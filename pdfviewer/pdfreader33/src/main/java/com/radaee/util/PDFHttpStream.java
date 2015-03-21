package com.radaee.util;

import java.io.File;
import java.io.InputStream;
import java.io.RandomAccessFile;
import java.net.HttpURLConnection;
import java.net.URL;

import android.os.Handler;
import android.os.Looper;
import android.os.Message;
import android.util.Log;

import com.radaee.pdf.Document.PDFStream;

/**
 * a class for HttpURLConnection.<br/>
 * the class read PDF file in remote way, this class not support write back to server.<br/>
 * the server must support Http header "Range" for request, and "content-length" for response.<br/>
 * and this class need Internet access right to run.
 * @author radaee
 */
public class PDFHttpStream implements PDFStream
{
	private static final int BLOCK_SIZE = 8192;
	private String m_url = null;
	private File m_tmp = null;
	private int m_total = 0;
	private RandomAccessFile m_cache = null;
	private HttpThread m_thread = null;
	private HttpDownloadThread m_thread2 = null;
	private int m_pos = 0;
	private int[] m_blocks_flag = null;
	
	private synchronized void write_cache( int off, byte[] data, int len )
	{
		try
		{
	    	m_cache.seek(off);
	    	m_cache.write(data, 0, len);
	    	int cur = off / BLOCK_SIZE;
	    	int end = (off + data.length + BLOCK_SIZE - 1) / BLOCK_SIZE;
			while( cur < end )
			{
				m_blocks_flag[cur] = 1;
				cur++;
			}
		}
		catch( Exception ex )
		{
		}
	}
	private synchronized int read_cache( int off, byte[] data )
	{
		try
		{
			if( off < m_total )
			{
				m_cache.seek(off);
				int ret = m_cache.read(data);
				return ret;
			}
			else return 0;
		}
		catch(Exception e)
		{
			return 0;
		}
	}
	private synchronized boolean download_blocks(int start, int end)
	{
		boolean ret = true;
		while( start < end )
		{
			while( start < end && m_blocks_flag[start] != 0 ) start++;
			int prev = start;
			while( start < end && m_blocks_flag[start] == 0 ) start++;
			if( start > prev )
			{
				int len = 0;
				int off = prev * BLOCK_SIZE;
			    len = m_total - off;
			    if( len > (start - prev) * BLOCK_SIZE )
			    	len = (start - prev) * BLOCK_SIZE;
	
				byte[] data = m_thread.read_range(this, off, len);
			    if(data != null)
			   	{
			    	try
			    	{
				    	m_cache.seek(off);
				    	m_cache.write(data);
			    		while( prev < start )
			    		{
			    			m_blocks_flag[prev] = 1;
			    			prev++;
			    		}
			    	}
			    	catch(Exception e)
			    	{
			    		ret = false;
			    	}
			    }
			    else
			    	ret = false;
			}
		}
		return ret;
	}

	protected class HttpDownloadThread extends Thread
	{
		private boolean m_run = false; 
		@Override
	    public void start()
		{
			m_run = true;
			super.start();
		}
		@Override
	    public void run()
		{
			try
			{
				URL url = new URL(m_url);
				HttpURLConnection conn = (HttpURLConnection)url.openConnection();
				conn.setRequestMethod("GET");
				conn.setRequestProperty("Connection", "Keep-Alive");
				conn.setConnectTimeout(30 * 1000);
				conn.connect();
				InputStream stream = conn.getInputStream();
				byte[] data = new byte[BLOCK_SIZE];
				int read = 0;
				int read_block = 0;
				int read_total = 0;
				while( read_total < m_total && m_run )
				{
					if( BLOCK_SIZE - read_block > m_total - read_total - read_block )
						read = stream.read(data, read_block, m_total - read_total - read_block);
					else
						read = stream.read(data, read_block, BLOCK_SIZE - read_block);
					if( read > 0 )
					{
						read_block += read;
						if( read_block == BLOCK_SIZE || read_total + read_block == m_total )
						{
							write_cache( read_total, data, read_block );
							read_total += read_block;
							read_block = 0;
						}
					}
				}
				stream.close();
				conn.disconnect();
			}
			catch(Exception e)
			{
				Log.d("Error", e.getMessage());
			}
		}
		public synchronized void destroy()
		{
			try
			{
				m_run = false;
				join();
			}
			catch(InterruptedException e)
			{
			}
		}
	}
	/**
	Inner class.<br/>
	developer should not use this.
	*/
	protected class HttpThread extends Thread
	{
		private Handler m_hand = null;
		private boolean is_notified = false;
		private boolean is_waitting = false;
		private class OP
		{
			PDFHttpStream stream;
			int para1;
			int para2;
			byte[] data;
		}
		private synchronized void wait_op()
		{
			try
			{
				if( is_notified )
					is_notified = false;
				else
				{
					is_waitting = true;
					wait();
					is_waitting = false;
				}
			}
			catch(Exception e)
			{
			}
		}
		private synchronized void notify_op()
		{
			if( is_waitting )
				notify();
			else
				is_notified = true;
		}
		
		@Override
	    public void start()
		{
			super.start();
			wait_op();
		}
		@Override
	    public void run()
		{
			Looper.prepare();
			m_hand = new Handler(Looper.myLooper())
			{
				public void handleMessage(Message msg)
				{
					if( msg != null )
					{
						if( msg.what == 0 )//get total size
						{
							OP op = (OP)msg.obj;
							op.para1 = op.stream.read_total_size();
							notify_op();
							super.handleMessage(msg);
						}
						else if( msg.what == 1 )
						{
							OP op = (OP)msg.obj;
							op.data = op.stream.read_range(op.para1, op.para2);
							notify_op();
							super.handleMessage(msg);
						}
						else if( msg.what == 100 )//quit
						{
							super.handleMessage(msg);
							getLooper().quit();
						}
						else
						{
							super.handleMessage(msg);
						}
					}
					else
						getLooper().quit();
				}
			};
			notify_op();
			Looper.loop();
		}
		public int get_size(PDFHttpStream stream)
		{
			OP op = new OP();
			op.stream = stream;
			m_hand.sendMessage(m_hand.obtainMessage(0, op));
			wait_op();
			return op.para1;
		}
		public byte[] read_range(PDFHttpStream stream, int start, int len)
		{
			OP op = new OP();
			op.stream = stream;
			op.para1 = start;
			op.para2 = len;
			m_hand.sendMessage(m_hand.obtainMessage(1, op));
			wait_op();
			return op.data;
		}
		public synchronized void destroy()
		{
			try
			{
				m_hand.sendEmptyMessage(100);
				join();
				m_hand = null;
			}
			catch(InterruptedException e)
			{
			}
		}
	}
	/**
	 * this method need http_header "content-length" for server.
	 * @return total size of PDF
	 */
	private int read_total_size()
	{
		try
		{
			URL url = new URL(m_url);
			HttpURLConnection conn = (HttpURLConnection)url.openConnection();
			conn.setRequestMethod("GET");
			conn.setRequestProperty("Connection", "Keep-Alive");
			conn.connect();
			int len = 0;
			try
			{
				len = conn.getContentLength();
			}
			catch(Exception e)
			{
				len = 0;
			}
			if( len <= 0 )
			{
				try
				{
					String slen = conn.getHeaderField("Content-Length");
					len = Integer.parseInt(slen);
				}
				catch(Exception e)
				{
					len = 0;
				}
			}
			//it's better to comment this line in release version.
			Log.d("Total Size:", String.valueOf(len) );
			conn.disconnect();
			return len;
		}
		catch(Exception e)
		{
			Log.d("Error", e.getMessage());
			return (int) 0;
		}
	}
	private byte[] read_range( int start, int len )
	{
		try
		{
			long time1 = System.currentTimeMillis();
			URL url = new URL(m_url);
			HttpURLConnection conn = (HttpURLConnection)url.openConnection();
			conn.setRequestMethod("GET");
			conn.setRequestProperty("Range", String.format("bytes=%d-%d", start, start + len - 1));
			conn.setRequestProperty("Connection", "Keep-Alive");
			conn.setConnectTimeout(30 * 1000);
			conn.connect();
			InputStream stream = conn.getInputStream();
			byte[] data = new byte[len];
			int read = 0;
			int read_total = 0;
			while( read_total < len )
			{
				read = stream.read(data, read_total, len - read_total);
				if( read > 0 ) read_total += read;
			}
			stream.close();
			conn.disconnect();
			long time2 = System.currentTimeMillis();
			//it's better to comment this line in release version.
			Log.d(String.format("Time:%06d %d", start/BLOCK_SIZE, len), String.valueOf(time2 - time1));
			return data;
		}
		catch(Exception e)
		{
			Log.d("Error", e.getMessage());
			return null;
		}
	}
	/**
	 * open an url as stream
	 * @param url url address.
	 * @return true or false.
	 */
	public boolean open(String url)
	{
		m_url = url;
		m_thread = new HttpThread();
		m_thread.start();
		try
		{
			m_total = m_thread.get_size(this);
			if( m_total <= 0 ) return false;
			m_tmp = File.createTempFile("RDTMP", ".dat");
			m_cache = new RandomAccessFile(m_tmp.getAbsolutePath(), "rw");
			m_cache.setLength(m_total);
			m_blocks_flag = new int[(m_total + BLOCK_SIZE - 1)/BLOCK_SIZE];
			
			m_thread2 = new HttpDownloadThread();//start back downloading thread.
			m_thread2.start();
			return true;
		}
		catch(Exception e)
		{
			Log.d("Error", e.getMessage());
			return false;
		}
	}
	/**
	 * free resources.<br/>
	 * this method is needed when APP close the PDF.
	 */
	public void close()
	{
		if( m_cache == null ) return;
		try
		{
			m_thread.destroy();
			m_thread2.destroy();
			m_cache.close();
			m_tmp.delete();
			m_thread = null;
			m_thread2 = null;
			m_cache = null;
			m_tmp = null;
		}
		catch(Exception e)
		{
		}
	}
	public boolean writeable()
	{
		return false;
	}
	public int get_size()
	{
		if( m_cache == null ) return 0;
		return m_total;
	}

	public int read(byte[] data)
	{
		if( m_cache == null ) return 0;
		int bstart = m_pos / BLOCK_SIZE;
		int bend = (m_pos + data.length + BLOCK_SIZE - 1)/BLOCK_SIZE;
		if( bend > m_blocks_flag.length ) bend = m_blocks_flag.length;
		int times = 3;
		while( times > 0 && !download_blocks(bstart,bend)) times--;
		if( times == 0 ) return 0;
		int ret = read_cache(m_pos, data);
		m_pos += ret;
		return ret;
	}
	public int write(byte[] data)
	{
		return 0;
	}
	public void seek(int pos)
	{
		if( m_cache == null ) return;
		if( pos < 0 ) pos = 0;
		if( pos > m_total ) pos = m_total;
		if( pos == m_pos ) return;
		m_pos = pos;
	}
	public int tell()
	{
		if( m_cache == null ) return 0;
		return m_pos;
	}
}

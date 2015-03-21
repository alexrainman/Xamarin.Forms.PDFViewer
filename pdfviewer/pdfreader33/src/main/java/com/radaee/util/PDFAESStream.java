package com.radaee.util;

import java.io.File;
import java.io.RandomAccessFile;

import javax.crypto.Cipher;
import javax.crypto.spec.IvParameterSpec;
import javax.crypto.spec.SecretKeySpec;

import android.util.Log;

import com.radaee.pdf.Document.PDFStream;

/**
 * class both support read and write for AES encryption
 * @author radaee
 */
public class PDFAESStream implements PDFStream
{
	static private int BLOCK_ENC_SIZE = 4096;
	static private int BLOCK_DEC_SIZE = BLOCK_ENC_SIZE-16;
	private RandomAccessFile m_file = null;
	private boolean m_writeable = false;
	private byte[] m_dec_block = null;
	private int m_dec_block_len = 0;
	private int m_dec_pos;
	private int m_dec_len;
	private int m_enc_len;
	private boolean m_flush = true;
	private Cipher m_dec_cipher = null;
	private Cipher m_enc_cipher = null;
	/**
	 * open or create a AES file stream.
	 * @param path file path to open or create
	 * @param key 16 bytes array for key.
	 * @return true or false.
	 */
	public boolean open( String path, byte[] key )
	{
		File file = new File(path);
		try
		{
			if( file.exists() && !file.isFile() ) return false;
			if( !file.exists() ) file.createNewFile();
			m_file = new RandomAccessFile( path, "rw" );
			m_enc_len = (int)m_file.length();
			if( m_enc_len > 0 )
			{
				m_file.seek(m_enc_len - 4);
				m_dec_len = m_file.readInt();
			}
			m_writeable = true;
		}
		catch( Exception e )
		{
			Log.e("o error", e.getMessage());
		}
		if( !m_writeable )
		{
			try
			{
				m_file = new RandomAccessFile( path, "r" );
				m_enc_len = (int)m_file.length();
				if( m_enc_len > 0 )
				{
					m_file.seek(m_enc_len - 4);
					m_dec_len = m_file.readInt();
				}
				m_writeable = false;
			}
			catch( Exception e )
			{
				Log.e("o error", e.getMessage());
				return false;
			}
		}
		try
		{
			SecretKeySpec skey = new SecretKeySpec(key, "AES");  
			byte[] ivbytes = new byte[]{0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
			IvParameterSpec iv = new IvParameterSpec(ivbytes);//need IV in CBC mode

			m_dec_cipher = Cipher.getInstance("AES/CBC/PKCS7Padding");
			m_dec_cipher.init(Cipher.DECRYPT_MODE, skey, iv);
			m_enc_cipher = Cipher.getInstance("AES/CBC/PKCS7Padding");
			m_enc_cipher.init(Cipher.ENCRYPT_MODE, skey, iv);
		}
		catch(Exception e)
		{
			Log.e("o error", e.getMessage());
			return false;
		}
		if( m_enc_len == 0 )
			m_dec_len = 0;
		else
		{
			if( m_enc_len % BLOCK_ENC_SIZE != 4 )
			{
				try
				{
					m_file.close();
				}
				catch(Exception e)
				{
				}
				return false;
			}
			m_dec_pos = 0;
			dec_block();
		}
		return true;
	}
	/**
	 * free memory and resource used.
	 */
	public void close()
	{
		if( !m_flush )
		{
			enc_block();
			m_flush = true;
		}
		if( m_file != null )
		{
			try
			{
				m_file.close();
			}
			catch(Exception e)
			{
			}
			m_file = null;
		}
    	m_enc_len = 0;
    	m_dec_len = 0;
    	m_dec_block = null;
    	m_dec_block_len = 0;
    	m_dec_pos = 0;
	}
	public boolean writeable()
	{
		return m_writeable;
	}

	public int get_size()
	{
		return m_dec_len;
	}

	public int read(byte[] data)
	{
		if( m_dec_block == null ) return 0;
		if( !m_flush )
		{
			enc_block();
			m_flush = true;
		}
		int off = m_dec_pos % BLOCK_DEC_SIZE;
		int total = data.length;
		if( m_dec_pos + total > m_dec_len )
			total = m_dec_len - m_dec_pos;
		int read = 0;
		while( read < total )
		{
			int len = m_dec_block_len - off;
			if( len > total - read ) len = total - read;
			System.arraycopy(m_dec_block, off, data, read, len);
			off = 0;
			m_dec_pos += len;
			read += len;
			if( m_dec_pos % BLOCK_DEC_SIZE == 0 )
				dec_block();
		}
		return read;
	}

	public int write(byte[] data)
	{
		if( !m_writeable ) return 0;
		int off = m_dec_pos % BLOCK_DEC_SIZE;
		int total = data.length;
		int written = 0;
		while( written < total )
		{
			if( m_dec_block == null ) m_dec_block = new byte[BLOCK_DEC_SIZE];
			int len = BLOCK_DEC_SIZE - off;
			if( len > total - written ) len = total - written;
			if( m_dec_block_len < off + len ) m_dec_block_len = off + len;
			System.arraycopy(data, written, m_dec_block, off, len);
			enc_block();
			off = 0;
			m_dec_pos += len;
			written += len;
			if( m_dec_pos % BLOCK_DEC_SIZE == 0 )
				dec_block();
		}
		if( m_dec_pos > m_dec_len )
		{
			m_dec_len = m_dec_pos;
			try
			{
				m_enc_len = (int)m_file.length();
				if( m_enc_len % BLOCK_ENC_SIZE == 4 )
					m_file.seek(m_enc_len - 4);
				else
					m_file.seek(m_enc_len);
				m_file.writeInt(m_dec_len);
				m_enc_len = (int)m_file.length();
			}
			catch(Exception e)
			{
			}
		}
		m_flush = (m_dec_pos % BLOCK_DEC_SIZE != 0);
		return written;
	}

	private boolean dec_block()
	{
		int block = m_dec_pos / BLOCK_DEC_SIZE;
		if( block < 0 || block * BLOCK_ENC_SIZE >= m_enc_len - 4 )
		{
			m_dec_block = null;
			m_dec_block_len = 0;
			return false;
		}
		try
		{
			int len = BLOCK_ENC_SIZE;
			if( (block + 1) * BLOCK_DEC_SIZE > m_dec_len )
				len = (m_dec_len - block * BLOCK_DEC_SIZE + 16)&(~15);//calculate padding length
			m_file.seek(block * BLOCK_ENC_SIZE);
			byte[] src = new byte[len];
			len = m_file.read(src);
			if( len <= 0 )
			{
				m_dec_block = null;
				m_dec_block_len = 0;
				return false;
			}
			src = m_dec_cipher.doFinal(src);
			m_dec_block_len = src.length;
			if( src.length == BLOCK_DEC_SIZE )
				m_dec_block = src;
			else
			{
				m_dec_block = new byte[BLOCK_DEC_SIZE];
				System.arraycopy(src, 0, m_dec_block, 0, src.length);
			}
			return true;
		}
		catch( Exception e )
		{
			Log.d("dec error", e.getMessage());
			m_dec_block = null;
			m_dec_block_len = 0;
			return false;
		}
	}
	private boolean enc_block()
	{
		int block = m_dec_pos / BLOCK_DEC_SIZE;
		try
		{
			byte[] data = m_enc_cipher.doFinal(m_dec_block, 0, m_dec_block_len);
			m_file.seek(block * BLOCK_ENC_SIZE);
			if( data.length != 4096 )
			{
				byte[] pad_data = new byte[4096];
				System.arraycopy(data, 0, pad_data, 0, data.length );
				m_file.write(pad_data);
			}
			else
				m_file.write(data);
			return true;
		}
		catch(Exception e)
		{
			Log.e("enc error", e.getMessage());
			return false;
		}
	}
	public void seek(int pos)
	{
		if( pos < 0 ) pos = 0;
		if( pos > m_dec_len ) pos = m_dec_len;
		if( !m_flush )
		{
			enc_block();
			m_flush = true;
		}
		int block_old = m_dec_pos / BLOCK_DEC_SIZE;
		int block_cur = pos / BLOCK_DEC_SIZE;
		m_dec_pos = pos;
		if( block_cur == block_old )
			return;
		dec_block();
	}
	public int tell()
	{
		return m_dec_pos;
	}
	/**
	 * clear all datas, and import PDF file, then save it as encrypted PDF file.
	 * @param path PDF file to encrypt.
	 * @return true or false.
	 */
	public boolean ImportFromFile(String path)
	{
        seek(0);
        try
        {
        	m_file.setLength(0);
        	m_enc_len = 0;
        	m_dec_len = 0;
        	m_dec_block = null;
        	m_dec_block_len = 0;
        	m_dec_pos = 0;
        	m_flush = true;
	        RandomAccessFile file = new RandomAccessFile(path, "r");
	        byte[] tmp = new byte[4096];
	        int read = 0;
	        while( (read = file.read(tmp)) > 0 )
	        {
	        	if( read != 4096 )
	        	{
	        		byte[] tmp1 = new byte[read];
	        		System.arraycopy(tmp, 0, tmp1, 0, read);
		        	write(tmp1);
	        	}
	        	else
	        		write(tmp);
	        }
	        file.close();
        }
        catch(Exception e)
        {
        	Log.e("w error", e.getMessage());
        	return false;
        }
        seek(0);
        return true;
	}
	public boolean ImportFromBuf(byte[] data)
	{
        seek(0);
        try
        {
        	m_file.setLength(0);
        }
        catch(Exception e)
        {
        }
    	m_enc_len = 0;
    	m_dec_len = 0;
    	m_dec_block = null;
    	m_dec_block_len = 0;
    	m_dec_pos = 0;
    	m_flush = true;
		write( data );
        seek(0);
        return true;
	}
	public boolean ExportToFile(String path)
	{
        seek(0);
        try
        {
        	File file1 = new File(path);
        	file1.deleteOnExit();
        	file1.createNewFile();
	        RandomAccessFile file = new RandomAccessFile(path, "rw");
	        byte[] tmp = new byte[4096];
	        int read = 0;
	        while( (read = read(tmp)) > 0 )
	        {
	        	file.write(tmp, 0, read);
	        }
	        file.close();
        }
        catch(Exception e)
        {
        	Log.e("w error", e.getMessage());
        	return false;
        }
        seek(0);
        return true;
	}
}

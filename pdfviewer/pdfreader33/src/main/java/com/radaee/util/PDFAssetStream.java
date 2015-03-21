package com.radaee.util;

import android.content.res.AssetManager;
import android.util.Log;
import com.radaee.pdf.Document.PDFStream;
import java.io.InputStream;

/**
 * Asset stream, an implement class for PDFStream, which used in Document.OpenStream
 * @author radaee
 */
public class PDFAssetStream implements PDFStream
{
	private InputStream m_stream;
	private int m_pos;
	private int m_len;
	public boolean open( AssetManager assets, String symbol )
	{
		try
		{
			m_stream = assets.open(symbol);
			seek(0x7FFFFFFF);
			m_len = m_pos;
			m_pos = 0;
			seek(0);
			return true;
		}
		catch( Exception e )
		{
			return false;
		}
	}
	public void close()
	{
		try
		{
			m_stream.close();
		}
		catch( Exception e )
		{
		}
		m_stream = null;
	}
	public boolean writeable()
	{
		return false;
	}
	public int get_size()
	{
		return m_len;
	}

	public int read(byte[] data)
	{
		try
		{
			int len = m_stream.read(data);
			if( len < 0 )
				return 0;
			else
			{
				m_pos += len;
				return len;
			}
		}
		catch( Exception e )
		{
			Log.d("read", e.getMessage());
			return 0;
		}
	}

	public int write(byte[] data)
	{
		return 0;
	}

	public void seek(int pos)
	{
		try
		{
			m_stream.reset();
			m_pos = (int)m_stream.skip(pos);
		}
		catch( Exception e )
		{
			if( e != null )
			{
				String err = e.getMessage();
				if( err != null )
					Log.d("seek", err);
			}
		}
	}

	public int tell()
	{
	    return m_pos;
	}
}

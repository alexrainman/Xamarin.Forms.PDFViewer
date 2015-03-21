package com.radaee.util;

import android.util.Log;

import com.radaee.pdf.Document;
import com.radaee.pdf.Document.PDFStream;
import java.io.RandomAccessFile;

/**
 * File stream, an implement class for PDFStream, which used in Document.OpenStream
 * @author radaee
 */
public class PDFFileStream implements PDFStream
{
	private RandomAccessFile m_impl;
	public boolean open( String path )
	{
		try
		{
			m_impl = new RandomAccessFile( path, "rw" );
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
			m_impl.close();
		}
		catch( Exception e )
		{
		}
		m_impl = null;
	}
	public boolean writeable()
	{
		return true;
	}
	public int get_size()
	{
		try
		{
			int len = (int)m_impl.length();
			if( len < 0 ) return 0;
			else return len;
		}
		catch( Exception e )
		{
			Log.d("get_size", e.getMessage());
			return 0;
		}
	}

	public int read(byte[] data)
	{
		try
		{
			int len = m_impl.read(data);
			if( len < 0 )
				return 0;
			else
				return len;
		}
		catch( Exception e )
		{
			Log.d("read", e.getMessage());
			return 0;
		}
	}

	public int write(byte[] data)
	{
		try
		{
			m_impl.write(data);
			return data.length;
		}
		catch( Exception e )
		{
			return 0;
		}
	}

	public void seek(int pos)
	{
		try
		{
			m_impl.seek(pos);
		}
		catch( Exception e )
		{
			Log.d("seek", e.getMessage());
		}
	}

	public int tell()
	{
		try
		{
			int pos = (int)m_impl.getFilePointer();
			if( pos < 0 ) return 0;
			else return pos;
		}
		catch( Exception e )
		{
			Log.d("tell", e.getMessage());
			return 0;
		}
	}
}

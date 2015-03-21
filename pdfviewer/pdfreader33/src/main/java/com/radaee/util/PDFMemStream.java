package com.radaee.util;

import com.radaee.pdf.Document.PDFStream;

public class PDFMemStream implements PDFStream
{
	private byte[] m_data;
	private int m_pos = 0;
	private int m_len = 0;
	public PDFMemStream(byte[] init_data)
	{
		m_data = init_data;
		m_pos = 0;
		if( init_data == null )
		{
			m_data = new byte[4096];
			m_len = 0;
		}
		else
			m_len = init_data.length;
	}
	public boolean writeable()
	{
		return true;
	}
	/**
	 * @return byte array for data<br/>
	 * do not use byte[].length to get size of stream, you shall invoke get_size method to get data length.
	 */
	public byte[] get_data()
	{
		return m_data;
	}
	public int get_size()
	{
		return m_len;
	}

	public int read(byte[] data)
	{
		if( data == null ) return 0;
		int len = data.length;
		if( len + m_pos > m_len )
			len = m_len - m_pos;
		System.arraycopy(m_data, m_pos, data, 0, len );
		m_pos += len;
		return len;
	}

	public int write(byte[] data)
	{
		if( data == null ) return 0;
		if( m_pos + data.length > m_data.length )
		{
			int new_len = (m_pos + data.length + 4096)&(~4095);
			byte[] new_data = new byte[new_len];
			System.arraycopy(m_data, 0, new_data, 0, m_len);
			System.arraycopy(data, 0, new_data, m_pos, data.length);
			m_data = new_data;
		}
		else
		{
			System.arraycopy(data, 0, m_data, m_pos, data.length);
		}
		m_pos += data.length;
		if( m_pos > m_len )
			m_len = m_pos;
		return data.length;
	}

	public void seek(int pos)
	{
		m_pos = pos;
	}

	public int tell()
	{
		return m_pos;
	}

}

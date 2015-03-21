package com.radaee.util;

import java.io.RandomAccessFile;

import javax.crypto.Cipher;
import javax.crypto.spec.IvParameterSpec;
import javax.crypto.spec.SecretKeySpec;

import android.util.Log;

import com.radaee.pdf.Document.PDFStream;

/**
 * a class to decrypt PDF file that encrypted by PDFAESEnc class<br/>
 * this is read-only for encrypted PDF file.
 * @author radaee
 */
public class PDFAESStreamOld implements PDFStream
{
	private class BlockEntry
	{
		int off;
		int len;
	}
	private RandomAccessFile m_impl = null;
	private BlockEntry[] m_entries = null;
	private Cipher m_cipher = null;
	private int m_total = 0;
	private int m_pos = 0;
	private int m_block_pos = 0;
	private byte[] m_block = null;
	/**
	 * open file, that encrypted by PDFAESEnc class
	 * @param filepath absolute file path
	 * @param key must be 16 bytes, 24 bytes, or 32 bytes.
	 * @return true or false.
	 */
	public boolean open(String filepath, byte[] key)
	{
		try
		{
			m_impl = new RandomAccessFile( filepath, "r" );
			//check header first
			byte[] header = new byte[8];
			m_impl.read(header);
			if( header[0] != 'R' || header[1] != 'D' || header[2] != 'A' || header[3] != 'E' || header[4] != 'S' )
			{
				m_impl.close();
				return false;
			}
			
			//load all sections.
			int secs_cnt = m_impl.readInt();
			m_total = m_impl.readInt();
			m_entries = new BlockEntry[secs_cnt];
			int cur = 0;
			while( cur < secs_cnt )
			{
				m_entries[cur] = new BlockEntry();
				m_entries[cur].off = m_impl.readInt();
				m_entries[cur].len = m_impl.readInt();
				cur++;
			}

			//init key and Cipher object
			SecretKeySpec skey = new SecretKeySpec(key, "AES");  
			m_cipher = Cipher.getInstance("AES/CBC/PKCS7Padding");
			byte[] ivbytes = new byte[]{0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
			IvParameterSpec iv = new IvParameterSpec(ivbytes);//need IV in CBC mode
            m_cipher.init(Cipher.DECRYPT_MODE, skey, iv);
            
            //decrypt first blocks.
			m_block = dec_block(0);
			return true;
		}
		catch(Exception e)
		{
			Log.d("error", e.getMessage());
			return false;
		}
	}
	/**
	 * free resources.<br/>
	 * this method is needed when APP close the PDF.
	 */
	public void close()
	{
		try
		{
			m_impl.close();
		}
		catch(Exception e)
		{
			Log.d("error", e.getMessage());
		}
	}
	private byte[] dec_block(int block)
	{
		if( block >= m_entries.length )
			return null;
		try
		{
			m_impl.seek(m_entries[block].off);
			byte[] src = new byte[m_entries[block].len];
			m_impl.read(src);
			return m_cipher.doFinal(src);
		}
		catch( Exception e )
		{
			Log.d("error", e.getMessage());
			return null;
		}
	}
	public boolean writeable()
	{
		return false;
	}

	public int get_size()
	{
		return m_total;
	}

	public int read(byte[] data)
	{
		if( m_block == null ) return 0;
		int dst_off = 0;
		int pos_old = m_pos;
		while( dst_off < data.length && m_pos < m_total )
		{
			int off = m_pos & 4095;
			while( off < m_block.length && dst_off < data.length )
			{
				data[dst_off] = m_block[off];
				dst_off++;
				off++;
			}
			seek(pos_old + dst_off);
		}
		return dst_off;
	}

	public int write(byte[] data)
	{
		return 0;
	}

	public void seek(int pos)
	{
		if( pos < 0 )
			pos = 0;
		if( pos > m_total )
			pos = m_total;
		int new_pos = pos;
		if( new_pos == m_pos ) return;
		int new_block_pos = new_pos/4096;
		if( new_block_pos == m_block_pos )
		{
			m_pos = new_pos;
		}
		else
		{
			m_block = dec_block(new_block_pos);
			m_pos = new_pos;
			m_block_pos = new_block_pos;
		}
	}

	public int tell()
	{
		return m_pos;
	}
}

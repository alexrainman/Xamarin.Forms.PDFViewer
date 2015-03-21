package com.radaee.util;
import java.io.File;
import java.io.FileInputStream;
import java.io.RandomAccessFile;

import javax.crypto.*;
import javax.crypto.spec.IvParameterSpec;
import javax.crypto.spec.SecretKeySpec;

/**
 * encrypt PDF file class.
 * @author radaee
 *
 */
public class PDFAESEncOld
{
	static private byte[] process_block( Cipher cipher, byte[] data, int len )
	{
		try
		{
			return cipher.doFinal(data, 0, len);
		}
		catch(Exception e)
		{
			return null;
		}
	}
	static private void write_int(byte[] data, int off, int val)
	{
		data[off + 3] = (byte)(val&0xFF);
		data[off + 2] = (byte)((val>>8)&0xFF);
		data[off + 1] = (byte)((val>>16)&0xFF);
		data[off + 0] = (byte)((val>>24)&0xFF);
	}
	/**
	 * encrypt PDF file
	 * @param src_file normal PDF file.
	 * @param dst_file encrypted PDF file.
	 * @param key key to encrypt, must 16 bytes, or 24 bytes, or 32 bytes
	 * @return true or false
	 */
	static public boolean encrypt( String src_file, String dst_file, byte[] key )
	{
		try
		{
			File ifile = new File(src_file);
			long total = ifile.length();
			int secs_cnt = (int)((total + 4095)/4096);
			byte[] header = new byte[(secs_cnt + 2) * 8];
			header[0] = 'R';
			header[1] = 'D';
			header[2] = 'A';
			header[3] = 'E';
			header[4] = 'S';
			header[5] = 0;
			header[6] = 0;
			header[7] = 0;
			write_int(header, 8, secs_cnt);
			write_int(header, 12, (int)total);

			FileInputStream is = new FileInputStream(new File(src_file));
			File ofile = new File(dst_file);
			ofile.createNewFile();
			RandomAccessFile os = new RandomAccessFile(dst_file, "rw");
			os.write(header);

			SecretKeySpec skey = new SecretKeySpec(key, "AES");  
			Cipher cipher = Cipher.getInstance("AES/CBC/PKCS7Padding");
			byte[] ivbytes = new byte[]{0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
			IvParameterSpec iv = new IvParameterSpec(ivbytes);//need IV in CBC mode
			cipher.init(Cipher.ENCRYPT_MODE, skey, iv);

			byte[] src = new byte[4096];
			int read = 0;
			int header_off = 16;
			int off = header.length;
			while( (read = is.read(src)) > 0 )
			{
				//there are some bytes for padding.
				//so, dst.length always great than src.length.
				byte[] dst = process_block(cipher, src, read);
				os.write(dst);
				int len = dst.length;
				write_int(header, header_off, off);
				write_int(header, header_off + 4, len);
				header_off += 8;
				off += len;
			}
			is.close();
			os.seek(0);
			os.write(header);
			os.close();
			return true;
		}
		catch(Exception e)
		{
			return false;
		}
	}
}

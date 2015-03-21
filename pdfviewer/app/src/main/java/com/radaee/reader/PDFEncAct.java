package com.radaee.reader;

import java.io.File;
import java.io.FileOutputStream;

import com.radaee.pdf.Document;
import com.radaee.pdf.Global;
import com.radaee.pdf.Matrix;
import com.radaee.pdf.Page;
import com.radaee.util.PDFAESEncOld;
import com.radaee.util.PDFAESStreamOld;

import android.app.Activity;
import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.graphics.Bitmap.Config;
import android.graphics.PixelFormat;
import android.os.Bundle;
import android.view.WindowManager;

public class PDFEncAct extends Activity
{
	private PDFAESStreamOld m_stream;
	private Document m_doc;
    private ReaderController m_vPDF = null;
	@Override
    public void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        Global.Init( this );
        
        //encrypt PDF file first
        //the key must 16 bytes long.
        byte[] key = new byte[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12,13,14,15,16};
        PDFAESEncOld.encrypt("/sdcard/src.pdf", "/sdcard/dst.pdf", key);

        //using PDFAESStream to decrypt PDF file.
        m_stream = new PDFAESStreamOld();
        if( !m_stream.open("/sdcard/dst.pdf", key) )
        	return;
        m_doc = new Document();
        int ret = m_doc.OpenStream(m_stream, null);
		switch( ret )
		{
		case -1://need input password
			finish();
			break;
		case -2://unknown encryption
			finish();
			break;
		case -3://damaged or invalid format
			finish();
			break;
		case -10://access denied or invalid file path
			finish();
			break;
		case 0://succeeded, and continue
			break;
		default://unknown error
			finish();
			break;
		}
		m_vPDF = new ReaderController(this);
		m_vPDF.open(m_doc);
        setContentView(m_vPDF);
	}
    protected void onDestroy()
    {
    	if( m_doc != null )
    	{
    		m_doc.Close();
    		m_doc = null;
    	}
    	if( m_stream != null )
    	{
    		m_stream.close();
    		m_stream = null;
    	}
    	Global.RemoveTmp();
    	super.onDestroy();
    }
}

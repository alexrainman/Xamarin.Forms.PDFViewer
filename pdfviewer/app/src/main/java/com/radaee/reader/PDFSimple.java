package com.radaee.reader;

import com.radaee.pdf.*;
import com.radaee.util.PDFFileStream;

import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.graphics.Bitmap.Config;
import android.util.AttributeSet;
import android.view.View;

/**
 * simplest PDF sample.
 * @author radaee
 */
public class PDFSimple extends View
{
	private Document m_doc = null;
	private PDFFileStream m_stream = null;
	private float m_ratio = 1;
	private int m_pageno = 0;
	private int win_cx = 0;
	private int win_cy = 0;
	private int page_x = 0;
	private int page_y = 0;
	private Bitmap bitmap = null;
	public PDFSimple(Context context)
	{
		super(context);
	}
	public PDFSimple(Context context, AttributeSet attrs)
	{
		super(context, attrs);
	}
	public void Close()
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
		if( bitmap != null )
		{
			bitmap.recycle();
			bitmap = null;
		}
	}
	private void render_page( int pageno )
	{
		if( m_doc != null && bitmap != null )
		{
			bitmap.eraseColor(0xFFFFFFFF);
			Page page = m_doc.GetPage(pageno);
			if( page != null )
			{
				Matrix mat = new Matrix(m_ratio, -m_ratio, 0, m_doc.GetPageHeight(0) * m_ratio);
				page.RenderToBmp(bitmap, mat);
				/*
				int cnt = page.GetAnnotCount();
				for(int x = 0; x < cnt; ++x)
				{
					int handle = page.GetAnnot(x);
					int type = page.GetAnnotFieldType(handle);
					if( type == 4 )
					{
						Toast.makeText(getContext(), "Signature Found", Toast.LENGTH_SHORT).show();
					}
				}
				*/
				mat.Destroy();
				page.Close();
			}
			/*
			 * Page page = m_doc.GetPage(pageno); if( page != null ) { Matrix
			 * mat = new Matrix(m_ratio, -m_ratio, 0, m_doc.GetPageHeight(0) *
			 * m_ratio); page.RenderToBmp(bitmap, mat); float rect[] = new
			 * float[4]; rect[0] = 100; rect[1] = 80; rect[2] = rect[0] + 100;
			 * rect[3] = rect[1] + 20; page.AddAnnotEditbox(mat, rect, 18, 0);
			 * mat.Destroy(); page.Close(); m_doc.Save(); }
			 */
		}
	}
	public int Open( String path )
	{
		Close();
		m_doc = new Document();
		m_stream = new PDFFileStream();
		boolean ok = m_stream.open(path);
		if( !ok ) return -1;
		int ret = m_doc.OpenStream(m_stream, null);
		if( ret != 0 )
		{
			m_doc.Close();
			m_doc = null;
			return ret;
		}
		onSizeChanged(win_cx, win_cy, 0, 0);
		return 0;
	}
	protected void onSizeChanged (int w, int h, int oldw, int oldh)
	{
		if( w > 0 && h > 0 )
		{
			win_cx = w;
			win_cy = h;
			if( bitmap != null ) bitmap.recycle();
			bitmap = Bitmap.createBitmap(win_cx, win_cy, Config.ARGB_8888);
			render_page(m_pageno);
		}
	}
	protected void onDraw( Canvas canvas )
	{
		if( bitmap != null )
			canvas.drawBitmap(bitmap, page_x, page_y, null);
	}
}

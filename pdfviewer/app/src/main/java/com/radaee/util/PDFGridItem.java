package com.radaee.util;

import com.radaee.pdf.Document;
import com.radaee.pdf.Matrix;
import com.radaee.pdf.Page;
import com.radaee.reader.R;

import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Canvas;
import android.graphics.Paint;
import android.util.AttributeSet;
import android.view.Gravity;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;

public class PDFGridItem extends LinearLayout
{
	private ImageView m_image;
	private TextView m_name;
	private String m_path;
	private Bitmap m_bmp;
	private Page m_page;
	private boolean m_cancel = false;
	static Bitmap m_def_pdf_icon = null;
	static Bitmap m_def_dir_icon = null;
	static Bitmap m_def_up_icon = null;
	static Bitmap m_def_refresh_icon = null;
	static int TEXT_COLOR = 0xFFCCCCCC;
	public PDFGridItem(Context context, AttributeSet attrs)
	{
		super(context, attrs);
		if( m_def_pdf_icon == null )
			m_def_pdf_icon = BitmapFactory.decodeResource(context.getResources(), R.drawable.file03);
		if( m_def_dir_icon == null )
			m_def_dir_icon = BitmapFactory.decodeResource(context.getResources(), R.drawable.folder0);
		if( m_def_up_icon == null )
			m_def_up_icon = BitmapFactory.decodeResource(context.getResources(), R.drawable.folder1);
		if( m_def_refresh_icon == null )
			m_def_refresh_icon = BitmapFactory.decodeResource(context.getResources(), R.drawable.folder2);
		this.setBackgroundColor(0);
		this.setOrientation(VERTICAL);
		unlock_file();
	}
	public int open_doc( Document doc, String password )
	{
		lock_file();
		int ret = doc.Open(m_path, password);
		unlock_file();
		return ret;
	}
	public boolean is_dir()
	{
		return (m_bmp == m_def_dir_icon || m_bmp == m_def_up_icon || m_bmp == m_def_refresh_icon);
	}
	public String get_name()
	{
		return (String) m_name.getText();
	}
	protected synchronized void page_set()
	{
		this.removeAllViews();
		m_image = new ImageView(getContext());
		m_image.setImageBitmap(m_bmp);
		m_image.setPadding(2, 2, 2, 2);
		this.addView(m_image);
		this.addView(m_name);
	}
	protected synchronized void page_destroy()
	{
		m_cancel = true;
		if( m_page != null )
			m_page.RenderCancel();
		if( m_bmp != m_def_pdf_icon && m_bmp != m_def_dir_icon && m_bmp != m_def_up_icon && m_bmp != m_def_refresh_icon && m_bmp != null )
		{
			m_bmp.recycle();
			m_bmp = null;
		}
	}
	protected void set_dir( String name, String path )
	{
		m_path = path;
		m_name = new TextView(getContext());
		m_name.setText(name);
		m_name.setSingleLine(true);
		m_name.setGravity(Gravity.CENTER_HORIZONTAL);
		m_name.setTextColor(TEXT_COLOR);
		m_image = new ImageView(getContext());
		if( name == "." )
			m_bmp = m_def_refresh_icon;
		else if( name == ".." )
			m_bmp = m_def_up_icon;
		else
			m_bmp = m_def_dir_icon;
		m_image.setImageBitmap(m_bmp);
		m_image.setPadding(2, 2, 2, 2);
		this.addView(m_image);
		this.addView(m_name);
	}
	protected void set_file( PDFGridThread thread, String name, String path )
	{
		m_path = path;
		m_name = new TextView(getContext());
		m_name.setText(name);
		m_name.setSingleLine(true);
		m_name.setGravity(Gravity.CENTER_HORIZONTAL);
		m_name.setTextColor(TEXT_COLOR);
		m_image = new ImageView(getContext());
		m_bmp = m_def_pdf_icon;
		m_image.setImageBitmap(m_bmp);
		m_image.setPadding(2, 2, 2, 2);
		this.addView(m_image);
		this.addView(m_name);
		thread.start_render( this );
	}
	private synchronized void set_page(Page page, Bitmap bmp)
	{
		m_page = page;
		if( bmp != null ) m_bmp = bmp;
	}
	protected boolean render()
	{
		if( m_cancel ) return false;
		lock_file();
		Document doc = new Document();
		if( doc.Open(m_path, null) == 0 )
		{
			Page page = doc.GetPage(0);
			set_page( page, null );
			float w = doc.GetPageWidth(0);
			float h = doc.GetPageHeight(0);
			int iw = m_bmp.getWidth();
			int ih = m_bmp.getHeight();
			Bitmap bmp = null;
			try
			{
				bmp = Bitmap.createBitmap( iw, ih, Bitmap.Config.ARGB_8888 );
				bmp.eraseColor(0);
				float ratiox = iw/w;
				float ratioy = ih/h;
				if( ratiox > ratioy ) ratiox = ratioy;
				if( !page.RenderThumb(bmp) )
				{
					Canvas canvas = new Canvas(bmp);
					Paint paint = new Paint();
					paint.setARGB(255, 255, 255, 255);
					canvas.drawRect((iw - w * ratiox)/2, (ih - h * ratiox)/2,
							(iw + w * ratiox)/2, (ih + h * ratiox)/2, paint);
					Matrix mat = new Matrix( ratiox, -ratiox, (iw - w * ratiox)/2, (ih + h * ratiox)/2 );
					page.RenderToBmp(bmp, mat);
					mat.Destroy();
					if( !m_page.RenderIsFinished() )
					{
						bmp.recycle();
						bmp = null;
					}
				}
				set_page( null, bmp );
			}
			catch(Exception e)
			{
			}
			page.Close();
			doc.Close();
			unlock_file();
			return bmp != null;
		}
		else
		{
			unlock_file();
			return false;
		}
	}
	private boolean is_notified = false;
	private boolean is_waitting = false;
	private synchronized void lock_file()
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
	private synchronized void unlock_file()
	{
		if( is_waitting )
			notify();
		else
			is_notified = true;
	}
}

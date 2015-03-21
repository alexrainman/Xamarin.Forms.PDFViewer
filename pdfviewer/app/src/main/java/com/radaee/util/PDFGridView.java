package com.radaee.util;

import java.io.File;

import android.content.Context;
import android.content.res.Configuration;
import android.util.AttributeSet;
import android.widget.GridView;

public class PDFGridView extends GridView
{
	private PDFGridAdt m_adt;
	private String m_root;
	private String m_cur;
	public PDFGridView(Context context, AttributeSet attrs)
	{
		super(context, attrs);
		m_adt = new PDFGridAdt(context);
		this.setNumColumns(4);
		this.setBackgroundColor(0xFF444444);
		this.setAdapter(m_adt);
	}
	public void PDFSetRootPath(String path)
	{
		m_root = path;
		m_cur = path;
		File root = new File( m_cur );
		if( root.exists() && root.isDirectory() )
			m_adt.set_dir(root, false);
	}
	public void PDFGotoSubdir(String name)
	{
		String new_path = m_cur;
		if( name == "." )
		{
		}
		else if( name == ".." )
		{
			int index = m_cur.lastIndexOf('/');
			if( index < 0 ) return;
			new_path = new_path.substring(0, index);
		}
		else
		{
			new_path += "/";
			new_path += name;
		}
		File dir = new File( new_path );
		if( dir.exists() && dir.isDirectory() )
		{
			m_adt.notifyDataSetInvalidated();
			m_cur = new_path;
			m_adt.set_dir(dir, m_cur.compareTo(m_root) != 0);
		}
	}
	public void close()
	{
		m_adt.destroy();
	}
	public String getPath() {
	    return m_cur;	    
	}
	
	@Override
	public void onConfigurationChanged(Configuration newConfig)
	{
	    super.onConfigurationChanged(newConfig);
	    if (newConfig.orientation == Configuration.ORIENTATION_PORTRAIT)
	    {
	        setNumColumns(4);
	    }
	    else if (newConfig.orientation == Configuration.ORIENTATION_LANDSCAPE)
	    {
	        setNumColumns(5);
	    }
	}
	
	/*protected void onSizeChanged (int w, int h, int oldw, int oldh)
	{
		if( w * 3 > h * 5 )
			this.setNumColumns(5);
		else if( w * 3 < h * 4 )
			this.setNumColumns(4);
		else
			this.setNumColumns(3);
		this.invalidate();
	}*/
}

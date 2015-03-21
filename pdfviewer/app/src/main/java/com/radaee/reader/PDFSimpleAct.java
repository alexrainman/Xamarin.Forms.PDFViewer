package com.radaee.reader;

import com.radaee.pdf.*;
import com.radaee.util.SnatchView;

import android.app.Activity;
import android.graphics.PixelFormat;
import android.os.Bundle;
import android.view.View;
import android.view.WindowManager;
import android.widget.ExpandableListView;
import android.widget.ExpandableListView.OnChildClickListener;

/**
 * test activity for PDFSimple
 * @author Radaee
 */
public class PDFSimpleAct extends Activity implements OnChildClickListener
{
	private PDFSimple m_vPDF = null;
	private SnatchView m_vFiles = null;

    /** Called when the activity is first created. */
	@Override
    public void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        Global.Init( this );
		m_vFiles = new SnatchView(this);
		m_vFiles.setOnChildClickListener(this);
		m_vFiles.start();
		m_vPDF = new PDFSimple(this);
		setContentView(m_vFiles);
    }
	@Override
    protected void onDestroy()
    {
    	if( m_vPDF != null )
    		m_vPDF.Close();
    	Global.RemoveTmp();
    	super.onDestroy();
    }
	public boolean onChildClick(ExpandableListView parent, View v,
			int groupPosition, int childPosition, long id)
	{
		String val = m_vFiles.getChildPath(groupPosition, childPosition);
		/*
		Document doc = new Document();
		doc.Open(val, null);
		int cnt = doc.GetPageCount();
		int cur = 0;
		for( cur = 0; cur < cnt; cur++ )
		{
			Page page = doc.GetPage(cur);
			page.ObjsStart();
			int ccnt = page.ObjsGetCharCount();
			String texts = page.ObjsGetString(0, ccnt);
			page.Close();
		}
		doc.Close();
		*/
		
		if( val != null )
		{
			m_vPDF.Close();
			//to open encrypted document, modify codes below:
			int ret = m_vPDF.Open(val);
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
            setContentView(m_vPDF);
		}
		return false;
	}
}
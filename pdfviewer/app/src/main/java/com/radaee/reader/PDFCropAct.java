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
import android.widget.Toast;

/**
 * test activity for PDFCrop
 * @author Radaee
 */
public class PDFCropAct extends Activity implements OnChildClickListener
{
	private Document m_doc = new Document();
	private PDFCrop m_vPDF = null;
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
		m_vPDF = new PDFCrop(this);
		setContentView(m_vFiles);
    }
    protected void onDestroy()
    {
    	if( m_vPDF != null )
    		m_vPDF.close();
    	Global.RemoveTmp();
    	super.onDestroy();
    }
	public boolean onChildClick(ExpandableListView parent, View v,
			int groupPosition, int childPosition, long id)
	{
		String val = m_vFiles.getChildPath(groupPosition, childPosition);
		if( val != null )
		{
			m_doc.Close();
			//to open encrypted document, modify codes below:
			int ret = m_doc.Open(val, "");
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
            String msg = "file name:" + val;
            msg += "\nversion:";
            msg += m_doc.GetMeta("ver");//PDF-1.X
            msg += "\npage count:";
            msg += String.format("%d", m_doc.GetPageCount());
            msg += "\n";
            msg += "\nTitle:";
            msg += m_doc.GetMeta("Title");
            msg += "\nAuthor:";
            msg += m_doc.GetMeta("Author");
            msg += "\nCreator:";
            msg += m_doc.GetMeta("Producer");
            msg += "\nProducer:";
            msg += m_doc.GetMeta("Creator");
            Toast toast = Toast.makeText(this, msg, Toast.LENGTH_LONG);
            toast.show();
            m_vPDF.open(m_doc);
            setContentView(m_vPDF);
		}
		return false;
	}
}
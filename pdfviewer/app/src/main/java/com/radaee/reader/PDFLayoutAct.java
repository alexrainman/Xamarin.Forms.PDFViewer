package com.radaee.reader;

import com.radaee.reader.R;
import com.radaee.pdf.Document;
import com.radaee.pdf.Global;
import com.radaee.pdf.Page;
import com.radaee.pdf.Page.Annotation;
import com.radaee.reader.PDFLayoutView.PDFLayoutListener;
import com.radaee.util.PDFGridItem;
import com.radaee.util.PDFGridView;
import com.radaee.view.VPage;
import android.annotation.SuppressLint;
import android.app.Activity;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.graphics.PixelFormat;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.RadioGroup;
import android.widget.RelativeLayout;
import android.widget.Toast;
import android.widget.AdapterView.OnItemClickListener;

public class PDFLayoutAct extends Activity implements OnClickListener, OnItemClickListener, PDFLayoutListener
{
	private PDFGridView m_vFiles = null;
	private Document m_doc = new Document();
	private boolean m_set = false;
	private RelativeLayout m_layout;
	private PDFLayoutView m_view = null;
    private Button btn_ink;
    private Button btn_rect;
    private Button btn_oval;
    private Button btn_note;
    private Button btn_line;
    private Button btn_stamp;
    private Button btn_cancel;
    private Button btn_save;
    private Button btn_close;

    private Button btn_sel;
    private Button btn_act;
    private Button btn_edit;
    private Button btn_remove;
    
    private Button btn_prev;
    private Button btn_next;
    private EditText txt_find;
    private String str_find;
	@Override
    public void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        getWindow().setFormat(PixelFormat.RGBA_8888);
        Global.Init( this );
		m_layout = (RelativeLayout)LayoutInflater.from(this).inflate(R.layout.pdf_layout, null);
		m_view = (PDFLayoutView)m_layout.findViewById(R.id.view);
        LinearLayout bar_cmd = (LinearLayout)m_layout.findViewById(R.id.bar_cmd);
        LinearLayout bar_act = (LinearLayout)m_layout.findViewById(R.id.bar_act);
        LinearLayout bar_find = (LinearLayout)m_layout.findViewById(R.id.bar_find);
        btn_ink = (Button)bar_cmd.findViewById(R.id.btn_ink);
        btn_rect = (Button)bar_cmd.findViewById(R.id.btn_rect);
        btn_oval = (Button)bar_cmd.findViewById(R.id.btn_oval);
        btn_note = (Button)bar_cmd.findViewById(R.id.btn_note);
        btn_line = (Button)bar_cmd.findViewById(R.id.btn_line);
        btn_stamp = (Button)bar_cmd.findViewById(R.id.btn_stamp);
        btn_cancel = (Button)bar_cmd.findViewById(R.id.btn_cancel);
        btn_save = (Button)bar_cmd.findViewById(R.id.btn_save);
        btn_close = (Button)bar_cmd.findViewById(R.id.btn_close);

        btn_sel = (Button)bar_act.findViewById(R.id.btn_sel);
        btn_act = (Button)bar_act.findViewById(R.id.btn_act);
        btn_edit = (Button)bar_act.findViewById(R.id.btn_edit);
        btn_remove = (Button)bar_act.findViewById(R.id.btn_remove);
        
        txt_find = (EditText)bar_find.findViewById(R.id.txt_find);
        btn_prev = (Button)bar_find.findViewById(R.id.btn_prev);
        btn_next = (Button)bar_find.findViewById(R.id.btn_next);

        btn_sel.setOnClickListener(this);
        btn_act.setOnClickListener(this);
        btn_edit.setOnClickListener(this);
        btn_remove.setOnClickListener(this);
 
        btn_ink.setOnClickListener(this);
        btn_rect.setOnClickListener(this);
        btn_oval.setOnClickListener(this);
        btn_note.setOnClickListener(this);
        btn_line.setOnClickListener(this);
        btn_stamp.setOnClickListener(this);
        btn_cancel.setOnClickListener(this);
        btn_save.setOnClickListener(this);
        btn_close.setOnClickListener(this);

        btn_prev.setOnClickListener(this);
        btn_next.setOnClickListener(this);

        btn_act.setEnabled(false);
        btn_save.setEnabled(false);
        btn_edit.setEnabled(false);
        btn_remove.setEnabled(false);
        
        btn_cancel.setEnabled(false);

        m_vFiles = new PDFGridView(this, null);
		m_vFiles.PDFSetRootPath("/mnt");
		m_vFiles.setOnItemClickListener(this);
		setContentView(m_vFiles);
    }
	@Override
    protected void onDestroy()
    {
    	//m_vFiles.close();
    	if( m_vFiles != null )
    	{
    		m_vFiles.close();
    		m_vFiles = null;
    	}
    	if( m_view != null )
    	{
    		m_view.PDFClose();
    		m_view = null;
    	}
    	if( m_doc != null )
    	{
    		m_doc.Close();
    	}
    	Global.RemoveTmp();
    	super.onDestroy();
    }
    private void InitView()
    {
		m_doc.SetCache( Global.tmp_path + "/temp.dat" );//set temporary cache for editing.
		//test font delegate
		//m_doc.SetFontDel(new MyFontDelegate());
		//byte[] sign_contents = m_doc.GetSignContents();
		//if( sign_contents != null )
		//{
		//}
		
		m_view.PDFOpen(m_doc, this);
		//m_reader.PDFGotoPage(10);
		setContentView(m_layout);
    }
    private void InputPassword(PDFGridItem item)
    {
		LinearLayout layout = (LinearLayout)LayoutInflater.from(this).inflate(R.layout.dlg_password, null);
		final EditText tpassword = (EditText)layout.findViewById(R.id.txt_password);
		final PDFGridItem gitem = item;

		AlertDialog.Builder builder = new AlertDialog.Builder(this);
		builder.setPositiveButton("OK", new DialogInterface.OnClickListener(){
			public void onClick(DialogInterface dialog, int which)
			{
				String password = tpassword.getText().toString();
				m_doc.Close();
				int ret = gitem.open_doc(m_doc, password);
				switch( ret )
				{
				case -1://need input password
					InputPassword(gitem);
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
					InitView();
					break;
				default://unknown error
					finish();
					break;
				}
			}});
		builder.setNegativeButton("Cancel", new DialogInterface.OnClickListener(){
			public void onClick(DialogInterface dialog, int which)
			{
				dialog.dismiss();
			}});
		builder.setTitle("Input Password");
		builder.setCancelable(false);
		builder.setView(layout);
		
		AlertDialog dlg = builder.create();
		dlg.show();
    }
	public void onItemClick(AdapterView<?> arg0, View arg1, int arg2, long arg3)
	{
		if( arg0 == m_vFiles )
		{
			PDFGridItem item = (PDFGridItem)arg1;
			if( item.is_dir() )
			{
				m_vFiles.PDFGotoSubdir(item.get_name());
			}
			else
			{
				m_doc.Close();
				int ret = item.open_doc(m_doc, null);
				switch( ret )
				{
				case -1://need input password
					InputPassword(item);
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
					InitView();
					break;
				default://unknown error
					finish();
					break;
				}
			}
		}
		else
		{
		}
	}
	private void onSelect()
	{
		m_set = !m_set;
		m_view.PDFSetSelect();
		btn_ink.setEnabled(!m_set && m_doc.CanSave());
		btn_rect.setEnabled(!m_set && m_doc.CanSave());
		btn_oval.setEnabled(!m_set && m_doc.CanSave());
		btn_note.setEnabled(!m_set && m_doc.CanSave());
		btn_line.setEnabled(!m_set && m_doc.CanSave());
		btn_stamp.setEnabled(!m_set && m_doc.CanSave());
		btn_cancel.setEnabled(false);

		btn_sel.setPressed(m_set);
        btn_act.setEnabled(false);
		btn_edit.setEnabled(false);
		btn_remove.setEnabled(false);
	}
	private void onInk()
	{
		m_set = !m_set;
		if( m_set )
			m_view.PDFSetInk(0);
		else
			m_view.PDFSetInk(1);
		btn_ink.setPressed(m_set && m_doc.CanSave());
		btn_rect.setEnabled(!m_set && m_doc.CanSave());
		btn_oval.setEnabled(!m_set && m_doc.CanSave());
		btn_note.setEnabled(!m_set && m_doc.CanSave());
		btn_line.setEnabled(!m_set && m_doc.CanSave());
		btn_stamp.setEnabled(!m_set && m_doc.CanSave());
		btn_cancel.setEnabled(m_set && m_doc.CanSave());
        btn_save.setEnabled(!m_set && m_doc.CanSave());

		btn_sel.setEnabled(!m_set);
        btn_act.setEnabled(!m_set);
		btn_edit.setEnabled(!m_set);
		btn_remove.setEnabled(!m_set);

        btn_prev.setEnabled(!m_set);
        btn_next.setEnabled(!m_set);
        txt_find.setEnabled(!m_set);
	}
	private void onRect()
	{
		m_set = !m_set;
		if( m_set )
			m_view.PDFSetRect(0);
		else
			m_view.PDFSetRect(1);
		btn_ink.setEnabled(!m_set && m_doc.CanSave());
		btn_rect.setPressed(m_set && m_doc.CanSave());
		btn_oval.setEnabled(!m_set && m_doc.CanSave());
		btn_note.setEnabled(!m_set && m_doc.CanSave());
		btn_line.setEnabled(!m_set && m_doc.CanSave());
		btn_stamp.setEnabled(!m_set && m_doc.CanSave());
		btn_cancel.setEnabled(m_set);
        btn_save.setEnabled(!m_set);

		btn_sel.setEnabled(!m_set);
        btn_act.setEnabled(!m_set);
		btn_edit.setEnabled(!m_set && m_doc.CanSave());
		btn_remove.setEnabled(!m_set && m_doc.CanSave());

        btn_prev.setEnabled(!m_set);
        btn_next.setEnabled(!m_set);
        txt_find.setEnabled(!m_set);
	}
	private void onOval()
	{
		m_set = !m_set;
		if( m_set )
			m_view.PDFSetEllipse(0);
		else
			m_view.PDFSetEllipse(1);
		btn_ink.setEnabled(!m_set && m_doc.CanSave());
		btn_rect.setEnabled(!m_set && m_doc.CanSave());
		btn_oval.setPressed(m_set && m_doc.CanSave());
		btn_note.setEnabled(!m_set && m_doc.CanSave());
		btn_line.setEnabled(!m_set && m_doc.CanSave());
		btn_stamp.setEnabled(!m_set && m_doc.CanSave());
		btn_cancel.setEnabled(m_set);
        btn_save.setEnabled(!m_set);

		btn_sel.setEnabled(!m_set);
        btn_act.setEnabled(!m_set);
		btn_edit.setEnabled(!m_set && m_doc.CanSave());
		btn_remove.setEnabled(!m_set && m_doc.CanSave());

        btn_prev.setEnabled(!m_set);
        btn_next.setEnabled(!m_set);
        txt_find.setEnabled(!m_set);
	}
	private void onNote()
	{
		m_view.PDFSetNote();
		m_set = !m_set;
		btn_ink.setEnabled(!m_set && m_doc.CanSave());
		btn_rect.setEnabled(!m_set && m_doc.CanSave());
		btn_oval.setEnabled(!m_set && m_doc.CanSave());
		btn_note.setPressed(m_set && m_doc.CanSave());
		btn_line.setEnabled(!m_set && m_doc.CanSave());
		btn_stamp.setEnabled(!m_set && m_doc.CanSave());
		btn_cancel.setEnabled(false);

		btn_sel.setEnabled(!m_set);
        btn_act.setEnabled(!m_set);
		btn_edit.setEnabled(!m_set && m_doc.CanSave());
		btn_remove.setEnabled(!m_set && m_doc.CanSave());
	}
	private void onLine()
	{
		m_set = !m_set;
		if( m_set )
			m_view.PDFSetLine(0);
		else
			m_view.PDFSetLine(1);
		btn_ink.setEnabled(!m_set && m_doc.CanSave());
		btn_rect.setEnabled(!m_set && m_doc.CanSave());
		btn_oval.setEnabled(!m_set && m_doc.CanSave());
		btn_note.setEnabled(!m_set && m_doc.CanSave());
		btn_line.setPressed(m_set && m_doc.CanSave());
		btn_stamp.setEnabled(!m_set && m_doc.CanSave());
		btn_cancel.setEnabled(m_set);
        btn_save.setEnabled(!m_set);

		btn_sel.setEnabled(!m_set);
        btn_act.setEnabled(!m_set);
		btn_edit.setEnabled(!m_set && m_doc.CanSave());
		btn_remove.setEnabled(!m_set && m_doc.CanSave());
	}
	private void onStamp()
	{
		m_set = !m_set;
		if( m_set )
			m_view.PDFSetStamp(0);
		else
			m_view.PDFSetStamp(1);
		btn_ink.setEnabled(!m_set && m_doc.CanSave());
		btn_rect.setEnabled(!m_set && m_doc.CanSave());
		btn_oval.setEnabled(!m_set && m_doc.CanSave());
		btn_note.setEnabled(!m_set && m_doc.CanSave());
		btn_line.setEnabled(!m_set && m_doc.CanSave());
		btn_stamp.setPressed(m_set && m_doc.CanSave());
		btn_cancel.setEnabled(m_set);
        btn_save.setEnabled(!m_set);

		btn_sel.setEnabled(!m_set);
        btn_act.setEnabled(!m_set);
		btn_edit.setEnabled(!m_set && m_doc.CanSave());
		btn_remove.setEnabled(!m_set && m_doc.CanSave());
	}
	private void onCancel()
	{
		m_view.PDFCancel();
		m_set = false;
		btn_ink.setEnabled(m_doc.CanSave());
		btn_rect.setEnabled(m_doc.CanSave());
		btn_oval.setEnabled(m_doc.CanSave());
		btn_note.setEnabled(m_doc.CanSave());
		btn_line.setEnabled(m_doc.CanSave());
		btn_stamp.setEnabled(m_doc.CanSave());
		btn_cancel.setEnabled(false);
        btn_save.setEnabled(true);

		btn_sel.setEnabled(true);
        btn_act.setEnabled(true);
		btn_edit.setEnabled(m_doc.CanSave());
		btn_remove.setEnabled(m_doc.CanSave());

        btn_prev.setEnabled(true);
        btn_next.setEnabled(true);
        txt_find.setEnabled(true);
	}
	private void onFindPrev()
	{
		String str = txt_find.getText().toString();
		if( str_find != null )
		{
			if( str != null && str.compareTo(str_find) == 0 )
			{
				m_view.PDFFind(-1);
				return;
			}
		}
		if( str != null && str.length() > 0 )
		{
			m_view.PDFFindStart(str, false, false);
			m_view.PDFFind(1);
			str_find = str;
		}
	}
	private void onFindNext()
	{
		String str = txt_find.getText().toString();
		if( str_find != null )
		{
			if( str != null && str.compareTo(str_find) == 0 )
			{
				m_view.PDFFind(1);
				return;
			}
		}
		if( str != null && str.length() > 0 )
		{
			m_view.PDFFindStart(str, false, false);
			m_view.PDFFind(1);
			str_find = str;
		}
	}
	private void onEdit()
	{
		LinearLayout layout = (LinearLayout)LayoutInflater.from(this).inflate(R.layout.dlg_note, null);
		final EditText subj = (EditText)layout.findViewById(R.id.txt_subj);
		final EditText content = (EditText)layout.findViewById(R.id.txt_content);
		Page page = null;
		if( m_annot_vpage != null )
			page = m_doc.GetPage(m_annot_vpage.GetPageNo());
		if( page == null ) return;
		page.Close();
		AlertDialog.Builder builder = new AlertDialog.Builder(this);
		builder.setPositiveButton("OK", new DialogInterface.OnClickListener(){
			public void onClick(DialogInterface dialog, int which)
			{
				String str_subj = subj.getText().toString();
				String str_content = content.getText().toString();
				m_annot.SetPopupSubject(str_subj);
				m_annot.SetPopupText(str_content);
				dialog.dismiss();
				m_view.PDFEndAnnot();
				m_set = false;
				btn_ink.setEnabled(m_doc.CanSave());
				btn_rect.setEnabled(m_doc.CanSave());
				btn_oval.setEnabled(m_doc.CanSave());
				btn_note.setEnabled(m_doc.CanSave());
				btn_line.setEnabled(m_doc.CanSave());
				btn_stamp.setEnabled(m_doc.CanSave());
				btn_cancel.setEnabled(false);
		        btn_save.setEnabled(true);

				btn_sel.setEnabled(true);
		        btn_act.setEnabled(false);
				btn_edit.setEnabled(false);
				btn_remove.setEnabled(false);

		        btn_prev.setEnabled(true);
		        btn_next.setEnabled(true);
		        txt_find.setEnabled(true);
			}});
		builder.setNegativeButton("Cancel", new DialogInterface.OnClickListener(){
			public void onClick(DialogInterface dialog, int which)
			{
				dialog.dismiss();
				m_view.PDFEndAnnot();
				m_set = false;
				btn_ink.setEnabled(m_doc.CanSave());
				btn_rect.setEnabled(m_doc.CanSave());
				btn_oval.setEnabled(m_doc.CanSave());
				btn_note.setEnabled(m_doc.CanSave());
				btn_line.setEnabled(m_doc.CanSave());
				btn_stamp.setEnabled(m_doc.CanSave());
				btn_cancel.setEnabled(false);
		        btn_save.setEnabled(true);

				btn_sel.setEnabled(true);
		        btn_act.setEnabled(false);
				btn_edit.setEnabled(false);
				btn_remove.setEnabled(false);

		        btn_prev.setEnabled(true);
		        btn_next.setEnabled(true);
		        txt_find.setEnabled(true);
			}});
		builder.setTitle("Note Content");
		builder.setCancelable(false);
		builder.setView(layout);
		
		subj.setText(m_annot.GetPopupSubject());
		content.setText(m_annot.GetPopupText());
		AlertDialog dlg = builder.create();
		dlg.show();
	}
	private void onAct()
	{
		m_view.PDFPerformAnnot();
		m_set = false;
		btn_ink.setEnabled(m_doc.CanSave());
		btn_rect.setEnabled(m_doc.CanSave());
		btn_oval.setEnabled(m_doc.CanSave());
		btn_note.setEnabled(m_doc.CanSave());
		btn_line.setEnabled(m_doc.CanSave());
		btn_stamp.setEnabled(m_doc.CanSave());
		btn_cancel.setEnabled(false);
        btn_save.setEnabled(true);

		btn_sel.setEnabled(true);
        btn_act.setEnabled(false);
		btn_edit.setEnabled(false);
		btn_remove.setEnabled(false);

        btn_prev.setEnabled(true);
        btn_next.setEnabled(true);
        txt_find.setEnabled(true);
	}
	private void onRemove()
	{
		m_view.PDFRemoveAnnot();
		m_set = false;
		btn_ink.setEnabled(m_doc.CanSave());
		btn_rect.setEnabled(m_doc.CanSave());
		btn_oval.setEnabled(m_doc.CanSave());
		btn_note.setEnabled(m_doc.CanSave());
		btn_line.setEnabled(m_doc.CanSave());
		btn_stamp.setEnabled(m_doc.CanSave());
		btn_cancel.setEnabled(false);
        btn_save.setEnabled(true);

		btn_sel.setEnabled(true);
        btn_act.setEnabled(false);
		btn_edit.setEnabled(false);
		btn_remove.setEnabled(false);

        btn_prev.setEnabled(true);
        btn_next.setEnabled(true);
        txt_find.setEnabled(true);
	}
	public void onClick(View v)
	{
		if( v.getId() == R.id.btn_ink )
			onInk();
		else if( v.getId() == R.id.btn_rect )
			onRect();
		else if( v.getId() == R.id.btn_oval )
			onOval();
		else if( v.getId() == R.id.btn_note )
			onNote();
		else if( v.getId() == R.id.btn_line )
			onLine();
		else if( v.getId() == R.id.btn_stamp )
			onStamp();
		else if( v.getId() == R.id.btn_cancel )
			onCancel();
		else if( v.getId() == R.id.btn_save )
			m_doc.Save();
		else if( v.getId() == R.id.btn_sel )
			onSelect();
		else if( v.getId() == R.id.btn_remove )
			onRemove();
		else if( v.getId() == R.id.btn_act )
			onAct();
		else if( v.getId() == R.id.btn_edit )
			onEdit();
		else if( v.getId() == R.id.btn_prev )
			onFindPrev();
		else if( v.getId() == R.id.btn_next )
			onFindNext();
		else if( v.getId() == R.id.btn_close )
		{
    		m_view.PDFClose();
        	if( m_doc != null ) m_doc.Close();
    		str_find = null;
	    	setContentView(m_vFiles);
		}
	}
	public void OnPageModified(int pageno) {
		// TODO Auto-generated method stub
		
	}
	public void OnPageChanged(int pageno) {
		// TODO Auto-generated method stub
		
	}
	private VPage m_annot_vpage = null;
	private Annotation m_annot;
	public void OnAnnotClicked(VPage vpage, Annotation annot)
	{
		m_annot_vpage = vpage;
		m_annot = annot;
		btn_ink.setEnabled(annot == null && m_doc.CanSave());
		btn_rect.setEnabled(annot == null && m_doc.CanSave());
		btn_oval.setEnabled(annot == null && m_doc.CanSave());
		btn_note.setEnabled(annot == null && m_doc.CanSave());
		btn_line.setEnabled(annot == null && m_doc.CanSave());
		btn_stamp.setEnabled(annot == null && m_doc.CanSave());
		btn_cancel.setEnabled(false);
		btn_save.setEnabled(annot == null);

		btn_sel.setEnabled(annot == null);
        btn_act.setEnabled(annot != null);
		btn_edit.setEnabled(annot != null && m_doc.CanSave());
		btn_remove.setEnabled(annot != null && m_doc.CanSave());

		btn_prev.setEnabled(annot == null);
        btn_next.setEnabled(annot == null);
        txt_find.setEnabled(annot == null);
	}
	public void OnSelectEnd(String text)
	{
		LinearLayout layout = (LinearLayout)LayoutInflater.from(this).inflate(R.layout.dlg_text, null);
		final RadioGroup rad_group = (RadioGroup)layout.findViewById(R.id.rad_group);
		final String sel_text = text;

		AlertDialog.Builder builder = new AlertDialog.Builder(this);
		builder.setPositiveButton("OK", new DialogInterface.OnClickListener()
		{
			@SuppressLint("NewApi")
			public void onClick(DialogInterface dialog, int which)
			{
				if( rad_group.getCheckedRadioButtonId() == R.id.rad_copy )
					Toast.makeText(PDFLayoutAct.this, "todo copy text:" + sel_text, Toast.LENGTH_SHORT).show();
				else if( m_doc.CanSave() )
				{
					boolean ret = false;
			        if( rad_group.getCheckedRadioButtonId() == R.id.rad_copy )
			    	{
	                    Toast.makeText(PDFLayoutAct.this, "todo copy text:" + sel_text, Toast.LENGTH_SHORT).show();
	                    android.content.ClipboardManager clipboard = (android.content.ClipboardManager) getSystemService(CLIPBOARD_SERVICE);
	                    android.content.ClipData clip = android.content.ClipData.newPlainText("Radaee", sel_text);
	                    clipboard.setPrimaryClip(clip);                    
			        }
			        else if( rad_group.getCheckedRadioButtonId() == R.id.rad_highlight )
						ret = m_view.PDFSetSelMarkup(0);
					else if( rad_group.getCheckedRadioButtonId() == R.id.rad_underline )
						ret = m_view.PDFSetSelMarkup(1);
					else if( rad_group.getCheckedRadioButtonId() == R.id.rad_strikeout )
						ret = m_view.PDFSetSelMarkup(2);
					else if( rad_group.getCheckedRadioButtonId() == R.id.rad_squiggly )
						ret = m_view.PDFSetSelMarkup(4);
					if( !ret )
						Toast.makeText(PDFLayoutAct.this, "add annotation failed!", Toast.LENGTH_SHORT).show();
				}
				else
					Toast.makeText(PDFLayoutAct.this, "can't write or encrypted!", Toast.LENGTH_SHORT).show();
				onSelect();
				dialog.dismiss();
			}});
		builder.setNegativeButton("Cancel", new DialogInterface.OnClickListener()
		{
			public void onClick(DialogInterface dialog, int which)
			{
				dialog.dismiss();
			}});
		builder.setTitle("Process selected text");
		builder.setCancelable(false);
		builder.setView(layout);
		AlertDialog dlg = builder.create();
		dlg.show();
	}
	public void OnOpenURI(String uri) {
		// TODO Auto-generated method stub
		
	}
	public void OnOpenJS(String js) {
		// TODO Auto-generated method stub
		
	}
	public void OnOpenMovie(String path) {
		// TODO Auto-generated method stub
		
	}
	public void OnOpenSound(int[] paras, String path) {
		// TODO Auto-generated method stub
		
	}
	public void OnOpenAttachment(String path) {
		// TODO Auto-generated method stub
		
	}
	public void OnOpen3D(String path) {
		// TODO Auto-generated method stub
		
	}
}

package com.radaee.reader;

import com.radaee.reader.R;
import com.radaee.pdf.Document;
import com.radaee.pdf.Global;
import com.radaee.pdf.Ink;
import com.radaee.pdf.Matrix;
import com.radaee.pdf.Page;
import com.radaee.pdf.Page.Annotation;
import com.radaee.util.ComboList;
import com.radaee.view.PDFLayout;
import com.radaee.view.PDFLayout.LayoutListener;
import com.radaee.view.PDFLayout.PDFPos;
import com.radaee.view.PDFLayoutDual;
import com.radaee.view.PDFLayoutVert;
import com.radaee.view.PDFViewCurl;
import com.radaee.view.PDFViewDual;
import com.radaee.view.PDFViewHorz;
import com.radaee.view.PDFViewReflow;
import com.radaee.view.PDFViewVert;
import com.radaee.view.VPage;
import com.radaee.view.VSel;
import android.app.ActivityManager;
import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Canvas;
import android.graphics.Paint;
import android.graphics.Rect;
import android.graphics.RectF;
import android.graphics.Paint.Style;
import android.graphics.drawable.BitmapDrawable;
import android.text.InputFilter;
import android.text.InputType;
import android.util.AttributeSet;
import android.util.FloatMath;
import android.util.Log;
import android.util.TypedValue;
import android.view.GestureDetector;
import android.view.Gravity;
import android.view.LayoutInflater;
import android.view.MotionEvent;
import android.view.View;
import android.widget.AdapterView;
import android.widget.EditText;
import android.widget.PopupWindow;
import android.widget.Scroller;
import android.widget.Toast;
import android.widget.AdapterView.OnItemClickListener;

public class PDFLayoutView extends View implements LayoutListener, OnItemClickListener, PopupWindow.OnDismissListener
{
	static final protected int STA_NONE = 0;
	static final protected int STA_ZOOM = 1;
	static final protected int STA_SELECT = 2;
	static final protected int STA_INK = 3;
	static final protected int STA_RECT = 4;
	static final protected int STA_ELLIPSE = 5;
	static final protected int STA_NOTE = 6;
	static final protected int STA_LINE = 7;
	static final protected int STA_STAMP = 8;
	static final protected int STA_ANNOT = 100;
	private PDFLayout m_layout;
	private Document m_doc;
	private int m_status = STA_NONE;
	private boolean m_zooming = false;
	private int m_pageno = 0;
	private int m_goto_pageno = -1;

    private GestureDetector m_gesture = null;
	private Annotation m_annot = null;
	private PDFPos m_annot_pos = null;
	private VPage m_annot_page = null;
	private float m_annot_rect[];
	private float m_annot_rect0[];
	private float m_annot_x0;
	private float m_annot_y0;

	private Ink m_ink = null;
	private Bitmap m_icon = null;
	private float m_rects[];
	private PDFLayoutListener m_listener;
	private VSel m_sel = null;
    private int m_edit_type = 0;
    private int m_combo_item = -1;
    private boolean m_rtol = false;
	private PopupWindow m_pEdit = null;
	private PopupWindow m_pCombo = null;
    class PDFGestureListener extends GestureDetector.SimpleOnGestureListener
    {
        @Override
        public boolean onFling(MotionEvent e1, MotionEvent e2, float velocityX, float velocityY)
        {
        	if(m_status == STA_NONE)
        	{
        		Log.i("PDF", "fling");
	        	float dx = e2.getX() - e1.getX();
	        	float dy = e2.getY() - e1.getY();
	        	return m_layout.vFling(m_hold_docx, m_hold_docy, dx, dy, velocityX, velocityY);
        	}
        	else return false;
        }
        @Override
        public boolean onDoubleTap(MotionEvent e)
        {
   			return false;
        }
        @Override
        public boolean onDoubleTapEvent(MotionEvent e)
        {
   			return false;
        }
        @Override
        public boolean onDown(MotionEvent e)
        {
        	return false;
        }
        @Override
        public void onLongPress(MotionEvent e)
        {
        }
        @Override
        public boolean onScroll(MotionEvent e1, MotionEvent e2, float distanceX, float distanceY)
        {
        	return false;
        }
        @Override
        public void onShowPress(MotionEvent e)
        {
        }
        @Override
        public boolean onSingleTapConfirmed(MotionEvent e)
        {
        	return false;
        }
        @Override
        public boolean onSingleTapUp(MotionEvent e)
        {
    		if( m_status == STA_NONE || m_status == STA_ANNOT )
    		{
    			m_annot_pos = m_layout.vGetPos((int)e.getX(), (int)e.getY());
    			m_annot_page = m_layout.vGetPage(m_annot_pos.pageno);
    			Page page = m_doc.GetPage(m_annot_page.GetPageNo());
    			if( page == null ) m_annot = null;
    			else m_annot = page.GetAnnotFromPoint(m_annot_pos.x, m_annot_pos.y);
    			if( m_annot == null )
    			{
    				m_annot_page = null;
    				m_annot_pos = null;
    				m_annot_rect = null;
    				if( m_listener != null && m_status == STA_ANNOT )
    					m_listener.OnAnnotClicked(m_annot_page, null);
    				m_status = STA_NONE;
    			}
    			else
    			{
    				page.ObjsStart();
    				m_annot_rect = m_annot.GetRect();
    				float tmp = m_annot_rect[1];
    				m_annot_rect[0] = m_annot_page.GetVX(m_annot_rect[0]) - m_layout.vGetX();
    				m_annot_rect[1] = m_annot_page.GetVY(m_annot_rect[3]) - m_layout.vGetY();
    				m_annot_rect[2] = m_annot_page.GetVX(m_annot_rect[2]) - m_layout.vGetX();
    				m_annot_rect[3] = m_annot_page.GetVY(tmp) - m_layout.vGetY();
    				m_status = STA_ANNOT;
    				if( m_doc.CanSave() && m_annot.GetEditType() > 0 )
    				{
    					int[] location = new int[2];  
    					getLocationOnScreen(location);
    					m_pEdit.setWidth((int)(m_annot_rect[2] - m_annot_rect[0]));
    					m_pEdit.setHeight((int)(m_annot_rect[3] - m_annot_rect[1]));
    					EditText edit = (EditText)m_pEdit.getContentView().findViewById(R.id.annot_text);
    					edit.setBackgroundColor(0xFFFFFFC0);
    					float fsize = m_annot.GetEditTextSize() * m_layout.vGetScale();
    					edit.setTextSize(TypedValue.COMPLEX_UNIT_PX, fsize);
    					edit.setPadding(2, 2, 2, 2);
    					switch( m_annot.GetEditType() )
    					{
    					case 1:
    						edit.setSingleLine();
    						edit.setInputType(InputType.TYPE_CLASS_TEXT + InputType.TYPE_TEXT_VARIATION_NORMAL);
    						break;
    					case 2:
    						edit.setSingleLine();
    						edit.setInputType(InputType.TYPE_CLASS_TEXT + InputType.TYPE_TEXT_VARIATION_PASSWORD);
    						break;
    					case 3:
    						edit.setSingleLine(false);
    						edit.setInputType(InputType.TYPE_CLASS_TEXT + InputType.TYPE_TEXT_VARIATION_NORMAL);
    						break;
    					}
    					int maxlen = m_annot.GetEditMaxlen();
    					if( maxlen > 0 )
    						edit.setFilters(new InputFilter[]{new InputFilter.LengthFilter(maxlen)});
    					else
    						edit.setFilters(new InputFilter[]{new InputFilter.LengthFilter(1020)});
    					edit.setText(m_annot.GetEditText());
    					m_edit_type = 1;
    					m_pEdit.showAtLocation(PDFLayoutView.this, Gravity.NO_GRAVITY, (int)m_annot_rect[0] + location[0], (int)m_annot_rect[1] + location[1]);
    				}
    				if( m_doc.CanSave() && m_annot.GetComboItemCount() >= 0 )
    				{
    					int[] location = new int[2];  
    					getLocationOnScreen(location);
    					String opts[] = new String[m_annot.GetComboItemCount()];
    					int cur = 0;
    					while( cur < opts.length )
    					{
    						opts[cur] = m_annot.GetComboItem(cur);
    						cur++;
    					}
    					m_pCombo.setWidth((int)(m_annot_rect[2] - m_annot_rect[0]));
    					if( (m_annot_rect[3] - m_annot_rect[1] - 4) * opts.length > 250 )
    						m_pCombo.setHeight(250);
    					else
    						m_pCombo.setHeight((int)(m_annot_rect[3] - m_annot_rect[1] - 4) * opts.length);
    					ComboList combo = (ComboList)m_pCombo.getContentView().findViewById(R.id.annot_combo);
    					combo.set_opts(opts);
    					combo.setOnItemClickListener(PDFLayoutView.this);
    					m_edit_type = 2;
    					m_combo_item = -1;
    					m_pCombo.showAtLocation(PDFLayoutView.this, Gravity.NO_GRAVITY, (int)m_annot_rect[0] + location[0], (int)(m_annot_rect[3] + location[1]));
    				}
    				if( m_listener != null )
    					m_listener.OnAnnotClicked(m_annot_page, m_annot);
    				invalidate();
    			}
    			return true;
    		}
    		return false;
        }
    }
	public interface PDFLayoutListener
	{
		public void OnPageModified(int pageno);
		public void OnPageChanged(int pageno);
		public void OnAnnotClicked(VPage vpage, Annotation annot);
		public void OnSelectEnd(String text);
		public void OnOpenURI(String uri);
		public void OnOpenJS(String js);
		public void OnOpenMovie(String path);
		public void OnOpenSound(int[] paras, String path);
		public void OnOpenAttachment(String path);
		public void OnOpen3D(String path);
	}
    class PDFVPageSet
    {
    	PDFVPageSet( int max_len )
    	{
    		pages = new VPage[max_len];
    		pages_cnt = 0;
    	}
    	void Insert( VPage vpage )
    	{
    		int cur = 0;
    		for( cur = 0; cur < pages_cnt; cur++ )
    		{
    			if( pages[cur] == vpage ) return;
    		}
    		pages[cur] = vpage;
    		pages_cnt++;
    	}
    	VPage pages[];
    	int pages_cnt;
    }
	public PDFLayoutView(Context context)
	{
		super(context);
		m_pEdit = new PopupWindow(LayoutInflater.from(context).inflate(R.layout.pop_edit, null) );
		m_pCombo = new PopupWindow(LayoutInflater.from(context).inflate(R.layout.pop_combo, null));
		m_pEdit.setOnDismissListener(this);
		m_pCombo.setOnDismissListener(this);
		m_pEdit.setFocusable(true);
		m_pEdit.setTouchable(true);
		BitmapDrawable bitmap = new BitmapDrawable();//add back
		m_pEdit.setBackgroundDrawable(bitmap);
		m_pCombo.setFocusable(true);
		m_pCombo.setTouchable(true);
		m_pCombo.setBackgroundDrawable(bitmap);

		m_doc = null;
    	m_gesture = new GestureDetector( context, new PDFGestureListener() );
	}
	public PDFLayoutView(Context context, AttributeSet attrs)
	{
		super(context, attrs);
		m_pEdit = new PopupWindow(LayoutInflater.from(context).inflate(R.layout.pop_edit, null) );
		m_pCombo = new PopupWindow(LayoutInflater.from(context).inflate(R.layout.pop_combo, null));
		m_pEdit.setOnDismissListener(this);
		m_pCombo.setOnDismissListener(this);
		m_pEdit.setFocusable(true);
		m_pEdit.setTouchable(true);
		BitmapDrawable bitmap = new BitmapDrawable();//add back
		m_pEdit.setBackgroundDrawable(bitmap);
		m_pCombo.setFocusable(true);
		m_pCombo.setTouchable(true);
		m_pCombo.setBackgroundDrawable(bitmap);

		m_doc = null;
    	m_gesture = new GestureDetector( context, new PDFGestureListener() );
	}
	@Override
	protected void onSizeChanged( int w, int h, int oldw, int oldh )
	{
		super.onSizeChanged(w,h,oldw, oldh);
		if(m_layout != null && m_status != STA_ANNOT && w > 0 && h > 0)
		{
			m_layout.vResize(w, h);
			if( m_goto_pageno >= 0 )
			{
				m_layout.vGotoPage(m_goto_pageno);
				m_goto_pageno = -1;
				invalidate();
			}
		}
	}
	private Paint m_info_paint = new Paint();
	private void onDrawSelect(Canvas canvas)
	{
		if( m_status == STA_SELECT && m_sel != null )
		{
			int orgx = m_annot_page.GetVX(0) - m_layout.vGetX();
			int orgy = m_annot_page.GetVY(m_doc.GetPageHeight(m_annot_page.GetPageNo())) - m_layout.vGetY();
			m_sel.DrawSel(canvas, m_layout.vGetScale(), m_doc.GetPageHeight(m_annot_page.GetPageNo()), orgx, orgy);
		}
	}
	private void onDrawAnnot(Canvas canvas)
	{
		if( m_status == STA_ANNOT )
		{
			Paint paint = new Paint();
			paint.setStyle(Style.STROKE);
			paint.setStrokeWidth(2);
			paint.setARGB(0x80, 0, 0, 0);
			canvas.drawRect(m_annot_rect[0],
					m_annot_rect[1],
					m_annot_rect[2],
					m_annot_rect[3], paint);
		}
	}
	private void onDrawRect(Canvas canvas)
	{
		if( m_status == STA_RECT && m_rects != null )
		{
			int len = m_rects.length;
			int cur;
			Paint paint1 = new Paint();
			Paint paint2 = new Paint();
			paint1.setStyle(Style.STROKE);
			paint1.setStrokeWidth(3);
			paint1.setARGB(0x80, 0xFF, 0, 0);
			paint2.setStyle(Style.FILL);
			paint2.setARGB(0x80, 0, 0, 0xFF);
			for( cur = 0; cur < len; cur += 4 )
			{
				float rect[] = new float[4];
				if( m_rects[cur] > m_rects[cur + 2] ) 
				{
					rect[0] = m_rects[cur + 2];
					rect[2] = m_rects[cur];
				}
				else
				{
					rect[0] = m_rects[cur];
					rect[2] = m_rects[cur + 2];
				}
				if( m_rects[cur + 1] > m_rects[cur + 3] ) 
				{
					rect[1] = m_rects[cur + 3];
					rect[3] = m_rects[cur + 1];
				}
				else
				{
					rect[1] = m_rects[cur + 1];
					rect[3] = m_rects[cur + 3];
				}
				canvas.drawRect(rect[0], rect[1], rect[2], rect[3], paint1);
				canvas.drawRect(rect[0] + 1.5f, rect[1] + 1.5f, rect[2] - 1.5f, rect[3] - 1.5f, paint2);
			}
		}
	}
	private void onDrawLine(Canvas canvas)
	{
		if( m_status == STA_LINE && m_rects != null )
		{
			int len = m_rects.length;
			int cur;
			Paint paint1 = new Paint();
			paint1.setStyle(Style.STROKE);
			paint1.setStrokeWidth(3);
			paint1.setARGB(0x80, 0xFF, 0, 0);
			for( cur = 0; cur < len; cur += 4 )
			{
				canvas.drawLine(m_rects[cur], m_rects[cur + 1], m_rects[cur + 2], m_rects[cur + 3], paint1);
			}
		}
	}
	private void onDrawStamp(Canvas canvas)
	{
		if( m_status == STA_STAMP && m_rects != null )
		{
			int len = m_rects.length;
			int cur;
			for( cur = 0; cur < len; cur += 4 )
			{
				float rect[] = new float[4];
				if( m_rects[cur] > m_rects[cur + 2] ) 
				{
					rect[0] = m_rects[cur + 2];
					rect[2] = m_rects[cur];
				}
				else
				{
					rect[0] = m_rects[cur];
					rect[2] = m_rects[cur + 2];
				}
				if( m_rects[cur + 1] > m_rects[cur + 3] ) 
				{
					rect[1] = m_rects[cur + 3];
					rect[3] = m_rects[cur + 1];
				}
				else
				{
					rect[1] = m_rects[cur + 1];
					rect[3] = m_rects[cur + 3];
				}
				if( m_icon != null )
				{
					Rect rc = new Rect();
					rc.left = (int) rect[0];
					rc.top = (int) rect[1];
					rc.right = (int) rect[2];
					rc.bottom = (int) rect[3];
					canvas.drawBitmap(m_icon, null, rc, null);
				}
			}
		}
	}
	private void onDrawEllipse(Canvas canvas)
	{
		if( m_status == STA_ELLIPSE && m_rects != null )
		{
			int len = m_rects.length;
			int cur;
			Paint paint1 = new Paint();
			Paint paint2 = new Paint();
			paint1.setStyle(Style.STROKE);
			paint1.setStrokeWidth(3);
			paint1.setARGB(0x80, 0xFF, 0, 0);
			paint2.setStyle(Style.FILL);
			paint2.setARGB(0x80, 0, 0, 0xFF);
			for( cur = 0; cur < len; cur += 4 )
			{
				float rect[] = new float[4];
				if( m_rects[cur] > m_rects[cur + 2] ) 
				{
					rect[0] = m_rects[cur + 2];
					rect[2] = m_rects[cur];
				}
				else
				{
					rect[0] = m_rects[cur];
					rect[2] = m_rects[cur + 2];
				}
				if( m_rects[cur + 1] > m_rects[cur + 3] ) 
				{
					rect[1] = m_rects[cur + 3];
					rect[3] = m_rects[cur + 1];
				}
				else
				{
					rect[1] = m_rects[cur + 1];
					rect[3] = m_rects[cur + 3];
				}
				RectF rc = new RectF();
				rc.left = rect[0];
				rc.top = rect[1];
				rc.right = rect[2];
				rc.bottom = rect[3];
				canvas.drawOval(rc, paint1);
				rc.left += 1.5f;
				rc.top += 1.5f;
				rc.right -= 1.5f;
				rc.bottom -= 1.5f;
				canvas.drawOval(rc, paint2);
			}
		}
	}
	@Override
	protected void onDraw(Canvas canvas)
	{
		if(m_layout != null)
		{
			m_layout.vDraw(canvas, m_zooming || m_status == STA_ZOOM);
			onDrawSelect(canvas);
			onDrawRect(canvas);
			onDrawEllipse(canvas);
			onDrawAnnot(canvas);
			onDrawLine(canvas);
			onDrawStamp(canvas);
			if( m_status == STA_INK && m_ink != null )
			{
				m_ink.OnDraw(canvas, 0, 0 );
			}
		}
		ActivityManager mgr = (ActivityManager)getContext().getSystemService(Context.ACTIVITY_SERVICE);
		ActivityManager.MemoryInfo info = new ActivityManager.MemoryInfo();
		mgr.getMemoryInfo(info);
		m_info_paint.setARGB(255, 255, 0, 0);
		m_info_paint.setTextSize(30);
		canvas.drawText( "AvialMem:" + info.availMem/(1024*1024) + " M", 20, 150, m_info_paint);
	}
	private float m_hold_x;
	private float m_hold_y;
	private int m_hold_docx;
	private int m_hold_docy;
	private PDFPos m_zoom_pos;
	private float m_zoom_dis0;
	private float m_zoom_scale;
	private boolean onTouchNone(MotionEvent event)
	{
		if( m_status != STA_NONE ) return false;
		if( m_gesture.onTouchEvent(event) ) return true;
		switch(event.getActionMasked())
		{
		case MotionEvent.ACTION_DOWN:
			m_hold_x = event.getX();
			m_hold_y = event.getY();
			m_hold_docx = m_layout.vGetX();
			m_hold_docy = m_layout.vGetY();
			m_layout.vScrollAbort();
			invalidate();
			break;
		case MotionEvent.ACTION_MOVE:
			if(m_hold_x <= -10000 && m_hold_y <= -10000)
			{
				m_hold_x = event.getX();
				m_hold_y = event.getY();
				m_hold_docx = m_layout.vGetX();
				m_hold_docy = m_layout.vGetY();
			}
			else
			{
				m_layout.vSetX( (int)(m_hold_docx + m_hold_x - event.getX()) );
				m_layout.vSetY( (int)(m_hold_docy + m_hold_y - event.getY()) );
				invalidate();
			}
			break;
		case MotionEvent.ACTION_UP:
		case MotionEvent.ACTION_CANCEL:
			if(m_hold_x <= -10000 && m_hold_y <= -10000)
			{
				m_hold_x = event.getX();
				m_hold_y = event.getY();
				m_hold_docx = m_layout.vGetX();
				m_hold_docy = m_layout.vGetY();
			}
			else
			{
				m_layout.vSetX( (int)(m_hold_docx + m_hold_x - event.getX()) );
				m_layout.vSetY( (int)(m_hold_docy + m_hold_y - event.getY()) );
				invalidate();
				m_layout.vMoveEnd();
			}
			break;
		case MotionEvent.ACTION_POINTER_DOWN:
			if( event.getPointerCount() >= 2 )
			{
				m_status = STA_ZOOM;
				m_hold_x = (event.getX(0) + event.getX(1))/2;
				m_hold_y = (event.getY(0) + event.getY(1))/2;
				m_zoom_pos = m_layout.vGetPos( (int)m_hold_x, (int)m_hold_y );
				float dx = event.getX(0) - event.getX(1);
				float dy = event.getY(0) - event.getY(1);
				m_zoom_dis0 = FloatMath.sqrt(dx * dx + dy * dy);
				m_zoom_scale = m_layout.vGetZoom();
				m_status = STA_ZOOM;
				m_layout.vZoomStart();
			}
			break;
		}
		return true;
	}
	private boolean onTouchZoom(MotionEvent event)
	{
		if( m_status != STA_ZOOM ) return false;
		switch(event.getActionMasked())
		{
		case MotionEvent.ACTION_MOVE:
			if( m_status == STA_ZOOM )
			{
				float dx = event.getX(0) - event.getX(1);
				float dy = event.getY(0) - event.getY(1);
				float dis1 = FloatMath.sqrt(dx * dx + dy * dy);
				m_layout.vZoomSet((int)m_hold_x, (int)m_hold_y, m_zoom_pos, m_zoom_scale * dis1 / m_zoom_dis0);
				invalidate();
			}
			break;
		case MotionEvent.ACTION_UP:
		case MotionEvent.ACTION_POINTER_UP:
		case MotionEvent.ACTION_CANCEL:
			if( m_status == STA_ZOOM && event.getPointerCount() <= 2 )
			{
				float dx = event.getX(0) - event.getX(1);
				float dy = event.getY(0) - event.getY(1);
				float dis1 = FloatMath.sqrt(dx * dx + dy * dy);
				m_layout.vZoomSet((int)m_hold_x, (int)m_hold_y, m_zoom_pos, m_zoom_scale * dis1 / m_zoom_dis0);
				m_hold_x = -10000;
				m_hold_y = -10000;
				m_status = STA_NONE;
				m_zooming = true;
				m_layout.vZoomConfirmed();
				invalidate();
			}
			break;
		}
    	return true;
	}
	private boolean onTouchSelect(MotionEvent event)
	{
		if( m_status != STA_SELECT ) return false;
		switch(event.getActionMasked())
		{
		case MotionEvent.ACTION_DOWN:
			m_hold_x = event.getX();
			m_hold_y = event.getY();
			if(m_sel != null)
			{
				m_sel.Clear();
				m_sel = null;
			}
			m_annot_pos = m_layout.vGetPos((int)m_hold_x, (int)m_hold_y);
			m_annot_page = m_layout.vGetPage(m_annot_pos.pageno);
			m_sel = new VSel(m_doc.GetPage(m_annot_pos.pageno));
			break;
		case MotionEvent.ACTION_MOVE:
			if(m_sel != null)
			{
				m_sel.SetSel( m_annot_pos.x, m_annot_pos.y,
						m_annot_page.ToPDFX(event.getX(), m_layout.vGetX()),
						m_annot_page.ToPDFY(event.getY(), m_layout.vGetY()) );
				invalidate();
			}
			break;
		case MotionEvent.ACTION_UP:
		case MotionEvent.ACTION_CANCEL:
			if(m_sel != null)
			{
				m_sel.SetSel( m_annot_pos.x, m_annot_pos.y,
						m_annot_page.ToPDFX(event.getX(), m_layout.vGetX()),
						m_annot_page.ToPDFY(event.getY(), m_layout.vGetY()) );
				invalidate();
				if(m_listener != null) m_listener.OnSelectEnd(m_sel.GetSelString());
			}
			break;
		}
		return true;
	}
	private boolean onTouchInk(MotionEvent event)
	{
		if( m_status != STA_INK ) return false;
		switch(event.getActionMasked())
		{
		case MotionEvent.ACTION_DOWN:
			if( m_annot_page == null )
			{
				PDFPos pos = m_layout.vGetPos((int)event.getX(), (int)event.getY());
				m_annot_page = m_layout.vGetPage(pos.pageno);
			}
			m_ink.OnDown(event.getX(), event.getY());
			break;
		case MotionEvent.ACTION_MOVE:
			m_ink.OnMove(event.getX(), event.getY());
			break;
		case MotionEvent.ACTION_UP:
		case MotionEvent.ACTION_CANCEL:
			m_ink.OnUp(event.getX(), event.getY());
			break;
		}
		invalidate();
		return true;
	}
	private boolean onTouchRect(MotionEvent event)
	{
		if( m_status != STA_RECT ) return false;
		int len = 0;
		if( m_rects != null ) len = m_rects.length;
		int cur = 0;
		switch(event.getActionMasked())
		{
		case MotionEvent.ACTION_DOWN:
			float rects[] = new float[len + 4];
			for( cur = 0; cur < len; cur++ )
				rects[cur] = m_rects[cur];
			len += 4;
			rects[cur + 0] = event.getX();
			rects[cur + 1] = event.getY();
			rects[cur + 2] = event.getX();
			rects[cur + 3] = event.getY();
			m_rects = rects;
			break;
		case MotionEvent.ACTION_MOVE:
			m_rects[len - 2] = event.getX();
			m_rects[len - 1] = event.getY();
			break;
		case MotionEvent.ACTION_UP:
		case MotionEvent.ACTION_CANCEL:
			m_rects[len - 2] = event.getX();
			m_rects[len - 1] = event.getY();
			break;
		}
		invalidate();
		return true;
	}
	private boolean onTouchEllipse(MotionEvent event)
	{
		if( m_status != STA_ELLIPSE ) return false;
		int len = 0;
		if( m_rects != null ) len = m_rects.length;
		int cur = 0;
		switch(event.getActionMasked())
		{
		case MotionEvent.ACTION_DOWN:
			float rects[] = new float[len + 4];
			for( cur = 0; cur < len; cur++ )
				rects[cur] = m_rects[cur];
			len += 4;
			rects[cur + 0] = event.getX();
			rects[cur + 1] = event.getY();
			rects[cur + 2] = event.getX();
			rects[cur + 3] = event.getY();
			m_rects = rects;
			break;
		case MotionEvent.ACTION_MOVE:
			m_rects[len - 2] = event.getX();
			m_rects[len - 1] = event.getY();
			break;
		case MotionEvent.ACTION_UP:
		case MotionEvent.ACTION_CANCEL:
			m_rects[len - 2] = event.getX();
			m_rects[len - 1] = event.getY();
			break;
		}
		invalidate();
		return true;
	}
	private boolean onTouchAnnot(MotionEvent event)
	{
		if( m_status != STA_ANNOT ) return false;
		switch(event.getActionMasked())
		{
		case MotionEvent.ACTION_DOWN:
			m_annot_x0 = event.getX();
			m_annot_y0 = event.getY();
			if( m_annot_x0 > m_annot_rect[0] && m_annot_y0 > m_annot_rect[1] &&
				m_annot_x0 < m_annot_rect[2] && m_annot_y0 < m_annot_rect[3] )
			{
				m_annot_rect0 = new float[4];
				m_annot_rect0[0] = m_annot_rect[0];
				m_annot_rect0[1] = m_annot_rect[1];
				m_annot_rect0[2] = m_annot_rect[2];
				m_annot_rect0[3] = m_annot_rect[3];
			}
			else
				m_annot_rect0 = null;
			break;
		case MotionEvent.ACTION_MOVE:
			if( m_annot_rect0 != null )
			{
				float x = event.getX();
				float y = event.getY();
				m_annot_rect[0] = m_annot_rect0[0] + x - m_annot_x0;
				m_annot_rect[1] = m_annot_rect0[1] + y - m_annot_y0;
				m_annot_rect[2] = m_annot_rect0[2] + x - m_annot_x0;
				m_annot_rect[3] = m_annot_rect0[3] + y - m_annot_y0;
			}
			break;
		case MotionEvent.ACTION_UP:
		case MotionEvent.ACTION_CANCEL:
			if( m_annot_rect0 != null )
			{
				float x = event.getX();
				float y = event.getY();
				PDFPos pos = m_layout.vGetPos((int)x, (int)y);
				m_annot_rect[0] = m_annot_rect0[0] + x - m_annot_x0;
				m_annot_rect[1] = m_annot_rect0[1] + y - m_annot_y0;
				m_annot_rect[2] = m_annot_rect0[2] + x - m_annot_x0;
				m_annot_rect[3] = m_annot_rect0[3] + y - m_annot_y0;
				if( m_annot_page.GetPageNo() == pos.pageno )
				{
					m_annot_rect0[0] = m_annot_page.ToPDFX(m_annot_rect[0], m_layout.vGetX());
					m_annot_rect0[1] = m_annot_page.ToPDFY(m_annot_rect[3], m_layout.vGetY());
					m_annot_rect0[2] = m_annot_page.ToPDFX(m_annot_rect[2], m_layout.vGetX());
					m_annot_rect0[3] = m_annot_page.ToPDFY(m_annot_rect[1], m_layout.vGetY());
					m_annot.SetRect(m_annot_rect0[0], m_annot_rect0[1], m_annot_rect0[2], m_annot_rect0[3]);
					m_layout.vRenderSync(m_annot_page);
					if( m_listener != null )
						m_listener.OnPageModified(m_annot_page.GetPageNo());
				}
				else
				{
					VPage vpage = m_layout.vGetPage(pos.pageno);
					Page page = m_doc.GetPage(vpage.GetPageNo());
					if( page != null )
					{
						page.ObjsStart();
						m_annot_rect0[0] = vpage.ToPDFX(m_annot_rect[0], m_layout.vGetX());
						m_annot_rect0[1] = vpage.ToPDFY(m_annot_rect[3], m_layout.vGetY());
						m_annot_rect0[2] = vpage.ToPDFX(m_annot_rect[2], m_layout.vGetX());
						m_annot_rect0[3] = vpage.ToPDFY(m_annot_rect[1], m_layout.vGetY());
						m_annot.MoveToPage(page, m_annot_rect0);
						//page.CopyAnnot(m_annot, m_annot_rect0);
						page.Close();
					}
					m_layout.vRenderSync(m_annot_page);
					m_layout.vRenderSync(vpage);
					if( m_listener != null )
					{
						m_listener.OnPageModified(m_annot_page.GetPageNo());
						m_listener.OnPageModified(vpage.GetPageNo());
					}
				}
			}
			PDFEndAnnot();
			break;
		}
		invalidate();
		return true;
	}
	private boolean onTouchLine(MotionEvent event)
	{
		if( m_status != STA_LINE ) return false;
		int len = 0;
		if( m_rects != null ) len = m_rects.length;
		int cur = 0;
		switch(event.getActionMasked())
		{
		case MotionEvent.ACTION_DOWN:
			float rects[] = new float[len + 4];
			for( cur = 0; cur < len; cur++ )
				rects[cur] = m_rects[cur];
			len += 4;
			rects[cur + 0] = event.getX();
			rects[cur + 1] = event.getY();
			rects[cur + 2] = event.getX();
			rects[cur + 3] = event.getY();
			m_rects = rects;
			break;
		case MotionEvent.ACTION_MOVE:
			m_rects[len - 2] = event.getX();
			m_rects[len - 1] = event.getY();
			break;
		case MotionEvent.ACTION_UP:
		case MotionEvent.ACTION_CANCEL:
			m_rects[len - 2] = event.getX();
			m_rects[len - 1] = event.getY();
			break;
		}
		invalidate();
		return true;
	}
	private boolean onTouchStamp(MotionEvent event)
	{
		if( m_status != STA_STAMP ) return false;
		int len = 0;
		if( m_rects != null ) len = m_rects.length;
		int cur = 0;
		switch(event.getActionMasked())
		{
		case MotionEvent.ACTION_DOWN:
			float rects[] = new float[len + 4];
			for( cur = 0; cur < len; cur++ )
				rects[cur] = m_rects[cur];
			len += 4;
			rects[cur + 0] = event.getX();
			rects[cur + 1] = event.getY();
			rects[cur + 2] = event.getX();
			rects[cur + 3] = event.getY();
			m_rects = rects;
			break;
		case MotionEvent.ACTION_MOVE:
			m_rects[len - 2] = event.getX();
			m_rects[len - 1] = event.getY();
			break;
		case MotionEvent.ACTION_UP:
		case MotionEvent.ACTION_CANCEL:
			m_rects[len - 2] = event.getX();
			m_rects[len - 1] = event.getY();
			break;
		}
		invalidate();
		return true;
	}
	private boolean onTouchNote(MotionEvent event)
	{
		if( m_status != STA_NOTE ) return false;
		switch(event.getActionMasked())
		{
		case MotionEvent.ACTION_UP:
			PDFPos pos = m_layout.vGetPos((int)event.getX(), (int)event.getY());
			VPage vpage = m_layout.vGetPage(pos.pageno);
			Page page = m_doc.GetPage(vpage.GetPageNo());
			if( page != null )
			{
				page.ObjsStart();
				float pt[] = new float[2];
				pt[0] = pos.x;
				pt[1] = pos.y;
				page.AddAnnotText(pt);
				m_layout.vRenderSync(vpage);
				invalidate();
				page.Close();
				if( m_listener != null )
					m_listener.OnPageModified(vpage.GetPageNo());
			}
			break;
		}
		return true;
	}
	@Override
	public boolean onTouchEvent(MotionEvent event)
	{
		if( m_layout == null ) return false;
		if( onTouchNone(event) ) return true;
		if( onTouchZoom(event) ) return true;
		if( onTouchSelect(event) ) return true;
		if( onTouchInk(event) ) return true;
		if( onTouchRect(event) ) return true;
		if( onTouchEllipse(event) ) return true;
		if( onTouchNote(event) ) return true;
		if( onTouchLine(event) ) return true;
		if( onTouchStamp(event) ) return true;
		if( onTouchAnnot(event) ) return true;
		return true;
	}
	@Override
	public void computeScroll()
	{
		if( m_layout != null && m_layout.vScrollCompute() )
			invalidate();
	}
	public void PDFSetView(int style)
	{
		PDFPos pos = null;
		if(m_layout != null)
			pos = m_layout.vGetPos(0, 0);
		PDFClose();
        switch( style )
        {
        case 3:
        {
        	PDFLayoutDual layout = new PDFLayoutDual(getContext());
        	boolean paras[] = new boolean[m_doc.GetPageCount()];
        	int cur = 0;
        	while( cur < paras.length )
        	{
        		paras[cur] = false;
        		cur++;
        	}
        	layout.vSetLayoutPara(null, paras, m_rtol);
            m_layout = layout;
        }
            break;
        case 4:
        case 6:
        {
        	PDFLayoutDual layout = new PDFLayoutDual(getContext());
        	layout.vSetLayoutPara(null, null, m_rtol);
            m_layout = layout;
        }
            break;
        default:
        {
        	PDFLayoutVert layout = new PDFLayoutVert(getContext());
        	m_layout = layout;
        }
            break;
        }
        m_layout.vOpen(m_doc, this);
        if( getWidth() > 0 && getHeight() > 0 )
        {
	        m_layout.vResize(getWidth(), getHeight());
			if( m_goto_pageno >= 0 )
			{
				m_layout.vGotoPage(m_goto_pageno);
				m_goto_pageno = -1;
				invalidate();
			}
			else if( pos != null )
			{
				m_layout.vSetPos(0, 0, pos);
				m_layout.vMoveEnd();
			}
        }
        invalidate();
	}
	public void PDFOpen(Document doc, PDFLayoutListener listener)
	{
		m_doc = doc;
		m_listener = listener;
		PDFSetView(Global.def_view);
	}
	public void PDFGotoPage(int pageno)
	{
		if( m_layout == null ) return;
		if( m_layout.vGetHeight() <= 0 || m_layout.vGetWidth() <= 0 )
			m_goto_pageno = pageno;
		else
		{
			m_layout.vGotoPage(pageno);
			invalidate();
		}
	}
	public void PDFClose()
	{
		if(m_layout != null)
		{
			PDFCancel();
			PDFEndAnnot();
			m_layout.vClose();
			m_layout = null;
			m_status = STA_NONE;
			m_zooming = false;
			m_pageno = -1;
		}
	}
	public void OnPageChanged(int pageno)
	{
		m_pageno = pageno;
	}
	public void OnPageRendered(int pageno)
	{
		invalidate();
	}
	public void OnFound(boolean found)
	{
		if(found) invalidate();
		else Toast.makeText(getContext(), "no more found", Toast.LENGTH_SHORT).show();
	}
	public void OnPageDisplayed(Canvas canvas, VPage vpage)
	{
		// TODO Auto-generated method stub
	}
	public void OnTimer()
	{
		if( m_layout != null )
		{
			if(m_zooming && m_layout.vZoomEnd())
			{
				m_zooming = false;
				invalidate();
			}
			else if(!m_layout.vRenderFinished())
				invalidate();
		}
	}

	public void PDFSetInk(int code)
	{
		if( code == 0 )//start
		{
			m_status = STA_INK;
			m_ink = new Ink(Global.inkWidth);
		}
		else if( code == 1 )//end
		{
			m_status = STA_NONE;
			if( m_annot_page != null )
			{
				Page page = m_doc.GetPage(m_annot_page.GetPageNo());
				if( page != null )
				{
					page.ObjsStart();
					Matrix mat = m_annot_page.CreateInvertMatrix(m_layout.vGetX(), m_layout.vGetY());
					mat.TransformInk(m_ink);
					page.AddAnnotInk(m_ink);
					mat.Destroy();
					m_layout.vRenderSync(m_annot_page);
					page.Close();
					if( m_listener != null )
						m_listener.OnPageModified(m_annot_page.GetPageNo());
				}
			}
			if( m_ink != null ) m_ink.Destroy();
			m_ink = null;
			m_annot_page = null;
			invalidate();
		}
		else//cancel
		{
			m_status = STA_NONE;
			m_ink.Destroy();
			m_ink = null;
			m_annot_page = null;
			invalidate();
		}
	}
	public void PDFSetRect(int code)
	{
		if( code == 0 )//start
		{
			m_status = STA_RECT;
		}
		else if( code == 1 )//end
		{
			if( m_rects != null )
			{
				int len = m_rects.length;
				int cur;
				PDFVPageSet pset = new PDFVPageSet(len);
				for( cur = 0; cur < len; cur += 4 )
				{
					PDFPos pos = m_layout.vGetPos((int)m_rects[cur], (int)m_rects[cur + 1]);
					VPage vpage = m_layout.vGetPage(pos.pageno);
					Page page = m_doc.GetPage(vpage.GetPageNo());
					if( page != null )
					{
						page.ObjsStart();
						Matrix mat = vpage.CreateInvertMatrix(m_layout.vGetX(), m_layout.vGetY());
						float rect[] = new float[4];
						if( m_rects[cur] > m_rects[cur + 2] ) 
						{
							rect[0] = m_rects[cur + 2];
							rect[2] = m_rects[cur];
						}
						else
						{
							rect[0] = m_rects[cur];
							rect[2] = m_rects[cur + 2];
						}
						if( m_rects[cur + 1] > m_rects[cur + 3] ) 
						{
							rect[1] = m_rects[cur + 3];
							rect[3] = m_rects[cur + 1];
						}
						else
						{
							rect[1] = m_rects[cur + 1];
							rect[3] = m_rects[cur + 3];
						}
						mat.TransformRect(rect);
						page.AddAnnotRect(rect, vpage.ToPDFSize(3), 0x80FF0000, 0x800000FF);
						mat.Destroy();
						pset.Insert(vpage);
						page.Close();
					}
				}
				for( cur = 0; cur < pset.pages_cnt; cur++ )
				{
					VPage vpage = pset.pages[cur];
					m_layout.vRenderSync(vpage);
					if( m_listener != null )
						m_listener.OnPageModified(vpage.GetPageNo());
				}
			}
			m_status = STA_NONE;
			m_rects = null;
			invalidate();
		}
		else//cancel
		{
			m_status = STA_NONE;
			m_rects = null;
			invalidate();
		}
	}
	public void PDFSetEllipse(int code)
	{
		if( code == 0 )//start
		{
			m_status = STA_ELLIPSE;
		}
		else if( code == 1 )//end
		{
			if( m_rects != null )
			{
				int len = m_rects.length;
				int cur;
				PDFVPageSet pset = new PDFVPageSet(len);
				for( cur = 0; cur < len; cur += 4 )
				{
					PDFPos pos = m_layout.vGetPos((int)m_rects[cur], (int)m_rects[cur + 1]);
					VPage vpage = m_layout.vGetPage(pos.pageno);
					Page page = m_doc.GetPage(vpage.GetPageNo());
					if( page != null )
					{
						page.ObjsStart();
						Matrix mat = vpage.CreateInvertMatrix(m_layout.vGetX(), m_layout.vGetY());
						float rect[] = new float[4];
						if( m_rects[cur] > m_rects[cur + 2] ) 
						{
							rect[0] = m_rects[cur + 2];
							rect[2] = m_rects[cur];
						}
						else
						{
							rect[0] = m_rects[cur];
							rect[2] = m_rects[cur + 2];
						}
						if( m_rects[cur + 1] > m_rects[cur + 3] ) 
						{
							rect[1] = m_rects[cur + 3];
							rect[3] = m_rects[cur + 1];
						}
						else
						{
							rect[1] = m_rects[cur + 1];
							rect[3] = m_rects[cur + 3];
						}
						mat.TransformRect(rect);
						page.AddAnnotEllipse(rect, vpage.ToPDFSize(3), 0x80FF0000, 0x800000FF);
						mat.Destroy();
						page.Close();
						pset.Insert(vpage);
					}
				}
				for( cur = 0; cur < pset.pages_cnt; cur++ )
				{
					VPage vpage = pset.pages[cur];
					m_layout.vRenderSync(vpage);
					if( m_listener != null )
						m_listener.OnPageModified(vpage.GetPageNo());
				}
			}
			m_status = STA_NONE;
			m_rects = null;
			invalidate();
		}
		else//cancel
		{
			m_status = STA_NONE;
			m_rects = null;
			invalidate();
		}
	}
	public void PDFSetSelect()
	{
		if( m_status == STA_SELECT )
		{
			m_status = STA_NONE;
		}
		else
		{
			m_status = STA_SELECT;
		}
	}
	public void PDFSetNote()
	{
		if( m_status == STA_NOTE )
		{
			m_status = STA_NONE;
		}
		else
		{
			m_status = STA_NOTE;
		}
	}
	public void PDFSetLine( int code )
	{
		if( code == 0 )//start
		{
			m_status = STA_LINE;
		}
		else if( code == 1 )//end
		{
			if( m_rects != null )
			{
				int len = m_rects.length;
				int cur;
				float[] pt1 = new float[2];
				float[] pt2 = new float[2];
				PDFVPageSet pset = new PDFVPageSet(len);
				for( cur = 0; cur < len; cur += 4 )
				{
					PDFPos pos = m_layout.vGetPos((int)m_rects[cur], (int)m_rects[cur + 1]);
					VPage vpage = m_layout.vGetPage(pos.pageno);
					pt1[0] = m_rects[cur];
					pt1[1] = m_rects[cur + 1];
					pt2[0] = m_rects[cur + 2];
					pt2[1] = m_rects[cur + 3];
					Page page = m_doc.GetPage(vpage.GetPageNo());
					if( page != null )
					{
						page.ObjsStart();
						Matrix mat = vpage.CreateInvertMatrix(m_layout.vGetX(), m_layout.vGetY());
						mat.TransformPoint(pt1);
						mat.TransformPoint(pt2);
						page.AddAnnotLine(pt1, pt2, 1, 0, vpage.ToPDFSize(3), 0x80FF0000, 0x800000FF);
						mat.Destroy();
						page.Close();
						pset.Insert(vpage);
					}
				}
				for( cur = 0; cur < pset.pages_cnt; cur++ )
				{
					VPage vpage = pset.pages[cur];
					m_layout.vRenderSync(vpage);
					if( m_listener != null )
						m_listener.OnPageModified(vpage.GetPageNo());
				}
			}
			m_status = STA_NONE;
			m_rects = null;
			invalidate();
		}
		else//cancel
		{
			m_status = STA_NONE;
			m_rects = null;
			invalidate();
		}
	}
	public void PDFSetStamp(int code)
	{
		if( code == 0 )//start
		{
			m_status = STA_STAMP;
			m_icon = BitmapFactory.decodeResource(this.getResources(), R.drawable.pdf_icon);  
		}
		else if( code == 1 )//end
		{
			if( m_rects != null )
			{
				int len = m_rects.length;
				int cur;
				PDFVPageSet pset = new PDFVPageSet(len);
				for( cur = 0; cur < len; cur += 4 )
				{
					PDFPos pos = m_layout.vGetPos((int)m_rects[cur], (int)m_rects[cur + 1]);
					VPage vpage = m_layout.vGetPage(pos.pageno);
					Page page = m_doc.GetPage(vpage.GetPageNo());
					if( page != null )
					{
						Matrix mat = vpage.CreateInvertMatrix(m_layout.vGetX(), m_layout.vGetY());
						float rect[] = new float[4];
						if( m_rects[cur] > m_rects[cur + 2] ) 
						{
							rect[0] = m_rects[cur + 2];
							rect[2] = m_rects[cur];
						}
						else
						{
							rect[0] = m_rects[cur];
							rect[2] = m_rects[cur + 2];
						}
						if( m_rects[cur + 1] > m_rects[cur + 3] ) 
						{
							rect[1] = m_rects[cur + 3];
							rect[3] = m_rects[cur + 1];
						}
						else
						{
							rect[1] = m_rects[cur + 1];
							rect[3] = m_rects[cur + 3];
						}
						mat.TransformRect(rect);
						page.ObjsStart();
						page.AddAnnotBitmap(m_icon, true, rect);
						page.Close();
						mat.Destroy();
						pset.Insert(vpage);
					}
				}
				for( cur = 0; cur < pset.pages_cnt; cur++ )
				{
					VPage vpage = pset.pages[cur];
					m_layout.vRenderSync(vpage);
					if( m_listener != null )
						m_listener.OnPageModified(vpage.GetPageNo());
				}
			}
			m_status = STA_NONE;
			m_rects = null;
			invalidate();
			m_icon.recycle();
			m_icon = null;
		}
		else//cancel
		{
			m_status = STA_NONE;
			m_rects = null;
			invalidate();
			m_icon.recycle();
			m_icon = null;
		}
	}
	public void PDFCancel()
	{
		if( m_status == STA_NOTE ) PDFSetNote();
		if( m_status == STA_RECT ) PDFSetRect(2);
		if( m_status == STA_INK ) PDFSetInk(2);
		if( m_status == STA_LINE ) PDFSetLine(2);
		if( m_status == STA_STAMP ) PDFSetStamp(2);
		if( m_status == STA_ELLIPSE ) PDFSetEllipse(2);
		if( m_status == STA_ANNOT ) PDFEndAnnot();
		invalidate();
	}
	public void PDFRemoveAnnot()
	{
		if( m_status != STA_ANNOT || !m_doc.CanSave() ) return;
		m_annot.RemoveFromPage();
		m_annot = null;
		m_layout.vRenderSync(m_annot_page);
		if( m_listener != null )
			m_listener.OnPageModified(m_annot_page.GetPageNo());
		PDFEndAnnot();
	}
	public void PDFEndAnnot()
	{
		if( m_status != STA_ANNOT ) return;
		m_annot_page = null;
		m_annot_pos = null;
		m_annot = null;
		invalidate();
		m_status = STA_NONE;
		if( m_pEdit != null && m_pEdit.isShowing() ) m_pEdit.dismiss();
		if( m_pCombo != null && m_pCombo.isShowing() ) m_pCombo.dismiss();
		if( m_listener != null )
			m_listener.OnAnnotClicked(null, null);
	}
	public void PDFPerformAnnot()
	{
		if( m_status != STA_ANNOT ) return;
		Page page = m_doc.GetPage(m_annot_page.GetPageNo());
		if( page == null || m_annot == null ) return;
		page.ObjsStart();
		int dest = m_annot.GetDest();
		if( dest >= 0 )
		{
			m_layout.vGotoPage(dest);
			invalidate();
		}
		String js = m_annot.GetJS();
		if( m_listener != null && js != null )
			m_listener.OnOpenJS(js);
		String uri = m_annot.GetURI();
		if( m_listener != null && uri != null )
			m_listener.OnOpenURI(uri);
		int index;
		String mov = m_annot.GetMovie();
		if( mov != null )
		{
			index = -1;
			if( index < 0 ) index = mov.lastIndexOf('\\');
			if( index < 0 ) index = mov.lastIndexOf('/');
			if( index < 0 ) index = mov.lastIndexOf(':');
			String save_file = Global.tmp_path + "/" + mov.substring(index + 1);
			m_annot.GetMovieData(save_file);
			if( m_listener != null )
				m_listener.OnOpenMovie(save_file);
		}
		String snd = m_annot.GetSound();
		if( snd != null )
		{
			int paras[] = new int[4];
			index = -1;
			if( index < 0 ) index = snd.lastIndexOf('\\');
			if( index < 0 ) index = snd.lastIndexOf('/');
			if( index < 0 ) index = snd.lastIndexOf(':');
			String save_file = Global.tmp_path + "/" + snd.substring(index + 1);
			m_annot.GetSoundData(paras, save_file);
			if( m_listener != null )
				m_listener.OnOpenSound(paras, save_file);
		}
		String att = m_annot.GetAttachment();
		if( att != null )
		{
			index = -1;
			if( index < 0 ) index = att.lastIndexOf('\\');
			if( index < 0 ) index = att.lastIndexOf('/');
			if( index < 0 ) index = att.lastIndexOf(':');
			String save_file = Global.tmp_path + "/" + att.substring(index + 1);
			m_annot.GetAttachmentData(save_file);
			if( m_listener != null )
				m_listener.OnOpenAttachment(save_file);
		}
		String f3d = m_annot.Get3D();
		if( f3d != null )
		{
			index = -1;
			if( index < 0 ) index = f3d.lastIndexOf('\\');
			if( index < 0 ) index = f3d.lastIndexOf('/');
			if( index < 0 ) index = f3d.lastIndexOf(':');
			String save_file = Global.tmp_path + "/" + f3d.substring(index + 1);
			m_annot.Get3DData(save_file);
			if( m_listener != null )
				m_listener.OnOpen3D(save_file);
		}

		int check = m_annot.GetCheckStatus();
		if( m_doc.CanSave() && check >= 0 )
		{
			switch( check )
			{
			case 0:
				m_annot.SetCheckValue(true);
				break;
			case 1:
				m_annot.SetCheckValue(false);
				break;
			case 2:
			case 3:
				m_annot.SetRadio();
				break;
			}
			m_layout.vRenderSync(m_annot_page);
			if( m_listener != null )
				m_listener.OnPageModified(m_annot_page.GetPageNo());
		}

		boolean reset = m_annot.GetReset();
		if( reset && m_doc.CanSave() )
		{
			m_annot.SetReset();
			m_layout.vRenderSync(m_annot_page);
			if( m_listener != null )
				m_listener.OnPageModified(m_annot_page.GetPageNo());
		}
		String tar = m_annot.GetSubmitTarget();
		if( tar != null )
		{
			if( m_listener != null )
				m_listener.OnOpenURI(tar + "?" + m_annot.GetSubmitTarget());
		}
		page.Close();
		PDFEndAnnot();
	}
	public final void PDFFindStart( String key, boolean match_case, boolean whole_word )
	{
		m_layout.vFindStart(key, match_case, whole_word);
	}
	public final void PDFFind(int dir)
	{
		m_layout.vFind(dir);
	}
	public boolean PDFSetSelMarkup(int type)
	{
		if( m_status == STA_SELECT && m_sel != null && m_sel.SetSelMarkup(type) )
		{
			m_layout.vRenderSync(m_annot_page);
			invalidate();
			return true;
		}
		else
		{
			return false;
		}
	}
	public void onDismiss()
	{
		if( m_edit_type == 1 )//edit box
		{
			EditText edit = (EditText)m_pEdit.getContentView().findViewById(R.id.annot_text);
			m_annot.SetEditText(edit.getText().toString());
			m_layout.vRenderSync(m_annot_page);
			if( m_listener != null )
				m_listener.OnPageModified(m_annot_page.GetPageNo());
			PDFEndAnnot();
		}
		if( m_edit_type == 2 )//combo
		{
			if( m_combo_item >= 0 )
			{
				m_annot.SetComboItem(m_combo_item);
				m_layout.vRenderSync(m_annot_page);
				if( m_listener != null )
					m_listener.OnPageModified(m_annot_page.GetPageNo());
			}
			m_combo_item = -1;
			PDFEndAnnot();
		}
		m_edit_type = 0;
	}
	public void onItemClick(AdapterView<?> arg0, View arg1, int arg2, long arg3)
	{
		m_combo_item = arg2;
		m_pCombo.dismiss();
	}
	public final int GetCurrPage()
	{
		return m_pageno;
	}
}

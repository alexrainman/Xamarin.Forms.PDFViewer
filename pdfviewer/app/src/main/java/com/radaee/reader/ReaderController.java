package com.radaee.reader;

import android.content.Context;
import android.graphics.Canvas;
import android.util.AttributeSet;
import android.view.MotionEvent;
import android.view.View;
import com.radaee.pdf.Document;
import com.radaee.view.*;
import com.radaee.view.PDFView.PDFPos;

/**
 * Created with IntelliJ IDEA.
 * User: Erick
 * Date: 1/21/13
 * Time: 11:12 PM
 * To change this template use File | Settings | File Templates.
 */
public class ReaderController extends View implements PDFView.PDFViewListener
{
    PDFView m_pdv;
    public boolean m_lock_resize = false;
    private int m_save_w = 0;
    private int m_save_h = 0;
    private int m_cur_page = 0;

    public ReaderController(Context context)
    {
        super(context);
    }

    public ReaderController(Context context, AttributeSet attrs)
    {
        super(context, attrs);
    }

    protected void onDraw(Canvas canvas)
    {
        m_pdv.vDraw(canvas);
        // Paint paint = new Paint();
        // paint.setARGB(255, 255, 0, 0);
        // canvas.drawText("myText", 20, 20, paint);
    }

    public void open(Document doc)
    {
        m_pdv = new PDFViewDual(getContext());
        m_pdv.vOpen(doc, 4, 0xFFCCCCCC, this);
        //boolean paras[] = new boolean[doc.GetPageCount()];
        //((PDFViewDual)m_pdv).vSetLayoutPara(null, paras, false);
        invalidate();
    }

    @Override
	public boolean onTouchEvent(MotionEvent event)
    {
    	if( m_pdv != null )
    		return m_pdv.vTouchEvent(event);
    	else
    		return true;
    }
    
    protected void onSizeChanged (int w, int h, int oldw, int oldh)
    {
        m_save_w = w;
        m_save_h = h;
        if( m_pdv != null && !m_lock_resize )
            m_pdv.vResize(w, h);
    }

    public void close()
    {
        if (m_pdv != null)
        {
            m_pdv.vClose();
        }
        m_pdv = null;
    }

	public void OnPDFPageChanged(int pageno)
	{
		m_cur_page = pageno;
	}

	public boolean OnPDFDoubleTapped(float x, float y)
	{
		return false;
	}

	public boolean OnPDFSingleTapped(float x, float y)
	{
		return false;
	}

	public void OnPDFLongPressed(float x, float y)
	{
	}

	public void OnPDFShowPressed(float x, float y)
	{
	}

	public void OnPDFSelectEnd()
	{
	}

	public void OnPDFFound(boolean found)
	{
	}

	public void OnPDFInvalidate(boolean post)
	{
		if( post ) postInvalidate();
		else invalidate();
	}

	public void OnPDFPageDisplayed(Canvas canvas, PDFVPage vpage)
	{
	}

	@Override
	public void computeScroll()
	{
		if( m_pdv == null ) return;
		m_pdv.vComputeScroll();
	}

	public void OnPDFSelecting(Canvas canvas, int[] rect1, int[] rect2) {
		// TODO Auto-generated method stub
		
	}
}

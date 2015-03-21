package com.radaee.reader;
import com.radaee.pdf.*;
import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.Bitmap.Config;
import android.graphics.Canvas;
import android.util.AttributeSet;
import android.view.MotionEvent;
import android.view.View;

/**
 * test view<br/>
 * this view clip one page as 100*100 blocks.<br/>
 * every block is a DIB data.
 * @author Radaee
 *
 */
public class PDFInk extends View
{
	Bitmap bitmap;
	int win_cx = 0;
	int win_cy = 0;
	HWriting ink = null;
	boolean pressed = false;
	public PDFInk(Context context)
	{
		super(context);
	}
	public PDFInk(Context context, AttributeSet attrs)
	{
		super(context, attrs);
	}
	protected void onSizeChanged (int w, int h, int oldw, int oldh)
	{
		win_cx = w;
		win_cy = h;
		if( win_cx > 0 && win_cy > 0 )
		{
			if( ink != null ) ink.Destroy();
			if( bitmap != null ) bitmap.recycle();
			ink = new HWriting( win_cx, win_cy, 2, 6, 255, 0, 0 );
			bitmap = Bitmap.createBitmap(win_cx, win_cy, Config.ARGB_8888);
		}
	}
	protected void onDraw( Canvas canvas )
	{
		if( ink == null ) return;
		bitmap.eraseColor(0);
		BMP bmp = new BMP();
		bmp.Create(bitmap);
		ink.OnDraw(bmp);
		bmp.Free(bitmap);
		canvas.drawBitmap(bitmap, 0, 0, null);
	}
	public boolean onTouchEvent (MotionEvent event)
	{
		switch( event.getActionMasked() )
		{
		case MotionEvent.ACTION_DOWN:
			if( !pressed )
			{
				pressed = true;
				if( ink != null )
					ink.OnDown(event.getX(), event.getY());
				invalidate();
			}
			break;
		case MotionEvent.ACTION_MOVE:
			if( pressed )
			{
				if( ink != null )
					ink.OnMove(event.getX(), event.getY());
				invalidate();
			}
			break;
		case MotionEvent.ACTION_UP:
			if( pressed )
			{
				if( ink != null )
					ink.OnUp(event.getX(), event.getY());
				pressed = false;
				invalidate();
			}
			break;
		}
		return true;
	}
}

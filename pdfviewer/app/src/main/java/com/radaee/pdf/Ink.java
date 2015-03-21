package com.radaee.pdf;

import android.graphics.Canvas;
import android.graphics.Paint;
import android.graphics.Paint.Style;
import android.graphics.Path;
import android.graphics.Paint.Cap;
import android.graphics.Paint.Join;

/**
 * class for ink.
 * @author radaee
 *
 */
public class Ink 
{
	protected long hand = 0;
	protected int color = 0;
	protected float width = 0;
	private static native int create( float line_w, int color, int style );
	private static native void onDown( long hand, float x, float y );
	private static native void onMove( long hand, float x, float y );
	private static native void onUp( long hand, float x, float y );
	private static native int getNodeCount( long hand );
	private static native int getNode( long hand, int index, float[] pt );
	private static native void destroy( long hand );
	/**
	 * constructor for ink.
	 * @param line_w width of line.
	 */
	public Ink( float line_w )
	{
		width = line_w;
		color = Global.inkColor;
		hand = create( line_w, color, 1 );
	}
	/**
	 * destroy and free memory.
	 */
	public final void Destroy()
	{
		destroy( hand );
		hand = 0;
	}
	/**
	 * call when click down
	 * @param x x value of point in this object.
	 * @param y y value of point in this object.
	 */
	public final void OnDown( float x, float y )
	{
		onDown( hand, x, y );
	}
	/**
	 * call when moving
	 * @param x x value of point in this object.
	 * @param y y value of point in this object.
	 */
	public final void OnMove( float x, float y )
	{
		onMove( hand, x, y );
	}
	/**
	 * call when click up
	 * @param x x value of point in this object.
	 * @param y y value of point in this object.
	 */
	public final void OnUp( float x, float y )
	{
		onUp( hand, x, y );
	}
	/**
	 * draw to canvas
	 * @param canvas Canvas to draw
	 */
	public void OnDraw(Canvas canvas)
	{
		int index = 0;
		int cnt = getNodeCount(hand);
		float pt1[] = new float[2];
		float pt2[] = new float[2];
		Paint paint = new Paint();
		Path path = new Path();
		paint.setStrokeCap(Cap.ROUND);
		paint.setStrokeJoin(Join.ROUND);
		paint.setStrokeWidth(width);
		paint.setColor(color);
		paint.setStyle(Style.STROKE);
		paint.setAntiAlias(true);
		path.reset();
		while( index < cnt )
		{
			int op = getNode( hand, index, pt1 );
			switch( op )
			{
			case 1:
				path.lineTo(pt1[0], pt1[1]);
				index++;
				break;
			case 2:
				getNode( hand, index + 1, pt2 );
				path.quadTo(pt1[0], pt1[1], pt2[0], pt2[1]);
				index += 2;
				break;
			default:
				path.moveTo(pt1[0], pt1[1]);
				index++;
				break;
			}
		}
		canvas.drawPath(path, paint);
	}
	public void OnDraw(Canvas canvas, float scrollx, float scrolly)
	{
		int index = 0;
		int cnt = getNodeCount(hand);
		float pt1[] = new float[2];
		float pt2[] = new float[2];
		Paint paint = new Paint();
		Path path = new Path();
		paint.setStrokeCap(Cap.ROUND);
		paint.setStrokeJoin(Join.ROUND);
		paint.setStrokeWidth(width);
		paint.setColor(color);
		paint.setStyle(Style.STROKE);
		paint.setAntiAlias(true);
		path.reset();
		while( index < cnt )
		{
			int op = getNode( hand, index, pt1 );
			switch( op )
			{
			case 1:
				path.lineTo(pt1[0] + scrollx, pt1[1] + scrolly);
				index++;
				break;
			case 2:
				getNode( hand, index + 1, pt2 );
				path.quadTo(pt1[0] + scrollx, pt1[1] + scrolly, pt2[0] + scrollx, pt2[1] + scrolly);
				index += 2;
				break;
			default:
				path.moveTo(pt1[0] + scrollx, pt1[1] + scrolly);
				index++;
				break;
			}
		}
		canvas.drawPath(path, paint);
	}
}

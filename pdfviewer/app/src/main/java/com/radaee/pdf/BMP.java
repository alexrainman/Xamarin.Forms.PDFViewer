package com.radaee.pdf;

import android.graphics.Bitmap;

public class BMP
{
	/**
	 * lock Bitmap object, and get a handle.
	 * 
	 * @param bitmap
	 *            Bitmap object.
	 * @return hand handle value.
	 */
	private static native long get(Bitmap bitmap);

	/**
	 * unlock Bitmap object, and free the handle.
	 * 
	 * @param bitmap
	 *            Bitmap object that passed to lockBitmap.
	 * @param bmp
	 *            handle value, that returned by lockBitmap.
	 */
	private static native void free(Bitmap bitmap, long bmp);
	/**
	 * draw Bitmap object to a dib
	 * @param dib
	 * @param bmp handle value, that returned by lockBitmap.
	 * @param x
	 * @param y
	 */
	private static native void drawToDIB( long bmp, long dib, int x, int y );

	/**
	 * fill solid rectangle to bmp.
	 * 
	 * @param bmp
	 *            handle value, that returned by lockBitmap.
	 * @param color
	 *            the color to fill, formatted: 0xAARRGGBB, AA: alpha value.
	 * @param x
	 * @param y
	 * @param width
	 * @param height
	 * @param mode
	 * <br/>
	 *            0: mix color by source pixels with alpha channel. <br/>
	 *            1: replace pixels.
	 */
	private static native void drawRect(long bmp, int color, int x, int y, int width, int height, int mode);

	/**
	 * invert all colors for locked bmp.
	 * 
	 * @param bmp
	 *            handle value, that returned by lockBitmap.
	 */
	private static native void invert(long bmp);

	protected long hand = 0;
	private int m_w = 0;
	private int m_h = 0;
	public final void Create(Bitmap bmp)
	{
		m_w = bmp.getWidth();
		m_h = bmp.getHeight();
		hand = get(bmp);
	}
	public final void DrawToDIB(DIB dib, int x, int y)
	{
		drawToDIB(hand, dib.hand, x, y);
	}
	/**
	 * fill solid rectangle to bmp.
	 * 
	 * @param color
	 *            the color to fill, formatted: 0xAARRGGBB, AA: alpha value.
	 * @param x
	 * @param y
	 * @param width
	 * @param height
	 * @param mode
	 * <br/>
	 *            0: mix color by source pixels with alpha channel. <br/>
	 *            1: replace pixels.
	 */
	public final void DrawRect(int color, int x, int y, int width, int height, int mode)
	{
		drawRect(hand, color, x, y, width, height, mode);
	}
	public final void Invert()
	{
		invert(hand);
	}
	public final void Free(Bitmap bmp)
	{
		free(bmp, hand);
		hand = 0;
	}
	public final int GetWidth()
	{
		return m_w;
	}
	public final int GetHeight()
	{
		return m_h;
	}
}

package com.radaee.pdf;

public class DIB
{
	/**
	 * create or resize dib, and reset all pixels in dib.<br/>
	 * if dib is 0, function create a new dib object.<br/>
	 * otherwise function resize the dib object.
	 */
	private static native long get(long dib, int width, int height);
	/**
	 * draw a dib to another dib
	 * @param dst_dib
	 * @param src_dib
	 * @param x
	 * @param y
	 */
	private static native void drawToDIB( long dib, long dst_dib, int x, int y );
	/**
	 * draw dib to bmp.
	 * 
	 * @param bmp
	 *            handle value, that returned by lockBitmap.
	 * @param dib
	 * @param x
	 *            origin position in bmp.
	 * @param y
	 *            origin position in bmp.
	 */
	private static native void drawToBmp(long dib, long bmp, int x, int y);
	/**
	 * draw dib to bmp, with scale
	 * @param bmp
	 * @param dib
	 * @param x
	 * @param y
	 * @param w
	 * @param h
	 */
	private static native void drawToBmp2(long dib, long bmp, int x, int y, int w, int h);
	private static native void drawRect(long dib, int color, int x, int y, int width, int height, int mode);

	/**
	 * free dib object.
	 */
	private static native int free(long dib);
	protected long hand = 0;
	public final boolean IsEmpty(){return hand == 0;}
	public final void CreateOrResize(int w, int h)
	{
		hand = get(hand, w, h);
	}
	public final void DrawToDIB(DIB dst, int x, int y)
	{
		drawToDIB(hand, dst.hand, x, y);
	}
	public final void DrawToBmp(BMP bmp, int x, int y)
	{
		drawToBmp(hand, bmp.hand, x, y);
	}
	/**
	 * draw dib to bmp, with scale
	 * @param bmp
	 * @param x
	 * @param y
	 * @param w
	 * @param h
	 */
	public final void DrawToBmp2(BMP bmp, int x, int y, int w, int h)
	{
		drawToBmp2(hand, bmp.hand, x, y, w, h);
	}
	public final void DrawRect(int color, int x, int y, int width, int height, int mode)
	{
		drawRect(hand, color, x, y, width, height, mode);
	}
	public final void Free()
	{
		free(hand);
		hand = 0;
	}
}

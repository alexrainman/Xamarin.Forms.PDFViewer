package com.radaee.pdf;

/**
class for PDF Matrix.
@author Radaee
@version 1.1
*/
public class Matrix
{
	protected long hand = 0;
	private static native long create( float xx, float yx, float xy, float yy, float x0, float y0 );
	private static native long createScale( float sx, float sy, float x0, float y0 );
	private static native void invert( long matrix );
	private static native void transformPath( long matrix, long path );
	private static native void transformInk( long matrix, long ink );
	private static native void transformRect( long matrix, float[] rect );
	private static native void transformPoint( long matrix, float[] point );
	private static native void destroy( long matrix );
	/**
	 * constructor for full values.
	 * @param xx
	 * @param yx
	 * @param xy
	 * @param yy
	 * @param x0
	 * @param y0
	 */
	public Matrix( float xx, float yx, float xy, float yy, float x0, float y0 )
	{
		hand = create( xx, yx, xy, yy, x0, y0 );
	}
	/**
	 * constructor for scaled values.<br/>
	 * xx = sx;<br/>
	 * yx = 0;<br/>
	 * xy = 0;<br/>
	 * yx = sy;
	 * @param sx
	 * @param sy
	 * @param x0
	 * @param y0
	 */
	public Matrix( float sx, float sy, float x0, float y0 )
	{
		hand = createScale( sx, sy, x0, y0 );
	}
	public final void Invert()
	{
		invert( hand );
	}
	public final void TransformPath( Path path )
	{
		transformPath( hand, path.m_hand );
	}
	public final void TransformInk( Ink ink )
	{
		transformInk( hand, ink.hand );
	}
	public final void TransformRect( float[] rect )
	{
		transformRect( hand, rect );
	}
	public final void TransformPoint( float[] point )
	{
		transformPoint( hand, point );
	}
	/**
	 * destroy and free memory.
	 */
	public final void Destroy()
	{
		destroy( hand );
		hand = 0;
	}
}

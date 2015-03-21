package com.radaee.reader;
import com.radaee.pdf.*;
import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.Bitmap.Config;
import android.graphics.Canvas;
import android.util.AttributeSet;
import android.view.View;

/**
 * test view<br/>
 * this view clip one page as 100*100 blocks.<br/>
 * every block is a DIB data.
 * @author Radaee
 *
 */
public class PDFCrop extends View
{
	private Document m_doc = null;
	static private final int blk_w = 100;
	static private final int blk_h = 100;
	static private final float ratio = 1.0f;
	private DIB dibs[][];
	Bitmap bitmap;
	public PDFCrop(Context context)
	{
		super(context);
	}
	public PDFCrop(Context context, AttributeSet attrs)
	{
		super(context, attrs);
	}
	public void open( Document doc )
	{
		m_doc = doc;
		Page page = m_doc.GetPage(0);
		float w = m_doc.GetPageWidth(0) * ratio;
		float h = m_doc.GetPageHeight(0) * ratio;
		bitmap = Bitmap.createBitmap((int)w, (int)h, Config.ARGB_8888);
		bitmap.eraseColor(0xFFFFFFFF);
		int wcnt = (int)(w + blk_w - 1) / blk_w;
		int hcnt = (int)(h + blk_h - 1) / blk_h;
		dibs = new DIB[hcnt][wcnt];
		int y = 0;
		int hi = 0;
		while( hi < hcnt )
		{
			int x = 0;
			int wi = 0;
			while( wi < wcnt )
			{
				dibs[hi][wi] = new DIB();
				dibs[hi][wi].CreateOrResize(blk_w, blk_h);
				Matrix mat = new Matrix(ratio, -ratio, -x, h - y);
				page.RenderPrePare(dibs[hi][wi]);
				page.Render(dibs[hi][wi], mat);
				mat.Destroy();
				x += blk_w;
				wi++;
			}
			y += blk_h;
			hi++;
		}
		page.Close();
	}
	public void close()
	{
		float w = m_doc.GetPageWidth(0) * ratio;
		float h = m_doc.GetPageHeight(0) * ratio;
		int wcnt = (int)(w + blk_w - 1) / blk_w;
		int hcnt = (int)(h + blk_h - 1) / blk_h;
		int hi = 0;
		while( hi < hcnt )
		{
			int wi = 0;
			while( wi < wcnt )
			{
				dibs[hi][wi].Free();
				wi++;
			}
			hi++;
		}
		m_doc = null;
		bitmap.recycle();
	}
	protected void onDraw( Canvas canvas )
	{
		if( m_doc != null )
		{
			BMP bmp = new BMP();
			bmp.Create(bitmap);
			float w = m_doc.GetPageWidth(0) * ratio;
			float h = m_doc.GetPageHeight(0) * ratio;
			int wcnt = (int)(w + blk_w - 1) / blk_w;
			int hcnt = (int)(h + blk_h - 1) / blk_h;
			int y = 0;
			int hi = 0;
			while( hi < hcnt )
			{
				int x = 0;
				int wi = 0;
				while( wi < wcnt )
				{
					dibs[hi][wi].DrawToBmp(bmp, x, y);
					x += blk_w;
					wi++;
				}
				y += blk_h;
				hi++;
			}
			bmp.Free(bitmap);
			canvas.drawBitmap(bitmap, 0, 0, null);
		}
	}
}

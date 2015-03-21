package com.radaee.reader;

import java.io.RandomAccessFile;

import com.radaee.pdf.Document;
import com.radaee.pdf.Document.*;
import com.radaee.pdf.Global;
import com.radaee.pdf.Matrix;
import com.radaee.pdf.Page;
import com.radaee.pdf.Path;
import com.radaee.pdf.Page.*;
import com.radaee.pdf.PageContent;
import com.radaee.util.PDFAESStream;

import android.app.Activity;
import android.graphics.Bitmap;
import android.graphics.Bitmap.Config;
import android.graphics.PixelFormat;
import android.os.Bundle;
import android.view.WindowManager;

public class PDFTestAct extends Activity
{
	private Document m_doc;
	private PDFSimple m_view;
	private void NewImagePage(int pageno, float w, float h, String img_path)
	{
		Page page = m_doc.NewPage(pageno, w, h);//create A4 paper
		DocImage dimg = m_doc.NewImageJPEG(img_path);
		ResImage rimg = page.AddResImage(dimg);
		PageContent content = new PageContent();
		content.Create();//create content, do not forget.
		content.GSSave();
		Matrix mat = new Matrix( w, h, 0, 0 );
		content.GSSetMatrix(mat);
		mat.Destroy();
		content.DrawImage(rimg);
		content.GSRestore();
		//add content to page
		page.AddContent(content, true);
		content.Destroy();
		page.Close();
	}
	private void NewPage(int pageno, float w, float h)
	{
		Page page = m_doc.NewPage(pageno, w, h);//create A4 paper
		
		PageContent content = new PageContent();
		content.Create();//create content, do not forget.

		//set alpha for both fill and stroke
		DocGState dgs = m_doc.NewGState();
		dgs.SetFillAlpha(0x80);//set alpha value to 0.5
		dgs.SetStrokeAlpha(0x80);//set alpha value to 0.5
		ResGState rgs = page.AddResGState(dgs);
		content.GSSet(rgs);

		//set matrix for filling
		content.GSSave();
		Matrix mat = new Matrix( 1, 1, 40, 100 );
		content.GSSetMatrix(mat);
		mat.Destroy();

		//build a path object
		Path path = new Path();
		path.MoveTo(10, 10);
		path.LineTo(20, 12);
		path.CurveTo(30, 20, 20, 30, -10, 50);
		path.ClosePath();

		//fill it
		content.SetFillColor(0xFF0000);//set red color;
		content.FillPath(path, true);//using winding fill rule
		content.GSRestore();

		
		//set matrix for stroke
		content.GSSave();
		mat = new Matrix( 1, 1, 40, 200 );
		content.GSSetMatrix(mat);
		mat.Destroy();
		
		//stroke it
		content.SetStrokeColor(0xFF);//set blue color;
		content.SetStrokeWidth(4);//set stroke width
		content.StrokePath(path);
		content.GSRestore();

		//destroy the path
		path.Destroy();

		
		//prepare to write texts
		content.GSSave();
		mat = new Matrix( 1, 1, 80, 200 );
		content.GSSetMatrix(mat);
		mat.Destroy();

		DocFont dfont = m_doc.NewFontCID("DroidSansFallback", 3 | 8);//bold-italic and embed in horizontal writing
		ResFont rfont = page.AddResFont(dfont);

		content.TextBegin();
		content.TextSetFont(rfont, 16);//set font and size
		content.SetFillColor(0x8000);//set fill color to black-green.
		content.SetStrokeColor(0x80);//set stroke color to black-red.
		content.TextSetCharSpace(0);
		content.TextSetWordSpace(0.2f);
		content.TextSetLeading(16);
		content.TextSetRenderMode(2);//fill and stroke
		content.TextSetHScale(120);//set horizontal scale
		content.DrawText("Hello word!\rNice to meet you!");
		content.TextEnd();
		content.GSRestore();

		//write a bitmap
		content.GSSave();
		dgs = m_doc.NewGState();
		dgs.SetFillAlpha(255);//set alpha value to 1
		dgs.SetStrokeAlpha(255);//set alpha value to 1
		rgs = page.AddResGState(dgs);
		content.GSSet(rgs);
		Bitmap bmp = Bitmap.createBitmap(100, 100, Config.ARGB_8888);//must be ARGB_8888
		bmp.eraseColor(0xc0000080);
		DocImage dimg = m_doc.NewImage(bmp, true);
		bmp.recycle();
		ResImage rimg = page.AddResImage(dimg);
		mat = new Matrix( 80, 80, 80, 400 );
		content.GSSetMatrix(mat);
		mat.Destroy();
		content.DrawImage(rimg);
		content.GSRestore();


		//add content to page
		page.AddContent(content, true);
		content.Destroy();
		
		page.Close();
	}
	private void concat_pdf( String dst, String src )
	{
		Document doc_dst = new Document();
		Document doc_src = new Document();
		doc_dst.Open(dst, null);
		doc_dst.SetCache(Global.tmp_path + "/ttt.dat");
		doc_src.Open(src, null);
		ImportContext ctx = doc_dst.ImportStart(doc_src);
		int dstno = doc_dst.GetPageCount();
		int srccnt = doc_src.GetPageCount();
		int srcno = 0;
		while( srcno < srccnt )
		{
			doc_dst.ImportPage(ctx, srcno, dstno);
			dstno++;
			srcno++;
		}
		ctx.Destroy();
		doc_src.Close();
		doc_dst.Save();
		doc_dst.Close();
	}

	@Override
    public void onCreate(Bundle savedInstanceState)
	{
		super.onCreate(savedInstanceState);
        Global.Init( this );
        //concat_pdf( "/sdcard/testImport.pdf", "/sdcard/test_images.pdf" );
        
		String file = "/sdcard/test.pdf";
		String file_cache = Global.tmp_path + "/temp.dat";

		m_doc = new Document();
		m_doc.Create( file );
		m_doc.SetCache( file_cache );//set temporary cache for editing.
		NewPage(0, (210 * 72)/25.4f, (297 * 72)/25.4f);
		//NewImagePage(1, 323, 239, "/sdcard/0001.jpg");
		//NewImagePage(2, 323, 239, "/sdcard/0002.jpg");
		

		//to new outline item for first page
		float top = m_doc.GetPageHeight(0);
		boolean ret = m_doc.NewRootOutline("Root", 0, top);
		if(ret)
		{
			Outline ol = m_doc.GetOutlines();
			ol.AddChild("Child1", 0, top * 5 / 6);
			Outline ol1 = ol.GetChild();
			ol1.AddNext("Child2", 0, top / 2);
		}

		m_doc.Save();
		m_doc.Close();
		m_doc = null;

		m_view = new PDFSimple(this);
		m_view.Open(file);
		setContentView( m_view );
	}
	@Override
    protected void onDestroy()
	{
    	if( m_view != null )
    		m_view.Close();
    	Global.RemoveTmp();
		super.onDestroy();
	}
}

package com.radaee.pdf;

import android.graphics.Bitmap;

/**
class for PDF Document.
@author Radaee
@version 1.1
*/
public class Document
{
	public interface PDFFontDelegate
	{
		/**
		 * font delegate, invoked when the Font not found in FontList.
		 * @param collection like: "", "GB1", "CNS1", and so on.
		 * @param fname font name that not found in native library.
		 * @param flag flag&1 means fixed width font, flag&2 means vertical writing.
		 * @param ret_flags 1 element int array for output values:<br/>
		 * (ret_flag[0]>>8) is the index of face in Font File(TTC file may has many faces, TTF file just pass 0).<br/>
		 * (ret_flag[0]&1) tell native library to apply bold effect by program.<br/>
		 * (ret_flag[0]&2) tell native library to apply italic effect by program.<br/>
		 * @return full path name to font file, or null if using native default font.
		 */
		public String GetExtFont(String collection, String fname, int flag, int[] ret_flags);
	}
	public interface PDFStream
	{
		/**
		 * check whether the stream is writable 
		 * @return true or false
		 */
		public boolean writeable();
		/**
		 * get stream length.
		 * @return
		 */
		public int get_size();
		/**
		 * read data from stream
		 * @param data output values.
		 * @return bytes read
		 */
		public int read( byte[] data );
		/**
		 * write data to stream
		 * @param data data to write
		 * @return bytes written
		 */
		public int write( byte[] data );
		/**
		 * seek to position
		 * @param pos position from begin of the stream
		 */
		public void seek( int pos );
		/**
		 * tell current position
		 * @return position from begin of the stream
		 */
		public int tell();
	}
	public class ImportContext
	{
		protected ImportContext(Document doc, long value)
		{
			hand = value;
			m_doc = doc;
		}
		/**
		 * Destroy context object and free memory used.
		 */
		public void Destroy()
		{
			Document.importEnd( m_doc.hand_val, hand );
			hand = 0;
		}
		protected long hand;
		protected Document m_doc;
	}
	public class Outline
	{
		protected long hand;
		protected Document doc;
		/**
		 * get label of Outline
		 * @return title string
		 */
		public String GetTitle()
		{
			return Document.getOutlineTitle(doc.hand_val, hand);
		}
		/**
		 * set label of Outline.<br/>
		 * a premium license is needed for this method.
		 * @param title title to set
		 * @return true or false.
		 */
		public boolean SetTitle(String title)
		{
			return Document.setOutlineTitle(doc.hand_val, hand, title);
		}
		/**
		 * get next
		 * @return
		 */
		public Outline GetNext()
		{
			long ret =  Document.getOutlineNext(doc.hand_val, hand);
			if( ret == 0 ) return null;
			Outline ol = new Outline();
			ol.hand = ret;
			ol.doc = doc;
			return ol;
		}
		/**
		 * get first child
		 * @return
		 */
		public Outline GetChild()
		{
			long ret =  Document.getOutlineChild(doc.hand_val, hand);
			if( ret == 0 ) return null;
			Outline ol = new Outline();
			ol.hand = ret;
			ol.doc = doc;
			return ol;
		}
		/**
		 * get jumping page NO.
		 * @return 0 based page NO.
		 */
		public int GetDest()
		{
			return Document.getOutlineDest(doc.hand_val, hand);
		}
		/**
		 * get url string of Outline
		 * @return url string or null.
		 */
		public String GetURI()
		{
			return Document.getOutlineURI(doc.hand_val, hand);
		}
		/**
		 * get file link path of Outline
		 * @return file link path string or null.
		 */
		public String GetFileLink()
		{
			return Document.getOutlineFileLink(doc.hand_val, hand);
		}
		/**
		 * insert outline after of this Outline.<br/>
		 * a premium license is needed for this method.
		 * @param label label of new outline.
		 * @param pageno 0 based page NO.
		 * @param top y in PDF coordinate.
		 * @return true of false.
		 */
		public boolean AddNext( String label, int pageno, float top )
		{
			return Document.addOutlineNext(doc.hand_val, hand, label, pageno, top);
		}
		/**
		 * insert outline as first child of this Outline.<br/>
		 * a premium license is needed for this method.
		 * @param label label of new outline.
		 * @param pageno 0 based page NO.
		 * @param top y in PDF coordinate.
		 * @return true or false.
		 */
		public boolean AddChild( String label, int pageno, float top )
		{
			return Document.addOutlineChild(doc.hand_val, hand, label, pageno, top);
		}
		/**
		 * remove this Outline, and all children of this Outline.<br/>
		 * this method connect previous Outline and next Outline.<br/>
		 * a premium license is needed for this method.
		 * @return true or false.
		 */
		public boolean RemoveFromDoc()
		{
			boolean ret = Document.removeOutline(doc.hand_val, hand);
			hand = 0;
			return ret;
		}
	}
	protected long hand_val = 0;
	private int page_count = 0;
	private static native long create( String path );
	private static native long createForStream( PDFStream stream );
	private static native long open( String path, String password );
	private static native long openMem( byte[] data, String password );
	private static native long openStream( PDFStream stream, String password );
	private static native boolean setCache( long hand, String path );
	private static native void setFontDel( long hand, PDFFontDelegate del );
	private static native int getPermission( long hand );
	private static native int getPerm( long hand );
	private static native String exportForm( long hand );
	private static native void close( long hand );
	private static native long getPage( long hand, int pageno );
	private static native int getPageCount( long hand );
	private static native float getPageWidth( long hand, int pageno );
	private static native float getPageHeight( long hand, int pageno );
	private static native boolean changePageRect( long hand, int pageno, float dl, float dt, float dr, float db );
	private static native boolean setPageRotate( long hand, int pageno, int degree );
	private static native String getOutlineTitle( long hand, long outline );
	private static native boolean setOutlineTitle( long hand, long outline, String title );
	private static native int getOutlineDest( long hand, long outline );
	private static native String getOutlineURI( long hand, long outline );
	private static native String getOutlineFileLink( long hand, long outline );
	private static native long getOutlineNext( long hand, long outline );
	private static native long getOutlineChild( long hand, long outline );
	private static native boolean addOutlineNext( long hand, long outline, String label, int pageno, float top );
	private static native boolean addOutlineChild( long hand, long outline, String label, int pageno, float top );
	private static native boolean removeOutline( long hand, long outline );
	private static native String getMeta( long hand, String tag );
	private static native byte[] getID( long hand, int index);
	private static native boolean setMeta( long hand, String tag, String value );
	private static native boolean canSave( long hand );
	private static native boolean save( long hand );
	private static native boolean saveAs( long hand, String dst, boolean rem_sec );//remove security info and save to another file.
	private static native boolean encryptAs( long hand, String dst, String upswd, String opswd, int perm, int method, byte[] id);
	private static native boolean isEncrypted( long hand );

	private static native long importStart( long hand, long hand_src );
	private static native boolean importPage( long hand, long ctx, int srcno, int dstno );
	private static native void importEnd( long hand, long ctx );
	private static native long newPage( long hand, int pageno, float w, float h );
	private static native boolean removePage( long hand, int pageno );
	private static native boolean movePage( long hand, int pageno1, int pageno2 );
	private static native long newFontCID( long hand, String name, int style );
	private static native float getFontAscent( long hand, long font );
	private static native float getFontDescent( long hand, long font );
	private static native long newGState(long hand);
	private static native boolean setGStateStrokeAlpha(long hand, long gstate, int alpha);
	private static native boolean setGStateFillAlpha(long hand, long gstate, int alpha);
	private static native long newImage( long hand, Bitmap bmp, boolean has_alpha );
	private static native long newImageJPEG( long hand, String path );
	private static native long newImageJPX( long hand, String path );
	private static native byte[] getSignContents( long hand );
	private static native String getSignFilter( long hand );
	private static native String getSignSubFilter( long hand );
	private static native int[] getSignByteRange( long hand );
	private static native int checkSignByteRange( long hand );
	public class DocFont
	{
		protected long hand;
		Document doc;
		/**
		 * get ascent
		 * @return ascent based in 1, for example: 0.88f
		 */
		public float GetAscent()
		{
			return getFontAscent(doc.hand_val, hand);
		}
		/**
		 * get descent
		 * @return ascent based in 1, for example: -0.12f
		 */
		public float GetDescent()
		{
			return getFontDescent(doc.hand_val, hand);
		}
	}
	public class DocGState
	{
		protected long hand;
		Document doc;
		/**
		 * set alpha value for fill and other non-stroke operation
		 * @param alpha range: [0, 255]
		 * @return true or false
		 */
		public boolean SetFillAlpha(int alpha)
		{
			return Document.setGStateFillAlpha(doc.hand_val, hand, alpha);
		}
		/**
		 * set alpha value for stroke operation
		 * @param alpha range: [0, 255]
		 * @return true or false
		 */
		public boolean SetStrokeAlpha(int alpha)
		{
			return Document.setGStateStrokeAlpha(doc.hand_val, hand, alpha);
		}
	}
	public class DocImage
	{
		protected long hand;
	}
	public Document()
	{
	}
	/**
	 * inner function.
	 * @param vals
	 */
	public Document(int vals[] )
	{
		if( vals != null )
		{
			hand_val = vals[0];
			page_count = vals[1];
		}
	}
	private long getOutlineRoot()
	{
		return getOutlineNext( hand_val, 0 );
	}
	/**
	 * check if opened.
	 * @return true or false.
	 */
	public boolean IsOpened()
	{
		return (hand_val != 0);
	}
	/**
	 * create a empty PDF document
	 * @param path path to create
	 * @return 0 or less than 0 means failed, same as Open.
	 */
	public int Create( String path )
	{
		if( hand_val == 0 )
		{
			int ret = 0;
			hand_val = create( path );
			if( hand_val <= 0 && hand_val >= -10 )//error
			{
				ret = (int)hand_val;
				hand_val = 0;
				page_count = 0;
			}
			else
				page_count = getPageCount(hand_val);
			return ret;
		}
		return 0;
	}
	/**
	 * create a empty PDF document
	 * @param stream stream to create
	 * @return 0 or less than 0 means failed, same as Open.
	 */
	public int CreateForStream( PDFStream stream )
	{
		if( hand_val == 0 )
		{
			int ret = 0;
			hand_val = createForStream( stream );
			if( hand_val <= 0 && hand_val >= -10 )//error
			{
				ret = (int)hand_val;
				hand_val = 0;
				page_count = 0;
			}
			else
				page_count = getPageCount(hand_val);
			return ret;
		}
		return 0;
	}
	/**
	 * set cache file to PDF.<br/>
	 * a premium license is needed for this method.
	 * @param path a path to save some temporary data, compressed images and so on
	 * @return true or false
	 */
	public boolean SetCache( String path )
	{
		return setCache( hand_val, path );
	}
	/**
	 * set font delegate to PDF.<br/>
	 * a professional or premium license is needed for this method.
	 * @param del delegate for font mapping, or null to remove delegate.
	 */
	public void SetFontDel( PDFFontDelegate del )
	{
		setFontDel(hand_val, del);
	}
	
	/**
	 * open document.<br/>
	 * first time, SDK try password as user password, and then try password as owner password.
	 * @param path PDF file to be open.
	 * @param password password or null.
	 * @return error code:<br/>
	 * 0:succeeded, and continue<br/>
	 * -1:need input password<br/>
	 * -2:unknown encryption<br/>
	 * -3:damaged or invalid format<br/>
	 * -10:access denied or invalid file path<br/>
	 * others:unknown error
	 */
	public int Open( String path, String password )
	{
		if( hand_val == 0 )
		{
			int ret = 0;
			hand_val = open( path, password );
			if( hand_val <= 0 && hand_val >= -10 )//error
			{
				ret = (int)hand_val;
				hand_val = 0;
				page_count = 0;
			}
			else
				page_count = getPageCount(hand_val);
			return ret;
		}
		return 0;
	}
	/**
	 * open document in memory.
	 * first time, SDK try password as user password, and then try password as owner password.
	 * @param data data for whole PDF file in byte array. developers should retain array data, till document closed.
	 * @param password password or null.
	 * @return error code:<br/>
	 * 0:succeeded, and continue<br/>
	 * -1:need input password<br/>
	 * -2:unknown encryption<br/>
	 * -3:damaged or invalid format<br/>
	 * -10:access denied or invalid file path<br/>
	 * others:unknown error
	 */
	public int OpenMem( byte[] data, String password )
	{
		if( hand_val == 0 )
		{
			int ret = 0;
			hand_val = openMem( data, password );
			if( hand_val <= 0 && hand_val >= -10 )//error
			{
				ret = (int)hand_val;
				hand_val = 0;
				page_count = 0;
			}
			else
				page_count = getPageCount(hand_val);
			return ret;
		}
		return 0;
	}
	/**
	 * open document from stream.
	 * first time, SDK try password as user password, and then try password as owner password.
	 * @param stream PDFStream object.
	 * @param password password or null.
	 * @return error code:<br/>
	 * 0:succeeded, and continue<br/>
	 * -1:need input password<br/>
	 * -2:unknown encryption<br/>
	 * -3:damaged or invalid format<br/>
	 * -10:access denied or invalid file path<br/>
	 * others:unknown error
	 */
	public int OpenStream( PDFStream stream, String password )
	{
		if( hand_val == 0 )
		{
			int ret = 0;
			hand_val = openStream( stream, password );
			if( hand_val <= 0 && hand_val >= -10 )//error
			{
				ret = (int)hand_val;
				hand_val = 0;
				page_count = 0;
			}
			else
				page_count = getPageCount(hand_val);
			return ret;
		}
		return 0;
	}
	/**
	 * get permission of PDF, this value defined in PDF reference 1.7<br/>
	 * mostly, it means the permission from encryption.<br/>
	 * this method need a professional or premium license.
	 * bit 1-2 reserved<br/>
	 * bit 3(0x4) print<br/>
	 * bit 4(0x8) modify<br/>
	 * bit 5(0x10) extract text or image<br/>
	 * others: see PDF reference
	 * @return permission flags
	 */
	public int GetPermission()
	{
		return getPermission( hand_val );
	}
	/**
	 * get permission of PDF, this value defined in "Perm" entry in Catalog object.<br/>
	 * mostly, it means the permission from signature.<br/>
	 * this method need a professional or premium license.
	 * @return 0 means not defined<br/>
	 * 1 means can't modify<br/>
	 * 2 means can modify some form fields<br/>
	 * 3 means can do any modify<br/>
	 */
	public int GetPerm()
	{
		return getPerm( hand_val );
	}
	/**
	 * export form data as xml string.<br/>
	 * this method need premium license.
	 * @return xml string or null.
	 */
	public String ExportForm()
	{
		return exportForm( hand_val );
	}
	/**
	 * close the document.
	 */
	public void Close()
	{
		if( hand_val != 0 )
			close( hand_val );
		hand_val = 0;
		page_count = 0;
	}
	/**
	 * get a Page object for page NO.
	 * @param pageno 0 based page NO. range:[0, GetPageCount()-1]
	 * @return Page object
	 */
	public Page GetPage( int pageno )
	{
		if( hand_val == 0 ) return null;
		long hand = getPage( hand_val, pageno );
		if( hand == 0 ) return null;
		Page page = new Page();
		if( page != null ) page.hand = hand;
		return page;
	}
	/**
	 * get pages count.
	 * @return pages count.
	 */
	public int GetPageCount()
	{
		//it loads all pages. sometimes the function is very slow.
		return page_count;
	}
	/**
	 * get page width by page NO.
	 * @param pageno 0 based page NO. range:[0, GetPageCount()-1]
	 * @return width value.
	 */
	public float GetPageWidth( int pageno )
	{
		float w = getPageWidth( hand_val, pageno );
		if( w <= 0 ) return 1;
		else return w;
	}
	/**
	 * get page height by page NO.
	 * @param pageno 0 based page NO. range:[0, GetPageCount()-1]
	 * @return height value.
	 */
	public float GetPageHeight( int pageno )
	{
		float h = getPageHeight( hand_val, pageno );
		if( h <= 0 ) return 1;
		else return h;
	}
	/**
	 * get meta data of document.
	 * @param tag Predefined values:"Title", "Author", "Subject", "Keywords", "Creator", "Producer", "CreationDate", "ModDate".<br/>or you can pass any key that self-defined.
	 * @return Meta string value, or null.
	 */
	public String GetMeta( String tag )
	{
		return getMeta( hand_val, tag );
	}
	/**
	 * get id of document.
	 * @param index must 0 or 1, 0 means first 16 bytes, 1 means last 16 bytes.
	 * @return bytes or null if no id for this document.
	 */
	public byte[] GetID(int index)
	{
		return getID( hand_val, index);
	}
	/**
	 * set meta data for document.<br/>
	 * this method valid only in premium version.
	 * @param tag Predefined values:"Title", "Author", "Subject", "Keywords", "Creator", "Producer", "CreationDate", "ModDate".<br/>or you can pass any key that self-defined.
	 * @param val string value.
	 * @return true or false.
	 */
	public boolean SetMeta( String tag, String val )
	{
		return setMeta( hand_val, tag, val );
	}
	/**
	 * get first root outline item.
	 * @return handle value of first root outline item. or null if no outlines.<br/>
	 */
	public Outline GetOutlines()
	{
		long ret = getOutlineRoot();
		if( ret == 0 ) return null;
		Outline ol = new Outline();
		ol.doc = this;
		ol.hand = ret;
		return ol;
	}
	/**
	 * check if document can be modified or saved.<br/>
	 * this always return false, if no license actived.
	 * @return true or false.
	 */
	public boolean CanSave()
	{
		return canSave( hand_val );
	}
	/**
	 * save the document.<br/>
	 * this always return false, if no license actived.
	 * @return true or false
	 */
	public boolean Save()
	{
		return save( hand_val );
	}
	/**
	 * save as the document to another file.<br/>
	 * this method need professional or premium license.
	 * @param path path to save.
	 * @param rem_sec remove security info?
	 * @return true or false.
	 */
	public boolean SaveAs( String path, boolean rem_sec )
	{
		return saveAs( hand_val, path, rem_sec );
	}
	/**
	 * encrypt document and save as the document to another file.<br/>
	 * this method need premium license.
	 * @param dst path to save， same as path parameter of SaveAs.
	 * @param upswd user password, can be null.
	 * @param opswd owner password, can be null.
	 * @param perm permission to set, same as GetPermission() method.<br/>
	 * bit 1-2 reserved<br/>
	 * bit 3(0x4) print<br/>
	 * bit 4(0x8) modify<br/>
	 * bit 5(0x10) extract text or image<br/>
	 * others: see PDF reference
	 * @param method reserved, currently only AES with V=4 and R=4 mode can be working.
	 * @param id must be 32 bytes for file ID. it is divided to 2 array in native library, as each 16 bytes.
	 * @return true or false. 
	 */
	public boolean EncryptAs( String dst, String upswd, String opswd, int perm, int method, byte[] id)
	{
		return encryptAs( hand_val, dst, upswd, opswd, perm, method, id);
	}
	/**
	 * check if document is encrypted.
	 * @return true or false.
	 */
	public boolean IsEncrypted()
	{
		return isEncrypted( hand_val );
	}
	/**
	 * new a root outline to document, it insert first root outline to Document.<br/>
	 * the old first root outline, shall be next of this outline. 
	 * @param label label to display
	 * @param pageno pageno to jump
	 * @param top y position in PDF coordinate
	 * @return true or false
	 */
	public boolean NewRootOutline( String label, int pageno, float top )
	{
		return addOutlineChild(hand_val, 0, label, pageno, top);
	}
	/**
	 * Start import operations, import page from src<br/>
	 * a premium license is needed for this method.<br/>
	 * you shall maintenance the source Document object until all pages are imported and ImportContext.Destroy() invoked. 
	 * @param src source Document object that opened.
	 * @return a context object used in ImportPage. 
	 */
	public ImportContext ImportStart( Document src )
	{
		if( src == null ) return null;
		long hand = importStart( hand_val, src.hand_val );
		if( hand != 0 ) return new ImportContext(this, hand);
		else return null;
	}
	/**
	 * import a page to the document.<br/>
	 * a premium license is needed for this method.<br/>
	 * do not forget to invoke ImportContext.Destroy() after all pages are imported.
	 * @param ctx context object created from ImportStart
	 * @param srcno 0 based page NO. from source Document that passed to ImportStart.
	 * @param dstno 0 based page NO. to insert in this document object.
	 * @return true or false.
	 */
	public boolean ImportPage( ImportContext ctx, int srcno, int dstno )
	{
		if( ctx == null ) return false;
		return importPage( hand_val, ctx.hand, srcno, dstno );
	}
	/**
	 * insert a page to Document<br/>
	 * if pagheno >= page_count, it do same as append.<br/>
	 * otherwise, insert to pageno.<br/>
	 * a premium license is needed for this method.
	 * @param pageno 0 based page NO.
	 * @param w page width in PDF coordinate
	 * @param h page height in PDF coordinate
	 * @return Page object or null means failed.
	 */
	public Page NewPage( int pageno, float w, float h )
	{
		long ret = newPage( hand_val, pageno, w, h );
		if( ret != 0 )
		{
			Page page = new Page();
			page.hand = ret;
			return page;
		}
		else return null;
	}
	/**
	 * remove page by page NO.<br/>
	 * a premium license is needed for this method.
	 * @param pageno 0 based page NO.
	 * @return true or false
	 */
	public boolean RemovePage( int pageno )
	{
		return removePage(hand_val, pageno);
	}
	/**
	 * move the page to other position.<br/>
	 * a premium license is needed for this method.
	 * @param pageno1 page NO, move from
	 * @param pageno2 page NO, move to
	 * @return true or false
	 */
	public boolean MovePage( int pageno1, int pageno2 )
	{
		return movePage(hand_val, pageno1, pageno2 );
	}
	/**
	 * create a font object, used to write texts.<br/>
	 * a premium license is needed for this method.
	 * @param font_name <br/>
	 * font name exists in font list.<br/>
	 * using Global.getFaceCount(), Global.getFaceName() to enumerate fonts.
	 * @param style <br/>
	 *   (style&1) means bold,<br/>
	 *   (style&2) means Italic,<br/>
	 *   (style&8) means embed,<br/>
	 *   (style&16) means vertical writing, mostly used in Asia fonts.
	 * @return DocFont object or null is failed.
	 */
	public DocFont NewFontCID( String font_name, int style )
	{
		long ret = newFontCID(hand_val, font_name, style);
		if( ret != 0 )
		{
			DocFont font = new DocFont();
			font.hand = ret;
			font.doc = this;
			return font;
		}
		else return null;
	}
	/**
	 * create a ExtGraphicState object, used to set alpha values.<br/>
	 * a premium license is needed for this method.
	 * @return DocGState object or null.
	 */
	public DocGState NewGState()
	{
		long ret = newGState(hand_val);
		if( ret != 0 )
		{
			DocGState gs = new DocGState();
			gs.hand = ret;
			gs.doc = this;
			return gs;
		}
		else return null;
	}
	/**
	 * create an image from Bitmap object.<br/>
	 * a premium license is needed for this method.
	 * @param bmp Bitmap object in ARGB_8888 format.
	 * @param has_alpha generate alpha channel information?
	 * @return DocImage object or null.
	 */
	public DocImage NewImage( Bitmap bmp, boolean has_alpha )
	{
		long ret = newImage(hand_val, bmp, has_alpha);
		if( ret != 0 )
		{
			DocImage img = new DocImage();
			img.hand = ret;
			return img;
		}
		else return null;
	}
	/**
	 * create an image from JPEG/JPG file.<br/>
	 * supported image color space:<br/>
	 * --GRAY<br/>
	 * --RGB<br/>
	 * --CMYK<br/>
	 * a premium license is needed for this method.
	 * @param path path to JPEG file.
	 * @return DocImage object or null.
	 */
	public DocImage NewImageJPEG( String path )
	{
		long ret = newImageJPEG(hand_val, path);
		if( ret != 0 )
		{
			DocImage img = new DocImage();
			img.hand = ret;
			return img;
		}
		else return null;
	}
	/**
	 * create an image from JPX/JPEG 2k file.<br/>
	 * a premium license is needed for this method.
	 * @param path path to JPX file.
	 * @return DocImage object or null.
	 */
	public DocImage NewImageJPX( String path )
	{
		long ret = newImageJPX(hand_val, path);
		if( ret != 0 )
		{
			DocImage img = new DocImage();
			img.hand = ret;
			return img;
		}
		else return null;
	}
	/**
	 * change page rect.<br/>
	 * a premium license is needed for this method.
	 * @param pageno 0 based page NO.
	 * @param dl delta to left, page_left += dl;
	 * @param dt delta to top, page_top += dt;
	 * @param dr delta to right, page_right += dr;
	 * @param db delta to bottom, page_bottom += db;
	 * @return true or false.
	 */
	public boolean ChangePageRect( int pageno, float dl, float dt, float dr, float db )
	{
		return changePageRect( hand_val, pageno, dl, dt, dr, db );
	}
	/**
	 * set page rotate.<br/>
	 * a premium license is needed for this method.
	 * @param pageno 0 based page NO.
	 * @param degree rotate angle in degree, must be 90 * n.
	 * @return true or false
	 */
	public boolean SetPageRotate( int pageno, int degree )
	{
		return setPageRotate( hand_val, pageno, degree );
	}

	/**
	 * get signature contents. mostly an encrypted digest.<br/>
	 * this method valid in professional or premium version.<br/>
	 * @return byte array which format depends on Filter and SubFilter.<br/>
	 * or null, if not signed for document.
	 */
	public byte[] GetSignContents()
	{
		return getSignContents( hand_val );
	}
	/**
	 * get signature filter name.<br/>
	 * this method valid in professional or premium version.<br/>
	 * @return The name of the preferred signature handler to use.<br/>
	 * Example signature handlers are "Adobe.PPKLite", "Entrust.PPKEF", "CICI.SignIt", and "VeriSign.PPKVS".<br/>
	 * others maybe user defined.
	 */
	public String GetSignFilter()
	{
		return getSignFilter( hand_val );
	}
	/**
	 * get sub filter name of signature.<br/>
	 * this method valid in professional or premium version.<br/>
	 * @return name that describes the encoding of the signature value and key information in the signature dictionary.<br/>
	 * like "adbe.x509.rsa_sha1", "adbe.pkcs7.detached", and "adbe.pkcs7.sha1"<br/>
	 * others maybe user defined.
	 */
	public String GetSignSubFilter()
	{
		return getSignSubFilter( hand_val );
	}
	/**
	 * get byte ranges from PDF file, to get digest.<br/>
	 * this method valid in professional or premium version.<br/>
	 * @return an integer pair array, to record byte ranges.<br/>
	 * each pair describing a range to digest.<br/>
	 * 1st element of pair is offset.<br/>
	 * 2nd element of pair is length.
	 */
	public int[] GetSignByteRange()
	{
		return getSignByteRange( hand_val );
	}
	/**
	 * check object defined in signature("Data" entry), is in byte ranges defined in signature.
	 * this method valid in professional or premium version.<br/>
	 * to ensure PDF file modified, mostly you shall(Adobe Standard):<br/>
	 * 1. invoke this method first.<br/>
	 * 2. if succeeded, then get signature contents(see GetSignContents).<br/>
	 * 3. decode public key from contents(see GetSignContents).<br/>
	 * 4. decode encrypted digest from contents.<br/>
	 * 5. decrypt digest.1 using public key, for step 4.<br/>
	 * 6. calculate digest.2 by yourself, using byte ranges(GetSignByteRange).<br/>
	 * 7. check digest.1 == digest.2
	 * @return <br/>
	 * -1: unknown or not defined in signature.<br/>
	 *  0: check failed, means modified.<br/>
	 *  1: check succeeded, means no new objects after signature.
	 */
	public int CheckSignByteRange()
	{
		return checkSignByteRange( hand_val );
	}
}

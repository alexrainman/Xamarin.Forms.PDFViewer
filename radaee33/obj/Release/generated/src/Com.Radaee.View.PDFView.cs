using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Radaee.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']"
	[global::Android.Runtime.Register ("com/radaee/view/PDFView", DoNotGenerateAcw=true)]
	public partial class PDFView : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='STA_CURLING']"
		[Register ("STA_CURLING")]
		protected const int StaCurling = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='STA_MOVING']"
		[Register ("STA_MOVING")]
		protected const int StaMoving = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='STA_NONE']"
		[Register ("STA_NONE")]
		protected const int StaNone = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='STA_SELECT']"
		[Register ("STA_SELECT")]
		protected const int StaSelect = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='STA_ZOOM']"
		[Register ("STA_ZOOM")]
		protected const int StaZoom = (int) 2;

		static IntPtr m_back_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_back']"
		[Register ("m_back")]
		protected int MBack {
			get {
				if (m_back_jfieldId == IntPtr.Zero)
					m_back_jfieldId = JNIEnv.GetFieldID (class_ref, "m_back", "I");
				return JNIEnv.GetIntField (Handle, m_back_jfieldId);
			}
			set {
				if (m_back_jfieldId == IntPtr.Zero)
					m_back_jfieldId = JNIEnv.GetFieldID (class_ref, "m_back", "I");
				JNIEnv.SetField (Handle, m_back_jfieldId, value);
			}
		}

		static IntPtr m_bmp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_bmp']"
		[Register ("m_bmp")]
		protected global::Android.Graphics.Bitmap MBmp {
			get {
				if (m_bmp_jfieldId == IntPtr.Zero)
					m_bmp_jfieldId = JNIEnv.GetFieldID (class_ref, "m_bmp", "Landroid/graphics/Bitmap;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, m_bmp_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_bmp_jfieldId == IntPtr.Zero)
					m_bmp_jfieldId = JNIEnv.GetFieldID (class_ref, "m_bmp", "Landroid/graphics/Bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, m_bmp_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr m_doc_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_doc']"
		[Register ("m_doc")]
		protected global::Com.Radaee.Pdf.Document MDoc {
			get {
				if (m_doc_jfieldId == IntPtr.Zero)
					m_doc_jfieldId = JNIEnv.GetFieldID (class_ref, "m_doc", "Lcom/radaee/pdf/Document;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, m_doc_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_doc_jfieldId == IntPtr.Zero)
					m_doc_jfieldId = JNIEnv.GetFieldID (class_ref, "m_doc", "Lcom/radaee/pdf/Document;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, m_doc_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr m_doch_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_doch']"
		[Register ("m_doch")]
		protected int MDoch {
			get {
				if (m_doch_jfieldId == IntPtr.Zero)
					m_doch_jfieldId = JNIEnv.GetFieldID (class_ref, "m_doch", "I");
				return JNIEnv.GetIntField (Handle, m_doch_jfieldId);
			}
			set {
				if (m_doch_jfieldId == IntPtr.Zero)
					m_doch_jfieldId = JNIEnv.GetFieldID (class_ref, "m_doch", "I");
				JNIEnv.SetField (Handle, m_doch_jfieldId, value);
			}
		}

		static IntPtr m_docw_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_docw']"
		[Register ("m_docw")]
		protected int MDocw {
			get {
				if (m_docw_jfieldId == IntPtr.Zero)
					m_docw_jfieldId = JNIEnv.GetFieldID (class_ref, "m_docw", "I");
				return JNIEnv.GetIntField (Handle, m_docw_jfieldId);
			}
			set {
				if (m_docw_jfieldId == IntPtr.Zero)
					m_docw_jfieldId = JNIEnv.GetFieldID (class_ref, "m_docw", "I");
				JNIEnv.SetField (Handle, m_docw_jfieldId, value);
			}
		}

		static IntPtr m_draw_bmp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_draw_bmp']"
		[Register ("m_draw_bmp")]
		protected global::Com.Radaee.Pdf.BMP MDrawBmp {
			get {
				if (m_draw_bmp_jfieldId == IntPtr.Zero)
					m_draw_bmp_jfieldId = JNIEnv.GetFieldID (class_ref, "m_draw_bmp", "Lcom/radaee/pdf/BMP;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, m_draw_bmp_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.BMP> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_draw_bmp_jfieldId == IntPtr.Zero)
					m_draw_bmp_jfieldId = JNIEnv.GetFieldID (class_ref, "m_draw_bmp", "Lcom/radaee/pdf/BMP;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, m_draw_bmp_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr m_drawbmp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_drawbmp']"
		[Register ("m_drawbmp")]
		protected bool MDrawbmp {
			get {
				if (m_drawbmp_jfieldId == IntPtr.Zero)
					m_drawbmp_jfieldId = JNIEnv.GetFieldID (class_ref, "m_drawbmp", "Z");
				return JNIEnv.GetBooleanField (Handle, m_drawbmp_jfieldId);
			}
			set {
				if (m_drawbmp_jfieldId == IntPtr.Zero)
					m_drawbmp_jfieldId = JNIEnv.GetFieldID (class_ref, "m_drawbmp", "Z");
				JNIEnv.SetField (Handle, m_drawbmp_jfieldId, value);
			}
		}

		static IntPtr m_finder_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_finder']"
		[Register ("m_finder")]
		protected global::Com.Radaee.View.PDFVFinder MFinder {
			get {
				if (m_finder_jfieldId == IntPtr.Zero)
					m_finder_jfieldId = JNIEnv.GetFieldID (class_ref, "m_finder", "Lcom/radaee/view/PDFVFinder;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, m_finder_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVFinder> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_finder_jfieldId == IntPtr.Zero)
					m_finder_jfieldId = JNIEnv.GetFieldID (class_ref, "m_finder", "Lcom/radaee/view/PDFVFinder;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, m_finder_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr m_h_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_h']"
		[Register ("m_h")]
		protected int MH {
			get {
				if (m_h_jfieldId == IntPtr.Zero)
					m_h_jfieldId = JNIEnv.GetFieldID (class_ref, "m_h", "I");
				return JNIEnv.GetIntField (Handle, m_h_jfieldId);
			}
			set {
				if (m_h_jfieldId == IntPtr.Zero)
					m_h_jfieldId = JNIEnv.GetFieldID (class_ref, "m_h", "I");
				JNIEnv.SetField (Handle, m_h_jfieldId, value);
			}
		}

		static IntPtr m_hand_ui_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_hand_ui']"
		[Register ("m_hand_ui")]
		protected global::Android.OS.Handler MHandUi {
			get {
				if (m_hand_ui_jfieldId == IntPtr.Zero)
					m_hand_ui_jfieldId = JNIEnv.GetFieldID (class_ref, "m_hand_ui", "Landroid/os/Handler;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, m_hand_ui_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_hand_ui_jfieldId == IntPtr.Zero)
					m_hand_ui_jfieldId = JNIEnv.GetFieldID (class_ref, "m_hand_ui", "Landroid/os/Handler;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, m_hand_ui_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr m_holdsx_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_holdsx']"
		[Register ("m_holdsx")]
		protected float MHoldsx {
			get {
				if (m_holdsx_jfieldId == IntPtr.Zero)
					m_holdsx_jfieldId = JNIEnv.GetFieldID (class_ref, "m_holdsx", "F");
				return JNIEnv.GetFloatField (Handle, m_holdsx_jfieldId);
			}
			set {
				if (m_holdsx_jfieldId == IntPtr.Zero)
					m_holdsx_jfieldId = JNIEnv.GetFieldID (class_ref, "m_holdsx", "F");
				JNIEnv.SetField (Handle, m_holdsx_jfieldId, value);
			}
		}

		static IntPtr m_holdsy_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_holdsy']"
		[Register ("m_holdsy")]
		protected float MHoldsy {
			get {
				if (m_holdsy_jfieldId == IntPtr.Zero)
					m_holdsy_jfieldId = JNIEnv.GetFieldID (class_ref, "m_holdsy", "F");
				return JNIEnv.GetFloatField (Handle, m_holdsy_jfieldId);
			}
			set {
				if (m_holdsy_jfieldId == IntPtr.Zero)
					m_holdsy_jfieldId = JNIEnv.GetFieldID (class_ref, "m_holdsy", "F");
				JNIEnv.SetField (Handle, m_holdsy_jfieldId, value);
			}
		}

		static IntPtr m_holdx_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_holdx']"
		[Register ("m_holdx")]
		protected float MHoldx {
			get {
				if (m_holdx_jfieldId == IntPtr.Zero)
					m_holdx_jfieldId = JNIEnv.GetFieldID (class_ref, "m_holdx", "F");
				return JNIEnv.GetFloatField (Handle, m_holdx_jfieldId);
			}
			set {
				if (m_holdx_jfieldId == IntPtr.Zero)
					m_holdx_jfieldId = JNIEnv.GetFieldID (class_ref, "m_holdx", "F");
				JNIEnv.SetField (Handle, m_holdx_jfieldId, value);
			}
		}

		static IntPtr m_holdy_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_holdy']"
		[Register ("m_holdy")]
		protected float MHoldy {
			get {
				if (m_holdy_jfieldId == IntPtr.Zero)
					m_holdy_jfieldId = JNIEnv.GetFieldID (class_ref, "m_holdy", "F");
				return JNIEnv.GetFloatField (Handle, m_holdy_jfieldId);
			}
			set {
				if (m_holdy_jfieldId == IntPtr.Zero)
					m_holdy_jfieldId = JNIEnv.GetFieldID (class_ref, "m_holdy", "F");
				JNIEnv.SetField (Handle, m_holdy_jfieldId, value);
			}
		}

		static IntPtr m_listener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_listener']"
		[Register ("m_listener")]
		protected global::Com.Radaee.View.PDFView.IPDFViewListener MListener {
			get {
				if (m_listener_jfieldId == IntPtr.Zero)
					m_listener_jfieldId = JNIEnv.GetFieldID (class_ref, "m_listener", "Lcom/radaee/view/PDFView$PDFViewListener;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, m_listener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView.IPDFViewListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_listener_jfieldId == IntPtr.Zero)
					m_listener_jfieldId = JNIEnv.GetFieldID (class_ref, "m_listener", "Lcom/radaee/view/PDFView$PDFViewListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, m_listener_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr m_page_gap_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_page_gap']"
		[Register ("m_page_gap")]
		protected int MPageGap {
			get {
				if (m_page_gap_jfieldId == IntPtr.Zero)
					m_page_gap_jfieldId = JNIEnv.GetFieldID (class_ref, "m_page_gap", "I");
				return JNIEnv.GetIntField (Handle, m_page_gap_jfieldId);
			}
			set {
				if (m_page_gap_jfieldId == IntPtr.Zero)
					m_page_gap_jfieldId = JNIEnv.GetFieldID (class_ref, "m_page_gap", "I");
				JNIEnv.SetField (Handle, m_page_gap_jfieldId, value);
			}
		}

		static IntPtr m_pageno_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_pageno']"
		[Register ("m_pageno")]
		protected int MPageno {
			get {
				if (m_pageno_jfieldId == IntPtr.Zero)
					m_pageno_jfieldId = JNIEnv.GetFieldID (class_ref, "m_pageno", "I");
				return JNIEnv.GetIntField (Handle, m_pageno_jfieldId);
			}
			set {
				if (m_pageno_jfieldId == IntPtr.Zero)
					m_pageno_jfieldId = JNIEnv.GetFieldID (class_ref, "m_pageno", "I");
				JNIEnv.SetField (Handle, m_pageno_jfieldId, value);
			}
		}

		static IntPtr m_pages_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_pages']"
		[Register ("m_pages")]
		protected IList<Com.Radaee.View.PDFVPage> MPages {
			get {
				if (m_pages_jfieldId == IntPtr.Zero)
					m_pages_jfieldId = JNIEnv.GetFieldID (class_ref, "m_pages", "[Lcom/radaee/view/PDFVPage;");
				return JavaArray<global::Com.Radaee.View.PDFVPage>.FromJniHandle (JNIEnv.GetObjectField (Handle, m_pages_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_pages_jfieldId == IntPtr.Zero)
					m_pages_jfieldId = JNIEnv.GetFieldID (class_ref, "m_pages", "[Lcom/radaee/view/PDFVPage;");
				IntPtr native_value = JavaArray<global::Com.Radaee.View.PDFVPage>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, m_pages_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr m_prange_end_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_prange_end']"
		[Register ("m_prange_end")]
		protected int MPrangeEnd {
			get {
				if (m_prange_end_jfieldId == IntPtr.Zero)
					m_prange_end_jfieldId = JNIEnv.GetFieldID (class_ref, "m_prange_end", "I");
				return JNIEnv.GetIntField (Handle, m_prange_end_jfieldId);
			}
			set {
				if (m_prange_end_jfieldId == IntPtr.Zero)
					m_prange_end_jfieldId = JNIEnv.GetFieldID (class_ref, "m_prange_end", "I");
				JNIEnv.SetField (Handle, m_prange_end_jfieldId, value);
			}
		}

		static IntPtr m_prange_start_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_prange_start']"
		[Register ("m_prange_start")]
		protected int MPrangeStart {
			get {
				if (m_prange_start_jfieldId == IntPtr.Zero)
					m_prange_start_jfieldId = JNIEnv.GetFieldID (class_ref, "m_prange_start", "I");
				return JNIEnv.GetIntField (Handle, m_prange_start_jfieldId);
			}
			set {
				if (m_prange_start_jfieldId == IntPtr.Zero)
					m_prange_start_jfieldId = JNIEnv.GetFieldID (class_ref, "m_prange_start", "I");
				JNIEnv.SetField (Handle, m_prange_start_jfieldId, value);
			}
		}

		static IntPtr m_scale_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_scale']"
		[Register ("m_scale")]
		protected float MScale {
			get {
				if (m_scale_jfieldId == IntPtr.Zero)
					m_scale_jfieldId = JNIEnv.GetFieldID (class_ref, "m_scale", "F");
				return JNIEnv.GetFloatField (Handle, m_scale_jfieldId);
			}
			set {
				if (m_scale_jfieldId == IntPtr.Zero)
					m_scale_jfieldId = JNIEnv.GetFieldID (class_ref, "m_scale", "F");
				JNIEnv.SetField (Handle, m_scale_jfieldId, value);
			}
		}

		static IntPtr m_scale_max_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_scale_max']"
		[Register ("m_scale_max")]
		protected float MScaleMax {
			get {
				if (m_scale_max_jfieldId == IntPtr.Zero)
					m_scale_max_jfieldId = JNIEnv.GetFieldID (class_ref, "m_scale_max", "F");
				return JNIEnv.GetFloatField (Handle, m_scale_max_jfieldId);
			}
			set {
				if (m_scale_max_jfieldId == IntPtr.Zero)
					m_scale_max_jfieldId = JNIEnv.GetFieldID (class_ref, "m_scale_max", "F");
				JNIEnv.SetField (Handle, m_scale_max_jfieldId, value);
			}
		}

		static IntPtr m_scale_min_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_scale_min']"
		[Register ("m_scale_min")]
		protected float MScaleMin {
			get {
				if (m_scale_min_jfieldId == IntPtr.Zero)
					m_scale_min_jfieldId = JNIEnv.GetFieldID (class_ref, "m_scale_min", "F");
				return JNIEnv.GetFloatField (Handle, m_scale_min_jfieldId);
			}
			set {
				if (m_scale_min_jfieldId == IntPtr.Zero)
					m_scale_min_jfieldId = JNIEnv.GetFieldID (class_ref, "m_scale_min", "F");
				JNIEnv.SetField (Handle, m_scale_min_jfieldId, value);
			}
		}

		static IntPtr m_scroller_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_scroller']"
		[Register ("m_scroller")]
		protected global::Android.Widget.Scroller MScroller {
			get {
				if (m_scroller_jfieldId == IntPtr.Zero)
					m_scroller_jfieldId = JNIEnv.GetFieldID (class_ref, "m_scroller", "Landroid/widget/Scroller;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, m_scroller_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.Scroller> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_scroller_jfieldId == IntPtr.Zero)
					m_scroller_jfieldId = JNIEnv.GetFieldID (class_ref, "m_scroller", "Landroid/widget/Scroller;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, m_scroller_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr m_selx1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_selx1']"
		[Register ("m_selx1")]
		protected int MSelx1 {
			get {
				if (m_selx1_jfieldId == IntPtr.Zero)
					m_selx1_jfieldId = JNIEnv.GetFieldID (class_ref, "m_selx1", "I");
				return JNIEnv.GetIntField (Handle, m_selx1_jfieldId);
			}
			set {
				if (m_selx1_jfieldId == IntPtr.Zero)
					m_selx1_jfieldId = JNIEnv.GetFieldID (class_ref, "m_selx1", "I");
				JNIEnv.SetField (Handle, m_selx1_jfieldId, value);
			}
		}

		static IntPtr m_selx2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_selx2']"
		[Register ("m_selx2")]
		protected int MSelx2 {
			get {
				if (m_selx2_jfieldId == IntPtr.Zero)
					m_selx2_jfieldId = JNIEnv.GetFieldID (class_ref, "m_selx2", "I");
				return JNIEnv.GetIntField (Handle, m_selx2_jfieldId);
			}
			set {
				if (m_selx2_jfieldId == IntPtr.Zero)
					m_selx2_jfieldId = JNIEnv.GetFieldID (class_ref, "m_selx2", "I");
				JNIEnv.SetField (Handle, m_selx2_jfieldId, value);
			}
		}

		static IntPtr m_sely1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_sely1']"
		[Register ("m_sely1")]
		protected int MSely1 {
			get {
				if (m_sely1_jfieldId == IntPtr.Zero)
					m_sely1_jfieldId = JNIEnv.GetFieldID (class_ref, "m_sely1", "I");
				return JNIEnv.GetIntField (Handle, m_sely1_jfieldId);
			}
			set {
				if (m_sely1_jfieldId == IntPtr.Zero)
					m_sely1_jfieldId = JNIEnv.GetFieldID (class_ref, "m_sely1", "I");
				JNIEnv.SetField (Handle, m_sely1_jfieldId, value);
			}
		}

		static IntPtr m_sely2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_sely2']"
		[Register ("m_sely2")]
		protected int MSely2 {
			get {
				if (m_sely2_jfieldId == IntPtr.Zero)
					m_sely2_jfieldId = JNIEnv.GetFieldID (class_ref, "m_sely2", "I");
				return JNIEnv.GetIntField (Handle, m_sely2_jfieldId);
			}
			set {
				if (m_sely2_jfieldId == IntPtr.Zero)
					m_sely2_jfieldId = JNIEnv.GetFieldID (class_ref, "m_sely2", "I");
				JNIEnv.SetField (Handle, m_sely2_jfieldId, value);
			}
		}

		static IntPtr m_status_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_status']"
		[Register ("m_status")]
		protected int MStatus {
			get {
				if (m_status_jfieldId == IntPtr.Zero)
					m_status_jfieldId = JNIEnv.GetFieldID (class_ref, "m_status", "I");
				return JNIEnv.GetIntField (Handle, m_status_jfieldId);
			}
			set {
				if (m_status_jfieldId == IntPtr.Zero)
					m_status_jfieldId = JNIEnv.GetFieldID (class_ref, "m_status", "I");
				JNIEnv.SetField (Handle, m_status_jfieldId, value);
			}
		}

		static IntPtr m_thread_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_thread']"
		[Register ("m_thread")]
		protected global::Com.Radaee.View.PDFVThread MThread {
			get {
				if (m_thread_jfieldId == IntPtr.Zero)
					m_thread_jfieldId = JNIEnv.GetFieldID (class_ref, "m_thread", "Lcom/radaee/view/PDFVThread;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, m_thread_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVThread> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_thread_jfieldId == IntPtr.Zero)
					m_thread_jfieldId = JNIEnv.GetFieldID (class_ref, "m_thread", "Lcom/radaee/view/PDFVThread;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, m_thread_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr m_w_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/field[@name='m_w']"
		[Register ("m_w")]
		protected int MW {
			get {
				if (m_w_jfieldId == IntPtr.Zero)
					m_w_jfieldId = JNIEnv.GetFieldID (class_ref, "m_w", "I");
				return JNIEnv.GetIntField (Handle, m_w_jfieldId);
			}
			set {
				if (m_w_jfieldId == IntPtr.Zero)
					m_w_jfieldId = JNIEnv.GetFieldID (class_ref, "m_w", "I");
				JNIEnv.SetField (Handle, m_w_jfieldId, value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView.PDFGestureListener']"
		[global::Android.Runtime.Register ("com/radaee/view/PDFView$PDFGestureListener", DoNotGenerateAcw=true)]
		public partial class PDFGestureListener : global::Android.Views.GestureDetector.SimpleOnGestureListener {

			protected PDFGestureListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView.PDFPos']"
		[global::Android.Runtime.Register ("com/radaee/view/PDFView$PDFPos", DoNotGenerateAcw=true)]
		public partial class PDFPos : global::Java.Lang.Object {


			static IntPtr pageno_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView.PDFPos']/field[@name='pageno']"
			[Register ("pageno")]
			public int Pageno {
				get {
					if (pageno_jfieldId == IntPtr.Zero)
						pageno_jfieldId = JNIEnv.GetFieldID (class_ref, "pageno", "I");
					return JNIEnv.GetIntField (Handle, pageno_jfieldId);
				}
				set {
					if (pageno_jfieldId == IntPtr.Zero)
						pageno_jfieldId = JNIEnv.GetFieldID (class_ref, "pageno", "I");
					JNIEnv.SetField (Handle, pageno_jfieldId, value);
				}
			}

			static IntPtr x_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView.PDFPos']/field[@name='x']"
			[Register ("x")]
			public float X {
				get {
					if (x_jfieldId == IntPtr.Zero)
						x_jfieldId = JNIEnv.GetFieldID (class_ref, "x", "F");
					return JNIEnv.GetFloatField (Handle, x_jfieldId);
				}
				set {
					if (x_jfieldId == IntPtr.Zero)
						x_jfieldId = JNIEnv.GetFieldID (class_ref, "x", "F");
					JNIEnv.SetField (Handle, x_jfieldId, value);
				}
			}

			static IntPtr y_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView.PDFPos']/field[@name='y']"
			[Register ("y")]
			public float Y {
				get {
					if (y_jfieldId == IntPtr.Zero)
						y_jfieldId = JNIEnv.GetFieldID (class_ref, "y", "F");
					return JNIEnv.GetFloatField (Handle, y_jfieldId);
				}
				set {
					if (y_jfieldId == IntPtr.Zero)
						y_jfieldId = JNIEnv.GetFieldID (class_ref, "y", "F");
					JNIEnv.SetField (Handle, y_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/radaee/view/PDFView$PDFPos", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PDFPos); }
			}

			protected PDFPos (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_radaee_view_PDFView_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView.PDFPos']/constructor[@name='PDFView.PDFPos' and count(parameter)=1 and parameter[1][@type='com.radaee.view.PDFView']]"
			[Register (".ctor", "(Lcom/radaee/view/PDFView;)V", "")]
			public PDFPos (global::Com.Radaee.View.PDFView __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (PDFPos)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self));
					return;
				}

				if (id_ctor_Lcom_radaee_view_PDFView_ == IntPtr.Zero)
					id_ctor_Lcom_radaee_view_PDFView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/radaee/view/PDFView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_radaee_view_PDFView_, new JValue (__self)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_radaee_view_PDFView_, new JValue (__self));
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.radaee.view']/interface[@name='PDFView.PDFViewListener']"
		[Register ("com/radaee/view/PDFView$PDFViewListener", "", "Com.Radaee.View.PDFView/IPDFViewListenerInvoker")]
		public partial interface IPDFViewListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/interface[@name='PDFView.PDFViewListener']/method[@name='OnPDFDoubleTapped' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
			[Register ("OnPDFDoubleTapped", "(FF)Z", "GetOnPDFDoubleTapped_FFHandler:Com.Radaee.View.PDFView/IPDFViewListenerInvoker, radaee33")]
			bool OnPDFDoubleTapped (float p0, float p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/interface[@name='PDFView.PDFViewListener']/method[@name='OnPDFFound' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("OnPDFFound", "(Z)V", "GetOnPDFFound_ZHandler:Com.Radaee.View.PDFView/IPDFViewListenerInvoker, radaee33")]
			void OnPDFFound (bool p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/interface[@name='PDFView.PDFViewListener']/method[@name='OnPDFInvalidate' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("OnPDFInvalidate", "(Z)V", "GetOnPDFInvalidate_ZHandler:Com.Radaee.View.PDFView/IPDFViewListenerInvoker, radaee33")]
			void OnPDFInvalidate (bool p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/interface[@name='PDFView.PDFViewListener']/method[@name='OnPDFLongPressed' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
			[Register ("OnPDFLongPressed", "(FF)V", "GetOnPDFLongPressed_FFHandler:Com.Radaee.View.PDFView/IPDFViewListenerInvoker, radaee33")]
			void OnPDFLongPressed (float p0, float p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/interface[@name='PDFView.PDFViewListener']/method[@name='OnPDFPageChanged' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("OnPDFPageChanged", "(I)V", "GetOnPDFPageChanged_IHandler:Com.Radaee.View.PDFView/IPDFViewListenerInvoker, radaee33")]
			void OnPDFPageChanged (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/interface[@name='PDFView.PDFViewListener']/method[@name='OnPDFPageDisplayed' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.radaee.view.PDFVPage']]"
			[Register ("OnPDFPageDisplayed", "(Landroid/graphics/Canvas;Lcom/radaee/view/PDFVPage;)V", "GetOnPDFPageDisplayed_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_Handler:Com.Radaee.View.PDFView/IPDFViewListenerInvoker, radaee33")]
			void OnPDFPageDisplayed (global::Android.Graphics.Canvas p0, global::Com.Radaee.View.PDFVPage p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/interface[@name='PDFView.PDFViewListener']/method[@name='OnPDFSelectEnd' and count(parameter)=0]"
			[Register ("OnPDFSelectEnd", "()V", "GetOnPDFSelectEndHandler:Com.Radaee.View.PDFView/IPDFViewListenerInvoker, radaee33")]
			void OnPDFSelectEnd ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/interface[@name='PDFView.PDFViewListener']/method[@name='OnPDFSelecting' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]']]"
			[Register ("OnPDFSelecting", "(Landroid/graphics/Canvas;[I[I)V", "GetOnPDFSelecting_Landroid_graphics_Canvas_arrayIarrayIHandler:Com.Radaee.View.PDFView/IPDFViewListenerInvoker, radaee33")]
			void OnPDFSelecting (global::Android.Graphics.Canvas p0, int[] p1, int[] p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/interface[@name='PDFView.PDFViewListener']/method[@name='OnPDFShowPressed' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
			[Register ("OnPDFShowPressed", "(FF)V", "GetOnPDFShowPressed_FFHandler:Com.Radaee.View.PDFView/IPDFViewListenerInvoker, radaee33")]
			void OnPDFShowPressed (float p0, float p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/interface[@name='PDFView.PDFViewListener']/method[@name='OnPDFSingleTapped' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
			[Register ("OnPDFSingleTapped", "(FF)Z", "GetOnPDFSingleTapped_FFHandler:Com.Radaee.View.PDFView/IPDFViewListenerInvoker, radaee33")]
			bool OnPDFSingleTapped (float p0, float p1);

		}

		[global::Android.Runtime.Register ("com/radaee/view/PDFView$PDFViewListener", DoNotGenerateAcw=true)]
		internal class IPDFViewListenerInvoker : global::Java.Lang.Object, IPDFViewListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/radaee/view/PDFView$PDFViewListener");
			IntPtr class_ref;

			public static IPDFViewListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPDFViewListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.radaee.view.PDFView.PDFViewListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPDFViewListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IPDFViewListenerInvoker); }
			}

			static Delegate cb_OnPDFDoubleTapped_FF;
#pragma warning disable 0169
			static Delegate GetOnPDFDoubleTapped_FFHandler ()
			{
				if (cb_OnPDFDoubleTapped_FF == null)
					cb_OnPDFDoubleTapped_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, bool>) n_OnPDFDoubleTapped_FF);
				return cb_OnPDFDoubleTapped_FF;
			}

			static bool n_OnPDFDoubleTapped_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
			{
				global::Com.Radaee.View.PDFView.IPDFViewListener __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView.IPDFViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.OnPDFDoubleTapped (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnPDFDoubleTapped_FF;
			public bool OnPDFDoubleTapped (float p0, float p1)
			{
				if (id_OnPDFDoubleTapped_FF == IntPtr.Zero)
					id_OnPDFDoubleTapped_FF = JNIEnv.GetMethodID (class_ref, "OnPDFDoubleTapped", "(FF)Z");
				return JNIEnv.CallBooleanMethod (Handle, id_OnPDFDoubleTapped_FF, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_OnPDFFound_Z;
#pragma warning disable 0169
			static Delegate GetOnPDFFound_ZHandler ()
			{
				if (cb_OnPDFFound_Z == null)
					cb_OnPDFFound_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnPDFFound_Z);
				return cb_OnPDFFound_Z;
			}

			static void n_OnPDFFound_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Radaee.View.PDFView.IPDFViewListener __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView.IPDFViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPDFFound (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnPDFFound_Z;
			public void OnPDFFound (bool p0)
			{
				if (id_OnPDFFound_Z == IntPtr.Zero)
					id_OnPDFFound_Z = JNIEnv.GetMethodID (class_ref, "OnPDFFound", "(Z)V");
				JNIEnv.CallVoidMethod (Handle, id_OnPDFFound_Z, new JValue (p0));
			}

			static Delegate cb_OnPDFInvalidate_Z;
#pragma warning disable 0169
			static Delegate GetOnPDFInvalidate_ZHandler ()
			{
				if (cb_OnPDFInvalidate_Z == null)
					cb_OnPDFInvalidate_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnPDFInvalidate_Z);
				return cb_OnPDFInvalidate_Z;
			}

			static void n_OnPDFInvalidate_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Radaee.View.PDFView.IPDFViewListener __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView.IPDFViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPDFInvalidate (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnPDFInvalidate_Z;
			public void OnPDFInvalidate (bool p0)
			{
				if (id_OnPDFInvalidate_Z == IntPtr.Zero)
					id_OnPDFInvalidate_Z = JNIEnv.GetMethodID (class_ref, "OnPDFInvalidate", "(Z)V");
				JNIEnv.CallVoidMethod (Handle, id_OnPDFInvalidate_Z, new JValue (p0));
			}

			static Delegate cb_OnPDFLongPressed_FF;
#pragma warning disable 0169
			static Delegate GetOnPDFLongPressed_FFHandler ()
			{
				if (cb_OnPDFLongPressed_FF == null)
					cb_OnPDFLongPressed_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_OnPDFLongPressed_FF);
				return cb_OnPDFLongPressed_FF;
			}

			static void n_OnPDFLongPressed_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
			{
				global::Com.Radaee.View.PDFView.IPDFViewListener __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView.IPDFViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPDFLongPressed (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnPDFLongPressed_FF;
			public void OnPDFLongPressed (float p0, float p1)
			{
				if (id_OnPDFLongPressed_FF == IntPtr.Zero)
					id_OnPDFLongPressed_FF = JNIEnv.GetMethodID (class_ref, "OnPDFLongPressed", "(FF)V");
				JNIEnv.CallVoidMethod (Handle, id_OnPDFLongPressed_FF, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_OnPDFPageChanged_I;
#pragma warning disable 0169
			static Delegate GetOnPDFPageChanged_IHandler ()
			{
				if (cb_OnPDFPageChanged_I == null)
					cb_OnPDFPageChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnPDFPageChanged_I);
				return cb_OnPDFPageChanged_I;
			}

			static void n_OnPDFPageChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Radaee.View.PDFView.IPDFViewListener __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView.IPDFViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPDFPageChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnPDFPageChanged_I;
			public void OnPDFPageChanged (int p0)
			{
				if (id_OnPDFPageChanged_I == IntPtr.Zero)
					id_OnPDFPageChanged_I = JNIEnv.GetMethodID (class_ref, "OnPDFPageChanged", "(I)V");
				JNIEnv.CallVoidMethod (Handle, id_OnPDFPageChanged_I, new JValue (p0));
			}

			static Delegate cb_OnPDFPageDisplayed_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_;
#pragma warning disable 0169
			static Delegate GetOnPDFPageDisplayed_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_Handler ()
			{
				if (cb_OnPDFPageDisplayed_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_ == null)
					cb_OnPDFPageDisplayed_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPDFPageDisplayed_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_);
				return cb_OnPDFPageDisplayed_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_;
			}

			static void n_OnPDFPageDisplayed_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Radaee.View.PDFView.IPDFViewListener __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView.IPDFViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Radaee.View.PDFVPage p1 = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVPage> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnPDFPageDisplayed (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnPDFPageDisplayed_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_;
			public void OnPDFPageDisplayed (global::Android.Graphics.Canvas p0, global::Com.Radaee.View.PDFVPage p1)
			{
				if (id_OnPDFPageDisplayed_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_ == IntPtr.Zero)
					id_OnPDFPageDisplayed_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_ = JNIEnv.GetMethodID (class_ref, "OnPDFPageDisplayed", "(Landroid/graphics/Canvas;Lcom/radaee/view/PDFVPage;)V");
				JNIEnv.CallVoidMethod (Handle, id_OnPDFPageDisplayed_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_OnPDFSelectEnd;
#pragma warning disable 0169
			static Delegate GetOnPDFSelectEndHandler ()
			{
				if (cb_OnPDFSelectEnd == null)
					cb_OnPDFSelectEnd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPDFSelectEnd);
				return cb_OnPDFSelectEnd;
			}

			static void n_OnPDFSelectEnd (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.View.PDFView.IPDFViewListener __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView.IPDFViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPDFSelectEnd ();
			}
#pragma warning restore 0169

			IntPtr id_OnPDFSelectEnd;
			public void OnPDFSelectEnd ()
			{
				if (id_OnPDFSelectEnd == IntPtr.Zero)
					id_OnPDFSelectEnd = JNIEnv.GetMethodID (class_ref, "OnPDFSelectEnd", "()V");
				JNIEnv.CallVoidMethod (Handle, id_OnPDFSelectEnd);
			}

			static Delegate cb_OnPDFSelecting_Landroid_graphics_Canvas_arrayIarrayI;
#pragma warning disable 0169
			static Delegate GetOnPDFSelecting_Landroid_graphics_Canvas_arrayIarrayIHandler ()
			{
				if (cb_OnPDFSelecting_Landroid_graphics_Canvas_arrayIarrayI == null)
					cb_OnPDFSelecting_Landroid_graphics_Canvas_arrayIarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPDFSelecting_Landroid_graphics_Canvas_arrayIarrayI);
				return cb_OnPDFSelecting_Landroid_graphics_Canvas_arrayIarrayI;
			}

			static void n_OnPDFSelecting_Landroid_graphics_Canvas_arrayIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Radaee.View.PDFView.IPDFViewListener __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView.IPDFViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
				int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
				int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
				__this.OnPDFSelecting (p0, p1, p2);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
			}
#pragma warning restore 0169

			IntPtr id_OnPDFSelecting_Landroid_graphics_Canvas_arrayIarrayI;
			public void OnPDFSelecting (global::Android.Graphics.Canvas p0, int[] p1, int[] p2)
			{
				if (id_OnPDFSelecting_Landroid_graphics_Canvas_arrayIarrayI == IntPtr.Zero)
					id_OnPDFSelecting_Landroid_graphics_Canvas_arrayIarrayI = JNIEnv.GetMethodID (class_ref, "OnPDFSelecting", "(Landroid/graphics/Canvas;[I[I)V");
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				JNIEnv.CallVoidMethod (Handle, id_OnPDFSelecting_Landroid_graphics_Canvas_arrayIarrayI, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

			static Delegate cb_OnPDFShowPressed_FF;
#pragma warning disable 0169
			static Delegate GetOnPDFShowPressed_FFHandler ()
			{
				if (cb_OnPDFShowPressed_FF == null)
					cb_OnPDFShowPressed_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_OnPDFShowPressed_FF);
				return cb_OnPDFShowPressed_FF;
			}

			static void n_OnPDFShowPressed_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
			{
				global::Com.Radaee.View.PDFView.IPDFViewListener __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView.IPDFViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPDFShowPressed (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnPDFShowPressed_FF;
			public void OnPDFShowPressed (float p0, float p1)
			{
				if (id_OnPDFShowPressed_FF == IntPtr.Zero)
					id_OnPDFShowPressed_FF = JNIEnv.GetMethodID (class_ref, "OnPDFShowPressed", "(FF)V");
				JNIEnv.CallVoidMethod (Handle, id_OnPDFShowPressed_FF, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_OnPDFSingleTapped_FF;
#pragma warning disable 0169
			static Delegate GetOnPDFSingleTapped_FFHandler ()
			{
				if (cb_OnPDFSingleTapped_FF == null)
					cb_OnPDFSingleTapped_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, bool>) n_OnPDFSingleTapped_FF);
				return cb_OnPDFSingleTapped_FF;
			}

			static bool n_OnPDFSingleTapped_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
			{
				global::Com.Radaee.View.PDFView.IPDFViewListener __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView.IPDFViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.OnPDFSingleTapped (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_OnPDFSingleTapped_FF;
			public bool OnPDFSingleTapped (float p0, float p1)
			{
				if (id_OnPDFSingleTapped_FF == IntPtr.Zero)
					id_OnPDFSingleTapped_FF = JNIEnv.GetMethodID (class_ref, "OnPDFSingleTapped", "(FF)Z");
				return JNIEnv.CallBooleanMethod (Handle, id_OnPDFSingleTapped_FF, new JValue (p0), new JValue (p1));
			}

		}

		public partial class PDFDoubleTappedEventArgs : global::System.EventArgs {

			public PDFDoubleTappedEventArgs (bool handled, float p0, float p1)
			{
				this.handled = handled;
				this.p0 = p0;
				this.p1 = p1;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			float p0;
			public float P0 {
				get { return p0; }
			}

			float p1;
			public float P1 {
				get { return p1; }
			}
		}

		public partial class PDFFoundEventArgs : global::System.EventArgs {

			public PDFFoundEventArgs (bool p0)
			{
				this.p0 = p0;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}
		}

		public partial class PDFInvalidateEventArgs : global::System.EventArgs {

			public PDFInvalidateEventArgs (bool p0)
			{
				this.p0 = p0;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}
		}

		public partial class PDFLongPressedEventArgs : global::System.EventArgs {

			public PDFLongPressedEventArgs (float p0, float p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			float p0;
			public float P0 {
				get { return p0; }
			}

			float p1;
			public float P1 {
				get { return p1; }
			}
		}

		public partial class PDFPageChangedEventArgs : global::System.EventArgs {

			public PDFPageChangedEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}
		}

		public partial class PDFPageDisplayedEventArgs : global::System.EventArgs {

			public PDFPageDisplayedEventArgs (global::Android.Graphics.Canvas p0, global::Com.Radaee.View.PDFVPage p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Android.Graphics.Canvas p0;
			public global::Android.Graphics.Canvas P0 {
				get { return p0; }
			}

			global::Com.Radaee.View.PDFVPage p1;
			public global::Com.Radaee.View.PDFVPage P1 {
				get { return p1; }
			}
		}

		public partial class PDFSelectingEventArgs : global::System.EventArgs {

			public PDFSelectingEventArgs (global::Android.Graphics.Canvas p0, int[] p1, int[] p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Android.Graphics.Canvas p0;
			public global::Android.Graphics.Canvas P0 {
				get { return p0; }
			}

			int[] p1;
			public int[] P1 {
				get { return p1; }
			}

			int[] p2;
			public int[] P2 {
				get { return p2; }
			}
		}

		public partial class PDFShowPressedEventArgs : global::System.EventArgs {

			public PDFShowPressedEventArgs (float p0, float p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			float p0;
			public float P0 {
				get { return p0; }
			}

			float p1;
			public float P1 {
				get { return p1; }
			}
		}

		public partial class PDFSingleTappedEventArgs : global::System.EventArgs {

			public PDFSingleTappedEventArgs (bool handled, float p0, float p1)
			{
				this.handled = handled;
				this.p0 = p0;
				this.p1 = p1;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			float p0;
			public float P0 {
				get { return p0; }
			}

			float p1;
			public float P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/radaee/view/PDFView_PDFViewListenerImplementor")]
		internal sealed class IPDFViewListenerImplementor : global::Java.Lang.Object, IPDFViewListener {

			object sender;

			public IPDFViewListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/radaee/view/PDFView_PDFViewListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<PDFDoubleTappedEventArgs> OnPDFDoubleTappedHandler;
#pragma warning restore 0649

			public bool OnPDFDoubleTapped (float p0, float p1)
			{
				var __h = OnPDFDoubleTappedHandler;
				if (__h == null)
					return false;
				var __e = new PDFDoubleTappedEventArgs (true, p0, p1);
				__h (sender, __e);
				return __e.Handled;
			}
#pragma warning disable 0649
			public EventHandler<PDFFoundEventArgs> OnPDFFoundHandler;
#pragma warning restore 0649

			public void OnPDFFound (bool p0)
			{
				var __h = OnPDFFoundHandler;
				if (__h != null)
					__h (sender, new PDFFoundEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<PDFInvalidateEventArgs> OnPDFInvalidateHandler;
#pragma warning restore 0649

			public void OnPDFInvalidate (bool p0)
			{
				var __h = OnPDFInvalidateHandler;
				if (__h != null)
					__h (sender, new PDFInvalidateEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<PDFLongPressedEventArgs> OnPDFLongPressedHandler;
#pragma warning restore 0649

			public void OnPDFLongPressed (float p0, float p1)
			{
				var __h = OnPDFLongPressedHandler;
				if (__h != null)
					__h (sender, new PDFLongPressedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<PDFPageChangedEventArgs> OnPDFPageChangedHandler;
#pragma warning restore 0649

			public void OnPDFPageChanged (int p0)
			{
				var __h = OnPDFPageChangedHandler;
				if (__h != null)
					__h (sender, new PDFPageChangedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<PDFPageDisplayedEventArgs> OnPDFPageDisplayedHandler;
#pragma warning restore 0649

			public void OnPDFPageDisplayed (global::Android.Graphics.Canvas p0, global::Com.Radaee.View.PDFVPage p1)
			{
				var __h = OnPDFPageDisplayedHandler;
				if (__h != null)
					__h (sender, new PDFPageDisplayedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler OnPDFSelectEndHandler;
#pragma warning restore 0649

			public void OnPDFSelectEnd ()
			{
				var __h = OnPDFSelectEndHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<PDFSelectingEventArgs> OnPDFSelectingHandler;
#pragma warning restore 0649

			public void OnPDFSelecting (global::Android.Graphics.Canvas p0, int[] p1, int[] p2)
			{
				var __h = OnPDFSelectingHandler;
				if (__h != null)
					__h (sender, new PDFSelectingEventArgs (p0, p1, p2));
			}
#pragma warning disable 0649
			public EventHandler<PDFShowPressedEventArgs> OnPDFShowPressedHandler;
#pragma warning restore 0649

			public void OnPDFShowPressed (float p0, float p1)
			{
				var __h = OnPDFShowPressedHandler;
				if (__h != null)
					__h (sender, new PDFShowPressedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<PDFSingleTappedEventArgs> OnPDFSingleTappedHandler;
#pragma warning restore 0649

			public bool OnPDFSingleTapped (float p0, float p1)
			{
				var __h = OnPDFSingleTappedHandler;
				if (__h == null)
					return false;
				var __e = new PDFSingleTappedEventArgs (true, p0, p1);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IPDFViewListenerImplementor value)
			{
				return value.OnPDFDoubleTappedHandler == null && value.OnPDFFoundHandler == null && value.OnPDFInvalidateHandler == null && value.OnPDFLongPressedHandler == null && value.OnPDFPageChangedHandler == null && value.OnPDFPageDisplayedHandler == null && value.OnPDFSelectEndHandler == null && value.OnPDFSelectingHandler == null && value.OnPDFShowPressedHandler == null && value.OnPDFSingleTappedHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/radaee/view/PDFView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PDFView); }
		}

		protected PDFView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/constructor[@name='PDFView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public PDFView (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PDFView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static Delegate cb_motionNormal_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetMotionNormal_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_motionNormal_Landroid_view_MotionEvent_ == null)
				cb_motionNormal_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_MotionNormal_Landroid_view_MotionEvent_);
			return cb_motionNormal_Landroid_view_MotionEvent_;
		}

		static bool n_MotionNormal_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.MotionNormal (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_motionNormal_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='motionNormal' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("motionNormal", "(Landroid/view/MotionEvent;)Z", "GetMotionNormal_Landroid_view_MotionEvent_Handler")]
		protected virtual bool MotionNormal (global::Android.Views.MotionEvent p0)
		{
			if (id_motionNormal_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_motionNormal_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "motionNormal", "(Landroid/view/MotionEvent;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_motionNormal_Landroid_view_MotionEvent_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "motionNormal", "(Landroid/view/MotionEvent;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_vCenterPage_I;
#pragma warning disable 0169
		static Delegate GetVCenterPage_IHandler ()
		{
			if (cb_vCenterPage_I == null)
				cb_vCenterPage_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_VCenterPage_I);
			return cb_vCenterPage_I;
		}

		static void n_VCenterPage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VCenterPage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_vCenterPage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vCenterPage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("vCenterPage", "(I)V", "GetVCenterPage_IHandler")]
		public virtual void VCenterPage (int p0)
		{
			if (id_vCenterPage_I == IntPtr.Zero)
				id_vCenterPage_I = JNIEnv.GetMethodID (class_ref, "vCenterPage", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vCenterPage_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vCenterPage", "(I)V"), new JValue (p0));
		}

		static Delegate cb_vClearSel;
#pragma warning disable 0169
		static Delegate GetVClearSelHandler ()
		{
			if (cb_vClearSel == null)
				cb_vClearSel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_VClearSel);
			return cb_vClearSel;
		}

		static void n_VClearSel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VClearSel ();
		}
#pragma warning restore 0169

		static IntPtr id_vClearSel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vClearSel' and count(parameter)=0]"
		[Register ("vClearSel", "()V", "GetVClearSelHandler")]
		public virtual void VClearSel ()
		{
			if (id_vClearSel == IntPtr.Zero)
				id_vClearSel = JNIEnv.GetMethodID (class_ref, "vClearSel", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vClearSel);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vClearSel", "()V"));
		}

		static Delegate cb_vClose;
#pragma warning disable 0169
		static Delegate GetVCloseHandler ()
		{
			if (cb_vClose == null)
				cb_vClose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_VClose);
			return cb_vClose;
		}

		static void n_VClose (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VClose ();
		}
#pragma warning restore 0169

		static IntPtr id_vClose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vClose' and count(parameter)=0]"
		[Register ("vClose", "()V", "GetVCloseHandler")]
		public virtual void VClose ()
		{
			if (id_vClose == IntPtr.Zero)
				id_vClose = JNIEnv.GetMethodID (class_ref, "vClose", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vClose);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vClose", "()V"));
		}

		static Delegate cb_vComputeScroll;
#pragma warning disable 0169
		static Delegate GetVComputeScrollHandler ()
		{
			if (cb_vComputeScroll == null)
				cb_vComputeScroll = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_VComputeScroll);
			return cb_vComputeScroll;
		}

		static void n_VComputeScroll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VComputeScroll ();
		}
#pragma warning restore 0169

		static IntPtr id_vComputeScroll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vComputeScroll' and count(parameter)=0]"
		[Register ("vComputeScroll", "()V", "GetVComputeScrollHandler")]
		public virtual void VComputeScroll ()
		{
			if (id_vComputeScroll == IntPtr.Zero)
				id_vComputeScroll = JNIEnv.GetMethodID (class_ref, "vComputeScroll", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vComputeScroll);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vComputeScroll", "()V"));
		}

		static Delegate cb_vDraw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetVDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_vDraw_Landroid_graphics_Canvas_ == null)
				cb_vDraw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_VDraw_Landroid_graphics_Canvas_);
			return cb_vDraw_Landroid_graphics_Canvas_;
		}

		static void n_VDraw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VDraw (p0);
		}
#pragma warning restore 0169

		static IntPtr id_vDraw_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vDraw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("vDraw", "(Landroid/graphics/Canvas;)V", "GetVDraw_Landroid_graphics_Canvas_Handler")]
		public virtual void VDraw (global::Android.Graphics.Canvas p0)
		{
			if (id_vDraw_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_vDraw_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "vDraw", "(Landroid/graphics/Canvas;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vDraw_Landroid_graphics_Canvas_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vDraw", "(Landroid/graphics/Canvas;)V"), new JValue (p0));
		}

		static Delegate cb_vFind_I;
#pragma warning disable 0169
		static Delegate GetVFind_IHandler ()
		{
			if (cb_vFind_I == null)
				cb_vFind_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_VFind_I);
			return cb_vFind_I;
		}

		static int n_VFind_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VFind (p0);
		}
#pragma warning restore 0169

		static IntPtr id_vFind_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vFind' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("vFind", "(I)I", "GetVFind_IHandler")]
		public virtual int VFind (int p0)
		{
			if (id_vFind_I == IntPtr.Zero)
				id_vFind_I = JNIEnv.GetMethodID (class_ref, "vFind", "(I)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_vFind_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vFind", "(I)I"), new JValue (p0));
		}

		static Delegate cb_vFindEnd;
#pragma warning disable 0169
		static Delegate GetVFindEndHandler ()
		{
			if (cb_vFindEnd == null)
				cb_vFindEnd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_VFindEnd);
			return cb_vFindEnd;
		}

		static void n_VFindEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VFindEnd ();
		}
#pragma warning restore 0169

		static IntPtr id_vFindEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vFindEnd' and count(parameter)=0]"
		[Register ("vFindEnd", "()V", "GetVFindEndHandler")]
		public virtual void VFindEnd ()
		{
			if (id_vFindEnd == IntPtr.Zero)
				id_vFindEnd = JNIEnv.GetMethodID (class_ref, "vFindEnd", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vFindEnd);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vFindEnd", "()V"));
		}

		static Delegate cb_vFindGoto;
#pragma warning disable 0169
		static Delegate GetVFindGotoHandler ()
		{
			if (cb_vFindGoto == null)
				cb_vFindGoto = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_VFindGoto);
			return cb_vFindGoto;
		}

		static void n_VFindGoto (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VFindGoto ();
		}
#pragma warning restore 0169

		static IntPtr id_vFindGoto;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vFindGoto' and count(parameter)=0]"
		[Register ("vFindGoto", "()V", "GetVFindGotoHandler")]
		protected virtual void VFindGoto ()
		{
			if (id_vFindGoto == IntPtr.Zero)
				id_vFindGoto = JNIEnv.GetMethodID (class_ref, "vFindGoto", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vFindGoto);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vFindGoto", "()V"));
		}

		static Delegate cb_vFindStart_Ljava_lang_String_ZZ;
#pragma warning disable 0169
		static Delegate GetVFindStart_Ljava_lang_String_ZZHandler ()
		{
			if (cb_vFindStart_Ljava_lang_String_ZZ == null)
				cb_vFindStart_Ljava_lang_String_ZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, bool>) n_VFindStart_Ljava_lang_String_ZZ);
			return cb_vFindStart_Ljava_lang_String_ZZ;
		}

		static void n_VFindStart_Ljava_lang_String_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, bool p2)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VFindStart (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_vFindStart_Ljava_lang_String_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vFindStart' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("vFindStart", "(Ljava/lang/String;ZZ)V", "GetVFindStart_Ljava_lang_String_ZZHandler")]
		public virtual void VFindStart (string p0, bool p1, bool p2)
		{
			if (id_vFindStart_Ljava_lang_String_ZZ == IntPtr.Zero)
				id_vFindStart_Ljava_lang_String_ZZ = JNIEnv.GetMethodID (class_ref, "vFindStart", "(Ljava/lang/String;ZZ)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vFindStart_Ljava_lang_String_ZZ, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vFindStart", "(Ljava/lang/String;ZZ)V"), new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_vFlushRange;
#pragma warning disable 0169
		static Delegate GetVFlushRangeHandler ()
		{
			if (cb_vFlushRange == null)
				cb_vFlushRange = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_VFlushRange);
			return cb_vFlushRange;
		}

		static void n_VFlushRange (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VFlushRange ();
		}
#pragma warning restore 0169

		static IntPtr id_vFlushRange;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vFlushRange' and count(parameter)=0]"
		[Register ("vFlushRange", "()V", "GetVFlushRangeHandler")]
		protected virtual void VFlushRange ()
		{
			if (id_vFlushRange == IntPtr.Zero)
				id_vFlushRange = JNIEnv.GetMethodID (class_ref, "vFlushRange", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vFlushRange);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vFlushRange", "()V"));
		}

		static IntPtr id_vGetDocH;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vGetDocH' and count(parameter)=0]"
		[Register ("vGetDocH", "()I", "")]
		public int VGetDocH ()
		{
			if (id_vGetDocH == IntPtr.Zero)
				id_vGetDocH = JNIEnv.GetMethodID (class_ref, "vGetDocH", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_vGetDocH);
		}

		static IntPtr id_vGetDocW;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vGetDocW' and count(parameter)=0]"
		[Register ("vGetDocW", "()I", "")]
		public int VGetDocW ()
		{
			if (id_vGetDocW == IntPtr.Zero)
				id_vGetDocW = JNIEnv.GetMethodID (class_ref, "vGetDocW", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_vGetDocW);
		}

		static Delegate cb_vGetLock;
#pragma warning disable 0169
		static Delegate GetVGetLockHandler ()
		{
			if (cb_vGetLock == null)
				cb_vGetLock = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_VGetLock);
			return cb_vGetLock;
		}

		static int n_VGetLock (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VGetLock ();
		}
#pragma warning restore 0169

		static IntPtr id_vGetLock;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vGetLock' and count(parameter)=0]"
		[Register ("vGetLock", "()I", "GetVGetLockHandler")]
		public virtual int VGetLock ()
		{
			if (id_vGetLock == IntPtr.Zero)
				id_vGetLock = JNIEnv.GetMethodID (class_ref, "vGetLock", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_vGetLock);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vGetLock", "()I"));
		}

		static Delegate cb_vGetMaxScale;
#pragma warning disable 0169
		static Delegate GetVGetMaxScaleHandler ()
		{
			if (cb_vGetMaxScale == null)
				cb_vGetMaxScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_VGetMaxScale);
			return cb_vGetMaxScale;
		}

		static float n_VGetMaxScale (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VGetMaxScale ();
		}
#pragma warning restore 0169

		static IntPtr id_vGetMaxScale;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vGetMaxScale' and count(parameter)=0]"
		[Register ("vGetMaxScale", "()F", "GetVGetMaxScaleHandler")]
		public virtual float VGetMaxScale ()
		{
			if (id_vGetMaxScale == IntPtr.Zero)
				id_vGetMaxScale = JNIEnv.GetMethodID (class_ref, "vGetMaxScale", "()F");

			if (GetType () == ThresholdType)
				return JNIEnv.CallFloatMethod  (Handle, id_vGetMaxScale);
			else
				return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vGetMaxScale", "()F"));
		}

		static Delegate cb_vGetMinScale;
#pragma warning disable 0169
		static Delegate GetVGetMinScaleHandler ()
		{
			if (cb_vGetMinScale == null)
				cb_vGetMinScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_VGetMinScale);
			return cb_vGetMinScale;
		}

		static float n_VGetMinScale (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VGetMinScale ();
		}
#pragma warning restore 0169

		static IntPtr id_vGetMinScale;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vGetMinScale' and count(parameter)=0]"
		[Register ("vGetMinScale", "()F", "GetVGetMinScaleHandler")]
		public virtual float VGetMinScale ()
		{
			if (id_vGetMinScale == IntPtr.Zero)
				id_vGetMinScale = JNIEnv.GetMethodID (class_ref, "vGetMinScale", "()F");

			if (GetType () == ThresholdType)
				return JNIEnv.CallFloatMethod  (Handle, id_vGetMinScale);
			else
				return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vGetMinScale", "()F"));
		}

		static Delegate cb_vGetPage_I;
#pragma warning disable 0169
		static Delegate GetVGetPage_IHandler ()
		{
			if (cb_vGetPage_I == null)
				cb_vGetPage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_VGetPage_I);
			return cb_vGetPage_I;
		}

		static IntPtr n_VGetPage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VGetPage (p0));
		}
#pragma warning restore 0169

		static IntPtr id_vGetPage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vGetPage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("vGetPage", "(I)Lcom/radaee/view/PDFVPage;", "GetVGetPage_IHandler")]
		public virtual global::Com.Radaee.View.PDFVPage VGetPage (int p0)
		{
			if (id_vGetPage_I == IntPtr.Zero)
				id_vGetPage_I = JNIEnv.GetMethodID (class_ref, "vGetPage", "(I)Lcom/radaee/view/PDFVPage;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVPage> (JNIEnv.CallObjectMethod  (Handle, id_vGetPage_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVPage> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vGetPage", "(I)Lcom/radaee/view/PDFVPage;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_vGetPage_II;
#pragma warning disable 0169
		static Delegate GetVGetPage_IIHandler ()
		{
			if (cb_vGetPage_II == null)
				cb_vGetPage_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_VGetPage_II);
			return cb_vGetPage_II;
		}

		static int n_VGetPage_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VGetPage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_vGetPage_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vGetPage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("vGetPage", "(II)I", "GetVGetPage_IIHandler")]
		protected virtual int VGetPage (int p0, int p1)
		{
			if (id_vGetPage_II == IntPtr.Zero)
				id_vGetPage_II = JNIEnv.GetMethodID (class_ref, "vGetPage", "(II)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_vGetPage_II, new JValue (p0), new JValue (p1));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vGetPage", "(II)I"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_vGetPos_II;
#pragma warning disable 0169
		static Delegate GetVGetPos_IIHandler ()
		{
			if (cb_vGetPos_II == null)
				cb_vGetPos_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_VGetPos_II);
			return cb_vGetPos_II;
		}

		static IntPtr n_VGetPos_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VGetPos (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_vGetPos_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vGetPos' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("vGetPos", "(II)Lcom/radaee/view/PDFView$PDFPos;", "GetVGetPos_IIHandler")]
		public virtual global::Com.Radaee.View.PDFView.PDFPos VGetPos (int p0, int p1)
		{
			if (id_vGetPos_II == IntPtr.Zero)
				id_vGetPos_II = JNIEnv.GetMethodID (class_ref, "vGetPos", "(II)Lcom/radaee/view/PDFView$PDFPos;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView.PDFPos> (JNIEnv.CallObjectMethod  (Handle, id_vGetPos_II, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView.PDFPos> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vGetPos", "(II)Lcom/radaee/view/PDFView$PDFPos;"), new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_vGetScale;
#pragma warning disable 0169
		static Delegate GetVGetScaleHandler ()
		{
			if (cb_vGetScale == null)
				cb_vGetScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_VGetScale);
			return cb_vGetScale;
		}

		static float n_VGetScale (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VGetScale ();
		}
#pragma warning restore 0169

		static IntPtr id_vGetScale;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vGetScale' and count(parameter)=0]"
		[Register ("vGetScale", "()F", "GetVGetScaleHandler")]
		public virtual float VGetScale ()
		{
			if (id_vGetScale == IntPtr.Zero)
				id_vGetScale = JNIEnv.GetMethodID (class_ref, "vGetScale", "()F");

			if (GetType () == ThresholdType)
				return JNIEnv.CallFloatMethod  (Handle, id_vGetScale);
			else
				return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vGetScale", "()F"));
		}

		static Delegate cb_vGetSel;
#pragma warning disable 0169
		static Delegate GetVGetSelHandler ()
		{
			if (cb_vGetSel == null)
				cb_vGetSel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_VGetSel);
			return cb_vGetSel;
		}

		static IntPtr n_VGetSel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VGetSel ());
		}
#pragma warning restore 0169

		static IntPtr id_vGetSel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vGetSel' and count(parameter)=0]"
		[Register ("vGetSel", "()Ljava/lang/String;", "GetVGetSelHandler")]
		public virtual string VGetSel ()
		{
			if (id_vGetSel == IntPtr.Zero)
				id_vGetSel = JNIEnv.GetMethodID (class_ref, "vGetSel", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_vGetSel), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vGetSel", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_vGetWinH;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vGetWinH' and count(parameter)=0]"
		[Register ("vGetWinH", "()I", "")]
		public int VGetWinH ()
		{
			if (id_vGetWinH == IntPtr.Zero)
				id_vGetWinH = JNIEnv.GetMethodID (class_ref, "vGetWinH", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_vGetWinH);
		}

		static IntPtr id_vGetWinW;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vGetWinW' and count(parameter)=0]"
		[Register ("vGetWinW", "()I", "")]
		public int VGetWinW ()
		{
			if (id_vGetWinW == IntPtr.Zero)
				id_vGetWinW = JNIEnv.GetMethodID (class_ref, "vGetWinW", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_vGetWinW);
		}

		static IntPtr id_vGetX;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vGetX' and count(parameter)=0]"
		[Register ("vGetX", "()I", "")]
		public int VGetX ()
		{
			if (id_vGetX == IntPtr.Zero)
				id_vGetX = JNIEnv.GetMethodID (class_ref, "vGetX", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_vGetX);
		}

		static IntPtr id_vGetY;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vGetY' and count(parameter)=0]"
		[Register ("vGetY", "()I", "")]
		public int VGetY ()
		{
			if (id_vGetY == IntPtr.Zero)
				id_vGetY = JNIEnv.GetMethodID (class_ref, "vGetY", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_vGetY);
		}

		static Delegate cb_vGotoPage_I;
#pragma warning disable 0169
		static Delegate GetVGotoPage_IHandler ()
		{
			if (cb_vGotoPage_I == null)
				cb_vGotoPage_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_VGotoPage_I);
			return cb_vGotoPage_I;
		}

		static void n_VGotoPage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VGotoPage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_vGotoPage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vGotoPage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("vGotoPage", "(I)V", "GetVGotoPage_IHandler")]
		public virtual void VGotoPage (int p0)
		{
			if (id_vGotoPage_I == IntPtr.Zero)
				id_vGotoPage_I = JNIEnv.GetMethodID (class_ref, "vGotoPage", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vGotoPage_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vGotoPage", "(I)V"), new JValue (p0));
		}

		static Delegate cb_vLayout;
#pragma warning disable 0169
		static Delegate GetVLayoutHandler ()
		{
			if (cb_vLayout == null)
				cb_vLayout = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_VLayout);
			return cb_vLayout;
		}

		static void n_VLayout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VLayout ();
		}
#pragma warning restore 0169

		static IntPtr id_vLayout;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vLayout' and count(parameter)=0]"
		[Register ("vLayout", "()V", "GetVLayoutHandler")]
		protected virtual void VLayout ()
		{
			if (id_vLayout == IntPtr.Zero)
				id_vLayout = JNIEnv.GetMethodID (class_ref, "vLayout", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vLayout);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vLayout", "()V"));
		}

		static Delegate cb_vMovingFinished;
#pragma warning disable 0169
		static Delegate GetVMovingFinishedHandler ()
		{
			if (cb_vMovingFinished == null)
				cb_vMovingFinished = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_VMovingFinished);
			return cb_vMovingFinished;
		}

		static bool n_VMovingFinished (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VMovingFinished ();
		}
#pragma warning restore 0169

		static IntPtr id_vMovingFinished;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vMovingFinished' and count(parameter)=0]"
		[Register ("vMovingFinished", "()Z", "GetVMovingFinishedHandler")]
		public virtual bool VMovingFinished ()
		{
			if (id_vMovingFinished == IntPtr.Zero)
				id_vMovingFinished = JNIEnv.GetMethodID (class_ref, "vMovingFinished", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_vMovingFinished);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vMovingFinished", "()Z"));
		}

		static Delegate cb_vOnFling_FFFF;
#pragma warning disable 0169
		static Delegate GetVOnFling_FFFFHandler ()
		{
			if (cb_vOnFling_FFFF == null)
				cb_vOnFling_FFFF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, float, float, bool>) n_VOnFling_FFFF);
			return cb_vOnFling_FFFF;
		}

		static bool n_VOnFling_FFFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2, float p3)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VOnFling (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_vOnFling_FFFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vOnFling' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("vOnFling", "(FFFF)Z", "GetVOnFling_FFFFHandler")]
		protected virtual bool VOnFling (float p0, float p1, float p2, float p3)
		{
			if (id_vOnFling_FFFF == IntPtr.Zero)
				id_vOnFling_FFFF = JNIEnv.GetMethodID (class_ref, "vOnFling", "(FFFF)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_vOnFling_FFFF, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vOnFling", "(FFFF)Z"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static Delegate cb_vOnMoveEnd_II;
#pragma warning disable 0169
		static Delegate GetVOnMoveEnd_IIHandler ()
		{
			if (cb_vOnMoveEnd_II == null)
				cb_vOnMoveEnd_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_VOnMoveEnd_II);
			return cb_vOnMoveEnd_II;
		}

		static void n_VOnMoveEnd_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VOnMoveEnd (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_vOnMoveEnd_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vOnMoveEnd' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("vOnMoveEnd", "(II)V", "GetVOnMoveEnd_IIHandler")]
		protected virtual void VOnMoveEnd (int p0, int p1)
		{
			if (id_vOnMoveEnd_II == IntPtr.Zero)
				id_vOnMoveEnd_II = JNIEnv.GetMethodID (class_ref, "vOnMoveEnd", "(II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vOnMoveEnd_II, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vOnMoveEnd", "(II)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_vOnTimer_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetVOnTimer_Ljava_lang_Object_Handler ()
		{
			if (cb_vOnTimer_Ljava_lang_Object_ == null)
				cb_vOnTimer_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_VOnTimer_Ljava_lang_Object_);
			return cb_vOnTimer_Ljava_lang_Object_;
		}

		static void n_VOnTimer_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VOnTimer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_vOnTimer_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vOnTimer' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("vOnTimer", "(Ljava/lang/Object;)V", "GetVOnTimer_Ljava_lang_Object_Handler")]
		protected virtual void VOnTimer (global::Java.Lang.Object p0)
		{
			if (id_vOnTimer_Ljava_lang_Object_ == IntPtr.Zero)
				id_vOnTimer_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "vOnTimer", "(Ljava/lang/Object;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vOnTimer_Ljava_lang_Object_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vOnTimer", "(Ljava/lang/Object;)V"), new JValue (p0));
		}

		static Delegate cb_vOnZoomEnd;
#pragma warning disable 0169
		static Delegate GetVOnZoomEndHandler ()
		{
			if (cb_vOnZoomEnd == null)
				cb_vOnZoomEnd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_VOnZoomEnd);
			return cb_vOnZoomEnd;
		}

		static void n_VOnZoomEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VOnZoomEnd ();
		}
#pragma warning restore 0169

		static IntPtr id_vOnZoomEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vOnZoomEnd' and count(parameter)=0]"
		[Register ("vOnZoomEnd", "()V", "GetVOnZoomEndHandler")]
		protected virtual void VOnZoomEnd ()
		{
			if (id_vOnZoomEnd == IntPtr.Zero)
				id_vOnZoomEnd = JNIEnv.GetMethodID (class_ref, "vOnZoomEnd", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vOnZoomEnd);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vOnZoomEnd", "()V"));
		}

		static Delegate cb_vOpen_Lcom_radaee_pdf_Document_IILcom_radaee_view_PDFView_PDFViewListener_;
#pragma warning disable 0169
		static Delegate GetVOpen_Lcom_radaee_pdf_Document_IILcom_radaee_view_PDFView_PDFViewListener_Handler ()
		{
			if (cb_vOpen_Lcom_radaee_pdf_Document_IILcom_radaee_view_PDFView_PDFViewListener_ == null)
				cb_vOpen_Lcom_radaee_pdf_Document_IILcom_radaee_view_PDFView_PDFViewListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_VOpen_Lcom_radaee_pdf_Document_IILcom_radaee_view_PDFView_PDFViewListener_);
			return cb_vOpen_Lcom_radaee_pdf_Document_IILcom_radaee_view_PDFView_PDFViewListener_;
		}

		static void n_VOpen_Lcom_radaee_pdf_Document_IILcom_radaee_view_PDFView_PDFViewListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Document p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.View.PDFView.IPDFViewListener p3 = (global::Com.Radaee.View.PDFView.IPDFViewListener)global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView.IPDFViewListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.VOpen (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_vOpen_Lcom_radaee_pdf_Document_IILcom_radaee_view_PDFView_PDFViewListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vOpen' and count(parameter)=4 and parameter[1][@type='com.radaee.pdf.Document'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.radaee.view.PDFView.PDFViewListener']]"
		[Register ("vOpen", "(Lcom/radaee/pdf/Document;IILcom/radaee/view/PDFView$PDFViewListener;)V", "GetVOpen_Lcom_radaee_pdf_Document_IILcom_radaee_view_PDFView_PDFViewListener_Handler")]
		public virtual void VOpen (global::Com.Radaee.Pdf.Document p0, int p1, int p2, global::Com.Radaee.View.PDFView.IPDFViewListener p3)
		{
			if (id_vOpen_Lcom_radaee_pdf_Document_IILcom_radaee_view_PDFView_PDFViewListener_ == IntPtr.Zero)
				id_vOpen_Lcom_radaee_pdf_Document_IILcom_radaee_view_PDFView_PDFViewListener_ = JNIEnv.GetMethodID (class_ref, "vOpen", "(Lcom/radaee/pdf/Document;IILcom/radaee/view/PDFView$PDFViewListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vOpen_Lcom_radaee_pdf_Document_IILcom_radaee_view_PDFView_PDFViewListener_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vOpen", "(Lcom/radaee/pdf/Document;IILcom/radaee/view/PDFView$PDFViewListener;)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static Delegate cb_vRenderAsync_Lcom_radaee_view_PDFVPage_;
#pragma warning disable 0169
		static Delegate GetVRenderAsync_Lcom_radaee_view_PDFVPage_Handler ()
		{
			if (cb_vRenderAsync_Lcom_radaee_view_PDFVPage_ == null)
				cb_vRenderAsync_Lcom_radaee_view_PDFVPage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_VRenderAsync_Lcom_radaee_view_PDFVPage_);
			return cb_vRenderAsync_Lcom_radaee_view_PDFVPage_;
		}

		static void n_VRenderAsync_Lcom_radaee_view_PDFVPage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.View.PDFVPage p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVPage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VRenderAsync (p0);
		}
#pragma warning restore 0169

		static IntPtr id_vRenderAsync_Lcom_radaee_view_PDFVPage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vRenderAsync' and count(parameter)=1 and parameter[1][@type='com.radaee.view.PDFVPage']]"
		[Register ("vRenderAsync", "(Lcom/radaee/view/PDFVPage;)V", "GetVRenderAsync_Lcom_radaee_view_PDFVPage_Handler")]
		public virtual void VRenderAsync (global::Com.Radaee.View.PDFVPage p0)
		{
			if (id_vRenderAsync_Lcom_radaee_view_PDFVPage_ == IntPtr.Zero)
				id_vRenderAsync_Lcom_radaee_view_PDFVPage_ = JNIEnv.GetMethodID (class_ref, "vRenderAsync", "(Lcom/radaee/view/PDFVPage;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vRenderAsync_Lcom_radaee_view_PDFVPage_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vRenderAsync", "(Lcom/radaee/view/PDFVPage;)V"), new JValue (p0));
		}

		static Delegate cb_vRenderSync_Lcom_radaee_view_PDFVPage_;
#pragma warning disable 0169
		static Delegate GetVRenderSync_Lcom_radaee_view_PDFVPage_Handler ()
		{
			if (cb_vRenderSync_Lcom_radaee_view_PDFVPage_ == null)
				cb_vRenderSync_Lcom_radaee_view_PDFVPage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_VRenderSync_Lcom_radaee_view_PDFVPage_);
			return cb_vRenderSync_Lcom_radaee_view_PDFVPage_;
		}

		static void n_VRenderSync_Lcom_radaee_view_PDFVPage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.View.PDFVPage p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVPage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VRenderSync (p0);
		}
#pragma warning restore 0169

		static IntPtr id_vRenderSync_Lcom_radaee_view_PDFVPage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vRenderSync' and count(parameter)=1 and parameter[1][@type='com.radaee.view.PDFVPage']]"
		[Register ("vRenderSync", "(Lcom/radaee/view/PDFVPage;)V", "GetVRenderSync_Lcom_radaee_view_PDFVPage_Handler")]
		public virtual void VRenderSync (global::Com.Radaee.View.PDFVPage p0)
		{
			if (id_vRenderSync_Lcom_radaee_view_PDFVPage_ == IntPtr.Zero)
				id_vRenderSync_Lcom_radaee_view_PDFVPage_ = JNIEnv.GetMethodID (class_ref, "vRenderSync", "(Lcom/radaee/view/PDFVPage;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vRenderSync_Lcom_radaee_view_PDFVPage_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vRenderSync", "(Lcom/radaee/view/PDFVPage;)V"), new JValue (p0));
		}

		static Delegate cb_vResize_II;
#pragma warning disable 0169
		static Delegate GetVResize_IIHandler ()
		{
			if (cb_vResize_II == null)
				cb_vResize_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_VResize_II);
			return cb_vResize_II;
		}

		static void n_VResize_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VResize (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_vResize_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vResize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("vResize", "(II)V", "GetVResize_IIHandler")]
		public virtual void VResize (int p0, int p1)
		{
			if (id_vResize_II == IntPtr.Zero)
				id_vResize_II = JNIEnv.GetMethodID (class_ref, "vResize", "(II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vResize_II, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vResize", "(II)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_vSetBackColor_I;
#pragma warning disable 0169
		static Delegate GetVSetBackColor_IHandler ()
		{
			if (cb_vSetBackColor_I == null)
				cb_vSetBackColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_VSetBackColor_I);
			return cb_vSetBackColor_I;
		}

		static void n_VSetBackColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VSetBackColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_vSetBackColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vSetBackColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("vSetBackColor", "(I)V", "GetVSetBackColor_IHandler")]
		public virtual void VSetBackColor (int p0)
		{
			if (id_vSetBackColor_I == IntPtr.Zero)
				id_vSetBackColor_I = JNIEnv.GetMethodID (class_ref, "vSetBackColor", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vSetBackColor_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vSetBackColor", "(I)V"), new JValue (p0));
		}

		static Delegate cb_vSetLock_I;
#pragma warning disable 0169
		static Delegate GetVSetLock_IHandler ()
		{
			if (cb_vSetLock_I == null)
				cb_vSetLock_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_VSetLock_I);
			return cb_vSetLock_I;
		}

		static void n_VSetLock_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VSetLock (p0);
		}
#pragma warning restore 0169

		static IntPtr id_vSetLock_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vSetLock' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("vSetLock", "(I)V", "GetVSetLock_IHandler")]
		public virtual void VSetLock (int p0)
		{
			if (id_vSetLock_I == IntPtr.Zero)
				id_vSetLock_I = JNIEnv.GetMethodID (class_ref, "vSetLock", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vSetLock_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vSetLock", "(I)V"), new JValue (p0));
		}

		static Delegate cb_vSetPageGap_I;
#pragma warning disable 0169
		static Delegate GetVSetPageGap_IHandler ()
		{
			if (cb_vSetPageGap_I == null)
				cb_vSetPageGap_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_VSetPageGap_I);
			return cb_vSetPageGap_I;
		}

		static void n_VSetPageGap_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VSetPageGap (p0);
		}
#pragma warning restore 0169

		static IntPtr id_vSetPageGap_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vSetPageGap' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("vSetPageGap", "(I)V", "GetVSetPageGap_IHandler")]
		public virtual void VSetPageGap (int p0)
		{
			if (id_vSetPageGap_I == IntPtr.Zero)
				id_vSetPageGap_I = JNIEnv.GetMethodID (class_ref, "vSetPageGap", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vSetPageGap_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vSetPageGap", "(I)V"), new JValue (p0));
		}

		static Delegate cb_vSetPos_Lcom_radaee_view_PDFView_PDFPos_II;
#pragma warning disable 0169
		static Delegate GetVSetPos_Lcom_radaee_view_PDFView_PDFPos_IIHandler ()
		{
			if (cb_vSetPos_Lcom_radaee_view_PDFView_PDFPos_II == null)
				cb_vSetPos_Lcom_radaee_view_PDFView_PDFPos_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_VSetPos_Lcom_radaee_view_PDFView_PDFPos_II);
			return cb_vSetPos_Lcom_radaee_view_PDFView_PDFPos_II;
		}

		static void n_VSetPos_Lcom_radaee_view_PDFView_PDFPos_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.View.PDFView.PDFPos p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView.PDFPos> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VSetPos (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_vSetPos_Lcom_radaee_view_PDFView_PDFPos_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vSetPos' and count(parameter)=3 and parameter[1][@type='com.radaee.view.PDFView.PDFPos'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("vSetPos", "(Lcom/radaee/view/PDFView$PDFPos;II)V", "GetVSetPos_Lcom_radaee_view_PDFView_PDFPos_IIHandler")]
		public virtual void VSetPos (global::Com.Radaee.View.PDFView.PDFPos p0, int p1, int p2)
		{
			if (id_vSetPos_Lcom_radaee_view_PDFView_PDFPos_II == IntPtr.Zero)
				id_vSetPos_Lcom_radaee_view_PDFView_PDFPos_II = JNIEnv.GetMethodID (class_ref, "vSetPos", "(Lcom/radaee/view/PDFView$PDFPos;II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vSetPos_Lcom_radaee_view_PDFView_PDFPos_II, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vSetPos", "(Lcom/radaee/view/PDFView$PDFPos;II)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_vSetScale_FFF;
#pragma warning disable 0169
		static Delegate GetVSetScale_FFFHandler ()
		{
			if (cb_vSetScale_FFF == null)
				cb_vSetScale_FFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float>) n_VSetScale_FFF);
			return cb_vSetScale_FFF;
		}

		static void n_VSetScale_FFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VSetScale (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_vSetScale_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vSetScale' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("vSetScale", "(FFF)V", "GetVSetScale_FFFHandler")]
		public virtual void VSetScale (float p0, float p1, float p2)
		{
			if (id_vSetScale_FFF == IntPtr.Zero)
				id_vSetScale_FFF = JNIEnv.GetMethodID (class_ref, "vSetScale", "(FFF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vSetScale_FFF, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vSetScale", "(FFF)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_vSetSel_FFFF;
#pragma warning disable 0169
		static Delegate GetVSetSel_FFFFHandler ()
		{
			if (cb_vSetSel_FFFF == null)
				cb_vSetSel_FFFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, float>) n_VSetSel_FFFF);
			return cb_vSetSel_FFFF;
		}

		static void n_VSetSel_FFFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2, float p3)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VSetSel (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_vSetSel_FFFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vSetSel' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("vSetSel", "(FFFF)V", "GetVSetSel_FFFFHandler")]
		public virtual void VSetSel (float p0, float p1, float p2, float p3)
		{
			if (id_vSetSel_FFFF == IntPtr.Zero)
				id_vSetSel_FFFF = JNIEnv.GetMethodID (class_ref, "vSetSel", "(FFFF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vSetSel_FFFF, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vSetSel", "(FFFF)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static Delegate cb_vSetSelMarkup_I;
#pragma warning disable 0169
		static Delegate GetVSetSelMarkup_IHandler ()
		{
			if (cb_vSetSelMarkup_I == null)
				cb_vSetSelMarkup_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_VSetSelMarkup_I);
			return cb_vSetSelMarkup_I;
		}

		static bool n_VSetSelMarkup_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VSetSelMarkup (p0);
		}
#pragma warning restore 0169

		static IntPtr id_vSetSelMarkup_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vSetSelMarkup' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("vSetSelMarkup", "(I)Z", "GetVSetSelMarkup_IHandler")]
		public virtual bool VSetSelMarkup (int p0)
		{
			if (id_vSetSelMarkup_I == IntPtr.Zero)
				id_vSetSelMarkup_I = JNIEnv.GetMethodID (class_ref, "vSetSelMarkup", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_vSetSelMarkup_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vSetSelMarkup", "(I)Z"), new JValue (p0));
		}

		static Delegate cb_vSetSelStatus_Z;
#pragma warning disable 0169
		static Delegate GetVSetSelStatus_ZHandler ()
		{
			if (cb_vSetSelStatus_Z == null)
				cb_vSetSelStatus_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_VSetSelStatus_Z);
			return cb_vSetSelStatus_Z;
		}

		static void n_VSetSelStatus_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VSetSelStatus (p0);
		}
#pragma warning restore 0169

		static IntPtr id_vSetSelStatus_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vSetSelStatus' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("vSetSelStatus", "(Z)V", "GetVSetSelStatus_ZHandler")]
		public virtual void VSetSelStatus (bool p0)
		{
			if (id_vSetSelStatus_Z == IntPtr.Zero)
				id_vSetSelStatus_Z = JNIEnv.GetMethodID (class_ref, "vSetSelStatus", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vSetSelStatus_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vSetSelStatus", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_vSingleTap_FF;
#pragma warning disable 0169
		static Delegate GetVSingleTap_FFHandler ()
		{
			if (cb_vSingleTap_FF == null)
				cb_vSingleTap_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_VSingleTap_FF);
			return cb_vSingleTap_FF;
		}

		static void n_VSingleTap_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VSingleTap (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_vSingleTap_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vSingleTap' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("vSingleTap", "(FF)V", "GetVSingleTap_FFHandler")]
		protected virtual void VSingleTap (float p0, float p1)
		{
			if (id_vSingleTap_FF == IntPtr.Zero)
				id_vSingleTap_FF = JNIEnv.GetMethodID (class_ref, "vSingleTap", "(FF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vSingleTap_FF, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vSingleTap", "(FF)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_vTouchEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetVTouchEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_vTouchEvent_Landroid_view_MotionEvent_ == null)
				cb_vTouchEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_VTouchEvent_Landroid_view_MotionEvent_);
			return cb_vTouchEvent_Landroid_view_MotionEvent_;
		}

		static bool n_VTouchEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.View.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.VTouchEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_vTouchEvent_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFView']/method[@name='vTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("vTouchEvent", "(Landroid/view/MotionEvent;)Z", "GetVTouchEvent_Landroid_view_MotionEvent_Handler")]
		public virtual bool VTouchEvent (global::Android.Views.MotionEvent p0)
		{
			if (id_vTouchEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_vTouchEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "vTouchEvent", "(Landroid/view/MotionEvent;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_vTouchEvent_Landroid_view_MotionEvent_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vTouchEvent", "(Landroid/view/MotionEvent;)Z"), new JValue (p0));
			return __ret;
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Radaee.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']"
	[global::Android.Runtime.Register ("com/radaee/view/PDFVPage", DoNotGenerateAcw=true)]
	public partial class PDFVPage : global::Java.Lang.Object {


		static IntPtr m_bmp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/field[@name='m_bmp']"
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

		static IntPtr m_cache_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/field[@name='m_cache']"
		[Register ("m_cache")]
		protected global::Com.Radaee.View.PDFVCache MCache {
			get {
				if (m_cache_jfieldId == IntPtr.Zero)
					m_cache_jfieldId = JNIEnv.GetFieldID (class_ref, "m_cache", "Lcom/radaee/view/PDFVCache;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, m_cache_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVCache> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_cache_jfieldId == IntPtr.Zero)
					m_cache_jfieldId = JNIEnv.GetFieldID (class_ref, "m_cache", "Lcom/radaee/view/PDFVCache;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, m_cache_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr m_doc_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/field[@name='m_doc']"
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

		static IntPtr m_h_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/field[@name='m_h']"
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

		static IntPtr m_pageno_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/field[@name='m_pageno']"
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

		static IntPtr m_scale_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/field[@name='m_scale']"
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

		static IntPtr m_sel_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/field[@name='m_sel']"
		[Register ("m_sel")]
		protected global::Com.Radaee.View.PDFVSel MSel {
			get {
				if (m_sel_jfieldId == IntPtr.Zero)
					m_sel_jfieldId = JNIEnv.GetFieldID (class_ref, "m_sel", "Lcom/radaee/view/PDFVSel;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, m_sel_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVSel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_sel_jfieldId == IntPtr.Zero)
					m_sel_jfieldId = JNIEnv.GetFieldID (class_ref, "m_sel", "Lcom/radaee/view/PDFVSel;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, m_sel_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr m_w_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/field[@name='m_w']"
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

		static IntPtr m_x_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/field[@name='m_x']"
		[Register ("m_x")]
		protected int MX {
			get {
				if (m_x_jfieldId == IntPtr.Zero)
					m_x_jfieldId = JNIEnv.GetFieldID (class_ref, "m_x", "I");
				return JNIEnv.GetIntField (Handle, m_x_jfieldId);
			}
			set {
				if (m_x_jfieldId == IntPtr.Zero)
					m_x_jfieldId = JNIEnv.GetFieldID (class_ref, "m_x", "I");
				JNIEnv.SetField (Handle, m_x_jfieldId, value);
			}
		}

		static IntPtr m_y_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/field[@name='m_y']"
		[Register ("m_y")]
		protected int MY {
			get {
				if (m_y_jfieldId == IntPtr.Zero)
					m_y_jfieldId = JNIEnv.GetFieldID (class_ref, "m_y", "I");
				return JNIEnv.GetIntField (Handle, m_y_jfieldId);
			}
			set {
				if (m_y_jfieldId == IntPtr.Zero)
					m_y_jfieldId = JNIEnv.GetFieldID (class_ref, "m_y", "I");
				JNIEnv.SetField (Handle, m_y_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/radaee/view/PDFVPage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PDFVPage); }
		}

		protected PDFVPage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_radaee_pdf_Document_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/constructor[@name='PDFVPage' and count(parameter)=2 and parameter[1][@type='com.radaee.pdf.Document'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lcom/radaee/pdf/Document;I)V", "")]
		protected PDFVPage (global::Com.Radaee.Pdf.Document p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PDFVPage)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/radaee/pdf/Document;I)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/radaee/pdf/Document;I)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lcom_radaee_pdf_Document_I == IntPtr.Zero)
				id_ctor_Lcom_radaee_pdf_Document_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/radaee/pdf/Document;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_radaee_pdf_Document_I, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_radaee_pdf_Document_I, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_GetHeight;
		public int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='GetHeight' and count(parameter)=0]"
			[Register ("GetHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_GetHeight == IntPtr.Zero)
					id_GetHeight = JNIEnv.GetMethodID (class_ref, "GetHeight", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_GetHeight);
			}
		}

		static IntPtr id_IsFinished;
		public bool IsFinished {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='IsFinished' and count(parameter)=0]"
			[Register ("IsFinished", "()Z", "GetIsFinishedHandler")]
			get {
				if (id_IsFinished == IntPtr.Zero)
					id_IsFinished = JNIEnv.GetMethodID (class_ref, "IsFinished", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_IsFinished);
			}
		}

		static IntPtr id_GetPage;
		public global::Com.Radaee.Pdf.Page Page {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='GetPage' and count(parameter)=0]"
			[Register ("GetPage", "()Lcom/radaee/pdf/Page;", "GetGetPageHandler")]
			get {
				if (id_GetPage == IntPtr.Zero)
					id_GetPage = JNIEnv.GetMethodID (class_ref, "GetPage", "()Lcom/radaee/pdf/Page;");
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (JNIEnv.CallObjectMethod  (Handle, id_GetPage), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_GetPageNo;
		public int PageNo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='GetPageNo' and count(parameter)=0]"
			[Register ("GetPageNo", "()I", "GetGetPageNoHandler")]
			get {
				if (id_GetPageNo == IntPtr.Zero)
					id_GetPageNo = JNIEnv.GetMethodID (class_ref, "GetPageNo", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_GetPageNo);
			}
		}

		static IntPtr id_GetScale;
		public float Scale {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='GetScale' and count(parameter)=0]"
			[Register ("GetScale", "()F", "GetGetScaleHandler")]
			get {
				if (id_GetScale == IntPtr.Zero)
					id_GetScale = JNIEnv.GetMethodID (class_ref, "GetScale", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_GetScale);
			}
		}

		static IntPtr id_GetSel;
		protected string Sel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='GetSel' and count(parameter)=0]"
			[Register ("GetSel", "()Ljava/lang/String;", "GetGetSelHandler")]
			get {
				if (id_GetSel == IntPtr.Zero)
					id_GetSel = JNIEnv.GetMethodID (class_ref, "GetSel", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetSel), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_GetWidth;
		public int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='GetWidth' and count(parameter)=0]"
			[Register ("GetWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_GetWidth == IntPtr.Zero)
					id_GetWidth = JNIEnv.GetMethodID (class_ref, "GetWidth", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_GetWidth);
			}
		}

		static Delegate cb_CancelRender;
#pragma warning disable 0169
		static Delegate GetCancelRenderHandler ()
		{
			if (cb_CancelRender == null)
				cb_CancelRender = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CancelRender);
			return cb_CancelRender;
		}

		static IntPtr n_CancelRender (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFVPage __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CancelRender ());
		}
#pragma warning restore 0169

		static IntPtr id_CancelRender;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='CancelRender' and count(parameter)=0]"
		[Register ("CancelRender", "()Lcom/radaee/view/PDFVCache;", "GetCancelRenderHandler")]
		protected virtual global::Com.Radaee.View.PDFVCache CancelRender ()
		{
			if (id_CancelRender == IntPtr.Zero)
				id_CancelRender = JNIEnv.GetMethodID (class_ref, "CancelRender", "()Lcom/radaee/view/PDFVCache;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVCache> (JNIEnv.CallObjectMethod  (Handle, id_CancelRender), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVCache> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "CancelRender", "()Lcom/radaee/view/PDFVCache;")), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ClearSel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='ClearSel' and count(parameter)=0]"
		[Register ("ClearSel", "()V", "")]
		protected void ClearSel ()
		{
			if (id_ClearSel == IntPtr.Zero)
				id_ClearSel = JNIEnv.GetMethodID (class_ref, "ClearSel", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_ClearSel);
		}

		static Delegate cb_CreateBmp;
#pragma warning disable 0169
		static Delegate GetCreateBmpHandler ()
		{
			if (cb_CreateBmp == null)
				cb_CreateBmp = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CreateBmp);
			return cb_CreateBmp;
		}

		static void n_CreateBmp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFVPage __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CreateBmp ();
		}
#pragma warning restore 0169

		static IntPtr id_CreateBmp;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='CreateBmp' and count(parameter)=0]"
		[Register ("CreateBmp", "()V", "GetCreateBmpHandler")]
		protected virtual void CreateBmp ()
		{
			if (id_CreateBmp == IntPtr.Zero)
				id_CreateBmp = JNIEnv.GetMethodID (class_ref, "CreateBmp", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_CreateBmp);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "CreateBmp", "()V"));
		}

		static IntPtr id_CreateInvertMatrix_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='CreateInvertMatrix' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("CreateInvertMatrix", "(FF)Lcom/radaee/pdf/Matrix;", "")]
		public global::Com.Radaee.Pdf.Matrix CreateInvertMatrix (float p0, float p1)
		{
			if (id_CreateInvertMatrix_FF == IntPtr.Zero)
				id_CreateInvertMatrix_FF = JNIEnv.GetMethodID (class_ref, "CreateInvertMatrix", "(FF)Lcom/radaee/pdf/Matrix;");
			return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Matrix> (JNIEnv.CallObjectMethod  (Handle, id_CreateInvertMatrix_FF, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_CreateMatrix;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='CreateMatrix' and count(parameter)=0]"
		[Register ("CreateMatrix", "()Lcom/radaee/pdf/Matrix;", "")]
		public global::Com.Radaee.Pdf.Matrix CreateMatrix ()
		{
			if (id_CreateMatrix == IntPtr.Zero)
				id_CreateMatrix = JNIEnv.GetMethodID (class_ref, "CreateMatrix", "()Lcom/radaee/pdf/Matrix;");
			return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Matrix> (JNIEnv.CallObjectMethod  (Handle, id_CreateMatrix), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_DeleteBmp;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='DeleteBmp' and count(parameter)=0]"
		[Register ("DeleteBmp", "()V", "")]
		protected void DeleteBmp ()
		{
			if (id_DeleteBmp == IntPtr.Zero)
				id_DeleteBmp = JNIEnv.GetMethodID (class_ref, "DeleteBmp", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_DeleteBmp);
		}

		static Delegate cb_Draw_Landroid_graphics_Canvas_II;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_IIHandler ()
		{
			if (cb_Draw_Landroid_graphics_Canvas_II == null)
				cb_Draw_Landroid_graphics_Canvas_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_Draw_Landroid_graphics_Canvas_II);
			return cb_Draw_Landroid_graphics_Canvas_II;
		}

		static void n_Draw_Landroid_graphics_Canvas_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Radaee.View.PDFVPage __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_Draw_Landroid_graphics_Canvas_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='Draw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("Draw", "(Landroid/graphics/Canvas;II)V", "GetDraw_Landroid_graphics_Canvas_IIHandler")]
		protected virtual void Draw (global::Android.Graphics.Canvas p0, int p1, int p2)
		{
			if (id_Draw_Landroid_graphics_Canvas_II == IntPtr.Zero)
				id_Draw_Landroid_graphics_Canvas_II = JNIEnv.GetMethodID (class_ref, "Draw", "(Landroid/graphics/Canvas;II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_Draw_Landroid_graphics_Canvas_II, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Draw", "(Landroid/graphics/Canvas;II)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_Draw_Lcom_radaee_pdf_BMP_II;
#pragma warning disable 0169
		static Delegate GetDraw_Lcom_radaee_pdf_BMP_IIHandler ()
		{
			if (cb_Draw_Lcom_radaee_pdf_BMP_II == null)
				cb_Draw_Lcom_radaee_pdf_BMP_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_Draw_Lcom_radaee_pdf_BMP_II);
			return cb_Draw_Lcom_radaee_pdf_BMP_II;
		}

		static void n_Draw_Lcom_radaee_pdf_BMP_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Radaee.View.PDFVPage __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.BMP p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.BMP> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_Draw_Lcom_radaee_pdf_BMP_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='Draw' and count(parameter)=3 and parameter[1][@type='com.radaee.pdf.BMP'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("Draw", "(Lcom/radaee/pdf/BMP;II)V", "GetDraw_Lcom_radaee_pdf_BMP_IIHandler")]
		protected virtual void Draw (global::Com.Radaee.Pdf.BMP p0, int p1, int p2)
		{
			if (id_Draw_Lcom_radaee_pdf_BMP_II == IntPtr.Zero)
				id_Draw_Lcom_radaee_pdf_BMP_II = JNIEnv.GetMethodID (class_ref, "Draw", "(Lcom/radaee/pdf/BMP;II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_Draw_Lcom_radaee_pdf_BMP_II, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Draw", "(Lcom/radaee/pdf/BMP;II)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_DrawDIB_Lcom_radaee_pdf_DIB_II;
#pragma warning disable 0169
		static Delegate GetDrawDIB_Lcom_radaee_pdf_DIB_IIHandler ()
		{
			if (cb_DrawDIB_Lcom_radaee_pdf_DIB_II == null)
				cb_DrawDIB_Lcom_radaee_pdf_DIB_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_DrawDIB_Lcom_radaee_pdf_DIB_II);
			return cb_DrawDIB_Lcom_radaee_pdf_DIB_II;
		}

		static void n_DrawDIB_Lcom_radaee_pdf_DIB_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Radaee.View.PDFVPage __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.DIB p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.DIB> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DrawDIB (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_DrawDIB_Lcom_radaee_pdf_DIB_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='DrawDIB' and count(parameter)=3 and parameter[1][@type='com.radaee.pdf.DIB'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("DrawDIB", "(Lcom/radaee/pdf/DIB;II)V", "GetDrawDIB_Lcom_radaee_pdf_DIB_IIHandler")]
		protected virtual void DrawDIB (global::Com.Radaee.Pdf.DIB p0, int p1, int p2)
		{
			if (id_DrawDIB_Lcom_radaee_pdf_DIB_II == IntPtr.Zero)
				id_DrawDIB_Lcom_radaee_pdf_DIB_II = JNIEnv.GetMethodID (class_ref, "DrawDIB", "(Lcom/radaee/pdf/DIB;II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_DrawDIB_Lcom_radaee_pdf_DIB_II, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "DrawDIB", "(Lcom/radaee/pdf/DIB;II)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_GetSelRect1_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='GetSelRect1' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("GetSelRect1", "(II)[I", "")]
		protected int[] GetSelRect1 (int p0, int p1)
		{
			if (id_GetSelRect1_II == IntPtr.Zero)
				id_GetSelRect1_II = JNIEnv.GetMethodID (class_ref, "GetSelRect1", "(II)[I");
			return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_GetSelRect1_II, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (int));
		}

		static IntPtr id_GetSelRect2_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='GetSelRect2' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("GetSelRect2", "(II)[I", "")]
		protected int[] GetSelRect2 (int p0, int p1)
		{
			if (id_GetSelRect2_II == IntPtr.Zero)
				id_GetSelRect2_II = JNIEnv.GetMethodID (class_ref, "GetSelRect2", "(II)[I");
			return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_GetSelRect2_II, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (int));
		}

		static IntPtr id_GetVX_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='GetVX' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("GetVX", "(F)I", "")]
		public int GetVX (float p0)
		{
			if (id_GetVX_F == IntPtr.Zero)
				id_GetVX_F = JNIEnv.GetMethodID (class_ref, "GetVX", "(F)I");
			return JNIEnv.CallIntMethod  (Handle, id_GetVX_F, new JValue (p0));
		}

		static IntPtr id_GetVY_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='GetVY' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("GetVY", "(F)I", "")]
		public int GetVY (float p0)
		{
			if (id_GetVY_F == IntPtr.Zero)
				id_GetVY_F = JNIEnv.GetMethodID (class_ref, "GetVY", "(F)I");
			return JNIEnv.CallIntMethod  (Handle, id_GetVY_F, new JValue (p0));
		}

		static IntPtr id_GetX;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='GetX' and count(parameter)=0]"
		[Register ("GetX", "()I", "")]
		public int GetX ()
		{
			if (id_GetX == IntPtr.Zero)
				id_GetX = JNIEnv.GetMethodID (class_ref, "GetX", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_GetX);
		}

		static IntPtr id_GetY;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='GetY' and count(parameter)=0]"
		[Register ("GetY", "()I", "")]
		public int GetY ()
		{
			if (id_GetY == IntPtr.Zero)
				id_GetY = JNIEnv.GetMethodID (class_ref, "GetY", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_GetY);
		}

		static Delegate cb_NeedBmp;
#pragma warning disable 0169
		static Delegate GetNeedBmpHandler ()
		{
			if (cb_NeedBmp == null)
				cb_NeedBmp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_NeedBmp);
			return cb_NeedBmp;
		}

		static bool n_NeedBmp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFVPage __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeedBmp ();
		}
#pragma warning restore 0169

		static IntPtr id_NeedBmp;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='NeedBmp' and count(parameter)=0]"
		[Register ("NeedBmp", "()Z", "GetNeedBmpHandler")]
		protected virtual bool NeedBmp ()
		{
			if (id_NeedBmp == IntPtr.Zero)
				id_NeedBmp = JNIEnv.GetMethodID (class_ref, "NeedBmp", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_NeedBmp);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "NeedBmp", "()Z"));
		}

		static Delegate cb_Reflow_IFZ;
#pragma warning disable 0169
		static Delegate GetReflow_IFZHandler ()
		{
			if (cb_Reflow_IFZ == null)
				cb_Reflow_IFZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, float, bool, IntPtr>) n_Reflow_IFZ);
			return cb_Reflow_IFZ;
		}

		static IntPtr n_Reflow_IFZ (IntPtr jnienv, IntPtr native__this, int p0, float p1, bool p2)
		{
			global::Com.Radaee.View.PDFVPage __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Reflow (p0, p1, p2));
		}
#pragma warning restore 0169

		static IntPtr id_Reflow_IFZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='Reflow' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='boolean']]"
		[Register ("Reflow", "(IFZ)Landroid/graphics/Bitmap;", "GetReflow_IFZHandler")]
		public virtual global::Android.Graphics.Bitmap Reflow (int p0, float p1, bool p2)
		{
			if (id_Reflow_IFZ == IntPtr.Zero)
				id_Reflow_IFZ = JNIEnv.GetMethodID (class_ref, "Reflow", "(IFZ)Landroid/graphics/Bitmap;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_Reflow_IFZ, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Reflow", "(IFZ)Landroid/graphics/Bitmap;"), new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_RenderPrepare;
#pragma warning disable 0169
		static Delegate GetRenderPrepareHandler ()
		{
			if (cb_RenderPrepare == null)
				cb_RenderPrepare = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_RenderPrepare);
			return cb_RenderPrepare;
		}

		static int n_RenderPrepare (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFVPage __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RenderPrepare ();
		}
#pragma warning restore 0169

		static IntPtr id_RenderPrepare;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='RenderPrepare' and count(parameter)=0]"
		[Register ("RenderPrepare", "()I", "GetRenderPrepareHandler")]
		protected virtual int RenderPrepare ()
		{
			if (id_RenderPrepare == IntPtr.Zero)
				id_RenderPrepare = JNIEnv.GetMethodID (class_ref, "RenderPrepare", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_RenderPrepare);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RenderPrepare", "()I"));
		}

		static Delegate cb_SetRect_IIF;
#pragma warning disable 0169
		static Delegate GetSetRect_IIFHandler ()
		{
			if (cb_SetRect_IIF == null)
				cb_SetRect_IIF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float, bool>) n_SetRect_IIF);
			return cb_SetRect_IIF;
		}

		static bool n_SetRect_IIF (IntPtr jnienv, IntPtr native__this, int p0, int p1, float p2)
		{
			global::Com.Radaee.View.PDFVPage __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetRect (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_SetRect_IIF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='SetRect' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='float']]"
		[Register ("SetRect", "(IIF)Z", "GetSetRect_IIFHandler")]
		protected virtual bool SetRect (int p0, int p1, float p2)
		{
			if (id_SetRect_IIF == IntPtr.Zero)
				id_SetRect_IIF = JNIEnv.GetMethodID (class_ref, "SetRect", "(IIF)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_SetRect_IIF, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetRect", "(IIF)Z"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_SetSel_FFFFII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='SetSel' and count(parameter)=6 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("SetSel", "(FFFFII)V", "")]
		protected void SetSel (float p0, float p1, float p2, float p3, int p4, int p5)
		{
			if (id_SetSel_FFFFII == IntPtr.Zero)
				id_SetSel_FFFFII = JNIEnv.GetMethodID (class_ref, "SetSel", "(FFFFII)V");
			JNIEnv.CallVoidMethod  (Handle, id_SetSel_FFFFII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
		}

		static IntPtr id_SetSelMarkup_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='SetSelMarkup' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("SetSelMarkup", "(I)Z", "")]
		protected bool SetSelMarkup (int p0)
		{
			if (id_SetSelMarkup_I == IntPtr.Zero)
				id_SetSelMarkup_I = JNIEnv.GetMethodID (class_ref, "SetSelMarkup", "(I)Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_SetSelMarkup_I, new JValue (p0));
		}

		static IntPtr id_ToDIBX_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='ToDIBX' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("ToDIBX", "(F)F", "")]
		public float ToDIBX (float p0)
		{
			if (id_ToDIBX_F == IntPtr.Zero)
				id_ToDIBX_F = JNIEnv.GetMethodID (class_ref, "ToDIBX", "(F)F");
			return JNIEnv.CallFloatMethod  (Handle, id_ToDIBX_F, new JValue (p0));
		}

		static IntPtr id_ToDIBY_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='ToDIBY' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("ToDIBY", "(F)F", "")]
		public float ToDIBY (float p0)
		{
			if (id_ToDIBY_F == IntPtr.Zero)
				id_ToDIBY_F = JNIEnv.GetMethodID (class_ref, "ToDIBY", "(F)F");
			return JNIEnv.CallFloatMethod  (Handle, id_ToDIBY_F, new JValue (p0));
		}

		static IntPtr id_ToPDFSize_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='ToPDFSize' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("ToPDFSize", "(F)F", "")]
		public float ToPDFSize (float p0)
		{
			if (id_ToPDFSize_F == IntPtr.Zero)
				id_ToPDFSize_F = JNIEnv.GetMethodID (class_ref, "ToPDFSize", "(F)F");
			return JNIEnv.CallFloatMethod  (Handle, id_ToPDFSize_F, new JValue (p0));
		}

		static IntPtr id_ToPDFX_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='ToPDFX' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("ToPDFX", "(FF)F", "")]
		public float ToPDFX (float p0, float p1)
		{
			if (id_ToPDFX_FF == IntPtr.Zero)
				id_ToPDFX_FF = JNIEnv.GetMethodID (class_ref, "ToPDFX", "(FF)F");
			return JNIEnv.CallFloatMethod  (Handle, id_ToPDFX_FF, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ToPDFY_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVPage']/method[@name='ToPDFY' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("ToPDFY", "(FF)F", "")]
		public float ToPDFY (float p0, float p1)
		{
			if (id_ToPDFY_FF == IntPtr.Zero)
				id_ToPDFY_FF = JNIEnv.GetMethodID (class_ref, "ToPDFY", "(FF)F");
			return JNIEnv.CallFloatMethod  (Handle, id_ToPDFY_FF, new JValue (p0), new JValue (p1));
		}

	}
}

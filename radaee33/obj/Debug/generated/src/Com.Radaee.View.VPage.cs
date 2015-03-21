using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Radaee.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']"
	[global::Android.Runtime.Register ("com/radaee/view/VPage", DoNotGenerateAcw=true)]
	public partial class VPage : global::Java.Lang.Object {


		static IntPtr CLIP_H_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/field[@name='CLIP_H']"
		[Register ("CLIP_H")]
		protected static int ClipH {
			get {
				if (CLIP_H_jfieldId == IntPtr.Zero)
					CLIP_H_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIP_H", "I");
				return JNIEnv.GetStaticIntField (class_ref, CLIP_H_jfieldId);
			}
			set {
				if (CLIP_H_jfieldId == IntPtr.Zero)
					CLIP_H_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIP_H", "I");
				JNIEnv.SetStaticField (class_ref, CLIP_H_jfieldId, value);
			}
		}

		static IntPtr CLIP_W_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/field[@name='CLIP_W']"
		[Register ("CLIP_W")]
		protected static int ClipW {
			get {
				if (CLIP_W_jfieldId == IntPtr.Zero)
					CLIP_W_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIP_W", "I");
				return JNIEnv.GetStaticIntField (class_ref, CLIP_W_jfieldId);
			}
			set {
				if (CLIP_W_jfieldId == IntPtr.Zero)
					CLIP_W_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIP_W", "I");
				JNIEnv.SetStaticField (class_ref, CLIP_W_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/radaee/view/VPage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VPage); }
		}

		protected VPage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_radaee_pdf_Document_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/constructor[@name='VPage' and count(parameter)=2 and parameter[1][@type='com.radaee.pdf.Document'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lcom/radaee/pdf/Document;I)V", "")]
		protected VPage (global::Com.Radaee.Pdf.Document p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (VPage)) {
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
		protected int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='GetHeight' and count(parameter)=0]"
			[Register ("GetHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_GetHeight == IntPtr.Zero)
					id_GetHeight = JNIEnv.GetMethodID (class_ref, "GetHeight", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_GetHeight);
			}
		}

		static IntPtr id_GetPageNo;
		public int PageNo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='GetPageNo' and count(parameter)=0]"
			[Register ("GetPageNo", "()I", "GetGetPageNoHandler")]
			get {
				if (id_GetPageNo == IntPtr.Zero)
					id_GetPageNo = JNIEnv.GetMethodID (class_ref, "GetPageNo", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_GetPageNo);
			}
		}

		static IntPtr id_GetWidth;
		protected int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='GetWidth' and count(parameter)=0]"
			[Register ("GetWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_GetWidth == IntPtr.Zero)
					id_GetWidth = JNIEnv.GetMethodID (class_ref, "GetWidth", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_GetWidth);
			}
		}

		static IntPtr id_CreateInvertMatrix_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='CreateInvertMatrix' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("CreateInvertMatrix", "(FF)Lcom/radaee/pdf/Matrix;", "")]
		public global::Com.Radaee.Pdf.Matrix CreateInvertMatrix (float p0, float p1)
		{
			if (id_CreateInvertMatrix_FF == IntPtr.Zero)
				id_CreateInvertMatrix_FF = JNIEnv.GetMethodID (class_ref, "CreateInvertMatrix", "(FF)Lcom/radaee/pdf/Matrix;");
			return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Matrix> (JNIEnv.CallObjectMethod  (Handle, id_CreateInvertMatrix_FF, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_GetPDFX_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='GetPDFX' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("GetPDFX", "(I)F", "")]
		protected float GetPDFX (int p0)
		{
			if (id_GetPDFX_I == IntPtr.Zero)
				id_GetPDFX_I = JNIEnv.GetMethodID (class_ref, "GetPDFX", "(I)F");
			return JNIEnv.CallFloatMethod  (Handle, id_GetPDFX_I, new JValue (p0));
		}

		static IntPtr id_GetPDFY_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='GetPDFY' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("GetPDFY", "(I)F", "")]
		protected float GetPDFY (int p0)
		{
			if (id_GetPDFY_I == IntPtr.Zero)
				id_GetPDFY_I = JNIEnv.GetMethodID (class_ref, "GetPDFY", "(I)F");
			return JNIEnv.CallFloatMethod  (Handle, id_GetPDFY_I, new JValue (p0));
		}

		static IntPtr id_GetVX_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='GetVX' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("GetVX", "(F)I", "")]
		public int GetVX (float p0)
		{
			if (id_GetVX_F == IntPtr.Zero)
				id_GetVX_F = JNIEnv.GetMethodID (class_ref, "GetVX", "(F)I");
			return JNIEnv.CallIntMethod  (Handle, id_GetVX_F, new JValue (p0));
		}

		static IntPtr id_GetVY_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='GetVY' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("GetVY", "(F)I", "")]
		public int GetVY (float p0)
		{
			if (id_GetVY_F == IntPtr.Zero)
				id_GetVY_F = JNIEnv.GetMethodID (class_ref, "GetVY", "(F)I");
			return JNIEnv.CallIntMethod  (Handle, id_GetVY_F, new JValue (p0));
		}

		static IntPtr id_GetX;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='GetX' and count(parameter)=0]"
		[Register ("GetX", "()I", "")]
		protected int GetX ()
		{
			if (id_GetX == IntPtr.Zero)
				id_GetX = JNIEnv.GetMethodID (class_ref, "GetX", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_GetX);
		}

		static IntPtr id_GetY;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='GetY' and count(parameter)=0]"
		[Register ("GetY", "()I", "")]
		protected int GetY ()
		{
			if (id_GetY == IntPtr.Zero)
				id_GetY = JNIEnv.GetMethodID (class_ref, "GetY", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_GetY);
		}

		static Delegate cb_LocHorz_II;
#pragma warning disable 0169
		static Delegate GetLocHorz_IIHandler ()
		{
			if (cb_LocHorz_II == null)
				cb_LocHorz_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_LocHorz_II);
			return cb_LocHorz_II;
		}

		static int n_LocHorz_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Radaee.View.VPage __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LocHorz (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_LocHorz_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='LocHorz' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("LocHorz", "(II)I", "GetLocHorz_IIHandler")]
		protected virtual int LocHorz (int p0, int p1)
		{
			if (id_LocHorz_II == IntPtr.Zero)
				id_LocHorz_II = JNIEnv.GetMethodID (class_ref, "LocHorz", "(II)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_LocHorz_II, new JValue (p0), new JValue (p1));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LocHorz", "(II)I"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_LocVert_II;
#pragma warning disable 0169
		static Delegate GetLocVert_IIHandler ()
		{
			if (cb_LocVert_II == null)
				cb_LocVert_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_LocVert_II);
			return cb_LocVert_II;
		}

		static int n_LocVert_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Radaee.View.VPage __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LocVert (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_LocVert_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='LocVert' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("LocVert", "(II)I", "GetLocVert_IIHandler")]
		protected virtual int LocVert (int p0, int p1)
		{
			if (id_LocVert_II == IntPtr.Zero)
				id_LocVert_II = JNIEnv.GetMethodID (class_ref, "LocVert", "(II)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_LocVert_II, new JValue (p0), new JValue (p1));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "LocVert", "(II)I"), new JValue (p0), new JValue (p1));
		}

		static IntPtr id_SetX_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='SetX' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("SetX", "(I)V", "")]
		protected void SetX (int p0)
		{
			if (id_SetX_I == IntPtr.Zero)
				id_SetX_I = JNIEnv.GetMethodID (class_ref, "SetX", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_SetX_I, new JValue (p0));
		}

		static IntPtr id_ToDIBX_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='ToDIBX' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("ToDIBX", "(F)F", "")]
		public float ToDIBX (float p0)
		{
			if (id_ToDIBX_F == IntPtr.Zero)
				id_ToDIBX_F = JNIEnv.GetMethodID (class_ref, "ToDIBX", "(F)F");
			return JNIEnv.CallFloatMethod  (Handle, id_ToDIBX_F, new JValue (p0));
		}

		static IntPtr id_ToDIBY_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='ToDIBY' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("ToDIBY", "(F)F", "")]
		public float ToDIBY (float p0)
		{
			if (id_ToDIBY_F == IntPtr.Zero)
				id_ToDIBY_F = JNIEnv.GetMethodID (class_ref, "ToDIBY", "(F)F");
			return JNIEnv.CallFloatMethod  (Handle, id_ToDIBY_F, new JValue (p0));
		}

		static IntPtr id_ToPDFSize_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='ToPDFSize' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("ToPDFSize", "(F)F", "")]
		public float ToPDFSize (float p0)
		{
			if (id_ToPDFSize_F == IntPtr.Zero)
				id_ToPDFSize_F = JNIEnv.GetMethodID (class_ref, "ToPDFSize", "(F)F");
			return JNIEnv.CallFloatMethod  (Handle, id_ToPDFSize_F, new JValue (p0));
		}

		static IntPtr id_ToPDFX_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='ToPDFX' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("ToPDFX", "(FF)F", "")]
		public float ToPDFX (float p0, float p1)
		{
			if (id_ToPDFX_FF == IntPtr.Zero)
				id_ToPDFX_FF = JNIEnv.GetMethodID (class_ref, "ToPDFX", "(FF)F");
			return JNIEnv.CallFloatMethod  (Handle, id_ToPDFX_FF, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ToPDFY_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='ToPDFY' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("ToPDFY", "(FF)F", "")]
		public float ToPDFY (float p0, float p1)
		{
			if (id_ToPDFY_FF == IntPtr.Zero)
				id_ToPDFY_FF = JNIEnv.GetMethodID (class_ref, "ToPDFY", "(FF)F");
			return JNIEnv.CallFloatMethod  (Handle, id_ToPDFY_FF, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_vDestroy_Lcom_radaee_view_VThread_;
#pragma warning disable 0169
		static Delegate GetVDestroy_Lcom_radaee_view_VThread_Handler ()
		{
			if (cb_vDestroy_Lcom_radaee_view_VThread_ == null)
				cb_vDestroy_Lcom_radaee_view_VThread_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_VDestroy_Lcom_radaee_view_VThread_);
			return cb_vDestroy_Lcom_radaee_view_VThread_;
		}

		static void n_VDestroy_Lcom_radaee_view_VThread_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.View.VPage __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.View.VThread p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VThread> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VDestroy (p0);
		}
#pragma warning restore 0169

		static IntPtr id_vDestroy_Lcom_radaee_view_VThread_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='vDestroy' and count(parameter)=1 and parameter[1][@type='com.radaee.view.VThread']]"
		[Register ("vDestroy", "(Lcom/radaee/view/VThread;)V", "GetVDestroy_Lcom_radaee_view_VThread_Handler")]
		protected virtual void VDestroy (global::Com.Radaee.View.VThread p0)
		{
			if (id_vDestroy_Lcom_radaee_view_VThread_ == IntPtr.Zero)
				id_vDestroy_Lcom_radaee_view_VThread_ = JNIEnv.GetMethodID (class_ref, "vDestroy", "(Lcom/radaee/view/VThread;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vDestroy_Lcom_radaee_view_VThread_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vDestroy", "(Lcom/radaee/view/VThread;)V"), new JValue (p0));
		}

		static Delegate cb_vDraw_Landroid_graphics_Canvas_II;
#pragma warning disable 0169
		static Delegate GetVDraw_Landroid_graphics_Canvas_IIHandler ()
		{
			if (cb_vDraw_Landroid_graphics_Canvas_II == null)
				cb_vDraw_Landroid_graphics_Canvas_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_VDraw_Landroid_graphics_Canvas_II);
			return cb_vDraw_Landroid_graphics_Canvas_II;
		}

		static void n_VDraw_Landroid_graphics_Canvas_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Radaee.View.VPage __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VDraw (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_vDraw_Landroid_graphics_Canvas_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='vDraw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("vDraw", "(Landroid/graphics/Canvas;II)V", "GetVDraw_Landroid_graphics_Canvas_IIHandler")]
		protected virtual void VDraw (global::Android.Graphics.Canvas p0, int p1, int p2)
		{
			if (id_vDraw_Landroid_graphics_Canvas_II == IntPtr.Zero)
				id_vDraw_Landroid_graphics_Canvas_II = JNIEnv.GetMethodID (class_ref, "vDraw", "(Landroid/graphics/Canvas;II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vDraw_Landroid_graphics_Canvas_II, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vDraw", "(Landroid/graphics/Canvas;II)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_vDraw_Lcom_radaee_view_VThread_Lcom_radaee_pdf_BMP_II;
#pragma warning disable 0169
		static Delegate GetVDraw_Lcom_radaee_view_VThread_Lcom_radaee_pdf_BMP_IIHandler ()
		{
			if (cb_vDraw_Lcom_radaee_view_VThread_Lcom_radaee_pdf_BMP_II == null)
				cb_vDraw_Lcom_radaee_view_VThread_Lcom_radaee_pdf_BMP_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_VDraw_Lcom_radaee_view_VThread_Lcom_radaee_pdf_BMP_II);
			return cb_vDraw_Lcom_radaee_view_VThread_Lcom_radaee_pdf_BMP_II;
		}

		static void n_VDraw_Lcom_radaee_view_VThread_Lcom_radaee_pdf_BMP_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			global::Com.Radaee.View.VPage __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.View.VThread p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VThread> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.BMP p1 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.BMP> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.VDraw (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_vDraw_Lcom_radaee_view_VThread_Lcom_radaee_pdf_BMP_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='vDraw' and count(parameter)=4 and parameter[1][@type='com.radaee.view.VThread'] and parameter[2][@type='com.radaee.pdf.BMP'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("vDraw", "(Lcom/radaee/view/VThread;Lcom/radaee/pdf/BMP;II)V", "GetVDraw_Lcom_radaee_view_VThread_Lcom_radaee_pdf_BMP_IIHandler")]
		protected virtual void VDraw (global::Com.Radaee.View.VThread p0, global::Com.Radaee.Pdf.BMP p1, int p2, int p3)
		{
			if (id_vDraw_Lcom_radaee_view_VThread_Lcom_radaee_pdf_BMP_II == IntPtr.Zero)
				id_vDraw_Lcom_radaee_view_VThread_Lcom_radaee_pdf_BMP_II = JNIEnv.GetMethodID (class_ref, "vDraw", "(Lcom/radaee/view/VThread;Lcom/radaee/pdf/BMP;II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vDraw_Lcom_radaee_view_VThread_Lcom_radaee_pdf_BMP_II, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vDraw", "(Lcom/radaee/view/VThread;Lcom/radaee/pdf/BMP;II)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static Delegate cb_vEndPage_Lcom_radaee_view_VThread_;
#pragma warning disable 0169
		static Delegate GetVEndPage_Lcom_radaee_view_VThread_Handler ()
		{
			if (cb_vEndPage_Lcom_radaee_view_VThread_ == null)
				cb_vEndPage_Lcom_radaee_view_VThread_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_VEndPage_Lcom_radaee_view_VThread_);
			return cb_vEndPage_Lcom_radaee_view_VThread_;
		}

		static void n_VEndPage_Lcom_radaee_view_VThread_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.View.VPage __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.View.VThread p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VThread> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VEndPage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_vEndPage_Lcom_radaee_view_VThread_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='vEndPage' and count(parameter)=1 and parameter[1][@type='com.radaee.view.VThread']]"
		[Register ("vEndPage", "(Lcom/radaee/view/VThread;)V", "GetVEndPage_Lcom_radaee_view_VThread_Handler")]
		protected virtual void VEndPage (global::Com.Radaee.View.VThread p0)
		{
			if (id_vEndPage_Lcom_radaee_view_VThread_ == IntPtr.Zero)
				id_vEndPage_Lcom_radaee_view_VThread_ = JNIEnv.GetMethodID (class_ref, "vEndPage", "(Lcom/radaee/view/VThread;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vEndPage_Lcom_radaee_view_VThread_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vEndPage", "(Lcom/radaee/view/VThread;)V"), new JValue (p0));
		}

		static Delegate cb_vFinished;
#pragma warning disable 0169
		static Delegate GetVFinishedHandler ()
		{
			if (cb_vFinished == null)
				cb_vFinished = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_VFinished);
			return cb_vFinished;
		}

		static bool n_VFinished (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.VPage __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VFinished ();
		}
#pragma warning restore 0169

		static IntPtr id_vFinished;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='vFinished' and count(parameter)=0]"
		[Register ("vFinished", "()Z", "GetVFinishedHandler")]
		protected virtual bool VFinished ()
		{
			if (id_vFinished == IntPtr.Zero)
				id_vFinished = JNIEnv.GetMethodID (class_ref, "vFinished", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_vFinished);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vFinished", "()Z"));
		}

		static Delegate cb_vLayout_Lcom_radaee_view_VThread_IIFZ;
#pragma warning disable 0169
		static Delegate GetVLayout_Lcom_radaee_view_VThread_IIFZHandler ()
		{
			if (cb_vLayout_Lcom_radaee_view_VThread_IIFZ == null)
				cb_vLayout_Lcom_radaee_view_VThread_IIFZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, float, bool>) n_VLayout_Lcom_radaee_view_VThread_IIFZ);
			return cb_vLayout_Lcom_radaee_view_VThread_IIFZ;
		}

		static void n_VLayout_Lcom_radaee_view_VThread_IIFZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, float p3, bool p4)
		{
			global::Com.Radaee.View.VPage __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.View.VThread p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VThread> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VLayout (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_vLayout_Lcom_radaee_view_VThread_IIFZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='vLayout' and count(parameter)=5 and parameter[1][@type='com.radaee.view.VThread'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='float'] and parameter[5][@type='boolean']]"
		[Register ("vLayout", "(Lcom/radaee/view/VThread;IIFZ)V", "GetVLayout_Lcom_radaee_view_VThread_IIFZHandler")]
		protected virtual void VLayout (global::Com.Radaee.View.VThread p0, int p1, int p2, float p3, bool p4)
		{
			if (id_vLayout_Lcom_radaee_view_VThread_IIFZ == IntPtr.Zero)
				id_vLayout_Lcom_radaee_view_VThread_IIFZ = JNIEnv.GetMethodID (class_ref, "vLayout", "(Lcom/radaee/view/VThread;IIFZ)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vLayout_Lcom_radaee_view_VThread_IIFZ, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vLayout", "(Lcom/radaee/view/VThread;IIFZ)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static Delegate cb_vRenderAsync_Lcom_radaee_view_VThread_IIII;
#pragma warning disable 0169
		static Delegate GetVRenderAsync_Lcom_radaee_view_VThread_IIIIHandler ()
		{
			if (cb_vRenderAsync_Lcom_radaee_view_VThread_IIII == null)
				cb_vRenderAsync_Lcom_radaee_view_VThread_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int>) n_VRenderAsync_Lcom_radaee_view_VThread_IIII);
			return cb_vRenderAsync_Lcom_radaee_view_VThread_IIII;
		}

		static void n_VRenderAsync_Lcom_radaee_view_VThread_IIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4)
		{
			global::Com.Radaee.View.VPage __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.View.VThread p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VThread> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VRenderAsync (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_vRenderAsync_Lcom_radaee_view_VThread_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='vRenderAsync' and count(parameter)=5 and parameter[1][@type='com.radaee.view.VThread'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("vRenderAsync", "(Lcom/radaee/view/VThread;IIII)V", "GetVRenderAsync_Lcom_radaee_view_VThread_IIIIHandler")]
		protected virtual void VRenderAsync (global::Com.Radaee.View.VThread p0, int p1, int p2, int p3, int p4)
		{
			if (id_vRenderAsync_Lcom_radaee_view_VThread_IIII == IntPtr.Zero)
				id_vRenderAsync_Lcom_radaee_view_VThread_IIII = JNIEnv.GetMethodID (class_ref, "vRenderAsync", "(Lcom/radaee/view/VThread;IIII)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vRenderAsync_Lcom_radaee_view_VThread_IIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vRenderAsync", "(Lcom/radaee/view/VThread;IIII)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static Delegate cb_vRenderSync_Lcom_radaee_view_VThread_IIII;
#pragma warning disable 0169
		static Delegate GetVRenderSync_Lcom_radaee_view_VThread_IIIIHandler ()
		{
			if (cb_vRenderSync_Lcom_radaee_view_VThread_IIII == null)
				cb_vRenderSync_Lcom_radaee_view_VThread_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int>) n_VRenderSync_Lcom_radaee_view_VThread_IIII);
			return cb_vRenderSync_Lcom_radaee_view_VThread_IIII;
		}

		static void n_VRenderSync_Lcom_radaee_view_VThread_IIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4)
		{
			global::Com.Radaee.View.VPage __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.View.VThread p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VThread> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VRenderSync (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_vRenderSync_Lcom_radaee_view_VThread_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='vRenderSync' and count(parameter)=5 and parameter[1][@type='com.radaee.view.VThread'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("vRenderSync", "(Lcom/radaee/view/VThread;IIII)V", "GetVRenderSync_Lcom_radaee_view_VThread_IIIIHandler")]
		protected virtual void VRenderSync (global::Com.Radaee.View.VThread p0, int p1, int p2, int p3, int p4)
		{
			if (id_vRenderSync_Lcom_radaee_view_VThread_IIII == IntPtr.Zero)
				id_vRenderSync_Lcom_radaee_view_VThread_IIII = JNIEnv.GetMethodID (class_ref, "vRenderSync", "(Lcom/radaee/view/VThread;IIII)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vRenderSync_Lcom_radaee_view_VThread_IIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vRenderSync", "(Lcom/radaee/view/VThread;IIII)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static Delegate cb_vZoomConfirmed_Lcom_radaee_view_VThread_IIII;
#pragma warning disable 0169
		static Delegate GetVZoomConfirmed_Lcom_radaee_view_VThread_IIIIHandler ()
		{
			if (cb_vZoomConfirmed_Lcom_radaee_view_VThread_IIII == null)
				cb_vZoomConfirmed_Lcom_radaee_view_VThread_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int>) n_VZoomConfirmed_Lcom_radaee_view_VThread_IIII);
			return cb_vZoomConfirmed_Lcom_radaee_view_VThread_IIII;
		}

		static void n_VZoomConfirmed_Lcom_radaee_view_VThread_IIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4)
		{
			global::Com.Radaee.View.VPage __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.View.VThread p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VThread> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VZoomConfirmed (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_vZoomConfirmed_Lcom_radaee_view_VThread_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='vZoomConfirmed' and count(parameter)=5 and parameter[1][@type='com.radaee.view.VThread'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("vZoomConfirmed", "(Lcom/radaee/view/VThread;IIII)V", "GetVZoomConfirmed_Lcom_radaee_view_VThread_IIIIHandler")]
		protected virtual void VZoomConfirmed (global::Com.Radaee.View.VThread p0, int p1, int p2, int p3, int p4)
		{
			if (id_vZoomConfirmed_Lcom_radaee_view_VThread_IIII == IntPtr.Zero)
				id_vZoomConfirmed_Lcom_radaee_view_VThread_IIII = JNIEnv.GetMethodID (class_ref, "vZoomConfirmed", "(Lcom/radaee/view/VThread;IIII)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vZoomConfirmed_Lcom_radaee_view_VThread_IIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vZoomConfirmed", "(Lcom/radaee/view/VThread;IIII)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static Delegate cb_vZoomEnd;
#pragma warning disable 0169
		static Delegate GetVZoomEndHandler ()
		{
			if (cb_vZoomEnd == null)
				cb_vZoomEnd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_VZoomEnd);
			return cb_vZoomEnd;
		}

		static void n_VZoomEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.VPage __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VZoomEnd ();
		}
#pragma warning restore 0169

		static IntPtr id_vZoomEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='vZoomEnd' and count(parameter)=0]"
		[Register ("vZoomEnd", "()V", "GetVZoomEndHandler")]
		protected virtual void VZoomEnd ()
		{
			if (id_vZoomEnd == IntPtr.Zero)
				id_vZoomEnd = JNIEnv.GetMethodID (class_ref, "vZoomEnd", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vZoomEnd);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vZoomEnd", "()V"));
		}

		static Delegate cb_vZoomStart;
#pragma warning disable 0169
		static Delegate GetVZoomStartHandler ()
		{
			if (cb_vZoomStart == null)
				cb_vZoomStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_VZoomStart);
			return cb_vZoomStart;
		}

		static void n_VZoomStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.VPage __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VZoomStart ();
		}
#pragma warning restore 0169

		static IntPtr id_vZoomStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VPage']/method[@name='vZoomStart' and count(parameter)=0]"
		[Register ("vZoomStart", "()V", "GetVZoomStartHandler")]
		protected virtual void VZoomStart ()
		{
			if (id_vZoomStart == IntPtr.Zero)
				id_vZoomStart = JNIEnv.GetMethodID (class_ref, "vZoomStart", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vZoomStart);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vZoomStart", "()V"));
		}

	}
}

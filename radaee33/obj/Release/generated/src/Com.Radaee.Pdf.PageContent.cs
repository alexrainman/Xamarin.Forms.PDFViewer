using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Radaee.Pdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']"
	[global::Android.Runtime.Register ("com/radaee/pdf/PageContent", DoNotGenerateAcw=true)]
	public partial class PageContent : global::Java.Lang.Object {


		static IntPtr hand_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/field[@name='hand']"
		[Register ("hand")]
		protected long Hand {
			get {
				if (hand_jfieldId == IntPtr.Zero)
					hand_jfieldId = JNIEnv.GetFieldID (class_ref, "hand", "J");
				return JNIEnv.GetLongField (Handle, hand_jfieldId);
			}
			set {
				if (hand_jfieldId == IntPtr.Zero)
					hand_jfieldId = JNIEnv.GetFieldID (class_ref, "hand", "J");
				JNIEnv.SetField (Handle, hand_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/radaee/pdf/PageContent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PageContent); }
		}

		protected PageContent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/constructor[@name='PageContent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public PageContent () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PageContent)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static Delegate cb_ClipPath_Lcom_radaee_pdf_Path_Z;
#pragma warning disable 0169
		static Delegate GetClipPath_Lcom_radaee_pdf_Path_ZHandler ()
		{
			if (cb_ClipPath_Lcom_radaee_pdf_Path_Z == null)
				cb_ClipPath_Lcom_radaee_pdf_Path_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_ClipPath_Lcom_radaee_pdf_Path_Z);
			return cb_ClipPath_Lcom_radaee_pdf_Path_Z;
		}

		static void n_ClipPath_Lcom_radaee_pdf_Path_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Path p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Path> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClipPath (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_ClipPath_Lcom_radaee_pdf_Path_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='ClipPath' and count(parameter)=2 and parameter[1][@type='com.radaee.pdf.Path'] and parameter[2][@type='boolean']]"
		[Register ("ClipPath", "(Lcom/radaee/pdf/Path;Z)V", "GetClipPath_Lcom_radaee_pdf_Path_ZHandler")]
		public virtual void ClipPath (global::Com.Radaee.Pdf.Path p0, bool p1)
		{
			if (id_ClipPath_Lcom_radaee_pdf_Path_Z == IntPtr.Zero)
				id_ClipPath_Lcom_radaee_pdf_Path_Z = JNIEnv.GetMethodID (class_ref, "ClipPath", "(Lcom/radaee/pdf/Path;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_ClipPath_Lcom_radaee_pdf_Path_Z, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ClipPath", "(Lcom/radaee/pdf/Path;Z)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_Create;
#pragma warning disable 0169
		static Delegate GetCreateHandler ()
		{
			if (cb_Create == null)
				cb_Create = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Create);
			return cb_Create;
		}

		static void n_Create (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Create ();
		}
#pragma warning restore 0169

		static IntPtr id_Create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='Create' and count(parameter)=0]"
		[Register ("Create", "()V", "GetCreateHandler")]
		public virtual void Create ()
		{
			if (id_Create == IntPtr.Zero)
				id_Create = JNIEnv.GetMethodID (class_ref, "Create", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_Create);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Create", "()V"));
		}

		static Delegate cb_Destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_Destroy == null)
				cb_Destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_Destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_Destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='Destroy' and count(parameter)=0]"
		[Register ("Destroy", "()V", "GetDestroyHandler")]
		public virtual void Destroy ()
		{
			if (id_Destroy == IntPtr.Zero)
				id_Destroy = JNIEnv.GetMethodID (class_ref, "Destroy", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_Destroy);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Destroy", "()V"));
		}

		static Delegate cb_DrawImage_Lcom_radaee_pdf_Page_ResImage_;
#pragma warning disable 0169
		static Delegate GetDrawImage_Lcom_radaee_pdf_Page_ResImage_Handler ()
		{
			if (cb_DrawImage_Lcom_radaee_pdf_Page_ResImage_ == null)
				cb_DrawImage_Lcom_radaee_pdf_Page_ResImage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DrawImage_Lcom_radaee_pdf_Page_ResImage_);
			return cb_DrawImage_Lcom_radaee_pdf_Page_ResImage_;
		}

		static void n_DrawImage_Lcom_radaee_pdf_Page_ResImage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Page.ResImage p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.ResImage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DrawImage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_DrawImage_Lcom_radaee_pdf_Page_ResImage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='DrawImage' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Page.ResImage']]"
		[Register ("DrawImage", "(Lcom/radaee/pdf/Page$ResImage;)V", "GetDrawImage_Lcom_radaee_pdf_Page_ResImage_Handler")]
		public virtual void DrawImage (global::Com.Radaee.Pdf.Page.ResImage p0)
		{
			if (id_DrawImage_Lcom_radaee_pdf_Page_ResImage_ == IntPtr.Zero)
				id_DrawImage_Lcom_radaee_pdf_Page_ResImage_ = JNIEnv.GetMethodID (class_ref, "DrawImage", "(Lcom/radaee/pdf/Page$ResImage;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_DrawImage_Lcom_radaee_pdf_Page_ResImage_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "DrawImage", "(Lcom/radaee/pdf/Page$ResImage;)V"), new JValue (p0));
		}

		static Delegate cb_DrawText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDrawText_Ljava_lang_String_Handler ()
		{
			if (cb_DrawText_Ljava_lang_String_ == null)
				cb_DrawText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DrawText_Ljava_lang_String_);
			return cb_DrawText_Ljava_lang_String_;
		}

		static void n_DrawText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DrawText (p0);
		}
#pragma warning restore 0169

		static IntPtr id_DrawText_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='DrawText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("DrawText", "(Ljava/lang/String;)V", "GetDrawText_Ljava_lang_String_Handler")]
		public virtual void DrawText (string p0)
		{
			if (id_DrawText_Ljava_lang_String_ == IntPtr.Zero)
				id_DrawText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "DrawText", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_DrawText_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "DrawText", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_FillPath_Lcom_radaee_pdf_Path_Z;
#pragma warning disable 0169
		static Delegate GetFillPath_Lcom_radaee_pdf_Path_ZHandler ()
		{
			if (cb_FillPath_Lcom_radaee_pdf_Path_Z == null)
				cb_FillPath_Lcom_radaee_pdf_Path_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_FillPath_Lcom_radaee_pdf_Path_Z);
			return cb_FillPath_Lcom_radaee_pdf_Path_Z;
		}

		static void n_FillPath_Lcom_radaee_pdf_Path_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Path p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Path> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FillPath (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_FillPath_Lcom_radaee_pdf_Path_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='FillPath' and count(parameter)=2 and parameter[1][@type='com.radaee.pdf.Path'] and parameter[2][@type='boolean']]"
		[Register ("FillPath", "(Lcom/radaee/pdf/Path;Z)V", "GetFillPath_Lcom_radaee_pdf_Path_ZHandler")]
		public virtual void FillPath (global::Com.Radaee.Pdf.Path p0, bool p1)
		{
			if (id_FillPath_Lcom_radaee_pdf_Path_Z == IntPtr.Zero)
				id_FillPath_Lcom_radaee_pdf_Path_Z = JNIEnv.GetMethodID (class_ref, "FillPath", "(Lcom/radaee/pdf/Path;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_FillPath_Lcom_radaee_pdf_Path_Z, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "FillPath", "(Lcom/radaee/pdf/Path;Z)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_GSRestore;
#pragma warning disable 0169
		static Delegate GetGSRestoreHandler ()
		{
			if (cb_GSRestore == null)
				cb_GSRestore = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_GSRestore);
			return cb_GSRestore;
		}

		static void n_GSRestore (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GSRestore ();
		}
#pragma warning restore 0169

		static IntPtr id_GSRestore;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='GSRestore' and count(parameter)=0]"
		[Register ("GSRestore", "()V", "GetGSRestoreHandler")]
		public virtual void GSRestore ()
		{
			if (id_GSRestore == IntPtr.Zero)
				id_GSRestore = JNIEnv.GetMethodID (class_ref, "GSRestore", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_GSRestore);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GSRestore", "()V"));
		}

		static Delegate cb_GSSave;
#pragma warning disable 0169
		static Delegate GetGSSaveHandler ()
		{
			if (cb_GSSave == null)
				cb_GSSave = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_GSSave);
			return cb_GSSave;
		}

		static void n_GSSave (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GSSave ();
		}
#pragma warning restore 0169

		static IntPtr id_GSSave;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='GSSave' and count(parameter)=0]"
		[Register ("GSSave", "()V", "GetGSSaveHandler")]
		public virtual void GSSave ()
		{
			if (id_GSSave == IntPtr.Zero)
				id_GSSave = JNIEnv.GetMethodID (class_ref, "GSSave", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_GSSave);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GSSave", "()V"));
		}

		static Delegate cb_GSSet_Lcom_radaee_pdf_Page_ResGState_;
#pragma warning disable 0169
		static Delegate GetGSSet_Lcom_radaee_pdf_Page_ResGState_Handler ()
		{
			if (cb_GSSet_Lcom_radaee_pdf_Page_ResGState_ == null)
				cb_GSSet_Lcom_radaee_pdf_Page_ResGState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GSSet_Lcom_radaee_pdf_Page_ResGState_);
			return cb_GSSet_Lcom_radaee_pdf_Page_ResGState_;
		}

		static void n_GSSet_Lcom_radaee_pdf_Page_ResGState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Page.ResGState p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.ResGState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GSSet (p0);
		}
#pragma warning restore 0169

		static IntPtr id_GSSet_Lcom_radaee_pdf_Page_ResGState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='GSSet' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Page.ResGState']]"
		[Register ("GSSet", "(Lcom/radaee/pdf/Page$ResGState;)V", "GetGSSet_Lcom_radaee_pdf_Page_ResGState_Handler")]
		public virtual void GSSet (global::Com.Radaee.Pdf.Page.ResGState p0)
		{
			if (id_GSSet_Lcom_radaee_pdf_Page_ResGState_ == IntPtr.Zero)
				id_GSSet_Lcom_radaee_pdf_Page_ResGState_ = JNIEnv.GetMethodID (class_ref, "GSSet", "(Lcom/radaee/pdf/Page$ResGState;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_GSSet_Lcom_radaee_pdf_Page_ResGState_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GSSet", "(Lcom/radaee/pdf/Page$ResGState;)V"), new JValue (p0));
		}

		static Delegate cb_GSSetMatrix_Lcom_radaee_pdf_Matrix_;
#pragma warning disable 0169
		static Delegate GetGSSetMatrix_Lcom_radaee_pdf_Matrix_Handler ()
		{
			if (cb_GSSetMatrix_Lcom_radaee_pdf_Matrix_ == null)
				cb_GSSetMatrix_Lcom_radaee_pdf_Matrix_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GSSetMatrix_Lcom_radaee_pdf_Matrix_);
			return cb_GSSetMatrix_Lcom_radaee_pdf_Matrix_;
		}

		static void n_GSSetMatrix_Lcom_radaee_pdf_Matrix_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Matrix p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Matrix> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GSSetMatrix (p0);
		}
#pragma warning restore 0169

		static IntPtr id_GSSetMatrix_Lcom_radaee_pdf_Matrix_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='GSSetMatrix' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Matrix']]"
		[Register ("GSSetMatrix", "(Lcom/radaee/pdf/Matrix;)V", "GetGSSetMatrix_Lcom_radaee_pdf_Matrix_Handler")]
		public virtual void GSSetMatrix (global::Com.Radaee.Pdf.Matrix p0)
		{
			if (id_GSSetMatrix_Lcom_radaee_pdf_Matrix_ == IntPtr.Zero)
				id_GSSetMatrix_Lcom_radaee_pdf_Matrix_ = JNIEnv.GetMethodID (class_ref, "GSSetMatrix", "(Lcom/radaee/pdf/Matrix;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_GSSetMatrix_Lcom_radaee_pdf_Matrix_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GSSetMatrix", "(Lcom/radaee/pdf/Matrix;)V"), new JValue (p0));
		}

		static Delegate cb_SetFillColor_I;
#pragma warning disable 0169
		static Delegate GetSetFillColor_IHandler ()
		{
			if (cb_SetFillColor_I == null)
				cb_SetFillColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFillColor_I);
			return cb_SetFillColor_I;
		}

		static void n_SetFillColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFillColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetFillColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='SetFillColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("SetFillColor", "(I)V", "GetSetFillColor_IHandler")]
		public virtual void SetFillColor (int p0)
		{
			if (id_SetFillColor_I == IntPtr.Zero)
				id_SetFillColor_I = JNIEnv.GetMethodID (class_ref, "SetFillColor", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_SetFillColor_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetFillColor", "(I)V"), new JValue (p0));
		}

		static Delegate cb_SetStrokeCap_I;
#pragma warning disable 0169
		static Delegate GetSetStrokeCap_IHandler ()
		{
			if (cb_SetStrokeCap_I == null)
				cb_SetStrokeCap_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStrokeCap_I);
			return cb_SetStrokeCap_I;
		}

		static void n_SetStrokeCap_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStrokeCap (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetStrokeCap_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='SetStrokeCap' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("SetStrokeCap", "(I)V", "GetSetStrokeCap_IHandler")]
		public virtual void SetStrokeCap (int p0)
		{
			if (id_SetStrokeCap_I == IntPtr.Zero)
				id_SetStrokeCap_I = JNIEnv.GetMethodID (class_ref, "SetStrokeCap", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_SetStrokeCap_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetStrokeCap", "(I)V"), new JValue (p0));
		}

		static Delegate cb_SetStrokeColor_I;
#pragma warning disable 0169
		static Delegate GetSetStrokeColor_IHandler ()
		{
			if (cb_SetStrokeColor_I == null)
				cb_SetStrokeColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStrokeColor_I);
			return cb_SetStrokeColor_I;
		}

		static void n_SetStrokeColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStrokeColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetStrokeColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='SetStrokeColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("SetStrokeColor", "(I)V", "GetSetStrokeColor_IHandler")]
		public virtual void SetStrokeColor (int p0)
		{
			if (id_SetStrokeColor_I == IntPtr.Zero)
				id_SetStrokeColor_I = JNIEnv.GetMethodID (class_ref, "SetStrokeColor", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_SetStrokeColor_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetStrokeColor", "(I)V"), new JValue (p0));
		}

		static Delegate cb_SetStrokeJoin_I;
#pragma warning disable 0169
		static Delegate GetSetStrokeJoin_IHandler ()
		{
			if (cb_SetStrokeJoin_I == null)
				cb_SetStrokeJoin_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStrokeJoin_I);
			return cb_SetStrokeJoin_I;
		}

		static void n_SetStrokeJoin_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStrokeJoin (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetStrokeJoin_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='SetStrokeJoin' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("SetStrokeJoin", "(I)V", "GetSetStrokeJoin_IHandler")]
		public virtual void SetStrokeJoin (int p0)
		{
			if (id_SetStrokeJoin_I == IntPtr.Zero)
				id_SetStrokeJoin_I = JNIEnv.GetMethodID (class_ref, "SetStrokeJoin", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_SetStrokeJoin_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetStrokeJoin", "(I)V"), new JValue (p0));
		}

		static Delegate cb_SetStrokeMiter_F;
#pragma warning disable 0169
		static Delegate GetSetStrokeMiter_FHandler ()
		{
			if (cb_SetStrokeMiter_F == null)
				cb_SetStrokeMiter_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetStrokeMiter_F);
			return cb_SetStrokeMiter_F;
		}

		static void n_SetStrokeMiter_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStrokeMiter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetStrokeMiter_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='SetStrokeMiter' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("SetStrokeMiter", "(F)V", "GetSetStrokeMiter_FHandler")]
		public virtual void SetStrokeMiter (float p0)
		{
			if (id_SetStrokeMiter_F == IntPtr.Zero)
				id_SetStrokeMiter_F = JNIEnv.GetMethodID (class_ref, "SetStrokeMiter", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_SetStrokeMiter_F, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetStrokeMiter", "(F)V"), new JValue (p0));
		}

		static Delegate cb_SetStrokeWidth_F;
#pragma warning disable 0169
		static Delegate GetSetStrokeWidth_FHandler ()
		{
			if (cb_SetStrokeWidth_F == null)
				cb_SetStrokeWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetStrokeWidth_F);
			return cb_SetStrokeWidth_F;
		}

		static void n_SetStrokeWidth_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStrokeWidth (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetStrokeWidth_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='SetStrokeWidth' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("SetStrokeWidth", "(F)V", "GetSetStrokeWidth_FHandler")]
		public virtual void SetStrokeWidth (float p0)
		{
			if (id_SetStrokeWidth_F == IntPtr.Zero)
				id_SetStrokeWidth_F = JNIEnv.GetMethodID (class_ref, "SetStrokeWidth", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_SetStrokeWidth_F, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetStrokeWidth", "(F)V"), new JValue (p0));
		}

		static Delegate cb_StrokePath_Lcom_radaee_pdf_Path_;
#pragma warning disable 0169
		static Delegate GetStrokePath_Lcom_radaee_pdf_Path_Handler ()
		{
			if (cb_StrokePath_Lcom_radaee_pdf_Path_ == null)
				cb_StrokePath_Lcom_radaee_pdf_Path_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StrokePath_Lcom_radaee_pdf_Path_);
			return cb_StrokePath_Lcom_radaee_pdf_Path_;
		}

		static void n_StrokePath_Lcom_radaee_pdf_Path_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Path p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Path> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StrokePath (p0);
		}
#pragma warning restore 0169

		static IntPtr id_StrokePath_Lcom_radaee_pdf_Path_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='StrokePath' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Path']]"
		[Register ("StrokePath", "(Lcom/radaee/pdf/Path;)V", "GetStrokePath_Lcom_radaee_pdf_Path_Handler")]
		public virtual void StrokePath (global::Com.Radaee.Pdf.Path p0)
		{
			if (id_StrokePath_Lcom_radaee_pdf_Path_ == IntPtr.Zero)
				id_StrokePath_Lcom_radaee_pdf_Path_ = JNIEnv.GetMethodID (class_ref, "StrokePath", "(Lcom/radaee/pdf/Path;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_StrokePath_Lcom_radaee_pdf_Path_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "StrokePath", "(Lcom/radaee/pdf/Path;)V"), new JValue (p0));
		}

		static Delegate cb_TextBegin;
#pragma warning disable 0169
		static Delegate GetTextBeginHandler ()
		{
			if (cb_TextBegin == null)
				cb_TextBegin = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TextBegin);
			return cb_TextBegin;
		}

		static void n_TextBegin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextBegin ();
		}
#pragma warning restore 0169

		static IntPtr id_TextBegin;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='TextBegin' and count(parameter)=0]"
		[Register ("TextBegin", "()V", "GetTextBeginHandler")]
		public virtual void TextBegin ()
		{
			if (id_TextBegin == IntPtr.Zero)
				id_TextBegin = JNIEnv.GetMethodID (class_ref, "TextBegin", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_TextBegin);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "TextBegin", "()V"));
		}

		static Delegate cb_TextEnd;
#pragma warning disable 0169
		static Delegate GetTextEndHandler ()
		{
			if (cb_TextEnd == null)
				cb_TextEnd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TextEnd);
			return cb_TextEnd;
		}

		static void n_TextEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextEnd ();
		}
#pragma warning restore 0169

		static IntPtr id_TextEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='TextEnd' and count(parameter)=0]"
		[Register ("TextEnd", "()V", "GetTextEndHandler")]
		public virtual void TextEnd ()
		{
			if (id_TextEnd == IntPtr.Zero)
				id_TextEnd = JNIEnv.GetMethodID (class_ref, "TextEnd", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_TextEnd);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "TextEnd", "()V"));
		}

		static Delegate cb_TextGetSize_Lcom_radaee_pdf_Page_ResFont_Ljava_lang_String_FFFF;
#pragma warning disable 0169
		static Delegate GetTextGetSize_Lcom_radaee_pdf_Page_ResFont_Ljava_lang_String_FFFFHandler ()
		{
			if (cb_TextGetSize_Lcom_radaee_pdf_Page_ResFont_Ljava_lang_String_FFFF == null)
				cb_TextGetSize_Lcom_radaee_pdf_Page_ResFont_Ljava_lang_String_FFFF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, float, float, float, float, IntPtr>) n_TextGetSize_Lcom_radaee_pdf_Page_ResFont_Ljava_lang_String_FFFF);
			return cb_TextGetSize_Lcom_radaee_pdf_Page_ResFont_Ljava_lang_String_FFFF;
		}

		static IntPtr n_TextGetSize_Lcom_radaee_pdf_Page_ResFont_Ljava_lang_String_FFFF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, float p3, float p4, float p5)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Page.ResFont p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.ResFont> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.TextGetSize (p0, p1, p2, p3, p4, p5));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_TextGetSize_Lcom_radaee_pdf_Page_ResFont_Ljava_lang_String_FFFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='TextGetSize' and count(parameter)=6 and parameter[1][@type='com.radaee.pdf.Page.ResFont'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='float']]"
		[Register ("TextGetSize", "(Lcom/radaee/pdf/Page$ResFont;Ljava/lang/String;FFFF)[F", "GetTextGetSize_Lcom_radaee_pdf_Page_ResFont_Ljava_lang_String_FFFFHandler")]
		public virtual float[] TextGetSize (global::Com.Radaee.Pdf.Page.ResFont p0, string p1, float p2, float p3, float p4, float p5)
		{
			if (id_TextGetSize_Lcom_radaee_pdf_Page_ResFont_Ljava_lang_String_FFFF == IntPtr.Zero)
				id_TextGetSize_Lcom_radaee_pdf_Page_ResFont_Ljava_lang_String_FFFF = JNIEnv.GetMethodID (class_ref, "TextGetSize", "(Lcom/radaee/pdf/Page$ResFont;Ljava/lang/String;FFFF)[F");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			float[] __ret;
			if (GetType () == ThresholdType)
				__ret = (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_TextGetSize_Lcom_radaee_pdf_Page_ResFont_Ljava_lang_String_FFFF, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)), JniHandleOwnership.TransferLocalRef, typeof (float));
			else
				__ret = (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "TextGetSize", "(Lcom/radaee/pdf/Page$ResFont;Ljava/lang/String;FFFF)[F"), new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)), JniHandleOwnership.TransferLocalRef, typeof (float));
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_TextMove_FF;
#pragma warning disable 0169
		static Delegate GetTextMove_FFHandler ()
		{
			if (cb_TextMove_FF == null)
				cb_TextMove_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_TextMove_FF);
			return cb_TextMove_FF;
		}

		static void n_TextMove_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextMove (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_TextMove_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='TextMove' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("TextMove", "(FF)V", "GetTextMove_FFHandler")]
		public virtual void TextMove (float p0, float p1)
		{
			if (id_TextMove_FF == IntPtr.Zero)
				id_TextMove_FF = JNIEnv.GetMethodID (class_ref, "TextMove", "(FF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_TextMove_FF, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "TextMove", "(FF)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_TextNextLine;
#pragma warning disable 0169
		static Delegate GetTextNextLineHandler ()
		{
			if (cb_TextNextLine == null)
				cb_TextNextLine = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TextNextLine);
			return cb_TextNextLine;
		}

		static void n_TextNextLine (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextNextLine ();
		}
#pragma warning restore 0169

		static IntPtr id_TextNextLine;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='TextNextLine' and count(parameter)=0]"
		[Register ("TextNextLine", "()V", "GetTextNextLineHandler")]
		public virtual void TextNextLine ()
		{
			if (id_TextNextLine == IntPtr.Zero)
				id_TextNextLine = JNIEnv.GetMethodID (class_ref, "TextNextLine", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_TextNextLine);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "TextNextLine", "()V"));
		}

		static Delegate cb_TextSetCharSpace_F;
#pragma warning disable 0169
		static Delegate GetTextSetCharSpace_FHandler ()
		{
			if (cb_TextSetCharSpace_F == null)
				cb_TextSetCharSpace_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_TextSetCharSpace_F);
			return cb_TextSetCharSpace_F;
		}

		static void n_TextSetCharSpace_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextSetCharSpace (p0);
		}
#pragma warning restore 0169

		static IntPtr id_TextSetCharSpace_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='TextSetCharSpace' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("TextSetCharSpace", "(F)V", "GetTextSetCharSpace_FHandler")]
		public virtual void TextSetCharSpace (float p0)
		{
			if (id_TextSetCharSpace_F == IntPtr.Zero)
				id_TextSetCharSpace_F = JNIEnv.GetMethodID (class_ref, "TextSetCharSpace", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_TextSetCharSpace_F, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "TextSetCharSpace", "(F)V"), new JValue (p0));
		}

		static Delegate cb_TextSetFont_Lcom_radaee_pdf_Page_ResFont_F;
#pragma warning disable 0169
		static Delegate GetTextSetFont_Lcom_radaee_pdf_Page_ResFont_FHandler ()
		{
			if (cb_TextSetFont_Lcom_radaee_pdf_Page_ResFont_F == null)
				cb_TextSetFont_Lcom_radaee_pdf_Page_ResFont_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float>) n_TextSetFont_Lcom_radaee_pdf_Page_ResFont_F);
			return cb_TextSetFont_Lcom_radaee_pdf_Page_ResFont_F;
		}

		static void n_TextSetFont_Lcom_radaee_pdf_Page_ResFont_F (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Page.ResFont p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.ResFont> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TextSetFont (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_TextSetFont_Lcom_radaee_pdf_Page_ResFont_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='TextSetFont' and count(parameter)=2 and parameter[1][@type='com.radaee.pdf.Page.ResFont'] and parameter[2][@type='float']]"
		[Register ("TextSetFont", "(Lcom/radaee/pdf/Page$ResFont;F)V", "GetTextSetFont_Lcom_radaee_pdf_Page_ResFont_FHandler")]
		public virtual void TextSetFont (global::Com.Radaee.Pdf.Page.ResFont p0, float p1)
		{
			if (id_TextSetFont_Lcom_radaee_pdf_Page_ResFont_F == IntPtr.Zero)
				id_TextSetFont_Lcom_radaee_pdf_Page_ResFont_F = JNIEnv.GetMethodID (class_ref, "TextSetFont", "(Lcom/radaee/pdf/Page$ResFont;F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_TextSetFont_Lcom_radaee_pdf_Page_ResFont_F, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "TextSetFont", "(Lcom/radaee/pdf/Page$ResFont;F)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_TextSetHScale_I;
#pragma warning disable 0169
		static Delegate GetTextSetHScale_IHandler ()
		{
			if (cb_TextSetHScale_I == null)
				cb_TextSetHScale_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_TextSetHScale_I);
			return cb_TextSetHScale_I;
		}

		static void n_TextSetHScale_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextSetHScale (p0);
		}
#pragma warning restore 0169

		static IntPtr id_TextSetHScale_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='TextSetHScale' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("TextSetHScale", "(I)V", "GetTextSetHScale_IHandler")]
		public virtual void TextSetHScale (int p0)
		{
			if (id_TextSetHScale_I == IntPtr.Zero)
				id_TextSetHScale_I = JNIEnv.GetMethodID (class_ref, "TextSetHScale", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_TextSetHScale_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "TextSetHScale", "(I)V"), new JValue (p0));
		}

		static Delegate cb_TextSetLeading_F;
#pragma warning disable 0169
		static Delegate GetTextSetLeading_FHandler ()
		{
			if (cb_TextSetLeading_F == null)
				cb_TextSetLeading_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_TextSetLeading_F);
			return cb_TextSetLeading_F;
		}

		static void n_TextSetLeading_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextSetLeading (p0);
		}
#pragma warning restore 0169

		static IntPtr id_TextSetLeading_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='TextSetLeading' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("TextSetLeading", "(F)V", "GetTextSetLeading_FHandler")]
		public virtual void TextSetLeading (float p0)
		{
			if (id_TextSetLeading_F == IntPtr.Zero)
				id_TextSetLeading_F = JNIEnv.GetMethodID (class_ref, "TextSetLeading", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_TextSetLeading_F, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "TextSetLeading", "(F)V"), new JValue (p0));
		}

		static Delegate cb_TextSetRenderMode_I;
#pragma warning disable 0169
		static Delegate GetTextSetRenderMode_IHandler ()
		{
			if (cb_TextSetRenderMode_I == null)
				cb_TextSetRenderMode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_TextSetRenderMode_I);
			return cb_TextSetRenderMode_I;
		}

		static void n_TextSetRenderMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextSetRenderMode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_TextSetRenderMode_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='TextSetRenderMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("TextSetRenderMode", "(I)V", "GetTextSetRenderMode_IHandler")]
		public virtual void TextSetRenderMode (int p0)
		{
			if (id_TextSetRenderMode_I == IntPtr.Zero)
				id_TextSetRenderMode_I = JNIEnv.GetMethodID (class_ref, "TextSetRenderMode", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_TextSetRenderMode_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "TextSetRenderMode", "(I)V"), new JValue (p0));
		}

		static Delegate cb_TextSetRise_F;
#pragma warning disable 0169
		static Delegate GetTextSetRise_FHandler ()
		{
			if (cb_TextSetRise_F == null)
				cb_TextSetRise_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_TextSetRise_F);
			return cb_TextSetRise_F;
		}

		static void n_TextSetRise_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextSetRise (p0);
		}
#pragma warning restore 0169

		static IntPtr id_TextSetRise_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='TextSetRise' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("TextSetRise", "(F)V", "GetTextSetRise_FHandler")]
		public virtual void TextSetRise (float p0)
		{
			if (id_TextSetRise_F == IntPtr.Zero)
				id_TextSetRise_F = JNIEnv.GetMethodID (class_ref, "TextSetRise", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_TextSetRise_F, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "TextSetRise", "(F)V"), new JValue (p0));
		}

		static Delegate cb_TextSetWordSpace_F;
#pragma warning disable 0169
		static Delegate GetTextSetWordSpace_FHandler ()
		{
			if (cb_TextSetWordSpace_F == null)
				cb_TextSetWordSpace_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_TextSetWordSpace_F);
			return cb_TextSetWordSpace_F;
		}

		static void n_TextSetWordSpace_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Radaee.Pdf.PageContent __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextSetWordSpace (p0);
		}
#pragma warning restore 0169

		static IntPtr id_TextSetWordSpace_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='PageContent']/method[@name='TextSetWordSpace' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("TextSetWordSpace", "(F)V", "GetTextSetWordSpace_FHandler")]
		public virtual void TextSetWordSpace (float p0)
		{
			if (id_TextSetWordSpace_F == IntPtr.Zero)
				id_TextSetWordSpace_F = JNIEnv.GetMethodID (class_ref, "TextSetWordSpace", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_TextSetWordSpace_F, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "TextSetWordSpace", "(F)V"), new JValue (p0));
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Radaee.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVSel']"
	[global::Android.Runtime.Register ("com/radaee/view/PDFVSel", DoNotGenerateAcw=true)]
	public partial class PDFVSel : global::Java.Lang.Object {


		static IntPtr m_index1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVSel']/field[@name='m_index1']"
		[Register ("m_index1")]
		protected int MIndex1 {
			get {
				if (m_index1_jfieldId == IntPtr.Zero)
					m_index1_jfieldId = JNIEnv.GetFieldID (class_ref, "m_index1", "I");
				return JNIEnv.GetIntField (Handle, m_index1_jfieldId);
			}
			set {
				if (m_index1_jfieldId == IntPtr.Zero)
					m_index1_jfieldId = JNIEnv.GetFieldID (class_ref, "m_index1", "I");
				JNIEnv.SetField (Handle, m_index1_jfieldId, value);
			}
		}

		static IntPtr m_index2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVSel']/field[@name='m_index2']"
		[Register ("m_index2")]
		protected int MIndex2 {
			get {
				if (m_index2_jfieldId == IntPtr.Zero)
					m_index2_jfieldId = JNIEnv.GetFieldID (class_ref, "m_index2", "I");
				return JNIEnv.GetIntField (Handle, m_index2_jfieldId);
			}
			set {
				if (m_index2_jfieldId == IntPtr.Zero)
					m_index2_jfieldId = JNIEnv.GetFieldID (class_ref, "m_index2", "I");
				JNIEnv.SetField (Handle, m_index2_jfieldId, value);
			}
		}

		static IntPtr m_ok_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVSel']/field[@name='m_ok']"
		[Register ("m_ok")]
		protected bool MOk {
			get {
				if (m_ok_jfieldId == IntPtr.Zero)
					m_ok_jfieldId = JNIEnv.GetFieldID (class_ref, "m_ok", "Z");
				return JNIEnv.GetBooleanField (Handle, m_ok_jfieldId);
			}
			set {
				if (m_ok_jfieldId == IntPtr.Zero)
					m_ok_jfieldId = JNIEnv.GetFieldID (class_ref, "m_ok", "Z");
				JNIEnv.SetField (Handle, m_ok_jfieldId, value);
			}
		}

		static IntPtr m_page_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVSel']/field[@name='m_page']"
		[Register ("m_page")]
		protected global::Com.Radaee.Pdf.Page MPage {
			get {
				if (m_page_jfieldId == IntPtr.Zero)
					m_page_jfieldId = JNIEnv.GetFieldID (class_ref, "m_page", "Lcom/radaee/pdf/Page;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, m_page_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_page_jfieldId == IntPtr.Zero)
					m_page_jfieldId = JNIEnv.GetFieldID (class_ref, "m_page", "Lcom/radaee/pdf/Page;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, m_page_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr m_swiped_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVSel']/field[@name='m_swiped']"
		[Register ("m_swiped")]
		protected bool MSwiped {
			get {
				if (m_swiped_jfieldId == IntPtr.Zero)
					m_swiped_jfieldId = JNIEnv.GetFieldID (class_ref, "m_swiped", "Z");
				return JNIEnv.GetBooleanField (Handle, m_swiped_jfieldId);
			}
			set {
				if (m_swiped_jfieldId == IntPtr.Zero)
					m_swiped_jfieldId = JNIEnv.GetFieldID (class_ref, "m_swiped", "Z");
				JNIEnv.SetField (Handle, m_swiped_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/radaee/view/PDFVSel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PDFVSel); }
		}

		protected PDFVSel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_radaee_pdf_Page_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVSel']/constructor[@name='PDFVSel' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Page']]"
		[Register (".ctor", "(Lcom/radaee/pdf/Page;)V", "")]
		protected PDFVSel (global::Com.Radaee.Pdf.Page p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PDFVSel)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/radaee/pdf/Page;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/radaee/pdf/Page;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_radaee_pdf_Page_ == IntPtr.Zero)
				id_ctor_Lcom_radaee_pdf_Page_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/radaee/pdf/Page;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_radaee_pdf_Page_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_radaee_pdf_Page_, new JValue (p0));
		}

		static Delegate cb_GetSelString;
#pragma warning disable 0169
		static Delegate GetGetSelStringHandler ()
		{
			if (cb_GetSelString == null)
				cb_GetSelString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelString);
			return cb_GetSelString;
		}

		static IntPtr n_GetSelString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFVSel __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVSel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SelString);
		}
#pragma warning restore 0169

		static IntPtr id_GetSelString;
		protected virtual string SelString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVSel']/method[@name='GetSelString' and count(parameter)=0]"
			[Register ("GetSelString", "()Ljava/lang/String;", "GetGetSelStringHandler")]
			get {
				if (id_GetSelString == IntPtr.Zero)
					id_GetSelString = JNIEnv.GetMethodID (class_ref, "GetSelString", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetSelString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSelString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_Clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_Clear == null)
				cb_Clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_Clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFVSel __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVSel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_Clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVSel']/method[@name='Clear' and count(parameter)=0]"
		[Register ("Clear", "()V", "GetClearHandler")]
		protected virtual void Clear ()
		{
			if (id_Clear == IntPtr.Zero)
				id_Clear = JNIEnv.GetMethodID (class_ref, "Clear", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_Clear);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Clear", "()V"));
		}

		static Delegate cb_DrawSel_Landroid_graphics_Canvas_FFII;
#pragma warning disable 0169
		static Delegate GetDrawSel_Landroid_graphics_Canvas_FFIIHandler ()
		{
			if (cb_DrawSel_Landroid_graphics_Canvas_FFII == null)
				cb_DrawSel_Landroid_graphics_Canvas_FFII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float, int, int>) n_DrawSel_Landroid_graphics_Canvas_FFII);
			return cb_DrawSel_Landroid_graphics_Canvas_FFII;
		}

		static void n_DrawSel_Landroid_graphics_Canvas_FFII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2, int p3, int p4)
		{
			global::Com.Radaee.View.PDFVSel __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVSel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DrawSel (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_DrawSel_Landroid_graphics_Canvas_FFII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVSel']/method[@name='DrawSel' and count(parameter)=5 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("DrawSel", "(Landroid/graphics/Canvas;FFII)V", "GetDrawSel_Landroid_graphics_Canvas_FFIIHandler")]
		protected virtual void DrawSel (global::Android.Graphics.Canvas p0, float p1, float p2, int p3, int p4)
		{
			if (id_DrawSel_Landroid_graphics_Canvas_FFII == IntPtr.Zero)
				id_DrawSel_Landroid_graphics_Canvas_FFII = JNIEnv.GetMethodID (class_ref, "DrawSel", "(Landroid/graphics/Canvas;FFII)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_DrawSel_Landroid_graphics_Canvas_FFII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "DrawSel", "(Landroid/graphics/Canvas;FFII)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static Delegate cb_DrawSel_Lcom_radaee_pdf_BMP_FFII;
#pragma warning disable 0169
		static Delegate GetDrawSel_Lcom_radaee_pdf_BMP_FFIIHandler ()
		{
			if (cb_DrawSel_Lcom_radaee_pdf_BMP_FFII == null)
				cb_DrawSel_Lcom_radaee_pdf_BMP_FFII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float, int, int>) n_DrawSel_Lcom_radaee_pdf_BMP_FFII);
			return cb_DrawSel_Lcom_radaee_pdf_BMP_FFII;
		}

		static void n_DrawSel_Lcom_radaee_pdf_BMP_FFII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2, int p3, int p4)
		{
			global::Com.Radaee.View.PDFVSel __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVSel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.BMP p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.BMP> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DrawSel (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_DrawSel_Lcom_radaee_pdf_BMP_FFII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVSel']/method[@name='DrawSel' and count(parameter)=5 and parameter[1][@type='com.radaee.pdf.BMP'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("DrawSel", "(Lcom/radaee/pdf/BMP;FFII)V", "GetDrawSel_Lcom_radaee_pdf_BMP_FFIIHandler")]
		protected virtual void DrawSel (global::Com.Radaee.Pdf.BMP p0, float p1, float p2, int p3, int p4)
		{
			if (id_DrawSel_Lcom_radaee_pdf_BMP_FFII == IntPtr.Zero)
				id_DrawSel_Lcom_radaee_pdf_BMP_FFII = JNIEnv.GetMethodID (class_ref, "DrawSel", "(Lcom/radaee/pdf/BMP;FFII)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_DrawSel_Lcom_radaee_pdf_BMP_FFII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "DrawSel", "(Lcom/radaee/pdf/BMP;FFII)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static Delegate cb_DrawSelToDIB_Lcom_radaee_pdf_DIB_FFII;
#pragma warning disable 0169
		static Delegate GetDrawSelToDIB_Lcom_radaee_pdf_DIB_FFIIHandler ()
		{
			if (cb_DrawSelToDIB_Lcom_radaee_pdf_DIB_FFII == null)
				cb_DrawSelToDIB_Lcom_radaee_pdf_DIB_FFII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float, int, int>) n_DrawSelToDIB_Lcom_radaee_pdf_DIB_FFII);
			return cb_DrawSelToDIB_Lcom_radaee_pdf_DIB_FFII;
		}

		static void n_DrawSelToDIB_Lcom_radaee_pdf_DIB_FFII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2, int p3, int p4)
		{
			global::Com.Radaee.View.PDFVSel __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVSel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.DIB p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.DIB> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DrawSelToDIB (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_DrawSelToDIB_Lcom_radaee_pdf_DIB_FFII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVSel']/method[@name='DrawSelToDIB' and count(parameter)=5 and parameter[1][@type='com.radaee.pdf.DIB'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("DrawSelToDIB", "(Lcom/radaee/pdf/DIB;FFII)V", "GetDrawSelToDIB_Lcom_radaee_pdf_DIB_FFIIHandler")]
		protected virtual void DrawSelToDIB (global::Com.Radaee.Pdf.DIB p0, float p1, float p2, int p3, int p4)
		{
			if (id_DrawSelToDIB_Lcom_radaee_pdf_DIB_FFII == IntPtr.Zero)
				id_DrawSelToDIB_Lcom_radaee_pdf_DIB_FFII = JNIEnv.GetMethodID (class_ref, "DrawSelToDIB", "(Lcom/radaee/pdf/DIB;FFII)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_DrawSelToDIB_Lcom_radaee_pdf_DIB_FFII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "DrawSelToDIB", "(Lcom/radaee/pdf/DIB;FFII)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static Delegate cb_GetRect1_FFII;
#pragma warning disable 0169
		static Delegate GetGetRect1_FFIIHandler ()
		{
			if (cb_GetRect1_FFII == null)
				cb_GetRect1_FFII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, int, int, IntPtr>) n_GetRect1_FFII);
			return cb_GetRect1_FFII;
		}

		static IntPtr n_GetRect1_FFII (IntPtr jnienv, IntPtr native__this, float p0, float p1, int p2, int p3)
		{
			global::Com.Radaee.View.PDFVSel __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVSel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRect1 (p0, p1, p2, p3));
		}
#pragma warning restore 0169

		static IntPtr id_GetRect1_FFII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVSel']/method[@name='GetRect1' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("GetRect1", "(FFII)[I", "GetGetRect1_FFIIHandler")]
		protected virtual int[] GetRect1 (float p0, float p1, int p2, int p3)
		{
			if (id_GetRect1_FFII == IntPtr.Zero)
				id_GetRect1_FFII = JNIEnv.GetMethodID (class_ref, "GetRect1", "(FFII)[I");

			if (GetType () == ThresholdType)
				return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_GetRect1_FFII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef, typeof (int));
			else
				return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetRect1", "(FFII)[I"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef, typeof (int));
		}

		static Delegate cb_GetRect2_FFII;
#pragma warning disable 0169
		static Delegate GetGetRect2_FFIIHandler ()
		{
			if (cb_GetRect2_FFII == null)
				cb_GetRect2_FFII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, int, int, IntPtr>) n_GetRect2_FFII);
			return cb_GetRect2_FFII;
		}

		static IntPtr n_GetRect2_FFII (IntPtr jnienv, IntPtr native__this, float p0, float p1, int p2, int p3)
		{
			global::Com.Radaee.View.PDFVSel __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVSel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRect2 (p0, p1, p2, p3));
		}
#pragma warning restore 0169

		static IntPtr id_GetRect2_FFII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVSel']/method[@name='GetRect2' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("GetRect2", "(FFII)[I", "GetGetRect2_FFIIHandler")]
		protected virtual int[] GetRect2 (float p0, float p1, int p2, int p3)
		{
			if (id_GetRect2_FFII == IntPtr.Zero)
				id_GetRect2_FFII = JNIEnv.GetMethodID (class_ref, "GetRect2", "(FFII)[I");

			if (GetType () == ThresholdType)
				return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_GetRect2_FFII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef, typeof (int));
			else
				return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetRect2", "(FFII)[I"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef, typeof (int));
		}

		static Delegate cb_SetSel_FFFF;
#pragma warning disable 0169
		static Delegate GetSetSel_FFFFHandler ()
		{
			if (cb_SetSel_FFFF == null)
				cb_SetSel_FFFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, float>) n_SetSel_FFFF);
			return cb_SetSel_FFFF;
		}

		static void n_SetSel_FFFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2, float p3)
		{
			global::Com.Radaee.View.PDFVSel __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVSel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSel (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_SetSel_FFFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVSel']/method[@name='SetSel' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("SetSel", "(FFFF)V", "GetSetSel_FFFFHandler")]
		protected virtual void SetSel (float p0, float p1, float p2, float p3)
		{
			if (id_SetSel_FFFF == IntPtr.Zero)
				id_SetSel_FFFF = JNIEnv.GetMethodID (class_ref, "SetSel", "(FFFF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_SetSel_FFFF, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetSel", "(FFFF)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static Delegate cb_SetSelMarkup_I;
#pragma warning disable 0169
		static Delegate GetSetSelMarkup_IHandler ()
		{
			if (cb_SetSelMarkup_I == null)
				cb_SetSelMarkup_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_SetSelMarkup_I);
			return cb_SetSelMarkup_I;
		}

		static bool n_SetSelMarkup_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.View.PDFVSel __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVSel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetSelMarkup (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetSelMarkup_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVSel']/method[@name='SetSelMarkup' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("SetSelMarkup", "(I)Z", "GetSetSelMarkup_IHandler")]
		protected virtual bool SetSelMarkup (int p0)
		{
			if (id_SetSelMarkup_I == IntPtr.Zero)
				id_SetSelMarkup_I = JNIEnv.GetMethodID (class_ref, "SetSelMarkup", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_SetSelMarkup_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetSelMarkup", "(I)Z"), new JValue (p0));
		}

	}
}

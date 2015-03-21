using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Radaee.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.view']/class[@name='VCache']"
	[global::Android.Runtime.Register ("com/radaee/view/VCache", DoNotGenerateAcw=true)]
	public partial class VCache : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/radaee/view/VCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VCache); }
		}

		protected VCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_radaee_pdf_Document_IFIIII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.view']/class[@name='VCache']/constructor[@name='VCache' and count(parameter)=7 and parameter[1][@type='com.radaee.pdf.Document'] and parameter[2][@type='int'] and parameter[3][@type='float'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register (".ctor", "(Lcom/radaee/pdf/Document;IFIIII)V", "")]
		protected VCache (global::Com.Radaee.Pdf.Document p0, int p1, float p2, int p3, int p4, int p5, int p6) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (VCache)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/radaee/pdf/Document;IFIIII)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/radaee/pdf/Document;IFIIII)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6));
				return;
			}

			if (id_ctor_Lcom_radaee_pdf_Document_IFIIII == IntPtr.Zero)
				id_ctor_Lcom_radaee_pdf_Document_IFIIII = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/radaee/pdf/Document;IFIIII)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_radaee_pdf_Document_IFIIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_radaee_pdf_Document_IFIIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6));
		}

		static Delegate cb_vDestroy;
#pragma warning disable 0169
		static Delegate GetVDestroyHandler ()
		{
			if (cb_vDestroy == null)
				cb_vDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_VDestroy);
			return cb_vDestroy;
		}

		static void n_VDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.VCache __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_vDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VCache']/method[@name='vDestroy' and count(parameter)=0]"
		[Register ("vDestroy", "()V", "GetVDestroyHandler")]
		protected virtual void VDestroy ()
		{
			if (id_vDestroy == IntPtr.Zero)
				id_vDestroy = JNIEnv.GetMethodID (class_ref, "vDestroy", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vDestroy);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vDestroy", "()V"));
		}

		static Delegate cb_vDraw_Lcom_radaee_pdf_BMP_II;
#pragma warning disable 0169
		static Delegate GetVDraw_Lcom_radaee_pdf_BMP_IIHandler ()
		{
			if (cb_vDraw_Lcom_radaee_pdf_BMP_II == null)
				cb_vDraw_Lcom_radaee_pdf_BMP_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_VDraw_Lcom_radaee_pdf_BMP_II);
			return cb_vDraw_Lcom_radaee_pdf_BMP_II;
		}

		static void n_VDraw_Lcom_radaee_pdf_BMP_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Radaee.View.VCache __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.BMP p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.BMP> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VDraw (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_vDraw_Lcom_radaee_pdf_BMP_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VCache']/method[@name='vDraw' and count(parameter)=3 and parameter[1][@type='com.radaee.pdf.BMP'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("vDraw", "(Lcom/radaee/pdf/BMP;II)V", "GetVDraw_Lcom_radaee_pdf_BMP_IIHandler")]
		protected virtual void VDraw (global::Com.Radaee.Pdf.BMP p0, int p1, int p2)
		{
			if (id_vDraw_Lcom_radaee_pdf_BMP_II == IntPtr.Zero)
				id_vDraw_Lcom_radaee_pdf_BMP_II = JNIEnv.GetMethodID (class_ref, "vDraw", "(Lcom/radaee/pdf/BMP;II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vDraw_Lcom_radaee_pdf_BMP_II, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vDraw", "(Lcom/radaee/pdf/BMP;II)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_vDraw_Lcom_radaee_pdf_BMP_IIII;
#pragma warning disable 0169
		static Delegate GetVDraw_Lcom_radaee_pdf_BMP_IIIIHandler ()
		{
			if (cb_vDraw_Lcom_radaee_pdf_BMP_IIII == null)
				cb_vDraw_Lcom_radaee_pdf_BMP_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int>) n_VDraw_Lcom_radaee_pdf_BMP_IIII);
			return cb_vDraw_Lcom_radaee_pdf_BMP_IIII;
		}

		static void n_VDraw_Lcom_radaee_pdf_BMP_IIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4)
		{
			global::Com.Radaee.View.VCache __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.BMP p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.BMP> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VDraw (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_vDraw_Lcom_radaee_pdf_BMP_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VCache']/method[@name='vDraw' and count(parameter)=5 and parameter[1][@type='com.radaee.pdf.BMP'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("vDraw", "(Lcom/radaee/pdf/BMP;IIII)V", "GetVDraw_Lcom_radaee_pdf_BMP_IIIIHandler")]
		protected virtual void VDraw (global::Com.Radaee.Pdf.BMP p0, int p1, int p2, int p3, int p4)
		{
			if (id_vDraw_Lcom_radaee_pdf_BMP_IIII == IntPtr.Zero)
				id_vDraw_Lcom_radaee_pdf_BMP_IIII = JNIEnv.GetMethodID (class_ref, "vDraw", "(Lcom/radaee/pdf/BMP;IIII)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vDraw_Lcom_radaee_pdf_BMP_IIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vDraw", "(Lcom/radaee/pdf/BMP;IIII)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static Delegate cb_vEnd;
#pragma warning disable 0169
		static Delegate GetVEndHandler ()
		{
			if (cb_vEnd == null)
				cb_vEnd = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_VEnd);
			return cb_vEnd;
		}

		static bool n_VEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.VCache __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VEnd ();
		}
#pragma warning restore 0169

		static IntPtr id_vEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VCache']/method[@name='vEnd' and count(parameter)=0]"
		[Register ("vEnd", "()Z", "GetVEndHandler")]
		protected virtual bool VEnd ()
		{
			if (id_vEnd == IntPtr.Zero)
				id_vEnd = JNIEnv.GetMethodID (class_ref, "vEnd", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_vEnd);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vEnd", "()Z"));
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
			global::Com.Radaee.View.VCache __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VFinished ();
		}
#pragma warning restore 0169

		static IntPtr id_vFinished;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VCache']/method[@name='vFinished' and count(parameter)=0]"
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

		static IntPtr id_vGetH;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VCache']/method[@name='vGetH' and count(parameter)=0]"
		[Register ("vGetH", "()I", "")]
		protected int VGetH ()
		{
			if (id_vGetH == IntPtr.Zero)
				id_vGetH = JNIEnv.GetMethodID (class_ref, "vGetH", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_vGetH);
		}

		static IntPtr id_vGetPageNO;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VCache']/method[@name='vGetPageNO' and count(parameter)=0]"
		[Register ("vGetPageNO", "()I", "")]
		protected int VGetPageNO ()
		{
			if (id_vGetPageNO == IntPtr.Zero)
				id_vGetPageNO = JNIEnv.GetMethodID (class_ref, "vGetPageNO", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_vGetPageNO);
		}

		static IntPtr id_vGetW;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VCache']/method[@name='vGetW' and count(parameter)=0]"
		[Register ("vGetW", "()I", "")]
		protected int VGetW ()
		{
			if (id_vGetW == IntPtr.Zero)
				id_vGetW = JNIEnv.GetMethodID (class_ref, "vGetW", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_vGetW);
		}

		static Delegate cb_vIsRender;
#pragma warning disable 0169
		static Delegate GetVIsRenderHandler ()
		{
			if (cb_vIsRender == null)
				cb_vIsRender = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_VIsRender);
			return cb_vIsRender;
		}

		static bool n_VIsRender (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.VCache __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VIsRender ();
		}
#pragma warning restore 0169

		static IntPtr id_vIsRender;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VCache']/method[@name='vIsRender' and count(parameter)=0]"
		[Register ("vIsRender", "()Z", "GetVIsRenderHandler")]
		protected virtual bool VIsRender ()
		{
			if (id_vIsRender == IntPtr.Zero)
				id_vIsRender = JNIEnv.GetMethodID (class_ref, "vIsRender", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_vIsRender);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vIsRender", "()Z"));
		}

		static Delegate cb_vRender;
#pragma warning disable 0169
		static Delegate GetVRenderHandler ()
		{
			if (cb_vRender == null)
				cb_vRender = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_VRender);
			return cb_vRender;
		}

		static void n_VRender (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.VCache __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VRender ();
		}
#pragma warning restore 0169

		static IntPtr id_vRender;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VCache']/method[@name='vRender' and count(parameter)=0]"
		[Register ("vRender", "()V", "GetVRenderHandler")]
		protected virtual void VRender ()
		{
			if (id_vRender == IntPtr.Zero)
				id_vRender = JNIEnv.GetMethodID (class_ref, "vRender", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vRender);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vRender", "()V"));
		}

		static Delegate cb_vRenderThumb;
#pragma warning disable 0169
		static Delegate GetVRenderThumbHandler ()
		{
			if (cb_vRenderThumb == null)
				cb_vRenderThumb = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_VRenderThumb);
			return cb_vRenderThumb;
		}

		static void n_VRenderThumb (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.VCache __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VRenderThumb ();
		}
#pragma warning restore 0169

		static IntPtr id_vRenderThumb;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VCache']/method[@name='vRenderThumb' and count(parameter)=0]"
		[Register ("vRenderThumb", "()V", "GetVRenderThumbHandler")]
		protected virtual void VRenderThumb ()
		{
			if (id_vRenderThumb == IntPtr.Zero)
				id_vRenderThumb = JNIEnv.GetMethodID (class_ref, "vRenderThumb", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vRenderThumb);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vRenderThumb", "()V"));
		}

		static Delegate cb_vStart;
#pragma warning disable 0169
		static Delegate GetVStartHandler ()
		{
			if (cb_vStart == null)
				cb_vStart = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_VStart);
			return cb_vStart;
		}

		static bool n_VStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.VCache __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.VCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VStart ();
		}
#pragma warning restore 0169

		static IntPtr id_vStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='VCache']/method[@name='vStart' and count(parameter)=0]"
		[Register ("vStart", "()Z", "GetVStartHandler")]
		protected virtual bool VStart ()
		{
			if (id_vStart == IntPtr.Zero)
				id_vStart = JNIEnv.GetMethodID (class_ref, "vStart", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_vStart);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vStart", "()Z"));
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Radaee.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFViewVert']"
	[global::Android.Runtime.Register ("com/radaee/view/PDFViewVert", DoNotGenerateAcw=true)]
	public partial class PDFViewVert : global::Com.Radaee.View.PDFView {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/radaee/view/PDFViewVert", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PDFViewVert); }
		}

		protected PDFViewVert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFViewVert']/constructor[@name='PDFViewVert' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public PDFViewVert (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PDFViewVert)) {
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

		static Delegate cb_vSetPageAlign_I;
#pragma warning disable 0169
		static Delegate GetVSetPageAlign_IHandler ()
		{
			if (cb_vSetPageAlign_I == null)
				cb_vSetPageAlign_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_VSetPageAlign_I);
			return cb_vSetPageAlign_I;
		}

		static void n_VSetPageAlign_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.View.PDFViewVert __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFViewVert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VSetPageAlign (p0);
		}
#pragma warning restore 0169

		static IntPtr id_vSetPageAlign_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFViewVert']/method[@name='vSetPageAlign' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("vSetPageAlign", "(I)V", "GetVSetPageAlign_IHandler")]
		public virtual void VSetPageAlign (int p0)
		{
			if (id_vSetPageAlign_I == IntPtr.Zero)
				id_vSetPageAlign_I = JNIEnv.GetMethodID (class_ref, "vSetPageAlign", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vSetPageAlign_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vSetPageAlign", "(I)V"), new JValue (p0));
		}

	}
}

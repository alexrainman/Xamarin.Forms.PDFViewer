using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Radaee.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFLayoutVert']"
	[global::Android.Runtime.Register ("com/radaee/view/PDFLayoutVert", DoNotGenerateAcw=true)]
	public partial class PDFLayoutVert : global::Com.Radaee.View.PDFLayout {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/radaee/view/PDFLayoutVert", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PDFLayoutVert); }
		}

		protected PDFLayoutVert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFLayoutVert']/constructor[@name='PDFLayoutVert' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public PDFLayoutVert (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PDFLayoutVert)) {
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
			global::Com.Radaee.View.PDFLayoutVert __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFLayoutVert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VGetPage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_vGetPage_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFLayoutVert']/method[@name='vGetPage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("vGetPage", "(II)I", "GetVGetPage_IIHandler")]
		public override int VGetPage (int p0, int p1)
		{
			if (id_vGetPage_II == IntPtr.Zero)
				id_vGetPage_II = JNIEnv.GetMethodID (class_ref, "vGetPage", "(II)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_vGetPage_II, new JValue (p0), new JValue (p1));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vGetPage", "(II)I"), new JValue (p0), new JValue (p1));
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
			global::Com.Radaee.View.PDFLayoutVert __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFLayoutVert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VLayout ();
		}
#pragma warning restore 0169

		static IntPtr id_vLayout;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFLayoutVert']/method[@name='vLayout' and count(parameter)=0]"
		[Register ("vLayout", "()V", "GetVLayoutHandler")]
		public override void VLayout ()
		{
			if (id_vLayout == IntPtr.Zero)
				id_vLayout = JNIEnv.GetMethodID (class_ref, "vLayout", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vLayout);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vLayout", "()V"));
		}

	}
}

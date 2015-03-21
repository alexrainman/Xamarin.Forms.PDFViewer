using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Radaee.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFViewDual']"
	[global::Android.Runtime.Register ("com/radaee/view/PDFViewDual", DoNotGenerateAcw=true)]
	public partial class PDFViewDual : global::Com.Radaee.View.PDFView {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFViewDual.PDFCell']"
		[global::Android.Runtime.Register ("com/radaee/view/PDFViewDual$PDFCell", DoNotGenerateAcw=true)]
		public partial class PDFCell : global::Java.Lang.Object {

			protected PDFCell (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/radaee/view/PDFViewDual", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PDFViewDual); }
		}

		protected PDFViewDual (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFViewDual']/constructor[@name='PDFViewDual' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public PDFViewDual (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PDFViewDual)) {
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

		static Delegate cb_vSetLayoutPara_arrayZarrayZZ;
#pragma warning disable 0169
		static Delegate GetVSetLayoutPara_arrayZarrayZZHandler ()
		{
			if (cb_vSetLayoutPara_arrayZarrayZZ == null)
				cb_vSetLayoutPara_arrayZarrayZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_VSetLayoutPara_arrayZarrayZZ);
			return cb_vSetLayoutPara_arrayZarrayZZ;
		}

		static void n_VSetLayoutPara_arrayZarrayZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Radaee.View.PDFViewDual __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFViewDual> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			bool[] p0 = (bool[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (bool));
			bool[] p1 = (bool[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (bool));
			__this.VSetLayoutPara (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_vSetLayoutPara_arrayZarrayZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFViewDual']/method[@name='vSetLayoutPara' and count(parameter)=3 and parameter[1][@type='boolean[]'] and parameter[2][@type='boolean[]'] and parameter[3][@type='boolean']]"
		[Register ("vSetLayoutPara", "([Z[ZZ)V", "GetVSetLayoutPara_arrayZarrayZZHandler")]
		public virtual void VSetLayoutPara (bool[] p0, bool[] p1, bool p2)
		{
			if (id_vSetLayoutPara_arrayZarrayZZ == IntPtr.Zero)
				id_vSetLayoutPara_arrayZarrayZZ = JNIEnv.GetMethodID (class_ref, "vSetLayoutPara", "([Z[ZZ)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vSetLayoutPara_arrayZarrayZZ, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vSetLayoutPara", "([Z[ZZ)V"), new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}

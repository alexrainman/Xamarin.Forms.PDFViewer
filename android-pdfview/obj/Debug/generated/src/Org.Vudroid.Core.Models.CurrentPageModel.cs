using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Core.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.vudroid.core.models']/class[@name='CurrentPageModel']"
	[global::Android.Runtime.Register ("org/vudroid/core/models/CurrentPageModel", DoNotGenerateAcw=true)]
	public partial class CurrentPageModel : global::Org.Vudroid.Core.Events.EventDispatcher {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/vudroid/core/models/CurrentPageModel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CurrentPageModel); }
		}

		protected CurrentPageModel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.vudroid.core.models']/class[@name='CurrentPageModel']/constructor[@name='CurrentPageModel' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public CurrentPageModel () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CurrentPageModel)) {
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

		static Delegate cb_setCurrentPageIndex_I;
#pragma warning disable 0169
		static Delegate GetSetCurrentPageIndex_IHandler ()
		{
			if (cb_setCurrentPageIndex_I == null)
				cb_setCurrentPageIndex_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCurrentPageIndex_I);
			return cb_setCurrentPageIndex_I;
		}

		static void n_SetCurrentPageIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Vudroid.Core.Models.CurrentPageModel __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Models.CurrentPageModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCurrentPageIndex (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCurrentPageIndex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.models']/class[@name='CurrentPageModel']/method[@name='setCurrentPageIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCurrentPageIndex", "(I)V", "GetSetCurrentPageIndex_IHandler")]
		public virtual void SetCurrentPageIndex (int p0)
		{
			if (id_setCurrentPageIndex_I == IntPtr.Zero)
				id_setCurrentPageIndex_I = JNIEnv.GetMethodID (class_ref, "setCurrentPageIndex", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setCurrentPageIndex_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurrentPageIndex", "(I)V"), new JValue (p0));
		}

	}
}

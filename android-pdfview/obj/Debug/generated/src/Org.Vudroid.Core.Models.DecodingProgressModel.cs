using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Core.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.vudroid.core.models']/class[@name='DecodingProgressModel']"
	[global::Android.Runtime.Register ("org/vudroid/core/models/DecodingProgressModel", DoNotGenerateAcw=true)]
	public partial class DecodingProgressModel : global::Org.Vudroid.Core.Events.EventDispatcher {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/vudroid/core/models/DecodingProgressModel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DecodingProgressModel); }
		}

		protected DecodingProgressModel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.vudroid.core.models']/class[@name='DecodingProgressModel']/constructor[@name='DecodingProgressModel' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DecodingProgressModel () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DecodingProgressModel)) {
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

		static Delegate cb_decrease;
#pragma warning disable 0169
		static Delegate GetDecreaseHandler ()
		{
			if (cb_decrease == null)
				cb_decrease = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Decrease);
			return cb_decrease;
		}

		static void n_Decrease (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Vudroid.Core.Models.DecodingProgressModel __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Models.DecodingProgressModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Decrease ();
		}
#pragma warning restore 0169

		static IntPtr id_decrease;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.models']/class[@name='DecodingProgressModel']/method[@name='decrease' and count(parameter)=0]"
		[Register ("decrease", "()V", "GetDecreaseHandler")]
		public virtual void Decrease ()
		{
			if (id_decrease == IntPtr.Zero)
				id_decrease = JNIEnv.GetMethodID (class_ref, "decrease", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_decrease);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decrease", "()V"));
		}

		static Delegate cb_increase;
#pragma warning disable 0169
		static Delegate GetIncreaseHandler ()
		{
			if (cb_increase == null)
				cb_increase = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Increase);
			return cb_increase;
		}

		static void n_Increase (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Vudroid.Core.Models.DecodingProgressModel __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Models.DecodingProgressModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Increase ();
		}
#pragma warning restore 0169

		static IntPtr id_increase;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.models']/class[@name='DecodingProgressModel']/method[@name='increase' and count(parameter)=0]"
		[Register ("increase", "()V", "GetIncreaseHandler")]
		public virtual void Increase ()
		{
			if (id_increase == IntPtr.Zero)
				id_increase = JNIEnv.GetMethodID (class_ref, "increase", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_increase);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "increase", "()V"));
		}

	}
}

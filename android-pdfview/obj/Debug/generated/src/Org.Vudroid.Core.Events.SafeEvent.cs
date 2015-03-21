using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Core.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.vudroid.core.events']/class[@name='SafeEvent']"
	[global::Android.Runtime.Register ("org/vudroid/core/events/SafeEvent", DoNotGenerateAcw=true)]
	public abstract partial class SafeEvent : global::Java.Lang.Object, global::Org.Vudroid.Core.Events.IEvent {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/vudroid/core/events/SafeEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SafeEvent); }
		}

		protected SafeEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.vudroid.core.events']/class[@name='SafeEvent']/constructor[@name='SafeEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected SafeEvent () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SafeEvent)) {
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

		static IntPtr id_dispatchOn_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.events']/class[@name='SafeEvent']/method[@name='dispatchOn' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("dispatchOn", "(Ljava/lang/Object;)V", "")]
		public void DispatchOn (global::Java.Lang.Object p0)
		{
			if (id_dispatchOn_Ljava_lang_Object_ == IntPtr.Zero)
				id_dispatchOn_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "dispatchOn", "(Ljava/lang/Object;)V");
			JNIEnv.CallVoidMethod  (Handle, id_dispatchOn_Ljava_lang_Object_, new JValue (p0));
		}

		static Delegate cb_dispatchSafely_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDispatchSafely_Ljava_lang_Object_Handler ()
		{
			if (cb_dispatchSafely_Ljava_lang_Object_ == null)
				cb_dispatchSafely_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DispatchSafely_Ljava_lang_Object_);
			return cb_dispatchSafely_Ljava_lang_Object_;
		}

		static void n_DispatchSafely_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Vudroid.Core.Events.SafeEvent __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Events.SafeEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DispatchSafely (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dispatchSafely_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.events']/class[@name='SafeEvent']/method[@name='dispatchSafely' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("dispatchSafely", "(Ljava/lang/Object;)V", "GetDispatchSafely_Ljava_lang_Object_Handler")]
		public virtual void DispatchSafely (global::Java.Lang.Object p0)
		{
			if (id_dispatchSafely_Ljava_lang_Object_ == IntPtr.Zero)
				id_dispatchSafely_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "dispatchSafely", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispatchSafely_Ljava_lang_Object_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatchSafely", "(Ljava/lang/Object;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	[global::Android.Runtime.Register ("org/vudroid/core/events/SafeEvent", DoNotGenerateAcw=true)]
	internal partial class SafeEventInvoker : SafeEvent, global::Org.Vudroid.Core.Events.IEvent {

		public SafeEventInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (SafeEventInvoker); }
		}

	}

}

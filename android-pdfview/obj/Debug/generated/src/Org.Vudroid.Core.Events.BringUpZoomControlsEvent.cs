using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Core.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.vudroid.core.events']/class[@name='BringUpZoomControlsEvent']"
	[global::Android.Runtime.Register ("org/vudroid/core/events/BringUpZoomControlsEvent", DoNotGenerateAcw=true)]
	public partial class BringUpZoomControlsEvent : global::Org.Vudroid.Core.Events.SafeEvent {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/vudroid/core/events/BringUpZoomControlsEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BringUpZoomControlsEvent); }
		}

		protected BringUpZoomControlsEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.vudroid.core.events']/class[@name='BringUpZoomControlsEvent']/constructor[@name='BringUpZoomControlsEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public BringUpZoomControlsEvent () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BringUpZoomControlsEvent)) {
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

		static Delegate cb_dispatchSafely_Lorg_vudroid_core_events_BringUpZoomControlsListener_;
#pragma warning disable 0169
		static Delegate GetDispatchSafely_Lorg_vudroid_core_events_BringUpZoomControlsListener_Handler ()
		{
			if (cb_dispatchSafely_Lorg_vudroid_core_events_BringUpZoomControlsListener_ == null)
				cb_dispatchSafely_Lorg_vudroid_core_events_BringUpZoomControlsListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DispatchSafely_Lorg_vudroid_core_events_BringUpZoomControlsListener_);
			return cb_dispatchSafely_Lorg_vudroid_core_events_BringUpZoomControlsListener_;
		}

		static void n_DispatchSafely_Lorg_vudroid_core_events_BringUpZoomControlsListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Vudroid.Core.Events.BringUpZoomControlsEvent __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Events.BringUpZoomControlsEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Vudroid.Core.Events.IBringUpZoomControlsListener p0 = (global::Org.Vudroid.Core.Events.IBringUpZoomControlsListener)global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Events.IBringUpZoomControlsListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DispatchSafely (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dispatchSafely_Lorg_vudroid_core_events_BringUpZoomControlsListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.events']/class[@name='BringUpZoomControlsEvent']/method[@name='dispatchSafely' and count(parameter)=1 and parameter[1][@type='org.vudroid.core.events.BringUpZoomControlsListener']]"
		[Register ("dispatchSafely", "(Lorg/vudroid/core/events/BringUpZoomControlsListener;)V", "GetDispatchSafely_Lorg_vudroid_core_events_BringUpZoomControlsListener_Handler")]
		public virtual void DispatchSafely (global::Org.Vudroid.Core.Events.IBringUpZoomControlsListener p0)
		{
			if (id_dispatchSafely_Lorg_vudroid_core_events_BringUpZoomControlsListener_ == IntPtr.Zero)
				id_dispatchSafely_Lorg_vudroid_core_events_BringUpZoomControlsListener_ = JNIEnv.GetMethodID (class_ref, "dispatchSafely", "(Lorg/vudroid/core/events/BringUpZoomControlsListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispatchSafely_Lorg_vudroid_core_events_BringUpZoomControlsListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatchSafely", "(Lorg/vudroid/core/events/BringUpZoomControlsListener;)V"), new JValue (p0));
		}

	}
}

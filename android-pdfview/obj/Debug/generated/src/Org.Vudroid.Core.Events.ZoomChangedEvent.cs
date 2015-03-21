using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Core.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.vudroid.core.events']/class[@name='ZoomChangedEvent']"
	[global::Android.Runtime.Register ("org/vudroid/core/events/ZoomChangedEvent", DoNotGenerateAcw=true)]
	public partial class ZoomChangedEvent : global::Org.Vudroid.Core.Events.SafeEvent {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/vudroid/core/events/ZoomChangedEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ZoomChangedEvent); }
		}

		protected ZoomChangedEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_FF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.vudroid.core.events']/class[@name='ZoomChangedEvent']/constructor[@name='ZoomChangedEvent' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register (".ctor", "(FF)V", "")]
		public ZoomChangedEvent (float p0, float p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ZoomChangedEvent)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(FF)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(FF)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_FF == IntPtr.Zero)
				id_ctor_FF = JNIEnv.GetMethodID (class_ref, "<init>", "(FF)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FF, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_FF, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_dispatchSafely_Lorg_vudroid_core_events_ZoomListener_;
#pragma warning disable 0169
		static Delegate GetDispatchSafely_Lorg_vudroid_core_events_ZoomListener_Handler ()
		{
			if (cb_dispatchSafely_Lorg_vudroid_core_events_ZoomListener_ == null)
				cb_dispatchSafely_Lorg_vudroid_core_events_ZoomListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DispatchSafely_Lorg_vudroid_core_events_ZoomListener_);
			return cb_dispatchSafely_Lorg_vudroid_core_events_ZoomListener_;
		}

		static void n_DispatchSafely_Lorg_vudroid_core_events_ZoomListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Vudroid.Core.Events.ZoomChangedEvent __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Events.ZoomChangedEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Vudroid.Core.Events.IZoomListener p0 = (global::Org.Vudroid.Core.Events.IZoomListener)global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Events.IZoomListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DispatchSafely (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dispatchSafely_Lorg_vudroid_core_events_ZoomListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.events']/class[@name='ZoomChangedEvent']/method[@name='dispatchSafely' and count(parameter)=1 and parameter[1][@type='org.vudroid.core.events.ZoomListener']]"
		[Register ("dispatchSafely", "(Lorg/vudroid/core/events/ZoomListener;)V", "GetDispatchSafely_Lorg_vudroid_core_events_ZoomListener_Handler")]
		public virtual void DispatchSafely (global::Org.Vudroid.Core.Events.IZoomListener p0)
		{
			if (id_dispatchSafely_Lorg_vudroid_core_events_ZoomListener_ == IntPtr.Zero)
				id_dispatchSafely_Lorg_vudroid_core_events_ZoomListener_ = JNIEnv.GetMethodID (class_ref, "dispatchSafely", "(Lorg/vudroid/core/events/ZoomListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispatchSafely_Lorg_vudroid_core_events_ZoomListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatchSafely", "(Lorg/vudroid/core/events/ZoomListener;)V"), new JValue (p0));
		}

	}
}

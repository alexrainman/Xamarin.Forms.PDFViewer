using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Core.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.vudroid.core.events']/class[@name='ZoomListener.CommitZoomEvent']"
	[global::Android.Runtime.Register ("org/vudroid/core/events/ZoomListener$CommitZoomEvent", DoNotGenerateAcw=true)]
	public partial class ZoomListenerCommitZoomEvent : global::Org.Vudroid.Core.Events.SafeEvent {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/vudroid/core/events/ZoomListener$CommitZoomEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ZoomListenerCommitZoomEvent); }
		}

		protected ZoomListenerCommitZoomEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.vudroid.core.events']/class[@name='ZoomListener.CommitZoomEvent']/constructor[@name='ZoomListener.CommitZoomEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ZoomListenerCommitZoomEvent () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ZoomListenerCommitZoomEvent)) {
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
			global::Org.Vudroid.Core.Events.ZoomListenerCommitZoomEvent __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Events.ZoomListenerCommitZoomEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Vudroid.Core.Events.IZoomListener p0 = (global::Org.Vudroid.Core.Events.IZoomListener)global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Events.IZoomListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DispatchSafely (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dispatchSafely_Lorg_vudroid_core_events_ZoomListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.events']/class[@name='ZoomListener.CommitZoomEvent']/method[@name='dispatchSafely' and count(parameter)=1 and parameter[1][@type='org.vudroid.core.events.ZoomListener']]"
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

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.vudroid.core.events']/interface[@name='ZoomListener']"
	[Register ("org/vudroid/core/events/ZoomListener", "", "Org.Vudroid.Core.Events.IZoomListenerInvoker")]
	public partial interface IZoomListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.events']/interface[@name='ZoomListener']/method[@name='commitZoom' and count(parameter)=0]"
		[Register ("commitZoom", "()V", "GetCommitZoomHandler:Org.Vudroid.Core.Events.IZoomListenerInvoker, android-pdfview")]
		void CommitZoom ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.events']/interface[@name='ZoomListener']/method[@name='zoomChanged' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("zoomChanged", "(FF)V", "GetZoomChanged_FFHandler:Org.Vudroid.Core.Events.IZoomListenerInvoker, android-pdfview")]
		void ZoomChanged (float p0, float p1);

	}

	[global::Android.Runtime.Register ("org/vudroid/core/events/ZoomListener", DoNotGenerateAcw=true)]
	internal class IZoomListenerInvoker : global::Java.Lang.Object, IZoomListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/vudroid/core/events/ZoomListener");
		IntPtr class_ref;

		public static IZoomListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IZoomListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.vudroid.core.events.ZoomListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IZoomListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IZoomListenerInvoker); }
		}

		static Delegate cb_commitZoom;
#pragma warning disable 0169
		static Delegate GetCommitZoomHandler ()
		{
			if (cb_commitZoom == null)
				cb_commitZoom = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CommitZoom);
			return cb_commitZoom;
		}

		static void n_CommitZoom (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Vudroid.Core.Events.IZoomListener __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Events.IZoomListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CommitZoom ();
		}
#pragma warning restore 0169

		IntPtr id_commitZoom;
		public void CommitZoom ()
		{
			if (id_commitZoom == IntPtr.Zero)
				id_commitZoom = JNIEnv.GetMethodID (class_ref, "commitZoom", "()V");
			JNIEnv.CallVoidMethod (Handle, id_commitZoom);
		}

		static Delegate cb_zoomChanged_FF;
#pragma warning disable 0169
		static Delegate GetZoomChanged_FFHandler ()
		{
			if (cb_zoomChanged_FF == null)
				cb_zoomChanged_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_ZoomChanged_FF);
			return cb_zoomChanged_FF;
		}

		static void n_ZoomChanged_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Org.Vudroid.Core.Events.IZoomListener __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Events.IZoomListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomChanged (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_zoomChanged_FF;
		public void ZoomChanged (float p0, float p1)
		{
			if (id_zoomChanged_FF == IntPtr.Zero)
				id_zoomChanged_FF = JNIEnv.GetMethodID (class_ref, "zoomChanged", "(FF)V");
			JNIEnv.CallVoidMethod (Handle, id_zoomChanged_FF, new JValue (p0), new JValue (p1));
		}

	}

	public partial class ZoomChangedEventArgs : global::System.EventArgs {

		public ZoomChangedEventArgs (float p0, float p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		float p0;
		public float P0 {
			get { return p0; }
		}

		float p1;
		public float P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/org/vudroid/core/events/ZoomListenerImplementor")]
	internal sealed class IZoomListenerImplementor : global::Java.Lang.Object, IZoomListener {

		object sender;

		public IZoomListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/vudroid/core/events/ZoomListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler CommitZoomHandler;
#pragma warning restore 0649

		public void CommitZoom ()
		{
			var __h = CommitZoomHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<ZoomChangedEventArgs> ZoomChangedHandler;
#pragma warning restore 0649

		public void ZoomChanged (float p0, float p1)
		{
			var __h = ZoomChangedHandler;
			if (__h != null)
				__h (sender, new ZoomChangedEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IZoomListenerImplementor value)
		{
			return value.CommitZoomHandler == null && value.ZoomChangedHandler == null;
		}
	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Core.Events {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.vudroid.core.events']/interface[@name='BringUpZoomControlsListener']"
	[Register ("org/vudroid/core/events/BringUpZoomControlsListener", "", "Org.Vudroid.Core.Events.IBringUpZoomControlsListenerInvoker")]
	public partial interface IBringUpZoomControlsListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.events']/interface[@name='BringUpZoomControlsListener']/method[@name='toggleZoomControls' and count(parameter)=0]"
		[Register ("toggleZoomControls", "()V", "GetToggleZoomControlsHandler:Org.Vudroid.Core.Events.IBringUpZoomControlsListenerInvoker, android-pdfview")]
		void ToggleZoomControls ();

	}

	[global::Android.Runtime.Register ("org/vudroid/core/events/BringUpZoomControlsListener", DoNotGenerateAcw=true)]
	internal class IBringUpZoomControlsListenerInvoker : global::Java.Lang.Object, IBringUpZoomControlsListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/vudroid/core/events/BringUpZoomControlsListener");
		IntPtr class_ref;

		public static IBringUpZoomControlsListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBringUpZoomControlsListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.vudroid.core.events.BringUpZoomControlsListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBringUpZoomControlsListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IBringUpZoomControlsListenerInvoker); }
		}

		static Delegate cb_toggleZoomControls;
#pragma warning disable 0169
		static Delegate GetToggleZoomControlsHandler ()
		{
			if (cb_toggleZoomControls == null)
				cb_toggleZoomControls = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ToggleZoomControls);
			return cb_toggleZoomControls;
		}

		static void n_ToggleZoomControls (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Vudroid.Core.Events.IBringUpZoomControlsListener __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Events.IBringUpZoomControlsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ToggleZoomControls ();
		}
#pragma warning restore 0169

		IntPtr id_toggleZoomControls;
		public void ToggleZoomControls ()
		{
			if (id_toggleZoomControls == IntPtr.Zero)
				id_toggleZoomControls = JNIEnv.GetMethodID (class_ref, "toggleZoomControls", "()V");
			JNIEnv.CallVoidMethod (Handle, id_toggleZoomControls);
		}

	}

	[global::Android.Runtime.Register ("mono/org/vudroid/core/events/BringUpZoomControlsListenerImplementor")]
	internal sealed class IBringUpZoomControlsListenerImplementor : global::Java.Lang.Object, IBringUpZoomControlsListener {

		object sender;

		public IBringUpZoomControlsListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/vudroid/core/events/BringUpZoomControlsListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void ToggleZoomControls ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IBringUpZoomControlsListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}

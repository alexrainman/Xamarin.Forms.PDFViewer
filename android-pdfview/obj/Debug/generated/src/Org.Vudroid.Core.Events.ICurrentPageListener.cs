using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Core.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.vudroid.core.events']/class[@name='CurrentPageListener.CurrentPageChangedEvent']"
	[global::Android.Runtime.Register ("org/vudroid/core/events/CurrentPageListener$CurrentPageChangedEvent", DoNotGenerateAcw=true)]
	public partial class CurrentPageListenerCurrentPageChangedEvent : global::Org.Vudroid.Core.Events.SafeEvent {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/vudroid/core/events/CurrentPageListener$CurrentPageChangedEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CurrentPageListenerCurrentPageChangedEvent); }
		}

		protected CurrentPageListenerCurrentPageChangedEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.vudroid.core.events']/class[@name='CurrentPageListener.CurrentPageChangedEvent']/constructor[@name='CurrentPageListener.CurrentPageChangedEvent' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public CurrentPageListenerCurrentPageChangedEvent (int p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CurrentPageListenerCurrentPageChangedEvent)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", new JValue (p0));
				return;
			}

			if (id_ctor_I == IntPtr.Zero)
				id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, new JValue (p0));
		}

		static Delegate cb_dispatchSafely_Lorg_vudroid_core_events_CurrentPageListener_;
#pragma warning disable 0169
		static Delegate GetDispatchSafely_Lorg_vudroid_core_events_CurrentPageListener_Handler ()
		{
			if (cb_dispatchSafely_Lorg_vudroid_core_events_CurrentPageListener_ == null)
				cb_dispatchSafely_Lorg_vudroid_core_events_CurrentPageListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DispatchSafely_Lorg_vudroid_core_events_CurrentPageListener_);
			return cb_dispatchSafely_Lorg_vudroid_core_events_CurrentPageListener_;
		}

		static void n_DispatchSafely_Lorg_vudroid_core_events_CurrentPageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Vudroid.Core.Events.CurrentPageListenerCurrentPageChangedEvent __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Events.CurrentPageListenerCurrentPageChangedEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Vudroid.Core.Events.ICurrentPageListener p0 = (global::Org.Vudroid.Core.Events.ICurrentPageListener)global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Events.ICurrentPageListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DispatchSafely (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dispatchSafely_Lorg_vudroid_core_events_CurrentPageListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.events']/class[@name='CurrentPageListener.CurrentPageChangedEvent']/method[@name='dispatchSafely' and count(parameter)=1 and parameter[1][@type='org.vudroid.core.events.CurrentPageListener']]"
		[Register ("dispatchSafely", "(Lorg/vudroid/core/events/CurrentPageListener;)V", "GetDispatchSafely_Lorg_vudroid_core_events_CurrentPageListener_Handler")]
		public virtual void DispatchSafely (global::Org.Vudroid.Core.Events.ICurrentPageListener p0)
		{
			if (id_dispatchSafely_Lorg_vudroid_core_events_CurrentPageListener_ == IntPtr.Zero)
				id_dispatchSafely_Lorg_vudroid_core_events_CurrentPageListener_ = JNIEnv.GetMethodID (class_ref, "dispatchSafely", "(Lorg/vudroid/core/events/CurrentPageListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispatchSafely_Lorg_vudroid_core_events_CurrentPageListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatchSafely", "(Lorg/vudroid/core/events/CurrentPageListener;)V"), new JValue (p0));
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.vudroid.core.events']/interface[@name='CurrentPageListener']"
	[Register ("org/vudroid/core/events/CurrentPageListener", "", "Org.Vudroid.Core.Events.ICurrentPageListenerInvoker")]
	public partial interface ICurrentPageListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.events']/interface[@name='CurrentPageListener']/method[@name='currentPageChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("currentPageChanged", "(I)V", "GetCurrentPageChanged_IHandler:Org.Vudroid.Core.Events.ICurrentPageListenerInvoker, android-pdfview")]
		void CurrentPageChanged (int p0);

	}

	[global::Android.Runtime.Register ("org/vudroid/core/events/CurrentPageListener", DoNotGenerateAcw=true)]
	internal class ICurrentPageListenerInvoker : global::Java.Lang.Object, ICurrentPageListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/vudroid/core/events/CurrentPageListener");
		IntPtr class_ref;

		public static ICurrentPageListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICurrentPageListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.vudroid.core.events.CurrentPageListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICurrentPageListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ICurrentPageListenerInvoker); }
		}

		static Delegate cb_currentPageChanged_I;
#pragma warning disable 0169
		static Delegate GetCurrentPageChanged_IHandler ()
		{
			if (cb_currentPageChanged_I == null)
				cb_currentPageChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_CurrentPageChanged_I);
			return cb_currentPageChanged_I;
		}

		static void n_CurrentPageChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Vudroid.Core.Events.ICurrentPageListener __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Events.ICurrentPageListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CurrentPageChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_currentPageChanged_I;
		public void CurrentPageChanged (int p0)
		{
			if (id_currentPageChanged_I == IntPtr.Zero)
				id_currentPageChanged_I = JNIEnv.GetMethodID (class_ref, "currentPageChanged", "(I)V");
			JNIEnv.CallVoidMethod (Handle, id_currentPageChanged_I, new JValue (p0));
		}

	}

	public partial class CurrentPageEventArgs : global::System.EventArgs {

		public CurrentPageEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/org/vudroid/core/events/CurrentPageListenerImplementor")]
	internal sealed class ICurrentPageListenerImplementor : global::Java.Lang.Object, ICurrentPageListener {

		object sender;

		public ICurrentPageListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/vudroid/core/events/CurrentPageListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<CurrentPageEventArgs> Handler;
#pragma warning restore 0649

		public void CurrentPageChanged (int p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new CurrentPageEventArgs (p0));
		}

		internal static bool __IsEmpty (ICurrentPageListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Core.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.vudroid.core.events']/class[@name='DecodingProgressListener.DecodingProgressEvent']"
	[global::Android.Runtime.Register ("org/vudroid/core/events/DecodingProgressListener$DecodingProgressEvent", DoNotGenerateAcw=true)]
	public partial class DecodingProgressListenerDecodingProgressEvent : global::Org.Vudroid.Core.Events.SafeEvent {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/vudroid/core/events/DecodingProgressListener$DecodingProgressEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DecodingProgressListenerDecodingProgressEvent); }
		}

		protected DecodingProgressListenerDecodingProgressEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.vudroid.core.events']/class[@name='DecodingProgressListener.DecodingProgressEvent']/constructor[@name='DecodingProgressListener.DecodingProgressEvent' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public DecodingProgressListenerDecodingProgressEvent (int p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DecodingProgressListenerDecodingProgressEvent)) {
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

		static Delegate cb_dispatchSafely_Lorg_vudroid_core_events_DecodingProgressListener_;
#pragma warning disable 0169
		static Delegate GetDispatchSafely_Lorg_vudroid_core_events_DecodingProgressListener_Handler ()
		{
			if (cb_dispatchSafely_Lorg_vudroid_core_events_DecodingProgressListener_ == null)
				cb_dispatchSafely_Lorg_vudroid_core_events_DecodingProgressListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DispatchSafely_Lorg_vudroid_core_events_DecodingProgressListener_);
			return cb_dispatchSafely_Lorg_vudroid_core_events_DecodingProgressListener_;
		}

		static void n_DispatchSafely_Lorg_vudroid_core_events_DecodingProgressListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Vudroid.Core.Events.DecodingProgressListenerDecodingProgressEvent __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Events.DecodingProgressListenerDecodingProgressEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Vudroid.Core.Events.IDecodingProgressListener p0 = (global::Org.Vudroid.Core.Events.IDecodingProgressListener)global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Events.IDecodingProgressListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DispatchSafely (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dispatchSafely_Lorg_vudroid_core_events_DecodingProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.events']/class[@name='DecodingProgressListener.DecodingProgressEvent']/method[@name='dispatchSafely' and count(parameter)=1 and parameter[1][@type='org.vudroid.core.events.DecodingProgressListener']]"
		[Register ("dispatchSafely", "(Lorg/vudroid/core/events/DecodingProgressListener;)V", "GetDispatchSafely_Lorg_vudroid_core_events_DecodingProgressListener_Handler")]
		public virtual void DispatchSafely (global::Org.Vudroid.Core.Events.IDecodingProgressListener p0)
		{
			if (id_dispatchSafely_Lorg_vudroid_core_events_DecodingProgressListener_ == IntPtr.Zero)
				id_dispatchSafely_Lorg_vudroid_core_events_DecodingProgressListener_ = JNIEnv.GetMethodID (class_ref, "dispatchSafely", "(Lorg/vudroid/core/events/DecodingProgressListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispatchSafely_Lorg_vudroid_core_events_DecodingProgressListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatchSafely", "(Lorg/vudroid/core/events/DecodingProgressListener;)V"), new JValue (p0));
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.vudroid.core.events']/interface[@name='DecodingProgressListener']"
	[Register ("org/vudroid/core/events/DecodingProgressListener", "", "Org.Vudroid.Core.Events.IDecodingProgressListenerInvoker")]
	public partial interface IDecodingProgressListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.events']/interface[@name='DecodingProgressListener']/method[@name='decodingProgressChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("decodingProgressChanged", "(I)V", "GetDecodingProgressChanged_IHandler:Org.Vudroid.Core.Events.IDecodingProgressListenerInvoker, android-pdfview")]
		void DecodingProgressChanged (int p0);

	}

	[global::Android.Runtime.Register ("org/vudroid/core/events/DecodingProgressListener", DoNotGenerateAcw=true)]
	internal class IDecodingProgressListenerInvoker : global::Java.Lang.Object, IDecodingProgressListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/vudroid/core/events/DecodingProgressListener");
		IntPtr class_ref;

		public static IDecodingProgressListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDecodingProgressListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.vudroid.core.events.DecodingProgressListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDecodingProgressListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IDecodingProgressListenerInvoker); }
		}

		static Delegate cb_decodingProgressChanged_I;
#pragma warning disable 0169
		static Delegate GetDecodingProgressChanged_IHandler ()
		{
			if (cb_decodingProgressChanged_I == null)
				cb_decodingProgressChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_DecodingProgressChanged_I);
			return cb_decodingProgressChanged_I;
		}

		static void n_DecodingProgressChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Vudroid.Core.Events.IDecodingProgressListener __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Events.IDecodingProgressListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DecodingProgressChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_decodingProgressChanged_I;
		public void DecodingProgressChanged (int p0)
		{
			if (id_decodingProgressChanged_I == IntPtr.Zero)
				id_decodingProgressChanged_I = JNIEnv.GetMethodID (class_ref, "decodingProgressChanged", "(I)V");
			JNIEnv.CallVoidMethod (Handle, id_decodingProgressChanged_I, new JValue (p0));
		}

	}

	public partial class DecodingProgressEventArgs : global::System.EventArgs {

		public DecodingProgressEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/org/vudroid/core/events/DecodingProgressListenerImplementor")]
	internal sealed class IDecodingProgressListenerImplementor : global::Java.Lang.Object, IDecodingProgressListener {

		object sender;

		public IDecodingProgressListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/vudroid/core/events/DecodingProgressListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<DecodingProgressEventArgs> Handler;
#pragma warning restore 0649

		public void DecodingProgressChanged (int p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new DecodingProgressEventArgs (p0));
		}

		internal static bool __IsEmpty (IDecodingProgressListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}

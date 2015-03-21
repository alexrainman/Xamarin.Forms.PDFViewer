using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Core.Events {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.vudroid.core.events']/interface[@name='Event']"
	[Register ("org/vudroid/core/events/Event", "", "Org.Vudroid.Core.Events.IEventInvoker")]
	public partial interface IEvent : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.events']/interface[@name='Event']/method[@name='dispatchOn' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("dispatchOn", "(Ljava/lang/Object;)V", "GetDispatchOn_Ljava_lang_Object_Handler:Org.Vudroid.Core.Events.IEventInvoker, android-pdfview")]
		void DispatchOn (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("org/vudroid/core/events/Event", DoNotGenerateAcw=true)]
	internal class IEventInvoker : global::Java.Lang.Object, IEvent {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/vudroid/core/events/Event");
		IntPtr class_ref;

		public static IEvent GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEvent> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.vudroid.core.events.Event"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEventInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IEventInvoker); }
		}

		static Delegate cb_dispatchOn_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDispatchOn_Ljava_lang_Object_Handler ()
		{
			if (cb_dispatchOn_Ljava_lang_Object_ == null)
				cb_dispatchOn_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DispatchOn_Ljava_lang_Object_);
			return cb_dispatchOn_Ljava_lang_Object_;
		}

		static void n_DispatchOn_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Vudroid.Core.Events.IEvent __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Events.IEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DispatchOn (p0);
		}
#pragma warning restore 0169

		IntPtr id_dispatchOn_Ljava_lang_Object_;
		public void DispatchOn (global::Java.Lang.Object p0)
		{
			if (id_dispatchOn_Ljava_lang_Object_ == IntPtr.Zero)
				id_dispatchOn_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "dispatchOn", "(Ljava/lang/Object;)V");
			JNIEnv.CallVoidMethod (Handle, id_dispatchOn_Ljava_lang_Object_, new JValue (p0));
		}

	}

}

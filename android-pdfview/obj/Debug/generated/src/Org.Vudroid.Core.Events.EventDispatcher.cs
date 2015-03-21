using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Core.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.vudroid.core.events']/class[@name='EventDispatcher']"
	[global::Android.Runtime.Register ("org/vudroid/core/events/EventDispatcher", DoNotGenerateAcw=true)]
	public partial class EventDispatcher : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/vudroid/core/events/EventDispatcher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventDispatcher); }
		}

		protected EventDispatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.vudroid.core.events']/class[@name='EventDispatcher']/constructor[@name='EventDispatcher' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public EventDispatcher () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (EventDispatcher)) {
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

		static Delegate cb_addEventListener_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAddEventListener_Ljava_lang_Object_Handler ()
		{
			if (cb_addEventListener_Ljava_lang_Object_ == null)
				cb_addEventListener_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddEventListener_Ljava_lang_Object_);
			return cb_addEventListener_Ljava_lang_Object_;
		}

		static void n_AddEventListener_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Vudroid.Core.Events.EventDispatcher __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Events.EventDispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddEventListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addEventListener_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.events']/class[@name='EventDispatcher']/method[@name='addEventListener' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("addEventListener", "(Ljava/lang/Object;)V", "GetAddEventListener_Ljava_lang_Object_Handler")]
		public virtual void AddEventListener (global::Java.Lang.Object p0)
		{
			if (id_addEventListener_Ljava_lang_Object_ == IntPtr.Zero)
				id_addEventListener_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "addEventListener", "(Ljava/lang/Object;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addEventListener_Ljava_lang_Object_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addEventListener", "(Ljava/lang/Object;)V"), new JValue (p0));
		}

		static Delegate cb_dispatch_Lorg_vudroid_core_events_Event_;
#pragma warning disable 0169
		static Delegate GetDispatch_Lorg_vudroid_core_events_Event_Handler ()
		{
			if (cb_dispatch_Lorg_vudroid_core_events_Event_ == null)
				cb_dispatch_Lorg_vudroid_core_events_Event_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Dispatch_Lorg_vudroid_core_events_Event_);
			return cb_dispatch_Lorg_vudroid_core_events_Event_;
		}

		static void n_Dispatch_Lorg_vudroid_core_events_Event_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Vudroid.Core.Events.EventDispatcher __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Events.EventDispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Vudroid.Core.Events.IEvent p0 = (global::Org.Vudroid.Core.Events.IEvent)global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Events.IEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Dispatch (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dispatch_Lorg_vudroid_core_events_Event_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.events']/class[@name='EventDispatcher']/method[@name='dispatch' and count(parameter)=1 and parameter[1][@type='org.vudroid.core.events.Event']]"
		[Register ("dispatch", "(Lorg/vudroid/core/events/Event;)V", "GetDispatch_Lorg_vudroid_core_events_Event_Handler")]
		public virtual void Dispatch (global::Org.Vudroid.Core.Events.IEvent p0)
		{
			if (id_dispatch_Lorg_vudroid_core_events_Event_ == IntPtr.Zero)
				id_dispatch_Lorg_vudroid_core_events_Event_ = JNIEnv.GetMethodID (class_ref, "dispatch", "(Lorg/vudroid/core/events/Event;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispatch_Lorg_vudroid_core_events_Event_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatch", "(Lorg/vudroid/core/events/Event;)V"), new JValue (p0));
		}

		static Delegate cb_removeEventListener_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemoveEventListener_Ljava_lang_Object_Handler ()
		{
			if (cb_removeEventListener_Ljava_lang_Object_ == null)
				cb_removeEventListener_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveEventListener_Ljava_lang_Object_);
			return cb_removeEventListener_Ljava_lang_Object_;
		}

		static void n_RemoveEventListener_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Vudroid.Core.Events.EventDispatcher __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Events.EventDispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveEventListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeEventListener_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.events']/class[@name='EventDispatcher']/method[@name='removeEventListener' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("removeEventListener", "(Ljava/lang/Object;)V", "GetRemoveEventListener_Ljava_lang_Object_Handler")]
		public virtual void RemoveEventListener (global::Java.Lang.Object p0)
		{
			if (id_removeEventListener_Ljava_lang_Object_ == IntPtr.Zero)
				id_removeEventListener_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "removeEventListener", "(Ljava/lang/Object;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeEventListener_Ljava_lang_Object_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeEventListener", "(Ljava/lang/Object;)V"), new JValue (p0));
		}

	}
}

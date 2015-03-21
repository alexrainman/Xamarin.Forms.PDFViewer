using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Core.Multitouch {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.vudroid.core.multitouch']/class[@name='MultiTouchZoomImpl']"
	[global::Android.Runtime.Register ("org/vudroid/core/multitouch/MultiTouchZoomImpl", DoNotGenerateAcw=true)]
	public partial class MultiTouchZoomImpl : global::Java.Lang.Object, global::Org.Vudroid.Core.Multitouch.IMultiTouchZoom {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/vudroid/core/multitouch/MultiTouchZoomImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MultiTouchZoomImpl); }
		}

		protected MultiTouchZoomImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_vudroid_core_models_ZoomModel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.vudroid.core.multitouch']/class[@name='MultiTouchZoomImpl']/constructor[@name='MultiTouchZoomImpl' and count(parameter)=1 and parameter[1][@type='org.vudroid.core.models.ZoomModel']]"
		[Register (".ctor", "(Lorg/vudroid/core/models/ZoomModel;)V", "")]
		public MultiTouchZoomImpl (global::Org.Vudroid.Core.Models.ZoomModel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MultiTouchZoomImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/vudroid/core/models/ZoomModel;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/vudroid/core/models/ZoomModel;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorg_vudroid_core_models_ZoomModel_ == IntPtr.Zero)
				id_ctor_Lorg_vudroid_core_models_ZoomModel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/vudroid/core/models/ZoomModel;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_vudroid_core_models_ZoomModel_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_vudroid_core_models_ZoomModel_, new JValue (p0));
		}

		static Delegate cb_isResetLastPointAfterZoom;
#pragma warning disable 0169
		static Delegate GetIsResetLastPointAfterZoomHandler ()
		{
			if (cb_isResetLastPointAfterZoom == null)
				cb_isResetLastPointAfterZoom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsResetLastPointAfterZoom);
			return cb_isResetLastPointAfterZoom;
		}

		static bool n_IsResetLastPointAfterZoom (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Vudroid.Core.Multitouch.MultiTouchZoomImpl __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Multitouch.MultiTouchZoomImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResetLastPointAfterZoom;
		}
#pragma warning restore 0169

		static Delegate cb_setResetLastPointAfterZoom_Z;
#pragma warning disable 0169
		static Delegate GetSetResetLastPointAfterZoom_ZHandler ()
		{
			if (cb_setResetLastPointAfterZoom_Z == null)
				cb_setResetLastPointAfterZoom_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetResetLastPointAfterZoom_Z);
			return cb_setResetLastPointAfterZoom_Z;
		}

		static void n_SetResetLastPointAfterZoom_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Vudroid.Core.Multitouch.MultiTouchZoomImpl __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Multitouch.MultiTouchZoomImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetLastPointAfterZoom = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isResetLastPointAfterZoom;
		static IntPtr id_setResetLastPointAfterZoom_Z;
		public virtual bool ResetLastPointAfterZoom {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.multitouch']/class[@name='MultiTouchZoomImpl']/method[@name='isResetLastPointAfterZoom' and count(parameter)=0]"
			[Register ("isResetLastPointAfterZoom", "()Z", "GetIsResetLastPointAfterZoomHandler")]
			get {
				if (id_isResetLastPointAfterZoom == IntPtr.Zero)
					id_isResetLastPointAfterZoom = JNIEnv.GetMethodID (class_ref, "isResetLastPointAfterZoom", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isResetLastPointAfterZoom);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isResetLastPointAfterZoom", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.multitouch']/class[@name='MultiTouchZoomImpl']/method[@name='setResetLastPointAfterZoom' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setResetLastPointAfterZoom", "(Z)V", "GetSetResetLastPointAfterZoom_ZHandler")]
			set {
				if (id_setResetLastPointAfterZoom_Z == IntPtr.Zero)
					id_setResetLastPointAfterZoom_Z = JNIEnv.GetMethodID (class_ref, "setResetLastPointAfterZoom", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setResetLastPointAfterZoom_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResetLastPointAfterZoom", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_onTouchEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouchEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouchEvent_Landroid_view_MotionEvent_ == null)
				cb_onTouchEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnTouchEvent_Landroid_view_MotionEvent_);
			return cb_onTouchEvent_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouchEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Vudroid.Core.Multitouch.MultiTouchZoomImpl __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Multitouch.MultiTouchZoomImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouchEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTouchEvent_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.multitouch']/class[@name='MultiTouchZoomImpl']/method[@name='onTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onTouchEvent", "(Landroid/view/MotionEvent;)Z", "GetOnTouchEvent_Landroid_view_MotionEvent_Handler")]
		public virtual bool OnTouchEvent (global::Android.Views.MotionEvent p0)
		{
			if (id_onTouchEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onTouchEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onTouchEvent_Landroid_view_MotionEvent_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"), new JValue (p0));
			return __ret;
		}

	}
}

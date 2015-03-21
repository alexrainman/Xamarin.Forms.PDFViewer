using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Core.Multitouch {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.vudroid.core.multitouch']/interface[@name='MultiTouchZoom']"
	[Register ("org/vudroid/core/multitouch/MultiTouchZoom", "", "Org.Vudroid.Core.Multitouch.IMultiTouchZoomInvoker")]
	public partial interface IMultiTouchZoom : IJavaObject {

		bool ResetLastPointAfterZoom {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.multitouch']/interface[@name='MultiTouchZoom']/method[@name='isResetLastPointAfterZoom' and count(parameter)=0]"
			[Register ("isResetLastPointAfterZoom", "()Z", "GetIsResetLastPointAfterZoomHandler:Org.Vudroid.Core.Multitouch.IMultiTouchZoomInvoker, android-pdfview")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.multitouch']/interface[@name='MultiTouchZoom']/method[@name='setResetLastPointAfterZoom' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setResetLastPointAfterZoom", "(Z)V", "GetSetResetLastPointAfterZoom_ZHandler:Org.Vudroid.Core.Multitouch.IMultiTouchZoomInvoker, android-pdfview")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.multitouch']/interface[@name='MultiTouchZoom']/method[@name='onTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onTouchEvent", "(Landroid/view/MotionEvent;)Z", "GetOnTouchEvent_Landroid_view_MotionEvent_Handler:Org.Vudroid.Core.Multitouch.IMultiTouchZoomInvoker, android-pdfview")]
		bool OnTouchEvent (global::Android.Views.MotionEvent p0);

	}

	[global::Android.Runtime.Register ("org/vudroid/core/multitouch/MultiTouchZoom", DoNotGenerateAcw=true)]
	internal class IMultiTouchZoomInvoker : global::Java.Lang.Object, IMultiTouchZoom {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/vudroid/core/multitouch/MultiTouchZoom");
		IntPtr class_ref;

		public static IMultiTouchZoom GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMultiTouchZoom> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.vudroid.core.multitouch.MultiTouchZoom"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMultiTouchZoomInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMultiTouchZoomInvoker); }
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
			global::Org.Vudroid.Core.Multitouch.IMultiTouchZoom __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Multitouch.IMultiTouchZoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Vudroid.Core.Multitouch.IMultiTouchZoom __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Multitouch.IMultiTouchZoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetLastPointAfterZoom = p0;
		}
#pragma warning restore 0169

		IntPtr id_isResetLastPointAfterZoom;
		IntPtr id_setResetLastPointAfterZoom_Z;
		public bool ResetLastPointAfterZoom {
			get {
				if (id_isResetLastPointAfterZoom == IntPtr.Zero)
					id_isResetLastPointAfterZoom = JNIEnv.GetMethodID (class_ref, "isResetLastPointAfterZoom", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isResetLastPointAfterZoom);
			}
			set {
				if (id_setResetLastPointAfterZoom_Z == IntPtr.Zero)
					id_setResetLastPointAfterZoom_Z = JNIEnv.GetMethodID (class_ref, "setResetLastPointAfterZoom", "(Z)V");
				JNIEnv.CallVoidMethod (Handle, id_setResetLastPointAfterZoom_Z, new JValue (value));
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
			global::Org.Vudroid.Core.Multitouch.IMultiTouchZoom __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Multitouch.IMultiTouchZoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouchEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onTouchEvent_Landroid_view_MotionEvent_;
		public bool OnTouchEvent (global::Android.Views.MotionEvent p0)
		{
			if (id_onTouchEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onTouchEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onTouchEvent_Landroid_view_MotionEvent_, new JValue (p0));
			return __ret;
		}

	}

}

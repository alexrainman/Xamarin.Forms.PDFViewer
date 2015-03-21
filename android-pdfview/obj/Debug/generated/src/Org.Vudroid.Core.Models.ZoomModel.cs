using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Core.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.vudroid.core.models']/class[@name='ZoomModel']"
	[global::Android.Runtime.Register ("org/vudroid/core/models/ZoomModel", DoNotGenerateAcw=true)]
	public partial class ZoomModel : global::Org.Vudroid.Core.Events.EventDispatcher {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/vudroid/core/models/ZoomModel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ZoomModel); }
		}

		protected ZoomModel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.vudroid.core.models']/class[@name='ZoomModel']/constructor[@name='ZoomModel' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ZoomModel () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ZoomModel)) {
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

		static Delegate cb_isHorizontalScrollEnabled;
#pragma warning disable 0169
		static Delegate GetIsHorizontalScrollEnabledHandler ()
		{
			if (cb_isHorizontalScrollEnabled == null)
				cb_isHorizontalScrollEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHorizontalScrollEnabled);
			return cb_isHorizontalScrollEnabled;
		}

		static bool n_IsHorizontalScrollEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Vudroid.Core.Models.ZoomModel __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Models.ZoomModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HorizontalScrollEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setHorizontalScrollEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetHorizontalScrollEnabled_ZHandler ()
		{
			if (cb_setHorizontalScrollEnabled_Z == null)
				cb_setHorizontalScrollEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHorizontalScrollEnabled_Z);
			return cb_setHorizontalScrollEnabled_Z;
		}

		static void n_SetHorizontalScrollEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Vudroid.Core.Models.ZoomModel __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Models.ZoomModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HorizontalScrollEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isHorizontalScrollEnabled;
		static IntPtr id_setHorizontalScrollEnabled_Z;
		public virtual bool HorizontalScrollEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.models']/class[@name='ZoomModel']/method[@name='isHorizontalScrollEnabled' and count(parameter)=0]"
			[Register ("isHorizontalScrollEnabled", "()Z", "GetIsHorizontalScrollEnabledHandler")]
			get {
				if (id_isHorizontalScrollEnabled == IntPtr.Zero)
					id_isHorizontalScrollEnabled = JNIEnv.GetMethodID (class_ref, "isHorizontalScrollEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isHorizontalScrollEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isHorizontalScrollEnabled", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.models']/class[@name='ZoomModel']/method[@name='setHorizontalScrollEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHorizontalScrollEnabled", "(Z)V", "GetSetHorizontalScrollEnabled_ZHandler")]
			set {
				if (id_setHorizontalScrollEnabled_Z == IntPtr.Zero)
					id_setHorizontalScrollEnabled_Z = JNIEnv.GetMethodID (class_ref, "setHorizontalScrollEnabled", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setHorizontalScrollEnabled_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHorizontalScrollEnabled", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_getZoom;
#pragma warning disable 0169
		static Delegate GetGetZoomHandler ()
		{
			if (cb_getZoom == null)
				cb_getZoom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetZoom);
			return cb_getZoom;
		}

		static float n_GetZoom (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Vudroid.Core.Models.ZoomModel __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Models.ZoomModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Zoom;
		}
#pragma warning restore 0169

		static Delegate cb_setZoom_F;
#pragma warning disable 0169
		static Delegate GetSetZoom_FHandler ()
		{
			if (cb_setZoom_F == null)
				cb_setZoom_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetZoom_F);
			return cb_setZoom_F;
		}

		static void n_SetZoom_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Org.Vudroid.Core.Models.ZoomModel __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Models.ZoomModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Zoom = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getZoom;
		static IntPtr id_setZoom_F;
		public virtual float Zoom {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.models']/class[@name='ZoomModel']/method[@name='getZoom' and count(parameter)=0]"
			[Register ("getZoom", "()F", "GetGetZoomHandler")]
			get {
				if (id_getZoom == IntPtr.Zero)
					id_getZoom = JNIEnv.GetMethodID (class_ref, "getZoom", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getZoom);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getZoom", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.models']/class[@name='ZoomModel']/method[@name='setZoom' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setZoom", "(F)V", "GetSetZoom_FHandler")]
			set {
				if (id_setZoom_F == IntPtr.Zero)
					id_setZoom_F = JNIEnv.GetMethodID (class_ref, "setZoom", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setZoom_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZoom", "(F)V"), new JValue (value));
			}
		}

		static Delegate cb_canDecrement;
#pragma warning disable 0169
		static Delegate GetCanDecrementHandler ()
		{
			if (cb_canDecrement == null)
				cb_canDecrement = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanDecrement);
			return cb_canDecrement;
		}

		static bool n_CanDecrement (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Vudroid.Core.Models.ZoomModel __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Models.ZoomModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanDecrement ();
		}
#pragma warning restore 0169

		static IntPtr id_canDecrement;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.models']/class[@name='ZoomModel']/method[@name='canDecrement' and count(parameter)=0]"
		[Register ("canDecrement", "()Z", "GetCanDecrementHandler")]
		public virtual bool CanDecrement ()
		{
			if (id_canDecrement == IntPtr.Zero)
				id_canDecrement = JNIEnv.GetMethodID (class_ref, "canDecrement", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_canDecrement);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canDecrement", "()Z"));
		}

		static Delegate cb_commit;
#pragma warning disable 0169
		static Delegate GetCommitHandler ()
		{
			if (cb_commit == null)
				cb_commit = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Commit);
			return cb_commit;
		}

		static void n_Commit (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Vudroid.Core.Models.ZoomModel __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Models.ZoomModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Commit ();
		}
#pragma warning restore 0169

		static IntPtr id_commit;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.models']/class[@name='ZoomModel']/method[@name='commit' and count(parameter)=0]"
		[Register ("commit", "()V", "GetCommitHandler")]
		public virtual void Commit ()
		{
			if (id_commit == IntPtr.Zero)
				id_commit = JNIEnv.GetMethodID (class_ref, "commit", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_commit);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "commit", "()V"));
		}

		static Delegate cb_decreaseZoom;
#pragma warning disable 0169
		static Delegate GetDecreaseZoomHandler ()
		{
			if (cb_decreaseZoom == null)
				cb_decreaseZoom = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DecreaseZoom);
			return cb_decreaseZoom;
		}

		static void n_DecreaseZoom (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Vudroid.Core.Models.ZoomModel __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Models.ZoomModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DecreaseZoom ();
		}
#pragma warning restore 0169

		static IntPtr id_decreaseZoom;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.models']/class[@name='ZoomModel']/method[@name='decreaseZoom' and count(parameter)=0]"
		[Register ("decreaseZoom", "()V", "GetDecreaseZoomHandler")]
		public virtual void DecreaseZoom ()
		{
			if (id_decreaseZoom == IntPtr.Zero)
				id_decreaseZoom = JNIEnv.GetMethodID (class_ref, "decreaseZoom", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_decreaseZoom);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decreaseZoom", "()V"));
		}

		static Delegate cb_increaseZoom;
#pragma warning disable 0169
		static Delegate GetIncreaseZoomHandler ()
		{
			if (cb_increaseZoom == null)
				cb_increaseZoom = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_IncreaseZoom);
			return cb_increaseZoom;
		}

		static void n_IncreaseZoom (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Vudroid.Core.Models.ZoomModel __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Models.ZoomModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IncreaseZoom ();
		}
#pragma warning restore 0169

		static IntPtr id_increaseZoom;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.models']/class[@name='ZoomModel']/method[@name='increaseZoom' and count(parameter)=0]"
		[Register ("increaseZoom", "()V", "GetIncreaseZoomHandler")]
		public virtual void IncreaseZoom ()
		{
			if (id_increaseZoom == IntPtr.Zero)
				id_increaseZoom = JNIEnv.GetMethodID (class_ref, "increaseZoom", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_increaseZoom);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "increaseZoom", "()V"));
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
			global::Org.Vudroid.Core.Models.ZoomModel __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Models.ZoomModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ToggleZoomControls ();
		}
#pragma warning restore 0169

		static IntPtr id_toggleZoomControls;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.models']/class[@name='ZoomModel']/method[@name='toggleZoomControls' and count(parameter)=0]"
		[Register ("toggleZoomControls", "()V", "GetToggleZoomControlsHandler")]
		public virtual void ToggleZoomControls ()
		{
			if (id_toggleZoomControls == IntPtr.Zero)
				id_toggleZoomControls = JNIEnv.GetMethodID (class_ref, "toggleZoomControls", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_toggleZoomControls);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toggleZoomControls", "()V"));
		}

	}
}

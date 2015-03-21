using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Joanzapata.Pdfview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']"
	[global::Android.Runtime.Register ("com/joanzapata/pdfview/PDFView", DoNotGenerateAcw=true)]
	public partial class PDFView : global::Android.Views.SurfaceView {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView.Configurator']"
		[global::Android.Runtime.Register ("com/joanzapata/pdfview/PDFView$Configurator", DoNotGenerateAcw=true)]
		public partial class Configurator : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/joanzapata/pdfview/PDFView$Configurator", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Configurator); }
			}

			protected Configurator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_defaultPage_I;
#pragma warning disable 0169
			static Delegate GetDefaultPage_IHandler ()
			{
				if (cb_defaultPage_I == null)
					cb_defaultPage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_DefaultPage_I);
				return cb_defaultPage_I;
			}

			static IntPtr n_DefaultPage_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Joanzapata.Pdfview.PDFView.Configurator __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.DefaultPage (p0));
			}
#pragma warning restore 0169

			static IntPtr id_defaultPage_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView.Configurator']/method[@name='defaultPage' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("defaultPage", "(I)Lcom/joanzapata/pdfview/PDFView$Configurator;", "GetDefaultPage_IHandler")]
			public virtual global::Com.Joanzapata.Pdfview.PDFView.Configurator DefaultPage (int p0)
			{
				if (id_defaultPage_I == IntPtr.Zero)
					id_defaultPage_I = JNIEnv.GetMethodID (class_ref, "defaultPage", "(I)Lcom/joanzapata/pdfview/PDFView$Configurator;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (JNIEnv.CallObjectMethod  (Handle, id_defaultPage_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "defaultPage", "(I)Lcom/joanzapata/pdfview/PDFView$Configurator;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_enableSwipe_Z;
#pragma warning disable 0169
			static Delegate GetEnableSwipe_ZHandler ()
			{
				if (cb_enableSwipe_Z == null)
					cb_enableSwipe_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_EnableSwipe_Z);
				return cb_enableSwipe_Z;
			}

			static IntPtr n_EnableSwipe_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Joanzapata.Pdfview.PDFView.Configurator __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.EnableSwipe (p0));
			}
#pragma warning restore 0169

			static IntPtr id_enableSwipe_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView.Configurator']/method[@name='enableSwipe' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("enableSwipe", "(Z)Lcom/joanzapata/pdfview/PDFView$Configurator;", "GetEnableSwipe_ZHandler")]
			public virtual global::Com.Joanzapata.Pdfview.PDFView.Configurator EnableSwipe (bool p0)
			{
				if (id_enableSwipe_Z == IntPtr.Zero)
					id_enableSwipe_Z = JNIEnv.GetMethodID (class_ref, "enableSwipe", "(Z)Lcom/joanzapata/pdfview/PDFView$Configurator;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (JNIEnv.CallObjectMethod  (Handle, id_enableSwipe_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableSwipe", "(Z)Lcom/joanzapata/pdfview/PDFView$Configurator;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_load;
#pragma warning disable 0169
			static Delegate GetLoadHandler ()
			{
				if (cb_load == null)
					cb_load = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Load);
				return cb_load;
			}

			static void n_Load (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Joanzapata.Pdfview.PDFView.Configurator __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Load ();
			}
#pragma warning restore 0169

			static IntPtr id_load;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView.Configurator']/method[@name='load' and count(parameter)=0]"
			[Register ("load", "()V", "GetLoadHandler")]
			public virtual void Load ()
			{
				if (id_load == IntPtr.Zero)
					id_load = JNIEnv.GetMethodID (class_ref, "load", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_load);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "load", "()V"));
			}

			static Delegate cb_onDraw_Lcom_joanzapata_pdfview_listener_OnDrawListener_;
#pragma warning disable 0169
			static Delegate GetOnDraw_Lcom_joanzapata_pdfview_listener_OnDrawListener_Handler ()
			{
				if (cb_onDraw_Lcom_joanzapata_pdfview_listener_OnDrawListener_ == null)
					cb_onDraw_Lcom_joanzapata_pdfview_listener_OnDrawListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDraw_Lcom_joanzapata_pdfview_listener_OnDrawListener_);
				return cb_onDraw_Lcom_joanzapata_pdfview_listener_OnDrawListener_;
			}

			static IntPtr n_OnDraw_Lcom_joanzapata_pdfview_listener_OnDrawListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Joanzapata.Pdfview.PDFView.Configurator __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Joanzapata.Pdfview.Listener.IOnDrawListener p0 = (global::Com.Joanzapata.Pdfview.Listener.IOnDrawListener)global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Listener.IOnDrawListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnDraw (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onDraw_Lcom_joanzapata_pdfview_listener_OnDrawListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView.Configurator']/method[@name='onDraw' and count(parameter)=1 and parameter[1][@type='com.joanzapata.pdfview.listener.OnDrawListener']]"
			[Register ("onDraw", "(Lcom/joanzapata/pdfview/listener/OnDrawListener;)Lcom/joanzapata/pdfview/PDFView$Configurator;", "GetOnDraw_Lcom_joanzapata_pdfview_listener_OnDrawListener_Handler")]
			public virtual global::Com.Joanzapata.Pdfview.PDFView.Configurator OnDraw (global::Com.Joanzapata.Pdfview.Listener.IOnDrawListener p0)
			{
				if (id_onDraw_Lcom_joanzapata_pdfview_listener_OnDrawListener_ == IntPtr.Zero)
					id_onDraw_Lcom_joanzapata_pdfview_listener_OnDrawListener_ = JNIEnv.GetMethodID (class_ref, "onDraw", "(Lcom/joanzapata/pdfview/listener/OnDrawListener;)Lcom/joanzapata/pdfview/PDFView$Configurator;");

				global::Com.Joanzapata.Pdfview.PDFView.Configurator __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (JNIEnv.CallObjectMethod  (Handle, id_onDraw_Lcom_joanzapata_pdfview_listener_OnDrawListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDraw", "(Lcom/joanzapata/pdfview/listener/OnDrawListener;)Lcom/joanzapata/pdfview/PDFView$Configurator;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_onLoad_Lcom_joanzapata_pdfview_listener_OnLoadCompleteListener_;
#pragma warning disable 0169
			static Delegate GetOnLoad_Lcom_joanzapata_pdfview_listener_OnLoadCompleteListener_Handler ()
			{
				if (cb_onLoad_Lcom_joanzapata_pdfview_listener_OnLoadCompleteListener_ == null)
					cb_onLoad_Lcom_joanzapata_pdfview_listener_OnLoadCompleteListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLoad_Lcom_joanzapata_pdfview_listener_OnLoadCompleteListener_);
				return cb_onLoad_Lcom_joanzapata_pdfview_listener_OnLoadCompleteListener_;
			}

			static IntPtr n_OnLoad_Lcom_joanzapata_pdfview_listener_OnLoadCompleteListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Joanzapata.Pdfview.PDFView.Configurator __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Joanzapata.Pdfview.Listener.IOnLoadCompleteListener p0 = (global::Com.Joanzapata.Pdfview.Listener.IOnLoadCompleteListener)global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Listener.IOnLoadCompleteListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnLoad (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onLoad_Lcom_joanzapata_pdfview_listener_OnLoadCompleteListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView.Configurator']/method[@name='onLoad' and count(parameter)=1 and parameter[1][@type='com.joanzapata.pdfview.listener.OnLoadCompleteListener']]"
			[Register ("onLoad", "(Lcom/joanzapata/pdfview/listener/OnLoadCompleteListener;)Lcom/joanzapata/pdfview/PDFView$Configurator;", "GetOnLoad_Lcom_joanzapata_pdfview_listener_OnLoadCompleteListener_Handler")]
			public virtual global::Com.Joanzapata.Pdfview.PDFView.Configurator OnLoad (global::Com.Joanzapata.Pdfview.Listener.IOnLoadCompleteListener p0)
			{
				if (id_onLoad_Lcom_joanzapata_pdfview_listener_OnLoadCompleteListener_ == IntPtr.Zero)
					id_onLoad_Lcom_joanzapata_pdfview_listener_OnLoadCompleteListener_ = JNIEnv.GetMethodID (class_ref, "onLoad", "(Lcom/joanzapata/pdfview/listener/OnLoadCompleteListener;)Lcom/joanzapata/pdfview/PDFView$Configurator;");

				global::Com.Joanzapata.Pdfview.PDFView.Configurator __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (JNIEnv.CallObjectMethod  (Handle, id_onLoad_Lcom_joanzapata_pdfview_listener_OnLoadCompleteListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLoad", "(Lcom/joanzapata/pdfview/listener/OnLoadCompleteListener;)Lcom/joanzapata/pdfview/PDFView$Configurator;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_onPageChange_Lcom_joanzapata_pdfview_listener_OnPageChangeListener_;
#pragma warning disable 0169
			static Delegate GetOnPageChange_Lcom_joanzapata_pdfview_listener_OnPageChangeListener_Handler ()
			{
				if (cb_onPageChange_Lcom_joanzapata_pdfview_listener_OnPageChangeListener_ == null)
					cb_onPageChange_Lcom_joanzapata_pdfview_listener_OnPageChangeListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPageChange_Lcom_joanzapata_pdfview_listener_OnPageChangeListener_);
				return cb_onPageChange_Lcom_joanzapata_pdfview_listener_OnPageChangeListener_;
			}

			static IntPtr n_OnPageChange_Lcom_joanzapata_pdfview_listener_OnPageChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Joanzapata.Pdfview.PDFView.Configurator __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Joanzapata.Pdfview.Listener.IOnPageChangeListener p0 = (global::Com.Joanzapata.Pdfview.Listener.IOnPageChangeListener)global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Listener.IOnPageChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnPageChange (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onPageChange_Lcom_joanzapata_pdfview_listener_OnPageChangeListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView.Configurator']/method[@name='onPageChange' and count(parameter)=1 and parameter[1][@type='com.joanzapata.pdfview.listener.OnPageChangeListener']]"
			[Register ("onPageChange", "(Lcom/joanzapata/pdfview/listener/OnPageChangeListener;)Lcom/joanzapata/pdfview/PDFView$Configurator;", "GetOnPageChange_Lcom_joanzapata_pdfview_listener_OnPageChangeListener_Handler")]
			public virtual global::Com.Joanzapata.Pdfview.PDFView.Configurator OnPageChange (global::Com.Joanzapata.Pdfview.Listener.IOnPageChangeListener p0)
			{
				if (id_onPageChange_Lcom_joanzapata_pdfview_listener_OnPageChangeListener_ == IntPtr.Zero)
					id_onPageChange_Lcom_joanzapata_pdfview_listener_OnPageChangeListener_ = JNIEnv.GetMethodID (class_ref, "onPageChange", "(Lcom/joanzapata/pdfview/listener/OnPageChangeListener;)Lcom/joanzapata/pdfview/PDFView$Configurator;");

				global::Com.Joanzapata.Pdfview.PDFView.Configurator __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (JNIEnv.CallObjectMethod  (Handle, id_onPageChange_Lcom_joanzapata_pdfview_listener_OnPageChangeListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPageChange", "(Lcom/joanzapata/pdfview/listener/OnPageChangeListener;)Lcom/joanzapata/pdfview/PDFView$Configurator;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_pages_arrayI;
#pragma warning disable 0169
			static Delegate GetPages_arrayIHandler ()
			{
				if (cb_pages_arrayI == null)
					cb_pages_arrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Pages_arrayI);
				return cb_pages_arrayI;
			}

			static IntPtr n_Pages_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Joanzapata.Pdfview.PDFView.Configurator __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Pages (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_pages_arrayI;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView.Configurator']/method[@name='pages' and count(parameter)=1 and parameter[1][@type='int...']]"
			[Register ("pages", "([I)Lcom/joanzapata/pdfview/PDFView$Configurator;", "GetPages_arrayIHandler")]
			public virtual global::Com.Joanzapata.Pdfview.PDFView.Configurator Pages (params  int[] p0)
			{
				if (id_pages_arrayI == IntPtr.Zero)
					id_pages_arrayI = JNIEnv.GetMethodID (class_ref, "pages", "([I)Lcom/joanzapata/pdfview/PDFView$Configurator;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);

				global::Com.Joanzapata.Pdfview.PDFView.Configurator __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (JNIEnv.CallObjectMethod  (Handle, id_pages_arrayI, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pages", "([I)Lcom/joanzapata/pdfview/PDFView$Configurator;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static Delegate cb_showMinimap_Z;
#pragma warning disable 0169
			static Delegate GetShowMinimap_ZHandler ()
			{
				if (cb_showMinimap_Z == null)
					cb_showMinimap_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_ShowMinimap_Z);
				return cb_showMinimap_Z;
			}

			static IntPtr n_ShowMinimap_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Joanzapata.Pdfview.PDFView.Configurator __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ShowMinimap (p0));
			}
#pragma warning restore 0169

			static IntPtr id_showMinimap_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView.Configurator']/method[@name='showMinimap' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("showMinimap", "(Z)Lcom/joanzapata/pdfview/PDFView$Configurator;", "GetShowMinimap_ZHandler")]
			public virtual global::Com.Joanzapata.Pdfview.PDFView.Configurator ShowMinimap (bool p0)
			{
				if (id_showMinimap_Z == IntPtr.Zero)
					id_showMinimap_Z = JNIEnv.GetMethodID (class_ref, "showMinimap", "(Z)Lcom/joanzapata/pdfview/PDFView$Configurator;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (JNIEnv.CallObjectMethod  (Handle, id_showMinimap_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showMinimap", "(Z)Lcom/joanzapata/pdfview/PDFView$Configurator;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView.State']"
		[global::Android.Runtime.Register ("com/joanzapata/pdfview/PDFView$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {


			static IntPtr DEFAULT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView.State']/field[@name='DEFAULT']"
			[Register ("DEFAULT")]
			public static global::Com.Joanzapata.Pdfview.PDFView.State Default {
				get {
					if (DEFAULT_jfieldId == IntPtr.Zero)
						DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lcom/joanzapata/pdfview/PDFView$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DEFAULT_jfieldId == IntPtr.Zero)
						DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lcom/joanzapata/pdfview/PDFView$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DEFAULT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr LOADED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView.State']/field[@name='LOADED']"
			[Register ("LOADED")]
			public static global::Com.Joanzapata.Pdfview.PDFView.State Loaded {
				get {
					if (LOADED_jfieldId == IntPtr.Zero)
						LOADED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOADED", "Lcom/joanzapata/pdfview/PDFView$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOADED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (LOADED_jfieldId == IntPtr.Zero)
						LOADED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOADED", "Lcom/joanzapata/pdfview/PDFView$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, LOADED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr SHOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView.State']/field[@name='SHOWN']"
			[Register ("SHOWN")]
			public static global::Com.Joanzapata.Pdfview.PDFView.State Shown {
				get {
					if (SHOWN_jfieldId == IntPtr.Zero)
						SHOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHOWN", "Lcom/joanzapata/pdfview/PDFView$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SHOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (SHOWN_jfieldId == IntPtr.Zero)
						SHOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHOWN", "Lcom/joanzapata/pdfview/PDFView$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, SHOWN_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/joanzapata/pdfview/PDFView$State", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (State); }
			}

			internal State (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/joanzapata/pdfview/PDFView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PDFView); }
		}

		protected PDFView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/constructor[@name='PDFView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public PDFView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PDFView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getCurrentPage;
#pragma warning disable 0169
		static Delegate GetGetCurrentPageHandler ()
		{
			if (cb_getCurrentPage == null)
				cb_getCurrentPage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentPage);
			return cb_getCurrentPage;
		}

		static int n_GetCurrentPage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Joanzapata.Pdfview.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentPage;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentPage;
		public virtual int CurrentPage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/method[@name='getCurrentPage' and count(parameter)=0]"
			[Register ("getCurrentPage", "()I", "GetGetCurrentPageHandler")]
			get {
				if (id_getCurrentPage == IntPtr.Zero)
					id_getCurrentPage = JNIEnv.GetMethodID (class_ref, "getCurrentPage", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getCurrentPage);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentPage", "()I"));
			}
		}

		static Delegate cb_getCurrentXOffset;
#pragma warning disable 0169
		static Delegate GetGetCurrentXOffsetHandler ()
		{
			if (cb_getCurrentXOffset == null)
				cb_getCurrentXOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetCurrentXOffset);
			return cb_getCurrentXOffset;
		}

		static float n_GetCurrentXOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Joanzapata.Pdfview.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentXOffset;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentXOffset;
		public virtual float CurrentXOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/method[@name='getCurrentXOffset' and count(parameter)=0]"
			[Register ("getCurrentXOffset", "()F", "GetGetCurrentXOffsetHandler")]
			get {
				if (id_getCurrentXOffset == IntPtr.Zero)
					id_getCurrentXOffset = JNIEnv.GetMethodID (class_ref, "getCurrentXOffset", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getCurrentXOffset);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentXOffset", "()F"));
			}
		}

		static Delegate cb_getCurrentYOffset;
#pragma warning disable 0169
		static Delegate GetGetCurrentYOffsetHandler ()
		{
			if (cb_getCurrentYOffset == null)
				cb_getCurrentYOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetCurrentYOffset);
			return cb_getCurrentYOffset;
		}

		static float n_GetCurrentYOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Joanzapata.Pdfview.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentYOffset;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentYOffset;
		public virtual float CurrentYOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/method[@name='getCurrentYOffset' and count(parameter)=0]"
			[Register ("getCurrentYOffset", "()F", "GetGetCurrentYOffsetHandler")]
			get {
				if (id_getCurrentYOffset == IntPtr.Zero)
					id_getCurrentYOffset = JNIEnv.GetMethodID (class_ref, "getCurrentYOffset", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getCurrentYOffset);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentYOffset", "()F"));
			}
		}

		static Delegate cb_isZooming;
#pragma warning disable 0169
		static Delegate GetIsZoomingHandler ()
		{
			if (cb_isZooming == null)
				cb_isZooming = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsZooming);
			return cb_isZooming;
		}

		static bool n_IsZooming (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Joanzapata.Pdfview.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsZooming;
		}
#pragma warning restore 0169

		static IntPtr id_isZooming;
		public virtual bool IsZooming {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/method[@name='isZooming' and count(parameter)=0]"
			[Register ("isZooming", "()Z", "GetIsZoomingHandler")]
			get {
				if (id_isZooming == IntPtr.Zero)
					id_isZooming = JNIEnv.GetMethodID (class_ref, "isZooming", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isZooming);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isZooming", "()Z"));
			}
		}

		static Delegate cb_getOptimalPageWidth;
#pragma warning disable 0169
		static Delegate GetGetOptimalPageWidthHandler ()
		{
			if (cb_getOptimalPageWidth == null)
				cb_getOptimalPageWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetOptimalPageWidth);
			return cb_getOptimalPageWidth;
		}

		static float n_GetOptimalPageWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Joanzapata.Pdfview.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OptimalPageWidth;
		}
#pragma warning restore 0169

		static IntPtr id_getOptimalPageWidth;
		public virtual float OptimalPageWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/method[@name='getOptimalPageWidth' and count(parameter)=0]"
			[Register ("getOptimalPageWidth", "()F", "GetGetOptimalPageWidthHandler")]
			get {
				if (id_getOptimalPageWidth == IntPtr.Zero)
					id_getOptimalPageWidth = JNIEnv.GetMethodID (class_ref, "getOptimalPageWidth", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getOptimalPageWidth);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOptimalPageWidth", "()F"));
			}
		}

		static Delegate cb_getPageCount;
#pragma warning disable 0169
		static Delegate GetGetPageCountHandler ()
		{
			if (cb_getPageCount == null)
				cb_getPageCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPageCount);
			return cb_getPageCount;
		}

		static int n_GetPageCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Joanzapata.Pdfview.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PageCount;
		}
#pragma warning restore 0169

		static IntPtr id_getPageCount;
		public virtual int PageCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/method[@name='getPageCount' and count(parameter)=0]"
			[Register ("getPageCount", "()I", "GetGetPageCountHandler")]
			get {
				if (id_getPageCount == IntPtr.Zero)
					id_getPageCount = JNIEnv.GetMethodID (class_ref, "getPageCount", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getPageCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPageCount", "()I"));
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
			global::Com.Joanzapata.Pdfview.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Zoom;
		}
#pragma warning restore 0169

		static IntPtr id_getZoom;
		public virtual float Zoom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/method[@name='getZoom' and count(parameter)=0]"
			[Register ("getZoom", "()F", "GetGetZoomHandler")]
			get {
				if (id_getZoom == IntPtr.Zero)
					id_getZoom = JNIEnv.GetMethodID (class_ref, "getZoom", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getZoom);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getZoom", "()F"));
			}
		}

		static Delegate cb_enableSwipe_Z;
#pragma warning disable 0169
		static Delegate GetEnableSwipe_ZHandler ()
		{
			if (cb_enableSwipe_Z == null)
				cb_enableSwipe_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_EnableSwipe_Z);
			return cb_enableSwipe_Z;
		}

		static void n_EnableSwipe_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Joanzapata.Pdfview.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableSwipe (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enableSwipe_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/method[@name='enableSwipe' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableSwipe", "(Z)V", "GetEnableSwipe_ZHandler")]
		public virtual void EnableSwipe (bool p0)
		{
			if (id_enableSwipe_Z == IntPtr.Zero)
				id_enableSwipe_Z = JNIEnv.GetMethodID (class_ref, "enableSwipe", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_enableSwipe_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableSwipe", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_fromAsset_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFromAsset_Ljava_lang_String_Handler ()
		{
			if (cb_fromAsset_Ljava_lang_String_ == null)
				cb_fromAsset_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FromAsset_Ljava_lang_String_);
			return cb_fromAsset_Ljava_lang_String_;
		}

		static IntPtr n_FromAsset_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Joanzapata.Pdfview.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FromAsset (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_fromAsset_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/method[@name='fromAsset' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromAsset", "(Ljava/lang/String;)Lcom/joanzapata/pdfview/PDFView$Configurator;", "GetFromAsset_Ljava_lang_String_Handler")]
		public virtual global::Com.Joanzapata.Pdfview.PDFView.Configurator FromAsset (string p0)
		{
			if (id_fromAsset_Ljava_lang_String_ == IntPtr.Zero)
				id_fromAsset_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "fromAsset", "(Ljava/lang/String;)Lcom/joanzapata/pdfview/PDFView$Configurator;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Joanzapata.Pdfview.PDFView.Configurator __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (JNIEnv.CallObjectMethod  (Handle, id_fromAsset_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fromAsset", "(Ljava/lang/String;)Lcom/joanzapata/pdfview/PDFView$Configurator;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_fromFile_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetFromFile_Ljava_io_File_Handler ()
		{
			if (cb_fromFile_Ljava_io_File_ == null)
				cb_fromFile_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FromFile_Ljava_io_File_);
			return cb_fromFile_Ljava_io_File_;
		}

		static IntPtr n_FromFile_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Joanzapata.Pdfview.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FromFile (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_fromFile_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/method[@name='fromFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("fromFile", "(Ljava/io/File;)Lcom/joanzapata/pdfview/PDFView$Configurator;", "GetFromFile_Ljava_io_File_Handler")]
		public virtual global::Com.Joanzapata.Pdfview.PDFView.Configurator FromFile (global::Java.IO.File p0)
		{
			if (id_fromFile_Ljava_io_File_ == IntPtr.Zero)
				id_fromFile_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "fromFile", "(Ljava/io/File;)Lcom/joanzapata/pdfview/PDFView$Configurator;");

			global::Com.Joanzapata.Pdfview.PDFView.Configurator __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (JNIEnv.CallObjectMethod  (Handle, id_fromFile_Ljava_io_File_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView.Configurator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fromFile", "(Ljava/io/File;)Lcom/joanzapata/pdfview/PDFView$Configurator;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_jumpTo_I;
#pragma warning disable 0169
		static Delegate GetJumpTo_IHandler ()
		{
			if (cb_jumpTo_I == null)
				cb_jumpTo_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_JumpTo_I);
			return cb_jumpTo_I;
		}

		static void n_JumpTo_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Joanzapata.Pdfview.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.JumpTo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_jumpTo_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/method[@name='jumpTo' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("jumpTo", "(I)V", "GetJumpTo_IHandler")]
		public virtual void JumpTo (int p0)
		{
			if (id_jumpTo_I == IntPtr.Zero)
				id_jumpTo_I = JNIEnv.GetMethodID (class_ref, "jumpTo", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_jumpTo_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "jumpTo", "(I)V"), new JValue (p0));
		}

		static Delegate cb_loadComplete_Lorg_vudroid_core_DecodeService_;
#pragma warning disable 0169
		static Delegate GetLoadComplete_Lorg_vudroid_core_DecodeService_Handler ()
		{
			if (cb_loadComplete_Lorg_vudroid_core_DecodeService_ == null)
				cb_loadComplete_Lorg_vudroid_core_DecodeService_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadComplete_Lorg_vudroid_core_DecodeService_);
			return cb_loadComplete_Lorg_vudroid_core_DecodeService_;
		}

		static void n_LoadComplete_Lorg_vudroid_core_DecodeService_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Joanzapata.Pdfview.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Vudroid.Core.IDecodeService p0 = (global::Org.Vudroid.Core.IDecodeService)global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.IDecodeService> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadComplete (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadComplete_Lorg_vudroid_core_DecodeService_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/method[@name='loadComplete' and count(parameter)=1 and parameter[1][@type='org.vudroid.core.DecodeService']]"
		[Register ("loadComplete", "(Lorg/vudroid/core/DecodeService;)V", "GetLoadComplete_Lorg_vudroid_core_DecodeService_Handler")]
		public virtual void LoadComplete (global::Org.Vudroid.Core.IDecodeService p0)
		{
			if (id_loadComplete_Lorg_vudroid_core_DecodeService_ == IntPtr.Zero)
				id_loadComplete_Lorg_vudroid_core_DecodeService_ = JNIEnv.GetMethodID (class_ref, "loadComplete", "(Lorg/vudroid/core/DecodeService;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadComplete_Lorg_vudroid_core_DecodeService_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadComplete", "(Lorg/vudroid/core/DecodeService;)V"), new JValue (p0));
		}

		static Delegate cb_loadPages;
#pragma warning disable 0169
		static Delegate GetLoadPagesHandler ()
		{
			if (cb_loadPages == null)
				cb_loadPages = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LoadPages);
			return cb_loadPages;
		}

		static void n_LoadPages (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Joanzapata.Pdfview.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoadPages ();
		}
#pragma warning restore 0169

		static IntPtr id_loadPages;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/method[@name='loadPages' and count(parameter)=0]"
		[Register ("loadPages", "()V", "GetLoadPagesHandler")]
		public virtual void LoadPages ()
		{
			if (id_loadPages == IntPtr.Zero)
				id_loadPages = JNIEnv.GetMethodID (class_ref, "loadPages", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadPages);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadPages", "()V"));
		}

		static Delegate cb_moveRelativeTo_FF;
#pragma warning disable 0169
		static Delegate GetMoveRelativeTo_FFHandler ()
		{
			if (cb_moveRelativeTo_FF == null)
				cb_moveRelativeTo_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_MoveRelativeTo_FF);
			return cb_moveRelativeTo_FF;
		}

		static void n_MoveRelativeTo_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Com.Joanzapata.Pdfview.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MoveRelativeTo (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_moveRelativeTo_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/method[@name='moveRelativeTo' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("moveRelativeTo", "(FF)V", "GetMoveRelativeTo_FFHandler")]
		public virtual void MoveRelativeTo (float p0, float p1)
		{
			if (id_moveRelativeTo_FF == IntPtr.Zero)
				id_moveRelativeTo_FF = JNIEnv.GetMethodID (class_ref, "moveRelativeTo", "(FF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_moveRelativeTo_FF, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moveRelativeTo", "(FF)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_moveTo_FF;
#pragma warning disable 0169
		static Delegate GetMoveTo_FFHandler ()
		{
			if (cb_moveTo_FF == null)
				cb_moveTo_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_MoveTo_FF);
			return cb_moveTo_FF;
		}

		static void n_MoveTo_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Com.Joanzapata.Pdfview.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MoveTo (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_moveTo_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/method[@name='moveTo' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("moveTo", "(FF)V", "GetMoveTo_FFHandler")]
		public virtual void MoveTo (float p0, float p1)
		{
			if (id_moveTo_FF == IntPtr.Zero)
				id_moveTo_FF = JNIEnv.GetMethodID (class_ref, "moveTo", "(FF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_moveTo_FF, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moveTo", "(FF)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_onBitmapRendered_Lcom_joanzapata_pdfview_model_PagePart_;
#pragma warning disable 0169
		static Delegate GetOnBitmapRendered_Lcom_joanzapata_pdfview_model_PagePart_Handler ()
		{
			if (cb_onBitmapRendered_Lcom_joanzapata_pdfview_model_PagePart_ == null)
				cb_onBitmapRendered_Lcom_joanzapata_pdfview_model_PagePart_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBitmapRendered_Lcom_joanzapata_pdfview_model_PagePart_);
			return cb_onBitmapRendered_Lcom_joanzapata_pdfview_model_PagePart_;
		}

		static void n_OnBitmapRendered_Lcom_joanzapata_pdfview_model_PagePart_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Joanzapata.Pdfview.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Joanzapata.Pdfview.Model.PagePart p0 = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Model.PagePart> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBitmapRendered (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onBitmapRendered_Lcom_joanzapata_pdfview_model_PagePart_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/method[@name='onBitmapRendered' and count(parameter)=1 and parameter[1][@type='com.joanzapata.pdfview.model.PagePart']]"
		[Register ("onBitmapRendered", "(Lcom/joanzapata/pdfview/model/PagePart;)V", "GetOnBitmapRendered_Lcom_joanzapata_pdfview_model_PagePart_Handler")]
		public virtual void OnBitmapRendered (global::Com.Joanzapata.Pdfview.Model.PagePart p0)
		{
			if (id_onBitmapRendered_Lcom_joanzapata_pdfview_model_PagePart_ == IntPtr.Zero)
				id_onBitmapRendered_Lcom_joanzapata_pdfview_model_PagePart_ = JNIEnv.GetMethodID (class_ref, "onBitmapRendered", "(Lcom/joanzapata/pdfview/model/PagePart;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onBitmapRendered_Lcom_joanzapata_pdfview_model_PagePart_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBitmapRendered", "(Lcom/joanzapata/pdfview/model/PagePart;)V"), new JValue (p0));
		}

		static Delegate cb_onLayerUpdate;
#pragma warning disable 0169
		static Delegate GetOnLayerUpdateHandler ()
		{
			if (cb_onLayerUpdate == null)
				cb_onLayerUpdate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLayerUpdate);
			return cb_onLayerUpdate;
		}

		static void n_OnLayerUpdate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Joanzapata.Pdfview.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLayerUpdate ();
		}
#pragma warning restore 0169

		static IntPtr id_onLayerUpdate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/method[@name='onLayerUpdate' and count(parameter)=0]"
		[Register ("onLayerUpdate", "()V", "GetOnLayerUpdateHandler")]
		public virtual void OnLayerUpdate ()
		{
			if (id_onLayerUpdate == IntPtr.Zero)
				id_onLayerUpdate = JNIEnv.GetMethodID (class_ref, "onLayerUpdate", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onLayerUpdate);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLayerUpdate", "()V"));
		}

		static Delegate cb_recycle;
#pragma warning disable 0169
		static Delegate GetRecycleHandler ()
		{
			if (cb_recycle == null)
				cb_recycle = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Recycle);
			return cb_recycle;
		}

		static void n_Recycle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Joanzapata.Pdfview.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Recycle ();
		}
#pragma warning restore 0169

		static IntPtr id_recycle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/method[@name='recycle' and count(parameter)=0]"
		[Register ("recycle", "()V", "GetRecycleHandler")]
		public virtual void Recycle ()
		{
			if (id_recycle == IntPtr.Zero)
				id_recycle = JNIEnv.GetMethodID (class_ref, "recycle", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_recycle);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recycle", "()V"));
		}

		static Delegate cb_resetZoom;
#pragma warning disable 0169
		static Delegate GetResetZoomHandler ()
		{
			if (cb_resetZoom == null)
				cb_resetZoom = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetZoom);
			return cb_resetZoom;
		}

		static void n_ResetZoom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Joanzapata.Pdfview.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetZoom ();
		}
#pragma warning restore 0169

		static IntPtr id_resetZoom;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/method[@name='resetZoom' and count(parameter)=0]"
		[Register ("resetZoom", "()V", "GetResetZoomHandler")]
		public virtual void ResetZoom ()
		{
			if (id_resetZoom == IntPtr.Zero)
				id_resetZoom = JNIEnv.GetMethodID (class_ref, "resetZoom", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_resetZoom);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetZoom", "()V"));
		}

		static Delegate cb_resetZoomWithAnimation;
#pragma warning disable 0169
		static Delegate GetResetZoomWithAnimationHandler ()
		{
			if (cb_resetZoomWithAnimation == null)
				cb_resetZoomWithAnimation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetZoomWithAnimation);
			return cb_resetZoomWithAnimation;
		}

		static void n_ResetZoomWithAnimation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Joanzapata.Pdfview.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetZoomWithAnimation ();
		}
#pragma warning restore 0169

		static IntPtr id_resetZoomWithAnimation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/method[@name='resetZoomWithAnimation' and count(parameter)=0]"
		[Register ("resetZoomWithAnimation", "()V", "GetResetZoomWithAnimationHandler")]
		public virtual void ResetZoomWithAnimation ()
		{
			if (id_resetZoomWithAnimation == IntPtr.Zero)
				id_resetZoomWithAnimation = JNIEnv.GetMethodID (class_ref, "resetZoomWithAnimation", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_resetZoomWithAnimation);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetZoomWithAnimation", "()V"));
		}

		static Delegate cb_toCurrentScale_F;
#pragma warning disable 0169
		static Delegate GetToCurrentScale_FHandler ()
		{
			if (cb_toCurrentScale_F == null)
				cb_toCurrentScale_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float>) n_ToCurrentScale_F);
			return cb_toCurrentScale_F;
		}

		static float n_ToCurrentScale_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Joanzapata.Pdfview.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ToCurrentScale (p0);
		}
#pragma warning restore 0169

		static IntPtr id_toCurrentScale_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/method[@name='toCurrentScale' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("toCurrentScale", "(F)F", "GetToCurrentScale_FHandler")]
		public virtual float ToCurrentScale (float p0)
		{
			if (id_toCurrentScale_F == IntPtr.Zero)
				id_toCurrentScale_F = JNIEnv.GetMethodID (class_ref, "toCurrentScale", "(F)F");

			if (GetType () == ThresholdType)
				return JNIEnv.CallFloatMethod  (Handle, id_toCurrentScale_F, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toCurrentScale", "(F)F"), new JValue (p0));
		}

		static Delegate cb_toRealScale_F;
#pragma warning disable 0169
		static Delegate GetToRealScale_FHandler ()
		{
			if (cb_toRealScale_F == null)
				cb_toRealScale_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float>) n_ToRealScale_F);
			return cb_toRealScale_F;
		}

		static float n_ToRealScale_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Joanzapata.Pdfview.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ToRealScale (p0);
		}
#pragma warning restore 0169

		static IntPtr id_toRealScale_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/method[@name='toRealScale' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("toRealScale", "(F)F", "GetToRealScale_FHandler")]
		public virtual float ToRealScale (float p0)
		{
			if (id_toRealScale_F == IntPtr.Zero)
				id_toRealScale_F = JNIEnv.GetMethodID (class_ref, "toRealScale", "(F)F");

			if (GetType () == ThresholdType)
				return JNIEnv.CallFloatMethod  (Handle, id_toRealScale_F, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toRealScale", "(F)F"), new JValue (p0));
		}

		static Delegate cb_zoomCenteredRelativeTo_FLandroid_graphics_PointF_;
#pragma warning disable 0169
		static Delegate GetZoomCenteredRelativeTo_FLandroid_graphics_PointF_Handler ()
		{
			if (cb_zoomCenteredRelativeTo_FLandroid_graphics_PointF_ == null)
				cb_zoomCenteredRelativeTo_FLandroid_graphics_PointF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, IntPtr>) n_ZoomCenteredRelativeTo_FLandroid_graphics_PointF_);
			return cb_zoomCenteredRelativeTo_FLandroid_graphics_PointF_;
		}

		static void n_ZoomCenteredRelativeTo_FLandroid_graphics_PointF_ (IntPtr jnienv, IntPtr native__this, float p0, IntPtr native_p1)
		{
			global::Com.Joanzapata.Pdfview.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.PointF p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ZoomCenteredRelativeTo (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_zoomCenteredRelativeTo_FLandroid_graphics_PointF_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/method[@name='zoomCenteredRelativeTo' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='android.graphics.PointF']]"
		[Register ("zoomCenteredRelativeTo", "(FLandroid/graphics/PointF;)V", "GetZoomCenteredRelativeTo_FLandroid_graphics_PointF_Handler")]
		public virtual void ZoomCenteredRelativeTo (float p0, global::Android.Graphics.PointF p1)
		{
			if (id_zoomCenteredRelativeTo_FLandroid_graphics_PointF_ == IntPtr.Zero)
				id_zoomCenteredRelativeTo_FLandroid_graphics_PointF_ = JNIEnv.GetMethodID (class_ref, "zoomCenteredRelativeTo", "(FLandroid/graphics/PointF;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_zoomCenteredRelativeTo_FLandroid_graphics_PointF_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomCenteredRelativeTo", "(FLandroid/graphics/PointF;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_zoomCenteredTo_FLandroid_graphics_PointF_;
#pragma warning disable 0169
		static Delegate GetZoomCenteredTo_FLandroid_graphics_PointF_Handler ()
		{
			if (cb_zoomCenteredTo_FLandroid_graphics_PointF_ == null)
				cb_zoomCenteredTo_FLandroid_graphics_PointF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, IntPtr>) n_ZoomCenteredTo_FLandroid_graphics_PointF_);
			return cb_zoomCenteredTo_FLandroid_graphics_PointF_;
		}

		static void n_ZoomCenteredTo_FLandroid_graphics_PointF_ (IntPtr jnienv, IntPtr native__this, float p0, IntPtr native_p1)
		{
			global::Com.Joanzapata.Pdfview.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.PointF p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ZoomCenteredTo (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_zoomCenteredTo_FLandroid_graphics_PointF_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/method[@name='zoomCenteredTo' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='android.graphics.PointF']]"
		[Register ("zoomCenteredTo", "(FLandroid/graphics/PointF;)V", "GetZoomCenteredTo_FLandroid_graphics_PointF_Handler")]
		public virtual void ZoomCenteredTo (float p0, global::Android.Graphics.PointF p1)
		{
			if (id_zoomCenteredTo_FLandroid_graphics_PointF_ == IntPtr.Zero)
				id_zoomCenteredTo_FLandroid_graphics_PointF_ = JNIEnv.GetMethodID (class_ref, "zoomCenteredTo", "(FLandroid/graphics/PointF;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_zoomCenteredTo_FLandroid_graphics_PointF_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomCenteredTo", "(FLandroid/graphics/PointF;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_zoomTo_F;
#pragma warning disable 0169
		static Delegate GetZoomTo_FHandler ()
		{
			if (cb_zoomTo_F == null)
				cb_zoomTo_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_ZoomTo_F);
			return cb_zoomTo_F;
		}

		static void n_ZoomTo_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Joanzapata.Pdfview.PDFView __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.PDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomTo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_zoomTo_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview']/class[@name='PDFView']/method[@name='zoomTo' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("zoomTo", "(F)V", "GetZoomTo_FHandler")]
		public virtual void ZoomTo (float p0)
		{
			if (id_zoomTo_F == IntPtr.Zero)
				id_zoomTo_F = JNIEnv.GetMethodID (class_ref, "zoomTo", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_zoomTo_F, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomTo", "(F)V"), new JValue (p0));
		}

	}
}

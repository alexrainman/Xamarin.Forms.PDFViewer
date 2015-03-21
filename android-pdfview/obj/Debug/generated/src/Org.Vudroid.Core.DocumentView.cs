using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.vudroid.core']/class[@name='DocumentView']"
	[global::Android.Runtime.Register ("org/vudroid/core/DocumentView", DoNotGenerateAcw=true)]
	public partial class DocumentView : global::Android.Views.View, global::Org.Vudroid.Core.Events.IZoomListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/vudroid/core/DocumentView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DocumentView); }
		}

		protected DocumentView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lorg_vudroid_core_models_ZoomModel_Lorg_vudroid_core_models_DecodingProgressModel_Lorg_vudroid_core_models_CurrentPageModel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.vudroid.core']/class[@name='DocumentView']/constructor[@name='DocumentView' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.vudroid.core.models.ZoomModel'] and parameter[3][@type='org.vudroid.core.models.DecodingProgressModel'] and parameter[4][@type='org.vudroid.core.models.CurrentPageModel']]"
		[Register (".ctor", "(Landroid/content/Context;Lorg/vudroid/core/models/ZoomModel;Lorg/vudroid/core/models/DecodingProgressModel;Lorg/vudroid/core/models/CurrentPageModel;)V", "")]
		public DocumentView (global::Android.Content.Context p0, global::Org.Vudroid.Core.Models.ZoomModel p1, global::Org.Vudroid.Core.Models.DecodingProgressModel p2, global::Org.Vudroid.Core.Models.CurrentPageModel p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DocumentView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lorg/vudroid/core/models/ZoomModel;Lorg/vudroid/core/models/DecodingProgressModel;Lorg/vudroid/core/models/CurrentPageModel;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lorg/vudroid/core/models/ZoomModel;Lorg/vudroid/core/models/DecodingProgressModel;Lorg/vudroid/core/models/CurrentPageModel;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				return;
			}

			if (id_ctor_Landroid_content_Context_Lorg_vudroid_core_models_ZoomModel_Lorg_vudroid_core_models_DecodingProgressModel_Lorg_vudroid_core_models_CurrentPageModel_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lorg_vudroid_core_models_ZoomModel_Lorg_vudroid_core_models_DecodingProgressModel_Lorg_vudroid_core_models_CurrentPageModel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lorg/vudroid/core/models/ZoomModel;Lorg/vudroid/core/models/DecodingProgressModel;Lorg/vudroid/core/models/CurrentPageModel;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lorg_vudroid_core_models_ZoomModel_Lorg_vudroid_core_models_DecodingProgressModel_Lorg_vudroid_core_models_CurrentPageModel_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lorg_vudroid_core_models_ZoomModel_Lorg_vudroid_core_models_DecodingProgressModel_Lorg_vudroid_core_models_CurrentPageModel_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
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
			global::Org.Vudroid.Core.DocumentView __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.DocumentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentPage;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentPage;
		public virtual int CurrentPage {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/class[@name='DocumentView']/method[@name='getCurrentPage' and count(parameter)=0]"
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
			global::Org.Vudroid.Core.DocumentView __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.DocumentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CommitZoom ();
		}
#pragma warning restore 0169

		static IntPtr id_commitZoom;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/class[@name='DocumentView']/method[@name='commitZoom' and count(parameter)=0]"
		[Register ("commitZoom", "()V", "GetCommitZoomHandler")]
		public virtual void CommitZoom ()
		{
			if (id_commitZoom == IntPtr.Zero)
				id_commitZoom = JNIEnv.GetMethodID (class_ref, "commitZoom", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_commitZoom);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "commitZoom", "()V"));
		}

		static Delegate cb_goToPage_I;
#pragma warning disable 0169
		static Delegate GetGoToPage_IHandler ()
		{
			if (cb_goToPage_I == null)
				cb_goToPage_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_GoToPage_I);
			return cb_goToPage_I;
		}

		static void n_GoToPage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Vudroid.Core.DocumentView __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.DocumentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GoToPage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_goToPage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/class[@name='DocumentView']/method[@name='goToPage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("goToPage", "(I)V", "GetGoToPage_IHandler")]
		public virtual void GoToPage (int p0)
		{
			if (id_goToPage_I == IntPtr.Zero)
				id_goToPage_I = JNIEnv.GetMethodID (class_ref, "goToPage", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_goToPage_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "goToPage", "(I)V"), new JValue (p0));
		}

		static Delegate cb_setDecodeService_Lorg_vudroid_core_DecodeService_;
#pragma warning disable 0169
		static Delegate GetSetDecodeService_Lorg_vudroid_core_DecodeService_Handler ()
		{
			if (cb_setDecodeService_Lorg_vudroid_core_DecodeService_ == null)
				cb_setDecodeService_Lorg_vudroid_core_DecodeService_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDecodeService_Lorg_vudroid_core_DecodeService_);
			return cb_setDecodeService_Lorg_vudroid_core_DecodeService_;
		}

		static void n_SetDecodeService_Lorg_vudroid_core_DecodeService_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Vudroid.Core.DocumentView __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.DocumentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Vudroid.Core.IDecodeService p0 = (global::Org.Vudroid.Core.IDecodeService)global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.IDecodeService> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDecodeService (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDecodeService_Lorg_vudroid_core_DecodeService_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/class[@name='DocumentView']/method[@name='setDecodeService' and count(parameter)=1 and parameter[1][@type='org.vudroid.core.DecodeService']]"
		[Register ("setDecodeService", "(Lorg/vudroid/core/DecodeService;)V", "GetSetDecodeService_Lorg_vudroid_core_DecodeService_Handler")]
		public virtual void SetDecodeService (global::Org.Vudroid.Core.IDecodeService p0)
		{
			if (id_setDecodeService_Lorg_vudroid_core_DecodeService_ == IntPtr.Zero)
				id_setDecodeService_Lorg_vudroid_core_DecodeService_ = JNIEnv.GetMethodID (class_ref, "setDecodeService", "(Lorg/vudroid/core/DecodeService;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setDecodeService_Lorg_vudroid_core_DecodeService_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDecodeService", "(Lorg/vudroid/core/DecodeService;)V"), new JValue (p0));
		}

		static Delegate cb_showDocument;
#pragma warning disable 0169
		static Delegate GetShowDocumentHandler ()
		{
			if (cb_showDocument == null)
				cb_showDocument = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowDocument);
			return cb_showDocument;
		}

		static void n_ShowDocument (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Vudroid.Core.DocumentView __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.DocumentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowDocument ();
		}
#pragma warning restore 0169

		static IntPtr id_showDocument;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/class[@name='DocumentView']/method[@name='showDocument' and count(parameter)=0]"
		[Register ("showDocument", "()V", "GetShowDocumentHandler")]
		public virtual void ShowDocument ()
		{
			if (id_showDocument == IntPtr.Zero)
				id_showDocument = JNIEnv.GetMethodID (class_ref, "showDocument", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_showDocument);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showDocument", "()V"));
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
			global::Org.Vudroid.Core.DocumentView __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.DocumentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomChanged (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_zoomChanged_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/class[@name='DocumentView']/method[@name='zoomChanged' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("zoomChanged", "(FF)V", "GetZoomChanged_FFHandler")]
		public virtual void ZoomChanged (float p0, float p1)
		{
			if (id_zoomChanged_FF == IntPtr.Zero)
				id_zoomChanged_FF = JNIEnv.GetMethodID (class_ref, "zoomChanged", "(FF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_zoomChanged_FF, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomChanged", "(FF)V"), new JValue (p0), new JValue (p1));
		}

	}
}

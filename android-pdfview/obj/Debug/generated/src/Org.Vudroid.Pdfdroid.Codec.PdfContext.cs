using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Pdfdroid.Codec {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.vudroid.pdfdroid.codec']/class[@name='PdfContext']"
	[global::Android.Runtime.Register ("org/vudroid/pdfdroid/codec/PdfContext", DoNotGenerateAcw=true)]
	public partial class PdfContext : global::Java.Lang.Object, global::Org.Vudroid.Core.Codec.ICodecContext {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/vudroid/pdfdroid/codec/PdfContext", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PdfContext); }
		}

		protected PdfContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.vudroid.pdfdroid.codec']/class[@name='PdfContext']/constructor[@name='PdfContext' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public PdfContext () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PdfContext)) {
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

		static Delegate cb_openDocument_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpenDocument_Ljava_lang_String_Handler ()
		{
			if (cb_openDocument_Ljava_lang_String_ == null)
				cb_openDocument_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OpenDocument_Ljava_lang_String_);
			return cb_openDocument_Ljava_lang_String_;
		}

		static IntPtr n_OpenDocument_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Vudroid.Pdfdroid.Codec.PdfContext __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Pdfdroid.Codec.PdfContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OpenDocument (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_openDocument_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.pdfdroid.codec']/class[@name='PdfContext']/method[@name='openDocument' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("openDocument", "(Ljava/lang/String;)Lorg/vudroid/core/codec/CodecDocument;", "GetOpenDocument_Ljava_lang_String_Handler")]
		public virtual global::Org.Vudroid.Core.Codec.ICodecDocument OpenDocument (string p0)
		{
			if (id_openDocument_Ljava_lang_String_ == IntPtr.Zero)
				id_openDocument_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "openDocument", "(Ljava/lang/String;)Lorg/vudroid/core/codec/CodecDocument;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Org.Vudroid.Core.Codec.ICodecDocument __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Codec.ICodecDocument> (JNIEnv.CallObjectMethod  (Handle, id_openDocument_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Codec.ICodecDocument> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openDocument", "(Ljava/lang/String;)Lorg/vudroid/core/codec/CodecDocument;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
			global::Org.Vudroid.Pdfdroid.Codec.PdfContext __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Pdfdroid.Codec.PdfContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Recycle ();
		}
#pragma warning restore 0169

		static IntPtr id_recycle;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.pdfdroid.codec']/class[@name='PdfContext']/method[@name='recycle' and count(parameter)=0]"
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

		static Delegate cb_setContentResolver_Landroid_content_ContentResolver_;
#pragma warning disable 0169
		static Delegate GetSetContentResolver_Landroid_content_ContentResolver_Handler ()
		{
			if (cb_setContentResolver_Landroid_content_ContentResolver_ == null)
				cb_setContentResolver_Landroid_content_ContentResolver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentResolver_Landroid_content_ContentResolver_);
			return cb_setContentResolver_Landroid_content_ContentResolver_;
		}

		static void n_SetContentResolver_Landroid_content_ContentResolver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Vudroid.Pdfdroid.Codec.PdfContext __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Pdfdroid.Codec.PdfContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentResolver p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentResolver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetContentResolver (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setContentResolver_Landroid_content_ContentResolver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.pdfdroid.codec']/class[@name='PdfContext']/method[@name='setContentResolver' and count(parameter)=1 and parameter[1][@type='android.content.ContentResolver']]"
		[Register ("setContentResolver", "(Landroid/content/ContentResolver;)V", "GetSetContentResolver_Landroid_content_ContentResolver_Handler")]
		public virtual void SetContentResolver (global::Android.Content.ContentResolver p0)
		{
			if (id_setContentResolver_Landroid_content_ContentResolver_ == IntPtr.Zero)
				id_setContentResolver_Landroid_content_ContentResolver_ = JNIEnv.GetMethodID (class_ref, "setContentResolver", "(Landroid/content/ContentResolver;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setContentResolver_Landroid_content_ContentResolver_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentResolver", "(Landroid/content/ContentResolver;)V"), new JValue (p0));
		}

	}
}

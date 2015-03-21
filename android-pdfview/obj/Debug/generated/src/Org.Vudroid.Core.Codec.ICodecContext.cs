using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Core.Codec {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.vudroid.core.codec']/interface[@name='CodecContext']"
	[Register ("org/vudroid/core/codec/CodecContext", "", "Org.Vudroid.Core.Codec.ICodecContextInvoker")]
	public partial interface ICodecContext : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.codec']/interface[@name='CodecContext']/method[@name='openDocument' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("openDocument", "(Ljava/lang/String;)Lorg/vudroid/core/codec/CodecDocument;", "GetOpenDocument_Ljava_lang_String_Handler:Org.Vudroid.Core.Codec.ICodecContextInvoker, android-pdfview")]
		global::Org.Vudroid.Core.Codec.ICodecDocument OpenDocument (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.codec']/interface[@name='CodecContext']/method[@name='recycle' and count(parameter)=0]"
		[Register ("recycle", "()V", "GetRecycleHandler:Org.Vudroid.Core.Codec.ICodecContextInvoker, android-pdfview")]
		void Recycle ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.codec']/interface[@name='CodecContext']/method[@name='setContentResolver' and count(parameter)=1 and parameter[1][@type='android.content.ContentResolver']]"
		[Register ("setContentResolver", "(Landroid/content/ContentResolver;)V", "GetSetContentResolver_Landroid_content_ContentResolver_Handler:Org.Vudroid.Core.Codec.ICodecContextInvoker, android-pdfview")]
		void SetContentResolver (global::Android.Content.ContentResolver p0);

	}

	[global::Android.Runtime.Register ("org/vudroid/core/codec/CodecContext", DoNotGenerateAcw=true)]
	internal class ICodecContextInvoker : global::Java.Lang.Object, ICodecContext {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/vudroid/core/codec/CodecContext");
		IntPtr class_ref;

		public static ICodecContext GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICodecContext> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.vudroid.core.codec.CodecContext"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICodecContextInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ICodecContextInvoker); }
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
			global::Org.Vudroid.Core.Codec.ICodecContext __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Codec.ICodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OpenDocument (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_openDocument_Ljava_lang_String_;
		public global::Org.Vudroid.Core.Codec.ICodecDocument OpenDocument (string p0)
		{
			if (id_openDocument_Ljava_lang_String_ == IntPtr.Zero)
				id_openDocument_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "openDocument", "(Ljava/lang/String;)Lorg/vudroid/core/codec/CodecDocument;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Org.Vudroid.Core.Codec.ICodecDocument __ret = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Codec.ICodecDocument> (JNIEnv.CallObjectMethod (Handle, id_openDocument_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Vudroid.Core.Codec.ICodecContext __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Codec.ICodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Recycle ();
		}
#pragma warning restore 0169

		IntPtr id_recycle;
		public void Recycle ()
		{
			if (id_recycle == IntPtr.Zero)
				id_recycle = JNIEnv.GetMethodID (class_ref, "recycle", "()V");
			JNIEnv.CallVoidMethod (Handle, id_recycle);
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
			global::Org.Vudroid.Core.Codec.ICodecContext __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Codec.ICodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentResolver p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentResolver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetContentResolver (p0);
		}
#pragma warning restore 0169

		IntPtr id_setContentResolver_Landroid_content_ContentResolver_;
		public void SetContentResolver (global::Android.Content.ContentResolver p0)
		{
			if (id_setContentResolver_Landroid_content_ContentResolver_ == IntPtr.Zero)
				id_setContentResolver_Landroid_content_ContentResolver_ = JNIEnv.GetMethodID (class_ref, "setContentResolver", "(Landroid/content/ContentResolver;)V");
			JNIEnv.CallVoidMethod (Handle, id_setContentResolver_Landroid_content_ContentResolver_, new JValue (p0));
		}

	}

}

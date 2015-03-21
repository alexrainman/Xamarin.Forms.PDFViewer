using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Pdfdroid.Codec {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.vudroid.pdfdroid.codec']/class[@name='PdfDocument']"
	[global::Android.Runtime.Register ("org/vudroid/pdfdroid/codec/PdfDocument", DoNotGenerateAcw=true)]
	public partial class PdfDocument : global::Java.Lang.Object, global::Org.Vudroid.Core.Codec.ICodecDocument {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/vudroid/pdfdroid/codec/PdfDocument", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PdfDocument); }
		}

		protected PdfDocument (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Org.Vudroid.Pdfdroid.Codec.PdfDocument __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Pdfdroid.Codec.PdfDocument> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PageCount;
		}
#pragma warning restore 0169

		static IntPtr id_getPageCount;
		public virtual int PageCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.pdfdroid.codec']/class[@name='PdfDocument']/method[@name='getPageCount' and count(parameter)=0]"
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

		static Delegate cb_getPage_I;
#pragma warning disable 0169
		static Delegate GetGetPage_IHandler ()
		{
			if (cb_getPage_I == null)
				cb_getPage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetPage_I);
			return cb_getPage_I;
		}

		static IntPtr n_GetPage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Vudroid.Pdfdroid.Codec.PdfDocument __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Pdfdroid.Codec.PdfDocument> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetPage (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getPage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.pdfdroid.codec']/class[@name='PdfDocument']/method[@name='getPage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPage", "(I)Lorg/vudroid/core/codec/CodecPage;", "GetGetPage_IHandler")]
		public virtual global::Org.Vudroid.Core.Codec.ICodecPage GetPage (int p0)
		{
			if (id_getPage_I == IntPtr.Zero)
				id_getPage_I = JNIEnv.GetMethodID (class_ref, "getPage", "(I)Lorg/vudroid/core/codec/CodecPage;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Codec.ICodecPage> (JNIEnv.CallObjectMethod  (Handle, id_getPage_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Codec.ICodecPage> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPage", "(I)Lorg/vudroid/core/codec/CodecPage;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Vudroid.Pdfdroid.Codec.PdfDocument __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Pdfdroid.Codec.PdfDocument> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Recycle ();
		}
#pragma warning restore 0169

		static IntPtr id_recycle;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.pdfdroid.codec']/class[@name='PdfDocument']/method[@name='recycle' and count(parameter)=0]"
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

	}
}

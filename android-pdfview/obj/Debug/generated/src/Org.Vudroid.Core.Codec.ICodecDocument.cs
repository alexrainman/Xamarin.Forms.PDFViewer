using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Core.Codec {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.vudroid.core.codec']/interface[@name='CodecDocument']"
	[Register ("org/vudroid/core/codec/CodecDocument", "", "Org.Vudroid.Core.Codec.ICodecDocumentInvoker")]
	public partial interface ICodecDocument : IJavaObject {

		int PageCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.codec']/interface[@name='CodecDocument']/method[@name='getPageCount' and count(parameter)=0]"
			[Register ("getPageCount", "()I", "GetGetPageCountHandler:Org.Vudroid.Core.Codec.ICodecDocumentInvoker, android-pdfview")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.codec']/interface[@name='CodecDocument']/method[@name='getPage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPage", "(I)Lorg/vudroid/core/codec/CodecPage;", "GetGetPage_IHandler:Org.Vudroid.Core.Codec.ICodecDocumentInvoker, android-pdfview")]
		global::Org.Vudroid.Core.Codec.ICodecPage GetPage (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.codec']/interface[@name='CodecDocument']/method[@name='recycle' and count(parameter)=0]"
		[Register ("recycle", "()V", "GetRecycleHandler:Org.Vudroid.Core.Codec.ICodecDocumentInvoker, android-pdfview")]
		void Recycle ();

	}

	[global::Android.Runtime.Register ("org/vudroid/core/codec/CodecDocument", DoNotGenerateAcw=true)]
	internal class ICodecDocumentInvoker : global::Java.Lang.Object, ICodecDocument {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/vudroid/core/codec/CodecDocument");
		IntPtr class_ref;

		public static ICodecDocument GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICodecDocument> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.vudroid.core.codec.CodecDocument"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICodecDocumentInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ICodecDocumentInvoker); }
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
			global::Org.Vudroid.Core.Codec.ICodecDocument __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Codec.ICodecDocument> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PageCount;
		}
#pragma warning restore 0169

		IntPtr id_getPageCount;
		public int PageCount {
			get {
				if (id_getPageCount == IntPtr.Zero)
					id_getPageCount = JNIEnv.GetMethodID (class_ref, "getPageCount", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getPageCount);
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
			global::Org.Vudroid.Core.Codec.ICodecDocument __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Codec.ICodecDocument> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetPage (p0));
		}
#pragma warning restore 0169

		IntPtr id_getPage_I;
		public global::Org.Vudroid.Core.Codec.ICodecPage GetPage (int p0)
		{
			if (id_getPage_I == IntPtr.Zero)
				id_getPage_I = JNIEnv.GetMethodID (class_ref, "getPage", "(I)Lorg/vudroid/core/codec/CodecPage;");
			return global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Codec.ICodecPage> (JNIEnv.CallObjectMethod (Handle, id_getPage_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Vudroid.Core.Codec.ICodecDocument __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Codec.ICodecDocument> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	}

}

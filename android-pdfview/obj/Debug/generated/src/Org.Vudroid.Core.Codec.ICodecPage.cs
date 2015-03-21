using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Core.Codec {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.vudroid.core.codec']/interface[@name='CodecPage']"
	[Register ("org/vudroid/core/codec/CodecPage", "", "Org.Vudroid.Core.Codec.ICodecPageInvoker")]
	public partial interface ICodecPage : IJavaObject {

		int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.codec']/interface[@name='CodecPage']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler:Org.Vudroid.Core.Codec.ICodecPageInvoker, android-pdfview")] get;
		}

		bool IsDecoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.codec']/interface[@name='CodecPage']/method[@name='isDecoding' and count(parameter)=0]"
			[Register ("isDecoding", "()Z", "GetIsDecodingHandler:Org.Vudroid.Core.Codec.ICodecPageInvoker, android-pdfview")] get;
		}

		int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.codec']/interface[@name='CodecPage']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler:Org.Vudroid.Core.Codec.ICodecPageInvoker, android-pdfview")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.codec']/interface[@name='CodecPage']/method[@name='recycle' and count(parameter)=0]"
		[Register ("recycle", "()V", "GetRecycleHandler:Org.Vudroid.Core.Codec.ICodecPageInvoker, android-pdfview")]
		void Recycle ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.codec']/interface[@name='CodecPage']/method[@name='renderBitmap' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.RectF']]"
		[Register ("renderBitmap", "(IILandroid/graphics/RectF;)Landroid/graphics/Bitmap;", "GetRenderBitmap_IILandroid_graphics_RectF_Handler:Org.Vudroid.Core.Codec.ICodecPageInvoker, android-pdfview")]
		global::Android.Graphics.Bitmap RenderBitmap (int p0, int p1, global::Android.Graphics.RectF p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.codec']/interface[@name='CodecPage']/method[@name='waitForDecode' and count(parameter)=0]"
		[Register ("waitForDecode", "()V", "GetWaitForDecodeHandler:Org.Vudroid.Core.Codec.ICodecPageInvoker, android-pdfview")]
		void WaitForDecode ();

	}

	[global::Android.Runtime.Register ("org/vudroid/core/codec/CodecPage", DoNotGenerateAcw=true)]
	internal class ICodecPageInvoker : global::Java.Lang.Object, ICodecPage {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/vudroid/core/codec/CodecPage");
		IntPtr class_ref;

		public static ICodecPage GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICodecPage> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.vudroid.core.codec.CodecPage"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICodecPageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ICodecPageInvoker); }
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Vudroid.Core.Codec.ICodecPage __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Codec.ICodecPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		IntPtr id_getHeight;
		public int Height {
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getHeight);
			}
		}

		static Delegate cb_isDecoding;
#pragma warning disable 0169
		static Delegate GetIsDecodingHandler ()
		{
			if (cb_isDecoding == null)
				cb_isDecoding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDecoding);
			return cb_isDecoding;
		}

		static bool n_IsDecoding (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Vudroid.Core.Codec.ICodecPage __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Codec.ICodecPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDecoding;
		}
#pragma warning restore 0169

		IntPtr id_isDecoding;
		public bool IsDecoding {
			get {
				if (id_isDecoding == IntPtr.Zero)
					id_isDecoding = JNIEnv.GetMethodID (class_ref, "isDecoding", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isDecoding);
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Vudroid.Core.Codec.ICodecPage __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Codec.ICodecPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		IntPtr id_getWidth;
		public int Width {
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getWidth);
			}
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
			global::Org.Vudroid.Core.Codec.ICodecPage __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Codec.ICodecPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_renderBitmap_IILandroid_graphics_RectF_;
#pragma warning disable 0169
		static Delegate GetRenderBitmap_IILandroid_graphics_RectF_Handler ()
		{
			if (cb_renderBitmap_IILandroid_graphics_RectF_ == null)
				cb_renderBitmap_IILandroid_graphics_RectF_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_RenderBitmap_IILandroid_graphics_RectF_);
			return cb_renderBitmap_IILandroid_graphics_RectF_;
		}

		static IntPtr n_RenderBitmap_IILandroid_graphics_RectF_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Org.Vudroid.Core.Codec.ICodecPage __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Codec.ICodecPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.RectF p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RenderBitmap (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_renderBitmap_IILandroid_graphics_RectF_;
		public global::Android.Graphics.Bitmap RenderBitmap (int p0, int p1, global::Android.Graphics.RectF p2)
		{
			if (id_renderBitmap_IILandroid_graphics_RectF_ == IntPtr.Zero)
				id_renderBitmap_IILandroid_graphics_RectF_ = JNIEnv.GetMethodID (class_ref, "renderBitmap", "(IILandroid/graphics/RectF;)Landroid/graphics/Bitmap;");
			global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (Handle, id_renderBitmap_IILandroid_graphics_RectF_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_waitForDecode;
#pragma warning disable 0169
		static Delegate GetWaitForDecodeHandler ()
		{
			if (cb_waitForDecode == null)
				cb_waitForDecode = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WaitForDecode);
			return cb_waitForDecode;
		}

		static void n_WaitForDecode (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Vudroid.Core.Codec.ICodecPage __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.Codec.ICodecPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaitForDecode ();
		}
#pragma warning restore 0169

		IntPtr id_waitForDecode;
		public void WaitForDecode ()
		{
			if (id_waitForDecode == IntPtr.Zero)
				id_waitForDecode = JNIEnv.GetMethodID (class_ref, "waitForDecode", "()V");
			JNIEnv.CallVoidMethod (Handle, id_waitForDecode);
		}

	}

}

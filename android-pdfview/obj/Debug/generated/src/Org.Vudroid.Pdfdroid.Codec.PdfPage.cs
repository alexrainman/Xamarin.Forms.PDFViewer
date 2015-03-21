using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Pdfdroid.Codec {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.vudroid.pdfdroid.codec']/class[@name='PdfPage']"
	[global::Android.Runtime.Register ("org/vudroid/pdfdroid/codec/PdfPage", DoNotGenerateAcw=true)]
	public partial class PdfPage : global::Java.Lang.Object, global::Org.Vudroid.Core.Codec.ICodecPage {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/vudroid/pdfdroid/codec/PdfPage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PdfPage); }
		}

		protected PdfPage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Org.Vudroid.Pdfdroid.Codec.PdfPage __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Pdfdroid.Codec.PdfPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.pdfdroid.codec']/class[@name='PdfPage']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getHeight);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()I"));
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
			global::Org.Vudroid.Pdfdroid.Codec.PdfPage __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Pdfdroid.Codec.PdfPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDecoding;
		}
#pragma warning restore 0169

		static IntPtr id_isDecoding;
		public virtual bool IsDecoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.pdfdroid.codec']/class[@name='PdfPage']/method[@name='isDecoding' and count(parameter)=0]"
			[Register ("isDecoding", "()Z", "GetIsDecodingHandler")]
			get {
				if (id_isDecoding == IntPtr.Zero)
					id_isDecoding = JNIEnv.GetMethodID (class_ref, "isDecoding", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isDecoding);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDecoding", "()Z"));
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
			global::Org.Vudroid.Pdfdroid.Codec.PdfPage __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Pdfdroid.Codec.PdfPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.pdfdroid.codec']/class[@name='PdfPage']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getWidth);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()I"));
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
			global::Org.Vudroid.Pdfdroid.Codec.PdfPage __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Pdfdroid.Codec.PdfPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Recycle ();
		}
#pragma warning restore 0169

		static IntPtr id_recycle;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.pdfdroid.codec']/class[@name='PdfPage']/method[@name='recycle' and count(parameter)=0]"
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

		static Delegate cb_render_Landroid_graphics_Rect_Landroid_graphics_Matrix_;
#pragma warning disable 0169
		static Delegate GetRender_Landroid_graphics_Rect_Landroid_graphics_Matrix_Handler ()
		{
			if (cb_render_Landroid_graphics_Rect_Landroid_graphics_Matrix_ == null)
				cb_render_Landroid_graphics_Rect_Landroid_graphics_Matrix_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Render_Landroid_graphics_Rect_Landroid_graphics_Matrix_);
			return cb_render_Landroid_graphics_Rect_Landroid_graphics_Matrix_;
		}

		static IntPtr n_Render_Landroid_graphics_Rect_Landroid_graphics_Matrix_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Vudroid.Pdfdroid.Codec.PdfPage __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Pdfdroid.Codec.PdfPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Matrix p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Render (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_render_Landroid_graphics_Rect_Landroid_graphics_Matrix_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.pdfdroid.codec']/class[@name='PdfPage']/method[@name='render' and count(parameter)=2 and parameter[1][@type='android.graphics.Rect'] and parameter[2][@type='android.graphics.Matrix']]"
		[Register ("render", "(Landroid/graphics/Rect;Landroid/graphics/Matrix;)Landroid/graphics/Bitmap;", "GetRender_Landroid_graphics_Rect_Landroid_graphics_Matrix_Handler")]
		public virtual global::Android.Graphics.Bitmap Render (global::Android.Graphics.Rect p0, global::Android.Graphics.Matrix p1)
		{
			if (id_render_Landroid_graphics_Rect_Landroid_graphics_Matrix_ == IntPtr.Zero)
				id_render_Landroid_graphics_Rect_Landroid_graphics_Matrix_ = JNIEnv.GetMethodID (class_ref, "render", "(Landroid/graphics/Rect;Landroid/graphics/Matrix;)Landroid/graphics/Bitmap;");

			global::Android.Graphics.Bitmap __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_render_Landroid_graphics_Rect_Landroid_graphics_Matrix_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "render", "(Landroid/graphics/Rect;Landroid/graphics/Matrix;)Landroid/graphics/Bitmap;"), new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Org.Vudroid.Pdfdroid.Codec.PdfPage __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Pdfdroid.Codec.PdfPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.RectF p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RenderBitmap (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_renderBitmap_IILandroid_graphics_RectF_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.pdfdroid.codec']/class[@name='PdfPage']/method[@name='renderBitmap' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.RectF']]"
		[Register ("renderBitmap", "(IILandroid/graphics/RectF;)Landroid/graphics/Bitmap;", "GetRenderBitmap_IILandroid_graphics_RectF_Handler")]
		public virtual global::Android.Graphics.Bitmap RenderBitmap (int p0, int p1, global::Android.Graphics.RectF p2)
		{
			if (id_renderBitmap_IILandroid_graphics_RectF_ == IntPtr.Zero)
				id_renderBitmap_IILandroid_graphics_RectF_ = JNIEnv.GetMethodID (class_ref, "renderBitmap", "(IILandroid/graphics/RectF;)Landroid/graphics/Bitmap;");

			global::Android.Graphics.Bitmap __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_renderBitmap_IILandroid_graphics_RectF_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "renderBitmap", "(IILandroid/graphics/RectF;)Landroid/graphics/Bitmap;"), new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Vudroid.Pdfdroid.Codec.PdfPage __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Pdfdroid.Codec.PdfPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaitForDecode ();
		}
#pragma warning restore 0169

		static IntPtr id_waitForDecode;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.pdfdroid.codec']/class[@name='PdfPage']/method[@name='waitForDecode' and count(parameter)=0]"
		[Register ("waitForDecode", "()V", "GetWaitForDecodeHandler")]
		public virtual void WaitForDecode ()
		{
			if (id_waitForDecode == IntPtr.Zero)
				id_waitForDecode = JNIEnv.GetMethodID (class_ref, "waitForDecode", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_waitForDecode);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "waitForDecode", "()V"));
		}

	}
}

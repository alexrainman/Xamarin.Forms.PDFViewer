using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Joanzapata.Pdfview.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.joanzapata.pdfview.model']/class[@name='PagePart']"
	[global::Android.Runtime.Register ("com/joanzapata/pdfview/model/PagePart", DoNotGenerateAcw=true)]
	public partial class PagePart : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/joanzapata/pdfview/model/PagePart", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PagePart); }
		}

		protected PagePart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IILandroid_graphics_Bitmap_FFLandroid_graphics_RectF_ZI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.joanzapata.pdfview.model']/class[@name='PagePart']/constructor[@name='PagePart' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Bitmap'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='android.graphics.RectF'] and parameter[7][@type='boolean'] and parameter[8][@type='int']]"
		[Register (".ctor", "(IILandroid/graphics/Bitmap;FFLandroid/graphics/RectF;ZI)V", "")]
		public PagePart (int p0, int p1, global::Android.Graphics.Bitmap p2, float p3, float p4, global::Android.Graphics.RectF p5, bool p6, int p7) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PagePart)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IILandroid/graphics/Bitmap;FFLandroid/graphics/RectF;ZI)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6), new JValue (p7)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IILandroid/graphics/Bitmap;FFLandroid/graphics/RectF;ZI)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6), new JValue (p7));
				return;
			}

			if (id_ctor_IILandroid_graphics_Bitmap_FFLandroid_graphics_RectF_ZI == IntPtr.Zero)
				id_ctor_IILandroid_graphics_Bitmap_FFLandroid_graphics_RectF_ZI = JNIEnv.GetMethodID (class_ref, "<init>", "(IILandroid/graphics/Bitmap;FFLandroid/graphics/RectF;ZI)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IILandroid_graphics_Bitmap_FFLandroid_graphics_RectF_ZI, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6), new JValue (p7)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IILandroid_graphics_Bitmap_FFLandroid_graphics_RectF_ZI, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6), new JValue (p7));
		}

		static Delegate cb_getCacheOrder;
#pragma warning disable 0169
		static Delegate GetGetCacheOrderHandler ()
		{
			if (cb_getCacheOrder == null)
				cb_getCacheOrder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCacheOrder);
			return cb_getCacheOrder;
		}

		static int n_GetCacheOrder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Joanzapata.Pdfview.Model.PagePart __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Model.PagePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CacheOrder;
		}
#pragma warning restore 0169

		static Delegate cb_setCacheOrder_I;
#pragma warning disable 0169
		static Delegate GetSetCacheOrder_IHandler ()
		{
			if (cb_setCacheOrder_I == null)
				cb_setCacheOrder_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCacheOrder_I);
			return cb_setCacheOrder_I;
		}

		static void n_SetCacheOrder_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Joanzapata.Pdfview.Model.PagePart __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Model.PagePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CacheOrder = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCacheOrder;
		static IntPtr id_setCacheOrder_I;
		public virtual int CacheOrder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.model']/class[@name='PagePart']/method[@name='getCacheOrder' and count(parameter)=0]"
			[Register ("getCacheOrder", "()I", "GetGetCacheOrderHandler")]
			get {
				if (id_getCacheOrder == IntPtr.Zero)
					id_getCacheOrder = JNIEnv.GetMethodID (class_ref, "getCacheOrder", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getCacheOrder);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCacheOrder", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.model']/class[@name='PagePart']/method[@name='setCacheOrder' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCacheOrder", "(I)V", "GetSetCacheOrder_IHandler")]
			set {
				if (id_setCacheOrder_I == IntPtr.Zero)
					id_setCacheOrder_I = JNIEnv.GetMethodID (class_ref, "setCacheOrder", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setCacheOrder_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCacheOrder", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetHeight);
			return cb_getHeight;
		}

		static float n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Joanzapata.Pdfview.Model.PagePart __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Model.PagePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual float Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.model']/class[@name='PagePart']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()F", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getHeight);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()F"));
			}
		}

		static Delegate cb_isThumbnail;
#pragma warning disable 0169
		static Delegate GetIsThumbnailHandler ()
		{
			if (cb_isThumbnail == null)
				cb_isThumbnail = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsThumbnail);
			return cb_isThumbnail;
		}

		static bool n_IsThumbnail (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Joanzapata.Pdfview.Model.PagePart __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Model.PagePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsThumbnail;
		}
#pragma warning restore 0169

		static IntPtr id_isThumbnail;
		public virtual bool IsThumbnail {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.model']/class[@name='PagePart']/method[@name='isThumbnail' and count(parameter)=0]"
			[Register ("isThumbnail", "()Z", "GetIsThumbnailHandler")]
			get {
				if (id_isThumbnail == IntPtr.Zero)
					id_isThumbnail = JNIEnv.GetMethodID (class_ref, "isThumbnail", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isThumbnail);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isThumbnail", "()Z"));
			}
		}

		static Delegate cb_getPage;
#pragma warning disable 0169
		static Delegate GetGetPageHandler ()
		{
			if (cb_getPage == null)
				cb_getPage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPage);
			return cb_getPage;
		}

		static int n_GetPage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Joanzapata.Pdfview.Model.PagePart __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Model.PagePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Page;
		}
#pragma warning restore 0169

		static IntPtr id_getPage;
		public virtual int Page {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.model']/class[@name='PagePart']/method[@name='getPage' and count(parameter)=0]"
			[Register ("getPage", "()I", "GetGetPageHandler")]
			get {
				if (id_getPage == IntPtr.Zero)
					id_getPage = JNIEnv.GetMethodID (class_ref, "getPage", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getPage);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPage", "()I"));
			}
		}

		static Delegate cb_getPageRelativeBounds;
#pragma warning disable 0169
		static Delegate GetGetPageRelativeBoundsHandler ()
		{
			if (cb_getPageRelativeBounds == null)
				cb_getPageRelativeBounds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPageRelativeBounds);
			return cb_getPageRelativeBounds;
		}

		static IntPtr n_GetPageRelativeBounds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Joanzapata.Pdfview.Model.PagePart __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Model.PagePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PageRelativeBounds);
		}
#pragma warning restore 0169

		static IntPtr id_getPageRelativeBounds;
		public virtual global::Android.Graphics.RectF PageRelativeBounds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.model']/class[@name='PagePart']/method[@name='getPageRelativeBounds' and count(parameter)=0]"
			[Register ("getPageRelativeBounds", "()Landroid/graphics/RectF;", "GetGetPageRelativeBoundsHandler")]
			get {
				if (id_getPageRelativeBounds == IntPtr.Zero)
					id_getPageRelativeBounds = JNIEnv.GetMethodID (class_ref, "getPageRelativeBounds", "()Landroid/graphics/RectF;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (JNIEnv.CallObjectMethod  (Handle, id_getPageRelativeBounds), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPageRelativeBounds", "()Landroid/graphics/RectF;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRenderedBitmap;
#pragma warning disable 0169
		static Delegate GetGetRenderedBitmapHandler ()
		{
			if (cb_getRenderedBitmap == null)
				cb_getRenderedBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRenderedBitmap);
			return cb_getRenderedBitmap;
		}

		static IntPtr n_GetRenderedBitmap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Joanzapata.Pdfview.Model.PagePart __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Model.PagePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RenderedBitmap);
		}
#pragma warning restore 0169

		static IntPtr id_getRenderedBitmap;
		public virtual global::Android.Graphics.Bitmap RenderedBitmap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.model']/class[@name='PagePart']/method[@name='getRenderedBitmap' and count(parameter)=0]"
			[Register ("getRenderedBitmap", "()Landroid/graphics/Bitmap;", "GetGetRenderedBitmapHandler")]
			get {
				if (id_getRenderedBitmap == IntPtr.Zero)
					id_getRenderedBitmap = JNIEnv.GetMethodID (class_ref, "getRenderedBitmap", "()Landroid/graphics/Bitmap;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_getRenderedBitmap), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRenderedBitmap", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUserPage;
#pragma warning disable 0169
		static Delegate GetGetUserPageHandler ()
		{
			if (cb_getUserPage == null)
				cb_getUserPage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUserPage);
			return cb_getUserPage;
		}

		static int n_GetUserPage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Joanzapata.Pdfview.Model.PagePart __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Model.PagePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UserPage;
		}
#pragma warning restore 0169

		static IntPtr id_getUserPage;
		public virtual int UserPage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.model']/class[@name='PagePart']/method[@name='getUserPage' and count(parameter)=0]"
			[Register ("getUserPage", "()I", "GetGetUserPageHandler")]
			get {
				if (id_getUserPage == IntPtr.Zero)
					id_getUserPage = JNIEnv.GetMethodID (class_ref, "getUserPage", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getUserPage);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserPage", "()I"));
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetWidth);
			return cb_getWidth;
		}

		static float n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Joanzapata.Pdfview.Model.PagePart __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Model.PagePart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual float Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.model']/class[@name='PagePart']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()F", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getWidth);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()F"));
			}
		}

	}
}

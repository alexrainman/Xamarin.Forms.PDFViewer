using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Core {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.vudroid.core']/interface[@name='DecodeService.DecodeCallback']"
	[Register ("org/vudroid/core/DecodeService$DecodeCallback", "", "Org.Vudroid.Core.IDecodeServiceDecodeCallbackInvoker")]
	public partial interface IDecodeServiceDecodeCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/interface[@name='DecodeService.DecodeCallback']/method[@name='decodeComplete' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("decodeComplete", "(Landroid/graphics/Bitmap;)V", "GetDecodeComplete_Landroid_graphics_Bitmap_Handler:Org.Vudroid.Core.IDecodeServiceDecodeCallbackInvoker, android-pdfview")]
		void DecodeComplete (global::Android.Graphics.Bitmap p0);

	}

	[global::Android.Runtime.Register ("org/vudroid/core/DecodeService$DecodeCallback", DoNotGenerateAcw=true)]
	internal class IDecodeServiceDecodeCallbackInvoker : global::Java.Lang.Object, IDecodeServiceDecodeCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/vudroid/core/DecodeService$DecodeCallback");
		IntPtr class_ref;

		public static IDecodeServiceDecodeCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDecodeServiceDecodeCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.vudroid.core.DecodeService.DecodeCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDecodeServiceDecodeCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IDecodeServiceDecodeCallbackInvoker); }
		}

		static Delegate cb_decodeComplete_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetDecodeComplete_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_decodeComplete_Landroid_graphics_Bitmap_ == null)
				cb_decodeComplete_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DecodeComplete_Landroid_graphics_Bitmap_);
			return cb_decodeComplete_Landroid_graphics_Bitmap_;
		}

		static void n_DecodeComplete_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Vudroid.Core.IDecodeServiceDecodeCallback __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.IDecodeServiceDecodeCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DecodeComplete (p0);
		}
#pragma warning restore 0169

		IntPtr id_decodeComplete_Landroid_graphics_Bitmap_;
		public void DecodeComplete (global::Android.Graphics.Bitmap p0)
		{
			if (id_decodeComplete_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_decodeComplete_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "decodeComplete", "(Landroid/graphics/Bitmap;)V");
			JNIEnv.CallVoidMethod (Handle, id_decodeComplete_Landroid_graphics_Bitmap_, new JValue (p0));
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='org.vudroid.core']/interface[@name='DecodeService']"
	[Register ("org/vudroid/core/DecodeService", "", "Org.Vudroid.Core.IDecodeServiceInvoker")]
	public partial interface IDecodeService : IJavaObject {

		int EffectivePagesHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/interface[@name='DecodeService']/method[@name='getEffectivePagesHeight' and count(parameter)=0]"
			[Register ("getEffectivePagesHeight", "()I", "GetGetEffectivePagesHeightHandler:Org.Vudroid.Core.IDecodeServiceInvoker, android-pdfview")] get;
		}

		int EffectivePagesWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/interface[@name='DecodeService']/method[@name='getEffectivePagesWidth' and count(parameter)=0]"
			[Register ("getEffectivePagesWidth", "()I", "GetGetEffectivePagesWidthHandler:Org.Vudroid.Core.IDecodeServiceInvoker, android-pdfview")] get;
		}

		int PageCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/interface[@name='DecodeService']/method[@name='getPageCount' and count(parameter)=0]"
			[Register ("getPageCount", "()I", "GetGetPageCountHandler:Org.Vudroid.Core.IDecodeServiceInvoker, android-pdfview")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/interface[@name='DecodeService']/method[@name='decodePage' and count(parameter)=5 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int'] and parameter[3][@type='org.vudroid.core.DecodeService.DecodeCallback'] and parameter[4][@type='float'] and parameter[5][@type='android.graphics.RectF']]"
		[Register ("decodePage", "(Ljava/lang/Object;ILorg/vudroid/core/DecodeService$DecodeCallback;FLandroid/graphics/RectF;)V", "GetDecodePage_Ljava_lang_Object_ILorg_vudroid_core_DecodeService_DecodeCallback_FLandroid_graphics_RectF_Handler:Org.Vudroid.Core.IDecodeServiceInvoker, android-pdfview")]
		void DecodePage (global::Java.Lang.Object p0, int p1, global::Org.Vudroid.Core.IDecodeServiceDecodeCallback p2, float p3, global::Android.Graphics.RectF p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/interface[@name='DecodeService']/method[@name='getPage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPage", "(I)Lorg/vudroid/core/codec/CodecPage;", "GetGetPage_IHandler:Org.Vudroid.Core.IDecodeServiceInvoker, android-pdfview")]
		global::Org.Vudroid.Core.Codec.ICodecPage GetPage (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/interface[@name='DecodeService']/method[@name='getPageHeight' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPageHeight", "(I)I", "GetGetPageHeight_IHandler:Org.Vudroid.Core.IDecodeServiceInvoker, android-pdfview")]
		int GetPageHeight (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/interface[@name='DecodeService']/method[@name='getPageWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPageWidth", "(I)I", "GetGetPageWidth_IHandler:Org.Vudroid.Core.IDecodeServiceInvoker, android-pdfview")]
		int GetPageWidth (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/interface[@name='DecodeService']/method[@name='open' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("open", "(Landroid/net/Uri;)V", "GetOpen_Landroid_net_Uri_Handler:Org.Vudroid.Core.IDecodeServiceInvoker, android-pdfview")]
		void Open (global::Android.Net.Uri p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/interface[@name='DecodeService']/method[@name='recycle' and count(parameter)=0]"
		[Register ("recycle", "()V", "GetRecycleHandler:Org.Vudroid.Core.IDecodeServiceInvoker, android-pdfview")]
		void Recycle ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/interface[@name='DecodeService']/method[@name='setContainerView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setContainerView", "(Landroid/view/View;)V", "GetSetContainerView_Landroid_view_View_Handler:Org.Vudroid.Core.IDecodeServiceInvoker, android-pdfview")]
		void SetContainerView (global::Android.Views.View p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/interface[@name='DecodeService']/method[@name='setContentResolver' and count(parameter)=1 and parameter[1][@type='android.content.ContentResolver']]"
		[Register ("setContentResolver", "(Landroid/content/ContentResolver;)V", "GetSetContentResolver_Landroid_content_ContentResolver_Handler:Org.Vudroid.Core.IDecodeServiceInvoker, android-pdfview")]
		void SetContentResolver (global::Android.Content.ContentResolver p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/interface[@name='DecodeService']/method[@name='stopDecoding' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("stopDecoding", "(Ljava/lang/Object;)V", "GetStopDecoding_Ljava_lang_Object_Handler:Org.Vudroid.Core.IDecodeServiceInvoker, android-pdfview")]
		void StopDecoding (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("org/vudroid/core/DecodeService", DoNotGenerateAcw=true)]
	internal class IDecodeServiceInvoker : global::Java.Lang.Object, IDecodeService {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/vudroid/core/DecodeService");
		IntPtr class_ref;

		public static IDecodeService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDecodeService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.vudroid.core.DecodeService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDecodeServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IDecodeServiceInvoker); }
		}

		static Delegate cb_getEffectivePagesHeight;
#pragma warning disable 0169
		static Delegate GetGetEffectivePagesHeightHandler ()
		{
			if (cb_getEffectivePagesHeight == null)
				cb_getEffectivePagesHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEffectivePagesHeight);
			return cb_getEffectivePagesHeight;
		}

		static int n_GetEffectivePagesHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Vudroid.Core.IDecodeService __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.IDecodeService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EffectivePagesHeight;
		}
#pragma warning restore 0169

		IntPtr id_getEffectivePagesHeight;
		public int EffectivePagesHeight {
			get {
				if (id_getEffectivePagesHeight == IntPtr.Zero)
					id_getEffectivePagesHeight = JNIEnv.GetMethodID (class_ref, "getEffectivePagesHeight", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getEffectivePagesHeight);
			}
		}

		static Delegate cb_getEffectivePagesWidth;
#pragma warning disable 0169
		static Delegate GetGetEffectivePagesWidthHandler ()
		{
			if (cb_getEffectivePagesWidth == null)
				cb_getEffectivePagesWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEffectivePagesWidth);
			return cb_getEffectivePagesWidth;
		}

		static int n_GetEffectivePagesWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Vudroid.Core.IDecodeService __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.IDecodeService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EffectivePagesWidth;
		}
#pragma warning restore 0169

		IntPtr id_getEffectivePagesWidth;
		public int EffectivePagesWidth {
			get {
				if (id_getEffectivePagesWidth == IntPtr.Zero)
					id_getEffectivePagesWidth = JNIEnv.GetMethodID (class_ref, "getEffectivePagesWidth", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getEffectivePagesWidth);
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
			global::Org.Vudroid.Core.IDecodeService __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.IDecodeService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_decodePage_Ljava_lang_Object_ILorg_vudroid_core_DecodeService_DecodeCallback_FLandroid_graphics_RectF_;
#pragma warning disable 0169
		static Delegate GetDecodePage_Ljava_lang_Object_ILorg_vudroid_core_DecodeService_DecodeCallback_FLandroid_graphics_RectF_Handler ()
		{
			if (cb_decodePage_Ljava_lang_Object_ILorg_vudroid_core_DecodeService_DecodeCallback_FLandroid_graphics_RectF_ == null)
				cb_decodePage_Ljava_lang_Object_ILorg_vudroid_core_DecodeService_DecodeCallback_FLandroid_graphics_RectF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, float, IntPtr>) n_DecodePage_Ljava_lang_Object_ILorg_vudroid_core_DecodeService_DecodeCallback_FLandroid_graphics_RectF_);
			return cb_decodePage_Ljava_lang_Object_ILorg_vudroid_core_DecodeService_DecodeCallback_FLandroid_graphics_RectF_;
		}

		static void n_DecodePage_Ljava_lang_Object_ILorg_vudroid_core_DecodeService_DecodeCallback_FLandroid_graphics_RectF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, float p3, IntPtr native_p4)
		{
			global::Org.Vudroid.Core.IDecodeService __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.IDecodeService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Vudroid.Core.IDecodeServiceDecodeCallback p2 = (global::Org.Vudroid.Core.IDecodeServiceDecodeCallback)global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.IDecodeServiceDecodeCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.RectF p4 = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.DecodePage (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_decodePage_Ljava_lang_Object_ILorg_vudroid_core_DecodeService_DecodeCallback_FLandroid_graphics_RectF_;
		public void DecodePage (global::Java.Lang.Object p0, int p1, global::Org.Vudroid.Core.IDecodeServiceDecodeCallback p2, float p3, global::Android.Graphics.RectF p4)
		{
			if (id_decodePage_Ljava_lang_Object_ILorg_vudroid_core_DecodeService_DecodeCallback_FLandroid_graphics_RectF_ == IntPtr.Zero)
				id_decodePage_Ljava_lang_Object_ILorg_vudroid_core_DecodeService_DecodeCallback_FLandroid_graphics_RectF_ = JNIEnv.GetMethodID (class_ref, "decodePage", "(Ljava/lang/Object;ILorg/vudroid/core/DecodeService$DecodeCallback;FLandroid/graphics/RectF;)V");
			JNIEnv.CallVoidMethod (Handle, id_decodePage_Ljava_lang_Object_ILorg_vudroid_core_DecodeService_DecodeCallback_FLandroid_graphics_RectF_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
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
			global::Org.Vudroid.Core.IDecodeService __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.IDecodeService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getPageHeight_I;
#pragma warning disable 0169
		static Delegate GetGetPageHeight_IHandler ()
		{
			if (cb_getPageHeight_I == null)
				cb_getPageHeight_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetPageHeight_I);
			return cb_getPageHeight_I;
		}

		static int n_GetPageHeight_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Vudroid.Core.IDecodeService __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.IDecodeService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPageHeight (p0);
		}
#pragma warning restore 0169

		IntPtr id_getPageHeight_I;
		public int GetPageHeight (int p0)
		{
			if (id_getPageHeight_I == IntPtr.Zero)
				id_getPageHeight_I = JNIEnv.GetMethodID (class_ref, "getPageHeight", "(I)I");
			return JNIEnv.CallIntMethod (Handle, id_getPageHeight_I, new JValue (p0));
		}

		static Delegate cb_getPageWidth_I;
#pragma warning disable 0169
		static Delegate GetGetPageWidth_IHandler ()
		{
			if (cb_getPageWidth_I == null)
				cb_getPageWidth_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetPageWidth_I);
			return cb_getPageWidth_I;
		}

		static int n_GetPageWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Vudroid.Core.IDecodeService __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.IDecodeService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPageWidth (p0);
		}
#pragma warning restore 0169

		IntPtr id_getPageWidth_I;
		public int GetPageWidth (int p0)
		{
			if (id_getPageWidth_I == IntPtr.Zero)
				id_getPageWidth_I = JNIEnv.GetMethodID (class_ref, "getPageWidth", "(I)I");
			return JNIEnv.CallIntMethod (Handle, id_getPageWidth_I, new JValue (p0));
		}

		static Delegate cb_open_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetOpen_Landroid_net_Uri_Handler ()
		{
			if (cb_open_Landroid_net_Uri_ == null)
				cb_open_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Open_Landroid_net_Uri_);
			return cb_open_Landroid_net_Uri_;
		}

		static void n_Open_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Vudroid.Core.IDecodeService __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.IDecodeService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Open (p0);
		}
#pragma warning restore 0169

		IntPtr id_open_Landroid_net_Uri_;
		public void Open (global::Android.Net.Uri p0)
		{
			if (id_open_Landroid_net_Uri_ == IntPtr.Zero)
				id_open_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "open", "(Landroid/net/Uri;)V");
			JNIEnv.CallVoidMethod (Handle, id_open_Landroid_net_Uri_, new JValue (p0));
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
			global::Org.Vudroid.Core.IDecodeService __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.IDecodeService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_setContainerView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetContainerView_Landroid_view_View_Handler ()
		{
			if (cb_setContainerView_Landroid_view_View_ == null)
				cb_setContainerView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContainerView_Landroid_view_View_);
			return cb_setContainerView_Landroid_view_View_;
		}

		static void n_SetContainerView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Vudroid.Core.IDecodeService __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.IDecodeService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetContainerView (p0);
		}
#pragma warning restore 0169

		IntPtr id_setContainerView_Landroid_view_View_;
		public void SetContainerView (global::Android.Views.View p0)
		{
			if (id_setContainerView_Landroid_view_View_ == IntPtr.Zero)
				id_setContainerView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setContainerView", "(Landroid/view/View;)V");
			JNIEnv.CallVoidMethod (Handle, id_setContainerView_Landroid_view_View_, new JValue (p0));
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
			global::Org.Vudroid.Core.IDecodeService __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.IDecodeService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_stopDecoding_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetStopDecoding_Ljava_lang_Object_Handler ()
		{
			if (cb_stopDecoding_Ljava_lang_Object_ == null)
				cb_stopDecoding_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StopDecoding_Ljava_lang_Object_);
			return cb_stopDecoding_Ljava_lang_Object_;
		}

		static void n_StopDecoding_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Vudroid.Core.IDecodeService __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.IDecodeService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StopDecoding (p0);
		}
#pragma warning restore 0169

		IntPtr id_stopDecoding_Ljava_lang_Object_;
		public void StopDecoding (global::Java.Lang.Object p0)
		{
			if (id_stopDecoding_Ljava_lang_Object_ == IntPtr.Zero)
				id_stopDecoding_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "stopDecoding", "(Ljava/lang/Object;)V");
			JNIEnv.CallVoidMethod (Handle, id_stopDecoding_Ljava_lang_Object_, new JValue (p0));
		}

	}

}

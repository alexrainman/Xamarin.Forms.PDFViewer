using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.vudroid.core']/class[@name='DecodeServiceBase']"
	[global::Android.Runtime.Register ("org/vudroid/core/DecodeServiceBase", DoNotGenerateAcw=true)]
	public partial class DecodeServiceBase : global::Java.Lang.Object, global::Org.Vudroid.Core.IDecodeService {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.vudroid.core']/class[@name='DecodeServiceBase']/field[@name='DECODE_SERVICE']"
		[Register ("DECODE_SERVICE")]
		public const string DecodeService = (string) "ViewDroidDecodeService";
		// Metadata.xml XPath class reference: path="/api/package[@name='org.vudroid.core']/class[@name='DecodeServiceBase.DecodeTask']"
		[global::Android.Runtime.Register ("org/vudroid/core/DecodeServiceBase$DecodeTask", DoNotGenerateAcw=true)]
		public partial class DecodeTask : global::Java.Lang.Object {

			protected DecodeTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/vudroid/core/DecodeServiceBase", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DecodeServiceBase); }
		}

		protected DecodeServiceBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_vudroid_core_codec_CodecContext_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.vudroid.core']/class[@name='DecodeServiceBase']/constructor[@name='DecodeServiceBase' and count(parameter)=1 and parameter[1][@type='org.vudroid.core.codec.CodecContext']]"
		[Register (".ctor", "(Lorg/vudroid/core/codec/CodecContext;)V", "")]
		public DecodeServiceBase (global::Org.Vudroid.Core.Codec.ICodecContext p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DecodeServiceBase)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/vudroid/core/codec/CodecContext;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/vudroid/core/codec/CodecContext;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorg_vudroid_core_codec_CodecContext_ == IntPtr.Zero)
				id_ctor_Lorg_vudroid_core_codec_CodecContext_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/vudroid/core/codec/CodecContext;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_vudroid_core_codec_CodecContext_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_vudroid_core_codec_CodecContext_, new JValue (p0));
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
			global::Org.Vudroid.Core.DecodeServiceBase __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.DecodeServiceBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EffectivePagesHeight;
		}
#pragma warning restore 0169

		static IntPtr id_getEffectivePagesHeight;
		public virtual int EffectivePagesHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/class[@name='DecodeServiceBase']/method[@name='getEffectivePagesHeight' and count(parameter)=0]"
			[Register ("getEffectivePagesHeight", "()I", "GetGetEffectivePagesHeightHandler")]
			get {
				if (id_getEffectivePagesHeight == IntPtr.Zero)
					id_getEffectivePagesHeight = JNIEnv.GetMethodID (class_ref, "getEffectivePagesHeight", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getEffectivePagesHeight);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEffectivePagesHeight", "()I"));
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
			global::Org.Vudroid.Core.DecodeServiceBase __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.DecodeServiceBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EffectivePagesWidth;
		}
#pragma warning restore 0169

		static IntPtr id_getEffectivePagesWidth;
		public virtual int EffectivePagesWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/class[@name='DecodeServiceBase']/method[@name='getEffectivePagesWidth' and count(parameter)=0]"
			[Register ("getEffectivePagesWidth", "()I", "GetGetEffectivePagesWidthHandler")]
			get {
				if (id_getEffectivePagesWidth == IntPtr.Zero)
					id_getEffectivePagesWidth = JNIEnv.GetMethodID (class_ref, "getEffectivePagesWidth", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getEffectivePagesWidth);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEffectivePagesWidth", "()I"));
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
			global::Org.Vudroid.Core.DecodeServiceBase __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.DecodeServiceBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PageCount;
		}
#pragma warning restore 0169

		static IntPtr id_getPageCount;
		public virtual int PageCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/class[@name='DecodeServiceBase']/method[@name='getPageCount' and count(parameter)=0]"
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
			global::Org.Vudroid.Core.DecodeServiceBase __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.DecodeServiceBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Vudroid.Core.IDecodeServiceDecodeCallback p2 = (global::Org.Vudroid.Core.IDecodeServiceDecodeCallback)global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.IDecodeServiceDecodeCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.RectF p4 = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.DecodePage (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_decodePage_Ljava_lang_Object_ILorg_vudroid_core_DecodeService_DecodeCallback_FLandroid_graphics_RectF_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/class[@name='DecodeServiceBase']/method[@name='decodePage' and count(parameter)=5 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int'] and parameter[3][@type='org.vudroid.core.DecodeService.DecodeCallback'] and parameter[4][@type='float'] and parameter[5][@type='android.graphics.RectF']]"
		[Register ("decodePage", "(Ljava/lang/Object;ILorg/vudroid/core/DecodeService$DecodeCallback;FLandroid/graphics/RectF;)V", "GetDecodePage_Ljava_lang_Object_ILorg_vudroid_core_DecodeService_DecodeCallback_FLandroid_graphics_RectF_Handler")]
		public virtual void DecodePage (global::Java.Lang.Object p0, int p1, global::Org.Vudroid.Core.IDecodeServiceDecodeCallback p2, float p3, global::Android.Graphics.RectF p4)
		{
			if (id_decodePage_Ljava_lang_Object_ILorg_vudroid_core_DecodeService_DecodeCallback_FLandroid_graphics_RectF_ == IntPtr.Zero)
				id_decodePage_Ljava_lang_Object_ILorg_vudroid_core_DecodeService_DecodeCallback_FLandroid_graphics_RectF_ = JNIEnv.GetMethodID (class_ref, "decodePage", "(Ljava/lang/Object;ILorg/vudroid/core/DecodeService$DecodeCallback;FLandroid/graphics/RectF;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_decodePage_Ljava_lang_Object_ILorg_vudroid_core_DecodeService_DecodeCallback_FLandroid_graphics_RectF_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodePage", "(Ljava/lang/Object;ILorg/vudroid/core/DecodeService$DecodeCallback;FLandroid/graphics/RectF;)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
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
			global::Org.Vudroid.Core.DecodeServiceBase __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.DecodeServiceBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetPage (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getPage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/class[@name='DecodeServiceBase']/method[@name='getPage' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Org.Vudroid.Core.DecodeServiceBase __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.DecodeServiceBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPageHeight (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getPageHeight_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/class[@name='DecodeServiceBase']/method[@name='getPageHeight' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPageHeight", "(I)I", "GetGetPageHeight_IHandler")]
		public virtual int GetPageHeight (int p0)
		{
			if (id_getPageHeight_I == IntPtr.Zero)
				id_getPageHeight_I = JNIEnv.GetMethodID (class_ref, "getPageHeight", "(I)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_getPageHeight_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPageHeight", "(I)I"), new JValue (p0));
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
			global::Org.Vudroid.Core.DecodeServiceBase __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.DecodeServiceBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPageWidth (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getPageWidth_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/class[@name='DecodeServiceBase']/method[@name='getPageWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPageWidth", "(I)I", "GetGetPageWidth_IHandler")]
		public virtual int GetPageWidth (int p0)
		{
			if (id_getPageWidth_I == IntPtr.Zero)
				id_getPageWidth_I = JNIEnv.GetMethodID (class_ref, "getPageWidth", "(I)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_getPageWidth_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPageWidth", "(I)I"), new JValue (p0));
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
			global::Org.Vudroid.Core.DecodeServiceBase __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.DecodeServiceBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Open (p0);
		}
#pragma warning restore 0169

		static IntPtr id_open_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/class[@name='DecodeServiceBase']/method[@name='open' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("open", "(Landroid/net/Uri;)V", "GetOpen_Landroid_net_Uri_Handler")]
		public virtual void Open (global::Android.Net.Uri p0)
		{
			if (id_open_Landroid_net_Uri_ == IntPtr.Zero)
				id_open_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "open", "(Landroid/net/Uri;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_open_Landroid_net_Uri_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "open", "(Landroid/net/Uri;)V"), new JValue (p0));
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
			global::Org.Vudroid.Core.DecodeServiceBase __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.DecodeServiceBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Recycle ();
		}
#pragma warning restore 0169

		static IntPtr id_recycle;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/class[@name='DecodeServiceBase']/method[@name='recycle' and count(parameter)=0]"
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
			global::Org.Vudroid.Core.DecodeServiceBase __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.DecodeServiceBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetContainerView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setContainerView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/class[@name='DecodeServiceBase']/method[@name='setContainerView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setContainerView", "(Landroid/view/View;)V", "GetSetContainerView_Landroid_view_View_Handler")]
		public virtual void SetContainerView (global::Android.Views.View p0)
		{
			if (id_setContainerView_Landroid_view_View_ == IntPtr.Zero)
				id_setContainerView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setContainerView", "(Landroid/view/View;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setContainerView_Landroid_view_View_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContainerView", "(Landroid/view/View;)V"), new JValue (p0));
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
			global::Org.Vudroid.Core.DecodeServiceBase __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.DecodeServiceBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentResolver p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentResolver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetContentResolver (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setContentResolver_Landroid_content_ContentResolver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/class[@name='DecodeServiceBase']/method[@name='setContentResolver' and count(parameter)=1 and parameter[1][@type='android.content.ContentResolver']]"
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
			global::Org.Vudroid.Core.DecodeServiceBase __this = global::Java.Lang.Object.GetObject<global::Org.Vudroid.Core.DecodeServiceBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StopDecoding (p0);
		}
#pragma warning restore 0169

		static IntPtr id_stopDecoding_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/class[@name='DecodeServiceBase']/method[@name='stopDecoding' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("stopDecoding", "(Ljava/lang/Object;)V", "GetStopDecoding_Ljava_lang_Object_Handler")]
		public virtual void StopDecoding (global::Java.Lang.Object p0)
		{
			if (id_stopDecoding_Ljava_lang_Object_ == IntPtr.Zero)
				id_stopDecoding_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "stopDecoding", "(Ljava/lang/Object;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_stopDecoding_Ljava_lang_Object_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopDecoding", "(Ljava/lang/Object;)V"), new JValue (p0));
		}

	}
}

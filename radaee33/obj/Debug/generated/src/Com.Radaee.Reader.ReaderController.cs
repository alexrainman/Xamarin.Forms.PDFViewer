using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Radaee.Reader {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.reader']/class[@name='ReaderController']"
	[global::Android.Runtime.Register ("com/radaee/reader/ReaderController", DoNotGenerateAcw=true)]
	public partial class ReaderController : global::Android.Views.View, global::Com.Radaee.View.PDFView.IPDFViewListener {


		static IntPtr m_lock_resize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.reader']/class[@name='ReaderController']/field[@name='m_lock_resize']"
		[Register ("m_lock_resize")]
		public bool MLockResize {
			get {
				if (m_lock_resize_jfieldId == IntPtr.Zero)
					m_lock_resize_jfieldId = JNIEnv.GetFieldID (class_ref, "m_lock_resize", "Z");
				return JNIEnv.GetBooleanField (Handle, m_lock_resize_jfieldId);
			}
			set {
				if (m_lock_resize_jfieldId == IntPtr.Zero)
					m_lock_resize_jfieldId = JNIEnv.GetFieldID (class_ref, "m_lock_resize", "Z");
				JNIEnv.SetField (Handle, m_lock_resize_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/radaee/reader/ReaderController", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReaderController); }
		}

		protected ReaderController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.reader']/class[@name='ReaderController']/constructor[@name='ReaderController' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public ReaderController (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ReaderController)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.reader']/class[@name='ReaderController']/constructor[@name='ReaderController' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public ReaderController (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ReaderController)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_OnPDFDoubleTapped_FF;
#pragma warning disable 0169
		static Delegate GetOnPDFDoubleTapped_FFHandler ()
		{
			if (cb_OnPDFDoubleTapped_FF == null)
				cb_OnPDFDoubleTapped_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, bool>) n_OnPDFDoubleTapped_FF);
			return cb_OnPDFDoubleTapped_FF;
		}

		static bool n_OnPDFDoubleTapped_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Com.Radaee.Reader.ReaderController __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Reader.ReaderController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnPDFDoubleTapped (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnPDFDoubleTapped_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.reader']/class[@name='ReaderController']/method[@name='OnPDFDoubleTapped' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("OnPDFDoubleTapped", "(FF)Z", "GetOnPDFDoubleTapped_FFHandler")]
		public virtual bool OnPDFDoubleTapped (float p0, float p1)
		{
			if (id_OnPDFDoubleTapped_FF == IntPtr.Zero)
				id_OnPDFDoubleTapped_FF = JNIEnv.GetMethodID (class_ref, "OnPDFDoubleTapped", "(FF)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_OnPDFDoubleTapped_FF, new JValue (p0), new JValue (p1));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnPDFDoubleTapped", "(FF)Z"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_OnPDFFound_Z;
#pragma warning disable 0169
		static Delegate GetOnPDFFound_ZHandler ()
		{
			if (cb_OnPDFFound_Z == null)
				cb_OnPDFFound_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnPDFFound_Z);
			return cb_OnPDFFound_Z;
		}

		static void n_OnPDFFound_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Radaee.Reader.ReaderController __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Reader.ReaderController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPDFFound (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnPDFFound_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.reader']/class[@name='ReaderController']/method[@name='OnPDFFound' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("OnPDFFound", "(Z)V", "GetOnPDFFound_ZHandler")]
		public virtual void OnPDFFound (bool p0)
		{
			if (id_OnPDFFound_Z == IntPtr.Zero)
				id_OnPDFFound_Z = JNIEnv.GetMethodID (class_ref, "OnPDFFound", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_OnPDFFound_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnPDFFound", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_OnPDFInvalidate_Z;
#pragma warning disable 0169
		static Delegate GetOnPDFInvalidate_ZHandler ()
		{
			if (cb_OnPDFInvalidate_Z == null)
				cb_OnPDFInvalidate_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnPDFInvalidate_Z);
			return cb_OnPDFInvalidate_Z;
		}

		static void n_OnPDFInvalidate_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Radaee.Reader.ReaderController __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Reader.ReaderController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPDFInvalidate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnPDFInvalidate_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.reader']/class[@name='ReaderController']/method[@name='OnPDFInvalidate' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("OnPDFInvalidate", "(Z)V", "GetOnPDFInvalidate_ZHandler")]
		public virtual void OnPDFInvalidate (bool p0)
		{
			if (id_OnPDFInvalidate_Z == IntPtr.Zero)
				id_OnPDFInvalidate_Z = JNIEnv.GetMethodID (class_ref, "OnPDFInvalidate", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_OnPDFInvalidate_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnPDFInvalidate", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_OnPDFLongPressed_FF;
#pragma warning disable 0169
		static Delegate GetOnPDFLongPressed_FFHandler ()
		{
			if (cb_OnPDFLongPressed_FF == null)
				cb_OnPDFLongPressed_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_OnPDFLongPressed_FF);
			return cb_OnPDFLongPressed_FF;
		}

		static void n_OnPDFLongPressed_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Com.Radaee.Reader.ReaderController __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Reader.ReaderController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPDFLongPressed (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnPDFLongPressed_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.reader']/class[@name='ReaderController']/method[@name='OnPDFLongPressed' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("OnPDFLongPressed", "(FF)V", "GetOnPDFLongPressed_FFHandler")]
		public virtual void OnPDFLongPressed (float p0, float p1)
		{
			if (id_OnPDFLongPressed_FF == IntPtr.Zero)
				id_OnPDFLongPressed_FF = JNIEnv.GetMethodID (class_ref, "OnPDFLongPressed", "(FF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_OnPDFLongPressed_FF, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnPDFLongPressed", "(FF)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_OnPDFPageChanged_I;
#pragma warning disable 0169
		static Delegate GetOnPDFPageChanged_IHandler ()
		{
			if (cb_OnPDFPageChanged_I == null)
				cb_OnPDFPageChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnPDFPageChanged_I);
			return cb_OnPDFPageChanged_I;
		}

		static void n_OnPDFPageChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.Reader.ReaderController __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Reader.ReaderController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPDFPageChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnPDFPageChanged_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.reader']/class[@name='ReaderController']/method[@name='OnPDFPageChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("OnPDFPageChanged", "(I)V", "GetOnPDFPageChanged_IHandler")]
		public virtual void OnPDFPageChanged (int p0)
		{
			if (id_OnPDFPageChanged_I == IntPtr.Zero)
				id_OnPDFPageChanged_I = JNIEnv.GetMethodID (class_ref, "OnPDFPageChanged", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_OnPDFPageChanged_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnPDFPageChanged", "(I)V"), new JValue (p0));
		}

		static Delegate cb_OnPDFPageDisplayed_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_;
#pragma warning disable 0169
		static Delegate GetOnPDFPageDisplayed_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_Handler ()
		{
			if (cb_OnPDFPageDisplayed_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_ == null)
				cb_OnPDFPageDisplayed_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPDFPageDisplayed_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_);
			return cb_OnPDFPageDisplayed_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_;
		}

		static void n_OnPDFPageDisplayed_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Radaee.Reader.ReaderController __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Reader.ReaderController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.View.PDFVPage p1 = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVPage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPDFPageDisplayed (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnPDFPageDisplayed_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.reader']/class[@name='ReaderController']/method[@name='OnPDFPageDisplayed' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.radaee.view.PDFVPage']]"
		[Register ("OnPDFPageDisplayed", "(Landroid/graphics/Canvas;Lcom/radaee/view/PDFVPage;)V", "GetOnPDFPageDisplayed_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_Handler")]
		public virtual void OnPDFPageDisplayed (global::Android.Graphics.Canvas p0, global::Com.Radaee.View.PDFVPage p1)
		{
			if (id_OnPDFPageDisplayed_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_ == IntPtr.Zero)
				id_OnPDFPageDisplayed_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_ = JNIEnv.GetMethodID (class_ref, "OnPDFPageDisplayed", "(Landroid/graphics/Canvas;Lcom/radaee/view/PDFVPage;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_OnPDFPageDisplayed_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnPDFPageDisplayed", "(Landroid/graphics/Canvas;Lcom/radaee/view/PDFVPage;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_OnPDFSelectEnd;
#pragma warning disable 0169
		static Delegate GetOnPDFSelectEndHandler ()
		{
			if (cb_OnPDFSelectEnd == null)
				cb_OnPDFSelectEnd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPDFSelectEnd);
			return cb_OnPDFSelectEnd;
		}

		static void n_OnPDFSelectEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Reader.ReaderController __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Reader.ReaderController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPDFSelectEnd ();
		}
#pragma warning restore 0169

		static IntPtr id_OnPDFSelectEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.reader']/class[@name='ReaderController']/method[@name='OnPDFSelectEnd' and count(parameter)=0]"
		[Register ("OnPDFSelectEnd", "()V", "GetOnPDFSelectEndHandler")]
		public virtual void OnPDFSelectEnd ()
		{
			if (id_OnPDFSelectEnd == IntPtr.Zero)
				id_OnPDFSelectEnd = JNIEnv.GetMethodID (class_ref, "OnPDFSelectEnd", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_OnPDFSelectEnd);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnPDFSelectEnd", "()V"));
		}

		static Delegate cb_OnPDFSelecting_Landroid_graphics_Canvas_arrayIarrayI;
#pragma warning disable 0169
		static Delegate GetOnPDFSelecting_Landroid_graphics_Canvas_arrayIarrayIHandler ()
		{
			if (cb_OnPDFSelecting_Landroid_graphics_Canvas_arrayIarrayI == null)
				cb_OnPDFSelecting_Landroid_graphics_Canvas_arrayIarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPDFSelecting_Landroid_graphics_Canvas_arrayIarrayI);
			return cb_OnPDFSelecting_Landroid_graphics_Canvas_arrayIarrayI;
		}

		static void n_OnPDFSelecting_Landroid_graphics_Canvas_arrayIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Radaee.Reader.ReaderController __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Reader.ReaderController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.OnPDFSelecting (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_OnPDFSelecting_Landroid_graphics_Canvas_arrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.reader']/class[@name='ReaderController']/method[@name='OnPDFSelecting' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]']]"
		[Register ("OnPDFSelecting", "(Landroid/graphics/Canvas;[I[I)V", "GetOnPDFSelecting_Landroid_graphics_Canvas_arrayIarrayIHandler")]
		public virtual void OnPDFSelecting (global::Android.Graphics.Canvas p0, int[] p1, int[] p2)
		{
			if (id_OnPDFSelecting_Landroid_graphics_Canvas_arrayIarrayI == IntPtr.Zero)
				id_OnPDFSelecting_Landroid_graphics_Canvas_arrayIarrayI = JNIEnv.GetMethodID (class_ref, "OnPDFSelecting", "(Landroid/graphics/Canvas;[I[I)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_OnPDFSelecting_Landroid_graphics_Canvas_arrayIarrayI, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnPDFSelecting", "(Landroid/graphics/Canvas;[I[I)V"), new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_OnPDFShowPressed_FF;
#pragma warning disable 0169
		static Delegate GetOnPDFShowPressed_FFHandler ()
		{
			if (cb_OnPDFShowPressed_FF == null)
				cb_OnPDFShowPressed_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_OnPDFShowPressed_FF);
			return cb_OnPDFShowPressed_FF;
		}

		static void n_OnPDFShowPressed_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Com.Radaee.Reader.ReaderController __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Reader.ReaderController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPDFShowPressed (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnPDFShowPressed_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.reader']/class[@name='ReaderController']/method[@name='OnPDFShowPressed' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("OnPDFShowPressed", "(FF)V", "GetOnPDFShowPressed_FFHandler")]
		public virtual void OnPDFShowPressed (float p0, float p1)
		{
			if (id_OnPDFShowPressed_FF == IntPtr.Zero)
				id_OnPDFShowPressed_FF = JNIEnv.GetMethodID (class_ref, "OnPDFShowPressed", "(FF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_OnPDFShowPressed_FF, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnPDFShowPressed", "(FF)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_OnPDFSingleTapped_FF;
#pragma warning disable 0169
		static Delegate GetOnPDFSingleTapped_FFHandler ()
		{
			if (cb_OnPDFSingleTapped_FF == null)
				cb_OnPDFSingleTapped_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, bool>) n_OnPDFSingleTapped_FF);
			return cb_OnPDFSingleTapped_FF;
		}

		static bool n_OnPDFSingleTapped_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Com.Radaee.Reader.ReaderController __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Reader.ReaderController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnPDFSingleTapped (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_OnPDFSingleTapped_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.reader']/class[@name='ReaderController']/method[@name='OnPDFSingleTapped' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("OnPDFSingleTapped", "(FF)Z", "GetOnPDFSingleTapped_FFHandler")]
		public virtual bool OnPDFSingleTapped (float p0, float p1)
		{
			if (id_OnPDFSingleTapped_FF == IntPtr.Zero)
				id_OnPDFSingleTapped_FF = JNIEnv.GetMethodID (class_ref, "OnPDFSingleTapped", "(FF)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_OnPDFSingleTapped_FF, new JValue (p0), new JValue (p1));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnPDFSingleTapped", "(FF)Z"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Reader.ReaderController __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Reader.ReaderController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.reader']/class[@name='ReaderController']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_close);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
		}

		static Delegate cb_open_Lcom_radaee_pdf_Document_;
#pragma warning disable 0169
		static Delegate GetOpen_Lcom_radaee_pdf_Document_Handler ()
		{
			if (cb_open_Lcom_radaee_pdf_Document_ == null)
				cb_open_Lcom_radaee_pdf_Document_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Open_Lcom_radaee_pdf_Document_);
			return cb_open_Lcom_radaee_pdf_Document_;
		}

		static void n_Open_Lcom_radaee_pdf_Document_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Reader.ReaderController __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Reader.ReaderController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Document p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Open (p0);
		}
#pragma warning restore 0169

		static IntPtr id_open_Lcom_radaee_pdf_Document_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.reader']/class[@name='ReaderController']/method[@name='open' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Document']]"
		[Register ("open", "(Lcom/radaee/pdf/Document;)V", "GetOpen_Lcom_radaee_pdf_Document_Handler")]
		public virtual void Open (global::Com.Radaee.Pdf.Document p0)
		{
			if (id_open_Lcom_radaee_pdf_Document_ == IntPtr.Zero)
				id_open_Lcom_radaee_pdf_Document_ = JNIEnv.GetMethodID (class_ref, "open", "(Lcom/radaee/pdf/Document;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_open_Lcom_radaee_pdf_Document_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "open", "(Lcom/radaee/pdf/Document;)V"), new JValue (p0));
		}

	}
}

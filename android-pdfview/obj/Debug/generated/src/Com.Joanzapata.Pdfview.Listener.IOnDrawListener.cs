using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Joanzapata.Pdfview.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.joanzapata.pdfview.listener']/interface[@name='OnDrawListener']"
	[Register ("com/joanzapata/pdfview/listener/OnDrawListener", "", "Com.Joanzapata.Pdfview.Listener.IOnDrawListenerInvoker")]
	public partial interface IOnDrawListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.listener']/interface[@name='OnDrawListener']/method[@name='onLayerDrawn' and count(parameter)=4 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='int']]"
		[Register ("onLayerDrawn", "(Landroid/graphics/Canvas;FFI)V", "GetOnLayerDrawn_Landroid_graphics_Canvas_FFIHandler:Com.Joanzapata.Pdfview.Listener.IOnDrawListenerInvoker, android-pdfview")]
		void OnLayerDrawn (global::Android.Graphics.Canvas p0, float p1, float p2, int p3);

	}

	[global::Android.Runtime.Register ("com/joanzapata/pdfview/listener/OnDrawListener", DoNotGenerateAcw=true)]
	internal class IOnDrawListenerInvoker : global::Java.Lang.Object, IOnDrawListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/joanzapata/pdfview/listener/OnDrawListener");
		IntPtr class_ref;

		public static IOnDrawListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnDrawListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.joanzapata.pdfview.listener.OnDrawListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnDrawListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOnDrawListenerInvoker); }
		}

		static Delegate cb_onLayerDrawn_Landroid_graphics_Canvas_FFI;
#pragma warning disable 0169
		static Delegate GetOnLayerDrawn_Landroid_graphics_Canvas_FFIHandler ()
		{
			if (cb_onLayerDrawn_Landroid_graphics_Canvas_FFI == null)
				cb_onLayerDrawn_Landroid_graphics_Canvas_FFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float, int>) n_OnLayerDrawn_Landroid_graphics_Canvas_FFI);
			return cb_onLayerDrawn_Landroid_graphics_Canvas_FFI;
		}

		static void n_OnLayerDrawn_Landroid_graphics_Canvas_FFI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2, int p3)
		{
			global::Com.Joanzapata.Pdfview.Listener.IOnDrawListener __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Listener.IOnDrawListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLayerDrawn (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onLayerDrawn_Landroid_graphics_Canvas_FFI;
		public void OnLayerDrawn (global::Android.Graphics.Canvas p0, float p1, float p2, int p3)
		{
			if (id_onLayerDrawn_Landroid_graphics_Canvas_FFI == IntPtr.Zero)
				id_onLayerDrawn_Landroid_graphics_Canvas_FFI = JNIEnv.GetMethodID (class_ref, "onLayerDrawn", "(Landroid/graphics/Canvas;FFI)V");
			JNIEnv.CallVoidMethod (Handle, id_onLayerDrawn_Landroid_graphics_Canvas_FFI, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

	}

	public partial class DrawEventArgs : global::System.EventArgs {

		public DrawEventArgs (global::Android.Graphics.Canvas p0, float p1, float p2, int p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		global::Android.Graphics.Canvas p0;
		public global::Android.Graphics.Canvas P0 {
			get { return p0; }
		}

		float p1;
		public float P1 {
			get { return p1; }
		}

		float p2;
		public float P2 {
			get { return p2; }
		}

		int p3;
		public int P3 {
			get { return p3; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/joanzapata/pdfview/listener/OnDrawListenerImplementor")]
	internal sealed class IOnDrawListenerImplementor : global::Java.Lang.Object, IOnDrawListener {

		object sender;

		public IOnDrawListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/joanzapata/pdfview/listener/OnDrawListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<DrawEventArgs> Handler;
#pragma warning restore 0649

		public void OnLayerDrawn (global::Android.Graphics.Canvas p0, float p1, float p2, int p3)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new DrawEventArgs (p0, p1, p2, p3));
		}

		internal static bool __IsEmpty (IOnDrawListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}

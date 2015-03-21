using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Radaee.Pdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Ink']"
	[global::Android.Runtime.Register ("com/radaee/pdf/Ink", DoNotGenerateAcw=true)]
	public partial class Ink : global::Java.Lang.Object {


		static IntPtr color_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Ink']/field[@name='color']"
		[Register ("color")]
		protected int Color {
			get {
				if (color_jfieldId == IntPtr.Zero)
					color_jfieldId = JNIEnv.GetFieldID (class_ref, "color", "I");
				return JNIEnv.GetIntField (Handle, color_jfieldId);
			}
			set {
				if (color_jfieldId == IntPtr.Zero)
					color_jfieldId = JNIEnv.GetFieldID (class_ref, "color", "I");
				JNIEnv.SetField (Handle, color_jfieldId, value);
			}
		}

		static IntPtr hand_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Ink']/field[@name='hand']"
		[Register ("hand")]
		protected long Hand {
			get {
				if (hand_jfieldId == IntPtr.Zero)
					hand_jfieldId = JNIEnv.GetFieldID (class_ref, "hand", "J");
				return JNIEnv.GetLongField (Handle, hand_jfieldId);
			}
			set {
				if (hand_jfieldId == IntPtr.Zero)
					hand_jfieldId = JNIEnv.GetFieldID (class_ref, "hand", "J");
				JNIEnv.SetField (Handle, hand_jfieldId, value);
			}
		}

		static IntPtr width_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Ink']/field[@name='width']"
		[Register ("width")]
		protected float Width {
			get {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "F");
				return JNIEnv.GetFloatField (Handle, width_jfieldId);
			}
			set {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "F");
				JNIEnv.SetField (Handle, width_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/radaee/pdf/Ink", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Ink); }
		}

		protected Ink (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_F;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Ink']/constructor[@name='Ink' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register (".ctor", "(F)V", "")]
		public Ink (float p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Ink)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(F)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(F)V", new JValue (p0));
				return;
			}

			if (id_ctor_F == IntPtr.Zero)
				id_ctor_F = JNIEnv.GetMethodID (class_ref, "<init>", "(F)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_F, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_F, new JValue (p0));
		}

		static IntPtr id_Destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Ink']/method[@name='Destroy' and count(parameter)=0]"
		[Register ("Destroy", "()V", "")]
		public void Destroy ()
		{
			if (id_Destroy == IntPtr.Zero)
				id_Destroy = JNIEnv.GetMethodID (class_ref, "Destroy", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_Destroy);
		}

		static IntPtr id_OnDown_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Ink']/method[@name='OnDown' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("OnDown", "(FF)V", "")]
		public void OnDown (float p0, float p1)
		{
			if (id_OnDown_FF == IntPtr.Zero)
				id_OnDown_FF = JNIEnv.GetMethodID (class_ref, "OnDown", "(FF)V");
			JNIEnv.CallVoidMethod  (Handle, id_OnDown_FF, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_OnDraw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetOnDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_OnDraw_Landroid_graphics_Canvas_ == null)
				cb_OnDraw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDraw_Landroid_graphics_Canvas_);
			return cb_OnDraw_Landroid_graphics_Canvas_;
		}

		static void n_OnDraw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Pdf.Ink __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Ink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDraw (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnDraw_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Ink']/method[@name='OnDraw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("OnDraw", "(Landroid/graphics/Canvas;)V", "GetOnDraw_Landroid_graphics_Canvas_Handler")]
		public virtual void OnDraw (global::Android.Graphics.Canvas p0)
		{
			if (id_OnDraw_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_OnDraw_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "OnDraw", "(Landroid/graphics/Canvas;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_OnDraw_Landroid_graphics_Canvas_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnDraw", "(Landroid/graphics/Canvas;)V"), new JValue (p0));
		}

		static Delegate cb_OnDraw_Landroid_graphics_Canvas_FF;
#pragma warning disable 0169
		static Delegate GetOnDraw_Landroid_graphics_Canvas_FFHandler ()
		{
			if (cb_OnDraw_Landroid_graphics_Canvas_FF == null)
				cb_OnDraw_Landroid_graphics_Canvas_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float>) n_OnDraw_Landroid_graphics_Canvas_FF);
			return cb_OnDraw_Landroid_graphics_Canvas_FF;
		}

		static void n_OnDraw_Landroid_graphics_Canvas_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2)
		{
			global::Com.Radaee.Pdf.Ink __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Ink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDraw (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_OnDraw_Landroid_graphics_Canvas_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Ink']/method[@name='OnDraw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("OnDraw", "(Landroid/graphics/Canvas;FF)V", "GetOnDraw_Landroid_graphics_Canvas_FFHandler")]
		public virtual void OnDraw (global::Android.Graphics.Canvas p0, float p1, float p2)
		{
			if (id_OnDraw_Landroid_graphics_Canvas_FF == IntPtr.Zero)
				id_OnDraw_Landroid_graphics_Canvas_FF = JNIEnv.GetMethodID (class_ref, "OnDraw", "(Landroid/graphics/Canvas;FF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_OnDraw_Landroid_graphics_Canvas_FF, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnDraw", "(Landroid/graphics/Canvas;FF)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_OnMove_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Ink']/method[@name='OnMove' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("OnMove", "(FF)V", "")]
		public void OnMove (float p0, float p1)
		{
			if (id_OnMove_FF == IntPtr.Zero)
				id_OnMove_FF = JNIEnv.GetMethodID (class_ref, "OnMove", "(FF)V");
			JNIEnv.CallVoidMethod  (Handle, id_OnMove_FF, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_OnUp_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Ink']/method[@name='OnUp' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("OnUp", "(FF)V", "")]
		public void OnUp (float p0, float p1)
		{
			if (id_OnUp_FF == IntPtr.Zero)
				id_OnUp_FF = JNIEnv.GetMethodID (class_ref, "OnUp", "(FF)V");
			JNIEnv.CallVoidMethod  (Handle, id_OnUp_FF, new JValue (p0), new JValue (p1));
		}

	}
}

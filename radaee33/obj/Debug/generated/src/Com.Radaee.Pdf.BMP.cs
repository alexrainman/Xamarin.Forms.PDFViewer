using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Radaee.Pdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.pdf']/class[@name='BMP']"
	[global::Android.Runtime.Register ("com/radaee/pdf/BMP", DoNotGenerateAcw=true)]
	public partial class BMP : global::Java.Lang.Object {


		static IntPtr hand_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='BMP']/field[@name='hand']"
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
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/radaee/pdf/BMP", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BMP); }
		}

		protected BMP (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.pdf']/class[@name='BMP']/constructor[@name='BMP' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public BMP () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BMP)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static IntPtr id_GetHeight;
		public int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='BMP']/method[@name='GetHeight' and count(parameter)=0]"
			[Register ("GetHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_GetHeight == IntPtr.Zero)
					id_GetHeight = JNIEnv.GetMethodID (class_ref, "GetHeight", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_GetHeight);
			}
		}

		static IntPtr id_GetWidth;
		public int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='BMP']/method[@name='GetWidth' and count(parameter)=0]"
			[Register ("GetWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_GetWidth == IntPtr.Zero)
					id_GetWidth = JNIEnv.GetMethodID (class_ref, "GetWidth", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_GetWidth);
			}
		}

		static IntPtr id_Create_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='BMP']/method[@name='Create' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("Create", "(Landroid/graphics/Bitmap;)V", "")]
		public void Create (global::Android.Graphics.Bitmap p0)
		{
			if (id_Create_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_Create_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "Create", "(Landroid/graphics/Bitmap;)V");
			JNIEnv.CallVoidMethod  (Handle, id_Create_Landroid_graphics_Bitmap_, new JValue (p0));
		}

		static IntPtr id_DrawRect_IIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='BMP']/method[@name='DrawRect' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("DrawRect", "(IIIIII)V", "")]
		public void DrawRect (int p0, int p1, int p2, int p3, int p4, int p5)
		{
			if (id_DrawRect_IIIIII == IntPtr.Zero)
				id_DrawRect_IIIIII = JNIEnv.GetMethodID (class_ref, "DrawRect", "(IIIIII)V");
			JNIEnv.CallVoidMethod  (Handle, id_DrawRect_IIIIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
		}

		static IntPtr id_DrawToDIB_Lcom_radaee_pdf_DIB_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='BMP']/method[@name='DrawToDIB' and count(parameter)=3 and parameter[1][@type='com.radaee.pdf.DIB'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("DrawToDIB", "(Lcom/radaee/pdf/DIB;II)V", "")]
		public void DrawToDIB (global::Com.Radaee.Pdf.DIB p0, int p1, int p2)
		{
			if (id_DrawToDIB_Lcom_radaee_pdf_DIB_II == IntPtr.Zero)
				id_DrawToDIB_Lcom_radaee_pdf_DIB_II = JNIEnv.GetMethodID (class_ref, "DrawToDIB", "(Lcom/radaee/pdf/DIB;II)V");
			JNIEnv.CallVoidMethod  (Handle, id_DrawToDIB_Lcom_radaee_pdf_DIB_II, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_Free_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='BMP']/method[@name='Free' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("Free", "(Landroid/graphics/Bitmap;)V", "")]
		public void Free (global::Android.Graphics.Bitmap p0)
		{
			if (id_Free_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_Free_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "Free", "(Landroid/graphics/Bitmap;)V");
			JNIEnv.CallVoidMethod  (Handle, id_Free_Landroid_graphics_Bitmap_, new JValue (p0));
		}

		static IntPtr id_Invert;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='BMP']/method[@name='Invert' and count(parameter)=0]"
		[Register ("Invert", "()V", "")]
		public void Invert ()
		{
			if (id_Invert == IntPtr.Zero)
				id_Invert = JNIEnv.GetMethodID (class_ref, "Invert", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_Invert);
		}

	}
}

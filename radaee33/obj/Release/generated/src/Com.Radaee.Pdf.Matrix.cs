using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Radaee.Pdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Matrix']"
	[global::Android.Runtime.Register ("com/radaee/pdf/Matrix", DoNotGenerateAcw=true)]
	public partial class Matrix : global::Java.Lang.Object {


		static IntPtr hand_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Matrix']/field[@name='hand']"
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
				return JNIEnv.FindClass ("com/radaee/pdf/Matrix", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Matrix); }
		}

		protected Matrix (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_FFFFFF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Matrix']/constructor[@name='Matrix' and count(parameter)=6 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='float']]"
		[Register (".ctor", "(FFFFFF)V", "")]
		public Matrix (float p0, float p1, float p2, float p3, float p4, float p5) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Matrix)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(FFFFFF)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(FFFFFF)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
				return;
			}

			if (id_ctor_FFFFFF == IntPtr.Zero)
				id_ctor_FFFFFF = JNIEnv.GetMethodID (class_ref, "<init>", "(FFFFFF)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FFFFFF, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_FFFFFF, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
		}

		static IntPtr id_ctor_FFFF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Matrix']/constructor[@name='Matrix' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register (".ctor", "(FFFF)V", "")]
		public Matrix (float p0, float p1, float p2, float p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Matrix)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(FFFF)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(FFFF)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				return;
			}

			if (id_ctor_FFFF == IntPtr.Zero)
				id_ctor_FFFF = JNIEnv.GetMethodID (class_ref, "<init>", "(FFFF)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FFFF, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_FFFF, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static IntPtr id_Destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Matrix']/method[@name='Destroy' and count(parameter)=0]"
		[Register ("Destroy", "()V", "")]
		public void Destroy ()
		{
			if (id_Destroy == IntPtr.Zero)
				id_Destroy = JNIEnv.GetMethodID (class_ref, "Destroy", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_Destroy);
		}

		static IntPtr id_Invert;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Matrix']/method[@name='Invert' and count(parameter)=0]"
		[Register ("Invert", "()V", "")]
		public void Invert ()
		{
			if (id_Invert == IntPtr.Zero)
				id_Invert = JNIEnv.GetMethodID (class_ref, "Invert", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_Invert);
		}

		static IntPtr id_TransformInk_Lcom_radaee_pdf_Ink_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Matrix']/method[@name='TransformInk' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Ink']]"
		[Register ("TransformInk", "(Lcom/radaee/pdf/Ink;)V", "")]
		public void TransformInk (global::Com.Radaee.Pdf.Ink p0)
		{
			if (id_TransformInk_Lcom_radaee_pdf_Ink_ == IntPtr.Zero)
				id_TransformInk_Lcom_radaee_pdf_Ink_ = JNIEnv.GetMethodID (class_ref, "TransformInk", "(Lcom/radaee/pdf/Ink;)V");
			JNIEnv.CallVoidMethod  (Handle, id_TransformInk_Lcom_radaee_pdf_Ink_, new JValue (p0));
		}

		static IntPtr id_TransformPath_Lcom_radaee_pdf_Path_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Matrix']/method[@name='TransformPath' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Path']]"
		[Register ("TransformPath", "(Lcom/radaee/pdf/Path;)V", "")]
		public void TransformPath (global::Com.Radaee.Pdf.Path p0)
		{
			if (id_TransformPath_Lcom_radaee_pdf_Path_ == IntPtr.Zero)
				id_TransformPath_Lcom_radaee_pdf_Path_ = JNIEnv.GetMethodID (class_ref, "TransformPath", "(Lcom/radaee/pdf/Path;)V");
			JNIEnv.CallVoidMethod  (Handle, id_TransformPath_Lcom_radaee_pdf_Path_, new JValue (p0));
		}

		static IntPtr id_TransformPoint_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Matrix']/method[@name='TransformPoint' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("TransformPoint", "([F)V", "")]
		public void TransformPoint (float[] p0)
		{
			if (id_TransformPoint_arrayF == IntPtr.Zero)
				id_TransformPoint_arrayF = JNIEnv.GetMethodID (class_ref, "TransformPoint", "([F)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallVoidMethod  (Handle, id_TransformPoint_arrayF, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_TransformRect_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Matrix']/method[@name='TransformRect' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("TransformRect", "([F)V", "")]
		public void TransformRect (float[] p0)
		{
			if (id_TransformRect_arrayF == IntPtr.Zero)
				id_TransformRect_arrayF = JNIEnv.GetMethodID (class_ref, "TransformRect", "([F)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallVoidMethod  (Handle, id_TransformRect_arrayF, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}

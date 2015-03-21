using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Radaee.Pdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.pdf']/class[@name='DIB']"
	[global::Android.Runtime.Register ("com/radaee/pdf/DIB", DoNotGenerateAcw=true)]
	public partial class DIB : global::Java.Lang.Object {


		static IntPtr hand_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='DIB']/field[@name='hand']"
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
				return JNIEnv.FindClass ("com/radaee/pdf/DIB", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DIB); }
		}

		protected DIB (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.pdf']/class[@name='DIB']/constructor[@name='DIB' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DIB () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DIB)) {
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

		static IntPtr id_IsEmpty;
		public bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='DIB']/method[@name='IsEmpty' and count(parameter)=0]"
			[Register ("IsEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				if (id_IsEmpty == IntPtr.Zero)
					id_IsEmpty = JNIEnv.GetMethodID (class_ref, "IsEmpty", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_IsEmpty);
			}
		}

		static IntPtr id_CreateOrResize_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='DIB']/method[@name='CreateOrResize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("CreateOrResize", "(II)V", "")]
		public void CreateOrResize (int p0, int p1)
		{
			if (id_CreateOrResize_II == IntPtr.Zero)
				id_CreateOrResize_II = JNIEnv.GetMethodID (class_ref, "CreateOrResize", "(II)V");
			JNIEnv.CallVoidMethod  (Handle, id_CreateOrResize_II, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_DrawRect_IIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='DIB']/method[@name='DrawRect' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("DrawRect", "(IIIIII)V", "")]
		public void DrawRect (int p0, int p1, int p2, int p3, int p4, int p5)
		{
			if (id_DrawRect_IIIIII == IntPtr.Zero)
				id_DrawRect_IIIIII = JNIEnv.GetMethodID (class_ref, "DrawRect", "(IIIIII)V");
			JNIEnv.CallVoidMethod  (Handle, id_DrawRect_IIIIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
		}

		static IntPtr id_DrawToBmp2_Lcom_radaee_pdf_BMP_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='DIB']/method[@name='DrawToBmp2' and count(parameter)=5 and parameter[1][@type='com.radaee.pdf.BMP'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("DrawToBmp2", "(Lcom/radaee/pdf/BMP;IIII)V", "")]
		public void DrawToBmp2 (global::Com.Radaee.Pdf.BMP p0, int p1, int p2, int p3, int p4)
		{
			if (id_DrawToBmp2_Lcom_radaee_pdf_BMP_IIII == IntPtr.Zero)
				id_DrawToBmp2_Lcom_radaee_pdf_BMP_IIII = JNIEnv.GetMethodID (class_ref, "DrawToBmp2", "(Lcom/radaee/pdf/BMP;IIII)V");
			JNIEnv.CallVoidMethod  (Handle, id_DrawToBmp2_Lcom_radaee_pdf_BMP_IIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static IntPtr id_DrawToBmp_Lcom_radaee_pdf_BMP_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='DIB']/method[@name='DrawToBmp' and count(parameter)=3 and parameter[1][@type='com.radaee.pdf.BMP'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("DrawToBmp", "(Lcom/radaee/pdf/BMP;II)V", "")]
		public void DrawToBmp (global::Com.Radaee.Pdf.BMP p0, int p1, int p2)
		{
			if (id_DrawToBmp_Lcom_radaee_pdf_BMP_II == IntPtr.Zero)
				id_DrawToBmp_Lcom_radaee_pdf_BMP_II = JNIEnv.GetMethodID (class_ref, "DrawToBmp", "(Lcom/radaee/pdf/BMP;II)V");
			JNIEnv.CallVoidMethod  (Handle, id_DrawToBmp_Lcom_radaee_pdf_BMP_II, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_DrawToDIB_Lcom_radaee_pdf_DIB_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='DIB']/method[@name='DrawToDIB' and count(parameter)=3 and parameter[1][@type='com.radaee.pdf.DIB'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("DrawToDIB", "(Lcom/radaee/pdf/DIB;II)V", "")]
		public void DrawToDIB (global::Com.Radaee.Pdf.DIB p0, int p1, int p2)
		{
			if (id_DrawToDIB_Lcom_radaee_pdf_DIB_II == IntPtr.Zero)
				id_DrawToDIB_Lcom_radaee_pdf_DIB_II = JNIEnv.GetMethodID (class_ref, "DrawToDIB", "(Lcom/radaee/pdf/DIB;II)V");
			JNIEnv.CallVoidMethod  (Handle, id_DrawToDIB_Lcom_radaee_pdf_DIB_II, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_Free;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='DIB']/method[@name='Free' and count(parameter)=0]"
		[Register ("Free", "()V", "")]
		public void Free ()
		{
			if (id_Free == IntPtr.Zero)
				id_Free = JNIEnv.GetMethodID (class_ref, "Free", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_Free);
		}

	}
}

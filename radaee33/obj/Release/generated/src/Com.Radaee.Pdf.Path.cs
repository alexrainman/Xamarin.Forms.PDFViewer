using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Radaee.Pdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Path']"
	[global::Android.Runtime.Register ("com/radaee/pdf/Path", DoNotGenerateAcw=true)]
	public partial class Path : global::Java.Lang.Object {


		static IntPtr m_hand_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Path']/field[@name='m_hand']"
		[Register ("m_hand")]
		protected long MHand {
			get {
				if (m_hand_jfieldId == IntPtr.Zero)
					m_hand_jfieldId = JNIEnv.GetFieldID (class_ref, "m_hand", "J");
				return JNIEnv.GetLongField (Handle, m_hand_jfieldId);
			}
			set {
				if (m_hand_jfieldId == IntPtr.Zero)
					m_hand_jfieldId = JNIEnv.GetFieldID (class_ref, "m_hand", "J");
				JNIEnv.SetField (Handle, m_hand_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/radaee/pdf/Path", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Path); }
		}

		protected Path (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Path']/constructor[@name='Path' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Path () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Path)) {
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

		static IntPtr id_GetNodeCount;
		public int NodeCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Path']/method[@name='GetNodeCount' and count(parameter)=0]"
			[Register ("GetNodeCount", "()I", "GetGetNodeCountHandler")]
			get {
				if (id_GetNodeCount == IntPtr.Zero)
					id_GetNodeCount = JNIEnv.GetMethodID (class_ref, "GetNodeCount", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_GetNodeCount);
			}
		}

		static IntPtr id_ClosePath;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Path']/method[@name='ClosePath' and count(parameter)=0]"
		[Register ("ClosePath", "()V", "")]
		public void ClosePath ()
		{
			if (id_ClosePath == IntPtr.Zero)
				id_ClosePath = JNIEnv.GetMethodID (class_ref, "ClosePath", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_ClosePath);
		}

		static IntPtr id_CurveTo_FFFFFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Path']/method[@name='CurveTo' and count(parameter)=6 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='float']]"
		[Register ("CurveTo", "(FFFFFF)V", "")]
		public void CurveTo (float p0, float p1, float p2, float p3, float p4, float p5)
		{
			if (id_CurveTo_FFFFFF == IntPtr.Zero)
				id_CurveTo_FFFFFF = JNIEnv.GetMethodID (class_ref, "CurveTo", "(FFFFFF)V");
			JNIEnv.CallVoidMethod  (Handle, id_CurveTo_FFFFFF, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
		}

		static IntPtr id_Destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Path']/method[@name='Destroy' and count(parameter)=0]"
		[Register ("Destroy", "()V", "")]
		public void Destroy ()
		{
			if (id_Destroy == IntPtr.Zero)
				id_Destroy = JNIEnv.GetMethodID (class_ref, "Destroy", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_Destroy);
		}

		static IntPtr id_GetNode_IarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Path']/method[@name='GetNode' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float[]']]"
		[Register ("GetNode", "(I[F)I", "")]
		public int GetNode (int p0, float[] p1)
		{
			if (id_GetNode_IarrayF == IntPtr.Zero)
				id_GetNode_IarrayF = JNIEnv.GetMethodID (class_ref, "GetNode", "(I[F)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			int __ret = JNIEnv.CallIntMethod  (Handle, id_GetNode_IarrayF, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static IntPtr id_LineTo_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Path']/method[@name='LineTo' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("LineTo", "(FF)V", "")]
		public void LineTo (float p0, float p1)
		{
			if (id_LineTo_FF == IntPtr.Zero)
				id_LineTo_FF = JNIEnv.GetMethodID (class_ref, "LineTo", "(FF)V");
			JNIEnv.CallVoidMethod  (Handle, id_LineTo_FF, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_MoveTo_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Path']/method[@name='MoveTo' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("MoveTo", "(FF)V", "")]
		public void MoveTo (float p0, float p1)
		{
			if (id_MoveTo_FF == IntPtr.Zero)
				id_MoveTo_FF = JNIEnv.GetMethodID (class_ref, "MoveTo", "(FF)V");
			JNIEnv.CallVoidMethod  (Handle, id_MoveTo_FF, new JValue (p0), new JValue (p1));
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Radaee.Pdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']"
	[global::Android.Runtime.Register ("com/radaee/pdf/Global", DoNotGenerateAcw=true)]
	public partial class Global : global::Java.Lang.Object {


		static IntPtr dark_mode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/field[@name='dark_mode']"
		[Register ("dark_mode")]
		public static bool DarkMode {
			get {
				if (dark_mode_jfieldId == IntPtr.Zero)
					dark_mode_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "dark_mode", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, dark_mode_jfieldId);
			}
			set {
				if (dark_mode_jfieldId == IntPtr.Zero)
					dark_mode_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "dark_mode", "Z");
				JNIEnv.SetStaticField (class_ref, dark_mode_jfieldId, value);
			}
		}

		static IntPtr def_view_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/field[@name='def_view']"
		[Register ("def_view")]
		public static int DefView {
			get {
				if (def_view_jfieldId == IntPtr.Zero)
					def_view_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "def_view", "I");
				return JNIEnv.GetStaticIntField (class_ref, def_view_jfieldId);
			}
			set {
				if (def_view_jfieldId == IntPtr.Zero)
					def_view_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "def_view", "I");
				JNIEnv.SetStaticField (class_ref, def_view_jfieldId, value);
			}
		}

		static IntPtr fling_dis_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/field[@name='fling_dis']"
		[Register ("fling_dis")]
		public static float FlingDis {
			get {
				if (fling_dis_jfieldId == IntPtr.Zero)
					fling_dis_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "fling_dis", "F");
				return JNIEnv.GetStaticFloatField (class_ref, fling_dis_jfieldId);
			}
			set {
				if (fling_dis_jfieldId == IntPtr.Zero)
					fling_dis_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "fling_dis", "F");
				JNIEnv.SetStaticField (class_ref, fling_dis_jfieldId, value);
			}
		}

		static IntPtr fling_speed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/field[@name='fling_speed']"
		[Register ("fling_speed")]
		public static float FlingSpeed {
			get {
				if (fling_speed_jfieldId == IntPtr.Zero)
					fling_speed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "fling_speed", "F");
				return JNIEnv.GetStaticFloatField (class_ref, fling_speed_jfieldId);
			}
			set {
				if (fling_speed_jfieldId == IntPtr.Zero)
					fling_speed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "fling_speed", "F");
				JNIEnv.SetStaticField (class_ref, fling_speed_jfieldId, value);
			}
		}

		static IntPtr inkColor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/field[@name='inkColor']"
		[Register ("inkColor")]
		public static int InkColor {
			get {
				if (inkColor_jfieldId == IntPtr.Zero)
					inkColor_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "inkColor", "I");
				return JNIEnv.GetStaticIntField (class_ref, inkColor_jfieldId);
			}
			set {
				if (inkColor_jfieldId == IntPtr.Zero)
					inkColor_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "inkColor", "I");
				JNIEnv.SetStaticField (class_ref, inkColor_jfieldId, value);
			}
		}

		static IntPtr inkWidth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/field[@name='inkWidth']"
		[Register ("inkWidth")]
		public static float InkWidth {
			get {
				if (inkWidth_jfieldId == IntPtr.Zero)
					inkWidth_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "inkWidth", "F");
				return JNIEnv.GetStaticFloatField (class_ref, inkWidth_jfieldId);
			}
			set {
				if (inkWidth_jfieldId == IntPtr.Zero)
					inkWidth_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "inkWidth", "F");
				JNIEnv.SetStaticField (class_ref, inkWidth_jfieldId, value);
			}
		}

		static IntPtr need_time_span_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/field[@name='need_time_span']"
		[Register ("need_time_span")]
		public static bool NeedTimeSpan {
			get {
				if (need_time_span_jfieldId == IntPtr.Zero)
					need_time_span_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "need_time_span", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, need_time_span_jfieldId);
			}
			set {
				if (need_time_span_jfieldId == IntPtr.Zero)
					need_time_span_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "need_time_span", "Z");
				JNIEnv.SetStaticField (class_ref, need_time_span_jfieldId, value);
			}
		}

		static IntPtr rectColor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/field[@name='rectColor']"
		[Register ("rectColor")]
		public static int RectColor {
			get {
				if (rectColor_jfieldId == IntPtr.Zero)
					rectColor_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "rectColor", "I");
				return JNIEnv.GetStaticIntField (class_ref, rectColor_jfieldId);
			}
			set {
				if (rectColor_jfieldId == IntPtr.Zero)
					rectColor_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "rectColor", "I");
				JNIEnv.SetStaticField (class_ref, rectColor_jfieldId, value);
			}
		}

		static IntPtr render_mode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/field[@name='render_mode']"
		[Register ("render_mode")]
		public static int RenderMode {
			get {
				if (render_mode_jfieldId == IntPtr.Zero)
					render_mode_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "render_mode", "I");
				return JNIEnv.GetStaticIntField (class_ref, render_mode_jfieldId);
			}
			set {
				if (render_mode_jfieldId == IntPtr.Zero)
					render_mode_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "render_mode", "I");
				JNIEnv.SetStaticField (class_ref, render_mode_jfieldId, value);
			}
		}

		static IntPtr selColor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/field[@name='selColor']"
		[Register ("selColor")]
		public static int SelColor {
			get {
				if (selColor_jfieldId == IntPtr.Zero)
					selColor_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "selColor", "I");
				return JNIEnv.GetStaticIntField (class_ref, selColor_jfieldId);
			}
			set {
				if (selColor_jfieldId == IntPtr.Zero)
					selColor_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "selColor", "I");
				JNIEnv.SetStaticField (class_ref, selColor_jfieldId, value);
			}
		}

		static IntPtr selRTOL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/field[@name='selRTOL']"
		[Register ("selRTOL")]
		public static bool SelRTOL {
			get {
				if (selRTOL_jfieldId == IntPtr.Zero)
					selRTOL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "selRTOL", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, selRTOL_jfieldId);
			}
			set {
				if (selRTOL_jfieldId == IntPtr.Zero)
					selRTOL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "selRTOL", "Z");
				JNIEnv.SetStaticField (class_ref, selRTOL_jfieldId, value);
			}
		}

		static IntPtr tmp_path_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/field[@name='tmp_path']"
		[Register ("tmp_path")]
		public static string TmpPath {
			get {
				if (tmp_path_jfieldId == IntPtr.Zero)
					tmp_path_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "tmp_path", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, tmp_path_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (tmp_path_jfieldId == IntPtr.Zero)
					tmp_path_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "tmp_path", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, tmp_path_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr zoomLevel_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/field[@name='zoomLevel']"
		[Register ("zoomLevel")]
		public static float ZoomLevel {
			get {
				if (zoomLevel_jfieldId == IntPtr.Zero)
					zoomLevel_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "zoomLevel", "F");
				return JNIEnv.GetStaticFloatField (class_ref, zoomLevel_jfieldId);
			}
			set {
				if (zoomLevel_jfieldId == IntPtr.Zero)
					zoomLevel_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "zoomLevel", "F");
				JNIEnv.SetStaticField (class_ref, zoomLevel_jfieldId, value);
			}
		}

		static IntPtr zoomStep_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/field[@name='zoomStep']"
		[Register ("zoomStep")]
		public static float ZoomStep {
			get {
				if (zoomStep_jfieldId == IntPtr.Zero)
					zoomStep_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "zoomStep", "F");
				return JNIEnv.GetStaticFloatField (class_ref, zoomStep_jfieldId);
			}
			set {
				if (zoomStep_jfieldId == IntPtr.Zero)
					zoomStep_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "zoomStep", "F");
				JNIEnv.SetStaticField (class_ref, zoomStep_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/radaee/pdf/Global", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Global); }
		}

		protected Global (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/constructor[@name='Global' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Global () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Global)) {
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

		static IntPtr id_DrawScroll_Landroid_graphics_Bitmap_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_DIB_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/method[@name='DrawScroll' and count(parameter)=6 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.radaee.pdf.DIB'] and parameter[3][@type='com.radaee.pdf.DIB'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("DrawScroll", "(Landroid/graphics/Bitmap;Lcom/radaee/pdf/DIB;Lcom/radaee/pdf/DIB;III)V", "")]
		public static void DrawScroll (global::Android.Graphics.Bitmap p0, global::Com.Radaee.Pdf.DIB p1, global::Com.Radaee.Pdf.DIB p2, int p3, int p4, int p5)
		{
			if (id_DrawScroll_Landroid_graphics_Bitmap_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_DIB_III == IntPtr.Zero)
				id_DrawScroll_Landroid_graphics_Bitmap_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_DIB_III = JNIEnv.GetStaticMethodID (class_ref, "DrawScroll", "(Landroid/graphics/Bitmap;Lcom/radaee/pdf/DIB;Lcom/radaee/pdf/DIB;III)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_DrawScroll_Landroid_graphics_Bitmap_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_DIB_III, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
		}

		static IntPtr id_Init_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/method[@name='Init' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("Init", "(Landroid/app/Activity;)V", "")]
		public static void Init (global::Android.App.Activity p0)
		{
			if (id_Init_Landroid_app_Activity_ == IntPtr.Zero)
				id_Init_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "Init", "(Landroid/app/Activity;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_Init_Landroid_app_Activity_, new JValue (p0));
		}

		static IntPtr id_RemoveTmp;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/method[@name='RemoveTmp' and count(parameter)=0]"
		[Register ("RemoveTmp", "()V", "")]
		public static void RemoveTmp ()
		{
			if (id_RemoveTmp == IntPtr.Zero)
				id_RemoveTmp = JNIEnv.GetStaticMethodID (class_ref, "RemoveTmp", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_RemoveTmp);
		}

		static IntPtr id_ToDIBPoint_Lcom_radaee_pdf_Matrix_arrayFarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/method[@name='ToDIBPoint' and count(parameter)=3 and parameter[1][@type='com.radaee.pdf.Matrix'] and parameter[2][@type='float[]'] and parameter[3][@type='float[]']]"
		[Register ("ToDIBPoint", "(Lcom/radaee/pdf/Matrix;[F[F)V", "")]
		public static void ToDIBPoint (global::Com.Radaee.Pdf.Matrix p0, float[] p1, float[] p2)
		{
			if (id_ToDIBPoint_Lcom_radaee_pdf_Matrix_arrayFarrayF == IntPtr.Zero)
				id_ToDIBPoint_Lcom_radaee_pdf_Matrix_arrayFarrayF = JNIEnv.GetStaticMethodID (class_ref, "ToDIBPoint", "(Lcom/radaee/pdf/Matrix;[F[F)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_ToDIBPoint_Lcom_radaee_pdf_Matrix_arrayFarrayF, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ToDIBPoint_FIarrayFarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/method[@name='ToDIBPoint' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='int'] and parameter[3][@type='float[]'] and parameter[4][@type='float[]']]"
		[Register ("ToDIBPoint", "(FI[F[F)V", "")]
		public static void ToDIBPoint (float p0, int p1, float[] p2, float[] p3)
		{
			if (id_ToDIBPoint_FIarrayFarrayF == IntPtr.Zero)
				id_ToDIBPoint_FIarrayFarrayF = JNIEnv.GetStaticMethodID (class_ref, "ToDIBPoint", "(FI[F[F)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_ToDIBPoint_FIarrayFarrayF, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3));
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_ToDIBRect_Lcom_radaee_pdf_Matrix_arrayFarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/method[@name='ToDIBRect' and count(parameter)=3 and parameter[1][@type='com.radaee.pdf.Matrix'] and parameter[2][@type='float[]'] and parameter[3][@type='float[]']]"
		[Register ("ToDIBRect", "(Lcom/radaee/pdf/Matrix;[F[F)V", "")]
		public static void ToDIBRect (global::Com.Radaee.Pdf.Matrix p0, float[] p1, float[] p2)
		{
			if (id_ToDIBRect_Lcom_radaee_pdf_Matrix_arrayFarrayF == IntPtr.Zero)
				id_ToDIBRect_Lcom_radaee_pdf_Matrix_arrayFarrayF = JNIEnv.GetStaticMethodID (class_ref, "ToDIBRect", "(Lcom/radaee/pdf/Matrix;[F[F)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_ToDIBRect_Lcom_radaee_pdf_Matrix_arrayFarrayF, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ToDIBRect_FIarrayFarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/method[@name='ToDIBRect' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='int'] and parameter[3][@type='float[]'] and parameter[4][@type='float[]']]"
		[Register ("ToDIBRect", "(FI[F[F)V", "")]
		public static void ToDIBRect (float p0, int p1, float[] p2, float[] p3)
		{
			if (id_ToDIBRect_FIarrayFarrayF == IntPtr.Zero)
				id_ToDIBRect_FIarrayFarrayF = JNIEnv.GetStaticMethodID (class_ref, "ToDIBRect", "(FI[F[F)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_ToDIBRect_FIarrayFarrayF, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3));
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_ToPDFPoint_Lcom_radaee_pdf_Matrix_arrayFarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/method[@name='ToPDFPoint' and count(parameter)=3 and parameter[1][@type='com.radaee.pdf.Matrix'] and parameter[2][@type='float[]'] and parameter[3][@type='float[]']]"
		[Register ("ToPDFPoint", "(Lcom/radaee/pdf/Matrix;[F[F)V", "")]
		public static void ToPDFPoint (global::Com.Radaee.Pdf.Matrix p0, float[] p1, float[] p2)
		{
			if (id_ToPDFPoint_Lcom_radaee_pdf_Matrix_arrayFarrayF == IntPtr.Zero)
				id_ToPDFPoint_Lcom_radaee_pdf_Matrix_arrayFarrayF = JNIEnv.GetStaticMethodID (class_ref, "ToPDFPoint", "(Lcom/radaee/pdf/Matrix;[F[F)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_ToPDFPoint_Lcom_radaee_pdf_Matrix_arrayFarrayF, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ToPDFPoint_FIarrayFarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/method[@name='ToPDFPoint' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='int'] and parameter[3][@type='float[]'] and parameter[4][@type='float[]']]"
		[Register ("ToPDFPoint", "(FI[F[F)V", "")]
		public static void ToPDFPoint (float p0, int p1, float[] p2, float[] p3)
		{
			if (id_ToPDFPoint_FIarrayFarrayF == IntPtr.Zero)
				id_ToPDFPoint_FIarrayFarrayF = JNIEnv.GetStaticMethodID (class_ref, "ToPDFPoint", "(FI[F[F)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_ToPDFPoint_FIarrayFarrayF, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3));
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_ToPDFRect_Lcom_radaee_pdf_Matrix_arrayFarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/method[@name='ToPDFRect' and count(parameter)=3 and parameter[1][@type='com.radaee.pdf.Matrix'] and parameter[2][@type='float[]'] and parameter[3][@type='float[]']]"
		[Register ("ToPDFRect", "(Lcom/radaee/pdf/Matrix;[F[F)V", "")]
		public static void ToPDFRect (global::Com.Radaee.Pdf.Matrix p0, float[] p1, float[] p2)
		{
			if (id_ToPDFRect_Lcom_radaee_pdf_Matrix_arrayFarrayF == IntPtr.Zero)
				id_ToPDFRect_Lcom_radaee_pdf_Matrix_arrayFarrayF = JNIEnv.GetStaticMethodID (class_ref, "ToPDFRect", "(Lcom/radaee/pdf/Matrix;[F[F)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_ToPDFRect_Lcom_radaee_pdf_Matrix_arrayFarrayF, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ToPDFRect_FIarrayFarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/method[@name='ToPDFRect' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='int'] and parameter[3][@type='float[]'] and parameter[4][@type='float[]']]"
		[Register ("ToPDFRect", "(FI[F[F)V", "")]
		public static void ToPDFRect (float p0, int p1, float[] p2, float[] p3)
		{
			if (id_ToPDFRect_FIarrayFarrayF == IntPtr.Zero)
				id_ToPDFRect_FIarrayFarrayF = JNIEnv.GetStaticMethodID (class_ref, "ToPDFRect", "(FI[F[F)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_ToPDFRect_FIarrayFarrayF, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3));
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_activeStandard_Landroid_content_ContextWrapper_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/method[@name='activeStandard' and count(parameter)=4 and parameter[1][@type='android.content.ContextWrapper'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("activeStandard", "(Landroid/content/ContextWrapper;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static bool ActiveStandard (global::Android.Content.ContextWrapper p0, string p1, string p2, string p3)
		{
			if (id_activeStandard_Landroid_content_ContextWrapper_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_activeStandard_Landroid_content_ContextWrapper_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "activeStandard", "(Landroid/content/ContextWrapper;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_activeStandard_Landroid_content_ContextWrapper_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static IntPtr id_default_config;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Global']/method[@name='default_config' and count(parameter)=0]"
		[Register ("default_config", "()V", "")]
		public static void Default_config ()
		{
			if (id_default_config == IntPtr.Zero)
				id_default_config = JNIEnv.GetStaticMethodID (class_ref, "default_config", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_default_config);
		}

	}
}

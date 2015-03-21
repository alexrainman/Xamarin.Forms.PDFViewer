using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Joanzapata.Pdfview.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.joanzapata.pdfview.util']/class[@name='NumberUtils']"
	[global::Android.Runtime.Register ("com/joanzapata/pdfview/util/NumberUtils", DoNotGenerateAcw=true)]
	public partial class NumberUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/joanzapata/pdfview/util/NumberUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NumberUtils); }
		}

		protected NumberUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_limit_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.util']/class[@name='NumberUtils']/method[@name='limit' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("limit", "(III)I", "")]
		public static int Limit (int p0, int p1, int p2)
		{
			if (id_limit_III == IntPtr.Zero)
				id_limit_III = JNIEnv.GetStaticMethodID (class_ref, "limit", "(III)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_limit_III, new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}
}

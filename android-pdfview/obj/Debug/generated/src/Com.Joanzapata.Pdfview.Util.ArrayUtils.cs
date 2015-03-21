using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Joanzapata.Pdfview.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.joanzapata.pdfview.util']/class[@name='ArrayUtils']"
	[global::Android.Runtime.Register ("com/joanzapata/pdfview/util/ArrayUtils", DoNotGenerateAcw=true)]
	public partial class ArrayUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/joanzapata/pdfview/util/ArrayUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ArrayUtils); }
		}

		protected ArrayUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_arrayToString_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.util']/class[@name='ArrayUtils']/method[@name='arrayToString' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("arrayToString", "([I)Ljava/lang/String;", "")]
		public static string ArrayToString (int[] p0)
		{
			if (id_arrayToString_arrayI == IntPtr.Zero)
				id_arrayToString_arrayI = JNIEnv.GetStaticMethodID (class_ref, "arrayToString", "([I)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_arrayToString_arrayI, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_calculateIndexesInDuplicateArray_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.util']/class[@name='ArrayUtils']/method[@name='calculateIndexesInDuplicateArray' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("calculateIndexesInDuplicateArray", "([I)[I", "")]
		public static int[] CalculateIndexesInDuplicateArray (int[] p0)
		{
			if (id_calculateIndexesInDuplicateArray_arrayI == IntPtr.Zero)
				id_calculateIndexesInDuplicateArray_arrayI = JNIEnv.GetStaticMethodID (class_ref, "calculateIndexesInDuplicateArray", "([I)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_calculateIndexesInDuplicateArray_arrayI, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (int));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_deleteDuplicatedPages_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.util']/class[@name='ArrayUtils']/method[@name='deleteDuplicatedPages' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("deleteDuplicatedPages", "([I)[I", "")]
		public static int[] DeleteDuplicatedPages (int[] p0)
		{
			if (id_deleteDuplicatedPages_arrayI == IntPtr.Zero)
				id_deleteDuplicatedPages_arrayI = JNIEnv.GetStaticMethodID (class_ref, "deleteDuplicatedPages", "([I)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_deleteDuplicatedPages_arrayI, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (int));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}
}

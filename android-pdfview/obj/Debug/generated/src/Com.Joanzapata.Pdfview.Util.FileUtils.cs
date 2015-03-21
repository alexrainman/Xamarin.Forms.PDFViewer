using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Joanzapata.Pdfview.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.joanzapata.pdfview.util']/class[@name='FileUtils']"
	[global::Android.Runtime.Register ("com/joanzapata/pdfview/util/FileUtils", DoNotGenerateAcw=true)]
	public partial class FileUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/joanzapata/pdfview/util/FileUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileUtils); }
		}

		protected FileUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_copy_Ljava_io_InputStream_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.util']/class[@name='FileUtils']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.File']]"
		[Register ("copy", "(Ljava/io/InputStream;Ljava/io/File;)V", "")]
		public static void Copy (global::System.IO.Stream p0, global::Java.IO.File p1)
		{
			if (id_copy_Ljava_io_InputStream_Ljava_io_File_ == IntPtr.Zero)
				id_copy_Ljava_io_InputStream_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "copy", "(Ljava/io/InputStream;Ljava/io/File;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_copy_Ljava_io_InputStream_Ljava_io_File_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_fileFromAsset_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.util']/class[@name='FileUtils']/method[@name='fileFromAsset' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("fileFromAsset", "(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;", "")]
		public static global::Java.IO.File FileFromAsset (global::Android.Content.Context p0, string p1)
		{
			if (id_fileFromAsset_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_fileFromAsset_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fileFromAsset", "(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fileFromAsset_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}

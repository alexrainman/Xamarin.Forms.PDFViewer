using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Core.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.vudroid.core.utils']/class[@name='MD5StringUtil']"
	[global::Android.Runtime.Register ("org/vudroid/core/utils/MD5StringUtil", DoNotGenerateAcw=true)]
	public partial class MD5StringUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/vudroid/core/utils/MD5StringUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MD5StringUtil); }
		}

		protected MD5StringUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.vudroid.core.utils']/class[@name='MD5StringUtil']/constructor[@name='MD5StringUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MD5StringUtil () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MD5StringUtil)) {
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

		static IntPtr id_md5StringFor_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.utils']/class[@name='MD5StringUtil']/method[@name='md5StringFor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("md5StringFor", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string Md5StringFor (string p0)
		{
			if (id_md5StringFor_Ljava_lang_String_ == IntPtr.Zero)
				id_md5StringFor_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "md5StringFor", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_md5StringFor_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Core.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.vudroid.core.utils']/class[@name='PathFromUri']"
	[global::Android.Runtime.Register ("org/vudroid/core/utils/PathFromUri", DoNotGenerateAcw=true)]
	public partial class PathFromUri : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/vudroid/core/utils/PathFromUri", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PathFromUri); }
		}

		protected PathFromUri (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.vudroid.core.utils']/class[@name='PathFromUri']/constructor[@name='PathFromUri' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public PathFromUri () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PathFromUri)) {
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

		static IntPtr id_retrieve_Landroid_content_ContentResolver_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core.utils']/class[@name='PathFromUri']/method[@name='retrieve' and count(parameter)=2 and parameter[1][@type='android.content.ContentResolver'] and parameter[2][@type='android.net.Uri']]"
		[Register ("retrieve", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Ljava/lang/String;", "")]
		public static string Retrieve (global::Android.Content.ContentResolver p0, global::Android.Net.Uri p1)
		{
			if (id_retrieve_Landroid_content_ContentResolver_Landroid_net_Uri_ == IntPtr.Zero)
				id_retrieve_Landroid_content_ContentResolver_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "retrieve", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_retrieve_Landroid_content_ContentResolver_Landroid_net_Uri_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}

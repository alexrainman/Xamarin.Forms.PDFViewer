using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Vudroid.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.vudroid.core']/class[@name='VuDroidLibraryLoader']"
	[global::Android.Runtime.Register ("org/vudroid/core/VuDroidLibraryLoader", DoNotGenerateAcw=true)]
	public partial class VuDroidLibraryLoader : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/vudroid/core/VuDroidLibraryLoader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VuDroidLibraryLoader); }
		}

		protected VuDroidLibraryLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.vudroid.core']/class[@name='VuDroidLibraryLoader']/constructor[@name='VuDroidLibraryLoader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public VuDroidLibraryLoader () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (VuDroidLibraryLoader)) {
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

		static IntPtr id_load;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.vudroid.core']/class[@name='VuDroidLibraryLoader']/method[@name='load' and count(parameter)=0]"
		[Register ("load", "()V", "")]
		public static void Load ()
		{
			if (id_load == IntPtr.Zero)
				id_load = JNIEnv.GetStaticMethodID (class_ref, "load", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_load);
		}

	}
}

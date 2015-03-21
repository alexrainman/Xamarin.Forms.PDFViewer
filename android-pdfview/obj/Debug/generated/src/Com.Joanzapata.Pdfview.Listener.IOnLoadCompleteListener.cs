using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Joanzapata.Pdfview.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.joanzapata.pdfview.listener']/interface[@name='OnLoadCompleteListener']"
	[Register ("com/joanzapata/pdfview/listener/OnLoadCompleteListener", "", "Com.Joanzapata.Pdfview.Listener.IOnLoadCompleteListenerInvoker")]
	public partial interface IOnLoadCompleteListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.listener']/interface[@name='OnLoadCompleteListener']/method[@name='loadComplete' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("loadComplete", "(I)V", "GetLoadComplete_IHandler:Com.Joanzapata.Pdfview.Listener.IOnLoadCompleteListenerInvoker, android-pdfview")]
		void LoadComplete (int p0);

	}

	[global::Android.Runtime.Register ("com/joanzapata/pdfview/listener/OnLoadCompleteListener", DoNotGenerateAcw=true)]
	internal class IOnLoadCompleteListenerInvoker : global::Java.Lang.Object, IOnLoadCompleteListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/joanzapata/pdfview/listener/OnLoadCompleteListener");
		IntPtr class_ref;

		public static IOnLoadCompleteListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnLoadCompleteListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.joanzapata.pdfview.listener.OnLoadCompleteListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnLoadCompleteListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOnLoadCompleteListenerInvoker); }
		}

		static Delegate cb_loadComplete_I;
#pragma warning disable 0169
		static Delegate GetLoadComplete_IHandler ()
		{
			if (cb_loadComplete_I == null)
				cb_loadComplete_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_LoadComplete_I);
			return cb_loadComplete_I;
		}

		static void n_LoadComplete_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Joanzapata.Pdfview.Listener.IOnLoadCompleteListener __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Listener.IOnLoadCompleteListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoadComplete (p0);
		}
#pragma warning restore 0169

		IntPtr id_loadComplete_I;
		public void LoadComplete (int p0)
		{
			if (id_loadComplete_I == IntPtr.Zero)
				id_loadComplete_I = JNIEnv.GetMethodID (class_ref, "loadComplete", "(I)V");
			JNIEnv.CallVoidMethod (Handle, id_loadComplete_I, new JValue (p0));
		}

	}

	public partial class LoadCompleteEventArgs : global::System.EventArgs {

		public LoadCompleteEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/joanzapata/pdfview/listener/OnLoadCompleteListenerImplementor")]
	internal sealed class IOnLoadCompleteListenerImplementor : global::Java.Lang.Object, IOnLoadCompleteListener {

		object sender;

		public IOnLoadCompleteListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/joanzapata/pdfview/listener/OnLoadCompleteListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<LoadCompleteEventArgs> Handler;
#pragma warning restore 0649

		public void LoadComplete (int p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new LoadCompleteEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnLoadCompleteListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}

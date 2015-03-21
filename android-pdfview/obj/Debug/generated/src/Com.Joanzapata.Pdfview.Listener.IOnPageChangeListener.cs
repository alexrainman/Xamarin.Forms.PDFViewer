using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Joanzapata.Pdfview.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.joanzapata.pdfview.listener']/interface[@name='OnPageChangeListener']"
	[Register ("com/joanzapata/pdfview/listener/OnPageChangeListener", "", "Com.Joanzapata.Pdfview.Listener.IOnPageChangeListenerInvoker")]
	public partial interface IOnPageChangeListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.listener']/interface[@name='OnPageChangeListener']/method[@name='onPageChanged' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onPageChanged", "(II)V", "GetOnPageChanged_IIHandler:Com.Joanzapata.Pdfview.Listener.IOnPageChangeListenerInvoker, android-pdfview")]
		void OnPageChanged (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/joanzapata/pdfview/listener/OnPageChangeListener", DoNotGenerateAcw=true)]
	internal class IOnPageChangeListenerInvoker : global::Java.Lang.Object, IOnPageChangeListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/joanzapata/pdfview/listener/OnPageChangeListener");
		IntPtr class_ref;

		public static IOnPageChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnPageChangeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.joanzapata.pdfview.listener.OnPageChangeListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnPageChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOnPageChangeListenerInvoker); }
		}

		static Delegate cb_onPageChanged_II;
#pragma warning disable 0169
		static Delegate GetOnPageChanged_IIHandler ()
		{
			if (cb_onPageChanged_II == null)
				cb_onPageChanged_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnPageChanged_II);
			return cb_onPageChanged_II;
		}

		static void n_OnPageChanged_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Joanzapata.Pdfview.Listener.IOnPageChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Listener.IOnPageChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPageChanged (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onPageChanged_II;
		public void OnPageChanged (int p0, int p1)
		{
			if (id_onPageChanged_II == IntPtr.Zero)
				id_onPageChanged_II = JNIEnv.GetMethodID (class_ref, "onPageChanged", "(II)V");
			JNIEnv.CallVoidMethod (Handle, id_onPageChanged_II, new JValue (p0), new JValue (p1));
		}

	}

	public partial class PageChangeEventArgs : global::System.EventArgs {

		public PageChangeEventArgs (int p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/joanzapata/pdfview/listener/OnPageChangeListenerImplementor")]
	internal sealed class IOnPageChangeListenerImplementor : global::Java.Lang.Object, IOnPageChangeListener {

		object sender;

		public IOnPageChangeListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/joanzapata/pdfview/listener/OnPageChangeListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<PageChangeEventArgs> Handler;
#pragma warning restore 0649

		public void OnPageChanged (int p0, int p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new PageChangeEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IOnPageChangeListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}

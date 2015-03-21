using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Radaee.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFViewThumb']"
	[global::Android.Runtime.Register ("com/radaee/view/PDFViewThumb", DoNotGenerateAcw=true)]
	public partial class PDFViewThumb : global::Com.Radaee.View.PDFView {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.radaee.view']/interface[@name='PDFViewThumb.PDFThumbListener']"
		[Register ("com/radaee/view/PDFViewThumb$PDFThumbListener", "", "Com.Radaee.View.PDFViewThumb/IPDFThumbListenerInvoker")]
		public partial interface IPDFThumbListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/interface[@name='PDFViewThumb.PDFThumbListener']/method[@name='OnPageClicked' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("OnPageClicked", "(I)V", "GetOnPageClicked_IHandler:Com.Radaee.View.PDFViewThumb/IPDFThumbListenerInvoker, radaee33")]
			void OnPageClicked (int p0);

		}

		[global::Android.Runtime.Register ("com/radaee/view/PDFViewThumb$PDFThumbListener", DoNotGenerateAcw=true)]
		internal class IPDFThumbListenerInvoker : global::Java.Lang.Object, IPDFThumbListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/radaee/view/PDFViewThumb$PDFThumbListener");
			IntPtr class_ref;

			public static IPDFThumbListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPDFThumbListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.radaee.view.PDFViewThumb.PDFThumbListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPDFThumbListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IPDFThumbListenerInvoker); }
			}

			static Delegate cb_OnPageClicked_I;
#pragma warning disable 0169
			static Delegate GetOnPageClicked_IHandler ()
			{
				if (cb_OnPageClicked_I == null)
					cb_OnPageClicked_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnPageClicked_I);
				return cb_OnPageClicked_I;
			}

			static void n_OnPageClicked_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Radaee.View.PDFViewThumb.IPDFThumbListener __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFViewThumb.IPDFThumbListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPageClicked (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnPageClicked_I;
			public void OnPageClicked (int p0)
			{
				if (id_OnPageClicked_I == IntPtr.Zero)
					id_OnPageClicked_I = JNIEnv.GetMethodID (class_ref, "OnPageClicked", "(I)V");
				JNIEnv.CallVoidMethod (Handle, id_OnPageClicked_I, new JValue (p0));
			}

		}

		public partial class PDFThumbEventArgs : global::System.EventArgs {

			public PDFThumbEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/radaee/view/PDFViewThumb_PDFThumbListenerImplementor")]
		internal sealed class IPDFThumbListenerImplementor : global::Java.Lang.Object, IPDFThumbListener {

			object sender;

			public IPDFThumbListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/radaee/view/PDFViewThumb_PDFThumbListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<PDFThumbEventArgs> Handler;
#pragma warning restore 0649

			public void OnPageClicked (int p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new PDFThumbEventArgs (p0));
			}

			internal static bool __IsEmpty (IPDFThumbListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/radaee/view/PDFViewThumb", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PDFViewThumb); }
		}

		protected PDFViewThumb (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFViewThumb']/constructor[@name='PDFViewThumb' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public PDFViewThumb (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PDFViewThumb)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static Delegate cb_vGetOrientation;
#pragma warning disable 0169
		static Delegate GetVGetOrientationHandler ()
		{
			if (cb_vGetOrientation == null)
				cb_vGetOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_VGetOrientation);
			return cb_vGetOrientation;
		}

		static int n_VGetOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFViewThumb __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFViewThumb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VGetOrientation ();
		}
#pragma warning restore 0169

		static IntPtr id_vGetOrientation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFViewThumb']/method[@name='vGetOrientation' and count(parameter)=0]"
		[Register ("vGetOrientation", "()I", "GetVGetOrientationHandler")]
		public virtual int VGetOrientation ()
		{
			if (id_vGetOrientation == IntPtr.Zero)
				id_vGetOrientation = JNIEnv.GetMethodID (class_ref, "vGetOrientation", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_vGetOrientation);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vGetOrientation", "()I"));
		}

		static Delegate cb_vSetOrientation_I;
#pragma warning disable 0169
		static Delegate GetVSetOrientation_IHandler ()
		{
			if (cb_vSetOrientation_I == null)
				cb_vSetOrientation_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_VSetOrientation_I);
			return cb_vSetOrientation_I;
		}

		static void n_VSetOrientation_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.View.PDFViewThumb __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFViewThumb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VSetOrientation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_vSetOrientation_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFViewThumb']/method[@name='vSetOrientation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("vSetOrientation", "(I)V", "GetVSetOrientation_IHandler")]
		public virtual void VSetOrientation (int p0)
		{
			if (id_vSetOrientation_I == IntPtr.Zero)
				id_vSetOrientation_I = JNIEnv.GetMethodID (class_ref, "vSetOrientation", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vSetOrientation_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vSetOrientation", "(I)V"), new JValue (p0));
		}

		static Delegate cb_vSetSel_I;
#pragma warning disable 0169
		static Delegate GetVSetSel_IHandler ()
		{
			if (cb_vSetSel_I == null)
				cb_vSetSel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_VSetSel_I);
			return cb_vSetSel_I;
		}

		static void n_VSetSel_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.View.PDFViewThumb __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFViewThumb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VSetSel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_vSetSel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFViewThumb']/method[@name='vSetSel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("vSetSel", "(I)V", "GetVSetSel_IHandler")]
		public virtual void VSetSel (int p0)
		{
			if (id_vSetSel_I == IntPtr.Zero)
				id_vSetSel_I = JNIEnv.GetMethodID (class_ref, "vSetSel", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vSetSel_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vSetSel", "(I)V"), new JValue (p0));
		}

		static Delegate cb_vSetThumbListener_Lcom_radaee_view_PDFViewThumb_PDFThumbListener_;
#pragma warning disable 0169
		static Delegate GetVSetThumbListener_Lcom_radaee_view_PDFViewThumb_PDFThumbListener_Handler ()
		{
			if (cb_vSetThumbListener_Lcom_radaee_view_PDFViewThumb_PDFThumbListener_ == null)
				cb_vSetThumbListener_Lcom_radaee_view_PDFViewThumb_PDFThumbListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_VSetThumbListener_Lcom_radaee_view_PDFViewThumb_PDFThumbListener_);
			return cb_vSetThumbListener_Lcom_radaee_view_PDFViewThumb_PDFThumbListener_;
		}

		static void n_VSetThumbListener_Lcom_radaee_view_PDFViewThumb_PDFThumbListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.View.PDFViewThumb __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFViewThumb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.View.PDFViewThumb.IPDFThumbListener p0 = (global::Com.Radaee.View.PDFViewThumb.IPDFThumbListener)global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFViewThumb.IPDFThumbListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VSetThumbListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_vSetThumbListener_Lcom_radaee_view_PDFViewThumb_PDFThumbListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFViewThumb']/method[@name='vSetThumbListener' and count(parameter)=1 and parameter[1][@type='com.radaee.view.PDFViewThumb.PDFThumbListener']]"
		[Register ("vSetThumbListener", "(Lcom/radaee/view/PDFViewThumb$PDFThumbListener;)V", "GetVSetThumbListener_Lcom_radaee_view_PDFViewThumb_PDFThumbListener_Handler")]
		public virtual void VSetThumbListener (global::Com.Radaee.View.PDFViewThumb.IPDFThumbListener p0)
		{
			if (id_vSetThumbListener_Lcom_radaee_view_PDFViewThumb_PDFThumbListener_ == IntPtr.Zero)
				id_vSetThumbListener_Lcom_radaee_view_PDFViewThumb_PDFThumbListener_ = JNIEnv.GetMethodID (class_ref, "vSetThumbListener", "(Lcom/radaee/view/PDFViewThumb$PDFThumbListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_vSetThumbListener_Lcom_radaee_view_PDFViewThumb_PDFThumbListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vSetThumbListener", "(Lcom/radaee/view/PDFViewThumb$PDFThumbListener;)V"), new JValue (p0));
		}

	}
}

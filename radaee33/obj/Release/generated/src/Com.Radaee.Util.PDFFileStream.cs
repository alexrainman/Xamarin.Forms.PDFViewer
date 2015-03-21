using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Radaee.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.util']/class[@name='PDFFileStream']"
	[global::Android.Runtime.Register ("com/radaee/util/PDFFileStream", DoNotGenerateAcw=true)]
	public partial class PDFFileStream : global::Java.Lang.Object, global::Com.Radaee.Pdf.Document.IPDFStream {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/radaee/util/PDFFileStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PDFFileStream); }
		}

		protected PDFFileStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.util']/class[@name='PDFFileStream']/constructor[@name='PDFFileStream' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public PDFFileStream () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PDFFileStream)) {
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

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Util.PDFFileStream __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Util.PDFFileStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.util']/class[@name='PDFFileStream']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_close);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
		}

		static Delegate cb_get_size;
#pragma warning disable 0169
		static Delegate GetGet_sizeHandler ()
		{
			if (cb_get_size == null)
				cb_get_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Get_size);
			return cb_get_size;
		}

		static int n_Get_size (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Util.PDFFileStream __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Util.PDFFileStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_size ();
		}
#pragma warning restore 0169

		static IntPtr id_get_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.util']/class[@name='PDFFileStream']/method[@name='get_size' and count(parameter)=0]"
		[Register ("get_size", "()I", "GetGet_sizeHandler")]
		public virtual int Get_size ()
		{
			if (id_get_size == IntPtr.Zero)
				id_get_size = JNIEnv.GetMethodID (class_ref, "get_size", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_get_size);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_size", "()I"));
		}

		static Delegate cb_open_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpen_Ljava_lang_String_Handler ()
		{
			if (cb_open_Ljava_lang_String_ == null)
				cb_open_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Open_Ljava_lang_String_);
			return cb_open_Ljava_lang_String_;
		}

		static bool n_Open_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Util.PDFFileStream __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Util.PDFFileStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Open (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_open_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.util']/class[@name='PDFFileStream']/method[@name='open' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("open", "(Ljava/lang/String;)Z", "GetOpen_Ljava_lang_String_Handler")]
		public virtual bool Open (string p0)
		{
			if (id_open_Ljava_lang_String_ == IntPtr.Zero)
				id_open_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "open", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_open_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "open", "(Ljava/lang/String;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_read_arrayB;
#pragma warning disable 0169
		static Delegate GetRead_arrayBHandler ()
		{
			if (cb_read_arrayB == null)
				cb_read_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Read_arrayB);
			return cb_read_arrayB;
		}

		static int n_Read_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Util.PDFFileStream __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Util.PDFFileStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Read (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_read_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.util']/class[@name='PDFFileStream']/method[@name='read' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("read", "([B)I", "GetRead_arrayBHandler")]
		public virtual int Read (byte[] p0)
		{
			if (id_read_arrayB == IntPtr.Zero)
				id_read_arrayB = JNIEnv.GetMethodID (class_ref, "read", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_read_arrayB, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "([B)I"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_seek_I;
#pragma warning disable 0169
		static Delegate GetSeek_IHandler ()
		{
			if (cb_seek_I == null)
				cb_seek_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Seek_I);
			return cb_seek_I;
		}

		static void n_Seek_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.Util.PDFFileStream __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Util.PDFFileStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Seek (p0);
		}
#pragma warning restore 0169

		static IntPtr id_seek_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.util']/class[@name='PDFFileStream']/method[@name='seek' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("seek", "(I)V", "GetSeek_IHandler")]
		public virtual void Seek (int p0)
		{
			if (id_seek_I == IntPtr.Zero)
				id_seek_I = JNIEnv.GetMethodID (class_ref, "seek", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_seek_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "seek", "(I)V"), new JValue (p0));
		}

		static Delegate cb_tell;
#pragma warning disable 0169
		static Delegate GetTellHandler ()
		{
			if (cb_tell == null)
				cb_tell = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Tell);
			return cb_tell;
		}

		static int n_Tell (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Util.PDFFileStream __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Util.PDFFileStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Tell ();
		}
#pragma warning restore 0169

		static IntPtr id_tell;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.util']/class[@name='PDFFileStream']/method[@name='tell' and count(parameter)=0]"
		[Register ("tell", "()I", "GetTellHandler")]
		public virtual int Tell ()
		{
			if (id_tell == IntPtr.Zero)
				id_tell = JNIEnv.GetMethodID (class_ref, "tell", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_tell);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "tell", "()I"));
		}

		static Delegate cb_write_arrayB;
#pragma warning disable 0169
		static Delegate GetWrite_arrayBHandler ()
		{
			if (cb_write_arrayB == null)
				cb_write_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Write_arrayB);
			return cb_write_arrayB;
		}

		static int n_Write_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Util.PDFFileStream __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Util.PDFFileStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Write (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_write_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.util']/class[@name='PDFFileStream']/method[@name='write' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("write", "([B)I", "GetWrite_arrayBHandler")]
		public virtual int Write (byte[] p0)
		{
			if (id_write_arrayB == IntPtr.Zero)
				id_write_arrayB = JNIEnv.GetMethodID (class_ref, "write", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_write_arrayB, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "([B)I"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_writeable;
#pragma warning disable 0169
		static Delegate GetWriteableHandler ()
		{
			if (cb_writeable == null)
				cb_writeable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Writeable);
			return cb_writeable;
		}

		static bool n_Writeable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Util.PDFFileStream __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Util.PDFFileStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Writeable ();
		}
#pragma warning restore 0169

		static IntPtr id_writeable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.util']/class[@name='PDFFileStream']/method[@name='writeable' and count(parameter)=0]"
		[Register ("writeable", "()Z", "GetWriteableHandler")]
		public virtual bool Writeable ()
		{
			if (id_writeable == IntPtr.Zero)
				id_writeable = JNIEnv.GetMethodID (class_ref, "writeable", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_writeable);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeable", "()Z"));
		}

	}
}

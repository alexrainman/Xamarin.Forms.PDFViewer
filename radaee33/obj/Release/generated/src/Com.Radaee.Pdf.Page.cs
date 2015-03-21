using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Radaee.Pdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']"
	[global::Android.Runtime.Register ("com/radaee/pdf/Page", DoNotGenerateAcw=true)]
	public partial class Page : global::Java.Lang.Object {


		static IntPtr hand_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/field[@name='hand']"
		[Register ("hand")]
		protected long Hand {
			get {
				if (hand_jfieldId == IntPtr.Zero)
					hand_jfieldId = JNIEnv.GetFieldID (class_ref, "hand", "J");
				return JNIEnv.GetLongField (Handle, hand_jfieldId);
			}
			set {
				if (hand_jfieldId == IntPtr.Zero)
					hand_jfieldId = JNIEnv.GetFieldID (class_ref, "hand", "J");
				JNIEnv.SetField (Handle, hand_jfieldId, value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']"
		[global::Android.Runtime.Register ("com/radaee/pdf/Page$Annotation", DoNotGenerateAcw=true)]
		public partial class Annotation : global::Java.Lang.Object {


			static IntPtr hand_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/field[@name='hand']"
			[Register ("hand")]
			protected long Hand {
				get {
					if (hand_jfieldId == IntPtr.Zero)
						hand_jfieldId = JNIEnv.GetFieldID (class_ref, "hand", "J");
					return JNIEnv.GetLongField (Handle, hand_jfieldId);
				}
				set {
					if (hand_jfieldId == IntPtr.Zero)
						hand_jfieldId = JNIEnv.GetFieldID (class_ref, "hand", "J");
					JNIEnv.SetField (Handle, hand_jfieldId, value);
				}
			}

			static IntPtr page_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/field[@name='page']"
			[Register ("page")]
			protected global::Com.Radaee.Pdf.Page Page {
				get {
					if (page_jfieldId == IntPtr.Zero)
						page_jfieldId = JNIEnv.GetFieldID (class_ref, "page", "Lcom/radaee/pdf/Page;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, page_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (page_jfieldId == IntPtr.Zero)
						page_jfieldId = JNIEnv.GetFieldID (class_ref, "page", "Lcom/radaee/pdf/Page;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, page_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/radaee/pdf/Page$Annotation", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Annotation); }
			}

			protected Annotation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_radaee_pdf_Page_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/constructor[@name='Page.Annotation' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Page']]"
			[Register (".ctor", "(Lcom/radaee/pdf/Page;)V", "")]
			public Annotation (global::Com.Radaee.Pdf.Page __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Annotation)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self));
					return;
				}

				if (id_ctor_Lcom_radaee_pdf_Page_ == IntPtr.Zero)
					id_ctor_Lcom_radaee_pdf_Page_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/radaee/pdf/Page;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_radaee_pdf_Page_, new JValue (__self)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_radaee_pdf_Page_, new JValue (__self));
			}

			static Delegate cb_GetAttachment;
#pragma warning disable 0169
			static Delegate GetGetAttachmentHandler ()
			{
				if (cb_GetAttachment == null)
					cb_GetAttachment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttachment);
				return cb_GetAttachment;
			}

			static IntPtr n_GetAttachment (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Attachment);
			}
#pragma warning restore 0169

			static IntPtr id_GetAttachment;
			public virtual string Attachment {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetAttachment' and count(parameter)=0]"
				[Register ("GetAttachment", "()Ljava/lang/String;", "GetGetAttachmentHandler")]
				get {
					if (id_GetAttachment == IntPtr.Zero)
						id_GetAttachment = JNIEnv.GetMethodID (class_ref, "GetAttachment", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetAttachment), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetAttachment", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_GetCheckStatus;
#pragma warning disable 0169
			static Delegate GetGetCheckStatusHandler ()
			{
				if (cb_GetCheckStatus == null)
					cb_GetCheckStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCheckStatus);
				return cb_GetCheckStatus;
			}

			static int n_GetCheckStatus (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CheckStatus;
			}
#pragma warning restore 0169

			static IntPtr id_GetCheckStatus;
			public virtual int CheckStatus {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetCheckStatus' and count(parameter)=0]"
				[Register ("GetCheckStatus", "()I", "GetGetCheckStatusHandler")]
				get {
					if (id_GetCheckStatus == IntPtr.Zero)
						id_GetCheckStatus = JNIEnv.GetMethodID (class_ref, "GetCheckStatus", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_GetCheckStatus);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetCheckStatus", "()I"));
				}
			}

			static Delegate cb_GetComboItemCount;
#pragma warning disable 0169
			static Delegate GetGetComboItemCountHandler ()
			{
				if (cb_GetComboItemCount == null)
					cb_GetComboItemCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetComboItemCount);
				return cb_GetComboItemCount;
			}

			static int n_GetComboItemCount (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ComboItemCount;
			}
#pragma warning restore 0169

			static IntPtr id_GetComboItemCount;
			public virtual int ComboItemCount {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetComboItemCount' and count(parameter)=0]"
				[Register ("GetComboItemCount", "()I", "GetGetComboItemCountHandler")]
				get {
					if (id_GetComboItemCount == IntPtr.Zero)
						id_GetComboItemCount = JNIEnv.GetMethodID (class_ref, "GetComboItemCount", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_GetComboItemCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetComboItemCount", "()I"));
				}
			}

			static Delegate cb_GetComboItemSel;
#pragma warning disable 0169
			static Delegate GetGetComboItemSelHandler ()
			{
				if (cb_GetComboItemSel == null)
					cb_GetComboItemSel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetComboItemSel);
				return cb_GetComboItemSel;
			}

			static int n_GetComboItemSel (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ComboItemSel;
			}
#pragma warning restore 0169

			static IntPtr id_GetComboItemSel;
			public virtual int ComboItemSel {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetComboItemSel' and count(parameter)=0]"
				[Register ("GetComboItemSel", "()I", "GetGetComboItemSelHandler")]
				get {
					if (id_GetComboItemSel == IntPtr.Zero)
						id_GetComboItemSel = JNIEnv.GetMethodID (class_ref, "GetComboItemSel", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_GetComboItemSel);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetComboItemSel", "()I"));
				}
			}

			static Delegate cb_GetDest;
#pragma warning disable 0169
			static Delegate GetGetDestHandler ()
			{
				if (cb_GetDest == null)
					cb_GetDest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDest);
				return cb_GetDest;
			}

			static int n_GetDest (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Dest;
			}
#pragma warning restore 0169

			static IntPtr id_GetDest;
			public virtual int Dest {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetDest' and count(parameter)=0]"
				[Register ("GetDest", "()I", "GetGetDestHandler")]
				get {
					if (id_GetDest == IntPtr.Zero)
						id_GetDest = JNIEnv.GetMethodID (class_ref, "GetDest", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_GetDest);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetDest", "()I"));
				}
			}

			static Delegate cb_GetEditMaxlen;
#pragma warning disable 0169
			static Delegate GetGetEditMaxlenHandler ()
			{
				if (cb_GetEditMaxlen == null)
					cb_GetEditMaxlen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEditMaxlen);
				return cb_GetEditMaxlen;
			}

			static int n_GetEditMaxlen (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.EditMaxlen;
			}
#pragma warning restore 0169

			static IntPtr id_GetEditMaxlen;
			public virtual int EditMaxlen {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetEditMaxlen' and count(parameter)=0]"
				[Register ("GetEditMaxlen", "()I", "GetGetEditMaxlenHandler")]
				get {
					if (id_GetEditMaxlen == IntPtr.Zero)
						id_GetEditMaxlen = JNIEnv.GetMethodID (class_ref, "GetEditMaxlen", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_GetEditMaxlen);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetEditMaxlen", "()I"));
				}
			}

			static Delegate cb_GetEditText;
#pragma warning disable 0169
			static Delegate GetGetEditTextHandler ()
			{
				if (cb_GetEditText == null)
					cb_GetEditText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEditText);
				return cb_GetEditText;
			}

			static IntPtr n_GetEditText (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.EditText);
			}
#pragma warning restore 0169

			static IntPtr id_GetEditText;
			public virtual string EditText {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetEditText' and count(parameter)=0]"
				[Register ("GetEditText", "()Ljava/lang/String;", "GetGetEditTextHandler")]
				get {
					if (id_GetEditText == IntPtr.Zero)
						id_GetEditText = JNIEnv.GetMethodID (class_ref, "GetEditText", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetEditText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetEditText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_GetEditTextColor;
#pragma warning disable 0169
			static Delegate GetGetEditTextColorHandler ()
			{
				if (cb_GetEditTextColor == null)
					cb_GetEditTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEditTextColor);
				return cb_GetEditTextColor;
			}

			static int n_GetEditTextColor (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.EditTextColor;
			}
#pragma warning restore 0169

			static IntPtr id_GetEditTextColor;
			public virtual int EditTextColor {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetEditTextColor' and count(parameter)=0]"
				[Register ("GetEditTextColor", "()I", "GetGetEditTextColorHandler")]
				get {
					if (id_GetEditTextColor == IntPtr.Zero)
						id_GetEditTextColor = JNIEnv.GetMethodID (class_ref, "GetEditTextColor", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_GetEditTextColor);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetEditTextColor", "()I"));
				}
			}

			static Delegate cb_GetEditTextFormat;
#pragma warning disable 0169
			static Delegate GetGetEditTextFormatHandler ()
			{
				if (cb_GetEditTextFormat == null)
					cb_GetEditTextFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEditTextFormat);
				return cb_GetEditTextFormat;
			}

			static IntPtr n_GetEditTextFormat (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.EditTextFormat);
			}
#pragma warning restore 0169

			static IntPtr id_GetEditTextFormat;
			public virtual string EditTextFormat {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetEditTextFormat' and count(parameter)=0]"
				[Register ("GetEditTextFormat", "()Ljava/lang/String;", "GetGetEditTextFormatHandler")]
				get {
					if (id_GetEditTextFormat == IntPtr.Zero)
						id_GetEditTextFormat = JNIEnv.GetMethodID (class_ref, "GetEditTextFormat", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetEditTextFormat), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetEditTextFormat", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_GetEditTextSize;
#pragma warning disable 0169
			static Delegate GetGetEditTextSizeHandler ()
			{
				if (cb_GetEditTextSize == null)
					cb_GetEditTextSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetEditTextSize);
				return cb_GetEditTextSize;
			}

			static float n_GetEditTextSize (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.EditTextSize;
			}
#pragma warning restore 0169

			static IntPtr id_GetEditTextSize;
			public virtual float EditTextSize {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetEditTextSize' and count(parameter)=0]"
				[Register ("GetEditTextSize", "()F", "GetGetEditTextSizeHandler")]
				get {
					if (id_GetEditTextSize == IntPtr.Zero)
						id_GetEditTextSize = JNIEnv.GetMethodID (class_ref, "GetEditTextSize", "()F");

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_GetEditTextSize);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetEditTextSize", "()F"));
				}
			}

			static Delegate cb_GetEditType;
#pragma warning disable 0169
			static Delegate GetGetEditTypeHandler ()
			{
				if (cb_GetEditType == null)
					cb_GetEditType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEditType);
				return cb_GetEditType;
			}

			static int n_GetEditType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.EditType;
			}
#pragma warning restore 0169

			static IntPtr id_GetEditType;
			public virtual int EditType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetEditType' and count(parameter)=0]"
				[Register ("GetEditType", "()I", "GetGetEditTypeHandler")]
				get {
					if (id_GetEditType == IntPtr.Zero)
						id_GetEditType = JNIEnv.GetMethodID (class_ref, "GetEditType", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_GetEditType);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetEditType", "()I"));
				}
			}

			static Delegate cb_GetFieldFormat;
#pragma warning disable 0169
			static Delegate GetGetFieldFormatHandler ()
			{
				if (cb_GetFieldFormat == null)
					cb_GetFieldFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFieldFormat);
				return cb_GetFieldFormat;
			}

			static IntPtr n_GetFieldFormat (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.FieldFormat);
			}
#pragma warning restore 0169

			static IntPtr id_GetFieldFormat;
			public virtual string FieldFormat {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetFieldFormat' and count(parameter)=0]"
				[Register ("GetFieldFormat", "()Ljava/lang/String;", "GetGetFieldFormatHandler")]
				get {
					if (id_GetFieldFormat == IntPtr.Zero)
						id_GetFieldFormat = JNIEnv.GetMethodID (class_ref, "GetFieldFormat", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetFieldFormat), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetFieldFormat", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_GetFieldFullName;
#pragma warning disable 0169
			static Delegate GetGetFieldFullNameHandler ()
			{
				if (cb_GetFieldFullName == null)
					cb_GetFieldFullName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFieldFullName);
				return cb_GetFieldFullName;
			}

			static IntPtr n_GetFieldFullName (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.FieldFullName);
			}
#pragma warning restore 0169

			static IntPtr id_GetFieldFullName;
			public virtual string FieldFullName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetFieldFullName' and count(parameter)=0]"
				[Register ("GetFieldFullName", "()Ljava/lang/String;", "GetGetFieldFullNameHandler")]
				get {
					if (id_GetFieldFullName == IntPtr.Zero)
						id_GetFieldFullName = JNIEnv.GetMethodID (class_ref, "GetFieldFullName", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetFieldFullName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetFieldFullName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_GetFieldFullName2;
#pragma warning disable 0169
			static Delegate GetGetFieldFullName2Handler ()
			{
				if (cb_GetFieldFullName2 == null)
					cb_GetFieldFullName2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFieldFullName2);
				return cb_GetFieldFullName2;
			}

			static IntPtr n_GetFieldFullName2 (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.FieldFullName2);
			}
#pragma warning restore 0169

			static IntPtr id_GetFieldFullName2;
			public virtual string FieldFullName2 {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetFieldFullName2' and count(parameter)=0]"
				[Register ("GetFieldFullName2", "()Ljava/lang/String;", "GetGetFieldFullName2Handler")]
				get {
					if (id_GetFieldFullName2 == IntPtr.Zero)
						id_GetFieldFullName2 = JNIEnv.GetMethodID (class_ref, "GetFieldFullName2", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetFieldFullName2), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetFieldFullName2", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_GetFieldName;
#pragma warning disable 0169
			static Delegate GetGetFieldNameHandler ()
			{
				if (cb_GetFieldName == null)
					cb_GetFieldName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFieldName);
				return cb_GetFieldName;
			}

			static IntPtr n_GetFieldName (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.FieldName);
			}
#pragma warning restore 0169

			static IntPtr id_GetFieldName;
			public virtual string FieldName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetFieldName' and count(parameter)=0]"
				[Register ("GetFieldName", "()Ljava/lang/String;", "GetGetFieldNameHandler")]
				get {
					if (id_GetFieldName == IntPtr.Zero)
						id_GetFieldName = JNIEnv.GetMethodID (class_ref, "GetFieldName", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetFieldName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetFieldName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_GetFieldType;
#pragma warning disable 0169
			static Delegate GetGetFieldTypeHandler ()
			{
				if (cb_GetFieldType == null)
					cb_GetFieldType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFieldType);
				return cb_GetFieldType;
			}

			static int n_GetFieldType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.FieldType;
			}
#pragma warning restore 0169

			static IntPtr id_GetFieldType;
			public virtual int FieldType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetFieldType' and count(parameter)=0]"
				[Register ("GetFieldType", "()I", "GetGetFieldTypeHandler")]
				get {
					if (id_GetFieldType == IntPtr.Zero)
						id_GetFieldType = JNIEnv.GetMethodID (class_ref, "GetFieldType", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_GetFieldType);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetFieldType", "()I"));
				}
			}

			static Delegate cb_GetFileLink;
#pragma warning disable 0169
			static Delegate GetGetFileLinkHandler ()
			{
				if (cb_GetFileLink == null)
					cb_GetFileLink = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileLink);
				return cb_GetFileLink;
			}

			static IntPtr n_GetFileLink (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.FileLink);
			}
#pragma warning restore 0169

			static IntPtr id_GetFileLink;
			public virtual string FileLink {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetFileLink' and count(parameter)=0]"
				[Register ("GetFileLink", "()Ljava/lang/String;", "GetGetFileLinkHandler")]
				get {
					if (id_GetFileLink == IntPtr.Zero)
						id_GetFileLink = JNIEnv.GetMethodID (class_ref, "GetFileLink", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetFileLink), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetFileLink", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_GetFillColor;
#pragma warning disable 0169
			static Delegate GetGetFillColorHandler ()
			{
				if (cb_GetFillColor == null)
					cb_GetFillColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFillColor);
				return cb_GetFillColor;
			}

			static int n_GetFillColor (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.FillColor;
			}
#pragma warning restore 0169

			static IntPtr id_GetFillColor;
			public virtual int FillColor {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetFillColor' and count(parameter)=0]"
				[Register ("GetFillColor", "()I", "GetGetFillColorHandler")]
				get {
					if (id_GetFillColor == IntPtr.Zero)
						id_GetFillColor = JNIEnv.GetMethodID (class_ref, "GetFillColor", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_GetFillColor);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetFillColor", "()I"));
				}
			}

			static Delegate cb_IsHide;
#pragma warning disable 0169
			static Delegate GetIsHideHandler ()
			{
				if (cb_IsHide == null)
					cb_IsHide = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHide);
				return cb_IsHide;
			}

			static bool n_IsHide (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Hide;
			}
#pragma warning restore 0169

			static Delegate cb_SetHide_Z;
#pragma warning disable 0169
			static Delegate GetSetHide_ZHandler ()
			{
				if (cb_SetHide_Z == null)
					cb_SetHide_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHide_Z);
				return cb_SetHide_Z;
			}

			static void n_SetHide_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Hide = p0;
			}
#pragma warning restore 0169

			static IntPtr id_IsHide;
			static IntPtr id_SetHide_Z;
			public virtual bool Hide {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='IsHide' and count(parameter)=0]"
				[Register ("IsHide", "()Z", "GetIsHideHandler")]
				get {
					if (id_IsHide == IntPtr.Zero)
						id_IsHide = JNIEnv.GetMethodID (class_ref, "IsHide", "()Z");

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_IsHide);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "IsHide", "()Z"));
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='SetHide' and count(parameter)=1 and parameter[1][@type='boolean']]"
				[Register ("SetHide", "(Z)V", "GetSetHide_ZHandler")]
				set {
					if (id_SetHide_Z == IntPtr.Zero)
						id_SetHide_Z = JNIEnv.GetMethodID (class_ref, "SetHide", "(Z)V");

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_SetHide_Z, new JValue (value));
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetHide", "(Z)V"), new JValue (value));
				}
			}

			static Delegate cb_GetIcon;
#pragma warning disable 0169
			static Delegate GetGetIconHandler ()
			{
				if (cb_GetIcon == null)
					cb_GetIcon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIcon);
				return cb_GetIcon;
			}

			static int n_GetIcon (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Icon;
			}
#pragma warning restore 0169

			static IntPtr id_GetIcon;
			public virtual int Icon {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetIcon' and count(parameter)=0]"
				[Register ("GetIcon", "()I", "GetGetIconHandler")]
				get {
					if (id_GetIcon == IntPtr.Zero)
						id_GetIcon = JNIEnv.GetMethodID (class_ref, "GetIcon", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_GetIcon);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetIcon", "()I"));
				}
			}

			static Delegate cb_GetIndexInPage;
#pragma warning disable 0169
			static Delegate GetGetIndexInPageHandler ()
			{
				if (cb_GetIndexInPage == null)
					cb_GetIndexInPage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndexInPage);
				return cb_GetIndexInPage;
			}

			static int n_GetIndexInPage (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IndexInPage;
			}
#pragma warning restore 0169

			static IntPtr id_GetIndexInPage;
			public virtual int IndexInPage {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetIndexInPage' and count(parameter)=0]"
				[Register ("GetIndexInPage", "()I", "GetGetIndexInPageHandler")]
				get {
					if (id_GetIndexInPage == IntPtr.Zero)
						id_GetIndexInPage = JNIEnv.GetMethodID (class_ref, "GetIndexInPage", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_GetIndexInPage);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetIndexInPage", "()I"));
				}
			}

			static Delegate cb_GetInkPath;
#pragma warning disable 0169
			static Delegate GetGetInkPathHandler ()
			{
				if (cb_GetInkPath == null)
					cb_GetInkPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInkPath);
				return cb_GetInkPath;
			}

			static IntPtr n_GetInkPath (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.InkPath);
			}
#pragma warning restore 0169

			static IntPtr id_GetInkPath;
			public virtual global::Com.Radaee.Pdf.Path InkPath {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetInkPath' and count(parameter)=0]"
				[Register ("GetInkPath", "()Lcom/radaee/pdf/Path;", "GetGetInkPathHandler")]
				get {
					if (id_GetInkPath == IntPtr.Zero)
						id_GetInkPath = JNIEnv.GetMethodID (class_ref, "GetInkPath", "()Lcom/radaee/pdf/Path;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Path> (JNIEnv.CallObjectMethod  (Handle, id_GetInkPath), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Path> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetInkPath", "()Lcom/radaee/pdf/Path;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_IsLockedContent;
#pragma warning disable 0169
			static Delegate GetIsLockedContentHandler ()
			{
				if (cb_IsLockedContent == null)
					cb_IsLockedContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLockedContent);
				return cb_IsLockedContent;
			}

			static bool n_IsLockedContent (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsLockedContent;
			}
#pragma warning restore 0169

			static IntPtr id_IsLockedContent;
			public virtual bool IsLockedContent {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='IsLockedContent' and count(parameter)=0]"
				[Register ("IsLockedContent", "()Z", "GetIsLockedContentHandler")]
				get {
					if (id_IsLockedContent == IntPtr.Zero)
						id_IsLockedContent = JNIEnv.GetMethodID (class_ref, "IsLockedContent", "()Z");

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_IsLockedContent);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "IsLockedContent", "()Z"));
				}
			}

			static Delegate cb_GetJS;
#pragma warning disable 0169
			static Delegate GetGetJSHandler ()
			{
				if (cb_GetJS == null)
					cb_GetJS = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJS);
				return cb_GetJS;
			}

			static IntPtr n_GetJS (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.JS);
			}
#pragma warning restore 0169

			static IntPtr id_GetJS;
			public virtual string JS {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetJS' and count(parameter)=0]"
				[Register ("GetJS", "()Ljava/lang/String;", "GetGetJSHandler")]
				get {
					if (id_GetJS == IntPtr.Zero)
						id_GetJS = JNIEnv.GetMethodID (class_ref, "GetJS", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetJS), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetJS", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_GetListItemCount;
#pragma warning disable 0169
			static Delegate GetGetListItemCountHandler ()
			{
				if (cb_GetListItemCount == null)
					cb_GetListItemCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetListItemCount);
				return cb_GetListItemCount;
			}

			static int n_GetListItemCount (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ListItemCount;
			}
#pragma warning restore 0169

			static IntPtr id_GetListItemCount;
			public virtual int ListItemCount {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetListItemCount' and count(parameter)=0]"
				[Register ("GetListItemCount", "()I", "GetGetListItemCountHandler")]
				get {
					if (id_GetListItemCount == IntPtr.Zero)
						id_GetListItemCount = JNIEnv.GetMethodID (class_ref, "GetListItemCount", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_GetListItemCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetListItemCount", "()I"));
				}
			}

			static Delegate cb_IsLocked;
#pragma warning disable 0169
			static Delegate GetIsLockedHandler ()
			{
				if (cb_IsLocked == null)
					cb_IsLocked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLocked);
				return cb_IsLocked;
			}

			static bool n_IsLocked (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Locked;
			}
#pragma warning restore 0169

			static Delegate cb_SetLocked_Z;
#pragma warning disable 0169
			static Delegate GetSetLocked_ZHandler ()
			{
				if (cb_SetLocked_Z == null)
					cb_SetLocked_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetLocked_Z);
				return cb_SetLocked_Z;
			}

			static void n_SetLocked_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Locked = p0;
			}
#pragma warning restore 0169

			static IntPtr id_IsLocked;
			static IntPtr id_SetLocked_Z;
			public virtual bool Locked {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='IsLocked' and count(parameter)=0]"
				[Register ("IsLocked", "()Z", "GetIsLockedHandler")]
				get {
					if (id_IsLocked == IntPtr.Zero)
						id_IsLocked = JNIEnv.GetMethodID (class_ref, "IsLocked", "()Z");

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_IsLocked);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "IsLocked", "()Z"));
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='SetLocked' and count(parameter)=1 and parameter[1][@type='boolean']]"
				[Register ("SetLocked", "(Z)V", "GetSetLocked_ZHandler")]
				set {
					if (id_SetLocked_Z == IntPtr.Zero)
						id_SetLocked_Z = JNIEnv.GetMethodID (class_ref, "SetLocked", "(Z)V");

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_SetLocked_Z, new JValue (value));
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetLocked", "(Z)V"), new JValue (value));
				}
			}

			static Delegate cb_GetMovie;
#pragma warning disable 0169
			static Delegate GetGetMovieHandler ()
			{
				if (cb_GetMovie == null)
					cb_GetMovie = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMovie);
				return cb_GetMovie;
			}

			static IntPtr n_GetMovie (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Movie);
			}
#pragma warning restore 0169

			static IntPtr id_GetMovie;
			public virtual string Movie {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetMovie' and count(parameter)=0]"
				[Register ("GetMovie", "()Ljava/lang/String;", "GetGetMovieHandler")]
				get {
					if (id_GetMovie == IntPtr.Zero)
						id_GetMovie = JNIEnv.GetMethodID (class_ref, "GetMovie", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetMovie), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetMovie", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_GetName;
#pragma warning disable 0169
			static Delegate GetGetNameHandler ()
			{
				if (cb_GetName == null)
					cb_GetName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
				return cb_GetName;
			}

			static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Name);
			}
#pragma warning restore 0169

			static IntPtr id_GetName;
			public virtual string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetName' and count(parameter)=0]"
				[Register ("GetName", "()Ljava/lang/String;", "GetGetNameHandler")]
				get {
					if (id_GetName == IntPtr.Zero)
						id_GetName = JNIEnv.GetMethodID (class_ref, "GetName", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_GetPolygonPath;
#pragma warning disable 0169
			static Delegate GetGetPolygonPathHandler ()
			{
				if (cb_GetPolygonPath == null)
					cb_GetPolygonPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPolygonPath);
				return cb_GetPolygonPath;
			}

			static IntPtr n_GetPolygonPath (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.PolygonPath);
			}
#pragma warning restore 0169

			static IntPtr id_GetPolygonPath;
			public virtual global::Com.Radaee.Pdf.Path PolygonPath {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetPolygonPath' and count(parameter)=0]"
				[Register ("GetPolygonPath", "()Lcom/radaee/pdf/Path;", "GetGetPolygonPathHandler")]
				get {
					if (id_GetPolygonPath == IntPtr.Zero)
						id_GetPolygonPath = JNIEnv.GetMethodID (class_ref, "GetPolygonPath", "()Lcom/radaee/pdf/Path;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Path> (JNIEnv.CallObjectMethod  (Handle, id_GetPolygonPath), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Path> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetPolygonPath", "()Lcom/radaee/pdf/Path;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_GetPolylinePath;
#pragma warning disable 0169
			static Delegate GetGetPolylinePathHandler ()
			{
				if (cb_GetPolylinePath == null)
					cb_GetPolylinePath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPolylinePath);
				return cb_GetPolylinePath;
			}

			static IntPtr n_GetPolylinePath (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.PolylinePath);
			}
#pragma warning restore 0169

			static IntPtr id_GetPolylinePath;
			public virtual global::Com.Radaee.Pdf.Path PolylinePath {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetPolylinePath' and count(parameter)=0]"
				[Register ("GetPolylinePath", "()Lcom/radaee/pdf/Path;", "GetGetPolylinePathHandler")]
				get {
					if (id_GetPolylinePath == IntPtr.Zero)
						id_GetPolylinePath = JNIEnv.GetMethodID (class_ref, "GetPolylinePath", "()Lcom/radaee/pdf/Path;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Path> (JNIEnv.CallObjectMethod  (Handle, id_GetPolylinePath), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Path> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetPolylinePath", "()Lcom/radaee/pdf/Path;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_GetPopupSubject;
#pragma warning disable 0169
			static Delegate GetGetPopupSubjectHandler ()
			{
				if (cb_GetPopupSubject == null)
					cb_GetPopupSubject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPopupSubject);
				return cb_GetPopupSubject;
			}

			static IntPtr n_GetPopupSubject (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.PopupSubject);
			}
#pragma warning restore 0169

			static IntPtr id_GetPopupSubject;
			public virtual string PopupSubject {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetPopupSubject' and count(parameter)=0]"
				[Register ("GetPopupSubject", "()Ljava/lang/String;", "GetGetPopupSubjectHandler")]
				get {
					if (id_GetPopupSubject == IntPtr.Zero)
						id_GetPopupSubject = JNIEnv.GetMethodID (class_ref, "GetPopupSubject", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetPopupSubject), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetPopupSubject", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_GetPopupText;
#pragma warning disable 0169
			static Delegate GetGetPopupTextHandler ()
			{
				if (cb_GetPopupText == null)
					cb_GetPopupText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPopupText);
				return cb_GetPopupText;
			}

			static IntPtr n_GetPopupText (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.PopupText);
			}
#pragma warning restore 0169

			static IntPtr id_GetPopupText;
			public virtual string PopupText {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetPopupText' and count(parameter)=0]"
				[Register ("GetPopupText", "()Ljava/lang/String;", "GetGetPopupTextHandler")]
				get {
					if (id_GetPopupText == IntPtr.Zero)
						id_GetPopupText = JNIEnv.GetMethodID (class_ref, "GetPopupText", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetPopupText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetPopupText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_GetReset;
#pragma warning disable 0169
			static Delegate GetGetResetHandler ()
			{
				if (cb_GetReset == null)
					cb_GetReset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetReset);
				return cb_GetReset;
			}

			static bool n_GetReset (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Reset;
			}
#pragma warning restore 0169

			static IntPtr id_GetReset;
			public virtual bool Reset {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetReset' and count(parameter)=0]"
				[Register ("GetReset", "()Z", "GetGetResetHandler")]
				get {
					if (id_GetReset == IntPtr.Zero)
						id_GetReset = JNIEnv.GetMethodID (class_ref, "GetReset", "()Z");

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_GetReset);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetReset", "()Z"));
				}
			}

			static Delegate cb_GetSignStatus;
#pragma warning disable 0169
			static Delegate GetGetSignStatusHandler ()
			{
				if (cb_GetSignStatus == null)
					cb_GetSignStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSignStatus);
				return cb_GetSignStatus;
			}

			static int n_GetSignStatus (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.SignStatus;
			}
#pragma warning restore 0169

			static IntPtr id_GetSignStatus;
			public virtual int SignStatus {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetSignStatus' and count(parameter)=0]"
				[Register ("GetSignStatus", "()I", "GetGetSignStatusHandler")]
				get {
					if (id_GetSignStatus == IntPtr.Zero)
						id_GetSignStatus = JNIEnv.GetMethodID (class_ref, "GetSignStatus", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_GetSignStatus);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSignStatus", "()I"));
				}
			}

			static Delegate cb_GetSound;
#pragma warning disable 0169
			static Delegate GetGetSoundHandler ()
			{
				if (cb_GetSound == null)
					cb_GetSound = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSound);
				return cb_GetSound;
			}

			static IntPtr n_GetSound (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Sound);
			}
#pragma warning restore 0169

			static IntPtr id_GetSound;
			public virtual string Sound {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetSound' and count(parameter)=0]"
				[Register ("GetSound", "()Ljava/lang/String;", "GetGetSoundHandler")]
				get {
					if (id_GetSound == IntPtr.Zero)
						id_GetSound = JNIEnv.GetMethodID (class_ref, "GetSound", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetSound), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSound", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_GetStrokeColor;
#pragma warning disable 0169
			static Delegate GetGetStrokeColorHandler ()
			{
				if (cb_GetStrokeColor == null)
					cb_GetStrokeColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStrokeColor);
				return cb_GetStrokeColor;
			}

			static int n_GetStrokeColor (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.StrokeColor;
			}
#pragma warning restore 0169

			static IntPtr id_GetStrokeColor;
			public virtual int StrokeColor {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetStrokeColor' and count(parameter)=0]"
				[Register ("GetStrokeColor", "()I", "GetGetStrokeColorHandler")]
				get {
					if (id_GetStrokeColor == IntPtr.Zero)
						id_GetStrokeColor = JNIEnv.GetMethodID (class_ref, "GetStrokeColor", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_GetStrokeColor);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetStrokeColor", "()I"));
				}
			}

			static Delegate cb_GetStrokeWidth;
#pragma warning disable 0169
			static Delegate GetGetStrokeWidthHandler ()
			{
				if (cb_GetStrokeWidth == null)
					cb_GetStrokeWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetStrokeWidth);
				return cb_GetStrokeWidth;
			}

			static float n_GetStrokeWidth (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.StrokeWidth;
			}
#pragma warning restore 0169

			static IntPtr id_GetStrokeWidth;
			public virtual float StrokeWidth {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetStrokeWidth' and count(parameter)=0]"
				[Register ("GetStrokeWidth", "()F", "GetGetStrokeWidthHandler")]
				get {
					if (id_GetStrokeWidth == IntPtr.Zero)
						id_GetStrokeWidth = JNIEnv.GetMethodID (class_ref, "GetStrokeWidth", "()F");

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_GetStrokeWidth);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetStrokeWidth", "()F"));
				}
			}

			static Delegate cb_GetSubmitPara;
#pragma warning disable 0169
			static Delegate GetGetSubmitParaHandler ()
			{
				if (cb_GetSubmitPara == null)
					cb_GetSubmitPara = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubmitPara);
				return cb_GetSubmitPara;
			}

			static IntPtr n_GetSubmitPara (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.SubmitPara);
			}
#pragma warning restore 0169

			static IntPtr id_GetSubmitPara;
			public virtual string SubmitPara {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetSubmitPara' and count(parameter)=0]"
				[Register ("GetSubmitPara", "()Ljava/lang/String;", "GetGetSubmitParaHandler")]
				get {
					if (id_GetSubmitPara == IntPtr.Zero)
						id_GetSubmitPara = JNIEnv.GetMethodID (class_ref, "GetSubmitPara", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetSubmitPara), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSubmitPara", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_GetSubmitTarget;
#pragma warning disable 0169
			static Delegate GetGetSubmitTargetHandler ()
			{
				if (cb_GetSubmitTarget == null)
					cb_GetSubmitTarget = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubmitTarget);
				return cb_GetSubmitTarget;
			}

			static IntPtr n_GetSubmitTarget (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.SubmitTarget);
			}
#pragma warning restore 0169

			static IntPtr id_GetSubmitTarget;
			public virtual string SubmitTarget {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetSubmitTarget' and count(parameter)=0]"
				[Register ("GetSubmitTarget", "()Ljava/lang/String;", "GetGetSubmitTargetHandler")]
				get {
					if (id_GetSubmitTarget == IntPtr.Zero)
						id_GetSubmitTarget = JNIEnv.GetMethodID (class_ref, "GetSubmitTarget", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetSubmitTarget), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSubmitTarget", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_GetType;
#pragma warning disable 0169
			static Delegate GetGetTypeHandler ()
			{
				if (cb_GetType == null)
					cb_GetType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
				return cb_GetType;
			}

			static int n_GetType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Type;
			}
#pragma warning restore 0169

			static IntPtr id_GetType;
			public virtual int Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetType' and count(parameter)=0]"
				[Register ("GetType", "()I", "GetGetTypeHandler")]
				get {
					if (id_GetType == IntPtr.Zero)
						id_GetType = JNIEnv.GetMethodID (class_ref, "GetType", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_GetType);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetType", "()I"));
				}
			}

			static Delegate cb_GetURI;
#pragma warning disable 0169
			static Delegate GetGetURIHandler ()
			{
				if (cb_GetURI == null)
					cb_GetURI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetURI);
				return cb_GetURI;
			}

			static IntPtr n_GetURI (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.URI);
			}
#pragma warning restore 0169

			static IntPtr id_GetURI;
			public virtual string URI {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetURI' and count(parameter)=0]"
				[Register ("GetURI", "()Ljava/lang/String;", "GetGetURIHandler")]
				get {
					if (id_GetURI == IntPtr.Zero)
						id_GetURI = JNIEnv.GetMethodID (class_ref, "GetURI", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetURI), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetURI", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_Get3D;
#pragma warning disable 0169
			static Delegate GetGet3DHandler ()
			{
				if (cb_Get3D == null)
					cb_Get3D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get3D);
				return cb_Get3D;
			}

			static IntPtr n_Get3D (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Get3D ());
			}
#pragma warning restore 0169

			static IntPtr id_Get3D;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='Get3D' and count(parameter)=0]"
			[Register ("Get3D", "()Ljava/lang/String;", "GetGet3DHandler")]
			public virtual string Get3D ()
			{
				if (id_Get3D == IntPtr.Zero)
					id_Get3D = JNIEnv.GetMethodID (class_ref, "Get3D", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_Get3D), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Get3D", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_Get3DData_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGet3DData_Ljava_lang_String_Handler ()
			{
				if (cb_Get3DData_Ljava_lang_String_ == null)
					cb_Get3DData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Get3DData_Ljava_lang_String_);
				return cb_Get3DData_Ljava_lang_String_;
			}

			static bool n_Get3DData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Get3DData (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_Get3DData_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='Get3DData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("Get3DData", "(Ljava/lang/String;)Z", "GetGet3DData_Ljava_lang_String_Handler")]
			public virtual bool Get3DData (string p0)
			{
				if (id_Get3DData_Ljava_lang_String_ == IntPtr.Zero)
					id_Get3DData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "Get3DData", "(Ljava/lang/String;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_Get3DData_Ljava_lang_String_, new JValue (native_p0));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Get3DData", "(Ljava/lang/String;)Z"), new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_GetAttachmentData_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetAttachmentData_Ljava_lang_String_Handler ()
			{
				if (cb_GetAttachmentData_Ljava_lang_String_ == null)
					cb_GetAttachmentData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetAttachmentData_Ljava_lang_String_);
				return cb_GetAttachmentData_Ljava_lang_String_;
			}

			static bool n_GetAttachmentData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.GetAttachmentData (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_GetAttachmentData_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetAttachmentData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("GetAttachmentData", "(Ljava/lang/String;)Z", "GetGetAttachmentData_Ljava_lang_String_Handler")]
			public virtual bool GetAttachmentData (string p0)
			{
				if (id_GetAttachmentData_Ljava_lang_String_ == IntPtr.Zero)
					id_GetAttachmentData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "GetAttachmentData", "(Ljava/lang/String;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_GetAttachmentData_Ljava_lang_String_, new JValue (native_p0));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetAttachmentData", "(Ljava/lang/String;)Z"), new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_GetComboItem_I;
#pragma warning disable 0169
			static Delegate GetGetComboItem_IHandler ()
			{
				if (cb_GetComboItem_I == null)
					cb_GetComboItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetComboItem_I);
				return cb_GetComboItem_I;
			}

			static IntPtr n_GetComboItem_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.GetComboItem (p0));
			}
#pragma warning restore 0169

			static IntPtr id_GetComboItem_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetComboItem' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("GetComboItem", "(I)Ljava/lang/String;", "GetGetComboItem_IHandler")]
			public virtual string GetComboItem (int p0)
			{
				if (id_GetComboItem_I == IntPtr.Zero)
					id_GetComboItem_I = JNIEnv.GetMethodID (class_ref, "GetComboItem", "(I)Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetComboItem_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetComboItem", "(I)Ljava/lang/String;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_GetEditTextRect_arrayF;
#pragma warning disable 0169
			static Delegate GetGetEditTextRect_arrayFHandler ()
			{
				if (cb_GetEditTextRect_arrayF == null)
					cb_GetEditTextRect_arrayF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetEditTextRect_arrayF);
				return cb_GetEditTextRect_arrayF;
			}

			static bool n_GetEditTextRect_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
				bool __ret = __this.GetEditTextRect (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_GetEditTextRect_arrayF;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetEditTextRect' and count(parameter)=1 and parameter[1][@type='float[]']]"
			[Register ("GetEditTextRect", "([F)Z", "GetGetEditTextRect_arrayFHandler")]
			public virtual bool GetEditTextRect (float[] p0)
			{
				if (id_GetEditTextRect_arrayF == IntPtr.Zero)
					id_GetEditTextRect_arrayF = JNIEnv.GetMethodID (class_ref, "GetEditTextRect", "([F)Z");
				IntPtr native_p0 = JNIEnv.NewArray (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_GetEditTextRect_arrayF, new JValue (native_p0));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetEditTextRect", "([F)Z"), new JValue (native_p0));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static Delegate cb_GetListItem_I;
#pragma warning disable 0169
			static Delegate GetGetListItem_IHandler ()
			{
				if (cb_GetListItem_I == null)
					cb_GetListItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetListItem_I);
				return cb_GetListItem_I;
			}

			static IntPtr n_GetListItem_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.GetListItem (p0));
			}
#pragma warning restore 0169

			static IntPtr id_GetListItem_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetListItem' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("GetListItem", "(I)Ljava/lang/String;", "GetGetListItem_IHandler")]
			public virtual string GetListItem (int p0)
			{
				if (id_GetListItem_I == IntPtr.Zero)
					id_GetListItem_I = JNIEnv.GetMethodID (class_ref, "GetListItem", "(I)Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetListItem_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetListItem", "(I)Ljava/lang/String;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_GetListSels;
#pragma warning disable 0169
			static Delegate GetGetListSelsHandler ()
			{
				if (cb_GetListSels == null)
					cb_GetListSels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetListSels);
				return cb_GetListSels;
			}

			static IntPtr n_GetListSels (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetListSels ());
			}
#pragma warning restore 0169

			static IntPtr id_GetListSels;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetListSels' and count(parameter)=0]"
			[Register ("GetListSels", "()[I", "GetGetListSelsHandler")]
			public virtual int[] GetListSels ()
			{
				if (id_GetListSels == IntPtr.Zero)
					id_GetListSels = JNIEnv.GetMethodID (class_ref, "GetListSels", "()[I");

				if (GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_GetListSels), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetListSels", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			}

			static Delegate cb_GetMarkupRects;
#pragma warning disable 0169
			static Delegate GetGetMarkupRectsHandler ()
			{
				if (cb_GetMarkupRects == null)
					cb_GetMarkupRects = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMarkupRects);
				return cb_GetMarkupRects;
			}

			static IntPtr n_GetMarkupRects (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetMarkupRects ());
			}
#pragma warning restore 0169

			static IntPtr id_GetMarkupRects;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetMarkupRects' and count(parameter)=0]"
			[Register ("GetMarkupRects", "()[F", "GetGetMarkupRectsHandler")]
			public virtual float[] GetMarkupRects ()
			{
				if (id_GetMarkupRects == IntPtr.Zero)
					id_GetMarkupRects = JNIEnv.GetMethodID (class_ref, "GetMarkupRects", "()[F");

				if (GetType () == ThresholdType)
					return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_GetMarkupRects), JniHandleOwnership.TransferLocalRef, typeof (float));
				else
					return (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetMarkupRects", "()[F")), JniHandleOwnership.TransferLocalRef, typeof (float));
			}

			static Delegate cb_GetMovieData_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetMovieData_Ljava_lang_String_Handler ()
			{
				if (cb_GetMovieData_Ljava_lang_String_ == null)
					cb_GetMovieData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetMovieData_Ljava_lang_String_);
				return cb_GetMovieData_Ljava_lang_String_;
			}

			static bool n_GetMovieData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.GetMovieData (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_GetMovieData_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetMovieData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("GetMovieData", "(Ljava/lang/String;)Z", "GetGetMovieData_Ljava_lang_String_Handler")]
			public virtual bool GetMovieData (string p0)
			{
				if (id_GetMovieData_Ljava_lang_String_ == IntPtr.Zero)
					id_GetMovieData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "GetMovieData", "(Ljava/lang/String;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_GetMovieData_Ljava_lang_String_, new JValue (native_p0));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetMovieData", "(Ljava/lang/String;)Z"), new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_GetRect;
#pragma warning disable 0169
			static Delegate GetGetRectHandler ()
			{
				if (cb_GetRect == null)
					cb_GetRect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRect);
				return cb_GetRect;
			}

			static IntPtr n_GetRect (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetRect ());
			}
#pragma warning restore 0169

			static IntPtr id_GetRect;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetRect' and count(parameter)=0]"
			[Register ("GetRect", "()[F", "GetGetRectHandler")]
			public virtual float[] GetRect ()
			{
				if (id_GetRect == IntPtr.Zero)
					id_GetRect = JNIEnv.GetMethodID (class_ref, "GetRect", "()[F");

				if (GetType () == ThresholdType)
					return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_GetRect), JniHandleOwnership.TransferLocalRef, typeof (float));
				else
					return (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetRect", "()[F")), JniHandleOwnership.TransferLocalRef, typeof (float));
			}

			static Delegate cb_GetSoundData_arrayILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetSoundData_arrayILjava_lang_String_Handler ()
			{
				if (cb_GetSoundData_arrayILjava_lang_String_ == null)
					cb_GetSoundData_arrayILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_GetSoundData_arrayILjava_lang_String_);
				return cb_GetSoundData_arrayILjava_lang_String_;
			}

			static bool n_GetSoundData_arrayILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.GetSoundData (p0, p1);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_GetSoundData_arrayILjava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='GetSoundData' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='java.lang.String']]"
			[Register ("GetSoundData", "([ILjava/lang/String;)Z", "GetGetSoundData_arrayILjava_lang_String_Handler")]
			public virtual bool GetSoundData (int[] p0, string p1)
			{
				if (id_GetSoundData_arrayILjava_lang_String_ == IntPtr.Zero)
					id_GetSoundData_arrayILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "GetSoundData", "([ILjava/lang/String;)Z");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_GetSoundData_arrayILjava_lang_String_, new JValue (native_p0), new JValue (native_p1));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSoundData", "([ILjava/lang/String;)Z"), new JValue (native_p0), new JValue (native_p1));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
				return __ret;
			}

			static Delegate cb_MoveToPage_Lcom_radaee_pdf_Page_arrayF;
#pragma warning disable 0169
			static Delegate GetMoveToPage_Lcom_radaee_pdf_Page_arrayFHandler ()
			{
				if (cb_MoveToPage_Lcom_radaee_pdf_Page_arrayF == null)
					cb_MoveToPage_Lcom_radaee_pdf_Page_arrayF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_MoveToPage_Lcom_radaee_pdf_Page_arrayF);
				return cb_MoveToPage_Lcom_radaee_pdf_Page_arrayF;
			}

			static bool n_MoveToPage_Lcom_radaee_pdf_Page_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Radaee.Pdf.Page p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (native_p0, JniHandleOwnership.DoNotTransfer);
				float[] p1 = (float[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (float));
				bool __ret = __this.MoveToPage (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_MoveToPage_Lcom_radaee_pdf_Page_arrayF;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='MoveToPage' and count(parameter)=2 and parameter[1][@type='com.radaee.pdf.Page'] and parameter[2][@type='float[]']]"
			[Register ("MoveToPage", "(Lcom/radaee/pdf/Page;[F)Z", "GetMoveToPage_Lcom_radaee_pdf_Page_arrayFHandler")]
			public virtual bool MoveToPage (global::Com.Radaee.Pdf.Page p0, float[] p1)
			{
				if (id_MoveToPage_Lcom_radaee_pdf_Page_arrayF == IntPtr.Zero)
					id_MoveToPage_Lcom_radaee_pdf_Page_arrayF = JNIEnv.GetMethodID (class_ref, "MoveToPage", "(Lcom/radaee/pdf/Page;[F)Z");
				IntPtr native_p1 = JNIEnv.NewArray (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_MoveToPage_Lcom_radaee_pdf_Page_arrayF, new JValue (p0), new JValue (native_p1));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "MoveToPage", "(Lcom/radaee/pdf/Page;[F)Z"), new JValue (p0), new JValue (native_p1));
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return __ret;
			}

			static Delegate cb_RemoveFromPage;
#pragma warning disable 0169
			static Delegate GetRemoveFromPageHandler ()
			{
				if (cb_RemoveFromPage == null)
					cb_RemoveFromPage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_RemoveFromPage);
				return cb_RemoveFromPage;
			}

			static bool n_RemoveFromPage (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.RemoveFromPage ();
			}
#pragma warning restore 0169

			static IntPtr id_RemoveFromPage;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='RemoveFromPage' and count(parameter)=0]"
			[Register ("RemoveFromPage", "()Z", "GetRemoveFromPageHandler")]
			public virtual bool RemoveFromPage ()
			{
				if (id_RemoveFromPage == IntPtr.Zero)
					id_RemoveFromPage = JNIEnv.GetMethodID (class_ref, "RemoveFromPage", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_RemoveFromPage);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RemoveFromPage", "()Z"));
			}

			static Delegate cb_RenderToBmp_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetRenderToBmp_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_RenderToBmp_Landroid_graphics_Bitmap_ == null)
					cb_RenderToBmp_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RenderToBmp_Landroid_graphics_Bitmap_);
				return cb_RenderToBmp_Landroid_graphics_Bitmap_;
			}

			static bool n_RenderToBmp_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.RenderToBmp (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_RenderToBmp_Landroid_graphics_Bitmap_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='RenderToBmp' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("RenderToBmp", "(Landroid/graphics/Bitmap;)Z", "GetRenderToBmp_Landroid_graphics_Bitmap_Handler")]
			public virtual bool RenderToBmp (global::Android.Graphics.Bitmap p0)
			{
				if (id_RenderToBmp_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_RenderToBmp_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "RenderToBmp", "(Landroid/graphics/Bitmap;)Z");

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_RenderToBmp_Landroid_graphics_Bitmap_, new JValue (p0));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RenderToBmp", "(Landroid/graphics/Bitmap;)Z"), new JValue (p0));
				return __ret;
			}

			static Delegate cb_SetCheckValue_Z;
#pragma warning disable 0169
			static Delegate GetSetCheckValue_ZHandler ()
			{
				if (cb_SetCheckValue_Z == null)
					cb_SetCheckValue_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_SetCheckValue_Z);
				return cb_SetCheckValue_Z;
			}

			static bool n_SetCheckValue_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.SetCheckValue (p0);
			}
#pragma warning restore 0169

			static IntPtr id_SetCheckValue_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='SetCheckValue' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("SetCheckValue", "(Z)Z", "GetSetCheckValue_ZHandler")]
			public virtual bool SetCheckValue (bool p0)
			{
				if (id_SetCheckValue_Z == IntPtr.Zero)
					id_SetCheckValue_Z = JNIEnv.GetMethodID (class_ref, "SetCheckValue", "(Z)Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_SetCheckValue_Z, new JValue (p0));
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetCheckValue", "(Z)Z"), new JValue (p0));
			}

			static Delegate cb_SetComboItem_I;
#pragma warning disable 0169
			static Delegate GetSetComboItem_IHandler ()
			{
				if (cb_SetComboItem_I == null)
					cb_SetComboItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_SetComboItem_I);
				return cb_SetComboItem_I;
			}

			static bool n_SetComboItem_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.SetComboItem (p0);
			}
#pragma warning restore 0169

			static IntPtr id_SetComboItem_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='SetComboItem' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("SetComboItem", "(I)Z", "GetSetComboItem_IHandler")]
			public virtual bool SetComboItem (int p0)
			{
				if (id_SetComboItem_I == IntPtr.Zero)
					id_SetComboItem_I = JNIEnv.GetMethodID (class_ref, "SetComboItem", "(I)Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_SetComboItem_I, new JValue (p0));
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetComboItem", "(I)Z"), new JValue (p0));
			}

			static Delegate cb_SetEditText_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetEditText_Ljava_lang_String_Handler ()
			{
				if (cb_SetEditText_Ljava_lang_String_ == null)
					cb_SetEditText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetEditText_Ljava_lang_String_);
				return cb_SetEditText_Ljava_lang_String_;
			}

			static bool n_SetEditText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.SetEditText (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_SetEditText_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='SetEditText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetEditText", "(Ljava/lang/String;)Z", "GetSetEditText_Ljava_lang_String_Handler")]
			public virtual bool SetEditText (string p0)
			{
				if (id_SetEditText_Ljava_lang_String_ == IntPtr.Zero)
					id_SetEditText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetEditText", "(Ljava/lang/String;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_SetEditText_Ljava_lang_String_, new JValue (native_p0));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetEditText", "(Ljava/lang/String;)Z"), new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_SetEditTextColor_I;
#pragma warning disable 0169
			static Delegate GetSetEditTextColor_IHandler ()
			{
				if (cb_SetEditTextColor_I == null)
					cb_SetEditTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_SetEditTextColor_I);
				return cb_SetEditTextColor_I;
			}

			static bool n_SetEditTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.SetEditTextColor (p0);
			}
#pragma warning restore 0169

			static IntPtr id_SetEditTextColor_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='SetEditTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("SetEditTextColor", "(I)Z", "GetSetEditTextColor_IHandler")]
			public virtual bool SetEditTextColor (int p0)
			{
				if (id_SetEditTextColor_I == IntPtr.Zero)
					id_SetEditTextColor_I = JNIEnv.GetMethodID (class_ref, "SetEditTextColor", "(I)Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_SetEditTextColor_I, new JValue (p0));
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetEditTextColor", "(I)Z"), new JValue (p0));
			}

			static Delegate cb_SetFillColor_I;
#pragma warning disable 0169
			static Delegate GetSetFillColor_IHandler ()
			{
				if (cb_SetFillColor_I == null)
					cb_SetFillColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_SetFillColor_I);
				return cb_SetFillColor_I;
			}

			static bool n_SetFillColor_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.SetFillColor (p0);
			}
#pragma warning restore 0169

			static IntPtr id_SetFillColor_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='SetFillColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("SetFillColor", "(I)Z", "GetSetFillColor_IHandler")]
			public virtual bool SetFillColor (int p0)
			{
				if (id_SetFillColor_I == IntPtr.Zero)
					id_SetFillColor_I = JNIEnv.GetMethodID (class_ref, "SetFillColor", "(I)Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_SetFillColor_I, new JValue (p0));
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetFillColor", "(I)Z"), new JValue (p0));
			}

			static Delegate cb_SetIcon_I;
#pragma warning disable 0169
			static Delegate GetSetIcon_IHandler ()
			{
				if (cb_SetIcon_I == null)
					cb_SetIcon_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_SetIcon_I);
				return cb_SetIcon_I;
			}

			static bool n_SetIcon_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.SetIcon (p0);
			}
#pragma warning restore 0169

			static IntPtr id_SetIcon_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='SetIcon' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("SetIcon", "(I)Z", "GetSetIcon_IHandler")]
			public virtual bool SetIcon (int p0)
			{
				if (id_SetIcon_I == IntPtr.Zero)
					id_SetIcon_I = JNIEnv.GetMethodID (class_ref, "SetIcon", "(I)Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_SetIcon_I, new JValue (p0));
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetIcon", "(I)Z"), new JValue (p0));
			}

			static Delegate cb_SetIcon_Ljava_lang_String_Lcom_radaee_pdf_PageContent_;
#pragma warning disable 0169
			static Delegate GetSetIcon_Ljava_lang_String_Lcom_radaee_pdf_PageContent_Handler ()
			{
				if (cb_SetIcon_Ljava_lang_String_Lcom_radaee_pdf_PageContent_ == null)
					cb_SetIcon_Ljava_lang_String_Lcom_radaee_pdf_PageContent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_SetIcon_Ljava_lang_String_Lcom_radaee_pdf_PageContent_);
				return cb_SetIcon_Ljava_lang_String_Lcom_radaee_pdf_PageContent_;
			}

			static bool n_SetIcon_Ljava_lang_String_Lcom_radaee_pdf_PageContent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Radaee.Pdf.PageContent p1 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.SetIcon (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_SetIcon_Ljava_lang_String_Lcom_radaee_pdf_PageContent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='SetIcon' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.radaee.pdf.PageContent']]"
			[Register ("SetIcon", "(Ljava/lang/String;Lcom/radaee/pdf/PageContent;)Z", "GetSetIcon_Ljava_lang_String_Lcom_radaee_pdf_PageContent_Handler")]
			public virtual bool SetIcon (string p0, global::Com.Radaee.Pdf.PageContent p1)
			{
				if (id_SetIcon_Ljava_lang_String_Lcom_radaee_pdf_PageContent_ == IntPtr.Zero)
					id_SetIcon_Ljava_lang_String_Lcom_radaee_pdf_PageContent_ = JNIEnv.GetMethodID (class_ref, "SetIcon", "(Ljava/lang/String;Lcom/radaee/pdf/PageContent;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_SetIcon_Ljava_lang_String_Lcom_radaee_pdf_PageContent_, new JValue (native_p0), new JValue (p1));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetIcon", "(Ljava/lang/String;Lcom/radaee/pdf/PageContent;)Z"), new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_SetInkPath_Lcom_radaee_pdf_Path_;
#pragma warning disable 0169
			static Delegate GetSetInkPath_Lcom_radaee_pdf_Path_Handler ()
			{
				if (cb_SetInkPath_Lcom_radaee_pdf_Path_ == null)
					cb_SetInkPath_Lcom_radaee_pdf_Path_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetInkPath_Lcom_radaee_pdf_Path_);
				return cb_SetInkPath_Lcom_radaee_pdf_Path_;
			}

			static bool n_SetInkPath_Lcom_radaee_pdf_Path_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Radaee.Pdf.Path p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Path> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.SetInkPath (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_SetInkPath_Lcom_radaee_pdf_Path_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='SetInkPath' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Path']]"
			[Register ("SetInkPath", "(Lcom/radaee/pdf/Path;)Z", "GetSetInkPath_Lcom_radaee_pdf_Path_Handler")]
			public virtual bool SetInkPath (global::Com.Radaee.Pdf.Path p0)
			{
				if (id_SetInkPath_Lcom_radaee_pdf_Path_ == IntPtr.Zero)
					id_SetInkPath_Lcom_radaee_pdf_Path_ = JNIEnv.GetMethodID (class_ref, "SetInkPath", "(Lcom/radaee/pdf/Path;)Z");

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_SetInkPath_Lcom_radaee_pdf_Path_, new JValue (p0));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetInkPath", "(Lcom/radaee/pdf/Path;)Z"), new JValue (p0));
				return __ret;
			}

			static Delegate cb_SetListSels_arrayI;
#pragma warning disable 0169
			static Delegate GetSetListSels_arrayIHandler ()
			{
				if (cb_SetListSels_arrayI == null)
					cb_SetListSels_arrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetListSels_arrayI);
				return cb_SetListSels_arrayI;
			}

			static bool n_SetListSels_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
				bool __ret = __this.SetListSels (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_SetListSels_arrayI;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='SetListSels' and count(parameter)=1 and parameter[1][@type='int[]']]"
			[Register ("SetListSels", "([I)Z", "GetSetListSels_arrayIHandler")]
			public virtual bool SetListSels (int[] p0)
			{
				if (id_SetListSels_arrayI == IntPtr.Zero)
					id_SetListSels_arrayI = JNIEnv.GetMethodID (class_ref, "SetListSels", "([I)Z");
				IntPtr native_p0 = JNIEnv.NewArray (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_SetListSels_arrayI, new JValue (native_p0));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetListSels", "([I)Z"), new JValue (native_p0));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static Delegate cb_SetName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetName_Ljava_lang_String_Handler ()
			{
				if (cb_SetName_Ljava_lang_String_ == null)
					cb_SetName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetName_Ljava_lang_String_);
				return cb_SetName_Ljava_lang_String_;
			}

			static bool n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.SetName (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_SetName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='SetName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetName", "(Ljava/lang/String;)Z", "GetSetName_Ljava_lang_String_Handler")]
			public virtual bool SetName (string p0)
			{
				if (id_SetName_Ljava_lang_String_ == IntPtr.Zero)
					id_SetName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetName", "(Ljava/lang/String;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_SetName_Ljava_lang_String_, new JValue (native_p0));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetName", "(Ljava/lang/String;)Z"), new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_SetPolygonPath_Lcom_radaee_pdf_Path_;
#pragma warning disable 0169
			static Delegate GetSetPolygonPath_Lcom_radaee_pdf_Path_Handler ()
			{
				if (cb_SetPolygonPath_Lcom_radaee_pdf_Path_ == null)
					cb_SetPolygonPath_Lcom_radaee_pdf_Path_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetPolygonPath_Lcom_radaee_pdf_Path_);
				return cb_SetPolygonPath_Lcom_radaee_pdf_Path_;
			}

			static bool n_SetPolygonPath_Lcom_radaee_pdf_Path_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Radaee.Pdf.Path p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Path> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.SetPolygonPath (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_SetPolygonPath_Lcom_radaee_pdf_Path_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='SetPolygonPath' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Path']]"
			[Register ("SetPolygonPath", "(Lcom/radaee/pdf/Path;)Z", "GetSetPolygonPath_Lcom_radaee_pdf_Path_Handler")]
			public virtual bool SetPolygonPath (global::Com.Radaee.Pdf.Path p0)
			{
				if (id_SetPolygonPath_Lcom_radaee_pdf_Path_ == IntPtr.Zero)
					id_SetPolygonPath_Lcom_radaee_pdf_Path_ = JNIEnv.GetMethodID (class_ref, "SetPolygonPath", "(Lcom/radaee/pdf/Path;)Z");

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_SetPolygonPath_Lcom_radaee_pdf_Path_, new JValue (p0));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetPolygonPath", "(Lcom/radaee/pdf/Path;)Z"), new JValue (p0));
				return __ret;
			}

			static Delegate cb_SetPolylinePath_Lcom_radaee_pdf_Path_;
#pragma warning disable 0169
			static Delegate GetSetPolylinePath_Lcom_radaee_pdf_Path_Handler ()
			{
				if (cb_SetPolylinePath_Lcom_radaee_pdf_Path_ == null)
					cb_SetPolylinePath_Lcom_radaee_pdf_Path_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetPolylinePath_Lcom_radaee_pdf_Path_);
				return cb_SetPolylinePath_Lcom_radaee_pdf_Path_;
			}

			static bool n_SetPolylinePath_Lcom_radaee_pdf_Path_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Radaee.Pdf.Path p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Path> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.SetPolylinePath (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_SetPolylinePath_Lcom_radaee_pdf_Path_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='SetPolylinePath' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Path']]"
			[Register ("SetPolylinePath", "(Lcom/radaee/pdf/Path;)Z", "GetSetPolylinePath_Lcom_radaee_pdf_Path_Handler")]
			public virtual bool SetPolylinePath (global::Com.Radaee.Pdf.Path p0)
			{
				if (id_SetPolylinePath_Lcom_radaee_pdf_Path_ == IntPtr.Zero)
					id_SetPolylinePath_Lcom_radaee_pdf_Path_ = JNIEnv.GetMethodID (class_ref, "SetPolylinePath", "(Lcom/radaee/pdf/Path;)Z");

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_SetPolylinePath_Lcom_radaee_pdf_Path_, new JValue (p0));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetPolylinePath", "(Lcom/radaee/pdf/Path;)Z"), new JValue (p0));
				return __ret;
			}

			static Delegate cb_SetPopupSubject_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetPopupSubject_Ljava_lang_String_Handler ()
			{
				if (cb_SetPopupSubject_Ljava_lang_String_ == null)
					cb_SetPopupSubject_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetPopupSubject_Ljava_lang_String_);
				return cb_SetPopupSubject_Ljava_lang_String_;
			}

			static bool n_SetPopupSubject_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.SetPopupSubject (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_SetPopupSubject_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='SetPopupSubject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetPopupSubject", "(Ljava/lang/String;)Z", "GetSetPopupSubject_Ljava_lang_String_Handler")]
			public virtual bool SetPopupSubject (string p0)
			{
				if (id_SetPopupSubject_Ljava_lang_String_ == IntPtr.Zero)
					id_SetPopupSubject_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetPopupSubject", "(Ljava/lang/String;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_SetPopupSubject_Ljava_lang_String_, new JValue (native_p0));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetPopupSubject", "(Ljava/lang/String;)Z"), new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_SetPopupText_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetPopupText_Ljava_lang_String_Handler ()
			{
				if (cb_SetPopupText_Ljava_lang_String_ == null)
					cb_SetPopupText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetPopupText_Ljava_lang_String_);
				return cb_SetPopupText_Ljava_lang_String_;
			}

			static bool n_SetPopupText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.SetPopupText (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_SetPopupText_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='SetPopupText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetPopupText", "(Ljava/lang/String;)Z", "GetSetPopupText_Ljava_lang_String_Handler")]
			public virtual bool SetPopupText (string p0)
			{
				if (id_SetPopupText_Ljava_lang_String_ == IntPtr.Zero)
					id_SetPopupText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetPopupText", "(Ljava/lang/String;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_SetPopupText_Ljava_lang_String_, new JValue (native_p0));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetPopupText", "(Ljava/lang/String;)Z"), new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_SetRadio;
#pragma warning disable 0169
			static Delegate GetSetRadioHandler ()
			{
				if (cb_SetRadio == null)
					cb_SetRadio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SetRadio);
				return cb_SetRadio;
			}

			static bool n_SetRadio (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.SetRadio ();
			}
#pragma warning restore 0169

			static IntPtr id_SetRadio;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='SetRadio' and count(parameter)=0]"
			[Register ("SetRadio", "()Z", "GetSetRadioHandler")]
			public virtual bool SetRadio ()
			{
				if (id_SetRadio == IntPtr.Zero)
					id_SetRadio = JNIEnv.GetMethodID (class_ref, "SetRadio", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_SetRadio);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetRadio", "()Z"));
			}

			static Delegate cb_SetRect_FFFF;
#pragma warning disable 0169
			static Delegate GetSetRect_FFFFHandler ()
			{
				if (cb_SetRect_FFFF == null)
					cb_SetRect_FFFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, float>) n_SetRect_FFFF);
				return cb_SetRect_FFFF;
			}

			static void n_SetRect_FFFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2, float p3)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetRect (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_SetRect_FFFF;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='SetRect' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
			[Register ("SetRect", "(FFFF)V", "GetSetRect_FFFFHandler")]
			public virtual void SetRect (float p0, float p1, float p2, float p3)
			{
				if (id_SetRect_FFFF == IntPtr.Zero)
					id_SetRect_FFFF = JNIEnv.GetMethodID (class_ref, "SetRect", "(FFFF)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_SetRect_FFFF, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetRect", "(FFFF)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			}

			static Delegate cb_SetReset;
#pragma warning disable 0169
			static Delegate GetSetResetHandler ()
			{
				if (cb_SetReset == null)
					cb_SetReset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SetReset);
				return cb_SetReset;
			}

			static bool n_SetReset (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.SetReset ();
			}
#pragma warning restore 0169

			static IntPtr id_SetReset;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='SetReset' and count(parameter)=0]"
			[Register ("SetReset", "()Z", "GetSetResetHandler")]
			public virtual bool SetReset ()
			{
				if (id_SetReset == IntPtr.Zero)
					id_SetReset = JNIEnv.GetMethodID (class_ref, "SetReset", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_SetReset);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetReset", "()Z"));
			}

			static Delegate cb_SetStrokeColor_I;
#pragma warning disable 0169
			static Delegate GetSetStrokeColor_IHandler ()
			{
				if (cb_SetStrokeColor_I == null)
					cb_SetStrokeColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_SetStrokeColor_I);
				return cb_SetStrokeColor_I;
			}

			static bool n_SetStrokeColor_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.SetStrokeColor (p0);
			}
#pragma warning restore 0169

			static IntPtr id_SetStrokeColor_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='SetStrokeColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("SetStrokeColor", "(I)Z", "GetSetStrokeColor_IHandler")]
			public virtual bool SetStrokeColor (int p0)
			{
				if (id_SetStrokeColor_I == IntPtr.Zero)
					id_SetStrokeColor_I = JNIEnv.GetMethodID (class_ref, "SetStrokeColor", "(I)Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_SetStrokeColor_I, new JValue (p0));
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetStrokeColor", "(I)Z"), new JValue (p0));
			}

			static Delegate cb_SetStrokeWidth_F;
#pragma warning disable 0169
			static Delegate GetSetStrokeWidth_FHandler ()
			{
				if (cb_SetStrokeWidth_F == null)
					cb_SetStrokeWidth_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, bool>) n_SetStrokeWidth_F);
				return cb_SetStrokeWidth_F;
			}

			static bool n_SetStrokeWidth_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				global::Com.Radaee.Pdf.Page.Annotation __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.SetStrokeWidth (p0);
			}
#pragma warning restore 0169

			static IntPtr id_SetStrokeWidth_F;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Annotation']/method[@name='SetStrokeWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("SetStrokeWidth", "(F)Z", "GetSetStrokeWidth_FHandler")]
			public virtual bool SetStrokeWidth (float p0)
			{
				if (id_SetStrokeWidth_F == IntPtr.Zero)
					id_SetStrokeWidth_F = JNIEnv.GetMethodID (class_ref, "SetStrokeWidth", "(F)Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_SetStrokeWidth_F, new JValue (p0));
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetStrokeWidth", "(F)Z"), new JValue (p0));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Finder']"
		[global::Android.Runtime.Register ("com/radaee/pdf/Page$Finder", DoNotGenerateAcw=true)]
		public partial class Finder : global::Java.Lang.Object {


			static IntPtr hand_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Finder']/field[@name='hand']"
			[Register ("hand")]
			protected long Hand {
				get {
					if (hand_jfieldId == IntPtr.Zero)
						hand_jfieldId = JNIEnv.GetFieldID (class_ref, "hand", "J");
					return JNIEnv.GetLongField (Handle, hand_jfieldId);
				}
				set {
					if (hand_jfieldId == IntPtr.Zero)
						hand_jfieldId = JNIEnv.GetFieldID (class_ref, "hand", "J");
					JNIEnv.SetField (Handle, hand_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/radaee/pdf/Page$Finder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Finder); }
			}

			protected Finder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_radaee_pdf_Page_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Finder']/constructor[@name='Page.Finder' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Page']]"
			[Register (".ctor", "(Lcom/radaee/pdf/Page;)V", "")]
			public Finder (global::Com.Radaee.Pdf.Page __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Finder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self));
					return;
				}

				if (id_ctor_Lcom_radaee_pdf_Page_ == IntPtr.Zero)
					id_ctor_Lcom_radaee_pdf_Page_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/radaee/pdf/Page;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_radaee_pdf_Page_, new JValue (__self)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_radaee_pdf_Page_, new JValue (__self));
			}

			static IntPtr id_GetCount;
			public int Count {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Finder']/method[@name='GetCount' and count(parameter)=0]"
				[Register ("GetCount", "()I", "GetGetCountHandler")]
				get {
					if (id_GetCount == IntPtr.Zero)
						id_GetCount = JNIEnv.GetMethodID (class_ref, "GetCount", "()I");
					return JNIEnv.CallIntMethod  (Handle, id_GetCount);
				}
			}

			static IntPtr id_Close;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Finder']/method[@name='Close' and count(parameter)=0]"
			[Register ("Close", "()V", "")]
			public void Close ()
			{
				if (id_Close == IntPtr.Zero)
					id_Close = JNIEnv.GetMethodID (class_ref, "Close", "()V");
				JNIEnv.CallVoidMethod  (Handle, id_Close);
			}

			static IntPtr id_GetFirstChar_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.Finder']/method[@name='GetFirstChar' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("GetFirstChar", "(I)I", "")]
			public int GetFirstChar (int p0)
			{
				if (id_GetFirstChar_I == IntPtr.Zero)
					id_GetFirstChar_I = JNIEnv.GetMethodID (class_ref, "GetFirstChar", "(I)I");
				return JNIEnv.CallIntMethod  (Handle, id_GetFirstChar_I, new JValue (p0));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.ResFont']"
		[global::Android.Runtime.Register ("com/radaee/pdf/Page$ResFont", DoNotGenerateAcw=true)]
		public partial class ResFont : global::Java.Lang.Object {


			static IntPtr hand_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.ResFont']/field[@name='hand']"
			[Register ("hand")]
			protected long Hand {
				get {
					if (hand_jfieldId == IntPtr.Zero)
						hand_jfieldId = JNIEnv.GetFieldID (class_ref, "hand", "J");
					return JNIEnv.GetLongField (Handle, hand_jfieldId);
				}
				set {
					if (hand_jfieldId == IntPtr.Zero)
						hand_jfieldId = JNIEnv.GetFieldID (class_ref, "hand", "J");
					JNIEnv.SetField (Handle, hand_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/radaee/pdf/Page$ResFont", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ResFont); }
			}

			protected ResFont (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_radaee_pdf_Page_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.ResFont']/constructor[@name='Page.ResFont' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Page']]"
			[Register (".ctor", "(Lcom/radaee/pdf/Page;)V", "")]
			public ResFont (global::Com.Radaee.Pdf.Page __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (ResFont)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self));
					return;
				}

				if (id_ctor_Lcom_radaee_pdf_Page_ == IntPtr.Zero)
					id_ctor_Lcom_radaee_pdf_Page_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/radaee/pdf/Page;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_radaee_pdf_Page_, new JValue (__self)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_radaee_pdf_Page_, new JValue (__self));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.ResGState']"
		[global::Android.Runtime.Register ("com/radaee/pdf/Page$ResGState", DoNotGenerateAcw=true)]
		public partial class ResGState : global::Java.Lang.Object {


			static IntPtr hand_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.ResGState']/field[@name='hand']"
			[Register ("hand")]
			protected long Hand {
				get {
					if (hand_jfieldId == IntPtr.Zero)
						hand_jfieldId = JNIEnv.GetFieldID (class_ref, "hand", "J");
					return JNIEnv.GetLongField (Handle, hand_jfieldId);
				}
				set {
					if (hand_jfieldId == IntPtr.Zero)
						hand_jfieldId = JNIEnv.GetFieldID (class_ref, "hand", "J");
					JNIEnv.SetField (Handle, hand_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/radaee/pdf/Page$ResGState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ResGState); }
			}

			protected ResGState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_radaee_pdf_Page_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.ResGState']/constructor[@name='Page.ResGState' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Page']]"
			[Register (".ctor", "(Lcom/radaee/pdf/Page;)V", "")]
			public ResGState (global::Com.Radaee.Pdf.Page __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (ResGState)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self));
					return;
				}

				if (id_ctor_Lcom_radaee_pdf_Page_ == IntPtr.Zero)
					id_ctor_Lcom_radaee_pdf_Page_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/radaee/pdf/Page;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_radaee_pdf_Page_, new JValue (__self)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_radaee_pdf_Page_, new JValue (__self));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.ResImage']"
		[global::Android.Runtime.Register ("com/radaee/pdf/Page$ResImage", DoNotGenerateAcw=true)]
		public partial class ResImage : global::Java.Lang.Object {


			static IntPtr hand_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.ResImage']/field[@name='hand']"
			[Register ("hand")]
			protected long Hand {
				get {
					if (hand_jfieldId == IntPtr.Zero)
						hand_jfieldId = JNIEnv.GetFieldID (class_ref, "hand", "J");
					return JNIEnv.GetLongField (Handle, hand_jfieldId);
				}
				set {
					if (hand_jfieldId == IntPtr.Zero)
						hand_jfieldId = JNIEnv.GetFieldID (class_ref, "hand", "J");
					JNIEnv.SetField (Handle, hand_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/radaee/pdf/Page$ResImage", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ResImage); }
			}

			protected ResImage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_radaee_pdf_Page_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page.ResImage']/constructor[@name='Page.ResImage' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Page']]"
			[Register (".ctor", "(Lcom/radaee/pdf/Page;)V", "")]
			public ResImage (global::Com.Radaee.Pdf.Page __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (ResImage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self));
					return;
				}

				if (id_ctor_Lcom_radaee_pdf_Page_ == IntPtr.Zero)
					id_ctor_Lcom_radaee_pdf_Page_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/radaee/pdf/Page;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_radaee_pdf_Page_, new JValue (__self)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_radaee_pdf_Page_, new JValue (__self));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/radaee/pdf/Page", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Page); }
		}

		protected Page (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/constructor[@name='Page' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Page () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Page)) {
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

		static Delegate cb_GetAnnotCount;
#pragma warning disable 0169
		static Delegate GetGetAnnotCountHandler ()
		{
			if (cb_GetAnnotCount == null)
				cb_GetAnnotCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAnnotCount);
			return cb_GetAnnotCount;
		}

		static int n_GetAnnotCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AnnotCount;
		}
#pragma warning restore 0169

		static IntPtr id_GetAnnotCount;
		public virtual int AnnotCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='GetAnnotCount' and count(parameter)=0]"
			[Register ("GetAnnotCount", "()I", "GetGetAnnotCountHandler")]
			get {
				if (id_GetAnnotCount == IntPtr.Zero)
					id_GetAnnotCount = JNIEnv.GetMethodID (class_ref, "GetAnnotCount", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_GetAnnotCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetAnnotCount", "()I"));
			}
		}

		static Delegate cb_GetRotate;
#pragma warning disable 0169
		static Delegate GetGetRotateHandler ()
		{
			if (cb_GetRotate == null)
				cb_GetRotate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRotate);
			return cb_GetRotate;
		}

		static int n_GetRotate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Rotate;
		}
#pragma warning restore 0169

		static IntPtr id_GetRotate;
		public virtual int Rotate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='GetRotate' and count(parameter)=0]"
			[Register ("GetRotate", "()I", "GetGetRotateHandler")]
			get {
				if (id_GetRotate == IntPtr.Zero)
					id_GetRotate = JNIEnv.GetMethodID (class_ref, "GetRotate", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_GetRotate);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetRotate", "()I"));
			}
		}

		static Delegate cb_AddAnnotAttachment_Ljava_lang_String_IarrayF;
#pragma warning disable 0169
		static Delegate GetAddAnnotAttachment_Ljava_lang_String_IarrayFHandler ()
		{
			if (cb_AddAnnotAttachment_Ljava_lang_String_IarrayF == null)
				cb_AddAnnotAttachment_Ljava_lang_String_IarrayF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, bool>) n_AddAnnotAttachment_Ljava_lang_String_IarrayF);
			return cb_AddAnnotAttachment_Ljava_lang_String_IarrayF;
		}

		static bool n_AddAnnotAttachment_Ljava_lang_String_IarrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			float[] p2 = (float[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (float));
			bool __ret = __this.AddAnnotAttachment (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddAnnotAttachment_Ljava_lang_String_IarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddAnnotAttachment' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='float[]']]"
		[Register ("AddAnnotAttachment", "(Ljava/lang/String;I[F)Z", "GetAddAnnotAttachment_Ljava_lang_String_IarrayFHandler")]
		public virtual bool AddAnnotAttachment (string p0, int p1, float[] p2)
		{
			if (id_AddAnnotAttachment_Ljava_lang_String_IarrayF == IntPtr.Zero)
				id_AddAnnotAttachment_Ljava_lang_String_IarrayF = JNIEnv.GetMethodID (class_ref, "AddAnnotAttachment", "(Ljava/lang/String;I[F)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_AddAnnotAttachment_Ljava_lang_String_IarrayF, new JValue (native_p0), new JValue (p1), new JValue (native_p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddAnnotAttachment", "(Ljava/lang/String;I[F)Z"), new JValue (native_p0), new JValue (p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate cb_AddAnnotBitmap_Landroid_graphics_Bitmap_ZarrayF;
#pragma warning disable 0169
		static Delegate GetAddAnnotBitmap_Landroid_graphics_Bitmap_ZarrayFHandler ()
		{
			if (cb_AddAnnotBitmap_Landroid_graphics_Bitmap_ZarrayF == null)
				cb_AddAnnotBitmap_Landroid_graphics_Bitmap_ZarrayF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr, bool>) n_AddAnnotBitmap_Landroid_graphics_Bitmap_ZarrayF);
			return cb_AddAnnotBitmap_Landroid_graphics_Bitmap_ZarrayF;
		}

		static bool n_AddAnnotBitmap_Landroid_graphics_Bitmap_ZarrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, IntPtr native_p2)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			float[] p2 = (float[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (float));
			bool __ret = __this.AddAnnotBitmap (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddAnnotBitmap_Landroid_graphics_Bitmap_ZarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddAnnotBitmap' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='boolean'] and parameter[3][@type='float[]']]"
		[Register ("AddAnnotBitmap", "(Landroid/graphics/Bitmap;Z[F)Z", "GetAddAnnotBitmap_Landroid_graphics_Bitmap_ZarrayFHandler")]
		public virtual bool AddAnnotBitmap (global::Android.Graphics.Bitmap p0, bool p1, float[] p2)
		{
			if (id_AddAnnotBitmap_Landroid_graphics_Bitmap_ZarrayF == IntPtr.Zero)
				id_AddAnnotBitmap_Landroid_graphics_Bitmap_ZarrayF = JNIEnv.GetMethodID (class_ref, "AddAnnotBitmap", "(Landroid/graphics/Bitmap;Z[F)Z");
			IntPtr native_p2 = JNIEnv.NewArray (p2);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_AddAnnotBitmap_Landroid_graphics_Bitmap_ZarrayF, new JValue (p0), new JValue (p1), new JValue (native_p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddAnnotBitmap", "(Landroid/graphics/Bitmap;Z[F)Z"), new JValue (p0), new JValue (p1), new JValue (native_p2));
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate cb_AddAnnotEditbox_Lcom_radaee_pdf_Matrix_arrayFIFIIF;
#pragma warning disable 0169
		static Delegate GetAddAnnotEditbox_Lcom_radaee_pdf_Matrix_arrayFIFIIFHandler ()
		{
			if (cb_AddAnnotEditbox_Lcom_radaee_pdf_Matrix_arrayFIFIIF == null)
				cb_AddAnnotEditbox_Lcom_radaee_pdf_Matrix_arrayFIFIIF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, float, int, int, float, bool>) n_AddAnnotEditbox_Lcom_radaee_pdf_Matrix_arrayFIFIIF);
			return cb_AddAnnotEditbox_Lcom_radaee_pdf_Matrix_arrayFIFIIF;
		}

		static bool n_AddAnnotEditbox_Lcom_radaee_pdf_Matrix_arrayFIFIIF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, float p3, int p4, int p5, float p6)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Matrix p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Matrix> (native_p0, JniHandleOwnership.DoNotTransfer);
			float[] p1 = (float[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (float));
			bool __ret = __this.AddAnnotEditbox (p0, p1, p2, p3, p4, p5, p6);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddAnnotEditbox_Lcom_radaee_pdf_Matrix_arrayFIFIIF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddAnnotEditbox' and count(parameter)=7 and parameter[1][@type='com.radaee.pdf.Matrix'] and parameter[2][@type='float[]'] and parameter[3][@type='int'] and parameter[4][@type='float'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='float']]"
		[Register ("AddAnnotEditbox", "(Lcom/radaee/pdf/Matrix;[FIFIIF)Z", "GetAddAnnotEditbox_Lcom_radaee_pdf_Matrix_arrayFIFIIFHandler")]
		public virtual bool AddAnnotEditbox (global::Com.Radaee.Pdf.Matrix p0, float[] p1, int p2, float p3, int p4, int p5, float p6)
		{
			if (id_AddAnnotEditbox_Lcom_radaee_pdf_Matrix_arrayFIFIIF == IntPtr.Zero)
				id_AddAnnotEditbox_Lcom_radaee_pdf_Matrix_arrayFIFIIF = JNIEnv.GetMethodID (class_ref, "AddAnnotEditbox", "(Lcom/radaee/pdf/Matrix;[FIFIIF)Z");
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_AddAnnotEditbox_Lcom_radaee_pdf_Matrix_arrayFIFIIF, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddAnnotEditbox", "(Lcom/radaee/pdf/Matrix;[FIFIIF)Z"), new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_AddAnnotEditbox_arrayFIFIFI;
#pragma warning disable 0169
		static Delegate GetAddAnnotEditbox_arrayFIFIFIHandler ()
		{
			if (cb_AddAnnotEditbox_arrayFIFIFI == null)
				cb_AddAnnotEditbox_arrayFIFIFI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, float, int, float, int, bool>) n_AddAnnotEditbox_arrayFIFIFI);
			return cb_AddAnnotEditbox_arrayFIFIFI;
		}

		static bool n_AddAnnotEditbox_arrayFIFIFI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, float p2, int p3, float p4, int p5)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			bool __ret = __this.AddAnnotEditbox (p0, p1, p2, p3, p4, p5);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddAnnotEditbox_arrayFIFIFI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddAnnotEditbox' and count(parameter)=6 and parameter[1][@type='float[]'] and parameter[2][@type='int'] and parameter[3][@type='float'] and parameter[4][@type='int'] and parameter[5][@type='float'] and parameter[6][@type='int']]"
		[Register ("AddAnnotEditbox", "([FIFIFI)Z", "GetAddAnnotEditbox_arrayFIFIFIHandler")]
		public virtual bool AddAnnotEditbox (float[] p0, int p1, float p2, int p3, float p4, int p5)
		{
			if (id_AddAnnotEditbox_arrayFIFIFI == IntPtr.Zero)
				id_AddAnnotEditbox_arrayFIFIFI = JNIEnv.GetMethodID (class_ref, "AddAnnotEditbox", "([FIFIFI)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_AddAnnotEditbox_arrayFIFIFI, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddAnnotEditbox", "([FIFIFI)Z"), new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_AddAnnotEllipse_Lcom_radaee_pdf_Matrix_arrayFFII;
#pragma warning disable 0169
		static Delegate GetAddAnnotEllipse_Lcom_radaee_pdf_Matrix_arrayFFIIHandler ()
		{
			if (cb_AddAnnotEllipse_Lcom_radaee_pdf_Matrix_arrayFFII == null)
				cb_AddAnnotEllipse_Lcom_radaee_pdf_Matrix_arrayFFII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, float, int, int, bool>) n_AddAnnotEllipse_Lcom_radaee_pdf_Matrix_arrayFFII);
			return cb_AddAnnotEllipse_Lcom_radaee_pdf_Matrix_arrayFFII;
		}

		static bool n_AddAnnotEllipse_Lcom_radaee_pdf_Matrix_arrayFFII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, int p3, int p4)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Matrix p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Matrix> (native_p0, JniHandleOwnership.DoNotTransfer);
			float[] p1 = (float[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (float));
			bool __ret = __this.AddAnnotEllipse (p0, p1, p2, p3, p4);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddAnnotEllipse_Lcom_radaee_pdf_Matrix_arrayFFII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddAnnotEllipse' and count(parameter)=5 and parameter[1][@type='com.radaee.pdf.Matrix'] and parameter[2][@type='float[]'] and parameter[3][@type='float'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("AddAnnotEllipse", "(Lcom/radaee/pdf/Matrix;[FFII)Z", "GetAddAnnotEllipse_Lcom_radaee_pdf_Matrix_arrayFFIIHandler")]
		public virtual bool AddAnnotEllipse (global::Com.Radaee.Pdf.Matrix p0, float[] p1, float p2, int p3, int p4)
		{
			if (id_AddAnnotEllipse_Lcom_radaee_pdf_Matrix_arrayFFII == IntPtr.Zero)
				id_AddAnnotEllipse_Lcom_radaee_pdf_Matrix_arrayFFII = JNIEnv.GetMethodID (class_ref, "AddAnnotEllipse", "(Lcom/radaee/pdf/Matrix;[FFII)Z");
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_AddAnnotEllipse_Lcom_radaee_pdf_Matrix_arrayFFII, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddAnnotEllipse", "(Lcom/radaee/pdf/Matrix;[FFII)Z"), new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_AddAnnotEllipse_arrayFFII;
#pragma warning disable 0169
		static Delegate GetAddAnnotEllipse_arrayFFIIHandler ()
		{
			if (cb_AddAnnotEllipse_arrayFFII == null)
				cb_AddAnnotEllipse_arrayFFII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, int, int, bool>) n_AddAnnotEllipse_arrayFFII);
			return cb_AddAnnotEllipse_arrayFFII;
		}

		static bool n_AddAnnotEllipse_arrayFFII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, int p2, int p3)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			bool __ret = __this.AddAnnotEllipse (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddAnnotEllipse_arrayFFII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddAnnotEllipse' and count(parameter)=4 and parameter[1][@type='float[]'] and parameter[2][@type='float'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("AddAnnotEllipse", "([FFII)Z", "GetAddAnnotEllipse_arrayFFIIHandler")]
		public virtual bool AddAnnotEllipse (float[] p0, float p1, int p2, int p3)
		{
			if (id_AddAnnotEllipse_arrayFFII == IntPtr.Zero)
				id_AddAnnotEllipse_arrayFFII = JNIEnv.GetMethodID (class_ref, "AddAnnotEllipse", "([FFII)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_AddAnnotEllipse_arrayFFII, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddAnnotEllipse", "([FFII)Z"), new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_AddAnnotGlyph_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_Path_IZ;
#pragma warning disable 0169
		static Delegate GetAddAnnotGlyph_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_Path_IZHandler ()
		{
			if (cb_AddAnnotGlyph_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_Path_IZ == null)
				cb_AddAnnotGlyph_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_Path_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, bool, bool>) n_AddAnnotGlyph_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_Path_IZ);
			return cb_AddAnnotGlyph_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_Path_IZ;
		}

		static bool n_AddAnnotGlyph_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_Path_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, bool p3)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Matrix p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Matrix> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Path p1 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Path> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddAnnotGlyph (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddAnnotGlyph_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_Path_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddAnnotGlyph' and count(parameter)=4 and parameter[1][@type='com.radaee.pdf.Matrix'] and parameter[2][@type='com.radaee.pdf.Path'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("AddAnnotGlyph", "(Lcom/radaee/pdf/Matrix;Lcom/radaee/pdf/Path;IZ)Z", "GetAddAnnotGlyph_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_Path_IZHandler")]
		public virtual bool AddAnnotGlyph (global::Com.Radaee.Pdf.Matrix p0, global::Com.Radaee.Pdf.Path p1, int p2, bool p3)
		{
			if (id_AddAnnotGlyph_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_Path_IZ == IntPtr.Zero)
				id_AddAnnotGlyph_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_Path_IZ = JNIEnv.GetMethodID (class_ref, "AddAnnotGlyph", "(Lcom/radaee/pdf/Matrix;Lcom/radaee/pdf/Path;IZ)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_AddAnnotGlyph_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_Path_IZ, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddAnnotGlyph", "(Lcom/radaee/pdf/Matrix;Lcom/radaee/pdf/Path;IZ)Z"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			return __ret;
		}

		static Delegate cb_AddAnnotGoto_arrayFIF;
#pragma warning disable 0169
		static Delegate GetAddAnnotGoto_arrayFIFHandler ()
		{
			if (cb_AddAnnotGoto_arrayFIF == null)
				cb_AddAnnotGoto_arrayFIF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, float, bool>) n_AddAnnotGoto_arrayFIF);
			return cb_AddAnnotGoto_arrayFIF;
		}

		static bool n_AddAnnotGoto_arrayFIF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, float p2)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			bool __ret = __this.AddAnnotGoto (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddAnnotGoto_arrayFIF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddAnnotGoto' and count(parameter)=3 and parameter[1][@type='float[]'] and parameter[2][@type='int'] and parameter[3][@type='float']]"
		[Register ("AddAnnotGoto", "([FIF)Z", "GetAddAnnotGoto_arrayFIFHandler")]
		public virtual bool AddAnnotGoto (float[] p0, int p1, float p2)
		{
			if (id_AddAnnotGoto_arrayFIF == IntPtr.Zero)
				id_AddAnnotGoto_arrayFIF = JNIEnv.GetMethodID (class_ref, "AddAnnotGoto", "([FIF)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_AddAnnotGoto_arrayFIF, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddAnnotGoto", "([FIF)Z"), new JValue (native_p0), new JValue (p1), new JValue (p2));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_AddAnnotHWriting_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_HWriting_FF;
#pragma warning disable 0169
		static Delegate GetAddAnnotHWriting_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_HWriting_FFHandler ()
		{
			if (cb_AddAnnotHWriting_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_HWriting_FF == null)
				cb_AddAnnotHWriting_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_HWriting_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, float, float, bool>) n_AddAnnotHWriting_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_HWriting_FF);
			return cb_AddAnnotHWriting_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_HWriting_FF;
		}

		static bool n_AddAnnotHWriting_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_HWriting_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, float p3)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Matrix p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Matrix> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.HWriting p1 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.HWriting> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddAnnotHWriting (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddAnnotHWriting_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_HWriting_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddAnnotHWriting' and count(parameter)=4 and parameter[1][@type='com.radaee.pdf.Matrix'] and parameter[2][@type='com.radaee.pdf.HWriting'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("AddAnnotHWriting", "(Lcom/radaee/pdf/Matrix;Lcom/radaee/pdf/HWriting;FF)Z", "GetAddAnnotHWriting_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_HWriting_FFHandler")]
		public virtual bool AddAnnotHWriting (global::Com.Radaee.Pdf.Matrix p0, global::Com.Radaee.Pdf.HWriting p1, float p2, float p3)
		{
			if (id_AddAnnotHWriting_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_HWriting_FF == IntPtr.Zero)
				id_AddAnnotHWriting_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_HWriting_FF = JNIEnv.GetMethodID (class_ref, "AddAnnotHWriting", "(Lcom/radaee/pdf/Matrix;Lcom/radaee/pdf/HWriting;FF)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_AddAnnotHWriting_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_HWriting_FF, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddAnnotHWriting", "(Lcom/radaee/pdf/Matrix;Lcom/radaee/pdf/HWriting;FF)Z"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			return __ret;
		}

		static Delegate cb_AddAnnotInk_Lcom_radaee_pdf_Ink_;
#pragma warning disable 0169
		static Delegate GetAddAnnotInk_Lcom_radaee_pdf_Ink_Handler ()
		{
			if (cb_AddAnnotInk_Lcom_radaee_pdf_Ink_ == null)
				cb_AddAnnotInk_Lcom_radaee_pdf_Ink_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddAnnotInk_Lcom_radaee_pdf_Ink_);
			return cb_AddAnnotInk_Lcom_radaee_pdf_Ink_;
		}

		static bool n_AddAnnotInk_Lcom_radaee_pdf_Ink_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Ink p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Ink> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddAnnotInk (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddAnnotInk_Lcom_radaee_pdf_Ink_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddAnnotInk' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Ink']]"
		[Register ("AddAnnotInk", "(Lcom/radaee/pdf/Ink;)Z", "GetAddAnnotInk_Lcom_radaee_pdf_Ink_Handler")]
		public virtual bool AddAnnotInk (global::Com.Radaee.Pdf.Ink p0)
		{
			if (id_AddAnnotInk_Lcom_radaee_pdf_Ink_ == IntPtr.Zero)
				id_AddAnnotInk_Lcom_radaee_pdf_Ink_ = JNIEnv.GetMethodID (class_ref, "AddAnnotInk", "(Lcom/radaee/pdf/Ink;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_AddAnnotInk_Lcom_radaee_pdf_Ink_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddAnnotInk", "(Lcom/radaee/pdf/Ink;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_AddAnnotInk_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_Ink_FF;
#pragma warning disable 0169
		static Delegate GetAddAnnotInk_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_Ink_FFHandler ()
		{
			if (cb_AddAnnotInk_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_Ink_FF == null)
				cb_AddAnnotInk_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_Ink_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, float, float, bool>) n_AddAnnotInk_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_Ink_FF);
			return cb_AddAnnotInk_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_Ink_FF;
		}

		static bool n_AddAnnotInk_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_Ink_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, float p3)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Matrix p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Matrix> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Ink p1 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Ink> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddAnnotInk (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddAnnotInk_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_Ink_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddAnnotInk' and count(parameter)=4 and parameter[1][@type='com.radaee.pdf.Matrix'] and parameter[2][@type='com.radaee.pdf.Ink'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("AddAnnotInk", "(Lcom/radaee/pdf/Matrix;Lcom/radaee/pdf/Ink;FF)Z", "GetAddAnnotInk_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_Ink_FFHandler")]
		public virtual bool AddAnnotInk (global::Com.Radaee.Pdf.Matrix p0, global::Com.Radaee.Pdf.Ink p1, float p2, float p3)
		{
			if (id_AddAnnotInk_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_Ink_FF == IntPtr.Zero)
				id_AddAnnotInk_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_Ink_FF = JNIEnv.GetMethodID (class_ref, "AddAnnotInk", "(Lcom/radaee/pdf/Matrix;Lcom/radaee/pdf/Ink;FF)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_AddAnnotInk_Lcom_radaee_pdf_Matrix_Lcom_radaee_pdf_Ink_FF, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddAnnotInk", "(Lcom/radaee/pdf/Matrix;Lcom/radaee/pdf/Ink;FF)Z"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			return __ret;
		}

		static Delegate cb_AddAnnotLine_Lcom_radaee_pdf_Matrix_arrayFarrayFIIFII;
#pragma warning disable 0169
		static Delegate GetAddAnnotLine_Lcom_radaee_pdf_Matrix_arrayFarrayFIIFIIHandler ()
		{
			if (cb_AddAnnotLine_Lcom_radaee_pdf_Matrix_arrayFarrayFIIFII == null)
				cb_AddAnnotLine_Lcom_radaee_pdf_Matrix_arrayFarrayFIIFII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, float, int, int, bool>) n_AddAnnotLine_Lcom_radaee_pdf_Matrix_arrayFarrayFIIFII);
			return cb_AddAnnotLine_Lcom_radaee_pdf_Matrix_arrayFarrayFIIFII;
		}

		static bool n_AddAnnotLine_Lcom_radaee_pdf_Matrix_arrayFarrayFIIFII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, int p4, float p5, int p6, int p7)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Matrix p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Matrix> (native_p0, JniHandleOwnership.DoNotTransfer);
			float[] p1 = (float[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (float));
			float[] p2 = (float[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (float));
			bool __ret = __this.AddAnnotLine (p0, p1, p2, p3, p4, p5, p6, p7);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddAnnotLine_Lcom_radaee_pdf_Matrix_arrayFarrayFIIFII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddAnnotLine' and count(parameter)=8 and parameter[1][@type='com.radaee.pdf.Matrix'] and parameter[2][@type='float[]'] and parameter[3][@type='float[]'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='float'] and parameter[7][@type='int'] and parameter[8][@type='int']]"
		[Register ("AddAnnotLine", "(Lcom/radaee/pdf/Matrix;[F[FIIFII)Z", "GetAddAnnotLine_Lcom_radaee_pdf_Matrix_arrayFarrayFIIFIIHandler")]
		public virtual bool AddAnnotLine (global::Com.Radaee.Pdf.Matrix p0, float[] p1, float[] p2, int p3, int p4, float p5, int p6, int p7)
		{
			if (id_AddAnnotLine_Lcom_radaee_pdf_Matrix_arrayFarrayFIIFII == IntPtr.Zero)
				id_AddAnnotLine_Lcom_radaee_pdf_Matrix_arrayFarrayFIIFII = JNIEnv.GetMethodID (class_ref, "AddAnnotLine", "(Lcom/radaee/pdf/Matrix;[F[FIIFII)Z");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_AddAnnotLine_Lcom_radaee_pdf_Matrix_arrayFarrayFIIFII, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6), new JValue (p7));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddAnnotLine", "(Lcom/radaee/pdf/Matrix;[F[FIIFII)Z"), new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6), new JValue (p7));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate cb_AddAnnotLine_arrayFarrayFIIFII;
#pragma warning disable 0169
		static Delegate GetAddAnnotLine_arrayFarrayFIIFIIHandler ()
		{
			if (cb_AddAnnotLine_arrayFarrayFIIFII == null)
				cb_AddAnnotLine_arrayFarrayFIIFII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, int, float, int, int, bool>) n_AddAnnotLine_arrayFarrayFIIFII);
			return cb_AddAnnotLine_arrayFarrayFIIFII;
		}

		static bool n_AddAnnotLine_arrayFarrayFIIFII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, float p4, int p5, int p6)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			float[] p1 = (float[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (float));
			bool __ret = __this.AddAnnotLine (p0, p1, p2, p3, p4, p5, p6);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddAnnotLine_arrayFarrayFIIFII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddAnnotLine' and count(parameter)=7 and parameter[1][@type='float[]'] and parameter[2][@type='float[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='float'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("AddAnnotLine", "([F[FIIFII)Z", "GetAddAnnotLine_arrayFarrayFIIFIIHandler")]
		public virtual bool AddAnnotLine (float[] p0, float[] p1, int p2, int p3, float p4, int p5, int p6)
		{
			if (id_AddAnnotLine_arrayFarrayFIIFII == IntPtr.Zero)
				id_AddAnnotLine_arrayFarrayFIIFII = JNIEnv.GetMethodID (class_ref, "AddAnnotLine", "([F[FIIFII)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_AddAnnotLine_arrayFarrayFIIFII, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddAnnotLine", "([F[FIIFII)Z"), new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_AddAnnotMarkup_Lcom_radaee_pdf_Matrix_arrayFI;
#pragma warning disable 0169
		static Delegate GetAddAnnotMarkup_Lcom_radaee_pdf_Matrix_arrayFIHandler ()
		{
			if (cb_AddAnnotMarkup_Lcom_radaee_pdf_Matrix_arrayFI == null)
				cb_AddAnnotMarkup_Lcom_radaee_pdf_Matrix_arrayFI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, bool>) n_AddAnnotMarkup_Lcom_radaee_pdf_Matrix_arrayFI);
			return cb_AddAnnotMarkup_Lcom_radaee_pdf_Matrix_arrayFI;
		}

		static bool n_AddAnnotMarkup_Lcom_radaee_pdf_Matrix_arrayFI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Matrix p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Matrix> (native_p0, JniHandleOwnership.DoNotTransfer);
			float[] p1 = (float[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (float));
			bool __ret = __this.AddAnnotMarkup (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddAnnotMarkup_Lcom_radaee_pdf_Matrix_arrayFI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddAnnotMarkup' and count(parameter)=3 and parameter[1][@type='com.radaee.pdf.Matrix'] and parameter[2][@type='float[]'] and parameter[3][@type='int']]"
		[Register ("AddAnnotMarkup", "(Lcom/radaee/pdf/Matrix;[FI)Z", "GetAddAnnotMarkup_Lcom_radaee_pdf_Matrix_arrayFIHandler")]
		public virtual bool AddAnnotMarkup (global::Com.Radaee.Pdf.Matrix p0, float[] p1, int p2)
		{
			if (id_AddAnnotMarkup_Lcom_radaee_pdf_Matrix_arrayFI == IntPtr.Zero)
				id_AddAnnotMarkup_Lcom_radaee_pdf_Matrix_arrayFI = JNIEnv.GetMethodID (class_ref, "AddAnnotMarkup", "(Lcom/radaee/pdf/Matrix;[FI)Z");
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_AddAnnotMarkup_Lcom_radaee_pdf_Matrix_arrayFI, new JValue (p0), new JValue (native_p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddAnnotMarkup", "(Lcom/radaee/pdf/Matrix;[FI)Z"), new JValue (p0), new JValue (native_p1), new JValue (p2));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_AddAnnotMarkup_III;
#pragma warning disable 0169
		static Delegate GetAddAnnotMarkup_IIIHandler ()
		{
			if (cb_AddAnnotMarkup_III == null)
				cb_AddAnnotMarkup_III = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, bool>) n_AddAnnotMarkup_III);
			return cb_AddAnnotMarkup_III;
		}

		static bool n_AddAnnotMarkup_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AddAnnotMarkup (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_AddAnnotMarkup_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddAnnotMarkup' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("AddAnnotMarkup", "(III)Z", "GetAddAnnotMarkup_IIIHandler")]
		public virtual bool AddAnnotMarkup (int p0, int p1, int p2)
		{
			if (id_AddAnnotMarkup_III == IntPtr.Zero)
				id_AddAnnotMarkup_III = JNIEnv.GetMethodID (class_ref, "AddAnnotMarkup", "(III)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_AddAnnotMarkup_III, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddAnnotMarkup", "(III)Z"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_AddAnnotPolygon_Lcom_radaee_pdf_Path_IIF;
#pragma warning disable 0169
		static Delegate GetAddAnnotPolygon_Lcom_radaee_pdf_Path_IIFHandler ()
		{
			if (cb_AddAnnotPolygon_Lcom_radaee_pdf_Path_IIF == null)
				cb_AddAnnotPolygon_Lcom_radaee_pdf_Path_IIF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, float, bool>) n_AddAnnotPolygon_Lcom_radaee_pdf_Path_IIF);
			return cb_AddAnnotPolygon_Lcom_radaee_pdf_Path_IIF;
		}

		static bool n_AddAnnotPolygon_Lcom_radaee_pdf_Path_IIF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, float p3)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Path p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Path> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddAnnotPolygon (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddAnnotPolygon_Lcom_radaee_pdf_Path_IIF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddAnnotPolygon' and count(parameter)=4 and parameter[1][@type='com.radaee.pdf.Path'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='float']]"
		[Register ("AddAnnotPolygon", "(Lcom/radaee/pdf/Path;IIF)Z", "GetAddAnnotPolygon_Lcom_radaee_pdf_Path_IIFHandler")]
		public virtual bool AddAnnotPolygon (global::Com.Radaee.Pdf.Path p0, int p1, int p2, float p3)
		{
			if (id_AddAnnotPolygon_Lcom_radaee_pdf_Path_IIF == IntPtr.Zero)
				id_AddAnnotPolygon_Lcom_radaee_pdf_Path_IIF = JNIEnv.GetMethodID (class_ref, "AddAnnotPolygon", "(Lcom/radaee/pdf/Path;IIF)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_AddAnnotPolygon_Lcom_radaee_pdf_Path_IIF, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddAnnotPolygon", "(Lcom/radaee/pdf/Path;IIF)Z"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			return __ret;
		}

		static Delegate cb_AddAnnotPolyline_Lcom_radaee_pdf_Path_IIIIF;
#pragma warning disable 0169
		static Delegate GetAddAnnotPolyline_Lcom_radaee_pdf_Path_IIIIFHandler ()
		{
			if (cb_AddAnnotPolyline_Lcom_radaee_pdf_Path_IIIIF == null)
				cb_AddAnnotPolyline_Lcom_radaee_pdf_Path_IIIIF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int, int, float, bool>) n_AddAnnotPolyline_Lcom_radaee_pdf_Path_IIIIF);
			return cb_AddAnnotPolyline_Lcom_radaee_pdf_Path_IIIIF;
		}

		static bool n_AddAnnotPolyline_Lcom_radaee_pdf_Path_IIIIF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4, float p5)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Path p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Path> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddAnnotPolyline (p0, p1, p2, p3, p4, p5);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddAnnotPolyline_Lcom_radaee_pdf_Path_IIIIF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddAnnotPolyline' and count(parameter)=6 and parameter[1][@type='com.radaee.pdf.Path'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='float']]"
		[Register ("AddAnnotPolyline", "(Lcom/radaee/pdf/Path;IIIIF)Z", "GetAddAnnotPolyline_Lcom_radaee_pdf_Path_IIIIFHandler")]
		public virtual bool AddAnnotPolyline (global::Com.Radaee.Pdf.Path p0, int p1, int p2, int p3, int p4, float p5)
		{
			if (id_AddAnnotPolyline_Lcom_radaee_pdf_Path_IIIIF == IntPtr.Zero)
				id_AddAnnotPolyline_Lcom_radaee_pdf_Path_IIIIF = JNIEnv.GetMethodID (class_ref, "AddAnnotPolyline", "(Lcom/radaee/pdf/Path;IIIIF)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_AddAnnotPolyline_Lcom_radaee_pdf_Path_IIIIF, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddAnnotPolyline", "(Lcom/radaee/pdf/Path;IIIIF)Z"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
			return __ret;
		}

		static Delegate cb_AddAnnotRect_Lcom_radaee_pdf_Matrix_arrayFFII;
#pragma warning disable 0169
		static Delegate GetAddAnnotRect_Lcom_radaee_pdf_Matrix_arrayFFIIHandler ()
		{
			if (cb_AddAnnotRect_Lcom_radaee_pdf_Matrix_arrayFFII == null)
				cb_AddAnnotRect_Lcom_radaee_pdf_Matrix_arrayFFII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, float, int, int, bool>) n_AddAnnotRect_Lcom_radaee_pdf_Matrix_arrayFFII);
			return cb_AddAnnotRect_Lcom_radaee_pdf_Matrix_arrayFFII;
		}

		static bool n_AddAnnotRect_Lcom_radaee_pdf_Matrix_arrayFFII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, int p3, int p4)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Matrix p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Matrix> (native_p0, JniHandleOwnership.DoNotTransfer);
			float[] p1 = (float[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (float));
			bool __ret = __this.AddAnnotRect (p0, p1, p2, p3, p4);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddAnnotRect_Lcom_radaee_pdf_Matrix_arrayFFII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddAnnotRect' and count(parameter)=5 and parameter[1][@type='com.radaee.pdf.Matrix'] and parameter[2][@type='float[]'] and parameter[3][@type='float'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("AddAnnotRect", "(Lcom/radaee/pdf/Matrix;[FFII)Z", "GetAddAnnotRect_Lcom_radaee_pdf_Matrix_arrayFFIIHandler")]
		public virtual bool AddAnnotRect (global::Com.Radaee.Pdf.Matrix p0, float[] p1, float p2, int p3, int p4)
		{
			if (id_AddAnnotRect_Lcom_radaee_pdf_Matrix_arrayFFII == IntPtr.Zero)
				id_AddAnnotRect_Lcom_radaee_pdf_Matrix_arrayFFII = JNIEnv.GetMethodID (class_ref, "AddAnnotRect", "(Lcom/radaee/pdf/Matrix;[FFII)Z");
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_AddAnnotRect_Lcom_radaee_pdf_Matrix_arrayFFII, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddAnnotRect", "(Lcom/radaee/pdf/Matrix;[FFII)Z"), new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_AddAnnotRect_arrayFFII;
#pragma warning disable 0169
		static Delegate GetAddAnnotRect_arrayFFIIHandler ()
		{
			if (cb_AddAnnotRect_arrayFFII == null)
				cb_AddAnnotRect_arrayFFII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, int, int, bool>) n_AddAnnotRect_arrayFFII);
			return cb_AddAnnotRect_arrayFFII;
		}

		static bool n_AddAnnotRect_arrayFFII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, int p2, int p3)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			bool __ret = __this.AddAnnotRect (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddAnnotRect_arrayFFII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddAnnotRect' and count(parameter)=4 and parameter[1][@type='float[]'] and parameter[2][@type='float'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("AddAnnotRect", "([FFII)Z", "GetAddAnnotRect_arrayFFIIHandler")]
		public virtual bool AddAnnotRect (float[] p0, float p1, int p2, int p3)
		{
			if (id_AddAnnotRect_arrayFFII == IntPtr.Zero)
				id_AddAnnotRect_arrayFFII = JNIEnv.GetMethodID (class_ref, "AddAnnotRect", "([FFII)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_AddAnnotRect_arrayFFII, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddAnnotRect", "([FFII)Z"), new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_AddAnnotStamp_arrayFI;
#pragma warning disable 0169
		static Delegate GetAddAnnotStamp_arrayFIHandler ()
		{
			if (cb_AddAnnotStamp_arrayFI == null)
				cb_AddAnnotStamp_arrayFI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool>) n_AddAnnotStamp_arrayFI);
			return cb_AddAnnotStamp_arrayFI;
		}

		static bool n_AddAnnotStamp_arrayFI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			bool __ret = __this.AddAnnotStamp (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddAnnotStamp_arrayFI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddAnnotStamp' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='int']]"
		[Register ("AddAnnotStamp", "([FI)Z", "GetAddAnnotStamp_arrayFIHandler")]
		public virtual bool AddAnnotStamp (float[] p0, int p1)
		{
			if (id_AddAnnotStamp_arrayFI == IntPtr.Zero)
				id_AddAnnotStamp_arrayFI = JNIEnv.GetMethodID (class_ref, "AddAnnotStamp", "([FI)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_AddAnnotStamp_arrayFI, new JValue (native_p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddAnnotStamp", "([FI)Z"), new JValue (native_p0), new JValue (p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_AddAnnotText_arrayF;
#pragma warning disable 0169
		static Delegate GetAddAnnotText_arrayFHandler ()
		{
			if (cb_AddAnnotText_arrayF == null)
				cb_AddAnnotText_arrayF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddAnnotText_arrayF);
			return cb_AddAnnotText_arrayF;
		}

		static bool n_AddAnnotText_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			bool __ret = __this.AddAnnotText (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddAnnotText_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddAnnotText' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("AddAnnotText", "([F)Z", "GetAddAnnotText_arrayFHandler")]
		public virtual bool AddAnnotText (float[] p0)
		{
			if (id_AddAnnotText_arrayF == IntPtr.Zero)
				id_AddAnnotText_arrayF = JNIEnv.GetMethodID (class_ref, "AddAnnotText", "([F)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_AddAnnotText_arrayF, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddAnnotText", "([F)Z"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_AddAnnotURI_arrayFLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddAnnotURI_arrayFLjava_lang_String_Handler ()
		{
			if (cb_AddAnnotURI_arrayFLjava_lang_String_ == null)
				cb_AddAnnotURI_arrayFLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_AddAnnotURI_arrayFLjava_lang_String_);
			return cb_AddAnnotURI_arrayFLjava_lang_String_;
		}

		static bool n_AddAnnotURI_arrayFLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddAnnotURI (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddAnnotURI_arrayFLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddAnnotURI' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("AddAnnotURI", "([FLjava/lang/String;)Z", "GetAddAnnotURI_arrayFLjava_lang_String_Handler")]
		public virtual bool AddAnnotURI (float[] p0, string p1)
		{
			if (id_AddAnnotURI_arrayFLjava_lang_String_ == IntPtr.Zero)
				id_AddAnnotURI_arrayFLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "AddAnnotURI", "([FLjava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_AddAnnotURI_arrayFLjava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddAnnotURI", "([FLjava/lang/String;)Z"), new JValue (native_p0), new JValue (native_p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_AddContent_Lcom_radaee_pdf_PageContent_Z;
#pragma warning disable 0169
		static Delegate GetAddContent_Lcom_radaee_pdf_PageContent_ZHandler ()
		{
			if (cb_AddContent_Lcom_radaee_pdf_PageContent_Z == null)
				cb_AddContent_Lcom_radaee_pdf_PageContent_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, bool>) n_AddContent_Lcom_radaee_pdf_PageContent_Z);
			return cb_AddContent_Lcom_radaee_pdf_PageContent_Z;
		}

		static bool n_AddContent_Lcom_radaee_pdf_PageContent_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.PageContent p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.PageContent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddContent (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddContent_Lcom_radaee_pdf_PageContent_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddContent' and count(parameter)=2 and parameter[1][@type='com.radaee.pdf.PageContent'] and parameter[2][@type='boolean']]"
		[Register ("AddContent", "(Lcom/radaee/pdf/PageContent;Z)Z", "GetAddContent_Lcom_radaee_pdf_PageContent_ZHandler")]
		public virtual bool AddContent (global::Com.Radaee.Pdf.PageContent p0, bool p1)
		{
			if (id_AddContent_Lcom_radaee_pdf_PageContent_Z == IntPtr.Zero)
				id_AddContent_Lcom_radaee_pdf_PageContent_Z = JNIEnv.GetMethodID (class_ref, "AddContent", "(Lcom/radaee/pdf/PageContent;Z)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_AddContent_Lcom_radaee_pdf_PageContent_Z, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddContent", "(Lcom/radaee/pdf/PageContent;Z)Z"), new JValue (p0), new JValue (p1));
			return __ret;
		}

		static Delegate cb_AddResFont_Lcom_radaee_pdf_Document_DocFont_;
#pragma warning disable 0169
		static Delegate GetAddResFont_Lcom_radaee_pdf_Document_DocFont_Handler ()
		{
			if (cb_AddResFont_Lcom_radaee_pdf_Document_DocFont_ == null)
				cb_AddResFont_Lcom_radaee_pdf_Document_DocFont_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddResFont_Lcom_radaee_pdf_Document_DocFont_);
			return cb_AddResFont_Lcom_radaee_pdf_Document_DocFont_;
		}

		static IntPtr n_AddResFont_Lcom_radaee_pdf_Document_DocFont_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Document.DocFont p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.DocFont> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddResFont (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddResFont_Lcom_radaee_pdf_Document_DocFont_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddResFont' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Document.DocFont']]"
		[Register ("AddResFont", "(Lcom/radaee/pdf/Document$DocFont;)Lcom/radaee/pdf/Page$ResFont;", "GetAddResFont_Lcom_radaee_pdf_Document_DocFont_Handler")]
		public virtual global::Com.Radaee.Pdf.Page.ResFont AddResFont (global::Com.Radaee.Pdf.Document.DocFont p0)
		{
			if (id_AddResFont_Lcom_radaee_pdf_Document_DocFont_ == IntPtr.Zero)
				id_AddResFont_Lcom_radaee_pdf_Document_DocFont_ = JNIEnv.GetMethodID (class_ref, "AddResFont", "(Lcom/radaee/pdf/Document$DocFont;)Lcom/radaee/pdf/Page$ResFont;");

			global::Com.Radaee.Pdf.Page.ResFont __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.ResFont> (JNIEnv.CallObjectMethod  (Handle, id_AddResFont_Lcom_radaee_pdf_Document_DocFont_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.ResFont> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddResFont", "(Lcom/radaee/pdf/Document$DocFont;)Lcom/radaee/pdf/Page$ResFont;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_AddResGState_Lcom_radaee_pdf_Document_DocGState_;
#pragma warning disable 0169
		static Delegate GetAddResGState_Lcom_radaee_pdf_Document_DocGState_Handler ()
		{
			if (cb_AddResGState_Lcom_radaee_pdf_Document_DocGState_ == null)
				cb_AddResGState_Lcom_radaee_pdf_Document_DocGState_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddResGState_Lcom_radaee_pdf_Document_DocGState_);
			return cb_AddResGState_Lcom_radaee_pdf_Document_DocGState_;
		}

		static IntPtr n_AddResGState_Lcom_radaee_pdf_Document_DocGState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Document.DocGState p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.DocGState> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddResGState (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddResGState_Lcom_radaee_pdf_Document_DocGState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddResGState' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Document.DocGState']]"
		[Register ("AddResGState", "(Lcom/radaee/pdf/Document$DocGState;)Lcom/radaee/pdf/Page$ResGState;", "GetAddResGState_Lcom_radaee_pdf_Document_DocGState_Handler")]
		public virtual global::Com.Radaee.Pdf.Page.ResGState AddResGState (global::Com.Radaee.Pdf.Document.DocGState p0)
		{
			if (id_AddResGState_Lcom_radaee_pdf_Document_DocGState_ == IntPtr.Zero)
				id_AddResGState_Lcom_radaee_pdf_Document_DocGState_ = JNIEnv.GetMethodID (class_ref, "AddResGState", "(Lcom/radaee/pdf/Document$DocGState;)Lcom/radaee/pdf/Page$ResGState;");

			global::Com.Radaee.Pdf.Page.ResGState __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.ResGState> (JNIEnv.CallObjectMethod  (Handle, id_AddResGState_Lcom_radaee_pdf_Document_DocGState_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.ResGState> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddResGState", "(Lcom/radaee/pdf/Document$DocGState;)Lcom/radaee/pdf/Page$ResGState;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_AddResImage_Lcom_radaee_pdf_Document_DocImage_;
#pragma warning disable 0169
		static Delegate GetAddResImage_Lcom_radaee_pdf_Document_DocImage_Handler ()
		{
			if (cb_AddResImage_Lcom_radaee_pdf_Document_DocImage_ == null)
				cb_AddResImage_Lcom_radaee_pdf_Document_DocImage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddResImage_Lcom_radaee_pdf_Document_DocImage_);
			return cb_AddResImage_Lcom_radaee_pdf_Document_DocImage_;
		}

		static IntPtr n_AddResImage_Lcom_radaee_pdf_Document_DocImage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Document.DocImage p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.DocImage> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddResImage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AddResImage_Lcom_radaee_pdf_Document_DocImage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='AddResImage' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Document.DocImage']]"
		[Register ("AddResImage", "(Lcom/radaee/pdf/Document$DocImage;)Lcom/radaee/pdf/Page$ResImage;", "GetAddResImage_Lcom_radaee_pdf_Document_DocImage_Handler")]
		public virtual global::Com.Radaee.Pdf.Page.ResImage AddResImage (global::Com.Radaee.Pdf.Document.DocImage p0)
		{
			if (id_AddResImage_Lcom_radaee_pdf_Document_DocImage_ == IntPtr.Zero)
				id_AddResImage_Lcom_radaee_pdf_Document_DocImage_ = JNIEnv.GetMethodID (class_ref, "AddResImage", "(Lcom/radaee/pdf/Document$DocImage;)Lcom/radaee/pdf/Page$ResImage;");

			global::Com.Radaee.Pdf.Page.ResImage __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.ResImage> (JNIEnv.CallObjectMethod  (Handle, id_AddResImage_Lcom_radaee_pdf_Document_DocImage_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.ResImage> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddResImage", "(Lcom/radaee/pdf/Document$DocImage;)Lcom/radaee/pdf/Page$ResImage;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_Close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_Close == null)
				cb_Close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_Close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_Close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='Close' and count(parameter)=0]"
		[Register ("Close", "()V", "GetCloseHandler")]
		public virtual void Close ()
		{
			if (id_Close == IntPtr.Zero)
				id_Close = JNIEnv.GetMethodID (class_ref, "Close", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_Close);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Close", "()V"));
		}

		static Delegate cb_CopyAnnot_Lcom_radaee_pdf_Page_Annotation_arrayF;
#pragma warning disable 0169
		static Delegate GetCopyAnnot_Lcom_radaee_pdf_Page_Annotation_arrayFHandler ()
		{
			if (cb_CopyAnnot_Lcom_radaee_pdf_Page_Annotation_arrayF == null)
				cb_CopyAnnot_Lcom_radaee_pdf_Page_Annotation_arrayF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_CopyAnnot_Lcom_radaee_pdf_Page_Annotation_arrayF);
			return cb_CopyAnnot_Lcom_radaee_pdf_Page_Annotation_arrayF;
		}

		static bool n_CopyAnnot_Lcom_radaee_pdf_Page_Annotation_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Page.Annotation p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (native_p0, JniHandleOwnership.DoNotTransfer);
			float[] p1 = (float[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (float));
			bool __ret = __this.CopyAnnot (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_CopyAnnot_Lcom_radaee_pdf_Page_Annotation_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='CopyAnnot' and count(parameter)=2 and parameter[1][@type='com.radaee.pdf.Page.Annotation'] and parameter[2][@type='float[]']]"
		[Register ("CopyAnnot", "(Lcom/radaee/pdf/Page$Annotation;[F)Z", "GetCopyAnnot_Lcom_radaee_pdf_Page_Annotation_arrayFHandler")]
		public virtual bool CopyAnnot (global::Com.Radaee.Pdf.Page.Annotation p0, float[] p1)
		{
			if (id_CopyAnnot_Lcom_radaee_pdf_Page_Annotation_arrayF == IntPtr.Zero)
				id_CopyAnnot_Lcom_radaee_pdf_Page_Annotation_arrayF = JNIEnv.GetMethodID (class_ref, "CopyAnnot", "(Lcom/radaee/pdf/Page$Annotation;[F)Z");
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_CopyAnnot_Lcom_radaee_pdf_Page_Annotation_arrayF, new JValue (p0), new JValue (native_p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "CopyAnnot", "(Lcom/radaee/pdf/Page$Annotation;[F)Z"), new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_FindOpen_Ljava_lang_String_ZZ;
#pragma warning disable 0169
		static Delegate GetFindOpen_Ljava_lang_String_ZZHandler ()
		{
			if (cb_FindOpen_Ljava_lang_String_ZZ == null)
				cb_FindOpen_Ljava_lang_String_ZZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, bool, IntPtr>) n_FindOpen_Ljava_lang_String_ZZ);
			return cb_FindOpen_Ljava_lang_String_ZZ;
		}

		static IntPtr n_FindOpen_Ljava_lang_String_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, bool p2)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FindOpen (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_FindOpen_Ljava_lang_String_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='FindOpen' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("FindOpen", "(Ljava/lang/String;ZZ)Lcom/radaee/pdf/Page$Finder;", "GetFindOpen_Ljava_lang_String_ZZHandler")]
		public virtual global::Com.Radaee.Pdf.Page.Finder FindOpen (string p0, bool p1, bool p2)
		{
			if (id_FindOpen_Ljava_lang_String_ZZ == IntPtr.Zero)
				id_FindOpen_Ljava_lang_String_ZZ = JNIEnv.GetMethodID (class_ref, "FindOpen", "(Ljava/lang/String;ZZ)Lcom/radaee/pdf/Page$Finder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Radaee.Pdf.Page.Finder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Finder> (JNIEnv.CallObjectMethod  (Handle, id_FindOpen_Ljava_lang_String_ZZ, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Finder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "FindOpen", "(Ljava/lang/String;ZZ)Lcom/radaee/pdf/Page$Finder;"), new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_GetAnnot_I;
#pragma warning disable 0169
		static Delegate GetGetAnnot_IHandler ()
		{
			if (cb_GetAnnot_I == null)
				cb_GetAnnot_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetAnnot_I);
			return cb_GetAnnot_I;
		}

		static IntPtr n_GetAnnot_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetAnnot (p0));
		}
#pragma warning restore 0169

		static IntPtr id_GetAnnot_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='GetAnnot' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("GetAnnot", "(I)Lcom/radaee/pdf/Page$Annotation;", "GetGetAnnot_IHandler")]
		public virtual global::Com.Radaee.Pdf.Page.Annotation GetAnnot (int p0)
		{
			if (id_GetAnnot_I == IntPtr.Zero)
				id_GetAnnot_I = JNIEnv.GetMethodID (class_ref, "GetAnnot", "(I)Lcom/radaee/pdf/Page$Annotation;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (JNIEnv.CallObjectMethod  (Handle, id_GetAnnot_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetAnnot", "(I)Lcom/radaee/pdf/Page$Annotation;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_GetAnnotByName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAnnotByName_Ljava_lang_String_Handler ()
		{
			if (cb_GetAnnotByName_Ljava_lang_String_ == null)
				cb_GetAnnotByName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAnnotByName_Ljava_lang_String_);
			return cb_GetAnnotByName_Ljava_lang_String_;
		}

		static IntPtr n_GetAnnotByName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAnnotByName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetAnnotByName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='GetAnnotByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("GetAnnotByName", "(Ljava/lang/String;)Lcom/radaee/pdf/Page$Annotation;", "GetGetAnnotByName_Ljava_lang_String_Handler")]
		public virtual global::Com.Radaee.Pdf.Page.Annotation GetAnnotByName (string p0)
		{
			if (id_GetAnnotByName_Ljava_lang_String_ == IntPtr.Zero)
				id_GetAnnotByName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "GetAnnotByName", "(Ljava/lang/String;)Lcom/radaee/pdf/Page$Annotation;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Radaee.Pdf.Page.Annotation __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (JNIEnv.CallObjectMethod  (Handle, id_GetAnnotByName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetAnnotByName", "(Ljava/lang/String;)Lcom/radaee/pdf/Page$Annotation;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_GetAnnotFromPoint_FF;
#pragma warning disable 0169
		static Delegate GetGetAnnotFromPoint_FFHandler ()
		{
			if (cb_GetAnnotFromPoint_FF == null)
				cb_GetAnnotFromPoint_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_GetAnnotFromPoint_FF);
			return cb_GetAnnotFromPoint_FF;
		}

		static IntPtr n_GetAnnotFromPoint_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetAnnotFromPoint (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_GetAnnotFromPoint_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='GetAnnotFromPoint' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("GetAnnotFromPoint", "(FF)Lcom/radaee/pdf/Page$Annotation;", "GetGetAnnotFromPoint_FFHandler")]
		public virtual global::Com.Radaee.Pdf.Page.Annotation GetAnnotFromPoint (float p0, float p1)
		{
			if (id_GetAnnotFromPoint_FF == IntPtr.Zero)
				id_GetAnnotFromPoint_FF = JNIEnv.GetMethodID (class_ref, "GetAnnotFromPoint", "(FF)Lcom/radaee/pdf/Page$Annotation;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (JNIEnv.CallObjectMethod  (Handle, id_GetAnnotFromPoint_FF, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page.Annotation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetAnnotFromPoint", "(FF)Lcom/radaee/pdf/Page$Annotation;"), new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_GetCropBox;
#pragma warning disable 0169
		static Delegate GetGetCropBoxHandler ()
		{
			if (cb_GetCropBox == null)
				cb_GetCropBox = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCropBox);
			return cb_GetCropBox;
		}

		static IntPtr n_GetCropBox (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCropBox ());
		}
#pragma warning restore 0169

		static IntPtr id_GetCropBox;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='GetCropBox' and count(parameter)=0]"
		[Register ("GetCropBox", "()[F", "GetGetCropBoxHandler")]
		public virtual float[] GetCropBox ()
		{
			if (id_GetCropBox == IntPtr.Zero)
				id_GetCropBox = JNIEnv.GetMethodID (class_ref, "GetCropBox", "()[F");

			if (GetType () == ThresholdType)
				return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_GetCropBox), JniHandleOwnership.TransferLocalRef, typeof (float));
			else
				return (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetCropBox", "()[F")), JniHandleOwnership.TransferLocalRef, typeof (float));
		}

		static Delegate cb_GetMediaBox;
#pragma warning disable 0169
		static Delegate GetGetMediaBoxHandler ()
		{
			if (cb_GetMediaBox == null)
				cb_GetMediaBox = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMediaBox);
			return cb_GetMediaBox;
		}

		static IntPtr n_GetMediaBox (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetMediaBox ());
		}
#pragma warning restore 0169

		static IntPtr id_GetMediaBox;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='GetMediaBox' and count(parameter)=0]"
		[Register ("GetMediaBox", "()[F", "GetGetMediaBoxHandler")]
		public virtual float[] GetMediaBox ()
		{
			if (id_GetMediaBox == IntPtr.Zero)
				id_GetMediaBox = JNIEnv.GetMethodID (class_ref, "GetMediaBox", "()[F");

			if (GetType () == ThresholdType)
				return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_GetMediaBox), JniHandleOwnership.TransferLocalRef, typeof (float));
			else
				return (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetMediaBox", "()[F")), JniHandleOwnership.TransferLocalRef, typeof (float));
		}

		static Delegate cb_ObjsAlignWord_II;
#pragma warning disable 0169
		static Delegate GetObjsAlignWord_IIHandler ()
		{
			if (cb_ObjsAlignWord_II == null)
				cb_ObjsAlignWord_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_ObjsAlignWord_II);
			return cb_ObjsAlignWord_II;
		}

		static int n_ObjsAlignWord_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjsAlignWord (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_ObjsAlignWord_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='ObjsAlignWord' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("ObjsAlignWord", "(II)I", "GetObjsAlignWord_IIHandler")]
		public virtual int ObjsAlignWord (int p0, int p1)
		{
			if (id_ObjsAlignWord_II == IntPtr.Zero)
				id_ObjsAlignWord_II = JNIEnv.GetMethodID (class_ref, "ObjsAlignWord", "(II)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_ObjsAlignWord_II, new JValue (p0), new JValue (p1));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ObjsAlignWord", "(II)I"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_ObjsGetCharCount;
#pragma warning disable 0169
		static Delegate GetObjsGetCharCountHandler ()
		{
			if (cb_ObjsGetCharCount == null)
				cb_ObjsGetCharCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ObjsGetCharCount);
			return cb_ObjsGetCharCount;
		}

		static int n_ObjsGetCharCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjsGetCharCount ();
		}
#pragma warning restore 0169

		static IntPtr id_ObjsGetCharCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='ObjsGetCharCount' and count(parameter)=0]"
		[Register ("ObjsGetCharCount", "()I", "GetObjsGetCharCountHandler")]
		public virtual int ObjsGetCharCount ()
		{
			if (id_ObjsGetCharCount == IntPtr.Zero)
				id_ObjsGetCharCount = JNIEnv.GetMethodID (class_ref, "ObjsGetCharCount", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_ObjsGetCharCount);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ObjsGetCharCount", "()I"));
		}

		static Delegate cb_ObjsGetCharFontName_I;
#pragma warning disable 0169
		static Delegate GetObjsGetCharFontName_IHandler ()
		{
			if (cb_ObjsGetCharFontName_I == null)
				cb_ObjsGetCharFontName_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ObjsGetCharFontName_I);
			return cb_ObjsGetCharFontName_I;
		}

		static IntPtr n_ObjsGetCharFontName_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ObjsGetCharFontName (p0));
		}
#pragma warning restore 0169

		static IntPtr id_ObjsGetCharFontName_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='ObjsGetCharFontName' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("ObjsGetCharFontName", "(I)Ljava/lang/String;", "GetObjsGetCharFontName_IHandler")]
		public virtual string ObjsGetCharFontName (int p0)
		{
			if (id_ObjsGetCharFontName_I == IntPtr.Zero)
				id_ObjsGetCharFontName_I = JNIEnv.GetMethodID (class_ref, "ObjsGetCharFontName", "(I)Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_ObjsGetCharFontName_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ObjsGetCharFontName", "(I)Ljava/lang/String;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ObjsGetCharIndex_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='ObjsGetCharIndex' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("ObjsGetCharIndex", "([F)I", "")]
		public int ObjsGetCharIndex (float[] p0)
		{
			if (id_ObjsGetCharIndex_arrayF == IntPtr.Zero)
				id_ObjsGetCharIndex_arrayF = JNIEnv.GetMethodID (class_ref, "ObjsGetCharIndex", "([F)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			int __ret = JNIEnv.CallIntMethod  (Handle, id_ObjsGetCharIndex_arrayF, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_ObjsGetCharRect_IarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='ObjsGetCharRect' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float[]']]"
		[Register ("ObjsGetCharRect", "(I[F)V", "")]
		public void ObjsGetCharRect (int p0, float[] p1)
		{
			if (id_ObjsGetCharRect_IarrayF == IntPtr.Zero)
				id_ObjsGetCharRect_IarrayF = JNIEnv.GetMethodID (class_ref, "ObjsGetCharRect", "(I[F)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JNIEnv.CallVoidMethod  (Handle, id_ObjsGetCharRect_IarrayF, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_ObjsGetString_II;
#pragma warning disable 0169
		static Delegate GetObjsGetString_IIHandler ()
		{
			if (cb_ObjsGetString_II == null)
				cb_ObjsGetString_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_ObjsGetString_II);
			return cb_ObjsGetString_II;
		}

		static IntPtr n_ObjsGetString_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ObjsGetString (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_ObjsGetString_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='ObjsGetString' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("ObjsGetString", "(II)Ljava/lang/String;", "GetObjsGetString_IIHandler")]
		public virtual string ObjsGetString (int p0, int p1)
		{
			if (id_ObjsGetString_II == IntPtr.Zero)
				id_ObjsGetString_II = JNIEnv.GetMethodID (class_ref, "ObjsGetString", "(II)Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_ObjsGetString_II, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ObjsGetString", "(II)Ljava/lang/String;"), new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_ObjsStart;
#pragma warning disable 0169
		static Delegate GetObjsStartHandler ()
		{
			if (cb_ObjsStart == null)
				cb_ObjsStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ObjsStart);
			return cb_ObjsStart;
		}

		static void n_ObjsStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ObjsStart ();
		}
#pragma warning restore 0169

		static IntPtr id_ObjsStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='ObjsStart' and count(parameter)=0]"
		[Register ("ObjsStart", "()V", "GetObjsStartHandler")]
		public virtual void ObjsStart ()
		{
			if (id_ObjsStart == IntPtr.Zero)
				id_ObjsStart = JNIEnv.GetMethodID (class_ref, "ObjsStart", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_ObjsStart);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ObjsStart", "()V"));
		}

		static Delegate cb_Reflow_Lcom_radaee_pdf_DIB_FF;
#pragma warning disable 0169
		static Delegate GetReflow_Lcom_radaee_pdf_DIB_FFHandler ()
		{
			if (cb_Reflow_Lcom_radaee_pdf_DIB_FF == null)
				cb_Reflow_Lcom_radaee_pdf_DIB_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, float, bool>) n_Reflow_Lcom_radaee_pdf_DIB_FF);
			return cb_Reflow_Lcom_radaee_pdf_DIB_FF;
		}

		static bool n_Reflow_Lcom_radaee_pdf_DIB_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.DIB p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.DIB> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Reflow (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_Reflow_Lcom_radaee_pdf_DIB_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='Reflow' and count(parameter)=3 and parameter[1][@type='com.radaee.pdf.DIB'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("Reflow", "(Lcom/radaee/pdf/DIB;FF)Z", "GetReflow_Lcom_radaee_pdf_DIB_FFHandler")]
		public virtual bool Reflow (global::Com.Radaee.Pdf.DIB p0, float p1, float p2)
		{
			if (id_Reflow_Lcom_radaee_pdf_DIB_FF == IntPtr.Zero)
				id_Reflow_Lcom_radaee_pdf_DIB_FF = JNIEnv.GetMethodID (class_ref, "Reflow", "(Lcom/radaee/pdf/DIB;FF)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_Reflow_Lcom_radaee_pdf_DIB_FF, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Reflow", "(Lcom/radaee/pdf/DIB;FF)Z"), new JValue (p0), new JValue (p1), new JValue (p2));
			return __ret;
		}

		static Delegate cb_ReflowGetCharColor_II;
#pragma warning disable 0169
		static Delegate GetReflowGetCharColor_IIHandler ()
		{
			if (cb_ReflowGetCharColor_II == null)
				cb_ReflowGetCharColor_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_ReflowGetCharColor_II);
			return cb_ReflowGetCharColor_II;
		}

		static int n_ReflowGetCharColor_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReflowGetCharColor (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_ReflowGetCharColor_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='ReflowGetCharColor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("ReflowGetCharColor", "(II)I", "GetReflowGetCharColor_IIHandler")]
		public virtual int ReflowGetCharColor (int p0, int p1)
		{
			if (id_ReflowGetCharColor_II == IntPtr.Zero)
				id_ReflowGetCharColor_II = JNIEnv.GetMethodID (class_ref, "ReflowGetCharColor", "(II)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_ReflowGetCharColor_II, new JValue (p0), new JValue (p1));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ReflowGetCharColor", "(II)I"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_ReflowGetCharCount_I;
#pragma warning disable 0169
		static Delegate GetReflowGetCharCount_IHandler ()
		{
			if (cb_ReflowGetCharCount_I == null)
				cb_ReflowGetCharCount_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_ReflowGetCharCount_I);
			return cb_ReflowGetCharCount_I;
		}

		static int n_ReflowGetCharCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReflowGetCharCount (p0);
		}
#pragma warning restore 0169

		static IntPtr id_ReflowGetCharCount_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='ReflowGetCharCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("ReflowGetCharCount", "(I)I", "GetReflowGetCharCount_IHandler")]
		public virtual int ReflowGetCharCount (int p0)
		{
			if (id_ReflowGetCharCount_I == IntPtr.Zero)
				id_ReflowGetCharCount_I = JNIEnv.GetMethodID (class_ref, "ReflowGetCharCount", "(I)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_ReflowGetCharCount_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ReflowGetCharCount", "(I)I"), new JValue (p0));
		}

		static Delegate cb_ReflowGetCharFont_II;
#pragma warning disable 0169
		static Delegate GetReflowGetCharFont_IIHandler ()
		{
			if (cb_ReflowGetCharFont_II == null)
				cb_ReflowGetCharFont_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_ReflowGetCharFont_II);
			return cb_ReflowGetCharFont_II;
		}

		static IntPtr n_ReflowGetCharFont_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReflowGetCharFont (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_ReflowGetCharFont_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='ReflowGetCharFont' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("ReflowGetCharFont", "(II)Ljava/lang/String;", "GetReflowGetCharFont_IIHandler")]
		public virtual string ReflowGetCharFont (int p0, int p1)
		{
			if (id_ReflowGetCharFont_II == IntPtr.Zero)
				id_ReflowGetCharFont_II = JNIEnv.GetMethodID (class_ref, "ReflowGetCharFont", "(II)Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_ReflowGetCharFont_II, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ReflowGetCharFont", "(II)Ljava/lang/String;"), new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_ReflowGetCharHeight_II;
#pragma warning disable 0169
		static Delegate GetReflowGetCharHeight_IIHandler ()
		{
			if (cb_ReflowGetCharHeight_II == null)
				cb_ReflowGetCharHeight_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float>) n_ReflowGetCharHeight_II);
			return cb_ReflowGetCharHeight_II;
		}

		static float n_ReflowGetCharHeight_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReflowGetCharHeight (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_ReflowGetCharHeight_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='ReflowGetCharHeight' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("ReflowGetCharHeight", "(II)F", "GetReflowGetCharHeight_IIHandler")]
		public virtual float ReflowGetCharHeight (int p0, int p1)
		{
			if (id_ReflowGetCharHeight_II == IntPtr.Zero)
				id_ReflowGetCharHeight_II = JNIEnv.GetMethodID (class_ref, "ReflowGetCharHeight", "(II)F");

			if (GetType () == ThresholdType)
				return JNIEnv.CallFloatMethod  (Handle, id_ReflowGetCharHeight_II, new JValue (p0), new JValue (p1));
			else
				return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ReflowGetCharHeight", "(II)F"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_ReflowGetCharRect_IIarrayF;
#pragma warning disable 0169
		static Delegate GetReflowGetCharRect_IIarrayFHandler ()
		{
			if (cb_ReflowGetCharRect_IIarrayF == null)
				cb_ReflowGetCharRect_IIarrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_ReflowGetCharRect_IIarrayF);
			return cb_ReflowGetCharRect_IIarrayF;
		}

		static void n_ReflowGetCharRect_IIarrayF (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p2 = (float[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.ReflowGetCharRect (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_ReflowGetCharRect_IIarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='ReflowGetCharRect' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='float[]']]"
		[Register ("ReflowGetCharRect", "(II[F)V", "GetReflowGetCharRect_IIarrayFHandler")]
		public virtual void ReflowGetCharRect (int p0, int p1, float[] p2)
		{
			if (id_ReflowGetCharRect_IIarrayF == IntPtr.Zero)
				id_ReflowGetCharRect_IIarrayF = JNIEnv.GetMethodID (class_ref, "ReflowGetCharRect", "(II[F)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_ReflowGetCharRect_IIarrayF, new JValue (p0), new JValue (p1), new JValue (native_p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ReflowGetCharRect", "(II[F)V"), new JValue (p0), new JValue (p1), new JValue (native_p2));
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_ReflowGetCharUnicode_II;
#pragma warning disable 0169
		static Delegate GetReflowGetCharUnicode_IIHandler ()
		{
			if (cb_ReflowGetCharUnicode_II == null)
				cb_ReflowGetCharUnicode_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_ReflowGetCharUnicode_II);
			return cb_ReflowGetCharUnicode_II;
		}

		static int n_ReflowGetCharUnicode_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReflowGetCharUnicode (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_ReflowGetCharUnicode_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='ReflowGetCharUnicode' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("ReflowGetCharUnicode", "(II)I", "GetReflowGetCharUnicode_IIHandler")]
		public virtual int ReflowGetCharUnicode (int p0, int p1)
		{
			if (id_ReflowGetCharUnicode_II == IntPtr.Zero)
				id_ReflowGetCharUnicode_II = JNIEnv.GetMethodID (class_ref, "ReflowGetCharUnicode", "(II)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_ReflowGetCharUnicode_II, new JValue (p0), new JValue (p1));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ReflowGetCharUnicode", "(II)I"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_ReflowGetCharWidth_II;
#pragma warning disable 0169
		static Delegate GetReflowGetCharWidth_IIHandler ()
		{
			if (cb_ReflowGetCharWidth_II == null)
				cb_ReflowGetCharWidth_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float>) n_ReflowGetCharWidth_II);
			return cb_ReflowGetCharWidth_II;
		}

		static float n_ReflowGetCharWidth_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReflowGetCharWidth (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_ReflowGetCharWidth_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='ReflowGetCharWidth' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("ReflowGetCharWidth", "(II)F", "GetReflowGetCharWidth_IIHandler")]
		public virtual float ReflowGetCharWidth (int p0, int p1)
		{
			if (id_ReflowGetCharWidth_II == IntPtr.Zero)
				id_ReflowGetCharWidth_II = JNIEnv.GetMethodID (class_ref, "ReflowGetCharWidth", "(II)F");

			if (GetType () == ThresholdType)
				return JNIEnv.CallFloatMethod  (Handle, id_ReflowGetCharWidth_II, new JValue (p0), new JValue (p1));
			else
				return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ReflowGetCharWidth", "(II)F"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_ReflowGetParaCount;
#pragma warning disable 0169
		static Delegate GetReflowGetParaCountHandler ()
		{
			if (cb_ReflowGetParaCount == null)
				cb_ReflowGetParaCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ReflowGetParaCount);
			return cb_ReflowGetParaCount;
		}

		static int n_ReflowGetParaCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReflowGetParaCount ();
		}
#pragma warning restore 0169

		static IntPtr id_ReflowGetParaCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='ReflowGetParaCount' and count(parameter)=0]"
		[Register ("ReflowGetParaCount", "()I", "GetReflowGetParaCountHandler")]
		public virtual int ReflowGetParaCount ()
		{
			if (id_ReflowGetParaCount == IntPtr.Zero)
				id_ReflowGetParaCount = JNIEnv.GetMethodID (class_ref, "ReflowGetParaCount", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_ReflowGetParaCount);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ReflowGetParaCount", "()I"));
		}

		static Delegate cb_ReflowGetText_IIII;
#pragma warning disable 0169
		static Delegate GetReflowGetText_IIIIHandler ()
		{
			if (cb_ReflowGetText_IIII == null)
				cb_ReflowGetText_IIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, IntPtr>) n_ReflowGetText_IIII);
			return cb_ReflowGetText_IIII;
		}

		static IntPtr n_ReflowGetText_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReflowGetText (p0, p1, p2, p3));
		}
#pragma warning restore 0169

		static IntPtr id_ReflowGetText_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='ReflowGetText' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("ReflowGetText", "(IIII)Ljava/lang/String;", "GetReflowGetText_IIIIHandler")]
		public virtual string ReflowGetText (int p0, int p1, int p2, int p3)
		{
			if (id_ReflowGetText_IIII == IntPtr.Zero)
				id_ReflowGetText_IIII = JNIEnv.GetMethodID (class_ref, "ReflowGetText", "(IIII)Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_ReflowGetText_IIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ReflowGetText", "(IIII)Ljava/lang/String;"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_ReflowStart_FFZ;
#pragma warning disable 0169
		static Delegate GetReflowStart_FFZHandler ()
		{
			if (cb_ReflowStart_FFZ == null)
				cb_ReflowStart_FFZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, bool, float>) n_ReflowStart_FFZ);
			return cb_ReflowStart_FFZ;
		}

		static float n_ReflowStart_FFZ (IntPtr jnienv, IntPtr native__this, float p0, float p1, bool p2)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReflowStart (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_ReflowStart_FFZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='ReflowStart' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='boolean']]"
		[Register ("ReflowStart", "(FFZ)F", "GetReflowStart_FFZHandler")]
		public virtual float ReflowStart (float p0, float p1, bool p2)
		{
			if (id_ReflowStart_FFZ == IntPtr.Zero)
				id_ReflowStart_FFZ = JNIEnv.GetMethodID (class_ref, "ReflowStart", "(FFZ)F");

			if (GetType () == ThresholdType)
				return JNIEnv.CallFloatMethod  (Handle, id_ReflowStart_FFZ, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ReflowStart", "(FFZ)F"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_ReflowToBmp_Landroid_graphics_Bitmap_FF;
#pragma warning disable 0169
		static Delegate GetReflowToBmp_Landroid_graphics_Bitmap_FFHandler ()
		{
			if (cb_ReflowToBmp_Landroid_graphics_Bitmap_FF == null)
				cb_ReflowToBmp_Landroid_graphics_Bitmap_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, float, bool>) n_ReflowToBmp_Landroid_graphics_Bitmap_FF);
			return cb_ReflowToBmp_Landroid_graphics_Bitmap_FF;
		}

		static bool n_ReflowToBmp_Landroid_graphics_Bitmap_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ReflowToBmp (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_ReflowToBmp_Landroid_graphics_Bitmap_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='ReflowToBmp' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("ReflowToBmp", "(Landroid/graphics/Bitmap;FF)Z", "GetReflowToBmp_Landroid_graphics_Bitmap_FFHandler")]
		public virtual bool ReflowToBmp (global::Android.Graphics.Bitmap p0, float p1, float p2)
		{
			if (id_ReflowToBmp_Landroid_graphics_Bitmap_FF == IntPtr.Zero)
				id_ReflowToBmp_Landroid_graphics_Bitmap_FF = JNIEnv.GetMethodID (class_ref, "ReflowToBmp", "(Landroid/graphics/Bitmap;FF)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_ReflowToBmp_Landroid_graphics_Bitmap_FF, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ReflowToBmp", "(Landroid/graphics/Bitmap;FF)Z"), new JValue (p0), new JValue (p1), new JValue (p2));
			return __ret;
		}

		static Delegate cb_Render_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_Matrix_;
#pragma warning disable 0169
		static Delegate GetRender_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_Matrix_Handler ()
		{
			if (cb_Render_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_Matrix_ == null)
				cb_Render_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_Matrix_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Render_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_Matrix_);
			return cb_Render_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_Matrix_;
		}

		static bool n_Render_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_Matrix_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.DIB p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.DIB> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Matrix p1 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Matrix> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Render (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_Render_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_Matrix_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='Render' and count(parameter)=2 and parameter[1][@type='com.radaee.pdf.DIB'] and parameter[2][@type='com.radaee.pdf.Matrix']]"
		[Register ("Render", "(Lcom/radaee/pdf/DIB;Lcom/radaee/pdf/Matrix;)Z", "GetRender_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_Matrix_Handler")]
		public virtual bool Render (global::Com.Radaee.Pdf.DIB p0, global::Com.Radaee.Pdf.Matrix p1)
		{
			if (id_Render_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_Matrix_ == IntPtr.Zero)
				id_Render_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_Matrix_ = JNIEnv.GetMethodID (class_ref, "Render", "(Lcom/radaee/pdf/DIB;Lcom/radaee/pdf/Matrix;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_Render_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_Matrix_, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Render", "(Lcom/radaee/pdf/DIB;Lcom/radaee/pdf/Matrix;)Z"), new JValue (p0), new JValue (p1));
			return __ret;
		}

		static Delegate cb_RenderCancel;
#pragma warning disable 0169
		static Delegate GetRenderCancelHandler ()
		{
			if (cb_RenderCancel == null)
				cb_RenderCancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RenderCancel);
			return cb_RenderCancel;
		}

		static void n_RenderCancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RenderCancel ();
		}
#pragma warning restore 0169

		static IntPtr id_RenderCancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='RenderCancel' and count(parameter)=0]"
		[Register ("RenderCancel", "()V", "GetRenderCancelHandler")]
		public virtual void RenderCancel ()
		{
			if (id_RenderCancel == IntPtr.Zero)
				id_RenderCancel = JNIEnv.GetMethodID (class_ref, "RenderCancel", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_RenderCancel);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RenderCancel", "()V"));
		}

		static Delegate cb_RenderIsFinished;
#pragma warning disable 0169
		static Delegate GetRenderIsFinishedHandler ()
		{
			if (cb_RenderIsFinished == null)
				cb_RenderIsFinished = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_RenderIsFinished);
			return cb_RenderIsFinished;
		}

		static bool n_RenderIsFinished (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RenderIsFinished ();
		}
#pragma warning restore 0169

		static IntPtr id_RenderIsFinished;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='RenderIsFinished' and count(parameter)=0]"
		[Register ("RenderIsFinished", "()Z", "GetRenderIsFinishedHandler")]
		public virtual bool RenderIsFinished ()
		{
			if (id_RenderIsFinished == IntPtr.Zero)
				id_RenderIsFinished = JNIEnv.GetMethodID (class_ref, "RenderIsFinished", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_RenderIsFinished);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RenderIsFinished", "()Z"));
		}

		static Delegate cb_RenderPrePare_Lcom_radaee_pdf_DIB_;
#pragma warning disable 0169
		static Delegate GetRenderPrePare_Lcom_radaee_pdf_DIB_Handler ()
		{
			if (cb_RenderPrePare_Lcom_radaee_pdf_DIB_ == null)
				cb_RenderPrePare_Lcom_radaee_pdf_DIB_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RenderPrePare_Lcom_radaee_pdf_DIB_);
			return cb_RenderPrePare_Lcom_radaee_pdf_DIB_;
		}

		static void n_RenderPrePare_Lcom_radaee_pdf_DIB_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.DIB p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.DIB> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RenderPrePare (p0);
		}
#pragma warning restore 0169

		static IntPtr id_RenderPrePare_Lcom_radaee_pdf_DIB_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='RenderPrePare' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.DIB']]"
		[Register ("RenderPrePare", "(Lcom/radaee/pdf/DIB;)V", "GetRenderPrePare_Lcom_radaee_pdf_DIB_Handler")]
		public virtual void RenderPrePare (global::Com.Radaee.Pdf.DIB p0)
		{
			if (id_RenderPrePare_Lcom_radaee_pdf_DIB_ == IntPtr.Zero)
				id_RenderPrePare_Lcom_radaee_pdf_DIB_ = JNIEnv.GetMethodID (class_ref, "RenderPrePare", "(Lcom/radaee/pdf/DIB;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_RenderPrePare_Lcom_radaee_pdf_DIB_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RenderPrePare", "(Lcom/radaee/pdf/DIB;)V"), new JValue (p0));
		}

		static Delegate cb_RenderThumb_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetRenderThumb_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_RenderThumb_Landroid_graphics_Bitmap_ == null)
				cb_RenderThumb_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RenderThumb_Landroid_graphics_Bitmap_);
			return cb_RenderThumb_Landroid_graphics_Bitmap_;
		}

		static bool n_RenderThumb_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RenderThumb (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RenderThumb_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='RenderThumb' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("RenderThumb", "(Landroid/graphics/Bitmap;)Z", "GetRenderThumb_Landroid_graphics_Bitmap_Handler")]
		public virtual bool RenderThumb (global::Android.Graphics.Bitmap p0)
		{
			if (id_RenderThumb_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_RenderThumb_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "RenderThumb", "(Landroid/graphics/Bitmap;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_RenderThumb_Landroid_graphics_Bitmap_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RenderThumb", "(Landroid/graphics/Bitmap;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_RenderThumbToBuf_arrayIII;
#pragma warning disable 0169
		static Delegate GetRenderThumbToBuf_arrayIIIHandler ()
		{
			if (cb_RenderThumbToBuf_arrayIII == null)
				cb_RenderThumbToBuf_arrayIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool>) n_RenderThumbToBuf_arrayIII);
			return cb_RenderThumbToBuf_arrayIII;
		}

		static bool n_RenderThumbToBuf_arrayIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			bool __ret = __this.RenderThumbToBuf (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RenderThumbToBuf_arrayIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='RenderThumbToBuf' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("RenderThumbToBuf", "([III)Z", "GetRenderThumbToBuf_arrayIIIHandler")]
		public virtual bool RenderThumbToBuf (int[] p0, int p1, int p2)
		{
			if (id_RenderThumbToBuf_arrayIII == IntPtr.Zero)
				id_RenderThumbToBuf_arrayIII = JNIEnv.GetMethodID (class_ref, "RenderThumbToBuf", "([III)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_RenderThumbToBuf_arrayIII, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RenderThumbToBuf", "([III)Z"), new JValue (native_p0), new JValue (p1), new JValue (p2));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_RenderThumbToDIB_Lcom_radaee_pdf_DIB_;
#pragma warning disable 0169
		static Delegate GetRenderThumbToDIB_Lcom_radaee_pdf_DIB_Handler ()
		{
			if (cb_RenderThumbToDIB_Lcom_radaee_pdf_DIB_ == null)
				cb_RenderThumbToDIB_Lcom_radaee_pdf_DIB_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RenderThumbToDIB_Lcom_radaee_pdf_DIB_);
			return cb_RenderThumbToDIB_Lcom_radaee_pdf_DIB_;
		}

		static bool n_RenderThumbToDIB_Lcom_radaee_pdf_DIB_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.DIB p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.DIB> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RenderThumbToDIB (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RenderThumbToDIB_Lcom_radaee_pdf_DIB_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='RenderThumbToDIB' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.DIB']]"
		[Register ("RenderThumbToDIB", "(Lcom/radaee/pdf/DIB;)Z", "GetRenderThumbToDIB_Lcom_radaee_pdf_DIB_Handler")]
		public virtual bool RenderThumbToDIB (global::Com.Radaee.Pdf.DIB p0)
		{
			if (id_RenderThumbToDIB_Lcom_radaee_pdf_DIB_ == IntPtr.Zero)
				id_RenderThumbToDIB_Lcom_radaee_pdf_DIB_ = JNIEnv.GetMethodID (class_ref, "RenderThumbToDIB", "(Lcom/radaee/pdf/DIB;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_RenderThumbToDIB_Lcom_radaee_pdf_DIB_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RenderThumbToDIB", "(Lcom/radaee/pdf/DIB;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_RenderToBmp_Landroid_graphics_Bitmap_Lcom_radaee_pdf_Matrix_;
#pragma warning disable 0169
		static Delegate GetRenderToBmp_Landroid_graphics_Bitmap_Lcom_radaee_pdf_Matrix_Handler ()
		{
			if (cb_RenderToBmp_Landroid_graphics_Bitmap_Lcom_radaee_pdf_Matrix_ == null)
				cb_RenderToBmp_Landroid_graphics_Bitmap_Lcom_radaee_pdf_Matrix_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_RenderToBmp_Landroid_graphics_Bitmap_Lcom_radaee_pdf_Matrix_);
			return cb_RenderToBmp_Landroid_graphics_Bitmap_Lcom_radaee_pdf_Matrix_;
		}

		static bool n_RenderToBmp_Landroid_graphics_Bitmap_Lcom_radaee_pdf_Matrix_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Matrix p1 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Matrix> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RenderToBmp (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RenderToBmp_Landroid_graphics_Bitmap_Lcom_radaee_pdf_Matrix_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='RenderToBmp' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.radaee.pdf.Matrix']]"
		[Register ("RenderToBmp", "(Landroid/graphics/Bitmap;Lcom/radaee/pdf/Matrix;)Z", "GetRenderToBmp_Landroid_graphics_Bitmap_Lcom_radaee_pdf_Matrix_Handler")]
		public virtual bool RenderToBmp (global::Android.Graphics.Bitmap p0, global::Com.Radaee.Pdf.Matrix p1)
		{
			if (id_RenderToBmp_Landroid_graphics_Bitmap_Lcom_radaee_pdf_Matrix_ == IntPtr.Zero)
				id_RenderToBmp_Landroid_graphics_Bitmap_Lcom_radaee_pdf_Matrix_ = JNIEnv.GetMethodID (class_ref, "RenderToBmp", "(Landroid/graphics/Bitmap;Lcom/radaee/pdf/Matrix;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_RenderToBmp_Landroid_graphics_Bitmap_Lcom_radaee_pdf_Matrix_, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RenderToBmp", "(Landroid/graphics/Bitmap;Lcom/radaee/pdf/Matrix;)Z"), new JValue (p0), new JValue (p1));
			return __ret;
		}

		static Delegate cb_RenderToBuf_arrayIIILcom_radaee_pdf_Matrix_;
#pragma warning disable 0169
		static Delegate GetRenderToBuf_arrayIIILcom_radaee_pdf_Matrix_Handler ()
		{
			if (cb_RenderToBuf_arrayIIILcom_radaee_pdf_Matrix_ == null)
				cb_RenderToBuf_arrayIIILcom_radaee_pdf_Matrix_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr, bool>) n_RenderToBuf_arrayIIILcom_radaee_pdf_Matrix_);
			return cb_RenderToBuf_arrayIIILcom_radaee_pdf_Matrix_;
		}

		static bool n_RenderToBuf_arrayIIILcom_radaee_pdf_Matrix_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Com.Radaee.Pdf.Matrix p3 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Matrix> (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RenderToBuf (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_RenderToBuf_arrayIIILcom_radaee_pdf_Matrix_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='RenderToBuf' and count(parameter)=4 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.radaee.pdf.Matrix']]"
		[Register ("RenderToBuf", "([IIILcom/radaee/pdf/Matrix;)Z", "GetRenderToBuf_arrayIIILcom_radaee_pdf_Matrix_Handler")]
		public virtual bool RenderToBuf (int[] p0, int p1, int p2, global::Com.Radaee.Pdf.Matrix p3)
		{
			if (id_RenderToBuf_arrayIIILcom_radaee_pdf_Matrix_ == IntPtr.Zero)
				id_RenderToBuf_arrayIIILcom_radaee_pdf_Matrix_ = JNIEnv.GetMethodID (class_ref, "RenderToBuf", "([IIILcom/radaee/pdf/Matrix;)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_RenderToBuf_arrayIIILcom_radaee_pdf_Matrix_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RenderToBuf", "([IIILcom/radaee/pdf/Matrix;)Z"), new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_Render_Normal_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_Matrix_;
#pragma warning disable 0169
		static Delegate GetRender_Normal_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_Matrix_Handler ()
		{
			if (cb_Render_Normal_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_Matrix_ == null)
				cb_Render_Normal_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_Matrix_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Render_Normal_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_Matrix_);
			return cb_Render_Normal_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_Matrix_;
		}

		static void n_Render_Normal_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_Matrix_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Radaee.Pdf.Page __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.DIB p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.DIB> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Matrix p1 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Matrix> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Render_Normal (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_Render_Normal_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_Matrix_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Page']/method[@name='Render_Normal' and count(parameter)=2 and parameter[1][@type='com.radaee.pdf.DIB'] and parameter[2][@type='com.radaee.pdf.Matrix']]"
		[Register ("Render_Normal", "(Lcom/radaee/pdf/DIB;Lcom/radaee/pdf/Matrix;)V", "GetRender_Normal_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_Matrix_Handler")]
		public virtual void Render_Normal (global::Com.Radaee.Pdf.DIB p0, global::Com.Radaee.Pdf.Matrix p1)
		{
			if (id_Render_Normal_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_Matrix_ == IntPtr.Zero)
				id_Render_Normal_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_Matrix_ = JNIEnv.GetMethodID (class_ref, "Render_Normal", "(Lcom/radaee/pdf/DIB;Lcom/radaee/pdf/Matrix;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_Render_Normal_Lcom_radaee_pdf_DIB_Lcom_radaee_pdf_Matrix_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Render_Normal", "(Lcom/radaee/pdf/DIB;Lcom/radaee/pdf/Matrix;)V"), new JValue (p0), new JValue (p1));
		}

	}
}

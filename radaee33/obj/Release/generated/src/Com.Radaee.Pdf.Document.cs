using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Radaee.Pdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']"
	[global::Android.Runtime.Register ("com/radaee/pdf/Document", DoNotGenerateAcw=true)]
	public partial class Document : global::Java.Lang.Object {


		static IntPtr hand_val_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/field[@name='hand_val']"
		[Register ("hand_val")]
		protected long HandVal {
			get {
				if (hand_val_jfieldId == IntPtr.Zero)
					hand_val_jfieldId = JNIEnv.GetFieldID (class_ref, "hand_val", "J");
				return JNIEnv.GetLongField (Handle, hand_val_jfieldId);
			}
			set {
				if (hand_val_jfieldId == IntPtr.Zero)
					hand_val_jfieldId = JNIEnv.GetFieldID (class_ref, "hand_val", "J");
				JNIEnv.SetField (Handle, hand_val_jfieldId, value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.DocFont']"
		[global::Android.Runtime.Register ("com/radaee/pdf/Document$DocFont", DoNotGenerateAcw=true)]
		public partial class DocFont : global::Java.Lang.Object {


			static IntPtr hand_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.DocFont']/field[@name='hand']"
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
					return JNIEnv.FindClass ("com/radaee/pdf/Document$DocFont", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DocFont); }
			}

			protected DocFont (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_radaee_pdf_Document_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.DocFont']/constructor[@name='Document.DocFont' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Document']]"
			[Register (".ctor", "(Lcom/radaee/pdf/Document;)V", "")]
			public DocFont (global::Com.Radaee.Pdf.Document __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (DocFont)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self));
					return;
				}

				if (id_ctor_Lcom_radaee_pdf_Document_ == IntPtr.Zero)
					id_ctor_Lcom_radaee_pdf_Document_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/radaee/pdf/Document;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_radaee_pdf_Document_, new JValue (__self)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_radaee_pdf_Document_, new JValue (__self));
			}

			static Delegate cb_GetAscent;
#pragma warning disable 0169
			static Delegate GetGetAscentHandler ()
			{
				if (cb_GetAscent == null)
					cb_GetAscent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetAscent);
				return cb_GetAscent;
			}

			static float n_GetAscent (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Document.DocFont __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.DocFont> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Ascent;
			}
#pragma warning restore 0169

			static IntPtr id_GetAscent;
			public virtual float Ascent {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.DocFont']/method[@name='GetAscent' and count(parameter)=0]"
				[Register ("GetAscent", "()F", "GetGetAscentHandler")]
				get {
					if (id_GetAscent == IntPtr.Zero)
						id_GetAscent = JNIEnv.GetMethodID (class_ref, "GetAscent", "()F");

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_GetAscent);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetAscent", "()F"));
				}
			}

			static Delegate cb_GetDescent;
#pragma warning disable 0169
			static Delegate GetGetDescentHandler ()
			{
				if (cb_GetDescent == null)
					cb_GetDescent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetDescent);
				return cb_GetDescent;
			}

			static float n_GetDescent (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Document.DocFont __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.DocFont> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Descent;
			}
#pragma warning restore 0169

			static IntPtr id_GetDescent;
			public virtual float Descent {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.DocFont']/method[@name='GetDescent' and count(parameter)=0]"
				[Register ("GetDescent", "()F", "GetGetDescentHandler")]
				get {
					if (id_GetDescent == IntPtr.Zero)
						id_GetDescent = JNIEnv.GetMethodID (class_ref, "GetDescent", "()F");

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_GetDescent);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetDescent", "()F"));
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.DocGState']"
		[global::Android.Runtime.Register ("com/radaee/pdf/Document$DocGState", DoNotGenerateAcw=true)]
		public partial class DocGState : global::Java.Lang.Object {


			static IntPtr hand_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.DocGState']/field[@name='hand']"
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
					return JNIEnv.FindClass ("com/radaee/pdf/Document$DocGState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DocGState); }
			}

			protected DocGState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_radaee_pdf_Document_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.DocGState']/constructor[@name='Document.DocGState' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Document']]"
			[Register (".ctor", "(Lcom/radaee/pdf/Document;)V", "")]
			public DocGState (global::Com.Radaee.Pdf.Document __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (DocGState)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self));
					return;
				}

				if (id_ctor_Lcom_radaee_pdf_Document_ == IntPtr.Zero)
					id_ctor_Lcom_radaee_pdf_Document_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/radaee/pdf/Document;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_radaee_pdf_Document_, new JValue (__self)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_radaee_pdf_Document_, new JValue (__self));
			}

			static Delegate cb_SetFillAlpha_I;
#pragma warning disable 0169
			static Delegate GetSetFillAlpha_IHandler ()
			{
				if (cb_SetFillAlpha_I == null)
					cb_SetFillAlpha_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_SetFillAlpha_I);
				return cb_SetFillAlpha_I;
			}

			static bool n_SetFillAlpha_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Radaee.Pdf.Document.DocGState __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.DocGState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.SetFillAlpha (p0);
			}
#pragma warning restore 0169

			static IntPtr id_SetFillAlpha_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.DocGState']/method[@name='SetFillAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("SetFillAlpha", "(I)Z", "GetSetFillAlpha_IHandler")]
			public virtual bool SetFillAlpha (int p0)
			{
				if (id_SetFillAlpha_I == IntPtr.Zero)
					id_SetFillAlpha_I = JNIEnv.GetMethodID (class_ref, "SetFillAlpha", "(I)Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_SetFillAlpha_I, new JValue (p0));
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetFillAlpha", "(I)Z"), new JValue (p0));
			}

			static Delegate cb_SetStrokeAlpha_I;
#pragma warning disable 0169
			static Delegate GetSetStrokeAlpha_IHandler ()
			{
				if (cb_SetStrokeAlpha_I == null)
					cb_SetStrokeAlpha_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_SetStrokeAlpha_I);
				return cb_SetStrokeAlpha_I;
			}

			static bool n_SetStrokeAlpha_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Radaee.Pdf.Document.DocGState __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.DocGState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.SetStrokeAlpha (p0);
			}
#pragma warning restore 0169

			static IntPtr id_SetStrokeAlpha_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.DocGState']/method[@name='SetStrokeAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("SetStrokeAlpha", "(I)Z", "GetSetStrokeAlpha_IHandler")]
			public virtual bool SetStrokeAlpha (int p0)
			{
				if (id_SetStrokeAlpha_I == IntPtr.Zero)
					id_SetStrokeAlpha_I = JNIEnv.GetMethodID (class_ref, "SetStrokeAlpha", "(I)Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_SetStrokeAlpha_I, new JValue (p0));
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetStrokeAlpha", "(I)Z"), new JValue (p0));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.DocImage']"
		[global::Android.Runtime.Register ("com/radaee/pdf/Document$DocImage", DoNotGenerateAcw=true)]
		public partial class DocImage : global::Java.Lang.Object {


			static IntPtr hand_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.DocImage']/field[@name='hand']"
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
					return JNIEnv.FindClass ("com/radaee/pdf/Document$DocImage", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DocImage); }
			}

			protected DocImage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_radaee_pdf_Document_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.DocImage']/constructor[@name='Document.DocImage' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Document']]"
			[Register (".ctor", "(Lcom/radaee/pdf/Document;)V", "")]
			public DocImage (global::Com.Radaee.Pdf.Document __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (DocImage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self));
					return;
				}

				if (id_ctor_Lcom_radaee_pdf_Document_ == IntPtr.Zero)
					id_ctor_Lcom_radaee_pdf_Document_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/radaee/pdf/Document;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_radaee_pdf_Document_, new JValue (__self)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_radaee_pdf_Document_, new JValue (__self));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.ImportContext']"
		[global::Android.Runtime.Register ("com/radaee/pdf/Document$ImportContext", DoNotGenerateAcw=true)]
		public partial class ImportContext : global::Java.Lang.Object {


			static IntPtr hand_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.ImportContext']/field[@name='hand']"
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

			static IntPtr m_doc_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.ImportContext']/field[@name='m_doc']"
			[Register ("m_doc")]
			protected global::Com.Radaee.Pdf.Document MDoc {
				get {
					if (m_doc_jfieldId == IntPtr.Zero)
						m_doc_jfieldId = JNIEnv.GetFieldID (class_ref, "m_doc", "Lcom/radaee/pdf/Document;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, m_doc_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (m_doc_jfieldId == IntPtr.Zero)
						m_doc_jfieldId = JNIEnv.GetFieldID (class_ref, "m_doc", "Lcom/radaee/pdf/Document;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, m_doc_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/radaee/pdf/Document$ImportContext", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ImportContext); }
			}

			protected ImportContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_radaee_pdf_Document_Lcom_radaee_pdf_Document_J;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.ImportContext']/constructor[@name='Document.ImportContext' and count(parameter)=3 and parameter[1][@type='com.radaee.pdf.Document'] and parameter[2][@type='com.radaee.pdf.Document'] and parameter[3][@type='long']]"
			[Register (".ctor", "(Lcom/radaee/pdf/Document;Lcom/radaee/pdf/Document;J)V", "")]
			protected ImportContext (global::Com.Radaee.Pdf.Document __self, global::Com.Radaee.Pdf.Document p1, long p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (ImportContext)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/radaee/pdf/Document;J)V", new JValue (__self), new JValue (p1), new JValue (p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/radaee/pdf/Document;J)V", new JValue (__self), new JValue (p1), new JValue (p2));
					return;
				}

				if (id_ctor_Lcom_radaee_pdf_Document_Lcom_radaee_pdf_Document_J == IntPtr.Zero)
					id_ctor_Lcom_radaee_pdf_Document_Lcom_radaee_pdf_Document_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/radaee/pdf/Document;Lcom/radaee/pdf/Document;J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_radaee_pdf_Document_Lcom_radaee_pdf_Document_J, new JValue (__self), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_radaee_pdf_Document_Lcom_radaee_pdf_Document_J, new JValue (__self), new JValue (p1), new JValue (p2));
			}

			static Delegate cb_Destroy;
#pragma warning disable 0169
			static Delegate GetDestroyHandler ()
			{
				if (cb_Destroy == null)
					cb_Destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
				return cb_Destroy;
			}

			static void n_Destroy (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Document.ImportContext __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.ImportContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Destroy ();
			}
#pragma warning restore 0169

			static IntPtr id_Destroy;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.ImportContext']/method[@name='Destroy' and count(parameter)=0]"
			[Register ("Destroy", "()V", "GetDestroyHandler")]
			public virtual void Destroy ()
			{
				if (id_Destroy == IntPtr.Zero)
					id_Destroy = JNIEnv.GetMethodID (class_ref, "Destroy", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_Destroy);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Destroy", "()V"));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.Outline']"
		[global::Android.Runtime.Register ("com/radaee/pdf/Document$Outline", DoNotGenerateAcw=true)]
		public partial class Outline : global::Java.Lang.Object {


			static IntPtr doc_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.Outline']/field[@name='doc']"
			[Register ("doc")]
			protected global::Com.Radaee.Pdf.Document Doc {
				get {
					if (doc_jfieldId == IntPtr.Zero)
						doc_jfieldId = JNIEnv.GetFieldID (class_ref, "doc", "Lcom/radaee/pdf/Document;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, doc_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (doc_jfieldId == IntPtr.Zero)
						doc_jfieldId = JNIEnv.GetFieldID (class_ref, "doc", "Lcom/radaee/pdf/Document;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, doc_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr hand_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.Outline']/field[@name='hand']"
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
					return JNIEnv.FindClass ("com/radaee/pdf/Document$Outline", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Outline); }
			}

			protected Outline (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_radaee_pdf_Document_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.Outline']/constructor[@name='Document.Outline' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Document']]"
			[Register (".ctor", "(Lcom/radaee/pdf/Document;)V", "")]
			public Outline (global::Com.Radaee.Pdf.Document __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Outline)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self));
					return;
				}

				if (id_ctor_Lcom_radaee_pdf_Document_ == IntPtr.Zero)
					id_ctor_Lcom_radaee_pdf_Document_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/radaee/pdf/Document;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_radaee_pdf_Document_, new JValue (__self)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_radaee_pdf_Document_, new JValue (__self));
			}

			static Delegate cb_GetChild;
#pragma warning disable 0169
			static Delegate GetGetChildHandler ()
			{
				if (cb_GetChild == null)
					cb_GetChild = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChild);
				return cb_GetChild;
			}

			static IntPtr n_GetChild (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Document.Outline __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.Outline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Child);
			}
#pragma warning restore 0169

			static IntPtr id_GetChild;
			public virtual global::Com.Radaee.Pdf.Document.Outline Child {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.Outline']/method[@name='GetChild' and count(parameter)=0]"
				[Register ("GetChild", "()Lcom/radaee/pdf/Document$Outline;", "GetGetChildHandler")]
				get {
					if (id_GetChild == IntPtr.Zero)
						id_GetChild = JNIEnv.GetMethodID (class_ref, "GetChild", "()Lcom/radaee/pdf/Document$Outline;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.Outline> (JNIEnv.CallObjectMethod  (Handle, id_GetChild), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.Outline> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetChild", "()Lcom/radaee/pdf/Document$Outline;")), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Radaee.Pdf.Document.Outline __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.Outline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Dest;
			}
#pragma warning restore 0169

			static IntPtr id_GetDest;
			public virtual int Dest {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.Outline']/method[@name='GetDest' and count(parameter)=0]"
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
				global::Com.Radaee.Pdf.Document.Outline __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.Outline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.FileLink);
			}
#pragma warning restore 0169

			static IntPtr id_GetFileLink;
			public virtual string FileLink {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.Outline']/method[@name='GetFileLink' and count(parameter)=0]"
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

			static Delegate cb_GetNext;
#pragma warning disable 0169
			static Delegate GetGetNextHandler ()
			{
				if (cb_GetNext == null)
					cb_GetNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNext);
				return cb_GetNext;
			}

			static IntPtr n_GetNext (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Document.Outline __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.Outline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Next);
			}
#pragma warning restore 0169

			static IntPtr id_GetNext;
			public virtual global::Com.Radaee.Pdf.Document.Outline Next {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.Outline']/method[@name='GetNext' and count(parameter)=0]"
				[Register ("GetNext", "()Lcom/radaee/pdf/Document$Outline;", "GetGetNextHandler")]
				get {
					if (id_GetNext == IntPtr.Zero)
						id_GetNext = JNIEnv.GetMethodID (class_ref, "GetNext", "()Lcom/radaee/pdf/Document$Outline;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.Outline> (JNIEnv.CallObjectMethod  (Handle, id_GetNext), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.Outline> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetNext", "()Lcom/radaee/pdf/Document$Outline;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_GetTitle;
#pragma warning disable 0169
			static Delegate GetGetTitleHandler ()
			{
				if (cb_GetTitle == null)
					cb_GetTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
				return cb_GetTitle;
			}

			static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Document.Outline __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.Outline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Title);
			}
#pragma warning restore 0169

			static IntPtr id_GetTitle;
			public virtual string Title {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.Outline']/method[@name='GetTitle' and count(parameter)=0]"
				[Register ("GetTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
				get {
					if (id_GetTitle == IntPtr.Zero)
						id_GetTitle = JNIEnv.GetMethodID (class_ref, "GetTitle", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Radaee.Pdf.Document.Outline __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.Outline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.URI);
			}
#pragma warning restore 0169

			static IntPtr id_GetURI;
			public virtual string URI {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.Outline']/method[@name='GetURI' and count(parameter)=0]"
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

			static Delegate cb_AddChild_Ljava_lang_String_IF;
#pragma warning disable 0169
			static Delegate GetAddChild_Ljava_lang_String_IFHandler ()
			{
				if (cb_AddChild_Ljava_lang_String_IF == null)
					cb_AddChild_Ljava_lang_String_IF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, float, bool>) n_AddChild_Ljava_lang_String_IF);
				return cb_AddChild_Ljava_lang_String_IF;
			}

			static bool n_AddChild_Ljava_lang_String_IF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, float p2)
			{
				global::Com.Radaee.Pdf.Document.Outline __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.Outline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.AddChild (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_AddChild_Ljava_lang_String_IF;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.Outline']/method[@name='AddChild' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='float']]"
			[Register ("AddChild", "(Ljava/lang/String;IF)Z", "GetAddChild_Ljava_lang_String_IFHandler")]
			public virtual bool AddChild (string p0, int p1, float p2)
			{
				if (id_AddChild_Ljava_lang_String_IF == IntPtr.Zero)
					id_AddChild_Ljava_lang_String_IF = JNIEnv.GetMethodID (class_ref, "AddChild", "(Ljava/lang/String;IF)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_AddChild_Ljava_lang_String_IF, new JValue (native_p0), new JValue (p1), new JValue (p2));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddChild", "(Ljava/lang/String;IF)Z"), new JValue (native_p0), new JValue (p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_AddNext_Ljava_lang_String_IF;
#pragma warning disable 0169
			static Delegate GetAddNext_Ljava_lang_String_IFHandler ()
			{
				if (cb_AddNext_Ljava_lang_String_IF == null)
					cb_AddNext_Ljava_lang_String_IF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, float, bool>) n_AddNext_Ljava_lang_String_IF);
				return cb_AddNext_Ljava_lang_String_IF;
			}

			static bool n_AddNext_Ljava_lang_String_IF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, float p2)
			{
				global::Com.Radaee.Pdf.Document.Outline __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.Outline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.AddNext (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_AddNext_Ljava_lang_String_IF;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.Outline']/method[@name='AddNext' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='float']]"
			[Register ("AddNext", "(Ljava/lang/String;IF)Z", "GetAddNext_Ljava_lang_String_IFHandler")]
			public virtual bool AddNext (string p0, int p1, float p2)
			{
				if (id_AddNext_Ljava_lang_String_IF == IntPtr.Zero)
					id_AddNext_Ljava_lang_String_IF = JNIEnv.GetMethodID (class_ref, "AddNext", "(Ljava/lang/String;IF)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_AddNext_Ljava_lang_String_IF, new JValue (native_p0), new JValue (p1), new JValue (p2));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AddNext", "(Ljava/lang/String;IF)Z"), new JValue (native_p0), new JValue (p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_RemoveFromDoc;
#pragma warning disable 0169
			static Delegate GetRemoveFromDocHandler ()
			{
				if (cb_RemoveFromDoc == null)
					cb_RemoveFromDoc = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_RemoveFromDoc);
				return cb_RemoveFromDoc;
			}

			static bool n_RemoveFromDoc (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Radaee.Pdf.Document.Outline __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.Outline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.RemoveFromDoc ();
			}
#pragma warning restore 0169

			static IntPtr id_RemoveFromDoc;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.Outline']/method[@name='RemoveFromDoc' and count(parameter)=0]"
			[Register ("RemoveFromDoc", "()Z", "GetRemoveFromDocHandler")]
			public virtual bool RemoveFromDoc ()
			{
				if (id_RemoveFromDoc == IntPtr.Zero)
					id_RemoveFromDoc = JNIEnv.GetMethodID (class_ref, "RemoveFromDoc", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_RemoveFromDoc);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RemoveFromDoc", "()Z"));
			}

			static Delegate cb_SetTitle_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTitle_Ljava_lang_String_Handler ()
			{
				if (cb_SetTitle_Ljava_lang_String_ == null)
					cb_SetTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetTitle_Ljava_lang_String_);
				return cb_SetTitle_Ljava_lang_String_;
			}

			static bool n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Radaee.Pdf.Document.Outline __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.Outline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.SetTitle (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_SetTitle_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document.Outline']/method[@name='SetTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetTitle", "(Ljava/lang/String;)Z", "GetSetTitle_Ljava_lang_String_Handler")]
			public virtual bool SetTitle (string p0)
			{
				if (id_SetTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_SetTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetTitle", "(Ljava/lang/String;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_SetTitle_Ljava_lang_String_, new JValue (native_p0));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetTitle", "(Ljava/lang/String;)Z"), new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.radaee.pdf']/interface[@name='Document.PDFFontDelegate']"
		[Register ("com/radaee/pdf/Document$PDFFontDelegate", "", "Com.Radaee.Pdf.Document/IPDFFontDelegateInvoker")]
		public partial interface IPDFFontDelegate : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/interface[@name='Document.PDFFontDelegate']/method[@name='GetExtFont' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int[]']]"
			[Register ("GetExtFont", "(Ljava/lang/String;Ljava/lang/String;I[I)Ljava/lang/String;", "GetGetExtFont_Ljava_lang_String_Ljava_lang_String_IarrayIHandler:Com.Radaee.Pdf.Document/IPDFFontDelegateInvoker, radaee33")]
			string GetExtFont (string p0, string p1, int p2, int[] p3);

		}

		[global::Android.Runtime.Register ("com/radaee/pdf/Document$PDFFontDelegate", DoNotGenerateAcw=true)]
		internal class IPDFFontDelegateInvoker : global::Java.Lang.Object, IPDFFontDelegate {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/radaee/pdf/Document$PDFFontDelegate");
			IntPtr class_ref;

			public static IPDFFontDelegate GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPDFFontDelegate> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.radaee.pdf.Document.PDFFontDelegate"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPDFFontDelegateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IPDFFontDelegateInvoker); }
			}

			static Delegate cb_GetExtFont_Ljava_lang_String_Ljava_lang_String_IarrayI;
#pragma warning disable 0169
			static Delegate GetGetExtFont_Ljava_lang_String_Ljava_lang_String_IarrayIHandler ()
			{
				if (cb_GetExtFont_Ljava_lang_String_Ljava_lang_String_IarrayI == null)
					cb_GetExtFont_Ljava_lang_String_Ljava_lang_String_IarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_GetExtFont_Ljava_lang_String_Ljava_lang_String_IarrayI);
				return cb_GetExtFont_Ljava_lang_String_Ljava_lang_String_IarrayI;
			}

			static IntPtr n_GetExtFont_Ljava_lang_String_Ljava_lang_String_IarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3)
			{
				global::Com.Radaee.Pdf.Document.IPDFFontDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.IPDFFontDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				int[] p3 = (int[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (int));
				IntPtr __ret = JNIEnv.NewString (__this.GetExtFont (p0, p1, p2, p3));
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_GetExtFont_Ljava_lang_String_Ljava_lang_String_IarrayI;
			public string GetExtFont (string p0, string p1, int p2, int[] p3)
			{
				if (id_GetExtFont_Ljava_lang_String_Ljava_lang_String_IarrayI == IntPtr.Zero)
					id_GetExtFont_Ljava_lang_String_Ljava_lang_String_IarrayI = JNIEnv.GetMethodID (class_ref, "GetExtFont", "(Ljava/lang/String;Ljava/lang/String;I[I)Ljava/lang/String;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_GetExtFont_Ljava_lang_String_Ljava_lang_String_IarrayI, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				return __ret;
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.radaee.pdf']/interface[@name='Document.PDFStream']"
		[Register ("com/radaee/pdf/Document$PDFStream", "", "Com.Radaee.Pdf.Document/IPDFStreamInvoker")]
		public partial interface IPDFStream : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/interface[@name='Document.PDFStream']/method[@name='get_size' and count(parameter)=0]"
			[Register ("get_size", "()I", "GetGet_sizeHandler:Com.Radaee.Pdf.Document/IPDFStreamInvoker, radaee33")]
			int Get_size ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/interface[@name='Document.PDFStream']/method[@name='read' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("read", "([B)I", "GetRead_arrayBHandler:Com.Radaee.Pdf.Document/IPDFStreamInvoker, radaee33")]
			int Read (byte[] p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/interface[@name='Document.PDFStream']/method[@name='seek' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("seek", "(I)V", "GetSeek_IHandler:Com.Radaee.Pdf.Document/IPDFStreamInvoker, radaee33")]
			void Seek (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/interface[@name='Document.PDFStream']/method[@name='tell' and count(parameter)=0]"
			[Register ("tell", "()I", "GetTellHandler:Com.Radaee.Pdf.Document/IPDFStreamInvoker, radaee33")]
			int Tell ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/interface[@name='Document.PDFStream']/method[@name='write' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("write", "([B)I", "GetWrite_arrayBHandler:Com.Radaee.Pdf.Document/IPDFStreamInvoker, radaee33")]
			int Write (byte[] p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/interface[@name='Document.PDFStream']/method[@name='writeable' and count(parameter)=0]"
			[Register ("writeable", "()Z", "GetWriteableHandler:Com.Radaee.Pdf.Document/IPDFStreamInvoker, radaee33")]
			bool Writeable ();

		}

		[global::Android.Runtime.Register ("com/radaee/pdf/Document$PDFStream", DoNotGenerateAcw=true)]
		internal class IPDFStreamInvoker : global::Java.Lang.Object, IPDFStream {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/radaee/pdf/Document$PDFStream");
			IntPtr class_ref;

			public static IPDFStream GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPDFStream> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.radaee.pdf.Document.PDFStream"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPDFStreamInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IPDFStreamInvoker); }
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
				global::Com.Radaee.Pdf.Document.IPDFStream __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.IPDFStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Get_size ();
			}
#pragma warning restore 0169

			IntPtr id_get_size;
			public int Get_size ()
			{
				if (id_get_size == IntPtr.Zero)
					id_get_size = JNIEnv.GetMethodID (class_ref, "get_size", "()I");
				return JNIEnv.CallIntMethod (Handle, id_get_size);
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
				global::Com.Radaee.Pdf.Document.IPDFStream __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.IPDFStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Read (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_read_arrayB;
			public int Read (byte[] p0)
			{
				if (id_read_arrayB == IntPtr.Zero)
					id_read_arrayB = JNIEnv.GetMethodID (class_ref, "read", "([B)I");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				int __ret = JNIEnv.CallIntMethod (Handle, id_read_arrayB, new JValue (native_p0));
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
				global::Com.Radaee.Pdf.Document.IPDFStream __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.IPDFStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Seek (p0);
			}
#pragma warning restore 0169

			IntPtr id_seek_I;
			public void Seek (int p0)
			{
				if (id_seek_I == IntPtr.Zero)
					id_seek_I = JNIEnv.GetMethodID (class_ref, "seek", "(I)V");
				JNIEnv.CallVoidMethod (Handle, id_seek_I, new JValue (p0));
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
				global::Com.Radaee.Pdf.Document.IPDFStream __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.IPDFStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Tell ();
			}
#pragma warning restore 0169

			IntPtr id_tell;
			public int Tell ()
			{
				if (id_tell == IntPtr.Zero)
					id_tell = JNIEnv.GetMethodID (class_ref, "tell", "()I");
				return JNIEnv.CallIntMethod (Handle, id_tell);
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
				global::Com.Radaee.Pdf.Document.IPDFStream __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.IPDFStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.Write (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_write_arrayB;
			public int Write (byte[] p0)
			{
				if (id_write_arrayB == IntPtr.Zero)
					id_write_arrayB = JNIEnv.GetMethodID (class_ref, "write", "([B)I");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				int __ret = JNIEnv.CallIntMethod (Handle, id_write_arrayB, new JValue (native_p0));
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
				global::Com.Radaee.Pdf.Document.IPDFStream __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.IPDFStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Writeable ();
			}
#pragma warning restore 0169

			IntPtr id_writeable;
			public bool Writeable ()
			{
				if (id_writeable == IntPtr.Zero)
					id_writeable = JNIEnv.GetMethodID (class_ref, "writeable", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_writeable);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/radaee/pdf/Document", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Document); }
		}

		protected Document (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/constructor[@name='Document' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Document () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Document)) {
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

		static IntPtr id_ctor_arrayI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/constructor[@name='Document' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register (".ctor", "([I)V", "")]
		public Document (int[] p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);;
			if (GetType () != typeof (Document)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([I)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([I)V", new JValue (native_p0));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return;
			}

			if (id_ctor_arrayI == IntPtr.Zero)
				id_ctor_arrayI = JNIEnv.GetMethodID (class_ref, "<init>", "([I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayI, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayI, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_IsEncrypted;
#pragma warning disable 0169
		static Delegate GetIsEncryptedHandler ()
		{
			if (cb_IsEncrypted == null)
				cb_IsEncrypted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEncrypted);
			return cb_IsEncrypted;
		}

		static bool n_IsEncrypted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEncrypted;
		}
#pragma warning restore 0169

		static IntPtr id_IsEncrypted;
		public virtual bool IsEncrypted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='IsEncrypted' and count(parameter)=0]"
			[Register ("IsEncrypted", "()Z", "GetIsEncryptedHandler")]
			get {
				if (id_IsEncrypted == IntPtr.Zero)
					id_IsEncrypted = JNIEnv.GetMethodID (class_ref, "IsEncrypted", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_IsEncrypted);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "IsEncrypted", "()Z"));
			}
		}

		static Delegate cb_IsOpened;
#pragma warning disable 0169
		static Delegate GetIsOpenedHandler ()
		{
			if (cb_IsOpened == null)
				cb_IsOpened = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOpened);
			return cb_IsOpened;
		}

		static bool n_IsOpened (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpened;
		}
#pragma warning restore 0169

		static IntPtr id_IsOpened;
		public virtual bool IsOpened {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='IsOpened' and count(parameter)=0]"
			[Register ("IsOpened", "()Z", "GetIsOpenedHandler")]
			get {
				if (id_IsOpened == IntPtr.Zero)
					id_IsOpened = JNIEnv.GetMethodID (class_ref, "IsOpened", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_IsOpened);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "IsOpened", "()Z"));
			}
		}

		static Delegate cb_GetOutlines;
#pragma warning disable 0169
		static Delegate GetGetOutlinesHandler ()
		{
			if (cb_GetOutlines == null)
				cb_GetOutlines = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOutlines);
			return cb_GetOutlines;
		}

		static IntPtr n_GetOutlines (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Outlines);
		}
#pragma warning restore 0169

		static IntPtr id_GetOutlines;
		public virtual global::Com.Radaee.Pdf.Document.Outline Outlines {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='GetOutlines' and count(parameter)=0]"
			[Register ("GetOutlines", "()Lcom/radaee/pdf/Document$Outline;", "GetGetOutlinesHandler")]
			get {
				if (id_GetOutlines == IntPtr.Zero)
					id_GetOutlines = JNIEnv.GetMethodID (class_ref, "GetOutlines", "()Lcom/radaee/pdf/Document$Outline;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.Outline> (JNIEnv.CallObjectMethod  (Handle, id_GetOutlines), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.Outline> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetOutlines", "()Lcom/radaee/pdf/Document$Outline;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_GetPageCount;
#pragma warning disable 0169
		static Delegate GetGetPageCountHandler ()
		{
			if (cb_GetPageCount == null)
				cb_GetPageCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPageCount);
			return cb_GetPageCount;
		}

		static int n_GetPageCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PageCount;
		}
#pragma warning restore 0169

		static IntPtr id_GetPageCount;
		public virtual int PageCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='GetPageCount' and count(parameter)=0]"
			[Register ("GetPageCount", "()I", "GetGetPageCountHandler")]
			get {
				if (id_GetPageCount == IntPtr.Zero)
					id_GetPageCount = JNIEnv.GetMethodID (class_ref, "GetPageCount", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_GetPageCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetPageCount", "()I"));
			}
		}

		static Delegate cb_GetPerm;
#pragma warning disable 0169
		static Delegate GetGetPermHandler ()
		{
			if (cb_GetPerm == null)
				cb_GetPerm = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPerm);
			return cb_GetPerm;
		}

		static int n_GetPerm (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Perm;
		}
#pragma warning restore 0169

		static IntPtr id_GetPerm;
		public virtual int Perm {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='GetPerm' and count(parameter)=0]"
			[Register ("GetPerm", "()I", "GetGetPermHandler")]
			get {
				if (id_GetPerm == IntPtr.Zero)
					id_GetPerm = JNIEnv.GetMethodID (class_ref, "GetPerm", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_GetPerm);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetPerm", "()I"));
			}
		}

		static Delegate cb_GetPermission;
#pragma warning disable 0169
		static Delegate GetGetPermissionHandler ()
		{
			if (cb_GetPermission == null)
				cb_GetPermission = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPermission);
			return cb_GetPermission;
		}

		static int n_GetPermission (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Permission;
		}
#pragma warning restore 0169

		static IntPtr id_GetPermission;
		public virtual int Permission {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='GetPermission' and count(parameter)=0]"
			[Register ("GetPermission", "()I", "GetGetPermissionHandler")]
			get {
				if (id_GetPermission == IntPtr.Zero)
					id_GetPermission = JNIEnv.GetMethodID (class_ref, "GetPermission", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_GetPermission);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetPermission", "()I"));
			}
		}

		static Delegate cb_GetSignFilter;
#pragma warning disable 0169
		static Delegate GetGetSignFilterHandler ()
		{
			if (cb_GetSignFilter == null)
				cb_GetSignFilter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSignFilter);
			return cb_GetSignFilter;
		}

		static IntPtr n_GetSignFilter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SignFilter);
		}
#pragma warning restore 0169

		static IntPtr id_GetSignFilter;
		public virtual string SignFilter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='GetSignFilter' and count(parameter)=0]"
			[Register ("GetSignFilter", "()Ljava/lang/String;", "GetGetSignFilterHandler")]
			get {
				if (id_GetSignFilter == IntPtr.Zero)
					id_GetSignFilter = JNIEnv.GetMethodID (class_ref, "GetSignFilter", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetSignFilter), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSignFilter", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_GetSignSubFilter;
#pragma warning disable 0169
		static Delegate GetGetSignSubFilterHandler ()
		{
			if (cb_GetSignSubFilter == null)
				cb_GetSignSubFilter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSignSubFilter);
			return cb_GetSignSubFilter;
		}

		static IntPtr n_GetSignSubFilter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SignSubFilter);
		}
#pragma warning restore 0169

		static IntPtr id_GetSignSubFilter;
		public virtual string SignSubFilter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='GetSignSubFilter' and count(parameter)=0]"
			[Register ("GetSignSubFilter", "()Ljava/lang/String;", "GetGetSignSubFilterHandler")]
			get {
				if (id_GetSignSubFilter == IntPtr.Zero)
					id_GetSignSubFilter = JNIEnv.GetMethodID (class_ref, "GetSignSubFilter", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetSignSubFilter), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSignSubFilter", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_CanSave;
#pragma warning disable 0169
		static Delegate GetCanSaveHandler ()
		{
			if (cb_CanSave == null)
				cb_CanSave = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanSave);
			return cb_CanSave;
		}

		static bool n_CanSave (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanSave ();
		}
#pragma warning restore 0169

		static IntPtr id_CanSave;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='CanSave' and count(parameter)=0]"
		[Register ("CanSave", "()Z", "GetCanSaveHandler")]
		public virtual bool CanSave ()
		{
			if (id_CanSave == IntPtr.Zero)
				id_CanSave = JNIEnv.GetMethodID (class_ref, "CanSave", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_CanSave);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "CanSave", "()Z"));
		}

		static Delegate cb_ChangePageRect_IFFFF;
#pragma warning disable 0169
		static Delegate GetChangePageRect_IFFFFHandler ()
		{
			if (cb_ChangePageRect_IFFFF == null)
				cb_ChangePageRect_IFFFF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, float, float, float, float, bool>) n_ChangePageRect_IFFFF);
			return cb_ChangePageRect_IFFFF;
		}

		static bool n_ChangePageRect_IFFFF (IntPtr jnienv, IntPtr native__this, int p0, float p1, float p2, float p3, float p4)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChangePageRect (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_ChangePageRect_IFFFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='ChangePageRect' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float']]"
		[Register ("ChangePageRect", "(IFFFF)Z", "GetChangePageRect_IFFFFHandler")]
		public virtual bool ChangePageRect (int p0, float p1, float p2, float p3, float p4)
		{
			if (id_ChangePageRect_IFFFF == IntPtr.Zero)
				id_ChangePageRect_IFFFF = JNIEnv.GetMethodID (class_ref, "ChangePageRect", "(IFFFF)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_ChangePageRect_IFFFF, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ChangePageRect", "(IFFFF)Z"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static Delegate cb_CheckSignByteRange;
#pragma warning disable 0169
		static Delegate GetCheckSignByteRangeHandler ()
		{
			if (cb_CheckSignByteRange == null)
				cb_CheckSignByteRange = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_CheckSignByteRange);
			return cb_CheckSignByteRange;
		}

		static int n_CheckSignByteRange (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckSignByteRange ();
		}
#pragma warning restore 0169

		static IntPtr id_CheckSignByteRange;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='CheckSignByteRange' and count(parameter)=0]"
		[Register ("CheckSignByteRange", "()I", "GetCheckSignByteRangeHandler")]
		public virtual int CheckSignByteRange ()
		{
			if (id_CheckSignByteRange == IntPtr.Zero)
				id_CheckSignByteRange = JNIEnv.GetMethodID (class_ref, "CheckSignByteRange", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_CheckSignByteRange);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "CheckSignByteRange", "()I"));
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
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_Close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='Close' and count(parameter)=0]"
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

		static Delegate cb_Create_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreate_Ljava_lang_String_Handler ()
		{
			if (cb_Create_Ljava_lang_String_ == null)
				cb_Create_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Create_Ljava_lang_String_);
			return cb_Create_Ljava_lang_String_;
		}

		static int n_Create_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Create (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_Create_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='Create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("Create", "(Ljava/lang/String;)I", "GetCreate_Ljava_lang_String_Handler")]
		public virtual int Create (string p0)
		{
			if (id_Create_Ljava_lang_String_ == IntPtr.Zero)
				id_Create_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "Create", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_Create_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Create", "(Ljava/lang/String;)I"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_CreateForStream_Lcom_radaee_pdf_Document_PDFStream_;
#pragma warning disable 0169
		static Delegate GetCreateForStream_Lcom_radaee_pdf_Document_PDFStream_Handler ()
		{
			if (cb_CreateForStream_Lcom_radaee_pdf_Document_PDFStream_ == null)
				cb_CreateForStream_Lcom_radaee_pdf_Document_PDFStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CreateForStream_Lcom_radaee_pdf_Document_PDFStream_);
			return cb_CreateForStream_Lcom_radaee_pdf_Document_PDFStream_;
		}

		static int n_CreateForStream_Lcom_radaee_pdf_Document_PDFStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Document.IPDFStream p0 = (global::Com.Radaee.Pdf.Document.IPDFStream)global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.IPDFStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CreateForStream (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_CreateForStream_Lcom_radaee_pdf_Document_PDFStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='CreateForStream' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Document.PDFStream']]"
		[Register ("CreateForStream", "(Lcom/radaee/pdf/Document$PDFStream;)I", "GetCreateForStream_Lcom_radaee_pdf_Document_PDFStream_Handler")]
		public virtual int CreateForStream (global::Com.Radaee.Pdf.Document.IPDFStream p0)
		{
			if (id_CreateForStream_Lcom_radaee_pdf_Document_PDFStream_ == IntPtr.Zero)
				id_CreateForStream_Lcom_radaee_pdf_Document_PDFStream_ = JNIEnv.GetMethodID (class_ref, "CreateForStream", "(Lcom/radaee/pdf/Document$PDFStream;)I");

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_CreateForStream_Lcom_radaee_pdf_Document_PDFStream_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "CreateForStream", "(Lcom/radaee/pdf/Document$PDFStream;)I"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_EncryptAs_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IIarrayB;
#pragma warning disable 0169
		static Delegate GetEncryptAs_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IIarrayBHandler ()
		{
			if (cb_EncryptAs_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IIarrayB == null)
				cb_EncryptAs_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IIarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr, bool>) n_EncryptAs_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IIarrayB);
			return cb_EncryptAs_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IIarrayB;
		}

		static bool n_EncryptAs_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IIarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, int p4, IntPtr native_p5)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			byte[] p5 = (byte[]) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.EncryptAs (p0, p1, p2, p3, p4, p5);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_EncryptAs_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IIarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='EncryptAs' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='byte[]']]"
		[Register ("EncryptAs", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;II[B)Z", "GetEncryptAs_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IIarrayBHandler")]
		public virtual bool EncryptAs (string p0, string p1, string p2, int p3, int p4, byte[] p5)
		{
			if (id_EncryptAs_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IIarrayB == IntPtr.Zero)
				id_EncryptAs_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IIarrayB = JNIEnv.GetMethodID (class_ref, "EncryptAs", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;II[B)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p5 = JNIEnv.NewArray (p5);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_EncryptAs_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IIarrayB, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (p4), new JValue (native_p5));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "EncryptAs", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;II[B)Z"), new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (p4), new JValue (native_p5));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p5 != null) {
				JNIEnv.CopyArray (native_p5, p5);
				JNIEnv.DeleteLocalRef (native_p5);
			}
			return __ret;
		}

		static Delegate cb_ExportForm;
#pragma warning disable 0169
		static Delegate GetExportFormHandler ()
		{
			if (cb_ExportForm == null)
				cb_ExportForm = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ExportForm);
			return cb_ExportForm;
		}

		static IntPtr n_ExportForm (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExportForm ());
		}
#pragma warning restore 0169

		static IntPtr id_ExportForm;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='ExportForm' and count(parameter)=0]"
		[Register ("ExportForm", "()Ljava/lang/String;", "GetExportFormHandler")]
		public virtual string ExportForm ()
		{
			if (id_ExportForm == IntPtr.Zero)
				id_ExportForm = JNIEnv.GetMethodID (class_ref, "ExportForm", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_ExportForm), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ExportForm", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_GetID_I;
#pragma warning disable 0169
		static Delegate GetGetID_IHandler ()
		{
			if (cb_GetID_I == null)
				cb_GetID_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetID_I);
			return cb_GetID_I;
		}

		static IntPtr n_GetID_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetID (p0));
		}
#pragma warning restore 0169

		static IntPtr id_GetID_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='GetID' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("GetID", "(I)[B", "GetGetID_IHandler")]
		public virtual byte[] GetID (int p0)
		{
			if (id_GetID_I == IntPtr.Zero)
				id_GetID_I = JNIEnv.GetMethodID (class_ref, "GetID", "(I)[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_GetID_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetID", "(I)[B"), new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_GetMeta_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMeta_Ljava_lang_String_Handler ()
		{
			if (cb_GetMeta_Ljava_lang_String_ == null)
				cb_GetMeta_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMeta_Ljava_lang_String_);
			return cb_GetMeta_Ljava_lang_String_;
		}

		static IntPtr n_GetMeta_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetMeta (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_GetMeta_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='GetMeta' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("GetMeta", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetMeta_Ljava_lang_String_Handler")]
		public virtual string GetMeta (string p0)
		{
			if (id_GetMeta_Ljava_lang_String_ == IntPtr.Zero)
				id_GetMeta_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "GetMeta", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetMeta_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetMeta", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_GetPage_I;
#pragma warning disable 0169
		static Delegate GetGetPage_IHandler ()
		{
			if (cb_GetPage_I == null)
				cb_GetPage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetPage_I);
			return cb_GetPage_I;
		}

		static IntPtr n_GetPage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetPage (p0));
		}
#pragma warning restore 0169

		static IntPtr id_GetPage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='GetPage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("GetPage", "(I)Lcom/radaee/pdf/Page;", "GetGetPage_IHandler")]
		public virtual global::Com.Radaee.Pdf.Page GetPage (int p0)
		{
			if (id_GetPage_I == IntPtr.Zero)
				id_GetPage_I = JNIEnv.GetMethodID (class_ref, "GetPage", "(I)Lcom/radaee/pdf/Page;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (JNIEnv.CallObjectMethod  (Handle, id_GetPage_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetPage", "(I)Lcom/radaee/pdf/Page;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_GetPageHeight_I;
#pragma warning disable 0169
		static Delegate GetGetPageHeight_IHandler ()
		{
			if (cb_GetPageHeight_I == null)
				cb_GetPageHeight_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, float>) n_GetPageHeight_I);
			return cb_GetPageHeight_I;
		}

		static float n_GetPageHeight_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPageHeight (p0);
		}
#pragma warning restore 0169

		static IntPtr id_GetPageHeight_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='GetPageHeight' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("GetPageHeight", "(I)F", "GetGetPageHeight_IHandler")]
		public virtual float GetPageHeight (int p0)
		{
			if (id_GetPageHeight_I == IntPtr.Zero)
				id_GetPageHeight_I = JNIEnv.GetMethodID (class_ref, "GetPageHeight", "(I)F");

			if (GetType () == ThresholdType)
				return JNIEnv.CallFloatMethod  (Handle, id_GetPageHeight_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetPageHeight", "(I)F"), new JValue (p0));
		}

		static Delegate cb_GetPageWidth_I;
#pragma warning disable 0169
		static Delegate GetGetPageWidth_IHandler ()
		{
			if (cb_GetPageWidth_I == null)
				cb_GetPageWidth_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, float>) n_GetPageWidth_I);
			return cb_GetPageWidth_I;
		}

		static float n_GetPageWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPageWidth (p0);
		}
#pragma warning restore 0169

		static IntPtr id_GetPageWidth_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='GetPageWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("GetPageWidth", "(I)F", "GetGetPageWidth_IHandler")]
		public virtual float GetPageWidth (int p0)
		{
			if (id_GetPageWidth_I == IntPtr.Zero)
				id_GetPageWidth_I = JNIEnv.GetMethodID (class_ref, "GetPageWidth", "(I)F");

			if (GetType () == ThresholdType)
				return JNIEnv.CallFloatMethod  (Handle, id_GetPageWidth_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetPageWidth", "(I)F"), new JValue (p0));
		}

		static Delegate cb_GetSignByteRange;
#pragma warning disable 0169
		static Delegate GetGetSignByteRangeHandler ()
		{
			if (cb_GetSignByteRange == null)
				cb_GetSignByteRange = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSignByteRange);
			return cb_GetSignByteRange;
		}

		static IntPtr n_GetSignByteRange (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSignByteRange ());
		}
#pragma warning restore 0169

		static IntPtr id_GetSignByteRange;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='GetSignByteRange' and count(parameter)=0]"
		[Register ("GetSignByteRange", "()[I", "GetGetSignByteRangeHandler")]
		public virtual int[] GetSignByteRange ()
		{
			if (id_GetSignByteRange == IntPtr.Zero)
				id_GetSignByteRange = JNIEnv.GetMethodID (class_ref, "GetSignByteRange", "()[I");

			if (GetType () == ThresholdType)
				return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_GetSignByteRange), JniHandleOwnership.TransferLocalRef, typeof (int));
			else
				return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSignByteRange", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
		}

		static Delegate cb_GetSignContents;
#pragma warning disable 0169
		static Delegate GetGetSignContentsHandler ()
		{
			if (cb_GetSignContents == null)
				cb_GetSignContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSignContents);
			return cb_GetSignContents;
		}

		static IntPtr n_GetSignContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSignContents ());
		}
#pragma warning restore 0169

		static IntPtr id_GetSignContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='GetSignContents' and count(parameter)=0]"
		[Register ("GetSignContents", "()[B", "GetGetSignContentsHandler")]
		public virtual byte[] GetSignContents ()
		{
			if (id_GetSignContents == IntPtr.Zero)
				id_GetSignContents = JNIEnv.GetMethodID (class_ref, "GetSignContents", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_GetSignContents), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetSignContents", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_ImportPage_Lcom_radaee_pdf_Document_ImportContext_II;
#pragma warning disable 0169
		static Delegate GetImportPage_Lcom_radaee_pdf_Document_ImportContext_IIHandler ()
		{
			if (cb_ImportPage_Lcom_radaee_pdf_Document_ImportContext_II == null)
				cb_ImportPage_Lcom_radaee_pdf_Document_ImportContext_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool>) n_ImportPage_Lcom_radaee_pdf_Document_ImportContext_II);
			return cb_ImportPage_Lcom_radaee_pdf_Document_ImportContext_II;
		}

		static bool n_ImportPage_Lcom_radaee_pdf_Document_ImportContext_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Document.ImportContext p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.ImportContext> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ImportPage (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_ImportPage_Lcom_radaee_pdf_Document_ImportContext_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='ImportPage' and count(parameter)=3 and parameter[1][@type='com.radaee.pdf.Document.ImportContext'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("ImportPage", "(Lcom/radaee/pdf/Document$ImportContext;II)Z", "GetImportPage_Lcom_radaee_pdf_Document_ImportContext_IIHandler")]
		public virtual bool ImportPage (global::Com.Radaee.Pdf.Document.ImportContext p0, int p1, int p2)
		{
			if (id_ImportPage_Lcom_radaee_pdf_Document_ImportContext_II == IntPtr.Zero)
				id_ImportPage_Lcom_radaee_pdf_Document_ImportContext_II = JNIEnv.GetMethodID (class_ref, "ImportPage", "(Lcom/radaee/pdf/Document$ImportContext;II)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_ImportPage_Lcom_radaee_pdf_Document_ImportContext_II, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ImportPage", "(Lcom/radaee/pdf/Document$ImportContext;II)Z"), new JValue (p0), new JValue (p1), new JValue (p2));
			return __ret;
		}

		static Delegate cb_ImportStart_Lcom_radaee_pdf_Document_;
#pragma warning disable 0169
		static Delegate GetImportStart_Lcom_radaee_pdf_Document_Handler ()
		{
			if (cb_ImportStart_Lcom_radaee_pdf_Document_ == null)
				cb_ImportStart_Lcom_radaee_pdf_Document_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ImportStart_Lcom_radaee_pdf_Document_);
			return cb_ImportStart_Lcom_radaee_pdf_Document_;
		}

		static IntPtr n_ImportStart_Lcom_radaee_pdf_Document_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Document p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ImportStart (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_ImportStart_Lcom_radaee_pdf_Document_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='ImportStart' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Document']]"
		[Register ("ImportStart", "(Lcom/radaee/pdf/Document;)Lcom/radaee/pdf/Document$ImportContext;", "GetImportStart_Lcom_radaee_pdf_Document_Handler")]
		public virtual global::Com.Radaee.Pdf.Document.ImportContext ImportStart (global::Com.Radaee.Pdf.Document p0)
		{
			if (id_ImportStart_Lcom_radaee_pdf_Document_ == IntPtr.Zero)
				id_ImportStart_Lcom_radaee_pdf_Document_ = JNIEnv.GetMethodID (class_ref, "ImportStart", "(Lcom/radaee/pdf/Document;)Lcom/radaee/pdf/Document$ImportContext;");

			global::Com.Radaee.Pdf.Document.ImportContext __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.ImportContext> (JNIEnv.CallObjectMethod  (Handle, id_ImportStart_Lcom_radaee_pdf_Document_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.ImportContext> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ImportStart", "(Lcom/radaee/pdf/Document;)Lcom/radaee/pdf/Document$ImportContext;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_MovePage_II;
#pragma warning disable 0169
		static Delegate GetMovePage_IIHandler ()
		{
			if (cb_MovePage_II == null)
				cb_MovePage_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool>) n_MovePage_II);
			return cb_MovePage_II;
		}

		static bool n_MovePage_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MovePage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_MovePage_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='MovePage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("MovePage", "(II)Z", "GetMovePage_IIHandler")]
		public virtual bool MovePage (int p0, int p1)
		{
			if (id_MovePage_II == IntPtr.Zero)
				id_MovePage_II = JNIEnv.GetMethodID (class_ref, "MovePage", "(II)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_MovePage_II, new JValue (p0), new JValue (p1));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "MovePage", "(II)Z"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_NewFontCID_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetNewFontCID_Ljava_lang_String_IHandler ()
		{
			if (cb_NewFontCID_Ljava_lang_String_I == null)
				cb_NewFontCID_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_NewFontCID_Ljava_lang_String_I);
			return cb_NewFontCID_Ljava_lang_String_I;
		}

		static IntPtr n_NewFontCID_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewFontCID (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_NewFontCID_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='NewFontCID' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("NewFontCID", "(Ljava/lang/String;I)Lcom/radaee/pdf/Document$DocFont;", "GetNewFontCID_Ljava_lang_String_IHandler")]
		public virtual global::Com.Radaee.Pdf.Document.DocFont NewFontCID (string p0, int p1)
		{
			if (id_NewFontCID_Ljava_lang_String_I == IntPtr.Zero)
				id_NewFontCID_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "NewFontCID", "(Ljava/lang/String;I)Lcom/radaee/pdf/Document$DocFont;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Radaee.Pdf.Document.DocFont __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.DocFont> (JNIEnv.CallObjectMethod  (Handle, id_NewFontCID_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.DocFont> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "NewFontCID", "(Ljava/lang/String;I)Lcom/radaee/pdf/Document$DocFont;"), new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_NewGState;
#pragma warning disable 0169
		static Delegate GetNewGStateHandler ()
		{
			if (cb_NewGState == null)
				cb_NewGState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NewGState);
			return cb_NewGState;
		}

		static IntPtr n_NewGState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewGState ());
		}
#pragma warning restore 0169

		static IntPtr id_NewGState;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='NewGState' and count(parameter)=0]"
		[Register ("NewGState", "()Lcom/radaee/pdf/Document$DocGState;", "GetNewGStateHandler")]
		public virtual global::Com.Radaee.Pdf.Document.DocGState NewGState ()
		{
			if (id_NewGState == IntPtr.Zero)
				id_NewGState = JNIEnv.GetMethodID (class_ref, "NewGState", "()Lcom/radaee/pdf/Document$DocGState;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.DocGState> (JNIEnv.CallObjectMethod  (Handle, id_NewGState), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.DocGState> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "NewGState", "()Lcom/radaee/pdf/Document$DocGState;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_NewImage_Landroid_graphics_Bitmap_Z;
#pragma warning disable 0169
		static Delegate GetNewImage_Landroid_graphics_Bitmap_ZHandler ()
		{
			if (cb_NewImage_Landroid_graphics_Bitmap_Z == null)
				cb_NewImage_Landroid_graphics_Bitmap_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_NewImage_Landroid_graphics_Bitmap_Z);
			return cb_NewImage_Landroid_graphics_Bitmap_Z;
		}

		static IntPtr n_NewImage_Landroid_graphics_Bitmap_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewImage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_NewImage_Landroid_graphics_Bitmap_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='NewImage' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='boolean']]"
		[Register ("NewImage", "(Landroid/graphics/Bitmap;Z)Lcom/radaee/pdf/Document$DocImage;", "GetNewImage_Landroid_graphics_Bitmap_ZHandler")]
		public virtual global::Com.Radaee.Pdf.Document.DocImage NewImage (global::Android.Graphics.Bitmap p0, bool p1)
		{
			if (id_NewImage_Landroid_graphics_Bitmap_Z == IntPtr.Zero)
				id_NewImage_Landroid_graphics_Bitmap_Z = JNIEnv.GetMethodID (class_ref, "NewImage", "(Landroid/graphics/Bitmap;Z)Lcom/radaee/pdf/Document$DocImage;");

			global::Com.Radaee.Pdf.Document.DocImage __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.DocImage> (JNIEnv.CallObjectMethod  (Handle, id_NewImage_Landroid_graphics_Bitmap_Z, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.DocImage> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "NewImage", "(Landroid/graphics/Bitmap;Z)Lcom/radaee/pdf/Document$DocImage;"), new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_NewImageJPEG_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNewImageJPEG_Ljava_lang_String_Handler ()
		{
			if (cb_NewImageJPEG_Ljava_lang_String_ == null)
				cb_NewImageJPEG_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewImageJPEG_Ljava_lang_String_);
			return cb_NewImageJPEG_Ljava_lang_String_;
		}

		static IntPtr n_NewImageJPEG_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewImageJPEG (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_NewImageJPEG_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='NewImageJPEG' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("NewImageJPEG", "(Ljava/lang/String;)Lcom/radaee/pdf/Document$DocImage;", "GetNewImageJPEG_Ljava_lang_String_Handler")]
		public virtual global::Com.Radaee.Pdf.Document.DocImage NewImageJPEG (string p0)
		{
			if (id_NewImageJPEG_Ljava_lang_String_ == IntPtr.Zero)
				id_NewImageJPEG_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "NewImageJPEG", "(Ljava/lang/String;)Lcom/radaee/pdf/Document$DocImage;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Radaee.Pdf.Document.DocImage __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.DocImage> (JNIEnv.CallObjectMethod  (Handle, id_NewImageJPEG_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.DocImage> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "NewImageJPEG", "(Ljava/lang/String;)Lcom/radaee/pdf/Document$DocImage;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_NewImageJPX_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNewImageJPX_Ljava_lang_String_Handler ()
		{
			if (cb_NewImageJPX_Ljava_lang_String_ == null)
				cb_NewImageJPX_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewImageJPX_Ljava_lang_String_);
			return cb_NewImageJPX_Ljava_lang_String_;
		}

		static IntPtr n_NewImageJPX_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewImageJPX (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_NewImageJPX_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='NewImageJPX' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("NewImageJPX", "(Ljava/lang/String;)Lcom/radaee/pdf/Document$DocImage;", "GetNewImageJPX_Ljava_lang_String_Handler")]
		public virtual global::Com.Radaee.Pdf.Document.DocImage NewImageJPX (string p0)
		{
			if (id_NewImageJPX_Ljava_lang_String_ == IntPtr.Zero)
				id_NewImageJPX_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "NewImageJPX", "(Ljava/lang/String;)Lcom/radaee/pdf/Document$DocImage;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Radaee.Pdf.Document.DocImage __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.DocImage> (JNIEnv.CallObjectMethod  (Handle, id_NewImageJPX_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.DocImage> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "NewImageJPX", "(Ljava/lang/String;)Lcom/radaee/pdf/Document$DocImage;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_NewPage_IFF;
#pragma warning disable 0169
		static Delegate GetNewPage_IFFHandler ()
		{
			if (cb_NewPage_IFF == null)
				cb_NewPage_IFF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, float, float, IntPtr>) n_NewPage_IFF);
			return cb_NewPage_IFF;
		}

		static IntPtr n_NewPage_IFF (IntPtr jnienv, IntPtr native__this, int p0, float p1, float p2)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewPage (p0, p1, p2));
		}
#pragma warning restore 0169

		static IntPtr id_NewPage_IFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='NewPage' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("NewPage", "(IFF)Lcom/radaee/pdf/Page;", "GetNewPage_IFFHandler")]
		public virtual global::Com.Radaee.Pdf.Page NewPage (int p0, float p1, float p2)
		{
			if (id_NewPage_IFF == IntPtr.Zero)
				id_NewPage_IFF = JNIEnv.GetMethodID (class_ref, "NewPage", "(IFF)Lcom/radaee/pdf/Page;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (JNIEnv.CallObjectMethod  (Handle, id_NewPage_IFF, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "NewPage", "(IFF)Lcom/radaee/pdf/Page;"), new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_NewRootOutline_Ljava_lang_String_IF;
#pragma warning disable 0169
		static Delegate GetNewRootOutline_Ljava_lang_String_IFHandler ()
		{
			if (cb_NewRootOutline_Ljava_lang_String_IF == null)
				cb_NewRootOutline_Ljava_lang_String_IF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, float, bool>) n_NewRootOutline_Ljava_lang_String_IF);
			return cb_NewRootOutline_Ljava_lang_String_IF;
		}

		static bool n_NewRootOutline_Ljava_lang_String_IF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, float p2)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.NewRootOutline (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_NewRootOutline_Ljava_lang_String_IF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='NewRootOutline' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='float']]"
		[Register ("NewRootOutline", "(Ljava/lang/String;IF)Z", "GetNewRootOutline_Ljava_lang_String_IFHandler")]
		public virtual bool NewRootOutline (string p0, int p1, float p2)
		{
			if (id_NewRootOutline_Ljava_lang_String_IF == IntPtr.Zero)
				id_NewRootOutline_Ljava_lang_String_IF = JNIEnv.GetMethodID (class_ref, "NewRootOutline", "(Ljava/lang/String;IF)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_NewRootOutline_Ljava_lang_String_IF, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "NewRootOutline", "(Ljava/lang/String;IF)Z"), new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_Open_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpen_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_Open_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_Open_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Open_Ljava_lang_String_Ljava_lang_String_);
			return cb_Open_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_Open_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Open (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_Open_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='Open' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("Open", "(Ljava/lang/String;Ljava/lang/String;)I", "GetOpen_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual int Open (string p0, string p1)
		{
			if (id_Open_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_Open_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "Open", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_Open_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Open", "(Ljava/lang/String;Ljava/lang/String;)I"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_OpenMem_arrayBLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpenMem_arrayBLjava_lang_String_Handler ()
		{
			if (cb_OpenMem_arrayBLjava_lang_String_ == null)
				cb_OpenMem_arrayBLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_OpenMem_arrayBLjava_lang_String_);
			return cb_OpenMem_arrayBLjava_lang_String_;
		}

		static int n_OpenMem_arrayBLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.OpenMem (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_OpenMem_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='OpenMem' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("OpenMem", "([BLjava/lang/String;)I", "GetOpenMem_arrayBLjava_lang_String_Handler")]
		public virtual int OpenMem (byte[] p0, string p1)
		{
			if (id_OpenMem_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_OpenMem_arrayBLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "OpenMem", "([BLjava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_OpenMem_arrayBLjava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OpenMem", "([BLjava/lang/String;)I"), new JValue (native_p0), new JValue (native_p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_OpenStream_Lcom_radaee_pdf_Document_PDFStream_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpenStream_Lcom_radaee_pdf_Document_PDFStream_Ljava_lang_String_Handler ()
		{
			if (cb_OpenStream_Lcom_radaee_pdf_Document_PDFStream_Ljava_lang_String_ == null)
				cb_OpenStream_Lcom_radaee_pdf_Document_PDFStream_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_OpenStream_Lcom_radaee_pdf_Document_PDFStream_Ljava_lang_String_);
			return cb_OpenStream_Lcom_radaee_pdf_Document_PDFStream_Ljava_lang_String_;
		}

		static int n_OpenStream_Lcom_radaee_pdf_Document_PDFStream_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Document.IPDFStream p0 = (global::Com.Radaee.Pdf.Document.IPDFStream)global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.IPDFStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.OpenStream (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_OpenStream_Lcom_radaee_pdf_Document_PDFStream_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='OpenStream' and count(parameter)=2 and parameter[1][@type='com.radaee.pdf.Document.PDFStream'] and parameter[2][@type='java.lang.String']]"
		[Register ("OpenStream", "(Lcom/radaee/pdf/Document$PDFStream;Ljava/lang/String;)I", "GetOpenStream_Lcom_radaee_pdf_Document_PDFStream_Ljava_lang_String_Handler")]
		public virtual int OpenStream (global::Com.Radaee.Pdf.Document.IPDFStream p0, string p1)
		{
			if (id_OpenStream_Lcom_radaee_pdf_Document_PDFStream_Ljava_lang_String_ == IntPtr.Zero)
				id_OpenStream_Lcom_radaee_pdf_Document_PDFStream_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "OpenStream", "(Lcom/radaee/pdf/Document$PDFStream;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_OpenStream_Lcom_radaee_pdf_Document_PDFStream_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OpenStream", "(Lcom/radaee/pdf/Document$PDFStream;Ljava/lang/String;)I"), new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_RemovePage_I;
#pragma warning disable 0169
		static Delegate GetRemovePage_IHandler ()
		{
			if (cb_RemovePage_I == null)
				cb_RemovePage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_RemovePage_I);
			return cb_RemovePage_I;
		}

		static bool n_RemovePage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemovePage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_RemovePage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='RemovePage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("RemovePage", "(I)Z", "GetRemovePage_IHandler")]
		public virtual bool RemovePage (int p0)
		{
			if (id_RemovePage_I == IntPtr.Zero)
				id_RemovePage_I = JNIEnv.GetMethodID (class_ref, "RemovePage", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_RemovePage_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RemovePage", "(I)Z"), new JValue (p0));
		}

		static Delegate cb_Save;
#pragma warning disable 0169
		static Delegate GetSaveHandler ()
		{
			if (cb_Save == null)
				cb_Save = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Save);
			return cb_Save;
		}

		static bool n_Save (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Save ();
		}
#pragma warning restore 0169

		static IntPtr id_Save;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='Save' and count(parameter)=0]"
		[Register ("Save", "()Z", "GetSaveHandler")]
		public virtual bool Save ()
		{
			if (id_Save == IntPtr.Zero)
				id_Save = JNIEnv.GetMethodID (class_ref, "Save", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_Save);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Save", "()Z"));
		}

		static Delegate cb_SaveAs_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSaveAs_Ljava_lang_String_ZHandler ()
		{
			if (cb_SaveAs_Ljava_lang_String_Z == null)
				cb_SaveAs_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, bool>) n_SaveAs_Ljava_lang_String_Z);
			return cb_SaveAs_Ljava_lang_String_Z;
		}

		static bool n_SaveAs_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SaveAs (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SaveAs_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='SaveAs' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("SaveAs", "(Ljava/lang/String;Z)Z", "GetSaveAs_Ljava_lang_String_ZHandler")]
		public virtual bool SaveAs (string p0, bool p1)
		{
			if (id_SaveAs_Ljava_lang_String_Z == IntPtr.Zero)
				id_SaveAs_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "SaveAs", "(Ljava/lang/String;Z)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_SaveAs_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SaveAs", "(Ljava/lang/String;Z)Z"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_SetCache_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCache_Ljava_lang_String_Handler ()
		{
			if (cb_SetCache_Ljava_lang_String_ == null)
				cb_SetCache_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetCache_Ljava_lang_String_);
			return cb_SetCache_Ljava_lang_String_;
		}

		static bool n_SetCache_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetCache (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetCache_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='SetCache' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SetCache", "(Ljava/lang/String;)Z", "GetSetCache_Ljava_lang_String_Handler")]
		public virtual bool SetCache (string p0)
		{
			if (id_SetCache_Ljava_lang_String_ == IntPtr.Zero)
				id_SetCache_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetCache", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_SetCache_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetCache", "(Ljava/lang/String;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_SetFontDel_Lcom_radaee_pdf_Document_PDFFontDelegate_;
#pragma warning disable 0169
		static Delegate GetSetFontDel_Lcom_radaee_pdf_Document_PDFFontDelegate_Handler ()
		{
			if (cb_SetFontDel_Lcom_radaee_pdf_Document_PDFFontDelegate_ == null)
				cb_SetFontDel_Lcom_radaee_pdf_Document_PDFFontDelegate_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFontDel_Lcom_radaee_pdf_Document_PDFFontDelegate_);
			return cb_SetFontDel_Lcom_radaee_pdf_Document_PDFFontDelegate_;
		}

		static void n_SetFontDel_Lcom_radaee_pdf_Document_PDFFontDelegate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Document.IPDFFontDelegate p0 = (global::Com.Radaee.Pdf.Document.IPDFFontDelegate)global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document.IPDFFontDelegate> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetFontDel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetFontDel_Lcom_radaee_pdf_Document_PDFFontDelegate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='SetFontDel' and count(parameter)=1 and parameter[1][@type='com.radaee.pdf.Document.PDFFontDelegate']]"
		[Register ("SetFontDel", "(Lcom/radaee/pdf/Document$PDFFontDelegate;)V", "GetSetFontDel_Lcom_radaee_pdf_Document_PDFFontDelegate_Handler")]
		public virtual void SetFontDel (global::Com.Radaee.Pdf.Document.IPDFFontDelegate p0)
		{
			if (id_SetFontDel_Lcom_radaee_pdf_Document_PDFFontDelegate_ == IntPtr.Zero)
				id_SetFontDel_Lcom_radaee_pdf_Document_PDFFontDelegate_ = JNIEnv.GetMethodID (class_ref, "SetFontDel", "(Lcom/radaee/pdf/Document$PDFFontDelegate;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_SetFontDel_Lcom_radaee_pdf_Document_PDFFontDelegate_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetFontDel", "(Lcom/radaee/pdf/Document$PDFFontDelegate;)V"), new JValue (p0));
		}

		static Delegate cb_SetMeta_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMeta_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_SetMeta_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_SetMeta_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_SetMeta_Ljava_lang_String_Ljava_lang_String_);
			return cb_SetMeta_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_SetMeta_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetMeta (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetMeta_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='SetMeta' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("SetMeta", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetSetMeta_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual bool SetMeta (string p0, string p1)
		{
			if (id_SetMeta_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_SetMeta_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "SetMeta", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_SetMeta_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetMeta", "(Ljava/lang/String;Ljava/lang/String;)Z"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_SetPageRotate_II;
#pragma warning disable 0169
		static Delegate GetSetPageRotate_IIHandler ()
		{
			if (cb_SetPageRotate_II == null)
				cb_SetPageRotate_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool>) n_SetPageRotate_II);
			return cb_SetPageRotate_II;
		}

		static bool n_SetPageRotate_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Radaee.Pdf.Document __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetPageRotate (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_SetPageRotate_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.pdf']/class[@name='Document']/method[@name='SetPageRotate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("SetPageRotate", "(II)Z", "GetSetPageRotate_IIHandler")]
		public virtual bool SetPageRotate (int p0, int p1)
		{
			if (id_SetPageRotate_II == IntPtr.Zero)
				id_SetPageRotate_II = JNIEnv.GetMethodID (class_ref, "SetPageRotate", "(II)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_SetPageRotate_II, new JValue (p0), new JValue (p1));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetPageRotate", "(II)Z"), new JValue (p0), new JValue (p1));
		}

	}
}

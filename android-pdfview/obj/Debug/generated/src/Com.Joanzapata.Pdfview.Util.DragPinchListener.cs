using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Joanzapata.Pdfview.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.joanzapata.pdfview.util']/class[@name='DragPinchListener']"
	[global::Android.Runtime.Register ("com/joanzapata/pdfview/util/DragPinchListener", DoNotGenerateAcw=true)]
	public partial class DragPinchListener : global::Java.Lang.Object, global::Android.Views.View.IOnTouchListener {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.joanzapata.pdfview.util']/interface[@name='DragPinchListener.OnDoubleTapListener']"
		[Register ("com/joanzapata/pdfview/util/DragPinchListener$OnDoubleTapListener", "", "Com.Joanzapata.Pdfview.Util.DragPinchListener/IOnDoubleTapListenerInvoker")]
		public partial interface IOnDoubleTapListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.util']/interface[@name='DragPinchListener.OnDoubleTapListener']/method[@name='onDoubleTap' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
			[Register ("onDoubleTap", "(FF)V", "GetOnDoubleTap_FFHandler:Com.Joanzapata.Pdfview.Util.DragPinchListener/IOnDoubleTapListenerInvoker, android-pdfview")]
			void OnDoubleTap (float p0, float p1);

		}

		[global::Android.Runtime.Register ("com/joanzapata/pdfview/util/DragPinchListener$OnDoubleTapListener", DoNotGenerateAcw=true)]
		internal class IOnDoubleTapListenerInvoker : global::Java.Lang.Object, IOnDoubleTapListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/joanzapata/pdfview/util/DragPinchListener$OnDoubleTapListener");
			IntPtr class_ref;

			public static IOnDoubleTapListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnDoubleTapListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.joanzapata.pdfview.util.DragPinchListener.OnDoubleTapListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnDoubleTapListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnDoubleTapListenerInvoker); }
			}

			static Delegate cb_onDoubleTap_FF;
#pragma warning disable 0169
			static Delegate GetOnDoubleTap_FFHandler ()
			{
				if (cb_onDoubleTap_FF == null)
					cb_onDoubleTap_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_OnDoubleTap_FF);
				return cb_onDoubleTap_FF;
			}

			static void n_OnDoubleTap_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
			{
				global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDoubleTapListener __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDoubleTapListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDoubleTap (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onDoubleTap_FF;
			public void OnDoubleTap (float p0, float p1)
			{
				if (id_onDoubleTap_FF == IntPtr.Zero)
					id_onDoubleTap_FF = JNIEnv.GetMethodID (class_ref, "onDoubleTap", "(FF)V");
				JNIEnv.CallVoidMethod (Handle, id_onDoubleTap_FF, new JValue (p0), new JValue (p1));
			}

		}

		public partial class DoubleTapEventArgs : global::System.EventArgs {

			public DoubleTapEventArgs (float p0, float p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			float p0;
			public float P0 {
				get { return p0; }
			}

			float p1;
			public float P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/joanzapata/pdfview/util/DragPinchListener_OnDoubleTapListenerImplementor")]
		internal sealed class IOnDoubleTapListenerImplementor : global::Java.Lang.Object, IOnDoubleTapListener {

			object sender;

			public IOnDoubleTapListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/joanzapata/pdfview/util/DragPinchListener_OnDoubleTapListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DoubleTapEventArgs> Handler;
#pragma warning restore 0649

			public void OnDoubleTap (float p0, float p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new DoubleTapEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnDoubleTapListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.joanzapata.pdfview.util']/interface[@name='DragPinchListener.OnDragListener']"
		[Register ("com/joanzapata/pdfview/util/DragPinchListener$OnDragListener", "", "Com.Joanzapata.Pdfview.Util.DragPinchListener/IOnDragListenerInvoker")]
		public partial interface IOnDragListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.util']/interface[@name='DragPinchListener.OnDragListener']/method[@name='endDrag' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
			[Register ("endDrag", "(FF)V", "GetEndDrag_FFHandler:Com.Joanzapata.Pdfview.Util.DragPinchListener/IOnDragListenerInvoker, android-pdfview")]
			void EndDrag (float p0, float p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.util']/interface[@name='DragPinchListener.OnDragListener']/method[@name='onDrag' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
			[Register ("onDrag", "(FF)V", "GetOnDrag_FFHandler:Com.Joanzapata.Pdfview.Util.DragPinchListener/IOnDragListenerInvoker, android-pdfview")]
			void OnDrag (float p0, float p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.util']/interface[@name='DragPinchListener.OnDragListener']/method[@name='startDrag' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
			[Register ("startDrag", "(FF)V", "GetStartDrag_FFHandler:Com.Joanzapata.Pdfview.Util.DragPinchListener/IOnDragListenerInvoker, android-pdfview")]
			void StartDrag (float p0, float p1);

		}

		[global::Android.Runtime.Register ("com/joanzapata/pdfview/util/DragPinchListener$OnDragListener", DoNotGenerateAcw=true)]
		internal class IOnDragListenerInvoker : global::Java.Lang.Object, IOnDragListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/joanzapata/pdfview/util/DragPinchListener$OnDragListener");
			IntPtr class_ref;

			public static IOnDragListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnDragListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.joanzapata.pdfview.util.DragPinchListener.OnDragListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnDragListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnDragListenerInvoker); }
			}

			static Delegate cb_endDrag_FF;
#pragma warning disable 0169
			static Delegate GetEndDrag_FFHandler ()
			{
				if (cb_endDrag_FF == null)
					cb_endDrag_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_EndDrag_FF);
				return cb_endDrag_FF;
			}

			static void n_EndDrag_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
			{
				global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListener __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.EndDrag (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_endDrag_FF;
			public void EndDrag (float p0, float p1)
			{
				if (id_endDrag_FF == IntPtr.Zero)
					id_endDrag_FF = JNIEnv.GetMethodID (class_ref, "endDrag", "(FF)V");
				JNIEnv.CallVoidMethod (Handle, id_endDrag_FF, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_onDrag_FF;
#pragma warning disable 0169
			static Delegate GetOnDrag_FFHandler ()
			{
				if (cb_onDrag_FF == null)
					cb_onDrag_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_OnDrag_FF);
				return cb_onDrag_FF;
			}

			static void n_OnDrag_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
			{
				global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListener __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDrag (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onDrag_FF;
			public void OnDrag (float p0, float p1)
			{
				if (id_onDrag_FF == IntPtr.Zero)
					id_onDrag_FF = JNIEnv.GetMethodID (class_ref, "onDrag", "(FF)V");
				JNIEnv.CallVoidMethod (Handle, id_onDrag_FF, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_startDrag_FF;
#pragma warning disable 0169
			static Delegate GetStartDrag_FFHandler ()
			{
				if (cb_startDrag_FF == null)
					cb_startDrag_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_StartDrag_FF);
				return cb_startDrag_FF;
			}

			static void n_StartDrag_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
			{
				global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListener __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.StartDrag (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_startDrag_FF;
			public void StartDrag (float p0, float p1)
			{
				if (id_startDrag_FF == IntPtr.Zero)
					id_startDrag_FF = JNIEnv.GetMethodID (class_ref, "startDrag", "(FF)V");
				JNIEnv.CallVoidMethod (Handle, id_startDrag_FF, new JValue (p0), new JValue (p1));
			}

		}

		public partial class EndDragEventArgs : global::System.EventArgs {

			public EndDragEventArgs (float p0, float p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			float p0;
			public float P0 {
				get { return p0; }
			}

			float p1;
			public float P1 {
				get { return p1; }
			}
		}

		public partial class DragEventArgs : global::System.EventArgs {

			public DragEventArgs (float p0, float p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			float p0;
			public float P0 {
				get { return p0; }
			}

			float p1;
			public float P1 {
				get { return p1; }
			}
		}

		public partial class StartDragEventArgs : global::System.EventArgs {

			public StartDragEventArgs (float p0, float p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			float p0;
			public float P0 {
				get { return p0; }
			}

			float p1;
			public float P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/joanzapata/pdfview/util/DragPinchListener_OnDragListenerImplementor")]
		internal sealed class IOnDragListenerImplementor : global::Java.Lang.Object, IOnDragListener {

			object sender;

			public IOnDragListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/joanzapata/pdfview/util/DragPinchListener_OnDragListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<EndDragEventArgs> EndDragHandler;
#pragma warning restore 0649

			public void EndDrag (float p0, float p1)
			{
				var __h = EndDragHandler;
				if (__h != null)
					__h (sender, new EndDragEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<DragEventArgs> OnDragHandler;
#pragma warning restore 0649

			public void OnDrag (float p0, float p1)
			{
				var __h = OnDragHandler;
				if (__h != null)
					__h (sender, new DragEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<StartDragEventArgs> StartDragHandler;
#pragma warning restore 0649

			public void StartDrag (float p0, float p1)
			{
				var __h = StartDragHandler;
				if (__h != null)
					__h (sender, new StartDragEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnDragListenerImplementor value)
			{
				return value.EndDragHandler == null && value.OnDragHandler == null && value.StartDragHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.joanzapata.pdfview.util']/interface[@name='DragPinchListener.OnPinchListener']"
		[Register ("com/joanzapata/pdfview/util/DragPinchListener$OnPinchListener", "", "Com.Joanzapata.Pdfview.Util.DragPinchListener/IOnPinchListenerInvoker")]
		public partial interface IOnPinchListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.util']/interface[@name='DragPinchListener.OnPinchListener']/method[@name='onPinch' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='android.graphics.PointF']]"
			[Register ("onPinch", "(FLandroid/graphics/PointF;)V", "GetOnPinch_FLandroid_graphics_PointF_Handler:Com.Joanzapata.Pdfview.Util.DragPinchListener/IOnPinchListenerInvoker, android-pdfview")]
			void OnPinch (float p0, global::Android.Graphics.PointF p1);

		}

		[global::Android.Runtime.Register ("com/joanzapata/pdfview/util/DragPinchListener$OnPinchListener", DoNotGenerateAcw=true)]
		internal class IOnPinchListenerInvoker : global::Java.Lang.Object, IOnPinchListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/joanzapata/pdfview/util/DragPinchListener$OnPinchListener");
			IntPtr class_ref;

			public static IOnPinchListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnPinchListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.joanzapata.pdfview.util.DragPinchListener.OnPinchListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnPinchListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnPinchListenerInvoker); }
			}

			static Delegate cb_onPinch_FLandroid_graphics_PointF_;
#pragma warning disable 0169
			static Delegate GetOnPinch_FLandroid_graphics_PointF_Handler ()
			{
				if (cb_onPinch_FLandroid_graphics_PointF_ == null)
					cb_onPinch_FLandroid_graphics_PointF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, IntPtr>) n_OnPinch_FLandroid_graphics_PointF_);
				return cb_onPinch_FLandroid_graphics_PointF_;
			}

			static void n_OnPinch_FLandroid_graphics_PointF_ (IntPtr jnienv, IntPtr native__this, float p0, IntPtr native_p1)
			{
				global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnPinchListener __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnPinchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.PointF p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnPinch (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onPinch_FLandroid_graphics_PointF_;
			public void OnPinch (float p0, global::Android.Graphics.PointF p1)
			{
				if (id_onPinch_FLandroid_graphics_PointF_ == IntPtr.Zero)
					id_onPinch_FLandroid_graphics_PointF_ = JNIEnv.GetMethodID (class_ref, "onPinch", "(FLandroid/graphics/PointF;)V");
				JNIEnv.CallVoidMethod (Handle, id_onPinch_FLandroid_graphics_PointF_, new JValue (p0), new JValue (p1));
			}

		}

		public partial class PinchEventArgs : global::System.EventArgs {

			public PinchEventArgs (float p0, global::Android.Graphics.PointF p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			float p0;
			public float P0 {
				get { return p0; }
			}

			global::Android.Graphics.PointF p1;
			public global::Android.Graphics.PointF P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/joanzapata/pdfview/util/DragPinchListener_OnPinchListenerImplementor")]
		internal sealed class IOnPinchListenerImplementor : global::Java.Lang.Object, IOnPinchListener {

			object sender;

			public IOnPinchListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/joanzapata/pdfview/util/DragPinchListener_OnPinchListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<PinchEventArgs> Handler;
#pragma warning restore 0649

			public void OnPinch (float p0, global::Android.Graphics.PointF p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new PinchEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnPinchListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.joanzapata.pdfview.util']/class[@name='DragPinchListener.State']"
		[global::Android.Runtime.Register ("com/joanzapata/pdfview/util/DragPinchListener$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {


			static IntPtr DRAG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.joanzapata.pdfview.util']/class[@name='DragPinchListener.State']/field[@name='DRAG']"
			[Register ("DRAG")]
			public static global::Com.Joanzapata.Pdfview.Util.DragPinchListener.State Drag {
				get {
					if (DRAG_jfieldId == IntPtr.Zero)
						DRAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DRAG", "Lcom/joanzapata/pdfview/util/DragPinchListener$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DRAG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DRAG_jfieldId == IntPtr.Zero)
						DRAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DRAG", "Lcom/joanzapata/pdfview/util/DragPinchListener$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DRAG_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr NONE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.joanzapata.pdfview.util']/class[@name='DragPinchListener.State']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Com.Joanzapata.Pdfview.Util.DragPinchListener.State None {
				get {
					if (NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/joanzapata/pdfview/util/DragPinchListener$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/joanzapata/pdfview/util/DragPinchListener$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NONE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr ZOOM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.joanzapata.pdfview.util']/class[@name='DragPinchListener.State']/field[@name='ZOOM']"
			[Register ("ZOOM")]
			public static global::Com.Joanzapata.Pdfview.Util.DragPinchListener.State Zoom {
				get {
					if (ZOOM_jfieldId == IntPtr.Zero)
						ZOOM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ZOOM", "Lcom/joanzapata/pdfview/util/DragPinchListener$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ZOOM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ZOOM_jfieldId == IntPtr.Zero)
						ZOOM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ZOOM", "Lcom/joanzapata/pdfview/util/DragPinchListener$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ZOOM_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/joanzapata/pdfview/util/DragPinchListener$State", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (State); }
			}

			internal State (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/joanzapata/pdfview/util/DragPinchListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DragPinchListener); }
		}

		protected DragPinchListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.joanzapata.pdfview.util']/class[@name='DragPinchListener']/constructor[@name='DragPinchListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DragPinchListener () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DragPinchListener)) {
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

		static Delegate cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == null)
				cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_);
			return cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Joanzapata.Pdfview.Util.DragPinchListener __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Util.DragPinchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouch (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.util']/class[@name='DragPinchListener']/method[@name='onTouch' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.MotionEvent']]"
		[Register ("onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
		public virtual bool OnTouch (global::Android.Views.View p0, global::Android.Views.MotionEvent p1)
		{
			if (id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z"), new JValue (p0), new JValue (p1));
			return __ret;
		}

		static Delegate cb_setOnDoubleTapListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnDoubleTapListener_;
#pragma warning disable 0169
		static Delegate GetSetOnDoubleTapListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnDoubleTapListener_Handler ()
		{
			if (cb_setOnDoubleTapListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnDoubleTapListener_ == null)
				cb_setOnDoubleTapListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnDoubleTapListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnDoubleTapListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnDoubleTapListener_);
			return cb_setOnDoubleTapListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnDoubleTapListener_;
		}

		static void n_SetOnDoubleTapListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnDoubleTapListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Joanzapata.Pdfview.Util.DragPinchListener __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Util.DragPinchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDoubleTapListener p0 = (global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDoubleTapListener)global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDoubleTapListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnDoubleTapListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnDoubleTapListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnDoubleTapListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.util']/class[@name='DragPinchListener']/method[@name='setOnDoubleTapListener' and count(parameter)=1 and parameter[1][@type='com.joanzapata.pdfview.util.DragPinchListener.OnDoubleTapListener']]"
		[Register ("setOnDoubleTapListener", "(Lcom/joanzapata/pdfview/util/DragPinchListener$OnDoubleTapListener;)V", "GetSetOnDoubleTapListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnDoubleTapListener_Handler")]
		public virtual void SetOnDoubleTapListener (global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDoubleTapListener p0)
		{
			if (id_setOnDoubleTapListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnDoubleTapListener_ == IntPtr.Zero)
				id_setOnDoubleTapListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnDoubleTapListener_ = JNIEnv.GetMethodID (class_ref, "setOnDoubleTapListener", "(Lcom/joanzapata/pdfview/util/DragPinchListener$OnDoubleTapListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnDoubleTapListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnDoubleTapListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnDoubleTapListener", "(Lcom/joanzapata/pdfview/util/DragPinchListener$OnDoubleTapListener;)V"), new JValue (p0));
		}

		static Delegate cb_setOnDragListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnDragListener_;
#pragma warning disable 0169
		static Delegate GetSetOnDragListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnDragListener_Handler ()
		{
			if (cb_setOnDragListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnDragListener_ == null)
				cb_setOnDragListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnDragListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnDragListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnDragListener_);
			return cb_setOnDragListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnDragListener_;
		}

		static void n_SetOnDragListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnDragListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Joanzapata.Pdfview.Util.DragPinchListener __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Util.DragPinchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListener p0 = (global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListener)global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnDragListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnDragListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnDragListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.util']/class[@name='DragPinchListener']/method[@name='setOnDragListener' and count(parameter)=1 and parameter[1][@type='com.joanzapata.pdfview.util.DragPinchListener.OnDragListener']]"
		[Register ("setOnDragListener", "(Lcom/joanzapata/pdfview/util/DragPinchListener$OnDragListener;)V", "GetSetOnDragListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnDragListener_Handler")]
		public virtual void SetOnDragListener (global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListener p0)
		{
			if (id_setOnDragListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnDragListener_ == IntPtr.Zero)
				id_setOnDragListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnDragListener_ = JNIEnv.GetMethodID (class_ref, "setOnDragListener", "(Lcom/joanzapata/pdfview/util/DragPinchListener$OnDragListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnDragListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnDragListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnDragListener", "(Lcom/joanzapata/pdfview/util/DragPinchListener$OnDragListener;)V"), new JValue (p0));
		}

		static Delegate cb_setOnPinchListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnPinchListener_;
#pragma warning disable 0169
		static Delegate GetSetOnPinchListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnPinchListener_Handler ()
		{
			if (cb_setOnPinchListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnPinchListener_ == null)
				cb_setOnPinchListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnPinchListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnPinchListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnPinchListener_);
			return cb_setOnPinchListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnPinchListener_;
		}

		static void n_SetOnPinchListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnPinchListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Joanzapata.Pdfview.Util.DragPinchListener __this = global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Util.DragPinchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnPinchListener p0 = (global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnPinchListener)global::Java.Lang.Object.GetObject<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnPinchListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnPinchListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnPinchListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnPinchListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.joanzapata.pdfview.util']/class[@name='DragPinchListener']/method[@name='setOnPinchListener' and count(parameter)=1 and parameter[1][@type='com.joanzapata.pdfview.util.DragPinchListener.OnPinchListener']]"
		[Register ("setOnPinchListener", "(Lcom/joanzapata/pdfview/util/DragPinchListener$OnPinchListener;)V", "GetSetOnPinchListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnPinchListener_Handler")]
		public virtual void SetOnPinchListener (global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnPinchListener p0)
		{
			if (id_setOnPinchListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnPinchListener_ == IntPtr.Zero)
				id_setOnPinchListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnPinchListener_ = JNIEnv.GetMethodID (class_ref, "setOnPinchListener", "(Lcom/joanzapata/pdfview/util/DragPinchListener$OnPinchListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnPinchListener_Lcom_joanzapata_pdfview_util_DragPinchListener_OnPinchListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnPinchListener", "(Lcom/joanzapata/pdfview/util/DragPinchListener$OnPinchListener;)V"), new JValue (p0));
		}

#region "Event implementation for Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDoubleTapListener"
		public event EventHandler<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.DoubleTapEventArgs> DoubleTap {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDoubleTapListener, global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDoubleTapListenerImplementor>(
						ref weak_implementor_SetOnDoubleTapListener,
						__CreateIOnDoubleTapListenerImplementor,
						SetOnDoubleTapListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDoubleTapListener, global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDoubleTapListenerImplementor>(
						ref weak_implementor_SetOnDoubleTapListener,
						global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDoubleTapListenerImplementor.__IsEmpty,
						__v => SetOnDoubleTapListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnDoubleTapListener;

		global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDoubleTapListenerImplementor __CreateIOnDoubleTapListenerImplementor ()
		{
			return new global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDoubleTapListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListener"
		public event EventHandler<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.EndDragEventArgs> EndDrag {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListener, global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListenerImplementor>(
						ref weak_implementor_SetOnDragListener,
						__CreateIOnDragListenerImplementor,
						SetOnDragListener,
						__h => __h.EndDragHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListener, global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListenerImplementor>(
						ref weak_implementor_SetOnDragListener,
						global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListenerImplementor.__IsEmpty,
						__v => SetOnDragListener (null),
						__h => __h.EndDragHandler -= value);
			}
		}

		public event EventHandler<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.DragEventArgs> Drag {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListener, global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListenerImplementor>(
						ref weak_implementor_SetOnDragListener,
						__CreateIOnDragListenerImplementor,
						SetOnDragListener,
						__h => __h.OnDragHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListener, global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListenerImplementor>(
						ref weak_implementor_SetOnDragListener,
						global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListenerImplementor.__IsEmpty,
						__v => SetOnDragListener (null),
						__h => __h.OnDragHandler -= value);
			}
		}

		public event EventHandler<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.StartDragEventArgs> StartDrag {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListener, global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListenerImplementor>(
						ref weak_implementor_SetOnDragListener,
						__CreateIOnDragListenerImplementor,
						SetOnDragListener,
						__h => __h.StartDragHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListener, global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListenerImplementor>(
						ref weak_implementor_SetOnDragListener,
						global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListenerImplementor.__IsEmpty,
						__v => SetOnDragListener (null),
						__h => __h.StartDragHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnDragListener;

		global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListenerImplementor __CreateIOnDragListenerImplementor ()
		{
			return new global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnDragListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnPinchListener"
		public event EventHandler<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.PinchEventArgs> Pinch {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnPinchListener, global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnPinchListenerImplementor>(
						ref weak_implementor_SetOnPinchListener,
						__CreateIOnPinchListenerImplementor,
						SetOnPinchListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnPinchListener, global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnPinchListenerImplementor>(
						ref weak_implementor_SetOnPinchListener,
						global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnPinchListenerImplementor.__IsEmpty,
						__v => SetOnPinchListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnPinchListener;

		global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnPinchListenerImplementor __CreateIOnPinchListenerImplementor ()
		{
			return new global::Com.Joanzapata.Pdfview.Util.DragPinchListener.IOnPinchListenerImplementor (this);
		}
#endregion
	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='IO']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/IO", DoNotGenerateAcw=true)]
	public partial class IO : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/IO", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IO); }
		}

		protected IO (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='IO']/constructor[@name='IO' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public IO () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (IO)) {
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
			global::Com.Jcraft.Jsch.IO __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='IO']/method[@name='close' and count(parameter)=0]"
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

		static Delegate cb_put_Lcom_jcraft_jsch_Packet_;
#pragma warning disable 0169
		static Delegate GetPut_Lcom_jcraft_jsch_Packet_Handler ()
		{
			if (cb_put_Lcom_jcraft_jsch_Packet_ == null)
				cb_put_Lcom_jcraft_jsch_Packet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Put_Lcom_jcraft_jsch_Packet_);
			return cb_put_Lcom_jcraft_jsch_Packet_;
		}

		static void n_Put_Lcom_jcraft_jsch_Packet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.IO __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.Packet p0 = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Packet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0);
		}
#pragma warning restore 0169

		static IntPtr id_put_Lcom_jcraft_jsch_Packet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='IO']/method[@name='put' and count(parameter)=1 and parameter[1][@type='com.jcraft.jsch.Packet']]"
		[Register ("put", "(Lcom/jcraft/jsch/Packet;)V", "GetPut_Lcom_jcraft_jsch_Packet_Handler")]
		public virtual void Put (global::Com.Jcraft.Jsch.Packet p0)
		{
			if (id_put_Lcom_jcraft_jsch_Packet_ == IntPtr.Zero)
				id_put_Lcom_jcraft_jsch_Packet_ = JNIEnv.GetMethodID (class_ref, "put", "(Lcom/jcraft/jsch/Packet;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_put_Lcom_jcraft_jsch_Packet_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Lcom/jcraft/jsch/Packet;)V"), new JValue (p0));
		}

	}
}

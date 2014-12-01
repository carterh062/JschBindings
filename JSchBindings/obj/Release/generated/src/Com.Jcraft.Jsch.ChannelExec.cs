using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelExec']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/ChannelExec", DoNotGenerateAcw=true)]
	public partial class ChannelExec : global::Com.Jcraft.Jsch.ChannelSession {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/ChannelExec", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelExec); }
		}

		protected ChannelExec (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelExec']/constructor[@name='ChannelExec' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ChannelExec () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ChannelExec)) {
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

		static Delegate cb_getErrStream;
#pragma warning disable 0169
		static Delegate GetGetErrStreamHandler ()
		{
			if (cb_getErrStream == null)
				cb_getErrStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrStream);
			return cb_getErrStream;
		}

		static IntPtr n_GetErrStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.ChannelExec __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelExec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.ErrStream);
		}
#pragma warning restore 0169

		static Delegate cb_setErrStream_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetSetErrStream_Ljava_io_OutputStream_Handler ()
		{
			if (cb_setErrStream_Ljava_io_OutputStream_ == null)
				cb_setErrStream_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetErrStream_Ljava_io_OutputStream_);
			return cb_setErrStream_Ljava_io_OutputStream_;
		}

		static void n_SetErrStream_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ChannelExec __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelExec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ErrStream = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getErrStream;
		static IntPtr id_setErrStream_Ljava_io_OutputStream_;
		public virtual global::System.IO.Stream ErrStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelExec']/method[@name='getErrStream' and count(parameter)=0]"
			[Register ("getErrStream", "()Ljava/io/InputStream;", "GetGetErrStreamHandler")]
			get {
				if (id_getErrStream == IntPtr.Zero)
					id_getErrStream = JNIEnv.GetMethodID (class_ref, "getErrStream", "()Ljava/io/InputStream;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getErrStream), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrStream", "()Ljava/io/InputStream;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelExec']/method[@name='setErrStream' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
			[Register ("setErrStream", "(Ljava/io/OutputStream;)V", "GetSetErrStream_Ljava_io_OutputStream_Handler")]
			set {
				if (id_setErrStream_Ljava_io_OutputStream_ == IntPtr.Zero)
					id_setErrStream_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "setErrStream", "(Ljava/io/OutputStream;)V");
				IntPtr native_value = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setErrStream_Ljava_io_OutputStream_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setErrStream", "(Ljava/io/OutputStream;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_setCommand_arrayB;
#pragma warning disable 0169
		static Delegate GetSetCommand_arrayBHandler ()
		{
			if (cb_setCommand_arrayB == null)
				cb_setCommand_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCommand_arrayB);
			return cb_setCommand_arrayB;
		}

		static void n_SetCommand_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ChannelExec __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelExec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetCommand (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCommand_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelExec']/method[@name='setCommand' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setCommand", "([B)V", "GetSetCommand_arrayBHandler")]
		public virtual void SetCommand (byte[] p0)
		{
			if (id_setCommand_arrayB == IntPtr.Zero)
				id_setCommand_arrayB = JNIEnv.GetMethodID (class_ref, "setCommand", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setCommand_arrayB, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCommand", "([B)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setCommand_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCommand_Ljava_lang_String_Handler ()
		{
			if (cb_setCommand_Ljava_lang_String_ == null)
				cb_setCommand_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCommand_Ljava_lang_String_);
			return cb_setCommand_Ljava_lang_String_;
		}

		static void n_SetCommand_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ChannelExec __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelExec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCommand (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCommand_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelExec']/method[@name='setCommand' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCommand", "(Ljava/lang/String;)V", "GetSetCommand_Ljava_lang_String_Handler")]
		public virtual void SetCommand (string p0)
		{
			if (id_setCommand_Ljava_lang_String_ == IntPtr.Zero)
				id_setCommand_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCommand", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setCommand_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCommand", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setErrStream_Ljava_io_OutputStream_Z;
#pragma warning disable 0169
		static Delegate GetSetErrStream_Ljava_io_OutputStream_ZHandler ()
		{
			if (cb_setErrStream_Ljava_io_OutputStream_Z == null)
				cb_setErrStream_Ljava_io_OutputStream_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetErrStream_Ljava_io_OutputStream_Z);
			return cb_setErrStream_Ljava_io_OutputStream_Z;
		}

		static void n_SetErrStream_Ljava_io_OutputStream_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Jcraft.Jsch.ChannelExec __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelExec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetErrStream (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setErrStream_Ljava_io_OutputStream_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelExec']/method[@name='setErrStream' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='boolean']]"
		[Register ("setErrStream", "(Ljava/io/OutputStream;Z)V", "GetSetErrStream_Ljava_io_OutputStream_ZHandler")]
		public virtual void SetErrStream (global::System.IO.Stream p0, bool p1)
		{
			if (id_setErrStream_Ljava_io_OutputStream_Z == IntPtr.Zero)
				id_setErrStream_Ljava_io_OutputStream_Z = JNIEnv.GetMethodID (class_ref, "setErrStream", "(Ljava/io/OutputStream;Z)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setErrStream_Ljava_io_OutputStream_Z, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setErrStream", "(Ljava/io/OutputStream;Z)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSubsystem']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/ChannelSubsystem", DoNotGenerateAcw=true)]
	public partial class ChannelSubsystem : global::Com.Jcraft.Jsch.ChannelSession {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/ChannelSubsystem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelSubsystem); }
		}

		protected ChannelSubsystem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSubsystem']/constructor[@name='ChannelSubsystem' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ChannelSubsystem () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ChannelSubsystem)) {
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
			global::Com.Jcraft.Jsch.ChannelSubsystem __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSubsystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Jcraft.Jsch.ChannelSubsystem __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSubsystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ErrStream = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getErrStream;
		static IntPtr id_setErrStream_Ljava_io_OutputStream_;
		public virtual global::System.IO.Stream ErrStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSubsystem']/method[@name='getErrStream' and count(parameter)=0]"
			[Register ("getErrStream", "()Ljava/io/InputStream;", "GetGetErrStreamHandler")]
			get {
				if (id_getErrStream == IntPtr.Zero)
					id_getErrStream = JNIEnv.GetMethodID (class_ref, "getErrStream", "()Ljava/io/InputStream;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getErrStream), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrStream", "()Ljava/io/InputStream;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSubsystem']/method[@name='setErrStream' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
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

		static Delegate cb_setPty_Z;
#pragma warning disable 0169
		static Delegate GetSetPty_ZHandler ()
		{
			if (cb_setPty_Z == null)
				cb_setPty_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPty_Z);
			return cb_setPty_Z;
		}

		static void n_SetPty_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Jcraft.Jsch.ChannelSubsystem __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSubsystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPty (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPty_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSubsystem']/method[@name='setPty' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setPty", "(Z)V", "GetSetPty_ZHandler")]
		public override void SetPty (bool p0)
		{
			if (id_setPty_Z == IntPtr.Zero)
				id_setPty_Z = JNIEnv.GetMethodID (class_ref, "setPty", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPty_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPty", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setSubsystem_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSubsystem_Ljava_lang_String_Handler ()
		{
			if (cb_setSubsystem_Ljava_lang_String_ == null)
				cb_setSubsystem_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSubsystem_Ljava_lang_String_);
			return cb_setSubsystem_Ljava_lang_String_;
		}

		static void n_SetSubsystem_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ChannelSubsystem __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSubsystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSubsystem (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSubsystem_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSubsystem']/method[@name='setSubsystem' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSubsystem", "(Ljava/lang/String;)V", "GetSetSubsystem_Ljava_lang_String_Handler")]
		public virtual void SetSubsystem (string p0)
		{
			if (id_setSubsystem_Ljava_lang_String_ == IntPtr.Zero)
				id_setSubsystem_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSubsystem", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setSubsystem_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSubsystem", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setWantReply_Z;
#pragma warning disable 0169
		static Delegate GetSetWantReply_ZHandler ()
		{
			if (cb_setWantReply_Z == null)
				cb_setWantReply_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetWantReply_Z);
			return cb_setWantReply_Z;
		}

		static void n_SetWantReply_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Jcraft.Jsch.ChannelSubsystem __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSubsystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetWantReply (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setWantReply_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSubsystem']/method[@name='setWantReply' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setWantReply", "(Z)V", "GetSetWantReply_ZHandler")]
		public virtual void SetWantReply (bool p0)
		{
			if (id_setWantReply_Z == IntPtr.Zero)
				id_setWantReply_Z = JNIEnv.GetMethodID (class_ref, "setWantReply", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setWantReply_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWantReply", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setXForwarding_Z;
#pragma warning disable 0169
		static Delegate GetSetXForwarding_ZHandler ()
		{
			if (cb_setXForwarding_Z == null)
				cb_setXForwarding_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetXForwarding_Z);
			return cb_setXForwarding_Z;
		}

		static void n_SetXForwarding_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Jcraft.Jsch.ChannelSubsystem __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSubsystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetXForwarding (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setXForwarding_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSubsystem']/method[@name='setXForwarding' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setXForwarding", "(Z)V", "GetSetXForwarding_ZHandler")]
		public override void SetXForwarding (bool p0)
		{
			if (id_setXForwarding_Z == IntPtr.Zero)
				id_setXForwarding_Z = JNIEnv.GetMethodID (class_ref, "setXForwarding", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setXForwarding_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setXForwarding", "(Z)V"), new JValue (p0));
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/Channel", DoNotGenerateAcw=true)]
	public abstract partial class Channel : global::Java.Lang.Object, global::Java.Lang.IRunnable {


		static IntPtr type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/field[@name='type']"
		[Register ("type")]
		protected IList<byte> Type {
			get {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, type_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, type_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel.MyPipedInputStream']"
		[global::Android.Runtime.Register ("com/jcraft/jsch/Channel$MyPipedInputStream", DoNotGenerateAcw=true)]
		public partial class MyPipedInputStream : global::Java.IO.PipedInputStream {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/jcraft/jsch/Channel$MyPipedInputStream", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MyPipedInputStream); }
			}

			protected MyPipedInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_updateReadSide;
#pragma warning disable 0169
			static Delegate GetUpdateReadSideHandler ()
			{
				if (cb_updateReadSide == null)
					cb_updateReadSide = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateReadSide);
				return cb_updateReadSide;
			}

			static void n_UpdateReadSide (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Jcraft.Jsch.Channel.MyPipedInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel.MyPipedInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.UpdateReadSide ();
			}
#pragma warning restore 0169

			static IntPtr id_updateReadSide;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel.MyPipedInputStream']/method[@name='updateReadSide' and count(parameter)=0]"
			[Register ("updateReadSide", "()V", "GetUpdateReadSideHandler")]
			public virtual void UpdateReadSide ()
			{
				if (id_updateReadSide == IntPtr.Zero)
					id_updateReadSide = JNIEnv.GetMethodID (class_ref, "updateReadSide", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_updateReadSide);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateReadSide", "()V"));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel.PassiveInputStream']"
		[global::Android.Runtime.Register ("com/jcraft/jsch/Channel$PassiveInputStream", DoNotGenerateAcw=true)]
		public partial class PassiveInputStream : global::Com.Jcraft.Jsch.Channel.MyPipedInputStream {

			protected PassiveInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel.PassiveOutputStream']"
		[global::Android.Runtime.Register ("com/jcraft/jsch/Channel$PassiveOutputStream", DoNotGenerateAcw=true)]
		public partial class PassiveOutputStream : global::Java.IO.PipedOutputStream {

			protected PassiveOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/Channel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Channel); }
		}

		protected Channel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getExitStatus;
#pragma warning disable 0169
		static Delegate GetGetExitStatusHandler ()
		{
			if (cb_getExitStatus == null)
				cb_getExitStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetExitStatus);
			return cb_getExitStatus;
		}

		static int n_GetExitStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExitStatus;
		}
#pragma warning restore 0169

		static IntPtr id_getExitStatus;
		public virtual int ExitStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='getExitStatus' and count(parameter)=0]"
			[Register ("getExitStatus", "()I", "GetGetExitStatusHandler")]
			get {
				if (id_getExitStatus == IntPtr.Zero)
					id_getExitStatus = JNIEnv.GetMethodID (class_ref, "getExitStatus", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getExitStatus);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExitStatus", "()I"));
			}
		}

		static Delegate cb_getExtInputStream;
#pragma warning disable 0169
		static Delegate GetGetExtInputStreamHandler ()
		{
			if (cb_getExtInputStream == null)
				cb_getExtInputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtInputStream);
			return cb_getExtInputStream;
		}

		static IntPtr n_GetExtInputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.ExtInputStream);
		}
#pragma warning restore 0169

		static IntPtr id_getExtInputStream;
		public virtual global::System.IO.Stream ExtInputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='getExtInputStream' and count(parameter)=0]"
			[Register ("getExtInputStream", "()Ljava/io/InputStream;", "GetGetExtInputStreamHandler")]
			get {
				if (id_getExtInputStream == IntPtr.Zero)
					id_getExtInputStream = JNIEnv.GetMethodID (class_ref, "getExtInputStream", "()Ljava/io/InputStream;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getExtInputStream), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExtInputStream", "()Ljava/io/InputStream;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetId);
			return cb_getId;
		}

		static int n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Id;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual int Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()I", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getId);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()I"));
			}
		}

		static Delegate cb_getInputStream;
#pragma warning disable 0169
		static Delegate GetGetInputStreamHandler ()
		{
			if (cb_getInputStream == null)
				cb_getInputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputStream);
			return cb_getInputStream;
		}

		static IntPtr n_GetInputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		static Delegate cb_setInputStream_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetSetInputStream_Ljava_io_InputStream_Handler ()
		{
			if (cb_setInputStream_Ljava_io_InputStream_ == null)
				cb_setInputStream_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInputStream_Ljava_io_InputStream_);
			return cb_setInputStream_Ljava_io_InputStream_;
		}

		static void n_SetInputStream_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InputStream = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInputStream;
		static IntPtr id_setInputStream_Ljava_io_InputStream_;
		public virtual global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler")]
			get {
				if (id_getInputStream == IntPtr.Zero)
					id_getInputStream = JNIEnv.GetMethodID (class_ref, "getInputStream", "()Ljava/io/InputStream;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getInputStream), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputStream", "()Ljava/io/InputStream;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='setInputStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
			[Register ("setInputStream", "(Ljava/io/InputStream;)V", "GetSetInputStream_Ljava_io_InputStream_Handler")]
			set {
				if (id_setInputStream_Ljava_io_InputStream_ == IntPtr.Zero)
					id_setInputStream_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "setInputStream", "(Ljava/io/InputStream;)V");
				IntPtr native_value = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setInputStream_Ljava_io_InputStream_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInputStream", "(Ljava/io/InputStream;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_isClosed;
#pragma warning disable 0169
		static Delegate GetIsClosedHandler ()
		{
			if (cb_isClosed == null)
				cb_isClosed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsClosed);
			return cb_isClosed;
		}

		static bool n_IsClosed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClosed;
		}
#pragma warning restore 0169

		static IntPtr id_isClosed;
		public virtual bool IsClosed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='isClosed' and count(parameter)=0]"
			[Register ("isClosed", "()Z", "GetIsClosedHandler")]
			get {
				if (id_isClosed == IntPtr.Zero)
					id_isClosed = JNIEnv.GetMethodID (class_ref, "isClosed", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isClosed);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isClosed", "()Z"));
			}
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		static IntPtr id_isConnected;
		public virtual bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				if (id_isConnected == IntPtr.Zero)
					id_isConnected = JNIEnv.GetMethodID (class_ref, "isConnected", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isConnected);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConnected", "()Z"));
			}
		}

		static Delegate cb_isEOF;
#pragma warning disable 0169
		static Delegate GetIsEOFHandler ()
		{
			if (cb_isEOF == null)
				cb_isEOF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEOF);
			return cb_isEOF;
		}

		static bool n_IsEOF (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEOF;
		}
#pragma warning restore 0169

		static IntPtr id_isEOF;
		public virtual bool IsEOF {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='isEOF' and count(parameter)=0]"
			[Register ("isEOF", "()Z", "GetIsEOFHandler")]
			get {
				if (id_isEOF == IntPtr.Zero)
					id_isEOF = JNIEnv.GetMethodID (class_ref, "isEOF", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isEOF);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEOF", "()Z"));
			}
		}

		static Delegate cb_getOutputStream;
#pragma warning disable 0169
		static Delegate GetGetOutputStreamHandler ()
		{
			if (cb_getOutputStream == null)
				cb_getOutputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOutputStream);
			return cb_getOutputStream;
		}

		static IntPtr n_GetOutputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.OutputStream);
		}
#pragma warning restore 0169

		static Delegate cb_setOutputStream_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetSetOutputStream_Ljava_io_OutputStream_Handler ()
		{
			if (cb_setOutputStream_Ljava_io_OutputStream_ == null)
				cb_setOutputStream_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOutputStream_Ljava_io_OutputStream_);
			return cb_setOutputStream_Ljava_io_OutputStream_;
		}

		static void n_SetOutputStream_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OutputStream = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOutputStream;
		static IntPtr id_setOutputStream_Ljava_io_OutputStream_;
		public virtual global::System.IO.Stream OutputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='getOutputStream' and count(parameter)=0]"
			[Register ("getOutputStream", "()Ljava/io/OutputStream;", "GetGetOutputStreamHandler")]
			get {
				if (id_getOutputStream == IntPtr.Zero)
					id_getOutputStream = JNIEnv.GetMethodID (class_ref, "getOutputStream", "()Ljava/io/OutputStream;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getOutputStream), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutputStream", "()Ljava/io/OutputStream;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='setOutputStream' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
			[Register ("setOutputStream", "(Ljava/io/OutputStream;)V", "GetSetOutputStream_Ljava_io_OutputStream_Handler")]
			set {
				if (id_setOutputStream_Ljava_io_OutputStream_ == IntPtr.Zero)
					id_setOutputStream_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "setOutputStream", "(Ljava/io/OutputStream;)V");
				IntPtr native_value = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOutputStream_Ljava_io_OutputStream_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOutputStream", "(Ljava/io/OutputStream;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getSession;
#pragma warning disable 0169
		static Delegate GetGetSessionHandler ()
		{
			if (cb_getSession == null)
				cb_getSession = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSession);
			return cb_getSession;
		}

		static IntPtr n_GetSession (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Session);
		}
#pragma warning restore 0169

		static IntPtr id_getSession;
		public virtual global::Com.Jcraft.Jsch.Session Session {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='getSession' and count(parameter)=0]"
			[Register ("getSession", "()Lcom/jcraft/jsch/Session;", "GetGetSessionHandler")]
			get {
				if (id_getSession == IntPtr.Zero)
					id_getSession = JNIEnv.GetMethodID (class_ref, "getSession", "()Lcom/jcraft/jsch/Session;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (JNIEnv.CallObjectMethod  (Handle, id_getSession), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSession", "()Lcom/jcraft/jsch/Session;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_connect;
#pragma warning disable 0169
		static Delegate GetConnectHandler ()
		{
			if (cb_connect == null)
				cb_connect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Connect);
			return cb_connect;
		}

		static void n_Connect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connect ();
		}
#pragma warning restore 0169

		static IntPtr id_connect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()V", "GetConnectHandler")]
		public virtual void Connect ()
		{
			if (id_connect == IntPtr.Zero)
				id_connect = JNIEnv.GetMethodID (class_ref, "connect", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_connect);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "()V"));
		}

		static Delegate cb_connect_I;
#pragma warning disable 0169
		static Delegate GetConnect_IHandler ()
		{
			if (cb_connect_I == null)
				cb_connect_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Connect_I);
			return cb_connect_I;
		}

		static void n_Connect_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0);
		}
#pragma warning restore 0169

		static IntPtr id_connect_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("connect", "(I)V", "GetConnect_IHandler")]
		public virtual void Connect (int p0)
		{
			if (id_connect_I == IntPtr.Zero)
				id_connect_I = JNIEnv.GetMethodID (class_ref, "connect", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_connect_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "(I)V"), new JValue (p0));
		}

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disconnect);
			return cb_disconnect;
		}

		static void n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		static IntPtr id_disconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler")]
		public virtual void Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_disconnect);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnect", "()V"));
		}

		static Delegate cb_genChannelOpenPacket;
#pragma warning disable 0169
		static Delegate GetGenChannelOpenPacketHandler ()
		{
			if (cb_genChannelOpenPacket == null)
				cb_genChannelOpenPacket = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GenChannelOpenPacket);
			return cb_genChannelOpenPacket;
		}

		static IntPtr n_GenChannelOpenPacket (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GenChannelOpenPacket ());
		}
#pragma warning restore 0169

		static IntPtr id_genChannelOpenPacket;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='genChannelOpenPacket' and count(parameter)=0]"
		[Register ("genChannelOpenPacket", "()Lcom/jcraft/jsch/Packet;", "GetGenChannelOpenPacketHandler")]
		protected virtual global::Com.Jcraft.Jsch.Packet GenChannelOpenPacket ()
		{
			if (id_genChannelOpenPacket == IntPtr.Zero)
				id_genChannelOpenPacket = JNIEnv.GetMethodID (class_ref, "genChannelOpenPacket", "()Lcom/jcraft/jsch/Packet;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Packet> (JNIEnv.CallObjectMethod  (Handle, id_genChannelOpenPacket), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Packet> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "genChannelOpenPacket", "()Lcom/jcraft/jsch/Packet;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_run);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
		}

		static Delegate cb_sendChannelOpen;
#pragma warning disable 0169
		static Delegate GetSendChannelOpenHandler ()
		{
			if (cb_sendChannelOpen == null)
				cb_sendChannelOpen = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendChannelOpen);
			return cb_sendChannelOpen;
		}

		static void n_SendChannelOpen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendChannelOpen ();
		}
#pragma warning restore 0169

		static IntPtr id_sendChannelOpen;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='sendChannelOpen' and count(parameter)=0]"
		[Register ("sendChannelOpen", "()V", "GetSendChannelOpenHandler")]
		protected virtual void SendChannelOpen ()
		{
			if (id_sendChannelOpen == IntPtr.Zero)
				id_sendChannelOpen = JNIEnv.GetMethodID (class_ref, "sendChannelOpen", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sendChannelOpen);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendChannelOpen", "()V"));
		}

		static Delegate cb_sendOpenConfirmation;
#pragma warning disable 0169
		static Delegate GetSendOpenConfirmationHandler ()
		{
			if (cb_sendOpenConfirmation == null)
				cb_sendOpenConfirmation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendOpenConfirmation);
			return cb_sendOpenConfirmation;
		}

		static void n_SendOpenConfirmation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendOpenConfirmation ();
		}
#pragma warning restore 0169

		static IntPtr id_sendOpenConfirmation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='sendOpenConfirmation' and count(parameter)=0]"
		[Register ("sendOpenConfirmation", "()V", "GetSendOpenConfirmationHandler")]
		protected virtual void SendOpenConfirmation ()
		{
			if (id_sendOpenConfirmation == IntPtr.Zero)
				id_sendOpenConfirmation = JNIEnv.GetMethodID (class_ref, "sendOpenConfirmation", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sendOpenConfirmation);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendOpenConfirmation", "()V"));
		}

		static Delegate cb_sendOpenFailure_I;
#pragma warning disable 0169
		static Delegate GetSendOpenFailure_IHandler ()
		{
			if (cb_sendOpenFailure_I == null)
				cb_sendOpenFailure_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SendOpenFailure_I);
			return cb_sendOpenFailure_I;
		}

		static void n_SendOpenFailure_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendOpenFailure (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendOpenFailure_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='sendOpenFailure' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("sendOpenFailure", "(I)V", "GetSendOpenFailure_IHandler")]
		protected virtual void SendOpenFailure (int p0)
		{
			if (id_sendOpenFailure_I == IntPtr.Zero)
				id_sendOpenFailure_I = JNIEnv.GetMethodID (class_ref, "sendOpenFailure", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sendOpenFailure_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendOpenFailure", "(I)V"), new JValue (p0));
		}

		static Delegate cb_sendSignal_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendSignal_Ljava_lang_String_Handler ()
		{
			if (cb_sendSignal_Ljava_lang_String_ == null)
				cb_sendSignal_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendSignal_Ljava_lang_String_);
			return cb_sendSignal_Ljava_lang_String_;
		}

		static void n_SendSignal_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendSignal (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendSignal_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='sendSignal' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sendSignal", "(Ljava/lang/String;)V", "GetSendSignal_Ljava_lang_String_Handler")]
		public virtual void SendSignal (string p0)
		{
			if (id_sendSignal_Ljava_lang_String_ == IntPtr.Zero)
				id_sendSignal_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendSignal", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sendSignal_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendSignal", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setExtOutputStream_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetSetExtOutputStream_Ljava_io_OutputStream_Handler ()
		{
			if (cb_setExtOutputStream_Ljava_io_OutputStream_ == null)
				cb_setExtOutputStream_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExtOutputStream_Ljava_io_OutputStream_);
			return cb_setExtOutputStream_Ljava_io_OutputStream_;
		}

		static void n_SetExtOutputStream_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetExtOutputStream (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setExtOutputStream_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='setExtOutputStream' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("setExtOutputStream", "(Ljava/io/OutputStream;)V", "GetSetExtOutputStream_Ljava_io_OutputStream_Handler")]
		public virtual void SetExtOutputStream (global::System.IO.Stream p0)
		{
			if (id_setExtOutputStream_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_setExtOutputStream_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "setExtOutputStream", "(Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setExtOutputStream_Ljava_io_OutputStream_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExtOutputStream", "(Ljava/io/OutputStream;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setExtOutputStream_Ljava_io_OutputStream_Z;
#pragma warning disable 0169
		static Delegate GetSetExtOutputStream_Ljava_io_OutputStream_ZHandler ()
		{
			if (cb_setExtOutputStream_Ljava_io_OutputStream_Z == null)
				cb_setExtOutputStream_Ljava_io_OutputStream_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetExtOutputStream_Ljava_io_OutputStream_Z);
			return cb_setExtOutputStream_Ljava_io_OutputStream_Z;
		}

		static void n_SetExtOutputStream_Ljava_io_OutputStream_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetExtOutputStream (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setExtOutputStream_Ljava_io_OutputStream_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='setExtOutputStream' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='boolean']]"
		[Register ("setExtOutputStream", "(Ljava/io/OutputStream;Z)V", "GetSetExtOutputStream_Ljava_io_OutputStream_ZHandler")]
		public virtual void SetExtOutputStream (global::System.IO.Stream p0, bool p1)
		{
			if (id_setExtOutputStream_Ljava_io_OutputStream_Z == IntPtr.Zero)
				id_setExtOutputStream_Ljava_io_OutputStream_Z = JNIEnv.GetMethodID (class_ref, "setExtOutputStream", "(Ljava/io/OutputStream;Z)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setExtOutputStream_Ljava_io_OutputStream_Z, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExtOutputStream", "(Ljava/io/OutputStream;Z)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setInputStream_Ljava_io_InputStream_Z;
#pragma warning disable 0169
		static Delegate GetSetInputStream_Ljava_io_InputStream_ZHandler ()
		{
			if (cb_setInputStream_Ljava_io_InputStream_Z == null)
				cb_setInputStream_Ljava_io_InputStream_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetInputStream_Ljava_io_InputStream_Z);
			return cb_setInputStream_Ljava_io_InputStream_Z;
		}

		static void n_SetInputStream_Ljava_io_InputStream_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetInputStream (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setInputStream_Ljava_io_InputStream_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='setInputStream' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='boolean']]"
		[Register ("setInputStream", "(Ljava/io/InputStream;Z)V", "GetSetInputStream_Ljava_io_InputStream_ZHandler")]
		public virtual void SetInputStream (global::System.IO.Stream p0, bool p1)
		{
			if (id_setInputStream_Ljava_io_InputStream_Z == IntPtr.Zero)
				id_setInputStream_Ljava_io_InputStream_Z = JNIEnv.GetMethodID (class_ref, "setInputStream", "(Ljava/io/InputStream;Z)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setInputStream_Ljava_io_InputStream_Z, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInputStream", "(Ljava/io/InputStream;Z)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setOutputStream_Ljava_io_OutputStream_Z;
#pragma warning disable 0169
		static Delegate GetSetOutputStream_Ljava_io_OutputStream_ZHandler ()
		{
			if (cb_setOutputStream_Ljava_io_OutputStream_Z == null)
				cb_setOutputStream_Ljava_io_OutputStream_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetOutputStream_Ljava_io_OutputStream_Z);
			return cb_setOutputStream_Ljava_io_OutputStream_Z;
		}

		static void n_SetOutputStream_Ljava_io_OutputStream_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOutputStream (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setOutputStream_Ljava_io_OutputStream_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='setOutputStream' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='boolean']]"
		[Register ("setOutputStream", "(Ljava/io/OutputStream;Z)V", "GetSetOutputStream_Ljava_io_OutputStream_ZHandler")]
		public virtual void SetOutputStream (global::System.IO.Stream p0, bool p1)
		{
			if (id_setOutputStream_Ljava_io_OutputStream_Z == IntPtr.Zero)
				id_setOutputStream_Ljava_io_OutputStream_Z = JNIEnv.GetMethodID (class_ref, "setOutputStream", "(Ljava/io/OutputStream;Z)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOutputStream_Ljava_io_OutputStream_Z, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOutputStream", "(Ljava/io/OutputStream;Z)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetXForwarding (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setXForwarding_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='setXForwarding' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setXForwarding", "(Z)V", "GetSetXForwarding_ZHandler")]
		public virtual void SetXForwarding (bool p0)
		{
			if (id_setXForwarding_Z == IntPtr.Zero)
				id_setXForwarding_Z = JNIEnv.GetMethodID (class_ref, "setXForwarding", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setXForwarding_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setXForwarding", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Channel']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_start);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
		}

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/Channel", DoNotGenerateAcw=true)]
	internal partial class ChannelInvoker : Channel {

		public ChannelInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelInvoker); }
		}

	}

}

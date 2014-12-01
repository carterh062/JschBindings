using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/Session", DoNotGenerateAcw=true)]
	public partial class Session : global::Java.Lang.Object, global::Java.Lang.IRunnable {


		static IntPtr daemon_thread_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/field[@name='daemon_thread']"
		[Register ("daemon_thread")]
		protected bool DaemonThread {
			get {
				if (daemon_thread_jfieldId == IntPtr.Zero)
					daemon_thread_jfieldId = JNIEnv.GetFieldID (class_ref, "daemon_thread", "Z");
				return JNIEnv.GetBooleanField (Handle, daemon_thread_jfieldId);
			}
			set {
				if (daemon_thread_jfieldId == IntPtr.Zero)
					daemon_thread_jfieldId = JNIEnv.GetFieldID (class_ref, "daemon_thread", "Z");
				JNIEnv.SetField (Handle, daemon_thread_jfieldId, value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session.Forwarding']"
		[global::Android.Runtime.Register ("com/jcraft/jsch/Session$Forwarding", DoNotGenerateAcw=true)]
		public partial class Forwarding : global::Java.Lang.Object {

			protected Forwarding (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session.GlobalRequestReply']"
		[global::Android.Runtime.Register ("com/jcraft/jsch/Session$GlobalRequestReply", DoNotGenerateAcw=true)]
		public partial class GlobalRequestReply : global::Java.Lang.Object {

			protected GlobalRequestReply (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/Session", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Session); }
		}

		protected Session (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getClientVersion;
#pragma warning disable 0169
		static Delegate GetGetClientVersionHandler ()
		{
			if (cb_getClientVersion == null)
				cb_getClientVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientVersion);
			return cb_getClientVersion;
		}

		static IntPtr n_GetClientVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientVersion);
		}
#pragma warning restore 0169

		static Delegate cb_setClientVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setClientVersion_Ljava_lang_String_ == null)
				cb_setClientVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClientVersion_Ljava_lang_String_);
			return cb_setClientVersion_Ljava_lang_String_;
		}

		static void n_SetClientVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClientVersion = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClientVersion;
		static IntPtr id_setClientVersion_Ljava_lang_String_;
		public virtual string ClientVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='getClientVersion' and count(parameter)=0]"
			[Register ("getClientVersion", "()Ljava/lang/String;", "GetGetClientVersionHandler")]
			get {
				if (id_getClientVersion == IntPtr.Zero)
					id_getClientVersion = JNIEnv.GetMethodID (class_ref, "getClientVersion", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getClientVersion), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setClientVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClientVersion", "(Ljava/lang/String;)V", "GetSetClientVersion_Ljava_lang_String_Handler")]
			set {
				if (id_setClientVersion_Ljava_lang_String_ == IntPtr.Zero)
					id_setClientVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setClientVersion", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setClientVersion_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClientVersion", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getHost;
#pragma warning disable 0169
		static Delegate GetGetHostHandler ()
		{
			if (cb_getHost == null)
				cb_getHost = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHost);
			return cb_getHost;
		}

		static IntPtr n_GetHost (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Host);
		}
#pragma warning restore 0169

		static Delegate cb_setHost_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHost_Ljava_lang_String_Handler ()
		{
			if (cb_setHost_Ljava_lang_String_ == null)
				cb_setHost_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHost_Ljava_lang_String_);
			return cb_setHost_Ljava_lang_String_;
		}

		static void n_SetHost_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Host = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHost;
		static IntPtr id_setHost_Ljava_lang_String_;
		public virtual string Host {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='getHost' and count(parameter)=0]"
			[Register ("getHost", "()Ljava/lang/String;", "GetGetHostHandler")]
			get {
				if (id_getHost == IntPtr.Zero)
					id_getHost = JNIEnv.GetMethodID (class_ref, "getHost", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getHost), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHost", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setHost' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHost", "(Ljava/lang/String;)V", "GetSetHost_Ljava_lang_String_Handler")]
			set {
				if (id_setHost_Ljava_lang_String_ == IntPtr.Zero)
					id_setHost_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHost", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setHost_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHost", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getHostKey;
#pragma warning disable 0169
		static Delegate GetGetHostKeyHandler ()
		{
			if (cb_getHostKey == null)
				cb_getHostKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHostKey);
			return cb_getHostKey;
		}

		static IntPtr n_GetHostKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HostKey);
		}
#pragma warning restore 0169

		static IntPtr id_getHostKey;
		public virtual global::Com.Jcraft.Jsch.HostKey HostKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='getHostKey' and count(parameter)=0]"
			[Register ("getHostKey", "()Lcom/jcraft/jsch/HostKey;", "GetGetHostKeyHandler")]
			get {
				if (id_getHostKey == IntPtr.Zero)
					id_getHostKey = JNIEnv.GetMethodID (class_ref, "getHostKey", "()Lcom/jcraft/jsch/HostKey;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.HostKey> (JNIEnv.CallObjectMethod  (Handle, id_getHostKey), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.HostKey> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHostKey", "()Lcom/jcraft/jsch/HostKey;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getHostKeyAlias;
#pragma warning disable 0169
		static Delegate GetGetHostKeyAliasHandler ()
		{
			if (cb_getHostKeyAlias == null)
				cb_getHostKeyAlias = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHostKeyAlias);
			return cb_getHostKeyAlias;
		}

		static IntPtr n_GetHostKeyAlias (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HostKeyAlias);
		}
#pragma warning restore 0169

		static Delegate cb_setHostKeyAlias_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHostKeyAlias_Ljava_lang_String_Handler ()
		{
			if (cb_setHostKeyAlias_Ljava_lang_String_ == null)
				cb_setHostKeyAlias_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHostKeyAlias_Ljava_lang_String_);
			return cb_setHostKeyAlias_Ljava_lang_String_;
		}

		static void n_SetHostKeyAlias_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HostKeyAlias = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHostKeyAlias;
		static IntPtr id_setHostKeyAlias_Ljava_lang_String_;
		public virtual string HostKeyAlias {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='getHostKeyAlias' and count(parameter)=0]"
			[Register ("getHostKeyAlias", "()Ljava/lang/String;", "GetGetHostKeyAliasHandler")]
			get {
				if (id_getHostKeyAlias == IntPtr.Zero)
					id_getHostKeyAlias = JNIEnv.GetMethodID (class_ref, "getHostKeyAlias", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getHostKeyAlias), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHostKeyAlias", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setHostKeyAlias' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHostKeyAlias", "(Ljava/lang/String;)V", "GetSetHostKeyAlias_Ljava_lang_String_Handler")]
			set {
				if (id_setHostKeyAlias_Ljava_lang_String_ == IntPtr.Zero)
					id_setHostKeyAlias_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHostKeyAlias", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setHostKeyAlias_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHostKeyAlias", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getHostKeyRepository;
#pragma warning disable 0169
		static Delegate GetGetHostKeyRepositoryHandler ()
		{
			if (cb_getHostKeyRepository == null)
				cb_getHostKeyRepository = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHostKeyRepository);
			return cb_getHostKeyRepository;
		}

		static IntPtr n_GetHostKeyRepository (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HostKeyRepository);
		}
#pragma warning restore 0169

		static Delegate cb_setHostKeyRepository_Lcom_jcraft_jsch_HostKeyRepository_;
#pragma warning disable 0169
		static Delegate GetSetHostKeyRepository_Lcom_jcraft_jsch_HostKeyRepository_Handler ()
		{
			if (cb_setHostKeyRepository_Lcom_jcraft_jsch_HostKeyRepository_ == null)
				cb_setHostKeyRepository_Lcom_jcraft_jsch_HostKeyRepository_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHostKeyRepository_Lcom_jcraft_jsch_HostKeyRepository_);
			return cb_setHostKeyRepository_Lcom_jcraft_jsch_HostKeyRepository_;
		}

		static void n_SetHostKeyRepository_Lcom_jcraft_jsch_HostKeyRepository_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.IHostKeyRepository p0 = (global::Com.Jcraft.Jsch.IHostKeyRepository)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IHostKeyRepository> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HostKeyRepository = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHostKeyRepository;
		static IntPtr id_setHostKeyRepository_Lcom_jcraft_jsch_HostKeyRepository_;
		public virtual global::Com.Jcraft.Jsch.IHostKeyRepository HostKeyRepository {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='getHostKeyRepository' and count(parameter)=0]"
			[Register ("getHostKeyRepository", "()Lcom/jcraft/jsch/HostKeyRepository;", "GetGetHostKeyRepositoryHandler")]
			get {
				if (id_getHostKeyRepository == IntPtr.Zero)
					id_getHostKeyRepository = JNIEnv.GetMethodID (class_ref, "getHostKeyRepository", "()Lcom/jcraft/jsch/HostKeyRepository;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IHostKeyRepository> (JNIEnv.CallObjectMethod  (Handle, id_getHostKeyRepository), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IHostKeyRepository> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHostKeyRepository", "()Lcom/jcraft/jsch/HostKeyRepository;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setHostKeyRepository' and count(parameter)=1 and parameter[1][@type='com.jcraft.jsch.HostKeyRepository']]"
			[Register ("setHostKeyRepository", "(Lcom/jcraft/jsch/HostKeyRepository;)V", "GetSetHostKeyRepository_Lcom_jcraft_jsch_HostKeyRepository_Handler")]
			set {
				if (id_setHostKeyRepository_Lcom_jcraft_jsch_HostKeyRepository_ == IntPtr.Zero)
					id_setHostKeyRepository_Lcom_jcraft_jsch_HostKeyRepository_ = JNIEnv.GetMethodID (class_ref, "setHostKeyRepository", "(Lcom/jcraft/jsch/HostKeyRepository;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setHostKeyRepository_Lcom_jcraft_jsch_HostKeyRepository_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHostKeyRepository", "(Lcom/jcraft/jsch/HostKeyRepository;)V"), new JValue (value));
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
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		static IntPtr id_isConnected;
		public virtual bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='isConnected' and count(parameter)=0]"
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

		static Delegate cb_getPort;
#pragma warning disable 0169
		static Delegate GetGetPortHandler ()
		{
			if (cb_getPort == null)
				cb_getPort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPort);
			return cb_getPort;
		}

		static int n_GetPort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Port;
		}
#pragma warning restore 0169

		static Delegate cb_setPort_I;
#pragma warning disable 0169
		static Delegate GetSetPort_IHandler ()
		{
			if (cb_setPort_I == null)
				cb_setPort_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPort_I);
			return cb_setPort_I;
		}

		static void n_SetPort_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Port = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPort;
		static IntPtr id_setPort_I;
		public virtual int Port {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='getPort' and count(parameter)=0]"
			[Register ("getPort", "()I", "GetGetPortHandler")]
			get {
				if (id_getPort == IntPtr.Zero)
					id_getPort = JNIEnv.GetMethodID (class_ref, "getPort", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getPort);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPort", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setPort' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPort", "(I)V", "GetSetPort_IHandler")]
			set {
				if (id_setPort_I == IntPtr.Zero)
					id_setPort_I = JNIEnv.GetMethodID (class_ref, "setPort", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPort_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPort", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getServerAliveCountMax;
#pragma warning disable 0169
		static Delegate GetGetServerAliveCountMaxHandler ()
		{
			if (cb_getServerAliveCountMax == null)
				cb_getServerAliveCountMax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetServerAliveCountMax);
			return cb_getServerAliveCountMax;
		}

		static int n_GetServerAliveCountMax (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ServerAliveCountMax;
		}
#pragma warning restore 0169

		static Delegate cb_setServerAliveCountMax_I;
#pragma warning disable 0169
		static Delegate GetSetServerAliveCountMax_IHandler ()
		{
			if (cb_setServerAliveCountMax_I == null)
				cb_setServerAliveCountMax_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetServerAliveCountMax_I);
			return cb_setServerAliveCountMax_I;
		}

		static void n_SetServerAliveCountMax_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ServerAliveCountMax = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getServerAliveCountMax;
		static IntPtr id_setServerAliveCountMax_I;
		public virtual int ServerAliveCountMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='getServerAliveCountMax' and count(parameter)=0]"
			[Register ("getServerAliveCountMax", "()I", "GetGetServerAliveCountMaxHandler")]
			get {
				if (id_getServerAliveCountMax == IntPtr.Zero)
					id_getServerAliveCountMax = JNIEnv.GetMethodID (class_ref, "getServerAliveCountMax", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getServerAliveCountMax);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServerAliveCountMax", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setServerAliveCountMax' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setServerAliveCountMax", "(I)V", "GetSetServerAliveCountMax_IHandler")]
			set {
				if (id_setServerAliveCountMax_I == IntPtr.Zero)
					id_setServerAliveCountMax_I = JNIEnv.GetMethodID (class_ref, "setServerAliveCountMax", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setServerAliveCountMax_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setServerAliveCountMax", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getServerAliveInterval;
#pragma warning disable 0169
		static Delegate GetGetServerAliveIntervalHandler ()
		{
			if (cb_getServerAliveInterval == null)
				cb_getServerAliveInterval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetServerAliveInterval);
			return cb_getServerAliveInterval;
		}

		static int n_GetServerAliveInterval (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ServerAliveInterval;
		}
#pragma warning restore 0169

		static Delegate cb_setServerAliveInterval_I;
#pragma warning disable 0169
		static Delegate GetSetServerAliveInterval_IHandler ()
		{
			if (cb_setServerAliveInterval_I == null)
				cb_setServerAliveInterval_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetServerAliveInterval_I);
			return cb_setServerAliveInterval_I;
		}

		static void n_SetServerAliveInterval_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ServerAliveInterval = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getServerAliveInterval;
		static IntPtr id_setServerAliveInterval_I;
		public virtual int ServerAliveInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='getServerAliveInterval' and count(parameter)=0]"
			[Register ("getServerAliveInterval", "()I", "GetGetServerAliveIntervalHandler")]
			get {
				if (id_getServerAliveInterval == IntPtr.Zero)
					id_getServerAliveInterval = JNIEnv.GetMethodID (class_ref, "getServerAliveInterval", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getServerAliveInterval);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServerAliveInterval", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setServerAliveInterval' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setServerAliveInterval", "(I)V", "GetSetServerAliveInterval_IHandler")]
			set {
				if (id_setServerAliveInterval_I == IntPtr.Zero)
					id_setServerAliveInterval_I = JNIEnv.GetMethodID (class_ref, "setServerAliveInterval", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setServerAliveInterval_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setServerAliveInterval", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getServerVersion;
#pragma warning disable 0169
		static Delegate GetGetServerVersionHandler ()
		{
			if (cb_getServerVersion == null)
				cb_getServerVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServerVersion);
			return cb_getServerVersion;
		}

		static IntPtr n_GetServerVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServerVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getServerVersion;
		public virtual string ServerVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='getServerVersion' and count(parameter)=0]"
			[Register ("getServerVersion", "()Ljava/lang/String;", "GetGetServerVersionHandler")]
			get {
				if (id_getServerVersion == IntPtr.Zero)
					id_getServerVersion = JNIEnv.GetMethodID (class_ref, "getServerVersion", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getServerVersion), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServerVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTimeout;
#pragma warning disable 0169
		static Delegate GetGetTimeoutHandler ()
		{
			if (cb_getTimeout == null)
				cb_getTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTimeout);
			return cb_getTimeout;
		}

		static int n_GetTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timeout;
		}
#pragma warning restore 0169

		static Delegate cb_setTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetTimeout_IHandler ()
		{
			if (cb_setTimeout_I == null)
				cb_setTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTimeout_I);
			return cb_setTimeout_I;
		}

		static void n_SetTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Timeout = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeout;
		static IntPtr id_setTimeout_I;
		public virtual int Timeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='getTimeout' and count(parameter)=0]"
			[Register ("getTimeout", "()I", "GetGetTimeoutHandler")]
			get {
				if (id_getTimeout == IntPtr.Zero)
					id_getTimeout = JNIEnv.GetMethodID (class_ref, "getTimeout", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getTimeout);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeout", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTimeout", "(I)V", "GetSetTimeout_IHandler")]
			set {
				if (id_setTimeout_I == IntPtr.Zero)
					id_setTimeout_I = JNIEnv.GetMethodID (class_ref, "setTimeout", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTimeout_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeout", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getUserInfo;
#pragma warning disable 0169
		static Delegate GetGetUserInfoHandler ()
		{
			if (cb_getUserInfo == null)
				cb_getUserInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserInfo);
			return cb_getUserInfo;
		}

		static IntPtr n_GetUserInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UserInfo);
		}
#pragma warning restore 0169

		static Delegate cb_setUserInfo_Lcom_jcraft_jsch_UserInfo_;
#pragma warning disable 0169
		static Delegate GetSetUserInfo_Lcom_jcraft_jsch_UserInfo_Handler ()
		{
			if (cb_setUserInfo_Lcom_jcraft_jsch_UserInfo_ == null)
				cb_setUserInfo_Lcom_jcraft_jsch_UserInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserInfo_Lcom_jcraft_jsch_UserInfo_);
			return cb_setUserInfo_Lcom_jcraft_jsch_UserInfo_;
		}

		static void n_SetUserInfo_Lcom_jcraft_jsch_UserInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.IUserInfo p0 = (global::Com.Jcraft.Jsch.IUserInfo)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IUserInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserInfo = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserInfo;
		static IntPtr id_setUserInfo_Lcom_jcraft_jsch_UserInfo_;
		public virtual global::Com.Jcraft.Jsch.IUserInfo UserInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='getUserInfo' and count(parameter)=0]"
			[Register ("getUserInfo", "()Lcom/jcraft/jsch/UserInfo;", "GetGetUserInfoHandler")]
			get {
				if (id_getUserInfo == IntPtr.Zero)
					id_getUserInfo = JNIEnv.GetMethodID (class_ref, "getUserInfo", "()Lcom/jcraft/jsch/UserInfo;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IUserInfo> (JNIEnv.CallObjectMethod  (Handle, id_getUserInfo), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IUserInfo> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserInfo", "()Lcom/jcraft/jsch/UserInfo;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setUserInfo' and count(parameter)=1 and parameter[1][@type='com.jcraft.jsch.UserInfo']]"
			[Register ("setUserInfo", "(Lcom/jcraft/jsch/UserInfo;)V", "GetSetUserInfo_Lcom_jcraft_jsch_UserInfo_Handler")]
			set {
				if (id_setUserInfo_Lcom_jcraft_jsch_UserInfo_ == IntPtr.Zero)
					id_setUserInfo_Lcom_jcraft_jsch_UserInfo_ = JNIEnv.GetMethodID (class_ref, "setUserInfo", "(Lcom/jcraft/jsch/UserInfo;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setUserInfo_Lcom_jcraft_jsch_UserInfo_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserInfo", "(Lcom/jcraft/jsch/UserInfo;)V"), new JValue (value));
			}
		}

		static Delegate cb_getUserName;
#pragma warning disable 0169
		static Delegate GetGetUserNameHandler ()
		{
			if (cb_getUserName == null)
				cb_getUserName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserName);
			return cb_getUserName;
		}

		static IntPtr n_GetUserName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserName);
		}
#pragma warning restore 0169

		static IntPtr id_getUserName;
		public virtual string UserName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='getUserName' and count(parameter)=0]"
			[Register ("getUserName", "()Ljava/lang/String;", "GetGetUserNameHandler")]
			get {
				if (id_getUserName == IntPtr.Zero)
					id_getUserName = JNIEnv.GetMethodID (class_ref, "getUserName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUserName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connect ();
		}
#pragma warning restore 0169

		static IntPtr id_connect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='connect' and count(parameter)=0]"
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
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0);
		}
#pragma warning restore 0169

		static IntPtr id_connect_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_delPortForwardingL_I;
#pragma warning disable 0169
		static Delegate GetDelPortForwardingL_IHandler ()
		{
			if (cb_delPortForwardingL_I == null)
				cb_delPortForwardingL_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_DelPortForwardingL_I);
			return cb_delPortForwardingL_I;
		}

		static void n_DelPortForwardingL_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DelPortForwardingL (p0);
		}
#pragma warning restore 0169

		static IntPtr id_delPortForwardingL_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='delPortForwardingL' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("delPortForwardingL", "(I)V", "GetDelPortForwardingL_IHandler")]
		public virtual void DelPortForwardingL (int p0)
		{
			if (id_delPortForwardingL_I == IntPtr.Zero)
				id_delPortForwardingL_I = JNIEnv.GetMethodID (class_ref, "delPortForwardingL", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_delPortForwardingL_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delPortForwardingL", "(I)V"), new JValue (p0));
		}

		static Delegate cb_delPortForwardingL_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetDelPortForwardingL_Ljava_lang_String_IHandler ()
		{
			if (cb_delPortForwardingL_Ljava_lang_String_I == null)
				cb_delPortForwardingL_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_DelPortForwardingL_Ljava_lang_String_I);
			return cb_delPortForwardingL_Ljava_lang_String_I;
		}

		static void n_DelPortForwardingL_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DelPortForwardingL (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_delPortForwardingL_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='delPortForwardingL' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("delPortForwardingL", "(Ljava/lang/String;I)V", "GetDelPortForwardingL_Ljava_lang_String_IHandler")]
		public virtual void DelPortForwardingL (string p0, int p1)
		{
			if (id_delPortForwardingL_Ljava_lang_String_I == IntPtr.Zero)
				id_delPortForwardingL_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "delPortForwardingL", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_delPortForwardingL_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delPortForwardingL", "(Ljava/lang/String;I)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_delPortForwardingR_I;
#pragma warning disable 0169
		static Delegate GetDelPortForwardingR_IHandler ()
		{
			if (cb_delPortForwardingR_I == null)
				cb_delPortForwardingR_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_DelPortForwardingR_I);
			return cb_delPortForwardingR_I;
		}

		static void n_DelPortForwardingR_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DelPortForwardingR (p0);
		}
#pragma warning restore 0169

		static IntPtr id_delPortForwardingR_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='delPortForwardingR' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("delPortForwardingR", "(I)V", "GetDelPortForwardingR_IHandler")]
		public virtual void DelPortForwardingR (int p0)
		{
			if (id_delPortForwardingR_I == IntPtr.Zero)
				id_delPortForwardingR_I = JNIEnv.GetMethodID (class_ref, "delPortForwardingR", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_delPortForwardingR_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delPortForwardingR", "(I)V"), new JValue (p0));
		}

		static Delegate cb_delPortForwardingR_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetDelPortForwardingR_Ljava_lang_String_IHandler ()
		{
			if (cb_delPortForwardingR_Ljava_lang_String_I == null)
				cb_delPortForwardingR_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_DelPortForwardingR_Ljava_lang_String_I);
			return cb_delPortForwardingR_Ljava_lang_String_I;
		}

		static void n_DelPortForwardingR_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DelPortForwardingR (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_delPortForwardingR_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='delPortForwardingR' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("delPortForwardingR", "(Ljava/lang/String;I)V", "GetDelPortForwardingR_Ljava_lang_String_IHandler")]
		public virtual void DelPortForwardingR (string p0, int p1)
		{
			if (id_delPortForwardingR_Ljava_lang_String_I == IntPtr.Zero)
				id_delPortForwardingR_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "delPortForwardingR", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_delPortForwardingR_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delPortForwardingR", "(Ljava/lang/String;I)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		static IntPtr id_disconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='disconnect' and count(parameter)=0]"
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

		static Delegate cb_encode_Lcom_jcraft_jsch_Packet_;
#pragma warning disable 0169
		static Delegate GetEncode_Lcom_jcraft_jsch_Packet_Handler ()
		{
			if (cb_encode_Lcom_jcraft_jsch_Packet_ == null)
				cb_encode_Lcom_jcraft_jsch_Packet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Encode_Lcom_jcraft_jsch_Packet_);
			return cb_encode_Lcom_jcraft_jsch_Packet_;
		}

		static void n_Encode_Lcom_jcraft_jsch_Packet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.Packet p0 = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Packet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Encode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lcom_jcraft_jsch_Packet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='com.jcraft.jsch.Packet']]"
		[Register ("encode", "(Lcom/jcraft/jsch/Packet;)V", "GetEncode_Lcom_jcraft_jsch_Packet_Handler")]
		public virtual void Encode (global::Com.Jcraft.Jsch.Packet p0)
		{
			if (id_encode_Lcom_jcraft_jsch_Packet_ == IntPtr.Zero)
				id_encode_Lcom_jcraft_jsch_Packet_ = JNIEnv.GetMethodID (class_ref, "encode", "(Lcom/jcraft/jsch/Packet;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_encode_Lcom_jcraft_jsch_Packet_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Lcom/jcraft/jsch/Packet;)V"), new JValue (p0));
		}

		static Delegate cb_getConfig_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetConfig_Ljava_lang_String_Handler ()
		{
			if (cb_getConfig_Ljava_lang_String_ == null)
				cb_getConfig_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConfig_Ljava_lang_String_);
			return cb_getConfig_Ljava_lang_String_;
		}

		static IntPtr n_GetConfig_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetConfig (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConfig_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='getConfig' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getConfig", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetConfig_Ljava_lang_String_Handler")]
		public virtual string GetConfig (string p0)
		{
			if (id_getConfig_Ljava_lang_String_ == IntPtr.Zero)
				id_getConfig_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getConfig", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getConfig_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConfig", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getPortForwardingL;
#pragma warning disable 0169
		static Delegate GetGetPortForwardingLHandler ()
		{
			if (cb_getPortForwardingL == null)
				cb_getPortForwardingL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPortForwardingL);
			return cb_getPortForwardingL;
		}

		static IntPtr n_GetPortForwardingL (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPortForwardingL ());
		}
#pragma warning restore 0169

		static IntPtr id_getPortForwardingL;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='getPortForwardingL' and count(parameter)=0]"
		[Register ("getPortForwardingL", "()[Ljava/lang/String;", "GetGetPortForwardingLHandler")]
		public virtual string[] GetPortForwardingL ()
		{
			if (id_getPortForwardingL == IntPtr.Zero)
				id_getPortForwardingL = JNIEnv.GetMethodID (class_ref, "getPortForwardingL", "()[Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getPortForwardingL), JniHandleOwnership.TransferLocalRef, typeof (string));
			else
				return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPortForwardingL", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static Delegate cb_getPortForwardingR;
#pragma warning disable 0169
		static Delegate GetGetPortForwardingRHandler ()
		{
			if (cb_getPortForwardingR == null)
				cb_getPortForwardingR = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPortForwardingR);
			return cb_getPortForwardingR;
		}

		static IntPtr n_GetPortForwardingR (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPortForwardingR ());
		}
#pragma warning restore 0169

		static IntPtr id_getPortForwardingR;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='getPortForwardingR' and count(parameter)=0]"
		[Register ("getPortForwardingR", "()[Ljava/lang/String;", "GetGetPortForwardingRHandler")]
		public virtual string[] GetPortForwardingR ()
		{
			if (id_getPortForwardingR == IntPtr.Zero)
				id_getPortForwardingR = JNIEnv.GetMethodID (class_ref, "getPortForwardingR", "()[Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getPortForwardingR), JniHandleOwnership.TransferLocalRef, typeof (string));
			else
				return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPortForwardingR", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static Delegate cb_getStreamForwarder_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetStreamForwarder_Ljava_lang_String_IHandler ()
		{
			if (cb_getStreamForwarder_Ljava_lang_String_I == null)
				cb_getStreamForwarder_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_GetStreamForwarder_Ljava_lang_String_I);
			return cb_getStreamForwarder_Ljava_lang_String_I;
		}

		static IntPtr n_GetStreamForwarder_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetStreamForwarder (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getStreamForwarder_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='getStreamForwarder' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getStreamForwarder", "(Ljava/lang/String;I)Lcom/jcraft/jsch/Channel;", "GetGetStreamForwarder_Ljava_lang_String_IHandler")]
		public virtual global::Com.Jcraft.Jsch.Channel GetStreamForwarder (string p0, int p1)
		{
			if (id_getStreamForwarder_Ljava_lang_String_I == IntPtr.Zero)
				id_getStreamForwarder_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "getStreamForwarder", "(Ljava/lang/String;I)Lcom/jcraft/jsch/Channel;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Jcraft.Jsch.Channel __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (JNIEnv.CallObjectMethod  (Handle, id_getStreamForwarder_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStreamForwarder", "(Ljava/lang/String;I)Lcom/jcraft/jsch/Channel;"), new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_noMoreSessionChannels;
#pragma warning disable 0169
		static Delegate GetNoMoreSessionChannelsHandler ()
		{
			if (cb_noMoreSessionChannels == null)
				cb_noMoreSessionChannels = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NoMoreSessionChannels);
			return cb_noMoreSessionChannels;
		}

		static void n_NoMoreSessionChannels (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NoMoreSessionChannels ();
		}
#pragma warning restore 0169

		static IntPtr id_noMoreSessionChannels;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='noMoreSessionChannels' and count(parameter)=0]"
		[Register ("noMoreSessionChannels", "()V", "GetNoMoreSessionChannelsHandler")]
		public virtual void NoMoreSessionChannels ()
		{
			if (id_noMoreSessionChannels == IntPtr.Zero)
				id_noMoreSessionChannels = JNIEnv.GetMethodID (class_ref, "noMoreSessionChannels", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_noMoreSessionChannels);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "noMoreSessionChannels", "()V"));
		}

		static Delegate cb_openChannel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpenChannel_Ljava_lang_String_Handler ()
		{
			if (cb_openChannel_Ljava_lang_String_ == null)
				cb_openChannel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OpenChannel_Ljava_lang_String_);
			return cb_openChannel_Ljava_lang_String_;
		}

		static IntPtr n_OpenChannel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OpenChannel (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_openChannel_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='openChannel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("openChannel", "(Ljava/lang/String;)Lcom/jcraft/jsch/Channel;", "GetOpenChannel_Ljava_lang_String_Handler")]
		public virtual global::Com.Jcraft.Jsch.Channel OpenChannel (string p0)
		{
			if (id_openChannel_Ljava_lang_String_ == IntPtr.Zero)
				id_openChannel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "openChannel", "(Ljava/lang/String;)Lcom/jcraft/jsch/Channel;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Jcraft.Jsch.Channel __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (JNIEnv.CallObjectMethod  (Handle, id_openChannel_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openChannel", "(Ljava/lang/String;)Lcom/jcraft/jsch/Channel;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_read_Lcom_jcraft_jsch_Buffer_;
#pragma warning disable 0169
		static Delegate GetRead_Lcom_jcraft_jsch_Buffer_Handler ()
		{
			if (cb_read_Lcom_jcraft_jsch_Buffer_ == null)
				cb_read_Lcom_jcraft_jsch_Buffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Read_Lcom_jcraft_jsch_Buffer_);
			return cb_read_Lcom_jcraft_jsch_Buffer_;
		}

		static IntPtr n_Read_Lcom_jcraft_jsch_Buffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.Buffer p0 = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Read (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_read_Lcom_jcraft_jsch_Buffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='read' and count(parameter)=1 and parameter[1][@type='com.jcraft.jsch.Buffer']]"
		[Register ("read", "(Lcom/jcraft/jsch/Buffer;)Lcom/jcraft/jsch/Buffer;", "GetRead_Lcom_jcraft_jsch_Buffer_Handler")]
		public virtual global::Com.Jcraft.Jsch.Buffer Read (global::Com.Jcraft.Jsch.Buffer p0)
		{
			if (id_read_Lcom_jcraft_jsch_Buffer_ == IntPtr.Zero)
				id_read_Lcom_jcraft_jsch_Buffer_ = JNIEnv.GetMethodID (class_ref, "read", "(Lcom/jcraft/jsch/Buffer;)Lcom/jcraft/jsch/Buffer;");

			global::Com.Jcraft.Jsch.Buffer __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (JNIEnv.CallObjectMethod  (Handle, id_read_Lcom_jcraft_jsch_Buffer_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(Lcom/jcraft/jsch/Buffer;)Lcom/jcraft/jsch/Buffer;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_rekey;
#pragma warning disable 0169
		static Delegate GetRekeyHandler ()
		{
			if (cb_rekey == null)
				cb_rekey = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Rekey);
			return cb_rekey;
		}

		static void n_Rekey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Rekey ();
		}
#pragma warning restore 0169

		static IntPtr id_rekey;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='rekey' and count(parameter)=0]"
		[Register ("rekey", "()V", "GetRekeyHandler")]
		public virtual void Rekey ()
		{
			if (id_rekey == IntPtr.Zero)
				id_rekey = JNIEnv.GetMethodID (class_ref, "rekey", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_rekey);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rekey", "()V"));
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
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='run' and count(parameter)=0]"
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

		static Delegate cb_sendIgnore;
#pragma warning disable 0169
		static Delegate GetSendIgnoreHandler ()
		{
			if (cb_sendIgnore == null)
				cb_sendIgnore = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendIgnore);
			return cb_sendIgnore;
		}

		static void n_SendIgnore (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendIgnore ();
		}
#pragma warning restore 0169

		static IntPtr id_sendIgnore;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='sendIgnore' and count(parameter)=0]"
		[Register ("sendIgnore", "()V", "GetSendIgnoreHandler")]
		public virtual void SendIgnore ()
		{
			if (id_sendIgnore == IntPtr.Zero)
				id_sendIgnore = JNIEnv.GetMethodID (class_ref, "sendIgnore", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sendIgnore);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendIgnore", "()V"));
		}

		static Delegate cb_sendKeepAliveMsg;
#pragma warning disable 0169
		static Delegate GetSendKeepAliveMsgHandler ()
		{
			if (cb_sendKeepAliveMsg == null)
				cb_sendKeepAliveMsg = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendKeepAliveMsg);
			return cb_sendKeepAliveMsg;
		}

		static void n_SendKeepAliveMsg (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendKeepAliveMsg ();
		}
#pragma warning restore 0169

		static IntPtr id_sendKeepAliveMsg;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='sendKeepAliveMsg' and count(parameter)=0]"
		[Register ("sendKeepAliveMsg", "()V", "GetSendKeepAliveMsgHandler")]
		public virtual void SendKeepAliveMsg ()
		{
			if (id_sendKeepAliveMsg == IntPtr.Zero)
				id_sendKeepAliveMsg = JNIEnv.GetMethodID (class_ref, "sendKeepAliveMsg", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sendKeepAliveMsg);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendKeepAliveMsg", "()V"));
		}

		static Delegate cb_setConfig_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetConfig_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setConfig_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setConfig_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetConfig_Ljava_lang_String_Ljava_lang_String_);
			return cb_setConfig_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetConfig_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetConfig (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setConfig_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setConfig' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setConfig", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetConfig_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void SetConfig (string p0, string p1)
		{
			if (id_setConfig_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setConfig_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setConfig", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setConfig_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConfig", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_setConfig_Ljava_util_Hashtable_;
#pragma warning disable 0169
		static Delegate GetSetConfig_Ljava_util_Hashtable_Handler ()
		{
			if (cb_setConfig_Ljava_util_Hashtable_ == null)
				cb_setConfig_Ljava_util_Hashtable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConfig_Ljava_util_Hashtable_);
			return cb_setConfig_Ljava_util_Hashtable_;
		}

		static void n_SetConfig_Ljava_util_Hashtable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Hashtable p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Hashtable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetConfig (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setConfig_Ljava_util_Hashtable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setConfig' and count(parameter)=1 and parameter[1][@type='java.util.Hashtable']]"
		[Register ("setConfig", "(Ljava/util/Hashtable;)V", "GetSetConfig_Ljava_util_Hashtable_Handler")]
		public virtual void SetConfig (global::Java.Util.Hashtable p0)
		{
			if (id_setConfig_Ljava_util_Hashtable_ == IntPtr.Zero)
				id_setConfig_Ljava_util_Hashtable_ = JNIEnv.GetMethodID (class_ref, "setConfig", "(Ljava/util/Hashtable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setConfig_Ljava_util_Hashtable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConfig", "(Ljava/util/Hashtable;)V"), new JValue (p0));
		}

		static Delegate cb_setConfig_Ljava_util_Properties_;
#pragma warning disable 0169
		static Delegate GetSetConfig_Ljava_util_Properties_Handler ()
		{
			if (cb_setConfig_Ljava_util_Properties_ == null)
				cb_setConfig_Ljava_util_Properties_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConfig_Ljava_util_Properties_);
			return cb_setConfig_Ljava_util_Properties_;
		}

		static void n_SetConfig_Ljava_util_Properties_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Properties p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Properties> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetConfig (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setConfig_Ljava_util_Properties_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setConfig' and count(parameter)=1 and parameter[1][@type='java.util.Properties']]"
		[Register ("setConfig", "(Ljava/util/Properties;)V", "GetSetConfig_Ljava_util_Properties_Handler")]
		public virtual void SetConfig (global::Java.Util.Properties p0)
		{
			if (id_setConfig_Ljava_util_Properties_ == IntPtr.Zero)
				id_setConfig_Ljava_util_Properties_ = JNIEnv.GetMethodID (class_ref, "setConfig", "(Ljava/util/Properties;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setConfig_Ljava_util_Properties_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConfig", "(Ljava/util/Properties;)V"), new JValue (p0));
		}

		static Delegate cb_setDaemonThread_Z;
#pragma warning disable 0169
		static Delegate GetSetDaemonThread_ZHandler ()
		{
			if (cb_setDaemonThread_Z == null)
				cb_setDaemonThread_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDaemonThread_Z);
			return cb_setDaemonThread_Z;
		}

		static void n_SetDaemonThread_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDaemonThread (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDaemonThread_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setDaemonThread' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDaemonThread", "(Z)V", "GetSetDaemonThread_ZHandler")]
		public virtual void SetDaemonThread (bool p0)
		{
			if (id_setDaemonThread_Z == IntPtr.Zero)
				id_setDaemonThread_Z = JNIEnv.GetMethodID (class_ref, "setDaemonThread", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setDaemonThread_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDaemonThread", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setIdentityRepository_Lcom_jcraft_jsch_IdentityRepository_;
#pragma warning disable 0169
		static Delegate GetSetIdentityRepository_Lcom_jcraft_jsch_IdentityRepository_Handler ()
		{
			if (cb_setIdentityRepository_Lcom_jcraft_jsch_IdentityRepository_ == null)
				cb_setIdentityRepository_Lcom_jcraft_jsch_IdentityRepository_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIdentityRepository_Lcom_jcraft_jsch_IdentityRepository_);
			return cb_setIdentityRepository_Lcom_jcraft_jsch_IdentityRepository_;
		}

		static void n_SetIdentityRepository_Lcom_jcraft_jsch_IdentityRepository_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.IIdentityRepository p0 = (global::Com.Jcraft.Jsch.IIdentityRepository)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IIdentityRepository> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetIdentityRepository (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIdentityRepository_Lcom_jcraft_jsch_IdentityRepository_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setIdentityRepository' and count(parameter)=1 and parameter[1][@type='com.jcraft.jsch.IdentityRepository']]"
		[Register ("setIdentityRepository", "(Lcom/jcraft/jsch/IdentityRepository;)V", "GetSetIdentityRepository_Lcom_jcraft_jsch_IdentityRepository_Handler")]
		public virtual void SetIdentityRepository (global::Com.Jcraft.Jsch.IIdentityRepository p0)
		{
			if (id_setIdentityRepository_Lcom_jcraft_jsch_IdentityRepository_ == IntPtr.Zero)
				id_setIdentityRepository_Lcom_jcraft_jsch_IdentityRepository_ = JNIEnv.GetMethodID (class_ref, "setIdentityRepository", "(Lcom/jcraft/jsch/IdentityRepository;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setIdentityRepository_Lcom_jcraft_jsch_IdentityRepository_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIdentityRepository", "(Lcom/jcraft/jsch/IdentityRepository;)V"), new JValue (p0));
		}

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
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetInputStream (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInputStream_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setInputStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("setInputStream", "(Ljava/io/InputStream;)V", "GetSetInputStream_Ljava_io_InputStream_Handler")]
		public virtual void SetInputStream (global::System.IO.Stream p0)
		{
			if (id_setInputStream_Ljava_io_InputStream_ == IntPtr.Zero)
				id_setInputStream_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "setInputStream", "(Ljava/io/InputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setInputStream_Ljava_io_InputStream_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInputStream", "(Ljava/io/InputStream;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

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
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOutputStream (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOutputStream_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setOutputStream' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("setOutputStream", "(Ljava/io/OutputStream;)V", "GetSetOutputStream_Ljava_io_OutputStream_Handler")]
		public virtual void SetOutputStream (global::System.IO.Stream p0)
		{
			if (id_setOutputStream_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_setOutputStream_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "setOutputStream", "(Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOutputStream_Ljava_io_OutputStream_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOutputStream", "(Ljava/io/OutputStream;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setPassword_arrayB;
#pragma warning disable 0169
		static Delegate GetSetPassword_arrayBHandler ()
		{
			if (cb_setPassword_arrayB == null)
				cb_setPassword_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPassword_arrayB);
			return cb_setPassword_arrayB;
		}

		static void n_SetPassword_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetPassword (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPassword_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setPassword' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setPassword", "([B)V", "GetSetPassword_arrayBHandler")]
		public virtual void SetPassword (byte[] p0)
		{
			if (id_setPassword_arrayB == IntPtr.Zero)
				id_setPassword_arrayB = JNIEnv.GetMethodID (class_ref, "setPassword", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPassword_arrayB, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPassword", "([B)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setPassword_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPassword_Ljava_lang_String_Handler ()
		{
			if (cb_setPassword_Ljava_lang_String_ == null)
				cb_setPassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPassword_Ljava_lang_String_);
			return cb_setPassword_Ljava_lang_String_;
		}

		static void n_SetPassword_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPassword (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPassword_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPassword", "(Ljava/lang/String;)V", "GetSetPassword_Ljava_lang_String_Handler")]
		public virtual void SetPassword (string p0)
		{
			if (id_setPassword_Ljava_lang_String_ == IntPtr.Zero)
				id_setPassword_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPassword", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPassword_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPassword", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setPortForwardingL_ILjava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetPortForwardingL_ILjava_lang_String_IHandler ()
		{
			if (cb_setPortForwardingL_ILjava_lang_String_I == null)
				cb_setPortForwardingL_ILjava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int, int>) n_SetPortForwardingL_ILjava_lang_String_I);
			return cb_setPortForwardingL_ILjava_lang_String_I;
		}

		static int n_SetPortForwardingL_ILjava_lang_String_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetPortForwardingL (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setPortForwardingL_ILjava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setPortForwardingL' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("setPortForwardingL", "(ILjava/lang/String;I)I", "GetSetPortForwardingL_ILjava_lang_String_IHandler")]
		public virtual int SetPortForwardingL (int p0, string p1, int p2)
		{
			if (id_setPortForwardingL_ILjava_lang_String_I == IntPtr.Zero)
				id_setPortForwardingL_ILjava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setPortForwardingL", "(ILjava/lang/String;I)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_setPortForwardingL_ILjava_lang_String_I, new JValue (p0), new JValue (native_p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPortForwardingL", "(ILjava/lang/String;I)I"), new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_setPortForwardingL_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPortForwardingL_Ljava_lang_String_Handler ()
		{
			if (cb_setPortForwardingL_Ljava_lang_String_ == null)
				cb_setPortForwardingL_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_SetPortForwardingL_Ljava_lang_String_);
			return cb_setPortForwardingL_Ljava_lang_String_;
		}

		static int n_SetPortForwardingL_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetPortForwardingL (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setPortForwardingL_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setPortForwardingL' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPortForwardingL", "(Ljava/lang/String;)I", "GetSetPortForwardingL_Ljava_lang_String_Handler")]
		public virtual int SetPortForwardingL (string p0)
		{
			if (id_setPortForwardingL_Ljava_lang_String_ == IntPtr.Zero)
				id_setPortForwardingL_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPortForwardingL", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_setPortForwardingL_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPortForwardingL", "(Ljava/lang/String;)I"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setPortForwardingL_Ljava_lang_String_ILjava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetPortForwardingL_Ljava_lang_String_ILjava_lang_String_IHandler ()
		{
			if (cb_setPortForwardingL_Ljava_lang_String_ILjava_lang_String_I == null)
				cb_setPortForwardingL_Ljava_lang_String_ILjava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, int, int>) n_SetPortForwardingL_Ljava_lang_String_ILjava_lang_String_I);
			return cb_setPortForwardingL_Ljava_lang_String_ILjava_lang_String_I;
		}

		static int n_SetPortForwardingL_Ljava_lang_String_ILjava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetPortForwardingL (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setPortForwardingL_Ljava_lang_String_ILjava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setPortForwardingL' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register ("setPortForwardingL", "(Ljava/lang/String;ILjava/lang/String;I)I", "GetSetPortForwardingL_Ljava_lang_String_ILjava_lang_String_IHandler")]
		public virtual int SetPortForwardingL (string p0, int p1, string p2, int p3)
		{
			if (id_setPortForwardingL_Ljava_lang_String_ILjava_lang_String_I == IntPtr.Zero)
				id_setPortForwardingL_Ljava_lang_String_ILjava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setPortForwardingL", "(Ljava/lang/String;ILjava/lang/String;I)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_setPortForwardingL_Ljava_lang_String_ILjava_lang_String_I, new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPortForwardingL", "(Ljava/lang/String;ILjava/lang/String;I)I"), new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_setPortForwardingL_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_ServerSocketFactory_;
#pragma warning disable 0169
		static Delegate GetSetPortForwardingL_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_ServerSocketFactory_Handler ()
		{
			if (cb_setPortForwardingL_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_ServerSocketFactory_ == null)
				cb_setPortForwardingL_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_ServerSocketFactory_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, int, IntPtr, int>) n_SetPortForwardingL_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_ServerSocketFactory_);
			return cb_setPortForwardingL_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_ServerSocketFactory_;
		}

		static int n_SetPortForwardingL_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_ServerSocketFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3, IntPtr native_p4)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.IServerSocketFactory p4 = (global::Com.Jcraft.Jsch.IServerSocketFactory)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IServerSocketFactory> (native_p4, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetPortForwardingL (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setPortForwardingL_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_ServerSocketFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setPortForwardingL' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='com.jcraft.jsch.ServerSocketFactory']]"
		[Register ("setPortForwardingL", "(Ljava/lang/String;ILjava/lang/String;ILcom/jcraft/jsch/ServerSocketFactory;)I", "GetSetPortForwardingL_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_ServerSocketFactory_Handler")]
		public virtual int SetPortForwardingL (string p0, int p1, string p2, int p3, global::Com.Jcraft.Jsch.IServerSocketFactory p4)
		{
			if (id_setPortForwardingL_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_ServerSocketFactory_ == IntPtr.Zero)
				id_setPortForwardingL_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_ServerSocketFactory_ = JNIEnv.GetMethodID (class_ref, "setPortForwardingL", "(Ljava/lang/String;ILjava/lang/String;ILcom/jcraft/jsch/ServerSocketFactory;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_setPortForwardingL_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_ServerSocketFactory_, new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (p3), new JValue (p4));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPortForwardingL", "(Ljava/lang/String;ILjava/lang/String;ILcom/jcraft/jsch/ServerSocketFactory;)I"), new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_setPortForwardingL_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_ServerSocketFactory_I;
#pragma warning disable 0169
		static Delegate GetSetPortForwardingL_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_ServerSocketFactory_IHandler ()
		{
			if (cb_setPortForwardingL_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_ServerSocketFactory_I == null)
				cb_setPortForwardingL_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_ServerSocketFactory_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, int, IntPtr, int, int>) n_SetPortForwardingL_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_ServerSocketFactory_I);
			return cb_setPortForwardingL_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_ServerSocketFactory_I;
		}

		static int n_SetPortForwardingL_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_ServerSocketFactory_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3, IntPtr native_p4, int p5)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.IServerSocketFactory p4 = (global::Com.Jcraft.Jsch.IServerSocketFactory)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IServerSocketFactory> (native_p4, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetPortForwardingL (p0, p1, p2, p3, p4, p5);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setPortForwardingL_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_ServerSocketFactory_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setPortForwardingL' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='com.jcraft.jsch.ServerSocketFactory'] and parameter[6][@type='int']]"
		[Register ("setPortForwardingL", "(Ljava/lang/String;ILjava/lang/String;ILcom/jcraft/jsch/ServerSocketFactory;I)I", "GetSetPortForwardingL_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_ServerSocketFactory_IHandler")]
		public virtual int SetPortForwardingL (string p0, int p1, string p2, int p3, global::Com.Jcraft.Jsch.IServerSocketFactory p4, int p5)
		{
			if (id_setPortForwardingL_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_ServerSocketFactory_I == IntPtr.Zero)
				id_setPortForwardingL_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_ServerSocketFactory_I = JNIEnv.GetMethodID (class_ref, "setPortForwardingL", "(Ljava/lang/String;ILjava/lang/String;ILcom/jcraft/jsch/ServerSocketFactory;I)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_setPortForwardingL_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_ServerSocketFactory_I, new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (p3), new JValue (p4), new JValue (p5));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPortForwardingL", "(Ljava/lang/String;ILjava/lang/String;ILcom/jcraft/jsch/ServerSocketFactory;I)I"), new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (p3), new JValue (p4), new JValue (p5));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_setPortForwardingR_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPortForwardingR_ILjava_lang_String_Handler ()
		{
			if (cb_setPortForwardingR_ILjava_lang_String_ == null)
				cb_setPortForwardingR_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetPortForwardingR_ILjava_lang_String_);
			return cb_setPortForwardingR_ILjava_lang_String_;
		}

		static void n_SetPortForwardingR_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetPortForwardingR (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setPortForwardingR_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setPortForwardingR' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("setPortForwardingR", "(ILjava/lang/String;)V", "GetSetPortForwardingR_ILjava_lang_String_Handler")]
		public virtual void SetPortForwardingR (int p0, string p1)
		{
			if (id_setPortForwardingR_ILjava_lang_String_ == IntPtr.Zero)
				id_setPortForwardingR_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPortForwardingR", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPortForwardingR_ILjava_lang_String_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPortForwardingR", "(ILjava/lang/String;)V"), new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_setPortForwardingR_ILjava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetPortForwardingR_ILjava_lang_String_IHandler ()
		{
			if (cb_setPortForwardingR_ILjava_lang_String_I == null)
				cb_setPortForwardingR_ILjava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, int>) n_SetPortForwardingR_ILjava_lang_String_I);
			return cb_setPortForwardingR_ILjava_lang_String_I;
		}

		static void n_SetPortForwardingR_ILjava_lang_String_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetPortForwardingR (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setPortForwardingR_ILjava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setPortForwardingR' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("setPortForwardingR", "(ILjava/lang/String;I)V", "GetSetPortForwardingR_ILjava_lang_String_IHandler")]
		public virtual void SetPortForwardingR (int p0, string p1, int p2)
		{
			if (id_setPortForwardingR_ILjava_lang_String_I == IntPtr.Zero)
				id_setPortForwardingR_ILjava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setPortForwardingR", "(ILjava/lang/String;I)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPortForwardingR_ILjava_lang_String_I, new JValue (p0), new JValue (native_p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPortForwardingR", "(ILjava/lang/String;I)V"), new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_setPortForwardingR_ILjava_lang_String_ILcom_jcraft_jsch_SocketFactory_;
#pragma warning disable 0169
		static Delegate GetSetPortForwardingR_ILjava_lang_String_ILcom_jcraft_jsch_SocketFactory_Handler ()
		{
			if (cb_setPortForwardingR_ILjava_lang_String_ILcom_jcraft_jsch_SocketFactory_ == null)
				cb_setPortForwardingR_ILjava_lang_String_ILcom_jcraft_jsch_SocketFactory_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, int, IntPtr>) n_SetPortForwardingR_ILjava_lang_String_ILcom_jcraft_jsch_SocketFactory_);
			return cb_setPortForwardingR_ILjava_lang_String_ILcom_jcraft_jsch_SocketFactory_;
		}

		static void n_SetPortForwardingR_ILjava_lang_String_ILcom_jcraft_jsch_SocketFactory_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2, IntPtr native_p3)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.ISocketFactory p3 = (global::Com.Jcraft.Jsch.ISocketFactory)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISocketFactory> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SetPortForwardingR (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_setPortForwardingR_ILjava_lang_String_ILcom_jcraft_jsch_SocketFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setPortForwardingR' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='com.jcraft.jsch.SocketFactory']]"
		[Register ("setPortForwardingR", "(ILjava/lang/String;ILcom/jcraft/jsch/SocketFactory;)V", "GetSetPortForwardingR_ILjava_lang_String_ILcom_jcraft_jsch_SocketFactory_Handler")]
		public virtual void SetPortForwardingR (int p0, string p1, int p2, global::Com.Jcraft.Jsch.ISocketFactory p3)
		{
			if (id_setPortForwardingR_ILjava_lang_String_ILcom_jcraft_jsch_SocketFactory_ == IntPtr.Zero)
				id_setPortForwardingR_ILjava_lang_String_ILcom_jcraft_jsch_SocketFactory_ = JNIEnv.GetMethodID (class_ref, "setPortForwardingR", "(ILjava/lang/String;ILcom/jcraft/jsch/SocketFactory;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPortForwardingR_ILjava_lang_String_ILcom_jcraft_jsch_SocketFactory_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPortForwardingR", "(ILjava/lang/String;ILcom/jcraft/jsch/SocketFactory;)V"), new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_setPortForwardingR_ILjava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetPortForwardingR_ILjava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_setPortForwardingR_ILjava_lang_String_arrayLjava_lang_Object_ == null)
				cb_setPortForwardingR_ILjava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SetPortForwardingR_ILjava_lang_String_arrayLjava_lang_Object_);
			return cb_setPortForwardingR_ILjava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_SetPortForwardingR_ILjava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.SetPortForwardingR (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_setPortForwardingR_ILjava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setPortForwardingR' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object[]']]"
		[Register ("setPortForwardingR", "(ILjava/lang/String;[Ljava/lang/Object;)V", "GetSetPortForwardingR_ILjava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual void SetPortForwardingR (int p0, string p1, global::Java.Lang.Object[] p2)
		{
			if (id_setPortForwardingR_ILjava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_setPortForwardingR_ILjava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setPortForwardingR", "(ILjava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPortForwardingR_ILjava_lang_String_arrayLjava_lang_Object_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPortForwardingR", "(ILjava/lang/String;[Ljava/lang/Object;)V"), new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_setPortForwardingR_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPortForwardingR_Ljava_lang_String_Handler ()
		{
			if (cb_setPortForwardingR_Ljava_lang_String_ == null)
				cb_setPortForwardingR_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_SetPortForwardingR_Ljava_lang_String_);
			return cb_setPortForwardingR_Ljava_lang_String_;
		}

		static int n_SetPortForwardingR_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetPortForwardingR (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setPortForwardingR_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setPortForwardingR' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPortForwardingR", "(Ljava/lang/String;)I", "GetSetPortForwardingR_Ljava_lang_String_Handler")]
		public virtual int SetPortForwardingR (string p0)
		{
			if (id_setPortForwardingR_Ljava_lang_String_ == IntPtr.Zero)
				id_setPortForwardingR_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPortForwardingR", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_setPortForwardingR_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPortForwardingR", "(Ljava/lang/String;)I"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setPortForwardingR_Ljava_lang_String_ILjava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetPortForwardingR_Ljava_lang_String_ILjava_lang_String_IHandler ()
		{
			if (cb_setPortForwardingR_Ljava_lang_String_ILjava_lang_String_I == null)
				cb_setPortForwardingR_Ljava_lang_String_ILjava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, int>) n_SetPortForwardingR_Ljava_lang_String_ILjava_lang_String_I);
			return cb_setPortForwardingR_Ljava_lang_String_ILjava_lang_String_I;
		}

		static void n_SetPortForwardingR_Ljava_lang_String_ILjava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetPortForwardingR (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_setPortForwardingR_Ljava_lang_String_ILjava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setPortForwardingR' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register ("setPortForwardingR", "(Ljava/lang/String;ILjava/lang/String;I)V", "GetSetPortForwardingR_Ljava_lang_String_ILjava_lang_String_IHandler")]
		public virtual void SetPortForwardingR (string p0, int p1, string p2, int p3)
		{
			if (id_setPortForwardingR_Ljava_lang_String_ILjava_lang_String_I == IntPtr.Zero)
				id_setPortForwardingR_Ljava_lang_String_ILjava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setPortForwardingR", "(Ljava/lang/String;ILjava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPortForwardingR_Ljava_lang_String_ILjava_lang_String_I, new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPortForwardingR", "(Ljava/lang/String;ILjava/lang/String;I)V"), new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_setPortForwardingR_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_SocketFactory_;
#pragma warning disable 0169
		static Delegate GetSetPortForwardingR_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_SocketFactory_Handler ()
		{
			if (cb_setPortForwardingR_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_SocketFactory_ == null)
				cb_setPortForwardingR_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_SocketFactory_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, int, IntPtr>) n_SetPortForwardingR_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_SocketFactory_);
			return cb_setPortForwardingR_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_SocketFactory_;
		}

		static void n_SetPortForwardingR_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_SocketFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3, IntPtr native_p4)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.ISocketFactory p4 = (global::Com.Jcraft.Jsch.ISocketFactory)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISocketFactory> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.SetPortForwardingR (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_setPortForwardingR_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_SocketFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setPortForwardingR' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='com.jcraft.jsch.SocketFactory']]"
		[Register ("setPortForwardingR", "(Ljava/lang/String;ILjava/lang/String;ILcom/jcraft/jsch/SocketFactory;)V", "GetSetPortForwardingR_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_SocketFactory_Handler")]
		public virtual void SetPortForwardingR (string p0, int p1, string p2, int p3, global::Com.Jcraft.Jsch.ISocketFactory p4)
		{
			if (id_setPortForwardingR_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_SocketFactory_ == IntPtr.Zero)
				id_setPortForwardingR_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_SocketFactory_ = JNIEnv.GetMethodID (class_ref, "setPortForwardingR", "(Ljava/lang/String;ILjava/lang/String;ILcom/jcraft/jsch/SocketFactory;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPortForwardingR_Ljava_lang_String_ILjava_lang_String_ILcom_jcraft_jsch_SocketFactory_, new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (p3), new JValue (p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPortForwardingR", "(Ljava/lang/String;ILjava/lang/String;ILcom/jcraft/jsch/SocketFactory;)V"), new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_setPortForwardingR_Ljava_lang_String_ILjava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetPortForwardingR_Ljava_lang_String_ILjava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_setPortForwardingR_Ljava_lang_String_ILjava_lang_String_arrayLjava_lang_Object_ == null)
				cb_setPortForwardingR_Ljava_lang_String_ILjava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SetPortForwardingR_Ljava_lang_String_ILjava_lang_String_arrayLjava_lang_Object_);
			return cb_setPortForwardingR_Ljava_lang_String_ILjava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_SetPortForwardingR_Ljava_lang_String_ILjava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p3 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.SetPortForwardingR (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		static IntPtr id_setPortForwardingR_Ljava_lang_String_ILjava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setPortForwardingR' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]']]"
		[Register ("setPortForwardingR", "(Ljava/lang/String;ILjava/lang/String;[Ljava/lang/Object;)V", "GetSetPortForwardingR_Ljava_lang_String_ILjava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual void SetPortForwardingR (string p0, int p1, string p2, global::Java.Lang.Object[] p3)
		{
			if (id_setPortForwardingR_Ljava_lang_String_ILjava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_setPortForwardingR_Ljava_lang_String_ILjava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setPortForwardingR", "(Ljava/lang/String;ILjava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPortForwardingR_Ljava_lang_String_ILjava_lang_String_arrayLjava_lang_Object_, new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPortForwardingR", "(Ljava/lang/String;ILjava/lang/String;[Ljava/lang/Object;)V"), new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_setProxy_Lcom_jcraft_jsch_Proxy_;
#pragma warning disable 0169
		static Delegate GetSetProxy_Lcom_jcraft_jsch_Proxy_Handler ()
		{
			if (cb_setProxy_Lcom_jcraft_jsch_Proxy_ == null)
				cb_setProxy_Lcom_jcraft_jsch_Proxy_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProxy_Lcom_jcraft_jsch_Proxy_);
			return cb_setProxy_Lcom_jcraft_jsch_Proxy_;
		}

		static void n_SetProxy_Lcom_jcraft_jsch_Proxy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.IProxy p0 = (global::Com.Jcraft.Jsch.IProxy)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IProxy> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetProxy (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setProxy_Lcom_jcraft_jsch_Proxy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setProxy' and count(parameter)=1 and parameter[1][@type='com.jcraft.jsch.Proxy']]"
		[Register ("setProxy", "(Lcom/jcraft/jsch/Proxy;)V", "GetSetProxy_Lcom_jcraft_jsch_Proxy_Handler")]
		public virtual void SetProxy (global::Com.Jcraft.Jsch.IProxy p0)
		{
			if (id_setProxy_Lcom_jcraft_jsch_Proxy_ == IntPtr.Zero)
				id_setProxy_Lcom_jcraft_jsch_Proxy_ = JNIEnv.GetMethodID (class_ref, "setProxy", "(Lcom/jcraft/jsch/Proxy;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setProxy_Lcom_jcraft_jsch_Proxy_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProxy", "(Lcom/jcraft/jsch/Proxy;)V"), new JValue (p0));
		}

		static Delegate cb_setSocketFactory_Lcom_jcraft_jsch_SocketFactory_;
#pragma warning disable 0169
		static Delegate GetSetSocketFactory_Lcom_jcraft_jsch_SocketFactory_Handler ()
		{
			if (cb_setSocketFactory_Lcom_jcraft_jsch_SocketFactory_ == null)
				cb_setSocketFactory_Lcom_jcraft_jsch_SocketFactory_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSocketFactory_Lcom_jcraft_jsch_SocketFactory_);
			return cb_setSocketFactory_Lcom_jcraft_jsch_SocketFactory_;
		}

		static void n_SetSocketFactory_Lcom_jcraft_jsch_SocketFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.ISocketFactory p0 = (global::Com.Jcraft.Jsch.ISocketFactory)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISocketFactory> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSocketFactory (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSocketFactory_Lcom_jcraft_jsch_SocketFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setSocketFactory' and count(parameter)=1 and parameter[1][@type='com.jcraft.jsch.SocketFactory']]"
		[Register ("setSocketFactory", "(Lcom/jcraft/jsch/SocketFactory;)V", "GetSetSocketFactory_Lcom_jcraft_jsch_SocketFactory_Handler")]
		public virtual void SetSocketFactory (global::Com.Jcraft.Jsch.ISocketFactory p0)
		{
			if (id_setSocketFactory_Lcom_jcraft_jsch_SocketFactory_ == IntPtr.Zero)
				id_setSocketFactory_Lcom_jcraft_jsch_SocketFactory_ = JNIEnv.GetMethodID (class_ref, "setSocketFactory", "(Lcom/jcraft/jsch/SocketFactory;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setSocketFactory_Lcom_jcraft_jsch_SocketFactory_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSocketFactory", "(Lcom/jcraft/jsch/SocketFactory;)V"), new JValue (p0));
		}

		static Delegate cb_setX11Cookie_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetX11Cookie_Ljava_lang_String_Handler ()
		{
			if (cb_setX11Cookie_Ljava_lang_String_ == null)
				cb_setX11Cookie_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetX11Cookie_Ljava_lang_String_);
			return cb_setX11Cookie_Ljava_lang_String_;
		}

		static void n_SetX11Cookie_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetX11Cookie (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setX11Cookie_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setX11Cookie' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setX11Cookie", "(Ljava/lang/String;)V", "GetSetX11Cookie_Ljava_lang_String_Handler")]
		public virtual void SetX11Cookie (string p0)
		{
			if (id_setX11Cookie_Ljava_lang_String_ == IntPtr.Zero)
				id_setX11Cookie_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setX11Cookie", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setX11Cookie_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setX11Cookie", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setX11Host_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetX11Host_Ljava_lang_String_Handler ()
		{
			if (cb_setX11Host_Ljava_lang_String_ == null)
				cb_setX11Host_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetX11Host_Ljava_lang_String_);
			return cb_setX11Host_Ljava_lang_String_;
		}

		static void n_SetX11Host_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetX11Host (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setX11Host_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setX11Host' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setX11Host", "(Ljava/lang/String;)V", "GetSetX11Host_Ljava_lang_String_Handler")]
		public virtual void SetX11Host (string p0)
		{
			if (id_setX11Host_Ljava_lang_String_ == IntPtr.Zero)
				id_setX11Host_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setX11Host", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setX11Host_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setX11Host", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setX11Port_I;
#pragma warning disable 0169
		static Delegate GetSetX11Port_IHandler ()
		{
			if (cb_setX11Port_I == null)
				cb_setX11Port_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetX11Port_I);
			return cb_setX11Port_I;
		}

		static void n_SetX11Port_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetX11Port (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setX11Port_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='setX11Port' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setX11Port", "(I)V", "GetSetX11Port_IHandler")]
		public virtual void SetX11Port (int p0)
		{
			if (id_setX11Port_I == IntPtr.Zero)
				id_setX11Port_I = JNIEnv.GetMethodID (class_ref, "setX11Port", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setX11Port_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setX11Port", "(I)V"), new JValue (p0));
		}

		static Delegate cb_write_Lcom_jcraft_jsch_Packet_;
#pragma warning disable 0169
		static Delegate GetWrite_Lcom_jcraft_jsch_Packet_Handler ()
		{
			if (cb_write_Lcom_jcraft_jsch_Packet_ == null)
				cb_write_Lcom_jcraft_jsch_Packet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Lcom_jcraft_jsch_Packet_);
			return cb_write_Lcom_jcraft_jsch_Packet_;
		}

		static void n_Write_Lcom_jcraft_jsch_Packet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Session __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.Packet p0 = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Packet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_Lcom_jcraft_jsch_Packet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Session']/method[@name='write' and count(parameter)=1 and parameter[1][@type='com.jcraft.jsch.Packet']]"
		[Register ("write", "(Lcom/jcraft/jsch/Packet;)V", "GetWrite_Lcom_jcraft_jsch_Packet_Handler")]
		public virtual void Write (global::Com.Jcraft.Jsch.Packet p0)
		{
			if (id_write_Lcom_jcraft_jsch_Packet_ == IntPtr.Zero)
				id_write_Lcom_jcraft_jsch_Packet_ = JNIEnv.GetMethodID (class_ref, "write", "(Lcom/jcraft/jsch/Packet;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_write_Lcom_jcraft_jsch_Packet_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Lcom/jcraft/jsch/Packet;)V"), new JValue (p0));
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='OpenSSHConfig']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/OpenSSHConfig", DoNotGenerateAcw=true)]
	public partial class OpenSSHConfig : global::Java.Lang.Object, global::Com.Jcraft.Jsch.IConfigRepository {


		public static class InterfaceConsts {

			// The following are fields from: com.jcraft.jsch.ConfigRepository

			static IntPtr defaultConfig_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='ConfigRepository']/field[@name='defaultConfig']"
			[Register ("defaultConfig")]
			public static global::Com.Jcraft.Jsch.IConfigRepositoryConfig DefaultConfig {
				get {
					if (defaultConfig_jfieldId == IntPtr.Zero)
						defaultConfig_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "defaultConfig", "Lcom/jcraft/jsch/ConfigRepository$Config;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, defaultConfig_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IConfigRepositoryConfig> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (defaultConfig_jfieldId == IntPtr.Zero)
						defaultConfig_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "defaultConfig", "Lcom/jcraft/jsch/ConfigRepository$Config;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, defaultConfig_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr nullConfig_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='ConfigRepository']/field[@name='nullConfig']"
			[Register ("nullConfig")]
			public static global::Com.Jcraft.Jsch.IConfigRepository NullConfig {
				get {
					if (nullConfig_jfieldId == IntPtr.Zero)
						nullConfig_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "nullConfig", "Lcom/jcraft/jsch/ConfigRepository;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, nullConfig_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IConfigRepository> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (nullConfig_jfieldId == IntPtr.Zero)
						nullConfig_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "nullConfig", "Lcom/jcraft/jsch/ConfigRepository;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, nullConfig_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='OpenSSHConfig.MyConfig']"
		[global::Android.Runtime.Register ("com/jcraft/jsch/OpenSSHConfig$MyConfig", DoNotGenerateAcw=true)]
		public partial class MyConfig : global::Java.Lang.Object, global::Com.Jcraft.Jsch.IConfigRepositoryConfig {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/jcraft/jsch/OpenSSHConfig$MyConfig", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MyConfig); }
			}

			protected MyConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getHostname;
#pragma warning disable 0169
			static Delegate GetGetHostnameHandler ()
			{
				if (cb_getHostname == null)
					cb_getHostname = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHostname);
				return cb_getHostname;
			}

			static IntPtr n_GetHostname (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Jcraft.Jsch.OpenSSHConfig.MyConfig __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.OpenSSHConfig.MyConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Hostname);
			}
#pragma warning restore 0169

			static IntPtr id_getHostname;
			public virtual string Hostname {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='OpenSSHConfig.MyConfig']/method[@name='getHostname' and count(parameter)=0]"
				[Register ("getHostname", "()Ljava/lang/String;", "GetGetHostnameHandler")]
				get {
					if (id_getHostname == IntPtr.Zero)
						id_getHostname = JNIEnv.GetMethodID (class_ref, "getHostname", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getHostname), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHostname", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Jcraft.Jsch.OpenSSHConfig.MyConfig __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.OpenSSHConfig.MyConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Port;
			}
#pragma warning restore 0169

			static IntPtr id_getPort;
			public virtual int Port {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='OpenSSHConfig.MyConfig']/method[@name='getPort' and count(parameter)=0]"
				[Register ("getPort", "()I", "GetGetPortHandler")]
				get {
					if (id_getPort == IntPtr.Zero)
						id_getPort = JNIEnv.GetMethodID (class_ref, "getPort", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getPort);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPort", "()I"));
				}
			}

			static Delegate cb_getUser;
#pragma warning disable 0169
			static Delegate GetGetUserHandler ()
			{
				if (cb_getUser == null)
					cb_getUser = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUser);
				return cb_getUser;
			}

			static IntPtr n_GetUser (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Jcraft.Jsch.OpenSSHConfig.MyConfig __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.OpenSSHConfig.MyConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.User);
			}
#pragma warning restore 0169

			static IntPtr id_getUser;
			public virtual string User {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='OpenSSHConfig.MyConfig']/method[@name='getUser' and count(parameter)=0]"
				[Register ("getUser", "()Ljava/lang/String;", "GetGetUserHandler")]
				get {
					if (id_getUser == IntPtr.Zero)
						id_getUser = JNIEnv.GetMethodID (class_ref, "getUser", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUser), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUser", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getValue_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetValue_Ljava_lang_String_Handler ()
			{
				if (cb_getValue_Ljava_lang_String_ == null)
					cb_getValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetValue_Ljava_lang_String_);
				return cb_getValue_Ljava_lang_String_;
			}

			static IntPtr n_GetValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Jcraft.Jsch.OpenSSHConfig.MyConfig __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.OpenSSHConfig.MyConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.GetValue (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getValue_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='OpenSSHConfig.MyConfig']/method[@name='getValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getValue", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetValue_Ljava_lang_String_Handler")]
			public virtual string GetValue (string p0)
			{
				if (id_getValue_Ljava_lang_String_ == IntPtr.Zero)
					id_getValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getValue", "(Ljava/lang/String;)Ljava/lang/String;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getValue_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_getValues_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetValues_Ljava_lang_String_Handler ()
			{
				if (cb_getValues_Ljava_lang_String_ == null)
					cb_getValues_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetValues_Ljava_lang_String_);
				return cb_getValues_Ljava_lang_String_;
			}

			static IntPtr n_GetValues_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Jcraft.Jsch.OpenSSHConfig.MyConfig __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.OpenSSHConfig.MyConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewArray (__this.GetValues (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getValues_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='OpenSSHConfig.MyConfig']/method[@name='getValues' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getValues", "(Ljava/lang/String;)[Ljava/lang/String;", "GetGetValues_Ljava_lang_String_Handler")]
			public virtual string[] GetValues (string p0)
			{
				if (id_getValues_Ljava_lang_String_ == IntPtr.Zero)
					id_getValues_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getValues", "(Ljava/lang/String;)[Ljava/lang/String;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				string[] __ret;
				if (GetType () == ThresholdType)
					__ret = (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getValues_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					__ret = (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValues", "(Ljava/lang/String;)[Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (string));
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/OpenSSHConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OpenSSHConfig); }
		}

		protected OpenSSHConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Jcraft.Jsch.OpenSSHConfig __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.OpenSSHConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConfig (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConfig_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='OpenSSHConfig']/method[@name='getConfig' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getConfig", "(Ljava/lang/String;)Lcom/jcraft/jsch/ConfigRepository$Config;", "GetGetConfig_Ljava_lang_String_Handler")]
		public virtual global::Com.Jcraft.Jsch.IConfigRepositoryConfig GetConfig (string p0)
		{
			if (id_getConfig_Ljava_lang_String_ == IntPtr.Zero)
				id_getConfig_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getConfig", "(Ljava/lang/String;)Lcom/jcraft/jsch/ConfigRepository$Config;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Jcraft.Jsch.IConfigRepositoryConfig __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IConfigRepositoryConfig> (JNIEnv.CallObjectMethod  (Handle, id_getConfig_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IConfigRepositoryConfig> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConfig", "(Ljava/lang/String;)Lcom/jcraft/jsch/ConfigRepository$Config;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_parse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='OpenSSHConfig']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)Lcom/jcraft/jsch/OpenSSHConfig;", "")]
		public static global::Com.Jcraft.Jsch.OpenSSHConfig Parse (string p0)
		{
			if (id_parse_Ljava_lang_String_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Ljava/lang/String;)Lcom/jcraft/jsch/OpenSSHConfig;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Jcraft.Jsch.OpenSSHConfig __ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.OpenSSHConfig> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_parseFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='OpenSSHConfig']/method[@name='parseFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseFile", "(Ljava/lang/String;)Lcom/jcraft/jsch/OpenSSHConfig;", "")]
		public static global::Com.Jcraft.Jsch.OpenSSHConfig ParseFile (string p0)
		{
			if (id_parseFile_Ljava_lang_String_ == IntPtr.Zero)
				id_parseFile_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseFile", "(Ljava/lang/String;)Lcom/jcraft/jsch/OpenSSHConfig;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Jcraft.Jsch.OpenSSHConfig __ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.OpenSSHConfig> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseFile_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}

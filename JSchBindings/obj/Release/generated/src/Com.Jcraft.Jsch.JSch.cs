using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/JSch", DoNotGenerateAcw=true)]
	public partial class JSch : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/field[@name='VERSION']"
		[Register ("VERSION")]
		public const string Version = (string) "0.1.51";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/JSch", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JSch); }
		}

		protected JSch (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/constructor[@name='JSch' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public JSch () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (JSch)) {
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

		static Delegate cb_getConfigRepository;
#pragma warning disable 0169
		static Delegate GetGetConfigRepositoryHandler ()
		{
			if (cb_getConfigRepository == null)
				cb_getConfigRepository = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConfigRepository);
			return cb_getConfigRepository;
		}

		static IntPtr n_GetConfigRepository (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.JSch __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.JSch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConfigRepository);
		}
#pragma warning restore 0169

		static Delegate cb_setConfigRepository_Lcom_jcraft_jsch_ConfigRepository_;
#pragma warning disable 0169
		static Delegate GetSetConfigRepository_Lcom_jcraft_jsch_ConfigRepository_Handler ()
		{
			if (cb_setConfigRepository_Lcom_jcraft_jsch_ConfigRepository_ == null)
				cb_setConfigRepository_Lcom_jcraft_jsch_ConfigRepository_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConfigRepository_Lcom_jcraft_jsch_ConfigRepository_);
			return cb_setConfigRepository_Lcom_jcraft_jsch_ConfigRepository_;
		}

		static void n_SetConfigRepository_Lcom_jcraft_jsch_ConfigRepository_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.JSch __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.JSch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.IConfigRepository p0 = (global::Com.Jcraft.Jsch.IConfigRepository)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IConfigRepository> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConfigRepository = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getConfigRepository;
		static IntPtr id_setConfigRepository_Lcom_jcraft_jsch_ConfigRepository_;
		public virtual global::Com.Jcraft.Jsch.IConfigRepository ConfigRepository {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='getConfigRepository' and count(parameter)=0]"
			[Register ("getConfigRepository", "()Lcom/jcraft/jsch/ConfigRepository;", "GetGetConfigRepositoryHandler")]
			get {
				if (id_getConfigRepository == IntPtr.Zero)
					id_getConfigRepository = JNIEnv.GetMethodID (class_ref, "getConfigRepository", "()Lcom/jcraft/jsch/ConfigRepository;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IConfigRepository> (JNIEnv.CallObjectMethod  (Handle, id_getConfigRepository), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IConfigRepository> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConfigRepository", "()Lcom/jcraft/jsch/ConfigRepository;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='setConfigRepository' and count(parameter)=1 and parameter[1][@type='com.jcraft.jsch.ConfigRepository']]"
			[Register ("setConfigRepository", "(Lcom/jcraft/jsch/ConfigRepository;)V", "GetSetConfigRepository_Lcom_jcraft_jsch_ConfigRepository_Handler")]
			set {
				if (id_setConfigRepository_Lcom_jcraft_jsch_ConfigRepository_ == IntPtr.Zero)
					id_setConfigRepository_Lcom_jcraft_jsch_ConfigRepository_ = JNIEnv.GetMethodID (class_ref, "setConfigRepository", "(Lcom/jcraft/jsch/ConfigRepository;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setConfigRepository_Lcom_jcraft_jsch_ConfigRepository_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConfigRepository", "(Lcom/jcraft/jsch/ConfigRepository;)V"), new JValue (value));
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
			global::Com.Jcraft.Jsch.JSch __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.JSch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Jcraft.Jsch.JSch __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.JSch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.IHostKeyRepository p0 = (global::Com.Jcraft.Jsch.IHostKeyRepository)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IHostKeyRepository> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HostKeyRepository = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHostKeyRepository;
		static IntPtr id_setHostKeyRepository_Lcom_jcraft_jsch_HostKeyRepository_;
		public virtual global::Com.Jcraft.Jsch.IHostKeyRepository HostKeyRepository {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='getHostKeyRepository' and count(parameter)=0]"
			[Register ("getHostKeyRepository", "()Lcom/jcraft/jsch/HostKeyRepository;", "GetGetHostKeyRepositoryHandler")]
			get {
				if (id_getHostKeyRepository == IntPtr.Zero)
					id_getHostKeyRepository = JNIEnv.GetMethodID (class_ref, "getHostKeyRepository", "()Lcom/jcraft/jsch/HostKeyRepository;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IHostKeyRepository> (JNIEnv.CallObjectMethod  (Handle, id_getHostKeyRepository), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IHostKeyRepository> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHostKeyRepository", "()Lcom/jcraft/jsch/HostKeyRepository;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='setHostKeyRepository' and count(parameter)=1 and parameter[1][@type='com.jcraft.jsch.HostKeyRepository']]"
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

		static Delegate cb_getIdentityNames;
#pragma warning disable 0169
		static Delegate GetGetIdentityNamesHandler ()
		{
			if (cb_getIdentityNames == null)
				cb_getIdentityNames = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIdentityNames);
			return cb_getIdentityNames;
		}

		static IntPtr n_GetIdentityNames (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.JSch __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.JSch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IdentityNames);
		}
#pragma warning restore 0169

		static IntPtr id_getIdentityNames;
		public virtual global::Java.Util.Vector IdentityNames {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='getIdentityNames' and count(parameter)=0]"
			[Register ("getIdentityNames", "()Ljava/util/Vector;", "GetGetIdentityNamesHandler")]
			get {
				if (id_getIdentityNames == IntPtr.Zero)
					id_getIdentityNames = JNIEnv.GetMethodID (class_ref, "getIdentityNames", "()Ljava/util/Vector;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.Vector> (JNIEnv.CallObjectMethod  (Handle, id_getIdentityNames), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.Vector> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIdentityNames", "()Ljava/util/Vector;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getIdentityRepository;
#pragma warning disable 0169
		static Delegate GetGetIdentityRepositoryHandler ()
		{
			if (cb_getIdentityRepository == null)
				cb_getIdentityRepository = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIdentityRepository);
			return cb_getIdentityRepository;
		}

		static IntPtr n_GetIdentityRepository (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.JSch __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.JSch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IdentityRepository);
		}
#pragma warning restore 0169

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
			global::Com.Jcraft.Jsch.JSch __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.JSch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.IIdentityRepository p0 = (global::Com.Jcraft.Jsch.IIdentityRepository)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IIdentityRepository> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IdentityRepository = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIdentityRepository;
		static IntPtr id_setIdentityRepository_Lcom_jcraft_jsch_IdentityRepository_;
		public virtual global::Com.Jcraft.Jsch.IIdentityRepository IdentityRepository {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='getIdentityRepository' and count(parameter)=0]"
			[Register ("getIdentityRepository", "()Lcom/jcraft/jsch/IdentityRepository;", "GetGetIdentityRepositoryHandler")]
			get {
				if (id_getIdentityRepository == IntPtr.Zero)
					id_getIdentityRepository = JNIEnv.GetMethodID (class_ref, "getIdentityRepository", "()Lcom/jcraft/jsch/IdentityRepository;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IIdentityRepository> (JNIEnv.CallObjectMethod  (Handle, id_getIdentityRepository), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IIdentityRepository> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIdentityRepository", "()Lcom/jcraft/jsch/IdentityRepository;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='setIdentityRepository' and count(parameter)=1 and parameter[1][@type='com.jcraft.jsch.IdentityRepository']]"
			[Register ("setIdentityRepository", "(Lcom/jcraft/jsch/IdentityRepository;)V", "GetSetIdentityRepository_Lcom_jcraft_jsch_IdentityRepository_Handler")]
			set {
				if (id_setIdentityRepository_Lcom_jcraft_jsch_IdentityRepository_ == IntPtr.Zero)
					id_setIdentityRepository_Lcom_jcraft_jsch_IdentityRepository_ = JNIEnv.GetMethodID (class_ref, "setIdentityRepository", "(Lcom/jcraft/jsch/IdentityRepository;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setIdentityRepository_Lcom_jcraft_jsch_IdentityRepository_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIdentityRepository", "(Lcom/jcraft/jsch/IdentityRepository;)V"), new JValue (value));
			}
		}

		static Delegate cb_addIdentity_Lcom_jcraft_jsch_Identity_arrayB;
#pragma warning disable 0169
		static Delegate GetAddIdentity_Lcom_jcraft_jsch_Identity_arrayBHandler ()
		{
			if (cb_addIdentity_Lcom_jcraft_jsch_Identity_arrayB == null)
				cb_addIdentity_Lcom_jcraft_jsch_Identity_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddIdentity_Lcom_jcraft_jsch_Identity_arrayB);
			return cb_addIdentity_Lcom_jcraft_jsch_Identity_arrayB;
		}

		static void n_AddIdentity_Lcom_jcraft_jsch_Identity_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.JSch __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.JSch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.IIdentity p0 = (global::Com.Jcraft.Jsch.IIdentity)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IIdentity> (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.AddIdentity (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_addIdentity_Lcom_jcraft_jsch_Identity_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='addIdentity' and count(parameter)=2 and parameter[1][@type='com.jcraft.jsch.Identity'] and parameter[2][@type='byte[]']]"
		[Register ("addIdentity", "(Lcom/jcraft/jsch/Identity;[B)V", "GetAddIdentity_Lcom_jcraft_jsch_Identity_arrayBHandler")]
		public virtual void AddIdentity (global::Com.Jcraft.Jsch.IIdentity p0, byte[] p1)
		{
			if (id_addIdentity_Lcom_jcraft_jsch_Identity_arrayB == IntPtr.Zero)
				id_addIdentity_Lcom_jcraft_jsch_Identity_arrayB = JNIEnv.GetMethodID (class_ref, "addIdentity", "(Lcom/jcraft/jsch/Identity;[B)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addIdentity_Lcom_jcraft_jsch_Identity_arrayB, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addIdentity", "(Lcom/jcraft/jsch/Identity;[B)V"), new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_addIdentity_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddIdentity_Ljava_lang_String_Handler ()
		{
			if (cb_addIdentity_Ljava_lang_String_ == null)
				cb_addIdentity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddIdentity_Ljava_lang_String_);
			return cb_addIdentity_Ljava_lang_String_;
		}

		static void n_AddIdentity_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.JSch __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.JSch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddIdentity (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addIdentity_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='addIdentity' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addIdentity", "(Ljava/lang/String;)V", "GetAddIdentity_Ljava_lang_String_Handler")]
		public virtual void AddIdentity (string p0)
		{
			if (id_addIdentity_Ljava_lang_String_ == IntPtr.Zero)
				id_addIdentity_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addIdentity", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addIdentity_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addIdentity", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_addIdentity_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetAddIdentity_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_addIdentity_Ljava_lang_String_arrayB == null)
				cb_addIdentity_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddIdentity_Ljava_lang_String_arrayB);
			return cb_addIdentity_Ljava_lang_String_arrayB;
		}

		static void n_AddIdentity_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.JSch __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.JSch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.AddIdentity (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_addIdentity_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='addIdentity' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("addIdentity", "(Ljava/lang/String;[B)V", "GetAddIdentity_Ljava_lang_String_arrayBHandler")]
		public virtual void AddIdentity (string p0, byte[] p1)
		{
			if (id_addIdentity_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_addIdentity_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "addIdentity", "(Ljava/lang/String;[B)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addIdentity_Ljava_lang_String_arrayB, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addIdentity", "(Ljava/lang/String;[B)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_addIdentity_Ljava_lang_String_arrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetAddIdentity_Ljava_lang_String_arrayBarrayBarrayBHandler ()
		{
			if (cb_addIdentity_Ljava_lang_String_arrayBarrayBarrayB == null)
				cb_addIdentity_Ljava_lang_String_arrayBarrayBarrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddIdentity_Ljava_lang_String_arrayBarrayBarrayB);
			return cb_addIdentity_Ljava_lang_String_arrayBarrayBarrayB;
		}

		static void n_AddIdentity_Ljava_lang_String_arrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Jcraft.Jsch.JSch __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.JSch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.AddIdentity (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		static IntPtr id_addIdentity_Ljava_lang_String_arrayBarrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='addIdentity' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
		[Register ("addIdentity", "(Ljava/lang/String;[B[B[B)V", "GetAddIdentity_Ljava_lang_String_arrayBarrayBarrayBHandler")]
		public virtual void AddIdentity (string p0, byte[] p1, byte[] p2, byte[] p3)
		{
			if (id_addIdentity_Ljava_lang_String_arrayBarrayBarrayB == IntPtr.Zero)
				id_addIdentity_Ljava_lang_String_arrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "addIdentity", "(Ljava/lang/String;[B[B[B)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addIdentity_Ljava_lang_String_arrayBarrayBarrayB, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addIdentity", "(Ljava/lang/String;[B[B[B)V"), new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_addIdentity_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddIdentity_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addIdentity_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addIdentity_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddIdentity_Ljava_lang_String_Ljava_lang_String_);
			return cb_addIdentity_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddIdentity_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.JSch __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.JSch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddIdentity (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addIdentity_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='addIdentity' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addIdentity", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddIdentity_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void AddIdentity (string p0, string p1)
		{
			if (id_addIdentity_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addIdentity_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addIdentity", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addIdentity_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addIdentity", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_addIdentity_Ljava_lang_String_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetAddIdentity_Ljava_lang_String_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_addIdentity_Ljava_lang_String_Ljava_lang_String_arrayB == null)
				cb_addIdentity_Ljava_lang_String_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddIdentity_Ljava_lang_String_Ljava_lang_String_arrayB);
			return cb_addIdentity_Ljava_lang_String_Ljava_lang_String_arrayB;
		}

		static void n_AddIdentity_Ljava_lang_String_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Jcraft.Jsch.JSch __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.JSch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.AddIdentity (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_addIdentity_Ljava_lang_String_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='addIdentity' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
		[Register ("addIdentity", "(Ljava/lang/String;Ljava/lang/String;[B)V", "GetAddIdentity_Ljava_lang_String_Ljava_lang_String_arrayBHandler")]
		public virtual void AddIdentity (string p0, string p1, byte[] p2)
		{
			if (id_addIdentity_Ljava_lang_String_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_addIdentity_Ljava_lang_String_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "addIdentity", "(Ljava/lang/String;Ljava/lang/String;[B)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addIdentity_Ljava_lang_String_Ljava_lang_String_arrayB, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addIdentity", "(Ljava/lang/String;Ljava/lang/String;[B)V"), new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_addSession_Lcom_jcraft_jsch_Session_;
#pragma warning disable 0169
		static Delegate GetAddSession_Lcom_jcraft_jsch_Session_Handler ()
		{
			if (cb_addSession_Lcom_jcraft_jsch_Session_ == null)
				cb_addSession_Lcom_jcraft_jsch_Session_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddSession_Lcom_jcraft_jsch_Session_);
			return cb_addSession_Lcom_jcraft_jsch_Session_;
		}

		static void n_AddSession_Lcom_jcraft_jsch_Session_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.JSch __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.JSch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.Session p0 = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddSession (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addSession_Lcom_jcraft_jsch_Session_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='addSession' and count(parameter)=1 and parameter[1][@type='com.jcraft.jsch.Session']]"
		[Register ("addSession", "(Lcom/jcraft/jsch/Session;)V", "GetAddSession_Lcom_jcraft_jsch_Session_Handler")]
		protected virtual void AddSession (global::Com.Jcraft.Jsch.Session p0)
		{
			if (id_addSession_Lcom_jcraft_jsch_Session_ == IntPtr.Zero)
				id_addSession_Lcom_jcraft_jsch_Session_ = JNIEnv.GetMethodID (class_ref, "addSession", "(Lcom/jcraft/jsch/Session;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addSession_Lcom_jcraft_jsch_Session_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addSession", "(Lcom/jcraft/jsch/Session;)V"), new JValue (p0));
		}

		static IntPtr id_getConfig_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='getConfig' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getConfig", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string GetConfig (string p0)
		{
			if (id_getConfig_Ljava_lang_String_ == IntPtr.Zero)
				id_getConfig_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getConfig", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getConfig_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getSession_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSession_Ljava_lang_String_Handler ()
		{
			if (cb_getSession_Ljava_lang_String_ == null)
				cb_getSession_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSession_Ljava_lang_String_);
			return cb_getSession_Ljava_lang_String_;
		}

		static IntPtr n_GetSession_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.JSch __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.JSch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSession (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSession_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='getSession' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSession", "(Ljava/lang/String;)Lcom/jcraft/jsch/Session;", "GetGetSession_Ljava_lang_String_Handler")]
		public virtual global::Com.Jcraft.Jsch.Session GetSession (string p0)
		{
			if (id_getSession_Ljava_lang_String_ == IntPtr.Zero)
				id_getSession_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSession", "(Ljava/lang/String;)Lcom/jcraft/jsch/Session;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Jcraft.Jsch.Session __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (JNIEnv.CallObjectMethod  (Handle, id_getSession_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSession", "(Ljava/lang/String;)Lcom/jcraft/jsch/Session;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getSession_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSession_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getSession_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getSession_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSession_Ljava_lang_String_Ljava_lang_String_);
			return cb_getSession_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetSession_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.JSch __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.JSch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSession (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSession_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='getSession' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getSession", "(Ljava/lang/String;Ljava/lang/String;)Lcom/jcraft/jsch/Session;", "GetGetSession_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual global::Com.Jcraft.Jsch.Session GetSession (string p0, string p1)
		{
			if (id_getSession_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getSession_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSession", "(Ljava/lang/String;Ljava/lang/String;)Lcom/jcraft/jsch/Session;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			global::Com.Jcraft.Jsch.Session __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (JNIEnv.CallObjectMethod  (Handle, id_getSession_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSession", "(Ljava/lang/String;Ljava/lang/String;)Lcom/jcraft/jsch/Session;"), new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_getSession_Ljava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetSession_Ljava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_getSession_Ljava_lang_String_Ljava_lang_String_I == null)
				cb_getSession_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr>) n_GetSession_Ljava_lang_String_Ljava_lang_String_I);
			return cb_getSession_Ljava_lang_String_Ljava_lang_String_I;
		}

		static IntPtr n_GetSession_Ljava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Com.Jcraft.Jsch.JSch __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.JSch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSession (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSession_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='getSession' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("getSession", "(Ljava/lang/String;Ljava/lang/String;I)Lcom/jcraft/jsch/Session;", "GetGetSession_Ljava_lang_String_Ljava_lang_String_IHandler")]
		public virtual global::Com.Jcraft.Jsch.Session GetSession (string p0, string p1, int p2)
		{
			if (id_getSession_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_getSession_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "getSession", "(Ljava/lang/String;Ljava/lang/String;I)Lcom/jcraft/jsch/Session;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			global::Com.Jcraft.Jsch.Session __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (JNIEnv.CallObjectMethod  (Handle, id_getSession_Ljava_lang_String_Ljava_lang_String_I, new JValue (native_p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSession", "(Ljava/lang/String;Ljava/lang/String;I)Lcom/jcraft/jsch/Session;"), new JValue (native_p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_removeAllIdentity;
#pragma warning disable 0169
		static Delegate GetRemoveAllIdentityHandler ()
		{
			if (cb_removeAllIdentity == null)
				cb_removeAllIdentity = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAllIdentity);
			return cb_removeAllIdentity;
		}

		static void n_RemoveAllIdentity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.JSch __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.JSch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllIdentity ();
		}
#pragma warning restore 0169

		static IntPtr id_removeAllIdentity;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='removeAllIdentity' and count(parameter)=0]"
		[Register ("removeAllIdentity", "()V", "GetRemoveAllIdentityHandler")]
		public virtual void RemoveAllIdentity ()
		{
			if (id_removeAllIdentity == IntPtr.Zero)
				id_removeAllIdentity = JNIEnv.GetMethodID (class_ref, "removeAllIdentity", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeAllIdentity);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAllIdentity", "()V"));
		}

		static Delegate cb_removeIdentity_Lcom_jcraft_jsch_Identity_;
#pragma warning disable 0169
		static Delegate GetRemoveIdentity_Lcom_jcraft_jsch_Identity_Handler ()
		{
			if (cb_removeIdentity_Lcom_jcraft_jsch_Identity_ == null)
				cb_removeIdentity_Lcom_jcraft_jsch_Identity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveIdentity_Lcom_jcraft_jsch_Identity_);
			return cb_removeIdentity_Lcom_jcraft_jsch_Identity_;
		}

		static void n_RemoveIdentity_Lcom_jcraft_jsch_Identity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.JSch __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.JSch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.IIdentity p0 = (global::Com.Jcraft.Jsch.IIdentity)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IIdentity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveIdentity (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeIdentity_Lcom_jcraft_jsch_Identity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='removeIdentity' and count(parameter)=1 and parameter[1][@type='com.jcraft.jsch.Identity']]"
		[Register ("removeIdentity", "(Lcom/jcraft/jsch/Identity;)V", "GetRemoveIdentity_Lcom_jcraft_jsch_Identity_Handler")]
		public virtual void RemoveIdentity (global::Com.Jcraft.Jsch.IIdentity p0)
		{
			if (id_removeIdentity_Lcom_jcraft_jsch_Identity_ == IntPtr.Zero)
				id_removeIdentity_Lcom_jcraft_jsch_Identity_ = JNIEnv.GetMethodID (class_ref, "removeIdentity", "(Lcom/jcraft/jsch/Identity;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeIdentity_Lcom_jcraft_jsch_Identity_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeIdentity", "(Lcom/jcraft/jsch/Identity;)V"), new JValue (p0));
		}

		static Delegate cb_removeIdentity_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveIdentity_Ljava_lang_String_Handler ()
		{
			if (cb_removeIdentity_Ljava_lang_String_ == null)
				cb_removeIdentity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveIdentity_Ljava_lang_String_);
			return cb_removeIdentity_Ljava_lang_String_;
		}

		static void n_RemoveIdentity_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.JSch __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.JSch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveIdentity (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeIdentity_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='removeIdentity' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeIdentity", "(Ljava/lang/String;)V", "GetRemoveIdentity_Ljava_lang_String_Handler")]
		public virtual void RemoveIdentity (string p0)
		{
			if (id_removeIdentity_Ljava_lang_String_ == IntPtr.Zero)
				id_removeIdentity_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeIdentity", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeIdentity_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeIdentity", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_removeSession_Lcom_jcraft_jsch_Session_;
#pragma warning disable 0169
		static Delegate GetRemoveSession_Lcom_jcraft_jsch_Session_Handler ()
		{
			if (cb_removeSession_Lcom_jcraft_jsch_Session_ == null)
				cb_removeSession_Lcom_jcraft_jsch_Session_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveSession_Lcom_jcraft_jsch_Session_);
			return cb_removeSession_Lcom_jcraft_jsch_Session_;
		}

		static bool n_RemoveSession_Lcom_jcraft_jsch_Session_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.JSch __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.JSch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.Session p0 = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveSession (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeSession_Lcom_jcraft_jsch_Session_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='removeSession' and count(parameter)=1 and parameter[1][@type='com.jcraft.jsch.Session']]"
		[Register ("removeSession", "(Lcom/jcraft/jsch/Session;)Z", "GetRemoveSession_Lcom_jcraft_jsch_Session_Handler")]
		protected virtual bool RemoveSession (global::Com.Jcraft.Jsch.Session p0)
		{
			if (id_removeSession_Lcom_jcraft_jsch_Session_ == IntPtr.Zero)
				id_removeSession_Lcom_jcraft_jsch_Session_ = JNIEnv.GetMethodID (class_ref, "removeSession", "(Lcom/jcraft/jsch/Session;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_removeSession_Lcom_jcraft_jsch_Session_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeSession", "(Lcom/jcraft/jsch/Session;)Z"), new JValue (p0));
			return __ret;
		}

		static IntPtr id_setConfig_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='setConfig' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setConfig", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void SetConfig (string p0, string p1)
		{
			if (id_setConfig_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setConfig_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setConfig", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setConfig_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_setConfig_Ljava_util_Hashtable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='setConfig' and count(parameter)=1 and parameter[1][@type='java.util.Hashtable']]"
		[Register ("setConfig", "(Ljava/util/Hashtable;)V", "")]
		public static void SetConfig (global::Java.Util.Hashtable p0)
		{
			if (id_setConfig_Ljava_util_Hashtable_ == IntPtr.Zero)
				id_setConfig_Ljava_util_Hashtable_ = JNIEnv.GetStaticMethodID (class_ref, "setConfig", "(Ljava/util/Hashtable;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setConfig_Ljava_util_Hashtable_, new JValue (p0));
		}

		static Delegate cb_setKnownHosts_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetSetKnownHosts_Ljava_io_InputStream_Handler ()
		{
			if (cb_setKnownHosts_Ljava_io_InputStream_ == null)
				cb_setKnownHosts_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetKnownHosts_Ljava_io_InputStream_);
			return cb_setKnownHosts_Ljava_io_InputStream_;
		}

		static void n_SetKnownHosts_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.JSch __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.JSch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetKnownHosts (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setKnownHosts_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='setKnownHosts' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("setKnownHosts", "(Ljava/io/InputStream;)V", "GetSetKnownHosts_Ljava_io_InputStream_Handler")]
		public virtual void SetKnownHosts (global::System.IO.Stream p0)
		{
			if (id_setKnownHosts_Ljava_io_InputStream_ == IntPtr.Zero)
				id_setKnownHosts_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "setKnownHosts", "(Ljava/io/InputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setKnownHosts_Ljava_io_InputStream_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKnownHosts", "(Ljava/io/InputStream;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setKnownHosts_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetKnownHosts_Ljava_lang_String_Handler ()
		{
			if (cb_setKnownHosts_Ljava_lang_String_ == null)
				cb_setKnownHosts_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetKnownHosts_Ljava_lang_String_);
			return cb_setKnownHosts_Ljava_lang_String_;
		}

		static void n_SetKnownHosts_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.JSch __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.JSch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetKnownHosts (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setKnownHosts_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='setKnownHosts' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setKnownHosts", "(Ljava/lang/String;)V", "GetSetKnownHosts_Ljava_lang_String_Handler")]
		public virtual void SetKnownHosts (string p0)
		{
			if (id_setKnownHosts_Ljava_lang_String_ == IntPtr.Zero)
				id_setKnownHosts_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setKnownHosts", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setKnownHosts_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKnownHosts", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_setLogger_Lcom_jcraft_jsch_Logger_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='JSch']/method[@name='setLogger' and count(parameter)=1 and parameter[1][@type='com.jcraft.jsch.Logger']]"
		[Register ("setLogger", "(Lcom/jcraft/jsch/Logger;)V", "")]
		public static void SetLogger (global::Com.Jcraft.Jsch.ILogger p0)
		{
			if (id_setLogger_Lcom_jcraft_jsch_Logger_ == IntPtr.Zero)
				id_setLogger_Lcom_jcraft_jsch_Logger_ = JNIEnv.GetStaticMethodID (class_ref, "setLogger", "(Lcom/jcraft/jsch/Logger;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setLogger_Lcom_jcraft_jsch_Logger_, new JValue (p0));
		}

	}
}

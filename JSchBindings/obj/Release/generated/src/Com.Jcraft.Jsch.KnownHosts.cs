using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KnownHosts']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/KnownHosts", DoNotGenerateAcw=true)]
	public partial class KnownHosts : global::Java.Lang.Object, global::Com.Jcraft.Jsch.IHostKeyRepository {


		public static class InterfaceConsts {

			// The following are fields from: com.jcraft.jsch.HostKeyRepository

			// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='HostKeyRepository']/field[@name='CHANGED']"
			[Register ("CHANGED")]
			public const int Changed = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='HostKeyRepository']/field[@name='NOT_INCLUDED']"
			[Register ("NOT_INCLUDED")]
			public const int NotIncluded = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='HostKeyRepository']/field[@name='OK']"
			[Register ("OK")]
			public const int Ok = (int) 0;
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KnownHosts.HashedHostKey']"
		[global::Android.Runtime.Register ("com/jcraft/jsch/KnownHosts$HashedHostKey", DoNotGenerateAcw=true)]
		public partial class HashedHostKey : global::Com.Jcraft.Jsch.HostKey {

			protected HashedHostKey (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/KnownHosts", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KnownHosts); }
		}

		protected KnownHosts (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getKnownHostsRepositoryID;
#pragma warning disable 0169
		static Delegate GetGetKnownHostsRepositoryIDHandler ()
		{
			if (cb_getKnownHostsRepositoryID == null)
				cb_getKnownHostsRepositoryID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKnownHostsRepositoryID);
			return cb_getKnownHostsRepositoryID;
		}

		static IntPtr n_GetKnownHostsRepositoryID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.KnownHosts __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KnownHosts> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.KnownHostsRepositoryID);
		}
#pragma warning restore 0169

		static IntPtr id_getKnownHostsRepositoryID;
		public virtual string KnownHostsRepositoryID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KnownHosts']/method[@name='getKnownHostsRepositoryID' and count(parameter)=0]"
			[Register ("getKnownHostsRepositoryID", "()Ljava/lang/String;", "GetGetKnownHostsRepositoryIDHandler")]
			get {
				if (id_getKnownHostsRepositoryID == IntPtr.Zero)
					id_getKnownHostsRepositoryID = JNIEnv.GetMethodID (class_ref, "getKnownHostsRepositoryID", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getKnownHostsRepositoryID), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKnownHostsRepositoryID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_add_Lcom_jcraft_jsch_HostKey_Lcom_jcraft_jsch_UserInfo_;
#pragma warning disable 0169
		static Delegate GetAdd_Lcom_jcraft_jsch_HostKey_Lcom_jcraft_jsch_UserInfo_Handler ()
		{
			if (cb_add_Lcom_jcraft_jsch_HostKey_Lcom_jcraft_jsch_UserInfo_ == null)
				cb_add_Lcom_jcraft_jsch_HostKey_Lcom_jcraft_jsch_UserInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_Lcom_jcraft_jsch_HostKey_Lcom_jcraft_jsch_UserInfo_);
			return cb_add_Lcom_jcraft_jsch_HostKey_Lcom_jcraft_jsch_UserInfo_;
		}

		static void n_Add_Lcom_jcraft_jsch_HostKey_Lcom_jcraft_jsch_UserInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.KnownHosts __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KnownHosts> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.HostKey p0 = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.HostKey> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.IUserInfo p1 = (global::Com.Jcraft.Jsch.IUserInfo)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IUserInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_add_Lcom_jcraft_jsch_HostKey_Lcom_jcraft_jsch_UserInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KnownHosts']/method[@name='add' and count(parameter)=2 and parameter[1][@type='com.jcraft.jsch.HostKey'] and parameter[2][@type='com.jcraft.jsch.UserInfo']]"
		[Register ("add", "(Lcom/jcraft/jsch/HostKey;Lcom/jcraft/jsch/UserInfo;)V", "GetAdd_Lcom_jcraft_jsch_HostKey_Lcom_jcraft_jsch_UserInfo_Handler")]
		public virtual void Add (global::Com.Jcraft.Jsch.HostKey p0, global::Com.Jcraft.Jsch.IUserInfo p1)
		{
			if (id_add_Lcom_jcraft_jsch_HostKey_Lcom_jcraft_jsch_UserInfo_ == IntPtr.Zero)
				id_add_Lcom_jcraft_jsch_HostKey_Lcom_jcraft_jsch_UserInfo_ = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/jcraft/jsch/HostKey;Lcom/jcraft/jsch/UserInfo;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_add_Lcom_jcraft_jsch_HostKey_Lcom_jcraft_jsch_UserInfo_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lcom/jcraft/jsch/HostKey;Lcom/jcraft/jsch/UserInfo;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_check_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetCheck_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_check_Ljava_lang_String_arrayB == null)
				cb_check_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Check_Ljava_lang_String_arrayB);
			return cb_check_Ljava_lang_String_arrayB;
		}

		static int n_Check_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.KnownHosts __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KnownHosts> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Check (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_check_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KnownHosts']/method[@name='check' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("check", "(Ljava/lang/String;[B)I", "GetCheck_Ljava_lang_String_arrayBHandler")]
		public virtual int Check (string p0, byte[] p1)
		{
			if (id_check_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_check_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "check", "(Ljava/lang/String;[B)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_check_Ljava_lang_String_arrayB, new JValue (native_p0), new JValue (native_p1));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "check", "(Ljava/lang/String;[B)I"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
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
			global::Com.Jcraft.Jsch.KnownHosts __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KnownHosts> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetHostKey ());
		}
#pragma warning restore 0169

		static IntPtr id_getHostKey;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KnownHosts']/method[@name='getHostKey' and count(parameter)=0]"
		[Register ("getHostKey", "()[Lcom/jcraft/jsch/HostKey;", "GetGetHostKeyHandler")]
		public virtual global::Com.Jcraft.Jsch.HostKey[] GetHostKey ()
		{
			if (id_getHostKey == IntPtr.Zero)
				id_getHostKey = JNIEnv.GetMethodID (class_ref, "getHostKey", "()[Lcom/jcraft/jsch/HostKey;");

			if (GetType () == ThresholdType)
				return (global::Com.Jcraft.Jsch.HostKey[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getHostKey), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Jcraft.Jsch.HostKey));
			else
				return (global::Com.Jcraft.Jsch.HostKey[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHostKey", "()[Lcom/jcraft/jsch/HostKey;")), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Jcraft.Jsch.HostKey));
		}

		static Delegate cb_getHostKey_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetHostKey_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getHostKey_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getHostKey_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetHostKey_Ljava_lang_String_Ljava_lang_String_);
			return cb_getHostKey_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetHostKey_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.KnownHosts __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KnownHosts> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetHostKey (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getHostKey_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KnownHosts']/method[@name='getHostKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getHostKey", "(Ljava/lang/String;Ljava/lang/String;)[Lcom/jcraft/jsch/HostKey;", "GetGetHostKey_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual global::Com.Jcraft.Jsch.HostKey[] GetHostKey (string p0, string p1)
		{
			if (id_getHostKey_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getHostKey_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getHostKey", "(Ljava/lang/String;Ljava/lang/String;)[Lcom/jcraft/jsch/HostKey;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			global::Com.Jcraft.Jsch.HostKey[] __ret;
			if (GetType () == ThresholdType)
				__ret = (global::Com.Jcraft.Jsch.HostKey[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getHostKey_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Jcraft.Jsch.HostKey));
			else
				__ret = (global::Com.Jcraft.Jsch.HostKey[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHostKey", "(Ljava/lang/String;Ljava/lang/String;)[Lcom/jcraft/jsch/HostKey;"), new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Jcraft.Jsch.HostKey));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_remove_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_String_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Remove_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.KnownHosts __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KnownHosts> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_remove_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KnownHosts']/method[@name='remove' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;Ljava/lang/String;)V", "GetRemove_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void Remove (string p0, string p1)
		{
			if (id_remove_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_remove_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_remove_Ljava_lang_String_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_remove_Ljava_lang_String_Ljava_lang_String_arrayB == null)
				cb_remove_Ljava_lang_String_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_String_Ljava_lang_String_arrayB);
			return cb_remove_Ljava_lang_String_Ljava_lang_String_arrayB;
		}

		static void n_Remove_Ljava_lang_String_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Jcraft.Jsch.KnownHosts __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KnownHosts> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Remove (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_remove_Ljava_lang_String_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KnownHosts']/method[@name='remove' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
		[Register ("remove", "(Ljava/lang/String;Ljava/lang/String;[B)V", "GetRemove_Ljava_lang_String_Ljava_lang_String_arrayBHandler")]
		public virtual void Remove (string p0, string p1, byte[] p2)
		{
			if (id_remove_Ljava_lang_String_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_remove_Ljava_lang_String_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;Ljava/lang/String;[B)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_remove_Ljava_lang_String_Ljava_lang_String_arrayB, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Ljava/lang/String;Ljava/lang/String;[B)V"), new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_sync;
#pragma warning disable 0169
		static Delegate GetSyncHandler ()
		{
			if (cb_sync == null)
				cb_sync = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Sync);
			return cb_sync;
		}

		static void n_Sync (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.KnownHosts __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KnownHosts> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Sync ();
		}
#pragma warning restore 0169

		static IntPtr id_sync;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KnownHosts']/method[@name='sync' and count(parameter)=0]"
		[Register ("sync", "()V", "GetSyncHandler")]
		protected virtual void Sync ()
		{
			if (id_sync == IntPtr.Zero)
				id_sync = JNIEnv.GetMethodID (class_ref, "sync", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sync);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sync", "()V"));
		}

		static Delegate cb_sync_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSync_Ljava_lang_String_Handler ()
		{
			if (cb_sync_Ljava_lang_String_ == null)
				cb_sync_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Sync_Ljava_lang_String_);
			return cb_sync_Ljava_lang_String_;
		}

		static void n_Sync_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.KnownHosts __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KnownHosts> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Sync (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sync_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KnownHosts']/method[@name='sync' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sync", "(Ljava/lang/String;)V", "GetSync_Ljava_lang_String_Handler")]
		protected virtual void Sync (string p0)
		{
			if (id_sync_Ljava_lang_String_ == IntPtr.Zero)
				id_sync_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sync", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sync_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sync", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}

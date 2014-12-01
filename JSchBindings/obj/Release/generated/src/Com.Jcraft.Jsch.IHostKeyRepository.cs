using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	[Register ("com/jcraft/jsch/HostKeyRepository")]
	public abstract class HostKeyRepository {

		internal HostKeyRepository ()
		{
		}

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

	[System.Obsolete ("Use the 'HostKeyRepository' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class HostKeyRepositoryConsts : HostKeyRepository {

		private HostKeyRepositoryConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='HostKeyRepository']"
	[Register ("com/jcraft/jsch/HostKeyRepository", "", "Com.Jcraft.Jsch.IHostKeyRepositoryInvoker")]
	public partial interface IHostKeyRepository : IJavaObject {

		string KnownHostsRepositoryID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='HostKeyRepository']/method[@name='getKnownHostsRepositoryID' and count(parameter)=0]"
			[Register ("getKnownHostsRepositoryID", "()Ljava/lang/String;", "GetGetKnownHostsRepositoryIDHandler:Com.Jcraft.Jsch.IHostKeyRepositoryInvoker, JSchBindings")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='HostKeyRepository']/method[@name='add' and count(parameter)=2 and parameter[1][@type='com.jcraft.jsch.HostKey'] and parameter[2][@type='com.jcraft.jsch.UserInfo']]"
		[Register ("add", "(Lcom/jcraft/jsch/HostKey;Lcom/jcraft/jsch/UserInfo;)V", "GetAdd_Lcom_jcraft_jsch_HostKey_Lcom_jcraft_jsch_UserInfo_Handler:Com.Jcraft.Jsch.IHostKeyRepositoryInvoker, JSchBindings")]
		void Add (global::Com.Jcraft.Jsch.HostKey p0, global::Com.Jcraft.Jsch.IUserInfo p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='HostKeyRepository']/method[@name='check' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("check", "(Ljava/lang/String;[B)I", "GetCheck_Ljava_lang_String_arrayBHandler:Com.Jcraft.Jsch.IHostKeyRepositoryInvoker, JSchBindings")]
		int Check (string p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='HostKeyRepository']/method[@name='getHostKey' and count(parameter)=0]"
		[Register ("getHostKey", "()[Lcom/jcraft/jsch/HostKey;", "GetGetHostKeyHandler:Com.Jcraft.Jsch.IHostKeyRepositoryInvoker, JSchBindings")]
		global::Com.Jcraft.Jsch.HostKey[] GetHostKey ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='HostKeyRepository']/method[@name='getHostKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getHostKey", "(Ljava/lang/String;Ljava/lang/String;)[Lcom/jcraft/jsch/HostKey;", "GetGetHostKey_Ljava_lang_String_Ljava_lang_String_Handler:Com.Jcraft.Jsch.IHostKeyRepositoryInvoker, JSchBindings")]
		global::Com.Jcraft.Jsch.HostKey[] GetHostKey (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='HostKeyRepository']/method[@name='remove' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;Ljava/lang/String;)V", "GetRemove_Ljava_lang_String_Ljava_lang_String_Handler:Com.Jcraft.Jsch.IHostKeyRepositoryInvoker, JSchBindings")]
		void Remove (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='HostKeyRepository']/method[@name='remove' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
		[Register ("remove", "(Ljava/lang/String;Ljava/lang/String;[B)V", "GetRemove_Ljava_lang_String_Ljava_lang_String_arrayBHandler:Com.Jcraft.Jsch.IHostKeyRepositoryInvoker, JSchBindings")]
		void Remove (string p0, string p1, byte[] p2);

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/HostKeyRepository", DoNotGenerateAcw=true)]
	internal class IHostKeyRepositoryInvoker : global::Java.Lang.Object, IHostKeyRepository {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jcraft/jsch/HostKeyRepository");
		IntPtr class_ref;

		public static IHostKeyRepository GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHostKeyRepository> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jcraft.jsch.HostKeyRepository"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHostKeyRepositoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IHostKeyRepositoryInvoker); }
		}

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
			global::Com.Jcraft.Jsch.IHostKeyRepository __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IHostKeyRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.KnownHostsRepositoryID);
		}
#pragma warning restore 0169

		IntPtr id_getKnownHostsRepositoryID;
		public string KnownHostsRepositoryID {
			get {
				if (id_getKnownHostsRepositoryID == IntPtr.Zero)
					id_getKnownHostsRepositoryID = JNIEnv.GetMethodID (class_ref, "getKnownHostsRepositoryID", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getKnownHostsRepositoryID), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Jcraft.Jsch.IHostKeyRepository __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IHostKeyRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.HostKey p0 = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.HostKey> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.IUserInfo p1 = (global::Com.Jcraft.Jsch.IUserInfo)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IUserInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_add_Lcom_jcraft_jsch_HostKey_Lcom_jcraft_jsch_UserInfo_;
		public void Add (global::Com.Jcraft.Jsch.HostKey p0, global::Com.Jcraft.Jsch.IUserInfo p1)
		{
			if (id_add_Lcom_jcraft_jsch_HostKey_Lcom_jcraft_jsch_UserInfo_ == IntPtr.Zero)
				id_add_Lcom_jcraft_jsch_HostKey_Lcom_jcraft_jsch_UserInfo_ = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/jcraft/jsch/HostKey;Lcom/jcraft/jsch/UserInfo;)V");
			JNIEnv.CallVoidMethod (Handle, id_add_Lcom_jcraft_jsch_HostKey_Lcom_jcraft_jsch_UserInfo_, new JValue (p0), new JValue (p1));
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
			global::Com.Jcraft.Jsch.IHostKeyRepository __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IHostKeyRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Check (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_check_Ljava_lang_String_arrayB;
		public int Check (string p0, byte[] p1)
		{
			if (id_check_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_check_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "check", "(Ljava/lang/String;[B)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			int __ret = JNIEnv.CallIntMethod (Handle, id_check_Ljava_lang_String_arrayB, new JValue (native_p0), new JValue (native_p1));
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
			global::Com.Jcraft.Jsch.IHostKeyRepository __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IHostKeyRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetHostKey ());
		}
#pragma warning restore 0169

		IntPtr id_getHostKey;
		public global::Com.Jcraft.Jsch.HostKey[] GetHostKey ()
		{
			if (id_getHostKey == IntPtr.Zero)
				id_getHostKey = JNIEnv.GetMethodID (class_ref, "getHostKey", "()[Lcom/jcraft/jsch/HostKey;");
			return (global::Com.Jcraft.Jsch.HostKey[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getHostKey), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Jcraft.Jsch.HostKey));
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
			global::Com.Jcraft.Jsch.IHostKeyRepository __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IHostKeyRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetHostKey (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getHostKey_Ljava_lang_String_Ljava_lang_String_;
		public global::Com.Jcraft.Jsch.HostKey[] GetHostKey (string p0, string p1)
		{
			if (id_getHostKey_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getHostKey_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getHostKey", "(Ljava/lang/String;Ljava/lang/String;)[Lcom/jcraft/jsch/HostKey;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Com.Jcraft.Jsch.HostKey[] __ret = (global::Com.Jcraft.Jsch.HostKey[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getHostKey_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Jcraft.Jsch.HostKey));
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
			global::Com.Jcraft.Jsch.IHostKeyRepository __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IHostKeyRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_remove_Ljava_lang_String_Ljava_lang_String_;
		public void Remove (string p0, string p1)
		{
			if (id_remove_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_remove_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
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
			global::Com.Jcraft.Jsch.IHostKeyRepository __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IHostKeyRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Remove (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_remove_Ljava_lang_String_Ljava_lang_String_arrayB;
		public void Remove (string p0, string p1, byte[] p2)
		{
			if (id_remove_Ljava_lang_String_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_remove_Ljava_lang_String_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;Ljava/lang/String;[B)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JNIEnv.CallVoidMethod (Handle, id_remove_Ljava_lang_String_Ljava_lang_String_arrayB, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}

}

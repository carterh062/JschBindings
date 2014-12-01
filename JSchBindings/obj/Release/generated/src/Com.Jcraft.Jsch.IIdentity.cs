using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Identity']"
	[Register ("com/jcraft/jsch/Identity", "", "Com.Jcraft.Jsch.IIdentityInvoker")]
	public partial interface IIdentity : IJavaObject {

		string AlgName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Identity']/method[@name='getAlgName' and count(parameter)=0]"
			[Register ("getAlgName", "()Ljava/lang/String;", "GetGetAlgNameHandler:Com.Jcraft.Jsch.IIdentityInvoker, JSchBindings")] get;
		}

		bool IsEncrypted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Identity']/method[@name='isEncrypted' and count(parameter)=0]"
			[Register ("isEncrypted", "()Z", "GetIsEncryptedHandler:Com.Jcraft.Jsch.IIdentityInvoker, JSchBindings")] get;
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Identity']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Com.Jcraft.Jsch.IIdentityInvoker, JSchBindings")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Identity']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler:Com.Jcraft.Jsch.IIdentityInvoker, JSchBindings")]
		void Clear ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Identity']/method[@name='decrypt' and count(parameter)=0]"
		[Register ("decrypt", "()Z", "GetDecryptHandler:Com.Jcraft.Jsch.IIdentityInvoker, JSchBindings")]
		bool Decrypt ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Identity']/method[@name='getPublicKeyBlob' and count(parameter)=0]"
		[Register ("getPublicKeyBlob", "()[B", "GetGetPublicKeyBlobHandler:Com.Jcraft.Jsch.IIdentityInvoker, JSchBindings")]
		byte[] GetPublicKeyBlob ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Identity']/method[@name='getSignature' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getSignature", "([B)[B", "GetGetSignature_arrayBHandler:Com.Jcraft.Jsch.IIdentityInvoker, JSchBindings")]
		byte[] GetSignature (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Identity']/method[@name='setPassphrase' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setPassphrase", "([B)Z", "GetSetPassphrase_arrayBHandler:Com.Jcraft.Jsch.IIdentityInvoker, JSchBindings")]
		bool SetPassphrase (byte[] p0);

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/Identity", DoNotGenerateAcw=true)]
	internal class IIdentityInvoker : global::Java.Lang.Object, IIdentity {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jcraft/jsch/Identity");
		IntPtr class_ref;

		public static IIdentity GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIdentity> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jcraft.jsch.Identity"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIdentityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IIdentityInvoker); }
		}

		static Delegate cb_getAlgName;
#pragma warning disable 0169
		static Delegate GetGetAlgNameHandler ()
		{
			if (cb_getAlgName == null)
				cb_getAlgName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAlgName);
			return cb_getAlgName;
		}

		static IntPtr n_GetAlgName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.IIdentity __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IIdentity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AlgName);
		}
#pragma warning restore 0169

		IntPtr id_getAlgName;
		public string AlgName {
			get {
				if (id_getAlgName == IntPtr.Zero)
					id_getAlgName = JNIEnv.GetMethodID (class_ref, "getAlgName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getAlgName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isEncrypted;
#pragma warning disable 0169
		static Delegate GetIsEncryptedHandler ()
		{
			if (cb_isEncrypted == null)
				cb_isEncrypted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEncrypted);
			return cb_isEncrypted;
		}

		static bool n_IsEncrypted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.IIdentity __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IIdentity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEncrypted;
		}
#pragma warning restore 0169

		IntPtr id_isEncrypted;
		public bool IsEncrypted {
			get {
				if (id_isEncrypted == IntPtr.Zero)
					id_isEncrypted = JNIEnv.GetMethodID (class_ref, "isEncrypted", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isEncrypted);
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.IIdentity __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IIdentity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.IIdentity __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IIdentity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (Handle, id_clear);
		}

		static Delegate cb_decrypt;
#pragma warning disable 0169
		static Delegate GetDecryptHandler ()
		{
			if (cb_decrypt == null)
				cb_decrypt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Decrypt);
			return cb_decrypt;
		}

		static bool n_Decrypt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.IIdentity __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IIdentity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Decrypt ();
		}
#pragma warning restore 0169

		IntPtr id_decrypt;
		public bool Decrypt ()
		{
			if (id_decrypt == IntPtr.Zero)
				id_decrypt = JNIEnv.GetMethodID (class_ref, "decrypt", "()Z");
			return JNIEnv.CallBooleanMethod (Handle, id_decrypt);
		}

		static Delegate cb_getPublicKeyBlob;
#pragma warning disable 0169
		static Delegate GetGetPublicKeyBlobHandler ()
		{
			if (cb_getPublicKeyBlob == null)
				cb_getPublicKeyBlob = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPublicKeyBlob);
			return cb_getPublicKeyBlob;
		}

		static IntPtr n_GetPublicKeyBlob (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.IIdentity __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IIdentity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPublicKeyBlob ());
		}
#pragma warning restore 0169

		IntPtr id_getPublicKeyBlob;
		public byte[] GetPublicKeyBlob ()
		{
			if (id_getPublicKeyBlob == IntPtr.Zero)
				id_getPublicKeyBlob = JNIEnv.GetMethodID (class_ref, "getPublicKeyBlob", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getPublicKeyBlob), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_getSignature_arrayB;
#pragma warning disable 0169
		static Delegate GetGetSignature_arrayBHandler ()
		{
			if (cb_getSignature_arrayB == null)
				cb_getSignature_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSignature_arrayB);
			return cb_getSignature_arrayB;
		}

		static IntPtr n_GetSignature_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.IIdentity __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IIdentity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.GetSignature (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getSignature_arrayB;
		public byte[] GetSignature (byte[] p0)
		{
			if (id_getSignature_arrayB == IntPtr.Zero)
				id_getSignature_arrayB = JNIEnv.GetMethodID (class_ref, "getSignature", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getSignature_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_setPassphrase_arrayB;
#pragma warning disable 0169
		static Delegate GetSetPassphrase_arrayBHandler ()
		{
			if (cb_setPassphrase_arrayB == null)
				cb_setPassphrase_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetPassphrase_arrayB);
			return cb_setPassphrase_arrayB;
		}

		static bool n_SetPassphrase_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.IIdentity __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IIdentity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.SetPassphrase (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setPassphrase_arrayB;
		public bool SetPassphrase (byte[] p0)
		{
			if (id_setPassphrase_arrayB == IntPtr.Zero)
				id_setPassphrase_arrayB = JNIEnv.GetMethodID (class_ref, "setPassphrase", "([B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_setPassphrase_arrayB, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}

}

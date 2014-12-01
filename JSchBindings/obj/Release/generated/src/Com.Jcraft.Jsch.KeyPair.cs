using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/KeyPair", DoNotGenerateAcw=true)]
	public abstract partial class KeyPair : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/field[@name='DSA']"
		[Register ("DSA")]
		public const int Dsa = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/field[@name='ERROR']"
		[Register ("ERROR")]
		public const int Error = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/field[@name='RSA']"
		[Register ("RSA")]
		public const int Rsa = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public const int Unknown = (int) 3;

		static IntPtr data_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/field[@name='data']"
		[Register ("data")]
		protected IList<byte> Data {
			get {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, data_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, data_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr encrypted_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/field[@name='encrypted']"
		[Register ("encrypted")]
		protected bool Encrypted {
			get {
				if (encrypted_jfieldId == IntPtr.Zero)
					encrypted_jfieldId = JNIEnv.GetFieldID (class_ref, "encrypted", "Z");
				return JNIEnv.GetBooleanField (Handle, encrypted_jfieldId);
			}
			set {
				if (encrypted_jfieldId == IntPtr.Zero)
					encrypted_jfieldId = JNIEnv.GetFieldID (class_ref, "encrypted", "Z");
				JNIEnv.SetField (Handle, encrypted_jfieldId, value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair.ASN1']"
		[global::Android.Runtime.Register ("com/jcraft/jsch/KeyPair$ASN1", DoNotGenerateAcw=true)]
		public partial class ASN1 : global::Java.Lang.Object {

			protected ASN1 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair.ASN1Exception']"
		[global::Android.Runtime.Register ("com/jcraft/jsch/KeyPair$ASN1Exception", DoNotGenerateAcw=true)]
		public partial class ASN1Exception : global::Java.Lang.Exception {

			protected ASN1Exception (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/KeyPair", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KeyPair); }
		}

		protected KeyPair (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_jcraft_jsch_JSch_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/constructor[@name='KeyPair' and count(parameter)=1 and parameter[1][@type='com.jcraft.jsch.JSch']]"
		[Register (".ctor", "(Lcom/jcraft/jsch/JSch;)V", "")]
		public KeyPair (global::Com.Jcraft.Jsch.JSch p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (KeyPair)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/jcraft/jsch/JSch;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/jcraft/jsch/JSch;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_jcraft_jsch_JSch_ == IntPtr.Zero)
				id_ctor_Lcom_jcraft_jsch_JSch_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/jcraft/jsch/JSch;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_jcraft_jsch_JSch_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_jcraft_jsch_JSch_, new JValue (p0));
		}

		static Delegate cb_getFingerPrint;
#pragma warning disable 0169
		static Delegate GetGetFingerPrintHandler ()
		{
			if (cb_getFingerPrint == null)
				cb_getFingerPrint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFingerPrint);
			return cb_getFingerPrint;
		}

		static IntPtr n_GetFingerPrint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.KeyPair __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FingerPrint);
		}
#pragma warning restore 0169

		static IntPtr id_getFingerPrint;
		public virtual string FingerPrint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='getFingerPrint' and count(parameter)=0]"
			[Register ("getFingerPrint", "()Ljava/lang/String;", "GetGetFingerPrintHandler")]
			get {
				if (id_getFingerPrint == IntPtr.Zero)
					id_getFingerPrint = JNIEnv.GetMethodID (class_ref, "getFingerPrint", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFingerPrint), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFingerPrint", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Jcraft.Jsch.KeyPair __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEncrypted;
		}
#pragma warning restore 0169

		static IntPtr id_isEncrypted;
		public virtual bool IsEncrypted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='isEncrypted' and count(parameter)=0]"
			[Register ("isEncrypted", "()Z", "GetIsEncryptedHandler")]
			get {
				if (id_isEncrypted == IntPtr.Zero)
					id_isEncrypted = JNIEnv.GetMethodID (class_ref, "isEncrypted", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isEncrypted);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEncrypted", "()Z"));
			}
		}

		static Delegate cb_getKeyType;
#pragma warning disable 0169
		static Delegate GetGetKeyTypeHandler ()
		{
			if (cb_getKeyType == null)
				cb_getKeyType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetKeyType);
			return cb_getKeyType;
		}

		static int n_GetKeyType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.KeyPair __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KeyType;
		}
#pragma warning restore 0169

		public abstract int KeyType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='getKeyType' and count(parameter)=0]"
			[Register ("getKeyType", "()I", "GetGetKeyTypeHandler")] get;
		}

		static Delegate cb_getPublicKeyComment;
#pragma warning disable 0169
		static Delegate GetGetPublicKeyCommentHandler ()
		{
			if (cb_getPublicKeyComment == null)
				cb_getPublicKeyComment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPublicKeyComment);
			return cb_getPublicKeyComment;
		}

		static IntPtr n_GetPublicKeyComment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.KeyPair __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PublicKeyComment);
		}
#pragma warning restore 0169

		static Delegate cb_setPublicKeyComment_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPublicKeyComment_Ljava_lang_String_Handler ()
		{
			if (cb_setPublicKeyComment_Ljava_lang_String_ == null)
				cb_setPublicKeyComment_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPublicKeyComment_Ljava_lang_String_);
			return cb_setPublicKeyComment_Ljava_lang_String_;
		}

		static void n_SetPublicKeyComment_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.KeyPair __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PublicKeyComment = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPublicKeyComment;
		static IntPtr id_setPublicKeyComment_Ljava_lang_String_;
		public virtual string PublicKeyComment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='getPublicKeyComment' and count(parameter)=0]"
			[Register ("getPublicKeyComment", "()Ljava/lang/String;", "GetGetPublicKeyCommentHandler")]
			get {
				if (id_getPublicKeyComment == IntPtr.Zero)
					id_getPublicKeyComment = JNIEnv.GetMethodID (class_ref, "getPublicKeyComment", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPublicKeyComment), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPublicKeyComment", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='setPublicKeyComment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPublicKeyComment", "(Ljava/lang/String;)V", "GetSetPublicKeyComment_Ljava_lang_String_Handler")]
			set {
				if (id_setPublicKeyComment_Ljava_lang_String_ == IntPtr.Zero)
					id_setPublicKeyComment_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPublicKeyComment", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPublicKeyComment_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPublicKeyComment", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getVerifier;
#pragma warning disable 0169
		static Delegate GetGetVerifierHandler ()
		{
			if (cb_getVerifier == null)
				cb_getVerifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVerifier);
			return cb_getVerifier;
		}

		static IntPtr n_GetVerifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.KeyPair __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Verifier);
		}
#pragma warning restore 0169

		public abstract global::Com.Jcraft.Jsch.ISignature Verifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='getVerifier' and count(parameter)=0]"
			[Register ("getVerifier", "()Lcom/jcraft/jsch/Signature;", "GetGetVerifierHandler")] get;
		}

		static Delegate cb_decrypt_arrayB;
#pragma warning disable 0169
		static Delegate GetDecrypt_arrayBHandler ()
		{
			if (cb_decrypt_arrayB == null)
				cb_decrypt_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Decrypt_arrayB);
			return cb_decrypt_arrayB;
		}

		static bool n_Decrypt_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.KeyPair __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.Decrypt (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decrypt_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='decrypt' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decrypt", "([B)Z", "GetDecrypt_arrayBHandler")]
		public virtual bool Decrypt (byte[] p0)
		{
			if (id_decrypt_arrayB == IntPtr.Zero)
				id_decrypt_arrayB = JNIEnv.GetMethodID (class_ref, "decrypt", "([B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_decrypt_arrayB, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decrypt", "([B)Z"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_decrypt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDecrypt_Ljava_lang_String_Handler ()
		{
			if (cb_decrypt_Ljava_lang_String_ == null)
				cb_decrypt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Decrypt_Ljava_lang_String_);
			return cb_decrypt_Ljava_lang_String_;
		}

		static bool n_Decrypt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.KeyPair __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Decrypt (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decrypt_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='decrypt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decrypt", "(Ljava/lang/String;)Z", "GetDecrypt_Ljava_lang_String_Handler")]
		public virtual bool Decrypt (string p0)
		{
			if (id_decrypt_Ljava_lang_String_ == IntPtr.Zero)
				id_decrypt_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "decrypt", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_decrypt_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decrypt", "(Ljava/lang/String;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.KeyPair __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispose);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispose", "()V"));
		}

		static Delegate cb_finalize;
#pragma warning disable 0169
		static Delegate GetFinalizeHandler ()
		{
			if (cb_finalize == null)
				cb_finalize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Finalize);
			return cb_finalize;
		}

		static void n_Finalize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.KeyPair __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finalize ();
		}
#pragma warning restore 0169

		static IntPtr id_finalize;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='finalize' and count(parameter)=0]"
		[Register ("finalize", "()V", "GetFinalizeHandler")]
		public virtual void Finalize ()
		{
			if (id_finalize == IntPtr.Zero)
				id_finalize = JNIEnv.GetMethodID (class_ref, "finalize", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_finalize);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finalize", "()V"));
		}

		static Delegate cb_forSSHAgent;
#pragma warning disable 0169
		static Delegate GetForSSHAgentHandler ()
		{
			if (cb_forSSHAgent == null)
				cb_forSSHAgent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ForSSHAgent);
			return cb_forSSHAgent;
		}

		static IntPtr n_ForSSHAgent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.KeyPair __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ForSSHAgent ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='forSSHAgent' and count(parameter)=0]"
		[Register ("forSSHAgent", "()[B", "GetForSSHAgentHandler")]
		public abstract byte[] ForSSHAgent ();

		static IntPtr id_genKeyPair_Lcom_jcraft_jsch_JSch_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='genKeyPair' and count(parameter)=2 and parameter[1][@type='com.jcraft.jsch.JSch'] and parameter[2][@type='int']]"
		[Register ("genKeyPair", "(Lcom/jcraft/jsch/JSch;I)Lcom/jcraft/jsch/KeyPair;", "")]
		public static global::Com.Jcraft.Jsch.KeyPair GenKeyPair (global::Com.Jcraft.Jsch.JSch p0, int p1)
		{
			if (id_genKeyPair_Lcom_jcraft_jsch_JSch_I == IntPtr.Zero)
				id_genKeyPair_Lcom_jcraft_jsch_JSch_I = JNIEnv.GetStaticMethodID (class_ref, "genKeyPair", "(Lcom/jcraft/jsch/JSch;I)Lcom/jcraft/jsch/KeyPair;");
			global::Com.Jcraft.Jsch.KeyPair __ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (JNIEnv.CallStaticObjectMethod  (class_ref, id_genKeyPair_Lcom_jcraft_jsch_JSch_I, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_genKeyPair_Lcom_jcraft_jsch_JSch_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='genKeyPair' and count(parameter)=3 and parameter[1][@type='com.jcraft.jsch.JSch'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("genKeyPair", "(Lcom/jcraft/jsch/JSch;II)Lcom/jcraft/jsch/KeyPair;", "")]
		public static global::Com.Jcraft.Jsch.KeyPair GenKeyPair (global::Com.Jcraft.Jsch.JSch p0, int p1, int p2)
		{
			if (id_genKeyPair_Lcom_jcraft_jsch_JSch_II == IntPtr.Zero)
				id_genKeyPair_Lcom_jcraft_jsch_JSch_II = JNIEnv.GetStaticMethodID (class_ref, "genKeyPair", "(Lcom/jcraft/jsch/JSch;II)Lcom/jcraft/jsch/KeyPair;");
			global::Com.Jcraft.Jsch.KeyPair __ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (JNIEnv.CallStaticObjectMethod  (class_ref, id_genKeyPair_Lcom_jcraft_jsch_JSch_II, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Com.Jcraft.Jsch.KeyPair __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPublicKeyBlob ());
		}
#pragma warning restore 0169

		static IntPtr id_getPublicKeyBlob;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='getPublicKeyBlob' and count(parameter)=0]"
		[Register ("getPublicKeyBlob", "()[B", "GetGetPublicKeyBlobHandler")]
		public virtual byte[] GetPublicKeyBlob ()
		{
			if (id_getPublicKeyBlob == IntPtr.Zero)
				id_getPublicKeyBlob = JNIEnv.GetMethodID (class_ref, "getPublicKeyBlob", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getPublicKeyBlob), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPublicKeyBlob", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Jcraft.Jsch.KeyPair __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.GetSignature (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='getSignature' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getSignature", "([B)[B", "GetGetSignature_arrayBHandler")]
		public abstract byte[] GetSignature (byte[] p0);

		static IntPtr id_load_Lcom_jcraft_jsch_JSch_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='load' and count(parameter)=3 and parameter[1][@type='com.jcraft.jsch.JSch'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("load", "(Lcom/jcraft/jsch/JSch;[B[B)Lcom/jcraft/jsch/KeyPair;", "")]
		public static global::Com.Jcraft.Jsch.KeyPair Load (global::Com.Jcraft.Jsch.JSch p0, byte[] p1, byte[] p2)
		{
			if (id_load_Lcom_jcraft_jsch_JSch_arrayBarrayB == IntPtr.Zero)
				id_load_Lcom_jcraft_jsch_JSch_arrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "load", "(Lcom/jcraft/jsch/JSch;[B[B)Lcom/jcraft/jsch/KeyPair;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			global::Com.Jcraft.Jsch.KeyPair __ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (JNIEnv.CallStaticObjectMethod  (class_ref, id_load_Lcom_jcraft_jsch_JSch_arrayBarrayB, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static IntPtr id_load_Lcom_jcraft_jsch_JSch_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='load' and count(parameter)=2 and parameter[1][@type='com.jcraft.jsch.JSch'] and parameter[2][@type='java.lang.String']]"
		[Register ("load", "(Lcom/jcraft/jsch/JSch;Ljava/lang/String;)Lcom/jcraft/jsch/KeyPair;", "")]
		public static global::Com.Jcraft.Jsch.KeyPair Load (global::Com.Jcraft.Jsch.JSch p0, string p1)
		{
			if (id_load_Lcom_jcraft_jsch_JSch_Ljava_lang_String_ == IntPtr.Zero)
				id_load_Lcom_jcraft_jsch_JSch_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "load", "(Lcom/jcraft/jsch/JSch;Ljava/lang/String;)Lcom/jcraft/jsch/KeyPair;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Com.Jcraft.Jsch.KeyPair __ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (JNIEnv.CallStaticObjectMethod  (class_ref, id_load_Lcom_jcraft_jsch_JSch_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_load_Lcom_jcraft_jsch_JSch_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='load' and count(parameter)=3 and parameter[1][@type='com.jcraft.jsch.JSch'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("load", "(Lcom/jcraft/jsch/JSch;Ljava/lang/String;Ljava/lang/String;)Lcom/jcraft/jsch/KeyPair;", "")]
		public static global::Com.Jcraft.Jsch.KeyPair Load (global::Com.Jcraft.Jsch.JSch p0, string p1, string p2)
		{
			if (id_load_Lcom_jcraft_jsch_JSch_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_load_Lcom_jcraft_jsch_JSch_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "load", "(Lcom/jcraft/jsch/JSch;Ljava/lang/String;Ljava/lang/String;)Lcom/jcraft/jsch/KeyPair;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			global::Com.Jcraft.Jsch.KeyPair __ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (JNIEnv.CallStaticObjectMethod  (class_ref, id_load_Lcom_jcraft_jsch_JSch_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_setPassphrase_arrayB;
#pragma warning disable 0169
		static Delegate GetSetPassphrase_arrayBHandler ()
		{
			if (cb_setPassphrase_arrayB == null)
				cb_setPassphrase_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPassphrase_arrayB);
			return cb_setPassphrase_arrayB;
		}

		static void n_SetPassphrase_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.KeyPair __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetPassphrase (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPassphrase_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='setPassphrase' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setPassphrase", "([B)V", "GetSetPassphrase_arrayBHandler")]
		public virtual void SetPassphrase (byte[] p0)
		{
			if (id_setPassphrase_arrayB == IntPtr.Zero)
				id_setPassphrase_arrayB = JNIEnv.GetMethodID (class_ref, "setPassphrase", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPassphrase_arrayB, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPassphrase", "([B)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setPassphrase_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPassphrase_Ljava_lang_String_Handler ()
		{
			if (cb_setPassphrase_Ljava_lang_String_ == null)
				cb_setPassphrase_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPassphrase_Ljava_lang_String_);
			return cb_setPassphrase_Ljava_lang_String_;
		}

		static void n_SetPassphrase_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.KeyPair __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPassphrase (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPassphrase_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='setPassphrase' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPassphrase", "(Ljava/lang/String;)V", "GetSetPassphrase_Ljava_lang_String_Handler")]
		public virtual void SetPassphrase (string p0)
		{
			if (id_setPassphrase_Ljava_lang_String_ == IntPtr.Zero)
				id_setPassphrase_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPassphrase", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPassphrase_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPassphrase", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_writePrivateKey_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetWritePrivateKey_Ljava_io_OutputStream_Handler ()
		{
			if (cb_writePrivateKey_Ljava_io_OutputStream_ == null)
				cb_writePrivateKey_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WritePrivateKey_Ljava_io_OutputStream_);
			return cb_writePrivateKey_Ljava_io_OutputStream_;
		}

		static void n_WritePrivateKey_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.KeyPair __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WritePrivateKey (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writePrivateKey_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='writePrivateKey' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("writePrivateKey", "(Ljava/io/OutputStream;)V", "GetWritePrivateKey_Ljava_io_OutputStream_Handler")]
		public virtual void WritePrivateKey (global::System.IO.Stream p0)
		{
			if (id_writePrivateKey_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_writePrivateKey_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "writePrivateKey", "(Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writePrivateKey_Ljava_io_OutputStream_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writePrivateKey", "(Ljava/io/OutputStream;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_writePrivateKey_Ljava_io_OutputStream_arrayB;
#pragma warning disable 0169
		static Delegate GetWritePrivateKey_Ljava_io_OutputStream_arrayBHandler ()
		{
			if (cb_writePrivateKey_Ljava_io_OutputStream_arrayB == null)
				cb_writePrivateKey_Ljava_io_OutputStream_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_WritePrivateKey_Ljava_io_OutputStream_arrayB);
			return cb_writePrivateKey_Ljava_io_OutputStream_arrayB;
		}

		static void n_WritePrivateKey_Ljava_io_OutputStream_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.KeyPair __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.WritePrivateKey (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_writePrivateKey_Ljava_io_OutputStream_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='writePrivateKey' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='byte[]']]"
		[Register ("writePrivateKey", "(Ljava/io/OutputStream;[B)V", "GetWritePrivateKey_Ljava_io_OutputStream_arrayBHandler")]
		public virtual void WritePrivateKey (global::System.IO.Stream p0, byte[] p1)
		{
			if (id_writePrivateKey_Ljava_io_OutputStream_arrayB == IntPtr.Zero)
				id_writePrivateKey_Ljava_io_OutputStream_arrayB = JNIEnv.GetMethodID (class_ref, "writePrivateKey", "(Ljava/io/OutputStream;[B)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writePrivateKey_Ljava_io_OutputStream_arrayB, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writePrivateKey", "(Ljava/io/OutputStream;[B)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_writePrivateKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWritePrivateKey_Ljava_lang_String_Handler ()
		{
			if (cb_writePrivateKey_Ljava_lang_String_ == null)
				cb_writePrivateKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WritePrivateKey_Ljava_lang_String_);
			return cb_writePrivateKey_Ljava_lang_String_;
		}

		static void n_WritePrivateKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.KeyPair __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WritePrivateKey (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writePrivateKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='writePrivateKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("writePrivateKey", "(Ljava/lang/String;)V", "GetWritePrivateKey_Ljava_lang_String_Handler")]
		public virtual void WritePrivateKey (string p0)
		{
			if (id_writePrivateKey_Ljava_lang_String_ == IntPtr.Zero)
				id_writePrivateKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "writePrivateKey", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writePrivateKey_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writePrivateKey", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_writePrivateKey_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetWritePrivateKey_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_writePrivateKey_Ljava_lang_String_arrayB == null)
				cb_writePrivateKey_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_WritePrivateKey_Ljava_lang_String_arrayB);
			return cb_writePrivateKey_Ljava_lang_String_arrayB;
		}

		static void n_WritePrivateKey_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.KeyPair __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.WritePrivateKey (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_writePrivateKey_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='writePrivateKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("writePrivateKey", "(Ljava/lang/String;[B)V", "GetWritePrivateKey_Ljava_lang_String_arrayBHandler")]
		public virtual void WritePrivateKey (string p0, byte[] p1)
		{
			if (id_writePrivateKey_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_writePrivateKey_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "writePrivateKey", "(Ljava/lang/String;[B)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writePrivateKey_Ljava_lang_String_arrayB, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writePrivateKey", "(Ljava/lang/String;[B)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_writePublicKey_Ljava_io_OutputStream_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWritePublicKey_Ljava_io_OutputStream_Ljava_lang_String_Handler ()
		{
			if (cb_writePublicKey_Ljava_io_OutputStream_Ljava_lang_String_ == null)
				cb_writePublicKey_Ljava_io_OutputStream_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_WritePublicKey_Ljava_io_OutputStream_Ljava_lang_String_);
			return cb_writePublicKey_Ljava_io_OutputStream_Ljava_lang_String_;
		}

		static void n_WritePublicKey_Ljava_io_OutputStream_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.KeyPair __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.WritePublicKey (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writePublicKey_Ljava_io_OutputStream_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='writePublicKey' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='java.lang.String']]"
		[Register ("writePublicKey", "(Ljava/io/OutputStream;Ljava/lang/String;)V", "GetWritePublicKey_Ljava_io_OutputStream_Ljava_lang_String_Handler")]
		public virtual void WritePublicKey (global::System.IO.Stream p0, string p1)
		{
			if (id_writePublicKey_Ljava_io_OutputStream_Ljava_lang_String_ == IntPtr.Zero)
				id_writePublicKey_Ljava_io_OutputStream_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "writePublicKey", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writePublicKey_Ljava_io_OutputStream_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writePublicKey", "(Ljava/io/OutputStream;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_writePublicKey_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWritePublicKey_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_writePublicKey_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_writePublicKey_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_WritePublicKey_Ljava_lang_String_Ljava_lang_String_);
			return cb_writePublicKey_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_WritePublicKey_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.KeyPair __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.WritePublicKey (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writePublicKey_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='writePublicKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("writePublicKey", "(Ljava/lang/String;Ljava/lang/String;)V", "GetWritePublicKey_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void WritePublicKey (string p0, string p1)
		{
			if (id_writePublicKey_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_writePublicKey_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "writePublicKey", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writePublicKey_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writePublicKey", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_writeSECSHPublicKey_Ljava_io_OutputStream_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWriteSECSHPublicKey_Ljava_io_OutputStream_Ljava_lang_String_Handler ()
		{
			if (cb_writeSECSHPublicKey_Ljava_io_OutputStream_Ljava_lang_String_ == null)
				cb_writeSECSHPublicKey_Ljava_io_OutputStream_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteSECSHPublicKey_Ljava_io_OutputStream_Ljava_lang_String_);
			return cb_writeSECSHPublicKey_Ljava_io_OutputStream_Ljava_lang_String_;
		}

		static void n_WriteSECSHPublicKey_Ljava_io_OutputStream_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.KeyPair __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.WriteSECSHPublicKey (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeSECSHPublicKey_Ljava_io_OutputStream_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='writeSECSHPublicKey' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='java.lang.String']]"
		[Register ("writeSECSHPublicKey", "(Ljava/io/OutputStream;Ljava/lang/String;)V", "GetWriteSECSHPublicKey_Ljava_io_OutputStream_Ljava_lang_String_Handler")]
		public virtual void WriteSECSHPublicKey (global::System.IO.Stream p0, string p1)
		{
			if (id_writeSECSHPublicKey_Ljava_io_OutputStream_Ljava_lang_String_ == IntPtr.Zero)
				id_writeSECSHPublicKey_Ljava_io_OutputStream_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "writeSECSHPublicKey", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writeSECSHPublicKey_Ljava_io_OutputStream_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeSECSHPublicKey", "(Ljava/io/OutputStream;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_writeSECSHPublicKey_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWriteSECSHPublicKey_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_writeSECSHPublicKey_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_writeSECSHPublicKey_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteSECSHPublicKey_Ljava_lang_String_Ljava_lang_String_);
			return cb_writeSECSHPublicKey_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_WriteSECSHPublicKey_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.KeyPair __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.WriteSECSHPublicKey (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeSECSHPublicKey_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='writeSECSHPublicKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("writeSECSHPublicKey", "(Ljava/lang/String;Ljava/lang/String;)V", "GetWriteSECSHPublicKey_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void WriteSECSHPublicKey (string p0, string p1)
		{
			if (id_writeSECSHPublicKey_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_writeSECSHPublicKey_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "writeSECSHPublicKey", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writeSECSHPublicKey_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeSECSHPublicKey", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/KeyPair", DoNotGenerateAcw=true)]
	internal partial class KeyPairInvoker : KeyPair {

		public KeyPairInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (KeyPairInvoker); }
		}

		static IntPtr id_getKeyType;
		public override int KeyType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='getKeyType' and count(parameter)=0]"
			[Register ("getKeyType", "()I", "GetGetKeyTypeHandler")]
			get {
				if (id_getKeyType == IntPtr.Zero)
					id_getKeyType = JNIEnv.GetMethodID (class_ref, "getKeyType", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getKeyType);
			}
		}

		static IntPtr id_getVerifier;
		public override global::Com.Jcraft.Jsch.ISignature Verifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='getVerifier' and count(parameter)=0]"
			[Register ("getVerifier", "()Lcom/jcraft/jsch/Signature;", "GetGetVerifierHandler")]
			get {
				if (id_getVerifier == IntPtr.Zero)
					id_getVerifier = JNIEnv.GetMethodID (class_ref, "getVerifier", "()Lcom/jcraft/jsch/Signature;");
				return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISignature> (JNIEnv.CallObjectMethod  (Handle, id_getVerifier), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_forSSHAgent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='forSSHAgent' and count(parameter)=0]"
		[Register ("forSSHAgent", "()[B", "GetForSSHAgentHandler")]
		public override byte[] ForSSHAgent ()
		{
			if (id_forSSHAgent == IntPtr.Zero)
				id_forSSHAgent = JNIEnv.GetMethodID (class_ref, "forSSHAgent", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_forSSHAgent), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static IntPtr id_getSignature_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPair']/method[@name='getSignature' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getSignature", "([B)[B", "GetGetSignature_arrayBHandler")]
		public override byte[] GetSignature (byte[] p0)
		{
			if (id_getSignature_arrayB == IntPtr.Zero)
				id_getSignature_arrayB = JNIEnv.GetMethodID (class_ref, "getSignature", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getSignature_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}

}

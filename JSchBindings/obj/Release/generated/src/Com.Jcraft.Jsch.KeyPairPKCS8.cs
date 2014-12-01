using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPairPKCS8']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/KeyPairPKCS8", DoNotGenerateAcw=true)]
	public partial class KeyPairPKCS8 : global::Com.Jcraft.Jsch.KeyPair {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/KeyPairPKCS8", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KeyPairPKCS8); }
		}

		protected KeyPairPKCS8 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_jcraft_jsch_JSch_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPairPKCS8']/constructor[@name='KeyPairPKCS8' and count(parameter)=1 and parameter[1][@type='com.jcraft.jsch.JSch']]"
		[Register (".ctor", "(Lcom/jcraft/jsch/JSch;)V", "")]
		public KeyPairPKCS8 (global::Com.Jcraft.Jsch.JSch p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (KeyPairPKCS8)) {
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

		static Delegate cb_getKeySize;
#pragma warning disable 0169
		static Delegate GetGetKeySizeHandler ()
		{
			if (cb_getKeySize == null)
				cb_getKeySize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetKeySize);
			return cb_getKeySize;
		}

		static int n_GetKeySize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.KeyPairPKCS8 __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPairPKCS8> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KeySize;
		}
#pragma warning restore 0169

		static IntPtr id_getKeySize;
		public virtual int KeySize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPairPKCS8']/method[@name='getKeySize' and count(parameter)=0]"
			[Register ("getKeySize", "()I", "GetGetKeySizeHandler")]
			get {
				if (id_getKeySize == IntPtr.Zero)
					id_getKeySize = JNIEnv.GetMethodID (class_ref, "getKeySize", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getKeySize);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeySize", "()I"));
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
			global::Com.Jcraft.Jsch.KeyPairPKCS8 __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPairPKCS8> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KeyType;
		}
#pragma warning restore 0169

		static IntPtr id_getKeyType;
		public override int KeyType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPairPKCS8']/method[@name='getKeyType' and count(parameter)=0]"
			[Register ("getKeyType", "()I", "GetGetKeyTypeHandler")]
			get {
				if (id_getKeyType == IntPtr.Zero)
					id_getKeyType = JNIEnv.GetMethodID (class_ref, "getKeyType", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getKeyType);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeyType", "()I"));
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
			global::Com.Jcraft.Jsch.KeyPairPKCS8 __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPairPKCS8> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Verifier);
		}
#pragma warning restore 0169

		static IntPtr id_getVerifier;
		public override global::Com.Jcraft.Jsch.ISignature Verifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPairPKCS8']/method[@name='getVerifier' and count(parameter)=0]"
			[Register ("getVerifier", "()Lcom/jcraft/jsch/Signature;", "GetGetVerifierHandler")]
			get {
				if (id_getVerifier == IntPtr.Zero)
					id_getVerifier = JNIEnv.GetMethodID (class_ref, "getVerifier", "()Lcom/jcraft/jsch/Signature;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISignature> (JNIEnv.CallObjectMethod  (Handle, id_getVerifier), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISignature> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVerifier", "()Lcom/jcraft/jsch/Signature;")), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Com.Jcraft.Jsch.KeyPairPKCS8 __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPairPKCS8> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ForSSHAgent ());
		}
#pragma warning restore 0169

		static IntPtr id_forSSHAgent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPairPKCS8']/method[@name='forSSHAgent' and count(parameter)=0]"
		[Register ("forSSHAgent", "()[B", "GetForSSHAgentHandler")]
		public override byte[] ForSSHAgent ()
		{
			if (id_forSSHAgent == IntPtr.Zero)
				id_forSSHAgent = JNIEnv.GetMethodID (class_ref, "forSSHAgent", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_forSSHAgent), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "forSSHAgent", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Jcraft.Jsch.KeyPairPKCS8 __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyPairPKCS8> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.GetSignature (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSignature_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyPairPKCS8']/method[@name='getSignature' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getSignature", "([B)[B", "GetGetSignature_arrayBHandler")]
		public override byte[] GetSignature (byte[] p0)
		{
			if (id_getSignature_arrayB == IntPtr.Zero)
				id_getSignature_arrayB = JNIEnv.GetMethodID (class_ref, "getSignature", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			byte[] __ret;
			if (GetType () == ThresholdType)
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getSignature_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSignature", "([B)[B"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}
}

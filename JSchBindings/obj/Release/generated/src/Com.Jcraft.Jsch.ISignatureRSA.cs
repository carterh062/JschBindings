using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='SignatureRSA']"
	[Register ("com/jcraft/jsch/SignatureRSA", "", "Com.Jcraft.Jsch.ISignatureRSAInvoker")]
	public partial interface ISignatureRSA : global::Com.Jcraft.Jsch.ISignature {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='SignatureRSA']/method[@name='setPrvKey' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("setPrvKey", "([B[B)V", "GetSetPrvKey_arrayBarrayBHandler:Com.Jcraft.Jsch.ISignatureRSAInvoker, JSchBindings")]
		void SetPrvKey (byte[] p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='SignatureRSA']/method[@name='setPubKey' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("setPubKey", "([B[B)V", "GetSetPubKey_arrayBarrayBHandler:Com.Jcraft.Jsch.ISignatureRSAInvoker, JSchBindings")]
		void SetPubKey (byte[] p0, byte[] p1);

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/SignatureRSA", DoNotGenerateAcw=true)]
	internal class ISignatureRSAInvoker : global::Java.Lang.Object, ISignatureRSA {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jcraft/jsch/SignatureRSA");
		IntPtr class_ref;

		public static ISignatureRSA GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISignatureRSA> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jcraft.jsch.SignatureRSA"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISignatureRSAInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISignatureRSAInvoker); }
		}

		static Delegate cb_setPrvKey_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetSetPrvKey_arrayBarrayBHandler ()
		{
			if (cb_setPrvKey_arrayBarrayB == null)
				cb_setPrvKey_arrayBarrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPrvKey_arrayBarrayB);
			return cb_setPrvKey_arrayBarrayB;
		}

		static void n_SetPrvKey_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.ISignatureRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISignatureRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetPrvKey (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_setPrvKey_arrayBarrayB;
		public void SetPrvKey (byte[] p0, byte[] p1)
		{
			if (id_setPrvKey_arrayBarrayB == IntPtr.Zero)
				id_setPrvKey_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "setPrvKey", "([B[B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JNIEnv.CallVoidMethod (Handle, id_setPrvKey_arrayBarrayB, new JValue (native_p0), new JValue (native_p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setPubKey_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetSetPubKey_arrayBarrayBHandler ()
		{
			if (cb_setPubKey_arrayBarrayB == null)
				cb_setPubKey_arrayBarrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPubKey_arrayBarrayB);
			return cb_setPubKey_arrayBarrayB;
		}

		static void n_SetPubKey_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.ISignatureRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISignatureRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetPubKey (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_setPubKey_arrayBarrayB;
		public void SetPubKey (byte[] p0, byte[] p1)
		{
			if (id_setPubKey_arrayBarrayB == IntPtr.Zero)
				id_setPubKey_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "setPubKey", "([B[B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JNIEnv.CallVoidMethod (Handle, id_setPubKey_arrayBarrayB, new JValue (native_p0), new JValue (native_p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.ISignatureRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISignatureRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		IntPtr id_init;
		public void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");
			JNIEnv.CallVoidMethod (Handle, id_init);
		}

		static Delegate cb_sign;
#pragma warning disable 0169
		static Delegate GetSignHandler ()
		{
			if (cb_sign == null)
				cb_sign = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Sign);
			return cb_sign;
		}

		static IntPtr n_Sign (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.ISignatureRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISignatureRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Sign ());
		}
#pragma warning restore 0169

		IntPtr id_sign;
		public byte[] Sign ()
		{
			if (id_sign == IntPtr.Zero)
				id_sign = JNIEnv.GetMethodID (class_ref, "sign", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_sign), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_update_arrayB;
#pragma warning disable 0169
		static Delegate GetUpdate_arrayBHandler ()
		{
			if (cb_update_arrayB == null)
				cb_update_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Update_arrayB);
			return cb_update_arrayB;
		}

		static void n_Update_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ISignatureRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISignatureRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Update (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_update_arrayB;
		public void Update (byte[] p0)
		{
			if (id_update_arrayB == IntPtr.Zero)
				id_update_arrayB = JNIEnv.GetMethodID (class_ref, "update", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallVoidMethod (Handle, id_update_arrayB, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_verify_arrayB;
#pragma warning disable 0169
		static Delegate GetVerify_arrayBHandler ()
		{
			if (cb_verify_arrayB == null)
				cb_verify_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Verify_arrayB);
			return cb_verify_arrayB;
		}

		static bool n_Verify_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ISignatureRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISignatureRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.Verify (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_verify_arrayB;
		public bool Verify (byte[] p0)
		{
			if (id_verify_arrayB == IntPtr.Zero)
				id_verify_arrayB = JNIEnv.GetMethodID (class_ref, "verify", "([B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_verify_arrayB, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}

}

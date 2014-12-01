using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='SignatureDSA']"
	[Register ("com/jcraft/jsch/SignatureDSA", "", "Com.Jcraft.Jsch.ISignatureDSAInvoker")]
	public partial interface ISignatureDSA : global::Com.Jcraft.Jsch.ISignature {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='SignatureDSA']/method[@name='setPrvKey' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
		[Register ("setPrvKey", "([B[B[B[B)V", "GetSetPrvKey_arrayBarrayBarrayBarrayBHandler:Com.Jcraft.Jsch.ISignatureDSAInvoker, JSchBindings")]
		void SetPrvKey (byte[] p0, byte[] p1, byte[] p2, byte[] p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='SignatureDSA']/method[@name='setPubKey' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
		[Register ("setPubKey", "([B[B[B[B)V", "GetSetPubKey_arrayBarrayBarrayBarrayBHandler:Com.Jcraft.Jsch.ISignatureDSAInvoker, JSchBindings")]
		void SetPubKey (byte[] p0, byte[] p1, byte[] p2, byte[] p3);

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/SignatureDSA", DoNotGenerateAcw=true)]
	internal class ISignatureDSAInvoker : global::Java.Lang.Object, ISignatureDSA {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jcraft/jsch/SignatureDSA");
		IntPtr class_ref;

		public static ISignatureDSA GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISignatureDSA> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jcraft.jsch.SignatureDSA"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISignatureDSAInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISignatureDSAInvoker); }
		}

		static Delegate cb_setPrvKey_arrayBarrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetSetPrvKey_arrayBarrayBarrayBarrayBHandler ()
		{
			if (cb_setPrvKey_arrayBarrayBarrayBarrayB == null)
				cb_setPrvKey_arrayBarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPrvKey_arrayBarrayBarrayBarrayB);
			return cb_setPrvKey_arrayBarrayBarrayBarrayB;
		}

		static void n_SetPrvKey_arrayBarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Jcraft.Jsch.ISignatureDSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISignatureDSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetPrvKey (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_setPrvKey_arrayBarrayBarrayBarrayB;
		public void SetPrvKey (byte[] p0, byte[] p1, byte[] p2, byte[] p3)
		{
			if (id_setPrvKey_arrayBarrayBarrayBarrayB == IntPtr.Zero)
				id_setPrvKey_arrayBarrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "setPrvKey", "([B[B[B[B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JNIEnv.CallVoidMethod (Handle, id_setPrvKey_arrayBarrayBarrayBarrayB, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
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

		static Delegate cb_setPubKey_arrayBarrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetSetPubKey_arrayBarrayBarrayBarrayBHandler ()
		{
			if (cb_setPubKey_arrayBarrayBarrayBarrayB == null)
				cb_setPubKey_arrayBarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPubKey_arrayBarrayBarrayBarrayB);
			return cb_setPubKey_arrayBarrayBarrayBarrayB;
		}

		static void n_SetPubKey_arrayBarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Jcraft.Jsch.ISignatureDSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISignatureDSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetPubKey (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_setPubKey_arrayBarrayBarrayBarrayB;
		public void SetPubKey (byte[] p0, byte[] p1, byte[] p2, byte[] p3)
		{
			if (id_setPubKey_arrayBarrayBarrayBarrayB == IntPtr.Zero)
				id_setPubKey_arrayBarrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "setPubKey", "([B[B[B[B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JNIEnv.CallVoidMethod (Handle, id_setPubKey_arrayBarrayBarrayBarrayB, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Jcraft.Jsch.ISignatureDSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISignatureDSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Jcraft.Jsch.ISignatureDSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISignatureDSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Jcraft.Jsch.ISignatureDSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISignatureDSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Jcraft.Jsch.ISignatureDSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISignatureDSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

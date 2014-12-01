using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch.Jce {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='SignatureRSA']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/jce/SignatureRSA", DoNotGenerateAcw=true)]
	public partial class SignatureRSA : global::Java.Lang.Object, global::Com.Jcraft.Jsch.ISignatureRSA {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/jce/SignatureRSA", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SignatureRSA); }
		}

		protected SignatureRSA (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='SignatureRSA']/constructor[@name='SignatureRSA' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public SignatureRSA () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SignatureRSA)) {
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
			global::Com.Jcraft.Jsch.Jce.SignatureRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.SignatureRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='SignatureRSA']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		public virtual void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_init);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "()V"));
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
			global::Com.Jcraft.Jsch.Jce.SignatureRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.SignatureRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetPrvKey (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_setPrvKey_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='SignatureRSA']/method[@name='setPrvKey' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("setPrvKey", "([B[B)V", "GetSetPrvKey_arrayBarrayBHandler")]
		public virtual void SetPrvKey (byte[] p0, byte[] p1)
		{
			if (id_setPrvKey_arrayBarrayB == IntPtr.Zero)
				id_setPrvKey_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "setPrvKey", "([B[B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPrvKey_arrayBarrayB, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPrvKey", "([B[B)V"), new JValue (native_p0), new JValue (native_p1));
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
			global::Com.Jcraft.Jsch.Jce.SignatureRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.SignatureRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetPubKey (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_setPubKey_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='SignatureRSA']/method[@name='setPubKey' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("setPubKey", "([B[B)V", "GetSetPubKey_arrayBarrayBHandler")]
		public virtual void SetPubKey (byte[] p0, byte[] p1)
		{
			if (id_setPubKey_arrayBarrayB == IntPtr.Zero)
				id_setPubKey_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "setPubKey", "([B[B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPubKey_arrayBarrayB, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPubKey", "([B[B)V"), new JValue (native_p0), new JValue (native_p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
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
			global::Com.Jcraft.Jsch.Jce.SignatureRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.SignatureRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Sign ());
		}
#pragma warning restore 0169

		static IntPtr id_sign;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='SignatureRSA']/method[@name='sign' and count(parameter)=0]"
		[Register ("sign", "()[B", "GetSignHandler")]
		public virtual byte[] Sign ()
		{
			if (id_sign == IntPtr.Zero)
				id_sign = JNIEnv.GetMethodID (class_ref, "sign", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_sign), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sign", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Jcraft.Jsch.Jce.SignatureRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.SignatureRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Update (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_update_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='SignatureRSA']/method[@name='update' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("update", "([B)V", "GetUpdate_arrayBHandler")]
		public virtual void Update (byte[] p0)
		{
			if (id_update_arrayB == IntPtr.Zero)
				id_update_arrayB = JNIEnv.GetMethodID (class_ref, "update", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_update_arrayB, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "update", "([B)V"), new JValue (native_p0));
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
			global::Com.Jcraft.Jsch.Jce.SignatureRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.SignatureRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.Verify (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_verify_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='SignatureRSA']/method[@name='verify' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("verify", "([B)Z", "GetVerify_arrayBHandler")]
		public virtual bool Verify (byte[] p0)
		{
			if (id_verify_arrayB == IntPtr.Zero)
				id_verify_arrayB = JNIEnv.GetMethodID (class_ref, "verify", "([B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_verify_arrayB, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "verify", "([B)Z"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}
}

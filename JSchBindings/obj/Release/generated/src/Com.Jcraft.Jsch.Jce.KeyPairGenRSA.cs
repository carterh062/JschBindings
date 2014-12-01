using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch.Jce {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='KeyPairGenRSA']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/jce/KeyPairGenRSA", DoNotGenerateAcw=true)]
	public partial class KeyPairGenRSA : global::Java.Lang.Object, global::Com.Jcraft.Jsch.IKeyPairGenRSA {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/jce/KeyPairGenRSA", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KeyPairGenRSA); }
		}

		protected KeyPairGenRSA (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='KeyPairGenRSA']/constructor[@name='KeyPairGenRSA' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public KeyPairGenRSA () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (KeyPairGenRSA)) {
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

		static Delegate cb_getC;
#pragma warning disable 0169
		static Delegate GetGetCHandler ()
		{
			if (cb_getC == null)
				cb_getC = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetC);
			return cb_getC;
		}

		static IntPtr n_GetC (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Jce.KeyPairGenRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.KeyPairGenRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetC ());
		}
#pragma warning restore 0169

		static IntPtr id_getC;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='KeyPairGenRSA']/method[@name='getC' and count(parameter)=0]"
		[Register ("getC", "()[B", "GetGetCHandler")]
		public virtual byte[] GetC ()
		{
			if (id_getC == IntPtr.Zero)
				id_getC = JNIEnv.GetMethodID (class_ref, "getC", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getC), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getC", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_getD;
#pragma warning disable 0169
		static Delegate GetGetDHandler ()
		{
			if (cb_getD == null)
				cb_getD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetD);
			return cb_getD;
		}

		static IntPtr n_GetD (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Jce.KeyPairGenRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.KeyPairGenRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetD ());
		}
#pragma warning restore 0169

		static IntPtr id_getD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='KeyPairGenRSA']/method[@name='getD' and count(parameter)=0]"
		[Register ("getD", "()[B", "GetGetDHandler")]
		public virtual byte[] GetD ()
		{
			if (id_getD == IntPtr.Zero)
				id_getD = JNIEnv.GetMethodID (class_ref, "getD", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getD), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getD", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_getE;
#pragma warning disable 0169
		static Delegate GetGetEHandler ()
		{
			if (cb_getE == null)
				cb_getE = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetE);
			return cb_getE;
		}

		static IntPtr n_GetE (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Jce.KeyPairGenRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.KeyPairGenRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetE ());
		}
#pragma warning restore 0169

		static IntPtr id_getE;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='KeyPairGenRSA']/method[@name='getE' and count(parameter)=0]"
		[Register ("getE", "()[B", "GetGetEHandler")]
		public virtual byte[] GetE ()
		{
			if (id_getE == IntPtr.Zero)
				id_getE = JNIEnv.GetMethodID (class_ref, "getE", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getE), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getE", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_getEP;
#pragma warning disable 0169
		static Delegate GetGetEPHandler ()
		{
			if (cb_getEP == null)
				cb_getEP = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEP);
			return cb_getEP;
		}

		static IntPtr n_GetEP (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Jce.KeyPairGenRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.KeyPairGenRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEP ());
		}
#pragma warning restore 0169

		static IntPtr id_getEP;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='KeyPairGenRSA']/method[@name='getEP' and count(parameter)=0]"
		[Register ("getEP", "()[B", "GetGetEPHandler")]
		public virtual byte[] GetEP ()
		{
			if (id_getEP == IntPtr.Zero)
				id_getEP = JNIEnv.GetMethodID (class_ref, "getEP", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getEP), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEP", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_getEQ;
#pragma warning disable 0169
		static Delegate GetGetEQHandler ()
		{
			if (cb_getEQ == null)
				cb_getEQ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEQ);
			return cb_getEQ;
		}

		static IntPtr n_GetEQ (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Jce.KeyPairGenRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.KeyPairGenRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEQ ());
		}
#pragma warning restore 0169

		static IntPtr id_getEQ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='KeyPairGenRSA']/method[@name='getEQ' and count(parameter)=0]"
		[Register ("getEQ", "()[B", "GetGetEQHandler")]
		public virtual byte[] GetEQ ()
		{
			if (id_getEQ == IntPtr.Zero)
				id_getEQ = JNIEnv.GetMethodID (class_ref, "getEQ", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getEQ), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEQ", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_getN;
#pragma warning disable 0169
		static Delegate GetGetNHandler ()
		{
			if (cb_getN == null)
				cb_getN = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetN);
			return cb_getN;
		}

		static IntPtr n_GetN (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Jce.KeyPairGenRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.KeyPairGenRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetN ());
		}
#pragma warning restore 0169

		static IntPtr id_getN;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='KeyPairGenRSA']/method[@name='getN' and count(parameter)=0]"
		[Register ("getN", "()[B", "GetGetNHandler")]
		public virtual byte[] GetN ()
		{
			if (id_getN == IntPtr.Zero)
				id_getN = JNIEnv.GetMethodID (class_ref, "getN", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getN), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getN", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_getP;
#pragma warning disable 0169
		static Delegate GetGetPHandler ()
		{
			if (cb_getP == null)
				cb_getP = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetP);
			return cb_getP;
		}

		static IntPtr n_GetP (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Jce.KeyPairGenRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.KeyPairGenRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetP ());
		}
#pragma warning restore 0169

		static IntPtr id_getP;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='KeyPairGenRSA']/method[@name='getP' and count(parameter)=0]"
		[Register ("getP", "()[B", "GetGetPHandler")]
		public virtual byte[] GetP ()
		{
			if (id_getP == IntPtr.Zero)
				id_getP = JNIEnv.GetMethodID (class_ref, "getP", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getP), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getP", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_getQ;
#pragma warning disable 0169
		static Delegate GetGetQHandler ()
		{
			if (cb_getQ == null)
				cb_getQ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetQ);
			return cb_getQ;
		}

		static IntPtr n_GetQ (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Jce.KeyPairGenRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.KeyPairGenRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetQ ());
		}
#pragma warning restore 0169

		static IntPtr id_getQ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='KeyPairGenRSA']/method[@name='getQ' and count(parameter)=0]"
		[Register ("getQ", "()[B", "GetGetQHandler")]
		public virtual byte[] GetQ ()
		{
			if (id_getQ == IntPtr.Zero)
				id_getQ = JNIEnv.GetMethodID (class_ref, "getQ", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getQ), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQ", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_init_I;
#pragma warning disable 0169
		static Delegate GetInit_IHandler ()
		{
			if (cb_init_I == null)
				cb_init_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Init_I);
			return cb_init_I;
		}

		static void n_Init_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jcraft.Jsch.Jce.KeyPairGenRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.KeyPairGenRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		static IntPtr id_init_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='KeyPairGenRSA']/method[@name='init' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("init", "(I)V", "GetInit_IHandler")]
		public virtual void Init (int p0)
		{
			if (id_init_I == IntPtr.Zero)
				id_init_I = JNIEnv.GetMethodID (class_ref, "init", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_init_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(I)V"), new JValue (p0));
		}

	}
}

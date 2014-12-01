using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='KeyPairGenRSA']"
	[Register ("com/jcraft/jsch/KeyPairGenRSA", "", "Com.Jcraft.Jsch.IKeyPairGenRSAInvoker")]
	public partial interface IKeyPairGenRSA : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='KeyPairGenRSA']/method[@name='getC' and count(parameter)=0]"
		[Register ("getC", "()[B", "GetGetCHandler:Com.Jcraft.Jsch.IKeyPairGenRSAInvoker, JSchBindings")]
		byte[] GetC ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='KeyPairGenRSA']/method[@name='getD' and count(parameter)=0]"
		[Register ("getD", "()[B", "GetGetDHandler:Com.Jcraft.Jsch.IKeyPairGenRSAInvoker, JSchBindings")]
		byte[] GetD ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='KeyPairGenRSA']/method[@name='getE' and count(parameter)=0]"
		[Register ("getE", "()[B", "GetGetEHandler:Com.Jcraft.Jsch.IKeyPairGenRSAInvoker, JSchBindings")]
		byte[] GetE ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='KeyPairGenRSA']/method[@name='getEP' and count(parameter)=0]"
		[Register ("getEP", "()[B", "GetGetEPHandler:Com.Jcraft.Jsch.IKeyPairGenRSAInvoker, JSchBindings")]
		byte[] GetEP ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='KeyPairGenRSA']/method[@name='getEQ' and count(parameter)=0]"
		[Register ("getEQ", "()[B", "GetGetEQHandler:Com.Jcraft.Jsch.IKeyPairGenRSAInvoker, JSchBindings")]
		byte[] GetEQ ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='KeyPairGenRSA']/method[@name='getN' and count(parameter)=0]"
		[Register ("getN", "()[B", "GetGetNHandler:Com.Jcraft.Jsch.IKeyPairGenRSAInvoker, JSchBindings")]
		byte[] GetN ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='KeyPairGenRSA']/method[@name='getP' and count(parameter)=0]"
		[Register ("getP", "()[B", "GetGetPHandler:Com.Jcraft.Jsch.IKeyPairGenRSAInvoker, JSchBindings")]
		byte[] GetP ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='KeyPairGenRSA']/method[@name='getQ' and count(parameter)=0]"
		[Register ("getQ", "()[B", "GetGetQHandler:Com.Jcraft.Jsch.IKeyPairGenRSAInvoker, JSchBindings")]
		byte[] GetQ ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='KeyPairGenRSA']/method[@name='init' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("init", "(I)V", "GetInit_IHandler:Com.Jcraft.Jsch.IKeyPairGenRSAInvoker, JSchBindings")]
		void Init (int p0);

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/KeyPairGenRSA", DoNotGenerateAcw=true)]
	internal class IKeyPairGenRSAInvoker : global::Java.Lang.Object, IKeyPairGenRSA {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jcraft/jsch/KeyPairGenRSA");
		IntPtr class_ref;

		public static IKeyPairGenRSA GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IKeyPairGenRSA> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jcraft.jsch.KeyPairGenRSA"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IKeyPairGenRSAInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IKeyPairGenRSAInvoker); }
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
			global::Com.Jcraft.Jsch.IKeyPairGenRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IKeyPairGenRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetC ());
		}
#pragma warning restore 0169

		IntPtr id_getC;
		public byte[] GetC ()
		{
			if (id_getC == IntPtr.Zero)
				id_getC = JNIEnv.GetMethodID (class_ref, "getC", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getC), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Jcraft.Jsch.IKeyPairGenRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IKeyPairGenRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetD ());
		}
#pragma warning restore 0169

		IntPtr id_getD;
		public byte[] GetD ()
		{
			if (id_getD == IntPtr.Zero)
				id_getD = JNIEnv.GetMethodID (class_ref, "getD", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getD), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Jcraft.Jsch.IKeyPairGenRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IKeyPairGenRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetE ());
		}
#pragma warning restore 0169

		IntPtr id_getE;
		public byte[] GetE ()
		{
			if (id_getE == IntPtr.Zero)
				id_getE = JNIEnv.GetMethodID (class_ref, "getE", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getE), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Jcraft.Jsch.IKeyPairGenRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IKeyPairGenRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEP ());
		}
#pragma warning restore 0169

		IntPtr id_getEP;
		public byte[] GetEP ()
		{
			if (id_getEP == IntPtr.Zero)
				id_getEP = JNIEnv.GetMethodID (class_ref, "getEP", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getEP), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Jcraft.Jsch.IKeyPairGenRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IKeyPairGenRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEQ ());
		}
#pragma warning restore 0169

		IntPtr id_getEQ;
		public byte[] GetEQ ()
		{
			if (id_getEQ == IntPtr.Zero)
				id_getEQ = JNIEnv.GetMethodID (class_ref, "getEQ", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getEQ), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Jcraft.Jsch.IKeyPairGenRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IKeyPairGenRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetN ());
		}
#pragma warning restore 0169

		IntPtr id_getN;
		public byte[] GetN ()
		{
			if (id_getN == IntPtr.Zero)
				id_getN = JNIEnv.GetMethodID (class_ref, "getN", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getN), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Jcraft.Jsch.IKeyPairGenRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IKeyPairGenRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetP ());
		}
#pragma warning restore 0169

		IntPtr id_getP;
		public byte[] GetP ()
		{
			if (id_getP == IntPtr.Zero)
				id_getP = JNIEnv.GetMethodID (class_ref, "getP", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getP), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Jcraft.Jsch.IKeyPairGenRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IKeyPairGenRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetQ ());
		}
#pragma warning restore 0169

		IntPtr id_getQ;
		public byte[] GetQ ()
		{
			if (id_getQ == IntPtr.Zero)
				id_getQ = JNIEnv.GetMethodID (class_ref, "getQ", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getQ), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Jcraft.Jsch.IKeyPairGenRSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IKeyPairGenRSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		IntPtr id_init_I;
		public void Init (int p0)
		{
			if (id_init_I == IntPtr.Zero)
				id_init_I = JNIEnv.GetMethodID (class_ref, "init", "(I)V");
			JNIEnv.CallVoidMethod (Handle, id_init_I, new JValue (p0));
		}

	}

}

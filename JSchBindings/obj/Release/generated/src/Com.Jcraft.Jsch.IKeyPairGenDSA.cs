using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='KeyPairGenDSA']"
	[Register ("com/jcraft/jsch/KeyPairGenDSA", "", "Com.Jcraft.Jsch.IKeyPairGenDSAInvoker")]
	public partial interface IKeyPairGenDSA : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='KeyPairGenDSA']/method[@name='getG' and count(parameter)=0]"
		[Register ("getG", "()[B", "GetGetGHandler:Com.Jcraft.Jsch.IKeyPairGenDSAInvoker, JSchBindings")]
		byte[] GetG ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='KeyPairGenDSA']/method[@name='getP' and count(parameter)=0]"
		[Register ("getP", "()[B", "GetGetPHandler:Com.Jcraft.Jsch.IKeyPairGenDSAInvoker, JSchBindings")]
		byte[] GetP ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='KeyPairGenDSA']/method[@name='getQ' and count(parameter)=0]"
		[Register ("getQ", "()[B", "GetGetQHandler:Com.Jcraft.Jsch.IKeyPairGenDSAInvoker, JSchBindings")]
		byte[] GetQ ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='KeyPairGenDSA']/method[@name='getX' and count(parameter)=0]"
		[Register ("getX", "()[B", "GetGetXHandler:Com.Jcraft.Jsch.IKeyPairGenDSAInvoker, JSchBindings")]
		byte[] GetX ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='KeyPairGenDSA']/method[@name='getY' and count(parameter)=0]"
		[Register ("getY", "()[B", "GetGetYHandler:Com.Jcraft.Jsch.IKeyPairGenDSAInvoker, JSchBindings")]
		byte[] GetY ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='KeyPairGenDSA']/method[@name='init' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("init", "(I)V", "GetInit_IHandler:Com.Jcraft.Jsch.IKeyPairGenDSAInvoker, JSchBindings")]
		void Init (int p0);

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/KeyPairGenDSA", DoNotGenerateAcw=true)]
	internal class IKeyPairGenDSAInvoker : global::Java.Lang.Object, IKeyPairGenDSA {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jcraft/jsch/KeyPairGenDSA");
		IntPtr class_ref;

		public static IKeyPairGenDSA GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IKeyPairGenDSA> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jcraft.jsch.KeyPairGenDSA"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IKeyPairGenDSAInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IKeyPairGenDSAInvoker); }
		}

		static Delegate cb_getG;
#pragma warning disable 0169
		static Delegate GetGetGHandler ()
		{
			if (cb_getG == null)
				cb_getG = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetG);
			return cb_getG;
		}

		static IntPtr n_GetG (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.IKeyPairGenDSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IKeyPairGenDSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetG ());
		}
#pragma warning restore 0169

		IntPtr id_getG;
		public byte[] GetG ()
		{
			if (id_getG == IntPtr.Zero)
				id_getG = JNIEnv.GetMethodID (class_ref, "getG", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getG), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Jcraft.Jsch.IKeyPairGenDSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IKeyPairGenDSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Jcraft.Jsch.IKeyPairGenDSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IKeyPairGenDSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getX;
#pragma warning disable 0169
		static Delegate GetGetXHandler ()
		{
			if (cb_getX == null)
				cb_getX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetX);
			return cb_getX;
		}

		static IntPtr n_GetX (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.IKeyPairGenDSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IKeyPairGenDSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetX ());
		}
#pragma warning restore 0169

		IntPtr id_getX;
		public byte[] GetX ()
		{
			if (id_getX == IntPtr.Zero)
				id_getX = JNIEnv.GetMethodID (class_ref, "getX", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getX), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_getY;
#pragma warning disable 0169
		static Delegate GetGetYHandler ()
		{
			if (cb_getY == null)
				cb_getY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetY);
			return cb_getY;
		}

		static IntPtr n_GetY (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.IKeyPairGenDSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IKeyPairGenDSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetY ());
		}
#pragma warning restore 0169

		IntPtr id_getY;
		public byte[] GetY ()
		{
			if (id_getY == IntPtr.Zero)
				id_getY = JNIEnv.GetMethodID (class_ref, "getY", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getY), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Jcraft.Jsch.IKeyPairGenDSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IKeyPairGenDSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

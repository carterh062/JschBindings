using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch.Jce {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='KeyPairGenDSA']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/jce/KeyPairGenDSA", DoNotGenerateAcw=true)]
	public partial class KeyPairGenDSA : global::Java.Lang.Object, global::Com.Jcraft.Jsch.IKeyPairGenDSA {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/jce/KeyPairGenDSA", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KeyPairGenDSA); }
		}

		protected KeyPairGenDSA (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='KeyPairGenDSA']/constructor[@name='KeyPairGenDSA' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public KeyPairGenDSA () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (KeyPairGenDSA)) {
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
			global::Com.Jcraft.Jsch.Jce.KeyPairGenDSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.KeyPairGenDSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetG ());
		}
#pragma warning restore 0169

		static IntPtr id_getG;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='KeyPairGenDSA']/method[@name='getG' and count(parameter)=0]"
		[Register ("getG", "()[B", "GetGetGHandler")]
		public virtual byte[] GetG ()
		{
			if (id_getG == IntPtr.Zero)
				id_getG = JNIEnv.GetMethodID (class_ref, "getG", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getG), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getG", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Jcraft.Jsch.Jce.KeyPairGenDSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.KeyPairGenDSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetP ());
		}
#pragma warning restore 0169

		static IntPtr id_getP;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='KeyPairGenDSA']/method[@name='getP' and count(parameter)=0]"
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
			global::Com.Jcraft.Jsch.Jce.KeyPairGenDSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.KeyPairGenDSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetQ ());
		}
#pragma warning restore 0169

		static IntPtr id_getQ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='KeyPairGenDSA']/method[@name='getQ' and count(parameter)=0]"
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
			global::Com.Jcraft.Jsch.Jce.KeyPairGenDSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.KeyPairGenDSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetX ());
		}
#pragma warning restore 0169

		static IntPtr id_getX;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='KeyPairGenDSA']/method[@name='getX' and count(parameter)=0]"
		[Register ("getX", "()[B", "GetGetXHandler")]
		public virtual byte[] GetX ()
		{
			if (id_getX == IntPtr.Zero)
				id_getX = JNIEnv.GetMethodID (class_ref, "getX", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getX), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getX", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Jcraft.Jsch.Jce.KeyPairGenDSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.KeyPairGenDSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetY ());
		}
#pragma warning restore 0169

		static IntPtr id_getY;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='KeyPairGenDSA']/method[@name='getY' and count(parameter)=0]"
		[Register ("getY", "()[B", "GetGetYHandler")]
		public virtual byte[] GetY ()
		{
			if (id_getY == IntPtr.Zero)
				id_getY = JNIEnv.GetMethodID (class_ref, "getY", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getY), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getY", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Jcraft.Jsch.Jce.KeyPairGenDSA __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.KeyPairGenDSA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		static IntPtr id_init_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='KeyPairGenDSA']/method[@name='init' and count(parameter)=1 and parameter[1][@type='int']]"
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

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch.Jce {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='DH']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/jce/DH", DoNotGenerateAcw=true)]
	public partial class DH : global::Java.Lang.Object, global::Com.Jcraft.Jsch.IDH {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/jce/DH", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DH); }
		}

		protected DH (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='DH']/constructor[@name='DH' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DH () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DH)) {
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
			global::Com.Jcraft.Jsch.Jce.DH __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.DH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetE ());
		}
#pragma warning restore 0169

		static IntPtr id_getE;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='DH']/method[@name='getE' and count(parameter)=0]"
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

		static Delegate cb_getK;
#pragma warning disable 0169
		static Delegate GetGetKHandler ()
		{
			if (cb_getK == null)
				cb_getK = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetK);
			return cb_getK;
		}

		static IntPtr n_GetK (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Jce.DH __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.DH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetK ());
		}
#pragma warning restore 0169

		static IntPtr id_getK;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='DH']/method[@name='getK' and count(parameter)=0]"
		[Register ("getK", "()[B", "GetGetKHandler")]
		public virtual byte[] GetK ()
		{
			if (id_getK == IntPtr.Zero)
				id_getK = JNIEnv.GetMethodID (class_ref, "getK", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getK), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getK", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Jcraft.Jsch.Jce.DH __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.DH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='DH']/method[@name='init' and count(parameter)=0]"
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

		static Delegate cb_setF_arrayB;
#pragma warning disable 0169
		static Delegate GetSetF_arrayBHandler ()
		{
			if (cb_setF_arrayB == null)
				cb_setF_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetF_arrayB);
			return cb_setF_arrayB;
		}

		static void n_SetF_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Jce.DH __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.DH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetF (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setF_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='DH']/method[@name='setF' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setF", "([B)V", "GetSetF_arrayBHandler")]
		public virtual void SetF (byte[] p0)
		{
			if (id_setF_arrayB == IntPtr.Zero)
				id_setF_arrayB = JNIEnv.GetMethodID (class_ref, "setF", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setF_arrayB, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setF", "([B)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setG_arrayB;
#pragma warning disable 0169
		static Delegate GetSetG_arrayBHandler ()
		{
			if (cb_setG_arrayB == null)
				cb_setG_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetG_arrayB);
			return cb_setG_arrayB;
		}

		static void n_SetG_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Jce.DH __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.DH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetG (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setG_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='DH']/method[@name='setG' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setG", "([B)V", "GetSetG_arrayBHandler")]
		public virtual void SetG (byte[] p0)
		{
			if (id_setG_arrayB == IntPtr.Zero)
				id_setG_arrayB = JNIEnv.GetMethodID (class_ref, "setG", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setG_arrayB, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setG", "([B)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setP_arrayB;
#pragma warning disable 0169
		static Delegate GetSetP_arrayBHandler ()
		{
			if (cb_setP_arrayB == null)
				cb_setP_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetP_arrayB);
			return cb_setP_arrayB;
		}

		static void n_SetP_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Jce.DH __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.DH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetP (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setP_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='DH']/method[@name='setP' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setP", "([B)V", "GetSetP_arrayBHandler")]
		public virtual void SetP (byte[] p0)
		{
			if (id_setP_arrayB == IntPtr.Zero)
				id_setP_arrayB = JNIEnv.GetMethodID (class_ref, "setP", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setP_arrayB, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setP", "([B)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}

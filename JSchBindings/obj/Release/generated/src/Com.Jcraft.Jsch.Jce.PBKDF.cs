using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch.Jce {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='PBKDF']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/jce/PBKDF", DoNotGenerateAcw=true)]
	public partial class PBKDF : global::Java.Lang.Object, global::Com.Jcraft.Jsch.IPBKDF {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/jce/PBKDF", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PBKDF); }
		}

		protected PBKDF (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='PBKDF']/constructor[@name='PBKDF' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public PBKDF () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PBKDF)) {
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

		static Delegate cb_getKey_arrayBarrayBII;
#pragma warning disable 0169
		static Delegate GetGetKey_arrayBarrayBIIHandler ()
		{
			if (cb_getKey_arrayBarrayBII == null)
				cb_getKey_arrayBarrayBII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_GetKey_arrayBarrayBII);
			return cb_getKey_arrayBarrayBII;
		}

		static IntPtr n_GetKey_arrayBarrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			global::Com.Jcraft.Jsch.Jce.PBKDF __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.PBKDF> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.GetKey (p0, p1, p2, p3));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getKey_arrayBarrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='PBKDF']/method[@name='getKey' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("getKey", "([B[BII)[B", "GetGetKey_arrayBarrayBIIHandler")]
		public virtual byte[] GetKey (byte[] p0, byte[] p1, int p2, int p3)
		{
			if (id_getKey_arrayBarrayBII == IntPtr.Zero)
				id_getKey_arrayBarrayBII = JNIEnv.GetMethodID (class_ref, "getKey", "([B[BII)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			byte[] __ret;
			if (GetType () == ThresholdType)
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getKey_arrayBarrayBII, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKey", "([B[BII)[B"), new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

	}
}

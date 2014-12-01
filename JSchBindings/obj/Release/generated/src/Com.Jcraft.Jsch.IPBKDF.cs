using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='PBKDF']"
	[Register ("com/jcraft/jsch/PBKDF", "", "Com.Jcraft.Jsch.IPBKDFInvoker")]
	public partial interface IPBKDF : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='PBKDF']/method[@name='getKey' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("getKey", "([B[BII)[B", "GetGetKey_arrayBarrayBIIHandler:Com.Jcraft.Jsch.IPBKDFInvoker, JSchBindings")]
		byte[] GetKey (byte[] p0, byte[] p1, int p2, int p3);

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/PBKDF", DoNotGenerateAcw=true)]
	internal class IPBKDFInvoker : global::Java.Lang.Object, IPBKDF {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jcraft/jsch/PBKDF");
		IntPtr class_ref;

		public static IPBKDF GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPBKDF> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jcraft.jsch.PBKDF"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPBKDFInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IPBKDFInvoker); }
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
			global::Com.Jcraft.Jsch.IPBKDF __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IPBKDF> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		IntPtr id_getKey_arrayBarrayBII;
		public byte[] GetKey (byte[] p0, byte[] p1, int p2, int p3)
		{
			if (id_getKey_arrayBarrayBII == IntPtr.Zero)
				id_getKey_arrayBarrayBII = JNIEnv.GetMethodID (class_ref, "getKey", "([B[BII)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getKey_arrayBarrayBII, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef, typeof (byte));
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

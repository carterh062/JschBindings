using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	[Register ("com/jcraft/jsch/Cipher")]
	public abstract class Cipher {

		internal Cipher ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Cipher']/field[@name='DECRYPT_MODE']"
		[Register ("DECRYPT_MODE")]
		public const int DecryptMode = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Cipher']/field[@name='ENCRYPT_MODE']"
		[Register ("ENCRYPT_MODE")]
		public const int EncryptMode = (int) 0;
	}

	[System.Obsolete ("Use the 'Cipher' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class CipherConsts : Cipher {

		private CipherConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Cipher']"
	[Register ("com/jcraft/jsch/Cipher", "", "Com.Jcraft.Jsch.ICipherInvoker")]
	public partial interface ICipher : IJavaObject {

		int BlockSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Cipher']/method[@name='getBlockSize' and count(parameter)=0]"
			[Register ("getBlockSize", "()I", "GetGetBlockSizeHandler:Com.Jcraft.Jsch.ICipherInvoker, JSchBindings")] get;
		}

		int IVSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Cipher']/method[@name='getIVSize' and count(parameter)=0]"
			[Register ("getIVSize", "()I", "GetGetIVSizeHandler:Com.Jcraft.Jsch.ICipherInvoker, JSchBindings")] get;
		}

		bool IsCBC {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Cipher']/method[@name='isCBC' and count(parameter)=0]"
			[Register ("isCBC", "()Z", "GetIsCBCHandler:Com.Jcraft.Jsch.ICipherInvoker, JSchBindings")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Cipher']/method[@name='init' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("init", "(I[B[B)V", "GetInit_IarrayBarrayBHandler:Com.Jcraft.Jsch.ICipherInvoker, JSchBindings")]
		void Init (int p0, byte[] p1, byte[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Cipher']/method[@name='update' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int']]"
		[Register ("update", "([BII[BI)V", "GetUpdate_arrayBIIarrayBIHandler:Com.Jcraft.Jsch.ICipherInvoker, JSchBindings")]
		void Update (byte[] p0, int p1, int p2, byte[] p3, int p4);

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/Cipher", DoNotGenerateAcw=true)]
	internal class ICipherInvoker : global::Java.Lang.Object, ICipher {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jcraft/jsch/Cipher");
		IntPtr class_ref;

		public static ICipher GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICipher> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jcraft.jsch.Cipher"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICipherInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ICipherInvoker); }
		}

		static Delegate cb_getBlockSize;
#pragma warning disable 0169
		static Delegate GetGetBlockSizeHandler ()
		{
			if (cb_getBlockSize == null)
				cb_getBlockSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBlockSize);
			return cb_getBlockSize;
		}

		static int n_GetBlockSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.ICipher __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ICipher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BlockSize;
		}
#pragma warning restore 0169

		IntPtr id_getBlockSize;
		public int BlockSize {
			get {
				if (id_getBlockSize == IntPtr.Zero)
					id_getBlockSize = JNIEnv.GetMethodID (class_ref, "getBlockSize", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getBlockSize);
			}
		}

		static Delegate cb_getIVSize;
#pragma warning disable 0169
		static Delegate GetGetIVSizeHandler ()
		{
			if (cb_getIVSize == null)
				cb_getIVSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIVSize);
			return cb_getIVSize;
		}

		static int n_GetIVSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.ICipher __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ICipher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IVSize;
		}
#pragma warning restore 0169

		IntPtr id_getIVSize;
		public int IVSize {
			get {
				if (id_getIVSize == IntPtr.Zero)
					id_getIVSize = JNIEnv.GetMethodID (class_ref, "getIVSize", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getIVSize);
			}
		}

		static Delegate cb_isCBC;
#pragma warning disable 0169
		static Delegate GetIsCBCHandler ()
		{
			if (cb_isCBC == null)
				cb_isCBC = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCBC);
			return cb_isCBC;
		}

		static bool n_IsCBC (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.ICipher __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ICipher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCBC;
		}
#pragma warning restore 0169

		IntPtr id_isCBC;
		public bool IsCBC {
			get {
				if (id_isCBC == IntPtr.Zero)
					id_isCBC = JNIEnv.GetMethodID (class_ref, "isCBC", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isCBC);
			}
		}

		static Delegate cb_init_IarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetInit_IarrayBarrayBHandler ()
		{
			if (cb_init_IarrayBarrayB == null)
				cb_init_IarrayBarrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_Init_IarrayBarrayB);
			return cb_init_IarrayBarrayB;
		}

		static void n_Init_IarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Jcraft.Jsch.ICipher __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ICipher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Init (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_init_IarrayBarrayB;
		public void Init (int p0, byte[] p1, byte[] p2)
		{
			if (id_init_IarrayBarrayB == IntPtr.Zero)
				id_init_IarrayBarrayB = JNIEnv.GetMethodID (class_ref, "init", "(I[B[B)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JNIEnv.CallVoidMethod (Handle, id_init_IarrayBarrayB, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_update_arrayBIIarrayBI;
#pragma warning disable 0169
		static Delegate GetUpdate_arrayBIIarrayBIHandler ()
		{
			if (cb_update_arrayBIIarrayBI == null)
				cb_update_arrayBIIarrayBI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, IntPtr, int>) n_Update_arrayBIIarrayBI);
			return cb_update_arrayBIIarrayBI;
		}

		static void n_Update_arrayBIIarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3, int p4)
		{
			global::Com.Jcraft.Jsch.ICipher __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ICipher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Update (p0, p1, p2, p3, p4);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_update_arrayBIIarrayBI;
		public void Update (byte[] p0, int p1, int p2, byte[] p3, int p4)
		{
			if (id_update_arrayBIIarrayBI == IntPtr.Zero)
				id_update_arrayBIIarrayBI = JNIEnv.GetMethodID (class_ref, "update", "([BII[BI)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JNIEnv.CallVoidMethod (Handle, id_update_arrayBIIarrayBI, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (native_p3), new JValue (p4));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}

}

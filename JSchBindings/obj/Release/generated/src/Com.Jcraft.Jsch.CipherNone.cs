using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='CipherNone']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/CipherNone", DoNotGenerateAcw=true)]
	public partial class CipherNone : global::Java.Lang.Object, global::Com.Jcraft.Jsch.ICipher {


		public static class InterfaceConsts {

			// The following are fields from: com.jcraft.jsch.Cipher

			// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Cipher']/field[@name='DECRYPT_MODE']"
			[Register ("DECRYPT_MODE")]
			public const int DecryptMode = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Cipher']/field[@name='ENCRYPT_MODE']"
			[Register ("ENCRYPT_MODE")]
			public const int EncryptMode = (int) 0;
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/CipherNone", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CipherNone); }
		}

		protected CipherNone (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='CipherNone']/constructor[@name='CipherNone' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public CipherNone () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CipherNone)) {
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
			global::Com.Jcraft.Jsch.CipherNone __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.CipherNone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BlockSize;
		}
#pragma warning restore 0169

		static IntPtr id_getBlockSize;
		public virtual int BlockSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='CipherNone']/method[@name='getBlockSize' and count(parameter)=0]"
			[Register ("getBlockSize", "()I", "GetGetBlockSizeHandler")]
			get {
				if (id_getBlockSize == IntPtr.Zero)
					id_getBlockSize = JNIEnv.GetMethodID (class_ref, "getBlockSize", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getBlockSize);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBlockSize", "()I"));
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
			global::Com.Jcraft.Jsch.CipherNone __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.CipherNone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IVSize;
		}
#pragma warning restore 0169

		static IntPtr id_getIVSize;
		public virtual int IVSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='CipherNone']/method[@name='getIVSize' and count(parameter)=0]"
			[Register ("getIVSize", "()I", "GetGetIVSizeHandler")]
			get {
				if (id_getIVSize == IntPtr.Zero)
					id_getIVSize = JNIEnv.GetMethodID (class_ref, "getIVSize", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getIVSize);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIVSize", "()I"));
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
			global::Com.Jcraft.Jsch.CipherNone __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.CipherNone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCBC;
		}
#pragma warning restore 0169

		static IntPtr id_isCBC;
		public virtual bool IsCBC {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='CipherNone']/method[@name='isCBC' and count(parameter)=0]"
			[Register ("isCBC", "()Z", "GetIsCBCHandler")]
			get {
				if (id_isCBC == IntPtr.Zero)
					id_isCBC = JNIEnv.GetMethodID (class_ref, "isCBC", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isCBC);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCBC", "()Z"));
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
			global::Com.Jcraft.Jsch.CipherNone __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.CipherNone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Init (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_init_IarrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='CipherNone']/method[@name='init' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("init", "(I[B[B)V", "GetInit_IarrayBarrayBHandler")]
		public virtual void Init (int p0, byte[] p1, byte[] p2)
		{
			if (id_init_IarrayBarrayB == IntPtr.Zero)
				id_init_IarrayBarrayB = JNIEnv.GetMethodID (class_ref, "init", "(I[B[B)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_init_IarrayBarrayB, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(I[B[B)V"), new JValue (p0), new JValue (native_p1), new JValue (native_p2));
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
			global::Com.Jcraft.Jsch.CipherNone __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.CipherNone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Update (p0, p1, p2, p3, p4);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		static IntPtr id_update_arrayBIIarrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='CipherNone']/method[@name='update' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int']]"
		[Register ("update", "([BII[BI)V", "GetUpdate_arrayBIIarrayBIHandler")]
		public virtual void Update (byte[] p0, int p1, int p2, byte[] p3, int p4)
		{
			if (id_update_arrayBIIarrayBI == IntPtr.Zero)
				id_update_arrayBIIarrayBI = JNIEnv.GetMethodID (class_ref, "update", "([BII[BI)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_update_arrayBIIarrayBI, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (native_p3), new JValue (p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "update", "([BII[BI)V"), new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (native_p3), new JValue (p4));
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

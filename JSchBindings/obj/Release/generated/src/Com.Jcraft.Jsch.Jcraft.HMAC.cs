using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch.Jcraft {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch.jcraft']/class[@name='HMAC']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/jcraft/HMAC", DoNotGenerateAcw=true)]
	public partial class HMAC : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/jcraft/HMAC", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HMAC); }
		}

		protected HMAC (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Jcraft.Jsch.Jcraft.HMAC __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jcraft.HMAC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BlockSize;
		}
#pragma warning restore 0169

		static IntPtr id_getBlockSize;
		public virtual int BlockSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jcraft']/class[@name='HMAC']/method[@name='getBlockSize' and count(parameter)=0]"
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

		static Delegate cb_doFinal_arrayBI;
#pragma warning disable 0169
		static Delegate GetDoFinal_arrayBIHandler ()
		{
			if (cb_doFinal_arrayBI == null)
				cb_doFinal_arrayBI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_DoFinal_arrayBI);
			return cb_doFinal_arrayBI;
		}

		static void n_DoFinal_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Jcraft.Jsch.Jcraft.HMAC __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jcraft.HMAC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.DoFinal (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_doFinal_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jcraft']/class[@name='HMAC']/method[@name='doFinal' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("doFinal", "([BI)V", "GetDoFinal_arrayBIHandler")]
		public virtual void DoFinal (byte[] p0, int p1)
		{
			if (id_doFinal_arrayBI == IntPtr.Zero)
				id_doFinal_arrayBI = JNIEnv.GetMethodID (class_ref, "doFinal", "([BI)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_doFinal_arrayBI, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doFinal", "([BI)V"), new JValue (native_p0), new JValue (p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_init_arrayB;
#pragma warning disable 0169
		static Delegate GetInit_arrayBHandler ()
		{
			if (cb_init_arrayB == null)
				cb_init_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_arrayB);
			return cb_init_arrayB;
		}

		static void n_Init_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Jcraft.HMAC __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jcraft.HMAC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Init (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_init_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jcraft']/class[@name='HMAC']/method[@name='init' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("init", "([B)V", "GetInit_arrayBHandler")]
		public virtual void Init (byte[] p0)
		{
			if (id_init_arrayB == IntPtr.Zero)
				id_init_arrayB = JNIEnv.GetMethodID (class_ref, "init", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_init_arrayB, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "([B)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setH_Ljava_security_MessageDigest_;
#pragma warning disable 0169
		static Delegate GetSetH_Ljava_security_MessageDigest_Handler ()
		{
			if (cb_setH_Ljava_security_MessageDigest_ == null)
				cb_setH_Ljava_security_MessageDigest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetH_Ljava_security_MessageDigest_);
			return cb_setH_Ljava_security_MessageDigest_;
		}

		static void n_SetH_Ljava_security_MessageDigest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Jcraft.HMAC __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jcraft.HMAC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.MessageDigest p0 = global::Java.Lang.Object.GetObject<global::Java.Security.MessageDigest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetH (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setH_Ljava_security_MessageDigest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jcraft']/class[@name='HMAC']/method[@name='setH' and count(parameter)=1 and parameter[1][@type='java.security.MessageDigest']]"
		[Register ("setH", "(Ljava/security/MessageDigest;)V", "GetSetH_Ljava_security_MessageDigest_Handler")]
		protected virtual void SetH (global::Java.Security.MessageDigest p0)
		{
			if (id_setH_Ljava_security_MessageDigest_ == IntPtr.Zero)
				id_setH_Ljava_security_MessageDigest_ = JNIEnv.GetMethodID (class_ref, "setH", "(Ljava/security/MessageDigest;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setH_Ljava_security_MessageDigest_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setH", "(Ljava/security/MessageDigest;)V"), new JValue (p0));
		}

		static Delegate cb_update_arrayBII;
#pragma warning disable 0169
		static Delegate GetUpdate_arrayBIIHandler ()
		{
			if (cb_update_arrayBII == null)
				cb_update_arrayBII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_Update_arrayBII);
			return cb_update_arrayBII;
		}

		static void n_Update_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Jcraft.Jsch.Jcraft.HMAC __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jcraft.HMAC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Update (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_update_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jcraft']/class[@name='HMAC']/method[@name='update' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("update", "([BII)V", "GetUpdate_arrayBIIHandler")]
		public virtual void Update (byte[] p0, int p1, int p2)
		{
			if (id_update_arrayBII == IntPtr.Zero)
				id_update_arrayBII = JNIEnv.GetMethodID (class_ref, "update", "([BII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_update_arrayBII, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "update", "([BII)V"), new JValue (native_p0), new JValue (p1), new JValue (p2));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_update_I;
#pragma warning disable 0169
		static Delegate GetUpdate_IHandler ()
		{
			if (cb_update_I == null)
				cb_update_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Update_I);
			return cb_update_I;
		}

		static void n_Update_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jcraft.Jsch.Jcraft.HMAC __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jcraft.HMAC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Update (p0);
		}
#pragma warning restore 0169

		static IntPtr id_update_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jcraft']/class[@name='HMAC']/method[@name='update' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("update", "(I)V", "GetUpdate_IHandler")]
		public virtual void Update (int p0)
		{
			if (id_update_I == IntPtr.Zero)
				id_update_I = JNIEnv.GetMethodID (class_ref, "update", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_update_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "update", "(I)V"), new JValue (p0));
		}

	}
}

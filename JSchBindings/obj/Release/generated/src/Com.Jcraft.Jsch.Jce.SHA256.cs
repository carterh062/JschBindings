using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch.Jce {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='SHA256']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/jce/SHA256", DoNotGenerateAcw=true)]
	public partial class SHA256 : global::Java.Lang.Object, global::Com.Jcraft.Jsch.IHASH {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/jce/SHA256", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SHA256); }
		}

		protected SHA256 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='SHA256']/constructor[@name='SHA256' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public SHA256 () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SHA256)) {
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
			global::Com.Jcraft.Jsch.Jce.SHA256 __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.SHA256> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BlockSize;
		}
#pragma warning restore 0169

		static IntPtr id_getBlockSize;
		public virtual int BlockSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='SHA256']/method[@name='getBlockSize' and count(parameter)=0]"
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

		static Delegate cb_digest;
#pragma warning disable 0169
		static Delegate GetDigestHandler ()
		{
			if (cb_digest == null)
				cb_digest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Digest);
			return cb_digest;
		}

		static IntPtr n_Digest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Jce.SHA256 __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.SHA256> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Digest ());
		}
#pragma warning restore 0169

		static IntPtr id_digest;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='SHA256']/method[@name='digest' and count(parameter)=0]"
		[Register ("digest", "()[B", "GetDigestHandler")]
		public virtual byte[] Digest ()
		{
			if (id_digest == IntPtr.Zero)
				id_digest = JNIEnv.GetMethodID (class_ref, "digest", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_digest), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "digest", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Jcraft.Jsch.Jce.SHA256 __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.SHA256> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='SHA256']/method[@name='init' and count(parameter)=0]"
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
			global::Com.Jcraft.Jsch.Jce.SHA256 __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jce.SHA256> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Update (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_update_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jce']/class[@name='SHA256']/method[@name='update' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
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

	}
}

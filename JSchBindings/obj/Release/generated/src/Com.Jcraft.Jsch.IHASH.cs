using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='HASH']"
	[Register ("com/jcraft/jsch/HASH", "", "Com.Jcraft.Jsch.IHASHInvoker")]
	public partial interface IHASH : IJavaObject {

		int BlockSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='HASH']/method[@name='getBlockSize' and count(parameter)=0]"
			[Register ("getBlockSize", "()I", "GetGetBlockSizeHandler:Com.Jcraft.Jsch.IHASHInvoker, JSchBindings")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='HASH']/method[@name='digest' and count(parameter)=0]"
		[Register ("digest", "()[B", "GetDigestHandler:Com.Jcraft.Jsch.IHASHInvoker, JSchBindings")]
		byte[] Digest ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='HASH']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler:Com.Jcraft.Jsch.IHASHInvoker, JSchBindings")]
		void Init ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='HASH']/method[@name='update' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("update", "([BII)V", "GetUpdate_arrayBIIHandler:Com.Jcraft.Jsch.IHASHInvoker, JSchBindings")]
		void Update (byte[] p0, int p1, int p2);

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/HASH", DoNotGenerateAcw=true)]
	internal class IHASHInvoker : global::Java.Lang.Object, IHASH {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jcraft/jsch/HASH");
		IntPtr class_ref;

		public static IHASH GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHASH> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jcraft.jsch.HASH"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHASHInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IHASHInvoker); }
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
			global::Com.Jcraft.Jsch.IHASH __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IHASH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Jcraft.Jsch.IHASH __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IHASH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Digest ());
		}
#pragma warning restore 0169

		IntPtr id_digest;
		public byte[] Digest ()
		{
			if (id_digest == IntPtr.Zero)
				id_digest = JNIEnv.GetMethodID (class_ref, "digest", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_digest), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Jcraft.Jsch.IHASH __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IHASH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		IntPtr id_init;
		public void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");
			JNIEnv.CallVoidMethod (Handle, id_init);
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
			global::Com.Jcraft.Jsch.IHASH __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IHASH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Update (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_update_arrayBII;
		public void Update (byte[] p0, int p1, int p2)
		{
			if (id_update_arrayBII == IntPtr.Zero)
				id_update_arrayBII = JNIEnv.GetMethodID (class_ref, "update", "([BII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallVoidMethod (Handle, id_update_arrayBII, new JValue (native_p0), new JValue (p1), new JValue (p2));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}

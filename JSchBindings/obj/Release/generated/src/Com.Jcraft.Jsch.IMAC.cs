using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='MAC']"
	[Register ("com/jcraft/jsch/MAC", "", "Com.Jcraft.Jsch.IMACInvoker")]
	public partial interface IMAC : IJavaObject {

		int BlockSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='MAC']/method[@name='getBlockSize' and count(parameter)=0]"
			[Register ("getBlockSize", "()I", "GetGetBlockSizeHandler:Com.Jcraft.Jsch.IMACInvoker, JSchBindings")] get;
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='MAC']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Com.Jcraft.Jsch.IMACInvoker, JSchBindings")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='MAC']/method[@name='doFinal' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("doFinal", "([BI)V", "GetDoFinal_arrayBIHandler:Com.Jcraft.Jsch.IMACInvoker, JSchBindings")]
		void DoFinal (byte[] p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='MAC']/method[@name='init' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("init", "([B)V", "GetInit_arrayBHandler:Com.Jcraft.Jsch.IMACInvoker, JSchBindings")]
		void Init (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='MAC']/method[@name='update' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("update", "([BII)V", "GetUpdate_arrayBIIHandler:Com.Jcraft.Jsch.IMACInvoker, JSchBindings")]
		void Update (byte[] p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='MAC']/method[@name='update' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("update", "(I)V", "GetUpdate_IHandler:Com.Jcraft.Jsch.IMACInvoker, JSchBindings")]
		void Update (int p0);

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/MAC", DoNotGenerateAcw=true)]
	internal class IMACInvoker : global::Java.Lang.Object, IMAC {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jcraft/jsch/MAC");
		IntPtr class_ref;

		public static IMAC GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMAC> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jcraft.jsch.MAC"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMACInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMACInvoker); }
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
			global::Com.Jcraft.Jsch.IMAC __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IMAC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.IMAC __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IMAC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Jcraft.Jsch.IMAC __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IMAC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.DoFinal (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_doFinal_arrayBI;
		public void DoFinal (byte[] p0, int p1)
		{
			if (id_doFinal_arrayBI == IntPtr.Zero)
				id_doFinal_arrayBI = JNIEnv.GetMethodID (class_ref, "doFinal", "([BI)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallVoidMethod (Handle, id_doFinal_arrayBI, new JValue (native_p0), new JValue (p1));
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
			global::Com.Jcraft.Jsch.IMAC __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IMAC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Init (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_init_arrayB;
		public void Init (byte[] p0)
		{
			if (id_init_arrayB == IntPtr.Zero)
				id_init_arrayB = JNIEnv.GetMethodID (class_ref, "init", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallVoidMethod (Handle, id_init_arrayB, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Jcraft.Jsch.IMAC __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IMAC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Jcraft.Jsch.IMAC __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IMAC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Update (p0);
		}
#pragma warning restore 0169

		IntPtr id_update_I;
		public void Update (int p0)
		{
			if (id_update_I == IntPtr.Zero)
				id_update_I = JNIEnv.GetMethodID (class_ref, "update", "(I)V");
			JNIEnv.CallVoidMethod (Handle, id_update_I, new JValue (p0));
		}

	}

}

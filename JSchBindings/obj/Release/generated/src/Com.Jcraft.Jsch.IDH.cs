using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='DH']"
	[Register ("com/jcraft/jsch/DH", "", "Com.Jcraft.Jsch.IDHInvoker")]
	public partial interface IDH : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='DH']/method[@name='getE' and count(parameter)=0]"
		[Register ("getE", "()[B", "GetGetEHandler:Com.Jcraft.Jsch.IDHInvoker, JSchBindings")]
		byte[] GetE ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='DH']/method[@name='getK' and count(parameter)=0]"
		[Register ("getK", "()[B", "GetGetKHandler:Com.Jcraft.Jsch.IDHInvoker, JSchBindings")]
		byte[] GetK ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='DH']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler:Com.Jcraft.Jsch.IDHInvoker, JSchBindings")]
		void Init ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='DH']/method[@name='setF' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setF", "([B)V", "GetSetF_arrayBHandler:Com.Jcraft.Jsch.IDHInvoker, JSchBindings")]
		void SetF (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='DH']/method[@name='setG' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setG", "([B)V", "GetSetG_arrayBHandler:Com.Jcraft.Jsch.IDHInvoker, JSchBindings")]
		void SetG (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='DH']/method[@name='setP' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setP", "([B)V", "GetSetP_arrayBHandler:Com.Jcraft.Jsch.IDHInvoker, JSchBindings")]
		void SetP (byte[] p0);

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/DH", DoNotGenerateAcw=true)]
	internal class IDHInvoker : global::Java.Lang.Object, IDH {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jcraft/jsch/DH");
		IntPtr class_ref;

		public static IDH GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDH> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jcraft.jsch.DH"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDHInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IDHInvoker); }
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
			global::Com.Jcraft.Jsch.IDH __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IDH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetE ());
		}
#pragma warning restore 0169

		IntPtr id_getE;
		public byte[] GetE ()
		{
			if (id_getE == IntPtr.Zero)
				id_getE = JNIEnv.GetMethodID (class_ref, "getE", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getE), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Jcraft.Jsch.IDH __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IDH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetK ());
		}
#pragma warning restore 0169

		IntPtr id_getK;
		public byte[] GetK ()
		{
			if (id_getK == IntPtr.Zero)
				id_getK = JNIEnv.GetMethodID (class_ref, "getK", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getK), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Jcraft.Jsch.IDH __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IDH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Jcraft.Jsch.IDH __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IDH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetF (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_setF_arrayB;
		public void SetF (byte[] p0)
		{
			if (id_setF_arrayB == IntPtr.Zero)
				id_setF_arrayB = JNIEnv.GetMethodID (class_ref, "setF", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallVoidMethod (Handle, id_setF_arrayB, new JValue (native_p0));
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
			global::Com.Jcraft.Jsch.IDH __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IDH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetG (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_setG_arrayB;
		public void SetG (byte[] p0)
		{
			if (id_setG_arrayB == IntPtr.Zero)
				id_setG_arrayB = JNIEnv.GetMethodID (class_ref, "setG", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallVoidMethod (Handle, id_setG_arrayB, new JValue (native_p0));
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
			global::Com.Jcraft.Jsch.IDH __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IDH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetP (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_setP_arrayB;
		public void SetP (byte[] p0)
		{
			if (id_setP_arrayB == IntPtr.Zero)
				id_setP_arrayB = JNIEnv.GetMethodID (class_ref, "setP", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallVoidMethod (Handle, id_setP_arrayB, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}

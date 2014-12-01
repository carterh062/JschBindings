using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Random']"
	[Register ("com/jcraft/jsch/Random", "", "Com.Jcraft.Jsch.IRandomInvoker")]
	public partial interface IRandom : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Random']/method[@name='fill' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("fill", "([BII)V", "GetFill_arrayBIIHandler:Com.Jcraft.Jsch.IRandomInvoker, JSchBindings")]
		void Fill (byte[] p0, int p1, int p2);

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/Random", DoNotGenerateAcw=true)]
	internal class IRandomInvoker : global::Java.Lang.Object, IRandom {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jcraft/jsch/Random");
		IntPtr class_ref;

		public static IRandom GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRandom> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jcraft.jsch.Random"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRandomInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IRandomInvoker); }
		}

		static Delegate cb_fill_arrayBII;
#pragma warning disable 0169
		static Delegate GetFill_arrayBIIHandler ()
		{
			if (cb_fill_arrayBII == null)
				cb_fill_arrayBII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_Fill_arrayBII);
			return cb_fill_arrayBII;
		}

		static void n_Fill_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Jcraft.Jsch.IRandom __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IRandom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Fill (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_fill_arrayBII;
		public void Fill (byte[] p0, int p1, int p2)
		{
			if (id_fill_arrayBII == IntPtr.Zero)
				id_fill_arrayBII = JNIEnv.GetMethodID (class_ref, "fill", "([BII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallVoidMethod (Handle, id_fill_arrayBII, new JValue (native_p0), new JValue (p1), new JValue (p2));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}

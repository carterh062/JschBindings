using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch.Jcraft {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch.jcraft']/class[@name='HMACMD596']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/jcraft/HMACMD596", DoNotGenerateAcw=true)]
	public partial class HMACMD596 : global::Com.Jcraft.Jsch.Jcraft.HMACMD5 {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/jcraft/HMACMD596", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HMACMD596); }
		}

		protected HMACMD596 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch.jcraft']/class[@name='HMACMD596']/constructor[@name='HMACMD596' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public HMACMD596 () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (HMACMD596)) {
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
			global::Com.Jcraft.Jsch.Jcraft.HMACMD596 __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jcraft.HMACMD596> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BlockSize;
		}
#pragma warning restore 0169

		static IntPtr id_getBlockSize;
		public override int BlockSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jcraft']/class[@name='HMACMD596']/method[@name='getBlockSize' and count(parameter)=0]"
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
			global::Com.Jcraft.Jsch.Jcraft.HMACMD596 __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jcraft.HMACMD596> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.DoFinal (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_doFinal_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jcraft']/class[@name='HMACMD596']/method[@name='doFinal' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("doFinal", "([BI)V", "GetDoFinal_arrayBIHandler")]
		public override void DoFinal (byte[] p0, int p1)
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

	}
}

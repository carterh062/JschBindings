using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch.Jcraft {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch.jcraft']/class[@name='HMACMD5']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/jcraft/HMACMD5", DoNotGenerateAcw=true)]
	public partial class HMACMD5 : global::Com.Jcraft.Jsch.Jcraft.HMAC, global::Com.Jcraft.Jsch.IMAC {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/jcraft/HMACMD5", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HMACMD5); }
		}

		protected HMACMD5 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch.jcraft']/class[@name='HMACMD5']/constructor[@name='HMACMD5' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public HMACMD5 () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (HMACMD5)) {
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
			global::Com.Jcraft.Jsch.Jcraft.HMACMD5 __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jcraft.HMACMD5> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jcraft']/class[@name='HMACMD5']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}

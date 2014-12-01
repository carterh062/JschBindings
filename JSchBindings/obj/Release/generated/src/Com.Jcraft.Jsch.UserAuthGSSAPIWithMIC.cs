using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='UserAuthGSSAPIWithMIC']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/UserAuthGSSAPIWithMIC", DoNotGenerateAcw=true)]
	public partial class UserAuthGSSAPIWithMIC : global::Com.Jcraft.Jsch.UserAuth {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/UserAuthGSSAPIWithMIC", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UserAuthGSSAPIWithMIC); }
		}

		protected UserAuthGSSAPIWithMIC (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='UserAuthGSSAPIWithMIC']/constructor[@name='UserAuthGSSAPIWithMIC' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public UserAuthGSSAPIWithMIC () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (UserAuthGSSAPIWithMIC)) {
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

	}
}

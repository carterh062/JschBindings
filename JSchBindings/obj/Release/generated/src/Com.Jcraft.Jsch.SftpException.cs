using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpException']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/SftpException", DoNotGenerateAcw=true)]
	public partial class SftpException : global::Java.Lang.Exception {


		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpException']/field[@name='id']"
		[Register ("id")]
		public int Id {
			get {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "I");
				return JNIEnv.GetIntField (Handle, id_jfieldId);
			}
			set {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "I");
				JNIEnv.SetField (Handle, id_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/SftpException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SftpException); }
		}

		protected SftpException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpException']/constructor[@name='SftpException' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;)V", "")]
		public SftpException (int p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (SftpException)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILjava/lang/String;)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILjava/lang/String;)V", new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_ILjava_lang_String_ == IntPtr.Zero)
				id_ctor_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILjava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_ILjava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpException']/constructor[@name='SftpException' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/lang/Throwable;)V", "")]
		public SftpException (int p0, string p1, global::Java.Lang.Throwable p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (SftpException)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILjava/lang/String;Ljava/lang/Throwable;)V", new JValue (p0), new JValue (native_p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILjava/lang/String;Ljava/lang/Throwable;)V", new JValue (p0), new JValue (native_p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_ILjava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_ctor_ILjava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;Ljava/lang/Throwable;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_Ljava_lang_Throwable_, new JValue (p0), new JValue (native_p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILjava_lang_String_Ljava_lang_Throwable_, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='UserInfo']"
	[Register ("com/jcraft/jsch/UserInfo", "", "Com.Jcraft.Jsch.IUserInfoInvoker")]
	public partial interface IUserInfo : IJavaObject {

		string Passphrase {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='UserInfo']/method[@name='getPassphrase' and count(parameter)=0]"
			[Register ("getPassphrase", "()Ljava/lang/String;", "GetGetPassphraseHandler:Com.Jcraft.Jsch.IUserInfoInvoker, JSchBindings")] get;
		}

		string Password {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='UserInfo']/method[@name='getPassword' and count(parameter)=0]"
			[Register ("getPassword", "()Ljava/lang/String;", "GetGetPasswordHandler:Com.Jcraft.Jsch.IUserInfoInvoker, JSchBindings")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='UserInfo']/method[@name='promptPassphrase' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("promptPassphrase", "(Ljava/lang/String;)Z", "GetPromptPassphrase_Ljava_lang_String_Handler:Com.Jcraft.Jsch.IUserInfoInvoker, JSchBindings")]
		bool PromptPassphrase (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='UserInfo']/method[@name='promptPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("promptPassword", "(Ljava/lang/String;)Z", "GetPromptPassword_Ljava_lang_String_Handler:Com.Jcraft.Jsch.IUserInfoInvoker, JSchBindings")]
		bool PromptPassword (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='UserInfo']/method[@name='promptYesNo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("promptYesNo", "(Ljava/lang/String;)Z", "GetPromptYesNo_Ljava_lang_String_Handler:Com.Jcraft.Jsch.IUserInfoInvoker, JSchBindings")]
		bool PromptYesNo (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='UserInfo']/method[@name='showMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("showMessage", "(Ljava/lang/String;)V", "GetShowMessage_Ljava_lang_String_Handler:Com.Jcraft.Jsch.IUserInfoInvoker, JSchBindings")]
		void ShowMessage (string p0);

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/UserInfo", DoNotGenerateAcw=true)]
	internal class IUserInfoInvoker : global::Java.Lang.Object, IUserInfo {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jcraft/jsch/UserInfo");
		IntPtr class_ref;

		public static IUserInfo GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUserInfo> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jcraft.jsch.UserInfo"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUserInfoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IUserInfoInvoker); }
		}

		static Delegate cb_getPassphrase;
#pragma warning disable 0169
		static Delegate GetGetPassphraseHandler ()
		{
			if (cb_getPassphrase == null)
				cb_getPassphrase = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPassphrase);
			return cb_getPassphrase;
		}

		static IntPtr n_GetPassphrase (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.IUserInfo __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IUserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Passphrase);
		}
#pragma warning restore 0169

		IntPtr id_getPassphrase;
		public string Passphrase {
			get {
				if (id_getPassphrase == IntPtr.Zero)
					id_getPassphrase = JNIEnv.GetMethodID (class_ref, "getPassphrase", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getPassphrase), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPassword;
#pragma warning disable 0169
		static Delegate GetGetPasswordHandler ()
		{
			if (cb_getPassword == null)
				cb_getPassword = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPassword);
			return cb_getPassword;
		}

		static IntPtr n_GetPassword (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.IUserInfo __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IUserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Password);
		}
#pragma warning restore 0169

		IntPtr id_getPassword;
		public string Password {
			get {
				if (id_getPassword == IntPtr.Zero)
					id_getPassword = JNIEnv.GetMethodID (class_ref, "getPassword", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getPassword), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_promptPassphrase_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPromptPassphrase_Ljava_lang_String_Handler ()
		{
			if (cb_promptPassphrase_Ljava_lang_String_ == null)
				cb_promptPassphrase_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_PromptPassphrase_Ljava_lang_String_);
			return cb_promptPassphrase_Ljava_lang_String_;
		}

		static bool n_PromptPassphrase_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.IUserInfo __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IUserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.PromptPassphrase (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_promptPassphrase_Ljava_lang_String_;
		public bool PromptPassphrase (string p0)
		{
			if (id_promptPassphrase_Ljava_lang_String_ == IntPtr.Zero)
				id_promptPassphrase_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "promptPassphrase", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_promptPassphrase_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_promptPassword_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPromptPassword_Ljava_lang_String_Handler ()
		{
			if (cb_promptPassword_Ljava_lang_String_ == null)
				cb_promptPassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_PromptPassword_Ljava_lang_String_);
			return cb_promptPassword_Ljava_lang_String_;
		}

		static bool n_PromptPassword_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.IUserInfo __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IUserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.PromptPassword (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_promptPassword_Ljava_lang_String_;
		public bool PromptPassword (string p0)
		{
			if (id_promptPassword_Ljava_lang_String_ == IntPtr.Zero)
				id_promptPassword_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "promptPassword", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_promptPassword_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_promptYesNo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPromptYesNo_Ljava_lang_String_Handler ()
		{
			if (cb_promptYesNo_Ljava_lang_String_ == null)
				cb_promptYesNo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_PromptYesNo_Ljava_lang_String_);
			return cb_promptYesNo_Ljava_lang_String_;
		}

		static bool n_PromptYesNo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.IUserInfo __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IUserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.PromptYesNo (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_promptYesNo_Ljava_lang_String_;
		public bool PromptYesNo (string p0)
		{
			if (id_promptYesNo_Ljava_lang_String_ == IntPtr.Zero)
				id_promptYesNo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "promptYesNo", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_promptYesNo_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_showMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShowMessage_Ljava_lang_String_Handler ()
		{
			if (cb_showMessage_Ljava_lang_String_ == null)
				cb_showMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowMessage_Ljava_lang_String_);
			return cb_showMessage_Ljava_lang_String_;
		}

		static void n_ShowMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.IUserInfo __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IUserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShowMessage (p0);
		}
#pragma warning restore 0169

		IntPtr id_showMessage_Ljava_lang_String_;
		public void ShowMessage (string p0)
		{
			if (id_showMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_showMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "showMessage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_showMessage_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='UserAuth']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/UserAuth", DoNotGenerateAcw=true)]
	public abstract partial class UserAuth : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='UserAuth']/field[@name='SSH_MSG_USERAUTH_BANNER']"
		[Register ("SSH_MSG_USERAUTH_BANNER")]
		protected const int SshMsgUserauthBanner = (int) 53;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='UserAuth']/field[@name='SSH_MSG_USERAUTH_FAILURE']"
		[Register ("SSH_MSG_USERAUTH_FAILURE")]
		protected const int SshMsgUserauthFailure = (int) 51;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='UserAuth']/field[@name='SSH_MSG_USERAUTH_INFO_REQUEST']"
		[Register ("SSH_MSG_USERAUTH_INFO_REQUEST")]
		protected const int SshMsgUserauthInfoRequest = (int) 60;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='UserAuth']/field[@name='SSH_MSG_USERAUTH_INFO_RESPONSE']"
		[Register ("SSH_MSG_USERAUTH_INFO_RESPONSE")]
		protected const int SshMsgUserauthInfoResponse = (int) 61;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='UserAuth']/field[@name='SSH_MSG_USERAUTH_PK_OK']"
		[Register ("SSH_MSG_USERAUTH_PK_OK")]
		protected const int SshMsgUserauthPkOk = (int) 60;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='UserAuth']/field[@name='SSH_MSG_USERAUTH_REQUEST']"
		[Register ("SSH_MSG_USERAUTH_REQUEST")]
		protected const int SshMsgUserauthRequest = (int) 50;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='UserAuth']/field[@name='SSH_MSG_USERAUTH_SUCCESS']"
		[Register ("SSH_MSG_USERAUTH_SUCCESS")]
		protected const int SshMsgUserauthSuccess = (int) 52;

		static IntPtr buf_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='UserAuth']/field[@name='buf']"
		[Register ("buf")]
		protected global::Com.Jcraft.Jsch.Buffer Buf {
			get {
				if (buf_jfieldId == IntPtr.Zero)
					buf_jfieldId = JNIEnv.GetFieldID (class_ref, "buf", "Lcom/jcraft/jsch/Buffer;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, buf_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (buf_jfieldId == IntPtr.Zero)
					buf_jfieldId = JNIEnv.GetFieldID (class_ref, "buf", "Lcom/jcraft/jsch/Buffer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, buf_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr packet_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='UserAuth']/field[@name='packet']"
		[Register ("packet")]
		protected global::Com.Jcraft.Jsch.Packet Packet {
			get {
				if (packet_jfieldId == IntPtr.Zero)
					packet_jfieldId = JNIEnv.GetFieldID (class_ref, "packet", "Lcom/jcraft/jsch/Packet;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, packet_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Packet> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (packet_jfieldId == IntPtr.Zero)
					packet_jfieldId = JNIEnv.GetFieldID (class_ref, "packet", "Lcom/jcraft/jsch/Packet;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, packet_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr userinfo_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='UserAuth']/field[@name='userinfo']"
		[Register ("userinfo")]
		protected global::Com.Jcraft.Jsch.IUserInfo Userinfo {
			get {
				if (userinfo_jfieldId == IntPtr.Zero)
					userinfo_jfieldId = JNIEnv.GetFieldID (class_ref, "userinfo", "Lcom/jcraft/jsch/UserInfo;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, userinfo_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IUserInfo> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (userinfo_jfieldId == IntPtr.Zero)
					userinfo_jfieldId = JNIEnv.GetFieldID (class_ref, "userinfo", "Lcom/jcraft/jsch/UserInfo;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, userinfo_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr username_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='UserAuth']/field[@name='username']"
		[Register ("username")]
		protected string Username {
			get {
				if (username_jfieldId == IntPtr.Zero)
					username_jfieldId = JNIEnv.GetFieldID (class_ref, "username", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, username_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (username_jfieldId == IntPtr.Zero)
					username_jfieldId = JNIEnv.GetFieldID (class_ref, "username", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, username_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/UserAuth", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UserAuth); }
		}

		protected UserAuth (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='UserAuth']/constructor[@name='UserAuth' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public UserAuth () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (UserAuth)) {
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

		static Delegate cb_start_Lcom_jcraft_jsch_Session_;
#pragma warning disable 0169
		static Delegate GetStart_Lcom_jcraft_jsch_Session_Handler ()
		{
			if (cb_start_Lcom_jcraft_jsch_Session_ == null)
				cb_start_Lcom_jcraft_jsch_Session_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Start_Lcom_jcraft_jsch_Session_);
			return cb_start_Lcom_jcraft_jsch_Session_;
		}

		static bool n_Start_Lcom_jcraft_jsch_Session_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.UserAuth __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.UserAuth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.Session p0 = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Start (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_start_Lcom_jcraft_jsch_Session_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='UserAuth']/method[@name='start' and count(parameter)=1 and parameter[1][@type='com.jcraft.jsch.Session']]"
		[Register ("start", "(Lcom/jcraft/jsch/Session;)Z", "GetStart_Lcom_jcraft_jsch_Session_Handler")]
		public virtual bool Start (global::Com.Jcraft.Jsch.Session p0)
		{
			if (id_start_Lcom_jcraft_jsch_Session_ == IntPtr.Zero)
				id_start_Lcom_jcraft_jsch_Session_ = JNIEnv.GetMethodID (class_ref, "start", "(Lcom/jcraft/jsch/Session;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_start_Lcom_jcraft_jsch_Session_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "(Lcom/jcraft/jsch/Session;)Z"), new JValue (p0));
			return __ret;
		}

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/UserAuth", DoNotGenerateAcw=true)]
	internal partial class UserAuthInvoker : UserAuth {

		public UserAuthInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (UserAuthInvoker); }
		}

	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSession']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/ChannelSession", DoNotGenerateAcw=true)]
	public partial class ChannelSession : global::Com.Jcraft.Jsch.Channel {


		static IntPtr agent_forwarding_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSession']/field[@name='agent_forwarding']"
		[Register ("agent_forwarding")]
		protected bool AgentForwarding {
			get {
				if (agent_forwarding_jfieldId == IntPtr.Zero)
					agent_forwarding_jfieldId = JNIEnv.GetFieldID (class_ref, "agent_forwarding", "Z");
				return JNIEnv.GetBooleanField (Handle, agent_forwarding_jfieldId);
			}
			set {
				if (agent_forwarding_jfieldId == IntPtr.Zero)
					agent_forwarding_jfieldId = JNIEnv.GetFieldID (class_ref, "agent_forwarding", "Z");
				JNIEnv.SetField (Handle, agent_forwarding_jfieldId, value);
			}
		}

		static IntPtr env_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSession']/field[@name='env']"
		[Register ("env")]
		protected global::Java.Util.Hashtable Env {
			get {
				if (env_jfieldId == IntPtr.Zero)
					env_jfieldId = JNIEnv.GetFieldID (class_ref, "env", "Ljava/util/Hashtable;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, env_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Hashtable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (env_jfieldId == IntPtr.Zero)
					env_jfieldId = JNIEnv.GetFieldID (class_ref, "env", "Ljava/util/Hashtable;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, env_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr pty_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSession']/field[@name='pty']"
		[Register ("pty")]
		protected bool Pty {
			get {
				if (pty_jfieldId == IntPtr.Zero)
					pty_jfieldId = JNIEnv.GetFieldID (class_ref, "pty", "Z");
				return JNIEnv.GetBooleanField (Handle, pty_jfieldId);
			}
			set {
				if (pty_jfieldId == IntPtr.Zero)
					pty_jfieldId = JNIEnv.GetFieldID (class_ref, "pty", "Z");
				JNIEnv.SetField (Handle, pty_jfieldId, value);
			}
		}

		static IntPtr tcol_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSession']/field[@name='tcol']"
		[Register ("tcol")]
		protected int Tcol {
			get {
				if (tcol_jfieldId == IntPtr.Zero)
					tcol_jfieldId = JNIEnv.GetFieldID (class_ref, "tcol", "I");
				return JNIEnv.GetIntField (Handle, tcol_jfieldId);
			}
			set {
				if (tcol_jfieldId == IntPtr.Zero)
					tcol_jfieldId = JNIEnv.GetFieldID (class_ref, "tcol", "I");
				JNIEnv.SetField (Handle, tcol_jfieldId, value);
			}
		}

		static IntPtr terminal_mode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSession']/field[@name='terminal_mode']"
		[Register ("terminal_mode")]
		protected IList<byte> TerminalMode {
			get {
				if (terminal_mode_jfieldId == IntPtr.Zero)
					terminal_mode_jfieldId = JNIEnv.GetFieldID (class_ref, "terminal_mode", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, terminal_mode_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (terminal_mode_jfieldId == IntPtr.Zero)
					terminal_mode_jfieldId = JNIEnv.GetFieldID (class_ref, "terminal_mode", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, terminal_mode_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr thp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSession']/field[@name='thp']"
		[Register ("thp")]
		protected int Thp {
			get {
				if (thp_jfieldId == IntPtr.Zero)
					thp_jfieldId = JNIEnv.GetFieldID (class_ref, "thp", "I");
				return JNIEnv.GetIntField (Handle, thp_jfieldId);
			}
			set {
				if (thp_jfieldId == IntPtr.Zero)
					thp_jfieldId = JNIEnv.GetFieldID (class_ref, "thp", "I");
				JNIEnv.SetField (Handle, thp_jfieldId, value);
			}
		}

		static IntPtr trow_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSession']/field[@name='trow']"
		[Register ("trow")]
		protected int Trow {
			get {
				if (trow_jfieldId == IntPtr.Zero)
					trow_jfieldId = JNIEnv.GetFieldID (class_ref, "trow", "I");
				return JNIEnv.GetIntField (Handle, trow_jfieldId);
			}
			set {
				if (trow_jfieldId == IntPtr.Zero)
					trow_jfieldId = JNIEnv.GetFieldID (class_ref, "trow", "I");
				JNIEnv.SetField (Handle, trow_jfieldId, value);
			}
		}

		static IntPtr ttype_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSession']/field[@name='ttype']"
		[Register ("ttype")]
		protected string Ttype {
			get {
				if (ttype_jfieldId == IntPtr.Zero)
					ttype_jfieldId = JNIEnv.GetFieldID (class_ref, "ttype", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, ttype_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ttype_jfieldId == IntPtr.Zero)
					ttype_jfieldId = JNIEnv.GetFieldID (class_ref, "ttype", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, ttype_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr twp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSession']/field[@name='twp']"
		[Register ("twp")]
		protected int Twp {
			get {
				if (twp_jfieldId == IntPtr.Zero)
					twp_jfieldId = JNIEnv.GetFieldID (class_ref, "twp", "I");
				return JNIEnv.GetIntField (Handle, twp_jfieldId);
			}
			set {
				if (twp_jfieldId == IntPtr.Zero)
					twp_jfieldId = JNIEnv.GetFieldID (class_ref, "twp", "I");
				JNIEnv.SetField (Handle, twp_jfieldId, value);
			}
		}

		static IntPtr xforwading_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSession']/field[@name='xforwading']"
		[Register ("xforwading")]
		protected bool Xforwading {
			get {
				if (xforwading_jfieldId == IntPtr.Zero)
					xforwading_jfieldId = JNIEnv.GetFieldID (class_ref, "xforwading", "Z");
				return JNIEnv.GetBooleanField (Handle, xforwading_jfieldId);
			}
			set {
				if (xforwading_jfieldId == IntPtr.Zero)
					xforwading_jfieldId = JNIEnv.GetFieldID (class_ref, "xforwading", "Z");
				JNIEnv.SetField (Handle, xforwading_jfieldId, value);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/ChannelSession", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelSession); }
		}

		protected ChannelSession (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_sendRequests;
#pragma warning disable 0169
		static Delegate GetSendRequestsHandler ()
		{
			if (cb_sendRequests == null)
				cb_sendRequests = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendRequests);
			return cb_sendRequests;
		}

		static void n_SendRequests (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.ChannelSession __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendRequests ();
		}
#pragma warning restore 0169

		static IntPtr id_sendRequests;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSession']/method[@name='sendRequests' and count(parameter)=0]"
		[Register ("sendRequests", "()V", "GetSendRequestsHandler")]
		protected virtual void SendRequests ()
		{
			if (id_sendRequests == IntPtr.Zero)
				id_sendRequests = JNIEnv.GetMethodID (class_ref, "sendRequests", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sendRequests);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendRequests", "()V"));
		}

		static Delegate cb_setAgentForwarding_Z;
#pragma warning disable 0169
		static Delegate GetSetAgentForwarding_ZHandler ()
		{
			if (cb_setAgentForwarding_Z == null)
				cb_setAgentForwarding_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAgentForwarding_Z);
			return cb_setAgentForwarding_Z;
		}

		static void n_SetAgentForwarding_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Jcraft.Jsch.ChannelSession __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAgentForwarding (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAgentForwarding_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSession']/method[@name='setAgentForwarding' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAgentForwarding", "(Z)V", "GetSetAgentForwarding_ZHandler")]
		public virtual void SetAgentForwarding (bool p0)
		{
			if (id_setAgentForwarding_Z == IntPtr.Zero)
				id_setAgentForwarding_Z = JNIEnv.GetMethodID (class_ref, "setAgentForwarding", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setAgentForwarding_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAgentForwarding", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setEnv_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetSetEnv_arrayBarrayBHandler ()
		{
			if (cb_setEnv_arrayBarrayB == null)
				cb_setEnv_arrayBarrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetEnv_arrayBarrayB);
			return cb_setEnv_arrayBarrayB;
		}

		static void n_SetEnv_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.ChannelSession __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetEnv (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_setEnv_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSession']/method[@name='setEnv' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("setEnv", "([B[B)V", "GetSetEnv_arrayBarrayBHandler")]
		public virtual void SetEnv (byte[] p0, byte[] p1)
		{
			if (id_setEnv_arrayBarrayB == IntPtr.Zero)
				id_setEnv_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "setEnv", "([B[B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setEnv_arrayBarrayB, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEnv", "([B[B)V"), new JValue (native_p0), new JValue (native_p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setEnv_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEnv_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setEnv_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setEnv_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetEnv_Ljava_lang_String_Ljava_lang_String_);
			return cb_setEnv_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetEnv_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.ChannelSession __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetEnv (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setEnv_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSession']/method[@name='setEnv' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setEnv", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetEnv_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void SetEnv (string p0, string p1)
		{
			if (id_setEnv_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setEnv_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEnv", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setEnv_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEnv", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_setEnv_Ljava_util_Hashtable_;
#pragma warning disable 0169
		static Delegate GetSetEnv_Ljava_util_Hashtable_Handler ()
		{
			if (cb_setEnv_Ljava_util_Hashtable_ == null)
				cb_setEnv_Ljava_util_Hashtable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEnv_Ljava_util_Hashtable_);
			return cb_setEnv_Ljava_util_Hashtable_;
		}

		static void n_SetEnv_Ljava_util_Hashtable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ChannelSession __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Hashtable p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Hashtable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetEnv (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setEnv_Ljava_util_Hashtable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSession']/method[@name='setEnv' and count(parameter)=1 and parameter[1][@type='java.util.Hashtable']]"
		[Register ("setEnv", "(Ljava/util/Hashtable;)V", "GetSetEnv_Ljava_util_Hashtable_Handler")]
		public virtual void SetEnv (global::Java.Util.Hashtable p0)
		{
			if (id_setEnv_Ljava_util_Hashtable_ == IntPtr.Zero)
				id_setEnv_Ljava_util_Hashtable_ = JNIEnv.GetMethodID (class_ref, "setEnv", "(Ljava/util/Hashtable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setEnv_Ljava_util_Hashtable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEnv", "(Ljava/util/Hashtable;)V"), new JValue (p0));
		}

		static Delegate cb_setPty_Z;
#pragma warning disable 0169
		static Delegate GetSetPty_ZHandler ()
		{
			if (cb_setPty_Z == null)
				cb_setPty_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPty_Z);
			return cb_setPty_Z;
		}

		static void n_SetPty_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Jcraft.Jsch.ChannelSession __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPty (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPty_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSession']/method[@name='setPty' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setPty", "(Z)V", "GetSetPty_ZHandler")]
		public virtual void SetPty (bool p0)
		{
			if (id_setPty_Z == IntPtr.Zero)
				id_setPty_Z = JNIEnv.GetMethodID (class_ref, "setPty", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPty_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPty", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setPtySize_IIII;
#pragma warning disable 0169
		static Delegate GetSetPtySize_IIIIHandler ()
		{
			if (cb_setPtySize_IIII == null)
				cb_setPtySize_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int>) n_SetPtySize_IIII);
			return cb_setPtySize_IIII;
		}

		static void n_SetPtySize_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			global::Com.Jcraft.Jsch.ChannelSession __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPtySize (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_setPtySize_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSession']/method[@name='setPtySize' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setPtySize", "(IIII)V", "GetSetPtySize_IIIIHandler")]
		public virtual void SetPtySize (int p0, int p1, int p2, int p3)
		{
			if (id_setPtySize_IIII == IntPtr.Zero)
				id_setPtySize_IIII = JNIEnv.GetMethodID (class_ref, "setPtySize", "(IIII)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPtySize_IIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPtySize", "(IIII)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static Delegate cb_setPtyType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPtyType_Ljava_lang_String_Handler ()
		{
			if (cb_setPtyType_Ljava_lang_String_ == null)
				cb_setPtyType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPtyType_Ljava_lang_String_);
			return cb_setPtyType_Ljava_lang_String_;
		}

		static void n_SetPtyType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ChannelSession __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPtyType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPtyType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSession']/method[@name='setPtyType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPtyType", "(Ljava/lang/String;)V", "GetSetPtyType_Ljava_lang_String_Handler")]
		public virtual void SetPtyType (string p0)
		{
			if (id_setPtyType_Ljava_lang_String_ == IntPtr.Zero)
				id_setPtyType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPtyType", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPtyType_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPtyType", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setPtyType_Ljava_lang_String_IIII;
#pragma warning disable 0169
		static Delegate GetSetPtyType_Ljava_lang_String_IIIIHandler ()
		{
			if (cb_setPtyType_Ljava_lang_String_IIII == null)
				cb_setPtyType_Ljava_lang_String_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int>) n_SetPtyType_Ljava_lang_String_IIII);
			return cb_setPtyType_Ljava_lang_String_IIII;
		}

		static void n_SetPtyType_Ljava_lang_String_IIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4)
		{
			global::Com.Jcraft.Jsch.ChannelSession __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPtyType (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_setPtyType_Ljava_lang_String_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSession']/method[@name='setPtyType' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("setPtyType", "(Ljava/lang/String;IIII)V", "GetSetPtyType_Ljava_lang_String_IIIIHandler")]
		public virtual void SetPtyType (string p0, int p1, int p2, int p3, int p4)
		{
			if (id_setPtyType_Ljava_lang_String_IIII == IntPtr.Zero)
				id_setPtyType_Ljava_lang_String_IIII = JNIEnv.GetMethodID (class_ref, "setPtyType", "(Ljava/lang/String;IIII)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPtyType_Ljava_lang_String_IIII, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPtyType", "(Ljava/lang/String;IIII)V"), new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setTerminalMode_arrayB;
#pragma warning disable 0169
		static Delegate GetSetTerminalMode_arrayBHandler ()
		{
			if (cb_setTerminalMode_arrayB == null)
				cb_setTerminalMode_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTerminalMode_arrayB);
			return cb_setTerminalMode_arrayB;
		}

		static void n_SetTerminalMode_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ChannelSession __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetTerminalMode (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTerminalMode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSession']/method[@name='setTerminalMode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setTerminalMode", "([B)V", "GetSetTerminalMode_arrayBHandler")]
		public virtual void SetTerminalMode (byte[] p0)
		{
			if (id_setTerminalMode_arrayB == IntPtr.Zero)
				id_setTerminalMode_arrayB = JNIEnv.GetMethodID (class_ref, "setTerminalMode", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setTerminalMode_arrayB, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTerminalMode", "([B)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}

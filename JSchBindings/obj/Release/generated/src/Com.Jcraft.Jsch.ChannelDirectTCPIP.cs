using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelDirectTCPIP']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/ChannelDirectTCPIP", DoNotGenerateAcw=true)]
	public partial class ChannelDirectTCPIP : global::Com.Jcraft.Jsch.Channel {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/ChannelDirectTCPIP", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelDirectTCPIP); }
		}

		protected ChannelDirectTCPIP (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_setHost_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHost_Ljava_lang_String_Handler ()
		{
			if (cb_setHost_Ljava_lang_String_ == null)
				cb_setHost_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHost_Ljava_lang_String_);
			return cb_setHost_Ljava_lang_String_;
		}

		static void n_SetHost_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ChannelDirectTCPIP __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelDirectTCPIP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetHost (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHost_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelDirectTCPIP']/method[@name='setHost' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setHost", "(Ljava/lang/String;)V", "GetSetHost_Ljava_lang_String_Handler")]
		public virtual void SetHost (string p0)
		{
			if (id_setHost_Ljava_lang_String_ == IntPtr.Zero)
				id_setHost_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHost", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setHost_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHost", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setOrgIPAddress_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOrgIPAddress_Ljava_lang_String_Handler ()
		{
			if (cb_setOrgIPAddress_Ljava_lang_String_ == null)
				cb_setOrgIPAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOrgIPAddress_Ljava_lang_String_);
			return cb_setOrgIPAddress_Ljava_lang_String_;
		}

		static void n_SetOrgIPAddress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ChannelDirectTCPIP __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelDirectTCPIP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOrgIPAddress (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOrgIPAddress_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelDirectTCPIP']/method[@name='setOrgIPAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOrgIPAddress", "(Ljava/lang/String;)V", "GetSetOrgIPAddress_Ljava_lang_String_Handler")]
		public virtual void SetOrgIPAddress (string p0)
		{
			if (id_setOrgIPAddress_Ljava_lang_String_ == IntPtr.Zero)
				id_setOrgIPAddress_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOrgIPAddress", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOrgIPAddress_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOrgIPAddress", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setOrgPort_I;
#pragma warning disable 0169
		static Delegate GetSetOrgPort_IHandler ()
		{
			if (cb_setOrgPort_I == null)
				cb_setOrgPort_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetOrgPort_I);
			return cb_setOrgPort_I;
		}

		static void n_SetOrgPort_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jcraft.Jsch.ChannelDirectTCPIP __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelDirectTCPIP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOrgPort (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOrgPort_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelDirectTCPIP']/method[@name='setOrgPort' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setOrgPort", "(I)V", "GetSetOrgPort_IHandler")]
		public virtual void SetOrgPort (int p0)
		{
			if (id_setOrgPort_I == IntPtr.Zero)
				id_setOrgPort_I = JNIEnv.GetMethodID (class_ref, "setOrgPort", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOrgPort_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOrgPort", "(I)V"), new JValue (p0));
		}

		static Delegate cb_setPort_I;
#pragma warning disable 0169
		static Delegate GetSetPort_IHandler ()
		{
			if (cb_setPort_I == null)
				cb_setPort_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPort_I);
			return cb_setPort_I;
		}

		static void n_SetPort_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jcraft.Jsch.ChannelDirectTCPIP __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelDirectTCPIP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPort (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPort_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelDirectTCPIP']/method[@name='setPort' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPort", "(I)V", "GetSetPort_IHandler")]
		public virtual void SetPort (int p0)
		{
			if (id_setPort_I == IntPtr.Zero)
				id_setPort_I = JNIEnv.GetMethodID (class_ref, "setPort", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPort_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPort", "(I)V"), new JValue (p0));
		}

	}
}

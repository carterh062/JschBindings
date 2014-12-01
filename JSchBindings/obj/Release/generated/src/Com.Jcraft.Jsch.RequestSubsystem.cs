using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='RequestSubsystem']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/RequestSubsystem", DoNotGenerateAcw=true)]
	public partial class RequestSubsystem : global::Com.Jcraft.Jsch.Request {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/RequestSubsystem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestSubsystem); }
		}

		protected RequestSubsystem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='RequestSubsystem']/constructor[@name='RequestSubsystem' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public RequestSubsystem () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RequestSubsystem)) {
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

		static Delegate cb_request_Lcom_jcraft_jsch_Session_Lcom_jcraft_jsch_Channel_;
#pragma warning disable 0169
		static Delegate GetRequest_Lcom_jcraft_jsch_Session_Lcom_jcraft_jsch_Channel_Handler ()
		{
			if (cb_request_Lcom_jcraft_jsch_Session_Lcom_jcraft_jsch_Channel_ == null)
				cb_request_Lcom_jcraft_jsch_Session_Lcom_jcraft_jsch_Channel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Request_Lcom_jcraft_jsch_Session_Lcom_jcraft_jsch_Channel_);
			return cb_request_Lcom_jcraft_jsch_Session_Lcom_jcraft_jsch_Channel_;
		}

		static void n_Request_Lcom_jcraft_jsch_Session_Lcom_jcraft_jsch_Channel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.RequestSubsystem __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.RequestSubsystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.Session p0 = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.Channel p1 = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Request (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_request_Lcom_jcraft_jsch_Session_Lcom_jcraft_jsch_Channel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='RequestSubsystem']/method[@name='request' and count(parameter)=2 and parameter[1][@type='com.jcraft.jsch.Session'] and parameter[2][@type='com.jcraft.jsch.Channel']]"
		[Register ("request", "(Lcom/jcraft/jsch/Session;Lcom/jcraft/jsch/Channel;)V", "GetRequest_Lcom_jcraft_jsch_Session_Lcom_jcraft_jsch_Channel_Handler")]
		public virtual void Request (global::Com.Jcraft.Jsch.Session p0, global::Com.Jcraft.Jsch.Channel p1)
		{
			if (id_request_Lcom_jcraft_jsch_Session_Lcom_jcraft_jsch_Channel_ == IntPtr.Zero)
				id_request_Lcom_jcraft_jsch_Session_Lcom_jcraft_jsch_Channel_ = JNIEnv.GetMethodID (class_ref, "request", "(Lcom/jcraft/jsch/Session;Lcom/jcraft/jsch/Channel;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_request_Lcom_jcraft_jsch_Session_Lcom_jcraft_jsch_Channel_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "request", "(Lcom/jcraft/jsch/Session;Lcom/jcraft/jsch/Channel;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_request_Lcom_jcraft_jsch_Session_Lcom_jcraft_jsch_Channel_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetRequest_Lcom_jcraft_jsch_Session_Lcom_jcraft_jsch_Channel_Ljava_lang_String_ZHandler ()
		{
			if (cb_request_Lcom_jcraft_jsch_Session_Lcom_jcraft_jsch_Channel_Ljava_lang_String_Z == null)
				cb_request_Lcom_jcraft_jsch_Session_Lcom_jcraft_jsch_Channel_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Request_Lcom_jcraft_jsch_Session_Lcom_jcraft_jsch_Channel_Ljava_lang_String_Z);
			return cb_request_Lcom_jcraft_jsch_Session_Lcom_jcraft_jsch_Channel_Ljava_lang_String_Z;
		}

		static void n_Request_Lcom_jcraft_jsch_Session_Lcom_jcraft_jsch_Channel_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			global::Com.Jcraft.Jsch.RequestSubsystem __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.RequestSubsystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.Session p0 = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.Channel p1 = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Request (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_request_Lcom_jcraft_jsch_Session_Lcom_jcraft_jsch_Channel_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='RequestSubsystem']/method[@name='request' and count(parameter)=4 and parameter[1][@type='com.jcraft.jsch.Session'] and parameter[2][@type='com.jcraft.jsch.Channel'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("request", "(Lcom/jcraft/jsch/Session;Lcom/jcraft/jsch/Channel;Ljava/lang/String;Z)V", "GetRequest_Lcom_jcraft_jsch_Session_Lcom_jcraft_jsch_Channel_Ljava_lang_String_ZHandler")]
		public virtual void Request (global::Com.Jcraft.Jsch.Session p0, global::Com.Jcraft.Jsch.Channel p1, string p2, bool p3)
		{
			if (id_request_Lcom_jcraft_jsch_Session_Lcom_jcraft_jsch_Channel_Ljava_lang_String_Z == IntPtr.Zero)
				id_request_Lcom_jcraft_jsch_Session_Lcom_jcraft_jsch_Channel_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "request", "(Lcom/jcraft/jsch/Session;Lcom/jcraft/jsch/Channel;Ljava/lang/String;Z)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_request_Lcom_jcraft_jsch_Session_Lcom_jcraft_jsch_Channel_Ljava_lang_String_Z, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "request", "(Lcom/jcraft/jsch/Session;Lcom/jcraft/jsch/Channel;Ljava/lang/String;Z)V"), new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}
}

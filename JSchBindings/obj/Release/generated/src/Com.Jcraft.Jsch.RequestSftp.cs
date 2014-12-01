using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='RequestSftp']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/RequestSftp", DoNotGenerateAcw=true)]
	public partial class RequestSftp : global::Com.Jcraft.Jsch.Request {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/RequestSftp", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestSftp); }
		}

		protected RequestSftp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Jcraft.Jsch.RequestSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.RequestSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.Session p0 = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.Channel p1 = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Channel> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Request (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_request_Lcom_jcraft_jsch_Session_Lcom_jcraft_jsch_Channel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='RequestSftp']/method[@name='request' and count(parameter)=2 and parameter[1][@type='com.jcraft.jsch.Session'] and parameter[2][@type='com.jcraft.jsch.Channel']]"
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

	}
}

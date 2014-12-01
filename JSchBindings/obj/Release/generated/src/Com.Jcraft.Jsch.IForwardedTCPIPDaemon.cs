using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='ForwardedTCPIPDaemon']"
	[Register ("com/jcraft/jsch/ForwardedTCPIPDaemon", "", "Com.Jcraft.Jsch.IForwardedTCPIPDaemonInvoker")]
	public partial interface IForwardedTCPIPDaemon : global::Java.Lang.IRunnable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='ForwardedTCPIPDaemon']/method[@name='setArg' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("setArg", "([Ljava/lang/Object;)V", "GetSetArg_arrayLjava_lang_Object_Handler:Com.Jcraft.Jsch.IForwardedTCPIPDaemonInvoker, JSchBindings")]
		void SetArg (global::Java.Lang.Object[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='ForwardedTCPIPDaemon']/method[@name='setChannel' and count(parameter)=3 and parameter[1][@type='com.jcraft.jsch.ChannelForwardedTCPIP'] and parameter[2][@type='java.io.InputStream'] and parameter[3][@type='java.io.OutputStream']]"
		[Register ("setChannel", "(Lcom/jcraft/jsch/ChannelForwardedTCPIP;Ljava/io/InputStream;Ljava/io/OutputStream;)V", "GetSetChannel_Lcom_jcraft_jsch_ChannelForwardedTCPIP_Ljava_io_InputStream_Ljava_io_OutputStream_Handler:Com.Jcraft.Jsch.IForwardedTCPIPDaemonInvoker, JSchBindings")]
		void SetChannel (global::Com.Jcraft.Jsch.ChannelForwardedTCPIP p0, global::System.IO.Stream p1, global::System.IO.Stream p2);

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/ForwardedTCPIPDaemon", DoNotGenerateAcw=true)]
	internal class IForwardedTCPIPDaemonInvoker : global::Java.Lang.Object, IForwardedTCPIPDaemon {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jcraft/jsch/ForwardedTCPIPDaemon");
		IntPtr class_ref;

		public static IForwardedTCPIPDaemon GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IForwardedTCPIPDaemon> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jcraft.jsch.ForwardedTCPIPDaemon"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IForwardedTCPIPDaemonInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IForwardedTCPIPDaemonInvoker); }
		}

		static Delegate cb_setArg_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetArg_arrayLjava_lang_Object_Handler ()
		{
			if (cb_setArg_arrayLjava_lang_Object_ == null)
				cb_setArg_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetArg_arrayLjava_lang_Object_);
			return cb_setArg_arrayLjava_lang_Object_;
		}

		static void n_SetArg_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.IForwardedTCPIPDaemon __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IForwardedTCPIPDaemon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.SetArg (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_setArg_arrayLjava_lang_Object_;
		public void SetArg (global::Java.Lang.Object[] p0)
		{
			if (id_setArg_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_setArg_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setArg", "([Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallVoidMethod (Handle, id_setArg_arrayLjava_lang_Object_, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setChannel_Lcom_jcraft_jsch_ChannelForwardedTCPIP_Ljava_io_InputStream_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetSetChannel_Lcom_jcraft_jsch_ChannelForwardedTCPIP_Ljava_io_InputStream_Ljava_io_OutputStream_Handler ()
		{
			if (cb_setChannel_Lcom_jcraft_jsch_ChannelForwardedTCPIP_Ljava_io_InputStream_Ljava_io_OutputStream_ == null)
				cb_setChannel_Lcom_jcraft_jsch_ChannelForwardedTCPIP_Ljava_io_InputStream_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetChannel_Lcom_jcraft_jsch_ChannelForwardedTCPIP_Ljava_io_InputStream_Ljava_io_OutputStream_);
			return cb_setChannel_Lcom_jcraft_jsch_ChannelForwardedTCPIP_Ljava_io_InputStream_Ljava_io_OutputStream_;
		}

		static void n_SetChannel_Lcom_jcraft_jsch_ChannelForwardedTCPIP_Ljava_io_InputStream_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Jcraft.Jsch.IForwardedTCPIPDaemon __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IForwardedTCPIPDaemon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.ChannelForwardedTCPIP p0 = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelForwardedTCPIP> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p1 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p2 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetChannel (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_setChannel_Lcom_jcraft_jsch_ChannelForwardedTCPIP_Ljava_io_InputStream_Ljava_io_OutputStream_;
		public void SetChannel (global::Com.Jcraft.Jsch.ChannelForwardedTCPIP p0, global::System.IO.Stream p1, global::System.IO.Stream p2)
		{
			if (id_setChannel_Lcom_jcraft_jsch_ChannelForwardedTCPIP_Ljava_io_InputStream_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_setChannel_Lcom_jcraft_jsch_ChannelForwardedTCPIP_Ljava_io_InputStream_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "setChannel", "(Lcom/jcraft/jsch/ChannelForwardedTCPIP;Ljava/io/InputStream;Ljava/io/OutputStream;)V");
			IntPtr native_p1 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p2);
			JNIEnv.CallVoidMethod (Handle, id_setChannel_Lcom_jcraft_jsch_ChannelForwardedTCPIP_Ljava_io_InputStream_Ljava_io_OutputStream_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.IForwardedTCPIPDaemon __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IForwardedTCPIPDaemon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		IntPtr id_run;
		public void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			JNIEnv.CallVoidMethod (Handle, id_run);
		}

	}

}

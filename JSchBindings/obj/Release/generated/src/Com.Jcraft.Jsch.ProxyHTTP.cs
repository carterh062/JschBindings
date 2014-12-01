using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ProxyHTTP']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/ProxyHTTP", DoNotGenerateAcw=true)]
	public partial class ProxyHTTP : global::Java.Lang.Object, global::Com.Jcraft.Jsch.IProxy {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/ProxyHTTP", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProxyHTTP); }
		}

		protected ProxyHTTP (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ProxyHTTP']/constructor[@name='ProxyHTTP' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		public ProxyHTTP (string p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (ProxyHTTP)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;I)V", new JValue (native_p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;I)V", new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_I == IntPtr.Zero)
				id_ctor_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ProxyHTTP']/constructor[@name='ProxyHTTP' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public ProxyHTTP (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (ProxyHTTP)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_getDefaultPort;
		public static int DefaultPort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ProxyHTTP']/method[@name='getDefaultPort' and count(parameter)=0]"
			[Register ("getDefaultPort", "()I", "GetGetDefaultPortHandler")]
			get {
				if (id_getDefaultPort == IntPtr.Zero)
					id_getDefaultPort = JNIEnv.GetStaticMethodID (class_ref, "getDefaultPort", "()I");
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getDefaultPort);
			}
		}

		static Delegate cb_getInputStream;
#pragma warning disable 0169
		static Delegate GetGetInputStreamHandler ()
		{
			if (cb_getInputStream == null)
				cb_getInputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputStream);
			return cb_getInputStream;
		}

		static IntPtr n_GetInputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.ProxyHTTP __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ProxyHTTP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		static IntPtr id_getInputStream;
		public virtual global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ProxyHTTP']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler")]
			get {
				if (id_getInputStream == IntPtr.Zero)
					id_getInputStream = JNIEnv.GetMethodID (class_ref, "getInputStream", "()Ljava/io/InputStream;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getInputStream), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputStream", "()Ljava/io/InputStream;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getOutputStream;
#pragma warning disable 0169
		static Delegate GetGetOutputStreamHandler ()
		{
			if (cb_getOutputStream == null)
				cb_getOutputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOutputStream);
			return cb_getOutputStream;
		}

		static IntPtr n_GetOutputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.ProxyHTTP __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ProxyHTTP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.OutputStream);
		}
#pragma warning restore 0169

		static IntPtr id_getOutputStream;
		public virtual global::System.IO.Stream OutputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ProxyHTTP']/method[@name='getOutputStream' and count(parameter)=0]"
			[Register ("getOutputStream", "()Ljava/io/OutputStream;", "GetGetOutputStreamHandler")]
			get {
				if (id_getOutputStream == IntPtr.Zero)
					id_getOutputStream = JNIEnv.GetMethodID (class_ref, "getOutputStream", "()Ljava/io/OutputStream;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getOutputStream), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutputStream", "()Ljava/io/OutputStream;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSocket;
#pragma warning disable 0169
		static Delegate GetGetSocketHandler ()
		{
			if (cb_getSocket == null)
				cb_getSocket = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSocket);
			return cb_getSocket;
		}

		static IntPtr n_GetSocket (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.ProxyHTTP __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ProxyHTTP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Socket);
		}
#pragma warning restore 0169

		static IntPtr id_getSocket;
		public virtual global::Java.Net.Socket Socket {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ProxyHTTP']/method[@name='getSocket' and count(parameter)=0]"
			[Register ("getSocket", "()Ljava/net/Socket;", "GetGetSocketHandler")]
			get {
				if (id_getSocket == IntPtr.Zero)
					id_getSocket = JNIEnv.GetMethodID (class_ref, "getSocket", "()Ljava/net/Socket;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (JNIEnv.CallObjectMethod  (Handle, id_getSocket), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSocket", "()Ljava/net/Socket;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.ProxyHTTP __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ProxyHTTP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ProxyHTTP']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_close);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
		}

		static Delegate cb_connect_Lcom_jcraft_jsch_SocketFactory_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetConnect_Lcom_jcraft_jsch_SocketFactory_Ljava_lang_String_IIHandler ()
		{
			if (cb_connect_Lcom_jcraft_jsch_SocketFactory_Ljava_lang_String_II == null)
				cb_connect_Lcom_jcraft_jsch_SocketFactory_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_Connect_Lcom_jcraft_jsch_SocketFactory_Ljava_lang_String_II);
			return cb_connect_Lcom_jcraft_jsch_SocketFactory_Ljava_lang_String_II;
		}

		static void n_Connect_Lcom_jcraft_jsch_SocketFactory_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			global::Com.Jcraft.Jsch.ProxyHTTP __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ProxyHTTP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.ISocketFactory p0 = (global::Com.Jcraft.Jsch.ISocketFactory)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISocketFactory> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_connect_Lcom_jcraft_jsch_SocketFactory_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ProxyHTTP']/method[@name='connect' and count(parameter)=4 and parameter[1][@type='com.jcraft.jsch.SocketFactory'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("connect", "(Lcom/jcraft/jsch/SocketFactory;Ljava/lang/String;II)V", "GetConnect_Lcom_jcraft_jsch_SocketFactory_Ljava_lang_String_IIHandler")]
		public virtual void Connect (global::Com.Jcraft.Jsch.ISocketFactory p0, string p1, int p2, int p3)
		{
			if (id_connect_Lcom_jcraft_jsch_SocketFactory_Ljava_lang_String_II == IntPtr.Zero)
				id_connect_Lcom_jcraft_jsch_SocketFactory_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "connect", "(Lcom/jcraft/jsch/SocketFactory;Ljava/lang/String;II)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_connect_Lcom_jcraft_jsch_SocketFactory_Ljava_lang_String_II, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "(Lcom/jcraft/jsch/SocketFactory;Ljava/lang/String;II)V"), new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_setUserPasswd_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserPasswd_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setUserPasswd_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setUserPasswd_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUserPasswd_Ljava_lang_String_Ljava_lang_String_);
			return cb_setUserPasswd_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetUserPasswd_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.ProxyHTTP __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ProxyHTTP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetUserPasswd (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setUserPasswd_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ProxyHTTP']/method[@name='setUserPasswd' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setUserPasswd", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetUserPasswd_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void SetUserPasswd (string p0, string p1)
		{
			if (id_setUserPasswd_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setUserPasswd_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUserPasswd", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setUserPasswd_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserPasswd", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}

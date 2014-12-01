using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Proxy']"
	[Register ("com/jcraft/jsch/Proxy", "", "Com.Jcraft.Jsch.IProxyInvoker")]
	public partial interface IProxy : IJavaObject {

		global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Proxy']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler:Com.Jcraft.Jsch.IProxyInvoker, JSchBindings")] get;
		}

		global::System.IO.Stream OutputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Proxy']/method[@name='getOutputStream' and count(parameter)=0]"
			[Register ("getOutputStream", "()Ljava/io/OutputStream;", "GetGetOutputStreamHandler:Com.Jcraft.Jsch.IProxyInvoker, JSchBindings")] get;
		}

		global::Java.Net.Socket Socket {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Proxy']/method[@name='getSocket' and count(parameter)=0]"
			[Register ("getSocket", "()Ljava/net/Socket;", "GetGetSocketHandler:Com.Jcraft.Jsch.IProxyInvoker, JSchBindings")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Proxy']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Com.Jcraft.Jsch.IProxyInvoker, JSchBindings")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Proxy']/method[@name='connect' and count(parameter)=4 and parameter[1][@type='com.jcraft.jsch.SocketFactory'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("connect", "(Lcom/jcraft/jsch/SocketFactory;Ljava/lang/String;II)V", "GetConnect_Lcom_jcraft_jsch_SocketFactory_Ljava_lang_String_IIHandler:Com.Jcraft.Jsch.IProxyInvoker, JSchBindings")]
		void Connect (global::Com.Jcraft.Jsch.ISocketFactory p0, string p1, int p2, int p3);

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/Proxy", DoNotGenerateAcw=true)]
	internal class IProxyInvoker : global::Java.Lang.Object, IProxy {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jcraft/jsch/Proxy");
		IntPtr class_ref;

		public static IProxy GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IProxy> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jcraft.jsch.Proxy"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IProxyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IProxyInvoker); }
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
			global::Com.Jcraft.Jsch.IProxy __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		IntPtr id_getInputStream;
		public global::System.IO.Stream InputStream {
			get {
				if (id_getInputStream == IntPtr.Zero)
					id_getInputStream = JNIEnv.GetMethodID (class_ref, "getInputStream", "()Ljava/io/InputStream;");
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getInputStream), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Jcraft.Jsch.IProxy __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.OutputStream);
		}
#pragma warning restore 0169

		IntPtr id_getOutputStream;
		public global::System.IO.Stream OutputStream {
			get {
				if (id_getOutputStream == IntPtr.Zero)
					id_getOutputStream = JNIEnv.GetMethodID (class_ref, "getOutputStream", "()Ljava/io/OutputStream;");
				return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getOutputStream), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Jcraft.Jsch.IProxy __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Socket);
		}
#pragma warning restore 0169

		IntPtr id_getSocket;
		public global::Java.Net.Socket Socket {
			get {
				if (id_getSocket == IntPtr.Zero)
					id_getSocket = JNIEnv.GetMethodID (class_ref, "getSocket", "()Ljava/net/Socket;");
				return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (JNIEnv.CallObjectMethod (Handle, id_getSocket), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Jcraft.Jsch.IProxy __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (Handle, id_close);
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
			global::Com.Jcraft.Jsch.IProxy __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.ISocketFactory p0 = (global::Com.Jcraft.Jsch.ISocketFactory)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISocketFactory> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_connect_Lcom_jcraft_jsch_SocketFactory_Ljava_lang_String_II;
		public void Connect (global::Com.Jcraft.Jsch.ISocketFactory p0, string p1, int p2, int p3)
		{
			if (id_connect_Lcom_jcraft_jsch_SocketFactory_Ljava_lang_String_II == IntPtr.Zero)
				id_connect_Lcom_jcraft_jsch_SocketFactory_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "connect", "(Lcom/jcraft/jsch/SocketFactory;Ljava/lang/String;II)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_connect_Lcom_jcraft_jsch_SocketFactory_Ljava_lang_String_II, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}

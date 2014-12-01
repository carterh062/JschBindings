using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='SocketFactory']"
	[Register ("com/jcraft/jsch/SocketFactory", "", "Com.Jcraft.Jsch.ISocketFactoryInvoker")]
	public partial interface ISocketFactory : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='SocketFactory']/method[@name='createSocket' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;", "GetCreateSocket_Ljava_lang_String_IHandler:Com.Jcraft.Jsch.ISocketFactoryInvoker, JSchBindings")]
		global::Java.Net.Socket CreateSocket (string p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='SocketFactory']/method[@name='getInputStream' and count(parameter)=1 and parameter[1][@type='java.net.Socket']]"
		[Register ("getInputStream", "(Ljava/net/Socket;)Ljava/io/InputStream;", "GetGetInputStream_Ljava_net_Socket_Handler:Com.Jcraft.Jsch.ISocketFactoryInvoker, JSchBindings")]
		global::System.IO.Stream GetInputStream (global::Java.Net.Socket p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='SocketFactory']/method[@name='getOutputStream' and count(parameter)=1 and parameter[1][@type='java.net.Socket']]"
		[Register ("getOutputStream", "(Ljava/net/Socket;)Ljava/io/OutputStream;", "GetGetOutputStream_Ljava_net_Socket_Handler:Com.Jcraft.Jsch.ISocketFactoryInvoker, JSchBindings")]
		global::System.IO.Stream GetOutputStream (global::Java.Net.Socket p0);

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/SocketFactory", DoNotGenerateAcw=true)]
	internal class ISocketFactoryInvoker : global::Java.Lang.Object, ISocketFactory {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jcraft/jsch/SocketFactory");
		IntPtr class_ref;

		public static ISocketFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISocketFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jcraft.jsch.SocketFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISocketFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISocketFactoryInvoker); }
		}

		static Delegate cb_createSocket_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetCreateSocket_Ljava_lang_String_IHandler ()
		{
			if (cb_createSocket_Ljava_lang_String_I == null)
				cb_createSocket_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_CreateSocket_Ljava_lang_String_I);
			return cb_createSocket_Ljava_lang_String_I;
		}

		static IntPtr n_CreateSocket_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Jcraft.Jsch.ISocketFactory __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISocketFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSocket (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createSocket_Ljava_lang_String_I;
		public global::Java.Net.Socket CreateSocket (string p0, int p1)
		{
			if (id_createSocket_Ljava_lang_String_I == IntPtr.Zero)
				id_createSocket_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Java.Net.Socket __ret = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (JNIEnv.CallObjectMethod (Handle, id_createSocket_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getInputStream_Ljava_net_Socket_;
#pragma warning disable 0169
		static Delegate GetGetInputStream_Ljava_net_Socket_Handler ()
		{
			if (cb_getInputStream_Ljava_net_Socket_ == null)
				cb_getInputStream_Ljava_net_Socket_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetInputStream_Ljava_net_Socket_);
			return cb_getInputStream_Ljava_net_Socket_;
		}

		static IntPtr n_GetInputStream_Ljava_net_Socket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ISocketFactory __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISocketFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.Socket p0 = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.GetInputStream (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getInputStream_Ljava_net_Socket_;
		public global::System.IO.Stream GetInputStream (global::Java.Net.Socket p0)
		{
			if (id_getInputStream_Ljava_net_Socket_ == IntPtr.Zero)
				id_getInputStream_Ljava_net_Socket_ = JNIEnv.GetMethodID (class_ref, "getInputStream", "(Ljava/net/Socket;)Ljava/io/InputStream;");
			global::System.IO.Stream __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getInputStream_Ljava_net_Socket_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getOutputStream_Ljava_net_Socket_;
#pragma warning disable 0169
		static Delegate GetGetOutputStream_Ljava_net_Socket_Handler ()
		{
			if (cb_getOutputStream_Ljava_net_Socket_ == null)
				cb_getOutputStream_Ljava_net_Socket_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetOutputStream_Ljava_net_Socket_);
			return cb_getOutputStream_Ljava_net_Socket_;
		}

		static IntPtr n_GetOutputStream_Ljava_net_Socket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ISocketFactory __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISocketFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.Socket p0 = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.GetOutputStream (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getOutputStream_Ljava_net_Socket_;
		public global::System.IO.Stream GetOutputStream (global::Java.Net.Socket p0)
		{
			if (id_getOutputStream_Ljava_net_Socket_ == IntPtr.Zero)
				id_getOutputStream_Ljava_net_Socket_ = JNIEnv.GetMethodID (class_ref, "getOutputStream", "(Ljava/net/Socket;)Ljava/io/OutputStream;");
			global::System.IO.Stream __ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getOutputStream_Ljava_net_Socket_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}

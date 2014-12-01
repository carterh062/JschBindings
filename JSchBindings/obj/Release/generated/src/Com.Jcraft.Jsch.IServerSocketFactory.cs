using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='ServerSocketFactory']"
	[Register ("com/jcraft/jsch/ServerSocketFactory", "", "Com.Jcraft.Jsch.IServerSocketFactoryInvoker")]
	public partial interface IServerSocketFactory : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='ServerSocketFactory']/method[@name='createServerSocket' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.net.InetAddress']]"
		[Register ("createServerSocket", "(IILjava/net/InetAddress;)Ljava/net/ServerSocket;", "GetCreateServerSocket_IILjava_net_InetAddress_Handler:Com.Jcraft.Jsch.IServerSocketFactoryInvoker, JSchBindings")]
		global::Java.Net.ServerSocket CreateServerSocket (int p0, int p1, global::Java.Net.InetAddress p2);

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/ServerSocketFactory", DoNotGenerateAcw=true)]
	internal class IServerSocketFactoryInvoker : global::Java.Lang.Object, IServerSocketFactory {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jcraft/jsch/ServerSocketFactory");
		IntPtr class_ref;

		public static IServerSocketFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IServerSocketFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jcraft.jsch.ServerSocketFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IServerSocketFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IServerSocketFactoryInvoker); }
		}

		static Delegate cb_createServerSocket_IILjava_net_InetAddress_;
#pragma warning disable 0169
		static Delegate GetCreateServerSocket_IILjava_net_InetAddress_Handler ()
		{
			if (cb_createServerSocket_IILjava_net_InetAddress_ == null)
				cb_createServerSocket_IILjava_net_InetAddress_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_CreateServerSocket_IILjava_net_InetAddress_);
			return cb_createServerSocket_IILjava_net_InetAddress_;
		}

		static IntPtr n_CreateServerSocket_IILjava_net_InetAddress_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Com.Jcraft.Jsch.IServerSocketFactory __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IServerSocketFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.InetAddress p2 = global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateServerSocket (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createServerSocket_IILjava_net_InetAddress_;
		public global::Java.Net.ServerSocket CreateServerSocket (int p0, int p1, global::Java.Net.InetAddress p2)
		{
			if (id_createServerSocket_IILjava_net_InetAddress_ == IntPtr.Zero)
				id_createServerSocket_IILjava_net_InetAddress_ = JNIEnv.GetMethodID (class_ref, "createServerSocket", "(IILjava/net/InetAddress;)Ljava/net/ServerSocket;");
			global::Java.Net.ServerSocket __ret = global::Java.Lang.Object.GetObject<global::Java.Net.ServerSocket> (JNIEnv.CallObjectMethod (Handle, id_createServerSocket_IILjava_net_InetAddress_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}

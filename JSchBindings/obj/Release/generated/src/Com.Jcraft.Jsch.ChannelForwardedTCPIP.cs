using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelForwardedTCPIP']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/ChannelForwardedTCPIP", DoNotGenerateAcw=true)]
	public partial class ChannelForwardedTCPIP : global::Com.Jcraft.Jsch.Channel {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelForwardedTCPIP.Config']"
		[global::Android.Runtime.Register ("com/jcraft/jsch/ChannelForwardedTCPIP$Config", DoNotGenerateAcw=true)]
		public abstract partial class Config : global::Java.Lang.Object {

			protected Config (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		[global::Android.Runtime.Register ("com/jcraft/jsch/ChannelForwardedTCPIP$Config", DoNotGenerateAcw=true)]
		internal partial class ConfigInvoker : Config {

			public ConfigInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (ConfigInvoker); }
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelForwardedTCPIP.ConfigDaemon']"
		[global::Android.Runtime.Register ("com/jcraft/jsch/ChannelForwardedTCPIP$ConfigDaemon", DoNotGenerateAcw=true)]
		public partial class ConfigDaemon : global::Com.Jcraft.Jsch.ChannelForwardedTCPIP.Config {

			protected ConfigDaemon (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelForwardedTCPIP.ConfigLHost']"
		[global::Android.Runtime.Register ("com/jcraft/jsch/ChannelForwardedTCPIP$ConfigLHost", DoNotGenerateAcw=true)]
		public partial class ConfigLHost : global::Com.Jcraft.Jsch.ChannelForwardedTCPIP.Config {

			protected ConfigLHost (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/ChannelForwardedTCPIP", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelForwardedTCPIP); }
		}

		protected ChannelForwardedTCPIP (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getRemotePort;
#pragma warning disable 0169
		static Delegate GetGetRemotePortHandler ()
		{
			if (cb_getRemotePort == null)
				cb_getRemotePort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRemotePort);
			return cb_getRemotePort;
		}

		static int n_GetRemotePort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.ChannelForwardedTCPIP __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelForwardedTCPIP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemotePort;
		}
#pragma warning restore 0169

		static IntPtr id_getRemotePort;
		public virtual int RemotePort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelForwardedTCPIP']/method[@name='getRemotePort' and count(parameter)=0]"
			[Register ("getRemotePort", "()I", "GetGetRemotePortHandler")]
			get {
				if (id_getRemotePort == IntPtr.Zero)
					id_getRemotePort = JNIEnv.GetMethodID (class_ref, "getRemotePort", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getRemotePort);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRemotePort", "()I"));
			}
		}

	}
}

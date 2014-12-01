using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	[Register ("com/jcraft/jsch/Logger")]
	public abstract class Logger {

		internal Logger ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Logger']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public const int Debug = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Logger']/field[@name='ERROR']"
		[Register ("ERROR")]
		public const int Error = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Logger']/field[@name='FATAL']"
		[Register ("FATAL")]
		public const int Fatal = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Logger']/field[@name='INFO']"
		[Register ("INFO")]
		public const int Info = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Logger']/field[@name='WARN']"
		[Register ("WARN")]
		public const int Warn = (int) 2;
	}

	[System.Obsolete ("Use the 'Logger' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class LoggerConsts : Logger {

		private LoggerConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Logger']"
	[Register ("com/jcraft/jsch/Logger", "", "Com.Jcraft.Jsch.ILoggerInvoker")]
	public partial interface ILogger : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Logger']/method[@name='isEnabled' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isEnabled", "(I)Z", "GetIsEnabled_IHandler:Com.Jcraft.Jsch.ILoggerInvoker, JSchBindings")]
		bool IsEnabled (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Logger']/method[@name='log' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("log", "(ILjava/lang/String;)V", "GetLog_ILjava_lang_String_Handler:Com.Jcraft.Jsch.ILoggerInvoker, JSchBindings")]
		void Log (int p0, string p1);

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/Logger", DoNotGenerateAcw=true)]
	internal class ILoggerInvoker : global::Java.Lang.Object, ILogger {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jcraft/jsch/Logger");
		IntPtr class_ref;

		public static ILogger GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILogger> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jcraft.jsch.Logger"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoggerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ILoggerInvoker); }
		}

		static Delegate cb_isEnabled_I;
#pragma warning disable 0169
		static Delegate GetIsEnabled_IHandler ()
		{
			if (cb_isEnabled_I == null)
				cb_isEnabled_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsEnabled_I);
			return cb_isEnabled_I;
		}

		static bool n_IsEnabled_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jcraft.Jsch.ILogger __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnabled (p0);
		}
#pragma warning restore 0169

		IntPtr id_isEnabled_I;
		public bool IsEnabled (int p0)
		{
			if (id_isEnabled_I == IntPtr.Zero)
				id_isEnabled_I = JNIEnv.GetMethodID (class_ref, "isEnabled", "(I)Z");
			return JNIEnv.CallBooleanMethod (Handle, id_isEnabled_I, new JValue (p0));
		}

		static Delegate cb_log_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLog_ILjava_lang_String_Handler ()
		{
			if (cb_log_ILjava_lang_String_ == null)
				cb_log_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Log_ILjava_lang_String_);
			return cb_log_ILjava_lang_String_;
		}

		static void n_Log_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.ILogger __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Log (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_log_ILjava_lang_String_;
		public void Log (int p0, string p1)
		{
			if (id_log_ILjava_lang_String_ == IntPtr.Zero)
				id_log_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "log", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_log_ILjava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}

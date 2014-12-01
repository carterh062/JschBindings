using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	[Register ("com/jcraft/jsch/SftpProgressMonitor")]
	public abstract class SftpProgressMonitor {

		internal SftpProgressMonitor ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='SftpProgressMonitor']/field[@name='GET']"
		[Register ("GET")]
		public const int Get = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='SftpProgressMonitor']/field[@name='PUT']"
		[Register ("PUT")]
		public const int Put = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='SftpProgressMonitor']/field[@name='UNKNOWN_SIZE']"
		[Register ("UNKNOWN_SIZE")]
		public const long UnknownSize = (long) -1L;
	}

	[System.Obsolete ("Use the 'SftpProgressMonitor' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class SftpProgressMonitorConsts : SftpProgressMonitor {

		private SftpProgressMonitorConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='SftpProgressMonitor']"
	[Register ("com/jcraft/jsch/SftpProgressMonitor", "", "Com.Jcraft.Jsch.ISftpProgressMonitorInvoker")]
	public partial interface ISftpProgressMonitor : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='SftpProgressMonitor']/method[@name='count' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("count", "(J)Z", "GetCount_JHandler:Com.Jcraft.Jsch.ISftpProgressMonitorInvoker, JSchBindings")]
		bool Count (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='SftpProgressMonitor']/method[@name='end' and count(parameter)=0]"
		[Register ("end", "()V", "GetEndHandler:Com.Jcraft.Jsch.ISftpProgressMonitorInvoker, JSchBindings")]
		void End ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='SftpProgressMonitor']/method[@name='init' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long']]"
		[Register ("init", "(ILjava/lang/String;Ljava/lang/String;J)V", "GetInit_ILjava_lang_String_Ljava_lang_String_JHandler:Com.Jcraft.Jsch.ISftpProgressMonitorInvoker, JSchBindings")]
		void Init (int p0, string p1, string p2, long p3);

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/SftpProgressMonitor", DoNotGenerateAcw=true)]
	internal class ISftpProgressMonitorInvoker : global::Java.Lang.Object, ISftpProgressMonitor {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jcraft/jsch/SftpProgressMonitor");
		IntPtr class_ref;

		public static ISftpProgressMonitor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISftpProgressMonitor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jcraft.jsch.SftpProgressMonitor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISftpProgressMonitorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISftpProgressMonitorInvoker); }
		}

		static Delegate cb_count_J;
#pragma warning disable 0169
		static Delegate GetCount_JHandler ()
		{
			if (cb_count_J == null)
				cb_count_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_Count_J);
			return cb_count_J;
		}

		static bool n_Count_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Jcraft.Jsch.ISftpProgressMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISftpProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count (p0);
		}
#pragma warning restore 0169

		IntPtr id_count_J;
		public bool Count (long p0)
		{
			if (id_count_J == IntPtr.Zero)
				id_count_J = JNIEnv.GetMethodID (class_ref, "count", "(J)Z");
			return JNIEnv.CallBooleanMethod (Handle, id_count_J, new JValue (p0));
		}

		static Delegate cb_end;
#pragma warning disable 0169
		static Delegate GetEndHandler ()
		{
			if (cb_end == null)
				cb_end = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_End);
			return cb_end;
		}

		static void n_End (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.ISftpProgressMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISftpProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.End ();
		}
#pragma warning restore 0169

		IntPtr id_end;
		public void End ()
		{
			if (id_end == IntPtr.Zero)
				id_end = JNIEnv.GetMethodID (class_ref, "end", "()V");
			JNIEnv.CallVoidMethod (Handle, id_end);
		}

		static Delegate cb_init_ILjava_lang_String_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetInit_ILjava_lang_String_Ljava_lang_String_JHandler ()
		{
			if (cb_init_ILjava_lang_String_Ljava_lang_String_J == null)
				cb_init_ILjava_lang_String_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, long>) n_Init_ILjava_lang_String_Ljava_lang_String_J);
			return cb_init_ILjava_lang_String_Ljava_lang_String_J;
		}

		static void n_Init_ILjava_lang_String_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, long p3)
		{
			global::Com.Jcraft.Jsch.ISftpProgressMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISftpProgressMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_init_ILjava_lang_String_Ljava_lang_String_J;
		public void Init (int p0, string p1, string p2, long p3)
		{
			if (id_init_ILjava_lang_String_Ljava_lang_String_J == IntPtr.Zero)
				id_init_ILjava_lang_String_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "init", "(ILjava/lang/String;Ljava/lang/String;J)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallVoidMethod (Handle, id_init_ILjava_lang_String_Ljava_lang_String_J, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

}

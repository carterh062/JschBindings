using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='GSSContext']"
	[Register ("com/jcraft/jsch/GSSContext", "", "Com.Jcraft.Jsch.IGSSContextInvoker")]
	public partial interface IGSSContext : IJavaObject {

		bool IsEstablished {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='GSSContext']/method[@name='isEstablished' and count(parameter)=0]"
			[Register ("isEstablished", "()Z", "GetIsEstablishedHandler:Com.Jcraft.Jsch.IGSSContextInvoker, JSchBindings")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='GSSContext']/method[@name='create' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("create", "(Ljava/lang/String;Ljava/lang/String;)V", "GetCreate_Ljava_lang_String_Ljava_lang_String_Handler:Com.Jcraft.Jsch.IGSSContextInvoker, JSchBindings")]
		void Create (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='GSSContext']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler:Com.Jcraft.Jsch.IGSSContextInvoker, JSchBindings")]
		void Dispose ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='GSSContext']/method[@name='getMIC' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getMIC", "([BII)[B", "GetGetMIC_arrayBIIHandler:Com.Jcraft.Jsch.IGSSContextInvoker, JSchBindings")]
		byte[] GetMIC (byte[] p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='GSSContext']/method[@name='init' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("init", "([BII)[B", "GetInit_arrayBIIHandler:Com.Jcraft.Jsch.IGSSContextInvoker, JSchBindings")]
		byte[] Init (byte[] p0, int p1, int p2);

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/GSSContext", DoNotGenerateAcw=true)]
	internal class IGSSContextInvoker : global::Java.Lang.Object, IGSSContext {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jcraft/jsch/GSSContext");
		IntPtr class_ref;

		public static IGSSContext GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGSSContext> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jcraft.jsch.GSSContext"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGSSContextInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IGSSContextInvoker); }
		}

		static Delegate cb_isEstablished;
#pragma warning disable 0169
		static Delegate GetIsEstablishedHandler ()
		{
			if (cb_isEstablished == null)
				cb_isEstablished = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEstablished);
			return cb_isEstablished;
		}

		static bool n_IsEstablished (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.IGSSContext __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IGSSContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEstablished;
		}
#pragma warning restore 0169

		IntPtr id_isEstablished;
		public bool IsEstablished {
			get {
				if (id_isEstablished == IntPtr.Zero)
					id_isEstablished = JNIEnv.GetMethodID (class_ref, "isEstablished", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isEstablished);
			}
		}

		static Delegate cb_create_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreate_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_create_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_create_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Create_Ljava_lang_String_Ljava_lang_String_);
			return cb_create_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Create_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.IGSSContext __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IGSSContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Create (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_create_Ljava_lang_String_Ljava_lang_String_;
		public void Create (string p0, string p1)
		{
			if (id_create_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_create_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "create", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_create_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.IGSSContext __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IGSSContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		IntPtr id_dispose;
		public void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
			JNIEnv.CallVoidMethod (Handle, id_dispose);
		}

		static Delegate cb_getMIC_arrayBII;
#pragma warning disable 0169
		static Delegate GetGetMIC_arrayBIIHandler ()
		{
			if (cb_getMIC_arrayBII == null)
				cb_getMIC_arrayBII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_GetMIC_arrayBII);
			return cb_getMIC_arrayBII;
		}

		static IntPtr n_GetMIC_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Jcraft.Jsch.IGSSContext __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IGSSContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.GetMIC (p0, p1, p2));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getMIC_arrayBII;
		public byte[] GetMIC (byte[] p0, int p1, int p2)
		{
			if (id_getMIC_arrayBII == IntPtr.Zero)
				id_getMIC_arrayBII = JNIEnv.GetMethodID (class_ref, "getMIC", "([BII)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getMIC_arrayBII, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_init_arrayBII;
#pragma warning disable 0169
		static Delegate GetInit_arrayBIIHandler ()
		{
			if (cb_init_arrayBII == null)
				cb_init_arrayBII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_Init_arrayBII);
			return cb_init_arrayBII;
		}

		static IntPtr n_Init_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Jcraft.Jsch.IGSSContext __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IGSSContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Init (p0, p1, p2));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_init_arrayBII;
		public byte[] Init (byte[] p0, int p1, int p2)
		{
			if (id_init_arrayBII == IntPtr.Zero)
				id_init_arrayBII = JNIEnv.GetMethodID (class_ref, "init", "([BII)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_init_arrayBII, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}

}

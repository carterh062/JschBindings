using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch.Jgss {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch.jgss']/class[@name='GSSContextKrb5']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/jgss/GSSContextKrb5", DoNotGenerateAcw=true)]
	public partial class GSSContextKrb5 : global::Java.Lang.Object, global::Com.Jcraft.Jsch.IGSSContext {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/jgss/GSSContextKrb5", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GSSContextKrb5); }
		}

		protected GSSContextKrb5 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch.jgss']/class[@name='GSSContextKrb5']/constructor[@name='GSSContextKrb5' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public GSSContextKrb5 () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GSSContextKrb5)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
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
			global::Com.Jcraft.Jsch.Jgss.GSSContextKrb5 __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jgss.GSSContextKrb5> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEstablished;
		}
#pragma warning restore 0169

		static IntPtr id_isEstablished;
		public virtual bool IsEstablished {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jgss']/class[@name='GSSContextKrb5']/method[@name='isEstablished' and count(parameter)=0]"
			[Register ("isEstablished", "()Z", "GetIsEstablishedHandler")]
			get {
				if (id_isEstablished == IntPtr.Zero)
					id_isEstablished = JNIEnv.GetMethodID (class_ref, "isEstablished", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isEstablished);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEstablished", "()Z"));
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
			global::Com.Jcraft.Jsch.Jgss.GSSContextKrb5 __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jgss.GSSContextKrb5> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Create (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_create_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jgss']/class[@name='GSSContextKrb5']/method[@name='create' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("create", "(Ljava/lang/String;Ljava/lang/String;)V", "GetCreate_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void Create (string p0, string p1)
		{
			if (id_create_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_create_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "create", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_create_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "create", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
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
			global::Com.Jcraft.Jsch.Jgss.GSSContextKrb5 __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jgss.GSSContextKrb5> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jgss']/class[@name='GSSContextKrb5']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispose);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispose", "()V"));
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
			global::Com.Jcraft.Jsch.Jgss.GSSContextKrb5 __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jgss.GSSContextKrb5> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.GetMIC (p0, p1, p2));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMIC_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jgss']/class[@name='GSSContextKrb5']/method[@name='getMIC' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getMIC", "([BII)[B", "GetGetMIC_arrayBIIHandler")]
		public virtual byte[] GetMIC (byte[] p0, int p1, int p2)
		{
			if (id_getMIC_arrayBII == IntPtr.Zero)
				id_getMIC_arrayBII = JNIEnv.GetMethodID (class_ref, "getMIC", "([BII)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			byte[] __ret;
			if (GetType () == ThresholdType)
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getMIC_arrayBII, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMIC", "([BII)[B"), new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Jcraft.Jsch.Jgss.GSSContextKrb5 __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jgss.GSSContextKrb5> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Init (p0, p1, p2));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_init_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jgss']/class[@name='GSSContextKrb5']/method[@name='init' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("init", "([BII)[B", "GetInit_arrayBIIHandler")]
		public virtual byte[] Init (byte[] p0, int p1, int p2)
		{
			if (id_init_arrayBII == IntPtr.Zero)
				id_init_arrayBII = JNIEnv.GetMethodID (class_ref, "init", "([BII)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			byte[] __ret;
			if (GetType () == ThresholdType)
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_init_arrayBII, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "([BII)[B"), new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}
}

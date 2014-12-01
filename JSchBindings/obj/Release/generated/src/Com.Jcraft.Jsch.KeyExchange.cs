using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyExchange']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/KeyExchange", DoNotGenerateAcw=true)]
	public abstract partial class KeyExchange : global::Java.Lang.Object {


		static IntPtr H_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyExchange']/field[@name='H']"
		[Register ("H")]
		protected IList<byte> H {
			get {
				if (H_jfieldId == IntPtr.Zero)
					H_jfieldId = JNIEnv.GetFieldID (class_ref, "H", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, H_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (H_jfieldId == IntPtr.Zero)
					H_jfieldId = JNIEnv.GetFieldID (class_ref, "H", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, H_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr K_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyExchange']/field[@name='K']"
		[Register ("K")]
		protected IList<byte> K {
			get {
				if (K_jfieldId == IntPtr.Zero)
					K_jfieldId = JNIEnv.GetFieldID (class_ref, "K", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, K_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (K_jfieldId == IntPtr.Zero)
					K_jfieldId = JNIEnv.GetFieldID (class_ref, "K", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, K_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr K_S_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyExchange']/field[@name='K_S']"
		[Register ("K_S")]
		protected IList<byte> KS {
			get {
				if (K_S_jfieldId == IntPtr.Zero)
					K_S_jfieldId = JNIEnv.GetFieldID (class_ref, "K_S", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, K_S_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (K_S_jfieldId == IntPtr.Zero)
					K_S_jfieldId = JNIEnv.GetFieldID (class_ref, "K_S", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, K_S_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyExchange']/field[@name='STATE_END']"
		[Register ("STATE_END")]
		public const int StateEnd = (int) 0;

		static IntPtr session_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyExchange']/field[@name='session']"
		[Register ("session")]
		protected global::Com.Jcraft.Jsch.Session Session {
			get {
				if (session_jfieldId == IntPtr.Zero)
					session_jfieldId = JNIEnv.GetFieldID (class_ref, "session", "Lcom/jcraft/jsch/Session;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, session_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (session_jfieldId == IntPtr.Zero)
					session_jfieldId = JNIEnv.GetFieldID (class_ref, "session", "Lcom/jcraft/jsch/Session;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, session_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr sha_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyExchange']/field[@name='sha']"
		[Register ("sha")]
		protected global::Com.Jcraft.Jsch.IHASH Sha {
			get {
				if (sha_jfieldId == IntPtr.Zero)
					sha_jfieldId = JNIEnv.GetFieldID (class_ref, "sha", "Lcom/jcraft/jsch/HASH;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, sha_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IHASH> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sha_jfieldId == IntPtr.Zero)
					sha_jfieldId = JNIEnv.GetFieldID (class_ref, "sha", "Lcom/jcraft/jsch/HASH;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, sha_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/KeyExchange", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KeyExchange); }
		}

		protected KeyExchange (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyExchange']/constructor[@name='KeyExchange' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public KeyExchange () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (KeyExchange)) {
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

		static Delegate cb_getFingerPrint;
#pragma warning disable 0169
		static Delegate GetGetFingerPrintHandler ()
		{
			if (cb_getFingerPrint == null)
				cb_getFingerPrint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFingerPrint);
			return cb_getFingerPrint;
		}

		static IntPtr n_GetFingerPrint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.KeyExchange __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyExchange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FingerPrint);
		}
#pragma warning restore 0169

		static IntPtr id_getFingerPrint;
		public virtual string FingerPrint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyExchange']/method[@name='getFingerPrint' and count(parameter)=0]"
			[Register ("getFingerPrint", "()Ljava/lang/String;", "GetGetFingerPrintHandler")]
			get {
				if (id_getFingerPrint == IntPtr.Zero)
					id_getFingerPrint = JNIEnv.GetMethodID (class_ref, "getFingerPrint", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFingerPrint), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFingerPrint", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getKeyType;
#pragma warning disable 0169
		static Delegate GetGetKeyTypeHandler ()
		{
			if (cb_getKeyType == null)
				cb_getKeyType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKeyType);
			return cb_getKeyType;
		}

		static IntPtr n_GetKeyType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.KeyExchange __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyExchange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.KeyType);
		}
#pragma warning restore 0169

		public abstract string KeyType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyExchange']/method[@name='getKeyType' and count(parameter)=0]"
			[Register ("getKeyType", "()Ljava/lang/String;", "GetGetKeyTypeHandler")] get;
		}

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetState);
			return cb_getState;
		}

		static int n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.KeyExchange __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyExchange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.State;
		}
#pragma warning restore 0169

		public abstract int State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyExchange']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()I", "GetGetStateHandler")] get;
		}

		static IntPtr id_guess_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyExchange']/method[@name='guess' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("guess", "([B[B)[Ljava/lang/String;", "")]
		protected static string[] Guess (byte[] p0, byte[] p1)
		{
			if (id_guess_arrayBarrayB == IntPtr.Zero)
				id_guess_arrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "guess", "([B[B)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_guess_arrayBarrayB, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef, typeof (string));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_init_Lcom_jcraft_jsch_Session_arrayBarrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetInit_Lcom_jcraft_jsch_Session_arrayBarrayBarrayBarrayBHandler ()
		{
			if (cb_init_Lcom_jcraft_jsch_Session_arrayBarrayBarrayBarrayB == null)
				cb_init_Lcom_jcraft_jsch_Session_arrayBarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Lcom_jcraft_jsch_Session_arrayBarrayBarrayBarrayB);
			return cb_init_Lcom_jcraft_jsch_Session_arrayBarrayBarrayBarrayB;
		}

		static void n_Init_Lcom_jcraft_jsch_Session_arrayBarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Jcraft.Jsch.KeyExchange __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyExchange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.Session p0 = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Session> (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p4 = (byte[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Init (p0, p1, p2, p3, p4);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyExchange']/method[@name='init' and count(parameter)=5 and parameter[1][@type='com.jcraft.jsch.Session'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
		[Register ("init", "(Lcom/jcraft/jsch/Session;[B[B[B[B)V", "GetInit_Lcom_jcraft_jsch_Session_arrayBarrayBarrayBarrayBHandler")]
		public abstract void Init (global::Com.Jcraft.Jsch.Session p0, byte[] p1, byte[] p2, byte[] p3, byte[] p4);

		static Delegate cb_next_Lcom_jcraft_jsch_Buffer_;
#pragma warning disable 0169
		static Delegate GetNext_Lcom_jcraft_jsch_Buffer_Handler ()
		{
			if (cb_next_Lcom_jcraft_jsch_Buffer_ == null)
				cb_next_Lcom_jcraft_jsch_Buffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Next_Lcom_jcraft_jsch_Buffer_);
			return cb_next_Lcom_jcraft_jsch_Buffer_;
		}

		static bool n_Next_Lcom_jcraft_jsch_Buffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.KeyExchange __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyExchange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.Buffer p0 = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Next (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyExchange']/method[@name='next' and count(parameter)=1 and parameter[1][@type='com.jcraft.jsch.Buffer']]"
		[Register ("next", "(Lcom/jcraft/jsch/Buffer;)Z", "GetNext_Lcom_jcraft_jsch_Buffer_Handler")]
		public abstract bool Next (global::Com.Jcraft.Jsch.Buffer p0);

		static Delegate cb_normalize_arrayB;
#pragma warning disable 0169
		static Delegate GetNormalize_arrayBHandler ()
		{
			if (cb_normalize_arrayB == null)
				cb_normalize_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Normalize_arrayB);
			return cb_normalize_arrayB;
		}

		static IntPtr n_Normalize_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.KeyExchange __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.KeyExchange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Normalize (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_normalize_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyExchange']/method[@name='normalize' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("normalize", "([B)[B", "GetNormalize_arrayBHandler")]
		protected virtual byte[] Normalize (byte[] p0)
		{
			if (id_normalize_arrayB == IntPtr.Zero)
				id_normalize_arrayB = JNIEnv.GetMethodID (class_ref, "normalize", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			byte[] __ret;
			if (GetType () == ThresholdType)
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_normalize_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "normalize", "([B)[B"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/KeyExchange", DoNotGenerateAcw=true)]
	internal partial class KeyExchangeInvoker : KeyExchange {

		public KeyExchangeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (KeyExchangeInvoker); }
		}

		static IntPtr id_getKeyType;
		public override string KeyType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyExchange']/method[@name='getKeyType' and count(parameter)=0]"
			[Register ("getKeyType", "()Ljava/lang/String;", "GetGetKeyTypeHandler")]
			get {
				if (id_getKeyType == IntPtr.Zero)
					id_getKeyType = JNIEnv.GetMethodID (class_ref, "getKeyType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getKeyType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getState;
		public override int State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyExchange']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()I", "GetGetStateHandler")]
			get {
				if (id_getState == IntPtr.Zero)
					id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getState);
			}
		}

		static IntPtr id_init_Lcom_jcraft_jsch_Session_arrayBarrayBarrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyExchange']/method[@name='init' and count(parameter)=5 and parameter[1][@type='com.jcraft.jsch.Session'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
		[Register ("init", "(Lcom/jcraft/jsch/Session;[B[B[B[B)V", "GetInit_Lcom_jcraft_jsch_Session_arrayBarrayBarrayBarrayBHandler")]
		public override void Init (global::Com.Jcraft.Jsch.Session p0, byte[] p1, byte[] p2, byte[] p3, byte[] p4)
		{
			if (id_init_Lcom_jcraft_jsch_Session_arrayBarrayBarrayBarrayB == IntPtr.Zero)
				id_init_Lcom_jcraft_jsch_Session_arrayBarrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "init", "(Lcom/jcraft/jsch/Session;[B[B[B[B)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JNIEnv.CallVoidMethod  (Handle, id_init_Lcom_jcraft_jsch_Session_arrayBarrayBarrayBarrayB, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_next_Lcom_jcraft_jsch_Buffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='KeyExchange']/method[@name='next' and count(parameter)=1 and parameter[1][@type='com.jcraft.jsch.Buffer']]"
		[Register ("next", "(Lcom/jcraft/jsch/Buffer;)Z", "GetNext_Lcom_jcraft_jsch_Buffer_Handler")]
		public override bool Next (global::Com.Jcraft.Jsch.Buffer p0)
		{
			if (id_next_Lcom_jcraft_jsch_Buffer_ == IntPtr.Zero)
				id_next_Lcom_jcraft_jsch_Buffer_ = JNIEnv.GetMethodID (class_ref, "next", "(Lcom/jcraft/jsch/Buffer;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_next_Lcom_jcraft_jsch_Buffer_, new JValue (p0));
			return __ret;
		}

	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='DHGEX']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/DHGEX", DoNotGenerateAcw=true)]
	public partial class DHGEX : global::Com.Jcraft.Jsch.KeyExchange {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/DHGEX", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DHGEX); }
		}

		protected DHGEX (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='DHGEX']/constructor[@name='DHGEX' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DHGEX () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DHGEX)) {
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
			global::Com.Jcraft.Jsch.DHGEX __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.DHGEX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.KeyType);
		}
#pragma warning restore 0169

		static IntPtr id_getKeyType;
		public override string KeyType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='DHGEX']/method[@name='getKeyType' and count(parameter)=0]"
			[Register ("getKeyType", "()Ljava/lang/String;", "GetGetKeyTypeHandler")]
			get {
				if (id_getKeyType == IntPtr.Zero)
					id_getKeyType = JNIEnv.GetMethodID (class_ref, "getKeyType", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getKeyType), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeyType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Com.Jcraft.Jsch.DHGEX __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.DHGEX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.State;
		}
#pragma warning restore 0169

		static IntPtr id_getState;
		public override int State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='DHGEX']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()I", "GetGetStateHandler")]
			get {
				if (id_getState == IntPtr.Zero)
					id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getState);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getState", "()I"));
			}
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
			global::Com.Jcraft.Jsch.DHGEX __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.DHGEX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static IntPtr id_init_Lcom_jcraft_jsch_Session_arrayBarrayBarrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='DHGEX']/method[@name='init' and count(parameter)=5 and parameter[1][@type='com.jcraft.jsch.Session'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
		[Register ("init", "(Lcom/jcraft/jsch/Session;[B[B[B[B)V", "GetInit_Lcom_jcraft_jsch_Session_arrayBarrayBarrayBarrayBHandler")]
		public override void Init (global::Com.Jcraft.Jsch.Session p0, byte[] p1, byte[] p2, byte[] p3, byte[] p4)
		{
			if (id_init_Lcom_jcraft_jsch_Session_arrayBarrayBarrayBarrayB == IntPtr.Zero)
				id_init_Lcom_jcraft_jsch_Session_arrayBarrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "init", "(Lcom/jcraft/jsch/Session;[B[B[B[B)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_init_Lcom_jcraft_jsch_Session_arrayBarrayBarrayBarrayB, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Lcom/jcraft/jsch/Session;[B[B[B[B)V"), new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4));
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
			global::Com.Jcraft.Jsch.DHGEX __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.DHGEX> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.Buffer p0 = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Next (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_next_Lcom_jcraft_jsch_Buffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='DHGEX']/method[@name='next' and count(parameter)=1 and parameter[1][@type='com.jcraft.jsch.Buffer']]"
		[Register ("next", "(Lcom/jcraft/jsch/Buffer;)Z", "GetNext_Lcom_jcraft_jsch_Buffer_Handler")]
		public override bool Next (global::Com.Jcraft.Jsch.Buffer p0)
		{
			if (id_next_Lcom_jcraft_jsch_Buffer_ == IntPtr.Zero)
				id_next_Lcom_jcraft_jsch_Buffer_ = JNIEnv.GetMethodID (class_ref, "next", "(Lcom/jcraft/jsch/Buffer;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_next_Lcom_jcraft_jsch_Buffer_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "next", "(Lcom/jcraft/jsch/Buffer;)Z"), new JValue (p0));
			return __ret;
		}

	}
}

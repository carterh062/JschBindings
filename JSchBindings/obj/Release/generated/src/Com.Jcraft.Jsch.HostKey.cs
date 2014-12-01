using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='HostKey']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/HostKey", DoNotGenerateAcw=true)]
	public partial class HostKey : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='HostKey']/field[@name='GUESS']"
		[Register ("GUESS")]
		protected const int Guess = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='HostKey']/field[@name='SSHDSS']"
		[Register ("SSHDSS")]
		public const int Sshdss = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='HostKey']/field[@name='SSHRSA']"
		[Register ("SSHRSA")]
		public const int Sshrsa = (int) 2;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/HostKey", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HostKey); }
		}

		protected HostKey (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_IarrayBLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='HostKey']/constructor[@name='HostKey' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;I[BLjava/lang/String;)V", "")]
		public HostKey (string p0, int p1, byte[] p2, string p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p2 = JNIEnv.NewArray (p2);;
			IntPtr native_p3 = JNIEnv.NewString (p3);;
			if (GetType () != typeof (HostKey)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;I[BLjava/lang/String;)V", new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;I[BLjava/lang/String;)V", new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3));
				JNIEnv.DeleteLocalRef (native_p0);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				JNIEnv.DeleteLocalRef (native_p3);
				return;
			}

			if (id_ctor_Ljava_lang_String_IarrayBLjava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_IarrayBLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;I[BLjava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_IarrayBLjava_lang_String_, new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_IarrayBLjava_lang_String_, new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static IntPtr id_ctor_Ljava_lang_String_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='HostKey']/constructor[@name='HostKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Ljava/lang/String;[B)V", "")]
		public HostKey (string p0, byte[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (HostKey)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;[B)V", new JValue (native_p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;[B)V", new JValue (native_p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return;
			}

			if (id_ctor_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_ctor_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;[B)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_arrayB, new JValue (native_p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_arrayB, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_IarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='HostKey']/constructor[@name='HostKey' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register (".ctor", "(Ljava/lang/String;I[B)V", "")]
		public HostKey (string p0, int p1, byte[] p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p2 = JNIEnv.NewArray (p2);;
			if (GetType () != typeof (HostKey)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;I[B)V", new JValue (native_p0), new JValue (p1), new JValue (native_p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;I[B)V", new JValue (native_p0), new JValue (p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p0);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				return;
			}

			if (id_ctor_Ljava_lang_String_IarrayB == IntPtr.Zero)
				id_ctor_Ljava_lang_String_IarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;I[B)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_IarrayB, new JValue (native_p0), new JValue (p1), new JValue (native_p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_IarrayB, new JValue (native_p0), new JValue (p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_IarrayBLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='HostKey']/constructor[@name='HostKey' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;I[BLjava/lang/String;)V", "")]
		public HostKey (string p0, string p1, int p2, byte[] p3, string p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p3 = JNIEnv.NewArray (p3);;
			IntPtr native_p4 = JNIEnv.NewString (p4);;
			if (GetType () != typeof (HostKey)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;I[BLjava/lang/String;)V", new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3), new JValue (native_p4)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;I[BLjava/lang/String;)V", new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3), new JValue (native_p4));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p4);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_IarrayBLjava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_IarrayBLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;I[BLjava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_IarrayBLjava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3), new JValue (native_p4)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_IarrayBLjava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3), new JValue (native_p4));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			JNIEnv.DeleteLocalRef (native_p4);
		}

		static Delegate cb_getComment;
#pragma warning disable 0169
		static Delegate GetGetCommentHandler ()
		{
			if (cb_getComment == null)
				cb_getComment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetComment);
			return cb_getComment;
		}

		static IntPtr n_GetComment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.HostKey __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.HostKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Comment);
		}
#pragma warning restore 0169

		static IntPtr id_getComment;
		public virtual string Comment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='HostKey']/method[@name='getComment' and count(parameter)=0]"
			[Register ("getComment", "()Ljava/lang/String;", "GetGetCommentHandler")]
			get {
				if (id_getComment == IntPtr.Zero)
					id_getComment = JNIEnv.GetMethodID (class_ref, "getComment", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getComment), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getComment", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getHost;
#pragma warning disable 0169
		static Delegate GetGetHostHandler ()
		{
			if (cb_getHost == null)
				cb_getHost = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHost);
			return cb_getHost;
		}

		static IntPtr n_GetHost (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.HostKey __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.HostKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Host);
		}
#pragma warning restore 0169

		static IntPtr id_getHost;
		public virtual string Host {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='HostKey']/method[@name='getHost' and count(parameter)=0]"
			[Register ("getHost", "()Ljava/lang/String;", "GetGetHostHandler")]
			get {
				if (id_getHost == IntPtr.Zero)
					id_getHost = JNIEnv.GetMethodID (class_ref, "getHost", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getHost), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHost", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getKey;
#pragma warning disable 0169
		static Delegate GetGetKeyHandler ()
		{
			if (cb_getKey == null)
				cb_getKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKey);
			return cb_getKey;
		}

		static IntPtr n_GetKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.HostKey __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.HostKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Key);
		}
#pragma warning restore 0169

		static IntPtr id_getKey;
		public virtual string Key {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='HostKey']/method[@name='getKey' and count(parameter)=0]"
			[Register ("getKey", "()Ljava/lang/String;", "GetGetKeyHandler")]
			get {
				if (id_getKey == IntPtr.Zero)
					id_getKey = JNIEnv.GetMethodID (class_ref, "getKey", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getKey), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMarker;
#pragma warning disable 0169
		static Delegate GetGetMarkerHandler ()
		{
			if (cb_getMarker == null)
				cb_getMarker = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMarker);
			return cb_getMarker;
		}

		static IntPtr n_GetMarker (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.HostKey __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.HostKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Marker);
		}
#pragma warning restore 0169

		static IntPtr id_getMarker;
		public virtual string Marker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='HostKey']/method[@name='getMarker' and count(parameter)=0]"
			[Register ("getMarker", "()Ljava/lang/String;", "GetGetMarkerHandler")]
			get {
				if (id_getMarker == IntPtr.Zero)
					id_getMarker = JNIEnv.GetMethodID (class_ref, "getMarker", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMarker), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMarker", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.HostKey __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.HostKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='HostKey']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getFingerPrint_Lcom_jcraft_jsch_JSch_;
#pragma warning disable 0169
		static Delegate GetGetFingerPrint_Lcom_jcraft_jsch_JSch_Handler ()
		{
			if (cb_getFingerPrint_Lcom_jcraft_jsch_JSch_ == null)
				cb_getFingerPrint_Lcom_jcraft_jsch_JSch_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetFingerPrint_Lcom_jcraft_jsch_JSch_);
			return cb_getFingerPrint_Lcom_jcraft_jsch_JSch_;
		}

		static IntPtr n_GetFingerPrint_Lcom_jcraft_jsch_JSch_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.HostKey __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.HostKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.JSch p0 = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.JSch> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetFingerPrint (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFingerPrint_Lcom_jcraft_jsch_JSch_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='HostKey']/method[@name='getFingerPrint' and count(parameter)=1 and parameter[1][@type='com.jcraft.jsch.JSch']]"
		[Register ("getFingerPrint", "(Lcom/jcraft/jsch/JSch;)Ljava/lang/String;", "GetGetFingerPrint_Lcom_jcraft_jsch_JSch_Handler")]
		public virtual string GetFingerPrint (global::Com.Jcraft.Jsch.JSch p0)
		{
			if (id_getFingerPrint_Lcom_jcraft_jsch_JSch_ == IntPtr.Zero)
				id_getFingerPrint_Lcom_jcraft_jsch_JSch_ = JNIEnv.GetMethodID (class_ref, "getFingerPrint", "(Lcom/jcraft/jsch/JSch;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFingerPrint_Lcom_jcraft_jsch_JSch_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFingerPrint", "(Lcom/jcraft/jsch/JSch;)Ljava/lang/String;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}

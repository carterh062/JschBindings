using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/Buffer", DoNotGenerateAcw=true)]
	public partial class Buffer : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/Buffer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Buffer); }
		}

		protected Buffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']/constructor[@name='Buffer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Buffer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Buffer)) {
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

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']/constructor[@name='Buffer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public Buffer (int p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Buffer)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", new JValue (p0));
				return;
			}

			if (id_ctor_I == IntPtr.Zero)
				id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, new JValue (p0));
		}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']/constructor[@name='Buffer' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public Buffer (byte[] p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);;
			if (GetType () != typeof (Buffer)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([B)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([B)V", new JValue (native_p0));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return;
			}

			if (id_ctor_arrayB == IntPtr.Zero)
				id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayB, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getByte;
#pragma warning disable 0169
		static Delegate GetGetByteHandler ()
		{
			if (cb_getByte == null)
				cb_getByte = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetByte);
			return cb_getByte;
		}

		static int n_GetByte (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Buffer __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Byte;
		}
#pragma warning restore 0169

		static IntPtr id_getByte;
		public virtual int Byte {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']/method[@name='getByte' and count(parameter)=0]"
			[Register ("getByte", "()I", "GetGetByteHandler")]
			get {
				if (id_getByte == IntPtr.Zero)
					id_getByte = JNIEnv.GetMethodID (class_ref, "getByte", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getByte);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getByte", "()I"));
			}
		}

		static Delegate cb_getInt;
#pragma warning disable 0169
		static Delegate GetGetIntHandler ()
		{
			if (cb_getInt == null)
				cb_getInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetInt);
			return cb_getInt;
		}

		static int n_GetInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Buffer __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Int;
		}
#pragma warning restore 0169

		static IntPtr id_getInt;
		public virtual int Int {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']/method[@name='getInt' and count(parameter)=0]"
			[Register ("getInt", "()I", "GetGetIntHandler")]
			get {
				if (id_getInt == IntPtr.Zero)
					id_getInt = JNIEnv.GetMethodID (class_ref, "getInt", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getInt);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInt", "()I"));
			}
		}

		static Delegate cb_getLength;
#pragma warning disable 0169
		static Delegate GetGetLengthHandler ()
		{
			if (cb_getLength == null)
				cb_getLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLength);
			return cb_getLength;
		}

		static int n_GetLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Buffer __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length;
		}
#pragma warning restore 0169

		static IntPtr id_getLength;
		public virtual int Length {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']/method[@name='getLength' and count(parameter)=0]"
			[Register ("getLength", "()I", "GetGetLengthHandler")]
			get {
				if (id_getLength == IntPtr.Zero)
					id_getLength = JNIEnv.GetMethodID (class_ref, "getLength", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLength);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLength", "()I"));
			}
		}

		static Delegate cb_getLong;
#pragma warning disable 0169
		static Delegate GetGetLongHandler ()
		{
			if (cb_getLong == null)
				cb_getLong = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLong);
			return cb_getLong;
		}

		static long n_GetLong (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Buffer __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Long;
		}
#pragma warning restore 0169

		static IntPtr id_getLong;
		public virtual long Long {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']/method[@name='getLong' and count(parameter)=0]"
			[Register ("getLong", "()J", "GetGetLongHandler")]
			get {
				if (id_getLong == IntPtr.Zero)
					id_getLong = JNIEnv.GetMethodID (class_ref, "getLong", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getLong);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLong", "()J"));
			}
		}

		static Delegate cb_getOffSet;
#pragma warning disable 0169
		static Delegate GetGetOffSetHandler ()
		{
			if (cb_getOffSet == null)
				cb_getOffSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOffSet);
			return cb_getOffSet;
		}

		static int n_GetOffSet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Buffer __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OffSet;
		}
#pragma warning restore 0169

		static Delegate cb_setOffSet_I;
#pragma warning disable 0169
		static Delegate GetSetOffSet_IHandler ()
		{
			if (cb_setOffSet_I == null)
				cb_setOffSet_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetOffSet_I);
			return cb_setOffSet_I;
		}

		static void n_SetOffSet_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jcraft.Jsch.Buffer __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OffSet = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOffSet;
		static IntPtr id_setOffSet_I;
		public virtual int OffSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']/method[@name='getOffSet' and count(parameter)=0]"
			[Register ("getOffSet", "()I", "GetGetOffSetHandler")]
			get {
				if (id_getOffSet == IntPtr.Zero)
					id_getOffSet = JNIEnv.GetMethodID (class_ref, "getOffSet", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getOffSet);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOffSet", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']/method[@name='setOffSet' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setOffSet", "(I)V", "GetSetOffSet_IHandler")]
			set {
				if (id_setOffSet_I == IntPtr.Zero)
					id_setOffSet_I = JNIEnv.GetMethodID (class_ref, "setOffSet", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOffSet_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOffSet", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getUInt;
#pragma warning disable 0169
		static Delegate GetGetUIntHandler ()
		{
			if (cb_getUInt == null)
				cb_getUInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetUInt);
			return cb_getUInt;
		}

		static long n_GetUInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Buffer __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UInt;
		}
#pragma warning restore 0169

		static IntPtr id_getUInt;
		public virtual long UInt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']/method[@name='getUInt' and count(parameter)=0]"
			[Register ("getUInt", "()J", "GetGetUIntHandler")]
			get {
				if (id_getUInt == IntPtr.Zero)
					id_getUInt = JNIEnv.GetMethodID (class_ref, "getUInt", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getUInt);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUInt", "()J"));
			}
		}

		static Delegate cb_getByte_arrayB;
#pragma warning disable 0169
		static Delegate GetGetByte_arrayBHandler ()
		{
			if (cb_getByte_arrayB == null)
				cb_getByte_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetByte_arrayB);
			return cb_getByte_arrayB;
		}

		static void n_GetByte_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Buffer __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.GetByte (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_getByte_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']/method[@name='getByte' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getByte", "([B)V", "GetGetByte_arrayBHandler")]
		public virtual void GetByte (byte[] p0)
		{
			if (id_getByte_arrayB == IntPtr.Zero)
				id_getByte_arrayB = JNIEnv.GetMethodID (class_ref, "getByte", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_getByte_arrayB, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getByte", "([B)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getByte_I;
#pragma warning disable 0169
		static Delegate GetGetByte_IHandler ()
		{
			if (cb_getByte_I == null)
				cb_getByte_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetByte_I);
			return cb_getByte_I;
		}

		static int n_GetByte_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jcraft.Jsch.Buffer __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetByte (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getByte_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']/method[@name='getByte' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getByte", "(I)I", "GetGetByte_IHandler")]
		public virtual int GetByte (int p0)
		{
			if (id_getByte_I == IntPtr.Zero)
				id_getByte_I = JNIEnv.GetMethodID (class_ref, "getByte", "(I)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_getByte_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getByte", "(I)I"), new JValue (p0));
		}

		static Delegate cb_getMPInt;
#pragma warning disable 0169
		static Delegate GetGetMPIntHandler ()
		{
			if (cb_getMPInt == null)
				cb_getMPInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMPInt);
			return cb_getMPInt;
		}

		static IntPtr n_GetMPInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Buffer __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetMPInt ());
		}
#pragma warning restore 0169

		static IntPtr id_getMPInt;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']/method[@name='getMPInt' and count(parameter)=0]"
		[Register ("getMPInt", "()[B", "GetGetMPIntHandler")]
		public virtual byte[] GetMPInt ()
		{
			if (id_getMPInt == IntPtr.Zero)
				id_getMPInt = JNIEnv.GetMethodID (class_ref, "getMPInt", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getMPInt), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMPInt", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_getMPIntBits;
#pragma warning disable 0169
		static Delegate GetGetMPIntBitsHandler ()
		{
			if (cb_getMPIntBits == null)
				cb_getMPIntBits = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMPIntBits);
			return cb_getMPIntBits;
		}

		static IntPtr n_GetMPIntBits (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Buffer __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetMPIntBits ());
		}
#pragma warning restore 0169

		static IntPtr id_getMPIntBits;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']/method[@name='getMPIntBits' and count(parameter)=0]"
		[Register ("getMPIntBits", "()[B", "GetGetMPIntBitsHandler")]
		public virtual byte[] GetMPIntBits ()
		{
			if (id_getMPIntBits == IntPtr.Zero)
				id_getMPIntBits = JNIEnv.GetMethodID (class_ref, "getMPIntBits", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getMPIntBits), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMPIntBits", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_getString;
#pragma warning disable 0169
		static Delegate GetGetStringHandler ()
		{
			if (cb_getString == null)
				cb_getString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetString);
			return cb_getString;
		}

		static IntPtr n_GetString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Buffer __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetString ());
		}
#pragma warning restore 0169

		static IntPtr id_getString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']/method[@name='getString' and count(parameter)=0]"
		[Register ("getString", "()[B", "GetGetStringHandler")]
		public virtual byte[] GetString ()
		{
			if (id_getString == IntPtr.Zero)
				id_getString = JNIEnv.GetMethodID (class_ref, "getString", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getString), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getString", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_putByte_B;
#pragma warning disable 0169
		static Delegate GetPutByte_BHandler ()
		{
			if (cb_putByte_B == null)
				cb_putByte_B = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, sbyte>) n_PutByte_B);
			return cb_putByte_B;
		}

		static void n_PutByte_B (IntPtr jnienv, IntPtr native__this, sbyte p0)
		{
			global::Com.Jcraft.Jsch.Buffer __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PutByte (p0);
		}
#pragma warning restore 0169

		static IntPtr id_putByte_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']/method[@name='putByte' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("putByte", "(B)V", "GetPutByte_BHandler")]
		public virtual void PutByte (sbyte p0)
		{
			if (id_putByte_B == IntPtr.Zero)
				id_putByte_B = JNIEnv.GetMethodID (class_ref, "putByte", "(B)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_putByte_B, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putByte", "(B)V"), new JValue (p0));
		}

		static Delegate cb_putByte_arrayB;
#pragma warning disable 0169
		static Delegate GetPutByte_arrayBHandler ()
		{
			if (cb_putByte_arrayB == null)
				cb_putByte_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutByte_arrayB);
			return cb_putByte_arrayB;
		}

		static void n_PutByte_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Buffer __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.PutByte (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_putByte_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']/method[@name='putByte' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("putByte", "([B)V", "GetPutByte_arrayBHandler")]
		public virtual void PutByte (byte[] p0)
		{
			if (id_putByte_arrayB == IntPtr.Zero)
				id_putByte_arrayB = JNIEnv.GetMethodID (class_ref, "putByte", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_putByte_arrayB, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putByte", "([B)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putByte_arrayBII;
#pragma warning disable 0169
		static Delegate GetPutByte_arrayBIIHandler ()
		{
			if (cb_putByte_arrayBII == null)
				cb_putByte_arrayBII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_PutByte_arrayBII);
			return cb_putByte_arrayBII;
		}

		static void n_PutByte_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Jcraft.Jsch.Buffer __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.PutByte (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_putByte_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']/method[@name='putByte' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("putByte", "([BII)V", "GetPutByte_arrayBIIHandler")]
		public virtual void PutByte (byte[] p0, int p1, int p2)
		{
			if (id_putByte_arrayBII == IntPtr.Zero)
				id_putByte_arrayBII = JNIEnv.GetMethodID (class_ref, "putByte", "([BII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_putByte_arrayBII, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putByte", "([BII)V"), new JValue (native_p0), new JValue (p1), new JValue (p2));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putInt_I;
#pragma warning disable 0169
		static Delegate GetPutInt_IHandler ()
		{
			if (cb_putInt_I == null)
				cb_putInt_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_PutInt_I);
			return cb_putInt_I;
		}

		static void n_PutInt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jcraft.Jsch.Buffer __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PutInt (p0);
		}
#pragma warning restore 0169

		static IntPtr id_putInt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']/method[@name='putInt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("putInt", "(I)V", "GetPutInt_IHandler")]
		public virtual void PutInt (int p0)
		{
			if (id_putInt_I == IntPtr.Zero)
				id_putInt_I = JNIEnv.GetMethodID (class_ref, "putInt", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_putInt_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putInt", "(I)V"), new JValue (p0));
		}

		static Delegate cb_putLong_J;
#pragma warning disable 0169
		static Delegate GetPutLong_JHandler ()
		{
			if (cb_putLong_J == null)
				cb_putLong_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_PutLong_J);
			return cb_putLong_J;
		}

		static void n_PutLong_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Jcraft.Jsch.Buffer __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PutLong (p0);
		}
#pragma warning restore 0169

		static IntPtr id_putLong_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']/method[@name='putLong' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("putLong", "(J)V", "GetPutLong_JHandler")]
		public virtual void PutLong (long p0)
		{
			if (id_putLong_J == IntPtr.Zero)
				id_putLong_J = JNIEnv.GetMethodID (class_ref, "putLong", "(J)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_putLong_J, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putLong", "(J)V"), new JValue (p0));
		}

		static Delegate cb_putMPInt_arrayB;
#pragma warning disable 0169
		static Delegate GetPutMPInt_arrayBHandler ()
		{
			if (cb_putMPInt_arrayB == null)
				cb_putMPInt_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutMPInt_arrayB);
			return cb_putMPInt_arrayB;
		}

		static void n_PutMPInt_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Buffer __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.PutMPInt (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_putMPInt_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']/method[@name='putMPInt' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("putMPInt", "([B)V", "GetPutMPInt_arrayBHandler")]
		public virtual void PutMPInt (byte[] p0)
		{
			if (id_putMPInt_arrayB == IntPtr.Zero)
				id_putMPInt_arrayB = JNIEnv.GetMethodID (class_ref, "putMPInt", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_putMPInt_arrayB, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putMPInt", "([B)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putString_arrayB;
#pragma warning disable 0169
		static Delegate GetPutString_arrayBHandler ()
		{
			if (cb_putString_arrayB == null)
				cb_putString_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutString_arrayB);
			return cb_putString_arrayB;
		}

		static void n_PutString_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.Buffer __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.PutString (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_putString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']/method[@name='putString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("putString", "([B)V", "GetPutString_arrayBHandler")]
		public virtual void PutString (byte[] p0)
		{
			if (id_putString_arrayB == IntPtr.Zero)
				id_putString_arrayB = JNIEnv.GetMethodID (class_ref, "putString", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_putString_arrayB, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putString", "([B)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putString_arrayBII;
#pragma warning disable 0169
		static Delegate GetPutString_arrayBIIHandler ()
		{
			if (cb_putString_arrayBII == null)
				cb_putString_arrayBII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_PutString_arrayBII);
			return cb_putString_arrayBII;
		}

		static void n_PutString_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Jcraft.Jsch.Buffer __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.PutString (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_putString_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']/method[@name='putString' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("putString", "([BII)V", "GetPutString_arrayBIIHandler")]
		public virtual void PutString (byte[] p0, int p1, int p2)
		{
			if (id_putString_arrayBII == IntPtr.Zero)
				id_putString_arrayBII = JNIEnv.GetMethodID (class_ref, "putString", "([BII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_putString_arrayBII, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putString", "([BII)V"), new JValue (native_p0), new JValue (p1), new JValue (p2));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Buffer __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_reset);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
		}

		static Delegate cb_shift;
#pragma warning disable 0169
		static Delegate GetShiftHandler ()
		{
			if (cb_shift == null)
				cb_shift = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Shift);
			return cb_shift;
		}

		static void n_Shift (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.Buffer __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shift ();
		}
#pragma warning restore 0169

		static IntPtr id_shift;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Buffer']/method[@name='shift' and count(parameter)=0]"
		[Register ("shift", "()V", "GetShiftHandler")]
		public virtual void Shift ()
		{
			if (id_shift == IntPtr.Zero)
				id_shift = JNIEnv.GetMethodID (class_ref, "shift", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_shift);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shift", "()V"));
		}

	}
}

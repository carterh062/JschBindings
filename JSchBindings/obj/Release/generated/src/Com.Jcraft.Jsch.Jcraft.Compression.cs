using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch.Jcraft {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch.jcraft']/class[@name='Compression']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/jcraft/Compression", DoNotGenerateAcw=true)]
	public partial class Compression : global::Java.Lang.Object, global::Com.Jcraft.Jsch.ICompression {


		public static class InterfaceConsts {

			// The following are fields from: com.jcraft.jsch.Compression

			// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Compression']/field[@name='DEFLATER']"
			[Register ("DEFLATER")]
			public const int Deflater = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Compression']/field[@name='INFLATER']"
			[Register ("INFLATER")]
			public const int Inflater = (int) 0;
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/jcraft/Compression", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Compression); }
		}

		protected Compression (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch.jcraft']/class[@name='Compression']/constructor[@name='Compression' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Compression () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Compression)) {
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

		static Delegate cb_compress_arrayBIarrayI;
#pragma warning disable 0169
		static Delegate GetCompress_arrayBIarrayIHandler ()
		{
			if (cb_compress_arrayBIarrayI == null)
				cb_compress_arrayBIarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_Compress_arrayBIarrayI);
			return cb_compress_arrayBIarrayI;
		}

		static IntPtr n_Compress_arrayBIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Jcraft.Jsch.Jcraft.Compression __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jcraft.Compression> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.NewArray (__this.Compress (p0, p1, p2));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compress_arrayBIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jcraft']/class[@name='Compression']/method[@name='compress' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("compress", "([BI[I)[B", "GetCompress_arrayBIarrayIHandler")]
		public virtual byte[] Compress (byte[] p0, int p1, int[] p2)
		{
			if (id_compress_arrayBIarrayI == IntPtr.Zero)
				id_compress_arrayBIarrayI = JNIEnv.GetMethodID (class_ref, "compress", "([BI[I)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);

			byte[] __ret;
			if (GetType () == ThresholdType)
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_compress_arrayBIarrayI, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compress", "([BI[I)[B"), new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate cb_init_II;
#pragma warning disable 0169
		static Delegate GetInit_IIHandler ()
		{
			if (cb_init_II == null)
				cb_init_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_Init_II);
			return cb_init_II;
		}

		static void n_Init_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Jcraft.Jsch.Jcraft.Compression __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jcraft.Compression> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_init_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jcraft']/class[@name='Compression']/method[@name='init' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("init", "(II)V", "GetInit_IIHandler")]
		public virtual void Init (int p0, int p1)
		{
			if (id_init_II == IntPtr.Zero)
				id_init_II = JNIEnv.GetMethodID (class_ref, "init", "(II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_init_II, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(II)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_uncompress_arrayBIarrayI;
#pragma warning disable 0169
		static Delegate GetUncompress_arrayBIarrayIHandler ()
		{
			if (cb_uncompress_arrayBIarrayI == null)
				cb_uncompress_arrayBIarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_Uncompress_arrayBIarrayI);
			return cb_uncompress_arrayBIarrayI;
		}

		static IntPtr n_Uncompress_arrayBIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Jcraft.Jsch.Jcraft.Compression __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.Jcraft.Compression> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.NewArray (__this.Uncompress (p0, p1, p2));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_uncompress_arrayBIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch.jcraft']/class[@name='Compression']/method[@name='uncompress' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("uncompress", "([BI[I)[B", "GetUncompress_arrayBIarrayIHandler")]
		public virtual byte[] Uncompress (byte[] p0, int p1, int[] p2)
		{
			if (id_uncompress_arrayBIarrayI == IntPtr.Zero)
				id_uncompress_arrayBIarrayI = JNIEnv.GetMethodID (class_ref, "uncompress", "([BI[I)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);

			byte[] __ret;
			if (GetType () == ThresholdType)
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_uncompress_arrayBIarrayI, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "uncompress", "([BI[I)[B"), new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

	}
}

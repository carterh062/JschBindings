using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	[Register ("com/jcraft/jsch/Compression")]
	public abstract class Compression {

		internal Compression ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Compression']/field[@name='DEFLATER']"
		[Register ("DEFLATER")]
		public const int Deflater = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Compression']/field[@name='INFLATER']"
		[Register ("INFLATER")]
		public const int Inflater = (int) 0;
	}

	[System.Obsolete ("Use the 'Compression' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class CompressionConsts : Compression {

		private CompressionConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Compression']"
	[Register ("com/jcraft/jsch/Compression", "", "Com.Jcraft.Jsch.ICompressionInvoker")]
	public partial interface ICompression : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Compression']/method[@name='compress' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("compress", "([BI[I)[B", "GetCompress_arrayBIarrayIHandler:Com.Jcraft.Jsch.ICompressionInvoker, JSchBindings")]
		byte[] Compress (byte[] p0, int p1, int[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Compression']/method[@name='init' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("init", "(II)V", "GetInit_IIHandler:Com.Jcraft.Jsch.ICompressionInvoker, JSchBindings")]
		void Init (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='Compression']/method[@name='uncompress' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("uncompress", "([BI[I)[B", "GetUncompress_arrayBIarrayIHandler:Com.Jcraft.Jsch.ICompressionInvoker, JSchBindings")]
		byte[] Uncompress (byte[] p0, int p1, int[] p2);

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/Compression", DoNotGenerateAcw=true)]
	internal class ICompressionInvoker : global::Java.Lang.Object, ICompression {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jcraft/jsch/Compression");
		IntPtr class_ref;

		public static ICompression GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICompression> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jcraft.jsch.Compression"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICompressionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ICompressionInvoker); }
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
			global::Com.Jcraft.Jsch.ICompression __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ICompression> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		IntPtr id_compress_arrayBIarrayI;
		public byte[] Compress (byte[] p0, int p1, int[] p2)
		{
			if (id_compress_arrayBIarrayI == IntPtr.Zero)
				id_compress_arrayBIarrayI = JNIEnv.GetMethodID (class_ref, "compress", "([BI[I)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_compress_arrayBIarrayI, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Jcraft.Jsch.ICompression __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ICompression> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_init_II;
		public void Init (int p0, int p1)
		{
			if (id_init_II == IntPtr.Zero)
				id_init_II = JNIEnv.GetMethodID (class_ref, "init", "(II)V");
			JNIEnv.CallVoidMethod (Handle, id_init_II, new JValue (p0), new JValue (p1));
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
			global::Com.Jcraft.Jsch.ICompression __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ICompression> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		IntPtr id_uncompress_arrayBIarrayI;
		public byte[] Uncompress (byte[] p0, int p1, int[] p2)
		{
			if (id_uncompress_arrayBIarrayI == IntPtr.Zero)
				id_uncompress_arrayBIarrayI = JNIEnv.GetMethodID (class_ref, "uncompress", "([BI[I)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_uncompress_arrayBIarrayI, new JValue (native_p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef, typeof (byte));
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

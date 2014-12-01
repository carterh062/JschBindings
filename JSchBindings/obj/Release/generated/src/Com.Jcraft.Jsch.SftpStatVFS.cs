using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpStatVFS']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/SftpStatVFS", DoNotGenerateAcw=true)]
	public partial class SftpStatVFS : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/SftpStatVFS", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SftpStatVFS); }
		}

		protected SftpStatVFS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAvail;
#pragma warning disable 0169
		static Delegate GetGetAvailHandler ()
		{
			if (cb_getAvail == null)
				cb_getAvail = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAvail);
			return cb_getAvail;
		}

		static long n_GetAvail (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpStatVFS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpStatVFS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Avail;
		}
#pragma warning restore 0169

		static IntPtr id_getAvail;
		public virtual long Avail {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpStatVFS']/method[@name='getAvail' and count(parameter)=0]"
			[Register ("getAvail", "()J", "GetGetAvailHandler")]
			get {
				if (id_getAvail == IntPtr.Zero)
					id_getAvail = JNIEnv.GetMethodID (class_ref, "getAvail", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getAvail);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAvail", "()J"));
			}
		}

		static Delegate cb_getAvailBlocks;
#pragma warning disable 0169
		static Delegate GetGetAvailBlocksHandler ()
		{
			if (cb_getAvailBlocks == null)
				cb_getAvailBlocks = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAvailBlocks);
			return cb_getAvailBlocks;
		}

		static long n_GetAvailBlocks (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpStatVFS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpStatVFS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AvailBlocks;
		}
#pragma warning restore 0169

		static IntPtr id_getAvailBlocks;
		public virtual long AvailBlocks {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpStatVFS']/method[@name='getAvailBlocks' and count(parameter)=0]"
			[Register ("getAvailBlocks", "()J", "GetGetAvailBlocksHandler")]
			get {
				if (id_getAvailBlocks == IntPtr.Zero)
					id_getAvailBlocks = JNIEnv.GetMethodID (class_ref, "getAvailBlocks", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getAvailBlocks);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAvailBlocks", "()J"));
			}
		}

		static Delegate cb_getAvailForNonRoot;
#pragma warning disable 0169
		static Delegate GetGetAvailForNonRootHandler ()
		{
			if (cb_getAvailForNonRoot == null)
				cb_getAvailForNonRoot = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAvailForNonRoot);
			return cb_getAvailForNonRoot;
		}

		static long n_GetAvailForNonRoot (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpStatVFS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpStatVFS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AvailForNonRoot;
		}
#pragma warning restore 0169

		static IntPtr id_getAvailForNonRoot;
		public virtual long AvailForNonRoot {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpStatVFS']/method[@name='getAvailForNonRoot' and count(parameter)=0]"
			[Register ("getAvailForNonRoot", "()J", "GetGetAvailForNonRootHandler")]
			get {
				if (id_getAvailForNonRoot == IntPtr.Zero)
					id_getAvailForNonRoot = JNIEnv.GetMethodID (class_ref, "getAvailForNonRoot", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getAvailForNonRoot);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAvailForNonRoot", "()J"));
			}
		}

		static Delegate cb_getAvailINodes;
#pragma warning disable 0169
		static Delegate GetGetAvailINodesHandler ()
		{
			if (cb_getAvailINodes == null)
				cb_getAvailINodes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAvailINodes);
			return cb_getAvailINodes;
		}

		static long n_GetAvailINodes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpStatVFS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpStatVFS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AvailINodes;
		}
#pragma warning restore 0169

		static IntPtr id_getAvailINodes;
		public virtual long AvailINodes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpStatVFS']/method[@name='getAvailINodes' and count(parameter)=0]"
			[Register ("getAvailINodes", "()J", "GetGetAvailINodesHandler")]
			get {
				if (id_getAvailINodes == IntPtr.Zero)
					id_getAvailINodes = JNIEnv.GetMethodID (class_ref, "getAvailINodes", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getAvailINodes);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAvailINodes", "()J"));
			}
		}

		static Delegate cb_getBlockSize;
#pragma warning disable 0169
		static Delegate GetGetBlockSizeHandler ()
		{
			if (cb_getBlockSize == null)
				cb_getBlockSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetBlockSize);
			return cb_getBlockSize;
		}

		static long n_GetBlockSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpStatVFS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpStatVFS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BlockSize;
		}
#pragma warning restore 0169

		static IntPtr id_getBlockSize;
		public virtual long BlockSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpStatVFS']/method[@name='getBlockSize' and count(parameter)=0]"
			[Register ("getBlockSize", "()J", "GetGetBlockSizeHandler")]
			get {
				if (id_getBlockSize == IntPtr.Zero)
					id_getBlockSize = JNIEnv.GetMethodID (class_ref, "getBlockSize", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getBlockSize);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBlockSize", "()J"));
			}
		}

		static Delegate cb_getBlocks;
#pragma warning disable 0169
		static Delegate GetGetBlocksHandler ()
		{
			if (cb_getBlocks == null)
				cb_getBlocks = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetBlocks);
			return cb_getBlocks;
		}

		static long n_GetBlocks (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpStatVFS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpStatVFS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Blocks;
		}
#pragma warning restore 0169

		static IntPtr id_getBlocks;
		public virtual long Blocks {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpStatVFS']/method[@name='getBlocks' and count(parameter)=0]"
			[Register ("getBlocks", "()J", "GetGetBlocksHandler")]
			get {
				if (id_getBlocks == IntPtr.Zero)
					id_getBlocks = JNIEnv.GetMethodID (class_ref, "getBlocks", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getBlocks);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBlocks", "()J"));
			}
		}

		static Delegate cb_getCapacity;
#pragma warning disable 0169
		static Delegate GetGetCapacityHandler ()
		{
			if (cb_getCapacity == null)
				cb_getCapacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCapacity);
			return cb_getCapacity;
		}

		static int n_GetCapacity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpStatVFS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpStatVFS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Capacity;
		}
#pragma warning restore 0169

		static IntPtr id_getCapacity;
		public virtual int Capacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpStatVFS']/method[@name='getCapacity' and count(parameter)=0]"
			[Register ("getCapacity", "()I", "GetGetCapacityHandler")]
			get {
				if (id_getCapacity == IntPtr.Zero)
					id_getCapacity = JNIEnv.GetMethodID (class_ref, "getCapacity", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getCapacity);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCapacity", "()I"));
			}
		}

		static Delegate cb_getFileSystemID;
#pragma warning disable 0169
		static Delegate GetGetFileSystemIDHandler ()
		{
			if (cb_getFileSystemID == null)
				cb_getFileSystemID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetFileSystemID);
			return cb_getFileSystemID;
		}

		static long n_GetFileSystemID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpStatVFS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpStatVFS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FileSystemID;
		}
#pragma warning restore 0169

		static IntPtr id_getFileSystemID;
		public virtual long FileSystemID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpStatVFS']/method[@name='getFileSystemID' and count(parameter)=0]"
			[Register ("getFileSystemID", "()J", "GetGetFileSystemIDHandler")]
			get {
				if (id_getFileSystemID == IntPtr.Zero)
					id_getFileSystemID = JNIEnv.GetMethodID (class_ref, "getFileSystemID", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getFileSystemID);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileSystemID", "()J"));
			}
		}

		static Delegate cb_getFragmentSize;
#pragma warning disable 0169
		static Delegate GetGetFragmentSizeHandler ()
		{
			if (cb_getFragmentSize == null)
				cb_getFragmentSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetFragmentSize);
			return cb_getFragmentSize;
		}

		static long n_GetFragmentSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpStatVFS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpStatVFS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FragmentSize;
		}
#pragma warning restore 0169

		static IntPtr id_getFragmentSize;
		public virtual long FragmentSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpStatVFS']/method[@name='getFragmentSize' and count(parameter)=0]"
			[Register ("getFragmentSize", "()J", "GetGetFragmentSizeHandler")]
			get {
				if (id_getFragmentSize == IntPtr.Zero)
					id_getFragmentSize = JNIEnv.GetMethodID (class_ref, "getFragmentSize", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getFragmentSize);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFragmentSize", "()J"));
			}
		}

		static Delegate cb_getFreeBlocks;
#pragma warning disable 0169
		static Delegate GetGetFreeBlocksHandler ()
		{
			if (cb_getFreeBlocks == null)
				cb_getFreeBlocks = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetFreeBlocks);
			return cb_getFreeBlocks;
		}

		static long n_GetFreeBlocks (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpStatVFS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpStatVFS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FreeBlocks;
		}
#pragma warning restore 0169

		static IntPtr id_getFreeBlocks;
		public virtual long FreeBlocks {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpStatVFS']/method[@name='getFreeBlocks' and count(parameter)=0]"
			[Register ("getFreeBlocks", "()J", "GetGetFreeBlocksHandler")]
			get {
				if (id_getFreeBlocks == IntPtr.Zero)
					id_getFreeBlocks = JNIEnv.GetMethodID (class_ref, "getFreeBlocks", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getFreeBlocks);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFreeBlocks", "()J"));
			}
		}

		static Delegate cb_getFreeINodes;
#pragma warning disable 0169
		static Delegate GetGetFreeINodesHandler ()
		{
			if (cb_getFreeINodes == null)
				cb_getFreeINodes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetFreeINodes);
			return cb_getFreeINodes;
		}

		static long n_GetFreeINodes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpStatVFS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpStatVFS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FreeINodes;
		}
#pragma warning restore 0169

		static IntPtr id_getFreeINodes;
		public virtual long FreeINodes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpStatVFS']/method[@name='getFreeINodes' and count(parameter)=0]"
			[Register ("getFreeINodes", "()J", "GetGetFreeINodesHandler")]
			get {
				if (id_getFreeINodes == IntPtr.Zero)
					id_getFreeINodes = JNIEnv.GetMethodID (class_ref, "getFreeINodes", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getFreeINodes);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFreeINodes", "()J"));
			}
		}

		static Delegate cb_getINodes;
#pragma warning disable 0169
		static Delegate GetGetINodesHandler ()
		{
			if (cb_getINodes == null)
				cb_getINodes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetINodes);
			return cb_getINodes;
		}

		static long n_GetINodes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpStatVFS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpStatVFS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.INodes;
		}
#pragma warning restore 0169

		static IntPtr id_getINodes;
		public virtual long INodes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpStatVFS']/method[@name='getINodes' and count(parameter)=0]"
			[Register ("getINodes", "()J", "GetGetINodesHandler")]
			get {
				if (id_getINodes == IntPtr.Zero)
					id_getINodes = JNIEnv.GetMethodID (class_ref, "getINodes", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getINodes);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getINodes", "()J"));
			}
		}

		static Delegate cb_getMaximumFilenameLength;
#pragma warning disable 0169
		static Delegate GetGetMaximumFilenameLengthHandler ()
		{
			if (cb_getMaximumFilenameLength == null)
				cb_getMaximumFilenameLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMaximumFilenameLength);
			return cb_getMaximumFilenameLength;
		}

		static long n_GetMaximumFilenameLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpStatVFS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpStatVFS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaximumFilenameLength;
		}
#pragma warning restore 0169

		static IntPtr id_getMaximumFilenameLength;
		public virtual long MaximumFilenameLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpStatVFS']/method[@name='getMaximumFilenameLength' and count(parameter)=0]"
			[Register ("getMaximumFilenameLength", "()J", "GetGetMaximumFilenameLengthHandler")]
			get {
				if (id_getMaximumFilenameLength == IntPtr.Zero)
					id_getMaximumFilenameLength = JNIEnv.GetMethodID (class_ref, "getMaximumFilenameLength", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getMaximumFilenameLength);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaximumFilenameLength", "()J"));
			}
		}

		static Delegate cb_getMountFlag;
#pragma warning disable 0169
		static Delegate GetGetMountFlagHandler ()
		{
			if (cb_getMountFlag == null)
				cb_getMountFlag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMountFlag);
			return cb_getMountFlag;
		}

		static long n_GetMountFlag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpStatVFS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpStatVFS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MountFlag;
		}
#pragma warning restore 0169

		static IntPtr id_getMountFlag;
		public virtual long MountFlag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpStatVFS']/method[@name='getMountFlag' and count(parameter)=0]"
			[Register ("getMountFlag", "()J", "GetGetMountFlagHandler")]
			get {
				if (id_getMountFlag == IntPtr.Zero)
					id_getMountFlag = JNIEnv.GetMethodID (class_ref, "getMountFlag", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getMountFlag);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMountFlag", "()J"));
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetSize);
			return cb_getSize;
		}

		static long n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpStatVFS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpStatVFS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		static IntPtr id_getSize;
		public virtual long Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpStatVFS']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()J", "GetGetSizeHandler")]
			get {
				if (id_getSize == IntPtr.Zero)
					id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getSize);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSize", "()J"));
			}
		}

		static Delegate cb_getUsed;
#pragma warning disable 0169
		static Delegate GetGetUsedHandler ()
		{
			if (cb_getUsed == null)
				cb_getUsed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetUsed);
			return cb_getUsed;
		}

		static long n_GetUsed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpStatVFS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpStatVFS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Used;
		}
#pragma warning restore 0169

		static IntPtr id_getUsed;
		public virtual long Used {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpStatVFS']/method[@name='getUsed' and count(parameter)=0]"
			[Register ("getUsed", "()J", "GetGetUsedHandler")]
			get {
				if (id_getUsed == IntPtr.Zero)
					id_getUsed = JNIEnv.GetMethodID (class_ref, "getUsed", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getUsed);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUsed", "()J"));
			}
		}

	}
}

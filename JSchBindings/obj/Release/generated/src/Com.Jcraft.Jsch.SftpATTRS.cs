using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/SftpATTRS", DoNotGenerateAcw=true)]
	public partial class SftpATTRS : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/field[@name='SSH_FILEXFER_ATTR_ACMODTIME']"
		[Register ("SSH_FILEXFER_ATTR_ACMODTIME")]
		public const int SshFilexferAttrAcmodtime = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/field[@name='SSH_FILEXFER_ATTR_EXTENDED']"
		[Register ("SSH_FILEXFER_ATTR_EXTENDED")]
		public const int SshFilexferAttrExtended = (int) -2147483648;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/field[@name='SSH_FILEXFER_ATTR_PERMISSIONS']"
		[Register ("SSH_FILEXFER_ATTR_PERMISSIONS")]
		public const int SshFilexferAttrPermissions = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/field[@name='SSH_FILEXFER_ATTR_SIZE']"
		[Register ("SSH_FILEXFER_ATTR_SIZE")]
		public const int SshFilexferAttrSize = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/field[@name='SSH_FILEXFER_ATTR_UIDGID']"
		[Register ("SSH_FILEXFER_ATTR_UIDGID")]
		public const int SshFilexferAttrUidgid = (int) 2;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/SftpATTRS", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SftpATTRS); }
		}

		protected SftpATTRS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getATime;
#pragma warning disable 0169
		static Delegate GetGetATimeHandler ()
		{
			if (cb_getATime == null)
				cb_getATime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetATime);
			return cb_getATime;
		}

		static int n_GetATime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpATTRS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ATime;
		}
#pragma warning restore 0169

		static IntPtr id_getATime;
		public virtual int ATime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/method[@name='getATime' and count(parameter)=0]"
			[Register ("getATime", "()I", "GetGetATimeHandler")]
			get {
				if (id_getATime == IntPtr.Zero)
					id_getATime = JNIEnv.GetMethodID (class_ref, "getATime", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getATime);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getATime", "()I"));
			}
		}

		static Delegate cb_getAtimeString;
#pragma warning disable 0169
		static Delegate GetGetAtimeStringHandler ()
		{
			if (cb_getAtimeString == null)
				cb_getAtimeString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAtimeString);
			return cb_getAtimeString;
		}

		static IntPtr n_GetAtimeString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpATTRS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AtimeString);
		}
#pragma warning restore 0169

		static IntPtr id_getAtimeString;
		public virtual string AtimeString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/method[@name='getAtimeString' and count(parameter)=0]"
			[Register ("getAtimeString", "()Ljava/lang/String;", "GetGetAtimeStringHandler")]
			get {
				if (id_getAtimeString == IntPtr.Zero)
					id_getAtimeString = JNIEnv.GetMethodID (class_ref, "getAtimeString", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAtimeString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAtimeString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getFlags;
#pragma warning disable 0169
		static Delegate GetGetFlagsHandler ()
		{
			if (cb_getFlags == null)
				cb_getFlags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFlags);
			return cb_getFlags;
		}

		static int n_GetFlags (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpATTRS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Flags;
		}
#pragma warning restore 0169

		static IntPtr id_getFlags;
		public virtual int Flags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/method[@name='getFlags' and count(parameter)=0]"
			[Register ("getFlags", "()I", "GetGetFlagsHandler")]
			get {
				if (id_getFlags == IntPtr.Zero)
					id_getFlags = JNIEnv.GetMethodID (class_ref, "getFlags", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getFlags);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFlags", "()I"));
			}
		}

		static Delegate cb_getGId;
#pragma warning disable 0169
		static Delegate GetGetGIdHandler ()
		{
			if (cb_getGId == null)
				cb_getGId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetGId);
			return cb_getGId;
		}

		static int n_GetGId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpATTRS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GId;
		}
#pragma warning restore 0169

		static IntPtr id_getGId;
		public virtual int GId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/method[@name='getGId' and count(parameter)=0]"
			[Register ("getGId", "()I", "GetGetGIdHandler")]
			get {
				if (id_getGId == IntPtr.Zero)
					id_getGId = JNIEnv.GetMethodID (class_ref, "getGId", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getGId);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGId", "()I"));
			}
		}

		static Delegate cb_isBlk;
#pragma warning disable 0169
		static Delegate GetIsBlkHandler ()
		{
			if (cb_isBlk == null)
				cb_isBlk = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBlk);
			return cb_isBlk;
		}

		static bool n_IsBlk (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpATTRS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBlk;
		}
#pragma warning restore 0169

		static IntPtr id_isBlk;
		public virtual bool IsBlk {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/method[@name='isBlk' and count(parameter)=0]"
			[Register ("isBlk", "()Z", "GetIsBlkHandler")]
			get {
				if (id_isBlk == IntPtr.Zero)
					id_isBlk = JNIEnv.GetMethodID (class_ref, "isBlk", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isBlk);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBlk", "()Z"));
			}
		}

		static Delegate cb_isChr;
#pragma warning disable 0169
		static Delegate GetIsChrHandler ()
		{
			if (cb_isChr == null)
				cb_isChr = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsChr);
			return cb_isChr;
		}

		static bool n_IsChr (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpATTRS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsChr;
		}
#pragma warning restore 0169

		static IntPtr id_isChr;
		public virtual bool IsChr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/method[@name='isChr' and count(parameter)=0]"
			[Register ("isChr", "()Z", "GetIsChrHandler")]
			get {
				if (id_isChr == IntPtr.Zero)
					id_isChr = JNIEnv.GetMethodID (class_ref, "isChr", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isChr);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isChr", "()Z"));
			}
		}

		static Delegate cb_isDir;
#pragma warning disable 0169
		static Delegate GetIsDirHandler ()
		{
			if (cb_isDir == null)
				cb_isDir = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDir);
			return cb_isDir;
		}

		static bool n_IsDir (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpATTRS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDir;
		}
#pragma warning restore 0169

		static IntPtr id_isDir;
		public virtual bool IsDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/method[@name='isDir' and count(parameter)=0]"
			[Register ("isDir", "()Z", "GetIsDirHandler")]
			get {
				if (id_isDir == IntPtr.Zero)
					id_isDir = JNIEnv.GetMethodID (class_ref, "isDir", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isDir);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDir", "()Z"));
			}
		}

		static Delegate cb_isFifo;
#pragma warning disable 0169
		static Delegate GetIsFifoHandler ()
		{
			if (cb_isFifo == null)
				cb_isFifo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFifo);
			return cb_isFifo;
		}

		static bool n_IsFifo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpATTRS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFifo;
		}
#pragma warning restore 0169

		static IntPtr id_isFifo;
		public virtual bool IsFifo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/method[@name='isFifo' and count(parameter)=0]"
			[Register ("isFifo", "()Z", "GetIsFifoHandler")]
			get {
				if (id_isFifo == IntPtr.Zero)
					id_isFifo = JNIEnv.GetMethodID (class_ref, "isFifo", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isFifo);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFifo", "()Z"));
			}
		}

		static Delegate cb_isLink;
#pragma warning disable 0169
		static Delegate GetIsLinkHandler ()
		{
			if (cb_isLink == null)
				cb_isLink = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLink);
			return cb_isLink;
		}

		static bool n_IsLink (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpATTRS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLink;
		}
#pragma warning restore 0169

		static IntPtr id_isLink;
		public virtual bool IsLink {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/method[@name='isLink' and count(parameter)=0]"
			[Register ("isLink", "()Z", "GetIsLinkHandler")]
			get {
				if (id_isLink == IntPtr.Zero)
					id_isLink = JNIEnv.GetMethodID (class_ref, "isLink", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isLink);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLink", "()Z"));
			}
		}

		static Delegate cb_isReg;
#pragma warning disable 0169
		static Delegate GetIsRegHandler ()
		{
			if (cb_isReg == null)
				cb_isReg = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReg);
			return cb_isReg;
		}

		static bool n_IsReg (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpATTRS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReg;
		}
#pragma warning restore 0169

		static IntPtr id_isReg;
		public virtual bool IsReg {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/method[@name='isReg' and count(parameter)=0]"
			[Register ("isReg", "()Z", "GetIsRegHandler")]
			get {
				if (id_isReg == IntPtr.Zero)
					id_isReg = JNIEnv.GetMethodID (class_ref, "isReg", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isReg);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isReg", "()Z"));
			}
		}

		static Delegate cb_isSock;
#pragma warning disable 0169
		static Delegate GetIsSockHandler ()
		{
			if (cb_isSock == null)
				cb_isSock = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSock);
			return cb_isSock;
		}

		static bool n_IsSock (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpATTRS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSock;
		}
#pragma warning restore 0169

		static IntPtr id_isSock;
		public virtual bool IsSock {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/method[@name='isSock' and count(parameter)=0]"
			[Register ("isSock", "()Z", "GetIsSockHandler")]
			get {
				if (id_isSock == IntPtr.Zero)
					id_isSock = JNIEnv.GetMethodID (class_ref, "isSock", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isSock);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSock", "()Z"));
			}
		}

		static Delegate cb_getMTime;
#pragma warning disable 0169
		static Delegate GetGetMTimeHandler ()
		{
			if (cb_getMTime == null)
				cb_getMTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMTime);
			return cb_getMTime;
		}

		static int n_GetMTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpATTRS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MTime;
		}
#pragma warning restore 0169

		static IntPtr id_getMTime;
		public virtual int MTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/method[@name='getMTime' and count(parameter)=0]"
			[Register ("getMTime", "()I", "GetGetMTimeHandler")]
			get {
				if (id_getMTime == IntPtr.Zero)
					id_getMTime = JNIEnv.GetMethodID (class_ref, "getMTime", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getMTime);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMTime", "()I"));
			}
		}

		static Delegate cb_getMtimeString;
#pragma warning disable 0169
		static Delegate GetGetMtimeStringHandler ()
		{
			if (cb_getMtimeString == null)
				cb_getMtimeString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMtimeString);
			return cb_getMtimeString;
		}

		static IntPtr n_GetMtimeString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpATTRS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MtimeString);
		}
#pragma warning restore 0169

		static IntPtr id_getMtimeString;
		public virtual string MtimeString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/method[@name='getMtimeString' and count(parameter)=0]"
			[Register ("getMtimeString", "()Ljava/lang/String;", "GetGetMtimeStringHandler")]
			get {
				if (id_getMtimeString == IntPtr.Zero)
					id_getMtimeString = JNIEnv.GetMethodID (class_ref, "getMtimeString", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMtimeString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMtimeString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPermissions;
#pragma warning disable 0169
		static Delegate GetGetPermissionsHandler ()
		{
			if (cb_getPermissions == null)
				cb_getPermissions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPermissions);
			return cb_getPermissions;
		}

		static int n_GetPermissions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpATTRS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Permissions;
		}
#pragma warning restore 0169

		static IntPtr id_getPermissions;
		public virtual int Permissions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/method[@name='getPermissions' and count(parameter)=0]"
			[Register ("getPermissions", "()I", "GetGetPermissionsHandler")]
			get {
				if (id_getPermissions == IntPtr.Zero)
					id_getPermissions = JNIEnv.GetMethodID (class_ref, "getPermissions", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getPermissions);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPermissions", "()I"));
			}
		}

		static Delegate cb_getPermissionsString;
#pragma warning disable 0169
		static Delegate GetGetPermissionsStringHandler ()
		{
			if (cb_getPermissionsString == null)
				cb_getPermissionsString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPermissionsString);
			return cb_getPermissionsString;
		}

		static IntPtr n_GetPermissionsString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpATTRS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PermissionsString);
		}
#pragma warning restore 0169

		static IntPtr id_getPermissionsString;
		public virtual string PermissionsString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/method[@name='getPermissionsString' and count(parameter)=0]"
			[Register ("getPermissionsString", "()Ljava/lang/String;", "GetGetPermissionsStringHandler")]
			get {
				if (id_getPermissionsString == IntPtr.Zero)
					id_getPermissionsString = JNIEnv.GetMethodID (class_ref, "getPermissionsString", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPermissionsString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPermissionsString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Jcraft.Jsch.SftpATTRS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		static IntPtr id_getSize;
		public virtual long Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/method[@name='getSize' and count(parameter)=0]"
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

		static Delegate cb_getUId;
#pragma warning disable 0169
		static Delegate GetGetUIdHandler ()
		{
			if (cb_getUId == null)
				cb_getUId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUId);
			return cb_getUId;
		}

		static int n_GetUId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpATTRS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UId;
		}
#pragma warning restore 0169

		static IntPtr id_getUId;
		public virtual int UId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/method[@name='getUId' and count(parameter)=0]"
			[Register ("getUId", "()I", "GetGetUIdHandler")]
			get {
				if (id_getUId == IntPtr.Zero)
					id_getUId = JNIEnv.GetMethodID (class_ref, "getUId", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getUId);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUId", "()I"));
			}
		}

		static Delegate cb_getExtended;
#pragma warning disable 0169
		static Delegate GetGetExtendedHandler ()
		{
			if (cb_getExtended == null)
				cb_getExtended = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtended);
			return cb_getExtended;
		}

		static IntPtr n_GetExtended (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.SftpATTRS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetExtended ());
		}
#pragma warning restore 0169

		static IntPtr id_getExtended;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/method[@name='getExtended' and count(parameter)=0]"
		[Register ("getExtended", "()[Ljava/lang/String;", "GetGetExtendedHandler")]
		public virtual string[] GetExtended ()
		{
			if (id_getExtended == IntPtr.Zero)
				id_getExtended = JNIEnv.GetMethodID (class_ref, "getExtended", "()[Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getExtended), JniHandleOwnership.TransferLocalRef, typeof (string));
			else
				return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExtended", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static Delegate cb_setACMODTIME_II;
#pragma warning disable 0169
		static Delegate GetSetACMODTIME_IIHandler ()
		{
			if (cb_setACMODTIME_II == null)
				cb_setACMODTIME_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetACMODTIME_II);
			return cb_setACMODTIME_II;
		}

		static void n_SetACMODTIME_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Jcraft.Jsch.SftpATTRS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetACMODTIME (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setACMODTIME_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/method[@name='setACMODTIME' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setACMODTIME", "(II)V", "GetSetACMODTIME_IIHandler")]
		public virtual void SetACMODTIME (int p0, int p1)
		{
			if (id_setACMODTIME_II == IntPtr.Zero)
				id_setACMODTIME_II = JNIEnv.GetMethodID (class_ref, "setACMODTIME", "(II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setACMODTIME_II, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setACMODTIME", "(II)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setPERMISSIONS_I;
#pragma warning disable 0169
		static Delegate GetSetPERMISSIONS_IHandler ()
		{
			if (cb_setPERMISSIONS_I == null)
				cb_setPERMISSIONS_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPERMISSIONS_I);
			return cb_setPERMISSIONS_I;
		}

		static void n_SetPERMISSIONS_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jcraft.Jsch.SftpATTRS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPERMISSIONS (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPERMISSIONS_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/method[@name='setPERMISSIONS' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPERMISSIONS", "(I)V", "GetSetPERMISSIONS_IHandler")]
		public virtual void SetPERMISSIONS (int p0)
		{
			if (id_setPERMISSIONS_I == IntPtr.Zero)
				id_setPERMISSIONS_I = JNIEnv.GetMethodID (class_ref, "setPERMISSIONS", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPERMISSIONS_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPERMISSIONS", "(I)V"), new JValue (p0));
		}

		static Delegate cb_setSIZE_J;
#pragma warning disable 0169
		static Delegate GetSetSIZE_JHandler ()
		{
			if (cb_setSIZE_J == null)
				cb_setSIZE_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetSIZE_J);
			return cb_setSIZE_J;
		}

		static void n_SetSIZE_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Jcraft.Jsch.SftpATTRS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSIZE (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSIZE_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/method[@name='setSIZE' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setSIZE", "(J)V", "GetSetSIZE_JHandler")]
		public virtual void SetSIZE (long p0)
		{
			if (id_setSIZE_J == IntPtr.Zero)
				id_setSIZE_J = JNIEnv.GetMethodID (class_ref, "setSIZE", "(J)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setSIZE_J, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSIZE", "(J)V"), new JValue (p0));
		}

		static Delegate cb_setUIDGID_II;
#pragma warning disable 0169
		static Delegate GetSetUIDGID_IIHandler ()
		{
			if (cb_setUIDGID_II == null)
				cb_setUIDGID_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetUIDGID_II);
			return cb_setUIDGID_II;
		}

		static void n_SetUIDGID_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Jcraft.Jsch.SftpATTRS __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUIDGID (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setUIDGID_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='SftpATTRS']/method[@name='setUIDGID' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setUIDGID", "(II)V", "GetSetUIDGID_IIHandler")]
		public virtual void SetUIDGID (int p0, int p1)
		{
			if (id_setUIDGID_II == IntPtr.Zero)
				id_setUIDGID_II = JNIEnv.GetMethodID (class_ref, "setUIDGID", "(II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setUIDGID_II, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUIDGID", "(II)V"), new JValue (p0), new JValue (p1));
		}

	}
}

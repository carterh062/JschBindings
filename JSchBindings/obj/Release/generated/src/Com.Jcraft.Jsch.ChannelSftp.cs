using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/ChannelSftp", DoNotGenerateAcw=true)]
	public partial class ChannelSftp : global::Com.Jcraft.Jsch.ChannelSession {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/field[@name='APPEND']"
		[Register ("APPEND")]
		public const int Append = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/field[@name='OVERWRITE']"
		[Register ("OVERWRITE")]
		public const int Overwrite = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/field[@name='RESUME']"
		[Register ("RESUME")]
		public const int Resume = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/field[@name='SSH_FX_BAD_MESSAGE']"
		[Register ("SSH_FX_BAD_MESSAGE")]
		public const int SshFxBadMessage = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/field[@name='SSH_FX_CONNECTION_LOST']"
		[Register ("SSH_FX_CONNECTION_LOST")]
		public const int SshFxConnectionLost = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/field[@name='SSH_FX_EOF']"
		[Register ("SSH_FX_EOF")]
		public const int SshFxEof = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/field[@name='SSH_FX_FAILURE']"
		[Register ("SSH_FX_FAILURE")]
		public const int SshFxFailure = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/field[@name='SSH_FX_NO_CONNECTION']"
		[Register ("SSH_FX_NO_CONNECTION")]
		public const int SshFxNoConnection = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/field[@name='SSH_FX_NO_SUCH_FILE']"
		[Register ("SSH_FX_NO_SUCH_FILE")]
		public const int SshFxNoSuchFile = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/field[@name='SSH_FX_OK']"
		[Register ("SSH_FX_OK")]
		public const int SshFxOk = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/field[@name='SSH_FX_OP_UNSUPPORTED']"
		[Register ("SSH_FX_OP_UNSUPPORTED")]
		public const int SshFxOpUnsupported = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/field[@name='SSH_FX_PERMISSION_DENIED']"
		[Register ("SSH_FX_PERMISSION_DENIED")]
		public const int SshFxPermissionDenied = (int) 3;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp.Header']"
		[global::Android.Runtime.Register ("com/jcraft/jsch/ChannelSftp$Header", DoNotGenerateAcw=true)]
		public partial class Header : global::Java.Lang.Object {

			protected Header (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp.LsEntry']"
		[global::Android.Runtime.Register ("com/jcraft/jsch/ChannelSftp$LsEntry", DoNotGenerateAcw=true)]
		public partial class LsEntry : global::Java.Lang.Object, global::Java.Lang.IComparable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/jcraft/jsch/ChannelSftp$LsEntry", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LsEntry); }
			}

			protected LsEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getAttrs;
#pragma warning disable 0169
			static Delegate GetGetAttrsHandler ()
			{
				if (cb_getAttrs == null)
					cb_getAttrs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttrs);
				return cb_getAttrs;
			}

			static IntPtr n_GetAttrs (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Jcraft.Jsch.ChannelSftp.LsEntry __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp.LsEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Attrs);
			}
#pragma warning restore 0169

			static IntPtr id_getAttrs;
			public virtual global::Com.Jcraft.Jsch.SftpATTRS Attrs {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp.LsEntry']/method[@name='getAttrs' and count(parameter)=0]"
				[Register ("getAttrs", "()Lcom/jcraft/jsch/SftpATTRS;", "GetGetAttrsHandler")]
				get {
					if (id_getAttrs == IntPtr.Zero)
						id_getAttrs = JNIEnv.GetMethodID (class_ref, "getAttrs", "()Lcom/jcraft/jsch/SftpATTRS;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (JNIEnv.CallObjectMethod  (Handle, id_getAttrs), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttrs", "()Lcom/jcraft/jsch/SftpATTRS;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getFilename;
#pragma warning disable 0169
			static Delegate GetGetFilenameHandler ()
			{
				if (cb_getFilename == null)
					cb_getFilename = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFilename);
				return cb_getFilename;
			}

			static IntPtr n_GetFilename (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Jcraft.Jsch.ChannelSftp.LsEntry __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp.LsEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Filename);
			}
#pragma warning restore 0169

			static IntPtr id_getFilename;
			public virtual string Filename {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp.LsEntry']/method[@name='getFilename' and count(parameter)=0]"
				[Register ("getFilename", "()Ljava/lang/String;", "GetGetFilenameHandler")]
				get {
					if (id_getFilename == IntPtr.Zero)
						id_getFilename = JNIEnv.GetMethodID (class_ref, "getFilename", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFilename), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFilename", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getLongname;
#pragma warning disable 0169
			static Delegate GetGetLongnameHandler ()
			{
				if (cb_getLongname == null)
					cb_getLongname = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLongname);
				return cb_getLongname;
			}

			static IntPtr n_GetLongname (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Jcraft.Jsch.ChannelSftp.LsEntry __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp.LsEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Longname);
			}
#pragma warning restore 0169

			static IntPtr id_getLongname;
			public virtual string Longname {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp.LsEntry']/method[@name='getLongname' and count(parameter)=0]"
				[Register ("getLongname", "()Ljava/lang/String;", "GetGetLongnameHandler")]
				get {
					if (id_getLongname == IntPtr.Zero)
						id_getLongname = JNIEnv.GetMethodID (class_ref, "getLongname", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLongname), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLongname", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_compareTo_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetCompareTo_Ljava_lang_Object_Handler ()
			{
				if (cb_compareTo_Ljava_lang_Object_ == null)
					cb_compareTo_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Ljava_lang_Object_);
				return cb_compareTo_Ljava_lang_Object_;
			}

			static int n_CompareTo_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Jcraft.Jsch.ChannelSftp.LsEntry __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp.LsEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.CompareTo (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_compareTo_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp.LsEntry']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
			public virtual int CompareTo (global::Java.Lang.Object p0)
			{
				if (id_compareTo_Ljava_lang_Object_ == IntPtr.Zero)
					id_compareTo_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Ljava/lang/Object;)I");

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Ljava_lang_Object_, new JValue (p0));
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Ljava/lang/Object;)I"), new JValue (p0));
				return __ret;
			}

		}

		[Register ("com/jcraft/jsch/ChannelSftp$LsEntrySelector")]
		public abstract class LsEntrySelector {

			internal LsEntrySelector ()
			{
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='ChannelSftp.LsEntrySelector']/field[@name='BREAK']"
			[Register ("BREAK")]
			public const int Break = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='ChannelSftp.LsEntrySelector']/field[@name='CONTINUE']"
			[Register ("CONTINUE")]
			public const int Continue = (int) 0;
		}

		[System.Obsolete ("Use the 'LsEntrySelector' type. This type will be removed in Mono for Android 5.0.")]
		public abstract class LsEntrySelectorConsts : LsEntrySelector {

			private LsEntrySelectorConsts ()
			{
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='ChannelSftp.LsEntrySelector']"
		[Register ("com/jcraft/jsch/ChannelSftp$LsEntrySelector", "", "Com.Jcraft.Jsch.ChannelSftp/ILsEntrySelectorInvoker")]
		public partial interface ILsEntrySelector : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='ChannelSftp.LsEntrySelector']/method[@name='select' and count(parameter)=1 and parameter[1][@type='com.jcraft.jsch.ChannelSftp.LsEntry']]"
			[Register ("select", "(Lcom/jcraft/jsch/ChannelSftp$LsEntry;)I", "GetSelect_Lcom_jcraft_jsch_ChannelSftp_LsEntry_Handler:Com.Jcraft.Jsch.ChannelSftp/ILsEntrySelectorInvoker, JSchBindings")]
			int Select (global::Com.Jcraft.Jsch.ChannelSftp.LsEntry p0);

		}

		[global::Android.Runtime.Register ("com/jcraft/jsch/ChannelSftp$LsEntrySelector", DoNotGenerateAcw=true)]
		internal class ILsEntrySelectorInvoker : global::Java.Lang.Object, ILsEntrySelector {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/jcraft/jsch/ChannelSftp$LsEntrySelector");
			IntPtr class_ref;

			public static ILsEntrySelector GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ILsEntrySelector> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.jcraft.jsch.ChannelSftp.LsEntrySelector"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ILsEntrySelectorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (ILsEntrySelectorInvoker); }
			}

			static Delegate cb_select_Lcom_jcraft_jsch_ChannelSftp_LsEntry_;
#pragma warning disable 0169
			static Delegate GetSelect_Lcom_jcraft_jsch_ChannelSftp_LsEntry_Handler ()
			{
				if (cb_select_Lcom_jcraft_jsch_ChannelSftp_LsEntry_ == null)
					cb_select_Lcom_jcraft_jsch_ChannelSftp_LsEntry_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Select_Lcom_jcraft_jsch_ChannelSftp_LsEntry_);
				return cb_select_Lcom_jcraft_jsch_ChannelSftp_LsEntry_;
			}

			static int n_Select_Lcom_jcraft_jsch_ChannelSftp_LsEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Jcraft.Jsch.ChannelSftp.ILsEntrySelector __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp.ILsEntrySelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Jcraft.Jsch.ChannelSftp.LsEntry p0 = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp.LsEntry> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.Select (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_select_Lcom_jcraft_jsch_ChannelSftp_LsEntry_;
			public int Select (global::Com.Jcraft.Jsch.ChannelSftp.LsEntry p0)
			{
				if (id_select_Lcom_jcraft_jsch_ChannelSftp_LsEntry_ == IntPtr.Zero)
					id_select_Lcom_jcraft_jsch_ChannelSftp_LsEntry_ = JNIEnv.GetMethodID (class_ref, "select", "(Lcom/jcraft/jsch/ChannelSftp$LsEntry;)I");
				int __ret = JNIEnv.CallIntMethod (Handle, id_select_Lcom_jcraft_jsch_ChannelSftp_LsEntry_, new JValue (p0));
				return __ret;
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp.RequestQueue']"
		[global::Android.Runtime.Register ("com/jcraft/jsch/ChannelSftp$RequestQueue", DoNotGenerateAcw=true)]
		public partial class RequestQueue : global::Java.Lang.Object {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp.RequestQueue.OutOfOrderException']"
			[global::Android.Runtime.Register ("com/jcraft/jsch/ChannelSftp$RequestQueue$OutOfOrderException", DoNotGenerateAcw=true)]
			public partial class OutOfOrderException : global::Java.Lang.Exception {

				protected OutOfOrderException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp.RequestQueue.Request']"
			[global::Android.Runtime.Register ("com/jcraft/jsch/ChannelSftp$RequestQueue$Request", DoNotGenerateAcw=true)]
			public partial class Request : global::Java.Lang.Object {

				protected Request (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			}

			protected RequestQueue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/ChannelSftp", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelSftp); }
		}

		protected ChannelSftp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/constructor[@name='ChannelSftp' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ChannelSftp () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ChannelSftp)) {
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

		static Delegate cb_getBulkRequests;
#pragma warning disable 0169
		static Delegate GetGetBulkRequestsHandler ()
		{
			if (cb_getBulkRequests == null)
				cb_getBulkRequests = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBulkRequests);
			return cb_getBulkRequests;
		}

		static int n_GetBulkRequests (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BulkRequests;
		}
#pragma warning restore 0169

		static Delegate cb_setBulkRequests_I;
#pragma warning disable 0169
		static Delegate GetSetBulkRequests_IHandler ()
		{
			if (cb_setBulkRequests_I == null)
				cb_setBulkRequests_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBulkRequests_I);
			return cb_setBulkRequests_I;
		}

		static void n_SetBulkRequests_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BulkRequests = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBulkRequests;
		static IntPtr id_setBulkRequests_I;
		public virtual int BulkRequests {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='getBulkRequests' and count(parameter)=0]"
			[Register ("getBulkRequests", "()I", "GetGetBulkRequestsHandler")]
			get {
				if (id_getBulkRequests == IntPtr.Zero)
					id_getBulkRequests = JNIEnv.GetMethodID (class_ref, "getBulkRequests", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getBulkRequests);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBulkRequests", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='setBulkRequests' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBulkRequests", "(I)V", "GetSetBulkRequests_IHandler")]
			set {
				if (id_setBulkRequests_I == IntPtr.Zero)
					id_setBulkRequests_I = JNIEnv.GetMethodID (class_ref, "setBulkRequests", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setBulkRequests_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBulkRequests", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getHome;
#pragma warning disable 0169
		static Delegate GetGetHomeHandler ()
		{
			if (cb_getHome == null)
				cb_getHome = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHome);
			return cb_getHome;
		}

		static IntPtr n_GetHome (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Home);
		}
#pragma warning restore 0169

		static IntPtr id_getHome;
		public virtual string Home {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='getHome' and count(parameter)=0]"
			[Register ("getHome", "()Ljava/lang/String;", "GetGetHomeHandler")]
			get {
				if (id_getHome == IntPtr.Zero)
					id_getHome = JNIEnv.GetMethodID (class_ref, "getHome", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getHome), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHome", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getServerVersion;
#pragma warning disable 0169
		static Delegate GetGetServerVersionHandler ()
		{
			if (cb_getServerVersion == null)
				cb_getServerVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetServerVersion);
			return cb_getServerVersion;
		}

		static int n_GetServerVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ServerVersion;
		}
#pragma warning restore 0169

		static IntPtr id_getServerVersion;
		public virtual int ServerVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='getServerVersion' and count(parameter)=0]"
			[Register ("getServerVersion", "()I", "GetGetServerVersionHandler")]
			get {
				if (id_getServerVersion == IntPtr.Zero)
					id_getServerVersion = JNIEnv.GetMethodID (class_ref, "getServerVersion", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getServerVersion);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServerVersion", "()I"));
			}
		}

		static Delegate cb__put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I;
#pragma warning disable 0169
		static Delegate Get_put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_IHandler ()
		{
			if (cb__put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I == null)
				cb__put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n__put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I);
			return cb__put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I;
		}

		static void n__put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.ISftpProgressMonitor p2 = (global::Com.Jcraft.Jsch.ISftpProgressMonitor)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISftpProgressMonitor> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this._put (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id__put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='_put' and count(parameter)=4 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.jcraft.jsch.SftpProgressMonitor'] and parameter[4][@type='int']]"
		[Register ("_put", "(Ljava/io/InputStream;Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;I)V", "Get_put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_IHandler")]
		public virtual void _put (global::System.IO.Stream p0, string p1, global::Com.Jcraft.Jsch.ISftpProgressMonitor p2, int p3)
		{
			if (id__put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I == IntPtr.Zero)
				id__put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I = JNIEnv.GetMethodID (class_ref, "_put", "(Ljava/io/InputStream;Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;I)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id__put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "_put", "(Ljava/io/InputStream;Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;I)V"), new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_cd_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCd_Ljava_lang_String_Handler ()
		{
			if (cb_cd_Ljava_lang_String_ == null)
				cb_cd_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Cd_Ljava_lang_String_);
			return cb_cd_Ljava_lang_String_;
		}

		static void n_Cd_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Cd (p0);
		}
#pragma warning restore 0169

		static IntPtr id_cd_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='cd' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("cd", "(Ljava/lang/String;)V", "GetCd_Ljava_lang_String_Handler")]
		public virtual void Cd (string p0)
		{
			if (id_cd_Ljava_lang_String_ == IntPtr.Zero)
				id_cd_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "cd", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_cd_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cd", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_chgrp_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetChgrp_ILjava_lang_String_Handler ()
		{
			if (cb_chgrp_ILjava_lang_String_ == null)
				cb_chgrp_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Chgrp_ILjava_lang_String_);
			return cb_chgrp_ILjava_lang_String_;
		}

		static void n_Chgrp_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Chgrp (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_chgrp_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='chgrp' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("chgrp", "(ILjava/lang/String;)V", "GetChgrp_ILjava_lang_String_Handler")]
		public virtual void Chgrp (int p0, string p1)
		{
			if (id_chgrp_ILjava_lang_String_ == IntPtr.Zero)
				id_chgrp_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "chgrp", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_chgrp_ILjava_lang_String_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "chgrp", "(ILjava/lang/String;)V"), new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_chmod_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetChmod_ILjava_lang_String_Handler ()
		{
			if (cb_chmod_ILjava_lang_String_ == null)
				cb_chmod_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Chmod_ILjava_lang_String_);
			return cb_chmod_ILjava_lang_String_;
		}

		static void n_Chmod_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Chmod (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_chmod_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='chmod' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("chmod", "(ILjava/lang/String;)V", "GetChmod_ILjava_lang_String_Handler")]
		public virtual void Chmod (int p0, string p1)
		{
			if (id_chmod_ILjava_lang_String_ == IntPtr.Zero)
				id_chmod_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "chmod", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_chmod_ILjava_lang_String_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "chmod", "(ILjava/lang/String;)V"), new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_chown_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetChown_ILjava_lang_String_Handler ()
		{
			if (cb_chown_ILjava_lang_String_ == null)
				cb_chown_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Chown_ILjava_lang_String_);
			return cb_chown_ILjava_lang_String_;
		}

		static void n_Chown_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Chown (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_chown_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='chown' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("chown", "(ILjava/lang/String;)V", "GetChown_ILjava_lang_String_Handler")]
		public virtual void Chown (int p0, string p1)
		{
			if (id_chown_ILjava_lang_String_ == IntPtr.Zero)
				id_chown_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "chown", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_chown_ILjava_lang_String_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "chown", "(ILjava/lang/String;)V"), new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_exit;
#pragma warning disable 0169
		static Delegate GetExitHandler ()
		{
			if (cb_exit == null)
				cb_exit = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Exit);
			return cb_exit;
		}

		static void n_Exit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Exit ();
		}
#pragma warning restore 0169

		static IntPtr id_exit;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='exit' and count(parameter)=0]"
		[Register ("exit", "()V", "GetExitHandler")]
		public virtual void Exit ()
		{
			if (id_exit == IntPtr.Zero)
				id_exit = JNIEnv.GetMethodID (class_ref, "exit", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_exit);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "exit", "()V"));
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/io/InputStream;", "GetGet_Ljava_lang_String_Handler")]
		public virtual global::System.IO.Stream Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;)Ljava/io/InputStream;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_Handler ()
		{
			if (cb_get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_ == null)
				cb_get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_);
			return cb_get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_;
		}

		static IntPtr n_Get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.ISftpProgressMonitor p1 = (global::Com.Jcraft.Jsch.ISftpProgressMonitor)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISftpProgressMonitor> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Get (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='get' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.jcraft.jsch.SftpProgressMonitor']]"
		[Register ("get", "(Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;)Ljava/io/InputStream;", "GetGet_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_Handler")]
		public virtual global::System.IO.Stream Get (string p0, global::Com.Jcraft.Jsch.ISftpProgressMonitor p1)
		{
			if (id_get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_ == IntPtr.Zero)
				id_get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;)Ljava/io/InputStream;"), new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_IHandler ()
		{
			if (cb_get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I == null)
				cb_get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr>) n_Get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I);
			return cb_get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I;
		}

		static IntPtr n_Get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.ISftpProgressMonitor p1 = (global::Com.Jcraft.Jsch.ISftpProgressMonitor)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISftpProgressMonitor> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Get (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='get' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.jcraft.jsch.SftpProgressMonitor'] and parameter[3][@type='int']]"
		[Register ("get", "(Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;I)Ljava/io/InputStream;", "GetGet_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_IHandler")]
		public virtual global::System.IO.Stream Get (string p0, global::Com.Jcraft.Jsch.ISftpProgressMonitor p1, int p2)
		{
			if (id_get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I == IntPtr.Zero)
				id_get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;I)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;I)Ljava/io/InputStream;"), new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_J;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_JHandler ()
		{
			if (cb_get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_J == null)
				cb_get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr>) n_Get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_J);
			return cb_get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_J;
		}

		static IntPtr n_Get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.ISftpProgressMonitor p1 = (global::Com.Jcraft.Jsch.ISftpProgressMonitor)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISftpProgressMonitor> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Get (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='get' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.jcraft.jsch.SftpProgressMonitor'] and parameter[3][@type='long']]"
		[Register ("get", "(Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;J)Ljava/io/InputStream;", "GetGet_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_JHandler")]
		public virtual global::System.IO.Stream Get (string p0, global::Com.Jcraft.Jsch.ISftpProgressMonitor p1, long p2)
		{
			if (id_get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_J == IntPtr.Zero)
				id_get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_J = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;J)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_J, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;J)Ljava/io/InputStream;"), new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_get_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_IHandler ()
		{
			if (cb_get_Ljava_lang_String_I == null)
				cb_get_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_Get_Ljava_lang_String_I);
			return cb_get_Ljava_lang_String_I;
		}

		static IntPtr n_Get_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Get (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='get' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("get", "(Ljava/lang/String;I)Ljava/io/InputStream;", "GetGet_Ljava_lang_String_IHandler")]
		public virtual global::System.IO.Stream Get (string p0, int p1)
		{
			if (id_get_Ljava_lang_String_I == IntPtr.Zero)
				id_get_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;I)Ljava/io/InputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;I)Ljava/io/InputStream;"), new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_get_Ljava_lang_String_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Ljava_io_OutputStream_Handler ()
		{
			if (cb_get_Ljava_lang_String_Ljava_io_OutputStream_ == null)
				cb_get_Ljava_lang_String_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_Ljava_io_OutputStream_);
			return cb_get_Ljava_lang_String_Ljava_io_OutputStream_;
		}

		static void n_Get_Ljava_lang_String_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p1 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Get (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='get' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("get", "(Ljava/lang/String;Ljava/io/OutputStream;)V", "GetGet_Ljava_lang_String_Ljava_io_OutputStream_Handler")]
		public virtual void Get (string p0, global::System.IO.Stream p1)
		{
			if (id_get_Ljava_lang_String_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_get_Ljava_lang_String_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;Ljava/io/OutputStream;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_get_Ljava_lang_String_Ljava_io_OutputStream_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;Ljava/io/OutputStream;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_get_Ljava_lang_String_Ljava_io_OutputStream_Lcom_jcraft_jsch_SftpProgressMonitor_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Ljava_io_OutputStream_Lcom_jcraft_jsch_SftpProgressMonitor_Handler ()
		{
			if (cb_get_Ljava_lang_String_Ljava_io_OutputStream_Lcom_jcraft_jsch_SftpProgressMonitor_ == null)
				cb_get_Ljava_lang_String_Ljava_io_OutputStream_Lcom_jcraft_jsch_SftpProgressMonitor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_Ljava_io_OutputStream_Lcom_jcraft_jsch_SftpProgressMonitor_);
			return cb_get_Ljava_lang_String_Ljava_io_OutputStream_Lcom_jcraft_jsch_SftpProgressMonitor_;
		}

		static void n_Get_Ljava_lang_String_Ljava_io_OutputStream_Lcom_jcraft_jsch_SftpProgressMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p1 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.ISftpProgressMonitor p2 = (global::Com.Jcraft.Jsch.ISftpProgressMonitor)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISftpProgressMonitor> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Get (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_Ljava_io_OutputStream_Lcom_jcraft_jsch_SftpProgressMonitor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='get' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.OutputStream'] and parameter[3][@type='com.jcraft.jsch.SftpProgressMonitor']]"
		[Register ("get", "(Ljava/lang/String;Ljava/io/OutputStream;Lcom/jcraft/jsch/SftpProgressMonitor;)V", "GetGet_Ljava_lang_String_Ljava_io_OutputStream_Lcom_jcraft_jsch_SftpProgressMonitor_Handler")]
		public virtual void Get (string p0, global::System.IO.Stream p1, global::Com.Jcraft.Jsch.ISftpProgressMonitor p2)
		{
			if (id_get_Ljava_lang_String_Ljava_io_OutputStream_Lcom_jcraft_jsch_SftpProgressMonitor_ == IntPtr.Zero)
				id_get_Ljava_lang_String_Ljava_io_OutputStream_Lcom_jcraft_jsch_SftpProgressMonitor_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;Ljava/io/OutputStream;Lcom/jcraft/jsch/SftpProgressMonitor;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_get_Ljava_lang_String_Ljava_io_OutputStream_Lcom_jcraft_jsch_SftpProgressMonitor_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;Ljava/io/OutputStream;Lcom/jcraft/jsch/SftpProgressMonitor;)V"), new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_get_Ljava_lang_String_Ljava_io_OutputStream_Lcom_jcraft_jsch_SftpProgressMonitor_IJ;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Ljava_io_OutputStream_Lcom_jcraft_jsch_SftpProgressMonitor_IJHandler ()
		{
			if (cb_get_Ljava_lang_String_Ljava_io_OutputStream_Lcom_jcraft_jsch_SftpProgressMonitor_IJ == null)
				cb_get_Ljava_lang_String_Ljava_io_OutputStream_Lcom_jcraft_jsch_SftpProgressMonitor_IJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, long>) n_Get_Ljava_lang_String_Ljava_io_OutputStream_Lcom_jcraft_jsch_SftpProgressMonitor_IJ);
			return cb_get_Ljava_lang_String_Ljava_io_OutputStream_Lcom_jcraft_jsch_SftpProgressMonitor_IJ;
		}

		static void n_Get_Ljava_lang_String_Ljava_io_OutputStream_Lcom_jcraft_jsch_SftpProgressMonitor_IJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, long p4)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p1 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.ISftpProgressMonitor p2 = (global::Com.Jcraft.Jsch.ISftpProgressMonitor)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISftpProgressMonitor> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Get (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_Ljava_io_OutputStream_Lcom_jcraft_jsch_SftpProgressMonitor_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='get' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.OutputStream'] and parameter[3][@type='com.jcraft.jsch.SftpProgressMonitor'] and parameter[4][@type='int'] and parameter[5][@type='long']]"
		[Register ("get", "(Ljava/lang/String;Ljava/io/OutputStream;Lcom/jcraft/jsch/SftpProgressMonitor;IJ)V", "GetGet_Ljava_lang_String_Ljava_io_OutputStream_Lcom_jcraft_jsch_SftpProgressMonitor_IJHandler")]
		public virtual void Get (string p0, global::System.IO.Stream p1, global::Com.Jcraft.Jsch.ISftpProgressMonitor p2, int p3, long p4)
		{
			if (id_get_Ljava_lang_String_Ljava_io_OutputStream_Lcom_jcraft_jsch_SftpProgressMonitor_IJ == IntPtr.Zero)
				id_get_Ljava_lang_String_Ljava_io_OutputStream_Lcom_jcraft_jsch_SftpProgressMonitor_IJ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;Ljava/io/OutputStream;Lcom/jcraft/jsch/SftpProgressMonitor;IJ)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_get_Ljava_lang_String_Ljava_io_OutputStream_Lcom_jcraft_jsch_SftpProgressMonitor_IJ, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;Ljava/io/OutputStream;Lcom/jcraft/jsch/SftpProgressMonitor;IJ)V"), new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_get_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Get_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Get (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='get' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;Ljava/lang/String;)V", "GetGet_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void Get (string p0, string p1)
		{
			if (id_get_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_get_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_get_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_Handler ()
		{
			if (cb_get_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_ == null)
				cb_get_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_);
			return cb_get_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_;
		}

		static void n_Get_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.ISftpProgressMonitor p2 = (global::Com.Jcraft.Jsch.ISftpProgressMonitor)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISftpProgressMonitor> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Get (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='get' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.jcraft.jsch.SftpProgressMonitor']]"
		[Register ("get", "(Ljava/lang/String;Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;)V", "GetGet_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_Handler")]
		public virtual void Get (string p0, string p1, global::Com.Jcraft.Jsch.ISftpProgressMonitor p2)
		{
			if (id_get_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_ == IntPtr.Zero)
				id_get_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_get_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;)V"), new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_get_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_IHandler ()
		{
			if (cb_get_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I == null)
				cb_get_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Get_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I);
			return cb_get_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I;
		}

		static void n_Get_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.ISftpProgressMonitor p2 = (global::Com.Jcraft.Jsch.ISftpProgressMonitor)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISftpProgressMonitor> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Get (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='get' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.jcraft.jsch.SftpProgressMonitor'] and parameter[4][@type='int']]"
		[Register ("get", "(Ljava/lang/String;Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;I)V", "GetGet_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_IHandler")]
		public virtual void Get (string p0, string p1, global::Com.Jcraft.Jsch.ISftpProgressMonitor p2, int p3)
		{
			if (id_get_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I == IntPtr.Zero)
				id_get_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_get_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;I)V"), new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getExtension_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetExtension_Ljava_lang_String_Handler ()
		{
			if (cb_getExtension_Ljava_lang_String_ == null)
				cb_getExtension_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetExtension_Ljava_lang_String_);
			return cb_getExtension_Ljava_lang_String_;
		}

		static IntPtr n_GetExtension_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetExtension (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getExtension_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='getExtension' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getExtension", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetExtension_Ljava_lang_String_Handler")]
		public virtual string GetExtension (string p0)
		{
			if (id_getExtension_Ljava_lang_String_ == IntPtr.Zero)
				id_getExtension_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getExtension", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getExtension_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExtension", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_hardlink_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHardlink_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_hardlink_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_hardlink_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Hardlink_Ljava_lang_String_Ljava_lang_String_);
			return cb_hardlink_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Hardlink_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Hardlink (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_hardlink_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='hardlink' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("hardlink", "(Ljava/lang/String;Ljava/lang/String;)V", "GetHardlink_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void Hardlink (string p0, string p1)
		{
			if (id_hardlink_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_hardlink_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "hardlink", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_hardlink_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hardlink", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_lcd_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLcd_Ljava_lang_String_Handler ()
		{
			if (cb_lcd_Ljava_lang_String_ == null)
				cb_lcd_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Lcd_Ljava_lang_String_);
			return cb_lcd_Ljava_lang_String_;
		}

		static void n_Lcd_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Lcd (p0);
		}
#pragma warning restore 0169

		static IntPtr id_lcd_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='lcd' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("lcd", "(Ljava/lang/String;)V", "GetLcd_Ljava_lang_String_Handler")]
		public virtual void Lcd (string p0)
		{
			if (id_lcd_Ljava_lang_String_ == IntPtr.Zero)
				id_lcd_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "lcd", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_lcd_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "lcd", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_lpwd;
#pragma warning disable 0169
		static Delegate GetLpwdHandler ()
		{
			if (cb_lpwd == null)
				cb_lpwd = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Lpwd);
			return cb_lpwd;
		}

		static IntPtr n_Lpwd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Lpwd ());
		}
#pragma warning restore 0169

		static IntPtr id_lpwd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='lpwd' and count(parameter)=0]"
		[Register ("lpwd", "()Ljava/lang/String;", "GetLpwdHandler")]
		public virtual string Lpwd ()
		{
			if (id_lpwd == IntPtr.Zero)
				id_lpwd = JNIEnv.GetMethodID (class_ref, "lpwd", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_lpwd), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "lpwd", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_ls_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLs_Ljava_lang_String_Handler ()
		{
			if (cb_ls_Ljava_lang_String_ == null)
				cb_ls_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Ls_Ljava_lang_String_);
			return cb_ls_Ljava_lang_String_;
		}

		static IntPtr n_Ls_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Ls (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_ls_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='ls' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("ls", "(Ljava/lang/String;)Ljava/util/Vector;", "GetLs_Ljava_lang_String_Handler")]
		public virtual global::Java.Util.Vector Ls (string p0)
		{
			if (id_ls_Ljava_lang_String_ == IntPtr.Zero)
				id_ls_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "ls", "(Ljava/lang/String;)Ljava/util/Vector;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Java.Util.Vector __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Vector> (JNIEnv.CallObjectMethod  (Handle, id_ls_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Vector> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ls", "(Ljava/lang/String;)Ljava/util/Vector;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_ls_Ljava_lang_String_Lcom_jcraft_jsch_ChannelSftp_LsEntrySelector_;
#pragma warning disable 0169
		static Delegate GetLs_Ljava_lang_String_Lcom_jcraft_jsch_ChannelSftp_LsEntrySelector_Handler ()
		{
			if (cb_ls_Ljava_lang_String_Lcom_jcraft_jsch_ChannelSftp_LsEntrySelector_ == null)
				cb_ls_Ljava_lang_String_Lcom_jcraft_jsch_ChannelSftp_LsEntrySelector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Ls_Ljava_lang_String_Lcom_jcraft_jsch_ChannelSftp_LsEntrySelector_);
			return cb_ls_Ljava_lang_String_Lcom_jcraft_jsch_ChannelSftp_LsEntrySelector_;
		}

		static void n_Ls_Ljava_lang_String_Lcom_jcraft_jsch_ChannelSftp_LsEntrySelector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.ChannelSftp.ILsEntrySelector p1 = (global::Com.Jcraft.Jsch.ChannelSftp.ILsEntrySelector)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp.ILsEntrySelector> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Ls (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_ls_Ljava_lang_String_Lcom_jcraft_jsch_ChannelSftp_LsEntrySelector_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='ls' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.jcraft.jsch.ChannelSftp.LsEntrySelector']]"
		[Register ("ls", "(Ljava/lang/String;Lcom/jcraft/jsch/ChannelSftp$LsEntrySelector;)V", "GetLs_Ljava_lang_String_Lcom_jcraft_jsch_ChannelSftp_LsEntrySelector_Handler")]
		public virtual void Ls (string p0, global::Com.Jcraft.Jsch.ChannelSftp.ILsEntrySelector p1)
		{
			if (id_ls_Ljava_lang_String_Lcom_jcraft_jsch_ChannelSftp_LsEntrySelector_ == IntPtr.Zero)
				id_ls_Ljava_lang_String_Lcom_jcraft_jsch_ChannelSftp_LsEntrySelector_ = JNIEnv.GetMethodID (class_ref, "ls", "(Ljava/lang/String;Lcom/jcraft/jsch/ChannelSftp$LsEntrySelector;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_ls_Ljava_lang_String_Lcom_jcraft_jsch_ChannelSftp_LsEntrySelector_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ls", "(Ljava/lang/String;Lcom/jcraft/jsch/ChannelSftp$LsEntrySelector;)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_lstat_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLstat_Ljava_lang_String_Handler ()
		{
			if (cb_lstat_Ljava_lang_String_ == null)
				cb_lstat_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Lstat_Ljava_lang_String_);
			return cb_lstat_Ljava_lang_String_;
		}

		static IntPtr n_Lstat_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Lstat (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_lstat_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='lstat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("lstat", "(Ljava/lang/String;)Lcom/jcraft/jsch/SftpATTRS;", "GetLstat_Ljava_lang_String_Handler")]
		public virtual global::Com.Jcraft.Jsch.SftpATTRS Lstat (string p0)
		{
			if (id_lstat_Ljava_lang_String_ == IntPtr.Zero)
				id_lstat_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "lstat", "(Ljava/lang/String;)Lcom/jcraft/jsch/SftpATTRS;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Jcraft.Jsch.SftpATTRS __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (JNIEnv.CallObjectMethod  (Handle, id_lstat_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "lstat", "(Ljava/lang/String;)Lcom/jcraft/jsch/SftpATTRS;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_mkdir_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMkdir_Ljava_lang_String_Handler ()
		{
			if (cb_mkdir_Ljava_lang_String_ == null)
				cb_mkdir_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Mkdir_Ljava_lang_String_);
			return cb_mkdir_Ljava_lang_String_;
		}

		static void n_Mkdir_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Mkdir (p0);
		}
#pragma warning restore 0169

		static IntPtr id_mkdir_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='mkdir' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("mkdir", "(Ljava/lang/String;)V", "GetMkdir_Ljava_lang_String_Handler")]
		public virtual void Mkdir (string p0)
		{
			if (id_mkdir_Ljava_lang_String_ == IntPtr.Zero)
				id_mkdir_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "mkdir", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_mkdir_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mkdir", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_put_Ljava_io_InputStream_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_io_InputStream_Ljava_lang_String_Handler ()
		{
			if (cb_put_Ljava_io_InputStream_Ljava_lang_String_ == null)
				cb_put_Ljava_io_InputStream_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_io_InputStream_Ljava_lang_String_);
			return cb_put_Ljava_io_InputStream_Ljava_lang_String_;
		}

		static void n_Put_Ljava_io_InputStream_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_io_InputStream_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.lang.String']]"
		[Register ("put", "(Ljava/io/InputStream;Ljava/lang/String;)V", "GetPut_Ljava_io_InputStream_Ljava_lang_String_Handler")]
		public virtual void Put (global::System.IO.Stream p0, string p1)
		{
			if (id_put_Ljava_io_InputStream_Ljava_lang_String_ == IntPtr.Zero)
				id_put_Ljava_io_InputStream_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/io/InputStream;Ljava/lang/String;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_put_Ljava_io_InputStream_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/io/InputStream;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_Handler ()
		{
			if (cb_put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_ == null)
				cb_put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_);
			return cb_put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_;
		}

		static void n_Put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.ISftpProgressMonitor p2 = (global::Com.Jcraft.Jsch.ISftpProgressMonitor)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISftpProgressMonitor> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='put' and count(parameter)=3 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.jcraft.jsch.SftpProgressMonitor']]"
		[Register ("put", "(Ljava/io/InputStream;Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;)V", "GetPut_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_Handler")]
		public virtual void Put (global::System.IO.Stream p0, string p1, global::Com.Jcraft.Jsch.ISftpProgressMonitor p2)
		{
			if (id_put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_ == IntPtr.Zero)
				id_put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/io/InputStream;Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/io/InputStream;Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;)V"), new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_IHandler ()
		{
			if (cb_put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I == null)
				cb_put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I);
			return cb_put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I;
		}

		static void n_Put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.ISftpProgressMonitor p2 = (global::Com.Jcraft.Jsch.ISftpProgressMonitor)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISftpProgressMonitor> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='put' and count(parameter)=4 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.jcraft.jsch.SftpProgressMonitor'] and parameter[4][@type='int']]"
		[Register ("put", "(Ljava/io/InputStream;Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;I)V", "GetPut_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_IHandler")]
		public virtual void Put (global::System.IO.Stream p0, string p1, global::Com.Jcraft.Jsch.ISftpProgressMonitor p2, int p3)
		{
			if (id_put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I == IntPtr.Zero)
				id_put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/io/InputStream;Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;I)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_put_Ljava_io_InputStream_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/io/InputStream;Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;I)V"), new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_put_Ljava_io_InputStream_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_io_InputStream_Ljava_lang_String_IHandler ()
		{
			if (cb_put_Ljava_io_InputStream_Ljava_lang_String_I == null)
				cb_put_Ljava_io_InputStream_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Put_Ljava_io_InputStream_Ljava_lang_String_I);
			return cb_put_Ljava_io_InputStream_Ljava_lang_String_I;
		}

		static void n_Put_Ljava_io_InputStream_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_io_InputStream_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='put' and count(parameter)=3 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("put", "(Ljava/io/InputStream;Ljava/lang/String;I)V", "GetPut_Ljava_io_InputStream_Ljava_lang_String_IHandler")]
		public virtual void Put (global::System.IO.Stream p0, string p1, int p2)
		{
			if (id_put_Ljava_io_InputStream_Ljava_lang_String_I == IntPtr.Zero)
				id_put_Ljava_io_InputStream_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/io/InputStream;Ljava/lang/String;I)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_put_Ljava_io_InputStream_Ljava_lang_String_I, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/io/InputStream;Ljava/lang/String;I)V"), new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_put_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Handler ()
		{
			if (cb_put_Ljava_lang_String_ == null)
				cb_put_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_);
			return cb_put_Ljava_lang_String_;
		}

		static IntPtr n_Put_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.Put (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='put' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("put", "(Ljava/lang/String;)Ljava/io/OutputStream;", "GetPut_Ljava_lang_String_Handler")]
		public virtual global::System.IO.Stream Put (string p0)
		{
			if (id_put_Ljava_lang_String_ == IntPtr.Zero)
				id_put_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;)Ljava/io/OutputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_put_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;)Ljava/io/OutputStream;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_put_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_IHandler ()
		{
			if (cb_put_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I == null)
				cb_put_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr>) n_Put_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I);
			return cb_put_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I;
		}

		static IntPtr n_Put_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.ISftpProgressMonitor p1 = (global::Com.Jcraft.Jsch.ISftpProgressMonitor)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISftpProgressMonitor> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.Put (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='put' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.jcraft.jsch.SftpProgressMonitor'] and parameter[3][@type='int']]"
		[Register ("put", "(Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;I)Ljava/io/OutputStream;", "GetPut_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_IHandler")]
		public virtual global::System.IO.Stream Put (string p0, global::Com.Jcraft.Jsch.ISftpProgressMonitor p1, int p2)
		{
			if (id_put_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I == IntPtr.Zero)
				id_put_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;I)Ljava/io/OutputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_put_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;I)Ljava/io/OutputStream;"), new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_put_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_IJ;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_IJHandler ()
		{
			if (cb_put_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_IJ == null)
				cb_put_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_IJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, long, IntPtr>) n_Put_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_IJ);
			return cb_put_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_IJ;
		}

		static IntPtr n_Put_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_IJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, long p3)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.ISftpProgressMonitor p1 = (global::Com.Jcraft.Jsch.ISftpProgressMonitor)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISftpProgressMonitor> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.Put (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='put' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.jcraft.jsch.SftpProgressMonitor'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("put", "(Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;IJ)Ljava/io/OutputStream;", "GetPut_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_IJHandler")]
		public virtual global::System.IO.Stream Put (string p0, global::Com.Jcraft.Jsch.ISftpProgressMonitor p1, int p2, long p3)
		{
			if (id_put_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_IJ == IntPtr.Zero)
				id_put_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_IJ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;IJ)Ljava/io/OutputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_put_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_IJ, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;IJ)Ljava/io/OutputStream;"), new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_put_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_IHandler ()
		{
			if (cb_put_Ljava_lang_String_I == null)
				cb_put_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_Put_Ljava_lang_String_I);
			return cb_put_Ljava_lang_String_I;
		}

		static IntPtr n_Put_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.Put (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("put", "(Ljava/lang/String;I)Ljava/io/OutputStream;", "GetPut_Ljava_lang_String_IHandler")]
		public virtual global::System.IO.Stream Put (string p0, int p1)
		{
			if (id_put_Ljava_lang_String_I == IntPtr.Zero)
				id_put_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;I)Ljava/io/OutputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_put_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;I)Ljava/io/OutputStream;"), new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_put_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Ljava_lang_String_);
			return cb_put_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Put_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPut_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void Put (string p0, string p1)
		{
			if (id_put_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_put_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_ == null)
				cb_put_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_);
			return cb_put_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_;
		}

		static void n_Put_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.ISftpProgressMonitor p2 = (global::Com.Jcraft.Jsch.ISftpProgressMonitor)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISftpProgressMonitor> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='put' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.jcraft.jsch.SftpProgressMonitor']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;)V", "GetPut_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_Handler")]
		public virtual void Put (string p0, string p1, global::Com.Jcraft.Jsch.ISftpProgressMonitor p2)
		{
			if (id_put_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_put_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;)V"), new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_IHandler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I == null)
				cb_put_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Put_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I);
			return cb_put_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I;
		}

		static void n_Put_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.ISftpProgressMonitor p2 = (global::Com.Jcraft.Jsch.ISftpProgressMonitor)global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ISftpProgressMonitor> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='put' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.jcraft.jsch.SftpProgressMonitor'] and parameter[4][@type='int']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;I)V", "GetPut_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_IHandler")]
		public virtual void Put (string p0, string p1, global::Com.Jcraft.Jsch.ISftpProgressMonitor p2, int p3)
		{
			if (id_put_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I == IntPtr.Zero)
				id_put_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_put_Ljava_lang_String_Ljava_lang_String_Lcom_jcraft_jsch_SftpProgressMonitor_I, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;Ljava/lang/String;Lcom/jcraft/jsch/SftpProgressMonitor;I)V"), new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_String_I == null)
				cb_put_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Put_Ljava_lang_String_Ljava_lang_String_I);
			return cb_put_Ljava_lang_String_Ljava_lang_String_I;
		}

		static void n_Put_Ljava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='put' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;I)V", "GetPut_Ljava_lang_String_Ljava_lang_String_IHandler")]
		public virtual void Put (string p0, string p1, int p2)
		{
			if (id_put_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_put_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_put_Ljava_lang_String_Ljava_lang_String_I, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;Ljava/lang/String;I)V"), new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_pwd;
#pragma warning disable 0169
		static Delegate GetPwdHandler ()
		{
			if (cb_pwd == null)
				cb_pwd = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Pwd);
			return cb_pwd;
		}

		static IntPtr n_Pwd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Pwd ());
		}
#pragma warning restore 0169

		static IntPtr id_pwd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='pwd' and count(parameter)=0]"
		[Register ("pwd", "()Ljava/lang/String;", "GetPwdHandler")]
		public virtual string Pwd ()
		{
			if (id_pwd == IntPtr.Zero)
				id_pwd = JNIEnv.GetMethodID (class_ref, "pwd", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_pwd), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pwd", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_quit;
#pragma warning disable 0169
		static Delegate GetQuitHandler ()
		{
			if (cb_quit == null)
				cb_quit = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Quit);
			return cb_quit;
		}

		static void n_Quit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Quit ();
		}
#pragma warning restore 0169

		static IntPtr id_quit;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='quit' and count(parameter)=0]"
		[Register ("quit", "()V", "GetQuitHandler")]
		public virtual void Quit ()
		{
			if (id_quit == IntPtr.Zero)
				id_quit = JNIEnv.GetMethodID (class_ref, "quit", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_quit);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "quit", "()V"));
		}

		static Delegate cb_readlink_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReadlink_Ljava_lang_String_Handler ()
		{
			if (cb_readlink_Ljava_lang_String_ == null)
				cb_readlink_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Readlink_Ljava_lang_String_);
			return cb_readlink_Ljava_lang_String_;
		}

		static IntPtr n_Readlink_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Readlink (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readlink_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='readlink' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("readlink", "(Ljava/lang/String;)Ljava/lang/String;", "GetReadlink_Ljava_lang_String_Handler")]
		public virtual string Readlink (string p0)
		{
			if (id_readlink_Ljava_lang_String_ == IntPtr.Zero)
				id_readlink_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "readlink", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_readlink_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readlink", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_realpath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRealpath_Ljava_lang_String_Handler ()
		{
			if (cb_realpath_Ljava_lang_String_ == null)
				cb_realpath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Realpath_Ljava_lang_String_);
			return cb_realpath_Ljava_lang_String_;
		}

		static IntPtr n_Realpath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Realpath (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_realpath_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='realpath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("realpath", "(Ljava/lang/String;)Ljava/lang/String;", "GetRealpath_Ljava_lang_String_Handler")]
		public virtual string Realpath (string p0)
		{
			if (id_realpath_Ljava_lang_String_ == IntPtr.Zero)
				id_realpath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "realpath", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_realpath_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "realpath", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_rename_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRename_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_rename_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_rename_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Rename_Ljava_lang_String_Ljava_lang_String_);
			return cb_rename_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Rename_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Rename (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_rename_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='rename' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("rename", "(Ljava/lang/String;Ljava/lang/String;)V", "GetRename_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void Rename (string p0, string p1)
		{
			if (id_rename_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_rename_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "rename", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_rename_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rename", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_rm_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRm_Ljava_lang_String_Handler ()
		{
			if (cb_rm_Ljava_lang_String_ == null)
				cb_rm_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Rm_Ljava_lang_String_);
			return cb_rm_Ljava_lang_String_;
		}

		static void n_Rm_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Rm (p0);
		}
#pragma warning restore 0169

		static IntPtr id_rm_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='rm' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("rm", "(Ljava/lang/String;)V", "GetRm_Ljava_lang_String_Handler")]
		public virtual void Rm (string p0)
		{
			if (id_rm_Ljava_lang_String_ == IntPtr.Zero)
				id_rm_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "rm", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_rm_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rm", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_rmdir_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRmdir_Ljava_lang_String_Handler ()
		{
			if (cb_rmdir_Ljava_lang_String_ == null)
				cb_rmdir_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Rmdir_Ljava_lang_String_);
			return cb_rmdir_Ljava_lang_String_;
		}

		static void n_Rmdir_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Rmdir (p0);
		}
#pragma warning restore 0169

		static IntPtr id_rmdir_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='rmdir' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("rmdir", "(Ljava/lang/String;)V", "GetRmdir_Ljava_lang_String_Handler")]
		public virtual void Rmdir (string p0)
		{
			if (id_rmdir_Ljava_lang_String_ == IntPtr.Zero)
				id_rmdir_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "rmdir", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_rmdir_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rmdir", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setFilenameEncoding_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFilenameEncoding_Ljava_lang_String_Handler ()
		{
			if (cb_setFilenameEncoding_Ljava_lang_String_ == null)
				cb_setFilenameEncoding_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFilenameEncoding_Ljava_lang_String_);
			return cb_setFilenameEncoding_Ljava_lang_String_;
		}

		static void n_SetFilenameEncoding_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetFilenameEncoding (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFilenameEncoding_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='setFilenameEncoding' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setFilenameEncoding", "(Ljava/lang/String;)V", "GetSetFilenameEncoding_Ljava_lang_String_Handler")]
		public virtual void SetFilenameEncoding (string p0)
		{
			if (id_setFilenameEncoding_Ljava_lang_String_ == IntPtr.Zero)
				id_setFilenameEncoding_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFilenameEncoding", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setFilenameEncoding_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFilenameEncoding", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setMtime_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetMtime_Ljava_lang_String_IHandler ()
		{
			if (cb_setMtime_Ljava_lang_String_I == null)
				cb_setMtime_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetMtime_Ljava_lang_String_I);
			return cb_setMtime_Ljava_lang_String_I;
		}

		static void n_SetMtime_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMtime (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setMtime_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='setMtime' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("setMtime", "(Ljava/lang/String;I)V", "GetSetMtime_Ljava_lang_String_IHandler")]
		public virtual void SetMtime (string p0, int p1)
		{
			if (id_setMtime_Ljava_lang_String_I == IntPtr.Zero)
				id_setMtime_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setMtime", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setMtime_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMtime", "(Ljava/lang/String;I)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setStat_Ljava_lang_String_Lcom_jcraft_jsch_SftpATTRS_;
#pragma warning disable 0169
		static Delegate GetSetStat_Ljava_lang_String_Lcom_jcraft_jsch_SftpATTRS_Handler ()
		{
			if (cb_setStat_Ljava_lang_String_Lcom_jcraft_jsch_SftpATTRS_ == null)
				cb_setStat_Ljava_lang_String_Lcom_jcraft_jsch_SftpATTRS_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetStat_Ljava_lang_String_Lcom_jcraft_jsch_SftpATTRS_);
			return cb_setStat_Ljava_lang_String_Lcom_jcraft_jsch_SftpATTRS_;
		}

		static void n_SetStat_Ljava_lang_String_Lcom_jcraft_jsch_SftpATTRS_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Jcraft.Jsch.SftpATTRS p1 = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetStat (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setStat_Ljava_lang_String_Lcom_jcraft_jsch_SftpATTRS_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='setStat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.jcraft.jsch.SftpATTRS']]"
		[Register ("setStat", "(Ljava/lang/String;Lcom/jcraft/jsch/SftpATTRS;)V", "GetSetStat_Ljava_lang_String_Lcom_jcraft_jsch_SftpATTRS_Handler")]
		public virtual void SetStat (string p0, global::Com.Jcraft.Jsch.SftpATTRS p1)
		{
			if (id_setStat_Ljava_lang_String_Lcom_jcraft_jsch_SftpATTRS_ == IntPtr.Zero)
				id_setStat_Ljava_lang_String_Lcom_jcraft_jsch_SftpATTRS_ = JNIEnv.GetMethodID (class_ref, "setStat", "(Ljava/lang/String;Lcom/jcraft/jsch/SftpATTRS;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setStat_Ljava_lang_String_Lcom_jcraft_jsch_SftpATTRS_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStat", "(Ljava/lang/String;Lcom/jcraft/jsch/SftpATTRS;)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_stat_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStat_Ljava_lang_String_Handler ()
		{
			if (cb_stat_Ljava_lang_String_ == null)
				cb_stat_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Stat_Ljava_lang_String_);
			return cb_stat_Ljava_lang_String_;
		}

		static IntPtr n_Stat_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Stat (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_stat_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='stat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("stat", "(Ljava/lang/String;)Lcom/jcraft/jsch/SftpATTRS;", "GetStat_Ljava_lang_String_Handler")]
		public virtual global::Com.Jcraft.Jsch.SftpATTRS Stat (string p0)
		{
			if (id_stat_Ljava_lang_String_ == IntPtr.Zero)
				id_stat_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "stat", "(Ljava/lang/String;)Lcom/jcraft/jsch/SftpATTRS;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Jcraft.Jsch.SftpATTRS __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (JNIEnv.CallObjectMethod  (Handle, id_stat_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpATTRS> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stat", "(Ljava/lang/String;)Lcom/jcraft/jsch/SftpATTRS;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_statVFS_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStatVFS_Ljava_lang_String_Handler ()
		{
			if (cb_statVFS_Ljava_lang_String_ == null)
				cb_statVFS_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_StatVFS_Ljava_lang_String_);
			return cb_statVFS_Ljava_lang_String_;
		}

		static IntPtr n_StatVFS_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StatVFS (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_statVFS_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='statVFS' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("statVFS", "(Ljava/lang/String;)Lcom/jcraft/jsch/SftpStatVFS;", "GetStatVFS_Ljava_lang_String_Handler")]
		public virtual global::Com.Jcraft.Jsch.SftpStatVFS StatVFS (string p0)
		{
			if (id_statVFS_Ljava_lang_String_ == IntPtr.Zero)
				id_statVFS_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "statVFS", "(Ljava/lang/String;)Lcom/jcraft/jsch/SftpStatVFS;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Jcraft.Jsch.SftpStatVFS __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpStatVFS> (JNIEnv.CallObjectMethod  (Handle, id_statVFS_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.SftpStatVFS> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "statVFS", "(Ljava/lang/String;)Lcom/jcraft/jsch/SftpStatVFS;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_symlink_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSymlink_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_symlink_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_symlink_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Symlink_Ljava_lang_String_Ljava_lang_String_);
			return cb_symlink_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Symlink_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Symlink (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_symlink_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='symlink' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("symlink", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSymlink_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void Symlink (string p0, string p1)
		{
			if (id_symlink_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_symlink_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "symlink", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_symlink_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "symlink", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_version;
#pragma warning disable 0169
		static Delegate GetVersionHandler ()
		{
			if (cb_version == null)
				cb_version = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Version);
			return cb_version;
		}

		static IntPtr n_Version (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.ChannelSftp __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.ChannelSftp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Version ());
		}
#pragma warning restore 0169

		static IntPtr id_version;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='ChannelSftp']/method[@name='version' and count(parameter)=0]"
		[Register ("version", "()Ljava/lang/String;", "GetVersionHandler")]
		public virtual string Version ()
		{
			if (id_version == IntPtr.Zero)
				id_version = JNIEnv.GetMethodID (class_ref, "version", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_version), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "version", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

	}
}

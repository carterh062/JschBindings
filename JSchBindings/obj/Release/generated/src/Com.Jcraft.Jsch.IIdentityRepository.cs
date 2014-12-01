using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='IdentityRepository.Wrapper']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/IdentityRepository$Wrapper", DoNotGenerateAcw=true)]
	public partial class IdentityRepositoryWrapper : global::Java.Lang.Object, global::Com.Jcraft.Jsch.IIdentityRepository {


		public static class InterfaceConsts {

			// The following are fields from: com.jcraft.jsch.IdentityRepository

			// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='IdentityRepository']/field[@name='NOTRUNNING']"
			[Register ("NOTRUNNING")]
			public const int Notrunning = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='IdentityRepository']/field[@name='RUNNING']"
			[Register ("RUNNING")]
			public const int Running = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='IdentityRepository']/field[@name='UNAVAILABLE']"
			[Register ("UNAVAILABLE")]
			public const int Unavailable = (int) 0;
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jcraft/jsch/IdentityRepository$Wrapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IdentityRepositoryWrapper); }
		}

		protected IdentityRepositoryWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getIdentities;
#pragma warning disable 0169
		static Delegate GetGetIdentitiesHandler ()
		{
			if (cb_getIdentities == null)
				cb_getIdentities = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIdentities);
			return cb_getIdentities;
		}

		static IntPtr n_GetIdentities (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.IdentityRepositoryWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IdentityRepositoryWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Identities);
		}
#pragma warning restore 0169

		static IntPtr id_getIdentities;
		public virtual global::Java.Util.Vector Identities {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='IdentityRepository.Wrapper']/method[@name='getIdentities' and count(parameter)=0]"
			[Register ("getIdentities", "()Ljava/util/Vector;", "GetGetIdentitiesHandler")]
			get {
				if (id_getIdentities == IntPtr.Zero)
					id_getIdentities = JNIEnv.GetMethodID (class_ref, "getIdentities", "()Ljava/util/Vector;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.Vector> (JNIEnv.CallObjectMethod  (Handle, id_getIdentities), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.Vector> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIdentities", "()Ljava/util/Vector;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.IdentityRepositoryWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IdentityRepositoryWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='IdentityRepository.Wrapper']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatus);
			return cb_getStatus;
		}

		static int n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.IdentityRepositoryWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IdentityRepositoryWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Status;
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		public virtual int Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='IdentityRepository.Wrapper']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()I", "GetGetStatusHandler")]
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getStatus);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()I"));
			}
		}

		static Delegate cb_add_arrayB;
#pragma warning disable 0169
		static Delegate GetAdd_arrayBHandler ()
		{
			if (cb_add_arrayB == null)
				cb_add_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Add_arrayB);
			return cb_add_arrayB;
		}

		static bool n_Add_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.IdentityRepositoryWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IdentityRepositoryWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.Add (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_add_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='IdentityRepository.Wrapper']/method[@name='add' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("add", "([B)Z", "GetAdd_arrayBHandler")]
		public virtual bool Add (byte[] p0)
		{
			if (id_add_arrayB == IntPtr.Zero)
				id_add_arrayB = JNIEnv.GetMethodID (class_ref, "add", "([B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_add_arrayB, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "([B)Z"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_remove_arrayB;
#pragma warning disable 0169
		static Delegate GetRemove_arrayBHandler ()
		{
			if (cb_remove_arrayB == null)
				cb_remove_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Remove_arrayB);
			return cb_remove_arrayB;
		}

		static bool n_Remove_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.IdentityRepositoryWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IdentityRepositoryWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.Remove (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_remove_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='IdentityRepository.Wrapper']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("remove", "([B)Z", "GetRemove_arrayBHandler")]
		public virtual bool Remove (byte[] p0)
		{
			if (id_remove_arrayB == IntPtr.Zero)
				id_remove_arrayB = JNIEnv.GetMethodID (class_ref, "remove", "([B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_remove_arrayB, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "([B)Z"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_removeAll;
#pragma warning disable 0169
		static Delegate GetRemoveAllHandler ()
		{
			if (cb_removeAll == null)
				cb_removeAll = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAll);
			return cb_removeAll;
		}

		static void n_RemoveAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.IdentityRepositoryWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IdentityRepositoryWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAll ();
		}
#pragma warning restore 0169

		static IntPtr id_removeAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='IdentityRepository.Wrapper']/method[@name='removeAll' and count(parameter)=0]"
		[Register ("removeAll", "()V", "GetRemoveAllHandler")]
		public virtual void RemoveAll ()
		{
			if (id_removeAll == IntPtr.Zero)
				id_removeAll = JNIEnv.GetMethodID (class_ref, "removeAll", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeAll);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAll", "()V"));
		}

	}

	[Register ("com/jcraft/jsch/IdentityRepository")]
	public abstract class IdentityRepository {

		internal IdentityRepository ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='IdentityRepository']/field[@name='NOTRUNNING']"
		[Register ("NOTRUNNING")]
		public const int Notrunning = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='IdentityRepository']/field[@name='RUNNING']"
		[Register ("RUNNING")]
		public const int Running = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='IdentityRepository']/field[@name='UNAVAILABLE']"
		[Register ("UNAVAILABLE")]
		public const int Unavailable = (int) 0;
	}

	[System.Obsolete ("Use the 'IdentityRepository' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class IdentityRepositoryConsts : IdentityRepository {

		private IdentityRepositoryConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='IdentityRepository']"
	[Register ("com/jcraft/jsch/IdentityRepository", "", "Com.Jcraft.Jsch.IIdentityRepositoryInvoker")]
	public partial interface IIdentityRepository : IJavaObject {

		global::Java.Util.Vector Identities {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='IdentityRepository']/method[@name='getIdentities' and count(parameter)=0]"
			[Register ("getIdentities", "()Ljava/util/Vector;", "GetGetIdentitiesHandler:Com.Jcraft.Jsch.IIdentityRepositoryInvoker, JSchBindings")] get;
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='IdentityRepository']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Com.Jcraft.Jsch.IIdentityRepositoryInvoker, JSchBindings")] get;
		}

		int Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='IdentityRepository']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()I", "GetGetStatusHandler:Com.Jcraft.Jsch.IIdentityRepositoryInvoker, JSchBindings")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='IdentityRepository']/method[@name='add' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("add", "([B)Z", "GetAdd_arrayBHandler:Com.Jcraft.Jsch.IIdentityRepositoryInvoker, JSchBindings")]
		bool Add (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='IdentityRepository']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("remove", "([B)Z", "GetRemove_arrayBHandler:Com.Jcraft.Jsch.IIdentityRepositoryInvoker, JSchBindings")]
		bool Remove (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='IdentityRepository']/method[@name='removeAll' and count(parameter)=0]"
		[Register ("removeAll", "()V", "GetRemoveAllHandler:Com.Jcraft.Jsch.IIdentityRepositoryInvoker, JSchBindings")]
		void RemoveAll ();

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/IdentityRepository", DoNotGenerateAcw=true)]
	internal class IIdentityRepositoryInvoker : global::Java.Lang.Object, IIdentityRepository {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jcraft/jsch/IdentityRepository");
		IntPtr class_ref;

		public static IIdentityRepository GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIdentityRepository> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jcraft.jsch.IdentityRepository"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIdentityRepositoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IIdentityRepositoryInvoker); }
		}

		static Delegate cb_getIdentities;
#pragma warning disable 0169
		static Delegate GetGetIdentitiesHandler ()
		{
			if (cb_getIdentities == null)
				cb_getIdentities = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIdentities);
			return cb_getIdentities;
		}

		static IntPtr n_GetIdentities (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.IIdentityRepository __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IIdentityRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Identities);
		}
#pragma warning restore 0169

		IntPtr id_getIdentities;
		public global::Java.Util.Vector Identities {
			get {
				if (id_getIdentities == IntPtr.Zero)
					id_getIdentities = JNIEnv.GetMethodID (class_ref, "getIdentities", "()Ljava/util/Vector;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Vector> (JNIEnv.CallObjectMethod (Handle, id_getIdentities), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.IIdentityRepository __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IIdentityRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatus);
			return cb_getStatus;
		}

		static int n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.IIdentityRepository __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IIdentityRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Status;
		}
#pragma warning restore 0169

		IntPtr id_getStatus;
		public int Status {
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getStatus);
			}
		}

		static Delegate cb_add_arrayB;
#pragma warning disable 0169
		static Delegate GetAdd_arrayBHandler ()
		{
			if (cb_add_arrayB == null)
				cb_add_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Add_arrayB);
			return cb_add_arrayB;
		}

		static bool n_Add_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.IIdentityRepository __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IIdentityRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.Add (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_add_arrayB;
		public bool Add (byte[] p0)
		{
			if (id_add_arrayB == IntPtr.Zero)
				id_add_arrayB = JNIEnv.GetMethodID (class_ref, "add", "([B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_add_arrayB, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_remove_arrayB;
#pragma warning disable 0169
		static Delegate GetRemove_arrayBHandler ()
		{
			if (cb_remove_arrayB == null)
				cb_remove_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Remove_arrayB);
			return cb_remove_arrayB;
		}

		static bool n_Remove_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jcraft.Jsch.IIdentityRepository __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IIdentityRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.Remove (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_remove_arrayB;
		public bool Remove (byte[] p0)
		{
			if (id_remove_arrayB == IntPtr.Zero)
				id_remove_arrayB = JNIEnv.GetMethodID (class_ref, "remove", "([B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_remove_arrayB, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_removeAll;
#pragma warning disable 0169
		static Delegate GetRemoveAllHandler ()
		{
			if (cb_removeAll == null)
				cb_removeAll = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAll);
			return cb_removeAll;
		}

		static void n_RemoveAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jcraft.Jsch.IIdentityRepository __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IIdentityRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAll ();
		}
#pragma warning restore 0169

		IntPtr id_removeAll;
		public void RemoveAll ()
		{
			if (id_removeAll == IntPtr.Zero)
				id_removeAll = JNIEnv.GetMethodID (class_ref, "removeAll", "()V");
			JNIEnv.CallVoidMethod (Handle, id_removeAll);
		}

	}

}

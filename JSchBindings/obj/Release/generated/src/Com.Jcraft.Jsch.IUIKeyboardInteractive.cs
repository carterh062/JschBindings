using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='UIKeyboardInteractive']"
	[Register ("com/jcraft/jsch/UIKeyboardInteractive", "", "Com.Jcraft.Jsch.IUIKeyboardInteractiveInvoker")]
	public partial interface IUIKeyboardInteractive : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.jcraft.jsch']/interface[@name='UIKeyboardInteractive']/method[@name='promptKeyboardInteractive' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='boolean[]']]"
		[Register ("promptKeyboardInteractive", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;[Z)[Ljava/lang/String;", "GetPromptKeyboardInteractive_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_arrayZHandler:Com.Jcraft.Jsch.IUIKeyboardInteractiveInvoker, JSchBindings")]
		string[] PromptKeyboardInteractive (string p0, string p1, string p2, string[] p3, bool[] p4);

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/UIKeyboardInteractive", DoNotGenerateAcw=true)]
	internal class IUIKeyboardInteractiveInvoker : global::Java.Lang.Object, IUIKeyboardInteractive {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/jcraft/jsch/UIKeyboardInteractive");
		IntPtr class_ref;

		public static IUIKeyboardInteractive GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUIKeyboardInteractive> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.jcraft.jsch.UIKeyboardInteractive"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUIKeyboardInteractiveInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IUIKeyboardInteractiveInvoker); }
		}

		static Delegate cb_promptKeyboardInteractive_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_arrayZ;
#pragma warning disable 0169
		static Delegate GetPromptKeyboardInteractive_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_arrayZHandler ()
		{
			if (cb_promptKeyboardInteractive_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_arrayZ == null)
				cb_promptKeyboardInteractive_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_arrayZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PromptKeyboardInteractive_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_arrayZ);
			return cb_promptKeyboardInteractive_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_arrayZ;
		}

		static IntPtr n_PromptKeyboardInteractive_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_arrayZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Jcraft.Jsch.IUIKeyboardInteractive __this = global::Java.Lang.Object.GetObject<global::Com.Jcraft.Jsch.IUIKeyboardInteractive> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string[] p3 = (string[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (string));
			bool[] p4 = (bool[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (bool));
			IntPtr __ret = JNIEnv.NewArray (__this.PromptKeyboardInteractive (p0, p1, p2, p3, p4));
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_promptKeyboardInteractive_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_arrayZ;
		public string[] PromptKeyboardInteractive (string p0, string p1, string p2, string[] p3, bool[] p4)
		{
			if (id_promptKeyboardInteractive_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_arrayZ == IntPtr.Zero)
				id_promptKeyboardInteractive_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_arrayZ = JNIEnv.GetMethodID (class_ref, "promptKeyboardInteractive", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;[Z)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_promptKeyboardInteractive_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_arrayZ, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4)), JniHandleOwnership.TransferLocalRef, typeof (string));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			return __ret;
		}

	}

}

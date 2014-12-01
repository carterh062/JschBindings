using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jcraft.Jsch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jcraft.jsch']/class[@name='Request']"
	[global::Android.Runtime.Register ("com/jcraft/jsch/Request", DoNotGenerateAcw=true)]
	public abstract partial class Request : global::Java.Lang.Object {

		protected Request (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}

	[global::Android.Runtime.Register ("com/jcraft/jsch/Request", DoNotGenerateAcw=true)]
	internal partial class RequestInvoker : Request {

		public RequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestInvoker); }
		}

	}

}

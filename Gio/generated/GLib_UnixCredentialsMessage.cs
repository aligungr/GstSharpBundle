// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class UnixCredentialsMessage : GLib.SocketControlMessage {

		public UnixCredentialsMessage (IntPtr raw) : base(raw) {}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_unix_credentials_message_new();

		public UnixCredentialsMessage () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (UnixCredentialsMessage)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = g_unix_credentials_message_new();
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_unix_credentials_message_new_with_credentials(IntPtr credentials);

		public UnixCredentialsMessage (GLib.Credentials credentials) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (UnixCredentialsMessage)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (credentials != null) {
					names.Add ("credentials");
					vals.Add (new GLib.Value (credentials));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = g_unix_credentials_message_new_with_credentials(credentials == null ? IntPtr.Zero : credentials.Handle);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_unix_credentials_message_get_credentials(IntPtr raw);

		[GLib.Property ("credentials")]
		public GLib.Credentials Credentials {
			get  {
				IntPtr raw_ret = g_unix_credentials_message_get_credentials(Handle);
				GLib.Credentials ret = GLib.Object.GetObject(raw_ret) as GLib.Credentials;
				return ret;
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_unix_credentials_message_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_unix_credentials_message_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_unix_credentials_message_is_supported();

		public static bool IsSupported { 
			get {
				bool raw_ret = g_unix_credentials_message_is_supported();
				bool ret = raw_ret;
				return ret;
			}
		}

#endregion
	}
}

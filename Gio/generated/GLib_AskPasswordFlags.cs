// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (GLib.AskPasswordFlagsGType))]
	public enum AskPasswordFlags : uint {

		NeedPassword = 1 << 0,
		NeedUsername = 1 << 1,
		NeedDomain = 1 << 2,
		SavingSupported = 1 << 3,
		AnonymousSupported = 1 << 4,
	}

	internal class AskPasswordFlagsGType {
		[DllImport ("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_ask_password_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_ask_password_flags_get_type ());
			}
		}
	}
#endregion
}

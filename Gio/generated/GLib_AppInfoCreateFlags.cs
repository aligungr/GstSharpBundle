// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (GLib.AppInfoCreateFlagsGType))]
	public enum AppInfoCreateFlags : uint {

		None,
		NeedsTerminal = 1 << 0,
		SupportsUris = 1 << 1,
		SupportsStartupNotification = 1 << 2,
	}

	internal class AppInfoCreateFlagsGType {
		[DllImport ("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_app_info_create_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_app_info_create_flags_get_type ());
			}
		}
	}
#endregion
}

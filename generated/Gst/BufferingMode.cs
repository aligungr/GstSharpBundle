// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gst.BufferingModeGType))]
	public enum BufferingMode {

		Stream = 0,
		Download = 1,
		Timeshift = 2,
		Live = 3,
	}

	internal class BufferingModeGType {
		[DllImport ("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_buffering_mode_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_buffering_mode_get_type ());
			}
		}
	}
#endregion
}

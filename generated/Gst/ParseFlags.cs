// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.ParseFlagsGType))]
	public enum ParseFlags : uint {

		None = 0,
		FatalErrors = 1,
		NoSingleElementBins = 2,
		PlaceInBin = 4,
	}

	internal class ParseFlagsGType {
		[DllImport ("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_parse_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_parse_flags_get_type ());
			}
		}
	}
#endregion
}

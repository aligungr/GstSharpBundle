// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Audio {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.Audio.AudioChannelMixerFlagsGType))]
	public enum AudioChannelMixerFlags : uint {

		None = 0,
		NonInterleavedIn = 1,
		NonInterleavedOut = 2,
		UnpositionedIn = 4,
		UnpositionedOut = 8,
	}

	internal class AudioChannelMixerFlagsGType {
		[DllImport ("gstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_audio_channel_mixer_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_audio_channel_mixer_flags_get_type ());
			}
		}
	}
#endregion
}

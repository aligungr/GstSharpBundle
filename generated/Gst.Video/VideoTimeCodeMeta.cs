// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct VideoTimeCodeMeta : IEquatable<VideoTimeCodeMeta> {

		public Gst.Meta Meta;
		public Gst.Video.VideoTimeCode Tc;

		public static Gst.Video.VideoTimeCodeMeta Zero = new Gst.Video.VideoTimeCodeMeta ();

		public static Gst.Video.VideoTimeCodeMeta New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Video.VideoTimeCodeMeta.Zero;
			return (Gst.Video.VideoTimeCodeMeta) Marshal.PtrToStructure (raw, typeof (Gst.Video.VideoTimeCodeMeta));
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_time_code_meta_get_info();

		public static Gst.MetaInfo Info { 
			get {
				IntPtr raw_ret = gst_video_time_code_meta_get_info();
				Gst.MetaInfo ret = Gst.MetaInfo.New (raw_ret);
				return ret;
			}
		}

		public bool Equals (VideoTimeCodeMeta other)
		{
			return true && Meta.Equals (other.Meta) && Tc.Equals (other.Tc);
		}

		public override bool Equals (object other)
		{
			return other is VideoTimeCodeMeta && Equals ((VideoTimeCodeMeta) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Meta.GetHashCode () ^ Tc.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}

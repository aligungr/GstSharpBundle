// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class VideoScaler : GLib.Opaque {

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_video_scaler_2d(IntPtr raw, IntPtr vscale, int format, IntPtr src, int src_stride, IntPtr dest, int dest_stride, uint x, uint y, uint width, uint height);

		public void TwoD(Gst.Video.VideoScaler vscale, Gst.Video.VideoFormat format, IntPtr src, int src_stride, IntPtr dest, int dest_stride, uint x, uint y, uint width, uint height) {
			gst_video_scaler_2d(Handle, vscale == null ? IntPtr.Zero : vscale.Handle, (int) format, src, src_stride, dest, dest_stride, x, y, width, height);
		}

		public void TwoD(Gst.Video.VideoScaler vscale, Gst.Video.VideoFormat format, int src_stride, int dest_stride, uint x, uint y, uint width, uint height) {
			TwoD (vscale, format, IntPtr.Zero, src_stride, IntPtr.Zero, dest_stride, x, y, width, height);
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double gst_video_scaler_get_coeff(IntPtr raw, uint out_offset, out uint in_offset, out uint n_taps);

		public double GetCoeff(uint out_offset, out uint in_offset, out uint n_taps) {
			double raw_ret = gst_video_scaler_get_coeff(Handle, out_offset, out in_offset, out n_taps);
			double ret = raw_ret;
			return ret;
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_video_scaler_get_max_taps(IntPtr raw);

		public uint MaxTaps { 
			get {
				uint raw_ret = gst_video_scaler_get_max_taps(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_video_scaler_horizontal(IntPtr raw, int format, IntPtr src, IntPtr dest, uint dest_offset, uint width);

		public void Horizontal(Gst.Video.VideoFormat format, IntPtr src, IntPtr dest, uint dest_offset, uint width) {
			gst_video_scaler_horizontal(Handle, (int) format, src, dest, dest_offset, width);
		}

		public void Horizontal(Gst.Video.VideoFormat format, uint dest_offset, uint width) {
			Horizontal (format, IntPtr.Zero, IntPtr.Zero, dest_offset, width);
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_video_scaler_vertical(IntPtr raw, int format, IntPtr src_lines, IntPtr dest, uint dest_offset, uint width);

		public void Vertical(Gst.Video.VideoFormat format, IntPtr src_lines, IntPtr dest, uint dest_offset, uint width) {
			gst_video_scaler_vertical(Handle, (int) format, src_lines, dest, dest_offset, width);
		}

		public void Vertical(Gst.Video.VideoFormat format, uint dest_offset, uint width) {
			Vertical (format, IntPtr.Zero, IntPtr.Zero, dest_offset, width);
		}

		public VideoScaler(IntPtr raw) : base(raw) {}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_video_scaler_free(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			gst_video_scaler_free (raw);
		}

		protected override Action<IntPtr> DisposeUnmanagedFunc {
			get {
				return gst_video_scaler_free;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}

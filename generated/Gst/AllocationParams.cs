// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct AllocationParams : IEquatable<AllocationParams> {

		public Gst.MemoryFlags Flags;
		private UIntPtr align;
		public ulong Align {
			get {
				return (ulong) align;
			}
			set {
				align = new UIntPtr (value);
			}
		}
		private UIntPtr prefix;
		public ulong Prefix {
			get {
				return (ulong) prefix;
			}
			set {
				prefix = new UIntPtr (value);
			}
		}
		private UIntPtr padding;
		public ulong Padding {
			get {
				return (ulong) padding;
			}
			set {
				padding = new UIntPtr (value);
			}
		}
		[MarshalAs (UnmanagedType.ByValArray, SizeConst=4)]
		private IntPtr[] _gstGstReserved;

		public static Gst.AllocationParams Zero = new Gst.AllocationParams ();

		public static Gst.AllocationParams New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.AllocationParams.Zero;
			return (Gst.AllocationParams) Marshal.PtrToStructure (raw, typeof (Gst.AllocationParams));
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_allocation_params_new();

		public static AllocationParams New()
		{
			AllocationParams result = AllocationParams.New (gst_allocation_params_new());
			return result;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_allocation_params_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_allocation_params_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_allocation_params_init(IntPtr raw);

		public void Init() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			gst_allocation_params_init(this_as_native);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		static void ReadNative (IntPtr native, ref Gst.AllocationParams target)
		{
			target = New (native);
		}

		public bool Equals (AllocationParams other)
		{
			return true && Flags.Equals (other.Flags) && Align.Equals (other.Align) && Prefix.Equals (other.Prefix) && Padding.Equals (other.Padding);
		}

		public override bool Equals (object other)
		{
			return other is AllocationParams && Equals ((AllocationParams) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Flags.GetHashCode () ^ Align.GetHashCode () ^ Prefix.GetHashCode () ^ Padding.GetHashCode ();
		}

		public static explicit operator GLib.Value (Gst.AllocationParams boxed)
		{
			GLib.Value val = GLib.Value.Empty;
			val.Init (Gst.AllocationParams.GType);
			val.Val = boxed;
			return val;
		}

		public static explicit operator Gst.AllocationParams (GLib.Value val)
		{
			return (Gst.AllocationParams) val.Val;
		}
#endregion
	}
}

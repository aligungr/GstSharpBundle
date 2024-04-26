// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ProtectionMeta : IEquatable<ProtectionMeta> {

		public Gst.Meta Meta;
		private IntPtr _info;
		public Gst.Structure Info {
			get {
				return _info == IntPtr.Zero ? null : (Gst.Structure) GLib.Opaque.GetOpaque (_info, typeof (Gst.Structure), false);
			}
			set {
				_info = value == null ? IntPtr.Zero : value.Handle;
			}
		}

		public static Gst.ProtectionMeta Zero = new Gst.ProtectionMeta ();

		public static Gst.ProtectionMeta New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.ProtectionMeta.Zero;
			return (Gst.ProtectionMeta) Marshal.PtrToStructure (raw, typeof (Gst.ProtectionMeta));
		}

		public bool Equals (ProtectionMeta other)
		{
			return true && Meta.Equals (other.Meta) && Info.Equals (other.Info);
		}

		public override bool Equals (object other)
		{
			return other is ProtectionMeta && Equals ((ProtectionMeta) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Meta.GetHashCode () ^ Info.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}

// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Controller {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TimedValueControlSource : Gst.ControlSource {

		protected TimedValueControlSource (IntPtr raw) : base(raw) {}

		protected TimedValueControlSource() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		public GLib.Mutex Lock {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("lock"));
					return new GLib.Mutex((*raw_ptr));
				}
			}
		}

		public int Nvalues {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("nvalues"));
					return (*raw_ptr);
				}
			}
		}

		public bool ValidCache {
			get {
				unsafe {
					bool* raw_ptr = (bool*)(((byte*)Handle) + abi_info.GetFieldOffset("valid_cache"));
					return (*raw_ptr);
				}
			}
		}

		[GLib.Signal("value-removed")]
		public event Gst.Controller.ValueRemovedHandler ValueRemoved {
			add {
				this.AddSignalHandler ("value-removed", value, typeof (Gst.Controller.ValueRemovedArgs));
			}
			remove {
				this.RemoveSignalHandler ("value-removed", value);
			}
		}

		[GLib.Signal("value-added")]
		public event Gst.Controller.ValueAddedHandler ValueAdded {
			add {
				this.AddSignalHandler ("value-added", value, typeof (Gst.Controller.ValueAddedArgs));
			}
			remove {
				this.RemoveSignalHandler ("value-added", value);
			}
		}

		[GLib.Signal("value-changed")]
		public event Gst.Controller.ValueChangedHandler ValueChanged {
			add {
				this.AddSignalHandler ("value-changed", value, typeof (Gst.Controller.ValueChangedArgs));
			}
			remove {
				this.RemoveSignalHandler ("value-changed", value);
			}
		}

		static ValueAddedNativeDelegate ValueAdded_cb_delegate;
		static ValueAddedNativeDelegate ValueAddedVMCallback {
			get {
				if (ValueAdded_cb_delegate == null)
					ValueAdded_cb_delegate = new ValueAddedNativeDelegate (ValueAdded_cb);
				return ValueAdded_cb_delegate;
			}
		}

		static void OverrideValueAdded (GLib.GType gtype)
		{
			OverrideValueAdded (gtype, ValueAddedVMCallback);
		}

		static void OverrideValueAdded (GLib.GType gtype, ValueAddedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "value-added", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ValueAddedNativeDelegate (IntPtr inst, IntPtr timed_value);

		static void ValueAdded_cb (IntPtr inst, IntPtr timed_value)
		{
			try {
				TimedValueControlSource __obj = GLib.Object.GetObject (inst, false) as TimedValueControlSource;
				__obj.OnValueAdded (Gst.Controller.ControlPoint.New (timed_value));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Controller.TimedValueControlSource), ConnectionMethod="OverrideValueAdded")]
		protected virtual void OnValueAdded (Gst.Controller.ControlPoint timed_value)
		{
			InternalValueAdded (timed_value);
		}

		private void InternalValueAdded (Gst.Controller.ControlPoint timed_value)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray ((uint)2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (timed_value);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static ValueChangedNativeDelegate ValueChanged_cb_delegate;
		static ValueChangedNativeDelegate ValueChangedVMCallback {
			get {
				if (ValueChanged_cb_delegate == null)
					ValueChanged_cb_delegate = new ValueChangedNativeDelegate (ValueChanged_cb);
				return ValueChanged_cb_delegate;
			}
		}

		static void OverrideValueChanged (GLib.GType gtype)
		{
			OverrideValueChanged (gtype, ValueChangedVMCallback);
		}

		static void OverrideValueChanged (GLib.GType gtype, ValueChangedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "value-changed", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ValueChangedNativeDelegate (IntPtr inst, IntPtr timed_value);

		static void ValueChanged_cb (IntPtr inst, IntPtr timed_value)
		{
			try {
				TimedValueControlSource __obj = GLib.Object.GetObject (inst, false) as TimedValueControlSource;
				__obj.OnValueChanged (Gst.Controller.ControlPoint.New (timed_value));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Controller.TimedValueControlSource), ConnectionMethod="OverrideValueChanged")]
		protected virtual void OnValueChanged (Gst.Controller.ControlPoint timed_value)
		{
			InternalValueChanged (timed_value);
		}

		private void InternalValueChanged (Gst.Controller.ControlPoint timed_value)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray ((uint)2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (timed_value);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static ValueRemovedNativeDelegate ValueRemoved_cb_delegate;
		static ValueRemovedNativeDelegate ValueRemovedVMCallback {
			get {
				if (ValueRemoved_cb_delegate == null)
					ValueRemoved_cb_delegate = new ValueRemovedNativeDelegate (ValueRemoved_cb);
				return ValueRemoved_cb_delegate;
			}
		}

		static void OverrideValueRemoved (GLib.GType gtype)
		{
			OverrideValueRemoved (gtype, ValueRemovedVMCallback);
		}

		static void OverrideValueRemoved (GLib.GType gtype, ValueRemovedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "value-removed", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ValueRemovedNativeDelegate (IntPtr inst, IntPtr timed_value);

		static void ValueRemoved_cb (IntPtr inst, IntPtr timed_value)
		{
			try {
				TimedValueControlSource __obj = GLib.Object.GetObject (inst, false) as TimedValueControlSource;
				__obj.OnValueRemoved (Gst.Controller.ControlPoint.New (timed_value));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Controller.TimedValueControlSource), ConnectionMethod="OverrideValueRemoved")]
		protected virtual void OnValueRemoved (Gst.Controller.ControlPoint timed_value)
		{
			InternalValueRemoved (timed_value);
		}

		private void InternalValueRemoved (Gst.Controller.ControlPoint timed_value)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray ((uint)2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (timed_value);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gst_reserved"
							, Gst.ControlSource.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("gstcontroller-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_timed_value_control_source_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_timed_value_control_source_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gstcontroller-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_timed_value_control_source_get_all(IntPtr raw);

		public GLib.List[] All { 
			get {
				IntPtr raw_ret = gst_timed_value_control_source_get_all(Handle);
				GLib.List[] ret = (GLib.List[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), false, true, typeof(GLib.List));
				return ret;
			}
		}

		[DllImport("gstcontroller-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_timed_value_control_source_get_count(IntPtr raw);

		public int Count { 
			get {
				int raw_ret = gst_timed_value_control_source_get_count(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gstcontroller-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_timed_value_control_source_set(IntPtr raw, ulong timestamp, double value);

		public bool Set(ulong timestamp, double value) {
			bool raw_ret = gst_timed_value_control_source_set(Handle, timestamp, value);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstcontroller-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_timed_value_control_source_set_from_list(IntPtr raw, IntPtr timedvalues);

		public bool SetFromList(GLib.SList timedvalues) {
			bool raw_ret = gst_timed_value_control_source_set_from_list(Handle, timedvalues == null ? IntPtr.Zero : timedvalues.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstcontroller-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_timed_value_control_source_unset(IntPtr raw, ulong timestamp);

		public bool Unset(ulong timestamp) {
			bool raw_ret = gst_timed_value_control_source_unset(Handle, timestamp);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstcontroller-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_timed_value_control_source_unset_all(IntPtr raw);

		public void UnsetAll() {
			gst_timed_value_control_source_unset_all(Handle);
		}


		static TimedValueControlSource ()
		{
			GtkSharp.GstreamerSharp.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("lock"
							, Gst.ControlSource.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // lock
							, null
							, "values"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("values"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // values
							, "lock"
							, "nvalues"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("nvalues"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) // nvalues
							, "values"
							, "valid_cache"
							, (long) Marshal.OffsetOf(typeof(GstTimedValueControlSource_nvaluesAlign), "nvalues")
							, 0
							),
						new GLib.AbiField("valid_cache"
							, -1
							, (uint) Marshal.SizeOf(typeof(bool)) // valid_cache
							, "nvalues"
							, "priv"
							, (long) Marshal.OffsetOf(typeof(GstTimedValueControlSource_valid_cacheAlign), "valid_cache")
							, 0
							),
						new GLib.AbiField("priv"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, "valid_cache"
							, "_gst_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
							, "priv"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstTimedValueControlSource_nvaluesAlign
		{
			sbyte f1;
			private int nvalues;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstTimedValueControlSource_valid_cacheAlign
		{
			sbyte f1;
			private bool valid_cache;
		}


		// End of the ABI representation.

#endregion
	}
}

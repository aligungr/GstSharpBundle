// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Clock : Gst.Object {

		protected Clock (IntPtr raw) : base(raw) {}

		protected Clock() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern ulong gst_clock_get_timeout(IntPtr raw);

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_clock_set_timeout(IntPtr raw, ulong timeout);

		[GLib.Property ("timeout")]
		public ulong Timeout {
			get  {
				ulong raw_ret = gst_clock_get_timeout(Handle);
				ulong ret = raw_ret;
				return ret;
			}
			set  {
				gst_clock_set_timeout(Handle, value);
			}
		}

		[GLib.Property ("window-size")]
		public int WindowSize {
			get {
				GLib.Value val = GetProperty ("window-size");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("window-size", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("window-threshold")]
		public int WindowThreshold {
			get {
				GLib.Value val = GetProperty ("window-threshold");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("window-threshold", val);
				val.Dispose ();
			}
		}

		[GLib.Signal("synced")]
		public event Gst.SyncedHandler Synced {
			add {
				this.AddSignalHandler ("synced", value, typeof (Gst.SyncedArgs));
			}
			remove {
				this.RemoveSignalHandler ("synced", value);
			}
		}

		static SyncedNativeDelegate Synced_cb_delegate;
		static SyncedNativeDelegate SyncedVMCallback {
			get {
				if (Synced_cb_delegate == null)
					Synced_cb_delegate = new SyncedNativeDelegate (Synced_cb);
				return Synced_cb_delegate;
			}
		}

		static void OverrideSynced (GLib.GType gtype)
		{
			OverrideSynced (gtype, SyncedVMCallback);
		}

		static void OverrideSynced (GLib.GType gtype, SyncedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "synced", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SyncedNativeDelegate (IntPtr inst, bool synced);

		static void Synced_cb (IntPtr inst, bool synced)
		{
			try {
				Clock __obj = GLib.Object.GetObject (inst, false) as Clock;
				__obj.OnSynced (synced);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Clock), ConnectionMethod="OverrideSynced")]
		protected virtual void OnSynced (bool synced)
		{
			InternalSynced (synced);
		}

		private void InternalSynced (bool synced)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray ((uint)2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (synced);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static ChangeResolutionNativeDelegate ChangeResolution_cb_delegate;
		static ChangeResolutionNativeDelegate ChangeResolutionVMCallback {
			get {
				if (ChangeResolution_cb_delegate == null)
					ChangeResolution_cb_delegate = new ChangeResolutionNativeDelegate (ChangeResolution_cb);
				return ChangeResolution_cb_delegate;
			}
		}

		static void OverrideChangeResolution (GLib.GType gtype)
		{
			OverrideChangeResolution (gtype, ChangeResolutionVMCallback);
		}

		static void OverrideChangeResolution (GLib.GType gtype, ChangeResolutionNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("change_resolution"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate ulong ChangeResolutionNativeDelegate (IntPtr inst, ulong old_resolution, ulong new_resolution);

		static ulong ChangeResolution_cb (IntPtr inst, ulong old_resolution, ulong new_resolution)
		{
			try {
				Clock __obj = GLib.Object.GetObject (inst, false) as Clock;
				ulong __result;
				__result = __obj.OnChangeResolution (old_resolution, new_resolution);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Clock), ConnectionMethod="OverrideChangeResolution")]
		protected virtual ulong OnChangeResolution (ulong old_resolution, ulong new_resolution)
		{
			return InternalChangeResolution (old_resolution, new_resolution);
		}

		private ulong InternalChangeResolution (ulong old_resolution, ulong new_resolution)
		{
			ChangeResolutionNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("change_resolution"));
				unmanaged = (ChangeResolutionNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ChangeResolutionNativeDelegate));
			}
			if (unmanaged == null) return 0;

			ulong __result = unmanaged (this.Handle, old_resolution, new_resolution);
			return __result;
		}

		static GetResolutionNativeDelegate GetResolution_cb_delegate;
		static GetResolutionNativeDelegate GetResolutionVMCallback {
			get {
				if (GetResolution_cb_delegate == null)
					GetResolution_cb_delegate = new GetResolutionNativeDelegate (GetResolution_cb);
				return GetResolution_cb_delegate;
			}
		}

		static void OverrideGetResolution (GLib.GType gtype)
		{
			OverrideGetResolution (gtype, GetResolutionVMCallback);
		}

		static void OverrideGetResolution (GLib.GType gtype, GetResolutionNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_resolution"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate ulong GetResolutionNativeDelegate (IntPtr inst);

		static ulong GetResolution_cb (IntPtr inst)
		{
			try {
				Clock __obj = GLib.Object.GetObject (inst, false) as Clock;
				ulong __result;
				__result = __obj.OnGetResolution ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Clock), ConnectionMethod="OverrideGetResolution")]
		protected virtual ulong OnGetResolution ()
		{
			return InternalGetResolution ();
		}

		private ulong InternalGetResolution ()
		{
			GetResolutionNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_resolution"));
				unmanaged = (GetResolutionNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetResolutionNativeDelegate));
			}
			if (unmanaged == null) return 0;

			ulong __result = unmanaged (this.Handle);
			return __result;
		}

		static GetInternalTimeNativeDelegate GetInternalTime_cb_delegate;
		static GetInternalTimeNativeDelegate GetInternalTimeVMCallback {
			get {
				if (GetInternalTime_cb_delegate == null)
					GetInternalTime_cb_delegate = new GetInternalTimeNativeDelegate (GetInternalTime_cb);
				return GetInternalTime_cb_delegate;
			}
		}

		static void OverrideGetInternalTime (GLib.GType gtype)
		{
			OverrideGetInternalTime (gtype, GetInternalTimeVMCallback);
		}

		static void OverrideGetInternalTime (GLib.GType gtype, GetInternalTimeNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_internal_time"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate ulong GetInternalTimeNativeDelegate (IntPtr inst);

		static ulong GetInternalTime_cb (IntPtr inst)
		{
			try {
				Clock __obj = GLib.Object.GetObject (inst, false) as Clock;
				ulong __result;
				__result = __obj.OnGetInternalTime ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Clock), ConnectionMethod="OverrideGetInternalTime")]
		protected virtual ulong OnGetInternalTime ()
		{
			return InternalGetInternalTime ();
		}

		private ulong InternalGetInternalTime ()
		{
			GetInternalTimeNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_internal_time"));
				unmanaged = (GetInternalTimeNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetInternalTimeNativeDelegate));
			}
			if (unmanaged == null) return 0;

			ulong __result = unmanaged (this.Handle);
			return __result;
		}

		static WaitNativeDelegate Wait_cb_delegate;
		static WaitNativeDelegate WaitVMCallback {
			get {
				if (Wait_cb_delegate == null)
					Wait_cb_delegate = new WaitNativeDelegate (Wait_cb);
				return Wait_cb_delegate;
			}
		}

		static void OverrideWait (GLib.GType gtype)
		{
			OverrideWait (gtype, WaitVMCallback);
		}

		static void OverrideWait (GLib.GType gtype, WaitNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("wait"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int WaitNativeDelegate (IntPtr inst, IntPtr entry, out long jitter);

		static int Wait_cb (IntPtr inst, IntPtr entry, out long jitter)
		{
			try {
				Clock __obj = GLib.Object.GetObject (inst, false) as Clock;
				Gst.ClockReturn __result;
				__result = __obj.OnWait (entry == IntPtr.Zero ? null : (Gst.ClockEntry) GLib.Opaque.GetOpaque (entry, typeof (Gst.ClockEntry), false), out jitter);
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Clock), ConnectionMethod="OverrideWait")]
		protected virtual Gst.ClockReturn OnWait (Gst.ClockEntry entry, out long jitter)
		{
			return InternalWait (entry, out jitter);
		}

		private Gst.ClockReturn InternalWait (Gst.ClockEntry entry, out long jitter)
		{
			WaitNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("wait"));
				unmanaged = (WaitNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(WaitNativeDelegate));
			}
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			int __result = unmanaged (this.Handle, entry == null ? IntPtr.Zero : entry.Handle, out jitter);
			return (Gst.ClockReturn) __result;
		}

		static WaitAsyncNativeDelegate WaitAsync_cb_delegate;
		static WaitAsyncNativeDelegate WaitAsyncVMCallback {
			get {
				if (WaitAsync_cb_delegate == null)
					WaitAsync_cb_delegate = new WaitAsyncNativeDelegate (WaitAsync_cb);
				return WaitAsync_cb_delegate;
			}
		}

		static void OverrideWaitAsync (GLib.GType gtype)
		{
			OverrideWaitAsync (gtype, WaitAsyncVMCallback);
		}

		static void OverrideWaitAsync (GLib.GType gtype, WaitAsyncNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("wait_async"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int WaitAsyncNativeDelegate (IntPtr inst, IntPtr entry);

		static int WaitAsync_cb (IntPtr inst, IntPtr entry)
		{
			try {
				Clock __obj = GLib.Object.GetObject (inst, false) as Clock;
				Gst.ClockReturn __result;
				__result = __obj.OnWaitAsync (entry == IntPtr.Zero ? null : (Gst.ClockEntry) GLib.Opaque.GetOpaque (entry, typeof (Gst.ClockEntry), false));
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Clock), ConnectionMethod="OverrideWaitAsync")]
		protected virtual Gst.ClockReturn OnWaitAsync (Gst.ClockEntry entry)
		{
			return InternalWaitAsync (entry);
		}

		private Gst.ClockReturn InternalWaitAsync (Gst.ClockEntry entry)
		{
			WaitAsyncNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("wait_async"));
				unmanaged = (WaitAsyncNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(WaitAsyncNativeDelegate));
			}
			if (unmanaged == null) return (Gst.ClockReturn) 0;

			int __result = unmanaged (this.Handle, entry == null ? IntPtr.Zero : entry.Handle);
			return (Gst.ClockReturn) __result;
		}

		static UnscheduleNativeDelegate Unschedule_cb_delegate;
		static UnscheduleNativeDelegate UnscheduleVMCallback {
			get {
				if (Unschedule_cb_delegate == null)
					Unschedule_cb_delegate = new UnscheduleNativeDelegate (Unschedule_cb);
				return Unschedule_cb_delegate;
			}
		}

		static void OverrideUnschedule (GLib.GType gtype)
		{
			OverrideUnschedule (gtype, UnscheduleVMCallback);
		}

		static void OverrideUnschedule (GLib.GType gtype, UnscheduleNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("unschedule"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void UnscheduleNativeDelegate (IntPtr inst, IntPtr entry);

		static void Unschedule_cb (IntPtr inst, IntPtr entry)
		{
			try {
				Clock __obj = GLib.Object.GetObject (inst, false) as Clock;
				__obj.OnUnschedule (entry == IntPtr.Zero ? null : (Gst.ClockEntry) GLib.Opaque.GetOpaque (entry, typeof (Gst.ClockEntry), false));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Clock), ConnectionMethod="OverrideUnschedule")]
		protected virtual void OnUnschedule (Gst.ClockEntry entry)
		{
			InternalUnschedule (entry);
		}

		private void InternalUnschedule (Gst.ClockEntry entry)
		{
			UnscheduleNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("unschedule"));
				unmanaged = (UnscheduleNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(UnscheduleNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, entry == null ? IntPtr.Zero : entry.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("change_resolution"
							, Gst.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // change_resolution
							, null
							, "get_resolution"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("get_resolution"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_resolution
							, "change_resolution"
							, "get_internal_time"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("get_internal_time"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_internal_time
							, "get_resolution"
							, "wait"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("wait"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // wait
							, "get_internal_time"
							, "wait_async"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("wait_async"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // wait_async
							, "wait"
							, "unschedule"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("unschedule"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // unschedule
							, "wait_async"
							, "_gst_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
							, "unschedule"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_clock_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_clock_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_clock_id_compare_func(IntPtr id1, IntPtr id2);

		public static int IdCompareFunc(IntPtr id1, IntPtr id2) {
			int raw_ret = gst_clock_id_compare_func(id1, id2);
			int ret = raw_ret;
			return ret;
		}

		public static int IdCompareFunc() {
			return IdCompareFunc (IntPtr.Zero, IntPtr.Zero);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_clock_id_get_clock(IntPtr id);

		public static Gst.Clock IdGetClock(IntPtr id) {
			IntPtr raw_ret = gst_clock_id_get_clock(id);
			Gst.Clock ret = GLib.Object.GetObject(raw_ret, true) as Gst.Clock;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern ulong gst_clock_id_get_time(IntPtr id);

		public static ulong IdGetTime(IntPtr id) {
			ulong raw_ret = gst_clock_id_get_time(id);
			ulong ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_clock_id_ref(IntPtr id);

		public static IntPtr IdRef(IntPtr id) {
			IntPtr raw_ret = gst_clock_id_ref(id);
			IntPtr ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_clock_id_unref(IntPtr id);

		public static void IdUnref(IntPtr id) {
			gst_clock_id_unref(id);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_clock_id_unschedule(IntPtr id);

		public static void IdUnschedule(IntPtr id) {
			gst_clock_id_unschedule(id);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_clock_id_uses_clock(IntPtr id, IntPtr clock);

		public static bool IdUsesClock(IntPtr id, Gst.Clock clock) {
			bool raw_ret = gst_clock_id_uses_clock(id, clock == null ? IntPtr.Zero : clock.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_clock_id_wait(IntPtr id, out long jitter);

		public static Gst.ClockReturn IdWait(IntPtr id, out long jitter) {
			int raw_ret = gst_clock_id_wait(id, out jitter);
			Gst.ClockReturn ret = (Gst.ClockReturn) raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_clock_id_wait_async(IntPtr id, GstSharp.ClockCallbackNative func, IntPtr user_data, GLib.DestroyNotify destroy_data);

		public static Gst.ClockReturn IdWaitAsync(IntPtr id, Gst.ClockCallback func) {
			GstSharp.ClockCallbackWrapper func_wrapper = new GstSharp.ClockCallbackWrapper (func);
			IntPtr user_data;
			GLib.DestroyNotify destroy_data;
			if (func == null) {
				user_data = IntPtr.Zero;
				destroy_data = null;
			} else {
				user_data = (IntPtr) GCHandle.Alloc (func_wrapper);
				destroy_data = GLib.DestroyHelper.NotifyHandler;
			}
			int raw_ret = gst_clock_id_wait_async(id, func_wrapper.NativeDelegate, user_data, destroy_data);
			Gst.ClockReturn ret = (Gst.ClockReturn) raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_clock_add_observation(IntPtr raw, ulong slave, ulong master, out double r_squared);

		public bool AddObservation(ulong slave, ulong master, out double r_squared) {
			bool raw_ret = gst_clock_add_observation(Handle, slave, master, out r_squared);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_clock_add_observation_unapplied(IntPtr raw, ulong slave, ulong master, out double r_squared, out ulong _internal, out ulong external, out ulong rate_num, out ulong rate_denom);

		public bool AddObservationUnapplied(ulong slave, ulong master, out double r_squared, out ulong _internal, out ulong external, out ulong rate_num, out ulong rate_denom) {
			bool raw_ret = gst_clock_add_observation_unapplied(Handle, slave, master, out r_squared, out _internal, out external, out rate_num, out rate_denom);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern ulong gst_clock_adjust_unlocked(IntPtr raw, ulong _internal);

		public ulong AdjustUnlocked(ulong _internal) {
			ulong raw_ret = gst_clock_adjust_unlocked(Handle, _internal);
			ulong ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern ulong gst_clock_adjust_with_calibration(IntPtr raw, ulong internal_target, ulong cinternal, ulong cexternal, ulong cnum, ulong cdenom);

		public ulong AdjustWithCalibration(ulong internal_target, ulong cinternal, ulong cexternal, ulong cnum, ulong cdenom) {
			ulong raw_ret = gst_clock_adjust_with_calibration(Handle, internal_target, cinternal, cexternal, cnum, cdenom);
			ulong ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_clock_get_calibration(IntPtr raw, out ulong _internal, out ulong external, out ulong rate_num, out ulong rate_denom);

		public void GetCalibration(out ulong _internal, out ulong external, out ulong rate_num, out ulong rate_denom) {
			gst_clock_get_calibration(Handle, out _internal, out external, out rate_num, out rate_denom);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern ulong gst_clock_get_internal_time(IntPtr raw);

		public ulong InternalTime { 
			get {
				ulong raw_ret = gst_clock_get_internal_time(Handle);
				ulong ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_clock_get_master(IntPtr raw);

		public Gst.Clock Master { 
			get {
				IntPtr raw_ret = gst_clock_get_master(Handle);
				Gst.Clock ret = GLib.Object.GetObject(raw_ret, true) as Gst.Clock;
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern ulong gst_clock_get_resolution(IntPtr raw);

		public ulong Resolution { 
			get {
				ulong raw_ret = gst_clock_get_resolution(Handle);
				ulong ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern ulong gst_clock_get_time(IntPtr raw);

		public ulong Time { 
			get {
				ulong raw_ret = gst_clock_get_time(Handle);
				ulong ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_clock_is_synced(IntPtr raw);

		public bool IsSynced { 
			get {
				bool raw_ret = gst_clock_is_synced(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_clock_new_periodic_id(IntPtr raw, ulong start_time, ulong interval);

		public IntPtr NewPeriodicId(ulong start_time, ulong interval) {
			IntPtr raw_ret = gst_clock_new_periodic_id(Handle, start_time, interval);
			IntPtr ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_clock_new_single_shot_id(IntPtr raw, ulong time);

		public IntPtr NewSingleShotId(ulong time) {
			IntPtr raw_ret = gst_clock_new_single_shot_id(Handle, time);
			IntPtr ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_clock_periodic_id_reinit(IntPtr raw, IntPtr id, ulong start_time, ulong interval);

		public bool PeriodicIdReinit(IntPtr id, ulong start_time, ulong interval) {
			bool raw_ret = gst_clock_periodic_id_reinit(Handle, id, start_time, interval);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_clock_set_calibration(IntPtr raw, ulong _internal, ulong external, ulong rate_num, ulong rate_denom);

		public void SetCalibration(ulong _internal, ulong external, ulong rate_num, ulong rate_denom) {
			gst_clock_set_calibration(Handle, _internal, external, rate_num, rate_denom);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_clock_set_master(IntPtr raw, IntPtr master);

		public bool SetMaster(Gst.Clock master) {
			bool raw_ret = gst_clock_set_master(Handle, master == null ? IntPtr.Zero : master.Handle);
			bool ret = raw_ret;
			return ret;
		}

		public bool SetMaster() {
			return SetMaster (null);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern ulong gst_clock_set_resolution(IntPtr raw, ulong resolution);

		public ulong SetResolution(ulong resolution) {
			ulong raw_ret = gst_clock_set_resolution(Handle, resolution);
			ulong ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_clock_set_synced(IntPtr raw, bool synced);

		public void is_synced(bool synced) {
			gst_clock_set_synced(Handle, synced);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_clock_single_shot_id_reinit(IntPtr raw, IntPtr id, ulong time);

		public bool SingleShotIdReinit(IntPtr id, ulong time) {
			bool raw_ret = gst_clock_single_shot_id_reinit(Handle, id, time);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern ulong gst_clock_unadjust_unlocked(IntPtr raw, ulong external);

		public ulong UnadjustUnlocked(ulong external) {
			ulong raw_ret = gst_clock_unadjust_unlocked(Handle, external);
			ulong ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern ulong gst_clock_unadjust_with_calibration(IntPtr raw, ulong external_target, ulong cinternal, ulong cexternal, ulong cnum, ulong cdenom);

		public ulong UnadjustWithCalibration(ulong external_target, ulong cinternal, ulong cexternal, ulong cnum, ulong cdenom) {
			ulong raw_ret = gst_clock_unadjust_with_calibration(Handle, external_target, cinternal, cexternal, cnum, cdenom);
			ulong ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_clock_wait_for_sync(IntPtr raw, ulong timeout);

		public bool WaitForSync(ulong timeout) {
			bool raw_ret = gst_clock_wait_for_sync(Handle, timeout);
			bool ret = raw_ret;
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gst.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
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


		// End of the ABI representation.

#endregion
	}
}

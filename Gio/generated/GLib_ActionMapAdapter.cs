// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ActionMapAdapter : GLib.GInterfaceAdapter, GLib.IActionMap {

		[StructLayout (LayoutKind.Sequential)]
		struct GActionMapInterface {
			public LookupActionNativeDelegate LookupAction;
			public AddActionNativeDelegate AddAction;
			public RemoveActionNativeDelegate RemoveAction;
		}

		static GActionMapInterface iface;

		static ActionMapAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (ActionMapAdapter));
			iface.LookupAction = new LookupActionNativeDelegate (LookupAction_cb);
			iface.AddAction = new AddActionNativeDelegate (AddAction_cb);
			iface.RemoveAction = new RemoveActionNativeDelegate (RemoveAction_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr LookupActionNativeDelegate (IntPtr inst, IntPtr action_name);

		static IntPtr LookupAction_cb (IntPtr inst, IntPtr action_name)
		{
			try {
				IActionMapImplementor __obj = GLib.Object.GetObject (inst, false) as IActionMapImplementor;
				GLib.IAction __result;
				__result = __obj.LookupAction (GLib.Marshaller.Utf8PtrToString (action_name));
				return __result == null ? IntPtr.Zero : ((__result is GLib.Object) ? (__result as GLib.Object).Handle : (__result as GLib.ActionAdapter).Handle);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void AddActionNativeDelegate (IntPtr inst, IntPtr action);

		static void AddAction_cb (IntPtr inst, IntPtr action)
		{
			try {
				IActionMapImplementor __obj = GLib.Object.GetObject (inst, false) as IActionMapImplementor;
				__obj.AddAction (GLib.ActionAdapter.GetObject (action, false));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void RemoveActionNativeDelegate (IntPtr inst, IntPtr action_name);

		static void RemoveAction_cb (IntPtr inst, IntPtr action_name)
		{
			try {
				IActionMapImplementor __obj = GLib.Object.GetObject (inst, false) as IActionMapImplementor;
				__obj.RemoveAction (GLib.Marshaller.Utf8PtrToString (action_name));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		static int class_offset = 2 * IntPtr.Size;

		static void Initialize (IntPtr ptr, IntPtr data)
		{
			IntPtr ifaceptr = new IntPtr (ptr.ToInt64 () + class_offset);
			GActionMapInterface native_iface = (GActionMapInterface) Marshal.PtrToStructure (ifaceptr, typeof (GActionMapInterface));
			native_iface.LookupAction = iface.LookupAction;
			native_iface.AddAction = iface.AddAction;
			native_iface.RemoveAction = iface.RemoveAction;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public ActionMapAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public ActionMapAdapter (IActionMapImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public ActionMapAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_action_map_get_type();

		private static GLib.GType _gtype = new GLib.GType (g_action_map_get_type ());

		public static GLib.GType GType {
			get {
				return _gtype;
			}
		}

		public override GLib.GType GInterfaceGType {
			get {
				return _gtype;
			}
		}

		public override IntPtr Handle {
			get {
				return implementor.Handle;
			}
		}

		public IntPtr OwnedHandle {
			get {
				return implementor.OwnedHandle;
			}
		}

		public static IActionMap GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static IActionMap GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is IActionMapImplementor)
				return new ActionMapAdapter (obj as IActionMapImplementor);
			else if (obj as IActionMap == null)
				return new ActionMapAdapter (obj.Handle);
			else
				return obj as IActionMap;
		}

		public IActionMapImplementor Implementor {
			get {
				return implementor as IActionMapImplementor;
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_action_map_add_action(IntPtr raw, IntPtr action);

		public void AddAction(GLib.IAction action) {
			g_action_map_add_action(Handle, action == null ? IntPtr.Zero : ((action is GLib.Object) ? (action as GLib.Object).Handle : (action as GLib.ActionAdapter).Handle));
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_action_map_add_action_entries(IntPtr raw, IntPtr entries, int n_entries, IntPtr user_data);

		public void AddActionEntries(GLib.ActionEntry entries, int n_entries, IntPtr user_data) {
			IntPtr native_entries = GLib.Marshaller.StructureToPtrAlloc (entries);
			g_action_map_add_action_entries(Handle, native_entries, n_entries, user_data);
			Marshal.FreeHGlobal (native_entries);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_action_map_lookup_action(IntPtr raw, IntPtr action_name);

		public GLib.IAction LookupAction(string action_name) {
			IntPtr native_action_name = GLib.Marshaller.StringToPtrGStrdup (action_name);
			IntPtr raw_ret = g_action_map_lookup_action(Handle, native_action_name);
			GLib.IAction ret = GLib.ActionAdapter.GetObject (raw_ret, false);
			GLib.Marshaller.Free (native_action_name);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_action_map_remove_action(IntPtr raw, IntPtr action_name);

		public void RemoveAction(string action_name) {
			IntPtr native_action_name = GLib.Marshaller.StringToPtrGStrdup (action_name);
			g_action_map_remove_action(Handle, native_action_name);
			GLib.Marshaller.Free (native_action_name);
		}

#endregion
	}
}

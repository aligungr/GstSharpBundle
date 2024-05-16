// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;

#region Autogenerated code
	public partial interface IDatagramBased : GLib.IWrapper {

		GLib.IOCondition ConditionCheck(GLib.IOCondition condition);
		bool ConditionWait(GLib.IOCondition condition, long timeout, GLib.Cancellable cancellable);
		GLib.Source CreateSource(GLib.IOCondition condition, GLib.Cancellable cancellable);
		int ReceiveMessages(GLib.InputMessage messages, uint num_messages, int flags, long timeout, GLib.Cancellable cancellable);
		int SendMessages(GLib.OutputMessage messages, uint num_messages, int flags, long timeout, GLib.Cancellable cancellable);
	}

	[GLib.GInterface (typeof (DatagramBasedAdapter))]
	public partial interface IDatagramBasedImplementor : GLib.IWrapper {

		int ReceiveMessages (GLib.InputMessage messages, uint num_messages, int flags, long timeout, GLib.Cancellable cancellable);
		int SendMessages (GLib.OutputMessage messages, uint num_messages, int flags, long timeout, GLib.Cancellable cancellable);
		GLib.Source CreateSource (GLib.IOCondition condition, GLib.Cancellable cancellable);
		GLib.IOCondition ConditionCheck (GLib.IOCondition condition);
		bool ConditionWait (GLib.IOCondition condition, long timeout, GLib.Cancellable cancellable);
	}
#endregion
}

// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.PbUtilsSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void AudioVisualizerShaderFuncNative(IntPtr scope, IntPtr s, IntPtr d);

	internal class AudioVisualizerShaderFuncInvoker {

		AudioVisualizerShaderFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~AudioVisualizerShaderFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal AudioVisualizerShaderFuncInvoker (AudioVisualizerShaderFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal AudioVisualizerShaderFuncInvoker (AudioVisualizerShaderFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal AudioVisualizerShaderFuncInvoker (AudioVisualizerShaderFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gst.PbUtils.AudioVisualizerShaderFunc Handler {
			get {
				return new Gst.PbUtils.AudioVisualizerShaderFunc(InvokeNative);
			}
		}

		void InvokeNative (Gst.PbUtils.AudioVisualizer scope, Gst.Video.VideoFrame s, Gst.Video.VideoFrame d)
		{
			IntPtr native_s = GLib.Marshaller.StructureToPtrAlloc (s);
			IntPtr native_d = GLib.Marshaller.StructureToPtrAlloc (d);
			native_cb (scope == null ? IntPtr.Zero : scope.Handle, native_s, native_d);
			Marshal.FreeHGlobal (native_s);
			Marshal.FreeHGlobal (native_d);
		}
	}

	internal class AudioVisualizerShaderFuncWrapper {

		public void NativeCallback (IntPtr scope, IntPtr s, IntPtr d)
		{
			try {
				managed (GLib.Object.GetObject(scope) as Gst.PbUtils.AudioVisualizer, Gst.Video.VideoFrame.New (s), Gst.Video.VideoFrame.New (d));
				if (release_on_call)
					gch.Free ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal AudioVisualizerShaderFuncNative NativeDelegate;
		Gst.PbUtils.AudioVisualizerShaderFunc managed;

		public AudioVisualizerShaderFuncWrapper (Gst.PbUtils.AudioVisualizerShaderFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new AudioVisualizerShaderFuncNative (NativeCallback);
		}

		public static Gst.PbUtils.AudioVisualizerShaderFunc GetManagedDelegate (AudioVisualizerShaderFuncNative native)
		{
			if (native == null)
				return null;
			AudioVisualizerShaderFuncWrapper wrapper = (AudioVisualizerShaderFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}

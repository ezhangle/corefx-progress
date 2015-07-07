namespace System.Threading {
  public unsafe delegate void IOCompletionCallback(uint errorCode, uint numBytes, NativeOverlapped* pOVERLAP);
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct NativeOverlapped {
    public int OffsetHigh;
    public int OffsetLow;
    public IntPtr EventHandle;
    public IntPtr InternalHigh;
    public IntPtr InternalLow;
  }
  public sealed class PreAllocatedOverlapped : IDisposable {
    public PreAllocatedOverlapped(IOCompletionCallback callback, object state, object pinData);
    public void Dispose();
  }
  public sealed class ThreadPoolBoundHandle : IDisposable {
    public SafeHandle Handle { get; }
    public unsafe NativeOverlapped* AllocateNativeOverlapped(IOCompletionCallback callback, object state, object pinData);
    public unsafe NativeOverlapped* AllocateNativeOverlapped(PreAllocatedOverlapped preAllocated);
    public static ThreadPoolBoundHandle BindHandle(SafeHandle handle);
    public void Dispose();
    public unsafe void FreeNativeOverlapped(NativeOverlapped* overlapped);
    public unsafe static object GetNativeOverlappedState(NativeOverlapped* overlapped);
  }
}

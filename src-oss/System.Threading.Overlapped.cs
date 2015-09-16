namespace System.Threading {
  public sealed class PreAllocatedOverlapped : IDisposable {
    public PreAllocatedOverlapped(IOCompletionCallback callback, object state, object pinData);
    public void Dispose();
    ~PreAllocatedOverlapped();
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

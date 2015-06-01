﻿namespace System.Threading {
  public unsafe delegate void IOCompletionCallback(uint errorCode, uint numBytes, NativeOverlapped* pOVERLAP);
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct NativeOverlapped {
    public int OffsetHigh;
    public int OffsetLow;
    public IntPtr EventHandle;
    public IntPtr InternalHigh;
    public IntPtr InternalLow;
  }
  public class Overlapped {
    public Overlapped();
    public IAsyncResult AsyncResult { get; set; }
    public int OffsetHigh { get; set; }
    public int OffsetLow { get; set; }
    public unsafe static void Free(NativeOverlapped* nativeOverlappedPtr);
    public unsafe NativeOverlapped* Pack(IOCompletionCallback iocb, object userData);
    public unsafe static Overlapped Unpack(NativeOverlapped* nativeOverlappedPtr);
    public unsafe NativeOverlapped* UnsafePack(IOCompletionCallback iocb, object userData);
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

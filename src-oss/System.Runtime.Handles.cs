namespace System.IO {
  public enum HandleInheritability {
    Inheritable = 1,
    None = 0,
  }
}
namespace System.Threading {
  public static class WaitHandleExtensions {
    public static SafeWaitHandle GetSafeWaitHandle(this WaitHandle waitHandle);
    public static void SetSafeWaitHandle(this WaitHandle waitHandle, SafeWaitHandle value);
  }
}

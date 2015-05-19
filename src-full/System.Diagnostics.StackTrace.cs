namespace System.Diagnostics {
  public sealed class StackFrame {
    public const int OFFSET_UNKNOWN = -1;
    public int GetFileColumnNumber();
    public int GetFileLineNumber();
    public string GetFileName();
    public int GetILOffset();
    public MethodBase GetMethod();
    public override string ToString();
  }
  public static class StackFrameExtensions {
    public static IntPtr GetNativeImageBase(this StackFrame stackFrame);
    public static IntPtr GetNativeIP(this StackFrame stackFrame);
    public static bool HasILOffset(this StackFrame stackFrame);
    public static bool HasMethod(this StackFrame stackFrame);
    public static bool HasNativeImage(this StackFrame stackFrame);
    public static bool HasSource(this StackFrame stackFrame);
  }
  public sealed class StackTrace {
    public StackTrace(Exception exception, bool needFileInfo);
    public StackFrame[] GetFrames();
    public override string ToString();
  }
}

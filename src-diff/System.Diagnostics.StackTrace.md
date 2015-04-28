```diff
---lib-full\System.Diagnostics.StackTrace.dll
+++lib-oss\System.Diagnostics.StackTrace.dll
-namespace System.Diagnostics {
- public sealed class StackFrame {
-   public const int OFFSET_UNKNOWN = -1;
-   public int GetFileColumnNumber();
-   public int GetFileLineNumber();
-   public string GetFileName();
-   public int GetILOffset();
-   public MethodBase GetMethod();
-   public override string ToString();
  }
- public static class StackFrameExtensions {
-   public static IntPtr GetNativeImageBase(this StackFrame sf);
-   public static IntPtr GetNativeIP(this StackFrame sf);
-   public static bool HasILOffset(this StackFrame sf);
-   public static bool HasMethod(this StackFrame sf);
-   public static bool HasNativeImage(this StackFrame sf);
-   public static bool HasSource(this StackFrame sf);
  }
- public sealed class StackTrace {
-   public StackTrace(Exception e, bool fNeedFileInfo);
-   public StackFrame[] GetFrames();
-   public override string ToString();
  }
 }
```

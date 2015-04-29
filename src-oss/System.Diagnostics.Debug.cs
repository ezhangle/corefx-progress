namespace System.Diagnostics {
  public static class Debug {
    public static void Assert(bool condition);
    public static void Assert(bool condition, string message);
    public static void Assert(bool condition, string message, string detailMessage);
    public static void Assert(bool condition, string message, string detailMessageFormat, params object[] args);
    public static void Fail(string message);
    public static void Fail(string message, string detailMessage);
    public static void Write(object value);
    public static void Write(object value, string category);
    public static void Write(string message);
    public static void Write(string message, string category);
    public static void WriteIf(bool condition, object value);
    public static void WriteIf(bool condition, object value, string category);
    public static void WriteIf(bool condition, string message);
    public static void WriteIf(bool condition, string message, string category);
    public static void WriteLine(object value);
    public static void WriteLine(object value, string category);
    public static void WriteLine(string message);
    public static void WriteLine(string format, params object[] args);
    public static void WriteLine(string message, string category);
    public static void WriteLineIf(bool condition, object value);
    public static void WriteLineIf(bool condition, object value, string category);
    public static void WriteLineIf(bool condition, string value);
    public static void WriteLineIf(bool condition, string value, string category);
  }
}

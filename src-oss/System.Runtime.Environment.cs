namespace System.Runtime.InteropServices {
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct OSName : IEquatable<OSName> {
    public static readonly OSName Linux;
    public static readonly OSName OSX;
    public static readonly OSName Windows;
    public OSName(string name);
    public override bool Equals(object obj);
    public bool Equals(OSName other);
    public override int GetHashCode();
    public static bool operator ==(OSName left, OSName right);
    public static bool operator !=(OSName left, OSName right);
    public override string ToString();
  }
  public static class RuntimeInformation {
    public static bool IsOperatingSystem(OSName osName);
  }
}

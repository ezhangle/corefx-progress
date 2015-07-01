namespace System.Runtime.InteropServices {
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct OSPlatform : IEquatable<OSPlatform> {
    public static OSPlatform Linux { get; }
    public static OSPlatform OSX { get; }
    public static OSPlatform Windows { get; }
    public static OSPlatform Create(string osPlatform);
    public override bool Equals(object obj);
    public bool Equals(OSPlatform other);
    public override int GetHashCode();
    public static bool operator ==(OSPlatform left, OSPlatform right);
    public static bool operator !=(OSPlatform left, OSPlatform right);
    public override string ToString();
  }
  public static class RuntimeInformation {
    public static bool IsOSPlatform(OSPlatform osPlatform);
  }
}

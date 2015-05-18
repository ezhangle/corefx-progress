namespace System.Diagnostics {
  public class Stopwatch {
    public static readonly bool IsHighResolution;
    public static readonly long Frequency;
    public Stopwatch();
    public TimeSpan Elapsed { get; }
    public long ElapsedMilliseconds { get; }
    public long ElapsedTicks { get; }
    public bool IsRunning { get; }
    public static long GetTimestamp();
    public void Reset();
    public void Restart();
    public void Start();
    public static Stopwatch StartNew();
    public void Stop();
  }
}
namespace System.Net {
  public static class WebUtility {
    public static string HtmlDecode(string value);
    public static string HtmlEncode(string value);
    public static string UrlDecode(string encodedValue);
    public static byte[] UrlDecodeToBytes(byte[] encodedValue, int offset, int count);
    public static string UrlEncode(string value);
    public static byte[] UrlEncodeToBytes(byte[] value, int offset, int count);
  }
}
namespace System.Runtime.Versioning {
  public sealed class FrameworkName : IEquatable<FrameworkName> {
    public FrameworkName(string frameworkName);
    public FrameworkName(string identifier, Version version);
    public FrameworkName(string identifier, Version version, string profile);
    public string FullName { get; }
    public string Identifier { get; }
    public string Profile { get; }
    public Version Version { get; }
    public override bool Equals(object obj);
    public bool Equals(FrameworkName other);
    public override int GetHashCode();
    public static bool operator ==(FrameworkName left, FrameworkName right);
    public static bool operator !=(FrameworkName left, FrameworkName right);
    public override string ToString();
  }
}

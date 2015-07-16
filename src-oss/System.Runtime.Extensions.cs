namespace System {
  public static class BitConverter {
    public static readonly bool IsLittleEndian;
    public static long DoubleToInt64Bits(double value);
    public static byte[] GetBytes(bool value);
    public static byte[] GetBytes(char value);
    public static byte[] GetBytes(double value);
    public static byte[] GetBytes(short value);
    public static byte[] GetBytes(int value);
    public static byte[] GetBytes(long value);
    public static byte[] GetBytes(float value);
    public static byte[] GetBytes(ushort value);
    public static byte[] GetBytes(uint value);
    public static byte[] GetBytes(ulong value);
    public static double Int64BitsToDouble(long value);
    public static bool ToBoolean(byte[] value, int startIndex);
    public static char ToChar(byte[] value, int startIndex);
    public static double ToDouble(byte[] value, int startIndex);
    public static short ToInt16(byte[] value, int startIndex);
    public static int ToInt32(byte[] value, int startIndex);
    public static long ToInt64(byte[] value, int startIndex);
    public static float ToSingle(byte[] value, int startIndex);
    public static string ToString(byte[] value);
    public static string ToString(byte[] value, int startIndex);
    public static string ToString(byte[] value, int startIndex, int length);
    public static ushort ToUInt16(byte[] value, int startIndex);
    public static uint ToUInt32(byte[] value, int startIndex);
    public static ulong ToUInt64(byte[] value, int startIndex);
  }
}
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
namespace System.IO {
  public static class Path {
    public static readonly char AltDirectorySeparatorChar;
    public static readonly char DirectorySeparatorChar;
    public static readonly char PathSeparator;
    public static readonly char VolumeSeparatorChar;
    public static string ChangeExtension(string path, string extension);
    public static string Combine(string path1, string path2);
    public static string Combine(string path1, string path2, string path3);
    public static string Combine(params string[] paths);
    public static string GetDirectoryName(string path);
    public static string GetExtension(string path);
    public static string GetFileName(string path);
    public static string GetFileNameWithoutExtension(string path);
    public static string GetFullPath(string path);
    public static char[] GetInvalidFileNameChars();
    public static char[] GetInvalidPathChars();
    public static string GetPathRoot(string path);
    public static string GetRandomFileName();
    public static string GetTempFileName();
    public static string GetTempPath();
    public static bool HasExtension(string path);
    public static bool IsPathRooted(string path);
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

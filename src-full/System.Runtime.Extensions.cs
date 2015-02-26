﻿namespace System {
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
  public static class Convert {
    public static object ChangeType(object value, Type conversionType);
    public static object ChangeType(object value, Type conversionType, IFormatProvider provider);
    public static byte[] FromBase64CharArray(char[] inArray, int offset, int length);
    public static byte[] FromBase64String(string s);
    public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut);
    public static string ToBase64String(byte[] inArray);
    public static string ToBase64String(byte[] inArray, int offset, int length);
    public static bool ToBoolean(bool value);
    public static bool ToBoolean(byte value);
    public static bool ToBoolean(decimal value);
    public static bool ToBoolean(double value);
    public static bool ToBoolean(short value);
    public static bool ToBoolean(int value);
    public static bool ToBoolean(long value);
    public static bool ToBoolean(object value);
    public static bool ToBoolean(object value, IFormatProvider provider);
    public static bool ToBoolean(sbyte value);
    public static bool ToBoolean(float value);
    public static bool ToBoolean(string value);
    public static bool ToBoolean(string value, IFormatProvider provider);
    public static bool ToBoolean(ushort value);
    public static bool ToBoolean(uint value);
    public static bool ToBoolean(ulong value);
    public static byte ToByte(bool value);
    public static byte ToByte(byte value);
    public static byte ToByte(char value);
    public static byte ToByte(decimal value);
    public static byte ToByte(double value);
    public static byte ToByte(short value);
    public static byte ToByte(int value);
    public static byte ToByte(long value);
    public static byte ToByte(object value);
    public static byte ToByte(object value, IFormatProvider provider);
    public static byte ToByte(sbyte value);
    public static byte ToByte(float value);
    public static byte ToByte(string value);
    public static byte ToByte(string value, IFormatProvider provider);
    public static byte ToByte(string value, int fromBase);
    public static byte ToByte(ushort value);
    public static byte ToByte(uint value);
    public static byte ToByte(ulong value);
    public static char ToChar(byte value);
    public static char ToChar(short value);
    public static char ToChar(int value);
    public static char ToChar(long value);
    public static char ToChar(object value);
    public static char ToChar(object value, IFormatProvider provider);
    public static char ToChar(sbyte value);
    public static char ToChar(string value);
    public static char ToChar(string value, IFormatProvider provider);
    public static char ToChar(ushort value);
    public static char ToChar(uint value);
    public static char ToChar(ulong value);
    public static DateTime ToDateTime(object value);
    public static DateTime ToDateTime(object value, IFormatProvider provider);
    public static DateTime ToDateTime(string value);
    public static DateTime ToDateTime(string value, IFormatProvider provider);
    public static decimal ToDecimal(bool value);
    public static decimal ToDecimal(byte value);
    public static decimal ToDecimal(decimal value);
    public static decimal ToDecimal(double value);
    public static decimal ToDecimal(short value);
    public static decimal ToDecimal(int value);
    public static decimal ToDecimal(long value);
    public static decimal ToDecimal(object value);
    public static decimal ToDecimal(object value, IFormatProvider provider);
    public static decimal ToDecimal(sbyte value);
    public static decimal ToDecimal(float value);
    public static decimal ToDecimal(string value);
    public static decimal ToDecimal(string value, IFormatProvider provider);
    public static decimal ToDecimal(ushort value);
    public static decimal ToDecimal(uint value);
    public static decimal ToDecimal(ulong value);
    public static double ToDouble(bool value);
    public static double ToDouble(byte value);
    public static double ToDouble(decimal value);
    public static double ToDouble(double value);
    public static double ToDouble(short value);
    public static double ToDouble(int value);
    public static double ToDouble(long value);
    public static double ToDouble(object value);
    public static double ToDouble(object value, IFormatProvider provider);
    public static double ToDouble(sbyte value);
    public static double ToDouble(float value);
    public static double ToDouble(string value);
    public static double ToDouble(string value, IFormatProvider provider);
    public static double ToDouble(ushort value);
    public static double ToDouble(uint value);
    public static double ToDouble(ulong value);
    public static short ToInt16(bool value);
    public static short ToInt16(byte value);
    public static short ToInt16(char value);
    public static short ToInt16(decimal value);
    public static short ToInt16(double value);
    public static short ToInt16(short value);
    public static short ToInt16(int value);
    public static short ToInt16(long value);
    public static short ToInt16(object value);
    public static short ToInt16(object value, IFormatProvider provider);
    public static short ToInt16(sbyte value);
    public static short ToInt16(float value);
    public static short ToInt16(string value);
    public static short ToInt16(string value, IFormatProvider provider);
    public static short ToInt16(string value, int fromBase);
    public static short ToInt16(ushort value);
    public static short ToInt16(uint value);
    public static short ToInt16(ulong value);
    public static int ToInt32(bool value);
    public static int ToInt32(byte value);
    public static int ToInt32(char value);
    public static int ToInt32(decimal value);
    public static int ToInt32(double value);
    public static int ToInt32(short value);
    public static int ToInt32(int value);
    public static int ToInt32(long value);
    public static int ToInt32(object value);
    public static int ToInt32(object value, IFormatProvider provider);
    public static int ToInt32(sbyte value);
    public static int ToInt32(float value);
    public static int ToInt32(string value);
    public static int ToInt32(string value, IFormatProvider provider);
    public static int ToInt32(string value, int fromBase);
    public static int ToInt32(ushort value);
    public static int ToInt32(uint value);
    public static int ToInt32(ulong value);
    public static long ToInt64(bool value);
    public static long ToInt64(byte value);
    public static long ToInt64(char value);
    public static long ToInt64(decimal value);
    public static long ToInt64(double value);
    public static long ToInt64(short value);
    public static long ToInt64(int value);
    public static long ToInt64(long value);
    public static long ToInt64(object value);
    public static long ToInt64(object value, IFormatProvider provider);
    public static long ToInt64(sbyte value);
    public static long ToInt64(float value);
    public static long ToInt64(string value);
    public static long ToInt64(string value, IFormatProvider provider);
    public static long ToInt64(string value, int fromBase);
    public static long ToInt64(ushort value);
    public static long ToInt64(uint value);
    public static long ToInt64(ulong value);
    public static sbyte ToSByte(bool value);
    public static sbyte ToSByte(byte value);
    public static sbyte ToSByte(char value);
    public static sbyte ToSByte(decimal value);
    public static sbyte ToSByte(double value);
    public static sbyte ToSByte(short value);
    public static sbyte ToSByte(int value);
    public static sbyte ToSByte(long value);
    public static sbyte ToSByte(object value);
    public static sbyte ToSByte(object value, IFormatProvider provider);
    public static sbyte ToSByte(sbyte value);
    public static sbyte ToSByte(float value);
    public static sbyte ToSByte(string value);
    public static sbyte ToSByte(string value, IFormatProvider provider);
    public static sbyte ToSByte(string value, int fromBase);
    public static sbyte ToSByte(ushort value);
    public static sbyte ToSByte(uint value);
    public static sbyte ToSByte(ulong value);
    public static float ToSingle(bool value);
    public static float ToSingle(byte value);
    public static float ToSingle(decimal value);
    public static float ToSingle(double value);
    public static float ToSingle(short value);
    public static float ToSingle(int value);
    public static float ToSingle(long value);
    public static float ToSingle(object value);
    public static float ToSingle(object value, IFormatProvider provider);
    public static float ToSingle(sbyte value);
    public static float ToSingle(float value);
    public static float ToSingle(string value);
    public static float ToSingle(string value, IFormatProvider provider);
    public static float ToSingle(ushort value);
    public static float ToSingle(uint value);
    public static float ToSingle(ulong value);
    public static string ToString(bool value);
    public static string ToString(bool value, IFormatProvider provider);
    public static string ToString(byte value);
    public static string ToString(byte value, IFormatProvider provider);
    public static string ToString(byte value, int toBase);
    public static string ToString(char value);
    public static string ToString(char value, IFormatProvider provider);
    public static string ToString(DateTime value);
    public static string ToString(DateTime value, IFormatProvider provider);
    public static string ToString(decimal value);
    public static string ToString(decimal value, IFormatProvider provider);
    public static string ToString(double value);
    public static string ToString(double value, IFormatProvider provider);
    public static string ToString(short value);
    public static string ToString(short value, IFormatProvider provider);
    public static string ToString(short value, int toBase);
    public static string ToString(int value);
    public static string ToString(int value, IFormatProvider provider);
    public static string ToString(int value, int toBase);
    public static string ToString(long value);
    public static string ToString(long value, IFormatProvider provider);
    public static string ToString(long value, int toBase);
    public static string ToString(object value);
    public static string ToString(object value, IFormatProvider provider);
    public static string ToString(sbyte value);
    public static string ToString(sbyte value, IFormatProvider provider);
    public static string ToString(float value);
    public static string ToString(float value, IFormatProvider provider);
    public static string ToString(ushort value);
    public static string ToString(ushort value, IFormatProvider provider);
    public static string ToString(uint value);
    public static string ToString(uint value, IFormatProvider provider);
    public static string ToString(ulong value);
    public static string ToString(ulong value, IFormatProvider provider);
    public static ushort ToUInt16(bool value);
    public static ushort ToUInt16(byte value);
    public static ushort ToUInt16(char value);
    public static ushort ToUInt16(decimal value);
    public static ushort ToUInt16(double value);
    public static ushort ToUInt16(short value);
    public static ushort ToUInt16(int value);
    public static ushort ToUInt16(long value);
    public static ushort ToUInt16(object value);
    public static ushort ToUInt16(object value, IFormatProvider provider);
    public static ushort ToUInt16(sbyte value);
    public static ushort ToUInt16(float value);
    public static ushort ToUInt16(string value);
    public static ushort ToUInt16(string value, IFormatProvider provider);
    public static ushort ToUInt16(string value, int fromBase);
    public static ushort ToUInt16(ushort value);
    public static ushort ToUInt16(uint value);
    public static ushort ToUInt16(ulong value);
    public static uint ToUInt32(bool value);
    public static uint ToUInt32(byte value);
    public static uint ToUInt32(char value);
    public static uint ToUInt32(decimal value);
    public static uint ToUInt32(double value);
    public static uint ToUInt32(short value);
    public static uint ToUInt32(int value);
    public static uint ToUInt32(long value);
    public static uint ToUInt32(object value);
    public static uint ToUInt32(object value, IFormatProvider provider);
    public static uint ToUInt32(sbyte value);
    public static uint ToUInt32(float value);
    public static uint ToUInt32(string value);
    public static uint ToUInt32(string value, IFormatProvider provider);
    public static uint ToUInt32(string value, int fromBase);
    public static uint ToUInt32(ushort value);
    public static uint ToUInt32(uint value);
    public static uint ToUInt32(ulong value);
    public static ulong ToUInt64(bool value);
    public static ulong ToUInt64(byte value);
    public static ulong ToUInt64(char value);
    public static ulong ToUInt64(decimal value);
    public static ulong ToUInt64(double value);
    public static ulong ToUInt64(short value);
    public static ulong ToUInt64(int value);
    public static ulong ToUInt64(long value);
    public static ulong ToUInt64(object value);
    public static ulong ToUInt64(object value, IFormatProvider provider);
    public static ulong ToUInt64(sbyte value);
    public static ulong ToUInt64(float value);
    public static ulong ToUInt64(string value);
    public static ulong ToUInt64(string value, IFormatProvider provider);
    public static ulong ToUInt64(string value, int fromBase);
    public static ulong ToUInt64(ushort value);
    public static ulong ToUInt64(uint value);
    public static ulong ToUInt64(ulong value);
  }
  public static class Environment {
    public static int CurrentManagedThreadId { get; }
    public static bool HasShutdownStarted { get; }
    public static string NewLine { get; }
    public static int ProcessorCount { get; }
    public static string StackTrace { get; }
    public static int TickCount { get; }
    public static string ExpandEnvironmentVariables(string name);
    public static void FailFast(string message);
    public static void FailFast(string message, Exception exception);
    public static string GetEnvironmentVariable(string variable);
    public static IDictionary GetEnvironmentVariables();
    public static void SetEnvironmentVariable(string variable, string value);
  }
  public static class Math {
    public const double E = 2.7182818284590451;
    public const double PI = 3.1415926535897931;
    public static decimal Abs(decimal value);
    public static double Abs(double value);
    public static short Abs(short value);
    public static int Abs(int value);
    public static long Abs(long value);
    public static sbyte Abs(sbyte value);
    public static float Abs(float value);
    public static double Acos(double d);
    public static double Asin(double d);
    public static double Atan(double d);
    public static double Atan2(double y, double x);
    public static decimal Ceiling(decimal d);
    public static double Ceiling(double a);
    public static double Cos(double d);
    public static double Cosh(double value);
    public static double Exp(double d);
    public static decimal Floor(decimal d);
    public static double Floor(double d);
    public static double IEEERemainder(double x, double y);
    public static double Log(double d);
    public static double Log(double a, double newBase);
    public static double Log10(double d);
    public static byte Max(byte val1, byte val2);
    public static decimal Max(decimal val1, decimal val2);
    public static double Max(double val1, double val2);
    public static short Max(short val1, short val2);
    public static int Max(int val1, int val2);
    public static long Max(long val1, long val2);
    public static sbyte Max(sbyte val1, sbyte val2);
    public static float Max(float val1, float val2);
    public static ushort Max(ushort val1, ushort val2);
    public static uint Max(uint val1, uint val2);
    public static ulong Max(ulong val1, ulong val2);
    public static byte Min(byte val1, byte val2);
    public static decimal Min(decimal val1, decimal val2);
    public static double Min(double val1, double val2);
    public static short Min(short val1, short val2);
    public static int Min(int val1, int val2);
    public static long Min(long val1, long val2);
    public static sbyte Min(sbyte val1, sbyte val2);
    public static float Min(float val1, float val2);
    public static ushort Min(ushort val1, ushort val2);
    public static uint Min(uint val1, uint val2);
    public static ulong Min(ulong val1, ulong val2);
    public static double Pow(double x, double y);
    public static decimal Round(decimal d);
    public static decimal Round(decimal d, int decimals);
    public static decimal Round(decimal d, int decimals, MidpointRounding mode);
    public static decimal Round(decimal d, MidpointRounding mode);
    public static double Round(double a);
    public static double Round(double value, int digits);
    public static double Round(double value, int digits, MidpointRounding mode);
    public static double Round(double value, MidpointRounding mode);
    public static int Sign(decimal value);
    public static int Sign(double value);
    public static int Sign(short value);
    public static int Sign(int value);
    public static int Sign(long value);
    public static int Sign(sbyte value);
    public static int Sign(float value);
    public static double Sin(double a);
    public static double Sinh(double value);
    public static double Sqrt(double d);
    public static double Tan(double a);
    public static double Tanh(double value);
    public static decimal Truncate(decimal d);
    public static double Truncate(double d);
  }
  public enum MidpointRounding {
    AwayFromZero = 1,
    ToEven = 0,
  }
  public class Progress<T> : IProgress<T> {
    public Progress();
    public Progress(Action<T> handler);
    public event EventHandler<T> ProgressChanged;
    protected virtual void OnReport(T value);
    void System.IProgress<T>.Report(T value);
  }
  public class Random {
    public Random();
    public Random(int Seed);
    public virtual int Next();
    public virtual int Next(int maxValue);
    public virtual int Next(int minValue, int maxValue);
    public virtual void NextBytes(byte[] buffer);
    public virtual double NextDouble();
    protected virtual double Sample();
  }
  public abstract class StringComparer : IComparer, IComparer<string>, IEqualityComparer, IEqualityComparer<string> {
    protected StringComparer();
    public static StringComparer CurrentCulture { get; }
    public static StringComparer CurrentCultureIgnoreCase { get; }
    public static StringComparer Ordinal { get; }
    public static StringComparer OrdinalIgnoreCase { get; }
    public abstract int Compare(string x, string y);
    public abstract bool Equals(string x, string y);
    public abstract int GetHashCode(string obj);
    int System.Collections.IComparer.Compare(object x, object y);
    bool System.Collections.IEqualityComparer.Equals(object x, object y);
    int System.Collections.IEqualityComparer.GetHashCode(object obj);
  }
  public class UriBuilder {
    public UriBuilder();
    public UriBuilder(string uri);
    public UriBuilder(string schemeName, string hostName);
    public UriBuilder(string scheme, string host, int portNumber);
    public UriBuilder(string scheme, string host, int port, string pathValue);
    public UriBuilder(string scheme, string host, int port, string path, string extraValue);
    public UriBuilder(Uri uri);
    public string Fragment { get; set; }
    public string Host { get; set; }
    public string Password { get; set; }
    public string Path { get; set; }
    public int Port { get; set; }
    public string Query { get; set; }
    public string Scheme { get; set; }
    public Uri Uri { get; }
    public string UserName { get; set; }
    public override bool Equals(object rparam);
    public override int GetHashCode();
    public override string ToString();
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

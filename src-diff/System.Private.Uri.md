```diff
---lib-full\System.Private.Uri.dll
+++lib-oss\System.Private.Uri.dll
+namespace System {
+ public class Uri {
+   public Uri(string uriString);
+   public Uri(string uriString, UriKind uriKind);
+   public Uri(Uri baseUri, string relativeUri);
+   public Uri(Uri baseUri, Uri relativeUri);
+   public string AbsolutePath { get; }
+   public string AbsoluteUri { get; }
+   public string Authority { get; }
+   public string DnsSafeHost { get; }
+   public string Fragment { get; }
+   public string Host { get; }
+   public UriHostNameType HostNameType { get; }
+   public string IdnHost { get; }
+   public bool IsAbsoluteUri { get; }
+   public bool IsDefaultPort { get; }
+   public bool IsFile { get; }
+   public bool IsLoopback { get; }
+   public bool IsUnc { get; }
+   public string LocalPath { get; }
+   public string OriginalString { get; }
+   public string PathAndQuery { get; }
+   public int Port { get; }
+   public string Query { get; }
+   public string Scheme { get; }
+   public string[] Segments { get; }
+   public bool UserEscaped { get; }
+   public string UserInfo { get; }
+   public static UriHostNameType CheckHostName(string name);
+   public static bool CheckSchemeName(string schemeName);
+   public static int Compare(Uri uri1, Uri uri2, UriComponents partsToCompare, UriFormat compareFormat, StringComparison comparisonType);
+   public override bool Equals(object comparand);
+   public static string EscapeDataString(string stringToEscape);
+   public static string EscapeUriString(string stringToEscape);
+   public string GetComponents(UriComponents components, UriFormat format);
+   public override int GetHashCode();
+   public bool IsBaseOf(Uri uri);
+   public bool IsWellFormedOriginalString();
+   public static bool IsWellFormedUriString(string uriString, UriKind uriKind);
+   public Uri MakeRelativeUri(Uri uri);
+   public static bool operator ==(Uri uri1, Uri uri2);
+   public static bool operator !=(Uri uri1, Uri uri2);
+   public override string ToString();
+   public static bool TryCreate(string uriString, UriKind uriKind, out Uri result);
+   public static bool TryCreate(Uri baseUri, string relativeUri, out Uri result);
+   public static bool TryCreate(Uri baseUri, Uri relativeUri, out Uri result);
+   public static string UnescapeDataString(string stringToUnescape);
  }
+ public class UriBuilder {
+   public UriBuilder();
+   public UriBuilder(string uri);
+   public UriBuilder(string schemeName, string hostName);
+   public UriBuilder(string scheme, string host, int portNumber);
+   public UriBuilder(string scheme, string host, int port, string pathValue);
+   public UriBuilder(string scheme, string host, int port, string path, string extraValue);
+   public UriBuilder(Uri uri);
+   public string Fragment { get; set; }
+   public string Host { get; set; }
+   public string Password { get; set; }
+   public string Path { get; set; }
+   public int Port { get; set; }
+   public string Query { get; set; }
+   public string Scheme { get; set; }
+   public Uri Uri { get; }
+   public string UserName { get; set; }
+   public override bool Equals(object rparam);
+   public override int GetHashCode();
+   public override string ToString();
  }
+ public enum UriComponents {
+   AbsoluteUri = 127,
+   Fragment = 64,
+   Host = 4,
+   HostAndPort = 132,
+   HttpRequestUrl = 61,
+   KeepDelimiter = 1073741824,
+   NormalizedHost = 256,
+   Path = 16,
+   PathAndQuery = 48,
+   Port = 8,
+   Query = 32,
+   Scheme = 1,
+   SchemeAndServer = 13,
+   SerializationInfoString = -2147483648,
+   StrongAuthority = 134,
+   StrongPort = 128,
+   UserInfo = 2,
  }
+ public enum UriFormat {
+   SafeUnescaped = 3,
+   Unescaped = 2,
+   UriEscaped = 1,
  }
+ public class UriFormatException : FormatException {
+   public UriFormatException();
+   public UriFormatException(string textString);
+   public UriFormatException(string textString, Exception e);
  }
+ public enum UriHostNameType {
+   Basic = 1,
+   Dns = 2,
+   IPv4 = 3,
+   IPv6 = 4,
+   Unknown = 0,
  }
+ public enum UriKind {
+   Absolute = 1,
+   Relative = 2,
+   RelativeOrAbsolute = 0,
  }
 }
```

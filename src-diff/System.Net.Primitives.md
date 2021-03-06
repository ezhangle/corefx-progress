﻿```diff
---lib-full\System.Net.Primitives.dll
+++lib-oss\System.Net.Primitives.dll
 namespace System.Net {
  public enum AuthenticationSchemes {
    Anonymous = 32768,
    Basic = 8,
    Digest = 1,
    IntegratedWindowsAuthentication = 6,
    Negotiate = 2,
    None = 0,
    Ntlm = 4,
  }
  public sealed class Cookie {
    public Cookie();
    public Cookie(string name, string value);
    public Cookie(string name, string value, string path);
    public Cookie(string name, string value, string path, string domain);
    public string Comment { get; set; }
    public Uri CommentUri { get; set; }
    public bool Discard { get; set; }
    public string Domain { get; set; }
    public bool Expired { get; set; }
    public DateTime Expires { get; set; }
    public bool HttpOnly { get; set; }
    public string Name { get; set; }
    public string Path { get; set; }
    public string Port { get; set; }
    public bool Secure { get; set; }
    public DateTime TimeStamp { get; }
    public string Value { get; set; }
    public int Version { get; set; }
    public override bool Equals(object comparand);
    public override int GetHashCode();
    public override string ToString();
  }
  public class CookieCollection : ICollection, IEnumerable {
    public CookieCollection();
    public int Count { get; }
+   public bool IsReadOnly { get; }
+   public bool IsSynchronized { get; }
+   public object SyncRoot { get; }
-   bool System.Collections.ICollection.IsSynchronized { get; }
-   object System.Collections.ICollection.SyncRoot { get; }
+   public Cookie this[int index] { get; }
    public Cookie this[string name] { get; }
    public void Add(Cookie cookie);
    public void Add(CookieCollection cookies);
+   public void CopyTo(Array array, int index);
+   public void CopyTo(Cookie[] array, int index);
    public IEnumerator GetEnumerator();
-   void System.Collections.ICollection.CopyTo(Array array, int index);
  }
  public class CookieContainer {
    public const int DefaultCookieLengthLimit = 4096;
    public const int DefaultCookieLimit = 300;
    public const int DefaultPerDomainCookieLimit = 20;
    public CookieContainer();
+   public CookieContainer(int capacity);
+   public CookieContainer(int capacity, int perDomainCapacity, int maxCookieSize);
    public int Capacity { get; set; }
    public int Count { get; }
    public int MaxCookieSize { get; set; }
    public int PerDomainCapacity { get; set; }
+   public void Add(Cookie cookie);
+   public void Add(CookieCollection cookies);
    public void Add(Uri uri, Cookie cookie);
    public void Add(Uri uri, CookieCollection cookies);
    public string GetCookieHeader(Uri uri);
    public CookieCollection GetCookies(Uri uri);
    public void SetCookies(Uri uri, string cookieHeader);
  }
  public class CookieException : FormatException {
    public CookieException();
  }
  public class CredentialCache : ICredentials, ICredentialsByHost, IEnumerable {
    public CredentialCache();
    public static ICredentials DefaultCredentials { get; }
    public static NetworkCredential DefaultNetworkCredentials { get; }
    public void Add(string host, int port, string authenticationType, NetworkCredential credential);
    public void Add(Uri uriPrefix, string authType, NetworkCredential cred);
    public NetworkCredential GetCredential(string host, int port, string authenticationType);
    public NetworkCredential GetCredential(Uri uriPrefix, string authType);
    public IEnumerator GetEnumerator();
    public void Remove(string host, int port, string authenticationType);
    public void Remove(Uri uriPrefix, string authType);
  }
  public enum DecompressionMethods {
    Deflate = 2,
    GZip = 1,
    None = 0,
  }
  public class DnsEndPoint : EndPoint {
    public DnsEndPoint(string host, int port);
    public DnsEndPoint(string host, int port, AddressFamily addressFamily);
    public override AddressFamily AddressFamily { get; }
    public string Host { get; }
    public int Port { get; }
    public override bool Equals(object comparand);
    public override int GetHashCode();
    public override string ToString();
  }
  public abstract class EndPoint {
    protected EndPoint();
    public virtual AddressFamily AddressFamily { get; }
    public virtual EndPoint Create(SocketAddress socketAddress);
    public virtual SocketAddress Serialize();
  }
  public enum HttpStatusCode {
    Accepted = 202,
    Ambiguous = 300,
    BadGateway = 502,
    BadRequest = 400,
    Conflict = 409,
    Continue = 100,
    Created = 201,
    ExpectationFailed = 417,
    Forbidden = 403,
    Found = 302,
    GatewayTimeout = 504,
    Gone = 410,
    HttpVersionNotSupported = 505,
    InternalServerError = 500,
    LengthRequired = 411,
    MethodNotAllowed = 405,
    Moved = 301,
    MovedPermanently = 301,
    MultipleChoices = 300,
    NoContent = 204,
    NonAuthoritativeInformation = 203,
    NotAcceptable = 406,
    NotFound = 404,
    NotImplemented = 501,
    NotModified = 304,
    OK = 200,
    PartialContent = 206,
    PaymentRequired = 402,
    PreconditionFailed = 412,
    ProxyAuthenticationRequired = 407,
    Redirect = 302,
    RedirectKeepVerb = 307,
    RedirectMethod = 303,
    RequestedRangeNotSatisfiable = 416,
    RequestEntityTooLarge = 413,
    RequestTimeout = 408,
    RequestUriTooLong = 414,
    ResetContent = 205,
    SeeOther = 303,
    ServiceUnavailable = 503,
    SwitchingProtocols = 101,
    TemporaryRedirect = 307,
    Unauthorized = 401,
    UnsupportedMediaType = 415,
    Unused = 306,
    UpgradeRequired = 426,
    UseProxy = 305,
  }
  public interface ICredentials {
    NetworkCredential GetCredential(Uri uri, string authType);
  }
  public interface ICredentialsByHost {
    NetworkCredential GetCredential(string host, int port, string authenticationType);
  }
  public class IPAddress {
    public static readonly IPAddress Any;
    public static readonly IPAddress Broadcast;
    public static readonly IPAddress IPv6Any;
    public static readonly IPAddress IPv6Loopback;
    public static readonly IPAddress IPv6None;
    public static readonly IPAddress Loopback;
    public static readonly IPAddress None;
    public IPAddress(byte[] address);
    public IPAddress(byte[] address, long scopeid);
    public IPAddress(long newAddress);
    public AddressFamily AddressFamily { get; }
    public bool IsIPv4MappedToIPv6 { get; }
    public bool IsIPv6LinkLocal { get; }
    public bool IsIPv6Multicast { get; }
    public bool IsIPv6SiteLocal { get; }
    public bool IsIPv6Teredo { get; }
    public long ScopeId { get; set; }
    public override bool Equals(object comparand);
    public byte[] GetAddressBytes();
    public override int GetHashCode();
    public static short HostToNetworkOrder(short host);
    public static int HostToNetworkOrder(int host);
    public static long HostToNetworkOrder(long host);
    public static bool IsLoopback(IPAddress address);
    public IPAddress MapToIPv4();
    public IPAddress MapToIPv6();
    public static short NetworkToHostOrder(short network);
    public static int NetworkToHostOrder(int network);
    public static long NetworkToHostOrder(long network);
    public static IPAddress Parse(string ipString);
    public override string ToString();
    public static bool TryParse(string ipString, out IPAddress address);
  }
  public class IPEndPoint : EndPoint {
    public const int MaxPort = 65535;
    public const int MinPort = 0;
    public IPEndPoint(long address, int port);
    public IPEndPoint(IPAddress address, int port);
    public IPAddress Address { get; set; }
    public override AddressFamily AddressFamily { get; }
    public int Port { get; set; }
    public override EndPoint Create(SocketAddress socketAddress);
    public override bool Equals(object comparand);
    public override int GetHashCode();
    public override SocketAddress Serialize();
    public override string ToString();
  }
  public interface IWebProxy {
    ICredentials Credentials { get; set; }
    Uri GetProxy(Uri destination);
    bool IsBypassed(Uri host);
  }
  public class NetworkCredential : ICredentials, ICredentialsByHost {
    public NetworkCredential();
    public NetworkCredential(string userName, string password);
    public NetworkCredential(string userName, string password, string domain);
    public string Domain { get; set; }
    public string Password { get; set; }
    public string UserName { get; set; }
    public NetworkCredential GetCredential(string host, int port, string authenticationType);
    public NetworkCredential GetCredential(Uri uri, string authType);
  }
  public class SocketAddress {
    public SocketAddress(AddressFamily family);
    public SocketAddress(AddressFamily family, int size);
    public AddressFamily Family { get; }
    public int Size { get; }
    public byte this[int offset] { get; set; }
    public override bool Equals(object comparand);
    public override int GetHashCode();
    public override string ToString();
  }
  public abstract class TransportContext {
    protected TransportContext();
    public abstract ChannelBinding GetChannelBinding(ChannelBindingKind kind);
  }
 }
 namespace System.Net.NetworkInformation {
  public class IPAddressCollection : ICollection<IPAddress>, IEnumerable, IEnumerable<IPAddress> {
    protected internal IPAddressCollection();
    public virtual int Count { get; }
    public virtual bool IsReadOnly { get; }
    public virtual IPAddress this[int index] { get; }
    public virtual void Add(IPAddress address);
    public virtual void Clear();
    public virtual bool Contains(IPAddress address);
    public virtual void CopyTo(IPAddress[] array, int offset);
    public virtual IEnumerator<IPAddress> GetEnumerator();
    public virtual bool Remove(IPAddress address);
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
  }
+ public class NetworkInformationException : Win32Exception {
+   public NetworkInformationException();
+   public NetworkInformationException(int errorCode);
+   public int ErrorCode { get; }
  }
 }
 namespace System.Net.Security {
  public enum AuthenticationLevel {
    MutualAuthRequested = 1,
    MutualAuthRequired = 2,
    None = 0,
  }
+ public enum ProtectionLevel {
+   EncryptAndSign = 2,
+   None = 0,
+   Sign = 1,
  }
  public enum SslPolicyErrors {
    None = 0,
    RemoteCertificateChainErrors = 4,
    RemoteCertificateNameMismatch = 2,
    RemoteCertificateNotAvailable = 1,
  }
 }
 namespace System.Net.Sockets {
  public enum AddressFamily {
    AppleTalk = 16,
    Atm = 22,
    Banyan = 21,
    Ccitt = 10,
    Chaos = 5,
    Cluster = 24,
    DataKit = 9,
    DataLink = 13,
    DecNet = 12,
    Ecma = 8,
    FireFox = 19,
    HyperChannel = 15,
    Ieee12844 = 25,
    ImpLink = 3,
    InterNetwork = 2,
    InterNetworkV6 = 23,
    Ipx = 6,
    Irda = 26,
    Iso = 7,
    Lat = 14,
+   Max = 29,
    NetBios = 17,
    NetworkDesigners = 28,
    NS = 6,
    Osi = 7,
    Pup = 4,
    Sna = 11,
    Unix = 1,
    Unknown = -1,
    Unspecified = 0,
    VoiceView = 18,
  }
  public enum SocketError {
    AccessDenied = 10013,
    AddressAlreadyInUse = 10048,
    AddressFamilyNotSupported = 10047,
    AddressNotAvailable = 10049,
    AlreadyInProgress = 10037,
    ConnectionAborted = 10053,
    ConnectionRefused = 10061,
    ConnectionReset = 10054,
    DestinationAddressRequired = 10039,
    Disconnecting = 10101,
    Fault = 10014,
    HostDown = 10064,
    HostNotFound = 11001,
    HostUnreachable = 10065,
    InProgress = 10036,
    Interrupted = 10004,
    InvalidArgument = 10022,
    IOPending = 997,
    IsConnected = 10056,
    MessageSize = 10040,
    NetworkDown = 10050,
    NetworkReset = 10052,
    NetworkUnreachable = 10051,
    NoBufferSpaceAvailable = 10055,
    NoData = 11004,
    NoRecovery = 11003,
    NotConnected = 10057,
    NotInitialized = 10093,
    NotSocket = 10038,
    OperationAborted = 995,
    OperationNotSupported = 10045,
    ProcessLimit = 10067,
    ProtocolFamilyNotSupported = 10046,
    ProtocolNotSupported = 10043,
    ProtocolOption = 10042,
    ProtocolType = 10041,
    Shutdown = 10058,
    SocketError = -1,
    SocketNotSupported = 10044,
    Success = 0,
    SystemNotReady = 10091,
    TimedOut = 10060,
    TooManyOpenSockets = 10024,
    TryAgain = 11002,
    TypeNotFound = 10109,
    VersionNotSupported = 10092,
    WouldBlock = 10035,
  }
  public class SocketException : ExceptionWin32Exception {
    public SocketException();
    public SocketException(int errorCode);
+   public int ErrorCode { get; }
    public override string Message { get; }
    public SocketError SocketErrorCode { get; }
  }
 }
 namespace System.Security.Authentication {
  public enum CipherAlgorithmType {
    Aes = 26129,
    Aes128 = 26126,
    Aes192 = 26127,
    Aes256 = 26128,
    Des = 26113,
    None = 0,
    Null = 24576,
    Rc2 = 26114,
    Rc4 = 26625,
    TripleDes = 26115,
  }
  public enum ExchangeAlgorithmType {
    DiffieHellman = 43522,
    None = 0,
    RsaKeyX = 41984,
    RsaSign = 9216,
  }
  public enum HashAlgorithmType {
    Md5 = 32771,
    None = 0,
    Sha1 = 32772,
  }
  public enum SslProtocols {
    None = 0,
    Ssl2 = 12,
    Ssl3 = 48,
    Tls = 192,
    Tls11 = 768,
    Tls12 = 3072,
  }
 }
 namespace System.Security.Authentication.ExtendedProtection {
  public abstract class ChannelBinding : SafeHandle {
    protected ChannelBinding();
    protected ChannelBinding(bool ownsHandle);
+   public override bool IsInvalid { get; }
    public abstract int Size { get; }
  }
  public enum ChannelBindingKind {
    Endpoint = 26,
    Unique = 25,
    Unknown = 0,
  }
 }
```

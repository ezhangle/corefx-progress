﻿namespace System.Net.Sockets {
  public enum IOControlCode : long {
    AbsorbRouterAlert = (long)2550136837,
    AddMulticastGroupOnInterface = (long)2550136842,
    AddressListChange = (long)671088663,
    AddressListQuery = (long)1207959574,
    AddressListSort = (long)3355443225,
    AssociateHandle = (long)2281701377,
    AsyncIO = (long)2147772029,
    BindToInterface = (long)2550136840,
    DataToRead = (long)1074030207,
    DeleteMulticastGroupFromInterface = (long)2550136843,
    EnableCircularQueuing = (long)671088642,
    Flush = (long)671088644,
    GetBroadcastAddress = (long)1207959557,
    GetExtensionFunctionPointer = (long)3355443206,
    GetGroupQos = (long)3355443208,
    GetQos = (long)3355443207,
    KeepAliveValues = (long)2550136836,
    LimitBroadcasts = (long)2550136839,
    MulticastInterface = (long)2550136841,
    MulticastScope = (long)2281701386,
    MultipointLoopback = (long)2281701385,
    NamespaceChange = (long)2281701401,
    NonBlockingIO = (long)2147772030,
    OobDataRead = (long)1074033415,
    QueryTargetPnpHandle = (long)1207959576,
    ReceiveAll = (long)2550136833,
    ReceiveAllIgmpMulticast = (long)2550136835,
    ReceiveAllMulticast = (long)2550136834,
    RoutingInterfaceChange = (long)2281701397,
    RoutingInterfaceQuery = (long)3355443220,
    SetGroupQos = (long)2281701388,
    SetQos = (long)2281701387,
    TranslateHandle = (long)3355443213,
    UnicastInterface = (long)2550136838,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct IPPacketInformation {
    public IPAddress Address { get; }
    public int Interface { get; }
    public override bool Equals(object comparand);
    public override int GetHashCode();
    public static bool operator ==(IPPacketInformation packetInformation1, IPPacketInformation packetInformation2);
    public static bool operator !=(IPPacketInformation packetInformation1, IPPacketInformation packetInformation2);
  }
  public enum IPProtectionLevel {
    EdgeRestricted = 20,
    Restricted = 30,
    Unrestricted = 10,
    Unspecified = -1,
  }
  public class IPv6MulticastOption {
    public IPv6MulticastOption(IPAddress group);
    public IPv6MulticastOption(IPAddress group, long ifindex);
    public IPAddress Group { get; set; }
    public long InterfaceIndex { get; set; }
  }
  public class LingerOption {
    public LingerOption(bool enable, int seconds);
    public bool Enabled { get; set; }
    public int LingerTime { get; set; }
  }
  public class MulticastOption {
    public MulticastOption(IPAddress group);
    public MulticastOption(IPAddress group, int interfaceIndex);
    public MulticastOption(IPAddress group, IPAddress mcint);
    public IPAddress Group { get; set; }
    public int InterfaceIndex { get; set; }
    public IPAddress LocalAddress { get; set; }
  }
  public class NetworkStream : Stream {
    public NetworkStream(Socket socket);
    public NetworkStream(Socket socket, bool ownsSocket);
    public override bool CanRead { get; }
    public override bool CanSeek { get; }
    public override bool CanTimeout { get; }
    public override bool CanWrite { get; }
    public virtual bool DataAvailable { get; }
    public override long Length { get; }
    public override long Position { get; set; }
    public override int ReadTimeout { get; set; }
    public override int WriteTimeout { get; set; }
    protected override void Dispose(bool disposing);
    ~NetworkStream();
    public override void Flush();
    public override Task FlushAsync(CancellationToken cancellationToken);
    public override int Read(byte[] buffer, int offset, int size);
    public override long Seek(long offset, SeekOrigin origin);
    public override void SetLength(long value);
    public override void Write(byte[] buffer, int offset, int size);
  }
  public enum ProtocolType {
    Ggp = 3,
    Icmp = 1,
    IcmpV6 = 58,
    Idp = 22,
    Igmp = 2,
    IP = 0,
    IPSecAuthenticationHeader = 51,
    IPSecEncapsulatingSecurityPayload = 50,
    IPv4 = 4,
    IPv6 = 41,
    IPv6DestinationOptions = 60,
    IPv6FragmentHeader = 44,
    IPv6HopByHopOptions = 0,
    IPv6NoNextHeader = 59,
    IPv6RoutingHeader = 43,
    Ipx = 1000,
    ND = 77,
    Pup = 12,
    Raw = 255,
    Spx = 1256,
    SpxII = 1257,
    Tcp = 6,
    Udp = 17,
    Unknown = -1,
    Unspecified = 0,
  }
  public enum SelectMode {
    SelectError = 2,
    SelectRead = 0,
    SelectWrite = 1,
  }
  public class SendPacketsElement {
    public SendPacketsElement(byte[] buffer);
    public SendPacketsElement(byte[] buffer, int offset, int count);
    public SendPacketsElement(byte[] buffer, int offset, int count, bool endOfPacket);
    public SendPacketsElement(string filepath);
    public SendPacketsElement(string filepath, int offset, int count);
    public SendPacketsElement(string filepath, int offset, int count, bool endOfPacket);
    public byte[] Buffer { get; }
    public int Count { get; }
    public bool EndOfPacket { get; }
    public string FilePath { get; }
    public int Offset { get; }
  }
  public class Socket : IDisposable {
    public Socket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType);
    public Socket(SocketInformation socketInformation);
    public Socket(SocketType socketType, ProtocolType protocolType);
    public AddressFamily AddressFamily { get; }
    public int Available { get; }
    public bool Blocking { get; set; }
    public bool Connected { get; }
    public bool DontFragment { get; set; }
    public bool DualMode { get; set; }
    public bool EnableBroadcast { get; set; }
    public bool ExclusiveAddressUse { get; set; }
    public IntPtr Handle { get; }
    public bool IsBound { get; }
    public LingerOption LingerState { get; set; }
    public EndPoint LocalEndPoint { get; }
    public bool MulticastLoopback { get; set; }
    public bool NoDelay { get; set; }
    public static bool OSSupportsIPv4 { get; }
    public static bool OSSupportsIPv6 { get; }
    public ProtocolType ProtocolType { get; }
    public int ReceiveBufferSize { get; set; }
    public int ReceiveTimeout { get; set; }
    public EndPoint RemoteEndPoint { get; }
    public int SendBufferSize { get; set; }
    public int SendTimeout { get; set; }
    public SocketType SocketType { get; }
    public short Ttl { get; set; }
    public bool UseOnlyOverlappedIO { get; set; }
    public Socket Accept();
    public bool AcceptAsync(SocketAsyncEventArgs e);
    public IAsyncResult BeginAccept(AsyncCallback callback, object state);
    public IAsyncResult BeginAccept(int receiveSize, AsyncCallback callback, object state);
    public IAsyncResult BeginAccept(Socket acceptSocket, int receiveSize, AsyncCallback callback, object state);
    public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state);
    public IAsyncResult BeginConnect(IPAddress address, int port, AsyncCallback requestCallback, object state);
    public IAsyncResult BeginConnect(IPAddress[] addresses, int port, AsyncCallback requestCallback, object state);
    public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state);
    public IAsyncResult BeginDisconnect(bool reuseSocket, AsyncCallback callback, object state);
    public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state);
    public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state);
    public IAsyncResult BeginReceive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, AsyncCallback callback, object state);
    public IAsyncResult BeginReceive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state);
    public IAsyncResult BeginReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, AsyncCallback callback, object state);
    public IAsyncResult BeginReceiveMessageFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, AsyncCallback callback, object state);
    public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state);
    public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state);
    public IAsyncResult BeginSend(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, AsyncCallback callback, object state);
    public IAsyncResult BeginSend(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state);
    public IAsyncResult BeginSendFile(string fileName, AsyncCallback callback, object state);
    public IAsyncResult BeginSendFile(string fileName, byte[] preBuffer, byte[] postBuffer, TransmitFileOptions flags, AsyncCallback callback, object state);
    public IAsyncResult BeginSendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP, AsyncCallback callback, object state);
    public void Bind(EndPoint localEP);
    public static void CancelConnectAsync(SocketAsyncEventArgs e);
    public void Connect(EndPoint remoteEP);
    public void Connect(IPAddress address, int port);
    public void Connect(IPAddress[] addresses, int port);
    public void Connect(string host, int port);
    public bool ConnectAsync(SocketAsyncEventArgs e);
    public static bool ConnectAsync(SocketType socketType, ProtocolType protocolType, SocketAsyncEventArgs e);
    public void Disconnect(bool reuseSocket);
    public bool DisconnectAsync(SocketAsyncEventArgs e);
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public SocketInformation DuplicateAndClose(int targetProcessId);
    public Socket EndAccept(out byte[] buffer, IAsyncResult asyncResult);
    public Socket EndAccept(out byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult);
    public Socket EndAccept(IAsyncResult asyncResult);
    public void EndConnect(IAsyncResult asyncResult);
    public void EndDisconnect(IAsyncResult asyncResult);
    public int EndReceive(IAsyncResult asyncResult);
    public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode);
    public int EndReceiveFrom(IAsyncResult asyncResult, ref EndPoint endPoint);
    public int EndReceiveMessageFrom(IAsyncResult asyncResult, ref SocketFlags socketFlags, ref EndPoint endPoint, out IPPacketInformation ipPacketInformation);
    public int EndSend(IAsyncResult asyncResult);
    public int EndSend(IAsyncResult asyncResult, out SocketError errorCode);
    public void EndSendFile(IAsyncResult asyncResult);
    public int EndSendTo(IAsyncResult asyncResult);
    ~Socket();
    public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName);
    public void GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue);
    public byte[] GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionLength);
    public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue);
    public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue);
    public void Listen(int backlog);
    public bool Poll(int microSeconds, SelectMode mode);
    public int Receive(byte[] buffer);
    public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags);
    public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode);
    public int Receive(byte[] buffer, int size, SocketFlags socketFlags);
    public int Receive(byte[] buffer, SocketFlags socketFlags);
    public int Receive(IList<ArraySegment<byte>> buffers);
    public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags);
    public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode);
    public bool ReceiveAsync(SocketAsyncEventArgs e);
    public int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP);
    public int ReceiveFrom(byte[] buffer, int size, SocketFlags socketFlags, ref EndPoint remoteEP);
    public int ReceiveFrom(byte[] buffer, ref EndPoint remoteEP);
    public int ReceiveFrom(byte[] buffer, SocketFlags socketFlags, ref EndPoint remoteEP);
    public bool ReceiveFromAsync(SocketAsyncEventArgs e);
    public int ReceiveMessageFrom(byte[] buffer, int offset, int size, ref SocketFlags socketFlags, ref EndPoint remoteEP, out IPPacketInformation ipPacketInformation);
    public bool ReceiveMessageFromAsync(SocketAsyncEventArgs e);
    public static void Select(IList checkRead, IList checkWrite, IList checkError, int microSeconds);
    public int Send(byte[] buffer);
    public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags);
    public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode);
    public int Send(byte[] buffer, int size, SocketFlags socketFlags);
    public int Send(byte[] buffer, SocketFlags socketFlags);
    public int Send(IList<ArraySegment<byte>> buffers);
    public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags);
    public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode);
    public bool SendAsync(SocketAsyncEventArgs e);
    public void SendFile(string fileName);
    public void SendFile(string fileName, byte[] preBuffer, byte[] postBuffer, TransmitFileOptions flags);
    public bool SendPacketsAsync(SocketAsyncEventArgs e);
    public int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP);
    public int SendTo(byte[] buffer, int size, SocketFlags socketFlags, EndPoint remoteEP);
    public int SendTo(byte[] buffer, EndPoint remoteEP);
    public int SendTo(byte[] buffer, SocketFlags socketFlags, EndPoint remoteEP);
    public bool SendToAsync(SocketAsyncEventArgs e);
    public void SetIPProtectionLevel(IPProtectionLevel level);
    public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, bool optionValue);
    public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue);
    public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue);
    public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, object optionValue);
    public void Shutdown(SocketShutdown how);
  }
  public class SocketAsyncEventArgs : EventArgs, IDisposable {
    public SocketAsyncEventArgs();
    public Socket AcceptSocket { get; set; }
    public byte[] Buffer { get; }
    public IList<ArraySegment<byte>> BufferList { get; set; }
    public int BytesTransferred { get; }
    public Exception ConnectByNameError { get; }
    public Socket ConnectSocket { get; }
    public int Count { get; }
    public bool DisconnectReuseSocket { get; set; }
    public SocketAsyncOperation LastOperation { get; }
    public int Offset { get; }
    public IPPacketInformation ReceiveMessageFromPacketInfo { get; }
    public EndPoint RemoteEndPoint { get; set; }
    public SendPacketsElement[] SendPacketsElements { get; set; }
    public TransmitFileOptions SendPacketsFlags { get; set; }
    public int SendPacketsSendSize { get; set; }
    public SocketError SocketError { get; set; }
    public SocketFlags SocketFlags { get; set; }
    public object UserToken { get; set; }
    public event EventHandler<SocketAsyncEventArgs> Completed;
    public void Dispose();
    ~SocketAsyncEventArgs();
    protected virtual void OnCompleted(SocketAsyncEventArgs e);
    public void SetBuffer(byte[] buffer, int offset, int count);
    public void SetBuffer(int offset, int count);
  }
  public enum SocketAsyncOperation {
    Accept = 1,
    Connect = 2,
    Disconnect = 3,
    None = 0,
    Receive = 4,
    ReceiveFrom = 5,
    ReceiveMessageFrom = 6,
    Send = 7,
    SendPackets = 8,
    SendTo = 9,
  }
  public enum SocketFlags {
    Broadcast = 1024,
    ControlDataTruncated = 512,
    DontRoute = 4,
    MaxIOVectorLength = 16,
    Multicast = 2048,
    None = 0,
    OutOfBand = 1,
    Partial = 32768,
    Peek = 2,
    Truncated = 256,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct SocketInformation {
    public SocketInformationOptions Options { get; set; }
    public byte[] ProtocolInformation { get; set; }
  }
  public enum SocketInformationOptions {
    Connected = 2,
    Listening = 4,
    NonBlocking = 1,
    UseOnlyOverlappedIO = 8,
  }
  public enum SocketOptionLevel {
    IP = 0,
    IPv6 = 41,
    Socket = 65535,
    Tcp = 6,
    Udp = 17,
  }
  public enum SocketOptionName {
    AcceptConnection = 2,
    AddMembership = 12,
    AddSourceMembership = 15,
    BlockSource = 17,
    Broadcast = 32,
    BsdUrgent = 2,
    ChecksumCoverage = 20,
    Debug = 1,
    DontFragment = 14,
    DontLinger = -129,
    DontRoute = 16,
    DropMembership = 13,
    DropSourceMembership = 16,
    Error = 4103,
    ExclusiveAddressUse = -5,
    Expedited = 2,
    HeaderIncluded = 2,
    HopLimit = 21,
    IPOptions = 1,
    IPProtectionLevel = 23,
    IpTimeToLive = 4,
    IPv6Only = 27,
    KeepAlive = 8,
    Linger = 128,
    MaxConnections = 2147483647,
    MulticastInterface = 9,
    MulticastLoopback = 11,
    MulticastTimeToLive = 10,
    NoChecksum = 1,
    NoDelay = 1,
    OutOfBandInline = 256,
    PacketInformation = 19,
    ReceiveBuffer = 4098,
    ReceiveLowWater = 4100,
    ReceiveTimeout = 4102,
    ReuseAddress = 4,
    SendBuffer = 4097,
    SendLowWater = 4099,
    SendTimeout = 4101,
    Type = 4104,
    TypeOfService = 3,
    UnblockSource = 18,
    UpdateAcceptContext = 28683,
    UpdateConnectContext = 28688,
    UseLoopback = 64,
  }
  public enum SocketShutdown {
    Both = 2,
    Receive = 0,
    Send = 1,
  }
  public enum SocketType {
    Dgram = 2,
    Raw = 3,
    Rdm = 4,
    Seqpacket = 5,
    Stream = 1,
    Unknown = -1,
  }
  public class TcpClient : IDisposable {
    public TcpClient();
    public TcpClient(IPEndPoint localEP);
    public TcpClient(AddressFamily family);
    public TcpClient(string hostname, int port);
    protected bool Active { get; set; }
    public int Available { get; }
    public Socket Client { get; set; }
    public bool Connected { get; }
    public bool ExclusiveAddressUse { get; set; }
    public LingerOption LingerState { get; set; }
    public bool NoDelay { get; set; }
    public int ReceiveBufferSize { get; set; }
    public int ReceiveTimeout { get; set; }
    public int SendBufferSize { get; set; }
    public int SendTimeout { get; set; }
    public IAsyncResult BeginConnect(IPAddress address, int port, AsyncCallback requestCallback, object state);
    public IAsyncResult BeginConnect(IPAddress[] addresses, int port, AsyncCallback requestCallback, object state);
    public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state);
    public void Connect(IPAddress address, int port);
    public void Connect(IPAddress[] ipAddresses, int port);
    public void Connect(IPEndPoint remoteEP);
    public void Connect(string hostname, int port);
    public Task ConnectAsync(IPAddress address, int port);
    public Task ConnectAsync(IPAddress[] addresses, int port);
    public Task ConnectAsync(string host, int port);
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public void EndConnect(IAsyncResult asyncResult);
    ~TcpClient();
    public NetworkStream GetStream();
  }
  public class TcpListener {
    public TcpListener(IPAddress localaddr, int port);
    public TcpListener(IPEndPoint localEP);
    protected bool Active { get; }
    public bool ExclusiveAddressUse { get; set; }
    public EndPoint LocalEndpoint { get; }
    public Socket Server { get; }
    public Socket AcceptSocket();
    public Task<Socket> AcceptSocketAsync();
    public TcpClient AcceptTcpClient();
    public Task<TcpClient> AcceptTcpClientAsync();
    public void AllowNatTraversal(bool allowed);
    public IAsyncResult BeginAcceptSocket(AsyncCallback callback, object state);
    public IAsyncResult BeginAcceptTcpClient(AsyncCallback callback, object state);
    public static TcpListener Create(int port);
    public Socket EndAcceptSocket(IAsyncResult asyncResult);
    public TcpClient EndAcceptTcpClient(IAsyncResult asyncResult);
    public bool Pending();
    public void Start();
    public void Start(int backlog);
    public void Stop();
  }
  public enum TransmitFileOptions {
    Disconnect = 1,
    ReuseSocket = 2,
    UseDefaultWorkerThread = 0,
    UseKernelApc = 32,
    UseSystemThread = 16,
    WriteBehind = 4,
  }
  public class UdpClient : IDisposable {
    public UdpClient();
    public UdpClient(int port);
    public UdpClient(int port, AddressFamily family);
    public UdpClient(IPEndPoint localEP);
    public UdpClient(AddressFamily family);
    public UdpClient(string hostname, int port);
    protected bool Active { get; set; }
    public int Available { get; }
    public Socket Client { get; set; }
    public bool DontFragment { get; set; }
    public bool EnableBroadcast { get; set; }
    public bool ExclusiveAddressUse { get; set; }
    public bool MulticastLoopback { get; set; }
    public short Ttl { get; set; }
    public void AllowNatTraversal(bool allowed);
    public IAsyncResult BeginReceive(AsyncCallback requestCallback, object state);
    public IAsyncResult BeginSend(byte[] datagram, int bytes, AsyncCallback requestCallback, object state);
    public IAsyncResult BeginSend(byte[] datagram, int bytes, IPEndPoint endPoint, AsyncCallback requestCallback, object state);
    public IAsyncResult BeginSend(byte[] datagram, int bytes, string hostname, int port, AsyncCallback requestCallback, object state);
    public void Connect(IPAddress addr, int port);
    public void Connect(IPEndPoint endPoint);
    public void Connect(string hostname, int port);
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public void DropMulticastGroup(IPAddress multicastAddr);
    public void DropMulticastGroup(IPAddress multicastAddr, int ifindex);
    public byte[] EndReceive(IAsyncResult asyncResult, ref IPEndPoint remoteEP);
    public int EndSend(IAsyncResult asyncResult);
    public void JoinMulticastGroup(int ifindex, IPAddress multicastAddr);
    public void JoinMulticastGroup(IPAddress multicastAddr);
    public void JoinMulticastGroup(IPAddress multicastAddr, int timeToLive);
    public void JoinMulticastGroup(IPAddress multicastAddr, IPAddress localAddress);
    public byte[] Receive(ref IPEndPoint remoteEP);
    public Task<UdpReceiveResult> ReceiveAsync();
    public int Send(byte[] dgram, int bytes);
    public int Send(byte[] dgram, int bytes, IPEndPoint endPoint);
    public int Send(byte[] dgram, int bytes, string hostname, int port);
    public Task<int> SendAsync(byte[] datagram, int bytes);
    public Task<int> SendAsync(byte[] datagram, int bytes, IPEndPoint endPoint);
    public Task<int> SendAsync(byte[] datagram, int bytes, string hostname, int port);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct UdpReceiveResult : IEquatable<UdpReceiveResult> {
    public UdpReceiveResult(byte[] buffer, IPEndPoint remoteEndPoint);
    public byte[] Buffer { get; }
    public IPEndPoint RemoteEndPoint { get; }
    public bool Equals(UdpReceiveResult other);
    public override bool Equals(object obj);
    public override int GetHashCode();
    public static bool operator ==(UdpReceiveResult left, UdpReceiveResult right);
    public static bool operator !=(UdpReceiveResult left, UdpReceiveResult right);
  }
}

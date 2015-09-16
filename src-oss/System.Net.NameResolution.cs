﻿namespace System.Net {
  public static class Dns {
    public static Task<IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress);
    public static Task<IPHostEntry> GetHostEntryAsync(IPAddress address);
    public static Task<IPHostEntry> GetHostEntryAsync(string hostNameOrAddress);
    public static string GetHostName();
  }
  public class IPHostEntry {
    public IPHostEntry();
    public IPAddress[] AddressList { get; set; }
    public string[] Aliases { get; set; }
    public string HostName { get; set; }
  }
}
namespace System.Net.Internals {
  public enum SocketType {
    Dgram = 2,
    Raw = 3,
    Rdm = 4,
    Seqpacket = 5,
    Stream = 1,
    Unknown = -1,
  }
}
namespace System.Net.Sockets {
  public static class IPAddressExtensions {
    public static long GetAddress(this IPAddress thisObj);
    public static IPAddress Snapshot(this IPAddress original);
  }
}

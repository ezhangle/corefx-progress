﻿namespace Microsoft.Win32 {
  public static class Registry {
    public static readonly RegistryKey ClassesRoot;
    public static readonly RegistryKey CurrentConfig;
    public static readonly RegistryKey CurrentUser;
    public static readonly RegistryKey LocalMachine;
    public static readonly RegistryKey PerformanceData;
    public static readonly RegistryKey Users;
    public static object GetValue(string keyName, string valueName, object defaultValue);
    public static void SetValue(string keyName, string valueName, object value);
    public static void SetValue(string keyName, string valueName, object value, RegistryValueKind valueKind);
  }
  public enum RegistryHive {
    ClassesRoot = -2147483648,
    CurrentConfig = -2147483643,
    CurrentUser = -2147483647,
    LocalMachine = -2147483646,
    PerformanceData = -2147483644,
    Users = -2147483645,
  }
  public sealed class RegistryKey : IDisposable {
    public SafeRegistryHandle Handle { get; }
    public string Name { get; }
    public int SubKeyCount { get; }
    public int ValueCount { get; }
    public RegistryView View { get; }
    public RegistryKey CreateSubKey(string subkey);
    public RegistryKey CreateSubKey(string subkey, bool writable);
    public RegistryKey CreateSubKey(string subkey, bool writable, RegistryOptions options);
    public void DeleteSubKey(string subkey);
    public void DeleteSubKey(string subkey, bool throwOnMissingSubKey);
    public void DeleteSubKeyTree(string subkey);
    public void DeleteSubKeyTree(string subkey, bool throwOnMissingSubKey);
    public void DeleteValue(string name);
    public void DeleteValue(string name, bool throwOnMissingValue);
    public void Dispose();
    public void Flush();
    public static RegistryKey FromHandle(SafeRegistryHandle handle);
    public static RegistryKey FromHandle(SafeRegistryHandle handle, RegistryView view);
    public string[] GetSubKeyNames();
    public object GetValue(string name);
    public object GetValue(string name, object defaultValue);
    public object GetValue(string name, object defaultValue, RegistryValueOptions options);
    public RegistryValueKind GetValueKind(string name);
    public string[] GetValueNames();
    public static RegistryKey OpenBaseKey(RegistryHive hKey, RegistryView view);
    public static RegistryKey OpenRemoteBaseKey(RegistryHive hKey, string machineName);
    public static RegistryKey OpenRemoteBaseKey(RegistryHive hKey, string machineName, RegistryView view);
    public RegistryKey OpenSubKey(string name);
    public RegistryKey OpenSubKey(string name, bool writable);
    public RegistryKey OpenSubKey(string name, RegistryRights rights);
    public void SetValue(string name, object value);
    public void SetValue(string name, object value, RegistryValueKind valueKind);
    public override string ToString();
  }
  public enum RegistryOptions {
    None = 0,
    Volatile = 1,
  }
  public enum RegistryValueKind {
    Binary = 3,
    DWord = 4,
    ExpandString = 2,
    MultiString = 7,
    None = -1,
    QWord = 11,
    String = 1,
    Unknown = 0,
  }
  public enum RegistryValueOptions {
    DoNotExpandEnvironmentNames = 1,
    None = 0,
  }
  public enum RegistryView {
    Default = 0,
    Registry32 = 512,
    Registry64 = 256,
  }
}
namespace Microsoft.Win32.SafeHandles {
  public sealed class SafeRegistryHandle : SafeHandle {
    public SafeRegistryHandle(IntPtr preexistingHandle, bool ownsHandle);
    public override bool IsInvalid { get; }
    protected override bool ReleaseHandle();
  }
}
namespace System.Security.AccessControl {
  public enum RegistryRights {
    ChangePermissions = 262144,
    CreateLink = 32,
    CreateSubKey = 4,
    Delete = 65536,
    EnumerateSubKeys = 8,
    ExecuteKey = 131097,
    FullControl = 983103,
    Notify = 16,
    QueryValues = 1,
    ReadKey = 131097,
    ReadPermissions = 131072,
    SetValue = 2,
    TakeOwnership = 524288,
    WriteKey = 131078,
  }
}

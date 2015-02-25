﻿namespace System.ComponentModel {
  public class Win32Exception : Exception {
    public Win32Exception();
    public Win32Exception(int error);
    public Win32Exception(int error, string message);
    public Win32Exception(string message);
    public Win32Exception(string message, Exception innerException);
    public int NativeErrorCode { get; }
  }
}

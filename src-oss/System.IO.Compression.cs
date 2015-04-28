﻿namespace System.IO.Compression {
  public enum CompressionLevel {
    Fastest = 1,
    NoCompression = 2,
    Optimal = 0,
  }
  public enum CompressionMode {
    Compress = 1,
    Decompress = 0,
  }
  public class DeflateStream : Stream {
    public DeflateStream(Stream stream, CompressionLevel compressionLevel);
    public DeflateStream(Stream stream, CompressionLevel compressionLevel, bool leaveOpen);
    public DeflateStream(Stream stream, CompressionMode mode);
    public DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen);
    public Stream BaseStream { get; }
    public override bool CanRead { get; }
    public override bool CanSeek { get; }
    public override bool CanWrite { get; }
    public override long Length { get; }
    public override long Position { get; set; }
    protected override void Dispose(bool disposing);
    public override void Flush();
    public override Task FlushAsync(CancellationToken cancellationToken);
    public override int Read(byte[] array, int offset, int count);
    public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken);
    public override long Seek(long offset, SeekOrigin origin);
    public override void SetLength(long value);
    public override void Write(byte[] array, int offset, int count);
    public override Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken);
  }
  public class GZipStream : Stream {
    public GZipStream(Stream stream, CompressionLevel compressionLevel);
    public GZipStream(Stream stream, CompressionLevel compressionLevel, bool leaveOpen);
    public GZipStream(Stream stream, CompressionMode mode);
    public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen);
    public Stream BaseStream { get; }
    public override bool CanRead { get; }
    public override bool CanSeek { get; }
    public override bool CanWrite { get; }
    public override long Length { get; }
    public override long Position { get; set; }
    protected override void Dispose(bool disposing);
    public override void Flush();
    public override Task FlushAsync(CancellationToken cancellationToken);
    public override int Read(byte[] array, int offset, int count);
    public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken);
    public override long Seek(long offset, SeekOrigin origin);
    public override void SetLength(long value);
    public override void Write(byte[] array, int offset, int count);
    public override Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken);
  }
  public class ZipArchive : IDisposable {
    public ZipArchive(Stream stream);
    public ZipArchive(Stream stream, ZipArchiveMode mode);
    public ZipArchive(Stream stream, ZipArchiveMode mode, bool leaveOpen);
    public ZipArchive(Stream stream, ZipArchiveMode mode, bool leaveOpen, Encoding entryNameEncoding);
    public ReadOnlyCollection<ZipArchiveEntry> Entries { get; }
    public ZipArchiveMode Mode { get; }
    public ZipArchiveEntry CreateEntry(string entryName);
    public ZipArchiveEntry CreateEntry(string entryName, CompressionLevel compressionLevel);
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public ZipArchiveEntry GetEntry(string entryName);
  }
  public class ZipArchiveEntry {
    public ZipArchive Archive { get; }
    public long CompressedLength { get; }
    public string FullName { get; }
    public DateTimeOffset LastWriteTime { get; set; }
    public long Length { get; }
    public string Name { get; }
    public void Delete();
    public Stream Open();
    public override string ToString();
  }
  public enum ZipArchiveMode {
    Create = 1,
    Read = 0,
    Update = 2,
  }
}

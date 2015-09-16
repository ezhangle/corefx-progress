```diff
---lib-full\System.Security.Cryptography.Primitives.dll
+++lib-oss\System.Security.Cryptography.Primitives.dll
 namespace System.Security.Cryptography {
  public abstract class AsymmetricAlgorithm : IDisposable {
    protected AsymmetricAlgorithm();
    public virtual int KeySize { get; set; }
    public virtual KeySizes[] LegalKeySizes { get; }
    public void Dispose();
    protected virtual void Dispose(bool disposing);
  }
  public enum CipherMode {
    CBC = 1,
    CTS = 5,
    ECB = 2,
  }
  public class CryptographicException : Exception {
    public CryptographicException();
    public CryptographicException(int hr);
    public CryptographicException(string message);
    public CryptographicException(string message, Exception inner);
    public CryptographicException(string format, string insert);
  }
  public class CryptoStream : Stream, IDisposable {
    public CryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode);
    public override bool CanRead { get; }
    public override bool CanSeek { get; }
    public override bool CanWrite { get; }
    public bool HasFlushedFinalBlock { get; }
    public override long Length { get; }
    public override long Position { get; set; }
    protected override void Dispose(bool disposing);
    public override void Flush();
-   public override Task FlushAsync(CancellationToken cancellationToken);
    public void FlushFinalBlock();
    public override int Read(byte[] buffer, int offset, int count);
    public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
    public override long Seek(long offset, SeekOrigin origin);
    public override void SetLength(long value);
    public override void Write(byte[] buffer, int offset, int count);
    public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
  }
  public enum CryptoStreamMode {
    Read = 0,
    Write = 1,
  }
  public abstract class HashAlgorithm : IDisposable {
    protected HashAlgorithm();
    public virtual int HashSize { get; }
    public byte[] ComputeHash(byte[] buffer);
    public byte[] ComputeHash(byte[] buffer, int offset, int count);
    public byte[] ComputeHash(Stream inputStream);
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    protected abstract void HashCore(byte[] array, int ibStart, int cbSize);
    protected abstract byte[] HashFinal();
    public abstract void Initialize();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct HashAlgorithmName : IEquatable<HashAlgorithmName> {
    public HashAlgorithmName(string name);
    public static HashAlgorithmName MD5 { get; }
    public string Name { get; }
    public static HashAlgorithmName SHA1 { get; }
    public static HashAlgorithmName SHA256 { get; }
    public static HashAlgorithmName SHA384 { get; }
    public static HashAlgorithmName SHA512 { get; }
    public override bool Equals(object obj);
    public bool Equals(HashAlgorithmName other);
    public override int GetHashCode();
    public static bool operator ==(HashAlgorithmName left, HashAlgorithmName right);
    public static bool operator !=(HashAlgorithmName left, HashAlgorithmName right);
    public override string ToString();
  }
  public abstract class HMAC : KeyedHashAlgorithm {
    protected HMAC();
    public string HashName { get; set; }
    public override byte[] Key { get; set; }
    protected override void Dispose(bool disposing);
    protected override void HashCore(byte[] rgb, int ib, int cb);
    protected override byte[] HashFinal();
    public override void Initialize();
  }
  public interface ICryptoTransform : IDisposable {
    bool CanReuseTransform { get; }
    bool CanTransformMultipleBlocks { get; }
    int InputBlockSize { get; }
    int OutputBlockSize { get; }
    int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset);
    byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount);
  }
  public abstract class KeyedHashAlgorithm : HashAlgorithm {
    protected KeyedHashAlgorithm();
    public virtual byte[] Key { get; set; }
    protected override void Dispose(bool disposing);
  }
  public sealed class KeySizes {
    public KeySizes(int minSize, int maxSize, int skipSize);
    public int MaxSize { get; }
    public int MinSize { get; }
    public int SkipSize { get; }
  }
  public enum PaddingMode {
    None = 1,
    PKCS7 = 2,
    Zeros = 3,
  }
  public abstract class SymmetricAlgorithm : IDisposable {
    protected SymmetricAlgorithm();
    public virtual int BlockSize { get; set; }
    public virtual byte[] IV { get; set; }
    public virtual byte[] Key { get; set; }
    public virtual int KeySize { get; set; }
    public virtual KeySizes[] LegalBlockSizes { get; }
    public virtual KeySizes[] LegalKeySizes { get; }
    public virtual CipherMode Mode { get; set; }
    public virtual PaddingMode Padding { get; set; }
    public virtual ICryptoTransform CreateDecryptor();
    public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV);
    public virtual ICryptoTransform CreateEncryptor();
    public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV);
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public abstract void GenerateIV();
    public abstract void GenerateKey();
  }
 }
```

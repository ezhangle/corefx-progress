namespace System.Security.Cryptography {
  public abstract class Aes : SymmetricAlgorithm {
    protected Aes();
    public override KeySizes[] LegalBlockSizes { get; }
    public override KeySizes[] LegalKeySizes { get; }
    public static Aes Create();
  }
  public abstract class DeriveBytes : IDisposable {
    protected DeriveBytes();
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public abstract byte[] GetBytes(int cb);
    public abstract void Reset();
  }
  public abstract class ECDsa : AsymmetricAlgorithm {
    protected ECDsa();
    protected abstract byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm);
    protected abstract byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm);
    public virtual byte[] SignData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm);
    public virtual byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm);
    public virtual byte[] SignData(Stream data, HashAlgorithmName hashAlgorithm);
    public abstract byte[] SignHash(byte[] hash);
    public bool VerifyData(byte[] data, byte[] signature, HashAlgorithmName hashAlgorithm);
    public virtual bool VerifyData(byte[] data, int offset, int count, byte[] signature, HashAlgorithmName hashAlgorithm);
    public bool VerifyData(Stream data, byte[] signature, HashAlgorithmName hashAlgorithm);
    public abstract bool VerifyHash(byte[] hash, byte[] signature);
  }
  public class HMACMD5 : HMAC {
    public HMACMD5();
    public HMACMD5(byte[] key);
    public override int HashSize { get; }
    public override byte[] Key { get; set; }
    protected override void Dispose(bool disposing);
    protected override void HashCore(byte[] rgb, int ib, int cb);
    protected override byte[] HashFinal();
    public override void Initialize();
  }
  public class HMACSHA1 : HMAC {
    public HMACSHA1();
    public HMACSHA1(byte[] key);
    public override int HashSize { get; }
    public override byte[] Key { get; set; }
    protected override void Dispose(bool disposing);
    protected override void HashCore(byte[] rgb, int ib, int cb);
    protected override byte[] HashFinal();
    public override void Initialize();
  }
  public class HMACSHA256 : HMAC {
    public HMACSHA256();
    public HMACSHA256(byte[] key);
    public override int HashSize { get; }
    public override byte[] Key { get; set; }
    protected override void Dispose(bool disposing);
    protected override void HashCore(byte[] rgb, int ib, int cb);
    protected override byte[] HashFinal();
    public override void Initialize();
  }
  public class HMACSHA384 : HMAC {
    public HMACSHA384();
    public HMACSHA384(byte[] key);
    public override int HashSize { get; }
    public override byte[] Key { get; set; }
    protected override void Dispose(bool disposing);
    protected override void HashCore(byte[] rgb, int ib, int cb);
    protected override byte[] HashFinal();
    public override void Initialize();
  }
  public class HMACSHA512 : HMAC {
    public HMACSHA512();
    public HMACSHA512(byte[] key);
    public override int HashSize { get; }
    public override byte[] Key { get; set; }
    protected override void Dispose(bool disposing);
    protected override void HashCore(byte[] rgb, int ib, int cb);
    protected override byte[] HashFinal();
    public override void Initialize();
  }
  public sealed class IncrementalHash : IDisposable {
    public HashAlgorithmName AlgorithmName { get; }
    public void AppendData(byte[] data);
    public void AppendData(byte[] data, int offset, int count);
    public static IncrementalHash CreateHash(HashAlgorithmName hashAlgorithm);
    public static IncrementalHash CreateHMAC(HashAlgorithmName hashAlgorithm, byte[] key);
    public void Dispose();
    public byte[] GetHashAndReset();
  }
  public abstract class MD5 : HashAlgorithm {
    protected MD5();
    public static MD5 Create();
  }
  public abstract class RandomNumberGenerator : IDisposable {
    protected RandomNumberGenerator();
    public static RandomNumberGenerator Create();
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public abstract void GetBytes(byte[] data);
  }
  public class Rfc2898DeriveBytes : DeriveBytes {
    public Rfc2898DeriveBytes(byte[] password, byte[] salt, int iterations);
    public Rfc2898DeriveBytes(string password, byte[] salt);
    public Rfc2898DeriveBytes(string password, byte[] salt, int iterations);
    public Rfc2898DeriveBytes(string password, int saltSize);
    public Rfc2898DeriveBytes(string password, int saltSize, int iterations);
    public int IterationCount { get; set; }
    public byte[] Salt { get; set; }
    protected override void Dispose(bool disposing);
    public override byte[] GetBytes(int cb);
    public override void Reset();
  }
  public abstract class RSA : AsymmetricAlgorithm {
    protected KeySizes[] _legalKeySizesValue;
    protected RSA();
    public override KeySizes[] LegalKeySizes { get; }
    public abstract byte[] Decrypt(byte[] data, RSAEncryptionPadding padding);
    public abstract byte[] Encrypt(byte[] data, RSAEncryptionPadding padding);
    public abstract RSAParameters ExportParameters(bool includePrivateParameters);
    protected abstract byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm);
    protected abstract byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm);
    public abstract void ImportParameters(RSAParameters parameters);
    public virtual byte[] SignData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding);
    public byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding);
    public virtual byte[] SignData(Stream data, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding);
    public abstract byte[] SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding);
    public bool VerifyData(byte[] data, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding);
    public virtual bool VerifyData(byte[] data, int offset, int count, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding);
    public bool VerifyData(Stream data, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding);
    public abstract bool VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding);
  }
  public sealed class RSAEncryptionPadding : IEquatable<RSAEncryptionPadding> {
    public RSAEncryptionPaddingMode Mode { get; }
    public HashAlgorithmName OaepHashAlgorithm { get; }
    public static RSAEncryptionPadding OaepSHA1 { get; }
    public static RSAEncryptionPadding OaepSHA256 { get; }
    public static RSAEncryptionPadding OaepSHA384 { get; }
    public static RSAEncryptionPadding OaepSHA512 { get; }
    public static RSAEncryptionPadding Pkcs1 { get; }
    public static RSAEncryptionPadding CreateOaep(HashAlgorithmName hashAlgorithm);
    public override bool Equals(object obj);
    public bool Equals(RSAEncryptionPadding other);
    public override int GetHashCode();
    public static bool operator ==(RSAEncryptionPadding left, RSAEncryptionPadding right);
    public static bool operator !=(RSAEncryptionPadding left, RSAEncryptionPadding right);
    public override string ToString();
  }
  public enum RSAEncryptionPaddingMode {
    Oaep = 1,
    Pkcs1 = 0,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct RSAParameters {
    public byte[] D;
    public byte[] DP;
    public byte[] DQ;
    public byte[] Exponent;
    public byte[] InverseQ;
    public byte[] Modulus;
    public byte[] P;
    public byte[] Q;
  }
  public sealed class RSASignaturePadding : IEquatable<RSASignaturePadding> {
    public RSASignaturePaddingMode Mode { get; }
    public static RSASignaturePadding Pkcs1 { get; }
    public static RSASignaturePadding Pss { get; }
    public override bool Equals(object obj);
    public bool Equals(RSASignaturePadding other);
    public override int GetHashCode();
    public static bool operator ==(RSASignaturePadding left, RSASignaturePadding right);
    public static bool operator !=(RSASignaturePadding left, RSASignaturePadding right);
    public override string ToString();
  }
  public enum RSASignaturePaddingMode {
    Pkcs1 = 0,
    Pss = 1,
  }
  public abstract class SHA1 : HashAlgorithm {
    protected SHA1();
    public static SHA1 Create();
  }
  public abstract class SHA256 : HashAlgorithm {
    protected SHA256();
    public static SHA256 Create();
  }
  public abstract class SHA384 : HashAlgorithm {
    protected SHA384();
    public static SHA384 Create();
  }
  public abstract class SHA512 : HashAlgorithm {
    protected SHA512();
    public static SHA512 Create();
  }
}

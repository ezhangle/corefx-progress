namespace System.Security.Cryptography {
  public sealed class ECDsaOpenSsl : ECDsa {
    public ECDsaOpenSsl();
    public ECDsaOpenSsl(int keySize);
    public ECDsaOpenSsl(IntPtr handle);
    public override int KeySize { set; }
    public override KeySizes[] LegalKeySizes { get; }
    protected override void Dispose(bool disposing);
    protected override byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm);
    protected override byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm);
    public override byte[] SignHash(byte[] hash);
    public override bool VerifyHash(byte[] hash, byte[] signature);
  }
  public sealed class RSAOpenSsl : RSA {
    public RSAOpenSsl();
    public RSAOpenSsl(int keySize);
    public RSAOpenSsl(IntPtr handle);
    public RSAOpenSsl(RSAParameters parameters);
    public override int KeySize { set; }
    public override byte[] Decrypt(byte[] data, RSAEncryptionPadding padding);
    protected override void Dispose(bool disposing);
    public override byte[] Encrypt(byte[] data, RSAEncryptionPadding padding);
    public override RSAParameters ExportParameters(bool includePrivateParameters);
    protected override byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm);
    protected override byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm);
    public override void ImportParameters(RSAParameters parameters);
    public override byte[] SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding);
    public override bool VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding);
  }
}

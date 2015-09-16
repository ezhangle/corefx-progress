```diff
---lib-full\System.Security.Cryptography.Csp.dll
+++lib-oss\System.Security.Cryptography.Csp.dll
 namespace System.Security.Cryptography {
  public sealed class CspKeyContainerInfo {
    public CspKeyContainerInfo(CspParameters parameters);
    public bool Accessible { get; }
    public bool Exportable { get; }
    public bool HardwareDevice { get; }
    public string KeyContainerName { get; }
    public KeyNumber KeyNumber { get; }
    public bool MachineKeyStore { get; }
    public bool Protected { get; }
    public string ProviderName { get; }
    public int ProviderType { get; }
    public bool RandomlyGenerated { get; }
    public bool Removable { get; }
    public string UniqueKeyContainerName { get; }
  }
  public sealed class CspParameters {
    public int KeyNumber;
    public int ProviderType;
    public string KeyContainerName;
    public string ProviderName;
    public CspParameters();
    public CspParameters(int dwTypeIn);
    public CspParameters(int dwTypeIn, string strProviderNameIn);
    public CspParameters(int dwTypeIn, string strProviderNameIn, string strContainerNameIn);
    public CspProviderFlags Flags { get; set; }
    public IntPtr ParentWindowHandle { get; set; }
  }
  public enum CspProviderFlags {
    CreateEphemeralKey = 128,
    NoFlags = 0,
    NoPrompt = 64,
    UseArchivableKey = 16,
    UseDefaultKeyContainer = 2,
    UseExistingKey = 8,
    UseMachineKeyStore = 1,
    UseNonExportableKey = 4,
    UseUserProtectedKey = 32,
  }
  public interface ICspAsymmetricAlgorithm {
    CspKeyContainerInfo CspKeyContainerInfo { get; }
    byte[] ExportCspBlob(bool includePrivateParameters);
    void ImportCspBlob(byte[] rawData);
  }
  public enum KeyNumber {
    Exchange = 1,
    Signature = 2,
  }
  public sealed class RSACryptoServiceProvider : RSA, ICspAsymmetricAlgorithm {
    public RSACryptoServiceProvider();
    public RSACryptoServiceProvider(int dwKeySize);
    public RSACryptoServiceProvider(int dwKeySize, CspParameters parameters);
    public RSACryptoServiceProvider(CspParameters parameters);
    public CspKeyContainerInfo CspKeyContainerInfo { get; }
    public override int KeySize { get; }
    public bool PersistKeyInCsp { get; set; }
    public bool PublicOnly { get; }
    public static bool UseMachineKeyStore { get; set; }
    public byte[] Decrypt(byte[] rgb, bool fOAEP);
    public override byte[] Decrypt(byte[] data, RSAEncryptionPadding padding);
    protected override void Dispose(bool disposing);
    public byte[] Encrypt(byte[] rgb, bool fOAEP);
    public override byte[] Encrypt(byte[] data, RSAEncryptionPadding padding);
    public byte[] ExportCspBlob(bool includePrivateParameters);
    public override RSAParameters ExportParameters(bool includePrivateParameters);
    protected override byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm);
    protected override byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm);
    public void ImportCspBlob(byte[] keyBlob);
    public override void ImportParameters(RSAParameters parameters);
    public byte[] SignData(byte[] buffer, int offset, int count, object halg);
    public byte[] SignData(byte[] buffer, object halg);
    public byte[] SignData(Stream inputStream, object halg);
    public override byte[] SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding);
    public byte[] SignHash(byte[] rgbHash, string str);
    public bool VerifyData(byte[] buffer, object halg, byte[] signature);
    public override bool VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding);
    public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature);
  }
 }
```

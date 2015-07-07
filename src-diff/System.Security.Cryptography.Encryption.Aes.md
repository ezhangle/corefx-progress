```diff
---lib-full\System.Security.Cryptography.Encryption.Aes.dll
+++lib-oss\System.Security.Cryptography.Encryption.Aes.dll
 namespace System.Security.Cryptography {
  public abstract class Aes : SymmetricAlgorithm {
    protected Aes();
+   public override KeySizes[] LegalBlockSizes { get; }
+   public override KeySizes[] LegalKeySizes { get; }
    public static Aes Create();
  }
 }
```

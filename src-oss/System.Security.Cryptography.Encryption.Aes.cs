namespace System.Security.Cryptography {
  public abstract class Aes : SymmetricAlgorithm {
    protected Aes();
    public override KeySizes[] LegalBlockSizes { get; }
    public override KeySizes[] LegalKeySizes { get; }
    public static Aes Create();
  }
}

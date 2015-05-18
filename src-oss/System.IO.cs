namespace System.IO {
  public sealed class InvalidDataException : Exception {
    public InvalidDataException();
    public InvalidDataException(string message);
    public InvalidDataException(string message, Exception innerException);
  }
}

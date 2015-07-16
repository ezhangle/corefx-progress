namespace System.Numerics {
  public static class VectorExtensions {
    public static Point ToPoint(this Vector2 vector);
    public static Size ToSize(this Vector2 vector);
    public static Vector2 ToVector2(this Point point);
    public static Vector2 ToVector2(this Size size);
  }
}

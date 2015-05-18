namespace System.Threading.Tasks {
  public static class TaskExtensions {
    public static Task Unwrap(this Task<Task> task);
    public static Task<TResult> Unwrap<TResult>(this Task<Task<TResult>> task);
  }
}

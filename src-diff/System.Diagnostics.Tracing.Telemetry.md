```diff
---lib-full\System.Diagnostics.Tracing.Telemetry.dll
+++lib-oss\System.Diagnostics.Tracing.Telemetry.dll
+namespace System.Diagnostics.Tracing {
+ public class TelemetryListener : TelemetrySource, IDisposable, IObservable<KeyValuePair<string, object>> {
+   public TelemetryListener(string name);
+   public static IObservable<TelemetryListener> AllListeners { get; }
+   public static TelemetryListener DefaultListener { get; }
+   public string Name { get; }
+   public virtual void Dispose();
+   public override bool IsEnabled(string telemetryName);
+   public IDisposable Subscribe(IObserver<KeyValuePair<string, object>> observer);
+   public virtual IDisposable Subscribe(IObserver<KeyValuePair<string, object>> observer, Predicate<string> isEnabled);
+   public override string ToString();
+   public override void WriteTelemetry(string telemetryName, object arguments);
  }
+ public abstract class TelemetrySource {
+   protected TelemetrySource();
+   public static TelemetrySource DefaultSource { get; }
+   public abstract bool IsEnabled(string telemetryName);
+   public abstract void WriteTelemetry(string telemetryName, object parameters);
  }
 }
```

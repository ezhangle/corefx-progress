﻿```diff
---lib-full\System.Composition.Hosting.dll
+++lib-oss\System.Composition.Hosting.dll
+namespace System.Composition.Hosting {
+ public sealed class CompositionHost : CompositionContext, IDisposable {
+   public static CompositionHost CreateCompositionHost(IEnumerable<ExportDescriptorProvider> providers);
+   public static CompositionHost CreateCompositionHost(params ExportDescriptorProvider[] providers);
+   public void Dispose();
+   public override bool TryGetExport(CompositionContract contract, out object export);
  }
 }
+namespace System.Composition.Hosting.Core {
+ public delegate object CompositeActivator(LifetimeContext context, CompositionOperation operation);
+ public class CompositionDependency {
+   public CompositionContract Contract { get; }
+   public bool IsPrerequisite { get; }
+   public object Site { get; }
+   public ExportDescriptorPromise Target { get; }
+   public static CompositionDependency Missing(CompositionContract contract, object site);
+   public static CompositionDependency Oversupplied(CompositionContract contract, IEnumerable<ExportDescriptorPromise> targets, object site);
+   public static CompositionDependency Satisfied(CompositionContract contract, ExportDescriptorPromise target, bool isPrerequisite, object site);
+   public override string ToString();
  }
+ public sealed class CompositionOperation : IDisposable {
+   public void AddNonPrerequisiteAction(Action action);
+   public void AddPostCompositionAction(Action action);
+   public void Dispose();
+   public static object Run(LifetimeContext outermostLifetimeContext, CompositeActivator compositionRootActivator);
  }
+ public abstract class DependencyAccessor {
+   protected DependencyAccessor();
+   protected abstract IEnumerable<ExportDescriptorPromise> GetPromises(CompositionContract exportKey);
+   public IEnumerable<CompositionDependency> ResolveDependencies(object site, CompositionContract contract, bool isPrerequisite);
+   public CompositionDependency ResolveRequiredDependency(object site, CompositionContract contract, bool isPrerequisite);
+   public bool TryResolveOptionalDependency(object site, CompositionContract contract, bool isPrerequisite, out CompositionDependency dependency);
  }
+ public abstract class ExportDescriptor {
+   protected ExportDescriptor();
+   public abstract CompositeActivator Activator { get; }
+   public abstract IDictionary<string, object> Metadata { get; }
+   public static ExportDescriptor Create(CompositeActivator activator, IDictionary<string, object> metadata);
  }
+ public class ExportDescriptorPromise {
+   public ExportDescriptorPromise(CompositionContract contract, string origin, bool isShared, Func<IEnumerable<CompositionDependency>> dependencies, Func<IEnumerable<CompositionDependency>, ExportDescriptor> getDescriptor);
+   public CompositionContract Contract { get; }
+   public ReadOnlyCollection<CompositionDependency> Dependencies { get; }
+   public bool IsShared { get; }
+   public string Origin { get; }
+   public ExportDescriptor GetDescriptor();
+   public override string ToString();
  }
+ public abstract class ExportDescriptorProvider {
+   protected static readonly IDictionary<string, object> NoMetadata;
+   protected static readonly IEnumerable<ExportDescriptorPromise> NoExportDescriptors;
+   protected static readonly Func<IEnumerable<CompositionDependency>> NoDependencies;
+   protected ExportDescriptorProvider();
+   public abstract IEnumerable<ExportDescriptorPromise> GetExportDescriptors(CompositionContract contract, DependencyAccessor descriptorAccessor);
  }
+ public sealed class LifetimeContext : CompositionContext, IDisposable {
+   public void AddBoundInstance(IDisposable instance);
+   public static int AllocateSharingId();
+   public void Dispose();
+   public LifetimeContext FindContextWithin(string sharingBoundary);
+   public object GetOrCreate(int sharingId, CompositionOperation operation, CompositeActivator creator);
+   public override string ToString();
+   public override bool TryGetExport(CompositionContract contract, out object export);
  }
 }
```

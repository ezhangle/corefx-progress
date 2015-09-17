```diff
---lib-full\System.Composition.TypedParts.dll
+++lib-oss\System.Composition.TypedParts.dll
+namespace System.Composition {
+ public static class CompositionContextExtensions {
+   public static void SatisfyImports(this CompositionContext compositionContext, object objectWithLooseImports);
+   public static void SatisfyImports(this CompositionContext compositionContext, object objectWithLooseImports, AttributedModelProvider conventions);
  }
 }
+namespace System.Composition.Hosting {
+ public class ContainerConfiguration {
+   public ContainerConfiguration();
+   public CompositionHost CreateContainer();
+   public ContainerConfiguration WithAssemblies(IEnumerable<Assembly> assemblies);
+   public ContainerConfiguration WithAssemblies(IEnumerable<Assembly> assemblies, AttributedModelProvider conventions);
+   public ContainerConfiguration WithAssembly(Assembly assembly);
+   public ContainerConfiguration WithAssembly(Assembly assembly, AttributedModelProvider conventions);
+   public ContainerConfiguration WithDefaultConventions(AttributedModelProvider conventions);
+   public ContainerConfiguration WithPart(Type partType);
+   public ContainerConfiguration WithPart(Type partType, AttributedModelProvider conventions);
+   public ContainerConfiguration WithPart<TPart>();
+   public ContainerConfiguration WithPart<TPart>(AttributedModelProvider conventions);
+   public ContainerConfiguration WithParts(IEnumerable<Type> partTypes);
+   public ContainerConfiguration WithParts(IEnumerable<Type> partTypes, AttributedModelProvider conventions);
+   public ContainerConfiguration WithParts(params Type[] partTypes);
+   public ContainerConfiguration WithProvider(ExportDescriptorProvider exportDescriptorProvider);
  }
 }
```

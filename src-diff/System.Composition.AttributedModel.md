```diff
---lib-full\System.Composition.AttributedModel.dll
+++lib-oss\System.Composition.AttributedModel.dll
+namespace System.Composition {
+ public class ExportAttribute : Attribute {
+   public ExportAttribute();
+   public ExportAttribute(string contractName);
+   public ExportAttribute(string contractName, Type contractType);
+   public ExportAttribute(Type contractType);
+   public string ContractName { get; }
+   public Type ContractType { get; }
  }
+ public sealed class ExportMetadataAttribute : Attribute {
+   public ExportMetadataAttribute(string name, object value);
+   public string Name { get; }
+   public object Value { get; }
  }
+ public class ImportAttribute : Attribute {
+   public ImportAttribute();
+   public ImportAttribute(string contractName);
+   public bool AllowDefault { get; set; }
+   public string ContractName { get; }
  }
+ public sealed class ImportingConstructorAttribute : Attribute {
+   public ImportingConstructorAttribute();
  }
+ public class ImportManyAttribute : Attribute {
+   public ImportManyAttribute();
+   public ImportManyAttribute(string contractName);
+   public string ContractName { get; }
  }
+ public sealed class ImportMetadataConstraintAttribute : Attribute {
+   public ImportMetadataConstraintAttribute(string name, object value);
+   public string Name { get; }
+   public object Value { get; }
  }
+ public sealed class MetadataAttributeAttribute : Attribute {
+   public MetadataAttributeAttribute();
  }
+ public sealed class OnImportsSatisfiedAttribute : Attribute {
+   public OnImportsSatisfiedAttribute();
  }
+ public class PartMetadataAttribute : Attribute {
+   public PartMetadataAttribute(string name, object value);
+   public string Name { get; }
+   public object Value { get; }
  }
+ public sealed class PartNotDiscoverableAttribute : Attribute {
+   public PartNotDiscoverableAttribute();
  }
+ public class SharedAttribute : PartMetadataAttribute {
+   public SharedAttribute();
+   public SharedAttribute(string sharingBoundaryName);
+   public string SharingBoundary { get; }
  }
+ public sealed class SharingBoundaryAttribute : Attribute {
+   public SharingBoundaryAttribute(params string[] sharingBoundaryNames);
+   public ReadOnlyCollection<string> SharingBoundaryNames { get; }
  }
 }
+namespace System.Composition.Convention {
+ public abstract class AttributedModelProvider {
+   protected AttributedModelProvider();
+   public abstract IEnumerable<Attribute> GetCustomAttributes(Type reflectedType, MemberInfo member);
+   public abstract IEnumerable<Attribute> GetCustomAttributes(Type reflectedType, ParameterInfo parameter);
  }
 }
```

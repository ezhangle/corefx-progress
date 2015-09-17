namespace Microsoft.Composition.Demos.ExtendedCollectionImports {
  public sealed class KeyByMetadataAttribute : Attribute {
    public KeyByMetadataAttribute(string keyMetadataName);
    public string KeyMetadataName { get; }
  }
  public sealed class OrderedImportManyAttribute : ImportAttribute {
    public OrderedImportManyAttribute(string orderMetadataName);
    public string OrderMetadataName { get; }
  }
}
namespace Microsoft.Composition.Demos.ExtendedCollectionImports.Dictionaries {
  public class DictionaryExportDescriptorProvider : ExportDescriptorProvider {
    public DictionaryExportDescriptorProvider();
    public override IEnumerable<ExportDescriptorPromise> GetExportDescriptors(CompositionContract contract, DependencyAccessor descriptorAccessor);
  }
}
namespace Microsoft.Composition.Demos.ExtendedCollectionImports.OrderedCollections {
  public class OrderedImportManyExportDescriptorProvider : ExportDescriptorProvider {
    public OrderedImportManyExportDescriptorProvider();
    public override IEnumerable<ExportDescriptorPromise> GetExportDescriptors(CompositionContract contract, DependencyAccessor definitionAccessor);
  }
}

namespace System.Composition {
  public abstract class CompositionContext {
    protected CompositionContext();
    public object GetExport(CompositionContract contract);
    public object GetExport(Type exportType);
    public object GetExport(Type exportType, string contractName);
    public TExport GetExport<TExport>();
    public TExport GetExport<TExport>(string contractName);
    public IEnumerable<object> GetExports(Type exportType);
    public IEnumerable<object> GetExports(Type exportType, string contractName);
    public IEnumerable<TExport> GetExports<TExport>();
    public IEnumerable<TExport> GetExports<TExport>(string contractName);
    public abstract bool TryGetExport(CompositionContract contract, out object export);
    public bool TryGetExport(Type exportType, out object export);
    public bool TryGetExport(Type exportType, string contractName, out object export);
    public bool TryGetExport<TExport>(string contractName, out TExport export);
    public bool TryGetExport<TExport>(out TExport export);
  }
  public sealed class Export<T> : IDisposable {
    public Export(T value, Action disposeAction);
    public T Value { get; }
    public void Dispose();
  }
  public class ExportFactory<T> {
    public ExportFactory(Func<Tuple<T, Action>> exportCreator);
    public Export<T> CreateExport();
  }
  public class ExportFactory<T, TMetadata> : ExportFactory<T> {
    public ExportFactory(Func<Tuple<T, Action>> exportCreator, TMetadata metadata);
    public TMetadata Metadata { get; }
  }
}
namespace System.Composition.Hosting {
  public class CompositionFailedException : Exception {
    public CompositionFailedException();
    public CompositionFailedException(string message);
    public CompositionFailedException(string message, Exception innerException);
  }
}
namespace System.Composition.Hosting.Core {
  public sealed class CompositionContract {
    public CompositionContract(Type contractType);
    public CompositionContract(Type contractType, string contractName);
    public CompositionContract(Type contractType, string contractName, IDictionary<string, object> metadataConstraints);
    public string ContractName { get; }
    public Type ContractType { get; }
    public IEnumerable<KeyValuePair<string, object>> MetadataConstraints { get; }
    public CompositionContract ChangeType(Type newContractType);
    public override bool Equals(object obj);
    public override int GetHashCode();
    public override string ToString();
    public bool TryUnwrapMetadataConstraint<T>(string constraintName, out T constraintValue, out CompositionContract remainingContract);
  }
}

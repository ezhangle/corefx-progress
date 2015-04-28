namespace System.Runtime.InteropServices {
  public class ComAwareEventInfo : EventInfo {
    public ComAwareEventInfo(Type type, string eventName);
    public override EventAttributes Attributes { get; }
    public override Type DeclaringType { get; }
    public override string Name { get; }
    public override Type ReflectedType { get; }
    public override void AddEventHandler(object target, Delegate handler);
    public override MethodInfo GetAddMethod(bool nonPublic);
    public override object[] GetCustomAttributes(bool inherit);
    public override object[] GetCustomAttributes(Type attributeType, bool inherit);
    public override MethodInfo GetRaiseMethod(bool nonPublic);
    public override MethodInfo GetRemoveMethod(bool nonPublic);
    public override bool IsDefined(Type attributeType, bool inherit);
    public override void RemoveEventHandler(object target, Delegate handler);
  }
  public sealed class DefaultParameterValueAttribute : Attribute {
    public DefaultParameterValueAttribute(object value);
    public object Value { get; }
  }
  public sealed class HandleCollector {
    public HandleCollector(string name, int initialThreshold);
    public HandleCollector(string name, int initialThreshold, int maximumThreshold);
    public int Count { get; }
    public int InitialThreshold { get; }
    public int MaximumThreshold { get; }
    public string Name { get; }
    public void Add();
    public void Remove();
  }
}
namespace System.Runtime.InteropServices.ComTypes {
  public enum ADVF {
    ADVF_DATAONSTOP = 64,
    ADVF_NODATA = 1,
    ADVF_ONLYONCE = 4,
    ADVF_PRIMEFIRST = 2,
    ADVFCACHE_FORCEBUILTIN = 16,
    ADVFCACHE_NOHANDLER = 8,
    ADVFCACHE_ONSAVE = 32,
  }
  public enum DATADIR {
    DATADIR_GET = 1,
    DATADIR_SET = 2,
  }
  public enum DVASPECT {
    DVASPECT_CONTENT = 1,
    DVASPECT_DOCPRINT = 8,
    DVASPECT_ICON = 4,
    DVASPECT_THUMBNAIL = 2,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct FORMATETC {
    public short cfFormat;
    public int lindex;
    public IntPtr ptd;
    public DVASPECT dwAspect;
    public TYMED tymed;
  }
  public interface IAdviseSink {
    [MethodImpl(PreserveSig)]void OnClose();
    [MethodImpl(PreserveSig)]void OnDataChange(ref FORMATETC format, ref STGMEDIUM stgmedium);
    [MethodImpl(PreserveSig)]void OnRename(IMoniker moniker);
    [MethodImpl(PreserveSig)]void OnSave();
    [MethodImpl(PreserveSig)]void OnViewChange(int aspect, int index);
  }
  public interface IEnumFORMATETC {
    void Clone(out IEnumFORMATETC newEnum);
    [MethodImpl(PreserveSig)]int Next(int celt, FORMATETC[] rgelt, int[] pceltFetched);
    [MethodImpl(PreserveSig)]int Reset();
    [MethodImpl(PreserveSig)]int Skip(int celt);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct STATDATA {
    public int connection;
    public ADVF advf;
    public FORMATETC formatetc;
    public IAdviseSink advSink;
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct STGMEDIUM {
    public IntPtr unionmember;
    public object pUnkForRelease;
    public TYMED tymed;
  }
  public enum TYMED {
    TYMED_ENHMF = 64,
    TYMED_FILE = 2,
    TYMED_GDI = 16,
    TYMED_HGLOBAL = 1,
    TYMED_ISTORAGE = 8,
    TYMED_ISTREAM = 4,
    TYMED_MFPICT = 32,
    TYMED_NULL = 0,
  }
}

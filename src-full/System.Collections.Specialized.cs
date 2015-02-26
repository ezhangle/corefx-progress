﻿namespace System.Collections.Specialized {
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct BitVector32 {
    public BitVector32(BitVector32 value);
    public BitVector32(int data);
    public int Data { get; }
    public int this[BitVector32.Section section] { get; set; }
    public bool this[int bit] { get; set; }
    public static int CreateMask();
    public static int CreateMask(int previous);
    public static BitVector32.Section CreateSection(short maxValue);
    public static BitVector32.Section CreateSection(short maxValue, BitVector32.Section previous);
    public override bool Equals(object o);
    public override int GetHashCode();
    public override string ToString();
    public static string ToString(BitVector32 value);
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Section {
      public short Mask { get; }
      public short Offset { get; }
      public bool Equals(BitVector32.Section obj);
      public override bool Equals(object o);
      public override int GetHashCode();
      public static bool operator ==(BitVector32.Section a, BitVector32.Section b);
      public static bool operator !=(BitVector32.Section a, BitVector32.Section b);
      public override string ToString();
      public static string ToString(BitVector32.Section value);
    }
  }
  public class HybridDictionary : ICollection, IDictionary, IEnumerable {
    public HybridDictionary();
    public HybridDictionary(bool caseInsensitive);
    public HybridDictionary(int initialSize);
    public HybridDictionary(int initialSize, bool caseInsensitive);
    public int Count { get; }
    public bool IsFixedSize { get; }
    public bool IsReadOnly { get; }
    public bool IsSynchronized { get; }
    public ICollection Keys { get; }
    public object SyncRoot { get; }
    public object this[object key] { get; set; }
    public ICollection Values { get; }
    public void Add(object key, object value);
    public void Clear();
    public bool Contains(object key);
    public void CopyTo(Array array, int index);
    public IDictionaryEnumerator GetEnumerator();
    public void Remove(object key);
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
  }
  public interface IOrderedDictionary : ICollection, IDictionary, IEnumerable {
    object this[int index] { get; set; }
    IDictionaryEnumerator GetEnumerator();
    void Insert(int index, object key, object value);
    void RemoveAt(int index);
  }
  public class ListDictionary : ICollection, IDictionary, IEnumerable {
    public ListDictionary();
    public ListDictionary(IComparer comparer);
    public int Count { get; }
    public bool IsFixedSize { get; }
    public bool IsReadOnly { get; }
    public bool IsSynchronized { get; }
    public ICollection Keys { get; }
    public object SyncRoot { get; }
    public object this[object key] { get; set; }
    public ICollection Values { get; }
    public void Add(object key, object value);
    public void Clear();
    public bool Contains(object key);
    public void CopyTo(Array array, int index);
    public IDictionaryEnumerator GetEnumerator();
    public void Remove(object key);
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
  }
  public abstract class NameObjectCollectionBase : ICollection, IEnumerable {
    protected NameObjectCollectionBase();
    protected NameObjectCollectionBase(IEqualityComparer equalityComparer);
    protected NameObjectCollectionBase(int capacity);
    protected NameObjectCollectionBase(int capacity, IEqualityComparer equalityComparer);
    public virtual int Count { get; }
    protected bool IsReadOnly { get; set; }
    public virtual NameObjectCollectionBase.KeysCollection Keys { get; }
    bool System.Collections.ICollection.IsSynchronized { get; }
    object System.Collections.ICollection.SyncRoot { get; }
    protected void BaseAdd(string name, object value);
    protected void BaseClear();
    protected object BaseGet(int index);
    protected object BaseGet(string name);
    protected string[] BaseGetAllKeys();
    protected object[] BaseGetAllValues();
    protected object[] BaseGetAllValues(Type type);
    protected string BaseGetKey(int index);
    protected bool BaseHasKeys();
    protected void BaseRemove(string name);
    protected void BaseRemoveAt(int index);
    protected void BaseSet(int index, object value);
    protected void BaseSet(string name, object value);
    public virtual IEnumerator GetEnumerator();
    void System.Collections.ICollection.CopyTo(Array array, int index);
    public class KeysCollection : ICollection, IEnumerable {
      public int Count { get; }
      bool System.Collections.ICollection.IsSynchronized { get; }
      object System.Collections.ICollection.SyncRoot { get; }
      public string this[int index] { get; }
      public virtual string Get(int index);
      public IEnumerator GetEnumerator();
      void System.Collections.ICollection.CopyTo(Array array, int index);
    }
  }
  public class NameValueCollection : NameObjectCollectionBase {
    public NameValueCollection();
    public NameValueCollection(IEqualityComparer equalityComparer);
    public NameValueCollection(NameValueCollection col);
    public NameValueCollection(int capacity);
    public NameValueCollection(int capacity, IEqualityComparer equalityComparer);
    public NameValueCollection(int capacity, NameValueCollection col);
    public virtual string[] AllKeys { get; }
    public string this[int index] { get; }
    public string this[string name] { get; set; }
    public void Add(NameValueCollection c);
    public virtual void Add(string name, string value);
    public virtual void Clear();
    public void CopyTo(Array dest, int index);
    public virtual string Get(int index);
    public virtual string Get(string name);
    public virtual string GetKey(int index);
    public virtual string[] GetValues(int index);
    public virtual string[] GetValues(string name);
    public bool HasKeys();
    protected void InvalidateCachedArrays();
    public virtual void Remove(string name);
    public virtual void Set(string name, string value);
  }
  public class OrderedDictionary : ICollection, IDictionary, IEnumerable, IOrderedDictionary {
    public OrderedDictionary();
    public OrderedDictionary(IEqualityComparer comparer);
    public OrderedDictionary(int capacity);
    public OrderedDictionary(int capacity, IEqualityComparer comparer);
    public int Count { get; }
    public bool IsReadOnly { get; }
    public ICollection Keys { get; }
    bool System.Collections.ICollection.IsSynchronized { get; }
    object System.Collections.ICollection.SyncRoot { get; }
    bool System.Collections.IDictionary.IsFixedSize { get; }
    public object this[int index] { get; set; }
    public object this[object key] { get; set; }
    public ICollection Values { get; }
    public void Add(object key, object value);
    public OrderedDictionary AsReadOnly();
    public void Clear();
    public bool Contains(object key);
    public void CopyTo(Array array, int index);
    public virtual IDictionaryEnumerator GetEnumerator();
    public void Insert(int index, object key, object value);
    public void Remove(object key);
    public void RemoveAt(int index);
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
  }
  public class StringCollection : ICollection, IEnumerable, IList {
    public StringCollection();
    public int Count { get; }
    public bool IsReadOnly { get; }
    public bool IsSynchronized { get; }
    public object SyncRoot { get; }
    bool System.Collections.IList.IsFixedSize { get; }
    bool System.Collections.IList.IsReadOnly { get; }
    object System.Collections.IList.this[int index] { get; set; }
    public string this[int index] { get; set; }
    public int Add(string value);
    public void AddRange(string[] value);
    public void Clear();
    public bool Contains(string value);
    public void CopyTo(string[] array, int index);
    public StringEnumerator GetEnumerator();
    public int IndexOf(string value);
    public void Insert(int index, string value);
    public void Remove(string value);
    public void RemoveAt(int index);
    void System.Collections.ICollection.CopyTo(Array array, int index);
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    int System.Collections.IList.Add(object value);
    bool System.Collections.IList.Contains(object value);
    int System.Collections.IList.IndexOf(object value);
    void System.Collections.IList.Insert(int index, object value);
    void System.Collections.IList.Remove(object value);
  }
  public class StringDictionary : IEnumerable {
    public StringDictionary();
    public virtual int Count { get; }
    public virtual bool IsSynchronized { get; }
    public virtual ICollection Keys { get; }
    public virtual object SyncRoot { get; }
    public virtual string this[string key] { get; set; }
    public virtual ICollection Values { get; }
    public virtual void Add(string key, string value);
    public virtual void Clear();
    public virtual bool ContainsKey(string key);
    public virtual bool ContainsValue(string value);
    public virtual void CopyTo(Array array, int index);
    public virtual IEnumerator GetEnumerator();
    public virtual void Remove(string key);
  }
  public class StringEnumerator {
    public string Current { get; }
    public bool MoveNext();
    public void Reset();
  }
}

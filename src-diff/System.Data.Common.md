﻿```diff
---lib-full\System.Data.Common.dll
+++lib-oss\System.Data.Common.dll
 namespace System {
  public sealed class DBNull {
    public static readonly DBNull Value;
    public override string ToString();
    public string ToString(IFormatProvider provider);
  }
 }
 namespace System.Data {
  public enum CommandBehavior {
    CloseConnection = 32,
    Default = 0,
    KeyInfo = 4,
    SchemaOnly = 2,
    SequentialAccess = 16,
    SingleResult = 1,
    SingleRow = 8,
  }
  public enum CommandType {
    StoredProcedure = 4,
    TableDirect = 512,
    Text = 1,
  }
  public enum ConnectionState {
    Broken = 16,
    Closed = 0,
    Connecting = 2,
    Executing = 4,
    Fetching = 8,
    Open = 1,
  }
  public enum DbType {
    AnsiString = 0,
    AnsiStringFixedLength = 22,
    Binary = 1,
    Boolean = 3,
    Byte = 2,
    Currency = 4,
    Date = 5,
    DateTime = 6,
    DateTime2 = 26,
    DateTimeOffset = 27,
    Decimal = 7,
    Double = 8,
    Guid = 9,
    Int16 = 10,
    Int32 = 11,
    Int64 = 12,
    Object = 13,
    SByte = 14,
    Single = 15,
    String = 16,
    StringFixedLength = 23,
    Time = 17,
    UInt16 = 18,
    UInt32 = 19,
    UInt64 = 20,
    VarNumeric = 21,
    Xml = 25,
  }
  public enum IsolationLevel {
    Chaos = 16,
    ReadCommitted = 4096,
    ReadUncommitted = 256,
    RepeatableRead = 65536,
    Serializable = 1048576,
    Snapshot = 16777216,
    Unspecified = -1,
  }
  public enum ParameterDirection {
    Input = 1,
    InputOutput = 3,
    Output = 2,
    ReturnValue = 6,
  }
  public sealed class StateChangeEventArgs : EventArgs {
    public StateChangeEventArgs(ConnectionState originalState, ConnectionState currentState);
    public ConnectionState CurrentState { get; }
    public ConnectionState OriginalState { get; }
  }
  public delegate void StateChangeEventHandler(object sender, StateChangeEventArgs e);
  public enum UpdateRowSource {
    Both = 3,
    FirstReturnedRecord = 2,
    None = 0,
    OutputParameters = 1,
  }
 }
 namespace System.Data.Common {
  public abstract class DbCommand : IDisposable {
    protected DbCommand();
    public abstract string CommandText { get; set; }
    public abstract int CommandTimeout { get; set; }
    public abstract CommandType CommandType { get; set; }
    public DbConnection Connection { get; set; }
    protected abstract DbConnection DbConnection { get; set; }
    protected abstract DbParameterCollection DbParameterCollection { get; }
    protected abstract DbTransaction DbTransaction { get; set; }
    public abstract bool DesignTimeVisible { get; set; }
    public DbParameterCollection Parameters { get; }
    public DbTransaction Transaction { get; set; }
    public abstract UpdateRowSource UpdatedRowSource { get; set; }
    public abstract void Cancel();
    protected abstract DbParameter CreateDbParameter();
    public DbParameter CreateParameter();
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    protected abstract DbDataReader ExecuteDbDataReader(CommandBehavior behavior);
    protected virtual Task<DbDataReader> ExecuteDbDataReaderAsync(CommandBehavior behavior, CancellationToken cancellationToken);
    public abstract int ExecuteNonQuery();
    public Task<int> ExecuteNonQueryAsync();
    public virtual Task<int> ExecuteNonQueryAsync(CancellationToken cancellationToken);
    public DbDataReader ExecuteReader();
    public DbDataReader ExecuteReader(CommandBehavior behavior);
    public Task<DbDataReader> ExecuteReaderAsync();
    public Task<DbDataReader> ExecuteReaderAsync(CommandBehavior behavior);
    public Task<DbDataReader> ExecuteReaderAsync(CommandBehavior behavior, CancellationToken cancellationToken);
    public Task<DbDataReader> ExecuteReaderAsync(CancellationToken cancellationToken);
    public abstract object ExecuteScalar();
    public Task<object> ExecuteScalarAsync();
    public virtual Task<object> ExecuteScalarAsync(CancellationToken cancellationToken);
    public abstract void Prepare();
  }
  public abstract class DbConnection : IDisposable {
    protected DbConnection();
    public abstract string ConnectionString { get; set; }
    public virtual int ConnectionTimeout { get; }
    public abstract string Database { get; }
    public abstract string DataSource { get; }
    public abstract string ServerVersion { get; }
    public abstract ConnectionState State { get; }
    public virtual event StateChangeEventHandler StateChange;
    protected abstract DbTransaction BeginDbTransaction(IsolationLevel isolationLevel);
    public DbTransaction BeginTransaction();
    public DbTransaction BeginTransaction(IsolationLevel isolationLevel);
    public abstract void ChangeDatabase(string databaseName);
    public abstract void Close();
    public DbCommand CreateCommand();
    protected abstract DbCommand CreateDbCommand();
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    protected virtual void OnStateChange(StateChangeEventArgs stateChange);
    public abstract void Open();
    public Task OpenAsync();
    public virtual Task OpenAsync(CancellationToken cancellationToken);
  }
  public class DbConnectionStringBuilder : ICollection, IDictionary, IEnumerable {
    public DbConnectionStringBuilder();
    public string ConnectionString { get; set; }
    public virtual int Count { get; }
+   public virtual bool IsFixedSize { get; }
+   public bool IsReadOnly { get; }
    public virtual ICollection Keys { get; }
    bool System.Collections.ICollection.IsSynchronized { get; }
    object System.Collections.ICollection.SyncRoot { get; }
-   bool System.Collections.IDictionary.IsFixedSize { get; }
-   bool System.Collections.IDictionary.IsReadOnly { get; }
    object System.Collections.IDictionary.this[object keyword] { get; set; }
    public virtual object this[string keyword] { get; set; }
    public virtual ICollection Values { get; }
    public void Add(string keyword, object value);
    public static void AppendKeyValuePair(StringBuilder builder, string keyword, string value);
    public virtual void Clear();
    public virtual bool ContainsKey(string keyword);
    public virtual bool EquivalentTo(DbConnectionStringBuilder connectionStringBuilder);
    public virtual bool Remove(string keyword);
    public virtual bool ShouldSerialize(string keyword);
    void System.Collections.ICollection.CopyTo(Array array, int index);
    void System.Collections.IDictionary.Add(object keyword, object value);
    bool System.Collections.IDictionary.Contains(object keyword);
    IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
    void System.Collections.IDictionary.Remove(object keyword);
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    public override string ToString();
    public virtual bool TryGetValue(string keyword, out object value);
  }
  public abstract class DbDataReader : IDisposable, IEnumerable {
    protected DbDataReader();
    public abstract int Depth { get; }
    public abstract int FieldCount { get; }
    public abstract bool HasRows { get; }
    public abstract bool IsClosed { get; }
    public abstract int RecordsAffected { get; }
    public abstract object this[int ordinal] { get; }
    public abstract object this[string name] { get; }
    public virtual int VisibleFieldCount { get; }
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public abstract bool GetBoolean(int ordinal);
    public abstract byte GetByte(int ordinal);
    public abstract long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length);
    public abstract char GetChar(int ordinal);
    public abstract long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length);
    public DbDataReader GetData(int ordinal);
    public abstract string GetDataTypeName(int ordinal);
    public abstract DateTime GetDateTime(int ordinal);
    protected virtual DbDataReader GetDbDataReader(int ordinal);
    public abstract decimal GetDecimal(int ordinal);
    public abstract double GetDouble(int ordinal);
    public abstract IEnumerator GetEnumerator();
    public abstract Type GetFieldType(int ordinal);
    public virtual T GetFieldValue<T>(int ordinal);
    public Task<T> GetFieldValueAsync<T>(int ordinal);
    public virtual Task<T> GetFieldValueAsync<T>(int ordinal, CancellationToken cancellationToken);
    public abstract float GetFloat(int ordinal);
    public abstract Guid GetGuid(int ordinal);
    public abstract short GetInt16(int ordinal);
    public abstract int GetInt32(int ordinal);
    public abstract long GetInt64(int ordinal);
    public abstract string GetName(int ordinal);
    public abstract int GetOrdinal(string name);
    public virtual Type GetProviderSpecificFieldType(int ordinal);
    public virtual object GetProviderSpecificValue(int ordinal);
    public virtual int GetProviderSpecificValues(object[] values);
    public virtual Stream GetStream(int ordinal);
    public abstract string GetString(int ordinal);
    public virtual TextReader GetTextReader(int ordinal);
    public abstract object GetValue(int ordinal);
    public abstract int GetValues(object[] values);
    public abstract bool IsDBNull(int ordinal);
    public Task<bool> IsDBNullAsync(int ordinal);
    public virtual Task<bool> IsDBNullAsync(int ordinal, CancellationToken cancellationToken);
    public abstract bool NextResult();
    public Task<bool> NextResultAsync();
    public virtual Task<bool> NextResultAsync(CancellationToken cancellationToken);
    public abstract bool Read();
    public Task<bool> ReadAsync();
    public virtual Task<bool> ReadAsync(CancellationToken cancellationToken);
  }
  public abstract class DbException : Exception {
    protected DbException();
    protected DbException(string message);
    protected DbException(string message, Exception innerException);
  }
  public abstract class DbParameter {
    protected DbParameter();
    public abstract DbType DbType { get; set; }
    public abstract ParameterDirection Direction { get; set; }
    public abstract bool IsNullable { get; set; }
    public abstract string ParameterName { get; set; }
    public virtual byte Precision { get; set; }
    public virtual byte Scale { get; set; }
    public abstract int Size { get; set; }
    public abstract string SourceColumn { get; set; }
    public abstract bool SourceColumnNullMapping { get; set; }
    public abstract object Value { get; set; }
    public abstract void ResetDbType();
  }
  public abstract class DbParameterCollection : ICollection, IEnumerable, IList {
    protected DbParameterCollection();
    public abstract int Count { get; }
+   public virtual bool IsReadOnly { get; }
+   public virtual bool IsSynchronized { get; }
    public abstract object SyncRoot { get; }
-   bool System.Collections.ICollection.IsSynchronized { get; }
    bool System.Collections.IList.IsFixedSize { get; }
-   bool System.Collections.IList.IsReadOnly { get; }
    object System.Collections.IList.this[int index] { get; set; }
    public DbParameter this[int index] { get; set; }
    public DbParameter this[string parameterName] { get; set; }
    public abstract int Add(object value);
    public abstract void AddRange(Array values);
    public abstract void Clear();
    public abstract bool Contains(object value);
    public abstract bool Contains(string value);
    public abstract void CopyTo(Array array, int index);
    public abstract IEnumerator GetEnumerator();
    protected abstract DbParameter GetParameter(int index);
    protected abstract DbParameter GetParameter(string parameterName);
    public abstract int IndexOf(object value);
    public abstract int IndexOf(string parameterName);
    public abstract void Insert(int index, object value);
    public abstract void Remove(object value);
    public abstract void RemoveAt(int index);
    public abstract void RemoveAt(string parameterName);
    protected abstract void SetParameter(int index, DbParameter value);
    protected abstract void SetParameter(string parameterName, DbParameter value);
  }
  public abstract class DbProviderFactory {
    protected DbProviderFactory();
    public virtual DbCommand CreateCommand();
    public virtual DbConnection CreateConnection();
    public virtual DbConnectionStringBuilder CreateConnectionStringBuilder();
    public virtual DbParameter CreateParameter();
  }
  public abstract class DbTransaction : IDisposable {
    protected DbTransaction();
    public DbConnection Connection { get; }
    protected abstract DbConnection DbConnection { get; }
    public abstract IsolationLevel IsolationLevel { get; }
    public abstract void Commit();
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public abstract void Rollback();
  }
 }
```

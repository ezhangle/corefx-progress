namespace System.Threading {
  public class Barrier : IDisposable {
    public Barrier(int participantCount);
    public Barrier(int participantCount, Action<Barrier> postPhaseAction);
    public long CurrentPhaseNumber { get; }
    public int ParticipantCount { get; }
    public int ParticipantsRemaining { get; }
    public long AddParticipant();
    public long AddParticipants(int participantCount);
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public void RemoveParticipant();
    public void RemoveParticipants(int participantCount);
    public void SignalAndWait();
    public bool SignalAndWait(int millisecondsTimeout);
    public bool SignalAndWait(int millisecondsTimeout, CancellationToken cancellationToken);
    public void SignalAndWait(CancellationToken cancellationToken);
    public bool SignalAndWait(TimeSpan timeout);
    public bool SignalAndWait(TimeSpan timeout, CancellationToken cancellationToken);
  }
  public class BarrierPostPhaseException : Exception {
    public BarrierPostPhaseException();
    public BarrierPostPhaseException(Exception innerException);
    public BarrierPostPhaseException(string message);
    public BarrierPostPhaseException(string message, Exception innerException);
  }
  public class CountdownEvent : IDisposable {
    public CountdownEvent(int initialCount);
    public int CurrentCount { get; }
    public int InitialCount { get; }
    public bool IsSet { get; }
    public WaitHandle WaitHandle { get; }
    public void AddCount();
    public void AddCount(int signalCount);
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public void Reset();
    public void Reset(int count);
    public bool Signal();
    public bool Signal(int signalCount);
    public bool TryAddCount();
    public bool TryAddCount(int signalCount);
    public void Wait();
    public bool Wait(int millisecondsTimeout);
    public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken);
    public void Wait(CancellationToken cancellationToken);
    public bool Wait(TimeSpan timeout);
    public bool Wait(TimeSpan timeout, CancellationToken cancellationToken);
  }
  public enum LockRecursionPolicy {
    NoRecursion = 0,
    SupportsRecursion = 1,
  }
  public class ReaderWriterLockSlim : IDisposable {
    public ReaderWriterLockSlim();
    public ReaderWriterLockSlim(LockRecursionPolicy recursionPolicy);
    public int CurrentReadCount { get; }
    public bool IsReadLockHeld { get; }
    public bool IsUpgradeableReadLockHeld { get; }
    public bool IsWriteLockHeld { get; }
    public LockRecursionPolicy RecursionPolicy { get; }
    public int RecursiveReadCount { get; }
    public int RecursiveUpgradeCount { get; }
    public int RecursiveWriteCount { get; }
    public int WaitingReadCount { get; }
    public int WaitingUpgradeCount { get; }
    public int WaitingWriteCount { get; }
    public void Dispose();
    public void EnterReadLock();
    public void EnterUpgradeableReadLock();
    public void EnterWriteLock();
    public void ExitReadLock();
    public void ExitUpgradeableReadLock();
    public void ExitWriteLock();
    public bool TryEnterReadLock(int millisecondsTimeout);
    public bool TryEnterReadLock(TimeSpan timeout);
    public bool TryEnterUpgradeableReadLock(int millisecondsTimeout);
    public bool TryEnterUpgradeableReadLock(TimeSpan timeout);
    public bool TryEnterWriteLock(int millisecondsTimeout);
    public bool TryEnterWriteLock(TimeSpan timeout);
  }
  public sealed class Semaphore : WaitHandle {
    public Semaphore(int initialCount, int maximumCount);
    public Semaphore(int initialCount, int maximumCount, string name);
    public Semaphore(int initialCount, int maximumCount, string name, out bool createdNew);
    public static Semaphore OpenExisting(string name);
    public int Release();
    public int Release(int releaseCount);
    public static bool TryOpenExisting(string name, out Semaphore result);
  }
}

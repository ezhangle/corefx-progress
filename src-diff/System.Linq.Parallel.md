﻿```diff
---lib-full\System.Linq.Parallel.dll
+++lib-oss\System.Linq.Parallel.dll
 namespace System.Linq {
  public class OrderedParallelQuery<TSource> : ParallelQuery<TSource> {
    public override IEnumerator<TSource> GetEnumerator();
  }
  public static class ParallelEnumerable {
    public static TResult Aggregate<TSource, TAccumulate, TResult>(this ParallelQuery<TSource> source, Func<TAccumulate> seedFactory, Func<TAccumulate, TSource, TAccumulate> updateAccumulatorFunc, Func<TAccumulate, TAccumulate, TAccumulate> combineAccumulatorsFunc, Func<TAccumulate, TResult> resultSelector);
    public static TResult Aggregate<TSource, TAccumulate, TResult>(this ParallelQuery<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> updateAccumulatorFunc, Func<TAccumulate, TAccumulate, TAccumulate> combineAccumulatorsFunc, Func<TAccumulate, TResult> resultSelector);
    public static TResult Aggregate<TSource, TAccumulate, TResult>(this ParallelQuery<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector);
    public static TAccumulate Aggregate<TSource, TAccumulate>(this ParallelQuery<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func);
    public static TSource Aggregate<TSource>(this ParallelQuery<TSource> source, Func<TSource, TSource, TSource> func);
    public static bool All<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate);
    public static bool Any<TSource>(this ParallelQuery<TSource> source);
    public static bool Any<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate);
    public static IEnumerable<TSource> AsEnumerable<TSource>(this ParallelQuery<TSource> source);
    public static ParallelQuery AsOrdered(this ParallelQuery source);
    public static ParallelQuery<TSource> AsOrdered<TSource>(this ParallelQuery<TSource> source);
    public static ParallelQuery AsParallel(this IEnumerable source);
    public static ParallelQuery<TSource> AsParallel<TSource>(this Partitioner<TSource> source);
    public static ParallelQuery<TSource> AsParallel<TSource>(this IEnumerable<TSource> source);
    public static IEnumerable<TSource> AsSequential<TSource>(this ParallelQuery<TSource> source);
    public static ParallelQuery<TSource> AsUnordered<TSource>(this ParallelQuery<TSource> source);
    public static decimal Average(this ParallelQuery<decimal> source);
    public static double Average(this ParallelQuery<double> source);
    public static double Average(this ParallelQuery<int> source);
    public static double Average(this ParallelQuery<long> source);
    public static Nullable<decimal> Average(this ParallelQuery<Nullable<decimal>> source);
    public static Nullable<double> Average(this ParallelQuery<Nullable<double>> source);
    public static Nullable<double> Average(this ParallelQuery<Nullable<int>> source);
    public static Nullable<double> Average(this ParallelQuery<Nullable<long>> source);
    public static Nullable<float> Average(this ParallelQuery<Nullable<float>> source);
    public static float Average(this ParallelQuery<float> source);
    public static decimal Average<TSource>(this ParallelQuery<TSource> source, Func<TSource, decimal> selector);
    public static double Average<TSource>(this ParallelQuery<TSource> source, Func<TSource, double> selector);
    public static double Average<TSource>(this ParallelQuery<TSource> source, Func<TSource, int> selector);
    public static double Average<TSource>(this ParallelQuery<TSource> source, Func<TSource, long> selector);
    public static Nullable<decimal> Average<TSource>(this ParallelQuery<TSource> source, Func<TSource, Nullable<decimal>> selector);
    public static Nullable<double> Average<TSource>(this ParallelQuery<TSource> source, Func<TSource, Nullable<double>> selector);
    public static Nullable<double> Average<TSource>(this ParallelQuery<TSource> source, Func<TSource, Nullable<int>> selector);
    public static Nullable<double> Average<TSource>(this ParallelQuery<TSource> source, Func<TSource, Nullable<long>> selector);
    public static Nullable<float> Average<TSource>(this ParallelQuery<TSource> source, Func<TSource, Nullable<float>> selector);
    public static float Average<TSource>(this ParallelQuery<TSource> source, Func<TSource, float> selector);
    public static ParallelQuery<TResult> Cast<TResult>(this ParallelQuery source);
    public static ParallelQuery<TSource> Concat<TSource>(this ParallelQuery<TSource> first, IEnumerable<TSource> second);
    public static ParallelQuery<TSource> Concat<TSource>(this ParallelQuery<TSource> first, ParallelQuery<TSource> second);
    public static bool Contains<TSource>(this ParallelQuery<TSource> source, TSource value);
    public static bool Contains<TSource>(this ParallelQuery<TSource> source, TSource value, IEqualityComparer<TSource> comparer);
    public static int Count<TSource>(this ParallelQuery<TSource> source);
    public static int Count<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate);
    public static ParallelQuery<TSource> DefaultIfEmpty<TSource>(this ParallelQuery<TSource> source);
    public static ParallelQuery<TSource> DefaultIfEmpty<TSource>(this ParallelQuery<TSource> source, TSource defaultValue);
    public static ParallelQuery<TSource> Distinct<TSource>(this ParallelQuery<TSource> source);
    public static ParallelQuery<TSource> Distinct<TSource>(this ParallelQuery<TSource> source, IEqualityComparer<TSource> comparer);
    public static TSource ElementAt<TSource>(this ParallelQuery<TSource> source, int index);
    public static TSource ElementAtOrDefault<TSource>(this ParallelQuery<TSource> source, int index);
    public static ParallelQuery<TResult> Empty<TResult>();
    public static ParallelQuery<TSource> Except<TSource>(this ParallelQuery<TSource> first, IEnumerable<TSource> second);
    public static ParallelQuery<TSource> Except<TSource>(this ParallelQuery<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer);
    public static ParallelQuery<TSource> Except<TSource>(this ParallelQuery<TSource> first, ParallelQuery<TSource> second);
    public static ParallelQuery<TSource> Except<TSource>(this ParallelQuery<TSource> first, ParallelQuery<TSource> second, IEqualityComparer<TSource> comparer);
    public static TSource First<TSource>(this ParallelQuery<TSource> source);
    public static TSource First<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate);
    public static TSource FirstOrDefault<TSource>(this ParallelQuery<TSource> source);
    public static TSource FirstOrDefault<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate);
    public static void ForAll<TSource>(this ParallelQuery<TSource> source, Action<TSource> action);
    public static ParallelQuery<TResult> GroupBy<TSource, TKey, TElement, TResult>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector);
    public static ParallelQuery<TResult> GroupBy<TSource, TKey, TElement, TResult>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector, IEqualityComparer<TKey> comparer);
    public static ParallelQuery<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector);
    public static ParallelQuery<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer);
    public static ParallelQuery<TResult> GroupBy<TSource, TKey, TResult>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector);
    public static ParallelQuery<TResult> GroupBy<TSource, TKey, TResult>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector, IEqualityComparer<TKey> comparer);
    public static ParallelQuery<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector);
    public static ParallelQuery<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer);
    public static ParallelQuery<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this ParallelQuery<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector);
    public static ParallelQuery<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this ParallelQuery<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector, IEqualityComparer<TKey> comparer);
    public static ParallelQuery<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this ParallelQuery<TOuter> outer, ParallelQuery<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector);
    public static ParallelQuery<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this ParallelQuery<TOuter> outer, ParallelQuery<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector, IEqualityComparer<TKey> comparer);
    public static ParallelQuery<TSource> Intersect<TSource>(this ParallelQuery<TSource> first, IEnumerable<TSource> second);
    public static ParallelQuery<TSource> Intersect<TSource>(this ParallelQuery<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer);
    public static ParallelQuery<TSource> Intersect<TSource>(this ParallelQuery<TSource> first, ParallelQuery<TSource> second);
    public static ParallelQuery<TSource> Intersect<TSource>(this ParallelQuery<TSource> first, ParallelQuery<TSource> second, IEqualityComparer<TSource> comparer);
    public static ParallelQuery<TResult> Join<TOuter, TInner, TKey, TResult>(this ParallelQuery<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector);
    public static ParallelQuery<TResult> Join<TOuter, TInner, TKey, TResult>(this ParallelQuery<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer);
    public static ParallelQuery<TResult> Join<TOuter, TInner, TKey, TResult>(this ParallelQuery<TOuter> outer, ParallelQuery<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector);
    public static ParallelQuery<TResult> Join<TOuter, TInner, TKey, TResult>(this ParallelQuery<TOuter> outer, ParallelQuery<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer);
    public static TSource Last<TSource>(this ParallelQuery<TSource> source);
    public static TSource Last<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate);
    public static TSource LastOrDefault<TSource>(this ParallelQuery<TSource> source);
    public static TSource LastOrDefault<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate);
    public static long LongCount<TSource>(this ParallelQuery<TSource> source);
    public static long LongCount<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate);
    public static decimal Max(this ParallelQuery<decimal> source);
    public static double Max(this ParallelQuery<double> source);
    public static int Max(this ParallelQuery<int> source);
    public static long Max(this ParallelQuery<long> source);
    public static Nullable<decimal> Max(this ParallelQuery<Nullable<decimal>> source);
    public static Nullable<double> Max(this ParallelQuery<Nullable<double>> source);
    public static Nullable<int> Max(this ParallelQuery<Nullable<int>> source);
    public static Nullable<long> Max(this ParallelQuery<Nullable<long>> source);
    public static Nullable<float> Max(this ParallelQuery<Nullable<float>> source);
    public static float Max(this ParallelQuery<float> source);
    public static TResult Max<TSource, TResult>(this ParallelQuery<TSource> source, Func<TSource, TResult> selector);
    public static TSource Max<TSource>(this ParallelQuery<TSource> source);
    public static decimal Max<TSource>(this ParallelQuery<TSource> source, Func<TSource, decimal> selector);
    public static double Max<TSource>(this ParallelQuery<TSource> source, Func<TSource, double> selector);
    public static int Max<TSource>(this ParallelQuery<TSource> source, Func<TSource, int> selector);
    public static long Max<TSource>(this ParallelQuery<TSource> source, Func<TSource, long> selector);
    public static Nullable<decimal> Max<TSource>(this ParallelQuery<TSource> source, Func<TSource, Nullable<decimal>> selector);
    public static Nullable<double> Max<TSource>(this ParallelQuery<TSource> source, Func<TSource, Nullable<double>> selector);
    public static Nullable<int> Max<TSource>(this ParallelQuery<TSource> source, Func<TSource, Nullable<int>> selector);
    public static Nullable<long> Max<TSource>(this ParallelQuery<TSource> source, Func<TSource, Nullable<long>> selector);
    public static Nullable<float> Max<TSource>(this ParallelQuery<TSource> source, Func<TSource, Nullable<float>> selector);
    public static float Max<TSource>(this ParallelQuery<TSource> source, Func<TSource, float> selector);
    public static decimal Min(this ParallelQuery<decimal> source);
    public static double Min(this ParallelQuery<double> source);
    public static int Min(this ParallelQuery<int> source);
    public static long Min(this ParallelQuery<long> source);
    public static Nullable<decimal> Min(this ParallelQuery<Nullable<decimal>> source);
    public static Nullable<double> Min(this ParallelQuery<Nullable<double>> source);
    public static Nullable<int> Min(this ParallelQuery<Nullable<int>> source);
    public static Nullable<long> Min(this ParallelQuery<Nullable<long>> source);
    public static Nullable<float> Min(this ParallelQuery<Nullable<float>> source);
    public static float Min(this ParallelQuery<float> source);
    public static TResult Min<TSource, TResult>(this ParallelQuery<TSource> source, Func<TSource, TResult> selector);
    public static TSource Min<TSource>(this ParallelQuery<TSource> source);
    public static decimal Min<TSource>(this ParallelQuery<TSource> source, Func<TSource, decimal> selector);
    public static double Min<TSource>(this ParallelQuery<TSource> source, Func<TSource, double> selector);
    public static int Min<TSource>(this ParallelQuery<TSource> source, Func<TSource, int> selector);
    public static long Min<TSource>(this ParallelQuery<TSource> source, Func<TSource, long> selector);
    public static Nullable<decimal> Min<TSource>(this ParallelQuery<TSource> source, Func<TSource, Nullable<decimal>> selector);
    public static Nullable<double> Min<TSource>(this ParallelQuery<TSource> source, Func<TSource, Nullable<double>> selector);
    public static Nullable<int> Min<TSource>(this ParallelQuery<TSource> source, Func<TSource, Nullable<int>> selector);
    public static Nullable<long> Min<TSource>(this ParallelQuery<TSource> source, Func<TSource, Nullable<long>> selector);
    public static Nullable<float> Min<TSource>(this ParallelQuery<TSource> source, Func<TSource, Nullable<float>> selector);
    public static float Min<TSource>(this ParallelQuery<TSource> source, Func<TSource, float> selector);
    public static ParallelQuery<TResult> OfType<TResult>(this ParallelQuery source);
    public static OrderedParallelQuery<TSource> OrderBy<TSource, TKey>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector);
    public static OrderedParallelQuery<TSource> OrderBy<TSource, TKey>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer);
    public static OrderedParallelQuery<TSource> OrderByDescending<TSource, TKey>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector);
    public static OrderedParallelQuery<TSource> OrderByDescending<TSource, TKey>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer);
    public static ParallelQuery<int> Range(int start, int count);
    public static ParallelQuery<TResult> Repeat<TResult>(TResult element, int count);
    public static ParallelQuery<TSource> Reverse<TSource>(this ParallelQuery<TSource> source);
    public static ParallelQuery<TResult> Select<TSource, TResult>(this ParallelQuery<TSource> source, Func<TSource, int, TResult> selector);
    public static ParallelQuery<TResult> Select<TSource, TResult>(this ParallelQuery<TSource> source, Func<TSource, TResult> selector);
    public static ParallelQuery<TResult> SelectMany<TSource, TCollection, TResult>(this ParallelQuery<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector);
    public static ParallelQuery<TResult> SelectMany<TSource, TCollection, TResult>(this ParallelQuery<TSource> source, Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector);
    public static ParallelQuery<TResult> SelectMany<TSource, TResult>(this ParallelQuery<TSource> source, Func<TSource, IEnumerable<TResult>> selector);
    public static ParallelQuery<TResult> SelectMany<TSource, TResult>(this ParallelQuery<TSource> source, Func<TSource, int, IEnumerable<TResult>> selector);
    public static bool SequenceEqual<TSource>(this ParallelQuery<TSource> first, IEnumerable<TSource> second);
    public static bool SequenceEqual<TSource>(this ParallelQuery<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer);
    public static bool SequenceEqual<TSource>(this ParallelQuery<TSource> first, ParallelQuery<TSource> second);
    public static bool SequenceEqual<TSource>(this ParallelQuery<TSource> first, ParallelQuery<TSource> second, IEqualityComparer<TSource> comparer);
    public static TSource Single<TSource>(this ParallelQuery<TSource> source);
    public static TSource Single<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate);
    public static TSource SingleOrDefault<TSource>(this ParallelQuery<TSource> source);
    public static TSource SingleOrDefault<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate);
    public static ParallelQuery<TSource> Skip<TSource>(this ParallelQuery<TSource> source, int count);
    public static ParallelQuery<TSource> SkipWhile<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate);
    public static ParallelQuery<TSource> SkipWhile<TSource>(this ParallelQuery<TSource> source, Func<TSource, int, bool> predicate);
    public static decimal Sum(this ParallelQuery<decimal> source);
    public static double Sum(this ParallelQuery<double> source);
    public static int Sum(this ParallelQuery<int> source);
    public static long Sum(this ParallelQuery<long> source);
    public static Nullable<decimal> Sum(this ParallelQuery<Nullable<decimal>> source);
    public static Nullable<double> Sum(this ParallelQuery<Nullable<double>> source);
    public static Nullable<int> Sum(this ParallelQuery<Nullable<int>> source);
    public static Nullable<long> Sum(this ParallelQuery<Nullable<long>> source);
    public static Nullable<float> Sum(this ParallelQuery<Nullable<float>> source);
    public static float Sum(this ParallelQuery<float> source);
    public static decimal Sum<TSource>(this ParallelQuery<TSource> source, Func<TSource, decimal> selector);
    public static double Sum<TSource>(this ParallelQuery<TSource> source, Func<TSource, double> selector);
    public static int Sum<TSource>(this ParallelQuery<TSource> source, Func<TSource, int> selector);
    public static long Sum<TSource>(this ParallelQuery<TSource> source, Func<TSource, long> selector);
    public static Nullable<decimal> Sum<TSource>(this ParallelQuery<TSource> source, Func<TSource, Nullable<decimal>> selector);
    public static Nullable<double> Sum<TSource>(this ParallelQuery<TSource> source, Func<TSource, Nullable<double>> selector);
    public static Nullable<int> Sum<TSource>(this ParallelQuery<TSource> source, Func<TSource, Nullable<int>> selector);
    public static Nullable<long> Sum<TSource>(this ParallelQuery<TSource> source, Func<TSource, Nullable<long>> selector);
    public static Nullable<float> Sum<TSource>(this ParallelQuery<TSource> source, Func<TSource, Nullable<float>> selector);
    public static float Sum<TSource>(this ParallelQuery<TSource> source, Func<TSource, float> selector);
    public static ParallelQuery<TSource> Take<TSource>(this ParallelQuery<TSource> source, int count);
    public static ParallelQuery<TSource> TakeWhile<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate);
    public static ParallelQuery<TSource> TakeWhile<TSource>(this ParallelQuery<TSource> source, Func<TSource, int, bool> predicate);
    public static OrderedParallelQuery<TSource> ThenBy<TSource, TKey>(this OrderedParallelQuery<TSource> source, Func<TSource, TKey> keySelector);
    public static OrderedParallelQuery<TSource> ThenBy<TSource, TKey>(this OrderedParallelQuery<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer);
    public static OrderedParallelQuery<TSource> ThenByDescending<TSource, TKey>(this OrderedParallelQuery<TSource> source, Func<TSource, TKey> keySelector);
    public static OrderedParallelQuery<TSource> ThenByDescending<TSource, TKey>(this OrderedParallelQuery<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer);
    public static TSource[] ToArray<TSource>(this ParallelQuery<TSource> source);
    public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector);
    public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer);
    public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector);
    public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer);
    public static List<TSource> ToList<TSource>(this ParallelQuery<TSource> source);
    public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector);
    public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer);
    public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector);
    public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer);
    public static ParallelQuery<TSource> Union<TSource>(this ParallelQuery<TSource> first, IEnumerable<TSource> second);
    public static ParallelQuery<TSource> Union<TSource>(this ParallelQuery<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer);
    public static ParallelQuery<TSource> Union<TSource>(this ParallelQuery<TSource> first, ParallelQuery<TSource> second);
    public static ParallelQuery<TSource> Union<TSource>(this ParallelQuery<TSource> first, ParallelQuery<TSource> second, IEqualityComparer<TSource> comparer);
    public static ParallelQuery<TSource> Where<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate);
    public static ParallelQuery<TSource> Where<TSource>(this ParallelQuery<TSource> source, Func<TSource, int, bool> predicate);
    public static ParallelQuery<TSource> WithCancellation<TSource>(this ParallelQuery<TSource> source, CancellationToken cancellationToken);
    public static ParallelQuery<TSource> WithDegreeOfParallelism<TSource>(this ParallelQuery<TSource> source, int degreeOfParallelism);
    public static ParallelQuery<TSource> WithExecutionMode<TSource>(this ParallelQuery<TSource> source, ParallelExecutionMode executionMode);
    public static ParallelQuery<TSource> WithMergeOptions<TSource>(this ParallelQuery<TSource> source, ParallelMergeOptions mergeOptions);
    public static ParallelQuery<TResult> Zip<TFirst, TSecond, TResult>(this ParallelQuery<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector);
    public static ParallelQuery<TResult> Zip<TFirst, TSecond, TResult>(this ParallelQuery<TFirst> first, ParallelQuery<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector);
  }
  public enum ParallelExecutionMode {
    Default = 0,
    ForceParallelism = 1,
  }
  public enum ParallelMergeOptions {
    AutoBuffered = 2,
    Default = 0,
    FullyBuffered = 3,
    NotBuffered = 1,
  }
  public class ParallelQuery : IEnumerable {
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
  }
  public class ParallelQuery<TSource> : ParallelQuery, IEnumerable, IEnumerable<TSource> {
    public virtual IEnumerator<TSource> GetEnumerator();
  }
 }
```

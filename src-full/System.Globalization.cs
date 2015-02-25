﻿namespace System.Globalization {
  public abstract class Calendar {
    public const int CurrentEra = 0;
    protected Calendar();
    public abstract int[] Eras { get; }
    public bool IsReadOnly { get; }
    public virtual DateTime MaxSupportedDateTime { get; }
    public virtual DateTime MinSupportedDateTime { get; }
    public virtual int TwoDigitYearMax { get; set; }
    public virtual DateTime AddDays(DateTime time, int days);
    public virtual DateTime AddHours(DateTime time, int hours);
    public virtual DateTime AddMilliseconds(DateTime time, double milliseconds);
    public virtual DateTime AddMinutes(DateTime time, int minutes);
    public abstract DateTime AddMonths(DateTime time, int months);
    public virtual DateTime AddSeconds(DateTime time, int seconds);
    public virtual DateTime AddWeeks(DateTime time, int weeks);
    public abstract DateTime AddYears(DateTime time, int years);
    public abstract int GetDayOfMonth(DateTime time);
    public abstract DayOfWeek GetDayOfWeek(DateTime time);
    public abstract int GetDayOfYear(DateTime time);
    public virtual int GetDaysInMonth(int year, int month);
    public abstract int GetDaysInMonth(int year, int month, int era);
    public virtual int GetDaysInYear(int year);
    public abstract int GetDaysInYear(int year, int era);
    public abstract int GetEra(DateTime time);
    public virtual int GetHour(DateTime time);
    public virtual int GetLeapMonth(int year, int era);
    public virtual double GetMilliseconds(DateTime time);
    public virtual int GetMinute(DateTime time);
    public abstract int GetMonth(DateTime time);
    public virtual int GetMonthsInYear(int year);
    public abstract int GetMonthsInYear(int year, int era);
    public virtual int GetSecond(DateTime time);
    public virtual int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek);
    public abstract int GetYear(DateTime time);
    public virtual bool IsLeapDay(int year, int month, int day);
    public abstract bool IsLeapDay(int year, int month, int day, int era);
    public virtual bool IsLeapMonth(int year, int month);
    public abstract bool IsLeapMonth(int year, int month, int era);
    public virtual bool IsLeapYear(int year);
    public abstract bool IsLeapYear(int year, int era);
    public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond);
    public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);
    public virtual int ToFourDigitYear(int year);
  }
  public enum CalendarWeekRule {
    FirstDay = 0,
    FirstFourDayWeek = 2,
    FirstFullWeek = 1,
  }
  public static class CharUnicodeInfo {
    public static double GetNumericValue(char ch);
    public static double GetNumericValue(string s, int index);
    public static UnicodeCategory GetUnicodeCategory(char ch);
    public static UnicodeCategory GetUnicodeCategory(string s, int index);
  }
  public class CompareInfo {
    public virtual string Name { get; }
    public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2);
    public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options);
    public virtual int Compare(string string1, int offset1, string string2, int offset2);
    public virtual int Compare(string string1, int offset1, string string2, int offset2, CompareOptions options);
    public virtual int Compare(string string1, string string2);
    public virtual int Compare(string string1, string string2, CompareOptions options);
    public override bool Equals(object value);
    public static CompareInfo GetCompareInfo(string name);
    public override int GetHashCode();
    public virtual int GetHashCode(string source, CompareOptions options);
    public virtual int IndexOf(string source, char value);
    public virtual int IndexOf(string source, char value, CompareOptions options);
    public virtual int IndexOf(string source, char value, int startIndex, CompareOptions options);
    public virtual int IndexOf(string source, char value, int startIndex, int count);
    public virtual int IndexOf(string source, char value, int startIndex, int count, CompareOptions options);
    public virtual int IndexOf(string source, string value);
    public virtual int IndexOf(string source, string value, CompareOptions options);
    public virtual int IndexOf(string source, string value, int startIndex, CompareOptions options);
    public virtual int IndexOf(string source, string value, int startIndex, int count);
    public virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options);
    public virtual bool IsPrefix(string source, string prefix);
    public virtual bool IsPrefix(string source, string prefix, CompareOptions options);
    public virtual bool IsSuffix(string source, string suffix);
    public virtual bool IsSuffix(string source, string suffix, CompareOptions options);
    public virtual int LastIndexOf(string source, char value);
    public virtual int LastIndexOf(string source, char value, CompareOptions options);
    public virtual int LastIndexOf(string source, char value, int startIndex, CompareOptions options);
    public virtual int LastIndexOf(string source, char value, int startIndex, int count);
    public virtual int LastIndexOf(string source, char value, int startIndex, int count, CompareOptions options);
    public virtual int LastIndexOf(string source, string value);
    public virtual int LastIndexOf(string source, string value, CompareOptions options);
    public virtual int LastIndexOf(string source, string value, int startIndex, CompareOptions options);
    public virtual int LastIndexOf(string source, string value, int startIndex, int count);
    public virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options);
    public override string ToString();
  }
  public enum CompareOptions {
    IgnoreCase = 1,
    IgnoreKanaType = 8,
    IgnoreNonSpace = 2,
    IgnoreSymbols = 4,
    IgnoreWidth = 16,
    None = 0,
    Ordinal = 1073741824,
    OrdinalIgnoreCase = 268435456,
    StringSort = 536870912,
  }
  public class CultureInfo : IFormatProvider {
    public CultureInfo(string name);
    public virtual Calendar Calendar { get; }
    public virtual CompareInfo CompareInfo { get; }
    public static CultureInfo CurrentCulture { get; set; }
    public static CultureInfo CurrentUICulture { get; set; }
    public virtual DateTimeFormatInfo DateTimeFormat { get; set; }
    public static CultureInfo DefaultThreadCurrentCulture { get; set; }
    public static CultureInfo DefaultThreadCurrentUICulture { get; set; }
    public virtual string DisplayName { get; }
    public virtual string EnglishName { get; }
    public static CultureInfo InvariantCulture { get; }
    public virtual bool IsNeutralCulture { get; }
    public bool IsReadOnly { get; }
    public virtual string Name { get; }
    public virtual string NativeName { get; }
    public virtual NumberFormatInfo NumberFormat { get; set; }
    public virtual Calendar[] OptionalCalendars { get; }
    public virtual CultureInfo Parent { get; }
    public virtual TextInfo TextInfo { get; }
    public virtual string TwoLetterISOLanguageName { get; }
    public virtual object Clone();
    public override bool Equals(object value);
    public virtual object GetFormat(Type formatType);
    public override int GetHashCode();
    public static CultureInfo ReadOnly(CultureInfo ci);
    public override string ToString();
  }
  public class CultureNotFoundException : ArgumentException {
    public CultureNotFoundException();
    public CultureNotFoundException(string message);
    public CultureNotFoundException(string message, Exception innerException);
    public CultureNotFoundException(string paramName, string message);
    public CultureNotFoundException(string message, string invalidCultureName, Exception innerException);
    public CultureNotFoundException(string paramName, string invalidCultureName, string message);
    public virtual string InvalidCultureName { get; }
    public override string Message { get; }
  }
  public sealed class DateTimeFormatInfo : IFormatProvider {
    public DateTimeFormatInfo();
    public string[] AbbreviatedDayNames { get; set; }
    public string[] AbbreviatedMonthGenitiveNames { get; set; }
    public string[] AbbreviatedMonthNames { get; set; }
    public string AMDesignator { get; set; }
    public Calendar Calendar { get; set; }
    public CalendarWeekRule CalendarWeekRule { get; set; }
    public static DateTimeFormatInfo CurrentInfo { get; }
    public string[] DayNames { get; set; }
    public DayOfWeek FirstDayOfWeek { get; set; }
    public string FullDateTimePattern { get; set; }
    public static DateTimeFormatInfo InvariantInfo { get; }
    public bool IsReadOnly { get; }
    public string LongDatePattern { get; set; }
    public string LongTimePattern { get; set; }
    public string MonthDayPattern { get; set; }
    public string[] MonthGenitiveNames { get; set; }
    public string[] MonthNames { get; set; }
    public string PMDesignator { get; set; }
    public string RFC1123Pattern { get; }
    public string ShortDatePattern { get; set; }
    public string[] ShortestDayNames { get; set; }
    public string ShortTimePattern { get; set; }
    public string SortableDateTimePattern { get; }
    public string UniversalSortableDateTimePattern { get; }
    public string YearMonthPattern { get; set; }
    public object Clone();
    public string GetAbbreviatedDayName(DayOfWeek dayofweek);
    public string GetAbbreviatedEraName(int era);
    public string GetAbbreviatedMonthName(int month);
    public string GetDayName(DayOfWeek dayofweek);
    public int GetEra(string eraName);
    public string GetEraName(int era);
    public object GetFormat(Type formatType);
    public static DateTimeFormatInfo GetInstance(IFormatProvider provider);
    public string GetMonthName(int month);
    public static DateTimeFormatInfo ReadOnly(DateTimeFormatInfo dtfi);
  }
  public sealed class NumberFormatInfo : IFormatProvider {
    public NumberFormatInfo();
    public int CurrencyDecimalDigits { get; set; }
    public string CurrencyDecimalSeparator { get; set; }
    public string CurrencyGroupSeparator { get; set; }
    public int[] CurrencyGroupSizes { get; set; }
    public int CurrencyNegativePattern { get; set; }
    public int CurrencyPositivePattern { get; set; }
    public string CurrencySymbol { get; set; }
    public static NumberFormatInfo CurrentInfo { get; }
    public static NumberFormatInfo InvariantInfo { get; }
    public bool IsReadOnly { get; }
    public string NaNSymbol { get; set; }
    public string NegativeInfinitySymbol { get; set; }
    public string NegativeSign { get; set; }
    public int NumberDecimalDigits { get; set; }
    public string NumberDecimalSeparator { get; set; }
    public string NumberGroupSeparator { get; set; }
    public int[] NumberGroupSizes { get; set; }
    public int NumberNegativePattern { get; set; }
    public int PercentDecimalDigits { get; set; }
    public string PercentDecimalSeparator { get; set; }
    public string PercentGroupSeparator { get; set; }
    public int[] PercentGroupSizes { get; set; }
    public int PercentNegativePattern { get; set; }
    public int PercentPositivePattern { get; set; }
    public string PercentSymbol { get; set; }
    public string PerMilleSymbol { get; set; }
    public string PositiveInfinitySymbol { get; set; }
    public string PositiveSign { get; set; }
    public object Clone();
    public object GetFormat(Type formatType);
    public static NumberFormatInfo GetInstance(IFormatProvider formatProvider);
    public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi);
  }
  public class RegionInfo {
    public RegionInfo(string name);
    public virtual string CurrencySymbol { get; }
    public static RegionInfo CurrentRegion { get; }
    public virtual string DisplayName { get; }
    public virtual string EnglishName { get; }
    public virtual bool IsMetric { get; }
    public virtual string ISOCurrencySymbol { get; }
    public virtual string Name { get; }
    public virtual string NativeName { get; }
    public virtual string TwoLetterISORegionName { get; }
    public override bool Equals(object value);
    public override int GetHashCode();
    public override string ToString();
  }
  public class StringInfo {
    public StringInfo();
    public StringInfo(string value);
    public int LengthInTextElements { get; }
    public string String { get; set; }
    public override bool Equals(object value);
    public override int GetHashCode();
    public static string GetNextTextElement(string str);
    public static string GetNextTextElement(string str, int index);
    public static TextElementEnumerator GetTextElementEnumerator(string str);
    public static TextElementEnumerator GetTextElementEnumerator(string str, int index);
    public static int[] ParseCombiningCharacters(string str);
  }
  public class TextElementEnumerator : IEnumerator {
    public object Current { get; }
    public int ElementIndex { get; }
    public string GetTextElement();
    public bool MoveNext();
    public void Reset();
  }
  public class TextInfo {
    public string CultureName { get; }
    public bool IsReadOnly { get; }
    public bool IsRightToLeft { get; }
    public virtual string ListSeparator { get; set; }
    public override bool Equals(object obj);
    public override int GetHashCode();
    public virtual char ToLower(char c);
    public virtual string ToLower(string str);
    public override string ToString();
    public virtual char ToUpper(char c);
    public virtual string ToUpper(string str);
  }
  public enum UnicodeCategory {
    ClosePunctuation = 21,
    ConnectorPunctuation = 18,
    Control = 14,
    CurrencySymbol = 26,
    DashPunctuation = 19,
    DecimalDigitNumber = 8,
    EnclosingMark = 7,
    FinalQuotePunctuation = 23,
    Format = 15,
    InitialQuotePunctuation = 22,
    LetterNumber = 9,
    LineSeparator = 12,
    LowercaseLetter = 1,
    MathSymbol = 25,
    ModifierLetter = 3,
    ModifierSymbol = 27,
    NonSpacingMark = 5,
    OpenPunctuation = 20,
    OtherLetter = 4,
    OtherNotAssigned = 29,
    OtherNumber = 10,
    OtherPunctuation = 24,
    OtherSymbol = 28,
    ParagraphSeparator = 13,
    PrivateUse = 17,
    SpaceSeparator = 11,
    SpacingCombiningMark = 6,
    Surrogate = 16,
    TitlecaseLetter = 2,
    UppercaseLetter = 0,
  }
}

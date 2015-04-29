namespace System.Text.Encodings.Web {
  public sealed class CodePointFilter : ICodePointFilter {
    public CodePointFilter();
    public CodePointFilter(ICodePointFilter other);
    public CodePointFilter(params UnicodeRange[] allowedRanges);
    public CodePointFilter AllowChar(char c);
    public CodePointFilter AllowChars(params char[] chars);
    public CodePointFilter AllowChars(string chars);
    public CodePointFilter AllowFilter(ICodePointFilter filter);
    public CodePointFilter AllowRange(UnicodeRange range);
    public CodePointFilter AllowRanges(params UnicodeRange[] ranges);
    public CodePointFilter Clear();
    public CodePointFilter ForbidChar(char c);
    public CodePointFilter ForbidChars(params char[] chars);
    public CodePointFilter ForbidChars(string chars);
    public CodePointFilter ForbidRange(UnicodeRange range);
    public CodePointFilter ForbidRanges(params UnicodeRange[] ranges);
    public IEnumerable<int> GetAllowedCodePoints();
    public bool IsCharacterAllowed(char c);
  }
  public static class EncoderExtensions {
    public static void HtmlEncode(this IHtmlEncoder htmlEncoder, string value, TextWriter output);
    public static void JavaScriptStringEncode(this IJavaScriptStringEncoder javaScriptStringEncoder, string value, TextWriter output);
    public static void UrlEncode(this IUrlEncoder urlEncoder, string value, TextWriter output);
  }
  public sealed class HtmlEncoder : IHtmlEncoder {
    public HtmlEncoder();
    public HtmlEncoder(ICodePointFilter filter);
    public HtmlEncoder(params UnicodeRange[] allowedRanges);
    public static HtmlEncoder Default { get; set; }
    public void HtmlEncode(char[] value, int startIndex, int charCount, TextWriter output);
    public string HtmlEncode(string value);
    public void HtmlEncode(string value, int startIndex, int charCount, TextWriter output);
  }
  public interface ICodePointFilter {
    IEnumerable<int> GetAllowedCodePoints();
  }
  public interface IHtmlEncoder {
    void HtmlEncode(char[] value, int startIndex, int charCount, TextWriter output);
    string HtmlEncode(string value);
    void HtmlEncode(string value, int startIndex, int charCount, TextWriter output);
  }
  public interface IJavaScriptStringEncoder {
    void JavaScriptStringEncode(char[] value, int startIndex, int charCount, TextWriter output);
    string JavaScriptStringEncode(string value);
    void JavaScriptStringEncode(string value, int startIndex, int charCount, TextWriter output);
  }
  public interface IUrlEncoder {
    void UrlEncode(char[] value, int startIndex, int charCount, TextWriter output);
    string UrlEncode(string value);
    void UrlEncode(string value, int startIndex, int charCount, TextWriter output);
  }
  public sealed class JavaScriptStringEncoder : IJavaScriptStringEncoder {
    public JavaScriptStringEncoder();
    public JavaScriptStringEncoder(ICodePointFilter filter);
    public JavaScriptStringEncoder(params UnicodeRange[] allowedRanges);
    public static JavaScriptStringEncoder Default { get; set; }
    public void JavaScriptStringEncode(char[] value, int startIndex, int charCount, TextWriter output);
    public string JavaScriptStringEncode(string value);
    public void JavaScriptStringEncode(string value, int startIndex, int charCount, TextWriter output);
  }
  public sealed class UnicodeRange {
    public UnicodeRange(int firstCodePoint, int rangeSize);
    public int FirstCodePoint { get; }
    public int RangeSize { get; }
    public static UnicodeRange FromSpan(char firstChar, char lastChar);
  }
  public static class UnicodeRanges {
    public static UnicodeRange All { get; }
    public static UnicodeRange AlphabeticPresentationForms { get; }
    public static UnicodeRange Arabic { get; }
    public static UnicodeRange ArabicExtendedA { get; }
    public static UnicodeRange ArabicPresentationFormsA { get; }
    public static UnicodeRange ArabicPresentationFormsB { get; }
    public static UnicodeRange ArabicSupplement { get; }
    public static UnicodeRange Armenian { get; }
    public static UnicodeRange Arrows { get; }
    public static UnicodeRange Balinese { get; }
    public static UnicodeRange Bamum { get; }
    public static UnicodeRange BasicLatin { get; }
    public static UnicodeRange Batak { get; }
    public static UnicodeRange Bengali { get; }
    public static UnicodeRange BlockElements { get; }
    public static UnicodeRange Bopomofo { get; }
    public static UnicodeRange BopomofoExtended { get; }
    public static UnicodeRange BoxDrawing { get; }
    public static UnicodeRange BraillePatterns { get; }
    public static UnicodeRange Buginese { get; }
    public static UnicodeRange Buhid { get; }
    public static UnicodeRange Cham { get; }
    public static UnicodeRange Cherokee { get; }
    public static UnicodeRange CJKCompatibility { get; }
    public static UnicodeRange CJKCompatibilityForms { get; }
    public static UnicodeRange CJKCompatibilityIdeographs { get; }
    public static UnicodeRange CJKRadicalsSupplement { get; }
    public static UnicodeRange CJKStrokes { get; }
    public static UnicodeRange CJKSymbolsandPunctuation { get; }
    public static UnicodeRange CJKUnifiedIdeographs { get; }
    public static UnicodeRange CJKUnifiedIdeographsExtensionA { get; }
    public static UnicodeRange CombiningDiacriticalMarks { get; }
    public static UnicodeRange CombiningDiacriticalMarksExtended { get; }
    public static UnicodeRange CombiningDiacriticalMarksforSymbols { get; }
    public static UnicodeRange CombiningDiacriticalMarksSupplement { get; }
    public static UnicodeRange CombiningHalfMarks { get; }
    public static UnicodeRange CommonIndicNumberForms { get; }
    public static UnicodeRange ControlPictures { get; }
    public static UnicodeRange Coptic { get; }
    public static UnicodeRange CurrencySymbols { get; }
    public static UnicodeRange Cyrillic { get; }
    public static UnicodeRange CyrillicExtendedA { get; }
    public static UnicodeRange CyrillicExtendedB { get; }
    public static UnicodeRange CyrillicSupplement { get; }
    public static UnicodeRange Devanagari { get; }
    public static UnicodeRange DevanagariExtended { get; }
    public static UnicodeRange Dingbats { get; }
    public static UnicodeRange EnclosedAlphanumerics { get; }
    public static UnicodeRange EnclosedCJKLettersandMonths { get; }
    public static UnicodeRange Ethiopic { get; }
    public static UnicodeRange EthiopicExtended { get; }
    public static UnicodeRange EthiopicExtendedA { get; }
    public static UnicodeRange EthiopicSupplement { get; }
    public static UnicodeRange GeneralPunctuation { get; }
    public static UnicodeRange GeometricShapes { get; }
    public static UnicodeRange Georgian { get; }
    public static UnicodeRange GeorgianSupplement { get; }
    public static UnicodeRange Glagolitic { get; }
    public static UnicodeRange GreekandCoptic { get; }
    public static UnicodeRange GreekExtended { get; }
    public static UnicodeRange Gujarati { get; }
    public static UnicodeRange Gurmukhi { get; }
    public static UnicodeRange HalfwidthandFullwidthForms { get; }
    public static UnicodeRange HangulCompatibilityJamo { get; }
    public static UnicodeRange HangulJamo { get; }
    public static UnicodeRange HangulJamoExtendedA { get; }
    public static UnicodeRange HangulJamoExtendedB { get; }
    public static UnicodeRange HangulSyllables { get; }
    public static UnicodeRange Hanunoo { get; }
    public static UnicodeRange Hebrew { get; }
    public static UnicodeRange Hiragana { get; }
    public static UnicodeRange IdeographicDescriptionCharacters { get; }
    public static UnicodeRange IPAExtensions { get; }
    public static UnicodeRange Javanese { get; }
    public static UnicodeRange Kanbun { get; }
    public static UnicodeRange KangxiRadicals { get; }
    public static UnicodeRange Kannada { get; }
    public static UnicodeRange Katakana { get; }
    public static UnicodeRange KatakanaPhoneticExtensions { get; }
    public static UnicodeRange KayahLi { get; }
    public static UnicodeRange Khmer { get; }
    public static UnicodeRange KhmerSymbols { get; }
    public static UnicodeRange Lao { get; }
    public static UnicodeRange Latin1Supplement { get; }
    public static UnicodeRange LatinExtendedA { get; }
    public static UnicodeRange LatinExtendedAdditional { get; }
    public static UnicodeRange LatinExtendedB { get; }
    public static UnicodeRange LatinExtendedC { get; }
    public static UnicodeRange LatinExtendedD { get; }
    public static UnicodeRange LatinExtendedE { get; }
    public static UnicodeRange Lepcha { get; }
    public static UnicodeRange LetterlikeSymbols { get; }
    public static UnicodeRange Limbu { get; }
    public static UnicodeRange Lisu { get; }
    public static UnicodeRange Malayalam { get; }
    public static UnicodeRange Mandaic { get; }
    public static UnicodeRange MathematicalOperators { get; }
    public static UnicodeRange MeeteiMayek { get; }
    public static UnicodeRange MeeteiMayekExtensions { get; }
    public static UnicodeRange MiscellaneousMathematicalSymbolsA { get; }
    public static UnicodeRange MiscellaneousMathematicalSymbolsB { get; }
    public static UnicodeRange MiscellaneousSymbols { get; }
    public static UnicodeRange MiscellaneousSymbolsandArrows { get; }
    public static UnicodeRange MiscellaneousTechnical { get; }
    public static UnicodeRange ModifierToneLetters { get; }
    public static UnicodeRange Mongolian { get; }
    public static UnicodeRange Myanmar { get; }
    public static UnicodeRange MyanmarExtendedA { get; }
    public static UnicodeRange MyanmarExtendedB { get; }
    public static UnicodeRange NewTaiLue { get; }
    public static UnicodeRange NKo { get; }
    public static UnicodeRange None { get; }
    public static UnicodeRange NumberForms { get; }
    public static UnicodeRange Ogham { get; }
    public static UnicodeRange OlChiki { get; }
    public static UnicodeRange OpticalCharacterRecognition { get; }
    public static UnicodeRange Oriya { get; }
    public static UnicodeRange Phagspa { get; }
    public static UnicodeRange PhoneticExtensions { get; }
    public static UnicodeRange PhoneticExtensionsSupplement { get; }
    public static UnicodeRange Rejang { get; }
    public static UnicodeRange Runic { get; }
    public static UnicodeRange Samaritan { get; }
    public static UnicodeRange Saurashtra { get; }
    public static UnicodeRange Sinhala { get; }
    public static UnicodeRange SmallFormVariants { get; }
    public static UnicodeRange SpacingModifierLetters { get; }
    public static UnicodeRange Specials { get; }
    public static UnicodeRange Sundanese { get; }
    public static UnicodeRange SundaneseSupplement { get; }
    public static UnicodeRange SuperscriptsandSubscripts { get; }
    public static UnicodeRange SupplementalArrowsA { get; }
    public static UnicodeRange SupplementalArrowsB { get; }
    public static UnicodeRange SupplementalMathematicalOperators { get; }
    public static UnicodeRange SupplementalPunctuation { get; }
    public static UnicodeRange SylotiNagri { get; }
    public static UnicodeRange Syriac { get; }
    public static UnicodeRange Tagalog { get; }
    public static UnicodeRange Tagbanwa { get; }
    public static UnicodeRange TaiLe { get; }
    public static UnicodeRange TaiTham { get; }
    public static UnicodeRange TaiViet { get; }
    public static UnicodeRange Tamil { get; }
    public static UnicodeRange Telugu { get; }
    public static UnicodeRange Thaana { get; }
    public static UnicodeRange Thai { get; }
    public static UnicodeRange Tibetan { get; }
    public static UnicodeRange Tifinagh { get; }
    public static UnicodeRange UnifiedCanadianAboriginalSyllabics { get; }
    public static UnicodeRange UnifiedCanadianAboriginalSyllabicsExtended { get; }
    public static UnicodeRange Vai { get; }
    public static UnicodeRange VariationSelectors { get; }
    public static UnicodeRange VedicExtensions { get; }
    public static UnicodeRange VerticalForms { get; }
    public static UnicodeRange YijingHexagramSymbols { get; }
    public static UnicodeRange YiRadicals { get; }
    public static UnicodeRange YiSyllables { get; }
  }
  public sealed class UrlEncoder : IUrlEncoder {
    public UrlEncoder();
    public UrlEncoder(ICodePointFilter filter);
    public UrlEncoder(params UnicodeRange[] allowedRanges);
    public static UrlEncoder Default { get; set; }
    public void UrlEncode(char[] value, int startIndex, int charCount, TextWriter output);
    public string UrlEncode(string value);
    public void UrlEncode(string value, int startIndex, int charCount, TextWriter output);
  }
}

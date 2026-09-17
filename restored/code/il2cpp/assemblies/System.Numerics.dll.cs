// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 27903
{}

// Namespace: 
internal static class SR // TypeDefIndex: 27904
{
	// Methods

	// RVA: 0x8187098 Offset: 0x8183098 VA: 0x8187098
	internal static string Format(string resourceFormat, object p1) { }
}

// Namespace: 
private enum BigInteger.GetBytesMode // TypeDefIndex: 27905
{
	// Fields
	public int value__; // 0x0
	public const BigInteger.GetBytesMode AllocateArray = 0;
	public const BigInteger.GetBytesMode Count = 1;
	public const BigInteger.GetBytesMode Span = 2;
}

// Namespace: System.Numerics
[IsReadOnly]
[Serializable]
public struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger> // TypeDefIndex: 27906
{
	// Fields
	internal readonly int _sign; // 0x0
	internal readonly uint[] _bits; // 0x8
	private static readonly BigInteger s_bnMinInt; // 0x0
	private static readonly BigInteger s_bnOneInt; // 0x10
	private static readonly BigInteger s_bnZeroInt; // 0x20
	private static readonly BigInteger s_bnMinusOneInt; // 0x30
	private static readonly byte[] s_success; // 0x40

	// Properties
	public static BigInteger Zero { get; }
	public static BigInteger MinusOne { get; }
	public bool IsZero { get; }

	// Methods

	// RVA: 0x8187108 Offset: 0x8183108 VA: 0x8187108
	public void .ctor(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x818718C Offset: 0x818318C VA: 0x818718C
	public void .ctor(uint value) { }

	// RVA: 0x8187230 Offset: 0x8183230 VA: 0x8187230
	public void .ctor(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x818737C Offset: 0x818337C VA: 0x818737C
	public void .ctor(ulong value) { }

	// RVA: 0x8187468 Offset: 0x8183468 VA: 0x8187468
	public void .ctor(float value) { }

	// RVA: 0x81874CC Offset: 0x81834CC VA: 0x81874CC
	public void .ctor(double value) { }

	// RVA: 0x8187844 Offset: 0x8183844 VA: 0x8187844
	public void .ctor(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x8187A40 Offset: 0x8183A40 VA: 0x8187A40
	public void .ctor(byte[] value) { }

	// RVA: 0x8187B04 Offset: 0x8183B04 VA: 0x8187B04
	public void .ctor(ReadOnlySpan<byte> value, bool isUnsigned = False, bool isBigEndian = False) { }

	// RVA: 0x818816C Offset: 0x818416C VA: 0x818816C
	internal void .ctor(int n, uint[] rgu) { }

	// RVA: 0x818817C Offset: 0x818417C VA: 0x818817C
	internal void .ctor(uint[] value, bool negative) { }

	// RVA: 0x8188370 Offset: 0x8184370 VA: 0x8188370
	public static BigInteger get_Zero() { }

	// RVA: 0x81883C8 Offset: 0x81843C8 VA: 0x81883C8
	public static BigInteger get_MinusOne() { }

	// RVA: 0x8188420 Offset: 0x8184420 VA: 0x8188420
	public bool get_IsZero() { }

	// RVA: 0x8188430 Offset: 0x8184430 VA: 0x8188430
	public static BigInteger Parse(string value, IFormatProvider provider) { }

	// RVA: 0x81884B8 Offset: 0x81844B8 VA: 0x81884B8
	public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x8188598 Offset: 0x8184598 VA: 0x8188598 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x81885D8 Offset: 0x81845D8 VA: 0x81885D8 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x818873C Offset: 0x818473C VA: 0x818873C
	public bool Equals(long other) { }

	// RVA: 0x8188680 Offset: 0x8184680 VA: 0x8188680 Slot: 7
	public bool Equals(BigInteger other) { }

	// RVA: 0x8188820 Offset: 0x8184820 VA: 0x8188820
	public int CompareTo(long other) { }

	// RVA: 0x81888B0 Offset: 0x81848B0 VA: 0x81888B0 Slot: 6
	public int CompareTo(BigInteger other) { }

	// RVA: 0x81889D8 Offset: 0x81849D8 VA: 0x81889D8 Slot: 5
	public int CompareTo(object obj) { }

	// RVA: 0x8188ADC Offset: 0x8184ADC VA: 0x8188ADC
	public byte[] ToByteArray() { }

	// RVA: 0x8188B38 Offset: 0x8184B38 VA: 0x8188B38
	public byte[] ToByteArray(bool isUnsigned = False, bool isBigEndian = False) { }

	// RVA: 0x81890D0 Offset: 0x81850D0 VA: 0x81890D0
	public bool TryWriteBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = False, bool isBigEndian = False) { }

	// RVA: 0x8189180 Offset: 0x8185180 VA: 0x8189180
	internal bool TryWriteOrCountBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = False, bool isBigEndian = False) { }

	// RVA: 0x8188BC4 Offset: 0x8184BC4 VA: 0x8188BC4
	private byte[] TryGetBytes(BigInteger.GetBytesMode mode, Span<byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten) { }

	// RVA: 0x8189228 Offset: 0x8185228 VA: 0x8189228 Slot: 3
	public override string ToString() { }

	// RVA: 0x8189304 Offset: 0x8185304 VA: 0x8189304
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x8189338 Offset: 0x8185338 VA: 0x8189338 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x8189370 Offset: 0x8185370 VA: 0x8189370
	private static BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) { }

	// RVA: 0x81896B4 Offset: 0x81856B4 VA: 0x81896B4
	public static BigInteger op_Subtraction(BigInteger left, BigInteger right) { }

	// RVA: 0x8189760 Offset: 0x8185760 VA: 0x8189760
	private static BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) { }

	// RVA: 0x8189B1C Offset: 0x8185B1C VA: 0x8189B1C
	public static BigInteger op_Implicit(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x8189B44 Offset: 0x8185B44 VA: 0x8189B44
	public static BigInteger op_Implicit(sbyte value) { }

	// RVA: 0x8189B6C Offset: 0x8185B6C VA: 0x8189B6C
	public static BigInteger op_Implicit(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x8189B94 Offset: 0x8185B94 VA: 0x8189B94
	public static BigInteger op_Implicit(ushort value) { }

	// RVA: 0x8189BBC Offset: 0x8185BBC VA: 0x8189BBC
	public static BigInteger op_Implicit(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x8189BE4 Offset: 0x8185BE4 VA: 0x8189BE4
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x81894BC Offset: 0x81854BC VA: 0x81894BC
	public static BigInteger op_Implicit(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x818781C Offset: 0x818381C VA: 0x818781C
	public static BigInteger op_Implicit(ulong value) { }

	// RVA: 0x8189C0C Offset: 0x8185C0C VA: 0x8189C0C
	public static byte op_Explicit(BigInteger value) { }

	[CLSCompliant(False)]
	// RVA: 0x8189D74 Offset: 0x8185D74 VA: 0x8189D74
	public static sbyte op_Explicit(BigInteger value) { }

	// RVA: 0x8189E04 Offset: 0x8185E04 VA: 0x8189E04
	public static short op_Explicit(BigInteger value) { }

	[CLSCompliant(False)]
	// RVA: 0x8189E94 Offset: 0x8185E94 VA: 0x8189E94
	public static ushort op_Explicit(BigInteger value) { }

	// RVA: 0x8189C9C Offset: 0x8185C9C VA: 0x8189C9C
	public static int op_Explicit(BigInteger value) { }

	[CLSCompliant(False)]
	// RVA: 0x8189F24 Offset: 0x8185F24 VA: 0x8189F24
	public static uint op_Explicit(BigInteger value) { }

	// RVA: 0x8189FCC Offset: 0x8185FCC VA: 0x8189FCC
	public static long op_Explicit(BigInteger value) { }

	[CLSCompliant(False)]
	// RVA: 0x818A078 Offset: 0x8186078 VA: 0x818A078
	public static ulong op_Explicit(BigInteger value) { }

	// RVA: 0x818A130 Offset: 0x8186130 VA: 0x818A130
	public static float op_Explicit(BigInteger value) { }

	// RVA: 0x818A19C Offset: 0x818619C VA: 0x818A19C
	public static double op_Explicit(BigInteger value) { }

	// RVA: 0x818A3B4 Offset: 0x81863B4 VA: 0x818A3B4
	public static Decimal op_Explicit(BigInteger value) { }

	// RVA: 0x818A50C Offset: 0x818650C VA: 0x818A50C
	public static BigInteger op_LeftShift(BigInteger value, int shift) { }

	// RVA: 0x818A760 Offset: 0x8186760 VA: 0x818A760
	public static BigInteger op_RightShift(BigInteger value, int shift) { }

	// RVA: 0x818AB48 Offset: 0x8186B48 VA: 0x818AB48
	public static BigInteger op_UnaryNegation(BigInteger value) { }

	// RVA: 0x818AB78 Offset: 0x8186B78 VA: 0x818AB78
	public static BigInteger op_Addition(BigInteger left, BigInteger right) { }

	// RVA: 0x818AC24 Offset: 0x8186C24 VA: 0x818AC24
	public static BigInteger op_Multiply(BigInteger left, BigInteger right) { }

	// RVA: 0x818B02C Offset: 0x818702C VA: 0x818B02C
	public static BigInteger op_Division(BigInteger dividend, BigInteger divisor) { }

	// RVA: 0x818B304 Offset: 0x8187304 VA: 0x818B304
	public static bool op_LessThanOrEqual(BigInteger left, BigInteger right) { }

	// RVA: 0x818B384 Offset: 0x8187384 VA: 0x818B384
	public static bool op_Inequality(BigInteger left, BigInteger right) { }

	// RVA: 0x818B404 Offset: 0x8187404 VA: 0x818B404
	public static bool op_LessThan(BigInteger left, long right) { }

	// RVA: 0x818B470 Offset: 0x8187470 VA: 0x818B470
	public static bool op_LessThanOrEqual(BigInteger left, long right) { }

	// RVA: 0x818B4E0 Offset: 0x81874E0 VA: 0x818B4E0
	public static bool op_Equality(BigInteger left, long right) { }

	// RVA: 0x818B54C Offset: 0x818754C VA: 0x818B54C
	public static bool op_Inequality(BigInteger left, long right) { }

	// RVA: 0x818B5BC Offset: 0x81875BC VA: 0x818B5BC
	public static bool op_LessThan(long left, BigInteger right) { }

	// RVA: 0x818B62C Offset: 0x818762C VA: 0x818B62C
	public static bool op_LessThanOrEqual(long left, BigInteger right) { }

	// RVA: 0x818AA84 Offset: 0x8186A84 VA: 0x818AA84
	private static bool GetPartsForBitManipulation(ref BigInteger x, out uint[] xd, out int xl) { }

	// RVA: 0x81887B8 Offset: 0x81847B8 VA: 0x81887B8
	internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu) { }

	// RVA: 0x818B69C Offset: 0x818769C VA: 0x818B69C
	private static void .cctor() { }
}

// Namespace: System.Numerics
internal static class BigIntegerCalculator // TypeDefIndex: 27907
{
	// Fields
	private static int ReducerThreshold; // 0x0
	private static int SquareThreshold; // 0x4
	private static int AllocationThreshold; // 0x8
	private static int MultiplyThreshold; // 0xC

	// Methods

	// RVA: 0x81894F0 Offset: 0x81854F0 VA: 0x81894F0
	public static uint[] Add(uint[] left, uint right) { }

	// RVA: 0x81895C8 Offset: 0x81855C8 VA: 0x81895C8
	public static uint[] Add(uint[] left, uint[] right) { }

	// RVA: 0x818B860 Offset: 0x8187860 VA: 0x818B860
	private static void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x818B8E4 Offset: 0x81878E4 VA: 0x818B8E4
	private static void AddSelf(uint* left, int leftLength, uint* right, int rightLength) { }

	// RVA: 0x81898F0 Offset: 0x81858F0 VA: 0x81898F0
	public static uint[] Subtract(uint[] left, uint right) { }

	// RVA: 0x8189A28 Offset: 0x8185A28 VA: 0x8189A28
	public static uint[] Subtract(uint[] left, uint[] right) { }

	// RVA: 0x818B958 Offset: 0x8187958 VA: 0x818B958
	private static void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x81899A8 Offset: 0x81859A8 VA: 0x81899A8
	public static int Compare(uint[] left, uint[] right) { }

	// RVA: 0x818B17C Offset: 0x818717C VA: 0x818B17C
	public static uint[] Divide(uint[] left, uint right) { }

	// RVA: 0x818B228 Offset: 0x8187228 VA: 0x818B228
	public static uint[] Divide(uint[] left, uint[] right) { }

	// RVA: 0x818BA4C Offset: 0x8187A4C VA: 0x818BA4C
	private static void Divide(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x818BE50 Offset: 0x8187E50 VA: 0x818BE50
	private static uint AddDivisor(uint* left, int leftLength, uint* right, int rightLength) { }

	// RVA: 0x818BE08 Offset: 0x8187E08 VA: 0x818BE08
	private static uint SubtractDivisor(uint* left, int leftLength, uint* right, int rightLength, ulong q) { }

	// RVA: 0x818BDBC Offset: 0x8187DBC VA: 0x818BDBC
	private static bool DivideGuessTooBig(ulong q, ulong valHi, uint valLo, uint divHi, uint divLo) { }

	// RVA: 0x818B9D0 Offset: 0x81879D0 VA: 0x818B9D0
	private static uint[] CreateCopy(uint[] value) { }

	// RVA: 0x818BD44 Offset: 0x8187D44 VA: 0x818BD44
	private static int LeadingZeros(uint value) { }

	// RVA: 0x818AE80 Offset: 0x8186E80 VA: 0x818AE80
	public static uint[] Square(uint[] value) { }

	// RVA: 0x818BE90 Offset: 0x8187E90 VA: 0x818BE90
	private static void Square(uint* value, int valueLength, uint* bits, int bitsLength) { }

	// RVA: 0x818AD9C Offset: 0x8186D9C VA: 0x818AD9C
	public static uint[] Multiply(uint[] left, uint right) { }

	// RVA: 0x818AF40 Offset: 0x8186F40 VA: 0x818AF40
	public static uint[] Multiply(uint[] left, uint[] right) { }

	// RVA: 0x818C2F8 Offset: 0x81882F8 VA: 0x818C2F8
	private static void Multiply(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x818C238 Offset: 0x8188238 VA: 0x818C238
	private static void SubtractCore(uint* left, int leftLength, uint* right, int rightLength, uint* core, int coreLength) { }

	// RVA: 0x818C78C Offset: 0x818878C VA: 0x818C78C
	private static void .cctor() { }
}

// Namespace: 
private struct BigNumber.BigNumberBuffer // TypeDefIndex: 27908
{
	// Fields
	public StringBuilder digits; // 0x0
	public int precision; // 0x8
	public int scale; // 0xC
	public bool sign; // 0x10

	// Methods

	// RVA: 0x818CA48 Offset: 0x8188A48 VA: 0x818CA48
	public static BigNumber.BigNumberBuffer Create() { }
}

// Namespace: System.Numerics
internal static class BigNumber // TypeDefIndex: 27909
{
	// Methods

	// RVA: 0x818C7DC Offset: 0x81887DC VA: 0x818C7DC
	internal static bool TryValidateParseStyleInteger(NumberStyles style, out ArgumentException e) { }

	// RVA: 0x818C8F4 Offset: 0x81888F4 VA: 0x818C8F4
	internal static bool TryParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info, out BigInteger result) { }

	// RVA: 0x81884EC Offset: 0x81844EC VA: 0x81884EC
	internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x818CF98 Offset: 0x8188F98 VA: 0x818CF98
	internal static BigInteger ParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x818CBBC Offset: 0x8188BBC VA: 0x818CBBC
	private static bool HexNumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value) { }

	// RVA: 0x818CD6C Offset: 0x8188D6C VA: 0x818CD6C
	private static bool NumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value) { }

	// RVA: 0x818D0D4 Offset: 0x81890D4 VA: 0x818D0D4
	internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits) { }

	// RVA: 0x818D1C4 Offset: 0x81891C4 VA: 0x818D1C4
	private static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, char format, int digits, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess) { }

	// RVA: 0x8189258 Offset: 0x8185258 VA: 0x8189258
	internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info) { }

	// RVA: 0x818DAFC Offset: 0x8189AFC VA: 0x818DAFC
	private static string FormatBigInteger(bool targetSpan, BigInteger value, string formatString, ReadOnlySpan<char> formatSpan, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess) { }
}

// Namespace: System.Numerics
internal struct DoubleUlong // TypeDefIndex: 27910
{
	// Fields
	public double dbl; // 0x0
	public ulong uu; // 0x0
}

// Namespace: System.Numerics
internal static class NumericsHelpers // TypeDefIndex: 27911
{
	// Methods

	// RVA: 0x81877A0 Offset: 0x81837A0 VA: 0x81877A0
	public static void GetDoubleParts(double dbl, out int sign, out int exp, out ulong man, out bool fFinite) { }

	// RVA: 0x818A30C Offset: 0x818630C VA: 0x818A30C
	public static double GetDoubleFromParts(int sign, int exp, ulong man) { }

	// RVA: 0x81880B8 Offset: 0x81840B8 VA: 0x81880B8
	public static void DangerousMakeTwosComplement(uint[] d) { }

	// RVA: 0x81887A8 Offset: 0x81847A8 VA: 0x81887A8
	public static ulong MakeUlong(uint uHi, uint uLo) { }

	// RVA: 0x81894E4 Offset: 0x81854E4 VA: 0x81894E4
	public static uint Abs(int a) { }

	// RVA: 0x818E638 Offset: 0x818A638 VA: 0x818E638
	public static uint CombineHash(uint u1, uint u2) { }

	// RVA: 0x81885D0 Offset: 0x81845D0 VA: 0x81885D0
	public static int CombineHash(int n1, int n2) { }

	// RVA: 0x818A294 Offset: 0x8186294 VA: 0x818A294
	public static int CbitHighZero(uint u) { }

	// RVA: 0x818E614 Offset: 0x818A614 VA: 0x818E614
	public static int CbitHighZero(ulong uu) { }
}

// Namespace: 
internal struct FormatProvider.Number.NumberBuffer // TypeDefIndex: 27912
{
	// Fields
	public int precision; // 0x0
	public int scale; // 0x4
	public bool sign; // 0x8
	public char* overrideDigits; // 0x10

	// Properties
	public char* digits { get; }

	// Methods

	// RVA: 0x8192A70 Offset: 0x818EA70 VA: 0x8192A70
	public char* get_digits() { }
}

// Namespace: 
private class FormatProvider.Number // TypeDefIndex: 27913
{
	// Fields
	private static string[] s_posCurrencyFormats; // 0x0
	private static string[] s_negCurrencyFormats; // 0x8
	private static string[] s_posPercentFormats; // 0x10
	private static string[] s_negPercentFormats; // 0x18
	private static string[] s_negNumberFormats; // 0x20
	private static string s_posNumberFormat; // 0x28

	// Methods

	// RVA: 0x818FEAC Offset: 0x818BEAC VA: 0x818FEAC
	private static bool IsWhite(char ch) { }

	// RVA: 0x818FED4 Offset: 0x818BED4 VA: 0x818FED4
	private static char* MatchChars(char* p, char* pEnd, string str) { }

	// RVA: 0x818FF98 Offset: 0x818BF98 VA: 0x818FF98
	private static char* MatchChars(char* p, char* pEnd, char* str) { }

	// RVA: 0x818FFF4 Offset: 0x818BFF4 VA: 0x818FFF4
	private static bool ParseNumber(ref char* str, char* strEnd, NumberStyles options, ref FormatProvider.Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x81906F8 Offset: 0x818C6F8 VA: 0x81906F8
	private static bool TrailingZeros(ReadOnlySpan<char> s, int index) { }

	// RVA: 0x818FD74 Offset: 0x818BD74 VA: 0x818FD74
	internal static bool TryStringToNumber(ReadOnlySpan<char> str, NumberStyles options, ref FormatProvider.Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x8190788 Offset: 0x818C788 VA: 0x8190788
	internal static void Int32ToDecChars(char* buffer, ref int index, uint value, int digits) { }

	// RVA: 0x818E640 Offset: 0x818A640 VA: 0x818E640
	internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits) { }

	// RVA: 0x818E784 Offset: 0x818A784 VA: 0x818E784
	internal static void NumberToString(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

	// RVA: 0x81908B4 Offset: 0x818C8B4 VA: 0x81908B4
	private static void FormatCurrency(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x8191A8C Offset: 0x818DA8C VA: 0x8191A8C
	private static int wcslen(char* s) { }

	// RVA: 0x8190B14 Offset: 0x818CB14 VA: 0x8190B14
	private static void FormatFixed(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup) { }

	// RVA: 0x8191020 Offset: 0x818D020 VA: 0x8191020
	private static void FormatNumber(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x8191268 Offset: 0x818D268 VA: 0x8191268
	private static void FormatScientific(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) { }

	// RVA: 0x8191CB4 Offset: 0x818DCB4 VA: 0x8191CB4
	private static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) { }

	// RVA: 0x81914A4 Offset: 0x818D4A4 VA: 0x81914A4
	private static void FormatGeneral(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) { }

	// RVA: 0x819182C Offset: 0x818D82C VA: 0x819182C
	private static void FormatPercent(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x81907E4 Offset: 0x818C7E4 VA: 0x81907E4
	private static void RoundNumber(ref FormatProvider.Number.NumberBuffer number, int pos) { }

	// RVA: 0x8191FA4 Offset: 0x818DFA4 VA: 0x8191FA4
	private static int FindSection(ReadOnlySpan<char> format, int section) { }

	// RVA: 0x818ECDC Offset: 0x818ACDC VA: 0x818ECDC
	internal static void NumberToStringFormat(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, ReadOnlySpan<char> format, NumberFormatInfo info) { }

	// RVA: 0x81920F0 Offset: 0x818E0F0 VA: 0x81920F0
	private static void .cctor() { }
}

// Namespace: System.Globalization
internal class FormatProvider // TypeDefIndex: 27914
{
	// Methods

	// RVA: 0x818E4DC Offset: 0x818A4DC VA: 0x818E4DC
	internal static void FormatBigInteger(ref ValueStringBuilder sb, int precision, int scale, bool sign, ReadOnlySpan<char> format, NumberFormatInfo numberFormatInfo, char[] digits, int startIndex) { }

	// RVA: 0x818CAC8 Offset: 0x8188AC8 VA: 0x818CAC8
	internal static bool TryStringToBigInteger(ReadOnlySpan<char> s, NumberStyles styles, NumberFormatInfo numberFormatInfo, StringBuilder receiver, out int precision, out int scale, out bool sign) { }
}

// Namespace: System.Text
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsByRefLike]
[DefaultMember("Item")]
internal struct ValueStringBuilder // TypeDefIndex: 27915
{
	// Fields
	private char[] _arrayToReturnToPool; // 0x0
	private Span<char> _chars; // 0x8
	private int _pos; // 0x18

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x818D774 Offset: 0x8189774 VA: 0x818D774
	public void .ctor(Span<char> initialBuffer) { }

	// RVA: 0x8192A78 Offset: 0x818EA78 VA: 0x8192A78
	public int get_Length() { }

	// RVA: 0x818DA30 Offset: 0x8189A30 VA: 0x818DA30 Slot: 3
	public override string ToString() { }

	// RVA: 0x818D948 Offset: 0x8189948 VA: 0x818D948
	public bool TryCopyTo(Span<char> destination, out int charsWritten) { }

	// RVA: 0x818D784 Offset: 0x8189784 VA: 0x818D784
	public void Insert(int index, char value, int count) { }

	// RVA: 0x8192CC4 Offset: 0x818ECC4 VA: 0x8192CC4
	public void Append(char c) { }

	// RVA: 0x8192DC0 Offset: 0x818EDC0 VA: 0x8192DC0
	public void Append(string s) { }

	// RVA: 0x8192E6C Offset: 0x818EE6C VA: 0x8192E6C
	private void AppendSlow(string s) { }

	// RVA: 0x8191B8C Offset: 0x818DB8C VA: 0x8191B8C
	public void Append(char c, int count) { }

	// RVA: 0x8191AAC Offset: 0x818DAAC VA: 0x8191AAC
	public void Append(char* value, int length) { }

	// RVA: 0x8192F98 Offset: 0x818EF98 VA: 0x8192F98
	public Span<char> AppendSpan(int length) { }

	// RVA: 0x8192D40 Offset: 0x818ED40 VA: 0x8192D40
	private void GrowAndAppend(char c) { }

	// RVA: 0x8192A80 Offset: 0x818EA80 VA: 0x8192A80
	private void Grow(int requiredAdditionalCapacity) { }

	// RVA: 0x8193054 Offset: 0x818F054 VA: 0x8193054
	public void Dispose() { }
}


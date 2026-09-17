// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 23867
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 23868
{
	// Fields
	public byte[] FilePathsData; // 0x0
	public byte[] TypesData; // 0x8
	public int TotalTypes; // 0x10
	public int TotalFiles; // 0x14
	public bool IsEditorOnly; // 0x18
}

// Namespace: 
[CompilerGenerated]
[EditorBrowsable(1)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 23869
{
	// Methods

	// RVA: 0x7F1930C Offset: 0x7F1530C VA: 0x7F1930C
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x7F19404 Offset: 0x7F15404 VA: 0x7F19404
	public void .ctor() { }
}

// Namespace: 
public enum Lexer.Token // TypeDefIndex: 23870
{
	// Fields
	public int value__; // 0x0
	public const Lexer.Token None = 0;
	public const Lexer.Token Null = 1;
	public const Lexer.Token True = 2;
	public const Lexer.Token False = 3;
	public const Lexer.Token Colon = 4;
	public const Lexer.Token Comma = 5;
	public const Lexer.Token String = 6;
	public const Lexer.Token Number = 7;
	public const Lexer.Token CurlyOpen = 8;
	public const Lexer.Token CurlyClose = 9;
	public const Lexer.Token SquaredOpen = 10;
	public const Lexer.Token SquaredClose = 11;
}

// Namespace: SharpJson
internal class Lexer // TypeDefIndex: 23871
{
	// Fields
	[CompilerGenerated]
	private int <lineNumber>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <parseNumbersAsFloat>k__BackingField; // 0x14
	private char[] json; // 0x18
	private int index; // 0x20
	private bool success; // 0x24
	private char[] stringBuffer; // 0x28

	// Properties
	public bool hasError { get; }
	public int lineNumber { get; set; }
	public bool parseNumbersAsFloat { get; set; }

	// Methods

	// RVA: 0x7F1940C Offset: 0x7F1540C VA: 0x7F1940C
	public bool get_hasError() { }

	[CompilerGenerated]
	// RVA: 0x7F1941C Offset: 0x7F1541C VA: 0x7F1941C
	public int get_lineNumber() { }

	[CompilerGenerated]
	// RVA: 0x7F19424 Offset: 0x7F15424 VA: 0x7F19424
	private void set_lineNumber(int value) { }

	[CompilerGenerated]
	// RVA: 0x7F1942C Offset: 0x7F1542C VA: 0x7F1942C
	public bool get_parseNumbersAsFloat() { }

	[CompilerGenerated]
	// RVA: 0x7F19434 Offset: 0x7F15434 VA: 0x7F19434
	public void set_parseNumbersAsFloat(bool value) { }

	// RVA: 0x7F19440 Offset: 0x7F15440 VA: 0x7F19440
	public void .ctor(string text) { }

	// RVA: 0x7F194F0 Offset: 0x7F154F0 VA: 0x7F194F0
	public void Reset() { }

	// RVA: 0x7F19504 Offset: 0x7F15504 VA: 0x7F19504
	public string ParseString() { }

	// RVA: 0x7F19A14 Offset: 0x7F15A14 VA: 0x7F19A14
	private string GetNumberString() { }

	// RVA: 0x7F19ADC Offset: 0x7F15ADC VA: 0x7F19ADC
	public float ParseFloatNumber() { }

	// RVA: 0x7F19B78 Offset: 0x7F15B78 VA: 0x7F19B78
	public double ParseDoubleNumber() { }

	// RVA: 0x7F19A5C Offset: 0x7F15A5C VA: 0x7F19A5C
	private int GetLastIndexOfNumber(int index) { }

	// RVA: 0x7F19960 Offset: 0x7F15960 VA: 0x7F19960
	private void SkipWhiteSpaces() { }

	// RVA: 0x7F19C14 Offset: 0x7F15C14 VA: 0x7F19C14
	public Lexer.Token LookAhead() { }

	// RVA: 0x7F19E98 Offset: 0x7F15E98 VA: 0x7F19E98
	public Lexer.Token NextToken() { }

	// RVA: 0x7F19C44 Offset: 0x7F15C44 VA: 0x7F19C44
	private static Lexer.Token NextToken(char[] json, ref int index) { }
}

// Namespace: SharpJson
public class JsonDecoder // TypeDefIndex: 23872
{
	// Fields
	[CompilerGenerated]
	private string <errorMessage>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <parseNumbersAsFloat>k__BackingField; // 0x18
	private Lexer lexer; // 0x20

	// Properties
	public string errorMessage { get; set; }
	public bool parseNumbersAsFloat { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7F19EB4 Offset: 0x7F15EB4 VA: 0x7F19EB4
	public string get_errorMessage() { }

	[CompilerGenerated]
	// RVA: 0x7F19EBC Offset: 0x7F15EBC VA: 0x7F19EBC
	private void set_errorMessage(string value) { }

	[CompilerGenerated]
	// RVA: 0x7F19EC4 Offset: 0x7F15EC4 VA: 0x7F19EC4
	public bool get_parseNumbersAsFloat() { }

	[CompilerGenerated]
	// RVA: 0x7F19ECC Offset: 0x7F15ECC VA: 0x7F19ECC
	public void set_parseNumbersAsFloat(bool value) { }

	// RVA: 0x7F19ED8 Offset: 0x7F15ED8 VA: 0x7F19ED8
	public void .ctor() { }

	// RVA: 0x7F19F04 Offset: 0x7F15F04 VA: 0x7F19F04
	public object Decode(string text) { }

	// RVA: 0x7F1A1B0 Offset: 0x7F161B0 VA: 0x7F1A1B0
	public static object DecodeText(string text) { }

	// RVA: 0x7F1A220 Offset: 0x7F16220 VA: 0x7F1A220
	private IDictionary<string, object> ParseObject() { }

	// RVA: 0x7F1A4C0 Offset: 0x7F164C0 VA: 0x7F1A4C0
	private IList<object> ParseArray() { }

	// RVA: 0x7F19FA0 Offset: 0x7F15FA0 VA: 0x7F19FA0
	private object ParseValue() { }

	// RVA: 0x7F1A418 Offset: 0x7F16418 VA: 0x7F1A418
	private void TriggerError(string message) { }

	// RVA: -1 Offset: -1
	private T EvalLexer<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x464F1D8 Offset: 0x464B1D8 VA: 0x464F1D8
	|-JsonDecoder.EvalLexer<double>
	|
	|-RVA: 0x464F250 Offset: 0x464B250 VA: 0x464F250
	|-JsonDecoder.EvalLexer<object>
	|
	|-RVA: 0x464F2C0 Offset: 0x464B2C0 VA: 0x464F2C0
	|-JsonDecoder.EvalLexer<float>
	|
	|-RVA: 0x464F338 Offset: 0x464B338 VA: 0x464F338
	|-JsonDecoder.EvalLexer<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Spine
public class Animation // TypeDefIndex: 23873
{
	// Fields
	internal string name; // 0x10
	internal ExposedList<Timeline> timelines; // 0x18
	internal HashSet<string> timelineIds; // 0x20
	internal float duration; // 0x28

	// Properties
	public ExposedList<Timeline> Timelines { get; set; }
	public float Duration { get; set; }
	public string Name { get; }

	// Methods

	// RVA: 0x7F1A67C Offset: 0x7F1667C VA: 0x7F1A67C
	public void .ctor(string name, ExposedList<Timeline> timelines, float duration) { }

	// RVA: 0x7F1A970 Offset: 0x7F16970 VA: 0x7F1A970
	public ExposedList<Timeline> get_Timelines() { }

	// RVA: 0x7F1A978 Offset: 0x7F16978 VA: 0x7F1A978
	public void set_Timelines(ExposedList<Timeline> value) { }

	// RVA: 0x7F1A730 Offset: 0x7F16730 VA: 0x7F1A730
	public void SetTimelines(ExposedList<Timeline> timelines) { }

	// RVA: 0x7F1A97C Offset: 0x7F1697C VA: 0x7F1A97C
	public float get_Duration() { }

	// RVA: 0x7F1A984 Offset: 0x7F16984 VA: 0x7F1A984
	public void set_Duration(float value) { }

	// RVA: 0x7F1A98C Offset: 0x7F1698C VA: 0x7F1A98C
	public string get_Name() { }

	// RVA: 0x7F1A994 Offset: 0x7F16994 VA: 0x7F1A994
	public bool HasTimeline(string[] propertyIds) { }

	// RVA: 0x7F1AA4C Offset: 0x7F16A4C VA: 0x7F1AA4C
	public void Apply(Skeleton skeleton, float lastTime, float time, bool loop, ExposedList<Event> events, float alpha, MixBlend blend, MixDirection direction) { }

	// RVA: 0x7F1ABAC Offset: 0x7F16BAC VA: 0x7F1ABAC Slot: 3
	public override string ToString() { }
}

// Namespace: Spine
public enum MixBlend // TypeDefIndex: 23874
{
	// Fields
	public int value__; // 0x0
	public const MixBlend Setup = 0;
	public const MixBlend First = 1;
	public const MixBlend Replace = 2;
	public const MixBlend Add = 3;
}

// Namespace: Spine
public enum MixDirection // TypeDefIndex: 23875
{
	// Fields
	public int value__; // 0x0
	public const MixDirection In = 0;
	public const MixDirection Out = 1;
}

// Namespace: Spine
internal enum Property // TypeDefIndex: 23876
{
	// Fields
	public int value__; // 0x0
	public const Property Rotate = 0;
	public const Property X = 1;
	public const Property Y = 2;
	public const Property ScaleX = 3;
	public const Property ScaleY = 4;
	public const Property ShearX = 5;
	public const Property ShearY = 6;
	public const Property RGB = 7;
	public const Property Alpha = 8;
	public const Property RGB2 = 9;
	public const Property Attachment = 10;
	public const Property Deform = 11;
	public const Property Event = 12;
	public const Property DrawOrder = 13;
	public const Property IkConstraint = 14;
	public const Property TransformConstraint = 15;
	public const Property PathConstraintPosition = 16;
	public const Property PathConstraintSpacing = 17;
	public const Property PathConstraintMix = 18;
	public const Property Sequence = 19;
}

// Namespace: Spine
public abstract class Timeline // TypeDefIndex: 23877
{
	// Fields
	private readonly string[] propertyIds; // 0x10
	internal readonly float[] frames; // 0x18

	// Properties
	public string[] PropertyIds { get; }
	public float[] Frames { get; }
	public virtual int FrameEntries { get; }
	public int FrameCount { get; }
	public float Duration { get; }

	// Methods

	// RVA: 0x7F1ABB4 Offset: 0x7F16BB4 VA: 0x7F1ABB4
	public void .ctor(int frameCount, string[] propertyIds) { }

	// RVA: 0x7F1ACAC Offset: 0x7F16CAC VA: 0x7F1ACAC
	public string[] get_PropertyIds() { }

	// RVA: 0x7F1ACB4 Offset: 0x7F16CB4 VA: 0x7F1ACB4
	public float[] get_Frames() { }

	// RVA: 0x7F1ACBC Offset: 0x7F16CBC VA: 0x7F1ACBC Slot: 4
	public virtual int get_FrameEntries() { }

	// RVA: 0x7F1ACC4 Offset: 0x7F16CC4 VA: 0x7F1ACC4
	public int get_FrameCount() { }

	// RVA: 0x7F1ACF0 Offset: 0x7F16CF0 VA: 0x7F1ACF0
	public float get_Duration() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> events, float alpha, MixBlend blend, MixDirection direction);

	// RVA: 0x7F1AD30 Offset: 0x7F16D30 VA: 0x7F1AD30
	internal static int Search(float[] frames, float time) { }

	// RVA: 0x7F1AD84 Offset: 0x7F16D84 VA: 0x7F1AD84
	internal static int Search(float[] frames, float time, int step) { }
}

// Namespace: Spine
public interface IBoneTimeline // TypeDefIndex: 23878
{
	// Properties
	public abstract int BoneIndex { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_BoneIndex();
}

// Namespace: Spine
public interface ISlotTimeline // TypeDefIndex: 23879
{
	// Properties
	public abstract int SlotIndex { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_SlotIndex();
}

// Namespace: Spine
public abstract class CurveTimeline : Timeline // TypeDefIndex: 23880
{
	// Fields
	public const int LINEAR = 0;
	public const int STEPPED = 1;
	public const int BEZIER = 2;
	public const int BEZIER_SIZE = 18;
	internal float[] curves; // 0x20

	// Methods

	// RVA: 0x7F1ADDC Offset: 0x7F16DDC VA: 0x7F1ADDC
	public void .ctor(int frameCount, int bezierCount, string[] propertyIds) { }

	// RVA: 0x7F1AE94 Offset: 0x7F16E94 VA: 0x7F1AE94
	public void SetLinear(int frame) { }

	// RVA: 0x7F1AEC4 Offset: 0x7F16EC4 VA: 0x7F1AEC4
	public void SetStepped(int frame) { }

	// RVA: 0x7F1AEF8 Offset: 0x7F16EF8 VA: 0x7F1AEF8
	public float GetCurveType(int frame) { }

	// RVA: 0x7F1AF48 Offset: 0x7F16F48 VA: 0x7F1AF48
	public void Shrink(int bezierCount) { }

	// RVA: 0x7F1B014 Offset: 0x7F17014 VA: 0x7F1B014
	public void SetBezier(int bezier, int frame, int value, float time1, float value1, float cx1, float cy1, float cx2, float cy2, float time2, float value2) { }

	// RVA: 0x7F1B1C4 Offset: 0x7F171C4 VA: 0x7F1B1C4
	public float GetBezierValue(float time, int frameIndex, int valueOffset, int i) { }
}

// Namespace: Spine
public abstract class CurveTimeline1 : CurveTimeline // TypeDefIndex: 23881
{
	// Fields
	public const int ENTRIES = 2;
	internal const int VALUE = 1;

	// Properties
	public override int FrameEntries { get; }

	// Methods

	// RVA: 0x7F1B360 Offset: 0x7F17360 VA: 0x7F1B360
	public void .ctor(int frameCount, int bezierCount, string propertyId) { }

	// RVA: 0x7F1B400 Offset: 0x7F17400 VA: 0x7F1B400 Slot: 4
	public override int get_FrameEntries() { }

	// RVA: 0x7F1B408 Offset: 0x7F17408 VA: 0x7F1B408
	public void SetFrame(int frame, float time, float value) { }

	// RVA: 0x7F1B454 Offset: 0x7F17454 VA: 0x7F1B454
	public float GetCurveValue(float time) { }
}

// Namespace: Spine
public abstract class CurveTimeline2 : CurveTimeline // TypeDefIndex: 23882
{
	// Fields
	public const int ENTRIES = 3;
	internal const int VALUE1 = 1;
	internal const int VALUE2 = 2;

	// Properties
	public override int FrameEntries { get; }

	// Methods

	// RVA: 0x7F1B584 Offset: 0x7F17584 VA: 0x7F1B584
	public void .ctor(int frameCount, int bezierCount, string propertyId1, string propertyId2) { }

	// RVA: 0x7F1B648 Offset: 0x7F17648 VA: 0x7F1B648 Slot: 4
	public override int get_FrameEntries() { }

	// RVA: 0x7F1B650 Offset: 0x7F17650 VA: 0x7F1B650
	public void SetFrame(int frame, float time, float value1, float value2) { }
}

// Namespace: Spine
public class RotateTimeline : CurveTimeline1, IBoneTimeline // TypeDefIndex: 23883
{
	// Fields
	private readonly int boneIndex; // 0x28

	// Properties
	public int BoneIndex { get; }

	// Methods

	// RVA: 0x7F1B6AC Offset: 0x7F176AC VA: 0x7F1B6AC
	public void .ctor(int frameCount, int bezierCount, int boneIndex) { }

	// RVA: 0x7F1B758 Offset: 0x7F17758 VA: 0x7F1B758 Slot: 6
	public int get_BoneIndex() { }

	// RVA: 0x7F1B760 Offset: 0x7F17760 VA: 0x7F1B760 Slot: 5
	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }
}

// Namespace: Spine
public class TranslateTimeline : CurveTimeline2, IBoneTimeline // TypeDefIndex: 23884
{
	// Fields
	private readonly int boneIndex; // 0x28

	// Properties
	public int BoneIndex { get; }

	// Methods

	// RVA: 0x7F1B87C Offset: 0x7F1787C VA: 0x7F1B87C
	public void .ctor(int frameCount, int bezierCount, int boneIndex) { }

	// RVA: 0x7F1B96C Offset: 0x7F1796C VA: 0x7F1B96C Slot: 6
	public int get_BoneIndex() { }

	// RVA: 0x7F1B974 Offset: 0x7F17974 VA: 0x7F1B974 Slot: 5
	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }

	// RVA: 0x7F1BAD0 Offset: 0x7F17AD0 VA: 0x7F1BAD0
	public void GetCurveValue(out float x, out float y, float time) { }
}

// Namespace: Spine
public class TranslateXTimeline : CurveTimeline1, IBoneTimeline // TypeDefIndex: 23885
{
	// Fields
	private readonly int boneIndex; // 0x28

	// Properties
	public int BoneIndex { get; }

	// Methods

	// RVA: 0x7F1BCA4 Offset: 0x7F17CA4 VA: 0x7F1BCA4
	public void .ctor(int frameCount, int bezierCount, int boneIndex) { }

	// RVA: 0x7F1BD54 Offset: 0x7F17D54 VA: 0x7F1BD54 Slot: 6
	public int get_BoneIndex() { }

	// RVA: 0x7F1BD5C Offset: 0x7F17D5C VA: 0x7F1BD5C Slot: 5
	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }
}

// Namespace: Spine
public class TranslateYTimeline : CurveTimeline1, IBoneTimeline // TypeDefIndex: 23886
{
	// Fields
	private readonly int boneIndex; // 0x28

	// Properties
	public int BoneIndex { get; }

	// Methods

	// RVA: 0x7F1BE78 Offset: 0x7F17E78 VA: 0x7F1BE78
	public void .ctor(int frameCount, int bezierCount, int boneIndex) { }

	// RVA: 0x7F1BF28 Offset: 0x7F17F28 VA: 0x7F1BF28 Slot: 6
	public int get_BoneIndex() { }

	// RVA: 0x7F1BF30 Offset: 0x7F17F30 VA: 0x7F1BF30 Slot: 5
	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }
}

// Namespace: Spine
public class ScaleTimeline : CurveTimeline2, IBoneTimeline // TypeDefIndex: 23887
{
	// Fields
	private readonly int boneIndex; // 0x28

	// Properties
	public int BoneIndex { get; }

	// Methods

	// RVA: 0x7F1C04C Offset: 0x7F1804C VA: 0x7F1C04C
	public void .ctor(int frameCount, int bezierCount, int boneIndex) { }

	// RVA: 0x7F1C13C Offset: 0x7F1813C VA: 0x7F1C13C Slot: 6
	public int get_BoneIndex() { }

	// RVA: 0x7F1C144 Offset: 0x7F18144 VA: 0x7F1C144 Slot: 5
	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }
}

// Namespace: Spine
public class ScaleXTimeline : CurveTimeline1, IBoneTimeline // TypeDefIndex: 23888
{
	// Fields
	private readonly int boneIndex; // 0x28

	// Properties
	public int BoneIndex { get; }

	// Methods

	// RVA: 0x7F1C630 Offset: 0x7F18630 VA: 0x7F1C630
	public void .ctor(int frameCount, int bezierCount, int boneIndex) { }

	// RVA: 0x7F1C6E0 Offset: 0x7F186E0 VA: 0x7F1C6E0 Slot: 6
	public int get_BoneIndex() { }

	// RVA: 0x7F1C6E8 Offset: 0x7F186E8 VA: 0x7F1C6E8 Slot: 5
	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }
}

// Namespace: Spine
public class ScaleYTimeline : CurveTimeline1, IBoneTimeline // TypeDefIndex: 23889
{
	// Fields
	private readonly int boneIndex; // 0x28

	// Properties
	public int BoneIndex { get; }

	// Methods

	// RVA: 0x7F1C908 Offset: 0x7F18908 VA: 0x7F1C908
	public void .ctor(int frameCount, int bezierCount, int boneIndex) { }

	// RVA: 0x7F1C9B8 Offset: 0x7F189B8 VA: 0x7F1C9B8 Slot: 6
	public int get_BoneIndex() { }

	// RVA: 0x7F1C9C0 Offset: 0x7F189C0 VA: 0x7F1C9C0 Slot: 5
	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }
}

// Namespace: Spine
public class ShearTimeline : CurveTimeline2, IBoneTimeline // TypeDefIndex: 23890
{
	// Fields
	private readonly int boneIndex; // 0x28

	// Properties
	public int BoneIndex { get; }

	// Methods

	// RVA: 0x7F1CBE0 Offset: 0x7F18BE0 VA: 0x7F1CBE0
	public void .ctor(int frameCount, int bezierCount, int boneIndex) { }

	// RVA: 0x7F1CCD0 Offset: 0x7F18CD0 VA: 0x7F1CCD0 Slot: 6
	public int get_BoneIndex() { }

	// RVA: 0x7F1CCD8 Offset: 0x7F18CD8 VA: 0x7F1CCD8 Slot: 5
	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }
}

// Namespace: Spine
public class ShearXTimeline : CurveTimeline1, IBoneTimeline // TypeDefIndex: 23891
{
	// Fields
	private readonly int boneIndex; // 0x28

	// Properties
	public int BoneIndex { get; }

	// Methods

	// RVA: 0x7F1CFD4 Offset: 0x7F18FD4 VA: 0x7F1CFD4
	public void .ctor(int frameCount, int bezierCount, int boneIndex) { }

	// RVA: 0x7F1D084 Offset: 0x7F19084 VA: 0x7F1D084 Slot: 6
	public int get_BoneIndex() { }

	// RVA: 0x7F1D08C Offset: 0x7F1908C VA: 0x7F1D08C Slot: 5
	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }
}

// Namespace: Spine
public class ShearYTimeline : CurveTimeline1, IBoneTimeline // TypeDefIndex: 23892
{
	// Fields
	private readonly int boneIndex; // 0x28

	// Properties
	public int BoneIndex { get; }

	// Methods

	// RVA: 0x7F1D1A8 Offset: 0x7F191A8 VA: 0x7F1D1A8
	public void .ctor(int frameCount, int bezierCount, int boneIndex) { }

	// RVA: 0x7F1D258 Offset: 0x7F19258 VA: 0x7F1D258 Slot: 6
	public int get_BoneIndex() { }

	// RVA: 0x7F1D260 Offset: 0x7F19260 VA: 0x7F1D260 Slot: 5
	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }
}

// Namespace: Spine
public class RGBATimeline : CurveTimeline, ISlotTimeline // TypeDefIndex: 23893
{
	// Fields
	public const int ENTRIES = 5;
	protected const int R = 1;
	protected const int G = 2;
	protected const int B = 3;
	protected const int A = 4;
	private readonly int slotIndex; // 0x28

	// Properties
	public override int FrameEntries { get; }
	public int SlotIndex { get; }

	// Methods

	// RVA: 0x7F1D37C Offset: 0x7F1937C VA: 0x7F1D37C
	public void .ctor(int frameCount, int bezierCount, int slotIndex) { }

	// RVA: 0x7F1D4D4 Offset: 0x7F194D4 VA: 0x7F1D4D4 Slot: 4
	public override int get_FrameEntries() { }

	// RVA: 0x7F1D4DC Offset: 0x7F194DC VA: 0x7F1D4DC Slot: 6
	public int get_SlotIndex() { }

	// RVA: 0x7F1D4E4 Offset: 0x7F194E4 VA: 0x7F1D4E4
	public void SetFrame(int frame, float time, float r, float g, float b, float a) { }

	// RVA: 0x7F1D568 Offset: 0x7F19568 VA: 0x7F1D568 Slot: 5
	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }
}

// Namespace: Spine
public class RGBTimeline : CurveTimeline, ISlotTimeline // TypeDefIndex: 23894
{
	// Fields
	public const int ENTRIES = 4;
	protected const int R = 1;
	protected const int G = 2;
	protected const int B = 3;
	private readonly int slotIndex; // 0x28

	// Properties
	public override int FrameEntries { get; }
	public int SlotIndex { get; }

	// Methods

	// RVA: 0x7F1D964 Offset: 0x7F19964 VA: 0x7F1D964
	public void .ctor(int frameCount, int bezierCount, int slotIndex) { }

	// RVA: 0x7F1DA5C Offset: 0x7F19A5C VA: 0x7F1DA5C Slot: 4
	public override int get_FrameEntries() { }

	// RVA: 0x7F1DA64 Offset: 0x7F19A64 VA: 0x7F1DA64 Slot: 6
	public int get_SlotIndex() { }

	// RVA: 0x7F1DA6C Offset: 0x7F19A6C VA: 0x7F1DA6C
	public void SetFrame(int frame, float time, float r, float g, float b) { }

	// RVA: 0x7F1DAE0 Offset: 0x7F19AE0 VA: 0x7F1DAE0 Slot: 5
	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }
}

// Namespace: Spine
public class AlphaTimeline : CurveTimeline1, ISlotTimeline // TypeDefIndex: 23895
{
	// Fields
	private readonly int slotIndex; // 0x28

	// Properties
	public int SlotIndex { get; }

	// Methods

	// RVA: 0x7F1DE54 Offset: 0x7F19E54 VA: 0x7F1DE54
	public void .ctor(int frameCount, int bezierCount, int slotIndex) { }

	// RVA: 0x7F1DF04 Offset: 0x7F19F04 VA: 0x7F1DF04 Slot: 6
	public int get_SlotIndex() { }

	// RVA: 0x7F1DF0C Offset: 0x7F19F0C VA: 0x7F1DF0C Slot: 5
	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }
}

// Namespace: Spine
public class RGBA2Timeline : CurveTimeline, ISlotTimeline // TypeDefIndex: 23896
{
	// Fields
	public const int ENTRIES = 8;
	protected const int R = 1;
	protected const int G = 2;
	protected const int B = 3;
	protected const int A = 4;
	protected const int R2 = 5;
	protected const int G2 = 6;
	protected const int B2 = 7;
	private readonly int slotIndex; // 0x28

	// Properties
	public override int FrameEntries { get; }
	public int SlotIndex { get; }

	// Methods

	// RVA: 0x7F1E024 Offset: 0x7F1A024 VA: 0x7F1E024
	public void .ctor(int frameCount, int bezierCount, int slotIndex) { }

	// RVA: 0x7F1E1D4 Offset: 0x7F1A1D4 VA: 0x7F1E1D4 Slot: 4
	public override int get_FrameEntries() { }

	// RVA: 0x7F1E1DC Offset: 0x7F1A1DC VA: 0x7F1E1DC Slot: 6
	public int get_SlotIndex() { }

	// RVA: 0x7F1E1E4 Offset: 0x7F1A1E4 VA: 0x7F1E1E4
	public void SetFrame(int frame, float time, float r, float g, float b, float a, float r2, float g2, float b2) { }

	// RVA: 0x7F1E2AC Offset: 0x7F1A2AC VA: 0x7F1E2AC Slot: 5
	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }
}

// Namespace: Spine
public class RGB2Timeline : CurveTimeline, ISlotTimeline // TypeDefIndex: 23897
{
	// Fields
	public const int ENTRIES = 7;
	protected const int R = 1;
	protected const int G = 2;
	protected const int B = 3;
	protected const int R2 = 4;
	protected const int G2 = 5;
	protected const int B2 = 6;
	private readonly int slotIndex; // 0x28

	// Properties
	public override int FrameEntries { get; }
	public int SlotIndex { get; }

	// Methods

	// RVA: 0x7F1E88C Offset: 0x7F1A88C VA: 0x7F1E88C
	public void .ctor(int frameCount, int bezierCount, int slotIndex) { }

	// RVA: 0x7F1E9E4 Offset: 0x7F1A9E4 VA: 0x7F1E9E4 Slot: 4
	public override int get_FrameEntries() { }

	// RVA: 0x7F1E9EC Offset: 0x7F1A9EC VA: 0x7F1E9EC Slot: 6
	public int get_SlotIndex() { }

	// RVA: 0x7F1E9F4 Offset: 0x7F1A9F4 VA: 0x7F1E9F4
	public void SetFrame(int frame, float time, float r, float g, float b, float r2, float g2, float b2) { }

	// RVA: 0x7F1EAA4 Offset: 0x7F1AAA4 VA: 0x7F1EAA4 Slot: 5
	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }
}

// Namespace: Spine
public class AttachmentTimeline : Timeline, ISlotTimeline // TypeDefIndex: 23898
{
	// Fields
	private readonly int slotIndex; // 0x20
	private readonly string[] attachmentNames; // 0x28

	// Properties
	public int SlotIndex { get; }
	public string[] AttachmentNames { get; }

	// Methods

	// RVA: 0x7F1F028 Offset: 0x7F1B028 VA: 0x7F1F028
	public void .ctor(int frameCount, int slotIndex) { }

	// RVA: 0x7F1F134 Offset: 0x7F1B134 VA: 0x7F1F134 Slot: 6
	public int get_SlotIndex() { }

	// RVA: 0x7F1F13C Offset: 0x7F1B13C VA: 0x7F1F13C
	public string[] get_AttachmentNames() { }

	// RVA: 0x7F1F144 Offset: 0x7F1B144 VA: 0x7F1F144
	public void SetFrame(int frame, float time, string attachmentName) { }

	// RVA: 0x7F1F198 Offset: 0x7F1B198 VA: 0x7F1F198 Slot: 5
	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }

	// RVA: 0x7F1F28C Offset: 0x7F1B28C VA: 0x7F1F28C
	private void SetAttachment(Skeleton skeleton, Slot slot, string attachmentName) { }
}

// Namespace: Spine
public class DeformTimeline : CurveTimeline, ISlotTimeline // TypeDefIndex: 23899
{
	// Fields
	private readonly int slotIndex; // 0x28
	private readonly VertexAttachment attachment; // 0x30
	internal float[][] vertices; // 0x38

	// Properties
	public int SlotIndex { get; }
	public VertexAttachment Attachment { get; }
	public float[][] Vertices { get; }

	// Methods

	// RVA: 0x7F1F2D8 Offset: 0x7F1B2D8 VA: 0x7F1F2D8
	public void .ctor(int frameCount, int bezierCount, int slotIndex, VertexAttachment attachment) { }

	// RVA: 0x7F1F4D4 Offset: 0x7F1B4D4 VA: 0x7F1F4D4 Slot: 6
	public int get_SlotIndex() { }

	// RVA: 0x7F1F4DC Offset: 0x7F1B4DC VA: 0x7F1F4DC
	public VertexAttachment get_Attachment() { }

	// RVA: 0x7F1F4E4 Offset: 0x7F1B4E4 VA: 0x7F1F4E4
	public float[][] get_Vertices() { }

	// RVA: 0x7F1F4EC Offset: 0x7F1B4EC VA: 0x7F1F4EC
	public void SetFrame(int frame, float time, float[] vertices) { }

	// RVA: 0x7F1F540 Offset: 0x7F1B540 VA: 0x7F1F540
	public void setBezier(int bezier, int frame, int value, float time1, float value1, float cx1, float cy1, float cx2, float cy2, float time2, float value2) { }

	// RVA: 0x7F1F6FC Offset: 0x7F1B6FC VA: 0x7F1F6FC
	private float GetCurvePercent(float time, int frame) { }

	// RVA: 0x7F1F92C Offset: 0x7F1B92C VA: 0x7F1F92C Slot: 5
	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }
}

// Namespace: Spine
public class EventTimeline : Timeline // TypeDefIndex: 23900
{
	// Fields
	private static readonly string[] propertyIds; // 0x0
	private readonly Event[] events; // 0x20

	// Properties
	public Event[] Events { get; }

	// Methods

	// RVA: 0x7F20458 Offset: 0x7F1C458 VA: 0x7F20458
	public void .ctor(int frameCount) { }

	// RVA: 0x7F204F8 Offset: 0x7F1C4F8 VA: 0x7F204F8
	public Event[] get_Events() { }

	// RVA: 0x7F20500 Offset: 0x7F1C500 VA: 0x7F20500
	public void SetFrame(int frame, Event e) { }

	// RVA: 0x7F20594 Offset: 0x7F1C594 VA: 0x7F20594 Slot: 5
	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }

	// RVA: 0x7F207A8 Offset: 0x7F1C7A8 VA: 0x7F207A8
	private static void .cctor() { }
}

// Namespace: Spine
public class DrawOrderTimeline : Timeline // TypeDefIndex: 23901
{
	// Fields
	private static readonly string[] propertyIds; // 0x0
	private readonly int[][] drawOrders; // 0x20

	// Properties
	public int[][] DrawOrders { get; }

	// Methods

	// RVA: 0x7F2085C Offset: 0x7F1C85C VA: 0x7F2085C
	public void .ctor(int frameCount) { }

	// RVA: 0x7F208FC Offset: 0x7F1C8FC VA: 0x7F208FC
	public int[][] get_DrawOrders() { }

	// RVA: 0x7F20904 Offset: 0x7F1C904 VA: 0x7F20904
	public void SetFrame(int frame, float time, int[] drawOrder) { }

	// RVA: 0x7F20958 Offset: 0x7F1C958 VA: 0x7F20958 Slot: 5
	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }

	// RVA: 0x7F20B28 Offset: 0x7F1CB28 VA: 0x7F20B28
	private static void .cctor() { }
}

// Namespace: Spine
public class IkConstraintTimeline : CurveTimeline // TypeDefIndex: 23902
{
	// Fields
	public const int ENTRIES = 6;
	private const int MIX = 1;
	private const int SOFTNESS = 2;
	private const int BEND_DIRECTION = 3;
	private const int COMPRESS = 4;
	private const int STRETCH = 5;
	private readonly int ikConstraintIndex; // 0x28

	// Properties
	public override int FrameEntries { get; }
	public int IkConstraintIndex { get; }

	// Methods

	// RVA: 0x7F20BDC Offset: 0x7F1CBDC VA: 0x7F20BDC
	public void .ctor(int frameCount, int bezierCount, int ikConstraintIndex) { }

	// RVA: 0x7F20CD4 Offset: 0x7F1CCD4 VA: 0x7F20CD4 Slot: 4
	public override int get_FrameEntries() { }

	// RVA: 0x7F20CDC Offset: 0x7F1CCDC VA: 0x7F20CDC
	public int get_IkConstraintIndex() { }

	// RVA: 0x7F20CE4 Offset: 0x7F1CCE4 VA: 0x7F20CE4
	public void SetFrame(int frame, float time, float mix, float softness, int bendDirection, bool compress, bool stretch) { }

	// RVA: 0x7F20DA0 Offset: 0x7F1CDA0 VA: 0x7F20DA0 Slot: 5
	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }
}

// Namespace: Spine
public class TransformConstraintTimeline : CurveTimeline // TypeDefIndex: 23903
{
	// Fields
	public const int ENTRIES = 7;
	private const int ROTATE = 1;
	private const int X = 2;
	private const int Y = 3;
	private const int SCALEX = 4;
	private const int SCALEY = 5;
	private const int SHEARY = 6;
	private readonly int transformConstraintIndex; // 0x28

	// Properties
	public override int FrameEntries { get; }
	public int TransformConstraintIndex { get; }

	// Methods

	// RVA: 0x7F2110C Offset: 0x7F1D10C VA: 0x7F2110C
	public void .ctor(int frameCount, int bezierCount, int transformConstraintIndex) { }

	// RVA: 0x7F21204 Offset: 0x7F1D204 VA: 0x7F21204 Slot: 4
	public override int get_FrameEntries() { }

	// RVA: 0x7F2120C Offset: 0x7F1D20C VA: 0x7F2120C
	public int get_TransformConstraintIndex() { }

	// RVA: 0x7F21214 Offset: 0x7F1D214 VA: 0x7F21214
	public void SetFrame(int frame, float time, float mixRotate, float mixX, float mixY, float mixScaleX, float mixScaleY, float mixShearY) { }

	// RVA: 0x7F212C4 Offset: 0x7F1D2C4 VA: 0x7F212C4 Slot: 5
	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }

	// RVA: 0x7F21490 Offset: 0x7F1D490 VA: 0x7F21490
	public void GetCurveValue(out float rotate, out float x, out float y, out float scaleX, out float scaleY, out float shearY, float time) { }
}

// Namespace: Spine
public class PathConstraintPositionTimeline : CurveTimeline1 // TypeDefIndex: 23904
{
	// Fields
	private readonly int pathConstraintIndex; // 0x28

	// Properties
	public int PathConstraintIndex { get; }

	// Methods

	// RVA: 0x7F2185C Offset: 0x7F1D85C VA: 0x7F2185C
	public void .ctor(int frameCount, int bezierCount, int pathConstraintIndex) { }

	// RVA: 0x7F2190C Offset: 0x7F1D90C VA: 0x7F2190C
	public int get_PathConstraintIndex() { }

	// RVA: 0x7F21914 Offset: 0x7F1D914 VA: 0x7F21914 Slot: 5
	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }
}

// Namespace: Spine
public class PathConstraintSpacingTimeline : CurveTimeline1 // TypeDefIndex: 23905
{
	// Fields
	private readonly int pathConstraintIndex; // 0x28

	// Properties
	public int PathConstraintIndex { get; }

	// Methods

	// RVA: 0x7F21A00 Offset: 0x7F1DA00 VA: 0x7F21A00
	public void .ctor(int frameCount, int bezierCount, int pathConstraintIndex) { }

	// RVA: 0x7F21AB0 Offset: 0x7F1DAB0 VA: 0x7F21AB0
	public int get_PathConstraintIndex() { }

	// RVA: 0x7F21AB8 Offset: 0x7F1DAB8 VA: 0x7F21AB8 Slot: 5
	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> events, float alpha, MixBlend blend, MixDirection direction) { }
}

// Namespace: Spine
public class PathConstraintMixTimeline : CurveTimeline // TypeDefIndex: 23906
{
	// Fields
	public const int ENTRIES = 4;
	private const int ROTATE = 1;
	private const int X = 2;
	private const int Y = 3;
	private readonly int pathConstraintIndex; // 0x28

	// Properties
	public override int FrameEntries { get; }
	public int PathConstraintIndex { get; }

	// Methods

	// RVA: 0x7F21BA4 Offset: 0x7F1DBA4 VA: 0x7F21BA4
	public void .ctor(int frameCount, int bezierCount, int pathConstraintIndex) { }

	// RVA: 0x7F21C9C Offset: 0x7F1DC9C VA: 0x7F21C9C Slot: 4
	public override int get_FrameEntries() { }

	// RVA: 0x7F21CA4 Offset: 0x7F1DCA4 VA: 0x7F21CA4
	public int get_PathConstraintIndex() { }

	// RVA: 0x7F21CAC Offset: 0x7F1DCAC VA: 0x7F21CAC
	public void SetFrame(int frame, float time, float mixRotate, float mixX, float mixY) { }

	// RVA: 0x7F21D20 Offset: 0x7F1DD20 VA: 0x7F21D20 Slot: 5
	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }
}

// Namespace: Spine
public class SequenceTimeline : Timeline, ISlotTimeline // TypeDefIndex: 23907
{
	// Fields
	public const int ENTRIES = 3;
	private const int MODE = 1;
	private const int DELAY = 2;
	private readonly int slotIndex; // 0x20
	private readonly IHasTextureRegion attachment; // 0x28

	// Properties
	public override int FrameEntries { get; }
	public int SlotIndex { get; }
	public Attachment Attachment { get; }

	// Methods

	// RVA: 0x7F22078 Offset: 0x7F1E078 VA: 0x7F22078
	public void .ctor(int frameCount, int slotIndex, Attachment attachment) { }

	// RVA: 0x7F22328 Offset: 0x7F1E328 VA: 0x7F22328 Slot: 4
	public override int get_FrameEntries() { }

	// RVA: 0x7F22330 Offset: 0x7F1E330 VA: 0x7F22330 Slot: 6
	public int get_SlotIndex() { }

	// RVA: 0x7F22338 Offset: 0x7F1E338 VA: 0x7F22338
	public Attachment get_Attachment() { }

	// RVA: 0x7F223B0 Offset: 0x7F1E3B0 VA: 0x7F223B0
	public void SetFrame(int frame, float time, SequenceMode mode, int index, float delay) { }

	// RVA: 0x7F22414 Offset: 0x7F1E414 VA: 0x7F22414 Slot: 5
	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }
}

// Namespace: 
public sealed class AnimationState.TrackEntryDelegate : MulticastDelegate // TypeDefIndex: 23908
{
	// Methods

	// RVA: 0x7F26260 Offset: 0x7F22260 VA: 0x7F26260
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7F26368 Offset: 0x7F22368 VA: 0x7F26368 Slot: 13
	public virtual void Invoke(TrackEntry trackEntry) { }

	// RVA: 0x7F2637C Offset: 0x7F2237C VA: 0x7F2637C Slot: 14
	public virtual IAsyncResult BeginInvoke(TrackEntry trackEntry, AsyncCallback callback, object object) { }

	// RVA: 0x7F2639C Offset: 0x7F2239C VA: 0x7F2639C Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class AnimationState.TrackEntryEventDelegate : MulticastDelegate // TypeDefIndex: 23909
{
	// Methods

	// RVA: 0x7F263A8 Offset: 0x7F223A8 VA: 0x7F263A8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7F264B4 Offset: 0x7F224B4 VA: 0x7F264B4 Slot: 13
	public virtual void Invoke(TrackEntry trackEntry, Event e) { }

	// RVA: 0x7F264C8 Offset: 0x7F224C8 VA: 0x7F264C8 Slot: 14
	public virtual IAsyncResult BeginInvoke(TrackEntry trackEntry, Event e, AsyncCallback callback, object object) { }

	// RVA: 0x7F264F0 Offset: 0x7F224F0 VA: 0x7F264F0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Spine
public class AnimationState // TypeDefIndex: 23910
{
	// Fields
	internal static readonly Animation EmptyAnimation; // 0x0
	internal const int Subsequent = 0;
	internal const int First = 1;
	internal const int HoldSubsequent = 2;
	internal const int HoldFirst = 3;
	internal const int HoldMix = 4;
	internal const int Setup = 1;
	internal const int Current = 2;
	protected AnimationStateData data; // 0x10
	private readonly ExposedList<TrackEntry> tracks; // 0x18
	private readonly ExposedList<Event> events; // 0x20
	[CompilerGenerated]
	private AnimationState.TrackEntryDelegate Start; // 0x28
	[CompilerGenerated]
	private AnimationState.TrackEntryDelegate Interrupt; // 0x30
	[CompilerGenerated]
	private AnimationState.TrackEntryDelegate End; // 0x38
	[CompilerGenerated]
	private AnimationState.TrackEntryDelegate Dispose; // 0x40
	[CompilerGenerated]
	private AnimationState.TrackEntryDelegate Complete; // 0x48
	[CompilerGenerated]
	private AnimationState.TrackEntryEventDelegate Event; // 0x50
	private readonly EventQueue queue; // 0x58
	private readonly HashSet<string> propertyIds; // 0x60
	private bool animationsChanged; // 0x68
	private float timeScale; // 0x6C
	private int unkeyedState; // 0x70
	private readonly Pool<TrackEntry> trackEntryPool; // 0x78

	// Properties
	public float TimeScale { get; set; }
	public AnimationStateData Data { get; set; }
	public ExposedList<TrackEntry> Tracks { get; }

	// Methods

	// RVA: 0x7F227CC Offset: 0x7F1E7CC VA: 0x7F227CC
	internal void OnStart(TrackEntry entry) { }

	// RVA: 0x7F227E8 Offset: 0x7F1E7E8 VA: 0x7F227E8
	internal void OnInterrupt(TrackEntry entry) { }

	// RVA: 0x7F22804 Offset: 0x7F1E804 VA: 0x7F22804
	internal void OnEnd(TrackEntry entry) { }

	// RVA: 0x7F22820 Offset: 0x7F1E820 VA: 0x7F22820
	internal void OnDispose(TrackEntry entry) { }

	// RVA: 0x7F2283C Offset: 0x7F1E83C VA: 0x7F2283C
	internal void OnComplete(TrackEntry entry) { }

	// RVA: 0x7F22858 Offset: 0x7F1E858 VA: 0x7F22858
	internal void OnEvent(TrackEntry entry, Event e) { }

	[CompilerGenerated]
	// RVA: 0x7F22874 Offset: 0x7F1E874 VA: 0x7F22874
	public void add_Start(AnimationState.TrackEntryDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F22910 Offset: 0x7F1E910 VA: 0x7F22910
	public void remove_Start(AnimationState.TrackEntryDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F229AC Offset: 0x7F1E9AC VA: 0x7F229AC
	public void add_Interrupt(AnimationState.TrackEntryDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F22A48 Offset: 0x7F1EA48 VA: 0x7F22A48
	public void remove_Interrupt(AnimationState.TrackEntryDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F22AE4 Offset: 0x7F1EAE4 VA: 0x7F22AE4
	public void add_End(AnimationState.TrackEntryDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F22B80 Offset: 0x7F1EB80 VA: 0x7F22B80
	public void remove_End(AnimationState.TrackEntryDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F22C1C Offset: 0x7F1EC1C VA: 0x7F22C1C
	public void add_Dispose(AnimationState.TrackEntryDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F22CB8 Offset: 0x7F1ECB8 VA: 0x7F22CB8
	public void remove_Dispose(AnimationState.TrackEntryDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F22D54 Offset: 0x7F1ED54 VA: 0x7F22D54
	public void add_Complete(AnimationState.TrackEntryDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F22DF0 Offset: 0x7F1EDF0 VA: 0x7F22DF0
	public void remove_Complete(AnimationState.TrackEntryDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F22E8C Offset: 0x7F1EE8C VA: 0x7F22E8C
	public void add_Event(AnimationState.TrackEntryEventDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F22F28 Offset: 0x7F1EF28 VA: 0x7F22F28
	public void remove_Event(AnimationState.TrackEntryEventDelegate value) { }

	// RVA: 0x7F22FC4 Offset: 0x7F1EFC4 VA: 0x7F22FC4
	public void AssignEventSubscribersFrom(AnimationState src) { }

	// RVA: 0x7F23040 Offset: 0x7F1F040 VA: 0x7F23040
	public void AddEventSubscribersFrom(AnimationState src) { }

	// RVA: 0x7F230A4 Offset: 0x7F1F0A4 VA: 0x7F230A4
	public void .ctor(AnimationStateData data) { }

	// RVA: 0x7F23338 Offset: 0x7F1F338 VA: 0x7F23338
	public void Update(float delta) { }

	// RVA: 0x7F23740 Offset: 0x7F1F740 VA: 0x7F23740
	private bool UpdateMixingFrom(TrackEntry to, float delta) { }

	// RVA: 0x7F2383C Offset: 0x7F1F83C VA: 0x7F2383C
	public bool Apply(Skeleton skeleton) { }

	// RVA: 0x7F24BF8 Offset: 0x7F20BF8 VA: 0x7F24BF8
	public bool ApplyEventTimelinesOnly(Skeleton skeleton, bool issueEvents = True) { }

	// RVA: 0x7F23EE0 Offset: 0x7F1FEE0 VA: 0x7F23EE0
	private float ApplyMixingFrom(TrackEntry to, Skeleton skeleton, MixBlend blend) { }

	// RVA: 0x7F24E7C Offset: 0x7F20E7C VA: 0x7F24E7C
	private float ApplyMixingFromEventTimelinesOnly(TrackEntry to, Skeleton skeleton, bool issueEvents) { }

	// RVA: 0x7F245A4 Offset: 0x7F205A4 VA: 0x7F245A4
	private void ApplyAttachmentTimeline(AttachmentTimeline timeline, Skeleton skeleton, float time, MixBlend blend, bool attachments) { }

	// RVA: 0x7F25068 Offset: 0x7F21068 VA: 0x7F25068
	private void SetAttachment(Skeleton skeleton, Slot slot, string attachmentName, bool attachments) { }

	// RVA: 0x7F246C4 Offset: 0x7F206C4 VA: 0x7F246C4
	private static void ApplyRotateTimeline(RotateTimeline timeline, Skeleton skeleton, float time, float alpha, MixBlend blend, float[] timelinesRotation, int i, bool firstFrame) { }

	// RVA: 0x7F24A7C Offset: 0x7F20A7C VA: 0x7F24A7C
	private void QueueEvents(TrackEntry entry, float animationTime) { }

	// RVA: 0x7F250E4 Offset: 0x7F210E4 VA: 0x7F250E4
	public void ClearTracks() { }

	// RVA: 0x7F25198 Offset: 0x7F21198 VA: 0x7F25198
	public void ClearTrack(int trackIndex) { }

	// RVA: 0x7F23544 Offset: 0x7F1F544 VA: 0x7F23544
	private void SetCurrent(int index, TrackEntry current, bool interrupt) { }

	// RVA: 0x7F25348 Offset: 0x7F21348 VA: 0x7F25348
	public TrackEntry SetAnimation(int trackIndex, string animationName, bool loop) { }

	// RVA: 0x7F25410 Offset: 0x7F21410 VA: 0x7F25410
	public TrackEntry SetAnimation(int trackIndex, Animation animation, bool loop) { }

	// RVA: 0x7F256C4 Offset: 0x7F216C4 VA: 0x7F256C4
	public TrackEntry AddAnimation(int trackIndex, string animationName, bool loop, float delay) { }

	// RVA: 0x7F2579C Offset: 0x7F2179C VA: 0x7F2579C
	public TrackEntry AddAnimation(int trackIndex, Animation animation, bool loop, float delay) { }

	// RVA: 0x7F2595C Offset: 0x7F2195C VA: 0x7F2595C
	public TrackEntry SetEmptyAnimation(int trackIndex, float mixDuration) { }

	// RVA: 0x7F259F0 Offset: 0x7F219F0 VA: 0x7F259F0
	public TrackEntry AddEmptyAnimation(int trackIndex, float mixDuration, float delay) { }

	// RVA: 0x7F25AB0 Offset: 0x7F21AB0 VA: 0x7F25AB0
	public void SetEmptyAnimations(float mixDuration) { }

	// RVA: 0x7F252B8 Offset: 0x7F212B8 VA: 0x7F252B8
	private TrackEntry ExpandToIndex(int index) { }

	// RVA: 0x7F255B0 Offset: 0x7F215B0 VA: 0x7F255B0
	private TrackEntry NewTrackEntry(int trackIndex, Animation animation, bool loop, TrackEntry last) { }

	// RVA: 0x7F236EC Offset: 0x7F1F6EC VA: 0x7F236EC
	public void ClearNext(TrackEntry entry) { }

	// RVA: 0x7F23E00 Offset: 0x7F1FE00 VA: 0x7F23E00
	private void AnimationsChanged() { }

	// RVA: 0x7F25B64 Offset: 0x7F21B64 VA: 0x7F25B64
	private void ComputeHold(TrackEntry entry) { }

	// RVA: 0x7F25F14 Offset: 0x7F21F14 VA: 0x7F25F14
	public TrackEntry GetCurrent(int trackIndex) { }

	// RVA: 0x7F25F60 Offset: 0x7F21F60 VA: 0x7F25F60
	public void ClearListenerNotifications() { }

	// RVA: 0x7F25F7C Offset: 0x7F21F7C VA: 0x7F25F7C
	public float get_TimeScale() { }

	// RVA: 0x7F25F84 Offset: 0x7F21F84 VA: 0x7F25F84
	public void set_TimeScale(float value) { }

	// RVA: 0x7F25F8C Offset: 0x7F21F8C VA: 0x7F25F8C
	public AnimationStateData get_Data() { }

	// RVA: 0x7F25F94 Offset: 0x7F21F94 VA: 0x7F25F94
	public void set_Data(AnimationStateData value) { }

	// RVA: 0x7F26010 Offset: 0x7F22010 VA: 0x7F26010
	public ExposedList<TrackEntry> get_Tracks() { }

	// RVA: 0x7F26018 Offset: 0x7F22018 VA: 0x7F26018 Slot: 3
	public override string ToString() { }

	// RVA: 0x7F26170 Offset: 0x7F22170 VA: 0x7F26170
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x7F26254 Offset: 0x7F22254 VA: 0x7F26254
	private void <.ctor>b__45_0() { }
}

// Namespace: Spine
public class TrackEntry : Pool.IPoolable<TrackEntry> // TypeDefIndex: 23911
{
	// Fields
	internal Animation animation; // 0x10
	internal TrackEntry previous; // 0x18
	internal TrackEntry next; // 0x20
	internal TrackEntry mixingFrom; // 0x28
	internal TrackEntry mixingTo; // 0x30
	[CompilerGenerated]
	private AnimationState.TrackEntryDelegate Start; // 0x38
	[CompilerGenerated]
	private AnimationState.TrackEntryDelegate Interrupt; // 0x40
	[CompilerGenerated]
	private AnimationState.TrackEntryDelegate End; // 0x48
	[CompilerGenerated]
	private AnimationState.TrackEntryDelegate Dispose; // 0x50
	[CompilerGenerated]
	private AnimationState.TrackEntryDelegate Complete; // 0x58
	[CompilerGenerated]
	private AnimationState.TrackEntryEventDelegate Event; // 0x60
	internal int trackIndex; // 0x68
	internal bool loop; // 0x6C
	internal bool holdPrevious; // 0x6D
	internal bool reverse; // 0x6E
	internal bool shortestRotation; // 0x6F
	internal float eventThreshold; // 0x70
	internal float attachmentThreshold; // 0x74
	internal float drawOrderThreshold; // 0x78
	internal float animationStart; // 0x7C
	internal float animationEnd; // 0x80
	internal float animationLast; // 0x84
	internal float nextAnimationLast; // 0x88
	internal float delay; // 0x8C
	internal float trackTime; // 0x90
	internal float trackLast; // 0x94
	internal float nextTrackLast; // 0x98
	internal float trackEnd; // 0x9C
	internal float timeScale; // 0xA0
	internal float alpha; // 0xA4
	internal float mixTime; // 0xA8
	internal float mixDuration; // 0xAC
	internal float interruptAlpha; // 0xB0
	internal float totalAlpha; // 0xB4
	internal MixBlend mixBlend; // 0xB8
	internal readonly ExposedList<int> timelineMode; // 0xC0
	internal readonly ExposedList<TrackEntry> timelineHoldMix; // 0xC8
	internal readonly ExposedList<float> timelinesRotation; // 0xD0

	// Properties
	public int TrackIndex { get; }
	public Animation Animation { get; }
	public bool Loop { get; set; }
	public float Delay { get; set; }
	public float TrackTime { get; set; }
	public float TrackEnd { get; set; }
	public float TrackComplete { get; }
	public float AnimationStart { get; set; }
	public float AnimationEnd { get; set; }
	public float AnimationLast { get; set; }
	public float AnimationTime { get; }
	public float TimeScale { get; set; }
	public float Alpha { get; set; }
	public float InterruptAlpha { get; }
	public float EventThreshold { get; set; }
	public float AttachmentThreshold { get; set; }
	public float DrawOrderThreshold { get; set; }
	public TrackEntry Next { get; }
	public TrackEntry Previous { get; }
	public bool IsComplete { get; }
	public float MixTime { get; set; }
	public float MixDuration { get; set; }
	public MixBlend MixBlend { get; set; }
	public TrackEntry MixingFrom { get; }
	public TrackEntry MixingTo { get; }
	public bool HoldPrevious { get; set; }
	public bool Reverse { get; set; }
	public bool ShortestRotation { get; set; }
	public bool IsEmptyAnimation { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7F264FC Offset: 0x7F224FC VA: 0x7F264FC
	public void add_Start(AnimationState.TrackEntryDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F26598 Offset: 0x7F22598 VA: 0x7F26598
	public void remove_Start(AnimationState.TrackEntryDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F26634 Offset: 0x7F22634 VA: 0x7F26634
	public void add_Interrupt(AnimationState.TrackEntryDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F266D0 Offset: 0x7F226D0 VA: 0x7F266D0
	public void remove_Interrupt(AnimationState.TrackEntryDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F2676C Offset: 0x7F2276C VA: 0x7F2676C
	public void add_End(AnimationState.TrackEntryDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F26808 Offset: 0x7F22808 VA: 0x7F26808
	public void remove_End(AnimationState.TrackEntryDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F268A4 Offset: 0x7F228A4 VA: 0x7F268A4
	public void add_Dispose(AnimationState.TrackEntryDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F26940 Offset: 0x7F22940 VA: 0x7F26940
	public void remove_Dispose(AnimationState.TrackEntryDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F269DC Offset: 0x7F229DC VA: 0x7F269DC
	public void add_Complete(AnimationState.TrackEntryDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F26A78 Offset: 0x7F22A78 VA: 0x7F26A78
	public void remove_Complete(AnimationState.TrackEntryDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F26B14 Offset: 0x7F22B14 VA: 0x7F26B14
	public void add_Event(AnimationState.TrackEntryEventDelegate value) { }

	[CompilerGenerated]
	// RVA: 0x7F26BB0 Offset: 0x7F22BB0 VA: 0x7F26BB0
	public void remove_Event(AnimationState.TrackEntryEventDelegate value) { }

	// RVA: 0x7F26C4C Offset: 0x7F22C4C VA: 0x7F26C4C
	internal void OnStart() { }

	// RVA: 0x7F26C6C Offset: 0x7F22C6C VA: 0x7F26C6C
	internal void OnInterrupt() { }

	// RVA: 0x7F26C8C Offset: 0x7F22C8C VA: 0x7F26C8C
	internal void OnEnd() { }

	// RVA: 0x7F26CAC Offset: 0x7F22CAC VA: 0x7F26CAC
	internal void OnDispose() { }

	// RVA: 0x7F26CCC Offset: 0x7F22CCC VA: 0x7F26CCC
	internal void OnComplete() { }

	// RVA: 0x7F26CEC Offset: 0x7F22CEC VA: 0x7F26CEC
	internal void OnEvent(Event e) { }

	// RVA: 0x7F26D14 Offset: 0x7F22D14 VA: 0x7F26D14 Slot: 4
	public void Reset() { }

	// RVA: 0x7F26E6C Offset: 0x7F22E6C VA: 0x7F26E6C
	public int get_TrackIndex() { }

	// RVA: 0x7F26E74 Offset: 0x7F22E74 VA: 0x7F26E74
	public Animation get_Animation() { }

	// RVA: 0x7F26E7C Offset: 0x7F22E7C VA: 0x7F26E7C
	public bool get_Loop() { }

	// RVA: 0x7F26E84 Offset: 0x7F22E84 VA: 0x7F26E84
	public void set_Loop(bool value) { }

	// RVA: 0x7F26E90 Offset: 0x7F22E90 VA: 0x7F26E90
	public float get_Delay() { }

	// RVA: 0x7F26E98 Offset: 0x7F22E98 VA: 0x7F26E98
	public void set_Delay(float value) { }

	// RVA: 0x7F26EA0 Offset: 0x7F22EA0 VA: 0x7F26EA0
	public float get_TrackTime() { }

	// RVA: 0x7F26EA8 Offset: 0x7F22EA8 VA: 0x7F26EA8
	public void set_TrackTime(float value) { }

	// RVA: 0x7F26EB0 Offset: 0x7F22EB0 VA: 0x7F26EB0
	public float get_TrackEnd() { }

	// RVA: 0x7F26EB8 Offset: 0x7F22EB8 VA: 0x7F26EB8
	public void set_TrackEnd(float value) { }

	// RVA: 0x7F258F8 Offset: 0x7F218F8 VA: 0x7F258F8
	public float get_TrackComplete() { }

	// RVA: 0x7F26EC0 Offset: 0x7F22EC0 VA: 0x7F26EC0
	public float get_AnimationStart() { }

	// RVA: 0x7F26EC8 Offset: 0x7F22EC8 VA: 0x7F26EC8
	public void set_AnimationStart(float value) { }

	// RVA: 0x7F26ED0 Offset: 0x7F22ED0 VA: 0x7F26ED0
	public float get_AnimationEnd() { }

	// RVA: 0x7F26ED8 Offset: 0x7F22ED8 VA: 0x7F26ED8
	public void set_AnimationEnd(float value) { }

	// RVA: 0x7F26EE0 Offset: 0x7F22EE0 VA: 0x7F26EE0
	public float get_AnimationLast() { }

	// RVA: 0x7F26EE8 Offset: 0x7F22EE8 VA: 0x7F26EE8
	public void set_AnimationLast(float value) { }

	// RVA: 0x7F244E0 Offset: 0x7F204E0 VA: 0x7F244E0
	public float get_AnimationTime() { }

	// RVA: 0x7F26EF0 Offset: 0x7F22EF0 VA: 0x7F26EF0
	public float get_TimeScale() { }

	// RVA: 0x7F26EF8 Offset: 0x7F22EF8 VA: 0x7F26EF8
	public void set_TimeScale(float value) { }

	// RVA: 0x7F26F00 Offset: 0x7F22F00 VA: 0x7F26F00
	public float get_Alpha() { }

	// RVA: 0x7F26F08 Offset: 0x7F22F08 VA: 0x7F26F08
	public void set_Alpha(float value) { }

	// RVA: 0x7F26F10 Offset: 0x7F22F10 VA: 0x7F26F10
	public float get_InterruptAlpha() { }

	// RVA: 0x7F26F18 Offset: 0x7F22F18 VA: 0x7F26F18
	public float get_EventThreshold() { }

	// RVA: 0x7F26F20 Offset: 0x7F22F20 VA: 0x7F26F20
	public void set_EventThreshold(float value) { }

	// RVA: 0x7F26F28 Offset: 0x7F22F28 VA: 0x7F26F28
	public float get_AttachmentThreshold() { }

	// RVA: 0x7F26F30 Offset: 0x7F22F30 VA: 0x7F26F30
	public void set_AttachmentThreshold(float value) { }

	// RVA: 0x7F26F38 Offset: 0x7F22F38 VA: 0x7F26F38
	public float get_DrawOrderThreshold() { }

	// RVA: 0x7F26F40 Offset: 0x7F22F40 VA: 0x7F26F40
	public void set_DrawOrderThreshold(float value) { }

	// RVA: 0x7F26F48 Offset: 0x7F22F48 VA: 0x7F26F48
	public TrackEntry get_Next() { }

	// RVA: 0x7F26F50 Offset: 0x7F22F50 VA: 0x7F26F50
	public TrackEntry get_Previous() { }

	// RVA: 0x7F26F58 Offset: 0x7F22F58 VA: 0x7F26F58
	public bool get_IsComplete() { }

	// RVA: 0x7F26F70 Offset: 0x7F22F70 VA: 0x7F26F70
	public float get_MixTime() { }

	// RVA: 0x7F26F78 Offset: 0x7F22F78 VA: 0x7F26F78
	public void set_MixTime(float value) { }

	// RVA: 0x7F26F80 Offset: 0x7F22F80 VA: 0x7F26F80
	public float get_MixDuration() { }

	// RVA: 0x7F26F88 Offset: 0x7F22F88 VA: 0x7F26F88
	public void set_MixDuration(float value) { }

	// RVA: 0x7F26F90 Offset: 0x7F22F90 VA: 0x7F26F90
	public MixBlend get_MixBlend() { }

	// RVA: 0x7F26F98 Offset: 0x7F22F98 VA: 0x7F26F98
	public void set_MixBlend(MixBlend value) { }

	// RVA: 0x7F26FA0 Offset: 0x7F22FA0 VA: 0x7F26FA0
	public TrackEntry get_MixingFrom() { }

	// RVA: 0x7F26FA8 Offset: 0x7F22FA8 VA: 0x7F26FA8
	public TrackEntry get_MixingTo() { }

	// RVA: 0x7F26FB0 Offset: 0x7F22FB0 VA: 0x7F26FB0
	public bool get_HoldPrevious() { }

	// RVA: 0x7F26FB8 Offset: 0x7F22FB8 VA: 0x7F26FB8
	public void set_HoldPrevious(bool value) { }

	// RVA: 0x7F26FC4 Offset: 0x7F22FC4 VA: 0x7F26FC4
	public bool get_Reverse() { }

	// RVA: 0x7F26FCC Offset: 0x7F22FCC VA: 0x7F26FCC
	public void set_Reverse(bool value) { }

	// RVA: 0x7F26FD8 Offset: 0x7F22FD8 VA: 0x7F26FD8
	public bool get_ShortestRotation() { }

	// RVA: 0x7F26FE0 Offset: 0x7F22FE0 VA: 0x7F26FE0
	public void set_ShortestRotation(bool value) { }

	// RVA: 0x7F26FEC Offset: 0x7F22FEC VA: 0x7F26FEC
	public bool get_IsEmptyAnimation() { }

	// RVA: 0x7F27054 Offset: 0x7F23054 VA: 0x7F27054
	public void ResetRotationDirections() { }

	// RVA: 0x7F270A8 Offset: 0x7F230A8 VA: 0x7F270A8 Slot: 3
	public override string ToString() { }

	// RVA: 0x7F270FC Offset: 0x7F230FC VA: 0x7F270FC
	public void AllowImmediateQueue() { }

	// RVA: 0x7F27110 Offset: 0x7F23110 VA: 0x7F27110
	public void .ctor() { }
}

// Namespace: 
private struct EventQueue.EventQueueEntry // TypeDefIndex: 23912
{
	// Fields
	public EventQueue.EventType type; // 0x0
	public TrackEntry entry; // 0x8
	public Event e; // 0x10

	// Methods

	// RVA: 0x7F27584 Offset: 0x7F23584 VA: 0x7F27584
	public void .ctor(EventQueue.EventType eventType, TrackEntry trackEntry, Event e) { }
}

// Namespace: 
private enum EventQueue.EventType // TypeDefIndex: 23913
{
	// Fields
	public int value__; // 0x0
	public const EventQueue.EventType Start = 0;
	public const EventQueue.EventType Interrupt = 1;
	public const EventQueue.EventType End = 2;
	public const EventQueue.EventType Dispose = 3;
	public const EventQueue.EventType Complete = 4;
	public const EventQueue.EventType Event = 5;
}

// Namespace: Spine
internal class EventQueue // TypeDefIndex: 23914
{
	// Fields
	private readonly List<EventQueue.EventQueueEntry> eventQueueEntries; // 0x10
	internal bool drainDisabled; // 0x18
	private readonly AnimationState state; // 0x20
	private readonly Pool<TrackEntry> trackEntryPool; // 0x28
	[CompilerGenerated]
	private Action AnimationsChanged; // 0x30

	// Methods

	[CompilerGenerated]
	// RVA: 0x7F27250 Offset: 0x7F23250 VA: 0x7F27250
	internal void add_AnimationsChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x7F272EC Offset: 0x7F232EC VA: 0x7F272EC
	internal void remove_AnimationsChanged(Action value) { }

	// RVA: 0x7F27388 Offset: 0x7F23388 VA: 0x7F27388
	internal void .ctor(AnimationState state, Action HandleAnimationsChanged, Pool<TrackEntry> trackEntryPool) { }

	// RVA: 0x7F27450 Offset: 0x7F23450 VA: 0x7F27450
	internal void Start(TrackEntry entry) { }

	// RVA: 0x7F275BC Offset: 0x7F235BC VA: 0x7F275BC
	internal void Interrupt(TrackEntry entry) { }

	// RVA: 0x7F276D8 Offset: 0x7F236D8 VA: 0x7F276D8
	internal void End(TrackEntry entry) { }

	// RVA: 0x7F27814 Offset: 0x7F23814 VA: 0x7F27814
	internal void Dispose(TrackEntry entry) { }

	// RVA: 0x7F27930 Offset: 0x7F23930 VA: 0x7F27930
	internal void Complete(TrackEntry entry) { }

	// RVA: 0x7F27A4C Offset: 0x7F23A4C VA: 0x7F27A4C
	internal void Event(TrackEntry entry, Event e) { }

	// RVA: 0x7F27B74 Offset: 0x7F23B74 VA: 0x7F27B74
	internal void Drain() { }

	// RVA: 0x7F27DBC Offset: 0x7F23DBC VA: 0x7F27DBC
	internal void Clear() { }
}

// Namespace: 
public interface Pool.IPoolable<T> // TypeDefIndex: 23915
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Reset();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Pool.IPoolable<object>.Reset
	*/
}

// Namespace: Spine
internal class Pool<T> // TypeDefIndex: 23916
{
	// Fields
	public readonly int max; // 0x0
	private readonly Stack<T> freeObjects; // 0x0
	[CompilerGenerated]
	private int <Peak>k__BackingField; // 0x0

	// Properties
	public int Count { get; }
	public int Peak { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x526A614 Offset: 0x5266614 VA: 0x526A614
	|-Pool<object>.get_Count
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_Peak() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x526A630 Offset: 0x5266630 VA: 0x526A630
	|-Pool<object>.get_Peak
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Peak(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x526A638 Offset: 0x5266638 VA: 0x526A638
	|-Pool<object>.set_Peak
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int initialCapacity = 16, int max = 2147483647) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x526A640 Offset: 0x5266640 VA: 0x526A640
	|-Pool<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T Obtain() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x526A6BC Offset: 0x52666BC VA: 0x526A6BC
	|-Pool<object>.Obtain
	*/

	// RVA: -1 Offset: -1
	public void Free(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x526A6F4 Offset: 0x52666F4 VA: 0x526A6F4
	|-Pool<object>.Free
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x526A80C Offset: 0x526680C VA: 0x526A80C
	|-Pool<object>.Clear
	*/

	// RVA: -1 Offset: -1
	protected void Reset(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x526A830 Offset: 0x5266830 VA: 0x526A830
	|-Pool<object>.Reset
	*/
}

// Namespace: Spine
[Extension]
public static class HashSetExtensions // TypeDefIndex: 23917
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static bool AddAll<T>(HashSet<T> set, T[] addSet) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46390E8 Offset: 0x46350E8 VA: 0x46390E8
	|-HashSetExtensions.AddAll<object>
	|
	|-RVA: 0x4639194 Offset: 0x4635194 VA: 0x4639194
	|-HashSetExtensions.AddAll<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
public struct AnimationStateData.AnimationPair // TypeDefIndex: 23918
{
	// Fields
	public readonly Animation a1; // 0x0
	public readonly Animation a2; // 0x8

	// Methods

	// RVA: 0x7F281F4 Offset: 0x7F241F4 VA: 0x7F281F4
	public void .ctor(Animation a1, Animation a2) { }

	// RVA: 0x7F2836C Offset: 0x7F2436C VA: 0x7F2836C Slot: 3
	public override string ToString() { }
}

// Namespace: 
public class AnimationStateData.AnimationPairComparer : IEqualityComparer<AnimationStateData.AnimationPair> // TypeDefIndex: 23919
{
	// Fields
	public static readonly AnimationStateData.AnimationPairComparer Instance; // 0x0

	// Methods

	// RVA: 0x7F283D0 Offset: 0x7F243D0 VA: 0x7F283D0 Slot: 4
	private bool System.Collections.Generic.IEqualityComparer<Spine.AnimationStateData.AnimationPair>.Equals(AnimationStateData.AnimationPair x, AnimationStateData.AnimationPair y) { }

	// RVA: 0x7F283E8 Offset: 0x7F243E8 VA: 0x7F283E8 Slot: 5
	private int System.Collections.Generic.IEqualityComparer<Spine.AnimationStateData.AnimationPair>.GetHashCode(AnimationStateData.AnimationPair obj) { }

	// RVA: 0x7F2843C Offset: 0x7F2443C VA: 0x7F2843C
	public void .ctor() { }

	// RVA: 0x7F28444 Offset: 0x7F24444 VA: 0x7F28444
	private static void .cctor() { }
}

// Namespace: Spine
public class AnimationStateData // TypeDefIndex: 23920
{
	// Fields
	internal SkeletonData skeletonData; // 0x10
	private readonly Dictionary<AnimationStateData.AnimationPair, float> animationToMixTime; // 0x18
	internal float defaultMix; // 0x20

	// Properties
	public SkeletonData SkeletonData { get; }
	public float DefaultMix { get; set; }

	// Methods

	// RVA: 0x7F27E2C Offset: 0x7F23E2C VA: 0x7F27E2C
	public SkeletonData get_SkeletonData() { }

	// RVA: 0x7F27E34 Offset: 0x7F23E34 VA: 0x7F27E34
	public float get_DefaultMix() { }

	// RVA: 0x7F27E3C Offset: 0x7F23E3C VA: 0x7F27E3C
	public void set_DefaultMix(float value) { }

	// RVA: 0x7F27E44 Offset: 0x7F23E44 VA: 0x7F27E44
	public void .ctor(SkeletonData skeletonData) { }

	// RVA: 0x7F27F74 Offset: 0x7F23F74 VA: 0x7F27F74
	public void SetMix(string fromName, string toName, float duration) { }

	// RVA: 0x7F28090 Offset: 0x7F24090 VA: 0x7F28090
	public void SetMix(Animation from, Animation to, float duration) { }

	// RVA: 0x7F28224 Offset: 0x7F24224 VA: 0x7F28224
	public float GetMix(Animation from, Animation to) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Atlas.<>c__DisplayClass10_0 // TypeDefIndex: 23921
{
	// Fields
	public AtlasPage page; // 0x10
	public string[] entry; // 0x18
	public AtlasRegion region; // 0x20

	// Methods

	// RVA: 0x7F29750 Offset: 0x7F25750 VA: 0x7F29750
	public void .ctor() { }

	// RVA: 0x7F29BB8 Offset: 0x7F25BB8 VA: 0x7F29BB8
	internal void <.ctor>b__0() { }

	// RVA: 0x7F29C88 Offset: 0x7F25C88 VA: 0x7F29C88
	internal void <.ctor>b__1() { }

	// RVA: 0x7F29DA8 Offset: 0x7F25DA8 VA: 0x7F29DA8
	internal void <.ctor>b__2() { }

	// RVA: 0x7F29F28 Offset: 0x7F25F28 VA: 0x7F29F28
	internal void <.ctor>b__3() { }

	// RVA: 0x7F29FC0 Offset: 0x7F25FC0 VA: 0x7F29FC0
	internal void <.ctor>b__4() { }

	// RVA: 0x7F2A03C Offset: 0x7F2603C VA: 0x7F2A03C
	internal void <.ctor>b__5() { }

	// RVA: 0x7F2A10C Offset: 0x7F2610C VA: 0x7F2A10C
	internal void <.ctor>b__6() { }

	// RVA: 0x7F2A1DC Offset: 0x7F261DC VA: 0x7F2A1DC
	internal void <.ctor>b__7() { }

	// RVA: 0x7F2A324 Offset: 0x7F26324 VA: 0x7F2A324
	internal void <.ctor>b__8() { }

	// RVA: 0x7F2A3FC Offset: 0x7F263FC VA: 0x7F2A3FC
	internal void <.ctor>b__9() { }

	// RVA: 0x7F2A4CC Offset: 0x7F264CC VA: 0x7F2A4CC
	internal void <.ctor>b__10() { }

	// RVA: 0x7F2A61C Offset: 0x7F2661C VA: 0x7F2A61C
	internal void <.ctor>b__11() { }

	// RVA: 0x7F2A710 Offset: 0x7F26710 VA: 0x7F2A710
	internal void <.ctor>b__12() { }
}

// Namespace: Spine
public class Atlas : IEnumerable<AtlasRegion>, IEnumerable // TypeDefIndex: 23922
{
	// Fields
	private readonly List<AtlasPage> pages; // 0x10
	private List<AtlasRegion> regions; // 0x18
	private TextureLoader textureLoader; // 0x20

	// Properties
	public List<AtlasRegion> Regions { get; }
	public List<AtlasPage> Pages { get; }

	// Methods

	// RVA: 0x7F284AC Offset: 0x7F244AC VA: 0x7F284AC Slot: 4
	public IEnumerator<AtlasRegion> GetEnumerator() { }

	// RVA: 0x7F2853C Offset: 0x7F2453C VA: 0x7F2853C Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x7F285CC Offset: 0x7F245CC VA: 0x7F285CC
	public List<AtlasRegion> get_Regions() { }

	// RVA: 0x7F285D4 Offset: 0x7F245D4 VA: 0x7F285D4
	public List<AtlasPage> get_Pages() { }

	// RVA: 0x7F285DC Offset: 0x7F245DC VA: 0x7F285DC
	public void .ctor(List<AtlasPage> pages, List<AtlasRegion> regions) { }

	// RVA: 0x7F28794 Offset: 0x7F24794 VA: 0x7F28794
	public void .ctor(TextReader reader, string imagesDir, TextureLoader textureLoader) { }

	// RVA: 0x7F29758 Offset: 0x7F25758 VA: 0x7F29758
	private static int ReadEntry(string[] entry, string line) { }

	// RVA: 0x7F29908 Offset: 0x7F25908 VA: 0x7F29908
	public void FlipV() { }

	// RVA: 0x7F299C0 Offset: 0x7F259C0 VA: 0x7F299C0
	public AtlasRegion FindRegion(string name) { }

	// RVA: 0x7F29A94 Offset: 0x7F25A94 VA: 0x7F29A94
	public void Dispose() { }
}

// Namespace: Spine
public enum Format // TypeDefIndex: 23923
{
	// Fields
	public int value__; // 0x0
	public const Format Alpha = 0;
	public const Format Intensity = 1;
	public const Format LuminanceAlpha = 2;
	public const Format RGB565 = 3;
	public const Format RGBA4444 = 4;
	public const Format RGB888 = 5;
	public const Format RGBA8888 = 6;
}

// Namespace: Spine
public enum TextureFilter // TypeDefIndex: 23924
{
	// Fields
	public int value__; // 0x0
	public const TextureFilter Nearest = 0;
	public const TextureFilter Linear = 1;
	public const TextureFilter MipMap = 2;
	public const TextureFilter MipMapNearestNearest = 3;
	public const TextureFilter MipMapLinearNearest = 4;
	public const TextureFilter MipMapNearestLinear = 5;
	public const TextureFilter MipMapLinearLinear = 6;
}

// Namespace: Spine
public enum TextureWrap // TypeDefIndex: 23925
{
	// Fields
	public int value__; // 0x0
	public const TextureWrap MirroredRepeat = 0;
	public const TextureWrap ClampToEdge = 1;
	public const TextureWrap Repeat = 2;
}

// Namespace: Spine
public class AtlasPage // TypeDefIndex: 23926
{
	// Fields
	public string name; // 0x10
	public int width; // 0x18
	public int height; // 0x1C
	public Format format; // 0x20
	public TextureFilter minFilter; // 0x24
	public TextureFilter magFilter; // 0x28
	public TextureWrap uWrap; // 0x2C
	public TextureWrap vWrap; // 0x30
	public bool pma; // 0x34
	public object rendererObject; // 0x38

	// Methods

	// RVA: 0x7F2A7A4 Offset: 0x7F267A4 VA: 0x7F2A7A4
	public AtlasPage Clone() { }

	// RVA: 0x7F298E8 Offset: 0x7F258E8 VA: 0x7F298E8
	public void .ctor() { }
}

// Namespace: Spine
public class AtlasRegion : TextureRegion // TypeDefIndex: 23927
{
	// Fields
	public AtlasPage page; // 0x28
	public string name; // 0x30
	public int x; // 0x38
	public int y; // 0x3C
	public float offsetX; // 0x40
	public float offsetY; // 0x44
	public int originalWidth; // 0x48
	public int originalHeight; // 0x4C
	public int degrees; // 0x50
	public bool rotate; // 0x54
	public int index; // 0x58
	public string[] names; // 0x60
	public int[][] values; // 0x68

	// Properties
	public int packedWidth { get; set; }
	public int packedHeight { get; set; }
	public override int OriginalWidth { get; }
	public override int OriginalHeight { get; }

	// Methods

	// RVA: 0x7F2A828 Offset: 0x7F26828 VA: 0x7F2A828
	public int get_packedWidth() { }

	// RVA: 0x7F2A830 Offset: 0x7F26830 VA: 0x7F2A830
	public void set_packedWidth(int value) { }

	// RVA: 0x7F2A838 Offset: 0x7F26838 VA: 0x7F2A838
	public int get_packedHeight() { }

	// RVA: 0x7F2A840 Offset: 0x7F26840 VA: 0x7F2A840
	public void set_packedHeight(int value) { }

	// RVA: 0x7F2A848 Offset: 0x7F26848 VA: 0x7F2A848 Slot: 4
	public override int get_OriginalWidth() { }

	// RVA: 0x7F2A850 Offset: 0x7F26850 VA: 0x7F2A850 Slot: 5
	public override int get_OriginalHeight() { }

	// RVA: 0x7F2A858 Offset: 0x7F26858 VA: 0x7F2A858
	public AtlasRegion Clone() { }

	// RVA: 0x7F29900 Offset: 0x7F25900 VA: 0x7F29900
	public void .ctor() { }
}

// Namespace: Spine
public interface TextureLoader // TypeDefIndex: 23928
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Load(AtlasPage page, string path);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Unload(object texture);
}

// Namespace: Spine
public class AtlasAttachmentLoader : AttachmentLoader // TypeDefIndex: 23929
{
	// Fields
	private Atlas[] atlasArray; // 0x10

	// Methods

	// RVA: 0x7F2A8DC Offset: 0x7F268DC VA: 0x7F2A8DC
	public void .ctor(Atlas[] atlasArray) { }

	// RVA: 0x7F2A96C Offset: 0x7F2696C VA: 0x7F2A96C
	private void LoadSequence(string name, string basePath, Sequence sequence) { }

	// RVA: 0x7F2AC28 Offset: 0x7F26C28 VA: 0x7F2AC28 Slot: 4
	public RegionAttachment NewRegionAttachment(Skin skin, string name, string path, Sequence sequence) { }

	// RVA: 0x7F2ADD0 Offset: 0x7F26DD0 VA: 0x7F2ADD0 Slot: 5
	public MeshAttachment NewMeshAttachment(Skin skin, string name, string path, Sequence sequence) { }

	// RVA: 0x7F2AFBC Offset: 0x7F26FBC VA: 0x7F2AFBC Slot: 6
	public BoundingBoxAttachment NewBoundingBoxAttachment(Skin skin, string name) { }

	// RVA: 0x7F2B078 Offset: 0x7F27078 VA: 0x7F2B078 Slot: 7
	public PathAttachment NewPathAttachment(Skin skin, string name) { }

	// RVA: 0x7F2B134 Offset: 0x7F27134 VA: 0x7F2B134 Slot: 8
	public PointAttachment NewPointAttachment(Skin skin, string name) { }

	// RVA: 0x7F2B190 Offset: 0x7F27190 VA: 0x7F2B190 Slot: 9
	public ClippingAttachment NewClippingAttachment(Skin skin, string name) { }

	// RVA: 0x7F2ABBC Offset: 0x7F26BBC VA: 0x7F2ABBC
	public AtlasRegion FindRegion(string name) { }
}

// Namespace: Spine
public abstract class Attachment // TypeDefIndex: 23930
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x10

	// Properties
	public string Name { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7F2B24C Offset: 0x7F2724C VA: 0x7F2B24C
	public string get_Name() { }

	// RVA: 0x7F2B254 Offset: 0x7F27254 VA: 0x7F2B254
	protected void .ctor(string name) { }

	// RVA: 0x7F2B2E4 Offset: 0x7F272E4 VA: 0x7F2B2E4
	protected void .ctor(Attachment other) { }

	// RVA: 0x7F2B31C Offset: 0x7F2731C VA: 0x7F2B31C Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Attachment Copy();
}

// Namespace: Spine
public interface AttachmentLoader // TypeDefIndex: 23931
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract RegionAttachment NewRegionAttachment(Skin skin, string name, string path, Sequence sequence);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract MeshAttachment NewMeshAttachment(Skin skin, string name, string path, Sequence sequence);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract BoundingBoxAttachment NewBoundingBoxAttachment(Skin skin, string name);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract PathAttachment NewPathAttachment(Skin skin, string name);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract PointAttachment NewPointAttachment(Skin skin, string name);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract ClippingAttachment NewClippingAttachment(Skin skin, string name);
}

// Namespace: Spine
public enum AttachmentType // TypeDefIndex: 23932
{
	// Fields
	public int value__; // 0x0
	public const AttachmentType Region = 0;
	public const AttachmentType Boundingbox = 1;
	public const AttachmentType Mesh = 2;
	public const AttachmentType Linkedmesh = 3;
	public const AttachmentType Path = 4;
	public const AttachmentType Point = 5;
	public const AttachmentType Clipping = 6;
	public const AttachmentType Sequence = 7;
}

// Namespace: Spine
public class BoundingBoxAttachment : VertexAttachment // TypeDefIndex: 23933
{
	// Methods

	// RVA: 0x7F2B014 Offset: 0x7F27014 VA: 0x7F2B014
	public void .ctor(string name) { }

	// RVA: 0x7F2B460 Offset: 0x7F27460 VA: 0x7F2B460
	protected void .ctor(BoundingBoxAttachment other) { }

	// RVA: 0x7F2B6F8 Offset: 0x7F276F8 VA: 0x7F2B6F8 Slot: 4
	public override Attachment Copy() { }
}

// Namespace: Spine
public class ClippingAttachment : VertexAttachment // TypeDefIndex: 23934
{
	// Fields
	internal SlotData endSlot; // 0x40

	// Properties
	public SlotData EndSlot { get; set; }

	// Methods

	// RVA: 0x7F2B750 Offset: 0x7F27750 VA: 0x7F2B750
	public SlotData get_EndSlot() { }

	// RVA: 0x7F2B758 Offset: 0x7F27758 VA: 0x7F2B758
	public void set_EndSlot(SlotData value) { }

	// RVA: 0x7F2B1E8 Offset: 0x7F271E8 VA: 0x7F2B1E8
	public void .ctor(string name) { }

	// RVA: 0x7F2B760 Offset: 0x7F27760 VA: 0x7F2B760
	protected void .ctor(ClippingAttachment other) { }

	// RVA: 0x7F2B7DC Offset: 0x7F277DC VA: 0x7F2B7DC Slot: 4
	public override Attachment Copy() { }
}

// Namespace: Spine
public interface IHasTextureRegion // TypeDefIndex: 23935
{
	// Properties
	public abstract string Path { get; set; }
	public abstract TextureRegion Region { get; set; }
	public abstract float R { get; set; }
	public abstract float G { get; set; }
	public abstract float B { get; set; }
	public abstract float A { get; set; }
	public abstract Sequence Sequence { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Path();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Path(string value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract TextureRegion get_Region();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Region(TextureRegion value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void UpdateRegion();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract float get_R();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void set_R(float value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract float get_G();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void set_G(float value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract float get_B();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void set_B(float value);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract float get_A();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void set_A(float value);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract Sequence get_Sequence();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void set_Sequence(Sequence value);
}

// Namespace: Spine
public class MeshAttachment : VertexAttachment, IHasTextureRegion // TypeDefIndex: 23936
{
	// Fields
	internal TextureRegion region; // 0x40
	internal string path; // 0x48
	internal float[] regionUVs; // 0x50
	internal float[] uvs; // 0x58
	internal int[] triangles; // 0x60
	internal float r; // 0x68
	internal float g; // 0x6C
	internal float b; // 0x70
	internal float a; // 0x74
	internal int hullLength; // 0x78
	private MeshAttachment parentMesh; // 0x80
	private Sequence sequence; // 0x88
	[CompilerGenerated]
	private int[] <Edges>k__BackingField; // 0x90
	[CompilerGenerated]
	private float <Width>k__BackingField; // 0x98
	[CompilerGenerated]
	private float <Height>k__BackingField; // 0x9C

	// Properties
	public TextureRegion Region { get; set; }
	public int HullLength { get; set; }
	public float[] RegionUVs { get; set; }
	public float[] UVs { get; set; }
	public int[] Triangles { get; set; }
	public float R { get; set; }
	public float G { get; set; }
	public float B { get; set; }
	public float A { get; set; }
	public string Path { get; set; }
	public Sequence Sequence { get; set; }
	public MeshAttachment ParentMesh { get; set; }
	public int[] Edges { get; set; }
	public float Width { get; set; }
	public float Height { get; set; }

	// Methods

	// RVA: 0x7F2B834 Offset: 0x7F27834 VA: 0x7F2B834 Slot: 8
	public TextureRegion get_Region() { }

	// RVA: 0x7F2AF44 Offset: 0x7F26F44 VA: 0x7F2AF44 Slot: 9
	public void set_Region(TextureRegion value) { }

	// RVA: 0x7F2B83C Offset: 0x7F2783C VA: 0x7F2B83C
	public int get_HullLength() { }

	// RVA: 0x7F2B844 Offset: 0x7F27844 VA: 0x7F2B844
	public void set_HullLength(int value) { }

	// RVA: 0x7F2B84C Offset: 0x7F2784C VA: 0x7F2B84C
	public float[] get_RegionUVs() { }

	// RVA: 0x7F2B854 Offset: 0x7F27854 VA: 0x7F2B854
	public void set_RegionUVs(float[] value) { }

	// RVA: 0x7F2B85C Offset: 0x7F2785C VA: 0x7F2B85C
	public float[] get_UVs() { }

	// RVA: 0x7F2B864 Offset: 0x7F27864 VA: 0x7F2B864
	public void set_UVs(float[] value) { }

	// RVA: 0x7F2B86C Offset: 0x7F2786C VA: 0x7F2B86C
	public int[] get_Triangles() { }

	// RVA: 0x7F2B874 Offset: 0x7F27874 VA: 0x7F2B874
	public void set_Triangles(int[] value) { }

	// RVA: 0x7F2B87C Offset: 0x7F2787C VA: 0x7F2B87C Slot: 11
	public float get_R() { }

	// RVA: 0x7F2B884 Offset: 0x7F27884 VA: 0x7F2B884 Slot: 12
	public void set_R(float value) { }

	// RVA: 0x7F2B88C Offset: 0x7F2788C VA: 0x7F2B88C Slot: 13
	public float get_G() { }

	// RVA: 0x7F2B894 Offset: 0x7F27894 VA: 0x7F2B894 Slot: 14
	public void set_G(float value) { }

	// RVA: 0x7F2B89C Offset: 0x7F2789C VA: 0x7F2B89C Slot: 15
	public float get_B() { }

	// RVA: 0x7F2B8A4 Offset: 0x7F278A4 VA: 0x7F2B8A4 Slot: 16
	public void set_B(float value) { }

	// RVA: 0x7F2B8AC Offset: 0x7F278AC VA: 0x7F2B8AC Slot: 17
	public float get_A() { }

	// RVA: 0x7F2B8B4 Offset: 0x7F278B4 VA: 0x7F2B8B4 Slot: 18
	public void set_A(float value) { }

	// RVA: 0x7F2B8BC Offset: 0x7F278BC VA: 0x7F2B8BC Slot: 6
	public string get_Path() { }

	// RVA: 0x7F2B8C4 Offset: 0x7F278C4 VA: 0x7F2B8C4 Slot: 7
	public void set_Path(string value) { }

	// RVA: 0x7F2B8CC Offset: 0x7F278CC VA: 0x7F2B8CC Slot: 19
	public Sequence get_Sequence() { }

	// RVA: 0x7F2B8D4 Offset: 0x7F278D4 VA: 0x7F2B8D4 Slot: 20
	public void set_Sequence(Sequence value) { }

	// RVA: 0x7F2B8DC Offset: 0x7F278DC VA: 0x7F2B8DC
	public MeshAttachment get_ParentMesh() { }

	// RVA: 0x7F2B8E4 Offset: 0x7F278E4 VA: 0x7F2B8E4
	public void set_ParentMesh(MeshAttachment value) { }

	[CompilerGenerated]
	// RVA: 0x7F2B974 Offset: 0x7F27974 VA: 0x7F2B974
	public int[] get_Edges() { }

	[CompilerGenerated]
	// RVA: 0x7F2B97C Offset: 0x7F2797C VA: 0x7F2B97C
	public void set_Edges(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x7F2B984 Offset: 0x7F27984 VA: 0x7F2B984
	public float get_Width() { }

	[CompilerGenerated]
	// RVA: 0x7F2B98C Offset: 0x7F2798C VA: 0x7F2B98C
	public void set_Width(float value) { }

	[CompilerGenerated]
	// RVA: 0x7F2B994 Offset: 0x7F27994 VA: 0x7F2B994
	public float get_Height() { }

	[CompilerGenerated]
	// RVA: 0x7F2B99C Offset: 0x7F2799C VA: 0x7F2B99C
	public void set_Height(float value) { }

	// RVA: 0x7F2AED8 Offset: 0x7F26ED8 VA: 0x7F2AED8
	public void .ctor(string name) { }

	// RVA: 0x7F2B9A4 Offset: 0x7F279A4 VA: 0x7F2B9A4
	protected void .ctor(MeshAttachment other) { }

	// RVA: 0x7F2BDE0 Offset: 0x7F27DE0 VA: 0x7F2BDE0 Slot: 10
	public void UpdateRegion() { }

	// RVA: 0x7F2C1F4 Offset: 0x7F281F4 VA: 0x7F2C1F4 Slot: 5
	public override void ComputeWorldVertices(Slot slot, int start, int count, float[] worldVertices, int offset, int stride = 2) { }

	// RVA: 0x7F2C864 Offset: 0x7F28864 VA: 0x7F2C864
	public MeshAttachment NewLinkedMesh() { }

	// RVA: 0x7F2C928 Offset: 0x7F28928 VA: 0x7F2C928 Slot: 4
	public override Attachment Copy() { }
}

// Namespace: Spine
public class PathAttachment : VertexAttachment // TypeDefIndex: 23937
{
	// Fields
	internal float[] lengths; // 0x40
	internal bool closed; // 0x48
	internal bool constantSpeed; // 0x49

	// Properties
	public float[] Lengths { get; set; }
	public bool Closed { get; set; }
	public bool ConstantSpeed { get; set; }

	// Methods

	// RVA: 0x7F2C998 Offset: 0x7F28998 VA: 0x7F2C998
	public float[] get_Lengths() { }

	// RVA: 0x7F2C9A0 Offset: 0x7F289A0 VA: 0x7F2C9A0
	public void set_Lengths(float[] value) { }

	// RVA: 0x7F2C9A8 Offset: 0x7F289A8 VA: 0x7F2C9A8
	public bool get_Closed() { }

	// RVA: 0x7F2C9B0 Offset: 0x7F289B0 VA: 0x7F2C9B0
	public void set_Closed(bool value) { }

	// RVA: 0x7F2C9BC Offset: 0x7F289BC VA: 0x7F2C9BC
	public bool get_ConstantSpeed() { }

	// RVA: 0x7F2C9C4 Offset: 0x7F289C4 VA: 0x7F2C9C4
	public void set_ConstantSpeed(bool value) { }

	// RVA: 0x7F2B0D0 Offset: 0x7F270D0 VA: 0x7F2B0D0
	public void .ctor(string name) { }

	// RVA: 0x7F2C9D0 Offset: 0x7F289D0 VA: 0x7F2C9D0
	protected void .ctor(PathAttachment other) { }

	// RVA: 0x7F2CAAC Offset: 0x7F28AAC VA: 0x7F2CAAC Slot: 4
	public override Attachment Copy() { }
}

// Namespace: Spine
public class PointAttachment : Attachment // TypeDefIndex: 23938
{
	// Fields
	internal float x; // 0x18
	internal float y; // 0x1C
	internal float rotation; // 0x20

	// Properties
	public float X { get; set; }
	public float Y { get; set; }
	public float Rotation { get; set; }

	// Methods

	// RVA: 0x7F2CB04 Offset: 0x7F28B04 VA: 0x7F2CB04
	public float get_X() { }

	// RVA: 0x7F2CB0C Offset: 0x7F28B0C VA: 0x7F2CB0C
	public void set_X(float value) { }

	// RVA: 0x7F2CB14 Offset: 0x7F28B14 VA: 0x7F2CB14
	public float get_Y() { }

	// RVA: 0x7F2CB1C Offset: 0x7F28B1C VA: 0x7F2CB1C
	public void set_Y(float value) { }

	// RVA: 0x7F2CB24 Offset: 0x7F28B24 VA: 0x7F2CB24
	public float get_Rotation() { }

	// RVA: 0x7F2CB2C Offset: 0x7F28B2C VA: 0x7F2CB2C
	public void set_Rotation(float value) { }

	// RVA: 0x7F2B18C Offset: 0x7F2718C VA: 0x7F2B18C
	public void .ctor(string name) { }

	// RVA: 0x7F2CB34 Offset: 0x7F28B34 VA: 0x7F2CB34
	protected void .ctor(PointAttachment other) { }

	// RVA: 0x7F2CB6C Offset: 0x7F28B6C VA: 0x7F2CB6C
	public void ComputeWorldPosition(Bone bone, out float ox, out float oy) { }

	// RVA: 0x7F2CBF8 Offset: 0x7F28BF8 VA: 0x7F2CBF8
	public float ComputeWorldRotation(Bone bone) { }

	// RVA: 0x7F2CDFC Offset: 0x7F28DFC VA: 0x7F2CDFC Slot: 4
	public override Attachment Copy() { }
}

// Namespace: Spine
public class RegionAttachment : Attachment, IHasTextureRegion // TypeDefIndex: 23939
{
	// Fields
	public const int BLX = 0;
	public const int BLY = 1;
	public const int ULX = 2;
	public const int ULY = 3;
	public const int URX = 4;
	public const int URY = 5;
	public const int BRX = 6;
	public const int BRY = 7;
	internal TextureRegion region; // 0x18
	internal float x; // 0x20
	internal float y; // 0x24
	internal float rotation; // 0x28
	internal float scaleX; // 0x2C
	internal float scaleY; // 0x30
	internal float width; // 0x34
	internal float height; // 0x38
	internal float[] offset; // 0x40
	internal float[] uvs; // 0x48
	internal float r; // 0x50
	internal float g; // 0x54
	internal float b; // 0x58
	internal float a; // 0x5C
	internal Sequence sequence; // 0x60
	[CompilerGenerated]
	private string <Path>k__BackingField; // 0x68

	// Properties
	public float X { get; set; }
	public float Y { get; set; }
	public float Rotation { get; set; }
	public float ScaleX { get; set; }
	public float ScaleY { get; set; }
	public float Width { get; set; }
	public float Height { get; set; }
	public float R { get; set; }
	public float G { get; set; }
	public float B { get; set; }
	public float A { get; set; }
	public string Path { get; set; }
	public TextureRegion Region { get; set; }
	public float[] Offset { get; }
	public float[] UVs { get; }
	public Sequence Sequence { get; set; }

	// Methods

	// RVA: 0x7F2CE54 Offset: 0x7F28E54 VA: 0x7F2CE54
	public float get_X() { }

	// RVA: 0x7F2CE5C Offset: 0x7F28E5C VA: 0x7F2CE5C
	public void set_X(float value) { }

	// RVA: 0x7F2CE64 Offset: 0x7F28E64 VA: 0x7F2CE64
	public float get_Y() { }

	// RVA: 0x7F2CE6C Offset: 0x7F28E6C VA: 0x7F2CE6C
	public void set_Y(float value) { }

	// RVA: 0x7F2CE74 Offset: 0x7F28E74 VA: 0x7F2CE74
	public float get_Rotation() { }

	// RVA: 0x7F2CE7C Offset: 0x7F28E7C VA: 0x7F2CE7C
	public void set_Rotation(float value) { }

	// RVA: 0x7F2CE84 Offset: 0x7F28E84 VA: 0x7F2CE84
	public float get_ScaleX() { }

	// RVA: 0x7F2CE8C Offset: 0x7F28E8C VA: 0x7F2CE8C
	public void set_ScaleX(float value) { }

	// RVA: 0x7F2CE94 Offset: 0x7F28E94 VA: 0x7F2CE94
	public float get_ScaleY() { }

	// RVA: 0x7F2CE9C Offset: 0x7F28E9C VA: 0x7F2CE9C
	public void set_ScaleY(float value) { }

	// RVA: 0x7F2CEA4 Offset: 0x7F28EA4 VA: 0x7F2CEA4
	public float get_Width() { }

	// RVA: 0x7F2CEAC Offset: 0x7F28EAC VA: 0x7F2CEAC
	public void set_Width(float value) { }

	// RVA: 0x7F2CEB4 Offset: 0x7F28EB4 VA: 0x7F2CEB4
	public float get_Height() { }

	// RVA: 0x7F2CEBC Offset: 0x7F28EBC VA: 0x7F2CEBC
	public void set_Height(float value) { }

	// RVA: 0x7F2CEC4 Offset: 0x7F28EC4 VA: 0x7F2CEC4 Slot: 10
	public float get_R() { }

	// RVA: 0x7F2CECC Offset: 0x7F28ECC VA: 0x7F2CECC Slot: 11
	public void set_R(float value) { }

	// RVA: 0x7F2CED4 Offset: 0x7F28ED4 VA: 0x7F2CED4 Slot: 12
	public float get_G() { }

	// RVA: 0x7F2CEDC Offset: 0x7F28EDC VA: 0x7F2CEDC Slot: 13
	public void set_G(float value) { }

	// RVA: 0x7F2CEE4 Offset: 0x7F28EE4 VA: 0x7F2CEE4 Slot: 14
	public float get_B() { }

	// RVA: 0x7F2CEEC Offset: 0x7F28EEC VA: 0x7F2CEEC Slot: 15
	public void set_B(float value) { }

	// RVA: 0x7F2CEF4 Offset: 0x7F28EF4 VA: 0x7F2CEF4 Slot: 16
	public float get_A() { }

	// RVA: 0x7F2CEFC Offset: 0x7F28EFC VA: 0x7F2CEFC Slot: 17
	public void set_A(float value) { }

	[CompilerGenerated]
	// RVA: 0x7F2CF04 Offset: 0x7F28F04 VA: 0x7F2CF04 Slot: 5
	public string get_Path() { }

	[CompilerGenerated]
	// RVA: 0x7F2CF0C Offset: 0x7F28F0C VA: 0x7F2CF0C Slot: 6
	public void set_Path(string value) { }

	// RVA: 0x7F2CF14 Offset: 0x7F28F14 VA: 0x7F2CF14 Slot: 7
	public TextureRegion get_Region() { }

	// RVA: 0x7F2CF1C Offset: 0x7F28F1C VA: 0x7F2CF1C Slot: 8
	public void set_Region(TextureRegion value) { }

	// RVA: 0x7F2CF24 Offset: 0x7F28F24 VA: 0x7F2CF24
	public float[] get_Offset() { }

	// RVA: 0x7F2CF2C Offset: 0x7F28F2C VA: 0x7F2CF2C
	public float[] get_UVs() { }

	// RVA: 0x7F2CF34 Offset: 0x7F28F34 VA: 0x7F2CF34 Slot: 18
	public Sequence get_Sequence() { }

	// RVA: 0x7F2CF3C Offset: 0x7F28F3C VA: 0x7F2CF3C Slot: 19
	public void set_Sequence(Sequence value) { }

	// RVA: 0x7F2AD34 Offset: 0x7F26D34 VA: 0x7F2AD34
	public void .ctor(string name) { }

	// RVA: 0x7F2CF44 Offset: 0x7F28F44 VA: 0x7F2CF44
	public void .ctor(RegionAttachment other) { }

	// RVA: 0x7F2D0AC Offset: 0x7F290AC VA: 0x7F2D0AC Slot: 9
	public void UpdateRegion() { }

	// RVA: 0x7F2D460 Offset: 0x7F29460 VA: 0x7F2D460
	public void ComputeWorldVertices(Slot slot, float[] worldVertices, int offset, int stride = 2) { }

	// RVA: 0x7F2D614 Offset: 0x7F29614 VA: 0x7F2D614 Slot: 4
	public override Attachment Copy() { }
}

// Namespace: Spine
public class Sequence // TypeDefIndex: 23940
{
	// Fields
	private static int nextID; // 0x0
	private static readonly object nextIdLock; // 0x8
	internal readonly int id; // 0x10
	internal readonly TextureRegion[] regions; // 0x18
	internal int start; // 0x20
	internal int digits; // 0x24
	internal int setupIndex; // 0x28

	// Properties
	public int Start { get; set; }
	public int Digits { get; set; }
	public int SetupIndex { get; set; }
	public TextureRegion[] Regions { get; }
	public int Id { get; }

	// Methods

	// RVA: 0x7F2D66C Offset: 0x7F2966C VA: 0x7F2D66C
	public int get_Start() { }

	// RVA: 0x7F2D674 Offset: 0x7F29674 VA: 0x7F2D674
	public void set_Start(int value) { }

	// RVA: 0x7F2D67C Offset: 0x7F2967C VA: 0x7F2D67C
	public int get_Digits() { }

	// RVA: 0x7F2D684 Offset: 0x7F29684 VA: 0x7F2D684
	public void set_Digits(int value) { }

	// RVA: 0x7F2D68C Offset: 0x7F2968C VA: 0x7F2D68C
	public int get_SetupIndex() { }

	// RVA: 0x7F2D694 Offset: 0x7F29694 VA: 0x7F2D694
	public void set_SetupIndex(int value) { }

	// RVA: 0x7F2D69C Offset: 0x7F2969C VA: 0x7F2D69C
	public TextureRegion[] get_Regions() { }

	// RVA: 0x7F2D6A4 Offset: 0x7F296A4 VA: 0x7F2D6A4
	public int get_Id() { }

	// RVA: 0x7F2D6AC Offset: 0x7F296AC VA: 0x7F2D6AC
	public void .ctor(int count) { }

	// RVA: 0x7F2BC38 Offset: 0x7F27C38 VA: 0x7F2BC38
	public void .ctor(Sequence other) { }

	// RVA: 0x7F2C264 Offset: 0x7F28264 VA: 0x7F2C264
	public void Apply(Slot slot, IHasTextureRegion attachment) { }

	// RVA: 0x7F2AAB4 Offset: 0x7F26AB4 VA: 0x7F2AAB4
	public string GetPath(string basePath, int index) { }

	// RVA: 0x7F2D810 Offset: 0x7F29810 VA: 0x7F2D810
	private static void .cctor() { }
}

// Namespace: Spine
public enum SequenceMode // TypeDefIndex: 23941
{
	// Fields
	public int value__; // 0x0
	public const SequenceMode Hold = 0;
	public const SequenceMode Once = 1;
	public const SequenceMode Loop = 2;
	public const SequenceMode Pingpong = 3;
	public const SequenceMode OnceReverse = 4;
	public const SequenceMode LoopReverse = 5;
	public const SequenceMode PingpongReverse = 6;
}

// Namespace: Spine
public abstract class VertexAttachment : Attachment // TypeDefIndex: 23942
{
	// Fields
	private static int nextID; // 0x0
	private static readonly object nextIdLock; // 0x8
	internal readonly int id; // 0x18
	internal VertexAttachment timelineAttachment; // 0x20
	internal int[] bones; // 0x28
	internal float[] vertices; // 0x30
	internal int worldVerticesLength; // 0x38

	// Properties
	public int Id { get; }
	public int[] Bones { get; set; }
	public float[] Vertices { get; set; }
	public int WorldVerticesLength { get; set; }
	public VertexAttachment TimelineAttachment { get; set; }

	// Methods

	// RVA: 0x7F2D890 Offset: 0x7F29890 VA: 0x7F2D890
	public int get_Id() { }

	// RVA: 0x7F2D898 Offset: 0x7F29898 VA: 0x7F2D898
	public int[] get_Bones() { }

	// RVA: 0x7F2D8A0 Offset: 0x7F298A0 VA: 0x7F2D8A0
	public void set_Bones(int[] value) { }

	// RVA: 0x7F2D8A8 Offset: 0x7F298A8 VA: 0x7F2D8A8
	public float[] get_Vertices() { }

	// RVA: 0x7F2D8B0 Offset: 0x7F298B0 VA: 0x7F2D8B0
	public void set_Vertices(float[] value) { }

	// RVA: 0x7F2D8B8 Offset: 0x7F298B8 VA: 0x7F2D8B8
	public int get_WorldVerticesLength() { }

	// RVA: 0x7F2D8C0 Offset: 0x7F298C0 VA: 0x7F2D8C0
	public void set_WorldVerticesLength(int value) { }

	// RVA: 0x7F2D8C8 Offset: 0x7F298C8 VA: 0x7F2D8C8
	public VertexAttachment get_TimelineAttachment() { }

	// RVA: 0x7F2D8D0 Offset: 0x7F298D0 VA: 0x7F2D8D0
	public void set_TimelineAttachment(VertexAttachment value) { }

	// RVA: 0x7F2B324 Offset: 0x7F27324 VA: 0x7F2B324
	public void .ctor(string name) { }

	// RVA: 0x7F2B4C4 Offset: 0x7F274C4 VA: 0x7F2B4C4
	public void .ctor(VertexAttachment other) { }

	// RVA: 0x7F2D8D8 Offset: 0x7F298D8 VA: 0x7F2D8D8
	public void ComputeWorldVertices(Slot slot, float[] worldVertices) { }

	// RVA: 0x7F2C428 Offset: 0x7F28428 VA: 0x7F2C428 Slot: 5
	public virtual void ComputeWorldVertices(Slot slot, int start, int count, float[] worldVertices, int offset, int stride = 2) { }

	// RVA: 0x7F2D8F8 Offset: 0x7F298F8 VA: 0x7F2D8F8
	private static void .cctor() { }
}

// Namespace: Spine
public enum BlendMode // TypeDefIndex: 23943
{
	// Fields
	public int value__; // 0x0
	public const BlendMode Normal = 0;
	public const BlendMode Additive = 1;
	public const BlendMode Multiply = 2;
	public const BlendMode Screen = 3;
}

// Namespace: Spine
public class Bone : IUpdatable // TypeDefIndex: 23944
{
	// Fields
	public static bool yDown; // 0x0
	internal BoneData data; // 0x10
	internal Skeleton skeleton; // 0x18
	internal Bone parent; // 0x20
	internal ExposedList<Bone> children; // 0x28
	internal float x; // 0x30
	internal float y; // 0x34
	internal float rotation; // 0x38
	internal float scaleX; // 0x3C
	internal float scaleY; // 0x40
	internal float shearX; // 0x44
	internal float shearY; // 0x48
	internal float ax; // 0x4C
	internal float ay; // 0x50
	internal float arotation; // 0x54
	internal float ascaleX; // 0x58
	internal float ascaleY; // 0x5C
	internal float ashearX; // 0x60
	internal float ashearY; // 0x64
	internal float a; // 0x68
	internal float b; // 0x6C
	internal float worldX; // 0x70
	internal float c; // 0x74
	internal float d; // 0x78
	internal float worldY; // 0x7C
	internal bool sorted; // 0x80
	internal bool active; // 0x81

	// Properties
	public BoneData Data { get; }
	public Skeleton Skeleton { get; }
	public Bone Parent { get; }
	public ExposedList<Bone> Children { get; }
	public bool Active { get; }
	public float X { get; set; }
	public float Y { get; set; }
	public float Rotation { get; set; }
	public float ScaleX { get; set; }
	public float ScaleY { get; set; }
	public float ShearX { get; set; }
	public float ShearY { get; set; }
	public float AppliedRotation { get; set; }
	public float AX { get; set; }
	public float AY { get; set; }
	public float AScaleX { get; set; }
	public float AScaleY { get; set; }
	public float AShearX { get; set; }
	public float AShearY { get; set; }
	public float A { get; set; }
	public float B { get; set; }
	public float C { get; set; }
	public float D { get; set; }
	public float WorldX { get; set; }
	public float WorldY { get; set; }
	public float WorldRotationX { get; }
	public float WorldRotationY { get; }
	public float WorldScaleX { get; }
	public float WorldScaleY { get; }
	public float WorldToLocalRotationX { get; }
	public float WorldToLocalRotationY { get; }

	// Methods

	// RVA: 0x7F2D978 Offset: 0x7F29978 VA: 0x7F2D978
	public BoneData get_Data() { }

	// RVA: 0x7F2D980 Offset: 0x7F29980 VA: 0x7F2D980
	public Skeleton get_Skeleton() { }

	// RVA: 0x7F2D988 Offset: 0x7F29988 VA: 0x7F2D988
	public Bone get_Parent() { }

	// RVA: 0x7F2D990 Offset: 0x7F29990 VA: 0x7F2D990
	public ExposedList<Bone> get_Children() { }

	// RVA: 0x7F2D998 Offset: 0x7F29998 VA: 0x7F2D998 Slot: 5
	public bool get_Active() { }

	// RVA: 0x7F2D9A0 Offset: 0x7F299A0 VA: 0x7F2D9A0
	public float get_X() { }

	// RVA: 0x7F2D9A8 Offset: 0x7F299A8 VA: 0x7F2D9A8
	public void set_X(float value) { }

	// RVA: 0x7F2D9B0 Offset: 0x7F299B0 VA: 0x7F2D9B0
	public float get_Y() { }

	// RVA: 0x7F2D9B8 Offset: 0x7F299B8 VA: 0x7F2D9B8
	public void set_Y(float value) { }

	// RVA: 0x7F2D9C0 Offset: 0x7F299C0 VA: 0x7F2D9C0
	public float get_Rotation() { }

	// RVA: 0x7F2D9C8 Offset: 0x7F299C8 VA: 0x7F2D9C8
	public void set_Rotation(float value) { }

	// RVA: 0x7F2D9D0 Offset: 0x7F299D0 VA: 0x7F2D9D0
	public float get_ScaleX() { }

	// RVA: 0x7F2D9D8 Offset: 0x7F299D8 VA: 0x7F2D9D8
	public void set_ScaleX(float value) { }

	// RVA: 0x7F2D9E0 Offset: 0x7F299E0 VA: 0x7F2D9E0
	public float get_ScaleY() { }

	// RVA: 0x7F2D9E8 Offset: 0x7F299E8 VA: 0x7F2D9E8
	public void set_ScaleY(float value) { }

	// RVA: 0x7F2D9F0 Offset: 0x7F299F0 VA: 0x7F2D9F0
	public float get_ShearX() { }

	// RVA: 0x7F2D9F8 Offset: 0x7F299F8 VA: 0x7F2D9F8
	public void set_ShearX(float value) { }

	// RVA: 0x7F2DA00 Offset: 0x7F29A00 VA: 0x7F2DA00
	public float get_ShearY() { }

	// RVA: 0x7F2DA08 Offset: 0x7F29A08 VA: 0x7F2DA08
	public void set_ShearY(float value) { }

	// RVA: 0x7F2DA10 Offset: 0x7F29A10 VA: 0x7F2DA10
	public float get_AppliedRotation() { }

	// RVA: 0x7F2DA18 Offset: 0x7F29A18 VA: 0x7F2DA18
	public void set_AppliedRotation(float value) { }

	// RVA: 0x7F2DA20 Offset: 0x7F29A20 VA: 0x7F2DA20
	public float get_AX() { }

	// RVA: 0x7F2DA28 Offset: 0x7F29A28 VA: 0x7F2DA28
	public void set_AX(float value) { }

	// RVA: 0x7F2DA30 Offset: 0x7F29A30 VA: 0x7F2DA30
	public float get_AY() { }

	// RVA: 0x7F2DA38 Offset: 0x7F29A38 VA: 0x7F2DA38
	public void set_AY(float value) { }

	// RVA: 0x7F2DA40 Offset: 0x7F29A40 VA: 0x7F2DA40
	public float get_AScaleX() { }

	// RVA: 0x7F2DA48 Offset: 0x7F29A48 VA: 0x7F2DA48
	public void set_AScaleX(float value) { }

	// RVA: 0x7F2DA50 Offset: 0x7F29A50 VA: 0x7F2DA50
	public float get_AScaleY() { }

	// RVA: 0x7F2DA58 Offset: 0x7F29A58 VA: 0x7F2DA58
	public void set_AScaleY(float value) { }

	// RVA: 0x7F2DA60 Offset: 0x7F29A60 VA: 0x7F2DA60
	public float get_AShearX() { }

	// RVA: 0x7F2DA68 Offset: 0x7F29A68 VA: 0x7F2DA68
	public void set_AShearX(float value) { }

	// RVA: 0x7F2DA70 Offset: 0x7F29A70 VA: 0x7F2DA70
	public float get_AShearY() { }

	// RVA: 0x7F2DA78 Offset: 0x7F29A78 VA: 0x7F2DA78
	public void set_AShearY(float value) { }

	// RVA: 0x7F2DA80 Offset: 0x7F29A80 VA: 0x7F2DA80
	public float get_A() { }

	// RVA: 0x7F2DA88 Offset: 0x7F29A88 VA: 0x7F2DA88
	public void set_A(float value) { }

	// RVA: 0x7F2DA90 Offset: 0x7F29A90 VA: 0x7F2DA90
	public float get_B() { }

	// RVA: 0x7F2DA98 Offset: 0x7F29A98 VA: 0x7F2DA98
	public void set_B(float value) { }

	// RVA: 0x7F2DAA0 Offset: 0x7F29AA0 VA: 0x7F2DAA0
	public float get_C() { }

	// RVA: 0x7F2DAA8 Offset: 0x7F29AA8 VA: 0x7F2DAA8
	public void set_C(float value) { }

	// RVA: 0x7F2DAB0 Offset: 0x7F29AB0 VA: 0x7F2DAB0
	public float get_D() { }

	// RVA: 0x7F2DAB8 Offset: 0x7F29AB8 VA: 0x7F2DAB8
	public void set_D(float value) { }

	// RVA: 0x7F2DAC0 Offset: 0x7F29AC0 VA: 0x7F2DAC0
	public float get_WorldX() { }

	// RVA: 0x7F2DAC8 Offset: 0x7F29AC8 VA: 0x7F2DAC8
	public void set_WorldX(float value) { }

	// RVA: 0x7F2DAD0 Offset: 0x7F29AD0 VA: 0x7F2DAD0
	public float get_WorldY() { }

	// RVA: 0x7F2DAD8 Offset: 0x7F29AD8 VA: 0x7F2DAD8
	public void set_WorldY(float value) { }

	// RVA: 0x7F2DAE0 Offset: 0x7F29AE0 VA: 0x7F2DAE0
	public float get_WorldRotationX() { }

	// RVA: 0x7F2DB58 Offset: 0x7F29B58 VA: 0x7F2DB58
	public float get_WorldRotationY() { }

	// RVA: 0x7F2DBD0 Offset: 0x7F29BD0 VA: 0x7F2DBD0
	public float get_WorldScaleX() { }

	// RVA: 0x7F2DC40 Offset: 0x7F29C40 VA: 0x7F2DC40
	public float get_WorldScaleY() { }

	// RVA: 0x7F2DCB0 Offset: 0x7F29CB0 VA: 0x7F2DCB0
	public void .ctor(BoneData data, Skeleton skeleton, Bone parent) { }

	// RVA: 0x7F2DE48 Offset: 0x7F29E48 VA: 0x7F2DE48
	public void .ctor(Bone bone, Skeleton skeleton, Bone parent) { }

	// RVA: 0x7F2DFC4 Offset: 0x7F29FC4 VA: 0x7F2DFC4 Slot: 4
	public void Update() { }

	// RVA: 0x7F2E7EC Offset: 0x7F2A7EC VA: 0x7F2E7EC
	public void UpdateWorldTransform() { }

	// RVA: 0x7F2DFD8 Offset: 0x7F29FD8 VA: 0x7F2DFD8
	public void UpdateWorldTransform(float x, float y, float rotation, float scaleX, float scaleY, float shearX, float shearY) { }

	// RVA: 0x7F2DE18 Offset: 0x7F29E18 VA: 0x7F2DE18
	public void SetToSetupPose() { }

	// RVA: 0x7F2E924 Offset: 0x7F2A924 VA: 0x7F2E924
	public void UpdateAppliedTransform() { }

	// RVA: 0x7F2EC24 Offset: 0x7F2AC24 VA: 0x7F2EC24
	public void WorldToLocal(float worldX, float worldY, out float localX, out float localY) { }

	// RVA: 0x7F2CBBC Offset: 0x7F28BBC VA: 0x7F2CBBC
	public void LocalToWorld(float localX, float localY, out float worldX, out float worldY) { }

	// RVA: 0x7F2EC70 Offset: 0x7F2AC70 VA: 0x7F2EC70
	public float get_WorldToLocalRotationX() { }

	// RVA: 0x7F2ED20 Offset: 0x7F2AD20 VA: 0x7F2ED20
	public float get_WorldToLocalRotationY() { }

	// RVA: 0x7F2EDD0 Offset: 0x7F2ADD0 VA: 0x7F2EDD0
	public float WorldToLocalRotation(float worldRotation) { }

	// RVA: 0x7F2EE80 Offset: 0x7F2AE80 VA: 0x7F2EE80
	public float LocalToWorldRotation(float localRotation) { }

	// RVA: 0x7F2EF30 Offset: 0x7F2AF30 VA: 0x7F2EF30
	public void RotateWorld(float degrees) { }

	// RVA: 0x7F2EFDC Offset: 0x7F2AFDC VA: 0x7F2EFDC Slot: 3
	public override string ToString() { }
}

// Namespace: Spine
public class BoneData // TypeDefIndex: 23945
{
	// Fields
	internal int index; // 0x10
	internal string name; // 0x18
	internal BoneData parent; // 0x20
	internal float length; // 0x28
	internal float x; // 0x2C
	internal float y; // 0x30
	internal float rotation; // 0x34
	internal float scaleX; // 0x38
	internal float scaleY; // 0x3C
	internal float shearX; // 0x40
	internal float shearY; // 0x44
	internal TransformMode transformMode; // 0x48
	internal bool skinRequired; // 0x4C

	// Properties
	public int Index { get; }
	public string Name { get; }
	public BoneData Parent { get; }
	public float Length { get; set; }
	public float X { get; set; }
	public float Y { get; set; }
	public float Rotation { get; set; }
	public float ScaleX { get; set; }
	public float ScaleY { get; set; }
	public float ShearX { get; set; }
	public float ShearY { get; set; }
	public TransformMode TransformMode { get; set; }
	public bool SkinRequired { get; set; }

	// Methods

	// RVA: 0x7F2EFF8 Offset: 0x7F2AFF8 VA: 0x7F2EFF8
	public int get_Index() { }

	// RVA: 0x7F2F000 Offset: 0x7F2B000 VA: 0x7F2F000
	public string get_Name() { }

	// RVA: 0x7F2F008 Offset: 0x7F2B008 VA: 0x7F2F008
	public BoneData get_Parent() { }

	// RVA: 0x7F2F010 Offset: 0x7F2B010 VA: 0x7F2F010
	public float get_Length() { }

	// RVA: 0x7F2F018 Offset: 0x7F2B018 VA: 0x7F2F018
	public void set_Length(float value) { }

	// RVA: 0x7F2F020 Offset: 0x7F2B020 VA: 0x7F2F020
	public float get_X() { }

	// RVA: 0x7F2F028 Offset: 0x7F2B028 VA: 0x7F2F028
	public void set_X(float value) { }

	// RVA: 0x7F2F030 Offset: 0x7F2B030 VA: 0x7F2F030
	public float get_Y() { }

	// RVA: 0x7F2F038 Offset: 0x7F2B038 VA: 0x7F2F038
	public void set_Y(float value) { }

	// RVA: 0x7F2F040 Offset: 0x7F2B040 VA: 0x7F2F040
	public float get_Rotation() { }

	// RVA: 0x7F2F048 Offset: 0x7F2B048 VA: 0x7F2F048
	public void set_Rotation(float value) { }

	// RVA: 0x7F2F050 Offset: 0x7F2B050 VA: 0x7F2F050
	public float get_ScaleX() { }

	// RVA: 0x7F2F058 Offset: 0x7F2B058 VA: 0x7F2F058
	public void set_ScaleX(float value) { }

	// RVA: 0x7F2F060 Offset: 0x7F2B060 VA: 0x7F2F060
	public float get_ScaleY() { }

	// RVA: 0x7F2F068 Offset: 0x7F2B068 VA: 0x7F2F068
	public void set_ScaleY(float value) { }

	// RVA: 0x7F2F070 Offset: 0x7F2B070 VA: 0x7F2F070
	public float get_ShearX() { }

	// RVA: 0x7F2F078 Offset: 0x7F2B078 VA: 0x7F2F078
	public void set_ShearX(float value) { }

	// RVA: 0x7F2F080 Offset: 0x7F2B080 VA: 0x7F2F080
	public float get_ShearY() { }

	// RVA: 0x7F2F088 Offset: 0x7F2B088 VA: 0x7F2F088
	public void set_ShearY(float value) { }

	// RVA: 0x7F2F090 Offset: 0x7F2B090 VA: 0x7F2F090
	public TransformMode get_TransformMode() { }

	// RVA: 0x7F2F098 Offset: 0x7F2B098 VA: 0x7F2F098
	public void set_TransformMode(TransformMode value) { }

	// RVA: 0x7F2F0A0 Offset: 0x7F2B0A0 VA: 0x7F2F0A0
	public bool get_SkinRequired() { }

	// RVA: 0x7F2F0A8 Offset: 0x7F2B0A8 VA: 0x7F2F0A8
	public void set_SkinRequired(bool value) { }

	// RVA: 0x7F2F0B4 Offset: 0x7F2B0B4 VA: 0x7F2F0B4
	public void .ctor(int index, string name, BoneData parent) { }

	// RVA: 0x7F2F1BC Offset: 0x7F2B1BC VA: 0x7F2F1BC Slot: 3
	public override string ToString() { }
}

// Namespace: Spine
[Flags]
public enum TransformMode // TypeDefIndex: 23946
{
	// Fields
	public int value__; // 0x0
	public const TransformMode Normal = 0;
	public const TransformMode OnlyTranslation = 7;
	public const TransformMode NoRotationOrReflection = 1;
	public const TransformMode NoScale = 2;
	public const TransformMode NoScaleOrReflection = 6;
}

// Namespace: Spine
public abstract class ConstraintData // TypeDefIndex: 23947
{
	// Fields
	internal readonly string name; // 0x10
	internal int order; // 0x18
	internal bool skinRequired; // 0x1C

	// Properties
	public string Name { get; }
	public int Order { get; set; }
	public bool SkinRequired { get; set; }

	// Methods

	// RVA: 0x7F2F1C4 Offset: 0x7F2B1C4 VA: 0x7F2F1C4
	public void .ctor(string name) { }

	// RVA: 0x7F2F254 Offset: 0x7F2B254 VA: 0x7F2F254
	public string get_Name() { }

	// RVA: 0x7F2F25C Offset: 0x7F2B25C VA: 0x7F2F25C
	public int get_Order() { }

	// RVA: 0x7F2F264 Offset: 0x7F2B264 VA: 0x7F2F264
	public void set_Order(int value) { }

	// RVA: 0x7F2F26C Offset: 0x7F2B26C VA: 0x7F2F26C
	public bool get_SkinRequired() { }

	// RVA: 0x7F2F274 Offset: 0x7F2B274 VA: 0x7F2F274
	public void set_SkinRequired(bool value) { }

	// RVA: 0x7F2F280 Offset: 0x7F2B280 VA: 0x7F2F280 Slot: 3
	public override string ToString() { }
}

// Namespace: Spine
public class Event // TypeDefIndex: 23948
{
	// Fields
	internal readonly EventData data; // 0x10
	internal readonly float time; // 0x18
	internal int intValue; // 0x1C
	internal float floatValue; // 0x20
	internal string stringValue; // 0x28
	internal float volume; // 0x30
	internal float balance; // 0x34

	// Properties
	public EventData Data { get; }
	public float Time { get; }
	public int Int { get; set; }
	public float Float { get; set; }
	public string String { get; set; }
	public float Volume { get; set; }
	public float Balance { get; set; }

	// Methods

	// RVA: 0x7F2F288 Offset: 0x7F2B288 VA: 0x7F2F288
	public EventData get_Data() { }

	// RVA: 0x7F2F290 Offset: 0x7F2B290 VA: 0x7F2F290
	public float get_Time() { }

	// RVA: 0x7F2F298 Offset: 0x7F2B298 VA: 0x7F2F298
	public int get_Int() { }

	// RVA: 0x7F2F2A0 Offset: 0x7F2B2A0 VA: 0x7F2F2A0
	public void set_Int(int value) { }

	// RVA: 0x7F2F2A8 Offset: 0x7F2B2A8 VA: 0x7F2F2A8
	public float get_Float() { }

	// RVA: 0x7F2F2B0 Offset: 0x7F2B2B0 VA: 0x7F2F2B0
	public void set_Float(float value) { }

	// RVA: 0x7F2F2B8 Offset: 0x7F2B2B8 VA: 0x7F2F2B8
	public string get_String() { }

	// RVA: 0x7F2F2C0 Offset: 0x7F2B2C0 VA: 0x7F2F2C0
	public void set_String(string value) { }

	// RVA: 0x7F2F2C8 Offset: 0x7F2B2C8 VA: 0x7F2F2C8
	public float get_Volume() { }

	// RVA: 0x7F2F2D0 Offset: 0x7F2B2D0 VA: 0x7F2F2D0
	public void set_Volume(float value) { }

	// RVA: 0x7F2F2D8 Offset: 0x7F2B2D8 VA: 0x7F2F2D8
	public float get_Balance() { }

	// RVA: 0x7F2F2E0 Offset: 0x7F2B2E0 VA: 0x7F2F2E0
	public void set_Balance(float value) { }

	// RVA: 0x7F2F2E8 Offset: 0x7F2B2E8 VA: 0x7F2F2E8
	public void .ctor(float time, EventData data) { }

	// RVA: 0x7F2F388 Offset: 0x7F2B388 VA: 0x7F2F388 Slot: 3
	public override string ToString() { }
}

// Namespace: Spine
public class EventData // TypeDefIndex: 23949
{
	// Fields
	internal string name; // 0x10
	[CompilerGenerated]
	private int <Int>k__BackingField; // 0x18
	[CompilerGenerated]
	private float <Float>k__BackingField; // 0x1C
	[CompilerGenerated]
	private string <String>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <AudioPath>k__BackingField; // 0x28
	[CompilerGenerated]
	private float <Volume>k__BackingField; // 0x30
	[CompilerGenerated]
	private float <Balance>k__BackingField; // 0x34

	// Properties
	public string Name { get; }
	public int Int { get; set; }
	public float Float { get; set; }
	public string String { get; set; }
	public string AudioPath { get; set; }
	public float Volume { get; set; }
	public float Balance { get; set; }

	// Methods

	// RVA: 0x7F2F3A4 Offset: 0x7F2B3A4 VA: 0x7F2F3A4
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x7F2F3AC Offset: 0x7F2B3AC VA: 0x7F2F3AC
	public int get_Int() { }

	[CompilerGenerated]
	// RVA: 0x7F2F3B4 Offset: 0x7F2B3B4 VA: 0x7F2F3B4
	public void set_Int(int value) { }

	[CompilerGenerated]
	// RVA: 0x7F2F3BC Offset: 0x7F2B3BC VA: 0x7F2F3BC
	public float get_Float() { }

	[CompilerGenerated]
	// RVA: 0x7F2F3C4 Offset: 0x7F2B3C4 VA: 0x7F2F3C4
	public void set_Float(float value) { }

	[CompilerGenerated]
	// RVA: 0x7F2F3CC Offset: 0x7F2B3CC VA: 0x7F2F3CC
	public string get_String() { }

	[CompilerGenerated]
	// RVA: 0x7F2F3D4 Offset: 0x7F2B3D4 VA: 0x7F2F3D4
	public void set_String(string value) { }

	[CompilerGenerated]
	// RVA: 0x7F2F3DC Offset: 0x7F2B3DC VA: 0x7F2F3DC
	public string get_AudioPath() { }

	[CompilerGenerated]
	// RVA: 0x7F2F3E4 Offset: 0x7F2B3E4 VA: 0x7F2F3E4
	public void set_AudioPath(string value) { }

	[CompilerGenerated]
	// RVA: 0x7F2F3EC Offset: 0x7F2B3EC VA: 0x7F2F3EC
	public float get_Volume() { }

	[CompilerGenerated]
	// RVA: 0x7F2F3F4 Offset: 0x7F2B3F4 VA: 0x7F2F3F4
	public void set_Volume(float value) { }

	[CompilerGenerated]
	// RVA: 0x7F2F3FC Offset: 0x7F2B3FC VA: 0x7F2F3FC
	public float get_Balance() { }

	[CompilerGenerated]
	// RVA: 0x7F2F404 Offset: 0x7F2B404 VA: 0x7F2F404
	public void set_Balance(float value) { }

	// RVA: 0x7F2F40C Offset: 0x7F2B40C VA: 0x7F2F40C
	public void .ctor(string name) { }

	// RVA: 0x7F2F49C Offset: 0x7F2B49C VA: 0x7F2F49C Slot: 3
	public override string ToString() { }
}

// Namespace: 
public struct ExposedList.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 23950
{
	// Fields
	private ExposedList<T> l; // 0x0
	private int next; // 0x0
	private int ver; // 0x0
	private T current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ExposedList<T> l) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60D7ABC Offset: 0x60D3ABC VA: 0x60D7ABC
	|-ExposedList.Enumerator<bool>..ctor
	|
	|-RVA: 0x60DA8F8 Offset: 0x60D68F8 VA: 0x60DA8F8
	|-ExposedList.Enumerator<Color32>..ctor
	|
	|-RVA: 0x60E1E24 Offset: 0x60DDE24 VA: 0x60E1E24
	|-ExposedList.Enumerator<int>..ctor
	|
	|-RVA: 0x60E8BF0 Offset: 0x60E4BF0 VA: 0x60E8BF0
	|-ExposedList.Enumerator<object>..ctor
	|
	|-RVA: 0x60EFD78 Offset: 0x60EBD78 VA: 0x60EFD78
	|-ExposedList.Enumerator<float>..ctor
	|
	|-RVA: 0x60F1C2C Offset: 0x60EDC2C VA: 0x60F1C2C
	|-ExposedList.Enumerator<SubmeshInstruction>..ctor
	|
	|-RVA: 0x60F5D00 Offset: 0x60F1D00 VA: 0x60F5D00
	|-ExposedList.Enumerator<Vector2>..ctor
	|
	|-RVA: 0x60F639C Offset: 0x60F239C VA: 0x60F639C
	|-ExposedList.Enumerator<Vector3>..ctor
	|
	|-RVA: 0x60FAC0C Offset: 0x60F6C0C VA: 0x60FAC0C
	|-ExposedList.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60D7AF4 Offset: 0x60D3AF4 VA: 0x60D7AF4
	|-ExposedList.Enumerator<bool>.Dispose
	|
	|-RVA: 0x60DA930 Offset: 0x60D6930 VA: 0x60DA930
	|-ExposedList.Enumerator<Color32>.Dispose
	|
	|-RVA: 0x60E1E5C Offset: 0x60DDE5C VA: 0x60E1E5C
	|-ExposedList.Enumerator<int>.Dispose
	|
	|-RVA: 0x60E8C28 Offset: 0x60E4C28 VA: 0x60E8C28
	|-ExposedList.Enumerator<object>.Dispose
	|
	|-RVA: 0x60EFDB0 Offset: 0x60EBDB0 VA: 0x60EFDB0
	|-ExposedList.Enumerator<float>.Dispose
	|
	|-RVA: 0x60F1C74 Offset: 0x60EDC74 VA: 0x60F1C74
	|-ExposedList.Enumerator<SubmeshInstruction>.Dispose
	|
	|-RVA: 0x60F5D38 Offset: 0x60F1D38 VA: 0x60F5D38
	|-ExposedList.Enumerator<Vector2>.Dispose
	|
	|-RVA: 0x60F63D4 Offset: 0x60F23D4 VA: 0x60F63D4
	|-ExposedList.Enumerator<Vector3>.Dispose
	|
	|-RVA: 0x60FACB8 Offset: 0x60F6CB8 VA: 0x60FACB8
	|-ExposedList.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1
	private void VerifyState() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60D7B00 Offset: 0x60D3B00 VA: 0x60D7B00
	|-ExposedList.Enumerator<bool>.VerifyState
	|
	|-RVA: 0x60DA93C Offset: 0x60D693C VA: 0x60DA93C
	|-ExposedList.Enumerator<Color32>.VerifyState
	|
	|-RVA: 0x60E1E68 Offset: 0x60DDE68 VA: 0x60E1E68
	|-ExposedList.Enumerator<int>.VerifyState
	|
	|-RVA: 0x60E8C34 Offset: 0x60E4C34 VA: 0x60E8C34
	|-ExposedList.Enumerator<object>.VerifyState
	|
	|-RVA: 0x60EFDBC Offset: 0x60EBDBC VA: 0x60EFDBC
	|-ExposedList.Enumerator<float>.VerifyState
	|
	|-RVA: 0x60F1C80 Offset: 0x60EDC80 VA: 0x60F1C80
	|-ExposedList.Enumerator<SubmeshInstruction>.VerifyState
	|
	|-RVA: 0x60F5D44 Offset: 0x60F1D44 VA: 0x60F5D44
	|-ExposedList.Enumerator<Vector2>.VerifyState
	|
	|-RVA: 0x60F63E0 Offset: 0x60F23E0 VA: 0x60F63E0
	|-ExposedList.Enumerator<Vector3>.VerifyState
	|
	|-RVA: 0x60FACF4 Offset: 0x60F6CF4 VA: 0x60FACF4
	|-ExposedList.Enumerator<__Il2CppFullySharedGenericType>.VerifyState
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60D7BF0 Offset: 0x60D3BF0 VA: 0x60D7BF0
	|-ExposedList.Enumerator<bool>.MoveNext
	|
	|-RVA: 0x60DAA2C Offset: 0x60D6A2C VA: 0x60DAA2C
	|-ExposedList.Enumerator<Color32>.MoveNext
	|
	|-RVA: 0x60E1F58 Offset: 0x60DDF58 VA: 0x60E1F58
	|-ExposedList.Enumerator<int>.MoveNext
	|
	|-RVA: 0x60E8D24 Offset: 0x60E4D24 VA: 0x60E8D24
	|-ExposedList.Enumerator<object>.MoveNext
	|
	|-RVA: 0x60EFEAC Offset: 0x60EBEAC VA: 0x60EFEAC
	|-ExposedList.Enumerator<float>.MoveNext
	|
	|-RVA: 0x60F1D70 Offset: 0x60EDD70 VA: 0x60F1D70
	|-ExposedList.Enumerator<SubmeshInstruction>.MoveNext
	|
	|-RVA: 0x60F5E34 Offset: 0x60F1E34 VA: 0x60F5E34
	|-ExposedList.Enumerator<Vector2>.MoveNext
	|
	|-RVA: 0x60F64C8 Offset: 0x60F24C8 VA: 0x60F64C8
	|-ExposedList.Enumerator<Vector3>.MoveNext
	|
	|-RVA: 0x60FAEE4 Offset: 0x60F6EE4 VA: 0x60FAEE4
	|-ExposedList.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60D7C90 Offset: 0x60D3C90 VA: 0x60D7C90
	|-ExposedList.Enumerator<bool>.get_Current
	|
	|-RVA: 0x60DAACC Offset: 0x60D6ACC VA: 0x60DAACC
	|-ExposedList.Enumerator<Color32>.get_Current
	|
	|-RVA: 0x60E1FF8 Offset: 0x60DDFF8 VA: 0x60E1FF8
	|-ExposedList.Enumerator<int>.get_Current
	|
	|-RVA: 0x60E8DCC Offset: 0x60E4DCC VA: 0x60E8DCC
	|-ExposedList.Enumerator<object>.get_Current
	|
	|-RVA: 0x60EFF4C Offset: 0x60EBF4C VA: 0x60EFF4C
	|-ExposedList.Enumerator<float>.get_Current
	|
	|-RVA: 0x60F1E28 Offset: 0x60EDE28 VA: 0x60F1E28
	|-ExposedList.Enumerator<SubmeshInstruction>.get_Current
	|
	|-RVA: 0x60F5ED4 Offset: 0x60F1ED4 VA: 0x60F5ED4
	|-ExposedList.Enumerator<Vector2>.get_Current
	|
	|-RVA: 0x60F6574 Offset: 0x60F2574 VA: 0x60F6574
	|-ExposedList.Enumerator<Vector3>.get_Current
	|
	|-RVA: 0x60FB184 Offset: 0x60F7184 VA: 0x60FB184
	|-ExposedList.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60D7C98 Offset: 0x60D3C98 VA: 0x60D7C98
	|-ExposedList.Enumerator<bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x60DAAD4 Offset: 0x60D6AD4 VA: 0x60DAAD4
	|-ExposedList.Enumerator<Color32>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x60E2000 Offset: 0x60DE000 VA: 0x60E2000
	|-ExposedList.Enumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x60E8DD4 Offset: 0x60E4DD4 VA: 0x60E8DD4
	|-ExposedList.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x60EFF54 Offset: 0x60EBF54 VA: 0x60EFF54
	|-ExposedList.Enumerator<float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x60F1E3C Offset: 0x60EDE3C VA: 0x60F1E3C
	|-ExposedList.Enumerator<SubmeshInstruction>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x60F5EDC Offset: 0x60F1EDC VA: 0x60F5EDC
	|-ExposedList.Enumerator<Vector2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x60F6580 Offset: 0x60F2580 VA: 0x60F6580
	|-ExposedList.Enumerator<Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x60FB274 Offset: 0x60F7274 VA: 0x60FB274
	|-ExposedList.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60D7CD4 Offset: 0x60D3CD4 VA: 0x60D7CD4
	|-ExposedList.Enumerator<bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x60DAB10 Offset: 0x60D6B10 VA: 0x60DAB10
	|-ExposedList.Enumerator<Color32>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x60E203C Offset: 0x60DE03C VA: 0x60E203C
	|-ExposedList.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x60E8E10 Offset: 0x60E4E10 VA: 0x60E8E10
	|-ExposedList.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x60EFF90 Offset: 0x60EBF90 VA: 0x60EFF90
	|-ExposedList.Enumerator<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x60F1E78 Offset: 0x60EDE78 VA: 0x60F1E78
	|-ExposedList.Enumerator<SubmeshInstruction>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x60F5F18 Offset: 0x60F1F18 VA: 0x60F5F18
	|-ExposedList.Enumerator<Vector2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x60F65BC Offset: 0x60F25BC VA: 0x60F65BC
	|-ExposedList.Enumerator<Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x60FB310 Offset: 0x60F7310 VA: 0x60FB310
	|-ExposedList.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: Spine
[DebuggerDisplay("Count={Count}")]
public class ExposedList<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 23951
{
	// Fields
	public T[] Items; // 0x0
	public int Count; // 0x0
	private const int DefaultCapacity = 4;
	private static readonly T[] EmptyArray; // 0x0
	private int version; // 0x0

	// Properties
	public int Capacity { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631B0D4 Offset: 0x63170D4 VA: 0x631B0D4
	|-ExposedList<bool>..ctor
	|
	|-RVA: 0x631DB90 Offset: 0x6319B90 VA: 0x631DB90
	|-ExposedList<Color32>..ctor
	|
	|-RVA: 0x6320648 Offset: 0x631C648 VA: 0x6320648
	|-ExposedList<int>..ctor
	|
	|-RVA: 0x63230D4 Offset: 0x631F0D4 VA: 0x63230D4
	|-ExposedList<object>..ctor
	|
	|-RVA: 0x6325BB8 Offset: 0x6321BB8 VA: 0x6325BB8
	|-ExposedList<float>..ctor
	|
	|-RVA: 0x6328620 Offset: 0x6324620 VA: 0x6328620
	|-ExposedList<SubmeshInstruction>..ctor
	|
	|-RVA: 0x632B5C8 Offset: 0x63275C8 VA: 0x632B5C8
	|-ExposedList<Vector2>..ctor
	|
	|-RVA: 0x632E0CC Offset: 0x632A0CC VA: 0x632E0CC
	|-ExposedList<Vector3>..ctor
	|
	|-RVA: 0x6330C80 Offset: 0x632CC80 VA: 0x6330C80
	|-ExposedList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631B144 Offset: 0x6317144 VA: 0x631B144
	|-ExposedList<bool>..ctor
	|
	|-RVA: 0x631DC00 Offset: 0x6319C00 VA: 0x631DC00
	|-ExposedList<Color32>..ctor
	|
	|-RVA: 0x63206B8 Offset: 0x631C6B8 VA: 0x63206B8
	|-ExposedList<int>..ctor
	|
	|-RVA: 0x6323144 Offset: 0x631F144 VA: 0x6323144
	|-ExposedList<object>..ctor
	|
	|-RVA: 0x6325C28 Offset: 0x6321C28 VA: 0x6325C28
	|-ExposedList<float>..ctor
	|
	|-RVA: 0x6328690 Offset: 0x6324690 VA: 0x6328690
	|-ExposedList<SubmeshInstruction>..ctor
	|
	|-RVA: 0x632B638 Offset: 0x6327638 VA: 0x632B638
	|-ExposedList<Vector2>..ctor
	|
	|-RVA: 0x632E13C Offset: 0x632A13C VA: 0x632E13C
	|-ExposedList<Vector3>..ctor
	|
	|-RVA: 0x6330CF0 Offset: 0x632CCF0 VA: 0x6330CF0
	|-ExposedList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631B2F4 Offset: 0x63172F4 VA: 0x631B2F4
	|-ExposedList<bool>..ctor
	|
	|-RVA: 0x631DDB0 Offset: 0x6319DB0 VA: 0x631DDB0
	|-ExposedList<Color32>..ctor
	|
	|-RVA: 0x6320868 Offset: 0x631C868 VA: 0x6320868
	|-ExposedList<int>..ctor
	|
	|-RVA: 0x63232F4 Offset: 0x631F2F4 VA: 0x63232F4
	|-ExposedList<object>..ctor
	|
	|-RVA: 0x6325DD8 Offset: 0x6321DD8 VA: 0x6325DD8
	|-ExposedList<float>..ctor
	|
	|-RVA: 0x6328840 Offset: 0x6324840 VA: 0x6328840
	|-ExposedList<SubmeshInstruction>..ctor
	|
	|-RVA: 0x632B7E8 Offset: 0x63277E8 VA: 0x632B7E8
	|-ExposedList<Vector2>..ctor
	|
	|-RVA: 0x632E2EC Offset: 0x632A2EC VA: 0x632E2EC
	|-ExposedList<Vector3>..ctor
	|
	|-RVA: 0x6330EA0 Offset: 0x632CEA0 VA: 0x6330EA0
	|-ExposedList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(T[] data, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631B388 Offset: 0x6317388 VA: 0x631B388
	|-ExposedList<bool>..ctor
	|
	|-RVA: 0x631DE44 Offset: 0x6319E44 VA: 0x631DE44
	|-ExposedList<Color32>..ctor
	|
	|-RVA: 0x63208FC Offset: 0x631C8FC VA: 0x63208FC
	|-ExposedList<int>..ctor
	|
	|-RVA: 0x6323388 Offset: 0x631F388 VA: 0x6323388
	|-ExposedList<object>..ctor
	|
	|-RVA: 0x6325E6C Offset: 0x6321E6C VA: 0x6325E6C
	|-ExposedList<float>..ctor
	|
	|-RVA: 0x63288D4 Offset: 0x63248D4 VA: 0x63288D4
	|-ExposedList<SubmeshInstruction>..ctor
	|
	|-RVA: 0x632B87C Offset: 0x632787C VA: 0x632B87C
	|-ExposedList<Vector2>..ctor
	|
	|-RVA: 0x632E380 Offset: 0x632A380 VA: 0x632E380
	|-ExposedList<Vector3>..ctor
	|
	|-RVA: 0x6330F34 Offset: 0x632CF34 VA: 0x6330F34
	|-ExposedList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631B3C4 Offset: 0x63173C4 VA: 0x631B3C4
	|-ExposedList<bool>.Add
	|
	|-RVA: 0x631DE80 Offset: 0x6319E80 VA: 0x631DE80
	|-ExposedList<Color32>.Add
	|
	|-RVA: 0x6320938 Offset: 0x631C938 VA: 0x6320938
	|-ExposedList<int>.Add
	|
	|-RVA: 0x63233C4 Offset: 0x631F3C4 VA: 0x63233C4
	|-ExposedList<object>.Add
	|
	|-RVA: 0x6325EA8 Offset: 0x6321EA8 VA: 0x6325EA8
	|-ExposedList<float>.Add
	|
	|-RVA: 0x6328910 Offset: 0x6324910 VA: 0x6328910
	|-ExposedList<SubmeshInstruction>.Add
	|
	|-RVA: 0x632B8B8 Offset: 0x63278B8 VA: 0x632B8B8
	|-ExposedList<Vector2>.Add
	|
	|-RVA: 0x632E3BC Offset: 0x632A3BC VA: 0x632E3BC
	|-ExposedList<Vector3>.Add
	|
	|-RVA: 0x6330F70 Offset: 0x632CF70 VA: 0x6330F70
	|-ExposedList<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void GrowIfNeeded(int addedCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631B458 Offset: 0x6317458 VA: 0x631B458
	|-ExposedList<bool>.GrowIfNeeded
	|
	|-RVA: 0x631DF10 Offset: 0x6319F10 VA: 0x631DF10
	|-ExposedList<Color32>.GrowIfNeeded
	|
	|-RVA: 0x63209C8 Offset: 0x631C9C8 VA: 0x63209C8
	|-ExposedList<int>.GrowIfNeeded
	|
	|-RVA: 0x632345C Offset: 0x631F45C VA: 0x632345C
	|-ExposedList<object>.GrowIfNeeded
	|
	|-RVA: 0x6325F38 Offset: 0x6321F38 VA: 0x6325F38
	|-ExposedList<float>.GrowIfNeeded
	|
	|-RVA: 0x63289E0 Offset: 0x63249E0 VA: 0x63289E0
	|-ExposedList<SubmeshInstruction>.GrowIfNeeded
	|
	|-RVA: 0x632B950 Offset: 0x6327950 VA: 0x632B950
	|-ExposedList<Vector2>.GrowIfNeeded
	|
	|-RVA: 0x632E468 Offset: 0x632A468 VA: 0x632E468
	|-ExposedList<Vector3>.GrowIfNeeded
	|
	|-RVA: 0x63310E8 Offset: 0x632D0E8 VA: 0x63310E8
	|-ExposedList<__Il2CppFullySharedGenericType>.GrowIfNeeded
	*/

	// RVA: -1 Offset: -1
	public ExposedList<T> Resize(int newSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631B518 Offset: 0x6317518 VA: 0x631B518
	|-ExposedList<bool>.Resize
	|
	|-RVA: 0x631DFD0 Offset: 0x6319FD0 VA: 0x631DFD0
	|-ExposedList<Color32>.Resize
	|
	|-RVA: 0x6320A88 Offset: 0x631CA88 VA: 0x6320A88
	|-ExposedList<int>.Resize
	|
	|-RVA: 0x632351C Offset: 0x631F51C VA: 0x632351C
	|-ExposedList<object>.Resize
	|
	|-RVA: 0x6325FF8 Offset: 0x6321FF8 VA: 0x6325FF8
	|-ExposedList<float>.Resize
	|
	|-RVA: 0x6328AA0 Offset: 0x6324AA0 VA: 0x6328AA0
	|-ExposedList<SubmeshInstruction>.Resize
	|
	|-RVA: 0x632BA10 Offset: 0x6327A10 VA: 0x632BA10
	|-ExposedList<Vector2>.Resize
	|
	|-RVA: 0x632E528 Offset: 0x632A528 VA: 0x632E528
	|-ExposedList<Vector3>.Resize
	|
	|-RVA: 0x63311CC Offset: 0x632D1CC VA: 0x63311CC
	|-ExposedList<__Il2CppFullySharedGenericType>.Resize
	*/

	// RVA: -1 Offset: -1
	public void EnsureCapacity(int min) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631B5A0 Offset: 0x63175A0 VA: 0x631B5A0
	|-ExposedList<bool>.EnsureCapacity
	|
	|-RVA: 0x631E06C Offset: 0x631A06C VA: 0x631E06C
	|-ExposedList<Color32>.EnsureCapacity
	|
	|-RVA: 0x6320B10 Offset: 0x631CB10 VA: 0x6320B10
	|-ExposedList<int>.EnsureCapacity
	|
	|-RVA: 0x63235D4 Offset: 0x631F5D4 VA: 0x63235D4
	|-ExposedList<object>.EnsureCapacity
	|
	|-RVA: 0x6326080 Offset: 0x6322080 VA: 0x6326080
	|-ExposedList<float>.EnsureCapacity
	|
	|-RVA: 0x6328B88 Offset: 0x6324B88 VA: 0x6328B88
	|-ExposedList<SubmeshInstruction>.EnsureCapacity
	|
	|-RVA: 0x632BAAC Offset: 0x6327AAC VA: 0x632BAAC
	|-ExposedList<Vector2>.EnsureCapacity
	|
	|-RVA: 0x632E5CC Offset: 0x632A5CC VA: 0x632E5CC
	|-ExposedList<Vector3>.EnsureCapacity
	|
	|-RVA: 0x6331358 Offset: 0x632D358 VA: 0x6331358
	|-ExposedList<__Il2CppFullySharedGenericType>.EnsureCapacity
	*/

	// RVA: -1 Offset: -1
	private void CheckRange(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631B5F0 Offset: 0x63175F0 VA: 0x631B5F0
	|-ExposedList<bool>.CheckRange
	|
	|-RVA: 0x631E0BC Offset: 0x631A0BC VA: 0x631E0BC
	|-ExposedList<Color32>.CheckRange
	|
	|-RVA: 0x6320B60 Offset: 0x631CB60 VA: 0x6320B60
	|-ExposedList<int>.CheckRange
	|
	|-RVA: 0x6323624 Offset: 0x631F624 VA: 0x6323624
	|-ExposedList<object>.CheckRange
	|
	|-RVA: 0x63260D0 Offset: 0x63220D0 VA: 0x63260D0
	|-ExposedList<float>.CheckRange
	|
	|-RVA: 0x6328BD8 Offset: 0x6324BD8 VA: 0x6328BD8
	|-ExposedList<SubmeshInstruction>.CheckRange
	|
	|-RVA: 0x632BAFC Offset: 0x6327AFC VA: 0x632BAFC
	|-ExposedList<Vector2>.CheckRange
	|
	|-RVA: 0x632E61C Offset: 0x632A61C VA: 0x632E61C
	|-ExposedList<Vector3>.CheckRange
	|
	|-RVA: 0x63313AC Offset: 0x632D3AC VA: 0x63313AC
	|-ExposedList<__Il2CppFullySharedGenericType>.CheckRange
	*/

	// RVA: -1 Offset: -1
	private void AddCollection(ICollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631B6B8 Offset: 0x63176B8 VA: 0x631B6B8
	|-ExposedList<bool>.AddCollection
	|
	|-RVA: 0x631E184 Offset: 0x631A184 VA: 0x631E184
	|-ExposedList<Color32>.AddCollection
	|
	|-RVA: 0x6320C28 Offset: 0x631CC28 VA: 0x6320C28
	|-ExposedList<int>.AddCollection
	|
	|-RVA: 0x63236EC Offset: 0x631F6EC VA: 0x63236EC
	|-ExposedList<object>.AddCollection
	|
	|-RVA: 0x6326198 Offset: 0x6322198 VA: 0x6326198
	|-ExposedList<float>.AddCollection
	|
	|-RVA: 0x6328CA0 Offset: 0x6324CA0 VA: 0x6328CA0
	|-ExposedList<SubmeshInstruction>.AddCollection
	|
	|-RVA: 0x632BBC4 Offset: 0x6327BC4 VA: 0x632BBC4
	|-ExposedList<Vector2>.AddCollection
	|
	|-RVA: 0x632E6E4 Offset: 0x632A6E4 VA: 0x632E6E4
	|-ExposedList<Vector3>.AddCollection
	|
	|-RVA: 0x6331474 Offset: 0x632D474 VA: 0x6331474
	|-ExposedList<__Il2CppFullySharedGenericType>.AddCollection
	*/

	// RVA: -1 Offset: -1
	private void AddEnumerable(IEnumerable<T> enumerable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631B810 Offset: 0x6317810 VA: 0x631B810
	|-ExposedList<bool>.AddEnumerable
	|
	|-RVA: 0x631E2DC Offset: 0x631A2DC VA: 0x631E2DC
	|-ExposedList<Color32>.AddEnumerable
	|
	|-RVA: 0x6320D80 Offset: 0x631CD80 VA: 0x6320D80
	|-ExposedList<int>.AddEnumerable
	|
	|-RVA: 0x6323844 Offset: 0x631F844 VA: 0x6323844
	|-ExposedList<object>.AddEnumerable
	|
	|-RVA: 0x63262F0 Offset: 0x63222F0 VA: 0x63262F0
	|-ExposedList<float>.AddEnumerable
	|
	|-RVA: 0x6328DF8 Offset: 0x6324DF8 VA: 0x6328DF8
	|-ExposedList<SubmeshInstruction>.AddEnumerable
	|
	|-RVA: 0x632BD1C Offset: 0x6327D1C VA: 0x632BD1C
	|-ExposedList<Vector2>.AddEnumerable
	|
	|-RVA: 0x632E83C Offset: 0x632A83C VA: 0x632E83C
	|-ExposedList<Vector3>.AddEnumerable
	|
	|-RVA: 0x63315D0 Offset: 0x632D5D0 VA: 0x63315D0
	|-ExposedList<__Il2CppFullySharedGenericType>.AddEnumerable
	*/

	// RVA: -1 Offset: -1
	public void AddRange(ExposedList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631BB00 Offset: 0x6317B00 VA: 0x631BB00
	|-ExposedList<bool>.AddRange
	|
	|-RVA: 0x631E5CC Offset: 0x631A5CC VA: 0x631E5CC
	|-ExposedList<Color32>.AddRange
	|
	|-RVA: 0x6321070 Offset: 0x631D070 VA: 0x6321070
	|-ExposedList<int>.AddRange
	|
	|-RVA: 0x6323B34 Offset: 0x631FB34 VA: 0x6323B34
	|-ExposedList<object>.AddRange
	|
	|-RVA: 0x63265DC Offset: 0x63225DC VA: 0x63265DC
	|-ExposedList<float>.AddRange
	|
	|-RVA: 0x6329114 Offset: 0x6325114 VA: 0x6329114
	|-ExposedList<SubmeshInstruction>.AddRange
	|
	|-RVA: 0x632C008 Offset: 0x6328008 VA: 0x632C008
	|-ExposedList<Vector2>.AddRange
	|
	|-RVA: 0x632EB28 Offset: 0x632AB28 VA: 0x632EB28
	|-ExposedList<Vector3>.AddRange
	|
	|-RVA: 0x6331994 Offset: 0x632D994 VA: 0x6331994
	|-ExposedList<__Il2CppFullySharedGenericType>.AddRange
	*/

	// RVA: -1 Offset: -1
	public void AddRange(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631BB8C Offset: 0x6317B8C VA: 0x631BB8C
	|-ExposedList<bool>.AddRange
	|
	|-RVA: 0x631E658 Offset: 0x631A658 VA: 0x631E658
	|-ExposedList<Color32>.AddRange
	|
	|-RVA: 0x63210FC Offset: 0x631D0FC VA: 0x63210FC
	|-ExposedList<int>.AddRange
	|
	|-RVA: 0x6323BC0 Offset: 0x631FBC0 VA: 0x6323BC0
	|-ExposedList<object>.AddRange
	|
	|-RVA: 0x6326668 Offset: 0x6322668 VA: 0x6326668
	|-ExposedList<float>.AddRange
	|
	|-RVA: 0x63291A0 Offset: 0x63251A0 VA: 0x63291A0
	|-ExposedList<SubmeshInstruction>.AddRange
	|
	|-RVA: 0x632C094 Offset: 0x6328094 VA: 0x632C094
	|-ExposedList<Vector2>.AddRange
	|
	|-RVA: 0x632EBB4 Offset: 0x632ABB4 VA: 0x632EBB4
	|-ExposedList<Vector3>.AddRange
	|
	|-RVA: 0x6331A2C Offset: 0x632DA2C VA: 0x6331A2C
	|-ExposedList<__Il2CppFullySharedGenericType>.AddRange
	*/

	// RVA: -1 Offset: -1
	public int BinarySearch(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631BC20 Offset: 0x6317C20 VA: 0x631BC20
	|-ExposedList<bool>.BinarySearch
	|
	|-RVA: 0x631E6EC Offset: 0x631A6EC VA: 0x631E6EC
	|-ExposedList<Color32>.BinarySearch
	|
	|-RVA: 0x6321190 Offset: 0x631D190 VA: 0x6321190
	|-ExposedList<int>.BinarySearch
	|
	|-RVA: 0x6323C54 Offset: 0x631FC54 VA: 0x6323C54
	|-ExposedList<object>.BinarySearch
	|
	|-RVA: 0x63266FC Offset: 0x63226FC VA: 0x63266FC
	|-ExposedList<float>.BinarySearch
	|
	|-RVA: 0x6329234 Offset: 0x6325234 VA: 0x6329234
	|-ExposedList<SubmeshInstruction>.BinarySearch
	|
	|-RVA: 0x632C128 Offset: 0x6328128 VA: 0x632C128
	|-ExposedList<Vector2>.BinarySearch
	|
	|-RVA: 0x632EC48 Offset: 0x632AC48 VA: 0x632EC48
	|-ExposedList<Vector3>.BinarySearch
	|
	|-RVA: 0x6331AC4 Offset: 0x632DAC4 VA: 0x6331AC4
	|-ExposedList<__Il2CppFullySharedGenericType>.BinarySearch
	*/

	// RVA: -1 Offset: -1
	public int BinarySearch(T item, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631BC44 Offset: 0x6317C44 VA: 0x631BC44
	|-ExposedList<bool>.BinarySearch
	|
	|-RVA: 0x631E710 Offset: 0x631A710 VA: 0x631E710
	|-ExposedList<Color32>.BinarySearch
	|
	|-RVA: 0x63211B4 Offset: 0x631D1B4 VA: 0x63211B4
	|-ExposedList<int>.BinarySearch
	|
	|-RVA: 0x6323C78 Offset: 0x631FC78 VA: 0x6323C78
	|-ExposedList<object>.BinarySearch
	|
	|-RVA: 0x632671C Offset: 0x632271C VA: 0x632671C
	|-ExposedList<float>.BinarySearch
	|
	|-RVA: 0x6329288 Offset: 0x6325288 VA: 0x6329288
	|-ExposedList<SubmeshInstruction>.BinarySearch
	|
	|-RVA: 0x632C148 Offset: 0x6328148 VA: 0x632C148
	|-ExposedList<Vector2>.BinarySearch
	|
	|-RVA: 0x632EC68 Offset: 0x632AC68 VA: 0x632EC68
	|-ExposedList<Vector3>.BinarySearch
	|
	|-RVA: 0x6331BA4 Offset: 0x632DBA4 VA: 0x6331BA4
	|-ExposedList<__Il2CppFullySharedGenericType>.BinarySearch
	*/

	// RVA: -1 Offset: -1
	public int BinarySearch(int index, int count, T item, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631BC70 Offset: 0x6317C70 VA: 0x631BC70
	|-ExposedList<bool>.BinarySearch
	|
	|-RVA: 0x631E73C Offset: 0x631A73C VA: 0x631E73C
	|-ExposedList<Color32>.BinarySearch
	|
	|-RVA: 0x63211DC Offset: 0x631D1DC VA: 0x63211DC
	|-ExposedList<int>.BinarySearch
	|
	|-RVA: 0x6323CA0 Offset: 0x631FCA0 VA: 0x6323CA0
	|-ExposedList<object>.BinarySearch
	|
	|-RVA: 0x6326740 Offset: 0x6322740 VA: 0x6326740
	|-ExposedList<float>.BinarySearch
	|
	|-RVA: 0x63292DC Offset: 0x63252DC VA: 0x63292DC
	|-ExposedList<SubmeshInstruction>.BinarySearch
	|
	|-RVA: 0x632C16C Offset: 0x632816C VA: 0x632C16C
	|-ExposedList<Vector2>.BinarySearch
	|
	|-RVA: 0x632EC8C Offset: 0x632AC8C VA: 0x632EC8C
	|-ExposedList<Vector3>.BinarySearch
	|
	|-RVA: 0x6331C8C Offset: 0x632DC8C VA: 0x6331C8C
	|-ExposedList<__Il2CppFullySharedGenericType>.BinarySearch
	*/

	// RVA: -1 Offset: -1
	public void Clear(bool clearArray = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631BCDC Offset: 0x6317CDC VA: 0x631BCDC
	|-ExposedList<bool>.Clear
	|
	|-RVA: 0x631E7A8 Offset: 0x631A7A8 VA: 0x631E7A8
	|-ExposedList<Color32>.Clear
	|
	|-RVA: 0x6321248 Offset: 0x631D248 VA: 0x6321248
	|-ExposedList<int>.Clear
	|
	|-RVA: 0x6323D0C Offset: 0x631FD0C VA: 0x6323D0C
	|-ExposedList<object>.Clear
	|
	|-RVA: 0x63267AC Offset: 0x63227AC VA: 0x63267AC
	|-ExposedList<float>.Clear
	|
	|-RVA: 0x6329374 Offset: 0x6325374 VA: 0x6329374
	|-ExposedList<SubmeshInstruction>.Clear
	|
	|-RVA: 0x632C1E0 Offset: 0x63281E0 VA: 0x632C1E0
	|-ExposedList<Vector2>.Clear
	|
	|-RVA: 0x632ED10 Offset: 0x632AD10 VA: 0x632ED10
	|-ExposedList<Vector3>.Clear
	|
	|-RVA: 0x6331DB0 Offset: 0x632DDB0 VA: 0x6331DB0
	|-ExposedList<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631BD18 Offset: 0x6317D18 VA: 0x631BD18
	|-ExposedList<bool>.Contains
	|
	|-RVA: 0x631E7E4 Offset: 0x631A7E4 VA: 0x631E7E4
	|-ExposedList<Color32>.Contains
	|
	|-RVA: 0x6321284 Offset: 0x631D284 VA: 0x6321284
	|-ExposedList<int>.Contains
	|
	|-RVA: 0x6323D48 Offset: 0x631FD48 VA: 0x6323D48
	|-ExposedList<object>.Contains
	|
	|-RVA: 0x63267E8 Offset: 0x63227E8 VA: 0x63267E8
	|-ExposedList<float>.Contains
	|
	|-RVA: 0x63293B0 Offset: 0x63253B0 VA: 0x63293B0
	|-ExposedList<SubmeshInstruction>.Contains
	|
	|-RVA: 0x632C21C Offset: 0x632821C VA: 0x632C21C
	|-ExposedList<Vector2>.Contains
	|
	|-RVA: 0x632ED4C Offset: 0x632AD4C VA: 0x632ED4C
	|-ExposedList<Vector3>.Contains
	|
	|-RVA: 0x6331DEC Offset: 0x632DDEC VA: 0x6331DEC
	|-ExposedList<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1
	public ExposedList<TOutput> ConvertAll<TOutput>(Converter<T, TOutput> converter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4223724 Offset: 0x421F724 VA: 0x4223724
	|-ExposedList<__Il2CppFullySharedGenericType>.ConvertAll<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631BD50 Offset: 0x6317D50 VA: 0x631BD50
	|-ExposedList<bool>.CopyTo
	|
	|-RVA: 0x631E81C Offset: 0x631A81C VA: 0x631E81C
	|-ExposedList<Color32>.CopyTo
	|
	|-RVA: 0x63212B8 Offset: 0x631D2B8 VA: 0x63212B8
	|-ExposedList<int>.CopyTo
	|
	|-RVA: 0x6323D7C Offset: 0x631FD7C VA: 0x6323D7C
	|-ExposedList<object>.CopyTo
	|
	|-RVA: 0x632681C Offset: 0x632281C VA: 0x632681C
	|-ExposedList<float>.CopyTo
	|
	|-RVA: 0x6329408 Offset: 0x6325408 VA: 0x6329408
	|-ExposedList<SubmeshInstruction>.CopyTo
	|
	|-RVA: 0x632C250 Offset: 0x6328250 VA: 0x632C250
	|-ExposedList<Vector2>.CopyTo
	|
	|-RVA: 0x632ED80 Offset: 0x632AD80 VA: 0x632ED80
	|-ExposedList<Vector3>.CopyTo
	|
	|-RVA: 0x6331ED8 Offset: 0x632DED8 VA: 0x6331ED8
	|-ExposedList<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631BD70 Offset: 0x6317D70 VA: 0x631BD70
	|-ExposedList<bool>.CopyTo
	|
	|-RVA: 0x631E83C Offset: 0x631A83C VA: 0x631E83C
	|-ExposedList<Color32>.CopyTo
	|
	|-RVA: 0x63212D8 Offset: 0x631D2D8 VA: 0x63212D8
	|-ExposedList<int>.CopyTo
	|
	|-RVA: 0x6323D9C Offset: 0x631FD9C VA: 0x6323D9C
	|-ExposedList<object>.CopyTo
	|
	|-RVA: 0x632683C Offset: 0x632283C VA: 0x632683C
	|-ExposedList<float>.CopyTo
	|
	|-RVA: 0x6329428 Offset: 0x6325428 VA: 0x6329428
	|-ExposedList<SubmeshInstruction>.CopyTo
	|
	|-RVA: 0x632C270 Offset: 0x6328270 VA: 0x632C270
	|-ExposedList<Vector2>.CopyTo
	|
	|-RVA: 0x632EDA0 Offset: 0x632ADA0 VA: 0x632EDA0
	|-ExposedList<Vector3>.CopyTo
	|
	|-RVA: 0x6331EF8 Offset: 0x632DEF8 VA: 0x6331EF8
	|-ExposedList<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(int index, T[] array, int arrayIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631BD90 Offset: 0x6317D90 VA: 0x631BD90
	|-ExposedList<bool>.CopyTo
	|
	|-RVA: 0x631E85C Offset: 0x631A85C VA: 0x631E85C
	|-ExposedList<Color32>.CopyTo
	|
	|-RVA: 0x63212F8 Offset: 0x631D2F8 VA: 0x63212F8
	|-ExposedList<int>.CopyTo
	|
	|-RVA: 0x6323DBC Offset: 0x631FDBC VA: 0x6323DBC
	|-ExposedList<object>.CopyTo
	|
	|-RVA: 0x632685C Offset: 0x632285C VA: 0x632685C
	|-ExposedList<float>.CopyTo
	|
	|-RVA: 0x6329448 Offset: 0x6325448 VA: 0x6329448
	|-ExposedList<SubmeshInstruction>.CopyTo
	|
	|-RVA: 0x632C290 Offset: 0x6328290 VA: 0x632C290
	|-ExposedList<Vector2>.CopyTo
	|
	|-RVA: 0x632EDC0 Offset: 0x632ADC0 VA: 0x632EDC0
	|-ExposedList<Vector3>.CopyTo
	|
	|-RVA: 0x6331F18 Offset: 0x632DF18 VA: 0x6331F18
	|-ExposedList<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public bool Exists(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631BDEC Offset: 0x6317DEC VA: 0x631BDEC
	|-ExposedList<bool>.Exists
	|
	|-RVA: 0x631E8B8 Offset: 0x631A8B8 VA: 0x631E8B8
	|-ExposedList<Color32>.Exists
	|
	|-RVA: 0x6321354 Offset: 0x631D354 VA: 0x6321354
	|-ExposedList<int>.Exists
	|
	|-RVA: 0x6323E18 Offset: 0x631FE18 VA: 0x6323E18
	|-ExposedList<object>.Exists
	|
	|-RVA: 0x63268B8 Offset: 0x63228B8 VA: 0x63268B8
	|-ExposedList<float>.Exists
	|
	|-RVA: 0x63294A4 Offset: 0x63254A4 VA: 0x63294A4
	|-ExposedList<SubmeshInstruction>.Exists
	|
	|-RVA: 0x632C2EC Offset: 0x63282EC VA: 0x632C2EC
	|-ExposedList<Vector2>.Exists
	|
	|-RVA: 0x632EE1C Offset: 0x632AE1C VA: 0x632EE1C
	|-ExposedList<Vector3>.Exists
	|
	|-RVA: 0x6331F78 Offset: 0x632DF78 VA: 0x6331F78
	|-ExposedList<__Il2CppFullySharedGenericType>.Exists
	*/

	// RVA: -1 Offset: -1
	public T Find(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631BE78 Offset: 0x6317E78 VA: 0x631BE78
	|-ExposedList<bool>.Find
	|
	|-RVA: 0x631E944 Offset: 0x631A944 VA: 0x631E944
	|-ExposedList<Color32>.Find
	|
	|-RVA: 0x63213E0 Offset: 0x631D3E0 VA: 0x63213E0
	|-ExposedList<int>.Find
	|
	|-RVA: 0x6323EA4 Offset: 0x631FEA4 VA: 0x6323EA4
	|-ExposedList<object>.Find
	|
	|-RVA: 0x6326944 Offset: 0x6322944 VA: 0x6326944
	|-ExposedList<float>.Find
	|
	|-RVA: 0x6329530 Offset: 0x6325530 VA: 0x6329530
	|-ExposedList<SubmeshInstruction>.Find
	|
	|-RVA: 0x632C378 Offset: 0x6328378 VA: 0x632C378
	|-ExposedList<Vector2>.Find
	|
	|-RVA: 0x632EEA8 Offset: 0x632AEA8 VA: 0x632EEA8
	|-ExposedList<Vector3>.Find
	|
	|-RVA: 0x633200C Offset: 0x632E00C VA: 0x633200C
	|-ExposedList<__Il2CppFullySharedGenericType>.Find
	*/

	// RVA: -1 Offset: -1
	private static void CheckMatch(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631BF38 Offset: 0x6317F38 VA: 0x631BF38
	|-ExposedList<bool>.CheckMatch
	|
	|-RVA: 0x631E9FC Offset: 0x631A9FC VA: 0x631E9FC
	|-ExposedList<Color32>.CheckMatch
	|
	|-RVA: 0x6321498 Offset: 0x631D498 VA: 0x6321498
	|-ExposedList<int>.CheckMatch
	|
	|-RVA: 0x6323F5C Offset: 0x631FF5C VA: 0x6323F5C
	|-ExposedList<object>.CheckMatch
	|
	|-RVA: 0x63269FC Offset: 0x63229FC VA: 0x63269FC
	|-ExposedList<float>.CheckMatch
	|
	|-RVA: 0x6329600 Offset: 0x6325600 VA: 0x6329600
	|-ExposedList<SubmeshInstruction>.CheckMatch
	|
	|-RVA: 0x632C438 Offset: 0x6328438 VA: 0x632C438
	|-ExposedList<Vector2>.CheckMatch
	|
	|-RVA: 0x632EF74 Offset: 0x632AF74 VA: 0x632EF74
	|-ExposedList<Vector3>.CheckMatch
	|
	|-RVA: 0x6332188 Offset: 0x632E188 VA: 0x6332188
	|-ExposedList<__Il2CppFullySharedGenericType>.CheckMatch
	*/

	// RVA: -1 Offset: -1
	public ExposedList<T> FindAll(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631BF88 Offset: 0x6317F88 VA: 0x631BF88
	|-ExposedList<bool>.FindAll
	|
	|-RVA: 0x631EA4C Offset: 0x631AA4C VA: 0x631EA4C
	|-ExposedList<Color32>.FindAll
	|
	|-RVA: 0x63214E8 Offset: 0x631D4E8 VA: 0x63214E8
	|-ExposedList<int>.FindAll
	|
	|-RVA: 0x6323FAC Offset: 0x631FFAC VA: 0x6323FAC
	|-ExposedList<object>.FindAll
	|
	|-RVA: 0x6326A4C Offset: 0x6322A4C VA: 0x6326A4C
	|-ExposedList<float>.FindAll
	|
	|-RVA: 0x6329650 Offset: 0x6325650 VA: 0x6329650
	|-ExposedList<SubmeshInstruction>.FindAll
	|
	|-RVA: 0x632C488 Offset: 0x6328488 VA: 0x632C488
	|-ExposedList<Vector2>.FindAll
	|
	|-RVA: 0x632EFC4 Offset: 0x632AFC4 VA: 0x632EFC4
	|-ExposedList<Vector3>.FindAll
	|
	|-RVA: 0x63321D8 Offset: 0x632E1D8 VA: 0x63321D8
	|-ExposedList<__Il2CppFullySharedGenericType>.FindAll
	*/

	// RVA: -1 Offset: -1
	private ExposedList<T> FindAllList(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631C000 Offset: 0x6318000 VA: 0x631C000
	|-ExposedList<bool>.FindAllList
	|
	|-RVA: 0x631EAC4 Offset: 0x631AAC4 VA: 0x631EAC4
	|-ExposedList<Color32>.FindAllList
	|
	|-RVA: 0x6321560 Offset: 0x631D560 VA: 0x6321560
	|-ExposedList<int>.FindAllList
	|
	|-RVA: 0x6324024 Offset: 0x6320024 VA: 0x6324024
	|-ExposedList<object>.FindAllList
	|
	|-RVA: 0x6326AC4 Offset: 0x6322AC4 VA: 0x6326AC4
	|-ExposedList<float>.FindAllList
	|
	|-RVA: 0x63296C8 Offset: 0x63256C8 VA: 0x63296C8
	|-ExposedList<SubmeshInstruction>.FindAllList
	|
	|-RVA: 0x632C500 Offset: 0x6328500 VA: 0x632C500
	|-ExposedList<Vector2>.FindAllList
	|
	|-RVA: 0x632F03C Offset: 0x632B03C VA: 0x632F03C
	|-ExposedList<Vector3>.FindAllList
	|
	|-RVA: 0x6332258 Offset: 0x632E258 VA: 0x6332258
	|-ExposedList<__Il2CppFullySharedGenericType>.FindAllList
	*/

	// RVA: -1 Offset: -1
	public int FindIndex(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631C100 Offset: 0x6318100 VA: 0x631C100
	|-ExposedList<bool>.FindIndex
	|
	|-RVA: 0x631EBC4 Offset: 0x631ABC4 VA: 0x631EBC4
	|-ExposedList<Color32>.FindIndex
	|
	|-RVA: 0x6321660 Offset: 0x631D660 VA: 0x6321660
	|-ExposedList<int>.FindIndex
	|
	|-RVA: 0x6324124 Offset: 0x6320124 VA: 0x6324124
	|-ExposedList<object>.FindIndex
	|
	|-RVA: 0x6326BC4 Offset: 0x6322BC4 VA: 0x6326BC4
	|-ExposedList<float>.FindIndex
	|
	|-RVA: 0x6329818 Offset: 0x6325818 VA: 0x6329818
	|-ExposedList<SubmeshInstruction>.FindIndex
	|
	|-RVA: 0x632C608 Offset: 0x6328608 VA: 0x632C608
	|-ExposedList<Vector2>.FindIndex
	|
	|-RVA: 0x632F14C Offset: 0x632B14C VA: 0x632F14C
	|-ExposedList<Vector3>.FindIndex
	|
	|-RVA: 0x6332424 Offset: 0x632E424 VA: 0x6332424
	|-ExposedList<__Il2CppFullySharedGenericType>.FindIndex
	*/

	// RVA: -1 Offset: -1
	public int FindIndex(int startIndex, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631C180 Offset: 0x6318180 VA: 0x631C180
	|-ExposedList<bool>.FindIndex
	|
	|-RVA: 0x631EC44 Offset: 0x631AC44 VA: 0x631EC44
	|-ExposedList<Color32>.FindIndex
	|
	|-RVA: 0x63216E0 Offset: 0x631D6E0 VA: 0x63216E0
	|-ExposedList<int>.FindIndex
	|
	|-RVA: 0x63241A4 Offset: 0x63201A4 VA: 0x63241A4
	|-ExposedList<object>.FindIndex
	|
	|-RVA: 0x6326C44 Offset: 0x6322C44 VA: 0x6326C44
	|-ExposedList<float>.FindIndex
	|
	|-RVA: 0x6329898 Offset: 0x6325898 VA: 0x6329898
	|-ExposedList<SubmeshInstruction>.FindIndex
	|
	|-RVA: 0x632C688 Offset: 0x6328688 VA: 0x632C688
	|-ExposedList<Vector2>.FindIndex
	|
	|-RVA: 0x632F1CC Offset: 0x632B1CC VA: 0x632F1CC
	|-ExposedList<Vector3>.FindIndex
	|
	|-RVA: 0x63324AC Offset: 0x632E4AC VA: 0x63324AC
	|-ExposedList<__Il2CppFullySharedGenericType>.FindIndex
	*/

	// RVA: -1 Offset: -1
	public int FindIndex(int startIndex, int count, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631C228 Offset: 0x6318228 VA: 0x631C228
	|-ExposedList<bool>.FindIndex
	|
	|-RVA: 0x631ECEC Offset: 0x631ACEC VA: 0x631ECEC
	|-ExposedList<Color32>.FindIndex
	|
	|-RVA: 0x6321788 Offset: 0x631D788 VA: 0x6321788
	|-ExposedList<int>.FindIndex
	|
	|-RVA: 0x632424C Offset: 0x632024C VA: 0x632424C
	|-ExposedList<object>.FindIndex
	|
	|-RVA: 0x6326CEC Offset: 0x6322CEC VA: 0x6326CEC
	|-ExposedList<float>.FindIndex
	|
	|-RVA: 0x6329940 Offset: 0x6325940 VA: 0x6329940
	|-ExposedList<SubmeshInstruction>.FindIndex
	|
	|-RVA: 0x632C730 Offset: 0x6328730 VA: 0x632C730
	|-ExposedList<Vector2>.FindIndex
	|
	|-RVA: 0x632F274 Offset: 0x632B274 VA: 0x632F274
	|-ExposedList<Vector3>.FindIndex
	|
	|-RVA: 0x6332560 Offset: 0x632E560 VA: 0x6332560
	|-ExposedList<__Il2CppFullySharedGenericType>.FindIndex
	*/

	// RVA: -1 Offset: -1
	private int GetIndex(int startIndex, int count, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631C2D4 Offset: 0x63182D4 VA: 0x631C2D4
	|-ExposedList<bool>.GetIndex
	|
	|-RVA: 0x631ED98 Offset: 0x631AD98 VA: 0x631ED98
	|-ExposedList<Color32>.GetIndex
	|
	|-RVA: 0x6321834 Offset: 0x631D834 VA: 0x6321834
	|-ExposedList<int>.GetIndex
	|
	|-RVA: 0x63242F8 Offset: 0x63202F8 VA: 0x63242F8
	|-ExposedList<object>.GetIndex
	|
	|-RVA: 0x6326D98 Offset: 0x6322D98 VA: 0x6326D98
	|-ExposedList<float>.GetIndex
	|
	|-RVA: 0x63299EC Offset: 0x63259EC VA: 0x63299EC
	|-ExposedList<SubmeshInstruction>.GetIndex
	|
	|-RVA: 0x632C7DC Offset: 0x63287DC VA: 0x632C7DC
	|-ExposedList<Vector2>.GetIndex
	|
	|-RVA: 0x632F320 Offset: 0x632B320 VA: 0x632F320
	|-ExposedList<Vector3>.GetIndex
	|
	|-RVA: 0x6332618 Offset: 0x632E618 VA: 0x6332618
	|-ExposedList<__Il2CppFullySharedGenericType>.GetIndex
	*/

	// RVA: -1 Offset: -1
	public T FindLast(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631C35C Offset: 0x631835C VA: 0x631C35C
	|-ExposedList<bool>.FindLast
	|
	|-RVA: 0x631EE20 Offset: 0x631AE20 VA: 0x631EE20
	|-ExposedList<Color32>.FindLast
	|
	|-RVA: 0x63218BC Offset: 0x631D8BC VA: 0x63218BC
	|-ExposedList<int>.FindLast
	|
	|-RVA: 0x6324380 Offset: 0x6320380 VA: 0x6324380
	|-ExposedList<object>.FindLast
	|
	|-RVA: 0x6326E20 Offset: 0x6322E20 VA: 0x6326E20
	|-ExposedList<float>.FindLast
	|
	|-RVA: 0x6329AB0 Offset: 0x6325AB0 VA: 0x6329AB0
	|-ExposedList<SubmeshInstruction>.FindLast
	|
	|-RVA: 0x632C870 Offset: 0x6328870 VA: 0x632C870
	|-ExposedList<Vector2>.FindLast
	|
	|-RVA: 0x632F3C0 Offset: 0x632B3C0 VA: 0x632F3C0
	|-ExposedList<Vector3>.FindLast
	|
	|-RVA: 0x633274C Offset: 0x632E74C VA: 0x633274C
	|-ExposedList<__Il2CppFullySharedGenericType>.FindLast
	*/

	// RVA: -1 Offset: -1
	public int FindLastIndex(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631C41C Offset: 0x631841C VA: 0x631C41C
	|-ExposedList<bool>.FindLastIndex
	|
	|-RVA: 0x631EED8 Offset: 0x631AED8 VA: 0x631EED8
	|-ExposedList<Color32>.FindLastIndex
	|
	|-RVA: 0x6321974 Offset: 0x631D974 VA: 0x6321974
	|-ExposedList<int>.FindLastIndex
	|
	|-RVA: 0x6324438 Offset: 0x6320438 VA: 0x6324438
	|-ExposedList<object>.FindLastIndex
	|
	|-RVA: 0x6326ED8 Offset: 0x6322ED8 VA: 0x6326ED8
	|-ExposedList<float>.FindLastIndex
	|
	|-RVA: 0x6329B80 Offset: 0x6325B80 VA: 0x6329B80
	|-ExposedList<SubmeshInstruction>.FindLastIndex
	|
	|-RVA: 0x632C930 Offset: 0x6328930 VA: 0x632C930
	|-ExposedList<Vector2>.FindLastIndex
	|
	|-RVA: 0x632F48C Offset: 0x632B48C VA: 0x632F48C
	|-ExposedList<Vector3>.FindLastIndex
	|
	|-RVA: 0x63328C8 Offset: 0x632E8C8 VA: 0x63328C8
	|-ExposedList<__Il2CppFullySharedGenericType>.FindLastIndex
	*/

	// RVA: -1 Offset: -1
	public int FindLastIndex(int startIndex, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631C49C Offset: 0x631849C VA: 0x631C49C
	|-ExposedList<bool>.FindLastIndex
	|
	|-RVA: 0x631EF58 Offset: 0x631AF58 VA: 0x631EF58
	|-ExposedList<Color32>.FindLastIndex
	|
	|-RVA: 0x63219F4 Offset: 0x631D9F4 VA: 0x63219F4
	|-ExposedList<int>.FindLastIndex
	|
	|-RVA: 0x63244B8 Offset: 0x63204B8 VA: 0x63244B8
	|-ExposedList<object>.FindLastIndex
	|
	|-RVA: 0x6326F58 Offset: 0x6322F58 VA: 0x6326F58
	|-ExposedList<float>.FindLastIndex
	|
	|-RVA: 0x6329C00 Offset: 0x6325C00 VA: 0x6329C00
	|-ExposedList<SubmeshInstruction>.FindLastIndex
	|
	|-RVA: 0x632C9B0 Offset: 0x63289B0 VA: 0x632C9B0
	|-ExposedList<Vector2>.FindLastIndex
	|
	|-RVA: 0x632F50C Offset: 0x632B50C VA: 0x632F50C
	|-ExposedList<Vector3>.FindLastIndex
	|
	|-RVA: 0x6332950 Offset: 0x632E950 VA: 0x6332950
	|-ExposedList<__Il2CppFullySharedGenericType>.FindLastIndex
	*/

	// RVA: -1 Offset: -1
	public int FindLastIndex(int startIndex, int count, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631C540 Offset: 0x6318540 VA: 0x631C540
	|-ExposedList<bool>.FindLastIndex
	|
	|-RVA: 0x631EFFC Offset: 0x631AFFC VA: 0x631EFFC
	|-ExposedList<Color32>.FindLastIndex
	|
	|-RVA: 0x6321A98 Offset: 0x631DA98 VA: 0x6321A98
	|-ExposedList<int>.FindLastIndex
	|
	|-RVA: 0x632455C Offset: 0x632055C VA: 0x632455C
	|-ExposedList<object>.FindLastIndex
	|
	|-RVA: 0x6326FFC Offset: 0x6322FFC VA: 0x6326FFC
	|-ExposedList<float>.FindLastIndex
	|
	|-RVA: 0x6329CA4 Offset: 0x6325CA4 VA: 0x6329CA4
	|-ExposedList<SubmeshInstruction>.FindLastIndex
	|
	|-RVA: 0x632CA54 Offset: 0x6328A54 VA: 0x632CA54
	|-ExposedList<Vector2>.FindLastIndex
	|
	|-RVA: 0x632F5B0 Offset: 0x632B5B0 VA: 0x632F5B0
	|-ExposedList<Vector3>.FindLastIndex
	|
	|-RVA: 0x6332A00 Offset: 0x632EA00 VA: 0x6332A00
	|-ExposedList<__Il2CppFullySharedGenericType>.FindLastIndex
	*/

	// RVA: -1 Offset: -1
	private int GetLastIndex(int startIndex, int count, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631C5F4 Offset: 0x63185F4 VA: 0x631C5F4
	|-ExposedList<bool>.GetLastIndex
	|
	|-RVA: 0x631F0B0 Offset: 0x631B0B0 VA: 0x631F0B0
	|-ExposedList<Color32>.GetLastIndex
	|
	|-RVA: 0x6321B4C Offset: 0x631DB4C VA: 0x6321B4C
	|-ExposedList<int>.GetLastIndex
	|
	|-RVA: 0x6324610 Offset: 0x6320610 VA: 0x6324610
	|-ExposedList<object>.GetLastIndex
	|
	|-RVA: 0x63270B0 Offset: 0x63230B0 VA: 0x63270B0
	|-ExposedList<float>.GetLastIndex
	|
	|-RVA: 0x6329D58 Offset: 0x6325D58 VA: 0x6329D58
	|-ExposedList<SubmeshInstruction>.GetLastIndex
	|
	|-RVA: 0x632CB08 Offset: 0x6328B08 VA: 0x632CB08
	|-ExposedList<Vector2>.GetLastIndex
	|
	|-RVA: 0x632F664 Offset: 0x632B664 VA: 0x632F664
	|-ExposedList<Vector3>.GetLastIndex
	|
	|-RVA: 0x6332AC0 Offset: 0x632EAC0 VA: 0x6332AC0
	|-ExposedList<__Il2CppFullySharedGenericType>.GetLastIndex
	*/

	// RVA: -1 Offset: -1
	public void ForEach(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631C674 Offset: 0x6318674 VA: 0x631C674
	|-ExposedList<bool>.ForEach
	|
	|-RVA: 0x631F130 Offset: 0x631B130 VA: 0x631F130
	|-ExposedList<Color32>.ForEach
	|
	|-RVA: 0x6321BCC Offset: 0x631DBCC VA: 0x6321BCC
	|-ExposedList<int>.ForEach
	|
	|-RVA: 0x6324690 Offset: 0x6320690 VA: 0x6324690
	|-ExposedList<object>.ForEach
	|
	|-RVA: 0x6327130 Offset: 0x6323130 VA: 0x6327130
	|-ExposedList<float>.ForEach
	|
	|-RVA: 0x6329E04 Offset: 0x6325E04 VA: 0x6329E04
	|-ExposedList<SubmeshInstruction>.ForEach
	|
	|-RVA: 0x632CB8C Offset: 0x6328B8C VA: 0x632CB8C
	|-ExposedList<Vector2>.ForEach
	|
	|-RVA: 0x632F6F0 Offset: 0x632B6F0 VA: 0x632F6F0
	|-ExposedList<Vector3>.ForEach
	|
	|-RVA: 0x6332BF0 Offset: 0x632EBF0 VA: 0x6332BF0
	|-ExposedList<__Il2CppFullySharedGenericType>.ForEach
	*/

	// RVA: -1 Offset: -1
	public ExposedList.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631C72C Offset: 0x631872C VA: 0x631C72C
	|-ExposedList<bool>.GetEnumerator
	|
	|-RVA: 0x631F1E4 Offset: 0x631B1E4 VA: 0x631F1E4
	|-ExposedList<Color32>.GetEnumerator
	|
	|-RVA: 0x6321C80 Offset: 0x631DC80 VA: 0x6321C80
	|-ExposedList<int>.GetEnumerator
	|
	|-RVA: 0x6324744 Offset: 0x6320744 VA: 0x6324744
	|-ExposedList<object>.GetEnumerator
	|
	|-RVA: 0x63271E4 Offset: 0x63231E4 VA: 0x63271E4
	|-ExposedList<float>.GetEnumerator
	|
	|-RVA: 0x6329EE8 Offset: 0x6325EE8 VA: 0x6329EE8
	|-ExposedList<SubmeshInstruction>.GetEnumerator
	|
	|-RVA: 0x632CC50 Offset: 0x6328C50 VA: 0x632CC50
	|-ExposedList<Vector2>.GetEnumerator
	|
	|-RVA: 0x632F7B8 Offset: 0x632B7B8 VA: 0x632F7B8
	|-ExposedList<Vector3>.GetEnumerator
	|
	|-RVA: 0x6332D4C Offset: 0x632ED4C VA: 0x6332D4C
	|-ExposedList<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public ExposedList<T> GetRange(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631C74C Offset: 0x631874C VA: 0x631C74C
	|-ExposedList<bool>.GetRange
	|
	|-RVA: 0x631F204 Offset: 0x631B204 VA: 0x631F204
	|-ExposedList<Color32>.GetRange
	|
	|-RVA: 0x6321CA0 Offset: 0x631DCA0 VA: 0x6321CA0
	|-ExposedList<int>.GetRange
	|
	|-RVA: 0x6324764 Offset: 0x6320764 VA: 0x6324764
	|-ExposedList<object>.GetRange
	|
	|-RVA: 0x6327204 Offset: 0x6323204 VA: 0x6327204
	|-ExposedList<float>.GetRange
	|
	|-RVA: 0x6329F0C Offset: 0x6325F0C VA: 0x6329F0C
	|-ExposedList<SubmeshInstruction>.GetRange
	|
	|-RVA: 0x632CC70 Offset: 0x6328C70 VA: 0x632CC70
	|-ExposedList<Vector2>.GetRange
	|
	|-RVA: 0x632F7D8 Offset: 0x632B7D8 VA: 0x632F7D8
	|-ExposedList<Vector3>.GetRange
	|
	|-RVA: 0x6332DFC Offset: 0x632EDFC VA: 0x6332DFC
	|-ExposedList<__Il2CppFullySharedGenericType>.GetRange
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631C80C Offset: 0x631880C VA: 0x631C80C
	|-ExposedList<bool>.IndexOf
	|
	|-RVA: 0x631F2C4 Offset: 0x631B2C4 VA: 0x631F2C4
	|-ExposedList<Color32>.IndexOf
	|
	|-RVA: 0x6321D60 Offset: 0x631DD60 VA: 0x6321D60
	|-ExposedList<int>.IndexOf
	|
	|-RVA: 0x6324824 Offset: 0x6320824 VA: 0x6324824
	|-ExposedList<object>.IndexOf
	|
	|-RVA: 0x63272C4 Offset: 0x63232C4 VA: 0x63272C4
	|-ExposedList<float>.IndexOf
	|
	|-RVA: 0x6329FCC Offset: 0x6325FCC VA: 0x6329FCC
	|-ExposedList<SubmeshInstruction>.IndexOf
	|
	|-RVA: 0x632CD30 Offset: 0x6328D30 VA: 0x632CD30
	|-ExposedList<Vector2>.IndexOf
	|
	|-RVA: 0x632F898 Offset: 0x632B898 VA: 0x632F898
	|-ExposedList<Vector3>.IndexOf
	|
	|-RVA: 0x6332EC0 Offset: 0x632EEC0 VA: 0x6332EC0
	|-ExposedList<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(T item, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631C830 Offset: 0x6318830 VA: 0x631C830
	|-ExposedList<bool>.IndexOf
	|
	|-RVA: 0x631F2E8 Offset: 0x631B2E8 VA: 0x631F2E8
	|-ExposedList<Color32>.IndexOf
	|
	|-RVA: 0x6321D80 Offset: 0x631DD80 VA: 0x6321D80
	|-ExposedList<int>.IndexOf
	|
	|-RVA: 0x6324844 Offset: 0x6320844 VA: 0x6324844
	|-ExposedList<object>.IndexOf
	|
	|-RVA: 0x63272E4 Offset: 0x63232E4 VA: 0x63272E4
	|-ExposedList<float>.IndexOf
	|
	|-RVA: 0x632A01C Offset: 0x632601C VA: 0x632A01C
	|-ExposedList<SubmeshInstruction>.IndexOf
	|
	|-RVA: 0x632CD50 Offset: 0x6328D50 VA: 0x632CD50
	|-ExposedList<Vector2>.IndexOf
	|
	|-RVA: 0x632F8B8 Offset: 0x632B8B8 VA: 0x632F8B8
	|-ExposedList<Vector3>.IndexOf
	|
	|-RVA: 0x6332FA4 Offset: 0x632EFA4 VA: 0x6332FA4
	|-ExposedList<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(T item, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631C890 Offset: 0x6318890 VA: 0x631C890
	|-ExposedList<bool>.IndexOf
	|
	|-RVA: 0x631F348 Offset: 0x631B348 VA: 0x631F348
	|-ExposedList<Color32>.IndexOf
	|
	|-RVA: 0x6321DE0 Offset: 0x631DDE0 VA: 0x6321DE0
	|-ExposedList<int>.IndexOf
	|
	|-RVA: 0x63248A4 Offset: 0x63208A4 VA: 0x63248A4
	|-ExposedList<object>.IndexOf
	|
	|-RVA: 0x6327340 Offset: 0x6323340 VA: 0x6327340
	|-ExposedList<float>.IndexOf
	|
	|-RVA: 0x632A0A8 Offset: 0x63260A8 VA: 0x632A0A8
	|-ExposedList<SubmeshInstruction>.IndexOf
	|
	|-RVA: 0x632CDB4 Offset: 0x6328DB4 VA: 0x632CDB4
	|-ExposedList<Vector2>.IndexOf
	|
	|-RVA: 0x632F92C Offset: 0x632B92C VA: 0x632F92C
	|-ExposedList<Vector3>.IndexOf
	|
	|-RVA: 0x63330C0 Offset: 0x632F0C0 VA: 0x63330C0
	|-ExposedList<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1
	private void Shift(int start, int delta) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631C958 Offset: 0x6318958 VA: 0x631C958
	|-ExposedList<bool>.Shift
	|
	|-RVA: 0x631F410 Offset: 0x631B410 VA: 0x631F410
	|-ExposedList<Color32>.Shift
	|
	|-RVA: 0x6321EA4 Offset: 0x631DEA4 VA: 0x6321EA4
	|-ExposedList<int>.Shift
	|
	|-RVA: 0x6324968 Offset: 0x6320968 VA: 0x6324968
	|-ExposedList<object>.Shift
	|
	|-RVA: 0x6327404 Offset: 0x6323404 VA: 0x6327404
	|-ExposedList<float>.Shift
	|
	|-RVA: 0x632A194 Offset: 0x6326194 VA: 0x632A194
	|-ExposedList<SubmeshInstruction>.Shift
	|
	|-RVA: 0x632CE78 Offset: 0x6328E78 VA: 0x632CE78
	|-ExposedList<Vector2>.Shift
	|
	|-RVA: 0x632F9F0 Offset: 0x632B9F0 VA: 0x632F9F0
	|-ExposedList<Vector3>.Shift
	|
	|-RVA: 0x6333244 Offset: 0x632F244 VA: 0x6333244
	|-ExposedList<__Il2CppFullySharedGenericType>.Shift
	*/

	// RVA: -1 Offset: -1
	private void CheckIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631C9C8 Offset: 0x63189C8 VA: 0x631C9C8
	|-ExposedList<bool>.CheckIndex
	|
	|-RVA: 0x631F480 Offset: 0x631B480 VA: 0x631F480
	|-ExposedList<Color32>.CheckIndex
	|
	|-RVA: 0x6321F14 Offset: 0x631DF14 VA: 0x6321F14
	|-ExposedList<int>.CheckIndex
	|
	|-RVA: 0x63249D8 Offset: 0x63209D8 VA: 0x63249D8
	|-ExposedList<object>.CheckIndex
	|
	|-RVA: 0x6327474 Offset: 0x6323474 VA: 0x6327474
	|-ExposedList<float>.CheckIndex
	|
	|-RVA: 0x632A204 Offset: 0x6326204 VA: 0x632A204
	|-ExposedList<SubmeshInstruction>.CheckIndex
	|
	|-RVA: 0x632CEE8 Offset: 0x6328EE8 VA: 0x632CEE8
	|-ExposedList<Vector2>.CheckIndex
	|
	|-RVA: 0x632FA60 Offset: 0x632BA60 VA: 0x632FA60
	|-ExposedList<Vector3>.CheckIndex
	|
	|-RVA: 0x63332B4 Offset: 0x632F2B4 VA: 0x63332B4
	|-ExposedList<__Il2CppFullySharedGenericType>.CheckIndex
	*/

	// RVA: -1 Offset: -1
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631CA2C Offset: 0x6318A2C VA: 0x631CA2C
	|-ExposedList<bool>.Insert
	|
	|-RVA: 0x631F4E4 Offset: 0x631B4E4 VA: 0x631F4E4
	|-ExposedList<Color32>.Insert
	|
	|-RVA: 0x6321F78 Offset: 0x631DF78 VA: 0x6321F78
	|-ExposedList<int>.Insert
	|
	|-RVA: 0x6324A3C Offset: 0x6320A3C VA: 0x6324A3C
	|-ExposedList<object>.Insert
	|
	|-RVA: 0x63274D8 Offset: 0x63234D8 VA: 0x63274D8
	|-ExposedList<float>.Insert
	|
	|-RVA: 0x632A268 Offset: 0x6326268 VA: 0x632A268
	|-ExposedList<SubmeshInstruction>.Insert
	|
	|-RVA: 0x632CF4C Offset: 0x6328F4C VA: 0x632CF4C
	|-ExposedList<Vector2>.Insert
	|
	|-RVA: 0x632FAC4 Offset: 0x632BAC4 VA: 0x632FAC4
	|-ExposedList<Vector3>.Insert
	|
	|-RVA: 0x6333318 Offset: 0x632F318 VA: 0x6333318
	|-ExposedList<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1
	private void CheckCollection(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631CADC Offset: 0x6318ADC VA: 0x631CADC
	|-ExposedList<bool>.CheckCollection
	|
	|-RVA: 0x631F590 Offset: 0x631B590 VA: 0x631F590
	|-ExposedList<Color32>.CheckCollection
	|
	|-RVA: 0x6322024 Offset: 0x631E024 VA: 0x6322024
	|-ExposedList<int>.CheckCollection
	|
	|-RVA: 0x6324AF0 Offset: 0x6320AF0 VA: 0x6324AF0
	|-ExposedList<object>.CheckCollection
	|
	|-RVA: 0x6327584 Offset: 0x6323584 VA: 0x6327584
	|-ExposedList<float>.CheckCollection
	|
	|-RVA: 0x632A35C Offset: 0x632635C VA: 0x632A35C
	|-ExposedList<SubmeshInstruction>.CheckCollection
	|
	|-RVA: 0x632D000 Offset: 0x6329000 VA: 0x632D000
	|-ExposedList<Vector2>.CheckCollection
	|
	|-RVA: 0x632FB8C Offset: 0x632BB8C VA: 0x632FB8C
	|-ExposedList<Vector3>.CheckCollection
	|
	|-RVA: 0x63334BC Offset: 0x632F4BC VA: 0x63334BC
	|-ExposedList<__Il2CppFullySharedGenericType>.CheckCollection
	*/

	// RVA: -1 Offset: -1
	public void InsertRange(int index, IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631CB2C Offset: 0x6318B2C VA: 0x631CB2C
	|-ExposedList<bool>.InsertRange
	|
	|-RVA: 0x631F5E0 Offset: 0x631B5E0 VA: 0x631F5E0
	|-ExposedList<Color32>.InsertRange
	|
	|-RVA: 0x6322074 Offset: 0x631E074 VA: 0x6322074
	|-ExposedList<int>.InsertRange
	|
	|-RVA: 0x6324B40 Offset: 0x6320B40 VA: 0x6324B40
	|-ExposedList<object>.InsertRange
	|
	|-RVA: 0x63275D4 Offset: 0x63235D4 VA: 0x63275D4
	|-ExposedList<float>.InsertRange
	|
	|-RVA: 0x632A3AC Offset: 0x63263AC VA: 0x632A3AC
	|-ExposedList<SubmeshInstruction>.InsertRange
	|
	|-RVA: 0x632D050 Offset: 0x6329050 VA: 0x632D050
	|-ExposedList<Vector2>.InsertRange
	|
	|-RVA: 0x632FBDC Offset: 0x632BBDC VA: 0x632FBDC
	|-ExposedList<Vector3>.InsertRange
	|
	|-RVA: 0x633350C Offset: 0x632F50C VA: 0x633350C
	|-ExposedList<__Il2CppFullySharedGenericType>.InsertRange
	*/

	// RVA: -1 Offset: -1
	private void InsertCollection(int index, ICollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631CC90 Offset: 0x6318C90 VA: 0x631CC90
	|-ExposedList<bool>.InsertCollection
	|
	|-RVA: 0x631F744 Offset: 0x631B744 VA: 0x631F744
	|-ExposedList<Color32>.InsertCollection
	|
	|-RVA: 0x63221D8 Offset: 0x631E1D8 VA: 0x63221D8
	|-ExposedList<int>.InsertCollection
	|
	|-RVA: 0x6324CA4 Offset: 0x6320CA4 VA: 0x6324CA4
	|-ExposedList<object>.InsertCollection
	|
	|-RVA: 0x6327738 Offset: 0x6323738 VA: 0x6327738
	|-ExposedList<float>.InsertCollection
	|
	|-RVA: 0x632A510 Offset: 0x6326510 VA: 0x632A510
	|-ExposedList<SubmeshInstruction>.InsertCollection
	|
	|-RVA: 0x632D1B4 Offset: 0x63291B4 VA: 0x632D1B4
	|-ExposedList<Vector2>.InsertCollection
	|
	|-RVA: 0x632FD40 Offset: 0x632BD40 VA: 0x632FD40
	|-ExposedList<Vector3>.InsertCollection
	|
	|-RVA: 0x633368C Offset: 0x632F68C VA: 0x633368C
	|-ExposedList<__Il2CppFullySharedGenericType>.InsertCollection
	*/

	// RVA: -1 Offset: -1
	private void InsertEnumeration(int index, IEnumerable<T> enumerable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631CDE4 Offset: 0x6318DE4 VA: 0x631CDE4
	|-ExposedList<bool>.InsertEnumeration
	|
	|-RVA: 0x631F898 Offset: 0x631B898 VA: 0x631F898
	|-ExposedList<Color32>.InsertEnumeration
	|
	|-RVA: 0x632232C Offset: 0x631E32C VA: 0x632232C
	|-ExposedList<int>.InsertEnumeration
	|
	|-RVA: 0x6324DF8 Offset: 0x6320DF8 VA: 0x6324DF8
	|-ExposedList<object>.InsertEnumeration
	|
	|-RVA: 0x632788C Offset: 0x632388C VA: 0x632788C
	|-ExposedList<float>.InsertEnumeration
	|
	|-RVA: 0x632A664 Offset: 0x6326664 VA: 0x632A664
	|-ExposedList<SubmeshInstruction>.InsertEnumeration
	|
	|-RVA: 0x632D308 Offset: 0x6329308 VA: 0x632D308
	|-ExposedList<Vector2>.InsertEnumeration
	|
	|-RVA: 0x632FE94 Offset: 0x632BE94 VA: 0x632FE94
	|-ExposedList<Vector3>.InsertEnumeration
	|
	|-RVA: 0x63337F4 Offset: 0x632F7F4 VA: 0x63337F4
	|-ExposedList<__Il2CppFullySharedGenericType>.InsertEnumeration
	*/

	// RVA: -1 Offset: -1
	public int LastIndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631D0EC Offset: 0x63190EC VA: 0x631D0EC
	|-ExposedList<bool>.LastIndexOf
	|
	|-RVA: 0x631FBA0 Offset: 0x631BBA0 VA: 0x631FBA0
	|-ExposedList<Color32>.LastIndexOf
	|
	|-RVA: 0x6322634 Offset: 0x631E634 VA: 0x6322634
	|-ExposedList<int>.LastIndexOf
	|
	|-RVA: 0x6325100 Offset: 0x6321100 VA: 0x6325100
	|-ExposedList<object>.LastIndexOf
	|
	|-RVA: 0x6327B90 Offset: 0x6323B90 VA: 0x6327B90
	|-ExposedList<float>.LastIndexOf
	|
	|-RVA: 0x632A994 Offset: 0x6326994 VA: 0x632A994
	|-ExposedList<SubmeshInstruction>.LastIndexOf
	|
	|-RVA: 0x632D60C Offset: 0x632960C VA: 0x632D60C
	|-ExposedList<Vector2>.LastIndexOf
	|
	|-RVA: 0x6330198 Offset: 0x632C198 VA: 0x6330198
	|-ExposedList<Vector3>.LastIndexOf
	|
	|-RVA: 0x6333BDC Offset: 0x632FBDC VA: 0x6333BDC
	|-ExposedList<__Il2CppFullySharedGenericType>.LastIndexOf
	*/

	// RVA: -1 Offset: -1
	public int LastIndexOf(T item, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631D10C Offset: 0x631910C VA: 0x631D10C
	|-ExposedList<bool>.LastIndexOf
	|
	|-RVA: 0x631FBC0 Offset: 0x631BBC0 VA: 0x631FBC0
	|-ExposedList<Color32>.LastIndexOf
	|
	|-RVA: 0x6322654 Offset: 0x631E654 VA: 0x6322654
	|-ExposedList<int>.LastIndexOf
	|
	|-RVA: 0x6325120 Offset: 0x6321120 VA: 0x6325120
	|-ExposedList<object>.LastIndexOf
	|
	|-RVA: 0x6327BB0 Offset: 0x6323BB0 VA: 0x6327BB0
	|-ExposedList<float>.LastIndexOf
	|
	|-RVA: 0x632A9E4 Offset: 0x63269E4 VA: 0x632A9E4
	|-ExposedList<SubmeshInstruction>.LastIndexOf
	|
	|-RVA: 0x632D62C Offset: 0x632962C VA: 0x632D62C
	|-ExposedList<Vector2>.LastIndexOf
	|
	|-RVA: 0x63301B8 Offset: 0x632C1B8 VA: 0x63301B8
	|-ExposedList<Vector3>.LastIndexOf
	|
	|-RVA: 0x6333CC4 Offset: 0x632FCC4 VA: 0x6333CC4
	|-ExposedList<__Il2CppFullySharedGenericType>.LastIndexOf
	*/

	// RVA: -1 Offset: -1
	public int LastIndexOf(T item, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631D168 Offset: 0x6319168 VA: 0x631D168
	|-ExposedList<bool>.LastIndexOf
	|
	|-RVA: 0x631FC1C Offset: 0x631BC1C VA: 0x631FC1C
	|-ExposedList<Color32>.LastIndexOf
	|
	|-RVA: 0x63226B0 Offset: 0x631E6B0 VA: 0x63226B0
	|-ExposedList<int>.LastIndexOf
	|
	|-RVA: 0x632517C Offset: 0x632117C VA: 0x632517C
	|-ExposedList<object>.LastIndexOf
	|
	|-RVA: 0x6327C08 Offset: 0x6323C08 VA: 0x6327C08
	|-ExposedList<float>.LastIndexOf
	|
	|-RVA: 0x632AA6C Offset: 0x6326A6C VA: 0x632AA6C
	|-ExposedList<SubmeshInstruction>.LastIndexOf
	|
	|-RVA: 0x632D68C Offset: 0x632968C VA: 0x632D68C
	|-ExposedList<Vector2>.LastIndexOf
	|
	|-RVA: 0x6330228 Offset: 0x632C228 VA: 0x6330228
	|-ExposedList<Vector3>.LastIndexOf
	|
	|-RVA: 0x6333DDC Offset: 0x632FDDC VA: 0x6333DDC
	|-ExposedList<__Il2CppFullySharedGenericType>.LastIndexOf
	*/

	// RVA: -1 Offset: -1
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631D2C8 Offset: 0x63192C8 VA: 0x631D2C8
	|-ExposedList<bool>.Remove
	|
	|-RVA: 0x631FD7C Offset: 0x631BD7C VA: 0x631FD7C
	|-ExposedList<Color32>.Remove
	|
	|-RVA: 0x632280C Offset: 0x631E80C VA: 0x632280C
	|-ExposedList<int>.Remove
	|
	|-RVA: 0x63252D8 Offset: 0x63212D8 VA: 0x63252D8
	|-ExposedList<object>.Remove
	|
	|-RVA: 0x6327D64 Offset: 0x6323D64 VA: 0x6327D64
	|-ExposedList<float>.Remove
	|
	|-RVA: 0x632ABE8 Offset: 0x6326BE8 VA: 0x632ABE8
	|-ExposedList<SubmeshInstruction>.Remove
	|
	|-RVA: 0x632D7E8 Offset: 0x63297E8 VA: 0x632D7E8
	|-ExposedList<Vector2>.Remove
	|
	|-RVA: 0x6330384 Offset: 0x632C384 VA: 0x6330384
	|-ExposedList<Vector3>.Remove
	|
	|-RVA: 0x6333FE8 Offset: 0x632FFE8 VA: 0x6333FE8
	|-ExposedList<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public int RemoveAll(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631D33C Offset: 0x631933C VA: 0x631D33C
	|-ExposedList<bool>.RemoveAll
	|
	|-RVA: 0x631FDF0 Offset: 0x631BDF0 VA: 0x631FDF0
	|-ExposedList<Color32>.RemoveAll
	|
	|-RVA: 0x632287C Offset: 0x631E87C VA: 0x632287C
	|-ExposedList<int>.RemoveAll
	|
	|-RVA: 0x6325348 Offset: 0x6321348 VA: 0x6325348
	|-ExposedList<object>.RemoveAll
	|
	|-RVA: 0x6327DD4 Offset: 0x6323DD4 VA: 0x6327DD4
	|-ExposedList<float>.RemoveAll
	|
	|-RVA: 0x632AC7C Offset: 0x6326C7C VA: 0x632AC7C
	|-ExposedList<SubmeshInstruction>.RemoveAll
	|
	|-RVA: 0x632D858 Offset: 0x6329858 VA: 0x632D858
	|-ExposedList<Vector2>.RemoveAll
	|
	|-RVA: 0x63303F4 Offset: 0x632C3F4 VA: 0x63303F4
	|-ExposedList<Vector3>.RemoveAll
	|
	|-RVA: 0x63340E4 Offset: 0x63300E4 VA: 0x63340E4
	|-ExposedList<__Il2CppFullySharedGenericType>.RemoveAll
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631D4E0 Offset: 0x63194E0 VA: 0x631D4E0
	|-ExposedList<bool>.RemoveAt
	|
	|-RVA: 0x631FF94 Offset: 0x631BF94 VA: 0x631FF94
	|-ExposedList<Color32>.RemoveAt
	|
	|-RVA: 0x6322A20 Offset: 0x631EA20 VA: 0x6322A20
	|-ExposedList<int>.RemoveAt
	|
	|-RVA: 0x63254F8 Offset: 0x63214F8 VA: 0x63254F8
	|-ExposedList<object>.RemoveAt
	|
	|-RVA: 0x6327F78 Offset: 0x6323F78 VA: 0x6327F78
	|-ExposedList<float>.RemoveAt
	|
	|-RVA: 0x632AEAC Offset: 0x6326EAC VA: 0x632AEAC
	|-ExposedList<SubmeshInstruction>.RemoveAt
	|
	|-RVA: 0x632DA08 Offset: 0x6329A08 VA: 0x632DA08
	|-ExposedList<Vector2>.RemoveAt
	|
	|-RVA: 0x63305C4 Offset: 0x632C5C4 VA: 0x63305C4
	|-ExposedList<Vector3>.RemoveAt
	|
	|-RVA: 0x63343E4 Offset: 0x63303E4 VA: 0x63343E4
	|-ExposedList<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631D574 Offset: 0x6319574 VA: 0x631D574
	|-ExposedList<bool>.Pop
	|
	|-RVA: 0x6320028 Offset: 0x631C028 VA: 0x6320028
	|-ExposedList<Color32>.Pop
	|
	|-RVA: 0x6322AB4 Offset: 0x631EAB4 VA: 0x6322AB4
	|-ExposedList<int>.Pop
	|
	|-RVA: 0x632558C Offset: 0x632158C VA: 0x632558C
	|-ExposedList<object>.Pop
	|
	|-RVA: 0x632800C Offset: 0x632400C VA: 0x632800C
	|-ExposedList<float>.Pop
	|
	|-RVA: 0x632AF40 Offset: 0x6326F40 VA: 0x632AF40
	|-ExposedList<SubmeshInstruction>.Pop
	|
	|-RVA: 0x632DA9C Offset: 0x6329A9C VA: 0x632DA9C
	|-ExposedList<Vector2>.Pop
	|
	|-RVA: 0x6330658 Offset: 0x632C658 VA: 0x6330658
	|-ExposedList<Vector3>.Pop
	|
	|-RVA: 0x6334488 Offset: 0x6330488 VA: 0x6334488
	|-ExposedList<__Il2CppFullySharedGenericType>.Pop
	*/

	// RVA: -1 Offset: -1
	public void RemoveRange(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631D60C Offset: 0x631960C VA: 0x631D60C
	|-ExposedList<bool>.RemoveRange
	|
	|-RVA: 0x63200C8 Offset: 0x631C0C8 VA: 0x63200C8
	|-ExposedList<Color32>.RemoveRange
	|
	|-RVA: 0x6322B54 Offset: 0x631EB54 VA: 0x6322B54
	|-ExposedList<int>.RemoveRange
	|
	|-RVA: 0x6325638 Offset: 0x6321638 VA: 0x6325638
	|-ExposedList<object>.RemoveRange
	|
	|-RVA: 0x63280A0 Offset: 0x63240A0 VA: 0x63280A0
	|-ExposedList<float>.RemoveRange
	|
	|-RVA: 0x632B008 Offset: 0x6327008 VA: 0x632B008
	|-ExposedList<SubmeshInstruction>.RemoveRange
	|
	|-RVA: 0x632DB3C Offset: 0x6329B3C VA: 0x632DB3C
	|-ExposedList<Vector2>.RemoveRange
	|
	|-RVA: 0x6330704 Offset: 0x632C704 VA: 0x6330704
	|-ExposedList<Vector3>.RemoveRange
	|
	|-RVA: 0x633467C Offset: 0x633067C VA: 0x633467C
	|-ExposedList<__Il2CppFullySharedGenericType>.RemoveRange
	*/

	// RVA: -1 Offset: -1
	public void Reverse() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631D674 Offset: 0x6319674 VA: 0x631D674
	|-ExposedList<bool>.Reverse
	|
	|-RVA: 0x6320130 Offset: 0x631C130 VA: 0x6320130
	|-ExposedList<Color32>.Reverse
	|
	|-RVA: 0x6322BBC Offset: 0x631EBBC VA: 0x6322BBC
	|-ExposedList<int>.Reverse
	|
	|-RVA: 0x63256A0 Offset: 0x63216A0 VA: 0x63256A0
	|-ExposedList<object>.Reverse
	|
	|-RVA: 0x6328108 Offset: 0x6324108 VA: 0x6328108
	|-ExposedList<float>.Reverse
	|
	|-RVA: 0x632B070 Offset: 0x6327070 VA: 0x632B070
	|-ExposedList<SubmeshInstruction>.Reverse
	|
	|-RVA: 0x632DBA4 Offset: 0x6329BA4 VA: 0x632DBA4
	|-ExposedList<Vector2>.Reverse
	|
	|-RVA: 0x633076C Offset: 0x632C76C VA: 0x633076C
	|-ExposedList<Vector3>.Reverse
	|
	|-RVA: 0x6334704 Offset: 0x6330704 VA: 0x6334704
	|-ExposedList<__Il2CppFullySharedGenericType>.Reverse
	*/

	// RVA: -1 Offset: -1
	public void Reverse(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631D6AC Offset: 0x63196AC VA: 0x631D6AC
	|-ExposedList<bool>.Reverse
	|
	|-RVA: 0x6320168 Offset: 0x631C168 VA: 0x6320168
	|-ExposedList<Color32>.Reverse
	|
	|-RVA: 0x6322BF4 Offset: 0x631EBF4 VA: 0x6322BF4
	|-ExposedList<int>.Reverse
	|
	|-RVA: 0x63256D8 Offset: 0x63216D8 VA: 0x63256D8
	|-ExposedList<object>.Reverse
	|
	|-RVA: 0x6328140 Offset: 0x6324140 VA: 0x6328140
	|-ExposedList<float>.Reverse
	|
	|-RVA: 0x632B0A8 Offset: 0x63270A8 VA: 0x632B0A8
	|-ExposedList<SubmeshInstruction>.Reverse
	|
	|-RVA: 0x632DBDC Offset: 0x6329BDC VA: 0x632DBDC
	|-ExposedList<Vector2>.Reverse
	|
	|-RVA: 0x63307A4 Offset: 0x632C7A4 VA: 0x63307A4
	|-ExposedList<Vector3>.Reverse
	|
	|-RVA: 0x6334740 Offset: 0x6330740 VA: 0x6334740
	|-ExposedList<__Il2CppFullySharedGenericType>.Reverse
	*/

	// RVA: -1 Offset: -1
	public void Sort() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631D710 Offset: 0x6319710 VA: 0x631D710
	|-ExposedList<bool>.Sort
	|
	|-RVA: 0x63201CC Offset: 0x631C1CC VA: 0x63201CC
	|-ExposedList<Color32>.Sort
	|
	|-RVA: 0x6322C58 Offset: 0x631EC58 VA: 0x6322C58
	|-ExposedList<int>.Sort
	|
	|-RVA: 0x632573C Offset: 0x632173C VA: 0x632573C
	|-ExposedList<object>.Sort
	|
	|-RVA: 0x63281A4 Offset: 0x63241A4 VA: 0x63281A4
	|-ExposedList<float>.Sort
	|
	|-RVA: 0x632B10C Offset: 0x632710C VA: 0x632B10C
	|-ExposedList<SubmeshInstruction>.Sort
	|
	|-RVA: 0x632DC40 Offset: 0x6329C40 VA: 0x632DC40
	|-ExposedList<Vector2>.Sort
	|
	|-RVA: 0x6330808 Offset: 0x632C808 VA: 0x6330808
	|-ExposedList<Vector3>.Sort
	|
	|-RVA: 0x63347AC Offset: 0x63307AC VA: 0x63347AC
	|-ExposedList<__Il2CppFullySharedGenericType>.Sort
	*/

	// RVA: -1 Offset: -1
	public void Sort(IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631D778 Offset: 0x6319778 VA: 0x631D778
	|-ExposedList<bool>.Sort
	|
	|-RVA: 0x6320234 Offset: 0x631C234 VA: 0x6320234
	|-ExposedList<Color32>.Sort
	|
	|-RVA: 0x6322CC0 Offset: 0x631ECC0 VA: 0x6322CC0
	|-ExposedList<int>.Sort
	|
	|-RVA: 0x63257A4 Offset: 0x63217A4 VA: 0x63257A4
	|-ExposedList<object>.Sort
	|
	|-RVA: 0x632820C Offset: 0x632420C VA: 0x632820C
	|-ExposedList<float>.Sort
	|
	|-RVA: 0x632B174 Offset: 0x6327174 VA: 0x632B174
	|-ExposedList<SubmeshInstruction>.Sort
	|
	|-RVA: 0x632DCA8 Offset: 0x6329CA8 VA: 0x632DCA8
	|-ExposedList<Vector2>.Sort
	|
	|-RVA: 0x6330870 Offset: 0x632C870 VA: 0x6330870
	|-ExposedList<Vector3>.Sort
	|
	|-RVA: 0x633481C Offset: 0x633081C VA: 0x633481C
	|-ExposedList<__Il2CppFullySharedGenericType>.Sort
	*/

	// RVA: -1 Offset: -1
	public void Sort(Comparison<T> comparison) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631D7B4 Offset: 0x63197B4 VA: 0x631D7B4
	|-ExposedList<bool>.Sort
	|
	|-RVA: 0x6320270 Offset: 0x631C270 VA: 0x6320270
	|-ExposedList<Color32>.Sort
	|
	|-RVA: 0x6322CFC Offset: 0x631ECFC VA: 0x6322CFC
	|-ExposedList<int>.Sort
	|
	|-RVA: 0x63257E0 Offset: 0x63217E0 VA: 0x63257E0
	|-ExposedList<object>.Sort
	|
	|-RVA: 0x6328248 Offset: 0x6324248 VA: 0x6328248
	|-ExposedList<float>.Sort
	|
	|-RVA: 0x632B1B0 Offset: 0x63271B0 VA: 0x632B1B0
	|-ExposedList<SubmeshInstruction>.Sort
	|
	|-RVA: 0x632DCE4 Offset: 0x6329CE4 VA: 0x632DCE4
	|-ExposedList<Vector2>.Sort
	|
	|-RVA: 0x63308AC Offset: 0x632C8AC VA: 0x63308AC
	|-ExposedList<Vector3>.Sort
	|
	|-RVA: 0x633485C Offset: 0x633085C VA: 0x633485C
	|-ExposedList<__Il2CppFullySharedGenericType>.Sort
	*/

	// RVA: -1 Offset: -1
	public void Sort(int index, int count, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631D7E4 Offset: 0x63197E4 VA: 0x631D7E4
	|-ExposedList<bool>.Sort
	|
	|-RVA: 0x63202A0 Offset: 0x631C2A0 VA: 0x63202A0
	|-ExposedList<Color32>.Sort
	|
	|-RVA: 0x6322D2C Offset: 0x631ED2C VA: 0x6322D2C
	|-ExposedList<int>.Sort
	|
	|-RVA: 0x6325810 Offset: 0x6321810 VA: 0x6325810
	|-ExposedList<object>.Sort
	|
	|-RVA: 0x6328278 Offset: 0x6324278 VA: 0x6328278
	|-ExposedList<float>.Sort
	|
	|-RVA: 0x632B1E0 Offset: 0x63271E0 VA: 0x632B1E0
	|-ExposedList<SubmeshInstruction>.Sort
	|
	|-RVA: 0x632DD14 Offset: 0x6329D14 VA: 0x632DD14
	|-ExposedList<Vector2>.Sort
	|
	|-RVA: 0x63308DC Offset: 0x632C8DC VA: 0x63308DC
	|-ExposedList<Vector3>.Sort
	|
	|-RVA: 0x6334890 Offset: 0x6330890 VA: 0x6334890
	|-ExposedList<__Il2CppFullySharedGenericType>.Sort
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631D850 Offset: 0x6319850 VA: 0x631D850
	|-ExposedList<bool>.ToArray
	|
	|-RVA: 0x632030C Offset: 0x631C30C VA: 0x632030C
	|-ExposedList<Color32>.ToArray
	|
	|-RVA: 0x6322D98 Offset: 0x631ED98 VA: 0x6322D98
	|-ExposedList<int>.ToArray
	|
	|-RVA: 0x632587C Offset: 0x632187C VA: 0x632587C
	|-ExposedList<object>.ToArray
	|
	|-RVA: 0x63282E4 Offset: 0x63242E4 VA: 0x63282E4
	|-ExposedList<float>.ToArray
	|
	|-RVA: 0x632B24C Offset: 0x632724C VA: 0x632B24C
	|-ExposedList<SubmeshInstruction>.ToArray
	|
	|-RVA: 0x632DD80 Offset: 0x6329D80 VA: 0x632DD80
	|-ExposedList<Vector2>.ToArray
	|
	|-RVA: 0x6330948 Offset: 0x632C948 VA: 0x6330948
	|-ExposedList<Vector3>.ToArray
	|
	|-RVA: 0x6334904 Offset: 0x6330904 VA: 0x6334904
	|-ExposedList<__Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public void TrimExcess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631D8AC Offset: 0x63198AC VA: 0x631D8AC
	|-ExposedList<bool>.TrimExcess
	|
	|-RVA: 0x6320368 Offset: 0x631C368 VA: 0x6320368
	|-ExposedList<Color32>.TrimExcess
	|
	|-RVA: 0x6322DF4 Offset: 0x631EDF4 VA: 0x6322DF4
	|-ExposedList<int>.TrimExcess
	|
	|-RVA: 0x63258D8 Offset: 0x63218D8 VA: 0x63258D8
	|-ExposedList<object>.TrimExcess
	|
	|-RVA: 0x6328340 Offset: 0x6324340 VA: 0x6328340
	|-ExposedList<float>.TrimExcess
	|
	|-RVA: 0x632B2A8 Offset: 0x63272A8 VA: 0x632B2A8
	|-ExposedList<SubmeshInstruction>.TrimExcess
	|
	|-RVA: 0x632DDDC Offset: 0x6329DDC VA: 0x632DDDC
	|-ExposedList<Vector2>.TrimExcess
	|
	|-RVA: 0x63309A4 Offset: 0x632C9A4 VA: 0x63309A4
	|-ExposedList<Vector3>.TrimExcess
	|
	|-RVA: 0x6334960 Offset: 0x6330960 VA: 0x6334960
	|-ExposedList<__Il2CppFullySharedGenericType>.TrimExcess
	*/

	// RVA: -1 Offset: -1
	public bool TrueForAll(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631D8C0 Offset: 0x63198C0 VA: 0x631D8C0
	|-ExposedList<bool>.TrueForAll
	|
	|-RVA: 0x632037C Offset: 0x631C37C VA: 0x632037C
	|-ExposedList<Color32>.TrueForAll
	|
	|-RVA: 0x6322E08 Offset: 0x631EE08 VA: 0x6322E08
	|-ExposedList<int>.TrueForAll
	|
	|-RVA: 0x63258EC Offset: 0x63218EC VA: 0x63258EC
	|-ExposedList<object>.TrueForAll
	|
	|-RVA: 0x6328354 Offset: 0x6324354 VA: 0x6328354
	|-ExposedList<float>.TrueForAll
	|
	|-RVA: 0x632B2BC Offset: 0x63272BC VA: 0x632B2BC
	|-ExposedList<SubmeshInstruction>.TrueForAll
	|
	|-RVA: 0x632DDF0 Offset: 0x6329DF0 VA: 0x632DDF0
	|-ExposedList<Vector2>.TrueForAll
	|
	|-RVA: 0x63309B8 Offset: 0x632C9B8 VA: 0x63309B8
	|-ExposedList<Vector3>.TrueForAll
	|
	|-RVA: 0x6334978 Offset: 0x6330978 VA: 0x6334978
	|-ExposedList<__Il2CppFullySharedGenericType>.TrueForAll
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631D990 Offset: 0x6319990 VA: 0x631D990
	|-ExposedList<bool>.get_Capacity
	|
	|-RVA: 0x6320448 Offset: 0x631C448 VA: 0x6320448
	|-ExposedList<Color32>.get_Capacity
	|
	|-RVA: 0x6322ED4 Offset: 0x631EED4 VA: 0x6322ED4
	|-ExposedList<int>.get_Capacity
	|
	|-RVA: 0x63259B8 Offset: 0x63219B8 VA: 0x63259B8
	|-ExposedList<object>.get_Capacity
	|
	|-RVA: 0x6328420 Offset: 0x6324420 VA: 0x6328420
	|-ExposedList<float>.get_Capacity
	|
	|-RVA: 0x632B3C0 Offset: 0x63273C0 VA: 0x632B3C0
	|-ExposedList<SubmeshInstruction>.get_Capacity
	|
	|-RVA: 0x632DECC Offset: 0x6329ECC VA: 0x632DECC
	|-ExposedList<Vector2>.get_Capacity
	|
	|-RVA: 0x6330A98 Offset: 0x632CA98 VA: 0x6330A98
	|-ExposedList<Vector3>.get_Capacity
	|
	|-RVA: 0x6334AE8 Offset: 0x6330AE8 VA: 0x6334AE8
	|-ExposedList<__Il2CppFullySharedGenericType>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631D9AC Offset: 0x63199AC VA: 0x631D9AC
	|-ExposedList<bool>.set_Capacity
	|
	|-RVA: 0x6320464 Offset: 0x631C464 VA: 0x6320464
	|-ExposedList<Color32>.set_Capacity
	|
	|-RVA: 0x6322EF0 Offset: 0x631EEF0 VA: 0x6322EF0
	|-ExposedList<int>.set_Capacity
	|
	|-RVA: 0x63259D4 Offset: 0x63219D4 VA: 0x63259D4
	|-ExposedList<object>.set_Capacity
	|
	|-RVA: 0x632843C Offset: 0x632443C VA: 0x632843C
	|-ExposedList<float>.set_Capacity
	|
	|-RVA: 0x632B3DC Offset: 0x63273DC VA: 0x632B3DC
	|-ExposedList<SubmeshInstruction>.set_Capacity
	|
	|-RVA: 0x632DEE8 Offset: 0x6329EE8 VA: 0x632DEE8
	|-ExposedList<Vector2>.set_Capacity
	|
	|-RVA: 0x6330AB4 Offset: 0x632CAB4 VA: 0x6330AB4
	|-ExposedList<Vector3>.set_Capacity
	|
	|-RVA: 0x6334B04 Offset: 0x6330B04 VA: 0x6334B04
	|-ExposedList<__Il2CppFullySharedGenericType>.set_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631DA08 Offset: 0x6319A08 VA: 0x631DA08
	|-ExposedList<bool>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x63204C0 Offset: 0x631C4C0 VA: 0x63204C0
	|-ExposedList<Color32>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x6322F4C Offset: 0x631EF4C VA: 0x6322F4C
	|-ExposedList<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x6325A30 Offset: 0x6321A30 VA: 0x6325A30
	|-ExposedList<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x6328498 Offset: 0x6324498 VA: 0x6328498
	|-ExposedList<float>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x632B438 Offset: 0x6327438 VA: 0x632B438
	|-ExposedList<SubmeshInstruction>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x632DF44 Offset: 0x6329F44 VA: 0x632DF44
	|-ExposedList<Vector2>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x6330B10 Offset: 0x632CB10 VA: 0x6330B10
	|-ExposedList<Vector3>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x6334B64 Offset: 0x6330B64 VA: 0x6334B64
	|-ExposedList<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631DA78 Offset: 0x6319A78 VA: 0x631DA78
	|-ExposedList<bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x6320530 Offset: 0x631C530 VA: 0x6320530
	|-ExposedList<Color32>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x6322FBC Offset: 0x631EFBC VA: 0x6322FBC
	|-ExposedList<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x6325AA0 Offset: 0x6321AA0 VA: 0x6325AA0
	|-ExposedList<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x6328508 Offset: 0x6324508 VA: 0x6328508
	|-ExposedList<float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x632B4AC Offset: 0x63274AC VA: 0x632B4AC
	|-ExposedList<SubmeshInstruction>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x632DFB4 Offset: 0x6329FB4 VA: 0x632DFB4
	|-ExposedList<Vector2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x6330B74 Offset: 0x632CB74 VA: 0x6330B74
	|-ExposedList<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x6334C08 Offset: 0x6330C08 VA: 0x6334C08
	|-ExposedList<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x631DAE8 Offset: 0x6319AE8 VA: 0x631DAE8
	|-ExposedList<bool>..cctor
	|
	|-RVA: 0x63205A0 Offset: 0x631C5A0 VA: 0x63205A0
	|-ExposedList<Color32>..cctor
	|
	|-RVA: 0x632302C Offset: 0x631F02C VA: 0x632302C
	|-ExposedList<int>..cctor
	|
	|-RVA: 0x6325B10 Offset: 0x6321B10 VA: 0x6325B10
	|-ExposedList<object>..cctor
	|
	|-RVA: 0x6328578 Offset: 0x6324578 VA: 0x6328578
	|-ExposedList<float>..cctor
	|
	|-RVA: 0x632B520 Offset: 0x6327520 VA: 0x632B520
	|-ExposedList<SubmeshInstruction>..cctor
	|
	|-RVA: 0x632E024 Offset: 0x632A024 VA: 0x632E024
	|-ExposedList<Vector2>..cctor
	|
	|-RVA: 0x6330BD8 Offset: 0x632CBD8 VA: 0x6330BD8
	|-ExposedList<Vector3>..cctor
	|
	|-RVA: 0x6334CAC Offset: 0x6330CAC VA: 0x6334CAC
	|-ExposedList<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Spine
public class IkConstraint : IUpdatable // TypeDefIndex: 23952
{
	// Fields
	internal readonly IkConstraintData data; // 0x10
	internal readonly ExposedList<Bone> bones; // 0x18
	internal Bone target; // 0x20
	internal int bendDirection; // 0x28
	internal bool compress; // 0x2C
	internal bool stretch; // 0x2D
	internal float mix; // 0x30
	internal float softness; // 0x34
	internal bool active; // 0x38

	// Properties
	public ExposedList<Bone> Bones { get; }
	public Bone Target { get; set; }
	public float Mix { get; set; }
	public float Softness { get; set; }
	public int BendDirection { get; set; }
	public bool Compress { get; set; }
	public bool Stretch { get; set; }
	public bool Active { get; }
	public IkConstraintData Data { get; }

	// Methods

	// RVA: 0x7F2F4A4 Offset: 0x7F2B4A4 VA: 0x7F2F4A4
	public void .ctor(IkConstraintData data, Skeleton skeleton) { }

	// RVA: 0x7F2F81C Offset: 0x7F2B81C VA: 0x7F2F81C
	public void .ctor(IkConstraint constraint, Skeleton skeleton) { }

	// RVA: 0x7F2FB84 Offset: 0x7F2BB84 VA: 0x7F2FB84 Slot: 4
	public void Update() { }

	// RVA: 0x7F30A2C Offset: 0x7F2CA2C VA: 0x7F30A2C
	public ExposedList<Bone> get_Bones() { }

	// RVA: 0x7F30A34 Offset: 0x7F2CA34 VA: 0x7F30A34
	public Bone get_Target() { }

	// RVA: 0x7F30A3C Offset: 0x7F2CA3C VA: 0x7F30A3C
	public void set_Target(Bone value) { }

	// RVA: 0x7F30A44 Offset: 0x7F2CA44 VA: 0x7F30A44
	public float get_Mix() { }

	// RVA: 0x7F30A4C Offset: 0x7F2CA4C VA: 0x7F30A4C
	public void set_Mix(float value) { }

	// RVA: 0x7F30A54 Offset: 0x7F2CA54 VA: 0x7F30A54
	public float get_Softness() { }

	// RVA: 0x7F30A5C Offset: 0x7F2CA5C VA: 0x7F30A5C
	public void set_Softness(float value) { }

	// RVA: 0x7F30A64 Offset: 0x7F2CA64 VA: 0x7F30A64
	public int get_BendDirection() { }

	// RVA: 0x7F30A6C Offset: 0x7F2CA6C VA: 0x7F30A6C
	public void set_BendDirection(int value) { }

	// RVA: 0x7F30A74 Offset: 0x7F2CA74 VA: 0x7F30A74
	public bool get_Compress() { }

	// RVA: 0x7F30A7C Offset: 0x7F2CA7C VA: 0x7F30A7C
	public void set_Compress(bool value) { }

	// RVA: 0x7F30A88 Offset: 0x7F2CA88 VA: 0x7F30A88
	public bool get_Stretch() { }

	// RVA: 0x7F30A90 Offset: 0x7F2CA90 VA: 0x7F30A90
	public void set_Stretch(bool value) { }

	// RVA: 0x7F30A9C Offset: 0x7F2CA9C VA: 0x7F30A9C Slot: 5
	public bool get_Active() { }

	// RVA: 0x7F30AA4 Offset: 0x7F2CAA4 VA: 0x7F30AA4
	public IkConstraintData get_Data() { }

	// RVA: 0x7F30AAC Offset: 0x7F2CAAC VA: 0x7F30AAC Slot: 3
	public override string ToString() { }

	// RVA: 0x7F2FC50 Offset: 0x7F2BC50 VA: 0x7F2FC50
	public static void Apply(Bone bone, float targetX, float targetY, bool compress, bool stretch, bool uniform, float alpha) { }

	// RVA: 0x7F30078 Offset: 0x7F2C078 VA: 0x7F30078
	public static void Apply(Bone parent, Bone child, float targetX, float targetY, int bendDir, bool stretch, bool uniform, float softness, float alpha) { }
}

// Namespace: Spine
public class IkConstraintData : ConstraintData // TypeDefIndex: 23953
{
	// Fields
	internal ExposedList<BoneData> bones; // 0x20
	internal BoneData target; // 0x28
	internal int bendDirection; // 0x30
	internal bool compress; // 0x34
	internal bool stretch; // 0x35
	internal bool uniform; // 0x36
	internal float mix; // 0x38
	internal float softness; // 0x3C

	// Properties
	public ExposedList<BoneData> Bones { get; }
	public BoneData Target { get; set; }
	public float Mix { get; set; }
	public float Softness { get; set; }
	public int BendDirection { get; set; }
	public bool Compress { get; set; }
	public bool Stretch { get; set; }
	public bool Uniform { get; set; }

	// Methods

	// RVA: 0x7F30AC8 Offset: 0x7F2CAC8 VA: 0x7F30AC8
	public void .ctor(string name) { }

	// RVA: 0x7F30B64 Offset: 0x7F2CB64 VA: 0x7F30B64
	public ExposedList<BoneData> get_Bones() { }

	// RVA: 0x7F30B6C Offset: 0x7F2CB6C VA: 0x7F30B6C
	public BoneData get_Target() { }

	// RVA: 0x7F30B74 Offset: 0x7F2CB74 VA: 0x7F30B74
	public void set_Target(BoneData value) { }

	// RVA: 0x7F30B7C Offset: 0x7F2CB7C VA: 0x7F30B7C
	public float get_Mix() { }

	// RVA: 0x7F30B84 Offset: 0x7F2CB84 VA: 0x7F30B84
	public void set_Mix(float value) { }

	// RVA: 0x7F30B8C Offset: 0x7F2CB8C VA: 0x7F30B8C
	public float get_Softness() { }

	// RVA: 0x7F30B94 Offset: 0x7F2CB94 VA: 0x7F30B94
	public void set_Softness(float value) { }

	// RVA: 0x7F30B9C Offset: 0x7F2CB9C VA: 0x7F30B9C
	public int get_BendDirection() { }

	// RVA: 0x7F30BA4 Offset: 0x7F2CBA4 VA: 0x7F30BA4
	public void set_BendDirection(int value) { }

	// RVA: 0x7F30BAC Offset: 0x7F2CBAC VA: 0x7F30BAC
	public bool get_Compress() { }

	// RVA: 0x7F30BB4 Offset: 0x7F2CBB4 VA: 0x7F30BB4
	public void set_Compress(bool value) { }

	// RVA: 0x7F30BC0 Offset: 0x7F2CBC0 VA: 0x7F30BC0
	public bool get_Stretch() { }

	// RVA: 0x7F30BC8 Offset: 0x7F2CBC8 VA: 0x7F30BC8
	public void set_Stretch(bool value) { }

	// RVA: 0x7F30BD4 Offset: 0x7F2CBD4 VA: 0x7F30BD4
	public bool get_Uniform() { }

	// RVA: 0x7F30BDC Offset: 0x7F2CBDC VA: 0x7F30BDC
	public void set_Uniform(bool value) { }
}

// Namespace: Spine
public interface IUpdatable // TypeDefIndex: 23954
{
	// Properties
	public abstract bool Active { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Update();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_Active();
}

// Namespace: Spine
public static class Json // TypeDefIndex: 23955
{
	// Methods

	// RVA: 0x7F30BE8 Offset: 0x7F2CBE8 VA: 0x7F30BE8
	public static object Deserialize(TextReader text) { }
}

// Namespace: Spine
public static class MathUtils // TypeDefIndex: 23956
{
	// Fields
	public const float PI = 3.1415927;
	public const float PI2 = 6.2831855;
	public const float RadDeg = 57.295776;
	public const float DegRad = 0.017453292;
	private static Random random; // 0x0

	// Methods

	// RVA: 0x7F2E8C0 Offset: 0x7F2A8C0 VA: 0x7F2E8C0
	public static float Sin(float radians) { }

	// RVA: 0x7F2E85C Offset: 0x7F2A85C VA: 0x7F2E85C
	public static float Cos(float radians) { }

	// RVA: 0x7F2CD20 Offset: 0x7F28D20 VA: 0x7F2CD20
	public static float SinDeg(float degrees) { }

	// RVA: 0x7F2CCB0 Offset: 0x7F28CB0 VA: 0x7F2CCB0
	public static float CosDeg(float degrees) { }

	// RVA: 0x7F2CD90 Offset: 0x7F28D90 VA: 0x7F2CD90
	public static float Atan2(float y, float x) { }

	// RVA: 0x7F30C70 Offset: 0x7F2CC70 VA: 0x7F30C70
	public static float Clamp(float value, float min, float max) { }

	// RVA: 0x7F30C90 Offset: 0x7F2CC90 VA: 0x7F30C90
	public static float RandomTriangle(float min, float max) { }

	// RVA: 0x7F30D00 Offset: 0x7F2CD00 VA: 0x7F30D00
	public static float RandomTriangle(float min, float max, float mode) { }

	// RVA: 0x7F30E04 Offset: 0x7F2CE04 VA: 0x7F30E04
	private static void .cctor() { }
}

// Namespace: Spine
public abstract class IInterpolation // TypeDefIndex: 23957
{
	// Fields
	public static IInterpolation Pow2; // 0x0
	public static IInterpolation Pow2Out; // 0x8

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract float Apply(float a);

	// RVA: 0x7F30E80 Offset: 0x7F2CE80 VA: 0x7F30E80
	public float Apply(float start, float end, float a) { }

	// RVA: 0x7F30EB8 Offset: 0x7F2CEB8 VA: 0x7F30EB8
	protected void .ctor() { }

	// RVA: 0x7F30EC0 Offset: 0x7F2CEC0 VA: 0x7F30EC0
	private static void .cctor() { }
}

// Namespace: Spine
public class Pow : IInterpolation // TypeDefIndex: 23958
{
	// Fields
	[CompilerGenerated]
	private float <Power>k__BackingField; // 0x10

	// Properties
	public float Power { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7F30FF0 Offset: 0x7F2CFF0 VA: 0x7F30FF0
	public float get_Power() { }

	[CompilerGenerated]
	// RVA: 0x7F30FF8 Offset: 0x7F2CFF8 VA: 0x7F30FF8
	public void set_Power(float value) { }

	// RVA: 0x7F30F80 Offset: 0x7F2CF80 VA: 0x7F30F80
	public void .ctor(float power) { }

	// RVA: 0x7F31000 Offset: 0x7F2D000 VA: 0x7F31000 Slot: 4
	protected override float Apply(float a) { }
}

// Namespace: Spine
public class PowOut : Pow // TypeDefIndex: 23959
{
	// Methods

	// RVA: 0x7F30FEC Offset: 0x7F2CFEC VA: 0x7F30FEC
	public void .ctor(float power) { }

	// RVA: 0x7F310E4 Offset: 0x7F2D0E4 VA: 0x7F310E4 Slot: 4
	protected override float Apply(float a) { }
}

// Namespace: Spine
public class PathConstraint : IUpdatable // TypeDefIndex: 23960
{
	// Fields
	private const int NONE = -1;
	private const int BEFORE = -2;
	private const int AFTER = -3;
	private const float Epsilon = 1E-05;
	internal readonly PathConstraintData data; // 0x10
	internal readonly ExposedList<Bone> bones; // 0x18
	internal Slot target; // 0x20
	internal float position; // 0x28
	internal float spacing; // 0x2C
	internal float mixRotate; // 0x30
	internal float mixX; // 0x34
	internal float mixY; // 0x38
	internal bool active; // 0x3C
	internal readonly ExposedList<float> spaces; // 0x40
	internal readonly ExposedList<float> positions; // 0x48
	internal readonly ExposedList<float> world; // 0x50
	internal readonly ExposedList<float> curves; // 0x58
	internal readonly ExposedList<float> lengths; // 0x60
	internal readonly float[] segments; // 0x68

	// Properties
	public float Position { get; set; }
	public float Spacing { get; set; }
	public float MixRotate { get; set; }
	public float MixX { get; set; }
	public float MixY { get; set; }
	public ExposedList<Bone> Bones { get; }
	public Slot Target { get; set; }
	public bool Active { get; }
	public PathConstraintData Data { get; }

	// Methods

	// RVA: 0x7F31188 Offset: 0x7F2D188 VA: 0x7F31188
	public void .ctor(PathConstraintData data, Skeleton skeleton) { }

	// RVA: 0x7F315B8 Offset: 0x7F2D5B8 VA: 0x7F315B8
	public void .ctor(PathConstraint constraint, Skeleton skeleton) { }

	// RVA: 0x7F319DC Offset: 0x7F2D9DC VA: 0x7F319DC
	public static void ArraysFill(float[] a, int fromIndex, int toIndex, float val) { }

	// RVA: 0x7F31A28 Offset: 0x7F2DA28 VA: 0x7F31A28 Slot: 4
	public void Update() { }

	// RVA: 0x7F32334 Offset: 0x7F2E334 VA: 0x7F32334
	private float[] ComputeWorldPositions(PathAttachment path, int spacesCount, bool tangents) { }

	// RVA: 0x7F33064 Offset: 0x7F2F064 VA: 0x7F33064
	private static void AddBeforePosition(float p, float[] temp, int i, float[] output, int o) { }

	// RVA: 0x7F331B4 Offset: 0x7F2F1B4 VA: 0x7F331B4
	private static void AddAfterPosition(float p, float[] temp, int i, float[] output, int o) { }

	// RVA: 0x7F33304 Offset: 0x7F2F304 VA: 0x7F33304
	private static void AddCurvePosition(float p, float x1, float y1, float cx1, float cy1, float cx2, float cy2, float x2, float y2, float[] output, int o, bool tangents) { }

	// RVA: 0x7F3354C Offset: 0x7F2F54C VA: 0x7F3354C
	public float get_Position() { }

	// RVA: 0x7F33554 Offset: 0x7F2F554 VA: 0x7F33554
	public void set_Position(float value) { }

	// RVA: 0x7F3355C Offset: 0x7F2F55C VA: 0x7F3355C
	public float get_Spacing() { }

	// RVA: 0x7F33564 Offset: 0x7F2F564 VA: 0x7F33564
	public void set_Spacing(float value) { }

	// RVA: 0x7F3356C Offset: 0x7F2F56C VA: 0x7F3356C
	public float get_MixRotate() { }

	// RVA: 0x7F33574 Offset: 0x7F2F574 VA: 0x7F33574
	public void set_MixRotate(float value) { }

	// RVA: 0x7F3357C Offset: 0x7F2F57C VA: 0x7F3357C
	public float get_MixX() { }

	// RVA: 0x7F33584 Offset: 0x7F2F584 VA: 0x7F33584
	public void set_MixX(float value) { }

	// RVA: 0x7F3358C Offset: 0x7F2F58C VA: 0x7F3358C
	public float get_MixY() { }

	// RVA: 0x7F33594 Offset: 0x7F2F594 VA: 0x7F33594
	public void set_MixY(float value) { }

	// RVA: 0x7F3359C Offset: 0x7F2F59C VA: 0x7F3359C
	public ExposedList<Bone> get_Bones() { }

	// RVA: 0x7F335A4 Offset: 0x7F2F5A4 VA: 0x7F335A4
	public Slot get_Target() { }

	// RVA: 0x7F335AC Offset: 0x7F2F5AC VA: 0x7F335AC
	public void set_Target(Slot value) { }

	// RVA: 0x7F335B4 Offset: 0x7F2F5B4 VA: 0x7F335B4 Slot: 5
	public bool get_Active() { }

	// RVA: 0x7F335BC Offset: 0x7F2F5BC VA: 0x7F335BC
	public PathConstraintData get_Data() { }

	// RVA: 0x7F335C4 Offset: 0x7F2F5C4 VA: 0x7F335C4 Slot: 3
	public override string ToString() { }
}

// Namespace: Spine
public class PathConstraintData : ConstraintData // TypeDefIndex: 23961
{
	// Fields
	internal ExposedList<BoneData> bones; // 0x20
	internal SlotData target; // 0x28
	internal PositionMode positionMode; // 0x30
	internal SpacingMode spacingMode; // 0x34
	internal RotateMode rotateMode; // 0x38
	internal float offsetRotation; // 0x3C
	internal float position; // 0x40
	internal float spacing; // 0x44
	internal float mixRotate; // 0x48
	internal float mixX; // 0x4C
	internal float mixY; // 0x50

	// Properties
	public ExposedList<BoneData> Bones { get; }
	public SlotData Target { get; set; }
	public PositionMode PositionMode { get; set; }
	public SpacingMode SpacingMode { get; set; }
	public RotateMode RotateMode { get; set; }
	public float OffsetRotation { get; set; }
	public float Position { get; set; }
	public float Spacing { get; set; }
	public float RotateMix { get; set; }
	public float MixX { get; set; }
	public float MixY { get; set; }

	// Methods

	// RVA: 0x7F335E0 Offset: 0x7F2F5E0 VA: 0x7F335E0
	public void .ctor(string name) { }

	// RVA: 0x7F3366C Offset: 0x7F2F66C VA: 0x7F3366C
	public ExposedList<BoneData> get_Bones() { }

	// RVA: 0x7F33674 Offset: 0x7F2F674 VA: 0x7F33674
	public SlotData get_Target() { }

	// RVA: 0x7F3367C Offset: 0x7F2F67C VA: 0x7F3367C
	public void set_Target(SlotData value) { }

	// RVA: 0x7F33684 Offset: 0x7F2F684 VA: 0x7F33684
	public PositionMode get_PositionMode() { }

	// RVA: 0x7F3368C Offset: 0x7F2F68C VA: 0x7F3368C
	public void set_PositionMode(PositionMode value) { }

	// RVA: 0x7F33694 Offset: 0x7F2F694 VA: 0x7F33694
	public SpacingMode get_SpacingMode() { }

	// RVA: 0x7F3369C Offset: 0x7F2F69C VA: 0x7F3369C
	public void set_SpacingMode(SpacingMode value) { }

	// RVA: 0x7F336A4 Offset: 0x7F2F6A4 VA: 0x7F336A4
	public RotateMode get_RotateMode() { }

	// RVA: 0x7F336AC Offset: 0x7F2F6AC VA: 0x7F336AC
	public void set_RotateMode(RotateMode value) { }

	// RVA: 0x7F336B4 Offset: 0x7F2F6B4 VA: 0x7F336B4
	public float get_OffsetRotation() { }

	// RVA: 0x7F336BC Offset: 0x7F2F6BC VA: 0x7F336BC
	public void set_OffsetRotation(float value) { }

	// RVA: 0x7F336C4 Offset: 0x7F2F6C4 VA: 0x7F336C4
	public float get_Position() { }

	// RVA: 0x7F336CC Offset: 0x7F2F6CC VA: 0x7F336CC
	public void set_Position(float value) { }

	// RVA: 0x7F336D4 Offset: 0x7F2F6D4 VA: 0x7F336D4
	public float get_Spacing() { }

	// RVA: 0x7F336DC Offset: 0x7F2F6DC VA: 0x7F336DC
	public void set_Spacing(float value) { }

	// RVA: 0x7F336E4 Offset: 0x7F2F6E4 VA: 0x7F336E4
	public float get_RotateMix() { }

	// RVA: 0x7F336EC Offset: 0x7F2F6EC VA: 0x7F336EC
	public void set_RotateMix(float value) { }

	// RVA: 0x7F336F4 Offset: 0x7F2F6F4 VA: 0x7F336F4
	public float get_MixX() { }

	// RVA: 0x7F336FC Offset: 0x7F2F6FC VA: 0x7F336FC
	public void set_MixX(float value) { }

	// RVA: 0x7F33704 Offset: 0x7F2F704 VA: 0x7F33704
	public float get_MixY() { }

	// RVA: 0x7F3370C Offset: 0x7F2F70C VA: 0x7F3370C
	public void set_MixY(float value) { }
}

// Namespace: Spine
public enum PositionMode // TypeDefIndex: 23962
{
	// Fields
	public int value__; // 0x0
	public const PositionMode Fixed = 0;
	public const PositionMode Percent = 1;
}

// Namespace: Spine
public enum SpacingMode // TypeDefIndex: 23963
{
	// Fields
	public int value__; // 0x0
	public const SpacingMode Length = 0;
	public const SpacingMode Fixed = 1;
	public const SpacingMode Percent = 2;
	public const SpacingMode Proportional = 3;
}

// Namespace: Spine
public enum RotateMode // TypeDefIndex: 23964
{
	// Fields
	public int value__; // 0x0
	public const RotateMode Tangent = 0;
	public const RotateMode Chain = 1;
	public const RotateMode ChainScale = 2;
}

// Namespace: Spine
public class Skeleton // TypeDefIndex: 23965
{
	// Fields
	internal SkeletonData data; // 0x10
	internal ExposedList<Bone> bones; // 0x18
	internal ExposedList<Slot> slots; // 0x20
	internal ExposedList<Slot> drawOrder; // 0x28
	internal ExposedList<IkConstraint> ikConstraints; // 0x30
	internal ExposedList<TransformConstraint> transformConstraints; // 0x38
	internal ExposedList<PathConstraint> pathConstraints; // 0x40
	internal ExposedList<IUpdatable> updateCache; // 0x48
	internal Skin skin; // 0x50
	internal float r; // 0x58
	internal float g; // 0x5C
	internal float b; // 0x60
	internal float a; // 0x64
	private float scaleX; // 0x68
	private float scaleY; // 0x6C
	internal float x; // 0x70
	internal float y; // 0x74

	// Properties
	public SkeletonData Data { get; }
	public ExposedList<Bone> Bones { get; }
	public ExposedList<IUpdatable> UpdateCacheList { get; }
	public ExposedList<Slot> Slots { get; }
	public ExposedList<Slot> DrawOrder { get; }
	public ExposedList<IkConstraint> IkConstraints { get; }
	public ExposedList<PathConstraint> PathConstraints { get; }
	public ExposedList<TransformConstraint> TransformConstraints { get; }
	public Skin Skin { get; set; }
	public float R { get; set; }
	public float G { get; set; }
	public float B { get; set; }
	public float A { get; set; }
	public float X { get; set; }
	public float Y { get; set; }
	public float ScaleX { get; set; }
	public float ScaleY { get; set; }
	[Obsolete("Use ScaleX instead. FlipX is when ScaleX is negative.")]
	public bool FlipX { get; set; }
	[Obsolete("Use ScaleY instead. FlipY is when ScaleY is negative.")]
	public bool FlipY { get; set; }
	public Bone RootBone { get; }

	// Methods

	// RVA: 0x7F33714 Offset: 0x7F2F714 VA: 0x7F33714
	public SkeletonData get_Data() { }

	// RVA: 0x7F3371C Offset: 0x7F2F71C VA: 0x7F3371C
	public ExposedList<Bone> get_Bones() { }

	// RVA: 0x7F33724 Offset: 0x7F2F724 VA: 0x7F33724
	public ExposedList<IUpdatable> get_UpdateCacheList() { }

	// RVA: 0x7F3372C Offset: 0x7F2F72C VA: 0x7F3372C
	public ExposedList<Slot> get_Slots() { }

	// RVA: 0x7F33734 Offset: 0x7F2F734 VA: 0x7F33734
	public ExposedList<Slot> get_DrawOrder() { }

	// RVA: 0x7F3373C Offset: 0x7F2F73C VA: 0x7F3373C
	public ExposedList<IkConstraint> get_IkConstraints() { }

	// RVA: 0x7F33744 Offset: 0x7F2F744 VA: 0x7F33744
	public ExposedList<PathConstraint> get_PathConstraints() { }

	// RVA: 0x7F3374C Offset: 0x7F2F74C VA: 0x7F3374C
	public ExposedList<TransformConstraint> get_TransformConstraints() { }

	// RVA: 0x7F33754 Offset: 0x7F2F754 VA: 0x7F33754
	public Skin get_Skin() { }

	// RVA: 0x7F3375C Offset: 0x7F2F75C VA: 0x7F3375C
	public void set_Skin(Skin value) { }

	// RVA: 0x7F33860 Offset: 0x7F2F860 VA: 0x7F33860
	public float get_R() { }

	// RVA: 0x7F33868 Offset: 0x7F2F868 VA: 0x7F33868
	public void set_R(float value) { }

	// RVA: 0x7F33870 Offset: 0x7F2F870 VA: 0x7F33870
	public float get_G() { }

	// RVA: 0x7F33878 Offset: 0x7F2F878 VA: 0x7F33878
	public void set_G(float value) { }

	// RVA: 0x7F33880 Offset: 0x7F2F880 VA: 0x7F33880
	public float get_B() { }

	// RVA: 0x7F33888 Offset: 0x7F2F888 VA: 0x7F33888
	public void set_B(float value) { }

	// RVA: 0x7F33890 Offset: 0x7F2F890 VA: 0x7F33890
	public float get_A() { }

	// RVA: 0x7F33898 Offset: 0x7F2F898 VA: 0x7F33898
	public void set_A(float value) { }

	// RVA: 0x7F338A0 Offset: 0x7F2F8A0 VA: 0x7F338A0
	public float get_X() { }

	// RVA: 0x7F338A8 Offset: 0x7F2F8A8 VA: 0x7F338A8
	public void set_X(float value) { }

	// RVA: 0x7F338B0 Offset: 0x7F2F8B0 VA: 0x7F338B0
	public float get_Y() { }

	// RVA: 0x7F338B8 Offset: 0x7F2F8B8 VA: 0x7F338B8
	public void set_Y(float value) { }

	// RVA: 0x7F338C0 Offset: 0x7F2F8C0 VA: 0x7F338C0
	public float get_ScaleX() { }

	// RVA: 0x7F338C8 Offset: 0x7F2F8C8 VA: 0x7F338C8
	public void set_ScaleX(float value) { }

	// RVA: 0x7F2E800 Offset: 0x7F2A800 VA: 0x7F2E800
	public float get_ScaleY() { }

	// RVA: 0x7F338D0 Offset: 0x7F2F8D0 VA: 0x7F338D0
	public void set_ScaleY(float value) { }

	// RVA: 0x7F338D8 Offset: 0x7F2F8D8 VA: 0x7F338D8
	public bool get_FlipX() { }

	// RVA: 0x7F338E8 Offset: 0x7F2F8E8 VA: 0x7F338E8
	public void set_FlipX(bool value) { }

	// RVA: 0x7F33910 Offset: 0x7F2F910 VA: 0x7F33910
	public bool get_FlipY() { }

	// RVA: 0x7F33920 Offset: 0x7F2F920 VA: 0x7F33920
	public void set_FlipY(bool value) { }

	// RVA: 0x7F33948 Offset: 0x7F2F948 VA: 0x7F33948
	public Bone get_RootBone() { }

	// RVA: 0x7F33988 Offset: 0x7F2F988 VA: 0x7F33988
	public void .ctor(SkeletonData data) { }

	// RVA: 0x7F34824 Offset: 0x7F30824 VA: 0x7F34824
	public void .ctor(Skeleton skeleton) { }

	// RVA: 0x7F3454C Offset: 0x7F3054C VA: 0x7F3454C
	public void UpdateCache() { }

	// RVA: 0x7F35548 Offset: 0x7F31548 VA: 0x7F35548
	private void SortIkConstraint(IkConstraint constraint) { }

	// RVA: 0x7F356F8 Offset: 0x7F316F8 VA: 0x7F356F8
	private void SortTransformConstraint(TransformConstraint constraint) { }

	// RVA: 0x7F35920 Offset: 0x7F31920 VA: 0x7F35920
	private void SortPathConstraint(PathConstraint constraint) { }

	// RVA: 0x7F35C8C Offset: 0x7F31C8C VA: 0x7F35C8C
	private void SortPathConstraintAttachment(Skin skin, int slotIndex, Bone slotBone) { }

	// RVA: 0x7F35F9C Offset: 0x7F31F9C VA: 0x7F35F9C
	private void SortPathConstraintAttachment(Attachment attachment, Bone slotBone) { }

	// RVA: 0x7F35B84 Offset: 0x7F31B84 VA: 0x7F35B84
	private void SortBone(Bone bone) { }

	// RVA: 0x7F35C0C Offset: 0x7F31C0C VA: 0x7F35C0C
	private static void SortReset(ExposedList<Bone> bones) { }

	// RVA: 0x7F36118 Offset: 0x7F32118 VA: 0x7F36118
	public void UpdateWorldTransform() { }

	// RVA: 0x7F36260 Offset: 0x7F32260 VA: 0x7F36260
	public void UpdateWorldTransform(Bone parent) { }

	// RVA: 0x7F364FC Offset: 0x7F324FC VA: 0x7F364FC
	public void SetToSetupPose() { }

	// RVA: 0x7F36514 Offset: 0x7F32514 VA: 0x7F36514
	public void SetBonesToSetupPose() { }

	// RVA: 0x7F366A8 Offset: 0x7F326A8 VA: 0x7F366A8
	public void SetSlotsToSetupPose() { }

	// RVA: 0x7F36734 Offset: 0x7F32734 VA: 0x7F36734
	public Bone FindBone(string boneName) { }

	// RVA: 0x7F36824 Offset: 0x7F32824 VA: 0x7F36824
	public Slot FindSlot(string slotName) { }

	// RVA: 0x7F36914 Offset: 0x7F32914 VA: 0x7F36914
	public void SetSkin(string skinName) { }

	// RVA: 0x7F33760 Offset: 0x7F2F760 VA: 0x7F33760
	public void SetSkin(Skin newSkin) { }

	// RVA: 0x7F369B8 Offset: 0x7F329B8 VA: 0x7F369B8
	public Attachment GetAttachment(string slotName, string attachmentName) { }

	// RVA: 0x7F369F8 Offset: 0x7F329F8 VA: 0x7F369F8
	public Attachment GetAttachment(int slotIndex, string attachmentName) { }

	// RVA: 0x7F36AC0 Offset: 0x7F32AC0 VA: 0x7F36AC0
	public void SetAttachment(string slotName, string attachmentName) { }

	// RVA: 0x7F36C6C Offset: 0x7F32C6C VA: 0x7F36C6C
	public IkConstraint FindIkConstraint(string constraintName) { }

	// RVA: 0x7F36D5C Offset: 0x7F32D5C VA: 0x7F36D5C
	public TransformConstraint FindTransformConstraint(string constraintName) { }

	// RVA: 0x7F36E4C Offset: 0x7F32E4C VA: 0x7F36E4C
	public PathConstraint FindPathConstraint(string constraintName) { }

	// RVA: 0x7F36F40 Offset: 0x7F32F40 VA: 0x7F36F40
	public void GetBounds(out float x, out float y, out float width, out float height, ref float[] vertexBuffer) { }
}

// Namespace: 
internal class SkeletonBinary.Vertices // TypeDefIndex: 23966
{
	// Fields
	public int[] bones; // 0x10
	public float[] vertices; // 0x18

	// Methods

	// RVA: 0x7F3D82C Offset: 0x7F3982C VA: 0x7F3D82C
	public void .ctor() { }
}

// Namespace: 
internal class SkeletonBinary.SkeletonInput // TypeDefIndex: 23967
{
	// Fields
	private byte[] chars; // 0x10
	private byte[] bytesBigEndian; // 0x18
	internal string[] strings; // 0x20
	private Stream input; // 0x28

	// Methods

	// RVA: 0x7F38B9C Offset: 0x7F34B9C VA: 0x7F38B9C
	public void .ctor(Stream input) { }

	// RVA: 0x7F3D834 Offset: 0x7F39834 VA: 0x7F3D834
	public int Read() { }

	// RVA: 0x7F3D298 Offset: 0x7F39298 VA: 0x7F3D298
	public byte ReadByte() { }

	// RVA: 0x7F395C8 Offset: 0x7F355C8 VA: 0x7F395C8
	public sbyte ReadSByte() { }

	// RVA: 0x7F393F8 Offset: 0x7F353F8 VA: 0x7F393F8
	public bool ReadBoolean() { }

	// RVA: 0x7F392F8 Offset: 0x7F352F8 VA: 0x7F392F8
	public float ReadFloat() { }

	// RVA: 0x7F394F8 Offset: 0x7F354F8 VA: 0x7F394F8
	public int ReadInt() { }

	// RVA: 0x7F39150 Offset: 0x7F35150 VA: 0x7F39150
	public long ReadLong() { }

	// RVA: 0x7F39428 Offset: 0x7F35428 VA: 0x7F39428
	public int ReadInt(bool optimizePositive) { }

	// RVA: 0x7F39214 Offset: 0x7F35214 VA: 0x7F39214
	public string ReadString() { }

	// RVA: 0x7F3957C Offset: 0x7F3557C VA: 0x7F3957C
	public string ReadStringRef() { }

	// RVA: 0x7F3DCF0 Offset: 0x7F39CF0 VA: 0x7F3DCF0
	public void ReadFully(byte[] buffer, int offset, int length) { }

	// RVA: 0x7F38C38 Offset: 0x7F34C38 VA: 0x7F38C38
	public string GetVersionString() { }

	// RVA: 0x7F3DD98 Offset: 0x7F39D98 VA: 0x7F3DD98
	public string GetVersionStringOld3X() { }
}

// Namespace: Spine
public class SkeletonBinary : SkeletonLoader // TypeDefIndex: 23968
{
	// Fields
	public const int BONE_ROTATE = 0;
	public const int BONE_TRANSLATE = 1;
	public const int BONE_TRANSLATEX = 2;
	public const int BONE_TRANSLATEY = 3;
	public const int BONE_SCALE = 4;
	public const int BONE_SCALEX = 5;
	public const int BONE_SCALEY = 6;
	public const int BONE_SHEAR = 7;
	public const int BONE_SHEARX = 8;
	public const int BONE_SHEARY = 9;
	public const int SLOT_ATTACHMENT = 0;
	public const int SLOT_RGBA = 1;
	public const int SLOT_RGB = 2;
	public const int SLOT_RGBA2 = 3;
	public const int SLOT_RGB2 = 4;
	public const int SLOT_ALPHA = 5;
	public const int ATTACHMENT_DEFORM = 0;
	public const int ATTACHMENT_SEQUENCE = 1;
	public const int PATH_POSITION = 0;
	public const int PATH_SPACING = 1;
	public const int PATH_MIX = 2;
	public const int CURVE_LINEAR = 0;
	public const int CURVE_STEPPED = 1;
	public const int CURVE_BEZIER = 2;
	public static readonly TransformMode[] TransformModeValues; // 0x0

	// Methods

	// RVA: 0x7F37280 Offset: 0x7F33280 VA: 0x7F37280
	public void .ctor(AttachmentLoader attachmentLoader) { }

	// RVA: 0x7F37288 Offset: 0x7F33288 VA: 0x7F37288
	public void .ctor(Atlas[] atlasArray) { }

	// RVA: 0x7F37290 Offset: 0x7F33290 VA: 0x7F37290 Slot: 4
	public override SkeletonData ReadSkeletonData(string path) { }

	// RVA: 0x7F38AF0 Offset: 0x7F34AF0 VA: 0x7F38AF0
	public static string GetVersionString(Stream file) { }

	// RVA: 0x7F3748C Offset: 0x7F3348C VA: 0x7F3748C
	public SkeletonData ReadSkeletonData(Stream file) { }

	// RVA: 0x7F3962C Offset: 0x7F3562C VA: 0x7F3962C
	private Skin ReadSkin(SkeletonBinary.SkeletonInput input, SkeletonData skeletonData, bool defaultSkin, bool nonessential) { }

	// RVA: 0x7F3C6FC Offset: 0x7F386FC VA: 0x7F3C6FC
	private Attachment ReadAttachment(SkeletonBinary.SkeletonInput input, SkeletonData skeletonData, Skin skin, int slotIndex, string attachmentName, bool nonessential) { }

	// RVA: 0x7F3D2C0 Offset: 0x7F392C0 VA: 0x7F3D2C0
	private Sequence ReadSequence(SkeletonBinary.SkeletonInput input) { }

	// RVA: 0x7F3D390 Offset: 0x7F39390 VA: 0x7F3D390
	private SkeletonBinary.Vertices ReadVertices(SkeletonBinary.SkeletonInput input, int vertexCount) { }

	// RVA: 0x7F3D62C Offset: 0x7F3962C VA: 0x7F3D62C
	private float[] ReadFloatArray(SkeletonBinary.SkeletonInput input, int n, float scale) { }

	// RVA: 0x7F3D734 Offset: 0x7F39734 VA: 0x7F3D734
	private int[] ReadShortArray(SkeletonBinary.SkeletonInput input) { }

	// RVA: 0x7F39C04 Offset: 0x7F35C04 VA: 0x7F39C04
	private Animation ReadAnimation(string name, SkeletonBinary.SkeletonInput input, SkeletonData skeletonData) { }

	// RVA: 0x7F3D928 Offset: 0x7F39928 VA: 0x7F3D928
	private Timeline ReadTimeline(SkeletonBinary.SkeletonInput input, CurveTimeline1 timeline, float scale) { }

	// RVA: 0x7F3DA8C Offset: 0x7F39A8C VA: 0x7F3DA8C
	private Timeline ReadTimeline(SkeletonBinary.SkeletonInput input, CurveTimeline2 timeline, float scale) { }

	// RVA: 0x7F3D858 Offset: 0x7F39858 VA: 0x7F3D858
	private void SetBezier(SkeletonBinary.SkeletonInput input, CurveTimeline timeline, int bezier, int frame, int value, float time1, float time2, float value1, float value2, float scale) { }

	// RVA: 0x7F3DC50 Offset: 0x7F39C50 VA: 0x7F3DC50
	private static void .cctor() { }
}

// Namespace: Spine
public class SkeletonBounds // TypeDefIndex: 23969
{
	// Fields
	private ExposedList<Polygon> polygonPool; // 0x10
	private float minX; // 0x18
	private float minY; // 0x1C
	private float maxX; // 0x20
	private float maxY; // 0x24
	[CompilerGenerated]
	private ExposedList<BoundingBoxAttachment> <BoundingBoxes>k__BackingField; // 0x28
	[CompilerGenerated]
	private ExposedList<Polygon> <Polygons>k__BackingField; // 0x30

	// Properties
	public ExposedList<BoundingBoxAttachment> BoundingBoxes { get; set; }
	public ExposedList<Polygon> Polygons { get; set; }
	public float MinX { get; set; }
	public float MinY { get; set; }
	public float MaxX { get; set; }
	public float MaxY { get; set; }
	public float Width { get; }
	public float Height { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7F3DED8 Offset: 0x7F39ED8 VA: 0x7F3DED8
	public ExposedList<BoundingBoxAttachment> get_BoundingBoxes() { }

	[CompilerGenerated]
	// RVA: 0x7F3DEE0 Offset: 0x7F39EE0 VA: 0x7F3DEE0
	private void set_BoundingBoxes(ExposedList<BoundingBoxAttachment> value) { }

	[CompilerGenerated]
	// RVA: 0x7F3DEE8 Offset: 0x7F39EE8 VA: 0x7F3DEE8
	public ExposedList<Polygon> get_Polygons() { }

	[CompilerGenerated]
	// RVA: 0x7F3DEF0 Offset: 0x7F39EF0 VA: 0x7F3DEF0
	private void set_Polygons(ExposedList<Polygon> value) { }

	// RVA: 0x7F3DEF8 Offset: 0x7F39EF8 VA: 0x7F3DEF8
	public float get_MinX() { }

	// RVA: 0x7F3DF00 Offset: 0x7F39F00 VA: 0x7F3DF00
	public void set_MinX(float value) { }

	// RVA: 0x7F3DF08 Offset: 0x7F39F08 VA: 0x7F3DF08
	public float get_MinY() { }

	// RVA: 0x7F3DF10 Offset: 0x7F39F10 VA: 0x7F3DF10
	public void set_MinY(float value) { }

	// RVA: 0x7F3DF18 Offset: 0x7F39F18 VA: 0x7F3DF18
	public float get_MaxX() { }

	// RVA: 0x7F3DF20 Offset: 0x7F39F20 VA: 0x7F3DF20
	public void set_MaxX(float value) { }

	// RVA: 0x7F3DF28 Offset: 0x7F39F28 VA: 0x7F3DF28
	public float get_MaxY() { }

	// RVA: 0x7F3DF30 Offset: 0x7F39F30 VA: 0x7F3DF30
	public void set_MaxY(float value) { }

	// RVA: 0x7F3DF38 Offset: 0x7F39F38 VA: 0x7F3DF38
	public float get_Width() { }

	// RVA: 0x7F3DF48 Offset: 0x7F39F48 VA: 0x7F3DF48
	public float get_Height() { }

	// RVA: 0x7F3DF58 Offset: 0x7F39F58 VA: 0x7F3DF58
	public void .ctor() { }

	// RVA: 0x7F3E058 Offset: 0x7F3A058 VA: 0x7F3E058
	public void Update(Skeleton skeleton, bool updateAabb) { }

	// RVA: 0x7F3E3B8 Offset: 0x7F3A3B8 VA: 0x7F3E3B8
	private void AabbCompute() { }

	// RVA: 0x7F3E55C Offset: 0x7F3A55C VA: 0x7F3E55C
	public bool AabbContainsPoint(float x, float y) { }

	// RVA: 0x7F3E598 Offset: 0x7F3A598 VA: 0x7F3E598
	public bool AabbIntersectsSegment(float x1, float y1, float x2, float y2) { }

	// RVA: 0x7F3E674 Offset: 0x7F3A674 VA: 0x7F3E674
	public bool AabbIntersectsSkeleton(SkeletonBounds bounds) { }

	// RVA: 0x7F3E6D0 Offset: 0x7F3A6D0 VA: 0x7F3E6D0
	public bool ContainsPoint(Polygon polygon, float x, float y) { }

	// RVA: 0x7F3E7B8 Offset: 0x7F3A7B8 VA: 0x7F3E7B8
	public BoundingBoxAttachment ContainsPoint(float x, float y) { }

	// RVA: 0x7F3E86C Offset: 0x7F3A86C VA: 0x7F3E86C
	public BoundingBoxAttachment IntersectsSegment(float x1, float y1, float x2, float y2) { }

	// RVA: 0x7F3E938 Offset: 0x7F3A938 VA: 0x7F3E938
	public bool IntersectsSegment(Polygon polygon, float x1, float y1, float x2, float y2) { }

	// RVA: 0x7F3EAA8 Offset: 0x7F3AAA8 VA: 0x7F3EAA8
	public Polygon GetPolygon(BoundingBoxAttachment attachment) { }
}

// Namespace: Spine
public class Polygon // TypeDefIndex: 23970
{
	// Fields
	[CompilerGenerated]
	private float[] <Vertices>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x18

	// Properties
	public float[] Vertices { get; set; }
	public int Count { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x7F3EB3C Offset: 0x7F3AB3C VA: 0x7F3EB3C
	public float[] get_Vertices() { }

	[CompilerGenerated]
	// RVA: 0x7F3EB44 Offset: 0x7F3AB44 VA: 0x7F3EB44
	public void set_Vertices(float[] value) { }

	[CompilerGenerated]
	// RVA: 0x7F3EB4C Offset: 0x7F3AB4C VA: 0x7F3EB4C
	public int get_Count() { }

	[CompilerGenerated]
	// RVA: 0x7F3EB54 Offset: 0x7F3AB54 VA: 0x7F3EB54
	public void set_Count(int value) { }

	// RVA: 0x7F3E354 Offset: 0x7F3A354 VA: 0x7F3E354
	public void .ctor() { }
}

// Namespace: Spine
public class SkeletonClipping // TypeDefIndex: 23971
{
	// Fields
	internal readonly Triangulator triangulator; // 0x10
	internal readonly ExposedList<float> clippingPolygon; // 0x18
	internal readonly ExposedList<float> clipOutput; // 0x20
	internal readonly ExposedList<float> clippedVertices; // 0x28
	internal readonly ExposedList<int> clippedTriangles; // 0x30
	internal readonly ExposedList<float> clippedUVs; // 0x38
	internal readonly ExposedList<float> scratch; // 0x40
	internal ClippingAttachment clipAttachment; // 0x48
	internal ExposedList<ExposedList<float>> clippingPolygons; // 0x50

	// Properties
	public ExposedList<float> ClippedVertices { get; }
	public ExposedList<int> ClippedTriangles { get; }
	public ExposedList<float> ClippedUVs { get; }
	public bool IsClipping { get; }

	// Methods

	// RVA: 0x7F3EB5C Offset: 0x7F3AB5C VA: 0x7F3EB5C
	public ExposedList<float> get_ClippedVertices() { }

	// RVA: 0x7F3EB64 Offset: 0x7F3AB64 VA: 0x7F3EB64
	public ExposedList<int> get_ClippedTriangles() { }

	// RVA: 0x7F3EB6C Offset: 0x7F3AB6C VA: 0x7F3EB6C
	public ExposedList<float> get_ClippedUVs() { }

	// RVA: 0x7F3EB74 Offset: 0x7F3AB74 VA: 0x7F3EB74
	public bool get_IsClipping() { }

	// RVA: 0x7F3EB84 Offset: 0x7F3AB84 VA: 0x7F3EB84
	public int ClipStart(Slot slot, ClippingAttachment clip) { }

	// RVA: 0x7F3EF88 Offset: 0x7F3AF88 VA: 0x7F3EF88
	public void ClipEnd(Slot slot) { }

	// RVA: 0x7F3EFBC Offset: 0x7F3AFBC VA: 0x7F3EFBC
	public void ClipEnd() { }

	// RVA: 0x7F3F084 Offset: 0x7F3B084 VA: 0x7F3F084
	public void ClipTriangles(float[] vertices, int verticesLength, int[] triangles, int trianglesLength, float[] uvs) { }

	// RVA: 0x7F3F7FC Offset: 0x7F3B7FC VA: 0x7F3F7FC
	internal bool Clip(float x1, float y1, float x2, float y2, float x3, float y3, ExposedList<float> clippingArea, ExposedList<float> output) { }

	// RVA: 0x7F3EE40 Offset: 0x7F3AE40 VA: 0x7F3EE40
	public static void MakeClockwise(ExposedList<float> polygon) { }

	// RVA: 0x7F3FDCC Offset: 0x7F3BDCC VA: 0x7F3FDCC
	public void .ctor() { }
}

// Namespace: Spine
public class SkeletonData // TypeDefIndex: 23972
{
	// Fields
	internal string name; // 0x10
	internal ExposedList<BoneData> bones; // 0x18
	internal ExposedList<SlotData> slots; // 0x20
	internal ExposedList<Skin> skins; // 0x28
	internal Skin defaultSkin; // 0x30
	internal ExposedList<EventData> events; // 0x38
	internal ExposedList<Animation> animations; // 0x40
	internal ExposedList<IkConstraintData> ikConstraints; // 0x48
	internal ExposedList<TransformConstraintData> transformConstraints; // 0x50
	internal ExposedList<PathConstraintData> pathConstraints; // 0x58
	internal float x; // 0x60
	internal float y; // 0x64
	internal float width; // 0x68
	internal float height; // 0x6C
	internal string version; // 0x70
	internal string hash; // 0x78
	internal float fps; // 0x80
	internal string imagesPath; // 0x88
	internal string audioPath; // 0x90

	// Properties
	public string Name { get; set; }
	public ExposedList<BoneData> Bones { get; }
	public ExposedList<SlotData> Slots { get; }
	public ExposedList<Skin> Skins { get; set; }
	public Skin DefaultSkin { get; set; }
	public ExposedList<EventData> Events { get; set; }
	public ExposedList<Animation> Animations { get; set; }
	public ExposedList<IkConstraintData> IkConstraints { get; set; }
	public ExposedList<TransformConstraintData> TransformConstraints { get; set; }
	public ExposedList<PathConstraintData> PathConstraints { get; set; }
	public float X { get; set; }
	public float Y { get; set; }
	public float Width { get; set; }
	public float Height { get; set; }
	public string Version { get; set; }
	public string Hash { get; set; }
	public string ImagesPath { get; set; }
	public string AudioPath { get; set; }
	public float Fps { get; set; }

	// Methods

	// RVA: 0x7F3FF9C Offset: 0x7F3BF9C VA: 0x7F3FF9C
	public string get_Name() { }

	// RVA: 0x7F3FFA4 Offset: 0x7F3BFA4 VA: 0x7F3FFA4
	public void set_Name(string value) { }

	// RVA: 0x7F3FFAC Offset: 0x7F3BFAC VA: 0x7F3FFAC
	public ExposedList<BoneData> get_Bones() { }

	// RVA: 0x7F3FFB4 Offset: 0x7F3BFB4 VA: 0x7F3FFB4
	public ExposedList<SlotData> get_Slots() { }

	// RVA: 0x7F3FFBC Offset: 0x7F3BFBC VA: 0x7F3FFBC
	public ExposedList<Skin> get_Skins() { }

	// RVA: 0x7F3FFC4 Offset: 0x7F3BFC4 VA: 0x7F3FFC4
	public void set_Skins(ExposedList<Skin> value) { }

	// RVA: 0x7F3FFCC Offset: 0x7F3BFCC VA: 0x7F3FFCC
	public Skin get_DefaultSkin() { }

	// RVA: 0x7F3FFD4 Offset: 0x7F3BFD4 VA: 0x7F3FFD4
	public void set_DefaultSkin(Skin value) { }

	// RVA: 0x7F3FFDC Offset: 0x7F3BFDC VA: 0x7F3FFDC
	public ExposedList<EventData> get_Events() { }

	// RVA: 0x7F3FFE4 Offset: 0x7F3BFE4 VA: 0x7F3FFE4
	public void set_Events(ExposedList<EventData> value) { }

	// RVA: 0x7F3FFEC Offset: 0x7F3BFEC VA: 0x7F3FFEC
	public ExposedList<Animation> get_Animations() { }

	// RVA: 0x7F3FFF4 Offset: 0x7F3BFF4 VA: 0x7F3FFF4
	public void set_Animations(ExposedList<Animation> value) { }

	// RVA: 0x7F3FFFC Offset: 0x7F3BFFC VA: 0x7F3FFFC
	public ExposedList<IkConstraintData> get_IkConstraints() { }

	// RVA: 0x7F40004 Offset: 0x7F3C004 VA: 0x7F40004
	public void set_IkConstraints(ExposedList<IkConstraintData> value) { }

	// RVA: 0x7F4000C Offset: 0x7F3C00C VA: 0x7F4000C
	public ExposedList<TransformConstraintData> get_TransformConstraints() { }

	// RVA: 0x7F40014 Offset: 0x7F3C014 VA: 0x7F40014
	public void set_TransformConstraints(ExposedList<TransformConstraintData> value) { }

	// RVA: 0x7F4001C Offset: 0x7F3C01C VA: 0x7F4001C
	public ExposedList<PathConstraintData> get_PathConstraints() { }

	// RVA: 0x7F40024 Offset: 0x7F3C024 VA: 0x7F40024
	public void set_PathConstraints(ExposedList<PathConstraintData> value) { }

	// RVA: 0x7F4002C Offset: 0x7F3C02C VA: 0x7F4002C
	public float get_X() { }

	// RVA: 0x7F40034 Offset: 0x7F3C034 VA: 0x7F40034
	public void set_X(float value) { }

	// RVA: 0x7F4003C Offset: 0x7F3C03C VA: 0x7F4003C
	public float get_Y() { }

	// RVA: 0x7F40044 Offset: 0x7F3C044 VA: 0x7F40044
	public void set_Y(float value) { }

	// RVA: 0x7F4004C Offset: 0x7F3C04C VA: 0x7F4004C
	public float get_Width() { }

	// RVA: 0x7F40054 Offset: 0x7F3C054 VA: 0x7F40054
	public void set_Width(float value) { }

	// RVA: 0x7F4005C Offset: 0x7F3C05C VA: 0x7F4005C
	public float get_Height() { }

	// RVA: 0x7F40064 Offset: 0x7F3C064 VA: 0x7F40064
	public void set_Height(float value) { }

	// RVA: 0x7F4006C Offset: 0x7F3C06C VA: 0x7F4006C
	public string get_Version() { }

	// RVA: 0x7F40074 Offset: 0x7F3C074 VA: 0x7F40074
	public void set_Version(string value) { }

	// RVA: 0x7F4007C Offset: 0x7F3C07C VA: 0x7F4007C
	public string get_Hash() { }

	// RVA: 0x7F40084 Offset: 0x7F3C084 VA: 0x7F40084
	public void set_Hash(string value) { }

	// RVA: 0x7F4008C Offset: 0x7F3C08C VA: 0x7F4008C
	public string get_ImagesPath() { }

	// RVA: 0x7F40094 Offset: 0x7F3C094 VA: 0x7F40094
	public void set_ImagesPath(string value) { }

	// RVA: 0x7F4009C Offset: 0x7F3C09C VA: 0x7F4009C
	public string get_AudioPath() { }

	// RVA: 0x7F400A4 Offset: 0x7F3C0A4 VA: 0x7F400A4
	public void set_AudioPath(string value) { }

	// RVA: 0x7F400AC Offset: 0x7F3C0AC VA: 0x7F400AC
	public float get_Fps() { }

	// RVA: 0x7F400B4 Offset: 0x7F3C0B4 VA: 0x7F400B4
	public void set_Fps(float value) { }

	// RVA: 0x7F400BC Offset: 0x7F3C0BC VA: 0x7F400BC
	public BoneData FindBone(string boneName) { }

	// RVA: 0x7F401A4 Offset: 0x7F3C1A4 VA: 0x7F401A4
	public SlotData FindSlot(string slotName) { }

	// RVA: 0x7F39A48 Offset: 0x7F35A48 VA: 0x7F39A48
	public Skin FindSkin(string skinName) { }

	// RVA: 0x7F4028C Offset: 0x7F3C28C VA: 0x7F4028C
	public EventData FindEvent(string eventDataName) { }

	// RVA: 0x7F40448 Offset: 0x7F3C448 VA: 0x7F40448
	public Animation FindAnimation(string animationName) { }

	// RVA: 0x7F40530 Offset: 0x7F3C530 VA: 0x7F40530
	public IkConstraintData FindIkConstraint(string constraintName) { }

	// RVA: 0x7F40618 Offset: 0x7F3C618 VA: 0x7F40618
	public TransformConstraintData FindTransformConstraint(string constraintName) { }

	// RVA: 0x7F40700 Offset: 0x7F3C700 VA: 0x7F40700
	public PathConstraintData FindPathConstraint(string constraintName) { }

	// RVA: 0x7F407EC Offset: 0x7F3C7EC VA: 0x7F407EC Slot: 3
	public override string ToString() { }

	// RVA: 0x7F38E9C Offset: 0x7F34E9C VA: 0x7F38E9C
	public void .ctor() { }
}

// Namespace: Spine
public class SkeletonJson : SkeletonLoader // TypeDefIndex: 23973
{
	// Methods

	// RVA: 0x7F40804 Offset: 0x7F3C804 VA: 0x7F40804
	public void .ctor(AttachmentLoader attachmentLoader) { }

	// RVA: 0x7F4080C Offset: 0x7F3C80C VA: 0x7F4080C
	public void .ctor(Atlas[] atlasArray) { }

	// RVA: 0x7F40814 Offset: 0x7F3C814 VA: 0x7F40814 Slot: 4
	public override SkeletonData ReadSkeletonData(string path) { }

	// RVA: 0x7F40A3C Offset: 0x7F3CA3C VA: 0x7F40A3C
	public SkeletonData ReadSkeletonData(TextReader reader) { }

	// RVA: 0x7F452F8 Offset: 0x7F412F8 VA: 0x7F452F8
	private Attachment ReadAttachment(Dictionary<string, object> map, Skin skin, int slotIndex, string name, SkeletonData skeletonData) { }

	// RVA: 0x7F4BECC Offset: 0x7F47ECC VA: 0x7F4BECC
	public static Sequence ReadSequence(object sequenceJson) { }

	// RVA: 0x7F4C024 Offset: 0x7F48024 VA: 0x7F4C024
	private void ReadVertices(Dictionary<string, object> map, VertexAttachment attachment, int verticesLength) { }

	// RVA: 0x7F4521C Offset: 0x7F4121C VA: 0x7F4521C
	private int FindSlotIndex(SkeletonData skeletonData, string slotName) { }

	// RVA: 0x7F4603C Offset: 0x7F4203C VA: 0x7F4603C
	private void ReadAnimation(Dictionary<string, object> map, string name, SkeletonData skeletonData) { }

	// RVA: 0x7F4CAE0 Offset: 0x7F48AE0 VA: 0x7F4CAE0
	private static Timeline ReadTimeline(ref List.Enumerator<object> keyMapEnumerator, CurveTimeline1 timeline, float defaultValue, float scale) { }

	// RVA: 0x7F4CDA0 Offset: 0x7F48DA0 VA: 0x7F4CDA0
	private static Timeline ReadTimeline(ref List.Enumerator<object> keyMapEnumerator, CurveTimeline2 timeline, string name1, string name2, float defaultValue, float scale) { }

	// RVA: 0x7F4C864 Offset: 0x7F48864 VA: 0x7F4C864
	private static int ReadCurve(object curve, CurveTimeline timeline, int bezier, int frame, int value, float time1, float time2, float value1, float value2, float scale) { }

	// RVA: 0x7F4D0C8 Offset: 0x7F490C8 VA: 0x7F4D0C8
	private static void SetBezier(CurveTimeline timeline, int frame, int value, int bezier, float time1, float value1, float cx1, float cy1, float cx2, float cy2, float time2, float value2) { }

	// RVA: 0x7F4C374 Offset: 0x7F48374 VA: 0x7F4C374
	private static float[] GetFloatArray(Dictionary<string, object> map, string name, float scale) { }

	// RVA: 0x7F4C590 Offset: 0x7F48590 VA: 0x7F4C590
	private static int[] GetIntArray(Dictionary<string, object> map, string name) { }

	// RVA: 0x7F44D7C Offset: 0x7F40D7C VA: 0x7F44D7C
	private static float GetFloat(Dictionary<string, object> map, string name, float defaultValue) { }

	// RVA: 0x7F45134 Offset: 0x7F41134 VA: 0x7F45134
	private static int GetInt(Dictionary<string, object> map, string name, int defaultValue) { }

	// RVA: 0x7F4C738 Offset: 0x7F48738 VA: 0x7F4C738
	private static int GetInt(Dictionary<string, object> map, string name) { }

	// RVA: 0x7F44F14 Offset: 0x7F40F14 VA: 0x7F44F14
	private static bool GetBoolean(Dictionary<string, object> map, string name, bool defaultValue) { }

	// RVA: 0x7F44E4C Offset: 0x7F40E4C VA: 0x7F44E4C
	private static string GetString(Dictionary<string, object> map, string name, string defaultValue) { }

	// RVA: 0x7F44FEC Offset: 0x7F40FEC VA: 0x7F44FEC
	private static float ToColor(string hexString, int colorIndex, int expectedLength = 8) { }
}

// Namespace: 
protected class SkeletonLoader.LinkedMesh // TypeDefIndex: 23974
{
	// Fields
	internal string parent; // 0x10
	internal string skin; // 0x18
	internal int slotIndex; // 0x20
	internal MeshAttachment mesh; // 0x28
	internal bool inheritTimelines; // 0x30

	// Methods

	// RVA: 0x7F4D350 Offset: 0x7F49350 VA: 0x7F4D350
	public void .ctor(MeshAttachment mesh, string skin, int slotIndex, string parent, bool inheritTimelines) { }
}

// Namespace: Spine
public abstract class SkeletonLoader // TypeDefIndex: 23975
{
	// Fields
	protected readonly AttachmentLoader attachmentLoader; // 0x10
	protected float scale; // 0x18
	protected readonly List<SkeletonLoader.LinkedMesh> linkedMeshes; // 0x20

	// Properties
	public float Scale { get; set; }

	// Methods

	// RVA: 0x7F4D0EC Offset: 0x7F490EC VA: 0x7F4D0EC
	public void .ctor(Atlas[] atlasArray) { }

	// RVA: 0x7F4D1C4 Offset: 0x7F491C4 VA: 0x7F4D1C4
	public void .ctor(AttachmentLoader attachmentLoader) { }

	// RVA: 0x7F4D2C8 Offset: 0x7F492C8 VA: 0x7F4D2C8
	public float get_Scale() { }

	// RVA: 0x7F4D2D0 Offset: 0x7F492D0 VA: 0x7F4D2D0
	public void set_Scale(float value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract SkeletonData ReadSkeletonData(string path);
}

// Namespace: 
public struct Skin.SkinEntry // TypeDefIndex: 23976
{
	// Fields
	internal readonly int slotIndex; // 0x0
	internal readonly string name; // 0x8
	internal readonly Attachment attachment; // 0x10

	// Properties
	public int SlotIndex { get; }
	public string Name { get; }
	public Attachment Attachment { get; }

	// Methods

	// RVA: 0x7F4D834 Offset: 0x7F49834 VA: 0x7F4D834
	public void .ctor(int slotIndex, string name, Attachment attachment) { }

	// RVA: 0x7F4E9CC Offset: 0x7F4A9CC VA: 0x7F4E9CC
	public int get_SlotIndex() { }

	// RVA: 0x7F4E9D4 Offset: 0x7F4A9D4 VA: 0x7F4E9D4
	public string get_Name() { }

	// RVA: 0x7F4E9DC Offset: 0x7F4A9DC VA: 0x7F4E9DC
	public Attachment get_Attachment() { }
}

// Namespace: 
private struct Skin.SkinKey // TypeDefIndex: 23977
{
	// Fields
	internal readonly int slotIndex; // 0x0
	internal readonly string name; // 0x8
	internal readonly int hashCode; // 0x10

	// Methods

	// RVA: 0x7F4D750 Offset: 0x7F49750 VA: 0x7F4D750
	public void .ctor(int slotIndex, string name) { }
}

// Namespace: 
private class Skin.SkinKeyComparer : IEqualityComparer<Skin.SkinKey> // TypeDefIndex: 23978
{
	// Fields
	internal static readonly Skin.SkinKeyComparer Instance; // 0x0

	// Methods

	// RVA: 0x7F4E9E4 Offset: 0x7F4A9E4 VA: 0x7F4E9E4 Slot: 4
	private bool System.Collections.Generic.IEqualityComparer<Spine.Skin.SkinKey>.Equals(Skin.SkinKey e1, Skin.SkinKey e2) { }

	// RVA: 0x7F4EA10 Offset: 0x7F4AA10 VA: 0x7F4EA10 Slot: 5
	private int System.Collections.Generic.IEqualityComparer<Spine.Skin.SkinKey>.GetHashCode(Skin.SkinKey e) { }

	// RVA: 0x7F4EA18 Offset: 0x7F4AA18 VA: 0x7F4EA18
	public void .ctor() { }

	// RVA: 0x7F4EA20 Offset: 0x7F4AA20 VA: 0x7F4EA20
	private static void .cctor() { }
}

// Namespace: Spine
public class Skin // TypeDefIndex: 23979
{
	// Fields
	internal string name; // 0x10
	private Dictionary<Skin.SkinKey, Skin.SkinEntry> attachments; // 0x18
	internal readonly ExposedList<BoneData> bones; // 0x20
	internal readonly ExposedList<ConstraintData> constraints; // 0x28

	// Properties
	public string Name { get; }
	public ICollection<Skin.SkinEntry> Attachments { get; }
	public ExposedList<BoneData> Bones { get; }
	public ExposedList<ConstraintData> Constraints { get; }

	// Methods

	// RVA: 0x7F4D3CC Offset: 0x7F493CC VA: 0x7F4D3CC
	public string get_Name() { }

	// RVA: 0x7F4D3D4 Offset: 0x7F493D4 VA: 0x7F4D3D4
	public ICollection<Skin.SkinEntry> get_Attachments() { }

	// RVA: 0x7F4D424 Offset: 0x7F49424 VA: 0x7F4D424
	public ExposedList<BoneData> get_Bones() { }

	// RVA: 0x7F4D42C Offset: 0x7F4942C VA: 0x7F4D42C
	public ExposedList<ConstraintData> get_Constraints() { }

	// RVA: 0x7F4D434 Offset: 0x7F49434 VA: 0x7F4D434
	public void .ctor(string name) { }

	// RVA: 0x7F4D60C Offset: 0x7F4960C VA: 0x7F4D60C
	public void SetAttachment(int slotIndex, string name, Attachment attachment) { }

	// RVA: 0x7F4D86C Offset: 0x7F4986C VA: 0x7F4D86C
	public void AddSkin(Skin skin) { }

	// RVA: 0x7F4DCD8 Offset: 0x7F49CD8 VA: 0x7F4DCD8
	public void CopySkin(Skin skin) { }

	// RVA: 0x7F4E1F0 Offset: 0x7F4A1F0 VA: 0x7F4E1F0
	public Attachment GetAttachment(int slotIndex, string name) { }

	// RVA: 0x7F4E2A4 Offset: 0x7F4A2A4 VA: 0x7F4E2A4
	public void RemoveAttachment(int slotIndex, string name) { }

	// RVA: 0x7F4E340 Offset: 0x7F4A340 VA: 0x7F4E340
	public void GetAttachments(int slotIndex, List<Skin.SkinEntry> attachments) { }

	// RVA: 0x7F4E64C Offset: 0x7F4A64C VA: 0x7F4E64C
	public void Clear() { }

	// RVA: 0x7F4E6EC Offset: 0x7F4A6EC VA: 0x7F4E6EC Slot: 3
	public override string ToString() { }

	// RVA: 0x7F4E6F4 Offset: 0x7F4A6F4 VA: 0x7F4E6F4
	internal void AttachAll(Skeleton skeleton, Skin oldSkin) { }
}

// Namespace: Spine
public class Slot // TypeDefIndex: 23980
{
	// Fields
	internal SlotData data; // 0x10
	internal Bone bone; // 0x18
	internal float r; // 0x20
	internal float g; // 0x24
	internal float b; // 0x28
	internal float a; // 0x2C
	internal float r2; // 0x30
	internal float g2; // 0x34
	internal float b2; // 0x38
	internal bool hasSecondColor; // 0x3C
	internal Attachment attachment; // 0x40
	internal int sequenceIndex; // 0x48
	internal ExposedList<float> deform; // 0x50
	internal int attachmentState; // 0x58

	// Properties
	public SlotData Data { get; }
	public Bone Bone { get; }
	public Skeleton Skeleton { get; }
	public float R { get; set; }
	public float G { get; set; }
	public float B { get; set; }
	public float A { get; set; }
	public float R2 { get; set; }
	public float G2 { get; set; }
	public float B2 { get; set; }
	public bool HasSecondColor { get; set; }
	public Attachment Attachment { get; set; }
	public int SequenceIndex { get; set; }
	public ExposedList<float> Deform { get; set; }

	// Methods

	// RVA: 0x7F4EA88 Offset: 0x7F4AA88 VA: 0x7F4EA88
	public void .ctor(SlotData data, Bone bone) { }

	// RVA: 0x7F4EC84 Offset: 0x7F4AC84 VA: 0x7F4EC84
	public void .ctor(Slot slot, Bone bone) { }

	// RVA: 0x7F4EE48 Offset: 0x7F4AE48 VA: 0x7F4EE48
	public SlotData get_Data() { }

	// RVA: 0x7F4EE50 Offset: 0x7F4AE50 VA: 0x7F4EE50
	public Bone get_Bone() { }

	// RVA: 0x7F4EE58 Offset: 0x7F4AE58 VA: 0x7F4EE58
	public Skeleton get_Skeleton() { }

	// RVA: 0x7F4EE74 Offset: 0x7F4AE74 VA: 0x7F4EE74
	public float get_R() { }

	// RVA: 0x7F4EE7C Offset: 0x7F4AE7C VA: 0x7F4EE7C
	public void set_R(float value) { }

	// RVA: 0x7F4EE84 Offset: 0x7F4AE84 VA: 0x7F4EE84
	public float get_G() { }

	// RVA: 0x7F4EE8C Offset: 0x7F4AE8C VA: 0x7F4EE8C
	public void set_G(float value) { }

	// RVA: 0x7F4EE94 Offset: 0x7F4AE94 VA: 0x7F4EE94
	public float get_B() { }

	// RVA: 0x7F4EE9C Offset: 0x7F4AE9C VA: 0x7F4EE9C
	public void set_B(float value) { }

	// RVA: 0x7F4EEA4 Offset: 0x7F4AEA4 VA: 0x7F4EEA4
	public float get_A() { }

	// RVA: 0x7F4EEAC Offset: 0x7F4AEAC VA: 0x7F4EEAC
	public void set_A(float value) { }

	// RVA: 0x7F4EEB4 Offset: 0x7F4AEB4 VA: 0x7F4EEB4
	public void ClampColor() { }

	// RVA: 0x7F4EF7C Offset: 0x7F4AF7C VA: 0x7F4EF7C
	public float get_R2() { }

	// RVA: 0x7F4EF84 Offset: 0x7F4AF84 VA: 0x7F4EF84
	public void set_R2(float value) { }

	// RVA: 0x7F4EF8C Offset: 0x7F4AF8C VA: 0x7F4EF8C
	public float get_G2() { }

	// RVA: 0x7F4EF94 Offset: 0x7F4AF94 VA: 0x7F4EF94
	public void set_G2(float value) { }

	// RVA: 0x7F4EF9C Offset: 0x7F4AF9C VA: 0x7F4EF9C
	public float get_B2() { }

	// RVA: 0x7F4EFA4 Offset: 0x7F4AFA4 VA: 0x7F4EFA4
	public void set_B2(float value) { }

	// RVA: 0x7F4EFAC Offset: 0x7F4AFAC VA: 0x7F4EFAC
	public bool get_HasSecondColor() { }

	// RVA: 0x7F4EFC8 Offset: 0x7F4AFC8 VA: 0x7F4EFC8
	public void set_HasSecondColor(bool value) { }

	// RVA: 0x7F4EFE8 Offset: 0x7F4AFE8 VA: 0x7F4EFE8
	public void ClampSecondColor() { }

	// RVA: 0x7F4F094 Offset: 0x7F4B094 VA: 0x7F4F094
	public Attachment get_Attachment() { }

	// RVA: 0x7F4E8D0 Offset: 0x7F4A8D0 VA: 0x7F4E8D0
	public void set_Attachment(Attachment value) { }

	// RVA: 0x7F4F09C Offset: 0x7F4B09C VA: 0x7F4F09C
	public int get_SequenceIndex() { }

	// RVA: 0x7F4F0A4 Offset: 0x7F4B0A4 VA: 0x7F4F0A4
	public void set_SequenceIndex(int value) { }

	// RVA: 0x7F4F0AC Offset: 0x7F4B0AC VA: 0x7F4F0AC
	public ExposedList<float> get_Deform() { }

	// RVA: 0x7F4F0B4 Offset: 0x7F4B0B4 VA: 0x7F4F0B4
	public void set_Deform(ExposedList<float> value) { }

	// RVA: 0x7F4EBEC Offset: 0x7F4ABEC VA: 0x7F4EBEC
	public void SetToSetupPose() { }

	// RVA: 0x7F4F130 Offset: 0x7F4B130 VA: 0x7F4F130 Slot: 3
	public override string ToString() { }
}

// Namespace: Spine
public class SlotData // TypeDefIndex: 23981
{
	// Fields
	internal int index; // 0x10
	internal string name; // 0x18
	internal BoneData boneData; // 0x20
	internal float r; // 0x28
	internal float g; // 0x2C
	internal float b; // 0x30
	internal float a; // 0x34
	internal float r2; // 0x38
	internal float g2; // 0x3C
	internal float b2; // 0x40
	internal bool hasSecondColor; // 0x44
	internal string attachmentName; // 0x48
	internal BlendMode blendMode; // 0x50

	// Properties
	public int Index { get; }
	public string Name { get; }
	public BoneData BoneData { get; }
	public float R { get; set; }
	public float G { get; set; }
	public float B { get; set; }
	public float A { get; set; }
	public float R2 { get; set; }
	public float G2 { get; set; }
	public float B2 { get; set; }
	public bool HasSecondColor { get; set; }
	public string AttachmentName { get; set; }
	public BlendMode BlendMode { get; set; }

	// Methods

	// RVA: 0x7F4F14C Offset: 0x7F4B14C VA: 0x7F4F14C
	public int get_Index() { }

	// RVA: 0x7F4F154 Offset: 0x7F4B154 VA: 0x7F4F154
	public string get_Name() { }

	// RVA: 0x7F4F15C Offset: 0x7F4B15C VA: 0x7F4F15C
	public BoneData get_BoneData() { }

	// RVA: 0x7F4F164 Offset: 0x7F4B164 VA: 0x7F4F164
	public float get_R() { }

	// RVA: 0x7F4F16C Offset: 0x7F4B16C VA: 0x7F4F16C
	public void set_R(float value) { }

	// RVA: 0x7F4F174 Offset: 0x7F4B174 VA: 0x7F4F174
	public float get_G() { }

	// RVA: 0x7F4F17C Offset: 0x7F4B17C VA: 0x7F4F17C
	public void set_G(float value) { }

	// RVA: 0x7F4F184 Offset: 0x7F4B184 VA: 0x7F4F184
	public float get_B() { }

	// RVA: 0x7F4F18C Offset: 0x7F4B18C VA: 0x7F4F18C
	public void set_B(float value) { }

	// RVA: 0x7F4F194 Offset: 0x7F4B194 VA: 0x7F4F194
	public float get_A() { }

	// RVA: 0x7F4F19C Offset: 0x7F4B19C VA: 0x7F4F19C
	public void set_A(float value) { }

	// RVA: 0x7F4F1A4 Offset: 0x7F4B1A4 VA: 0x7F4F1A4
	public float get_R2() { }

	// RVA: 0x7F4F1AC Offset: 0x7F4B1AC VA: 0x7F4F1AC
	public void set_R2(float value) { }

	// RVA: 0x7F4F1B4 Offset: 0x7F4B1B4 VA: 0x7F4F1B4
	public float get_G2() { }

	// RVA: 0x7F4F1BC Offset: 0x7F4B1BC VA: 0x7F4F1BC
	public void set_G2(float value) { }

	// RVA: 0x7F4F1C4 Offset: 0x7F4B1C4 VA: 0x7F4F1C4
	public float get_B2() { }

	// RVA: 0x7F4F1CC Offset: 0x7F4B1CC VA: 0x7F4F1CC
	public void set_B2(float value) { }

	// RVA: 0x7F4F1D4 Offset: 0x7F4B1D4 VA: 0x7F4F1D4
	public bool get_HasSecondColor() { }

	// RVA: 0x7F4F1DC Offset: 0x7F4B1DC VA: 0x7F4F1DC
	public void set_HasSecondColor(bool value) { }

	// RVA: 0x7F4F1E8 Offset: 0x7F4B1E8 VA: 0x7F4F1E8
	public string get_AttachmentName() { }

	// RVA: 0x7F4F1F0 Offset: 0x7F4B1F0 VA: 0x7F4F1F0
	public void set_AttachmentName(string value) { }

	// RVA: 0x7F4F1F8 Offset: 0x7F4B1F8 VA: 0x7F4F1F8
	public BlendMode get_BlendMode() { }

	// RVA: 0x7F4F200 Offset: 0x7F4B200 VA: 0x7F4F200
	public void set_BlendMode(BlendMode value) { }

	// RVA: 0x7F4F208 Offset: 0x7F4B208 VA: 0x7F4F208
	public void .ctor(int index, string name, BoneData boneData) { }

	// RVA: 0x7F4F344 Offset: 0x7F4B344 VA: 0x7F4F344 Slot: 3
	public override string ToString() { }
}

// Namespace: Spine
public class TextureRegion // TypeDefIndex: 23982
{
	// Fields
	public int width; // 0x10
	public int height; // 0x14
	public float u; // 0x18
	public float v; // 0x1C
	public float u2; // 0x20
	public float v2; // 0x24

	// Properties
	public virtual int OriginalWidth { get; }
	public virtual int OriginalHeight { get; }

	// Methods

	// RVA: 0x7F4F34C Offset: 0x7F4B34C VA: 0x7F4F34C Slot: 4
	public virtual int get_OriginalWidth() { }

	// RVA: 0x7F4F354 Offset: 0x7F4B354 VA: 0x7F4F354 Slot: 5
	public virtual int get_OriginalHeight() { }

	// RVA: 0x7F4F35C Offset: 0x7F4B35C VA: 0x7F4F35C
	public void .ctor() { }
}

// Namespace: Spine
public class TransformConstraint : IUpdatable // TypeDefIndex: 23983
{
	// Fields
	internal readonly TransformConstraintData data; // 0x10
	internal readonly ExposedList<Bone> bones; // 0x18
	internal Bone target; // 0x20
	internal float mixRotate; // 0x28
	internal float mixX; // 0x2C
	internal float mixY; // 0x30
	internal float mixScaleX; // 0x34
	internal float mixScaleY; // 0x38
	internal float mixShearY; // 0x3C
	internal bool active; // 0x40

	// Properties
	public ExposedList<Bone> Bones { get; }
	public Bone Target { get; set; }
	public float MixRotate { get; set; }
	public float MixX { get; set; }
	public float MixY { get; set; }
	public float MixScaleX { get; set; }
	public float MixScaleY { get; set; }
	public float MixShearY { get; set; }
	public bool Active { get; }
	public TransformConstraintData Data { get; }

	// Methods

	// RVA: 0x7F4F364 Offset: 0x7F4B364 VA: 0x7F4F364
	public void .ctor(TransformConstraintData data, Skeleton skeleton) { }

	// RVA: 0x7F4F678 Offset: 0x7F4B678 VA: 0x7F4F678
	public void .ctor(TransformConstraint constraint, Skeleton skeleton) { }

	// RVA: 0x7F4F990 Offset: 0x7F4B990 VA: 0x7F4F990 Slot: 4
	public void Update() { }

	// RVA: 0x7F50224 Offset: 0x7F4C224 VA: 0x7F50224
	private void ApplyAbsoluteWorld() { }

	// RVA: 0x7F4FD94 Offset: 0x7F4BD94 VA: 0x7F4FD94
	private void ApplyRelativeWorld() { }

	// RVA: 0x7F4FB60 Offset: 0x7F4BB60 VA: 0x7F4FB60
	private void ApplyAbsoluteLocal() { }

	// RVA: 0x7F4FA24 Offset: 0x7F4BA24 VA: 0x7F4FA24
	private void ApplyRelativeLocal() { }

	// RVA: 0x7F50760 Offset: 0x7F4C760 VA: 0x7F50760
	public ExposedList<Bone> get_Bones() { }

	// RVA: 0x7F50768 Offset: 0x7F4C768 VA: 0x7F50768
	public Bone get_Target() { }

	// RVA: 0x7F50770 Offset: 0x7F4C770 VA: 0x7F50770
	public void set_Target(Bone value) { }

	// RVA: 0x7F50778 Offset: 0x7F4C778 VA: 0x7F50778
	public float get_MixRotate() { }

	// RVA: 0x7F50780 Offset: 0x7F4C780 VA: 0x7F50780
	public void set_MixRotate(float value) { }

	// RVA: 0x7F50788 Offset: 0x7F4C788 VA: 0x7F50788
	public float get_MixX() { }

	// RVA: 0x7F50790 Offset: 0x7F4C790 VA: 0x7F50790
	public void set_MixX(float value) { }

	// RVA: 0x7F50798 Offset: 0x7F4C798 VA: 0x7F50798
	public float get_MixY() { }

	// RVA: 0x7F507A0 Offset: 0x7F4C7A0 VA: 0x7F507A0
	public void set_MixY(float value) { }

	// RVA: 0x7F507A8 Offset: 0x7F4C7A8 VA: 0x7F507A8
	public float get_MixScaleX() { }

	// RVA: 0x7F507B0 Offset: 0x7F4C7B0 VA: 0x7F507B0
	public void set_MixScaleX(float value) { }

	// RVA: 0x7F507B8 Offset: 0x7F4C7B8 VA: 0x7F507B8
	public float get_MixScaleY() { }

	// RVA: 0x7F507C0 Offset: 0x7F4C7C0 VA: 0x7F507C0
	public void set_MixScaleY(float value) { }

	// RVA: 0x7F507C8 Offset: 0x7F4C7C8 VA: 0x7F507C8
	public float get_MixShearY() { }

	// RVA: 0x7F507D0 Offset: 0x7F4C7D0 VA: 0x7F507D0
	public void set_MixShearY(float value) { }

	// RVA: 0x7F507D8 Offset: 0x7F4C7D8 VA: 0x7F507D8 Slot: 5
	public bool get_Active() { }

	// RVA: 0x7F507E0 Offset: 0x7F4C7E0 VA: 0x7F507E0
	public TransformConstraintData get_Data() { }

	// RVA: 0x7F507E8 Offset: 0x7F4C7E8 VA: 0x7F507E8 Slot: 3
	public override string ToString() { }
}

// Namespace: Spine
public class TransformConstraintData : ConstraintData // TypeDefIndex: 23984
{
	// Fields
	internal ExposedList<BoneData> bones; // 0x20
	internal BoneData target; // 0x28
	internal float mixRotate; // 0x30
	internal float mixX; // 0x34
	internal float mixY; // 0x38
	internal float mixScaleX; // 0x3C
	internal float mixScaleY; // 0x40
	internal float mixShearY; // 0x44
	internal float offsetRotation; // 0x48
	internal float offsetX; // 0x4C
	internal float offsetY; // 0x50
	internal float offsetScaleX; // 0x54
	internal float offsetScaleY; // 0x58
	internal float offsetShearY; // 0x5C
	internal bool relative; // 0x60
	internal bool local; // 0x61

	// Properties
	public ExposedList<BoneData> Bones { get; }
	public BoneData Target { get; set; }
	public float MixRotate { get; set; }
	public float MixX { get; set; }
	public float MixY { get; set; }
	public float MixScaleX { get; set; }
	public float MixScaleY { get; set; }
	public float MixShearY { get; set; }
	public float OffsetRotation { get; set; }
	public float OffsetX { get; set; }
	public float OffsetY { get; set; }
	public float OffsetScaleX { get; set; }
	public float OffsetScaleY { get; set; }
	public float OffsetShearY { get; set; }
	public bool Relative { get; set; }
	public bool Local { get; set; }

	// Methods

	// RVA: 0x7F50804 Offset: 0x7F4C804 VA: 0x7F50804
	public ExposedList<BoneData> get_Bones() { }

	// RVA: 0x7F5080C Offset: 0x7F4C80C VA: 0x7F5080C
	public BoneData get_Target() { }

	// RVA: 0x7F50814 Offset: 0x7F4C814 VA: 0x7F50814
	public void set_Target(BoneData value) { }

	// RVA: 0x7F5081C Offset: 0x7F4C81C VA: 0x7F5081C
	public float get_MixRotate() { }

	// RVA: 0x7F50824 Offset: 0x7F4C824 VA: 0x7F50824
	public void set_MixRotate(float value) { }

	// RVA: 0x7F5082C Offset: 0x7F4C82C VA: 0x7F5082C
	public float get_MixX() { }

	// RVA: 0x7F50834 Offset: 0x7F4C834 VA: 0x7F50834
	public void set_MixX(float value) { }

	// RVA: 0x7F5083C Offset: 0x7F4C83C VA: 0x7F5083C
	public float get_MixY() { }

	// RVA: 0x7F50844 Offset: 0x7F4C844 VA: 0x7F50844
	public void set_MixY(float value) { }

	// RVA: 0x7F5084C Offset: 0x7F4C84C VA: 0x7F5084C
	public float get_MixScaleX() { }

	// RVA: 0x7F50854 Offset: 0x7F4C854 VA: 0x7F50854
	public void set_MixScaleX(float value) { }

	// RVA: 0x7F5085C Offset: 0x7F4C85C VA: 0x7F5085C
	public float get_MixScaleY() { }

	// RVA: 0x7F50864 Offset: 0x7F4C864 VA: 0x7F50864
	public void set_MixScaleY(float value) { }

	// RVA: 0x7F5086C Offset: 0x7F4C86C VA: 0x7F5086C
	public float get_MixShearY() { }

	// RVA: 0x7F50874 Offset: 0x7F4C874 VA: 0x7F50874
	public void set_MixShearY(float value) { }

	// RVA: 0x7F5087C Offset: 0x7F4C87C VA: 0x7F5087C
	public float get_OffsetRotation() { }

	// RVA: 0x7F50884 Offset: 0x7F4C884 VA: 0x7F50884
	public void set_OffsetRotation(float value) { }

	// RVA: 0x7F5088C Offset: 0x7F4C88C VA: 0x7F5088C
	public float get_OffsetX() { }

	// RVA: 0x7F50894 Offset: 0x7F4C894 VA: 0x7F50894
	public void set_OffsetX(float value) { }

	// RVA: 0x7F5089C Offset: 0x7F4C89C VA: 0x7F5089C
	public float get_OffsetY() { }

	// RVA: 0x7F508A4 Offset: 0x7F4C8A4 VA: 0x7F508A4
	public void set_OffsetY(float value) { }

	// RVA: 0x7F508AC Offset: 0x7F4C8AC VA: 0x7F508AC
	public float get_OffsetScaleX() { }

	// RVA: 0x7F508B4 Offset: 0x7F4C8B4 VA: 0x7F508B4
	public void set_OffsetScaleX(float value) { }

	// RVA: 0x7F508BC Offset: 0x7F4C8BC VA: 0x7F508BC
	public float get_OffsetScaleY() { }

	// RVA: 0x7F508C4 Offset: 0x7F4C8C4 VA: 0x7F508C4
	public void set_OffsetScaleY(float value) { }

	// RVA: 0x7F508CC Offset: 0x7F4C8CC VA: 0x7F508CC
	public float get_OffsetShearY() { }

	// RVA: 0x7F508D4 Offset: 0x7F4C8D4 VA: 0x7F508D4
	public void set_OffsetShearY(float value) { }

	// RVA: 0x7F508DC Offset: 0x7F4C8DC VA: 0x7F508DC
	public bool get_Relative() { }

	// RVA: 0x7F508E4 Offset: 0x7F4C8E4 VA: 0x7F508E4
	public void set_Relative(bool value) { }

	// RVA: 0x7F508F0 Offset: 0x7F4C8F0 VA: 0x7F508F0
	public bool get_Local() { }

	// RVA: 0x7F508F8 Offset: 0x7F4C8F8 VA: 0x7F508F8
	public void set_Local(bool value) { }

	// RVA: 0x7F50904 Offset: 0x7F4C904 VA: 0x7F50904
	public void .ctor(string name) { }
}

// Namespace: Spine
public class Triangulator // TypeDefIndex: 23985
{
	// Fields
	private readonly ExposedList<ExposedList<float>> convexPolygons; // 0x10
	private readonly ExposedList<ExposedList<int>> convexPolygonsIndices; // 0x18
	private readonly ExposedList<int> indicesArray; // 0x20
	private readonly ExposedList<bool> isConcaveArray; // 0x28
	private readonly ExposedList<int> triangles; // 0x30
	private readonly Pool<ExposedList<float>> polygonPool; // 0x38
	private readonly Pool<ExposedList<int>> polygonIndicesPool; // 0x40

	// Methods

	// RVA: 0x7F50994 Offset: 0x7F4C994 VA: 0x7F50994
	public ExposedList<int> Triangulate(ExposedList<float> verticesArray) { }

	// RVA: 0x7F510D8 Offset: 0x7F4D0D8 VA: 0x7F510D8
	public ExposedList<ExposedList<float>> Decompose(ExposedList<float> verticesArray, ExposedList<int> triangles) { }

	// RVA: 0x7F50F94 Offset: 0x7F4CF94 VA: 0x7F50F94
	private static bool IsConcave(int index, int vertexCount, float[] vertices, int[] indices) { }

	// RVA: 0x7F510AC Offset: 0x7F4D0AC VA: 0x7F510AC
	private static bool PositiveArea(float p1x, float p1y, float p2x, float p2y, float p3x, float p3y) { }

	// RVA: 0x7F51B98 Offset: 0x7F4DB98 VA: 0x7F51B98
	private static int Winding(float p1x, float p1y, float p2x, float p2y, float p3x, float p3y) { }

	// RVA: 0x7F51BCC Offset: 0x7F4DBCC VA: 0x7F51BCC
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 // TypeDefIndex: 23986
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2495 // TypeDefIndex: 23987
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3091 // TypeDefIndex: 23988
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 23989
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 ADCCF6F914B86A7EF3FFAA75A291E94CBA3B3DFBF16E94206A5A932D18E28891 /*Metadata offset 0xF30B38*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2495 B5CC7CD12F29462C8412F03C14BCC450448782055803AD193008F7FD9D19A0B6 /*Metadata offset 0xF30B50*/; // 0x14
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3091 E44704F9543B4D75D151CACCEAC8C3E5D437C06F637DDEFFA5B845962F2F9723 /*Metadata offset 0xF31510*/; // 0x9D3
}


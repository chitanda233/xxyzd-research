// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28784
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 28785
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
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 28786
{
	// Methods

	// RVA: 0x6482AD8 Offset: 0x647EAD8 VA: 0x6482AD8
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x6482BD0 Offset: 0x647EBD0 VA: 0x6482BD0
	public void .ctor() { }
}

// Namespace: GorillaIM.Protobuf.Framework
public static class PackageFactory // TypeDefIndex: 28787
{
	// Methods

	// RVA: 0x6482BD8 Offset: 0x647EBD8 VA: 0x6482BD8
	public static IMessage CreateMessage(ushort id) { }
}

// Namespace: GorillaIM.Protobuf.Framework
internal static class PackageID // TypeDefIndex: 28788
{
	// Fields
	public const int IMLoginRequest = 31101;
	public const int IMLoginResponse = 31102;
	public const int IMHeartBeatRequest = 31107;
	public const int IMHeartBeatResponse = 31108;
}

// Namespace: IM.Guild
public static class ImReflection // TypeDefIndex: 28789
{
	// Fields
	private static FileDescriptor descriptor; // 0x0

	// Properties
	public static FileDescriptor Descriptor { get; }

	// Methods

	// RVA: 0x6482D44 Offset: 0x647ED44 VA: 0x6482D44
	public static FileDescriptor get_Descriptor() { }

	// RVA: 0x6482D9C Offset: 0x647ED9C VA: 0x6482D9C
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class IMLoginRequest.<>c // TypeDefIndex: 28790
{
	// Fields
	public static readonly IMLoginRequest.<>c <>9; // 0x0

	// Methods

	// RVA: 0x6483C4C Offset: 0x647FC4C VA: 0x6483C4C
	private static void .cctor() { }

	// RVA: 0x6483CB4 Offset: 0x647FCB4 VA: 0x6483CB4
	public void .ctor() { }

	// RVA: 0x6483CBC Offset: 0x647FCBC VA: 0x6483CBC
	internal IMLoginRequest <.cctor>b__28_0() { }
}

// Namespace: IM.Guild
[DebuggerDisplay("{ToString(),nq}")]
public sealed class IMLoginRequest : IMessage<IMLoginRequest>, IMessage, IEquatable<IMLoginRequest>, IDeepCloneable<IMLoginRequest>, IBufferMessage, IMessageIDGetter // TypeDefIndex: 28791
{
	// Fields
	private static readonly MessageParser<IMLoginRequest> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	public const int AccessTokenFieldNumber = 1;
	private string accessToken_; // 0x18

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IMLoginRequest> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AccessToken { get; set; }

	// Methods

	// RVA: 0x6483470 Offset: 0x647F470 VA: 0x6483470
	public static MessageParser<IMLoginRequest> get_Parser() { }

	// RVA: 0x64834C8 Offset: 0x647F4C8 VA: 0x64834C8
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x64835CC Offset: 0x647F5CC VA: 0x64835CC Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6482CD4 Offset: 0x647ECD4 VA: 0x6482CD4
	public void .ctor() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6483618 Offset: 0x647F618 VA: 0x6483618
	public void .ctor(IMLoginRequest other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6483668 Offset: 0x647F668 VA: 0x6483668 Slot: 10
	public IMLoginRequest Clone() { }

	// RVA: 0x64836C0 Offset: 0x647F6C0 VA: 0x64836C0
	public string get_AccessToken() { }

	// RVA: 0x64836C8 Offset: 0x647F6C8 VA: 0x64836C8
	public void set_AccessToken(string value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6483744 Offset: 0x647F744 VA: 0x6483744 Slot: 0
	public override bool Equals(object other) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x64837A8 Offset: 0x647F7A8 VA: 0x64837A8 Slot: 9
	public bool Equals(IMLoginRequest other) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6483808 Offset: 0x647F808 VA: 0x6483808 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6483868 Offset: 0x647F868 VA: 0x6483868 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x64838C0 Offset: 0x647F8C0 VA: 0x64838C0 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x64838E0 Offset: 0x647F8E0 VA: 0x64838E0 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x648394C Offset: 0x647F94C VA: 0x648394C Slot: 7
	public int CalculateSize() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x64839E0 Offset: 0x647F9E0 VA: 0x64839E0 Slot: 4
	public void MergeFrom(IMLoginRequest other) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6483A44 Offset: 0x647FA44 VA: 0x6483A44 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6483A64 Offset: 0x647FA64 VA: 0x6483A64 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x6483B2C Offset: 0x647FB2C VA: 0x6483B2C Slot: 13
	public ushort GetMessageId() { }

	// RVA: 0x6483B34 Offset: 0x647FB34 VA: 0x6483B34
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class IMLoginResponse.<>c // TypeDefIndex: 28792
{
	// Fields
	public static readonly IMLoginResponse.<>c <>9; // 0x0

	// Methods

	// RVA: 0x64843E8 Offset: 0x64803E8 VA: 0x64843E8
	private static void .cctor() { }

	// RVA: 0x6484450 Offset: 0x6480450 VA: 0x6484450
	public void .ctor() { }

	// RVA: 0x6484458 Offset: 0x6480458 VA: 0x6484458
	internal IMLoginResponse <.cctor>b__28_0() { }
}

// Namespace: IM.Guild
[DebuggerDisplay("{ToString(),nq}")]
public sealed class IMLoginResponse : IMessage<IMLoginResponse>, IMessage, IEquatable<IMLoginResponse>, IDeepCloneable<IMLoginResponse>, IBufferMessage, IMessageIDGetter // TypeDefIndex: 28793
{
	// Fields
	private static readonly MessageParser<IMLoginResponse> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	public const int CodeFieldNumber = 1;
	private int code_; // 0x18

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IMLoginResponse> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Code { get; set; }

	// Methods

	// RVA: 0x6483D0C Offset: 0x647FD0C VA: 0x6483D0C
	public static MessageParser<IMLoginResponse> get_Parser() { }

	// RVA: 0x6483D64 Offset: 0x647FD64 VA: 0x6483D64
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x6483E68 Offset: 0x647FE68 VA: 0x6483E68 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6482D2C Offset: 0x647ED2C VA: 0x6482D2C
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6483EB4 Offset: 0x647FEB4 VA: 0x6483EB4
	public void .ctor(IMLoginResponse other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6483F00 Offset: 0x647FF00 VA: 0x6483F00 Slot: 10
	public IMLoginResponse Clone() { }

	// RVA: 0x6483F58 Offset: 0x647FF58 VA: 0x6483F58
	public int get_Code() { }

	// RVA: 0x6483F60 Offset: 0x647FF60 VA: 0x6483F60
	public void set_Code(int value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6483F68 Offset: 0x647FF68 VA: 0x6483F68 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6483FCC Offset: 0x647FFCC VA: 0x6483FCC Slot: 9
	public bool Equals(IMLoginResponse other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6484008 Offset: 0x6480008 VA: 0x6484008 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6484064 Offset: 0x6480064 VA: 0x6484064 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x64840BC Offset: 0x64800BC VA: 0x64840BC Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x64840DC Offset: 0x64800DC VA: 0x64840DC Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x648413C Offset: 0x648013C VA: 0x648413C Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x64841BC Offset: 0x64801BC VA: 0x64841BC Slot: 4
	public void MergeFrom(IMLoginResponse other) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x64841FC Offset: 0x64801FC VA: 0x64841FC Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x648421C Offset: 0x648021C VA: 0x648421C Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x64842C8 Offset: 0x64802C8 VA: 0x64842C8 Slot: 13
	public ushort GetMessageId() { }

	// RVA: 0x64842D0 Offset: 0x64802D0 VA: 0x64842D0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class IMHeartBeatRequest.<>c // TypeDefIndex: 28794
{
	// Fields
	public static readonly IMHeartBeatRequest.<>c <>9; // 0x0

	// Methods

	// RVA: 0x6484A64 Offset: 0x6480A64 VA: 0x6484A64
	private static void .cctor() { }

	// RVA: 0x6484ACC Offset: 0x6480ACC VA: 0x6484ACC
	public void .ctor() { }

	// RVA: 0x6484AD4 Offset: 0x6480AD4 VA: 0x6484AD4
	internal IMHeartBeatRequest <.cctor>b__23_0() { }
}

// Namespace: IM.Guild
[DebuggerDisplay("{ToString(),nq}")]
public sealed class IMHeartBeatRequest : IMessage<IMHeartBeatRequest>, IMessage, IEquatable<IMHeartBeatRequest>, IDeepCloneable<IMHeartBeatRequest>, IBufferMessage, IMessageIDGetter // TypeDefIndex: 28795
{
	// Fields
	private static readonly MessageParser<IMHeartBeatRequest> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IMHeartBeatRequest> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }

	// Methods

	// RVA: 0x64844AC Offset: 0x64804AC VA: 0x64844AC
	public static MessageParser<IMHeartBeatRequest> get_Parser() { }

	// RVA: 0x6484504 Offset: 0x6480504 VA: 0x6484504
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x6484608 Offset: 0x6480608 VA: 0x6484608 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6482D34 Offset: 0x647ED34 VA: 0x6482D34
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6484654 Offset: 0x6480654 VA: 0x6484654
	public void .ctor(IMHeartBeatRequest other) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6484698 Offset: 0x6480698 VA: 0x6484698 Slot: 10
	public IMHeartBeatRequest Clone() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x64846F0 Offset: 0x64806F0 VA: 0x64846F0 Slot: 0
	public override bool Equals(object other) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6484774 Offset: 0x6480774 VA: 0x6484774 Slot: 9
	public bool Equals(IMHeartBeatRequest other) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x64847A0 Offset: 0x64807A0 VA: 0x64847A0 Slot: 2
	public override int GetHashCode() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x64847CC Offset: 0x64807CC VA: 0x64847CC Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6484824 Offset: 0x6480824 VA: 0x6484824 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6484844 Offset: 0x6480844 VA: 0x6484844 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6484858 Offset: 0x6480858 VA: 0x6484858 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x648486C Offset: 0x648086C VA: 0x648486C Slot: 4
	public void MergeFrom(IMHeartBeatRequest other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x64848A0 Offset: 0x64808A0 VA: 0x64848A0 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x64848C0 Offset: 0x64808C0 VA: 0x64848C0 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x6484944 Offset: 0x6480944 VA: 0x6484944 Slot: 13
	public ushort GetMessageId() { }

	// RVA: 0x648494C Offset: 0x648094C VA: 0x648494C
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class IMHeartBeatResponse.<>c // TypeDefIndex: 28796
{
	// Fields
	public static readonly IMHeartBeatResponse.<>c <>9; // 0x0

	// Methods

	// RVA: 0x6485204 Offset: 0x6481204 VA: 0x6485204
	private static void .cctor() { }

	// RVA: 0x648526C Offset: 0x648126C VA: 0x648526C
	public void .ctor() { }

	// RVA: 0x6485274 Offset: 0x6481274 VA: 0x6485274
	internal IMHeartBeatResponse <.cctor>b__28_0() { }
}

// Namespace: IM.Guild
[DebuggerDisplay("{ToString(),nq}")]
public sealed class IMHeartBeatResponse : IMessage<IMHeartBeatResponse>, IMessage, IEquatable<IMHeartBeatResponse>, IDeepCloneable<IMHeartBeatResponse>, IBufferMessage, IMessageIDGetter // TypeDefIndex: 28797
{
	// Fields
	private static readonly MessageParser<IMHeartBeatResponse> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	public const int CodeFieldNumber = 1;
	private int code_; // 0x18

	// Properties
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<IMHeartBeatResponse> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Code { get; set; }

	// Methods

	// RVA: 0x6484B28 Offset: 0x6480B28 VA: 0x6484B28
	public static MessageParser<IMHeartBeatResponse> get_Parser() { }

	// RVA: 0x6484B80 Offset: 0x6480B80 VA: 0x6484B80
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x6484C84 Offset: 0x6480C84 VA: 0x6484C84 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6482D3C Offset: 0x647ED3C VA: 0x6482D3C
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6484CD0 Offset: 0x6480CD0 VA: 0x6484CD0
	public void .ctor(IMHeartBeatResponse other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6484D1C Offset: 0x6480D1C VA: 0x6484D1C Slot: 10
	public IMHeartBeatResponse Clone() { }

	// RVA: 0x6484D74 Offset: 0x6480D74 VA: 0x6484D74
	public int get_Code() { }

	// RVA: 0x6484D7C Offset: 0x6480D7C VA: 0x6484D7C
	public void set_Code(int value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6484D84 Offset: 0x6480D84 VA: 0x6484D84 Slot: 0
	public override bool Equals(object other) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6484DE8 Offset: 0x6480DE8 VA: 0x6484DE8 Slot: 9
	public bool Equals(IMHeartBeatResponse other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6484E24 Offset: 0x6480E24 VA: 0x6484E24 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6484E80 Offset: 0x6480E80 VA: 0x6484E80 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6484ED8 Offset: 0x6480ED8 VA: 0x6484ED8 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6484EF8 Offset: 0x6480EF8 VA: 0x6484EF8 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6484F58 Offset: 0x6480F58 VA: 0x6484F58 Slot: 7
	public int CalculateSize() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6484FD8 Offset: 0x6480FD8 VA: 0x6484FD8 Slot: 4
	public void MergeFrom(IMHeartBeatResponse other) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6485018 Offset: 0x6481018 VA: 0x6485018 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6485038 Offset: 0x6481038 VA: 0x6485038 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x64850E4 Offset: 0x64810E4 VA: 0x64850E4 Slot: 13
	public ushort GetMessageId() { }

	// RVA: 0x64850EC Offset: 0x64810EC VA: 0x64850EC
	private static void .cctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=306 // TypeDefIndex: 28798
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=361 // TypeDefIndex: 28799
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 28800
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=306 500D92352DE5E3A39A12150A152C7D7E32AE0ECECE149D709773E405A5552C5B /*Metadata offset 0xF553E8*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=361 E593AC2AFD815FAB3B73F0FAC7D67CEE7C6FFA4D5FE3D84BFBC7FB649E7018A3 /*Metadata offset 0xF55520*/; // 0x132
}


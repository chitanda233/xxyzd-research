// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 24346
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 24347
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
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
[EditorBrowsable(1)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 24348
{
	// Methods

	// RVA: 0x6BA195C Offset: 0x6B9D95C VA: 0x6BA195C
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x6BA1A54 Offset: 0x6B9DA54 VA: 0x6BA1A54
	public void .ctor() { }
}

// Namespace: HabbyFrameNet
public static class HabbyFrameNetReflection // TypeDefIndex: 24349
{
	// Fields
	private static FileDescriptor descriptor; // 0x0

	// Properties
	public static FileDescriptor Descriptor { get; }

	// Methods

	// RVA: 0x6BA1A5C Offset: 0x6B9DA5C VA: 0x6BA1A5C
	public static FileDescriptor get_Descriptor() { }

	// RVA: 0x6BA1AB4 Offset: 0x6B9DAB4 VA: 0x6BA1AB4
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class C2SConnect.<>c // TypeDefIndex: 24350
{
	// Fields
	public static readonly C2SConnect.<>c <>9; // 0x0

	// Methods

	// RVA: 0x6BA2F9C Offset: 0x6B9EF9C VA: 0x6BA2F9C
	private static void .cctor() { }

	// RVA: 0x6BA3004 Offset: 0x6B9F004 VA: 0x6BA3004
	public void .ctor() { }

	// RVA: 0x6BA300C Offset: 0x6B9F00C VA: 0x6BA300C
	internal C2SConnect <.cctor>b__32_0() { }
}

// Namespace: HabbyFrameNet
[DebuggerDisplay("{ToString(),nq}")]
public sealed class C2SConnect : IMessage<C2SConnect>, IMessage, IEquatable<C2SConnect>, IDeepCloneable<C2SConnect>, IBufferMessage // TypeDefIndex: 24351
{
	// Fields
	private static readonly MessageParser<C2SConnect> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private int _hasBits0; // 0x18
	public const int TimeoutFieldNumber = 1;
	private static readonly int TimeoutDefaultValue; // 0x8
	private int timeout_; // 0x1C

	// Properties
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<C2SConnect> Parser { get; }
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Timeout { get; set; }
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasTimeout { get; }

	// Methods

	// RVA: 0x6BA27AC Offset: 0x6B9E7AC VA: 0x6BA27AC
	public static MessageParser<C2SConnect> get_Parser() { }

	// RVA: 0x6BA2804 Offset: 0x6B9E804 VA: 0x6BA2804
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x6BA2908 Offset: 0x6B9E908 VA: 0x6BA2908 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA2954 Offset: 0x6B9E954 VA: 0x6BA2954
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA295C Offset: 0x6B9E95C VA: 0x6BA295C
	public void .ctor(C2SConnect other) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA29A8 Offset: 0x6B9E9A8 VA: 0x6BA29A8 Slot: 10
	public C2SConnect Clone() { }

	// RVA: 0x6BA2A00 Offset: 0x6B9EA00 VA: 0x6BA2A00
	public int get_Timeout() { }

	// RVA: 0x6BA2A70 Offset: 0x6B9EA70 VA: 0x6BA2A70
	public void set_Timeout(int value) { }

	// RVA: 0x6BA2A80 Offset: 0x6B9EA80 VA: 0x6BA2A80
	public bool get_HasTimeout() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA2A8C Offset: 0x6B9EA8C VA: 0x6BA2A8C
	public void ClearTimeout() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA2A9C Offset: 0x6B9EA9C VA: 0x6BA2A9C Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA2B00 Offset: 0x6B9EB00 VA: 0x6BA2B00 Slot: 9
	public bool Equals(C2SConnect other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA2B68 Offset: 0x6B9EB68 VA: 0x6BA2B68 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA2BCC Offset: 0x6B9EBCC VA: 0x6BA2BCC Slot: 3
	public override string ToString() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA2C24 Offset: 0x6B9EC24 VA: 0x6BA2C24 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA2C44 Offset: 0x6B9EC44 VA: 0x6BA2C44 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA2CAC Offset: 0x6B9ECAC VA: 0x6BA2CAC Slot: 7
	public int CalculateSize() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA2D44 Offset: 0x6B9ED44 VA: 0x6BA2D44 Slot: 4
	public void MergeFrom(C2SConnect other) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA2DA0 Offset: 0x6B9EDA0 VA: 0x6BA2DA0 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA2DC0 Offset: 0x6B9EDC0 VA: 0x6BA2DC0 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x6BA2E74 Offset: 0x6B9EE74 VA: 0x6BA2E74
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Ping.<>c // TypeDefIndex: 24352
{
	// Fields
	public static readonly Ping.<>c <>9; // 0x0

	// Methods

	// RVA: 0x6BA3864 Offset: 0x6B9F864 VA: 0x6BA3864
	private static void .cctor() { }

	// RVA: 0x6BA38CC Offset: 0x6B9F8CC VA: 0x6BA38CC
	public void .ctor() { }

	// RVA: 0x6BA38D4 Offset: 0x6B9F8D4 VA: 0x6BA38D4
	internal Ping <.cctor>b__32_0() { }
}

// Namespace: HabbyFrameNet
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Ping : IMessage<Ping>, IMessage, IEquatable<Ping>, IDeepCloneable<Ping>, IBufferMessage // TypeDefIndex: 24353
{
	// Fields
	private static readonly MessageParser<Ping> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private int _hasBits0; // 0x18
	public const int ClientSendTimeStampFieldNumber = 1;
	private static readonly long ClientSendTimeStampDefaultValue; // 0x8
	private long clientSendTimeStamp_; // 0x20

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Ping> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long ClientSendTimeStamp { get; set; }
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasClientSendTimeStamp { get; }

	// Methods

	// RVA: 0x6BA3060 Offset: 0x6B9F060 VA: 0x6BA3060
	public static MessageParser<Ping> get_Parser() { }

	// RVA: 0x6BA30B8 Offset: 0x6B9F0B8 VA: 0x6BA30B8
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x6BA31BC Offset: 0x6B9F1BC VA: 0x6BA31BC Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA3208 Offset: 0x6B9F208 VA: 0x6BA3208
	public void .ctor() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA3210 Offset: 0x6B9F210 VA: 0x6BA3210
	public void .ctor(Ping other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA3264 Offset: 0x6B9F264 VA: 0x6BA3264 Slot: 10
	public Ping Clone() { }

	// RVA: 0x6BA32BC Offset: 0x6B9F2BC VA: 0x6BA32BC
	public long get_ClientSendTimeStamp() { }

	// RVA: 0x6BA332C Offset: 0x6B9F32C VA: 0x6BA332C
	public void set_ClientSendTimeStamp(long value) { }

	// RVA: 0x6BA3340 Offset: 0x6B9F340 VA: 0x6BA3340
	public bool get_HasClientSendTimeStamp() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA334C Offset: 0x6B9F34C VA: 0x6BA334C
	public void ClearClientSendTimeStamp() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA335C Offset: 0x6B9F35C VA: 0x6BA335C Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA33C0 Offset: 0x6B9F3C0 VA: 0x6BA33C0 Slot: 9
	public bool Equals(Ping other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA3428 Offset: 0x6B9F428 VA: 0x6BA3428 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA348C Offset: 0x6B9F48C VA: 0x6BA348C Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA34E4 Offset: 0x6B9F4E4 VA: 0x6BA34E4 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA3504 Offset: 0x6B9F504 VA: 0x6BA3504 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA356C Offset: 0x6B9F56C VA: 0x6BA356C Slot: 7
	public int CalculateSize() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA3604 Offset: 0x6B9F604 VA: 0x6BA3604 Slot: 4
	public void MergeFrom(Ping other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA3664 Offset: 0x6B9F664 VA: 0x6BA3664 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA3684 Offset: 0x6B9F684 VA: 0x6BA3684 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x6BA373C Offset: 0x6B9F73C VA: 0x6BA373C
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Pong.<>c // TypeDefIndex: 24354
{
	// Fields
	public static readonly Pong.<>c <>9; // 0x0

	// Methods

	// RVA: 0x6BA4640 Offset: 0x6BA0640 VA: 0x6BA4640
	private static void .cctor() { }

	// RVA: 0x6BA46A8 Offset: 0x6BA06A8 VA: 0x6BA46A8
	public void .ctor() { }

	// RVA: 0x6BA46B0 Offset: 0x6BA06B0 VA: 0x6BA46B0
	internal Pong <.cctor>b__59_0() { }
}

// Namespace: HabbyFrameNet
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Pong : IMessage<Pong>, IMessage, IEquatable<Pong>, IDeepCloneable<Pong>, IBufferMessage // TypeDefIndex: 24355
{
	// Fields
	private static readonly MessageParser<Pong> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private int _hasBits0; // 0x18
	public const int ClientSendTimeStampFieldNumber = 1;
	private static readonly long ClientSendTimeStampDefaultValue; // 0x8
	private long clientSendTimeStamp_; // 0x20
	public const int ServerSendTimeStampFieldNumber = 2;
	private static readonly long ServerSendTimeStampDefaultValue; // 0x10
	private long serverSendTimeStamp_; // 0x28
	public const int ServerReceiveTimeStampFieldNumber = 3;
	private static readonly long ServerReceiveTimeStampDefaultValue; // 0x18
	private long serverReceiveTimeStamp_; // 0x30
	public const int ClientReceiveTimeStampFieldNumber = 4;
	private static readonly long ClientReceiveTimeStampDefaultValue; // 0x20
	private long clientReceiveTimeStamp_; // 0x38

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Pong> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ClientSendTimeStamp { get; set; }
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasClientSendTimeStamp { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ServerSendTimeStamp { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasServerSendTimeStamp { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ServerReceiveTimeStamp { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasServerReceiveTimeStamp { get; }
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long ClientReceiveTimeStamp { get; set; }
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasClientReceiveTimeStamp { get; }

	// Methods

	// RVA: 0x6BA3928 Offset: 0x6B9F928 VA: 0x6BA3928
	public static MessageParser<Pong> get_Parser() { }

	// RVA: 0x6BA3980 Offset: 0x6B9F980 VA: 0x6BA3980
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x6BA3A84 Offset: 0x6B9FA84 VA: 0x6BA3A84 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA3AD0 Offset: 0x6B9FAD0 VA: 0x6BA3AD0
	public void .ctor() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA3AD8 Offset: 0x6B9FAD8 VA: 0x6BA3AD8
	public void .ctor(Pong other) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA3B34 Offset: 0x6B9FB34 VA: 0x6BA3B34 Slot: 10
	public Pong Clone() { }

	// RVA: 0x6BA3B8C Offset: 0x6B9FB8C VA: 0x6BA3B8C
	public long get_ClientSendTimeStamp() { }

	// RVA: 0x6BA3BFC Offset: 0x6B9FBFC VA: 0x6BA3BFC
	public void set_ClientSendTimeStamp(long value) { }

	// RVA: 0x6BA3C10 Offset: 0x6B9FC10 VA: 0x6BA3C10
	public bool get_HasClientSendTimeStamp() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA3C1C Offset: 0x6B9FC1C VA: 0x6BA3C1C
	public void ClearClientSendTimeStamp() { }

	// RVA: 0x6BA3C2C Offset: 0x6B9FC2C VA: 0x6BA3C2C
	public long get_ServerSendTimeStamp() { }

	// RVA: 0x6BA3C9C Offset: 0x6B9FC9C VA: 0x6BA3C9C
	public void set_ServerSendTimeStamp(long value) { }

	// RVA: 0x6BA3CB0 Offset: 0x6B9FCB0 VA: 0x6BA3CB0
	public bool get_HasServerSendTimeStamp() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA3CBC Offset: 0x6B9FCBC VA: 0x6BA3CBC
	public void ClearServerSendTimeStamp() { }

	// RVA: 0x6BA3CCC Offset: 0x6B9FCCC VA: 0x6BA3CCC
	public long get_ServerReceiveTimeStamp() { }

	// RVA: 0x6BA3D3C Offset: 0x6B9FD3C VA: 0x6BA3D3C
	public void set_ServerReceiveTimeStamp(long value) { }

	// RVA: 0x6BA3D50 Offset: 0x6B9FD50 VA: 0x6BA3D50
	public bool get_HasServerReceiveTimeStamp() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA3D5C Offset: 0x6B9FD5C VA: 0x6BA3D5C
	public void ClearServerReceiveTimeStamp() { }

	// RVA: 0x6BA3D6C Offset: 0x6B9FD6C VA: 0x6BA3D6C
	public long get_ClientReceiveTimeStamp() { }

	// RVA: 0x6BA3DDC Offset: 0x6B9FDDC VA: 0x6BA3DDC
	public void set_ClientReceiveTimeStamp(long value) { }

	// RVA: 0x6BA3DF0 Offset: 0x6B9FDF0 VA: 0x6BA3DF0
	public bool get_HasClientReceiveTimeStamp() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA3DFC Offset: 0x6B9FDFC VA: 0x6BA3DFC
	public void ClearClientReceiveTimeStamp() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA3E0C Offset: 0x6B9FE0C VA: 0x6BA3E0C Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA3E70 Offset: 0x6B9FE70 VA: 0x6BA3E70 Slot: 9
	public bool Equals(Pong other) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA3F2C Offset: 0x6B9FF2C VA: 0x6BA3F2C Slot: 2
	public override int GetHashCode() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA4008 Offset: 0x6BA0008 VA: 0x6BA4008 Slot: 3
	public override string ToString() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA4060 Offset: 0x6BA0060 VA: 0x6BA4060 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA4080 Offset: 0x6BA0080 VA: 0x6BA4080 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA4188 Offset: 0x6BA0188 VA: 0x6BA4188 Slot: 7
	public int CalculateSize() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA42E8 Offset: 0x6BA02E8 VA: 0x6BA42E8 Slot: 4
	public void MergeFrom(Pong other) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA43B8 Offset: 0x6BA03B8 VA: 0x6BA43B8 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA43D8 Offset: 0x6BA03D8 VA: 0x6BA43D8 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x6BA4510 Offset: 0x6BA0510 VA: 0x6BA4510
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SeqInfo.<>c // TypeDefIndex: 24356
{
	// Fields
	public static readonly SeqInfo.<>c <>9; // 0x0

	// Methods

	// RVA: 0x6BA509C Offset: 0x6BA109C VA: 0x6BA509C
	private static void .cctor() { }

	// RVA: 0x6BA5104 Offset: 0x6BA1104 VA: 0x6BA5104
	public void .ctor() { }

	// RVA: 0x6BA510C Offset: 0x6BA110C VA: 0x6BA510C
	internal SeqInfo <.cctor>b__41_0() { }
}

// Namespace: HabbyFrameNet
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SeqInfo : IMessage<SeqInfo>, IMessage, IEquatable<SeqInfo>, IDeepCloneable<SeqInfo>, IBufferMessage // TypeDefIndex: 24357
{
	// Fields
	private static readonly MessageParser<SeqInfo> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private int _hasBits0; // 0x18
	public const int StartSeqIdFieldNumber = 1;
	private static readonly uint StartSeqIdDefaultValue; // 0x8
	private uint startSeqId_; // 0x1C
	public const int EndSeqIdFieldNumber = 2;
	private static readonly uint EndSeqIdDefaultValue; // 0xC
	private uint endSeqId_; // 0x20

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SeqInfo> Parser { get; }
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor { get; }
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public uint StartSeqId { get; set; }
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasStartSeqId { get; }
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public uint EndSeqId { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasEndSeqId { get; }

	// Methods

	// RVA: 0x6BA4704 Offset: 0x6BA0704 VA: 0x6BA4704
	public static MessageParser<SeqInfo> get_Parser() { }

	// RVA: 0x6BA475C Offset: 0x6BA075C VA: 0x6BA475C
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x6BA4860 Offset: 0x6BA0860 VA: 0x6BA4860 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA48AC Offset: 0x6BA08AC VA: 0x6BA48AC
	public void .ctor() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA48B4 Offset: 0x6BA08B4 VA: 0x6BA48B4
	public void .ctor(SeqInfo other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA4908 Offset: 0x6BA0908 VA: 0x6BA4908 Slot: 10
	public SeqInfo Clone() { }

	// RVA: 0x6BA4960 Offset: 0x6BA0960 VA: 0x6BA4960
	public uint get_StartSeqId() { }

	// RVA: 0x6BA49D0 Offset: 0x6BA09D0 VA: 0x6BA49D0
	public void set_StartSeqId(uint value) { }

	// RVA: 0x6BA49E0 Offset: 0x6BA09E0 VA: 0x6BA49E0
	public bool get_HasStartSeqId() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA49EC Offset: 0x6BA09EC VA: 0x6BA49EC
	public void ClearStartSeqId() { }

	// RVA: 0x6BA49FC Offset: 0x6BA09FC VA: 0x6BA49FC
	public uint get_EndSeqId() { }

	// RVA: 0x6BA4A6C Offset: 0x6BA0A6C VA: 0x6BA4A6C
	public void set_EndSeqId(uint value) { }

	// RVA: 0x6BA4A80 Offset: 0x6BA0A80 VA: 0x6BA4A80
	public bool get_HasEndSeqId() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA4A8C Offset: 0x6BA0A8C VA: 0x6BA4A8C
	public void ClearEndSeqId() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA4A9C Offset: 0x6BA0A9C VA: 0x6BA4A9C Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA4B00 Offset: 0x6BA0B00 VA: 0x6BA4B00 Slot: 9
	public bool Equals(SeqInfo other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA4B84 Offset: 0x6BA0B84 VA: 0x6BA4B84 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA4C10 Offset: 0x6BA0C10 VA: 0x6BA4C10 Slot: 3
	public override string ToString() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA4C68 Offset: 0x6BA0C68 VA: 0x6BA4C68 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA4C88 Offset: 0x6BA0C88 VA: 0x6BA4C88 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA4D20 Offset: 0x6BA0D20 VA: 0x6BA4D20 Slot: 7
	public int CalculateSize() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA4DF8 Offset: 0x6BA0DF8 VA: 0x6BA4DF8 Slot: 4
	public void MergeFrom(SeqInfo other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA4E74 Offset: 0x6BA0E74 VA: 0x6BA4E74 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA4E94 Offset: 0x6BA0E94 VA: 0x6BA4E94 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x6BA4F74 Offset: 0x6BA0F74 VA: 0x6BA4F74
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ReliableAck.<>c // TypeDefIndex: 24358
{
	// Fields
	public static readonly ReliableAck.<>c <>9; // 0x0

	// Methods

	// RVA: 0x6BA5E18 Offset: 0x6BA1E18 VA: 0x6BA5E18
	private static void .cctor() { }

	// RVA: 0x6BA5E80 Offset: 0x6BA1E80 VA: 0x6BA5E80
	public void .ctor() { }

	// RVA: 0x6BA5E88 Offset: 0x6BA1E88 VA: 0x6BA5E88
	internal ReliableAck <.cctor>b__46_0() { }
}

// Namespace: HabbyFrameNet
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ReliableAck : IMessage<ReliableAck>, IMessage, IEquatable<ReliableAck>, IDeepCloneable<ReliableAck>, IBufferMessage // TypeDefIndex: 24359
{
	// Fields
	private static readonly MessageParser<ReliableAck> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private int _hasBits0; // 0x18
	public const int ChannelTypeFieldNumber = 1;
	private static readonly int ChannelTypeDefaultValue; // 0x8
	private int channelType_; // 0x1C
	public const int MaxSeqIdFieldNumber = 2;
	private static readonly int MaxSeqIdDefaultValue; // 0xC
	private int maxSeqId_; // 0x20
	public const int MissedSeqIdsFieldNumber = 3;
	private static readonly FieldCodec<int> _repeated_missedSeqIds_codec; // 0x10
	private readonly RepeatedField<int> missedSeqIds_; // 0x28

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ReliableAck> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ChannelType { get; set; }
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasChannelType { get; }
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MaxSeqId { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasMaxSeqId { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> MissedSeqIds { get; }

	// Methods

	// RVA: 0x6BA5160 Offset: 0x6BA1160 VA: 0x6BA5160
	public static MessageParser<ReliableAck> get_Parser() { }

	// RVA: 0x6BA51B8 Offset: 0x6BA11B8 VA: 0x6BA51B8
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x6BA52BC Offset: 0x6BA12BC VA: 0x6BA52BC Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA5308 Offset: 0x6BA1308 VA: 0x6BA5308
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA5390 Offset: 0x6BA1390 VA: 0x6BA5390
	public void .ctor(ReliableAck other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA542C Offset: 0x6BA142C VA: 0x6BA542C Slot: 10
	public ReliableAck Clone() { }

	// RVA: 0x6BA5484 Offset: 0x6BA1484 VA: 0x6BA5484
	public int get_ChannelType() { }

	// RVA: 0x6BA54F4 Offset: 0x6BA14F4 VA: 0x6BA54F4
	public void set_ChannelType(int value) { }

	// RVA: 0x6BA5504 Offset: 0x6BA1504 VA: 0x6BA5504
	public bool get_HasChannelType() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA5510 Offset: 0x6BA1510 VA: 0x6BA5510
	public void ClearChannelType() { }

	// RVA: 0x6BA5520 Offset: 0x6BA1520 VA: 0x6BA5520
	public int get_MaxSeqId() { }

	// RVA: 0x6BA5590 Offset: 0x6BA1590 VA: 0x6BA5590
	public void set_MaxSeqId(int value) { }

	// RVA: 0x6BA55A4 Offset: 0x6BA15A4 VA: 0x6BA55A4
	public bool get_HasMaxSeqId() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA55B0 Offset: 0x6BA15B0 VA: 0x6BA55B0
	public void ClearMaxSeqId() { }

	// RVA: 0x6BA55C0 Offset: 0x6BA15C0 VA: 0x6BA55C0
	public RepeatedField<int> get_MissedSeqIds() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA55C8 Offset: 0x6BA15C8 VA: 0x6BA55C8 Slot: 0
	public override bool Equals(object other) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA562C Offset: 0x6BA162C VA: 0x6BA562C Slot: 9
	public bool Equals(ReliableAck other) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA56F4 Offset: 0x6BA16F4 VA: 0x6BA56F4 Slot: 2
	public override int GetHashCode() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA57A0 Offset: 0x6BA17A0 VA: 0x6BA57A0 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA57F8 Offset: 0x6BA17F8 VA: 0x6BA57F8 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA5818 Offset: 0x6BA1818 VA: 0x6BA5818 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA5930 Offset: 0x6BA1930 VA: 0x6BA5930 Slot: 7
	public int CalculateSize() { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA5A78 Offset: 0x6BA1A78 VA: 0x6BA5A78 Slot: 4
	public void MergeFrom(ReliableAck other) { }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	// RVA: 0x6BA5B3C Offset: 0x6BA1B3C VA: 0x6BA5B3C Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x6BA5B5C Offset: 0x6BA1B5C VA: 0x6BA5B5C Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x6BA5CD0 Offset: 0x6BA1CD0 VA: 0x6BA5CD0
	private static void .cctor() { }
}

// Namespace: FalconNet
public enum NetErrorCode // TypeDefIndex: 24360
{
	// Fields
	public int value__; // 0x0
	public const NetErrorCode ServerError = 0;
}

// Namespace: FalconNet
internal enum NetEvent // TypeDefIndex: 24361
{
	// Fields
	public ushort value__; // 0x0
	public const NetEvent NetworkEventNetPeerUpdate = 1;
	public const NetEvent NetworkEventNetPeerStateSwitching = 2;
	public const NetEvent NetworkSocketConnect = 3;
	public const NetEvent NetworkSocketBind = 4;
	public const NetEvent NetworkSocketStop = 5;
	public const NetEvent NetworkSocketReinitialization = 6;
	public const NetEvent NetworkUdpSocketReady = 7;
	public const NetEvent NetworkTcpSocketReady = 8;
	public const NetEvent NetworkPeerStoped = 9;
	public const NetEvent NetworkEventSendMsg = 10;
	public const NetEvent NetworkEventBatchSendMsg = 11;
	public const NetEvent NetworkEventConnectionSend = 12;
	public const NetEvent NetworkEventPeerReceiveMsg = 13;
	public const NetEvent NetworkEventConnectionReceiveMsg = 14;
	public const NetEvent UserSendMessage = 15;
	public const NetEvent ReceiveSocketMessage = 16;
	public const NetEvent NetworkUdpSocketError = 17;
	public const NetEvent NetworkTcpSocketError = 18;
	public const NetEvent NetworkUdpDetectSuccess = 19;
	public const NetEvent NetworkEventCloseConnection = 20;
	public const NetEvent NetworkEventCreateConnection = 21;
	public const NetEvent NetworkEventReplaceConnection = 22;
	public const NetEvent NetworkExternalConnected = 23;
	public const NetEvent NetworkExternalDisconnected = 24;
	public const NetEvent NetworkExternalError = 25;
	public const NetEvent NetworkEventProcessMetric = 26;
	public const NetEvent NetworkEventStatisticsUpdate = 27;
	public const NetEvent NetworkEventMetricStatisticsRefresh = 28;
}

// Namespace: FalconNet
internal enum NetPeerState // TypeDefIndex: 24362
{
	// Fields
	public byte value__; // 0x0
	public const NetPeerState NotInitialized = 0;
	public const NetPeerState Initialize = 1;
	public const NetPeerState Run = 2;
	public const NetPeerState RunHalf = 3;
	public const NetPeerState Stop = 4;
	public const NetPeerState ErrorOccurred = 5;
}

// Namespace: FalconNet
internal enum InitializationMode // TypeDefIndex: 24363
{
	// Fields
	public int value__; // 0x0
	public const InitializationMode None = 0;
	public const InitializationMode Connect = 1;
	public const InitializationMode Bind = 2;
}

// Namespace: FalconNet
internal enum EndPointRole // TypeDefIndex: 24364
{
	// Fields
	public int value__; // 0x0
	public const EndPointRole Client = 0;
	public const EndPointRole Server = 1;
}

// Namespace: FalconNet
public enum ConnectionState // TypeDefIndex: 24365
{
	// Fields
	public byte value__; // 0x0
	public const ConnectionState Initializing = 0;
	public const ConnectionState Connecting = 1;
	public const ConnectionState Connected = 2;
	public const ConnectionState Disconnected = 3;
}

// Namespace: FalconNet
internal abstract class NetConnection // TypeDefIndex: 24366
{
	// Fields
	public readonly IPEndPoint IpEndPoint; // 0x10
	protected readonly bool IsInitiator; // 0x18
	public readonly IProtoParse InternalProtoParse; // 0x20
	public readonly IProtoParse ExternalProtoParse; // 0x28
	private List<int> _rttSamples; // 0x30
	public int AvgRtt; // 0x38
	private int _connectionPackSequenceId; // 0x3C

	// Properties
	public abstract ProtocolType ProtocolType { get; }
	public abstract ConnectionState ConnState { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ProtocolType get_ProtocolType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract ConnectionState get_ConnState();

	// RVA: 0x6BA5ED8 Offset: 0x6BA1ED8 VA: 0x6BA5ED8
	protected void .ctor(bool isInitiator, IPEndPoint endPoint, IProtoParse internalProtoParse, IProtoParse externalProtoParse) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void UpdateLogic();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void OnSendMessage(ushort msgId, byte[] payload, EChannelType channelType = 0);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void OnReceiveMessage(object headerData, ByteArray payload, long receiveTime, IEvent evt);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void HandlePendingReceiveMessage(byte channelType, IEvent evt);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void HandlePendingSendMessage(byte channelType, IEvent evt);

	// RVA: 0x6BA5FC0 Offset: 0x6BA1FC0 VA: 0x6BA5FC0
	public void CalcAvgRtt(int nowRtt) { }

	// RVA: 0x6BA60C8 Offset: 0x6BA20C8 VA: 0x6BA60C8
	public int IncrementConnectionPackSequenceId() { }
}

// Namespace: FalconNet
internal class ReceiveMsg : IRecyclable // TypeDefIndex: 24367
{
	// Fields
	internal IPEndPoint IpEndPoint; // 0x10
	internal long ReceiveTime; // 0x18
	internal IMessage Msg; // 0x20
	internal ProtocolType ProtocolType; // 0x28
	internal byte ChannelType; // 0x2C
	internal ushort MsgId; // 0x2E
	internal int SeqId; // 0x30

	// Methods

	// RVA: 0x6BA60E4 Offset: 0x6BA20E4 VA: 0x6BA60E4 Slot: 4
	public void Recycle() { }

	// RVA: 0x6BA6114 Offset: 0x6BA2114 VA: 0x6BA6114
	public void .ctor() { }
}

// Namespace: FalconNet
public class UdpSendItem // TypeDefIndex: 24368
{
	// Fields
	[CompilerGenerated]
	private readonly byte[] <Buffer>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly IPEndPoint <RemoteEndPoint>k__BackingField; // 0x18

	// Properties
	public byte[] Buffer { get; }
	public IPEndPoint RemoteEndPoint { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BA611C Offset: 0x6BA211C VA: 0x6BA611C
	public byte[] get_Buffer() { }

	[CompilerGenerated]
	// RVA: 0x6BA6124 Offset: 0x6BA2124 VA: 0x6BA6124
	public IPEndPoint get_RemoteEndPoint() { }

	// RVA: 0x6BA612C Offset: 0x6BA212C VA: 0x6BA612C
	public void .ctor(byte[] buffer, IPEndPoint remoteEndPoint) { }
}

// Namespace: FalconNet
internal abstract class StateBase // TypeDefIndex: 24369
{
	// Fields
	protected readonly UdpConnection Connection; // 0x10
	protected readonly bool IsInitiator; // 0x18
	[CompilerGenerated]
	private long <EnterTime>k__BackingField; // 0x20
	[CompilerGenerated]
	private ConnectionState <LastState>k__BackingField; // 0x28

	// Properties
	public long EnterTime { get; set; }
	public abstract ConnectionState CurState { get; }
	public ConnectionState LastState { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BA6170 Offset: 0x6BA2170 VA: 0x6BA6170
	public long get_EnterTime() { }

	[CompilerGenerated]
	// RVA: 0x6BA6178 Offset: 0x6BA2178 VA: 0x6BA6178
	protected void set_EnterTime(long value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ConnectionState get_CurState();

	[CompilerGenerated]
	// RVA: 0x6BA6180 Offset: 0x6BA2180 VA: 0x6BA6180
	public ConnectionState get_LastState() { }

	[CompilerGenerated]
	// RVA: 0x6BA6188 Offset: 0x6BA2188 VA: 0x6BA6188
	public void set_LastState(ConnectionState value) { }

	// RVA: 0x6BA6190 Offset: 0x6BA2190 VA: 0x6BA6190
	protected void .ctor(UdpConnection connection, bool isInitiator) { }

	// RVA: 0x6BA61CC Offset: 0x6BA21CC VA: 0x6BA61CC Slot: 5
	public virtual void Enter(ConnectionState lastState) { }

	// RVA: 0x6BA6320 Offset: 0x6BA2320 VA: 0x6BA6320 Slot: 6
	public virtual bool IsValidMsgReceive(ushort msgId) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract StateBase HandleInternalMsg(UdpReceiveMsgData msgData);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Update();
}

// Namespace: FalconNet
internal class StateConnecting : StateBase // TypeDefIndex: 24370
{
	// Properties
	public override ConnectionState CurState { get; }

	// Methods

	// RVA: 0x6BA6330 Offset: 0x6BA2330 VA: 0x6BA6330 Slot: 4
	public override ConnectionState get_CurState() { }

	// RVA: 0x6BA6338 Offset: 0x6BA2338 VA: 0x6BA6338
	public void .ctor(UdpConnection connection, bool isInitiator) { }

	// RVA: 0x6BA6374 Offset: 0x6BA2374 VA: 0x6BA6374 Slot: 5
	public override void Enter(ConnectionState lastState) { }

	// RVA: 0x6BA64C4 Offset: 0x6BA24C4 VA: 0x6BA64C4 Slot: 8
	public override bool Update() { }

	// RVA: 0x6BA6548 Offset: 0x6BA2548 VA: 0x6BA6548 Slot: 6
	public override bool IsValidMsgReceive(ushort msgId) { }

	// RVA: 0x6BA655C Offset: 0x6BA255C VA: 0x6BA655C Slot: 7
	public override StateBase HandleInternalMsg(UdpReceiveMsgData msgData) { }
}

// Namespace: FalconNet
internal class StateConnected : StateBase // TypeDefIndex: 24371
{
	// Fields
	private long remoteTickTime; // 0x30
	private long lastSendHeartbeatTime; // 0x38

	// Properties
	public override ConnectionState CurState { get; }

	// Methods

	// RVA: 0x6BA681C Offset: 0x6BA281C VA: 0x6BA681C Slot: 4
	public override ConnectionState get_CurState() { }

	// RVA: 0x6BA67E0 Offset: 0x6BA27E0 VA: 0x6BA67E0
	public void .ctor(UdpConnection connection, bool isInitiator) { }

	// RVA: 0x6BA6824 Offset: 0x6BA2824 VA: 0x6BA6824 Slot: 5
	public override void Enter(ConnectionState lastState) { }

	// RVA: 0x6BA6974 Offset: 0x6BA2974 VA: 0x6BA6974 Slot: 8
	public override bool Update() { }

	// RVA: 0x6BA6A70 Offset: 0x6BA2A70 VA: 0x6BA6A70 Slot: 6
	public override bool IsValidMsgReceive(ushort msgId) { }

	// RVA: 0x6BA6A78 Offset: 0x6BA2A78 VA: 0x6BA6A78 Slot: 7
	public override StateBase HandleInternalMsg(UdpReceiveMsgData msgData) { }
}

// Namespace: FalconNet
internal enum EDisconnectState // TypeDefIndex: 24372
{
	// Fields
	public int value__; // 0x0
	public const EDisconnectState Normal = 0;
	public const EDisconnectState Replace = 1;
}

// Namespace: FalconNet
internal class StateDisconnected : StateBase // TypeDefIndex: 24373
{
	// Fields
	public EDisconnectState InnerState; // 0x2C
	private int timeout; // 0x30

	// Properties
	public override ConnectionState CurState { get; }

	// Methods

	// RVA: 0x6BA7054 Offset: 0x6BA3054 VA: 0x6BA7054 Slot: 4
	public override ConnectionState get_CurState() { }

	// RVA: 0x6BA6EE4 Offset: 0x6BA2EE4 VA: 0x6BA6EE4
	public void .ctor(UdpConnection connection, bool isInitiator, EDisconnectState state, int timeout = 0) { }

	// RVA: 0x6BA705C Offset: 0x6BA305C VA: 0x6BA705C Slot: 5
	public override void Enter(ConnectionState lastStates) { }

	// RVA: 0x6BA71F0 Offset: 0x6BA31F0 VA: 0x6BA71F0 Slot: 8
	public override bool Update() { }

	// RVA: 0x6BA71F8 Offset: 0x6BA31F8 VA: 0x6BA71F8 Slot: 7
	public override StateBase HandleInternalMsg(UdpReceiveMsgData msgData) { }
}

// Namespace: FalconNet
internal class ConnectStateFsm // TypeDefIndex: 24374
{
	// Fields
	public StateBase State; // 0x10

	// Methods

	// RVA: 0x6BA73D8 Offset: 0x6BA33D8 VA: 0x6BA73D8
	public void .ctor() { }
}

// Namespace: FalconNet
internal sealed class UdpConnection : NetConnection // TypeDefIndex: 24375
{
	// Fields
	private readonly ConnectStateFsm stateFsm; // 0x40
	private readonly Dictionary<EChannelType, BaseSendChannel> sendChannels; // 0x48
	private readonly Dictionary<EChannelType, BaseReceiveChannel> receiveChannels; // 0x50
	internal int ConnTimeout; // 0x58

	// Properties
	public override ProtocolType ProtocolType { get; }
	public override ConnectionState ConnState { get; }

	// Methods

	// RVA: 0x6BA73E0 Offset: 0x6BA33E0 VA: 0x6BA73E0
	public void SetTimeout(int timeout) { }

	// RVA: 0x6BA73E8 Offset: 0x6BA33E8 VA: 0x6BA73E8 Slot: 4
	public override ProtocolType get_ProtocolType() { }

	// RVA: 0x6BA73F0 Offset: 0x6BA33F0 VA: 0x6BA73F0 Slot: 5
	public override ConnectionState get_ConnState() { }

	// RVA: 0x6BA7418 Offset: 0x6BA3418 VA: 0x6BA7418
	public void .ctor(bool isInitiator, IPEndPoint endPoint, IProtoParse internalProtoParse, IProtoParse externalProtoParse, bool replaceFlag = False) { }

	// RVA: 0x6BA7B20 Offset: 0x6BA3B20 VA: 0x6BA7B20 Slot: 6
	public override void UpdateLogic() { }

	// RVA: 0x6BA7EE8 Offset: 0x6BA3EE8 VA: 0x6BA7EE8
	private int GetAvgRtt() { }

	// RVA: 0x6BA7C5C Offset: 0x6BA3C5C VA: 0x6BA7C5C
	private void HandleChannelLogic() { }

	// RVA: 0x6BA6444 Offset: 0x6BA2444 VA: 0x6BA6444
	public void OnSendMessage(ushort msgId, IMessage data, EChannelType channelType = 0) { }

	// RVA: 0x6BA7EF0 Offset: 0x6BA3EF0 VA: 0x6BA7EF0 Slot: 7
	public override void OnSendMessage(ushort msgId, byte[] data, EChannelType channelType = 0) { }

	// RVA: 0x6BA7F70 Offset: 0x6BA3F70 VA: 0x6BA7F70 Slot: 8
	public override void OnReceiveMessage(object headerData, ByteArray payload, long receiveTime, IEvent evt) { }

	// RVA: 0x6BA816C Offset: 0x6BA416C VA: 0x6BA816C Slot: 9
	public override void HandlePendingReceiveMessage(byte channelType, IEvent evt) { }

	// RVA: 0x6BA81D4 Offset: 0x6BA41D4 VA: 0x6BA81D4 Slot: 10
	public override void HandlePendingSendMessage(byte channelType, IEvent evt) { }

	// RVA: 0x6BA823C Offset: 0x6BA423C VA: 0x6BA823C
	public void HandleReceivedMsg(UdpReceiveMsgData msgData) { }

	// RVA: 0x6BA671C Offset: 0x6BA271C VA: 0x6BA671C
	public void OnReceiveAck(ReliableAck ack) { }

	// RVA: 0x6BA8708 Offset: 0x6BA4708 VA: 0x6BA8708
	private void HandleReceivedInternalMsg(UdpReceiveMsgData msgData) { }
}

// Namespace: FalconNet
internal class SocketAsyncEventArgsPool // TypeDefIndex: 24376
{
	// Fields
	private readonly ConcurrentQueue<SocketAsyncEventArgs> _pool; // 0x10
	private readonly int _capacity; // 0x18
	private readonly int _bufferSize; // 0x1C
	private readonly bool _isReceivePool; // 0x20
	private readonly Action<object, SocketAsyncEventArgs> _onCompletedCallback; // 0x28

	// Methods

	// RVA: 0x6BA87F8 Offset: 0x6BA47F8 VA: 0x6BA87F8
	public void .ctor(int capacity, int bufferSize, bool isReceivePool, Action<object, SocketAsyncEventArgs> onCompletedCallback) { }

	// RVA: 0x6BA89C8 Offset: 0x6BA49C8 VA: 0x6BA89C8
	public SocketAsyncEventArgs Get() { }

	// RVA: 0x6BA8B00 Offset: 0x6BA4B00 VA: 0x6BA8B00
	public void Return(SocketAsyncEventArgs args) { }

	// RVA: 0x6BA8BC8 Offset: 0x6BA4BC8 VA: 0x6BA8BC8
	private void OnCompleted(object sender, SocketAsyncEventArgs e) { }
}

// Namespace: FalconNet
internal interface INetPeer // TypeDefIndex: 24377
{
	// Properties
	public abstract IProtoParse InternalProtoParse { get; }
	public abstract ConcurrentQueue<ValueTuple<IPEndPoint, ushort, IMessage>> ReceiveMsgQueue { get; }
	public abstract ConcurrentQueue<ExternalEventParameter> ExternalEventQueue { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void AddParseExternal<T>(ushort protoDef, T msg);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-INetPeer.AddParseExternal<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IProtoParse get_InternalProtoParse();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ConcurrentQueue<ValueTuple<IPEndPoint, ushort, IMessage>> get_ReceiveMsgQueue();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract ConcurrentQueue<ExternalEventParameter> get_ExternalEventQueue();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Disconnect();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Dispose();
}

// Namespace: FalconNet
internal interface INetPeerClient : INetPeer // TypeDefIndex: 24378
{
	// Properties
	public abstract ConnectionState ConnState { get; }
	public abstract NetPeerState PeerState { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ConnectionState get_ConnState();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract NetPeerState get_PeerState();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SendMessage(IMessage message, EChannelType channelType);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SendMessage(ushort msgId, byte[] msg, EChannelType channelType);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Connect(IPEndPoint remoteIPEndPoint, bool isForceTcp = False);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Reconnect();
}

// Namespace: FalconNet
internal interface INetPeerServer : INetPeer // TypeDefIndex: 24379
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SendMessage(IPEndPoint remoteIPEndPoint, ushort msgId, byte[] msg, EChannelType channelType);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SendMessage(IPEndPoint remoteIPEndPoint, IMessage message, EChannelType channelType);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Bind(int port);
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class NetPeerClient.<>c // TypeDefIndex: 24380
{
	// Fields
	public static readonly NetPeerClient.<>c <>9; // 0x0
	public static EventHandler<SocketIODataEventArgs<UdpHeaderData>> <>9__33_0; // 0x8
	public static EventHandler<SocketIOErrorEventArgs> <>9__33_1; // 0x10
	public static EventHandler<SocketIODataEventArgs<TcpHeaderData>> <>9__45_0; // 0x18
	public static EventHandler<SocketIOErrorEventArgs> <>9__45_1; // 0x20

	// Methods

	// RVA: 0x6BACFDC Offset: 0x6BA8FDC VA: 0x6BACFDC
	private static void .cctor() { }

	// RVA: 0x6BAD044 Offset: 0x6BA9044 VA: 0x6BAD044
	public void .ctor() { }

	// RVA: 0x6BAD04C Offset: 0x6BA904C VA: 0x6BAD04C
	internal void <RegisterSocketEvents>b__33_0(object sender, SocketIODataEventArgs<UdpHeaderData> e) { }

	// RVA: 0x6BAD184 Offset: 0x6BA9184 VA: 0x6BAD184
	internal void <RegisterSocketEvents>b__33_1(object sender, SocketIOErrorEventArgs e) { }

	// RVA: 0x6BAD284 Offset: 0x6BA9284 VA: 0x6BAD284
	internal void <Connect>b__45_0(object sender, SocketIODataEventArgs<TcpHeaderData> e) { }

	// RVA: 0x6BAD3BC Offset: 0x6BA93BC VA: 0x6BAD3BC
	internal void <Connect>b__45_1(object sender, SocketIOErrorEventArgs e) { }
}

// Namespace: FalconNet
internal class NetPeerClient : INetPeerClient, INetPeer // TypeDefIndex: 24381
{
	// Fields
	[CompilerGenerated]
	private readonly IProtoParse <InternalProtoParse>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly IProtoParse <ExternalProtoParse>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly ConcurrentQueue<ValueTuple<IPEndPoint, ushort, IMessage>> <ReceiveMsgQueue>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly ConcurrentQueue<ExternalEventParameter> <ExternalEventQueue>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly IUdpSocketIO<UdpHeaderData> <UdpSocketIO>k__BackingField; // 0x30
	[CompilerGenerated]
	private ISocketIO<TcpHeaderData> <TcpSocketIO>k__BackingField; // 0x38
	private ClientPeerStateFSM _peerStateFsm; // 0x40
	private NetConnection _connection; // 0x48
	internal bool _isConnectionConnecting; // 0x50
	private EventHandler<SocketIODataEventArgs<UdpHeaderData>> _udpDataReceivedHandler; // 0x58
	private EventHandler<SocketIOErrorEventArgs> _udpErrorOccurredHandler; // 0x60
	private EventHandler<SocketIODataEventArgs<TcpHeaderData>> _tcpDataReceivedHandler; // 0x68
	private EventHandler<SocketIOErrorEventArgs> _tcpErrorOccurredHandler; // 0x70
	private IPEndPoint _remoteEndpoint; // 0x78
	private ProtocolType _curProtocolType; // 0x80

	// Properties
	public IProtoParse InternalProtoParse { get; }
	public IProtoParse ExternalProtoParse { get; }
	public ConcurrentQueue<ValueTuple<IPEndPoint, ushort, IMessage>> ReceiveMsgQueue { get; }
	public ConcurrentQueue<ExternalEventParameter> ExternalEventQueue { get; }
	private IUdpSocketIO<UdpHeaderData> UdpSocketIO { get; }
	private ISocketIO<TcpHeaderData> TcpSocketIO { get; set; }
	public NetPeerState PeerState { get; }
	public ConnectionState ConnState { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BA8BE4 Offset: 0x6BA4BE4 VA: 0x6BA8BE4 Slot: 11
	public IProtoParse get_InternalProtoParse() { }

	[CompilerGenerated]
	// RVA: 0x6BA8BEC Offset: 0x6BA4BEC VA: 0x6BA8BEC
	public IProtoParse get_ExternalProtoParse() { }

	[CompilerGenerated]
	// RVA: 0x6BA8BF4 Offset: 0x6BA4BF4 VA: 0x6BA8BF4 Slot: 12
	public ConcurrentQueue<ValueTuple<IPEndPoint, ushort, IMessage>> get_ReceiveMsgQueue() { }

	[CompilerGenerated]
	// RVA: 0x6BA8BFC Offset: 0x6BA4BFC VA: 0x6BA8BFC Slot: 13
	public ConcurrentQueue<ExternalEventParameter> get_ExternalEventQueue() { }

	[CompilerGenerated]
	// RVA: 0x6BA8C04 Offset: 0x6BA4C04 VA: 0x6BA8C04
	private IUdpSocketIO<UdpHeaderData> get_UdpSocketIO() { }

	[CompilerGenerated]
	// RVA: 0x6BA8C0C Offset: 0x6BA4C0C VA: 0x6BA8C0C
	private ISocketIO<TcpHeaderData> get_TcpSocketIO() { }

	[CompilerGenerated]
	// RVA: 0x6BA8C14 Offset: 0x6BA4C14 VA: 0x6BA8C14
	private void set_TcpSocketIO(ISocketIO<TcpHeaderData> value) { }

	// RVA: 0x6BA8C1C Offset: 0x6BA4C1C VA: 0x6BA8C1C Slot: 5
	public NetPeerState get_PeerState() { }

	// RVA: 0x6BA8CCC Offset: 0x6BA4CCC VA: 0x6BA8CCC Slot: 4
	public ConnectionState get_ConnState() { }

	// RVA: 0x6BA8D18 Offset: 0x6BA4D18 VA: 0x6BA8D18
	public void .ctor() { }

	// RVA: 0x6BA979C Offset: 0x6BA579C VA: 0x6BA979C
	private void RegisterSocketEvents() { }

	// RVA: 0x6BA9A84 Offset: 0x6BA5A84 VA: 0x6BA9A84
	private void UnregisterSocketEvents() { }

	// RVA: 0x6BA9304 Offset: 0x6BA5304 VA: 0x6BA9304
	public void RegisterNetEvent() { }

	// RVA: 0x6BA9D00 Offset: 0x6BA5D00 VA: 0x6BA9D00
	public void UnRegisterNetEvent() { }

	// RVA: -1 Offset: -1 Slot: 10
	public void AddParseExternal<T>(ushort protoDef, T msg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46817A4 Offset: 0x467D7A4 VA: 0x46817A4
	|-NetPeerClient.AddParseExternal<object>
	|
	|-RVA: 0x4681864 Offset: 0x467D864 VA: 0x4681864
	|-NetPeerClient.AddParseExternal<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x6BAA198 Offset: 0x6BA6198 VA: 0x6BAA198 Slot: 8
	public void Connect(IPEndPoint remoteIPEndPoint, bool isForceTcp = False) { }

	// RVA: 0x6BAA304 Offset: 0x6BA6304 VA: 0x6BAA304 Slot: 9
	public void Reconnect() { }

	// RVA: 0x6BAA41C Offset: 0x6BA641C VA: 0x6BAA41C Slot: 14
	public void Disconnect() { }

	// RVA: 0x6BAA5AC Offset: 0x6BA65AC VA: 0x6BAA5AC Slot: 15
	public void Dispose() { }

	// RVA: 0x6BAA5C4 Offset: 0x6BA65C4 VA: 0x6BAA5C4 Slot: 6
	public void SendMessage(IMessage message, EChannelType channelType) { }

	// RVA: 0x6BAA6AC Offset: 0x6BA66AC VA: 0x6BAA6AC Slot: 7
	public void SendMessage(ushort msgId, byte[] msg, EChannelType channelType) { }

	// RVA: 0x6BAA7A0 Offset: 0x6BA67A0 VA: 0x6BAA7A0
	private void HandleUserSendMessageEvent(IEvent evt) { }

	// RVA: 0x6BAA8C4 Offset: 0x6BA68C4 VA: 0x6BAA8C4
	private void Connect(IEvent evt) { }

	// RVA: 0x6BAAEBC Offset: 0x6BA6EBC VA: 0x6BAAEBC
	private void SocketStop(IEvent evt) { }

	// RVA: 0x6BAB230 Offset: 0x6BA7230 VA: 0x6BAB230
	private void SendTo(IEvent evt) { }

	// RVA: 0x6BAB698 Offset: 0x6BA7698 VA: 0x6BAB698
	private void BatchUdpSendTo(IEvent evt) { }

	// RVA: 0x6BAB830 Offset: 0x6BA7830 VA: 0x6BAB830
	private void ReceiveMessage(IEvent evt) { }

	// RVA: 0x6BABB80 Offset: 0x6BA7B80 VA: 0x6BABB80
	private void RecycleConnection(IEvent evt) { }

	// RVA: 0x6BABF0C Offset: 0x6BA7F0C VA: 0x6BABF0C
	private void Update(IEvent evt) { }

	// RVA: 0x6BABFE8 Offset: 0x6BA7FE8 VA: 0x6BABFE8
	private void HandleConnectionReceiveMsg(IEvent evt) { }

	// RVA: 0x6BAC120 Offset: 0x6BA8120 VA: 0x6BAC120
	private void HandleConnectionSendMsg(IEvent evt) { }

	// RVA: 0x6BAC258 Offset: 0x6BA8258 VA: 0x6BAC258
	private void CreateConnection(IEvent evt) { }

	// RVA: 0x6BAC668 Offset: 0x6BA8668 VA: 0x6BAC668
	private void Reinitialization(IEvent evt) { }

	// RVA: 0x6BAC8C8 Offset: 0x6BA88C8 VA: 0x6BAC8C8
	private void NetworkPeerStopped(IEvent evt) { }

	// RVA: 0x6BAC8EC Offset: 0x6BA88EC VA: 0x6BAC8EC
	private void HandleExternalEvent(IEvent evt) { }

	// RVA: -1 Offset: -1
	private void CallConnectionReceiveAsync<THeader>(THeader udpHeaderData, ByteArray payload, long receiveTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46819AC Offset: 0x467D9AC VA: 0x46819AC
	|-NetPeerClient.CallConnectionReceiveAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x6BACB98 Offset: 0x6BA8B98 VA: 0x6BACB98
	private void HandleReceiveSocketMessage(IEvent evt) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class NetPeerServer.<>c // TypeDefIndex: 24382
{
	// Fields
	public static readonly NetPeerServer.<>c <>9; // 0x0
	public static EventHandler<SocketIODataEventArgs<UdpHeaderData>> <>9__35_0; // 0x8
	public static EventHandler<SocketIOErrorEventArgs> <>9__35_1; // 0x10
	public static EventHandler<SocketIODataEventArgs<TcpHeaderData>> <>9__35_2; // 0x18
	public static EventHandler<SocketIOErrorEventArgs> <>9__35_3; // 0x20

	// Methods

	// RVA: 0x6BB0C30 Offset: 0x6BACC30 VA: 0x6BB0C30
	private static void .cctor() { }

	// RVA: 0x6BB0C98 Offset: 0x6BACC98 VA: 0x6BB0C98
	public void .ctor() { }

	// RVA: 0x6BB0CA0 Offset: 0x6BACCA0 VA: 0x6BB0CA0
	internal void <RegisterSocketEvents>b__35_0(object sender, SocketIODataEventArgs<UdpHeaderData> e) { }

	// RVA: 0x6BB0DE4 Offset: 0x6BACDE4 VA: 0x6BB0DE4
	internal void <RegisterSocketEvents>b__35_1(object sender, SocketIOErrorEventArgs e) { }

	// RVA: 0x6BB0E84 Offset: 0x6BACE84 VA: 0x6BB0E84
	internal void <RegisterSocketEvents>b__35_2(object sender, SocketIODataEventArgs<TcpHeaderData> e) { }

	// RVA: 0x6BB0FC8 Offset: 0x6BACFC8 VA: 0x6BB0FC8
	internal void <RegisterSocketEvents>b__35_3(object sender, SocketIOErrorEventArgs e) { }
}

// Namespace: FalconNet
internal class NetPeerServer : INetPeerServer, INetPeer // TypeDefIndex: 24383
{
	// Fields
	[CompilerGenerated]
	private readonly IProtoParse <InternalProtoParse>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly IProtoParse <ExternalProtoParse>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly ConcurrentQueue<ValueTuple<IPEndPoint, ushort, IMessage>> <ReceiveMsgQueue>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly ConcurrentQueue<ExternalEventParameter> <ExternalEventQueue>k__BackingField; // 0x28
	private EventHandler<SocketIODataEventArgs<UdpHeaderData>> _udpDataReceivedHandler; // 0x30
	private EventHandler<SocketIOErrorEventArgs> _udpErrorOccurredHandler; // 0x38
	private EventHandler<SocketIODataEventArgs<TcpHeaderData>> _tcpDataReceivedHandler; // 0x40
	private EventHandler<SocketIOErrorEventArgs> _tcpErrorOccurredHandler; // 0x48
	[CompilerGenerated]
	private readonly INetPeerState <CurrentState>k__BackingField; // 0x50
	[CompilerGenerated]
	private readonly IUdpSocketIO<UdpHeaderData> <UdpSocketIO>k__BackingField; // 0x58
	[CompilerGenerated]
	private readonly ISocketIO<TcpHeaderData> <TcpSocketIO>k__BackingField; // 0x60
	private readonly Dictionary<IPEndPoint, NetConnection> _netConnections; // 0x68
	private ServerPeerStateFSM _peerStateFsm; // 0x70

	// Properties
	public IProtoParse InternalProtoParse { get; }
	public IProtoParse ExternalProtoParse { get; }
	public ConcurrentQueue<ValueTuple<IPEndPoint, ushort, IMessage>> ReceiveMsgQueue { get; }
	public ConcurrentQueue<ExternalEventParameter> ExternalEventQueue { get; }
	public INetPeerState CurrentState { get; }
	private IUdpSocketIO<UdpHeaderData> UdpSocketIO { get; }
	private ISocketIO<TcpHeaderData> TcpSocketIO { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BAD4BC Offset: 0x6BA94BC VA: 0x6BAD4BC Slot: 8
	public IProtoParse get_InternalProtoParse() { }

	[CompilerGenerated]
	// RVA: 0x6BAD4C4 Offset: 0x6BA94C4 VA: 0x6BAD4C4
	public IProtoParse get_ExternalProtoParse() { }

	[CompilerGenerated]
	// RVA: 0x6BAD4CC Offset: 0x6BA94CC VA: 0x6BAD4CC Slot: 9
	public ConcurrentQueue<ValueTuple<IPEndPoint, ushort, IMessage>> get_ReceiveMsgQueue() { }

	[CompilerGenerated]
	// RVA: 0x6BAD4D4 Offset: 0x6BA94D4 VA: 0x6BAD4D4 Slot: 10
	public ConcurrentQueue<ExternalEventParameter> get_ExternalEventQueue() { }

	[CompilerGenerated]
	// RVA: 0x6BAD4DC Offset: 0x6BA94DC VA: 0x6BAD4DC
	public INetPeerState get_CurrentState() { }

	[CompilerGenerated]
	// RVA: 0x6BAD4E4 Offset: 0x6BA94E4 VA: 0x6BAD4E4
	private IUdpSocketIO<UdpHeaderData> get_UdpSocketIO() { }

	[CompilerGenerated]
	// RVA: 0x6BAD4EC Offset: 0x6BA94EC VA: 0x6BAD4EC
	private ISocketIO<TcpHeaderData> get_TcpSocketIO() { }

	// RVA: 0x6BAD4F4 Offset: 0x6BA94F4 VA: 0x6BAD4F4
	public void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 7
	public void AddParseExternal<T>(ushort protoDef, T msg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4681AE8 Offset: 0x467DAE8 VA: 0x4681AE8
	|-NetPeerServer.AddParseExternal<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x6BAE144 Offset: 0x6BAA144 VA: 0x6BAE144 Slot: 11
	public void Disconnect() { }

	// RVA: 0x6BAE148 Offset: 0x6BAA148 VA: 0x6BAE148 Slot: 12
	public void Dispose() { }

	// RVA: 0x6BAE8A0 Offset: 0x6BAA8A0 VA: 0x6BAE8A0 Slot: 5
	public void SendMessage(IPEndPoint remoteIPEndPoint, IMessage message, EChannelType channelType) { }

	// RVA: 0x6BAE990 Offset: 0x6BAA990 VA: 0x6BAE990 Slot: 4
	public void SendMessage(IPEndPoint remoteIPEndPoint, ushort msgId, byte[] msg, EChannelType channelType) { }

	// RVA: 0x6BAEA88 Offset: 0x6BAAA88 VA: 0x6BAEA88
	private void HandleUserSendMessageEvent(IEvent evt) { }

	// RVA: 0x6BAEBDC Offset: 0x6BAABDC VA: 0x6BAEBDC Slot: 6
	public void Bind(int port) { }

	// RVA: 0x6BADC38 Offset: 0x6BA9C38 VA: 0x6BADC38
	private void RegisterSocketEvents() { }

	// RVA: 0x6BAE624 Offset: 0x6BAA624 VA: 0x6BAE624
	private void UnregisterSocketEvents() { }

	// RVA: 0x6BAEDF0 Offset: 0x6BAADF0 VA: 0x6BAEDF0
	private void HandleReceiveSocketMessage(IEvent evt) { }

	// RVA: 0x6BAD774 Offset: 0x6BA9774 VA: 0x6BAD774
	public void RegisterNetEvent() { }

	// RVA: 0x6BAE160 Offset: 0x6BAA160 VA: 0x6BAE160
	public void UnRegisterNetEvent() { }

	// RVA: 0x6BAF1FC Offset: 0x6BAB1FC VA: 0x6BAF1FC
	private void Update(IEvent evt) { }

	// RVA: 0x6BAF368 Offset: 0x6BAB368 VA: 0x6BAF368
	private void Bind(IEvent evt) { }

	// RVA: 0x6BAF53C Offset: 0x6BAB53C VA: 0x6BAF53C
	private void HandleConnectionReceiveMsg(IEvent evt) { }

	// RVA: 0x6BAF6A8 Offset: 0x6BAB6A8 VA: 0x6BAF6A8
	private void HandleConnectionSendMsg(IEvent evt) { }

	// RVA: 0x6BAF814 Offset: 0x6BAB814 VA: 0x6BAF814
	private void SendTo(IEvent evt) { }

	// RVA: 0x6BAFB0C Offset: 0x6BABB0C VA: 0x6BAFB0C
	private void BatchUdpSendTo(IEvent evt) { }

	// RVA: 0x6BAFD1C Offset: 0x6BABD1C VA: 0x6BAFD1C
	private void ReceiveMessage(IEvent evt) { }

	// RVA: 0x6BAFFC0 Offset: 0x6BABFC0 VA: 0x6BAFFC0
	private void SocketStop(IEvent evt) { }

	// RVA: 0x6BB0180 Offset: 0x6BAC180 VA: 0x6BB0180
	private void Reinitialization(IEvent evt) { }

	// RVA: 0x6BB039C Offset: 0x6BAC39C VA: 0x6BB039C
	private void HandleExternalEvent(IEvent evt) { }

	// RVA: 0x6BB04B8 Offset: 0x6BAC4B8 VA: 0x6BB04B8
	private void RecycleConnection(IEvent evt) { }

	// RVA: 0x6BB0894 Offset: 0x6BAC894 VA: 0x6BB0894
	private void CreateConnection(IEvent evt) { }

	// RVA: 0x6BAF050 Offset: 0x6BAB050 VA: 0x6BAF050
	private void HandleConnectionStatus(IPEndPoint remoteIPEndPoint, ProtocolType protocolType) { }

	// RVA: 0x6BB0990 Offset: 0x6BAC990 VA: 0x6BB0990
	private void ReplaceConnection(IEvent evt) { }
}

// Namespace: FalconNet
internal class ErrorStateClient : INetPeerState // TypeDefIndex: 24384
{
	// Fields
	private long _enterTime; // 0x10
	private ProtocolType _errorProtocolType; // 0x18
	private bool _isSendRecoverEvent; // 0x1C
	private bool _isReceiveErrorEvent; // 0x1D
	private int _socketId; // 0x20

	// Properties
	public NetPeerState CurrentState { get; }

	// Methods

	// RVA: 0x6BB1068 Offset: 0x6BAD068 VA: 0x6BB1068 Slot: 4
	public NetPeerState get_CurrentState() { }

	// RVA: 0x6BB1070 Offset: 0x6BAD070 VA: 0x6BB1070 Slot: 5
	public void Enter(NetStateParameter netPeerState) { }

	// RVA: 0x6BB1294 Offset: 0x6BAD294 VA: 0x6BB1294 Slot: 6
	public void Exit() { }

	// RVA: 0x6BB13F0 Offset: 0x6BAD3F0 VA: 0x6BB13F0 Slot: 7
	public void Update() { }

	// RVA: 0x6BB15A8 Offset: 0x6BAD5A8 VA: 0x6BB15A8 Slot: 8
	public bool IsStateChangeValid(NetPeerState nextPeerState) { }

	// RVA: 0x6BB15D4 Offset: 0x6BAD5D4 VA: 0x6BB15D4 Slot: 9
	public bool IsMessageValid(NetSendParameter parameter) { }

	// RVA: 0x6BB15DC Offset: 0x6BAD5DC VA: 0x6BB15DC
	private void HandleSocketReadyEvent(IEvent _) { }

	// RVA: 0x6BB16A8 Offset: 0x6BAD6A8 VA: 0x6BB16A8
	private void HandleUdpSocketErrorEvent(IEvent eEvent) { }

	// RVA: 0x6BB1C98 Offset: 0x6BADC98 VA: 0x6BB1C98
	private void HandleTcpSocketErrorEvent(IEvent eEvent) { }

	// RVA: 0x6BB1FA0 Offset: 0x6BADFA0 VA: 0x6BB1FA0
	public void .ctor() { }
}

// Namespace: FalconNet
internal class InitializingStateClient : INetPeerState // TypeDefIndex: 24385
{
	// Fields
	private IPEndPoint _remoteEndpoint; // 0x10
	private bool _isForceTcp; // 0x18
	private bool _isUdpSocketReady; // 0x19
	private bool _isUdpDetecting; // 0x1A
	private int _udpDetectCount; // 0x1C
	private long _lastDetectTime; // 0x20

	// Properties
	public NetPeerState CurrentState { get; }

	// Methods

	// RVA: 0x6BB1FA8 Offset: 0x6BADFA8 VA: 0x6BB1FA8 Slot: 4
	public NetPeerState get_CurrentState() { }

	// RVA: 0x6BB1FB0 Offset: 0x6BADFB0 VA: 0x6BB1FB0 Slot: 5
	public void Enter(NetStateParameter netPeerState) { }

	// RVA: 0x6BB2278 Offset: 0x6BAE278 VA: 0x6BB2278 Slot: 6
	public void Exit() { }

	// RVA: 0x6BB2430 Offset: 0x6BAE430 VA: 0x6BB2430 Slot: 7
	public void Update() { }

	// RVA: 0x6BB2758 Offset: 0x6BAE758 VA: 0x6BB2758 Slot: 8
	public bool IsStateChangeValid(NetPeerState nextPeerState) { }

	// RVA: 0x6BB2844 Offset: 0x6BAE844 VA: 0x6BB2844 Slot: 9
	public bool IsMessageValid(NetSendParameter parameter) { }

	// RVA: 0x6BB2864 Offset: 0x6BAE864 VA: 0x6BB2864
	private void HandleUdpSocketReadyEvent(IEvent _) { }

	// RVA: 0x6BB2870 Offset: 0x6BAE870 VA: 0x6BB2870
	private void HandleTcpSocketReadyEvent(IEvent _) { }

	// RVA: 0x6BB29F0 Offset: 0x6BAE9F0 VA: 0x6BB29F0
	private void NetworkUdpDetectSuccess(IEvent _) { }

	// RVA: 0x6BB2B70 Offset: 0x6BAEB70 VA: 0x6BB2B70
	private void HandleUdpSocketErrorEvent(IEvent eEvent) { }

	// RVA: 0x6BB2EA4 Offset: 0x6BAEEA4 VA: 0x6BB2EA4
	private void HandleTcpSocketErrorEvent(IEvent eEvent) { }

	// RVA: 0x6BB31D8 Offset: 0x6BAF1D8 VA: 0x6BB31D8
	public void .ctor() { }
}

// Namespace: FalconNet
internal class NotInitializedStateClient : INetPeerState // TypeDefIndex: 24386
{
	// Properties
	public NetPeerState CurrentState { get; }

	// Methods

	// RVA: 0x6BB31E0 Offset: 0x6BAF1E0 VA: 0x6BB31E0 Slot: 4
	public NetPeerState get_CurrentState() { }

	// RVA: 0x6BB31E8 Offset: 0x6BAF1E8 VA: 0x6BB31E8 Slot: 5
	public void Enter(NetStateParameter netPeerState) { }

	// RVA: 0x6BB31EC Offset: 0x6BAF1EC VA: 0x6BB31EC Slot: 6
	public void Exit() { }

	// RVA: 0x6BB31F0 Offset: 0x6BAF1F0 VA: 0x6BB31F0 Slot: 7
	public void Update() { }

	// RVA: 0x6BB31F4 Offset: 0x6BAF1F4 VA: 0x6BB31F4 Slot: 8
	public bool IsStateChangeValid(NetPeerState nextPeerState) { }

	// RVA: 0x6BB32C0 Offset: 0x6BAF2C0 VA: 0x6BB32C0 Slot: 9
	public bool IsMessageValid(NetSendParameter parameter) { }

	// RVA: 0x6BB32C8 Offset: 0x6BAF2C8 VA: 0x6BB32C8
	public void .ctor() { }
}

// Namespace: FalconNet
internal class RunningStateClient : INetPeerState // TypeDefIndex: 24387
{
	// Fields
	private IPEndPoint _remoteEndpoint; // 0x10

	// Properties
	public NetPeerState CurrentState { get; }

	// Methods

	// RVA: 0x6BB32D0 Offset: 0x6BAF2D0 VA: 0x6BB32D0 Slot: 4
	public NetPeerState get_CurrentState() { }

	// RVA: 0x6BB32D8 Offset: 0x6BAF2D8 VA: 0x6BB32D8 Slot: 5
	public void Enter(NetStateParameter netPeerState) { }

	// RVA: 0x6BB33E4 Offset: 0x6BAF3E4 VA: 0x6BB33E4 Slot: 6
	public void Exit() { }

	// RVA: 0x6BB34CC Offset: 0x6BAF4CC VA: 0x6BB34CC Slot: 7
	public void Update() { }

	// RVA: 0x6BB34D0 Offset: 0x6BAF4D0 VA: 0x6BB34D0 Slot: 8
	public bool IsStateChangeValid(NetPeerState nextPeerState) { }

	// RVA: 0x6BB35A4 Offset: 0x6BAF5A4 VA: 0x6BB35A4 Slot: 9
	public bool IsMessageValid(NetSendParameter parameter) { }

	// RVA: 0x6BB35AC Offset: 0x6BAF5AC VA: 0x6BB35AC
	private void HandleUdpSocketErrorEvent(IEvent eEvent) { }

	// RVA: 0x6BB3828 Offset: 0x6BAF828 VA: 0x6BB3828
	private void HandleTcpSocketErrorEvent(IEvent eEvent) { }

	// RVA: 0x6BB3A94 Offset: 0x6BAFA94 VA: 0x6BB3A94
	public void .ctor() { }
}

// Namespace: FalconNet
internal class StopStateClient : INetPeerState // TypeDefIndex: 24388
{
	// Properties
	public NetPeerState CurrentState { get; }

	// Methods

	// RVA: 0x6BB3A9C Offset: 0x6BAFA9C VA: 0x6BB3A9C Slot: 4
	public NetPeerState get_CurrentState() { }

	// RVA: 0x6BB3AA4 Offset: 0x6BAFAA4 VA: 0x6BB3AA4 Slot: 5
	public void Enter(NetStateParameter netPeerState) { }

	// RVA: 0x6BB3C6C Offset: 0x6BAFC6C VA: 0x6BB3C6C Slot: 6
	public void Exit() { }

	// RVA: 0x6BB3C70 Offset: 0x6BAFC70 VA: 0x6BB3C70 Slot: 7
	public void Update() { }

	// RVA: 0x6BB3C74 Offset: 0x6BAFC74 VA: 0x6BB3C74 Slot: 8
	public bool IsStateChangeValid(NetPeerState nextPeerState) { }

	// RVA: 0x6BB3C84 Offset: 0x6BAFC84 VA: 0x6BB3C84 Slot: 9
	public bool IsMessageValid(NetSendParameter parameter) { }

	// RVA: 0x6BB3C9C Offset: 0x6BAFC9C VA: 0x6BB3C9C
	private bool IsDisconnectMsg(object headerData) { }

	// RVA: 0x6BB3D78 Offset: 0x6BAFD78 VA: 0x6BB3D78
	public void .ctor() { }
}

// Namespace: FalconNet
internal interface IPeerFSM // TypeDefIndex: 24389
{
	// Properties
	public abstract NetPeerState CurrentState { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract NetPeerState get_CurrentState();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Update();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsMessageValid(NetSendParameter parameter);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void HandleStateSwitching(IEvent e);
}

// Namespace: FalconNet
internal abstract class BasePeerStateFSM : IPeerFSM // TypeDefIndex: 24390
{
	// Fields
	protected INetPeerState State; // 0x10
	private bool _isRegistered; // 0x18

	// Properties
	public NetPeerState CurrentState { get; }

	// Methods

	// RVA: 0x6BA8C2C Offset: 0x6BA4C2C VA: 0x6BA8C2C Slot: 4
	public NetPeerState get_CurrentState() { }

	// RVA: 0x6BB3D80 Offset: 0x6BAFD80 VA: 0x6BB3D80 Slot: 8
	protected virtual void Start() { }

	// RVA: 0x6BB3E2C Offset: 0x6BAFE2C VA: 0x6BB3E2C Slot: 9
	protected virtual void Dispose() { }

	// RVA: 0x6BABF44 Offset: 0x6BA7F44 VA: 0x6BABF44 Slot: 5
	public void Update() { }

	// RVA: 0x6BAB508 Offset: 0x6BA7508 VA: 0x6BAB508 Slot: 6
	public bool IsMessageValid(NetSendParameter parameter) { }

	// RVA: 0x6BB3ED0 Offset: 0x6BAFED0 VA: 0x6BB3ED0 Slot: 10
	public virtual void HandleStateSwitching(IEvent e) { }

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract INetPeerState GetState(NetPeerState state);

	// RVA: 0x6BB4348 Offset: 0x6BB0348 VA: 0x6BB4348
	protected void .ctor() { }
}

// Namespace: FalconNet
internal class ClientPeerStateFSM : BasePeerStateFSM // TypeDefIndex: 24391
{
	// Methods

	// RVA: 0x6BA9A18 Offset: 0x6BA5A18 VA: 0x6BA9A18
	public void .ctor() { }

	// RVA: 0x6BAA20C Offset: 0x6BA620C VA: 0x6BAA20C
	public void Start(IPEndPoint remoteEndpoint, bool isForceTcp) { }

	// RVA: 0x6BB4350 Offset: 0x6BB0350 VA: 0x6BB4350 Slot: 9
	protected override void Dispose() { }

	// RVA: 0x6BB4354 Offset: 0x6BB0354 VA: 0x6BB4354 Slot: 10
	public override void HandleStateSwitching(IEvent e) { }

	// RVA: 0x6BB44EC Offset: 0x6BB04EC VA: 0x6BB44EC Slot: 11
	protected override INetPeerState GetState(NetPeerState state) { }
}

// Namespace: FalconNet
internal class ServerPeerStateFSM : BasePeerStateFSM // TypeDefIndex: 24392
{
	// Methods

	// RVA: 0x6BAE0D8 Offset: 0x6BAA0D8 VA: 0x6BAE0D8
	public void .ctor() { }

	// RVA: 0x6BAED10 Offset: 0x6BAAD10 VA: 0x6BAED10
	public void Start() { }

	// RVA: 0x6BB45A4 Offset: 0x6BB05A4 VA: 0x6BB45A4 Slot: 11
	protected override INetPeerState GetState(NetPeerState state) { }
}

// Namespace: FalconNet
internal interface INetPeerState // TypeDefIndex: 24393
{
	// Properties
	public abstract NetPeerState CurrentState { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract NetPeerState get_CurrentState();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Enter(NetStateParameter netPeerState);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Exit();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Update();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsStateChangeValid(NetPeerState nextPeerState);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool IsMessageValid(NetSendParameter parameter);
}

// Namespace: FalconNet
internal class ErrorStateServer : INetPeerState // TypeDefIndex: 24394
{
	// Fields
	private bool isUdpReady; // 0x10
	private bool isTcpReady; // 0x11

	// Properties
	public NetPeerState CurrentState { get; }

	// Methods

	// RVA: 0x6BB467C Offset: 0x6BB067C VA: 0x6BB467C Slot: 4
	public NetPeerState get_CurrentState() { }

	// RVA: 0x6BB4684 Offset: 0x6BB0684 VA: 0x6BB4684 Slot: 5
	public void Enter(NetStateParameter netPeerState) { }

	// RVA: 0x6BB481C Offset: 0x6BB081C VA: 0x6BB481C Slot: 6
	public void Exit() { }

	// RVA: 0x6BB498C Offset: 0x6BB098C VA: 0x6BB498C Slot: 7
	public void Update() { }

	// RVA: 0x6BB4990 Offset: 0x6BB0990 VA: 0x6BB4990 Slot: 8
	public bool IsStateChangeValid(NetPeerState nextPeerState) { }

	// RVA: 0x6BB49B4 Offset: 0x6BB09B4 VA: 0x6BB49B4 Slot: 9
	public bool IsMessageValid(NetSendParameter parameter) { }

	// RVA: 0x6BB49BC Offset: 0x6BB09BC VA: 0x6BB49BC
	private void HandleUdpSocketReadyEvent(IEvent _) { }

	// RVA: 0x6BB4AAC Offset: 0x6BB0AAC VA: 0x6BB4AAC
	private void HandleTcpSocketReadyEvent(IEvent _) { }

	// RVA: 0x6BB4B9C Offset: 0x6BB0B9C VA: 0x6BB4B9C
	private void HandleUdpSocketErrorEvent(IEvent _) { }

	// RVA: 0x6BB4CA4 Offset: 0x6BB0CA4 VA: 0x6BB4CA4
	private void HandleTcpSocketErrorEvent(IEvent _) { }

	// RVA: 0x6BB4804 Offset: 0x6BB0804 VA: 0x6BB4804
	private void DoSocketReconnect() { }

	// RVA: 0x6BB4BA4 Offset: 0x6BB0BA4 VA: 0x6BB4BA4
	private void DoSocketReconnect(ProtocolType protocolType) { }

	// RVA: 0x6BB466C Offset: 0x6BB066C VA: 0x6BB466C
	public void .ctor() { }
}

// Namespace: FalconNet
internal class InitializingStateServer : INetPeerState // TypeDefIndex: 24395
{
	// Fields
	private bool _isUdpReady; // 0x10
	private bool _isTcpReady; // 0x11

	// Properties
	public NetPeerState CurrentState { get; }

	// Methods

	// RVA: 0x6BB4CAC Offset: 0x6BB0CAC VA: 0x6BB4CAC Slot: 4
	public NetPeerState get_CurrentState() { }

	// RVA: 0x6BB4CB4 Offset: 0x6BB0CB4 VA: 0x6BB4CB4 Slot: 5
	public void Enter(NetStateParameter netPeerState) { }

	// RVA: 0x6BB4E68 Offset: 0x6BB0E68 VA: 0x6BB4E68 Slot: 6
	public void Exit() { }

	// RVA: 0x6BB4F50 Offset: 0x6BB0F50 VA: 0x6BB4F50 Slot: 7
	public void Update() { }

	// RVA: 0x6BB5034 Offset: 0x6BB1034 VA: 0x6BB5034 Slot: 8
	public bool IsStateChangeValid(NetPeerState nextPeerState) { }

	// RVA: 0x6BB5100 Offset: 0x6BB1100 VA: 0x6BB5100 Slot: 9
	public bool IsMessageValid(NetSendParameter parameter) { }

	// RVA: 0x6BB5108 Offset: 0x6BB1108 VA: 0x6BB5108
	private void HandleUdpSocketReadyEvent(IEvent _) { }

	// RVA: 0x6BB5114 Offset: 0x6BB1114 VA: 0x6BB5114
	private void HandleTcpSocketReadyEvent(IEvent _) { }

	// RVA: 0x6BB4654 Offset: 0x6BB0654 VA: 0x6BB4654
	public void .ctor() { }
}

// Namespace: FalconNet
internal class NotInitializedStateServer : INetPeerState // TypeDefIndex: 24396
{
	// Properties
	public NetPeerState CurrentState { get; }

	// Methods

	// RVA: 0x6BB5120 Offset: 0x6BB1120 VA: 0x6BB5120 Slot: 4
	public NetPeerState get_CurrentState() { }

	// RVA: 0x6BB5128 Offset: 0x6BB1128 VA: 0x6BB5128 Slot: 5
	public void Enter(NetStateParameter netPeerState) { }

	// RVA: 0x6BB512C Offset: 0x6BB112C VA: 0x6BB512C Slot: 6
	public void Exit() { }

	// RVA: 0x6BB5130 Offset: 0x6BB1130 VA: 0x6BB5130 Slot: 7
	public void Update() { }

	// RVA: 0x6BB5134 Offset: 0x6BB1134 VA: 0x6BB5134 Slot: 8
	public bool IsStateChangeValid(NetPeerState nextPeerState) { }

	// RVA: 0x6BB5200 Offset: 0x6BB1200 VA: 0x6BB5200 Slot: 9
	public bool IsMessageValid(NetSendParameter parameter) { }

	// RVA: 0x6BB459C Offset: 0x6BB059C VA: 0x6BB459C
	public void .ctor() { }
}

// Namespace: FalconNet
internal class RunHalfStateServer : INetPeerState // TypeDefIndex: 24397
{
	// Fields
	private ProtocolType _errorProtocolType; // 0x10

	// Properties
	public NetPeerState CurrentState { get; }

	// Methods

	// RVA: 0x6BB5208 Offset: 0x6BB1208 VA: 0x6BB5208 Slot: 4
	public NetPeerState get_CurrentState() { }

	// RVA: 0x6BB5210 Offset: 0x6BB1210 VA: 0x6BB5210 Slot: 5
	public void Enter(NetStateParameter netPeerState) { }

	// RVA: 0x6BB54E8 Offset: 0x6BB14E8 VA: 0x6BB54E8 Slot: 6
	public void Exit() { }

	// RVA: 0x6BB5658 Offset: 0x6BB1658 VA: 0x6BB5658 Slot: 7
	public void Update() { }

	// RVA: 0x6BB565C Offset: 0x6BB165C VA: 0x6BB565C Slot: 8
	public bool IsStateChangeValid(NetPeerState nextPeerState) { }

	// RVA: 0x6BB5680 Offset: 0x6BB1680 VA: 0x6BB5680 Slot: 9
	public bool IsMessageValid(NetSendParameter parameter) { }

	// RVA: 0x6BB53E4 Offset: 0x6BB13E4 VA: 0x6BB53E4
	private void DoSocketReconnect() { }

	// RVA: 0x6BB56A4 Offset: 0x6BB16A4 VA: 0x6BB56A4
	private void HandleUdpSocketReadyEvent(IEvent _) { }

	// RVA: 0x6BB5790 Offset: 0x6BB1790 VA: 0x6BB5790
	private void HandleTcpSocketReadyEvent(IEvent _) { }

	// RVA: 0x6BB587C Offset: 0x6BB187C VA: 0x6BB587C
	private void HandleUdpSocketErrorEvent(IEvent _) { }

	// RVA: 0x6BB596C Offset: 0x6BB196C VA: 0x6BB596C
	private void HandleTcpSocketErrorEvent(IEvent _) { }

	// RVA: 0x6BB4664 Offset: 0x6BB0664 VA: 0x6BB4664
	public void .ctor() { }
}

// Namespace: FalconNet
internal class RunningStateServer : INetPeerState // TypeDefIndex: 24398
{
	// Properties
	public NetPeerState CurrentState { get; }

	// Methods

	// RVA: 0x6BB5A5C Offset: 0x6BB1A5C VA: 0x6BB5A5C Slot: 4
	public NetPeerState get_CurrentState() { }

	// RVA: 0x6BB5A64 Offset: 0x6BB1A64 VA: 0x6BB5A64 Slot: 5
	public void Enter(NetStateParameter netPeerState) { }

	// RVA: 0x6BB5B4C Offset: 0x6BB1B4C VA: 0x6BB5B4C Slot: 6
	public void Exit() { }

	// RVA: 0x6BB5C34 Offset: 0x6BB1C34 VA: 0x6BB5C34 Slot: 7
	public void Update() { }

	// RVA: 0x6BB5C38 Offset: 0x6BB1C38 VA: 0x6BB5C38 Slot: 8
	public bool IsStateChangeValid(NetPeerState nextPeerState) { }

	// RVA: 0x6BB5C4C Offset: 0x6BB1C4C VA: 0x6BB5C4C Slot: 9
	public bool IsMessageValid(NetSendParameter parameter) { }

	// RVA: 0x6BB5C54 Offset: 0x6BB1C54 VA: 0x6BB5C54
	private void HandleUdpSocketErrorEvent(IEvent _) { }

	// RVA: 0x6BB5D24 Offset: 0x6BB1D24 VA: 0x6BB5D24
	private void HandleTcpSocketErrorEvent(IEvent _) { }

	// RVA: 0x6BB465C Offset: 0x6BB065C VA: 0x6BB465C
	public void .ctor() { }
}

// Namespace: FalconNet
internal class StopStateServer : INetPeerState // TypeDefIndex: 24399
{
	// Properties
	public NetPeerState CurrentState { get; }

	// Methods

	// RVA: 0x6BB5DF4 Offset: 0x6BB1DF4 VA: 0x6BB5DF4 Slot: 4
	public NetPeerState get_CurrentState() { }

	// RVA: 0x6BB5DFC Offset: 0x6BB1DFC VA: 0x6BB5DFC Slot: 5
	public void Enter(NetStateParameter netPeerState) { }

	// RVA: 0x6BB5E00 Offset: 0x6BB1E00 VA: 0x6BB5E00 Slot: 6
	public void Exit() { }

	// RVA: 0x6BB5E04 Offset: 0x6BB1E04 VA: 0x6BB5E04 Slot: 7
	public void Update() { }

	// RVA: 0x6BB5E08 Offset: 0x6BB1E08 VA: 0x6BB5E08 Slot: 8
	public bool IsStateChangeValid(NetPeerState nextPeerState) { }

	// RVA: 0x6BB5E18 Offset: 0x6BB1E18 VA: 0x6BB5E18 Slot: 9
	public bool IsMessageValid(NetSendParameter parameter) { }

	// RVA: 0x6BB4674 Offset: 0x6BB0674 VA: 0x6BB4674
	public void .ctor() { }
}

// Namespace: FalconNet
internal class CustomMessageParser : IMessageParser // TypeDefIndex: 24400
{
	// Fields
	private readonly Func<byte[], IMessage> _customParser; // 0x10

	// Methods

	// RVA: 0x6BB5E20 Offset: 0x6BB1E20 VA: 0x6BB5E20
	internal void .ctor(Func<byte[], IMessage> customParser) { }

	// RVA: 0x6BB5E50 Offset: 0x6BB1E50 VA: 0x6BB5E50 Slot: 5
	public IMessage Parse(byte[] data) { }

	// RVA: 0x6BB5E74 Offset: 0x6BB1E74 VA: 0x6BB5E74 Slot: 4
	public IMessage Parse(ByteArray data) { }
}

// Namespace: FalconNet
public interface IMessageParser // TypeDefIndex: 24401
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessage Parse(ByteArray data);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IMessage Parse(byte[] data);
}

// Namespace: FalconNet
internal interface IProtoParse // TypeDefIndex: 24402
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ushort GetParserMsgId(Type type);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IMessage Parse(ushort protoDef, byte[] data);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IMessage Parse(ushort protoDef, ByteArray data);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void AddParse(ushort protoDef, IMessageParser parser);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void AddParseExternal<T>(ushort protoDef, T msg);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IProtoParse.AddParseExternal<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ProtoParse.<>c // TypeDefIndex: 24403
{
	// Fields
	public static readonly ProtoParse.<>c <>9; // 0x0
	public static Func<IMessage> <>9__3_0; // 0x8
	public static Func<IMessage> <>9__3_1; // 0x10
	public static Func<byte[], IMessage> <>9__3_2; // 0x18
	public static Func<byte[], IMessage> <>9__3_3; // 0x20

	// Methods

	// RVA: 0x6BB6210 Offset: 0x6BB2210 VA: 0x6BB6210
	private static void .cctor() { }

	// RVA: 0x6BB6278 Offset: 0x6BB2278 VA: 0x6BB6278
	public void .ctor() { }

	// RVA: 0x6BB6280 Offset: 0x6BB2280 VA: 0x6BB6280
	internal IMessage <.ctor>b__3_0() { }

	// RVA: 0x6BB62D4 Offset: 0x6BB22D4 VA: 0x6BB62D4
	internal IMessage <.ctor>b__3_1() { }

	// RVA: 0x6BB6324 Offset: 0x6BB2324 VA: 0x6BB6324
	internal IMessage <.ctor>b__3_2(byte[] data) { }

	// RVA: 0x6BB6458 Offset: 0x6BB2458 VA: 0x6BB6458
	internal IMessage <.ctor>b__3_3(byte[] data) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ProtoParse.<>c__6<T> // TypeDefIndex: 24404
{
	// Fields
	public static readonly ProtoParse.<>c__6<T> <>9; // 0x0
	public static Func<IMessage> <>9__6_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485B8FC Offset: 0x48578FC VA: 0x485B8FC
	|-ProtoParse.<>c__6<object>..cctor
	|
	|-RVA: 0x485BB90 Offset: 0x4857B90 VA: 0x485BB90
	|-ProtoParse.<>c__6<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485B9B8 Offset: 0x48579B8 VA: 0x485B9B8
	|-ProtoParse.<>c__6<object>..ctor
	|
	|-RVA: 0x485BC84 Offset: 0x4857C84 VA: 0x485BC84
	|-ProtoParse.<>c__6<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IMessage <AddParseExternal>b__6_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x485B9C0 Offset: 0x48579C0 VA: 0x485B9C0
	|-ProtoParse.<>c__6<object>.<AddParseExternal>b__6_0
	|
	|-RVA: 0x485BC8C Offset: 0x4857C8C VA: 0x485BC8C
	|-ProtoParse.<>c__6<__Il2CppFullySharedGenericType>.<AddParseExternal>b__6_0
	*/
}

// Namespace: FalconNet
internal class ProtoParse : IProtoParse // TypeDefIndex: 24405
{
	// Fields
	internal const int MaxInnerProtoDef = 99;
	private readonly Dictionary<ushort, IMessageParser> _parserDict; // 0x10
	private readonly Dictionary<Type, ushort> _parserMsgId; // 0x18

	// Methods

	// RVA: 0x6BA8ED8 Offset: 0x6BA4ED8 VA: 0x6BA8ED8
	internal void .ctor(bool isInner) { }

	// RVA: 0x6BB5FB4 Offset: 0x6BB1FB4 VA: 0x6BB5FB4 Slot: 4
	public ushort GetParserMsgId(Type type) { }

	// RVA: 0x6BB5F4C Offset: 0x6BB1F4C VA: 0x6BB5F4C Slot: 7
	public void AddParse(ushort protoDef, IMessageParser parser) { }

	// RVA: -1 Offset: -1 Slot: 8
	public void AddParseExternal<T>(ushort protoDef, T msg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x46ABC70 Offset: 0x46A7C70 VA: 0x46ABC70
	|-ProtoParse.AddParseExternal<object>
	|
	|-RVA: 0x46ABEB4 Offset: 0x46A7EB4 VA: 0x46ABEB4
	|-ProtoParse.AddParseExternal<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x6BB6024 Offset: 0x6BB2024 VA: 0x6BB6024 Slot: 5
	public IMessage Parse(ushort protoDef, byte[] data) { }

	// RVA: 0x6BB611C Offset: 0x6BB211C VA: 0x6BB611C Slot: 6
	public IMessage Parse(ushort protoDef, ByteArray data) { }

	// RVA: 0x6BA8624 Offset: 0x6BA4624 VA: 0x6BA8624
	public static bool IsInternalProto(ushort protoDef) { }
}

// Namespace: FalconNet
internal enum ProtoDef // TypeDefIndex: 24406
{
	// Fields
	public ushort value__; // 0x0
	public const ProtoDef C2SConnect = 1;
	public const ProtoDef S2CConnect = 2;
	public const ProtoDef Disconnect = 3;
	public const ProtoDef ReliableAck = 11;
	public const ProtoDef ReachableTest = 12;
	public const ProtoDef Ping = 13;
	public const ProtoDef Pong = 14;
}

// Namespace: FalconNet
internal class StandardMessageParser : IMessageParser // TypeDefIndex: 24407
{
	// Fields
	private readonly Func<IMessage> _messageFactory; // 0x10

	// Methods

	// RVA: 0x6BB5F1C Offset: 0x6BB1F1C VA: 0x6BB5F1C
	internal void .ctor(Func<IMessage> messageFactory) { }

	// RVA: 0x6BB661C Offset: 0x6BB261C VA: 0x6BB661C Slot: 5
	public IMessage Parse(byte[] data) { }

	// RVA: 0x6BB6664 Offset: 0x6BB2664 VA: 0x6BB6664 Slot: 4
	public IMessage Parse(ByteArray data) { }
}

// Namespace: 
private struct DelayedCallbackManager.<>c__DisplayClass1_0.<<AddCallback>b__0>d : IAsyncStateMachine // TypeDefIndex: 24408
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public DelayedCallbackManager.<>c__DisplayClass1_0 <>4__this; // 0x20
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x6BB6DA4 Offset: 0x6BB2DA4 VA: 0x6BB6DA4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x6BB71F8 Offset: 0x6BB31F8 VA: 0x6BB71F8 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DelayedCallbackManager.<>c__DisplayClass1_0 // TypeDefIndex: 24409
{
	// Fields
	public TimeSpan delay; // 0x10
	public CancellationTokenSource cts; // 0x18
	public Action<Guid> callback; // 0x20
	public Guid id; // 0x28
	public DelayedCallbackManager <>4__this; // 0x38

	// Methods

	// RVA: 0x6BB6850 Offset: 0x6BB2850 VA: 0x6BB6850
	public void .ctor() { }

	[AsyncStateMachine(typeof(DelayedCallbackManager.<>c__DisplayClass1_0.<<AddCallback>b__0>d))]
	// RVA: 0x6BB6CC0 Offset: 0x6BB2CC0 VA: 0x6BB6CC0
	internal Task <AddCallback>b__0() { }
}

// Namespace: FalconNet
internal class DelayedCallbackManager // TypeDefIndex: 24410
{
	// Fields
	private readonly ConcurrentDictionary<Guid, CancellationTokenSource> _callbackTasks; // 0x10

	// Methods

	// RVA: 0x6BB66BC Offset: 0x6BB26BC VA: 0x6BB66BC
	internal Guid AddCallback(TimeSpan delay, Action<Guid> callback) { }

	// RVA: 0x6BB6858 Offset: 0x6BB2858 VA: 0x6BB6858
	internal void CancelCallback(Guid id) { }

	// RVA: 0x6BB6974 Offset: 0x6BB2974 VA: 0x6BB6974
	internal void CancelAllCallbacks() { }

	// RVA: 0x6BB6C38 Offset: 0x6BB2C38 VA: 0x6BB6C38
	public void .ctor() { }
}

// Namespace: FalconNet
internal interface IRecyclable // TypeDefIndex: 24411
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Recycle();
}

// Namespace: FalconNet
internal sealed class ConcurrentObjectPool<T> // TypeDefIndex: 24412
{
	// Fields
	private readonly ConcurrentBag<T> pool; // 0x0
	private readonly ConcurrentDictionary<T, bool> inuse; // 0x0
	private readonly Func<T> objectFactory; // 0x0
	private readonly int maxCount; // 0x0
	private int _totalCount; // 0x0

	// Properties
	public int NumberInUse { get; }
	public int NumberInPool { get; }
	public int CurrentCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_NumberInUse() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CD9240 Offset: 0x5CD5240 VA: 0x5CD9240
	|-ConcurrentObjectPool<object>.get_NumberInUse
	|
	|-RVA: 0x5CD96A4 Offset: 0x5CD56A4 VA: 0x5CD96A4
	|-ConcurrentObjectPool<__Il2CppFullySharedGenericType>.get_NumberInUse
	*/

	// RVA: -1 Offset: -1
	public int get_NumberInPool() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CD9264 Offset: 0x5CD5264 VA: 0x5CD9264
	|-ConcurrentObjectPool<object>.get_NumberInPool
	|
	|-RVA: 0x5CD96CC Offset: 0x5CD56CC VA: 0x5CD96CC
	|-ConcurrentObjectPool<__Il2CppFullySharedGenericType>.get_NumberInPool
	*/

	// RVA: -1 Offset: -1
	public int get_CurrentCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CD9288 Offset: 0x5CD5288 VA: 0x5CD9288
	|-ConcurrentObjectPool<object>.get_CurrentCount
	|
	|-RVA: 0x5CD96F4 Offset: 0x5CD56F4 VA: 0x5CD96F4
	|-ConcurrentObjectPool<__Il2CppFullySharedGenericType>.get_CurrentCount
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int maxCount, Func<T> objectFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CD929C Offset: 0x5CD529C VA: 0x5CD929C
	|-ConcurrentObjectPool<object>..ctor
	|
	|-RVA: 0x5CD9708 Offset: 0x5CD5708 VA: 0x5CD9708
	|-ConcurrentObjectPool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T GetObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CD9370 Offset: 0x5CD5370 VA: 0x5CD9370
	|-ConcurrentObjectPool<object>.GetObject
	|
	|-RVA: 0x5CD97E4 Offset: 0x5CD57E4 VA: 0x5CD97E4
	|-ConcurrentObjectPool<__Il2CppFullySharedGenericType>.GetObject
	*/

	// RVA: -1 Offset: -1
	public void RecycleObject(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CD95B0 Offset: 0x5CD55B0 VA: 0x5CD95B0
	|-ConcurrentObjectPool<object>.RecycleObject
	|
	|-RVA: 0x5CD9B20 Offset: 0x5CD5B20 VA: 0x5CD9B20
	|-ConcurrentObjectPool<__Il2CppFullySharedGenericType>.RecycleObject
	*/
}

// Namespace: FalconNet
internal sealed class ObjectPool<T> // TypeDefIndex: 24413
{
	// Fields
	private readonly List<T> pool; // 0x0
	private readonly Dictionary<T, bool> inuse; // 0x0
	private readonly Func<T> objectFactory; // 0x0
	private readonly int maxCount; // 0x0

	// Properties
	public int NumberInUse { get; }
	public int NumberInPool { get; }
	public int CurrentCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_NumberInUse() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FDEAC Offset: 0x51F9EAC VA: 0x51FDEAC
	|-ObjectPool<object>.get_NumberInUse
	|
	|-RVA: 0x51FE3E8 Offset: 0x51FA3E8 VA: 0x51FE3E8
	|-ObjectPool<__Il2CppFullySharedGenericType>.get_NumberInUse
	*/

	// RVA: -1 Offset: -1
	public int get_NumberInPool() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FDED0 Offset: 0x51F9ED0 VA: 0x51FDED0
	|-ObjectPool<object>.get_NumberInPool
	|
	|-RVA: 0x51FE410 Offset: 0x51FA410 VA: 0x51FE410
	|-ObjectPool<__Il2CppFullySharedGenericType>.get_NumberInPool
	*/

	// RVA: -1 Offset: -1
	public int get_CurrentCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FDEEC Offset: 0x51F9EEC VA: 0x51FDEEC
	|-ObjectPool<object>.get_CurrentCount
	|
	|-RVA: 0x51FE438 Offset: 0x51FA438 VA: 0x51FE438
	|-ObjectPool<__Il2CppFullySharedGenericType>.get_CurrentCount
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int maxCount, Func<T> objectFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FDF20 Offset: 0x51F9F20 VA: 0x51FDF20
	|-ObjectPool<object>..ctor
	|
	|-RVA: 0x51FE488 Offset: 0x51FA488 VA: 0x51FE488
	|-ObjectPool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T GetObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FDFF4 Offset: 0x51F9FF4 VA: 0x51FDFF4
	|-ObjectPool<object>.GetObject
	|
	|-RVA: 0x51FE564 Offset: 0x51FA564 VA: 0x51FE564
	|-ObjectPool<__Il2CppFullySharedGenericType>.GetObject
	*/

	// RVA: -1 Offset: -1
	public void RecycleObject(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51FE298 Offset: 0x51FA298 VA: 0x51FE298
	|-ObjectPool<object>.RecycleObject
	|
	|-RVA: 0x51FE9D4 Offset: 0x51FA9D4 VA: 0x51FE9D4
	|-ObjectPool<__Il2CppFullySharedGenericType>.RecycleObject
	*/
}

// Namespace: FalconNet
public class TimestampTextWriter : TextWriter // TypeDefIndex: 24414
{
	// Fields
	private readonly TextWriter originalOut; // 0x30

	// Properties
	public override Encoding Encoding { get; }

	// Methods

	// RVA: 0x6BB7260 Offset: 0x6BB3260 VA: 0x6BB7260
	public void .ctor(TextWriter original) { }

	// RVA: 0x6BB72D4 Offset: 0x6BB32D4 VA: 0x6BB72D4 Slot: 12
	public override Encoding get_Encoding() { }

	// RVA: 0x6BB72F4 Offset: 0x6BB32F4 VA: 0x6BB72F4 Slot: 46
	public override void WriteLine(string value) { }

	// RVA: 0x6BB73BC Offset: 0x6BB33BC VA: 0x6BB73BC Slot: 33
	public override void WriteLine() { }
}

// Namespace: FalconNet
internal static class TimeUtil // TypeDefIndex: 24415
{
	// Fields
	private static long epochTicks; // 0x0

	// Methods

	// RVA: 0x6BB73E0 Offset: 0x6BB33E0 VA: 0x6BB73E0
	internal static long GetUtcTicks() { }

	// RVA: 0x6BB7488 Offset: 0x6BB3488 VA: 0x6BB7488
	internal static long GetUtcMicroMilliseconds() { }

	// RVA: 0x6BB74EC Offset: 0x6BB34EC VA: 0x6BB74EC
	private static void .cctor() { }
}

// Namespace: FalconNet.Utils
public class IPEndPointComparer : IEqualityComparer<IPEndPoint> // TypeDefIndex: 24416
{
	// Fields
	public static readonly IPEndPointComparer Instance; // 0x0

	// Methods

	// RVA: 0x6BB75A0 Offset: 0x6BB35A0 VA: 0x6BB75A0 Slot: 4
	public bool Equals(IPEndPoint x, IPEndPoint y) { }

	// RVA: 0x6BB7610 Offset: 0x6BB3610 VA: 0x6BB7610 Slot: 5
	public int GetHashCode(IPEndPoint obj) { }

	// RVA: 0x6BB7678 Offset: 0x6BB3678 VA: 0x6BB7678
	public void .ctor() { }

	// RVA: 0x6BB7680 Offset: 0x6BB3680 VA: 0x6BB7680
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct PingUtil.<GetIcmpPingAsync>d__0 : IAsyncStateMachine // TypeDefIndex: 24417
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<long> <>t__builder; // 0x8
	public IPAddress address; // 0x20
	public int count; // 0x28
	private int <realCount>5__2; // 0x2C
	private long <totalValue>5__3; // 0x30
	private int <i>5__4; // 0x38
	private Ping <ping>5__5; // 0x40
	private Task <timeoutTask>5__6; // 0x48
	private Task<PingReply> <pingTask>5__7; // 0x50
	private TaskAwaiter<Task> <>u__1; // 0x58

	// Methods

	// RVA: 0x6BB7A5C Offset: 0x6BB3A5C VA: 0x6BB7A5C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x6BB8110 Offset: 0x6BB4110 VA: 0x6BB8110 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct PingUtil.<GetTcpPingAsync>d__1 : IAsyncStateMachine // TypeDefIndex: 24418
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<long> <>t__builder; // 0x8
	public IPAddress address; // 0x20
	public int port; // 0x28
	public int count; // 0x2C
	private int <realCount>5__2; // 0x30
	private long <totalValue>5__3; // 0x38
	private Stopwatch <sw>5__4; // 0x40
	private TcpClient <client>5__5; // 0x48
	private Task <timeoutTask>5__6; // 0x50
	private byte[] <pingData>5__7; // 0x58
	private byte[] <buffer>5__8; // 0x60
	private TaskAwaiter<Task> <>u__1; // 0x68
	private NetworkStream <stream>5__9; // 0x70
	private int <i>5__10; // 0x78
	private Task<int> <readTask>5__11; // 0x80
	private TaskAwaiter <>u__2; // 0x88

	// Methods

	// RVA: 0x6BB818C Offset: 0x6BB418C VA: 0x6BB818C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x6BB8F5C Offset: 0x6BB4F5C VA: 0x6BB8F5C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct PingUtil.<GetUdpPingAsync>d__2 : IAsyncStateMachine // TypeDefIndex: 24419
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<long> <>t__builder; // 0x8
	public IPAddress address; // 0x20
	public int port; // 0x28
	public int count; // 0x2C
	private int <realCount>5__2; // 0x30
	private long <totalValue>5__3; // 0x38
	private Stopwatch <sw>5__4; // 0x40
	private UdpClient <client>5__5; // 0x48
	private byte[] <pingData>5__6; // 0x50
	private int <i>5__7; // 0x58
	private Task<UdpReceiveResult> <receiveTask>5__8; // 0x60
	private Task <timeoutTask>5__9; // 0x68
	private TaskAwaiter<int> <>u__1; // 0x70
	private TaskAwaiter<Task> <>u__2; // 0x78

	// Methods

	// RVA: 0x6BB8FD8 Offset: 0x6BB4FD8 VA: 0x6BB8FD8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x6BB99B8 Offset: 0x6BB59B8 VA: 0x6BB99B8 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: FalconNet.Util
public static class PingUtil // TypeDefIndex: 24420
{
	// Methods

	[AsyncStateMachine(typeof(PingUtil.<GetIcmpPingAsync>d__0))]
	// RVA: 0x6BB76E8 Offset: 0x6BB36E8 VA: 0x6BB76E8
	public static Task<long> GetIcmpPingAsync(IPAddress address, int count) { }

	[AsyncStateMachine(typeof(PingUtil.<GetTcpPingAsync>d__1))]
	// RVA: 0x6BB7808 Offset: 0x6BB3808 VA: 0x6BB7808
	public static Task<long> GetTcpPingAsync(IPAddress address, int port, int count) { }

	[AsyncStateMachine(typeof(PingUtil.<GetUdpPingAsync>d__2))]
	// RVA: 0x6BB7934 Offset: 0x6BB3934 VA: 0x6BB7934
	public static Task<long> GetUdpPingAsync(IPAddress address, int port, int count) { }
}

// Namespace: FalconNet.NetStatistic
public enum EStatisticEvent // TypeDefIndex: 24421
{
	// Fields
	public byte value__; // 0x0
	public const EStatisticEvent PacketReceiveInfo = 0;
	public const EStatisticEvent PacketReceiveHandleInfo = 1;
	public const EStatisticEvent PacketSendInfo = 2;
	public const EStatisticEvent PacketCreateInfo = 3;
	public const EStatisticEvent PacketNetDelayInfo = 4;
	public const EStatisticEvent PacketRealRtt = 5;
	public const EStatisticEvent PacketRealSendCont = 6;
	public const EStatisticEvent PacketRealReceiveCont = 7;
	public const EStatisticEvent PacketRealSendBytes = 8;
	public const EStatisticEvent PacketRealReceiveBytes = 9;
	public const EStatisticEvent PacketNetSeqId = 10;
}

// Namespace: FalconNet.NetStatistic.Models
public class PacketInfo // TypeDefIndex: 24422
{
	// Fields
	public ProtocolType ProtoType; // 0x10
	public EChannelType ChannelType; // 0x14
	public int SeqId; // 0x18
	public int MsgId; // 0x1C

	// Methods

	// RVA: 0x6BB9A34 Offset: 0x6BB5A34 VA: 0x6BB9A34
	public void .ctor(ProtocolType protoType, EChannelType channelType, int seqId, int msgId) { }

	// RVA: 0x6BB9A78 Offset: 0x6BB5A78 VA: 0x6BB9A78
	public void .ctor() { }
}

// Namespace: FalconNet.NetStatistic.Models
public class PacketReceiveInfo : PacketInfo // TypeDefIndex: 24423
{
	// Fields
	public long ReceiveTs; // 0x20

	// Methods

	// RVA: 0x6BB9A80 Offset: 0x6BB5A80 VA: 0x6BB9A80
	public void .ctor(ProtocolType protoType, EChannelType channelType, int seqId, int msgId, long receiveTs) { }

	// RVA: 0x6BB9AD4 Offset: 0x6BB5AD4 VA: 0x6BB9AD4
	public void .ctor() { }
}

// Namespace: FalconNet.NetStatistic.Models
public class PacketHandleInfo : PacketInfo // TypeDefIndex: 24424
{
	// Fields
	public long HandleTs; // 0x20

	// Methods

	// RVA: 0x6BABAD4 Offset: 0x6BA7AD4 VA: 0x6BABAD4
	public void .ctor(ProtocolType protoType, EChannelType channelType, int seqId, int msgId, long handleTs) { }

	// RVA: 0x6BB9ADC Offset: 0x6BB5ADC VA: 0x6BB9ADC
	public void .ctor() { }
}

// Namespace: FalconNet.NetStatistic.Models
public class PacketCreateInfo : PacketInfo // TypeDefIndex: 24425
{
	// Fields
	public long CreatedTs; // 0x20

	// Methods

	// RVA: 0x6BB9AE4 Offset: 0x6BB5AE4 VA: 0x6BB9AE4
	public void .ctor(ProtocolType protoType, EChannelType channelType, int seqId, int msgId, long createdTs) { }

	// RVA: 0x6BB9B38 Offset: 0x6BB5B38 VA: 0x6BB9B38
	public void .ctor() { }
}

// Namespace: FalconNet.NetStatistic.Models
public class PacketSendInfo : PacketInfo // TypeDefIndex: 24426
{
	// Fields
	public long SendTs; // 0x20
	public int RetryTimes; // 0x28

	// Methods

	// RVA: 0x6BB9B40 Offset: 0x6BB5B40 VA: 0x6BB9B40
	public void .ctor(ProtocolType protoType, EChannelType channelType, int seqId, int msgId, long sendTs, int retryTimes) { }

	// RVA: 0x6BB9B9C Offset: 0x6BB5B9C VA: 0x6BB9B9C
	public void .ctor() { }
}

// Namespace: FalconNet.NetStatistic.Models
public class NetDelayInfo // TypeDefIndex: 24427
{
	// Fields
	public int Rtt; // 0x10

	// Methods

	// RVA: 0x6BA6F34 Offset: 0x6BA2F34 VA: 0x6BA6F34
	public void .ctor(int rtt) { }

	// RVA: 0x6BB9BA4 Offset: 0x6BB5BA4 VA: 0x6BB9BA4
	public void .ctor() { }
}

// Namespace: FalconNet.NetStatistic.Models
public class NetRealTimeRtt // TypeDefIndex: 24428
{
	// Fields
	public int Rtt; // 0x10

	// Methods

	// RVA: 0x6BA6F5C Offset: 0x6BA2F5C VA: 0x6BA6F5C
	public void .ctor(int rtt) { }

	// RVA: 0x6BB9BAC Offset: 0x6BB5BAC VA: 0x6BB9BAC
	public void .ctor() { }
}

// Namespace: FalconNet.NetStatistic.Models
public class NetRealSendCont // TypeDefIndex: 24429
{
	// Methods

	// RVA: 0x6BB9BB4 Offset: 0x6BB5BB4 VA: 0x6BB9BB4
	public void .ctor() { }
}

// Namespace: FalconNet.NetStatistic.Models
public class NetRealReceiveCont // TypeDefIndex: 24430
{
	// Methods

	// RVA: 0x6BB9BBC Offset: 0x6BB5BBC VA: 0x6BB9BBC
	public void .ctor() { }
}

// Namespace: FalconNet.NetStatistic.Models
public class NetRealReceiveConnectionId // TypeDefIndex: 24431
{
	// Fields
	public int ConnectionSeqId; // 0x10

	// Methods

	// RVA: 0x6BB9BC4 Offset: 0x6BB5BC4 VA: 0x6BB9BC4
	public void .ctor(int connectionSeqId) { }
}

// Namespace: FalconNet.NetStatistic.Models
public class NetRealSendBytes // TypeDefIndex: 24432
{
	// Fields
	public int Length; // 0x10

	// Methods

	// RVA: 0x6BB9BEC Offset: 0x6BB5BEC VA: 0x6BB9BEC
	public void .ctor(int length = 0) { }
}

// Namespace: FalconNet.NetStatistic.Models
public class NetRealReceiveBytes // TypeDefIndex: 24433
{
	// Fields
	public int Length; // 0x10

	// Methods

	// RVA: 0x6BB9C14 Offset: 0x6BB5C14 VA: 0x6BB9C14
	public void .ctor(int length = 0) { }
}

// Namespace: FalconNet.Statistics
public interface IConnectionStatisticsCallback // TypeDefIndex: 24434
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnConnectionRealTimeStats(ConnectionRealTimeStats realTimeStats);
}

// Namespace: FalconNet.Statistics
public interface IConnectionMetricStatisticsCallback // TypeDefIndex: 24435
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnConnectionMetricCallBack(SnapshotMetric metric);
}

// Namespace: FalconNet.Statistics
internal class ClientMetricStatisticManager // TypeDefIndex: 24436
{
	// Fields
	private static bool _isInitialized; // 0x0
	private static long _processingInterval; // 0x8
	public static IConnectionMetricStatisticsCallback ConnectionStatisticsCallback; // 0x10
	public static ConcurrentQueue<SnapshotMetric> Queue; // 0x18
	private static MetricStatisticsConfig _config; // 0x20
	private static MinuteReportWriter _minuteReportWriter; // 0x28
	private static bool _clientConnectionState; // 0xA0
	private static long _lastProcessTick; // 0xA8

	// Methods

	// RVA: 0x6BB9C3C Offset: 0x6BB5C3C VA: 0x6BB9C3C
	internal static void Refresh() { }

	// RVA: 0x6BB9D3C Offset: 0x6BB5D3C VA: 0x6BB9D3C
	private static void OnRefreshEvent(IEvent _) { }

	// RVA: 0x6BB9E9C Offset: 0x6BB5E9C VA: 0x6BB9E9C
	internal static void Initialize(MetricStatisticsConfig config, IConnectionMetricStatisticsCallback connectionMetricStatisticsCallback) { }

	// RVA: 0x6BBA0F0 Offset: 0x6BB60F0 VA: 0x6BBA0F0
	internal static void SetConnectionState(bool state) { }

	// RVA: 0x6BBA020 Offset: 0x6BB6020 VA: 0x6BBA020
	private static void RegisterEvent() { }

	// RVA: 0x6BA6F84 Offset: 0x6BA2F84 VA: 0x6BA6F84
	internal static void WriteRtt(ushort value) { }

	// RVA: 0x6BBA150 Offset: 0x6BB6150 VA: 0x6BBA150
	internal static void WriteEventProcessTime(ushort value) { }

	// RVA: 0x6BAB5B4 Offset: 0x6BA75B4 VA: 0x6BAB5B4
	internal static void AddCount(CountType type, ushort value) { }

	// RVA: 0x6BB1BC8 Offset: 0x6BADBC8 VA: 0x6BB1BC8
	internal static void MarkNetError(NetErrorType type) { }

	// RVA: 0x6BACE70 Offset: 0x6BA8E70 VA: 0x6BACE70
	internal static void MarkPacketReceived(int packetId) { }

	// RVA: 0x6BAADE4 Offset: 0x6BA6DE4 VA: 0x6BAADE4
	internal static void SetProtocolType(ProtocolType protocolType) { }

	// RVA: 0x6BBA220 Offset: 0x6BB6220 VA: 0x6BBA220
	internal static void MarkGc(int gc0_delta, int gc1_delta, int gc2_delta) { }

	// RVA: 0x6BBA30C Offset: 0x6BB630C VA: 0x6BBA30C
	internal static void MarkEvent(uint eventBitMap, uint eventNumber) { }

	// RVA: 0x6BBA3F0 Offset: 0x6BB63F0 VA: 0x6BBA3F0
	internal static void HandleMetricStatistics() { }

	// RVA: 0x6BBA598 Offset: 0x6BB6598 VA: 0x6BBA598
	public void .ctor() { }

	// RVA: 0x6BBA5A0 Offset: 0x6BB65A0 VA: 0x6BBA5A0
	private static void .cctor() { }
}

// Namespace: FalconNet.Statistics
internal static class ClientRealTimeStatisticManager // TypeDefIndex: 24437
{
	// Fields
	private static readonly DoubleBufferedQueue<IMetricDataPoint> _realTimeMetricData; // 0x0
	private static bool _isRealTimeProcessingInProgress; // 0x8
	private static long _lastRealTimeProcessingTime; // 0x10
	private static readonly int _realTimeProcessingInterval; // 0x18
	private static bool _clientConnectionState; // 0x1C
	private static RealTimeStatisticsConfig _config; // 0x20
	private static bool _isInitialized; // 0x28
	private static int SentPacketsCount; // 0x2C
	private static int ReceivedPacketsCount; // 0x30
	private static int SentBytes; // 0x34
	private static int ReceivedBytes; // 0x38
	private static IConnectionStatisticsCallback _connectionStatisticsCallback; // 0x40
	private static ProtocolType _protocolType; // 0x48

	// Methods

	// RVA: 0x6BBA698 Offset: 0x6BB6698 VA: 0x6BBA698
	internal static void Initialize(RealTimeStatisticsConfig config, IConnectionStatisticsCallback connectionStatisticsCallback) { }

	// RVA: 0x6BBA758 Offset: 0x6BB6758 VA: 0x6BBA758
	internal static void SetConnectionState(bool state) { }

	// RVA: 0x6BBA7B8 Offset: 0x6BB67B8 VA: 0x6BBA7B8
	public static void SetProtocolType(ProtocolType protocolType) { }

	// RVA: 0x6BBA814 Offset: 0x6BB6814 VA: 0x6BBA814
	public static void HandleStatisticsRealTime() { }

	// RVA: 0x6BBB23C Offset: 0x6BB723C VA: 0x6BBB23C
	private static void WriteMetricDataPointRealTimeStaticAsync(EStatisticEvent metricName, IMetricDataPoint dataPoint) { }

	// RVA: 0x6BBAB6C Offset: 0x6BB6B6C VA: 0x6BBAB6C
	public static void HandleConnectionRealTimeStatsStaticAsync() { }

	// RVA: -1 Offset: -1
	public static void CreateAndWriteMetricDataRealTimePointStaticAsync<T>(EStatisticEvent metricName, T value, Nullable<long> timestamp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454E47C Offset: 0x454A47C VA: 0x454E47C
	|-ClientRealTimeStatisticManager.CreateAndWriteMetricDataRealTimePointStaticAsync<object>
	|
	|-RVA: 0x454E5D8 Offset: 0x454A5D8 VA: 0x454E5D8
	|-ClientRealTimeStatisticManager.CreateAndWriteMetricDataRealTimePointStaticAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x6BBB388 Offset: 0x6BB7388 VA: 0x6BBB388
	public static void WriteSimpleMetricDataRealTimePointStaticAsync(EStatisticEvent metricName, int value) { }

	// RVA: 0x6BBB4E8 Offset: 0x6BB74E8 VA: 0x6BBB4E8
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class StatisticsManager.<>c__DisplayClass11_0 // TypeDefIndex: 24438
{
	// Fields
	public long currentTime; // 0x10

	// Methods

	// RVA: 0x6BBB998 Offset: 0x6BB7998 VA: 0x6BBB998
	public void .ctor() { }

	// RVA: 0x6BBC2D8 Offset: 0x6BB82D8 VA: 0x6BBC2D8
	internal void <HandleStatisticsRemove>b__0() { }
}

// Namespace: FalconNet.Statistics
public class StatisticsManager : IStatisticsManager // TypeDefIndex: 24439
{
	// Fields
	private static readonly ConcurrentDictionary<IPEndPoint, ConnectionRawStats> _connectionStats; // 0x0
	private static readonly ConcurrentDictionary<IPEndPoint, long> _connectionDelayTime; // 0x8
	private static StatisticsConfig _config; // 0x10
	private static bool _isInitialized; // 0x18
	private static int _delDelyTime; // 0x1C
	private static bool _isRemoveInProgress; // 0x20
	private static readonly int _cleanupInterval; // 0x24
	private static long _lastCleanupTime; // 0x28
	private static IConnectionStatisticsCallback _connectionStatisticsCallback; // 0x30

	// Methods

	// RVA: 0x6BBB5AC Offset: 0x6BB75AC VA: 0x6BBB5AC Slot: 4
	public void InitializeAsync(StatisticsConfig config, IConnectionStatisticsCallback connectionStatisticsCallback) { }

	// RVA: 0x6BBB6CC Offset: 0x6BB76CC VA: 0x6BBB6CC
	private static void RegisterEvent() { }

	// RVA: 0x6BBB7A8 Offset: 0x6BB77A8 VA: 0x6BBB7A8
	private static void HandleStatisticsRemove(IEvent evt) { }

	// RVA: 0x6BBB610 Offset: 0x6BB7610 VA: 0x6BBB610
	internal static void Initialize(StatisticsConfig config, IConnectionStatisticsCallback connectionStatisticsCallback) { }

	// RVA: 0x6BBB9C0 Offset: 0x6BB79C0 VA: 0x6BBB9C0 Slot: 5
	public void RegisterConnectionAsync(IPEndPoint ipEndPoint) { }

	// RVA: 0x6BBBA14 Offset: 0x6BB7A14 VA: 0x6BBBA14
	internal static void SetStatisticsEnabled(bool isEnabled) { }

	// RVA: 0x6BAC4F4 Offset: 0x6BA84F4 VA: 0x6BAC4F4
	internal static void RegisterConnectionStaticAsync(IPEndPoint ipEndPoint) { }

	// RVA: 0x6BBBD3C Offset: 0x6BB7D3C VA: 0x6BBBD3C Slot: 6
	public void UnregisterConnectionAsync(IPEndPoint connectionId) { }

	// RVA: 0x6BABE1C Offset: 0x6BA7E1C VA: 0x6BABE1C
	public static void UnregisterConnectionStaticAsync(IPEndPoint ipEndPoint) { }

	// RVA: 0x6BBBD90 Offset: 0x6BB7D90 VA: 0x6BBBD90 Slot: 7
	public ConnectionRawStats GetConnectionRawStatsAsync(IPEndPoint IpEndPoint) { }

	// RVA: 0x6BBBDE4 Offset: 0x6BB7DE4 VA: 0x6BBBDE4
	public static ConnectionRawStats GetConnectionRawStatsStaticAsync(IPEndPoint ipEndPoint) { }

	// RVA: 0x6BBBAA8 Offset: 0x6BB7AA8 VA: 0x6BBBAA8
	private static void EnsureInitialized() { }

	// RVA: 0x6BBBF38 Offset: 0x6BB7F38 VA: 0x6BBBF38 Slot: 8
	public void WriteMetricDataPointAsync(IPEndPoint connectionId, EStatisticEvent metricName, IMetricDataPoint dataPoint) { }

	// RVA: -1 Offset: -1 Slot: 9
	public void CreateAndWriteMetricDataPointAsync<T>(IPEndPoint ipEndPoint, EStatisticEvent metricName, T value, Nullable<long> timestamp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x47016D8 Offset: 0x46FD6D8 VA: 0x47016D8
	|-StatisticsManager.CreateAndWriteMetricDataPointAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x6BBBFA4 Offset: 0x6BB7FA4 VA: 0x6BBBFA4
	public static void WriteMetricDataPointStaticAsync(IPEndPoint ipEndPoint, EStatisticEvent metricName, IMetricDataPoint dataPoint) { }

	// RVA: -1 Offset: -1
	public static void CreateAndWriteMetricDataPointStaticAsync<T>(IPEndPoint ipEndPoint, EStatisticEvent metricName, T value, Nullable<long> timestamp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x470180C Offset: 0x46FD80C VA: 0x470180C
	|-StatisticsManager.CreateAndWriteMetricDataPointStaticAsync<object>
	|
	|-RVA: 0x4701938 Offset: 0x46FD938 VA: 0x4701938
	|-StatisticsManager.CreateAndWriteMetricDataPointStaticAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x6BBC168 Offset: 0x6BB8168 VA: 0x6BBC168
	public void .ctor() { }

	// RVA: 0x6BBC170 Offset: 0x6BB8170 VA: 0x6BBC170
	private static void .cctor() { }
}

// Namespace: FalconNet.Statistics
public interface IStatisticsManager // TypeDefIndex: 24440
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void InitializeAsync(StatisticsConfig config, IConnectionStatisticsCallback callback);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void RegisterConnectionAsync(IPEndPoint ipEndPoint);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void UnregisterConnectionAsync(IPEndPoint ipEndPoint);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract ConnectionRawStats GetConnectionRawStatsAsync(IPEndPoint ipEndPoint);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void WriteMetricDataPointAsync(IPEndPoint ipEndPoint, EStatisticEvent metricName, IMetricDataPoint dataPoint);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void CreateAndWriteMetricDataPointAsync<T>(IPEndPoint ipEndPoint, EStatisticEvent metricName, T value, Nullable<long> timestamp);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IStatisticsManager.CreateAndWriteMetricDataPointAsync<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: FalconNet.Statistics
public class StatisticsConfig // TypeDefIndex: 24441
{
	// Fields
	private bool _isStatisticsEnabled; // 0x10

	// Properties
	public bool IsStatisticsEnabled { get; set; }

	// Methods

	// RVA: 0x6BBB9A0 Offset: 0x6BB79A0 VA: 0x6BBB9A0
	public bool get_IsStatisticsEnabled() { }

	// RVA: 0x6BBBA84 Offset: 0x6BB7A84 VA: 0x6BBBA84
	public void set_IsStatisticsEnabled(bool value) { }

	// RVA: 0x6BBC77C Offset: 0x6BB877C VA: 0x6BBC77C
	public void .ctor(bool isStatisticsEnabled) { }

	// RVA: 0x6BBB9B8 Offset: 0x6BB79B8 VA: 0x6BBB9B8
	public void .ctor() { }
}

// Namespace: FalconNet.Statistics
public class RealTimeStatisticsConfig // TypeDefIndex: 24442
{
	// Fields
	[CompilerGenerated]
	private bool <IsRealTimeStatisticsEnabled>k__BackingField; // 0x10

	// Properties
	public bool IsRealTimeStatisticsEnabled { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BBC7AC Offset: 0x6BB87AC VA: 0x6BBC7AC
	public bool get_IsRealTimeStatisticsEnabled() { }

	[CompilerGenerated]
	// RVA: 0x6BBC7B4 Offset: 0x6BB87B4 VA: 0x6BBC7B4
	public void set_IsRealTimeStatisticsEnabled(bool value) { }

	// RVA: 0x6BBC7C0 Offset: 0x6BB87C0 VA: 0x6BBC7C0
	public void .ctor(bool isRealTimeStatisticsEnabled) { }

	// RVA: 0x6BBA750 Offset: 0x6BB6750 VA: 0x6BBA750
	public void .ctor() { }
}

// Namespace: FalconNet.Statistics
public class MetricStatisticsConfig // TypeDefIndex: 24443
{
	// Fields
	[CompilerGenerated]
	private bool <IsMetricStatisticsEnabled>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <ProcessingInterval>k__BackingField; // 0x14

	// Properties
	public bool IsMetricStatisticsEnabled { get; set; }
	public int ProcessingInterval { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BBC7EC Offset: 0x6BB87EC VA: 0x6BBC7EC
	public bool get_IsMetricStatisticsEnabled() { }

	[CompilerGenerated]
	// RVA: 0x6BBC7F4 Offset: 0x6BB87F4 VA: 0x6BBC7F4
	public void set_IsMetricStatisticsEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6BBC800 Offset: 0x6BB8800 VA: 0x6BBC800
	public int get_ProcessingInterval() { }

	[CompilerGenerated]
	// RVA: 0x6BBC808 Offset: 0x6BB8808 VA: 0x6BBC808
	public void set_ProcessingInterval(int value) { }

	// RVA: 0x6BBC810 Offset: 0x6BB8810 VA: 0x6BBC810
	public void .ctor(bool isMetricStatisticsEnabled, int processingInterval) { }

	// RVA: 0x6BBA018 Offset: 0x6BB6018 VA: 0x6BBA018
	public void .ctor() { }
}

// Namespace: FalconNet.Statistics
public class ConnectionRawStats // TypeDefIndex: 24444
{
	// Fields
	[CompilerGenerated]
	private string <ConnectionId>k__BackingField; // 0x10
	[CompilerGenerated]
	private long <RegisteredTimestamp>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<long> <UnregisteredTimestamp>k__BackingField; // 0x20
	[CompilerGenerated]
	private Nullable<long> <GetTimestamp>k__BackingField; // 0x30
	[CompilerGenerated]
	private ConcurrentDictionary<EStatisticEvent, ConcurrentBag<IMetricDataPoint>> <MetricDataPoints>k__BackingField; // 0x40

	// Properties
	public string ConnectionId { get; set; }
	public long RegisteredTimestamp { get; set; }
	public Nullable<long> UnregisteredTimestamp { get; set; }
	public Nullable<long> GetTimestamp { get; set; }
	public ConcurrentDictionary<EStatisticEvent, ConcurrentBag<IMetricDataPoint>> MetricDataPoints { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BBC844 Offset: 0x6BB8844 VA: 0x6BBC844
	public string get_ConnectionId() { }

	[CompilerGenerated]
	// RVA: 0x6BBC84C Offset: 0x6BB884C VA: 0x6BBC84C
	public void set_ConnectionId(string value) { }

	[CompilerGenerated]
	// RVA: 0x6BBC854 Offset: 0x6BB8854 VA: 0x6BBC854
	public long get_RegisteredTimestamp() { }

	[CompilerGenerated]
	// RVA: 0x6BBC85C Offset: 0x6BB885C VA: 0x6BBC85C
	public void set_RegisteredTimestamp(long value) { }

	[CompilerGenerated]
	// RVA: 0x6BBC864 Offset: 0x6BB8864 VA: 0x6BBC864
	public Nullable<long> get_UnregisteredTimestamp() { }

	[CompilerGenerated]
	// RVA: 0x6BBC870 Offset: 0x6BB8870 VA: 0x6BBC870
	public void set_UnregisteredTimestamp(Nullable<long> value) { }

	[CompilerGenerated]
	// RVA: 0x6BBC878 Offset: 0x6BB8878 VA: 0x6BBC878
	public Nullable<long> get_GetTimestamp() { }

	[CompilerGenerated]
	// RVA: 0x6BBC884 Offset: 0x6BB8884 VA: 0x6BBC884
	public void set_GetTimestamp(Nullable<long> value) { }

	[CompilerGenerated]
	// RVA: 0x6BBC88C Offset: 0x6BB888C VA: 0x6BBC88C
	public ConcurrentDictionary<EStatisticEvent, ConcurrentBag<IMetricDataPoint>> get_MetricDataPoints() { }

	[CompilerGenerated]
	// RVA: 0x6BBC894 Offset: 0x6BB8894 VA: 0x6BBC894
	public void set_MetricDataPoints(ConcurrentDictionary<EStatisticEvent, ConcurrentBag<IMetricDataPoint>> value) { }

	// RVA: 0x6BBBB4C Offset: 0x6BB7B4C VA: 0x6BBBB4C
	public void .ctor(IPEndPoint connectionId, long registeredTimestamp, Dictionary<string, object> metadata) { }

	// RVA: 0x6BBC89C Offset: 0x6BB889C VA: 0x6BBC89C
	public List<IMetricDataPoint> GetMetricDataPoints(EStatisticEvent metricName) { }

	// RVA: 0x6BBC974 Offset: 0x6BB8974 VA: 0x6BBC974
	public List<EStatisticEvent> GetAllMetricNames() { }

	// RVA: 0x6BBC9E0 Offset: 0x6BB89E0 VA: 0x6BBC9E0
	public long GetConnectionDuration() { }
}

// Namespace: FalconNet.Statistics
public class IMetricDataPoint // TypeDefIndex: 24445
{
	// Fields
	[CompilerGenerated]
	private long <Timestamp>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly object <Value>k__BackingField; // 0x18

	// Properties
	public long Timestamp { get; set; }
	public virtual object Value { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BBCA80 Offset: 0x6BB8A80 VA: 0x6BBCA80
	public long get_Timestamp() { }

	[CompilerGenerated]
	// RVA: 0x6BBCA88 Offset: 0x6BB8A88 VA: 0x6BBCA88
	protected void set_Timestamp(long value) { }

	[CompilerGenerated]
	// RVA: 0x6BBCA90 Offset: 0x6BB8A90 VA: 0x6BBCA90 Slot: 4
	public virtual object get_Value() { }

	// RVA: 0x6BBCA98 Offset: 0x6BB8A98 VA: 0x6BBCA98
	public void .ctor() { }
}

// Namespace: FalconNet.Statistics
public class MetricDataPoint<T> : IMetricDataPoint // TypeDefIndex: 24446
{
	// Fields
	[CompilerGenerated]
	private T <TypedValue>k__BackingField; // 0x0

	// Properties
	public override object Value { get; }
	private T TypedValue { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override object get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F47B8 Offset: 0x50F07B8 VA: 0x50F47B8
	|-MetricDataPoint<object>.get_Value
	|
	|-RVA: 0x50F4810 Offset: 0x50F0810 VA: 0x50F4810
	|-MetricDataPoint<__Il2CppFullySharedGenericType>.get_Value
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private T get_TypedValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F47C0 Offset: 0x50F07C0 VA: 0x50F47C0
	|-MetricDataPoint<object>.get_TypedValue
	|
	|-RVA: 0x50F48B0 Offset: 0x50F08B0 VA: 0x50F48B0
	|-MetricDataPoint<__Il2CppFullySharedGenericType>.get_TypedValue
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_TypedValue(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F47C8 Offset: 0x50F07C8 VA: 0x50F47C8
	|-MetricDataPoint<object>.set_TypedValue
	|
	|-RVA: 0x50F4948 Offset: 0x50F0948 VA: 0x50F4948
	|-MetricDataPoint<__Il2CppFullySharedGenericType>.set_TypedValue
	*/

	// RVA: -1 Offset: -1
	public void .ctor(long timestamp, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F47D0 Offset: 0x50F07D0 VA: 0x50F47D0
	|-MetricDataPoint<object>..ctor
	|
	|-RVA: 0x50F49FC Offset: 0x50F09FC VA: 0x50F49FC
	|-MetricDataPoint<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: FalconNet.Statistics
public class ConnectionRealTimeStats // TypeDefIndex: 24447
{
	// Fields
	[CompilerGenerated]
	private IPEndPoint <ConnectionId>k__BackingField; // 0x10
	[CompilerGenerated]
	private double <Rtt>k__BackingField; // 0x18
	[CompilerGenerated]
	private double <Delay>k__BackingField; // 0x20
	[CompilerGenerated]
	private long <SentPacketsCount>k__BackingField; // 0x28
	[CompilerGenerated]
	private long <ReceivedPacketsCount>k__BackingField; // 0x30
	[CompilerGenerated]
	private float <PacketLossRate>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <PacketLossNum>k__BackingField; // 0x3C
	[CompilerGenerated]
	private long <SentBytes>k__BackingField; // 0x40
	[CompilerGenerated]
	private long <ReceivedBytes>k__BackingField; // 0x48
	[CompilerGenerated]
	private long <Timestamp>k__BackingField; // 0x50

	// Properties
	public IPEndPoint ConnectionId { get; set; }
	public double Rtt { get; set; }
	public double Delay { get; set; }
	public long SentPacketsCount { get; set; }
	public long ReceivedPacketsCount { get; set; }
	public float PacketLossRate { get; set; }
	public int PacketLossNum { get; set; }
	public long SentBytes { get; set; }
	public long ReceivedBytes { get; set; }
	public long Timestamp { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BBCAA0 Offset: 0x6BB8AA0 VA: 0x6BBCAA0
	public IPEndPoint get_ConnectionId() { }

	[CompilerGenerated]
	// RVA: 0x6BBCAA8 Offset: 0x6BB8AA8 VA: 0x6BBCAA8
	public void set_ConnectionId(IPEndPoint value) { }

	[CompilerGenerated]
	// RVA: 0x6BBCAB0 Offset: 0x6BB8AB0 VA: 0x6BBCAB0
	public double get_Rtt() { }

	[CompilerGenerated]
	// RVA: 0x6BBCAB8 Offset: 0x6BB8AB8 VA: 0x6BBCAB8
	public void set_Rtt(double value) { }

	[CompilerGenerated]
	// RVA: 0x6BBCAC0 Offset: 0x6BB8AC0 VA: 0x6BBCAC0
	public double get_Delay() { }

	[CompilerGenerated]
	// RVA: 0x6BBCAC8 Offset: 0x6BB8AC8 VA: 0x6BBCAC8
	public void set_Delay(double value) { }

	[CompilerGenerated]
	// RVA: 0x6BBCAD0 Offset: 0x6BB8AD0 VA: 0x6BBCAD0
	public long get_SentPacketsCount() { }

	[CompilerGenerated]
	// RVA: 0x6BBCAD8 Offset: 0x6BB8AD8 VA: 0x6BBCAD8
	public void set_SentPacketsCount(long value) { }

	[CompilerGenerated]
	// RVA: 0x6BBCAE0 Offset: 0x6BB8AE0 VA: 0x6BBCAE0
	public long get_ReceivedPacketsCount() { }

	[CompilerGenerated]
	// RVA: 0x6BBCAE8 Offset: 0x6BB8AE8 VA: 0x6BBCAE8
	public void set_ReceivedPacketsCount(long value) { }

	[CompilerGenerated]
	// RVA: 0x6BBCAF0 Offset: 0x6BB8AF0 VA: 0x6BBCAF0
	public float get_PacketLossRate() { }

	[CompilerGenerated]
	// RVA: 0x6BBCAF8 Offset: 0x6BB8AF8 VA: 0x6BBCAF8
	public void set_PacketLossRate(float value) { }

	[CompilerGenerated]
	// RVA: 0x6BBCB00 Offset: 0x6BB8B00 VA: 0x6BBCB00
	public int get_PacketLossNum() { }

	[CompilerGenerated]
	// RVA: 0x6BBCB08 Offset: 0x6BB8B08 VA: 0x6BBCB08
	public void set_PacketLossNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x6BBCB10 Offset: 0x6BB8B10 VA: 0x6BBCB10
	public long get_SentBytes() { }

	[CompilerGenerated]
	// RVA: 0x6BBCB18 Offset: 0x6BB8B18 VA: 0x6BBCB18
	public void set_SentBytes(long value) { }

	[CompilerGenerated]
	// RVA: 0x6BBCB20 Offset: 0x6BB8B20 VA: 0x6BBCB20
	public long get_ReceivedBytes() { }

	[CompilerGenerated]
	// RVA: 0x6BBCB28 Offset: 0x6BB8B28 VA: 0x6BBCB28
	public void set_ReceivedBytes(long value) { }

	[CompilerGenerated]
	// RVA: 0x6BBCB30 Offset: 0x6BB8B30 VA: 0x6BBCB30
	public long get_Timestamp() { }

	[CompilerGenerated]
	// RVA: 0x6BBCB38 Offset: 0x6BB8B38 VA: 0x6BBCB38
	public void set_Timestamp(long value) { }

	// RVA: 0x6BBB308 Offset: 0x6BB7308 VA: 0x6BBB308
	public void .ctor() { }

	// RVA: 0x6BBCB40 Offset: 0x6BB8B40 VA: 0x6BBCB40
	public void .ctor(IPEndPoint connectionId) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReceiveByteArrayPool.<>c__DisplayClass2_0 // TypeDefIndex: 24448
{
	// Fields
	public int arrayLength; // 0x10

	// Methods

	// RVA: 0x6BBCC8C Offset: 0x6BB8C8C VA: 0x6BBCC8C
	public void .ctor() { }

	// RVA: 0x6BBCDA8 Offset: 0x6BB8DA8 VA: 0x6BBCDA8
	internal ByteArray <.ctor>b__0() { }
}

// Namespace: FalconNet.NetModelPool
internal class ReceiveByteArrayPool // TypeDefIndex: 24449
{
	// Fields
	public static readonly ReceiveByteArrayPool ByteArray1032; // 0x0
	private readonly ObjectPool<ByteArray> pool; // 0x10

	// Methods

	// RVA: 0x6BBCB6C Offset: 0x6BB8B6C VA: 0x6BBCB6C
	internal void .ctor(int poolCapacity, int arrayLength) { }

	// RVA: 0x6BBCC94 Offset: 0x6BB8C94 VA: 0x6BBCC94
	internal ByteArray Get() { }

	// RVA: 0x6BBCCE4 Offset: 0x6BB8CE4 VA: 0x6BBCCE4
	internal void Return(ByteArray array) { }

	// RVA: 0x6BBCD3C Offset: 0x6BB8D3C VA: 0x6BBCD3C
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EventByteArrayPool.<>c__DisplayClass2_0 // TypeDefIndex: 24450
{
	// Fields
	public int arrayLength; // 0x10

	// Methods

	// RVA: 0x6BBCF94 Offset: 0x6BB8F94 VA: 0x6BBCF94
	public void .ctor() { }

	// RVA: 0x6BBD008 Offset: 0x6BB9008 VA: 0x6BBD008
	internal ByteArray <.ctor>b__0() { }
}

// Namespace: FalconNet.NetModelPool
internal class EventByteArrayPool // TypeDefIndex: 24451
{
	// Fields
	public static readonly EventByteArrayPool ByteArray1032; // 0x0
	private readonly ObjectPool<ByteArray> pool; // 0x10

	// Methods

	// RVA: 0x6BBCE74 Offset: 0x6BB8E74 VA: 0x6BBCE74
	internal void .ctor(int poolCapacity, int arrayLength) { }

	// RVA: 0x6BACF40 Offset: 0x6BA8F40 VA: 0x6BACF40
	internal ByteArray Get() { }

	// RVA: 0x6BA8114 Offset: 0x6BA4114 VA: 0x6BA8114
	internal void Return(ByteArray array) { }

	// RVA: 0x6BBCF9C Offset: 0x6BB8F9C VA: 0x6BBCF9C
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ConcurrentByteArrayPool.<>c__DisplayClass2_0 // TypeDefIndex: 24452
{
	// Fields
	public int arrayLength; // 0x10

	// Methods

	// RVA: 0x6BBD184 Offset: 0x6BB9184 VA: 0x6BBD184
	public void .ctor() { }

	// RVA: 0x6BBD248 Offset: 0x6BB9248 VA: 0x6BBD248
	internal ByteArray <.ctor>b__0() { }
}

// Namespace: FalconNet.NetModelPool
internal class ConcurrentByteArrayPool // TypeDefIndex: 24453
{
	// Fields
	public static readonly ConcurrentByteArrayPool ByteArray1024; // 0x0
	private readonly ConcurrentObjectPool<ByteArray> pool; // 0x10

	// Methods

	// RVA: 0x6BBD064 Offset: 0x6BB9064 VA: 0x6BBD064
	internal void .ctor(int poolCapacity, int arrayLength) { }

	// RVA: 0x6BBD18C Offset: 0x6BB918C VA: 0x6BBD18C
	internal ByteArray Get() { }

	// RVA: 0x6BACE18 Offset: 0x6BA8E18 VA: 0x6BACE18
	internal void Return(ByteArray array) { }

	// RVA: 0x6BBD1DC Offset: 0x6BB91DC VA: 0x6BBD1DC
	private static void .cctor() { }
}

// Namespace: FalconNet.NetModelPool
public class ByteArray : IRecyclable // TypeDefIndex: 24454
{
	// Fields
	internal byte[] Data; // 0x10
	internal int CurLength; // 0x18

	// Methods

	// RVA: 0x6BBCE04 Offset: 0x6BB8E04 VA: 0x6BBCE04
	internal void .ctor(int length) { }

	// RVA: 0x6BBD2A4 Offset: 0x6BB92A4 VA: 0x6BBD2A4 Slot: 4
	public void Recycle() { }

	// RVA: 0x6BBD2AC Offset: 0x6BB92AC VA: 0x6BBD2AC
	internal byte[] GetSpanAsArray() { }

	// RVA: 0x6BB5EA8 Offset: 0x6BB1EA8 VA: 0x6BB5EA8
	internal byte[] GetBytes() { }

	// RVA: 0x6BACF90 Offset: 0x6BA8F90 VA: 0x6BACF90
	internal void CopyTo(byte[] src, int srcOffset, int dstOffset, int count) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ReceiveMsgPool.<>c // TypeDefIndex: 24455
{
	// Fields
	public static readonly ReceiveMsgPool.<>c <>9; // 0x0
	public static Func<ReceiveMsg> <>9__2_0; // 0x8

	// Methods

	// RVA: 0x6BBD4D0 Offset: 0x6BB94D0 VA: 0x6BBD4D0
	private static void .cctor() { }

	// RVA: 0x6BBD538 Offset: 0x6BB9538 VA: 0x6BBD538
	public void .ctor() { }

	// RVA: 0x6BBD540 Offset: 0x6BB9540 VA: 0x6BBD540
	internal ReceiveMsg <.ctor>b__2_0() { }
}

// Namespace: FalconNet.NetModelPool
internal class ReceiveMsgPool // TypeDefIndex: 24456
{
	// Fields
	public static ReceiveMsgPool DefaultPool; // 0x0
	private readonly ObjectPool<ReceiveMsg> pool; // 0x10

	// Methods

	// RVA: 0x6BBD320 Offset: 0x6BB9320 VA: 0x6BBD320
	public void .ctor(int poolCapacity) { }

	// RVA: 0x6BA87A8 Offset: 0x6BA47A8 VA: 0x6BA87A8
	public ReceiveMsg Get() { }

	// RVA: 0x6BABB28 Offset: 0x6BA7B28 VA: 0x6BABB28
	public void Return(ReceiveMsg array) { }

	// RVA: 0x6BBD468 Offset: 0x6BB9468 VA: 0x6BBD468
	private static void .cctor() { }
}

// Namespace: FalconNet.NetManager
public class FalconNetClient : IClientNetManager, INetManager // TypeDefIndex: 24457
{
	// Fields
	private INetEventListener _listener; // 0x10
	private readonly NetPeerClient _netPeerInstance; // 0x18
	private readonly EventProcessor _processor; // 0x20
	internal static int DisconnectTimeout; // 0x0

	// Properties
	internal virtual INetPeerClient NetPeer { get; }
	public ConnectionState ConnState { get; }

	// Methods

	// RVA: 0x6BBD594 Offset: 0x6BB9594 VA: 0x6BBD594 Slot: 15
	internal virtual INetPeerClient get_NetPeer() { }

	// RVA: 0x6BBD59C Offset: 0x6BB959C VA: 0x6BBD59C Slot: 4
	public ConnectionState get_ConnState() { }

	// RVA: 0x6BBD5B4 Offset: 0x6BB95B4 VA: 0x6BBD5B4 Slot: 5
	public void SetNetEventListener(INetEventListener listener) { }

	// RVA: 0x6BBD5BC Offset: 0x6BB95BC VA: 0x6BBD5BC Slot: 6
	public void DebugSetDisconnectTimeout(int timeout) { }

	// RVA: -1 Offset: -1 Slot: 10
	public void AddParseExternal<T>(ushort protoDef, T msg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45FCF70 Offset: 0x45F8F70 VA: 0x45FCF70
	|-FalconNetClient.AddParseExternal<object>
	|
	|-RVA: 0x45FCFC8 Offset: 0x45F8FC8 VA: 0x45FCFC8
	|-FalconNetClient.AddParseExternal<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x6BBD630 Offset: 0x6BB9630 VA: 0x6BBD630 Slot: 7
	public void Connect(string ip, int port, bool isForceTcp = False) { }

	// RVA: 0x6BBD850 Offset: 0x6BB9850 VA: 0x6BBD850 Slot: 8
	public void SendMessage(IMessage payload, EChannelType reliableType) { }

	// RVA: 0x6BBD96C Offset: 0x6BB996C VA: 0x6BBD96C Slot: 11
	public void Disconnect() { }

	// RVA: 0x6BBDA24 Offset: 0x6BB9A24 VA: 0x6BBDA24 Slot: 12
	public void Dispose() { }

	// RVA: 0x6BBDADC Offset: 0x6BB9ADC VA: 0x6BBDADC Slot: 13
	public void Update() { }

	// RVA: 0x6BBE1D0 Offset: 0x6BBA1D0 VA: 0x6BBE1D0 Slot: 14
	public void InitStatistics(StatisticsConfig config) { }

	// RVA: 0x6BBE228 Offset: 0x6BBA228 VA: 0x6BBE228
	public void SetStatisticsEnabled(bool isEnable) { }

	// RVA: 0x6BBE27C Offset: 0x6BBA27C VA: 0x6BBE27C Slot: 9
	public void InitClientRealTimeStatistic(RealTimeStatisticsConfig config, IConnectionStatisticsCallback callback) { }

	// RVA: 0x6BBE2E0 Offset: 0x6BBA2E0 VA: 0x6BBE2E0
	public void InitClientMetricStatistic(MetricStatisticsConfig config, IConnectionMetricStatisticsCallback callback) { }

	// RVA: 0x6BBE344 Offset: 0x6BBA344 VA: 0x6BBE344
	public void RefreshClientMetricStatistic() { }

	// RVA: 0x6BBE390 Offset: 0x6BBA390 VA: 0x6BBE390
	public void .ctor() { }

	// RVA: 0x6BBE43C Offset: 0x6BBA43C VA: 0x6BBE43C
	private static void .cctor() { }
}

// Namespace: FalconNet.NetManager
public class FalconNetServer : IServerNetManager, INetManager // TypeDefIndex: 24458
{
	// Fields
	private IServerNetEventListener _listener; // 0x10
	private readonly INetPeerServer _netPeerInstance; // 0x18
	private readonly EventProcessor _processor; // 0x20

	// Properties
	internal virtual INetPeerServer NetPeer { get; }

	// Methods

	// RVA: 0x6BBE488 Offset: 0x6BBA488 VA: 0x6BBE488 Slot: 13
	internal virtual INetPeerServer get_NetPeer() { }

	// RVA: -1 Offset: -1 Slot: 8
	public void AddParseExternal<T>(ushort protoDef, T msg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x45FD0B4 Offset: 0x45F90B4 VA: 0x45FD0B4
	|-FalconNetServer.AddParseExternal<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x6BBE490 Offset: 0x6BBA490 VA: 0x6BBE490 Slot: 4
	public void SetNetEventListener(IServerNetEventListener listener) { }

	// RVA: 0x6BBE498 Offset: 0x6BBA498 VA: 0x6BBE498 Slot: 5
	public void Bind(int port) { }

	// RVA: 0x6BBE558 Offset: 0x6BBA558 VA: 0x6BBE558 Slot: 6
	public void SendMessage(IPEndPoint endPoint, IMessage payload, EChannelType reliableType) { }

	// RVA: 0x6BBE67C Offset: 0x6BBA67C VA: 0x6BBE67C Slot: 7
	public void RegisterConnectionStaticAsync(IPEndPoint endPoint) { }

	// RVA: 0x6BBE6D0 Offset: 0x6BBA6D0 VA: 0x6BBE6D0 Slot: 9
	public void Disconnect() { }

	// RVA: 0x6BBE788 Offset: 0x6BBA788 VA: 0x6BBE788 Slot: 10
	public void Dispose() { }

	// RVA: 0x6BBE840 Offset: 0x6BBA840 VA: 0x6BBE840 Slot: 11
	public void Update() { }

	// RVA: 0x6BBEE5C Offset: 0x6BBAE5C VA: 0x6BBEE5C Slot: 12
	public void InitStatistics(StatisticsConfig config) { }

	// RVA: 0x6BBEEB4 Offset: 0x6BBAEB4 VA: 0x6BBEEB4
	public void .ctor() { }
}

// Namespace: FalconNet.NetManager
public interface INetEventListener // TypeDefIndex: 24459
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnNetworkReceive(IPEndPoint remoteEndpoint, ushort msgId, IMessage msg);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnConnectionConnected(IPEndPoint remoteEndpoint, ProtocolType protocolType);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnConnectionDisconnected(IPEndPoint remoteEndpoint, ProtocolType protocolType, bool isForceDisconnect);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnNetworkError(ExternalErrorEventParameter parameter);
}

// Namespace: FalconNet.NetManager
public class ExternalErrorEventParameter // TypeDefIndex: 24460
{
	// Fields
	[CompilerGenerated]
	private string <IpEndPoint>k__BackingField; // 0x10
	[CompilerGenerated]
	private NetErrorCode <Extra>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <ExtraContext>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <EventContext>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <FucInfo>k__BackingField; // 0x30

	// Properties
	public string IpEndPoint { get; set; }
	public NetErrorCode Extra { get; set; }
	public string ExtraContext { get; set; }
	public string EventContext { get; set; }
	public string FucInfo { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BBEF60 Offset: 0x6BBAF60 VA: 0x6BBEF60
	public string get_IpEndPoint() { }

	[CompilerGenerated]
	// RVA: 0x6BBEF68 Offset: 0x6BBAF68 VA: 0x6BBEF68
	public void set_IpEndPoint(string value) { }

	[CompilerGenerated]
	// RVA: 0x6BBEF70 Offset: 0x6BBAF70 VA: 0x6BBEF70
	public NetErrorCode get_Extra() { }

	[CompilerGenerated]
	// RVA: 0x6BBEF78 Offset: 0x6BBAF78 VA: 0x6BBEF78
	public void set_Extra(NetErrorCode value) { }

	[CompilerGenerated]
	// RVA: 0x6BBEF80 Offset: 0x6BBAF80 VA: 0x6BBEF80
	public string get_ExtraContext() { }

	[CompilerGenerated]
	// RVA: 0x6BBEF88 Offset: 0x6BBAF88 VA: 0x6BBEF88
	public void set_ExtraContext(string value) { }

	[CompilerGenerated]
	// RVA: 0x6BBEF90 Offset: 0x6BBAF90 VA: 0x6BBEF90
	public string get_EventContext() { }

	[CompilerGenerated]
	// RVA: 0x6BBEF98 Offset: 0x6BBAF98 VA: 0x6BBEF98
	public void set_EventContext(string value) { }

	[CompilerGenerated]
	// RVA: 0x6BBEFA0 Offset: 0x6BBAFA0 VA: 0x6BBEFA0
	public string get_FucInfo() { }

	[CompilerGenerated]
	// RVA: 0x6BBEFA8 Offset: 0x6BBAFA8 VA: 0x6BBEFA8
	public void set_FucInfo(string value) { }

	// RVA: 0x6BBEFB0 Offset: 0x6BBAFB0 VA: 0x6BBEFB0
	public void .ctor(IPEndPoint ipEndPoint, NetErrorCode extra, string extraContext, string eventContext) { }

	// RVA: 0x6BBF034 Offset: 0x6BBB034 VA: 0x6BBF034
	public void .ctor() { }
}

// Namespace: FalconNet.NetManager
public interface IServerNetEventListener : INetEventListener // TypeDefIndex: 24461
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnEventProcessMetrics(long microseconds, int tickCount, long maxTickCount);
}

// Namespace: FalconNet.NetManager
public interface INetManager // TypeDefIndex: 24462
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void AddParseExternal<T>(ushort protoDef, T msg);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-INetManager.AddParseExternal<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Disconnect();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Dispose();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Update();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void InitStatistics(StatisticsConfig config);
}

// Namespace: FalconNet.NetManager
public interface IClientNetManager : INetManager // TypeDefIndex: 24463
{
	// Properties
	public abstract ConnectionState ConnState { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ConnectionState get_ConnState();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetNetEventListener(INetEventListener listener);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void DebugSetDisconnectTimeout(int timeout);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Connect(string ip, int port, bool isForceTcp = False);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SendMessage(IMessage payload, EChannelType reliableType);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void InitClientRealTimeStatistic(RealTimeStatisticsConfig config, IConnectionStatisticsCallback callback);
}

// Namespace: FalconNet.NetManager
public interface IServerNetManager : INetManager // TypeDefIndex: 24464
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetNetEventListener(IServerNetEventListener listener);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Bind(int port);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SendMessage(IPEndPoint endPoint, IMessage payload, EChannelType reliableType);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void RegisterConnectionStaticAsync(IPEndPoint endpoint);
}

// Namespace: FalconNet.NetSocket.Tcp
internal class ClientSession // TypeDefIndex: 24465
{
	// Fields
	private readonly Socket _clientSocket; // 0x10
	private readonly SocketAsyncEventArgsPool _sendPool; // 0x18
	private readonly SocketAsyncEventArgsPool _receivePool; // 0x20
	private readonly TcpMessageProcessor _messageProcessor; // 0x28
	private Action<IPEndPoint> _socketDisconnected; // 0x30
	private Action<object, SocketAsyncEventArgs> _onReceiveCompleted; // 0x38
	private Action<object, SocketAsyncEventArgs> _onSendCompleted; // 0x40

	// Methods

	// RVA: 0x6BBF03C Offset: 0x6BBB03C VA: 0x6BBF03C
	internal void .ctor(Socket socket, SocketAsyncEventArgsPool sendPool, SocketAsyncEventArgsPool receivePool, Action<IPEndPoint> handleSocketDisconnected, Action<object, SocketAsyncEventArgs> onReceiveCompleted, Action<object, SocketAsyncEventArgs> onSendCompleted) { }

	// RVA: 0x6BBF19C Offset: 0x6BBB19C VA: 0x6BBF19C
	public void ProcessReceivedData(SocketAsyncEventArgs e, IPacketHeaderParser<TcpHeaderData> packetHeaderParser, Action<SocketIODataEventArgs<TcpHeaderData>> onDataReceivedCallback) { }

	// RVA: 0x6BC0460 Offset: 0x6BBC460 VA: 0x6BC0460
	public void SendMessage(string message) { }

	// RVA: 0x6BC06EC Offset: 0x6BBC6EC VA: 0x6BC06EC
	public void SendMessage(byte[] messageBytes) { }

	// RVA: 0x6BBF5E8 Offset: 0x6BBB5E8 VA: 0x6BBF5E8
	private void Disconnect(SocketAsyncEventArgs e) { }

	// RVA: 0x6BC09E4 Offset: 0x6BBC9E4 VA: 0x6BC09E4
	public void Close() { }

	// RVA: 0x6BC0A00 Offset: 0x6BBCA00 VA: 0x6BC0A00
	public void Shutdown() { }
}

// Namespace: FalconNet.NetIOProcessor
internal abstract class BaseTcpOperation : ITcpOperation // TypeDefIndex: 24466
{
	// Fields
	protected SocketAsyncEventArgsPool _sendPool; // 0x10
	protected SocketAsyncEventArgsPool _receivePool; // 0x18
	protected IPacketHeaderParser<TcpHeaderData> PacketHeaderParser; // 0x20
	protected IPacketHeaderGenerator<TcpHeaderData, byte[]> PacketHeaderGenerator; // 0x28
	protected Socket _socket; // 0x30
	[CompilerGenerated]
	private Action<SocketIODataEventArgs<TcpHeaderData>> <OnDataReceivedCallback>k__BackingField; // 0x38
	[CompilerGenerated]
	private Action<SocketIOErrorEventArgs> <OnErrorOccurredCallback>k__BackingField; // 0x40

	// Properties
	public Action<SocketIODataEventArgs<TcpHeaderData>> OnDataReceivedCallback { get; set; }
	public Action<SocketIOErrorEventArgs> OnErrorOccurredCallback { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BC0A20 Offset: 0x6BBCA20 VA: 0x6BC0A20 Slot: 4
	public Action<SocketIODataEventArgs<TcpHeaderData>> get_OnDataReceivedCallback() { }

	[CompilerGenerated]
	// RVA: 0x6BC0A28 Offset: 0x6BBCA28 VA: 0x6BC0A28 Slot: 5
	public void set_OnDataReceivedCallback(Action<SocketIODataEventArgs<TcpHeaderData>> value) { }

	[CompilerGenerated]
	// RVA: 0x6BC0A30 Offset: 0x6BBCA30 VA: 0x6BC0A30 Slot: 6
	public Action<SocketIOErrorEventArgs> get_OnErrorOccurredCallback() { }

	[CompilerGenerated]
	// RVA: 0x6BC0A38 Offset: 0x6BBCA38 VA: 0x6BC0A38 Slot: 7
	public void set_OnErrorOccurredCallback(Action<SocketIOErrorEventArgs> value) { }

	// RVA: 0x6BC0A40 Offset: 0x6BBCA40 VA: 0x6BC0A40 Slot: 10
	public void SetHeaderParser(IPacketHeaderParser<TcpHeaderData> packetHeaderParser) { }

	// RVA: 0x6BC0A48 Offset: 0x6BBCA48 VA: 0x6BC0A48 Slot: 11
	public void SetHeaderGenerator(IPacketHeaderGenerator<TcpHeaderData, byte[]> packetHeaderGenerator) { }

	// RVA: 0x6BC0A50 Offset: 0x6BBCA50 VA: 0x6BC0A50
	protected Socket CreateSocket() { }

	// RVA: 0x6BC0AC8 Offset: 0x6BBCAC8 VA: 0x6BC0AC8
	protected void CloseSocket() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void OnReceiveCompleted(object sender, SocketAsyncEventArgs e);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void OnSendCompleted(object sender, SocketAsyncEventArgs e);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void SocketWork();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void Send(byte[] data, TcpHeaderData header, IPEndPoint remoteEndpoint);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void Stop();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void StopRemote(IPEndPoint remoteEndpoint);

	// RVA: 0x6BC0BDC Offset: 0x6BBCBDC VA: 0x6BC0BDC
	protected void .ctor() { }
}

// Namespace: FalconNet.NetIOProcessor
internal interface IMessagePreprocessor // TypeDefIndex: 24467
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IEnumerable<ByteArray> Preprocess(ByteArray rawData);
}

// Namespace: FalconNet.NetIOProcessor
internal interface IPacketHeaderParser<THeader> // TypeDefIndex: 24468
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ValueTuple<THeader, ByteArray> ParseHeader(ByteArray msg);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPacketHeaderParser<__Il2CppFullySharedGenericType>.ParseHeader
	*/
}

// Namespace: FalconNet.NetIOProcessor
internal interface IPacketHeaderGenerator<THeader, TResult> // TypeDefIndex: 24469
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TResult GenerateHeader(THeader header, byte[] payload, NetSendParameter parameter);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPacketHeaderGenerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GenerateHeader
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract TResult BatchGenerate(int connSeqId, List<NetSendParameter> parameter);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPacketHeaderGenerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.BatchGenerate
	*/
}

// Namespace: FalconNet.NetIOProcessor
internal interface ISocketIO<THeader> // TypeDefIndex: 24470
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Bind();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISocketIO<__Il2CppFullySharedGenericType>.Bind
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetBindPort(int port);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISocketIO<__Il2CppFullySharedGenericType>.SetBindPort
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Task Connect(IPEndPoint remoteEndpoint);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISocketIO<__Il2CppFullySharedGenericType>.Connect
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Stop();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISocketIO<__Il2CppFullySharedGenericType>.Stop
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int GetCurrentSocketId();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISocketIO<__Il2CppFullySharedGenericType>.GetCurrentSocketId
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void StopRemote(IPEndPoint remoteEndpoint);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISocketIO<__Il2CppFullySharedGenericType>.StopRemote
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Reinitialization();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISocketIO<__Il2CppFullySharedGenericType>.Reinitialization
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Send(byte[] data, THeader header, NetSendParameter parameter);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISocketIO<__Il2CppFullySharedGenericType>.Send
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 8
	public abstract void add_DataReceived(EventHandler<SocketIODataEventArgs<THeader>> value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISocketIO<__Il2CppFullySharedGenericType>.add_DataReceived
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 9
	public abstract void remove_DataReceived(EventHandler<SocketIODataEventArgs<THeader>> value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISocketIO<__Il2CppFullySharedGenericType>.remove_DataReceived
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 10
	public abstract void add_ErrorOccurred(EventHandler<SocketIOErrorEventArgs> value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISocketIO<__Il2CppFullySharedGenericType>.add_ErrorOccurred
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 11
	public abstract void remove_ErrorOccurred(EventHandler<SocketIOErrorEventArgs> value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISocketIO<__Il2CppFullySharedGenericType>.remove_ErrorOccurred
	*/
}

// Namespace: FalconNet.NetIOProcessor
internal interface IUdpSocketIO<THeader> : ISocketIO<THeader> // TypeDefIndex: 24471
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void BatchSend(NetUdpBatchSendParameter parameter);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IUdpSocketIO<__Il2CppFullySharedGenericType>.BatchSend
	*/
}

// Namespace: FalconNet.NetIOProcessor
internal class SocketIODataEventArgs<THeader> : EventArgs // TypeDefIndex: 24472
{
	// Fields
	[CompilerGenerated]
	private ByteArray <Data>k__BackingField; // 0x0
	[CompilerGenerated]
	private IPEndPoint <RemoteIPEndPoint>k__BackingField; // 0x0
	[CompilerGenerated]
	private THeader <PacketHeader>k__BackingField; // 0x0
	[CompilerGenerated]
	private long <ReceiveTime>k__BackingField; // 0x0
	[CompilerGenerated]
	private int <MsgSeqId>k__BackingField; // 0x0

	// Properties
	public ByteArray Data { get; set; }
	public IPEndPoint RemoteIPEndPoint { get; set; }
	public THeader PacketHeader { get; set; }
	public long ReceiveTime { get; set; }
	public int MsgSeqId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public ByteArray get_Data() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54EAE38 Offset: 0x54E6E38 VA: 0x54EAE38
	|-SocketIODataEventArgs<object>.get_Data
	|
	|-RVA: 0x54EB050 Offset: 0x54E7050 VA: 0x54EB050
	|-SocketIODataEventArgs<__Il2CppFullySharedGenericType>.get_Data
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_Data(ByteArray value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54EAE40 Offset: 0x54E6E40 VA: 0x54EAE40
	|-SocketIODataEventArgs<object>.set_Data
	|
	|-RVA: 0x54EB074 Offset: 0x54E7074 VA: 0x54EB074
	|-SocketIODataEventArgs<__Il2CppFullySharedGenericType>.set_Data
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public IPEndPoint get_RemoteIPEndPoint() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54EAE48 Offset: 0x54E6E48 VA: 0x54EAE48
	|-SocketIODataEventArgs<object>.get_RemoteIPEndPoint
	|
	|-RVA: 0x54EB090 Offset: 0x54E7090 VA: 0x54EB090
	|-SocketIODataEventArgs<__Il2CppFullySharedGenericType>.get_RemoteIPEndPoint
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_RemoteIPEndPoint(IPEndPoint value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54EAE50 Offset: 0x54E6E50 VA: 0x54EAE50
	|-SocketIODataEventArgs<object>.set_RemoteIPEndPoint
	|
	|-RVA: 0x54EB0B8 Offset: 0x54E70B8 VA: 0x54EB0B8
	|-SocketIODataEventArgs<__Il2CppFullySharedGenericType>.set_RemoteIPEndPoint
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public THeader get_PacketHeader() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54EAE58 Offset: 0x54E6E58 VA: 0x54EAE58
	|-SocketIODataEventArgs<object>.get_PacketHeader
	|
	|-RVA: 0x54EB0D8 Offset: 0x54E70D8 VA: 0x54EB0D8
	|-SocketIODataEventArgs<__Il2CppFullySharedGenericType>.get_PacketHeader
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_PacketHeader(THeader value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54EAE60 Offset: 0x54E6E60 VA: 0x54EAE60
	|-SocketIODataEventArgs<object>.set_PacketHeader
	|
	|-RVA: 0x54EB174 Offset: 0x54E7174 VA: 0x54EB174
	|-SocketIODataEventArgs<__Il2CppFullySharedGenericType>.set_PacketHeader
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public long get_ReceiveTime() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54EAE68 Offset: 0x54E6E68 VA: 0x54EAE68
	|-SocketIODataEventArgs<object>.get_ReceiveTime
	|
	|-RVA: 0x54EB22C Offset: 0x54E722C VA: 0x54EB22C
	|-SocketIODataEventArgs<__Il2CppFullySharedGenericType>.get_ReceiveTime
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_ReceiveTime(long value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54EAE70 Offset: 0x54E6E70 VA: 0x54EAE70
	|-SocketIODataEventArgs<object>.set_ReceiveTime
	|
	|-RVA: 0x54EB254 Offset: 0x54E7254 VA: 0x54EB254
	|-SocketIODataEventArgs<__Il2CppFullySharedGenericType>.set_ReceiveTime
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_MsgSeqId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54EAE78 Offset: 0x54E6E78 VA: 0x54EAE78
	|-SocketIODataEventArgs<object>.get_MsgSeqId
	|
	|-RVA: 0x54EB274 Offset: 0x54E7274 VA: 0x54EB274
	|-SocketIODataEventArgs<__Il2CppFullySharedGenericType>.get_MsgSeqId
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_MsgSeqId(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54EAE80 Offset: 0x54E6E80 VA: 0x54EAE80
	|-SocketIODataEventArgs<object>.set_MsgSeqId
	|
	|-RVA: 0x54EB29C Offset: 0x54E729C VA: 0x54EB29C
	|-SocketIODataEventArgs<__Il2CppFullySharedGenericType>.set_MsgSeqId
	*/

	// RVA: -1 Offset: -1
	public void .ctor(ByteArray data, IPEndPoint remoteEndPoint, THeader packetHeader, long receiveTime, int msgSeqId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54EAE88 Offset: 0x54E6E88 VA: 0x54EAE88
	|-SocketIODataEventArgs<object>..ctor
	|
	|-RVA: 0x54EB2BC Offset: 0x54E72BC VA: 0x54EB2BC
	|-SocketIODataEventArgs<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(ByteArray data, IPEndPoint remoteEndPoint, THeader packetHeader, long receiveTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54EAF48 Offset: 0x54E6F48 VA: 0x54EAF48
	|-SocketIODataEventArgs<object>..ctor
	|
	|-RVA: 0x54EB470 Offset: 0x54E7470 VA: 0x54EB470
	|-SocketIODataEventArgs<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54EAFF8 Offset: 0x54E6FF8 VA: 0x54EAFF8
	|-SocketIODataEventArgs<object>..ctor
	|
	|-RVA: 0x54EB604 Offset: 0x54E7604 VA: 0x54EB604
	|-SocketIODataEventArgs<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: FalconNet.NetIOProcessor
internal class SocketIOErrorEventArgs : EventArgs // TypeDefIndex: 24473
{
	// Fields
	[CompilerGenerated]
	private readonly Exception <Exception>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly IPEndPoint <RemoteIPEndPoint>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly ProtocolType <ProtocolType>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly int <SocketId>k__BackingField; // 0x24
	[CompilerGenerated]
	private readonly string <FucInfo>k__BackingField; // 0x28

	// Properties
	public Exception Exception { get; }
	public IPEndPoint RemoteIPEndPoint { get; }
	public ProtocolType ProtocolType { get; }
	public int SocketId { get; }
	public string FucInfo { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BC0BE4 Offset: 0x6BBCBE4 VA: 0x6BC0BE4
	public Exception get_Exception() { }

	[CompilerGenerated]
	// RVA: 0x6BC0BEC Offset: 0x6BBCBEC VA: 0x6BC0BEC
	public IPEndPoint get_RemoteIPEndPoint() { }

	[CompilerGenerated]
	// RVA: 0x6BC0BF4 Offset: 0x6BBCBF4 VA: 0x6BC0BF4
	public ProtocolType get_ProtocolType() { }

	[CompilerGenerated]
	// RVA: 0x6BC0BFC Offset: 0x6BBCBFC VA: 0x6BC0BFC
	public int get_SocketId() { }

	[CompilerGenerated]
	// RVA: 0x6BC0C04 Offset: 0x6BBCC04 VA: 0x6BC0C04
	public string get_FucInfo() { }

	// RVA: 0x6BC0C0C Offset: 0x6BBCC0C VA: 0x6BC0C0C
	public void .ctor(Exception exception, IPEndPoint remoteIPEndPoint, ProtocolType protocolType = 17, int socketId = 0, string fucInfo = "") { }
}

// Namespace: FalconNet.NetIOProcessor
internal class SocketIOPeerEventArgs : EventArgs // TypeDefIndex: 24474
{
	// Fields
	[CompilerGenerated]
	private readonly IPEndPoint <RemoteIPEndPoint>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly bool <Initial>k__BackingField; // 0x18

	// Properties
	public IPEndPoint RemoteIPEndPoint { get; }
	public bool Initial { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BC0CC4 Offset: 0x6BBCCC4 VA: 0x6BC0CC4
	public IPEndPoint get_RemoteIPEndPoint() { }

	[CompilerGenerated]
	// RVA: 0x6BC0CCC Offset: 0x6BBCCCC VA: 0x6BC0CCC
	public bool get_Initial() { }

	// RVA: 0x6BC0CD4 Offset: 0x6BBCCD4 VA: 0x6BC0CD4
	public void .ctor(IPEndPoint remoteEndPoint, bool initial = False) { }
}

// Namespace: FalconNet.NetIOProcessor
internal interface ITcpOperation // TypeDefIndex: 24475
{
	// Properties
	public abstract Action<SocketIODataEventArgs<TcpHeaderData>> OnDataReceivedCallback { get; set; }
	public abstract Action<SocketIOErrorEventArgs> OnErrorOccurredCallback { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Action<SocketIODataEventArgs<TcpHeaderData>> get_OnDataReceivedCallback();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_OnDataReceivedCallback(Action<SocketIODataEventArgs<TcpHeaderData>> value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Action<SocketIOErrorEventArgs> get_OnErrorOccurredCallback();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_OnErrorOccurredCallback(Action<SocketIOErrorEventArgs> value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnReceiveCompleted(object sender, SocketAsyncEventArgs e);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnSendCompleted(object sender, SocketAsyncEventArgs e);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SetHeaderParser(IPacketHeaderParser<TcpHeaderData> packetHeaderParser);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SetHeaderGenerator(IPacketHeaderGenerator<TcpHeaderData, byte[]> packetHeaderGenerator);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void SocketWork();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Send(byte[] data, TcpHeaderData header, IPEndPoint remoteEndpoint);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Stop();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void StopRemote(IPEndPoint remoteEndpoint);
}

// Namespace: 
[CompilerGenerated]
private struct TcpClientOperation.<ConnectWithTimeoutAsync>d__3 : IAsyncStateMachine // TypeDefIndex: 24476
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public TcpClientOperation <>4__this; // 0x20
	public IPEndPoint remoteEndpoint; // 0x28
	public int timeoutMs; // 0x30
	public int maxReceiveBufferSize; // 0x34
	private Task <timeoutTask>5__2; // 0x38
	private TaskAwaiter<Task> <>u__1; // 0x40

	// Methods

	// RVA: 0x6BC1894 Offset: 0x6BBD894 VA: 0x6BC1894 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x6BC1E80 Offset: 0x6BBDE80 VA: 0x6BC1E80 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: FalconNet.NetIOProcessor
internal class TcpClientOperation : BaseTcpOperation // TypeDefIndex: 24477
{
	// Fields
	private TcpMessageProcessor _messageProcessor; // 0x48
	private IPEndPoint _remoteEndPoint; // 0x50

	// Methods

	// RVA: 0x6BC0D58 Offset: 0x6BBCD58 VA: 0x6BC0D58
	public void .ctor() { }

	[AsyncStateMachine(typeof(TcpClientOperation.<ConnectWithTimeoutAsync>d__3))]
	// RVA: 0x6BC0D80 Offset: 0x6BBCD80 VA: 0x6BC0D80
	public Task<bool> ConnectWithTimeoutAsync(int maxReceiveBufferSize, IPEndPoint remoteEndpoint, int timeoutMs) { }

	// RVA: 0x6BC0EC4 Offset: 0x6BBCEC4 VA: 0x6BC0EC4 Slot: 16
	public override void OnReceiveCompleted(object sender, SocketAsyncEventArgs e) { }

	// RVA: 0x6BC1114 Offset: 0x6BBD114 VA: 0x6BC1114 Slot: 17
	public override void OnSendCompleted(object sender, SocketAsyncEventArgs e) { }

	// RVA: 0x6BC12A8 Offset: 0x6BBD2A8 VA: 0x6BC12A8 Slot: 18
	public override void SocketWork() { }

	// RVA: 0x6BC10BC Offset: 0x6BBD0BC VA: 0x6BC10BC
	private void SocketWork(SocketAsyncEventArgs receiveArgs) { }

	// RVA: 0x6BC14B8 Offset: 0x6BBD4B8 VA: 0x6BC14B8 Slot: 19
	public override void Send(byte[] data, TcpHeaderData header, IPEndPoint remoteEndpoint) { }

	// RVA: 0x6BC1864 Offset: 0x6BBD864 VA: 0x6BC1864 Slot: 20
	public override void Stop() { }

	// RVA: 0x6BC1884 Offset: 0x6BBD884 VA: 0x6BC1884 Slot: 21
	public override void StopRemote(IPEndPoint remoteEndpoint) { }
}

// Namespace: FalconNet.NetIOProcessor
internal class TcpMessageProcessor // TypeDefIndex: 24478
{
	// Fields
	private readonly byte[] _packetBuffer; // 0x10
	private int _bufferOffset; // 0x18
	private int _expectedMessageLength; // 0x1C

	// Methods

	// RVA: 0x6BBFA10 Offset: 0x6BBBA10 VA: 0x6BBFA10
	public bool ProcessReceivedData(SocketAsyncEventArgs e, IPacketHeaderParser<TcpHeaderData> packetHeaderParser, Action<SocketIODataEventArgs<TcpHeaderData>> onDataReceived, IPEndPoint remoteEndPoint) { }

	// RVA: 0x6BC1EFC Offset: 0x6BBDEFC VA: 0x6BC1EFC
	public void Reset() { }

	// RVA: 0x6BBF134 Offset: 0x6BBB134 VA: 0x6BBF134
	public void .ctor() { }
}

// Namespace: FalconNet.NetIOProcessor
internal class TcpPacketHeaderParser : IPacketHeaderParser<TcpHeaderData> // TypeDefIndex: 24479
{
	// Methods

	// RVA: 0x6BC1F04 Offset: 0x6BBDF04 VA: 0x6BC1F04 Slot: 4
	public ValueTuple<TcpHeaderData, ByteArray> ParseHeader(ByteArray msg) { }

	// RVA: 0x6BC20F8 Offset: 0x6BBE0F8 VA: 0x6BC20F8
	public void .ctor() { }
}

// Namespace: FalconNet.NetIOProcessor
internal class TcpPacketHeaderGenerator : IPacketHeaderGenerator<TcpHeaderData, byte[]> // TypeDefIndex: 24480
{
	// Fields
	private readonly byte[] packet; // 0x10

	// Methods

	// RVA: 0x6BC2100 Offset: 0x6BBE100 VA: 0x6BC2100 Slot: 5
	public byte[] BatchGenerate(int connSeqId, List<NetSendParameter> parameters) { }

	// RVA: 0x6BC2108 Offset: 0x6BBE108 VA: 0x6BC2108 Slot: 4
	public byte[] GenerateHeader(TcpHeaderData header, byte[] payload, NetSendParameter parameter) { }

	// RVA: 0x6BC2290 Offset: 0x6BBE290 VA: 0x6BC2290
	public void .ctor() { }
}

// Namespace: FalconNet.NetIOProcessor
internal class TcpHeaderData // TypeDefIndex: 24481
{
	// Fields
	[CompilerGenerated]
	private readonly ushort <MsgId>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ushort <SeqId>k__BackingField; // 0x12

	// Properties
	public ushort MsgId { get; }
	public ushort SeqId { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BC22F8 Offset: 0x6BBE2F8 VA: 0x6BC22F8
	public ushort get_MsgId() { }

	[CompilerGenerated]
	// RVA: 0x6BC2300 Offset: 0x6BBE300 VA: 0x6BC2300
	public ushort get_SeqId() { }

	// RVA: 0x6BC20C8 Offset: 0x6BBE0C8 VA: 0x6BC20C8
	public void .ctor(ushort msgId, ushort seqId) { }
}

// Namespace: FalconNet.NetIOProcessor
internal class TcpServerOperation : BaseTcpOperation // TypeDefIndex: 24482
{
	// Fields
	private readonly SocketAsyncEventArgs _acceptEventArgs; // 0x48
	private readonly ConcurrentDictionary<IPEndPoint, ClientSession> _clientSessions; // 0x50
	private readonly int _bufferSize; // 0x58
	private const int poolCapacity = 5000;
	private const int backlogSize = 1024;

	// Methods

	// RVA: 0x6BC2308 Offset: 0x6BBE308 VA: 0x6BC2308
	public void .ctor(int bufferSize, IPEndPoint localIPEndPoint) { }

	// RVA: 0x6BC255C Offset: 0x6BBE55C VA: 0x6BC255C Slot: 16
	public override void OnReceiveCompleted(object sender, SocketAsyncEventArgs e) { }

	// RVA: 0x6BC25EC Offset: 0x6BBE5EC VA: 0x6BC25EC Slot: 17
	public override void OnSendCompleted(object sender, SocketAsyncEventArgs e) { }

	// RVA: 0x6BC260C Offset: 0x6BBE60C VA: 0x6BC260C Slot: 18
	public override void SocketWork() { }

	// RVA: 0x6BC26B8 Offset: 0x6BBE6B8 VA: 0x6BC26B8 Slot: 19
	public override void Send(byte[] data, TcpHeaderData header, IPEndPoint remoteEndpoint) { }

	// RVA: 0x6BC2610 Offset: 0x6BBE610 VA: 0x6BC2610
	private void StartAcceptLoop() { }

	// RVA: 0x6BC27D0 Offset: 0x6BBE7D0 VA: 0x6BC27D0
	private void BeginAccept() { }

	// RVA: 0x6BC2BC4 Offset: 0x6BBEBC4 VA: 0x6BC2BC4
	private void OnAcceptCompleted(object sender, SocketAsyncEventArgs e) { }

	// RVA: 0x6BC280C Offset: 0x6BBE80C VA: 0x6BC280C
	private void ProcessAccept(SocketAsyncEventArgs e) { }

	// RVA: 0x6BC2BCC Offset: 0x6BBEBCC VA: 0x6BC2BCC
	private void CloseSocket(Socket socket) { }

	// RVA: 0x6BC2E00 Offset: 0x6BBEE00 VA: 0x6BC2E00
	private void HandleSocketDisconnected(IPEndPoint remoteEP) { }

	// RVA: 0x6BC2DA4 Offset: 0x6BBEDA4 VA: 0x6BC2DA4
	private void StartReceive(Socket clientSocket, SocketAsyncEventArgs receiveArgs) { }

	// RVA: 0x6BC2E70 Offset: 0x6BBEE70 VA: 0x6BC2E70 Slot: 20
	public override void Stop() { }

	// RVA: 0x6BC33A4 Offset: 0x6BBF3A4 VA: 0x6BC33A4 Slot: 21
	public override void StopRemote(IPEndPoint remoteEndpoint) { }
}

// Namespace: 
[CompilerGenerated]
private struct TcpSocketIO.<Connect>d__26 : IAsyncStateMachine // TypeDefIndex: 24483
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public TcpSocketIO <>4__this; // 0x20
	public IPEndPoint remoteEndpoint; // 0x28
	private TaskAwaiter<bool> <>u__1; // 0x30

	// Methods

	// RVA: 0x6BC44AC Offset: 0x6BC04AC VA: 0x6BC44AC Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x6BC4CD4 Offset: 0x6BC0CD4 VA: 0x6BC4CD4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: FalconNet.NetIOProcessor
internal class TcpSocketIO : ISocketIO<TcpHeaderData> // TypeDefIndex: 24484
{
	// Fields
	private CancellationTokenSource _cts; // 0x10
	private Thread _socketWorkerThread; // 0x18
	private const int MaxReceiveBufferSize = 1500;
	internal const int MaxPacketBufferSize = 102400;
	private IPEndPoint _localIPEndPoint; // 0x20
	private IPEndPoint _remoteEndpoint; // 0x28
	private ITcpOperation _socketOperation; // 0x30
	[CompilerGenerated]
	private IPacketHeaderParser<TcpHeaderData> <PacketHeaderParser>k__BackingField; // 0x38
	[CompilerGenerated]
	private IPacketHeaderGenerator<TcpHeaderData, byte[]> <PacketHeaderGenerator>k__BackingField; // 0x40
	[CompilerGenerated]
	private EventHandler<SocketIODataEventArgs<TcpHeaderData>> DataReceived; // 0x48
	[CompilerGenerated]
	private EventHandler<SocketIOErrorEventArgs> ErrorOccurred; // 0x50
	private EndPointRole _role; // 0x58
	private bool _isConnecting; // 0x5C

	// Properties
	public IPacketHeaderParser<TcpHeaderData> PacketHeaderParser { get; set; }
	public IPacketHeaderGenerator<TcpHeaderData, byte[]> PacketHeaderGenerator { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BC3628 Offset: 0x6BBF628 VA: 0x6BC3628
	public IPacketHeaderParser<TcpHeaderData> get_PacketHeaderParser() { }

	[CompilerGenerated]
	// RVA: 0x6BC3630 Offset: 0x6BBF630 VA: 0x6BC3630
	public void set_PacketHeaderParser(IPacketHeaderParser<TcpHeaderData> value) { }

	[CompilerGenerated]
	// RVA: 0x6BC3638 Offset: 0x6BBF638 VA: 0x6BC3638
	public IPacketHeaderGenerator<TcpHeaderData, byte[]> get_PacketHeaderGenerator() { }

	[CompilerGenerated]
	// RVA: 0x6BC3640 Offset: 0x6BBF640 VA: 0x6BC3640
	public void set_PacketHeaderGenerator(IPacketHeaderGenerator<TcpHeaderData, byte[]> value) { }

	[CompilerGenerated]
	// RVA: 0x6BC3648 Offset: 0x6BBF648 VA: 0x6BC3648 Slot: 12
	public void add_DataReceived(EventHandler<SocketIODataEventArgs<TcpHeaderData>> value) { }

	[CompilerGenerated]
	// RVA: 0x6BC36F8 Offset: 0x6BBF6F8 VA: 0x6BC36F8 Slot: 13
	public void remove_DataReceived(EventHandler<SocketIODataEventArgs<TcpHeaderData>> value) { }

	[CompilerGenerated]
	// RVA: 0x6BC37A8 Offset: 0x6BBF7A8 VA: 0x6BC37A8 Slot: 14
	public void add_ErrorOccurred(EventHandler<SocketIOErrorEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x6BC3858 Offset: 0x6BBF858 VA: 0x6BC3858 Slot: 15
	public void remove_ErrorOccurred(EventHandler<SocketIOErrorEventArgs> value) { }

	// RVA: 0x6BC3908 Offset: 0x6BBF908 VA: 0x6BC3908
	public void .ctor() { }

	// RVA: 0x6BC39B0 Offset: 0x6BBF9B0 VA: 0x6BC39B0 Slot: 4
	public void Bind() { }

	// RVA: 0x6BC3DC0 Offset: 0x6BBFDC0 VA: 0x6BC3DC0 Slot: 5
	public void SetBindPort(int port) { }

	[AsyncStateMachine(typeof(TcpSocketIO.<Connect>d__26))]
	// RVA: 0x6BC3E64 Offset: 0x6BBFE64 VA: 0x6BC3E64 Slot: 6
	public Task Connect(IPEndPoint remoteEndpoint) { }

	// RVA: 0x6BC3C84 Offset: 0x6BBFC84 VA: 0x6BC3C84
	private void StartSocketWorkerThread() { }

	// RVA: 0x6BC3F60 Offset: 0x6BBFF60 VA: 0x6BC3F60
	private void SocketWork() { }

	// RVA: 0x6BC4004 Offset: 0x6BC0004 VA: 0x6BC4004 Slot: 7
	public void Stop() { }

	// RVA: 0x6BC40F8 Offset: 0x6BC00F8 VA: 0x6BC40F8 Slot: 8
	public int GetCurrentSocketId() { }

	// RVA: 0x6BC4100 Offset: 0x6BC0100 VA: 0x6BC4100 Slot: 9
	public void StopRemote(IPEndPoint remoteEndpoint) { }

	// RVA: 0x6BC41B4 Offset: 0x6BC01B4 VA: 0x6BC41B4 Slot: 10
	public void Reinitialization() { }

	// RVA: 0x6BC41C8 Offset: 0x6BC01C8 VA: 0x6BC41C8 Slot: 11
	public void Send(byte[] data, TcpHeaderData header, NetSendParameter parameter) { }

	// RVA: 0x6BC43B8 Offset: 0x6BC03B8 VA: 0x6BC43B8 Slot: 16
	protected virtual void OnDataReceived(SocketIODataEventArgs<TcpHeaderData> e) { }

	// RVA: 0x6BC4460 Offset: 0x6BC0460 VA: 0x6BC4460 Slot: 17
	protected virtual void OnErrorOccurred(SocketIOErrorEventArgs e) { }

	[CompilerGenerated]
	// RVA: 0x6BC4488 Offset: 0x6BC0488 VA: 0x6BC4488
	private void <Bind>b__23_0(SocketIODataEventArgs<TcpHeaderData> args) { }

	[CompilerGenerated]
	// RVA: 0x6BC4498 Offset: 0x6BC0498 VA: 0x6BC4498
	private void <Bind>b__23_1(SocketIOErrorEventArgs args) { }

	[CompilerGenerated]
	// RVA: 0x6BC44A8 Offset: 0x6BC04A8 VA: 0x6BC44A8
	private void <StartSocketWorkerThread>b__27_0() { }
}

// Namespace: FalconNet.NetIOProcessor
internal class UdpPacketHeaderParser : IPacketHeaderParser<UdpHeaderData> // TypeDefIndex: 24485
{
	// Methods

	// RVA: 0x6BC4D3C Offset: 0x6BC0D3C VA: 0x6BC4D3C Slot: 4
	public ValueTuple<UdpHeaderData, ByteArray> ParseHeader(ByteArray msg) { }

	// RVA: 0x6BC4F94 Offset: 0x6BC0F94 VA: 0x6BC4F94
	public void .ctor() { }
}

// Namespace: FalconNet.NetIOProcessor
internal class UdpPacketHeaderGenerator : IPacketHeaderGenerator<UdpHeaderData, ByteArray> // TypeDefIndex: 24486
{
	// Methods

	// RVA: 0x6BC4F9C Offset: 0x6BC0F9C VA: 0x6BC4F9C Slot: 4
	public ByteArray GenerateHeader(UdpHeaderData header, byte[] payload, NetSendParameter parameter) { }

	// RVA: 0x6BC552C Offset: 0x6BC152C VA: 0x6BC552C Slot: 5
	public ByteArray BatchGenerate(int connSeqId, List<NetSendParameter> parameters) { }

	// RVA: 0x6BC5C18 Offset: 0x6BC1C18 VA: 0x6BC5C18
	public void .ctor() { }
}

// Namespace: FalconNet.NetIOProcessor
internal class UdpHeaderData // TypeDefIndex: 24487
{
	// Fields
	internal ushort MsgId; // 0x10
	internal ushort ChannelType; // 0x12
	internal int SeqId; // 0x14
	internal ushort CurFragmentId; // 0x18
	internal ushort MaxFragmentId; // 0x1A

	// Methods

	// RVA: 0x6BC4F3C Offset: 0x6BC0F3C VA: 0x6BC4F3C
	internal void .ctor(ushort msgId, ushort channelType, int seqId, ushort curFragmentId, ushort maxFragmentId) { }

	// RVA: 0x6BC5C20 Offset: 0x6BC1C20 VA: 0x6BC5C20
	internal void .ctor() { }

	// RVA: 0x6BC5C28 Offset: 0x6BC1C28 VA: 0x6BC5C28 Slot: 3
	public override string ToString() { }
}

// Namespace: FalconNet.NetIOProcessor
internal class UdpSocketIO : IUdpSocketIO<UdpHeaderData>, ISocketIO<UdpHeaderData> // TypeDefIndex: 24488
{
	// Fields
	private Socket _socket; // 0x10
	private IPEndPoint _localEndpoint; // 0x18
	private IPEndPoint _remoteEndpoint; // 0x20
	private Thread _receiveThread; // 0x28
	private Thread _sendThread; // 0x30
	private CancellationTokenSource _cts; // 0x38
	private readonly int _bufferSize; // 0x40
	private readonly int _receiveBufferSize; // 0x44
	private readonly int _sendBufferSize; // 0x48
	private EndPointRole _role; // 0x4C
	private int _socketId; // 0x50
	[CompilerGenerated]
	private EventHandler<SocketIODataEventArgs<UdpHeaderData>> DataReceived; // 0x58
	[CompilerGenerated]
	private EventHandler<SocketIOErrorEventArgs> ErrorOccurred; // 0x60
	private AutoResetEvent _sendSignal; // 0x68
	private readonly ConcurrentQueue<UdpSendItem> _sendQueue; // 0x70
	[CompilerGenerated]
	private IPacketHeaderParser<UdpHeaderData> <PacketHeaderParser>k__BackingField; // 0x78
	[CompilerGenerated]
	private IPacketHeaderGenerator<UdpHeaderData, ByteArray> <PacketHeaderGenerator>k__BackingField; // 0x80

	// Properties
	private IPacketHeaderParser<UdpHeaderData> PacketHeaderParser { get; set; }
	private IPacketHeaderGenerator<UdpHeaderData, ByteArray> PacketHeaderGenerator { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BC5D00 Offset: 0x6BC1D00 VA: 0x6BC5D00 Slot: 13
	public void add_DataReceived(EventHandler<SocketIODataEventArgs<UdpHeaderData>> value) { }

	[CompilerGenerated]
	// RVA: 0x6BC5DB0 Offset: 0x6BC1DB0 VA: 0x6BC5DB0 Slot: 14
	public void remove_DataReceived(EventHandler<SocketIODataEventArgs<UdpHeaderData>> value) { }

	[CompilerGenerated]
	// RVA: 0x6BC5E60 Offset: 0x6BC1E60 VA: 0x6BC5E60 Slot: 15
	public void add_ErrorOccurred(EventHandler<SocketIOErrorEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x6BC5F10 Offset: 0x6BC1F10 VA: 0x6BC5F10 Slot: 16
	public void remove_ErrorOccurred(EventHandler<SocketIOErrorEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x6BC5FC0 Offset: 0x6BC1FC0 VA: 0x6BC5FC0
	private IPacketHeaderParser<UdpHeaderData> get_PacketHeaderParser() { }

	[CompilerGenerated]
	// RVA: 0x6BC5FC8 Offset: 0x6BC1FC8 VA: 0x6BC5FC8
	private void set_PacketHeaderParser(IPacketHeaderParser<UdpHeaderData> value) { }

	[CompilerGenerated]
	// RVA: 0x6BC5FD0 Offset: 0x6BC1FD0 VA: 0x6BC5FD0
	private IPacketHeaderGenerator<UdpHeaderData, ByteArray> get_PacketHeaderGenerator() { }

	[CompilerGenerated]
	// RVA: 0x6BC5FD8 Offset: 0x6BC1FD8 VA: 0x6BC5FD8
	private void set_PacketHeaderGenerator(IPacketHeaderGenerator<UdpHeaderData, ByteArray> value) { }

	// RVA: 0x6BC5FE0 Offset: 0x6BC1FE0 VA: 0x6BC5FE0
	public void .ctor(int bufferSize = 1048576) { }

	// RVA: 0x6BC6134 Offset: 0x6BC2134 VA: 0x6BC6134 Slot: 9
	public int GetCurrentSocketId() { }

	// RVA: 0x6BC614C Offset: 0x6BC214C VA: 0x6BC614C Slot: 5
	public void Bind() { }

	// RVA: 0x6BC6428 Offset: 0x6BC2428 VA: 0x6BC6428 Slot: 6
	public void SetBindPort(int port) { }

	// RVA: 0x6BC64CC Offset: 0x6BC24CC VA: 0x6BC64CC Slot: 7
	public Task Connect(IPEndPoint remoteEndpoint) { }

	// RVA: 0x6BC620C Offset: 0x6BC220C VA: 0x6BC620C
	private void StartThread() { }

	// RVA: 0x6BC6708 Offset: 0x6BC2708 VA: 0x6BC6708 Slot: 8
	public void Stop() { }

	// RVA: 0x6BC6978 Offset: 0x6BC2978 VA: 0x6BC6978 Slot: 10
	public void StopRemote(IPEndPoint remoteEndpoint) { }

	// RVA: 0x6BC697C Offset: 0x6BC297C VA: 0x6BC697C Slot: 11
	public void Reinitialization() { }

	// RVA: 0x6BC6B80 Offset: 0x6BC2B80 VA: 0x6BC6B80 Slot: 4
	public void BatchSend(NetUdpBatchSendParameter parameter) { }

	// RVA: 0x6BC7000 Offset: 0x6BC3000 VA: 0x6BC7000 Slot: 12
	public void Send(byte[] payload, UdpHeaderData header, NetSendParameter parameter) { }

	// RVA: 0x6BC7484 Offset: 0x6BC3484 VA: 0x6BC7484
	private void SendLoop(CancellationToken cancellationToken) { }

	// RVA: 0x6BC6F0C Offset: 0x6BC2F0C VA: 0x6BC6F0C
	public void EnqueueSend(byte[] buffer, IPEndPoint remoteEndPoint) { }

	// RVA: 0x6BC7AEC Offset: 0x6BC3AEC VA: 0x6BC7AEC
	private void ReceiveLoop(CancellationToken cancellationToken) { }

	// RVA: 0x6BC884C Offset: 0x6BC484C VA: 0x6BC884C Slot: 17
	protected virtual void OnDataReceived(SocketIODataEventArgs<UdpHeaderData> e) { }

	// RVA: 0x6BC88F4 Offset: 0x6BC48F4 VA: 0x6BC88F4 Slot: 18
	protected virtual void OnErrorOccurred(SocketIOErrorEventArgs e) { }

	[CompilerGenerated]
	// RVA: 0x6BC891C Offset: 0x6BC491C VA: 0x6BC891C
	private void <StartThread>b__32_0() { }

	[CompilerGenerated]
	// RVA: 0x6BC8948 Offset: 0x6BC4948 VA: 0x6BC8948
	private void <StartThread>b__32_1() { }
}

// Namespace: FalconNet.NETEventDriven
internal class EventProcessor // TypeDefIndex: 24489
{
	// Fields
	private static readonly BlockingCollection<IEvent> _eventQueue; // 0x0
	private readonly Thread _workerThread; // 0x10
	private readonly Thread _callbackProcessThread; // 0x18
	private const int MinCycleDelay = 30;
	public static readonly Dictionary<int, Action<IEvent>> InvokedEvents; // 0x8
	private readonly CancellationTokenSource _cts; // 0x20
	private readonly bool _isServer; // 0x28
	private static long _globalEventId; // 0x10
	private uint _processEventIdBitmap; // 0x2C
	private uint _processEventNumber; // 0x30

	// Methods

	// RVA: 0x6BC8974 Offset: 0x6BC4974 VA: 0x6BC8974
	public void .ctor(bool isServer) { }

	// RVA: 0x6BC8B64 Offset: 0x6BC4B64 VA: 0x6BC8B64
	private void Start() { }

	// RVA: 0x6BC13A8 Offset: 0x6BBD3A8 VA: 0x6BC13A8
	public static void Publish(IEvent evt) { }

	// RVA: 0x6BC8BA4 Offset: 0x6BC4BA4 VA: 0x6BC8BA4
	public static bool Register(NetEvent eventId, Action<IEvent> callBack) { }

	// RVA: 0x6BC8D28 Offset: 0x6BC4D28 VA: 0x6BC8D28
	public static void UnRegister(NetEvent eventId, Action<IEvent> callBack) { }

	// RVA: 0x6BC8EEC Offset: 0x6BC4EEC VA: 0x6BC8EEC
	private void MarkProcessEventId(int eventId) { }

	// RVA: 0x6BC8F10 Offset: 0x6BC4F10 VA: 0x6BC8F10
	public uint GetProcessEventIdBitmap() { }

	// RVA: 0x6BC8F18 Offset: 0x6BC4F18 VA: 0x6BC8F18
	public void ResetProcessEventIdBitmap() { }

	// RVA: 0x6BC8F20 Offset: 0x6BC4F20 VA: 0x6BC8F20
	private void ProcessCallBack(CancellationToken cancellationToken) { }

	// RVA: 0x6BC91E0 Offset: 0x6BC51E0 VA: 0x6BC91E0
	private void ProcessEvents(CancellationToken cancellationToken) { }

	// RVA: 0x6BC9BB8 Offset: 0x6BC5BB8 VA: 0x6BC9BB8
	private void ProcessEventCallBacks(List<IEvent> events) { }

	// RVA: 0x6BC9EAC Offset: 0x6BC5EAC VA: 0x6BC9EAC
	public void Shutdown() { }

	// RVA: 0x6BC9F48 Offset: 0x6BC5F48 VA: 0x6BC9F48
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x6BCA048 Offset: 0x6BC6048 VA: 0x6BCA048
	private void <.ctor>b__10_0() { }

	[CompilerGenerated]
	// RVA: 0x6BCA074 Offset: 0x6BC6074 VA: 0x6BCA074
	private void <.ctor>b__10_1() { }
}

// Namespace: FalconNet.NETEventDriven
internal interface IEvent // TypeDefIndex: 24490
{
	// Properties
	public abstract ushort EventId { get; }
	public abstract object ParameterObject { get; }
	public abstract long EventUniqueId { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ushort get_EventId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object get_ParameterObject();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract long get_EventUniqueId();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_EventUniqueId(long value);
}

// Namespace: FalconNet.NETEventDriven
internal interface IEvent<TParameter> : IEvent // TypeDefIndex: 24491
{
	// Properties
	public abstract TParameter Parameter { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TParameter get_Parameter();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEvent<__Il2CppFullySharedGenericType>.get_Parameter
	*/
}

// Namespace: FalconNet.NETEventDriven
internal class NetEvent<TParameter> : IEvent<TParameter>, IEvent // TypeDefIndex: 24492
{
	// Fields
	[CompilerGenerated]
	private ushort <EventId>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly TParameter <Parameter>k__BackingField; // 0x0
	[CompilerGenerated]
	private long <EventUniqueId>k__BackingField; // 0x0

	// Properties
	public ushort EventId { get; set; }
	public object ParameterObject { get; }
	public TParameter Parameter { get; }
	public long EventUniqueId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public ushort get_EventId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5124394 Offset: 0x5120394 VA: 0x5124394
	|-NetEvent<object>.get_EventId
	|
	|-RVA: 0x5124404 Offset: 0x5120404 VA: 0x5124404
	|-NetEvent<__Il2CppFullySharedGenericType>.get_EventId
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_EventId(ushort value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x512439C Offset: 0x512039C VA: 0x512439C
	|-NetEvent<object>.set_EventId
	|
	|-RVA: 0x5124428 Offset: 0x5120428 VA: 0x5124428
	|-NetEvent<__Il2CppFullySharedGenericType>.set_EventId
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public object get_ParameterObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51243A4 Offset: 0x51203A4 VA: 0x51243A4
	|-NetEvent<object>.get_ParameterObject
	|
	|-RVA: 0x5124444 Offset: 0x5120444 VA: 0x5124444
	|-NetEvent<__Il2CppFullySharedGenericType>.get_ParameterObject
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public TParameter get_Parameter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51243AC Offset: 0x51203AC VA: 0x51243AC
	|-NetEvent<object>.get_Parameter
	|
	|-RVA: 0x51244E4 Offset: 0x51204E4 VA: 0x51244E4
	|-NetEvent<__Il2CppFullySharedGenericType>.get_Parameter
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 7
	public long get_EventUniqueId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51243B4 Offset: 0x51203B4 VA: 0x51243B4
	|-NetEvent<object>.get_EventUniqueId
	|
	|-RVA: 0x5124584 Offset: 0x5120584 VA: 0x5124584
	|-NetEvent<__Il2CppFullySharedGenericType>.get_EventUniqueId
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 8
	public void set_EventUniqueId(long value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51243BC Offset: 0x51203BC VA: 0x51243BC
	|-NetEvent<object>.set_EventUniqueId
	|
	|-RVA: 0x51245AC Offset: 0x51205AC VA: 0x51245AC
	|-NetEvent<__Il2CppFullySharedGenericType>.set_EventUniqueId
	*/

	// RVA: -1 Offset: -1
	public void .ctor(ushort eventId, TParameter parameter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x51243C4 Offset: 0x51203C4 VA: 0x51243C4
	|-NetEvent<object>..ctor
	|
	|-RVA: 0x51245CC Offset: 0x51205CC VA: 0x51245CC
	|-NetEvent<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: FalconNet.NETEventDriven
internal class EmptyParameter // TypeDefIndex: 24493
{
	// Methods

	// RVA: 0x6BCA098 Offset: 0x6BC6098 VA: 0x6BCA098
	public void .ctor() { }
}

// Namespace: FalconNet.NETEventDriven
internal class NetStateParameter // TypeDefIndex: 24494
{
	// Fields
	[CompilerGenerated]
	private IPEndPoint <RemoteEndPoint>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly NetPeerState <TargetNetPeerState>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <EventContext>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <ErrorContext>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <FucInfo>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <SocketId>k__BackingField; // 0x38

	// Properties
	public IPEndPoint RemoteEndPoint { get; set; }
	public NetPeerState TargetNetPeerState { get; }
	public string EventContext { get; set; }
	public string ErrorContext { get; set; }
	public string FucInfo { get; set; }
	public int SocketId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BCA0A0 Offset: 0x6BC60A0 VA: 0x6BCA0A0
	public IPEndPoint get_RemoteEndPoint() { }

	[CompilerGenerated]
	// RVA: 0x6BCA0A8 Offset: 0x6BC60A8 VA: 0x6BCA0A8
	public void set_RemoteEndPoint(IPEndPoint value) { }

	// RVA: 0x6BCA0B0 Offset: 0x6BC60B0 VA: 0x6BCA0B0
	public void .ctor(NetPeerState targetNetPeerState) { }

	[CompilerGenerated]
	// RVA: 0x6BCA0D8 Offset: 0x6BC60D8 VA: 0x6BCA0D8
	public NetPeerState get_TargetNetPeerState() { }

	[CompilerGenerated]
	// RVA: 0x6BCA0E0 Offset: 0x6BC60E0 VA: 0x6BCA0E0
	public string get_EventContext() { }

	[CompilerGenerated]
	// RVA: 0x6BCA0E8 Offset: 0x6BC60E8 VA: 0x6BCA0E8
	public void set_EventContext(string value) { }

	[CompilerGenerated]
	// RVA: 0x6BCA0F0 Offset: 0x6BC60F0 VA: 0x6BCA0F0
	public string get_ErrorContext() { }

	[CompilerGenerated]
	// RVA: 0x6BCA0F8 Offset: 0x6BC60F8 VA: 0x6BCA0F8
	public void set_ErrorContext(string value) { }

	[CompilerGenerated]
	// RVA: 0x6BCA100 Offset: 0x6BC6100 VA: 0x6BCA100
	public string get_FucInfo() { }

	[CompilerGenerated]
	// RVA: 0x6BCA108 Offset: 0x6BC6108 VA: 0x6BCA108
	public void set_FucInfo(string value) { }

	[CompilerGenerated]
	// RVA: 0x6BCA110 Offset: 0x6BC6110 VA: 0x6BCA110
	public int get_SocketId() { }

	[CompilerGenerated]
	// RVA: 0x6BCA118 Offset: 0x6BC6118 VA: 0x6BCA118
	public void set_SocketId(int value) { }
}

// Namespace: FalconNet.NETEventDriven
internal class NetStateInitializingClientParameter : NetStateParameter // TypeDefIndex: 24495
{
	// Fields
	[CompilerGenerated]
	private readonly bool <IsForceTcp>k__BackingField; // 0x3C

	// Properties
	public bool IsForceTcp { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BCA120 Offset: 0x6BC6120 VA: 0x6BCA120
	public bool get_IsForceTcp() { }

	// RVA: 0x6BCA128 Offset: 0x6BC6128 VA: 0x6BCA128
	public void .ctor(NetPeerState targetNetPeerState, IPEndPoint remoteEndPoint, bool isForceTcp) { }
}

// Namespace: FalconNet.NETEventDriven
internal class NetStateRunHalfParameter : NetStateParameter // TypeDefIndex: 24496
{
	// Fields
	[CompilerGenerated]
	private readonly ProtocolType <ErrorProtoType>k__BackingField; // 0x3C

	// Properties
	public ProtocolType ErrorProtoType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BCA174 Offset: 0x6BC6174 VA: 0x6BCA174
	public ProtocolType get_ErrorProtoType() { }

	// RVA: 0x6BCA17C Offset: 0x6BC617C VA: 0x6BCA17C
	public void .ctor(NetPeerState targetNetPeerState, ProtocolType errorProtoType) { }
}

// Namespace: FalconNet.NETEventDriven
internal class NetStateErrorOccuredClientParameter : NetStateParameter // TypeDefIndex: 24497
{
	// Fields
	public ProtocolType ErrorProtocolType; // 0x3C

	// Methods

	// RVA: 0x6BCA1AC Offset: 0x6BC61AC VA: 0x6BCA1AC
	public void .ctor(NetPeerState targetNetPeerState, ProtocolType errorProtoType) { }
}

// Namespace: FalconNet.NETEventDriven
internal class NetReceiveParameter // TypeDefIndex: 24498
{
	// Fields
	[CompilerGenerated]
	private ProtocolType <ProtocolType>k__BackingField; // 0x10
	[CompilerGenerated]
	private IPEndPoint <RemoteIPEndPoint>k__BackingField; // 0x18
	[CompilerGenerated]
	private byte <ChannelType>k__BackingField; // 0x20

	// Properties
	public ProtocolType ProtocolType { get; set; }
	public IPEndPoint RemoteIPEndPoint { get; set; }
	public byte ChannelType { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BCA1DC Offset: 0x6BC61DC VA: 0x6BCA1DC
	public ProtocolType get_ProtocolType() { }

	[CompilerGenerated]
	// RVA: 0x6BCA1E4 Offset: 0x6BC61E4 VA: 0x6BCA1E4
	public void set_ProtocolType(ProtocolType value) { }

	[CompilerGenerated]
	// RVA: 0x6BCA1EC Offset: 0x6BC61EC VA: 0x6BCA1EC
	public IPEndPoint get_RemoteIPEndPoint() { }

	[CompilerGenerated]
	// RVA: 0x6BCA1F4 Offset: 0x6BC61F4 VA: 0x6BCA1F4
	public void set_RemoteIPEndPoint(IPEndPoint value) { }

	[CompilerGenerated]
	// RVA: 0x6BCA1FC Offset: 0x6BC61FC VA: 0x6BCA1FC
	public byte get_ChannelType() { }

	[CompilerGenerated]
	// RVA: 0x6BCA204 Offset: 0x6BC6204 VA: 0x6BCA204
	public void set_ChannelType(byte value) { }

	// RVA: 0x6BCA20C Offset: 0x6BC620C VA: 0x6BCA20C
	public void .ctor(ProtocolType protocolType, IPEndPoint remoteIPEndPoint, byte channelType) { }
}

// Namespace: FalconNet.NETEventDriven
internal class NetSendTriggerParameter // TypeDefIndex: 24499
{
	// Fields
	[CompilerGenerated]
	private ProtocolType <ProtocolType>k__BackingField; // 0x10
	[CompilerGenerated]
	private IPEndPoint <RemoteIPEndPoint>k__BackingField; // 0x18
	[CompilerGenerated]
	private byte <ChannelType>k__BackingField; // 0x20

	// Properties
	public ProtocolType ProtocolType { get; set; }
	public IPEndPoint RemoteIPEndPoint { get; set; }
	public byte ChannelType { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BCA258 Offset: 0x6BC6258 VA: 0x6BCA258
	public ProtocolType get_ProtocolType() { }

	[CompilerGenerated]
	// RVA: 0x6BCA260 Offset: 0x6BC6260 VA: 0x6BCA260
	public void set_ProtocolType(ProtocolType value) { }

	[CompilerGenerated]
	// RVA: 0x6BCA268 Offset: 0x6BC6268 VA: 0x6BCA268
	public IPEndPoint get_RemoteIPEndPoint() { }

	[CompilerGenerated]
	// RVA: 0x6BCA270 Offset: 0x6BC6270 VA: 0x6BCA270
	public void set_RemoteIPEndPoint(IPEndPoint value) { }

	[CompilerGenerated]
	// RVA: 0x6BCA278 Offset: 0x6BC6278 VA: 0x6BCA278
	public byte get_ChannelType() { }

	[CompilerGenerated]
	// RVA: 0x6BCA280 Offset: 0x6BC6280 VA: 0x6BCA280
	public void set_ChannelType(byte value) { }

	// RVA: 0x6BCA288 Offset: 0x6BC6288 VA: 0x6BCA288
	public void .ctor(ProtocolType protocolType, IPEndPoint remoteIPEndPoint, byte channelType) { }
}

// Namespace: FalconNet.NETEventDriven
internal class NetSendParameter // TypeDefIndex: 24500
{
	// Fields
	[CompilerGenerated]
	private ProtocolType <ProtocolType>k__BackingField; // 0x10
	[CompilerGenerated]
	private object <HeaderData>k__BackingField; // 0x18
	[CompilerGenerated]
	private IPEndPoint <RemoteIPEndPoint>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <RetryTimes>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte[] <Data>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <ConnectionSeqId>k__BackingField; // 0x38
	[CompilerGenerated]
	private EndPointRole <Role>k__BackingField; // 0x3C

	// Properties
	public ProtocolType ProtocolType { get; set; }
	public object HeaderData { get; set; }
	public IPEndPoint RemoteIPEndPoint { get; set; }
	public int RetryTimes { get; set; }
	public byte[] Data { get; set; }
	public int ConnectionSeqId { get; set; }
	public EndPointRole Role { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BCA2D4 Offset: 0x6BC62D4 VA: 0x6BCA2D4
	public ProtocolType get_ProtocolType() { }

	[CompilerGenerated]
	// RVA: 0x6BCA2DC Offset: 0x6BC62DC VA: 0x6BCA2DC
	public void set_ProtocolType(ProtocolType value) { }

	[CompilerGenerated]
	// RVA: 0x6BCA2E4 Offset: 0x6BC62E4 VA: 0x6BCA2E4
	public object get_HeaderData() { }

	[CompilerGenerated]
	// RVA: 0x6BCA2EC Offset: 0x6BC62EC VA: 0x6BCA2EC
	public void set_HeaderData(object value) { }

	[CompilerGenerated]
	// RVA: 0x6BCA2F4 Offset: 0x6BC62F4 VA: 0x6BCA2F4
	public IPEndPoint get_RemoteIPEndPoint() { }

	[CompilerGenerated]
	// RVA: 0x6BCA2FC Offset: 0x6BC62FC VA: 0x6BCA2FC
	public void set_RemoteIPEndPoint(IPEndPoint value) { }

	[CompilerGenerated]
	// RVA: 0x6BCA304 Offset: 0x6BC6304 VA: 0x6BCA304
	public int get_RetryTimes() { }

	[CompilerGenerated]
	// RVA: 0x6BCA30C Offset: 0x6BC630C VA: 0x6BCA30C
	public void set_RetryTimes(int value) { }

	[CompilerGenerated]
	// RVA: 0x6BCA314 Offset: 0x6BC6314 VA: 0x6BCA314
	public byte[] get_Data() { }

	[CompilerGenerated]
	// RVA: 0x6BCA31C Offset: 0x6BC631C VA: 0x6BCA31C
	public void set_Data(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x6BCA324 Offset: 0x6BC6324 VA: 0x6BCA324
	public int get_ConnectionSeqId() { }

	[CompilerGenerated]
	// RVA: 0x6BCA32C Offset: 0x6BC632C VA: 0x6BCA32C
	public void set_ConnectionSeqId(int value) { }

	[CompilerGenerated]
	// RVA: 0x6BCA334 Offset: 0x6BC6334 VA: 0x6BCA334
	public EndPointRole get_Role() { }

	[CompilerGenerated]
	// RVA: 0x6BCA33C Offset: 0x6BC633C VA: 0x6BCA33C
	public void set_Role(EndPointRole value) { }

	// RVA: 0x6BC87A8 Offset: 0x6BC47A8 VA: 0x6BC87A8
	public void .ctor(ProtocolType protocolType, object headerData, byte[] data, IPEndPoint remoteIPEndPoint, int retryTimes) { }

	// RVA: 0x6BCA344 Offset: 0x6BC6344 VA: 0x6BCA344
	public void .ctor(IPEndPoint remoteIPEndPoint) { }
}

// Namespace: FalconNet.NETEventDriven
internal class NetUdpBatchSendParameter // TypeDefIndex: 24501
{
	// Fields
	[CompilerGenerated]
	private List<NetSendParameter> <SendParameters>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <ConnectionSeqId>k__BackingField; // 0x18

	// Properties
	public List<NetSendParameter> SendParameters { get; set; }
	public int ConnectionSeqId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BCA374 Offset: 0x6BC6374 VA: 0x6BCA374
	public List<NetSendParameter> get_SendParameters() { }

	[CompilerGenerated]
	// RVA: 0x6BCA37C Offset: 0x6BC637C VA: 0x6BCA37C
	public void set_SendParameters(List<NetSendParameter> value) { }

	[CompilerGenerated]
	// RVA: 0x6BCA384 Offset: 0x6BC6384 VA: 0x6BCA384
	public int get_ConnectionSeqId() { }

	[CompilerGenerated]
	// RVA: 0x6BCA38C Offset: 0x6BC638C VA: 0x6BCA38C
	public void set_ConnectionSeqId(int value) { }

	// RVA: 0x6BCA394 Offset: 0x6BC6394 VA: 0x6BCA394
	public void .ctor(List<NetSendParameter> sendParameters) { }
}

// Namespace: FalconNet.NETEventDriven
internal class NetSocketConnectParameter // TypeDefIndex: 24502
{
	// Fields
	[CompilerGenerated]
	private ProtocolType <ProtocolType>k__BackingField; // 0x10
	[CompilerGenerated]
	private IPEndPoint <RemoteIPEndPoint>k__BackingField; // 0x18

	// Properties
	public ProtocolType ProtocolType { get; set; }
	public IPEndPoint RemoteIPEndPoint { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BCA3C4 Offset: 0x6BC63C4 VA: 0x6BCA3C4
	public ProtocolType get_ProtocolType() { }

	[CompilerGenerated]
	// RVA: 0x6BCA3CC Offset: 0x6BC63CC VA: 0x6BCA3CC
	public void set_ProtocolType(ProtocolType value) { }

	[CompilerGenerated]
	// RVA: 0x6BCA3D4 Offset: 0x6BC63D4 VA: 0x6BCA3D4
	public IPEndPoint get_RemoteIPEndPoint() { }

	[CompilerGenerated]
	// RVA: 0x6BCA3DC Offset: 0x6BC63DC VA: 0x6BCA3DC
	public void set_RemoteIPEndPoint(IPEndPoint value) { }

	// RVA: 0x6BCA3E4 Offset: 0x6BC63E4 VA: 0x6BCA3E4
	public void .ctor(ProtocolType protocolType, IPEndPoint remoteIPEndPoint) { }
}

// Namespace: FalconNet.NETEventDriven
internal class NetSocketBindParameter // TypeDefIndex: 24503
{
	// Fields
	[CompilerGenerated]
	private ProtocolType <ProtocolType>k__BackingField; // 0x10

	// Properties
	public ProtocolType ProtocolType { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BCA41C Offset: 0x6BC641C VA: 0x6BCA41C
	public ProtocolType get_ProtocolType() { }

	[CompilerGenerated]
	// RVA: 0x6BCA424 Offset: 0x6BC6424 VA: 0x6BCA424
	public void set_ProtocolType(ProtocolType value) { }

	// RVA: 0x6BCA42C Offset: 0x6BC642C VA: 0x6BCA42C
	public void .ctor(ProtocolType protocolType) { }
}

// Namespace: FalconNet.NETEventDriven
internal class NetBaseSocketParameter // TypeDefIndex: 24504
{
	// Fields
	[CompilerGenerated]
	private ProtocolType <ProtocolType>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <SocketId>k__BackingField; // 0x14

	// Properties
	public ProtocolType ProtocolType { get; set; }
	public int SocketId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BCA454 Offset: 0x6BC6454 VA: 0x6BCA454
	public ProtocolType get_ProtocolType() { }

	[CompilerGenerated]
	// RVA: 0x6BCA45C Offset: 0x6BC645C VA: 0x6BCA45C
	public void set_ProtocolType(ProtocolType value) { }

	[CompilerGenerated]
	// RVA: 0x6BCA464 Offset: 0x6BC6464 VA: 0x6BCA464
	public int get_SocketId() { }

	[CompilerGenerated]
	// RVA: 0x6BCA46C Offset: 0x6BC646C VA: 0x6BCA46C
	public void set_SocketId(int value) { }

	// RVA: 0x6BC8824 Offset: 0x6BC4824 VA: 0x6BC8824
	public void .ctor(ProtocolType protocolType) { }
}

// Namespace: FalconNet.NETEventDriven
internal class NetCloseConnectionParameter // TypeDefIndex: 24505
{
	// Fields
	[CompilerGenerated]
	private ProtocolType <ProtocolType>k__BackingField; // 0x10
	[CompilerGenerated]
	private IPEndPoint <RemoteIPEndPoint>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsForceDisconnect>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsExternalPush>k__BackingField; // 0x21

	// Properties
	public ProtocolType ProtocolType { get; set; }
	public IPEndPoint RemoteIPEndPoint { get; set; }
	public bool IsForceDisconnect { get; set; }
	public bool IsExternalPush { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BCA474 Offset: 0x6BC6474 VA: 0x6BCA474
	public ProtocolType get_ProtocolType() { }

	[CompilerGenerated]
	// RVA: 0x6BCA47C Offset: 0x6BC647C VA: 0x6BCA47C
	public void set_ProtocolType(ProtocolType value) { }

	[CompilerGenerated]
	// RVA: 0x6BCA484 Offset: 0x6BC6484 VA: 0x6BCA484
	public IPEndPoint get_RemoteIPEndPoint() { }

	[CompilerGenerated]
	// RVA: 0x6BCA48C Offset: 0x6BC648C VA: 0x6BCA48C
	public void set_RemoteIPEndPoint(IPEndPoint value) { }

	[CompilerGenerated]
	// RVA: 0x6BCA494 Offset: 0x6BC6494 VA: 0x6BCA494
	public bool get_IsForceDisconnect() { }

	[CompilerGenerated]
	// RVA: 0x6BCA49C Offset: 0x6BC649C VA: 0x6BCA49C
	public void set_IsForceDisconnect(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6BCA4A8 Offset: 0x6BC64A8 VA: 0x6BCA4A8
	public bool get_IsExternalPush() { }

	[CompilerGenerated]
	// RVA: 0x6BCA4B0 Offset: 0x6BC64B0 VA: 0x6BCA4B0
	public void set_IsExternalPush(bool value) { }

	// RVA: 0x6BCA4BC Offset: 0x6BC64BC VA: 0x6BCA4BC
	public void .ctor(IPEndPoint remoteIPEndPoint, ProtocolType protocolType, bool isForceDisconnect = False, bool isExternalPush = True) { }
}

// Namespace: FalconNet.NETEventDriven
internal class NetCreateConnectionParameter // TypeDefIndex: 24506
{
	// Fields
	[CompilerGenerated]
	private ProtocolType <ProtocolType>k__BackingField; // 0x10
	[CompilerGenerated]
	private IPEndPoint <RemoteIPEndPoint>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsInitiator>k__BackingField; // 0x20

	// Properties
	public ProtocolType ProtocolType { get; set; }
	public IPEndPoint RemoteIPEndPoint { get; set; }
	public bool IsInitiator { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BCA518 Offset: 0x6BC6518 VA: 0x6BCA518
	public ProtocolType get_ProtocolType() { }

	[CompilerGenerated]
	// RVA: 0x6BCA520 Offset: 0x6BC6520 VA: 0x6BCA520
	public void set_ProtocolType(ProtocolType value) { }

	[CompilerGenerated]
	// RVA: 0x6BCA528 Offset: 0x6BC6528 VA: 0x6BCA528
	public IPEndPoint get_RemoteIPEndPoint() { }

	[CompilerGenerated]
	// RVA: 0x6BCA530 Offset: 0x6BC6530 VA: 0x6BCA530
	public void set_RemoteIPEndPoint(IPEndPoint value) { }

	[CompilerGenerated]
	// RVA: 0x6BCA538 Offset: 0x6BC6538 VA: 0x6BCA538
	public bool get_IsInitiator() { }

	[CompilerGenerated]
	// RVA: 0x6BCA540 Offset: 0x6BC6540 VA: 0x6BCA540
	public void set_IsInitiator(bool value) { }

	// RVA: 0x6BCA54C Offset: 0x6BC654C VA: 0x6BCA54C
	public void .ctor(IPEndPoint remoteIPEndPoint, ProtocolType protocolType, bool isInitiator) { }
}

// Namespace: FalconNet.NETEventDriven
internal class NetReplaceConnectionParameter // TypeDefIndex: 24507
{
	// Fields
	[CompilerGenerated]
	private ProtocolType <ProtocolType>k__BackingField; // 0x10
	[CompilerGenerated]
	private IPEndPoint <RemoteIPEndPoint>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsInitiator>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Timeout>k__BackingField; // 0x24

	// Properties
	public ProtocolType ProtocolType { get; set; }
	public IPEndPoint RemoteIPEndPoint { get; set; }
	public bool IsInitiator { get; set; }
	public int Timeout { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BCA59C Offset: 0x6BC659C VA: 0x6BCA59C
	public ProtocolType get_ProtocolType() { }

	[CompilerGenerated]
	// RVA: 0x6BCA5A4 Offset: 0x6BC65A4 VA: 0x6BCA5A4
	public void set_ProtocolType(ProtocolType value) { }

	[CompilerGenerated]
	// RVA: 0x6BCA5AC Offset: 0x6BC65AC VA: 0x6BCA5AC
	public IPEndPoint get_RemoteIPEndPoint() { }

	[CompilerGenerated]
	// RVA: 0x6BCA5B4 Offset: 0x6BC65B4 VA: 0x6BCA5B4
	public void set_RemoteIPEndPoint(IPEndPoint value) { }

	[CompilerGenerated]
	// RVA: 0x6BCA5BC Offset: 0x6BC65BC VA: 0x6BCA5BC
	public bool get_IsInitiator() { }

	[CompilerGenerated]
	// RVA: 0x6BCA5C4 Offset: 0x6BC65C4 VA: 0x6BCA5C4
	public void set_IsInitiator(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6BCA5D0 Offset: 0x6BC65D0 VA: 0x6BCA5D0
	public int get_Timeout() { }

	[CompilerGenerated]
	// RVA: 0x6BCA5D8 Offset: 0x6BC65D8 VA: 0x6BCA5D8
	public void set_Timeout(int value) { }

	// RVA: 0x6BCA5E0 Offset: 0x6BC65E0 VA: 0x6BCA5E0
	public void .ctor(IPEndPoint remoteIPEndPoint, ProtocolType protocolType, bool isInitiator, int timeout = 0) { }
}

// Namespace: FalconNet.NETEventDriven
internal class SocketDisconnect : IRecyclable // TypeDefIndex: 24508
{
	// Fields
	public IPEndPoint IpEndPoint; // 0x10

	// Methods

	// RVA: 0x6BCA638 Offset: 0x6BC6638 VA: 0x6BCA638 Slot: 4
	public void Recycle() { }

	// RVA: 0x6BCA644 Offset: 0x6BC6644 VA: 0x6BCA644
	public void .ctor() { }
}

// Namespace: FalconNet.NETEventDriven
internal class NetErrorOccuredParameter : IRecyclable // TypeDefIndex: 24509
{
	// Fields
	public IPEndPoint IpEndPoint; // 0x10
	public Exception Exception; // 0x18
	public string FucInfo; // 0x20
	public int SocketId; // 0x28

	// Methods

	// RVA: 0x6BCA64C Offset: 0x6BC664C VA: 0x6BCA64C
	public void .ctor(IPEndPoint ipEndPoint, Exception exception) { }

	// RVA: 0x6BCA690 Offset: 0x6BC6690 VA: 0x6BCA690
	public void .ctor(IPEndPoint ipEndPoint, Exception exception, int socketId, string fucInfo) { }

	// RVA: 0x6BCA6F8 Offset: 0x6BC66F8 VA: 0x6BCA6F8 Slot: 4
	public void Recycle() { }
}

// Namespace: FalconNet.NETEventDriven
internal class ExternalDisconnectExtra // TypeDefIndex: 24510
{
	// Fields
	public bool IsForceDisconnect; // 0x10
	public ProtocolType ProtocolType; // 0x14

	// Methods

	// RVA: 0x6BCA720 Offset: 0x6BC6720 VA: 0x6BCA720
	public void .ctor(ProtocolType protocolType, bool isForceDisconnect) { }
}

// Namespace: FalconNet.NETEventDriven
internal class ExternalProcessMetricExtra // TypeDefIndex: 24511
{
	// Fields
	public long TotalMicroseconds; // 0x10
	public int TotalTicks; // 0x18
	public long MaxMicroseconds; // 0x20

	// Methods

	// RVA: 0x6BC9B78 Offset: 0x6BC5B78 VA: 0x6BC9B78
	public void .ctor(long totalMicroSeconds, int totalTicks, long maxMicroseconds) { }
}

// Namespace: FalconNet.NETEventDriven
internal class ExternalEventParameter : IRecyclable // TypeDefIndex: 24512
{
	// Fields
	public IPEndPoint IpEndPoint; // 0x10
	public ushort EventId; // 0x18
	public object Extra; // 0x20
	public string ExtraContext; // 0x28
	public string EventContext; // 0x30
	public string FucInfo; // 0x38

	// Methods

	// RVA: 0x6BCA750 Offset: 0x6BC6750 VA: 0x6BCA750 Slot: 4
	public void Recycle() { }

	// RVA: 0x6BC9B70 Offset: 0x6BC5B70 VA: 0x6BC9B70
	public void .ctor() { }
}

// Namespace: FalconNet.NETEventDriven
internal class UserSendMessageEventParameter // TypeDefIndex: 24513
{
	// Fields
	public IPEndPoint RemoteIPEndPoint; // 0x10
	public ushort MsgId; // 0x18
	public byte[] Msg; // 0x20
	public EChannelType ChannelType; // 0x28

	// Methods

	// RVA: 0x6BCA7D0 Offset: 0x6BC67D0 VA: 0x6BCA7D0
	public void .ctor(IPEndPoint remoteIPEndPoint, ushort msgId, byte[] msg, EChannelType channelType) { }
}

// Namespace: FalconNet.NETEventDriven
internal class ReceiveMsgFromSocket // TypeDefIndex: 24514
{
	// Fields
	public IPEndPoint RemoteIPEndPoint; // 0x10
	public object HeaderData; // 0x18
	public ByteArray Payload; // 0x20
	public long ReceiveTime; // 0x28
	public ProtocolType ProtocolType; // 0x30
	public int MsgSeqId; // 0x34

	// Methods

	// RVA: 0x6BCA830 Offset: 0x6BC6830 VA: 0x6BCA830
	public void .ctor(IPEndPoint remoteIPEndPoint, object headerData, ByteArray payload, long receiveTime, int msgSeqId, ProtocolType protocolType) { }
}

// Namespace: FalconNet.Models
public enum EChannelType // TypeDefIndex: 24515
{
	// Fields
	public byte value__; // 0x0
	public const EChannelType Unreliable = 0;
	public const EChannelType ReliableUnordered = 1;
	public const EChannelType ReliableOrdered = 2;
	public const EChannelType CrazyReliableUnordered = 3;
	public const EChannelType CrazyReliableOrdered = 4;
	public const EChannelType ReliableOrderedCombine = 5;
}

// Namespace: FalconNet.Models
internal class UdpBaseSendMsgData : UdpHeaderData // TypeDefIndex: 24516
{
	// Fields
	internal byte[] Data; // 0x20

	// Methods

	// RVA: 0x6BCA8B0 Offset: 0x6BC68B0 VA: 0x6BCA8B0
	internal void .ctor(ushort msgId, ushort channelType, int seqId, ushort curFragmentId, ushort maxFragmentId, byte[] data) { }

	// RVA: 0x6BCA918 Offset: 0x6BC6918 VA: 0x6BCA918
	internal void .ctor() { }
}

// Namespace: FalconNet.Models
internal class UdpReliableSendMsgData // TypeDefIndex: 24517
{
	// Fields
	internal long LastSendTime; // 0x10
	internal int RetryCount; // 0x18
	internal NetSendParameter SendParameter; // 0x20

	// Methods

	// RVA: 0x6BCA920 Offset: 0x6BC6920 VA: 0x6BCA920
	public void .ctor() { }
}

// Namespace: FalconNet.Models
internal class UdpReceiveMsgData : UdpHeaderData // TypeDefIndex: 24518
{
	// Fields
	internal long ReceiveTime; // 0x20
	internal ByteArray Data; // 0x28

	// Methods

	// RVA: 0x6BCA930 Offset: 0x6BC6930 VA: 0x6BCA930
	internal void .ctor(ushort msgId, ushort channelType, int seqId, ushort curFragmentId, ushort maxFragmentId, ByteArray data) { }

	// RVA: 0x6BCA998 Offset: 0x6BC6998 VA: 0x6BCA998
	internal void .ctor() { }
}

// Namespace: FalconNet.Channel
internal class BaseChannel // TypeDefIndex: 24519
{
	// Fields
	protected readonly byte ChannelType; // 0x10
	protected readonly UdpConnection Connection; // 0x18
	protected IPEndPoint IpEndPoint; // 0x20

	// Methods

	// RVA: 0x6BCA9A0 Offset: 0x6BC69A0 VA: 0x6BCA9A0
	protected void .ctor(EChannelType channelType, UdpConnection connection, IPEndPoint endPoint) { }

	// RVA: 0x6BCA9F4 Offset: 0x6BC69F4 VA: 0x6BCA9F4 Slot: 4
	public virtual void LogicUpdate() { }
}

// Namespace: FalconNet.Channel
internal abstract class BaseSendChannel : BaseChannel // TypeDefIndex: 24520
{
	// Fields
	public bool IsSendEvent; // 0x28

	// Methods

	// RVA: 0x6BCA9F8 Offset: 0x6BC69F8 VA: 0x6BCA9F8 Slot: 5
	public virtual void AddMessage(ushort msgId, IMessage data) { }

	// RVA: 0x6BCA9FC Offset: 0x6BC69FC VA: 0x6BCA9FC Slot: 6
	public virtual void AddMessage(ushort msgId, byte[] data) { }

	// RVA: 0x6BCAA00 Offset: 0x6BC6A00 VA: 0x6BCAA00 Slot: 7
	public virtual void RemoveMessage(int maxSeqId, HashSet<int> missingSeqIds) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void HandlerSendMessage();

	// RVA: 0x6BCAA04 Offset: 0x6BC6A04 VA: 0x6BCAA04
	protected void .ctor(EChannelType channelType, UdpConnection connection, IPEndPoint endPoint) { }
}

// Namespace: FalconNet.Channel
internal abstract class BaseReceiveChannel : BaseChannel // TypeDefIndex: 24521
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SocketReceiveMessage(UdpReceiveMsgData data);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void HandleReceivedMsg();

	// RVA: 0x6BCAA08 Offset: 0x6BC6A08 VA: 0x6BCAA08
	protected void .ctor(EChannelType channelType, UdpConnection connection, IPEndPoint endPoint) { }
}

// Namespace: FalconNet.Channel
internal class CrazyReliableSendChannel : ReliableSendChannel // TypeDefIndex: 24522
{
	// Methods

	// RVA: 0x6BCAA0C Offset: 0x6BC6A0C VA: 0x6BCAA0C Slot: 9
	protected override int GetRetryTime(int retryCount) { }

	// RVA: 0x6BCAA38 Offset: 0x6BC6A38 VA: 0x6BCAA38
	public void .ctor(EChannelType channelType, UdpConnection connection, IPEndPoint endPoint, Func<int> getAvgRtt) { }
}

// Namespace: FalconNet.Channel
internal class ReliableCombineSendChannel : BaseSendChannel // TypeDefIndex: 24523
{
	// Fields
	private const int RetryInterval = 300;
	private const int FullCheckInterval = 200;
	private int nextSeq; // 0x2C
	private int currentMaxSeq; // 0x30
	private long lastFullCheckTime; // 0x38
	private readonly Dictionary<int, UdpReliableSendMsgData> pendingSendMessages; // 0x40

	// Methods

	// RVA: 0x6BCAAFC Offset: 0x6BC6AFC VA: 0x6BCAAFC
	private int GetSeqId() { }

	// RVA: 0x6BCAB18 Offset: 0x6BC6B18 VA: 0x6BCAB18 Slot: 5
	public override void AddMessage(ushort msgId, IMessage data) { }

	// RVA: 0x6BCABE8 Offset: 0x6BC6BE8 VA: 0x6BCABE8 Slot: 6
	public override void AddMessage(ushort msgId, byte[] data) { }

	// RVA: 0x6BCB0B0 Offset: 0x6BC70B0 VA: 0x6BCB0B0 Slot: 4
	public override void LogicUpdate() { }

	// RVA: 0x6BCB504 Offset: 0x6BC7504 VA: 0x6BCB504 Slot: 7
	public override void RemoveMessage(int maxSeqId, HashSet<int> missingSeqIds) { }

	// RVA: 0x6BCB708 Offset: 0x6BC7708 VA: 0x6BCB708 Slot: 8
	public override void HandlerSendMessage() { }

	// RVA: 0x6BCBDA8 Offset: 0x6BC7DA8 VA: 0x6BCBDA8
	public void .ctor(EChannelType channelType, UdpConnection connection, IPEndPoint endPoint) { }
}

// Namespace: FalconNet.Channel
internal class ReliableSendChannel : BaseSendChannel // TypeDefIndex: 24524
{
	// Fields
	private int nextSeq; // 0x2C
	internal readonly Dictionary<int, UdpReliableSendMsgData> pendingSendMessages; // 0x30
	protected readonly Func<int> GetAvgRtt; // 0x38
	private long lastFullCheckTime; // 0x40
	private const int FullCheckInterval = 200;

	// Methods

	// RVA: 0x6BCBE4C Offset: 0x6BC7E4C VA: 0x6BCBE4C
	private int GetSeqId() { }

	// RVA: 0x6BCBE68 Offset: 0x6BC7E68 VA: 0x6BCBE68 Slot: 5
	public override void AddMessage(ushort msgId, IMessage data) { }

	// RVA: 0x6BCBF38 Offset: 0x6BC7F38 VA: 0x6BCBF38 Slot: 6
	public override void AddMessage(ushort msgId, byte[] data) { }

	// RVA: 0x6BCC40C Offset: 0x6BC840C VA: 0x6BCC40C Slot: 4
	public override void LogicUpdate() { }

	// RVA: 0x6BCC8E4 Offset: 0x6BC88E4 VA: 0x6BCC8E4 Slot: 7
	public override void RemoveMessage(int maxSeqId, HashSet<int> missingSeqIds) { }

	// RVA: 0x6BCCAE8 Offset: 0x6BC8AE8 VA: 0x6BCCAE8 Slot: 8
	public override void HandlerSendMessage() { }

	// RVA: 0x6BCC5C4 Offset: 0x6BC85C4 VA: 0x6BCC5C4
	private void PushSendMessageEvent(int seqId, UdpReliableSendMsgData msgData, long curTime) { }

	// RVA: 0x6BCCC90 Offset: 0x6BC8C90 VA: 0x6BCCC90 Slot: 9
	protected virtual int GetRetryTime(int retryCount) { }

	// RVA: 0x6BCAA3C Offset: 0x6BC6A3C VA: 0x6BCAA3C
	public void .ctor(EChannelType channelType, UdpConnection connection, IPEndPoint endPoint, Func<int> getAvgRtt) { }
}

// Namespace: FalconNet.Channel
internal class UnreliableSendChannel : BaseSendChannel // TypeDefIndex: 24525
{
	// Fields
	private readonly Queue<UdpBaseSendMsgData> pendingSendMessages; // 0x30
	private int nextSeq; // 0x38

	// Methods

	// RVA: 0x6BCCD34 Offset: 0x6BC8D34 VA: 0x6BCCD34
	private int GetSeqId() { }

	// RVA: 0x6BCCD40 Offset: 0x6BC8D40 VA: 0x6BCCD40 Slot: 5
	public override void AddMessage(ushort msgId, IMessage data) { }

	// RVA: 0x6BCCE10 Offset: 0x6BC8E10 VA: 0x6BCCE10 Slot: 6
	public override void AddMessage(ushort msgId, byte[] data) { }

	// RVA: 0x6BCD0B0 Offset: 0x6BC90B0 VA: 0x6BCD0B0 Slot: 8
	public override void HandlerSendMessage() { }

	// RVA: 0x6BCD2BC Offset: 0x6BC92BC VA: 0x6BCD2BC Slot: 4
	public override void LogicUpdate() { }

	// RVA: 0x6BCD2C0 Offset: 0x6BC92C0 VA: 0x6BCD2C0
	public void .ctor(EChannelType channelType, UdpConnection connection, IPEndPoint endPoint) { }
}

// Namespace: FalconNet.Channel.ReceiveChannel
internal abstract class BaseReliableReceiveChannel : BaseReceiveChannel // TypeDefIndex: 24526
{
	// Fields
	private long lastSendAckTime; // 0x28
	internal int maxReceiveSeqId; // 0x30
	internal readonly HashSet<int> missedSeqIds; // 0x38
	protected readonly List<int> RemoveKeys; // 0x40
	private int hasNewMsg; // 0x48
	private readonly Func<int> GetAvgRtt; // 0x50
	protected internal readonly Dictionary<int, UdpReceiveMsgData> PendingReceiveMessages; // 0x58
	protected bool IsSendEvent; // 0x60

	// Methods

	// RVA: 0x6BCD364 Offset: 0x6BC9364 VA: 0x6BCD364 Slot: 5
	public override void SocketReceiveMessage(UdpReceiveMsgData msgData) { }

	// RVA: 0x6BCD5F4 Offset: 0x6BC95F4 VA: 0x6BCD5F4
	private bool CheckAndAddMissedSeqId(int seqId) { }

	// RVA: 0x6BCD710 Offset: 0x6BC9710 VA: 0x6BCD710
	protected void TrySendAck() { }

	// RVA: 0x6BCD80C Offset: 0x6BC980C VA: 0x6BCD80C
	private ReliableAck GenerateAck() { }

	// RVA: 0x6BCD900 Offset: 0x6BC9900 VA: 0x6BCD900
	protected void .ctor(EChannelType channelType, UdpConnection connection, IPEndPoint endPoint, Func<int> getAvgRtt) { }
}

// Namespace: FalconNet.Channel.ReceiveChannel
internal class ReliableOrderedReceiveChannel : BaseReliableReceiveChannel // TypeDefIndex: 24527
{
	// Fields
	private int maxContinuousSeqId; // 0x64

	// Methods

	// RVA: 0x6BCDA60 Offset: 0x6BC9A60 VA: 0x6BCDA60 Slot: 6
	public override void HandleReceivedMsg() { }

	// RVA: 0x6BCE1F4 Offset: 0x6BCA1F4 VA: 0x6BCE1F4 Slot: 4
	public override void LogicUpdate() { }

	// RVA: 0x6BCE1F8 Offset: 0x6BCA1F8 VA: 0x6BCE1F8
	public void .ctor(EChannelType channelType, UdpConnection connection, IPEndPoint endPoint, Func<int> getAvgRtt) { }
}

// Namespace: FalconNet.Channel.ReceiveChannel
internal class ReliableUnorderedReceiveChannel : BaseReliableReceiveChannel // TypeDefIndex: 24528
{
	// Methods

	// RVA: 0x6BCE1FC Offset: 0x6BCA1FC VA: 0x6BCE1FC Slot: 6
	public override void HandleReceivedMsg() { }

	// RVA: 0x6BCE544 Offset: 0x6BCA544 VA: 0x6BCE544 Slot: 4
	public override void LogicUpdate() { }

	// RVA: 0x6BCE548 Offset: 0x6BCA548 VA: 0x6BCE548
	public void .ctor(EChannelType channelType, UdpConnection connection, IPEndPoint endPoint, Func<int> getAvgRtt) { }
}

// Namespace: FalconNet.Channel.ReceiveChannel
internal class UnreliableReceiveChannel : BaseReceiveChannel // TypeDefIndex: 24529
{
	// Fields
	private readonly Queue<UdpReceiveMsgData> pendingReceiveMessages; // 0x28
	protected bool IsSendEvent; // 0x30

	// Methods

	// RVA: 0x6BCE54C Offset: 0x6BCA54C VA: 0x6BCE54C Slot: 5
	public override void SocketReceiveMessage(UdpReceiveMsgData msgData) { }

	// RVA: 0x6BCE74C Offset: 0x6BCA74C VA: 0x6BCE74C Slot: 6
	public override void HandleReceivedMsg() { }

	// RVA: 0x6BCE7E8 Offset: 0x6BCA7E8 VA: 0x6BCE7E8 Slot: 4
	public override void LogicUpdate() { }

	// RVA: 0x6BCE7EC Offset: 0x6BCA7EC VA: 0x6BCE7EC
	public void .ctor(EChannelType channelType, UdpConnection connection, IPEndPoint endPoint) { }
}

// Namespace: FalconNet.Tcp
internal class TcpConnection : NetConnection // TypeDefIndex: 24530
{
	// Fields
	private int nextSeq; // 0x40
	private readonly Queue<TcpReceiveMsgData> receiveMsgs; // 0x48
	private readonly Queue<TcpSendMsgData> sendMsgs; // 0x50
	private long remoteTickTime; // 0x58
	private long lastSendHeartbeatTime; // 0x60
	private ConnectionState state; // 0x68
	private bool _isSendReceiveTriggerEvent; // 0x69
	private bool _isSendSendTriggerEvent; // 0x6A

	// Properties
	public override ConnectionState ConnState { get; }
	public override ProtocolType ProtocolType { get; }

	// Methods

	// RVA: 0x6BCE890 Offset: 0x6BCA890 VA: 0x6BCE890
	public void .ctor(bool isInitiator, IPEndPoint endPoint, IProtoParse internalProtoParse, IProtoParse externalProtoParse) { }

	// RVA: 0x6BCEAA0 Offset: 0x6BCAAA0 VA: 0x6BCEAA0
	private int GetSeqId() { }

	// RVA: 0x6BCEAAC Offset: 0x6BCAAAC VA: 0x6BCEAAC Slot: 5
	public override ConnectionState get_ConnState() { }

	// RVA: 0x6BCEAB4 Offset: 0x6BCAAB4 VA: 0x6BCEAB4 Slot: 4
	public override ProtocolType get_ProtocolType() { }

	// RVA: 0x6BCEABC Offset: 0x6BCAABC VA: 0x6BCEABC Slot: 6
	public override void UpdateLogic() { }

	// RVA: 0x6BCEC88 Offset: 0x6BCAC88 VA: 0x6BCEC88
	public void OnSendMessage(ushort msgId, IMessage data, EChannelType channelType = 0) { }

	// RVA: 0x6BCED60 Offset: 0x6BCAD60 VA: 0x6BCED60 Slot: 7
	public override void OnSendMessage(ushort msgId, byte[] payload, EChannelType channelType = 0) { }

	// RVA: 0x6BCEFEC Offset: 0x6BCAFEC VA: 0x6BCEFEC Slot: 8
	public override void OnReceiveMessage(object headerData, ByteArray payload, long receiveTime, IEvent evt) { }

	// RVA: 0x6BCF3A4 Offset: 0x6BCB3A4 VA: 0x6BCF3A4 Slot: 9
	public override void HandlePendingReceiveMessage(byte channelType, IEvent evt) { }

	// RVA: 0x6BCF6F4 Offset: 0x6BCB6F4 VA: 0x6BCF6F4 Slot: 10
	public override void HandlePendingSendMessage(byte channelType, IEvent evt) { }

	// RVA: 0x6BCF494 Offset: 0x6BCB494 VA: 0x6BCF494
	private void HandleReceivedMsg(TcpReceiveMsgData msgData) { }

	// RVA: 0x6BCF8F0 Offset: 0x6BCB8F0 VA: 0x6BCF8F0
	private void HandleReceivedInternalMsg(TcpReceiveMsgData msgData) { }
}

// Namespace: FalconNet.Tcp.Models
internal class TcpReceiveMsgData // TypeDefIndex: 24531
{
	// Fields
	internal ushort MsgId; // 0x10
	public long ReceiveTime; // 0x18
	internal ushort SeqId; // 0x20
	public ByteArray Data; // 0x28

	// Methods

	// RVA: 0x6BCF39C Offset: 0x6BCB39C VA: 0x6BCF39C
	public void .ctor() { }
}

// Namespace: FalconNet.Tcp.Models
internal class TcpSendMsgData // TypeDefIndex: 24532
{
	// Fields
	internal ushort MsgId; // 0x10
	internal int SeqId; // 0x14
	public byte[] Data; // 0x18

	// Methods

	// RVA: 0x6BCEFE4 Offset: 0x6BCAFE4 VA: 0x6BCEFE4
	public void .ctor() { }
}

// Namespace: FalconNet.FrameSyncManager
internal interface IFrameSyncManager // TypeDefIndex: 24533
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Disconnect();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Dispose();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void ErrorHandlerRegister(Func<NetErrorCode> handler);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void ProtoRegister(ushort msgId, Func<IMessage> messageFactory);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void RegisterByType(Type classType);
}

// Namespace: FalconNet.FrameSyncManager
internal interface IServerFrameSyncManager : IFrameSyncManager // TypeDefIndex: 24534
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Bind(int port);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void AddRoom(string roomId, List<string> playerIds);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void RemoveRoom(string roomId);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void AddFrameData(string roomId, Frame frame);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnPlayerLogin(string playerId, IPEndPoint remoteEndpoint);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SendMessageByPlayer(string playerId, ushort msgId, IMessage data, EChannelType reliableType);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SendMessageByRoom(string roomId, ushort msgId, IMessage data, EChannelType reliableType);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void HandleFrameChasing(string playerId, string roomId, uint startFrameNumber, uint endFrameNumber);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Update();
}

// Namespace: FalconNet.FrameSyncManager
internal interface IClientFrameSyncManager : IFrameSyncManager // TypeDefIndex: 24535
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Connect(string ip, int port);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SendMessage(ushort msgId, IMessage data, EChannelType reliableType);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract List<Frame> Update();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void DoFrameChasing(uint startFrameNumber, uint endFrameNumber);
}

// Namespace: FalconNet.FrameSyncManager.Models
internal class Frame // TypeDefIndex: 24536
{
	// Fields
	public uint FrameNumber; // 0x10
	public List<Event<EventData>> Events; // 0x18

	// Methods

	// RVA: 0x6BCFBAC Offset: 0x6BCBBAC VA: 0x6BCFBAC
	public void .ctor() { }
}

// Namespace: FalconNet.FrameSyncManager.Models
internal abstract class EventData // TypeDefIndex: 24537
{
	// Methods

	// RVA: 0x6BCFC34 Offset: 0x6BCBC34 VA: 0x6BCFC34
	protected void .ctor() { }
}

// Namespace: FalconNet.FrameSyncManager.Models
internal class Event<T> // TypeDefIndex: 24538
{
	// Fields
	public int PlayerId; // 0x0
	public int EventId; // 0x0
	public T EventData; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6319E98 Offset: 0x6315E98 VA: 0x6319E98
	|-Event<object>..ctor
	*/
}

// Namespace: FalconNet.FrameSyncManager.Models
internal class FrameChasing // TypeDefIndex: 24539
{
	// Fields
	public List<MergedFrame> MergedFrames; // 0x10

	// Methods

	// RVA: 0x6BCFC3C Offset: 0x6BCBC3C VA: 0x6BCFC3C
	public void .ctor() { }
}

// Namespace: FalconNet.FrameSyncManager.Models
internal class MergedFrame // TypeDefIndex: 24540
{
	// Fields
	public uint StartFrameNumber; // 0x10
	public uint EndFrameNumber; // 0x14
	public List<Event<EventData>> Events; // 0x18

	// Methods

	// RVA: 0x6BCFCC4 Offset: 0x6BCBCC4 VA: 0x6BCFCC4
	public void .ctor() { }
}

// Namespace: FalconNet.FrameSyncManager.Models
internal class PlayerMoveEventData : EventData // TypeDefIndex: 24541
{
	// Fields
	[CompilerGenerated]
	private int <X>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <Y>k__BackingField; // 0x14

	// Properties
	public int X { get; set; }
	public int Y { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BCFD4C Offset: 0x6BCBD4C VA: 0x6BCFD4C
	public int get_X() { }

	[CompilerGenerated]
	// RVA: 0x6BCFD54 Offset: 0x6BCBD54 VA: 0x6BCFD54
	public void set_X(int value) { }

	[CompilerGenerated]
	// RVA: 0x6BCFD5C Offset: 0x6BCBD5C VA: 0x6BCFD5C
	public int get_Y() { }

	[CompilerGenerated]
	// RVA: 0x6BCFD64 Offset: 0x6BCBD64 VA: 0x6BCFD64
	public void set_Y(int value) { }

	// RVA: 0x6BCFD6C Offset: 0x6BCBD6C VA: 0x6BCFD6C
	public void .ctor() { }
}

// Namespace: FalconNet.FrameSyncManager.Models
internal class FrameExample // TypeDefIndex: 24542
{
	// Methods

	// RVA: 0x6BCFD74 Offset: 0x6BCBD74 VA: 0x6BCFD74
	public void Example() { }

	// RVA: 0x6BCFED8 Offset: 0x6BCBED8 VA: 0x6BCFED8
	public void .ctor() { }
}

// Namespace: FalconNet.FrameSyncManager.Models
internal enum EPlayerState // TypeDefIndex: 24543
{
	// Fields
	public int value__; // 0x0
	public const EPlayerState Disconnect = 0;
	public const EPlayerState SyncTime = 1;
	public const EPlayerState Active = 2;
}

// Namespace: FalconNet.FrameSyncManager.Models
internal enum ERoomState // TypeDefIndex: 24544
{
	// Fields
	public int value__; // 0x0
	public const ERoomState NoActive = 0;
	public const ERoomState ResourceLoading = 1;
	public const ERoomState GameRunning = 2;
	public const ERoomState GameOver = 3;
}

// Namespace: FalconNet.FrameSyncManager.Models
internal class Room // TypeDefIndex: 24545
{
	// Fields
	[CompilerGenerated]
	private string <RoomId>k__BackingField; // 0x10
	public ERoomState RoomState; // 0x18
	[CompilerGenerated]
	private readonly Dictionary<string, Player> <Players>k__BackingField; // 0x20
	public List<Frame> Frames; // 0x28

	// Properties
	public string RoomId { get; set; }
	public Dictionary<string, Player> Players { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BCFEE0 Offset: 0x6BCBEE0 VA: 0x6BCFEE0
	public string get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x6BCFEE8 Offset: 0x6BCBEE8 VA: 0x6BCFEE8
	private void set_RoomId(string value) { }

	[CompilerGenerated]
	// RVA: 0x6BCFEF0 Offset: 0x6BCBEF0 VA: 0x6BCFEF0
	public Dictionary<string, Player> get_Players() { }

	// RVA: 0x6BCFEF8 Offset: 0x6BCBEF8 VA: 0x6BCFEF8
	public void .ctor(string roomId, List<string> playerIds) { }
}

// Namespace: FalconNet.FrameSyncManager.Models
internal class Player // TypeDefIndex: 24546
{
	// Fields
	public string PlayerId; // 0x10
	public EPlayerState PlayerState; // 0x18

	// Methods

	// RVA: 0x6BD0180 Offset: 0x6BCC180 VA: 0x6BD0180
	public void .ctor() { }
}

// Namespace: FalconNet.NetCore.Statistics
public class DoubleBufferedQueue<T> // TypeDefIndex: 24547
{
	// Fields
	private readonly ConcurrentQueue<T> _activeQueue; // 0x0
	private readonly ConcurrentQueue<T> _standbyQueue; // 0x0
	private ConcurrentQueue<T> _currentQueue; // 0x0
	private ConcurrentQueue<T> _previousQueue; // 0x0
	private readonly object _switchLock; // 0x0
	private int _drainInProgress; // 0x0
	private int _raceConditionDetected; // 0x0

	// Properties
	public int Count { get; }
	public bool IsEmpty { get; }
	public int RaceConditionDetected { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601B3AC Offset: 0x60173AC VA: 0x601B3AC
	|-DoubleBufferedQueue<object>..ctor
	|
	|-RVA: 0x601B8F4 Offset: 0x60178F4 VA: 0x601B8F4
	|-DoubleBufferedQueue<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void EnqueueItem(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601B4D0 Offset: 0x60174D0 VA: 0x601B4D0
	|-DoubleBufferedQueue<object>.EnqueueItem
	|
	|-RVA: 0x601BA20 Offset: 0x6017A20 VA: 0x601BA20
	|-DoubleBufferedQueue<__Il2CppFullySharedGenericType>.EnqueueItem
	*/

	// RVA: -1 Offset: -1
	public List<T> DrainQueue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601B554 Offset: 0x6017554 VA: 0x601B554
	|-DoubleBufferedQueue<object>.DrainQueue
	|
	|-RVA: 0x601BB3C Offset: 0x6017B3C VA: 0x601BB3C
	|-DoubleBufferedQueue<__Il2CppFullySharedGenericType>.DrainQueue
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601B87C Offset: 0x601787C VA: 0x601B87C
	|-DoubleBufferedQueue<object>.get_Count
	|
	|-RVA: 0x601BEE0 Offset: 0x6017EE0 VA: 0x601BEE0
	|-DoubleBufferedQueue<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601B8B4 Offset: 0x60178B4 VA: 0x601B8B4
	|-DoubleBufferedQueue<object>.get_IsEmpty
	|
	|-RVA: 0x601BF1C Offset: 0x6017F1C VA: 0x601BF1C
	|-DoubleBufferedQueue<__Il2CppFullySharedGenericType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	public int get_RaceConditionDetected() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601B8EC Offset: 0x60178EC VA: 0x601B8EC
	|-DoubleBufferedQueue<object>.get_RaceConditionDetected
	|
	|-RVA: 0x601BF58 Offset: 0x6017F58 VA: 0x601BF58
	|-DoubleBufferedQueue<__Il2CppFullySharedGenericType>.get_RaceConditionDetected
	*/
}

// Namespace: FalconNet.NetCore.Statistics.Models
public struct MetricSnapshot // TypeDefIndex: 24548
{
	// Fields
	public ushort Ema; // 0x0
	public ushort SampleCount; // 0x2
	public ushort MaxValue; // 0x4
	private const int MaxSamples = 4096;
	private ushort[] _buffer; // 0x8
	private bool _initialized; // 0x10

	// Methods

	// RVA: 0x6BD0188 Offset: 0x6BCC188 VA: 0x6BD0188
	public void Init() { }

	// RVA: 0x6BD0284 Offset: 0x6BCC284 VA: 0x6BD0284
	public void AddSample(ushort value) { }

	// RVA: 0x6BD037C Offset: 0x6BCC37C VA: 0x6BD037C
	public ushort GetPercentile(double percentile) { }

	// RVA: 0x6BD0620 Offset: 0x6BCC620 VA: 0x6BD0620
	public ushort GetP95() { }

	// RVA: 0x6BD062C Offset: 0x6BCC62C VA: 0x6BD062C
	public ushort GetP99() { }

	// RVA: 0x6BD0638 Offset: 0x6BCC638 VA: 0x6BD0638
	public void Reset() { }

	// RVA: 0x6BD064C Offset: 0x6BCC64C VA: 0x6BD064C
	public void Dispose() { }
}

// Namespace: FalconNet.NetCore.Statistics.Models
public struct CountSnapshot // TypeDefIndex: 24549
{
	// Fields
	public ushort SentPackets; // 0x0
	public ushort ReceivedPackets; // 0x2
	public ushort SentBytes; // 0x4
	public ushort ReceivedBytes; // 0x6
	public ushort AckMissPackets; // 0x8
}

// Namespace: FalconNet.NetCore.Statistics.Models
public struct NetErrorFlags // TypeDefIndex: 24550
{
	// Fields
	public ushort BitField; // 0x0

	// Methods

	// RVA: 0x6BD0754 Offset: 0x6BCC754 VA: 0x6BD0754
	public void Mark(NetErrorType type) { }

	// RVA: 0x6BD076C Offset: 0x6BCC76C VA: 0x6BD076C
	public bool Has(NetErrorType type) { }

	// RVA: 0x6BD077C Offset: 0x6BCC77C VA: 0x6BD077C
	public void Clear(NetErrorType type) { }

	// RVA: 0x6BD0794 Offset: 0x6BCC794 VA: 0x6BD0794
	public bool HasAny() { }

	// RVA: 0x6BD07A4 Offset: 0x6BCC7A4 VA: 0x6BD07A4
	public void Reset() { }
}

// Namespace: FalconNet.NetCore.Statistics.Models
public enum NetErrorType // TypeDefIndex: 24551
{
	// Fields
	public byte value__; // 0x0
	public const NetErrorType UdpErrorState = 0;
	public const NetErrorType TcpErrorState = 1;
	public const NetErrorType UdpInitializingState = 2;
	public const NetErrorType TcpInitializingState = 3;
	public const NetErrorType UdpRunningState = 4;
	public const NetErrorType TcpRunningState = 5;
}

// Namespace: FalconNet.NetCore.Statistics.Models
public enum CountType // TypeDefIndex: 24552
{
	// Fields
	public int value__; // 0x0
	public const CountType SentPackets = 0;
	public const CountType ReceivedPackets = 1;
	public const CountType SentBytes = 2;
	public const CountType ReceivedBytes = 3;
	public const CountType AckMissPackets = 4;
}

// Namespace: FalconNet.NetCore.Statistics.Models
public class SnapshotMetric // TypeDefIndex: 24553
{
	// Fields
	[CompilerGenerated]
	private ushort <RttEma>k__BackingField; // 0x10
	[CompilerGenerated]
	private ushort <RttMaxValue>k__BackingField; // 0x12
	[CompilerGenerated]
	private ushort <RttP95>k__BackingField; // 0x14
	[CompilerGenerated]
	private ushort <RttP99>k__BackingField; // 0x16
	[CompilerGenerated]
	private ushort <EventEma>k__BackingField; // 0x18
	[CompilerGenerated]
	private ushort <EventMaxValue>k__BackingField; // 0x1A
	[CompilerGenerated]
	private ushort <EventP95>k__BackingField; // 0x1C
	[CompilerGenerated]
	private ushort <EventP99>k__BackingField; // 0x1E
	[CompilerGenerated]
	private ushort <SentPackets>k__BackingField; // 0x20
	[CompilerGenerated]
	private ushort <ReceivedPackets>k__BackingField; // 0x22
	[CompilerGenerated]
	private ushort <SentBytes>k__BackingField; // 0x24
	[CompilerGenerated]
	private ushort <ReceivedBytes>k__BackingField; // 0x26
	[CompilerGenerated]
	private bool <NetErrorUdpErrorState>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <NetErrorTcpErrorState>k__BackingField; // 0x29
	[CompilerGenerated]
	private bool <NetErrorUdpInitializingState>k__BackingField; // 0x2A
	[CompilerGenerated]
	private bool <NetErrorTcpInitializingState>k__BackingField; // 0x2B
	[CompilerGenerated]
	private bool <NetErrorUdpRunningState>k__BackingField; // 0x2C
	[CompilerGenerated]
	private bool <NetErrorTcpRunningState>k__BackingField; // 0x2D
	[CompilerGenerated]
	private float <LossWindowRate>k__BackingField; // 0x30
	[CompilerGenerated]
	private ushort <NetType>k__BackingField; // 0x34
	[CompilerGenerated]
	private bool <Gc0Flag>k__BackingField; // 0x36
	[CompilerGenerated]
	private bool <Gc1Flag>k__BackingField; // 0x37
	[CompilerGenerated]
	private bool <Gc2Flag>k__BackingField; // 0x38
	[CompilerGenerated]
	private uint <EventBitmap>k__BackingField; // 0x3C
	[CompilerGenerated]
	private uint <EventNumber>k__BackingField; // 0x40

	// Properties
	public ushort RttEma { get; set; }
	public ushort RttMaxValue { get; set; }
	public ushort RttP95 { get; set; }
	public ushort RttP99 { get; set; }
	public ushort EventEma { get; set; }
	public ushort EventMaxValue { get; set; }
	public ushort EventP95 { get; set; }
	public ushort EventP99 { get; set; }
	public ushort SentPackets { get; set; }
	public ushort ReceivedPackets { get; set; }
	public ushort SentBytes { get; set; }
	public ushort ReceivedBytes { get; set; }
	public bool NetErrorUdpErrorState { get; set; }
	public bool NetErrorTcpErrorState { get; set; }
	public bool NetErrorUdpInitializingState { get; set; }
	public bool NetErrorTcpInitializingState { get; set; }
	public bool NetErrorUdpRunningState { get; set; }
	public bool NetErrorTcpRunningState { get; set; }
	public float LossWindowRate { get; set; }
	public ushort NetType { get; set; }
	public bool Gc0Flag { get; set; }
	public bool Gc1Flag { get; set; }
	public bool Gc2Flag { get; set; }
	public uint EventBitmap { get; set; }
	public uint EventNumber { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BD07AC Offset: 0x6BCC7AC VA: 0x6BD07AC
	public ushort get_RttEma() { }

	[CompilerGenerated]
	// RVA: 0x6BD07B4 Offset: 0x6BCC7B4 VA: 0x6BD07B4
	public void set_RttEma(ushort value) { }

	[CompilerGenerated]
	// RVA: 0x6BD07BC Offset: 0x6BCC7BC VA: 0x6BD07BC
	public ushort get_RttMaxValue() { }

	[CompilerGenerated]
	// RVA: 0x6BD07C4 Offset: 0x6BCC7C4 VA: 0x6BD07C4
	public void set_RttMaxValue(ushort value) { }

	[CompilerGenerated]
	// RVA: 0x6BD07CC Offset: 0x6BCC7CC VA: 0x6BD07CC
	public ushort get_RttP95() { }

	[CompilerGenerated]
	// RVA: 0x6BD07D4 Offset: 0x6BCC7D4 VA: 0x6BD07D4
	public void set_RttP95(ushort value) { }

	[CompilerGenerated]
	// RVA: 0x6BD07DC Offset: 0x6BCC7DC VA: 0x6BD07DC
	public ushort get_RttP99() { }

	[CompilerGenerated]
	// RVA: 0x6BD07E4 Offset: 0x6BCC7E4 VA: 0x6BD07E4
	public void set_RttP99(ushort value) { }

	[CompilerGenerated]
	// RVA: 0x6BD07EC Offset: 0x6BCC7EC VA: 0x6BD07EC
	public ushort get_EventEma() { }

	[CompilerGenerated]
	// RVA: 0x6BD07F4 Offset: 0x6BCC7F4 VA: 0x6BD07F4
	public void set_EventEma(ushort value) { }

	[CompilerGenerated]
	// RVA: 0x6BD07FC Offset: 0x6BCC7FC VA: 0x6BD07FC
	public ushort get_EventMaxValue() { }

	[CompilerGenerated]
	// RVA: 0x6BD0804 Offset: 0x6BCC804 VA: 0x6BD0804
	public void set_EventMaxValue(ushort value) { }

	[CompilerGenerated]
	// RVA: 0x6BD080C Offset: 0x6BCC80C VA: 0x6BD080C
	public ushort get_EventP95() { }

	[CompilerGenerated]
	// RVA: 0x6BD0814 Offset: 0x6BCC814 VA: 0x6BD0814
	public void set_EventP95(ushort value) { }

	[CompilerGenerated]
	// RVA: 0x6BD081C Offset: 0x6BCC81C VA: 0x6BD081C
	public ushort get_EventP99() { }

	[CompilerGenerated]
	// RVA: 0x6BD0824 Offset: 0x6BCC824 VA: 0x6BD0824
	public void set_EventP99(ushort value) { }

	[CompilerGenerated]
	// RVA: 0x6BD082C Offset: 0x6BCC82C VA: 0x6BD082C
	public ushort get_SentPackets() { }

	[CompilerGenerated]
	// RVA: 0x6BD0834 Offset: 0x6BCC834 VA: 0x6BD0834
	public void set_SentPackets(ushort value) { }

	[CompilerGenerated]
	// RVA: 0x6BD083C Offset: 0x6BCC83C VA: 0x6BD083C
	public ushort get_ReceivedPackets() { }

	[CompilerGenerated]
	// RVA: 0x6BD0844 Offset: 0x6BCC844 VA: 0x6BD0844
	public void set_ReceivedPackets(ushort value) { }

	[CompilerGenerated]
	// RVA: 0x6BD084C Offset: 0x6BCC84C VA: 0x6BD084C
	public ushort get_SentBytes() { }

	[CompilerGenerated]
	// RVA: 0x6BD0854 Offset: 0x6BCC854 VA: 0x6BD0854
	public void set_SentBytes(ushort value) { }

	[CompilerGenerated]
	// RVA: 0x6BD085C Offset: 0x6BCC85C VA: 0x6BD085C
	public ushort get_ReceivedBytes() { }

	[CompilerGenerated]
	// RVA: 0x6BD0864 Offset: 0x6BCC864 VA: 0x6BD0864
	public void set_ReceivedBytes(ushort value) { }

	[CompilerGenerated]
	// RVA: 0x6BD086C Offset: 0x6BCC86C VA: 0x6BD086C
	public bool get_NetErrorUdpErrorState() { }

	[CompilerGenerated]
	// RVA: 0x6BD0874 Offset: 0x6BCC874 VA: 0x6BD0874
	public void set_NetErrorUdpErrorState(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6BD0880 Offset: 0x6BCC880 VA: 0x6BD0880
	public bool get_NetErrorTcpErrorState() { }

	[CompilerGenerated]
	// RVA: 0x6BD0888 Offset: 0x6BCC888 VA: 0x6BD0888
	public void set_NetErrorTcpErrorState(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6BD0894 Offset: 0x6BCC894 VA: 0x6BD0894
	public bool get_NetErrorUdpInitializingState() { }

	[CompilerGenerated]
	// RVA: 0x6BD089C Offset: 0x6BCC89C VA: 0x6BD089C
	public void set_NetErrorUdpInitializingState(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6BD08A8 Offset: 0x6BCC8A8 VA: 0x6BD08A8
	public bool get_NetErrorTcpInitializingState() { }

	[CompilerGenerated]
	// RVA: 0x6BD08B0 Offset: 0x6BCC8B0 VA: 0x6BD08B0
	public void set_NetErrorTcpInitializingState(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6BD08BC Offset: 0x6BCC8BC VA: 0x6BD08BC
	public bool get_NetErrorUdpRunningState() { }

	[CompilerGenerated]
	// RVA: 0x6BD08C4 Offset: 0x6BCC8C4 VA: 0x6BD08C4
	public void set_NetErrorUdpRunningState(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6BD08D0 Offset: 0x6BCC8D0 VA: 0x6BD08D0
	public bool get_NetErrorTcpRunningState() { }

	[CompilerGenerated]
	// RVA: 0x6BD08D8 Offset: 0x6BCC8D8 VA: 0x6BD08D8
	public void set_NetErrorTcpRunningState(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6BD08E4 Offset: 0x6BCC8E4 VA: 0x6BD08E4
	public float get_LossWindowRate() { }

	[CompilerGenerated]
	// RVA: 0x6BD08EC Offset: 0x6BCC8EC VA: 0x6BD08EC
	public void set_LossWindowRate(float value) { }

	[CompilerGenerated]
	// RVA: 0x6BD08F4 Offset: 0x6BCC8F4 VA: 0x6BD08F4
	public ushort get_NetType() { }

	[CompilerGenerated]
	// RVA: 0x6BD08FC Offset: 0x6BCC8FC VA: 0x6BD08FC
	public void set_NetType(ushort value) { }

	[CompilerGenerated]
	// RVA: 0x6BD0904 Offset: 0x6BCC904 VA: 0x6BD0904
	public bool get_Gc0Flag() { }

	[CompilerGenerated]
	// RVA: 0x6BD090C Offset: 0x6BCC90C VA: 0x6BD090C
	public void set_Gc0Flag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6BD0918 Offset: 0x6BCC918 VA: 0x6BD0918
	public bool get_Gc1Flag() { }

	[CompilerGenerated]
	// RVA: 0x6BD0920 Offset: 0x6BCC920 VA: 0x6BD0920
	public void set_Gc1Flag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6BD092C Offset: 0x6BCC92C VA: 0x6BD092C
	public bool get_Gc2Flag() { }

	[CompilerGenerated]
	// RVA: 0x6BD0934 Offset: 0x6BCC934 VA: 0x6BD0934
	public void set_Gc2Flag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6BD0940 Offset: 0x6BCC940 VA: 0x6BD0940
	public uint get_EventBitmap() { }

	[CompilerGenerated]
	// RVA: 0x6BD0948 Offset: 0x6BCC948 VA: 0x6BD0948
	public void set_EventBitmap(uint value) { }

	[CompilerGenerated]
	// RVA: 0x6BD0950 Offset: 0x6BCC950 VA: 0x6BD0950
	public uint get_EventNumber() { }

	[CompilerGenerated]
	// RVA: 0x6BD0958 Offset: 0x6BCC958 VA: 0x6BD0958
	public void set_EventNumber(uint value) { }

	// RVA: 0x6BD0960 Offset: 0x6BCC960 VA: 0x6BD0960
	public void .ctor() { }
}

// Namespace: FalconNet.NetCore.Statistics.Models
public struct MinuteReportWriter // TypeDefIndex: 24554
{
	// Fields
	public bool HasData; // 0x0
	public MetricSnapshot Rtt; // 0x8
	public MetricSnapshot EventProcessTime; // 0x20
	public CountSnapshot Counts; // 0x38
	public NetErrorFlags NetErrors; // 0x42
	public CircularPacketBitmap LossBitmap; // 0x48
	public ushort NetType; // 0x68
	public byte GcFlag; // 0x6A
	public uint EventBitmap; // 0x6C
	public uint EventNumber; // 0x70

	// Methods

	// RVA: 0x6BD0968 Offset: 0x6BCC968 VA: 0x6BD0968
	public void .ctor(ushort rttBucketSize, ushort eventProcessTimeBucketSize, ushort lossWindowSize, ushort lossInitialPacketId = 0) { }

	// RVA: 0x6BD0A84 Offset: 0x6BCCA84 VA: 0x6BD0A84
	public void WriteRtt(ushort value) { }

	// RVA: 0x6BD0AA4 Offset: 0x6BCCAA4 VA: 0x6BD0AA4
	public void WriteEventProcessTime(ushort value) { }

	// RVA: 0x6BD0AB0 Offset: 0x6BCCAB0 VA: 0x6BD0AB0
	public void WriteNetType(ushort value) { }

	// RVA: 0x6BD0AC0 Offset: 0x6BCCAC0 VA: 0x6BD0AC0
	public void AddCount(CountType type, ushort value) { }

	// RVA: 0x6BD0B20 Offset: 0x6BCCB20 VA: 0x6BD0B20
	public void MarkNetError(NetErrorType type) { }

	// RVA: 0x6BD0B3C Offset: 0x6BCCB3C VA: 0x6BD0B3C
	public void MarkPacketReceived(int packetId) { }

	// RVA: 0x6BD0C2C Offset: 0x6BCCC2C VA: 0x6BD0C2C
	public float GetLossWindowRate() { }

	// RVA: 0x6BD0CB4 Offset: 0x6BCCCB4 VA: 0x6BD0CB4
	public void MarkGc(int gc0_delta, int gc1_delta, int gc2_delta) { }

	// RVA: 0x6BD0CFC Offset: 0x6BCCCFC VA: 0x6BD0CFC
	public bool HasGc(int generation) { }

	// RVA: 0x6BD0D0C Offset: 0x6BCCD0C VA: 0x6BD0D0C
	public void MarkEvent(uint eventBitMap, uint eventNumber) { }

	// RVA: 0x6BD0D1C Offset: 0x6BCCD1C VA: 0x6BD0D1C
	public bool HasEvent(int eventId) { }

	// RVA: 0x6BD0D40 Offset: 0x6BCCD40 VA: 0x6BD0D40
	public void ResetEvents() { }

	// RVA: 0x6BD0D48 Offset: 0x6BCCD48 VA: 0x6BD0D48
	public SnapshotMetric ToSnapshotMetric() { }

	// RVA: 0x6BD0ED4 Offset: 0x6BCCED4 VA: 0x6BD0ED4
	public void Reset() { }

	// RVA: 0x6BD0A90 Offset: 0x6BCCA90 VA: 0x6BD0A90
	private void WriteMetricSample(ref MetricSnapshot snapshot, ushort value) { }

	// RVA: 0x6BD0FA4 Offset: 0x6BCCFA4 VA: 0x6BD0FA4
	private int GetBucketIndex(ushort value, ushort bucketSize) { }
}

// Namespace: FalconNet.NetCore.Statistics.Models
public struct CircularPacketBitmap // TypeDefIndex: 24555
{
	// Fields
	private const int BitsPerByte = 8;
	private int _receivedCountInWindow; // 0x0
	private readonly int _windowSize; // 0x4
	private readonly int _bitmapLength; // 0x8
	private int _windowStartId; // 0xC
	private byte[] _bitmap; // 0x10
	private int _firstReceivedId; // 0x18
	private int _lastReceivedId; // 0x1C

	// Properties
	public int WindowStart { get; }
	public int WindowEnd { get; }

	// Methods

	// RVA: 0x6BD09F4 Offset: 0x6BCC9F4 VA: 0x6BD09F4
	public void .ctor(int windowSize, int initialStartId = 1) { }

	// RVA: 0x6BD0F50 Offset: 0x6BCCF50 VA: 0x6BD0F50
	public int GetNextWindowStartId() { }

	// RVA: 0x6BD0B48 Offset: 0x6BCCB48 VA: 0x6BD0B48
	public void MarkReceived(int packetId) { }

	// RVA: 0x6BD10AC Offset: 0x6BCD0AC VA: 0x6BD10AC
	public bool IsReceived(int packetId) { }

	// RVA: 0x6BD112C Offset: 0x6BCD12C VA: 0x6BD112C
	public int CountReceived() { }

	// RVA: 0x6BD11DC Offset: 0x6BCD1DC VA: 0x6BD11DC
	public int CountLost() { }

	// RVA: 0x6BD0C70 Offset: 0x6BCCC70 VA: 0x6BD0C70
	public float GetObservedLossRate() { }

	// RVA: 0x6BD11F4 Offset: 0x6BCD1F4 VA: 0x6BD11F4
	public int get_WindowStart() { }

	// RVA: 0x6BD11FC Offset: 0x6BCD1FC VA: 0x6BD11FC
	public int get_WindowEnd() { }

	// RVA: 0x6BD0F64 Offset: 0x6BCCF64 VA: 0x6BD0F64
	public void Reset(int startId = 1) { }

	// RVA: 0x6BD0FC0 Offset: 0x6BCCFC0 VA: 0x6BD0FC0
	private void AdvanceWindow(int newStartId) { }

	// RVA: 0x6BD11AC Offset: 0x6BCD1AC VA: 0x6BD11AC
	private static int CountBits(byte b) { }
}

// Namespace: FalconNet.NetCore.Const
internal static class Const // TypeDefIndex: 24556
{
	// Fields
	internal const int UdpNetSeqIdMetaSize = 4;
	internal const int UdpMsgLengthMetaSize = 4;
	internal const int UdpMaxMsgSize = 1024;
	internal const int UdpHeaderSize = 12;
	internal const int UdpMaxPayloadSize = 1012;
	internal const int UdpCombineMaxPayloadSize = 1008;
	internal const int UdpTsTailSize = 8;
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5942 // TypeDefIndex: 24557
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=7526 // TypeDefIndex: 24558
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 24559
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=7526 390BA9A8461AFFD81562F6ED2AA857AE6108E717ABFE396AB219897D97F8F117 /*Metadata offset 0xF39618*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5942 EFF14A4C8F0328831A8527AA5CA1C9D4D809F49A35089ACB0F7E5150FD6C62AC /*Metadata offset 0xF3B380*/; // 0x1D66
}


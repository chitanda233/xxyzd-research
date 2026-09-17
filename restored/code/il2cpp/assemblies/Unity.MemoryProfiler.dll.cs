// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28973
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 28974
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
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 28975
{
	// Methods

	// RVA: 0x8532F00 Offset: 0x852EF00 VA: 0x8532F00
	public void .ctor() { }
}

// Namespace: Unity.MemoryProfiler
internal static class MetadataInjector // TypeDefIndex: 28976
{
	// Fields
	public static DefaultMetadataCollect DefaultCollector; // 0x0
	public static long CollectorCount; // 0x8
	public static byte DefaultCollectorInjected; // 0x10

	// Methods

	[RuntimeInitializeOnLoadMethod(3)]
	// RVA: 0x8532F08 Offset: 0x852EF08 VA: 0x8532F08
	private static void PlayerInitMetadata() { }

	// RVA: 0x85330C0 Offset: 0x852F0C0 VA: 0x85330C0
	private static void InitializeMetadataCollection() { }
}

// Namespace: Unity.MemoryProfiler
public abstract class MetadataCollect : IDisposable // TypeDefIndex: 28977
{
	// Fields
	private bool disposed; // 0x10

	// Methods

	// RVA: 0x8533190 Offset: 0x852F190 VA: 0x8533190
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void CollectMetadata(MemorySnapshotMetadata data);

	// RVA: 0x8532FB4 Offset: 0x852EFB4 VA: 0x8532FB4 Slot: 4
	public void Dispose() { }
}

// Namespace: Unity.MemoryProfiler
internal class DefaultMetadataCollect : MetadataCollect // TypeDefIndex: 28978
{
	// Methods

	// RVA: 0x8533138 Offset: 0x852F138 VA: 0x8533138
	public void .ctor() { }

	// RVA: 0x85332A4 Offset: 0x852F2A4 VA: 0x85332A4 Slot: 5
	public override void CollectMetadata(MemorySnapshotMetadata data) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=88 // TypeDefIndex: 28979
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=131 // TypeDefIndex: 28980
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 28981
{}


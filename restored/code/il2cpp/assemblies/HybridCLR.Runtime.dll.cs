// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28964
{}

// Namespace: HybridCLR
public enum HomologousImageMode // TypeDefIndex: 28965
{
	// Fields
	public int value__; // 0x0
	public const HomologousImageMode Consistent = 0;
	public const HomologousImageMode SuperSet = 1;
}

// Namespace: HybridCLR
public enum LoadImageErrorCode // TypeDefIndex: 28966
{
	// Fields
	public int value__; // 0x0
	public const LoadImageErrorCode OK = 0;
	public const LoadImageErrorCode BAD_IMAGE = 1;
	public const LoadImageErrorCode NOT_IMPLEMENT = 2;
	public const LoadImageErrorCode AOT_ASSEMBLY_NOT_FIND = 3;
	public const LoadImageErrorCode HOMOLOGOUS_ONLY_SUPPORT_AOT_ASSEMBLY = 4;
	public const LoadImageErrorCode HOMOLOGOUS_ASSEMBLY_HAS_LOADED = 5;
	public const LoadImageErrorCode INVALID_HOMOLOGOUS_MODE = 6;
	public const LoadImageErrorCode PDB_BAD_FILE = 7;
	public const LoadImageErrorCode UNKNOWN_IMAGE_FORMAT = 8;
	public const LoadImageErrorCode UNSUPPORT_FORMAT_VERSION = 9;
	public const LoadImageErrorCode UNSUPPORT_ENCRYPTION_ALGORHITHM = 10;
	public const LoadImageErrorCode DHE_NOT_DIFFERENTIAL_HYBRID_ASSEMBLY = 11;
	public const LoadImageErrorCode DHE_HAS_BEEN_LOADED = 12;
	public const LoadImageErrorCode DHE_BAD_DHAO_DATA = 13;
	public const LoadImageErrorCode DHE_BAD_META_VERSION_FILE = 14;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class RuntimeApi.<>c // TypeDefIndex: 28967
{
	// Fields
	public static readonly RuntimeApi.<>c <>9; // 0x0

	// Methods

	// RVA: 0x797AB14 Offset: 0x7976B14 VA: 0x797AB14
	private static void .cctor() { }

	// RVA: 0x797AB7C Offset: 0x7976B7C VA: 0x797AB7C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RuntimeApi.<>c__DisplayClass13_0 // TypeDefIndex: 28968
{
	// Methods

	// RVA: 0x797AB84 Offset: 0x7976B84 VA: 0x797AB84
	public void .ctor() { }
}

// Namespace: HybridCLR
[Preserve]
public static class RuntimeApi // TypeDefIndex: 28969
{
	// Methods

	// RVA: 0x797A9DC Offset: 0x79769DC VA: 0x797A9DC
	public static LoadImageErrorCode LoadMetadataForAOTAssembly(byte[] dllBytes, HomologousImageMode mode) { }

	// RVA: 0x797AA20 Offset: 0x7976A20 VA: 0x797AA20
	public static LoadImageErrorCode LoadOriginalDifferentialHybridAssembly(string assName) { }

	// RVA: 0x797AA5C Offset: 0x7976A5C VA: 0x797AA5C
	public static LoadImageErrorCode LoadDifferentialHybridAssemblyWithMetaVersion(byte[] currentDllBytes, byte[] currentDllSymbolBytes, byte[] originalMetaVersionFileBytes, byte[] currentMetaVersionFileBytes) { }

	// RVA: 0x797AAB8 Offset: 0x7976AB8 VA: 0x797AAB8
	private static LoadImageErrorCode LoadDifferentialHybridAssemblyWithMetaVersionImpl(byte[] currentDllBytes, byte[] currentDllSymbolBytes, byte[] originalMetaVersionFileBytes, byte[] currentMetaVersionFileBytes) { }
}


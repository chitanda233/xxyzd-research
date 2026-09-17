// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28855
{}

// Namespace: UnityEngine
[NativeHeader("Modules/ImageConversion/ScriptBindings/ImageConversion.bindings.h")]
[Extension]
public static class ImageConversion // TypeDefIndex: 28856
{
	// Methods

	[Extension]
	[NativeMethod(Name = "ImageConversionBindings::EncodeToPNG", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x8781C04 Offset: 0x877DC04 VA: 0x8781C04
	public static byte[] EncodeToPNG(Texture2D tex) { }

	[NativeMethod(Name = "ImageConversionBindings::EncodeToJPG", IsFreeFunction = True, ThrowsException = True)]
	[Extension]
	// RVA: 0x8781C40 Offset: 0x877DC40 VA: 0x8781C40
	public static byte[] EncodeToJPG(Texture2D tex, int quality) { }

	[Extension]
	// RVA: 0x8781C84 Offset: 0x877DC84 VA: 0x8781C84
	public static byte[] EncodeToJPG(Texture2D tex) { }

	[Extension]
	[NativeMethod(Name = "ImageConversionBindings::LoadImage", IsFreeFunction = True)]
	// RVA: 0x8781CC4 Offset: 0x877DCC4 VA: 0x8781CC4
	public static bool LoadImage(Texture2D tex, byte[] data, bool markNonReadable) { }

	[Extension]
	// RVA: 0x8781D18 Offset: 0x877DD18 VA: 0x8781D18
	public static bool LoadImage(Texture2D tex, byte[] data) { }
}


// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28815
{}

// Namespace: 
public sealed class RemoteSettings.UpdatedEventHandler : MulticastDelegate // TypeDefIndex: 28816
{
	// Methods

	// RVA: 0x89B8A78 Offset: 0x89B4A78 VA: 0x89B8A78
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89B8B14 Offset: 0x89B4B14 VA: 0x89B8B14 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: UnityEngine
[NativeHeader("UnityAnalyticsScriptingClasses.h")]
[NativeHeader("Modules/UnityAnalytics/RemoteSettings/RemoteSettings.h")]
public static class RemoteSettings // TypeDefIndex: 28817
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static RemoteSettings.UpdatedEventHandler Updated; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action BeforeFetchFromServer; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<bool, bool, int> Completed; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x89B8928 Offset: 0x89B4928 VA: 0x89B8928
	internal static void RemoteSettingsUpdated(bool wasLastUpdatedFromServer) { }

	[RequiredByNativeCode]
	// RVA: 0x89B898C Offset: 0x89B498C VA: 0x89B898C
	internal static void RemoteSettingsBeforeFetchFromServer() { }

	[RequiredByNativeCode]
	// RVA: 0x89B89F0 Offset: 0x89B49F0 VA: 0x89B89F0
	internal static void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/UnityAnalytics/RemoteSettings/RemoteSettings.h")]
[NativeHeader("UnityAnalyticsScriptingClasses.h")]
[ExcludeFromDocs]
public class RemoteConfigSettings // TypeDefIndex: 28818
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<bool> Updated; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x89B8B28 Offset: 0x89B4B28 VA: 0x89B8B28
	internal static void RemoteConfigSettingsUpdated(RemoteConfigSettings rcs, bool wasLastUpdatedFromServer) { }
}

// Namespace: 
[RequiredByNativeCode]
internal enum RemoteConfigSettingsHelper.Tag // TypeDefIndex: 28819
{
	// Fields
	public int value__; // 0x0
	public const RemoteConfigSettingsHelper.Tag kUnknown = 0;
	public const RemoteConfigSettingsHelper.Tag kIntVal = 1;
	public const RemoteConfigSettingsHelper.Tag kInt64Val = 2;
	public const RemoteConfigSettingsHelper.Tag kUInt64Val = 3;
	public const RemoteConfigSettingsHelper.Tag kDoubleVal = 4;
	public const RemoteConfigSettingsHelper.Tag kBoolVal = 5;
	public const RemoteConfigSettingsHelper.Tag kStringVal = 6;
	public const RemoteConfigSettingsHelper.Tag kArrayVal = 7;
	public const RemoteConfigSettingsHelper.Tag kMixedArrayVal = 8;
	public const RemoteConfigSettingsHelper.Tag kMapVal = 9;
	public const RemoteConfigSettingsHelper.Tag kMaxTags = 10;
}

// Namespace: UnityEngine
internal static class RemoteConfigSettingsHelper // TypeDefIndex: 28820
{}

// Namespace: UnityEngine.Analytics
[RequiredByNativeCode]
[NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
[NativeHeader("Modules/UnityAnalytics/ContinuousEvent/Manager.h")]
[ExcludeFromDocs]
public class ContinuousEvent // TypeDefIndex: 28821
{}

// Namespace: UnityEngine.Analytics
[RequiredByNativeCode]
public enum AnalyticsSessionState // TypeDefIndex: 28822
{
	// Fields
	public int value__; // 0x0
	public const AnalyticsSessionState kSessionStopped = 0;
	public const AnalyticsSessionState kSessionStarted = 1;
	public const AnalyticsSessionState kSessionPaused = 2;
	public const AnalyticsSessionState kSessionResumed = 3;
}

// Namespace: 
public sealed class AnalyticsSessionInfo.SessionStateChanged : MulticastDelegate // TypeDefIndex: 28823
{
	// Methods

	// RVA: 0x89B8C64 Offset: 0x89B4C64 VA: 0x89B8C64
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89B8D04 Offset: 0x89B4D04 VA: 0x89B8D04 Slot: 13
	public virtual void Invoke(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) { }
}

// Namespace: 
public sealed class AnalyticsSessionInfo.IdentityTokenChanged : MulticastDelegate // TypeDefIndex: 28824
{
	// Methods

	// RVA: 0x89B8D1C Offset: 0x89B4D1C VA: 0x89B8D1C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x89B8DCC Offset: 0x89B4DCC VA: 0x89B8DCC Slot: 13
	public virtual void Invoke(string token) { }
}

// Namespace: UnityEngine.Analytics
[NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
[RequiredByNativeCode]
[NativeHeader("UnityAnalyticsScriptingClasses.h")]
public static class AnalyticsSessionInfo // TypeDefIndex: 28825
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static AnalyticsSessionInfo.SessionStateChanged sessionStateChanged; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static AnalyticsSessionInfo.IdentityTokenChanged identityTokenChanged; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x89B8B5C Offset: 0x89B4B5C VA: 0x89B8B5C
	internal static void CallSessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) { }

	[RequiredByNativeCode]
	// RVA: 0x89B8BF8 Offset: 0x89B4BF8 VA: 0x89B8BF8
	internal static void CallIdentityTokenChanged(string token) { }
}


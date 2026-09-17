// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28163
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 28164
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
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 28165
{
	// Methods

	// RVA: 0x64666FC Offset: 0x64626FC VA: 0x64666FC
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x64667F4 Offset: 0x64627F4 VA: 0x64667F4
	public void .ctor() { }
}

// Namespace: GorillaIM
public enum ChatMessageType // TypeDefIndex: 28166
{
	// Fields
	public int value__; // 0x0
	public const ChatMessageType None = 0;
	public const ChatMessageType Context = 1;
	public const ChatMessageType System = 2;
	public const ChatMessageType Emoji = 3;
}

// Namespace: GorillaIM
public enum ChatType // TypeDefIndex: 28167
{
	// Fields
	public int value__; // 0x0
	public const ChatType None = 0;
	public const ChatType Guild = 1;
	public const ChatType SelfServer = 2;
	public const ChatType Private = 3;
	public const ChatType CrossServer = 4;
	public const ChatType AllServer = 5;
}

// Namespace: GorillaIM
[Extension]
public static class MessageTypeExtension // TypeDefIndex: 28168
{
	// Methods

	[Extension]
	// RVA: 0x64667FC Offset: 0x64627FC VA: 0x64667FC
	public static ChatType ToChatType(MessageType messageType) { }
}

// Namespace: GorillaIM
public class ConnectHandler : IIMConnectHandler // TypeDefIndex: 28169
{
	// Fields
	private readonly Dictionary<ushort, Action<IMessage>> _messageHandlers; // 0x10
	private readonly List<Action> _imConnectedHandlers; // 0x18
	private static ConnectHandler _instance; // 0x0

	// Properties
	public static ConnectHandler Instance { get; }

	// Methods

	// RVA: 0x646682C Offset: 0x646282C VA: 0x646682C
	public static ConnectHandler get_Instance() { }

	// RVA: 0x64668A4 Offset: 0x64628A4 VA: 0x64668A4
	private void .ctor() { }

	// RVA: 0x6466980 Offset: 0x6462980 VA: 0x6466980
	public void RegisterHandler(ushort id, Action<IMessage> handler) { }

	// RVA: 0x6466A9C Offset: 0x6462A9C VA: 0x6466A9C
	public void UnRegisterHandler(ushort id, Action<IMessage> handler) { }

	// RVA: 0x6466BB4 Offset: 0x6462BB4 VA: 0x6466BB4
	public void RegisterOnIMConnected(Action handler) { }

	// RVA: 0x6466C9C Offset: 0x6462C9C VA: 0x6466C9C
	public void UnRegisterOnIMConnected(Action handler) { }

	// RVA: 0x6466D04 Offset: 0x6462D04 VA: 0x6466D04 Slot: 4
	public void OnReceiveMessage(IMessage msg) { }

	// RVA: 0x6466FB0 Offset: 0x6462FB0 VA: 0x6466FB0 Slot: 5
	public void OnWebSocketConnected() { }

	// RVA: 0x6467224 Offset: 0x6463224 VA: 0x6467224 Slot: 6
	public void OnWebSocketError(WebSocketStausCodes code, string message) { }

	// RVA: 0x6467228 Offset: 0x6463228 VA: 0x6467228 Slot: 7
	public void OnDisconnect() { }

	// RVA: 0x646722C Offset: 0x646322C VA: 0x646722C Slot: 8
	public IMessage CreateMessage(ushort id) { }
}

// Namespace: GorillaIM
internal struct TrackEventData // TypeDefIndex: 28170
{
	// Fields
	public string Step; // 0x0
	public string MessageId; // 0x8
	public string MessageName; // 0x10
	public string Data; // 0x18
	public int ErrorCode; // 0x20
	public string ErrorMessage; // 0x28

	// Methods

	// RVA: 0x6467238 Offset: 0x6463238 VA: 0x6467238
	public Dictionary<string, object> ToProperty() { }
}

// Namespace: GorillaIM
internal static class EventTracker // TypeDefIndex: 28171
{
	// Fields
	public static Action<TrackEventData> OnTrackEvent; // 0x0

	// Methods

	// RVA: 0x64673F8 Offset: 0x64633F8 VA: 0x64673F8
	public static void TrackInit() { }

	// RVA: 0x64675F0 Offset: 0x64635F0 VA: 0x64675F0
	public static void TrackError(int code, string message) { }

	// RVA: 0x6467694 Offset: 0x6463694 VA: 0x6467694
	public static void TrackSend(IMessage msg) { }

	// RVA: 0x6467844 Offset: 0x6463844 VA: 0x6467844
	public static void TrackReceive(IMessage msg) { }

	// RVA: 0x64679F4 Offset: 0x64639F4 VA: 0x64679F4
	public static void TrackClose(int errorCode, string message) { }

	// RVA: 0x6467A98 Offset: 0x6463A98 VA: 0x6467A98
	public static void TrackInternalError(string message) { }

	// RVA: 0x6467B2C Offset: 0x6463B2C VA: 0x6467B2C
	public static void TrackConnect(string uri) { }

	// RVA: 0x6467BC0 Offset: 0x6463BC0 VA: 0x6467BC0
	public static void TrackConnected() { }

	// RVA: 0x6467474 Offset: 0x6463474 VA: 0x6467474
	private static void TryTrack(TrackEventData data) { }
}

// Namespace: GorillaIM
public interface IIMConnectHandler // TypeDefIndex: 28172
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnReceiveMessage(IMessage msg);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnWebSocketConnected();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnWebSocketError(WebSocketStausCodes code, string message);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnDisconnect();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IMessage CreateMessage(ushort id);
}

// Namespace: GorillaIM
public class IMConnectContext // TypeDefIndex: 28173
{
	// Fields
	[CompilerGenerated]
	private ulong <UserID>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Token>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <ImToken>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Uri>k__BackingField; // 0x28
	private readonly Action<WebSocketLogicType> _changeLogicAction; // 0x30
	public readonly WebSocketConnection Connection; // 0x38
	public IIMConnectHandler Handler; // 0x40
	public float Float_Param; // 0x48
	[CompilerGenerated]
	private bool <IsAutoReconnect>k__BackingField; // 0x4C
	[CompilerGenerated]
	private int <AutoConnectNum>k__BackingField; // 0x50

	// Properties
	public ulong UserID { get; set; }
	public string Token { get; set; }
	public string ImToken { get; set; }
	public string Uri { get; set; }
	public bool IsAutoReconnect { get; set; }
	public int AutoConnectNum { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6467C3C Offset: 0x6463C3C VA: 0x6467C3C
	private void set_UserID(ulong value) { }

	[CompilerGenerated]
	// RVA: 0x6467C44 Offset: 0x6463C44 VA: 0x6467C44
	public ulong get_UserID() { }

	[CompilerGenerated]
	// RVA: 0x6467C4C Offset: 0x6463C4C VA: 0x6467C4C
	private void set_Token(string value) { }

	[CompilerGenerated]
	// RVA: 0x6467C54 Offset: 0x6463C54 VA: 0x6467C54
	public string get_Token() { }

	[CompilerGenerated]
	// RVA: 0x6467C5C Offset: 0x6463C5C VA: 0x6467C5C
	private void set_ImToken(string value) { }

	[CompilerGenerated]
	// RVA: 0x6467C64 Offset: 0x6463C64 VA: 0x6467C64
	public string get_ImToken() { }

	[CompilerGenerated]
	// RVA: 0x6467C6C Offset: 0x6463C6C VA: 0x6467C6C
	private void set_Uri(string value) { }

	[CompilerGenerated]
	// RVA: 0x6467C74 Offset: 0x6463C74 VA: 0x6467C74
	public string get_Uri() { }

	[CompilerGenerated]
	// RVA: 0x6467C7C Offset: 0x6463C7C VA: 0x6467C7C
	private void set_IsAutoReconnect(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6467C88 Offset: 0x6463C88 VA: 0x6467C88
	public bool get_IsAutoReconnect() { }

	[CompilerGenerated]
	// RVA: 0x6467C90 Offset: 0x6463C90 VA: 0x6467C90
	private void set_AutoConnectNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x6467C98 Offset: 0x6463C98 VA: 0x6467C98
	public int get_AutoConnectNum() { }

	// RVA: 0x6467CA0 Offset: 0x6463CA0 VA: 0x6467CA0
	public void .ctor(IWebSocketListener listener, Action<WebSocketLogicType> changeLogic, string uri) { }

	// RVA: 0x6467DDC Offset: 0x6463DDC VA: 0x6467DDC
	public void ChangeLogic(WebSocketLogicType type) { }

	// RVA: 0x6467DF8 Offset: 0x6463DF8 VA: 0x6467DF8
	public bool CheckAndSetLoginData(ulong id, string token, string imToken) { }

	// RVA: 0x6467ECC Offset: 0x6463ECC VA: 0x6467ECC
	public void ClearLoginData() { }

	// RVA: 0x6467EF8 Offset: 0x6463EF8 VA: 0x6467EF8
	public void EnableAutoConnect() { }

	// RVA: 0x6467F08 Offset: 0x6463F08 VA: 0x6467F08
	public void DisableAutoConnect() { }

	// RVA: 0x6467F10 Offset: 0x6463F10 VA: 0x6467F10
	public bool CanConnect() { }

	// RVA: 0x6467F64 Offset: 0x6463F64 VA: 0x6467F64
	public void SetAutoConnectNum(int i) { }

	// RVA: 0x6467F6C Offset: 0x6463F6C VA: 0x6467F6C
	public void SendMessage(IMessage message) { }
}

// Namespace: GorillaIM
public enum WebSocketState // TypeDefIndex: 28174
{
	// Fields
	public int value__; // 0x0
	public const WebSocketState Disconnect = 0;
	public const WebSocketState Disconnecting = 1;
	public const WebSocketState Connected = 2;
	public const WebSocketState Connecting = 3;
}

// Namespace: GorillaIM
public class IMConnectManager : MonoBehaviour, IWebSocketListener // TypeDefIndex: 28175
{
	// Fields
	private const string Tag = "[IMConnectManager]";
	private IIMConnectLogic _logic; // 0x20
	private IMConnectContext _context; // 0x28
	private bool _isInitialized; // 0x30
	private readonly Dictionary<int, IIMConnectLogic> _logicDic; // 0x38
	private static IMConnectManager _instance; // 0x0

	// Properties
	public WebSocketState CurrentState { get; }
	public static IMConnectManager Instance { get; }

	// Methods

	// RVA: 0x6468114 Offset: 0x6464114 VA: 0x6468114
	public WebSocketState get_CurrentState() { }

	// RVA: 0x64681C4 Offset: 0x64641C4 VA: 0x64681C4
	public static IMConnectManager get_Instance() { }

	// RVA: 0x64682D4 Offset: 0x64642D4 VA: 0x64682D4
	private void Awake() { }

	// RVA: 0x64683FC Offset: 0x64643FC VA: 0x64683FC
	private void Update() { }

	// RVA: 0x64684DC Offset: 0x64644DC VA: 0x64684DC
	public void Init(string url) { }

	// RVA: 0x646875C Offset: 0x646475C VA: 0x646875C
	public void SetWebSocketHandler(IIMConnectHandler handler) { }

	// RVA: 0x6468828 Offset: 0x6464828 VA: 0x6468828
	public void Connect() { }

	// RVA: 0x646896C Offset: 0x646496C VA: 0x646896C
	public void Disconnect() { }

	// RVA: 0x6468B34 Offset: 0x6464B34 VA: 0x6468B34
	public void Login(ulong userId, string token, string imToken) { }

	// RVA: 0x6468CAC Offset: 0x6464CAC VA: 0x6468CAC
	public void Logout() { }

	// RVA: 0x6468E0C Offset: 0x6464E0C VA: 0x6468E0C
	public bool SendMessage(IMessage msg) { }

	// RVA: 0x6468F54 Offset: 0x6464F54 VA: 0x6468F54 Slot: 4
	public void OnWebSocketOpen() { }

	// RVA: 0x6469008 Offset: 0x6465008 VA: 0x6469008 Slot: 5
	public void OnWebSocketMessage(BufferSegment data) { }

	// RVA: 0x64694A8 Offset: 0x64654A8 VA: 0x64694A8 Slot: 6
	public void OnWebSocketClosed(WebSocketStausCodes code, string message) { }

	// RVA: 0x6469574 Offset: 0x6465574 VA: 0x6469574 Slot: 7
	private void GorillaIM.IWebSocketListener.OnWebSocketError(WebSocketStausCodes code, string message) { }

	// RVA: 0x64685C8 Offset: 0x64645C8 VA: 0x64685C8
	private IIMConnectLogic GetLogic(WebSocketLogicType type) { }

	// RVA: 0x64698A4 Offset: 0x64658A4 VA: 0x64698A4
	private void ChangeLogic(WebSocketLogicType type) { }

	// RVA: 0x6469974 Offset: 0x6465974 VA: 0x6469974
	public void .ctor() { }
}

// Namespace: GorillaIM
public class IMNetCode // TypeDefIndex: 28176
{
	// Fields
	public const int Success = 0;
	public const int IM_PARAMS_ERROR = 310001;
	public const int IM_USER_NOT_LOGIN = 310002;
	public const int IM_CHAT_BANNED = 310007;
	public const int IM_CHAT_CONTENT_LENGTH_ERROR = 320001;
	public const int IM_CHAT_GUILD_NOTJOIN = 320002;
	public const int IM_CHAT_FREQUENCY_TOO_FAST = 320003;
	public const int IM_CHATBANNED = 320004;
	public const int IM_CHAT_IN_BLACKLIST = 320005;
	public const int IM_CHAT_CHAPTER_LIMIT = 320006;
	public const int IMCHAT_NOT_OPEN = 320007;
	public const int IM_CHATBLACK_LIST_ERROR = 320008;
	public const int IM_CHATCONTENTCHECK_ERROR = 320009;

	// Methods

	// RVA: 0x64699FC Offset: 0x64659FC VA: 0x64699FC
	public void .ctor() { }
}

// Namespace: GorillaIM
internal interface IIMConnectLogic // TypeDefIndex: 28177
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnEnter(IMConnectContext context);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Connect(IMConnectContext context);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Reconnect(IMConnectContext context);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Disconnect(IMConnectContext context);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnLogin(IMConnectContext context);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnLogout(IMConnectContext context);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract WebSocketState GetConnectState();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void OnWebSocketOpen(IMConnectContext context);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void OnWebSocketMessage(IMConnectContext context, IMessage message);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void OnWebSocketClosed(IMConnectContext context, WebSocketStausCodes code, string message);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void OnWebSocketError(IMConnectContext context, WebSocketStausCodes code, string message);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void OnUpdate(IMConnectContext context, float deltaTime, float unscaleDeltaTime);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool SendMessage(IMConnectContext context, IMessage msg);
}

// Namespace: GorillaIM
public class IMConnectLogic_AutoReconnect : IMConnectLogic_Base // TypeDefIndex: 28178
{
	// Fields
	private readonly float[] _connectWaitTime; // 0x18

	// Methods

	// RVA: 0x6469A04 Offset: 0x6465A04 VA: 0x6469A04 Slot: 21
	public override WebSocketState GetConnectState() { }

	// RVA: 0x6469A0C Offset: 0x6465A0C VA: 0x6469A0C Slot: 22
	public override void OnEnter(IMConnectContext context) { }

	// RVA: 0x6469A28 Offset: 0x6465A28 VA: 0x6469A28 Slot: 17
	public override void Connect(IMConnectContext context) { }

	// RVA: 0x6469AA8 Offset: 0x6465AA8 VA: 0x6469AA8 Slot: 19
	public override void OnLogin(IMConnectContext context) { }

	// RVA: 0x6469AB0 Offset: 0x6465AB0 VA: 0x6469AB0 Slot: 18
	public override void Disconnect(IMConnectContext context) { }

	// RVA: 0x6469AE4 Offset: 0x6465AE4 VA: 0x6469AE4 Slot: 27
	public override void OnUpdate(IMConnectContext context, float deltaTime, float unscaleDeltaTime) { }

	// RVA: 0x6469A44 Offset: 0x6465A44 VA: 0x6469A44
	private static void TryConnect(IMConnectContext context) { }

	// RVA: 0x646980C Offset: 0x646580C VA: 0x646980C
	public void .ctor() { }
}

// Namespace: GorillaIM
public enum WebSocketLogicType // TypeDefIndex: 28179
{
	// Fields
	public int value__; // 0x0
	public const WebSocketLogicType None = 0;
	public const WebSocketLogicType Rest = 1;
	public const WebSocketLogicType Connecting = 2;
	public const WebSocketLogicType Login = 3;
	public const WebSocketLogicType Connected = 4;
	public const WebSocketLogicType Disconnect = 5;
	public const WebSocketLogicType AutoReconnect = 6;
}

// Namespace: GorillaIM
public abstract class IMConnectLogic_Base : IIMConnectLogic // TypeDefIndex: 28180
{
	// Fields
	[CompilerGenerated]
	private float <HeartBeatInterval>k__BackingField; // 0x10

	// Properties
	protected float HeartBeatInterval { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6469BD4 Offset: 0x6465BD4 VA: 0x6469BD4
	protected float get_HeartBeatInterval() { }

	[CompilerGenerated]
	// RVA: 0x6469BDC Offset: 0x6465BDC VA: 0x6469BDC
	protected void set_HeartBeatInterval(float value) { }

	// RVA: 0x6469BE4 Offset: 0x6465BE4 VA: 0x6469BE4 Slot: 17
	public virtual void Connect(IMConnectContext context) { }

	// RVA: 0x6469BE8 Offset: 0x6465BE8 VA: 0x6469BE8 Slot: 18
	public virtual void Disconnect(IMConnectContext context) { }

	// RVA: 0x6469BEC Offset: 0x6465BEC VA: 0x6469BEC Slot: 6
	public void Reconnect(IMConnectContext context) { }

	// RVA: 0x6469BF0 Offset: 0x6465BF0 VA: 0x6469BF0 Slot: 19
	public virtual void OnLogin(IMConnectContext context) { }

	// RVA: 0x6469BF4 Offset: 0x6465BF4 VA: 0x6469BF4 Slot: 20
	public virtual void OnLogout(IMConnectContext context) { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract WebSocketState GetConnectState();

	// RVA: 0x6469BF8 Offset: 0x6465BF8 VA: 0x6469BF8 Slot: 22
	public virtual void OnEnter(IMConnectContext context) { }

	// RVA: 0x6469BFC Offset: 0x6465BFC VA: 0x6469BFC Slot: 23
	public virtual void OnWebSocketOpen(IMConnectContext context) { }

	// RVA: 0x6469C00 Offset: 0x6465C00 VA: 0x6469C00 Slot: 24
	public virtual void OnWebSocketMessage(IMConnectContext context, IMessage message) { }

	// RVA: 0x6469C04 Offset: 0x6465C04 VA: 0x6469C04 Slot: 25
	public virtual void OnWebSocketClosed(IMConnectContext context, WebSocketStausCodes code, string message) { }

	// RVA: 0x6469C08 Offset: 0x6465C08 VA: 0x6469C08 Slot: 26
	public virtual void OnWebSocketError(IMConnectContext context, WebSocketStausCodes code, string message) { }

	// RVA: 0x6469C0C Offset: 0x6465C0C VA: 0x6469C0C Slot: 27
	public virtual void OnUpdate(IMConnectContext context, float deltaTime, float unscaleDeltaTime) { }

	// RVA: 0x6469C10 Offset: 0x6465C10 VA: 0x6469C10 Slot: 28
	public virtual bool SendMessage(IMConnectContext context, IMessage msg) { }

	// RVA: 0x6469BC4 Offset: 0x6465BC4 VA: 0x6469BC4
	protected void .ctor() { }
}

// Namespace: GorillaIM
public class IMConnectLogic_Connected : IMConnectLogic_Base // TypeDefIndex: 28181
{
	// Methods

	// RVA: 0x6469C18 Offset: 0x6465C18 VA: 0x6469C18 Slot: 22
	public override void OnEnter(IMConnectContext context) { }

	// RVA: 0x6469DA8 Offset: 0x6465DA8 VA: 0x6469DA8 Slot: 18
	public override void Disconnect(IMConnectContext context) { }

	// RVA: 0x6469DDC Offset: 0x6465DDC VA: 0x6469DDC Slot: 19
	public override void OnLogin(IMConnectContext context) { }

	// RVA: 0x6469E10 Offset: 0x6465E10 VA: 0x6469E10 Slot: 20
	public override void OnLogout(IMConnectContext context) { }

	// RVA: 0x6469E44 Offset: 0x6465E44 VA: 0x6469E44 Slot: 24
	public override void OnWebSocketMessage(IMConnectContext context, IMessage message) { }

	// RVA: 0x646A060 Offset: 0x6466060 VA: 0x646A060 Slot: 25
	public override void OnWebSocketClosed(IMConnectContext context, WebSocketStausCodes code, string message) { }

	// RVA: 0x646A094 Offset: 0x6466094 VA: 0x646A094 Slot: 26
	public override void OnWebSocketError(IMConnectContext context, WebSocketStausCodes code, string message) { }

	// RVA: 0x646A0C8 Offset: 0x64660C8 VA: 0x646A0C8 Slot: 21
	public override WebSocketState GetConnectState() { }

	// RVA: 0x646A0D0 Offset: 0x64660D0 VA: 0x646A0D0 Slot: 28
	public override bool SendMessage(IMConnectContext context, IMessage msg) { }

	// RVA: 0x646A0F8 Offset: 0x64660F8 VA: 0x646A0F8 Slot: 27
	public override void OnUpdate(IMConnectContext context, float deltaTime, float unscaleDeltaTime) { }

	// RVA: 0x64697DC Offset: 0x64657DC VA: 0x64697DC
	public void .ctor() { }
}

// Namespace: GorillaIM
public class IMConnectLogic_Connecting : IMConnectLogic_Base // TypeDefIndex: 28182
{
	// Methods

	// RVA: 0x646A1A0 Offset: 0x64661A0 VA: 0x646A1A0 Slot: 22
	public override void OnEnter(IMConnectContext context) { }

	// RVA: 0x646A5C0 Offset: 0x64665C0 VA: 0x646A5C0 Slot: 18
	public override void Disconnect(IMConnectContext context) { }

	// RVA: 0x646A5F4 Offset: 0x64665F4 VA: 0x646A5F4 Slot: 20
	public override void OnLogout(IMConnectContext context) { }

	// RVA: 0x646A628 Offset: 0x6466628 VA: 0x646A628 Slot: 25
	public override void OnWebSocketClosed(IMConnectContext context, WebSocketStausCodes code, string message) { }

	// RVA: 0x646A65C Offset: 0x646665C VA: 0x646A65C Slot: 26
	public override void OnWebSocketError(IMConnectContext context, WebSocketStausCodes code, string message) { }

	// RVA: 0x646A690 Offset: 0x6466690 VA: 0x646A690 Slot: 23
	public override void OnWebSocketOpen(IMConnectContext context) { }

	// RVA: 0x646A6C4 Offset: 0x64666C4 VA: 0x646A6C4 Slot: 21
	public override WebSocketState GetConnectState() { }

	// RVA: 0x64697CC Offset: 0x64657CC VA: 0x64697CC
	public void .ctor() { }
}

// Namespace: GorillaIM
public class IMConnectLogic_Disconnect : IMConnectLogic_Base // TypeDefIndex: 28183
{
	// Methods

	// RVA: 0x646A6CC Offset: 0x64666CC VA: 0x646A6CC Slot: 21
	public override WebSocketState GetConnectState() { }

	// RVA: 0x646A6D4 Offset: 0x64666D4 VA: 0x646A6D4 Slot: 22
	public override void OnEnter(IMConnectContext context) { }

	// RVA: 0x646A7CC Offset: 0x64667CC VA: 0x646A7CC Slot: 25
	public override void OnWebSocketClosed(IMConnectContext context, WebSocketStausCodes code, string message) { }

	// RVA: 0x646A7D0 Offset: 0x64667D0 VA: 0x646A7D0 Slot: 26
	public override void OnWebSocketError(IMConnectContext context, WebSocketStausCodes code, string message) { }

	// RVA: 0x646A710 Offset: 0x6466710 VA: 0x646A710
	private void DisconnectFinish(IMConnectContext context) { }

	// RVA: 0x64697EC Offset: 0x64657EC VA: 0x64697EC
	public void .ctor() { }
}

// Namespace: GorillaIM
public class IMConnectLogic_Login : IMConnectLogic_Base // TypeDefIndex: 28184
{
	// Methods

	// RVA: 0x646A7D4 Offset: 0x64667D4 VA: 0x646A7D4 Slot: 22
	public override void OnEnter(IMConnectContext context) { }

	// RVA: 0x646A8CC Offset: 0x64668CC VA: 0x646A8CC Slot: 18
	public override void Disconnect(IMConnectContext context) { }

	// RVA: 0x646A900 Offset: 0x6466900 VA: 0x646A900 Slot: 19
	public override void OnLogin(IMConnectContext context) { }

	// RVA: 0x646A934 Offset: 0x6466934 VA: 0x646A934 Slot: 20
	public override void OnLogout(IMConnectContext context) { }

	// RVA: 0x646A968 Offset: 0x6466968 VA: 0x646A968 Slot: 25
	public override void OnWebSocketClosed(IMConnectContext context, WebSocketStausCodes code, string message) { }

	// RVA: 0x646A99C Offset: 0x646699C VA: 0x646A99C Slot: 26
	public override void OnWebSocketError(IMConnectContext context, WebSocketStausCodes code, string message) { }

	// RVA: 0x646A9D0 Offset: 0x64669D0 VA: 0x646A9D0 Slot: 24
	public override void OnWebSocketMessage(IMConnectContext context, IMessage message) { }

	// RVA: 0x646AA7C Offset: 0x6466A7C VA: 0x646AA7C Slot: 21
	public override WebSocketState GetConnectState() { }

	// RVA: 0x64697FC Offset: 0x64657FC VA: 0x64697FC
	public void .ctor() { }
}

// Namespace: GorillaIM
public class IMConnectLogic_Rest : IMConnectLogic_Base // TypeDefIndex: 28185
{
	// Methods

	// RVA: 0x646AA84 Offset: 0x6466A84 VA: 0x646AA84 Slot: 22
	public override void OnEnter(IMConnectContext context) { }

	// RVA: 0x646AA88 Offset: 0x6466A88 VA: 0x646AA88 Slot: 17
	public override void Connect(IMConnectContext context) { }

	// RVA: 0x646AACC Offset: 0x6466ACC VA: 0x646AACC Slot: 19
	public override void OnLogin(IMConnectContext context) { }

	// RVA: 0x646AB10 Offset: 0x6466B10 VA: 0x646AB10 Slot: 21
	public override WebSocketState GetConnectState() { }

	// RVA: 0x64697BC Offset: 0x64657BC VA: 0x64697BC
	public void .ctor() { }
}

// Namespace: GorillaIM
internal static class ZLog // TypeDefIndex: 28186
{
	// Methods

	// RVA: 0x646AB18 Offset: 0x6466B18 VA: 0x646AB18
	public static void Log(object message) { }

	// RVA: 0x646AB1C Offset: 0x6466B1C VA: 0x646AB1C
	public static void LogWarning(object message) { }

	// RVA: 0x646AB20 Offset: 0x6466B20 VA: 0x646AB20
	public static void LogError(object message) { }
}

// Namespace: GorillaIM
public enum ImErrorCode // TypeDefIndex: 28187
{
	// Fields
	public int value__; // 0x0
	public const ImErrorCode Success = 0;
	public const ImErrorCode RequestDataDuplicate = 100;
	public const ImErrorCode GameConfigNotExist = 31000;
	public const ImErrorCode ParameterInvalid = 310001;
	public const ImErrorCode NotLogin = 310002;
	public const ImErrorCode GroupNotExist = 310003;
	public const ImErrorCode ChatContentTooLong = 310004;
	public const ImErrorCode ChatNotJoinGuild = 310005;
	public const ImErrorCode ChatFrequencyTooFast = 310006;
	public const ImErrorCode ChatBanned = 310007;
	public const ImErrorCode ChatBlocked = 310008;
	public const ImErrorCode ChatTargetBlocked = 310009;
	public const ImErrorCode ChatChapterLimit = 310010;
	public const ImErrorCode ChatNotOpen = 310011;
	public const ImErrorCode ChatBlackListTooLong = 310012;
	public const ImErrorCode ChatLengthInvalid = 310013;
	public const ImErrorCode BinaryFormatError = -1;
	public const ImErrorCode BuildRequestError = -2;
	public const ImErrorCode ServerError = -3;
	public const ImErrorCode BuildResponseError = -4;
	public const ImErrorCode OperationTooFast = -14;
	public const ImErrorCode DBError = -15;
}

// Namespace: GorillaIM
public class ImManager // TypeDefIndex: 28188
{
	// Fields
	private const string Tag = "[ImManager]";
	private static ImManager _instance; // 0x0
	[CompilerGenerated]
	private Action<Dictionary<string, object>> <ImEventHandler>k__BackingField; // 0x10

	// Properties
	public static ImManager Instance { get; }
	public Action<Dictionary<string, object>> ImEventHandler { get; set; }
	public ConnectHandler Handler { get; }

	// Methods

	// RVA: 0x646AC00 Offset: 0x6466C00 VA: 0x646AC00
	public static ImManager get_Instance() { }

	// RVA: 0x646AC7C Offset: 0x6466C7C VA: 0x646AC7C
	private void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x646AC84 Offset: 0x6466C84 VA: 0x646AC84
	public Action<Dictionary<string, object>> get_ImEventHandler() { }

	[CompilerGenerated]
	// RVA: 0x646AC8C Offset: 0x6466C8C VA: 0x646AC8C
	public void set_ImEventHandler(Action<Dictionary<string, object>> value) { }

	// RVA: 0x646AC94 Offset: 0x6466C94 VA: 0x646AC94
	public ConnectHandler get_Handler() { }

	// RVA: 0x646AC98 Offset: 0x6466C98 VA: 0x646AC98
	public void Init(string url) { }

	// RVA: 0x646ADE8 Offset: 0x6466DE8 VA: 0x646ADE8
	public void Login(ulong userId, string token, string imToken) { }

	// RVA: 0x646AE20 Offset: 0x6466E20 VA: 0x646AE20
	public void Logout() { }

	// RVA: 0x646AE38 Offset: 0x6466E38 VA: 0x646AE38
	public void Connect() { }

	// RVA: 0x646AE50 Offset: 0x6466E50 VA: 0x646AE50
	public void Disconnect() { }

	// RVA: 0x646AE68 Offset: 0x6466E68 VA: 0x646AE68
	private void OnReceiveImEvent(TrackEventData data) { }

	// RVA: 0x646AF08 Offset: 0x6466F08 VA: 0x646AF08
	public void RequestGroupMessageRecord(uint reqCount, ulong msgId, string groupId) { }

	// RVA: 0x646B000 Offset: 0x6467000 VA: 0x646B000
	public void SendGroupChat(string groupId, string content, string language, int itemType = 0, int itemRowId = 0) { }

	// RVA: 0x646B128 Offset: 0x6467128 VA: 0x646B128
	public void TranslateChat(string privateTargetId, ulong msgId, string groupId, string targetLanguage) { }

	// RVA: 0x646B224 Offset: 0x6467224 VA: 0x646B224
	public void RequestPrivateList(string lastKey = "") { }

	// RVA: 0x646B2C4 Offset: 0x64672C4 VA: 0x646B2C4
	public void RequestPrivateChatRecord(uint reqCount, ulong msgId, string targetId) { }

	// RVA: 0x646B3BC Offset: 0x64673BC VA: 0x646B3BC
	public void SendPrivateChat(string privateTargetId, string content, string language) { }

	// RVA: 0x646B4CC Offset: 0x64674CC VA: 0x646B4CC
	public void RequestGetBlackList() { }

	// RVA: 0x646B540 Offset: 0x6467540 VA: 0x646B540
	public void RequestAddBlackUser(List<long> userIds) { }

	// RVA: 0x646B730 Offset: 0x6467730 VA: 0x646B730
	public void BlackListRemove(List<string> userIds) { }

	// RVA: 0x646B7E0 Offset: 0x64677E0 VA: 0x646B7E0
	public static string ToSupportedLanguage(SystemLanguage language) { }
}

// Namespace: GorillaIM
public interface IWebSocketListener // TypeDefIndex: 28189
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnWebSocketOpen();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnWebSocketMessage(BufferSegment buffer);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnWebSocketClosed(WebSocketStausCodes code, string message);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnWebSocketError(WebSocketStausCodes code, string message);
}

// Namespace: GorillaIM
public class WebSocketConnection // TypeDefIndex: 28190
{
	// Fields
	private const string Tag = "[WebSocketConnection]";
	private WebSocket _socket; // 0x10
	private bool _hasReportedCloseOrError; // 0x18
	private readonly IWebSocketListener _listener; // 0x20

	// Properties
	public bool IsConnected { get; }
	public bool IsRest { get; }

	// Methods

	// RVA: 0x646A8A4 Offset: 0x64668A4 VA: 0x646A8A4
	public bool get_IsConnected() { }

	// RVA: 0x646A700 Offset: 0x6466700 VA: 0x646A700
	public bool get_IsRest() { }

	// RVA: 0x6467DAC Offset: 0x6463DAC VA: 0x6467DAC
	internal void .ctor(IWebSocketListener listener) { }

	// RVA: 0x646A1EC Offset: 0x64661EC VA: 0x646A1EC
	public bool ConnectWebSocket(string uri, string imToken) { }

	// RVA: 0x646A764 Offset: 0x6466764 VA: 0x646A764
	public void Disconnect() { }

	// RVA: 0x6467F84 Offset: 0x6463F84 VA: 0x6467F84
	public void SendMessage(IMessage msg) { }

	// RVA: 0x646B924 Offset: 0x6467924 VA: 0x646B924
	public void SendMessage(IMessage msg, ushort packageId) { }

	// RVA: 0x646B990 Offset: 0x6467990 VA: 0x646B990
	private static byte[] ToByteArray(IMessage message, ushort packageId) { }

	// RVA: 0x646BCD8 Offset: 0x6467CD8 VA: 0x646BCD8
	private void OnWebSocketOpen(WebSocket ws) { }

	// RVA: 0x646BD78 Offset: 0x6467D78 VA: 0x646BD78
	private void OnWebSocketMessage(WebSocket ws, byte[] data) { }

	// RVA: 0x646BE7C Offset: 0x6467E7C VA: 0x646BE7C
	private void OnWebSocketClosed(WebSocket ws, ushort code, string message) { }

	// RVA: 0x646BFDC Offset: 0x6467FDC VA: 0x646BFDC
	private void OnWebSocketError(WebSocket ws, string reason) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 // TypeDefIndex: 28191
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=643 // TypeDefIndex: 28192
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1436 // TypeDefIndex: 28193
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 28194
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1436 79750B8FA87DC4B65F8AA9B8D83536F1A231E69B3AB265A602EFA85676D3E169 /*Metadata offset 0xF525B8*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=643 892A7C50F0749F259BC6FD26A139C7092F9CB63C8C1CA11DDCA6C4334F40AD49 /*Metadata offset 0xF52B58*/; // 0x59C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 98EEBD3A80959D7F2F8A935F9D71947765FD43C09908D94F7342F489876FEFC3 /*Metadata offset 0xF52DE0*/; // 0x81F
}


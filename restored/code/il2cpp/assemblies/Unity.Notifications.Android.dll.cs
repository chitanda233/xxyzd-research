// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 27916
{}

// Namespace: Unity.Notifications.Android
public enum NotificationStyle // TypeDefIndex: 27917
{
	// Fields
	public int value__; // 0x0
	public const NotificationStyle None = 0;
	public const NotificationStyle BigPictureStyle = 1;
	public const NotificationStyle BigTextStyle = 2;
}

// Namespace: Unity.Notifications.Android
public enum GroupAlertBehaviours // TypeDefIndex: 27918
{
	// Fields
	public int value__; // 0x0
	public const GroupAlertBehaviours GroupAlertAll = 0;
	public const GroupAlertBehaviours GroupAlertSummary = 1;
	public const GroupAlertBehaviours GroupAlertChildren = 2;
}

// Namespace: Unity.Notifications.Android
public struct BigPictureStyle // TypeDefIndex: 27919
{
	// Fields
	[CompilerGenerated]
	private string <LargeIcon>k__BackingField; // 0x0
	[CompilerGenerated]
	private string <Picture>k__BackingField; // 0x8
	[CompilerGenerated]
	private string <ContentTitle>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <ContentDescription>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <SummaryText>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <ShowWhenCollapsed>k__BackingField; // 0x28

	// Properties
	public string LargeIcon { get; set; }
	public string Picture { get; set; }
	public string ContentTitle { get; set; }
	public string ContentDescription { get; set; }
	public string SummaryText { get; set; }
	public bool ShowWhenCollapsed { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x8533338 Offset: 0x852F338 VA: 0x8533338
	public string get_LargeIcon() { }

	[CompilerGenerated]
	// RVA: 0x8533340 Offset: 0x852F340 VA: 0x8533340
	public void set_LargeIcon(string value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x8533348 Offset: 0x852F348 VA: 0x8533348
	public string get_Picture() { }

	[CompilerGenerated]
	// RVA: 0x8533350 Offset: 0x852F350 VA: 0x8533350
	public void set_Picture(string value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x8533358 Offset: 0x852F358 VA: 0x8533358
	public string get_ContentTitle() { }

	[CompilerGenerated]
	// RVA: 0x8533360 Offset: 0x852F360 VA: 0x8533360
	public void set_ContentTitle(string value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x8533368 Offset: 0x852F368 VA: 0x8533368
	public string get_ContentDescription() { }

	[CompilerGenerated]
	// RVA: 0x8533370 Offset: 0x852F370 VA: 0x8533370
	public void set_ContentDescription(string value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x8533378 Offset: 0x852F378 VA: 0x8533378
	public string get_SummaryText() { }

	[CompilerGenerated]
	// RVA: 0x8533380 Offset: 0x852F380 VA: 0x8533380
	public void set_SummaryText(string value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x8533388 Offset: 0x852F388 VA: 0x8533388
	public bool get_ShowWhenCollapsed() { }

	[CompilerGenerated]
	// RVA: 0x8533390 Offset: 0x852F390 VA: 0x8533390
	public void set_ShowWhenCollapsed(bool value) { }
}

// Namespace: Unity.Notifications.Android
public struct AndroidNotification // TypeDefIndex: 27920
{
	// Fields
	[CompilerGenerated]
	private string <Title>k__BackingField; // 0x0
	[CompilerGenerated]
	private string <Text>k__BackingField; // 0x8
	[CompilerGenerated]
	private string <SmallIcon>k__BackingField; // 0x10
	[CompilerGenerated]
	private DateTime <FireTime>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <LargeIcon>k__BackingField; // 0x20
	[CompilerGenerated]
	private NotificationStyle <Style>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Number>k__BackingField; // 0x2C
	[CompilerGenerated]
	private bool <ShouldAutoCancel>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <UsesStopwatch>k__BackingField; // 0x31
	[CompilerGenerated]
	private string <Group>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <GroupSummary>k__BackingField; // 0x40
	[CompilerGenerated]
	private GroupAlertBehaviours <GroupAlertBehaviour>k__BackingField; // 0x44
	[CompilerGenerated]
	private string <SortKey>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <IntentData>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <ShowTimestamp>k__BackingField; // 0x58
	[CompilerGenerated]
	private bool <ShowCustomTimestamp>k__BackingField; // 0x59
	private Color m_Color; // 0x5C
	private TimeSpan m_RepeatInterval; // 0x70
	private DateTime m_CustomTimestamp; // 0x78
	private bool m_SilentInForeground; // 0x80
	private Nullable<BigPictureStyle> m_BigPictureStyle; // 0x88

	// Properties
	public string Title { get; set; }
	public string Text { get; set; }
	public string SmallIcon { get; set; }
	public DateTime FireTime { get; set; }
	public Nullable<TimeSpan> RepeatInterval { get; set; }
	public string LargeIcon { get; set; }
	public NotificationStyle Style { get; set; }
	public Nullable<Color> Color { get; set; }
	public int Number { get; set; }
	public bool ShouldAutoCancel { get; set; }
	public bool UsesStopwatch { get; set; }
	public string Group { get; set; }
	public bool GroupSummary { get; set; }
	public GroupAlertBehaviours GroupAlertBehaviour { get; set; }
	public string SortKey { get; set; }
	public string IntentData { get; set; }
	public bool ShowTimestamp { get; set; }
	public DateTime CustomTimestamp { get; set; }
	public bool ShowInForeground { get; set; }
	public Nullable<BigPictureStyle> BigPicture { get; set; }
	internal bool ShowCustomTimestamp { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x853339C Offset: 0x852F39C VA: 0x853339C
	public string get_Title() { }

	[CompilerGenerated]
	// RVA: 0x85333A4 Offset: 0x852F3A4 VA: 0x85333A4
	public void set_Title(string value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x85333AC Offset: 0x852F3AC VA: 0x85333AC
	public string get_Text() { }

	[CompilerGenerated]
	// RVA: 0x85333B4 Offset: 0x852F3B4 VA: 0x85333B4
	public void set_Text(string value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x85333BC Offset: 0x852F3BC VA: 0x85333BC
	public string get_SmallIcon() { }

	[CompilerGenerated]
	// RVA: 0x85333C4 Offset: 0x852F3C4 VA: 0x85333C4
	public void set_SmallIcon(string value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x85333CC Offset: 0x852F3CC VA: 0x85333CC
	public DateTime get_FireTime() { }

	[CompilerGenerated]
	// RVA: 0x85333D4 Offset: 0x852F3D4 VA: 0x85333D4
	public void set_FireTime(DateTime value) { }

	// RVA: 0x85333DC Offset: 0x852F3DC VA: 0x85333DC
	public Nullable<TimeSpan> get_RepeatInterval() { }

	// RVA: 0x853343C Offset: 0x852F43C VA: 0x853343C
	public void set_RepeatInterval(Nullable<TimeSpan> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x8533514 Offset: 0x852F514 VA: 0x8533514
	public string get_LargeIcon() { }

	[CompilerGenerated]
	// RVA: 0x853351C Offset: 0x852F51C VA: 0x853351C
	public void set_LargeIcon(string value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x8533524 Offset: 0x852F524 VA: 0x8533524
	public NotificationStyle get_Style() { }

	[CompilerGenerated]
	// RVA: 0x853352C Offset: 0x852F52C VA: 0x853352C
	public void set_Style(NotificationStyle value) { }

	// RVA: 0x8533534 Offset: 0x852F534 VA: 0x8533534
	public Nullable<Color> get_Color() { }

	// RVA: 0x8533598 Offset: 0x852F598 VA: 0x8533598
	public void set_Color(Nullable<Color> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x8533618 Offset: 0x852F618 VA: 0x8533618
	public int get_Number() { }

	[CompilerGenerated]
	// RVA: 0x8533620 Offset: 0x852F620 VA: 0x8533620
	public void set_Number(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x8533628 Offset: 0x852F628 VA: 0x8533628
	public bool get_ShouldAutoCancel() { }

	[CompilerGenerated]
	// RVA: 0x8533630 Offset: 0x852F630 VA: 0x8533630
	public void set_ShouldAutoCancel(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x853363C Offset: 0x852F63C VA: 0x853363C
	public bool get_UsesStopwatch() { }

	[CompilerGenerated]
	// RVA: 0x8533644 Offset: 0x852F644 VA: 0x8533644
	public void set_UsesStopwatch(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x8533650 Offset: 0x852F650 VA: 0x8533650
	public string get_Group() { }

	[CompilerGenerated]
	// RVA: 0x8533658 Offset: 0x852F658 VA: 0x8533658
	public void set_Group(string value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x8533660 Offset: 0x852F660 VA: 0x8533660
	public bool get_GroupSummary() { }

	[CompilerGenerated]
	// RVA: 0x8533668 Offset: 0x852F668 VA: 0x8533668
	public void set_GroupSummary(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x8533674 Offset: 0x852F674 VA: 0x8533674
	public GroupAlertBehaviours get_GroupAlertBehaviour() { }

	[CompilerGenerated]
	// RVA: 0x853367C Offset: 0x852F67C VA: 0x853367C
	public void set_GroupAlertBehaviour(GroupAlertBehaviours value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x8533684 Offset: 0x852F684 VA: 0x8533684
	public string get_SortKey() { }

	[CompilerGenerated]
	// RVA: 0x853368C Offset: 0x852F68C VA: 0x853368C
	public void set_SortKey(string value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x8533694 Offset: 0x852F694 VA: 0x8533694
	public string get_IntentData() { }

	[CompilerGenerated]
	// RVA: 0x853369C Offset: 0x852F69C VA: 0x853369C
	public void set_IntentData(string value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x85336A4 Offset: 0x852F6A4 VA: 0x85336A4
	public bool get_ShowTimestamp() { }

	[CompilerGenerated]
	// RVA: 0x85336AC Offset: 0x852F6AC VA: 0x85336AC
	public void set_ShowTimestamp(bool value) { }

	// RVA: 0x85336B8 Offset: 0x852F6B8 VA: 0x85336B8
	public DateTime get_CustomTimestamp() { }

	// RVA: 0x85336C0 Offset: 0x852F6C0 VA: 0x85336C0
	public void set_CustomTimestamp(DateTime value) { }

	// RVA: 0x85336D0 Offset: 0x852F6D0 VA: 0x85336D0
	public bool get_ShowInForeground() { }

	// RVA: 0x85336E0 Offset: 0x852F6E0 VA: 0x85336E0
	public void set_ShowInForeground(bool value) { }

	// RVA: 0x85336F0 Offset: 0x852F6F0 VA: 0x85336F0
	public Nullable<BigPictureStyle> get_BigPicture() { }

	// RVA: 0x8533710 Offset: 0x852F710 VA: 0x8533710
	public void set_BigPicture(Nullable<BigPictureStyle> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x853379C Offset: 0x852F79C VA: 0x853379C
	internal bool get_ShowCustomTimestamp() { }

	[CompilerGenerated]
	// RVA: 0x85337A4 Offset: 0x852F7A4 VA: 0x85337A4
	internal void set_ShowCustomTimestamp(bool value) { }

	// RVA: 0x85337B0 Offset: 0x852F7B0 VA: 0x85337B0
	public void .ctor(string title, string text, DateTime fireTime) { }

	// RVA: 0x85339A4 Offset: 0x852F9A4 VA: 0x85339A4
	public void .ctor(string title, string text, DateTime fireTime, TimeSpan repeatInterval) { }

	// RVA: 0x8533A40 Offset: 0x852FA40 VA: 0x8533A40
	public void .ctor(string title, string text, DateTime fireTime, TimeSpan repeatInterval, string smallIcon) { }
}

// Namespace: Unity.Notifications.Android
internal class NotificationCallback : AndroidJavaProxy // TypeDefIndex: 27921
{
	// Methods

	// RVA: 0x8533A6C Offset: 0x852FA6C VA: 0x8533A6C
	public void .ctor() { }

	// RVA: 0x8533ADC Offset: 0x852FADC VA: 0x8533ADC Slot: 5
	public override AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] args) { }

	// RVA: 0x8533B88 Offset: 0x852FB88 VA: 0x8533B88
	public void onSentNotification(AndroidJavaObject notification) { }
}

// Namespace: Unity.Notifications.Android
public enum NotificationStatus // TypeDefIndex: 27922
{
	// Fields
	public int value__; // 0x0
	public const NotificationStatus Unavailable = -1;
	public const NotificationStatus Unknown = 0;
	public const NotificationStatus Scheduled = 1;
	public const NotificationStatus Delivered = 2;
}

// Namespace: Unity.Notifications.Android
internal struct NotificationManagerJni // TypeDefIndex: 27923
{
	// Fields
	private AndroidJavaClass klass; // 0x0
	private AndroidJavaObject self; // 0x8
	public AndroidJavaObject KEY_FIRE_TIME; // 0x10
	public AndroidJavaObject KEY_ID; // 0x18
	public AndroidJavaObject KEY_INTENT_DATA; // 0x20
	public AndroidJavaObject KEY_LARGE_ICON; // 0x28
	public AndroidJavaObject KEY_REPEAT_INTERVAL; // 0x30
	public AndroidJavaObject KEY_NOTIFICATION; // 0x38
	public AndroidJavaObject KEY_SMALL_ICON; // 0x40
	public AndroidJavaObject KEY_SHOW_IN_FOREGROUND; // 0x48
	public AndroidJavaObject KEY_BIG_PICTURE; // 0x50
	public string KEY_BIG_LARGE_ICON; // 0x58
	public string KEY_BIG_CONTENT_TITLE; // 0x60
	public string KEY_BIG_SUMMARY_TEXT; // 0x68
	public string KEY_BIG_CONTENT_DESCRIPTION; // 0x70
	public string KEY_BIG_SHOW_WHEN_COLLAPSED; // 0x78
	private IntPtr getNotificationFromIntent; // 0x80
	private IntPtr setNotificationIcon; // 0x88
	private IntPtr setNotificationColor; // 0x90
	private IntPtr getNotificationColor; // 0x98
	private IntPtr setNotificationUsesChronometer; // 0xA0
	private IntPtr setNotificationGroupAlertBehavior; // 0xA8
	private IntPtr getNotificationGroupAlertBehavior; // 0xB0
	private IntPtr getNotificationChannelId; // 0xB8
	private IntPtr scheduleNotification; // 0xC0
	private IntPtr createNotificationBuilder; // 0xC8

	// Methods

	// RVA: 0x8533D2C Offset: 0x852FD2C VA: 0x8533D2C
	public void .ctor(AndroidJavaClass clazz, AndroidJavaObject obj) { }

	// RVA: 0x85340CC Offset: 0x85300CC VA: 0x85340CC
	private void CollectMethods(AndroidJavaClass clazz) { }

	// RVA: 0x85344E0 Offset: 0x85304E0 VA: 0x85344E0
	public AndroidJavaObject GetNotificationFromIntent(AndroidJavaObject intent) { }

	// RVA: 0x85345B4 Offset: 0x85305B4 VA: 0x85345B4
	public void SetNotificationIcon(AndroidJavaObject builder, AndroidJavaObject keyName, string icon) { }

	// RVA: 0x85346EC Offset: 0x85306EC VA: 0x85346EC
	public void SetNotificationColor(AndroidJavaObject builder, int color) { }

	// RVA: 0x8534818 Offset: 0x8530818 VA: 0x8534818
	public Nullable<Color> GetNotificationColor(AndroidJavaObject notification) { }

	// RVA: 0x8534B2C Offset: 0x8530B2C VA: 0x8534B2C
	public void SetNotificationUsesChronometer(AndroidJavaObject builder, bool usesStopwatch) { }

	// RVA: 0x8534C5C Offset: 0x8530C5C VA: 0x8534C5C
	public void SetNotificationGroupAlertBehavior(AndroidJavaObject builder, int groupAlertBehaviour) { }

	// RVA: 0x8534D88 Offset: 0x8530D88 VA: 0x8534D88
	public int GetNotificationGroupAlertBehavior(AndroidJavaObject notification) { }

	// RVA: 0x8534E5C Offset: 0x8530E5C VA: 0x8534E5C
	public string GetNotificationChannelId(AndroidJavaObject notification) { }

	// RVA: 0x8534F30 Offset: 0x8530F30 VA: 0x8534F30
	public void RegisterNotificationChannelGroup(AndroidNotificationChannelGroup group) { }

	// RVA: 0x8535074 Offset: 0x8531074 VA: 0x8535074
	public void RegisterNotificationChannel(AndroidNotificationChannel channel) { }

	// RVA: 0x853542C Offset: 0x853142C VA: 0x853542C
	public AndroidJavaObject[] GetNotificationChannels() { }

	// RVA: 0x85354FC Offset: 0x85314FC VA: 0x85354FC
	public void DeleteNotificationChannelGroup(string id) { }

	// RVA: 0x85355CC Offset: 0x85315CC VA: 0x85355CC
	public void DeleteNotificationChannel(string channelId) { }

	// RVA: 0x853569C Offset: 0x853169C VA: 0x853569C
	public int ScheduleNotification(AndroidJavaObject notificationBuilder, bool customized) { }

	// RVA: 0x85357E0 Offset: 0x85317E0 VA: 0x85357E0
	public bool CheckIfPendingNotificationIsRegistered(int id) { }

	// RVA: 0x85358FC Offset: 0x85318FC VA: 0x85358FC
	public void CancelPendingNotification(int id) { }

	// RVA: 0x8535A00 Offset: 0x8531A00 VA: 0x8535A00
	public void CancelDisplayedNotification(int id) { }

	// RVA: 0x8535B04 Offset: 0x8531B04 VA: 0x8535B04
	public void CancelAllPendingNotificationIntents() { }

	// RVA: 0x8535BC0 Offset: 0x8531BC0 VA: 0x8535BC0
	public void CancelAllNotifications() { }

	// RVA: 0x8535C7C Offset: 0x8531C7C VA: 0x8535C7C
	public int CheckNotificationStatus(int id) { }

	// RVA: 0x8535D94 Offset: 0x8531D94 VA: 0x8535D94
	public void ShowNotificationSettings(string channelId) { }

	// RVA: 0x8535E64 Offset: 0x8531E64 VA: 0x8535E64
	public AndroidJavaObject CreateNotificationBuilder(string channelId) { }

	// RVA: 0x8535F38 Offset: 0x8531F38 VA: 0x8535F38
	public void SetupBigPictureStyle(AndroidJavaObject builder, BigPictureStyle bigPicture) { }

	// RVA: 0x8536190 Offset: 0x8532190 VA: 0x8536190
	public bool CanScheduleExactAlarms() { }

	// RVA: 0x8536260 Offset: 0x8532260 VA: 0x8536260
	public PermissionStatus AreNotificationsEnabled() { }
}

// Namespace: Unity.Notifications.Android
internal struct NotificationJni // TypeDefIndex: 27924
{
	// Fields
	public AndroidJavaObject EXTRA_TITLE; // 0x0
	public AndroidJavaObject EXTRA_TEXT; // 0x8
	public AndroidJavaObject EXTRA_SHOW_CHRONOMETER; // 0x10
	public AndroidJavaObject EXTRA_BIG_TEXT; // 0x18
	public AndroidJavaObject EXTRA_SHOW_WHEN; // 0x20
	public int FLAG_AUTO_CANCEL; // 0x28
	public int FLAG_GROUP_SUMMARY; // 0x2C
	private IntPtr getGroup; // 0x30
	private IntPtr getSortKey; // 0x38
	private IntPtr extras; // 0x40
	private IntPtr flags; // 0x48
	private IntPtr number; // 0x50
	private IntPtr when; // 0x58

	// Methods

	// RVA: 0x8536330 Offset: 0x8532330 VA: 0x8536330
	public void CollectJni() { }

	// RVA: 0x85364F0 Offset: 0x85324F0 VA: 0x85364F0
	private void CollectConstants(AndroidJavaClass clazz) { }

	// RVA: 0x85366C4 Offset: 0x85326C4 VA: 0x85366C4
	private void CollectMethods(AndroidJavaClass clazz) { }

	// RVA: 0x8536770 Offset: 0x8532770 VA: 0x8536770
	private void CollectFields(AndroidJavaClass clazz) { }

	// RVA: 0x8536A04 Offset: 0x8532A04 VA: 0x8536A04
	public AndroidJavaObject Extras(AndroidJavaObject notification) { }

	// RVA: 0x8536A5C Offset: 0x8532A5C VA: 0x8536A5C
	public int Flags(AndroidJavaObject notification) { }

	// RVA: 0x8536AB4 Offset: 0x8532AB4 VA: 0x8536AB4
	public int Number(AndroidJavaObject notification) { }

	// RVA: 0x8536B0C Offset: 0x8532B0C VA: 0x8536B0C
	public string GetGroup(AndroidJavaObject notification) { }

	// RVA: 0x8536BD4 Offset: 0x8532BD4 VA: 0x8536BD4
	public string GetSortKey(AndroidJavaObject notification) { }

	// RVA: 0x8536C9C Offset: 0x8532C9C VA: 0x8536C9C
	internal long When(AndroidJavaObject notification) { }
}

// Namespace: Unity.Notifications.Android
internal struct NotificationBuilderJni // TypeDefIndex: 27925
{
	// Fields
	private IntPtr getExtras; // 0x0
	private IntPtr setContentTitle; // 0x8
	private IntPtr setContentText; // 0x10
	private IntPtr setAutoCancel; // 0x18
	private IntPtr setNumber; // 0x20
	private IntPtr setStyle; // 0x28
	private IntPtr setWhen; // 0x30
	private IntPtr setGroup; // 0x38
	private IntPtr setGroupSummary; // 0x40
	private IntPtr setSortKey; // 0x48
	private IntPtr setShowWhen; // 0x50

	// Methods

	// RVA: 0x8536CF4 Offset: 0x8532CF4 VA: 0x8536CF4
	public void CollectJni() { }

	// RVA: 0x8537128 Offset: 0x8533128 VA: 0x8537128
	public AndroidJavaObject GetExtras(AndroidJavaObject builder) { }

	// RVA: 0x85371F0 Offset: 0x85331F0 VA: 0x85371F0
	public void SetContentTitle(AndroidJavaObject builder, string title) { }

	// RVA: 0x85372D0 Offset: 0x85332D0 VA: 0x85372D0
	public void SetContentText(AndroidJavaObject builder, string text) { }

	// RVA: 0x85373B0 Offset: 0x85333B0 VA: 0x85373B0
	public void SetAutoCancel(AndroidJavaObject builder, bool shouldAutoCancel) { }

	// RVA: 0x85374C8 Offset: 0x85334C8 VA: 0x85374C8
	public void SetNumber(AndroidJavaObject builder, int number) { }

	// RVA: 0x85375DC Offset: 0x85335DC VA: 0x85375DC
	public void SetStyle(AndroidJavaObject builder, AndroidJavaObject style) { }

	// RVA: 0x85376BC Offset: 0x85336BC VA: 0x85376BC
	public void SetWhen(AndroidJavaObject builder, long timestamp) { }

	// RVA: 0x85377D0 Offset: 0x85337D0 VA: 0x85377D0
	public void SetGroup(AndroidJavaObject builder, string group) { }

	// RVA: 0x85378B0 Offset: 0x85338B0 VA: 0x85378B0
	public void SetGroupSummary(AndroidJavaObject builder, bool groupSummary) { }

	// RVA: 0x85379C8 Offset: 0x85339C8 VA: 0x85379C8
	public void SetSortKey(AndroidJavaObject builder, string sortKey) { }

	// RVA: 0x8537AA8 Offset: 0x8533AA8 VA: 0x8537AA8
	public void SetShowWhen(AndroidJavaObject builder, bool showTimestamp) { }
}

// Namespace: Unity.Notifications.Android
internal struct BundleJni // TypeDefIndex: 27926
{
	// Fields
	private IntPtr containsKey; // 0x0
	private IntPtr getBoolean; // 0x8
	private IntPtr getInt; // 0x10
	private IntPtr getLong; // 0x18
	private IntPtr getString; // 0x20
	private IntPtr putBoolean; // 0x28
	private IntPtr putInt; // 0x30
	private IntPtr putLong; // 0x38
	private IntPtr putString; // 0x40

	// Methods

	// RVA: 0x8537BC0 Offset: 0x8533BC0 VA: 0x8537BC0
	public void CollectJni() { }

	// RVA: 0x8537FBC Offset: 0x8533FBC VA: 0x8537FBC
	public bool ContainsKey(AndroidJavaObject bundle, AndroidJavaObject key) { }

	// RVA: 0x8538090 Offset: 0x8534090 VA: 0x8538090
	public bool GetBoolean(AndroidJavaObject bundle, AndroidJavaObject key, bool defaultValue) { }

	// RVA: 0x85381D8 Offset: 0x85341D8 VA: 0x85381D8
	public bool GetBoolean(AndroidJavaObject bundle, string key, bool defaultValue) { }

	// RVA: 0x8538320 Offset: 0x8534320 VA: 0x8538320
	public int GetInt(AndroidJavaObject bundle, AndroidJavaObject key, int defaultValue) { }

	// RVA: 0x8538460 Offset: 0x8534460 VA: 0x8538460
	public long GetLong(AndroidJavaObject bundle, AndroidJavaObject key, long defaultValue) { }

	// RVA: 0x85385A0 Offset: 0x85345A0 VA: 0x85385A0
	public string GetString(AndroidJavaObject bundle, AndroidJavaObject key) { }

	// RVA: 0x8538674 Offset: 0x8534674 VA: 0x8538674
	public string GetString(AndroidJavaObject bundle, string key) { }

	// RVA: 0x8538748 Offset: 0x8534748 VA: 0x8538748
	public void PutBoolean(AndroidJavaObject bundle, AndroidJavaObject key, bool value) { }

	// RVA: 0x8538878 Offset: 0x8534878 VA: 0x8538878
	public void PutInt(AndroidJavaObject bundle, AndroidJavaObject key, int value) { }

	// RVA: 0x85389A4 Offset: 0x85349A4 VA: 0x85389A4
	public void PutLong(AndroidJavaObject bundle, AndroidJavaObject key, long value) { }

	// RVA: 0x8538AD0 Offset: 0x8534AD0 VA: 0x8538AD0
	public void PutString(AndroidJavaObject bundle, AndroidJavaObject key, string value) { }
}

// Namespace: Unity.Notifications.Android
internal struct JniApi // TypeDefIndex: 27927
{
	// Fields
	public NotificationManagerJni NotificationManager; // 0x0
	public NotificationJni Notification; // 0xD0
	public NotificationBuilderJni NotificationBuilder; // 0x130
	public BundleJni Bundle; // 0x188

	// Methods

	// RVA: 0x8538BD0 Offset: 0x8534BD0 VA: 0x8538BD0
	public void .ctor(AndroidJavaClass notificationManagerClass, AndroidJavaObject notificationManager) { }

	// RVA: 0x85368AC Offset: 0x85328AC VA: 0x85368AC
	public static IntPtr FindField(AndroidJavaClass clazz, string name, string signature, bool isStatic) { }

	// RVA: 0x8534388 Offset: 0x8530388 VA: 0x8534388
	public static IntPtr FindMethod(AndroidJavaClass clazz, string name, string signature, bool isStatic) { }
}

// Namespace: 
public sealed class AndroidNotificationCenter.NotificationReceivedCallback : MulticastDelegate // TypeDefIndex: 27928
{
	// Methods

	// RVA: 0x853D658 Offset: 0x8539658 VA: 0x853D658
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x853D760 Offset: 0x8539760 VA: 0x853D760 Slot: 13
	public virtual void Invoke(AndroidNotificationIntentData data) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AndroidNotificationCenter.<>c // TypeDefIndex: 27929
{
	// Fields
	public static readonly AndroidNotificationCenter.<>c <>9; // 0x0

	// Methods

	// RVA: 0x853D774 Offset: 0x8539774 VA: 0x853D774
	private static void .cctor() { }

	// RVA: 0x853D7DC Offset: 0x85397DC VA: 0x853D7DC
	public void .ctor() { }

	// RVA: 0x853D7E4 Offset: 0x85397E4 VA: 0x853D7E4
	internal void <.cctor>b__55_0(AndroidNotificationIntentData <p0>) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AndroidNotificationCenter.<>c__DisplayClass31_0 // TypeDefIndex: 27930
{
	// Fields
	public string channelId; // 0x10

	// Methods

	// RVA: 0x853AA8C Offset: 0x8536A8C VA: 0x853AA8C
	public void .ctor() { }

	// RVA: 0x853D7E8 Offset: 0x85397E8 VA: 0x853D7E8
	internal bool <GetNotificationChannel>b__0(AndroidNotificationChannel channel) { }
}

// Namespace: Unity.Notifications.Android
public class AndroidNotificationCenter // TypeDefIndex: 27931
{
	// Fields
	private static int API_NOTIFICATIONS_CAN_BE_BLOCKED; // 0x0
	private static int API_POST_NOTIFICATIONS_PERMISSION_REQUIRED; // 0x4
	internal static string PERMISSION_POST_NOTIFICATIONS; // 0x8
	public static string SETTING_POST_NOTIFICATIONS_PERMISSION; // 0x10
	[CompilerGenerated]
	private static AndroidNotificationCenter.NotificationReceivedCallback OnNotificationReceived; // 0x18
	private static AndroidJavaObject s_CurrentActivity; // 0x20
	private static JniApi s_Jni; // 0x28
	private static int s_DeviceApiLevel; // 0x1F8
	private static int s_TargetApiLevel; // 0x1FC
	private static bool s_Initialized; // 0x200

	// Properties
	public static PermissionStatus UserPermissionToPost { get; }
	internal static bool CanRequestPermissionToPost { get; }
	public static bool ShouldShowPermissionToPostRationale { get; }
	public static bool UsingExactScheduling { get; }
	public static bool IgnoringBatteryOptimizations { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8538C8C Offset: 0x8534C8C VA: 0x8538C8C
	public static void add_OnNotificationReceived(AndroidNotificationCenter.NotificationReceivedCallback value) { }

	[CompilerGenerated]
	// RVA: 0x8538D68 Offset: 0x8534D68 VA: 0x8538D68
	public static void remove_OnNotificationReceived(AndroidNotificationCenter.NotificationReceivedCallback value) { }

	// RVA: 0x8538E44 Offset: 0x8534E44 VA: 0x8538E44
	public static bool Initialize() { }

	// RVA: 0x8539588 Offset: 0x8535588 VA: 0x8539588
	internal static void SetPostPermissionSetting(PermissionStatus status) { }

	// RVA: 0x85395EC Offset: 0x85355EC VA: 0x85395EC
	public static PermissionStatus get_UserPermissionToPost() { }

	// RVA: 0x8539748 Offset: 0x8535748 VA: 0x8539748
	internal static bool get_CanRequestPermissionToPost() { }

	// RVA: 0x85397CC Offset: 0x85357CC VA: 0x85397CC
	public static bool get_ShouldShowPermissionToPostRationale() { }

	// RVA: 0x8539918 Offset: 0x8535918 VA: 0x8539918
	public static bool get_UsingExactScheduling() { }

	// RVA: 0x8539998 Offset: 0x8535998 VA: 0x8539998
	public static void RequestExactScheduling() { }

	// RVA: 0x8539A40 Offset: 0x8535A40 VA: 0x8539A40
	private static void StartActionForThisPackage(string action) { }

	// RVA: 0x853A174 Offset: 0x8536174 VA: 0x853A174
	public static bool get_IgnoringBatteryOptimizations() { }

	// RVA: 0x853A588 Offset: 0x8536588 VA: 0x853A588
	public static void RequestIgnoreBatteryOptimizations() { }

	// RVA: 0x853A630 Offset: 0x8536630 VA: 0x853A630
	public static void RegisterNotificationChannelGroup(AndroidNotificationChannelGroup group) { }

	// RVA: 0x853A74C Offset: 0x853674C VA: 0x853A74C
	public static void DeleteNotificationChannelGroup(string id) { }

	// RVA: 0x853A7D0 Offset: 0x85367D0 VA: 0x853A7D0
	public static void RegisterNotificationChannel(AndroidNotificationChannel channel) { }

	// RVA: 0x853A94C Offset: 0x853694C VA: 0x853A94C
	public static AndroidNotificationChannel GetNotificationChannel(string channelId) { }

	// RVA: 0x853AA94 Offset: 0x8536A94 VA: 0x853AA94
	public static AndroidNotificationChannel[] GetNotificationChannels() { }

	// RVA: 0x853B088 Offset: 0x8537088 VA: 0x853B088
	public static void DeleteNotificationChannel(string channelId) { }

	// RVA: 0x853B10C Offset: 0x853710C VA: 0x853B10C
	public static int SendNotification(AndroidNotification notification, string channelId) { }

	// RVA: 0x853B43C Offset: 0x853743C VA: 0x853B43C
	public static void SendNotificationWithExplicitID(AndroidNotification notification, string channelId, int id) { }

	// RVA: 0x853B738 Offset: 0x8537738 VA: 0x853B738
	public static void SendNotification(AndroidJavaObject notificationBuilder) { }

	// RVA: 0x853B7B4 Offset: 0x85377B4 VA: 0x853B7B4
	public static void SendNotification(AndroidJavaObject notificationBuilder, out int id) { }

	// RVA: 0x853B3CC Offset: 0x85373CC VA: 0x853B3CC
	private static int ScheduleNotification(AndroidJavaObject notificationBuilder, bool customized) { }

	// RVA: 0x853B840 Offset: 0x8537840 VA: 0x853B840
	public static void UpdateScheduledNotification(int id, AndroidNotification notification, string channelId) { }

	// RVA: 0x853BA70 Offset: 0x8537A70 VA: 0x853BA70
	public static void CancelNotification(int id) { }

	// RVA: 0x853BAF0 Offset: 0x8537AF0 VA: 0x853BAF0
	public static void CancelScheduledNotification(int id) { }

	// RVA: 0x853BB74 Offset: 0x8537B74 VA: 0x853BB74
	public static void CancelDisplayedNotification(int id) { }

	// RVA: 0x853BBF8 Offset: 0x8537BF8 VA: 0x853BBF8
	public static void CancelAllNotifications() { }

	// RVA: 0x853BC6C Offset: 0x8537C6C VA: 0x853BC6C
	public static void CancelAllScheduledNotifications() { }

	// RVA: 0x853BCE8 Offset: 0x8537CE8 VA: 0x853BCE8
	public static void CancelAllDisplayedNotifications() { }

	// RVA: 0x853BD64 Offset: 0x8537D64 VA: 0x853BD64
	public static NotificationStatus CheckScheduledNotificationStatus(int id) { }

	// RVA: 0x853BDEC Offset: 0x8537DEC VA: 0x853BDEC
	public static AndroidNotificationIntentData GetLastNotificationIntent() { }

	// RVA: 0x853C764 Offset: 0x8538764 VA: 0x853C764
	public static void OpenNotificationSettings(string channelId) { }

	// RVA: 0x853B31C Offset: 0x853731C VA: 0x853B31C
	public static AndroidJavaObject CreateNotificationBuilder(AndroidNotification notification, string channelId) { }

	// RVA: 0x853B644 Offset: 0x8537644 VA: 0x853B644
	public static AndroidJavaObject CreateNotificationBuilder(int id, AndroidNotification notification, string channelId) { }

	// RVA: 0x853C7E8 Offset: 0x85387E8 VA: 0x853C7E8
	private static void CreateNotificationBuilder(AndroidNotification notification, string channelId, out AndroidJavaObject notificationBuilder, out AndroidJavaObject extras) { }

	// RVA: 0x853BF40 Offset: 0x8537F40 VA: 0x853BF40
	internal static AndroidNotificationIntentData GetNotificationData(AndroidJavaObject notificationObj) { }

	// RVA: 0x853D4A4 Offset: 0x85394A4 VA: 0x853D4A4
	internal static void ReceivedNotificationCallback(AndroidJavaObject notification) { }

	// RVA: 0x853D520 Offset: 0x8539520 VA: 0x853D520
	public void .ctor() { }

	// RVA: 0x853D528 Offset: 0x8539528 VA: 0x853D528
	private static void .cctor() { }
}

// Namespace: Unity.Notifications.Android
public enum Importance // TypeDefIndex: 27932
{
	// Fields
	public int value__; // 0x0
	public const Importance None = 0;
	public const Importance Low = 2;
	public const Importance Default = 3;
	public const Importance High = 4;
}

// Namespace: Unity.Notifications.Android
public enum LockScreenVisibility // TypeDefIndex: 27933
{
	// Fields
	public int value__; // 0x0
	public const LockScreenVisibility Secret = -1;
	public const LockScreenVisibility Private = 0;
	public const LockScreenVisibility Public = 1;
}

// Namespace: Unity.Notifications.Android
public struct AndroidNotificationChannel // TypeDefIndex: 27934
{
	// Fields
	[CompilerGenerated]
	private string <Id>k__BackingField; // 0x0
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x8
	[CompilerGenerated]
	private string <Description>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Group>k__BackingField; // 0x18
	[CompilerGenerated]
	private Importance <Importance>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <CanBypassDnd>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <CanShowBadge>k__BackingField; // 0x25
	[CompilerGenerated]
	private bool <EnableLights>k__BackingField; // 0x26
	[CompilerGenerated]
	private bool <EnableVibration>k__BackingField; // 0x27
	[CompilerGenerated]
	private long[] <VibrationPattern>k__BackingField; // 0x28
	[CompilerGenerated]
	private LockScreenVisibility <LockScreenVisibility>k__BackingField; // 0x30

	// Properties
	public string Id { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public string Group { get; set; }
	public Importance Importance { get; set; }
	public bool CanBypassDnd { get; set; }
	public bool CanShowBadge { get; set; }
	public bool EnableLights { get; set; }
	public bool EnableVibration { get; set; }
	public long[] VibrationPattern { get; set; }
	public LockScreenVisibility LockScreenVisibility { get; set; }
	public bool Enabled { get; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x853D7FC Offset: 0x85397FC VA: 0x853D7FC
	public string get_Id() { }

	[CompilerGenerated]
	// RVA: 0x853D804 Offset: 0x8539804 VA: 0x853D804
	public void set_Id(string value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x853D80C Offset: 0x853980C VA: 0x853D80C
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x853D814 Offset: 0x8539814 VA: 0x853D814
	public void set_Name(string value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x853D81C Offset: 0x853981C VA: 0x853D81C
	public string get_Description() { }

	[CompilerGenerated]
	// RVA: 0x853D824 Offset: 0x8539824 VA: 0x853D824
	public void set_Description(string value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x853D82C Offset: 0x853982C VA: 0x853D82C
	public string get_Group() { }

	[CompilerGenerated]
	// RVA: 0x853D834 Offset: 0x8539834 VA: 0x853D834
	public void set_Group(string value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x853D83C Offset: 0x853983C VA: 0x853D83C
	public Importance get_Importance() { }

	[CompilerGenerated]
	// RVA: 0x853D844 Offset: 0x8539844 VA: 0x853D844
	public void set_Importance(Importance value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x853D84C Offset: 0x853984C VA: 0x853D84C
	public bool get_CanBypassDnd() { }

	[CompilerGenerated]
	// RVA: 0x853D854 Offset: 0x8539854 VA: 0x853D854
	public void set_CanBypassDnd(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x853D860 Offset: 0x8539860 VA: 0x853D860
	public bool get_CanShowBadge() { }

	[CompilerGenerated]
	// RVA: 0x853D868 Offset: 0x8539868 VA: 0x853D868
	public void set_CanShowBadge(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x853D874 Offset: 0x8539874 VA: 0x853D874
	public bool get_EnableLights() { }

	[CompilerGenerated]
	// RVA: 0x853D87C Offset: 0x853987C VA: 0x853D87C
	public void set_EnableLights(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x853D888 Offset: 0x8539888 VA: 0x853D888
	public bool get_EnableVibration() { }

	[CompilerGenerated]
	// RVA: 0x853D890 Offset: 0x8539890 VA: 0x853D890
	public void set_EnableVibration(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x853D89C Offset: 0x853989C VA: 0x853D89C
	public long[] get_VibrationPattern() { }

	[CompilerGenerated]
	// RVA: 0x853D8A4 Offset: 0x85398A4 VA: 0x853D8A4
	public void set_VibrationPattern(long[] value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x853D8AC Offset: 0x85398AC VA: 0x853D8AC
	public LockScreenVisibility get_LockScreenVisibility() { }

	[CompilerGenerated]
	// RVA: 0x853D8B4 Offset: 0x85398B4 VA: 0x853D8B4
	public void set_LockScreenVisibility(LockScreenVisibility value) { }

	// RVA: 0x853D8BC Offset: 0x85398BC VA: 0x853D8BC
	public bool get_Enabled() { }

	// RVA: 0x853D8CC Offset: 0x85398CC VA: 0x853D8CC
	public void .ctor(string id, string name, string description, Importance importance) { }
}

// Namespace: Unity.Notifications.Android
public struct AndroidNotificationChannelGroup // TypeDefIndex: 27935
{
	// Fields
	[CompilerGenerated]
	private string <Id>k__BackingField; // 0x0
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x8
	[CompilerGenerated]
	private string <Description>k__BackingField; // 0x10

	// Properties
	public string Id { get; }
	public string Name { get; }
	public string Description { get; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x853D950 Offset: 0x8539950 VA: 0x853D950
	public string get_Id() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x853D958 Offset: 0x8539958 VA: 0x853D958
	public string get_Name() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x853D960 Offset: 0x8539960 VA: 0x853D960
	public string get_Description() { }
}

// Namespace: Unity.Notifications.Android
[Extension]
internal static class AndroidNotificationExtensions // TypeDefIndex: 27936
{
	// Methods

	[Extension]
	// RVA: 0x853AEB4 Offset: 0x8536EB4 VA: 0x853AEB4
	public static Importance ToImportance(int importance) { }

	[Extension]
	// RVA: 0x853AFA0 Offset: 0x8536FA0 VA: 0x853AFA0
	public static LockScreenVisibility ToLockScreenVisibility(int lockscreenVisibility) { }

	[Extension]
	// RVA: 0x853D358 Offset: 0x8539358 VA: 0x853D358
	public static GroupAlertBehaviours ToGroupAlertBehaviours(int groupAlertBehaviour) { }

	[Extension]
	// RVA: 0x8534AE4 Offset: 0x8530AE4 VA: 0x8534AE4
	public static Color ToColor(int color) { }

	[Extension]
	// RVA: 0x853D210 Offset: 0x8539210 VA: 0x853D210
	public static int ToInt(Nullable<Color> color) { }

	[Extension]
	// RVA: 0x853D0E8 Offset: 0x85390E8 VA: 0x853D0E8
	public static long ToLong(DateTime dateTime) { }

	[Extension]
	// RVA: 0x85338F8 Offset: 0x852F8F8 VA: 0x85338F8
	public static DateTime ToDatetime(long dateTime) { }

	[Extension]
	// RVA: 0x853D290 Offset: 0x8539290 VA: 0x853D290
	public static long ToLong(Nullable<TimeSpan> timeSpan) { }

	[Extension]
	// RVA: 0x85334BC Offset: 0x852F4BC VA: 0x85334BC
	public static TimeSpan ToTimeSpan(long timeSpan) { }
}

// Namespace: Unity.Notifications.Android
public class AndroidNotificationIntentData // TypeDefIndex: 27937
{
	// Fields
	[CompilerGenerated]
	private readonly int <Id>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <Channel>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly AndroidNotification <Notification>k__BackingField; // 0x20
	[CompilerGenerated]
	private AndroidJavaObject <NativeNotification>k__BackingField; // 0xE0

	// Properties
	internal AndroidJavaObject NativeNotification { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x853D968 Offset: 0x8539968 VA: 0x853D968
	internal void set_NativeNotification(AndroidJavaObject value) { }

	// RVA: 0x853D440 Offset: 0x8539440 VA: 0x853D440
	public void .ctor(int id, string channelId, AndroidNotification notification) { }
}

// Namespace: Unity.Notifications.Android
public class AndroidReceivedNotificationMainThreadDispatcher : MonoBehaviour // TypeDefIndex: 27938
{
	// Fields
	private static AndroidReceivedNotificationMainThreadDispatcher instance; // 0x0
	private List<AndroidJavaObject> m_ReceivedNotificationQueue; // 0x20
	private List<AndroidJavaObject> m_ReceivedNotificationList; // 0x28

	// Methods

	// RVA: 0x8533BE0 Offset: 0x852FBE0 VA: 0x8533BE0
	internal void EnqueueReceivedNotification(AndroidJavaObject notification) { }

	// RVA: 0x853D970 Offset: 0x8539970 VA: 0x853D970
	internal static AndroidReceivedNotificationMainThreadDispatcher GetInstance() { }

	// RVA: 0x853D9B8 Offset: 0x85399B8 VA: 0x853D9B8
	public void Update() { }

	// RVA: 0x853DD10 Offset: 0x8539D10 VA: 0x853DD10
	private void Awake() { }

	// RVA: 0x853DDF4 Offset: 0x8539DF4 VA: 0x853DDF4
	private void OnDestroy() { }

	// RVA: 0x853DE48 Offset: 0x8539E48 VA: 0x853DE48
	public void .ctor() { }
}

// Namespace: Unity.Notifications.Android
public enum PermissionStatus // TypeDefIndex: 27939
{
	// Fields
	public int value__; // 0x0
	public const PermissionStatus NotRequested = 0;
	public const PermissionStatus Allowed = 1;
	public const PermissionStatus Denied = 2;
	public const PermissionStatus DeniedDontAskAgain = 3;
	public const PermissionStatus RequestPending = 4;
	public const PermissionStatus NotificationsBlockedForApp = 5;
}


// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 26490
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 26491
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
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 26492
{
	// Methods

	// RVA: 0x7FB2CD0 Offset: 0x7FAECD0 VA: 0x7FB2CD0
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x7FB2DC8 Offset: 0x7FAEDC8 VA: 0x7FB2DC8
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ClickEventListener : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 26493
{
	// Fields
	private Action<GameObject> mClickedHandler; // 0x20
	private Action<GameObject> mDoubleClickedHandler; // 0x28
	private Action<GameObject> mOnPointerDownHandler; // 0x30
	private Action<GameObject> mOnPointerUpHandler; // 0x38
	private bool mIsPressed; // 0x40

	// Properties
	public bool IsPressd { get; }

	// Methods

	// RVA: 0x7FB2DD0 Offset: 0x7FAEDD0 VA: 0x7FB2DD0
	public static ClickEventListener Get(GameObject obj) { }

	// RVA: 0x7FB2E90 Offset: 0x7FAEE90 VA: 0x7FB2E90
	public bool get_IsPressd() { }

	// RVA: 0x7FB2E98 Offset: 0x7FAEE98 VA: 0x7FB2E98 Slot: 4
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x7FB2EEC Offset: 0x7FAEEEC VA: 0x7FB2EEC
	public void SetClickEventHandler(Action<GameObject> handler) { }

	// RVA: 0x7FB2EF4 Offset: 0x7FAEEF4 VA: 0x7FB2EF4
	public void SetDoubleClickEventHandler(Action<GameObject> handler) { }

	// RVA: 0x7FB2EFC Offset: 0x7FAEEFC VA: 0x7FB2EFC
	public void SetPointerDownHandler(Action<GameObject> handler) { }

	// RVA: 0x7FB2F04 Offset: 0x7FAEF04 VA: 0x7FB2F04
	public void SetPointerUpHandler(Action<GameObject> handler) { }

	// RVA: 0x7FB2F0C Offset: 0x7FAEF0C VA: 0x7FB2F0C Slot: 5
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x7FB2F4C Offset: 0x7FAEF4C VA: 0x7FB2F4C Slot: 6
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x7FB2F88 Offset: 0x7FAEF88 VA: 0x7FB2F88
	public void .ctor() { }
}

// Namespace: SuperScrollView
public enum SnapStatus // TypeDefIndex: 26494
{
	// Fields
	public int value__; // 0x0
	public const SnapStatus NoTargetSet = 0;
	public const SnapStatus TargetHasSet = 1;
	public const SnapStatus SnapMoving = 2;
	public const SnapStatus SnapMoveFinish = 3;
}

// Namespace: SuperScrollView
public enum ItemCornerEnum // TypeDefIndex: 26495
{
	// Fields
	public int value__; // 0x0
	public const ItemCornerEnum LeftBottom = 0;
	public const ItemCornerEnum LeftTop = 1;
	public const ItemCornerEnum RightTop = 2;
	public const ItemCornerEnum RightBottom = 3;
}

// Namespace: SuperScrollView
public enum ListItemArrangeType // TypeDefIndex: 26496
{
	// Fields
	public int value__; // 0x0
	public const ListItemArrangeType TopToBottom = 0;
	public const ListItemArrangeType BottomToTop = 1;
	public const ListItemArrangeType LeftToRight = 2;
	public const ListItemArrangeType RightToLeft = 3;
}

// Namespace: SuperScrollView
public enum GridItemArrangeType // TypeDefIndex: 26497
{
	// Fields
	public int value__; // 0x0
	public const GridItemArrangeType TopLeftToBottomRight = 0;
	public const GridItemArrangeType BottomLeftToTopRight = 1;
	public const GridItemArrangeType TopRightToBottomLeft = 2;
	public const GridItemArrangeType BottomRightToTopLeft = 3;
}

// Namespace: SuperScrollView
public enum GridFixedType // TypeDefIndex: 26498
{
	// Fields
	public int value__; // 0x0
	public const GridFixedType ColumnCountFixed = 0;
	public const GridFixedType RowCountFixed = 1;
}

// Namespace: SuperScrollView
public struct RowColumnPair // TypeDefIndex: 26499
{
	// Fields
	public int mRow; // 0x0
	public int mColumn; // 0x4

	// Methods

	// RVA: 0x7FB2F90 Offset: 0x7FAEF90 VA: 0x7FB2F90
	public void .ctor(int row1, int column1) { }

	// RVA: 0x7FB2F98 Offset: 0x7FAEF98 VA: 0x7FB2F98
	public bool Equals(RowColumnPair other) { }

	// RVA: 0x7FB2FC0 Offset: 0x7FAEFC0 VA: 0x7FB2FC0
	public static bool op_Equality(RowColumnPair a, RowColumnPair b) { }

	// RVA: 0x7FB2FE0 Offset: 0x7FAEFE0 VA: 0x7FB2FE0
	public static bool op_Inequality(RowColumnPair a, RowColumnPair b) { }

	// RVA: 0x7FB3000 Offset: 0x7FAF000 VA: 0x7FB3000 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x7FB3008 Offset: 0x7FAF008 VA: 0x7FB3008 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: SuperScrollView
public class ItemSizeGroup // TypeDefIndex: 26500
{
	// Fields
	public float[] mItemSizeArray; // 0x10
	public float[] mItemStartPosArray; // 0x18
	public int mItemCount; // 0x20
	private int mDirtyBeginIndex; // 0x24
	public float mGroupSize; // 0x28
	public float mGroupStartPos; // 0x2C
	public float mGroupEndPos; // 0x30
	public int mGroupIndex; // 0x34
	private float mItemDefaultSize; // 0x38
	private int mMaxNoZeroIndex; // 0x3C

	// Properties
	public bool IsDirty { get; }

	// Methods

	// RVA: 0x7FB3090 Offset: 0x7FAF090 VA: 0x7FB3090
	public void .ctor(int index, float itemDefaultSize) { }

	// RVA: 0x7FB30D4 Offset: 0x7FAF0D4 VA: 0x7FB30D4
	public void Init() { }

	// RVA: 0x7FB31EC Offset: 0x7FAF1EC VA: 0x7FB31EC
	public float GetItemStartPos(int index) { }

	// RVA: 0x7FB3224 Offset: 0x7FAF224 VA: 0x7FB3224
	public bool get_IsDirty() { }

	// RVA: 0x7FB3234 Offset: 0x7FAF234 VA: 0x7FB3234
	public float SetItemSize(int index, float size) { }

	// RVA: 0x7FB32B0 Offset: 0x7FAF2B0 VA: 0x7FB32B0
	public void SetItemCount(int count) { }

	// RVA: 0x7FB32D8 Offset: 0x7FAF2D8 VA: 0x7FB32D8
	public void RecalcGroupSize() { }

	// RVA: 0x7FB3334 Offset: 0x7FAF334 VA: 0x7FB3334
	public int GetItemIndexByPos(float pos) { }

	// RVA: 0x7FB3410 Offset: 0x7FAF410 VA: 0x7FB3410
	public void UpdateAllItemStartPos() { }

	// RVA: 0x7FB34A8 Offset: 0x7FAF4A8 VA: 0x7FB34A8
	public void ClearOldData() { }
}

// Namespace: SuperScrollView
public class ItemPosMgr // TypeDefIndex: 26501
{
	// Fields
	public const int mItemMaxCountPerGroup = 100;
	private List<ItemSizeGroup> mItemSizeGroupList; // 0x10
	private int mDirtyBeginIndex; // 0x18
	public float mTotalSize; // 0x1C
	public float mItemDefaultSize; // 0x20
	private int mMaxNotEmptyGroupIndex; // 0x24

	// Methods

	// RVA: 0x7FB34F8 Offset: 0x7FAF4F8 VA: 0x7FB34F8
	public void .ctor(float itemDefaultSize) { }

	// RVA: 0x7FB35A4 Offset: 0x7FAF5A4 VA: 0x7FB35A4
	public void SetItemMaxCount(int maxCount) { }

	// RVA: 0x7FB3898 Offset: 0x7FAF898 VA: 0x7FB3898
	public void SetItemSize(int itemIndex, float size) { }

	// RVA: 0x7FB3968 Offset: 0x7FAF968 VA: 0x7FB3968
	public float GetItemPos(int itemIndex) { }

	// RVA: 0x7FB3B18 Offset: 0x7FAFB18 VA: 0x7FB3B18
	public bool GetItemIndexAndPosAtGivenPos(float pos, ref int index, ref float itemPos) { }

	// RVA: 0x7FB39F4 Offset: 0x7FAF9F4 VA: 0x7FB39F4
	public void Update(bool updateAll) { }
}

// Namespace: SuperScrollView
public class GridItemGroup // TypeDefIndex: 26502
{
	// Fields
	private int mCount; // 0x10
	private int mGroupIndex; // 0x14
	private LoopGridViewItem mFirst; // 0x18
	private LoopGridViewItem mLast; // 0x20

	// Properties
	public int Count { get; }
	public LoopGridViewItem First { get; }
	public LoopGridViewItem Last { get; }
	public int GroupIndex { get; set; }

	// Methods

	// RVA: 0x7FB3CD8 Offset: 0x7FAFCD8 VA: 0x7FB3CD8
	public int get_Count() { }

	// RVA: 0x7FB3CE0 Offset: 0x7FAFCE0 VA: 0x7FB3CE0
	public LoopGridViewItem get_First() { }

	// RVA: 0x7FB3CE8 Offset: 0x7FAFCE8 VA: 0x7FB3CE8
	public LoopGridViewItem get_Last() { }

	// RVA: 0x7FB3CF0 Offset: 0x7FAFCF0 VA: 0x7FB3CF0
	public int get_GroupIndex() { }

	// RVA: 0x7FB3CF8 Offset: 0x7FAFCF8 VA: 0x7FB3CF8
	public void set_GroupIndex(int value) { }

	// RVA: 0x7FB3D00 Offset: 0x7FAFD00 VA: 0x7FB3D00
	public LoopGridViewItem GetItemByColumn(int column) { }

	// RVA: 0x7FB3D94 Offset: 0x7FAFD94 VA: 0x7FB3D94
	public LoopGridViewItem GetItemByRow(int row) { }

	// RVA: 0x7FB3E28 Offset: 0x7FAFE28 VA: 0x7FB3E28
	public void ReplaceItem(LoopGridViewItem curItem, LoopGridViewItem newItem) { }

	// RVA: 0x7FB3FB0 Offset: 0x7FAFFB0 VA: 0x7FB3FB0
	public void AddFirst(LoopGridViewItem newItem) { }

	// RVA: 0x7FB40F8 Offset: 0x7FB00F8 VA: 0x7FB40F8
	public void AddLast(LoopGridViewItem newItem) { }

	// RVA: 0x7FB4244 Offset: 0x7FB0244 VA: 0x7FB4244
	public LoopGridViewItem RemoveFirst() { }

	// RVA: 0x7FB434C Offset: 0x7FB034C VA: 0x7FB434C
	public LoopGridViewItem RemoveLast() { }

	// RVA: 0x7FB4458 Offset: 0x7FB0458 VA: 0x7FB4458
	public void Clear() { }

	// RVA: 0x7FB4520 Offset: 0x7FB0520 VA: 0x7FB4520
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class GridItemPool // TypeDefIndex: 26503
{
	// Fields
	private GameObject mPrefabObj; // 0x10
	private string mPrefabName; // 0x18
	private int mInitCreateCount; // 0x20
	private List<LoopGridViewItem> mTmpPooledItemList; // 0x28
	private List<LoopGridViewItem> mPooledItemList; // 0x30
	private static int mCurItemIdCount; // 0x0
	private RectTransform mItemParent; // 0x38

	// Methods

	// RVA: 0x7FB4530 Offset: 0x7FB0530 VA: 0x7FB4530
	public void .ctor() { }

	// RVA: 0x7FB45E4 Offset: 0x7FB05E4 VA: 0x7FB45E4
	public void Init(GameObject prefabObj, int createCount, RectTransform parent) { }

	// RVA: 0x7FB49C8 Offset: 0x7FB09C8 VA: 0x7FB49C8
	public LoopGridViewItem GetItem() { }

	// RVA: 0x7FB4B0C Offset: 0x7FB0B0C VA: 0x7FB4B0C
	public void DestroyAllItem() { }

	// RVA: 0x7FB46A0 Offset: 0x7FB06A0 VA: 0x7FB46A0
	public LoopGridViewItem CreateItem() { }

	// RVA: 0x7FB48FC Offset: 0x7FB08FC VA: 0x7FB48FC
	private void RecycleItemReal(LoopGridViewItem item) { }

	// RVA: 0x7FB4D04 Offset: 0x7FB0D04 VA: 0x7FB4D04
	public void RecycleItem(LoopGridViewItem item) { }

	// RVA: 0x7FB4C2C Offset: 0x7FB0C2C VA: 0x7FB4C2C
	public void ClearTmpRecycledItem() { }
}

// Namespace: SuperScrollView
[Serializable]
public class GridViewItemPrefabConfData // TypeDefIndex: 26504
{
	// Fields
	public GameObject mItemPrefab; // 0x10
	public int mInitCreateCount; // 0x18

	// Methods

	// RVA: 0x7FB4DD4 Offset: 0x7FB0DD4 VA: 0x7FB4DD4
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class LoopGridViewInitParam // TypeDefIndex: 26505
{
	// Fields
	public float mSmoothDumpRate; // 0x10
	public float mSnapFinishThreshold; // 0x14
	public float mSnapVecThreshold; // 0x18

	// Methods

	// RVA: 0x7FB4DDC Offset: 0x7FB0DDC VA: 0x7FB4DDC
	public static LoopGridViewInitParam CopyDefaultInitParam() { }

	// RVA: 0x7FB4E44 Offset: 0x7FB0E44 VA: 0x7FB4E44
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class LoopGridViewSettingParam // TypeDefIndex: 26506
{
	// Fields
	public object mItemSize; // 0x10
	public object mPadding; // 0x18
	public object mItemPadding; // 0x20
	public object mGridFixedType; // 0x28
	public object mFixedRowOrColumnCount; // 0x30

	// Methods

	// RVA: 0x7FB4E60 Offset: 0x7FB0E60 VA: 0x7FB4E60
	public void .ctor() { }
}

// Namespace: 
private class LoopGridView.SnapData // TypeDefIndex: 26507
{
	// Fields
	public SnapStatus mSnapStatus; // 0x10
	public RowColumnPair mSnapTarget; // 0x14
	public Vector2 mSnapNeedMoveDir; // 0x1C
	public float mTargetSnapVal; // 0x24
	public float mCurSnapVal; // 0x28
	public bool mIsForceSnapTo; // 0x2C

	// Methods

	// RVA: 0x7FB58EC Offset: 0x7FB18EC VA: 0x7FB58EC
	public void Clear() { }

	// RVA: 0x7FBA044 Offset: 0x7FB6044 VA: 0x7FBA044
	public void .ctor() { }
}

// Namespace: 
private class LoopGridView.ItemRangeData // TypeDefIndex: 26508
{
	// Fields
	public int mMaxRow; // 0x10
	public int mMinRow; // 0x14
	public int mMaxColumn; // 0x18
	public int mMinColumn; // 0x1C
	public Vector2 mCheckedPosition; // 0x20

	// Methods

	// RVA: 0x7FBA04C Offset: 0x7FB604C VA: 0x7FBA04C
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class LoopGridView : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler // TypeDefIndex: 26509
{
	// Fields
	private Dictionary<string, GridItemPool> mItemPoolDict; // 0x20
	private List<GridItemPool> mItemPoolList; // 0x28
	[SerializeField]
	private List<GridViewItemPrefabConfData> mItemPrefabDataList; // 0x30
	[SerializeField]
	private GridItemArrangeType mArrangeType; // 0x38
	private RectTransform mContainerTrans; // 0x40
	private ScrollRect mScrollRect; // 0x48
	private RectTransform mScrollRectTransform; // 0x50
	private RectTransform mViewPortRectTransform; // 0x58
	private int mItemTotalCount; // 0x60
	[SerializeField]
	private int mFixedRowOrColumnCount; // 0x64
	[SerializeField]
	private RectOffset mPadding; // 0x68
	[SerializeField]
	private Vector2 mItemPadding; // 0x70
	[SerializeField]
	private Vector2 mItemSize; // 0x78
	[SerializeField]
	private Vector2 mItemRecycleDistance; // 0x80
	private Vector2 mItemSizeWithPadding; // 0x88
	private Vector2 mStartPadding; // 0x90
	private Vector2 mEndPadding; // 0x98
	private Func<LoopGridView, int, int, int, LoopGridViewItem> mOnGetItemByRowColumn; // 0xA0
	private List<GridItemGroup> mItemGroupObjPool; // 0xA8
	private List<GridItemGroup> mItemGroupList; // 0xB0
	private bool mIsDraging; // 0xB8
	private int mRowCount; // 0xBC
	private int mColumnCount; // 0xC0
	public Action<PointerEventData> mOnBeginDragAction; // 0xC8
	public Action<PointerEventData> mOnDragingAction; // 0xD0
	public Action<PointerEventData> mOnEndDragAction; // 0xD8
	private float mSmoothDumpVel; // 0xE0
	private float mSmoothDumpRate; // 0xE4
	private float mSnapFinishThreshold; // 0xE8
	private float mSnapVecThreshold; // 0xEC
	[SerializeField]
	private bool mItemSnapEnable; // 0xF0
	[SerializeField]
	private GridFixedType mGridFixedType; // 0xF4
	public Action<LoopGridView, LoopGridViewItem> mOnSnapItemFinished; // 0xF8
	public Action<LoopGridView> mOnSnapNearestChanged; // 0x100
	private int mLeftSnapUpdateExtraCount; // 0x108
	[SerializeField]
	private Vector2 mViewPortSnapPivot; // 0x10C
	[SerializeField]
	private Vector2 mItemSnapPivot; // 0x114
	private LoopGridView.SnapData mCurSnapData; // 0x120
	private Vector3 mLastSnapCheckPos; // 0x128
	private bool mListViewInited; // 0x134
	private int mListUpdateCheckFrameCount; // 0x138
	private LoopGridView.ItemRangeData mCurFrameItemRangeData; // 0x140
	private int mNeedCheckContentPosLeftCount; // 0x148
	private ClickEventListener mScrollBarClickEventListener1; // 0x150
	private ClickEventListener mScrollBarClickEventListener2; // 0x158
	private RowColumnPair mCurSnapNearestItemRowColumn; // 0x160
	private bool mIsPointerDownInVerticalScrollBar; // 0x168
	private bool mIsPointerDownInHorizontalScrollBar; // 0x169
	private bool mNeedReplaceScrollbarEventHandler; // 0x16A
	private Vector3[] itemCorners; // 0x170
	private Vector3[] viewportCorners; // 0x178

	// Properties
	public GridItemArrangeType ArrangeType { get; set; }
	public List<GridViewItemPrefabConfData> ItemPrefabDataList { get; }
	public int ItemTotalCount { get; }
	public RectTransform ContainerTrans { get; }
	public float ViewPortWidth { get; }
	public float ViewPortHeight { get; }
	public ScrollRect ScrollRect { get; }
	public bool IsDraging { get; }
	public bool ItemSnapEnable { get; set; }
	public Vector2 ItemSize { get; set; }
	public Vector2 ItemPadding { get; set; }
	public Vector2 ItemSizeWithPadding { get; }
	public RectOffset Padding { get; set; }
	public RowColumnPair CurSnapNearestItemRowColumn { get; }
	public List<GridItemGroup> ItemGroupList { get; }

	// Methods

	// RVA: 0x7FB4E68 Offset: 0x7FB0E68 VA: 0x7FB4E68
	public GridItemArrangeType get_ArrangeType() { }

	// RVA: 0x7FB4E70 Offset: 0x7FB0E70 VA: 0x7FB4E70
	public void set_ArrangeType(GridItemArrangeType value) { }

	// RVA: 0x7FB4E78 Offset: 0x7FB0E78 VA: 0x7FB4E78
	public List<GridViewItemPrefabConfData> get_ItemPrefabDataList() { }

	// RVA: 0x7FB4E80 Offset: 0x7FB0E80 VA: 0x7FB4E80
	public int get_ItemTotalCount() { }

	// RVA: 0x7FB4E88 Offset: 0x7FB0E88 VA: 0x7FB4E88
	public RectTransform get_ContainerTrans() { }

	// RVA: 0x7FB4E90 Offset: 0x7FB0E90 VA: 0x7FB4E90
	public float get_ViewPortWidth() { }

	// RVA: 0x7FB4EB4 Offset: 0x7FB0EB4 VA: 0x7FB4EB4
	public float get_ViewPortHeight() { }

	// RVA: 0x7FB4ED8 Offset: 0x7FB0ED8 VA: 0x7FB4ED8
	public ScrollRect get_ScrollRect() { }

	// RVA: 0x7FB4EE0 Offset: 0x7FB0EE0 VA: 0x7FB4EE0
	public bool get_IsDraging() { }

	// RVA: 0x7FB4EE8 Offset: 0x7FB0EE8 VA: 0x7FB4EE8
	public bool get_ItemSnapEnable() { }

	// RVA: 0x7FB4EF0 Offset: 0x7FB0EF0 VA: 0x7FB4EF0
	public void set_ItemSnapEnable(bool value) { }

	// RVA: 0x7FB4EFC Offset: 0x7FB0EFC VA: 0x7FB4EFC
	public Vector2 get_ItemSize() { }

	// RVA: 0x7FB4F04 Offset: 0x7FB0F04 VA: 0x7FB4F04
	public void set_ItemSize(Vector2 value) { }

	// RVA: 0x7FB4FD0 Offset: 0x7FB0FD0 VA: 0x7FB4FD0
	public Vector2 get_ItemPadding() { }

	// RVA: 0x7FB4FD8 Offset: 0x7FB0FD8 VA: 0x7FB4FD8
	public void set_ItemPadding(Vector2 value) { }

	// RVA: 0x7FB50A4 Offset: 0x7FB10A4 VA: 0x7FB50A4
	public Vector2 get_ItemSizeWithPadding() { }

	// RVA: 0x7FB50AC Offset: 0x7FB10AC VA: 0x7FB50AC
	public RectOffset get_Padding() { }

	// RVA: 0x7FB50B4 Offset: 0x7FB10B4 VA: 0x7FB50B4
	public void set_Padding(RectOffset value) { }

	// RVA: 0x7FB5164 Offset: 0x7FB1164 VA: 0x7FB5164
	public GridViewItemPrefabConfData GetItemPrefabConfData(string prefabName) { }

	// RVA: 0x7FB538C Offset: 0x7FB138C VA: 0x7FB538C
	public void InitGridView(int itemTotalCount, Func<LoopGridView, int, int, int, LoopGridViewItem> onGetItemByRowColumn, LoopGridViewSettingParam settingParam, LoopGridViewInitParam initParam) { }

	// RVA: 0x7FB63EC Offset: 0x7FB23EC VA: 0x7FB63EC
	public void SetListItemCount(int itemCount, bool resetPos = True, bool isUpdateItem = True) { }

	// RVA: 0x7FB704C Offset: 0x7FB304C VA: 0x7FB704C
	public LoopGridViewItem NewListViewItem(string itemPrefabName) { }

	// RVA: 0x7FB71DC Offset: 0x7FB31DC VA: 0x7FB71DC
	public void ClearAllShownItems() { }

	// RVA: 0x7FB71F4 Offset: 0x7FB31F4 VA: 0x7FB71F4
	public void RefreshItemByItemIndex(int itemIndex) { }

	// RVA: 0x7FB72B8 Offset: 0x7FB32B8 VA: 0x7FB72B8
	public void RefreshItemByRowColumn(int row, int column) { }

	// RVA: 0x7FB7800 Offset: 0x7FB3800 VA: 0x7FB7800
	public void ClearSnapData() { }

	// RVA: 0x7FB7820 Offset: 0x7FB3820 VA: 0x7FB7820
	public void SetSnapTargetItemRowColumn(int row, int column) { }

	// RVA: 0x7FB7858 Offset: 0x7FB3858 VA: 0x7FB7858
	public RowColumnPair get_CurSnapNearestItemRowColumn() { }

	// RVA: 0x7FB7860 Offset: 0x7FB3860 VA: 0x7FB7860
	public void ForceSnapUpdateCheck() { }

	// RVA: 0x7FB65F0 Offset: 0x7FB25F0 VA: 0x7FB65F0
	public void ForceToCheckContentPos() { }

	// RVA: 0x7FB787C Offset: 0x7FB387C VA: 0x7FB787C
	public void MovePanelToItemByIndex(int itemIndex, float offsetX = 0, float offsetY = 0) { }

	// RVA: 0x7FB6E3C Offset: 0x7FB2E3C VA: 0x7FB6E3C
	public void MovePanelToItemByRowColumn(int row, int column, float offsetX = 0, float offsetY = 0) { }

	// RVA: 0x7FB7954 Offset: 0x7FB3954 VA: 0x7FB7954
	public void RefreshAllShownItem() { }

	// RVA: 0x7FB79CC Offset: 0x7FB39CC VA: 0x7FB79CC Slot: 7
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x7FB7A1C Offset: 0x7FB3A1C VA: 0x7FB7A1C Slot: 8
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x7FB7A6C Offset: 0x7FB3A6C VA: 0x7FB7A6C Slot: 9
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x7FB7AA4 Offset: 0x7FB3AA4 VA: 0x7FB7AA4
	public int GetItemIndexByRowColumn(int row, int column) { }

	// RVA: 0x7FB7288 Offset: 0x7FB3288 VA: 0x7FB7288
	public RowColumnPair GetRowColumnByItemIndex(int itemIndex) { }

	// RVA: 0x7FB7AC0 Offset: 0x7FB3AC0 VA: 0x7FB7AC0
	public Vector2 GetItemAbsPos(int row, int column) { }

	// RVA: 0x7FB78BC Offset: 0x7FB38BC VA: 0x7FB78BC
	public Vector2 GetItemPos(int row, int column) { }

	// RVA: 0x7FB7AE0 Offset: 0x7FB3AE0 VA: 0x7FB7AE0
	public LoopGridViewItem GetShownItemByItemIndex(int itemIndex) { }

	// RVA: 0x7FB7B78 Offset: 0x7FB3B78 VA: 0x7FB7B78
	public LoopGridViewItem GetShownItemByRowColumn(int row, int column) { }

	// RVA: 0x7FB6398 Offset: 0x7FB2398 VA: 0x7FB6398
	public void UpdateAllGridSetting() { }

	// RVA: 0x7FB7F80 Offset: 0x7FB3F80 VA: 0x7FB7F80
	public void SetGridFixedGroupCount(GridFixedType fixedType, int count) { }

	// RVA: 0x7FB4F08 Offset: 0x7FB0F08 VA: 0x7FB4F08
	public void SetItemSize(Vector2 newSize) { }

	// RVA: 0x7FB4FDC Offset: 0x7FB0FDC VA: 0x7FB4FDC
	public void SetItemPadding(Vector2 newPadding) { }

	// RVA: 0x7FB50B8 Offset: 0x7FB10B8 VA: 0x7FB50B8
	public void SetPadding(RectOffset newPadding) { }

	// RVA: 0x7FB6518 Offset: 0x7FB2518 VA: 0x7FB6518
	public void UpdateContentSize() { }

	// RVA: 0x7FB681C Offset: 0x7FB281C VA: 0x7FB681C
	public void VaildAndSetContainerPos() { }

	// RVA: 0x7FB6784 Offset: 0x7FB2784 VA: 0x7FB6784
	public void ClearAllTmpRecycledItem() { }

	// RVA: 0x7FB660C Offset: 0x7FB260C VA: 0x7FB660C
	public void RecycleAllItem() { }

	// RVA: 0x7FB6864 Offset: 0x7FB2864 VA: 0x7FB6864
	public void UpdateGridViewContent() { }

	// RVA: 0x7FB7C28 Offset: 0x7FB3C28 VA: 0x7FB7C28
	public void UpdateStartEndPadding() { }

	// RVA: 0x7FB7DCC Offset: 0x7FB3DCC VA: 0x7FB7DCC
	public void UpdateItemSize() { }

	// RVA: 0x7FB64B8 Offset: 0x7FB24B8 VA: 0x7FB64B8
	public void UpdateColumnRowCount() { }

	// RVA: 0x7FB88A0 Offset: 0x7FB48A0 VA: 0x7FB88A0
	private bool IsContainerTransCanMove() { }

	// RVA: 0x7FB8188 Offset: 0x7FB4188 VA: 0x7FB8188
	private void RecycleItemGroupTmp(GridItemGroup group) { }

	// RVA: 0x7FB7734 Offset: 0x7FB3734 VA: 0x7FB7734
	private void RecycleItemTmp(LoopGridViewItem item) { }

	// RVA: 0x7FB5D48 Offset: 0x7FB1D48 VA: 0x7FB5D48
	private void AdjustViewPortPivot() { }

	// RVA: 0x7FB5DC8 Offset: 0x7FB1DC8 VA: 0x7FB5DC8
	private void AdjustContainerAnchorAndPivot() { }

	// RVA: 0x7FB89E4 Offset: 0x7FB49E4 VA: 0x7FB89E4
	private void AdjustItemAnchorAndPivot(RectTransform rtf) { }

	// RVA: 0x7FB5E88 Offset: 0x7FB1E88 VA: 0x7FB5E88
	private void InitItemPool() { }

	// RVA: 0x7FB7564 Offset: 0x7FB3564 VA: 0x7FB7564
	private LoopGridViewItem GetNewItemByRowColumn(int row, int column) { }

	// RVA: 0x7FB8AA4 Offset: 0x7FB4AA4 VA: 0x7FB8AA4
	private RowColumnPair GetCeilItemRowColumnAtGivenAbsPos(float ax, float ay) { }

	// RVA: 0x7FB8BDC Offset: 0x7FB4BDC VA: 0x7FB8BDC
	private void Update() { }

	// RVA: 0x7FB8330 Offset: 0x7FB4330 VA: 0x7FB8330
	private GridItemGroup CreateItemGroup(int groupIndex) { }

	// RVA: 0x7FB8F30 Offset: 0x7FB4F30 VA: 0x7FB8F30
	private Vector2 GetContainerMovedDistance() { }

	// RVA: 0x7FB803C Offset: 0x7FB403C VA: 0x7FB803C
	private Vector2 GetContainerVaildPos(float curX, float curY) { }

	// RVA: 0x7FB8238 Offset: 0x7FB4238 VA: 0x7FB8238
	private void UpdateCurFrameItemRangeData() { }

	// RVA: 0x7FB8350 Offset: 0x7FB4350 VA: 0x7FB8350
	private void UpdateRowItemGroupForRecycleAndNew(GridItemGroup group) { }

	// RVA: 0x7FB85F8 Offset: 0x7FB45F8 VA: 0x7FB85F8
	private void UpdateColumnItemGroupForRecycleAndNew(GridItemGroup group) { }

	// RVA: 0x7FB58F8 Offset: 0x7FB18F8 VA: 0x7FB58F8
	private void SetScrollbarListener() { }

	// RVA: 0x7FB5B78 Offset: 0x7FB1B78 VA: 0x7FB5B78
	private void ReplaceScrollbarEventHandlerForSmoothMove() { }

	// RVA: 0x7FB8F84 Offset: 0x7FB4F84 VA: 0x7FB8F84
	private void OnVerticalScrollBarValueChanged(float value) { }

	// RVA: 0x7FB8FB0 Offset: 0x7FB4FB0 VA: 0x7FB8FB0
	private void OnHorizontalScrollBarValueChanged(float value) { }

	// RVA: 0x7FB8FDC Offset: 0x7FB4FDC VA: 0x7FB8FDC
	private void OnPointerDownInVerticalScrollBar(GameObject obj) { }

	// RVA: 0x7FB9004 Offset: 0x7FB5004 VA: 0x7FB9004
	private void OnPointerUpInVerticalScrollBar(GameObject obj) { }

	// RVA: 0x7FB9024 Offset: 0x7FB5024 VA: 0x7FB9024
	private void OnPointerDownInHorizontalScrollBar(GameObject obj) { }

	// RVA: 0x7FB904C Offset: 0x7FB504C VA: 0x7FB904C
	private void OnPointerUpInHorizontalScrollBar(GameObject obj) { }

	// RVA: 0x7FB906C Offset: 0x7FB506C VA: 0x7FB906C
	private RowColumnPair FindNearestItemWithLocalPos(float x, float y) { }

	// RVA: 0x7FB9198 Offset: 0x7FB5198 VA: 0x7FB9198
	private Vector2 GetItemSnapPivotLocalPos(int row, int column) { }

	// RVA: 0x7FB92C4 Offset: 0x7FB52C4 VA: 0x7FB92C4
	private Vector2 GetViewPortSnapPivotLocalPos(Vector2 pos) { }

	// RVA: 0x7FB93DC Offset: 0x7FB53DC VA: 0x7FB93DC
	private void UpdateNearestSnapItem(bool forceSendEvent) { }

	// RVA: 0x7FB5744 Offset: 0x7FB1744 VA: 0x7FB5744
	private void UpdateFromSettingParam(LoopGridViewSettingParam param) { }

	// RVA: 0x7FB9520 Offset: 0x7FB5520 VA: 0x7FB9520
	public void FinishSnapImmediately() { }

	// RVA: 0x7FB8C14 Offset: 0x7FB4C14 VA: 0x7FB8C14
	private void UpdateSnapMove(bool immediate = False, bool forceSendEvent = False) { }

	// RVA: 0x7FB7470 Offset: 0x7FB3470 VA: 0x7FB7470
	private GridItemGroup GetShownGroup(int groupIndex) { }

	// RVA: 0x7FB9820 Offset: 0x7FB5820 VA: 0x7FB9820
	private void FillCurSnapData(int row, int column) { }

	// RVA: 0x7FB966C Offset: 0x7FB566C VA: 0x7FB966C
	private void UpdateCurSnapData() { }

	// RVA: 0x7FB952C Offset: 0x7FB552C VA: 0x7FB952C
	private bool CanSnap() { }

	// RVA: 0x7FB8E58 Offset: 0x7FB4E58 VA: 0x7FB8E58
	private GridItemGroup GetOneItemGroupObj() { }

	// RVA: 0x7FB8938 Offset: 0x7FB4938 VA: 0x7FB8938
	private void RecycleOneItemGroupObj(GridItemGroup obj) { }

	// RVA: 0x7FB99A4 Offset: 0x7FB59A4 VA: 0x7FB99A4
	public List<GridItemGroup> get_ItemGroupList() { }

	// RVA: 0x7FB99AC Offset: 0x7FB59AC VA: 0x7FB99AC
	public void RefreshAllItems() { }

	// RVA: 0x7FB99F0 Offset: 0x7FB59F0 VA: 0x7FB99F0
	public void SmoothMoveToItemIndex(int itemIndex, float offsetX = 0, float offsetY = 0, float duration = 0.5) { }

	// RVA: 0x7FB9B14 Offset: 0x7FB5B14 VA: 0x7FB9B14
	public bool IsItemVisibleViewPort(int itemIndex) { }

	// RVA: 0x7FB9CD0 Offset: 0x7FB5CD0 VA: 0x7FB9CD0
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class LoopGridViewItem : MonoBehaviour // TypeDefIndex: 26510
{
	// Fields
	private int mItemIndex; // 0x20
	private int mRow; // 0x24
	private int mColumn; // 0x28
	private int mItemId; // 0x2C
	private LoopGridView mParentGridView; // 0x30
	private bool mIsInitHandlerCalled; // 0x38
	private string mItemPrefabName; // 0x40
	private RectTransform mCachedRectTransform; // 0x48
	private int mItemCreatedCheckFrameCount; // 0x50
	private object mUserObjectData; // 0x58
	private int mUserIntData1; // 0x60
	private int mUserIntData2; // 0x64
	private string mUserStringData1; // 0x68
	private string mUserStringData2; // 0x70
	private LoopGridViewItem mPrevItem; // 0x78
	private LoopGridViewItem mNextItem; // 0x80

	// Properties
	public object UserObjectData { get; set; }
	public int UserIntData1 { get; set; }
	public int UserIntData2 { get; set; }
	public string UserStringData1 { get; set; }
	public string UserStringData2 { get; set; }
	public int ItemCreatedCheckFrameCount { get; set; }
	public RectTransform CachedRectTransform { get; }
	public string ItemPrefabName { get; set; }
	public int Row { get; set; }
	public int Column { get; set; }
	public int ItemIndex { get; set; }
	public int ItemId { get; set; }
	public bool IsInitHandlerCalled { get; set; }
	public LoopGridView ParentGridView { get; set; }
	public LoopGridViewItem PrevItem { get; set; }
	public LoopGridViewItem NextItem { get; set; }

	// Methods

	// RVA: 0x7FBA054 Offset: 0x7FB6054 VA: 0x7FBA054
	public object get_UserObjectData() { }

	// RVA: 0x7FBA05C Offset: 0x7FB605C VA: 0x7FBA05C
	public void set_UserObjectData(object value) { }

	// RVA: 0x7FBA064 Offset: 0x7FB6064 VA: 0x7FBA064
	public int get_UserIntData1() { }

	// RVA: 0x7FBA06C Offset: 0x7FB606C VA: 0x7FBA06C
	public void set_UserIntData1(int value) { }

	// RVA: 0x7FBA074 Offset: 0x7FB6074 VA: 0x7FBA074
	public int get_UserIntData2() { }

	// RVA: 0x7FBA07C Offset: 0x7FB607C VA: 0x7FBA07C
	public void set_UserIntData2(int value) { }

	// RVA: 0x7FBA084 Offset: 0x7FB6084 VA: 0x7FBA084
	public string get_UserStringData1() { }

	// RVA: 0x7FBA08C Offset: 0x7FB608C VA: 0x7FBA08C
	public void set_UserStringData1(string value) { }

	// RVA: 0x7FBA094 Offset: 0x7FB6094 VA: 0x7FBA094
	public string get_UserStringData2() { }

	// RVA: 0x7FBA09C Offset: 0x7FB609C VA: 0x7FBA09C
	public void set_UserStringData2(string value) { }

	// RVA: 0x7FBA0A4 Offset: 0x7FB60A4 VA: 0x7FBA0A4
	public int get_ItemCreatedCheckFrameCount() { }

	// RVA: 0x7FBA0AC Offset: 0x7FB60AC VA: 0x7FBA0AC
	public void set_ItemCreatedCheckFrameCount(int value) { }

	// RVA: 0x7FB767C Offset: 0x7FB367C VA: 0x7FB767C
	public RectTransform get_CachedRectTransform() { }

	// RVA: 0x7FBA0B4 Offset: 0x7FB60B4 VA: 0x7FBA0B4
	public string get_ItemPrefabName() { }

	// RVA: 0x7FBA0BC Offset: 0x7FB60BC VA: 0x7FBA0BC
	public void set_ItemPrefabName(string value) { }

	// RVA: 0x7FBA0C4 Offset: 0x7FB60C4 VA: 0x7FBA0C4
	public int get_Row() { }

	// RVA: 0x7FBA0CC Offset: 0x7FB60CC VA: 0x7FBA0CC
	public void set_Row(int value) { }

	// RVA: 0x7FBA0D4 Offset: 0x7FB60D4 VA: 0x7FBA0D4
	public int get_Column() { }

	// RVA: 0x7FBA0DC Offset: 0x7FB60DC VA: 0x7FBA0DC
	public void set_Column(int value) { }

	// RVA: 0x7FBA0E4 Offset: 0x7FB60E4 VA: 0x7FBA0E4
	public int get_ItemIndex() { }

	// RVA: 0x7FBA0EC Offset: 0x7FB60EC VA: 0x7FBA0EC
	public void set_ItemIndex(int value) { }

	// RVA: 0x7FBA0F4 Offset: 0x7FB60F4 VA: 0x7FBA0F4
	public int get_ItemId() { }

	// RVA: 0x7FBA0FC Offset: 0x7FB60FC VA: 0x7FBA0FC
	public void set_ItemId(int value) { }

	// RVA: 0x7FBA104 Offset: 0x7FB6104 VA: 0x7FBA104
	public bool get_IsInitHandlerCalled() { }

	// RVA: 0x7FBA10C Offset: 0x7FB610C VA: 0x7FBA10C
	public void set_IsInitHandlerCalled(bool value) { }

	// RVA: 0x7FBA118 Offset: 0x7FB6118 VA: 0x7FBA118
	public LoopGridView get_ParentGridView() { }

	// RVA: 0x7FBA120 Offset: 0x7FB6120 VA: 0x7FBA120
	public void set_ParentGridView(LoopGridView value) { }

	// RVA: 0x7FBA128 Offset: 0x7FB6128 VA: 0x7FBA128
	public LoopGridViewItem get_PrevItem() { }

	// RVA: 0x7FBA130 Offset: 0x7FB6130 VA: 0x7FBA130
	public void set_PrevItem(LoopGridViewItem value) { }

	// RVA: 0x7FBA138 Offset: 0x7FB6138 VA: 0x7FBA138
	public LoopGridViewItem get_NextItem() { }

	// RVA: 0x7FBA140 Offset: 0x7FB6140 VA: 0x7FBA140
	public void set_NextItem(LoopGridViewItem value) { }

	// RVA: 0x7FBA148 Offset: 0x7FB6148 VA: 0x7FBA148
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ScrollRectEx : ScrollRect // TypeDefIndex: 26511
{
	// Methods

	// RVA: 0x7FBA158 Offset: 0x7FB6158 VA: 0x7FBA158 Slot: 48
	protected override void LateUpdate() { }

	// RVA: 0x7FBA234 Offset: 0x7FB6234 VA: 0x7FBA234
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ItemPool // TypeDefIndex: 26512
{
	// Fields
	private GameObject mPrefabObj; // 0x10
	private string mPrefabName; // 0x18
	private int mInitCreateCount; // 0x20
	private float mPadding; // 0x24
	private float mStartPosOffset; // 0x28
	private List<LoopListViewItem2> mTmpPooledItemList; // 0x30
	private List<LoopListViewItem2> mPooledItemList; // 0x38
	private static int mCurItemIdCount; // 0x0
	private RectTransform mItemParent; // 0x40

	// Methods

	// RVA: 0x7FBA23C Offset: 0x7FB623C VA: 0x7FBA23C
	public void .ctor() { }

	// RVA: 0x7FBA2F0 Offset: 0x7FB62F0 VA: 0x7FBA2F0
	public void Init(GameObject prefabObj, float padding, float startPosOffset, int createCount, RectTransform parent) { }

	// RVA: 0x7FBA700 Offset: 0x7FB6700 VA: 0x7FBA700
	public LoopListViewItem2 GetItem() { }

	// RVA: 0x7FBA84C Offset: 0x7FB684C VA: 0x7FBA84C
	public void DestroyAllItem() { }

	// RVA: 0x7FBA3C0 Offset: 0x7FB63C0 VA: 0x7FBA3C0
	public LoopListViewItem2 CreateItem() { }

	// RVA: 0x7FBA634 Offset: 0x7FB6634 VA: 0x7FBA634
	private void RecycleItemReal(LoopListViewItem2 item) { }

	// RVA: 0x7FBAA44 Offset: 0x7FB6A44 VA: 0x7FBAA44
	public void RecycleItem(LoopListViewItem2 item) { }

	// RVA: 0x7FBA96C Offset: 0x7FB696C VA: 0x7FBA96C
	public void ClearTmpRecycledItem() { }
}

// Namespace: SuperScrollView
[Serializable]
public class ItemPrefabConfData // TypeDefIndex: 26513
{
	// Fields
	public GameObject mItemPrefab; // 0x10
	public float mPadding; // 0x18
	public int mInitCreateCount; // 0x1C
	public float mStartPosOffset; // 0x20

	// Methods

	// RVA: 0x7FBAAF0 Offset: 0x7FB6AF0 VA: 0x7FBAAF0
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class LoopListViewInitParam // TypeDefIndex: 26514
{
	// Fields
	public float mDistanceForRecycle0; // 0x10
	public float mDistanceForNew0; // 0x14
	public float mDistanceForRecycle1; // 0x18
	public float mDistanceForNew1; // 0x1C
	public float mSmoothDumpRate; // 0x20
	public float mSnapFinishThreshold; // 0x24
	public float mSnapVecThreshold; // 0x28
	public float mItemDefaultWithPaddingSize; // 0x2C

	// Methods

	// RVA: 0x7FBAAF8 Offset: 0x7FB6AF8 VA: 0x7FBAAF8
	public static LoopListViewInitParam CopyDefaultInitParam() { }

	// RVA: 0x7FBAB60 Offset: 0x7FB6B60 VA: 0x7FBAB60
	public void .ctor() { }
}

// Namespace: 
private class LoopListView2.SnapData // TypeDefIndex: 26515
{
	// Fields
	public SnapStatus mSnapStatus; // 0x10
	public int mSnapTargetIndex; // 0x14
	public float mTargetSnapVal; // 0x18
	public float mCurSnapVal; // 0x1C
	public bool mIsForceSnapTo; // 0x20
	public bool mIsTempTarget; // 0x21
	public int mTempTargetIndex; // 0x24
	public float mMoveMaxAbsVec; // 0x28

	// Methods

	// RVA: 0x7FC2ADC Offset: 0x7FBEADC VA: 0x7FC2ADC
	public void Clear() { }

	// RVA: 0x7FC2AF4 Offset: 0x7FBEAF4 VA: 0x7FC2AF4
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class LoopListView2 : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler // TypeDefIndex: 26516
{
	// Fields
	private Dictionary<string, ItemPool> mItemPoolDict; // 0x20
	private List<ItemPool> mItemPoolList; // 0x28
	[SerializeField]
	private List<ItemPrefabConfData> mItemPrefabDataList; // 0x30
	[SerializeField]
	private ListItemArrangeType mArrangeType; // 0x38
	private List<LoopListViewItem2> mItemList; // 0x40
	private RectTransform mContainerTrans; // 0x48
	private ScrollRect mScrollRect; // 0x50
	private RectTransform mScrollRectTransform; // 0x58
	private RectTransform mViewPortRectTransform; // 0x60
	private float mItemDefaultWithPaddingSize; // 0x68
	private int mItemTotalCount; // 0x6C
	private bool mIsVertList; // 0x70
	private Func<LoopListView2, int, LoopListViewItem2> mOnGetItemByIndex; // 0x78
	private Vector3[] mItemWorldCorners; // 0x80
	private Vector3[] mViewPortRectLocalCorners; // 0x88
	private int mCurReadyMinItemIndex; // 0x90
	private int mCurReadyMaxItemIndex; // 0x94
	private bool mNeedCheckNextMinItem; // 0x98
	private bool mNeedCheckNextMaxItem; // 0x99
	private ItemPosMgr mItemPosMgr; // 0xA0
	private float mDistanceForRecycle0; // 0xA8
	private float mDistanceForNew0; // 0xAC
	private float mDistanceForRecycle1; // 0xB0
	private float mDistanceForNew1; // 0xB4
	[SerializeField]
	private bool mSupportScrollBar; // 0xB8
	private float mExtraBottomSize; // 0xBC
	private bool mIsDraging; // 0xC0
	private PointerEventData mPointerEventData; // 0xC8
	public Action mOnBeginDragAction; // 0xD0
	public Action mOnDragingAction; // 0xD8
	public Action mOnEndDragAction; // 0xE0
	private int mLastItemIndex; // 0xE8
	private float mLastItemPadding; // 0xEC
	private float mSmoothDumpVel; // 0xF0
	private float mSmoothDumpRate; // 0xF4
	private float mSnapFinishThreshold; // 0xF8
	private float mSnapVecThreshold; // 0xFC
	private float mSnapMoveDefaultMaxAbsVec; // 0x100
	[SerializeField]
	private bool mItemSnapEnable; // 0x104
	private Vector3 mLastFrameContainerPos; // 0x108
	public Action<LoopListView2, LoopListViewItem2> mOnSnapItemFinished; // 0x118
	public Action<LoopListView2, LoopListViewItem2> mOnSnapNearestChanged; // 0x120
	private int mCurSnapNearestItemIndex; // 0x128
	private Vector2 mAdjustedVec; // 0x12C
	private bool mNeedAdjustVec; // 0x134
	private int mLeftSnapUpdateExtraCount; // 0x138
	[SerializeField]
	private Vector2 mViewPortSnapPivot; // 0x13C
	[SerializeField]
	private Vector2 mItemSnapPivot; // 0x144
	private ClickEventListener mScrollBarClickEventListener; // 0x150
	private LoopListView2.SnapData mCurSnapData; // 0x158
	private Vector3 mLastSnapCheckPos; // 0x160
	private bool mListViewInited; // 0x16C
	private int mListUpdateCheckFrameCount; // 0x170
	public Action<LoopListView2> OnListViewStart; // 0x178
	private bool mIsPointerDownInScrollBar; // 0x180
	private bool mNeedReplaceScrollbarEventHandler; // 0x181

	// Properties
	public ListItemArrangeType ArrangeType { get; set; }
	public float ExtraBottomSize { get; set; }
	public List<ItemPrefabConfData> ItemPrefabDataList { get; }
	public List<LoopListViewItem2> ItemList { get; }
	public bool IsVertList { get; }
	public int ItemTotalCount { get; }
	public RectTransform ContainerTrans { get; }
	public ScrollRect ScrollRect { get; }
	public bool IsDraging { get; }
	public bool ItemSnapEnable { get; set; }
	public bool SupportScrollBar { get; set; }
	public float SnapMoveDefaultMaxAbsVec { get; set; }
	public int ShownItemCount { get; }
	public float ViewPortSize { get; }
	public float ViewPortWidth { get; }
	public float ViewPortHeight { get; }
	public int CurSnapNearestItemIndex { get; }

	// Methods

	// RVA: 0x7FBAB7C Offset: 0x7FB6B7C VA: 0x7FBAB7C
	public ListItemArrangeType get_ArrangeType() { }

	// RVA: 0x7FBAB84 Offset: 0x7FB6B84 VA: 0x7FBAB84
	public void set_ArrangeType(ListItemArrangeType value) { }

	// RVA: 0x7FBAB8C Offset: 0x7FB6B8C VA: 0x7FBAB8C
	public float get_ExtraBottomSize() { }

	// RVA: 0x7FBAB94 Offset: 0x7FB6B94 VA: 0x7FBAB94
	public void set_ExtraBottomSize(float value) { }

	// RVA: 0x7FBAB9C Offset: 0x7FB6B9C VA: 0x7FBAB9C
	public List<ItemPrefabConfData> get_ItemPrefabDataList() { }

	// RVA: 0x7FBABA4 Offset: 0x7FB6BA4 VA: 0x7FBABA4
	public List<LoopListViewItem2> get_ItemList() { }

	// RVA: 0x7FBABAC Offset: 0x7FB6BAC VA: 0x7FBABAC
	public bool get_IsVertList() { }

	// RVA: 0x7FBABB4 Offset: 0x7FB6BB4 VA: 0x7FBABB4
	public int get_ItemTotalCount() { }

	// RVA: 0x7FBABBC Offset: 0x7FB6BBC VA: 0x7FBABBC
	public RectTransform get_ContainerTrans() { }

	// RVA: 0x7FBABC4 Offset: 0x7FB6BC4 VA: 0x7FBABC4
	public ScrollRect get_ScrollRect() { }

	// RVA: 0x7FBABCC Offset: 0x7FB6BCC VA: 0x7FBABCC
	public bool get_IsDraging() { }

	// RVA: 0x7FBABD4 Offset: 0x7FB6BD4 VA: 0x7FBABD4
	public bool get_ItemSnapEnable() { }

	// RVA: 0x7FBABDC Offset: 0x7FB6BDC VA: 0x7FBABDC
	public void set_ItemSnapEnable(bool value) { }

	// RVA: 0x7FBABE8 Offset: 0x7FB6BE8 VA: 0x7FBABE8
	public bool get_SupportScrollBar() { }

	// RVA: 0x7FBABF0 Offset: 0x7FB6BF0 VA: 0x7FBABF0
	public void set_SupportScrollBar(bool value) { }

	// RVA: 0x7FBABFC Offset: 0x7FB6BFC VA: 0x7FBABFC
	public float get_SnapMoveDefaultMaxAbsVec() { }

	// RVA: 0x7FBAC04 Offset: 0x7FB6C04 VA: 0x7FBAC04
	public void set_SnapMoveDefaultMaxAbsVec(float value) { }

	// RVA: 0x7FBAC0C Offset: 0x7FB6C0C VA: 0x7FBAC0C
	public ItemPrefabConfData GetItemPrefabConfData(string prefabName) { }

	// RVA: 0x7FBAE34 Offset: 0x7FB6E34 VA: 0x7FBAE34
	public void OnItemPrefabChanged(string prefabName) { }

	// RVA: 0x7FBB3CC Offset: 0x7FB73CC VA: 0x7FBB3CC
	public void InitListView(int itemTotalCount, Func<LoopListView2, int, LoopListViewItem2> onGetItemByIndex, LoopListViewInitParam initParam) { }

	// RVA: 0x7FBC470 Offset: 0x7FB8470 VA: 0x7FBC470
	private void Start() { }

	// RVA: 0x7FBB8CC Offset: 0x7FB78CC VA: 0x7FBB8CC
	private void SetScrollbarListener() { }

	// RVA: 0x7FBC490 Offset: 0x7FB8490 VA: 0x7FBC490
	private void OnPointerDownInScrollBar(GameObject obj) { }

	// RVA: 0x7FBC4B8 Offset: 0x7FB84B8 VA: 0x7FBC4B8
	private void OnPointerUpInScrollBar(GameObject obj) { }

	// RVA: 0x7FBC224 Offset: 0x7FB8224 VA: 0x7FBC224
	private void ReplaceScrollbarEventHandlerForSmoothMove() { }

	// RVA: 0x7FBC4F4 Offset: 0x7FB84F4 VA: 0x7FBC4F4
	private void OnScrollBarValueChanged(float value) { }

	// RVA: 0x7FBC18C Offset: 0x7FB818C VA: 0x7FBC18C
	public void ResetListView(bool resetPos = True) { }

	// RVA: 0x7FBC538 Offset: 0x7FB8538 VA: 0x7FBC538
	public void SetListItemCount(int itemCount, bool resetPos = True) { }

	// RVA: 0x7FBD01C Offset: 0x7FB901C VA: 0x7FBD01C
	public LoopListViewItem2 GetShownItemByItemIndex(int itemIndex) { }

	// RVA: 0x7FBD10C Offset: 0x7FB910C VA: 0x7FBD10C
	public LoopListViewItem2 GetShownItemNearestItemIndex(int itemIndex) { }

	// RVA: 0x7FBD21C Offset: 0x7FB921C VA: 0x7FBD21C
	public int get_ShownItemCount() { }

	// RVA: 0x7FBD264 Offset: 0x7FB9264 VA: 0x7FBD264
	public float get_ViewPortSize() { }

	// RVA: 0x7FBD294 Offset: 0x7FB9294 VA: 0x7FBD294
	public float get_ViewPortWidth() { }

	// RVA: 0x7FBD2B8 Offset: 0x7FB92B8 VA: 0x7FBD2B8
	public float get_ViewPortHeight() { }

	// RVA: 0x7FBD2DC Offset: 0x7FB92DC VA: 0x7FBD2DC
	public LoopListViewItem2 GetShownItemByIndex(int index) { }

	// RVA: 0x7FBD360 Offset: 0x7FB9360 VA: 0x7FBD360
	public LoopListViewItem2 GetShownItemByIndexWithoutCheck(int index) { }

	// RVA: 0x7FBD3B8 Offset: 0x7FB93B8 VA: 0x7FBD3B8
	public int GetIndexInShownItemList(LoopListViewItem2 item) { }

	// RVA: 0x7FBD4C0 Offset: 0x7FB94C0 VA: 0x7FBD4C0
	public void DoActionForEachShownItem(Action<LoopListViewItem2, object> action, object param) { }

	// RVA: 0x7FBD580 Offset: 0x7FB9580 VA: 0x7FBD580
	public LoopListViewItem2 NewListViewItem(string itemPrefabName) { }

	// RVA: 0x7FBD710 Offset: 0x7FB9710 VA: 0x7FBD710
	public void OnItemSizeChanged(int itemIndex) { }

	// RVA: 0x7FBD844 Offset: 0x7FB9844 VA: 0x7FBD844
	public void RefreshItemByItemIndex(int itemIndex) { }

	// RVA: 0x7FBDE40 Offset: 0x7FB9E40 VA: 0x7FBDE40
	public void FinishSnapImmediately() { }

	// RVA: 0x7FBC6B8 Offset: 0x7FB86B8 VA: 0x7FBC6B8
	public void MovePanelToItemIndex(int itemIndex, float offset) { }

	// RVA: 0x7FBE81C Offset: 0x7FBA81C VA: 0x7FBE81C
	public void RefreshAllShownItem() { }

	// RVA: 0x7FBDC04 Offset: 0x7FB9C04 VA: 0x7FBDC04
	public void RefreshAllShownItemWithFirstIndex(int firstItemIndex) { }

	// RVA: 0x7FBB1FC Offset: 0x7FB71FC VA: 0x7FBB1FC
	public void RefreshAllShownItemWithFirstIndexAndPos(int firstItemIndex, Vector3 pos) { }

	// RVA: 0x7FBDA60 Offset: 0x7FB9A60 VA: 0x7FBDA60
	private void RecycleItemTmp(LoopListViewItem2 item) { }

	// RVA: 0x7FBB164 Offset: 0x7FB7164 VA: 0x7FBB164
	private void ClearAllTmpRecycledItem() { }

	// RVA: 0x7FBAFEC Offset: 0x7FB6FEC VA: 0x7FBAFEC
	private void RecycleAllItem() { }

	// RVA: 0x7FBBBF0 Offset: 0x7FB7BF0 VA: 0x7FBBBF0
	private void AdjustContainerPivot(RectTransform rtf) { }

	// RVA: 0x7FBBAB0 Offset: 0x7FB7AB0 VA: 0x7FBBAB0
	private void AdjustPivot(RectTransform rtf) { }

	// RVA: 0x7FBE8A0 Offset: 0x7FBA8A0 VA: 0x7FBE8A0
	private void AdjustContainerAnchor(RectTransform rtf) { }

	// RVA: 0x7FBBB24 Offset: 0x7FB7B24 VA: 0x7FBBB24
	private void AdjustAnchor(RectTransform rtf) { }

	// RVA: 0x7FBBC64 Offset: 0x7FB7C64 VA: 0x7FBBC64
	private void InitItemPool() { }

	// RVA: 0x7FBE96C Offset: 0x7FBA96C VA: 0x7FBE96C Slot: 7
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x7FBEB10 Offset: 0x7FBAB10 VA: 0x7FBEB10 Slot: 8
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x7FBEB7C Offset: 0x7FBAB7C VA: 0x7FBEB7C Slot: 9
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x7FBE9C4 Offset: 0x7FBA9C4 VA: 0x7FBE9C4
	private void CacheDragPointerEventData(PointerEventData eventData) { }

	// RVA: 0x7FBDB2C Offset: 0x7FB9B2C VA: 0x7FBDB2C
	private LoopListViewItem2 GetNewItemByIndex(int index) { }

	// RVA: 0x7FBD7F4 Offset: 0x7FB97F4 VA: 0x7FBD7F4
	private void SetItemSize(int itemIndex, float itemSize, float padding) { }

	// RVA: 0x7FBEBBC Offset: 0x7FBABBC VA: 0x7FBEBBC
	private bool GetPlusItemIndexAndPosAtGivenPos(float pos, ref int index, ref float itemPos) { }

	// RVA: 0x7FBEBD4 Offset: 0x7FBABD4 VA: 0x7FBEBD4
	private float GetItemPos(int itemIndex) { }

	// RVA: 0x7FBEBEC Offset: 0x7FBABEC VA: 0x7FBEBEC
	public Vector3 GetItemCornerPosInViewPort(LoopListViewItem2 item, ItemCornerEnum corner = 0) { }

	// RVA: 0x7FBDFE4 Offset: 0x7FB9FE4 VA: 0x7FBDFE4
	private void AdjustPanelPos() { }

	// RVA: 0x7FBEDE8 Offset: 0x7FBADE8 VA: 0x7FBEDE8
	private void Update() { }

	// RVA: 0x7FBDE4C Offset: 0x7FB9E4C VA: 0x7FBDE4C
	private void UpdateSnapMove(bool immediate = False, bool forceSendEvent = False) { }

	// RVA: 0x7FBFD6C Offset: 0x7FBBD6C VA: 0x7FBFD6C
	public void UpdateAllShownItemSnapData() { }

	// RVA: 0x7FBEF5C Offset: 0x7FBAF5C VA: 0x7FBEF5C
	private void UpdateSnapVertical(bool immediate = False, bool forceSendEvent = False) { }

	// RVA: 0x7FC0574 Offset: 0x7FBC574 VA: 0x7FC0574
	private void UpdateCurSnapData() { }

	// RVA: 0x7FC0558 Offset: 0x7FBC558 VA: 0x7FC0558
	public void ClearSnapData() { }

	// RVA: 0x7FC07F8 Offset: 0x7FBC7F8 VA: 0x7FC07F8
	public void SetSnapTargetItemIndex(int itemIndex, float moveMaxAbsVec = -1) { }

	// RVA: 0x7FC086C Offset: 0x7FBC86C VA: 0x7FC086C
	public int get_CurSnapNearestItemIndex() { }

	// RVA: 0x7FBC4D8 Offset: 0x7FB84D8 VA: 0x7FBC4D8
	public void ForceSnapUpdateCheck() { }

	// RVA: 0x7FBF65C Offset: 0x7FBB65C VA: 0x7FBF65C
	private void UpdateSnapHorizontal(bool immediate = False, bool forceSendEvent = False) { }

	// RVA: 0x7FC02D8 Offset: 0x7FBC2D8 VA: 0x7FC02D8
	private bool CanSnap() { }

	// RVA: 0x7FBDE78 Offset: 0x7FB9E78 VA: 0x7FBDE78
	public void UpdateListView(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1) { }

	// RVA: 0x7FC0874 Offset: 0x7FBC874 VA: 0x7FC0874
	private bool UpdateForVertList(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1) { }

	// RVA: 0x7FC1638 Offset: 0x7FBD638 VA: 0x7FC1638
	private bool UpdateForHorizontalList(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1) { }

	// RVA: 0x7FBEC64 Offset: 0x7FBAC64 VA: 0x7FBEC64
	private float GetContentPanelSize() { }

	// RVA: 0x7FC2420 Offset: 0x7FBE420 VA: 0x7FC2420
	private void CheckIfNeedUpdataItemPos() { }

	// RVA: 0x7FBCA28 Offset: 0x7FB8A28 VA: 0x7FBCA28
	private void UpdateAllShownItemsPos() { }

	// RVA: 0x7FBC3E8 Offset: 0x7FB83E8 VA: 0x7FBC3E8
	private void UpdateContentSize() { }

	// RVA: 0x7FC27B0 Offset: 0x7FBE7B0 VA: 0x7FC27B0
	public void UpdateListView() { }

	// RVA: 0x7FC27BC Offset: 0x7FBE7BC VA: 0x7FC27BC
	public void RefreshAllShowItems() { }

	// RVA: 0x7FC27D4 Offset: 0x7FBE7D4 VA: 0x7FC27D4
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class LoopListViewItem2 : MonoBehaviour // TypeDefIndex: 26517
{
	// Fields
	private int mItemIndex; // 0x20
	private int mItemId; // 0x24
	private LoopListView2 mParentListView; // 0x28
	private bool mIsInitHandlerCalled; // 0x30
	private string mItemPrefabName; // 0x38
	private RectTransform mCachedRectTransform; // 0x40
	private float mPadding; // 0x48
	private float mDistanceWithViewPortSnapCenter; // 0x4C
	private int mItemCreatedCheckFrameCount; // 0x50
	private float mStartPosOffset; // 0x54
	private object mUserObjectData; // 0x58
	private int mUserIntData1; // 0x60
	private int mUserIntData2; // 0x64
	private string mUserStringData1; // 0x68
	private string mUserStringData2; // 0x70

	// Properties
	public object UserObjectData { get; set; }
	public int UserIntData1 { get; set; }
	public int UserIntData2 { get; set; }
	public string UserStringData1 { get; set; }
	public string UserStringData2 { get; set; }
	public float DistanceWithViewPortSnapCenter { get; set; }
	public float StartPosOffset { get; set; }
	public int ItemCreatedCheckFrameCount { get; set; }
	public float Padding { get; set; }
	public RectTransform CachedRectTransform { get; }
	public string ItemPrefabName { get; set; }
	public int ItemIndex { get; set; }
	public int ItemId { get; set; }
	public bool IsInitHandlerCalled { get; set; }
	public LoopListView2 ParentListView { get; set; }
	public float TopY { get; }
	public float BottomY { get; }
	public float LeftX { get; }
	public float RightX { get; }
	public float ItemSize { get; }
	public float ItemSizeWithPadding { get; }

	// Methods

	// RVA: 0x7FC2B08 Offset: 0x7FBEB08 VA: 0x7FC2B08
	public object get_UserObjectData() { }

	// RVA: 0x7FC2B10 Offset: 0x7FBEB10 VA: 0x7FC2B10
	public void set_UserObjectData(object value) { }

	// RVA: 0x7FC2B18 Offset: 0x7FBEB18 VA: 0x7FC2B18
	public int get_UserIntData1() { }

	// RVA: 0x7FC2B20 Offset: 0x7FBEB20 VA: 0x7FC2B20
	public void set_UserIntData1(int value) { }

	// RVA: 0x7FC2B28 Offset: 0x7FBEB28 VA: 0x7FC2B28
	public int get_UserIntData2() { }

	// RVA: 0x7FC2B30 Offset: 0x7FBEB30 VA: 0x7FC2B30
	public void set_UserIntData2(int value) { }

	// RVA: 0x7FC2B38 Offset: 0x7FBEB38 VA: 0x7FC2B38
	public string get_UserStringData1() { }

	// RVA: 0x7FC2B40 Offset: 0x7FBEB40 VA: 0x7FC2B40
	public void set_UserStringData1(string value) { }

	// RVA: 0x7FC2B48 Offset: 0x7FBEB48 VA: 0x7FC2B48
	public string get_UserStringData2() { }

	// RVA: 0x7FC2B50 Offset: 0x7FBEB50 VA: 0x7FC2B50
	public void set_UserStringData2(string value) { }

	// RVA: 0x7FC2B58 Offset: 0x7FBEB58 VA: 0x7FC2B58
	public float get_DistanceWithViewPortSnapCenter() { }

	// RVA: 0x7FC2B60 Offset: 0x7FBEB60 VA: 0x7FC2B60
	public void set_DistanceWithViewPortSnapCenter(float value) { }

	// RVA: 0x7FC2B68 Offset: 0x7FBEB68 VA: 0x7FC2B68
	public float get_StartPosOffset() { }

	// RVA: 0x7FC2B70 Offset: 0x7FBEB70 VA: 0x7FC2B70
	public void set_StartPosOffset(float value) { }

	// RVA: 0x7FC2B78 Offset: 0x7FBEB78 VA: 0x7FC2B78
	public int get_ItemCreatedCheckFrameCount() { }

	// RVA: 0x7FC2B80 Offset: 0x7FBEB80 VA: 0x7FC2B80
	public void set_ItemCreatedCheckFrameCount(int value) { }

	// RVA: 0x7FC2B88 Offset: 0x7FBEB88 VA: 0x7FC2B88
	public float get_Padding() { }

	// RVA: 0x7FC2B90 Offset: 0x7FBEB90 VA: 0x7FC2B90
	public void set_Padding(float value) { }

	// RVA: 0x7FC2B98 Offset: 0x7FBEB98 VA: 0x7FC2B98
	public RectTransform get_CachedRectTransform() { }

	// RVA: 0x7FC2C50 Offset: 0x7FBEC50 VA: 0x7FC2C50
	public string get_ItemPrefabName() { }

	// RVA: 0x7FC2C58 Offset: 0x7FBEC58 VA: 0x7FC2C58
	public void set_ItemPrefabName(string value) { }

	// RVA: 0x7FC2C60 Offset: 0x7FBEC60 VA: 0x7FC2C60
	public int get_ItemIndex() { }

	// RVA: 0x7FC2C68 Offset: 0x7FBEC68 VA: 0x7FC2C68
	public void set_ItemIndex(int value) { }

	// RVA: 0x7FC2C70 Offset: 0x7FBEC70 VA: 0x7FC2C70
	public int get_ItemId() { }

	// RVA: 0x7FC2C78 Offset: 0x7FBEC78 VA: 0x7FC2C78
	public void set_ItemId(int value) { }

	// RVA: 0x7FC2C80 Offset: 0x7FBEC80 VA: 0x7FC2C80
	public bool get_IsInitHandlerCalled() { }

	// RVA: 0x7FC2C88 Offset: 0x7FBEC88 VA: 0x7FC2C88
	public void set_IsInitHandlerCalled(bool value) { }

	// RVA: 0x7FC2C94 Offset: 0x7FBEC94 VA: 0x7FC2C94
	public LoopListView2 get_ParentListView() { }

	// RVA: 0x7FC2C9C Offset: 0x7FBEC9C VA: 0x7FC2C9C
	public void set_ParentListView(LoopListView2 value) { }

	// RVA: 0x7FC2CA4 Offset: 0x7FBECA4 VA: 0x7FC2CA4
	public float get_TopY() { }

	// RVA: 0x7FC2D28 Offset: 0x7FBED28 VA: 0x7FC2D28
	public float get_BottomY() { }

	// RVA: 0x7FC2DAC Offset: 0x7FBEDAC VA: 0x7FC2DAC
	public float get_LeftX() { }

	// RVA: 0x7FC2E30 Offset: 0x7FBEE30 VA: 0x7FC2E30
	public float get_RightX() { }

	// RVA: 0x7FC2EB4 Offset: 0x7FBEEB4 VA: 0x7FC2EB4
	public float get_ItemSize() { }

	// RVA: 0x7FC2EE8 Offset: 0x7FBEEE8 VA: 0x7FC2EE8
	public float get_ItemSizeWithPadding() { }

	// RVA: 0x7FC2F04 Offset: 0x7FBEF04 VA: 0x7FC2F04
	public void .ctor() { }
}

// Namespace: SuperScrollView
[Serializable]
public class StaggeredGridItemPrefabConfData // TypeDefIndex: 26518
{
	// Fields
	public GameObject mItemPrefab; // 0x10
	public float mPadding; // 0x18
	public int mInitCreateCount; // 0x1C

	// Methods

	// RVA: 0x7FC2F14 Offset: 0x7FBEF14 VA: 0x7FC2F14
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class StaggeredGridViewInitParam // TypeDefIndex: 26519
{
	// Fields
	public float mDistanceForRecycle0; // 0x10
	public float mDistanceForNew0; // 0x14
	public float mDistanceForRecycle1; // 0x18
	public float mDistanceForNew1; // 0x1C
	public float mItemDefaultWithPaddingSize; // 0x20

	// Methods

	// RVA: 0x7FC2F1C Offset: 0x7FBEF1C VA: 0x7FC2F1C
	public static StaggeredGridViewInitParam CopyDefaultInitParam() { }

	// RVA: 0x7FC2F84 Offset: 0x7FBEF84 VA: 0x7FC2F84
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ItemIndexData // TypeDefIndex: 26520
{
	// Fields
	public int mGroupIndex; // 0x10
	public int mIndexInGroup; // 0x14

	// Methods

	// RVA: 0x7FC2FA0 Offset: 0x7FBEFA0 VA: 0x7FC2FA0
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class GridViewLayoutParam // TypeDefIndex: 26521
{
	// Fields
	public int mColumnOrRowCount; // 0x10
	public float mItemWidthOrHeight; // 0x14
	public float mPadding1; // 0x18
	public float mPadding2; // 0x1C
	public float[] mCustomColumnOrRowOffsetArray; // 0x20

	// Methods

	// RVA: 0x7FC2FA8 Offset: 0x7FBEFA8 VA: 0x7FC2FA8
	public bool CheckParam() { }

	// RVA: 0x7FC3074 Offset: 0x7FBF074 VA: 0x7FC3074
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class LoopStaggeredGridView : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler // TypeDefIndex: 26522
{
	// Fields
	private Dictionary<string, StaggeredGridItemPool> mItemPoolDict; // 0x20
	private List<StaggeredGridItemPool> mItemPoolList; // 0x28
	[SerializeField]
	private List<StaggeredGridItemPrefabConfData> mItemPrefabDataList; // 0x30
	[SerializeField]
	private ListItemArrangeType mArrangeType; // 0x38
	private RectTransform mContainerTrans; // 0x40
	private ScrollRect mScrollRect; // 0x48
	private int mGroupCount; // 0x50
	private List<StaggeredGridItemGroup> mItemGroupList; // 0x58
	private List<ItemIndexData> mItemIndexDataList; // 0x60
	private RectTransform mScrollRectTransform; // 0x68
	private RectTransform mViewPortRectTransform; // 0x70
	private float mItemDefaultWithPaddingSize; // 0x78
	private int mItemTotalCount; // 0x7C
	private bool mIsVertList; // 0x80
	private Func<LoopStaggeredGridView, int, LoopStaggeredGridViewItem> mOnGetItemByItemIndex; // 0x88
	private Vector3[] mItemWorldCorners; // 0x90
	private Vector3[] mViewPortRectLocalCorners; // 0x98
	private float mDistanceForRecycle0; // 0xA0
	private float mDistanceForNew0; // 0xA4
	private float mDistanceForRecycle1; // 0xA8
	private float mDistanceForNew1; // 0xAC
	private bool mIsDraging; // 0xB0
	private PointerEventData mPointerEventData; // 0xB8
	public Action mOnBeginDragAction; // 0xC0
	public Action mOnDragingAction; // 0xC8
	public Action mOnEndDragAction; // 0xD0
	private Vector3 mLastFrameContainerPos; // 0xD8
	private bool mListViewInited; // 0xE4
	private int mListUpdateCheckFrameCount; // 0xE8
	private GridViewLayoutParam mLayoutParam; // 0xF0
	private bool mIsPointerDownInScrollBar; // 0xF8
	private bool mNeedReplaceScrollbarEventHandler; // 0xF9
	private ClickEventListener mScrollBarClickEventListener; // 0x100

	// Properties
	public ListItemArrangeType ArrangeType { get; set; }
	public List<StaggeredGridItemPrefabConfData> ItemPrefabDataList { get; }
	public int ListUpdateCheckFrameCount { get; }
	public bool IsVertList { get; }
	public int ItemTotalCount { get; }
	public RectTransform ContainerTrans { get; }
	public ScrollRect ScrollRect { get; }
	public bool IsDraging { get; }
	public GridViewLayoutParam LayoutParam { get; }
	public bool IsInited { get; }
	public float ViewPortSize { get; }
	public float ViewPortWidth { get; }
	public float ViewPortHeight { get; }
	public int CurMaxCreatedItemIndexCount { get; }

	// Methods

	// RVA: 0x7FC307C Offset: 0x7FBF07C VA: 0x7FC307C
	public ListItemArrangeType get_ArrangeType() { }

	// RVA: 0x7FC3084 Offset: 0x7FBF084 VA: 0x7FC3084
	public void set_ArrangeType(ListItemArrangeType value) { }

	// RVA: 0x7FC308C Offset: 0x7FBF08C VA: 0x7FC308C
	public List<StaggeredGridItemPrefabConfData> get_ItemPrefabDataList() { }

	// RVA: 0x7FC3094 Offset: 0x7FBF094 VA: 0x7FC3094
	public int get_ListUpdateCheckFrameCount() { }

	// RVA: 0x7FC309C Offset: 0x7FBF09C VA: 0x7FC309C
	public bool get_IsVertList() { }

	// RVA: 0x7FC30A4 Offset: 0x7FBF0A4 VA: 0x7FC30A4
	public int get_ItemTotalCount() { }

	// RVA: 0x7FC30AC Offset: 0x7FBF0AC VA: 0x7FC30AC
	public RectTransform get_ContainerTrans() { }

	// RVA: 0x7FC30B4 Offset: 0x7FBF0B4 VA: 0x7FC30B4
	public ScrollRect get_ScrollRect() { }

	// RVA: 0x7FC30BC Offset: 0x7FBF0BC VA: 0x7FC30BC
	public bool get_IsDraging() { }

	// RVA: 0x7FC30C4 Offset: 0x7FBF0C4 VA: 0x7FC30C4
	public GridViewLayoutParam get_LayoutParam() { }

	// RVA: 0x7FC30CC Offset: 0x7FBF0CC VA: 0x7FC30CC
	public bool get_IsInited() { }

	// RVA: 0x7FC30D4 Offset: 0x7FBF0D4 VA: 0x7FC30D4
	public StaggeredGridItemGroup GetItemGroupByIndex(int index) { }

	// RVA: 0x7FC3158 Offset: 0x7FBF158 VA: 0x7FC3158
	public StaggeredGridItemPrefabConfData GetItemPrefabConfData(string prefabName) { }

	// RVA: 0x7FC3380 Offset: 0x7FBF380 VA: 0x7FC3380
	public void InitListView(int itemTotalCount, GridViewLayoutParam layoutParam, Func<LoopStaggeredGridView, int, LoopStaggeredGridViewItem> onGetItemByItemIndex, StaggeredGridViewInitParam initParam) { }

	// RVA: 0x7FC4AFC Offset: 0x7FC0AFC VA: 0x7FC4AFC
	public void ResetGridViewLayoutParam(int itemTotalCount, GridViewLayoutParam layoutParam) { }

	// RVA: 0x7FC50DC Offset: 0x7FC10DC VA: 0x7FC50DC
	private void OnPointerDownInScrollBar(GameObject obj) { }

	// RVA: 0x7FC50E8 Offset: 0x7FC10E8 VA: 0x7FC50E8
	private void OnPointerUpInScrollBar(GameObject obj) { }

	// RVA: 0x7FC426C Offset: 0x7FC026C VA: 0x7FC426C
	private void ReplaceScrollbarEventHandlerForSmoothMove() { }

	// RVA: 0x7FC50F0 Offset: 0x7FC10F0 VA: 0x7FC50F0
	private void OnScrollBarValueChanged(float value) { }

	// RVA: 0x7FC39E4 Offset: 0x7FBF9E4 VA: 0x7FC39E4
	private void UpdateItemSize() { }

	// RVA: 0x7FC44D4 Offset: 0x7FC04D4 VA: 0x7FC44D4
	private void UpdateLayoutParamAutoValue() { }

	// RVA: 0x7FC517C Offset: 0x7FC117C VA: 0x7FC517C
	public LoopStaggeredGridViewItem NewListViewItem(string itemPrefabName) { }

	// RVA: 0x7FC4E28 Offset: 0x7FC0E28 VA: 0x7FC4E28
	public void SetListItemCount(int itemCount, bool resetPos = True) { }

	// RVA: 0x7FC554C Offset: 0x7FC154C VA: 0x7FC554C
	public void MovePanelToItemIndex(int itemIndex, float offset) { }

	// RVA: 0x7FC5B5C Offset: 0x7FC1B5C VA: 0x7FC5B5C
	public LoopStaggeredGridViewItem GetShownItemByItemIndex(int itemIndex) { }

	// RVA: 0x7FC5D18 Offset: 0x7FC1D18 VA: 0x7FC5D18
	public void RefreshAllShownItem() { }

	// RVA: 0x7FC5E34 Offset: 0x7FC1E34 VA: 0x7FC5E34
	public void OnItemSizeChanged(int itemIndex) { }

	// RVA: 0x7FC5F54 Offset: 0x7FC1F54 VA: 0x7FC5F54
	public void RefreshItemByItemIndex(int itemIndex) { }

	// RVA: 0x7FC61B8 Offset: 0x7FC21B8 VA: 0x7FC61B8
	public void ResetListView(bool resetPos = True) { }

	// RVA: 0x7FC57F4 Offset: 0x7FC17F4 VA: 0x7FC57F4
	public float get_ViewPortSize() { }

	// RVA: 0x7FC5134 Offset: 0x7FC1134 VA: 0x7FC5134
	public float get_ViewPortWidth() { }

	// RVA: 0x7FC5158 Offset: 0x7FC1158 VA: 0x7FC5158
	public float get_ViewPortHeight() { }

	// RVA: 0x7FC4FAC Offset: 0x7FC0FAC VA: 0x7FC4FAC
	public void RecycleAllItem() { }

	// RVA: 0x7FC63C8 Offset: 0x7FC23C8 VA: 0x7FC63C8
	public void RecycleItemTmp(LoopStaggeredGridViewItem item) { }

	// RVA: 0x7FC5044 Offset: 0x7FC1044 VA: 0x7FC5044
	public void ClearAllTmpRecycledItem() { }

	// RVA: 0x7FC3CD4 Offset: 0x7FBFCD4 VA: 0x7FC3CD4
	private void AdjustContainerPivot(RectTransform rtf) { }

	// RVA: 0x7FC3B94 Offset: 0x7FBFB94 VA: 0x7FC3B94
	private void AdjustPivot(RectTransform rtf) { }

	// RVA: 0x7FC6618 Offset: 0x7FC2618 VA: 0x7FC6618
	private void AdjustContainerAnchor(RectTransform rtf) { }

	// RVA: 0x7FC3C08 Offset: 0x7FBFC08 VA: 0x7FC3C08
	private void AdjustAnchor(RectTransform rtf) { }

	// RVA: 0x7FC3D48 Offset: 0x7FBFD48 VA: 0x7FC3D48
	private void InitItemPool() { }

	// RVA: 0x7FC6864 Offset: 0x7FC2864 VA: 0x7FC6864 Slot: 7
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x7FC69F8 Offset: 0x7FC29F8 VA: 0x7FC69F8 Slot: 8
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x7FC6A48 Offset: 0x7FC2A48 VA: 0x7FC6A48 Slot: 9
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x7FC68AC Offset: 0x7FC28AC VA: 0x7FC68AC
	private void CacheDragPointerEventData(PointerEventData eventData) { }

	// RVA: 0x7FC6A88 Offset: 0x7FC2A88 VA: 0x7FC6A88
	public int get_CurMaxCreatedItemIndexCount() { }

	// RVA: 0x7FC5890 Offset: 0x7FC1890 VA: 0x7FC5890
	private void SetAnchoredPositionX(RectTransform rtf, float x) { }

	// RVA: 0x7FC5854 Offset: 0x7FC1854 VA: 0x7FC5854
	private void SetAnchoredPositionY(RectTransform rtf, float y) { }

	// RVA: 0x7FC5BA4 Offset: 0x7FC1BA4 VA: 0x7FC5BA4
	public ItemIndexData GetItemIndexData(int itemIndex) { }

	// RVA: 0x7FC6AD0 Offset: 0x7FC2AD0 VA: 0x7FC6AD0
	public void UpdateAllGroupShownItemsPos() { }

	// RVA: 0x7FC575C Offset: 0x7FC175C VA: 0x7FC575C
	private void CheckAllGroupIfNeedUpdateItemPos() { }

	// RVA: 0x7FC58CC Offset: 0x7FC18CC VA: 0x7FC58CC
	public float GetItemAbsPosByItemIndex(int itemIndex) { }

	// RVA: 0x7FC72CC Offset: 0x7FC32CC VA: 0x7FC72CC
	public LoopStaggeredGridViewItem GetNewItemByGroupAndIndex(int groupIndex, int indexInGroup) { }

	// RVA: 0x7FC75F8 Offset: 0x7FC35F8 VA: 0x7FC75F8
	private int GetCurShouldAddNewItemGroupIndex() { }

	// RVA: 0x7FC7784 Offset: 0x7FC3784 VA: 0x7FC7784
	public void UpdateListViewWithDefault() { }

	// RVA: 0x7FC77A4 Offset: 0x7FC37A4 VA: 0x7FC77A4
	private void Update() { }

	// RVA: 0x7FC5998 Offset: 0x7FC1998 VA: 0x7FC5998
	public void UpdateListView(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1) { }

	// RVA: 0x7FC5824 Offset: 0x7FC1824 VA: 0x7FC5824
	public float GetContentSize() { }

	// RVA: 0x7FC49C4 Offset: 0x7FC09C4 VA: 0x7FC49C4
	public void UpdateContentSize() { }

	// RVA: 0x7FC79B4 Offset: 0x7FC39B4 VA: 0x7FC79B4
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class LoopStaggeredGridViewItem : MonoBehaviour // TypeDefIndex: 26523
{
	// Fields
	private int mItemIndex; // 0x20
	private int mItemIndexInGroup; // 0x24
	private int mItemId; // 0x28
	private float mPadding; // 0x2C
	private float mExtraPadding; // 0x30
	private bool mIsInitHandlerCalled; // 0x34
	private string mItemPrefabName; // 0x38
	private RectTransform mCachedRectTransform; // 0x40
	private LoopStaggeredGridView mParentListView; // 0x48
	private float mDistanceWithViewPortSnapCenter; // 0x50
	private int mItemCreatedCheckFrameCount; // 0x54
	private float mStartPosOffset; // 0x58
	private object mUserObjectData; // 0x60
	private int mUserIntData1; // 0x68
	private int mUserIntData2; // 0x6C
	private string mUserStringData1; // 0x70
	private string mUserStringData2; // 0x78

	// Properties
	public object UserObjectData { get; set; }
	public int UserIntData1 { get; set; }
	public int UserIntData2 { get; set; }
	public string UserStringData1 { get; set; }
	public string UserStringData2 { get; set; }
	public float DistanceWithViewPortSnapCenter { get; set; }
	public float StartPosOffset { get; set; }
	public int ItemCreatedCheckFrameCount { get; set; }
	public float Padding { get; set; }
	public float ExtraPadding { get; set; }
	public RectTransform CachedRectTransform { get; }
	public string ItemPrefabName { get; set; }
	public int ItemIndexInGroup { get; set; }
	public int ItemIndex { get; set; }
	public int ItemId { get; set; }
	public bool IsInitHandlerCalled { get; set; }
	public LoopStaggeredGridView ParentListView { get; set; }
	public float TopY { get; }
	public float BottomY { get; }
	public float LeftX { get; }
	public float RightX { get; }
	public float ItemSize { get; }
	public float ItemSizeWithPadding { get; }

	// Methods

	// RVA: 0x7FC7C30 Offset: 0x7FC3C30 VA: 0x7FC7C30
	public object get_UserObjectData() { }

	// RVA: 0x7FC7C38 Offset: 0x7FC3C38 VA: 0x7FC7C38
	public void set_UserObjectData(object value) { }

	// RVA: 0x7FC7C40 Offset: 0x7FC3C40 VA: 0x7FC7C40
	public int get_UserIntData1() { }

	// RVA: 0x7FC7C48 Offset: 0x7FC3C48 VA: 0x7FC7C48
	public void set_UserIntData1(int value) { }

	// RVA: 0x7FC7C50 Offset: 0x7FC3C50 VA: 0x7FC7C50
	public int get_UserIntData2() { }

	// RVA: 0x7FC7C58 Offset: 0x7FC3C58 VA: 0x7FC7C58
	public void set_UserIntData2(int value) { }

	// RVA: 0x7FC7C60 Offset: 0x7FC3C60 VA: 0x7FC7C60
	public string get_UserStringData1() { }

	// RVA: 0x7FC7C68 Offset: 0x7FC3C68 VA: 0x7FC7C68
	public void set_UserStringData1(string value) { }

	// RVA: 0x7FC7C70 Offset: 0x7FC3C70 VA: 0x7FC7C70
	public string get_UserStringData2() { }

	// RVA: 0x7FC7C78 Offset: 0x7FC3C78 VA: 0x7FC7C78
	public void set_UserStringData2(string value) { }

	// RVA: 0x7FC7C80 Offset: 0x7FC3C80 VA: 0x7FC7C80
	public float get_DistanceWithViewPortSnapCenter() { }

	// RVA: 0x7FC7C88 Offset: 0x7FC3C88 VA: 0x7FC7C88
	public void set_DistanceWithViewPortSnapCenter(float value) { }

	// RVA: 0x7FC7C90 Offset: 0x7FC3C90 VA: 0x7FC7C90
	public float get_StartPosOffset() { }

	// RVA: 0x7FC7C98 Offset: 0x7FC3C98 VA: 0x7FC7C98
	public void set_StartPosOffset(float value) { }

	// RVA: 0x7FC7CA0 Offset: 0x7FC3CA0 VA: 0x7FC7CA0
	public int get_ItemCreatedCheckFrameCount() { }

	// RVA: 0x7FC7CA8 Offset: 0x7FC3CA8 VA: 0x7FC7CA8
	public void set_ItemCreatedCheckFrameCount(int value) { }

	// RVA: 0x7FC7CB0 Offset: 0x7FC3CB0 VA: 0x7FC7CB0
	public float get_Padding() { }

	// RVA: 0x7FC7CB8 Offset: 0x7FC3CB8 VA: 0x7FC7CB8
	public void set_Padding(float value) { }

	// RVA: 0x7FC7CC0 Offset: 0x7FC3CC0 VA: 0x7FC7CC0
	public float get_ExtraPadding() { }

	// RVA: 0x7FC7CC8 Offset: 0x7FC3CC8 VA: 0x7FC7CC8
	public void set_ExtraPadding(float value) { }

	// RVA: 0x7FC7CD0 Offset: 0x7FC3CD0 VA: 0x7FC7CD0
	public RectTransform get_CachedRectTransform() { }

	// RVA: 0x7FC7D88 Offset: 0x7FC3D88 VA: 0x7FC7D88
	public string get_ItemPrefabName() { }

	// RVA: 0x7FC7D90 Offset: 0x7FC3D90 VA: 0x7FC7D90
	public void set_ItemPrefabName(string value) { }

	// RVA: 0x7FC7D98 Offset: 0x7FC3D98 VA: 0x7FC7D98
	public int get_ItemIndexInGroup() { }

	// RVA: 0x7FC7DA0 Offset: 0x7FC3DA0 VA: 0x7FC7DA0
	public void set_ItemIndexInGroup(int value) { }

	// RVA: 0x7FC7DA8 Offset: 0x7FC3DA8 VA: 0x7FC7DA8
	public int get_ItemIndex() { }

	// RVA: 0x7FC7DB0 Offset: 0x7FC3DB0 VA: 0x7FC7DB0
	public void set_ItemIndex(int value) { }

	// RVA: 0x7FC7DB8 Offset: 0x7FC3DB8 VA: 0x7FC7DB8
	public int get_ItemId() { }

	// RVA: 0x7FC7DC0 Offset: 0x7FC3DC0 VA: 0x7FC7DC0
	public void set_ItemId(int value) { }

	// RVA: 0x7FC7DC8 Offset: 0x7FC3DC8 VA: 0x7FC7DC8
	public bool get_IsInitHandlerCalled() { }

	// RVA: 0x7FC7DD0 Offset: 0x7FC3DD0 VA: 0x7FC7DD0
	public void set_IsInitHandlerCalled(bool value) { }

	// RVA: 0x7FC7DDC Offset: 0x7FC3DDC VA: 0x7FC7DDC
	public LoopStaggeredGridView get_ParentListView() { }

	// RVA: 0x7FC7DE4 Offset: 0x7FC3DE4 VA: 0x7FC7DE4
	public void set_ParentListView(LoopStaggeredGridView value) { }

	// RVA: 0x7FC7DEC Offset: 0x7FC3DEC VA: 0x7FC7DEC
	public float get_TopY() { }

	// RVA: 0x7FC7E70 Offset: 0x7FC3E70 VA: 0x7FC7E70
	public float get_BottomY() { }

	// RVA: 0x7FC7EF4 Offset: 0x7FC3EF4 VA: 0x7FC7EF4
	public float get_LeftX() { }

	// RVA: 0x7FC7F78 Offset: 0x7FC3F78 VA: 0x7FC7F78
	public float get_RightX() { }

	// RVA: 0x7FC7FFC Offset: 0x7FC3FFC VA: 0x7FC7FFC
	public float get_ItemSize() { }

	// RVA: 0x7FC8030 Offset: 0x7FC4030 VA: 0x7FC8030
	public float get_ItemSizeWithPadding() { }

	// RVA: 0x7FC804C Offset: 0x7FC404C VA: 0x7FC804C
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class StaggeredGridItemGroup // TypeDefIndex: 26524
{
	// Fields
	private LoopStaggeredGridView mParentGridView; // 0x10
	private ListItemArrangeType mArrangeType; // 0x18
	private List<LoopStaggeredGridViewItem> mItemList; // 0x20
	private RectTransform mContainerTrans; // 0x28
	private ScrollRect mScrollRect; // 0x30
	public int mGroupIndex; // 0x38
	private GameObject mGameObject; // 0x40
	private List<int> mItemIndexMap; // 0x48
	private RectTransform mScrollRectTransform; // 0x50
	private RectTransform mViewPortRectTransform; // 0x58
	private float mItemDefaultWithPaddingSize; // 0x60
	private int mItemTotalCount; // 0x64
	private bool mIsVertList; // 0x68
	private Func<int, int, LoopStaggeredGridViewItem> mOnGetItemByIndex; // 0x70
	private Vector3[] mItemWorldCorners; // 0x78
	private Vector3[] mViewPortRectLocalCorners; // 0x80
	private int mCurReadyMinItemIndex; // 0x88
	private int mCurReadyMaxItemIndex; // 0x8C
	private bool mNeedCheckNextMinItem; // 0x90
	private bool mNeedCheckNextMaxItem; // 0x91
	private ItemPosMgr mItemPosMgr; // 0x98
	private bool mSupportScrollBar; // 0xA0
	private int mLastItemIndex; // 0xA4
	private float mLastItemPadding; // 0xA8
	private Vector3 mLastFrameContainerPos; // 0xAC
	private int mListUpdateCheckFrameCount; // 0xB8

	// Properties
	public List<int> ItemIndexMap { get; }
	public float ViewPortSize { get; }
	public float ViewPortWidth { get; }
	public float ViewPortHeight { get; }
	private bool IsDraging { get; }
	public int HadCreatedItemCount { get; }

	// Methods

	// RVA: 0x7FC4778 Offset: 0x7FC0778 VA: 0x7FC4778
	public void Init(LoopStaggeredGridView parent, int itemTotalCount, int groupIndex, Func<int, int, LoopStaggeredGridViewItem> onGetItemByIndex) { }

	// RVA: 0x7FC8064 Offset: 0x7FC4064 VA: 0x7FC8064
	public List<int> get_ItemIndexMap() { }

	// RVA: 0x7FC806C Offset: 0x7FC406C VA: 0x7FC806C
	public void ResetListView() { }

	// RVA: 0x7FC8090 Offset: 0x7FC4090 VA: 0x7FC8090
	public LoopStaggeredGridViewItem GetShownItemByItemIndex(int itemIndex) { }

	// RVA: 0x7FC8184 Offset: 0x7FC4184 VA: 0x7FC8184
	public float get_ViewPortSize() { }

	// RVA: 0x7FC81B4 Offset: 0x7FC41B4 VA: 0x7FC81B4
	public float get_ViewPortWidth() { }

	// RVA: 0x7FC81D8 Offset: 0x7FC41D8 VA: 0x7FC81D8
	public float get_ViewPortHeight() { }

	// RVA: 0x7FC81FC Offset: 0x7FC41FC VA: 0x7FC81FC
	private bool get_IsDraging() { }

	// RVA: 0x7FC5C28 Offset: 0x7FC1C28 VA: 0x7FC5C28
	public LoopStaggeredGridViewItem GetShownItemByIndexInGroup(int indexInGroup) { }

	// RVA: 0x7FC8218 Offset: 0x7FC4218 VA: 0x7FC8218
	public int GetIndexInShownItemList(LoopStaggeredGridViewItem item) { }

	// RVA: 0x7FC5DB0 Offset: 0x7FC1DB0 VA: 0x7FC5DB0
	public void RefreshAllShownItem() { }

	// RVA: 0x7FC5E7C Offset: 0x7FC1E7C VA: 0x7FC5E7C
	public void OnItemSizeChanged(int indexInGroup) { }

	// RVA: 0x7FC5F9C Offset: 0x7FC1F9C VA: 0x7FC5F9C
	public void RefreshItemByIndexInGroup(int indexInGroup) { }

	// RVA: 0x7FC8320 Offset: 0x7FC4320 VA: 0x7FC8320
	public void RefreshAllShownItemWithFirstIndexInGroup(int firstItemIndexInGroup) { }

	// RVA: 0x7FC85F4 Offset: 0x7FC45F4 VA: 0x7FC85F4
	public void RefreshAllShownItemWithFirstIndexAndPos(int firstItemIndexInGroup, Vector3 pos) { }

	// RVA: 0x7FC854C Offset: 0x7FC454C VA: 0x7FC854C
	private void SetItemSize(int itemIndex, float itemSize, float padding) { }

	// RVA: 0x7FC87B4 Offset: 0x7FC47B4 VA: 0x7FC87B4
	private bool GetPlusItemIndexAndPosAtGivenPos(float pos, ref int index, ref float itemPos) { }

	// RVA: 0x7FC72B0 Offset: 0x7FC32B0 VA: 0x7FC72B0
	public float GetItemPos(int itemIndex) { }

	// RVA: 0x7FC87D0 Offset: 0x7FC47D0 VA: 0x7FC87D0
	public Vector3 GetItemCornerPosInViewPort(LoopStaggeredGridViewItem item, ItemCornerEnum corner = 0) { }

	// RVA: 0x7FC85A0 Offset: 0x7FC45A0 VA: 0x7FC85A0
	public void RecycleItemTmp(LoopStaggeredGridViewItem item) { }

	// RVA: 0x7FC6244 Offset: 0x7FC2244 VA: 0x7FC6244
	public void RecycleAllItem() { }

	// RVA: 0x7FC85DC Offset: 0x7FC45DC VA: 0x7FC85DC
	public void ClearAllTmpRecycledItem() { }

	// RVA: 0x7FC85B8 Offset: 0x7FC45B8 VA: 0x7FC85B8
	private LoopStaggeredGridViewItem GetNewItemByIndexInGroup(int indexInGroup) { }

	// RVA: 0x7FC8844 Offset: 0x7FC4844 VA: 0x7FC8844
	public int get_HadCreatedItemCount() { }

	// RVA: 0x7FC5458 Offset: 0x7FC1458 VA: 0x7FC5458
	public void SetListItemCount(int itemCount) { }

	// RVA: 0x7FC888C Offset: 0x7FC488C VA: 0x7FC888C
	private void UpdateItemIndexMap(int oldItemTotalCount) { }

	// RVA: 0x7FC77E4 Offset: 0x7FC37E4 VA: 0x7FC77E4
	public void UpdateListViewPart1(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1) { }

	// RVA: 0x7FC796C Offset: 0x7FC396C VA: 0x7FC796C
	public bool UpdateListViewPart2(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1) { }

	// RVA: 0x7FC8A20 Offset: 0x7FC4A20 VA: 0x7FC8A20
	public bool UpdateForVertListPart1(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1) { }

	// RVA: 0x7FCA574 Offset: 0x7FC6574 VA: 0x7FCA574
	public bool UpdateForVertListPart2(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1) { }

	// RVA: 0x7FC97B4 Offset: 0x7FC57B4 VA: 0x7FC97B4
	public bool UpdateForHorizontalListPart1(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1) { }

	// RVA: 0x7FCAD00 Offset: 0x7FC6D00 VA: 0x7FCAD00
	public bool UpdateForHorizontalListPart2(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1) { }

	// RVA: 0x7FC797C Offset: 0x7FC397C VA: 0x7FC797C
	public float GetContentPanelSize() { }

	// RVA: 0x7FC76BC Offset: 0x7FC36BC VA: 0x7FC76BC
	public float GetShownItemPosMaxValue() { }

	// RVA: 0x7FC6EF0 Offset: 0x7FC2EF0 VA: 0x7FC6EF0
	public void CheckIfNeedUpdateItemPos() { }

	// RVA: 0x7FC6B68 Offset: 0x7FC2B68 VA: 0x7FC6B68
	public void UpdateAllShownItemsPos() { }

	// RVA: 0x7FC4600 Offset: 0x7FC0600 VA: 0x7FC4600
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class StaggeredGridItemPool // TypeDefIndex: 26525
{
	// Fields
	private GameObject mPrefabObj; // 0x10
	private string mPrefabName; // 0x18
	private int mInitCreateCount; // 0x20
	private float mPadding; // 0x24
	private List<LoopStaggeredGridViewItem> mTmpPooledItemList; // 0x28
	private List<LoopStaggeredGridViewItem> mPooledItemList; // 0x30
	private static int mCurItemIdCount; // 0x0
	private RectTransform mItemParent; // 0x38

	// Methods

	// RVA: 0x7FC66E4 Offset: 0x7FC26E4 VA: 0x7FC66E4
	public void .ctor() { }

	// RVA: 0x7FC6798 Offset: 0x7FC2798 VA: 0x7FC6798
	public void Init(GameObject prefabObj, float padding, int createCount, RectTransform parent) { }

	// RVA: 0x7FC530C Offset: 0x7FC130C VA: 0x7FC530C
	public LoopStaggeredGridViewItem GetItem() { }

	// RVA: 0x7FCB7C8 Offset: 0x7FC77C8 VA: 0x7FCB7C8
	public void DestroyAllItem() { }

	// RVA: 0x7FCB49C Offset: 0x7FC749C VA: 0x7FCB49C
	public LoopStaggeredGridViewItem CreateItem() { }

	// RVA: 0x7FCB6FC Offset: 0x7FC76FC VA: 0x7FCB6FC
	private void RecycleItemReal(LoopStaggeredGridViewItem item) { }

	// RVA: 0x7FC6494 Offset: 0x7FC2494 VA: 0x7FC6494
	public void RecycleItem(LoopStaggeredGridViewItem item) { }

	// RVA: 0x7FC6540 Offset: 0x7FC2540 VA: 0x7FC6540
	public void ClearTmpRecycledItem() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1169 // TypeDefIndex: 26526
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1367 // TypeDefIndex: 26527
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 26528
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1169 2EB2BFC057F412F3D99FA6D13F689F0C1676082B633DDCE21A9A14DA9485A2D3 /*Metadata offset 0xF45708*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1367 31E88AE51DC3019DF630480734CCDCA7B62353563629464874A0AAC0BBF3F63B /*Metadata offset 0xF45BA0*/; // 0x491
}


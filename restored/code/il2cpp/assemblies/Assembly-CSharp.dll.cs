// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 22587
{}

// Namespace: 
[DefaultMember("Item")]
[ExecuteInEditMode]
[Serializable]
public class BezierCurve : MonoBehaviour // TypeDefIndex: 22588
{
	// Fields
	public int resolution; // 0x20
	[CompilerGenerated]
	private bool <dirty>k__BackingField; // 0x24
	public Color drawColor; // 0x28
	[SerializeField]
	private bool _close; // 0x38
	[SerializeField]
	private float _length; // 0x3C
	[SerializeField]
	public BezierPoint[] points; // 0x40

	// Properties
	public bool dirty { get; set; }
	public bool close { get; set; }
	public BezierPoint Item { get; }
	public int pointCount { get; }
	public float length { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3B612F4 Offset: 0x3B5D2F4 VA: 0x3B612F4
	public bool get_dirty() { }

	[CompilerGenerated]
	// RVA: 0x3B612FC Offset: 0x3B5D2FC VA: 0x3B612FC
	private void set_dirty(bool value) { }

	// RVA: 0x3B61308 Offset: 0x3B5D308 VA: 0x3B61308
	public bool get_close() { }

	// RVA: 0x3B61310 Offset: 0x3B5D310 VA: 0x3B61310
	public void set_close(bool value) { }

	// RVA: 0x3B61330 Offset: 0x3B5D330 VA: 0x3B61330
	public BezierPoint get_Item(int index) { }

	// RVA: 0x3B61360 Offset: 0x3B5D360 VA: 0x3B61360
	public int get_pointCount() { }

	// RVA: 0x3B6137C Offset: 0x3B5D37C VA: 0x3B6137C
	public float get_length() { }

	// RVA: 0x3B61580 Offset: 0x3B5D580 VA: 0x3B61580
	private void OnDrawGizmos() { }

	// RVA: 0x3B61760 Offset: 0x3B5D760 VA: 0x3B61760
	private void Awake() { }

	// RVA: 0x3B6176C Offset: 0x3B5D76C VA: 0x3B6176C
	public void AddPoint(BezierPoint point) { }

	// RVA: 0x3B618A4 Offset: 0x3B5D8A4 VA: 0x3B618A4
	public BezierPoint AddPointAt(Vector3 position) { }

	// RVA: 0x3B61A98 Offset: 0x3B5DA98 VA: 0x3B61A98
	public void RemovePoint(BezierPoint point) { }

	// RVA: 0x3B61B80 Offset: 0x3B5DB80 VA: 0x3B61B80
	public BezierPoint[] GetAnchorPoints() { }

	// RVA: 0x3B61BF8 Offset: 0x3B5DBF8 VA: 0x3B61BF8
	public Vector3 GetPointAt(float t) { }

	// RVA: 0x3B6201C Offset: 0x3B5E01C VA: 0x3B6201C
	public int GetPointIndex(BezierPoint point) { }

	// RVA: 0x3B620D0 Offset: 0x3B5E0D0 VA: 0x3B620D0
	public void SetDirty() { }

	// RVA: 0x3B61674 Offset: 0x3B5D674 VA: 0x3B61674
	public static void DrawCurve(BezierPoint p1, BezierPoint p2, int resolution) { }

	// RVA: 0x3B61E04 Offset: 0x3B5DE04 VA: 0x3B61E04
	public static Vector3 GetPoint(BezierPoint p1, BezierPoint p2, float t) { }

	// RVA: 0x3B62134 Offset: 0x3B5E134 VA: 0x3B62134
	public static Vector3 GetCubicCurvePoint(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4, float t) { }

	// RVA: 0x3B6225C Offset: 0x3B5E25C VA: 0x3B6225C
	public static Vector3 GetQuadraticCurvePoint(Vector3 p1, Vector3 p2, Vector3 p3, float t) { }

	// RVA: 0x3B622D0 Offset: 0x3B5E2D0 VA: 0x3B622D0
	public static Vector3 GetLinearPoint(Vector3 p1, Vector3 p2, float t) { }

	// RVA: 0x3B622F8 Offset: 0x3B5E2F8 VA: 0x3B622F8
	public static Vector3 GetPoint(float t, Vector3[] points) { }

	// RVA: 0x3B61460 Offset: 0x3B5D460 VA: 0x3B61460
	public static float ApproximateLength(BezierPoint p1, BezierPoint p2, int resolution = 10) { }

	// RVA: 0x3B62450 Offset: 0x3B5E450 VA: 0x3B62450
	private static int BinomialCoefficient(int i, int n) { }

	// RVA: 0x3B625C4 Offset: 0x3B5E5C4 VA: 0x3B625C4
	private static int Factoral(int i) { }

	// RVA: 0x3B62648 Offset: 0x3B5E648 VA: 0x3B62648
	public void .ctor() { }
}

// Namespace: 
public enum BezierPoint.HandleStyle // TypeDefIndex: 22589
{
	// Fields
	public int value__; // 0x0
	public const BezierPoint.HandleStyle Connected = 0;
	public const BezierPoint.HandleStyle Broken = 1;
	public const BezierPoint.HandleStyle None = 2;
}

// Namespace: 
[Serializable]
public class BezierPoint : MonoBehaviour // TypeDefIndex: 22590
{
	// Fields
	[SerializeField]
	private BezierCurve _curve; // 0x20
	public BezierPoint.HandleStyle handleStyle; // 0x28
	[SerializeField]
	private Vector3 _handle1; // 0x2C
	[SerializeField]
	private Vector3 _handle2; // 0x38
	private Vector3 lastPosition; // 0x44

	// Properties
	public BezierCurve curve { get; set; }
	public Vector3 position { get; set; }
	public Vector3 localPosition { get; set; }
	public Vector3 handle1 { get; set; }
	public Vector3 globalHandle1 { get; set; }
	public Vector3 handle2 { get; set; }
	public Vector3 globalHandle2 { get; set; }

	// Methods

	// RVA: 0x3B626BC Offset: 0x3B5E6BC VA: 0x3B626BC
	public BezierCurve get_curve() { }

	// RVA: 0x3B619F4 Offset: 0x3B5D9F4 VA: 0x3B619F4
	public void set_curve(BezierCurve value) { }

	// RVA: 0x3B61DE4 Offset: 0x3B5DDE4 VA: 0x3B61DE4
	public Vector3 get_position() { }

	// RVA: 0x3B626C4 Offset: 0x3B5E6C4 VA: 0x3B626C4
	public void set_position(Vector3 value) { }

	// RVA: 0x3B6270C Offset: 0x3B5E70C VA: 0x3B6270C
	public Vector3 get_localPosition() { }

	// RVA: 0x3B6272C Offset: 0x3B5E72C VA: 0x3B6272C
	public void set_localPosition(Vector3 value) { }

	// RVA: 0x3B62774 Offset: 0x3B5E774 VA: 0x3B62774
	public Vector3 get_handle1() { }

	// RVA: 0x3B62780 Offset: 0x3B5E780 VA: 0x3B62780
	public void set_handle1(Vector3 value) { }

	// RVA: 0x3B62108 Offset: 0x3B5E108 VA: 0x3B62108
	public Vector3 get_globalHandle1() { }

	// RVA: 0x3B62810 Offset: 0x3B5E810 VA: 0x3B62810
	public void set_globalHandle1(Vector3 value) { }

	// RVA: 0x3B62864 Offset: 0x3B5E864 VA: 0x3B62864
	public Vector3 get_handle2() { }

	// RVA: 0x3B62870 Offset: 0x3B5E870 VA: 0x3B62870
	public void set_handle2(Vector3 value) { }

	// RVA: 0x3B620DC Offset: 0x3B5E0DC VA: 0x3B620DC
	public Vector3 get_globalHandle2() { }

	// RVA: 0x3B62900 Offset: 0x3B5E900 VA: 0x3B62900
	public void set_globalHandle2(Vector3 value) { }

	// RVA: 0x3B62954 Offset: 0x3B5E954 VA: 0x3B62954
	private void Update() { }

	// RVA: 0x3B629F4 Offset: 0x3B5E9F4 VA: 0x3B629F4
	public void .ctor() { }
}

// Namespace: 
public class ProductRowPrefab : MonoBehaviour // TypeDefIndex: 22591
{
	// Fields
	[SerializeField]
	private RawImage _thumbImg; // 0x20
	[SerializeField]
	private Text _titleText; // 0x28
	[SerializeField]
	private Text _productIdText; // 0x30
	[SerializeField]
	private GameObject _buyBtn; // 0x38
	private Product _product; // 0x40
	private LogScroller _logScroller; // 0x48
	private PurchasePage _parentScript; // 0x50

	// Methods

	// RVA: 0x3B629FC Offset: 0x3B5E9FC VA: 0x3B629FC
	private void Awake() { }

	// RVA: 0x3B62A00 Offset: 0x3B5EA00 VA: 0x3B62A00
	public void OnLogBtnClick() { }

	// RVA: 0x3B62CD8 Offset: 0x3B5ECD8 VA: 0x3B62CD8
	public void OnPurchaseBtnClick() { }

	// RVA: 0x3B62E38 Offset: 0x3B5EE38 VA: 0x3B62E38
	public void Initialize(PurchasePage parentScript, LogScroller logScroller, Product product) { }

	// RVA: 0x3B62F50 Offset: 0x3B5EF50 VA: 0x3B62F50
	private void SetThumb(string productId, string url) { }

	// RVA: 0x3B630B4 Offset: 0x3B5F0B4 VA: 0x3B630B4
	private void LogText(string text) { }

	// RVA: 0x3B630CC Offset: 0x3B5F0CC VA: 0x3B630CC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3B630D4 Offset: 0x3B5F0D4 VA: 0x3B630D4
	private void <SetThumb>b__11_0(Texture texture) { }
}

// Namespace: 
public class PurchaseRowPrefab : MonoBehaviour // TypeDefIndex: 22592
{
	// Fields
	[SerializeField]
	private Text _purchaseTokenText; // 0x20
	[SerializeField]
	private Text _productIdText; // 0x28
	[SerializeField]
	private Text _purchaseTimeText; // 0x30
	[SerializeField]
	private GameObject _consumeBtn; // 0x38
	private string DATE_FORMAT; // 0x40
	private Purchase _purchase; // 0x48
	private LogScroller _logScroller; // 0x50
	private PurchasePage _parentScript; // 0x58

	// Methods

	// RVA: 0x3B630F0 Offset: 0x3B5F0F0 VA: 0x3B630F0
	public string GetPurchaseToken() { }

	// RVA: 0x3B6310C Offset: 0x3B5F10C VA: 0x3B6310C
	public void OnLogBtnClick() { }

	// RVA: 0x3B63144 Offset: 0x3B5F144 VA: 0x3B63144
	public void OnConsumeBtnClick() { }

	// RVA: 0x3B63350 Offset: 0x3B5F350 VA: 0x3B63350
	public void Initialize(PurchasePage parentScript, LogScroller logScroller, Purchase purchase) { }

	// RVA: 0x3B63488 Offset: 0x3B5F488 VA: 0x3B63488
	private void SetConsumeBtnData(bool isConsumed) { }

	// RVA: 0x3B63578 Offset: 0x3B5F578 VA: 0x3B63578
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3B635D0 Offset: 0x3B5F5D0 VA: 0x3B635D0
	private void <OnConsumeBtnClick>b__10_0(bool success) { }
}

// Namespace: 
public class AdsPage : MonoBehaviour // TypeDefIndex: 22593
{
	// Fields
	private LogScroller _logScroller; // 0x20
	private string INTERSTITIAL_PLACEMENT_ID; // 0x28
	private string VIDEO_PLACEMENT_ID; // 0x30

	// Methods

	// RVA: 0x3B6363C Offset: 0x3B5F63C VA: 0x3B6363C
	private void Awake() { }

	// RVA: 0x3B636B4 Offset: 0x3B5F6B4 VA: 0x3B636B4
	public void OnLoadInterstitialBtnClick() { }

	// RVA: 0x3B6377C Offset: 0x3B5F77C VA: 0x3B6377C
	public void OnLoadVideoBtnClick() { }

	// RVA: 0x3B6382C Offset: 0x3B5F82C VA: 0x3B6382C
	public void OnViewInterstitialBtnClick() { }

	// RVA: 0x3B638DC Offset: 0x3B5F8DC VA: 0x3B638DC
	public void OnViewVideoBtnClick() { }

	// RVA: 0x3B63764 Offset: 0x3B5F764 VA: 0x3B63764
	private void _LogText(string text) { }

	// RVA: 0x3B6398C Offset: 0x3B5F98C VA: 0x3B6398C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3B639F4 Offset: 0x3B5F9F4 VA: 0x3B639F4
	private void <OnLoadInterstitialBtnClick>b__4_0(IInterstitialAdResult result) { }

	[CompilerGenerated]
	// RVA: 0x3B63BC0 Offset: 0x3B5FBC0 VA: 0x3B63BC0
	private void <OnLoadVideoBtnClick>b__5_0(IRewardedVideoResult result) { }

	[CompilerGenerated]
	// RVA: 0x3B63D8C Offset: 0x3B5FD8C VA: 0x3B63D8C
	private void <OnViewInterstitialBtnClick>b__6_0(IInterstitialAdResult result) { }

	[CompilerGenerated]
	// RVA: 0x3B63F58 Offset: 0x3B5FF58 VA: 0x3B63F58
	private void <OnViewVideoBtnClick>b__7_0(IRewardedVideoResult result) { }
}

// Namespace: 
public class LogScroller : MonoBehaviour // TypeDefIndex: 22594
{
	// Fields
	[SerializeField]
	private GameObject _content; // 0x20
	[HideInInspector]
	public List<string> texts; // 0x28
	private string DATE_FORMAT; // 0x30
	private int index; // 0x38

	// Methods

	// RVA: 0x3B64124 Offset: 0x3B60124 VA: 0x3B64124
	private void Start() { }

	// RVA: 0x3B64128 Offset: 0x3B60128 VA: 0x3B64128
	public void ClearLogs() { }

	// RVA: 0x3B62A38 Offset: 0x3B5EA38 VA: 0x3B62A38
	public void Log(string text) { }

	// RVA: 0x3B6446C Offset: 0x3B6046C VA: 0x3B6446C
	public void .ctor() { }
}

// Namespace: 
public class MainPage : MonoBehaviour // TypeDefIndex: 22595
{
	// Fields
	[SerializeField]
	private Menu _menu; // 0x20
	private LogScroller _logScroller; // 0x28

	// Methods

	// RVA: 0x3B64518 Offset: 0x3B60518 VA: 0x3B64518
	private void Awake() { }

	// RVA: 0x3B646C0 Offset: 0x3B606C0 VA: 0x3B646C0
	public void OnLogAcessTokenBtnClick() { }

	// RVA: 0x3B64790 Offset: 0x3B60790 VA: 0x3B64790
	public void OnLogPayloadBtnClick() { }

	// RVA: 0x3B64830 Offset: 0x3B60830 VA: 0x3B64830
	public void OnNavBtnClick(string pageName) { }

	// RVA: 0x3B646A8 Offset: 0x3B606A8 VA: 0x3B646A8
	private void _LogText(string text) { }

	// RVA: 0x3B649A4 Offset: 0x3B609A4 VA: 0x3B649A4
	private void _OnInitComplete() { }

	// RVA: 0x3B64AA4 Offset: 0x3B60AA4 VA: 0x3B64AA4
	private void _OnInitCloud(IInitCloudGameResult result) { }

	// RVA: 0x3B64C70 Offset: 0x3B60C70 VA: 0x3B64C70
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3B64C78 Offset: 0x3B60C78 VA: 0x3B64C78
	private void <OnLogPayloadBtnClick>b__4_0(IPayloadResult result) { }
}

// Namespace: 
public class Menu : MonoBehaviour // TypeDefIndex: 22596
{
	// Fields
	[SerializeField]
	private Button _backBtn; // 0x20
	[SerializeField]
	private Sprite _mutedSprite; // 0x28
	[SerializeField]
	private Sprite _volumeSprite; // 0x30
	[SerializeField]
	private Image _mutedBtnImg; // 0x38
	[SerializeField]
	private AudioSource _bgMusic; // 0x40
	[SerializeField]
	private GameObject _pages; // 0x48
	private GameObject _currentPage; // 0x50
	private LogScroller _logScroller; // 0x58
	private bool _muted; // 0x60
	private Stack<GameObject> _pagesStack; // 0x68

	// Methods

	// RVA: 0x3B64D5C Offset: 0x3B60D5C VA: 0x3B64D5C
	private void Awake() { }

	// RVA: 0x3B64848 Offset: 0x3B60848 VA: 0x3B64848
	public void NavToPage(string pageName) { }

	// RVA: 0x3B654C8 Offset: 0x3B614C8 VA: 0x3B654C8
	public void OnBackBtnClick() { }

	// RVA: 0x3B655D4 Offset: 0x3B615D4 VA: 0x3B655D4
	public void OnToggleMuteBtnClick() { }

	// RVA: 0x3B65184 Offset: 0x3B61184 VA: 0x3B65184
	private GameObject _FindChild(Transform target, string name) { }

	// RVA: 0x3B654B0 Offset: 0x3B614B0 VA: 0x3B654B0
	private void _LogText(string text) { }

	// RVA: 0x3B65138 Offset: 0x3B61138 VA: 0x3B65138
	private void _SetMuteBtnIcon() { }

	// RVA: 0x3B65630 Offset: 0x3B61630 VA: 0x3B65630
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PurchasePage.<>c__DisplayClass10_0 // TypeDefIndex: 22597
{
	// Fields
	public PurchasePage <>4__this; // 0x10
	public Purchase purchase; // 0x18
	public Action<bool> callback; // 0x20

	// Methods

	// RVA: 0x3B657E8 Offset: 0x3B617E8 VA: 0x3B657E8
	public void .ctor() { }

	// RVA: 0x3B67200 Offset: 0x3B63200 VA: 0x3B67200
	internal void <ConsumePurchase>b__0(IConsumePurchaseResult result) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PurchasePage.<>c__DisplayClass13_0 // TypeDefIndex: 22598
{
	// Fields
	public PurchasePage <>4__this; // 0x10
	public Product product; // 0x18

	// Methods

	// RVA: 0x3B65ED0 Offset: 0x3B61ED0 VA: 0x3B65ED0
	public void .ctor() { }

	// RVA: 0x3B6746C Offset: 0x3B6346C VA: 0x3B6746C
	internal void <MakePurchase>b__0(IPurchaseResult result) { }
}

// Namespace: 
public class PurchasePage : MonoBehaviour // TypeDefIndex: 22599
{
	// Fields
	[SerializeField]
	private Button _loadProductsBtn; // 0x20
	[SerializeField]
	private Button _loadPurchasesBtn; // 0x28
	[SerializeField]
	private GameObject _productRowPrefab; // 0x30
	[SerializeField]
	private Transform _productScrollTransform; // 0x38
	[SerializeField]
	private GameObject _purchaseRowPrefab; // 0x40
	[SerializeField]
	private Transform _purchaseScrollTransform; // 0x48
	private LogScroller _logScroller; // 0x50
	private IList<Product> _products; // 0x58

	// Methods

	// RVA: 0x3B656B8 Offset: 0x3B616B8 VA: 0x3B656B8
	private void Awake() { }

	// RVA: 0x3B65730 Offset: 0x3B61730 VA: 0x3B65730
	public void CheckReady() { }

	// RVA: 0x3B631D8 Offset: 0x3B5F1D8 VA: 0x3B631D8
	public void ConsumePurchase(Purchase purchase, Action<bool> callback) { }

	// RVA: 0x3B657F0 Offset: 0x3B617F0 VA: 0x3B657F0
	public void LoadProducts() { }

	// RVA: 0x3B65B60 Offset: 0x3B61B60 VA: 0x3B65B60
	public void LoadPurchases() { }

	// RVA: 0x3B62CF8 Offset: 0x3B5ECF8 VA: 0x3B62CF8
	public void MakePurchase(Product product) { }

	// RVA: 0x3B65ED8 Offset: 0x3B61ED8 VA: 0x3B65ED8
	public void ToggleShowConsumedClicked(bool show) { }

	// RVA: 0x3B661C8 Offset: 0x3B621C8 VA: 0x3B661C8
	private void AddPurchase(Purchase purchase, bool setToTop) { }

	// RVA: 0x3B657D0 Offset: 0x3B617D0 VA: 0x3B657D0
	private void LogText(string text) { }

	// RVA: 0x3B662C4 Offset: 0x3B622C4 VA: 0x3B662C4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3B6634C Offset: 0x3B6234C VA: 0x3B6634C
	private void <CheckReady>b__9_0(IIAPReadyResult result) { }

	[CompilerGenerated]
	// RVA: 0x3B66540 Offset: 0x3B62540 VA: 0x3B66540
	private void <LoadProducts>b__11_0(ICatalogResult result) { }

	[CompilerGenerated]
	// RVA: 0x3B66C00 Offset: 0x3B62C00 VA: 0x3B66C00
	private void <LoadPurchases>b__12_0(IPurchasesResult result) { }
}

// Namespace: 
public class SavePage : MonoBehaviour // TypeDefIndex: 22600
{
	// Fields
	[SerializeField]
	private Button _saveLogBtn; // 0x20
	[SerializeField]
	private InputField _customInputField; // 0x28
	[SerializeField]
	private Button _appendDataBtn; // 0x30
	private string LOGS_FOLDER_PATH; // 0x38
	private string PLAYER_PREFS_PATH; // 0x40
	private string SAVE_FILE_PATH; // 0x48
	private LogScroller _logScroller; // 0x50

	// Methods

	// RVA: 0x3B67844 Offset: 0x3B63844 VA: 0x3B67844
	private void Awake() { }

	// RVA: 0x3B679A0 Offset: 0x3B639A0 VA: 0x3B679A0
	public void OnLogPlayerPrefsBtnClick() { }

	// RVA: 0x3B67A44 Offset: 0x3B63A44 VA: 0x3B67A44
	public void OnSavePlayerPrefsBtnClick() { }

	// RVA: 0x3B67AB0 Offset: 0x3B63AB0 VA: 0x3B67AB0
	public void OnDeleteLogFilesBtnClick() { }

	// RVA: 0x3B67B10 Offset: 0x3B63B10 VA: 0x3B67B10
	public void OnSaveLogsBtnClick() { }

	// RVA: 0x3B67D3C Offset: 0x3B63D3C VA: 0x3B67D3C
	public void OnAppendSaveFileBtnClick() { }

	// RVA: 0x3B67F00 Offset: 0x3B63F00 VA: 0x3B67F00
	public void OnDeleteSaveFileBtnClick() { }

	// RVA: 0x3B67F5C Offset: 0x3B63F5C VA: 0x3B67F5C
	public void OnLogSaveFileBtnClick() { }

	// RVA: 0x3B68128 Offset: 0x3B64128 VA: 0x3B68128
	public void OnLogSaveFilePathBtnClick() { }

	// RVA: 0x3B68188 Offset: 0x3B64188 VA: 0x3B68188
	public void .ctor() { }
}

// Namespace: 
public class SettingsMenu : MonoBehaviour // TypeDefIndex: 22601
{
	// Fields
	private bool showSettings; // 0x20

	// Methods

	// RVA: 0x3B68190 Offset: 0x3B64190 VA: 0x3B68190
	public void ToggleActive() { }

	// RVA: 0x3B681C4 Offset: 0x3B641C4 VA: 0x3B681C4
	public void .ctor() { }
}

// Namespace: 
public class UIState : MonoBehaviour // TypeDefIndex: 22602
{
	// Fields
	public LogScroller logScroller; // 0x20

	// Methods

	// RVA: 0x3B681CC Offset: 0x3B641CC VA: 0x3B681CC
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Utility.<GetTexture>d__1 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 22603
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string id; // 0x20
	public Action<Texture> callback; // 0x28
	public string url; // 0x30
	private UnityWebRequest <www>5__2; // 0x38

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3B681D4 Offset: 0x3B641D4 VA: 0x3B681D4
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3B6829C Offset: 0x3B6429C VA: 0x3B6829C Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x3B682A0 Offset: 0x3B642A0 VA: 0x3B682A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3B68488 Offset: 0x3B64488 VA: 0x3B68488 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x3B68490 Offset: 0x3B64490 VA: 0x3B68490 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3B684C8 Offset: 0x3B644C8 VA: 0x3B684C8 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class Utility // TypeDefIndex: 22604
{
	// Fields
	private static Dictionary<string, Texture> _textures; // 0x0

	// Methods

	[IteratorStateMachine(typeof(Utility.<GetTexture>d__1))]
	// RVA: 0x3B63018 Offset: 0x3B5F018 VA: 0x3B63018
	public static IEnumerator GetTexture(string id, string url, Action<Texture> callback) { }

	// RVA: 0x3B681FC Offset: 0x3B641FC VA: 0x3B681FC
	public void .ctor() { }

	// RVA: 0x3B68204 Offset: 0x3B64204 VA: 0x3B68204
	private static void .cctor() { }
}

// Namespace: 
public class InputSystemWarning : MonoBehaviour // TypeDefIndex: 22605
{
	// Methods

	// RVA: 0x3B684D0 Offset: 0x3B644D0 VA: 0x3B684D0
	private void Awake() { }

	// RVA: 0x3B684D4 Offset: 0x3B644D4 VA: 0x3B684D4
	public void .ctor() { }
}

// Namespace: 
public class UIInputHelper : MonoBehaviour // TypeDefIndex: 22606
{
	// Fields
	[CompilerGenerated]
	private FBSDKEventBindingManager <eventBindingManager>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <isOldEventSystem>k__BackingField; // 0x28

	// Properties
	private FBSDKEventBindingManager eventBindingManager { get; set; }
	private bool isOldEventSystem { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3B684DC Offset: 0x3B644DC VA: 0x3B684DC
	private FBSDKEventBindingManager get_eventBindingManager() { }

	[CompilerGenerated]
	// RVA: 0x3B684E4 Offset: 0x3B644E4 VA: 0x3B684E4
	private void set_eventBindingManager(FBSDKEventBindingManager value) { }

	[CompilerGenerated]
	// RVA: 0x3B684EC Offset: 0x3B644EC VA: 0x3B684EC
	private bool get_isOldEventSystem() { }

	[CompilerGenerated]
	// RVA: 0x3B684F4 Offset: 0x3B644F4 VA: 0x3B684F4
	private void set_isOldEventSystem(bool value) { }

	// RVA: 0x3B68500 Offset: 0x3B64500 VA: 0x3B68500
	private void Start() { }

	// RVA: 0x3B68704 Offset: 0x3B64704 VA: 0x3B68704
	private void Update() { }

	// RVA: 0x3B68BB0 Offset: 0x3B64BB0 VA: 0x3B68BB0
	public void .ctor() { }
}

// Namespace: 
public class FBWindowsA2UNotificationsManager : MonoBehaviour // TypeDefIndex: 22607
{
	// Fields
	public FBWindowsLogsManager Logger; // 0x20
	public InputField TitleText; // 0x28
	public InputField BodyText; // 0x30
	public InputField MediaText; // 0x38
	public InputField PayloadText; // 0x40
	public InputField TimeIntervalText; // 0x48

	// Methods

	// RVA: 0x3B68BB8 Offset: 0x3B64BB8 VA: 0x3B68BB8
	public void ScheduleButton() { }

	// RVA: 0x3B68DCC Offset: 0x3B64DCC VA: 0x3B68DCC
	private void A2UNotificationCallback(IScheduleAppToUserNotificationResult result) { }

	// RVA: 0x3B68FB8 Offset: 0x3B64FB8 VA: 0x3B68FB8
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FBWindowsADSManager.<>c__DisplayClass3_0 // TypeDefIndex: 22608
{
	// Fields
	public FBWindowsADSManager <>4__this; // 0x10
	public string placementID; // 0x18

	// Methods

	// RVA: 0x3B690E4 Offset: 0x3B650E4 VA: 0x3B690E4
	public void .ctor() { }

	// RVA: 0x3B69738 Offset: 0x3B65738 VA: 0x3B69738
	internal void <LoadRewardedVideo>b__0(IRewardedVideoResult rewardedVideoResult) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FBWindowsADSManager.<>c__DisplayClass4_0 // TypeDefIndex: 22609
{
	// Fields
	public FBWindowsADSManager <>4__this; // 0x10
	public string placementID; // 0x18

	// Methods

	// RVA: 0x3B69210 Offset: 0x3B65210 VA: 0x3B69210
	public void .ctor() { }

	// RVA: 0x3B698B0 Offset: 0x3B658B0 VA: 0x3B698B0
	internal void <ShowRewardedVideo>b__0(IRewardedVideoResult rewardedVideoResult) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FBWindowsADSManager.<>c__DisplayClass5_0 // TypeDefIndex: 22610
{
	// Fields
	public FBWindowsADSManager <>4__this; // 0x10
	public string placementID; // 0x18

	// Methods

	// RVA: 0x3B6933C Offset: 0x3B6533C VA: 0x3B6933C
	public void .ctor() { }

	// RVA: 0x3B69A54 Offset: 0x3B65A54 VA: 0x3B69A54
	internal void <LoadInterstitialAd>b__0(IInterstitialAdResult interstitialAdResult) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FBWindowsADSManager.<>c__DisplayClass6_0 // TypeDefIndex: 22611
{
	// Fields
	public FBWindowsADSManager <>4__this; // 0x10
	public string placementID; // 0x18

	// Methods

	// RVA: 0x3B69468 Offset: 0x3B65468 VA: 0x3B69468
	public void .ctor() { }

	// RVA: 0x3B69BCC Offset: 0x3B65BCC VA: 0x3B69BCC
	internal void <ShowInterstitialAd>b__0(IInterstitialAdResult interstitialAdResult) { }
}

// Namespace: 
public class FBWindowsADSManager : MonoBehaviour // TypeDefIndex: 22612
{
	// Fields
	public FBWindowsLogsManager Logger; // 0x20
	public InputField InputInterstitialAd; // 0x28
	public InputField InputRewardedVideo; // 0x30

	// Methods

	// RVA: 0x3B68FC0 Offset: 0x3B64FC0 VA: 0x3B68FC0
	public void LoadRewardedVideo(string placementID) { }

	// RVA: 0x3B690EC Offset: 0x3B650EC VA: 0x3B690EC
	public void ShowRewardedVideo(string placementID) { }

	// RVA: 0x3B69218 Offset: 0x3B65218 VA: 0x3B69218
	public void LoadInterstitialAd(string placementID) { }

	// RVA: 0x3B69344 Offset: 0x3B65344 VA: 0x3B69344
	public void ShowInterstitialAd(string placementID) { }

	// RVA: 0x3B69470 Offset: 0x3B65470 VA: 0x3B69470
	public void OnButtonLoadInterstitialAd() { }

	// RVA: 0x3B695A4 Offset: 0x3B655A4 VA: 0x3B695A4
	public void OnButtonShowInterstitialAd() { }

	// RVA: 0x3B69628 Offset: 0x3B65628 VA: 0x3B69628
	public void OnButtonLoadRewardedVideo() { }

	// RVA: 0x3B696AC Offset: 0x3B656AC VA: 0x3B696AC
	public void OnButtonShowRewardedVideo() { }

	// RVA: 0x3B69730 Offset: 0x3B65730 VA: 0x3B69730
	public void .ctor() { }
}

// Namespace: 
public class FBWindowsExampleTabsManager : MonoBehaviour // TypeDefIndex: 22613
{
	// Fields
	public GameObject[] sections; // 0x20

	// Methods

	// RVA: 0x3B69D44 Offset: 0x3B65D44 VA: 0x3B69D44
	private void Start() { }

	// RVA: 0x3B69D4C Offset: 0x3B65D4C VA: 0x3B69D4C
	public void ShowTab(int id) { }

	// RVA: 0x3B69DE8 Offset: 0x3B65DE8 VA: 0x3B69DE8
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FBWindowsFriendsManager.<>c__DisplayClass6_0 // TypeDefIndex: 22614
{
	// Fields
	public FriendFinderInviation item; // 0x10
	public Button button; // 0x18
	public FBWindowsFriendsManager <>4__this; // 0x20

	// Methods

	// RVA: 0x3B6AE44 Offset: 0x3B66E44 VA: 0x3B6AE44
	public void .ctor() { }

	// RVA: 0x3B6AF9C Offset: 0x3B66F9C VA: 0x3B6AF9C
	internal void <GetFriendFinderInvitationsCallback>b__0() { }
}

// Namespace: 
public class FBWindowsFriendsManager : MonoBehaviour // TypeDefIndex: 22615
{
	// Fields
	public FBWindowsLogsManager Logger; // 0x20
	public Transform ReceivedInvitationsPanelTransform; // 0x28
	public GameObject ShowReceivedInvitation; // 0x30

	// Methods

	// RVA: 0x3B69DF0 Offset: 0x3B65DF0 VA: 0x3B69DF0
	public void Button_OpenReceivedInvitations() { }

	// RVA: 0x3B69ED8 Offset: 0x3B65ED8 VA: 0x3B69ED8
	private void OpenFriendsDialogCallBack(IGamingServicesFriendFinderResult result) { }

	// RVA: 0x3B6A014 Offset: 0x3B66014 VA: 0x3B6A014
	public void Button_GetFriendFinderInvitations() { }

	// RVA: 0x3B6A0FC Offset: 0x3B660FC VA: 0x3B6A0FC
	private void GetFriendFinderInvitationsCallback(IFriendFinderInvitationResult receivedInvitations) { }

	// RVA: 0x3B6AE4C Offset: 0x3B66E4C VA: 0x3B6AE4C
	private void DeleteFriendFinderInvitationCallback(IFriendFinderInvitationResult receivedInvitations) { }

	// RVA: 0x3B6AF94 Offset: 0x3B66F94 VA: 0x3B6AF94
	public void .ctor() { }
}

// Namespace: 
public class FBWindowsGraphAPIManager : MonoBehaviour // TypeDefIndex: 22616
{
	// Fields
	public FBWindowsLogsManager Logger; // 0x20
	public InputField QueryText; // 0x28
	public Dropdown QueryType; // 0x30
	public InputField GraphAPIVersionText; // 0x38
	public Text GraphAPIVersion; // 0x40
	private IDictionary<string, string> formData; // 0x48

	// Methods

	// RVA: 0x3B6B06C Offset: 0x3B6706C VA: 0x3B6B06C
	private void Start() { }

	// RVA: 0x3B6B0C0 Offset: 0x3B670C0 VA: 0x3B6B0C0
	private void OnEnable() { }

	// RVA: 0x3B6B1AC Offset: 0x3B671AC VA: 0x3B6B1AC
	public void GraphAPI() { }

	// RVA: 0x3B6B378 Offset: 0x3B67378 VA: 0x3B6B378
	public void SetGraphAPiVersion() { }

	// RVA: 0x3B6B458 Offset: 0x3B67458 VA: 0x3B6B458
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3B6B460 Offset: 0x3B67460 VA: 0x3B6B460
	private void <GraphAPI>b__8_0(IGraphResult result) { }
}

// Namespace: 
public class FBWindowsInitManager : MonoBehaviour // TypeDefIndex: 22617
{
	// Fields
	public FBWindowsLogsManager Logger; // 0x20

	// Methods

	// RVA: 0x3B6B518 Offset: 0x3B67518 VA: 0x3B6B518
	public void InitButton() { }

	// RVA: 0x3B6B648 Offset: 0x3B67648 VA: 0x3B6B648
	private void InitCallback() { }

	// RVA: 0x3B6B7A4 Offset: 0x3B677A4 VA: 0x3B6B7A4
	private void OnHideUnity(bool isGameShown) { }

	// RVA: 0x3B6B7BC Offset: 0x3B677BC VA: 0x3B6B7BC
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FBWindowsLoginManager.<LoadPictureFromUrl>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 22618
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string url; // 0x20
	public RawImage itemImage; // 0x28
	private Texture2D <UserPicture>5__2; // 0x30
	private WWW <www>5__3; // 0x38

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3B6C1F4 Offset: 0x3B681F4 VA: 0x3B6C1F4
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3B6CA9C Offset: 0x3B68A9C VA: 0x3B6CA9C Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x3B6CAA0 Offset: 0x3B68AA0 VA: 0x3B6CAA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3B6CBE0 Offset: 0x3B68BE0 VA: 0x3B6CBE0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x3B6CBE8 Offset: 0x3B68BE8 VA: 0x3B6CBE8 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3B6CC20 Offset: 0x3B68C20 VA: 0x3B6CC20 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class FBWindowsLoginManager : MonoBehaviour // TypeDefIndex: 22619
{
	// Fields
	public FBWindowsLogsManager Logger; // 0x20
	public InputField Permissions; // 0x28
	public RawImage UserImage; // 0x30
	public Text UserName; // 0x38

	// Methods

	// RVA: 0x3B6B7C4 Offset: 0x3B677C4 VA: 0x3B6B7C4
	public void LogInReadButton() { }

	// RVA: 0x3B6B8E4 Offset: 0x3B678E4 VA: 0x3B6B8E4
	public void LogInPublishButton() { }

	// RVA: 0x3B6BA04 Offset: 0x3B67A04 VA: 0x3B6BA04
	public void LogOutButton() { }

	// RVA: 0x3B6BAC8 Offset: 0x3B67AC8 VA: 0x3B6BAC8
	private void AuthCallback(ILoginResult result) { }

	// RVA: 0x3B6BFFC Offset: 0x3B67FFC VA: 0x3B6BFFC
	public void GetCurrentProfile() { }

	// RVA: 0x3B6C0C8 Offset: 0x3B680C8 VA: 0x3B6C0C8
	public void GetUserLocale() { }

	[IteratorStateMachine(typeof(FBWindowsLoginManager.<LoadPictureFromUrl>d__10))]
	// RVA: 0x3B6C16C Offset: 0x3B6816C VA: 0x3B6C16C
	private IEnumerator LoadPictureFromUrl(string url, RawImage itemImage) { }

	// RVA: 0x3B6C21C Offset: 0x3B6821C VA: 0x3B6C21C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3B6C224 Offset: 0x3B68224 VA: 0x3B6C224
	private void <GetCurrentProfile>b__8_0(IProfileResult result) { }

	[CompilerGenerated]
	// RVA: 0x3B6C8B8 Offset: 0x3B688B8 VA: 0x3B6C8B8
	private void <GetUserLocale>b__9_0(ILocaleResult result) { }
}

// Namespace: 
public class FBWindowsLogsManager : MonoBehaviour // TypeDefIndex: 22620
{
	// Fields
	public Text LogText; // 0x20
	public ScrollRect ScrollView; // 0x28

	// Methods

	// RVA: 0x3B6CC28 Offset: 0x3B68C28 VA: 0x3B6CC28
	private void Awake() { }

	// RVA: 0x3B68D1C Offset: 0x3B64D1C VA: 0x3B68D1C
	public void DebugLog(string message) { }

	// RVA: 0x3B68F08 Offset: 0x3B64F08 VA: 0x3B68F08
	public void DebugErrorLog(string message) { }

	// RVA: 0x3B694F4 Offset: 0x3B654F4 VA: 0x3B694F4
	public void DebugWarningLog(string message) { }

	// RVA: 0x3B6CCB8 Offset: 0x3B68CB8 VA: 0x3B6CCB8
	public void DebugClean() { }

	// RVA: 0x3B6CC90 Offset: 0x3B68C90 VA: 0x3B6CC90
	private void ScrollToTheBottom() { }

	// RVA: 0x3B6CD14 Offset: 0x3B68D14 VA: 0x3B6CD14
	public void .ctor() { }
}

// Namespace: 
public class FBWindowsPhysicalGamepadManager : MonoBehaviour // TypeDefIndex: 22621
{
	// Fields
	public Text displayGamepadInputText; // 0x20

	// Methods

	// RVA: 0x3B6CD1C Offset: 0x3B68D1C VA: 0x3B6CD1C
	private void Start() { }

	// RVA: 0x3B6CD78 Offset: 0x3B68D78 VA: 0x3B6CD78
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FBWindowsPurchaseManager.<>c__DisplayClass5_0 // TypeDefIndex: 22622
{
	// Fields
	public Product item; // 0x10
	public FBWindowsPurchaseManager <>4__this; // 0x18

	// Methods

	// RVA: 0x3B6D8C4 Offset: 0x3B698C4 VA: 0x3B6D8C4
	public void .ctor() { }

	// RVA: 0x3B6EDB8 Offset: 0x3B6ADB8 VA: 0x3B6EDB8
	internal void <ProcessGetCatalog>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FBWindowsPurchaseManager.<>c__DisplayClass9_0 // TypeDefIndex: 22623
{
	// Fields
	public Purchase item; // 0x10
	public FBWindowsPurchaseManager <>4__this; // 0x18
	public FacebookDelegate<IConsumePurchaseResult> <>9__1; // 0x20

	// Methods

	// RVA: 0x3B6EDA8 Offset: 0x3B6ADA8 VA: 0x3B6EDA8
	public void .ctor() { }

	// RVA: 0x3B6EE8C Offset: 0x3B6AE8C VA: 0x3B6EE8C
	internal void <processPurchases>b__0() { }

	// RVA: 0x3B6EF60 Offset: 0x3B6AF60 VA: 0x3B6EF60
	internal void <processPurchases>b__1(IConsumePurchaseResult consumeResult) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FBWindowsPurchaseManager.<LoadPictureFromUrl>d__6 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 22624
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string url; // 0x20
	public RawImage itemImage; // 0x28
	private Texture2D <UserPicture>5__2; // 0x30
	private WWW <www>5__3; // 0x38

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3B6D954 Offset: 0x3B69954 VA: 0x3B6D954
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3B6F0CC Offset: 0x3B6B0CC VA: 0x3B6F0CC Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x3B6F0D0 Offset: 0x3B6B0D0 VA: 0x3B6F0D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3B6F210 Offset: 0x3B6B210 VA: 0x3B6F210 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x3B6F218 Offset: 0x3B6B218 VA: 0x3B6F218 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3B6F250 Offset: 0x3B6B250 VA: 0x3B6F250 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class FBWindowsPurchaseManager : MonoBehaviour // TypeDefIndex: 22625
{
	// Fields
	public FBWindowsLogsManager Logger; // 0x20
	public GameObject ProductGameObject; // 0x28
	public Transform CatalogPanelTarnsform; // 0x30
	public Transform PurchasesPanelTarnsform; // 0x38

	// Methods

	// RVA: 0x3B6CD80 Offset: 0x3B68D80 VA: 0x3B6CD80
	public void GetCatalogButton() { }

	// RVA: 0x3B6CE8C Offset: 0x3B68E8C VA: 0x3B6CE8C
	private void ProcessGetCatalog(ICatalogResult result) { }

	[IteratorStateMachine(typeof(FBWindowsPurchaseManager.<LoadPictureFromUrl>d__6))]
	// RVA: 0x3B6D8CC Offset: 0x3B698CC VA: 0x3B6D8CC
	private IEnumerator LoadPictureFromUrl(string url, RawImage itemImage) { }

	// RVA: 0x3B6D97C Offset: 0x3B6997C VA: 0x3B6D97C
	private void ProcessPurchase(IPurchaseResult result) { }

	// RVA: 0x3B6E294 Offset: 0x3B6A294 VA: 0x3B6E294
	public void GetPurchases() { }

	// RVA: 0x3B6E360 Offset: 0x3B6A360 VA: 0x3B6E360
	private void processPurchases(IPurchasesResult result) { }

	// RVA: 0x3B6EDB0 Offset: 0x3B6ADB0 VA: 0x3B6EDB0
	public void .ctor() { }
}

// Namespace: 
public class FBWindowsReferralsManager : MonoBehaviour // TypeDefIndex: 22626
{
	// Fields
	public FBWindowsLogsManager Logger; // 0x20
	public InputField Payload; // 0x28
	public InputField ReferralLinks; // 0x30
	private string _referral_example_payload; // 0x38

	// Methods

	// RVA: 0x3B6F258 Offset: 0x3B6B258 VA: 0x3B6F258
	private void OnEnable() { }

	// RVA: 0x3B6F27C Offset: 0x3B6B27C VA: 0x3B6F27C
	public void CreateReferral() { }

	// RVA: 0x3B6F32C Offset: 0x3B6B32C VA: 0x3B6F32C
	private void CallbackReferralsCreate(IReferralsCreateResult result) { }

	// RVA: 0x3B6F698 Offset: 0x3B6B698 VA: 0x3B6F698
	public void GetDataReferral() { }

	// RVA: 0x3B6F738 Offset: 0x3B6B738 VA: 0x3B6F738
	private void CallbackReferralsGetData(IReferralsGetDataResult result) { }

	// RVA: 0x3B6FA30 Offset: 0x3B6BA30 VA: 0x3B6FA30
	public void .ctor() { }
}

// Namespace: 
public class FBWindowsShareManager : MonoBehaviour // TypeDefIndex: 22627
{
	// Fields
	public FBWindowsLogsManager Logger; // 0x20
	public InputField Caption; // 0x28
	public InputField ImageFile; // 0x30
	public InputField VideoFile; // 0x38
	public InputField TravelID; // 0x40
	public Toggle ShouldShowDialog; // 0x48
	public Button ImageUploadButton; // 0x50
	public Button VideoUploadButton; // 0x58

	// Methods

	// RVA: 0x3B6FA88 Offset: 0x3B6BA88 VA: 0x3B6FA88
	public void Button_UploadImage() { }

	// RVA: 0x3B6FC98 Offset: 0x3B6BC98 VA: 0x3B6FC98
	public void Button_UploadVideo() { }

	// RVA: 0x3B6FEA8 Offset: 0x3B6BEA8 VA: 0x3B6FEA8
	private void CallbackUploadImage(IMediaUploadResult result) { }

	// RVA: 0x3B7011C Offset: 0x3B6C11C VA: 0x3B7011C
	private void CallbackUploadVideo(IMediaUploadResult result) { }

	// RVA: 0x3B70390 Offset: 0x3B6C390 VA: 0x3B70390
	public void .ctor() { }
}

// Namespace: 
public class FBWindowsSoftKeyboardManager : MonoBehaviour // TypeDefIndex: 22628
{
	// Fields
	public FBWindowsLogsManager Logger; // 0x20

	// Methods

	// RVA: 0x3B70398 Offset: 0x3B6C398 VA: 0x3B70398
	public void SetSoftKeyboardOpenButton() { }

	// RVA: 0x3B7043C Offset: 0x3B6C43C VA: 0x3B7043C
	private void CallbackSetSoftKeyboardOpen(ISoftKeyboardOpenResult result) { }

	// RVA: 0x3B7069C Offset: 0x3B6C69C VA: 0x3B7069C
	public void .ctor() { }
}

// Namespace: 
public class FBWindowsTournamentsManager : MonoBehaviour // TypeDefIndex: 22629
{
	// Fields
	public FBWindowsLogsManager Logger; // 0x20
	public InputField Title; // 0x28
	public InputField Image; // 0x30
	public Dropdown SortOrder; // 0x38
	public Dropdown ScoreFormat; // 0x40
	public InputField Data; // 0x48
	public InputField InitialScore; // 0x50
	public InputField Score; // 0x58
	public InputField ShareData; // 0x60

	// Methods

	// RVA: 0x3B706A4 Offset: 0x3B6C6A4 VA: 0x3B706A4
	private Dictionary<string, string> ConvertDataToDict(string UTF8String) { }

	// RVA: 0x3B70A54 Offset: 0x3B6CA54 VA: 0x3B70A54
	public void Button_CreateTournament() { }

	// RVA: 0x3B70BE4 Offset: 0x3B6CBE4 VA: 0x3B70BE4
	private void CallbackCreateTournament(ITournamentResult result) { }

	// RVA: 0x3B70D5C Offset: 0x3B6CD5C VA: 0x3B70D5C
	public void Button_PostSessionScore() { }

	// RVA: 0x3B70E24 Offset: 0x3B6CE24 VA: 0x3B70E24
	private void CallbackPostSessionScore(ISessionScoreResult result) { }

	// RVA: 0x3B70F9C Offset: 0x3B6CF9C VA: 0x3B70F9C
	public void Button_PostTournamentScore() { }

	// RVA: 0x3B71064 Offset: 0x3B6D064 VA: 0x3B71064
	private void CallbackPostTournamentScore(ITournamentScoreResult result) { }

	// RVA: 0x3B711DC Offset: 0x3B6D1DC VA: 0x3B711DC
	public void Button_ShareTournament() { }

	// RVA: 0x3B712BC Offset: 0x3B6D2BC VA: 0x3B712BC
	private void CallbackShareTournament(ITournamentScoreResult result) { }

	// RVA: 0x3B71434 Offset: 0x3B6D434 VA: 0x3B71434
	public void Button_GetTournament() { }

	// RVA: 0x3B714D8 Offset: 0x3B6D4D8 VA: 0x3B714D8
	private void CallbackGetTournament(ITournamentResult result) { }

	// RVA: 0x3B71650 Offset: 0x3B6D650 VA: 0x3B71650
	public void .ctor() { }
}

// Namespace: 
public class FBWindowsVirtualGamepadManager : MonoBehaviour // TypeDefIndex: 22630
{
	// Fields
	public FBWindowsLogsManager Logger; // 0x20
	public InputField NewVirtualGamepadLayout; // 0x28

	// Methods

	// RVA: 0x3B71658 Offset: 0x3B6D658 VA: 0x3B71658
	public void SetVirtualGamepadLayout() { }

	// RVA: 0x3B71724 Offset: 0x3B6D724 VA: 0x3B71724
	private void CallbackSetVirtualGamepadLayout(IVirtualGamepadLayoutResult result) { }

	// RVA: 0x3B71984 Offset: 0x3B6D984 VA: 0x3B71984
	public void .ctor() { }
}

// Namespace: 
public class AOTGenericReferences : MonoBehaviour // TypeDefIndex: 22631
{
	// Fields
	public static readonly IReadOnlyList<string> PatchedAOTAssemblyList; // 0x0

	// Methods

	// RVA: 0x3B7198C Offset: 0x3B6D98C VA: 0x3B7198C
	public void RefMethods() { }

	// RVA: 0x3B71990 Offset: 0x3B6D990 VA: 0x3B71990
	public void .ctor() { }

	// RVA: 0x3B71998 Offset: 0x3B6D998 VA: 0x3B71998
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ScreenShotMovie.<Capture>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 22632
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ScreenShotMovie <>4__this; // 0x20
	private string <fileName>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3B723B8 Offset: 0x3B6E3B8 VA: 0x3B723B8
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3B7246C Offset: 0x3B6E46C VA: 0x3B7246C Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x3B72470 Offset: 0x3B6E470 VA: 0x3B72470 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3B728A4 Offset: 0x3B6E8A4 VA: 0x3B728A4 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x3B728AC Offset: 0x3B6E8AC VA: 0x3B728AC Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3B728E4 Offset: 0x3B6E8E4 VA: 0x3B728E4 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class ScreenShotMovie : MonoBehaviour // TypeDefIndex: 22633
{
	// Fields
	private string folder; // 0x20
	public int frameRate; // 0x28
	public int framesToCapture; // 0x2C
	private int frame; // 0x30
	private string realFolder; // 0x38

	// Methods

	// RVA: 0x3B722D0 Offset: 0x3B6E2D0 VA: 0x3B722D0
	private void Start() { }

	// RVA: 0x3B7232C Offset: 0x3B6E32C VA: 0x3B7232C
	private void Update() { }

	[IteratorStateMachine(typeof(ScreenShotMovie.<Capture>d__7))]
	// RVA: 0x3B7234C Offset: 0x3B6E34C VA: 0x3B7234C
	private IEnumerator Capture() { }

	// RVA: 0x3B723E0 Offset: 0x3B6E3E0 VA: 0x3B723E0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ParticleExporter.<CaptureFrame>d__16 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 22634
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ParticleExporter <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3B72D80 Offset: 0x3B6ED80 VA: 0x3B72D80
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3B72F4C Offset: 0x3B6EF4C VA: 0x3B72F4C Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x3B72F50 Offset: 0x3B6EF50 VA: 0x3B72F50 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3B7341C Offset: 0x3B6F41C VA: 0x3B7341C Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x3B73424 Offset: 0x3B6F424 VA: 0x3B73424 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3B7345C Offset: 0x3B6F45C VA: 0x3B7345C Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class ParticleExporter : MonoBehaviour // TypeDefIndex: 22635
{
	// Fields
	public string folder; // 0x20
	public int frameRate; // 0x28
	public float frameCount; // 0x2C
	public int screenWidth; // 0x30
	public int screenHeight; // 0x34
	public Vector3 cameraPosition; // 0x38
	public Vector3 cameraRotation; // 0x44
	private string realFolder; // 0x50
	private float originaltimescaleTime; // 0x58
	private float currentTime; // 0x5C
	private bool over; // 0x60
	private int currentIndex; // 0x64
	private Camera exportCamera; // 0x68

	// Methods

	// RVA: 0x3B728EC Offset: 0x3B6E8EC VA: 0x3B728EC
	public void Start() { }

	// RVA: 0x3B72BCC Offset: 0x3B6EBCC VA: 0x3B72BCC
	private void Update() { }

	// RVA: 0x3B72CA4 Offset: 0x3B6ECA4 VA: 0x3B72CA4
	private void Cleanup() { }

	[IteratorStateMachine(typeof(ParticleExporter.<CaptureFrame>d__16))]
	// RVA: 0x3B72D14 Offset: 0x3B6ED14 VA: 0x3B72D14
	private IEnumerator CaptureFrame() { }

	// RVA: 0x3B72DA8 Offset: 0x3B6EDA8 VA: 0x3B72DA8
	private Texture2D GetTex2D() { }

	// RVA: 0x3B72E60 Offset: 0x3B6EE60 VA: 0x3B72E60
	public void .ctor() { }
}

// Namespace: 
public class ResetPosition : MonoBehaviour // TypeDefIndex: 22636
{
	// Methods

	[ContextMenu("Reset Settings")]
	// RVA: 0x3B73464 Offset: 0x3B6F464 VA: 0x3B73464
	private void ResetSettings() { }

	// RVA: 0x3B73584 Offset: 0x3B6F584 VA: 0x3B73584
	public void .ctor() { }
}

// Namespace: 
[RequireComponent(typeof(AraTrail))]
public class BakeTrail : MonoBehaviour // TypeDefIndex: 22637
{
	// Fields
	private AraTrail trail; // 0x20

	// Methods

	// RVA: 0x3B7358C Offset: 0x3B6F58C VA: 0x3B7358C
	private void Awake() { }

	// RVA: 0x3B735E4 Offset: 0x3B6F5E4 VA: 0x3B735E4
	private void Update() { }

	// RVA: 0x3B73610 Offset: 0x3B6F610 VA: 0x3B73610
	private void Bake() { }

	// RVA: 0x3B737D8 Offset: 0x3B6F7D8 VA: 0x3B737D8
	public void .ctor() { }
}

// Namespace: 
public class WobblePath : MonoBehaviour // TypeDefIndex: 22638
{
	// Fields
	public float speed; // 0x20
	public float amplitude; // 0x24
	public Vector3 offset; // 0x28

	// Methods

	// RVA: 0x3B737E0 Offset: 0x3B6F7E0 VA: 0x3B737E0
	private void Update() { }

	// RVA: 0x3B73894 Offset: 0x3B6F894 VA: 0x3B73894
	public void .ctor() { }
}

// Namespace: 
public class DynamicBoneDemo1 : MonoBehaviour // TypeDefIndex: 22639
{
	// Fields
	public GameObject m_Player; // 0x20
	private float m_weight; // 0x28

	// Methods

	// RVA: 0x3B738A8 Offset: 0x3B6F8A8 VA: 0x3B738A8
	private void Update() { }

	// RVA: 0x3B739EC Offset: 0x3B6F9EC VA: 0x3B739EC
	private void OnGUI() { }

	// RVA: 0x3B73D54 Offset: 0x3B6FD54 VA: 0x3B73D54
	public void .ctor() { }
}

// Namespace: 
public enum DynamicBone.UpdateMode // TypeDefIndex: 22640
{
	// Fields
	public int value__; // 0x0
	public const DynamicBone.UpdateMode Normal = 0;
	public const DynamicBone.UpdateMode AnimatePhysics = 1;
	public const DynamicBone.UpdateMode UnscaledTime = 2;
	public const DynamicBone.UpdateMode Default = 3;
}

// Namespace: 
public enum DynamicBone.FreezeAxis // TypeDefIndex: 22641
{
	// Fields
	public int value__; // 0x0
	public const DynamicBone.FreezeAxis None = 0;
	public const DynamicBone.FreezeAxis X = 1;
	public const DynamicBone.FreezeAxis Y = 2;
	public const DynamicBone.FreezeAxis Z = 3;
}

// Namespace: 
private class DynamicBone.Particle // TypeDefIndex: 22642
{
	// Fields
	public Transform m_Transform; // 0x10
	public int m_ParentIndex; // 0x18
	public int m_ChildCount; // 0x1C
	public float m_Damping; // 0x20
	public float m_Elasticity; // 0x24
	public float m_Stiffness; // 0x28
	public float m_Inert; // 0x2C
	public float m_Friction; // 0x30
	public float m_Radius; // 0x34
	public float m_BoneLength; // 0x38
	public bool m_isCollide; // 0x3C
	public bool m_TransformNotNull; // 0x3D
	public Vector3 m_Position; // 0x40
	public Vector3 m_PrevPosition; // 0x4C
	public Vector3 m_EndOffset; // 0x58
	public Vector3 m_InitLocalPosition; // 0x64
	public Quaternion m_InitLocalRotation; // 0x70
	public Vector3 m_TransformPosition; // 0x80
	public Vector3 m_TransformLocalPosition; // 0x8C
	public Matrix4x4 m_TransformLocalToWorldMatrix; // 0x98

	// Methods

	// RVA: 0x3B75D04 Offset: 0x3B71D04 VA: 0x3B75D04
	public void .ctor() { }
}

// Namespace: 
private class DynamicBone.ParticleTree // TypeDefIndex: 22643
{
	// Fields
	public Transform m_Root; // 0x10
	public Vector3 m_LocalGravity; // 0x18
	public Matrix4x4 m_RootWorldToLocalMatrix; // 0x24
	public float m_BoneTotalLength; // 0x64
	public List<DynamicBone.Particle> m_Particles; // 0x68
	public Vector3 m_RestGravity; // 0x70

	// Methods

	// RVA: 0x3B75C7C Offset: 0x3B71C7C VA: 0x3B75C7C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicBone.<>c__DisplayClass62_0 // TypeDefIndex: 22644
{
	// Fields
	public Transform root; // 0x10

	// Methods

	// RVA: 0x3B75638 Offset: 0x3B71638 VA: 0x3B75638
	public void .ctor() { }

	// RVA: 0x3B77348 Offset: 0x3B73348 VA: 0x3B77348
	internal bool <SetupParticles>b__0(DynamicBone.ParticleTree x) { }
}

// Namespace: 
[AddComponentMenu("Dynamic Bone/Dynamic Bone")]
public class DynamicBone : MonoBehaviour // TypeDefIndex: 22645
{
	// Fields
	[Tooltip("The roots of the transform hierarchy to apply physics.")]
	public Transform m_Root; // 0x20
	public List<Transform> m_Roots; // 0x28
	[Tooltip("Internal physics simulation rate.")]
	public float m_UpdateRate; // 0x30
	public DynamicBone.UpdateMode m_UpdateMode; // 0x34
	[Tooltip("How much the bones slowed down.")]
	[Range(0, 1)]
	public float m_Damping; // 0x38
	public AnimationCurve m_DampingDistrib; // 0x40
	[Range(0, 1)]
	[Tooltip("How much the force applied to return each bone to original orientation.")]
	public float m_Elasticity; // 0x48
	public AnimationCurve m_ElasticityDistrib; // 0x50
	[Range(0, 1)]
	[Tooltip("How much bone's original orientation are preserved.")]
	public float m_Stiffness; // 0x58
	public AnimationCurve m_StiffnessDistrib; // 0x60
	[Range(0, 1)]
	[Tooltip("How much character's position change is ignored in physics simulation.")]
	public float m_Inert; // 0x68
	public AnimationCurve m_InertDistrib; // 0x70
	[Tooltip("How much the bones slowed down when collide.")]
	public float m_Friction; // 0x78
	public AnimationCurve m_FrictionDistrib; // 0x80
	[Tooltip("Each bone can be a sphere to collide with colliders. Radius describe sphere's size.")]
	public float m_Radius; // 0x88
	public AnimationCurve m_RadiusDistrib; // 0x90
	[Tooltip("If End Length is not zero, an extra bone is generated at the end of transform hierarchy.")]
	public float m_EndLength; // 0x98
	[Tooltip("If End Offset is not zero, an extra bone is generated at the end of transform hierarchy.")]
	public Vector3 m_EndOffset; // 0x9C
	[Tooltip("The force apply to bones. Partial force apply to character's initial pose is cancelled out.")]
	public Vector3 m_Gravity; // 0xA8
	[Tooltip("The force apply to bones.")]
	public Vector3 m_Force; // 0xB4
	[Range(0, 1)]
	[Tooltip("Control how physics blends with existing animation.")]
	public float m_BlendWeight; // 0xC0
	[Tooltip("Collider objects interact with the bones.")]
	public List<DynamicBoneColliderBase> m_Colliders; // 0xC8
	[Tooltip("Bones exclude from physics simulation.")]
	public List<Transform> m_Exclusions; // 0xD0
	[Tooltip("Constrain bones to move on specified plane.")]
	public DynamicBone.FreezeAxis m_FreezeAxis; // 0xD8
	[Tooltip("Disable physics simulation automatically if character is far from camera or player.")]
	public bool m_DistantDisable; // 0xDC
	public Transform m_ReferenceObject; // 0xE0
	public float m_DistanceToObject; // 0xE8
	[HideInInspector]
	public bool m_Multithread; // 0xEC
	private Vector3 m_ObjectMove; // 0xF0
	private Vector3 m_ObjectPrevPosition; // 0xFC
	private float m_ObjectScale; // 0x108
	private float m_Time; // 0x10C
	private float m_Weight; // 0x110
	private bool m_DistantDisabled; // 0x114
	private int m_PreUpdateCount; // 0x118
	private List<DynamicBone.ParticleTree> m_ParticleTrees; // 0x120
	private float m_DeltaTime; // 0x128
	private List<DynamicBoneColliderBase> m_EffectiveColliders; // 0x130
	private static int s_UpdateCount; // 0x0
	private static int s_PrepareFrame; // 0x4

	// Methods

	// RVA: 0x3B73D64 Offset: 0x3B6FD64 VA: 0x3B73D64
	private void Start() { }

	// RVA: 0x3B7406C Offset: 0x3B7006C VA: 0x3B7406C
	private void FixedUpdate() { }

	// RVA: 0x3B740C0 Offset: 0x3B700C0 VA: 0x3B740C0
	private void Update() { }

	// RVA: 0x3B74128 Offset: 0x3B70128 VA: 0x3B74128
	private void LateUpdate() { }

	// RVA: 0x3B74390 Offset: 0x3B70390 VA: 0x3B74390
	private void Prepare() { }

	// RVA: 0x3B7435C Offset: 0x3B7035C VA: 0x3B7435C
	private bool IsNeedUpdate() { }

	// RVA: 0x3B74080 Offset: 0x3B70080 VA: 0x3B74080
	private void PreUpdate() { }

	// RVA: 0x3B741DC Offset: 0x3B701DC VA: 0x3B741DC
	private void CheckDistance() { }

	// RVA: 0x3B74B2C Offset: 0x3B70B2C VA: 0x3B74B2C
	private void OnEnable() { }

	// RVA: 0x3B74B30 Offset: 0x3B70B30 VA: 0x3B74B30
	private void OnDisable() { }

	// RVA: 0x3B74B34 Offset: 0x3B70B34 VA: 0x3B74B34
	private void OnValidate() { }

	// RVA: 0x3B74C64 Offset: 0x3B70C64 VA: 0x3B74C64
	private bool IsRootChanged() { }

	// RVA: 0x3B750E4 Offset: 0x3B710E4 VA: 0x3B750E4
	private void OnDidApplyAnimationProperties() { }

	// RVA: 0x3B750E8 Offset: 0x3B710E8 VA: 0x3B750E8
	private void OnDrawGizmosSelected() { }

	// RVA: 0x3B7520C Offset: 0x3B7120C VA: 0x3B7520C
	private void DrawGizmos(DynamicBone.ParticleTree pt) { }

	// RVA: 0x3B73D00 Offset: 0x3B6FD00 VA: 0x3B73D00
	public void SetWeight(float w) { }

	// RVA: 0x3B752FC Offset: 0x3B712FC VA: 0x3B752FC
	public float GetWeight() { }

	// RVA: 0x3B747E0 Offset: 0x3B707E0 VA: 0x3B747E0
	private void UpdateParticles() { }

	// RVA: 0x3B73D68 Offset: 0x3B6FD68 VA: 0x3B73D68
	public void SetupParticles() { }

	// RVA: 0x3B754D8 Offset: 0x3B714D8 VA: 0x3B754D8
	private void AppendParticleTree(Transform root) { }

	// RVA: 0x3B75640 Offset: 0x3B71640 VA: 0x3B75640
	private void AppendParticles(DynamicBone.ParticleTree pt, Transform b, int parentIndex, float boneLength) { }

	// RVA: 0x3B7504C Offset: 0x3B7104C VA: 0x3B7504C
	public void UpdateParameters() { }

	// RVA: 0x3B75D0C Offset: 0x3B71D0C VA: 0x3B75D0C
	private void UpdateParameters(DynamicBone.ParticleTree pt) { }

	// RVA: 0x3B749FC Offset: 0x3B709FC VA: 0x3B749FC
	private void InitTransforms() { }

	// RVA: 0x3B76104 Offset: 0x3B72104 VA: 0x3B76104
	private void InitTransforms(DynamicBone.ParticleTree pt) { }

	// RVA: 0x3B74A84 Offset: 0x3B70A84 VA: 0x3B74A84
	private void ResetParticlesPosition() { }

	// RVA: 0x3B761D0 Offset: 0x3B721D0 VA: 0x3B761D0
	private void ResetParticlesPosition(DynamicBone.ParticleTree pt) { }

	// RVA: 0x3B75304 Offset: 0x3B71304 VA: 0x3B75304
	private void UpdateParticles1(float timeVar, int loopIndex) { }

	// RVA: 0x3B762C0 Offset: 0x3B722C0 VA: 0x3B762C0
	private void UpdateParticles1(DynamicBone.ParticleTree pt, float timeVar, int loopIndex) { }

	// RVA: 0x3B753B0 Offset: 0x3B713B0 VA: 0x3B753B0
	private void UpdateParticles2(float timeVar) { }

	// RVA: 0x3B76598 Offset: 0x3B72598 VA: 0x3B76598
	private void UpdateParticles2(DynamicBone.ParticleTree pt, float timeVar) { }

	// RVA: 0x3B7544C Offset: 0x3B7144C VA: 0x3B7544C
	private void SkipUpdateParticles() { }

	// RVA: 0x3B76C14 Offset: 0x3B72C14 VA: 0x3B76C14
	private void SkipUpdateParticles(DynamicBone.ParticleTree pt) { }

	// RVA: 0x3B77004 Offset: 0x3B73004 VA: 0x3B77004
	private static Vector3 MirrorVector(Vector3 v, Vector3 axis) { }

	// RVA: 0x3B74900 Offset: 0x3B70900 VA: 0x3B74900
	private void ApplyParticlesToTransforms() { }

	// RVA: 0x3B77038 Offset: 0x3B73038 VA: 0x3B77038
	private void ApplyParticlesToTransforms(DynamicBone.ParticleTree pt, Vector3 ax, Vector3 ay, Vector3 az, bool nx, bool ny, bool nz) { }

	// RVA: 0x3B7721C Offset: 0x3B7321C VA: 0x3B7721C
	public void .ctor() { }
}

// Namespace: 
[AddComponentMenu("Dynamic Bone/Dynamic Bone Collider")]
public class DynamicBoneCollider : DynamicBoneColliderBase // TypeDefIndex: 22646
{
	// Fields
	[Tooltip("The radius of the sphere or capsule.")]
	public float m_Radius; // 0x38
	[Tooltip("The height of the capsule.")]
	public float m_Height; // 0x3C
	[Tooltip("The other radius of the capsule.")]
	public float m_Radius2; // 0x40
	private float m_ScaledRadius; // 0x44
	private float m_ScaledRadius2; // 0x48
	private Vector3 m_C0; // 0x4C
	private Vector3 m_C1; // 0x58
	private float m_C01Distance; // 0x64
	private int m_CollideType; // 0x68

	// Methods

	// RVA: 0x3B773B8 Offset: 0x3B733B8 VA: 0x3B773B8
	private void OnValidate() { }

	// RVA: 0x3B773DC Offset: 0x3B733DC VA: 0x3B773DC Slot: 5
	public override void Prepare() { }

	// RVA: 0x3B77764 Offset: 0x3B73764 VA: 0x3B77764 Slot: 6
	public override bool Collide(ref Vector3 particlePosition, float particleRadius) { }

	// RVA: 0x3B77874 Offset: 0x3B73874 VA: 0x3B77874
	private static bool OutsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius) { }

	// RVA: 0x3B778E4 Offset: 0x3B738E4 VA: 0x3B778E4
	private static bool InsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius) { }

	// RVA: 0x3B77944 Offset: 0x3B73944 VA: 0x3B77944
	private static bool OutsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius, float dirlen) { }

	// RVA: 0x3B77AB8 Offset: 0x3B73AB8 VA: 0x3B77AB8
	private static bool InsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius, float dirlen) { }

	// RVA: 0x3B77C0C Offset: 0x3B73C0C VA: 0x3B77C0C
	private static bool OutsideCapsule2(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius0, float capsuleRadius1, float dirlen) { }

	// RVA: 0x3B77DD8 Offset: 0x3B73DD8 VA: 0x3B77DD8
	private static bool InsideCapsule2(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius0, float capsuleRadius1, float dirlen) { }

	// RVA: 0x3B77F84 Offset: 0x3B73F84 VA: 0x3B77F84
	private void OnDrawGizmosSelected() { }

	// RVA: 0x3B78054 Offset: 0x3B74054 VA: 0x3B78054
	private static void DrawCapsule(Vector3 c0, Vector3 c1, float radius0, float radius1) { }

	// RVA: 0x3B780D4 Offset: 0x3B740D4 VA: 0x3B780D4
	public void .ctor() { }
}

// Namespace: 
public enum DynamicBoneColliderBase.Direction // TypeDefIndex: 22647
{
	// Fields
	public int value__; // 0x0
	public const DynamicBoneColliderBase.Direction X = 0;
	public const DynamicBoneColliderBase.Direction Y = 1;
	public const DynamicBoneColliderBase.Direction Z = 2;
}

// Namespace: 
public enum DynamicBoneColliderBase.Bound // TypeDefIndex: 22648
{
	// Fields
	public int value__; // 0x0
	public const DynamicBoneColliderBase.Bound Outside = 0;
	public const DynamicBoneColliderBase.Bound Inside = 1;
}

// Namespace: 
public class DynamicBoneColliderBase : MonoBehaviour // TypeDefIndex: 22649
{
	// Fields
	[Tooltip("The axis of the capsule's height.")]
	public DynamicBoneColliderBase.Direction m_Direction; // 0x20
	[Tooltip("The center of the sphere or capsule, in the object's local space.")]
	public Vector3 m_Center; // 0x24
	[Tooltip("Constrain bones to outside bound or inside bound.")]
	public DynamicBoneColliderBase.Bound m_Bound; // 0x30
	[CompilerGenerated]
	private int <PrepareFrame>k__BackingField; // 0x34

	// Properties
	public int PrepareFrame { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3B78144 Offset: 0x3B74144 VA: 0x3B78144
	public void set_PrepareFrame(int value) { }

	[CompilerGenerated]
	// RVA: 0x3B7814C Offset: 0x3B7414C VA: 0x3B7814C
	public int get_PrepareFrame() { }

	// RVA: 0x3B78154 Offset: 0x3B74154 VA: 0x3B78154 Slot: 4
	public virtual void Start() { }

	// RVA: 0x3B78158 Offset: 0x3B74158 VA: 0x3B78158 Slot: 5
	public virtual void Prepare() { }

	// RVA: 0x3B7815C Offset: 0x3B7415C VA: 0x3B7815C Slot: 6
	public virtual bool Collide(ref Vector3 particlePosition, float particleRadius) { }

	// RVA: 0x3B780E0 Offset: 0x3B740E0 VA: 0x3B780E0
	public void .ctor() { }
}

// Namespace: 
[AddComponentMenu("Dynamic Bone/Dynamic Bone Plane Collider")]
public class DynamicBonePlaneCollider : DynamicBoneColliderBase // TypeDefIndex: 22650
{
	// Fields
	private Plane m_Plane; // 0x38

	// Methods

	// RVA: 0x3B78164 Offset: 0x3B74164 VA: 0x3B78164
	private void OnValidate() { }

	// RVA: 0x3B78168 Offset: 0x3B74168 VA: 0x3B78168 Slot: 5
	public override void Prepare() { }

	// RVA: 0x3B78338 Offset: 0x3B74338 VA: 0x3B78338 Slot: 6
	public override bool Collide(ref Vector3 particlePosition, float particleRadius) { }

	// RVA: 0x3B783A4 Offset: 0x3B743A4 VA: 0x3B783A4
	private void OnDrawGizmosSelected() { }

	// RVA: 0x3B7844C Offset: 0x3B7444C VA: 0x3B7844C
	public void .ctor() { }
}

// Namespace: 
public class AutoSetAnchorPosForIphonex : MonoBehaviour // TypeDefIndex: 22651
{
	// Fields
	public Canvas mCanvas; // 0x20

	// Methods

	// RVA: 0x3B78450 Offset: 0x3B74450 VA: 0x3B78450
	private void Awake() { }

	// RVA: 0x3B785D0 Offset: 0x3B745D0 VA: 0x3B785D0
	public void .ctor() { }
}

// Namespace: 
public class DragEventForward : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 22652
{
	// Fields
	public ScrollRect parentScrollRect; // 0x20
	private ScrollRect scrollRect; // 0x28

	// Methods

	// RVA: 0x3B785D8 Offset: 0x3B745D8 VA: 0x3B785D8
	private void Awake() { }

	// RVA: 0x3B786D4 Offset: 0x3B746D4 VA: 0x3B786D4 Slot: 4
	public void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x3B78774 Offset: 0x3B74774 VA: 0x3B78774 Slot: 5
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0x3B7895C Offset: 0x3B7495C VA: 0x3B7895C Slot: 6
	public void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x3B789FC Offset: 0x3B749FC VA: 0x3B789FC
	public void .ctor() { }
}

// Namespace: 
public enum DebugGPU.RenderType // TypeDefIndex: 22653
{
	// Fields
	public int value__; // 0x0
	public const DebugGPU.RenderType Normal = 0;
	public const DebugGPU.RenderType Mipmap = 1;
	public const DebugGPU.RenderType Overdraw = 2;
}

// Namespace: 
public class DebugGPU : MonoBehaviour // TypeDefIndex: 22654
{
	// Fields
	public Shader mipmapShader; // 0x20
	public Shader overdrawShader; // 0x28
	private Camera _cachedCamera; // 0x30
	private Texture2D _mipColorsTexture; // 0x38
	private DebugGPU.RenderType _renderType; // 0x40

	// Methods

	// RVA: 0x3B78A04 Offset: 0x3B74A04 VA: 0x3B78A04
	private void Awake() { }

	// RVA: 0x3B78A5C Offset: 0x3B74A5C VA: 0x3B78A5C
	private void OnEable() { }

	// RVA: 0x3B78B0C Offset: 0x3B74B0C VA: 0x3B78B0C
	private void OnDisable() { }

	// RVA: 0x3B78B28 Offset: 0x3B74B28 VA: 0x3B78B28
	private void OnGUI() { }

	// RVA: 0x3B78A60 Offset: 0x3B74A60 VA: 0x3B78A60
	private void UpdateRenderType() { }

	// RVA: 0x3B78CF8 Offset: 0x3B74CF8 VA: 0x3B78CF8
	private void CreateMipColorsTexture() { }

	// RVA: 0x3B78FC0 Offset: 0x3B74FC0 VA: 0x3B78FC0
	public void .ctor() { }
}

// Namespace: 
public class ButtonAnimation : MonoBehaviour // TypeDefIndex: 22655
{
	// Fields
	private float initial_size_x; // 0x20
	private float initial_size_y; // 0x24
	public float factor; // 0x28
	public float speed; // 0x2C
	private bool GO; // 0x30

	// Methods

	// RVA: 0x3B78FC8 Offset: 0x3B74FC8 VA: 0x3B78FC8
	private void Awake() { }

	// RVA: 0x3B79010 Offset: 0x3B75010 VA: 0x3B79010
	private void FixedUpdate() { }

	// RVA: 0x3B790F4 Offset: 0x3B750F4 VA: 0x3B790F4
	private void Go() { }

	// RVA: 0x3B79134 Offset: 0x3B75134 VA: 0x3B79134
	public void .ctor() { }
}

// Namespace: 
public class GameManager : MonoBehaviour // TypeDefIndex: 22656
{
	// Fields
	public TextMesh text_fx_name; // 0x20
	public GameObject[] fx_prefabs; // 0x28
	public int index_fx; // 0x30
	private Ray ray; // 0x34
	private RaycastHit2D ray_cast_hit; // 0x4C

	// Methods

	// RVA: 0x3B79148 Offset: 0x3B75148 VA: 0x3B79148
	private void Start() { }

	// RVA: 0x3B79228 Offset: 0x3B75228 VA: 0x3B79228
	private void Update() { }

	// RVA: 0x3B79934 Offset: 0x3B75934 VA: 0x3B79934
	public void .ctor() { }
}

// Namespace: 
public class SelfDestruct : MonoBehaviour // TypeDefIndex: 22657
{
	// Fields
	public float selfdestruct_in; // 0x20

	// Methods

	// RVA: 0x3B7993C Offset: 0x3B7593C VA: 0x3B7993C
	private void Start() { }

	// RVA: 0x3B799D4 Offset: 0x3B759D4 VA: 0x3B799D4
	public void .ctor() { }
}

// Namespace: 
public struct CameraHolder.SVA // TypeDefIndex: 22658
{
	// Fields
	public float S; // 0x0
	public float V; // 0x4
	public float A; // 0x8
}

// Namespace: 
public class CameraHolder : MonoBehaviour // TypeDefIndex: 22659
{
	// Fields
	public Transform Holder; // 0x20
	public float currDistance; // 0x28
	public float xRotate; // 0x2C
	public float yRotate; // 0x30
	public float yMinLimit; // 0x34
	public float yMaxLimit; // 0x38
	public float prevDistance; // 0x3C
	private float x; // 0x40
	private float y; // 0x44
	[Header("GUI")]
	private float windowDpi; // 0x48
	public GameObject[] Prefabs; // 0x50
	private int Prefab; // 0x58
	private GameObject Instance; // 0x60
	private float StartColor; // 0x68
	private float HueColor; // 0x6C
	public Texture HueTexture; // 0x70
	private ParticleSystem[] particleSystems; // 0x78
	private List<CameraHolder.SVA> svList; // 0x80
	private float H; // 0x88

	// Methods

	// RVA: 0x3B799E4 Offset: 0x3B759E4 VA: 0x3B799E4
	private void Start() { }

	// RVA: 0x3B79D58 Offset: 0x3B75D58 VA: 0x3B79D58
	private void OnGUI() { }

	// RVA: 0x3B79A70 Offset: 0x3B75A70 VA: 0x3B79A70
	private void Counter(int count) { }

	// RVA: 0x3B7A114 Offset: 0x3B76114 VA: 0x3B7A114
	private void LateUpdate() { }

	// RVA: 0x3B7A528 Offset: 0x3B76528 VA: 0x3B7A528
	private static float ClampAngle(float angle, float min, float max) { }

	// RVA: 0x3B7A564 Offset: 0x3B76564 VA: 0x3B7A564
	public void .ctor() { }
}

// Namespace: 
public class Rotator : MonoBehaviour // TypeDefIndex: 22660
{
	// Fields
	public float x; // 0x20
	public float y; // 0x24
	public float z; // 0x28

	// Methods

	// RVA: 0x3B7A630 Offset: 0x3B76630 VA: 0x3B7A630
	private void OnEnable() { }

	// RVA: 0x3B7A688 Offset: 0x3B76688 VA: 0x3B7A688
	private void OnDisable() { }

	// RVA: 0x3B7A690 Offset: 0x3B76690 VA: 0x3B7A690
	private void Rotate() { }

	// RVA: 0x3B7A6E0 Offset: 0x3B766E0 VA: 0x3B7A6E0
	public void .ctor() { }
}

// Namespace: 
public class HS_DemoShooting : MonoBehaviour // TypeDefIndex: 22661
{
	// Fields
	public GameObject FirePoint; // 0x20
	public Camera Cam; // 0x28
	public float MaxLength; // 0x30
	public GameObject[] Prefabs; // 0x38
	private Ray RayMouse; // 0x40
	private Vector3 direction; // 0x58
	private Quaternion rotation; // 0x64
	[Header("GUI")]
	private float windowDpi; // 0x74
	private int Prefab; // 0x78
	private GameObject Instance; // 0x80
	private float hSliderValue; // 0x88
	private float fireCountdown; // 0x8C
	private float buttonSaver; // 0x90
	public Animation camAnim; // 0x98

	// Methods

	// RVA: 0x3B7A6E8 Offset: 0x3B766E8 VA: 0x3B7A6E8
	private void Start() { }

	// RVA: 0x3B7A798 Offset: 0x3B76798 VA: 0x3B7A798
	private void Update() { }

	// RVA: 0x3B7ACD0 Offset: 0x3B76CD0 VA: 0x3B7ACD0
	private void OnGUI() { }

	// RVA: 0x3B7A754 Offset: 0x3B76754 VA: 0x3B7A754
	private void Counter(int count) { }

	// RVA: 0x3B7AC00 Offset: 0x3B76C00 VA: 0x3B7AC00
	private void RotateToMouseDirection(GameObject obj, Vector3 destination) { }

	// RVA: 0x3B7AE70 Offset: 0x3B76E70 VA: 0x3B7AE70
	public void .ctor() { }
}

// Namespace: 
public struct HS_DemoToonVFX.SVA // TypeDefIndex: 22662
{
	// Fields
	public float S; // 0x0
	public float V; // 0x4
	public float A; // 0x8
}

// Namespace: 
public class HS_DemoToonVFX : MonoBehaviour // TypeDefIndex: 22663
{
	// Fields
	public Transform Holder; // 0x20
	public Vector3 cameraPos; // 0x28
	public float currDistance; // 0x34
	public float xRotate; // 0x38
	public float yRotate; // 0x3C
	public float yMinLimit; // 0x40
	public float yMaxLimit; // 0x44
	public float prevDistance; // 0x48
	private float x; // 0x4C
	private float y; // 0x50
	[Header("GUI")]
	private float windowDpi; // 0x54
	public GameObject[] Prefabs; // 0x58
	private int Prefab; // 0x60
	private GameObject Instance; // 0x68
	private float StartColor; // 0x70
	private float HueColor; // 0x74
	public Texture HueTexture; // 0x78
	public float[] activationTime; // 0x80
	private bool enableGUI; // 0x88
	public Animator animObject; // 0x90
	private ParticleSystem[] particleSystems; // 0x98
	private List<HS_DemoToonVFX.SVA> svList; // 0xA0
	private float H; // 0xA8
	public bool useAnimation; // 0xAC

	// Methods

	// RVA: 0x3B7AE84 Offset: 0x3B76E84 VA: 0x3B7AE84
	private void Start() { }

	// RVA: 0x3B7B340 Offset: 0x3B77340 VA: 0x3B7B340
	private void Update() { }

	// RVA: 0x3B7B36C Offset: 0x3B7736C VA: 0x3B7B36C
	private void OnGUI() { }

	// RVA: 0x3B7AF50 Offset: 0x3B76F50 VA: 0x3B7AF50
	private void Counter(int count) { }

	// RVA: 0x3B7B730 Offset: 0x3B77730 VA: 0x3B7B730
	private void Activate() { }

	// RVA: 0x3B7B750 Offset: 0x3B77750 VA: 0x3B7B750
	private void LateUpdate() { }

	// RVA: 0x3B7BBB0 Offset: 0x3B77BB0 VA: 0x3B7BBB0
	private static float ClampAngle(float angle, float min, float max) { }

	// RVA: 0x3B7BBEC Offset: 0x3B77BEC VA: 0x3B7BBEC
	public void .ctor() { }
}

// Namespace: 
public class HS_EffectSound : MonoBehaviour // TypeDefIndex: 22664
{
	// Fields
	public bool Repeating; // 0x20
	public float RepeatTime; // 0x24
	public float StartTime; // 0x28
	public bool RandomVolume; // 0x2C
	public float minVolume; // 0x30
	public float maxVolume; // 0x34
	private AudioClip clip; // 0x38
	private AudioSource soundComponent; // 0x40

	// Methods

	// RVA: 0x3B7BCC4 Offset: 0x3B77CC4 VA: 0x3B7BCC4
	private void Start() { }

	// RVA: 0x3B7BDB4 Offset: 0x3B77DB4 VA: 0x3B7BDB4
	private void RepeatSound() { }

	// RVA: 0x3B7BDD8 Offset: 0x3B77DD8 VA: 0x3B7BDD8
	public void .ctor() { }
}

// Namespace: 
public class HS_FrontMover : MonoBehaviour // TypeDefIndex: 22665
{
	// Fields
	public Transform pivot; // 0x20
	public ParticleSystem effect; // 0x28
	public float speed; // 0x30
	public float drug; // 0x34
	public float repeatingTime; // 0x38
	private float startSpeed; // 0x3C

	// Methods

	// RVA: 0x3B7BDFC Offset: 0x3B77DFC VA: 0x3B7BDFC
	private void Start() { }

	// RVA: 0x3B7BE70 Offset: 0x3B77E70 VA: 0x3B7BE70
	private void StartAgain() { }

	// RVA: 0x3B7BEB8 Offset: 0x3B77EB8 VA: 0x3B7BEB8
	private void Update() { }

	// RVA: 0x3B7BF7C Offset: 0x3B77F7C VA: 0x3B7BF7C
	public void .ctor() { }
}

// Namespace: 
public class HS_ParticleCollisionInstance : MonoBehaviour // TypeDefIndex: 22666
{
	// Fields
	public GameObject[] EffectsOnCollision; // 0x20
	public float DestroyTimeDelay; // 0x28
	public bool UseWorldSpacePosition; // 0x2C
	public float Offset; // 0x30
	public Vector3 rotationOffset; // 0x34
	public bool useOnlyRotationOffset; // 0x40
	public bool UseFirePointRotation; // 0x41
	public bool DestoyMainEffect; // 0x42
	private ParticleSystem part; // 0x48
	private List<ParticleCollisionEvent> collisionEvents; // 0x50
	private ParticleSystem ps; // 0x58

	// Methods

	// RVA: 0x3B7BF98 Offset: 0x3B77F98 VA: 0x3B7BF98
	private void Start() { }

	// RVA: 0x3B7BFF0 Offset: 0x3B77FF0 VA: 0x3B7BFF0
	private void OnParticleCollision(GameObject other) { }

	// RVA: 0x3B7C514 Offset: 0x3B78514 VA: 0x3B7C514
	public void .ctor() { }
}

// Namespace: 
public class HS_ProjectileMover : MonoBehaviour // TypeDefIndex: 22667
{
	// Fields
	public float speed; // 0x20
	public float hitOffset; // 0x24
	public bool UseFirePointRotation; // 0x28
	public Vector3 rotationOffset; // 0x2C
	public GameObject hit; // 0x38
	public GameObject flash; // 0x40
	private Rigidbody rb; // 0x48
	public GameObject[] Detached; // 0x50

	// Methods

	// RVA: 0x3B7C5B4 Offset: 0x3B785B4 VA: 0x3B7C5B4
	private void Start() { }

	// RVA: 0x3B7C86C Offset: 0x3B7886C VA: 0x3B7C86C
	private void FixedUpdate() { }

	// RVA: 0x3B7C8D4 Offset: 0x3B788D4 VA: 0x3B7C8D4
	private void OnCollisionEnter(Collision collision) { }

	// RVA: 0x3B7CE54 Offset: 0x3B78E54 VA: 0x3B7CE54
	public void .ctor() { }
}

// Namespace: 
public class HS_DemoShooting2D : MonoBehaviour // TypeDefIndex: 22668
{
	// Fields
	public GameObject FirePoint; // 0x20
	public Camera Cam; // 0x28
	public float MaxLength; // 0x30
	public GameObject[] Prefabs; // 0x38
	private Ray RayMouse; // 0x40
	private Vector3 direction; // 0x58
	private Quaternion rotation; // 0x64
	[Header("GUI")]
	private float windowDpi; // 0x74
	private int Prefab; // 0x78
	private GameObject Instance; // 0x80
	private float hSliderValue; // 0x88
	private float fireCountdown; // 0x8C
	private float buttonSaver; // 0x90

	// Methods

	// RVA: 0x3B7CE6C Offset: 0x3B78E6C VA: 0x3B7CE6C
	private void Start() { }

	// RVA: 0x3B7CF1C Offset: 0x3B78F1C VA: 0x3B7CF1C
	private void Update() { }

	// RVA: 0x3B7D354 Offset: 0x3B79354 VA: 0x3B7D354
	private void OnGUI() { }

	// RVA: 0x3B7CED8 Offset: 0x3B78ED8 VA: 0x3B7CED8
	private void Counter(int count) { }

	// RVA: 0x3B7D4F4 Offset: 0x3B794F4 VA: 0x3B7D4F4
	public void .ctor() { }
}

// Namespace: 
public class HS_ProjectileMover2D : MonoBehaviour // TypeDefIndex: 22669
{
	// Fields
	public float speed; // 0x20
	public float hitOffset; // 0x24
	public bool UseFirePointRotation; // 0x28
	public Vector3 rotationOffset; // 0x2C
	public GameObject hit; // 0x38
	public GameObject flash; // 0x40
	private Rigidbody2D rb; // 0x48
	public GameObject[] Detached; // 0x50

	// Methods

	// RVA: 0x3B7D508 Offset: 0x3B79508 VA: 0x3B7D508
	private void Start() { }

	// RVA: 0x3B7D7C0 Offset: 0x3B797C0 VA: 0x3B7D7C0
	private void FixedUpdate() { }

	// RVA: 0x3B7D824 Offset: 0x3B79824 VA: 0x3B7D824
	private void OnCollisionEnter2D(Collision2D collision) { }

	// RVA: 0x3B7DDA4 Offset: 0x3B79DA4 VA: 0x3B7DDA4
	public void .ctor() { }
}

// Namespace: 
[AddComponentMenu("Camera-Control/Mouse Orbit with zoom")]
public class MouseOrbitImproved : MonoBehaviour // TypeDefIndex: 22670
{
	// Fields
	public Transform target; // 0x20
	public float distance; // 0x28
	public float xSpeed; // 0x2C
	public float ySpeed; // 0x30
	public float yMinLimit; // 0x34
	public float yMaxLimit; // 0x38
	public float distanceMin; // 0x3C
	public float distanceMax; // 0x40
	private Rigidbody rigidbody; // 0x48
	private float x; // 0x50
	private float y; // 0x54

	// Methods

	// RVA: 0x3B7DDBC Offset: 0x3B79DBC VA: 0x3B7DDBC
	private void Start() { }

	// RVA: 0x3B7DE90 Offset: 0x3B79E90 VA: 0x3B7DE90
	private void LateUpdate() { }

	// RVA: 0x3B7E18C Offset: 0x3B7A18C VA: 0x3B7E18C
	public static float ClampAngle(float angle, float min, float max) { }

	// RVA: 0x3B7E1C8 Offset: 0x3B7A1C8 VA: 0x3B7E1C8
	public void .ctor() { }
}

// Namespace: 
public class Swapper : MonoBehaviour // TypeDefIndex: 22671
{
	// Fields
	public GameObject[] character; // 0x20
	public int index; // 0x28
	public Texture btn_tex; // 0x30

	// Methods

	// RVA: 0x3B7E1F0 Offset: 0x3B7A1F0 VA: 0x3B7E1F0
	private void Awake() { }

	// RVA: 0x3B7E278 Offset: 0x3B7A278 VA: 0x3B7E278
	private void OnGUI() { }

	// RVA: 0x3B7E394 Offset: 0x3B7A394 VA: 0x3B7E394
	public void .ctor() { }
}

// Namespace: 
public class AnimatedUVs : MonoBehaviour // TypeDefIndex: 22672
{
	// Fields
	public int materialIndex; // 0x20
	public Vector2 uvAnimationRate; // 0x24
	public string textureName; // 0x30
	private Vector2 uvOffset; // 0x38

	// Methods

	// RVA: 0x3B7E39C Offset: 0x3B7A39C VA: 0x3B7E39C
	private void LateUpdate() { }

	// RVA: 0x3B7E478 Offset: 0x3B7A478 VA: 0x3B7E478
	public void .ctor() { }
}

// Namespace: 
public class DeemoUvAnimation : MonoBehaviour // TypeDefIndex: 22673
{
	// Fields
	public float fTilingX; // 0x20
	public float fTilingY; // 0x24
	public float fStartOffsetX; // 0x28
	public float fStartOffsetY; // 0x2C
	public float fScrollSpeedX; // 0x30
	public float fScrollSpeedY; // 0x34
	public float fDurationTime; // 0x38
	public AnimationCurve scrollCurve; // 0x40
	private float offsetX; // 0x48
	private float offsetY; // 0x4C
	private bool _isEnable; // 0x50

	// Properties
	public bool isEnable { get; set; }

	// Methods

	// RVA: 0x3B7E514 Offset: 0x3B7A514 VA: 0x3B7E514
	public bool get_isEnable() { }

	// RVA: 0x3B7E51C Offset: 0x3B7A51C VA: 0x3B7E51C
	public void set_isEnable(bool value) { }

	// RVA: 0x3B7E538 Offset: 0x3B7A538 VA: 0x3B7E538
	private void Awake() { }

	// RVA: 0x3B7E5E0 Offset: 0x3B7A5E0 VA: 0x3B7E5E0
	private void Update() { }

	// RVA: 0x3B7E838 Offset: 0x3B7A838 VA: 0x3B7E838
	public void UpdateFrame() { }

	// RVA: 0x3B7E5F8 Offset: 0x3B7A5F8 VA: 0x3B7E5F8
	private void _OnUpdate() { }

	// RVA: 0x3B7E83C Offset: 0x3B7A83C VA: 0x3B7E83C
	public void .ctor() { }
}

// Namespace: 
[ExecuteInEditMode]
[RequireComponent(typeof(LineRenderer))]
public class UVChainLightning : MonoBehaviour // TypeDefIndex: 22674
{
	// Fields
	public float detail; // 0x20
	public float displacement; // 0x24
	public Transform target; // 0x28
	public Transform start; // 0x30
	public float yOffset; // 0x38
	private LineRenderer _lineRender; // 0x40
	private List<Vector3> _linePosList; // 0x48

	// Methods

	// RVA: 0x3B7E88C Offset: 0x3B7A88C VA: 0x3B7E88C
	private void OnEnable() { }

	// RVA: 0x3B7E940 Offset: 0x3B7A940 VA: 0x3B7E940
	private void Update() { }

	// RVA: 0x3B7EC64 Offset: 0x3B7AC64 VA: 0x3B7EC64
	private void CollectLinPos(Vector3 startPos, Vector3 destPos, float displace) { }

	// RVA: 0x3B7EE10 Offset: 0x3B7AE10 VA: 0x3B7EE10
	public void .ctor() { }
}

// Namespace: 
[ExecuteAlways]
public class TextureFlow : MonoBehaviour // TypeDefIndex: 22675
{
	// Fields
	[Header("目标材质")]
	public Material mat; // 0x20
	[Header("流动速度 (X,Y)")]
	public Vector2 speed; // 0x28
	private Vector2 offset; // 0x30

	// Methods

	// RVA: 0x3B7EE24 Offset: 0x3B7AE24 VA: 0x3B7EE24
	private void Update() { }

	// RVA: 0x3B7EF28 Offset: 0x3B7AF28 VA: 0x3B7EF28
	public void .ctor() { }
}

// Namespace: 
[ExecuteAlways]
public class TextureFlow_01 : MonoBehaviour // TypeDefIndex: 22676
{
	// Fields
	[Header("目标材质")]
	public Material mat; // 0x20
	[Header("流动速度 (X,Y)")]
	public Vector2 mainSpeed; // 0x28
	public Vector2 maskSpeed; // 0x30
	public Vector2 textureSpeed; // 0x38
	private Vector2 mainOffset; // 0x40
	private Vector2 maskOffset; // 0x48
	private Vector2 textureOffset; // 0x50

	// Methods

	// RVA: 0x3B7EF8C Offset: 0x3B7AF8C VA: 0x3B7EF8C
	private void Update() { }

	// RVA: 0x3B7F164 Offset: 0x3B7B164 VA: 0x3B7F164
	public void .ctor() { }
}

// Namespace: 
[ExecuteInEditMode]
[RequireComponent(typeof(VertIndexAsUV))]
public class UIShaderGradientRampAdd : MonoBehaviour // TypeDefIndex: 22677
{
	// Fields
	public float _Intensity; // 0x20
	public float _RampScale; // 0x24
	public float _RampOffset; // 0x28
	public float _RampSpeed; // 0x2C
	public float _Angle; // 0x30
	public Vector2 _GradientOffset; // 0x34
	private Image m_Image; // 0x40
	public Material mat; // 0x48

	// Methods

	// RVA: 0x3B7F1EC Offset: 0x3B7B1EC VA: 0x3B7F1EC
	private void Start() { }

	// RVA: 0x3B7F2B4 Offset: 0x3B7B2B4 VA: 0x3B7F2B4
	private void Update() { }

	// RVA: 0x3B7F4EC Offset: 0x3B7B4EC VA: 0x3B7F4EC
	public void .ctor() { }
}

// Namespace: 
[ExecuteInEditMode]
public class VertIndexAsUV : BaseMeshEffect // TypeDefIndex: 22678
{
	// Methods

	// RVA: 0x3B7F54C Offset: 0x3B7B54C VA: 0x3B7F54C Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }

	// RVA: 0x3B7F634 Offset: 0x3B7B634 VA: 0x3B7F634
	public void .ctor() { }
}

// Namespace: 
public class ECCameraShake : MonoBehaviour // TypeDefIndex: 22679
{
	// Fields
	public Transform camTransform; // 0x20
	public static float shakeDuration; // 0x0
	public static float shakeAmount; // 0x4
	public float decreaseFactor; // 0x28
	private Vector3 originalPos; // 0x2C

	// Methods

	// RVA: 0x3B7F63C Offset: 0x3B7B63C VA: 0x3B7F63C
	private void Awake() { }

	// RVA: 0x3B7F7A4 Offset: 0x3B7B7A4 VA: 0x3B7F7A4
	private void OnEnable() { }

	// RVA: 0x3B7F7D0 Offset: 0x3B7B7D0 VA: 0x3B7F7D0
	private void Update() { }

	// RVA: 0x3B7F984 Offset: 0x3B7B984 VA: 0x3B7F984
	public void .ctor() { }

	// RVA: 0x3B7F994 Offset: 0x3B7B994 VA: 0x3B7F994
	private static void .cctor() { }
}

// Namespace: 
public class ECCameraShakeCaller : MonoBehaviour // TypeDefIndex: 22680
{
	// Fields
	public float ProjectileShakeDuration; // 0x20
	public float ProjectileShakeAmount; // 0x24

	// Methods

	// RVA: 0x3B7F9E4 Offset: 0x3B7B9E4 VA: 0x3B7F9E4
	private void Start() { }

	// RVA: 0x3B7FA54 Offset: 0x3B7BA54 VA: 0x3B7FA54
	private void Update() { }

	// RVA: 0x3B7FA58 Offset: 0x3B7BA58 VA: 0x3B7FA58
	public void .ctor() { }
}

// Namespace: 
public class ECCameraShakeProjectile : MonoBehaviour // TypeDefIndex: 22681
{
	// Fields
	public Animator CamerShakeAnimator; // 0x20

	// Methods

	// RVA: 0x3B7FA6C Offset: 0x3B7BA6C VA: 0x3B7FA6C
	private void Start() { }

	// RVA: 0x3B7FA70 Offset: 0x3B7BA70 VA: 0x3B7FA70
	private void Update() { }

	// RVA: 0x3B7FA74 Offset: 0x3B7BA74 VA: 0x3B7FA74
	public void ShakeCamera() { }

	// RVA: 0x3B7FAC8 Offset: 0x3B7BAC8 VA: 0x3B7FAC8
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class ECEffectActor.projectile // TypeDefIndex: 22682
{
	// Fields
	public string name; // 0x10
	public GameObject bombPrefab; // 0x18
	public Transform bombPrefabTransform; // 0x20

	// Methods

	// RVA: 0x3B8011C Offset: 0x3B7C11C VA: 0x3B8011C
	public void .ctor() { }
}

// Namespace: 
public class ECEffectActor : MonoBehaviour // TypeDefIndex: 22683
{
	// Fields
	public Transform spawnLocator; // 0x20
	public ECEffectActor.projectile[] bombList; // 0x28
	private string FauxName; // 0x30
	public Text UiText; // 0x38
	public int bombType; // 0x40
	public float min; // 0x44
	public float max; // 0x48
	public bool MinorRotate; // 0x4C
	public bool MajorRotate; // 0x4D
	private int seq; // 0x50

	// Methods

	// RVA: 0x3B7FAD0 Offset: 0x3B7BAD0 VA: 0x3B7FAD0
	private void Start() { }

	// RVA: 0x3B7FBC4 Offset: 0x3B7BBC4 VA: 0x3B7FBC4
	private void Update() { }

	// RVA: 0x3B7FC80 Offset: 0x3B7BC80 VA: 0x3B7FC80
	public void Switch(int value) { }

	// RVA: 0x3B7FDB8 Offset: 0x3B7BDB8 VA: 0x3B7FDB8
	public void Fire() { }

	// RVA: 0x3B7FF38 Offset: 0x3B7BF38 VA: 0x3B7FF38
	private void RandomizeRotation() { }

	// RVA: 0x3B80034 Offset: 0x3B7C034 VA: 0x3B80034
	private void Major_RandomizeRotation() { }

	// RVA: 0x3B80114 Offset: 0x3B7C114 VA: 0x3B80114
	public void .ctor() { }
}

// Namespace: 
public class ECExplodingProjectile : MonoBehaviour // TypeDefIndex: 22684
{
	// Fields
	public GameObject impactPrefab; // 0x20
	public GameObject explosionPrefab; // 0x28
	public float thrust; // 0x30
	public Rigidbody thisRigidbody; // 0x38
	public GameObject particleKillGroup; // 0x40
	private Collider thisCollider; // 0x48
	public bool LookRotation; // 0x50
	public bool Missile; // 0x51
	public Transform missileTarget; // 0x58
	public float projectileSpeed; // 0x60
	public float projectileSpeedMultiplier; // 0x64
	public bool ignorePrevRotation; // 0x68
	public bool explodeOnTimer; // 0x69
	public float explosionTimer; // 0x6C
	private float timer; // 0x70
	private Vector3 previousPosition; // 0x74

	// Methods

	// RVA: 0x3B80124 Offset: 0x3B7C124 VA: 0x3B80124
	private void Start() { }

	// RVA: 0x3B8021C Offset: 0x3B7C21C VA: 0x3B8021C
	private void Update() { }

	// RVA: 0x3B8038C Offset: 0x3B7C38C VA: 0x3B8038C
	private void FixedUpdate() { }

	// RVA: 0x3B804A0 Offset: 0x3B7C4A0 VA: 0x3B804A0
	private void CheckCollision(Vector3 prevPos) { }

	// RVA: 0x3B808D0 Offset: 0x3B7C8D0 VA: 0x3B808D0
	private void OnCollisionEnter(Collision collision) { }

	// RVA: 0x3B8026C Offset: 0x3B7C26C VA: 0x3B8026C
	private void Explode() { }

	// RVA: 0x3B80BA4 Offset: 0x3B7CBA4 VA: 0x3B80BA4
	public void .ctor() { }
}

// Namespace: 
public class EffectCoreProjectile : MonoBehaviour // TypeDefIndex: 22685
{
	// Fields
	private float disappearAfterTime; // 0x20
	private float disappearTimer; // 0x24
	private bool isActive; // 0x28
	private Vector3 direction; // 0x2C
	private Vector3 startPosition; // 0x38
	private float movementSpeed; // 0x44
	private Vector3 targetPosition; // 0x48
	private float distanceToTarget; // 0x54
	private float movementValue; // 0x58

	// Methods

	// RVA: 0x3B80BB4 Offset: 0x3B7CBB4 VA: 0x3B80BB4
	private void Start() { }

	// RVA: 0x3B80BB8 Offset: 0x3B7CBB8 VA: 0x3B80BB8
	private void Update() { }

	// RVA: 0x3B80C68 Offset: 0x3B7CC68 VA: 0x3B80C68
	private void Move() { }

	// RVA: 0x3B80CD0 Offset: 0x3B7CCD0 VA: 0x3B80CD0
	private void MoveWithoutTargetHit() { }

	// RVA: 0x3B80DFC Offset: 0x3B7CDFC VA: 0x3B80DFC
	public void Fire(Vector3 target, Vector3 spawnPosition, Vector3 Direction, float speed) { }

	// RVA: 0x3B80C5C Offset: 0x3B7CC5C VA: 0x3B80C5C
	private void Explode() { }

	// RVA: 0x3B80FE4 Offset: 0x3B7CFE4 VA: 0x3B80FE4
	public bool GetIsActive() { }

	// RVA: 0x3B80FEC Offset: 0x3B7CFEC VA: 0x3B80FEC
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class ECprojectileActor.projectile // TypeDefIndex: 22686
{
	// Fields
	public string name; // 0x10
	public Rigidbody bombPrefab; // 0x18
	public GameObject muzzleflare; // 0x20
	public float min; // 0x28
	public float max; // 0x2C
	public bool rapidFire; // 0x30
	public float rapidFireCooldown; // 0x34
	public bool shotgunBehavior; // 0x38
	public int shotgunPellets; // 0x3C
	public GameObject shellPrefab; // 0x40
	public bool hasShells; // 0x48

	// Methods

	// RVA: 0x3B81A98 Offset: 0x3B7DA98 VA: 0x3B81A98
	public void .ctor() { }
}

// Namespace: 
public class ECprojectileActor : MonoBehaviour // TypeDefIndex: 22687
{
	// Fields
	public Transform spawnLocator; // 0x20
	public Transform spawnLocatorMuzzleFlare; // 0x28
	public Transform shellLocator; // 0x30
	public Animator recoilAnimator; // 0x38
	public Transform[] shotgunLocator; // 0x40
	public ECprojectileActor.projectile[] bombList; // 0x48
	private string FauxName; // 0x50
	public Text UiText; // 0x58
	public bool UImaster; // 0x60
	public bool CameraShake; // 0x61
	public float rapidFireDelay; // 0x64
	public ECCameraShakeProjectile CameraShakeCaller; // 0x68
	private float firingTimer; // 0x70
	public bool firing; // 0x74
	public int bombType; // 0x78
	public bool swarmMissileLauncher; // 0x7C
	public bool Torque; // 0x7D
	public float Tor_min; // 0x80
	public float Tor_max; // 0x84
	public bool MinorRotate; // 0x88
	public bool MajorRotate; // 0x89
	private int seq; // 0x8C

	// Methods

	// RVA: 0x3B81004 Offset: 0x3B7D004 VA: 0x3B81004
	private void Start() { }

	// RVA: 0x3B81080 Offset: 0x3B7D080 VA: 0x3B81080
	private void Update() { }

	// RVA: 0x3B812A0 Offset: 0x3B7D2A0 VA: 0x3B812A0
	public void Switch(int value) { }

	// RVA: 0x3B81348 Offset: 0x3B7D348 VA: 0x3B81348
	public void Fire() { }

	// RVA: 0x3B818AC Offset: 0x3B7D8AC VA: 0x3B818AC
	private void RandomizeRotation() { }

	// RVA: 0x3B819A8 Offset: 0x3B7D9A8 VA: 0x3B819A8
	private void Major_RandomizeRotation() { }

	// RVA: 0x3B81A88 Offset: 0x3B7DA88 VA: 0x3B81A88
	public void .ctor() { }
}

// Namespace: 
public class ECdestroyMe : MonoBehaviour // TypeDefIndex: 22688
{
	// Fields
	private float timer; // 0x20
	public float deathtimer; // 0x24

	// Methods

	// RVA: 0x3B81AA0 Offset: 0x3B7DAA0 VA: 0x3B81AA0
	private void Start() { }

	// RVA: 0x3B81AA4 Offset: 0x3B7DAA4 VA: 0x3B81AA4
	private void Update() { }

	// RVA: 0x3B81B48 Offset: 0x3B7DB48 VA: 0x3B81B48
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class ECparticleColorChangerMaster.colorChange // TypeDefIndex: 22689
{
	// Fields
	public string Name; // 0x10
	public ParticleSystem[] colored_ParticleSystem; // 0x18
	public Gradient Gradient_custom; // 0x20

	// Methods

	// RVA: 0x3B81D04 Offset: 0x3B7DD04 VA: 0x3B81D04
	public void .ctor() { }
}

// Namespace: 
[ExecuteInEditMode]
public class ECparticleColorChangerMaster : MonoBehaviour // TypeDefIndex: 22690
{
	// Fields
	public float Speed_custom; // 0x20
	public ECparticleColorChangerMaster.colorChange[] colorChangeList; // 0x28
	public bool applyChanges; // 0x30
	public bool Keep_applyChanges; // 0x31

	// Methods

	// RVA: 0x3B81B58 Offset: 0x3B7DB58 VA: 0x3B81B58
	private void Start() { }

	// RVA: 0x3B81B5C Offset: 0x3B7DB5C VA: 0x3B81B5C
	private void Update() { }

	// RVA: 0x3B81CF4 Offset: 0x3B7DCF4 VA: 0x3B81CF4
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CameraShake.<Shake>d__0 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 22691
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public CameraShake <>4__this; // 0x20
	public float magnitude; // 0x28
	public float duration; // 0x2C
	private Vector3 <originalPos>5__2; // 0x30
	private float <elapsed>5__3; // 0x3C

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3B81D8C Offset: 0x3B7DD8C VA: 0x3B81D8C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3B81DBC Offset: 0x3B7DDBC VA: 0x3B81DBC Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x3B81DC0 Offset: 0x3B7DDC0 VA: 0x3B81DC0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3B81F1C Offset: 0x3B7DF1C VA: 0x3B81F1C Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x3B81F24 Offset: 0x3B7DF24 VA: 0x3B81F24 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3B81F5C Offset: 0x3B7DF5C VA: 0x3B81F5C Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
public class CameraShake : MonoBehaviour // TypeDefIndex: 22692
{
	// Methods

	[IteratorStateMachine(typeof(CameraShake.<Shake>d__0))]
	// RVA: 0x3B81D0C Offset: 0x3B7DD0C VA: 0x3B81D0C
	public IEnumerator Shake(float duration, float magnitude) { }

	// RVA: 0x3B81DB4 Offset: 0x3B7DDB4 VA: 0x3B81DB4
	public void .ctor() { }
}

// Namespace: 
public class ExplosionSwitch : MonoBehaviour // TypeDefIndex: 22693
{
	// Fields
	public CameraShake cameraShake; // 0x20
	public int selectedExplosion; // 0x28

	// Methods

	// RVA: 0x3B81F64 Offset: 0x3B7DF64 VA: 0x3B81F64
	private void Start() { }

	// RVA: 0x3B822A8 Offset: 0x3B7E2A8 VA: 0x3B822A8
	private void Update() { }

	// RVA: 0x3B81F68 Offset: 0x3B7DF68 VA: 0x3B81F68
	private void SelectExplosion() { }

	// RVA: 0x3B823E4 Offset: 0x3B7E3E4 VA: 0x3B823E4
	public void .ctor() { }
}

// Namespace: 
public class ExplosionSwitchAndroid : MonoBehaviour // TypeDefIndex: 22694
{
	// Fields
	public CameraShake cameraShake; // 0x20
	public int selectedExplosion; // 0x28

	// Methods

	// RVA: 0x3B823EC Offset: 0x3B7E3EC VA: 0x3B823EC
	private void Start() { }

	// RVA: 0x3B82730 Offset: 0x3B7E730 VA: 0x3B82730
	private void Update() { }

	// RVA: 0x3B823F0 Offset: 0x3B7E3F0 VA: 0x3B823F0
	private void SelectExplosion() { }

	// RVA: 0x3B827F0 Offset: 0x3B7E7F0 VA: 0x3B827F0
	public void .ctor() { }
}

// Namespace: 
public class FXIFIED_Rotator : MonoBehaviour // TypeDefIndex: 22695
{
	// Fields
	public float rotationSpeed; // 0x20

	// Methods

	// RVA: 0x3B827F8 Offset: 0x3B7E7F8 VA: 0x3B827F8
	private void Start() { }

	// RVA: 0x3B827FC Offset: 0x3B7E7FC VA: 0x3B827FC
	private void Update() { }

	// RVA: 0x3B82894 Offset: 0x3B7E894 VA: 0x3B82894
	public void .ctor() { }
}

// Namespace: 
public class Quit : MonoBehaviour // TypeDefIndex: 22696
{
	// Methods

	// RVA: 0x3B8289C Offset: 0x3B7E89C VA: 0x3B8289C
	private void Start() { }

	// RVA: 0x3B828A0 Offset: 0x3B7E8A0 VA: 0x3B828A0
	public void Update() { }

	// RVA: 0x3B82900 Offset: 0x3B7E900 VA: 0x3B82900
	public void .ctor() { }
}

// Namespace: 
public class ProjectileMove : MonoBehaviour // TypeDefIndex: 22697
{
	// Fields
	public float speed; // 0x20
	public float fireRate; // 0x24
	public GameObject muzzlePrefab; // 0x28
	public GameObject hitPrefab; // 0x30

	// Methods

	// RVA: 0x3B82908 Offset: 0x3B7E908 VA: 0x3B82908
	private void Start() { }

	// RVA: 0x3B82B58 Offset: 0x3B7EB58 VA: 0x3B82B58
	private void Update() { }

	// RVA: 0x3B82C8C Offset: 0x3B7EC8C VA: 0x3B82C8C
	private void OnCollisionEnter(Collision co) { }

	// RVA: 0x3B82F3C Offset: 0x3B7EF3C VA: 0x3B82F3C
	public void .ctor() { }
}

// Namespace: 
public class RotateToMouse : MonoBehaviour // TypeDefIndex: 22698
{
	// Fields
	public Camera cam; // 0x20
	public float maximumLength; // 0x28
	private Ray rayMouse; // 0x2C
	private Vector3 pos; // 0x44
	private Vector3 direction; // 0x50
	private Quaternion rotation; // 0x5C

	// Methods

	// RVA: 0x3B82F44 Offset: 0x3B7EF44 VA: 0x3B82F44
	private void Update() { }

	// RVA: 0x3B83128 Offset: 0x3B7F128 VA: 0x3B83128
	private void RotateToMouseDirection(GameObject obj, Vector3 destination) { }

	// RVA: 0x3B831F8 Offset: 0x3B7F1F8 VA: 0x3B831F8
	public Quaternion GetRotation() { }

	// RVA: 0x3B83204 Offset: 0x3B7F204 VA: 0x3B83204
	public void .ctor() { }
}

// Namespace: 
public class SpawnProjectiles : MonoBehaviour // TypeDefIndex: 22699
{
	// Fields
	public GameObject firePoint; // 0x20
	public GameObject[] Effects; // 0x28
	public RotateToMouse rotateToMouse; // 0x30
	private int selectedPrefab; // 0x38
	private GameObject effectToSpawn; // 0x40
	private float timeToFire; // 0x48
	private Text prefabName; // 0x50

	// Methods

	// RVA: 0x3B8320C Offset: 0x3B7F20C VA: 0x3B8320C
	private void Start() { }

	// RVA: 0x3B832AC Offset: 0x3B7F2AC VA: 0x3B832AC
	private void Update() { }

	// RVA: 0x3B8345C Offset: 0x3B7F45C VA: 0x3B8345C
	private void SpawnEffects() { }

	// RVA: 0x3B83664 Offset: 0x3B7F664 VA: 0x3B83664
	public void .ctor() { }
}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 22700
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
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 22701
{
	// Methods

	// RVA: 0x3B8366C Offset: 0x3B7F66C VA: 0x3B8366C
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x3B83764 Offset: 0x3B7F764 VA: 0x3B83764
	public void .ctor() { }
}

// Namespace: Suriyun
public class AnimatorController : MonoBehaviour // TypeDefIndex: 22702
{
	// Fields
	public Animator[] animators; // 0x20

	// Methods

	// RVA: 0x3B8376C Offset: 0x3B7F76C VA: 0x3B8376C
	public void SwapVisibility(GameObject obj) { }

	// RVA: 0x3B837A0 Offset: 0x3B7F7A0 VA: 0x3B837A0
	public void SetFloat(string parameter = "key,value") { }

	// RVA: 0x3B8394C Offset: 0x3B7F94C VA: 0x3B8394C
	public void SetInt(string parameter = "key,value") { }

	// RVA: 0x3B83AF4 Offset: 0x3B7FAF4 VA: 0x3B83AF4
	public void SetBool(string parameter = "key,value") { }

	// RVA: 0x3B83CC8 Offset: 0x3B7FCC8 VA: 0x3B83CC8
	public void SetTrigger(string parameter = "key,value") { }

	// RVA: 0x3B83DEC Offset: 0x3B7FDEC VA: 0x3B83DEC
	public void .ctor() { }
}

// Namespace: PolygonArsenal
public class PolygonBeamScript : MonoBehaviour // TypeDefIndex: 22703
{
	// Fields
	[Header("Prefabs")]
	public GameObject[] beamLineRendererPrefab; // 0x20
	public GameObject[] beamStartPrefab; // 0x28
	public GameObject[] beamEndPrefab; // 0x30
	private int currentBeam; // 0x38
	private GameObject beamStart; // 0x40
	private GameObject beamEnd; // 0x48
	private GameObject beam; // 0x50
	private LineRenderer line; // 0x58
	[Header("Adjustable Variables")]
	public float beamEndOffset; // 0x60
	public float textureScrollSpeed; // 0x64
	public float textureLengthScale; // 0x68
	[Header("Put Sliders here (Optional)")]
	public Slider endOffSetSlider; // 0x70
	public Slider scrollSpeedSlider; // 0x78
	[Header("Put UI Text object here to show beam name")]
	public Text textBeamName; // 0x80

	// Methods

	// RVA: 0x3B83DF4 Offset: 0x3B7FDF4 VA: 0x3B83DF4
	private void Start() { }

	// RVA: 0x3B83F34 Offset: 0x3B7FF34 VA: 0x3B83F34
	private void Update() { }

	// RVA: 0x3B847D4 Offset: 0x3B807D4 VA: 0x3B847D4
	public void nextBeam() { }

	// RVA: 0x3B848B4 Offset: 0x3B808B4 VA: 0x3B848B4
	public void previousBeam() { }

	// RVA: 0x3B84994 Offset: 0x3B80994 VA: 0x3B84994
	public void UpdateEndOffset() { }

	// RVA: 0x3B849C4 Offset: 0x3B809C4 VA: 0x3B849C4
	public void UpdateScrollSpeed() { }

	// RVA: 0x3B84384 Offset: 0x3B80384 VA: 0x3B84384
	private void ShootBeamInDir(Vector3 start, Vector3 dir) { }

	// RVA: 0x3B849F4 Offset: 0x3B809F4 VA: 0x3B849F4
	public void .ctor() { }
}

// Namespace: PolygonArsenal
public class PolygonButtonScript : MonoBehaviour // TypeDefIndex: 22704
{
	// Fields
	public GameObject Button; // 0x20
	private Text MyButtonText; // 0x28
	private string projectileParticleName; // 0x30
	private PolygonFireProjectile effectScript; // 0x38
	private PolygonProjectileScript projectileScript; // 0x40
	public float buttonsX; // 0x48
	public float buttonsY; // 0x4C
	public float buttonsSizeX; // 0x50
	public float buttonsSizeY; // 0x54
	public float buttonsDistance; // 0x58

	// Methods

	// RVA: 0x3B84A10 Offset: 0x3B80A10 VA: 0x3B84A10
	private void Start() { }

	// RVA: 0x3B84BCC Offset: 0x3B80BCC VA: 0x3B84BCC
	private void Update() { }

	// RVA: 0x3B84B18 Offset: 0x3B80B18 VA: 0x3B84B18
	public void getProjectileNames() { }

	// RVA: 0x3B84BF8 Offset: 0x3B80BF8 VA: 0x3B84BF8
	public bool overButton() { }

	// RVA: 0x3B84CDC Offset: 0x3B80CDC VA: 0x3B84CDC
	public void .ctor() { }
}

// Namespace: PolygonArsenal
public class PolygonEffectCycler : MonoBehaviour // TypeDefIndex: 22705
{
	// Fields
	[SerializeField]
	private List<GameObject> listOfEffects; // 0x20
	[Header("Loop length in seconds")]
	[SerializeField]
	private float loopTimeLength; // 0x28
	private float timeOfLastInstantiate; // 0x2C
	private GameObject instantiatedEffect; // 0x30
	private int effectIndex; // 0x38

	// Methods

	// RVA: 0x3B84CE4 Offset: 0x3B80CE4 VA: 0x3B84CE4
	private void Start() { }

	// RVA: 0x3B84E3C Offset: 0x3B80E3C VA: 0x3B84E3C
	private void Update() { }

	// RVA: 0x3B84FC8 Offset: 0x3B80FC8 VA: 0x3B84FC8
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PolygonFireProjectile.<Shoot>d__16 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 22706
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PolygonFireProjectile <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3B85FB4 Offset: 0x3B81FB4 VA: 0x3B85FB4
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3B86018 Offset: 0x3B82018 VA: 0x3B86018 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x3B8601C Offset: 0x3B8201C VA: 0x3B8601C Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3B860EC Offset: 0x3B820EC VA: 0x3B860EC Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x3B860F4 Offset: 0x3B820F4 VA: 0x3B860F4 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3B8612C Offset: 0x3B8212C VA: 0x3B8612C Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: PolygonArsenal
public class PolygonFireProjectile : MonoBehaviour // TypeDefIndex: 22707
{
	// Fields
	public GameObject[] projectiles; // 0x20
	[Header("GUI Links")]
	public Text missileNameText; // 0x28
	public Toggle fullAutoButton; // 0x30
	public Slider speedSlider; // 0x38
	[Header("Projectile Settings")]
	public Transform spawnPosition; // 0x40
	[HideInInspector]
	public int currentProjectile; // 0x48
	public float speed; // 0x4C
	public float spawnOffset; // 0x50
	[Header("Firing Settings")]
	public float fireRate; // 0x54
	public bool isFullAuto; // 0x58
	[Header("Gun Settings")]
	public GameObject gunPrefab; // 0x60
	public float gunOffset; // 0x68
	private bool canShoot; // 0x6C
	private GameObject instantiatedGun; // 0x70

	// Methods

	// RVA: 0x3B84FD8 Offset: 0x3B80FD8 VA: 0x3B84FD8
	private void Start() { }

	// RVA: 0x3B853C4 Offset: 0x3B813C4 VA: 0x3B853C4
	private void Update() { }

	[IteratorStateMachine(typeof(PolygonFireProjectile.<Shoot>d__16))]
	// RVA: 0x3B85B64 Offset: 0x3B81B64 VA: 0x3B85B64
	private IEnumerator Shoot() { }

	// RVA: 0x3B85BD0 Offset: 0x3B81BD0 VA: 0x3B85BD0
	private void ShootProjectile() { }

	// RVA: 0x3B85788 Offset: 0x3B81788 VA: 0x3B85788
	private void UpdateGunPositionAndRotation() { }

	// RVA: 0x3B85728 Offset: 0x3B81728 VA: 0x3B85728
	public void nextEffect() { }

	// RVA: 0x3B85758 Offset: 0x3B81758 VA: 0x3B85758
	public void previousEffect() { }

	// RVA: 0x3B8528C Offset: 0x3B8128C VA: 0x3B8528C
	private void UpdateDisplayName() { }

	// RVA: 0x3B85FDC Offset: 0x3B81FDC VA: 0x3B85FDC
	private void OnSpeedSliderChanged(float value) { }

	// RVA: 0x3B85FE4 Offset: 0x3B81FE4 VA: 0x3B85FE4
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PolygonLoopScript.<EffectLoop>d__4 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 22708
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PolygonLoopScript <>4__this; // 0x20
	private GameObject <effectPlayer>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3B861F0 Offset: 0x3B821F0 VA: 0x3B861F0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3B86228 Offset: 0x3B82228 VA: 0x3B86228 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x3B8622C Offset: 0x3B8222C VA: 0x3B8622C Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3B863A8 Offset: 0x3B823A8 VA: 0x3B863A8 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x3B863B0 Offset: 0x3B823B0 VA: 0x3B863B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3B863E8 Offset: 0x3B823E8 VA: 0x3B863E8 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: PolygonArsenal
public class PolygonLoopScript : MonoBehaviour // TypeDefIndex: 22709
{
	// Fields
	public GameObject chosenEffect; // 0x20
	public float loopTimeLimit; // 0x28

	// Methods

	// RVA: 0x3B86134 Offset: 0x3B82134 VA: 0x3B86134
	private void Start() { }

	// RVA: 0x3B86138 Offset: 0x3B82138 VA: 0x3B86138
	public void PlayEffect() { }

	[IteratorStateMachine(typeof(PolygonLoopScript.<EffectLoop>d__4))]
	// RVA: 0x3B86184 Offset: 0x3B82184 VA: 0x3B86184
	private IEnumerator EffectLoop() { }

	// RVA: 0x3B86218 Offset: 0x3B82218 VA: 0x3B86218
	public void .ctor() { }
}

// Namespace: PolygonArsenal
[AddComponentMenu("Camera-Control/Mouse drag Orbit with zoom")]
public class PolygonOrbit : MonoBehaviour // TypeDefIndex: 22710
{
	// Fields
	public Transform target; // 0x20
	public float distance; // 0x28
	public float xSpeed; // 0x2C
	public float ySpeed; // 0x30
	public float yMinLimit; // 0x34
	public float yMaxLimit; // 0x38
	public float distanceMin; // 0x3C
	public float distanceMax; // 0x40
	public float smoothTime; // 0x44
	private float rotationYAxis; // 0x48
	private float rotationXAxis; // 0x4C
	private float velocityX; // 0x50
	private float velocityY; // 0x54

	// Methods

	// RVA: 0x3B863F0 Offset: 0x3B823F0 VA: 0x3B863F0
	private void Start() { }

	// RVA: 0x3B864BC Offset: 0x3B824BC VA: 0x3B864BC
	private void LateUpdate() { }

	// RVA: 0x3B8684C Offset: 0x3B8284C VA: 0x3B8684C
	public static float ClampAngle(float angle, float min, float max) { }

	// RVA: 0x3B86888 Offset: 0x3B82888 VA: 0x3B86888
	public void .ctor() { }
}

// Namespace: PolygonArsenal
public class PolygonProjectileScript : MonoBehaviour // TypeDefIndex: 22711
{
	// Fields
	public GameObject impactParticle; // 0x20
	public GameObject projectileParticle; // 0x28
	public GameObject muzzleParticle; // 0x30
	public GameObject[] trailParticles; // 0x38
	[Header("Adjust if not using Sphere Collider")]
	public float colliderRadius; // 0x40
	[Range(0, 1)]
	public float collideOffset; // 0x44
	private Rigidbody rb; // 0x48
	private Transform myTransform; // 0x50
	private SphereCollider sphereCollider; // 0x58
	private float destroyTimer; // 0x60
	private bool destroyed; // 0x64

	// Methods

	// RVA: 0x3B868A8 Offset: 0x3B828A8 VA: 0x3B868A8
	private void Start() { }

	// RVA: 0x3B86B24 Offset: 0x3B82B24 VA: 0x3B86B24
	private void FixedUpdate() { }

	// RVA: 0x3B870A0 Offset: 0x3B830A0 VA: 0x3B870A0
	private void DestroyMissile() { }

	// RVA: 0x3B87314 Offset: 0x3B83314 VA: 0x3B87314
	private void RotateTowardsDirection() { }

	// RVA: 0x3B8771C Offset: 0x3B8371C VA: 0x3B8771C
	public void .ctor() { }
}

// Namespace: PolygonArsenal
public class PolygonSceneSelect : MonoBehaviour // TypeDefIndex: 22712
{
	// Fields
	public bool GUIHide; // 0x20
	public bool GUIHide2; // 0x21
	public bool GUIHide3; // 0x22
	public bool GUIHide4; // 0x23
	public bool GUIHide5; // 0x24

	// Methods

	// RVA: 0x3B87730 Offset: 0x3B83730 VA: 0x3B87730
	public void CBLoadSceneMissiles() { }

	// RVA: 0x3B87798 Offset: 0x3B83798 VA: 0x3B87798
	public void CBLoadSceneBeams() { }

	// RVA: 0x3B87800 Offset: 0x3B83800 VA: 0x3B87800
	public void CBLoadSceneBeams2() { }

	// RVA: 0x3B87868 Offset: 0x3B83868 VA: 0x3B87868
	public void CBLoadSceneAura() { }

	// RVA: 0x3B878D0 Offset: 0x3B838D0 VA: 0x3B878D0
	public void CBLoadSceneAura2() { }

	// RVA: 0x3B87938 Offset: 0x3B83938 VA: 0x3B87938
	public void CBLoadSceneAura3() { }

	// RVA: 0x3B879A0 Offset: 0x3B839A0 VA: 0x3B879A0
	public void CBLoadSceneAura4() { }

	// RVA: 0x3B87A08 Offset: 0x3B83A08 VA: 0x3B87A08
	public void CBLoadSceneBarrage() { }

	// RVA: 0x3B87A70 Offset: 0x3B83A70 VA: 0x3B87A70
	public void CBLoadSceneBarrage2() { }

	// RVA: 0x3B87AD8 Offset: 0x3B83AD8 VA: 0x3B87AD8
	public void CBLoadSceneChains() { }

	// RVA: 0x3B87B40 Offset: 0x3B83B40 VA: 0x3B87B40
	public void CBLoadSceneChains2() { }

	// RVA: 0x3B87BA8 Offset: 0x3B83BA8 VA: 0x3B87BA8
	public void CBLoadSceneCleave() { }

	// RVA: 0x3B87C10 Offset: 0x3B83C10 VA: 0x3B87C10
	public void CBLoadSceneCombat01() { }

	// RVA: 0x3B87C78 Offset: 0x3B83C78 VA: 0x3B87C78
	public void CBLoadSceneCombat02() { }

	// RVA: 0x3B87CE0 Offset: 0x3B83CE0 VA: 0x3B87CE0
	public void CBLoadSceneCurses() { }

	// RVA: 0x3B87D48 Offset: 0x3B83D48 VA: 0x3B87D48
	public void CBLoadSceneDeath() { }

	// RVA: 0x3B87DB0 Offset: 0x3B83DB0 VA: 0x3B87DB0
	public void CBLoadSceneEnchant() { }

	// RVA: 0x3B87E18 Offset: 0x3B83E18 VA: 0x3B87E18
	public void CBLoadSceneExploMini() { }

	// RVA: 0x3B87E80 Offset: 0x3B83E80 VA: 0x3B87E80
	public void CBLoadSceneGore() { }

	// RVA: 0x3B87EE8 Offset: 0x3B83EE8 VA: 0x3B87EE8
	public void CBLoadSceneHitscan() { }

	// RVA: 0x3B87F50 Offset: 0x3B83F50 VA: 0x3B87F50
	public void CBLoadSceneNecromancy() { }

	// RVA: 0x3B87FB8 Offset: 0x3B83FB8 VA: 0x3B87FB8
	public void CBLoadSceneNova() { }

	// RVA: 0x3B88020 Offset: 0x3B84020 VA: 0x3B88020
	public void CBLoadSceneOrbitalBeam() { }

	// RVA: 0x3B88088 Offset: 0x3B84088 VA: 0x3B88088
	public void CBLoadSceneSpikes() { }

	// RVA: 0x3B880F0 Offset: 0x3B840F0 VA: 0x3B880F0
	public void CBLoadSceneSpikes2() { }

	// RVA: 0x3B88158 Offset: 0x3B84158 VA: 0x3B88158
	public void CBLoadSceneSpikes3() { }

	// RVA: 0x3B881C0 Offset: 0x3B841C0 VA: 0x3B881C0
	public void CBLoadSceneSpikes4() { }

	// RVA: 0x3B88228 Offset: 0x3B84228 VA: 0x3B88228
	public void CBLoadSceneSurfaceDmg() { }

	// RVA: 0x3B88290 Offset: 0x3B84290 VA: 0x3B88290
	public void CBLoadSceneSword() { }

	// RVA: 0x3B882F8 Offset: 0x3B842F8 VA: 0x3B882F8
	public void CBLoadSceneSwordTrail() { }

	// RVA: 0x3B88360 Offset: 0x3B84360 VA: 0x3B88360
	public void ENVLoadSceneConfetti() { }

	// RVA: 0x3B883C8 Offset: 0x3B843C8 VA: 0x3B883C8
	public void ENVLoadSceneEnvironment() { }

	// RVA: 0x3B88430 Offset: 0x3B84430 VA: 0x3B88430
	public void ENVLoadSceneFire() { }

	// RVA: 0x3B88498 Offset: 0x3B84498 VA: 0x3B88498
	public void ENVLoadSceneFire2() { }

	// RVA: 0x3B88500 Offset: 0x3B84500 VA: 0x3B88500
	public void ENVLoadSceneFireflies() { }

	// RVA: 0x3B88568 Offset: 0x3B84568 VA: 0x3B88568
	public void ENVLoadSceneFireworks() { }

	// RVA: 0x3B885D0 Offset: 0x3B845D0 VA: 0x3B885D0
	public void ENVLoadSceneLiquid() { }

	// RVA: 0x3B88638 Offset: 0x3B84638 VA: 0x3B88638
	public void ENVLoadSceneLiquid2() { }

	// RVA: 0x3B886A0 Offset: 0x3B846A0 VA: 0x3B886A0
	public void ENVLoadSceneRocks() { }

	// RVA: 0x3B88708 Offset: 0x3B84708 VA: 0x3B88708
	public void ENVLoadSceneSparks() { }

	// RVA: 0x3B88770 Offset: 0x3B84770 VA: 0x3B88770
	public void ENVLoadSceneTornado() { }

	// RVA: 0x3B887D8 Offset: 0x3B847D8 VA: 0x3B887D8
	public void ENVLoadSceneWeather() { }

	// RVA: 0x3B88840 Offset: 0x3B84840 VA: 0x3B88840
	public void INTLoadSceneBeamUp() { }

	// RVA: 0x3B888A8 Offset: 0x3B848A8 VA: 0x3B888A8
	public void INTLoadSceneBlackHole() { }

	// RVA: 0x3B88910 Offset: 0x3B84910 VA: 0x3B88910
	public void INTLoadSceneHeal() { }

	// RVA: 0x3B88978 Offset: 0x3B84978 VA: 0x3B88978
	public void INTLoadSceneJets() { }

	// RVA: 0x3B889E0 Offset: 0x3B849E0 VA: 0x3B889E0
	public void INTLoadSceneLoot() { }

	// RVA: 0x3B88A48 Offset: 0x3B84A48 VA: 0x3B88A48
	public void INTLoadScenePortal() { }

	// RVA: 0x3B88AB0 Offset: 0x3B84AB0 VA: 0x3B88AB0
	public void INTLoadScenePortal2() { }

	// RVA: 0x3B88B18 Offset: 0x3B84B18 VA: 0x3B88B18
	public void INTLoadScenePowerupIcon() { }

	// RVA: 0x3B88B80 Offset: 0x3B84B80 VA: 0x3B88B80
	public void INTLoadSceneSpawn() { }

	// RVA: 0x3B88BE8 Offset: 0x3B84BE8 VA: 0x3B88BE8
	public void INTLoadSceneTrails() { }

	// RVA: 0x3B88C50 Offset: 0x3B84C50 VA: 0x3B88C50
	public void INTLoadSceneTreasure() { }

	// RVA: 0x3B88CB8 Offset: 0x3B84CB8 VA: 0x3B88CB8
	public void INTLoadSceneTreasure2() { }

	// RVA: 0x3B88D20 Offset: 0x3B84D20 VA: 0x3B88D20
	public void INTLoadSceneZones() { }

	// RVA: 0x3B88D88 Offset: 0x3B84D88 VA: 0x3B88D88
	private void Update() { }

	// RVA: 0x3B88FC0 Offset: 0x3B84FC0 VA: 0x3B88FC0
	public void .ctor() { }
}

// Namespace: PolygonArsenal
public class PolygonBeamStatic : MonoBehaviour // TypeDefIndex: 22713
{
	// Fields
	[Header("Prefabs")]
	public GameObject beamLineRendererPrefab; // 0x20
	public GameObject beamStartPrefab; // 0x28
	public GameObject beamEndPrefab; // 0x30
	private GameObject beamStart; // 0x38
	private GameObject beamEnd; // 0x40
	private GameObject beam; // 0x48
	private LineRenderer line; // 0x50
	[Header("Beam Options")]
	public bool beamCollides; // 0x58
	public float beamLength; // 0x5C
	public float beamEndOffset; // 0x60
	public float textureScrollSpeed; // 0x64
	public float textureLengthScale; // 0x68
	[Header("Width Pulse Options")]
	public float widthMultiplier; // 0x6C
	private float customWidth; // 0x70
	private float originalWidth; // 0x74
	private float lerpValue; // 0x78
	public float pulseSpeed; // 0x7C
	private bool pulseExpanding; // 0x80

	// Methods

	// RVA: 0x3B88FC8 Offset: 0x3B84FC8 VA: 0x3B88FC8
	private void Start() { }

	// RVA: 0x3B89334 Offset: 0x3B85334 VA: 0x3B89334
	private void FixedUpdate() { }

	// RVA: 0x3B88FFC Offset: 0x3B84FFC VA: 0x3B88FFC
	public void SpawnBeam() { }

	// RVA: 0x3B898A0 Offset: 0x3B858A0 VA: 0x3B898A0
	public void .ctor() { }
}

// Namespace: PolygonArsenal
public class PolygonLightFade : MonoBehaviour // TypeDefIndex: 22714
{
	// Fields
	[Header("Seconds to dim the light")]
	public float life; // 0x20
	public bool killAfterLife; // 0x24
	private Light li; // 0x28
	private float initIntensity; // 0x30

	// Methods

	// RVA: 0x3B898D0 Offset: 0x3B858D0 VA: 0x3B898D0
	private void Start() { }

	// RVA: 0x3B899EC Offset: 0x3B859EC VA: 0x3B899EC
	private void Update() { }

	// RVA: 0x3B89B28 Offset: 0x3B85B28 VA: 0x3B89B28
	public void .ctor() { }
}

// Namespace: PolygonArsenal
public class PolygonLightFlicker : MonoBehaviour // TypeDefIndex: 22715
{
	// Fields
	public string waveFunction; // 0x20
	public float startValue; // 0x28
	public float amplitude; // 0x2C
	public float phase; // 0x30
	public float frequency; // 0x34
	private Color originalColor; // 0x38

	// Methods

	// RVA: 0x3B89B44 Offset: 0x3B85B44 VA: 0x3B89B44
	private void Start() { }

	// RVA: 0x3B89BA8 Offset: 0x3B85BA8 VA: 0x3B89BA8
	private void Update() { }

	// RVA: 0x3B89C68 Offset: 0x3B85C68 VA: 0x3B89C68
	private float EvalWave() { }

	// RVA: 0x3B89E38 Offset: 0x3B85E38 VA: 0x3B89E38
	public void .ctor() { }
}

// Namespace: 
public enum PolygonRotation.spaceEnum // TypeDefIndex: 22716
{
	// Fields
	public int value__; // 0x0
	public const PolygonRotation.spaceEnum Local = 0;
	public const PolygonRotation.spaceEnum World = 1;
}

// Namespace: PolygonArsenal
public class PolygonRotation : MonoBehaviour // TypeDefIndex: 22717
{
	// Fields
	[Header("Rotate axises by degrees per second")]
	public Vector3 rotateVector; // 0x20
	public PolygonRotation.spaceEnum rotateSpace; // 0x2C

	// Methods

	// RVA: 0x3B89EA0 Offset: 0x3B85EA0 VA: 0x3B89EA0
	private void Start() { }

	// RVA: 0x3B89EA4 Offset: 0x3B85EA4 VA: 0x3B89EA4
	private void Update() { }

	// RVA: 0x3B89F70 Offset: 0x3B85F70 VA: 0x3B89F70
	public void .ctor() { }
}

// Namespace: PolygonArsenal
public class PolygonSoundSpawn : MonoBehaviour // TypeDefIndex: 22718
{
	// Fields
	public GameObject prefabSound; // 0x20
	public bool destroyWhenDone; // 0x28
	public bool soundPrefabIsChild; // 0x29
	[Range(0.01, 10)]
	public float pitchRandomMultiplier; // 0x2C

	// Methods

	// RVA: 0x3B89FD0 Offset: 0x3B85FD0 VA: 0x3B89FD0
	private void Start() { }

	// RVA: 0x3B8A220 Offset: 0x3B86220 VA: 0x3B8A220
	public void .ctor() { }
}

// Namespace: SciFiArsenal
public class SciFiPitchRandomizer : MonoBehaviour // TypeDefIndex: 22719
{
	// Fields
	public float randomPercent; // 0x20

	// Methods

	// RVA: 0x3B8A238 Offset: 0x3B86238 VA: 0x3B8A238
	private void Start() { }

	// RVA: 0x3B8A2E8 Offset: 0x3B862E8 VA: 0x3B8A2E8
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class DragChangSizeScript : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 22720
{
	// Fields
	private bool mIsDragging; // 0x20
	public Camera mCamera; // 0x28
	public float mBorderSize; // 0x30
	public Texture2D mCursorTexture; // 0x38
	public Vector2 mCursorHotSpot; // 0x40
	public bool mIsVertical; // 0x48
	private RectTransform mCachedRectTransform; // 0x50
	private RectTransform mRootCanvasRectTransform; // 0x58
	private float mMinWidth; // 0x60
	private float mMinHeight; // 0x64
	public Action mOnDragBeginAction; // 0x68
	public Action mOnDraggingAction; // 0x70
	public Action mOnDragEndAction; // 0x78

	// Properties
	public RectTransform CachedRectTransform { get; }

	// Methods

	// RVA: 0x3B8A2F8 Offset: 0x3B862F8 VA: 0x3B8A2F8
	public RectTransform get_CachedRectTransform() { }

	// RVA: 0x3B8A3B0 Offset: 0x3B863B0 VA: 0x3B8A3B0 Slot: 7
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x3B8A454 Offset: 0x3B86454 VA: 0x3B8A454 Slot: 8
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x3B8A3F8 Offset: 0x3B863F8 VA: 0x3B8A3F8
	private void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode) { }

	// RVA: 0x3B8A498 Offset: 0x3B86498 VA: 0x3B8A498
	private Canvas GetRootCanvas() { }

	// RVA: 0x3B8A600 Offset: 0x3B86600 VA: 0x3B8A600
	private void Start() { }

	// RVA: 0x3B8A664 Offset: 0x3B86664 VA: 0x3B8A664
	private void LateUpdate() { }

	// RVA: 0x3B8A7D8 Offset: 0x3B867D8 VA: 0x3B8A7D8 Slot: 4
	public void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x3B8A7FC Offset: 0x3B867FC VA: 0x3B8A7FC Slot: 5
	public void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x3B8A81C Offset: 0x3B8681C VA: 0x3B8A81C Slot: 6
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0x3B8A988 Offset: 0x3B86988 VA: 0x3B8A988
	public void .ctor() { }
}

// Namespace: 
public sealed class DragEventHelper.OnDragEventHandler : MulticastDelegate // TypeDefIndex: 22721
{
	// Methods

	// RVA: 0x3B8AA08 Offset: 0x3B86A08 VA: 0x3B8AA08
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3B8AB10 Offset: 0x3B86B10 VA: 0x3B8AB10 Slot: 13
	public virtual void Invoke(PointerEventData eventData) { }

	// RVA: 0x3B8AB24 Offset: 0x3B86B24 VA: 0x3B8AB24 Slot: 14
	public virtual IAsyncResult BeginInvoke(PointerEventData eventData, AsyncCallback callback, object object) { }

	// RVA: 0x3B8AB44 Offset: 0x3B86B44 VA: 0x3B8AB44 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: SuperScrollView
public class DragEventHelper : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 22722
{
	// Fields
	public DragEventHelper.OnDragEventHandler mOnBeginDragHandler; // 0x20
	public DragEventHelper.OnDragEventHandler mOnDragHandler; // 0x28
	public DragEventHelper.OnDragEventHandler mOnEndDragHandler; // 0x30

	// Methods

	// RVA: 0x3B8A9AC Offset: 0x3B869AC VA: 0x3B8A9AC Slot: 4
	public void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x3B8A9C8 Offset: 0x3B869C8 VA: 0x3B8A9C8 Slot: 5
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0x3B8A9E4 Offset: 0x3B869E4 VA: 0x3B8A9E4 Slot: 6
	public void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x3B8AA00 Offset: 0x3B86A00 VA: 0x3B8AA00
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class FPSDisplay : MonoBehaviour // TypeDefIndex: 22723
{
	// Fields
	private float deltaTime; // 0x20
	private GUIStyle mStyle; // 0x28

	// Methods

	// RVA: 0x3B8AB50 Offset: 0x3B86B50 VA: 0x3B8AB50
	private void Awake() { }

	// RVA: 0x3B8AC28 Offset: 0x3B86C28 VA: 0x3B8AC28
	private void Update() { }

	// RVA: 0x3B8AC68 Offset: 0x3B86C68 VA: 0x3B8AC68
	private void OnGUI() { }

	// RVA: 0x3B8AD80 Offset: 0x3B86D80 VA: 0x3B8AD80
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class RotateScript : MonoBehaviour // TypeDefIndex: 22724
{
	// Fields
	public float speed; // 0x20

	// Methods

	// RVA: 0x3B8AD88 Offset: 0x3B86D88 VA: 0x3B8AD88
	private void Update() { }

	// RVA: 0x3B8AE20 Offset: 0x3B86E20 VA: 0x3B8AE20
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ButtonPanel // TypeDefIndex: 22725
{
	// Fields
	public LoopListView2 mLoopListView; // 0x10
	public DataSourceMgr<ItemData> mDataSourceMgr; // 0x18
	private Button mSetCountButton; // 0x20
	private InputField mSetCountInput; // 0x28
	private Button mScrollToButton; // 0x30
	private InputField mScrollToInput; // 0x38
	private Button mAddButton; // 0x40
	private InputField mAddInput; // 0x48
	private Button mBackButton; // 0x50

	// Methods

	// RVA: 0x3B8AE30 Offset: 0x3B86E30 VA: 0x3B8AE30
	public void Start() { }

	// RVA: 0x3B8B19C Offset: 0x3B8719C VA: 0x3B8B19C
	private void OnSetCountButtonClicked() { }

	// RVA: 0x3B8B240 Offset: 0x3B87240 VA: 0x3B8B240
	private void OnScrollToButtonClicked() { }

	// RVA: 0x3B8B2DC Offset: 0x3B872DC VA: 0x3B8B2DC
	private void OnAddButtonClicked() { }

	// RVA: 0x3B8B408 Offset: 0x3B87408 VA: 0x3B8B408
	private void OnBackButtonClicked() { }

	// RVA: 0x3B8B4BC Offset: 0x3B874BC VA: 0x3B8B4BC
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ButtonPanelDelete.<>c // TypeDefIndex: 22726
{
	// Fields
	public static readonly ButtonPanelDelete.<>c <>9; // 0x0
	public static Predicate<ItemData> <>9__8_0; // 0x8

	// Methods

	// RVA: 0x3B8BA90 Offset: 0x3B87A90 VA: 0x3B8BA90
	private static void .cctor() { }

	// RVA: 0x3B8BAF8 Offset: 0x3B87AF8 VA: 0x3B8BAF8
	public void .ctor() { }

	// RVA: 0x3B8BB00 Offset: 0x3B87B00 VA: 0x3B8BB00
	internal bool <DeleteAllCheckedItem>b__8_0(ItemData it) { }
}

// Namespace: SuperScrollView
public class ButtonPanelDelete // TypeDefIndex: 22727
{
	// Fields
	public LoopListView2 mLoopListView; // 0x10
	public DataSourceMgr<ItemData> mDataSourceMgr; // 0x18
	private Button mSelectAllButton; // 0x20
	private Button mCancelAllButton; // 0x28
	private Button mDeleteButton; // 0x30
	private Button mBackButton; // 0x38

	// Methods

	// RVA: 0x3B8B4C4 Offset: 0x3B874C4 VA: 0x3B8B4C4
	public void Start() { }

	// RVA: 0x3B8B768 Offset: 0x3B87768 VA: 0x3B8B768
	public void CheckAllItem(bool isCheck) { }

	// RVA: 0x3B8B818 Offset: 0x3B87818 VA: 0x3B8B818
	public bool DeleteAllCheckedItem() { }

	// RVA: 0x3B8B958 Offset: 0x3B87958 VA: 0x3B8B958
	private void OnSelectAllButtonClicked() { }

	// RVA: 0x3B8B980 Offset: 0x3B87980 VA: 0x3B8B980
	private void OnCancelAllButtonClicked() { }

	// RVA: 0x3B8B9A8 Offset: 0x3B879A8 VA: 0x3B8B9A8
	private void OnDeleteButtonClicked() { }

	// RVA: 0x3B8BA3C Offset: 0x3B87A3C VA: 0x3B8BA3C
	private void OnBackButtonClicked() { }

	// RVA: 0x3B8BA88 Offset: 0x3B87A88 VA: 0x3B8BA88
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ButtonPanelGallery // TypeDefIndex: 22728
{
	// Fields
	public LoopListView2 mLoopListView; // 0x10
	public DataSourceMgr<ItemData> mDataSourceMgr; // 0x18
	private Button mSetCountButton; // 0x20
	private InputField mSetCountInput; // 0x28
	private Button mScrollToButton; // 0x30
	private InputField mScrollToInput; // 0x38
	private Button mAddButton; // 0x40
	private InputField mAddInput; // 0x48
	private Button mBackButton; // 0x50

	// Methods

	// RVA: 0x3B8BB18 Offset: 0x3B87B18 VA: 0x3B8BB18
	public void Start() { }

	// RVA: 0x3B8BE84 Offset: 0x3B87E84 VA: 0x3B8BE84
	private void OnSetCountButtonClicked() { }

	// RVA: 0x3B8BF28 Offset: 0x3B87F28 VA: 0x3B8BF28
	private void OnScrollToButtonClicked() { }

	// RVA: 0x3B8BFE0 Offset: 0x3B87FE0 VA: 0x3B8BFE0
	private void OnAddButtonClicked() { }

	// RVA: 0x3B8C10C Offset: 0x3B8810C VA: 0x3B8C10C
	private void OnBackButtonClicked() { }

	// RVA: 0x3B8C158 Offset: 0x3B88158 VA: 0x3B8C158
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ButtonPanelGridView // TypeDefIndex: 22729
{
	// Fields
	public LoopGridView mLoopGridView; // 0x10
	public DataSourceMgr<ItemData> mDataSourceMgr; // 0x18
	private Button mSetCountButton; // 0x20
	private InputField mSetCountInput; // 0x28
	private Button mScrollToButton; // 0x30
	private InputField mScrollToInput; // 0x38
	private Button mAddButton; // 0x40
	private InputField mAddInput; // 0x48
	private Button mBackButton; // 0x50

	// Methods

	// RVA: 0x3B8C160 Offset: 0x3B88160 VA: 0x3B8C160
	public void Start() { }

	// RVA: 0x3B8C4CC Offset: 0x3B884CC VA: 0x3B8C4CC
	private void OnSetCountButtonClicked() { }

	// RVA: 0x3B8C574 Offset: 0x3B88574 VA: 0x3B8C574
	private void onScrollToButtonClicked() { }

	// RVA: 0x3B8C614 Offset: 0x3B88614 VA: 0x3B8C614
	private void OnAddButtonClicked() { }

	// RVA: 0x3B8C744 Offset: 0x3B88744 VA: 0x3B8C744
	private void OnBackButtonClicked() { }

	// RVA: 0x3B8C790 Offset: 0x3B88790 VA: 0x3B8C790
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ButtonPanelGridViewDelete.<>c // TypeDefIndex: 22730
{
	// Fields
	public static readonly ButtonPanelGridViewDelete.<>c <>9; // 0x0
	public static Predicate<ItemData> <>9__8_0; // 0x8

	// Methods

	// RVA: 0x3B8CD68 Offset: 0x3B88D68 VA: 0x3B8CD68
	private static void .cctor() { }

	// RVA: 0x3B8CDD0 Offset: 0x3B88DD0 VA: 0x3B8CDD0
	public void .ctor() { }

	// RVA: 0x3B8CDD8 Offset: 0x3B88DD8 VA: 0x3B8CDD8
	internal bool <DeleteAllCheckedItem>b__8_0(ItemData it) { }
}

// Namespace: SuperScrollView
public class ButtonPanelGridViewDelete // TypeDefIndex: 22731
{
	// Fields
	public LoopGridView mLoopGridView; // 0x10
	public DataSourceMgr<ItemData> mDataSourceMgr; // 0x18
	private Button mSelectAllButton; // 0x20
	private Button mCancelAllButton; // 0x28
	private Button mDeleteButton; // 0x30
	private Button mBackButton; // 0x38

	// Methods

	// RVA: 0x3B8C798 Offset: 0x3B88798 VA: 0x3B8C798
	public void Start() { }

	// RVA: 0x3B8CA3C Offset: 0x3B88A3C VA: 0x3B8CA3C
	public void CheckAllItem(bool isCheck) { }

	// RVA: 0x3B8CAEC Offset: 0x3B88AEC VA: 0x3B8CAEC
	public bool DeleteAllCheckedItem() { }

	// RVA: 0x3B8CC2C Offset: 0x3B88C2C VA: 0x3B8CC2C
	private void OnSelectAllButtonClicked() { }

	// RVA: 0x3B8CC54 Offset: 0x3B88C54 VA: 0x3B8CC54
	private void OnCancelAllButtonClicked() { }

	// RVA: 0x3B8CC7C Offset: 0x3B88C7C VA: 0x3B8CC7C
	private void OnDeleteButtonClicked() { }

	// RVA: 0x3B8CD14 Offset: 0x3B88D14 VA: 0x3B8CD14
	private void OnBackButtonClicked() { }

	// RVA: 0x3B8CD60 Offset: 0x3B88D60 VA: 0x3B8CD60
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ButtonPanelGridViewLoad // TypeDefIndex: 22732
{
	// Fields
	public LoopGridView mLoopGridView; // 0x10
	public DataSourceMgr<ItemData> mDataSourceMgr; // 0x18
	public int mExtraHeaderItemCount; // 0x20
	public int mExtraFooterItemCount; // 0x24
	private Button mSetCountButton; // 0x28
	private InputField mSetCountInput; // 0x30
	private Button mScrollToButton; // 0x38
	private InputField mScrollToInput; // 0x40
	private Button mAddButton; // 0x48
	private InputField mAddInput; // 0x50
	private Button mBackButton; // 0x58

	// Methods

	// RVA: 0x3B8CDF0 Offset: 0x3B88DF0 VA: 0x3B8CDF0
	public void Start() { }

	// RVA: 0x3B8D15C Offset: 0x3B8915C VA: 0x3B8D15C
	private void OnSetCountButtonClicked() { }

	// RVA: 0x3B8D210 Offset: 0x3B89210 VA: 0x3B8D210
	private void onScrollToButtonClicked() { }

	// RVA: 0x3B8D2B8 Offset: 0x3B892B8 VA: 0x3B8D2B8
	private void OnAddButtonClicked() { }

	// RVA: 0x3B8D3F8 Offset: 0x3B893F8 VA: 0x3B8D3F8
	private void OnBackButtonClicked() { }

	// RVA: 0x3B8D444 Offset: 0x3B89444 VA: 0x3B8D444
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ButtonPanelLoad // TypeDefIndex: 22733
{
	// Fields
	public LoopListView2 mLoopListView; // 0x10
	public DataSourceMgr<ItemData> mDataSourceMgr; // 0x18
	public int mExtraHeaderItemCount; // 0x20
	public int mExtraFooterItemCount; // 0x24
	private Button mSetCountButton; // 0x28
	private InputField mSetCountInput; // 0x30
	private Button mScrollToButton; // 0x38
	private InputField mScrollToInput; // 0x40
	private Button mAddButton; // 0x48
	private InputField mAddInput; // 0x50
	private Button mBackButton; // 0x58

	// Methods

	// RVA: 0x3B8D44C Offset: 0x3B8944C VA: 0x3B8D44C
	public void Start() { }

	// RVA: 0x3B8D7B8 Offset: 0x3B897B8 VA: 0x3B8D7B8
	private void OnSetCountButtonClicked() { }

	// RVA: 0x3B8D868 Offset: 0x3B89868 VA: 0x3B8D868
	private void OnScrollToButtonClicked() { }

	// RVA: 0x3B8D90C Offset: 0x3B8990C VA: 0x3B8D90C
	private void OnAddButtonClicked() { }

	// RVA: 0x3B8DA48 Offset: 0x3B89A48 VA: 0x3B8DA48
	private void OnBackButtonClicked() { }

	// RVA: 0x3B8DA94 Offset: 0x3B89A94 VA: 0x3B8DA94
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ButtonPanelMenu : MonoBehaviour // TypeDefIndex: 22734
{
	// Fields
	public ScrollRect scrollRect; // 0x20
	public static int lastSelectSceneArrayIndex; // 0x0
	private static float[] lastSelectSceneMenuYPos; // 0x8

	// Methods

	// RVA: 0x3B8DA9C Offset: 0x3B89A9C VA: 0x3B8DA9C
	private void Start() { }

	// RVA: 0x3B8DB60 Offset: 0x3B89B60 VA: 0x3B8DB60
	public void .ctor() { }

	// RVA: 0x3B8DB68 Offset: 0x3B89B68 VA: 0x3B8DB68
	private static void .cctor() { }
}

// Namespace: SuperScrollView
public class ButtonPanelMenuList : MonoBehaviour // TypeDefIndex: 22735
{
	// Fields
	private static string[] sceneArray0; // 0x0
	private static string[] sceneArray1; // 0x8
	private static string[] sceneArray3; // 0x10
	private static string[] sceneArray2; // 0x18
	private static string[][] allSceneArray; // 0x20
	private static string[] mainMenuSceneArray; // 0x28
	private Button button; // 0x20
	public int sceneArrayIndex; // 0x28

	// Methods

	// RVA: 0x3B8DC0C Offset: 0x3B89C0C VA: 0x3B8DC0C
	private void Start() { }

	// RVA: 0x3B8DD18 Offset: 0x3B89D18 VA: 0x3B8DD18
	public void OnButtonClick() { }

	// RVA: 0x3B8B454 Offset: 0x3B87454 VA: 0x3B8B454
	public static void BackToMainMenu() { }

	// RVA: 0x3B8DF84 Offset: 0x3B89F84 VA: 0x3B8DF84
	private static int GetSceneArrayIndexByName(string sceneName) { }

	// RVA: 0x3B8DEE4 Offset: 0x3B89EE4 VA: 0x3B8DEE4
	private string GetSceneName(int sceneArrayIndex, int index) { }

	// RVA: 0x3B8DDD8 Offset: 0x3B89DD8 VA: 0x3B8DDD8
	private int GetSelfIndexInParent() { }

	// RVA: 0x3B8E094 Offset: 0x3B8A094 VA: 0x3B8E094
	public void .ctor() { }

	// RVA: 0x3B8E09C Offset: 0x3B8A09C VA: 0x3B8E09C
	private static void .cctor() { }
}

// Namespace: SuperScrollView
public class ButtonPanelNested // TypeDefIndex: 22736
{
	// Fields
	public LoopListView2 mLoopListView; // 0x10
	public DataSourceMgr<NestedItemData> mDataSourceMgr; // 0x18
	private Button mSetCountButton; // 0x20
	private InputField mSetCountInput; // 0x28
	private Button mScrollToButton; // 0x30
	private InputField mScrollToInput; // 0x38
	private Button mAddButton; // 0x40
	private InputField mAddInput; // 0x48
	private Button mBackButton; // 0x50

	// Methods

	// RVA: 0x3B8EF2C Offset: 0x3B8AF2C VA: 0x3B8EF2C
	public void Start() { }

	// RVA: 0x3B8F298 Offset: 0x3B8B298 VA: 0x3B8F298
	private void OnSetCountButtonClicked() { }

	// RVA: 0x3B8F33C Offset: 0x3B8B33C VA: 0x3B8F33C
	private void OnScrollToButtonClicked() { }

	// RVA: 0x3B8F3D8 Offset: 0x3B8B3D8 VA: 0x3B8F3D8
	private void OnAddButtonClicked() { }

	// RVA: 0x3B8F4C8 Offset: 0x3B8B4C8 VA: 0x3B8F4C8
	private void OnBackButtonClicked() { }

	// RVA: 0x3B8F514 Offset: 0x3B8B514 VA: 0x3B8F514
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ButtonPanelSpecial // TypeDefIndex: 22737
{
	// Fields
	public LoopListView2 mLoopListView; // 0x10
	public DataSourceMgr<ItemData> mDataSourceMgr; // 0x18
	public int mItemCountPerRow; // 0x20
	private Button mSetCountButton; // 0x28
	private InputField mSetCountInput; // 0x30
	private Button mScrollToButton; // 0x38
	private InputField mScrollToInput; // 0x40
	private Button mAddButton; // 0x48
	private InputField mAddInput; // 0x50
	private Button mBackButton; // 0x58

	// Methods

	// RVA: 0x3B8F51C Offset: 0x3B8B51C VA: 0x3B8F51C
	public void Start() { }

	// RVA: 0x3B8F888 Offset: 0x3B8B888 VA: 0x3B8F888
	private void OnSetCountButtonClicked() { }

	// RVA: 0x3B8F940 Offset: 0x3B8B940 VA: 0x3B8F940
	private void OnScrollToButtonClicked() { }

	// RVA: 0x3B8FA00 Offset: 0x3B8BA00 VA: 0x3B8FA00
	private void OnAddButtonClicked() { }

	// RVA: 0x3B8FB3C Offset: 0x3B8BB3C VA: 0x3B8FB3C
	private void OnBackButtonClicked() { }

	// RVA: 0x3B8FB88 Offset: 0x3B8BB88 VA: 0x3B8FB88
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ButtonPanelSpecialDelete.<>c // TypeDefIndex: 22738
{
	// Fields
	public static readonly ButtonPanelSpecialDelete.<>c <>9; // 0x0
	public static Predicate<ItemData> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x3B901A8 Offset: 0x3B8C1A8 VA: 0x3B901A8
	private static void .cctor() { }

	// RVA: 0x3B90210 Offset: 0x3B8C210 VA: 0x3B90210
	public void .ctor() { }

	// RVA: 0x3B90218 Offset: 0x3B8C218 VA: 0x3B90218
	internal bool <DeleteAllCheckedItem>b__9_0(ItemData it) { }
}

// Namespace: SuperScrollView
public class ButtonPanelSpecialDelete // TypeDefIndex: 22739
{
	// Fields
	public LoopListView2 mLoopListView; // 0x10
	public DataSourceMgr<ItemData> mDataSourceMgr; // 0x18
	public int mItemCountPerRow; // 0x20
	private Button mSelectAllButton; // 0x28
	private Button mCancelAllButton; // 0x30
	private Button mDeleteButton; // 0x38
	private Button mBackButton; // 0x40

	// Methods

	// RVA: 0x3B8FB98 Offset: 0x3B8BB98 VA: 0x3B8FB98
	public void Start() { }

	// RVA: 0x3B8FE3C Offset: 0x3B8BE3C VA: 0x3B8FE3C
	public void CheckAllItem(bool isCheck) { }

	// RVA: 0x3B8FEEC Offset: 0x3B8BEEC VA: 0x3B8FEEC
	public bool DeleteAllCheckedItem() { }

	// RVA: 0x3B9002C Offset: 0x3B8C02C VA: 0x3B9002C
	private void OnSelectAllButtonClicked() { }

	// RVA: 0x3B90054 Offset: 0x3B8C054 VA: 0x3B90054
	private void OnCancelAllButtonClicked() { }

	// RVA: 0x3B9007C Offset: 0x3B8C07C VA: 0x3B9007C
	private void OnDeleteButtonClicked() { }

	// RVA: 0x3B9014C Offset: 0x3B8C14C VA: 0x3B9014C
	private void OnBackButtonClicked() { }

	// RVA: 0x3B90198 Offset: 0x3B8C198 VA: 0x3B90198
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ButtonPanelSpecialLoad // TypeDefIndex: 22740
{
	// Fields
	public LoopListView2 mLoopListView; // 0x10
	public DataSourceMgr<ItemData> mDataSourceMgr; // 0x18
	public int mItemCountPerRow; // 0x20
	public int mExtraHeaderItemCount; // 0x24
	public int mExtraFooterItemCount; // 0x28
	private Button mSetCountButton; // 0x30
	private InputField mSetCountInput; // 0x38
	private Button mScrollToButton; // 0x40
	private InputField mScrollToInput; // 0x48
	private Button mAddButton; // 0x50
	private InputField mAddInput; // 0x58
	private Button mBackButton; // 0x60

	// Methods

	// RVA: 0x3B90230 Offset: 0x3B8C230 VA: 0x3B90230
	public void Start() { }

	// RVA: 0x3B9059C Offset: 0x3B8C59C VA: 0x3B9059C
	private void OnSetCountButtonClicked() { }

	// RVA: 0x3B90668 Offset: 0x3B8C668 VA: 0x3B90668
	private void OnScrollToButtonClicked() { }

	// RVA: 0x3B90730 Offset: 0x3B8C730 VA: 0x3B90730
	private void OnAddButtonClicked() { }

	// RVA: 0x3B90878 Offset: 0x3B8C878 VA: 0x3B90878
	private void OnBackButtonClicked() { }

	// RVA: 0x3B908C4 Offset: 0x3B8C8C4 VA: 0x3B908C4
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ButtonPanelStaggeredView // TypeDefIndex: 22741
{
	// Fields
	public LoopStaggeredGridView mLoopListView; // 0x10
	public DataSourceMgr<ItemData> mDataSourceMgr; // 0x18
	private Button mSetCountButton; // 0x20
	private InputField mSetCountInput; // 0x28
	private Button mAddButton; // 0x30
	private Button mBackButton; // 0x38

	// Methods

	// RVA: 0x3B908D4 Offset: 0x3B8C8D4 VA: 0x3B908D4
	public void Start() { }

	// RVA: 0x3B90B38 Offset: 0x3B8CB38 VA: 0x3B90B38
	private void OnSetCountButtonClicked() { }

	// RVA: 0x3B90BDC Offset: 0x3B8CBDC VA: 0x3B90BDC
	private void OnAddButtonClicked() { }

	// RVA: 0x3B90CD4 Offset: 0x3B8CCD4 VA: 0x3B90CD4
	private void OnBackButtonClicked() { }

	// RVA: 0x3B90D20 Offset: 0x3B8CD20 VA: 0x3B90D20
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ButtonPanelTreeView // TypeDefIndex: 22742
{
	// Fields
	public LoopListView2 mLoopListView; // 0x10
	public TreeViewDataSourceMgr<ItemData> mTreeViewDataSourceMgr; // 0x18
	public TreeViewItemCountMgr mTreeItemCountMgr; // 0x20
	private Button mScrollToButton; // 0x28
	private InputField mScrollToInputItem; // 0x30
	private InputField mScrollToInputChild; // 0x38
	private Button mExpandAllButton; // 0x40
	private Button mCollapseAllButton; // 0x48
	private Button mAddButton; // 0x50
	private InputField mAddInputItem; // 0x58
	private InputField mAddInputChild; // 0x60
	private Button mBackButton; // 0x68

	// Methods

	// RVA: 0x3B90D28 Offset: 0x3B8CD28 VA: 0x3B90D28
	public void Start() { }

	// RVA: 0x3B91160 Offset: 0x3B8D160 VA: 0x3B91160
	private void OnScrollToButtonClicked() { }

	// RVA: 0x3B912A4 Offset: 0x3B8D2A4 VA: 0x3B912A4
	private void OnExpandAllButtonClicked() { }

	// RVA: 0x3B914A0 Offset: 0x3B8D4A0 VA: 0x3B914A0
	private void OnCollapseAllButtonClicked() { }

	// RVA: 0x3B9152C Offset: 0x3B8D52C VA: 0x3B9152C
	private void OnAddButtonClicked() { }

	// RVA: 0x3B91710 Offset: 0x3B8D710 VA: 0x3B91710
	private void OnBackButtonClicked() { }

	// RVA: 0x3B9175C Offset: 0x3B8D75C VA: 0x3B9175C
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ButtonPanelTreeViewSimple // TypeDefIndex: 22743
{
	// Fields
	public LoopListView2 mLoopListView; // 0x10
	public TreeViewDataSourceMgr<SimpleItemData> mTreeViewDataSourceMgr; // 0x18
	public TreeViewItemCountMgr mTreeItemCountMgr; // 0x20
	private Button mScrollToButton; // 0x28
	private InputField mScrollToInputItem; // 0x30
	private InputField mScrollToInputChild; // 0x38
	private Button mExpandAllButton; // 0x40
	private Button mCollapseAllButton; // 0x48
	private Button mAddButton; // 0x50
	private InputField mAddInputItem; // 0x58
	private Button mBackButton; // 0x60

	// Methods

	// RVA: 0x3B91764 Offset: 0x3B8D764 VA: 0x3B91764
	public void Start() { }

	// RVA: 0x3B91B60 Offset: 0x3B8DB60 VA: 0x3B91B60
	private void OnScrollToButtonClicked() { }

	// RVA: 0x3B91C20 Offset: 0x3B8DC20 VA: 0x3B91C20
	private void OnExpandAllButtonClicked() { }

	// RVA: 0x3B91CAC Offset: 0x3B8DCAC VA: 0x3B91CAC
	private void OnCollapseAllButtonClicked() { }

	// RVA: 0x3B91D38 Offset: 0x3B8DD38 VA: 0x3B91D38
	private void OnAddButtonClicked() { }

	// RVA: 0x3B91E1C Offset: 0x3B8DE1C VA: 0x3B91E1C
	private void OnBackButtonClicked() { }

	// RVA: 0x3B91E68 Offset: 0x3B8DE68 VA: 0x3B91E68
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ButtonPanelTreeViewSticky // TypeDefIndex: 22744
{
	// Fields
	public LoopListView2 mLoopListView; // 0x10
	public TreeViewDataSourceMgr<ItemData> mTreeViewDataSourceMgr; // 0x18
	public TreeViewItemCountMgr mTreeItemCountMgr; // 0x20
	public float mStickeyHeadItemHeight; // 0x28
	private Button mScrollToButton; // 0x30
	private InputField mScrollToInputItem; // 0x38
	private InputField mScrollToInputChild; // 0x40
	private Button mExpandAllButton; // 0x48
	private Button mCollapseAllButton; // 0x50
	private Button mAddButton; // 0x58
	private InputField mAddInputItem; // 0x60
	private InputField mAddInputChild; // 0x68
	private Button mBackButton; // 0x70

	// Methods

	// RVA: 0x3B91E70 Offset: 0x3B8DE70 VA: 0x3B91E70
	public void Start() { }

	// RVA: 0x3B922A8 Offset: 0x3B8E2A8 VA: 0x3B922A8
	private void OnScrollToButtonClicked() { }

	// RVA: 0x3B92370 Offset: 0x3B8E370 VA: 0x3B92370
	private void OnAddButtonClicked() { }

	// RVA: 0x3B924C0 Offset: 0x3B8E4C0 VA: 0x3B924C0
	private void OnExpandAllButtonClicked() { }

	// RVA: 0x3B9254C Offset: 0x3B8E54C VA: 0x3B9254C
	private void OnCollapseAllButtonClicked() { }

	// RVA: 0x3B925D8 Offset: 0x3B8E5D8 VA: 0x3B925D8
	private void OnBackButtonClicked() { }

	// RVA: 0x3B92624 Offset: 0x3B8E624 VA: 0x3B92624
	public void .ctor() { }
}

// Namespace: SuperScrollView
public enum MsgTypeEnum // TypeDefIndex: 22745
{
	// Fields
	public int value__; // 0x0
	public const MsgTypeEnum Str = 0;
	public const MsgTypeEnum Picture = 1;
	public const MsgTypeEnum Count = 2;
}

// Namespace: SuperScrollView
public class PersonInfo // TypeDefIndex: 22746
{
	// Fields
	public int mId; // 0x10
	public string mName; // 0x18
	public string mHeadIcon; // 0x20

	// Methods

	// RVA: 0x3B92634 Offset: 0x3B8E634 VA: 0x3B92634
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ChatMsg // TypeDefIndex: 22747
{
	// Fields
	public int mPersonId; // 0x10
	public MsgTypeEnum mMsgType; // 0x14
	public string mSrtMsg; // 0x18
	public string mPicMsgSpriteName; // 0x20

	// Methods

	// RVA: 0x3B9263C Offset: 0x3B8E63C VA: 0x3B9263C
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ChatMsgDataSourceMgr : MonoBehaviour // TypeDefIndex: 22748
{
	// Fields
	private Dictionary<int, PersonInfo> mPersonInfoDict; // 0x20
	private List<ChatMsg> mChatMsgList; // 0x28
	private static ChatMsgDataSourceMgr instance; // 0x0
	private static string[] mChatDemoStrList; // 0x8
	private static int[] mChatDemoPicList; // 0x10

	// Properties
	public static ChatMsgDataSourceMgr Get { get; }
	public int TotalItemCount { get; }

	// Methods

	// RVA: 0x3B92644 Offset: 0x3B8E644 VA: 0x3B92644
	public static ChatMsgDataSourceMgr get_Get() { }

	// RVA: 0x3B92754 Offset: 0x3B8E754 VA: 0x3B92754
	private void Awake() { }

	// RVA: 0x3B928D4 Offset: 0x3B8E8D4 VA: 0x3B928D4
	public PersonInfo GetPersonInfo(int personId) { }

	// RVA: 0x3B92758 Offset: 0x3B8E758 VA: 0x3B92758
	public void Init() { }

	// RVA: 0x3B92D28 Offset: 0x3B8ED28 VA: 0x3B92D28
	public ChatMsg GetChatMsgByIndex(int index) { }

	// RVA: 0x3B92DAC Offset: 0x3B8EDAC VA: 0x3B92DAC
	public int get_TotalItemCount() { }

	// RVA: 0x3B92AA8 Offset: 0x3B8EAA8 VA: 0x3B92AA8
	private void InitChatDataSource() { }

	// RVA: 0x3B92DF4 Offset: 0x3B8EDF4 VA: 0x3B92DF4
	public void AppendOneMsg(int personId) { }

	// RVA: 0x3B92FF8 Offset: 0x3B8EFF8 VA: 0x3B92FF8
	public void .ctor() { }

	// RVA: 0x3B930D4 Offset: 0x3B8F0D4 VA: 0x3B930D4
	private static void .cctor() { }
}

// Namespace: SuperScrollView
public class DataSourceMgr<T> // TypeDefIndex: 22749
{
	// Fields
	private List<T> mItemDataList; // 0x0
	private Action mOnRefreshFinished; // 0x0
	private Action mOnLoadMoreFinished; // 0x0
	private int mLoadMoreCount; // 0x0
	private float mDataLoadLeftTime; // 0x0
	private float mDataRefreshLeftTime; // 0x0
	private bool mIsWaittingRefreshData; // 0x0
	private bool mIsWaitLoadingMoreData; // 0x0

	// Properties
	public int TotalItemCount { get; }
	public List<T> ItemDataList { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1DF78 Offset: 0x5D19F78 VA: 0x5D1DF78
	|-DataSourceMgr<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T GetItemDataByIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1E014 Offset: 0x5D1A014 VA: 0x5D1E014
	|-DataSourceMgr<object>.GetItemDataByIndex
	*/

	// RVA: -1 Offset: -1
	public int get_TotalItemCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1E054 Offset: 0x5D1A054 VA: 0x5D1E054
	|-DataSourceMgr<object>.get_TotalItemCount
	*/

	// RVA: -1 Offset: -1
	public List<T> get_ItemDataList() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1E070 Offset: 0x5D1A070 VA: 0x5D1E070
	|-DataSourceMgr<object>.get_ItemDataList
	*/

	// RVA: -1 Offset: -1
	public void RequestRefreshDataList(Action onReflushFinished) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1E078 Offset: 0x5D1A078 VA: 0x5D1E078
	|-DataSourceMgr<object>.RequestRefreshDataList
	*/

	// RVA: -1 Offset: -1
	public void RequestLoadMoreDataList(int loadCount, Action onLoadMoreFinished) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1E0A4 Offset: 0x5D1A0A4 VA: 0x5D1E0A4
	|-DataSourceMgr<object>.RequestLoadMoreDataList
	*/

	// RVA: -1 Offset: -1
	public void Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1E0D4 Offset: 0x5D1A0D4 VA: 0x5D1E0D4
	|-DataSourceMgr<object>.Update
	*/

	// RVA: -1 Offset: -1
	public void SetDataTotalCount(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1E1C0 Offset: 0x5D1A1C0 VA: 0x5D1E1C0
	|-DataSourceMgr<object>.SetDataTotalCount
	*/

	// RVA: -1 Offset: -1
	public void ExchangeData(int index1, int index2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1E214 Offset: 0x5D1A214 VA: 0x5D1E214
	|-DataSourceMgr<object>.ExchangeData
	*/

	// RVA: -1 Offset: -1
	public void RemoveData(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1E2C0 Offset: 0x5D1A2C0 VA: 0x5D1E2C0
	|-DataSourceMgr<object>.RemoveData
	*/

	// RVA: -1 Offset: -1
	public T InsertData(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1E2E4 Offset: 0x5D1A2E4 VA: 0x5D1E2E4
	|-DataSourceMgr<object>.InsertData
	*/

	// RVA: -1 Offset: -1
	public T InsertData(int index, T newData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1E3AC Offset: 0x5D1A3AC VA: 0x5D1E3AC
	|-DataSourceMgr<object>.InsertData
	*/

	// RVA: -1 Offset: -1
	private void DoRefreshDataSource(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1E444 Offset: 0x5D1A444 VA: 0x5D1E444
	|-DataSourceMgr<object>.DoRefreshDataSource
	*/

	// RVA: -1 Offset: -1
	public void AppendData(int addCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1E548 Offset: 0x5D1A548 VA: 0x5D1E548
	|-DataSourceMgr<object>.AppendData
	*/

	// RVA: -1 Offset: -1
	public void AppendData(T itemData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1E628 Offset: 0x5D1A628 VA: 0x5D1E628
	|-DataSourceMgr<object>.AppendData
	*/

	// RVA: -1 Offset: -1
	public List<T> GetFilteredItemList(string filterStr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1E698 Offset: 0x5D1A698 VA: 0x5D1E698
	|-DataSourceMgr<object>.GetFilteredItemList
	*/
}

// Namespace: SuperScrollView
public class DescArray // TypeDefIndex: 22750
{
	// Fields
	public static string[] mStrList; // 0x0

	// Methods

	// RVA: 0x3B932C8 Offset: 0x3B8F2C8 VA: 0x3B932C8
	public void .ctor() { }

	// RVA: 0x3B932D0 Offset: 0x3B8F2D0 VA: 0x3B932D0
	private static void .cctor() { }
}

// Namespace: SuperScrollView
public class ItemDataBase // TypeDefIndex: 22751
{
	// Methods

	// RVA: 0x3B9368C Offset: 0x3B8F68C VA: 0x3B9368C Slot: 4
	public virtual void Init(int index) { }

	// RVA: 0x3B93690 Offset: 0x3B8F690 VA: 0x3B93690 Slot: 5
	public virtual void Init(int index, int parentIndex) { }

	// RVA: 0x3B93694 Offset: 0x3B8F694 VA: 0x3B93694 Slot: 6
	public virtual void OnIndexChanged(int index) { }

	// RVA: 0x3B93698 Offset: 0x3B8F698 VA: 0x3B93698 Slot: 7
	public virtual void OnIndexChanged(int index, int parentIndex) { }

	// RVA: 0x3B9369C Offset: 0x3B8F69C VA: 0x3B9369C Slot: 8
	public virtual bool IsFilterMatched(string filterStr) { }

	// RVA: 0x3B936A4 Offset: 0x3B8F6A4 VA: 0x3B936A4
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ItemData : ItemDataBase // TypeDefIndex: 22752
{
	// Fields
	public int mIndex; // 0x10
	public int mParentIndex; // 0x14
	public string mName; // 0x18
	public string mDesc; // 0x20
	public string mDescExtend; // 0x28
	public string mIcon; // 0x30
	public int mStarCount; // 0x38
	public bool mChecked; // 0x3C
	public bool mIsExpand; // 0x3D
	public float mSliderValue; // 0x40
	public string mInputFieldText; // 0x48
	public string mContentImage; // 0x50

	// Methods

	// RVA: 0x3B936AC Offset: 0x3B8F6AC VA: 0x3B936AC Slot: 4
	public override void Init(int index) { }

	// RVA: 0x3B938CC Offset: 0x3B8F8CC VA: 0x3B938CC Slot: 5
	public override void Init(int index, int parentIndex = -1) { }

	// RVA: 0x3B93ACC Offset: 0x3B8FACC VA: 0x3B93ACC Slot: 6
	public override void OnIndexChanged(int index) { }

	// RVA: 0x3B93B50 Offset: 0x3B8FB50 VA: 0x3B93B50 Slot: 7
	public override void OnIndexChanged(int index, int parentIndex = -1) { }

	// RVA: 0x3B93C30 Offset: 0x3B8FC30 VA: 0x3B93C30 Slot: 8
	public override bool IsFilterMatched(string filterStr) { }

	// RVA: 0x3B93C4C Offset: 0x3B8FC4C VA: 0x3B93C4C
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class SimpleItemData : ItemDataBase // TypeDefIndex: 22753
{
	// Fields
	public int mIndex; // 0x10
	public int mParentIndex; // 0x14
	public string mName; // 0x18

	// Methods

	// RVA: 0x3B93C5C Offset: 0x3B8FC5C VA: 0x3B93C5C Slot: 4
	public override void Init(int index) { }

	// RVA: 0x3B93CE0 Offset: 0x3B8FCE0 VA: 0x3B93CE0 Slot: 5
	public override void Init(int index, int parentIndex = -1) { }

	// RVA: 0x3B93DC0 Offset: 0x3B8FDC0 VA: 0x3B93DC0 Slot: 6
	public override void OnIndexChanged(int index) { }

	// RVA: 0x3B93E44 Offset: 0x3B8FE44 VA: 0x3B93E44 Slot: 7
	public override void OnIndexChanged(int index, int parentIndex = -1) { }

	// RVA: 0x3B93F24 Offset: 0x3B8FF24 VA: 0x3B93F24 Slot: 8
	public override bool IsFilterMatched(string filterStr) { }

	// RVA: 0x3B93F40 Offset: 0x3B8FF40 VA: 0x3B93F40
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class NestedItemData : ItemDataBase // TypeDefIndex: 22754
{
	// Fields
	public string mName; // 0x10
	public int mIndex; // 0x18
	public DataSourceMgr<ItemData> mDataSourceMgr; // 0x20
	private int mNestedCount; // 0x28

	// Methods

	// RVA: 0x3B93F50 Offset: 0x3B8FF50 VA: 0x3B93F50 Slot: 4
	public override void Init(int index) { }

	// RVA: 0x3B94030 Offset: 0x3B90030 VA: 0x3B94030 Slot: 6
	public override void OnIndexChanged(int index) { }

	// RVA: 0x3B940B4 Offset: 0x3B900B4 VA: 0x3B940B4
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class TreeViewDataSourceMgr<T> // TypeDefIndex: 22755
{
	// Fields
	private List<TreeViewItemData<T>> mItemDataList; // 0x0
	private int mTreeViewItemCount; // 0x0
	private int mTreeViewChildItemCount; // 0x0

	// Properties
	public int TreeViewItemCount { get; }
	public int TotalTreeViewItemAndChildCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_TreeViewItemCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5649914 Offset: 0x5645914 VA: 0x5649914
	|-TreeViewDataSourceMgr<object>.get_TreeViewItemCount
	*/

	// RVA: -1 Offset: -1
	public int get_TotalTreeViewItemAndChildCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5649930 Offset: 0x5645930 VA: 0x5649930
	|-TreeViewDataSourceMgr<object>.get_TotalTreeViewItemAndChildCount
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x56499B8 Offset: 0x56459B8 VA: 0x56499B8
	|-TreeViewDataSourceMgr<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public TreeViewItemData<T> GetItemDataByIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5649A48 Offset: 0x5645A48 VA: 0x5649A48
	|-TreeViewDataSourceMgr<object>.GetItemDataByIndex
	*/

	// RVA: -1 Offset: -1
	public T GetItemChildDataByIndex(int itemIndex, int childIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5649A88 Offset: 0x5645A88 VA: 0x5649A88
	|-TreeViewDataSourceMgr<object>.GetItemChildDataByIndex
	*/

	// RVA: -1 Offset: -1
	public T AddNewItemChild(int itemIndex, int AddToBeforeChildIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5649AE0 Offset: 0x5645AE0 VA: 0x5649AE0
	|-TreeViewDataSourceMgr<object>.AddNewItemChild
	*/

	// RVA: -1 Offset: -1
	private void DoRefreshDataSource() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5649B58 Offset: 0x5645B58 VA: 0x5649B58
	|-TreeViewDataSourceMgr<object>.DoRefreshDataSource
	*/
}

// Namespace: SuperScrollView
public class TreeViewItemCountData // TypeDefIndex: 22756
{
	// Fields
	public int mTreeItemIndex; // 0x10
	public int mChildCount; // 0x14
	public bool mIsExpand; // 0x18
	public int mBeginIndex; // 0x1C
	public int mEndIndex; // 0x20

	// Methods

	// RVA: 0x3B940C4 Offset: 0x3B900C4 VA: 0x3B940C4
	public bool IsChild(int index) { }

	// RVA: 0x3B940D4 Offset: 0x3B900D4 VA: 0x3B940D4
	public int GetChildIndex(int index) { }

	// RVA: 0x3B940E4 Offset: 0x3B900E4 VA: 0x3B940E4
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class TreeViewItemCountMgr // TypeDefIndex: 22757
{
	// Fields
	private List<TreeViewItemCountData> mTreeItemDataList; // 0x10
	private TreeViewItemCountData mLastQueryResult; // 0x18
	private bool mIsDirty; // 0x20

	// Properties
	public int TreeViewItemCount { get; }

	// Methods

	// RVA: 0x3B940F4 Offset: 0x3B900F4 VA: 0x3B940F4
	public void AddTreeItem(int count, bool isExpand) { }

	// RVA: 0x3B941FC Offset: 0x3B901FC VA: 0x3B941FC
	public void Clear() { }

	// RVA: 0x3B91220 Offset: 0x3B8D220 VA: 0x3B91220
	public TreeViewItemCountData GetTreeItem(int treeIndex) { }

	// RVA: 0x3B9167C Offset: 0x3B8D67C VA: 0x3B9167C
	public void SetItemChildCount(int treeIndex, int count) { }

	// RVA: 0x3B91378 Offset: 0x3B8D378 VA: 0x3B91378
	public void SetItemExpand(int treeIndex, bool isExpand) { }

	// RVA: 0x3B9427C Offset: 0x3B9027C VA: 0x3B9427C
	public void ToggleItemExpand(int treeIndex) { }

	// RVA: 0x3B9430C Offset: 0x3B9030C VA: 0x3B9430C
	public bool IsTreeItemExpand(int treeIndex) { }

	// RVA: 0x3B9432C Offset: 0x3B9032C VA: 0x3B9432C
	private void UpdateAllTreeItemDataIndex() { }

	// RVA: 0x3B91330 Offset: 0x3B8D330 VA: 0x3B91330
	public int get_TreeViewItemCount() { }

	// RVA: 0x3B91410 Offset: 0x3B8D410 VA: 0x3B91410
	public int GetTotalItemAndChildCount() { }

	// RVA: 0x3B9442C Offset: 0x3B9042C VA: 0x3B9442C
	public TreeViewItemCountData QueryTreeItemByTotalIndex(int totalIndex) { }

	// RVA: 0x3B9456C Offset: 0x3B9056C VA: 0x3B9456C
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class TreeViewItemData<T> // TypeDefIndex: 22758
{
	// Fields
	public string mName; // 0x0
	public List<T> mChildItemDataList; // 0x0

	// Properties
	public int ChildCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_ChildCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5649C88 Offset: 0x5645C88 VA: 0x5649C88
	|-TreeViewItemData<object>.get_ChildCount
	*/

	// RVA: -1 Offset: -1
	public T AddNewItemChild(int index, int childIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5649CA4 Offset: 0x5645CA4 VA: 0x5649CA4
	|-TreeViewItemData<object>.AddNewItemChild
	*/

	// RVA: -1 Offset: -1
	public T GetItemChildDataByIndex(int childIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5649DF4 Offset: 0x5645DF4 VA: 0x5649DF4
	|-TreeViewItemData<object>.GetItemChildDataByIndex
	*/

	// RVA: -1 Offset: -1
	public void RefreshItemDataList(int index, int childItemCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5649E04 Offset: 0x5645E04 VA: 0x5649E04
	|-TreeViewItemData<object>.RefreshItemDataList
	*/

	// RVA: -1 Offset: -1
	private void AddChild(T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5649EF0 Offset: 0x5645EF0 VA: 0x5649EF0
	|-TreeViewItemData<object>.AddChild
	*/

	// RVA: -1 Offset: -1
	private T GetChild(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5649F60 Offset: 0x5645F60 VA: 0x5649F60
	|-TreeViewItemData<object>.GetChild
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5649FA0 Offset: 0x5645FA0 VA: 0x5649FA0
	|-TreeViewItemData<object>..ctor
	*/
}

// Namespace: SuperScrollView
public class BaseHorizontalItem : MonoBehaviour // TypeDefIndex: 22759
{
	// Fields
	public Text mNameText; // 0x20
	public Image mIcon; // 0x28
	public Image mStarIcon; // 0x30
	public Text mStarCount; // 0x38
	public Text mDesc; // 0x40
	public Color32 mRedStarColor; // 0x48
	public Color32 mGrayStarColor; // 0x4C
	private int mItemDataIndex; // 0x50
	private ItemData mItemData; // 0x58

	// Methods

	// RVA: 0x3B945FC Offset: 0x3B905FC VA: 0x3B945FC
	public void Init() { }

	// RVA: 0x3B946A0 Offset: 0x3B906A0 VA: 0x3B946A0
	private void OnStarClicked(GameObject obj) { }

	// RVA: 0x3B946C8 Offset: 0x3B906C8 VA: 0x3B946C8
	public void SetStarCount(int count) { }

	// RVA: 0x3B9477C Offset: 0x3B9077C VA: 0x3B9477C
	public void SetItemData(ItemData itemData, int itemIndex) { }

	// RVA: 0x3B948A0 Offset: 0x3B908A0 VA: 0x3B948A0
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class BaseHorizontalItemList : MonoBehaviour // TypeDefIndex: 22760
{
	// Fields
	public List<BaseHorizontalItem> mItemList; // 0x20

	// Methods

	// RVA: 0x3B948BC Offset: 0x3B908BC VA: 0x3B948BC
	public void Init() { }

	// RVA: 0x3B94A04 Offset: 0x3B90A04 VA: 0x3B94A04
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class BaseHorizontalToggleItem : MonoBehaviour // TypeDefIndex: 22761
{
	// Fields
	public Text mNameText; // 0x20
	public Image mIcon; // 0x28
	public Image mStarIcon; // 0x30
	public Text mStarCount; // 0x38
	public Text mDesc; // 0x40
	public Color32 mRedStarColor; // 0x48
	public Color32 mGrayStarColor; // 0x4C
	public Toggle mToggle; // 0x50
	private int mItemDataIndex; // 0x58
	private ItemData mItemData; // 0x60

	// Methods

	// RVA: 0x3B94A0C Offset: 0x3B90A0C VA: 0x3B94A0C
	public void Init() { }

	// RVA: 0x3B94B28 Offset: 0x3B90B28 VA: 0x3B94B28
	private void OnToggleValueChanged(bool check) { }

	// RVA: 0x3B94B48 Offset: 0x3B90B48 VA: 0x3B94B48
	private void OnStarClicked(GameObject obj) { }

	// RVA: 0x3B94B70 Offset: 0x3B90B70 VA: 0x3B94B70
	public void SetStarCount(int count) { }

	// RVA: 0x3B94C24 Offset: 0x3B90C24 VA: 0x3B94C24
	public void SetItemData(ItemData itemData, int itemIndex) { }

	// RVA: 0x3B94CE4 Offset: 0x3B90CE4 VA: 0x3B94CE4
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class BaseHorizontalToggleItemList : MonoBehaviour // TypeDefIndex: 22762
{
	// Fields
	public BaseHorizontalToggleItem[] mItemList; // 0x20

	// Methods

	// RVA: 0x3B94D00 Offset: 0x3B90D00 VA: 0x3B94D00
	public void Init() { }

	// RVA: 0x3B94D5C Offset: 0x3B90D5C VA: 0x3B94D5C
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class BaseRowColItem : MonoBehaviour // TypeDefIndex: 22763
{
	// Fields
	public Text mNameText; // 0x20
	public Image mIcon; // 0x28
	public Image mStarIcon; // 0x30
	public Text mStarCount; // 0x38
	public Text mRowText; // 0x40
	public Text mColumnText; // 0x48
	public Text mDescText; // 0x50
	public Color32 mRedStarColor; // 0x58
	public Color32 mGrayStarColor; // 0x5C
	private ItemData mItemData; // 0x60
	private int mItemDataIndex; // 0x68

	// Methods

	// RVA: 0x3B94D64 Offset: 0x3B90D64 VA: 0x3B94D64
	public void Init() { }

	// RVA: 0x3B94E08 Offset: 0x3B90E08 VA: 0x3B94E08
	private void OnStarClicked(GameObject obj) { }

	// RVA: 0x3B94E30 Offset: 0x3B90E30 VA: 0x3B94E30
	public void SetStarCount(int count) { }

	// RVA: 0x3B94EE4 Offset: 0x3B90EE4 VA: 0x3B94EE4
	public void SetItemData(ItemData itemData, int itemIndex, int row, int column) { }

	// RVA: 0x3B95058 Offset: 0x3B91058 VA: 0x3B95058
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class BaseRowColItemList : MonoBehaviour // TypeDefIndex: 22764
{
	// Fields
	public List<BaseRowColItem> mItemList; // 0x20

	// Methods

	// RVA: 0x3B95074 Offset: 0x3B91074 VA: 0x3B95074
	public void Init() { }

	// RVA: 0x3B951BC Offset: 0x3B911BC VA: 0x3B951BC
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class BaseVerticalItem.<>c__DisplayClass9_0 // TypeDefIndex: 22765
{
	// Fields
	public int index; // 0x10
	public BaseVerticalItem <>4__this; // 0x18

	// Methods

	// RVA: 0x3B95308 Offset: 0x3B91308 VA: 0x3B95308
	public void .ctor() { }

	// RVA: 0x3B95574 Offset: 0x3B91574 VA: 0x3B95574
	internal void <Init>b__0(GameObject obj) { }
}

// Namespace: SuperScrollView
public class BaseVerticalItem : MonoBehaviour // TypeDefIndex: 22766
{
	// Fields
	public Text mNameText; // 0x20
	public Image mIcon; // 0x28
	public Image[] mStarArray; // 0x30
	public Text mDesc; // 0x38
	public Text mDescExtend; // 0x40
	public Color32 mRedStarColor; // 0x48
	public Color32 mGrayStarColor; // 0x4C
	private ItemData mItemData; // 0x50
	private int mItemDataIndex; // 0x58

	// Methods

	// RVA: 0x3B951C4 Offset: 0x3B911C4 VA: 0x3B951C4
	public void Init() { }

	// RVA: 0x3B95310 Offset: 0x3B91310 VA: 0x3B95310
	private void OnStarClicked(int index) { }

	// RVA: 0x3B95354 Offset: 0x3B91354 VA: 0x3B95354
	public void SetStarCount(int count) { }

	// RVA: 0x3B95490 Offset: 0x3B91490 VA: 0x3B95490
	public void SetItemData(ItemData itemData, int itemIndex) { }

	// RVA: 0x3B95558 Offset: 0x3B91558 VA: 0x3B95558
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class BaseVerticalItemList : MonoBehaviour // TypeDefIndex: 22767
{
	// Fields
	public List<BaseVerticalItem> mItemList; // 0x20

	// Methods

	// RVA: 0x3B95594 Offset: 0x3B91594 VA: 0x3B95594
	public void Init() { }

	// RVA: 0x3B956DC Offset: 0x3B916DC VA: 0x3B956DC
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class BaseVerticalLineItem.<>c__DisplayClass10_0 // TypeDefIndex: 22768
{
	// Fields
	public int index; // 0x10
	public BaseVerticalLineItem <>4__this; // 0x18

	// Methods

	// RVA: 0x3B95828 Offset: 0x3B91828 VA: 0x3B95828
	public void .ctor() { }

	// RVA: 0x3B95AC4 Offset: 0x3B91AC4 VA: 0x3B95AC4
	internal void <Init>b__0(GameObject obj) { }
}

// Namespace: SuperScrollView
public class BaseVerticalLineItem : MonoBehaviour // TypeDefIndex: 22769
{
	// Fields
	public Text mNameText; // 0x20
	public Image mIcon; // 0x28
	public Image[] mStarArray; // 0x30
	public Text mDesc; // 0x38
	public Text mDescExtend; // 0x40
	public Color32 mRedStarColor; // 0x48
	public Color32 mGrayStarColor; // 0x4C
	public Image mLine; // 0x50
	private ItemData mItemData; // 0x58
	private int mItemDataIndex; // 0x60

	// Methods

	// RVA: 0x3B956E4 Offset: 0x3B916E4 VA: 0x3B956E4
	public void Init() { }

	// RVA: 0x3B95830 Offset: 0x3B91830 VA: 0x3B95830
	private void OnStarClicked(int index) { }

	// RVA: 0x3B95874 Offset: 0x3B91874 VA: 0x3B95874
	public void SetStarCount(int count) { }

	// RVA: 0x3B959B0 Offset: 0x3B919B0 VA: 0x3B959B0
	public void SetItemData(ItemData itemData, int itemIndex) { }

	// RVA: 0x3B95A78 Offset: 0x3B91A78 VA: 0x3B95A78
	public void SetLineVisible(bool visible) { }

	// RVA: 0x3B95AA8 Offset: 0x3B91AA8 VA: 0x3B95AA8
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class BaseVerticalLineItemList : MonoBehaviour // TypeDefIndex: 22770
{
	// Fields
	public List<BaseVerticalLineItem> mItemList; // 0x20

	// Methods

	// RVA: 0x3B95AE4 Offset: 0x3B91AE4 VA: 0x3B95AE4
	public void Init() { }

	// RVA: 0x3B95C2C Offset: 0x3B91C2C VA: 0x3B95C2C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ChangeItemHeightItem.<>c__DisplayClass12_0 // TypeDefIndex: 22771
{
	// Fields
	public int index; // 0x10
	public ChangeItemHeightItem <>4__this; // 0x18

	// Methods

	// RVA: 0x3B95DE0 Offset: 0x3B91DE0 VA: 0x3B95DE0
	public void .ctor() { }

	// RVA: 0x3B961DC Offset: 0x3B921DC VA: 0x3B961DC
	internal void <Init>b__0(GameObject obj) { }
}

// Namespace: SuperScrollView
public class ChangeItemHeightItem : MonoBehaviour // TypeDefIndex: 22772
{
	// Fields
	public Text mNameText; // 0x20
	public Image mIcon; // 0x28
	public Image[] mStarArray; // 0x30
	public Text mDesc; // 0x38
	public GameObject mExpandContentRoot; // 0x40
	public Text mClickTip; // 0x48
	public Button mExpandButton; // 0x50
	public Color32 mRedStarColor; // 0x58
	public Color32 mGrayStarColor; // 0x5C
	private bool mIsExpand; // 0x60
	private int mItemDataIndex; // 0x64
	private ItemData mItemData; // 0x68

	// Methods

	// RVA: 0x3B95C34 Offset: 0x3B91C34 VA: 0x3B95C34
	public void Init() { }

	// RVA: 0x3B95DE8 Offset: 0x3B91DE8 VA: 0x3B95DE8
	public void OnExpandChanged() { }

	// RVA: 0x3B95EF0 Offset: 0x3B91EF0 VA: 0x3B95EF0
	private void OnExpandButtonClicked() { }

	// RVA: 0x3B95F84 Offset: 0x3B91F84 VA: 0x3B95F84
	private void OnStarClicked(int index) { }

	// RVA: 0x3B95FC8 Offset: 0x3B91FC8 VA: 0x3B95FC8
	public void SetStarCount(int count) { }

	// RVA: 0x3B96104 Offset: 0x3B92104 VA: 0x3B96104
	public void SetItemData(ItemData itemData, int itemIndex) { }

	// RVA: 0x3B961C0 Offset: 0x3B921C0 VA: 0x3B961C0
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ChatViewItem : MonoBehaviour // TypeDefIndex: 22773
{
	// Fields
	public Text mMsgText; // 0x20
	public RectTransform mMsgPicMask; // 0x28
	public Image mMsgPic; // 0x30
	public Image mIcon; // 0x38
	public Image mItemBg; // 0x40
	public Image mArrow; // 0x48
	public Text mIndexText; // 0x50
	private int mItemIndex; // 0x58
	private float mMsgPicScaleX; // 0x5C
	private float mMsgPicScaleY; // 0x60

	// Properties
	public int ItemIndex { get; }

	// Methods

	// RVA: 0x3B961FC Offset: 0x3B921FC VA: 0x3B961FC
	public int get_ItemIndex() { }

	// RVA: 0x3B96204 Offset: 0x3B92204 VA: 0x3B96204
	public void Init() { }

	// RVA: 0x3B96208 Offset: 0x3B92208 VA: 0x3B96208
	public void SetItemData(ChatMsg itemData, int itemIndex) { }

	// RVA: 0x3B96600 Offset: 0x3B92600 VA: 0x3B96600
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class GalleryHorizontalItem : MonoBehaviour // TypeDefIndex: 22774
{
	// Fields
	public Text mNameText; // 0x20
	public Image mIcon; // 0x28
	public Image mStarIcon; // 0x30
	public Text mStarCount; // 0x38
	public Text mDesc; // 0x40
	public Color32 mRedStarColor; // 0x48
	public Color32 mGrayStarColor; // 0x4C
	public GameObject mContentRootObj; // 0x50
	private ItemData mItemData; // 0x58
	private int mItemDataIndex; // 0x60

	// Methods

	// RVA: 0x3B96620 Offset: 0x3B92620 VA: 0x3B96620
	public void Init() { }

	// RVA: 0x3B966C4 Offset: 0x3B926C4 VA: 0x3B966C4
	private void OnStarClicked(GameObject obj) { }

	// RVA: 0x3B966EC Offset: 0x3B926EC VA: 0x3B966EC
	public void SetStarCount(int count) { }

	// RVA: 0x3B967A0 Offset: 0x3B927A0 VA: 0x3B967A0
	public void SetItemData(ItemData itemData, int itemIndex) { }

	// RVA: 0x3B9684C Offset: 0x3B9284C VA: 0x3B9684C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GalleryVerticalItem.<>c__DisplayClass10_0 // TypeDefIndex: 22775
{
	// Fields
	public int index; // 0x10
	public GalleryVerticalItem <>4__this; // 0x18

	// Methods

	// RVA: 0x3B969AC Offset: 0x3B929AC VA: 0x3B969AC
	public void .ctor() { }

	// RVA: 0x3B96C18 Offset: 0x3B92C18 VA: 0x3B96C18
	internal void <Init>b__0(GameObject obj) { }
}

// Namespace: SuperScrollView
public class GalleryVerticalItem : MonoBehaviour // TypeDefIndex: 22776
{
	// Fields
	public Text mNameText; // 0x20
	public Image mIcon; // 0x28
	public Image[] mStarArray; // 0x30
	public Text mDesc; // 0x38
	public Text mDescExtend; // 0x40
	public Color32 mRedStarColor; // 0x48
	public Color32 mGrayStarColor; // 0x4C
	public GameObject mContentRootObj; // 0x50
	private int mItemDataIndex; // 0x58
	private ItemData mItemData; // 0x60

	// Methods

	// RVA: 0x3B96868 Offset: 0x3B92868 VA: 0x3B96868
	public void Init() { }

	// RVA: 0x3B969B4 Offset: 0x3B929B4 VA: 0x3B969B4
	private void OnStarClicked(int index) { }

	// RVA: 0x3B969F8 Offset: 0x3B929F8 VA: 0x3B969F8
	public void SetStarCount(int count) { }

	// RVA: 0x3B96B34 Offset: 0x3B92B34 VA: 0x3B96B34
	public void SetItemData(ItemData itemData, int itemIndex) { }

	// RVA: 0x3B96BFC Offset: 0x3B92BFC VA: 0x3B96BFC
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class IconItem : MonoBehaviour // TypeDefIndex: 22777
{
	// Fields
	public Image mIcon; // 0x20
	private ItemData mItemData; // 0x28
	private int mItemDataIndex; // 0x30

	// Methods

	// RVA: 0x3B96C38 Offset: 0x3B92C38 VA: 0x3B96C38
	public void Init() { }

	// RVA: 0x3B96C3C Offset: 0x3B92C3C VA: 0x3B96C3C
	public void SetItemData(ItemData itemData, int itemIndex) { }

	// RVA: 0x3B96CA0 Offset: 0x3B92CA0 VA: 0x3B96CA0
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class IconItemList : MonoBehaviour // TypeDefIndex: 22778
{
	// Fields
	public List<IconItem> mItemList; // 0x20

	// Methods

	// RVA: 0x3B96CB0 Offset: 0x3B92CB0 VA: 0x3B96CB0
	public void Init() { }

	// RVA: 0x3B96DEC Offset: 0x3B92DEC VA: 0x3B96DEC
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class IconTextDescItem : MonoBehaviour // TypeDefIndex: 22779
{
	// Fields
	public Text mNameText; // 0x20
	public Image mIcon; // 0x28
	public Text mDesc; // 0x30
	private int mItemDataIndex; // 0x38
	private ItemData mItemData; // 0x40

	// Methods

	// RVA: 0x3B96DF4 Offset: 0x3B92DF4 VA: 0x3B96DF4
	public void Init() { }

	// RVA: 0x3B96DF8 Offset: 0x3B92DF8 VA: 0x3B96DF8
	public void SetItemData(ItemData itemData, int itemIndex) { }

	// RVA: 0x3B96E98 Offset: 0x3B92E98 VA: 0x3B96E98
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class IconTextDescItemList : MonoBehaviour // TypeDefIndex: 22780
{
	// Fields
	public List<IconTextDescItem> mItemList; // 0x20

	// Methods

	// RVA: 0x3B96EA8 Offset: 0x3B92EA8 VA: 0x3B96EA8
	public void Init() { }

	// RVA: 0x3B96FE4 Offset: 0x3B92FE4 VA: 0x3B96FE4
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class IconTextItem : MonoBehaviour // TypeDefIndex: 22781
{
	// Fields
	public Text mNameText; // 0x20
	public Image mIcon; // 0x28
	private ItemData mItemData; // 0x30
	private int mItemDataIndex; // 0x38

	// Methods

	// RVA: 0x3B96FEC Offset: 0x3B92FEC VA: 0x3B96FEC
	public void Init() { }

	// RVA: 0x3B96FF0 Offset: 0x3B92FF0 VA: 0x3B96FF0
	public void SetItemData(ItemData itemData, int itemIndex) { }

	// RVA: 0x3B97074 Offset: 0x3B93074 VA: 0x3B97074
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class IconTextItemList : MonoBehaviour // TypeDefIndex: 22782
{
	// Fields
	public List<IconTextItem> mItemList; // 0x20

	// Methods

	// RVA: 0x3B97084 Offset: 0x3B93084 VA: 0x3B97084
	public void Init() { }

	// RVA: 0x3B971C0 Offset: 0x3B931C0 VA: 0x3B971C0
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ImageItem : MonoBehaviour // TypeDefIndex: 22783
{
	// Fields
	public Text mNameText; // 0x20
	public Image mIcon; // 0x28
	public Text mDesc; // 0x30
	public Image mContentImage; // 0x38
	private ItemData mItemData; // 0x40
	private int mItemDataIndex; // 0x48

	// Methods

	// RVA: 0x3B971C8 Offset: 0x3B931C8 VA: 0x3B971C8
	public void Init() { }

	// RVA: 0x3B971CC Offset: 0x3B931CC VA: 0x3B971CC
	public void SetItemData(ItemData itemData, int itemIndex) { }

	// RVA: 0x3B97294 Offset: 0x3B93294 VA: 0x3B97294
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ImageItemList : MonoBehaviour // TypeDefIndex: 22784
{
	// Fields
	public List<ImageItem> mItemList; // 0x20

	// Methods

	// RVA: 0x3B972A4 Offset: 0x3B932A4 VA: 0x3B972A4
	public void Init() { }

	// RVA: 0x3B973E0 Offset: 0x3B933E0 VA: 0x3B973E0
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class InputFieldItem : MonoBehaviour // TypeDefIndex: 22785
{
	// Fields
	public Text mNameText; // 0x20
	public Image mIcon; // 0x28
	public Text mDesc; // 0x30
	public InputField mInputField; // 0x38
	private ItemData mItemData; // 0x40
	private int mItemDataIndex; // 0x48

	// Methods

	// RVA: 0x3B973E8 Offset: 0x3B933E8 VA: 0x3B973E8
	public void Init() { }

	// RVA: 0x3B9748C Offset: 0x3B9348C VA: 0x3B9748C
	public void SetItemData(ItemData itemData, int itemIndex) { }

	// RVA: 0x3B97540 Offset: 0x3B93540 VA: 0x3B97540
	public void OnInputFieldValueChange(string text) { }

	// RVA: 0x3B9755C Offset: 0x3B9355C VA: 0x3B9755C
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class InputFieldItemList : MonoBehaviour // TypeDefIndex: 22786
{
	// Fields
	public List<InputFieldItem> mItemList; // 0x20

	// Methods

	// RVA: 0x3B9756C Offset: 0x3B9356C VA: 0x3B9756C
	public void Init() { }

	// RVA: 0x3B976B4 Offset: 0x3B936B4 VA: 0x3B976B4
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class LoadClickItem : MonoBehaviour // TypeDefIndex: 22787
{
	// Fields
	public Button mRootButton; // 0x20
	public Text mText; // 0x28
	public GameObject mWaitingIcon; // 0x30

	// Methods

	// RVA: 0x3B976BC Offset: 0x3B936BC VA: 0x3B976BC
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class LoadComplexItem : MonoBehaviour // TypeDefIndex: 22788
{
	// Fields
	public GameObject mRoot1; // 0x20
	public GameObject mRoot; // 0x28
	public Text mText; // 0x30
	public GameObject mArrow; // 0x38
	public GameObject mWaitingIcon; // 0x40

	// Methods

	// RVA: 0x3B976C4 Offset: 0x3B936C4 VA: 0x3B976C4
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class LoadItem : MonoBehaviour // TypeDefIndex: 22789
{
	// Fields
	public GameObject mRoot; // 0x20
	public Text mText; // 0x28
	public GameObject mArrow; // 0x30
	public GameObject mWaitingIcon; // 0x38

	// Methods

	// RVA: 0x3B976CC Offset: 0x3B936CC VA: 0x3B976CC
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class NestedGridViewLeftRightItem : MonoBehaviour // TypeDefIndex: 22790
{
	// Fields
	public LoopGridView mLoopGridView; // 0x20
	public Text mTitle; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30

	// Methods

	// RVA: 0x3B976D4 Offset: 0x3B936D4 VA: 0x3B976D4
	public void Init() { }

	// RVA: 0x3B97770 Offset: 0x3B93770 VA: 0x3B97770
	public void SetItemData(NestedItemData itemData) { }

	// RVA: 0x3B97854 Offset: 0x3B93854 VA: 0x3B97854
	private LoopGridViewItem OnGetItemByIndex(LoopGridView gridView, int index) { }

	// RVA: 0x3B97958 Offset: 0x3B93958 VA: 0x3B97958
	private LoopGridViewItem OnGetItemByRowColumn(LoopGridView gridView, int itemIndex, int row, int column) { }

	// RVA: 0x3B97A5C Offset: 0x3B93A5C VA: 0x3B97A5C
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class NestedGridViewTopBottomItem : MonoBehaviour // TypeDefIndex: 22791
{
	// Fields
	public LoopGridView mLoopGridView; // 0x20
	public Text mTitle; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30

	// Methods

	// RVA: 0x3B97A64 Offset: 0x3B93A64 VA: 0x3B97A64
	public void Init() { }

	// RVA: 0x3B97B00 Offset: 0x3B93B00 VA: 0x3B97B00
	public void SetItemData(NestedItemData itemData) { }

	// RVA: 0x3B97BE4 Offset: 0x3B93BE4 VA: 0x3B97BE4
	private LoopGridViewItem OnGetItemByRowColumn(LoopGridView gridView, int itemIndex, int row, int column) { }

	// RVA: 0x3B97CD4 Offset: 0x3B93CD4 VA: 0x3B97CD4
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class NestedLeftRightItem : MonoBehaviour // TypeDefIndex: 22792
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public Text mTitle; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30

	// Methods

	// RVA: 0x3B97CDC Offset: 0x3B93CDC VA: 0x3B97CDC
	public void Init() { }

	// RVA: 0x3B97D74 Offset: 0x3B93D74 VA: 0x3B97D74
	public void SetItemData(NestedItemData itemData) { }

	// RVA: 0x3B97E30 Offset: 0x3B93E30 VA: 0x3B97E30
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3B97F4C Offset: 0x3B93F4C VA: 0x3B97F4C
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class NestedTopBottomItem : MonoBehaviour // TypeDefIndex: 22793
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public Text mTitle; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30

	// Methods

	// RVA: 0x3B97F54 Offset: 0x3B93F54 VA: 0x3B97F54
	public void Init() { }

	// RVA: 0x3B97FEC Offset: 0x3B93FEC VA: 0x3B97FEC
	public void SetItemData(NestedItemData itemData) { }

	// RVA: 0x3B980A8 Offset: 0x3B940A8 VA: 0x3B980A8
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3B981D8 Offset: 0x3B941D8 VA: 0x3B981D8
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class PageViewItemElem // TypeDefIndex: 22794
{
	// Fields
	public GameObject mRootObj; // 0x10
	public Image mIcon; // 0x18
	public Text mName; // 0x20

	// Methods

	// RVA: 0x3B981E0 Offset: 0x3B941E0 VA: 0x3B981E0
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class PageViewItem : MonoBehaviour // TypeDefIndex: 22795
{
	// Fields
	public List<PageViewItemElem> mElemItemList; // 0x20

	// Methods

	// RVA: 0x3B981E8 Offset: 0x3B941E8 VA: 0x3B981E8
	public void Init() { }

	// RVA: 0x3B983FC Offset: 0x3B943FC VA: 0x3B983FC
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class SimpleItem : MonoBehaviour // TypeDefIndex: 22796
{
	// Fields
	public Text mNameText; // 0x20
	private SimpleItemData mItemData; // 0x28
	private int mItemDataIndex; // 0x30
	public Image mImageSelect; // 0x38
	private Button mButton; // 0x40
	private Action<int> mOnClickItemCallBack; // 0x48

	// Properties
	public int ItemIndex { get; set; }

	// Methods

	// RVA: 0x3B98484 Offset: 0x3B94484 VA: 0x3B98484
	public int get_ItemIndex() { }

	// RVA: 0x3B9848C Offset: 0x3B9448C VA: 0x3B9848C
	public void set_ItemIndex(int value) { }

	// RVA: 0x3B98494 Offset: 0x3B94494 VA: 0x3B98494
	public void Init(Action<int> OnClickItemCallBack) { }

	// RVA: 0x3B985C0 Offset: 0x3B945C0 VA: 0x3B985C0
	private void OnButtonClicked() { }

	// RVA: 0x3B985E0 Offset: 0x3B945E0 VA: 0x3B985E0
	public void SetItemData(SimpleItemData itemData, int itemIndex) { }

	// RVA: 0x3B98630 Offset: 0x3B94630 VA: 0x3B98630
	public void SetItemSelected(bool isSelected) { }

	// RVA: 0x3B986D4 Offset: 0x3B946D4 VA: 0x3B986D4
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class SimpleItemList : MonoBehaviour // TypeDefIndex: 22797
{
	// Fields
	public List<SimpleItem> mItemList; // 0x20

	// Methods

	// RVA: 0x3B986E4 Offset: 0x3B946E4 VA: 0x3B986E4
	public void Init() { }

	// RVA: 0x3B986E8 Offset: 0x3B946E8 VA: 0x3B986E8
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class SliderComplexItem : MonoBehaviour // TypeDefIndex: 22798
{
	// Fields
	public Text mNameText; // 0x20
	public Image mIcon; // 0x28
	public Image mStarIcon; // 0x30
	public Text mStarCount; // 0x38
	public Text mDesc; // 0x40
	public Slider mSlider; // 0x48
	public Color32 mRedStarColor; // 0x50
	public Color32 mGrayStarColor; // 0x54
	private int mItemDataIndex; // 0x58
	private ItemData mItemData; // 0x60

	// Methods

	// RVA: 0x3B986F0 Offset: 0x3B946F0 VA: 0x3B986F0
	public void Init() { }

	// RVA: 0x3B9880C Offset: 0x3B9480C VA: 0x3B9880C
	private void OnStarClicked(GameObject obj) { }

	// RVA: 0x3B98834 Offset: 0x3B94834 VA: 0x3B98834
	public void SetStarCount(int count) { }

	// RVA: 0x3B988E8 Offset: 0x3B948E8 VA: 0x3B988E8
	public void SetItemData(ItemData itemData, int itemIndex) { }

	// RVA: 0x3B98994 Offset: 0x3B94994 VA: 0x3B98994
	public void OnSliderValueChange(float value) { }

	// RVA: 0x3B989B0 Offset: 0x3B949B0 VA: 0x3B989B0
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class SliderComplexItemList : MonoBehaviour // TypeDefIndex: 22799
{
	// Fields
	public List<SliderComplexItem> mItemList; // 0x20

	// Methods

	// RVA: 0x3B989CC Offset: 0x3B949CC VA: 0x3B989CC
	public void Init() { }

	// RVA: 0x3B98B14 Offset: 0x3B94B14 VA: 0x3B98B14
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class SliderItem : MonoBehaviour // TypeDefIndex: 22800
{
	// Fields
	public Text mNameText; // 0x20
	public Image mIcon; // 0x28
	public Text mDesc; // 0x30
	public Slider mSlider; // 0x38
	private ItemData mItemData; // 0x40
	private int mItemDataIndex; // 0x48

	// Methods

	// RVA: 0x3B98B1C Offset: 0x3B94B1C VA: 0x3B98B1C
	public void Init() { }

	// RVA: 0x3B98BC0 Offset: 0x3B94BC0 VA: 0x3B98BC0
	public void SetItemData(ItemData itemData, int itemIndex) { }

	// RVA: 0x3B98C7C Offset: 0x3B94C7C VA: 0x3B98C7C
	public void OnSliderValueChange(float value) { }

	// RVA: 0x3B98C98 Offset: 0x3B94C98 VA: 0x3B98C98
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class SliderItemList : MonoBehaviour // TypeDefIndex: 22801
{
	// Fields
	public List<SliderItem> mItemList; // 0x20

	// Methods

	// RVA: 0x3B98CA8 Offset: 0x3B94CA8 VA: 0x3B98CA8
	public void Init() { }

	// RVA: 0x3B98DF0 Offset: 0x3B94DF0 VA: 0x3B98DF0
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class SpinDatePickerItem : MonoBehaviour // TypeDefIndex: 22802
{
	// Fields
	public Text mText; // 0x20
	public int mValue; // 0x28

	// Properties
	public int Value { get; set; }

	// Methods

	// RVA: 0x3B98DF8 Offset: 0x3B94DF8 VA: 0x3B98DF8
	public void Init() { }

	// RVA: 0x3B98DFC Offset: 0x3B94DFC VA: 0x3B98DFC
	public int get_Value() { }

	// RVA: 0x3B98E04 Offset: 0x3B94E04 VA: 0x3B98E04
	public void set_Value(int value) { }

	// RVA: 0x3B98E0C Offset: 0x3B94E0C VA: 0x3B98E0C
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class TextDescRowColItem : MonoBehaviour // TypeDefIndex: 22803
{
	// Fields
	public Text mNameText; // 0x20
	public Text mRowText; // 0x28
	public Text mColumnText; // 0x30
	public Text mDescText; // 0x38
	private int mItemDataIndex; // 0x40
	private ItemData mItemData; // 0x48

	// Methods

	// RVA: 0x3B98E14 Offset: 0x3B94E14 VA: 0x3B98E14
	public void Init() { }

	// RVA: 0x3B98E18 Offset: 0x3B94E18 VA: 0x3B98E18
	public void SetItemData(ItemData itemData, int itemIndex, int row, int column) { }

	// RVA: 0x3B98F58 Offset: 0x3B94F58 VA: 0x3B98F58
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class TextDescRowColItemList : MonoBehaviour // TypeDefIndex: 22804
{
	// Fields
	public List<TextDescRowColItem> mItemList; // 0x20

	// Methods

	// RVA: 0x3B98F68 Offset: 0x3B94F68 VA: 0x3B98F68
	public void Init() { }

	// RVA: 0x3B990A4 Offset: 0x3B950A4 VA: 0x3B990A4
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ToggleItem : MonoBehaviour // TypeDefIndex: 22805
{
	// Fields
	public Text mNameText; // 0x20
	public Image mIcon; // 0x28
	public Text mDescText; // 0x30
	public Toggle mToggle; // 0x38
	private ItemData mItemData; // 0x40
	private int mItemIndex; // 0x48

	// Methods

	// RVA: 0x3B990AC Offset: 0x3B950AC VA: 0x3B990AC
	public void Init() { }

	// RVA: 0x3B99150 Offset: 0x3B95150 VA: 0x3B99150
	private void OnToggleValueChanged(bool check) { }

	// RVA: 0x3B99170 Offset: 0x3B95170 VA: 0x3B99170
	public void SetItemData(ItemData itemData, int itemIndex) { }

	// RVA: 0x3B99224 Offset: 0x3B95224 VA: 0x3B99224
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ToggleItemList : MonoBehaviour // TypeDefIndex: 22806
{
	// Fields
	public List<ToggleItem> mItemList; // 0x20

	// Methods

	// RVA: 0x3B99234 Offset: 0x3B95234 VA: 0x3B99234
	public void Init() { }

	// RVA: 0x3B9937C Offset: 0x3B9537C VA: 0x3B9937C
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ToggleRowColItem : MonoBehaviour // TypeDefIndex: 22807
{
	// Fields
	public Text mNameText; // 0x20
	public Image mIcon; // 0x28
	public Image mStarIcon; // 0x30
	public Text mStarCount; // 0x38
	public Text mRowText; // 0x40
	public Text mColumnText; // 0x48
	public Color32 mRedStarColor; // 0x50
	public Color32 mGrayStarColor; // 0x54
	public Toggle mToggle; // 0x58
	private int mItemDataIndex; // 0x60
	private ItemData mItemData; // 0x68

	// Methods

	// RVA: 0x3B99384 Offset: 0x3B95384 VA: 0x3B99384
	public void Init() { }

	// RVA: 0x3B994A0 Offset: 0x3B954A0 VA: 0x3B994A0
	private void OnToggleValueChanged(bool check) { }

	// RVA: 0x3B994C0 Offset: 0x3B954C0 VA: 0x3B994C0
	private void OnStarClicked(GameObject obj) { }

	// RVA: 0x3B994E8 Offset: 0x3B954E8 VA: 0x3B994E8
	public void SetStarCount(int count) { }

	// RVA: 0x3B9959C Offset: 0x3B9559C VA: 0x3B9959C
	public void SetItemData(ItemData itemData, int itemIndex, int row, int column) { }

	// RVA: 0x3B99708 Offset: 0x3B95708 VA: 0x3B99708
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ToggleRowColItemList : MonoBehaviour // TypeDefIndex: 22808
{
	// Fields
	public List<ToggleRowColItem> mItemList; // 0x20

	// Methods

	// RVA: 0x3B99724 Offset: 0x3B95724 VA: 0x3B99724
	public void Init() { }

	// RVA: 0x3B9986C Offset: 0x3B9586C VA: 0x3B9986C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TreeViewItem.<>c__DisplayClass10_0 // TypeDefIndex: 22809
{
	// Fields
	public int index; // 0x10
	public TreeViewItem <>4__this; // 0x18

	// Methods

	// RVA: 0x3B999B8 Offset: 0x3B959B8 VA: 0x3B999B8
	public void .ctor() { }

	// RVA: 0x3B99C20 Offset: 0x3B95C20 VA: 0x3B99C20
	internal void <Init>b__0(GameObject obj) { }
}

// Namespace: SuperScrollView
public class TreeViewItem : MonoBehaviour // TypeDefIndex: 22810
{
	// Fields
	public Text mNameText; // 0x20
	public Image mIcon; // 0x28
	public Image[] mStarArray; // 0x30
	public Text mDesc; // 0x38
	public Text mDescExtend; // 0x40
	public Color32 mRedStarColor; // 0x48
	public Color32 mGrayStarColor; // 0x4C
	private int mItemDataIndex; // 0x50
	private int mChildDataIndex; // 0x54
	private ItemData mItemData; // 0x58

	// Methods

	// RVA: 0x3B99874 Offset: 0x3B95874 VA: 0x3B99874
	public void Init() { }

	// RVA: 0x3B999C0 Offset: 0x3B959C0 VA: 0x3B999C0
	private void OnStarClicked(int index) { }

	// RVA: 0x3B99A04 Offset: 0x3B95A04 VA: 0x3B99A04
	public void SetStarCount(int count) { }

	// RVA: 0x3B99B40 Offset: 0x3B95B40 VA: 0x3B99B40
	public void SetItemData(ItemData itemData, int itemIndex, int childIndex) { }

	// RVA: 0x3B99C0C Offset: 0x3B95C0C VA: 0x3B99C0C
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class TreeViewItemHead : MonoBehaviour // TypeDefIndex: 22811
{
	// Fields
	public Text mText; // 0x20
	public GameObject mArrow; // 0x28
	public Button mButton; // 0x30
	private int mTreeItemIndex; // 0x38
	private Action<int> mClickHandler; // 0x40

	// Properties
	public int TreeItemIndex { get; }

	// Methods

	// RVA: 0x3B99C40 Offset: 0x3B95C40 VA: 0x3B99C40
	public int get_TreeItemIndex() { }

	// RVA: 0x3B99C48 Offset: 0x3B95C48 VA: 0x3B99C48
	public void Init() { }

	// RVA: 0x3B99CD8 Offset: 0x3B95CD8 VA: 0x3B99CD8
	public void SetClickCallBack(Action<int> clickHandler) { }

	// RVA: 0x3B99CE0 Offset: 0x3B95CE0 VA: 0x3B99CE0
	private void OnButtonClicked() { }

	// RVA: 0x3B99D00 Offset: 0x3B95D00 VA: 0x3B99D00
	public void SetExpand(bool expand) { }

	// RVA: 0x3B99D4C Offset: 0x3B95D4C VA: 0x3B99D4C
	public void SetItemData(int treeItemIndex, bool expand) { }

	// RVA: 0x3B99D5C Offset: 0x3B95D5C VA: 0x3B99D5C
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class TreeViewSimpleItem : MonoBehaviour // TypeDefIndex: 22812
{
	// Fields
	private int mItemDataIndex; // 0x20
	private int mChildDataIndex; // 0x24
	public Text mNameText; // 0x28
	private SimpleItemData mItemData; // 0x30
	public Image mImageSelect; // 0x38
	private Button mButton; // 0x40
	private Action<int> mOnClickItemCallBack; // 0x48

	// Properties
	public int ItemIndex { get; set; }
	public int ItemChildIndex { get; set; }

	// Methods

	// RVA: 0x3B99D6C Offset: 0x3B95D6C VA: 0x3B99D6C
	public int get_ItemIndex() { }

	// RVA: 0x3B99D74 Offset: 0x3B95D74 VA: 0x3B99D74
	public void set_ItemIndex(int value) { }

	// RVA: 0x3B99D7C Offset: 0x3B95D7C VA: 0x3B99D7C
	public int get_ItemChildIndex() { }

	// RVA: 0x3B99D84 Offset: 0x3B95D84 VA: 0x3B99D84
	public void set_ItemChildIndex(int value) { }

	// RVA: 0x3B99D8C Offset: 0x3B95D8C VA: 0x3B99D8C
	public void Init(Action<int> OnClickItemCallBack) { }

	// RVA: 0x3B99EB8 Offset: 0x3B95EB8 VA: 0x3B99EB8
	private void OnButtonClicked() { }

	// RVA: 0x3B99ED8 Offset: 0x3B95ED8 VA: 0x3B99ED8
	public void SetItemData(SimpleItemData itemData, int itemIndex, int childIndex) { }

	// RVA: 0x3B99F34 Offset: 0x3B95F34 VA: 0x3B99F34
	public void SetItemSelected(bool isSelected) { }

	// RVA: 0x3B99FD8 Offset: 0x3B95FD8 VA: 0x3B99FD8
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ResManager : MonoBehaviour // TypeDefIndex: 22813
{
	// Fields
	public Sprite[] spriteObjArray; // 0x20
	private static ResManager instance; // 0x0
	private string[] mWordList; // 0x28
	private Dictionary<string, Sprite> spriteObjDict; // 0x30

	// Properties
	public static ResManager Get { get; }
	public int SpriteCount { get; }

	// Methods

	// RVA: 0x3B9294C Offset: 0x3B8E94C VA: 0x3B9294C
	public static ResManager get_Get() { }

	// RVA: 0x3B99FE8 Offset: 0x3B95FE8 VA: 0x3B99FE8
	private void InitData() { }

	// RVA: 0x3B9A0C8 Offset: 0x3B960C8 VA: 0x3B9A0C8
	private void Awake() { }

	// RVA: 0x3B94828 Offset: 0x3B90828 VA: 0x3B94828
	public Sprite GetSpriteByName(string spriteName) { }

	// RVA: 0x3B9A128 Offset: 0x3B96128 VA: 0x3B9A128
	public string GetRandomSpriteName() { }

	// RVA: 0x3B9A17C Offset: 0x3B9617C VA: 0x3B9A17C
	public int get_SpriteCount() { }

	// RVA: 0x3B9A198 Offset: 0x3B96198 VA: 0x3B9A198
	public Sprite GetSpriteByIndex(int index) { }

	// RVA: 0x3B92A20 Offset: 0x3B8EA20 VA: 0x3B92A20
	public string GetSpriteNameByIndex(int index) { }

	// RVA: 0x3B9A1D8 Offset: 0x3B961D8 VA: 0x3B9A1D8
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ChatViewChangeViewportHeightScript : MonoBehaviour // TypeDefIndex: 22814
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public DragChangSizeScript mDragChangSizeScript; // 0x28
	private Button mScrollToButton; // 0x30
	private InputField mScrollToInput; // 0x38
	private Button mAppendUser1Button; // 0x40
	private Button mAppendUser2Button; // 0x48
	private Button mBackButton; // 0x50

	// Methods

	// RVA: 0x3B9A260 Offset: 0x3B96260 VA: 0x3B9A260
	private void Start() { }

	// RVA: 0x3B9A39C Offset: 0x3B9639C VA: 0x3B9A39C
	private void InitButtonPanel() { }

	// RVA: 0x3B9A690 Offset: 0x3B96690 VA: 0x3B9A690
	private void OnViewPortHeightChanged() { }

	// RVA: 0x3B9A6B0 Offset: 0x3B966B0 VA: 0x3B9A6B0
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3B9A7E4 Offset: 0x3B967E4 VA: 0x3B9A7E4
	private void OnAppendUser1ButtonClicked() { }

	// RVA: 0x3B9A894 Offset: 0x3B96894 VA: 0x3B9A894
	private void OnAppendUser2ButtonClicked() { }

	// RVA: 0x3B9A944 Offset: 0x3B96944 VA: 0x3B9A944
	private void OnScrollToButtonClicked() { }

	// RVA: 0x3B9A9A8 Offset: 0x3B969A8 VA: 0x3B9A9A8
	private void OnBackButtonClicked() { }

	// RVA: 0x3B9A9F4 Offset: 0x3B969F4 VA: 0x3B9A9F4
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ChatViewDemoScript : MonoBehaviour // TypeDefIndex: 22815
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	private Button mScrollToButton; // 0x28
	private InputField mScrollToInput; // 0x30
	private Button mAppendUser1Button; // 0x38
	private Button mAppendUser2Button; // 0x40
	private Button mBackButton; // 0x48

	// Methods

	// RVA: 0x3B9A9FC Offset: 0x3B969FC VA: 0x3B9A9FC
	private void Start() { }

	// RVA: 0x3B9AAD4 Offset: 0x3B96AD4 VA: 0x3B9AAD4
	private void InitButtonPanel() { }

	// RVA: 0x3B9ADC8 Offset: 0x3B96DC8 VA: 0x3B9ADC8
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3B9AEFC Offset: 0x3B96EFC VA: 0x3B9AEFC
	private void OnAppendUser1ButtonClicked() { }

	// RVA: 0x3B9AFAC Offset: 0x3B96FAC VA: 0x3B9AFAC
	private void OnAppendUser2ButtonClicked() { }

	// RVA: 0x3B9B05C Offset: 0x3B9705C VA: 0x3B9B05C
	private void OnScrollToButtonClicked() { }

	// RVA: 0x3B9B0C4 Offset: 0x3B970C4 VA: 0x3B9B0C4
	private void OnBackButtonClicked() { }

	// RVA: 0x3B9B110 Offset: 0x3B97110 VA: 0x3B9B110
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class GalleryHorizontalDemoScript : MonoBehaviour // TypeDefIndex: 22816
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private ButtonPanelGallery mButtonPanel; // 0x38

	// Methods

	// RVA: 0x3B9B118 Offset: 0x3B97118 VA: 0x3B9B118
	private void Start() { }

	// RVA: 0x3B9B23C Offset: 0x3B9723C VA: 0x3B9B23C
	private void InitButtonPanel() { }

	// RVA: 0x3B9B2D8 Offset: 0x3B972D8 VA: 0x3B9B2D8
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3B9B408 Offset: 0x3B97408 VA: 0x3B9B408
	private void LateUpdate() { }

	// RVA: 0x3B9B568 Offset: 0x3B97568 VA: 0x3B9B568
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class GalleryVerticalDemoScript : MonoBehaviour // TypeDefIndex: 22817
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private ButtonPanelGallery mButtonPanel; // 0x38

	// Methods

	// RVA: 0x3B9B578 Offset: 0x3B97578 VA: 0x3B9B578
	private void Start() { }

	// RVA: 0x3B9B69C Offset: 0x3B9769C VA: 0x3B9B69C
	private void InitButtonPanel() { }

	// RVA: 0x3B9B738 Offset: 0x3B97738 VA: 0x3B9B738
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3B9B868 Offset: 0x3B97868 VA: 0x3B9B868
	private void LateUpdate() { }

	// RVA: 0x3B9B9C8 Offset: 0x3B979C8 VA: 0x3B9B9C8
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class GridViewClickLoadMoreDemoScript : MonoBehaviour // TypeDefIndex: 22818
{
	// Fields
	public LoopGridView mLoopGridView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private LoadingTipStatus mLoadingTipStatus; // 0x38
	private int mLoadMoreCount; // 0x3C
	private ButtonPanelGridViewLoad mButtonPanel; // 0x40

	// Methods

	// RVA: 0x3B9B9D8 Offset: 0x3B979D8 VA: 0x3B9B9D8
	private void Start() { }

	// RVA: 0x3B9BB00 Offset: 0x3B97B00 VA: 0x3B9BB00
	private void InitButtonPanel() { }

	// RVA: 0x3B9BBA8 Offset: 0x3B97BA8 VA: 0x3B9BBA8
	private LoopGridViewItem OnGetItemByRowColumn(LoopGridView gridView, int index, int row, int column) { }

	// RVA: 0x3B9BDB0 Offset: 0x3B97DB0 VA: 0x3B9BDB0
	private void UpdateLoadingTip(LoopGridViewItem item) { }

	// RVA: 0x3B9BF2C Offset: 0x3B97F2C VA: 0x3B9BF2C
	private void Update() { }

	// RVA: 0x3B9BF7C Offset: 0x3B97F7C VA: 0x3B9BF7C
	private void OnLoadMoreButtonClicked() { }

	// RVA: 0x3B9C0D0 Offset: 0x3B980D0 VA: 0x3B9C0D0
	private void OnDataSourceLoadMoreFinished() { }

	// RVA: 0x3B9C16C Offset: 0x3B9816C VA: 0x3B9C16C
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class GridViewComplexDemoScript : MonoBehaviour // TypeDefIndex: 22819
{
	// Fields
	public LoopGridView mLoopGridView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private ButtonPanelGridView mButtonPanel; // 0x38

	// Methods

	// RVA: 0x3B9C184 Offset: 0x3B98184 VA: 0x3B9C184
	private void Start() { }

	// RVA: 0x3B9C2AC Offset: 0x3B982AC VA: 0x3B9C2AC
	private void InitButtonPanel() { }

	// RVA: 0x3B9C348 Offset: 0x3B98348 VA: 0x3B9C348
	private LoopGridViewItem OnGetItemByRowColumn(LoopGridView gridView, int index, int row, int column) { }

	// RVA: 0x3B9C464 Offset: 0x3B98464 VA: 0x3B9C464
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class GridViewDemoScript : MonoBehaviour // TypeDefIndex: 22820
{
	// Fields
	public LoopGridView mLoopGridView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private ButtonPanelGridView mButtonPanel; // 0x38

	// Methods

	// RVA: 0x3B9C474 Offset: 0x3B98474 VA: 0x3B9C474
	private void Start() { }

	// RVA: 0x3B9C59C Offset: 0x3B9859C VA: 0x3B9C59C
	private void InitButtonPanel() { }

	// RVA: 0x3B9C638 Offset: 0x3B98638 VA: 0x3B9C638
	private LoopGridViewItem OnGetItemByRowColumn(LoopGridView gridView, int index, int row, int column) { }

	// RVA: 0x3B9C768 Offset: 0x3B98768 VA: 0x3B9C768
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class GridViewDiagonalDemoScript : MonoBehaviour // TypeDefIndex: 22821
{
	// Fields
	public LoopGridView mLoopGridView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private ButtonPanelGridView mButtonPanel; // 0x38

	// Methods

	// RVA: 0x3B9C778 Offset: 0x3B98778 VA: 0x3B9C778
	private void Start() { }

	// RVA: 0x3B9C8A0 Offset: 0x3B988A0 VA: 0x3B9C8A0
	private void InitButtonPanel() { }

	// RVA: 0x3B9C93C Offset: 0x3B9893C VA: 0x3B9C93C
	private LoopGridViewItem OnGetItemByRowColumn(LoopGridView gridView, int index, int row, int column) { }

	// RVA: 0x3B9CA58 Offset: 0x3B98A58 VA: 0x3B9CA58
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class GridViewDiagonalSelectDeleteDemoScript : MonoBehaviour // TypeDefIndex: 22822
{
	// Fields
	public LoopGridView mLoopGridView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private ButtonPanelGridViewDelete mButtonPanel; // 0x38

	// Methods

	// RVA: 0x3B9CA68 Offset: 0x3B98A68 VA: 0x3B9CA68
	private void Start() { }

	// RVA: 0x3B9CB90 Offset: 0x3B98B90 VA: 0x3B9CB90
	private void InitButtonPanel() { }

	// RVA: 0x3B9CC2C Offset: 0x3B98C2C VA: 0x3B9CC2C
	private LoopGridViewItem OnGetItemByRowColumn(LoopGridView gridView, int index, int row, int column) { }

	// RVA: 0x3B9CD48 Offset: 0x3B98D48 VA: 0x3B9CD48
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class GridViewMultiplePrefabDemoScript : MonoBehaviour // TypeDefIndex: 22823
{
	// Fields
	public LoopGridView mLoopGridView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private ButtonPanelGridView mButtonPanel; // 0x38

	// Methods

	// RVA: 0x3B9CD58 Offset: 0x3B98D58 VA: 0x3B9CD58
	private void Start() { }

	// RVA: 0x3B9CE80 Offset: 0x3B98E80 VA: 0x3B9CE80
	private void InitButtonPanel() { }

	// RVA: 0x3B9CF1C Offset: 0x3B98F1C VA: 0x3B9CF1C
	private LoopGridViewItem OnGetItemByRowColumn(LoopGridView gridView, int index, int row, int column) { }

	// RVA: 0x3B9D1A8 Offset: 0x3B991A8 VA: 0x3B9D1A8
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class GridViewSelectDeleteDemoScript : MonoBehaviour // TypeDefIndex: 22824
{
	// Fields
	public LoopGridView mLoopGridView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private ButtonPanelGridViewDelete mButtonPanel; // 0x38

	// Methods

	// RVA: 0x3B9D1B8 Offset: 0x3B991B8 VA: 0x3B9D1B8
	private void Start() { }

	// RVA: 0x3B9D2E0 Offset: 0x3B992E0 VA: 0x3B9D2E0
	private void InitButtonPanel() { }

	// RVA: 0x3B9D37C Offset: 0x3B9937C VA: 0x3B9D37C
	private LoopGridViewItem OnGetItemByRowColumn(LoopGridView gridView, int index, int row, int column) { }

	// RVA: 0x3B9D480 Offset: 0x3B99480 VA: 0x3B9D480
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class GridViewSimpleDemo : MonoBehaviour // TypeDefIndex: 22825
{
	// Fields
	public LoopGridView mLoopGridView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<SimpleItemData> mDataSourceMgr; // 0x30
	private Button mSetCountButton; // 0x38
	private InputField mSetCountInput; // 0x40
	private Button mScrollToButton; // 0x48
	private InputField mScrollToInput; // 0x50
	private Button mAddButton; // 0x58
	private Button mBackButton; // 0x60
	private int mCurrentSelectIndex; // 0x68

	// Methods

	// RVA: 0x3B9D490 Offset: 0x3B99490 VA: 0x3B9D490
	private void Start() { }

	// RVA: 0x3B9D880 Offset: 0x3B99880 VA: 0x3B9D880
	private LoopGridViewItem OnGetItemByRowColumn(LoopGridView gridView, int index, int row, int column) { }

	// RVA: 0x3B9D9E8 Offset: 0x3B999E8 VA: 0x3B9D9E8
	private void OnItemClicked(int index) { }

	// RVA: 0x3B9DA0C Offset: 0x3B99A0C VA: 0x3B9DA0C
	private void OnSetCountButtonClicked() { }

	// RVA: 0x3B9DAC8 Offset: 0x3B99AC8 VA: 0x3B9DAC8
	private void OnScrollToButtonClicked() { }

	// RVA: 0x3B9DB68 Offset: 0x3B99B68 VA: 0x3B9DB68
	private void OnAddButtonClicked() { }

	// RVA: 0x3B9DC28 Offset: 0x3B99C28 VA: 0x3B9DC28
	private void OnBackButtonClicked() { }

	// RVA: 0x3B9DC74 Offset: 0x3B99C74 VA: 0x3B9DC74
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ListViewBottomToTopDemoScript : MonoBehaviour // TypeDefIndex: 22826
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private ButtonPanel mButtonPanel; // 0x38

	// Methods

	// RVA: 0x3B9DC8C Offset: 0x3B99C8C VA: 0x3B9DC8C
	private void Start() { }

	// RVA: 0x3B9DDB0 Offset: 0x3B99DB0 VA: 0x3B9DDB0
	private void InitButtonPanel() { }

	// RVA: 0x3B9DE4C Offset: 0x3B99E4C VA: 0x3B9DE4C
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3B9DF7C Offset: 0x3B99F7C VA: 0x3B9DF7C
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ListViewChangeItemHeightDemoScript : MonoBehaviour // TypeDefIndex: 22827
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private ButtonPanel mButtonPanel; // 0x38

	// Methods

	// RVA: 0x3B9DF8C Offset: 0x3B99F8C VA: 0x3B9DF8C
	private void Start() { }

	// RVA: 0x3B9E0B0 Offset: 0x3B9A0B0 VA: 0x3B9E0B0
	private void InitButtonPanel() { }

	// RVA: 0x3B9E14C Offset: 0x3B9A14C VA: 0x3B9E14C
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3B9E27C Offset: 0x3B9A27C VA: 0x3B9E27C
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ListViewClickLoadMoreDemoScript : MonoBehaviour // TypeDefIndex: 22828
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private LoadingTipStatus mLoadingTipStatus; // 0x38
	private int mLoadMoreCount; // 0x3C
	private ButtonPanelLoad mButtonPanel; // 0x40

	// Methods

	// RVA: 0x3B9E28C Offset: 0x3B9A28C VA: 0x3B9E28C
	private void Start() { }

	// RVA: 0x3B9E3B0 Offset: 0x3B9A3B0 VA: 0x3B9E3B0
	private void InitButtonPanel() { }

	// RVA: 0x3B9E458 Offset: 0x3B9A458 VA: 0x3B9E458
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3B9E660 Offset: 0x3B9A660 VA: 0x3B9E660
	private void UpdateLoadingTip(LoopListViewItem2 item) { }

	// RVA: 0x3B9E7DC Offset: 0x3B9A7DC VA: 0x3B9E7DC
	private void Update() { }

	// RVA: 0x3B9E82C Offset: 0x3B9A82C VA: 0x3B9E82C
	private void OnLoadMoreButtonClicked() { }

	// RVA: 0x3B9E994 Offset: 0x3B9A994 VA: 0x3B9E994
	private void OnDataSourceLoadMoreFinished() { }

	// RVA: 0x3B9EA40 Offset: 0x3B9AA40 VA: 0x3B9EA40
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ListViewFilterDemoScript : MonoBehaviour // TypeDefIndex: 22829
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private InputField mFilterClickInput; // 0x38
	private Button mFilterButton; // 0x40
	private InputField mFilterInput; // 0x48
	private Button mSetCountButton; // 0x50
	private InputField mSetCountInput; // 0x58
	private Button mScrollToButton; // 0x60
	private InputField mScrollToInput; // 0x68
	private Button mAddButton; // 0x70
	private InputField mAddInput; // 0x78
	private Button mBackButton; // 0x80
	private List<ItemData> mFilteredDataList; // 0x88
	private string mFilerStr; // 0x90
	private string mFilerClickStr; // 0x98

	// Methods

	// RVA: 0x3B9EA58 Offset: 0x3B9AA58 VA: 0x3B9EA58
	private void Start() { }

	// RVA: 0x3B9F0D4 Offset: 0x3B9B0D4 VA: 0x3B9F0D4
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3B9F1F8 Offset: 0x3B9B1F8 VA: 0x3B9F1F8
	private void OnFilterButtonClicked() { }

	// RVA: 0x3B9F2AC Offset: 0x3B9B2AC VA: 0x3B9F2AC
	private void OnInputChanged(string value) { }

	// RVA: 0x3B9F06C Offset: 0x3B9B06C VA: 0x3B9F06C
	private void UpdateFilteredDataList(string filterStr) { }

	// RVA: 0x3B9F338 Offset: 0x3B9B338 VA: 0x3B9F338
	private void OnSetCountButtonClicked() { }

	// RVA: 0x3B9F3FC Offset: 0x3B9B3FC VA: 0x3B9F3FC
	private void OnScrollToButtonClicked() { }

	// RVA: 0x3B9F488 Offset: 0x3B9B488 VA: 0x3B9F488
	private void OnAddButtonClicked() { }

	// RVA: 0x3B9F588 Offset: 0x3B9B588 VA: 0x3B9F588
	private void OnBackButtonClicked() { }

	// RVA: 0x3B9F5D8 Offset: 0x3B9B5D8 VA: 0x3B9F5D8
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ListViewLeftToRightDemoScript : MonoBehaviour // TypeDefIndex: 22830
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private ButtonPanel mButtonPanel; // 0x38

	// Methods

	// RVA: 0x3B9F5E8 Offset: 0x3B9B5E8 VA: 0x3B9F5E8
	private void Start() { }

	// RVA: 0x3B9F70C Offset: 0x3B9B70C VA: 0x3B9F70C
	private void InitButtonPanel() { }

	// RVA: 0x3B9F7AC Offset: 0x3B9B7AC VA: 0x3B9F7AC
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3B9F8E4 Offset: 0x3B9B8E4 VA: 0x3B9F8E4
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ListViewMultiplePrefabDemoScript : MonoBehaviour // TypeDefIndex: 22831
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private ButtonPanel mButtonPanel; // 0x38

	// Methods

	// RVA: 0x3B9F8F4 Offset: 0x3B9B8F4 VA: 0x3B9F8F4
	private void Start() { }

	// RVA: 0x3B9FA18 Offset: 0x3B9BA18 VA: 0x3B9FA18
	private void InitButtonPanel() { }

	// RVA: 0x3B9FAB8 Offset: 0x3B9BAB8 VA: 0x3B9FAB8
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3B9FD34 Offset: 0x3B9BD34 VA: 0x3B9FD34
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ListViewMultiplePrefabLeftToRightDemoScript : MonoBehaviour // TypeDefIndex: 22832
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private ButtonPanel mButtonPanel; // 0x38

	// Methods

	// RVA: 0x3B9FD44 Offset: 0x3B9BD44 VA: 0x3B9FD44
	private void Start() { }

	// RVA: 0x3B9FE68 Offset: 0x3B9BE68 VA: 0x3B9FE68
	private void InitButtonPanel() { }

	// RVA: 0x3B9FF08 Offset: 0x3B9BF08 VA: 0x3B9FF08
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3BA0184 Offset: 0x3B9C184 VA: 0x3BA0184
	public void .ctor() { }
}

// Namespace: SuperScrollView
public enum LoadingTipStatus // TypeDefIndex: 22833
{
	// Fields
	public int value__; // 0x0
	public const LoadingTipStatus None = 0;
	public const LoadingTipStatus WaitContinureDrag = 1;
	public const LoadingTipStatus WaitRelease = 2;
	public const LoadingTipStatus WaitLoad = 3;
	public const LoadingTipStatus Loaded = 4;
}

// Namespace: SuperScrollView
public class ListViewPullDownRefreshDemoScript : MonoBehaviour // TypeDefIndex: 22834
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private LoadingTipStatus mLoadingTipStatus; // 0x38
	private float mDataLoadedTipShowLeftTime; // 0x3C
	private float mLoadingTipItemHeight; // 0x40
	private ButtonPanelLoad mButtonPanel; // 0x48

	// Methods

	// RVA: 0x3BA0194 Offset: 0x3B9C194 VA: 0x3BA0194
	private void Start() { }

	// RVA: 0x3BA0364 Offset: 0x3B9C364 VA: 0x3BA0364
	private void InitButtonPanel() { }

	// RVA: 0x3BA0410 Offset: 0x3B9C410 VA: 0x3BA0410
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3BA05B8 Offset: 0x3B9C5B8 VA: 0x3BA05B8
	private void UpdateLoadingTip(LoopListViewItem2 item) { }

	// RVA: 0x3BA0844 Offset: 0x3B9C844 VA: 0x3BA0844
	private void OnDraging() { }

	// RVA: 0x3BA09A0 Offset: 0x3B9C9A0 VA: 0x3BA09A0
	private void OnEndDrag() { }

	// RVA: 0x3BA0AF8 Offset: 0x3B9CAF8 VA: 0x3BA0AF8
	private void OnDataSourceRefreshFinished() { }

	// RVA: 0x3BA0BD0 Offset: 0x3B9CBD0 VA: 0x3BA0BD0
	private void Update() { }

	// RVA: 0x3BA0D18 Offset: 0x3B9CD18 VA: 0x3BA0D18
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ListViewPullDownRefreshOrPullUpLoadDemo : MonoBehaviour // TypeDefIndex: 22835
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private LoadingTipStatus mLoadingTipStatusForRefresh; // 0x38
	private LoadingTipStatus mLoadingTipStatusForLoad; // 0x3C
	private float mDataLoadedTipShowLeftTime; // 0x40
	private float mLoadingTipItemHeightForRefresh; // 0x44
	private float mLoadingTipItemHeightForLoad; // 0x48
	private int mLoadMoreCount; // 0x4C
	private ButtonPanelLoad mButtonPanel; // 0x50

	// Methods

	// RVA: 0x3BA0D30 Offset: 0x3B9CD30 VA: 0x3BA0D30
	private void Start() { }

	// RVA: 0x3BA0F00 Offset: 0x3B9CF00 VA: 0x3BA0F00
	private void InitButtonPanel() { }

	// RVA: 0x3BA0FA8 Offset: 0x3B9CFA8 VA: 0x3BA0FA8
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3BA1184 Offset: 0x3B9D184 VA: 0x3BA1184
	private void UpdateLoadingTipForRefresh(LoopListViewItem2 item) { }

	// RVA: 0x3BA162C Offset: 0x3B9D62C VA: 0x3BA162C
	private void OnDraging() { }

	// RVA: 0x3BA1954 Offset: 0x3B9D954 VA: 0x3BA1954
	private void OnEndDrag() { }

	// RVA: 0x3BA1644 Offset: 0x3B9D644 VA: 0x3BA1644
	private void OnDragingForRefresh() { }

	// RVA: 0x3BA196C Offset: 0x3B9D96C VA: 0x3BA196C
	private void OnEndDragForRefresh() { }

	// RVA: 0x3BA1C60 Offset: 0x3B9DC60 VA: 0x3BA1C60
	private void OnDataSourceRefreshFinished() { }

	// RVA: 0x3BA1D3C Offset: 0x3B9DD3C VA: 0x3BA1D3C
	private void Update() { }

	// RVA: 0x3BA1410 Offset: 0x3B9D410 VA: 0x3BA1410
	private void UpdateLoadingTipForLoad(LoopListViewItem2 item) { }

	// RVA: 0x3BA17A4 Offset: 0x3B9D7A4 VA: 0x3BA17A4
	private void OnDragingForLoad() { }

	// RVA: 0x3BA1AC8 Offset: 0x3B9DAC8 VA: 0x3BA1AC8
	private void OnEndDragForLoad() { }

	// RVA: 0x3BA1E84 Offset: 0x3B9DE84 VA: 0x3BA1E84
	private void OnDataSourceLoadMoreFinished() { }

	// RVA: 0x3BA1F30 Offset: 0x3B9DF30 VA: 0x3BA1F30
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ListViewPullUpLoadMoreDemo : MonoBehaviour // TypeDefIndex: 22836
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private LoadingTipStatus mLoadingTipStatus; // 0x38
	private float mLoadingTipItemHeight; // 0x3C
	private int mLoadMoreCount; // 0x40
	private ButtonPanelLoad mButtonPanel; // 0x48

	// Methods

	// RVA: 0x3BA1F54 Offset: 0x3B9DF54 VA: 0x3BA1F54
	private void Start() { }

	// RVA: 0x3BA216C Offset: 0x3B9E16C VA: 0x3BA216C
	private void InitButtonPanel() { }

	// RVA: 0x3BA2218 Offset: 0x3B9E218 VA: 0x3BA2218
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3BA23B0 Offset: 0x3B9E3B0 VA: 0x3BA23B0
	private void UpdateLoadingTip(LoopListViewItem2 item) { }

	// RVA: 0x3BA25CC Offset: 0x3B9E5CC VA: 0x3BA25CC
	private void OnBeginDrag() { }

	// RVA: 0x3BA25D0 Offset: 0x3B9E5D0 VA: 0x3BA25D0
	private void OnDraging() { }

	// RVA: 0x3BA277C Offset: 0x3B9E77C VA: 0x3BA277C
	private void OnEndDrag() { }

	// RVA: 0x3BA2910 Offset: 0x3B9E910 VA: 0x3BA2910
	private void OnDataSourceLoadMoreFinished() { }

	// RVA: 0x3BA29BC Offset: 0x3B9E9BC VA: 0x3BA29BC
	private void Update() { }

	// RVA: 0x3BA2A0C Offset: 0x3B9EA0C VA: 0x3BA2A0C
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ListViewRightToLeftDemoScript : MonoBehaviour // TypeDefIndex: 22837
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private ButtonPanel mButtonPanel; // 0x38

	// Methods

	// RVA: 0x3BA2A28 Offset: 0x3B9EA28 VA: 0x3BA2A28
	private void Start() { }

	// RVA: 0x3BA2B4C Offset: 0x3B9EB4C VA: 0x3BA2B4C
	private void InitButtonPanel() { }

	// RVA: 0x3BA2BEC Offset: 0x3B9EBEC VA: 0x3BA2BEC
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3BA2D24 Offset: 0x3B9ED24 VA: 0x3BA2D24
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ListViewSelectDeleteDemoScript : MonoBehaviour // TypeDefIndex: 22838
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private ButtonPanelDelete mButtonPanel; // 0x38

	// Methods

	// RVA: 0x3BA2D34 Offset: 0x3B9ED34 VA: 0x3BA2D34
	private void Start() { }

	// RVA: 0x3BA2E58 Offset: 0x3B9EE58 VA: 0x3BA2E58
	private void InitButtonPanel() { }

	// RVA: 0x3BA2EF8 Offset: 0x3B9EEF8 VA: 0x3BA2EF8
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3BA3030 Offset: 0x3B9F030 VA: 0x3BA3030
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ListViewSimpleDemoScript : MonoBehaviour // TypeDefIndex: 22839
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<SimpleItemData> mDataSourceMgr; // 0x30
	private Button mSetCountButton; // 0x38
	private InputField mSetCountInput; // 0x40
	private Button mScrollToButton; // 0x48
	private InputField mScrollToInput; // 0x50
	private Button mAddButton; // 0x58
	private Button mBackButton; // 0x60
	private int mCurrentSelectIndex; // 0x68

	// Methods

	// RVA: 0x3BA3040 Offset: 0x3B9F040 VA: 0x3BA3040
	private void Start() { }

	// RVA: 0x3BA3458 Offset: 0x3B9F458 VA: 0x3BA3458
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3BA35F8 Offset: 0x3B9F5F8 VA: 0x3BA35F8
	private void OnItemClicked(int index) { }

	// RVA: 0x3BA361C Offset: 0x3B9F61C VA: 0x3BA361C
	private void OnSetCountButtonClicked() { }

	// RVA: 0x3BA36D4 Offset: 0x3B9F6D4 VA: 0x3BA36D4
	private void OnScrollToButtonClicked() { }

	// RVA: 0x3BA3770 Offset: 0x3B9F770 VA: 0x3BA3770
	private void OnAddButtonClicked() { }

	// RVA: 0x3BA382C Offset: 0x3B9F82C VA: 0x3BA382C
	private void OnBackButtonClicked() { }

	// RVA: 0x3BA387C Offset: 0x3B9F87C VA: 0x3BA387C
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ListViewTopToBottomDemoScript : MonoBehaviour // TypeDefIndex: 22840
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private ButtonPanel mButtonPanel; // 0x38

	// Methods

	// RVA: 0x3BA3894 Offset: 0x3B9F894 VA: 0x3BA3894
	private void Start() { }

	// RVA: 0x3BA39B8 Offset: 0x3B9F9B8 VA: 0x3BA39B8
	private void InitButtonPanel() { }

	// RVA: 0x3BA3A58 Offset: 0x3B9FA58 VA: 0x3BA3A58
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3BA3B90 Offset: 0x3B9FB90 VA: 0x3BA3B90
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class NestedGridViewLeftToRightDemoScript : MonoBehaviour // TypeDefIndex: 22841
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<NestedItemData> mDataSourceMgr; // 0x30
	private ButtonPanelNested mButtonPanel; // 0x38

	// Methods

	// RVA: 0x3BA3BA0 Offset: 0x3B9FBA0 VA: 0x3BA3BA0
	private void Start() { }

	// RVA: 0x3BA3CC4 Offset: 0x3B9FCC4 VA: 0x3BA3CC4
	private void InitButtonPanel() { }

	// RVA: 0x3BA3D64 Offset: 0x3B9FD64 VA: 0x3BA3D64
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3BA3E6C Offset: 0x3B9FE6C VA: 0x3BA3E6C
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class NestedGridViewTopToBottomDemoScript : MonoBehaviour // TypeDefIndex: 22842
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<NestedItemData> mDataSourceMgr; // 0x30
	private ButtonPanelNested mButtonPanel; // 0x38

	// Methods

	// RVA: 0x3BA3E7C Offset: 0x3B9FE7C VA: 0x3BA3E7C
	private void Start() { }

	// RVA: 0x3BA3FA0 Offset: 0x3B9FFA0 VA: 0x3BA3FA0
	private void InitButtonPanel() { }

	// RVA: 0x3BA4040 Offset: 0x3BA0040 VA: 0x3BA4040
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3BA4148 Offset: 0x3BA0148 VA: 0x3BA4148
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class NestedLeftToRightDemoScript : MonoBehaviour // TypeDefIndex: 22843
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<NestedItemData> mDataSourceMgr; // 0x30
	private ButtonPanelNested mButtonPanel; // 0x38

	// Methods

	// RVA: 0x3BA4158 Offset: 0x3BA0158 VA: 0x3BA4158
	private void Start() { }

	// RVA: 0x3BA427C Offset: 0x3BA027C VA: 0x3BA427C
	private void InitButtonPanel() { }

	// RVA: 0x3BA431C Offset: 0x3BA031C VA: 0x3BA431C
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3BA4450 Offset: 0x3BA0450 VA: 0x3BA4450
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class NestedTopToBottomDemoScript : MonoBehaviour // TypeDefIndex: 22844
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<NestedItemData> mDataSourceMgr; // 0x30
	private ButtonPanelNested mButtonPanel; // 0x38

	// Methods

	// RVA: 0x3BA4460 Offset: 0x3BA0460 VA: 0x3BA4460
	private void Start() { }

	// RVA: 0x3BA4584 Offset: 0x3BA0584 VA: 0x3BA4584
	private void InitButtonPanel() { }

	// RVA: 0x3BA4624 Offset: 0x3BA0624 VA: 0x3BA4624
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3BA4758 Offset: 0x3BA0758 VA: 0x3BA4758
	public void .ctor() { }
}

// Namespace: 
private class PageViewDemoScript.DotElem // TypeDefIndex: 22845
{
	// Fields
	public GameObject mDotElemRoot; // 0x10
	public GameObject mDotNormal; // 0x18
	public GameObject mDotSelect; // 0x20

	// Methods

	// RVA: 0x3BA5464 Offset: 0x3BA1464 VA: 0x3BA5464
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PageViewDemoScript.<>c__DisplayClass25_0 // TypeDefIndex: 22846
{
	// Fields
	public PageViewDemoScript <>4__this; // 0x10
	public int dotIndex; // 0x18

	// Methods

	// RVA: 0x3BA545C Offset: 0x3BA145C VA: 0x3BA545C
	public void .ctor() { }

	// RVA: 0x3BA5DAC Offset: 0x3BA1DAC VA: 0x3BA5DAC
	internal void <CreateOneDot>b__0(GameObject tmpObj) { }
}

// Namespace: SuperScrollView
public class PageViewDemoScript : MonoBehaviour // TypeDefIndex: 22847
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	public RectTransform mParentView; // 0x30
	public RectTransform mDotsRoot; // 0x38
	public RectTransform mDotTemplate; // 0x40
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x48
	private Button mSetCountButton; // 0x50
	private InputField mSetCountInput; // 0x58
	private Button mScrollToButton; // 0x60
	private InputField mScrollToInput; // 0x68
	private Button mAddButton; // 0x70
	private Button mBackButton; // 0x78
	private int mPageCount; // 0x80
	private int mMaxPageCount; // 0x84
	private int mCountEachPage; // 0x88
	private int mMaxItemCount; // 0x8C
	private List<PageViewDemoScript.DotElem> mDotElemList; // 0x90
	private List<RectTransform> mDotRectList; // 0x98

	// Methods

	// RVA: 0x3BA4768 Offset: 0x3BA0768 VA: 0x3BA4768
	private void Start() { }

	// RVA: 0x3BA4AB8 Offset: 0x3BA0AB8 VA: 0x3BA4AB8
	public void InitButtonPanel() { }

	// RVA: 0x3BA4DE8 Offset: 0x3BA0DE8 VA: 0x3BA4DE8
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int pageIndex) { }

	// RVA: 0x3BA4A38 Offset: 0x3BA0A38 VA: 0x3BA4A38
	private void UpdatePageCount(int itemCount) { }

	// RVA: 0x3BA4A5C Offset: 0x3BA0A5C VA: 0x3BA4A5C
	private void InitAllDots() { }

	// RVA: 0x3BA5004 Offset: 0x3BA1004 VA: 0x3BA5004
	private void CreateDots(int count) { }

	// RVA: 0x3BA503C Offset: 0x3BA103C VA: 0x3BA503C
	private void CreateOneDot(RectTransform rectParent, RectTransform rectTemplate) { }

	// RVA: 0x3BA546C Offset: 0x3BA146C VA: 0x3BA546C
	private void OnDotClicked(int index) { }

	// RVA: 0x3BA54B4 Offset: 0x3BA14B4 VA: 0x3BA54B4
	private void UpdateAllDots() { }

	// RVA: 0x3BA5530 Offset: 0x3BA1530 VA: 0x3BA5530
	private void RefreshAllDots(int selectedIndex) { }

	// RVA: 0x3BA5610 Offset: 0x3BA1610 VA: 0x3BA5610
	private void ResetDots() { }

	// RVA: 0x3BA56B0 Offset: 0x3BA16B0 VA: 0x3BA56B0
	private void AppendDots(int count) { }

	// RVA: 0x3BA56E8 Offset: 0x3BA16E8 VA: 0x3BA56E8
	private void RemoveDots(int count) { }

	// RVA: 0x3BA57E8 Offset: 0x3BA17E8 VA: 0x3BA57E8
	private void OnSnapNearestChanged(LoopListView2 listView, LoopListViewItem2 item) { }

	// RVA: 0x3BA57EC Offset: 0x3BA17EC VA: 0x3BA57EC
	private void OnBeginDrag() { }

	// RVA: 0x3BA57F0 Offset: 0x3BA17F0 VA: 0x3BA57F0
	private void OnDraging() { }

	// RVA: 0x3BA57F4 Offset: 0x3BA17F4 VA: 0x3BA57F4
	private void OnEndDrag() { }

	// RVA: 0x3BA5944 Offset: 0x3BA1944 VA: 0x3BA5944
	private void OnSetCountButtonClicked() { }

	// RVA: 0x3BA5A60 Offset: 0x3BA1A60 VA: 0x3BA5A60
	private void OnScrollToButtonClicked() { }

	// RVA: 0x3BA5B30 Offset: 0x3BA1B30 VA: 0x3BA5B30
	private void OnAddButtonClicked() { }

	// RVA: 0x3BA5C68 Offset: 0x3BA1C68 VA: 0x3BA5C68
	private void OnBackButtonClicked() { }

	// RVA: 0x3BA5CB8 Offset: 0x3BA1CB8 VA: 0x3BA5CB8
	public void .ctor() { }
}

// Namespace: 
private class PageViewSimpleDemoScript.DotElem // TypeDefIndex: 22848
{
	// Fields
	public GameObject mDotElemRoot; // 0x10
	public GameObject mDotNormal; // 0x18
	public GameObject mDotSelect; // 0x20

	// Methods

	// RVA: 0x3BA68B0 Offset: 0x3BA28B0 VA: 0x3BA68B0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PageViewSimpleDemoScript.<>c__DisplayClass20_0 // TypeDefIndex: 22849
{
	// Fields
	public PageViewSimpleDemoScript <>4__this; // 0x10
	public int dotIndex; // 0x18

	// Methods

	// RVA: 0x3BA68A8 Offset: 0x3BA28A8 VA: 0x3BA68A8
	public void .ctor() { }

	// RVA: 0x3BA703C Offset: 0x3BA303C VA: 0x3BA703C
	internal void <CreateOneDot>b__0(GameObject tmpObj) { }
}

// Namespace: SuperScrollView
public class PageViewSimpleDemoScript : MonoBehaviour // TypeDefIndex: 22850
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public RectTransform mParentView; // 0x28
	public RectTransform mDotsRoot; // 0x30
	public RectTransform mDotTemplate; // 0x38
	private DataSourceMgr<SimpleItemData> mDataSourceMgr; // 0x40
	private Button mSetCountButton; // 0x48
	private InputField mSetCountInput; // 0x50
	private Button mScrollToButton; // 0x58
	private InputField mScrollToInput; // 0x60
	private Button mAddButton; // 0x68
	private Button mBackButton; // 0x70
	private int mPageCount; // 0x78
	private const int mMaxPageCount = 10;
	private List<PageViewSimpleDemoScript.DotElem> mDotElemList; // 0x80

	// Methods

	// RVA: 0x3BA5DCC Offset: 0x3BA1DCC VA: 0x3BA5DCC
	private void Start() { }

	// RVA: 0x3BA6004 Offset: 0x3BA2004 VA: 0x3BA6004
	public void InitButtonPanel() { }

	// RVA: 0x3BA6334 Offset: 0x3BA2334 VA: 0x3BA6334
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int pageIndex) { }

	// RVA: 0x3BA5FA8 Offset: 0x3BA1FA8 VA: 0x3BA5FA8
	private void InitAllDots() { }

	// RVA: 0x3BA6450 Offset: 0x3BA2450 VA: 0x3BA6450
	private void CreateDots(int count) { }

	// RVA: 0x3BA6488 Offset: 0x3BA2488 VA: 0x3BA6488
	private void CreateOneDot(RectTransform rectParent, RectTransform rectTemplate) { }

	// RVA: 0x3BA68B8 Offset: 0x3BA28B8 VA: 0x3BA68B8
	private void OnDotClicked(int index) { }

	// RVA: 0x3BA6900 Offset: 0x3BA2900 VA: 0x3BA6900
	private void UpdateAllDots() { }

	// RVA: 0x3BA697C Offset: 0x3BA297C VA: 0x3BA697C
	private void RefreshAllDots(int selectedIndex) { }

	// RVA: 0x3BA6A5C Offset: 0x3BA2A5C VA: 0x3BA6A5C
	private void ResetDots() { }

	// RVA: 0x3BA6AFC Offset: 0x3BA2AFC VA: 0x3BA6AFC
	private void AppendDots(int count) { }

	// RVA: 0x3BA6B34 Offset: 0x3BA2B34 VA: 0x3BA6B34
	private void RemoveDots(int count) { }

	// RVA: 0x3BA6C34 Offset: 0x3BA2C34 VA: 0x3BA6C34
	private void OnSnapNearestChanged(LoopListView2 listView, LoopListViewItem2 item) { }

	// RVA: 0x3BA6C38 Offset: 0x3BA2C38 VA: 0x3BA6C38
	private void OnEndDrag() { }

	// RVA: 0x3BA6D88 Offset: 0x3BA2D88 VA: 0x3BA6D88
	private void OnSetCountButtonClicked() { }

	// RVA: 0x3BA6E48 Offset: 0x3BA2E48 VA: 0x3BA6E48
	private void OnScrollToButtonClicked() { }

	// RVA: 0x3BA6EBC Offset: 0x3BA2EBC VA: 0x3BA6EBC
	private void OnAddButtonClicked() { }

	// RVA: 0x3BA6F5C Offset: 0x3BA2F5C VA: 0x3BA6F5C
	private void OnBackButtonClicked() { }

	// RVA: 0x3BA6FAC Offset: 0x3BA2FAC VA: 0x3BA6FAC
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ResponsiveViewDemoScript : MonoBehaviour // TypeDefIndex: 22851
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private int mItemCountPerRow; // 0x38
	private int mMinWidth; // 0x3C
	public DragChangSizeScript mDragChangSizeScript; // 0x40
	private ButtonPanelSpecial mButtonPanel; // 0x48

	// Methods

	// RVA: 0x3BA705C Offset: 0x3BA305C VA: 0x3BA705C
	private void Start() { }

	// RVA: 0x3BA72E0 Offset: 0x3BA32E0 VA: 0x3BA72E0
	private void InitButtonPanel() { }

	// RVA: 0x3BA7388 Offset: 0x3BA3388 VA: 0x3BA7388
	private void UpdateItemPrefab() { }

	// RVA: 0x3BA7224 Offset: 0x3BA3224 VA: 0x3BA7224
	private void OnViewPortSizeChanged() { }

	// RVA: 0x3BA793C Offset: 0x3BA393C VA: 0x3BA793C
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3BA7B3C Offset: 0x3BA3B3C VA: 0x3BA7B3C
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class ResponsiveViewRefreshLoadDemoScript : MonoBehaviour // TypeDefIndex: 22852
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private LoadingTipStatus mLoadingTipStatusForRefresh; // 0x38
	private LoadingTipStatus mLoadingTipStatusForLoad; // 0x3C
	private float mDataLoadedTipShowLeftTime; // 0x40
	private float mLoadingTipItemHeightForRefresh; // 0x44
	private float mLoadingTipItemHeightForLoad; // 0x48
	private int mLoadMoreCount; // 0x4C
	private Button mScrollToButton; // 0x50
	private InputField mScrollToInput; // 0x58
	private Button mBackButton; // 0x60
	private int mItemCountPerRow; // 0x68
	public DragChangSizeScript mDragChangSizeScript; // 0x70

	// Methods

	// RVA: 0x3BA7B58 Offset: 0x3BA3B58 VA: 0x3BA7B58
	private void Start() { }

	// RVA: 0x3BA7FBC Offset: 0x3BA3FBC VA: 0x3BA7FBC
	private void OnBackButtonClicked() { }

	// RVA: 0x3BA800C Offset: 0x3BA400C VA: 0x3BA800C
	private void UpdateItemPrefab() { }

	// RVA: 0x3BA7F6C Offset: 0x3BA3F6C VA: 0x3BA7F6C
	private void OnViewPortSizeChanged() { }

	// RVA: 0x3BA7EE8 Offset: 0x3BA3EE8 VA: 0x3BA7EE8
	private int GetMaxRowCount() { }

	// RVA: 0x3BA85B0 Offset: 0x3BA45B0 VA: 0x3BA85B0
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int row) { }

	// RVA: 0x3BA8844 Offset: 0x3BA4844 VA: 0x3BA8844
	private void UpdateLoadingTipForRefresh(LoopListViewItem2 item) { }

	// RVA: 0x3BA8DC0 Offset: 0x3BA4DC0 VA: 0x3BA8DC0
	private void OnDraging() { }

	// RVA: 0x3BA90F0 Offset: 0x3BA50F0 VA: 0x3BA90F0
	private void OnEndDrag() { }

	// RVA: 0x3BA8DD8 Offset: 0x3BA4DD8 VA: 0x3BA8DD8
	private void OnDragingForRefresh() { }

	// RVA: 0x3BA9108 Offset: 0x3BA5108 VA: 0x3BA9108
	private void OnEndDragForRefresh() { }

	// RVA: 0x3BA93C8 Offset: 0x3BA53C8 VA: 0x3BA93C8
	private void OnDataSourceRefreshFinished() { }

	// RVA: 0x3BA94A4 Offset: 0x3BA54A4 VA: 0x3BA94A4
	private void Update() { }

	// RVA: 0x3BA8B6C Offset: 0x3BA4B6C VA: 0x3BA8B6C
	private void UpdateLoadingTipForLoad(LoopListViewItem2 item) { }

	// RVA: 0x3BA8F68 Offset: 0x3BA4F68 VA: 0x3BA8F68
	private void OnDragingForLoad() { }

	// RVA: 0x3BA9250 Offset: 0x3BA5250 VA: 0x3BA9250
	private void OnEndDragForLoad() { }

	// RVA: 0x3BA95EC Offset: 0x3BA55EC VA: 0x3BA95EC
	private void OnDataSourceLoadMoreFinished() { }

	// RVA: 0x3BA9668 Offset: 0x3BA5668 VA: 0x3BA9668
	private void OnScrollToButtonClicked() { }

	// RVA: 0x3BA96EC Offset: 0x3BA56EC VA: 0x3BA96EC
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class SpecialGridViewDemoScript : MonoBehaviour // TypeDefIndex: 22853
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private const int mItemCountPerRow = 3;
	private ButtonPanelSpecial mButtonPanel; // 0x38

	// Methods

	// RVA: 0x3BA9718 Offset: 0x3BA5718 VA: 0x3BA9718
	private void Start() { }

	// RVA: 0x3BA9890 Offset: 0x3BA5890 VA: 0x3BA9890
	private void InitButtonPanel() { }

	// RVA: 0x3BA9938 Offset: 0x3BA5938 VA: 0x3BA9938
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int rowIndex) { }

	// RVA: 0x3BA9B2C Offset: 0x3BA5B2C VA: 0x3BA9B2C
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class SpecialGridViewFeatureDemoScript : MonoBehaviour // TypeDefIndex: 22854
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private const int mItemCountPerRow = 3;
	private Button mSetCountButton; // 0x38
	private InputField mSetCountInput; // 0x40
	private Button mScrollToButton; // 0x48
	private InputField mScrollToInput; // 0x50
	private Button mAddButton; // 0x58
	private InputField mAddInput; // 0x60
	private Button mBackButton; // 0x68
	private int[] mFeatureArray; // 0x70
	private string[] mFeaturePrefabs; // 0x78

	// Methods

	// RVA: 0x3BA9B3C Offset: 0x3BA5B3C VA: 0x3BA9B3C
	private void Start() { }

	// RVA: 0x3BA9D38 Offset: 0x3BA5D38 VA: 0x3BA9D38
	private void InitButtonPanel() { }

	// RVA: 0x3BAA0A4 Offset: 0x3BA60A4 VA: 0x3BAA0A4
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int rowIndex) { }

	// RVA: 0x3BAA0E0 Offset: 0x3BA60E0 VA: 0x3BAA0E0
	private LoopListViewItem2 NewFeatureItems(LoopListView2 listView, int rowIndex) { }

	// RVA: 0x3BAA32C Offset: 0x3BA632C VA: 0x3BAA32C
	private LoopListViewItem2 NewMainItems(LoopListView2 listView, int rowIndex) { }

	// RVA: 0x3BAA55C Offset: 0x3BA655C VA: 0x3BAA55C
	private int GetInitItemIndex(int rowIndex) { }

	// RVA: 0x3BAA5BC Offset: 0x3BA65BC VA: 0x3BAA5BC
	private int GetInitRowIndex(int rowIndex) { }

	// RVA: 0x3BA9CD8 Offset: 0x3BA5CD8 VA: 0x3BA9CD8
	private int GetFeatureItemCount() { }

	// RVA: 0x3BAA5E4 Offset: 0x3BA65E4 VA: 0x3BAA5E4
	private int GetFeatureLastRowIndex() { }

	// RVA: 0x3BAA604 Offset: 0x3BA6604 VA: 0x3BAA604
	private int GetRowIndex(int itemIndex) { }

	// RVA: 0x3BAA694 Offset: 0x3BA6694 VA: 0x3BAA694
	private void OnSetCountButtonClicked() { }

	// RVA: 0x3BAA750 Offset: 0x3BA6750 VA: 0x3BAA750
	private void OnScrollToButtonClicked() { }

	// RVA: 0x3BAA7FC Offset: 0x3BA67FC VA: 0x3BAA7FC
	private void OnAddButtonClicked() { }

	// RVA: 0x3BAA938 Offset: 0x3BA6938 VA: 0x3BAA938
	private void OnBackButtonClicked() { }

	// RVA: 0x3BAA988 Offset: 0x3BA6988 VA: 0x3BAA988
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class SpecialGridViewPullDownRefreshDemoScript : MonoBehaviour // TypeDefIndex: 22855
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private LoadingTipStatus mLoadingTipStatusForRefresh; // 0x38
	private float mDataLoadedTipShowLeftTime; // 0x3C
	private float mLoadingTipItemHeightForRefresh; // 0x40
	private int mItemCountPerRow; // 0x44
	private ButtonPanelSpecialLoad mButtonPanel; // 0x48

	// Methods

	// RVA: 0x3BAAAB8 Offset: 0x3BA6AB8 VA: 0x3BAAAB8
	private void Start() { }

	// RVA: 0x3BAACEC Offset: 0x3BA6CEC VA: 0x3BAACEC
	private void InitButtonPanel() { }

	// RVA: 0x3BAAC68 Offset: 0x3BA6C68 VA: 0x3BAAC68
	private int GetMaxRowCount() { }

	// RVA: 0x3BAADA0 Offset: 0x3BA6DA0 VA: 0x3BAADA0
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int rowIndex) { }

	// RVA: 0x3BAAFE4 Offset: 0x3BA6FE4 VA: 0x3BAAFE4
	private void UpdateLoadingTipForRefresh(LoopListViewItem2 item) { }

	// RVA: 0x3BAB30C Offset: 0x3BA730C VA: 0x3BAB30C
	private void OnDraging() { }

	// RVA: 0x3BAB4A0 Offset: 0x3BA74A0 VA: 0x3BAB4A0
	private void OnEndDrag() { }

	// RVA: 0x3BAB310 Offset: 0x3BA7310 VA: 0x3BAB310
	private void OnDragingForRefresh() { }

	// RVA: 0x3BAB4A4 Offset: 0x3BA74A4 VA: 0x3BAB4A4
	private void OnEndDragForRefresh() { }

	// RVA: 0x3BAB5EC Offset: 0x3BA75EC VA: 0x3BAB5EC
	private void OnDataSourceRefreshFinished() { }

	// RVA: 0x3BAB6C4 Offset: 0x3BA76C4 VA: 0x3BAB6C4
	private void Update() { }

	// RVA: 0x3BAB80C Offset: 0x3BA780C VA: 0x3BAB80C
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class SpecialGridViewPullUpLoadMoreDemoScript : MonoBehaviour // TypeDefIndex: 22856
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private LoadingTipStatus mLoadingTipStatusForLoad; // 0x38
	private float mLoadingTipItemHeightForLoad; // 0x3C
	private int mLoadMoreCount; // 0x40
	private int mItemCountPerRow; // 0x44
	private ButtonPanelSpecialLoad mButtonPanel; // 0x48

	// Methods

	// RVA: 0x3BAB828 Offset: 0x3BA7828 VA: 0x3BAB828
	private void Start() { }

	// RVA: 0x3BABA5C Offset: 0x3BA7A5C VA: 0x3BABA5C
	private void InitButtonPanel() { }

	// RVA: 0x3BAB9D8 Offset: 0x3BA79D8 VA: 0x3BAB9D8
	private int GetMaxRowCount() { }

	// RVA: 0x3BABB10 Offset: 0x3BA7B10 VA: 0x3BABB10
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int rowIndex) { }

	// RVA: 0x3BABF74 Offset: 0x3BA7F74 VA: 0x3BABF74
	private void Update() { }

	// RVA: 0x3BABFC4 Offset: 0x3BA7FC4 VA: 0x3BABFC4
	private void OnDraging() { }

	// RVA: 0x3BAC150 Offset: 0x3BA8150 VA: 0x3BAC150
	private void OnEndDrag() { }

	// RVA: 0x3BABD58 Offset: 0x3BA7D58 VA: 0x3BABD58
	private void UpdateLoadingTipForLoad(LoopListViewItem2 item) { }

	// RVA: 0x3BABFC8 Offset: 0x3BA7FC8 VA: 0x3BABFC8
	private void OnDragingForLoad() { }

	// RVA: 0x3BAC154 Offset: 0x3BA8154 VA: 0x3BAC154
	private void OnEndDragForLoad() { }

	// RVA: 0x3BAC2CC Offset: 0x3BA82CC VA: 0x3BAC2CC
	private void OnDataSourceLoadMoreFinished() { }

	// RVA: 0x3BAC348 Offset: 0x3BA8348 VA: 0x3BAC348
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class SpecialGridViewSelectDeleteDemoScript : MonoBehaviour // TypeDefIndex: 22857
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private const int mItemCountPerRow = 3;
	private ButtonPanelSpecialDelete mButtonPanel; // 0x38

	// Methods

	// RVA: 0x3BAC36C Offset: 0x3BA836C VA: 0x3BAC36C
	private void Start() { }

	// RVA: 0x3BAC4E4 Offset: 0x3BA84E4 VA: 0x3BAC4E4
	private void InitButtonPanel() { }

	// RVA: 0x3BAC58C Offset: 0x3BA858C VA: 0x3BAC58C
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int rowIndex) { }

	// RVA: 0x3BAC784 Offset: 0x3BA8784 VA: 0x3BAC784
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class SpecialGridViewSimpleDemoScript : MonoBehaviour // TypeDefIndex: 22858
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<SimpleItemData> mDataSourceMgr; // 0x30
	private const int mItemCountPerRow = 3;
	private Button mSetCountButton; // 0x38
	private InputField mSetCountInput; // 0x40
	private Button mScrollToButton; // 0x48
	private InputField mScrollToInput; // 0x50
	private Button mAddButton; // 0x58
	private Button mBackButton; // 0x60
	private int mCurrentSelectIndex; // 0x68

	// Methods

	// RVA: 0x3BAC794 Offset: 0x3BA8794 VA: 0x3BAC794
	private void Start() { }

	// RVA: 0x3BACC00 Offset: 0x3BA8C00 VA: 0x3BACC00
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int rowIndex) { }

	// RVA: 0x3BACE98 Offset: 0x3BA8E98 VA: 0x3BACE98
	private void OnItemClicked(int itemIndex) { }

	// RVA: 0x3BACEBC Offset: 0x3BA8EBC VA: 0x3BACEBC
	private void OnSetCountButtonClicked() { }

	// RVA: 0x3BACF90 Offset: 0x3BA8F90 VA: 0x3BACF90
	private void OnScrollToButtonClicked() { }

	// RVA: 0x3BAD064 Offset: 0x3BA9064 VA: 0x3BAD064
	private void OnAddButtonClicked() { }

	// RVA: 0x3BAD144 Offset: 0x3BA9144 VA: 0x3BAD144
	private void OnBackButtonClicked() { }

	// RVA: 0x3BAD194 Offset: 0x3BA9194 VA: 0x3BAD194
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class SpinDatePickerDemoScript : MonoBehaviour // TypeDefIndex: 22859
{
	// Fields
	public LoopListView2 mLoopListViewMonth; // 0x20
	public LoopListView2 mLoopListViewDay; // 0x28
	public LoopListView2 mLoopListViewHour; // 0x30
	public Color mColorReserved; // 0x38
	public Color mColorSelected; // 0x48
	private Button mBackButton; // 0x58
	private static int[] mMonthDayCountArray; // 0x0
	private static string[] mMonthNameArray; // 0x8
	private int mCurSelectedMonth; // 0x60
	private int mCurSelectedDay; // 0x64
	private int mCurSelectedHour; // 0x68

	// Properties
	public int CurSelectedMonth { get; }
	public int CurSelectedDay { get; }
	public int CurSelectedHour { get; }

	// Methods

	// RVA: 0x3BAD1AC Offset: 0x3BA91AC VA: 0x3BAD1AC
	public int get_CurSelectedMonth() { }

	// RVA: 0x3BAD1B4 Offset: 0x3BA91B4 VA: 0x3BAD1B4
	public int get_CurSelectedDay() { }

	// RVA: 0x3BAD1BC Offset: 0x3BA91BC VA: 0x3BAD1BC
	public int get_CurSelectedHour() { }

	// RVA: 0x3BAD1C4 Offset: 0x3BA91C4 VA: 0x3BAD1C4
	private void Start() { }

	// RVA: 0x3BAD440 Offset: 0x3BA9440 VA: 0x3BAD440
	private void InitButtonPanel() { }

	// RVA: 0x3BAD524 Offset: 0x3BA9524 VA: 0x3BAD524
	private LoopListViewItem2 OnGetItemByIndexForHour(LoopListView2 listView, int index) { }

	// RVA: 0x3BAD65C Offset: 0x3BA965C VA: 0x3BAD65C
	private LoopListViewItem2 OnGetItemByIndexForMonth(LoopListView2 listView, int index) { }

	// RVA: 0x3BAD7D0 Offset: 0x3BA97D0 VA: 0x3BAD7D0
	private LoopListViewItem2 OnGetItemByIndexForDay(LoopListView2 listView, int index) { }

	// RVA: 0x3BAD944 Offset: 0x3BA9944 VA: 0x3BAD944
	private void OnMonthSnapTargetChanged(LoopListView2 listView, LoopListViewItem2 item) { }

	// RVA: 0x3BADAD0 Offset: 0x3BA9AD0 VA: 0x3BADAD0
	private void OnDaySnapTargetChanged(LoopListView2 listView, LoopListViewItem2 item) { }

	// RVA: 0x3BADB78 Offset: 0x3BA9B78 VA: 0x3BADB78
	private void OnHourSnapTargetChanged(LoopListView2 listView, LoopListViewItem2 item) { }

	// RVA: 0x3BADC20 Offset: 0x3BA9C20 VA: 0x3BADC20
	private void OnMonthSnapTargetFinished(LoopListView2 listView, LoopListViewItem2 item) { }

	// RVA: 0x3BAD9EC Offset: 0x3BA99EC VA: 0x3BAD9EC
	private void OnListViewSnapTargetChanged(LoopListView2 listView, int targetIndex) { }

	// RVA: 0x3BADCA0 Offset: 0x3BA9CA0 VA: 0x3BADCA0
	private void OnBackButtonClicked() { }

	// RVA: 0x3BADCF0 Offset: 0x3BA9CF0 VA: 0x3BADCF0
	public void .ctor() { }

	// RVA: 0x3BADD08 Offset: 0x3BA9D08 VA: 0x3BADD08
	private static void .cctor() { }
}

// Namespace: SuperScrollView
public class StaggeredViewLeftToRightDemoScript : MonoBehaviour // TypeDefIndex: 22860
{
	// Fields
	public LoopStaggeredGridView mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private int[] mItemWidthArrayForDemo; // 0x38
	private float mMinWidth; // 0x40
	private int mCount; // 0x44
	private ButtonPanelStaggeredView mButtonPanel; // 0x48

	// Methods

	// RVA: 0x3BAE054 Offset: 0x3BAA054 VA: 0x3BAE054
	private void Start() { }

	// RVA: 0x3BAE268 Offset: 0x3BAA268 VA: 0x3BAE268
	private void InitButtonPanel() { }

	// RVA: 0x3BAE308 Offset: 0x3BAA308 VA: 0x3BAE308
	private LoopStaggeredGridViewItem OnGetItemByIndex(LoopStaggeredGridView listView, int index) { }

	// RVA: 0x3BAE1BC Offset: 0x3BAA1BC VA: 0x3BAE1BC
	private void InitItemWidthArrayForDemo() { }

	// RVA: 0x3BAE4A0 Offset: 0x3BAA4A0 VA: 0x3BAE4A0
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class StaggeredViewSimpleLeftToRightDemoScript : MonoBehaviour // TypeDefIndex: 22861
{
	// Fields
	public LoopStaggeredGridView mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<SimpleItemData> mDataSourceMgr; // 0x30
	private int[] mItemWidthArrayForDemo; // 0x38
	private int mCount; // 0x40
	private float mMinWidth; // 0x44
	private int mCurrentSelectIndex; // 0x48
	private Button mSetCountButton; // 0x50
	private InputField mSetCountInput; // 0x58
	private Button mAddButton; // 0x60
	private Button mBackButton; // 0x68

	// Methods

	// RVA: 0x3BAE4BC Offset: 0x3BAA4BC VA: 0x3BAE4BC
	private void Start() { }

	// RVA: 0x3BAE8F8 Offset: 0x3BAA8F8 VA: 0x3BAE8F8
	private LoopStaggeredGridViewItem OnGetItemByIndex(LoopStaggeredGridView listView, int index) { }

	// RVA: 0x3BAE84C Offset: 0x3BAA84C VA: 0x3BAE84C
	private void InitItemHeightArrayForDemo() { }

	// RVA: 0x3BAEAD8 Offset: 0x3BAAAD8 VA: 0x3BAEAD8
	private void OnItemClicked(int index) { }

	// RVA: 0x3BAEAFC Offset: 0x3BAAAFC VA: 0x3BAEAFC
	private void OnSetCountButtonClicked() { }

	// RVA: 0x3BAEBB4 Offset: 0x3BAABB4 VA: 0x3BAEBB4
	private void OnAddButtonClicked() { }

	// RVA: 0x3BAEC70 Offset: 0x3BAAC70 VA: 0x3BAEC70
	private void OnBackButtonClicked() { }

	// RVA: 0x3BAECC0 Offset: 0x3BAACC0 VA: 0x3BAECC0
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class StaggeredViewSimpleTopToBottomDemoScript : MonoBehaviour // TypeDefIndex: 22862
{
	// Fields
	public LoopStaggeredGridView mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<SimpleItemData> mDataSourceMgr; // 0x30
	private int[] mItemHeightArrayForDemo; // 0x38
	private int mCount; // 0x40
	private float mMinHeight; // 0x44
	private int mCurrentSelectIndex; // 0x48
	private Button mSetCountButton; // 0x50
	private InputField mSetCountInput; // 0x58
	private Button mAddButton; // 0x60
	private Button mBackButton; // 0x68

	// Methods

	// RVA: 0x3BAECE4 Offset: 0x3BAACE4 VA: 0x3BAECE4
	private void Start() { }

	// RVA: 0x3BAF120 Offset: 0x3BAB120 VA: 0x3BAF120
	private LoopStaggeredGridViewItem OnGetItemByIndex(LoopStaggeredGridView listView, int index) { }

	// RVA: 0x3BAF074 Offset: 0x3BAB074 VA: 0x3BAF074
	private void InitItemHeightArrayForDemo() { }

	// RVA: 0x3BAF300 Offset: 0x3BAB300 VA: 0x3BAF300
	private void OnItemClicked(int index) { }

	// RVA: 0x3BAF324 Offset: 0x3BAB324 VA: 0x3BAF324
	private void OnSetCountButtonClicked() { }

	// RVA: 0x3BAF3DC Offset: 0x3BAB3DC VA: 0x3BAF3DC
	private void OnAddButtonClicked() { }

	// RVA: 0x3BAF498 Offset: 0x3BAB498 VA: 0x3BAF498
	private void OnBackButtonClicked() { }

	// RVA: 0x3BAF4E8 Offset: 0x3BAB4E8 VA: 0x3BAF4E8
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class StaggeredViewTopToBottomDemoScript : MonoBehaviour // TypeDefIndex: 22863
{
	// Fields
	public LoopStaggeredGridView mLoopListView; // 0x20
	public int mTotalDataCount; // 0x28
	private DataSourceMgr<ItemData> mDataSourceMgr; // 0x30
	private int[] mItemHeightArrayForDemo; // 0x38
	private float mMinHeight; // 0x40
	private int mCount; // 0x44
	private ButtonPanelStaggeredView mButtonPanel; // 0x48

	// Methods

	// RVA: 0x3BAF50C Offset: 0x3BAB50C VA: 0x3BAF50C
	private void Start() { }

	// RVA: 0x3BAF720 Offset: 0x3BAB720 VA: 0x3BAF720
	private void InitButtonPanel() { }

	// RVA: 0x3BAF7C0 Offset: 0x3BAB7C0 VA: 0x3BAF7C0
	private LoopStaggeredGridViewItem OnGetItemByItemIndex(LoopStaggeredGridView listView, int index) { }

	// RVA: 0x3BAF674 Offset: 0x3BAB674 VA: 0x3BAF674
	private void InitItemHeightArrayForDemo() { }

	// RVA: 0x3BAF958 Offset: 0x3BAB958 VA: 0x3BAF958
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class TreeViewDemoScript : MonoBehaviour // TypeDefIndex: 22864
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	private TreeViewDataSourceMgr<ItemData> mTreeViewDataSourceMgr; // 0x28
	private TreeViewItemCountMgr mTreeItemCountMgr; // 0x30
	private ButtonPanelTreeView mButtonPanel; // 0x38

	// Methods

	// RVA: 0x3BAF974 Offset: 0x3BAB974 VA: 0x3BAF974
	private void Start() { }

	// RVA: 0x3BAFB28 Offset: 0x3BABB28 VA: 0x3BAFB28
	private void InitButtonPanel() { }

	// RVA: 0x3BAFBDC Offset: 0x3BABBDC VA: 0x3BAFBDC
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3BAFE70 Offset: 0x3BABE70 VA: 0x3BAFE70
	public void OnExpandClicked(int index) { }

	// RVA: 0x3BAFED4 Offset: 0x3BABED4 VA: 0x3BAFED4
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class TreeViewSimpleDemoScript : MonoBehaviour // TypeDefIndex: 22865
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	private TreeViewDataSourceMgr<SimpleItemData> mTreeViewDataSourceMgr; // 0x28
	private TreeViewItemCountMgr mTreeItemCountMgr; // 0x30
	private ButtonPanelTreeViewSimple mButtonPanel; // 0x38
	private int mCurrentSelectIndex; // 0x40

	// Methods

	// RVA: 0x3BAFF40 Offset: 0x3BABF40 VA: 0x3BAFF40
	private void Start() { }

	// RVA: 0x3BB00F4 Offset: 0x3BAC0F4 VA: 0x3BB00F4
	private void InitButtonPanel() { }

	// RVA: 0x3BB01A8 Offset: 0x3BAC1A8 VA: 0x3BB01A8
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3BB0490 Offset: 0x3BAC490 VA: 0x3BB0490
	public void OnExpandClicked(int index) { }

	// RVA: 0x3BB04F4 Offset: 0x3BAC4F4 VA: 0x3BB04F4
	private void OnItemClicked(int index) { }

	// RVA: 0x3BB0518 Offset: 0x3BAC518 VA: 0x3BB0518
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class TreeViewWithChildIndentDemo : MonoBehaviour // TypeDefIndex: 22866
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	private TreeViewDataSourceMgr<ItemData> mTreeViewDataSourceMgr; // 0x28
	private TreeViewItemCountMgr mTreeItemCountMgr; // 0x30
	private ButtonPanelTreeView mButtonPanel; // 0x38

	// Methods

	// RVA: 0x3BB058C Offset: 0x3BAC58C VA: 0x3BB058C
	private void Start() { }

	// RVA: 0x3BB0740 Offset: 0x3BAC740 VA: 0x3BB0740
	private void InitButtonPanel() { }

	// RVA: 0x3BB07F4 Offset: 0x3BAC7F4 VA: 0x3BB07F4
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3BB0A88 Offset: 0x3BACA88 VA: 0x3BB0A88
	public void OnExpandClicked(int index) { }

	// RVA: 0x3BB0AEC Offset: 0x3BACAEC VA: 0x3BB0AEC
	public void .ctor() { }
}

// Namespace: SuperScrollView
public class TreeViewWithStickyHeadDemoScript : MonoBehaviour // TypeDefIndex: 22867
{
	// Fields
	public LoopListView2 mLoopListView; // 0x20
	private TreeViewDataSourceMgr<ItemData> mTreeViewDataSourceMgr; // 0x28
	private TreeViewItemCountMgr mTreeItemCountMgr; // 0x30
	public TreeViewItemHead mStickeyHeadItem; // 0x38
	private RectTransform mStickeyHeadItemRf; // 0x40
	private float mStickeyHeadItemHeight; // 0x48
	private ButtonPanelTreeViewSticky mButtonPanel; // 0x50

	// Methods

	// RVA: 0x3BB0B58 Offset: 0x3BACB58 VA: 0x3BB0B58
	private void Start() { }

	// RVA: 0x3BB1230 Offset: 0x3BAD230 VA: 0x3BB1230
	private void InitButtonPanel() { }

	// RVA: 0x3BB12EC Offset: 0x3BAD2EC VA: 0x3BB12EC
	private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index) { }

	// RVA: 0x3BB1590 Offset: 0x3BAD590 VA: 0x3BB1590
	public void OnExpandClicked(int index) { }

	// RVA: 0x3BB0E78 Offset: 0x3BACE78 VA: 0x3BB0E78
	private void UpdateStickeyHeadPos() { }

	// RVA: 0x3BB15F4 Offset: 0x3BAD5F4 VA: 0x3BB15F4
	private void OnScrollContentPosChanged(Vector2 pos) { }

	// RVA: 0x3BB15F8 Offset: 0x3BAD5F8 VA: 0x3BB15F8
	public void .ctor() { }
}

// Namespace: DG.Tweening
[AddComponentMenu("DOTween/DOTween Animation")]
public class DOTweenAnimation : ABSAnimationComponent // TypeDefIndex: 22868
{
	// Fields
	public float delay; // 0x70
	public float duration; // 0x74
	public Ease easeType; // 0x78
	public AnimationCurve easeCurve; // 0x80
	public LoopType loopType; // 0x88
	public int loops; // 0x8C
	public string id; // 0x90
	public bool isRelative; // 0x98
	public bool isFrom; // 0x99
	public bool isIndependentUpdate; // 0x9A
	public bool autoKill; // 0x9B
	public bool isActive; // 0x9C
	public bool isValid; // 0x9D
	public Component target; // 0xA0
	public DOTweenAnimationType animationType; // 0xA8
	public TargetType targetType; // 0xAC
	public TargetType forcedTargetType; // 0xB0
	public bool autoPlay; // 0xB4
	public bool useTargetAsV3; // 0xB5
	public float endValueFloat; // 0xB8
	public Vector3 endValueV3; // 0xBC
	public Vector2 endValueV2; // 0xC8
	public Color endValueColor; // 0xD0
	public string endValueString; // 0xE0
	public Rect endValueRect; // 0xE8
	public Transform endValueTransform; // 0xF8
	public bool optionalBool0; // 0x100
	public float optionalFloat0; // 0x104
	public int optionalInt0; // 0x108
	public RotateMode optionalRotationMode; // 0x10C
	public ScrambleMode optionalScrambleMode; // 0x110
	public string optionalString; // 0x118
	private bool _tweenCreated; // 0x120
	private int _playCount; // 0x124

	// Methods

	// RVA: 0x3BB166C Offset: 0x3BAD66C VA: 0x3BB166C
	private void Awake() { }

	// RVA: 0x3BB2B50 Offset: 0x3BAEB50 VA: 0x3BB2B50
	private void Start() { }

	// RVA: 0x3BB2B88 Offset: 0x3BAEB88 VA: 0x3BB2B88
	private void OnDestroy() { }

	// RVA: 0x3BB16B0 Offset: 0x3BAD6B0 VA: 0x3BB16B0
	public void CreateTween() { }

	// RVA: 0x3BB2D70 Offset: 0x3BAED70 VA: 0x3BB2D70 Slot: 4
	public override void DOPlay() { }

	// RVA: 0x3BB2DDC Offset: 0x3BAEDDC VA: 0x3BB2DDC Slot: 5
	public override void DOPlayBackwards() { }

	// RVA: 0x3BB2E48 Offset: 0x3BAEE48 VA: 0x3BB2E48 Slot: 6
	public override void DOPlayForward() { }

	// RVA: 0x3BB2EB4 Offset: 0x3BAEEB4 VA: 0x3BB2EB4 Slot: 7
	public override void DOPause() { }

	// RVA: 0x3BB2F20 Offset: 0x3BAEF20 VA: 0x3BB2F20 Slot: 8
	public override void DOTogglePause() { }

	// RVA: 0x3BB2F8C Offset: 0x3BAEF8C VA: 0x3BB2F8C Slot: 9
	public override void DORewind() { }

	// RVA: 0x3BB3068 Offset: 0x3BAF068 VA: 0x3BB3068 Slot: 10
	public override void DORestart(bool fromHere = False) { }

	// RVA: 0x3BB3270 Offset: 0x3BAF270 VA: 0x3BB3270 Slot: 11
	public override void DOComplete() { }

	// RVA: 0x3BB32E0 Offset: 0x3BAF2E0 VA: 0x3BB32E0 Slot: 12
	public override void DOKill() { }

	// RVA: 0x3BB3360 Offset: 0x3BAF360 VA: 0x3BB3360
	public void DOPlayById(string id) { }

	// RVA: 0x3BB33DC Offset: 0x3BAF3DC VA: 0x3BB33DC
	public void DOPlayAllById(string id) { }

	// RVA: 0x3BB3434 Offset: 0x3BAF434 VA: 0x3BB3434
	public void DOPauseAllById(string id) { }

	// RVA: 0x3BB348C Offset: 0x3BAF48C VA: 0x3BB348C
	public void DOPlayBackwardsById(string id) { }

	// RVA: 0x3BB3508 Offset: 0x3BAF508 VA: 0x3BB3508
	public void DOPlayBackwardsAllById(string id) { }

	// RVA: 0x3BB3560 Offset: 0x3BAF560 VA: 0x3BB3560
	public void DOPlayForwardById(string id) { }

	// RVA: 0x3BB35DC Offset: 0x3BAF5DC VA: 0x3BB35DC
	public void DOPlayForwardAllById(string id) { }

	// RVA: 0x3BB3634 Offset: 0x3BAF634 VA: 0x3BB3634
	public void DOPlayNext() { }

	// RVA: 0x3BB3768 Offset: 0x3BAF768 VA: 0x3BB3768
	public void DORewindAndPlayNext() { }

	// RVA: 0x3BB37E8 Offset: 0x3BAF7E8 VA: 0x3BB37E8
	public void DORestartById(string id) { }

	// RVA: 0x3BB3870 Offset: 0x3BAF870 VA: 0x3BB3870
	public void DORestartAllById(string id) { }

	// RVA: 0x3BB38E0 Offset: 0x3BAF8E0 VA: 0x3BB38E0
	public List<Tween> GetTweens() { }

	// RVA: 0x3BB2BC0 Offset: 0x3BAEBC0 VA: 0x3BB2BC0
	public static TargetType TypeToDOTargetType(Type t) { }

	// RVA: 0x3BB3148 Offset: 0x3BAF148 VA: 0x3BB3148
	private void ReEvaluateRelativeTween() { }

	// RVA: 0x3BB3A28 Offset: 0x3BAFA28 VA: 0x3BB3A28
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3BB3BD8 Offset: 0x3BAFBD8 VA: 0x3BB3BD8
	private void <CreateTween>b__37_0() { }
}

// Namespace: DG.Tweening
[Extension]
public static class DOTweenAnimationExtensions // TypeDefIndex: 22869
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static bool IsSameOrSubclassOf<T>(Component t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456619C Offset: 0x456219C VA: 0x456619C
	|-DOTweenAnimationExtensions.IsSameOrSubclassOf<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: AraSamples
[Serializable]
public class AxleInfo // TypeDefIndex: 22870
{
	// Fields
	public WheelCollider leftWheel; // 0x10
	public WheelCollider rightWheel; // 0x18
	public bool motor; // 0x20
	public bool steering; // 0x21

	// Methods

	// RVA: 0x3BB3BE4 Offset: 0x3BAFBE4 VA: 0x3BB3BE4
	public void .ctor() { }
}

// Namespace: AraSamples
public class CarController : MonoBehaviour // TypeDefIndex: 22871
{
	// Fields
	public List<AxleInfo> axleInfos; // 0x20
	public float maxMotorTorque; // 0x28
	public float maxSteeringAngle; // 0x2C

	// Methods

	// RVA: 0x3BB3BEC Offset: 0x3BAFBEC VA: 0x3BB3BEC
	public void ApplyLocalPositionToVisuals(WheelCollider collider) { }

	// RVA: 0x3BB3CB4 Offset: 0x3BAFCB4 VA: 0x3BB3CB4
	public void FixedUpdate() { }

	// RVA: 0x3BB3F04 Offset: 0x3BAFF04 VA: 0x3BB3F04
	public void .ctor() { }
}

// Namespace: AraSamples
public class ObjectDragger : MonoBehaviour // TypeDefIndex: 22872
{
	// Fields
	private Vector3 screenPoint; // 0x20
	private Vector3 offset; // 0x2C

	// Methods

	// RVA: 0x3BB3F0C Offset: 0x3BAFF0C VA: 0x3BB3F0C
	private void OnMouseDown() { }

	// RVA: 0x3BB3FFC Offset: 0x3BAFFFC VA: 0x3BB3FFC
	private void OnMouseDrag() { }

	// RVA: 0x3BB4094 Offset: 0x3BB0094 VA: 0x3BB4094
	public void .ctor() { }
}

// Namespace: AraSamples
public class Rotation : MonoBehaviour // TypeDefIndex: 22873
{
	// Fields
	public float speed; // 0x20
	public Vector3 axis; // 0x24

	// Methods

	// RVA: 0x3BB409C Offset: 0x3BB009C VA: 0x3BB409C
	private void Update() { }

	// RVA: 0x3BB40F8 Offset: 0x3BB00F8 VA: 0x3BB40F8
	public void .ctor() { }
}

// Namespace: AraSamples
[RequireComponent(typeof(AraTrail))]
public class WallPlayerController : MonoBehaviour // TypeDefIndex: 22874
{
	// Fields
	public float speed; // 0x20
	public int boardSize; // 0x24
	public int maxTrailLenght; // 0x28
	public Color[] colors; // 0x30
	private int coordX; // 0x38
	private int coordZ; // 0x3C
	private AraTrail trail; // 0x40

	// Methods

	// RVA: 0x3BB4108 Offset: 0x3BB0108 VA: 0x3BB4108
	private void Awake() { }

	// RVA: 0x3BB4160 Offset: 0x3BB0160 VA: 0x3BB4160
	private void Update() { }

	// RVA: 0x3BB4838 Offset: 0x3BB0838 VA: 0x3BB4838
	public void .ctor() { }
}

// Namespace: 
public enum AraTrail.TrailAlignment // TypeDefIndex: 22875
{
	// Fields
	public int value__; // 0x0
	public const AraTrail.TrailAlignment View = 0;
	public const AraTrail.TrailAlignment Velocity = 1;
	public const AraTrail.TrailAlignment Local = 2;
}

// Namespace: 
public enum AraTrail.TrailSpace // TypeDefIndex: 22876
{
	// Fields
	public int value__; // 0x0
	public const AraTrail.TrailSpace World = 0;
	public const AraTrail.TrailSpace Self = 1;
	public const AraTrail.TrailSpace Custom = 2;
}

// Namespace: 
public enum AraTrail.TrailSorting // TypeDefIndex: 22877
{
	// Fields
	public int value__; // 0x0
	public const AraTrail.TrailSorting OlderOnTop = 0;
	public const AraTrail.TrailSorting NewerOnTop = 1;
}

// Namespace: 
public enum AraTrail.Timescale // TypeDefIndex: 22878
{
	// Fields
	public int value__; // 0x0
	public const AraTrail.Timescale Normal = 0;
	public const AraTrail.Timescale Unscaled = 1;
}

// Namespace: 
public enum AraTrail.TextureMode // TypeDefIndex: 22879
{
	// Fields
	public int value__; // 0x0
	public const AraTrail.TextureMode Stretch = 0;
	public const AraTrail.TextureMode Tile = 1;
	public const AraTrail.TextureMode WorldTile = 2;
}

// Namespace: 
public struct AraTrail.CurveFrame // TypeDefIndex: 22880
{
	// Fields
	public Vector3 position; // 0x0
	public Vector3 normal; // 0xC
	public Vector3 bitangent; // 0x18
	public Vector3 tangent; // 0x24

	// Methods

	// RVA: 0x3BB6940 Offset: 0x3BB2940 VA: 0x3BB6940
	public void .ctor(Vector3 position, Vector3 normal, Vector3 bitangent, Vector3 tangent) { }

	// RVA: 0x3BB76D0 Offset: 0x3BB36D0 VA: 0x3BB76D0
	public Vector3 Transport(Vector3 newTangent, Vector3 newPosition) { }
}

// Namespace: 
public struct AraTrail.Point // TypeDefIndex: 22881
{
	// Fields
	public Vector3 position; // 0x0
	public Vector3 velocity; // 0xC
	public Vector3 tangent; // 0x18
	public Vector3 normal; // 0x24
	public Color color; // 0x30
	public float thickness; // 0x40
	public float life; // 0x44
	public float texcoord; // 0x48
	public bool discontinuous; // 0x4C

	// Methods

	// RVA: 0x3BB5B1C Offset: 0x3BB1B1C VA: 0x3BB5B1C
	public void .ctor(Vector3 position, Vector3 velocity, Vector3 tangent, Vector3 normal, Color color, float thickness, float texcoord, float lifetime) { }

	// RVA: 0x3BB6698 Offset: 0x3BB2698 VA: 0x3BB6698
	public static float CatmullRom(float p0, float p1, float p2, float p3, float t) { }

	// RVA: 0x3BB9A0C Offset: 0x3BB5A0C VA: 0x3BB9A0C
	public static AraTrail.Point op_Addition(AraTrail.Point p1, AraTrail.Point p2) { }

	// RVA: 0x3BB9AF0 Offset: 0x3BB5AF0 VA: 0x3BB9AF0
	public static AraTrail.Point op_Subtraction(AraTrail.Point p1, AraTrail.Point p2) { }
}

// Namespace: Ara
[ExecuteInEditMode]
public class AraTrail : MonoBehaviour // TypeDefIndex: 22882
{
	// Fields
	public const float epsilon = 1E-05;
	[Header("Overall")]
	[Tooltip("Trail cross-section asset, determines the shape of the emitted trail. If no asset is specified, the trail will be a simple strip.")]
	public TrailSection section; // 0x20
	[Tooltip("Whether to use world or local space to generate and simulate the trail.")]
	public AraTrail.TrailSpace space; // 0x28
	[Tooltip("Custom space to use when generating and simulating the trail")]
	public Transform customSpace; // 0x30
	[Tooltip("Whether to use regular time.")]
	public AraTrail.Timescale timescale; // 0x38
	[Tooltip("How to align the trail geometry: facing the camera (view) of using the transform's rotation (local).")]
	public AraTrail.TrailAlignment alignment; // 0x3C
	[Tooltip("Determines the order in which trail points will be rendered.")]
	public AraTrail.TrailSorting sorting; // 0x40
	[Tooltip("Thickness multiplier, in meters.")]
	public float thickness; // 0x44
	[Range(1, 8)]
	[Tooltip("Amount of smoothing iterations applied to the trail shape.")]
	public int smoothness; // 0x48
	[Min(0)]
	public float smoothingDistance; // 0x4C
	[Tooltip("Calculate accurate thickness at sharp corners.")]
	public bool highQualityCorners; // 0x50
	[Range(0, 12)]
	public int cornerRoundness; // 0x54
	[Header("Length")]
	[Tooltip("How should the thickness of the curve evolve over its lenght. The horizontal axis is normalized lenght (in the [0,1] range) and the vertical axis is a thickness multiplier.")]
	[FormerlySerializedAs("thicknessOverLenght")]
	public AnimationCurve thicknessOverLength; // 0x58
	[FormerlySerializedAs("colorOverLenght")]
	[Tooltip("How should vertex color evolve over the trail's length.")]
	public Gradient colorOverLength; // 0x60
	[Header("Time")]
	[Tooltip("How should the thickness of the curve evolve with its lifetime. The horizontal axis is normalized lifetime (in the [0,1] range) and the vertical axis is a thickness multiplier.")]
	public AnimationCurve thicknessOverTime; // 0x68
	[Tooltip("How should vertex color evolve over the trail's lifetime.")]
	public Gradient colorOverTime; // 0x70
	[Header("Emission")]
	public bool emit; // 0x78
	[Tooltip("Initial thickness of trail points when they are first spawned.")]
	public float initialThickness; // 0x7C
	[Tooltip("Initial color of trail points when they are first spawned.")]
	public Color initialColor; // 0x80
	[Tooltip("Initial velocity of trail points when they are first spawned.")]
	public Vector3 initialVelocity; // 0x90
	[Tooltip("Minimum amount of time (in seconds) that must pass before spawning a new point.")]
	public float timeInterval; // 0x9C
	[Tooltip("Minimum distance (in meters) that must be left between consecutive points in the trail.")]
	public float minDistance; // 0xA0
	[Tooltip("Duration of the trail (in seconds).")]
	public float time; // 0xA4
	[Header("Physics")]
	[Tooltip("Toggles trail physics.")]
	public bool enablePhysics; // 0xA8
	[Tooltip("Amount of seconds pre-simulated before the trail appears. Useful when you want a trail to be already simulating when the game starts.")]
	public float warmup; // 0xAC
	[Tooltip("Gravity affecting the trail.")]
	public Vector3 gravity; // 0xB0
	[Tooltip("Amount of speed transferred from the transform to the trail. 0 means no velocity is transferred, 1 means 100% of the velocity is transferred.")]
	[Range(0, 1)]
	public float inertia; // 0xBC
	[Range(0, 1)]
	[Tooltip("Amount of temporal smoothing applied to the velocity transferred from the transform to the trail.")]
	public float velocitySmoothing; // 0xC0
	[Range(0, 1)]
	[Tooltip("Amount of damping applied to the trail's velocity. Larger values will slow down the trail more as time passes.")]
	public float damping; // 0xC4
	[Header("Rendering")]
	public Material[] materials; // 0xC8
	public ShadowCastingMode castShadows; // 0xD0
	public bool receiveShadows; // 0xD4
	public bool useLightProbes; // 0xD5
	[Tooltip("Quad mapping will send the shader an extra coordinate for each vertex, that can be used to correct UV distortion using tex2Dproj.")]
	[Header("Texture")]
	public bool quadMapping; // 0xD6
	[Tooltip("How to apply the texture over the trail: stretch it all over its lenght, or tile it.")]
	public AraTrail.TextureMode textureMode; // 0xD8
	[Tooltip("Defines how many times are U coords repeated across the length of the trail.")]
	public float uvFactor; // 0xDC
	[Tooltip("Defines how many times are V coords repeated trough the width of the trail.")]
	public float uvWidthFactor; // 0xE0
	[Range(0, 1)]
	[Tooltip("When the texture mode is set to 'Tile', defines where to begin tiling from: 0 means the start of the trail, 1 means the end.")]
	public float tileAnchor; // 0xE4
	[CompilerGenerated]
	private Action onUpdatePoints; // 0xE8
	[HideInInspector]
	public ElasticArray<AraTrail.Point> points; // 0xF0
	private ElasticArray<AraTrail.Point> renderablePoints; // 0xF8
	private List<int> discontinuities; // 0x100
	private Mesh mesh_; // 0x108
	private Vector3 velocity; // 0x110
	private Vector3 prevPosition; // 0x11C
	private float accumTime; // 0x128
	private List<Vector3> vertices; // 0x130
	private List<Vector3> normals; // 0x138
	private List<Vector4> tangents; // 0x140
	private List<Vector4> uvs; // 0x148
	private List<Color> vertColors; // 0x150
	private List<int> tris; // 0x158
	private Vector3 nextV; // 0x160
	private Vector3 prevV; // 0x16C
	private Vector3 vertex; // 0x178
	private Vector3 normal; // 0x184
	private Vector3 bitangent; // 0x190
	private Vector4 tangent; // 0x19C
	private Vector4 texTangent; // 0x1AC
	private Vector4 uv; // 0x1BC
	private Color color; // 0x1CC
	private Action<ScriptableRenderContext, Camera> renderCallback; // 0x1E0

	// Properties
	public Vector3 Velocity { get; }
	private float DeltaTime { get; }
	private float FixedDeltaTime { get; }
	public Mesh mesh { get; }
	public Matrix4x4 worldToTrail { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3BB48B0 Offset: 0x3BB08B0 VA: 0x3BB48B0
	public void add_onUpdatePoints(Action value) { }

	[CompilerGenerated]
	// RVA: 0x3BB494C Offset: 0x3BB094C VA: 0x3BB494C
	public void remove_onUpdatePoints(Action value) { }

	// RVA: 0x3BB49E8 Offset: 0x3BB09E8 VA: 0x3BB49E8
	public Vector3 get_Velocity() { }

	// RVA: 0x3BB49F8 Offset: 0x3BB09F8 VA: 0x3BB49F8
	private float get_DeltaTime() { }

	// RVA: 0x3BB4A14 Offset: 0x3BB0A14 VA: 0x3BB4A14
	private float get_FixedDeltaTime() { }

	// RVA: 0x3BB4A30 Offset: 0x3BB0A30 VA: 0x3BB4A30
	public Mesh get_mesh() { }

	// RVA: 0x3BB4A38 Offset: 0x3BB0A38 VA: 0x3BB4A38
	public Matrix4x4 get_worldToTrail() { }

	// RVA: 0x3BB4B34 Offset: 0x3BB0B34 VA: 0x3BB4B34
	public void OnValidate() { }

	// RVA: 0x3BB4B5C Offset: 0x3BB0B5C VA: 0x3BB4B5C
	public void Awake() { }

	// RVA: 0x3BB4C98 Offset: 0x3BB0C98 VA: 0x3BB4C98
	private void OnEnable() { }

	// RVA: 0x3BB4F28 Offset: 0x3BB0F28 VA: 0x3BB4F28
	private void OnDisable() { }

	// RVA: 0x3BB4DA4 Offset: 0x3BB0DA4 VA: 0x3BB4DA4
	private void AttachToCameraRendering() { }

	// RVA: 0x3BB4F8C Offset: 0x3BB0F8C VA: 0x3BB4F8C
	private void DetachFromCameraRendering() { }

	// RVA: 0x3BB50B4 Offset: 0x3BB10B4 VA: 0x3BB50B4
	public void Clear() { }

	// RVA: 0x3BB5104 Offset: 0x3BB1104 VA: 0x3BB5104
	private void UpdateVelocity() { }

	// RVA: 0x3BB5204 Offset: 0x3BB1204 VA: 0x3BB5204
	private void LateUpdate() { }

	// RVA: 0x3BB526C Offset: 0x3BB126C VA: 0x3BB526C
	private void EmissionStep(float time) { }

	// RVA: 0x3BB4B60 Offset: 0x3BB0B60 VA: 0x3BB4B60
	private void Warmup() { }

	// RVA: 0x3BB5928 Offset: 0x3BB1928 VA: 0x3BB5928
	private void PhysicsStep(float timestep) { }

	// RVA: 0x3BB5AD8 Offset: 0x3BB1AD8 VA: 0x3BB5AD8
	private void FixedUpdate() { }

	// RVA: 0x3BB45DC Offset: 0x3BB05DC VA: 0x3BB45DC
	public void EmitPoint(Vector3 position, bool adjustEnd = True) { }

	// RVA: 0x3BB53FC Offset: 0x3BB13FC VA: 0x3BB53FC
	private void SnapLastPointToTransform() { }

	// RVA: 0x3BB5730 Offset: 0x3BB1730 VA: 0x3BB5730
	private void UpdatePointsLifecycle() { }

	// RVA: 0x3BB5B6C Offset: 0x3BB1B6C VA: 0x3BB5B6C
	private void ClearMeshData() { }

	// RVA: 0x3BB5C54 Offset: 0x3BB1C54 VA: 0x3BB5C54
	private void CommitMeshData() { }

	// RVA: 0x3BB5CE8 Offset: 0x3BB1CE8 VA: 0x3BB5CE8
	private void RenderMesh(Camera cam) { }

	// RVA: 0x3BB5E6C Offset: 0x3BB1E6C VA: 0x3BB5E6C
	private ElasticArray<AraTrail.Point> GetRenderablePoints(int start, int end) { }

	// RVA: 0x3BB6704 Offset: 0x3BB2704 VA: 0x3BB6704
	private AraTrail.CurveFrame InitializeCurveFrame(Vector3 point, Vector3 nextPoint) { }

	// RVA: 0x3BB6970 Offset: 0x3BB2970 VA: 0x3BB6970
	private void UpdateTrailMesh(Camera cam) { }

	// RVA: 0x3BB6C00 Offset: 0x3BB2C00 VA: 0x3BB6C00
	private void UpdateSegmentMesh(int start, int end, Vector3 localCamPosition) { }

	// RVA: 0x3BB781C Offset: 0x3BB381C VA: 0x3BB781C
	private void AppendSection(AraTrail.Point[] data, ref AraTrail.CurveFrame frame, int i, int count, float sectionThickness, float vCoord) { }

	// RVA: 0x3BB7FC8 Offset: 0x3BB3FC8 VA: 0x3BB7FC8
	private void AppendFlatTrail(AraTrail.Point[] data, ref AraTrail.CurveFrame frame, int i, int count, float sectionThickness, float vCoord, ref int va, ref int vb) { }

	// RVA: 0x3BB94F0 Offset: 0x3BB54F0 VA: 0x3BB94F0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3BB9A04 Offset: 0x3BB5A04 VA: 0x3BB9A04
	private void <AttachToCameraRendering>b__85_0(ScriptableRenderContext cntxt, Camera cam) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ElasticArray.<GetEnumerator>d__2<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 22883
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	public ElasticArray<T> <>4__this; // 0x0
	private int <i>5__2; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2A138 Offset: 0x5D26138 VA: 0x5D2A138
	|-ElasticArray.<GetEnumerator>d__2<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x5D2A510 Offset: 0x5D26510 VA: 0x5D2A510
	|-ElasticArray.<GetEnumerator>d__2<AraTrail.Point>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2A178 Offset: 0x5D26178 VA: 0x5D2A178
	|-ElasticArray.<GetEnumerator>d__2<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	|
	|-RVA: 0x5D2A538 Offset: 0x5D26538 VA: 0x5D2A538
	|-ElasticArray.<GetEnumerator>d__2<AraTrail.Point>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2A17C Offset: 0x5D2617C VA: 0x5D2A17C
	|-ElasticArray.<GetEnumerator>d__2<__Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0x5D2A53C Offset: 0x5D2653C VA: 0x5D2A53C
	|-ElasticArray.<GetEnumerator>d__2<AraTrail.Point>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2A398 Offset: 0x5D26398 VA: 0x5D2A398
	|-ElasticArray.<GetEnumerator>d__2<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0x5D2A5D8 Offset: 0x5D265D8 VA: 0x5D2A5D8
	|-ElasticArray.<GetEnumerator>d__2<AraTrail.Point>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2A438 Offset: 0x5D26438 VA: 0x5D2A438
	|-ElasticArray.<GetEnumerator>d__2<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x5D2A5E8 Offset: 0x5D265E8 VA: 0x5D2A5E8
	|-ElasticArray.<GetEnumerator>d__2<AraTrail.Point>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2A46C Offset: 0x5D2646C VA: 0x5D2A46C
	|-ElasticArray.<GetEnumerator>d__2<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x5D2A61C Offset: 0x5D2661C VA: 0x5D2A61C
	|-ElasticArray.<GetEnumerator>d__2<AraTrail.Point>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: Ara
[DefaultMember("Item")]
public class ElasticArray<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 22884
{
	// Fields
	private T[] data; // 0x0
	private int count; // 0x0

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	public T Item { get; set; }
	public T[] Data { get; }

	// Methods

	[IteratorStateMachine(typeof(ElasticArray.<GetEnumerator>d__2<T>))]
	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6051528 Offset: 0x604D528 VA: 0x6051528
	|-ElasticArray<__Il2CppFullySharedGenericType>.GetEnumerator
	|
	|-RVA: 0x6052660 Offset: 0x604E660 VA: 0x6052660
	|-ElasticArray<AraTrail.Point>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60515B4 Offset: 0x604D5B4 VA: 0x60515B4
	|-ElasticArray<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x60526D8 Offset: 0x604E6D8 VA: 0x60526D8
	|-ElasticArray<AraTrail.Point>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60515C8 Offset: 0x604D5C8 VA: 0x60515C8
	|-ElasticArray<__Il2CppFullySharedGenericType>.Add
	|
	|-RVA: 0x60526E8 Offset: 0x604E6E8 VA: 0x60526E8
	|-ElasticArray<AraTrail.Point>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6051718 Offset: 0x604D718 VA: 0x6051718
	|-ElasticArray<__Il2CppFullySharedGenericType>.Clear
	|
	|-RVA: 0x605278C Offset: 0x604E78C VA: 0x605278C
	|-ElasticArray<AraTrail.Point>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6051720 Offset: 0x604D720 VA: 0x6051720
	|-ElasticArray<__Il2CppFullySharedGenericType>.Contains
	|
	|-RVA: 0x6052794 Offset: 0x604E794 VA: 0x6052794
	|-ElasticArray<AraTrail.Point>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60518D0 Offset: 0x604D8D0 VA: 0x60518D0
	|-ElasticArray<__Il2CppFullySharedGenericType>.CopyTo
	|
	|-RVA: 0x60528A8 Offset: 0x604E8A8 VA: 0x60528A8
	|-ElasticArray<AraTrail.Point>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6051964 Offset: 0x604D964 VA: 0x6051964
	|-ElasticArray<__Il2CppFullySharedGenericType>.Remove
	|
	|-RVA: 0x605293C Offset: 0x604E93C VA: 0x605293C
	|-ElasticArray<AraTrail.Point>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6051BF0 Offset: 0x604DBF0 VA: 0x6051BF0
	|-ElasticArray<__Il2CppFullySharedGenericType>.get_Count
	|
	|-RVA: 0x6052AC0 Offset: 0x604EAC0 VA: 0x6052AC0
	|-ElasticArray<AraTrail.Point>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6051BF8 Offset: 0x604DBF8 VA: 0x6051BF8
	|-ElasticArray<__Il2CppFullySharedGenericType>.get_IsReadOnly
	|
	|-RVA: 0x6052AC8 Offset: 0x604EAC8 VA: 0x6052AC8
	|-ElasticArray<AraTrail.Point>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6051C00 Offset: 0x604DC00 VA: 0x6051C00
	|-ElasticArray<__Il2CppFullySharedGenericType>.IndexOf
	|
	|-RVA: 0x6052AD0 Offset: 0x604EAD0 VA: 0x6052AD0
	|-ElasticArray<AraTrail.Point>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6051CC4 Offset: 0x604DCC4 VA: 0x6051CC4
	|-ElasticArray<__Il2CppFullySharedGenericType>.Insert
	|
	|-RVA: 0x6052B2C Offset: 0x604EB2C VA: 0x6052B2C
	|-ElasticArray<AraTrail.Point>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6051F18 Offset: 0x604DF18 VA: 0x6051F18
	|-ElasticArray<__Il2CppFullySharedGenericType>.RemoveAt
	|
	|-RVA: 0x6052C80 Offset: 0x604EC80 VA: 0x6052C80
	|-ElasticArray<AraTrail.Point>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveRange(int index, int num) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6052084 Offset: 0x604E084 VA: 0x6052084
	|-ElasticArray<__Il2CppFullySharedGenericType>.RemoveRange
	|
	|-RVA: 0x6052D40 Offset: 0x604ED40 VA: 0x6052D40
	|-ElasticArray<AraTrail.Point>.RemoveRange
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x605213C Offset: 0x604E13C VA: 0x605213C
	|-ElasticArray<__Il2CppFullySharedGenericType>.get_Item
	|
	|-RVA: 0x6052DE4 Offset: 0x604EDE4 VA: 0x6052DE4
	|-ElasticArray<AraTrail.Point>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x60521F8 Offset: 0x604E1F8 VA: 0x60521F8
	|-ElasticArray<__Il2CppFullySharedGenericType>.set_Item
	|
	|-RVA: 0x6052E20 Offset: 0x604EE20 VA: 0x6052E20
	|-ElasticArray<AraTrail.Point>.set_Item
	*/

	// RVA: -1 Offset: -1
	public T[] get_Data() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x605231C Offset: 0x604E31C VA: 0x605231C
	|-ElasticArray<__Il2CppFullySharedGenericType>.get_Data
	|
	|-RVA: 0x6052E98 Offset: 0x604EE98 VA: 0x6052E98
	|-ElasticArray<AraTrail.Point>.get_Data
	*/

	// RVA: -1 Offset: -1
	public void SetCount(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6052324 Offset: 0x604E324 VA: 0x6052324
	|-ElasticArray<__Il2CppFullySharedGenericType>.SetCount
	|
	|-RVA: 0x6052EA0 Offset: 0x604EEA0 VA: 0x6052EA0
	|-ElasticArray<AraTrail.Point>.SetCount
	*/

	// RVA: -1 Offset: -1
	public void EnsureCapacity(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6052358 Offset: 0x604E358 VA: 0x6052358
	|-ElasticArray<__Il2CppFullySharedGenericType>.EnsureCapacity
	|
	|-RVA: 0x6052ED0 Offset: 0x604EED0 VA: 0x6052ED0
	|-ElasticArray<AraTrail.Point>.EnsureCapacity
	*/

	// RVA: -1 Offset: -1
	public void Reverse() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6052398 Offset: 0x604E398 VA: 0x6052398
	|-ElasticArray<__Il2CppFullySharedGenericType>.Reverse
	|
	|-RVA: 0x6052F0C Offset: 0x604EF0C VA: 0x6052F0C
	|-ElasticArray<AraTrail.Point>.Reverse
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x605260C Offset: 0x604E60C VA: 0x605260C
	|-ElasticArray<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x6053020 Offset: 0x604F020 VA: 0x6053020
	|-ElasticArray<AraTrail.Point>..ctor
	*/
}

// Namespace: Ara
[RequireComponent(typeof(AraTrail))]
public class ColorFromSpeed : MonoBehaviour // TypeDefIndex: 22885
{
	// Fields
	private AraTrail trail; // 0x20
	[Tooltip("Maps trail speed to color. Control how much speed is transferred to the trail by setting inertia > 0. The trail will be colorized even if physics are disabled. ")]
	public Gradient colorFromSpeed; // 0x28
	[Tooltip("Min speed used to map speed to color.")]
	public float minSpeed; // 0x30
	[Tooltip("Max speed used to map speed to color.")]
	public float maxSpeed; // 0x34

	// Methods

	// RVA: 0x3BB9BD4 Offset: 0x3BB5BD4 VA: 0x3BB9BD4
	private void OnEnable() { }

	// RVA: 0x3BB9C94 Offset: 0x3BB5C94 VA: 0x3BB9C94
	private void OnDisable() { }

	// RVA: 0x3BB9D20 Offset: 0x3BB5D20 VA: 0x3BB9D20
	private void SetColorFromSpeed() { }

	// RVA: 0x3BB9F24 Offset: 0x3BB5F24 VA: 0x3BB9F24
	public void .ctor() { }
}

// Namespace: Ara
[RequireComponent(typeof(AraTrail))]
public class ElectricalArc : MonoBehaviour // TypeDefIndex: 22886
{
	// Fields
	private AraTrail trail; // 0x20
	public Transform source; // 0x28
	public Transform target; // 0x30
	public int points; // 0x38
	public float burstInterval; // 0x3C
	public float burstRandom; // 0x40
	public float speedRandom; // 0x44
	public float positionRandom; // 0x48
	private float accum; // 0x4C

	// Methods

	// RVA: 0x3BB9F98 Offset: 0x3BB5F98 VA: 0x3BB9F98
	private void OnEnable() { }

	// RVA: 0x3BBA004 Offset: 0x3BB6004 VA: 0x3BBA004
	private void Update() { }

	// RVA: 0x3BBA064 Offset: 0x3BB6064 VA: 0x3BBA064
	private void ChangeArc() { }

	// RVA: 0x3BBA3D4 Offset: 0x3BB63D4 VA: 0x3BBA3D4
	public void .ctor() { }
}

// Namespace: Ara
[RequireComponent(typeof(AraTrail))]
public class TireTrack : MonoBehaviour // TypeDefIndex: 22887
{
	// Fields
	private AraTrail trail; // 0x20
	public float offset; // 0x28
	public float maxDist; // 0x2C

	// Methods

	// RVA: 0x3BBA3F0 Offset: 0x3BB63F0 VA: 0x3BBA3F0
	private void OnEnable() { }

	// RVA: 0x3BBA4B0 Offset: 0x3BB64B0 VA: 0x3BBA4B0
	private void OnDisable() { }

	// RVA: 0x3BBA53C Offset: 0x3BB653C VA: 0x3BBA53C
	private void ProjectToGround() { }

	// RVA: 0x3BBA8B8 Offset: 0x3BB68B8 VA: 0x3BBA8B8
	public void .ctor() { }
}

// Namespace: Ara
[CreateAssetMenu(menuName = "Ara Trails/Trail Section")]
public class TrailSection : ScriptableObject // TypeDefIndex: 22888
{
	// Fields
	[HideInInspector]
	public List<Vector2> vertices; // 0x18
	public int snapX; // 0x20
	public int snapY; // 0x24

	// Properties
	public int Segments { get; }

	// Methods

	// RVA: 0x3BB94A4 Offset: 0x3BB54A4 VA: 0x3BB94A4
	public int get_Segments() { }

	// RVA: 0x3BBA8CC Offset: 0x3BB68CC VA: 0x3BBA8CC
	public void OnEnable() { }

	// RVA: 0x3BBA964 Offset: 0x3BB6964 VA: 0x3BBA964
	public void CirclePreset(int segments) { }

	// RVA: 0x3BBAB10 Offset: 0x3BB6B10 VA: 0x3BBAB10
	public static int SnapTo(float val, int snapInterval, int threshold) { }

	// RVA: 0x3BBABE4 Offset: 0x3BB6BE4 VA: 0x3BBABE4
	public void .ctor() { }
}

// Namespace: OptimizeTool
public class FastCloneAndCopy : MonoBehaviour // TypeDefIndex: 22889
{
	// Fields
	public List<GameObject> goParent; // 0x20
	public GameObject overridePrefab; // 0x28

	// Methods

	[ContextMenu("FastCloneAndCopy")]
	// RVA: 0x3BBABEC Offset: 0x3BB6BEC VA: 0x3BBABEC
	private void DoFastClone() { }

	// RVA: 0x3BBAFC4 Offset: 0x3BB6FC4 VA: 0x3BBAFC4
	public void .ctor() { }
}

// Namespace: OptimizeTool.Baker
[RequireComponent(typeof(Renderer))]
[DisallowMultipleComponent]
public class AdditiveTintOverride : MonoBehaviour // TypeDefIndex: 22890
{
	// Fields
	[ColorUsage(True, True)]
	public Color additiveTint; // 0x20

	// Methods

	// RVA: 0x3BBAFCC Offset: 0x3BB6FCC VA: 0x3BBAFCC
	public void .ctor() { }
}

// Namespace: OptimizeTool.Baker
public static class AdditiveTintHelper // TypeDefIndex: 22891
{
	// Methods

	// RVA: 0x3BBAFDC Offset: 0x3BB6FDC VA: 0x3BBAFDC
	public static Color GetRendererTint(Renderer renderer, Color fallback) { }
}

// Namespace: OptimizeTool.Baker
[ExecuteAlways]
public class AnimationSequenceBacker : ParticleSequenceBaker // TypeDefIndex: 22892
{
	// Methods

	// RVA: 0x3BBB0FC Offset: 0x3BB70FC VA: 0x3BBB0FC
	public void .ctor() { }
}

// Namespace: OptimizeTool.Baker
[ExecuteAlways]
[DisallowMultipleComponent]
public class BakerManager : MonoBehaviour // TypeDefIndex: 22893
{
	// Methods

	// RVA: 0x3BBB10C Offset: 0x3BB710C VA: 0x3BBB10C
	public void .ctor() { }
}

// Namespace: OptimizeTool.Baker
public struct BakerOverlayInfo // TypeDefIndex: 22894
{
	// Fields
	public Bounds Bounds; // 0x0
	public Vector2 WorldSize; // 0x18
	public Vector3 WorldCenter; // 0x20
	public CaptureAxis Axis; // 0x2C
	public int TargetWidth; // 0x30
	public int TargetHeight; // 0x34
}

// Namespace: OptimizeTool.Baker
public abstract class BaseBaker : MonoBehaviour // TypeDefIndex: 22895
{
	// Methods

	// RVA: 0x3BBB114 Offset: 0x3BB7114 VA: 0x3BBB114
	protected void .ctor() { }
}

// Namespace: OptimizeTool.Baker
public struct CaptureSettings // TypeDefIndex: 22896
{
	// Fields
	public float PaddingPercent; // 0x0
	public Color Background; // 0x4
	public int AntiAliasing; // 0x14
	public ParticleSequenceCaptureMode CaptureMode; // 0x18
	public bool SkipObjectsWithAnimators; // 0x1C
	public bool SkipDisabledObjects; // 0x1D
	public bool CombineFromSubobjects; // 0x1E
	public Transform[] CombineFromSpecificObjects; // 0x20
	public float PixelsPerUnit; // 0x28
	public CaptureAxis Axis; // 0x2C
	public int MaxTextureSize; // 0x30
	public Color AdditiveTint; // 0x34
}

// Namespace: OptimizeTool.Baker
public enum CaptureAxis // TypeDefIndex: 22897
{
	// Fields
	public int value__; // 0x0
	public const CaptureAxis XY = 0;
	public const CaptureAxis XZ = 1;
}

// Namespace: OptimizeTool.Baker
public static class ColorModeUtil // TypeDefIndex: 22898
{
	// Methods

	// RVA: 0x3BBB11C Offset: 0x3BB711C VA: 0x3BBB11C
	public static bool RendererUsesAdditive(Renderer renderer) { }

	// RVA: 0x3BBB360 Offset: 0x3BB7360 VA: 0x3BBB360
	public static bool RendererUsesAlphaBlend(Renderer renderer) { }
}

// Namespace: OptimizeTool.Baker
public static class AdditiveCaptureUtil // TypeDefIndex: 22899
{
	// Methods

	// RVA: 0x3BBB5A4 Offset: 0x3BB75A4 VA: 0x3BBB5A4
	public static RenderTexture ConvertAdditiveBlackToAlphaRT_CPU(RenderTexture srcRT, float strength = 1) { }
}

// Namespace: OptimizeTool.Baker
public enum ParticleSequenceCaptureMode // TypeDefIndex: 22900
{
	// Fields
	public int value__; // 0x0
	public const ParticleSequenceCaptureMode BlackWhite = 0;
	public const ParticleSequenceCaptureMode AdditiveBlackToAlpha = 1;
	public const ParticleSequenceCaptureMode TransparentBackground = 2;
	public const ParticleSequenceCaptureMode LegacyPerRenderer = 3;
	public const ParticleSequenceCaptureMode OrderedPerRenderer = 4;
}

// Namespace: OptimizeTool.Baker
[ExecuteAlways]
public class ParticleSequenceBaker : BaseBaker // TypeDefIndex: 22901
{
	// Methods

	// RVA: 0x3BBB104 Offset: 0x3BB7104 VA: 0x3BBB104
	public void .ctor() { }
}

// Namespace: OptimizeTool.Baker
public static class PixelComposite // TypeDefIndex: 22902
{
	// Methods

	// RVA: 0x3BBBCB8 Offset: 0x3BB7CB8 VA: 0x3BBBCB8
	public static void CompositeAlpha(Color32[] src, Color32[] dst) { }

	// RVA: 0x3BBBDFC Offset: 0x3BB7DFC VA: 0x3BBBDFC
	public static void CompositePremultiplied(Color32[] src, Color32[] dst) { }

	// RVA: 0x3BBBF18 Offset: 0x3BB7F18 VA: 0x3BBBF18
	public static void CompositeAdditive(Color32[] src, Color32[] dst, bool useSrcAlpha = True) { }
}

// Namespace: OptimizeTool.Baker
public static class RendererSortUtil // TypeDefIndex: 22903
{
	// Fields
	private static readonly List<Transform> _tmpA; // 0x0
	private static readonly List<Transform> _tmpB; // 0x8

	// Methods

	// RVA: 0x3BBC040 Offset: 0x3BB8040 VA: 0x3BBC040
	public static int CompareByRenderOrder(Renderer a, Renderer b) { }

	// RVA: 0x3BBC228 Offset: 0x3BB8228 VA: 0x3BBC228
	private static int GetRenderQueue(Renderer r) { }

	// RVA: 0x3BBC2E0 Offset: 0x3BB82E0 VA: 0x3BBC2E0
	private static void GetEffectiveSorting(Renderer r, out int layerId, out int order) { }

	// RVA: 0x3BBC4D8 Offset: 0x3BB84D8 VA: 0x3BBC4D8
	private static int CompareHierarchy(Transform a, Transform b) { }

	// RVA: 0x3BBC8A8 Offset: 0x3BB88A8 VA: 0x3BBC8A8
	private static void .cctor() { }
}

// Namespace: OptimizeTool.Baker
public class SimpleSpriteCombine : MonoBehaviour // TypeDefIndex: 22904
{
	// Methods

	// RVA: 0x3BBC970 Offset: 0x3BB8970 VA: 0x3BBC970
	public void .ctor() { }
}

// Namespace: OptimizeTool.Baker
[DisallowMultipleComponent]
public class SpriteAtlasOrganizer : MonoBehaviour // TypeDefIndex: 22905
{
	// Methods

	// RVA: 0x3BBC978 Offset: 0x3BB8978 VA: 0x3BBC978
	public void .ctor() { }
}

// Namespace: Facebook.Unity.Example
internal class ConsoleBase : MonoBehaviour // TypeDefIndex: 22906
{
	// Fields
	private const int DpiScalingFactor = 160;
	private static Stack<string> menuStack; // 0x0
	private string status; // 0x20
	private string lastResponse; // 0x28
	private Vector2 scrollPosition; // 0x30
	private Nullable<float> scaleFactor; // 0x38
	private GUIStyle textStyle; // 0x40
	private GUIStyle buttonStyle; // 0x48
	private GUIStyle textInputStyle; // 0x50
	private GUIStyle labelStyle; // 0x58
	[CompilerGenerated]
	private Texture2D <LastResponseTexture>k__BackingField; // 0x60

	// Properties
	protected static int ButtonHeight { get; }
	protected static int MainWindowWidth { get; }
	protected static int MainWindowFullWidth { get; }
	protected static int MarginFix { get; }
	protected static Stack<string> MenuStack { get; set; }
	protected string Status { get; set; }
	protected Texture2D LastResponseTexture { get; set; }
	protected string LastResponse { get; set; }
	protected Vector2 ScrollPosition { get; set; }
	protected float ScaleFactor { get; }
	protected int FontSize { get; }
	protected GUIStyle TextStyle { get; }
	protected GUIStyle ButtonStyle { get; }
	protected GUIStyle TextInputStyle { get; }
	protected GUIStyle LabelStyle { get; }

	// Methods

	// RVA: 0x3BBC980 Offset: 0x3BB8980 VA: 0x3BBC980
	protected static int get_ButtonHeight() { }

	// RVA: 0x3BBC9A4 Offset: 0x3BB89A4 VA: 0x3BBC9A4
	protected static int get_MainWindowWidth() { }

	// RVA: 0x3BBC9D0 Offset: 0x3BB89D0 VA: 0x3BBC9D0
	protected static int get_MainWindowFullWidth() { }

	// RVA: 0x3BBC9F8 Offset: 0x3BB89F8 VA: 0x3BBC9F8
	protected static int get_MarginFix() { }

	// RVA: 0x3BBCA18 Offset: 0x3BB8A18 VA: 0x3BBCA18
	protected static Stack<string> get_MenuStack() { }

	// RVA: 0x3BBCA70 Offset: 0x3BB8A70 VA: 0x3BBCA70
	protected static void set_MenuStack(Stack<string> value) { }

	// RVA: 0x3BBCAD8 Offset: 0x3BB8AD8 VA: 0x3BBCAD8
	protected string get_Status() { }

	// RVA: 0x3BBCAE0 Offset: 0x3BB8AE0 VA: 0x3BBCAE0
	protected void set_Status(string value) { }

	[CompilerGenerated]
	// RVA: 0x3BBCAE8 Offset: 0x3BB8AE8 VA: 0x3BBCAE8
	protected Texture2D get_LastResponseTexture() { }

	[CompilerGenerated]
	// RVA: 0x3BBCAF0 Offset: 0x3BB8AF0 VA: 0x3BBCAF0
	protected void set_LastResponseTexture(Texture2D value) { }

	// RVA: 0x3BBCAF8 Offset: 0x3BB8AF8 VA: 0x3BBCAF8
	protected string get_LastResponse() { }

	// RVA: 0x3BBCB00 Offset: 0x3BB8B00 VA: 0x3BBCB00
	protected void set_LastResponse(string value) { }

	// RVA: 0x3BBCB08 Offset: 0x3BB8B08 VA: 0x3BBCB08
	protected Vector2 get_ScrollPosition() { }

	// RVA: 0x3BBCB10 Offset: 0x3BB8B10 VA: 0x3BBCB10
	protected void set_ScrollPosition(Vector2 value) { }

	// RVA: 0x3BBCB18 Offset: 0x3BB8B18 VA: 0x3BBCB18
	protected float get_ScaleFactor() { }

	// RVA: 0x3BBCBB8 Offset: 0x3BB8BB8 VA: 0x3BBCBB8
	protected int get_FontSize() { }

	// RVA: 0x3BBCCB0 Offset: 0x3BB8CB0 VA: 0x3BBCCB0
	protected GUIStyle get_TextStyle() { }

	// RVA: 0x3BBCE34 Offset: 0x3BB8E34 VA: 0x3BBCE34
	protected GUIStyle get_ButtonStyle() { }

	// RVA: 0x3BBCF18 Offset: 0x3BB8F18 VA: 0x3BBCF18
	protected GUIStyle get_TextInputStyle() { }

	// RVA: 0x3BBCFFC Offset: 0x3BB8FFC VA: 0x3BBCFFC
	protected GUIStyle get_LabelStyle() { }

	// RVA: 0x3BBD0E0 Offset: 0x3BB90E0 VA: 0x3BBD0E0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x3BBD134 Offset: 0x3BB9134 VA: 0x3BBD134
	protected bool Button(string label) { }

	// RVA: 0x3BBD27C Offset: 0x3BB927C VA: 0x3BBD27C
	protected void LabelAndTextField(string label, ref string text) { }

	// RVA: 0x3BBD474 Offset: 0x3BB9474 VA: 0x3BBD474
	protected bool IsHorizontalLayout() { }

	// RVA: 0x3BBD490 Offset: 0x3BB9490 VA: 0x3BBD490
	protected void SwitchMenu(Type menuClass) { }

	// RVA: 0x3BBD590 Offset: 0x3BB9590 VA: 0x3BBD590
	protected void GoBack() { }

	// RVA: 0x3BBD688 Offset: 0x3BB9688 VA: 0x3BBD688
	public void .ctor() { }

	// RVA: 0x3BBD74C Offset: 0x3BB974C VA: 0x3BBD74C
	private static void .cctor() { }
}

// Namespace: Facebook.Unity.Example
internal class LogView : ConsoleBase // TypeDefIndex: 22907
{
	// Fields
	private static string datePatt; // 0x0
	private static IList<string> events; // 0x8

	// Methods

	// RVA: 0x3BBD7E4 Offset: 0x3BB97E4 VA: 0x3BBD7E4
	public static void AddLog(string log) { }

	// RVA: 0x3BBD944 Offset: 0x3BB9944 VA: 0x3BBD944
	protected void OnGUI() { }

	// RVA: 0x3BBDCB0 Offset: 0x3BB9CB0 VA: 0x3BBDCB0
	public void .ctor() { }

	// RVA: 0x3BBDD04 Offset: 0x3BB9D04 VA: 0x3BBDD04
	private static void .cctor() { }
}

// Namespace: Facebook.Unity.Example
internal abstract class MenuBase : ConsoleBase // TypeDefIndex: 22908
{
	// Fields
	private static ShareDialogMode shareDialogMode; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void GetGui();

	// RVA: 0x3BBDDC8 Offset: 0x3BB9DC8 VA: 0x3BBDDC8 Slot: 6
	protected virtual bool ShowDialogModeSelector() { }

	// RVA: 0x3BBDDD0 Offset: 0x3BB9DD0 VA: 0x3BBDDD0 Slot: 7
	protected virtual bool ShowBackButton() { }

	// RVA: 0x3BBDDD8 Offset: 0x3BB9DD8 VA: 0x3BBDDD8
	protected void HandleResult(IResult result) { }

	// RVA: 0x3BBE1E0 Offset: 0x3BBA1E0 VA: 0x3BBE1E0
	protected void HandleLimitedLoginResult(IResult result) { }

	// RVA: 0x3BBE8F0 Offset: 0x3BBA8F0 VA: 0x3BBE8F0
	protected void OnGUI() { }

	// RVA: 0x3BBEDDC Offset: 0x3BBADDC VA: 0x3BBEDDC
	private void AddStatus() { }

	// RVA: 0x3BBEF04 Offset: 0x3BBAF04 VA: 0x3BBEF04
	private void AddBackButton() { }

	// RVA: 0x3BBF02C Offset: 0x3BBB02C VA: 0x3BBF02C
	private void AddLogButton() { }

	// RVA: 0x3BBF0D8 Offset: 0x3BBB0D8 VA: 0x3BBF0D8
	private void AddDialogModeButtons() { }

	// RVA: 0x3BBF484 Offset: 0x3BBB484 VA: 0x3BBF484
	private void AddDialogModeButton(ShareDialogMode mode) { }

	// RVA: 0x3BBF5C8 Offset: 0x3BBB5C8 VA: 0x3BBF5C8
	protected void .ctor() { }
}

// Namespace: Facebook.Unity.Example
internal class AccessTokenMenu : MenuBase // TypeDefIndex: 22909
{
	// Methods

	// RVA: 0x3BBF61C Offset: 0x3BBB61C VA: 0x3BBF61C Slot: 5
	protected override void GetGui() { }

	// RVA: 0x3BBF6C4 Offset: 0x3BBB6C4 VA: 0x3BBF6C4
	public void .ctor() { }
}

// Namespace: Facebook.Unity.Example
internal class AppEvents : MenuBase // TypeDefIndex: 22910
{
	// Methods

	// RVA: 0x3BBF6C8 Offset: 0x3BBB6C8 VA: 0x3BBF6C8 Slot: 5
	protected override void GetGui() { }

	// RVA: 0x3BBF8B4 Offset: 0x3BBB8B4 VA: 0x3BBF8B4
	public void .ctor() { }
}

// Namespace: Facebook.Unity.Example
internal class AppLinks : MenuBase // TypeDefIndex: 22911
{
	// Methods

	// RVA: 0x3BBF8B8 Offset: 0x3BBB8B8 VA: 0x3BBF8B8 Slot: 5
	protected override void GetGui() { }

	// RVA: 0x3BBF9E8 Offset: 0x3BBB9E8 VA: 0x3BBF9E8
	public void .ctor() { }
}

// Namespace: Facebook.Unity.Example
internal class AppRequests : MenuBase // TypeDefIndex: 22912
{
	// Fields
	private string requestMessage; // 0x68
	private string requestTo; // 0x70
	private string requestFilter; // 0x78
	private string requestExcludes; // 0x80
	private string requestMax; // 0x88
	private string requestData; // 0x90
	private string requestTitle; // 0x98
	private string requestObjectID; // 0xA0
	private int selectedAction; // 0xA8
	private string[] actionTypeStrings; // 0xB0

	// Methods

	// RVA: 0x3BBF9EC Offset: 0x3BBB9EC VA: 0x3BBF9EC Slot: 5
	protected override void GetGui() { }

	// RVA: 0x3BC03D0 Offset: 0x3BBC3D0 VA: 0x3BC03D0
	private Nullable<OGActionType> GetSelectedOGActionType() { }

	// RVA: 0x3BC0518 Offset: 0x3BBC518 VA: 0x3BC0518
	public void .ctor() { }
}

// Namespace: Facebook.Unity.Example
internal class DialogShare : MenuBase // TypeDefIndex: 22913
{
	// Fields
	private string shareLink; // 0x68
	private string shareTitle; // 0x70
	private string shareDescription; // 0x78
	private string shareImage; // 0x80
	private string feedTo; // 0x88
	private string feedLink; // 0x90
	private string feedTitle; // 0x98
	private string feedCaption; // 0xA0
	private string feedDescription; // 0xA8
	private string feedImage; // 0xB0
	private string feedMediaSource; // 0xB8

	// Methods

	// RVA: 0x3BC0768 Offset: 0x3BBC768 VA: 0x3BC0768 Slot: 6
	protected override bool ShowDialogModeSelector() { }

	// RVA: 0x3BC0770 Offset: 0x3BBC770 VA: 0x3BC0770 Slot: 5
	protected override void GetGui() { }

	// RVA: 0x3BC0F1C Offset: 0x3BBCF1C VA: 0x3BC0F1C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GraphRequest.<TakeScreenshot>d__4 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 22914
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public GraphRequest <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3BC16B4 Offset: 0x3BBD6B4 VA: 0x3BC16B4
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3BC1738 Offset: 0x3BBD738 VA: 0x3BC1738 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x3BC173C Offset: 0x3BBD73C VA: 0x3BC173C Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3BC19B8 Offset: 0x3BBD9B8 VA: 0x3BC19B8 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x3BC19C0 Offset: 0x3BBD9C0 VA: 0x3BC19C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3BC19F8 Offset: 0x3BBD9F8 VA: 0x3BC19F8 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Facebook.Unity.Example
internal class GraphRequest : MenuBase // TypeDefIndex: 22915
{
	// Fields
	private string apiQuery; // 0x68
	private Texture2D profilePic; // 0x70

	// Methods

	// RVA: 0x3BC10E0 Offset: 0x3BBD0E0 VA: 0x3BC10E0 Slot: 5
	protected override void GetGui() { }

	// RVA: 0x3BC14E0 Offset: 0x3BBD4E0 VA: 0x3BC14E0
	private void ProfilePhotoCallback(IGraphResult result) { }

	[IteratorStateMachine(typeof(GraphRequest.<TakeScreenshot>d__4))]
	// RVA: 0x3BC1474 Offset: 0x3BBD474 VA: 0x3BC1474
	private IEnumerator TakeScreenshot() { }

	// RVA: 0x3BC16DC Offset: 0x3BBD6DC VA: 0x3BC16DC
	public void .ctor() { }
}

// Namespace: Facebook.Unity.Example
internal class IAP : MenuBase // TypeDefIndex: 22916
{
	// Methods

	// RVA: 0x3BC1A00 Offset: 0x3BBDA00 VA: 0x3BC1A00 Slot: 5
	protected override void GetGui() { }

	// RVA: 0x3BC1A04 Offset: 0x3BBDA04 VA: 0x3BC1A04
	public void .ctor() { }
}

// Namespace: 
private enum MainMenu.Scope // TypeDefIndex: 22917
{
	// Fields
	public int value__; // 0x0
	public const MainMenu.Scope PublicProfile = 1;
	public const MainMenu.Scope UserFriends = 2;
	public const MainMenu.Scope UserBirthday = 3;
	public const MainMenu.Scope UserAgeRange = 4;
	public const MainMenu.Scope PublishActions = 5;
	public const MainMenu.Scope UserLocation = 6;
	public const MainMenu.Scope UserHometown = 7;
	public const MainMenu.Scope UserGender = 8;
}

// Namespace: Facebook.Unity.Example
internal sealed class MainMenu : MenuBase // TypeDefIndex: 22918
{
	// Methods

	// RVA: 0x3BC1A08 Offset: 0x3BBDA08 VA: 0x3BC1A08 Slot: 7
	protected override bool ShowBackButton() { }

	// RVA: 0x3BC1A10 Offset: 0x3BBDA10 VA: 0x3BC1A10 Slot: 5
	protected override void GetGui() { }

	// RVA: 0x3BC2A7C Offset: 0x3BBEA7C VA: 0x3BC2A7C
	private void CallFBLogin(LoginTracking mode, HashSet<MainMenu.Scope> scope) { }

	// RVA: 0x3BC3098 Offset: 0x3BBF098 VA: 0x3BC3098
	private void CallFBLoginForPublish() { }

	// RVA: 0x3BC3204 Offset: 0x3BBF204 VA: 0x3BC3204
	private void CallFBLogout() { }

	// RVA: 0x3BC3254 Offset: 0x3BBF254 VA: 0x3BC3254
	private void OnInitComplete() { }

	// RVA: 0x3BC3418 Offset: 0x3BBF418 VA: 0x3BC3418
	private void OnHideUnity(bool isGameShown) { }

	// RVA: 0x3BC3554 Offset: 0x3BBF554 VA: 0x3BC3554
	public void .ctor() { }
}

// Namespace: Facebook.Unity.Example
internal class Pay : MenuBase // TypeDefIndex: 22919
{
	// Fields
	private string payProduct; // 0x68

	// Methods

	// RVA: 0x3BC3558 Offset: 0x3BBF558 VA: 0x3BC3558 Slot: 5
	protected override void GetGui() { }

	// RVA: 0x3BC35EC Offset: 0x3BBF5EC VA: 0x3BC35EC
	private void CallFBPay() { }

	// RVA: 0x3BC36AC Offset: 0x3BBF6AC VA: 0x3BC36AC
	public void .ctor() { }
}

// Namespace: Facebook.Unity.Example
internal class Subscription : MenuBase // TypeDefIndex: 22920
{
	// Fields
	private string subscriptionProductId; // 0x68
	private string cancelSubscriptionProductId; // 0x70

	// Methods

	// RVA: 0x3BC370C Offset: 0x3BBF70C VA: 0x3BC370C Slot: 5
	protected override void GetGui() { }

	// RVA: 0x3BC387C Offset: 0x3BBF87C VA: 0x3BC387C
	private void CallGetSubscribableCatalog() { }

	// RVA: 0x3BC3920 Offset: 0x3BBF920 VA: 0x3BC3920
	private void CallPurchaseSubscription() { }

	// RVA: 0x3BC39CC Offset: 0x3BBF9CC VA: 0x3BC39CC
	private void CallGetSubscriptions() { }

	// RVA: 0x3BC3A70 Offset: 0x3BBFA70 VA: 0x3BC3A70
	private void CallCancelSubscription() { }

	// RVA: 0x3BC3B1C Offset: 0x3BBFB1C VA: 0x3BC3B1C
	public void .ctor() { }
}

// Namespace: Facebook.Unity.Example
internal class TournamentsMenu : MenuBase // TypeDefIndex: 22921
{
	// Fields
	private string score; // 0x68
	private string tournamentID; // 0x70

	// Methods

	// RVA: 0x3BC3B94 Offset: 0x3BBFB94 VA: 0x3BC3B94 Slot: 5
	protected override void GetGui() { }

	// RVA: 0x3BC3F60 Offset: 0x3BBFF60 VA: 0x3BC3F60
	private void GetTournamentsHandleResult(IGetTournamentsResult result) { }

	// RVA: 0x3BC42EC Offset: 0x3BC02EC VA: 0x3BC42EC
	public void .ctor() { }
}

// Namespace: Facebook.Unity.Example
internal class UploadToMediaLibrary : MenuBase // TypeDefIndex: 22922
{
	// Fields
	private bool imageShouldLaunchMediaDialog; // 0x68
	private string imageCaption; // 0x70
	private string imageFile; // 0x78
	private bool videoShouldLaunchMediaDialog; // 0x80
	private string videoCaption; // 0x88
	private string videoFile; // 0x90

	// Methods

	// RVA: 0x3BC4364 Offset: 0x3BC0364 VA: 0x3BC4364 Slot: 5
	protected override void GetGui() { }

	// RVA: 0x3BC4854 Offset: 0x3BC0854 VA: 0x3BC4854
	private string GetPath(string filename) { }

	// RVA: 0x3BC49B0 Offset: 0x3BC09B0 VA: 0x3BC49B0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class AssetAuditData.Node // TypeDefIndex: 22923
{
	// Fields
	[Header("Name Setting")]
	public string m_name; // 0x10
	[Header("Data")]
	[Label]
	public ImporterType m_importerType; // 0x18
	[Label]
	public string m_guid; // 0x20
	[Label]
	public string m_parameter; // 0x28
	[Header("Path Setting")]
	public List<string> m_paths; // 0x30
	public List<string> m_ignorePaths; // 0x38

	// Methods

	// RVA: 0x3BC4B18 Offset: 0x3BC0B18 VA: 0x3BC4B18
	public void SetName(string name) { }

	// RVA: 0x3BC4B20 Offset: 0x3BC0B20 VA: 0x3BC4B20
	public void SetImporterType(ImporterType importerType) { }

	// RVA: 0x3BC4B28 Offset: 0x3BC0B28 VA: 0x3BC4B28
	public void SetGUID(string guid) { }

	// RVA: 0x3BC4B30 Offset: 0x3BC0B30 VA: 0x3BC4B30
	public void .ctor() { }
}

// Namespace: UnityEngine.AssetAudit
[CreateAssetMenu]
public class AssetAuditData : ScriptableObject // TypeDefIndex: 22924
{
	// Fields
	public List<AssetAuditData.Node> m_nodes; // 0x18

	// Methods

	// RVA: 0x3BC4A90 Offset: 0x3BC0A90 VA: 0x3BC4A90
	public void .ctor() { }
}

// Namespace: UnityEngine.AssetAudit
public enum ImporterType // TypeDefIndex: 22925
{
	// Fields
	public int value__; // 0x0
	public const ImporterType Texture = 0;
	public const ImporterType Model = 1;
	public const ImporterType Audio = 2;
	public const ImporterType Font = 3;
	public const ImporterType Video = 4;
	public const ImporterType Shader = 5;
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 // TypeDefIndex: 22926
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 // TypeDefIndex: 22927
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 // TypeDefIndex: 22928
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10036 // TypeDefIndex: 22929
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=21347 // TypeDefIndex: 22930
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 22931
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 4F6ADDC9659D6FB90FE94B6688A79F2A1FA8D36EC43F8F3E1D9B6528C448A384 /*Metadata offset 0xF171B0*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10036 6182FBDFD252F13BC258DFC93EDDF992428E12DC0C520B71BFBC371F4BFBBC94 /*Metadata offset 0xF171C8*/; // 0x14
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 8D37C81B9A47C1B878313F8A5FA9A3F69ED9EB4DFCB83E949037E3FA5B4F9EB3 /*Metadata offset 0xF19900*/; // 0x2748
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 90F8B9CA427929CB3B8BEA56E4FFD009721F38BB0ED6C6403EFC5D644474C3EC /*Metadata offset 0xF19938*/; // 0x2778
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=21347 FCE68D57935FEC59BC63688B3F7925098AAA70221120A2757A4D40A3C70A116D /*Metadata offset 0xF19950*/; // 0x2788
}


package cn.thinkingdata.analytics;

import android.app.Activity;
import android.app.Application;
import android.app.Dialog;
import android.app.Fragment;
import android.content.Context;
import android.os.Looper;
import android.os.SystemClock;
import android.text.TextUtils;
import android.util.Pair;
import android.view.View;
import android.webkit.WebView;
import cn.thinkingdata.analytics.aop.push.TAPushUtils;
import cn.thinkingdata.analytics.h.q;
import cn.thinkingdata.analytics.utils.broadcast.TDReceiver;
import cn.thinkingdata.core.preset.TDPresetUtils;
import cn.thinkingdata.core.receiver.TDAnalyticsObservable;
import cn.thinkingdata.core.router.TRouter;
import cn.thinkingdata.core.router.TRouterMap;
import cn.thinkingdata.core.router.provider.callback.ISensitivePropertiesCallBack;
import cn.thinkingdata.core.utils.TDLog;
import com.alipay.sdk.app.AlipayApi;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Date;
import java.util.HashMap;
import java.util.Iterator;
import java.util.LinkedList;
import java.util.List;
import java.util.Locale;
import java.util.Map;
import java.util.TimeZone;
import java.util.concurrent.TimeUnit;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class ThinkingAnalyticsSDK implements cn.thinkingdata.analytics.a {
    static final String TAG = "ThinkingAnalyticsSDK";
    protected String _statusAccountId;
    protected String _statusIdentifyId;
    protected TATrackStatus _statusTrackStatus;
    private boolean mAutoTrack;
    public AutoTrackDynamicProperties mAutoTrackDynamicProperties;
    private AutoTrackEventListener mAutoTrackEventListener;
    private final JSONObject mAutoTrackEventProperties;
    private List<AutoTrackEventType> mAutoTrackEventTypeList;
    private List<Integer> mAutoTrackIgnoredActivities;
    private JSONObject mAutoTrackStartProperties;
    private cn.thinkingdata.analytics.h.e mAutoTrackStartTime;
    public cn.thinkingdata.analytics.h.a mCalibratedTimeManager;
    public TDConfig mConfig;
    private DynamicSuperPropertiesTracker mDynamicSuperPropertiesTracker;
    private final boolean mEnableTrackOldData;
    private boolean mIgnoreAppViewInExtPackage = false;
    private List<Class> mIgnoredViewTypeList = new ArrayList();
    private String mLastScreenUrl;
    private cn.thinkingdata.analytics.d.b mLifecycleCallbacks;
    protected final cn.thinkingdata.analytics.e.b mMessages;
    private cn.thinkingdata.analytics.f.a mStorageManager;
    private cn.thinkingdata.analytics.e.e mSystemInformation;
    private boolean mTrackCrash;
    private boolean mTrackFragmentAppViewScreen;
    final Map<String, cn.thinkingdata.analytics.e.d> mTrackTimer;
    private final cn.thinkingdata.analytics.e.g mUserOperationHandler;
    private static final Map<Context, Map<String, ThinkingAnalyticsSDK>> sInstanceMap = new HashMap();
    private static final Map<Context, List<String>> sAppFirstInstallationMap = new HashMap();

    public interface AutoTrackDynamicProperties {
        JSONObject getAutoTrackDynamicProperties();
    }

    public interface AutoTrackEventListener {
        JSONObject eventCallback(AutoTrackEventType autoTrackEventType, JSONObject jSONObject);
    }

    public enum AutoTrackEventType {
        APP_START("ta_app_start"),
        APP_END("ta_app_end"),
        APP_CLICK("ta_app_click"),
        APP_VIEW_SCREEN("ta_app_view"),
        APP_CRASH("ta_app_crash"),
        APP_INSTALL("ta_app_install");

        private final String eventName;

        AutoTrackEventType(String str) {
            this.eventName = str;
        }

        public static AutoTrackEventType autoTrackEventTypeFromEventName(String str) {
            if (TextUtils.isEmpty(str)) {
                return null;
            }
            str.hashCode();
            switch (str) {
                case "ta_app_install":
                    return APP_INSTALL;
                case "ta_app_click":
                    return APP_CLICK;
                case "ta_app_crash":
                    return APP_CRASH;
                case "ta_app_start":
                    return APP_START;
                case "ta_app_end":
                    return APP_END;
                case "ta_app_view":
                    return APP_VIEW_SCREEN;
                default:
                    return null;
            }
        }

        String getEventName() {
            return this.eventName;
        }
    }

    public interface DynamicSuperPropertiesTracker {
        JSONObject getDynamicSuperProperties();
    }

    public enum TATrackStatus {
        PAUSE,
        STOP,
        SAVE_ONLY,
        NORMAL
    }

    public enum ThinkingdataNetworkType {
        NETWORKTYPE_DEFAULT,
        NETWORKTYPE_WIFI,
        NETWORKTYPE_ALL
    }

    class a implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ String f47a;
        final /* synthetic */ long b;

        a(String str, long j) {
            this.f47a = str;
            this.b = j;
        }

        @Override // java.lang.Runnable
        public void run() {
            try {
                if (cn.thinkingdata.analytics.h.g.a(this.f47a)) {
                    TDLog.w(ThinkingAnalyticsSDK.TAG, "timeEvent event name[" + this.f47a + "] is not valid");
                }
                synchronized (ThinkingAnalyticsSDK.this.mTrackTimer) {
                    ThinkingAnalyticsSDK.this.mTrackTimer.put(this.f47a, new cn.thinkingdata.analytics.e.d(TimeUnit.SECONDS, this.b));
                }
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
    }

    class b implements Runnable {
        b() {
        }

        @Override // java.lang.Runnable
        public void run() {
            ThinkingAnalyticsSDK thinkingAnalyticsSDK = ThinkingAnalyticsSDK.this;
            thinkingAnalyticsSDK.mMessages.b(thinkingAnalyticsSDK.getToken());
        }
    }

    class c implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ TATrackStatus f49a;

        c(TATrackStatus tATrackStatus) {
            this.f49a = tATrackStatus;
        }

        @Override // java.lang.Runnable
        public void run() {
            String str;
            int i = d.f50a[this.f49a.ordinal()];
            if (i == 1) {
                ThinkingAnalyticsSDK.this.mStorageManager.b(false);
                ThinkingAnalyticsSDK.this.mStorageManager.c(false);
                ThinkingAnalyticsSDK thinkingAnalyticsSDK = ThinkingAnalyticsSDK.this;
                thinkingAnalyticsSDK.mMessages.a(thinkingAnalyticsSDK.getToken(), false);
                ThinkingAnalyticsSDK.this.enableTracking(false);
                str = "[ThinkingData] Info: Change Status to Pause";
            } else if (i == 2) {
                ThinkingAnalyticsSDK.this.mStorageManager.a(true);
                ThinkingAnalyticsSDK.this.mStorageManager.c(false);
                ThinkingAnalyticsSDK thinkingAnalyticsSDK2 = ThinkingAnalyticsSDK.this;
                thinkingAnalyticsSDK2.mMessages.a(thinkingAnalyticsSDK2.getToken(), false);
                ThinkingAnalyticsSDK.this.optOutTracking();
                str = "[ThinkingData] Info: Change Status to Stop";
            } else {
                if (i != 3) {
                    if (i != 4) {
                        return;
                    }
                    ThinkingAnalyticsSDK.this.mStorageManager.a(true);
                    ThinkingAnalyticsSDK.this.mStorageManager.b(false);
                    ThinkingAnalyticsSDK.this.mStorageManager.c(false);
                    ThinkingAnalyticsSDK thinkingAnalyticsSDK3 = ThinkingAnalyticsSDK.this;
                    thinkingAnalyticsSDK3.mMessages.a(thinkingAnalyticsSDK3.getToken(), false);
                    TDLog.i(ThinkingAnalyticsSDK.TAG, "[ThinkingData] Info: Change Status to Normal");
                    ThinkingAnalyticsSDK.this.flush();
                    return;
                }
                ThinkingAnalyticsSDK.this.mStorageManager.a(true);
                ThinkingAnalyticsSDK.this.mStorageManager.b(false);
                ThinkingAnalyticsSDK.this.mStorageManager.c(true);
                ThinkingAnalyticsSDK thinkingAnalyticsSDK4 = ThinkingAnalyticsSDK.this;
                thinkingAnalyticsSDK4.mMessages.a(thinkingAnalyticsSDK4.getToken(), true);
                str = "[ThinkingData] Info: Change Status to SaveOnly";
            }
            TDLog.i(ThinkingAnalyticsSDK.TAG, str);
        }
    }

    static /* synthetic */ class d {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        static final /* synthetic */ int[] f50a;

        static {
            int[] iArr = new int[TATrackStatus.values().length];
            f50a = iArr;
            try {
                iArr[TATrackStatus.PAUSE.ordinal()] = 1;
            } catch (NoSuchFieldError unused) {
            }
            try {
                f50a[TATrackStatus.STOP.ordinal()] = 2;
            } catch (NoSuchFieldError unused2) {
            }
            try {
                f50a[TATrackStatus.SAVE_ONLY.ordinal()] = 3;
            } catch (NoSuchFieldError unused3) {
            }
            try {
                f50a[TATrackStatus.NORMAL.ordinal()] = 4;
            } catch (NoSuchFieldError unused4) {
            }
        }
    }

    class e implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ boolean[] f51a;

        e(boolean[] zArr) {
            this.f51a = zArr;
        }

        @Override // java.lang.Runnable
        public void run() {
            ThinkingAnalyticsSDK thinkingAnalyticsSDK = ThinkingAnalyticsSDK.this;
            TDConfig tDConfig = thinkingAnalyticsSDK.mConfig;
            thinkingAnalyticsSDK.mSystemInformation = cn.thinkingdata.analytics.e.e.a(tDConfig.mContext, tDConfig.getDefaultTimeZone());
            boolean[] zArr = this.f51a;
            if (zArr.length <= 0 || !zArr[0]) {
                if (!ThinkingAnalyticsSDK.this.mConfig.isNormal() || q.b()) {
                    ThinkingAnalyticsSDK.enableTrackLog(true);
                }
            }
        }
    }

    class f implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ String f52a;
        final /* synthetic */ JSONObject b;
        final /* synthetic */ boolean c;
        final /* synthetic */ long d;
        final /* synthetic */ JSONObject e;
        final /* synthetic */ cn.thinkingdata.analytics.h.k f;
        final /* synthetic */ ThinkingAnalyticsSDK g;
        final /* synthetic */ cn.thinkingdata.analytics.h.e h;
        final /* synthetic */ String i;
        final /* synthetic */ String j;
        final /* synthetic */ boolean k;
        final /* synthetic */ int l;
        final /* synthetic */ Map m;

        f(String str, JSONObject jSONObject, boolean z, long j, JSONObject jSONObject2, cn.thinkingdata.analytics.h.k kVar, ThinkingAnalyticsSDK thinkingAnalyticsSDK, cn.thinkingdata.analytics.h.e eVar, String str2, String str3, boolean z2, int i, Map map) {
            this.f52a = str;
            this.b = jSONObject;
            this.c = z;
            this.d = j;
            this.e = jSONObject2;
            this.f = kVar;
            this.g = thinkingAnalyticsSDK;
            this.h = eVar;
            this.i = str2;
            this.j = str3;
            this.k = z2;
            this.l = i;
            this.m = map;
        }

        @Override // java.lang.Runnable
        public void run() {
            AutoTrackEventType autoTrackEventTypeAutoTrackEventTypeFromEventName;
            if (ThinkingAnalyticsSDK.this.mConfig.isDisabledEvent(this.f52a)) {
                TDLog.d(ThinkingAnalyticsSDK.TAG, "Ignoring disabled event [" + this.f52a + "]");
                return;
            }
            try {
                JSONObject jSONObject = this.b;
                boolean z = jSONObject != null && jSONObject.has(TDPresetUtils.KEY_BUNDLE_ID) && this.b.has("TA_KEY_SUBPROCESS_TAG__TA__");
                if (this.c && cn.thinkingdata.analytics.h.g.a(this.f52a)) {
                    TDLog.e(ThinkingAnalyticsSDK.TAG, "[ThinkingData] Error: Incorrect Event name[" + this.f52a + "]. Event name must be string that starts with English letter, and contains letter, number, and '_'. The max length of the event name is 50.");
                    if (ThinkingAnalyticsSDK.this.mConfig.shouldThrowException()) {
                        throw new cn.thinkingdata.analytics.h.l("Invalid event name: " + this.f52a);
                    }
                }
                if (this.c && !cn.thinkingdata.analytics.h.g.a(this.b)) {
                    TDLog.w(ThinkingAnalyticsSDK.TAG, "[ThinkingData] Warning: The data contains invalid key or value: " + this.b.toString());
                    if (ThinkingAnalyticsSDK.this.mConfig.shouldThrowException()) {
                        throw new cn.thinkingdata.analytics.h.l("Invalid properties. Please refer to SDK debug log for detail reasons.");
                    }
                }
                JSONObject jSONObjectObtainDefaultEventProperties = ThinkingAnalyticsSDK.this.obtainDefaultEventProperties(this.f52a, this.d, z);
                JSONObject jSONObject2 = this.e;
                if (jSONObject2 != null) {
                    q.a(jSONObject2, jSONObjectObtainDefaultEventProperties, ThinkingAnalyticsSDK.this.mConfig.getDefaultTimeZone());
                }
                JSONObject jSONObject3 = this.b;
                if (jSONObject3 != null) {
                    q.a(jSONObject3, jSONObjectObtainDefaultEventProperties, ThinkingAnalyticsSDK.this.mConfig.getDefaultTimeZone());
                }
                if (!z && (autoTrackEventTypeAutoTrackEventTypeFromEventName = AutoTrackEventType.autoTrackEventTypeFromEventName(this.f52a)) != null) {
                    if (ThinkingAnalyticsSDK.this.mAutoTrackEventListener != null) {
                        JSONObject jSONObjectEventCallback = ThinkingAnalyticsSDK.this.mAutoTrackEventListener.eventCallback(autoTrackEventTypeAutoTrackEventTypeFromEventName, jSONObjectObtainDefaultEventProperties);
                        if (jSONObjectEventCallback != null) {
                            q.a(jSONObjectEventCallback, jSONObjectObtainDefaultEventProperties, ThinkingAnalyticsSDK.this.mConfig.getDefaultTimeZone());
                        }
                    } else {
                        TDLog.i(ThinkingAnalyticsSDK.TAG, "No mAutoTrackEventListener");
                    }
                }
                if (z && jSONObjectObtainDefaultEventProperties.has("TA_KEY_SUBPROCESS_TAG__TA__")) {
                    jSONObjectObtainDefaultEventProperties.remove("TA_KEY_SUBPROCESS_TAG__TA__");
                }
                cn.thinkingdata.analytics.h.k kVar = this.f;
                if (kVar == null) {
                    kVar = cn.thinkingdata.analytics.h.k.TRACK;
                }
                cn.thinkingdata.analytics.e.a aVar = new cn.thinkingdata.analytics.e.a(this.g, kVar, jSONObjectObtainDefaultEventProperties, this.h, this.i, this.j, this.k);
                aVar.f86a = this.f52a;
                aVar.b = this.l;
                Map<String, String> map = this.m;
                if (map != null) {
                    aVar.a(map);
                }
                ThinkingAnalyticsSDK.this.trackInternal(aVar);
            } catch (JSONException e) {
                e.printStackTrace();
            }
        }
    }

    class g implements ISensitivePropertiesCallBack {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ cn.thinkingdata.analytics.e.a f53a;

        g(cn.thinkingdata.analytics.e.a aVar) {
            this.f53a = aVar;
        }

        @Override // cn.thinkingdata.core.router.provider.callback.ISensitivePropertiesCallBack
        public void onSuccess(JSONObject jSONObject) {
            if (!ThinkingAnalyticsSDK.this.mConfig.isDebugOnly() && !ThinkingAnalyticsSDK.this.mConfig.isDebug()) {
                cn.thinkingdata.analytics.e.a aVar = this.f53a;
                if (aVar.b != 2) {
                    if (aVar.i) {
                        ThinkingAnalyticsSDK.this.mMessages.c(aVar);
                        return;
                    } else {
                        ThinkingAnalyticsSDK.this.mMessages.a(aVar);
                        return;
                    }
                }
            }
            ThinkingAnalyticsSDK.this.mMessages.b(this.f53a);
        }
    }

    class h implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ String f54a;

        h(String str) {
            this.f54a = str;
        }

        @Override // java.lang.Runnable
        public void run() {
            ThinkingAnalyticsSDK.this.mStorageManager.b(this.f54a, ThinkingAnalyticsSDK.this.mConfig.shouldThrowException());
        }
    }

    class i implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ String f55a;

        i(String str) {
            this.f55a = str;
        }

        @Override // java.lang.Runnable
        public void run() {
            ThinkingAnalyticsSDK.this.mStorageManager.a(this.f55a, ThinkingAnalyticsSDK.this.mConfig.shouldThrowException());
        }
    }

    class j implements Runnable {
        j() {
        }

        @Override // java.lang.Runnable
        public void run() {
            ThinkingAnalyticsSDK.this.mStorageManager.b(ThinkingAnalyticsSDK.this.mEnableTrackOldData, ThinkingAnalyticsSDK.this.mConfig.mContext);
        }
    }

    class k implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ JSONObject f57a;

        k(JSONObject jSONObject) {
            this.f57a = jSONObject;
        }

        @Override // java.lang.Runnable
        public void run() {
            ThinkingAnalyticsSDK.this.mStorageManager.a(this.f57a, ThinkingAnalyticsSDK.this.mConfig.getDefaultTimeZone(), ThinkingAnalyticsSDK.this.mConfig.shouldThrowException());
        }
    }

    class l implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ String f58a;

        l(String str) {
            this.f58a = str;
        }

        @Override // java.lang.Runnable
        public void run() {
            ThinkingAnalyticsSDK.this.mStorageManager.a(this.f58a);
        }
    }

    class m implements Runnable {
        m() {
        }

        @Override // java.lang.Runnable
        public void run() {
            ThinkingAnalyticsSDK.this.mStorageManager.c();
        }
    }

    public interface n {
        void a(ThinkingAnalyticsSDK thinkingAnalyticsSDK);
    }

    ThinkingAnalyticsSDK(TDConfig tDConfig, boolean... zArr) {
        this.mConfig = tDConfig;
        if (TextUtils.isEmpty(tDConfig.getServerUrl()) || TextUtils.isEmpty(this.mConfig.mToken)) {
            throw new IllegalArgumentException("invalid appId or serverUrl");
        }
        this.mAutoTrackEventProperties = new JSONObject();
        if (!TDPresetProperties.disableList.contains("#fps")) {
            if (Looper.myLooper() == null) {
                Looper.prepare();
            }
            q.c();
        }
        this.mCalibratedTimeManager = new cn.thinkingdata.analytics.h.a(tDConfig);
        this.mUserOperationHandler = new cn.thinkingdata.analytics.e.g(this, tDConfig);
        cn.thinkingdata.analytics.g.a.a().a(new e(zArr));
        if (zArr.length > 0 && zArr[0]) {
            this.mEnableTrackOldData = false;
            this.mTrackTimer = new HashMap();
            this.mMessages = getDataHandleInstance(tDConfig.mContext);
            return;
        }
        boolean z = tDConfig.trackOldData() && !isOldDataTracked();
        this.mEnableTrackOldData = z;
        this.mStorageManager = new cn.thinkingdata.analytics.f.a(tDConfig.mContext, tDConfig.getName());
        cn.thinkingdata.analytics.e.b dataHandleInstance = getDataHandleInstance(tDConfig.mContext);
        this.mMessages = dataHandleInstance;
        dataHandleInstance.a(getToken(), this.mStorageManager.g());
        String identifyID = getIdentifyID();
        setStatusIdentifyId(identifyID == null ? getRandomID() : identifyID);
        setStatusAccountId(this.mStorageManager.a(z, this.mConfig.mContext));
        TATrackStatus tATrackStatus = TATrackStatus.NORMAL;
        if (this.mStorageManager.g()) {
            tATrackStatus = TATrackStatus.SAVE_ONLY;
        } else if (!this.mStorageManager.d()) {
            tATrackStatus = TATrackStatus.PAUSE;
        } else if (this.mStorageManager.f()) {
            tATrackStatus = TATrackStatus.STOP;
        }
        setStatusTrackStatus(tATrackStatus);
        if (tDConfig.mEnableEncrypt) {
            cn.thinkingdata.analytics.encrypt.e.a(tDConfig.getName(), tDConfig);
        }
        if (z) {
            dataHandleInstance.c(tDConfig.getName());
        }
        this.mTrackTimer = new HashMap();
        this.mAutoTrackIgnoredActivities = new ArrayList();
        this.mAutoTrackEventTypeList = new ArrayList();
        this.mLifecycleCallbacks = new cn.thinkingdata.analytics.d.b(this);
        ((Application) tDConfig.mContext.getApplicationContext()).registerActivityLifecycleCallbacks(this.mLifecycleCallbacks);
        TRouter.init();
        if (tDConfig.isEnableMutiprocess() && q.f(tDConfig.mContext)) {
            TDReceiver.a(tDConfig.mContext);
        }
        cn.thinkingdata.analytics.h.r.b.a(this);
        TDLog.i(TAG, String.format("[ThinkingData] Info: ThinkingData SDK %s initialize success with mode: %s, APP ID ends with: %s, server url: %s", "3.1.1", tDConfig.getMode().name(), q.a(tDConfig.mToken, 4), tDConfig.getServerUrl()));
    }

    static void addInstance(ThinkingAnalyticsSDK thinkingAnalyticsSDK, Context context, String str) {
        Map<Context, Map<String, ThinkingAnalyticsSDK>> map = sInstanceMap;
        synchronized (map) {
            Map<String, ThinkingAnalyticsSDK> map2 = map.get(context);
            if (map2 == null) {
                map2 = new HashMap<>();
                map.put(context, map2);
            }
            map2.put(str, thinkingAnalyticsSDK);
        }
    }

    public static void allInstances(n nVar) {
        Map<Context, Map<String, ThinkingAnalyticsSDK>> map = sInstanceMap;
        synchronized (map) {
            Iterator<Map<String, ThinkingAnalyticsSDK>> it = map.values().iterator();
            while (it.hasNext()) {
                Iterator<ThinkingAnalyticsSDK> it2 = it.next().values().iterator();
                while (it2.hasNext()) {
                    nVar.a(it2.next());
                }
            }
        }
    }

    public static void calibrateTime(long j2) {
        if (j2 <= 0) {
            return;
        }
        TDLog.i(TAG, "[ThinkingData] Info: Time Calibration with timestamp(" + j2 + ")");
        cn.thinkingdata.analytics.h.a.a(j2);
    }

    public static void calibrateTimeWithNtp(String... strArr) {
        cn.thinkingdata.analytics.h.a.a(strArr);
    }

    public static void enableTrackLog(boolean z) {
        TDLog.setEnableLog(z);
    }

    public static cn.thinkingdata.analytics.h.d getCalibratedTime() {
        return cn.thinkingdata.analytics.h.a.b();
    }

    private String getIdentifyID() {
        return this.mStorageManager.e();
    }

    public static ThinkingAnalyticsSDK getInstanceByAppId(String str) {
        Map<Context, Map<String, ThinkingAnalyticsSDK>> map = sInstanceMap;
        synchronized (map) {
            Iterator<Map<String, ThinkingAnalyticsSDK>> it = map.values().iterator();
            while (it.hasNext()) {
                for (ThinkingAnalyticsSDK thinkingAnalyticsSDK : it.next().values()) {
                    if (TextUtils.isEmpty(str)) {
                        return thinkingAnalyticsSDK;
                    }
                    if (TextUtils.equals(str, thinkingAnalyticsSDK.getToken())) {
                        return thinkingAnalyticsSDK;
                    }
                }
            }
            return null;
        }
    }

    static Map<String, ThinkingAnalyticsSDK> getInstanceMap(Context context) {
        return sInstanceMap.get(context);
    }

    public static String getLocalRegion() {
        return Locale.getDefault().getCountry();
    }

    private static boolean isOldDataTracked() {
        Map<Context, Map<String, ThinkingAnalyticsSDK>> map = sInstanceMap;
        synchronized (map) {
            if (map.size() > 0) {
                Iterator<Map<String, ThinkingAnalyticsSDK>> it = map.values().iterator();
                while (it.hasNext()) {
                    Iterator<ThinkingAnalyticsSDK> it2 = it.next().values().iterator();
                    while (it2.hasNext()) {
                        if (it2.next().mEnableTrackOldData) {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* JADX WARN: Code duplicated, block: B:33:0x00a2 A[Catch: Exception -> 0x014e, TryCatch #0 {Exception -> 0x014e, blocks: (B:3:0x0005, B:6:0x0027, B:7:0x0030, B:10:0x003c, B:11:0x0043, B:13:0x004d, B:16:0x0057, B:17:0x0060, B:19:0x006f, B:21:0x0079, B:33:0x00a2, B:34:0x00a4, B:38:0x00b5, B:40:0x00c7, B:42:0x00d1, B:43:0x00d6, B:45:0x00e6, B:47:0x00ee, B:49:0x00f8, B:52:0x00ff, B:56:0x0105, B:57:0x0106, B:60:0x0112, B:61:0x011b, B:64:0x0127, B:65:0x0134, B:68:0x0140, B:31:0x009d, B:35:0x00a5, B:36:0x00b2, B:22:0x0082, B:24:0x0086, B:26:0x008c, B:28:0x0092), top: B:71:0x0005, inners: #1, #2, #3 }] */
    /* JADX WARN: Code duplicated, block: B:59:0x0110  */
    /* JADX WARN: Code duplicated, block: B:63:0x0125  */
    /* JADX WARN: Code duplicated, block: B:67:0x013e  */
    /* JADX WARN: Code duplicated, block: B:72:0x00a5 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:76:0x00b5 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    public JSONObject obtainDefaultEventProperties(String str, long j2, boolean z) {
        cn.thinkingdata.analytics.e.d dVar;
        Double dValueOf;
        Double dValueOf2;
        JSONObject dynamicSuperProperties;
        JSONObject jSONObjectOptJSONObject;
        JSONObject jSONObject = new JSONObject();
        try {
            q.a(new JSONObject(this.mSystemInformation.e()), jSONObject, this.mConfig.getDefaultTimeZone());
            if (!TextUtils.isEmpty(this.mSystemInformation.b())) {
                jSONObject.put(TDPresetUtils.KEY_APP_VERSION, this.mSystemInformation.b());
            }
            if (!TDPresetProperties.disableList.contains("#fps")) {
                jSONObject.put("#fps", q.a());
            }
            if (!TDPresetProperties.disableList.contains(TDPresetUtils.KEY_DEVICE_ID) && !jSONObject.has(TDPresetUtils.KEY_DEVICE_ID)) {
                jSONObject.put(TDPresetUtils.KEY_DEVICE_ID, this.mSystemInformation.d());
            }
            q.a(getSuperProperties(), jSONObject, this.mConfig.getDefaultTimeZone());
            if (!z && (jSONObjectOptJSONObject = getAutoTrackProperties().optJSONObject(str)) != null) {
                q.a(jSONObjectOptJSONObject, jSONObject, this.mConfig.getDefaultTimeZone());
            }
            try {
                DynamicSuperPropertiesTracker dynamicSuperPropertiesTracker = this.mDynamicSuperPropertiesTracker;
                if (dynamicSuperPropertiesTracker == null || (dynamicSuperProperties = dynamicSuperPropertiesTracker.getDynamicSuperProperties()) == null || !cn.thinkingdata.analytics.h.g.a(dynamicSuperProperties)) {
                    if (!z) {
                        synchronized (this.mTrackTimer) {
                            dVar = this.mTrackTimer.get(str);
                            this.mTrackTimer.remove(str);
                        }
                        if (dVar != null) {
                            try {
                                dValueOf = Double.valueOf(dVar.a(j2));
                                if (dValueOf.doubleValue() > 0.0d && !TDPresetProperties.disableList.contains("#duration")) {
                                    jSONObject.put("#duration", dValueOf);
                                }
                                dValueOf2 = Double.valueOf(dVar.a());
                                if (dValueOf2.doubleValue() > 0.0d && !str.equals("ta_app_end") && !TDPresetProperties.disableList.contains("#background_duration")) {
                                    jSONObject.put("#background_duration", dValueOf2);
                                }
                            } catch (JSONException e2) {
                                e2.printStackTrace();
                            }
                        }
                    }
                    if (!TDPresetProperties.disableList.contains(TDPresetUtils.KEY_NETWORK_TYPE)) {
                        jSONObject.put(TDPresetUtils.KEY_NETWORK_TYPE, this.mSystemInformation.c());
                    }
                    if (!TDPresetProperties.disableList.contains("#ram")) {
                        jSONObject.put("#ram", this.mSystemInformation.a(this.mConfig.mContext));
                    }
                    if (!TDPresetProperties.disableList.contains("#disk")) {
                        jSONObject.put("#disk", this.mSystemInformation.a(this.mConfig.mContext, false));
                    }
                } else {
                    q.a(dynamicSuperProperties, jSONObject, this.mConfig.getDefaultTimeZone());
                    if (!z) {
                        synchronized (this.mTrackTimer) {
                            dVar = this.mTrackTimer.get(str);
                            this.mTrackTimer.remove(str);
                            if (dVar != null) {
                                dValueOf = Double.valueOf(dVar.a(j2));
                                if (dValueOf.doubleValue() > 0.0d) {
                                    jSONObject.put("#duration", dValueOf);
                                }
                                dValueOf2 = Double.valueOf(dVar.a());
                                if (dValueOf2.doubleValue() > 0.0d) {
                                    jSONObject.put("#background_duration", dValueOf2);
                                }
                            }
                        }
                    }
                    if (!TDPresetProperties.disableList.contains(TDPresetUtils.KEY_NETWORK_TYPE)) {
                        jSONObject.put(TDPresetUtils.KEY_NETWORK_TYPE, this.mSystemInformation.c());
                    }
                    if (!TDPresetProperties.disableList.contains("#ram")) {
                        jSONObject.put("#ram", this.mSystemInformation.a(this.mConfig.mContext));
                    }
                    if (!TDPresetProperties.disableList.contains("#disk")) {
                        jSONObject.put("#disk", this.mSystemInformation.a(this.mConfig.mContext, false));
                    }
                }
            } catch (Exception e3) {
                e3.printStackTrace();
            }
        } catch (Exception unused) {
        }
        return jSONObject;
    }

    public static void setCustomerLibInfo(String str, String str2) {
        cn.thinkingdata.analytics.e.e.a(str, str2);
    }

    public static ThinkingAnalyticsSDK sharedInstance(Context context, String str) {
        return sharedInstance(context, str, null, false);
    }

    public static ThinkingAnalyticsSDK sharedInstance(Context context, String str, String str2) {
        return sharedInstance(context, str, str2, true);
    }

    public static ThinkingAnalyticsSDK sharedInstance(Context context, String str, String str2, boolean z) {
        String str3;
        if (context == null) {
            str3 = "App context is required to get SDK instance.";
        } else if (TextUtils.isEmpty(str)) {
            str3 = "APP ID is required to get SDK instance.";
        } else {
            try {
                TDConfig tDConfig = TDConfig.getInstance(context, str, str2);
                tDConfig.setTrackOldData(z);
                return sharedInstance(tDConfig);
            } catch (IllegalArgumentException unused) {
                str3 = "Cannot get valid TDConfig instance. Returning null";
            }
        }
        TDLog.w(TAG, str3);
        return null;
    }

    public static ThinkingAnalyticsSDK sharedInstance(TDConfig tDConfig) {
        ThinkingAnalyticsSDK thinkingAnalyticsSDK;
        if (tDConfig == null) {
            TDLog.w(TAG, "Cannot initial SDK instance with null config instance.");
            return null;
        }
        Map<Context, Map<String, ThinkingAnalyticsSDK>> map = sInstanceMap;
        synchronized (map) {
            Map<String, ThinkingAnalyticsSDK> map2 = map.get(tDConfig.mContext);
            if (map2 == null) {
                map2 = new HashMap<>();
                map.put(tDConfig.mContext, map2);
                Pair<Long, Boolean> pairC = q.c(tDConfig.mContext);
                long jLongValue = ((Long) pairC.first).longValue();
                long jLongValue2 = cn.thinkingdata.analytics.f.d.a(tDConfig.mContext).b().longValue();
                boolean z = jLongValue2 > 0 && jLongValue <= jLongValue2;
                if (!z) {
                    cn.thinkingdata.analytics.f.d.a(tDConfig.mContext).a(Long.valueOf(jLongValue));
                }
                boolean zBooleanValue = ((Boolean) pairC.second).booleanValue();
                if (!z && zBooleanValue) {
                    sAppFirstInstallationMap.put(tDConfig.mContext, new LinkedList());
                }
            }
            thinkingAnalyticsSDK = map2.get(tDConfig.getName());
            if (thinkingAnalyticsSDK == null) {
                try {
                    if (q.f(tDConfig.mContext)) {
                        thinkingAnalyticsSDK = new ThinkingAnalyticsSDK(tDConfig, new boolean[0]);
                        Map<Context, List<String>> map3 = sAppFirstInstallationMap;
                        if (map3.containsKey(tDConfig.mContext)) {
                            map3.get(tDConfig.mContext).add(tDConfig.getName());
                        }
                    } else {
                        thinkingAnalyticsSDK = new cn.thinkingdata.analytics.c(tDConfig);
                    }
                    map2.put(tDConfig.getName(), thinkingAnalyticsSDK);
                } catch (Exception unused) {
                    return null;
                }
            }
        }
        return thinkingAnalyticsSDK;
    }

    private void track(String str, JSONObject jSONObject, cn.thinkingdata.analytics.h.e eVar) {
        track(str, jSONObject, eVar, true);
    }

    private void track(String str, JSONObject jSONObject, cn.thinkingdata.analytics.h.e eVar, boolean z) {
        track(str, jSONObject, eVar, z, null, null, 0);
    }

    public void appBecomeActive() {
        cn.thinkingdata.analytics.e.d value;
        synchronized (this.mTrackTimer) {
            try {
                for (Map.Entry<String, cn.thinkingdata.analytics.e.d> entry : this.mTrackTimer.entrySet()) {
                    if (entry != null && (value = entry.getValue()) != null) {
                        long jB = (value.b() + SystemClock.elapsedRealtime()) - value.d();
                        value.e(SystemClock.elapsedRealtime());
                        value.c(jB);
                    }
                }
            } catch (Exception e2) {
                TDLog.i(TAG, "appBecomeActive error:" + e2.getMessage());
            } finally {
                flush();
            }
        }
    }

    public void appEnterBackground() {
        cn.thinkingdata.analytics.e.d value;
        synchronized (this.mTrackTimer) {
            try {
                for (Map.Entry<String, cn.thinkingdata.analytics.e.d> entry : this.mTrackTimer.entrySet()) {
                    if (entry != null && !"ta_app_end".equals(entry.getKey().toString()) && (value = entry.getValue()) != null) {
                        value.d((value.c() + SystemClock.elapsedRealtime()) - value.d());
                        value.e(SystemClock.elapsedRealtime());
                    }
                }
            } catch (Exception e2) {
                TDLog.i(TAG, "appEnterBackground error:" + e2.getMessage());
            }
        }
    }

    public void autoTrack(String str, JSONObject jSONObject) {
        track(str, jSONObject, this.mCalibratedTimeManager.a(), false);
    }

    public void autoTrack(String str, JSONObject jSONObject, cn.thinkingdata.analytics.h.e eVar) {
        track(str, jSONObject, eVar, false);
    }

    public void clearSuperProperties() {
        if (getStatusHasDisabled()) {
            return;
        }
        cn.thinkingdata.analytics.g.a.a().a(new m());
    }

    /* JADX INFO: renamed from: createLightInstance, reason: merged with bridge method [inline-methods] */
    public ThinkingAnalyticsSDK m78createLightInstance() {
        return new cn.thinkingdata.analytics.b(this.mConfig);
    }

    public void enableAutoTrack(List<AutoTrackEventType> list) {
        if (getStatusHasDisabled()) {
            return;
        }
        this.mAutoTrack = true;
        if (list == null || list.size() == 0) {
            return;
        }
        if (list.contains(AutoTrackEventType.APP_INSTALL)) {
            synchronized (sInstanceMap) {
                Map<Context, List<String>> map = sAppFirstInstallationMap;
                if (map.containsKey(this.mConfig.mContext) && map.get(this.mConfig.mContext).contains(getToken())) {
                    track("ta_app_install");
                    flush();
                    map.get(this.mConfig.mContext).remove(getToken());
                    TRouter.getInstance().build(TRouterMap.PRESET_TEMPLATE_ROUTE_PATH).withAction("triggerAppInstallEvent").withString(AlipayApi.c, getToken()).navigation();
                }
            }
        }
        if (list.contains(AutoTrackEventType.APP_CRASH)) {
            this.mTrackCrash = true;
            cn.thinkingdata.analytics.d.a aVarB = cn.thinkingdata.analytics.d.a.b(this.mConfig.mContext);
            if (aVarB != null) {
                aVarB.a();
            }
        }
        if (!this.mAutoTrackEventTypeList.contains(AutoTrackEventType.APP_END) && list.contains(AutoTrackEventType.APP_END)) {
            timeEvent("ta_app_end");
            this.mLifecycleCallbacks.a(true);
        }
        synchronized (this) {
            long jElapsedRealtime = SystemClock.elapsedRealtime();
            this.mAutoTrackStartTime = this.mCalibratedTimeManager.a();
            this.mAutoTrackStartProperties = obtainDefaultEventProperties("ta_app_start", jElapsedRealtime, false);
        }
        this.mAutoTrackEventTypeList.clear();
        this.mAutoTrackEventTypeList.addAll(list);
        if (this.mAutoTrackEventTypeList.contains(AutoTrackEventType.APP_START)) {
            this.mLifecycleCallbacks.b();
        }
    }

    public void enableAutoTrack(List<AutoTrackEventType> list, AutoTrackEventListener autoTrackEventListener) {
        this.mAutoTrackEventListener = autoTrackEventListener;
        enableAutoTrack(list);
    }

    public void enableAutoTrack(List<AutoTrackEventType> list, JSONObject jSONObject) {
        setAutoTrackProperties(list, jSONObject);
        enableAutoTrack(list);
    }

    public void enableThirdPartySharing(int i2) {
        TRouter.getInstance().build("/thingkingdata/third/party").withAction("enableThirdPartySharing").withInt("type", i2).withObject("instance", this).withString("loginId", getLoginId()).navigation();
    }

    public void enableThirdPartySharing(int i2, Object obj) {
        TRouter.getInstance().build("/thingkingdata/third/party").withAction("enableThirdPartySharingWithParams").withInt("type", i2).withObject("instance", this).withString("loginId", getLoginId()).withObject("params", obj).navigation();
    }

    @Deprecated
    public void enableTracking(boolean z) {
        if (!z) {
            flush();
        }
        setStatusTrackStatus(TATrackStatus.PAUSE);
        this.mStorageManager.a(z);
    }

    public void flush() {
        boolean statusHasDisabled = getStatusHasDisabled();
        boolean zIsStatusTrackSaveOnly = isStatusTrackSaveOnly();
        if (statusHasDisabled || zIsStatusTrackSaveOnly) {
            return;
        }
        cn.thinkingdata.analytics.g.a.a().a(new b());
    }

    public List<AutoTrackEventType> getAutoTrackEventTypeList() {
        return this.mAutoTrackEventTypeList;
    }

    public JSONObject getAutoTrackProperties() {
        return this.mAutoTrackEventProperties;
    }

    public synchronized JSONObject getAutoTrackStartProperties() {
        JSONObject jSONObject;
        jSONObject = this.mAutoTrackStartProperties;
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        return jSONObject;
    }

    public synchronized cn.thinkingdata.analytics.h.e getAutoTrackStartTime() {
        return this.mAutoTrackStartTime;
    }

    public String getCurrentTime() {
        return this.mCalibratedTimeManager.a().b();
    }

    public Double getCurrentZoneOffset() {
        return this.mCalibratedTimeManager.a().a();
    }

    protected cn.thinkingdata.analytics.e.b getDataHandleInstance(Context context) {
        return cn.thinkingdata.analytics.e.b.b(context);
    }

    public String getDeviceId() {
        TDConfig tDConfig = this.mConfig;
        return cn.thinkingdata.analytics.e.e.a(tDConfig.mContext, tDConfig.getDefaultTimeZone()).d();
    }

    public String getDistinctId() {
        String statusIdentifyId = getStatusIdentifyId();
        return statusIdentifyId == null ? getRandomID() : statusIdentifyId;
    }

    DynamicSuperPropertiesTracker getDynamicSuperPropertiesTracker() {
        return this.mDynamicSuperPropertiesTracker;
    }

    List<Class> getIgnoredViewTypeList() {
        if (this.mIgnoredViewTypeList == null) {
            this.mIgnoredViewTypeList = new ArrayList();
        }
        return this.mIgnoredViewTypeList;
    }

    String getLoginId() {
        return getStatusAccountId();
    }

    public TDPresetProperties getPresetProperties() {
        JSONObject jSONObjectA = cn.thinkingdata.analytics.e.e.b(this.mConfig.mContext).a();
        String strC = cn.thinkingdata.analytics.e.e.b(this.mConfig.mContext).c();
        double dDoubleValue = this.mCalibratedTimeManager.a().a().doubleValue();
        try {
            if (!TDPresetProperties.disableList.contains(TDPresetUtils.KEY_NETWORK_TYPE)) {
                jSONObjectA.put(TDPresetUtils.KEY_NETWORK_TYPE, strC);
            }
            jSONObjectA.put("#zone_offset", dDoubleValue);
            if (!TDPresetProperties.disableList.contains("#ram")) {
                jSONObjectA.put("#ram", cn.thinkingdata.analytics.e.e.b(this.mConfig.mContext).a(this.mConfig.mContext));
            }
            if (!TDPresetProperties.disableList.contains("#disk")) {
                jSONObjectA.put("#disk", cn.thinkingdata.analytics.e.e.b(this.mConfig.mContext).a(this.mConfig.mContext, false));
            }
            if (!TDPresetProperties.disableList.contains("#fps")) {
                jSONObjectA.put("#fps", q.a());
            }
            if (!TDPresetProperties.disableList.contains(TDPresetUtils.KEY_DEVICE_ID) && !jSONObjectA.has(TDPresetUtils.KEY_DEVICE_ID)) {
                jSONObjectA.put(TDPresetUtils.KEY_DEVICE_ID, cn.thinkingdata.analytics.e.e.b(this.mConfig.mContext).d());
            }
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        return new TDPresetProperties(jSONObjectA);
    }

    String getRandomID() {
        return cn.thinkingdata.analytics.f.d.a(this.mConfig.mContext).d();
    }

    public synchronized String getStatusAccountId() {
        return this._statusAccountId;
    }

    public synchronized boolean getStatusHasDisabled() {
        TATrackStatus statusTrackStatus = getStatusTrackStatus();
        return statusTrackStatus == TATrackStatus.STOP || statusTrackStatus == TATrackStatus.PAUSE;
    }

    public synchronized String getStatusIdentifyId() {
        return this._statusIdentifyId;
    }

    protected synchronized TATrackStatus getStatusTrackStatus() {
        return this._statusTrackStatus;
    }

    public JSONObject getSuperProperties() {
        return this.mStorageManager.h();
    }

    public String getTimeString(Date date) {
        return this.mCalibratedTimeManager.a(date, this.mConfig.getDefaultTimeZone()).b();
    }

    public String getToken() {
        return this.mConfig.getName();
    }

    boolean hasDisabled() {
        return !isEnabled() || hasOptOut();
    }

    public boolean hasOptOut() {
        return this.mStorageManager.f();
    }

    public void identify(String str) {
        if (getStatusHasDisabled()) {
            return;
        }
        if (q.b(str)) {
            TDLog.w(TAG, "The identity cannot be empty.");
            if (this.mConfig.shouldThrowException()) {
                throw new cn.thinkingdata.analytics.h.l("distinct id cannot be empty");
            }
        } else {
            TDLog.i(TAG, "[ThinkingData] Info: Setting distinct ID, DistinctId = " + str);
            setStatusIdentifyId(str);
            cn.thinkingdata.analytics.g.a.a().a(new h(str));
            TDAnalyticsObservable.getInstance().onSetDistinctIdMethodCalled(getLoginId(), str, this.mConfig.mToken);
            TAPushUtils.handlePushTokenAfterLogin(this);
        }
    }

    public void ignoreAppViewEventInExtPackage() {
        this.mIgnoreAppViewInExtPackage = true;
    }

    public void ignoreAutoTrackActivities(List<Class<?>> list) {
        if (getStatusHasDisabled() || list == null || list.size() == 0) {
            return;
        }
        if (this.mAutoTrackIgnoredActivities == null) {
            this.mAutoTrackIgnoredActivities = new ArrayList();
        }
        for (Class<?> cls : list) {
            if (cls != null && !this.mAutoTrackIgnoredActivities.contains(Integer.valueOf(cls.hashCode()))) {
                this.mAutoTrackIgnoredActivities.add(Integer.valueOf(cls.hashCode()));
            }
        }
    }

    public void ignoreAutoTrackActivity(Class<?> cls) {
        if (getStatusHasDisabled() || cls == null) {
            return;
        }
        if (this.mAutoTrackIgnoredActivities == null) {
            this.mAutoTrackIgnoredActivities = new ArrayList();
        }
        if (this.mAutoTrackIgnoredActivities.contains(Integer.valueOf(cls.hashCode()))) {
            return;
        }
        this.mAutoTrackIgnoredActivities.add(Integer.valueOf(cls.hashCode()));
    }

    public void ignoreView(View view) {
        if (getStatusHasDisabled() || view == null) {
            return;
        }
        q.a(getToken(), view, R.id.thinking_analytics_tag_view_ignored, "1");
    }

    public void ignoreViewType(Class cls) {
        if (getStatusHasDisabled() || cls == null) {
            return;
        }
        if (this.mIgnoredViewTypeList == null) {
            this.mIgnoredViewTypeList = new ArrayList();
        }
        if (this.mIgnoredViewTypeList.contains(cls)) {
            return;
        }
        this.mIgnoredViewTypeList.add(cls);
    }

    boolean isActivityAutoTrackAppClickIgnored(Class<?> cls) {
        if (cls == null) {
            return false;
        }
        List<Integer> list = this.mAutoTrackIgnoredActivities;
        if (list != null && list.contains(Integer.valueOf(cls.hashCode()))) {
            return true;
        }
        ThinkingDataIgnoreTrackAppViewScreenAndAppClick thinkingDataIgnoreTrackAppViewScreenAndAppClick = (ThinkingDataIgnoreTrackAppViewScreenAndAppClick) cls.getAnnotation(ThinkingDataIgnoreTrackAppViewScreenAndAppClick.class);
        if (thinkingDataIgnoreTrackAppViewScreenAndAppClick != null && (TextUtils.isEmpty(thinkingDataIgnoreTrackAppViewScreenAndAppClick.appId()) || getToken().equals(thinkingDataIgnoreTrackAppViewScreenAndAppClick.appId()))) {
            return true;
        }
        ThinkingDataIgnoreTrackAppClick thinkingDataIgnoreTrackAppClick = (ThinkingDataIgnoreTrackAppClick) cls.getAnnotation(ThinkingDataIgnoreTrackAppClick.class);
        if (thinkingDataIgnoreTrackAppClick != null) {
            return TextUtils.isEmpty(thinkingDataIgnoreTrackAppClick.appId()) || getToken().equals(thinkingDataIgnoreTrackAppClick.appId());
        }
        return false;
    }

    public boolean isActivityAutoTrackAppViewScreenIgnored(Class<?> cls) {
        if (cls == null) {
            return false;
        }
        List<Integer> list = this.mAutoTrackIgnoredActivities;
        if (list != null && list.contains(Integer.valueOf(cls.hashCode()))) {
            return true;
        }
        ThinkingDataIgnoreTrackAppViewScreenAndAppClick thinkingDataIgnoreTrackAppViewScreenAndAppClick = (ThinkingDataIgnoreTrackAppViewScreenAndAppClick) cls.getAnnotation(ThinkingDataIgnoreTrackAppViewScreenAndAppClick.class);
        if (thinkingDataIgnoreTrackAppViewScreenAndAppClick != null && (TextUtils.isEmpty(thinkingDataIgnoreTrackAppViewScreenAndAppClick.appId()) || getToken().equals(thinkingDataIgnoreTrackAppViewScreenAndAppClick.appId()))) {
            return true;
        }
        ThinkingDataIgnoreTrackAppViewScreen thinkingDataIgnoreTrackAppViewScreen = (ThinkingDataIgnoreTrackAppViewScreen) cls.getAnnotation(ThinkingDataIgnoreTrackAppViewScreen.class);
        return thinkingDataIgnoreTrackAppViewScreen != null && (TextUtils.isEmpty(thinkingDataIgnoreTrackAppViewScreen.appId()) || getToken().equals(thinkingDataIgnoreTrackAppViewScreen.appId()));
    }

    public boolean isAutoTrackEnabled() {
        if (getStatusHasDisabled()) {
            return false;
        }
        return this.mAutoTrack;
    }

    public boolean isAutoTrackEventTypeIgnored(AutoTrackEventType autoTrackEventType) {
        return (autoTrackEventType == null || this.mAutoTrackEventTypeList.contains(autoTrackEventType)) ? false : true;
    }

    public boolean isEnabled() {
        return this.mStorageManager.d();
    }

    public boolean isIgnoreAppViewInExtPackage() {
        return this.mIgnoreAppViewInExtPackage;
    }

    public synchronized boolean isStatusTrackSaveOnly() {
        return getStatusTrackStatus() == TATrackStatus.SAVE_ONLY;
    }

    boolean isTrackFragmentAppViewScreenEnabled() {
        return this.mTrackFragmentAppViewScreen;
    }

    public void login(String str) {
        if (getStatusHasDisabled()) {
            return;
        }
        if (q.b(str)) {
            TDLog.w(TAG, "The account id cannot be empty.");
            if (this.mConfig.shouldThrowException()) {
                throw new cn.thinkingdata.analytics.h.l("account id cannot be empty");
            }
        } else {
            TDLog.i(TAG, "[ThinkingData] Info: Login SDK, AccountId = " + str);
            setStatusAccountId(str);
            cn.thinkingdata.analytics.g.a.a().a(new i(str));
            TDAnalyticsObservable.getInstance().onLoginMethodCalled(str, getDistinctId(), this.mConfig.mToken);
            TAPushUtils.handlePushTokenAfterLogin(this);
        }
    }

    public void logout() {
        if (getStatusHasDisabled()) {
            return;
        }
        TDLog.i(TAG, "[ThinkingData] Info: Logout SDK");
        setStatusAccountId(null);
        cn.thinkingdata.analytics.g.a.a().a(new j());
        TDAnalyticsObservable.getInstance().onLogoutMethodCalled(getDistinctId(), this.mConfig.mToken);
    }

    @Deprecated
    public void optInTracking() {
        setStatusTrackStatus(TATrackStatus.NORMAL);
        this.mStorageManager.b(false);
        this.mMessages.b(getToken());
    }

    @Deprecated
    public void optOutTracking() {
        setStatusTrackStatus(TATrackStatus.PAUSE);
        this.mStorageManager.b(true);
        this.mMessages.a(getToken());
        synchronized (this.mTrackTimer) {
            this.mTrackTimer.clear();
        }
        setStatusAccountId(null);
        setStatusIdentifyId(getRandomID());
        this.mStorageManager.a();
        this.mStorageManager.b();
        this.mStorageManager.c();
    }

    @Deprecated
    public void optOutTrackingAndDeleteUser() {
        setStatusTrackStatus(TATrackStatus.STOP);
        cn.thinkingdata.analytics.e.a aVar = new cn.thinkingdata.analytics.e.a(this, cn.thinkingdata.analytics.h.k.USER_DEL, null, this.mCalibratedTimeManager.a(), getStatusIdentifyId(), getStatusAccountId(), false);
        aVar.b();
        trackInternal(aVar);
        optOutTracking();
    }

    public void setAutoTrackDynamicProperties(AutoTrackDynamicProperties autoTrackDynamicProperties) {
        if (getStatusHasDisabled()) {
            return;
        }
        this.mAutoTrackDynamicProperties = autoTrackDynamicProperties;
    }

    public void setAutoTrackProperties(List<AutoTrackEventType> list, JSONObject jSONObject) {
        if (getStatusHasDisabled()) {
            return;
        }
        if (jSONObject != null) {
            try {
                if (cn.thinkingdata.analytics.h.g.a(jSONObject)) {
                    JSONObject jSONObject2 = new JSONObject();
                    for (AutoTrackEventType autoTrackEventType : list) {
                        JSONObject jSONObject3 = new JSONObject();
                        q.a(jSONObject, jSONObject3, this.mConfig.getDefaultTimeZone());
                        jSONObject2.put(autoTrackEventType.getEventName(), jSONObject3);
                    }
                    synchronized (this.mAutoTrackEventProperties) {
                        q.b(jSONObject2, this.mAutoTrackEventProperties, this.mConfig.getDefaultTimeZone());
                    }
                    return;
                }
            } catch (Exception e2) {
                e2.printStackTrace();
                return;
            }
        }
        if (this.mConfig.shouldThrowException()) {
            throw new cn.thinkingdata.analytics.h.l("Set autoTrackEvent properties failed. Please refer to the SDK debug log for details.");
        }
    }

    public void setDynamicSuperPropertiesTracker(DynamicSuperPropertiesTracker dynamicSuperPropertiesTracker) {
        if (getStatusHasDisabled()) {
            return;
        }
        this.mDynamicSuperPropertiesTracker = dynamicSuperPropertiesTracker;
    }

    public void setJsBridge(WebView webView) {
        if (webView == null) {
            TDLog.d(TAG, "SetJsBridge failed due to parameter webView is null");
            if (this.mConfig.shouldThrowException()) {
                throw new cn.thinkingdata.analytics.h.l("webView cannot be null for setJsBridge");
            }
        } else {
            webView.getSettings().setJavaScriptEnabled(true);
            TDConfig tDConfig = this.mConfig;
            webView.addJavascriptInterface(new TDWebAppInterface(this, cn.thinkingdata.analytics.e.e.a(tDConfig.mContext, tDConfig.getDefaultTimeZone()).e()), "ThinkingData_APP_JS_Bridge");
        }
    }

    public void setJsBridgeForX5WebView(Object obj) {
        if (obj == null) {
            TDLog.d(TAG, "SetJsBridge failed due to parameter webView is null");
            return;
        }
        try {
            obj.getClass().getMethod("addJavascriptInterface", Object.class, String.class).invoke(obj, new TDWebAppInterface(this, cn.thinkingdata.analytics.e.e.a(this.mConfig.mContext, this.mConfig.getDefaultTimeZone()).e()), "ThinkingData_APP_JS_Bridge");
        } catch (Exception e2) {
            TDLog.w(TAG, "setJsBridgeForX5WebView failed: " + e2.toString());
        }
    }

    public void setNetworkType(ThinkingdataNetworkType thinkingdataNetworkType) {
        if (getStatusHasDisabled()) {
            return;
        }
        this.mConfig.setNetworkType(thinkingdataNetworkType);
    }

    protected synchronized void setStatusAccountId(String str) {
        this._statusAccountId = str;
    }

    protected synchronized void setStatusIdentifyId(String str) {
        this._statusIdentifyId = str;
    }

    protected synchronized void setStatusTrackStatus(TATrackStatus tATrackStatus) {
        this._statusTrackStatus = tATrackStatus;
    }

    public void setSuperProperties(JSONObject jSONObject) {
        if (getStatusHasDisabled()) {
            return;
        }
        cn.thinkingdata.analytics.g.a.a().a(new k(jSONObject));
    }

    public void setTrackStatus(TATrackStatus tATrackStatus) {
        setStatusTrackStatus(tATrackStatus);
        cn.thinkingdata.analytics.g.a.a().a(new c(tATrackStatus));
    }

    public void setViewID(Dialog dialog, String str) {
        if (getStatusHasDisabled() || dialog == null) {
            return;
        }
        try {
            if (TextUtils.isEmpty(str) || dialog.getWindow() == null) {
                return;
            }
            q.a(getToken(), dialog.getWindow().getDecorView(), R.id.thinking_analytics_tag_view_id, str);
        } catch (Exception e2) {
            e2.printStackTrace();
        }
    }

    public void setViewID(View view, String str) {
        if (getStatusHasDisabled() || view == null || TextUtils.isEmpty(str)) {
            return;
        }
        q.a(getToken(), view, R.id.thinking_analytics_tag_view_id, str);
    }

    public void setViewProperties(View view, JSONObject jSONObject) {
        if (getStatusHasDisabled() || view == null || jSONObject == null) {
            return;
        }
        q.a(getToken(), view, R.id.thinking_analytics_tag_view_properties, jSONObject);
    }

    public boolean shouldTrackCrash() {
        if (getStatusHasDisabled()) {
            return false;
        }
        return this.mTrackCrash;
    }

    public void timeEvent(String str) {
        if (getStatusHasDisabled()) {
            return;
        }
        cn.thinkingdata.analytics.g.a.a().a(new a(str, SystemClock.elapsedRealtime()));
    }

    public void track(ThinkingAnalyticsEvent thinkingAnalyticsEvent) {
        if (getStatusHasDisabled()) {
            return;
        }
        if (thinkingAnalyticsEvent == null) {
            TDLog.w(TAG, "Ignoring empty event...");
            return;
        }
        cn.thinkingdata.analytics.h.e eVarA = thinkingAnalyticsEvent.getEventTime() != null ? this.mCalibratedTimeManager.a(thinkingAnalyticsEvent.getEventTime(), thinkingAnalyticsEvent.getTimeZone()) : this.mCalibratedTimeManager.a();
        HashMap map = new HashMap();
        if (TextUtils.isEmpty(thinkingAnalyticsEvent.getExtraField())) {
            TDLog.w(TAG, "Invalid ExtraFields. Ignoring...");
        } else {
            map.put(thinkingAnalyticsEvent.getExtraField(), ((thinkingAnalyticsEvent instanceof TDFirstEvent) && thinkingAnalyticsEvent.getExtraValue() == null) ? getDeviceId() : thinkingAnalyticsEvent.getExtraValue());
        }
        track(thinkingAnalyticsEvent.getEventName(), thinkingAnalyticsEvent.getProperties(), eVarA, true, map, thinkingAnalyticsEvent.getDataType(), 0);
    }

    public void track(String str) {
        track(str, (JSONObject) null, this.mCalibratedTimeManager.a());
    }

    public void track(String str, JSONObject jSONObject) {
        track(str, jSONObject, this.mCalibratedTimeManager.a());
    }

    void track(String str, JSONObject jSONObject, cn.thinkingdata.analytics.h.e eVar, boolean z, Map<String, String> map, cn.thinkingdata.analytics.h.k kVar, int i2) {
        JSONObject autoTrackDynamicProperties;
        AutoTrackDynamicProperties autoTrackDynamicProperties2;
        if (getStatusHasDisabled()) {
            return;
        }
        long jElapsedRealtime = SystemClock.elapsedRealtime();
        String statusAccountId = getStatusAccountId();
        String statusIdentifyId = getStatusIdentifyId();
        boolean zIsStatusTrackSaveOnly = isStatusTrackSaveOnly();
        if (AutoTrackEventType.autoTrackEventTypeFromEventName(str) == null || (autoTrackDynamicProperties2 = this.mAutoTrackDynamicProperties) == null) {
            autoTrackDynamicProperties = null;
        } else {
            try {
                autoTrackDynamicProperties = autoTrackDynamicProperties2.getAutoTrackDynamicProperties();
            } catch (Exception e2) {
                e2.printStackTrace();
                autoTrackDynamicProperties = null;
            }
        }
        cn.thinkingdata.analytics.g.a.a().a(new f(str, jSONObject, z, jElapsedRealtime, autoTrackDynamicProperties, kVar, this, eVar, statusIdentifyId, statusAccountId, zIsStatusTrackSaveOnly, i2, map));
    }

    public void track(String str, JSONObject jSONObject, Date date) {
        track(str, jSONObject, this.mCalibratedTimeManager.a(date, null));
    }

    public void track(String str, JSONObject jSONObject, Date date, TimeZone timeZone) {
        track(str, jSONObject, this.mCalibratedTimeManager.a(date, timeZone));
    }

    public void trackAppCrashAndEndEvent(JSONObject jSONObject) {
        this.mLifecycleCallbacks.a(jSONObject);
    }

    public void trackAppInstall() {
        if (getStatusHasDisabled()) {
            return;
        }
        enableAutoTrack(new ArrayList(Collections.singletonList(AutoTrackEventType.APP_INSTALL)));
    }

    public void trackFragmentAppViewScreen() {
        if (getStatusHasDisabled()) {
            return;
        }
        this.mTrackFragmentAppViewScreen = true;
    }

    public void trackInternal(cn.thinkingdata.analytics.e.a aVar) {
        aVar.a(this.mConfig.mContext, new g(aVar));
    }

    /* JADX WARN: Multi-variable type inference failed */
    public void trackViewScreen(Activity activity) {
        if (getStatusHasDisabled() || activity == 0) {
            return;
        }
        try {
            JSONObject jSONObject = new JSONObject();
            if (!TDPresetProperties.disableList.contains("#screen_name")) {
                jSONObject.put("#screen_name", activity.getClass().getCanonicalName());
            }
            q.a(jSONObject, activity);
            if (!(activity instanceof ScreenAutoTracker)) {
                autoTrack("ta_app_view", jSONObject);
                return;
            }
            ScreenAutoTracker screenAutoTracker = (ScreenAutoTracker) activity;
            String screenUrl = screenAutoTracker.getScreenUrl();
            JSONObject trackProperties = screenAutoTracker.getTrackProperties();
            if (trackProperties != null) {
                q.a(trackProperties, jSONObject, this.mConfig.getDefaultTimeZone());
            }
            trackViewScreenInternal(screenUrl, jSONObject);
        } catch (Exception e2) {
            TDLog.i(TAG, "trackViewScreen:" + e2);
        }
    }

    /* JADX WARN: Multi-variable type inference failed */
    public void trackViewScreen(Fragment fragment) {
        if (getStatusHasDisabled() || fragment == 0) {
            return;
        }
        try {
            JSONObject jSONObject = new JSONObject();
            Object canonicalName = fragment.getClass().getCanonicalName();
            String strA = q.a(fragment, getToken());
            Activity activity = fragment.getActivity();
            if (activity != null) {
                if (TextUtils.isEmpty(strA)) {
                    strA = q.a(activity);
                }
                canonicalName = String.format(Locale.CHINA, "%s|%s", activity.getClass().getCanonicalName(), canonicalName);
            }
            if (!TextUtils.isEmpty(strA) && !TDPresetProperties.disableList.contains("#title")) {
                jSONObject.put("#title", strA);
            }
            if (!TDPresetProperties.disableList.contains("#screen_name")) {
                jSONObject.put("#screen_name", canonicalName);
            }
            if (!(fragment instanceof ScreenAutoTracker)) {
                autoTrack("ta_app_view", jSONObject);
                return;
            }
            ScreenAutoTracker screenAutoTracker = (ScreenAutoTracker) fragment;
            String screenUrl = screenAutoTracker.getScreenUrl();
            JSONObject trackProperties = screenAutoTracker.getTrackProperties();
            if (trackProperties != null) {
                q.a(trackProperties, jSONObject, this.mConfig.getDefaultTimeZone());
            }
            trackViewScreenInternal(screenUrl, jSONObject);
        } catch (Exception e2) {
            TDLog.i(TAG, "trackViewScreen:" + e2);
        }
    }

    public void trackViewScreen(Object obj) {
        Class<?> cls;
        Class<?> cls2;
        Class<?> cls3;
        if (getStatusHasDisabled() || obj == null) {
            return;
        }
        Activity activity = null;
        try {
            cls = Class.forName("androidx.fragment.app.Fragment");
        } catch (Exception unused) {
            cls = null;
        }
        try {
            cls2 = Class.forName("android.app.Fragment");
        } catch (Exception unused2) {
            cls2 = null;
        }
        try {
            cls3 = Class.forName("androidx.fragment.app.Fragment");
        } catch (Exception unused3) {
            cls3 = null;
        }
        if ((cls == null || !cls.isInstance(obj)) && ((cls2 == null || !cls2.isInstance(obj)) && (cls3 == null || !cls3.isInstance(obj)))) {
            return;
        }
        try {
            JSONObject jSONObject = new JSONObject();
            Object canonicalName = obj.getClass().getCanonicalName();
            String strA = q.a(obj, getToken());
            try {
                activity = (Activity) obj.getClass().getMethod("getActivity", new Class[0]).invoke(obj, new Object[0]);
            } catch (Exception unused4) {
            }
            if (activity != null) {
                if (TextUtils.isEmpty(strA)) {
                    strA = q.a(activity);
                }
                canonicalName = String.format(Locale.CHINA, "%s|%s", activity.getClass().getCanonicalName(), canonicalName);
            }
            if (!TextUtils.isEmpty(strA) && !TDPresetProperties.disableList.contains("#title")) {
                jSONObject.put("#title", strA);
            }
            if (!TDPresetProperties.disableList.contains("#screen_name")) {
                jSONObject.put("#screen_name", canonicalName);
            }
            if (!(obj instanceof ScreenAutoTracker)) {
                autoTrack("ta_app_view", jSONObject);
                return;
            }
            ScreenAutoTracker screenAutoTracker = (ScreenAutoTracker) obj;
            String screenUrl = screenAutoTracker.getScreenUrl();
            JSONObject trackProperties = screenAutoTracker.getTrackProperties();
            if (trackProperties != null) {
                q.a(trackProperties, jSONObject, this.mConfig.getDefaultTimeZone());
            }
            trackViewScreenInternal(screenUrl, jSONObject);
        } catch (Exception e2) {
            e2.printStackTrace();
        }
    }

    public void trackViewScreenInternal(String str, JSONObject jSONObject) {
        if (getStatusHasDisabled()) {
            return;
        }
        try {
            if (TextUtils.isEmpty(str) && jSONObject == null) {
                return;
            }
            JSONObject jSONObject2 = new JSONObject();
            if (!TextUtils.isEmpty(this.mLastScreenUrl) && !TDPresetProperties.disableList.contains("#referrer")) {
                jSONObject2.put("#referrer", this.mLastScreenUrl);
            }
            if (!TDPresetProperties.disableList.contains("#url")) {
                jSONObject2.put("#url", str);
            }
            this.mLastScreenUrl = str;
            if (jSONObject != null) {
                q.a(jSONObject, jSONObject2, this.mConfig.getDefaultTimeZone());
            }
            autoTrack("ta_app_view", jSONObject2);
        } catch (JSONException e2) {
            TDLog.i(TAG, "trackViewScreen:" + e2);
        }
    }

    public void trackWithDebugOnly(String str, JSONObject jSONObject) {
        track(str, jSONObject, this.mCalibratedTimeManager.a(), false, null, null, 2);
    }

    public void unsetSuperProperty(String str) {
        if (getStatusHasDisabled()) {
            return;
        }
        cn.thinkingdata.analytics.g.a.a().a(new l(str));
    }

    public void user_add(String str, Number number) {
        this.mUserOperationHandler.a(str, number);
    }

    public void user_add(JSONObject jSONObject) {
        this.mUserOperationHandler.a(jSONObject, (Date) null);
    }

    public void user_add(JSONObject jSONObject, Date date) {
        this.mUserOperationHandler.a(jSONObject, date);
    }

    public void user_append(JSONObject jSONObject) {
        this.mUserOperationHandler.b(jSONObject, null);
    }

    public void user_append(JSONObject jSONObject, Date date) {
        this.mUserOperationHandler.b(jSONObject, date);
    }

    public void user_delete() {
        this.mUserOperationHandler.a((Date) null);
    }

    public void user_delete(Date date) {
        this.mUserOperationHandler.a(date);
    }

    public void user_operations(cn.thinkingdata.analytics.h.k kVar, JSONObject jSONObject, Date date) {
        this.mUserOperationHandler.a(kVar, jSONObject, date);
    }

    public void user_set(JSONObject jSONObject) {
        this.mUserOperationHandler.c(jSONObject, null);
    }

    public void user_set(JSONObject jSONObject, Date date) {
        this.mUserOperationHandler.c(jSONObject, date);
    }

    public void user_setOnce(JSONObject jSONObject) {
        this.mUserOperationHandler.d(jSONObject, null);
    }

    public void user_setOnce(JSONObject jSONObject, Date date) {
        this.mUserOperationHandler.d(jSONObject, date);
    }

    public void user_uniqAppend(JSONObject jSONObject) {
        this.mUserOperationHandler.e(jSONObject, null);
    }

    public void user_uniqAppend(JSONObject jSONObject, Date date) {
        this.mUserOperationHandler.e(jSONObject, date);
    }

    public void user_unset(JSONObject jSONObject, Date date) {
        this.mUserOperationHandler.f(jSONObject, date);
    }

    public void user_unset(String... strArr) {
        this.mUserOperationHandler.a(strArr);
    }
}

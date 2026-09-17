package com.sigmob.windad;

import android.app.Activity;
import android.content.Context;
import android.os.Handler;
import android.os.Looper;
import android.text.TextUtils;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.Constants;
import com.czhj.sdk.common.utils.ResourceUtil;
import com.czhj.sdk.logger.SigmobLog;
import com.kuaishou.weapon.p0.g;
import com.sigmob.sdk.Sigmob;
import com.sigmob.sdk.b;
import com.sigmob.sdk.base.i;
import com.sigmob.sdk.base.n;
import com.sigmob.sdk.base.o;
import com.sigmob.sdk.base.utils.k;
import com.sigmob.windad.consent.ConsentStatus;
import com.sigmob.windad.consent.WindAdConsentInformation;
import java.util.ArrayList;
import java.util.concurrent.CountDownLatch;
import java.util.concurrent.TimeUnit;
import java.util.logging.Level;

/* JADX INFO: loaded from: classes4.dex */
public class WindAds {
    public static final String ADN_ID = "ADN_ID";
    public static final String ADX_ID = "_adx_id";
    public static final String AD_SCENE_DESC = "scene_desc";
    public static final String AD_SCENE_ID = "scene_id";
    public static final String AUCTION_PRICE = "AUCTION_PRICE";
    public static final String CNY = "CNY";
    public static final String CURRENCY = "CURRENCY";
    public static final String HIGHEST_LOSS_PRICE = "HIGHEST_LOSS_PRICE";
    public static final String LOSS_REASON = "LOSS_REASON";
    public static final String REWARD_TYPE = "reward_type";
    public static final String SAAS_OPTIONS = "saas_options";
    public static final String SERVER_ARRIVED = "server_arrived";
    public static final String TAG = "WindAds";
    public static final String TRANS_ID = "trans_id";
    public static final String USD = "USD";

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static volatile WindAds f3705a;
    private boolean e;
    private OnInitializationListener g;
    private int i;
    private int k;
    private int l;
    private Context m;
    private volatile boolean b = false;
    private volatile boolean c = false;
    private boolean h = true;
    private boolean j = true;
    private boolean n = true;
    private final CountDownLatch o = new CountDownLatch(1);
    private WindAdOptions d = null;
    private Handler f = new Handler(Looper.getMainLooper());

    /* JADX INFO: renamed from: com.sigmob.windad.WindAds$2, reason: invalid class name */
    static /* synthetic */ class AnonymousClass2 {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        static final /* synthetic */ int[] f3707a;

        static {
            int[] iArr = new int[ConsentStatus.values().length];
            f3707a = iArr;
            try {
                iArr[ConsentStatus.ACCEPT.ordinal()] = 1;
            } catch (NoSuchFieldError unused) {
            }
            try {
                f3707a[ConsentStatus.DENIED.ordinal()] = 2;
            } catch (NoSuchFieldError unused2) {
            }
            try {
                f3707a[ConsentStatus.UNKNOWN.ordinal()] = 3;
            } catch (NoSuchFieldError unused3) {
            }
        }
    }

    private WindAds() {
    }

    private void a(String error) {
        k.f(TAG, "notifyInitError: error = " + error, new Object[0]);
        OnInitializationListener onInitializationListener = this.g;
        if (onInitializationListener == null) {
            return;
        }
        onInitializationListener.onInitializationFail(error);
    }

    private void b() {
        k.b(TAG, "notifyInitSuccess", new Object[0]);
        OnInitializationListener onInitializationListener = this.g;
        if (onInitializationListener == null) {
            return;
        }
        onInitializationListener.onInitializationSuccess();
    }

    /* JADX WARN: Code duplicated, block: B:12:0x002d A[Catch: all -> 0x002f, PHI: r1
  0x002d: PHI (r1v2 int) = (r1v1 int), (r1v3 int) binds: [B:8:0x0027, B:10:0x002a] A[DONT_GENERATE, DONT_INLINE], TRY_LEAVE, TryCatch #1 {all -> 0x002f, blocks: (B:7:0x0012, B:12:0x002d), top: B:19:0x0012 }] */
    private void c() {
        if (this.i == 0) {
            try {
                this.i = i.a().g();
            } catch (Throwable unused) {
            }
            if (this.i == 0) {
                try {
                    int i = AnonymousClass2.f3707a[WindAdConsentInformation.getInstance(b.e()).getConsentStatus().ordinal()];
                    int i2 = 1;
                    if (i != 1) {
                        i2 = 2;
                        if (i == 2) {
                            this.i = i2;
                        }
                    } else {
                        this.i = i2;
                    }
                } catch (Throwable unused2) {
                }
            }
        }
        i.a().c(this.i, false);
    }

    private void d() {
        try {
            if (this.k == 0) {
                this.k = i.a().c();
            } else {
                i.a().b(this.k, false);
            }
            if (this.l == 0) {
                this.l = i.a().b();
            } else {
                i.a().a(this.l, false);
            }
        } catch (Throwable unused) {
        }
    }

    private void e() {
        try {
            d();
            c();
            i.a().b(this.j, false);
            i.a().a(this.h, false);
        } catch (Throwable th) {
            SigmobLog.e("loadPrivacyInfo: error = " + th.getMessage());
        }
    }

    private void f() {
    }

    public static String getUserId() {
        return ClientMetadata.getUserId();
    }

    public static String getVersion() {
        return "4.25.14";
    }

    public static void requestPermission(Activity activity) {
        if (activity == null || ClientMetadata.isPermissionGranted(activity, g.c)) {
            return;
        }
        activity.requestPermissions(new String[]{g.c}, 0);
    }

    public static void setOAIDCertPem(String certPem) {
        if (TextUtils.isEmpty(certPem)) {
            k.e(TAG, "certPem is unavailable.", new Object[0]);
            return;
        }
        try {
            ClientMetadata.setOAIDCertPem(certPem);
        } catch (Throwable unused) {
            k.f(TAG, "not support OAID module.", new Object[0]);
        }
    }

    public static void setUserId(String userId) {
        ClientMetadata.setUserId(userId);
    }

    public static WindAds sharedAds() {
        if (f3705a == null) {
            synchronized (WindAds.class) {
                if (f3705a == null) {
                    WindAds windAds = new WindAds();
                    windAds.setDebugEnable(true);
                    f3705a = windAds;
                }
            }
        }
        return f3705a;
    }

    protected int a() {
        return 159;
    }

    public void checkAndResGuard(Context context) {
        if (ResourceUtil.getLayoutId(context, "sig_new_interstitial_layout") != 0) {
            return;
        }
        k.f(TAG, "The Wind SDK resources may have been obfuscated by AndResGuard. Please add the following " + new ArrayList<String>() { // from class: com.sigmob.windad.WindAds.1
            {
                add("R.string.sig_*");
                add("R.integer.sig_*");
                add("R.layout.sig_*");
                add("R.drawable.sig_*");
                add("R.style.sig_*");
                add("R.dimen.sig_*");
                add("R.anim.sig_*");
                add("R.color.sig_*");
                add("R.id.sig_*");
                add("R.attr.sig_*");
            }
        } + " to the whitelist.", new Object[0]);
    }

    public int getAgeRestrictedStatus() {
        return this.k;
    }

    public String getAppId() {
        WindAdOptions windAdOptions = this.d;
        if (windAdOptions == null) {
            return null;
        }
        return windAdOptions.getAppId();
    }

    public String getAppKey() {
        WindAdOptions windAdOptions = this.d;
        if (windAdOptions == null) {
            return null;
        }
        return windAdOptions.getAppKey();
    }

    public int getCommonVersion() {
        try {
            return Constants.getVersion();
        } catch (Throwable unused) {
            return 201;
        }
    }

    public Handler getHandler() {
        if (this.f == null) {
            this.f = new Handler(Looper.getMainLooper());
        }
        return this.f;
    }

    public WindAdOptions getOptions() {
        return this.d;
    }

    public String getSDKToken() {
        if (this.c) {
            k.c(TAG, "getSDKToken: SDK is ready, Retrieving token.", new Object[0]);
            return Sigmob.getInstance().getSDKToken();
        }
        try {
            this.o.await(o.a().ag(), TimeUnit.MILLISECONDS);
            if (this.c) {
                k.c(TAG, "getSDKToken(await): SDK is ready, Retrieving token.", new Object[0]);
                return Sigmob.getInstance().getSDKToken();
            }
        } catch (Exception e) {
            k.f(TAG, "getSDKToken: error = " + e.getMessage(), new Object[0]);
        }
        k.f(TAG, "getSDKToken: SDK is not ready, Cannot retrieve token.", new Object[0]);
        return null;
    }

    public boolean getSensorStatus() {
        return this.n;
    }

    public int getUserAge() {
        return this.l;
    }

    public int getUserGDPRConsentStatus() {
        return this.i;
    }

    public String getWindUid() {
        try {
            return ClientMetadata.getUid();
        } catch (Exception e) {
            SigmobLog.e("getWindUid: error = " + e.getMessage());
            return null;
        }
    }

    public boolean init(Context context, WindAdOptions options, OnInitializationListener onInitializationListener) {
        synchronized (this) {
            this.g = onInitializationListener;
            if (!this.b) {
                if (context == null) {
                    a("context is null.");
                    return false;
                }
                if (options == null) {
                    a("WindAdOptions is null.");
                    return false;
                }
                if (TextUtils.isEmpty(options.getAppId())) {
                    a("appId is empty.");
                    return false;
                }
                int commonVersion = getCommonVersion();
                if (commonVersion < 201) {
                    a("Your COMMON Lib version must be equal or higher than 201, current Version [ " + commonVersion + " ]");
                    return false;
                }
                this.d = options;
                this.m = context.getApplicationContext();
                this.b = true;
                checkAndResGuard(context);
                f();
            }
            b();
            return true;
        }
    }

    public boolean isAdult() {
        return this.h;
    }

    public boolean isDebugEnable() {
        return this.e;
    }

    public boolean isInit() {
        return this.b;
    }

    public boolean isPersonalizedAdvertisingOn() {
        return this.j;
    }

    public void setAdult(boolean isAdult) {
        this.h = isAdult;
        k.b(TAG, "setAdult: result = " + isAdult, new Object[0]);
        if (this.c) {
            i.a().a(isAdult, true);
        }
    }

    /* JADX WARN: Code duplicated, block: B:8:0x0014  */
    public void setDebugEnable(boolean enable) {
        Level level;
        this.e = enable;
        if (n.f.booleanValue()) {
            if (enable) {
                level = Level.FINE;
            } else {
                level = Level.SEVERE;
            }
        } else if (enable) {
            level = Level.INFO;
        } else {
            level = Level.SEVERE;
        }
        SigmobLog.setSdkHandlerLevel(level);
    }

    public void setIsAgeRestrictedUser(int windAgeRestrictedStatus) {
        this.k = windAgeRestrictedStatus;
        if (this.c) {
            i.a().b(windAgeRestrictedStatus, true);
        }
    }

    public void setOAIDCertFileName(String fileName) {
        ClientMetadata.setOaidCertFileName(fileName);
    }

    public void setPersonalizedAdvertisingOn(boolean isPersonalizedAdvertisingOn) {
        this.j = isPersonalizedAdvertisingOn;
        k.b(TAG, "setPersonalized: result = " + isPersonalizedAdvertisingOn, new Object[0]);
        if (this.c) {
            i.a().b(isPersonalizedAdvertisingOn, true);
        }
    }

    public void setSensorStatus(boolean status) {
        this.n = status;
        k.b(TAG, "setSensorStatus: status = " + status, new Object[0]);
    }

    public void setUserAge(int userAge) {
        this.l = userAge;
        if (this.c) {
            i.a().a(userAge, true);
        }
    }

    public void setUserGDPRConsentStatus(int windConsentStatus) {
        this.i = windConsentStatus;
        if (this.c) {
            i.a().c(windConsentStatus, true);
        }
    }

    public void start(OnStartListener onStartListener) {
        synchronized (this) {
            if (this.b) {
                if (!this.c) {
                    try {
                        b.a(this.m.getApplicationContext());
                        e();
                        Sigmob.getInstance().init();
                        this.c = true;
                        k.b(TAG, "start: appId = " + getAppId(), new Object[0]);
                        this.o.countDown();
                    } catch (Throwable th) {
                        if (onStartListener != null) {
                            try {
                                onStartListener.onStartFail("Wind SDK Start fail Exception " + th.getMessage());
                            } finally {
                                this.o.countDown();
                            }
                        }
                        k.f(TAG, "start: error = " + th.getMessage(), new Object[0]);
                        return;
                    }
                }
                if (onStartListener == null) {
                } else {
                    onStartListener.onStartSuccess();
                }
            } else if (onStartListener == null) {
            } else {
                onStartListener.onStartFail("Wind SDK Start fail, need Init SDK first.");
            }
        }
    }
}

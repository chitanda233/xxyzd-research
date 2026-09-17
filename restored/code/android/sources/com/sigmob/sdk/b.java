package com.sigmob.sdk;

import android.app.Activity;
import android.app.Application;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.content.pm.PackageInfo;
import android.hardware.Sensor;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.location.Location;
import android.media.AudioManager;
import android.net.Uri;
import android.os.Handler;
import android.os.Looper;
import android.util.Base64;
import com.bykv.vk.component.ttvideo.player.MediaFormat;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.ThreadPool.ThreadPoolFactory;
import com.czhj.sdk.common.mta.DeviceContext;
import com.czhj.sdk.common.network.Networking;
import com.czhj.sdk.common.utils.AdLifecycleManager;
import com.czhj.sdk.common.utils.RomUtils;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.BaseAdActivity;
import com.sigmob.sdk.base.common.AdActivity;
import com.sigmob.sdk.base.common.ad;
import com.sigmob.sdk.base.common.ag;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.mta.PointCategory;
import com.sigmob.sdk.base.mta.PointEntityActive;
import com.sigmob.sdk.base.n;
import com.sigmob.sdk.base.o;
import com.sigmob.sdk.base.utils.h;
import com.sigmob.sdk.base.utils.s;
import com.sigmob.sdk.base.utils.v;
import com.sigmob.sdk.manager.d;
import com.sigmob.windad.WindAdOptions;
import com.sigmob.windad.WindAds;
import com.sigmob.windad.WindCustomController;
import java.lang.ref.WeakReference;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.UUID;

/* JADX INFO: loaded from: classes2.dex */
public class b {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static WeakReference<Activity> f3121a = null;
    private static Context b = null;
    private static a c = null;
    private static WeakReference<Activity> d = null;
    private static boolean e = false;
    private static DeviceContext f;
    private static Handler g = new Handler(Looper.getMainLooper());
    private static C0556b h;

    /* JADX INFO: Access modifiers changed from: private */
    static class a implements AdLifecycleManager.LifecycleListener {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private String f3122a;
        private long b;
        private String d;
        private int e;
        private boolean i;
        private final BroadcastReceiver k;
        private final Map<String, String> c = new HashMap();
        private boolean f = true;
        private boolean g = false;
        private boolean h = false;
        private int j = 0;

        a() {
            BroadcastReceiver broadcastReceiver = new BroadcastReceiver() { // from class: com.sigmob.sdk.b.a.1
                @Override // android.content.BroadcastReceiver
                public void onReceive(Context context, Intent intent) {
                    String str;
                    String action = intent.getAction();
                    if (s.a((CharSequence) action)) {
                        return;
                    }
                    byte b = 2;
                    String strEncodeToString = Base64.encodeToString(action.getBytes(), 2);
                    strEncodeToString.hashCode();
                    switch (strEncodeToString.hashCode()) {
                        case -252353173:
                            b = !strEncodeToString.equals(n.O) ? (byte) -1 : (byte) 0;
                            break;
                        case 1349729289:
                            b = !strEncodeToString.equals(n.N) ? (byte) -1 : (byte) 1;
                            break;
                        case 1349784159:
                            if (!strEncodeToString.equals(n.M)) {
                                b = -1;
                            }
                            break;
                        default:
                            b = -1;
                            break;
                    }
                    switch (b) {
                        case 0:
                            SigmobLog.d("screen user present");
                            d.a().a(false);
                            str = PointCategory.UNLOCK;
                            break;
                        case 1:
                            SigmobLog.d("screen off");
                            d.a().a(true);
                            str = PointCategory.LOCKED;
                            break;
                        case 2:
                            SigmobLog.d("screen on");
                            str = PointCategory.SCREEN_ON;
                            break;
                        default:
                            return;
                    }
                    ad.a(str, (String) null, (BaseAdUnit) null, (ad.a) null);
                }
            };
            this.k = broadcastReceiver;
            AdLifecycleManager.getInstance().initialize(b.h());
            this.b = System.currentTimeMillis();
            this.f3122a = UUID.randomUUID().toString();
            SigmobLog.i("session_start: " + this.b + ":" + this.f3122a);
            PointEntityActive.ActiveTracking(PointCategory.SESSION_START, this.f3122a, "0", String.valueOf(this.b));
            AdLifecycleManager.getInstance().addLifecycleListener(this);
            try {
                IntentFilter intentFilter = new IntentFilter();
                intentFilter.addAction(new String(Base64.decode(n.M, 2)));
                intentFilter.addAction(new String(Base64.decode(n.N, 2)));
                intentFilter.addAction(new String(Base64.decode(n.O, 2)));
                h.a(b.b, broadcastReceiver, intentFilter);
            } catch (Throwable th) {
                SigmobLog.e("register screen status receiver error" + th.getMessage());
            }
        }

        public int a() {
            return this.e;
        }

        public void a(Activity activity) {
        }

        public void a(Activity activity, int reqCode, int resCode, Intent data) {
        }

        public void b(Activity activity) {
        }

        @Override // com.czhj.sdk.common.utils.AdLifecycleManager.LifecycleListener
        public void onCreate(Activity activity) {
            String simpleName = activity.getClass().getSimpleName();
            this.d = simpleName;
            this.c.put(simpleName, simpleName);
            this.f = true;
            this.g = false;
        }

        @Override // com.czhj.sdk.common.utils.AdLifecycleManager.LifecycleListener
        public void onDestroy(Activity activity) {
            if (activity instanceof AdActivity) {
                this.i = false;
            }
            this.c.remove(activity.getClass().getSimpleName());
            if (this.c.isEmpty() && this.f) {
                long jCurrentTimeMillis = System.currentTimeMillis();
                long j = (jCurrentTimeMillis - this.b) / 1000;
                SigmobLog.i("onActivityDestroyed session_end: " + jCurrentTimeMillis + ":" + this.f3122a + ":" + j);
                PointEntityActive.ActiveTracking(PointCategory.SESSION_END, this.f3122a, String.valueOf(j), String.valueOf(jCurrentTimeMillis));
                this.b = System.currentTimeMillis();
                this.f = false;
            }
            if (this.c.isEmpty()) {
                this.h = true;
            }
        }

        @Override // com.czhj.sdk.common.utils.AdLifecycleManager.LifecycleListener
        public void onPause(Activity activity) {
            int i;
            if (RomUtils.isHuawei()) {
                int i2 = this.j;
                if (i2 == 0) {
                    i = 1;
                } else if (i2 != 2) {
                    if (i2 == 3) {
                        b.g.removeCallbacksAndMessages(null);
                        return;
                    }
                    i = 0;
                }
                this.j = i;
                return;
            }
            this.j = 3;
        }

        @Override // com.czhj.sdk.common.utils.AdLifecycleManager.LifecycleListener
        public void onResume(final Activity activity) {
            if (activity instanceof AdActivity) {
                this.i = true;
            } else if (!this.i) {
                WeakReference unused = b.d = new WeakReference(activity);
            }
            if (RomUtils.isHuawei()) {
                int i = this.j;
                if (i == 1) {
                    this.j = 2;
                } else if (i == 3) {
                    b.g.postDelayed(new Runnable() { // from class: com.sigmob.sdk.b$a$$ExternalSyntheticLambda0
                        @Override // java.lang.Runnable
                        public final void run() {
                            b.b(activity);
                        }
                    }, 500L);
                }
            } else {
                b.c(activity);
            }
            this.g = !activity.getClass().getSimpleName().equals(this.d);
            this.d = activity.getClass().getSimpleName();
            if (this.g) {
                WeakReference unused2 = b.f3121a = new WeakReference(activity);
            }
            if (!this.f || this.h) {
                this.h = false;
                this.f3122a = UUID.randomUUID().toString();
                this.b = System.currentTimeMillis();
                this.f = true;
                SigmobLog.i("onActivityResumed session_start: " + this.b + ":" + this.f3122a);
                PointEntityActive.ActiveTracking(PointCategory.SESSION_START, this.f3122a, "0", String.valueOf(this.b));
            }
        }

        @Override // com.czhj.sdk.common.utils.AdLifecycleManager.LifecycleListener
        public void onStart(Activity activity) {
            this.j = 0;
            this.e++;
        }

        @Override // com.czhj.sdk.common.utils.AdLifecycleManager.LifecycleListener
        public void onStop(Activity activity) {
            this.e--;
            b.g.removeCallbacksAndMessages(null);
            Activity activityI = b.i();
            String simpleName = activity.getClass().getSimpleName();
            if (simpleName.equals(this.d) || (v.b(activityI) && simpleName.equals(activityI.getClass().getSimpleName()))) {
                b.j();
                if (!this.g || this.c.size() == 1) {
                    long jCurrentTimeMillis = System.currentTimeMillis();
                    long j = (jCurrentTimeMillis - this.b) / 1000;
                    SigmobLog.i("onActivityStopped session_end: " + jCurrentTimeMillis + ":" + this.f3122a + ":" + j);
                    PointEntityActive.ActiveTracking(PointCategory.SESSION_END, this.f3122a, String.valueOf(j), String.valueOf(jCurrentTimeMillis));
                    this.b = System.currentTimeMillis();
                    this.f = false;
                }
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* JADX INFO: renamed from: com.sigmob.sdk.b$b, reason: collision with other inner class name */
    static class C0556b implements SensorEventListener {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private static final int f3124a = 1000;
        private volatile Boolean b = null;

        C0556b() {
            b();
            c();
        }

        private void b() {
            if (b.b == null) {
                return;
            }
            ag.a(b.b).a(this);
        }

        private void c() {
            ThreadPoolFactory.BackgroundThreadPool.getInstance().getIOHandler().postDelayed(new Runnable() { // from class: com.sigmob.sdk.b$b$$ExternalSyntheticLambda0
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.e();
                }
            }, 1000L);
        }

        private void d() {
            if (b.b == null) {
                return;
            }
            ag.a(b.b).b(this);
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void e() {
            if (this.b == null) {
                this.b = false;
            }
        }

        public Boolean a() {
            if (this.b == null) {
                return true;
            }
            return this.b;
        }

        @Override // android.hardware.SensorEventListener
        public void onAccuracyChanged(Sensor sensor, int accuracy) {
        }

        @Override // android.hardware.SensorEventListener
        public void onSensorChanged(SensorEvent sensorEvent) {
            this.b = true;
            d();
        }
    }

    public static String a() {
        return "";
    }

    public static void a(Activity activity) {
        if (activity == null) {
            return;
        }
        f3121a = new WeakReference<>(activity);
    }

    public static synchronized void a(Context context) {
        if (b == null) {
            Context applicationContext = context.getApplicationContext();
            b = applicationContext;
            com.sigmob.sdk.base.utils.n.a(applicationContext, n.o);
            o.a().e();
            b(b);
            com.sigmob.sdk.base.db.a.a(b);
            ClientMetadata.getInstance().initialize(b);
            n();
        }
    }

    public static void a(boolean hasAdLoaded) {
        e = hasAdLoaded;
    }

    public static DeviceContext b() {
        DeviceContext deviceContext = f;
        if (deviceContext != null || b == null) {
            return deviceContext;
        }
        DeviceContext deviceContext2 = new DeviceContext() { // from class: com.sigmob.sdk.b.1
            private WindCustomController a() {
                return WindAds.sharedAds().getOptions().getCustomController();
            }

            @Override // com.czhj.sdk.common.mta.DeviceContext
            public boolean allowReadSpaceSize() {
                WindCustomController windCustomControllerA = a();
                return v.b(windCustomControllerA) && windCustomControllerA.isCanUseSpaceSize();
            }

            @Override // com.czhj.sdk.common.mta.DeviceContext
            public String getAndroidId() {
                WindCustomController windCustomControllerA = a();
                if ((windCustomControllerA == null || windCustomControllerA.isCanUseAndroidId()) && b.e && WindAds.sharedAds().isPersonalizedAdvertisingOn()) {
                    return ClientMetadata.getInstance().getAndroidId();
                }
                if (windCustomControllerA == null || windCustomControllerA.isCanUseAndroidId()) {
                    return null;
                }
                return windCustomControllerA.getAndroidId();
            }

            @Override // com.czhj.sdk.common.mta.DeviceContext
            public String getCarrier() {
                if (o.a().j()) {
                    return null;
                }
                WindCustomController windCustomControllerA = a();
                if (windCustomControllerA != null && !windCustomControllerA.isCanUseSimOperator()) {
                    return windCustomControllerA.getDevSimOperatorCode();
                }
                String networkOperatorForUrl = ClientMetadata.getInstance().getNetworkOperatorForUrl();
                SigmobLog.d(String.format("SDKContext: simOperator = %s", networkOperatorForUrl));
                return networkOperatorForUrl;
            }

            @Override // com.czhj.sdk.common.mta.DeviceContext
            public String getCarrierName() {
                if (o.a().j()) {
                    return null;
                }
                WindCustomController windCustomControllerA = a();
                if (windCustomControllerA != null && !windCustomControllerA.isCanUseSimOperator()) {
                    return windCustomControllerA.getDevSimOperatorName();
                }
                String networkOperatorName = ClientMetadata.getInstance().getNetworkOperatorName();
                SigmobLog.d(String.format("SDKContext: carrierName = %s", networkOperatorName));
                return networkOperatorName;
            }

            @Override // com.czhj.sdk.common.mta.DeviceContext
            public String getImei() {
                WindCustomController windCustomControllerA = a();
                if (((windCustomControllerA == null || windCustomControllerA.isCanUsePhoneState()) && b.e && WindAds.sharedAds().isPersonalizedAdvertisingOn()) || windCustomControllerA == null || windCustomControllerA.isCanUsePhoneState()) {
                    return null;
                }
                return windCustomControllerA.getDevImei();
            }

            @Override // com.czhj.sdk.common.mta.DeviceContext
            public String getImei1() {
                WindCustomController windCustomControllerA = a();
                if (((windCustomControllerA == null || windCustomControllerA.isCanUsePhoneState()) && b.e && WindAds.sharedAds().isPersonalizedAdvertisingOn()) || windCustomControllerA == null || windCustomControllerA.isCanUsePhoneState()) {
                    return null;
                }
                return windCustomControllerA.getDevImei();
            }

            @Override // com.czhj.sdk.common.mta.DeviceContext
            public String getImei2() {
                WindCustomController windCustomControllerA = a();
                if (((windCustomControllerA == null || windCustomControllerA.isCanUsePhoneState()) && b.e && WindAds.sharedAds().isPersonalizedAdvertisingOn()) || windCustomControllerA == null || windCustomControllerA.isCanUsePhoneState()) {
                    return null;
                }
                return windCustomControllerA.getDevImei();
            }

            @Override // com.czhj.sdk.common.mta.DeviceContext
            public Location getLocation() {
                if (o.a().P()) {
                    return null;
                }
                WindCustomController windCustomControllerA = a();
                return (windCustomControllerA == null || windCustomControllerA.isCanUseLocation()) ? ClientMetadata.getInstance().getLocation() : windCustomControllerA.getLocation();
            }

            @Override // com.czhj.sdk.common.mta.DeviceContext
            public String getOaid() {
                WindCustomController windCustomControllerA = a();
                return (windCustomControllerA == null || windCustomControllerA.isCanUseOaid()) ? ClientMetadata.getInstance().getOAID() : windCustomControllerA.getDevOaid();
            }

            @Override // com.czhj.sdk.common.mta.DeviceContext
            public boolean isCustomAndroidId() {
                WindCustomController windCustomControllerA = a();
                return windCustomControllerA == null || windCustomControllerA.isCanUseAndroidId();
            }

            @Override // com.czhj.sdk.common.mta.DeviceContext
            public boolean isCustomOaId() {
                WindCustomController windCustomControllerA = a();
                return (windCustomControllerA == null || windCustomControllerA.isCanUseOaid()) ? false : true;
            }

            @Override // com.czhj.sdk.common.mta.DeviceContext
            public boolean isCustomOperatorCode() {
                WindCustomController windCustomControllerA = a();
                return (windCustomControllerA == null || windCustomControllerA.isCanUseSimOperator() || s.a((CharSequence) windCustomControllerA.getDevSimOperatorCode())) ? false : true;
            }

            @Override // com.czhj.sdk.common.mta.DeviceContext
            public boolean isCustomOperatorName() {
                WindCustomController windCustomControllerA = a();
                return (windCustomControllerA == null || windCustomControllerA.isCanUseSimOperator() || s.a((CharSequence) windCustomControllerA.getDevSimOperatorName())) ? false : true;
            }

            @Override // com.czhj.sdk.common.mta.DeviceContext
            public boolean isCustomPhoneState() {
                WindCustomController windCustomControllerA = a();
                return windCustomControllerA == null || windCustomControllerA.isCanUsePhoneState();
            }
        };
        f = deviceContext2;
        return deviceContext2;
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    public static /* synthetic */ void b(Activity activity) {
        c(activity);
    }

    private static void b(Context context) {
        Networking.AddSigmobServerURL(o.c());
        Networking.AddSigmobServerURL(o.a().a(false));
        Networking.AddSigmobServerURL(o.a().b(false));
        Networking.AddSigmobServerURL(o.a().r());
        Networking.initializeV2(context);
        Networking.initializeSigRequestQueue(context);
    }

    public static Activity c() {
        WeakReference<Activity> weakReference = d;
        if (weakReference == null) {
            return null;
        }
        return weakReference.get();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void c(Activity activity) {
        q();
        d(activity);
    }

    public static void d() {
        if (c == null) {
            c = new a();
        }
    }

    private static void d(Activity activity) {
        Uri uri;
        BaseAdUnit baseAdUnitM = com.sigmob.sdk.base.common.h.m();
        if (baseAdUnitM == null || activity == null) {
            return;
        }
        com.sigmob.sdk.base.common.h.d((BaseAdUnit) null);
        baseAdUnitM.getClickCommon().isDeeplink = "0";
        com.sigmob.sdk.manager.b.b(baseAdUnitM, com.sigmob.sdk.base.common.a.H, null);
        String landing_page = baseAdUnitM.getLanding_page();
        if (s.a((CharSequence) landing_page) || (uri = Uri.parse(landing_page)) == null) {
            return;
        }
        if (!baseAdUnitM.isSkipSigmobBrowser()) {
            com.sigmob.sdk.base.common.h.a(baseAdUnitM);
            AdActivity.a(activity, (Class<? extends BaseAdActivity>) AdActivity.class, baseAdUnitM.getUuid());
        } else {
            try {
                h.a(activity, uri);
            } catch (Throwable th) {
                SigmobLog.e("can't open load ", th);
            }
        }
    }

    public static Context e() {
        return b;
    }

    public static boolean f() {
        if (h == null) {
            h = new C0556b();
        }
        return h.a().booleanValue();
    }

    public static boolean g() {
        AudioManager audioManager;
        return (b == null || (audioManager = (AudioManager) e().getSystemService(MediaFormat.KEY_AUDIO)) == null || audioManager.getStreamVolume(3) != 0) ? false : true;
    }

    public static Application h() {
        Context context = b;
        if (context instanceof Application) {
            return (Application) context;
        }
        return null;
    }

    public static Activity i() {
        WeakReference<Activity> weakReference = f3121a;
        if (weakReference == null) {
            return null;
        }
        return weakReference.get();
    }

    public static void j() {
        o();
        p();
    }

    private static void n() {
        WindAdOptions options;
        WindCustomController customController;
        List<PackageInfo> installPackageInfoList;
        if (o.a().Q() || (options = WindAds.sharedAds().getOptions()) == null || (customController = options.getCustomController()) == null || customController.isCanUseAppList() || (installPackageInfoList = customController.getInstallPackageInfoList()) == null || installPackageInfoList.isEmpty()) {
            return;
        }
        Iterator<PackageInfo> it = installPackageInfoList.iterator();
        while (it.hasNext()) {
            ad.a(it.next(), 2);
        }
    }

    private static void o() {
        BaseAdUnit baseAdUnitF = com.sigmob.sdk.base.common.h.f();
        if (baseAdUnitF == null) {
            return;
        }
        com.sigmob.sdk.base.common.h.c((BaseAdUnit) null);
        com.sigmob.sdk.base.network.h.a(baseAdUnitF, "open_pkg");
        ad.a("open_pkg", "1", baseAdUnitF, (ad.a) null);
    }

    private static void p() {
        BaseAdUnit baseAdUnitM = com.sigmob.sdk.base.common.h.m();
        if (baseAdUnitM == null) {
            return;
        }
        com.sigmob.sdk.base.common.h.d((BaseAdUnit) null);
        baseAdUnitM.getClickCommon().isDeeplink = "1";
        Uri deeplinkUri = baseAdUnitM.getDeeplinkUri();
        com.sigmob.sdk.manager.b.b(baseAdUnitM, com.sigmob.sdk.base.common.a.G, deeplinkUri == null ? baseAdUnitM.getDeeplinkUrl() : deeplinkUri.toString());
    }

    private static void q() {
        BaseAdUnit baseAdUnitF = com.sigmob.sdk.base.common.h.f();
        if (baseAdUnitF == null) {
            return;
        }
        com.sigmob.sdk.base.common.h.c((BaseAdUnit) null);
        ad.a("open_pkg", "0", baseAdUnitF, (ad.a) null);
    }
}

package com.kwad.sdk;

import android.content.Context;
import android.os.SystemClock;
import android.text.TextUtils;
import android.util.Log;
import com.bykv.vk.component.ttvideo.mediakit.medialoader.AVMDLDataLoader;
import com.kwad.components.core.t.t;
import com.kwad.components.offline.api.BuildConfig;
import com.kwad.sdk.api.KsLoadManager;
import com.kwad.sdk.api.SdkConfig;
import com.kwad.sdk.api.loader.DynamicInstallReceiver;
import com.kwad.sdk.api.proxy.BaseProxyActivity;
import com.kwad.sdk.api.proxy.BaseProxyFragmentActivity;
import com.kwad.sdk.api.proxy.IComponentProxy;
import com.kwad.sdk.core.imageloader.ImageLoaderPerfUtil;
import com.kwad.sdk.core.response.model.SdkConfigData;
import com.kwad.sdk.core.threads.GlobalThreadPools;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ad;
import com.kwad.sdk.utils.ai;
import com.kwad.sdk.utils.at;
import com.kwad.sdk.utils.ba;
import com.kwad.sdk.utils.bf;
import com.kwad.sdk.utils.bj;
import com.kwad.sdk.utils.bv;
import java.io.File;
import java.util.Map;
import java.util.concurrent.TimeUnit;
import java.util.concurrent.atomic.AtomicBoolean;
import org.json.JSONArray;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class o {
    private long aGA;
    private long aGB;
    private g aGC;
    private g aGD;
    private g aGE;
    private g aGF;
    private volatile boolean aGG;
    private boolean aGH;
    private boolean aGI;
    private String aGJ;
    private volatile AtomicBoolean aGq;
    private volatile AtomicBoolean aGr;
    private volatile AtomicBoolean aGs;
    private volatile AtomicBoolean aGt;
    private AtomicBoolean aGu;
    private volatile Boolean aGv;
    private String aGw;
    private int aGx;
    private boolean aGy;
    private com.kwad.components.core.b aGz;
    private long alM;

    public static String getSDKVersion() {
        return BuildConfig.VERSION_NAME;
    }

    /* synthetic */ o(byte b) {
        this();
    }

    private o() {
        this.aGq = new AtomicBoolean(false);
        this.aGr = new AtomicBoolean(false);
        this.aGs = new AtomicBoolean(false);
        this.aGt = new AtomicBoolean(false);
        this.aGu = new AtomicBoolean(false);
        this.aGv = null;
        this.aGw = "";
        this.aGG = true;
        this.aGH = true;
        this.aGI = false;
    }

    static class a {
        private static final o aGN = new o(0);
    }

    public static o GE() {
        return a.aGN;
    }

    private static void a(Context context, SdkConfig sdkConfig) {
        if (sdkConfig != null) {
            com.kwad.sdk.service.b.holderSdkConfig(sdkConfig);
        }
        if (context != null) {
            ServiceProvider.cI(context);
        }
    }

    final synchronized void init(Context context, SdkConfig sdkConfig) {
        if (context != null && sdkConfig != null) {
            try {
                if (!TextUtils.isEmpty(sdkConfig.appId)) {
                    Log.d("KSAdSDK", "init appId:" + sdkConfig.appId + "--mIsSdkInit:" + this.aGq.get());
                    if (this.aGq.get()) {
                        a((Context) null, sdkConfig);
                        return;
                    }
                    a(context, sdkConfig);
                    if (bf(context)) {
                        Log.d("KSAdSDK", "intKSRemoteProcess appId=" + sdkConfig.appId);
                        ServiceProvider.Ul();
                        k.FA();
                        GV();
                        this.aGq.set(true);
                    } else {
                        try {
                            q.Hq();
                            GJ();
                            q.bi(context);
                        } catch (Throwable th) {
                            Log.e("KSAdSDK", "initSDKModule error", th);
                            String stackTraceString = Log.getStackTraceString(th);
                            q.a(th, stackTraceString);
                            f.a(sdkConfig, new e(AVMDLDataLoader.KeyIsStoPlayDldWinSizeKBLS, stackTraceString));
                            return;
                        }
                    }
                }
            } catch (Throwable th2) {
                Log.e("KSAdSDK", "init error", th2);
                String stackTraceString2 = Log.getStackTraceString(th2);
                q.a(th2, stackTraceString2);
                f.a(sdkConfig, new e(AVMDLDataLoader.KeyIsStoPlayDldWinSizeKBLS, stackTraceString2));
            }
            return;
        }
        Log.e("KSAdSDK", "KSAdSDK SDKInit:init error,please check appID and config item");
        f.a(sdkConfig, e.aFQ);
    }

    final synchronized void start() {
        boolean z;
        try {
            long jElapsedRealtime = SystemClock.elapsedRealtime();
            Log.d("KSAdSDK", "KSAdSDK start call");
            if (this.aGE == null) {
                this.aGE = g.ai(this.aGA);
            }
            this.aGE.report();
            SdkConfig sDKConfig = ServiceProvider.getSDKConfig();
            if (GH()) {
                z = false;
            } else {
                c(sDKConfig);
                z = true;
            }
            if (!this.aGq.get()) {
                f.b(sDKConfig, e.aFR);
                z = true;
            }
            if (this.aGr.get()) {
                c(sDKConfig);
                z = true;
            }
            if (!z) {
                GK();
                g(new com.kwad.sdk.g.a() { // from class: com.kwad.sdk.o.1
                    @Override // com.kwad.sdk.g.a
                    public final void accept(Object obj) {
                    }
                });
                com.kwad.sdk.a.a.c.Hx().Hz();
                com.kwad.components.core.p.a.vX().vY();
                g gVar = this.aGC;
                if (gVar != null) {
                    gVar.report();
                }
                g gVar2 = this.aGD;
                if (gVar2 != null) {
                    gVar2.report();
                }
                this.aGr.set(true);
                c(sDKConfig);
            }
            com.kwad.sdk.utils.i.schedule(new Runnable() { // from class: com.kwad.sdk.o.3
                @Override // java.lang.Runnable
                public final void run() {
                    if (com.kwad.sdk.core.config.e.KH()) {
                        com.kwad.sdk.resourceCache.b.cH(o.getContext());
                    }
                }
            }, com.kwad.sdk.core.config.e.KI(), TimeUnit.SECONDS);
            if (this.aGF == null) {
                this.aGF = g.aj(SystemClock.elapsedRealtime() - jElapsedRealtime);
            }
            this.aGE.report();
        } catch (Throwable th) {
            q.s(th);
        }
    }

    public final void b(final Context context, final SdkConfig sdkConfig) {
        Log.w("jky", "KSAdSDK initAsync call mIsSdkInit:" + this.aGq);
        this.aGs.set(true);
        if (this.aGq.get()) {
            a((Context) null, sdkConfig);
            return;
        }
        a(context, sdkConfig);
        GlobalThreadPools.Of().submit(new Runnable() { // from class: com.kwad.sdk.o.4
            @Override // java.lang.Runnable
            public final void run() {
                o.this.init(context, sdkConfig);
            }
        });
        f.a(sdkConfig);
    }

    public final void GF() {
        this.aGt.set(true);
        boolean zHh = GE().Hh();
        com.kwad.sdk.core.d.c.d("jky", "startAsync call: " + zHh);
        if (zHh) {
            return;
        }
        GlobalThreadPools.Of().submit(new Runnable() { // from class: com.kwad.sdk.o.5
            @Override // java.lang.Runnable
            public final void run() {
                o.this.start();
            }
        });
        f.b(ServiceProvider.getSDKConfig());
    }

    public final boolean GG() {
        return this.aGs.get() && this.aGt.get();
    }

    private static void c(SdkConfig sdkConfig) {
        f.c(sdkConfig);
    }

    public final boolean GH() {
        try {
            if (GI()) {
                Log.d("KSAdSDK", "enableInitStartMode return false hadLastTimeInitError");
                return false;
            }
            if (this.aGv == null) {
                this.aGv = Boolean.valueOf(com.kwad.sdk.core.config.e.GH());
            }
            if (!this.aGv.booleanValue()) {
                Log.d("KSAdSDK", "enableInitStartMode return false mConfigEnableInitStart");
                return false;
            }
            if (this.aGu.get()) {
                Log.d("KSAdSDK", "enableInitStartMode return true mApiHadStartMethod");
                return true;
            }
            Class.forName("com.kwad.sdk.api.core.IKsAdSDK").getDeclaredMethod("start", new Class[0]);
            this.aGu.set(true);
            Log.d("KSAdSDK", "enableInitStartMode return mApiHadStartMethod: " + this.aGu);
            return this.aGu.get();
        } catch (Throwable th) {
            Log.e("KSAdSDK", th.getMessage());
            th.printStackTrace();
            this.aGu.set(false);
        }
    }

    private boolean GI() {
        return q.bj(getContext());
    }

    private static boolean bf(Context context) {
        String processName = ba.getProcessName(context);
        return !TextUtils.isEmpty(processName) && processName.endsWith("kssdk_remote");
    }

    private void GJ() {
        long jElapsedRealtime = SystemClock.elapsedRealtime();
        this.alM = jElapsedRealtime;
        com.kwad.sdk.service.c.init();
        k.FA();
        GV();
        GW();
        boolean zGH = GH();
        Log.d("KSAdSDK", "initSDKModule enableInitStartMode: " + zGH);
        if (this.aGC == null) {
            this.aGC = g.ag(this.aGA);
        }
        if (!zGH) {
            this.aGC.report();
        }
        GM();
        GZ();
        Ha();
        Hg();
        GS();
        if (!zGH) {
            GK();
            g(null);
        }
        GO();
        GQ();
        GR();
        GX();
        He();
        Hc();
        com.kwad.sdk.wrapper.l.OE();
        GN();
        com.kwad.sdk.core.h.a.OE();
        if (!zGH) {
            com.kwad.sdk.a.a.c.Hx().Hz();
            com.kwad.components.core.p.a.vX().vY();
        }
        if (com.kwad.framework.a.a.oU.booleanValue()) {
            try {
                com.kwad.sdk.components.d.f(com.kwad.sdk.components.a.class);
            } catch (Exception unused) {
            }
        }
        long jElapsedRealtime2 = SystemClock.elapsedRealtime() - jElapsedRealtime;
        com.kwad.sdk.core.d.c.d("KSAdSDK", "KSAdSDK init time:" + jElapsedRealtime2);
        com.kwad.sdk.core.d.c.i("KSAdSDK", "SDK_VERSION_NAME: 5.3.20.1 TK_VERSION_CODE: 6.2.2 BRIDGE_VERSION: 1.3");
        if (this.aGD == null) {
            this.aGD = g.ah(jElapsedRealtime2);
        }
        if (!zGH) {
            this.aGD.report();
        }
        long j = GE().aGB;
        if (j > 0) {
            p.ao(SystemClock.elapsedRealtime() - j);
        }
        f.a(ServiceProvider.getSDKConfig(), j);
        this.aGq.set(true);
    }

    private void GK() {
        com.kwad.sdk.mobileid.a.init(getContext());
    }

    private void GL() {
        try {
            com.kwad.sdk.commercial.c.a(new com.kwad.sdk.commercial.c.a() { // from class: com.kwad.sdk.o.6
                @Override // com.kwad.sdk.commercial.c.a
                public final boolean Hj() {
                    return com.kwad.sdk.core.config.e.b(com.kwad.sdk.core.config.c.aND);
                }

                @Override // com.kwad.sdk.commercial.c.a
                public final boolean Hk() {
                    return com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aNC);
                }

                @Override // com.kwad.sdk.commercial.c.a
                public final JSONObject Hl() {
                    return com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aNO);
                }

                @Override // com.kwad.sdk.commercial.c.a
                public final JSONObject Hm() {
                    return com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aNP);
                }

                @Override // com.kwad.sdk.commercial.c.a
                public final void j(String str, String str2, boolean z) {
                    com.kwad.components.core.p.a.vX().e(str, str2, false);
                }

                @Override // com.kwad.sdk.commercial.c.a
                public final String Hn() {
                    return com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aQf);
                }
            }, this.aGy);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    private static void GM() {
        try {
            com.kwad.sdk.components.c.init(ServiceProvider.getContext());
        } catch (Throwable th) {
            q.s(th);
        }
    }

    private static void GN() {
        try {
            com.kwad.components.core.proxy.launchdialog.e.vV().init(ServiceProvider.getContext());
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    private static void GO() {
        try {
            com.kwad.components.core.d.a.initAsync(ServiceProvider.getContext());
        } catch (Throwable th) {
            q.s(th);
        }
    }

    private static void GP() {
        try {
            com.kwad.components.core.d.a.am(ServiceProvider.getContext());
        } catch (Throwable th) {
            q.s(th);
        }
    }

    private void GQ() {
        try {
            com.kwad.sdk.components.d.init(getContext());
        } catch (Throwable th) {
            q.s(th);
        }
    }

    private void GR() {
        try {
            com.kwad.components.core.offline.b.b.init(getContext());
        } catch (Throwable th) {
            q.s(th);
        }
    }

    private void GS() {
        ai.ap(ServiceProvider.getContext(), this.aGJ);
        this.aGJ = null;
    }

    private void g(final com.kwad.sdk.g.a aVar) {
        try {
            com.kwad.components.core.request.h.a(new com.kwad.components.core.request.h.b() { // from class: com.kwad.sdk.o.7
                @Override // com.kwad.components.core.request.h.b
                public final void wm() {
                    try {
                        com.kwad.sdk.g.a aVar2 = aVar;
                        if (aVar2 != null) {
                            aVar2.accept(null);
                        }
                    } catch (Throwable th) {
                        com.kwad.components.core.d.a.reportSdkCaughtException(th);
                    }
                }

                @Override // com.kwad.components.core.request.h.a
                public final void wl() {
                    com.kwad.sdk.core.d.c.i("KSAdSDK", "onCacheLoaded()");
                    o.this.GT();
                }

                @Override // com.kwad.components.core.request.h.a
                public final void d(SdkConfigData sdkConfigData) {
                    com.kwad.sdk.core.d.c.i("KSAdSDK", "onConfigRefresh()");
                    try {
                        o.this.e(sdkConfigData);
                        com.kwad.sdk.g.a aVar2 = aVar;
                        if (aVar2 != null) {
                            aVar2.accept(null);
                        }
                    } catch (Throwable th) {
                        com.kwad.components.core.d.a.reportSdkCaughtException(th);
                    }
                }
            });
        } catch (Throwable th) {
            q.s(th);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void GT() {
        try {
            Map<String, String> jSON2MapString = ad.parseJSON2MapString(com.kwad.sdk.core.config.c.aPI.getValue());
            for (String str : jSON2MapString.keySet()) {
                GlobalThreadPools.r(str, Integer.parseInt((String) requireNonNull(jSON2MapString.get(str))));
            }
            GlobalThreadPools.Od();
            com.kwad.sdk.core.config.c.aQC.getValue().booleanValue();
            GlobalThreadPools.Ob();
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    private static <T> T requireNonNull(T t) {
        t.getClass();
        return t;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void e(SdkConfigData sdkConfigData) {
        try {
            GP();
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.e("KSAdSDK", Log.getStackTraceString(th));
        }
        GL();
        GY();
        com.kwad.sdk.core.config.e.FE();
        if ((com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aNB) && ba.isInMainProcess(ServiceProvider.Um())) || com.kwad.framework.a.a.oV.booleanValue()) {
            DynamicInstallReceiver.registerToApp(ServiceProvider.Um());
        }
        if (com.kwad.sdk.core.config.e.Kw()) {
            com.kwad.sdk.b.a.init(com.kwad.sdk.wrapper.m.Yh());
        }
        Hd();
        bj.init(getContext());
        com.kwad.components.core.a.a.oB().aw();
        com.kwad.sdk.utils.h.a(getContext(), 30000L, new com.kwad.sdk.collector.h() { // from class: com.kwad.sdk.o.8
            @Override // com.kwad.sdk.collector.h
            public final void c(JSONArray jSONArray) {
                com.kwad.components.core.p.a.vX().c(jSONArray);
            }
        });
        com.kwad.sdk.core.network.idc.a.My().a(com.kwad.sdk.core.config.e.Kx(), com.kwad.sdk.core.config.e.Ky());
        com.kwad.sdk.ip.direct.a.a(sdkConfigData.httpDnsInfo);
        bv.a(com.kwad.sdk.core.config.e.Kz(), com.kwad.sdk.core.config.e.KA(), ServiceProvider.getContext());
        Hf();
        Hb();
        com.kwad.components.core.i.a.qZ().at(getContext());
        com.kwad.sdk.crash.online.monitor.a.dA(com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aPu));
        ImageLoaderPerfUtil.report();
        com.kwad.sdk.m.f.dA(com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aPD));
        at.VW().dA(com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aPF));
        com.kwad.sdk.core.threads.c.dA(com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aPH));
        com.kwad.sdk.monitor.b.SG();
        com.kwad.sdk.wrapper.m.E(getContext(), ((Boolean) sdkConfigData.getAppConfigData(Boolean.FALSE, new com.kwad.sdk.g.b<JSONObject, Boolean>() { // from class: com.kwad.sdk.o.9
            @Override // com.kwad.sdk.g.b
            public final /* synthetic */ Boolean apply(JSONObject jSONObject) {
                return g(jSONObject);
            }

            private static Boolean g(JSONObject jSONObject) {
                return Boolean.valueOf(jSONObject.optBoolean("useContextClassLoader"));
            }
        })).booleanValue());
        com.kwad.sdk.kgeo.a.eS(com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aPZ));
        try {
            com.kwad.components.core.webview.tachikoma.g.yT().init();
        } catch (Throwable th2) {
            com.kwad.components.core.d.a.reportSdkCaughtException(th2);
        }
        GU();
        try {
            com.kwad.sdk.f.a.a.Rj().init(com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aPE));
        } catch (Throwable th3) {
            com.kwad.components.core.d.a.reportSdkCaughtException(th3);
        }
        com.kwad.components.core.pfmonitor.d.aE(getContext());
    }

    private void GU() {
        GlobalThreadPools.Or().execute(new Runnable() { // from class: com.kwad.sdk.o.10
            @Override // java.lang.Runnable
            public final void run() {
                try {
                    com.kwad.components.core.c.a.oF().oH();
                } catch (Exception e) {
                    com.kwad.sdk.core.d.c.w("KSAdSDK", Log.getStackTraceString(e));
                }
            }
        });
    }

    private static void GV() {
        try {
            com.kwad.sdk.core.d.c.init(ServiceProvider.getSDKConfig().enableDebug);
        } catch (Throwable th) {
            q.s(th);
        }
    }

    private static void GW() {
        try {
            com.kwad.sdk.wrapper.f.XZ().init();
        } catch (Throwable th) {
            q.s(th);
        }
    }

    private static void GX() {
        try {
            com.kwad.sdk.core.c.b.Mh().init(ServiceProvider.getContext());
        } catch (Throwable th) {
            q.s(th);
        }
    }

    private void GY() {
        try {
            com.kwad.sdk.core.webview.b.a.PQ().init(getContext());
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    private void GZ() {
        try {
            com.kwad.sdk.core.network.idc.a.My().init(getContext());
        } catch (Throwable th) {
            q.s(th);
        }
    }

    private static void Ha() {
        try {
            com.kwad.sdk.core.download.a.bP(ServiceProvider.getContext());
        } catch (Throwable th) {
            q.s(th);
        }
    }

    private void Hb() {
        try {
            com.kwad.sdk.core.diskcache.a.bO(getContext());
        } catch (Throwable th) {
            q.s(th);
        }
    }

    private static void Hc() {
        try {
            t.xg().init();
        } catch (Throwable th) {
            q.s(th);
        }
    }

    private static void Hd() {
        com.kwad.components.core.q.b.wr();
        com.kwad.components.core.q.b.f(com.kwad.sdk.core.config.e.JL(), com.kwad.sdk.core.config.e.JM());
    }

    private void He() {
        try {
            bf.init(getContext());
        } catch (Throwable th) {
            q.s(th);
        }
    }

    private static void Hf() {
        try {
            com.kwad.sdk.app.b.Ia().init();
        } catch (Throwable th) {
            q.s(th);
        }
    }

    private void Hg() {
        try {
            com.kwad.library.solder.lib.i.a(new com.kwad.library.solder.lib.i.a() { // from class: com.kwad.sdk.o.2
                @Override // com.kwad.library.solder.lib.i.a
                public final int getMaxRetryCount() {
                    return com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aOP);
                }

                @Override // com.kwad.library.solder.lib.i.a
                public final int getCorePoolSize() {
                    return com.kwad.sdk.core.config.e.JO();
                }

                @Override // com.kwad.library.solder.lib.i.a
                public final boolean Ef() {
                    return com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aOO);
                }

                @Override // com.kwad.library.solder.lib.i.a
                public final void b(String str, File file) {
                    com.kwad.sdk.core.download.a.a(str, file, true);
                }

                @Override // com.kwad.library.solder.lib.i.a
                public final void f(String str, Throwable th) {
                    if (th instanceof Exception) {
                        com.kwad.sdk.core.network.idc.a.My().h(str, th);
                    }
                }
            });
        } catch (Throwable th) {
            q.s(th);
        }
    }

    public static boolean isDebugLogEnable() {
        return ServiceProvider.getSDKConfig().enableDebug;
    }

    public static String getAppId() {
        return ServiceProvider.getSDKConfig().appId;
    }

    public static String getAppName() {
        return ServiceProvider.getSDKConfig().appName;
    }

    public static Context getContext() {
        return ServiceProvider.getContext();
    }

    public final boolean FJ() {
        return this.aGq.get();
    }

    public final boolean Hh() {
        if (GH()) {
            return this.aGq.get() && this.aGr.get();
        }
        return this.aGq.get();
    }

    public final KsLoadManager getAdManager() {
        if (this.aGz == null) {
            this.aGz = new com.kwad.components.core.b();
        }
        return this.aGz;
    }

    public final void unInit() {
        com.kwad.sdk.core.download.b.LK().bR(getContext());
    }

    public final String getApiVersion() {
        return this.aGw;
    }

    public final int getApiVersionCode() {
        return this.aGx;
    }

    public final void setApiVersion(String str) {
        this.aGw = str;
    }

    public final void setApiVersionCode(int i) {
        this.aGx = i;
    }

    public static void deleteCache() {
        com.kwad.sdk.core.diskcache.b.a.LI().delete();
    }

    public final <T extends IComponentProxy> T newComponentProxy(Class<?> cls, Object obj) {
        try {
            Class clsG = com.kwad.sdk.service.c.g(cls);
            if (clsG == null) {
                if (obj instanceof BaseProxyActivity) {
                    clsG = com.kwad.components.core.proxy.d.class;
                } else if (obj instanceof BaseProxyFragmentActivity) {
                    clsG = com.kwad.components.core.proxy.e.class;
                }
                com.kwad.components.core.d.a.reportSdkCaughtException(new RuntimeException("--getIsExternal:" + FG() + "--mIsSdkInit:" + FJ() + "--componentClass" + cls));
            }
            return (T) clsG.newInstance();
        } catch (Exception e) {
            com.kwad.components.core.d.a.reportSdkCaughtException(e);
            com.kwad.sdk.core.d.c.printStackTrace(e);
            return null;
        }
    }

    public static <T> T newInstance(Class<T> cls) {
        try {
            return (T) com.kwad.sdk.service.c.h(cls).newInstance();
        } catch (Exception e) {
            throw new RuntimeException(e);
        }
    }

    public static JSONObject getAppInfo() {
        return com.kwad.sdk.core.request.model.a.Nz();
    }

    public static JSONObject getDeviceInfo() {
        return com.kwad.sdk.core.request.model.b.NB().toJson();
    }

    public static JSONObject getNetworkInfo() {
        return com.kwad.sdk.core.request.model.d.NE().toJson();
    }

    public final void setIsExternal(boolean z) {
        this.aGy = z;
    }

    public static String getDid() {
        return bf.getDeviceId();
    }

    public static void resumeCurrentPlayer() {
        com.kwad.sdk.components.d.f(com.kwad.components.a.a.a.class);
    }

    public static void pauseCurrentPlayer() {
        com.kwad.sdk.components.d.f(com.kwad.components.a.a.a.class);
    }

    public final void setPersonalRecommend(boolean z) {
        this.aGG = z;
    }

    public final void setProgrammaticRecommend(boolean z) {
        this.aGH = z;
    }

    public final void setAdxEnable(boolean z) {
        this.aGI = z;
    }

    public final void setAppTag(String str) {
        if (this.aGq.get()) {
            ai.ap(ServiceProvider.getContext(), this.aGJ);
        } else {
            this.aGJ = str;
        }
    }

    public final void setLaunchTime(long j) {
        this.aGA = j;
        com.kwad.sdk.utils.q.setLaunchTime(j);
    }

    public final void setInitStartTime(long j) {
        this.aGB = j;
        com.kwad.sdk.utils.q.setInitStartTime(System.currentTimeMillis());
    }

    public final long Hi() {
        return this.alM;
    }

    public final boolean FG() {
        return this.aGy;
    }

    public static void setThemeMode(int i) {
        com.kwad.sdk.components.d.f(com.kwad.components.a.a.a.class);
    }

    public static void setLoadingLottieAnimation(boolean z, int i) {
        com.kwad.sdk.components.d.f(com.kwad.components.a.a.a.class);
    }

    public static void setLoadingLottieAnimationColor(boolean z, int i) {
        com.kwad.sdk.components.d.f(com.kwad.components.a.a.a.class);
    }

    public final boolean FH() {
        return this.aGG;
    }

    public final boolean FI() {
        return this.aGH;
    }

    public static void r(Throwable th) {
        ServiceProvider.reportSdkCaughtException(th);
    }

    public static void f(Map<String, String> map) {
        com.kwad.sdk.core.a.d.h(map);
    }

    public static String cR(String str) {
        return com.kwad.sdk.core.a.d.av(str);
    }

    public static String cS(String str) {
        return com.kwad.sdk.core.a.d.getResponseData(str);
    }

    public static void b(String str, Map<String, String> map, String str2) {
        com.kwad.sdk.core.a.d.a(str, map, str2);
    }

    public static Object f(String str, Object... objArr) {
        try {
            if ("autoRT".equals(str)) {
                return -1;
            }
            if ("getAutoRevertTime".equals(str)) {
                return 10000;
            }
            boolean z = false;
            if ("TRANSFORM_API_HOST".equals(str)) {
                return com.kwad.sdk.core.network.idc.a.My().aa(objArr[0].toString(), "api");
            }
            if ("reportDynamicUpdate".equals(str)) {
                com.kwad.sdk.commercial.c.h((JSONObject) objArr[0]);
                return Boolean.TRUE;
            }
            if ("enableDynamic".equals(str) && ServiceProvider.Um() != null) {
                if (ba.isInMainProcess(ServiceProvider.Um()) && com.kwad.framework.a.a.ayO.booleanValue()) {
                    z = true;
                }
                return Boolean.valueOf(z);
            }
            if ("getThrowClassNotFoundSet".equals(str) && com.kwad.sdk.core.config.e.enableInflaterOptimize()) {
                return com.kwad.sdk.core.config.e.Lm();
            }
            return null;
        } catch (Throwable th) {
            try {
                ServiceProvider.reportSdkCaughtException(th);
            } catch (Throwable unused) {
            }
            return null;
        }
    }

    public static SdkConfig getSdkConfig() {
        return ServiceProvider.getSDKConfig();
    }
}

package com.kwad.components.core.innerEc;

import android.app.Activity;
import android.app.Application;
import android.content.Context;
import android.net.Uri;
import android.os.ResultReceiver;
import android.text.TextUtils;
import android.webkit.WebView;
import com.baidu.mobads.sdk.internal.cb;
import com.byazt.nys.PluginConstants;
import com.kwad.components.core.innerEc.a.j;
import com.kwad.components.core.innerEc.a.k;
import com.kwad.components.core.page.AdWebViewActivityProxy;
import com.kwad.components.offline.api.adInnerEc.login.IAdInnerEcLoginBindListener;
import com.kwad.components.offline.api.core.adInnerEc.ExternalExitListener;
import com.kwad.components.offline.api.core.adInnerEc.IAdInnerEcExternalModule;
import com.kwad.components.offline.api.core.adInnerEc.YodaWebPageListener;
import com.kwad.components.offline.api.core.adInnerEc.fullAdLive.IHostLivePlayer;
import com.kwad.components.offline.api.core.adInnerEc.fullAdLive.ILiveBindOwner;
import com.kwad.components.offline.api.core.adInnerEc.fullAdLive.ILivePluginProvider;
import com.kwad.components.offline.api.core.adInnerEc.fullAdLive.model.PBHelper;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ae;
import com.kwad.sdk.utils.au;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import com.kwad.sdk.utils.bz;
import com.kwad.sdk.wrapper.m;
import com.sigmob.sdk.base.mta.PointCategory;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public final class f {
    private static IAdInnerEcExternalModule SR;
    private static PBHelper SS;

    public static void init() {
        b(com.kwad.sdk.core.c.b.Mh().getApplication());
    }

    public static boolean aG(AdTemplate adTemplate) {
        boolean zDG;
        int iEv = com.kwad.sdk.core.response.helper.b.ev(adTemplate);
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        if (com.kwad.sdk.core.response.helper.a.cZ(adInfoEM)) {
            zDG = com.kwad.sdk.core.response.helper.a.dG(adInfoEM) && com.kwad.components.core.innerEc.live.b.rG();
        } else {
            zDG = com.kwad.sdk.core.response.helper.a.dG(adInfoEM);
        }
        return zDG && com.kwad.components.core.innerEc.local.a.be(iEv);
    }

    public static WebView a(Activity activity, YodaWebPageListener yodaWebPageListener, ExternalExitListener externalExitListener) {
        IAdInnerEcExternalModule iAdInnerEcExternalModuleB = b(activity.getApplication());
        if (iAdInnerEcExternalModuleB != null) {
            return iAdInnerEcExternalModuleB.createYodaWebViewAndInit(activity, yodaWebPageListener, externalExitListener);
        }
        return null;
    }

    public static IHostLivePlayer a(Application application, String str) {
        com.kwad.sdk.core.d.c.d("SdkInnerECWrapper", "createFullLivePlayer dataKey: " + str);
        IAdInnerEcExternalModule iAdInnerEcExternalModuleB = b(application);
        if (iAdInnerEcExternalModuleB == null) {
            return null;
        }
        IHostLivePlayer iHostLivePlayerCreateLivePlayer = iAdInnerEcExternalModuleB.createLivePlayer(str);
        com.kwad.sdk.core.d.c.d("SdkInnerECWrapper", "createFullLivePlayer player: " + iHostLivePlayerCreateLivePlayer);
        return iHostLivePlayerCreateLivePlayer;
    }

    public static ILiveBindOwner a(Application application, String str, String str2, ILivePluginProvider iLivePluginProvider) {
        IAdInnerEcExternalModule iAdInnerEcExternalModuleB = b(application);
        if (iAdInnerEcExternalModuleB != null) {
            return iAdInnerEcExternalModuleB.createLiveBindOwner(str, str2, iLivePluginProvider);
        }
        return null;
    }

    public static PBHelper rh() {
        PBHelper pBHelper = SS;
        if (pBHelper != null) {
            return pBHelper;
        }
        IAdInnerEcExternalModule iAdInnerEcExternalModuleB = b(com.kwad.sdk.core.c.b.Mh().getApplication());
        if (iAdInnerEcExternalModuleB != null) {
            SS = iAdInnerEcExternalModuleB.createPBPaser();
        }
        return SS;
    }

    public static void b(Application application, String str) {
        IAdInnerEcExternalModule iAdInnerEcExternalModuleB = b(application);
        com.kwad.sdk.core.d.c.d("SdkInnerECWrapper", "initEmotionSdk module: " + iAdInnerEcExternalModuleB);
        if (iAdInnerEcExternalModuleB != null) {
            iAdInnerEcExternalModuleB.initEmotionSdk(str);
            iAdInnerEcExternalModuleB.loadData(true);
        }
    }

    public static int a(Context context, final AdTemplate adTemplate, final com.kwad.components.core.e.d.a.C0428a c0428a) {
        com.kwad.sdk.core.d.c.d("SdkInnerECWrapper", "handleUserAuthCheck call");
        int iAv = av(context);
        if (iAv != 0) {
            if (adTemplate != null) {
                adTemplate.setHasInnerEcFailed(true);
            }
            com.kwad.components.core.innerEc.logger.a.f(adTemplate, iAv);
            return 3;
        }
        if (e.re().rf()) {
            com.kwad.sdk.core.d.c.d("SdkInnerECWrapper", "handleUserAuthCheck hasUserLogin");
            com.kwad.components.core.innerEc.logger.a.aM(adTemplate);
            return 2;
        }
        com.kwad.components.core.innerEc.logger.a.aN(adTemplate);
        if (com.kwad.sdk.core.response.helper.b.ew(adTemplate)) {
            com.kwad.sdk.core.d.c.d("SdkInnerECWrapper", "handleUserAuthCheck showAuthHintCard");
            com.kwad.components.core.innerEc.a.f.ru().a(adTemplate, new j() { // from class: com.kwad.components.core.innerEc.f.1
                @Override // com.kwad.components.core.innerEc.a.j
                public final void rm() {
                    AdTemplate adTemplate2 = adTemplate;
                    if (adTemplate2 != null) {
                        adTemplate2.setHasInnerEcFailed(true);
                    }
                    by.runOnUiThread(new bi() { // from class: com.kwad.components.core.innerEc.f.1.1
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            f.G(c0428a);
                        }
                    });
                }

                @Override // com.kwad.components.core.innerEc.a.j
                public final void rn() {
                    AdTemplate adTemplate2 = adTemplate;
                    if (adTemplate2 != null) {
                        adTemplate2.setHasInnerEcFailed(true);
                    }
                    by.runOnUiThread(new bi() { // from class: com.kwad.components.core.innerEc.f.1.2
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            f.G(c0428a);
                        }
                    });
                }

                @Override // com.kwad.components.core.innerEc.a.j
                public final void oV() {
                    com.kwad.components.core.e.d.a.C0428a c0428a2 = c0428a;
                    if (c0428a2 != null) {
                        c0428a2.aC(true);
                    }
                    by.runOnUiThread(new bi() { // from class: com.kwad.components.core.innerEc.f.1.3
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            f.G(c0428a);
                        }
                    });
                }
            });
        } else {
            a(context, adTemplate, c0428a, new k() { // from class: com.kwad.components.core.innerEc.f.2
                @Override // com.kwad.components.core.innerEc.a.k
                public final void oT() {
                }

                @Override // com.kwad.components.core.innerEc.a.k
                public final void oU() {
                }

                @Override // com.kwad.components.core.innerEc.a.k
                public final void k(int i, String str) {
                    AdTemplate adTemplate2 = adTemplate;
                    if (adTemplate2 != null) {
                        adTemplate2.setHasInnerEcFailed(true);
                    }
                    by.runOnUiThread(new bi() { // from class: com.kwad.components.core.innerEc.f.2.1
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            f.G(c0428a);
                        }
                    });
                }

                @Override // com.kwad.components.core.innerEc.a.k
                public final void oV() {
                    com.kwad.components.core.e.d.a.C0428a c0428a2 = c0428a;
                    if (c0428a2 != null) {
                        c0428a2.aC(true);
                    }
                    by.runOnUiThread(new bi() { // from class: com.kwad.components.core.innerEc.f.2.2
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            f.G(c0428a);
                        }
                    });
                }
            });
        }
        return 1;
    }

    public static void a(final Context context, final AdTemplate adTemplate, final com.kwad.components.core.e.d.a.C0428a c0428a, final k kVar) {
        com.kwad.sdk.core.d.c.d("SdkInnerECWrapper", "startAuthPage call");
        final String strRk = rk();
        if (!TextUtils.isEmpty(strRk) && aw(context)) {
            com.kwad.sdk.core.d.c.d("SdkInnerECWrapper", "startAuthPage startLoginWithKwaiClient");
            com.kwad.components.core.innerEc.logger.a.i(adTemplate, PointCategory.APP);
            e.re().a(m.getActivityFromContext(context), new IAdInnerEcLoginBindListener() { // from class: com.kwad.components.core.innerEc.f.3
                @Override // com.kwad.components.offline.api.adInnerEc.login.IAdInnerEcLoginBindListener
                public final void onSuccess(String str, final int i) {
                    com.kwad.sdk.core.d.c.d("SdkInnerECWrapper", "startAuthPage startAuthPage onSuccess");
                    com.kwad.components.core.innerEc.logger.a.j(adTemplate, PointCategory.APP);
                    if (TextUtils.isEmpty(str)) {
                        return;
                    }
                    e.re();
                    e.b(str, new c() { // from class: com.kwad.components.core.innerEc.f.3.1
                        @Override // com.kwad.components.core.innerEc.c
                        public final void a(InnerEcUserLoginBindInfo innerEcUserLoginBindInfo) {
                            com.kwad.sdk.core.d.c.d("SdkInnerECWrapper", "startAuthPage startCodebind onSuccess");
                            com.kwad.components.core.innerEc.logger.a.k(adTemplate, PointCategory.APP);
                            com.kwad.sdk.core.adlog.c.a(adTemplate, cb.o, PointCategory.APP, i);
                            com.kwad.components.core.innerEc.local.a.aO(PointCategory.APP);
                            e.re().b(innerEcUserLoginBindInfo);
                            kVar.oU();
                            adTemplate.isDoAuth = true;
                            com.kwad.components.core.innerEc.qcpx.b.h(context, adTemplate);
                            if (com.kwad.sdk.core.response.helper.e.fk(adTemplate)) {
                                com.kwad.components.core.innerEc.live.b.c(com.kwad.sdk.core.c.b.Mh().getApplication());
                                com.kwad.components.core.innerEc.live.b.b(context, adTemplate, c0428a);
                            } else {
                                f.g(context, adTemplate);
                            }
                        }

                        @Override // com.kwad.components.core.innerEc.c
                        public final void rb() {
                            com.kwad.sdk.core.d.c.d("SdkInnerECWrapper", "startAuthPage startCode bind onFail");
                            com.kwad.sdk.core.adlog.c.a(adTemplate, "fail", PointCategory.APP, i);
                            kVar.k(2001, "fail");
                            com.kwad.components.core.innerEc.logger.a.f(adTemplate, 2001, "fail");
                            com.kwad.components.core.innerEc.local.a.f(adTemplate, PointCategory.APP);
                        }
                    }, strRk);
                }

                @Override // com.kwad.components.offline.api.adInnerEc.login.IAdInnerEcLoginBindListener
                public final void onFailed(int i, String str, int i2) {
                    if (i != 10002) {
                        com.kwad.sdk.core.adlog.c.a(adTemplate, "fail", PointCategory.APP, i2);
                        com.kwad.components.core.innerEc.local.a.f(adTemplate, PointCategory.APP);
                        String str2 = "errorCode=" + i + ",errorMsg=" + str;
                        kVar.k(2000, str2);
                        com.kwad.components.core.innerEc.logger.a.f(adTemplate, 2000, str2);
                        return;
                    }
                    onCancel(false, i2);
                }

                @Override // com.kwad.components.offline.api.adInnerEc.login.IAdInnerEcLoginBindListener
                public final void onCancel(boolean z, int i) {
                    com.kwad.sdk.core.adlog.c.a(adTemplate, "reject", PointCategory.APP, i);
                    com.kwad.components.core.innerEc.local.a.g(adTemplate, PointCategory.APP);
                    kVar.oV();
                    com.kwad.components.core.innerEc.logger.a.h(adTemplate, PointCategory.APP);
                }
            }, rk());
            return;
        }
        com.kwad.sdk.core.d.c.d("SdkInnerECWrapper", "startAuthPage startLoginWithH5");
        com.kwad.components.core.innerEc.logger.a.i(adTemplate, "h5");
        e.re();
        e.a(context, adTemplate, new k() { // from class: com.kwad.components.core.innerEc.f.4
            @Override // com.kwad.components.core.innerEc.a.k
            public final void oT() {
                com.kwad.components.core.innerEc.logger.a.j(adTemplate, "h5");
                k kVar2 = kVar;
                if (kVar2 != null) {
                    kVar2.oT();
                }
            }

            @Override // com.kwad.components.core.innerEc.a.k
            public final void oU() {
                com.kwad.components.core.innerEc.logger.a.k(adTemplate, "h5");
                k kVar2 = kVar;
                if (kVar2 != null) {
                    kVar2.oU();
                }
                com.kwad.components.core.innerEc.qcpx.b.h(context, adTemplate);
                if (com.kwad.sdk.core.response.helper.e.fk(adTemplate)) {
                    com.kwad.components.core.innerEc.live.b.c(com.kwad.sdk.core.c.b.Mh().getApplication());
                    com.kwad.components.core.innerEc.live.b.b(context, adTemplate, c0428a);
                }
            }

            @Override // com.kwad.components.core.innerEc.a.k
            public final void k(int i, String str) {
                k kVar2 = kVar;
                if (kVar2 != null) {
                    kVar2.k(i, str);
                }
                com.kwad.components.core.innerEc.logger.a.g(adTemplate, i);
            }

            @Override // com.kwad.components.core.innerEc.a.k
            public final void oV() {
                k kVar2 = kVar;
                if (kVar2 != null) {
                    kVar2.oV();
                }
                com.kwad.components.core.innerEc.logger.a.h(adTemplate, "h5");
            }
        });
    }

    public static void g(Context context, AdTemplate adTemplate) {
        AdWebViewActivityProxy.launch(context, new AdWebViewActivityProxy.a.C0449a().aX(com.kwad.sdk.core.response.helper.b.dh(adTemplate)).aU(adTemplate).bl(2).um());
    }

    public static boolean a(String str, final c cVar) {
        Uri uri;
        if (TextUtils.isEmpty(com.kwad.sdk.core.config.e.Lf()) || !str.contains(com.kwad.sdk.core.config.e.Lf()) || (uri = Uri.parse(str)) == null) {
            return false;
        }
        String queryParameter = uri.getQueryParameter(PluginConstants.KEY_ERROR_CODE);
        if (!TextUtils.isEmpty(queryParameter)) {
            e.re();
            e.b(queryParameter, new c() { // from class: com.kwad.components.core.innerEc.f.5
                @Override // com.kwad.components.core.innerEc.c
                public final void a(InnerEcUserLoginBindInfo innerEcUserLoginBindInfo) {
                    e.re().b(innerEcUserLoginBindInfo);
                    c cVar2 = cVar;
                    if (cVar2 != null) {
                        cVar2.a(innerEcUserLoginBindInfo);
                    }
                }

                @Override // com.kwad.components.core.innerEc.c
                public final void rb() {
                    c cVar2 = cVar;
                    if (cVar2 != null) {
                        cVar2.rb();
                    }
                }
            }, com.kwad.sdk.core.config.e.Ld());
            return true;
        }
        return false;
    }

    public static void a(Activity activity, String str, String str2, ResultReceiver resultReceiver) {
        IAdInnerEcExternalModule iAdInnerEcExternalModuleB = b(activity.getApplication());
        if (iAdInnerEcExternalModuleB != null) {
            iAdInnerEcExternalModuleB.startPay(activity, str, str2, resultReceiver);
        }
    }

    public static CharSequence a(Application application, CharSequence charSequence, float f) {
        IAdInnerEcExternalModule iAdInnerEcExternalModuleB = b(application);
        com.kwad.sdk.core.d.c.d("SdkInnerECWrapper", "generateBasicEmoji module is:" + iAdInnerEcExternalModuleB);
        if (iAdInnerEcExternalModuleB != null) {
            return iAdInnerEcExternalModuleB.generateBasicEmoji(charSequence, f);
        }
        return null;
    }

    public static Map<String, String> ri() {
        if (!e.re().rf()) {
            com.kwad.sdk.core.d.c.w("SdkInnerECWrapper", "obtainEcModule user not login");
            return null;
        }
        IAdInnerEcExternalModule iAdInnerEcExternalModuleB = b(com.kwad.sdk.core.c.b.Mh().getApplication());
        if (iAdInnerEcExternalModuleB == null) {
            com.kwad.sdk.core.d.c.w("SdkInnerECWrapper", "obtainEcModule is null");
            return null;
        }
        return iAdInnerEcExternalModuleB.getCurrentCookieMap();
    }

    private static IAdInnerEcExternalModule b(Application application) {
        IAdInnerEcExternalModule iAdInnerEcExternalModule = SR;
        if (iAdInnerEcExternalModule != null) {
            return iAdInnerEcExternalModule;
        }
        com.kwad.components.core.offline.a.a.a aVar = (com.kwad.components.core.offline.a.a.a) com.kwad.sdk.components.d.f(com.kwad.components.core.offline.a.a.a.class);
        com.kwad.sdk.core.d.c.w("SdkInnerECWrapper", "adInnerEcComponents is: " + aVar);
        if (aVar == null && com.kwad.components.core.a.oV.booleanValue()) {
            ae.c((Context) application, "电商闭环离线组件未安装成功", 0);
            return null;
        }
        if (aVar != null) {
            com.kwad.sdk.core.d.c.w("SdkInnerECWrapper", "adInnerEcComponents hasInnerEcCompoReady: " + aVar.tD());
        }
        if (aVar == null) {
            com.kwad.sdk.core.d.c.w("SdkInnerECWrapper", " adInnerEcComponents is return null");
            return null;
        }
        IAdInnerEcExternalModule iAdInnerEcExternalModuleTE = aVar.tE();
        if (iAdInnerEcExternalModuleTE == null) {
            com.kwad.sdk.core.d.c.w("SdkInnerECWrapper", " getExternalComponents is return null");
            return null;
        }
        com.kwad.components.core.offline.b.a.a aVar2 = new com.kwad.components.core.offline.b.a.a();
        iAdInnerEcExternalModuleTE.setDebug(com.kwad.components.core.a.oV.booleanValue());
        try {
            com.kwad.sdk.core.d.c.d("SdkInnerECWrapper", "obtainEcModule setAdInnerEcHostProvider call " + aVar2.getApp());
            iAdInnerEcExternalModuleTE.setAdInnerEcHostProvider(aVar2);
            iAdInnerEcExternalModuleTE.initModule();
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.w("SdkInnerECWrapper", "initModule error: " + th.getMessage());
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
        }
        SR = iAdInnerEcExternalModuleTE;
        rj();
        return iAdInnerEcExternalModuleTE;
    }

    private static void rj() {
        com.kwad.sdk.core.c.b.Mh();
        com.kwad.sdk.core.c.b.a(new a() { // from class: com.kwad.components.core.innerEc.f.6
            @Override // com.kwad.components.core.innerEc.a, com.kwad.sdk.core.c.c
            /* JADX INFO: renamed from: onActivityPaused */
            public final void c(Activity activity) {
                super.c(activity);
                if (f.SR != null) {
                    f.SR.onActivityPaused(activity);
                }
            }

            @Override // com.kwad.components.core.innerEc.a, com.kwad.sdk.core.c.c
            /* JADX INFO: renamed from: onActivityResumed */
            public final void d(Activity activity) {
                super.d(activity);
                if (f.SR != null) {
                    f.SR.onActivityResumed(activity);
                }
            }

            @Override // com.kwad.components.core.innerEc.a, com.kwad.sdk.core.c.c
            /* JADX INFO: renamed from: onActivityDestroyed */
            public final void b(Activity activity) {
                super.b(activity);
                if (f.SR != null) {
                    f.SR.onActivityDestroyed(activity);
                }
            }

            @Override // com.kwad.components.core.innerEc.a, com.kwad.sdk.core.c.c
            /* JADX INFO: renamed from: onActivityStopped */
            public final void f(Activity activity) {
                super.b(activity);
                if (f.SR != null) {
                    f.SR.onActivityStopped(activity);
                }
            }
        });
    }

    private static String rk() {
        return (String) com.kwad.sdk.core.config.e.b(com.kwad.sdk.core.config.c.aQB);
    }

    private static int av(Context context) {
        try {
            com.kwad.components.core.offline.a.a.a aVar = (com.kwad.components.core.offline.a.a.a) com.kwad.sdk.components.d.f(com.kwad.components.core.offline.a.a.a.class);
            if (aVar != null && aVar.tD()) {
                boolean z = true;
                boolean z2 = !TextUtils.isEmpty(rk()) && (au.dF(context) || au.dG(context));
                if (TextUtils.isEmpty(com.kwad.sdk.core.config.e.Lc()) || TextUtils.isEmpty(com.kwad.sdk.core.config.e.Ld()) || TextUtils.isEmpty(com.kwad.sdk.core.config.e.Lf())) {
                    z = false;
                }
                if (!z2 && !z) {
                    return 1001;
                }
                e.re();
                return !e.isReady() ? 1002 : 0;
            }
            return 1000;
        } catch (Throwable th) {
            com.kwad.sdk.crash.b.u(th);
            return 1003;
        }
    }

    public static int G(com.kwad.components.core.e.d.a.C0428a c0428a) {
        if (c0428a.getAdTemplate().hasInnerEcFailed() || c0428a.qj()) {
            return com.kwad.components.core.e.d.a.a(c0428a);
        }
        return 14;
    }

    private static boolean aw(Context context) {
        int iDH = au.dH(context);
        int iDI = au.dI(context);
        boolean zAD = bz.aD(((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).getApiVersion(), "4.10.30");
        if (iDH == 0 && iDI == 0) {
            return false;
        }
        if (iDH == 1 && zAD) {
            return false;
        }
        return (iDH == 0 && iDI == 1 && zAD) ? false : true;
    }
}

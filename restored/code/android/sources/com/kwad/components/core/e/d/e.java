package com.kwad.components.core.e.d;

import android.app.Activity;
import android.content.Context;
import android.net.Uri;
import android.text.TextUtils;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.internal.api.SceneImpl;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.au;
import com.kwad.sdk.utils.by;
import com.kwad.sdk.wrapper.m;
import java.util.concurrent.Callable;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class e {
    private static boolean Rn = false;
    private static final b Ro = new b() { // from class: com.kwad.components.core.e.d.e.4
        long Rv;

        @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
        public final void onBackToForeground() {
            super.onBackToForeground();
            if (this.Rv != 0) {
                com.kwad.sdk.core.adlog.c.n(getAdTemplate(), System.currentTimeMillis() - this.Rv);
            }
            com.kwad.sdk.core.c.b.Mh();
            com.kwad.sdk.core.c.b.b((com.kwad.sdk.core.c.c) e.Ro);
            setAdTemplate(null);
            this.Rv = 0L;
        }

        @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
        public final void onBackToBackground() {
            super.onBackToBackground();
            this.Rv = System.currentTimeMillis();
        }
    };

    public static void aD(boolean z) {
        com.kwad.sdk.core.adlog.c.aLK = z;
    }

    public static int a(final a.C0428a c0428a, int i) {
        Context context = c0428a.getContext();
        final AdTemplate adTemplate = c0428a.getAdTemplate();
        String strB = b(c0428a, adTemplate);
        if (TextUtils.isEmpty(strB)) {
            return 0;
        }
        final AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        Activity activityFromContext = m.getActivityFromContext(context);
        if (activityFromContext != null && com.kwad.sdk.core.response.helper.a.W(adInfoEM) && !c0428a.pO()) {
            c0428a.aA(1);
            com.kwad.components.core.e.e.e.a(activityFromContext, c0428a);
            return 2;
        }
        final String strA = a(strB, c0428a, adInfoEM);
        final int i2 = 1;
        return com.kwad.sdk.core.download.a.b.a(context, strA, new com.kwad.sdk.core.download.a.b.a() { // from class: com.kwad.components.core.e.d.e.1
            @Override // com.kwad.sdk.core.download.a.b.a
            public final void aJ(int i3) {
                if (c0428a.QR == null) {
                    c0428a.QR = new com.kwad.sdk.core.adlog.a.C0502a();
                }
                c0428a.QR.aLG = c0428a.pO() ? 2 : 1;
                com.kwad.sdk.core.adlog.c.a aVarPZ = c0428a.pZ();
                if (qG()) {
                    if (aVarPZ.QR == null) {
                        aVarPZ.QR = new com.kwad.sdk.core.adlog.a.C0502a();
                    }
                    aVarPZ.QR.aLr = true;
                }
                aVarPZ.aMv = i3;
                com.kwad.sdk.core.adlog.c.a(adTemplate, "", i2, aVarPZ);
            }

            @Override // com.kwad.sdk.core.download.a.b.a
            public final void onPreStart() {
                if (c0428a.QR == null) {
                    c0428a.QR = new com.kwad.sdk.core.adlog.a.C0502a();
                }
                c0428a.QR.aLG = c0428a.pO() ? 2 : 1;
                com.kwad.sdk.core.adlog.c.a aVarPZ = c0428a.pZ();
                if (qG()) {
                    if (aVarPZ.QR == null) {
                        aVarPZ.QR = new com.kwad.sdk.core.adlog.a.C0502a();
                    }
                    aVarPZ.QR.aLr = true;
                }
                com.kwad.sdk.core.adlog.c.b(adTemplate, "", i2, aVarPZ);
                com.kwad.sdk.commercial.e.a.o(adTemplate, strA);
            }

            @Override // com.kwad.sdk.core.download.a.b.a
            public final void onStart() {
                com.kwad.components.core.proxy.launchdialog.e.vV().aW(adTemplate);
                e.Ro.setAdTemplate(adTemplate);
                com.kwad.sdk.core.c.b.Mh();
                com.kwad.sdk.core.c.b.a(e.Ro);
                com.kwad.sdk.core.adlog.c.aLJ = e.ap(strA);
                com.kwad.sdk.commercial.e.a.q(adTemplate, strA);
            }

            @Override // com.kwad.sdk.core.download.a.b.a
            public final void onSuccess() {
                if (c0428a.QR == null) {
                    c0428a.QR = new com.kwad.sdk.core.adlog.a.C0502a();
                }
                c0428a.QR.aLG = c0428a.pO() ? 2 : 1;
                com.kwad.sdk.core.adlog.c.a aVarPZ = c0428a.pZ();
                if (qG()) {
                    if (aVarPZ.QR == null) {
                        aVarPZ.QR = new com.kwad.sdk.core.adlog.a.C0502a();
                    }
                    aVarPZ.QR.aLr = true;
                }
                com.kwad.sdk.commercial.e.a.r(adTemplate, strA);
                com.kwad.sdk.core.adlog.c.c(adTemplate, "", i2, aVarPZ);
                e.a(adTemplate, strA, i2, c0428a.QR.aLG);
            }

            @Override // com.kwad.sdk.core.download.a.b.a
            public final void qF() {
                com.kwad.sdk.commercial.e.a.p(adTemplate, strA);
            }

            @Override // com.kwad.sdk.core.download.a.b.a
            public final void onError(Throwable th) {
                com.kwad.sdk.core.adlog.c.a aVar = new com.kwad.sdk.core.adlog.c.a();
                aVar.QR = new com.kwad.sdk.core.adlog.a.C0502a();
                if (qG()) {
                    aVar.QR.aLr = true;
                }
                aVar.QR.aLG = c0428a.pO() ? 2 : 1;
                com.kwad.sdk.core.adlog.c.d(adTemplate, "", i2, aVar);
                com.kwad.sdk.commercial.e.a.d(adTemplate, strA, by.y(th));
            }

            @Override // com.kwad.sdk.core.download.a.b.a
            public final boolean qG() {
                return com.kwad.sdk.core.response.helper.a.cr(adInfoEM);
            }
        });
    }

    public static int F(a.C0428a c0428a) {
        Context context = c0428a.getContext();
        final AdTemplate adTemplate = c0428a.getAdTemplate();
        String strB = b(c0428a, adTemplate);
        if (TextUtils.isEmpty(strB)) {
            return 0;
        }
        final AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        final String strA = a(strB, c0428a, adInfoEM);
        return com.kwad.sdk.core.download.a.b.a(context, strA, new com.kwad.sdk.core.download.a.b.a() { // from class: com.kwad.components.core.e.d.e.2
            @Override // com.kwad.sdk.core.download.a.b.a
            public final void aJ(int i) {
            }

            @Override // com.kwad.sdk.core.download.a.b.a
            public final void onPreStart() {
                com.kwad.sdk.commercial.e.a.o(adTemplate, strA);
            }

            @Override // com.kwad.sdk.core.download.a.b.a
            public final void onStart() {
                com.kwad.sdk.commercial.e.a.q(adTemplate, strA);
            }

            @Override // com.kwad.sdk.core.download.a.b.a
            public final void onSuccess() {
                com.kwad.sdk.commercial.e.a.r(adTemplate, strA);
            }

            @Override // com.kwad.sdk.core.download.a.b.a
            public final void qF() {
                com.kwad.sdk.commercial.e.a.p(adTemplate, strA);
            }

            @Override // com.kwad.sdk.core.download.a.b.a
            public final void onError(Throwable th) {
                com.kwad.sdk.commercial.e.a.d(adTemplate, strA, by.y(th));
            }

            @Override // com.kwad.sdk.core.download.a.b.a
            public final boolean qG() {
                return com.kwad.sdk.core.response.helper.a.cr(adInfoEM);
            }
        });
    }

    private static String a(String str, a.C0428a c0428a, AdInfo adInfo) {
        AdTemplate adTemplate = c0428a.getAdTemplate();
        if (com.kwad.sdk.core.response.helper.a.bs(adInfo)) {
            str = b(c0428a, adInfo, str);
        }
        if (com.kwad.sdk.core.response.helper.a.cY(adInfo)) {
            str = a(c0428a, adInfo, str);
        }
        return ((com.kwad.sdk.core.response.helper.a.cQ(adInfo) || com.kwad.sdk.core.response.helper.a.cW(adInfo)) && adTemplate.mAdScene != null) ? a(str, c0428a.getContext(), adTemplate.mAdScene) : str;
    }

    private static String b(a.C0428a c0428a, AdTemplate adTemplate) {
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        for (AdInfo.AdConversionInfo.DeeplinkItemInfo deeplinkItemInfo : adInfoEM.adConversionInfo.deeplinkConf) {
            boolean zContains = deeplinkItemInfo.areaConf.contains(Integer.valueOf(c0428a.ee()));
            boolean zContains2 = deeplinkItemInfo.sceneConf.contains(Integer.valueOf(c0428a.pS()));
            if ((zContains && zContains2) || ((zContains && deeplinkItemInfo.sceneConf.size() == 0) || (zContains2 && deeplinkItemInfo.areaConf.size() == 0))) {
                if (!TextUtils.isEmpty(deeplinkItemInfo.url)) {
                    return deeplinkItemInfo.url + adInfoEM.adConversionInfo.deeplinkExtra;
                }
            }
        }
        return com.kwad.sdk.core.response.helper.a.da(adInfoEM);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static JSONObject ap(String str) {
        try {
            return new JSONObject(Uri.parse(str).getQueryParameter("universeClientInfo"));
        } catch (Throwable unused) {
            return null;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void a(final AdTemplate adTemplate, final String str, final int i, final int i2) {
        if (qD()) {
            return;
        }
        aE(true);
        int iJV = com.kwad.sdk.core.config.e.JV();
        com.kwad.sdk.core.config.e.JW();
        int iAbs = Math.abs(iJV);
        if (iAbs > 0) {
            by.a(new Runnable() { // from class: com.kwad.components.core.e.d.e.3
                @Override // java.lang.Runnable
                public final void run() {
                    e.aE(false);
                    com.kwad.sdk.core.c.b.Mh();
                    if (com.kwad.sdk.core.c.b.isAppOnForeground()) {
                        return;
                    }
                    com.kwad.sdk.core.adlog.c.d(adTemplate, "", i, i2);
                    com.kwad.sdk.commercial.e.a.s(adTemplate, str);
                }
            }, null, ((long) iAbs) * 1000);
        } else {
            aE(false);
        }
    }

    private static String a(a.C0428a c0428a, AdInfo adInfo, String str) {
        String strCall;
        String strValueOf;
        if (!com.kwad.sdk.core.response.helper.a.bp(adInfo)) {
            return str;
        }
        Callable<String> callablePN = c0428a.pN();
        if (callablePN != null) {
            try {
                strCall = callablePN.call();
            } catch (Exception unused) {
                strCall = null;
            }
        } else {
            strCall = null;
        }
        if (TextUtils.isEmpty(strCall)) {
            strCall = c0428a.pM();
        }
        if (TextUtils.isEmpty(strCall)) {
            return (str.contains("__itemId__") || str.contains("__simpleItemId__")) ? com.kwad.sdk.core.response.helper.a.da(adInfo) : str;
        }
        try {
            strValueOf = String.valueOf(com.kwad.components.core.e.b.a.ak(strCall));
        } catch (Throwable unused2) {
            strValueOf = strCall;
        }
        return str.replaceAll("__itemId__", strCall).replaceAll("__simpleItemId__", strValueOf);
    }

    private static boolean qD() {
        return Rn;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void aE(boolean z) {
        Rn = z;
    }

    private static String a(String str, Context context, SceneImpl sceneImpl) {
        if (sceneImpl == null) {
            return "";
        }
        int i = 0;
        if (!au.aw(context, "com.smile.gifmaker") && au.aw(context, "com.kuaishou.nebula")) {
            i = 3;
        }
        String backUrl = sceneImpl.getBackUrl();
        return a(str, i, TextUtils.isEmpty(backUrl) ? "" : backUrl);
    }

    private static String a(String str, int i, String str2) {
        if (TextUtils.isEmpty(str2)) {
            return str;
        }
        return (i == 0 || i == 3) ? l(str, str2) : str;
    }

    private static String b(a.C0428a c0428a, AdInfo adInfo, String str) {
        long jMax = c0428a.getAdTemplate().getmCurPlayTime();
        if (jMax > 0) {
            jMax = Math.max(jMax - com.kwad.sdk.core.response.helper.a.bt(adInfo), 0L);
        }
        return Uri.parse(str).buildUpon().appendQueryParameter("playStartTime", String.valueOf(jMax)).toString();
    }

    private static String l(String str, String str2) {
        Uri.Builder builderAppendQueryParameter = Uri.parse(str).buildUpon().appendQueryParameter("returnBack", "liveunion_" + ServiceProvider.getAppId());
        if (TextUtils.isEmpty(str2)) {
            str2 = "0";
        }
        return builderAppendQueryParameter.appendQueryParameter("back_url", str2).toString();
    }
}

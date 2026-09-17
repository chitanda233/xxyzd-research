package com.kwad.sdk.commercial;

import android.text.TextUtils;
import com.kwad.components.offline.api.BuildConfig;
import com.kwad.components.offline.api.core.api.ILoggerReporter;
import com.kwad.sdk.commercial.model.HybridLoadMsg;
import com.kwad.sdk.commercial.model.WebViewCommercialMsg;
import com.kwad.sdk.commercial.model.WebViewLoadMsg;
import com.kwad.sdk.core.network.j;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.service.a.h;
import com.kwad.sdk.utils.ac;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.bz;
import com.kwad.sdk.utils.i;
import com.kwai.adclient.kscommerciallogger.model.BusinessType;
import com.sigmob.sdk.base.n;
import java.math.BigDecimal;
import java.math.RoundingMode;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.Random;
import java.util.concurrent.CopyOnWriteArrayList;
import java.util.concurrent.TimeUnit;
import java.util.concurrent.atomic.AtomicBoolean;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    private static float aJA = -1.0f;
    private static float aJB = -1.0f;
    private static final AtomicBoolean aJC = new AtomicBoolean();
    private static final AtomicBoolean aJD = new AtomicBoolean();
    private static boolean aJE = false;
    private static volatile boolean aJF = false;
    private static List<d> aJG = null;
    private static a aJH = null;
    private static Map<String, com.kwad.sdk.commercial.c.c> aJI = null;
    private static Map<String, com.kwad.sdk.commercial.a> aJJ = null;
    private static float aJw = -1.0f;
    private static float aJx = -1.0f;
    private static float aJy = -1.0f;
    private static float aJz = -1.0f;

    public interface a {
        boolean Hj();

        boolean Hk();

        JSONObject Hl();

        JSONObject Hm();

        String Hn();

        void j(String str, String str2, boolean z);
    }

    public static synchronized void a(final a aVar, final boolean z) {
        if (aJE) {
            return;
        }
        aJE = true;
        aJH = aVar;
        i.execute(new bi() { // from class: com.kwad.sdk.commercial.c.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                try {
                    c.b(aVar, z);
                    c.Iu();
                    c.Iv();
                    c.aJC.set(true);
                    c.pf();
                } catch (Throwable th) {
                    c.aJD.set(true);
                    ServiceProvider.reportSdkCaughtException(th);
                }
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void Iu() {
        try {
            aJI = new HashMap();
            JSONObject jSONObjectHl = aJH.Hl();
            if (jSONObjectHl == null) {
                return;
            }
            Iterator<String> itKeys = jSONObjectHl.keys();
            while (itKeys.hasNext()) {
                String next = itKeys.next();
                JSONObject jSONObjectOptJSONObject = jSONObjectHl.optJSONObject(next);
                if (jSONObjectOptJSONObject != null) {
                    a(next, jSONObjectOptJSONObject.optJSONArray(n.C));
                    b(next, jSONObjectOptJSONObject.optJSONArray("ratioApmRL"));
                }
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void Iv() {
        try {
            aJJ = new HashMap();
            JSONObject jSONObjectHm = aJH.Hm();
            if (jSONObjectHm == null) {
                return;
            }
            Iterator<String> itKeys = jSONObjectHm.keys();
            while (itKeys.hasNext()) {
                String next = itKeys.next();
                JSONObject jSONObjectOptJSONObject = jSONObjectHm.optJSONObject(next);
                if (jSONObjectOptJSONObject != null) {
                    com.kwad.sdk.commercial.a aVar = new com.kwad.sdk.commercial.a();
                    aVar.parseJson(jSONObjectOptJSONObject);
                    aJJ.put(next, aVar);
                }
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    private static void a(String str, JSONArray jSONArray) {
        if (jSONArray != null) {
            try {
                if (jSONArray.length() == 0) {
                    return;
                }
                for (int i = 0; i < jSONArray.length(); i++) {
                    Object obj = jSONArray.get(i);
                    if (obj instanceof String) {
                        com.kwad.sdk.commercial.c.c cVar = new com.kwad.sdk.commercial.c.c();
                        String strA = a(cVar, (String) obj);
                        com.kwad.sdk.commercial.c.c cVar2 = aJI.get(strA);
                        if (cVar2 != null) {
                            cVar2.aKo = true;
                            cVar2.aJX = Double.parseDouble(str);
                        } else {
                            cVar.aKo = true;
                            cVar.aJX = Double.parseDouble(str);
                            aJI.put(strA, cVar);
                        }
                    }
                }
            } catch (JSONException e) {
                ServiceProvider.reportSdkCaughtException(e);
            }
        }
    }

    private static void b(String str, JSONArray jSONArray) {
        if (jSONArray != null) {
            try {
                if (jSONArray.length() == 0) {
                    return;
                }
                for (int i = 0; i < jSONArray.length(); i++) {
                    Object obj = jSONArray.get(i);
                    if (obj instanceof String) {
                        com.kwad.sdk.commercial.c.c cVar = new com.kwad.sdk.commercial.c.c();
                        String strA = a(cVar, (String) obj);
                        com.kwad.sdk.commercial.c.c cVar2 = aJI.get(strA);
                        if (cVar2 != null) {
                            cVar2.aKp = true;
                            cVar2.aKl = Double.parseDouble(str);
                        } else {
                            cVar.aKp = true;
                            cVar.aKl = Double.parseDouble(str);
                            aJI.put(strA, cVar);
                        }
                    }
                }
            } catch (Throwable th) {
                ServiceProvider.reportSdkCaughtException(th);
            }
        }
    }

    private static String a(com.kwad.sdk.commercial.c.b bVar, String str) {
        try {
            int iLastIndexOf = str.lastIndexOf(95);
            int length = str.length() - 1;
            if (str.charAt(length) >= '0' && str.charAt(length) <= '9' && iLastIndexOf != -1) {
                bVar.aKm = str.substring(iLastIndexOf + 1);
                return str.substring(0, iLastIndexOf);
            }
        } catch (Throwable unused) {
        }
        return str;
    }

    private static com.kwad.sdk.commercial.c.b a(d dVar) {
        double d;
        double d2;
        String str;
        com.kwad.sdk.commercial.c.c cVar;
        com.kwad.sdk.commercial.c.c cVar2;
        com.kwad.sdk.commercial.c.b bVar = new com.kwad.sdk.commercial.c.b();
        try {
            if (com.kwad.framework.a.a.oV.booleanValue()) {
                bVar.aJX = dVar.aJP;
            } else {
                bVar.aJX = dVar.aJO;
            }
            bVar.aKl = dVar.aJQ;
            if (!aJI.containsKey(dVar.eventId) || (cVar2 = aJI.get(dVar.eventId)) == null) {
                d = -1.0d;
                d2 = -1.0d;
            } else {
                d = cVar2.aKo ? cVar2.aJX : -1.0d;
                d2 = cVar2.aKp ? cVar2.aKl : -1.0d;
                if (!TextUtils.isEmpty(cVar2.aKm)) {
                    bVar.aKm = cVar2.aKm;
                }
            }
            if (TextUtils.isEmpty(dVar.primaryKey) && com.kwad.framework.a.a.oV.booleanValue()) {
                throw new Exception("primaryKey为空");
            }
            String str2 = dVar.eventId;
            if (!TextUtils.isEmpty(dVar.primaryKey)) {
                if (dVar.msg.has(dVar.primaryKey)) {
                    str = str2 + "_" + dVar.msg.opt(dVar.primaryKey);
                } else {
                    str = str2 + "_" + dVar.primaryKey;
                }
                if (aJI.containsKey(str) && (cVar = aJI.get(str)) != null) {
                    if (cVar.aKo) {
                        d = cVar.aJX;
                    }
                    if (cVar.aKp) {
                        d2 = cVar.aKl;
                    }
                    if (!TextUtils.isEmpty(cVar.aKm)) {
                        bVar.aKm = cVar.aKm;
                    }
                }
            }
            Map<String, com.kwad.sdk.commercial.a> map = aJJ;
            if (map != null && map.containsKey(dVar.eventId)) {
                com.kwad.sdk.core.d.c.d("KCLRefineReport", "命中精细化采样配置 " + dVar.eventId);
                com.kwad.sdk.commercial.a aVar = aJJ.get(dVar.eventId);
                if (aVar != null && aVar.aJu > 0.0d) {
                    bVar.aKm = aVar.minVersion;
                    if (bz.aD(BuildConfig.VERSION_NAME, aVar.minVersion)) {
                        d = aVar.aJu;
                    }
                    com.kwad.sdk.core.d.c.d("KCLRefineReport", "默认采样率： " + aVar.aJu + "  minVersion: " + aVar.minVersion);
                    if (aVar.aJv == null) {
                        d2 = -1.0d;
                        break;
                    }
                    Iterator<f> it = aVar.aJv.iterator();
                    while (true) {
                        if (!it.hasNext()) {
                            d2 = -1.0d;
                            break;
                        }
                        f next = it.next();
                        if (next != null && next.e(dVar)) {
                            d = next.aJX;
                            double d3 = next.aJY;
                            bVar.aKm = next.minVersion;
                            bVar.aKn = bz.aD(next.maxVersion, "0") ? next.maxVersion : null;
                            bVar.aJZ = next.aJZ;
                            com.kwad.sdk.core.d.c.d("KCLRefineReport", "命中精细化采样规则: for msg " + dVar.msg + " minVersion: " + next.minVersion + " maxVersion: " + next.maxVersion + " deviceMode: " + next.aJZ + " ratio: " + next.aJX + " convert: " + next.aJY);
                            d2 = d3;
                            break;
                        }
                    }
                }
            }
            if (d != -1.0d) {
                bVar.aJX = d;
            }
            if (d2 != -1.0d) {
                bVar.aKl = d2;
            } else {
                bVar.aKl = ((h) ServiceProvider.get(h.class)).Gg();
            }
            dVar.aJO = bVar.aJX;
            dVar.aJQ = bVar.aKl;
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
        return bVar;
    }

    private static void b(d dVar) {
        com.kwai.adclient.kscommerciallogger.model.c.a aVarYv;
        if (aJF) {
            com.kwad.sdk.commercial.c.b bVarA = a(dVar);
            if (aJw == -1.0f) {
                aJw = new Random().nextFloat();
            }
            if (aJz == -1.0f) {
                aJz = new Random().nextFloat();
            }
            if (aJH.Hk() || !a(bVarA)) {
                try {
                    if (ILoggerReporter.Category.ERROR_LOG.equals(a(dVar.category, dVar))) {
                        aVarYv = com.kwai.adclient.kscommerciallogger.model.c.a.Yu();
                    } else {
                        aVarYv = com.kwai.adclient.kscommerciallogger.model.c.a.Yv();
                    }
                    com.kwai.adclient.kscommerciallogger.a.Yl().a(aVarYv.c(dVar.aJR).b(dVar.aJS).iD(TextUtils.isEmpty(dVar.tag) ? dVar.eventId : dVar.tag).b(dVar.aJT).iE(dVar.eventId).B(a(dVar.msg, bVarA)).Yw());
                } catch (Throwable th) {
                    ServiceProvider.reportSdkCaughtException(th);
                }
            }
        }
    }

    private static boolean a(com.kwad.sdk.commercial.c.b bVar) {
        if (!bz.aD(BuildConfig.VERSION_NAME, bVar.aKm)) {
            return false;
        }
        if (aJy == -1.0f) {
            aJy = new Random().nextFloat();
        }
        if (aJB == -1.0f) {
            aJB = new Random().nextFloat();
        }
        aJA = new Random().nextFloat();
        aJx = new Random().nextFloat();
        if (bVar.aJZ == 0) {
            aJw = aJx;
            aJz = aJA;
        } else {
            aJw = aJy;
            aJz = aJA;
        }
        com.kwad.sdk.core.d.c.d("KCLRefineReport", " 随机数采样率： " + aJx + " 设备随机采样率：" + aJy + " 随机离线转实时采样率： " + aJA + " 设备随机离线转实时采样率： " + aJB + " 当前采用的采样率： " + aJw + " 采用离线转实时采样率： " + aJz + " 客户端埋点采样率： " + bVar.aJX);
        return ((double) aJw) > bVar.aJX;
    }

    private static void c(d dVar) {
        if (aJG == null) {
            aJG = new CopyOnWriteArrayList();
        }
        if (aJG.size() < ((h) ServiceProvider.get(h.class)).Gy()) {
            aJG.add(dVar);
        }
    }

    public static synchronized void d(d dVar) {
        if (com.kwad.framework.a.a.oV.booleanValue()) {
            if (dVar.category.equals(ILoggerReporter.Category.ERROR_LOG)) {
                com.kwad.sdk.core.d.c.e("KCLogReporter", "reportItem: " + dVar);
            } else {
                com.kwad.sdk.core.d.c.d("KCLogReporter", "reportItem: " + dVar);
            }
        }
        if (!aJC.get()) {
            if (!aJD.get()) {
                c(dVar);
            }
        } else {
            b(dVar);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void b(final a aVar, boolean z) {
        boolean zHj = aVar.Hj();
        aJF = zHj;
        if (zHj) {
            JSONObject jSONObject = new JSONObject();
            ac.putValue(jSONObject, "publish_type", 0);
            ac.putValue(jSONObject, "plug_sdk", z ? 1 : 0);
            com.kwai.adclient.kscommerciallogger.a.Yl().a(new b(), new com.kwai.adclient.kscommerciallogger.a.b() { // from class: com.kwad.sdk.commercial.c.3
                @Override // com.kwai.adclient.kscommerciallogger.a.b
                public final void N(String str, String str2) {
                    O(str, str2);
                }

                private void O(String str, String str2) {
                    aVar.j(str, str2, false);
                }
            }, jSONObject, com.kwad.framework.a.a.oV.booleanValue(), com.kwad.framework.a.a.oV.booleanValue());
            com.kwad.sdk.commercial.g.a.IH().dA(aVar.Hn());
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static synchronized void pf() {
        List<d> list = aJG;
        if (list == null) {
            return;
        }
        Iterator<d> it = list.iterator();
        while (it.hasNext()) {
            b(it.next());
        }
        aJG.clear();
        aJG = null;
    }

    private static String a(String str, d dVar) {
        return (!str.equals(ILoggerReporter.Category.APM_LOG) || ((double) aJz) >= dVar.aJQ) ? str : ILoggerReporter.Category.ERROR_LOG;
    }

    public static void a(String str, com.kwai.adclient.kscommerciallogger.model.d dVar, com.kwad.sdk.commercial.c.a aVar) {
        try {
            d(d.Iz().dm(str).g(0.001d).P(ILoggerReporter.Category.ERROR_LOG.equals(str) ? "ad_sdk_init_error_performance" : "ad_sdk_init_performance", "init_status").b(BusinessType.AD_SDK_INIT).A(aVar).a(dVar));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void f(com.kwad.sdk.commercial.c.a aVar) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.01d).P("ad_sdk_reward_check_result", "check_type").b(BusinessType.AD_REWARD).A(aVar).a(new com.kwai.adclient.kscommerciallogger.model.b("RESULT_CHECK_REWARD")));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void a(boolean z, com.kwad.sdk.commercial.c.a aVar, com.kwai.adclient.kscommerciallogger.model.d dVar) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.01d).P(z ? "ad_sdk_reward_load" : "ad_sdk_fullscreen_load", "load_status").b(z ? BusinessType.AD_REWARD : BusinessType.AD_FULLSCREEN).A(aVar).a(dVar));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void b(boolean z, com.kwad.sdk.commercial.c.a aVar) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.ERROR_LOG).g(1.0d).P(z ? "ad_sdk_reward_download_error" : "ad_sdk_fullscreen_download_error", "download_type").b(z ? BusinessType.AD_REWARD : BusinessType.AD_FULLSCREEN).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.b.buD));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void c(boolean z, com.kwad.sdk.commercial.c.a aVar) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.01d).P(z ? "ad_sdk_reward_page_show" : "ad_sdk_fullscreen_page_show", "page_status").b(z ? BusinessType.AD_REWARD : BusinessType.AD_FULLSCREEN).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.a.bug));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void d(boolean z, com.kwad.sdk.commercial.c.a aVar) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.01d).P(z ? "ad_sdk_reward_callback_interaction" : "ad_sdk_fullscreen_callback_interaction", "callback_type").b(z ? BusinessType.AD_REWARD : BusinessType.AD_FULLSCREEN).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.a.buq));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void e(boolean z, com.kwad.sdk.commercial.c.a aVar) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.01d).P(z ? "ad_sdk_reward_callback_load" : "ad_sdk_fullscreen_callback_load", "callback_type").b(z ? BusinessType.AD_REWARD : BusinessType.AD_FULLSCREEN).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.a.buq));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void g(com.kwad.sdk.commercial.c.a aVar) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.5d).P("ad_sdk_webview_track", "scene_id").b(BusinessType.AD_WEBVIEW).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.a.buq));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void f(boolean z, com.kwad.sdk.commercial.c.a aVar) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.ERROR_LOG).g(1.0d).P(z ? "ad_sdk_reward_play_error" : "ad_sdk_fullscreen_play_error", "reward_type").b(z ? BusinessType.AD_REWARD : BusinessType.AD_FULLSCREEN).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.b.buJ));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void a(boolean z, String str, com.kwad.sdk.commercial.c.a aVar) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.ERROR_LOG).g(1.0d).P(str, "reward_type").b(z ? BusinessType.AD_REWARD : BusinessType.AD_FULLSCREEN).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.b.buJ));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void b(String str, com.kwad.sdk.commercial.c.a aVar) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.ERROR_LOG).g(1.0d).P(str, "status").b(BusinessType.OTHER).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.b.buL));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void h(com.kwad.sdk.commercial.c.a aVar) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.ERROR_LOG).g(0.01d).P("ad_sdk_reward_performance", "reward_type").b(BusinessType.AD_REWARD).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.b.buS));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void i(com.kwad.sdk.commercial.c.a aVar) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.01d).P("ad_sdk_reward_performance", "page_status").b(BusinessType.AD_REWARD).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.b.buS));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void a(String str, HybridLoadMsg hybridLoadMsg) {
        try {
            d(d.Iz().dm(str).g(1.0E-4d).P("union_web_cache_download_event", "state").b(BusinessType.WEB_CACHE).A(hybridLoadMsg).a(com.kwai.adclient.kscommerciallogger.model.b.buS));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void b(String str, HybridLoadMsg hybridLoadMsg) {
        try {
            d(d.Iz().dm(str).g(ILoggerReporter.Category.ERROR_LOG.equals(str) ? 1.0d : 0.001d).P("union_web_cache_load_event", "state").b(BusinessType.WEB_CACHE).A(hybridLoadMsg).a(com.kwai.adclient.kscommerciallogger.model.b.buS));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void a(String str, WebViewLoadMsg webViewLoadMsg) {
        try {
            d(d.Iz().dm(str).g(1.0d).P("union_webview_load_event", "state").A(webViewLoadMsg).a(com.kwai.adclient.kscommerciallogger.model.b.buS));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void a(String str, WebViewCommercialMsg webViewCommercialMsg) {
        try {
            if (webViewCommercialMsg.rate >= 0.0d) {
                ac.putValue(webViewCommercialMsg.msg, n.C, webViewCommercialMsg.rate);
            }
            if (TextUtils.isEmpty(webViewCommercialMsg.primaryKey)) {
                webViewCommercialMsg.primaryKey = "web_log";
            }
            d(d.Iz().dm(str).g(webViewCommercialMsg.rate).P(webViewCommercialMsg.eventId, webViewCommercialMsg.primaryKey).b(webViewCommercialMsg.biz).a(webViewCommercialMsg.subBiz).i(webViewCommercialMsg.msg).a(com.kwai.adclient.kscommerciallogger.model.b.buS));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void b(j jVar) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(1.0E-5d).P("ad_perf_monitor_net_success", "network_monitor").A(jVar).a(com.kwai.adclient.kscommerciallogger.model.b.buS));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void b(com.kwad.sdk.core.network.i iVar) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.1d).P("ad_perf_monitor_net_error", "network_monitor").A(iVar).a(com.kwai.adclient.kscommerciallogger.model.b.buS));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void b(com.kwad.sdk.utils.b.a aVar) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.01d).P("ad_union_kv_fail_rate", "kv").A(aVar).a(com.kwai.adclient.kscommerciallogger.model.b.buS));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void j(final com.kwad.sdk.commercial.c.a aVar) {
        if (((h) ServiceProvider.get(h.class)).Gw()) {
            i.schedule(new bi() { // from class: com.kwad.sdk.commercial.c.4
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    c.d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.1d).P("ad_sdk_splash_load", "status").b(BusinessType.AD_SPLASH).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.a.buq));
                }
            }, 10L, TimeUnit.SECONDS);
            return;
        }
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.1d).P("ad_sdk_splash_load", "status").b(BusinessType.AD_SPLASH).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.a.buq));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void k(final com.kwad.sdk.commercial.c.a aVar) {
        if (((h) ServiceProvider.get(h.class)).Gw()) {
            i.schedule(new bi() { // from class: com.kwad.sdk.commercial.c.5
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    c.d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.1d).P("ad_sdk_splash_preload", "status").b(BusinessType.AD_SPLASH).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.a.buq));
                }
            }, 10L, TimeUnit.SECONDS);
            return;
        }
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.1d).P("ad_sdk_splash_preload", "status").b(BusinessType.AD_SPLASH).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.a.buq));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void g(final boolean z, final com.kwad.sdk.commercial.c.a aVar) {
        if (((h) ServiceProvider.get(h.class)).Gw()) {
            i.schedule(new bi() { // from class: com.kwad.sdk.commercial.c.6
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    c.d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(z ? 1.0d : 0.01d).P("ad_sdk_splash_single_cache", "status").b(BusinessType.AD_SPLASH).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.a.bup));
                }
            }, 10L, TimeUnit.SECONDS);
            return;
        }
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(z ? 1.0d : 0.01d).P("ad_sdk_splash_single_cache", "status").b(BusinessType.AD_SPLASH).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.a.bup));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void l(final com.kwad.sdk.commercial.c.a aVar) {
        if (((h) ServiceProvider.get(h.class)).Gw()) {
            i.schedule(new bi() { // from class: com.kwad.sdk.commercial.c.7
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    c.d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.01d).P("ad_sdk_splash_cache", "cache").b(BusinessType.AD_SPLASH).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.a.bup));
                }
            }, 10L, TimeUnit.SECONDS);
            return;
        }
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.01d).P("ad_sdk_splash_cache", "cache").b(BusinessType.AD_SPLASH).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.a.bup));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void m(final com.kwad.sdk.commercial.c.a aVar) {
        if (((h) ServiceProvider.get(h.class)).Gw()) {
            i.schedule(new bi() { // from class: com.kwad.sdk.commercial.c.8
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    c.d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.01d).P("ad_sdk_splash_show", "status").b(BusinessType.AD_SPLASH).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.a.buq));
                }
            }, 10L, TimeUnit.SECONDS);
            return;
        }
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.01d).P("ad_sdk_splash_show", "status").b(BusinessType.AD_SPLASH).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.a.buq));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void n(final com.kwad.sdk.commercial.c.a aVar) {
        if (((h) ServiceProvider.get(h.class)).Gw()) {
            i.schedule(new bi() { // from class: com.kwad.sdk.commercial.c.9
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    c.d(d.Iz().dm(ILoggerReporter.Category.ERROR_LOG).g(1.0d).P("ad_sdk_splash_monitor_view_error", "status").b(BusinessType.AD_SPLASH).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.a.buq));
                }
            }, 10L, TimeUnit.SECONDS);
            return;
        }
        try {
            d(d.Iz().dm(ILoggerReporter.Category.ERROR_LOG).g(1.0d).P("ad_sdk_splash_monitor_view_error", "status").b(BusinessType.AD_SPLASH).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.a.buq));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void o(final com.kwad.sdk.commercial.c.a aVar) {
        if (((h) ServiceProvider.get(h.class)).Gw()) {
            i.schedule(new bi() { // from class: com.kwad.sdk.commercial.c.10
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    c.d(d.Iz().dm(ILoggerReporter.Category.ERROR_LOG).g(1.0d).P("ad_sdk_splash_monitor_template_data_error", "status").b(BusinessType.AD_SPLASH).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.a.buq));
                }
            }, 10L, TimeUnit.SECONDS);
            return;
        }
        try {
            d(d.Iz().dm(ILoggerReporter.Category.ERROR_LOG).g(1.0d).P("ad_sdk_splash_monitor_template_data_error", "status").b(BusinessType.AD_SPLASH).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.a.buq));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void p(final com.kwad.sdk.commercial.c.a aVar) {
        if (((h) ServiceProvider.get(h.class)).Gw()) {
            i.schedule(new bi() { // from class: com.kwad.sdk.commercial.c.2
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    c.d(d.Iz().dm(ILoggerReporter.Category.ERROR_LOG).g(1.0d).P("ad_sdk_splash_monitor_errorcode_error", "status").b(BusinessType.AD_SPLASH).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.a.buq));
                }
            }, 10L, TimeUnit.SECONDS);
            return;
        }
        try {
            d(d.Iz().dm(ILoggerReporter.Category.ERROR_LOG).g(1.0d).P("ad_sdk_splash_monitor_errorcode_error", "status").b(BusinessType.AD_SPLASH).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.a.buq));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void h(JSONObject jSONObject) {
        try {
            int iOptInt = jSONObject.optInt("load_status");
            d(d.Iz().dm((iOptInt == 3 || iOptInt == 4 || iOptInt == 7) ? ILoggerReporter.Category.ERROR_LOG : ILoggerReporter.Category.APM_LOG).g(1.0d).h(0.1d).i(0.001d).P("ad_sdk_dynamic_update", "load_status").a(com.kwai.adclient.kscommerciallogger.model.a.buq).i(jSONObject));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void b(String str, com.kwai.adclient.kscommerciallogger.model.d dVar, com.kwad.sdk.commercial.c.a aVar) {
        try {
            d(d.Iz().dm(str).g(0.001d).P("ad_sdk_resource_warmup", "warm_up").b(BusinessType.OTHER).A(aVar).a(dVar));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void c(String str, com.kwai.adclient.kscommerciallogger.model.d dVar, com.kwad.sdk.commercial.c.a aVar) {
        try {
            d(d.Iz().dm(str).g(0.001d).P("ad_sdk_local_warmup", "warm_up").b(BusinessType.OTHER).A(aVar).a(dVar));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void q(com.kwad.sdk.commercial.c.a aVar) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.01d).P("ad_sdk_block_info", "block").a(com.kwai.adclient.kscommerciallogger.model.b.buJ).A(aVar));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void r(com.kwad.sdk.commercial.c.a aVar) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.01d).P("ad_image_load_perf", "image_perf").A(aVar).a(com.kwai.adclient.kscommerciallogger.model.d.buS));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void s(com.kwad.sdk.commercial.c.a aVar) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(1.0d).P("ad_thread_monitor", "thread_perf").A(aVar).a(com.kwai.adclient.kscommerciallogger.model.d.buS));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void t(com.kwad.sdk.commercial.c.a aVar) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.001d).P("ad_video_load_perf", "video_load_perf").dn("ad_video_load_perf").A(aVar).a(com.kwai.adclient.kscommerciallogger.model.d.buS));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void u(com.kwad.sdk.commercial.c.a aVar) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.001d).P("ad_video_load_failed", "video_load_failed").dn("ad_video_load_failed").A(aVar).a(com.kwai.adclient.kscommerciallogger.model.d.buS));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void v(com.kwad.sdk.commercial.c.a aVar) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(1.0d).P("ad_sdk_aggregation_monitor", "ranger").dn("ad_sdk_aggregation_monitor").A(aVar).a(com.kwai.adclient.kscommerciallogger.model.d.buS));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void w(com.kwad.sdk.commercial.c.a aVar) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.01d).P("ad_wayne_player_vse_monitor", "status").A(aVar).a(com.kwai.adclient.kscommerciallogger.model.d.buS));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void x(com.kwad.sdk.commercial.c.a aVar) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.01d).P("ad_sdk_installer_info", "status").A(aVar).a(com.kwai.adclient.kscommerciallogger.model.d.buS));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void y(com.kwad.sdk.commercial.c.a aVar) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.01d).P("ad_sdk_uaid_data_performance", "status").A(aVar).a(com.kwai.adclient.kscommerciallogger.model.a.buq));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void c(com.kwad.sdk.commercial.c.a aVar, boolean z) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.ERROR_LOG).g(z ? 1.0d : 1.0E-4d).P("ad_sdk_disk_monitor", "reward_type").A(aVar).a(com.kwai.adclient.kscommerciallogger.model.b.buL));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void d(com.kwad.sdk.commercial.c.a aVar, boolean z) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.01d).P("ad_media_configuration_switch", "device_os_id").A(aVar).a(com.kwai.adclient.kscommerciallogger.model.d.buS));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void b(boolean z, com.kwad.sdk.commercial.c.a aVar, com.kwai.adclient.kscommerciallogger.model.d dVar) {
        try {
            d(d.Iz().dm(z ? ILoggerReporter.Category.ERROR_LOG : ILoggerReporter.Category.APM_LOG).g(z ? 1.0d : 0.01d).P(z ? "ad_sdk_innerec_error" : "ad_sdk_innerec_performance", "status").b(BusinessType.OTHER).A(aVar).a(dVar));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void z(com.kwad.sdk.commercial.c.a aVar) {
        try {
            d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.01d).P("ad_sdk_bid_token", "status").A(aVar).a(com.kwai.adclient.kscommerciallogger.model.d.buS));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    private static JSONObject a(JSONObject jSONObject, com.kwad.sdk.commercial.c.b bVar) {
        try {
            ac.putValue(jSONObject, n.C, bVar.aJX);
            if (bVar.aJX > 0.0d) {
                ac.putValue(jSONObject, "ratio_count", a(1.0d, bVar.aJX, 0));
            }
            ac.putValue(jSONObject, "debug_mode", com.kwad.framework.a.a.oV.booleanValue() ? 1 : 0);
            ac.putValue(jSONObject, "convert_ratio", bVar.aKl);
            if (bVar.aKl > 0.0d) {
                ac.putValue(jSONObject, "convert_ratio_count", a(1.0d, bVar.aKl, 0));
            }
            return jSONObject;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
            return jSONObject;
        }
    }

    private static double a(double d, double d2, int i) {
        return new BigDecimal(Double.toString(1.0d)).divide(new BigDecimal(Double.toString(d2)), 0, RoundingMode.HALF_UP).doubleValue();
    }
}

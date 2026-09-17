package com.kwad.sdk.core.config;

import android.content.Context;
import android.os.Looper;
import android.text.TextUtils;
import com.ksad.annotation.invoker.ForInvoker;
import com.kwad.sdk.components.DevelopMangerComponents;
import com.kwad.sdk.core.config.item.f;
import com.kwad.sdk.core.config.item.g;
import com.kwad.sdk.core.config.item.l;
import com.kwad.sdk.core.config.item.p;
import com.kwad.sdk.core.config.item.s;
import com.kwad.sdk.core.response.model.SdkConfigData;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ai;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.br;
import com.kwad.sdk.utils.i;
import java.util.HashSet;
import java.util.List;
import java.util.Set;
import java.util.concurrent.atomic.AtomicBoolean;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class e {
    private static volatile SdkConfigData aQW;
    private static final AtomicBoolean aQV = new AtomicBoolean(false);
    private static final Object mLock = new Object();

    public static boolean FE() {
        return false;
    }

    public static boolean Jv() {
        return c.aNk.getValue().intValue() == 1;
    }

    public static int Jw() {
        return c.aNl.getValue().intValue();
    }

    public static int Jx() {
        return c.aNm.getValue().intValue();
    }

    public static boolean Jy() {
        return c.aNo.getValue().intValue() > 0;
    }

    public static boolean Jz() {
        return c.aNm.getValue().intValue() == 2;
    }

    public static int JA() {
        return c.aNn.getValue().intValue();
    }

    public static boolean JB() {
        return c.aNs.getValue().intValue() > 0;
    }

    public static boolean JC() {
        return c.aNt.getValue().intValue() == 1;
    }

    public static int JD() {
        return c.aNs.getValue().intValue();
    }

    public static int Ge() {
        if (aQW != null) {
            return aQW.goodIdcThresholdMs;
        }
        return 200;
    }

    public static synchronized void bM(Context context) {
        AtomicBoolean atomicBoolean = aQV;
        if (atomicBoolean.get()) {
            return;
        }
        com.kwad.sdk.core.d.c.d("SdkConfigManager", "loadCache");
        c.init();
        JE();
        b.bL(context);
        Kd();
        atomicBoolean.set(true);
    }

    public static boolean isLoaded() {
        return aQV.get();
    }

    @ForInvoker(methodId = "initConfigList")
    private static void JE() {
        com.kwad.components.ad.e.a.init();
        com.kwad.components.ad.feed.a.a.init();
        com.kwad.components.ad.fullscreen.a.a.init();
        com.kwad.components.ad.interstitial.b.a.init();
        com.kwad.components.ad.reward.a.a.init();
        com.kwad.components.ad.splashscreen.b.a.init();
    }

    public static <T> T b(com.kwad.sdk.core.config.item.b<T> bVar) {
        if (!isLoaded()) {
            final Context contextUm = ServiceProvider.Um();
            b.a(contextUm, bVar);
            i.execute(new bi() { // from class: com.kwad.sdk.core.config.e.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    e.bM(contextUm);
                }
            });
        }
        T value = bVar.getValue();
        return value != null ? value : bVar.Ln();
    }

    public static JSONObject a(f fVar) {
        JSONObject jSONObject = (JSONObject) b(fVar);
        return jSONObject != null ? jSONObject : fVar.Ln();
    }

    public static JSONObject a(com.kwad.sdk.core.config.item.e eVar) {
        JSONObject jSONObject = (JSONObject) b(eVar);
        return jSONObject != null ? jSONObject : eVar.Ln();
    }

    public static int cP(String str) {
        Integer value = c.aNQ.getValue(str);
        if (value != null) {
            return value.intValue();
        }
        return 0;
    }

    public static int a(l lVar) {
        Integer numLn = (Integer) b((com.kwad.sdk.core.config.item.b) lVar);
        if (numLn == null) {
            numLn = lVar.Ln();
        }
        return numLn.intValue();
    }

    public static long a(p pVar) {
        Long lLn = (Long) b(pVar);
        if (lLn == null) {
            lLn = pVar.Ln();
        }
        return lLn.longValue();
    }

    public static double a(g gVar) {
        Double dLn = (Double) b(gVar);
        if (dLn == null) {
            dLn = gVar.Ln();
        }
        return dLn.doubleValue();
    }

    public static boolean a(com.kwad.sdk.core.config.item.d dVar) {
        Boolean boolLn = (Boolean) b(dVar);
        if (boolLn == null) {
            boolLn = dVar.Ln();
        }
        return boolLn.booleanValue();
    }

    public static boolean b(l lVar) {
        Integer num = (Integer) b((com.kwad.sdk.core.config.item.b) lVar);
        if (num != null) {
            return num.intValue() > 0;
        }
        return lVar.Ln().intValue() > 0;
    }

    public static String a(s sVar) {
        String str = (String) b(sVar);
        return str != null ? str : sVar.Ln();
    }

    public static String Q(String str, String str2) {
        if (br.isNullString(str)) {
            return str2;
        }
        JSONObject abConfig = Kd().getAbConfig();
        if (abConfig != null && abConfig.has(str)) {
            return abConfig.optString(str);
        }
        JSONObject appConfig = Kd().getAppConfig();
        if (appConfig != null && appConfig.has(str)) {
            return appConfig.optString(str);
        }
        JSONObject adxConfig = Kd().getAdxConfig();
        return (adxConfig == null || !adxConfig.has(str)) ? str2 : adxConfig.optString(str);
    }

    public static boolean f(String str, boolean z) {
        if (br.isNullString(str)) {
            return z;
        }
        JSONObject abConfig = Kd().getAbConfig();
        if (abConfig != null && abConfig.has(str)) {
            return abConfig.optBoolean(str);
        }
        JSONObject appConfig = Kd().getAppConfig();
        if (appConfig != null && appConfig.has(str)) {
            return appConfig.optBoolean(str);
        }
        JSONObject adxConfig = Kd().getAdxConfig();
        return (adxConfig == null || !adxConfig.has(str)) ? z : adxConfig.optBoolean(str);
    }

    public static List<String> FX() {
        return c.aNI.getValue();
    }

    public static List<String> JF() {
        return c.aNK.getValue();
    }

    public static int FD() {
        return c.aNa.getValue().intValue();
    }

    public static List<String> JG() {
        return c.aNJ.getValue();
    }

    public static int JH() {
        return c.aPl.getValue().intValue();
    }

    public static int JI() {
        return c.aPm.getValue().intValue();
    }

    public static String JJ() {
        return c.aNE.getValue();
    }

    public static String JK() {
        return c.aNF.getValue();
    }

    public static boolean JL() {
        return c.aNg.getValue().intValue() == 1;
    }

    public static int JM() {
        return c.aNh.getValue().intValue();
    }

    public static boolean JN() {
        return c.aNi.getValue().intValue() == 1;
    }

    public static int JO() {
        return c.aNj.getValue().intValue();
    }

    public static boolean FF() {
        com.kwad.sdk.components.d.f(DevelopMangerComponents.class);
        return c.aNf.getValue().intValue() == 1;
    }

    public static int JP() {
        return c.aNT.getValue().intValue();
    }

    public static int JQ() {
        return c.aNU.getValue().intValue();
    }

    public static int JR() {
        return c.aNV.getValue().intValue();
    }

    public static long JS() {
        return ((long) c.aNW.getValue().intValue()) * 60000;
    }

    public static boolean FU() {
        return c.aOb.getValue().intValue() == 1;
    }

    public static boolean FR() {
        return c.aOc.getValue().intValue() == 1;
    }

    public static boolean FT() {
        return c.aOd.getValue().intValue() == 1;
    }

    public static boolean al(long j) {
        return (j & c.aNz.getValue().longValue()) != 0;
    }

    public static boolean JT() {
        return c.aOf.getValue().intValue() == 1;
    }

    public static boolean JU() {
        return c.aOg.getValue().intValue() == 1;
    }

    public static String FV() {
        return c.aOp.getImei();
    }

    public static String FW() {
        return c.aOp.getOaid();
    }

    public static int JV() {
        return c.aOn.getValue().intValue();
    }

    public static boolean JW() {
        return c.aOo.getValue().booleanValue();
    }

    public static boolean JX() {
        return com.kwad.sdk.core.h.a.OH();
    }

    public static boolean JY() {
        return a(c.aOu);
    }

    public static boolean JZ() {
        return !c.aOv.getValue().booleanValue();
    }

    public static boolean Ka() {
        return a(c.aOt);
    }

    public static boolean Kb() {
        return c.aOx.getValue().intValue() == 1;
    }

    public static int Kc() {
        return c.aOy.getValue().intValue();
    }

    public static SdkConfigData Kd() {
        if (aQW != null) {
            return aQW;
        }
        if (Looper.getMainLooper() == Looper.myLooper()) {
            com.kwad.sdk.core.d.c.d("SdkConfigManager", "getSdkConfigData is ui thread");
            aQW = Ke();
        } else {
            synchronized (mLock) {
                if (aQW == null) {
                    return Ke();
                }
            }
        }
        return aQW;
    }

    private static SdkConfigData Ke() {
        aQW = new SdkConfigData();
        String strDv = ai.dv(ServiceProvider.Um());
        if (!TextUtils.isEmpty(strDv)) {
            try {
                aQW.parseJson(new JSONObject(strDv));
            } catch (Exception e) {
                com.kwad.sdk.core.d.c.printStackTrace(e);
            }
        } else {
            com.kwad.sdk.core.d.c.d("SdkConfigManager", "configCache is empty");
        }
        return aQW;
    }

    public static void f(SdkConfigData sdkConfigData) {
        synchronized (mLock) {
            aQW = sdkConfigData;
        }
    }

    public static boolean Kf() {
        return c.aNu.getValue().intValue() == 1;
    }

    public static boolean Kg() {
        return c.aNv.getValue().intValue() == 1;
    }

    @Deprecated
    public static int Gm() {
        return c.aNx.getValue().intValue();
    }

    public static boolean Kh() {
        return c.aNy.getValue().booleanValue();
    }

    public static String getUserAgent() {
        return c.aOD.getValue();
    }

    public static boolean FY() {
        return c.aOB.getValue().intValue() == 1;
    }

    public static boolean FZ() {
        return c.aOC.getValue().booleanValue();
    }

    public static boolean Ki() {
        return c.aPa.getValue().intValue() == 1;
    }

    public static boolean Ga() {
        return c.aOE.getValue().intValue() == 1;
    }

    public static int Kj() {
        return c.aNw.getValue().intValue();
    }

    public static int Kk() {
        return c.aOG.getValue().intValue();
    }

    public static int Kl() {
        return c.aOF.getValue().intValue();
    }

    public static boolean Km() {
        return c.aOH.getValue().intValue() == 1;
    }

    public static double Gg() {
        return c.aOM.getValue().floatValue();
    }

    public static boolean Kn() {
        return c.aOI.getValue().booleanValue();
    }

    public static float Ko() {
        float fFloatValue = c.aOJ.getValue().floatValue();
        if (fFloatValue <= 0.0f || fFloatValue > 1.0f) {
            return 0.3f;
        }
        return fFloatValue;
    }

    public static float Kp() {
        return c.aOL.getValue().floatValue();
    }

    public static float Kq() {
        return c.aOK.getValue().floatValue();
    }

    public static boolean Kr() {
        return c.aON.getValue().booleanValue();
    }

    public static boolean hM() {
        return c.aOQ.getValue().booleanValue();
    }

    public static boolean Ks() {
        return c.aOR.getValue().booleanValue();
    }

    public static boolean Kt() {
        return c.aOS.getValue().intValue() > 0;
    }

    public static boolean Ku() {
        return c.aOZ.getValue().intValue() == 1;
    }

    public static long Kv() {
        return c.aOX.getValue().longValue();
    }

    public static String getLogObiwanData() {
        return c.aOW.getValue();
    }

    public static boolean Gc() {
        return c.aPb.getValue().booleanValue();
    }

    public static boolean Gd() {
        return c.aPc.getValue().booleanValue();
    }

    public static int Gf() {
        return c.aPe.getValue().intValue();
    }

    public static boolean Kw() {
        return c.aPd.Ls();
    }

    public static com.kwad.sdk.core.network.idc.a.b Kx() {
        return c.aPf.getValue();
    }

    public static int Ky() {
        return c.aPg.getValue().intValue();
    }

    public static long Kz() {
        return c.aPh.getValue().longValue();
    }

    public static int KA() {
        return c.aPi.getValue().intValue();
    }

    public static boolean KB() {
        return c.aPj.getValue().floatValue() == 1.0f;
    }

    public static boolean KC() {
        return c.aPk.Ls();
    }

    public static boolean KD() {
        return c.aPn.Ls();
    }

    public static String KE() {
        return c.aPo.getValue();
    }

    public static String KF() {
        return c.aPp.getValue();
    }

    public static String KG() {
        return c.aPq.getValue();
    }

    public static boolean DH() {
        return c.aPr.getValue().booleanValue();
    }

    public static boolean KH() {
        return c.aPs.getValue().booleanValue();
    }

    public static int KI() {
        return c.aPt.getValue().intValue();
    }

    public static int KJ() {
        return c.aPv.getValue().intValue();
    }

    public static boolean Gh() {
        return c.aPz.getValue().booleanValue();
    }

    public static boolean KK() {
        return c.aPB.getValue().booleanValue();
    }

    public static int KL() {
        return c.aPC.getValue().intValue();
    }

    public static boolean Gl() {
        return c.aPP.getValue().booleanValue();
    }

    public static boolean Gn() {
        return c.aPT.Ls();
    }

    public static boolean KM() {
        return c.aQb.Ls();
    }

    public static List<String> getTKPreloadMemCacheTemplates() {
        return c.aPY.getValue();
    }

    public static int getTKErrorDetailCount() {
        return c.aQc.getValue().intValue();
    }

    public static boolean KN() {
        return c.aQd.Ls();
    }

    public static boolean GH() {
        return c.aQe.Ls();
    }

    public static int cO(String str) {
        return c.aQh.ei(str);
    }

    public static boolean KO() {
        return c.aQi.getValue().booleanValue();
    }

    public static int KP() {
        return c.aQk.getValue().intValue();
    }

    public static int KQ() {
        return c.aQj.getValue().intValue();
    }

    public static boolean Gu() {
        return c.aQm.getValue().booleanValue();
    }

    public static int Gv() {
        return c.aQn.getValue().intValue();
    }

    public static long KR() {
        return c.aNq.getValue().longValue();
    }

    public static long KS() {
        return c.aNr.getValue().longValue();
    }

    public static boolean KT() {
        return c.aMY.getValue().booleanValue();
    }

    public static Long KU() {
        return c.aMZ.getValue();
    }

    public static boolean KV() {
        int iIntValue = c.aQo.getValue().intValue();
        return iIntValue == 1 || iIntValue == 3;
    }

    public static boolean Gw() {
        int iIntValue = c.aQo.getValue().intValue();
        return iIntValue == 2 || iIntValue == 3;
    }

    public static long KW() {
        return c.aQp.getValue().longValue();
    }

    public static String KX() {
        return c.aQs.getValue();
    }

    public static String KY() {
        return c.aQD.getValue();
    }

    public static String KZ() {
        return c.aQE.getValue();
    }

    public static boolean La() {
        return c.aQF.Ls();
    }

    public static int Gx() {
        return c.aQH.getValue().intValue();
    }

    public static String Lb() {
        return c.aQI.getValue();
    }

    public static String Lc() {
        return c.aQx.getValue();
    }

    public static String Ld() {
        return c.aQy.getValue();
    }

    public static boolean Le() {
        return c.aQw.getValue().booleanValue();
    }

    public static String Lf() {
        return c.aQz.getValue();
    }

    public static int Gy() {
        return c.aQJ.getValue().intValue();
    }

    public static int Lg() {
        return c.aQK.getValue().intValue();
    }

    public static String Lh() {
        return c.aQL.getValue();
    }

    public static String Li() {
        return c.aQM.getValue();
    }

    public static List<String> Lj() {
        return c.aQN.getValue();
    }

    public static String Lk() {
        return c.aQO.getValue();
    }

    public static boolean Ll() {
        return c.aQP.getValue().booleanValue();
    }

    public static boolean enableInflaterOptimize() {
        return c.aQQ.getValue().booleanValue();
    }

    public static Set<String> Lm() {
        HashSet hashSet = new HashSet();
        hashSet.add("android.widget.View");
        hashSet.add("android.webkit.View");
        hashSet.add("android.app.View");
        return hashSet;
    }
}

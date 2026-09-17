package com.kwad.sdk.utils;

import android.content.Context;
import android.os.Build;
import android.text.TextUtils;
import androidx.core.content.ContextCompat;
import com.kwad.components.offline.api.BuildConfig;
import com.kwad.sdk.app.AppPackageInfo;
import com.kwad.sdk.service.ServiceProvider;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public final class bf {
    public static String bqb = "";

    private static String getSdkVersion() {
        return BuildConfig.VERSION_NAME;
    }

    static /* synthetic */ String A(Context context, boolean z) {
        return dZ(context);
    }

    static /* synthetic */ String cA(boolean z) {
        return cv(true);
    }

    static /* synthetic */ String cB(boolean z) {
        return cw(true);
    }

    static /* synthetic */ String cC(boolean z) {
        return Ws();
    }

    static /* synthetic */ String cD(boolean z) {
        return Wt();
    }

    static /* synthetic */ String cE(boolean z) {
        return Wu();
    }

    static /* synthetic */ String cx(boolean z) {
        return cu(true);
    }

    static /* synthetic */ String cy(boolean z) {
        return Wq();
    }

    static /* synthetic */ String cz(boolean z) {
        return Wr();
    }

    static /* synthetic */ String q(Context context, boolean z) {
        return j(context, true);
    }

    static /* synthetic */ String r(Context context, boolean z) {
        return k(context, true);
    }

    static /* synthetic */ String s(Context context, boolean z) {
        return l(context, true);
    }

    static /* synthetic */ String t(Context context, boolean z) {
        return m(context, true);
    }

    static /* synthetic */ String u(Context context, boolean z) {
        return n(context, true);
    }

    static /* synthetic */ String v(Context context, boolean z) {
        return o(context, true);
    }

    static /* synthetic */ String w(Context context, boolean z) {
        return p(context, true);
    }

    static /* synthetic */ String x(Context context, boolean z) {
        return dV(context);
    }

    static /* synthetic */ String y(Context context, boolean z) {
        return dX(context);
    }

    static /* synthetic */ String z(Context context, boolean z) {
        return ea(context);
    }

    public static void init(Context context) {
        com.kwad.sdk.e.b.a(eb(context));
    }

    public static String dN(Context context) {
        return j(context, false);
    }

    private static String j(Context context, boolean z) {
        String strB = bt.B(context, z);
        if (!z) {
            return TextUtils.isEmpty(strB) ? "" : strB;
        }
        if (!TextUtils.isEmpty(strB)) {
            return com.kwad.sdk.e.b.a(be.usePhoneStateDisable() && !TextUtils.isEmpty(be.getDevImei()), strB, 0);
        }
        if (Build.VERSION.SDK_INT >= 29) {
            return com.kwad.sdk.e.b.a(false, strB, 4);
        }
        if (be.usePhoneStateDisable() || !t.UV()) {
            return com.kwad.sdk.e.b.a(false, strB, 1);
        }
        return com.kwad.sdk.e.b.a(false, strB, SystemUtil.en(context) ? 3 : 1);
    }

    public static String getOaid() {
        return cu(false);
    }

    private static String cu(boolean z) {
        String strCF = bt.cF(z);
        if (!z) {
            return TextUtils.isEmpty(strCF) ? "" : strCF;
        }
        if (!TextUtils.isEmpty(strCF)) {
            return com.kwad.sdk.e.b.a(be.useOaidDisable() && !TextUtils.isEmpty(be.getDevOaid()), strCF, 0);
        }
        if (be.useOaidDisable() || !t.UR()) {
            return com.kwad.sdk.e.b.a(false, strCF, 1);
        }
        return com.kwad.sdk.e.b.a(false, strCF, 5);
    }

    public static String dO(Context context) {
        return k(context, false);
    }

    private static String k(Context context, boolean z) {
        String strDO = bt.dO(context);
        if (!z) {
            return TextUtils.isEmpty(strDO) ? "" : strDO;
        }
        if (!TextUtils.isEmpty(strDO)) {
            return com.kwad.sdk.e.b.a(be.usePhoneStateDisable() && !TextUtils.isEmpty(be.getDevAndroidId()), strDO, 0);
        }
        if (be.usePhoneStateDisable() || !t.UP()) {
            return com.kwad.sdk.e.b.a(false, strDO, 1);
        }
        return com.kwad.sdk.e.b.a(false, strDO, 5);
    }

    public static String dP(Context context) {
        return l(context, false);
    }

    private static String l(Context context, boolean z) {
        String strEB = bt.eB(context);
        if (!z) {
            return TextUtils.isEmpty(strEB) ? "" : strEB;
        }
        if (!TextUtils.isEmpty(strEB)) {
            return com.kwad.sdk.e.b.a(be.useMacAddressDisable() && !TextUtils.isEmpty(be.getDevMacAddress()), strEB.toLowerCase(), 0);
        }
        if (be.useMacAddressDisable() || !t.UQ()) {
            return com.kwad.sdk.e.b.a(false, strEB, 0);
        }
        return com.kwad.sdk.e.b.a(false, strEB, aw.aA(context, com.kuaishou.weapon.p0.g.d) == 0 ? 3 : 1);
    }

    public static String dQ(Context context) {
        return m(context, false);
    }

    private static String m(Context context, boolean z) {
        String[] strArrEv = bt.ev(context);
        String str = (strArrEv == null || strArrEv.length <= 0) ? null : strArrEv[0];
        if (!z) {
            return TextUtils.isEmpty(str) ? "" : str;
        }
        if (!TextUtils.isEmpty(str)) {
            return com.kwad.sdk.e.b.a(be.usePhoneStateDisable() && !TextUtils.isEmpty(be.getDevImei()), str, 0);
        }
        if (Build.VERSION.SDK_INT >= 29) {
            return com.kwad.sdk.e.b.a(false, str, 4);
        }
        if (be.usePhoneStateDisable() || !t.UV()) {
            return com.kwad.sdk.e.b.a(false, str, 1);
        }
        return com.kwad.sdk.e.b.a(false, str, SystemUtil.en(context) ? 3 : 1);
    }

    public static String dR(Context context) {
        return n(context, false);
    }

    private static String n(Context context, boolean z) {
        String[] strArrEv = bt.ev(context);
        String str = (strArrEv == null || strArrEv.length <= 1) ? null : strArrEv[1];
        if (!z) {
            return TextUtils.isEmpty(str) ? "" : str;
        }
        if (!TextUtils.isEmpty(str)) {
            return com.kwad.sdk.e.b.a(be.usePhoneStateDisable() && !TextUtils.isEmpty(be.getDevImei()), str, 0);
        }
        if (Build.VERSION.SDK_INT >= 29) {
            return com.kwad.sdk.e.b.a(false, str, 4);
        }
        if (be.usePhoneStateDisable() || !t.UV()) {
            return com.kwad.sdk.e.b.a(false, str, 1);
        }
        return com.kwad.sdk.e.b.a(false, str, SystemUtil.en(context) ? 3 : 1);
    }

    public static String dS(Context context) {
        return o(context, false);
    }

    private static String o(Context context, boolean z) {
        String strDS = bt.dS(context);
        if (!z) {
            return TextUtils.isEmpty(strDS) ? "" : strDS;
        }
        if (!TextUtils.isEmpty(strDS)) {
            return com.kwad.sdk.e.b.a(be.usePhoneStateDisable(), strDS, 0);
        }
        if (Build.VERSION.SDK_INT >= 29) {
            return com.kwad.sdk.e.b.a(false, strDS, 4);
        }
        if (be.usePhoneStateDisable() || !t.UW()) {
            return com.kwad.sdk.e.b.a(false, strDS, 1);
        }
        return com.kwad.sdk.e.b.a(false, strDS, SystemUtil.en(context) ? 3 : 1);
    }

    public static String dT(Context context) {
        return p(context, false);
    }

    private static String p(Context context, boolean z) {
        String strEy = bt.ey(context);
        if (!z) {
            return TextUtils.isEmpty(strEy) ? "" : strEy;
        }
        if (!TextUtils.isEmpty(strEy)) {
            return com.kwad.sdk.e.b.a(be.usePhoneStateDisable(), strEy, 0);
        }
        if (be.usePhoneStateDisable() || !t.UX()) {
            return com.kwad.sdk.e.b.a(false, strEy, 1);
        }
        return com.kwad.sdk.e.b.a(false, strEy, SystemUtil.en(context) ? 3 : 1);
    }

    public static int dU(Context context) {
        return bt.ew(context);
    }

    private static String dV(Context context) {
        int iEw = bt.ew(context);
        if (iEw > 0) {
            return com.kwad.sdk.e.b.a(false, String.valueOf(iEw), 0);
        }
        return com.kwad.sdk.e.b.a(false, String.valueOf(iEw), 3);
    }

    public static com.kwad.sdk.k.a.f TL() {
        return com.kwad.sdk.k.a.f.TL();
    }

    public static int dW(Context context) {
        return bt.ex(context);
    }

    private static String Wq() {
        com.kwad.sdk.k.a.f fVarTL = com.kwad.sdk.k.a.f.TL();
        int i = fVarTL != null ? fVarTL.bmF : -1;
        if (i >= 0) {
            return com.kwad.sdk.e.b.a(false, String.valueOf(i), 0);
        }
        if (!((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).FR()) {
            return com.kwad.sdk.e.b.a(false, String.valueOf(i), 1);
        }
        return com.kwad.sdk.e.b.a(false, String.valueOf(i), 2);
    }

    public static com.kwad.sdk.k.a.b TK() {
        return com.kwad.sdk.k.a.b.TK();
    }

    private static String Wr() {
        com.kwad.sdk.k.a.b bVarTK = com.kwad.sdk.k.a.b.TK();
        if (bVarTK != null) {
            return com.kwad.sdk.e.b.a(false, bVarTK.toJson(), 0);
        }
        if (!((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).FT()) {
            return com.kwad.sdk.e.b.a(false, "", 1);
        }
        return com.kwad.sdk.e.b.a(false, "", 2);
    }

    public static String getDeviceId() {
        return cv(false);
    }

    private static String cv(boolean z) {
        if (com.kwad.framework.a.a.oV.booleanValue() && !TextUtils.isEmpty(bu.getDeviceId())) {
            return bu.getDeviceId();
        }
        String deviceId = bt.getDeviceId();
        if (!z) {
            return TextUtils.isEmpty(deviceId) ? "" : deviceId;
        }
        if (!TextUtils.isEmpty(deviceId)) {
            return com.kwad.sdk.e.b.a(be.usePhoneStateDisable() && !TextUtils.isEmpty(be.getDevAndroidId()), deviceId, 0);
        }
        if (be.usePhoneStateDisable() || !t.UP()) {
            return com.kwad.sdk.e.b.a(false, deviceId, 1);
        }
        return com.kwad.sdk.e.b.a(false, deviceId, 5);
    }

    private static String cw(boolean z) {
        String strXh = bt.Xh();
        if (!z) {
            return TextUtils.isEmpty(strXh) ? "" : strXh;
        }
        if (!TextUtils.isEmpty(strXh)) {
            return com.kwad.sdk.e.b.a(be.useNetworkStateDisable(), strXh, 0);
        }
        if (be.useNetworkStateDisable() || ((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).al(8L)) {
            return com.kwad.sdk.e.b.a(false, strXh, 1);
        }
        return com.kwad.sdk.e.b.a(false, strXh, 2);
    }

    public static List<cf.a> o(Context context, int i) {
        return cf.o(context, 15);
    }

    private static String dX(Context context) {
        List<cf.a> listO = o(context, 15);
        if (listO != null && listO.size() > 0) {
            return com.kwad.sdk.e.b.a(be.useNetworkStateDisable(), ac.Y(listO), 0);
        }
        if (be.useNetworkStateDisable() || ((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).al(32L)) {
            return com.kwad.sdk.e.b.a(false, "", 1);
        }
        return com.kwad.sdk.e.b.a(false, "", cf.eF(context) ? 1 : 3);
    }

    private static Map<String, AppPackageInfo> dY(Context context) {
        com.kwad.sdk.components.p pVar = (com.kwad.sdk.components.p) com.kwad.sdk.components.d.f(com.kwad.sdk.components.p.class);
        if (pVar != null && t.UT()) {
            return pVar.P(context);
        }
        return new HashMap();
    }

    private static String dZ(Context context) {
        com.kwad.sdk.core.c.b.Mh();
        if (!com.kwad.sdk.core.c.b.isAppOnForeground()) {
            return com.kwad.sdk.e.b.a(false, "", 5);
        }
        Map<String, AppPackageInfo> mapDY = dY(context);
        if (mapDY.size() > 0) {
            boolean z = be.readInstalledPackagesDisable() && be.getDevInstalledPackages() != null;
            com.kwad.sdk.components.p pVar = (com.kwad.sdk.components.p) com.kwad.sdk.components.d.f(com.kwad.sdk.components.p.class);
            if (pVar != null && t.UT()) {
                return com.kwad.sdk.e.b.a(z, pVar.c(mapDY), 0);
            }
        }
        if (be.readInstalledPackagesDisable() || !t.UT()) {
            return com.kwad.sdk.e.b.a(false, "", 1);
        }
        return com.kwad.sdk.e.b.a(false, "", bt.eD(context) ? 3 : 1);
    }

    public static com.kwad.sdk.utils.c.a df(Context context) {
        return z.df(context);
    }

    /* JADX WARN: Multi-variable type inference failed */
    private static String ea(Context context) {
        com.kwad.sdk.utils.c.a aVarDf = z.df(context);
        if (aVarDf != null && aVarDf.bsJ != null) {
            HashMap map = new HashMap();
            map.put("latitude", String.valueOf(aVarDf.bsJ.getLatitude()));
            map.put("longitude", String.valueOf(aVarDf.bsJ.getLongitude()));
            return com.kwad.sdk.e.b.a(be.readLocationDisable() && be.Wo() != null, ac.parseMap2JSON(map), 0);
        }
        if (be.readLocationDisable() || ((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).al(64L)) {
            return com.kwad.sdk.e.b.a(false, "", 1);
        }
        return com.kwad.sdk.e.b.a(false, "", (ContextCompat.checkSelfPermission(context, com.kuaishou.weapon.p0.g.g) == 0) == true ? 3 : 1);
    }

    private static String Ws() {
        return com.kwad.sdk.e.b.a(false, "1", 0);
    }

    private static String Wt() {
        return com.kwad.sdk.e.b.a(false, String.valueOf(getSdkVersion()), 0);
    }

    private static String getAppId() {
        return ((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).getAppId();
    }

    private static String Wu() {
        return com.kwad.sdk.e.b.a(false, String.valueOf(getAppId()), 0);
    }

    private static com.kwad.sdk.e.c eb(final Context context) {
        return new com.kwad.sdk.e.c() { // from class: com.kwad.sdk.utils.bf.1
            @Override // com.kwad.sdk.e.a
            public final String getIMEI() {
                com.kwad.sdk.core.d.c.d("SDKPrivateSafetyDataUtil", "getIMEI:" + bf.q(context, true));
                return bf.q(context, true);
            }

            @Override // com.kwad.sdk.e.a
            public final String getOaid() {
                com.kwad.sdk.core.d.c.d("SDKPrivateSafetyDataUtil", "getOaid:" + bf.cx(true));
                return bf.cx(true);
            }

            @Override // com.kwad.sdk.e.a
            public final String QX() {
                com.kwad.sdk.core.d.c.d("SDKPrivateSafetyDataUtil", "getAndroidID:" + bf.r(context, true));
                return bf.r(context, true);
            }

            @Override // com.kwad.sdk.e.a
            public final String getMac() {
                com.kwad.sdk.core.d.c.d("SDKPrivateSafetyDataUtil", "getMac:" + bf.s(context, true));
                return bf.s(context, true);
            }

            @Override // com.kwad.sdk.e.a
            public final String QY() {
                com.kwad.sdk.core.d.c.d("SDKPrivateSafetyDataUtil", "getIMEI2:" + bf.t(context, true));
                return bf.t(context, true);
            }

            @Override // com.kwad.sdk.e.a
            public final String QZ() {
                String strU = bf.u(context, true);
                com.kwad.sdk.core.d.c.d("SDKPrivateSafetyDataUtil", "getIMEI2:" + strU);
                return strU;
            }

            @Override // com.kwad.sdk.e.a
            public final String Ra() {
                com.kwad.sdk.core.d.c.d("SDKPrivateSafetyDataUtil", "getIMSI:" + bf.v(context, true));
                return bf.v(context, true);
            }

            @Override // com.kwad.sdk.e.a
            public final String getIccId() {
                com.kwad.sdk.core.d.c.d("SDKPrivateSafetyDataUtil", "getIccId:" + bf.w(context, true));
                return bf.w(context, true);
            }

            @Override // com.kwad.sdk.e.a
            public final String Rb() {
                com.kwad.sdk.core.d.c.d("SDKPrivateSafetyDataUtil", "getSimCardPhoneCount:" + bf.x(context, true));
                return bf.x(context, true);
            }

            @Override // com.kwad.sdk.e.a
            public final String Rc() {
                String strCy = bf.cy(true);
                com.kwad.sdk.core.d.c.d("SDKPrivateSafetyDataUtil", "getSimCardActivePhoneCount:" + strCy);
                return strCy;
            }

            @Override // com.kwad.sdk.e.a
            public final String Rd() {
                String strCz = bf.cz(true);
                com.kwad.sdk.core.d.c.d("SDKPrivateSafetyDataUtil", "getBaseStationInfo:" + strCz);
                return strCz;
            }

            @Override // com.kwad.sdk.e.a
            public final String getDeviceId() {
                String strCA = bf.cA(true);
                com.kwad.sdk.core.d.c.d("SDKPrivateSafetyDataUtil", "getDeviceId:" + strCA);
                return strCA;
            }

            @Override // com.kwad.sdk.e.a
            public final String getIp() {
                String strCB = bf.cB(true);
                com.kwad.sdk.core.d.c.d("SDKPrivateSafetyDataUtil", "getIp:" + strCB);
                return strCB;
            }

            @Override // com.kwad.sdk.e.a
            public final String Re() {
                String strY = bf.y(context, true);
                com.kwad.sdk.core.d.c.d("SDKPrivateSafetyDataUtil", "getWifiList:" + strY);
                return strY;
            }

            @Override // com.kwad.sdk.e.a
            public final String getLocation() {
                String strZ = bf.z(context, true);
                com.kwad.sdk.core.d.c.d("SDKPrivateSafetyDataUtil", "getLocation:" + strZ);
                return strZ;
            }

            @Override // com.kwad.sdk.e.a
            public final String Rf() {
                String strA = bf.A(context, true);
                com.kwad.sdk.core.d.c.d("SDKPrivateSafetyDataUtil", "getAppList:" + strA);
                return strA;
            }

            @Override // com.kwad.sdk.e.a
            public final String Rg() {
                String strCC = bf.cC(true);
                com.kwad.sdk.core.d.c.d("SDKPrivateSafetyDataUtil", "getSdkType:" + strCC);
                return strCC;
            }

            @Override // com.kwad.sdk.e.a
            public final String getSdkVersion() {
                String strCD = bf.cD(true);
                com.kwad.sdk.core.d.c.d("SDKPrivateSafetyDataUtil", "getSdkVersion:" + strCD);
                return strCD;
            }

            @Override // com.kwad.sdk.e.a
            public final String getAppId() {
                String strCE = bf.cE(true);
                com.kwad.sdk.core.d.c.d("SDKPrivateSafetyDataUtil", "getAppId:" + strCE);
                return strCE;
            }
        };
    }
}

package com.kwad.components.ad.reward.a;

import com.kwad.sdk.core.response.model.AdInfo;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    public static int hJ() {
        return a.ug.getValue().intValue();
    }

    public static String hK() {
        return a.uk.getValue();
    }

    public static int hL() {
        return a.uh.getValue().intValue();
    }

    public static boolean hM() {
        return a.uj.getValue().booleanValue();
    }

    public static int hN() {
        return a.ui.getValue().intValue();
    }

    private static boolean hO() {
        return a.um.getValue().intValue() == 1;
    }

    public static boolean j(AdInfo adInfo) {
        return !k(adInfo) && com.kwad.sdk.core.response.helper.a.cW(adInfo) && hO();
    }

    public static boolean k(AdInfo adInfo) {
        return com.kwad.sdk.core.response.helper.a.cW(adInfo) && a.uo.getValue().intValue() == 1;
    }

    public static boolean l(AdInfo adInfo) {
        return j(adInfo);
    }

    public static float hP() {
        return a.ur.getValue().floatValue();
    }

    public static boolean hQ() {
        return a.ur.getValue().floatValue() > 0.0f && a.ur.getValue().floatValue() < 1.0f;
    }

    public static boolean hR() {
        return a.us.getValue().booleanValue();
    }

    public static long hS() {
        return a.up.getValue().intValue();
    }

    public static int hT() {
        return a.uq.getValue().intValue();
    }

    public static int hU() {
        return a.ut.getValue().intValue();
    }

    public static boolean hV() {
        return a.uu.getValue().booleanValue();
    }

    public static boolean hW() {
        return a.uv.getValue().intValue() == 1 || a.uv.getValue().intValue() == 3;
    }

    public static boolean hX() {
        return a.uw.getValue().booleanValue();
    }

    public static boolean hY() {
        return a.ux.getValue().booleanValue();
    }
}

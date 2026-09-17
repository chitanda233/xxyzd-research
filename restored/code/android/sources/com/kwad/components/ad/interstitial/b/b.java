package com.kwad.components.ad.interstitial.b;

import com.kwad.sdk.core.response.model.AdInfo;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    public static boolean dM() {
        return a.mo.getValue().booleanValue();
    }

    public static boolean dN() {
        return a.mi.getValue().intValue() == 1;
    }

    public static int dO() {
        return a.mj.getValue().intValue();
    }

    public static boolean dP() {
        return a.mk.getValue().intValue() == 1;
    }

    public static boolean dQ() {
        return a.ml.getValue().intValue() == 1;
    }

    public static int b(AdInfo adInfo) {
        int iN;
        int iIntValue = a.mm.getValue().intValue();
        if (com.kwad.sdk.core.response.helper.a.bi(adInfo)) {
            iN = com.kwad.sdk.core.response.helper.a.N(adInfo);
            if (iIntValue != 0) {
                return Math.min(iIntValue, iN);
            }
        } else {
            iN = 60;
            if (iIntValue <= 60 && iIntValue > 0) {
                return iIntValue;
            }
        }
        return iN;
    }

    public static boolean dR() {
        return a.mn.getValue().intValue() == 1;
    }

    public static boolean dS() {
        return a.mp.getValue().intValue() == 1;
    }
}

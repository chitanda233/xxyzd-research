package com.kwad.components.core.t;

import android.content.Context;
import android.os.Build;
import com.kwad.sdk.utils.ab;
import com.kwad.sdk.utils.bd;

/* JADX INFO: loaded from: classes3.dex */
public final class w {
    private static final String[] alY = {"ONEPLUS A6000", "ONEPLUS A6003", "IN2010"};
    private static Boolean alZ;

    public static boolean aQ(Context context) {
        Boolean bool = alZ;
        if (bool != null) {
            return bool.booleanValue();
        }
        if (bd.UJ()) {
            alZ = Boolean.valueOf(aR(context));
        } else if (bd.UK()) {
            alZ = Boolean.valueOf(xk() || xl());
        } else if (bd.Wj()) {
            alZ = Boolean.valueOf(xm());
        } else if (bd.Wk()) {
            alZ = Boolean.valueOf(xn());
        } else if (bd.Wm()) {
            alZ = xj();
        } else {
            alZ = Boolean.valueOf(xo());
        }
        return alZ.booleanValue();
    }

    private static Boolean xj() {
        Boolean bool;
        boolean z = false;
        try {
            bool = (Boolean) ab.a("smartisanos.api.DisplayUtilsSmt", "isFeatureSupport", 1);
        } catch (Exception unused) {
            bool = null;
        }
        if (bool != null && bool.booleanValue()) {
            z = true;
        }
        return Boolean.valueOf(z);
    }

    private static boolean aR(Context context) {
        try {
            return context.getPackageManager().hasSystemFeature("com.oppo.feature.screen.heteromorphism");
        } catch (Exception unused) {
            return false;
        }
    }

    private static boolean xk() {
        Boolean bool;
        try {
            bool = (Boolean) ab.a("android.util.FtFeature", "isFeatureSupport", 32);
        } catch (Exception unused) {
            bool = null;
        }
        return bool != null && bool.booleanValue();
    }

    private static boolean xl() {
        Boolean bool;
        try {
            bool = (Boolean) ab.a("android.util.FtFeature", "isFeatureSupport", "vivo.hardware.holescreen");
        } catch (Exception unused) {
            bool = null;
        }
        return bool != null && bool.booleanValue();
    }

    private static boolean xm() {
        Boolean bool;
        try {
            bool = (Boolean) ab.a("com.huawei.android.util.HwNotchSizeUtil", "hasNotchInScreen", new Object[0]);
        } catch (Exception unused) {
            bool = null;
        }
        return bool != null && bool.booleanValue();
    }

    private static boolean xn() {
        Integer num;
        try {
            num = (Integer) ab.a("android.os.SystemProperties", "getInt", "ro.miui.notch", 0);
        } catch (Exception unused) {
            num = null;
        }
        return num != null && num.intValue() == 1;
    }

    private static boolean xo() {
        for (String str : alY) {
            if (str.equalsIgnoreCase(Build.MODEL)) {
                return true;
            }
        }
        return false;
    }
}

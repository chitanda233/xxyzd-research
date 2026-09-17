package com.chuanglan.shanyan_sdk;

import android.text.TextUtils;
import com.byazt.bv.BaseConstants;

/* JADX INFO: loaded from: classes2.dex */
public abstract class o0 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static String f1992a;
    private static String b;

    public static String a() {
        if (b == null) {
            a("");
        }
        if (AbstractC0600f.a(b)) {
            b = C0616v.g().c();
        }
        return b;
    }

    public static String b(String str) {
        try {
            return (String) Class.forName("android.os.SystemProperties").getMethod("get", String.class, String.class).invoke(null, str, "");
        } catch (Throwable unused) {
            return null;
        }
    }

    public static boolean a(String str) {
        String str2 = f1992a;
        if (str2 != null) {
            return str2.equals(str);
        }
        String strB = b("ro.miui.ui.version.name");
        b = strB;
        if (!TextUtils.isEmpty(strB)) {
            f1992a = "MIUI";
        } else {
            String strB2 = b(com.alipay.sdk.m.d.a.f272a);
            b = strB2;
            if (!TextUtils.isEmpty(strB2)) {
                f1992a = "EMUI";
            } else {
                String strB3 = b("ro.build.version.opporom");
                b = strB3;
                if (!TextUtils.isEmpty(strB3)) {
                    f1992a = BaseConstants.ROM_OPPO_UPPER_CONSTANT;
                } else {
                    String strB4 = b("ro.vivo.os.version");
                    b = strB4;
                    if (!TextUtils.isEmpty(strB4)) {
                        f1992a = "VIVO";
                    } else {
                        String strB5 = b("ro.smartisan.version");
                        b = strB5;
                        if (!TextUtils.isEmpty(strB5)) {
                            f1992a = "SMARTISAN";
                        } else {
                            String strC = C0616v.g().c();
                            b = strC;
                            if (strC != null && strC.toUpperCase().contains("FLYME")) {
                                f1992a = "FLYME";
                            } else {
                                f1992a = C0616v.g().e();
                            }
                        }
                    }
                }
            }
        }
        String str3 = f1992a;
        if (str3 == null) {
            return false;
        }
        return str3.equals(str);
    }
}

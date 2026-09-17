package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.os.Build;
import android.text.TextUtils;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import java.util.Locale;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Aquila {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static long f3819a = -1;
    public static Integer b;

    public static String a(String str) {
        String str2;
        Context context;
        try {
            synchronized (Ccatch.class) {
                context = Ccatch.f3917a;
            }
            Class<?> clsLoadClass = context.getClassLoader().loadClass("android.os.SystemProperties");
            str2 = (String) clsLoadClass.getMethod("get", String.class, String.class).invoke(clsLoadClass, new String(str), new String(""));
        } catch (IllegalArgumentException e) {
            throw e;
        } catch (Exception unused) {
            str2 = "";
        }
        return str2 == null ? "" : str2;
    }

    public static String b() {
        String str = Build.MANUFACTURER;
        return str == null ? "UNKNOWN" : str;
    }

    public static String a() {
        String[] strArrSplit;
        try {
            String str = Build.MANUFACTURER;
            if (TextUtils.isEmpty(str)) {
                return null;
            }
            String lowerCase = str.toLowerCase(Locale.ENGLISH);
            if (lowerCase.contains("huawei")) {
                return Cumquat.a(com.alipay.sdk.m.d.a.f272a);
            }
            if (lowerCase.contains(MediationConstant.ADN_XIAOMI)) {
                return Cumquat.a("ro.miui.ui.version.name");
            }
            if (lowerCase.contains("gionee")) {
                String strA = Cumquat.a("ro.gn.extvernumber");
                return TextUtils.isEmpty(strA) ? Cumquat.a("ro.build.display.id") : strA;
            }
            if (lowerCase.contains("vivo")) {
                String strA2 = Cumquat.a("ro.vivo.os.name");
                String strA3 = Cumquat.a("ro.vivo.os.version");
                if (!TextUtils.isEmpty(strA2) && !TextUtils.isEmpty(strA3)) {
                    return strA2 + "_" + strA3;
                }
                return Cumquat.a("ro.vivo.os.build.display.id");
            }
            if (lowerCase.contains("meizu")) {
                return Cumquat.a("ro.build.display.id");
            }
            if (lowerCase.contains("lenovo")) {
                String strA4 = Cumquat.a("ro.lenovo.lvp.version");
                String str2 = (TextUtils.isEmpty(strA4) || (strArrSplit = strA4.split("_")) == null || strArrSplit.length <= 0) ? null : strArrSplit[0];
                return TextUtils.isEmpty(str2) ? Cumquat.a("ro.build.version.incremental") : str2;
            }
            if (lowerCase.contains("letv")) {
                return Cumquat.a("ro.letv.eui");
            }
            return null;
        } catch (Exception unused) {
            return null;
        }
    }
}

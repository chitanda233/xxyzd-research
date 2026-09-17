package com.bytedance.ads.convert.flat.n;

import android.os.Build;
import android.text.TextUtils;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes2.dex */
public class b {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final /* synthetic */ int f1743a = 0;

    static {
        new AtomicBoolean(false);
    }

    public static boolean a() {
        try {
            Class<?> cls = Class.forName("android.os.SystemProperties");
            String str = (String) cls.getDeclaredMethod("get", String.class).invoke(cls, com.alipay.sdk.m.d.a.f272a);
            if (!TextUtils.isEmpty(str)) {
                String str2 = "honor# oldHonor device, version is" + str;
                return true;
            }
        } catch (Exception e) {
            String str3 = "Honor# " + e.getMessage();
        }
        return false;
    }

    public static boolean b() {
        String str = Build.BRAND;
        if (TextUtils.isEmpty(str) || !str.toLowerCase().startsWith("honor")) {
            String str2 = Build.MANUFACTURER;
            if ((TextUtils.isEmpty(str2) || !str2.toLowerCase().startsWith("honor")) && !"HONOR".equalsIgnoreCase(str2)) {
                return false;
            }
        }
        return true;
    }
}

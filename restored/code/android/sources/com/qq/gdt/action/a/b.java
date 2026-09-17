package com.qq.gdt.action.a;

import android.content.Context;
import android.content.pm.ApplicationInfo;
import android.text.TextUtils;
import com.qq.gdt.action.i.o;
import com.qq.gdt.action.i.t;
import java.io.File;

/* JADX INFO: loaded from: classes3.dex */
public class b {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static String f3015a;
    private static String b;

    public static String a(Context context) {
        if (f3015a == null) {
            a(context, "channelIdInner");
        }
        return f3015a;
    }

    public static void a(Context context, String str) {
        if (f3015a == null || b == null) {
            try {
                File file = new File(c(context));
                String strA = c.a(file, -2012129808);
                b = strA;
                if (!TextUtils.isEmpty(strA) && str == "clickId") {
                    o.a("获取clickId不为空" + b, new Object[0]);
                    t.h(context);
                }
                String strA2 = c.a(file, -2012129793);
                f3015a = strA2;
                if (TextUtils.isEmpty(strA2)) {
                    f3015a = f.a(file);
                }
            } catch (Throwable th) {
                th.printStackTrace();
            }
        }
    }

    public static String b(Context context) {
        if (b == null) {
            a(context, "clickId");
        }
        return b;
    }

    private static String c(Context context) {
        try {
            ApplicationInfo applicationInfo = context.getApplicationInfo();
            if (applicationInfo == null) {
                return null;
            }
            return applicationInfo.sourceDir;
        } catch (Throwable th) {
            th.printStackTrace();
            return null;
        }
    }
}

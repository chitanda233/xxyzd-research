package com.sigmob.sdk.base.utils;

import android.util.Log;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.LoadAdRequest;
import com.sigmob.windad.natives.AdAppInfo;
import java.util.HashSet;
import java.util.Map;
import java.util.Set;

/* JADX INFO: loaded from: classes3.dex */
public class k {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final int f3258a = 2;
    public static final int b = 3;
    public static final int c = 4;
    public static final int d = 5;
    public static final int e = 6;
    private static final String f = "SigAds";
    private static final boolean g = true;
    private static boolean h = true;
    private static final int i = 1;
    private static final int j = 1;
    private static final int k = 4;
    private static final Set<String> l = new HashSet();

    private static int a(StackTraceElement[] elements) {
        for (int i2 = 1; i2 < elements.length; i2++) {
            if (!elements[i2].getClassName().split("\\$")[0].equals(k.class.getName())) {
                return i2;
            }
        }
        return -1;
    }

    private static String a() {
        return Thread.currentThread().getName();
    }

    private static String a(StackTraceElement element) {
        return "(" + element.getFileName() + ':' + element.getLineNumber() + ')';
    }

    private static String a(String log) {
        return log + " [" + a() + "] " + b();
    }

    public static String a(String format, Object... args) {
        return (args == null || args.length == 0) ? format : String.format(format, args);
    }

    public static void a(int level, String tag, String methodName, BaseAdUnit adUnit, Map<String, Object> params) {
        if (adUnit == null) {
            f(tag, methodName + ": adUnit is null.", new Object[0]);
            return;
        }
        String vid = adUnit.getVid();
        int playMode = adUnit.getPlayMode();
        String requestId = adUnit.getRequestId();
        String adslot_id = adUnit.getAdslot_id();
        boolean disableAutoLoad = adUnit.getDisableAutoLoad();
        a(level, tag, methodName + ": placementId = " + adslot_id + ", sceneType = " + adUnit.getRequestSceneType() + ", requestId = " + requestId + ", playMode = " + playMode + ", autoLoad = " + disableAutoLoad + ", adType = " + com.sigmob.sdk.base.common.d.a(adUnit.getAd_type()) + ", vid = " + vid + ", params = " + params, new Object[0]);
    }

    public static void a(int level, String tag, String methodName, LoadAdRequest request, Map<String, Object> params) {
        if (request == null) {
            f(tag, methodName + ": request is null.", new Object[0]);
            return;
        }
        String requestId = request.getRequestId();
        a(level, tag, methodName + ": placementId = " + request.getPlacementId() + ", sceneType = " + request.getRequest_scene_type() + ", requestId = " + requestId + ", adType = " + com.sigmob.sdk.base.common.d.a(request.getAdType()) + ", params = " + params, new Object[0]);
    }

    public static void a(int level, String tag, String format, Object... args) {
        if (level == 2) {
            a(tag, format, args);
            return;
        }
        if (level == 3) {
            c(tag, format, args);
            return;
        }
        if (level == 4) {
            b(tag, format, args);
            return;
        }
        if (level == 5) {
            e(tag, format, args);
        } else if (level != 6) {
            f(tag, "level is unknown.", new Object[0]);
        } else {
            f(tag, format, args);
        }
    }

    public static void a(Class<?> clazz) {
        l.add(clazz.getSimpleName());
    }

    public static void a(String tag, String format, Throwable th, Object... args) {
        if (!h || l.contains(tag)) {
            return;
        }
        Log.e(b(tag), a(a(format, args)), th);
    }

    public static void a(String tag, String format, Object... args) {
        if (!h || l.contains(tag)) {
            return;
        }
        Log.v(b(tag), a(a(format, args)));
    }

    public static void a(String tag, Throwable tr) {
        if (!h || l.contains(tag)) {
            return;
        }
        Log.w(b(tag), tr);
    }

    public static void a(String tag, Throwable tr, String format, Object... args) {
        if (!h || l.contains(tag)) {
            return;
        }
        Log.i(b(tag), a(a(format, args)), tr);
    }

    public static void a(boolean enable) {
        h = enable;
    }

    private static String b() {
        StackTraceElement[] stackTrace = Thread.currentThread().getStackTrace();
        int iA = a(stackTrace);
        int length = iA + 4;
        int length2 = iA + 1 + 4;
        if (length >= stackTrace.length) {
            length = stackTrace.length - 1;
        }
        if (length2 > stackTrace.length) {
            length2 = stackTrace.length;
        }
        StringBuilder sb = new StringBuilder();
        StringBuilder sb2 = new StringBuilder();
        for (int i2 = length2 - 1; i2 >= length; i2--) {
            sb.append((CharSequence) sb2).append(a(stackTrace[i2])).append('\n');
            sb2.append("  ");
        }
        return sb.toString();
    }

    private static String b(String tag) {
        return "SigAds#" + tag;
    }

    public static void b(int level, String tag, String methodName, BaseAdUnit adUnit, Map<String, Object> params) {
        if (adUnit == null) {
            f(tag, methodName + ": adUnit is null.", new Object[0]);
            return;
        }
        AdAppInfo adAppInfo = adUnit.getAdAppInfo();
        a(level, tag, methodName + ": placementId = " + adUnit.getAdslot_id() + ", requestId = " + adUnit.getRequestId() + ", adType = " + com.sigmob.sdk.base.common.d.a(adUnit.getAd_type()) + ", appInfo = " + adAppInfo + ", params = " + params, new Object[0]);
    }

    public static void b(String tag, String format, Object... args) {
        if (!h || l.contains(tag)) {
            return;
        }
        Log.i(b(tag), a(a(format, args)));
    }

    public static void b(String tag, Throwable tr, String format, Object... args) {
        if (!h || l.contains(tag)) {
            return;
        }
        Log.d(b(tag), a(a(format, args)), tr);
    }

    public static void c(String tag, String format, Object... args) {
        if (!h || l.contains(tag)) {
            return;
        }
        Log.d(b(tag), a(a(format, args)));
    }

    public static void c(String tag, Throwable tr, String format, Object... args) {
        if (!h || l.contains(tag)) {
            return;
        }
        Log.w(b(tag), a(a(format, args)), tr);
    }

    public static void d(String tag, String format, Object... args) {
        if (!h) {
            l.contains(tag);
            return;
        }
        String strA = a(format, args);
        if (strA.length() < 3000) {
            Log.d(b(tag), strA);
            return;
        }
        synchronized (k.class) {
            int length = strA.length();
            int i2 = 0;
            int i3 = 0;
            do {
                i2 += 3000;
                if (i2 >= length) {
                    i2 = length - 1;
                }
                Log.d(b(tag), strA.substring(i3, i2));
                i3 = i2 + 1;
            } while (i2 != length - 1);
        }
    }

    public static void e(String tag, String format, Object... args) {
        if (!h || l.contains(tag)) {
            return;
        }
        Log.w(b(tag), a(a(format, args)));
    }

    public static void f(String tag, String format, Object... args) {
        if (!h || l.contains(tag)) {
            return;
        }
        Log.e(b(tag), a(a(format, args)));
    }
}

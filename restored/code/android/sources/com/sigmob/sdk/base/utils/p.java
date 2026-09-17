package com.sigmob.sdk.base.utils;

import android.util.Log;
import cn.thinkingdata.core.router.TRouterMap;

/* JADX INFO: loaded from: classes3.dex */
public class p {
    public static String a() {
        return Log.getStackTraceString(new Throwable());
    }

    public static String a(Throwable th) {
        return Log.getStackTraceString(th);
    }

    public static String a(String... excludePackages) {
        boolean z;
        StackTraceElement[] stackTrace = Thread.currentThread().getStackTrace();
        StringBuilder sb = new StringBuilder();
        for (StackTraceElement stackTraceElement : stackTrace) {
            int length = excludePackages.length;
            int i = 0;
            while (true) {
                if (i >= length) {
                    z = false;
                    break;
                }
                if (stackTraceElement.getClassName().startsWith(excludePackages[i])) {
                    z = true;
                    break;
                }
                i++;
            }
            if (!z) {
                sb.append(stackTraceElement.toString()).append("\n");
            }
        }
        return sb.toString();
    }

    public static void a(String tag, String packageFilter) {
        StackTraceElement[] stackTrace = new Throwable().getStackTrace();
        StringBuilder sb = new StringBuilder("Current Stack Trace:\n");
        for (StackTraceElement stackTraceElement : stackTrace) {
            String className = stackTraceElement.getClassName();
            if (packageFilter == null || className.contains(packageFilter)) {
                sb.append("  at ").append(className).append(TRouterMap.DOT).append(stackTraceElement.getMethodName()).append("(").append(stackTraceElement.getFileName()).append(":").append(stackTraceElement.getLineNumber()).append(")\n");
            }
        }
        Log.d(tag, sb.toString());
    }
}

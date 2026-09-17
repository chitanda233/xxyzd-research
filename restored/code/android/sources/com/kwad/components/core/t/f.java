package com.kwad.components.core.t;

import cn.thinkingdata.core.router.TRouterMap;

/* JADX INFO: loaded from: classes3.dex */
public final class f {
    public static boolean bj(String str) {
        if (str == null) {
            return false;
        }
        for (StackTraceElement stackTraceElement : Thread.currentThread().getStackTrace()) {
            if (a(stackTraceElement).equals(str)) {
                return true;
            }
        }
        return false;
    }

    public static String a(StackTraceElement stackTraceElement) {
        StringBuilder sb = new StringBuilder();
        sb.append(stackTraceElement.getClassName()).append(TRouterMap.DOT).append(stackTraceElement.getMethodName());
        return sb.toString();
    }
}

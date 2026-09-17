package com.kwad.sdk.utils;

import cn.thinkingdata.core.router.TRouterMap;

/* JADX INFO: loaded from: classes3.dex */
public final class q {
    public static long boK;
    public static long sLaunchTime;

    public static String a(StackTraceElement stackTraceElement) {
        StringBuilder sb = new StringBuilder();
        sb.append(stackTraceElement.getClassName()).append(TRouterMap.DOT).append(stackTraceElement.getMethodName());
        return sb.toString();
    }

    public static void setLaunchTime(long j) {
        sLaunchTime = j;
    }

    public static void setInitStartTime(long j) {
        boK = j;
    }

    public static long UM() {
        return boK - sLaunchTime;
    }
}

package com.sigmob.sdk.base.utils;

/* JADX INFO: loaded from: classes3.dex */
public class x {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3268a = "WebUtils";

    public static boolean a(String url) {
        if (s.a((CharSequence) url)) {
            return true;
        }
        try {
            return url.contains("../") || url.contains("..%2F") || url.contains("..\\") || url.contains("..%5C");
        } catch (Exception e) {
            k.f(f3268a, "isUnsafeUrl: error = " + e.getMessage(), new Object[0]);
        }
    }
}

package com.cmic.gen.sdk.f;

import com.cmic.gen.sdk.auth.GenTokenListener;
import java.util.concurrent.ConcurrentHashMap;

/* JADX INFO: compiled from: OverTimeUtils.java */
/* JADX INFO: loaded from: classes2.dex */
public class f {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static ConcurrentHashMap<String, GenTokenListener> f2121a = new ConcurrentHashMap<>(16);
    private static ConcurrentHashMap<String, com.cmic.gen.sdk.a> b = new ConcurrentHashMap<>();

    public static boolean a(String str) {
        return !f2121a.containsKey(str);
    }

    public static void a(String str, GenTokenListener genTokenListener) {
        f2121a.put(str, genTokenListener);
    }

    public static void b(String str) {
        f2121a.remove(str);
    }

    public static GenTokenListener c(String str) {
        return f2121a.get(str);
    }

    public static com.cmic.gen.sdk.a d(String str) {
        if (str != null) {
            return b.get(str);
        }
        return new com.cmic.gen.sdk.a(0);
    }

    public static void a(String str, com.cmic.gen.sdk.a aVar) {
        if (str == null || aVar == null) {
            return;
        }
        b.put(str, aVar);
    }
}

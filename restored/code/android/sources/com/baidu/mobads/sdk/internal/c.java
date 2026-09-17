package com.baidu.mobads.sdk.internal;

/* JADX INFO: loaded from: classes.dex */
public class c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static volatile c f457a;

    public interface a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public static final String f458a = "remote_adserv";
        public static final String b = "remote_novel";
    }

    private c() {
    }

    public static c a() {
        if (f457a == null) {
            synchronized (c.class) {
                if (f457a == null) {
                    f457a = new c();
                }
            }
        }
        return f457a;
    }

    public as a(String str) {
        return new as(str);
    }
}

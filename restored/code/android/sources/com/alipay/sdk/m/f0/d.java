package com.alipay.sdk.m.f0;

import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;

/* JADX INFO: loaded from: classes.dex */
public class d {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final Map<String, a> f286a = new ConcurrentHashMap();

    public static class a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public String f287a;
        public long b;
        public long c;
    }

    public static String a(String str) {
        Map<String, a> map;
        a aVar;
        String str2;
        if (str == null || (map = f286a) == null || (aVar = map.get(str)) == null) {
            return null;
        }
        if (a(aVar.b, aVar.c) && (str2 = aVar.f287a) != null) {
            return str2;
        }
        map.remove(str);
        return null;
    }

    public static void a(String str, String str2) {
        a(str, str2, 86400000L);
    }

    public static void a(String str, String str2, long j) {
        if (str == null) {
            return;
        }
        if (str2 == null) {
            str2 = "";
        }
        if (j == 0) {
            j = 86400000;
        }
        Map<String, a> map = f286a;
        a aVar = map.get(str);
        if (aVar == null) {
            aVar = new a();
        }
        aVar.f287a = str2;
        aVar.c = j;
        aVar.b = System.currentTimeMillis();
        map.put(str, aVar);
    }

    public static boolean a(long j, long j2) {
        return System.currentTimeMillis() - j < j2;
    }
}

package com.cmic.gen.sdk.c.d;

import java.util.HashMap;
import java.util.List;
import java.util.Map;

/* JADX INFO: compiled from: HttpSuccessResponse.java */
/* JADX INFO: loaded from: classes2.dex */
public class b {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private int f2091a;
    private Map<String, List<String>> b;
    private String c;

    public b(int i, Map<String, List<String>> map, String str) {
        this.f2091a = i;
        this.b = map;
        this.c = str;
    }

    public int a() {
        return this.f2091a;
    }

    public Map<String, List<String>> b() {
        Map<String, List<String>> map = this.b;
        return map == null ? new HashMap() : map;
    }

    public String c() {
        String str = this.c;
        return str == null ? "" : str;
    }

    public boolean d() {
        int i = this.f2091a;
        return i == 302 || i == 301;
    }
}

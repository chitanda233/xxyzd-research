package com.qq.gdt.action.e.b;

import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public class i {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final j f3059a;
    private final g b;
    private final int c;
    private final String d;
    private final String e;
    private final Map<String, List<String>> f;

    public static class a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private j f3060a;
        private g b;
        private int c;
        private String d;
        private String e;
        private Map<String, List<String>> f;

        public a a(int i) {
            this.c = i;
            return this;
        }

        public a a(g gVar) {
            this.b = gVar;
            return this;
        }

        public a a(j jVar) {
            this.f3060a = jVar;
            return this;
        }

        public a a(String str) {
            this.d = str;
            return this;
        }

        public a a(Map<String, List<String>> map) {
            this.f = map;
            return this;
        }

        public i a() {
            return new i(this);
        }
    }

    i(a aVar) {
        this.b = aVar.b;
        this.c = aVar.c;
        this.d = aVar.d;
        this.e = aVar.e;
        this.f = aVar.f;
        this.f3059a = aVar.f3060a;
    }

    public g a() {
        return this.b;
    }

    public boolean b() {
        return this.c / 100 == 2;
    }

    public int c() {
        return this.c;
    }

    public Map<String, List<String>> d() {
        return this.f;
    }

    public j e() {
        return this.f3059a;
    }

    public String toString() {
        StringBuilder sb = new StringBuilder("{\"body\":");
        sb.append(this.f3059a);
        sb.append(",\"request\":").append(this.b);
        sb.append(",\"code\":").append(this.c);
        sb.append(",\"message\":\"").append(this.d).append("\",\"trace_id\":\"");
        sb.append(this.e).append("\",\"headers\":");
        sb.append(this.f);
        sb.append('}');
        return sb.toString();
    }
}

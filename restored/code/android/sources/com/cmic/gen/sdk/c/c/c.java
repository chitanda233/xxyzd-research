package com.cmic.gen.sdk.c.c;

import android.net.Network;
import com.baidu.mobads.sdk.internal.an;
import com.cmic.gen.sdk.c.b.f;
import com.cmic.gen.sdk.c.b.h;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: compiled from: HttpRequest.java */
/* JADX INFO: loaded from: classes2.dex */
public class c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    String f2088a;
    private final String b;
    private final Map<String, String> c;
    private final String d;
    private boolean e;
    private final String f;
    private Network g;
    private long h;
    private final String i;
    private int j;
    private final h k;

    private c(String str, Map<String, String> map, h hVar, String str2, String str3) {
        this.e = false;
        this.b = str;
        this.k = hVar;
        map = map == null ? new HashMap<>() : map;
        this.c = map;
        this.f2088a = hVar == null ? "" : hVar.b().toString();
        this.d = str2;
        this.f = str3;
        this.i = hVar != null ? hVar.a() : "";
        map.put("interfaceVersion", "1.0");
        if (hVar instanceof f) {
            map.put(com.alipay.sdk.m.x.a.k, ((f) hVar).c());
        }
        l();
    }

    public c(String str, h hVar, String str2, String str3) {
        this(str, null, hVar, str2, str3);
    }

    private void l() {
        this.c.put("sdkVersion", com.cmic.gen.sdk.auth.c.SDK_VERSION);
        this.c.put("Content-Type", an.d);
        this.c.put("CMCC-EncryptType", "STD");
        this.c.put("traceId", this.f);
        this.c.put("appid", this.i);
        this.c.put("connection", "Keep-Alive");
    }

    public void a(String str, String str2) {
        this.c.put(str, str2);
    }

    public String a() {
        return this.b;
    }

    public boolean b() {
        return this.e;
    }

    void a(boolean z) {
        this.e = z;
    }

    public Map<String, String> c() {
        return this.c;
    }

    public String d() {
        return this.f2088a;
    }

    public String e() {
        return this.d;
    }

    public String f() {
        return this.f;
    }

    public boolean g() {
        return !com.cmic.gen.sdk.f.f.a(this.f) || this.b.contains("logReport") || this.b.contains("uniConfig");
    }

    public Network h() {
        return this.g;
    }

    public void a(Network network) {
        this.g = network;
    }

    public void a(long j) {
        this.h = j;
    }

    public long i() {
        return this.h;
    }

    public boolean j() {
        int i = this.j;
        this.j = i + 1;
        return i < 2;
    }

    public h k() {
        return this.k;
    }
}

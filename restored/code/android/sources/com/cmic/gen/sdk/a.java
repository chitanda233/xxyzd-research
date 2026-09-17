package com.cmic.gen.sdk;

import java.util.concurrent.ConcurrentHashMap;

/* JADX INFO: compiled from: ConcurrentBundle.java */
/* JADX INFO: loaded from: classes2.dex */
public class a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private ConcurrentHashMap<String, Object> f2038a;

    public a(int i) {
        this.f2038a = new ConcurrentHashMap<>(i);
    }

    public void a(String str, byte[] bArr) {
        if (str == null || bArr == null) {
            return;
        }
        this.f2038a.put(str, bArr);
    }

    public byte[] a(String str) {
        if (str != null) {
            return (byte[]) this.f2038a.get(str);
        }
        return null;
    }

    public void a(String str, String str2) {
        if (str == null || str2 == null) {
            return;
        }
        this.f2038a.put(str, str2);
    }

    public String b(String str) {
        return b(str, "");
    }

    public String b(String str, String str2) {
        return (str == null || !this.f2038a.containsKey(str)) ? str2 : (String) this.f2038a.get(str);
    }

    public void a(String str, boolean z) {
        if (str != null) {
            this.f2038a.put(str, Boolean.valueOf(z));
        }
    }

    public boolean b(String str, boolean z) {
        return (str == null || !this.f2038a.containsKey(str)) ? z : ((Boolean) this.f2038a.get(str)).booleanValue();
    }

    public void a(String str, int i) {
        if (str != null) {
            this.f2038a.put(str, Integer.valueOf(i));
        }
    }

    public int c(String str) {
        return b(str, 0);
    }

    public int b(String str, int i) {
        return (str == null || !this.f2038a.containsKey(str)) ? i : ((Integer) this.f2038a.get(str)).intValue();
    }

    public void a(String str, long j) {
        if (str != null) {
            this.f2038a.put(str, Long.valueOf(j));
        }
    }

    public long b(String str, long j) {
        return (str == null || !this.f2038a.containsKey(str)) ? j : ((Long) this.f2038a.get(str)).longValue();
    }

    public void a(com.cmic.gen.sdk.d.b bVar) {
        if (bVar != null) {
            this.f2038a.put("logBean", bVar);
        }
    }

    public com.cmic.gen.sdk.d.b a() {
        com.cmic.gen.sdk.d.b bVar = (com.cmic.gen.sdk.d.b) this.f2038a.get("logBean");
        return bVar != null ? bVar : new com.cmic.gen.sdk.d.b();
    }

    public void a(com.cmic.gen.sdk.a.a aVar) {
        if (aVar != null) {
            this.f2038a.put("current_config", aVar);
        }
    }

    public com.cmic.gen.sdk.a.a b() {
        com.cmic.gen.sdk.a.a aVar = (com.cmic.gen.sdk.a.a) this.f2038a.get("current_config");
        if (aVar != null) {
            return aVar;
        }
        com.cmic.gen.sdk.f.c.a("UmcConfigBean为空", "请核查");
        return new com.cmic.gen.sdk.a.a.C0343a().a();
    }
}

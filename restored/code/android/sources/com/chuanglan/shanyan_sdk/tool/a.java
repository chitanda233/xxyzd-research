package com.chuanglan.shanyan_sdk.tool;

/* JADX INFO: loaded from: classes2.dex */
public class a {
    private static volatile a d;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private ShanYanUIConfig f2014a;
    private ShanYanUIConfig b = null;
    private ShanYanUIConfig c = null;

    public static a b() {
        if (d == null) {
            synchronized (a.class) {
                if (d == null) {
                    d = new a();
                }
            }
        }
        return d;
    }

    public void a(ShanYanUIConfig shanYanUIConfig, ShanYanUIConfig shanYanUIConfig2, ShanYanUIConfig shanYanUIConfig3) {
        this.c = shanYanUIConfig;
        this.b = shanYanUIConfig2;
        this.f2014a = shanYanUIConfig3;
    }

    public ShanYanUIConfig c() {
        return this.b;
    }

    public void d() {
        ShanYanUIConfig shanYanUIConfig = this.f2014a;
        if (shanYanUIConfig != null) {
            shanYanUIConfig.remove();
            this.f2014a = null;
        }
        ShanYanUIConfig shanYanUIConfig2 = this.b;
        if (shanYanUIConfig2 != null) {
            shanYanUIConfig2.remove();
            this.b = null;
        }
        ShanYanUIConfig shanYanUIConfig3 = this.c;
        if (shanYanUIConfig3 != null) {
            shanYanUIConfig3.remove();
            this.c = null;
        }
    }

    public ShanYanUIConfig a() {
        ShanYanUIConfig shanYanUIConfig = this.c;
        if (shanYanUIConfig != null) {
            return shanYanUIConfig;
        }
        ShanYanUIConfig shanYanUIConfig2 = this.f2014a;
        return shanYanUIConfig2 != null ? shanYanUIConfig2 : new ShanYanUIConfig.Builder().build();
    }
}

package com.byazt.gf;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 914, 46})
public class n {
    public static n c;
    public boolean tt = false;
    public long ve = 180000;
    public long uj = 43200000;
    public long n = 3;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public long f944a = 30;
    public long sp = 15;

    private n() {
    }

    public static n c() {
        if (c == null) {
            synchronized (n.class) {
                if (c == null) {
                    c = new n();
                }
            }
        }
        return c;
    }

    public synchronized void c(JSONObject jSONObject) {
        if (jSONObject != null) {
            if (!jSONObject.toString().isEmpty()) {
                this.tt = jSONObject.optBoolean("sensorenable", false);
                this.ve = jSONObject.optLong("interval", 180000L);
                this.uj = jSONObject.optLong("expireduation", 43200000L);
                this.n = jSONObject.optLong("showinterval", 3L);
                this.f944a = jSONObject.optLong("azimuth_unit", 30L);
                this.sp = jSONObject.optLong("angle_unit", 15L);
            }
        }
    }

    public boolean tt() {
        return this.tt;
    }

    public long ve() {
        return this.uj;
    }

    public long uj() {
        return this.ve;
    }

    public long n() {
        return this.n;
    }

    public long a() {
        return this.f944a;
    }

    public long sp() {
        return this.sp;
    }
}

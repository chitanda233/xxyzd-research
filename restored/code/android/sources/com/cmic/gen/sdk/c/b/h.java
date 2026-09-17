package com.cmic.gen.sdk.c.b;

import org.json.JSONObject;

/* JADX INFO: compiled from: RequestParameter.java */
/* JADX INFO: loaded from: classes2.dex */
public abstract class h {
    public abstract String a();

    protected abstract String a_(String str);

    public abstract JSONObject b();

    public String y(String str) {
        return com.cmic.gen.sdk.f.d.a(a_(str)).toLowerCase();
    }
}

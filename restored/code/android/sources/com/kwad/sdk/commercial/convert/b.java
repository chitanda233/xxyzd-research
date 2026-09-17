package com.kwad.sdk.commercial.convert;

/* JADX INFO: loaded from: classes3.dex */
public class b extends com.kwad.sdk.commercial.c.a {
    public boolean aKq;
    public boolean aKr;
    public String aKs;
    public int adNum;
    public String adSource;
    public String methodName;

    public static b IC() {
        return new b();
    }

    public final b dr(String str) {
        this.methodName = str;
        return this;
    }

    public final b bC(boolean z) {
        this.aKq = z;
        return this;
    }

    public final b dq(int i) {
        this.adNum = i;
        return this;
    }

    public final b ds(String str) {
        this.aKs = str;
        return this;
    }

    public final b dt(String str) {
        this.adSource = str;
        return this;
    }
}

package com.kwad.components.ad.draw.a;

/* JADX INFO: loaded from: classes3.dex */
public class a extends com.kwad.sdk.commercial.c.a {
    public int adNum;
    public int adStyle;
    public long dI;
    public int dJ;
    public long loadTime;
    public int materialType;
    public String materialUrl;
    public String methodName;
    public long renderTime;
    public int renderType;
    public int status;

    public static a aO() {
        return new a();
    }

    public final a s(int i) {
        this.status = i;
        return this;
    }

    public final a o(String str) {
        this.methodName = str;
        return this;
    }

    public final a t(int i) {
        this.adNum = i;
        return this;
    }

    public final a e(long j) {
        this.loadTime = j;
        return this;
    }

    public final a f(long j) {
        this.renderTime = j;
        return this;
    }

    public final a g(long j) {
        this.dI = j;
        return this;
    }

    public final a u(int i) {
        this.materialType = i;
        return this;
    }

    public final a p(String str) {
        this.materialUrl = str;
        return this;
    }

    public final a v(int i) {
        this.renderType = i;
        return this;
    }

    public final a w(int i) {
        this.dJ = i;
        return this;
    }

    public final a x(int i) {
        this.adStyle = i;
        return this;
    }
}

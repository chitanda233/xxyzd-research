package com.kwad.sdk.commercial.b;

import java.net.URL;

/* JADX INFO: loaded from: classes3.dex */
public class b extends com.kwad.sdk.commercial.c.a {
    public String aKa;
    public String aKh;
    public String aKi;
    public int aKj;
    public int aKk;
    public int status;
    public String url;

    public static b IB() {
        return new b();
    }

    public final b dn(int i) {
        this.status = i;
        return this;
    }

    public final b dp(String str) {
        this.url = str;
        try {
            URL url = new URL(str);
            this.aKa = url.getHost();
            this.aKh = url.getPath();
        } catch (Throwable unused) {
        }
        return this;
    }

    /* JADX INFO: renamed from: do, reason: not valid java name */
    public final b m176do(int i) {
        this.aKj = i;
        return this;
    }

    public final b dp(int i) {
        this.aKk = i;
        return this;
    }

    public final b dq(String str) {
        this.aKi = str;
        return this;
    }
}

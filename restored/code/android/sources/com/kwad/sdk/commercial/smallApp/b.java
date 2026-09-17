package com.kwad.sdk.commercial.smallApp;

import java.net.URL;

/* JADX INFO: loaded from: classes3.dex */
public class b extends com.kwad.sdk.commercial.c.a {
    public String aKF;
    public String aKG;
    public String aKH;
    public String aKa;
    public String aKh;
    public int status;
    public String url;

    public static b a(JumpFrom jumpFrom) {
        return new b(jumpFrom);
    }

    private b(JumpFrom jumpFrom) {
        if (jumpFrom != null) {
            this.aKH = jumpFrom.getValue();
        }
    }

    public final b du(int i) {
        this.status = i;
        return this;
    }

    public final b dF(String str) {
        this.url = str;
        try {
            URL url = new URL(str);
            this.aKa = url.getHost();
            this.aKh = url.getPath();
        } catch (Throwable unused) {
        }
        return this;
    }

    public final b dG(String str) {
        this.aKF = str;
        return this;
    }

    public final b dH(String str) {
        this.aKG = str;
        return this;
    }
}

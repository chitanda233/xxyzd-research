package com.kwad.sdk.commercial.f;

import java.net.URL;

/* JADX INFO: loaded from: classes3.dex */
public class b extends com.kwad.sdk.commercial.c.a {
    public String aKa;
    public String aKh;
    public int adu;
    public int status;
    public String url;

    public static b IG() {
        return new b();
    }

    public final b ds(int i) {
        this.status = i;
        return this;
    }

    public final b dt(int i) {
        this.adu = i;
        return this;
    }

    public final b dz(String str) {
        this.url = str;
        try {
            URL url = new URL(str);
            this.aKa = url.getHost();
            this.aKh = url.getPath();
        } catch (Throwable unused) {
        }
        return this;
    }
}

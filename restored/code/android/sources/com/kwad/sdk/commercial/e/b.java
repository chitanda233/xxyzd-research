package com.kwad.sdk.commercial.e;

import java.net.URL;

/* JADX INFO: loaded from: classes3.dex */
public class b extends com.kwad.sdk.commercial.c.a {
    public String aKa;
    public String aKh;
    public int status;
    public String url;

    public static b IF() {
        return new b();
    }

    public final b dr(int i) {
        this.status = i;
        return this;
    }

    public final b dy(String str) {
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

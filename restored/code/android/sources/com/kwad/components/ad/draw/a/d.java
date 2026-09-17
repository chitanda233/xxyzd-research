package com.kwad.components.ad.draw.a;

/* JADX INFO: loaded from: classes3.dex */
public class d extends com.kwad.sdk.commercial.c.a {
    public long dK;
    public int materialType;
    public String materialUrl;
    public int status;

    public static d aP() {
        return new d();
    }

    public final d y(int i) {
        this.status = i;
        return this;
    }

    public final d z(int i) {
        this.materialType = i;
        return this;
    }

    public final d q(String str) {
        this.materialUrl = str;
        return this;
    }

    public final d h(long j) {
        this.dK = j;
        return this;
    }
}

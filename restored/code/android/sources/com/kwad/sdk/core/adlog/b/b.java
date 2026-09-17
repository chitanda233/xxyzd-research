package com.kwad.sdk.core.adlog.b;

import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public class b extends com.kwad.sdk.commercial.c.a {
    public int aKK;
    public int aLP;
    public String aLQ;
    public boolean aLZ;
    public int aMa;
    public int aMb;
    public long aMc;
    public int retryCount;
    public int status;

    public static b Jp() {
        return new b();
    }

    public final b dA(int i) {
        this.status = i;
        return this;
    }

    public final b bE(boolean z) {
        this.aLZ = z;
        return this;
    }

    public final b dB(int i) {
        this.aKK = i;
        return this;
    }

    @Override // com.kwad.sdk.commercial.c.a
    /* JADX INFO: renamed from: cz, reason: merged with bridge method [inline-methods] */
    public final b setAdTemplate(AdTemplate adTemplate) {
        super.setAdTemplate(adTemplate);
        return this;
    }

    public final b dC(int i) {
        this.retryCount = i;
        return this;
    }

    public final b dD(int i) {
        this.aLP = i;
        return this;
    }

    public final b dW(String str) {
        this.aLQ = str;
        return this;
    }

    public final b dE(int i) {
        this.aMa = i;
        return this;
    }

    public final b dF(int i) {
        this.aMb = i;
        return this;
    }

    public final b aw(long j) {
        this.aMc = j;
        return this;
    }
}

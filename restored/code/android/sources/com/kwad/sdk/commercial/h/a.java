package com.kwad.sdk.commercial.h;

import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public class a extends com.kwad.sdk.commercial.c.a {
    public String aKC;
    public String aKD;
    public String aKE;
    public String aKu;

    public static a IJ() {
        return new a();
    }

    public final a dB(String str) {
        this.aKE = str;
        return this;
    }

    public final a dC(String str) {
        this.aKu = str;
        return this;
    }

    public final a dD(String str) {
        this.aKC = str;
        return this;
    }

    public final a dE(String str) {
        this.aKD = str;
        return this;
    }

    @Override // com.kwad.sdk.commercial.c.a
    /* JADX INFO: renamed from: cg, reason: merged with bridge method [inline-methods] */
    public final a setAdTemplate(AdTemplate adTemplate) {
        super.setAdTemplate(adTemplate);
        return this;
    }
}

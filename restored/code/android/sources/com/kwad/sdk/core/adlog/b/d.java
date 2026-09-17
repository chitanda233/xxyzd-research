package com.kwad.sdk.core.adlog.b;

import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public class d extends com.kwad.sdk.commercial.c.a {
    public String aKD;
    public int aKK;
    public int aMd;
    public int retryCount;
    public int status;

    public static d Jq() {
        return new d();
    }

    public final d dG(int i) {
        this.status = i;
        return this;
    }

    public final d dX(String str) {
        this.aKD = str;
        return this;
    }

    public final d dH(int i) {
        this.aKK = i;
        return this;
    }

    public final d dI(int i) {
        this.aMd = 1;
        return this;
    }

    public final d dJ(int i) {
        this.retryCount = i;
        return this;
    }

    @Override // com.kwad.sdk.commercial.c.a
    /* JADX INFO: renamed from: dY, reason: merged with bridge method [inline-methods] */
    public final d setErrorMsg(String str) {
        super.setErrorMsg(str);
        return this;
    }

    @Override // com.kwad.sdk.commercial.c.a
    /* JADX INFO: renamed from: dK, reason: merged with bridge method [inline-methods] */
    public final d setErrorCode(int i) {
        super.setErrorCode(i);
        return this;
    }

    @Override // com.kwad.sdk.commercial.c.a
    /* JADX INFO: renamed from: cA, reason: merged with bridge method [inline-methods] */
    public final d setAdTemplate(AdTemplate adTemplate) {
        super.setAdTemplate(adTemplate);
        return this;
    }
}

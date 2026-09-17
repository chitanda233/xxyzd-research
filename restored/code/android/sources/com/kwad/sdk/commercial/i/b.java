package com.kwad.sdk.commercial.i;

import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public class b extends com.kwad.sdk.commercial.c.a {
    public String aKC;
    public String aKD;
    public int aKK;
    public int requestType;
    public int status;

    public static b IN() {
        return new b();
    }

    public final b dv(int i) {
        this.status = i;
        return this;
    }

    public final b dw(int i) {
        this.aKK = i;
        return this;
    }

    public final b dJ(String str) {
        this.aKC = str;
        return this;
    }

    public final b dK(String str) {
        this.aKD = str;
        return this;
    }

    public final b dx(int i) {
        this.requestType = i;
        return this;
    }

    @Override // com.kwad.sdk.commercial.c.a
    /* JADX INFO: renamed from: dy, reason: merged with bridge method [inline-methods] */
    public final b setErrorCode(int i) {
        super.setErrorCode(i);
        return this;
    }

    @Override // com.kwad.sdk.commercial.c.a
    /* JADX INFO: renamed from: dL, reason: merged with bridge method [inline-methods] */
    public final b setErrorMsg(String str) {
        super.setErrorMsg(str);
        return this;
    }

    @Override // com.kwad.sdk.commercial.c.a
    /* JADX INFO: renamed from: ch, reason: merged with bridge method [inline-methods] */
    public final b setAdTemplate(AdTemplate adTemplate) {
        super.setAdTemplate(adTemplate);
        return this;
    }
}

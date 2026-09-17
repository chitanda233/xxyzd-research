package com.kwad.components.ad.reward.retryReward;

import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public class c extends com.kwad.sdk.commercial.c.a {
    public String Br;
    public String Bs;
    public int convertType;
    public int errorCode;
    public String errorMsg;
    public String productName;
    public int status;
    public String tL;

    public static c kC() {
        return new c();
    }

    public final c ag(int i) {
        this.status = i;
        return this;
    }

    @Override // com.kwad.sdk.commercial.c.a
    /* JADX INFO: renamed from: ah, reason: merged with bridge method [inline-methods] */
    public final c setErrorCode(int i) {
        this.errorCode = i;
        return this;
    }

    @Override // com.kwad.sdk.commercial.c.a
    /* JADX INFO: renamed from: W, reason: merged with bridge method [inline-methods] */
    public final c setErrorMsg(String str) {
        this.errorMsg = str;
        return this;
    }

    public final c c(f fVar) {
        if (fVar == null) {
            return this;
        }
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(fVar.mAdTemplate);
        super.setAdTemplate(fVar.mAdTemplate);
        this.productName = com.kwad.sdk.core.response.helper.a.aD(adInfoEM);
        this.convertType = com.kwad.sdk.core.response.helper.a.dx(adInfoEM);
        return this;
    }

    public final c aa(AdTemplate adTemplate) {
        if (adTemplate == null) {
            return this;
        }
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        super.setAdTemplate(adTemplate);
        this.productName = com.kwad.sdk.core.response.helper.a.aD(adInfoEM);
        this.convertType = com.kwad.sdk.core.response.helper.a.dx(adInfoEM);
        return this;
    }
}

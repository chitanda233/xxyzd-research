package com.kwad.sdk.commercial.c;

import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdMatrixInfo;
import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public abstract class a extends com.kwad.sdk.core.response.a.a {
    public int adOperationType;
    public int campaignType;
    public long creativeId;
    public int errorCode;
    public String errorMsg;
    public int industryFirstLevelId;
    public long llsid;
    public int ocpcActionType;
    public long posId;
    public String templateId;
    public String templateVersion;
    public int tkPublishType;
    public int webUriSourceType;

    public a setLlsid(long j) {
        this.llsid = j;
        return this;
    }

    public a setPosId(long j) {
        this.posId = j;
        return this;
    }

    public a setAdTemplate(AdTemplate adTemplate) {
        if (adTemplate == null) {
            return this;
        }
        this.creativeId = e.eW(adTemplate);
        this.llsid = e.eJ(adTemplate);
        this.posId = e.eF(adTemplate);
        AdInfo adInfoEM = e.eM(adTemplate);
        this.campaignType = com.kwad.sdk.core.response.helper.a.dw(adInfoEM);
        this.ocpcActionType = com.kwad.sdk.core.response.helper.a.dx(adInfoEM);
        this.industryFirstLevelId = com.kwad.sdk.core.response.helper.a.dy(adInfoEM);
        this.adOperationType = com.kwad.sdk.core.response.helper.a.aW(adInfoEM);
        this.webUriSourceType = com.kwad.sdk.core.response.helper.a.dz(adInfoEM);
        AdMatrixInfo.MatrixTemplate matrixTemplateBx = com.kwad.sdk.commercial.e.bx(adTemplate);
        if (matrixTemplateBx != null) {
            this.templateId = matrixTemplateBx.templateId;
            this.templateVersion = String.valueOf(matrixTemplateBx.templateVersionCode);
            this.tkPublishType = matrixTemplateBx.publishType;
        }
        return this;
    }

    public a setErrorCode(int i) {
        this.errorCode = i;
        return this;
    }

    public a setErrorMsg(String str) {
        this.errorMsg = str;
        return this;
    }
}

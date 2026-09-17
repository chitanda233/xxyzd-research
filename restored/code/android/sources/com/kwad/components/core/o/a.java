package com.kwad.components.core.o;

import android.text.TextUtils;
import com.kwad.components.core.request.model.ImpInfo;
import com.kwad.sdk.core.network.l;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.threads.GlobalThreadPools;
import java.util.concurrent.ExecutorService;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class a extends l<com.kwad.components.core.request.a, AdResultData> {
    private ImpInfo abv;

    public a(ImpInfo impInfo) {
        this.abv = impInfo;
    }

    /* JADX INFO: Access modifiers changed from: protected */
    @Override // com.kwad.sdk.core.network.a
    /* JADX INFO: renamed from: pd */
    public com.kwad.components.core.request.a createRequest() {
        return new com.kwad.components.core.request.a(this.abv);
    }

    /* JADX INFO: Access modifiers changed from: protected */
    @Override // com.kwad.sdk.core.network.l
    /* JADX INFO: renamed from: ah */
    public AdResultData parseData(String str) {
        JSONObject jSONObject = new JSONObject(str);
        AdResultData adResultData = new AdResultData(this.abv.adScene);
        adResultData.parseJson(jSONObject);
        return adResultData;
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.sdk.core.network.l
    /* JADX INFO: renamed from: o, reason: merged with bridge method [inline-methods] */
    public void afterParseData(AdResultData adResultData) {
        super.afterParseData(adResultData);
        p(adResultData);
    }

    private static void p(AdResultData adResultData) {
        for (AdTemplate adTemplate : adResultData.getProceedTemplateList()) {
            AdInfo adInfoEM = e.eM(adTemplate);
            if (com.kwad.sdk.core.response.helper.a.bj(adInfoEM)) {
                if (com.kwad.sdk.core.response.helper.a.bg(adInfoEM).size() == 0) {
                    com.kwad.components.core.p.a.vX().i(adTemplate, 21005);
                }
            } else if (com.kwad.sdk.core.response.helper.a.bo(adInfoEM) && TextUtils.isEmpty(com.kwad.sdk.core.response.helper.a.M(adInfoEM))) {
                com.kwad.components.core.p.a.vX().i(adTemplate, 21006);
            }
        }
    }

    @Override // com.kwad.sdk.core.network.a
    public ExecutorService getExecutor() {
        return GlobalThreadPools.On();
    }
}

package com.kwad.components.core.c;

import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.threads.GlobalThreadPools;
import com.kwad.sdk.utils.bi;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class k extends com.kwad.sdk.core.network.o<com.kwad.components.core.request.a, AdResultData> {
    private final com.kwad.components.core.request.model.a Py;

    protected boolean a(com.kwad.components.core.request.model.a aVar, AdResultData adResultData) {
        return false;
    }

    public k(com.kwad.components.core.request.model.a aVar) {
        this.Py = aVar;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void m(AdResultData adResultData) {
        List<AdTemplate> proceedTemplateList = adResultData.getProceedTemplateList();
        a aVarOF = a.oF();
        if (aVarOF == null || proceedTemplateList.size() <= 0) {
            return;
        }
        AdTemplate adTemplate = proceedTemplateList.get(0);
        e eVarX = e.x(adResultData.getPosId());
        aVarOF.oG();
        aVarOF.j(i.a(eVarX, adResultData));
        aVarOF.a(e.ax(adTemplate));
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.sdk.core.network.o, com.kwad.sdk.core.network.g
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public void onSuccess(com.kwad.components.core.request.a aVar, final AdResultData adResultData) {
        super.onSuccess(aVar, adResultData);
        GlobalThreadPools.Om().submit(new bi() { // from class: com.kwad.components.core.c.k.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                k kVar = k.this;
                k.m(adResultData);
            }
        });
        if (a(this.Py, adResultData)) {
            return;
        }
        com.kwad.components.core.request.model.a.a(this.Py, adResultData, false);
    }

    @Override // com.kwad.sdk.core.network.o, com.kwad.sdk.core.network.g
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public void onError(com.kwad.components.core.request.a aVar, int i, String str) {
        super.onError(aVar, i, str);
        com.kwad.components.core.request.model.a.a(this.Py, i, str, false);
    }
}

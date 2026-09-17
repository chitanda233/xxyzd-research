package com.kwad.components.core.webview.tachikoma;

import android.text.TextUtils;
import com.kwad.components.core.webview.tachikoma.c.m;
import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public final class a implements com.kwad.sdk.core.webview.c.a {
    private final AdTemplate mAdTemplate;

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "getLandingPageInfo";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
    }

    public a(AdTemplate adTemplate) {
        this.mAdTemplate = adTemplate;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        AdTemplate adTemplate = this.mAdTemplate;
        if (adTemplate != null) {
            String strAY = com.kwad.sdk.core.response.helper.a.aY(com.kwad.sdk.core.response.helper.e.eM(adTemplate));
            if (TextUtils.isEmpty(strAY)) {
                cVar.onError(-1, "landing page url is null");
                return;
            }
            m mVar = new m();
            mVar.auu = strAY;
            cVar.b(mVar);
            return;
        }
        cVar.onError(-1, "adTemplate is null");
    }
}

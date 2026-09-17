package com.kwad.components.core.webview.jshandler;

import android.content.Context;
import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public class bk implements com.kwad.sdk.core.webview.c.a {
    private a arY;
    private AdTemplate mAdTemplate;
    protected Context mContext;

    public interface a {
        boolean eR();
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "showPlayable";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
    }

    public bk(Context context, AdTemplate adTemplate) {
        this.mContext = com.kwad.sdk.wrapper.m.wrapContextIfNeed(context);
        this.mAdTemplate = adTemplate;
    }

    public final void a(a aVar) {
        this.arY = aVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        a aVar = this.arY;
        boolean zER = aVar != null ? aVar.eR() : true;
        com.kwad.sdk.core.d.c.d("WebShowPlayableHandler", "handleJsCall launch AdPlayableActivityProxy : " + zER);
        if (zER) {
            com.kwad.components.core.page.a.launch(this.mContext, this.mAdTemplate);
        }
    }
}

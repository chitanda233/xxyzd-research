package com.kwad.components.ad.reward.k;

/* JADX INFO: loaded from: classes3.dex */
public class c implements com.kwad.sdk.core.webview.c.a {
    private a BL;

    public interface a {
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "callButtonImpressionWhenPlay";
    }

    public void kr() {
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        kr();
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.BL = null;
    }
}

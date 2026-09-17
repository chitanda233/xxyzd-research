package com.kwad.components.ad.reward.k;

/* JADX INFO: loaded from: classes3.dex */
public class b implements com.kwad.sdk.core.webview.c.a {
    private a BK;

    public interface a {
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "callButtonImpressionWhenFinish";
    }

    public void kr() {
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        kr();
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.BK = null;
    }
}

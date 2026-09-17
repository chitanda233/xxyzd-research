package com.kwad.components.ad.reward.k;

/* JADX INFO: loaded from: classes3.dex */
public final class e implements com.kwad.sdk.core.webview.c.a {
    private a BN;

    public interface a {
        void kq();
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "clickGift";
    }

    public final void a(a aVar) {
        this.BN = aVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        a aVar = this.BN;
        if (aVar != null) {
            aVar.kq();
        }
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.BN = null;
    }
}

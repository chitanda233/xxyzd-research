package com.kwad.components.core.webview.jshandler;

/* JADX INFO: loaded from: classes3.dex */
public final class g implements com.kwad.sdk.core.webview.c.a {
    private com.kwad.sdk.core.webview.c.c apz;
    private int pp;
    private int pq;

    public static class a extends com.kwad.sdk.core.response.a.a {
        public int showLiveStatus;
        public int showLiveStyle;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "getLiveInfo";
    }

    public g(int i, int i2) {
        this.pp = i;
        this.pq = i2;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        this.apz = cVar;
        t(this.pp, this.pq);
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.apz = null;
    }

    private void t(int i, int i2) {
        if (this.apz == null) {
            return;
        }
        a aVar = new a();
        aVar.showLiveStatus = i;
        aVar.showLiveStyle = i2;
        this.apz.b(aVar);
    }
}

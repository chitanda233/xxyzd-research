package com.kwad.components.core.webview.jshandler;

/* JADX INFO: loaded from: classes3.dex */
public final class bi implements com.kwad.sdk.core.webview.c.a {
    private final a arQ;
    private com.kwad.sdk.core.webview.c.c qW;

    public interface a {
        void uN();
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "unregisterBackClickListener";
    }

    public bi(a aVar) {
        this.arQ = aVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        this.qW = cVar;
        a aVar = this.arQ;
        if (aVar != null) {
            aVar.uN();
        }
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.qW = null;
    }
}

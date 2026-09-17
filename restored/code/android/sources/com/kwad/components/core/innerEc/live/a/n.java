package com.kwad.components.core.innerEc.live.a;

/* JADX INFO: loaded from: classes3.dex */
public final class n implements com.kwad.sdk.core.webview.c.a {
    private final a TT;

    public interface a {
        void rJ();
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "showSoftInput";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
    }

    public n(a aVar) {
        this.TT = aVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        a aVar = this.TT;
        if (aVar != null) {
            aVar.rJ();
        }
    }
}

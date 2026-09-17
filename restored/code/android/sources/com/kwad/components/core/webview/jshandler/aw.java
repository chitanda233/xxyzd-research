package com.kwad.components.core.webview.jshandler;

/* JADX INFO: loaded from: classes3.dex */
public final class aw implements com.kwad.sdk.core.webview.c.a {
    private com.kwad.sdk.core.webview.c.c apz;

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "registerDeeplinkListener";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        this.apz = cVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.apz = null;
    }

    public final void onSuccess() {
        com.kwad.sdk.core.webview.c.c cVar = this.apz;
        if (cVar != null) {
            cVar.b(null);
        }
    }

    public final void onFailed() {
        com.kwad.sdk.core.webview.c.c cVar = this.apz;
        if (cVar != null) {
            cVar.onError(-1, "deep link error");
        }
    }
}

package com.kwad.components.core.webview.jshandler;

/* JADX INFO: loaded from: classes3.dex */
public final class ay implements com.kwad.sdk.core.webview.c.a {
    private com.kwad.sdk.core.webview.c.c apz;

    public static final class a extends com.kwad.sdk.core.response.a.a implements com.kwad.sdk.core.b {
        public String arw;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "registerFocusListener";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        this.apz = cVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.apz = null;
    }

    public final void bl(boolean z) {
        if (z) {
            aE("windowFocusGet");
        } else {
            aE("windowFocusLost");
        }
    }

    private void aE(String str) {
        if (this.apz != null) {
            a aVar = new a();
            aVar.arw = str;
            this.apz.b(aVar);
        }
    }
}

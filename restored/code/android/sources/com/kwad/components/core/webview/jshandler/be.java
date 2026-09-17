package com.kwad.components.core.webview.jshandler;

/* JADX INFO: loaded from: classes3.dex */
public final class be implements com.kwad.sdk.core.webview.c.a {
    private com.kwad.sdk.core.webview.c.c apz;
    private a arJ = new a();

    public static final class a extends com.kwad.sdk.core.response.a.a implements com.kwad.sdk.core.b {
        public int status;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "registerVideoListener";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        this.apz = cVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.apz = null;
    }

    public final void bV(int i) {
        if (this.apz != null) {
            this.arJ.status = i;
            this.apz.b(this.arJ);
        }
    }
}

package com.kwad.components.core.webview.jshandler;

/* JADX INFO: loaded from: classes3.dex */
public final class h implements com.kwad.sdk.core.webview.c.a {
    private int HB;
    private com.kwad.sdk.core.webview.c.c apz;

    public static class a extends com.kwad.sdk.core.response.a.a {
        public int loadType;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "getLoadInfo";
    }

    public h(int i) {
        this.HB = i;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        this.apz = cVar;
        bS(this.HB);
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.apz = null;
    }

    private void bS(int i) {
        if (this.apz == null) {
            return;
        }
        a aVar = new a();
        aVar.loadType = i;
        this.apz.b(aVar);
    }
}

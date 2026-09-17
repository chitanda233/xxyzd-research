package com.kwad.components.core.webview.jshandler;

/* JADX INFO: loaded from: classes3.dex */
public final class av implements com.kwad.sdk.core.webview.c.a {
    private com.kwad.sdk.core.webview.c.c apz;
    private b arr;

    public static final class a extends com.kwad.sdk.core.response.a.a implements com.kwad.sdk.core.b {
        public int status;
    }

    public interface b {
        void uM();
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "registerBackClickListener";
    }

    public av(b bVar) {
        this.arr = bVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        this.apz = cVar;
        b bVar = this.arr;
        if (bVar != null) {
            bVar.uM();
        }
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.apz = null;
    }

    public final void yI() {
        if (this.apz != null) {
            a aVar = new a();
            aVar.status = 1;
            this.apz.b(aVar);
        }
    }
}

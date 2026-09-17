package com.kwad.components.core.webview.tachikoma.b;

/* JADX INFO: loaded from: classes3.dex */
public final class o extends w {
    private a atU;

    public interface a {
        boolean isMuted();
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "registerMuteStateListener";
    }

    public final void a(a aVar) {
        this.atU = aVar;
    }

    public final void c(com.kwad.components.core.webview.tachikoma.c.n nVar) {
        super.a(nVar);
    }

    @Override // com.kwad.components.core.webview.tachikoma.b.w, com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        super.a(str, cVar);
        if (this.atU != null) {
            com.kwad.components.core.webview.tachikoma.c.n nVar = new com.kwad.components.core.webview.tachikoma.c.n();
            nVar.auv = this.atU.isMuted();
            cVar.b(nVar);
        }
    }
}

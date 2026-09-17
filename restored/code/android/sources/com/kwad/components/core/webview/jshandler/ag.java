package com.kwad.components.core.webview.jshandler;

/* JADX INFO: loaded from: classes3.dex */
public final class ag implements com.kwad.sdk.core.webview.c.a {
    private final com.kwad.sdk.core.webview.b apL;

    public static final class a extends com.kwad.sdk.core.response.a.a {
        public String playableExtraData;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "getKsPlayableAdData";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
    }

    public ag(com.kwad.sdk.core.webview.b bVar) {
        this.apL = bVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        if (this.apL.PE()) {
            cVar.onError(-1, "native adTemplate is null");
            return;
        }
        a aVar = new a();
        try {
            aVar.playableExtraData = this.apL.getAdTemplate().adInfoList.get(0).adStyleInfo.playableExtraData;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
        }
        cVar.b(aVar);
    }
}

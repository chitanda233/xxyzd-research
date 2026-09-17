package com.kwad.components.core.webview.jshandler;

import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public final class bb implements com.kwad.sdk.core.webview.c.a {
    private final a arC;

    public interface a {
        void cN();
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "registerMotionListener";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
    }

    public bb(a aVar) {
        this.arC = aVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, final com.kwad.sdk.core.webview.c.c cVar) {
        by.runOnUiThread(new com.kwad.sdk.utils.bi() { // from class: com.kwad.components.core.webview.jshandler.bb.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                if (bb.this.arC != null) {
                    bb.this.arC.cN();
                }
                cVar.b(null);
            }
        });
    }
}

package com.kwad.components.core.webview.jshandler;

import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public final class bh implements com.kwad.sdk.core.webview.c.a {
    private a arO;

    public interface a {
        void ys();
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "showDownloadTips";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
    }

    public bh(a aVar) {
        this.arO = aVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        yP();
    }

    private void yP() {
        if (com.kwad.components.core.e.c.b.pF()) {
            return;
        }
        by.runOnUiThread(new com.kwad.sdk.utils.bi() { // from class: com.kwad.components.core.webview.jshandler.bh.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                if (bh.this.arO != null) {
                    bh.this.arO.ys();
                }
            }
        });
    }
}

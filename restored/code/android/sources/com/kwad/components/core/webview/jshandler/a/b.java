package com.kwad.components.core.webview.jshandler.a;

import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public final class b implements com.kwad.sdk.core.webview.c.a {
    private c aoG;

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "exitWebView";
    }

    public b(c cVar) {
        this.aoG = cVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        by.runOnUiThread(new Runnable() { // from class: com.kwad.components.core.webview.jshandler.a.b.1
            @Override // java.lang.Runnable
            public final void run() {
                if (b.this.aoG != null) {
                    b.this.aoG.us();
                }
            }
        });
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.aoG = null;
    }
}

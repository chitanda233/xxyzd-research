package com.kwad.components.core.webview.jshandler;

import android.os.Handler;
import android.os.Looper;

/* JADX INFO: loaded from: classes3.dex */
public final class ad implements com.kwad.sdk.core.webview.c.a {
    private final com.kwad.sdk.core.webview.b apL;
    private a aqn;
    private Handler jc = new Handler(Looper.getMainLooper());

    public interface a {
        void cM();
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "dislike";
    }

    public ad(com.kwad.sdk.core.webview.b bVar, a aVar) {
        this.apL = bVar;
        this.aqn = aVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        this.jc.post(new com.kwad.sdk.utils.bi() { // from class: com.kwad.components.core.webview.jshandler.ad.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                ad.this.aqn.cM();
            }
        });
        cVar.b(null);
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.jc.removeCallbacksAndMessages(null);
    }
}

package com.kwad.components.core.webview.tachikoma;

import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public class e implements com.kwad.sdk.core.webview.c.a {
    private com.kwad.sdk.core.webview.c.c qW;

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "registerConvertStatusListener";
    }

    public final void b(final com.kwad.sdk.core.response.a.a aVar) {
        if (this.qW != null) {
            by.runOnUiThread(new bi() { // from class: com.kwad.components.core.webview.tachikoma.e.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    e.this.qW.b(aVar);
                }
            });
        }
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        this.qW = cVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.qW = null;
    }
}

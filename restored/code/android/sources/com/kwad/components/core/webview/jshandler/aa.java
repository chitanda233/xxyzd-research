package com.kwad.components.core.webview.jshandler;

import android.os.Handler;
import android.os.Looper;
import com.kwad.sdk.commercial.model.WebCloseStatus;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class aa implements com.kwad.sdk.core.webview.c.a {
    private Handler aqf = new Handler(Looper.getMainLooper());
    private com.kwad.sdk.core.webview.c.c aqg;
    private com.kwad.sdk.core.webview.d.a.b mWebCardCloseListener;

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "close";
    }

    public aa(com.kwad.sdk.core.webview.d.a.b bVar) {
        this.mWebCardCloseListener = bVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        this.aqg = cVar;
        final WebCloseStatus webCloseStatus = new WebCloseStatus();
        try {
            webCloseStatus.parseJson(new JSONObject(str));
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
        }
        this.aqf.post(new com.kwad.sdk.utils.bi() { // from class: com.kwad.components.core.webview.jshandler.aa.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                aa.this.c(webCloseStatus);
                if (aa.this.aqg != null) {
                    aa.this.aqg.b(null);
                }
            }
        });
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.mWebCardCloseListener = null;
        this.aqg = null;
        this.aqf.removeCallbacksAndMessages(null);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void c(WebCloseStatus webCloseStatus) {
        com.kwad.sdk.core.webview.d.a.b bVar = this.mWebCardCloseListener;
        if (bVar != null) {
            bVar.b(webCloseStatus);
        }
    }
}

package com.kwad.components.core.webview.jshandler;

import android.os.Handler;
import android.os.Looper;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class as implements com.kwad.sdk.core.webview.c.a {
    private Handler aqf = new Handler(Looper.getMainLooper());
    private com.kwad.sdk.core.webview.c.c aqg;
    private b fj;
    private String mUrl;

    public interface b {
        void a(a aVar);
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "pageStatus";
    }

    @Deprecated
    public as(b bVar) {
        this.fj = bVar;
    }

    public as(b bVar, String str) {
        this.fj = bVar;
        this.mUrl = str;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        this.aqg = cVar;
        try {
            final a aVar = new a();
            aVar.parseJson(new JSONObject(str));
            this.aqf.post(new com.kwad.sdk.utils.bi() { // from class: com.kwad.components.core.webview.jshandler.as.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    as.this.b(aVar);
                    if (as.this.aqg != null) {
                        as.this.aqg.b(null);
                    }
                }
            });
        } catch (JSONException e) {
            com.kwad.sdk.core.d.c.e("WebCardPageStatusHandler", "handleJsCall error: " + e);
            com.kwad.sdk.core.webview.b.c.b.ai(this.mUrl, e.getMessage());
            cVar.onError(-1, e.getMessage());
        }
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.fj = null;
        this.aqg = null;
        this.aqf.removeCallbacksAndMessages(null);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void b(a aVar) {
        b bVar = this.fj;
        if (bVar != null) {
            bVar.a(aVar);
        }
    }

    public static final class a extends com.kwad.sdk.core.response.a.a {
        public String errorMsg;
        public int status;

        public final boolean isSuccess() {
            return this.status == 1;
        }
    }
}

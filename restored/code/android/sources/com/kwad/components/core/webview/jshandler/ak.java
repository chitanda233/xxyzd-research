package com.kwad.components.core.webview.jshandler;

import android.os.Handler;
import android.os.Looper;
import android.text.TextUtils;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class ak implements com.kwad.sdk.core.webview.c.a {
    private final Handler aqf = new Handler(Looper.getMainLooper());
    private com.kwad.sdk.core.webview.c.c aqg;
    private b fi;

    public static class a extends com.kwad.sdk.core.response.a.a {
        public int aqN = -1;
        public int type;
    }

    public interface b {
        void a(a aVar);
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "hide";
    }

    public ak(b bVar) {
        this.fi = bVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        try {
            this.aqg = cVar;
            final a aVar = new a();
            if (!TextUtils.isEmpty(str)) {
                aVar.parseJson(new JSONObject(str));
            }
            this.aqf.post(new com.kwad.sdk.utils.bi() { // from class: com.kwad.components.core.webview.jshandler.ak.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    if (ak.this.aqg != null) {
                        ak.this.aqg.b(null);
                    }
                    ak.this.b(aVar);
                }
            });
        } catch (Exception e) {
            this.aqg.onError(-1, e.getMessage());
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
        }
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.fi = null;
        this.aqg = null;
        this.aqf.removeCallbacksAndMessages(null);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void b(a aVar) {
        b bVar = this.fi;
        if (bVar != null) {
            bVar.a(aVar);
        }
    }
}

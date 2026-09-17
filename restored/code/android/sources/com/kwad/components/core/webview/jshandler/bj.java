package com.kwad.components.core.webview.jshandler;

import android.os.Handler;
import android.os.Looper;
import android.text.TextUtils;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class bj implements com.kwad.sdk.core.webview.c.a {
    private static Handler arV;
    private com.kwad.components.core.e.d.d QK;
    private com.kwad.sdk.core.webview.b arU;
    private b arW;

    public static class a extends com.kwad.sdk.core.response.a.a {
        public int ne;
    }

    public interface b {
        void ae(int i);
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "playableConvert";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
    }

    public bj(com.kwad.sdk.core.webview.b bVar, com.kwad.components.core.e.d.d dVar, b bVar2) {
        this.arU = bVar;
        this.QK = dVar;
        this.arW = bVar2;
        if (arV == null) {
            arV = new Handler(Looper.getMainLooper());
        }
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        try {
            if (TextUtils.isEmpty(str)) {
                return;
            }
            a aVar = new a();
            aVar.parseJson(new JSONObject(str));
            final int i = aVar.ne;
            arV.post(new com.kwad.sdk.utils.bi() { // from class: com.kwad.components.core.webview.jshandler.bj.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    if (bj.this.arW != null) {
                        bj.this.arW.ae(i);
                    }
                }
            });
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
        }
    }
}

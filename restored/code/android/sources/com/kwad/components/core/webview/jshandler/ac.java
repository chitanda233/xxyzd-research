package com.kwad.components.core.webview.jshandler;

import android.os.Handler;
import android.os.Looper;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class ac implements com.kwad.sdk.core.webview.c.a {
    private final com.kwad.sdk.core.webview.b apL;
    private boolean apX;
    private Handler aqf;
    private boolean aqj;
    private boolean aqk;
    private com.kwad.sdk.core.webview.d.a.a fg;
    private final com.kwad.components.core.e.d.d mApkDownloadHelper;

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "convert";
    }

    public ac(com.kwad.sdk.core.webview.b bVar, com.kwad.components.core.e.d.d dVar, com.kwad.sdk.core.webview.d.a.a aVar, boolean z, boolean z2, boolean z3) {
        this.aqj = false;
        this.aqk = false;
        this.apX = z;
        this.aqf = new Handler(Looper.getMainLooper());
        this.apL = bVar;
        this.mApkDownloadHelper = dVar;
        this.aqj = false;
        if (dVar != null) {
            dVar.aI(1);
        }
        this.fg = aVar;
        this.aqk = z3;
    }

    public ac(com.kwad.sdk.core.webview.b bVar, com.kwad.components.core.e.d.d dVar, com.kwad.sdk.core.webview.d.a.a aVar) {
        this(bVar, dVar, aVar, false, false, false);
    }

    public ac(com.kwad.sdk.core.webview.b bVar, com.kwad.components.core.e.d.d dVar, com.kwad.sdk.core.webview.d.a.a aVar, byte b) {
        this(bVar, dVar, aVar, false, false, false);
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        if (this.apL.PE()) {
            cVar.onError(-1, "native adTemplate is null");
            return;
        }
        final com.kwad.sdk.core.webview.d.b.a aVar = new com.kwad.sdk.core.webview.d.b.a();
        try {
            aVar.parseJson(new JSONObject(str));
            aVar.QC = true;
        } catch (JSONException e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
        }
        if (this.apL.bbX) {
            this.aqf.post(new com.kwad.sdk.utils.bi() { // from class: com.kwad.components.core.webview.jshandler.ac.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    if (ac.this.apL.bbY || aVar.ara) {
                        ac.this.apL.getAdTemplate();
                        com.kwad.components.core.e.d.a.a(ac.this.apL.adZ.getContext(), ac.this.apL.getAdTemplate(), new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.core.webview.jshandler.ac.1.1
                            @Override // com.kwad.components.core.e.d.a.b
                            public final void onAdClicked() {
                                if (ac.this.fg != null) {
                                    ac.this.fg.a(aVar);
                                }
                            }
                        }, ac.this.mApkDownloadHelper, aVar.ara, ac.this.apX, ac.this.aqj, ac.this.aqk);
                    }
                }
            });
        } else if (this.fg != null) {
            this.aqf.post(new com.kwad.sdk.utils.bi() { // from class: com.kwad.components.core.webview.jshandler.ac.2
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    if (ac.this.fg != null) {
                        ac.this.fg.a(aVar);
                    }
                }
            });
        }
        cVar.b(null);
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.aqf.removeCallbacksAndMessages(null);
        this.fg = null;
    }
}

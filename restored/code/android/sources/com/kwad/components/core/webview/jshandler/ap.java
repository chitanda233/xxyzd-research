package com.kwad.components.core.webview.jshandler;

import com.kwad.sdk.api.KsAppDownloadListener;
import com.kwad.sdk.core.response.model.AdTemplate;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class ap implements com.kwad.sdk.core.webview.c.a {
    private final com.kwad.sdk.core.webview.b fc;

    public static final class a extends com.kwad.sdk.core.response.a.a {
        public String arb;
    }

    public static final class b extends com.kwad.sdk.core.response.a.a {
        public double ari;
        public double arj;
        public long soFarBytes;
        public int status;
        public long totalBytes;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "registerProgressListener";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        a aVar = new a();
        AdTemplate adTemplate = new AdTemplate();
        try {
            aVar.parseJson(new JSONObject(str));
            adTemplate.parseJson(new JSONObject(aVar.arb));
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            adTemplate = null;
        }
        if (adTemplate == null || !com.kwad.sdk.core.response.helper.e.eE(adTemplate) || this.fc.bbW == null) {
            return;
        }
        com.kwad.components.core.e.d.d dVar = new com.kwad.components.core.e.d.d(adTemplate);
        String strQn = dVar.qn();
        dVar.b(bF(strQn));
        this.fc.bbW.a(strQn, dVar);
        this.fc.bbW.b(strQn, cVar);
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        if (this.fc.bbW != null) {
            this.fc.bbW.release();
        }
    }

    private KsAppDownloadListener bF(String str) {
        return new com.kwad.sdk.core.download.a.a(str) { // from class: com.kwad.components.core.webview.jshandler.ap.1
            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onIdle() {
                if (ap.this.fc.bbW != null) {
                    ap.this.a(1, 0.0f, ap.this.fc.bbW.hQ(qn()));
                }
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onProgressUpdate(int i) {
                if (ap.this.fc.bbW != null) {
                    ap.this.a(2, (i * 1.0f) / 100.0f, ap.this.fc.bbW.hQ(qn()));
                }
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onDownloadFinished() {
                if (ap.this.fc.bbW != null) {
                    ap.this.a(5, 1.0f, ap.this.fc.bbW.hQ(qn()));
                }
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onDownloadFailed() {
                if (ap.this.fc.bbW != null) {
                    ap.this.a(1, 0.0f, ap.this.fc.bbW.hQ(qn()));
                }
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onInstalled() {
                if (ap.this.fc.bbW != null) {
                    ap.this.a(6, 1.0f, ap.this.fc.bbW.hQ(qn()));
                }
            }

            @Override // com.kwad.sdk.core.download.a.a
            public final void onPaused(int i) {
                if (ap.this.fc.bbW != null) {
                    ap.this.a(3, (i * 1.0f) / 100.0f, ap.this.fc.bbW.hQ(qn()));
                }
            }
        };
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(int i, float f, com.kwad.sdk.core.webview.c.c cVar) {
        if (cVar != null) {
            b bVar = new b();
            bVar.ari = f;
            bVar.status = i;
            bVar.totalBytes = com.kwad.sdk.core.response.helper.e.eM(this.fc.getAdTemplate()).totalBytes;
            bVar.soFarBytes = com.kwad.sdk.core.response.helper.e.eM(this.fc.getAdTemplate()).soFarBytes;
            if (bVar.totalBytes > 0) {
                bVar.arj = (bVar.soFarBytes * 1.0d) / bVar.totalBytes;
            } else {
                bVar.arj = 0.0d;
            }
            cVar.b(bVar);
        }
    }
}

package com.kwad.components.core.webview.jshandler;

import com.kwad.sdk.api.KsAppDownloadListener;
import com.kwad.sdk.core.NetworkMonitor;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class bc implements com.kwad.sdk.core.webview.c.a {
    private KsAppDownloadListener apj;
    private com.kwad.sdk.core.webview.c.c apz;
    private KsAppDownloadListener arE;
    private final com.kwad.sdk.core.webview.b fc;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "registerProgressListener";
    }

    public bc(com.kwad.sdk.core.webview.b bVar, com.kwad.components.core.e.d.d dVar) {
        this.fc = bVar;
        this.mApkDownloadHelper = dVar;
    }

    public bc(com.kwad.sdk.core.webview.b bVar, com.kwad.components.core.e.d.d dVar, KsAppDownloadListener ksAppDownloadListener) {
        this.fc = bVar;
        this.mApkDownloadHelper = dVar;
        this.arE = ksAppDownloadListener;
    }

    public final void setApkDownloadHelper(com.kwad.components.core.e.d.d dVar) {
        this.mApkDownloadHelper.qB();
        com.kwad.sdk.core.download.b.LK().a(this.mApkDownloadHelper);
        if (com.kwad.sdk.core.config.e.Kn()) {
            NetworkMonitor.getInstance().a(this.mApkDownloadHelper);
        }
        this.mApkDownloadHelper = dVar;
        KsAppDownloadListener ksAppDownloadListenerYD = yD();
        this.apj = ksAppDownloadListenerYD;
        this.mApkDownloadHelper.b(ksAppDownloadListenerYD);
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        if (this.fc.PE()) {
            cVar.onError(-1, "native photo is null");
            return;
        }
        this.apz = cVar;
        com.kwad.components.core.e.d.d dVar = this.mApkDownloadHelper;
        if (dVar != null) {
            KsAppDownloadListener ksAppDownloadListener = this.apj;
            if (ksAppDownloadListener == null) {
                KsAppDownloadListener ksAppDownloadListenerYD = yD();
                this.apj = ksAppDownloadListenerYD;
                this.mApkDownloadHelper.b(ksAppDownloadListenerYD);
                return;
            }
            dVar.d(ksAppDownloadListener);
        }
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        KsAppDownloadListener ksAppDownloadListener;
        this.apz = null;
        com.kwad.components.core.e.d.d dVar = this.mApkDownloadHelper;
        if (dVar == null || (ksAppDownloadListener = this.apj) == null) {
            return;
        }
        dVar.c(ksAppDownloadListener);
        this.apj = null;
    }

    private KsAppDownloadListener yD() {
        return new com.kwad.sdk.core.download.a.a() { // from class: com.kwad.components.core.webview.jshandler.bc.1
            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onIdle() {
                bc.this.a(1, 0.0f);
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onProgressUpdate(int i) {
                bc.this.a(2, (i * 1.0f) / 100.0f);
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onDownloadFinished() {
                bc.this.a(5, 1.0f);
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onDownloadFailed() {
                bc.this.a(1, 0.0f);
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onInstalled() {
                bc.this.a(6, 1.0f);
                if (bc.this.arE != null) {
                    bc.this.arE.onInstalled();
                }
            }

            @Override // com.kwad.sdk.core.download.a.a
            public final void onPaused(int i) {
                bc.this.a(3, (i * 1.0f) / 100.0f);
            }
        };
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(int i, float f) {
        if (this.apz != null) {
            a aVar = new a();
            aVar.arG = f;
            aVar.status = i;
            aVar.totalBytes = com.kwad.sdk.core.response.helper.e.eM(this.fc.getAdTemplate()).totalBytes;
            aVar.soFarBytes = com.kwad.sdk.core.response.helper.e.eM(this.fc.getAdTemplate()).soFarBytes;
            if (aVar.totalBytes > 0) {
                aVar.arH = (aVar.soFarBytes * 1.0f) / aVar.totalBytes;
            } else {
                aVar.arH = 0.0f;
            }
            this.apz.b(aVar);
        }
    }

    public static final class a implements com.kwad.sdk.core.b {
        public float arG;
        public float arH;
        public long creativeId;
        public long soFarBytes;
        public int status;
        public long totalBytes;

        @Override // com.kwad.sdk.core.b
        public final void parseJson(JSONObject jSONObject) {
        }

        @Override // com.kwad.sdk.core.b
        public final JSONObject toJson() {
            JSONObject jSONObject = new JSONObject();
            com.kwad.sdk.utils.ac.putValue(jSONObject, "progress", this.arG);
            com.kwad.sdk.utils.ac.putValue(jSONObject, "status", this.status);
            com.kwad.sdk.utils.ac.putValue(jSONObject, "totalBytes", this.totalBytes);
            com.kwad.sdk.utils.ac.putValue(jSONObject, "soFarBytes", this.soFarBytes);
            com.kwad.sdk.utils.ac.putValue(jSONObject, "realProgress", this.arH);
            com.kwad.sdk.utils.ac.putValue(jSONObject, "creativeId", this.creativeId);
            return jSONObject;
        }
    }
}

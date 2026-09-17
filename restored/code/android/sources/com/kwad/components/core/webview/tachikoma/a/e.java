package com.kwad.components.core.webview.tachikoma.a;

import com.kwad.components.core.webview.jshandler.bc;
import com.kwad.sdk.api.KsAppDownloadListener;
import com.kwad.sdk.components.o;

/* JADX INFO: loaded from: classes3.dex */
public final class e {
    private KsAppDownloadListener apj;
    private KsAppDownloadListener arE;
    private o ata;
    private com.kwad.sdk.core.webview.b fc;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;

    public e(com.kwad.components.core.e.d.d dVar, com.kwad.sdk.core.webview.b bVar, o oVar) {
        this.fc = bVar;
        this.mApkDownloadHelper = dVar;
        this.ata = oVar;
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

    private KsAppDownloadListener yD() {
        return new com.kwad.sdk.core.download.a.a() { // from class: com.kwad.components.core.webview.tachikoma.a.e.1
            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onIdle() {
                e.this.a(1, 0.0f);
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onProgressUpdate(int i) {
                e.this.a(2, (i * 1.0f) / 100.0f);
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onDownloadFinished() {
                e.this.a(5, 1.0f);
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onDownloadFailed() {
                e.this.a(1, 0.0f);
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onInstalled() {
                e.this.a(6, 1.0f);
                if (e.this.arE != null) {
                    e.this.arE.onInstalled();
                }
            }

            @Override // com.kwad.sdk.core.download.a.a
            public final void onPaused(int i) {
                e.this.a(3, (i * 1.0f) / 100.0f);
            }
        };
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(int i, float f) {
        bc.a aVar = new bc.a();
        aVar.arG = f;
        aVar.status = i;
        aVar.totalBytes = com.kwad.sdk.core.response.helper.e.eM(this.fc.getAdTemplate()).totalBytes;
        aVar.soFarBytes = com.kwad.sdk.core.response.helper.e.eM(this.fc.getAdTemplate()).soFarBytes;
        if (aVar.totalBytes > 0) {
            aVar.arH = (aVar.soFarBytes * 1.0f) / aVar.totalBytes;
        } else {
            aVar.arH = 0.0f;
        }
        this.ata.setDownloadProgress(aVar.toJson().toString());
    }
}

package com.kwad.components.ad.splashscreen.presenter;

import android.content.Context;
import com.kwad.sdk.utils.ae;

/* JADX INFO: loaded from: classes3.dex */
public final class s extends e {
    private com.kwad.sdk.core.download.a.a IZ;

    @Override // com.kwad.components.ad.splashscreen.presenter.e, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.IZ = new com.kwad.sdk.core.download.a.a() { // from class: com.kwad.components.ad.splashscreen.presenter.s.1
            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onDownloadFailed() {
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onDownloadFinished() {
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onIdle() {
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onInstalled() {
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onProgressUpdate(int i) {
            }

            @Override // com.kwad.sdk.core.download.a.a, com.kwad.sdk.api.KsAppDownloadListener
            public final void onDownloadStarted() {
                super.onDownloadStarted();
                Context context = s.this.getContext();
                if (context != null) {
                    String strCZ = com.kwad.sdk.utils.n.cZ(context);
                    ae.V(context, strCZ != null ? strCZ + ":已开始下载" : "已开始下载");
                }
            }
        };
        this.Hu.mApkDownloadHelper.b(this.IZ);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        if (this.IZ != null) {
            this.Hu.mApkDownloadHelper.c(this.IZ);
        }
    }
}

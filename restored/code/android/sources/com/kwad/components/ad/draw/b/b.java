package com.kwad.components.ad.draw.b;

import android.content.Context;
import com.kwad.components.core.e.d.d;
import com.kwad.components.offline.api.core.adlive.IAdLiveOfflineView;
import com.kwad.components.offline.api.core.adlive.IAdLivePlayModule;
import com.kwad.sdk.api.KsDrawAd;
import com.kwad.sdk.core.adlog.c;
import com.kwad.sdk.core.view.AdBaseFrameLayout;
import com.kwad.sdk.service.ServiceProvider;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.sdk.mvp.a {
    private boolean dM;
    public com.kwad.components.ad.draw.c.a dN;
    public IAdLivePlayModule dO;
    public IAdLiveOfflineView dP;
    public com.kwad.components.ad.draw.presenter.b.a dQ;
    public com.kwad.components.ad.l.b dR;
    public KsDrawAd.AdInteractionListener du;
    public d mApkDownloadHelper;
    public AdBaseFrameLayout mRootContainer;

    @Override // com.kwad.sdk.mvp.a
    public final void release() {
        d dVar = this.mApkDownloadHelper;
        if (dVar != null) {
            dVar.clear();
        }
        IAdLivePlayModule iAdLivePlayModule = this.dO;
        if (iAdLivePlayModule != null) {
            iAdLivePlayModule.release();
            this.dO = null;
        }
        IAdLiveOfflineView iAdLiveOfflineView = this.dP;
        if (iAdLiveOfflineView != null) {
            iAdLiveOfflineView.onDestroy();
            this.dP = null;
        }
        com.kwad.components.ad.draw.c.a aVar = this.dN;
        if (aVar != null) {
            aVar.release();
        }
    }

    public final void a(int i, Context context, final int i2, int i3) {
        com.kwad.components.core.e.d.a.C0428a c0428aAD = new com.kwad.components.core.e.d.a.C0428a(context).aF(this.mAdTemplate).b(this.mApkDownloadHelper).as(false).aD(i3);
        IAdLivePlayModule iAdLivePlayModule = this.dO;
        com.kwad.components.core.e.d.a.a(c0428aAD.A(iAdLivePlayModule == null ? 0L : iAdLivePlayModule.getPlayDuration()).aA(true).aC(i2).aB(i).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.draw.b.b.1
            @Override // com.kwad.components.core.e.d.a.b
            public final void onAdClicked() {
                try {
                    b.this.a(i2, null);
                } catch (Throwable th) {
                    ServiceProvider.reportSdkCaughtException(th);
                }
            }
        }));
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(int i, com.kwad.sdk.core.adlog.c.b bVar) {
        if (bVar == null) {
            bVar = new com.kwad.sdk.core.adlog.c.b();
        }
        bVar.dS(i);
        bVar.f(this.mRootContainer.getTouchCoords());
        c.a(this.mAdTemplate, bVar, (JSONObject) null);
        KsDrawAd.AdInteractionListener adInteractionListener = this.du;
        if (adInteractionListener != null) {
            adInteractionListener.onAdClicked();
        }
        if (this.dM) {
            return;
        }
        com.kwad.components.ad.draw.a.c.b(this.mAdTemplate, 1, com.kwad.sdk.core.response.helper.b.dA(this.mAdTemplate) ? 2 : 1);
        this.dM = true;
    }
}

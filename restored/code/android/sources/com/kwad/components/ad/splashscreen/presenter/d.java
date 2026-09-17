package com.kwad.components.ad.splashscreen.presenter;

import java.util.Iterator;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class d extends e {
    private List<Integer> cv;
    private final com.kwad.components.core.video.l mVideoPlayStateListener = new com.kwad.components.core.video.m() { // from class: com.kwad.components.ad.splashscreen.presenter.d.1
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayStart() {
            d.this.mA();
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, long j2) {
            d.this.c(j2);
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayCompleted() {
            d.this.mB();
        }
    };

    @Override // com.kwad.components.ad.splashscreen.presenter.e, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.cv = com.kwad.sdk.core.response.helper.a.bv(com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate));
        if (this.Hu.GF != null) {
            this.Hu.GF.b(this.mVideoPlayStateListener);
        }
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        if (this.Hu.GF != null) {
            this.Hu.GF.a(this.mVideoPlayStateListener);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void mA() {
        com.kwad.sdk.core.adlog.c.cp(this.Hu.mAdTemplate);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void mB() {
        com.kwad.sdk.core.adlog.c.cq(this.Hu.mAdTemplate);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void c(long j) {
        int iCeil = (int) Math.ceil(j / 1000.0f);
        List<Integer> list = this.cv;
        if (list == null || list.isEmpty()) {
            return;
        }
        Iterator<Integer> it = this.cv.iterator();
        while (it.hasNext()) {
            if (iCeil >= it.next().intValue()) {
                com.kwad.sdk.core.adlog.c.a(this.Hu.mAdTemplate, iCeil, (JSONObject) null);
                it.remove();
                return;
            }
        }
    }
}

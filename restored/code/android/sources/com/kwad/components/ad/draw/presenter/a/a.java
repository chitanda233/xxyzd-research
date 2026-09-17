package com.kwad.components.ad.draw.presenter.a;

import android.view.View;
import com.kwad.components.ad.draw.a.c;
import com.kwad.components.core.video.m;
import com.kwad.sdk.core.response.helper.b;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.view.AdBasePvFrameLayout;
import com.kwad.sdk.utils.o;
import com.kwad.sdk.widget.l;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends com.kwad.components.ad.draw.b.a {
    private List<Integer> cv;
    private AdInfo mAdInfo;
    private AdTemplate mAdTemplate;
    private boolean eP = false;
    private volatile boolean eQ = false;
    private l eR = new l() { // from class: com.kwad.components.ad.draw.presenter.a.a.1
        @Override // com.kwad.sdk.widget.l
        public final void aV() {
            o.fp(a.this.mAdTemplate);
        }
    };
    private com.kwad.components.core.video.l mVideoPlayStateListener = new m() { // from class: com.kwad.components.ad.draw.presenter.a.a.2
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayStart() {
            a.this.eQ = false;
            if (!a.this.mAdTemplate.mPvReported && a.this.dL.du != null) {
                a.this.dL.du.onAdShow();
                c.a(a.this.mAdTemplate, 1, b.dA(a.this.mAdTemplate) ? 2 : 1);
            }
            if (a.this.dL.du != null) {
                try {
                    a.this.dL.du.onVideoPlayStart();
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                }
                a.this.eP = false;
            }
            com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
            bVar.b(new com.kwad.sdk.core.adlog.a.C0502a());
            com.kwad.components.core.t.b.wR().a(a.this.mAdTemplate, null, bVar);
            com.kwad.sdk.core.adlog.c.cp(a.this.mAdTemplate);
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, long j2) {
            a.this.c(j2);
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayCompleted() {
            com.kwad.sdk.core.adlog.c.cq(a.this.mAdTemplate);
            if (a.this.dL.du != null) {
                try {
                    a.this.dL.du.onVideoPlayEnd();
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                }
            }
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlaying() {
            super.onMediaPlaying();
            if (a.this.eP) {
                a.this.eP = false;
                if (a.this.dL.du != null) {
                    try {
                        a.this.dL.du.onVideoPlayResume();
                        return;
                    } catch (Throwable th) {
                        com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                        return;
                    }
                }
                return;
            }
            if (a.this.eQ) {
                return;
            }
            a.this.eQ = true;
            com.kwad.components.core.p.a.vX().a(a.this.mAdTemplate, System.currentTimeMillis(), 1);
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayPaused() {
            super.onMediaPlayPaused();
            if (a.this.dL.du != null) {
                try {
                    a.this.dL.du.onVideoPlayPause();
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                }
            }
            a.this.eP = true;
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayError(int i, int i2) {
            super.onMediaPlayError(i, i2);
            if (a.this.dL.du != null) {
                try {
                    a.this.dL.du.onVideoPlayError();
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                }
            }
        }
    };

    @Override // com.kwad.components.ad.draw.b.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        AdTemplate adTemplate = this.dL.mAdTemplate;
        this.mAdTemplate = adTemplate;
        AdInfo adInfoEM = e.eM(adTemplate);
        this.mAdInfo = adInfoEM;
        this.cv = com.kwad.sdk.core.response.helper.a.bv(adInfoEM);
        this.dL.dN.b(this.mVideoPlayStateListener);
        a(this.eR);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.dL.dN.a(this.mVideoPlayStateListener);
        a((l) null);
    }

    private void a(l lVar) {
        View rootView = getRootView();
        if (rootView instanceof AdBasePvFrameLayout) {
            ((AdBasePvFrameLayout) rootView).setVisibleListener(lVar);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void c(long j) {
        int iCeil = (int) Math.ceil(j / 1000.0f);
        List<Integer> list = this.cv;
        if (list == null || list.isEmpty()) {
            return;
        }
        for (Integer num : this.cv) {
            if (iCeil >= num.intValue()) {
                com.kwad.sdk.core.adlog.c.a(this.mAdTemplate, iCeil, (JSONObject) null);
                this.cv.remove(num);
                return;
            }
        }
    }
}

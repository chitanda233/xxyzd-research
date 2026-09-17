package com.kwad.components.ad.nativead.b;

import android.view.View;
import com.kwad.components.core.video.m;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends com.kwad.components.ad.nativead.a.a {
    private List<Integer> cv;
    private volatile boolean eQ = false;

    @Override // com.kwad.components.ad.nativead.a.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.cv = com.kwad.sdk.core.response.helper.a.bv(com.kwad.sdk.core.response.helper.e.eM(this.pO.mAdTemplate));
        this.mVideoPlayStateListener = new m() { // from class: com.kwad.components.ad.nativead.b.c.1
            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayStart() {
                c.this.eQ = false;
                if (!c.this.pO.mAdTemplate.mPvReported) {
                    c.this.pO.pv.fw();
                }
                com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
                View view = (View) c.this.pO.pJ.getParent();
                if (view != null) {
                    bVar.z(view.getHeight(), view.getWidth());
                }
                com.kwad.components.core.t.b.wR().a(c.this.pO.mAdTemplate, null, bVar);
                com.kwad.sdk.core.adlog.c.cp(c.this.pO.mAdTemplate);
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlaying() {
                if (c.this.eQ) {
                    return;
                }
                c.this.eQ = true;
                com.kwad.components.core.p.a.vX().a(c.this.pO.mAdTemplate, System.currentTimeMillis(), 1);
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayProgress(long j, long j2) {
                c.this.c(j2);
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayCompleted() {
                com.kwad.sdk.core.adlog.c.cq(c.this.pO.mAdTemplate);
            }
        };
        this.pO.pP.b(this.mVideoPlayStateListener);
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
                com.kwad.sdk.core.adlog.c.a(this.pO.mAdTemplate, iCeil, (JSONObject) null);
                this.cv.remove(num);
                return;
            }
        }
    }
}

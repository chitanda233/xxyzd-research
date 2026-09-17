package com.kwad.components.ad.k;

import com.kwad.components.core.video.DetailVideoView;
import com.kwad.components.core.video.l;
import com.kwad.components.core.video.m;
import com.kwad.sdk.core.config.e;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public class b extends a<l> {
    public com.kwad.components.core.video.b Np;
    private boolean Nq;
    private l Nr;
    protected DetailVideoView mDetailVideoView;

    public b(AdTemplate adTemplate, DetailVideoView detailVideoView) {
        super(adTemplate);
        this.Nq = false;
        this.Nr = new m() { // from class: com.kwad.components.ad.k.b.1
            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayCompleted() {
                b.this.mAdTemplate.setmCurPlayTime(-1L);
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayProgress(long j, long j2) {
                b.this.mAdTemplate.setmCurPlayTime(j2);
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayError(int i, int i2) {
                try {
                    super.onMediaPlayError(i, i2);
                    if (!b.this.Nq) {
                        b.this.om();
                    } else if (e.KC()) {
                        b.this.om();
                    }
                } catch (Throwable th) {
                    ServiceProvider.reportSdkCaughtException(th);
                }
            }
        };
        this.mDetailVideoView = detailVideoView;
        this.Np = new com.kwad.components.core.video.b(this.mDetailVideoView, adTemplate);
        ok();
    }

    private void ok() {
        this.Np.c(this.Nr);
    }

    private void ol() {
        l lVar;
        com.kwad.components.core.video.b bVar = this.Np;
        if (bVar == null || (lVar = this.Nr) == null) {
            return;
        }
        bVar.d(lVar);
        this.Nr = null;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void om() {
        com.kwad.components.core.p.a.vX().i(this.mAdTemplate, 21008);
        this.Nq = true;
    }

    @Override // com.kwad.components.ad.k.a
    public long getPlayDuration() {
        com.kwad.components.core.video.b bVar = this.Np;
        if (bVar != null) {
            return bVar.getPlayDuration();
        }
        return 0L;
    }

    @Override // com.kwad.components.ad.k.a
    public void resume() {
        this.Np.resume();
    }

    @Override // com.kwad.components.ad.k.a
    public void pause() {
        this.Np.pause();
    }

    @Override // com.kwad.components.ad.k.a
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public final void b(l lVar) {
        com.kwad.components.core.video.b bVar;
        if (lVar == null || (bVar = this.Np) == null) {
            return;
        }
        bVar.c(lVar);
    }

    @Override // com.kwad.components.ad.k.a
    /* JADX INFO: renamed from: b, reason: merged with bridge method [inline-methods] */
    public final void a(l lVar) {
        if (lVar == null) {
            return;
        }
        this.Np.d(lVar);
    }

    @Override // com.kwad.components.ad.k.a
    public void release() {
        super.release();
        this.Nq = false;
        ol();
        com.kwad.components.core.video.b bVar = this.Np;
        if (bVar != null) {
            bVar.clear();
            this.Np.release();
        }
    }
}

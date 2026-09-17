package com.kwad.components.ad.draw.c;

import android.content.Context;
import com.kwad.components.ad.k.b;
import com.kwad.components.core.video.DetailVideoView;
import com.kwad.components.core.video.l;
import com.kwad.components.core.video.m;
import com.kwad.sdk.core.j.c;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.helper.h;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.o;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends b {
    private final c fA;
    private long fr;
    private com.kwad.components.core.widget.a.c fs;
    private com.kwad.sdk.contentalliance.a.a.a ft;
    private boolean fu;
    private boolean fv;
    private int fw;
    public boolean fx;
    public int fy;
    private boolean fz;
    private Context mContext;

    static /* synthetic */ boolean a(a aVar, boolean z) {
        aVar.fz = true;
        return true;
    }

    public a(AdTemplate adTemplate, com.kwad.components.core.widget.a.c cVar, DetailVideoView detailVideoView) {
        super(adTemplate, detailVideoView);
        this.fv = false;
        this.fw = -1;
        this.fx = true;
        this.fy = 0;
        this.fA = new c() { // from class: com.kwad.components.ad.draw.c.a.3
            @Override // com.kwad.sdk.core.j.c
            public final void bv() {
                if (a.this.ft == null) {
                    a aVar = a.this;
                    aVar.ft = com.kwad.sdk.contentalliance.a.a.a.ci(aVar.mAdTemplate);
                    a.this.Np.a(a.this.ft);
                }
                if (a.this.fz || a.this.fu || !a.this.br()) {
                    return;
                }
                a.this.resume();
            }

            @Override // com.kwad.sdk.core.j.c
            public final void bw() {
                a.this.pause();
            }
        };
        this.fr = com.kwad.sdk.core.response.helper.a.ae(e.eM(this.mAdTemplate));
        this.fs = cVar;
        this.mContext = detailVideoView.getContext();
        bu();
        if (com.kwad.sdk.core.response.helper.a.ci(e.eM(this.mAdTemplate))) {
            this.Np.setVolume(0.0f, 0.0f);
            this.fv = true;
        }
        this.Np.a(new com.kwad.sdk.core.video.a.c.e() { // from class: com.kwad.components.ad.draw.c.a.1
            @Override // com.kwad.sdk.core.video.a.c.e
            public final void a(com.kwad.sdk.core.video.a.c cVar2) {
                try {
                    a.this.start(o.fq(a.this.mAdTemplate));
                } catch (Throwable th) {
                    ServiceProvider.reportSdkCaughtException(th);
                }
            }
        });
    }

    public final void bq() {
        long jFq = o.fq(this.mAdTemplate);
        if (this.Np.xy() == null) {
            bu();
        }
        start(jFq);
        this.fs.a(this.fA);
        b((l) new m() { // from class: com.kwad.components.ad.draw.c.a.2
            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayCompleted() {
                a.a(a.this, true);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void start(long j) {
        if (this.fs.ah() && br() && !this.fz) {
            this.Np.a(new com.kwad.sdk.contentalliance.a.a.a(this.mAdTemplate, j));
            this.Np.start();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean br() {
        int i = this.fy;
        if (i == 1) {
            return true;
        }
        if (i != 2) {
            return this.fx;
        }
        return false;
    }

    public final void setVideoSound(boolean z) {
        if (this.Np == null) {
            return;
        }
        if (z) {
            this.Np.setVolume(1.0f, 1.0f);
            this.fv = false;
        } else {
            this.Np.setVolume(0.0f, 0.0f);
            this.fv = true;
        }
        this.fw = 1;
    }

    public final void bs() {
        this.ft = null;
        this.fs.b(this.fA);
        this.Np.release();
    }

    public final void g(boolean z) {
        this.fu = z;
    }

    public final boolean bt() {
        return this.fz;
    }

    private void bu() {
        this.Np.a(new com.kwad.sdk.contentalliance.a.a.b.a(this.mAdTemplate).dO(e.eO(this.mAdTemplate)).dP(h.b(e.eN(this.mAdTemplate))).a(this.mAdTemplate.mVideoPlayerStatus).b(new com.kwad.sdk.contentalliance.a.a.a(this.mAdTemplate, System.currentTimeMillis())).IS(), this.mDetailVideoView);
        this.Np.prepareAsync();
        if (this.fw != -1 || this.fv) {
            setVideoSound(!this.fv);
        }
    }

    @Override // com.kwad.components.ad.k.b, com.kwad.components.ad.k.a
    public final void resume() {
        super.resume();
        com.kwad.components.core.t.a.aN(this.mContext).bd(false);
    }
}

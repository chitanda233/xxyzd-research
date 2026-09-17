package com.kwad.components.ad.reward.presenter.f;

import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.x;
import com.kwad.components.core.webview.tachikoma.b.o;
import com.kwad.components.core.webview.tachikoma.c.y;
import com.kwad.sdk.components.t;

/* JADX INFO: loaded from: classes3.dex */
public abstract class a extends d {
    private o Ar;

    @Override // com.kwad.components.ad.reward.presenter.f.d
    protected final boolean kg() {
        return true;
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(o oVar) {
        this.Ar = oVar;
        oVar.a(new o.a() { // from class: com.kwad.components.ad.reward.presenter.f.a.1
            @Override // com.kwad.components.core.webview.tachikoma.b.o.a
            public final boolean isMuted() {
                return !a.this.ub.mVideoPlayConfig.isVideoSoundEnable() || (!com.kwad.sdk.core.config.e.hM() && com.kwad.components.core.t.a.aN(a.this.getContext()).wP());
            }
        });
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public void a(t tVar, com.kwad.sdk.core.webview.b bVar) {
        super.a(tVar, bVar);
        tVar.c(new x() { // from class: com.kwad.components.ad.reward.presenter.f.a.2
            @Override // com.kwad.components.core.webview.jshandler.x
            public final void b(y yVar) {
                super.b(yVar);
                a.this.ub.sq.onVideoPlayStart();
                com.kwad.components.ad.reward.monitor.d.b(a.this.ub.sG, a.this.ub.mAdTemplate, a.this.ub.mPageEnterTime);
            }

            @Override // com.kwad.components.core.webview.jshandler.x
            public final void c(y yVar) {
                super.c(yVar);
                a.this.ub.sq.onVideoPlayEnd();
                a.this.ub.mAdTemplate.setmCurPlayTime(-1L);
                com.kwad.components.ad.reward.presenter.f.u(a.this.ub);
                if (yVar.zE()) {
                    com.kwad.components.ad.reward.g unused = a.this.ub;
                    com.kwad.components.ad.reward.g.a(a.this.ub.sy, new com.kwad.sdk.g.a<com.kwad.components.ad.reward.k.a>() { // from class: com.kwad.components.ad.reward.presenter.f.a.2.1
                        /* JADX INFO: Access modifiers changed from: private */
                        @Override // com.kwad.sdk.g.a
                        /* JADX INFO: renamed from: c, reason: merged with bridge method [inline-methods] */
                        public void accept(com.kwad.components.ad.reward.k.a aVar) {
                            com.kwad.components.ad.reward.g unused2 = a.this.ub;
                            aVar.ke();
                        }
                    });
                }
            }

            @Override // com.kwad.components.core.webview.jshandler.x
            public final void d(y yVar) {
                super.d(yVar);
                a.this.ub.mAdTemplate.setmCurPlayTime(yVar.ri);
            }

            @Override // com.kwad.components.core.webview.jshandler.x
            public final void a(y yVar) {
                super.a(yVar);
                long jZI = yVar.zI();
                a.this.ub.sq.onVideoPlayError(yVar.errorCode, (int) jZI);
                com.kwad.components.ad.reward.monitor.d.a(a.this.ub.sG, a.this.ub.mAdTemplate, a.this.ub.tf, yVar.errorCode, jZI);
                com.kwad.components.ad.reward.monitor.c.c(a.this.ub.sG, a.this.mAdTemplate);
            }
        });
    }

    public void a(ae.a aVar) {
        float fBA = com.kwad.sdk.c.a.a.bA(getContext());
        float screenHeight = com.kwad.sdk.c.a.a.getScreenHeight(getContext());
        aVar.width = (int) ((com.kwad.sdk.c.a.a.getScreenWidth(getContext()) / fBA) + 0.5f);
        aVar.height = (int) ((screenHeight / fBA) + 0.5f);
    }
}

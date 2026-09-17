package com.kwad.components.ad.nativead.d;

import android.content.Context;
import android.view.View;
import com.kwad.components.ad.k.b;
import com.kwad.components.ad.nativead.g;
import com.kwad.components.core.internal.api.KSAdVideoPlayConfigImpl;
import com.kwad.components.core.video.DetailVideoView;
import com.kwad.components.core.video.m;
import com.kwad.components.offline.api.core.api.OfflineOnAudioConflictListener;
import com.kwad.sdk.api.KsAdVideoPlayConfig;
import com.kwad.sdk.core.j.c;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.helper.h;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.aq;
import com.kwad.sdk.utils.o;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends b {
    private boolean cA;
    private OfflineOnAudioConflictListener cM;
    private KsAdVideoPlayConfig ce;
    private final c fA;
    private com.kwad.components.core.l.a.b fP;
    private com.kwad.components.core.widget.a.c fs;
    private boolean hasNoCache;
    private final AdInfo mAdInfo;
    private Context mContext;
    private boolean qG;
    private boolean qH;
    private m qI;
    private int qJ;
    private long qK;

    static /* synthetic */ int a(a aVar, int i) {
        aVar.qJ = 3;
        return 3;
    }

    static /* synthetic */ boolean c(a aVar, boolean z) {
        aVar.cA = false;
        return false;
    }

    public a(final AdTemplate adTemplate, com.kwad.components.core.widget.a.c cVar, DetailVideoView detailVideoView, KsAdVideoPlayConfig ksAdVideoPlayConfig) {
        super(adTemplate, detailVideoView);
        this.hasNoCache = false;
        this.fA = new c() { // from class: com.kwad.components.ad.nativead.d.a.4
            @Override // com.kwad.sdk.core.j.c
            public final void bv() {
                com.kwad.components.core.l.a.ty().a(a.this.getCurrentVoiceItem());
                a.this.fT();
            }

            @Override // com.kwad.sdk.core.j.c
            public final void bw() {
                com.kwad.components.core.l.a.ty().c(a.this.fP);
                a.this.pause();
            }
        };
        this.cM = new OfflineOnAudioConflictListener() { // from class: com.kwad.components.ad.nativead.d.a.6
            @Override // com.kwad.components.offline.api.core.api.OfflineOnAudioConflictListener
            public final void onAudioBeReleased() {
            }

            @Override // com.kwad.components.offline.api.core.api.OfflineOnAudioConflictListener
            public final void onAudioBeOccupied() {
                a.c(a.this, false);
                a.this.setAudioEnabled(false);
            }
        };
        if (cVar == null) {
            View view = (View) detailVideoView.getParent();
            cVar = new g(view == null ? detailVideoView : view);
        }
        this.fs = cVar;
        AdInfo adInfoEM = e.eM(this.mAdTemplate);
        this.mAdInfo = adInfoEM;
        if ((ksAdVideoPlayConfig instanceof KSAdVideoPlayConfigImpl) && ((KSAdVideoPlayConfigImpl) ksAdVideoPlayConfig).getVideoSoundValue() != 0) {
            this.qG = ksAdVideoPlayConfig.isVideoSoundEnable();
        } else {
            this.qG = com.kwad.sdk.core.response.helper.a.ch(adInfoEM);
        }
        this.ce = ksAdVideoPlayConfig;
        this.mContext = detailVideoView.getContext();
        if (ksAdVideoPlayConfig != null) {
            try {
                this.hasNoCache = ksAdVideoPlayConfig.isNoCache();
            } catch (Throwable th) {
                com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            }
        }
        this.qI = new m() { // from class: com.kwad.components.ad.nativead.d.a.1
            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayError(int i, int i2) {
                super.onMediaPlayError(i, i2);
                com.kwad.components.core.p.a.vX().g(adTemplate, i, i2);
            }
        };
        this.Np.c(this.qI);
        bu();
        this.Np.a(new com.kwad.sdk.core.video.a.c.e() { // from class: com.kwad.components.ad.nativead.d.a.2
            @Override // com.kwad.sdk.core.video.a.c.e
            public final void a(com.kwad.sdk.core.video.a.c cVar2) {
                try {
                    if (a.this.fU() && a.this.fs.ah() && a.this.fS()) {
                        a.this.Np.a(com.kwad.sdk.contentalliance.a.a.a.ci(a.this.mAdTemplate));
                        com.kwad.components.core.l.a.ty().a(a.this.getCurrentVoiceItem());
                        a.this.Np.start(a.this.qK);
                    }
                } catch (Throwable th2) {
                    ServiceProvider.reportSdkCaughtException(th2);
                }
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean fS() {
        int i = this.qJ;
        return (i == 3 || i == 2) ? false : true;
    }

    public final void bq() {
        o.fp(this.mAdTemplate);
        if (this.Np.xy() == null) {
            bu();
        }
        if (fU() && this.fs.ah()) {
            this.Np.a(com.kwad.sdk.contentalliance.a.a.a.ci(this.mAdTemplate));
            com.kwad.components.core.l.a.ty().a(getCurrentVoiceItem());
            this.Np.start(this.qK);
        }
        this.Np.c(new m() { // from class: com.kwad.components.ad.nativead.d.a.3
            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayProgress(long j, long j2) {
                if (j != 0) {
                    a.this.qK = j2;
                }
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayCompleted() {
                super.onMediaPlayCompleted();
                a.this.qK = 0L;
                a.a(a.this, 3);
            }
        });
        this.fs.a(this.fA);
    }

    public final void bs() {
        o.fn(this.mAdTemplate);
        this.fs.b(this.fA);
        this.Np.release();
        com.kwad.components.core.l.a.ty().c(this.fP);
        com.kwad.components.core.t.a.aN(this.mContext).b(this.cM);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void fT() {
        int i = this.qJ;
        if (i == 1) {
            start();
            return;
        }
        if (i == 2) {
            pause();
        } else if (i == 3) {
            stop();
        } else {
            resume();
        }
    }

    private void start() {
        if (this.qH) {
            resume();
        } else {
            fV();
        }
    }

    private void stop() {
        this.Np.complete();
    }

    private void bu() {
        this.Np.a(new com.kwad.sdk.contentalliance.a.a.b.a(this.mAdTemplate).dO(e.eO(this.mAdTemplate)).dP(h.b(e.eN(this.mAdTemplate))).a(this.mAdTemplate.mVideoPlayerStatus).bD(this.hasNoCache).b(com.kwad.sdk.contentalliance.a.a.a.ci(this.mAdTemplate)).IS(), true, true, this.mDetailVideoView);
        setAudioEnabled(h(this.qG));
        if (fU()) {
            this.Np.prepareAsync();
            com.kwad.components.core.t.a.aN(this.mContext).a(this.cM);
        }
    }

    @Override // com.kwad.components.ad.k.b, com.kwad.components.ad.k.a
    public final void resume() {
        com.kwad.components.core.l.a.ty().a(getCurrentVoiceItem());
        setAudioEnabled(h(this.qG));
        if (fU()) {
            this.Np.start(this.qK);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean h(boolean z) {
        if (!z) {
            return false;
        }
        if (this.fP != null) {
            com.kwad.components.core.l.a.ty();
            if (!com.kwad.components.core.l.a.b(this.fP)) {
                return false;
            }
        }
        if (!com.kwad.sdk.core.config.e.hM()) {
            if (com.kwad.components.core.t.a.aN(this.mContext).wQ()) {
                return !com.kwad.components.core.t.a.aN(this.mContext).wP();
            }
            return com.kwad.components.core.t.a.aN(this.mContext).bd(false);
        }
        if (!this.cA) {
            this.cA = com.kwad.components.core.t.a.aN(this.mContext).bd(true);
        }
        return this.cA;
    }

    public final void V(int i) {
        this.qJ = i;
        if (this.fs.ah()) {
            fT();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void setAudioEnabled(boolean z) {
        this.Np.setAudioEnabled(z);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean fU() {
        if (this.qH) {
            return true;
        }
        KsAdVideoPlayConfig ksAdVideoPlayConfig = this.ce;
        if (ksAdVideoPlayConfig instanceof KSAdVideoPlayConfigImpl) {
            KSAdVideoPlayConfigImpl kSAdVideoPlayConfigImpl = (KSAdVideoPlayConfigImpl) ksAdVideoPlayConfig;
            if (kSAdVideoPlayConfigImpl.getVideoAutoPlayType() == 1) {
                return aq.isNetworkConnected(this.mContext);
            }
            if (kSAdVideoPlayConfigImpl.getVideoAutoPlayType() == 2) {
                return aq.isWifiConnected(this.mContext);
            }
            if (kSAdVideoPlayConfigImpl.getVideoAutoPlayType() == 3) {
                return false;
            }
            if (kSAdVideoPlayConfigImpl.getDataFlowAutoStartValue() != 0) {
                return aq.isWifiConnected(this.mContext) || (kSAdVideoPlayConfigImpl.isDataFlowAutoStart() && aq.isMobileConnected(this.mContext));
            }
        }
        if (com.kwad.sdk.core.response.helper.a.cj(this.mAdInfo) && aq.isNetworkConnected(this.mContext)) {
            return true;
        }
        return com.kwad.sdk.core.response.helper.a.ck(this.mAdInfo) && aq.isWifiConnected(this.mContext);
    }

    public final void fV() {
        this.qH = true;
        this.mAdInfo.isAllowVideoAutoPlay = true;
        if (this.fs.ah()) {
            o.fo(this.mAdTemplate);
            this.Np.a(com.kwad.sdk.contentalliance.a.a.a.ci(this.mAdTemplate));
            com.kwad.components.core.l.a.ty().a(getCurrentVoiceItem());
            this.Np.start(this.qK);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public com.kwad.components.core.l.a.b getCurrentVoiceItem() {
        if (this.fP == null) {
            this.fP = new com.kwad.components.core.l.a.b(new com.kwad.components.core.l.a.c() { // from class: com.kwad.components.ad.nativead.d.a.5
                @Override // com.kwad.components.core.l.a.c
                public final void bH() {
                    a aVar = a.this;
                    aVar.setAudioEnabled(aVar.h(aVar.qG));
                }
            });
        }
        return this.fP;
    }
}

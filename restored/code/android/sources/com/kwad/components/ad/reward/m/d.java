package com.kwad.components.ad.reward.m;

import android.content.Context;
import com.kwad.components.ad.reward.g;
import com.kwad.components.core.video.DetailVideoView;
import com.kwad.components.core.video.k;
import com.kwad.components.core.video.m;
import com.kwad.components.offline.api.core.api.OfflineOnAudioConflictListener;
import com.kwad.sdk.api.KsVideoPlayConfig;
import com.kwad.sdk.core.response.helper.h;
import com.kwad.sdk.core.response.model.VideoPlayerStatus;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.j;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
public final class d extends com.kwad.components.ad.k.b implements g.a {
    private String Cu;
    private AtomicBoolean Cv;
    private boolean Cw;
    private final List<j.a> Cx;
    private final List<Object> Cy;
    private OfflineOnAudioConflictListener Cz;
    private Context mContext;
    private KsVideoPlayConfig mVideoPlayConfig;
    private VideoPlayerStatus mVideoPlayerStatus;
    private boolean nC;
    private boolean qG;
    private m qI;
    private g ub;

    static /* synthetic */ boolean a(d dVar, boolean z) {
        dVar.Cw = true;
        return true;
    }

    public d(g gVar, DetailVideoView detailVideoView) {
        super(gVar.mAdTemplate, detailVideoView);
        this.Cv = new AtomicBoolean(false);
        this.Cw = false;
        this.nC = false;
        this.Cx = new ArrayList();
        this.Cy = new ArrayList();
        this.Cz = new OfflineOnAudioConflictListener() { // from class: com.kwad.components.ad.reward.m.d.1
            @Override // com.kwad.components.offline.api.core.api.OfflineOnAudioConflictListener
            public final void onAudioBeOccupied() {
                d.a(d.this, true);
                if (d.this.Np != null) {
                    d.this.Np.setAudioEnabled(false);
                }
                synchronized (d.this.Cx) {
                    Iterator it = d.this.Cx.iterator();
                    while (it.hasNext()) {
                        ((j.a) it.next()).onAudioBeOccupied();
                    }
                }
            }

            @Override // com.kwad.components.offline.api.core.api.OfflineOnAudioConflictListener
            public final void onAudioBeReleased() {
                synchronized (d.this.Cx) {
                    Iterator it = d.this.Cx.iterator();
                    while (it.hasNext()) {
                        ((j.a) it.next()).onAudioBeReleased();
                    }
                }
            }
        };
        this.ub = gVar;
        this.mContext = gVar.mContext;
        this.mVideoPlayConfig = gVar.mVideoPlayConfig;
        this.mVideoPlayerStatus = this.mAdTemplate.mVideoPlayerStatus;
        this.Cu = getVideoUrl();
    }

    private String getVideoUrl() {
        return lo() ? "" : k.j(this.mContext, this.mAdTemplate);
    }

    public final void lm() {
        if (this.Cv.get()) {
            return;
        }
        this.Cv.set(true);
        bu();
        this.qI = new m() { // from class: com.kwad.components.ad.reward.m.d.2
            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayError(int i, int i2) {
                super.onMediaPlayError(i, i2);
                com.kwad.components.core.p.a.vX().g(d.this.mAdTemplate, i, i2);
            }
        };
        this.Np.c(this.qI);
        this.Np.a(new com.kwad.sdk.core.video.a.c.e() { // from class: com.kwad.components.ad.reward.m.d.3
            @Override // com.kwad.sdk.core.video.a.c.e
            public final void a(com.kwad.sdk.core.video.a.c cVar) {
                try {
                    com.kwad.sdk.core.c.b.Mh();
                    if (com.kwad.sdk.core.c.b.isAppOnForeground()) {
                        d.this.Np.start();
                    }
                } catch (Throwable th) {
                    ServiceProvider.reportSdkCaughtException(th);
                }
            }
        });
        this.Np.start();
        com.kwad.components.core.t.a.aN(this.mContext).a(this.Cz);
    }

    private void bu() {
        if (lo()) {
            return;
        }
        this.Np.a(new com.kwad.sdk.contentalliance.a.a.b.a(this.mAdTemplate).dO(this.Cu).dP(h.b(com.kwad.sdk.core.response.helper.e.eN(this.mAdTemplate))).a(this.mVideoPlayerStatus).b(com.kwad.sdk.contentalliance.a.a.a.ci(this.mAdTemplate)).IS(), this.mDetailVideoView);
        KsVideoPlayConfig ksVideoPlayConfig = this.mVideoPlayConfig;
        if (ksVideoPlayConfig != null) {
            setAudioEnabled(ksVideoPlayConfig.isVideoSoundEnable(), false);
        }
        this.Np.prepareAsync();
    }

    @Override // com.kwad.components.ad.k.b, com.kwad.components.ad.k.a
    public final void resume() {
        this.nC = false;
        if (!this.Cv.get() || this.Np == null || lo() || g.b(this.ub)) {
            return;
        }
        super.resume();
    }

    @Override // com.kwad.components.ad.k.b, com.kwad.components.ad.k.a
    public final void pause() {
        if (!this.Cv.get() || this.Np == null || lo()) {
            return;
        }
        super.pause();
    }

    private void stop() {
        pause();
        this.nC = true;
    }

    @Override // com.kwad.components.ad.k.a
    @Deprecated
    public final void skipToEnd() {
        if (!this.Cv.get() || this.Np == null) {
            return;
        }
        this.Np.onPlayStateChanged(9);
        stop();
    }

    @Override // com.kwad.components.ad.k.b, com.kwad.components.ad.k.a
    public final void release() {
        super.release();
        com.kwad.components.core.t.a.aN(this.mContext).b(this.Cz);
    }

    @Override // com.kwad.components.ad.k.b, com.kwad.components.ad.k.a
    public final long getPlayDuration() {
        if (this.Cv.get()) {
            return super.getPlayDuration();
        }
        return 0L;
    }

    @Override // com.kwad.components.ad.k.a
    public final void setAudioEnabled(boolean z, boolean z2) {
        this.qG = z;
        if (!this.Cv.get() || this.Np == null) {
            return;
        }
        if (z && z2) {
            com.kwad.components.core.t.a.aN(this.mContext).bd(true);
        }
        this.Np.setAudioEnabled(z);
    }

    public final void a(j.a aVar) {
        this.Cx.add(aVar);
    }

    public final void b(j.a aVar) {
        this.Cx.remove(aVar);
    }

    public final void ln() {
        Iterator<Object> it = this.Cy.iterator();
        while (it.hasNext()) {
            it.next();
        }
    }

    @Override // com.kwad.components.ad.reward.g.a
    public final void hn() {
        this.Cw = false;
    }

    @Override // com.kwad.components.ad.reward.g.a
    public final void ho() {
        if (this.nC) {
            return;
        }
        resume();
        if (this.qG || (com.kwad.components.ad.reward.a.b.hM() && this.Cw)) {
            com.kwad.components.core.t.a.aN(this.mContext).bd(com.kwad.components.ad.reward.a.b.hM());
            if (com.kwad.components.ad.reward.a.b.hM() && this.Cw) {
                this.Cw = false;
                this.qG = true;
                setAudioEnabled(true, false);
            } else {
                if (this.ub.sp || !com.kwad.components.core.t.a.aN(this.mContext).wP()) {
                    return;
                }
                this.qG = false;
                setAudioEnabled(false, false);
            }
        }
    }

    @Override // com.kwad.components.ad.reward.g.a
    public final void hp() {
        pause();
    }

    @Override // com.kwad.components.ad.reward.g.a
    public final void hq() {
        this.Cw = false;
        if (!this.Cv.get() || this.Np == null) {
            return;
        }
        this.Np.d(this.qI);
        this.Np.release();
    }

    private boolean lo() {
        return com.kwad.sdk.core.response.helper.a.cY(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate));
    }
}

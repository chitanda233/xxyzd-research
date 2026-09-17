package com.kwad.components.ad.splashscreen.d;

import android.content.Context;
import android.os.SystemClock;
import com.kwad.components.ad.k.b;
import com.kwad.components.ad.splashscreen.h;
import com.kwad.components.core.video.DetailVideoView;
import com.kwad.components.offline.api.core.api.OfflineOnAudioConflictListener;
import com.kwad.sdk.api.KsVideoPlayConfig;
import com.kwad.sdk.core.j.c;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.response.model.VideoPlayerStatus;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.cb;
import com.kwad.sdk.utils.j;
import java.io.File;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends b implements c {
    private String Cu;
    private final List<j.a> Cx;
    private OfflineOnAudioConflictListener Cz;
    public int HA;
    private boolean KF;
    public long KG;
    private Context mContext;
    private KsVideoPlayConfig mVideoPlayConfig;
    private VideoPlayerStatus mVideoPlayerStatus;
    private boolean qG;

    public a(AdTemplate adTemplate, final DetailVideoView detailVideoView, KsVideoPlayConfig ksVideoPlayConfig) {
        super(adTemplate, detailVideoView);
        this.Cx = new ArrayList();
        this.Cz = new OfflineOnAudioConflictListener() { // from class: com.kwad.components.ad.splashscreen.d.a.1
            @Override // com.kwad.components.offline.api.core.api.OfflineOnAudioConflictListener
            public final void onAudioBeOccupied() {
                synchronized (a.this.Cx) {
                    Iterator it = a.this.Cx.iterator();
                    while (it.hasNext()) {
                        ((j.a) it.next()).onAudioBeOccupied();
                    }
                }
            }

            @Override // com.kwad.components.offline.api.core.api.OfflineOnAudioConflictListener
            public final void onAudioBeReleased() {
                synchronized (a.this.Cx) {
                    Iterator it = a.this.Cx.iterator();
                    while (it.hasNext()) {
                        ((j.a) it.next()).onAudioBeReleased();
                    }
                }
            }
        };
        this.mVideoPlayConfig = ksVideoPlayConfig;
        this.mContext = detailVideoView.getContext();
        String strBf = com.kwad.sdk.core.response.helper.a.bf(e.eM(adTemplate));
        this.mVideoPlayerStatus = adTemplate.mVideoPlayerStatus;
        e.eM(adTemplate);
        this.HA = h.af(adTemplate) ? 2 : 1;
        File fileCM = com.kwad.sdk.core.diskcache.b.a.LI().cM(strBf);
        if (fileCM != null && fileCM.exists()) {
            this.Cu = fileCM.getAbsolutePath();
        }
        this.Np.a(new com.kwad.sdk.core.video.a.c.e() { // from class: com.kwad.components.ad.splashscreen.d.a.2
            @Override // com.kwad.sdk.core.video.a.c.e
            public final void a(com.kwad.sdk.core.video.a.c cVar) {
                com.kwad.sdk.core.d.c.d("SplashPlayModule", " onPrepared");
                detailVideoView.post(new bi() { // from class: com.kwad.components.ad.splashscreen.d.a.2.1
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        long jElapsedRealtime = SystemClock.elapsedRealtime();
                        com.kwad.components.ad.splashscreen.monitor.b.mt();
                        com.kwad.components.ad.splashscreen.monitor.b.a(a.this.mAdTemplate, 1, a.this.HA, 2, jElapsedRealtime - a.this.KG, jElapsedRealtime - a.this.mAdTemplate.showTime);
                        boolean zA = cb.a(detailVideoView, 50, true);
                        com.kwad.sdk.core.d.c.d("SplashPlayModule", " onPrepared" + zA);
                        if (zA) {
                            a.this.Np.start();
                        }
                    }
                });
            }
        });
        com.kwad.components.core.t.a.aN(this.mContext).a(this.Cz);
    }

    public final long getCurrentPosition() {
        return this.Np.getCurrentPosition();
    }

    private void bu() {
        com.kwad.sdk.contentalliance.a.a.b bVarIS = new com.kwad.sdk.contentalliance.a.a.b.a(this.mAdTemplate).a(this.mVideoPlayerStatus).dO(this.Cu).dP(com.kwad.sdk.core.response.helper.h.b(e.eN(this.mAdTemplate))).b(com.kwad.sdk.contentalliance.a.a.a.ci(this.mAdTemplate)).IS();
        this.KG = SystemClock.elapsedRealtime();
        com.kwad.components.ad.splashscreen.monitor.b.mt();
        com.kwad.components.ad.splashscreen.monitor.b.e(this.mAdTemplate, 1, this.HA);
        this.Np.a(bVarIS, this.mDetailVideoView);
        KsVideoPlayConfig ksVideoPlayConfig = this.mVideoPlayConfig;
        if (ksVideoPlayConfig != null) {
            setAudioEnabled(ksVideoPlayConfig.isVideoSoundEnable(), false);
        }
        this.Np.prepareAsync();
    }

    @Override // com.kwad.components.ad.k.b, com.kwad.components.ad.k.a
    public final void resume() {
        super.resume();
        if (this.qG && this.KF) {
            com.kwad.components.core.t.a.aN(this.mContext).bd(false);
            if (com.kwad.components.core.t.a.aN(this.mContext).wP()) {
                this.qG = false;
                setAudioEnabled(false, false);
            }
        }
    }

    @Override // com.kwad.components.ad.k.b, com.kwad.components.ad.k.a
    public final void release() {
        super.release();
        com.kwad.components.core.t.a.aN(this.mContext).b(this.Cz);
    }

    public final void ah(boolean z) {
        this.KF = true;
    }

    public final void nN() {
        if (this.Np.xy() == null) {
            bu();
        }
        this.Np.start();
    }

    @Override // com.kwad.components.ad.k.a
    public final void setAudioEnabled(boolean z, boolean z2) {
        this.qG = z;
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

    @Override // com.kwad.sdk.core.j.c
    public final void bv() {
        resume();
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bw() {
        pause();
    }
}

package com.kwad.components.core.page.e;

import android.content.Context;
import com.kwad.components.core.proxy.f;
import com.kwad.components.core.video.DetailVideoView;
import com.kwad.components.core.video.b;
import com.kwad.components.core.video.k;
import com.kwad.components.core.video.l;
import com.kwad.components.core.video.m;
import com.kwad.components.offline.api.core.api.OfflineOnAudioConflictListener;
import com.kwad.sdk.api.KsVideoPlayConfig;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.helper.h;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.response.model.VideoPlayerStatus;
import com.kwad.sdk.core.video.a.c;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.j;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class a implements com.kwad.components.core.n.a.a {
    private String Cu;
    private boolean Cw = false;
    private final List<j.a> Cx = new ArrayList();
    private OfflineOnAudioConflictListener Cz = new OfflineOnAudioConflictListener() { // from class: com.kwad.components.core.page.e.a.1
        @Override // com.kwad.components.offline.api.core.api.OfflineOnAudioConflictListener
        public final void onAudioBeOccupied() {
            a.a(a.this, true);
            if (a.this.Np != null) {
                a.this.Np.setAudioEnabled(false);
            }
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
    private b Np;
    private AdTemplate mAdTemplate;
    private Context mContext;
    private DetailVideoView mDetailVideoView;
    private KsVideoPlayConfig mVideoPlayConfig;
    private VideoPlayerStatus mVideoPlayerStatus;
    private boolean qG;
    private m qI;

    static /* synthetic */ boolean a(a aVar, boolean z) {
        aVar.Cw = true;
        return true;
    }

    public a(final AdTemplate adTemplate, DetailVideoView detailVideoView, KsVideoPlayConfig ksVideoPlayConfig) {
        this.mVideoPlayConfig = ksVideoPlayConfig;
        this.mAdTemplate = adTemplate;
        this.mContext = detailVideoView.getContext();
        this.mVideoPlayerStatus = adTemplate.mVideoPlayerStatus;
        this.Cu = k.j(this.mContext, adTemplate);
        this.mDetailVideoView = detailVideoView;
        this.Np = new b(detailVideoView, adTemplate);
        bu();
        m mVar = new m() { // from class: com.kwad.components.core.page.e.a.2
            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayError(int i, int i2) {
                super.onMediaPlayError(i, i2);
                com.kwad.components.core.p.a.vX().g(adTemplate, i, i2);
            }
        };
        this.qI = mVar;
        this.Np.c(mVar);
        this.Np.a(new c.e() { // from class: com.kwad.components.core.page.e.a.3
            @Override // com.kwad.sdk.core.video.a.c.e
            public final void a(c cVar) {
                try {
                    a.this.Np.start();
                } catch (Throwable th) {
                    ServiceProvider.reportSdkCaughtException(th);
                }
            }
        });
        com.kwad.components.core.t.a.aN(this.mContext).a(this.Cz);
    }

    private void bu() {
        this.Np.a(new com.kwad.sdk.contentalliance.a.a.b.a(this.mAdTemplate).dO(this.Cu).dP(h.b(e.eN(this.mAdTemplate))).a(this.mVideoPlayerStatus).b(com.kwad.sdk.contentalliance.a.a.a.ci(this.mAdTemplate)).IS(), this.mDetailVideoView);
        KsVideoPlayConfig ksVideoPlayConfig = this.mVideoPlayConfig;
        if (ksVideoPlayConfig != null) {
            setAudioEnabled(ksVideoPlayConfig.isVideoSoundEnable(), false);
        }
        this.Np.prepareAsync();
    }

    private void resume() {
        this.Np.resume();
    }

    private void pause() {
        if (this.mAdTemplate.mXiaomiAppStoreDetailViewOpen && this.mAdTemplate.mAdScene != null && this.mAdTemplate.mAdScene.getAdStyle() == 2) {
            return;
        }
        this.Np.pause();
    }

    public final void a(l lVar) {
        if (lVar == null) {
            return;
        }
        this.Np.c(lVar);
    }

    public final void b(l lVar) {
        if (lVar == null) {
            return;
        }
        this.Np.d(lVar);
    }

    public final void release() {
        b bVar = this.Np;
        if (bVar != null) {
            bVar.clear();
            this.Np.release();
        }
        com.kwad.components.core.t.a.aN(this.mContext).b(this.Cz);
    }

    @Override // com.kwad.components.core.n.a.a
    public final void hi() {
        this.Cw = false;
        if (this.Np.xy() == null) {
            bu();
        }
    }

    @Override // com.kwad.components.core.n.a.a
    public final void c(f fVar) {
        resume();
    }

    @Override // com.kwad.components.core.n.a.a
    public final void d(f fVar) {
        pause();
    }

    @Override // com.kwad.components.core.n.a.a
    public final void hj() {
        this.Cw = false;
        b bVar = this.Np;
        if (bVar != null) {
            bVar.d(this.qI);
            this.Np.release();
        }
    }

    private void setAudioEnabled(boolean z, boolean z2) {
        this.qG = z;
        this.Np.setAudioEnabled(z);
    }
}

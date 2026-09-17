package com.kwad.components.ad.reward.presenter.c;

import android.os.Handler;
import android.os.Looper;
import android.os.SystemClock;
import com.kwad.components.ad.reward.model.EcOrderCardStyle;
import com.kwad.components.ad.reward.monitor.c;
import com.kwad.components.ad.reward.monitor.d;
import com.kwad.components.ad.reward.presenter.b;
import com.kwad.components.core.video.j;
import com.kwad.components.core.video.m;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends b {
    private List<Integer> cv;
    private AdInfo mAdInfo;
    private m wG;
    private final j yf = new j();
    private long sW = 0;
    private Handler jc = new Handler(Looper.getMainLooper());
    private boolean yg = true;
    private volatile boolean eQ = false;
    private Runnable yh = new Runnable() { // from class: com.kwad.components.ad.reward.presenter.c.a.1
        @Override // java.lang.Runnable
        public final void run() {
            if (a.this.yf.ye()) {
                long jElapsedRealtime = SystemClock.elapsedRealtime() - a.this.yf.yg();
                int iYh = a.this.yf.yf().yh();
                a.this.ub.a(jElapsedRealtime, a.this.yf.yf().yi(), iYh);
            } else if (a.this.yg) {
                a.this.ub.a(5000L, 5000L, 1);
            }
            com.kwad.components.core.p.a.vX().bb(a.this.mAdTemplate);
        }
    };
    private m wH = new m() { // from class: com.kwad.components.ad.reward.presenter.c.a.2
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayCompleted() {
            super.onMediaPlayCompleted();
            a.this.iR();
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, long j2) {
            super.onMediaPlayProgress(j, j2);
            a.this.c(j2);
            a.this.sW = j2;
            a.this.yf.yd();
            a.a(a.this, false);
            a.this.ub.sW = j2;
            if (a.this.eQ) {
                return;
            }
            a.b(a.this, true);
            com.kwad.components.core.p.a.vX().a(a.this.mAdTemplate, System.currentTimeMillis(), 1);
            d.b(a.this.ub.sG, a.this.mAdTemplate, a.this.ub.mPageEnterTime);
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayStart() {
            super.onMediaPlayStart();
            a.this.jl();
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayPaused() {
            super.onMediaPlayPaused();
            a.this.yf.yd();
        }
    };
    private m jX = new m() { // from class: com.kwad.components.ad.reward.presenter.c.a.3
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayStart() {
            super.onMediaPlayStart();
            a.this.jl();
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, long j2) {
            a.this.c(j2);
            a.this.sW = j2;
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlaying() {
            super.onMediaPlaying();
            a.this.yf.yd();
            a.a(a.this, false);
            if (a.this.eQ) {
                return;
            }
            a.b(a.this, true);
            com.kwad.components.core.p.a.vX().a(a.this.mAdTemplate, System.currentTimeMillis(), 1);
            d.b(a.this.ub.sG, a.this.mAdTemplate, a.this.ub.mPageEnterTime);
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayError(int i, int i2) {
            super.onMediaPlayError(i, i2);
            d.a(a.this.ub.sG, a.this.ub.mAdTemplate, a.this.ub.tf, i, i2);
            c.c(a.this.ub.sG, a.this.mAdTemplate);
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayPaused() {
            super.onMediaPlayPaused();
            a.this.yf.yd();
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.l
        public final void onVideoPlayBufferingPaused() {
            super.onVideoPlayBufferingPaused();
            a.this.yf.yc();
            a.this.jc.removeCallbacks(a.this.yh);
            a.this.jc.postDelayed(a.this.yh, 5000L);
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.l
        public final void onVideoPlayBufferingPlaying() {
            super.onVideoPlayBufferingPlaying();
            a.this.yf.yc();
            a.this.jc.removeCallbacks(a.this.yh);
            a.this.jc.postDelayed(a.this.yh, 5000L);
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayCompleted() {
            a.this.iR();
        }
    };

    static /* synthetic */ boolean a(a aVar, boolean z) {
        aVar.yg = false;
        return false;
    }

    static /* synthetic */ boolean b(a aVar, boolean z) {
        aVar.eQ = true;
        return true;
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        AdInfo adInfoEM = e.eM(this.mAdTemplate);
        this.mAdInfo = adInfoEM;
        this.cv = com.kwad.sdk.core.response.helper.a.bv(adInfoEM);
        if (this.ub.sr.lq()) {
            this.wG = this.wH;
        } else {
            this.wG = this.jX;
        }
        this.ub.sr.a(this.wG);
        this.jc.postDelayed(this.yh, 5000L);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.jc.removeCallbacksAndMessages(null);
        this.ub.sr.b(this.wG);
        j.a aVarYf = this.yf.yf();
        com.kwad.components.core.p.a.vX().a(this.ub.mAdTemplate, this.sW, aVarYf.yi(), aVarYf.yh());
    }

    public final void iR() {
        if (!this.ub.sG || !this.ub.sL) {
            com.kwad.sdk.core.adlog.c.g(this.mAdTemplate, this.ub.mReportExtData);
        }
        this.yf.yd();
    }

    public final void jl() {
        this.eQ = false;
        EcOrderCardStyle ecOrderCardStyleCreateFromAdInfo = EcOrderCardStyle.createFromAdInfo(this.mAdInfo);
        com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
        if (ecOrderCardStyleCreateFromAdInfo != null) {
            com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
            c0502a.aLl = String.valueOf(ecOrderCardStyleCreateFromAdInfo.getValue());
            bVar.b(c0502a);
        }
        if (!this.mAdTemplate.mPvReported) {
            checkExposure();
        }
        com.kwad.components.ad.reward.j.b.a(true, this.mAdTemplate, null, bVar);
        com.kwad.sdk.core.adlog.c.f(this.mAdTemplate, this.ub.mReportExtData);
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
                com.kwad.sdk.core.adlog.c.a(this.mAdTemplate, iCeil, this.ub.mReportExtData);
                this.cv.remove(num);
                return;
            }
        }
    }

    private void checkExposure() {
        long j = this.mAdInfo.adRewardInfo.callBackStrategyInfo.impressionCheckMs;
        if (j <= 0 || com.kwad.sdk.core.response.helper.a.ak(this.mAdInfo) <= 5000) {
            return;
        }
        this.jc.postDelayed(new Runnable() { // from class: com.kwad.components.ad.reward.presenter.c.a.4
            @Override // java.lang.Runnable
            public final void run() {
                com.kwad.components.ad.reward.m.a(1, a.this.ub);
            }
        }, j);
    }
}

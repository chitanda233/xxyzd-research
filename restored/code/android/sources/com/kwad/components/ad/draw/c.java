package com.kwad.components.ad.draw;

import android.content.Context;
import android.os.SystemClock;
import android.view.View;
import android.view.ViewGroup;
import android.widget.FrameLayout;
import com.kwad.sdk.api.KsDrawAd;
import com.kwad.sdk.api.core.AbstractKsDrawAd;
import com.kwad.sdk.api.model.AdExposureFailedReason;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.o;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.wrapper.m;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends AbstractKsDrawAd implements com.kwad.components.core.internal.api.a {
    private KsDrawAd.AdInteractionListener du;
    private com.kwad.components.ad.draw.view.b dv;
    private com.kwad.components.ad.draw.view.a dw;
    private com.kwad.components.ad.draw.view.c dx;
    private FrameLayout dz;
    private AdInfo mAdInfo;
    private AdResultData mAdResultData;
    private AdTemplate mAdTemplate;
    private long startTime;
    private boolean dy = false;
    private com.kwad.components.core.internal.api.c bz = new com.kwad.components.core.internal.api.c();
    private final com.kwad.sdk.core.j.b dA = new com.kwad.sdk.core.j.b() { // from class: com.kwad.components.ad.draw.c.2
        @Override // com.kwad.sdk.core.j.b
        public final void aM() {
            c.this.bz.h(c.this);
        }

        @Override // com.kwad.sdk.core.j.b
        public final void aN() {
            c.this.bz.i(c.this);
        }
    };
    private final KsDrawAd.AdInteractionListener dB = new KsDrawAd.AdInteractionListener() { // from class: com.kwad.components.ad.draw.c.3
        @Override // com.kwad.sdk.api.KsDrawAd.AdInteractionListener
        public final void onAdClicked() {
            if (c.this.du != null) {
                c.this.du.onAdClicked();
            }
        }

        @Override // com.kwad.sdk.api.KsDrawAd.AdInteractionListener
        public final void onAdShow() {
            if (c.this.du != null) {
                c.this.du.onAdShow();
            }
        }

        @Override // com.kwad.sdk.api.KsDrawAd.AdInteractionListener
        public final void onVideoPlayStart() {
            if (c.this.du != null) {
                try {
                    c.this.du.onVideoPlayStart();
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                }
            }
        }

        @Override // com.kwad.sdk.api.KsDrawAd.AdInteractionListener
        public final void onVideoPlayPause() {
            if (c.this.du != null) {
                try {
                    c.this.du.onVideoPlayPause();
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                }
            }
        }

        @Override // com.kwad.sdk.api.KsDrawAd.AdInteractionListener
        public final void onVideoPlayResume() {
            if (c.this.du != null) {
                try {
                    c.this.du.onVideoPlayResume();
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                }
            }
        }

        @Override // com.kwad.sdk.api.KsDrawAd.AdInteractionListener
        public final void onVideoPlayEnd() {
            if (c.this.du != null) {
                try {
                    c.this.du.onVideoPlayEnd();
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                }
            }
        }

        @Override // com.kwad.sdk.api.KsDrawAd.AdInteractionListener
        public final void onVideoPlayError() {
            if (c.this.du != null) {
                try {
                    c.this.du.onVideoPlayError();
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                }
            }
        }
    };

    public interface a {
        void aK();

        void aL();
    }

    @Override // com.kwad.components.core.internal.api.a
    public final boolean supportPushAd() {
        return true;
    }

    public c(AdResultData adResultData) {
        this.mAdResultData = adResultData;
        AdTemplate adTemplateR = com.kwad.sdk.core.response.helper.c.r(adResultData);
        this.mAdTemplate = adTemplateR;
        AdInfo adInfoEM = e.eM(adTemplateR);
        this.mAdInfo = adInfoEM;
        KSImageLoader.preloadImage(com.kwad.sdk.core.response.helper.a.bA(adInfoEM).getUrl(), this.mAdTemplate);
        com.kwad.components.ad.i.b.gb().a(this);
    }

    @Override // com.kwad.sdk.api.KsDrawAd
    public final int getECPM() {
        return com.kwad.sdk.core.response.helper.a.aX(e.eM(this.mAdTemplate));
    }

    @Override // com.kwad.sdk.api.KsDrawAd
    public final void setBidEcpm(int i) {
        setBidEcpm(i, -1L);
    }

    @Override // com.kwad.sdk.api.KsDrawAd
    public final void setBidEcpm(long j, long j2) {
        this.mAdTemplate.mBidEcpm = j;
        com.kwad.sdk.core.adlog.c.m(this.mAdTemplate, j2);
    }

    @Override // com.kwad.sdk.api.BaseKSAd
    public final Map<String, Object> getMediaExtraInfo() {
        HashMap map = new HashMap();
        if (com.kwad.sdk.core.config.e.Ka()) {
            map.put("llsid", Long.valueOf(this.mAdTemplate.llsid));
        }
        return map;
    }

    @Override // com.kwad.sdk.api.KsDrawAd
    public final void reportAdExposureFailed(int i, AdExposureFailedReason adExposureFailedReason) {
        com.kwad.sdk.core.adlog.c.a(this.mAdTemplate, i, adExposureFailedReason);
    }

    @Override // com.kwad.sdk.api.core.AbstractKsDrawAd
    public final View getDrawView2(Context context) {
        long jElapsedRealtime = SystemClock.elapsedRealtime();
        if (context == null || !o.GE().FJ()) {
            return null;
        }
        if (aJ()) {
            return this.dz;
        }
        this.dz = new FrameLayout(context);
        com.kwad.components.ad.draw.a.c.i(this.mAdTemplate);
        this.startTime = SystemClock.elapsedRealtime();
        try {
            context = m.wrapContextIfNeed(context);
            if (com.kwad.sdk.core.response.helper.b.dA(this.mAdTemplate)) {
                a(context, this.dz);
            } else {
                b(context, this.dz);
                com.kwad.components.ad.draw.a.c.a(this.mAdTemplate, SystemClock.elapsedRealtime() - this.startTime, 1, 1, true);
            }
        } catch (Throwable th) {
            if (o.GE().FG()) {
                RuntimeException runtimeException = new RuntimeException("context:" + context.getClass().getName() + "--classloader:" + context.getClass().getClassLoader());
                runtimeException.addSuppressed(th);
                com.kwad.components.ad.draw.a.c.b(this.mAdTemplate, SystemClock.elapsedRealtime() - this.startTime, th.getMessage());
                com.kwad.components.core.d.a.reportSdkCaughtException(runtimeException);
            } else {
                throw th;
            }
        }
        if (!aJ()) {
            return null;
        }
        try {
            com.kwad.sdk.commercial.convert.d.f(e.eG(this.mAdTemplate), SystemClock.elapsedRealtime() - jElapsedRealtime);
        } catch (Throwable th2) {
            ServiceProvider.reportSdkCaughtException(th2);
        }
        return this.dz;
    }

    private boolean aJ() {
        FrameLayout frameLayout = this.dz;
        return frameLayout != null && frameLayout.getChildCount() == 1;
    }

    private void a(final Context context, final ViewGroup viewGroup) {
        if (this.dx == null) {
            com.kwad.components.ad.draw.view.c cVar = new com.kwad.components.ad.draw.view.c(context);
            this.dx = cVar;
            cVar.setPageExitListener(this.dA);
            this.dx.setAdInteractionListener(this.du);
            this.dx.setTKLoadStateListener(new a() { // from class: com.kwad.components.ad.draw.c.1
                @Override // com.kwad.components.ad.draw.c.a
                public final void aK() {
                    try {
                        com.kwad.sdk.commercial.convert.d.b(e.eG(c.this.mAdTemplate), 2, SystemClock.elapsedRealtime() - c.this.startTime);
                    } catch (Throwable th) {
                        ServiceProvider.reportSdkCaughtException(th);
                    }
                    com.kwad.components.ad.draw.a.c.a(c.this.mAdTemplate, SystemClock.elapsedRealtime() - c.this.startTime, 2, 2, false);
                }

                @Override // com.kwad.components.ad.draw.c.a
                public final void aL() {
                    viewGroup.removeAllViews();
                    c.this.b(context, viewGroup);
                    com.kwad.components.ad.draw.a.c.a(c.this.mAdTemplate, SystemClock.elapsedRealtime() - c.this.startTime, 1, 2, true);
                }
            });
            this.dx.c(this.mAdResultData);
        }
        a(viewGroup, this.dx);
    }

    private static void a(ViewGroup viewGroup, View view) {
        if (viewGroup == null || view == null || view.getParent() != null) {
            return;
        }
        viewGroup.removeAllViews();
        viewGroup.addView(view);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void b(Context context, ViewGroup viewGroup) {
        if (com.kwad.sdk.core.response.helper.a.cY(this.mAdInfo)) {
            if (this.dw == null) {
                com.kwad.components.ad.draw.view.a aVar = new com.kwad.components.ad.draw.view.a(context, this.mAdTemplate);
                this.dw = aVar;
                aVar.setPageExitListener(this.dA);
                this.dw.setAdInteractionListener(this.du);
                this.dw.bA();
            } else {
                com.kwad.sdk.core.d.c.i("KSDrawAdControl", "mDrawAdLiveView is not null");
            }
            a(viewGroup, this.dw);
            return;
        }
        if (this.dv == null) {
            com.kwad.components.ad.draw.view.b bVar = new com.kwad.components.ad.draw.view.b(context);
            this.dv = bVar;
            bVar.setPageExitListener(this.dA);
            this.dv.setAdInteractionListener(this.du);
            this.dv.k(this.mAdTemplate);
        } else {
            com.kwad.sdk.core.d.c.i("KSDrawAdControl", "mDrawVideoView is not null");
        }
        a(viewGroup, this.dv);
        try {
            com.kwad.sdk.commercial.convert.d.b(e.eG(this.mAdTemplate), 1, SystemClock.elapsedRealtime() - this.startTime);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    @Override // com.kwad.sdk.api.KsDrawAd
    public final void setAdInteractionListener(KsDrawAd.AdInteractionListener adInteractionListener) {
        this.du = adInteractionListener;
        com.kwad.components.ad.draw.view.b bVar = this.dv;
        if (bVar != null) {
            bVar.setAdInteractionListener(adInteractionListener);
        }
    }

    @Override // com.kwad.sdk.api.KsDrawAd
    public final int getMaterialType() {
        return com.kwad.sdk.core.response.helper.a.bk(e.eM(this.mAdTemplate));
    }

    @Override // com.kwad.sdk.api.KsDrawAd
    public final int getInteractionType() {
        return com.kwad.sdk.core.response.helper.a.aW(e.eM(this.mAdTemplate));
    }

    @Override // com.kwad.sdk.api.KsDrawAd
    public final void setVideoSoundEnable(boolean z) {
        com.kwad.components.ad.draw.view.b bVar = this.dv;
        if (bVar != null) {
            bVar.setVideoSound(z);
        }
        com.kwad.components.ad.draw.view.a aVar = this.dw;
        if (aVar != null) {
            aVar.setVideoSound(z);
        }
        com.kwad.components.ad.draw.view.c cVar = this.dx;
        if (cVar != null) {
            cVar.setVideoSound(z);
        }
    }

    @Override // com.kwad.sdk.api.KsDrawAd
    public final void controlPlayerStatus() {
        this.dy = true;
        com.kwad.components.ad.draw.view.b bVar = this.dv;
        if (bVar != null) {
            bVar.bM();
        }
        com.kwad.components.ad.draw.view.c cVar = this.dx;
        if (cVar != null) {
            cVar.bM();
        }
    }

    @Override // com.kwad.sdk.api.KsDrawAd
    public final void play() {
        if (this.dy) {
            com.kwad.components.ad.draw.view.b bVar = this.dv;
            if (bVar != null) {
                bVar.play();
            }
            com.kwad.components.ad.draw.view.c cVar = this.dx;
            if (cVar != null) {
                cVar.A(1);
            }
        }
    }

    @Override // com.kwad.sdk.api.KsDrawAd
    public final void pause() {
        if (this.dy) {
            com.kwad.components.ad.draw.view.b bVar = this.dv;
            if (bVar != null) {
                bVar.pause();
            }
            com.kwad.components.ad.draw.view.c cVar = this.dx;
            if (cVar != null) {
                cVar.A(2);
            }
        }
    }

    @Override // com.kwad.components.core.internal.api.a
    public final AdTemplate getAdTemplate() {
        return this.mAdTemplate;
    }

    @Override // com.kwad.components.core.internal.api.a
    public final void a(com.kwad.components.core.internal.api.b bVar) {
        this.bz.a(bVar);
    }

    @Override // com.kwad.components.core.internal.api.a
    public final void b(com.kwad.components.core.internal.api.b bVar) {
        this.bz.b(bVar);
    }
}

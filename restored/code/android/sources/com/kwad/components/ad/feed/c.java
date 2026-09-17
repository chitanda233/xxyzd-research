package com.kwad.components.ad.feed;

import android.content.Context;
import android.os.SystemClock;
import android.view.View;
import android.view.ViewGroup;
import com.kwad.components.ad.feed.widget.q;
import com.kwad.components.ad.feed.widget.r;
import com.kwad.components.core.internal.api.KSAdVideoPlayConfigImpl;
import com.kwad.components.model.FeedType;
import com.kwad.sdk.api.KsAdVideoPlayConfig;
import com.kwad.sdk.api.KsFeedAd;
import com.kwad.sdk.api.core.AbstractKsFeedAd;
import com.kwad.sdk.api.model.AdExposureFailedReason;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.o;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import com.kwad.sdk.utils.n;
import com.kwad.sdk.wrapper.m;
import java.util.HashMap;
import java.util.Map;
import java.util.concurrent.atomic.AtomicBoolean;
import java.util.concurrent.atomic.AtomicInteger;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends AbstractKsFeedAd implements com.kwad.components.core.internal.api.a {
    private final KsAdVideoPlayConfig ce;
    private KsFeedAd.AdInteractionListener gW;
    private com.kwad.components.core.widget.b gX;
    private r gY;
    private boolean gZ;
    private final AdInfo mAdInfo;
    private final AdResultData mAdResultData;
    private final AdTemplate mAdTemplate;
    private AtomicBoolean ha = new AtomicBoolean(false);
    private AtomicBoolean hb = new AtomicBoolean(false);
    private AtomicInteger hc = new AtomicInteger(2);
    private com.kwad.components.core.internal.api.c bz = new com.kwad.components.core.internal.api.c();
    private com.kwad.sdk.core.j.b dA = new com.kwad.sdk.core.j.b() { // from class: com.kwad.components.ad.feed.c.1
        @Override // com.kwad.sdk.core.j.b
        public final void aM() {
            c.this.bz.h(c.this);
        }

        @Override // com.kwad.sdk.core.j.b
        public final void aN() {
            c.this.bz.i(c.this);
        }
    };

    public interface a {
        void d(int i, String str);
    }

    @Override // com.kwad.components.core.internal.api.a
    public final boolean supportPushAd() {
        return true;
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

    public c(AdResultData adResultData, boolean z) {
        this.mAdResultData = adResultData;
        AdTemplate adTemplateR = com.kwad.sdk.core.response.helper.c.r(adResultData);
        this.mAdTemplate = adTemplateR;
        adTemplateR.mInitVoiceStatus = 1;
        this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(adTemplateR);
        this.gZ = z;
        this.ce = new KSAdVideoPlayConfigImpl();
        com.kwad.components.ad.i.b.gb().a(this);
    }

    @Override // com.kwad.sdk.api.KsFeedAd
    public final void setVideoSoundEnable(boolean z) {
        this.ce.setVideoSoundEnable(z);
        if (this.ce.isVideoSoundEnable()) {
            this.mAdTemplate.mInitVoiceStatus = 2;
        } else {
            this.mAdTemplate.mInitVoiceStatus = 1;
        }
    }

    @Override // com.kwad.sdk.api.KsFeedAd
    public final void render(final KsFeedAd.AdRenderListener adRenderListener) {
        final long jElapsedRealtime = SystemClock.elapsedRealtime();
        com.kwad.components.ad.feed.monitor.b.n(this.mAdTemplate);
        if (this.hb.get()) {
            if (this.gX == null) {
                adRenderListener.onAdRenderFailed(com.kwad.sdk.core.network.e.aTj.errorCode, com.kwad.sdk.core.network.e.aTj.msg);
                this.hb.set(false);
                this.ha.set(false);
                return;
            }
            by.runOnUiThread(new bi() { // from class: com.kwad.components.ad.feed.c.2
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    try {
                        com.kwad.sdk.commercial.convert.d.e(com.kwad.sdk.core.response.helper.e.eG(c.this.mAdTemplate), SystemClock.elapsedRealtime() - jElapsedRealtime);
                    } catch (Throwable th) {
                        ServiceProvider.reportSdkCaughtException(th);
                    }
                    adRenderListener.onAdRenderSuccess(c.this.gX);
                    com.kwad.components.ad.feed.monitor.b.a(2, c.this.mAdTemplate, com.kwad.sdk.core.response.helper.a.bh(c.this.mAdInfo), c.this.hc.get());
                }
            });
            return;
        }
        if (this.ha.get()) {
            return;
        }
        final long jElapsedRealtime2 = SystemClock.elapsedRealtime();
        final int i = com.kwad.sdk.core.response.helper.b.dy(this.mAdTemplate) ? 3 : 2;
        this.ha.set(true);
        a(new a() { // from class: com.kwad.components.ad.feed.c.3
            @Override // com.kwad.components.ad.feed.c.a
            public final void d(int i2, String str) {
                com.kwad.components.ad.feed.monitor.b.a(c.this.getAdTemplate(), i2, i, SystemClock.elapsedRealtime() - jElapsedRealtime2, str);
                c.this.hc.set(i2);
                c.this.hb.set(true);
                try {
                    if (adRenderListener != null) {
                        if (c.this.gX == null) {
                            adRenderListener.onAdRenderFailed(com.kwad.sdk.core.network.e.aTj.errorCode, com.kwad.sdk.core.network.e.aTj.msg);
                        } else {
                            by.runOnUiThread(new Runnable() { // from class: com.kwad.components.ad.feed.c.3.1
                                @Override // java.lang.Runnable
                                public final void run() {
                                    try {
                                        com.kwad.sdk.commercial.convert.d.e(com.kwad.sdk.core.response.helper.e.eG(c.this.mAdTemplate), SystemClock.elapsedRealtime() - jElapsedRealtime);
                                    } catch (Throwable th) {
                                        ServiceProvider.reportSdkCaughtException(th);
                                    }
                                    adRenderListener.onAdRenderSuccess(c.this.gX);
                                    com.kwad.components.ad.feed.monitor.b.a(2, c.this.mAdTemplate, com.kwad.sdk.core.response.helper.a.bh(c.this.mAdInfo), c.this.hc.get());
                                }
                            });
                        }
                    }
                } catch (Throwable unused) {
                }
            }
        });
    }

    @Override // com.kwad.sdk.api.KsFeedAd
    public final void setVideoPlayConfig(KsAdVideoPlayConfig ksAdVideoPlayConfig) {
        if (ksAdVideoPlayConfig instanceof KSAdVideoPlayConfigImpl) {
            KSAdVideoPlayConfigImpl kSAdVideoPlayConfigImpl = (KSAdVideoPlayConfigImpl) ksAdVideoPlayConfig;
            if (kSAdVideoPlayConfigImpl.getVideoSoundValue() != 0) {
                this.ce.setVideoSoundEnable(kSAdVideoPlayConfigImpl.isVideoSoundEnable());
            }
            if (kSAdVideoPlayConfigImpl.getVideoAutoPlayType() != 0) {
                this.ce.setVideoAutoPlayType(kSAdVideoPlayConfigImpl.getVideoAutoPlayType());
            } else if (kSAdVideoPlayConfigImpl.getDataFlowAutoStartValue() != 0) {
                this.ce.setDataFlowAutoStart(kSAdVideoPlayConfigImpl.isDataFlowAutoStart());
            } else {
                this.ce.setDataFlowAutoStart(com.kwad.sdk.core.config.e.Kh());
                try {
                    this.ce.setVideoAutoPlayType(0);
                } catch (NoSuchMethodError unused) {
                } catch (Throwable th) {
                    com.kwad.components.core.d.a.reportSdkCaughtException(th);
                }
            }
            com.kwad.components.core.widget.b bVar = this.gX;
            if (bVar instanceof q) {
                ((q) bVar).setVideoPlayConfig(this.ce);
            }
            com.kwad.components.core.widget.b bVar2 = this.gX;
            if (bVar2 instanceof r) {
                ((r) bVar2).setVideoPlayConfig(this.ce);
            }
            com.kwad.components.core.widget.b bVar3 = this.gX;
            if (bVar3 instanceof com.kwad.components.ad.feed.widget.c) {
                ((com.kwad.components.ad.feed.widget.c) bVar3).setVideoPlayConfig(this.ce);
            }
        }
        if (isVideoSoundEnable()) {
            this.mAdTemplate.mInitVoiceStatus = 2;
        } else {
            this.mAdTemplate.mInitVoiceStatus = 1;
        }
    }

    private boolean isVideoSoundEnable() {
        KsAdVideoPlayConfig ksAdVideoPlayConfig = this.ce;
        if (ksAdVideoPlayConfig instanceof KSAdVideoPlayConfigImpl) {
            KSAdVideoPlayConfigImpl kSAdVideoPlayConfigImpl = (KSAdVideoPlayConfigImpl) ksAdVideoPlayConfig;
            if (kSAdVideoPlayConfigImpl.getVideoSoundValue() != 0) {
                return kSAdVideoPlayConfigImpl.isVideoSoundEnable();
            }
        }
        return com.kwad.sdk.core.response.helper.a.ch(this.mAdInfo);
    }

    public final void a(final a aVar) {
        Context context = ServiceProvider.getContext();
        this.mAdTemplate.loadType = 2;
        this.ha.set(true);
        com.kwad.components.core.widget.b<?, ?> bVarC = C(context);
        this.gX = bVarC;
        if (bVarC != null) {
            if (bVarC instanceof q) {
                q qVar = (q) bVarC;
                qVar.setPreloadListener(new q.a() { // from class: com.kwad.components.ad.feed.c.4
                    @Override // com.kwad.components.ad.feed.widget.q.a
                    public final void d(int i, String str) {
                        c cVar = c.this;
                        cVar.a(cVar.gX, false);
                        c.this.hb.set(true);
                        aVar.d(i, str);
                    }
                });
                qVar.d(this.mAdResultData);
                return;
            } else {
                if (bVarC instanceof r) {
                    r rVar = (r) bVarC;
                    rVar.setTKLoadListener(new r.a() { // from class: com.kwad.components.ad.feed.c.5
                        @Override // com.kwad.components.ad.feed.widget.r.a
                        public final void d(int i, String str) {
                            c cVar = c.this;
                            cVar.a(cVar.gX, false);
                            c.this.hb.set(true);
                            aVar.d(i, str);
                        }
                    });
                    rVar.d(this.mAdResultData);
                    return;
                }
                bVarC.d(this.mAdResultData);
                com.kwad.components.core.widget.b bVar = this.gX;
                if (bVar instanceof com.kwad.components.ad.feed.widget.c) {
                    ((com.kwad.components.ad.feed.widget.c) bVar).b(this.ce);
                }
                a(this.gX, true);
                this.hb.set(true);
                aVar.d(1, "");
                return;
            }
        }
        this.hb.set(false);
        this.ha.set(false);
        aVar.d(1, "render Failed");
    }

    @Override // com.kwad.sdk.api.KsFeedAd
    public final void setAdInteractionListener(KsFeedAd.AdInteractionListener adInteractionListener) {
        this.gW = adInteractionListener;
    }

    @Override // com.kwad.sdk.api.KsFeedAd
    public final int getECPM() {
        return com.kwad.sdk.core.response.helper.a.aX(this.mAdInfo);
    }

    @Override // com.kwad.sdk.api.KsFeedAd
    public final void setBidEcpm(int i) {
        setBidEcpm(i, -1L);
    }

    @Override // com.kwad.sdk.api.KsFeedAd
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

    @Override // com.kwad.sdk.api.KsFeedAd
    public final void reportAdExposureFailed(int i, AdExposureFailedReason adExposureFailedReason) {
        com.kwad.sdk.core.adlog.c.a(this.mAdTemplate, i, adExposureFailedReason);
    }

    @Override // com.kwad.sdk.api.KsFeedAd
    public final int getMaterialType() {
        return com.kwad.sdk.core.response.helper.a.bk(this.mAdInfo);
    }

    @Override // com.kwad.sdk.api.KsFeedAd
    public final int getInteractionType() {
        return com.kwad.sdk.core.response.helper.a.aW(this.mAdInfo);
    }

    /* JADX WARN: Code duplicated, block: B:37:0x009d  */
    /* JADX WARN: Code duplicated, block: B:39:0x00a1  */
    @Override // com.kwad.sdk.api.core.AbstractKsFeedAd
    public final View getFeedView2(Context context) {
        long jElapsedRealtime = SystemClock.elapsedRealtime();
        if (context == null || !o.GE().FJ()) {
            return null;
        }
        try {
            Context contextWrapContextIfNeed = m.wrapContextIfNeed(context);
            com.kwad.sdk.commercial.convert.c.cc(this.mAdTemplate);
            com.kwad.components.core.widget.b bVar = this.gX;
            if (bVar != null) {
                try {
                    if (bVar.getParent() instanceof ViewGroup) {
                        ((ViewGroup) this.gX.getParent()).removeView(this.gX);
                    }
                } catch (NullPointerException unused) {
                }
                try {
                    com.kwad.sdk.commercial.convert.d.f(com.kwad.sdk.core.response.helper.e.eG(this.mAdTemplate), SystemClock.elapsedRealtime() - jElapsedRealtime);
                } catch (Throwable th) {
                    ServiceProvider.reportSdkCaughtException(th);
                }
                return this.gX;
            }
            bZ();
            this.mAdTemplate.loadType = 1;
            com.kwad.components.core.widget.b<?, ?> bVarC = C(contextWrapContextIfNeed);
            this.gX = bVarC;
            if (bVarC == null) {
                return null;
            }
            bVarC.d(this.mAdResultData);
            com.kwad.components.core.widget.b bVar2 = this.gX;
            if (bVar2 instanceof com.kwad.components.ad.feed.widget.c) {
                ((com.kwad.components.ad.feed.widget.c) bVar2).b(this.ce);
            }
            com.kwad.components.core.widget.b bVar3 = this.gX;
            if (bVar3 instanceof q) {
                a(bVar3, false);
            } else {
                a(bVar3, true);
            }
            try {
                com.kwad.sdk.commercial.convert.d.f(com.kwad.sdk.core.response.helper.e.eG(this.mAdTemplate), SystemClock.elapsedRealtime() - jElapsedRealtime);
            } catch (Throwable th2) {
                ServiceProvider.reportSdkCaughtException(th2);
            }
            return this.gX;
        } catch (Throwable th3) {
            if (o.GE().FG()) {
                ServiceProvider.reportSdkCaughtException(th3);
                return null;
            }
            throw th3;
        }
        if (o.GE().FG()) {
            ServiceProvider.reportSdkCaughtException(th3);
            return null;
        }
        throw th3;
    }

    private void bZ() {
        if (this.mAdTemplate != null) {
            com.kwad.sdk.core.diskcache.b.a.LI().remove("feed_ad_cache_" + this.mAdTemplate.posId);
        }
    }

    private com.kwad.components.core.widget.b<?, ?> C(Context context) {
        com.kwad.components.core.widget.b<?, ?> bVarA;
        int width = this.mAdTemplate.mAdScene.getWidth();
        if (width < com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aPK) * ((double) n.getScreenWidth(context))) {
            com.kwad.components.ad.feed.monitor.b.a(width, com.kwad.sdk.core.response.helper.a.bk(this.mAdInfo), this.mAdTemplate.type, this.mAdTemplate);
        }
        if (com.kwad.sdk.core.response.helper.b.dy(this.mAdTemplate)) {
            r rVar = new r(m.wrapContextIfNeed(context));
            this.gY = rVar;
            rVar.setWidth(width);
            this.gY.setVideoPlayConfig(this.ce);
            bVarA = this.gY;
        } else if (this.gZ && com.kwad.sdk.core.response.helper.b.dx(this.mAdTemplate)) {
            try {
                context = m.wrapContextIfNeed(context);
                q qVar = new q(context);
                qVar.setWidth(width);
                qVar.setVideoPlayConfig(this.ce);
                bVarA = qVar;
            } catch (Throwable th) {
                com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                bVarA = null;
            }
        } else {
            bVarA = b.a(context, FeedType.fromInt(this.mAdTemplate.type, this.mAdTemplate.defaultType), com.kwad.sdk.core.response.helper.a.bk(this.mAdInfo));
        }
        if (bVarA != null) {
            if (!(bVarA instanceof r)) {
                bVarA.setMargin(com.kwad.sdk.c.a.a.a(context, 16.0f));
            }
            bVarA.setPageExitListener(this.dA);
        }
        return bVarA;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(final com.kwad.components.core.widget.b bVar, final boolean z) {
        if (bVar == null) {
            return;
        }
        bVar.setInnerAdInteractionListener(new com.kwad.components.core.widget.b.a() { // from class: com.kwad.components.ad.feed.c.6
            @Override // com.kwad.components.core.widget.b.a
            public final void onAdClicked() {
                if (c.this.gW != null) {
                    c.this.gW.onAdClicked();
                }
                com.kwad.components.ad.feed.monitor.b.a(4, c.this.mAdTemplate, com.kwad.sdk.core.response.helper.a.bh(c.this.mAdInfo), z ? 1 : 2);
            }

            @Override // com.kwad.components.core.widget.b.a
            public final void onAdShow() {
                com.kwad.components.ad.feed.monitor.b.o(c.this.mAdTemplate);
                com.kwad.sdk.commercial.convert.c.cd(c.this.mAdTemplate);
                if (c.this.gW != null) {
                    c.this.gW.onAdShow();
                }
                com.kwad.components.ad.feed.monitor.b.a(3, c.this.mAdTemplate, com.kwad.sdk.core.response.helper.a.bh(c.this.mAdInfo), z ? 1 : 2);
                if (z) {
                    com.kwad.sdk.core.adlog.c.b bVar2 = new com.kwad.sdk.core.adlog.c.b();
                    com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
                    FeedType feedTypeFromInt = FeedType.fromInt(c.this.mAdTemplate.type, c.this.mAdTemplate.defaultType);
                    if (feedTypeFromInt == FeedType.FEED_TYPE_TEXT_NEW) {
                        feedTypeFromInt = FeedType.FEED_TYPE_TEXT_BELOW;
                    }
                    c0502a.templateId = String.valueOf(feedTypeFromInt.getType());
                    c0502a.aLj = String.valueOf(feedTypeFromInt.getFeedDefaultType() == null ? 0 : feedTypeFromInt.getFeedDefaultType().getDefaultType());
                    bVar2.b(c0502a);
                    bVar2.z(c.this.gX.getHeight(), c.this.gX.getWidth());
                    com.kwad.components.core.t.b.wR().a(c.this.mAdTemplate, null, bVar2);
                }
            }

            @Override // com.kwad.components.core.widget.b.a
            public final void onDislikeClicked() {
                if (c.this.gW != null) {
                    c.this.gW.onDislikeClicked();
                    try {
                        if (bVar.getParent() instanceof ViewGroup) {
                            ((ViewGroup) bVar.getParent()).removeView(bVar);
                        }
                    } catch (Exception e) {
                        com.kwad.sdk.core.d.c.printStackTrace(e);
                    }
                }
                com.kwad.components.ad.feed.monitor.b.a(5, c.this.mAdTemplate, com.kwad.sdk.core.response.helper.a.bh(c.this.mAdInfo), z ? 1 : 2);
            }

            @Override // com.kwad.components.core.widget.b.a
            public final void onDownloadTipsDialogShow() {
                if (c.this.gW != null) {
                    try {
                        c.this.gW.onDownloadTipsDialogShow();
                    } catch (Throwable unused) {
                    }
                }
            }

            @Override // com.kwad.components.core.widget.b.a
            public final void onDownloadTipsDialogDismiss() {
                if (c.this.gW != null) {
                    try {
                        c.this.gW.onDownloadTipsDialogDismiss();
                    } catch (Throwable unused) {
                    }
                }
            }
        });
    }
}

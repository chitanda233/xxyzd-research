package com.kwad.components.ad.c;

import android.content.Context;
import android.os.SystemClock;
import android.view.View;
import com.kwad.components.core.internal.api.KSAdVideoPlayConfigImpl;
import com.kwad.sdk.api.KsAdVideoPlayConfig;
import com.kwad.sdk.api.KsBannerAd;
import com.kwad.sdk.api.model.AdExposureFailedReason;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.o;
import com.kwad.sdk.service.ServiceProvider;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public final class h implements d, KsBannerAd {
    private final KsAdVideoPlayConfig ce = new KSAdVideoPlayConfigImpl();
    private AdResultData mAdResultData;
    private AdTemplate mAdTemplate;

    @Override // com.kwad.sdk.api.KsBannerAd
    public final boolean supportPushAd() {
        return false;
    }

    public h(AdResultData adResultData) {
        this.mAdResultData = adResultData;
        this.mAdTemplate = com.kwad.sdk.core.response.helper.c.r(adResultData);
    }

    @Override // com.kwad.sdk.api.KsBannerAd
    public final int getECPM() {
        return com.kwad.sdk.core.response.helper.a.aX(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate));
    }

    @Override // com.kwad.sdk.api.KsBannerAd
    public final void setBidEcpm(int i) {
        setBidEcpm(i, -1L);
    }

    @Override // com.kwad.sdk.api.KsBannerAd
    public final void setBidEcpm(long j, long j2) {
        this.mAdTemplate.mBidEcpm = j;
        com.kwad.sdk.core.adlog.c.m(this.mAdTemplate, j2);
    }

    @Override // com.kwad.sdk.api.KsBannerAd
    public final void reportAdExposureFailed(int i, AdExposureFailedReason adExposureFailedReason) {
        com.kwad.sdk.core.adlog.c.a(this.mAdTemplate, i, adExposureFailedReason);
    }

    @Override // com.kwad.sdk.api.KsBannerAd
    public final int getMaterialType() {
        return com.kwad.sdk.core.response.helper.a.bk(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate));
    }

    @Override // com.kwad.sdk.api.KsBannerAd
    public final int getInteractionType() {
        return com.kwad.sdk.core.response.helper.a.aW(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate));
    }

    @Override // com.kwad.sdk.api.KsBannerAd
    public final View getView(Context context, KsBannerAd.BannerAdInteractionListener bannerAdInteractionListener, KsAdVideoPlayConfig ksAdVideoPlayConfig) {
        long jElapsedRealtime = SystemClock.elapsedRealtime();
        if (context == null || !o.GE().FJ()) {
            return null;
        }
        com.kwad.sdk.commercial.convert.c.cc(this.mAdTemplate);
        i iVar = new i(context, this.mAdResultData, ksAdVideoPlayConfig);
        iVar.setBannerAdListener(bannerAdInteractionListener);
        iVar.setBannerUpdateAdResultDataListener(this);
        try {
            com.kwad.sdk.commercial.convert.d.f(com.kwad.sdk.core.response.helper.e.eG(this.mAdTemplate), SystemClock.elapsedRealtime() - jElapsedRealtime);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
        return iVar;
    }

    public final AdTemplate getAdTemplate() {
        return this.mAdTemplate;
    }

    @Override // com.kwad.sdk.api.BaseKSAd
    public final Map<String, Object> getMediaExtraInfo() {
        HashMap map = new HashMap();
        if (com.kwad.sdk.core.config.e.Ka()) {
            map.put("llsid", Long.valueOf(this.mAdTemplate.llsid));
        }
        return map;
    }

    @Override // com.kwad.components.ad.c.d
    public final void b(AdTemplate adTemplate) {
        this.mAdTemplate = adTemplate;
    }
}

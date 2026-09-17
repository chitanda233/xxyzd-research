package com.kwad.components.ad.fullscreen;

import android.app.Activity;
import com.kwad.components.core.video.k;
import com.kwad.sdk.api.KsFullScreenVideoAd;
import com.kwad.sdk.api.KsVideoPlayConfig;
import com.kwad.sdk.core.response.model.AdResultData;

/* JADX INFO: loaded from: classes3.dex */
public final class g extends com.kwad.components.ad.b implements com.kwad.components.core.internal.api.a, KsFullScreenVideoAd {
    private c jP;

    public g(AdResultData adResultData) {
        super(adResultData);
        com.kwad.components.ad.i.b.gb().a(this);
    }

    @Override // com.kwad.sdk.api.KsFullScreenVideoAd
    public final void setFullScreenVideoAdInteractionListener(KsFullScreenVideoAd.FullScreenVideoAdInteractionListener fullScreenVideoAdInteractionListener) {
        if (this.jP == null) {
            this.jP = new c() { // from class: com.kwad.components.ad.fullscreen.g.1
                @Override // com.kwad.components.ad.fullscreen.c, com.kwad.sdk.api.KsFullScreenVideoAd.FullScreenVideoAdInteractionListener
                public final void onVideoPlayStart() {
                    super.onVideoPlayStart();
                    g.this.bz.h(g.this);
                }

                @Override // com.kwad.components.ad.fullscreen.c, com.kwad.sdk.api.KsFullScreenVideoAd.FullScreenVideoAdInteractionListener
                public final void onPageDismiss() {
                    super.onPageDismiss();
                    g.this.bz.i(g.this);
                }
            };
        }
        this.jP.a(fullScreenVideoAdInteractionListener);
    }

    @Override // com.kwad.sdk.api.KsFullScreenVideoAd
    public final void showFullScreenVideoAd(Activity activity, KsVideoPlayConfig ksVideoPlayConfig) {
        if (activity == null || activity.isFinishing()) {
            com.kwad.sdk.core.d.c.e("KsFullScreenVideoAdControl", "showFullScreenVideoAd error, activity is null or finished");
            com.kwad.components.ad.reward.monitor.d.b(false, this.mAdTemplate, "illegal_activity");
            return;
        }
        com.kwad.components.ad.reward.monitor.d.h(false, this.mAdTemplate);
        com.kwad.sdk.commercial.convert.c.cc(this.mAdTemplate);
        if (!com.kwad.sdk.core.config.e.KM() && !isAdEnable()) {
            com.kwad.sdk.core.d.c.i("KsFullScreenVideoAdControl", "isAdEnable is false");
            com.kwad.components.ad.reward.monitor.d.b(false, this.mAdTemplate, "cache_not_ready");
        } else {
            if (ksVideoPlayConfig == null) {
                ksVideoPlayConfig = new KsVideoPlayConfig.Builder().build();
            }
            KsFullScreenVideoActivityProxy.launch(activity, this.mAdResultData, ksVideoPlayConfig, this.jP);
        }
    }

    @Override // com.kwad.sdk.api.KsFullScreenVideoAd
    public final boolean isAdEnable() {
        if (com.kwad.sdk.core.response.helper.e.fc(this.mAdTemplate) >= 0) {
            return true;
        }
        return k.bd(this.mAdTemplate);
    }
}

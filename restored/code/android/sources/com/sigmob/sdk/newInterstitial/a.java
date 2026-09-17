package com.sigmob.sdk.newInterstitial;

import com.czhj.sdk.common.models.AdStatus;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.mta.PointCategory;
import com.sigmob.sdk.base.utils.k;
import com.sigmob.windad.WindAdError;

/* JADX INFO: loaded from: classes4.dex */
public class a extends com.sigmob.sdk.manager.f implements e {
    @Override // com.sigmob.sdk.newInterstitial.e
    public void c(BaseAdUnit adUnit, String message) {
        k.f(this.f3469a, "onAdShowFail: msg = " + message, new Object[0]);
        if (n(adUnit)) {
            com.sigmob.sdk.base.common.h.g().e(adUnit);
        }
        WindAdError windAdError = WindAdError.ERROR_SIGMOB_AD_PLAY;
        windAdError.setMessage(message);
        a(windAdError, this.r);
        a(adUnit, PointCategory.PLAY, this.m.getAdType(), this.i, this.m.getLoadId(), windAdError);
    }

    @Override // com.sigmob.sdk.manager.b
    protected void g() {
        if (com.sigmob.sdk.base.utils.f.a(this.o)) {
            this.o = null;
            return;
        }
        BaseAdUnit baseAdUnitE = e();
        if (n(baseAdUnitE)) {
            com.sigmob.sdk.base.common.h.g().e(baseAdUnitE);
        }
        this.o = null;
    }

    @Override // com.sigmob.sdk.manager.f
    public com.sigmob.sdk.mraid.i o() {
        return new f(this);
    }

    @Override // com.sigmob.sdk.newInterstitial.e
    public void p(BaseAdUnit adUnit) {
        if (this.b == AdStatus.AdStatusClose) {
            return;
        }
        o(adUnit);
    }

    @Override // com.sigmob.sdk.newInterstitial.e
    public void q(BaseAdUnit adUnit) {
        k.c(this.f3469a, "onAdSkip", new Object[0]);
    }

    @Override // com.sigmob.sdk.newInterstitial.e
    public void r(BaseAdUnit adUnit) {
        k.c(this.f3469a, "onAdShow", new Object[0]);
    }
}

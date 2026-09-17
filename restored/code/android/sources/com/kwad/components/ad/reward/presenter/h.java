package com.kwad.components.ad.reward.presenter;

import android.text.TextUtils;
import com.kwad.sdk.core.response.model.AdInfo;

/* JADX INFO: loaded from: classes3.dex */
public final class h extends b implements com.kwad.sdk.app.a {
    private AdInfo mAdInfo;

    @Override // com.kwad.sdk.app.a
    public final void U(String str) {
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(this.ub.mAdTemplate);
        com.kwad.sdk.app.b.Ia().a(this);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        com.kwad.sdk.app.b.Ia().b(this);
    }

    @Override // com.kwad.sdk.app.a
    public final void T(String str) {
        if (TextUtils.equals(com.kwad.sdk.core.response.helper.a.aE(this.mAdInfo), str)) {
            AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(this.ub.mAdTemplate);
            if (com.kwad.sdk.core.response.helper.a.aU(adInfoEM) && com.kwad.sdk.core.response.helper.a.aT(adInfoEM) == 1) {
                return;
            }
            if (this.ub.sq != null) {
                this.ub.sq.onRewardVerify();
            }
            this.ub.sr.pause();
            this.ub.gU();
        }
    }
}

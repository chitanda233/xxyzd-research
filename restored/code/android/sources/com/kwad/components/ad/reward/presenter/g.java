package com.kwad.components.ad.reward.presenter;

import com.kwad.sdk.core.response.model.AdTemplate;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class g extends b implements com.kwad.components.core.j.a.InterfaceC0443a {
    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        boolean zMk = com.kwad.sdk.core.local.a.Mk();
        com.kwad.sdk.core.d.c.d("RewardInnerAdLoadPresenter", "onBind localCheckResult: " + zMk);
        if (this.mAdTemplate.mAdScene == null || !zMk) {
            return;
        }
        com.kwad.components.core.j.a.a(this.mAdTemplate.mAdScene, this);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
    }

    @Override // com.kwad.components.core.j.a.InterfaceC0443a
    public final void onError(int i, String str) {
        List<com.kwad.components.core.j.a.InterfaceC0443a> listHb = this.ub.hb();
        if (listHb != null) {
            Iterator<com.kwad.components.core.j.a.InterfaceC0443a> it = listHb.iterator();
            while (it.hasNext()) {
                it.next().onError(i, str);
            }
        }
    }

    @Override // com.kwad.components.core.j.a.InterfaceC0443a
    public final void onRequestResult(int i) {
        List<com.kwad.components.core.j.a.InterfaceC0443a> listHb = this.ub.hb();
        if (listHb != null) {
            Iterator<com.kwad.components.core.j.a.InterfaceC0443a> it = listHb.iterator();
            while (it.hasNext()) {
                it.next().onRequestResult(i);
            }
        }
    }

    @Override // com.kwad.components.core.j.a.InterfaceC0443a
    public final void e(List<com.kwad.components.core.j.c> list) {
        if (list == null || list.size() == 0) {
            return;
        }
        com.kwad.sdk.core.d.c.d("RewardInnerAdLoadPresenter", "onInnerAdLoad: " + list.size());
        AdTemplate adTemplate = list.get(0).getAdTemplate();
        boolean zDa = com.kwad.sdk.core.response.helper.b.da(adTemplate);
        List<com.kwad.components.core.j.a.InterfaceC0443a> listHb = this.ub.hb();
        if (zDa) {
            com.kwad.sdk.core.local.a.g(com.kwad.sdk.core.response.helper.b.cX(adTemplate), com.kwad.sdk.core.response.helper.b.cY(adTemplate));
            if (listHb != null) {
                Iterator<com.kwad.components.core.j.a.InterfaceC0443a> it = listHb.iterator();
                while (it.hasNext()) {
                    it.next().e(list);
                }
            }
        }
    }
}

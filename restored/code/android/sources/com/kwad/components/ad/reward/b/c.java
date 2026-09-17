package com.kwad.components.ad.reward.b;

import android.view.ViewGroup;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdProductInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.bi;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends com.kwad.components.ad.reward.presenter.b implements b.a {
    private AdTemplate mAdTemplate;
    private boolean qA = false;

    static /* synthetic */ boolean a(c cVar, boolean z) {
        cVar.qA = true;
        return true;
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.mAdTemplate = this.ub.mAdTemplate;
    }

    private static boolean m(AdInfo adInfo) {
        AdProductInfo adProductInfoDc = com.kwad.sdk.core.response.helper.a.dc(adInfo);
        return (!com.kwad.components.ad.reward.a.b.j(adInfo) || adProductInfoDc == null || adProductInfoDc.isCouponListEmpty()) ? false : true;
    }

    @Override // com.kwad.components.ad.reward.b.b.a
    public final void id() {
        this.ub.a(1, getContext(), 29, 1);
    }

    public final void showDialog() {
        ViewGroup childAt;
        com.kwad.sdk.core.d.c.d("RewardCouponDialogPresenter", "onBind hasShown : " + this.qA);
        if (this.qA) {
            return;
        }
        AdInfo adInfoEM = e.eM(this.mAdTemplate);
        ViewGroup viewGroup = (ViewGroup) this.ub.mRootContainer.findViewById(R.id.ksad_reward_order_coupon_list);
        if (viewGroup == null) {
            return;
        }
        if (viewGroup.getChildCount() > 0) {
            childAt = viewGroup;
            childAt = viewGroup.getChildAt(0);
        }
        childAt = viewGroup;
        final int[] iArrL = com.kwad.sdk.c.a.a.L(childAt);
        if (!m(adInfoEM) || iArrL == null) {
            return;
        }
        childAt.post(new bi() { // from class: com.kwad.components.ad.reward.b.c.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                com.kwad.sdk.core.d.c.d("RewardCouponDialogPresenter", "targetView x: " + iArrL[0] + ", y: " + iArrL[1]);
                b.a(c.this.getActivity(), c.this.mAdTemplate, c.this, iArrL);
                c.a(c.this, true);
            }
        });
    }
}

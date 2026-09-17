package com.kwad.components.ad.reward.presenter.platdetail.actionbar;

import android.content.Context;
import android.os.Handler;
import android.os.Looper;
import android.view.View;
import com.kwad.components.ad.reward.g;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.bi;
import java.util.Iterator;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: loaded from: classes3.dex */
public final class RewardActionBarControl {
    private AdInfo mAdInfo;
    private AdTemplate mAdTemplate;
    private Context mContext;
    private g ub;
    private b yO;
    private d yS;
    private c yT;
    private final long yV;
    private a yU = new a(0);
    private Handler jc = new Handler(Looper.getMainLooper());
    private boolean yW = false;
    private boolean yX = false;

    public enum ShowActionBarResult {
        SHOW_NATIVE_DEFAULT,
        SHOW_H5_SUCCESS,
        SHOW_H5_FAILURE,
        SHOW_ORDER,
        SHOW_NATIVE_ORDER,
        SHOW_NATIVE_JINNIU,
        SHOW_NATIVE_PLAYABLE_PORTRAIT,
        SHOW_NATIVE_LIVE_SUBSCRIBE,
        SHOW_NATIVE_ORIGIN_LIVE
    }

    public interface b {
        void a(boolean z, com.kwad.components.ad.reward.presenter.platdetail.actionbar.a aVar);
    }

    public interface c {
        void e(com.kwad.components.ad.reward.presenter.platdetail.actionbar.a aVar);
    }

    public interface d {
        boolean f(com.kwad.components.ad.reward.presenter.platdetail.actionbar.a aVar);
    }

    static /* synthetic */ boolean a(RewardActionBarControl rewardActionBarControl, boolean z) {
        rewardActionBarControl.yW = true;
        return true;
    }

    public RewardActionBarControl(g gVar, Context context, AdTemplate adTemplate) {
        this.ub = gVar;
        this.mContext = context;
        this.mAdTemplate = adTemplate;
        this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        long jCR = com.kwad.sdk.core.response.helper.b.cR(adTemplate) > 0 ? com.kwad.sdk.core.response.helper.b.cR(adTemplate) : 1000L;
        this.yV = jCR > 0 ? jCR : 1000L;
    }

    public final void Q(boolean z) {
        ShowActionBarResult showActionBarResultR = R(z);
        com.kwad.sdk.core.d.c.d("ActionBarControl", "showActionBarOnVideoStart result: " + showActionBarResultR);
        if (showActionBarResultR != ShowActionBarResult.SHOW_H5_FAILURE) {
            return;
        }
        this.jc.postDelayed(new bi() { // from class: com.kwad.components.ad.reward.presenter.platdetail.actionbar.RewardActionBarControl.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                RewardActionBarControl.a(RewardActionBarControl.this, true);
                com.kwad.sdk.core.d.c.d("ActionBarControl", "mHasOutTime");
                if (RewardActionBarControl.this.yS == null || RewardActionBarControl.this.yX || !RewardActionBarControl.this.yS.f(RewardActionBarControl.this.yU)) {
                    com.kwad.sdk.core.d.c.d("ActionBarControl", "showWebActionBar out " + RewardActionBarControl.this.yV);
                    com.kwad.components.core.p.a.vX().j(RewardActionBarControl.this.mAdTemplate, RewardActionBarControl.this.yV);
                    com.kwad.components.ad.reward.monitor.d.a(RewardActionBarControl.this.ub.mAdTemplate, RewardActionBarControl.this.ub.sG, "play_card", com.kwad.sdk.core.response.helper.b.cQ(RewardActionBarControl.this.ub.mAdTemplate), RewardActionBarControl.this.yV, 1);
                    RewardActionBarControl.this.S(true);
                    return;
                }
                com.kwad.sdk.core.d.c.d("ActionBarControl", "showWebActionBar success on " + RewardActionBarControl.this.yV);
            }
        }, this.yV);
    }

    public final void jA() {
        if (this.yW) {
            com.kwad.sdk.core.d.c.i("ActionBarControl", "showWebActionBar time out on pageStatus");
        } else {
            this.jc.removeCallbacksAndMessages(null);
            R(true);
        }
    }

    private ShowActionBarResult R(boolean z) {
        c cVar;
        if (com.kwad.components.ad.reward.a.b.j(this.mAdInfo) && (cVar = this.yT) != null) {
            cVar.e(this.yU);
            return ShowActionBarResult.SHOW_ORDER;
        }
        if (!com.kwad.sdk.core.response.helper.b.cS(this.mAdTemplate) || com.kwad.sdk.core.response.helper.a.bj(this.mAdInfo) || this.yS == null) {
            S(z);
            return ShowActionBarResult.SHOW_NATIVE_DEFAULT;
        }
        com.kwad.sdk.core.d.c.d("ActionBarControl", "showWebActionBar success in " + this.yV);
        if (this.yS.f(this.yU)) {
            return ShowActionBarResult.SHOW_H5_SUCCESS;
        }
        return ShowActionBarResult.SHOW_H5_FAILURE;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void S(boolean z) {
        if (this.yO != null) {
            com.kwad.sdk.core.d.c.d("ActionBarControl", "showNativeActionBar");
            this.yX = true;
            this.yO.a(z, this.yU);
        }
    }

    public final void a(b bVar) {
        this.yO = bVar;
    }

    public final void a(d dVar) {
        this.yS = dVar;
    }

    public final void a(c cVar) {
        this.yT = cVar;
    }

    public final void a(com.kwad.components.ad.reward.presenter.platdetail.actionbar.a aVar) {
        this.yU.c(aVar);
    }

    public final void b(com.kwad.components.ad.reward.presenter.platdetail.actionbar.a aVar) {
        this.yU.d(aVar);
    }

    public final ShowActionBarResult jB() {
        return this.yU.zd;
    }

    public static void a(final com.kwad.components.ad.reward.presenter.platdetail.actionbar.a aVar, final View view, final ShowActionBarResult showActionBarResult) {
        if (aVar != null) {
            view.post(new bi() { // from class: com.kwad.components.ad.reward.presenter.platdetail.actionbar.RewardActionBarControl.2
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    aVar.a(showActionBarResult, view);
                }
            });
        }
    }

    static class a implements com.kwad.components.ad.reward.presenter.platdetail.actionbar.a {
        private List<com.kwad.components.ad.reward.presenter.platdetail.actionbar.a> zc;
        private ShowActionBarResult zd;

        private a() {
            this.zc = new CopyOnWriteArrayList();
        }

        /* synthetic */ a(byte b) {
            this();
        }

        public final void c(com.kwad.components.ad.reward.presenter.platdetail.actionbar.a aVar) {
            this.zc.add(aVar);
        }

        public final void d(com.kwad.components.ad.reward.presenter.platdetail.actionbar.a aVar) {
            this.zc.remove(aVar);
        }

        @Override // com.kwad.components.ad.reward.presenter.platdetail.actionbar.a
        public final void a(ShowActionBarResult showActionBarResult, View view) {
            com.kwad.sdk.core.d.c.d("ActionBarControl", "onActionBarShown result: " + showActionBarResult);
            this.zd = showActionBarResult;
            Iterator<com.kwad.components.ad.reward.presenter.platdetail.actionbar.a> it = this.zc.iterator();
            while (it.hasNext()) {
                it.next().a(showActionBarResult, view);
            }
        }
    }
}

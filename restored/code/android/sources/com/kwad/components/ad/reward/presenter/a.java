package com.kwad.components.ad.reward.presenter;

import android.view.ViewStub;
import android.widget.FrameLayout;
import com.kwad.components.ad.reward.RewardRenderResult;
import com.kwad.components.core.video.DetailVideoView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.utils.as;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends b {
    private com.kwad.components.core.video.m jX = new com.kwad.components.core.video.m() { // from class: com.kwad.components.ad.reward.presenter.a.1
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, long j2) {
            a.this.ub.sW = j2;
        }
    };
    private DetailVideoView mDetailVideoView;

    public a(com.kwad.components.ad.reward.g gVar) {
        this.ub = gVar;
        this.mAdTemplate = gVar.mAdTemplate;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        ViewStub viewStub = (ViewStub) findViewById(R.id.ksad_native_container_stub);
        if (viewStub != null) {
            viewStub.inflate();
        }
        this.mDetailVideoView = (DetailVideoView) findViewById(R.id.ksad_video_player);
        n(this.ub);
        if (RewardRenderResult.DEFAULT.equals(this.ub.hc())) {
            com.kwad.components.ad.reward.g.a(getContext(), this.ub, (FrameLayout) findViewById(R.id.ksad_reward_play_layout));
        }
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        getContext();
        boolean z = !as.VV();
        if ((iC() || iE()) && z) {
            this.mDetailVideoView.setForce(true);
        }
        this.mDetailVideoView.g(true, com.kwad.sdk.core.config.e.KJ());
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onDestroy() {
        super.onDestroy();
        if (this.ub.sr != null) {
            this.ub.sr.b(this.jX);
        }
    }

    private boolean iC() {
        return com.kwad.sdk.core.response.helper.e.m(this.mAdTemplate, com.kwad.components.ad.reward.a.b.l(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate)));
    }

    private boolean iE() {
        return com.kwad.sdk.core.response.helper.e.O(this.mAdTemplate);
    }

    private void n(com.kwad.components.ad.reward.g gVar) {
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate);
        com.kwad.components.ad.reward.m.e eVar = gVar.sr;
        if (com.kwad.sdk.core.response.helper.a.bj(adInfoEM)) {
            com.kwad.components.ad.reward.m.b bVar = new com.kwad.components.ad.reward.m.b(this.mAdTemplate);
            eVar.a(3, bVar);
            gVar.a(bVar);
        } else {
            com.kwad.components.ad.reward.m.d dVar = new com.kwad.components.ad.reward.m.d(gVar, this.mDetailVideoView);
            eVar.a(1, dVar);
            gVar.a(dVar);
        }
        eVar.a(this.jX);
    }
}

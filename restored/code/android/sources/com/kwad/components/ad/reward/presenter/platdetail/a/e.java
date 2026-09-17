package com.kwad.components.ad.reward.presenter.platdetail.a;

import android.view.View;
import android.widget.ImageView;
import com.kwad.components.ad.reward.e.g;
import com.kwad.components.ad.reward.e.j;
import com.kwad.components.ad.reward.e.n;
import com.kwad.components.core.playable.PlayableSource;
import com.kwad.sdk.R;
import com.kwad.sdk.utils.as;

/* JADX INFO: loaded from: classes3.dex */
public final class e extends com.kwad.components.ad.reward.presenter.b implements j {
    private g mPlayEndPageListener = new com.kwad.components.ad.reward.e.a() { // from class: com.kwad.components.ad.reward.presenter.platdetail.a.e.1
        @Override // com.kwad.components.ad.reward.e.g
        public final void cZ() {
            e.this.jN();
        }
    };
    private View zJ;
    private View zK;
    private ImageView zL;

    @Override // com.kwad.components.ad.reward.e.j
    public final void a(PlayableSource playableSource, n nVar) {
    }

    public e() {
        a(new com.kwad.components.ad.reward.presenter.platdetail.a());
        a(new com.kwad.components.ad.reward.presenter.d.a());
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.zJ = findViewById(R.id.ksad_play_detail_top_toolbar);
        this.zK = findViewById(R.id.ksad_play_end_top_toolbar);
        this.zL = (ImageView) findViewById(R.id.ksad_blur_end_cover);
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.zJ.setVisibility(0);
        this.zK.setVisibility(8);
        this.ub.b(this.mPlayEndPageListener);
        com.kwad.components.ad.reward.a.gq().a(this);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        jM();
        this.ub.c(this.mPlayEndPageListener);
        com.kwad.components.ad.reward.a.gq().b(this);
        this.zK.setVisibility(8);
    }

    private void jM() {
        if (!this.ub.sI) {
            this.zK.setVisibility(8);
        }
        this.zJ.setVisibility(0);
        getContext();
        if (com.kwad.components.ad.reward.g.O(this.ub.mAdTemplate) && as.VV()) {
            this.zL.setVisibility(8);
        }
    }

    public final void jN() {
        if (this.ub.sI) {
            this.zJ.setVisibility(8);
        } else {
            this.zJ.setVisibility(8);
            this.zK.setVisibility(0);
        }
        getContext();
        if (com.kwad.components.ad.reward.g.O(this.ub.mAdTemplate) && as.VV()) {
            this.zL.setVisibility(0);
        }
    }

    @Override // com.kwad.components.ad.reward.e.j
    /* JADX INFO: renamed from: do */
    public final void mo174do() {
        jM();
    }

    @Override // com.kwad.components.ad.reward.e.j
    public final void dp() {
        jN();
    }
}

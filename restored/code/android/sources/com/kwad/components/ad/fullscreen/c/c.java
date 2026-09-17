package com.kwad.components.ad.fullscreen.c;

import android.view.View;
import com.kwad.components.ad.fullscreen.c.a.e;
import com.kwad.components.ad.reward.e.g;
import com.kwad.components.ad.reward.e.j;
import com.kwad.components.ad.reward.e.n;
import com.kwad.components.core.playable.PlayableSource;
import com.kwad.sdk.R;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends com.kwad.components.ad.reward.presenter.b implements j {
    private View kk;
    private View kl;
    private g mPlayEndPageListener = new com.kwad.components.ad.reward.e.a() { // from class: com.kwad.components.ad.fullscreen.c.c.1
        @Override // com.kwad.components.ad.reward.e.g
        public final void cZ() {
            c.this.j(false);
        }
    };

    @Override // com.kwad.components.ad.reward.e.j
    public final void a(PlayableSource playableSource, n nVar) {
    }

    public c() {
        a(new e());
        a(new com.kwad.components.ad.fullscreen.c.b.a());
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.kk = findViewById(R.id.ksad_play_detail_top_toolbar);
        this.kl = findViewById(R.id.ksad_play_end_top_toolbar);
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.ub.b(this.mPlayEndPageListener);
        com.kwad.components.ad.reward.a.gq().a(this);
        this.kk.setVisibility(0);
        this.kl.setVisibility(8);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.ub.c(this.mPlayEndPageListener);
        com.kwad.components.ad.reward.a.gq().b(this);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void j(boolean z) {
        if ((this.ub.sI || this.ub.sH) && !z) {
            this.kk.setVisibility(8);
            this.kl.setVisibility(8);
        } else {
            this.kk.setVisibility(8);
            this.kl.setVisibility(0);
        }
    }

    private void dn() {
        if (this.ub.sI || this.ub.sH) {
            return;
        }
        this.kk.setVisibility(0);
        this.kl.setVisibility(8);
    }

    @Override // com.kwad.components.ad.reward.e.j
    /* JADX INFO: renamed from: do, reason: not valid java name */
    public final void mo174do() {
        dn();
        if (this.ub.sH && this.kl.getVisibility() == 0) {
            this.kl.setVisibility(8);
        }
    }

    @Override // com.kwad.components.ad.reward.e.j
    public final void dp() {
        j(true);
    }
}

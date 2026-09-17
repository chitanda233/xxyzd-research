package com.kwad.components.ad.reward.presenter.d.b;

import android.view.View;
import com.kwad.components.ad.reward.presenter.f;
import com.kwad.components.core.playable.PlayableSource;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.components.ad.reward.presenter.b implements View.OnClickListener, c {
    private View Ac;
    private boolean Ad;
    private final Runnable Ae = new Runnable() { // from class: com.kwad.components.ad.reward.presenter.d.b.b.1
        @Override // java.lang.Runnable
        public final void run() {
            if (b.this.getActivity() == null || b.this.getActivity().isFinishing()) {
                return;
            }
            b.this.jZ();
        }
    };

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        View viewFindViewById = findViewById(R.id.ksad_end_close_btn);
        this.Ac = viewFindViewById;
        viewFindViewById.setOnClickListener(this);
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.Ad = com.kwad.sdk.core.response.helper.b.eH(e.eM(this.ub.mAdTemplate));
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.Ac.setVisibility(8);
        by.b(this.Ae);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void jZ() {
        com.kwad.sdk.core.d.c.d("RewardPlayEndCloseBtn", "showPageCloseBtn mPlayEndH5ShowSuccess: " + this.ub.tk + ", needHideCloseButton: " + this.Ad);
        if (this.ub.tk && this.Ad) {
            return;
        }
        this.Ac.setVisibility(0);
        this.Ac.setAlpha(0.0f);
        this.Ac.animate().alpha(1.0f).setDuration(500L).start();
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (view == this.Ac) {
            PlayableSource playableSourceGZ = this.ub.gZ();
            if (playableSourceGZ != null && (playableSourceGZ.equals(PlayableSource.PENDANT_CLICK_NOT_AUTO) || playableSourceGZ.equals(PlayableSource.PENDANT_CLICK_AUTO) || playableSourceGZ.equals(PlayableSource.PENDANT_AUTO) || playableSourceGZ.equals(PlayableSource.ACTIONBAR_CLICK))) {
                com.kwad.components.ad.reward.a.gq().gr();
            } else {
                f.v(this.ub);
            }
        }
    }

    @Override // com.kwad.components.ad.reward.presenter.d.b.c
    public final void jY() {
        if (this.ub.sT) {
            return;
        }
        long j = this.ub.te;
        if (j == 0) {
            this.Ae.run();
        } else {
            by.runOnUiThreadDelay(this.Ae, j);
        }
    }
}

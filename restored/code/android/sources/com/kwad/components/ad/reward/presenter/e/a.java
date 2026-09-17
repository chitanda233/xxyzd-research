package com.kwad.components.ad.reward.presenter.e;

import android.widget.FrameLayout;
import com.kwad.components.ad.reward.page.BackPressHandleResult;
import com.kwad.components.ad.reward.presenter.f.g;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.tachikoma.TKRenderFailReason;
import com.kwad.sdk.R;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.core.response.helper.b;
import com.kwad.sdk.core.response.model.AdMatrixInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.bt;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends g implements com.kwad.components.ad.reward.k.a {
    private AdMatrixInfo.PreLandingPageTKInfo Am;
    private az An;
    private boolean rD = false;
    private com.kwad.components.ad.reward.e.g Ao = new com.kwad.components.ad.reward.e.a() { // from class: com.kwad.components.ad.reward.presenter.e.a.1
        @Override // com.kwad.components.ad.reward.e.g
        public final void cZ() {
            c.d("TKPreFormPresenter", "handleToSkip PlayEndPageListener onPlayEndPageShow: " + a.this.ub.sL);
            if (a.this.ub.sL) {
                return;
            }
            a.this.kc();
        }
    };

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void f(AdTemplate adTemplate) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTKReaderScene() {
        return "tk_pre_landing_page";
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.Am = b.dX(this.ub.mAdTemplate);
        this.ub.b(this.Ao);
        this.ub.a((com.kwad.components.ad.reward.k.a) this);
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.ub.c(this.Ao);
        this.ub.b((com.kwad.components.ad.reward.k.a) this);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTkTemplateId() {
        return b.eq(this.ub.mAdTemplate);
    }

    @Override // com.kwad.components.ad.reward.presenter.f.g
    public final int jh() {
        return R.id.ksad_pre_form_card;
    }

    @Override // com.kwad.components.ad.reward.presenter.f.g
    public final void a(FrameLayout frameLayout) {
        frameLayout.setVisibility(4);
        frameLayout.setClickable(false);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(ae.a aVar) {
        float fBA = com.kwad.sdk.c.a.a.bA(getContext());
        aVar.width = (int) ((bt.getScreenWidth(getContext()) / fBA) + 0.5f);
        aVar.height = (int) ((bt.getScreenHeight(getContext()) / fBA) + 0.5f);
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(az azVar) {
        super.a(azVar);
        this.An = azVar;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void kc() {
        if (!this.rD || this.Am == null) {
            return;
        }
        c.d("TKPreFormPresenter", "handleToSkip handleToPlayEnd isPlayEndShow: " + this.Am.isPlayEndShow());
        if (this.Am.isPlayEndShow()) {
            U(true);
        }
    }

    private void kd() {
        if (!this.rD || this.Am == null) {
            return;
        }
        c.d("TKPreFormPresenter", "handleToSkip mPreLandingPageData isSkipShow: " + this.Am.isSkipShow());
        if (this.Am.isSkipShow()) {
            U(true);
        }
    }

    public final BackPressHandleResult hH() {
        if (this.Az == null || this.AS == null) {
            return BackPressHandleResult.NOT_HANDLED;
        }
        if (this.AS.getVisibility() == 0) {
            return this.Az.hH();
        }
        return BackPressHandleResult.NOT_HANDLED;
    }

    private void U(final boolean z) {
        c.d("TKPreFormPresenter", "switchPreForm: " + z);
        this.AS.post(new bi() { // from class: com.kwad.components.ad.reward.presenter.e.a.2
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                a.this.AS.setVisibility(z ? 0 : 4);
                a.this.AS.setClickable(z);
                if (a.this.An != null) {
                    if (z) {
                        a.this.An.yJ();
                        a.this.An.yK();
                    } else {
                        a.this.An.yL();
                        a.this.An.yM();
                    }
                }
            }
        });
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void aB() {
        super.aB();
        c.d("TKPreFormPresenter", "onTkLoadSuccess");
        this.rD = true;
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(TKRenderFailReason tKRenderFailReason) {
        super.a(tKRenderFailReason);
        this.rD = false;
        c.d("TKPreFormPresenter", "onTkLoadFailed");
        U(false);
    }

    @Override // com.kwad.components.ad.reward.k.a
    public final void ke() {
        c.d("TKPreFormPresenter", "onPlayComplete: ");
        kc();
    }

    @Override // com.kwad.components.ad.reward.k.a
    public final void kf() {
        c.d("TKPreFormPresenter", "onSkipClick: ");
        kd();
    }
}

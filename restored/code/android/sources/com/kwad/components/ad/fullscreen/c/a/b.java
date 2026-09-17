package com.kwad.components.ad.fullscreen.c.a;

import android.text.TextUtils;
import android.view.View;
import android.widget.TextView;
import com.kwad.components.core.video.m;
import com.kwad.sdk.R;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.components.ad.reward.presenter.b implements View.OnClickListener {
    private m jX = new m() { // from class: com.kwad.components.ad.fullscreen.c.a.b.1
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, long j2) {
            b.this.k(j2);
        }
    };
    private TextView ks;
    private String kt;
    private long ku;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.ks = (TextView) findViewById(R.id.ksad_detail_call_btn);
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        dq();
    }

    private void dq() {
        this.ku = com.kwad.sdk.core.response.helper.d.ey(this.mAdTemplate);
        String strEz = com.kwad.sdk.core.response.helper.d.ez(this.mAdTemplate);
        this.kt = strEz;
        if (TextUtils.isEmpty(strEz)) {
            return;
        }
        this.mApkDownloadHelper = this.ub.mApkDownloadHelper;
        this.ub.sr.a(this.jX);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        if (TextUtils.isEmpty(this.kt)) {
            return;
        }
        this.ub.sr.b(this.jX);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onDestroy() {
        super.onDestroy();
        this.ks = null;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void k(long j) {
        if (j >= this.ku) {
            dr();
        }
    }

    private void dr() {
        if (this.ks.getVisibility() == 0) {
            return;
        }
        this.ks.setText(com.kwad.sdk.core.response.helper.d.ez(this.mAdTemplate));
        this.ks.setVisibility(0);
        this.ks.setOnClickListener(this);
        ds();
    }

    private void ds() {
        com.kwad.sdk.core.adlog.c.b(this.mAdTemplate, 18, this.ub.mReportExtData);
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (view == this.ks) {
            com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(view.getContext()).aF(this.mAdTemplate).b(this.mApkDownloadHelper).aC(40).aB(1).as(false).an(this.ub.gS()).aD(1).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.fullscreen.c.a.b.2
                @Override // com.kwad.components.core.e.d.a.b
                public final void onAdClicked() {
                    b.this.notifyAdClick();
                }
            }));
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void notifyAdClick() {
        com.kwad.sdk.core.adlog.c.a(this.mAdTemplate, new com.kwad.sdk.core.adlog.c.b().f(this.ub.mRootContainer.getTouchCoords()).dS(40), this.ub.mReportExtData);
        this.ub.sq.cY();
    }
}

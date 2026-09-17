package com.kwad.components.ad.reward.presenter.d.b;

import android.view.View;
import android.widget.TextView;
import com.kwad.sdk.R;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends com.kwad.components.ad.reward.presenter.b implements View.OnClickListener, c {
    private TextView Aa;
    private TextView zZ;

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.zZ = (TextView) findViewById(R.id.ksad_end_left_call_btn);
        this.Aa = (TextView) findViewById(R.id.ksad_end_right_call_btn);
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.zZ.setVisibility(8);
        this.Aa.setVisibility(8);
    }

    private void jW() {
        String strEA = com.kwad.sdk.core.response.helper.d.eA(this.ub.mAdTemplate);
        if (this.ub.mScreenOrientation == 1) {
            this.Aa.setVisibility(8);
            this.zZ.setText(strEA);
            this.zZ.setVisibility(0);
            this.zZ.setOnClickListener(this);
        } else {
            this.zZ.setVisibility(8);
            this.Aa.setText(strEA);
            this.Aa.setVisibility(0);
            this.Aa.setOnClickListener(this);
        }
        ds();
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (view == this.zZ || view == this.Aa) {
            com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(view.getContext()).aF(this.ub.mAdTemplate).b(this.ub.mApkDownloadHelper).as(false).aD(1).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.reward.presenter.d.b.a.1
                @Override // com.kwad.components.core.e.d.a.b
                public final void onAdClicked() {
                    a.this.jX();
                    a.this.notifyAdClick();
                }
            }));
        }
    }

    private void ds() {
        com.kwad.sdk.core.adlog.c.b(this.ub.mAdTemplate, 17, this.ub.mReportExtData);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void jX() {
        com.kwad.components.ad.reward.j.b.a(this.ub.mAdTemplate, "native_id", "endTopBar", new com.kwad.sdk.core.adlog.c.b().f(this.ub.mRootContainer.getTouchCoords()).dS(39), this.ub.mReportExtData);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void notifyAdClick() {
        this.ub.sq.cY();
    }

    @Override // com.kwad.components.ad.reward.presenter.d.b.c
    public final void jY() {
        if (this.ub.sT) {
            return;
        }
        jW();
    }
}

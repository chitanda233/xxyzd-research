package com.kwad.components.ad.splashscreen.presenter;

import com.kwad.components.core.widget.ComplianceTextView;
import com.kwad.sdk.R;

/* JADX INFO: loaded from: classes3.dex */
public final class f extends e {
    private ComplianceTextView dU;

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.e, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        ComplianceTextView complianceTextView = (ComplianceTextView) findViewById(com.kwad.components.ad.splashscreen.e.c.A(com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate)) ? R.id.ksad_compliance_right_view : R.id.ksad_compliance_left_view);
        this.dU = complianceTextView;
        complianceTextView.setBackgroundColor(0);
        this.dU.setVisibility(0);
        this.dU.setAdTemplate(this.Hu.mAdTemplate);
    }
}

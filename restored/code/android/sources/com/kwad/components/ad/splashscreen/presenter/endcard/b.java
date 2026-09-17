package com.kwad.components.ad.splashscreen.presenter.endcard;

import com.kwad.components.core.widget.ComplianceTextView;
import com.kwad.sdk.R;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.components.ad.splashscreen.presenter.e {
    private ComplianceTextView dU;

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.e, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        ni();
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
    }

    private void ni() {
        if (com.kwad.sdk.core.response.helper.a.aV(com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate))) {
            ComplianceTextView complianceTextView = (ComplianceTextView) findViewById(R.id.ksad_compliance_splash_endcard);
            this.dU = complianceTextView;
            complianceTextView.setBackgroundColor(0);
            this.dU.setVisibility(0);
            this.dU.setAdTemplate(this.Hu.mAdTemplate);
        }
    }
}

package com.kwad.components.ad.reward.presenter.f;

import android.widget.FrameLayout;
import com.kwad.sdk.widget.KSFrameLayout;

/* JADX INFO: loaded from: classes3.dex */
public abstract class g extends d {
    public KSFrameLayout AS;

    protected void a(FrameLayout frameLayout) {
    }

    protected abstract int jh();

    @Override // com.kwad.components.core.webview.tachikoma.j
    public FrameLayout getTKContainer() {
        KSFrameLayout kSFrameLayout = this.AS;
        if (kSFrameLayout != null) {
            return kSFrameLayout;
        }
        KSFrameLayout kSFrameLayout2 = (KSFrameLayout) findViewById(jh());
        this.AS = kSFrameLayout2;
        if (kSFrameLayout2 == null) {
            KSFrameLayout kSFrameLayout3 = new KSFrameLayout(getContext());
            this.AS = kSFrameLayout3;
            kSFrameLayout3.setVisibility(8);
            FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(-1, -1);
            layoutParams.gravity = 17;
            a(this.AS);
            ((FrameLayout) getRootView()).addView(this.AS, layoutParams);
        }
        return this.AS;
    }
}

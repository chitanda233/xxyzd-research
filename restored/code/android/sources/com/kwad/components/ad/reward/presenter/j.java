package com.kwad.components.ad.reward.presenter;

import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public final class j extends b {
    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        try {
            this.ub.sr.lm();
        } catch (Throwable th) {
            by.postOnUiThread(new bi() { // from class: com.kwad.components.ad.reward.presenter.j.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    ServiceProvider.reportSdkCaughtException(th);
                    j.this.iK();
                }
            });
        }
    }
}

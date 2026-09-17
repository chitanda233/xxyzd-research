package com.kwad.components.ad.splashscreen.presenter;

import android.os.SystemClock;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public final class j extends e {
    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        findViewById(R.id.splash_play_card_view).setVisibility(0);
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.e, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        by.postOnUiThread(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.j.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                j.this.de();
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void de() {
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate);
        a(new b(), true);
        a(new c(), true);
        if (com.kwad.sdk.core.response.helper.a.bi(adInfoEM)) {
            a(new d(), true);
            a(new u(), true);
        } else {
            a(new h(), true);
        }
        if (this.Hu.GN) {
            a(new t(), true);
        } else {
            boolean zEd = com.kwad.sdk.core.response.helper.b.ed(adInfoEM);
            boolean zEh = com.kwad.sdk.core.response.helper.b.eh(adInfoEM);
            boolean zEq = com.kwad.sdk.core.response.helper.b.eq(adInfoEM);
            if (com.kwad.sdk.core.response.helper.b.ej(adInfoEM)) {
                a(new r(), true);
            } else if (zEd) {
                a(new o(), true);
            } else if (zEh) {
                a(new m(), true);
            } else if (zEq) {
                a(new t(), true);
            } else {
                a(new t(), true);
            }
        }
        if (com.kwad.sdk.core.response.helper.a.aV(adInfoEM)) {
            a(new f(), true);
        }
        if (!this.Hu.bY) {
            a(new com.kwad.components.ad.splashscreen.presenter.playcard.b(), true);
        }
        a(new a(), true);
        a(new g(), true);
        try {
            if (this.Hu.mStartRenderTime > 0) {
                com.kwad.sdk.commercial.convert.d.b(com.kwad.sdk.core.response.helper.e.eG(this.Hu.mAdTemplate), 1, SystemClock.elapsedRealtime() - this.Hu.mStartRenderTime);
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }
}

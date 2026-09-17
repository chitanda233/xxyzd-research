package com.kwad.components.ad.splashscreen.presenter.endcard;

import android.widget.FrameLayout;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.jshandler.z;
import com.kwad.components.core.webview.tachikoma.TKRenderFailReason;
import com.kwad.sdk.R;
import com.kwad.sdk.commercial.model.WebCloseStatus;
import com.kwad.sdk.components.t;
import com.kwad.sdk.utils.bi;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class h extends com.kwad.components.ad.splashscreen.presenter.a.c implements com.kwad.sdk.core.j.c {
    private FrameLayout dg;
    private az di;

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTKReaderScene() {
        return "tk_splash_end_card";
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.dg = (FrameLayout) findViewById(R.id.splash_end_card_view);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTkTemplateId() {
        return com.kwad.sdk.core.response.helper.b.ei(this.Hu.mAdTemplate);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final FrameLayout getTKContainer() {
        return this.dg;
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.a.c, com.kwad.components.ad.splashscreen.presenter.e, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.Hu.GH.a(this);
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.a.c, com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        az azVar = this.di;
        if (azVar != null) {
            azVar.yL();
            this.di.yM();
        }
        super.onUnbind();
        this.Hu.GH.b(this);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(TKRenderFailReason tKRenderFailReason) {
        az azVar = this.di;
        if (azVar != null) {
            azVar.yL();
            this.di.yM();
        }
        nA();
        this.dg.setVisibility(8);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void aB() {
        az azVar = this.di;
        if (azVar != null) {
            azVar.yJ();
            this.di.yK();
        }
        nA();
        this.dg.setVisibility(0);
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.a.c, com.kwad.components.core.webview.tachikoma.j
    public final void a(WebCloseStatus webCloseStatus) {
        super.a(webCloseStatus);
        ap(webCloseStatus.closeType);
        if (webCloseStatus.closeType == 2) {
            this.Hu.mq();
        } else {
            com.kwad.components.ad.splashscreen.monitor.a.mr().ak(this.Hu.mAdTemplate);
            this.Hu.mm();
        }
    }

    private void ap(int i) {
        com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
        if (this.Hu.mTimerHelper != null) {
            c0502a.duration = this.Hu.mTimerHelper.getTime();
        }
        com.kwad.sdk.core.adlog.c.b bVarB = new com.kwad.sdk.core.adlog.c.b().eb(6).b(c0502a);
        if (i == 2) {
            bVarB.dT(14);
        } else {
            bVarB.dT(1);
        }
        com.kwad.sdk.core.adlog.c.b(this.Hu.mAdTemplate, bVarB, (JSONObject) null);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(ae.a aVar) {
        aVar.width = com.kwad.sdk.c.a.a.px2dip(getContext(), this.Hu.mRootContainer.getWidth());
        aVar.height = com.kwad.sdk.c.a.a.px2dip(getContext(), this.Hu.mRootContainer.getHeight());
    }

    private void nA() {
        try {
            this.Hu.mRootContainer.findViewById(R.id.splash_play_card_view).setVisibility(8);
        } catch (NullPointerException e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
        }
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.a.c, com.kwad.components.core.webview.tachikoma.j
    public final void a(az azVar) {
        super.a(azVar);
        this.di = azVar;
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.a.c, com.kwad.components.core.webview.tachikoma.j
    public final void a(t tVar, com.kwad.sdk.core.webview.b bVar) {
        super.a(tVar, bVar);
        tVar.c(a(bVar));
    }

    private z a(com.kwad.sdk.core.webview.b bVar) {
        return new z(bVar, this.Hu.mApkDownloadHelper, new com.kwad.sdk.core.webview.d.a.a() { // from class: com.kwad.components.ad.splashscreen.presenter.endcard.h.1
            @Override // com.kwad.sdk.core.webview.d.a.a
            public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
                if (aVar != null) {
                    h.this.Hu.mRootContainer.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.endcard.h.1.1
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            h.this.Hu.ab();
                        }
                    });
                }
            }
        });
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bv() {
        az azVar = this.di;
        if (azVar != null) {
            azVar.yN();
        }
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bw() {
        az azVar = this.di;
        if (azVar != null) {
            azVar.yO();
        }
    }
}

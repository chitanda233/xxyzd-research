package com.kwad.components.ad.splashscreen.presenter.playcard;

import android.os.SystemClock;
import android.widget.FrameLayout;
import com.kwad.components.ad.splashscreen.f;
import com.kwad.components.ad.splashscreen.g;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.jshandler.z;
import com.kwad.components.core.webview.tachikoma.TKRenderFailReason;
import com.kwad.components.core.webview.tachikoma.b.m;
import com.kwad.sdk.R;
import com.kwad.sdk.components.t;
import com.kwad.sdk.core.response.helper.e;

/* JADX INFO: loaded from: classes3.dex */
public final class d extends com.kwad.components.ad.splashscreen.presenter.a.c implements g, com.kwad.sdk.core.j.c {
    f JR = new f() { // from class: com.kwad.components.ad.splashscreen.presenter.playcard.d.2
        @Override // com.kwad.components.ad.splashscreen.f
        public final void lW() {
            d.this.dg.setVisibility(8);
            if (d.this.di != null) {
                d.this.di.yL();
                d.this.di.yM();
            }
        }
    };
    private m Kv;
    private FrameLayout dg;
    private az di;

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTKReaderScene() {
        return "tk_splash";
    }

    @Override // com.kwad.components.ad.splashscreen.g
    public final void ma() {
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.dg = (FrameLayout) findViewById(R.id.splash_tk_play_card_view);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTkTemplateId() {
        return com.kwad.sdk.core.response.helper.b.eh(this.Hu.mAdTemplate);
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.a.c
    public final int nI() {
        return (int) (com.kwad.sdk.core.response.helper.b.dT(e.eM(this.Hu.mAdTemplate)) - (SystemClock.elapsedRealtime() - this.Hu.GO));
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final FrameLayout getTKContainer() {
        return this.dg;
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.a.c, com.kwad.components.ad.splashscreen.presenter.e, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        com.kwad.components.ad.splashscreen.monitor.b.mt();
        com.kwad.components.ad.splashscreen.monitor.b.b(this.Hu.mAdTemplate, this.Hu.GG);
        this.Hu.GH.a(this);
        this.Hu.a(this);
        this.Hu.a(this.JR);
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
        this.Hu.b(this.JR);
        this.Hu.b(this);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(TKRenderFailReason tKRenderFailReason) {
        az azVar = this.di;
        if (azVar != null) {
            azVar.yL();
            this.di.yM();
        }
        this.dg.setVisibility(8);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void aB() {
        if (this.Hu.bY) {
            return;
        }
        az azVar = this.di;
        if (azVar != null) {
            azVar.yJ();
            this.di.yK();
        }
        this.dg.setVisibility(0);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(ae.a aVar) {
        aVar.width = com.kwad.sdk.c.a.a.px2dip(getContext(), this.Hu.mRootContainer.getWidth());
        aVar.height = com.kwad.sdk.c.a.a.px2dip(getContext(), this.Hu.mRootContainer.getHeight());
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
        tVar.c(nJ());
    }

    private m nJ() {
        m mVar = new m();
        this.Kv = mVar;
        return mVar;
    }

    private z a(com.kwad.sdk.core.webview.b bVar) {
        return new z(bVar, this.Hu.mApkDownloadHelper, new com.kwad.sdk.core.webview.d.a.a() { // from class: com.kwad.components.ad.splashscreen.presenter.playcard.d.1
            @Override // com.kwad.sdk.core.webview.d.a.a
            public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
                if (aVar != null) {
                    d.this.Hu.mRootContainer.post(new Runnable() { // from class: com.kwad.components.ad.splashscreen.presenter.playcard.d.1.1
                        @Override // java.lang.Runnable
                        public final void run() {
                            d.this.Hu.ab();
                        }
                    });
                }
            }
        });
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bv() {
        az azVar;
        if (this.Hu.bY || (azVar = this.di) == null) {
            return;
        }
        azVar.yN();
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bw() {
        az azVar;
        if (this.Hu.bY || (azVar = this.di) == null) {
            return;
        }
        azVar.yO();
    }

    @Override // com.kwad.components.ad.splashscreen.g
    public final void am(int i) {
        m mVar = this.Kv;
        if (mVar != null) {
            mVar.bY(i);
        }
    }
}

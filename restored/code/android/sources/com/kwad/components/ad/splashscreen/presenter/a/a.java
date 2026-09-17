package com.kwad.components.ad.splashscreen.presenter.a;

import android.os.SystemClock;
import android.text.TextUtils;
import android.widget.FrameLayout;
import com.kwad.components.ad.splashscreen.f;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.jshandler.j;
import com.kwad.components.core.webview.jshandler.p;
import com.kwad.components.core.webview.jshandler.z;
import com.kwad.components.core.webview.tachikoma.TKRenderFailReason;
import com.kwad.components.core.webview.tachikoma.b.m;
import com.kwad.components.core.webview.tachikoma.b.u;
import com.kwad.sdk.R;
import com.kwad.sdk.components.t;
import com.kwad.sdk.utils.bi;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends c implements com.kwad.sdk.core.j.c {
    private m Kv;
    private FrameLayout dg;
    private az di;
    private boolean Ky = false;
    f JR = new f() { // from class: com.kwad.components.ad.splashscreen.presenter.a.a.4
        @Override // com.kwad.components.ad.splashscreen.f
        public final void lW() {
            a.this.dg.postDelayed(new Runnable() { // from class: com.kwad.components.ad.splashscreen.presenter.a.a.4.1
                @Override // java.lang.Runnable
                public final void run() {
                    a.this.dg.setVisibility(8);
                }
            }, 500L);
            if (a.this.di != null) {
                a.this.di.yL();
                a.this.di.yM();
            }
        }
    };

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTKReaderScene() {
        return "tk_splash";
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.dg = (FrameLayout) findViewById(R.id.splash_full_tk_play_card_view);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTkTemplateId() {
        return com.kwad.sdk.core.response.helper.b.cL(this.Hu.mAdTemplate).splashPlayCardTKInfo.templateId;
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.a.c
    protected final int nI() {
        return (int) (com.kwad.sdk.core.response.helper.b.dS(this.Hu.mAdTemplate) - (SystemClock.elapsedRealtime() - this.Hu.GO));
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
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(TKRenderFailReason tKRenderFailReason) {
        az azVar = this.di;
        if (azVar != null) {
            azVar.yL();
            this.di.yM();
        }
        this.dg.setVisibility(8);
        nK();
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void aB() {
        az azVar;
        if (this.Hu.bY) {
            return;
        }
        az azVar2 = this.di;
        if (azVar2 != null) {
            azVar2.yJ();
            this.di.yK();
        }
        if (this.Ky && (azVar = this.di) != null) {
            azVar.yN();
        }
        this.dg.setVisibility(0);
    }

    private void nK() {
        if (this.Hu.GF != null) {
            this.Hu.GF.nN();
        }
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
        tVar.c(nL());
        tVar.c(new j(new p() { // from class: com.kwad.components.ad.splashscreen.presenter.a.a.1
            @Override // com.kwad.components.core.webview.jshandler.p
            public final void a(j jVar, String str) {
                if (TextUtils.equals(str, "getSplashShowStartTime")) {
                    jVar.S(a.this.Hu.mAdTemplate.showTime);
                }
            }
        }));
    }

    private m nJ() {
        m mVar = new m();
        this.Kv = mVar;
        return mVar;
    }

    private z a(com.kwad.sdk.core.webview.b bVar) {
        return new z(bVar, this.Hu.mApkDownloadHelper, new com.kwad.sdk.core.webview.d.a.a() { // from class: com.kwad.components.ad.splashscreen.presenter.a.a.2
            @Override // com.kwad.sdk.core.webview.d.a.a
            public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
                if (aVar != null) {
                    a.this.Hu.mRootContainer.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.a.a.2.1
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            a.this.Hu.ab();
                        }
                    });
                }
            }
        });
    }

    private u nL() {
        u uVar = new u();
        uVar.a(new u.a() { // from class: com.kwad.components.ad.splashscreen.presenter.a.a.3
            @Override // com.kwad.components.core.webview.tachikoma.b.u.a
            public final void a(final u.b bVar) {
                int i = bVar.status;
                if (i == 1) {
                    a.this.Hu.mRootContainer.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.a.a.3.1
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            if (com.kwad.components.core.e.c.b.pF()) {
                                a.this.Hu.mRootContainer.postDelayed(this, 1000L);
                            } else {
                                a.this.Hu.mk();
                            }
                        }
                    });
                    return;
                }
                if (i == 2) {
                    a.this.Hu.mRootContainer.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.a.a.3.2
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            com.kwad.components.ad.splashscreen.monitor.a.mr().ak(a.this.Hu.mAdTemplate);
                            a.this.Hu.mm();
                        }
                    });
                } else if (i == 3) {
                    a.this.Hu.mRootContainer.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.a.a.3.3
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            a.this.Hu.mb();
                        }
                    });
                } else if (i == 4) {
                    a.this.Hu.mRootContainer.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.a.a.3.4
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            a.this.Hu.c(bVar.errorCode, bVar.errorMsg);
                        }
                    });
                }
            }
        });
        return uVar;
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bv() {
        if (this.Hu.bY) {
            return;
        }
        az azVar = this.di;
        if (azVar != null) {
            azVar.yN();
        } else {
            this.Ky = true;
        }
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bw() {
        az azVar;
        if (this.Hu.bY || (azVar = this.di) == null) {
            return;
        }
        azVar.yO();
    }
}

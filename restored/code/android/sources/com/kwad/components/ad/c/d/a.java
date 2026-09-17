package com.kwad.components.ad.c.d;

import android.content.Context;
import android.os.SystemClock;
import android.view.View;
import android.view.ViewGroup;
import android.widget.FrameLayout;
import com.kwad.components.core.internal.api.KSAdVideoPlayConfigImpl;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.jshandler.z;
import com.kwad.components.core.webview.tachikoma.TKRenderFailReason;
import com.kwad.components.core.webview.tachikoma.b.o;
import com.kwad.components.core.webview.tachikoma.c.n;
import com.kwad.sdk.R;
import com.kwad.sdk.commercial.convert.d;
import com.kwad.sdk.commercial.model.WebCloseStatus;
import com.kwad.sdk.components.t;
import com.kwad.sdk.core.config.e;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bi;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends c {
    private boolean cA;
    private FrameLayout dg;
    private boolean dh;
    private az di;
    private o dj;
    private Context mContext;

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTKReaderScene() {
        return "tk_splash";
    }

    public a(Context context) {
        this.mContext = context.getApplicationContext();
    }

    @Override // com.kwad.components.ad.c.c.a, com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        FrameLayout frameLayout = (FrameLayout) findViewById(R.id.banner_full_tk_card_view);
        this.dg = frameLayout;
        b((ViewGroup) frameLayout.getParent());
    }

    private void b(ViewGroup viewGroup) {
        if (e.Kr() || e.Kq() < 0.0f) {
            return;
        }
        com.kwad.components.core.widget.a aVar = new com.kwad.components.core.widget.a(viewGroup.getContext(), viewGroup);
        viewGroup.addView(aVar);
        aVar.setViewCallback(new com.kwad.components.core.widget.a.InterfaceC0474a() { // from class: com.kwad.components.ad.c.d.a.1
            @Override // com.kwad.components.core.widget.a.InterfaceC0474a
            public final void ae() {
            }

            @Override // com.kwad.components.core.widget.a.InterfaceC0474a
            public final void af() {
            }

            @Override // com.kwad.components.core.widget.a.InterfaceC0474a
            public final void onWindowFocusChanged(boolean z) {
                if (a.this.di != null) {
                    if (z) {
                        a.this.di.yN();
                        n nVar = new n();
                        if (a.this.dh) {
                            a aVar2 = a.this;
                            nVar.auv = !aVar2.f(aVar2.cO.mAdTemplate.mIsAudioEnable);
                        } else {
                            nVar.auv = false;
                        }
                        a.this.dj.c(nVar);
                        return;
                    }
                    a aVar3 = a.this;
                    aVar3.f(aVar3.cO.mAdTemplate.mIsAudioEnable);
                    a.this.di.yO();
                }
            }

            @Override // com.kwad.components.core.widget.a.InterfaceC0474a
            public final void b(View view) {
                com.kwad.sdk.core.d.c.e("BannerFullTKCardPresenter ", "onViewVisible");
            }

            @Override // com.kwad.components.core.widget.a.InterfaceC0474a
            public final void aA() {
                com.kwad.sdk.core.d.c.e("BannerFullTKCardPresenter ", "onViewFirstInVisible");
            }
        });
        aVar.zY();
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTkTemplateId() {
        return com.kwad.sdk.core.response.helper.b.cL(this.cO.mAdTemplate).bannerTKInfo.templateId;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final FrameLayout getTKContainer() {
        return this.dg;
    }

    @Override // com.kwad.components.ad.c.d.c, com.kwad.components.ad.c.c.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
    }

    @Override // com.kwad.components.ad.c.d.c, com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        az azVar = this.di;
        if (azVar != null) {
            azVar.yL();
            this.di.yM();
        }
        super.onUnbind();
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(TKRenderFailReason tKRenderFailReason) {
        az azVar = this.di;
        if (azVar != null) {
            azVar.yL();
            this.di.yM();
        }
        this.dg.setVisibility(8);
        this.cO.bY = true;
        this.cO.bR.ad();
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void aB() {
        if (this.cO.bY) {
            return;
        }
        try {
            if (this.cO.bU > 0) {
                d.b(com.kwad.sdk.core.response.helper.e.eG(this.cO.mAdTemplate), 2, SystemClock.elapsedRealtime() - this.cO.bU);
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
        az azVar = this.di;
        if (azVar != null) {
            azVar.yN();
            this.di.yJ();
            this.di.yK();
        }
        this.dg.setVisibility(0);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(ae.a aVar) {
        aVar.width = com.kwad.sdk.c.a.a.px2dip(getContext(), this.cO.bQ.getWidth());
        aVar.height = com.kwad.sdk.c.a.a.px2dip(getContext(), this.cO.bQ.getHeight());
    }

    @Override // com.kwad.components.ad.c.d.c, com.kwad.components.core.webview.tachikoma.j
    public final void a(az azVar) {
        super.a(azVar);
        this.di = azVar;
    }

    @Override // com.kwad.components.ad.c.d.c, com.kwad.components.core.webview.tachikoma.j
    public final void a(t tVar, com.kwad.sdk.core.webview.b bVar) {
        super.a(tVar, bVar);
        tVar.c(a(bVar));
    }

    private z a(com.kwad.sdk.core.webview.b bVar) {
        return new z(bVar, (com.kwad.components.core.e.d.d) null, new com.kwad.sdk.core.webview.d.a.a() { // from class: com.kwad.components.ad.c.d.a.2
            @Override // com.kwad.sdk.core.webview.d.a.a
            public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
                if (aVar != null) {
                    a.this.cO.bQ.post(new bi() { // from class: com.kwad.components.ad.c.d.a.2.1
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            a.this.cO.ab();
                        }
                    });
                }
            }
        });
    }

    @Override // com.kwad.components.ad.c.d.c, com.kwad.components.core.webview.tachikoma.j
    public final void a(WebCloseStatus webCloseStatus) {
        this.di.yM();
        this.cO.bQ.removeAllViews();
        onDestroy();
        this.cO.ac();
    }

    @Override // com.kwad.components.ad.c.d.c, com.kwad.components.core.webview.tachikoma.j
    public final void a(o oVar) {
        this.dj = oVar;
        oVar.a(new o.a() { // from class: com.kwad.components.ad.c.d.a.3
            @Override // com.kwad.components.core.webview.tachikoma.b.o.a
            public final boolean isMuted() {
                boolean z;
                try {
                    if (e.Ks() || !com.kwad.components.core.t.a.aN(a.this.cO.mContext).wP()) {
                        if ((a.this.cO.bS instanceof KSAdVideoPlayConfigImpl) && ((KSAdVideoPlayConfigImpl) a.this.cO.bS).getVideoSoundValue() != 0) {
                            z = !a.this.cO.bS.isVideoSoundEnable();
                        } else {
                            z = !com.kwad.sdk.core.response.helper.a.ce(com.kwad.sdk.core.response.helper.e.eM(a.this.cO.mAdTemplate));
                        }
                    }
                    if (a.this.cO.mAdTemplate != null) {
                        a.this.cO.mAdTemplate.mIsAudioEnable = z ? false : true;
                    }
                    a.this.dh = z;
                    return z;
                } catch (Throwable unused) {
                    return true;
                }
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean f(boolean z) {
        if (!z) {
            com.kwad.components.core.t.a.aN(this.mContext).bd(false);
            return false;
        }
        if (!e.Ks()) {
            if (com.kwad.components.core.t.a.aN(this.mContext).wQ()) {
                return !com.kwad.components.core.t.a.aN(this.mContext).wP();
            }
            return com.kwad.components.core.t.a.aN(this.mContext).bd(false);
        }
        if (!this.cA) {
            this.cA = com.kwad.components.core.t.a.aN(this.mContext).bd(true);
        }
        return this.cA;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onDestroy() {
        super.onDestroy();
    }
}

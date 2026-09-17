package com.kwad.components.ad.draw.view;

import android.app.Activity;
import android.content.Context;
import android.os.SystemClock;
import android.widget.FrameLayout;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.tachikoma.TKRenderFailReason;
import com.kwad.components.core.webview.tachikoma.b.o;
import com.kwad.components.core.webview.tachikoma.b.p;
import com.kwad.components.core.webview.tachikoma.c.n;
import com.kwad.components.core.webview.tachikoma.c.u;
import com.kwad.components.core.webview.tachikoma.c.y;
import com.kwad.components.core.webview.tachikoma.i;
import com.kwad.components.core.webview.tachikoma.j;
import com.kwad.sdk.R;
import com.kwad.sdk.api.KsDrawAd;
import com.kwad.sdk.commercial.model.WebCloseStatus;
import com.kwad.sdk.components.t;
import com.kwad.sdk.core.c.d;
import com.kwad.sdk.core.config.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.widget.KSFrameLayout;
import com.kwad.sdk.widget.g;
import com.kwad.sdk.wrapper.m;
import java.lang.ref.WeakReference;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends KSFrameLayout {
    private com.kwad.sdk.core.j.b dA;
    private boolean dM;
    private KsDrawAd.AdInteractionListener du;
    private boolean dy;
    private final com.kwad.sdk.core.j.c fA;
    private long fS;
    private com.kwad.components.core.widget.a.c fs;
    private boolean fv;
    private i gg;
    private KSFrameLayout gh;
    private com.kwad.components.ad.draw.c.a gi;
    private boolean gj;
    private int gk;
    private boolean gl;
    private AdInfo mAdInfo;
    private AdResultData mAdResultData;
    private AdTemplate mAdTemplate;
    private Context mContext;

    public static class a extends com.kwad.sdk.core.response.a.a {
        public boolean gn;
        public int status;
    }

    static /* synthetic */ boolean b(c cVar, boolean z) {
        cVar.dM = true;
        return true;
    }

    public c(Context context) {
        super(context);
        this.fA = new com.kwad.sdk.core.j.c() { // from class: com.kwad.components.ad.draw.view.c.2
            @Override // com.kwad.sdk.core.j.c
            public final void bv() {
                if (!c.this.mAdTemplate.mPvReported && c.this.du != null && !c.this.mAdTemplate.mHasAdShow) {
                    c.this.du.onAdShow();
                    com.kwad.components.ad.draw.a.c.a(c.this.mAdTemplate, 2, 2);
                    c.this.mAdTemplate.mHasAdShow = true;
                }
                if (!c.this.gl) {
                    c.this.setLifeStatue("showStart");
                    c.this.setLifeStatue("showEnd");
                    c.this.gl = true;
                }
                c.this.setLifeStatue("pageVisiable");
            }

            @Override // com.kwad.sdk.core.j.c
            public final void bw() {
                c.this.setLifeStatue("pageInvisiable");
            }
        };
        B(context);
    }

    private void B(Context context) {
        this.mContext = context;
        m.inflate(context, R.layout.ksad_draw_tk_layout, this);
        this.gh = (KSFrameLayout) findViewById(R.id.ksad_draw_tk_container);
        int iA = e.a(com.kwad.sdk.core.config.c.aPx);
        this.gg = new i(context, iA, iA);
        final WeakReference weakReference = new WeakReference(m.getActivityFromContext(context));
        com.kwad.sdk.core.c.b.Mh();
        com.kwad.sdk.core.c.b.a(new d() { // from class: com.kwad.components.ad.draw.view.c.1
            @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
            /* JADX INFO: renamed from: onActivityDestroyed */
            public final void b(Activity activity) {
                Activity activity2 = (Activity) weakReference.get();
                if (activity2 == null || !activity2.equals(activity)) {
                    return;
                }
                if (c.this.gg != null) {
                    c.this.setLifeStatue("hideStart");
                    c.this.setLifeStatue("hideEnd");
                    c.this.gl = false;
                    c.this.gg.kT();
                }
                com.kwad.sdk.core.c.b.Mh();
                com.kwad.sdk.core.c.b.b((com.kwad.sdk.core.c.c) this);
            }
        });
    }

    public final void setPageExitListener(com.kwad.sdk.core.j.b bVar) {
        this.dA = bVar;
    }

    public final void setAdInteractionListener(KsDrawAd.AdInteractionListener adInteractionListener) {
        this.du = adInteractionListener;
    }

    public final void setTKLoadStateListener(com.kwad.components.ad.draw.c.a aVar) {
        this.gi = aVar;
    }

    public final void c(AdResultData adResultData) {
        this.mAdResultData = adResultData;
        AdTemplate adTemplateR = com.kwad.sdk.core.response.helper.c.r(adResultData);
        this.mAdTemplate = adTemplateR;
        this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(adTemplateR);
        this.fs = new com.kwad.components.ad.draw.b(this.gh);
        bN();
    }

    private void bN() {
        this.fs.a(this.dA);
        this.fs.a(this.fA);
        this.fs.Am();
        if (this.gg != null) {
            this.fS = SystemClock.elapsedRealtime();
            com.kwad.components.ad.draw.a.b.g(this.mAdTemplate);
            this.gg.a(m.getActivityFromContext(this.mContext), this.mAdResultData, new j() { // from class: com.kwad.components.ad.draw.view.c.3
                @Override // com.kwad.components.core.webview.tachikoma.j
                public final void a(az azVar) {
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final void a(o oVar) {
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final void a(p pVar) {
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final void a(n nVar) {
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final void a(u uVar) {
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final void a(WebCloseStatus webCloseStatus) {
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final void a(t tVar, com.kwad.sdk.core.webview.b bVar) {
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final void aC() {
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final void f(AdTemplate adTemplate) {
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final String getRegisterViewKey() {
                    return "ksad-draw-card";
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final String getTKReaderScene() {
                    return "tk_draw_card";
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final g getTouchCoordsView() {
                    return null;
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final String getTkTemplateId() {
                    return com.kwad.sdk.core.response.helper.b.es(c.this.mAdTemplate);
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final FrameLayout getTKContainer() {
                    return c.this.gh;
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final void a(TKRenderFailReason tKRenderFailReason) {
                    if (c.this.gi != null) {
                        c.this.gi.aL();
                    }
                    c.this.gh.setVisibility(8);
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final void aB() {
                    if (c.this.gi != null) {
                        c.this.gi.aK();
                    }
                    c.this.gh.setVisibility(0);
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
                    if (c.this.du != null) {
                        c.this.du.onAdClicked();
                    }
                    if (c.this.dM) {
                        return;
                    }
                    c.b(c.this, true);
                    com.kwad.components.ad.draw.a.c.b(c.this.mAdTemplate, 2, 2);
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final void a(ae.a aVar) {
                    aVar.width = com.kwad.sdk.c.a.a.px2dip(c.this.getContext(), c.this.gh.getWidth());
                    aVar.height = com.kwad.sdk.c.a.a.px2dip(c.this.getContext(), c.this.gh.getHeight());
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final void a(com.kwad.components.core.webview.jshandler.a.C0464a c0464a) {
                    if (c.this.du != null) {
                        String str = c0464a.apu;
                        str.hashCode();
                        if (str.equals("adShowCallback")) {
                            c.this.du.onAdShow();
                            if (c.this.mAdTemplate == null || c.this.mAdTemplate.mHasAdShow) {
                                return;
                            }
                            com.kwad.components.ad.draw.a.c.a(c.this.mAdTemplate, 2, 2);
                            c.this.mAdTemplate.mHasAdShow = true;
                            return;
                        }
                        if (str.equals("adClickCallback")) {
                            c.this.du.onAdClicked();
                            if (c.this.dM) {
                                return;
                            }
                            c.b(c.this, true);
                            com.kwad.components.ad.draw.a.c.b(c.this.mAdTemplate, 2, 2);
                        }
                    }
                }

                @Override // com.kwad.components.core.webview.tachikoma.j
                public final void aD() {
                    c.this.bO();
                    c.this.bP();
                    c cVar = c.this;
                    cVar.A(cVar.gk);
                }
            });
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void bO() {
        i iVar = this.gg;
        if (iVar != null) {
            iVar.a("setVideoPlayStatusCallback", (String) null, new com.kwad.components.core.webview.tachikoma.a.g() { // from class: com.kwad.components.ad.draw.view.c.4
                @Override // com.kwad.components.core.webview.tachikoma.a.g
                public final void bR() {
                    if (c.this.du != null) {
                        c.this.du.onVideoPlayResume();
                    }
                }

                @Override // com.kwad.components.core.webview.tachikoma.a.g
                public final void bS() {
                    if (c.this.du != null) {
                        c.this.du.onVideoPlayPause();
                    }
                }

                @Override // com.kwad.components.core.webview.tachikoma.a.g
                public final void a(y yVar) {
                    if (c.this.du != null) {
                        c.this.du.onVideoPlayError();
                        com.kwad.components.ad.draw.a.b.a(c.this.mAdTemplate, SystemClock.elapsedRealtime() - c.this.fS, "video play error");
                    }
                }

                @Override // com.kwad.components.core.webview.tachikoma.a.g
                public final void bT() {
                    if (c.this.du != null) {
                        c.this.du.onVideoPlayEnd();
                    }
                }

                @Override // com.kwad.components.core.webview.tachikoma.a.g
                public final void bU() {
                    if (c.this.du != null) {
                        c.this.du.onVideoPlayStart();
                        com.kwad.components.ad.draw.a.b.a(c.this.mAdTemplate, SystemClock.elapsedRealtime() - c.this.fS);
                        c.this.bP();
                    }
                }
            });
        }
    }

    public final void setLifeStatue(String str) {
        i iVar = this.gg;
        if (iVar != null) {
            iVar.a("setLifeStatus", str, (com.kwad.sdk.components.m) null);
        }
    }

    public final void setVideoSound(boolean z) {
        this.fv = !z;
        this.gj = true;
        bP();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void bP() {
        if (this.gg != null) {
            n nVar = new n();
            nVar.auv = bQ();
            this.gg.a("setVideoMuteStateListener", nVar.toJson().toString(), (com.kwad.sdk.components.m) null);
        }
    }

    public final void A(int i) {
        this.gk = i;
        if (this.gg == null) {
            return;
        }
        a aVar = new a();
        aVar.status = this.gk;
        aVar.gn = this.dy;
        this.gg.a("setVideoPlayerStatus", aVar.toJson().toString(), (com.kwad.sdk.components.m) null);
    }

    private boolean bQ() {
        if (this.gj) {
            return this.fv;
        }
        return com.kwad.sdk.core.response.helper.a.ci(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate));
    }

    public final void bM() {
        this.dy = true;
        A(0);
    }
}

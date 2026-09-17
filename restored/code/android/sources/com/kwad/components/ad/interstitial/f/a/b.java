package com.kwad.components.ad.interstitial.f.a;

import android.app.Activity;
import android.app.Dialog;
import android.os.Vibrator;
import android.widget.FrameLayout;
import com.kwad.components.ad.interstitial.f.c;
import com.kwad.components.core.page.AdWebViewActivityProxy;
import com.kwad.components.core.t.n;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.ak;
import com.kwad.components.core.webview.jshandler.aq;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.jshandler.bb;
import com.kwad.components.core.webview.jshandler.bk;
import com.kwad.components.core.webview.jshandler.x;
import com.kwad.components.core.webview.jshandler.z;
import com.kwad.components.core.webview.tachikoma.TKRenderFailReason;
import com.kwad.components.core.webview.tachikoma.b.q;
import com.kwad.components.core.webview.tachikoma.c.l;
import com.kwad.components.core.webview.tachikoma.c.u;
import com.kwad.components.core.webview.tachikoma.c.y;
import com.kwad.components.core.webview.tachikoma.e;
import com.kwad.components.core.webview.tachikoma.f.g;
import com.kwad.sdk.R;
import com.kwad.sdk.api.KsInterstitialAd;
import com.kwad.sdk.commercial.model.WebCloseStatus;
import com.kwad.sdk.components.t;
import com.kwad.sdk.core.g.d;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.bt;
import com.kwad.sdk.utils.by;
import com.kwad.sdk.utils.cb;
import java.io.File;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends a {
    private static long nW = 400;
    private FrameLayout dg;
    private d hm;
    private Vibrator ho;
    private az iQ;
    private com.kwad.components.ad.h.a.a.b nV;
    private boolean nY;
    private e nZ;
    private boolean nX = false;
    private final c.b np = new c.b() { // from class: com.kwad.components.ad.interstitial.f.a.b.1
        @Override // com.kwad.components.ad.interstitial.f.c.b
        public final void c(long j, long j2) {
            com.kwad.components.ad.interstitial.report.a.eT().b(b.this.mF.mAdTemplate, j, j2);
            if (b.this.nZ != null) {
                com.kwad.components.core.webview.tachikoma.c.a aVar = new com.kwad.components.core.webview.tachikoma.c.a();
                aVar.auj = b.this.mF.mH ? 1 : 0;
                b.this.nZ.b(aVar);
            }
        }
    };
    private com.kwad.sdk.core.j.c fA = new com.kwad.sdk.core.j.d() { // from class: com.kwad.components.ad.interstitial.f.a.b.9
        @Override // com.kwad.sdk.core.j.d, com.kwad.sdk.core.j.c
        public final void bv() {
            if (b.this.iQ != null && !b.this.nX) {
                b.a(b.this, true);
                b.this.iQ.yJ();
                b.this.iQ.yK();
            }
            if (b.this.iQ != null) {
                b.this.iQ.yN();
            }
            if (b.this.nV != null) {
                b.this.nV.ga();
            }
            if (!b.this.nY) {
                b.this.mF.lp.getTimerHelper().startTiming();
            }
            if (b.this.nY || b.this.mF.mJ || b.this.mF.lk == null) {
                return;
            }
            b.this.mF.lk.onAdShow();
            com.kwad.components.ad.interstitial.report.c.eX().a(b.this.mF.mAdTemplate, 3);
            b.b(b.this, true);
        }

        @Override // com.kwad.sdk.core.j.d, com.kwad.sdk.core.j.c
        public final void bw() {
            if (b.this.iQ != null) {
                b.this.iQ.yO();
            }
            if (b.this.nV != null) {
                b.this.nV.fZ();
            }
        }
    };

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void aC() {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void aD() {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getRegisterViewKey() {
        return null;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTKReaderScene() {
        return "tk_interstitial";
    }

    static /* synthetic */ boolean a(b bVar, boolean z) {
        bVar.nX = true;
        return true;
    }

    static /* synthetic */ boolean b(b bVar, boolean z) {
        bVar.nY = true;
        return true;
    }

    @Override // com.kwad.components.ad.interstitial.f.a.a, com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        FrameLayout frameLayout = (FrameLayout) findViewById(R.id.ksad_tk_view);
        this.dg = frameLayout;
        frameLayout.setVisibility(0);
    }

    @Override // com.kwad.components.ad.interstitial.f.a.a, com.kwad.components.ad.interstitial.f.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
    }

    @Override // com.kwad.components.ad.interstitial.f.a.a, com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.nX = false;
        this.nY = false;
        by.b(getContext(), this.ho);
        d dVar = this.hm;
        if (dVar != null) {
            dVar.cb(getContext());
        }
        if (this.mF.li != null) {
            this.mF.li.b(this.fA);
        }
        this.mF.b(this.np);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTkTemplateId() {
        return com.kwad.sdk.core.response.helper.b.ek(this.mF.mAdTemplate);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final FrameLayout getTKContainer() {
        return this.dg;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(TKRenderFailReason tKRenderFailReason) {
        this.dg.setVisibility(8);
        if (this.mF.mM != null) {
            g gVar = this.mF.mM;
            getTkTemplateId();
            gVar.v(getTKReaderScene());
        }
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void aB() {
        com.kwad.components.ad.interstitial.report.c.eX().B(this.mF.mAdTemplate);
        if (this.mF.mM != null) {
            this.mF.mM.a(getTkTemplateId(), 0L, 0L, 0L);
        }
        if (this.iQ != null && this.mF.li.ah()) {
            this.nX = true;
            this.iQ.yJ();
            this.iQ.yK();
        }
        this.mF.li.a(this.fA);
    }

    @Override // com.kwad.components.ad.interstitial.f.a.a, com.kwad.components.core.webview.tachikoma.j
    public final void a(t tVar, com.kwad.sdk.core.webview.b bVar) {
        super.a(tVar, bVar);
        com.kwad.components.ad.h.a.a.b bVarI = com.kwad.components.ad.h.a.a.b.I(this.mF.mAdTemplate);
        this.nV = bVarI;
        if (bVarI != null) {
            bVarI.a(new com.kwad.components.ad.h.a.a.b.InterfaceC0371b() { // from class: com.kwad.components.ad.interstitial.f.a.b.10
                @Override // com.kwad.components.ad.h.a.a.b.InterfaceC0371b
                public final void Q(int i) {
                    if (i == com.kwad.components.ad.h.a.a.b.qY) {
                        b.this.mF.c(b.this.getContext(), b.this.mF.mAdTemplate);
                        b.this.mF.a(true, -1, null);
                    }
                    b.this.eA();
                }
            });
            tVar.c(this.nV);
            this.nV.aw();
        }
        tVar.c(eO());
        tVar.c(new aq(getOpenNewPageListener()));
        if (com.kwad.sdk.core.response.helper.b.dW(com.kwad.sdk.core.response.helper.e.eM(this.mF.mAdTemplate))) {
            tVar.c(new bb(new bb.a() { // from class: com.kwad.components.ad.interstitial.f.a.b.11
                @Override // com.kwad.components.core.webview.jshandler.bb.a
                public final void cN() {
                    b.this.cH();
                }
            }));
        }
        tVar.c(eN());
        tVar.c(eM());
        tVar.c(eK());
        tVar.c(a(bVar));
        tVar.c(eP());
        tVar.c(eL());
        tVar.c(new q() { // from class: com.kwad.components.ad.interstitial.f.a.b.12
            @Override // com.kwad.components.core.webview.tachikoma.b.q, com.kwad.sdk.core.webview.c.a
            public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
                super.a(str, cVar);
                n.i(b.this.getContext(), b.this.mF.mAdTemplate);
            }
        });
        this.nZ = eJ();
        this.mF.a(this.np);
        tVar.c(this.nZ);
        tVar.c(new com.kwad.components.core.webview.tachikoma.b(new com.kwad.components.core.webview.tachikoma.b.a() { // from class: com.kwad.components.ad.interstitial.f.a.b.13
            @Override // com.kwad.components.core.webview.tachikoma.b.a
            public final void eS() {
                com.kwad.components.ad.interstitial.d.a.L(b.this.getContext());
            }
        }));
        tVar.c(eI());
    }

    @Override // com.kwad.components.ad.interstitial.f.a.a, com.kwad.components.core.webview.tachikoma.j
    public final void a(az azVar) {
        super.a(azVar);
        this.iQ = azVar;
    }

    private com.kwad.components.core.webview.tachikoma.c eI() {
        return new com.kwad.components.core.webview.tachikoma.c() { // from class: com.kwad.components.ad.interstitial.f.a.b.14
            @Override // com.kwad.components.core.webview.tachikoma.c, com.kwad.sdk.core.webview.c.a
            public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
                super.a(str, cVar);
                com.kwad.components.core.webview.tachikoma.c.c cVar2 = new com.kwad.components.core.webview.tachikoma.c.c();
                cVar2.aul = com.kwad.components.ad.interstitial.d.a.dV();
                cVar.b(cVar2);
            }
        };
    }

    private e eJ() {
        return new e() { // from class: com.kwad.components.ad.interstitial.f.a.b.15
            @Override // com.kwad.components.core.webview.tachikoma.e, com.kwad.sdk.core.webview.c.a
            public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
                super.a(str, cVar);
                com.kwad.components.core.webview.tachikoma.c.a aVar = new com.kwad.components.core.webview.tachikoma.c.a();
                aVar.auj = b.this.mF.mH ? 1 : 0;
                cVar.b(aVar);
            }
        };
    }

    private com.kwad.components.core.webview.tachikoma.b.g eK() {
        l lVar = new l();
        lVar.aus = this.mF.mT;
        return new com.kwad.components.core.webview.tachikoma.b.g(lVar);
    }

    private com.kwad.components.ad.h.a.a.a eL() {
        final com.kwad.components.ad.h.a.a.a aVar = new com.kwad.components.ad.h.a.a.a();
        this.mF.mO.add(new c.d() { // from class: com.kwad.components.ad.interstitial.f.a.b.16
            @Override // com.kwad.components.ad.interstitial.f.c.d
            public final void eg() {
                aVar.fY();
            }
        });
        return aVar;
    }

    private z a(com.kwad.sdk.core.webview.b bVar) {
        return new z(bVar, this.mF.mApkDownloadHelper, new com.kwad.sdk.core.webview.d.a.a() { // from class: com.kwad.components.ad.interstitial.f.a.b.2
            @Override // com.kwad.sdk.core.webview.d.a.a
            public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
                if (aVar != null) {
                    com.kwad.components.ad.interstitial.report.a.eT().a(b.this.mF.mAdTemplate, aVar.bdh, aVar.ne);
                    b.this.mF.mH = true;
                    b.this.mF.c(aVar.bdh, aVar.ne);
                    if (b.this.mF.lp == null || !com.kwad.components.ad.interstitial.d.b.t(b.this.mF.mAdTemplate)) {
                        return;
                    }
                    b.this.mF.a(false, -1, b.this.mF.cB);
                    b.this.mF.lp.dismiss();
                    b.this.mF.ac();
                }
            }
        });
    }

    private bk eM() {
        bk bkVar = new bk(getContext(), this.mF.mAdTemplate);
        bkVar.a(new bk.a() { // from class: com.kwad.components.ad.interstitial.f.a.b.3
            @Override // com.kwad.components.core.webview.jshandler.bk.a
            public final boolean eR() {
                com.kwad.components.core.page.a.launch(b.this.getContext(), b.this.mF.mAdTemplate);
                b.this.mF.a(true, -1, null);
                by.runOnUiThreadDelay(new Runnable() { // from class: com.kwad.components.ad.interstitial.f.a.b.3.1
                    @Override // java.lang.Runnable
                    public final void run() {
                        b.this.eA();
                    }
                }, 0L);
                return false;
            }
        });
        return bkVar;
    }

    private com.kwad.components.core.webview.tachikoma.b.n eN() {
        return new com.kwad.components.core.webview.tachikoma.b.n() { // from class: com.kwad.components.ad.interstitial.f.a.b.4
            @Override // com.kwad.components.core.webview.tachikoma.b.w, com.kwad.sdk.core.webview.c.a
            public final void a(String str, final com.kwad.sdk.core.webview.c.c cVar) {
                super.a(str, cVar);
                by.runOnUiThreadDelay(new bi() { // from class: com.kwad.components.ad.interstitial.f.a.b.4.1
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        com.kwad.components.core.webview.tachikoma.c.d dVar = new com.kwad.components.core.webview.tachikoma.c.d();
                        dVar.aum = com.kwad.sdk.utils.aq.isWifiConnected(b.this.getContext()) || b.this.mF.ce.isDataFlowAutoStart() || b.u(b.this.mF.mAdTemplate);
                        cVar.b(dVar);
                    }
                }, 0L);
            }
        };
    }

    public static boolean u(AdTemplate adTemplate) {
        File fileCM = com.kwad.sdk.core.diskcache.b.a.LI().cM(com.kwad.sdk.core.response.helper.a.M(com.kwad.sdk.core.response.helper.e.eM(adTemplate)));
        return fileCM != null && fileCM.exists();
    }

    private ak eO() {
        return new ak(new ak.b() { // from class: com.kwad.components.ad.interstitial.f.a.b.5
            @Override // com.kwad.components.core.webview.jshandler.ak.b
            public final void a(final ak.a aVar) {
                if (b.this.mF.lp != null) {
                    b.this.mF.gh.post(new bi() { // from class: com.kwad.components.ad.interstitial.f.a.b.5.1
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            if (aVar.type != 0 || b.this.mF.mH || b.this.mF.mI || !com.kwad.components.ad.interstitial.g.a.e(b.this.mF)) {
                                b.this.eQ();
                                b.this.mF.a(aVar.type == 3, aVar.aqN, null);
                                b.this.eA();
                            } else {
                                b.this.mF.mI = true;
                                com.kwad.components.ad.interstitial.c.b.K(b.this.getContext());
                            }
                        }
                    });
                }
            }
        });
    }

    private x eP() {
        return new x() { // from class: com.kwad.components.ad.interstitial.f.a.b.6
            @Override // com.kwad.components.core.webview.jshandler.x
            public final void b(y yVar) {
                super.b(yVar);
                if (b.this.mF.mJ || b.this.mF.lk == null) {
                    return;
                }
                b.this.mF.lk.onVideoPlayStart();
            }

            @Override // com.kwad.components.core.webview.jshandler.x
            public final void d(y yVar) {
                super.d(yVar);
                b.this.mF.mAdTemplate.setmCurPlayTime(yVar.ri);
            }

            @Override // com.kwad.components.core.webview.jshandler.x
            public final void c(y yVar) {
                super.c(yVar);
                if (b.this.mF.mJ || b.this.mF.lk == null) {
                    return;
                }
                b.this.mF.lk.onVideoPlayEnd();
            }
        };
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void cH() {
        if (getContext() != null) {
            this.ho = (Vibrator) getContext().getSystemService("vibrator");
        }
        float fDD = com.kwad.sdk.core.response.helper.b.dD(this.mF.mAdTemplate);
        boolean zDX = com.kwad.sdk.core.response.helper.b.dX(com.kwad.sdk.core.response.helper.e.eM(this.mF.mAdTemplate));
        boolean zDY = com.kwad.sdk.core.response.helper.b.dY(com.kwad.sdk.core.response.helper.e.eM(this.mF.mAdTemplate));
        if (this.hm == null) {
            d dVar = new d(zDX, fDD);
            this.hm = dVar;
            dVar.bG(zDY);
            this.hm.a(new com.kwad.sdk.core.g.b() { // from class: com.kwad.components.ad.interstitial.f.a.b.7
                @Override // com.kwad.sdk.core.g.b
                public final void cf() {
                }

                @Override // com.kwad.sdk.core.g.b
                public final void a(double d) {
                    if (cb.r(b.this.getTKContainer(), 100)) {
                        b.this.d(d);
                    }
                    by.a(new bi() { // from class: com.kwad.components.ad.interstitial.f.a.b.7.1
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            b.this.hm.NS();
                        }
                    }, null, 500L);
                }
            });
        }
        this.hm.m(fDD);
        this.hm.ca(getContext());
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void d(double d) {
        this.mF.a(new c.C0377c(getContext()).m(true).c(d).L(2).a(this.mF.gh.getTouchCoords()).M(157));
        by.vibrate(getContext(), this.ho, nW);
    }

    private aq.a getOpenNewPageListener() {
        return new aq.a() { // from class: com.kwad.components.ad.interstitial.f.a.b.8
            @Override // com.kwad.components.core.webview.jshandler.aq.a
            public final void a(com.kwad.components.core.webview.a.b bVar) {
                AdWebViewActivityProxy.launch(b.this.getContext(), new AdWebViewActivityProxy.a.C0449a().aW(bVar.title).aX(bVar.url).aQ(true).q(b.this.mF.mAdResultData).um());
            }
        };
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(ae.a aVar) {
        float height;
        float width;
        float fBA = com.kwad.sdk.c.a.a.bA(getContext());
        FrameLayout frameLayout = this.dg;
        if (frameLayout != null) {
            height = frameLayout.getHeight();
            width = this.dg.getWidth();
        } else {
            height = 0.0f;
            width = 0.0f;
        }
        if (height == 0.0f || width == 0.0f) {
            aVar.width = (int) ((bt.getScreenWidth(getContext()) / fBA) + 0.5f);
            aVar.height = (int) ((bt.getScreenHeight(getContext()) / fBA) + 0.5f);
        } else {
            aVar.width = (int) ((width / fBA) + 0.5f);
            aVar.height = (int) ((height / fBA) + 0.5f);
        }
    }

    @Override // com.kwad.components.ad.interstitial.f.a.a, com.kwad.components.core.webview.tachikoma.j
    public final void a(u uVar) {
        super.a(uVar);
        if (this.mF.lk != null) {
            this.mF.lk.onSkippedAd();
        }
        if (this.mF.mK != null) {
            this.mF.mK.a(-1L, -1L, false);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void eA() {
        if (this.mF == null) {
            return;
        }
        if (this.mF.lp != null && a(this.mF.lp)) {
            this.mF.lp.dismiss();
        }
        try {
            KsInterstitialAd.AdInteractionListener adInteractionListener = this.mF.lk;
            if (adInteractionListener != null) {
                adInteractionListener.onAdClosed();
            }
        } catch (Throwable th) {
            com.kwad.components.core.d.a.reportSdkCaughtException(th);
        }
    }

    private static boolean a(Dialog dialog) {
        Activity ownerActivity = dialog.getOwnerActivity();
        return (ownerActivity == null || ownerActivity.isFinishing()) ? false : true;
    }

    @Override // com.kwad.components.ad.interstitial.f.a.a, com.kwad.components.core.webview.tachikoma.j
    public final void a(WebCloseStatus webCloseStatus) {
        this.mF.a(webCloseStatus.closeType == 2, -1, null);
        eA();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void eQ() {
        az azVar = this.iQ;
        if (azVar != null) {
            azVar.yL();
            this.iQ.yM();
        }
        com.kwad.components.ad.h.a.a.b bVar = this.nV;
        if (bVar != null) {
            bVar.fZ();
        }
    }
}

package com.kwad.components.ad.reward.presenter.h;

import android.content.DialogInterface;
import com.kwad.components.ad.reward.k.a.d;
import com.kwad.components.ad.reward.presenter.f.g;
import com.kwad.components.ad.reward.presenter.i;
import com.kwad.components.core.n.a.b;
import com.kwad.components.core.video.m;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.tachikoma.TKRenderFailReason;
import com.kwad.components.core.webview.tachikoma.b.o;
import com.kwad.components.core.webview.tachikoma.b.p;
import com.kwad.components.core.webview.tachikoma.c.n;
import com.kwad.components.core.webview.tachikoma.c.u;
import com.kwad.components.core.webview.tachikoma.c.w;
import com.kwad.components.core.webview.tachikoma.f;
import com.kwad.components.core.webview.tachikoma.j;
import com.kwad.sdk.R;
import com.kwad.sdk.commercial.model.WebCloseStatus;
import com.kwad.sdk.components.t;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.as;
import com.kwad.sdk.utils.au;
import com.kwad.sdk.utils.bt;
import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends g implements j {
    private d Az;
    private boolean Bm;
    private f Bn;
    private long Bo;
    private AdInfo mAdInfo;
    private boolean xU;
    private boolean xV;
    private com.kwad.components.ad.reward.g.b xW = new com.kwad.components.ad.reward.g.b() { // from class: com.kwad.components.ad.reward.presenter.h.a.1
        @Override // com.kwad.components.ad.reward.g.b
        public final boolean interceptPlayCardResume() {
            return a.this.AS != null && a.this.AS.getVisibility() == 0;
        }
    };
    private final com.kwad.components.core.n.a.a wz = new b() { // from class: com.kwad.components.ad.reward.presenter.h.a.2
        @Override // com.kwad.components.core.n.a.b, com.kwad.components.core.n.a.a
        public final void d(com.kwad.components.core.proxy.f fVar) {
            super.d(fVar);
            a.this.Bm = true;
        }

        @Override // com.kwad.components.core.n.a.b, com.kwad.components.core.n.a.a
        public final void c(com.kwad.components.core.proxy.f fVar) {
            a.this.Bm = false;
            if (a.this.Bn == null) {
                return;
            }
            w wVar = new w();
            if (com.kwad.components.core.r.a.wy().wE()) {
                com.kwad.components.core.r.a.wy().bc(false);
                if (com.kwad.sdk.core.response.helper.a.aT(a.this.mAdInfo) == 0) {
                    wVar.auA = 1;
                    a.this.Bn.a(wVar);
                    return;
                } else if (com.kwad.components.core.r.a.wy().wA()) {
                    wVar.auA = 1;
                    a.this.Bn.a(wVar);
                    return;
                } else {
                    wVar.auA = 0;
                    a.this.Bn.a(wVar);
                    return;
                }
            }
            if (com.kwad.components.core.r.a.wy().wC() && com.kwad.sdk.core.response.helper.a.aT(a.this.mAdInfo) == 1) {
                if (com.kwad.components.core.r.a.wy().wD() == 1) {
                    if (au.aw(a.this.getContext(), com.kwad.sdk.core.response.helper.a.aE(a.this.mAdInfo))) {
                        wVar.auA = 2;
                        com.kwad.components.core.r.a.wy().bL(2);
                        a.this.Bn.a(wVar);
                        return;
                    } else {
                        wVar.auA = 0;
                        a.this.Bn.a(wVar);
                        return;
                    }
                }
                if (com.kwad.components.core.r.a.wy().wD() == 3) {
                    wVar.auA = 1;
                    com.kwad.components.core.r.a.wy().bL(0);
                    a.this.Bn.a(wVar);
                }
            }
        }
    };
    private final m jX = new m() { // from class: com.kwad.components.ad.reward.presenter.h.a.3
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, long j2) {
            super.onMediaPlayProgress(j, j2);
            long jH = com.kwad.components.ad.reward.g.h(a.this.mAdInfo);
            long jAS = ((long) com.kwad.sdk.core.response.helper.a.aS(a.this.mAdInfo)) * 1000;
            if (j2 <= a.this.Bo || jH - j2 <= jAS || a.this.xU) {
                return;
            }
            if (com.kwad.sdk.core.response.helper.a.aT(a.this.mAdInfo) == 1) {
                if (au.aw(a.this.getContext(), com.kwad.sdk.core.response.helper.a.aE(a.this.mAdInfo))) {
                    return;
                }
            } else if (a.this.ub.iZ) {
                return;
            }
            a.b(a.this, true);
            a.this.Az.a(a.this.ub.getActivity(), a.this.ub.mAdResultData, a.this);
            a.this.ky();
        }
    };

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(az azVar) {
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(o oVar) {
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(p pVar) {
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(n nVar) {
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(u uVar) {
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void aC() {
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void f(AdTemplate adTemplate) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTKReaderScene() {
        return "tk_reward_task_card";
    }

    static /* synthetic */ boolean b(a aVar, boolean z) {
        aVar.xU = true;
        return true;
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        getContext();
        if (as.VV()) {
            this.Bm = false;
            c.d("TkRewardVideoTaskPresenter", "onBind: ");
            if (this.Az == null) {
                this.Az = new d(this.ub, -1L, getContext(), new DialogInterface.OnDismissListener() { // from class: com.kwad.components.ad.reward.presenter.h.a.4
                    @Override // android.content.DialogInterface.OnDismissListener
                    public final void onDismiss(DialogInterface dialogInterface) {
                        if (a.this.Bn == null) {
                            return;
                        }
                        w wVar = new w();
                        if (com.kwad.components.core.r.a.wy().wE()) {
                            com.kwad.components.core.r.a.wy().bc(false);
                            if (com.kwad.sdk.core.response.helper.a.aT(a.this.mAdInfo) == 0) {
                                wVar.auA = 1;
                                a.this.Bn.a(wVar);
                                return;
                            } else if (com.kwad.components.core.r.a.wy().wA()) {
                                wVar.auA = 1;
                                a.this.Bn.a(wVar);
                                return;
                            } else {
                                wVar.auA = 0;
                                a.this.Bn.a(wVar);
                                return;
                            }
                        }
                        if (com.kwad.components.core.r.a.wy().wC() && com.kwad.sdk.core.response.helper.a.aT(a.this.mAdInfo) == 1) {
                            if (com.kwad.components.core.r.a.wy().wD() == 1) {
                                if (au.aw(a.this.getContext(), com.kwad.sdk.core.response.helper.a.aE(a.this.mAdInfo))) {
                                    return;
                                }
                                wVar.auA = 0;
                                a.this.Bn.a(wVar);
                                return;
                            }
                            if (com.kwad.components.core.r.a.wy().wD() == 3) {
                                wVar.auA = 1;
                                com.kwad.components.core.r.a.wy().bL(0);
                                a.this.Bn.a(wVar);
                            }
                        }
                    }
                });
            }
            AdInfo adInfoEM = e.eM(this.ub.mAdTemplate);
            this.mAdInfo = adInfoEM;
            this.Bo = ((long) com.kwad.sdk.core.response.helper.a.aR(adInfoEM)) * 1000;
            if (this.ub.sr != null) {
                this.ub.sr.a(this.jX);
            }
            this.ub.a(this.xW);
            this.ub.abs.add(this.wz);
        }
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        if (this.ub.sr != null) {
            this.ub.sr.b(this.jX);
        }
        this.ub.b(this.xW);
        this.ub.abs.remove(this.wz);
        d dVar = this.Az;
        if (dVar != null) {
            dVar.kT();
            this.Az = null;
        }
        this.AS.setVisibility(8);
        com.kwad.components.core.r.a.wy().clear();
        this.xU = false;
        this.xV = false;
        this.Bm = false;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTkTemplateId() {
        return com.kwad.sdk.core.response.helper.b.eg(this.ub.mAdTemplate);
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final com.kwad.sdk.widget.g getTouchCoordsView() {
        return this.ub.mRootContainer;
    }

    @Override // com.kwad.components.ad.reward.presenter.f.g
    public final int jh() {
        return R.id.ksad_js_task;
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(TKRenderFailReason tKRenderFailReason) {
        c.d("TkRewardVideoTaskPresenter", "onTkLoadFailed: ");
        this.AS.setVisibility(8);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void ky() {
        this.AS.setVisibility(0);
        if (this.ub.sr != null) {
            this.ub.sr.pause();
        }
        this.xV = true;
    }

    private f kz() {
        return new f() { // from class: com.kwad.components.ad.reward.presenter.h.a.5
            @Override // com.kwad.components.core.webview.tachikoma.b.w, com.kwad.sdk.core.webview.c.a
            public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
                super.a(str, cVar);
            }
        };
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(t tVar, com.kwad.sdk.core.webview.b bVar) {
        f fVarKz = kz();
        this.Bn = fVarKz;
        tVar.c(fVarKz);
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
        this.ub.sq.cY();
        c.d("jky", "onAdClicked convertPageType: " + aVar.bdg);
        if (com.kwad.sdk.core.response.helper.a.aU(this.mAdInfo)) {
            com.kwad.components.core.r.a.wy().bK(aVar.bdg);
            if (aVar.bdg == -1) {
                com.kwad.components.core.r.a.wy().bc(false);
                com.kwad.components.core.r.a.wy().bL(0);
            } else {
                if (com.kwad.sdk.core.response.helper.a.aL(this.mAdInfo)) {
                    if (com.kwad.components.core.r.a.wy().wD() == 2) {
                        com.kwad.components.core.r.a.wy().bL(3);
                        return;
                    } else {
                        com.kwad.components.core.r.a.wy().bL(1);
                        return;
                    }
                }
                com.kwad.components.core.r.a.wy().bc(true);
            }
        }
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(ae.a aVar) {
        float fBA = com.kwad.sdk.c.a.a.bA(getContext());
        aVar.width = (int) ((bt.getScreenWidth(getContext()) / fBA) + 0.5f);
        aVar.height = (int) ((bt.getScreenHeight(getContext()) / fBA) + 0.5f);
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(WebCloseStatus webCloseStatus) {
        boolean z = false;
        this.ub.sJ = webCloseStatus != null && webCloseStatus.interactSuccess;
        int iWz = com.kwad.components.core.r.a.wy().wz();
        if (this.ub.sr != null) {
            if (this.ub.sJ) {
                this.ub.sr.ln();
                if (iWz == 1) {
                    iR();
                    z = true;
                }
            }
            if (this.xV && !this.Bm && !z) {
                this.ub.sr.resume();
            }
        }
        this.AS.setVisibility(8);
    }

    private void iR() {
        boolean z = i.z(this.ub);
        c.d("jky", "onPlayCompleted: " + z);
        if (z) {
            by.runOnUiThreadDelay(new Runnable() { // from class: com.kwad.components.ad.reward.presenter.h.a.6
                @Override // java.lang.Runnable
                public final void run() {
                    if (a.this.ub.sq != null) {
                        a.this.ub.sq.onRewardVerify();
                    }
                    a.this.ub.sr.pause();
                    a.this.ub.gU();
                }
            }, 200L);
            return;
        }
        if (this.ub.sq != null) {
            this.ub.sq.onRewardVerify();
        }
        this.ub.sr.pause();
        this.ub.gU();
    }
}

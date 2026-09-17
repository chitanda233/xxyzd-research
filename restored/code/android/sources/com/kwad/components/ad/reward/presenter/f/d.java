package com.kwad.components.ad.reward.presenter.f;

import android.content.DialogInterface;
import com.kwad.components.ad.reward.RewardRenderResult;
import com.kwad.components.ad.reward.e.l;
import com.kwad.components.ad.reward.k.i;
import com.kwad.components.ad.reward.k.j;
import com.kwad.components.ad.reward.k.k;
import com.kwad.components.core.playable.PlayableSource;
import com.kwad.components.core.video.m;
import com.kwad.components.core.webview.jshandler.ah;
import com.kwad.components.core.webview.jshandler.ak;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.jshandler.bj;
import com.kwad.components.core.webview.tachikoma.TKRenderFailReason;
import com.kwad.components.core.webview.tachikoma.b.o;
import com.kwad.components.core.webview.tachikoma.b.p;
import com.kwad.components.core.webview.tachikoma.b.y;
import com.kwad.components.core.webview.tachikoma.c.n;
import com.kwad.components.core.webview.tachikoma.c.q;
import com.kwad.components.core.webview.tachikoma.c.r;
import com.kwad.components.core.webview.tachikoma.c.u;
import com.kwad.components.core.webview.tachikoma.c.z;
import com.kwad.sdk.commercial.model.WebCloseStatus;
import com.kwad.sdk.components.t;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.response.model.TKAdLiveShopItemInfo;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public abstract class d extends com.kwad.components.ad.reward.presenter.b implements DialogInterface.OnDismissListener, com.kwad.components.ad.reward.k.a.e, y.a {
    private p AA;
    private o AB;
    private i AC;
    private j AE;
    private z AF;
    private boolean AG;
    private com.kwad.components.core.webview.tachikoma.b.h AH;
    protected e AI;
    protected com.kwad.components.ad.reward.k.a.d Az;
    private bj.b AJ = new bj.b() { // from class: com.kwad.components.ad.reward.presenter.f.d.1
        @Override // com.kwad.components.core.webview.jshandler.bj.b
        public final void ae(int i) {
            com.kwad.sdk.core.adlog.c.b bVarF = new com.kwad.sdk.core.adlog.c.b().dS(i).f(d.this.ub.mRootContainer.getTouchCoords());
            com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(d.this.getContext()).aF(d.this.ub.mAdTemplate).b(d.this.ub.mApkDownloadHelper).as(false));
            com.kwad.components.ad.reward.j.b.a(d.this.ub.mAdTemplate, d.this.kp(), (String) null, bVarF, (JSONObject) null);
        }
    };
    private final com.kwad.sdk.utils.j.a kx = new com.kwad.sdk.utils.j.a() { // from class: com.kwad.components.ad.reward.presenter.f.d.5
        @Override // com.kwad.sdk.utils.j.a
        public final void onAudioBeReleased() {
        }

        @Override // com.kwad.sdk.utils.j.a
        public final void onAudioBeOccupied() {
            if (d.this.AB == null || com.kwad.components.ad.reward.a.b.hM()) {
                return;
            }
            n nVar = new n();
            nVar.auv = true;
            d.this.AB.c(nVar);
        }
    };
    private final l mRewardVerifyListener = new l() { // from class: com.kwad.components.ad.reward.presenter.f.d.6
        @Override // com.kwad.components.ad.reward.e.l
        public final void onRewardVerify() {
            if (d.this.AC != null) {
                com.kwad.components.core.webview.tachikoma.c.h hVar = new com.kwad.components.core.webview.tachikoma.c.h();
                hVar.auo = 1;
                d.this.AC.a(hVar);
            }
        }
    };
    private final com.kwad.components.ad.reward.e.g mPlayEndPageListener = new com.kwad.components.ad.reward.e.a() { // from class: com.kwad.components.ad.reward.presenter.f.d.7
        @Override // com.kwad.components.ad.reward.e.g
        public final void cZ() {
            if (d.this.AE != null) {
                by.runOnUiThreadDelay(new bi() { // from class: com.kwad.components.ad.reward.presenter.f.d.7.1
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        com.kwad.components.core.webview.tachikoma.c.p pVar = new com.kwad.components.core.webview.tachikoma.c.p();
                        pVar.scene = 1;
                        d.this.AE.a(pVar);
                        if (d.this.AH != null) {
                            d.this.AH.bn(d.this.ub.tk);
                        }
                    }
                }, 0L);
            }
        }
    };
    private final m jX = new m() { // from class: com.kwad.components.ad.reward.presenter.f.d.8
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPreparing() {
            d.this.e(0.0d);
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, long j2) {
            d.this.a(j, j2);
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayStart() {
            d.this.e(0.0d);
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayCompleted() {
            d.this.iR();
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayError(int i, int i2) {
            d.this.kn();
        }
    };

    public void a(WebCloseStatus webCloseStatus) {
    }

    public void aC() {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void aD() {
    }

    public void f(AdTemplate adTemplate) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public String getRegisterViewKey() {
        return null;
    }

    protected boolean kg() {
        return false;
    }

    public d() {
        if (kg()) {
            this.AI = new e();
        }
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public void av() {
        super.av();
        this.AG = true;
        this.ub.a(this);
        if (this.Az == null) {
            this.Az = new com.kwad.components.ad.reward.k.a.d(this.ub, -1L, getContext());
        }
        if (this.AF == null) {
            this.AF = new z();
        }
        this.Az.a(this.ub.getActivity(), this.ub.mAdResultData, this);
        e eVar = this.AI;
        if (eVar != null) {
            eVar.A(this.ub);
        }
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public void onUnbind() {
        super.onUnbind();
        if (this.AG) {
            e eVar = this.AI;
            if (eVar != null) {
                eVar.B(this.ub);
            }
            this.ub.b(this);
            com.kwad.components.ad.reward.k.a.d dVar = this.Az;
            if (dVar != null) {
                dVar.kT();
            }
            if (this.ub.sr != null) {
                this.ub.sr.b(this.jX);
                this.ub.sr.b(this.kx);
            }
            com.kwad.components.ad.reward.b.gu().b(this.mRewardVerifyListener);
            this.ub.c(this.mPlayEndPageListener);
        }
    }

    @Override // android.content.DialogInterface.OnDismissListener
    public void onDismiss(DialogInterface dialogInterface) {
        com.kwad.components.ad.reward.k.a.d dVar = this.Az;
        if (dVar == null || dVar.kR() == null) {
            return;
        }
        this.Az.kR().ik();
    }

    public com.kwad.sdk.widget.g getTouchCoordsView() {
        return this.ub.mRootContainer;
    }

    public void a(t tVar, com.kwad.sdk.core.webview.b bVar) {
        k kVar = new k();
        kVar.a(new k.a() { // from class: com.kwad.components.ad.reward.presenter.f.d.9
            @Override // com.kwad.components.ad.reward.k.k.a
            public final void d(r rVar) {
                com.kwad.components.ad.reward.c.gx().c(rVar);
            }
        });
        tVar.c(kVar);
        long j = this.ub.te;
        tVar.c(new com.kwad.components.ad.reward.k.g(j > 0 ? ((int) j) / 1000 : 0));
        i iVar = new i();
        this.AC = iVar;
        tVar.c(iVar);
        j jVar = new j();
        this.AE = jVar;
        tVar.c(jVar);
        com.kwad.components.ad.reward.b.gu().a(this.mRewardVerifyListener);
        this.ub.b(this.mPlayEndPageListener);
        tVar.c(new ak(new ak.b() { // from class: com.kwad.components.ad.reward.presenter.f.d.10
            @Override // com.kwad.components.core.webview.jshandler.ak.b
            public final void a(ak.a aVar) {
                d.this.getTKContainer().setVisibility(8);
            }
        }));
        com.kwad.components.ad.reward.k.d dVar = new com.kwad.components.ad.reward.k.d();
        dVar.a(new com.kwad.components.ad.reward.k.d.a() { // from class: com.kwad.components.ad.reward.presenter.f.d.11
            @Override // com.kwad.components.ad.reward.k.d.a
            public final void a(final q qVar) {
                com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(d.this.getContext()).aF(d.this.ub.mAdTemplate).b(d.this.ub.mApkDownloadHelper).aD(1).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.reward.presenter.f.d.11.1
                    @Override // com.kwad.components.core.e.d.a.b
                    public final void onAdClicked() {
                        if (qVar.aux) {
                            d.this.kj();
                        } else {
                            d.this.kk();
                        }
                    }
                }));
            }
        });
        tVar.c(dVar);
        com.kwad.components.ad.reward.k.e eVar = new com.kwad.components.ad.reward.k.e();
        eVar.a(new com.kwad.components.ad.reward.k.e.a() { // from class: com.kwad.components.ad.reward.presenter.f.d.12
            @Override // com.kwad.components.ad.reward.k.e.a
            public final void kq() {
                com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(d.this.getContext()).aF(d.this.ub.mAdTemplate).b(d.this.ub.mApkDownloadHelper).aD(2).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.reward.presenter.f.d.12.1
                    @Override // com.kwad.components.core.e.d.a.b
                    public final void onAdClicked() {
                        d.this.kl();
                    }
                }));
            }
        });
        tVar.c(eVar);
        tVar.c(new com.kwad.components.ad.reward.k.h(new com.kwad.components.ad.reward.k.h.a() { // from class: com.kwad.components.ad.reward.presenter.f.d.13
            @Override // com.kwad.components.ad.reward.k.h.a
            public final void af(int i) {
                if (com.kwad.components.ad.reward.g.P(d.this.ub.mAdTemplate)) {
                    if (!com.kwad.components.ad.reward.g.N(d.this.ub.mAdTemplate) || d.this.ub.ta == null) {
                        if (com.kwad.components.ad.reward.g.O(d.this.ub.mAdTemplate) && d.this.ub.tb != null && !d.this.ub.tb.lf()) {
                            d.this.ub.tb.le();
                        }
                    } else if (!d.this.ub.ta.lf()) {
                        d.this.ub.ta.le();
                    }
                }
                if (d.this.ub.hc() != RewardRenderResult.DEFAULT) {
                    d.this.ub.sQ = i;
                }
                d.this.notifyRewardVerify();
            }
        }));
        tVar.c(new com.kwad.components.ad.reward.k.c() { // from class: com.kwad.components.ad.reward.presenter.f.d.14
            @Override // com.kwad.components.ad.reward.k.c
            public final void kr() {
                super.kr();
                d.this.ki();
            }
        });
        tVar.c(new com.kwad.components.ad.reward.k.f() { // from class: com.kwad.components.ad.reward.presenter.f.d.15
            @Override // com.kwad.components.ad.reward.k.f
            public final void W(boolean z) {
                super.W(z);
                com.kwad.components.ad.reward.presenter.f.v(d.this.ub);
            }
        });
        tVar.c(new com.kwad.components.ad.reward.k.b() { // from class: com.kwad.components.ad.reward.presenter.f.d.16
            @Override // com.kwad.components.ad.reward.k.b
            public final void kr() {
                super.kr();
                d.this.kh();
            }
        });
        tVar.c(new com.kwad.components.core.webview.tachikoma.b.q() { // from class: com.kwad.components.ad.reward.presenter.f.d.2
            @Override // com.kwad.components.core.webview.tachikoma.b.q, com.kwad.sdk.core.webview.c.a
            public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
                super.a(str, cVar);
                com.kwad.components.core.t.n.i(d.this.getContext(), d.this.ub.mAdTemplate);
            }
        });
        tVar.c(new com.kwad.components.ad.reward.i.b(getContext(), this.ub.mAdTemplate, PlayableSource.ACTIONBAR_CLICK));
        com.kwad.components.core.webview.tachikoma.b.h hVar = new com.kwad.components.core.webview.tachikoma.b.h();
        this.AH = hVar;
        hVar.a(new com.kwad.components.core.webview.tachikoma.b.h.a() { // from class: com.kwad.components.ad.reward.presenter.f.d.3
            @Override // com.kwad.components.core.webview.tachikoma.b.h.a
            public final void a(com.kwad.components.core.webview.tachikoma.b.h hVar2) {
                hVar2.bn(d.this.ub.tk);
            }
        });
        tVar.c(this.AH);
        tVar.c(new ah());
        tVar.c(new bj(bVar, this.ub.mApkDownloadHelper, this.AJ));
        tVar.c(new y(this));
    }

    public void a(p pVar) {
        this.AA = pVar;
        if (this.ub.sr != null) {
            this.ub.sr.a(this.jX);
        }
    }

    public void a(u uVar) {
        com.kwad.components.ad.reward.presenter.f.a(this.ub, false);
    }

    public void aB() {
        e eVar = this.AI;
        if (eVar != null) {
            eVar.aB();
        }
    }

    public void a(TKRenderFailReason tKRenderFailReason) {
        e eVar = this.AI;
        if (eVar != null) {
            eVar.kt();
        }
    }

    public void a(az azVar) {
        e eVar = this.AI;
        if (eVar != null) {
            eVar.b(azVar);
        }
    }

    /* JADX WARN: Code duplicated, block: B:31:0x006b  */
    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(com.kwad.components.core.webview.jshandler.a.C0464a c0464a) {
        if (this.ub == null || this.ub.sq == null) {
            return;
        }
        try {
            com.kwad.components.core.webview.jshandler.a.c cVar = new com.kwad.components.core.webview.jshandler.a.c();
            cVar.parseJson(new JSONObject(c0464a.apv));
            switch (c0464a.apu) {
                case "adClickCallback":
                    this.ub.sq.cY();
                    break;
                case "videoPlayStartCallback":
                    this.ub.sq.onVideoPlayStart();
                    break;
                case "videoPlayErrorCallback":
                    this.ub.sq.onVideoPlayError(cVar.errorCode, cVar.apw);
                    break;
                case "videoPlayEndCallback":
                    this.ub.sq.onVideoPlayEnd();
                    break;
                case "adSkipWithPlayTimeCallback":
                    this.ub.sq.onVideoSkipToEnd(cVar.apx);
                    break;
                case "adCloseCallback":
                    this.ub.sq.i(cVar.apy);
                    break;
                case "rewardVerifyCallback":
                    this.ub.sq.onRewardVerify();
                    break;
            }
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.e("TKBasePresenter", "onOutCallback Error: " + th.getMessage());
        }
    }

    public void a(n nVar) {
        if (this.ub.sr != null) {
            this.ub.sr.setAudioEnabled(!nVar.auv, true);
        }
    }

    public void a(com.kwad.sdk.core.webview.d.b.a aVar) {
        this.ub.sq.cY();
    }

    public final void a(com.kwad.components.ad.reward.c.b bVar) {
        if (this.ub != null) {
            this.ub.b(bVar);
        }
    }

    public void a(o oVar) {
        this.AB = oVar;
        if (this.ub.sr != null) {
            this.ub.sr.a(this.kx);
        }
        by.runOnUiThread(new bi() { // from class: com.kwad.components.ad.reward.presenter.f.d.4
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                boolean z = com.kwad.components.core.t.a.aN(d.this.getContext()).wP() || !d.this.ub.mVideoPlayConfig.isVideoSoundEnable();
                n nVar = new n();
                nVar.auv = z;
                d.this.AB.c(nVar);
                if (d.this.ub.sr != null) {
                    d.this.ub.sr.setAudioEnabled(!z, false);
                }
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void iR() {
        if (this.ub.sL) {
            kn();
        } else {
            km();
        }
    }

    public final void a(long j, long j2) {
        d(j, j2);
        e(j2);
    }

    @Override // com.kwad.components.core.webview.tachikoma.b.y.a
    public final void a(TKAdLiveShopItemInfo tKAdLiveShopItemInfo) {
        this.ub.mAdTemplate.tkLiveShopItemInfo = tKAdLiveShopItemInfo;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void kh() {
        com.kwad.sdk.core.adlog.c.b(this.ub.mAdTemplate, 17, this.ub.mReportExtData);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void ki() {
        this.ub.C(kp());
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void kj() {
        com.kwad.components.ad.reward.j.b.a(this.ub.mAdTemplate, kp(), "endTopBar", new com.kwad.sdk.core.adlog.c.b().dS(39).f(this.ub.mRootContainer.getTouchCoords()), this.ub.mReportExtData);
        this.ub.sq.cY();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void kk() {
        com.kwad.components.ad.reward.j.b.a(this.ub.mAdTemplate, kp(), (String) null, new com.kwad.sdk.core.adlog.c.b().dS(40).f(this.ub.mRootContainer.getTouchCoords()), this.ub.mReportExtData);
        this.ub.sq.cY();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void kl() {
        com.kwad.components.ad.reward.j.b.a(this.ub.mAdTemplate, kp(), (String) null, new com.kwad.sdk.core.adlog.c.b().dS(41).f(this.ub.mRootContainer.getTouchCoords()), this.ub.mReportExtData);
        this.ub.sq.cY();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void notifyRewardVerify() {
        this.ub.sq.onRewardVerify();
    }

    private void km() {
        this.AF.aji = true;
        this.AF.auD = false;
        this.AF.ri = com.kwad.sdk.core.response.helper.a.N(com.kwad.sdk.core.response.helper.e.eM(this.ub.mAdTemplate));
        ko();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void kn() {
        this.AF.auD = true;
        this.AF.aji = false;
        ko();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void e(double d) {
        this.AF.auD = false;
        this.AF.aji = false;
        this.AF.ri = (int) ((d / 1000.0d) + 0.5d);
        ko();
    }

    private void d(long j, long j2) {
        long jMin = Math.min(com.kwad.sdk.core.response.helper.a.ak(this.ub.mAdTemplate.adInfoList.get(0)), j);
        if (j2 < jMin - 800) {
            this.ub.tc = (int) (((jMin - j2) / 1000.0f) + 0.5f);
        }
    }

    private void ko() {
        z zVar;
        p pVar = this.AA;
        if (pVar == null || (zVar = this.AF) == null) {
            return;
        }
        pVar.a(zVar);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public String kp() {
        com.kwad.components.ad.reward.k.a.d dVar = this.Az;
        if (dVar == null) {
            return null;
        }
        return dVar.getTkTemplateId();
    }
}

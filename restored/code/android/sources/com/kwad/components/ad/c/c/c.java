package com.kwad.components.ad.c.c;

import android.animation.ObjectAnimator;
import android.os.Handler;
import android.os.SystemClock;
import android.text.TextUtils;
import android.view.View;
import android.view.ViewGroup;
import android.widget.FrameLayout;
import com.kwad.components.ad.KsAdLoadManager;
import com.kwad.components.ad.c.g;
import com.kwad.components.core.request.j;
import com.kwad.components.core.request.model.ImpInfo;
import com.kwad.components.core.t.t;
import com.kwad.sdk.R;
import com.kwad.sdk.commercial.convert.d;
import com.kwad.sdk.core.config.e;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.internal.api.SceneImpl;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.l;
import com.sigmob.sdk.base.mta.PointType;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends a {
    private com.kwad.components.ad.c.b.a cP;
    private com.kwad.components.ad.c.b.a cQ;
    private FrameLayout cR;
    private boolean cS;
    private boolean cT;
    private boolean cU;
    private long cV;
    private boolean cX;
    boolean db;
    private long startTime;
    private Handler handler = new Handler();
    private boolean cW = false;
    private boolean cY = true;
    private bi cZ = new bi() { // from class: com.kwad.components.ad.c.c.c.1
        @Override // com.kwad.sdk.utils.bi
        public final void doTask() {
            if (c.this.cY) {
                c.this.cV = System.currentTimeMillis() - c.this.startTime;
                if (!c.this.cT || (c.this.cV >= e.KP() && com.kwad.sdk.core.response.helper.a.dB(com.kwad.sdk.core.response.helper.e.eM(c.this.cO.mAdTemplate)))) {
                    c.this.ay();
                    c.this.cU = true;
                    c.b(c.this, true);
                    if (c.this.cV >= e.KP()) {
                        c.this.startTime = System.currentTimeMillis();
                    }
                }
                if (com.kwad.sdk.core.response.helper.a.dB(com.kwad.sdk.core.response.helper.e.eM(c.this.cO.mAdTemplate))) {
                    c.this.handler.postDelayed(this, 1000L);
                }
            }
        }
    };
    private int da = 0;

    static /* synthetic */ boolean b(c cVar, boolean z) {
        cVar.cT = true;
        return true;
    }

    static /* synthetic */ boolean d(c cVar, boolean z) {
        cVar.cW = true;
        return true;
    }

    static /* synthetic */ boolean e(c cVar, boolean z) {
        cVar.cX = true;
        return true;
    }

    @Override // com.kwad.components.ad.c.c.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.cR = (FrameLayout) findViewById(R.id.ksad_banner_base_content);
        this.startTime = System.currentTimeMillis();
        aw();
        b(this.cR);
    }

    private void b(ViewGroup viewGroup) {
        if (e.Kr() || e.Kq() < 0.0f) {
            return;
        }
        com.kwad.components.core.widget.a aVar = new com.kwad.components.core.widget.a(viewGroup.getContext(), viewGroup);
        viewGroup.addView(aVar);
        aVar.setViewCallback(new com.kwad.components.core.widget.a.InterfaceC0474a() { // from class: com.kwad.components.ad.c.c.c.2
            @Override // com.kwad.components.core.widget.a.InterfaceC0474a
            public final void aA() {
            }

            @Override // com.kwad.components.core.widget.a.InterfaceC0474a
            public final void ae() {
            }

            @Override // com.kwad.components.core.widget.a.InterfaceC0474a
            public final void af() {
            }

            @Override // com.kwad.components.core.widget.a.InterfaceC0474a
            public final void onWindowFocusChanged(boolean z) {
                if (z) {
                    c.this.cY = true;
                    c.this.startTime = System.currentTimeMillis() - c.this.cV;
                    c.this.aw();
                    return;
                }
                c.this.cY = false;
                c.this.ax();
            }

            @Override // com.kwad.components.core.widget.a.InterfaceC0474a
            public final void b(View view) {
                c.this.aw();
            }
        });
        aVar.zY();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void aw() {
        this.handler.removeCallbacksAndMessages(this.cZ);
        this.handler.post(this.cZ);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void ax() {
        this.handler.removeCallbacksAndMessages(this.cZ);
    }

    public final void ay() {
        if (this.cU || this.cO.bT.isEmpty()) {
            return;
        }
        try {
            com.kwad.components.ad.c.b.a aVar = new com.kwad.components.ad.c.b.a(getContext(), this.cO.bT.get(this.da), new com.kwad.components.ad.c.b.a.InterfaceC0359a() { // from class: com.kwad.components.ad.c.c.c.3
                @Override // com.kwad.components.ad.c.b.a.InterfaceC0359a
                public final void d(AdTemplate adTemplate) {
                    if (!c.this.cW) {
                        try {
                            if (c.this.cO.bU > 0) {
                                d.b(com.kwad.sdk.core.response.helper.e.eG(c.this.cO.mAdTemplate), 1, SystemClock.elapsedRealtime() - c.this.cO.bU);
                            }
                        } catch (Throwable th) {
                            ServiceProvider.reportSdkCaughtException(th);
                        }
                        c.d(c.this, true);
                    }
                    if (adTemplate.mPvReported) {
                        return;
                    }
                    com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
                    com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
                    c0502a.templateId = PointType.ANTI_SPAM;
                    c0502a.aLu = com.kwad.sdk.core.response.helper.a.dB(com.kwad.sdk.core.response.helper.e.eM(c.this.cO.mAdTemplate)) ? 1 : 2;
                    bVar.b(c0502a);
                    com.kwad.components.core.t.b.wR().a(adTemplate, null, bVar);
                    c.this.cO.aa();
                }

                @Override // com.kwad.components.ad.c.b.a.InterfaceC0359a
                public final void a(final int i, int i2, final AdTemplate adTemplate) {
                    com.kwad.components.core.e.d.a.C0428a c0428aA = new com.kwad.components.core.e.d.a.C0428a(c.this.getContext()).aF(adTemplate).ax(true).b(new com.kwad.components.core.e.d.d(adTemplate)).au(false).aD(i2).aC(i).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.c.c.c.3.1
                        @Override // com.kwad.components.core.e.d.a.b
                        public final void onAdClicked() {
                            com.kwad.sdk.core.adlog.c.a aVar2 = new com.kwad.sdk.core.adlog.c.a();
                            aVar2.QR = new com.kwad.sdk.core.adlog.a.C0502a();
                            aVar2.QR.templateId = PointType.ANTI_SPAM;
                            aVar2.ne = i;
                            com.kwad.sdk.core.adlog.c.a(adTemplate, aVar2, (JSONObject) null);
                        }
                    });
                    com.kwad.components.core.e.d.a.a(c0428aA);
                    if (com.kwad.components.core.e.d.a.c(c0428aA)) {
                        return;
                    }
                    c.this.cO.ab();
                }

                @Override // com.kwad.components.ad.c.b.a.InterfaceC0359a
                public final void e(AdTemplate adTemplate) {
                    com.kwad.sdk.core.adlog.c.h(adTemplate, (JSONObject) null);
                    c.this.cO.ac();
                    c.this.cO.bQ.removeAllViews();
                    c.this.handler.removeCallbacksAndMessages(null);
                    c.this.onDestroy();
                }

                @Override // com.kwad.components.ad.c.b.a.InterfaceC0359a
                public final void au() {
                    c.this.cO.c(0, "onMediaPlayError");
                }
            });
            aVar.a(this.cO.bS);
            this.cO.b(this.cO.bT.get(this.da));
            if (!this.cS) {
                this.cP = aVar;
                this.cR.addView(aVar);
                this.cP.aq();
                this.handler.postDelayed(new bi() { // from class: com.kwad.components.ad.c.c.c.4
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        if (c.this.cQ != null) {
                            c.this.cR.removeView(c.this.cQ);
                        }
                        c.this.cU = false;
                    }
                }, 500L);
                this.cS = true;
            } else {
                this.cQ = aVar;
                this.cR.addView(aVar);
                this.cQ.aq();
                this.handler.postDelayed(new bi() { // from class: com.kwad.components.ad.c.c.c.5
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        if (c.this.cP != null) {
                            c.this.cR.removeView(c.this.cP);
                        }
                        c.this.cU = false;
                    }
                }, 500L);
                this.cS = false;
            }
            int i = this.da + 1;
            this.da = i;
            if (i == this.cO.bT.size()) {
                az();
                this.da = 0;
            }
            if (!this.db) {
                this.db = true;
                return;
            }
            ObjectAnimator objectAnimatorOfFloat = ObjectAnimator.ofFloat(aVar, "translationX", this.cR.getWidth(), 0.0f);
            objectAnimatorOfFloat.setDuration(300L);
            objectAnimatorOfFloat.start();
        } catch (Exception e) {
            com.kwad.components.core.d.a.reportSdkCaughtException(e);
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
        }
    }

    public final void az() {
        SceneImpl sceneImplCovert = SceneImpl.covert(g.cf);
        sceneImplCovert.setBidResponse(null);
        sceneImplCovert.setBidResponseV2(null);
        com.kwad.sdk.commercial.convert.e.c(sceneImplCovert);
        boolean zB = t.xg().b(sceneImplCovert, "loadBannerAd");
        sceneImplCovert.setAdStyle(5);
        KsAdLoadManager.O().a(new com.kwad.components.core.request.model.a.C0459a().e(new ImpInfo(sceneImplCovert)).aZ(zB).a(new j() { // from class: com.kwad.components.ad.c.c.c.7
            @Override // com.kwad.components.core.request.j
            public final void ak() {
            }
        }).a(new com.kwad.components.core.request.d() { // from class: com.kwad.components.ad.c.c.c.6
            @Override // com.kwad.components.core.request.d, com.kwad.components.core.request.l
            public final void onError(int i, String str) {
                c.this.handler.postDelayed(new bi() { // from class: com.kwad.components.ad.c.c.c.6.1
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        if (c.this.cX) {
                            c.this.cU = true;
                        } else {
                            c.this.az();
                            c.e(c.this, true);
                        }
                    }
                }, e.KP());
            }

            @Override // com.kwad.components.core.request.d, com.kwad.components.core.request.c
            public final void a(AdResultData adResultData, boolean z) {
                c.this.cO.bT = adResultData.getAdTemplateList();
                if (c.this.cO.bT.isEmpty()) {
                    onError(com.kwad.sdk.core.network.e.aTe.errorCode, TextUtils.isEmpty(adResultData.testErrorMsg) ? com.kwad.sdk.core.network.e.aTe.msg : adResultData.testErrorMsg);
                    l.as("bannerAd_", "数据为空");
                }
            }
        }).wp());
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onDestroy() {
        super.onDestroy();
        this.handler.removeCallbacksAndMessages(null);
    }
}

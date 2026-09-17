package com.kwad.components.ad.interstitial.h;

import android.content.Context;
import android.os.SystemClock;
import android.util.AttributeSet;
import android.view.ViewGroup;
import com.kwad.components.ad.interstitial.f.f;
import com.kwad.components.core.webview.tachikoma.f.g;
import com.kwad.sdk.R;
import com.kwad.sdk.api.KsAdVideoPlayConfig;
import com.kwad.sdk.api.KsInterstitialAd;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.as;
import com.kwad.sdk.widget.KSFrameLayout;
import com.kwad.sdk.wrapper.m;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class c extends a {
    public KsAdVideoPlayConfig ce;
    public KsInterstitialAd.AdInteractionListener lk;
    public com.kwad.components.ad.interstitial.d lp;
    protected AdInfo mAdInfo;
    public AdResultData mAdResultData;
    protected AdTemplate mAdTemplate;
    protected com.kwad.components.ad.interstitial.f.c mF;
    private boolean mJ;
    private com.kwad.components.ad.interstitial.f.c.a mK;
    private g mM;
    private int mT;
    protected com.kwad.components.ad.interstitial.f.b os;
    private boolean ot;
    public ViewGroup ou;

    static /* synthetic */ boolean a(c cVar, boolean z) {
        cVar.ot = false;
        return false;
    }

    public c(Context context) {
        this(context, null);
    }

    public c(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        this.mT = -1;
        this.mM = new g() { // from class: com.kwad.components.ad.interstitial.h.c.1
            @Override // com.kwad.components.core.webview.tachikoma.f.b
            public final void v(String str) {
                if ("tk_interstitial".equals(str)) {
                    c.a(c.this, false);
                    if (c.this.os != null) {
                        c.this.os.ob();
                    }
                    c cVar = c.this;
                    cVar.os = cVar.fe();
                    c.this.os.N(c.this.ou);
                    c.this.os.q(c.this.mF);
                }
            }

            @Override // com.kwad.components.core.webview.tachikoma.f.g
            public final void a(String str, long j, long j2, long j3) {
                c.this.mF.mS = true;
                try {
                    if (c.this.lp.mStartRenderTime > 0) {
                        com.kwad.sdk.commercial.convert.d.b(com.kwad.sdk.core.response.helper.e.eG(c.this.mF.mAdTemplate), 2, SystemClock.elapsedRealtime() - c.this.lp.mStartRenderTime);
                    }
                } catch (Throwable th) {
                    ServiceProvider.reportSdkCaughtException(th);
                }
            }
        };
        this.ou = (ViewGroup) m.inflate(context, getLayoutId(), this);
    }

    protected int getLayoutId() {
        return R.layout.ksad_interstitial;
    }

    public void setTkLoadListenerAdapter(g gVar) {
        this.mM = gVar;
    }

    private com.kwad.components.ad.interstitial.f.c fd() {
        com.kwad.components.ad.interstitial.f.c cVar = new com.kwad.components.ad.interstitial.f.c();
        cVar.a(this.mAdResultData);
        cVar.setAdTemplate(this.mAdTemplate);
        cVar.lk = this.lk;
        cVar.lp = this.lp;
        cVar.mApkDownloadHelper = new com.kwad.components.core.e.d.d(this.mAdTemplate);
        cVar.ce = this.ce;
        cVar.cB = new com.kwad.sdk.core.video.videoview.a(this.mContext);
        cVar.gh = (KSFrameLayout) this.ou.findViewById(R.id.ksad_container);
        cVar.li = new com.kwad.components.ad.interstitial.g.b(cVar.gh, com.kwad.sdk.core.config.e.JI());
        cVar.li.Am();
        cVar.mT = this.mT;
        cVar.mJ = this.mJ;
        cVar.mK = this.mK;
        cVar.mM = this.mM;
        cVar.mG = a(this.mContext, com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate), cVar);
        return cVar;
    }

    private d a(Context context, AdInfo adInfo, com.kwad.components.ad.interstitial.f.c cVar) {
        boolean zA = com.kwad.components.ad.interstitial.f.c.a(this.mContext, adInfo);
        d.a aVar = new d.a();
        aVar.w(zA);
        boolean z = true;
        aVar.x(!cVar.M(context) && com.kwad.components.ad.interstitial.b.b.dN());
        aVar.R(com.kwad.components.ad.interstitial.b.b.dO());
        if (com.kwad.sdk.core.response.helper.a.bc(adInfo) && as.VV()) {
            z = false;
        }
        aVar.y(z);
        return new d(context, aVar);
    }

    public final com.kwad.components.ad.interstitial.f.b fe() {
        com.kwad.components.ad.interstitial.f.b bVar = new com.kwad.components.ad.interstitial.f.b();
        if (this.ot) {
            bVar.a(new com.kwad.components.ad.interstitial.f.a.b());
        } else {
            if (com.kwad.sdk.core.response.helper.a.bi(this.mAdInfo)) {
                bVar.a(new f());
            }
            bVar.a(new com.kwad.components.ad.interstitial.f.g());
            bVar.a(new com.kwad.components.ad.interstitial.f.d());
            if (com.kwad.sdk.core.response.helper.a.aV(this.mAdInfo)) {
                bVar.a(new com.kwad.components.ad.interstitial.f.a());
            }
            if (this.mF.M(getContext())) {
                bVar.a(new com.kwad.components.ad.interstitial.f.e());
            }
            try {
                if (this.lp.mStartRenderTime > 0) {
                    com.kwad.sdk.commercial.convert.d.b(com.kwad.sdk.core.response.helper.e.eG(this.mF.mAdTemplate), 1, SystemClock.elapsedRealtime() - this.lp.mStartRenderTime);
                }
            } catch (Throwable th) {
                ServiceProvider.reportSdkCaughtException(th);
            }
        }
        return bVar;
    }

    @Override // com.kwad.components.ad.interstitial.h.a
    public void setAdInteractionListener(KsInterstitialAd.AdInteractionListener adInteractionListener) {
        this.lk = adInteractionListener;
        com.kwad.components.ad.interstitial.f.c cVar = this.mF;
        if (cVar != null) {
            cVar.lk = adInteractionListener;
        }
    }

    public void setAggregateAdView(boolean z) {
        this.mJ = z;
        com.kwad.components.ad.interstitial.f.c cVar = this.mF;
        if (cVar != null) {
            cVar.mJ = z;
        }
    }

    public void setAdAggregateClickActionListener(com.kwad.components.ad.interstitial.f.c.a aVar) {
        this.mK = aVar;
        com.kwad.components.ad.interstitial.f.c cVar = this.mF;
        if (cVar != null) {
            cVar.mK = aVar;
        }
    }

    @Override // com.kwad.components.ad.interstitial.h.a
    public final void a(AdResultData adResultData, com.kwad.components.ad.interstitial.d dVar, KsAdVideoPlayConfig ksAdVideoPlayConfig, KsInterstitialAd.AdInteractionListener adInteractionListener, int i) {
        a(adResultData, i);
        this.mAdTemplate.realShowType = 2;
        this.ce = ksAdVideoPlayConfig;
        this.lp = dVar;
        this.ot = com.kwad.sdk.core.response.helper.b.dE(this.mAdTemplate);
        this.lk = adInteractionListener;
        this.mF = fd();
        if (this.os == null) {
            this.os = fe();
        }
        this.os.N(this.ou);
        this.os.q(this.mF);
    }

    @Override // com.kwad.components.ad.interstitial.h.a
    public final void a(AdResultData adResultData, com.kwad.components.ad.interstitial.d dVar, KsAdVideoPlayConfig ksAdVideoPlayConfig, KsInterstitialAd.AdInteractionListener adInteractionListener, int i, boolean z) {
        a(adResultData, i);
        this.mAdTemplate.realShowType = 2;
        this.ce = ksAdVideoPlayConfig;
        this.lp = dVar;
        this.ot = z;
        this.lk = adInteractionListener;
        this.mF = fd();
        if (this.os == null) {
            this.os = fe();
        }
        this.os.N(this.ou);
        this.os.q(this.mF);
    }

    public void a(AdResultData adResultData, int i) {
        List<AdTemplate> adTemplateList = adResultData.getAdTemplateList();
        if (adTemplateList != null && i < adTemplateList.size()) {
            this.mAdTemplate = adTemplateList.get(i);
        } else {
            this.mAdTemplate = com.kwad.sdk.core.response.helper.c.r(adResultData);
        }
        this.mAdResultData = com.kwad.sdk.core.response.helper.c.a(adResultData, this.mAdTemplate);
        this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate);
    }

    public void setAggregateShowTriggerType(int i) {
        this.mT = i;
        com.kwad.components.ad.interstitial.f.c cVar = this.mF;
        if (cVar != null) {
            cVar.mT = i;
        }
    }

    @Override // android.view.ViewGroup, android.view.View
    protected void onDetachedFromWindow() {
        super.onDetachedFromWindow();
        com.kwad.components.ad.interstitial.f.c cVar = this.mF;
        if (cVar != null) {
            cVar.release();
        }
        com.kwad.components.ad.interstitial.f.b bVar = this.os;
        if (bVar != null) {
            bVar.destroy();
        }
    }

    @Override // com.kwad.components.ad.interstitial.h.a
    public final void dF() {
        com.kwad.components.ad.interstitial.f.b bVar = this.os;
        if (bVar != null) {
            bVar.dW();
        }
    }

    @Override // com.kwad.components.ad.interstitial.h.a
    public final void dG() {
        com.kwad.components.ad.interstitial.f.b bVar = this.os;
        if (bVar != null) {
            bVar.dX();
        }
    }

    public final void ff() {
        com.kwad.components.ad.interstitial.f.c cVar = this.mF;
        if (cVar == null || !cVar.mR) {
            return;
        }
        this.mF.dY();
    }

    public final void fg() {
        com.kwad.components.ad.interstitial.f.c cVar = this.mF;
        if (cVar != null) {
            if (this.ot || cVar.mR) {
                this.mF.dZ();
            }
        }
    }

    public final void fh() {
        if (this.mF != null) {
            this.mF.a(new com.kwad.components.ad.interstitial.f.c.C0377c(this.mContext).l(true).M(1).n(true).L(2));
        }
    }

    public final boolean fi() {
        com.kwad.components.ad.interstitial.f.c cVar = this.mF;
        if (cVar != null) {
            return cVar.mS;
        }
        return false;
    }
}

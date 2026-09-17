package com.kwad.components.ad.nativead;

import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import com.kwad.components.ad.nativead.b.h;
import com.kwad.components.ad.nativead.b.i;
import com.kwad.components.ad.nativead.b.j;
import com.kwad.components.ad.nativead.b.k;
import com.kwad.components.core.video.DetailVideoView;
import com.kwad.sdk.R;
import com.kwad.sdk.api.KsAdVideoPlayConfig;
import com.kwad.sdk.api.KsNativeAd;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.view.AdBasePvFrameLayout;
import com.kwad.sdk.mvp.Presenter;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import com.kwad.sdk.utils.o;
import com.kwad.sdk.widget.KSFrameLayout;
import com.kwad.sdk.widget.l;
import com.kwad.sdk.wrapper.m;

/* JADX INFO: loaded from: classes3.dex */
public final class f extends KSFrameLayout {
    private l eR;
    private com.kwad.components.core.widget.a.c fs;
    private AdTemplate mAdTemplate;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;
    private DetailVideoView mDetailVideoView;
    private Presenter mPresenter;
    private AdBasePvFrameLayout pJ;
    private com.kwad.components.ad.nativead.a.b pO;
    public com.kwad.components.ad.nativead.d.a pP;
    private KsAdVideoPlayConfig pQ;
    private boolean pR;
    private boolean pS;
    private KsNativeAd.VideoPlayListener pn;
    private d.a pv;

    public f(Context context) {
        this(context, null);
    }

    private f(Context context, AttributeSet attributeSet) {
        this(context, null, 0);
    }

    private f(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, 0);
        this.pR = false;
        this.pS = false;
        this.eR = new l() { // from class: com.kwad.components.ad.nativead.f.1
            @Override // com.kwad.sdk.widget.l
            public final void aV() {
                o.fp(f.this.mAdTemplate);
            }
        };
        B(context);
    }

    public final void g(int i, int i2) {
        if (i == 0) {
            this.pS = true;
        }
        if (i2 == 0) {
            this.pR = true;
        }
    }

    private void B(Context context) {
        m.inflate(context, R.layout.ksad_native_video_layout, this);
        AdBasePvFrameLayout adBasePvFrameLayout = (AdBasePvFrameLayout) findViewById(R.id.ksad_root_container);
        this.pJ = adBasePvFrameLayout;
        DetailVideoView detailVideoView = (DetailVideoView) adBasePvFrameLayout.findViewById(R.id.ksad_video_player);
        this.mDetailVideoView = detailVideoView;
        detailVideoView.setAd(true);
        this.fs = new g(getParent() == null ? this : (View) getParent());
    }

    public final void setInnerAdInteractionListener(d.a aVar) {
        this.pv = aVar;
    }

    public final void setVideoPlayListener(KsNativeAd.VideoPlayListener videoPlayListener) {
        this.pn = videoPlayListener;
    }

    public final void setPlayState(int i) {
        com.kwad.components.ad.nativead.d.a aVar = this.pP;
        if (aVar != null) {
            aVar.V(i);
        }
    }

    public final void a(AdTemplate adTemplate, com.kwad.components.core.e.d.d dVar, KsAdVideoPlayConfig ksAdVideoPlayConfig) {
        this.mAdTemplate = adTemplate;
        this.mApkDownloadHelper = dVar;
        this.pQ = ksAdVideoPlayConfig;
        this.pJ.setVisibleListener(this.eR);
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout
    public final void ae() {
        super.ae();
        if (this.pP == null) {
            if (this.fs == null) {
                this.fs = new g(getParent() == null ? this : (View) getParent());
            }
            this.pP = new com.kwad.components.ad.nativead.d.a(this.mAdTemplate, this.fs, this.mDetailVideoView, this.pQ);
        }
        this.pO = fA();
        Presenter presenterBF = bF();
        this.mPresenter = presenterBF;
        presenterBF.N(this.pJ);
        this.mPresenter.q(this.pO);
        com.kwad.components.core.widget.a.c cVar = this.fs;
        if (cVar != null) {
            cVar.Am();
        }
        this.pP.bq();
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout
    public final void af() {
        super.af();
        by.runOnUiThread(new bi() { // from class: com.kwad.components.ad.nativead.f.2
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                if (f.this.fs != null) {
                    f.this.fs.release();
                }
                if (f.this.pP != null) {
                    f.this.pP.bs();
                }
                if (f.this.pO != null) {
                    f.this.pO.release();
                }
                if (f.this.mPresenter != null) {
                    f.this.mPresenter.destroy();
                }
            }
        });
    }

    private com.kwad.components.ad.nativead.a.b fA() {
        com.kwad.components.ad.nativead.a.b bVar = new com.kwad.components.ad.nativead.a.b();
        bVar.pJ = this.pJ;
        bVar.mAdTemplate = this.mAdTemplate;
        bVar.pv = this.pv;
        bVar.pn = this.pn;
        if (com.kwad.sdk.core.response.helper.a.aL(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate))) {
            com.kwad.components.core.e.d.d dVar = this.mApkDownloadHelper;
            if (dVar == null) {
                bVar.mApkDownloadHelper = new com.kwad.components.core.e.d.d(this.mAdTemplate);
            } else {
                dVar.qk();
                bVar.mApkDownloadHelper = this.mApkDownloadHelper;
            }
        }
        bVar.pV = this.pS;
        bVar.pU = this.pR;
        bVar.pP = this.pP;
        return bVar;
    }

    private Presenter bF() {
        Presenter presenter = new Presenter();
        presenter.a(new com.kwad.components.ad.nativead.b.e());
        presenter.a(new com.kwad.components.ad.nativead.b.c());
        presenter.a(new i());
        presenter.a(new j());
        presenter.a(new com.kwad.components.ad.nativead.b.d());
        presenter.a(new com.kwad.components.ad.nativead.b.b());
        presenter.a(new k());
        presenter.a(new com.kwad.components.ad.nativead.b.a(this.pQ));
        presenter.a(new com.kwad.components.ad.nativead.b.g());
        if (com.kwad.sdk.core.response.helper.a.aL(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate))) {
            presenter.a(new com.kwad.components.ad.nativead.b.f());
        } else {
            presenter.a(new h());
        }
        return presenter;
    }
}

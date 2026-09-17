package com.kwad.components.ad.draw.view;

import android.app.Activity;
import android.content.Context;
import android.os.SystemClock;
import android.view.View;
import android.widget.ImageView;
import com.kwad.components.core.video.DetailVideoView;
import com.kwad.components.core.video.l;
import com.kwad.components.core.video.m;
import com.kwad.sdk.R;
import com.kwad.sdk.api.KsDrawAd;
import com.kwad.sdk.core.c.d;
import com.kwad.sdk.core.config.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.view.AdBaseFrameLayout;
import com.kwad.sdk.mvp.Presenter;
import com.kwad.sdk.widget.KSFrameLayout;
import java.lang.ref.WeakReference;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends KSFrameLayout {
    private com.kwad.sdk.core.j.b dA;
    private com.kwad.components.ad.draw.b.b dL;
    private boolean dM;
    private com.kwad.components.ad.draw.c.a dN;
    private KsDrawAd.AdInteractionListener du;
    private boolean eP;
    private ImageView fX;
    private long fY;
    private View.OnClickListener fZ;
    private com.kwad.components.core.widget.a.c fs;
    private l ga;
    private AdInfo mAdInfo;
    private AdTemplate mAdTemplate;
    private Context mContext;
    private DetailVideoView mDetailVideoView;
    private Presenter mPresenter;
    private AdBaseFrameLayout mRootContainer;

    public b(Context context) {
        super(context);
        this.dM = false;
        this.fZ = new View.OnClickListener() { // from class: com.kwad.components.ad.draw.view.b.2
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(b.this.dL.mRootContainer.getContext()).aF(b.this.dL.mAdTemplate).b(b.this.dL.mApkDownloadHelper).as(false).aD(3).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.draw.view.b.2.1
                    @Override // com.kwad.components.core.e.d.a.b
                    public final void onAdClicked() {
                        b.this.notifyAdClick();
                    }
                }));
                b.this.bI();
            }
        };
        this.ga = new m() { // from class: com.kwad.components.ad.draw.view.b.3
            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayPaused() {
                super.onMediaPlayPaused();
                b.this.fX.setVisibility(0);
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlaying() {
                super.onMediaPlaying();
                b.this.fX.setVisibility(8);
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayStart() {
                super.onMediaPlayStart();
                b.this.fX.setVisibility(8);
                com.kwad.components.ad.draw.a.b.a(b.this.mAdTemplate, SystemClock.elapsedRealtime() - b.this.fY);
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayError(int i, int i2) {
                super.onMediaPlayError(i, i2);
                com.kwad.components.ad.draw.a.b.a(b.this.mAdTemplate, SystemClock.elapsedRealtime() - b.this.fY, "what : " + i + " extra : " + i2);
            }
        };
        this.mContext = context;
        initView();
    }

    private void initView() {
        com.kwad.sdk.wrapper.m.inflate(this.mContext, R.layout.ksad_draw_layout, this);
        AdBaseFrameLayout adBaseFrameLayout = (AdBaseFrameLayout) findViewById(R.id.ksad_root_container);
        this.mRootContainer = adBaseFrameLayout;
        this.fX = (ImageView) adBaseFrameLayout.findViewById(R.id.ksad_video_control_button);
        DetailVideoView detailVideoView = (DetailVideoView) this.mRootContainer.findViewById(R.id.ksad_video_player);
        this.mDetailVideoView = detailVideoView;
        detailVideoView.g(true, e.KJ());
        this.mDetailVideoView.setOnClickListener(this.fZ);
        this.fX.setOnClickListener(this.fZ);
        final WeakReference weakReference = new WeakReference(com.kwad.sdk.wrapper.m.getActivityFromContext(this.mContext));
        com.kwad.sdk.core.c.b.Mh();
        com.kwad.sdk.core.c.b.a(new d() { // from class: com.kwad.components.ad.draw.view.b.1
            @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
            /* JADX INFO: renamed from: onActivityDestroyed */
            public final void b(Activity activity) {
                Activity activity2 = (Activity) weakReference.get();
                if (activity2 == null || !activity2.equals(activity)) {
                    return;
                }
                b.this.bL();
                com.kwad.sdk.core.c.b.Mh();
                com.kwad.sdk.core.c.b.b((com.kwad.sdk.core.c.c) this);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void bI() {
        if (com.kwad.sdk.core.response.helper.a.aL(this.mAdInfo)) {
            if (3 == com.kwad.sdk.core.response.helper.a.bE(com.kwad.sdk.core.response.helper.e.eM(this.dL.mAdTemplate))) {
                bJ();
            }
        } else if (1 == com.kwad.sdk.core.response.helper.a.bE(com.kwad.sdk.core.response.helper.e.eM(this.dL.mAdTemplate))) {
            bJ();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void notifyAdClick() {
        com.kwad.sdk.core.adlog.c.a(this.mAdTemplate, new com.kwad.sdk.core.adlog.c.b().f(this.dL.mRootContainer.getTouchCoords()).dS(85), (JSONObject) null);
        if (this.dL.du != null) {
            this.dL.du.onAdClicked();
        }
        if (this.dM) {
            return;
        }
        AdTemplate adTemplate = this.mAdTemplate;
        com.kwad.components.ad.draw.a.c.b(adTemplate, 1, com.kwad.sdk.core.response.helper.b.dA(adTemplate) ? 2 : 1);
        this.dM = true;
    }

    private void bJ() {
        this.dN.g(!this.eP);
        if (!this.eP) {
            this.dN.pause();
        } else {
            this.dN.resume();
        }
        this.eP = !this.eP;
    }

    public final void setVideoSound(boolean z) {
        com.kwad.components.ad.draw.c.a aVar = this.dN;
        if (aVar != null) {
            aVar.setVideoSound(z);
        }
    }

    public final void play() {
        com.kwad.components.ad.draw.c.a aVar = this.dN;
        if (aVar == null || aVar.bt()) {
            return;
        }
        this.dN.fy = 1;
        this.dN.g(false);
        this.dN.resume();
    }

    public final void pause() {
        com.kwad.components.ad.draw.c.a aVar = this.dN;
        if (aVar == null || aVar.bt()) {
            return;
        }
        this.dN.fy = 2;
        this.dN.g(true);
        this.dN.pause();
    }

    public final void setPageExitListener(com.kwad.sdk.core.j.b bVar) {
        this.dA = bVar;
    }

    public final void setAdInteractionListener(KsDrawAd.AdInteractionListener adInteractionListener) {
        this.du = adInteractionListener;
    }

    public final void k(AdTemplate adTemplate) {
        this.mAdTemplate = adTemplate;
        this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        this.fs = new com.kwad.components.ad.draw.b(this);
        com.kwad.components.ad.draw.a.b.g(this.mAdTemplate);
        this.fY = SystemClock.elapsedRealtime();
        this.dN = new com.kwad.components.ad.draw.c.a(this.mAdTemplate, this.fs, this.mDetailVideoView);
        bK();
    }

    private void bK() {
        this.dL = bE();
        Presenter presenterBF = bF();
        this.mPresenter = presenterBF;
        presenterBF.N(this.mRootContainer);
        this.mPresenter.q(this.dL);
        this.fs.a(this.dA);
        this.fs.Am();
        this.dN.bq();
        this.dN.b(this.ga);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void bL() {
        com.kwad.components.core.widget.a.c cVar = this.fs;
        if (cVar != null) {
            cVar.release();
        }
        com.kwad.components.ad.draw.c.a aVar = this.dN;
        if (aVar != null) {
            aVar.bs();
            this.dN.a(this.ga);
        }
        com.kwad.components.ad.draw.b.b bVar = this.dL;
        if (bVar != null) {
            bVar.release();
        }
        Presenter presenter = this.mPresenter;
        if (presenter != null) {
            presenter.destroy();
        }
    }

    private com.kwad.components.ad.draw.b.b bE() {
        com.kwad.components.ad.draw.b.b bVar = new com.kwad.components.ad.draw.b.b();
        bVar.du = this.du;
        bVar.mRootContainer = this.mRootContainer;
        bVar.mAdTemplate = this.mAdTemplate;
        if (com.kwad.sdk.core.response.helper.a.aL(this.mAdInfo)) {
            bVar.mApkDownloadHelper = new com.kwad.components.core.e.d.d(this.mAdTemplate);
        }
        bVar.dN = this.dN;
        bVar.dQ = new com.kwad.components.ad.draw.presenter.b.a(this.mAdTemplate);
        if (com.kwad.sdk.core.response.helper.b.df(this.mAdTemplate)) {
            bVar.dR = new com.kwad.components.ad.l.b();
        }
        return bVar;
    }

    private Presenter bF() {
        Presenter presenter = new Presenter();
        presenter.a(new com.kwad.components.ad.draw.presenter.a.a());
        presenter.a(new com.kwad.components.ad.draw.presenter.b());
        presenter.a(new com.kwad.components.ad.draw.presenter.d());
        presenter.a(new com.kwad.components.ad.draw.presenter.c());
        presenter.a(new com.kwad.components.ad.draw.presenter.b.b());
        if (com.kwad.sdk.core.response.helper.b.cS(this.mAdTemplate)) {
            presenter.a(new com.kwad.components.ad.draw.presenter.b.c());
        }
        presenter.a(new com.kwad.components.ad.draw.presenter.c.a());
        if (com.kwad.sdk.core.response.helper.b.df(this.mAdTemplate)) {
            presenter.a(new com.kwad.components.ad.draw.presenter.c.b());
        }
        if (com.kwad.sdk.core.response.helper.a.aV(this.mAdInfo)) {
            presenter.a(new com.kwad.components.ad.draw.presenter.a());
        }
        return presenter;
    }

    public final void bM() {
        com.kwad.components.ad.draw.c.a aVar = this.dN;
        if (aVar != null) {
            aVar.fx = false;
        }
    }
}

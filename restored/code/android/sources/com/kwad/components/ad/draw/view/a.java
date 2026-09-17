package com.kwad.components.ad.draw.view;

import android.app.Activity;
import android.content.Context;
import android.os.SystemClock;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewStub;
import android.widget.TextView;
import com.kwad.components.ad.draw.presenter.livecard.KsLiveAuthorView;
import com.kwad.components.core.widget.KsLogoView;
import com.kwad.components.offline.api.core.adlive.IAdLiveOfflineView;
import com.kwad.components.offline.api.core.adlive.IAdLivePlayModule;
import com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListener;
import com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListenerAdapter;
import com.kwad.sdk.R;
import com.kwad.sdk.api.KsDrawAd;
import com.kwad.sdk.components.d;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.view.AdBaseFrameLayout;
import com.kwad.sdk.mvp.Presenter;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bx;
import com.kwad.sdk.widget.KSFrameLayout;
import com.kwad.sdk.wrapper.m;
import java.lang.ref.WeakReference;
import java.util.Iterator;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends KSFrameLayout implements View.OnClickListener {
    private List<Integer> cv;
    private com.kwad.sdk.core.j.b dA;
    private com.kwad.components.ad.draw.b.b dL;
    private IAdLivePlayModule dO;
    private KsDrawAd.AdInteractionListener du;
    private final AdLivePlayStateListener et;
    private final com.kwad.sdk.core.j.c fA;
    private IAdLiveOfflineView fC;
    private com.kwad.components.core.offline.a.c.a fD;
    private boolean fE;
    private KsLiveAuthorView fF;
    private TextView fG;
    private TextView fH;
    private TextView fI;
    private KsLogoView fJ;
    private View fK;
    private ViewGroup fL;
    private String fM;
    private KsLogoView fN;
    private KSFrameLayout fO;
    private com.kwad.components.core.l.a.b fP;
    private int fQ;
    private View fR;
    private long fS;
    private boolean fT;
    private Runnable fU;
    private com.kwad.components.core.widget.a.c fs;
    private boolean fv;
    private AdInfo mAdInfo;
    private AdTemplate mAdTemplate;
    private Context mContext;
    private Presenter mPresenter;
    private AdBaseFrameLayout mRootContainer;
    private bx mTimerHelper;

    public a(Context context, AdTemplate adTemplate) {
        super(context);
        this.fQ = -1;
        this.fA = new com.kwad.sdk.core.j.c() { // from class: com.kwad.components.ad.draw.view.a.2
            @Override // com.kwad.sdk.core.j.c
            public final void bv() {
                try {
                    a.this.fT = true;
                    if (a.this.dO == null) {
                        a aVar = a.this;
                        aVar.dO = aVar.bC();
                    }
                    com.kwad.components.core.l.a.ty().a(a.this.getCurrentVoiceItem());
                    a.this.dO.onResume();
                    a.this.getTimerHelper().startTiming();
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                }
            }

            @Override // com.kwad.sdk.core.j.c
            public final void bw() {
                if (a.this.fT) {
                    if (a.this.dO != null) {
                        a.this.dO.onPause();
                    }
                    com.kwad.components.core.l.a.ty().c(a.this.fP);
                    a.this.fT = false;
                }
            }
        };
        this.fU = new Runnable() { // from class: com.kwad.components.ad.draw.view.a.4
            @Override // java.lang.Runnable
            public final void run() {
                try {
                    com.kwad.sdk.c.a.a.a(a.this.fH, a.this.fM, KsLogoView.a(a.this.fN));
                } catch (Exception e) {
                    com.kwad.sdk.core.d.c.printStackTraceOnly(e);
                    a.this.fH.setText(a.this.fM);
                    a.this.fH.setVisibility(0);
                }
            }
        };
        this.et = new AdLivePlayStateListenerAdapter() { // from class: com.kwad.components.ad.draw.view.a.5
            @Override // com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListenerAdapter, com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListener
            public final void onLivePlayProgress(long j) {
                super.onLivePlayProgress(j);
                a.this.c(j);
            }

            @Override // com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListenerAdapter, com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListener
            public final void onLivePlayEnd() {
                super.onLivePlayEnd();
                com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
                com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
                bVar.eb(24);
                bVar.b(c0502a);
                com.kwad.components.core.t.b.wR().a(a.this.mAdTemplate, null, bVar);
                a.this.fL.setVisibility(8);
                a.this.fR.setVisibility(0);
            }

            @Override // com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListenerAdapter, com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListener
            public final void onLivePlayPause() {
                super.onLivePlayPause();
                if (com.kwad.sdk.core.response.helper.a.cZ(a.this.mAdInfo)) {
                    com.kwad.sdk.core.adlog.c.p(a.this.mAdTemplate, (int) Math.ceil(a.this.getTimerHelper().getTime() / 1000.0f));
                }
            }

            @Override // com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListenerAdapter, com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListener
            public final void onLivePlayStart() {
                super.onLivePlayStart();
                if (!a.this.mAdTemplate.mPvReported && a.this.dL != null && a.this.dL.du != null) {
                    a.this.dL.du.onAdShow();
                    com.kwad.components.ad.draw.a.c.a(a.this.mAdTemplate, 1, com.kwad.sdk.core.response.helper.b.dA(a.this.mAdTemplate) ? 2 : 1);
                    com.kwad.components.ad.draw.a.b.a(a.this.mAdTemplate, SystemClock.elapsedRealtime() - a.this.fS);
                }
                com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
                bVar.b(new com.kwad.sdk.core.adlog.a.C0502a());
                com.kwad.components.core.t.b.wR().a(a.this.mAdTemplate, null, bVar);
                com.kwad.sdk.core.adlog.c.f(a.this.mAdTemplate, null);
                com.kwad.components.core.l.a.ty().a(a.this.getCurrentVoiceItem());
                a.this.dO.setAudioEnabled(a.this.isVideoSoundEnable(), false);
                a.this.fL.setVisibility(0);
                a.this.fR.setVisibility(8);
            }

            @Override // com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListenerAdapter, com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListener
            public final void onLivePlayResume() {
                super.onLivePlayResume();
                com.kwad.components.core.l.a.ty().a(a.this.getCurrentVoiceItem());
                a.this.dO.setAudioEnabled(a.this.isVideoSoundEnable(), false);
            }
        };
        this.mContext = context;
        this.mAdTemplate = adTemplate;
        this.mAdInfo = e.eM(adTemplate);
        this.fD = (com.kwad.components.core.offline.a.c.a) d.f(com.kwad.components.core.offline.a.c.a.class);
        final WeakReference weakReference = new WeakReference(m.getActivityFromContext(this.mContext));
        com.kwad.sdk.core.c.b.Mh();
        com.kwad.sdk.core.c.b.a(new com.kwad.sdk.core.c.d() { // from class: com.kwad.components.ad.draw.view.a.1
            @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
            /* JADX INFO: renamed from: onActivityDestroyed */
            public final void b(Activity activity) {
                Activity activity2 = (Activity) weakReference.get();
                if (activity2 == null || !activity2.equals(activity)) {
                    return;
                }
                a.this.bD();
                com.kwad.sdk.core.c.b.Mh();
                com.kwad.sdk.core.c.b.b((com.kwad.sdk.core.c.c) this);
            }
        });
        initView();
        bz();
        by();
        bx();
    }

    private void bx() {
        this.fL.setOnClickListener(this);
        this.fI.setOnClickListener(this);
        this.fF.setOnClickListener(this);
        this.fH.setOnClickListener(this);
        this.fG.setOnClickListener(this);
        this.mRootContainer.setOnClickListener(this);
    }

    private void by() {
        try {
            ViewGroup viewGroup = this.fL;
            if (viewGroup == null) {
                return;
            }
            this.fF = (KsLiveAuthorView) viewGroup.findViewById(R.id.ksad_live_author_icon);
            this.fG = (TextView) this.fL.findViewById(R.id.kwad_actionbar_title);
            this.fH = (TextView) this.fL.findViewById(R.id.kwad_actionbar_des_text);
            this.fI = (TextView) this.fL.findViewById(R.id.ksad_live_actionbar_btn);
            this.fJ = (KsLogoView) this.fL.findViewById(R.id.ksad_draw_live_kwai_logo);
            if (this.fE) {
                return;
            }
            this.fK = this.fL.findViewById(R.id.ksad_draw_origin_live_relative);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    private void bz() {
        if (this.mRootContainer == null) {
            return;
        }
        if (8 == com.kwad.sdk.core.response.helper.a.bm(this.mAdInfo)) {
            this.fL = (ViewGroup) ((ViewStub) this.mRootContainer.findViewById(R.id.ksad_draw_live_shop_stub)).inflate();
            this.fE = true;
        } else {
            this.fL = (ViewGroup) ((ViewStub) this.mRootContainer.findViewById(R.id.ksad_draw_live_base_stub)).inflate();
            this.fE = false;
        }
        this.fL.setVisibility(4);
    }

    private void initView() {
        m.a(this.mContext, R.layout.ksad_draw_ad_live_layout, this, true);
        AdBaseFrameLayout adBaseFrameLayout = (AdBaseFrameLayout) findViewById(R.id.ksad_root_live_container);
        this.mRootContainer = adBaseFrameLayout;
        this.fO = (KSFrameLayout) adBaseFrameLayout.findViewById(R.id.ksad_draw_video_container);
        this.fR = this.mRootContainer.findViewById(R.id.ksad_draw_live_frame_bg);
    }

    public final void bA() {
        this.fs = new com.kwad.components.ad.draw.b(this);
        this.cv = com.kwad.sdk.core.response.helper.a.bv(this.mAdInfo);
        bB();
    }

    private void bB() {
        this.fG.setText(com.kwad.sdk.core.response.helper.a.cs(this.mAdInfo));
        com.kwad.components.core.widget.e eVar = new com.kwad.components.core.widget.e();
        this.fF.setVisibility(0);
        this.fF.j(this.mAdTemplate);
        this.fF.a(eVar);
        this.fI.setText(com.kwad.sdk.core.response.helper.a.aK(this.mAdInfo));
        if (com.kwad.sdk.core.response.helper.a.bm(this.mAdInfo) == 8) {
            this.fJ.setVisibility(0);
            this.fJ.bh(this.mAdTemplate);
            this.fH.setText(com.kwad.sdk.core.response.helper.a.aA(this.mAdInfo));
        } else {
            this.fM = com.kwad.sdk.core.response.helper.a.aA(this.mAdInfo);
            KsLogoView ksLogoView = new KsLogoView(this.fL.getContext(), false);
            this.fN = ksLogoView;
            ksLogoView.setLogoLoadFinishListener(new KsLogoView.a() { // from class: com.kwad.components.ad.draw.view.a.3
                @Override // com.kwad.components.core.widget.KsLogoView.a
                public final void bG() {
                    a.this.fH.post(a.this.fU);
                }
            });
            this.fN.bh(this.mAdTemplate);
            this.fJ.setVisibility(8);
        }
        com.kwad.components.ad.draw.a.b.g(this.mAdTemplate);
        this.fS = SystemClock.elapsedRealtime();
        this.dL = bE();
        Presenter presenterBF = bF();
        this.mPresenter = presenterBF;
        presenterBF.N(this.mRootContainer);
        this.mPresenter.q(this.dL);
        this.fs.a(this.dA);
        this.fs.a(this.fA);
        this.fs.Am();
    }

    public final void setPageExitListener(com.kwad.sdk.core.j.b bVar) {
        this.dA = bVar;
    }

    public final void setAdInteractionListener(KsDrawAd.AdInteractionListener adInteractionListener) {
        this.du = adInteractionListener;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public IAdLivePlayModule bC() {
        try {
            IAdLivePlayModule iAdLivePlayModule = this.dO;
            if (iAdLivePlayModule != null) {
                return iAdLivePlayModule;
            }
            com.kwad.components.core.offline.a.c.a aVar = this.fD;
            if (aVar != null && aVar.tG() && com.kwad.sdk.core.response.helper.a.cY(e.eM(this.mAdTemplate))) {
                IAdLiveOfflineView iAdLiveOfflineViewA = com.kwad.components.ad.j.c.a(this.fD, this.mContext, com.kwad.sdk.core.response.helper.a.bm(this.mAdInfo) == 8 ? 1 : 0);
                this.fC = iAdLiveOfflineViewA;
                if (iAdLiveOfflineViewA == null) {
                    return null;
                }
                IAdLivePlayModule adLivePlayModule = this.fD.getAdLivePlayModule(iAdLiveOfflineViewA, ServiceProvider.getSDKConfig().appId, String.valueOf(com.kwad.sdk.core.response.helper.a.cw(this.mAdInfo)), com.kwad.sdk.core.response.helper.a.cx(this.mAdInfo), com.kwad.sdk.core.response.helper.a.cy(this.mAdInfo), e.eG(this.mAdTemplate));
                adLivePlayModule.setAudioEnabled(isVideoSoundEnable(), false);
                adLivePlayModule.registerAdLivePlayStateListener(this.et);
                View view = this.fC.getView();
                if (this.fO.getTag() != null) {
                    KSFrameLayout kSFrameLayout = this.fO;
                    kSFrameLayout.removeView((View) kSFrameLayout.getTag());
                    this.fO.setTag(null);
                }
                this.fO.addView(view);
                this.fO.setTag(view);
                return adLivePlayModule;
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
        return null;
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (view.equals(this.fI)) {
            this.dL.a(1, view.getContext(), 29, 1);
            return;
        }
        if (view.equals(this.fF)) {
            this.dL.a(1, view.getContext(), 30, 2);
            return;
        }
        if (view.equals(this.fH)) {
            this.dL.a(1, view.getContext(), 32, 2);
            return;
        }
        if (view.equals(this.fG)) {
            this.dL.a(1, view.getContext(), 31, 2);
            return;
        }
        if (view.equals(this.fL)) {
            this.dL.a(1, view.getContext(), 53, 2);
        } else if (view.equals(this.mRootContainer) || view.equals(this.fO)) {
            this.dL.a(1, view.getContext(), 85, 3);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public com.kwad.components.core.l.a.b getCurrentVoiceItem() {
        if (this.fP == null) {
            this.fP = new com.kwad.components.core.l.a.b(new com.kwad.components.core.l.a.c() { // from class: com.kwad.components.ad.draw.view.a.6
                @Override // com.kwad.components.core.l.a.c
                public final void bH() {
                    if (a.this.dO == null) {
                        a aVar = a.this;
                        aVar.dO = aVar.bC();
                    }
                    if (a.this.dO != null) {
                        a.this.dO.setAudioEnabled(a.this.isVideoSoundEnable(), false);
                    }
                }
            });
        }
        return this.fP;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void c(long j) {
        int iCeil = (int) Math.ceil(j / 1000.0f);
        List<Integer> list = this.cv;
        if (list == null || list.isEmpty()) {
            return;
        }
        Iterator<Integer> it = this.cv.iterator();
        while (it.hasNext()) {
            if (iCeil >= it.next().intValue()) {
                com.kwad.sdk.core.adlog.c.a(this.mAdTemplate, iCeil, (JSONObject) null);
                it.remove();
                return;
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean isVideoSoundEnable() {
        if (this.fQ == 1) {
            return !this.fv;
        }
        return !com.kwad.sdk.core.response.helper.a.ci(e.eM(this.mAdTemplate));
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void bD() {
        com.kwad.components.core.widget.a.c cVar = this.fs;
        if (cVar != null) {
            cVar.release();
        }
        com.kwad.components.ad.draw.b.b bVar = this.dL;
        if (bVar != null) {
            bVar.release();
        }
        if (this.dO != null) {
            this.dO = null;
        }
        if (this.fC != null) {
            this.fC = null;
        }
        Presenter presenter = this.mPresenter;
        if (presenter != null) {
            presenter.destroy();
        }
        com.kwad.components.core.l.a.ty().c(this.fP);
    }

    private com.kwad.components.ad.draw.b.b bE() {
        com.kwad.components.ad.draw.b.b bVar = new com.kwad.components.ad.draw.b.b();
        bVar.du = this.du;
        bVar.mRootContainer = this.mRootContainer;
        bVar.mAdTemplate = this.mAdTemplate;
        if (com.kwad.sdk.core.response.helper.a.aL(this.mAdInfo) && bVar.mApkDownloadHelper == null) {
            bVar.mApkDownloadHelper = new com.kwad.components.core.e.d.d(this.mAdTemplate);
        }
        if (this.dO == null) {
            this.dO = bC();
        }
        bVar.dO = this.dO;
        bVar.dP = this.fC;
        bVar.dQ = new com.kwad.components.ad.draw.presenter.b.a(this.mAdTemplate);
        return bVar;
    }

    public final void setVideoSound(boolean z) {
        IAdLivePlayModule iAdLivePlayModule = this.dO;
        if (iAdLivePlayModule != null) {
            iAdLivePlayModule.setAudioEnabled(z, false);
        }
        this.fv = !z;
        this.fQ = 1;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public bx getTimerHelper() {
        if (this.mTimerHelper == null) {
            bx bxVar = new bx();
            this.mTimerHelper = bxVar;
            bxVar.startTiming();
        }
        return this.mTimerHelper;
    }

    private static Presenter bF() {
        Presenter presenter = new Presenter();
        presenter.a(new com.kwad.components.ad.draw.presenter.b());
        presenter.a(new com.kwad.components.ad.draw.presenter.livecard.b());
        presenter.a(new com.kwad.components.ad.draw.presenter.livecard.a());
        return presenter;
    }
}

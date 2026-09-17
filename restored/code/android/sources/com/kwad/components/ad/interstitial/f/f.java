package com.kwad.components.ad.interstitial.f;

import android.content.Context;
import android.text.TextUtils;
import android.view.View;
import android.widget.ImageView;
import com.kwad.sdk.R;
import com.kwad.sdk.api.KsAdVideoPlayConfig;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.helper.SlideConvertHelper;
import com.kwad.sdk.core.response.helper.h;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.al;
import com.kwad.sdk.utils.as;
import com.kwad.sdk.widget.KSFrameLayout;
import java.io.File;
import java.util.Iterator;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class f extends b implements com.kwad.sdk.widget.d {
    private com.kwad.sdk.core.video.videoview.a cB;
    private com.kwad.sdk.core.video.videoview.a.InterfaceC0519a cK;
    private KsAdVideoPlayConfig ce;
    private List<Integer> cv;
    private KSFrameLayout fO;
    private ImageView ia;
    protected AdInfo mAdInfo;
    private AdTemplate mAdTemplate;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;
    protected Context mContext;
    private c mF;
    private KSFrameLayout nE;
    private com.kwad.components.core.video.f nF;
    private boolean mIsAudioEnable = false;

    /* JADX INFO: renamed from: if, reason: not valid java name */
    private final com.kwad.components.core.video.a.InterfaceC0460a f7if = new com.kwad.components.core.video.a.InterfaceC0460a() { // from class: com.kwad.components.ad.interstitial.f.f.4
        /* JADX WARN: Code duplicated, block: B:15:0x0024  */
        @Override // com.kwad.components.core.video.a.InterfaceC0460a
        public final void a(int i, al.a aVar) {
            final int i2;
            int i3;
            boolean z = false;
            if (i == 1) {
                i2 = 13;
            } else {
                if (i != 2) {
                    if (i != 3) {
                        i2 = 108;
                    } else {
                        i2 = 83;
                        z = true;
                        i3 = 1;
                    }
                    f.this.getContext();
                    int i4 = as.VV() ? 2 : 1;
                    com.kwad.components.ad.interstitial.report.a.eT().a(f.this.mAdTemplate, 1L, i2);
                    com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(f.this.getContext()).aF(f.this.mAdTemplate).b(f.this.mApkDownloadHelper).aD(i3).as(z).au(true).aC(i2).d(aVar).aE(i4).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.interstitial.f.f.4.1
                        @Override // com.kwad.components.core.e.d.a.b
                        public final void onAdClicked() {
                            f.this.l(i2);
                        }
                    }));
                }
                i2 = 82;
            }
            i3 = 2;
            f.this.getContext();
            if (as.VV()) {
            }
            com.kwad.components.ad.interstitial.report.a.eT().a(f.this.mAdTemplate, 1L, i2);
            com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(f.this.getContext()).aF(f.this.mAdTemplate).b(f.this.mApkDownloadHelper).aD(i3).as(z).au(true).aC(i2).d(aVar).aE(i4).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.interstitial.f.f.4.1
                @Override // com.kwad.components.core.e.d.a.b
                public final void onAdClicked() {
                    f.this.l(i2);
                }
            }));
        }
    };

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.nE = (KSFrameLayout) getRootView().findViewById(R.id.ksad_container);
        this.fO = (KSFrameLayout) getRootView().findViewById(R.id.ksad_video_container);
        this.ia = (ImageView) getRootView().findViewById(R.id.ksad_video_first_frame_container);
        this.fO.setVisibility(4);
        this.mContext = getContext();
    }

    @Override // com.kwad.components.ad.interstitial.f.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        c cVar = (c) SK();
        this.mF = cVar;
        this.ce = cVar.ce;
        AdTemplate adTemplate = this.mF.mAdTemplate;
        this.mAdTemplate = adTemplate;
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        this.mAdInfo = adInfoEM;
        this.cv = com.kwad.sdk.core.response.helper.a.bv(adInfoEM);
        com.kwad.sdk.core.video.videoview.a aVar = this.mF.cB;
        this.cB = aVar;
        aVar.setTag(this.cv);
        com.kwad.components.core.video.f fVar = new com.kwad.components.core.video.f(this.mContext, this.mAdTemplate, this.cB);
        this.nF = fVar;
        fVar.setDataFlowAutoStart(this.ce.isDataFlowAutoStart());
        this.nF.setAdClickListener(this.f7if);
        this.nF.xx();
        this.mApkDownloadHelper = this.mF.mApkDownloadHelper;
        eC();
        float dimension = getContext().getResources().getDimension(R.dimen.ksad_interstitial_card_radius);
        this.fO.setRadius(dimension, dimension, 0.0f, 0.0f);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.mF.mN = null;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onDestroy() {
        super.onDestroy();
    }

    private void eC() {
        String strFv;
        this.mIsAudioEnable = this.ce.isVideoSoundEnable();
        String url = com.kwad.sdk.core.response.helper.a.bA(this.mAdInfo).getUrl();
        if (!TextUtils.isEmpty(url)) {
            this.ia.setImageDrawable(null);
            KSImageLoader.loadImage(this.ia, url, this.mAdTemplate);
            this.ia.setVisibility(0);
        } else {
            this.ia.setVisibility(8);
        }
        int iGm = com.kwad.sdk.core.config.e.Gm();
        String strM = com.kwad.sdk.core.response.helper.a.M(this.mAdInfo);
        if (TextUtils.isEmpty(strM)) {
            return;
        }
        if (iGm < 0) {
            File fileCM = com.kwad.sdk.core.diskcache.b.a.LI().cM(strM);
            if (fileCM == null || !fileCM.exists()) {
                strM = null;
            } else {
                strFv = fileCM.getAbsolutePath();
                strM = strFv;
            }
        } else if (iGm != 0) {
            com.kwad.sdk.core.videocache.f fVarCl = com.kwad.sdk.core.videocache.c.a.cl(this.mContext);
            if (com.kwad.sdk.core.config.e.JB()) {
                int iGm2 = com.kwad.sdk.core.config.e.Gm();
                if (!fVarCl.fx(strM)) {
                    if (fVarCl.a(strM, iGm2 * 1024, new com.kwad.sdk.core.network.a.a.C0515a(), null)) {
                        strFv = fVarCl.fv(strM);
                    }
                } else {
                    strFv = fVarCl.fv(strM);
                }
                strM = strFv;
            } else {
                strM = fVarCl.fv(strM);
            }
        }
        if (TextUtils.isEmpty(strM)) {
            return;
        }
        this.cB.a(new com.kwad.sdk.contentalliance.a.a.b.a(this.mAdTemplate).dO(strM).dP(h.b(com.kwad.sdk.core.response.helper.e.eN(this.mAdTemplate))).a(this.mAdTemplate.mVideoPlayerStatus).b(new com.kwad.sdk.contentalliance.a.a.a(this.mAdTemplate, System.currentTimeMillis())).IS(), null);
        com.kwad.sdk.core.video.videoview.a.InterfaceC0519a interfaceC0519a = new com.kwad.sdk.core.video.videoview.a.InterfaceC0519a() { // from class: com.kwad.components.ad.interstitial.f.f.1
            @Override // com.kwad.sdk.core.video.videoview.a.InterfaceC0519a
            public final com.kwad.sdk.core.video.a.c a(com.kwad.sdk.contentalliance.a.a.b bVar) {
                if (!((Boolean) com.kwad.sdk.core.config.e.b(com.kwad.sdk.core.config.c.aQq)).booleanValue() || !((Boolean) com.kwad.sdk.core.config.e.b(com.kwad.sdk.core.config.c.aQr)).booleanValue()) {
                    return null;
                }
                com.kwad.components.core.video.g gVar = new com.kwad.components.core.video.g(bVar, f.this.mAdTemplate);
                if (com.kwad.components.core.video.g.isWaynePlayerReady()) {
                    return gVar;
                }
                return null;
            }
        };
        this.cK = interfaceC0519a;
        this.cB.setExternalPlayerListener(interfaceC0519a);
        this.cB.setVideoSoundEnable(this.mIsAudioEnable);
        final long jCurrentTimeMillis = System.currentTimeMillis();
        com.kwad.components.ad.interstitial.report.d.eZ().E(this.mAdTemplate);
        this.nF.setVideoPlayCallback(new com.kwad.components.core.video.f.a() { // from class: com.kwad.components.ad.interstitial.f.f.2
            private boolean eQ = false;

            @Override // com.kwad.components.core.video.a.c
            public final void d(long j) {
                f.this.c(j);
                Iterator<com.kwad.components.core.video.a.c> it = f.this.mF.mP.iterator();
                while (it.hasNext()) {
                    it.next().d(j);
                }
            }

            @Override // com.kwad.components.core.video.a.c
            public final void onVideoPlayStart() {
                com.kwad.sdk.core.adlog.c.cp(f.this.mAdTemplate);
                com.kwad.components.ad.interstitial.report.d.eZ().b(f.this.mAdTemplate, System.currentTimeMillis() - jCurrentTimeMillis);
                com.kwad.components.ad.interstitial.report.b.eV().x(f.this.mAdTemplate);
                if (!f.this.mF.mJ && f.this.mF.lk != null) {
                    f.this.mF.lk.onVideoPlayStart();
                }
                Iterator<com.kwad.components.core.video.a.c> it = f.this.mF.mP.iterator();
                while (it.hasNext()) {
                    it.next().onVideoPlayStart();
                }
                f.this.mF.mR = false;
            }

            @Override // com.kwad.components.core.video.f.a
            public final void onVideoPlayError(int i, int i2) {
                com.kwad.components.ad.interstitial.report.d.eZ().b(f.this.mAdTemplate, i, String.valueOf(i2));
                if (f.this.mF.lk != null) {
                    f.this.mF.lk.onVideoPlayError(i, i2);
                }
            }

            @Override // com.kwad.components.core.video.a.c
            public final void as() {
                if (!this.eQ) {
                    this.eQ = true;
                    com.kwad.components.core.p.a.vX().a(f.this.mAdTemplate, System.currentTimeMillis(), 0);
                }
                Iterator<com.kwad.components.core.video.a.c> it = f.this.mF.mP.iterator();
                while (it.hasNext()) {
                    it.next().as();
                }
            }

            @Override // com.kwad.components.core.video.a.c
            public final void at() {
                com.kwad.sdk.core.adlog.c.cq(f.this.mAdTemplate);
                if (!f.this.mF.mJ && f.this.mF.lk != null) {
                    f.this.mF.lk.onVideoPlayEnd();
                }
                Iterator<com.kwad.components.core.video.a.c> it = f.this.mF.mP.iterator();
                while (it.hasNext()) {
                    it.next().at();
                }
                f.this.mF.mR = true;
            }
        });
        this.cB.setController(this.nF);
        this.fO.setClickable(true);
        new com.kwad.sdk.widget.h(this.fO.getContext(), this.fO, this);
        this.fO.addView(this.cB);
        this.mF.mN = new c.e() { // from class: com.kwad.components.ad.interstitial.f.f.3
            @Override // com.kwad.components.ad.interstitial.f.c.e
            public final void eh() {
                if (f.this.cB != null) {
                    f.this.cB.restart();
                }
            }
        };
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
    public void l(long j) {
        this.mF.mH = true;
        this.mF.c(1L, j);
    }

    private c.C0377c c(View view, boolean z) {
        return new c.C0377c(view.getContext()).l(z).a(this.nE.getTouchCoords()).L(3).M(85);
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view) {
        this.mF.a(c(view, true));
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view, float f, float f2, float f3, float f4) {
        if (SlideConvertHelper.a(this.mF.mAdTemplate, f, f2, f3, f4)) {
            this.mF.a(c(view, false));
        }
    }
}

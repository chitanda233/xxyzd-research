package com.kwad.components.ad.nativead;

import android.app.Activity;
import android.content.Context;
import android.content.DialogInterface;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Vibrator;
import android.text.TextUtils;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.widget.FrameLayout;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.ad.nativead.monitor.NativeAdMonitor;
import com.kwad.components.core.internal.api.KSAdVideoPlayConfigImpl;
import com.kwad.sdk.R;
import com.kwad.sdk.api.KsAdVideoPlayConfig;
import com.kwad.sdk.api.KsAppDownloadListener;
import com.kwad.sdk.api.KsImage;
import com.kwad.sdk.api.KsNativeAd;
import com.kwad.sdk.api.core.AbstractKsNativeAd;
import com.kwad.sdk.api.model.AdExposureFailedReason;
import com.kwad.sdk.api.model.KsLiveInfo;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdMatrixInfo;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.o;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.al;
import com.kwad.sdk.utils.bx;
import com.kwad.sdk.utils.by;
import com.kwad.sdk.utils.cb;
import com.kwad.sdk.wrapper.m;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class d extends AbstractKsNativeAd implements DialogInterface.OnDismissListener, DialogInterface.OnShowListener, com.kwad.components.core.internal.api.a {
    private Vibrator ho;
    private AdInfo mAdInfo;
    private final AdResultData mAdResultData;
    private AdTemplate mAdTemplate;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;
    private volatile bx mTimerHelper;
    private b.c pd;
    private b.e pe;
    private boolean pj;
    private KsNativeAd.AdInteractionListener pk;
    private f pl;
    private e pm;
    private KsNativeAd.VideoPlayListener pn;
    private com.kwad.components.ad.nativead.e.a pr;
    private com.kwad.components.ad.nativead.c.a ps;
    private boolean pt;
    private boolean po = false;
    private com.kwad.components.core.internal.api.c bz = new com.kwad.components.core.internal.api.c();
    private int pp = 0;
    private int pq = 0;
    private KsNativeAd.VideoPlayListener pu = new KsNativeAd.VideoPlayListener() { // from class: com.kwad.components.ad.nativead.d.10
        @Override // com.kwad.sdk.api.KsNativeAd.VideoPlayListener
        public final void onVideoPlayStart() {
            if (d.this.pn != null) {
                d.this.pn.onVideoPlayStart();
            }
        }

        @Override // com.kwad.sdk.api.KsNativeAd.VideoPlayListener
        public final void onVideoPlayComplete() {
            if (d.this.pn != null) {
                d.this.pn.onVideoPlayComplete();
            }
        }

        @Override // com.kwad.sdk.api.KsNativeAd.VideoPlayListener
        public final void onVideoPlayError(int i, int i2) {
            if (d.this.pn != null) {
                d.this.pn.onVideoPlayError(i, i2);
            }
        }

        @Override // com.kwad.sdk.api.KsNativeAd.VideoPlayListener
        public final void onVideoPlayPause() {
            if (d.this.pn != null) {
                try {
                    d.this.pn.onVideoPlayPause();
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                }
            }
        }

        @Override // com.kwad.sdk.api.KsNativeAd.VideoPlayListener
        public final void onVideoPlayReady() {
            if (d.this.pn != null) {
                try {
                    d.this.pn.onVideoPlayReady();
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                }
            }
        }

        @Override // com.kwad.sdk.api.KsNativeAd.VideoPlayListener
        public final void onVideoPlayResume() {
            if (d.this.pn != null) {
                try {
                    d.this.pn.onVideoPlayResume();
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                }
            }
        }
    };
    private a pv = new a() { // from class: com.kwad.components.ad.nativead.d.2
        @Override // com.kwad.components.ad.nativead.d.a
        public final void l(View view) {
            if (d.this.pk != null) {
                d.this.pk.onAdClicked(new FrameLayout(m.eL(view.getContext())), d.this);
            }
        }

        @Override // com.kwad.components.ad.nativead.d.a
        public final void fw() {
            if (d.this.pk != null) {
                d.this.pk.onAdShow(d.this);
            }
        }

        @Override // com.kwad.components.ad.nativead.d.a
        public final boolean handleDownloadDialog(DialogInterface.OnClickListener onClickListener) {
            if (d.this.pk == null) {
                return false;
            }
            try {
                return d.this.pk.handleDownloadDialog(onClickListener);
            } catch (Throwable th) {
                com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                return false;
            }
        }

        @Override // com.kwad.components.ad.nativead.d.a
        public final void onDownloadTipsDialogShow() {
            if (d.this.pk != null) {
                try {
                    d.this.pk.onDownloadTipsDialogShow();
                } catch (Throwable unused) {
                }
            }
        }

        @Override // com.kwad.components.ad.nativead.d.a
        public final void onDownloadTipsDialogDismiss() {
            if (d.this.pk != null) {
                try {
                    d.this.pk.onDownloadTipsDialogDismiss();
                } catch (Throwable unused) {
                }
            }
        }
    };

    public interface a {
        void fw();

        boolean handleDownloadDialog(DialogInterface.OnClickListener onClickListener);

        void l(View view);

        void onDownloadTipsDialogDismiss();

        void onDownloadTipsDialogShow();
    }

    @Override // com.kwad.components.core.internal.api.a
    public final boolean supportPushAd() {
        return true;
    }

    static /* synthetic */ boolean b(d dVar, al.a aVar) {
        return c(aVar);
    }

    public d(AdResultData adResultData) {
        this.mAdResultData = adResultData;
        AdTemplate adTemplateR = com.kwad.sdk.core.response.helper.c.r(adResultData);
        this.mAdTemplate = adTemplateR;
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplateR);
        this.mAdInfo = adInfoEM;
        if (com.kwad.sdk.core.response.helper.a.aL(adInfoEM)) {
            com.kwad.components.core.e.d.d dVar = new com.kwad.components.core.e.d.d(this.mAdTemplate);
            this.mApkDownloadHelper = dVar;
            dVar.setOnShowListener(this);
            this.mApkDownloadHelper.setOnDismissListener(this);
            this.mApkDownloadHelper.a(new com.kwad.components.core.e.d.d.a() { // from class: com.kwad.components.ad.nativead.d.1
                @Override // com.kwad.components.core.e.d.d.a
                public final boolean handleDownloadDialog(DialogInterface.OnClickListener onClickListener) {
                    return d.this.pv.handleDownloadDialog(onClickListener);
                }
            });
        }
        KSImageLoader.preloadImage(com.kwad.sdk.core.response.helper.a.Q(this.mAdInfo), this.mAdTemplate);
    }

    public final synchronized bx getTimerHelper() {
        if (this.mTimerHelper == null) {
            this.mTimerHelper = new bx();
        }
        return this.mTimerHelper;
    }

    @Override // com.kwad.sdk.api.core.AbstractKsNativeAd
    public final Bitmap getSdkLogo() {
        return BitmapFactory.decodeResource(ServiceProvider.getContext().getResources(), R.drawable.ksad_sdk_logo);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final String getAdDescription() {
        return com.kwad.sdk.core.response.helper.a.aA(this.mAdInfo);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final String getAdSource() {
        return com.kwad.sdk.core.response.helper.a.aJ(this.mAdInfo);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final String getAdSourceLogoUrl(int i) {
        AdInfo adInfo = this.mAdInfo;
        if (adInfo == null) {
            return null;
        }
        if (i == 1) {
            return adInfo.adBaseInfo.adGrayMarkIcon;
        }
        return adInfo.adBaseInfo.adMarkIcon;
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.sdk.api.KsNativeAd
    /* JADX INFO: renamed from: ft, reason: merged with bridge method [inline-methods] */
    public com.kwad.components.core.internal.api.d getVideoCoverImage() {
        AdInfo.AdMaterialInfo.MaterialFeature materialFeatureBb = com.kwad.sdk.core.response.helper.a.bb(this.mAdInfo);
        if (TextUtils.isEmpty(materialFeatureBb.coverUrl)) {
            return null;
        }
        return new com.kwad.components.core.internal.api.d(materialFeatureBb.width, materialFeatureBb.height, materialFeatureBb.coverUrl);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final int getVideoWidth() {
        if (com.kwad.sdk.core.response.helper.a.cY(this.mAdInfo)) {
            return 720;
        }
        return com.kwad.sdk.core.response.helper.a.bb(this.mAdInfo).videoWidth;
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final int getVideoHeight() {
        if (com.kwad.sdk.core.response.helper.a.cY(this.mAdInfo)) {
            return 1280;
        }
        return com.kwad.sdk.core.response.helper.a.bb(this.mAdInfo).videoHeight;
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final int getVideoDuration() {
        return com.kwad.sdk.core.response.helper.a.N(this.mAdInfo);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final List<KsImage> getImageList() {
        ArrayList arrayList = new ArrayList();
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate);
        int iBk = com.kwad.sdk.core.response.helper.a.bk(this.mAdInfo);
        if (iBk == 2 || iBk == 3) {
            for (AdInfo.AdMaterialInfo.MaterialFeature materialFeature : adInfoEM.adMaterialInfo.materialFeatureList) {
                if (materialFeature.featureType == 2 && !TextUtils.isEmpty(materialFeature.materialUrl)) {
                    arrayList.add(new com.kwad.components.core.internal.api.d(materialFeature.width, materialFeature.height, materialFeature.materialUrl));
                }
            }
        }
        return arrayList;
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final String getAppIconUrl() {
        return com.kwad.sdk.core.response.helper.a.cv(this.mAdInfo);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final String getAppName() {
        return com.kwad.sdk.core.response.helper.a.aB(this.mAdInfo);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final String getAppDownloadCountDes() {
        return com.kwad.sdk.core.response.helper.a.aF(this.mAdInfo);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final float getAppScore() {
        return com.kwad.sdk.core.response.helper.a.aG(this.mAdInfo);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final String getCorporationName() {
        return com.kwad.sdk.core.response.helper.a.bI(this.mAdInfo);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final String getPermissionInfo() {
        return com.kwad.sdk.core.response.helper.a.bJ(this.mAdInfo);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final String getPermissionInfoUrl() {
        return com.kwad.sdk.core.response.helper.a.bK(this.mAdInfo);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final String getIntroductionInfo() {
        return com.kwad.sdk.core.response.helper.a.bL(this.mAdInfo);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final String getIntroductionInfoUrl() {
        return com.kwad.sdk.core.response.helper.a.bM(this.mAdInfo);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final String getAppPrivacyUrl() {
        return com.kwad.sdk.core.response.helper.a.bN(this.mAdInfo);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final String getAppVersion() {
        return com.kwad.sdk.core.response.helper.a.bO(this.mAdInfo);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final String getAppPackageName() {
        return com.kwad.sdk.core.response.helper.a.aE(this.mAdInfo);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final long getAppPackageSize() {
        return com.kwad.sdk.core.response.helper.a.bP(this.mAdInfo);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final String getActionDescription() {
        return com.kwad.sdk.core.response.helper.a.aK(this.mAdInfo);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final String getProductName() {
        return com.kwad.sdk.core.response.helper.a.aD(this.mAdInfo);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final String getVideoUrl() {
        return com.kwad.sdk.core.response.helper.a.M(this.mAdInfo);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final int getMaterialType() {
        return com.kwad.sdk.core.response.helper.a.bk(this.mAdInfo);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final int getInteractionType() {
        return com.kwad.sdk.core.response.helper.a.aW(this.mAdInfo);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final int getECPM() {
        return com.kwad.sdk.core.response.helper.a.aX(this.mAdInfo);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final void setBidEcpm(int i) {
        setBidEcpm(i, -1L);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final void setBidEcpm(long j, long j2) {
        this.mAdTemplate.mBidEcpm = j;
        com.kwad.sdk.core.adlog.c.m(this.mAdTemplate, j2);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final KsLiveInfo getLiveInfo() {
        if (com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aPV)) {
            return com.kwad.sdk.core.response.helper.e.fd(this.mAdTemplate);
        }
        return null;
    }

    @Override // com.kwad.sdk.api.BaseKSAd
    public final Map<String, Object> getMediaExtraInfo() {
        HashMap map = new HashMap();
        if (com.kwad.sdk.core.config.e.Ka()) {
            map.put("llsid", Long.valueOf(this.mAdTemplate.llsid));
        }
        return map;
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final void reportAdExposureFailed(int i, AdExposureFailedReason adExposureFailedReason) {
        com.kwad.sdk.core.adlog.c.a(this.mAdTemplate, i, adExposureFailedReason);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final void setDownloadListener(KsAppDownloadListener ksAppDownloadListener) {
        com.kwad.components.core.e.d.d dVar = this.mApkDownloadHelper;
        if (dVar == null || ksAppDownloadListener == null) {
            return;
        }
        dVar.b(ksAppDownloadListener);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final void reportAdVideoPlayStart() {
        com.kwad.sdk.core.adlog.c.cp(getAdTemplate());
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final void reportAdVideoPlayEnd() {
        com.kwad.sdk.core.adlog.c.cq(getAdTemplate());
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final void registerViewForInteraction(ViewGroup viewGroup, List<View> list, KsNativeAd.AdInteractionListener adInteractionListener) {
        registerViewForInteraction((Activity) null, viewGroup, list, adInteractionListener);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final void registerViewForInteraction(Activity activity, ViewGroup viewGroup, List<View> list, KsNativeAd.AdInteractionListener adInteractionListener) {
        NativeAdMonitor.a(viewGroup, 1);
        this.pk = adInteractionListener;
        b(viewGroup);
        a(activity, viewGroup, list);
        c(viewGroup);
    }

    private void c(ViewGroup viewGroup) {
        AdTemplate adTemplate;
        try {
            Context contextWrapContextIfNeed = m.wrapContextIfNeed(viewGroup.getContext());
            if (!(viewGroup instanceof FrameLayout) || (adTemplate = this.mAdTemplate) == null || !com.kwad.sdk.core.response.helper.b.dz(adTemplate) || this.pt) {
                return;
            }
            com.kwad.components.ad.nativead.c.a aVar = new com.kwad.components.ad.nativead.c.a(contextWrapContextIfNeed);
            this.ps = aVar;
            aVar.setAdInteractionListener(this.pv);
            this.ps.a(this.mAdResultData, this.mApkDownloadHelper);
            viewGroup.addView(this.ps);
            this.pt = true;
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final void registerViewForInteraction(Activity activity, ViewGroup viewGroup, Map<View, Integer> map, KsNativeAd.AdInteractionListener adInteractionListener) {
        NativeAdMonitor.a(viewGroup, 1);
        this.pk = adInteractionListener;
        b(viewGroup);
        a(activity, viewGroup, map);
        c(viewGroup);
    }

    private void a(Activity activity, ViewGroup viewGroup, List<View> list) {
        Iterator<View> it = list.iterator();
        while (it.hasNext()) {
            a(activity, viewGroup, 0, it.next(), false);
        }
    }

    private void a(Activity activity, ViewGroup viewGroup, Map<View, Integer> map) {
        for (View view : map.keySet()) {
            if (map.get(view) != null) {
                a(activity, viewGroup, map.get(view).intValue(), view, true);
            }
        }
    }

    private void a(final Activity activity, final ViewGroup viewGroup, int i, final View view, final boolean z) {
        final al.a aVar = new al.a();
        if (view == null) {
            return;
        }
        final int[] iArrS = S(i);
        if (view instanceof f) {
            ((f) view).g(iArrS[1], iArrS[2]);
        } else {
            view.setOnTouchListener(new View.OnTouchListener() { // from class: com.kwad.components.ad.nativead.d.3
                private int[] px = new int[2];

                @Override // android.view.View.OnTouchListener
                public final boolean onTouch(View view2, MotionEvent motionEvent) {
                    int action = motionEvent.getAction();
                    if (action == 0) {
                        aVar.H(viewGroup.getWidth(), viewGroup.getHeight());
                        viewGroup.getLocationOnScreen(this.px);
                        aVar.j(Math.abs(motionEvent.getRawX() - this.px[0]), Math.abs(motionEvent.getRawY() - this.px[1]));
                    } else if (action == 1) {
                        aVar.k(Math.abs(motionEvent.getRawX() - this.px[0]), Math.abs(motionEvent.getRawY() - this.px[1]));
                        if (com.kwad.sdk.utils.b.g(aVar)) {
                            if (iArrS[2] != 1 && d.this.b(aVar)) {
                                view.setPressed(false);
                                d.this.a(activity, view2, aVar, iArrS[0], z, MediaPlayer.MEDIA_PLAYER_OPTION_GET_DROP_COUNT);
                            }
                            return true;
                        }
                        if (iArrS[1] != 1 && com.kwad.sdk.core.config.e.Jy()) {
                            if (d.b(d.this, aVar)) {
                                d.this.a(activity, view2, aVar, iArrS[0], z, 0);
                            }
                            return true;
                        }
                    }
                    return false;
                }
            });
            view.setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.ad.nativead.d.4
                @Override // android.view.View.OnClickListener
                public final void onClick(View view2) {
                    int[] iArr = iArrS;
                    if (iArr[1] != 0) {
                        return;
                    }
                    d.this.a(activity, view2, aVar, iArr[0], z, 0);
                }
            });
        }
    }

    private static int[] S(int i) {
        int i2;
        int i3;
        if (i == 3 || i == 4) {
            i2 = 1;
            i3 = 0;
        } else if (i == 5 || i == 6) {
            i3 = 1;
            i2 = 0;
        } else {
            i3 = 0;
            i2 = 0;
        }
        return new int[]{i % 2 == 0 ? 2 : 1, i3, i2};
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean b(al.a aVar) {
        return com.kwad.sdk.utils.b.a(aVar, com.kwad.sdk.core.response.helper.a.X(this.mAdInfo));
    }

    private static boolean c(al.a aVar) {
        return (Math.abs(aVar.VN() - aVar.VP()) < 20) && (Math.abs(aVar.VO() - aVar.VQ()) < 20);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(Activity activity, final View view, final al.a aVar, int i, boolean z, final int i2) {
        long playDuration;
        Context context = activity;
        if (activity == null) {
            context = view.getContext();
        }
        Context contextWrapContextIfNeed = m.wrapContextIfNeed(context);
        e eVar = this.pm;
        if (eVar != null && eVar.ig != null) {
            playDuration = this.pm.ig.getPlayDuration();
        } else {
            f fVar = this.pl;
            playDuration = (fVar == null || fVar.pP == null) ? 0L : this.pl.pP.getPlayDuration();
        }
        com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(contextWrapContextIfNeed).aF(this.mAdTemplate).b(this.mApkDownloadHelper).aG(i).as(true).A(playDuration).az(z).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.nativead.d.5
            @Override // com.kwad.components.core.e.d.a.b
            public final void onAdClicked() {
                com.kwad.sdk.core.adlog.c.a(d.this.mAdTemplate, new com.kwad.sdk.core.adlog.c.b().f(aVar).dS(i2), (JSONObject) null);
                d.this.pv.l(view);
            }
        }));
    }

    private void b(final ViewGroup viewGroup) {
        if (!this.pj) {
            this.pj = true;
            com.kwad.sdk.commercial.convert.c.cc(this.mAdTemplate);
        }
        if (!com.kwad.sdk.core.config.e.Kr() && com.kwad.sdk.core.config.e.Kq() >= 0.0f) {
            e(viewGroup);
            com.kwad.components.core.widget.a aVar = new com.kwad.components.core.widget.a(viewGroup.getContext(), viewGroup);
            NativeAdMonitor.a(viewGroup, 2);
            aVar.setViewCallback(new com.kwad.components.core.widget.a.InterfaceC0474a() { // from class: com.kwad.components.ad.nativead.d.6
                @Override // com.kwad.components.core.widget.a.InterfaceC0474a
                public final void ae() {
                    com.kwad.components.ad.i.b.gb().a(d.this);
                    if (d.this.ps != null) {
                        d.this.ps.setVisibility(0);
                    }
                }

                @Override // com.kwad.components.core.widget.a.InterfaceC0474a
                public final void af() {
                    try {
                        long jXp = d.this.getTimerHelper().Xp();
                        if (d.this.mAdTemplate.mPvReported && d.this.po) {
                            com.kwad.sdk.core.adlog.c.a(d.this.mAdTemplate, jXp, (JSONObject) null);
                            d.this.po = false;
                        }
                        if (com.kwad.sdk.core.response.helper.a.cZ(d.this.mAdInfo)) {
                            com.kwad.sdk.core.adlog.c.p(d.this.mAdTemplate, ((int) jXp) / 1000);
                        }
                        d.this.bz.i(d.this);
                        b.fr().a(d.this.pe);
                        b.fr().a(d.this.pd);
                        com.kwad.components.ad.i.b.gb().b(d.this);
                        if (d.this.ps != null) {
                            d.this.ps.setVisibility(8);
                        }
                    } catch (Throwable th) {
                        ServiceProvider.reportSdkCaughtException(th);
                    }
                }

                @Override // com.kwad.components.core.widget.a.InterfaceC0474a
                public final void onWindowFocusChanged(boolean z) {
                    ViewGroup viewGroup2;
                    if (!z || (viewGroup2 = viewGroup) == null) {
                        return;
                    }
                    viewGroup2.getWidth();
                }

                @Override // com.kwad.components.core.widget.a.InterfaceC0474a
                public final void b(View view) {
                    if (!d.this.mAdTemplate.mPvReported) {
                        d.this.pv.fw();
                        d.this.fu();
                        com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
                        bVar.z(viewGroup.getHeight(), viewGroup.getWidth());
                        if (com.kwad.sdk.core.response.helper.a.cY(d.this.mAdInfo)) {
                            com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
                            c0502a.showLiveStyle = d.this.pq;
                            c0502a.showLiveStatus = d.this.pp;
                            bVar.b(c0502a);
                        }
                        com.kwad.components.core.t.b.wR().a(d.this.mAdTemplate, null, bVar);
                        if (d.this.enableRotate()) {
                            com.kwad.sdk.core.adlog.c.b(d.this.mAdTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_HW_CONTROL_BY_OPPO, (JSONObject) null);
                        }
                        NativeAdMonitor.a(viewGroup, 4);
                    }
                    if (!d.this.po) {
                        d.this.j(view);
                        d.this.k(view);
                        d.this.getTimerHelper().startTiming();
                        d.this.bz.h(d.this);
                    }
                    b.fr().N(viewGroup.getContext());
                    d.this.po = true;
                }

                @Override // com.kwad.components.core.widget.a.InterfaceC0474a
                public final void aA() {
                    try {
                        if (d.this.mAdTemplate.mPvReported && d.this.po) {
                            com.kwad.sdk.core.adlog.c.a(d.this.mAdTemplate, d.this.getTimerHelper().Xp(), (JSONObject) null);
                            d.this.po = false;
                            b.fr().a(d.this.pe);
                            b.fr().a(d.this.pd);
                            b.fr().D(viewGroup.getContext());
                        }
                    } catch (Throwable th) {
                        ServiceProvider.reportSdkCaughtException(th);
                    }
                }
            });
            viewGroup.addView(aVar);
            aVar.zY();
            return;
        }
        com.kwad.components.core.widget.c cVarD = d(viewGroup);
        if (cVarD == null) {
            cVarD = new com.kwad.components.core.widget.c(viewGroup.getContext(), viewGroup);
            viewGroup.addView(cVarD);
        }
        cVarD.setViewCallback(new com.kwad.components.core.widget.c.a() { // from class: com.kwad.components.ad.nativead.d.7
            @Override // com.kwad.components.core.widget.c.a
            public final void fx() {
                if (!d.this.mAdTemplate.mPvReported) {
                    d.this.pv.fw();
                }
                d.this.fu();
                com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
                bVar.z(viewGroup.getHeight(), viewGroup.getWidth());
                if (com.kwad.sdk.core.response.helper.a.cY(d.this.mAdInfo)) {
                    com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
                    c0502a.showLiveStyle = d.this.pq;
                    c0502a.showLiveStatus = d.this.pp;
                    bVar.b(c0502a);
                }
                com.kwad.components.core.t.b.wR().a(d.this.mAdTemplate, null, bVar);
                com.kwad.sdk.commercial.convert.c.cd(d.this.mAdTemplate);
            }
        });
        cVarD.setNeedCheckingShow(true);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void fu() {
        try {
            this.pp = this.mAdTemplate.mAdScene.nativeAdExtraData.showLiveStatus;
            this.pq = this.mAdTemplate.mAdScene.nativeAdExtraData.showLiveStyle;
        } catch (Throwable unused) {
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void j(final View view) {
        if (com.kwad.sdk.core.response.helper.a.am(this.mAdInfo) || com.kwad.sdk.core.response.helper.b.du(this.mAdTemplate)) {
            float fDv = com.kwad.sdk.core.response.helper.b.dv(this.mAdTemplate);
            if (fDv <= 0.0f) {
                fDv = com.kwad.sdk.core.response.helper.a.an(this.mAdInfo);
            }
            float f = fDv;
            this.pe = new b.e() { // from class: com.kwad.components.ad.nativead.d.8
                @Override // com.kwad.components.ad.nativead.b.e
                public final boolean b(final double d) {
                    if ((d.this.ps != null && d.this.ps.fQ() && !d.this.ps.fP()) || !d.this.fv() || !b.ca()) {
                        return false;
                    }
                    com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(m.wrapContextIfNeed(view.getContext())).aF(d.this.mAdTemplate).b(d.this.mApkDownloadHelper).az(false).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.nativead.d.8.1
                        @Override // com.kwad.components.core.e.d.a.b
                        public final void onAdClicked() {
                            com.kwad.sdk.core.adlog.c.a(d.this.mAdTemplate, new com.kwad.sdk.core.adlog.c.b().dS(157).j(d), (JSONObject) null);
                            d.this.pv.l(view);
                        }
                    }));
                    by.a(view.getContext(), d.this.F(view.getContext()));
                    return true;
                }
            };
            b.fr().a(com.kwad.sdk.core.response.helper.b.du(this.mAdTemplate) || com.kwad.sdk.core.response.helper.a.am(this.mAdInfo), f, view, this.pe, com.kwad.sdk.core.response.helper.b.dK(this.mAdInfo));
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void k(final View view) {
        AdMatrixInfo.RotateInfo rotateInfoDI = com.kwad.sdk.core.response.helper.b.dI(this.mAdTemplate);
        if (rotateInfoDI == null || !rotateInfoDI.enable) {
            return;
        }
        this.pd = new b.c() { // from class: com.kwad.components.ad.nativead.d.9
            @Override // com.kwad.components.ad.nativead.b.c
            public final boolean s(final String str) {
                if (d.this.ps != null && d.this.ps.fR() && !d.this.ps.fP()) {
                    return false;
                }
                if (!cb.r(view, (int) (com.kwad.sdk.core.config.e.Ko() * 100.0f)) || !d.this.fv() || !b.ca()) {
                    return false;
                }
                com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(m.wrapContextIfNeed(view.getContext())).aF(d.this.mAdTemplate).b(d.this.mApkDownloadHelper).az(false).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.nativead.d.9.1
                    @Override // com.kwad.components.core.e.d.a.b
                    public final void onAdClicked() {
                        com.kwad.sdk.core.adlog.c.a(d.this.mAdTemplate, new com.kwad.sdk.core.adlog.c.b().dS(161).ed(str), (JSONObject) null);
                        d.this.pv.l(view);
                    }
                }));
                by.a(view.getContext(), d.this.F(view.getContext()));
                return true;
            }
        };
        b.fr().a(rotateInfoDI, view.getContext(), this.pd);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public Vibrator F(Context context) {
        if (this.ho == null) {
            this.ho = (Vibrator) context.getSystemService("vibrator");
        }
        return this.ho;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean fv() {
        return (this.mAdInfo.status == 2 || this.mAdInfo.status == 3) ? false : true;
    }

    private static com.kwad.components.core.widget.c d(ViewGroup viewGroup) {
        for (int i = 0; i < viewGroup.getChildCount(); i++) {
            View childAt = viewGroup.getChildAt(i);
            if (childAt instanceof com.kwad.components.core.widget.c) {
                return (com.kwad.components.core.widget.c) childAt;
            }
        }
        return null;
    }

    private static void e(ViewGroup viewGroup) {
        for (int i = 0; i < viewGroup.getChildCount(); i++) {
            View childAt = viewGroup.getChildAt(i);
            if (childAt instanceof com.kwad.components.core.widget.a) {
                viewGroup.removeView(childAt);
            }
        }
    }

    @Override // com.kwad.components.core.internal.api.a
    public final AdTemplate getAdTemplate() {
        return this.mAdTemplate;
    }

    @Override // com.kwad.components.core.internal.api.a
    public final void a(com.kwad.components.core.internal.api.b bVar) {
        this.bz.a(bVar);
    }

    @Override // com.kwad.components.core.internal.api.a
    public final void b(com.kwad.components.core.internal.api.b bVar) {
        this.bz.b(bVar);
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final void setVideoPlayListener(KsNativeAd.VideoPlayListener videoPlayListener) {
        this.pn = videoPlayListener;
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final void startVideo() {
        f fVar = this.pl;
        if (fVar != null) {
            fVar.setPlayState(1);
        }
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final void pauseVideo() {
        f fVar = this.pl;
        if (fVar != null) {
            fVar.setPlayState(2);
        }
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final void stopVideo() {
        f fVar = this.pl;
        if (fVar != null) {
            fVar.setPlayState(3);
        }
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final boolean enableRotate() {
        AdMatrixInfo.RotateInfo rotateInfoDI = com.kwad.sdk.core.response.helper.b.dI(this.mAdTemplate);
        return rotateInfoDI != null && rotateInfoDI.enable;
    }

    @Override // com.kwad.sdk.api.KsNativeAd
    public final View getRotateView(Context context) {
        if (this.pr == null) {
            com.kwad.components.ad.nativead.e.a aVar = new com.kwad.components.ad.nativead.e.a(context);
            this.pr = aVar;
            aVar.fW();
            NativeAdMonitor.fD();
            NativeAdMonitor.fC();
        }
        return this.pr;
    }

    @Override // com.kwad.sdk.api.core.AbstractKsNativeAd
    public final View getVideoView2(Context context, boolean z) {
        if (context == null || !o.GE().FJ()) {
            return null;
        }
        return getVideoView2(context, new KsAdVideoPlayConfig.Builder().videoSoundEnable(z).build());
    }

    @Override // com.kwad.sdk.api.core.AbstractKsNativeAd
    public final View getVideoView2(Context context, KsAdVideoPlayConfig ksAdVideoPlayConfig) {
        KSAdVideoPlayConfigImpl kSAdVideoPlayConfigImpl;
        if (context == null || !o.GE().FJ()) {
            return null;
        }
        try {
            Context contextWrapContextIfNeed = m.wrapContextIfNeed(context);
            if (ksAdVideoPlayConfig instanceof KSAdVideoPlayConfigImpl) {
                kSAdVideoPlayConfigImpl = (KSAdVideoPlayConfigImpl) ksAdVideoPlayConfig;
            } else {
                kSAdVideoPlayConfigImpl = new KSAdVideoPlayConfigImpl();
            }
            if (com.kwad.sdk.core.response.helper.a.cY(this.mAdInfo)) {
                return a(contextWrapContextIfNeed, kSAdVideoPlayConfigImpl);
            }
            return b(contextWrapContextIfNeed, kSAdVideoPlayConfigImpl);
        } catch (Throwable th) {
            RuntimeException runtimeException = new RuntimeException("getVideoView fail--context:" + context.getClass().getName() + "--classloader:" + context.getClassLoader().getClass().getName());
            if (o.GE().FG()) {
                runtimeException.addSuppressed(th);
                com.kwad.components.core.d.a.reportSdkCaughtException(runtimeException);
                return null;
            }
            throw th;
        }
    }

    private View a(Context context, KSAdVideoPlayConfigImpl kSAdVideoPlayConfigImpl) {
        com.kwad.components.core.offline.a.c.a aVar = (com.kwad.components.core.offline.a.c.a) com.kwad.sdk.components.d.f(com.kwad.components.core.offline.a.c.a.class);
        if (aVar == null || !aVar.tG()) {
            return null;
        }
        if (this.pm == null) {
            e eVar = new e(context);
            this.pm = eVar;
            eVar.setInnerAdInteractionListener(this.pv);
            this.pm.setVideoPlayListener(this.pu);
            this.pm.a(context, this.mAdTemplate, this.mApkDownloadHelper, kSAdVideoPlayConfigImpl);
        }
        return this.pm;
    }

    private View b(Context context, KSAdVideoPlayConfigImpl kSAdVideoPlayConfigImpl) {
        if (TextUtils.isEmpty(getVideoUrl())) {
            com.kwad.sdk.core.d.c.w("KsNativeAdControl", "videoUrl is empty");
            return null;
        }
        if (this.pl == null) {
            f fVar = new f(context);
            this.pl = fVar;
            fVar.setInnerAdInteractionListener(this.pv);
            this.pl.setVideoPlayListener(this.pu);
            this.pl.a(this.mAdTemplate, this.mApkDownloadHelper, kSAdVideoPlayConfigImpl);
        }
        return this.pl;
    }

    @Override // android.content.DialogInterface.OnDismissListener
    public final void onDismiss(DialogInterface dialogInterface) {
        this.pv.onDownloadTipsDialogDismiss();
    }

    @Override // android.content.DialogInterface.OnShowListener
    public final void onShow(DialogInterface dialogInterface) {
        a aVar = this.pv;
        if (aVar != null) {
            aVar.onDownloadTipsDialogShow();
        }
    }
}

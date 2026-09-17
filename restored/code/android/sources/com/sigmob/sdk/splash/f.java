package com.sigmob.sdk.splash;

import android.app.Activity;
import android.os.Bundle;
import android.os.Handler;
import android.os.Looper;
import android.os.Message;
import android.view.View;
import android.view.ViewGroup;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.models.AdStatus;
import com.czhj.sdk.common.utils.FileUtil;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.sdk.logger.SigmobLogger;
import com.sigmob.sdk.base.common.BaseBroadcastReceiver;
import com.sigmob.sdk.base.common.ad;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.IntentActions;
import com.sigmob.sdk.base.models.LoadAdRequest;
import com.sigmob.sdk.base.models.rtb.BiddingResponse;
import com.sigmob.sdk.base.mta.PointCategory;
import com.sigmob.sdk.base.mta.PointEntitySigmob;
import com.sigmob.sdk.base.utils.n;
import com.sigmob.sdk.base.utils.s;
import com.sigmob.sdk.base.utils.v;
import com.sigmob.sdk.base.utils.w;
import com.sigmob.windad.Splash.WindSplashADListener;
import com.sigmob.windad.Splash.WindSplashAdRequest;
import com.sigmob.windad.WindAdError;
import com.sigmob.windad.WindAdRequest;
import com.sigmob.windad.WindAds;
import java.io.File;
import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes4.dex */
public final class f extends com.sigmob.sdk.manager.b implements com.sigmob.sdk.base.common.h.b, com.sigmob.sdk.base.network.f.a, e {
    private static final int h = 131073;
    private final LoadAdRequest i;
    private List<BaseAdUnit> k;
    private BaseAdUnit l;
    private BaseAdUnit m;
    private WindSplashADListener o;
    private i p;
    private int r;
    private boolean s;
    private long u;
    private int q = 0;
    private final Handler t = new Handler(Looper.getMainLooper()) { // from class: com.sigmob.sdk.splash.f.1
        @Override // android.os.Handler
        public void handleMessage(Message msg) {
            super.handleMessage(msg);
            if (msg.what == f.h && f.this.b == AdStatus.AdStatusLoading) {
                f.this.t.removeMessages(f.h);
                WindAdError windAdError = WindAdError.ERROR_SIGMOB_AD_TIME_OUT;
                f.this.a(windAdError.getErrorCode(), windAdError.getMessage(), f.this.i);
                f.this.a(windAdError, true);
            }
        }
    };
    private final Runnable j = new Runnable() { // from class: com.sigmob.sdk.splash.f.2
        @Override // java.lang.Runnable
        public void run() {
            f.this.p();
            if (f.this.p == null) {
                return;
            }
            if (f.this.r <= 0) {
                f.this.p.setDuration(0);
                return;
            }
            f.this.p.setDuration(f.this.r);
            f.f(f.this);
            f.this.t.postDelayed(f.this.j, 1000L);
        }
    };
    private final d n = new d(this);

    public f(WindSplashAdRequest splashAdRequest, WindSplashADListener splashADListener) {
        this.i = new LoadAdRequest(splashAdRequest);
        this.o = splashADListener;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(int code, String message, LoadAdRequest loadAdRequest) {
        ad.a(PointCategory.REQUEST, (String) null, code, message, (WindAdRequest) null, loadAdRequest, (BaseAdUnit) null, new ad.a() { // from class: com.sigmob.sdk.splash.f$$ExternalSyntheticLambda3
            @Override // com.sigmob.sdk.base.common.ad.a
            public final void onAddExtra(Object obj) {
                f.a(obj);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(BaseAdUnit baseAdUnit, int i) {
        if (i == 0 && this.s) {
            d(baseAdUnit);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(WindAdError error, boolean isLoadError) {
        SigmobLogger.e(this.f3469a, "handleError: error = " + error + ", isLoadError = " + isLoadError, new Object[0]);
        this.b = AdStatus.AdStatusNone;
        p();
        int request_scene_type = this.i.getRequest_scene_type();
        String placementId = this.i.getPlacementId();
        if (c(Integer.valueOf(request_scene_type)) && v.b(this.o)) {
            if (isLoadError) {
                this.o.onSplashAdLoadFail(error, placementId);
            } else {
                this.o.onSplashAdShowError(error, placementId);
            }
        }
        if (v.b(this.n)) {
            this.n.b(this.m);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(Object obj) {
        if (obj instanceof PointEntitySigmob) {
            ((PointEntitySigmob) obj).setAdx_id(null);
        }
    }

    private boolean a(ViewGroup viewGroup, final BaseAdUnit adUnit) {
        if (adUnit == null) {
            return false;
        }
        this.p = new i(viewGroup.getContext().getApplicationContext());
        int width = viewGroup.getWidth();
        int height = viewGroup.getHeight();
        if (width <= 0 || height <= 0) {
            ViewGroup.LayoutParams layoutParams = this.p.getLayoutParams();
            if (layoutParams == null) {
                layoutParams = new ViewGroup.LayoutParams(-1, -2);
                this.p.setLayoutParams(layoutParams);
            }
            int childMeasureSpec = ViewGroup.getChildMeasureSpec(0, 0, layoutParams.width);
            if (childMeasureSpec == 0) {
                childMeasureSpec = View.MeasureSpec.makeMeasureSpec(ClientMetadata.getInstance().getDisplayMetrics().widthPixels, 1073741824);
            }
            int i = layoutParams.height;
            this.p.measure(childMeasureSpec, i > 0 ? View.MeasureSpec.makeMeasureSpec(i, 1073741824) : View.MeasureSpec.makeMeasureSpec(0, 0));
            width = this.p.getMeasuredWidth();
            height = this.p.getMeasuredHeight();
        }
        if (width > 0 && height > 0) {
            this.p.setAspectRatio((width * 1.0f) / height);
        }
        this.p.b();
        this.p.setViewStatusListener(new i.a() { // from class: com.sigmob.sdk.splash.f$$ExternalSyntheticLambda2
            @Override // com.sigmob.sdk.splash.i.a
            public final void onWindowVisibilityChanged(int i2) {
                this.f$0.a(adUnit, i2);
            }
        });
        return this.p.a(adUnit, w.d(viewGroup));
    }

    private BaseAdUnit b(LoadAdRequest loadAdRequest) {
        if (loadAdRequest == null) {
            com.sigmob.sdk.base.utils.k.e(this.f3469a, "getAdUnitCache: request is null.", new Object[0]);
            return null;
        }
        String strC = n.c(loadAdRequest.getPlacementId());
        Object fromCache = FileUtil.readFromCache(strC);
        if (!(fromCache instanceof BaseAdUnit)) {
            return null;
        }
        FileUtil.deleteFile(strC);
        BaseAdUnit baseAdUnit = (BaseAdUnit) fromCache;
        if (baseAdUnit.getAd() == null) {
            com.sigmob.sdk.base.utils.k.e(this.f3469a, "getAdUnitCache: ad is null.", new Object[0]);
            return null;
        }
        if (v.b(baseAdUnit.bidding_response) && s.b(baseAdUnit.bidding_response.currency, l())) {
            com.sigmob.sdk.base.utils.k.e(this.f3469a, "getAdUnitCache: Inconsistent currency.", new Object[0]);
            return null;
        }
        baseAdUnit.setTraceId(loadAdRequest.getTraceId());
        baseAdUnit.setRequestSceneType(loadAdRequest.getRequest_scene_type());
        com.sigmob.sdk.base.utils.k.c(this.f3469a, "getAdUnitCache: vid = " + baseAdUnit.getVid(), new Object[0]);
        return baseAdUnit;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void b(String str) {
        SigmobLog.d("loadEnd: placementId = " + str);
        WindSplashADListener windSplashADListener = this.o;
        if (windSplashADListener == null) {
            return;
        }
        windSplashADListener.onSplashAdLoadSuccess(str);
    }

    static /* synthetic */ int f(f fVar) {
        int i = fVar.r;
        fVar.r = i - 1;
        return i;
    }

    private Activity t() {
        Activity activityC = w.c(this.p);
        SigmobLogger.d(this.f3469a, "getActivity: activityFromView = " + activityC, new Object[0]);
        return activityC;
    }

    private boolean u() {
        boolean z = c() && v.b(this.n);
        SigmobLog.d("isExistCache: cached = " + z);
        if (z) {
            this.n.a((Map<String, Object>) null, this.m);
            com.sigmob.sdk.base.common.h.g().a(this.m, this);
            SigmobLog.d("isExistCache: ready");
            l(this.m);
        }
        return z;
    }

    private synchronized void v() {
        LoadAdRequest loadAdRequest;
        if (this.p != null && (loadAdRequest = this.i) != null && !loadAdRequest.isDisableAutoHideAd()) {
            w.a(this.p);
            this.p = null;
        }
    }

    private void w() {
        if (this.b == AdStatus.AdStatusPlaying) {
            this.b = AdStatus.AdStatusClose;
            WindSplashADListener windSplashADListener = this.o;
            if (windSplashADListener == null) {
                return;
            }
            windSplashADListener.onSplashAdClose(this.i.getPlacementId());
        }
    }

    @Override // com.sigmob.sdk.base.common.x
    public void a() {
    }

    @Override // com.sigmob.sdk.base.network.f.a
    public void a(int code, String message, String requestId, LoadAdRequest loadAdRequest) {
        WindAdError windAdError = WindAdError.getWindAdError(code);
        if (windAdError == null) {
            windAdError = WindAdError.ERROR_SIGMOB_REQUEST;
            windAdError.setErrorMessage(code, message);
        }
        ad.a(PointCategory.RESPOND, "0", loadAdRequest);
        a(code, message, loadAdRequest);
        a(windAdError, true);
    }

    public void a(Activity activity) {
        if (this.p == null || activity != t()) {
            return;
        }
        this.p.d();
        p();
    }

    public synchronized void a(ViewGroup viewGroup) {
        boolean z = true;
        if (1 != ClientMetadata.getInstance().getOrientationInt().intValue()) {
            z = false;
        }
        if (!z) {
            o();
            return;
        }
        if (v.b(viewGroup) && v.b(this.m) && a(viewGroup, this.m)) {
            BaseAdUnit baseAdUnit = this.m;
            this.l = baseAdUnit;
            this.n.a(baseAdUnit, (Bundle) null);
            if (v.b(this.n.c)) {
                this.r = this.n.c.l();
            }
            if (v.b(this.p)) {
                this.p.setDuration(this.r);
                if (this.p.c()) {
                    viewGroup.addView(this.p, new ViewGroup.LayoutParams(-1, -1));
                    return;
                }
            }
        }
        b_();
    }

    @Override // com.sigmob.sdk.base.common.h.b
    public void a(BaseAdUnit adUnit) {
        SigmobLog.d("loadStart: placementId = " + h());
    }

    @Override // com.sigmob.sdk.base.common.h.b
    public void a(BaseAdUnit adUnit, String error) {
        final String strH = h();
        if (s.b(error)) {
            SigmobLog.e("loadEnd: placementId = " + strH + ", adStatus = " + this.b + ", error = " + error);
            b(this.m, error);
            return;
        }
        if (this.b == AdStatus.AdStatusClose) {
            FileUtil.writeToCache(adUnit, n.c(this.i.getPlacementId()));
        }
        int request_scene_type = this.i.getRequest_scene_type();
        SigmobLogger.d(this.f3469a, "loadEnd: sceneType = " + request_scene_type, new Object[0]);
        a(adUnit, this.i);
        if (this.b == AdStatus.AdStatusLoading && request_scene_type == com.sigmob.sdk.base.j.NormalRequest.a()) {
            if (!(1 == ClientMetadata.getInstance().getOrientationInt().intValue())) {
                o();
                return;
            }
            p();
            this.b = AdStatus.AdStatusReady;
            a((com.sigmob.sdk.manager.b) this);
            WindAds.sharedAds().getHandler().post(new Runnable() { // from class: com.sigmob.sdk.splash.f$$ExternalSyntheticLambda1
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.b(strH);
                }
            });
        }
    }

    public void a(String bidToken, Integer bidFloor, String currency, Integer fetchTime, Boolean preload, com.sigmob.sdk.base.j sceneType, String traceId) {
        boolean zA = a(sceneType);
        this.i.setOriginVid(zA ? this.d : "");
        this.i.setOriginPrice(zA ? this.e : "");
        this.i.setRequest_scene_type(sceneType.a());
        this.i.setBidToken(bidToken);
        this.i.setBidFloor(bidFloor);
        this.i.setCurrency(currency);
        if (!s.b(traceId)) {
            traceId = com.sigmob.sdk.manager.b.j();
        }
        this.i.setTraceId(traceId);
        SigmobLog.d("loadAd: preload = " + preload + ", sceneType = " + sceneType.a());
        if (v.b(preload)) {
            this.b = AdStatus.AdStatusLoading;
            if (u()) {
                return;
            }
        }
        a(this.i);
        com.sigmob.sdk.base.network.f.a(this.i, this);
        this.t.sendEmptyMessageDelayed(h, ((long) fetchTime.intValue()) * 1000);
    }

    public void a(String key, String value) {
        a(this.m, key, value);
    }

    @Override // com.sigmob.sdk.manager.b
    public void a(String originVid, String originPrice, com.sigmob.sdk.base.j requestSceneType) {
        super.a(originVid, originPrice, requestSceneType);
        if (s.b(this.i.getBidToken())) {
            return;
        }
        g();
        a(null, k(), l(), 45, true, requestSceneType, null);
    }

    @Override // com.sigmob.sdk.base.network.f.a
    public void a(List<BaseAdUnit> adUnits, LoadAdRequest loadAdRequest) {
        if (com.sigmob.sdk.base.utils.f.a(adUnits)) {
            return;
        }
        this.k = adUnits;
        BaseAdUnit baseAdUnit = adUnits.get(0);
        SigmobLog.d("onSuccess(real): vid = " + baseAdUnit.getVid());
        a(adUnits, loadAdRequest, baseAdUnit);
        a(loadAdRequest.getRequest_scene_type());
        if (v.b(this.n) && !this.n.a(baseAdUnit)) {
            a(WindAdError.ERROR_SIGMOB_INFORMATION_LOSE, true);
            return;
        }
        this.m = baseAdUnit;
        if (v.b(this.n)) {
            this.n.a((Map<String, Object>) null, baseAdUnit);
        }
        com.sigmob.sdk.base.common.h.g().a(this.m, this);
    }

    @Override // com.sigmob.sdk.splash.e
    public void a_() {
        p();
    }

    @Override // com.sigmob.sdk.base.common.x
    public void b() {
        BaseBroadcastReceiver.a(com.sigmob.sdk.b.e(), this.m.getUuid(), IntentActions.ACTION_INTERSTITIAL_DISMISS);
    }

    public void b(Activity activity) {
        if (this.p == null || activity != t()) {
            return;
        }
        this.p.e();
        this.t.post(this.j);
    }

    @Override // com.sigmob.sdk.base.common.p
    public void b(BaseAdUnit adUnit) {
        a("start", adUnit);
        this.b = AdStatus.AdStatusPlaying;
        m();
        com.sigmob.sdk.base.common.h.a(adUnit);
        if (v.b(this.p)) {
            int duration = this.p.getDuration();
            if (duration > 0 && duration < this.r) {
                this.r = duration;
            }
            this.p.setDuration(this.r);
            this.p.setVisibility(0);
        }
        b((com.sigmob.sdk.manager.b) this);
        if (v.b(this.o)) {
            this.o.onSplashAdShow(this.i.getPlacementId());
        }
        this.q = this.r;
        this.t.post(this.j);
    }

    @Override // com.sigmob.sdk.base.common.p
    public void b(BaseAdUnit adUnit, String error) {
        com.sigmob.sdk.base.utils.k.f(this.f3469a, "onInterstitialFailed: error = " + error, new Object[0]);
        WindAdError windAdError = WindAdError.ERROR_SIGMOB_FILE_DOWNLOAD;
        windAdError.setMessage(error);
        a(windAdError, true);
        ad.a("load", windAdError, this.m, (LoadAdRequest) null);
    }

    @Override // com.sigmob.sdk.splash.e
    public void b_() {
        WindAdError windAdError = WindAdError.ERROR_SIGMOB_SPLASH_UNSUPPORT_RESOURCE;
        ad.a(PointCategory.PLAY, windAdError, this.m, (LoadAdRequest) null);
        a(windAdError, false);
        n();
    }

    @Override // com.sigmob.sdk.base.common.p
    public void c(BaseAdUnit adUnit) {
        this.s = true;
        a("click", adUnit);
        if (com.sigmob.sdk.base.utils.d.a(com.sigmob.sdk.base.utils.d.b(this.f3469a, adUnit)) && v.b(this.o)) {
            this.o.onSplashAdClick(this.i.getPlacementId());
        }
        if (v.b(this.p) && this.p.f()) {
            d(adUnit);
        }
    }

    @Override // com.sigmob.sdk.manager.b
    public boolean c() {
        try {
            if (this.m == null) {
                this.m = b(this.i);
            }
            if (this.m == null) {
                return false;
            }
            SigmobLog.d("isReady: vid = " + this.m.getVid());
            boolean zCanRead = new File(this.m.getSplashFilePath()).canRead();
            boolean zIsExpiredAd = this.m.isExpiredAd();
            boolean zA = this.n.a(this.m);
            boolean z = zCanRead && !zIsExpiredAd && zA;
            SigmobLog.d("isReady: ready = " + z + ", isExist = " + zCanRead + ", isExpired = " + zIsExpiredAd + ", isValid = " + zA);
            return z;
        } catch (Exception e) {
            SigmobLog.e("isReady: error = " + e.getMessage());
            return false;
        }
    }

    @Override // com.sigmob.sdk.splash.e
    public void c_() {
        if (v.b(this.p)) {
            this.p.setDuration(0);
        }
        if (v.b(this.o)) {
            this.o.onSplashAdSkip(this.i.getPlacementId());
        }
    }

    @Override // com.sigmob.sdk.base.common.p
    public void d(BaseAdUnit adUnit) {
        long jCurrentTimeMillis = System.currentTimeMillis();
        if (jCurrentTimeMillis - this.u <= 500) {
            SigmobLogger.d(this.f3469a, "onInterstitialDismissed: unavailable callback.", new Object[0]);
            return;
        }
        this.u = jCurrentTimeMillis;
        this.b = AdStatus.AdStatusClose;
        if (v.b(this.o)) {
            this.o.onSplashAdClose(this.i.getPlacementId());
        }
        this.t.post(new Runnable() { // from class: com.sigmob.sdk.splash.f$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.n();
            }
        });
        if (s.a((CharSequence) adUnit.getBid_token())) {
            a(null, k(), l(), 45, true, com.sigmob.sdk.base.j.SplashCloseRequest, null);
        }
    }

    @Override // com.sigmob.sdk.manager.b
    public boolean d() {
        return f(this.m);
    }

    @Override // com.sigmob.sdk.splash.e
    public void d_() {
    }

    @Override // com.sigmob.sdk.manager.b
    public BaseAdUnit e() {
        return (this.m == null && com.sigmob.sdk.base.utils.f.b(this.k)) ? this.k.get(0) : this.m;
    }

    @Override // com.sigmob.sdk.base.common.p
    public void e(BaseAdUnit adUnit) {
    }

    @Override // com.sigmob.sdk.manager.b
    public LoadAdRequest f() {
        return this.i;
    }

    @Override // com.sigmob.sdk.manager.b
    protected void g() {
        com.sigmob.sdk.base.common.h.b(this.m);
        this.m = null;
        this.k = null;
    }

    @Override // com.sigmob.sdk.manager.b
    public BaseAdUnit i() {
        return this.l;
    }

    public void m() {
        if (v.b(this.m) && this.m.getSessionManager() == null) {
            new k().a(this.m);
        }
    }

    public void n() {
        if (v.b(this.n)) {
            this.n.b(this.m);
        }
        w();
        v();
        g();
        this.o = null;
        this.l = null;
        p();
        b((com.sigmob.sdk.manager.b) this);
    }

    public void o() {
        WindAdError windAdError = WindAdError.ERROR_SIGMOB_SPLASH_UNSUPPORT_ORIENTATION;
        ad.a(PointCategory.PLAY, windAdError, this.m, (LoadAdRequest) null);
        a(windAdError, false);
        n();
    }

    public void p() {
        this.t.removeCallbacksAndMessages(null);
    }

    public String q() {
        return h(this.m);
    }

    public String r() {
        return i(this.m);
    }

    public Map<String, BiddingResponse> s() {
        return j(this.m);
    }
}

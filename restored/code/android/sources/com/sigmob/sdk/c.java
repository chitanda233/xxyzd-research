package com.sigmob.sdk;

import android.os.Handler;
import android.os.Looper;
import com.czhj.sdk.common.models.AdStatus;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.common.h;
import com.sigmob.sdk.base.common.z;
import com.sigmob.sdk.base.m;
import com.sigmob.sdk.base.models.ClickCommon;
import com.sigmob.sdk.base.models.LoadAdRequest;
import com.sigmob.sdk.base.models.rtb.BiddingResponse;
import com.sigmob.sdk.base.mta.PointEntitySigmobError;
import com.sigmob.sdk.base.utils.d;
import com.sigmob.sdk.base.utils.v;
import com.sigmob.sdk.manager.f;
import com.sigmob.sdk.videoAd.k;
import com.sigmob.sdk.videoAd.l;
import com.sigmob.windad.WindAdError;
import com.sigmob.windad.WindAdRequest;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes2.dex */
public abstract class c<T extends f> extends m {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    protected final Handler f3368a;
    protected int b;
    protected T c;
    protected T d;
    protected LoadAdRequest e;
    protected k f;
    protected c<T>.a g;
    private final String m;

    /* JADX INFO: renamed from: com.sigmob.sdk.c$1, reason: invalid class name */
    class AnonymousClass1 implements com.sigmob.sdk.videoAd.m {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ com.sigmob.sdk.videoAd.m f3369a;

        AnonymousClass1(final com.sigmob.sdk.videoAd.m val$showListener) {
            this.f3369a = val$showListener;
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void a(d.a aVar, String str, com.sigmob.sdk.videoAd.m mVar) {
            if (v.b(c.this.c)) {
                HashMap map = new HashMap();
                Integer numValueOf = Integer.valueOf(aVar == null ? 0 : aVar.f3253a.intValue());
                Integer numValueOf2 = Integer.valueOf(aVar == null ? d.b : aVar.b.intValue());
                map.put(ClickCommon.CLICK_LOSE_RATE, String.valueOf(numValueOf));
                map.put(ClickCommon.CLICK_CB_STATE, String.valueOf(numValueOf2));
                c.this.c.a("click_callback", map);
            }
            if (d.a(aVar)) {
                SigmobLog.i("onAdClicked: placementId = " + str);
                if (v.b(mVar)) {
                    mVar.onAdClicked(str);
                }
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void a(com.sigmob.sdk.videoAd.m mVar, WindAdError windAdError, String str) {
            if (v.b(mVar)) {
                mVar.onAdShowError(windAdError, str);
            }
            if (v.b(c.this.d)) {
                if (v.b(c.this.c)) {
                    c.this.c.s();
                }
                c cVar = c.this;
                cVar.c = cVar.d;
                c.this.h = AdStatus.AdStatusReady;
                c.this.d = null;
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void a(com.sigmob.sdk.videoAd.m mVar, String str) {
            if (v.b(c.this.c)) {
                c.this.c.a("close_callback", null);
            }
            if (v.b(mVar)) {
                mVar.onAdClosed(str);
            }
            if (v.b(c.this.d)) {
                if (v.b(c.this.c)) {
                    c.this.c.s();
                }
                c cVar = c.this;
                cVar.c = cVar.d;
                c.this.h = AdStatus.AdStatusReady;
                c.this.d = null;
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public static /* synthetic */ void b(com.sigmob.sdk.videoAd.m mVar, String str) {
            if (v.b(mVar)) {
                mVar.onVideoAdPlayEnd(str);
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public static /* synthetic */ void c(com.sigmob.sdk.videoAd.m mVar, String str) {
            if (v.b(mVar)) {
                mVar.onVideoAdPlayComplete(str);
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void d(com.sigmob.sdk.videoAd.m mVar, String str) {
            if (v.b(c.this.c)) {
                c.this.c.a("show_callback", null);
            }
            if (v.b(mVar)) {
                mVar.onAdShow(str);
            }
        }

        @Override // com.sigmob.sdk.videoAd.m
        public void onAdClicked(final String placementId) {
            final d.a aVarB = d.b(c.this.m, c.this.c == null ? null : c.this.c.i());
            Handler handler = c.this.f3368a;
            final com.sigmob.sdk.videoAd.m mVar = this.f3369a;
            handler.post(new Runnable() { // from class: com.sigmob.sdk.c$1$$ExternalSyntheticLambda1
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.a(aVarB, placementId, mVar);
                }
            });
        }

        @Override // com.sigmob.sdk.videoAd.m
        public void onAdClosed(final String placementId) {
            SigmobLog.i("onAdClosed: placementId = " + placementId);
            c.this.h = AdStatus.AdStatusClose;
            Handler handler = c.this.f3368a;
            final com.sigmob.sdk.videoAd.m mVar = this.f3369a;
            handler.post(new Runnable() { // from class: com.sigmob.sdk.c$1$$ExternalSyntheticLambda0
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.a(mVar, placementId);
                }
            });
        }

        @Override // com.sigmob.sdk.videoAd.m
        public void onAdShow(final String placementId) {
            SigmobLog.i("onAdShow: placementId = " + placementId);
            c.this.h = AdStatus.AdStatusPlaying;
            Handler handler = c.this.f3368a;
            final com.sigmob.sdk.videoAd.m mVar = this.f3369a;
            handler.post(new Runnable() { // from class: com.sigmob.sdk.c$1$$ExternalSyntheticLambda3
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.d(mVar, placementId);
                }
            });
        }

        @Override // com.sigmob.sdk.videoAd.m
        public void onAdShowError(final WindAdError error, final String placementId) {
            SigmobLog.e("onAdShowError: error = " + error.toString() + ", placementId = " + placementId);
            c.this.h = AdStatus.AdStatusClose;
            Handler handler = c.this.f3368a;
            final com.sigmob.sdk.videoAd.m mVar = this.f3369a;
            handler.post(new Runnable() { // from class: com.sigmob.sdk.c$1$$ExternalSyntheticLambda5
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.a(mVar, error, placementId);
                }
            });
        }

        @Override // com.sigmob.sdk.videoAd.m
        public void onVideoAdPlayComplete(final String placementId) {
            SigmobLog.i("onVideoAdPlayComplete: placementId = " + placementId);
            Handler handler = c.this.f3368a;
            final com.sigmob.sdk.videoAd.m mVar = this.f3369a;
            handler.post(new Runnable() { // from class: com.sigmob.sdk.c$1$$ExternalSyntheticLambda4
                @Override // java.lang.Runnable
                public final void run() {
                    c.AnonymousClass1.c(mVar, placementId);
                }
            });
        }

        @Override // com.sigmob.sdk.videoAd.m
        public void onVideoAdPlayEnd(final String placementId) {
            SigmobLog.i("onVideoAdPlayEnd: placementId = " + placementId);
            Handler handler = c.this.f3368a;
            final com.sigmob.sdk.videoAd.m mVar = this.f3369a;
            handler.post(new Runnable() { // from class: com.sigmob.sdk.c$1$$ExternalSyntheticLambda2
                @Override // java.lang.Runnable
                public final void run() {
                    c.AnonymousClass1.b(mVar, placementId);
                }
            });
        }
    }

    protected class a implements k {
        private k b;

        public a(k windAdLoadListener) {
            this.b = windAdLoadListener;
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void a(WindAdError windAdError, String str) {
            if (v.b(this.b)) {
                this.b.onAdLoadError(windAdError, str);
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void a(String str) {
            if (v.b(this.b)) {
                this.b.onAdPreLoadSuccess(str);
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void b(WindAdError windAdError, String str) {
            if (v.b(this.b)) {
                this.b.onAdPreLoadFail(windAdError, str);
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void b(String str) {
            if (v.b(this.b)) {
                this.b.onAdLoadSuccess(str);
            }
        }

        public void a() {
            this.b = null;
        }

        @Override // com.sigmob.sdk.videoAd.k
        public void onAdLoadError(final WindAdError error, final String placementId) {
            SigmobLog.e("onAdLoadError: error = " + error.toString() + ", placementId = " + placementId + ", adStatus = " + c.this.h);
            if (c.this.h != AdStatus.AdStatusPlaying) {
                c.this.h = AdStatus.AdStatusNone;
            }
            c.this.f3368a.post(new Runnable() { // from class: com.sigmob.sdk.c$a$$ExternalSyntheticLambda0
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.a(error, placementId);
                }
            });
        }

        @Override // com.sigmob.sdk.videoAd.k
        public void onAdLoadSuccess(final String placementId) {
            SigmobLog.i("onAdLoadSuccess: placementId = " + placementId + ", adStatus = " + c.this.h);
            if (c.this.h != AdStatus.AdStatusPlaying) {
                c.this.h = AdStatus.AdStatusReady;
            }
            c.this.f3368a.post(new Runnable() { // from class: com.sigmob.sdk.c$a$$ExternalSyntheticLambda1
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.b(placementId);
                }
            });
        }

        @Override // com.sigmob.sdk.videoAd.k
        public void onAdPreLoadFail(final WindAdError error, final String placementId) {
            SigmobLog.e("onAdPreLoadFail: error = " + error.toString() + ", placementId = " + placementId + ", adStatus = " + c.this.h);
            if (c.this.h != AdStatus.AdStatusPlaying) {
                c.this.h = AdStatus.AdStatusNone;
            }
            c.this.f3368a.post(new Runnable() { // from class: com.sigmob.sdk.c$a$$ExternalSyntheticLambda3
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.b(error, placementId);
                }
            });
        }

        @Override // com.sigmob.sdk.videoAd.k
        public void onAdPreLoadSuccess(final String placementId) {
            SigmobLog.i("onAdPreLoadSuccess: placementId = " + placementId);
            c.this.f3368a.post(new Runnable() { // from class: com.sigmob.sdk.c$a$$ExternalSyntheticLambda2
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.a(placementId);
                }
            });
        }
    }

    protected c(WindAdRequest windAdRequest, boolean z, int i) {
        super(windAdRequest, z);
        this.m = getClass().getSimpleName();
        this.f3368a = new Handler(Looper.getMainLooper());
        this.b = i;
        h.g().a(d(), windAdRequest.getAdType());
        this.c = (T) createAdManager();
    }

    private void a(T adManager) {
        String strJ = com.sigmob.sdk.manager.b.j();
        a((z) null, strJ);
        adManager.a(this.e, strJ);
    }

    protected void a(l windAdRewardListener) {
    }

    @Override // com.sigmob.sdk.base.m
    protected void a(WindAdError error) {
        if (this.h != AdStatus.AdStatusLoading) {
            this.h = AdStatus.AdStatusNone;
        }
        if (v.b(this.f)) {
            String strD = d();
            this.f.onAdPreLoadFail(error, strD);
            this.f.onAdLoadError(error, strD);
        }
    }

    protected void a(WindAdError error, String errMsg) {
        PointEntitySigmobError pointEntitySigmobErrorSigmobError = PointEntitySigmobError.SigmobError("error", error.getErrorCode(), errMsg);
        pointEntitySigmobErrorSigmobError.setAdtype(String.valueOf(this.b));
        pointEntitySigmobErrorSigmobError.setPlacement_id(d());
        pointEntitySigmobErrorSigmobError.commit();
    }

    @Override // com.sigmob.sdk.base.m
    protected void a(String key, String value) {
        T t = this.c;
        if (t == null) {
            return;
        }
        t.a(key, value);
    }

    protected boolean a() {
        T t;
        String strD = d();
        try {
            if (!g()) {
                return false;
            }
            if (v.b(this.g)) {
                this.g.a();
                this.g = null;
            }
            this.g = new a(this.f);
            T t2 = this.c;
            if (t2 == null) {
                this.c = (T) createAdManager();
            } else if (t2.c() && this.h == AdStatus.AdStatusReady) {
                this.g.onAdPreLoadSuccess(strD);
                this.g.onAdLoadSuccess(strD);
                return true;
            }
            LoadAdRequest loadAdRequest = new LoadAdRequest(this.l);
            this.e = loadAdRequest;
            loadAdRequest.setBidToken(getBid_token());
            this.e.setBidFloor(Integer.valueOf(getBidFloor()));
            this.e.setCurrency(h());
            this.c.a(this.g);
            if (this.h == AdStatus.AdStatusPlaying) {
                if (this.d == null) {
                    T t3 = (T) createAdManager();
                    this.d = t3;
                    t3.a(this.g);
                    t = this.d;
                } else if (v.b(this.f)) {
                    SigmobLog.i("onVideoAdLoadSuccess: placementId = " + strD);
                    this.f.onAdLoadSuccess(strD);
                }
                return true;
            }
            this.h = AdStatus.AdStatusLoading;
            t = this.c;
            a(t);
            return true;
        } catch (Throwable th) {
            PointEntitySigmobError pointEntitySigmobErrorSigmobError = PointEntitySigmobError.SigmobError("error", WindAdError.ERROR_SIGMOB_REQUEST.getErrorCode(), th.getMessage());
            pointEntitySigmobErrorSigmobError.setAdtype(String.valueOf(this.b));
            pointEntitySigmobErrorSigmobError.setPlacement_id(strD);
            pointEntitySigmobErrorSigmobError.commit();
            SigmobLog.e("onVideoAdLoadError: error = " + th.getMessage() + ", placementId = " + strD + ", adStatus = " + this.h);
            if (v.b(this.f)) {
                this.f.onAdLoadError(WindAdError.ERROR_SIGMOB_REQUEST, strD);
            }
            return false;
        }
    }

    @Override // com.sigmob.sdk.base.m
    protected Map<String, BiddingResponse> b() {
        T t = this.c;
        if (t == null) {
            return null;
        }
        return t.m();
    }

    @Override // com.sigmob.sdk.base.m
    protected com.sigmob.sdk.manager.b c() {
        return this.c;
    }

    protected abstract T createAdManager();

    public void destroy() {
        this.f3368a.removeCallbacksAndMessages(null);
        if (v.b(this.g)) {
            this.g.a();
            this.g = null;
        }
        this.f = null;
        if (v.b(this.c)) {
            this.c.s();
            this.c = null;
        }
        if (v.b(this.d)) {
            this.d.s();
            this.d = null;
        }
    }

    @Override // com.sigmob.sdk.base.m
    public String getCurrency() {
        T t = this.c;
        if (t == null) {
            return null;
        }
        return t.b();
    }

    @Override // com.sigmob.sdk.base.m
    public String getEcpm() {
        T t = this.c;
        if (t == null) {
            return null;
        }
        return t.a();
    }

    public boolean isReady() {
        return f();
    }

    @Override // com.sigmob.sdk.base.m
    public boolean loadAd() {
        super.loadAd();
        return a();
    }

    @Override // com.sigmob.sdk.base.m
    public boolean loadAd(String bidToken) {
        super.loadAd(bidToken);
        return a();
    }

    public void setAdLoadListener(k adLoadListener) {
        this.f = adLoadListener;
    }

    public boolean show(HashMap<String, String> options, com.sigmob.sdk.videoAd.m windAdShowListener) {
        return show(options, windAdShowListener, null);
    }

    public boolean show(HashMap<String, String> options, com.sigmob.sdk.videoAd.m showListener, l rewardListener) {
        try {
            if (this.e == null) {
                a(WindAdError.ERROR_SIGMOB_PLACEMENTID_EMPTY, "loadAdRequest is null.");
                if (!v.b(showListener)) {
                    return false;
                }
                showListener.onAdShowError(WindAdError.ERROR_SIGMOB_PLACEMENTID_EMPTY, d());
                return false;
            }
            if (v.b(options)) {
                if (options.containsKey("scene_id")) {
                    this.e.setAd_scene_id(options.get("scene_id"));
                }
                if (options.containsKey("scene_desc")) {
                    this.e.setAd_scene_desc(options.get("scene_desc"));
                }
            }
            if (this.b == 1) {
                a(rewardListener);
            }
            this.c.a(this.e, new AnonymousClass1(showListener));
            return true;
        } catch (Throwable th) {
            a(WindAdError.ERROR_SIGMOB_REQUEST, th.getMessage());
            SigmobLog.e("show: error = " + th.getMessage());
        }
    }
}

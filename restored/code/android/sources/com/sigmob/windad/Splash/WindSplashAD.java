package com.sigmob.windad.Splash;

import android.app.Activity;
import android.os.Handler;
import android.os.Looper;
import android.view.ViewGroup;
import android.view.Window;
import android.view.WindowManager;
import android.widget.RelativeLayout;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.models.AdStatus;
import com.czhj.sdk.common.utils.AdLifecycleManager;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.common.z;
import com.sigmob.sdk.base.j;
import com.sigmob.sdk.base.m;
import com.sigmob.sdk.base.models.rtb.BiddingResponse;
import com.sigmob.sdk.base.utils.v;
import com.sigmob.sdk.base.utils.w;
import com.sigmob.sdk.manager.b;
import com.sigmob.sdk.splash.f;
import com.sigmob.windad.WindAdError;
import java.util.Map;

/* JADX INFO: loaded from: classes4.dex */
public final class WindSplashAD extends m implements AdLifecycleManager.LifecycleListener {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private WindSplashADListener f3699a;
    private ViewGroup b;
    private final int c;
    private RelativeLayout d;
    private final boolean e;
    private boolean f;
    private boolean g;
    private final f m;
    private final Handler n;

    /* JADX INFO: renamed from: com.sigmob.windad.Splash.WindSplashAD$1, reason: invalid class name */
    class AnonymousClass1 implements WindSplashADListener {
        AnonymousClass1() {
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void a(WindAdError windAdError, String str) {
            if (WindSplashAD.this.f3699a == null) {
                return;
            }
            WindSplashAD.this.f3699a.onSplashAdLoadFail(windAdError, str);
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void a(String str) {
            if (WindSplashAD.this.f3699a == null) {
                return;
            }
            WindSplashAD.this.f3699a.onSplashAdSkip(str);
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void b(String str) {
            if (WindSplashAD.this.f3699a == null) {
                return;
            }
            WindSplashAD.this.f3699a.onSplashAdClose(str);
            WindSplashAD.this.l();
        }

        @Override // com.sigmob.windad.Splash.WindSplashADListener
        public void onSplashAdClick(String placementId) {
            if (WindSplashAD.this.f3699a == null) {
                return;
            }
            WindSplashAD.this.f3699a.onSplashAdClick(placementId);
        }

        @Override // com.sigmob.windad.Splash.WindSplashADListener
        public void onSplashAdClose(final String placementId) {
            WindSplashAD.this.h = AdStatus.AdStatusClose;
            WindSplashAD.this.n.post(new Runnable() { // from class: com.sigmob.windad.Splash.WindSplashAD$1$$ExternalSyntheticLambda0
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.b(placementId);
                }
            });
        }

        @Override // com.sigmob.windad.Splash.WindSplashADListener
        public void onSplashAdLoadFail(final WindAdError error, final String placementId) {
            WindSplashAD.this.h = AdStatus.AdStatusNone;
            WindSplashAD.this.n.post(new Runnable() { // from class: com.sigmob.windad.Splash.WindSplashAD$1$$ExternalSyntheticLambda1
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.a(error, placementId);
                }
            });
        }

        @Override // com.sigmob.windad.Splash.WindSplashADListener
        public void onSplashAdLoadSuccess(String placementId) {
            WindSplashAD.this.h = AdStatus.AdStatusReady;
            if (WindSplashAD.this.f3699a != null) {
                WindSplashAD.this.f3699a.onSplashAdLoadSuccess(placementId);
            }
            if (WindSplashAD.this.g) {
                WindSplashAD.this.i();
            }
        }

        @Override // com.sigmob.windad.Splash.WindSplashADListener
        public void onSplashAdShow(String placementId) {
            if (WindSplashAD.this.f3699a == null) {
                return;
            }
            WindSplashAD.this.f3699a.onSplashAdShow(placementId);
        }

        @Override // com.sigmob.windad.Splash.WindSplashADListener
        public void onSplashAdShowError(WindAdError error, String placementId) {
            WindSplashAD.this.b(error, placementId);
        }

        @Override // com.sigmob.windad.Splash.WindSplashADListener
        public void onSplashAdSkip(final String placementId) {
            WindSplashAD.this.n.post(new Runnable() { // from class: com.sigmob.windad.Splash.WindSplashAD$1$$ExternalSyntheticLambda2
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.a(placementId);
                }
            });
        }
    }

    public WindSplashAD(WindSplashAdRequest adRequest, WindSplashADListener adListener) {
        super(adRequest, false);
        this.f = false;
        this.n = new Handler(Looper.getMainLooper());
        this.f3699a = adListener;
        this.m = new f(adRequest, new AnonymousClass1());
        this.c = adRequest.getFetchDelay();
        this.e = adRequest.isDisableAutoHideAd();
    }

    private void a() {
        if (this.b == null) {
            return;
        }
        RelativeLayout relativeLayout = new RelativeLayout(this.b.getContext());
        this.d = relativeLayout;
        relativeLayout.setVisibility(4);
        this.d.setId(ClientMetadata.generateViewId());
        this.b.addView(this.d, new RelativeLayout.LayoutParams(-1, -1));
    }

    private void a(final WindAdError error, final String placementId) {
        SigmobLog.e("onSplashError: error = " + error + ", placementId = " + placementId);
        if (this.f) {
            return;
        }
        this.n.removeMessages(1);
        this.n.post(new Runnable() { // from class: com.sigmob.windad.Splash.WindSplashAD$$ExternalSyntheticLambda3
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.d(error, placementId);
            }
        });
        l();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void b(WindAdError windAdError) {
        WindSplashADListener windSplashADListener = this.f3699a;
        if (windSplashADListener == null) {
            return;
        }
        windSplashADListener.onSplashAdLoadFail(windAdError, d());
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void b(final WindAdError error, final String placementId) {
        this.h = AdStatus.AdStatusNone;
        b bVar = this.m;
        bVar.b(bVar);
        this.n.post(new Runnable() { // from class: com.sigmob.windad.Splash.WindSplashAD$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.c(error, placementId);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void c(WindAdError windAdError, String str) {
        WindSplashADListener windSplashADListener = this.f3699a;
        if (windSplashADListener == null) {
            return;
        }
        windSplashADListener.onSplashAdShowError(windAdError, str);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void d(WindAdError windAdError, String str) {
        WindSplashADListener windSplashADListener = this.f3699a;
        if (windSplashADListener == null) {
            return;
        }
        this.f = true;
        windSplashADListener.onSplashAdLoadFail(windAdError, str);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void i() {
        if (this.m == null) {
            a(WindAdError.ERROR_SIGMOB_SPLASH_NOT_READY, d());
            return;
        }
        a();
        RelativeLayout relativeLayout = this.d;
        if (relativeLayout != null) {
            relativeLayout.setVisibility(0);
        }
        this.n.post(new Runnable() { // from class: com.sigmob.windad.Splash.WindSplashAD$$ExternalSyntheticLambda1
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.m();
            }
        });
        this.h = AdStatus.AdStatusPlaying;
    }

    private boolean j() {
        int bidFloor = getBidFloor();
        String strH = h();
        if (this.m.c() && this.h == AdStatus.AdStatusReady) {
            SigmobLog.i("load: ready");
            return true;
        }
        if (!g()) {
            return false;
        }
        AdLifecycleManager.getInstance().addLifecycleListener(this);
        this.h = AdStatus.AdStatusLoading;
        String strJ = b.j();
        a((z) null, strJ);
        this.m.a(getBid_token(), Integer.valueOf(bidFloor), strH, Integer.valueOf(this.c), false, j.NormalRequest, strJ);
        return true;
    }

    private void k() {
        Activity activityC;
        ViewGroup viewGroup = this.b;
        if (viewGroup == null || (activityC = w.c(viewGroup)) == null) {
            return;
        }
        Window window = activityC.getWindow();
        WindowManager.LayoutParams attributes = window.getAttributes();
        attributes.systemUiVisibility = 2050;
        window.setAttributes(attributes);
        window.addFlags(1024);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void l() {
        if (this.e) {
            return;
        }
        RelativeLayout relativeLayout = this.d;
        if (relativeLayout != null) {
            relativeLayout.setVisibility(8);
            this.d.removeAllViews();
            this.d = null;
        }
        this.b = null;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void m() {
        this.m.a((ViewGroup) this.d);
    }

    @Override // com.sigmob.sdk.base.m
    protected void a(final WindAdError adError) {
        this.h = AdStatus.AdStatusNone;
        this.n.post(new Runnable() { // from class: com.sigmob.windad.Splash.WindSplashAD$$ExternalSyntheticLambda2
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.b(adError);
            }
        });
    }

    @Override // com.sigmob.sdk.base.m
    protected void a(String key, String value) {
        f fVar = this.m;
        if (fVar == null) {
            return;
        }
        fVar.a(key, value);
    }

    @Override // com.sigmob.sdk.base.m
    protected Map<String, BiddingResponse> b() {
        f fVar = this.m;
        if (fVar == null) {
            return null;
        }
        return fVar.s();
    }

    @Override // com.sigmob.sdk.base.m
    protected b c() {
        return this.m;
    }

    public void destroy() {
        Object[] objArr = new Object[1];
        objArr[0] = this.l != null ? this.l.getPlacementId() : "null";
        SigmobLog.i(String.format("splash ad %s is Destroy", objArr));
        f fVar = this.m;
        if (fVar != null) {
            fVar.n();
            this.n.removeCallbacksAndMessages(null);
            this.f3699a = null;
            this.b = null;
        }
        RelativeLayout relativeLayout = this.d;
        if (relativeLayout != null && !this.e) {
            relativeLayout.setVisibility(8);
            this.d.removeAllViews();
        }
        this.d = null;
    }

    @Override // com.sigmob.sdk.base.m
    public String getCurrency() {
        f fVar = this.m;
        if (fVar == null) {
            return null;
        }
        return fVar.r();
    }

    @Override // com.sigmob.sdk.base.m
    public String getEcpm() {
        f fVar = this.m;
        if (fVar == null) {
            return null;
        }
        return fVar.q();
    }

    public boolean isReady() {
        return f();
    }

    @Override // com.sigmob.sdk.base.m
    public boolean loadAd() {
        this.g = false;
        super.loadAd();
        return j();
    }

    @Override // com.sigmob.sdk.base.m
    public boolean loadAd(String bid_token) {
        super.loadAd(bid_token);
        return j();
    }

    public void loadAndShow(ViewGroup adContainer) {
        if (adContainer == null) {
            a(WindAdError.ERROR_SIGMOB_ADCONTAINER_IS_NULL);
            return;
        }
        super.loadAd();
        this.b = adContainer;
        this.g = true;
        j();
    }

    public void loadAndShow(String bidToken, ViewGroup adContainer) {
        if (adContainer == null) {
            a(WindAdError.ERROR_SIGMOB_ADCONTAINER_IS_NULL);
            return;
        }
        super.loadAd(bidToken);
        this.b = adContainer;
        this.g = true;
        j();
    }

    @Override // com.czhj.sdk.common.utils.AdLifecycleManager.LifecycleListener
    public void onCreate(Activity activity) {
    }

    @Override // com.czhj.sdk.common.utils.AdLifecycleManager.LifecycleListener
    public void onDestroy(Activity activity) {
    }

    @Override // com.czhj.sdk.common.utils.AdLifecycleManager.LifecycleListener
    public void onPause(Activity activity) {
        f fVar = this.m;
        if (fVar == null) {
            return;
        }
        fVar.a(activity);
    }

    @Override // com.czhj.sdk.common.utils.AdLifecycleManager.LifecycleListener
    public void onResume(Activity activity) {
        f fVar = this.m;
        if (fVar == null) {
            return;
        }
        fVar.b(activity);
    }

    @Override // com.czhj.sdk.common.utils.AdLifecycleManager.LifecycleListener
    public void onStart(Activity activity) {
    }

    @Override // com.czhj.sdk.common.utils.AdLifecycleManager.LifecycleListener
    public void onStop(Activity activity) {
    }

    public void show(ViewGroup adContainer) {
        f fVar;
        if (this.g || (fVar = this.m) == null) {
            if (v.b(this.m)) {
                b bVar = this.m;
                bVar.b(bVar);
            }
            a(WindAdError.ERROR_SIGMOB_SPLASH_NOT_READY, d());
            return;
        }
        if (fVar.d()) {
            b(WindAdError.ERROR_SIGMOB_EXPIRED, d());
            return;
        }
        if (!isReady()) {
            b bVar2 = this.m;
            bVar2.b(bVar2);
            a(WindAdError.ERROR_SIGMOB_SPLASH_NOT_READY, d());
        } else if (adContainer == null) {
            b(WindAdError.ERROR_SIGMOB_ADCONTAINER_IS_NULL, d());
        } else {
            this.b = adContainer;
            i();
        }
    }
}

package com.sigmob.windad.natives;

import android.os.Handler;
import android.os.Looper;
import com.czhj.sdk.common.models.AdStatus;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.common.z;
import com.sigmob.sdk.base.m;
import com.sigmob.sdk.base.models.rtb.BiddingResponse;
import com.sigmob.sdk.base.mta.PointEntitySigmobError;
import com.sigmob.sdk.manager.b;
import com.sigmob.sdk.nativead.aa;
import com.sigmob.sdk.nativead.y;
import com.sigmob.windad.WindAdError;
import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes4.dex */
public class WindNativeUnifiedAd extends m {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private WindNativeAdLoadListener f3708a;
    private final Handler b;
    private final y c;

    /* JADX INFO: renamed from: com.sigmob.windad.natives.WindNativeUnifiedAd$1, reason: invalid class name */
    class AnonymousClass1 implements aa {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ WindNativeAdRequest f3709a;

        AnonymousClass1(final WindNativeAdRequest val$request) {
            this.f3709a = val$request;
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void a(int i, String str, WindNativeAdRequest windNativeAdRequest) {
            if (WindNativeUnifiedAd.this.f3708a == null) {
                return;
            }
            WindAdError windAdError = WindAdError.getWindAdError(i);
            if (windAdError == null) {
                windAdError = WindAdError.ERROR_SIGMOB_REQUEST;
                windAdError.setErrorMessage(i, str);
                windAdError.setMessage(str);
            }
            WindNativeUnifiedAd.this.f3708a.onAdError(windAdError, windNativeAdRequest.getPlacementId());
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void a(List list) {
            if (WindNativeUnifiedAd.this.f3708a == null) {
                return;
            }
            WindNativeUnifiedAd.this.f3708a.onAdLoad(list, WindNativeUnifiedAd.this.d());
        }

        @Override // com.sigmob.sdk.nativead.aa
        public void onNativeAdLoadFail(final int errorCode, final String errorMsg) {
            WindNativeUnifiedAd.this.h = AdStatus.AdStatusNone;
            Handler handler = WindNativeUnifiedAd.this.b;
            final WindNativeAdRequest windNativeAdRequest = this.f3709a;
            handler.post(new Runnable() { // from class: com.sigmob.windad.natives.WindNativeUnifiedAd$1$$ExternalSyntheticLambda0
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.a(errorCode, errorMsg, windNativeAdRequest);
                }
            });
        }

        @Override // com.sigmob.sdk.nativead.aa
        public void onNativeAdLoaded(final List<WindNativeAdData> adUnits) {
            WindNativeUnifiedAd.this.h = AdStatus.AdStatusNone;
            WindNativeUnifiedAd.this.b.post(new Runnable() { // from class: com.sigmob.windad.natives.WindNativeUnifiedAd$1$$ExternalSyntheticLambda1
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.a(adUnits);
                }
            });
        }
    }

    public interface WindNativeAdLoadListener {
        void onAdError(WindAdError error, String placementId);

        void onAdLoad(List<WindNativeAdData> adDataList, String placementId);
    }

    public WindNativeUnifiedAd(WindNativeAdRequest request) {
        super(request, false);
        this.b = new Handler(Looper.getMainLooper());
        this.c = new y(request, new AnonymousClass1(request));
    }

    private void a(Throwable e) {
        PointEntitySigmobError pointEntitySigmobErrorSigmobError = PointEntitySigmobError.SigmobError("error", WindAdError.ERROR_SIGMOB_REQUEST.getErrorCode(), e.getMessage());
        pointEntitySigmobErrorSigmobError.setAdtype(String.valueOf(5));
        pointEntitySigmobErrorSigmobError.setPlacement_id(d());
        pointEntitySigmobErrorSigmobError.commit();
        a(WindAdError.ERROR_SIGMOB_REQUEST);
    }

    private boolean a(int adCount) {
        try {
            if (!g()) {
                return false;
            }
            String strJ = b.j();
            this.h = AdStatus.AdStatusLoading;
            if (this.c.a(adCount, getBid_token(), getBidFloor(), h(), strJ) == 1) {
                a(z.a(d()), strJ);
            }
            return true;
        } catch (Throwable th) {
            SigmobLog.i(getClass().getSimpleName() + " catch throwable " + th);
            if (this.f3708a == null) {
                return false;
            }
            WindAdError windAdError = WindAdError.ERROR_SIGMOB_REQUEST;
            windAdError.setMessage(th.getMessage());
            this.f3708a.onAdError(windAdError, d());
            return false;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void b(WindAdError windAdError) {
        this.h = AdStatus.AdStatusNone;
        if (this.f3708a == null) {
            return;
        }
        SigmobLog.i("onVideoAdLoadFail " + windAdError.toString() + "|" + d());
        this.f3708a.onAdError(windAdError, d());
    }

    @Override // com.sigmob.sdk.base.m
    protected void a(final WindAdError error) {
        this.b.post(new Runnable() { // from class: com.sigmob.windad.natives.WindNativeUnifiedAd$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.b(error);
            }
        });
    }

    @Override // com.sigmob.sdk.base.m
    protected void a(String key, String value) {
        y yVar = this.c;
        if (yVar == null) {
            return;
        }
        yVar.a(key, value);
    }

    @Override // com.sigmob.sdk.base.m
    protected Map<String, BiddingResponse> b() {
        y yVar = this.c;
        if (yVar == null) {
            return null;
        }
        return yVar.c();
    }

    @Override // com.sigmob.sdk.base.m
    protected b c() {
        return null;
    }

    public void destroy() {
        Object[] objArr = new Object[1];
        objArr[0] = this.l != null ? this.l.getPlacementId() : "null";
        SigmobLog.i(String.format("native ad %s is Destroy", objArr));
        this.f3708a = null;
    }

    @Override // com.sigmob.sdk.base.m
    public String getCurrency() {
        y yVar = this.c;
        if (yVar == null) {
            return null;
        }
        return yVar.b();
    }

    @Override // com.sigmob.sdk.base.m
    public String getEcpm() {
        y yVar = this.c;
        if (yVar == null) {
            return null;
        }
        return yVar.a();
    }

    @Override // com.sigmob.sdk.base.m
    @Deprecated
    public boolean loadAd() {
        try {
            super.loadAd();
            return a(this.l.getAdCount());
        } catch (Throwable th) {
            a(th);
            return false;
        }
    }

    public boolean loadAd(int adCount) {
        try {
            super.loadAd();
            int iMax = Math.max(this.l.getAdCount(), adCount);
            this.l.setAdCount(iMax);
            return a(iMax);
        } catch (Throwable th) {
            a(th);
            return false;
        }
    }

    @Override // com.sigmob.sdk.base.m
    public boolean loadAd(String bidToken) {
        try {
            super.loadAd(bidToken);
            return a(this.l.getAdCount() > 0 ? this.l.getAdCount() : 1);
        } catch (Throwable th) {
            a(th);
            return false;
        }
    }

    public boolean loadAd(String bidToken, int adCount) {
        try {
            super.loadAd(bidToken);
            return a(adCount);
        } catch (Throwable th) {
            a(th);
            return false;
        }
    }

    public void setNativeAdLoadListener(WindNativeAdLoadListener nativeAdLoadListener) {
        this.f3708a = nativeAdLoadListener;
    }
}

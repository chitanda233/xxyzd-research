package com.bytedance.msdk.adapter.sigmob;

import android.content.Context;
import android.util.SparseArray;
import com.bytedance.msdk.adapter.sigmob.base.config.MediationAdSlotValueSet;
import com.sigmob.windad.WindAdError;
import com.sigmob.windad.natives.WindNativeAdData;
import com.sigmob.windad.natives.WindNativeAdRequest;
import com.sigmob.windad.natives.WindNativeUnifiedAd;
import java.util.ArrayList;
import java.util.List;
import java.util.function.Function;

/* JADX INFO: loaded from: classes2.dex */
public class SigmobNativeLoader extends SigmobBaseLoader {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private WindNativeUnifiedAd f1887a;
    private MediationAdSlotValueSet b;

    private void a(final Context context) {
        WindNativeUnifiedAd windNativeUnifiedAd = new WindNativeUnifiedAd(new WindNativeAdRequest(this.b.getADNId(), this.b.getUserId(), this.b.getAdCount(), null));
        this.f1887a = windNativeUnifiedAd;
        windNativeUnifiedAd.setNativeAdLoadListener(new WindNativeUnifiedAd.WindNativeAdLoadListener() { // from class: com.bytedance.msdk.adapter.sigmob.SigmobNativeLoader.1
            @Override // com.sigmob.windad.natives.WindNativeUnifiedAd.WindNativeAdLoadListener
            public void onAdError(WindAdError windAdError, String str) {
                if (windAdError != null) {
                    SigmobNativeLoader.this.notifyAdFailed(windAdError.getErrorCode(), windAdError.getMessage());
                } else {
                    SigmobNativeLoader.this.notifyAdFailed(80001, "error is null");
                }
            }

            @Override // com.sigmob.windad.natives.WindNativeUnifiedAd.WindNativeAdLoadListener
            public void onAdLoad(List<WindNativeAdData> list, String str) {
                if (list == null || list.isEmpty()) {
                    SigmobNativeLoader.this.notifyAdFailed(80001, "请求成功，但无广告可用");
                    return;
                }
                ArrayList arrayList = new ArrayList();
                for (WindNativeAdData windNativeAdData : list) {
                    if (windNativeAdData != null) {
                        Function<SparseArray<Object>, Object> gMBridge = SigmobNativeLoader.this.getGMBridge();
                        new SigmobNativeAd(context, windNativeAdData, SigmobNativeLoader.this, gMBridge);
                        arrayList.add(gMBridge);
                    }
                }
                SigmobNativeLoader.this.notifyAdSuccess(arrayList);
            }
        });
        if (isServerBidding()) {
            this.f1887a.loadAd(getAdm());
        } else {
            this.f1887a.loadAd();
        }
    }

    public WindNativeUnifiedAd getWindNativeUnifiedAd() {
        return this.f1887a;
    }

    @Override // com.bytedance.msdk.adapter.sigmob.base.MediationAdLoaderBaseFunction
    public void realLoader(Context context, MediationAdSlotValueSet mediationAdSlotValueSet) {
        this.b = mediationAdSlotValueSet;
        a(context.getApplicationContext());
    }
}

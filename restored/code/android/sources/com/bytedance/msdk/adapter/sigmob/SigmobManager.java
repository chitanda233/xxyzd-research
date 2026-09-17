package com.bytedance.msdk.adapter.sigmob;

import android.util.SparseArray;
import com.bytedance.msdk.adapter.sigmob.base.proto.AdnAdapterBaseFunction;

/* JADX INFO: loaded from: classes2.dex */
public class SigmobManager extends AdnAdapterBaseFunction {
    @Override // com.bytedance.msdk.adapter.sigmob.base.proto.AdnAdapterBaseFunction
    public <T> T applyFunction(int i, SparseArray<Object> sparseArray, Class<T> cls) {
        if (i == 10000) {
            return (T) new SigmobAdapterConfiguration();
        }
        if (i == 20001) {
            return (T) new SigmobBannerLoader();
        }
        if (i == 20003) {
            return (T) new SigmobFullVideoLoader();
        }
        if (i == 20004) {
            return (T) new SigmobInterstitialLoader();
        }
        if (i == 20005) {
            return (T) new SigmobNativeLoader();
        }
        if (i == 20006) {
            return (T) new SigmobRewardLoader();
        }
        if (i == 20007) {
            return (T) new SigmobSplashLoader();
        }
        return null;
    }

    @Override // com.bytedance.msdk.adapter.sigmob.base.proto.AdnAdapterBaseFunction
    public SparseArray<Object> get() {
        return null;
    }
}

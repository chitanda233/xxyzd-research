package com.bytedance.msdk.adapter.sigmob;

import com.bytedance.msdk.adapter.sigmob.base.MediationAdLoaderBaseFunction;

/* JADX INFO: loaded from: classes2.dex */
public abstract class SigmobBaseLoader extends MediationAdLoaderBaseFunction {
    public boolean isMuted() {
        return this.mSlotValueSet != null && this.mSlotValueSet.isMuted();
    }
}

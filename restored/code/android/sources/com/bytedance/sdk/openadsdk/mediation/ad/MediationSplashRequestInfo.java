package com.bytedance.sdk.openadsdk.mediation.ad;

import com.byazt.zqa.c;

/* JADX INFO: loaded from: classes2.dex */
@c(c = {0, 80, 81, 82, 83, 686, 687})
public abstract class MediationSplashRequestInfo implements IMediationSplashRequestInfo {
    private String c;
    private String tt;
    private String uj;
    private String ve;

    public MediationSplashRequestInfo(String str, String str2, String str3, String str4) {
        this.c = str;
        this.tt = str2;
        this.ve = str3;
        this.uj = str4;
    }

    @Override // com.bytedance.sdk.openadsdk.mediation.ad.IMediationSplashRequestInfo
    public String getAdnName() {
        return this.c;
    }

    @Override // com.bytedance.sdk.openadsdk.mediation.ad.IMediationSplashRequestInfo
    public String getAdnSlotId() {
        return this.tt;
    }

    @Override // com.bytedance.sdk.openadsdk.mediation.ad.IMediationSplashRequestInfo
    public String getAppId() {
        return this.ve;
    }

    @Override // com.bytedance.sdk.openadsdk.mediation.ad.IMediationSplashRequestInfo
    public String getAppkey() {
        return this.uj;
    }
}

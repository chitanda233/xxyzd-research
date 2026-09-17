package com.bytedance.android;

import com.bytedance.sdk.openadsdk.mediation.init.IMediationPrivacyConfig;
import java.util.List;

/* JADX INFO: loaded from: classes2.dex */
public class MediationPrivacyConfig implements IMediationPrivacyConfig {
    private List<String> customAppList;
    private List<String> customDevImeis;
    private boolean canUseOaid = true;
    private boolean limitPersonalAds = false;
    private boolean programmaticRecommend = true;

    public void setCustomAppList(List<String> list) {
        this.customAppList = list;
    }

    public void setCustomDevImeis(List<String> list) {
        this.customDevImeis = list;
    }

    public void setCanUseOaid(boolean z) {
        this.canUseOaid = z;
    }

    public void setLimitPersonalAds(boolean z) {
        this.limitPersonalAds = z;
    }

    public void setProgrammaticRecommend(boolean z) {
        this.programmaticRecommend = z;
    }

    @Override // com.bytedance.sdk.openadsdk.mediation.init.IMediationPrivacyConfig
    public List<String> getCustomAppList() {
        return this.customAppList;
    }

    @Override // com.bytedance.sdk.openadsdk.mediation.init.IMediationPrivacyConfig
    public List<String> getCustomDevImeis() {
        return this.customDevImeis;
    }

    @Override // com.bytedance.sdk.openadsdk.mediation.init.IMediationPrivacyConfig
    public boolean isCanUseOaid() {
        return this.canUseOaid;
    }

    @Override // com.bytedance.sdk.openadsdk.mediation.init.IMediationPrivacyConfig
    public boolean isLimitPersonalAds() {
        return this.limitPersonalAds;
    }

    @Override // com.bytedance.sdk.openadsdk.mediation.init.IMediationPrivacyConfig
    public boolean isProgrammaticRecommend() {
        return this.programmaticRecommend;
    }
}

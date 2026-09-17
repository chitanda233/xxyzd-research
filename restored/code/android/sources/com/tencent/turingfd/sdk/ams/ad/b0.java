package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public final class b0 implements RiskDetectResp {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ Lichee f3913a;

    public b0(Lichee lichee) {
        this.f3913a = lichee;
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.RiskDetectResp
    public final String getDeviceToken() {
        return this.f3913a.b;
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.RiskDetectResp
    public final long getErrorCode() {
        return this.f3913a.f3860a;
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.RiskDetectResp
    public final long getStagePackTimeMillis() {
        this.f3913a.getClass();
        return 0L;
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.RiskDetectResp
    public final long getStageReqTimeMillis() {
        this.f3913a.getClass();
        return 0L;
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.RiskDetectResp
    public final boolean isDowngrade() {
        this.f3913a.getClass();
        return false;
    }
}

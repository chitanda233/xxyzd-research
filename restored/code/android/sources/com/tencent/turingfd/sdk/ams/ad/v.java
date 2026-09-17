package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public final class v implements ITuringDID {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ h f3969a;

    public v(h hVar) {
        this.f3969a = hVar;
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.ITuringDID
    public final String getAIDCode() {
        return this.f3969a.g;
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.ITuringDID
    public final String getAIDTicket() {
        return this.f3969a.f;
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.ITuringDID
    public final int getErrorCode() {
        return this.f3969a.c;
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.ITuringDID
    public final long getExpiredTimestamp() {
        return this.f3969a.b;
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.ITuringDID
    public final String getOpenIdTicket() {
        return this.f3969a.f3932a;
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.ITuringDID
    public final String getTAIDTicket() {
        return this.f3969a.e;
    }
}

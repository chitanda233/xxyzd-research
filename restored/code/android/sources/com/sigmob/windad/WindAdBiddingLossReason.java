package com.sigmob.windad;

/* JADX INFO: loaded from: classes4.dex */
public enum WindAdBiddingLossReason {
    LOSS_REASON_LOW_PRICE(2, "出价过低"),
    LOSS_REASON_RETURN_TIMEOUT(2000, "返回超时"),
    LOSS_REASON_RETURN_ERROR(2001, "广告素材格式错误");


    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final int f3701a;
    private final String message;

    WindAdBiddingLossReason(int code, String message) {
        this.f3701a = code;
        this.message = message;
    }

    public int getCode() {
        return this.f3701a;
    }

    public String getMessage() {
        return this.message;
    }
}

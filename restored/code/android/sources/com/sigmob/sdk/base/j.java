package com.sigmob.sdk.base;

/* JADX INFO: loaded from: classes3.dex */
public enum j {
    AppSWith(1),
    AutoNextPreload(2),
    NormalRequest(3),
    SplashCloseRequest(5),
    ReloadAfterExpiration(6),
    ActiveFailureReload(7),
    OtherRequest(999);

    private final int h;

    j(int type) {
        this.h = type;
    }

    public int a() {
        return this.h;
    }
}

package com.kwad.sdk.core.network.idc.a;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private final long aUr;
    private volatile boolean aUs = false;

    public a(long j, boolean z) {
        this.aUr = j;
    }

    public final boolean MC() {
        return this.aUs;
    }

    public final a bF(boolean z) {
        this.aUs = true;
        return this;
    }

    public final long MD() {
        return this.aUr;
    }
}

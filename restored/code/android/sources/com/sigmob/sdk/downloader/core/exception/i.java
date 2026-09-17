package com.sigmob.sdk.downloader.core.exception;

import java.io.IOException;

/* JADX INFO: loaded from: classes3.dex */
public class i extends IOException {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final int f3433a;

    public i(int responseCode, long currentOffset) {
        super("Response code can't handled on internal " + responseCode + " with current offset " + currentOffset);
        this.f3433a = responseCode;
    }

    public int a() {
        return this.f3433a;
    }
}

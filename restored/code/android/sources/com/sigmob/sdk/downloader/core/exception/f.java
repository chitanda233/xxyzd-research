package com.sigmob.sdk.downloader.core.exception;

import java.io.IOException;

/* JADX INFO: loaded from: classes3.dex */
public class f extends IOException {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final com.sigmob.sdk.downloader.core.cause.b f3432a;

    public f(com.sigmob.sdk.downloader.core.cause.b cause) {
        super("Resume failed because of " + cause);
        this.f3432a = cause;
    }

    public com.sigmob.sdk.downloader.core.cause.b a() {
        return this.f3432a;
    }
}

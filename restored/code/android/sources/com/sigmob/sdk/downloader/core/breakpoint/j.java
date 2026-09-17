package com.sigmob.sdk.downloader.core.breakpoint;

import java.io.IOException;

/* JADX INFO: loaded from: classes3.dex */
public interface j extends g {
    void a(int id, com.sigmob.sdk.downloader.core.cause.a cause, Exception exception);

    void a(c info, int blockIndex, long increaseLength) throws IOException;

    void d(int id);

    c e(int id);

    boolean f(int id);

    boolean g(int id);
}

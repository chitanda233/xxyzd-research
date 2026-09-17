package com.sigmob.sdk.downloader.core.exception;

import java.io.IOException;

/* JADX INFO: loaded from: classes3.dex */
public class e extends IOException {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final long f3431a;
    private final long b;

    public e(long requireSpace, long freeSpace) {
        super("There is Free space less than Require space: " + freeSpace + " < " + requireSpace);
        this.f3431a = requireSpace;
        this.b = freeSpace;
    }

    public long a() {
        return this.f3431a;
    }

    public long b() {
        return this.b;
    }
}

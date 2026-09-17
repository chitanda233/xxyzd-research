package com.sigmob.sdk.videocache.file;

import java.io.File;

/* JADX INFO: loaded from: classes4.dex */
public class g extends e {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final int f3665a;

    public g(int maxCount) {
        if (maxCount <= 0) {
            throw new IllegalArgumentException("Max count must be positive number!");
        }
        this.f3665a = maxCount;
    }

    @Override // com.sigmob.sdk.videocache.file.e
    protected boolean a(File file, long totalSize, int totalCount) {
        return totalCount <= this.f3665a;
    }
}

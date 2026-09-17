package com.sigmob.sdk.videocache;

import java.io.File;

/* JADX INFO: loaded from: classes4.dex */
public class e {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final File f3659a;
    public final com.sigmob.sdk.videocache.file.c b;
    public final com.sigmob.sdk.videocache.file.a c;
    public final com.sigmob.sdk.videocache.sourcestorage.c d;
    public final com.sigmob.sdk.videocache.headers.b e;

    e(File cacheRoot, com.sigmob.sdk.videocache.file.c fileNameGenerator, com.sigmob.sdk.videocache.file.a diskUsage, com.sigmob.sdk.videocache.sourcestorage.c sourceInfoStorage, com.sigmob.sdk.videocache.headers.b headerInjector) {
        this.f3659a = cacheRoot;
        this.b = fileNameGenerator;
        this.c = diskUsage;
        this.d = sourceInfoStorage;
        this.e = headerInjector;
    }

    File a(String url) {
        return new File(this.f3659a, this.b.a(url));
    }
}

package com.byazt.yj;

import java.io.File;

/* JADX INFO: loaded from: classes2.dex */
public interface tt {
    File getCacheDir();

    long getFileCacheSize();

    int getMemoryCacheSize();

    int getRawMemoryCacheSize();

    boolean isDiskCache();

    boolean isMemoryCache();

    boolean isQueryAll();

    boolean isRawMemoryCache();
}

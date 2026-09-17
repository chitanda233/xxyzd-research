package com.byazt.fk;

/* JADX INFO: loaded from: classes.dex */
public interface c {
    void clearCache();

    String getBrandCacheDir();

    long getCachedSize(u uVar);

    String getOtherCacheDir();

    String getRewardFullCacheDir();

    String getSplashCacheDir();

    boolean isVideoCached(u uVar);

    void setRootDir(String str);
}

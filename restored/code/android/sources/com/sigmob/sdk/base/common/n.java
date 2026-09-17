package com.sigmob.sdk.base.common;

/* JADX INFO: loaded from: classes3.dex */
public enum n {
    CreativeTypeVideo_Tar(1),
    CreativeTypeImage(3),
    CreativeTypeVideo_Html_Snippet(4),
    CreativeTypeVideo_Tar_Companion(5),
    CreativeTypeVideo_transparent_html(6),
    CreativeTypeVideo_EndCardURL(7),
    CreativeTypeSplashVideo(8),
    CreativeTypeMRAID(9),
    CreativeTypeMRAIDTWO(10),
    CreativeTypeNewInterstitial(16);

    private final int k;

    n(int type) {
        this.k = type;
    }

    public int a() {
        return this.k;
    }
}

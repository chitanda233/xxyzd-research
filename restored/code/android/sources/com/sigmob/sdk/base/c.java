package com.sigmob.sdk.base;

/* JADX INFO: loaded from: classes3.dex */
public enum c {
    ImageTypeUnknow(0),
    ImageTypeJPEG(1),
    ImageTypePNG(2),
    ImageTypeGIF(3),
    SMImageTypeWEBP(4),
    ImageTypeMP4(5);

    private final int g;

    c(int type) {
        this.g = type;
    }

    public int a() {
        return this.g;
    }
}

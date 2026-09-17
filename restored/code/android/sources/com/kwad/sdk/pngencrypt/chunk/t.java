package com.kwad.sdk.pngencrypt.chunk;

/* JADX INFO: loaded from: classes3.dex */
public abstract class t extends k {
    protected String bmp;
    protected String key;

    protected t(String str, com.kwad.sdk.pngencrypt.k kVar) {
        super(str, kVar);
    }

    public final String getKey() {
        return this.key;
    }

    public final String TJ() {
        return this.bmp;
    }
}

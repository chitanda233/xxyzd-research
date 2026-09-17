package com.kwad.sdk.core.videocache;

/* JADX INFO: loaded from: classes3.dex */
public final class n {
    public final long baB;
    public final String baC;
    public final String url;

    public n(String str, long j, String str2) {
        this.url = str;
        this.baB = j;
        this.baC = str2;
    }

    public final String toString() {
        return "SourceInfo{url='" + this.url + "', length=" + this.baB + ", mime='" + this.baC + "'}";
    }
}

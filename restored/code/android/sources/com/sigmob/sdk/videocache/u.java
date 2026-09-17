package com.sigmob.sdk.videocache;

/* JADX INFO: loaded from: classes4.dex */
public class u {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final String f3681a;
    public final long b;
    public final String c;

    public u(String url, long length, String mime) {
        this.f3681a = url;
        this.b = length;
        this.c = mime;
    }

    public String toString() {
        return "SourceInfo{url='" + this.f3681a + "', length=" + this.b + ", mime='" + this.c + "'}";
    }
}

package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public final class Pistachio {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final byte[] f3878a;
    public final String b;
    public final String c;
    public final int d;

    public Pistachio(byte[] bArr, String str, String str2, int i) {
        this.f3878a = bArr;
        this.b = str;
        this.c = str2;
        this.d = i;
    }

    public final String toString() {
        return "symmetricAlgorithm : 1 randomKey : " + this.b + " sessionId : " + this.c + " expireTime : " + this.d;
    }
}

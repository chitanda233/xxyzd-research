package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public final class w {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final w f3970a = new w();

    public static a0 a(int i, byte[] bArr, int i2, int i3, r rVar) {
        h0 h0VarA;
        White white = (White) White.c.b();
        synchronized (white) {
            h0VarA = white.a(i2, i3, i, bArr, rVar);
        }
        int i4 = h0VarA.f3933a;
        if (i4 == 0) {
            return new a0(0, h0VarA.d, 0, 0);
        }
        return new a0(i4 - 40000, a0.e, h0VarA.b, h0VarA.c);
    }
}

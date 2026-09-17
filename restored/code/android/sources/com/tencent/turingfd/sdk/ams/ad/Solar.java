package com.tencent.turingfd.sdk.ams.ad;

import java.security.spec.AlgorithmParameterSpec;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Solar {
    public abstract Solar a(String... strArr);

    public abstract AlgorithmParameterSpec a();

    public abstract Solar b(String... strArr);

    public static Solar a(String str, int i) {
        return new Sculptor(str, i);
    }
}

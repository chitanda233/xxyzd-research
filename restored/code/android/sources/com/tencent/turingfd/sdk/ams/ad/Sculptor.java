package com.tencent.turingfd.sdk.ams.ad;

import android.security.keystore.KeyGenParameterSpec;
import java.security.spec.AlgorithmParameterSpec;

/* JADX INFO: loaded from: classes4.dex */
public final class Sculptor extends Solar {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final KeyGenParameterSpec.Builder f3888a;

    public Sculptor(String str, int i) {
        this.f3888a = null;
        this.f3888a = new KeyGenParameterSpec.Builder(str, i);
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Solar
    public final AlgorithmParameterSpec a() {
        return this.f3888a.build();
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Solar
    public final Solar b(String... strArr) {
        this.f3888a.setSignaturePaddings(strArr);
        return this;
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Solar
    public final Solar a(String... strArr) {
        this.f3888a.setDigests(strArr);
        return this;
    }
}

package com.tencent.turingfd.sdk.ams.ad;

import java.math.BigInteger;
import java.security.spec.AlgorithmParameterSpec;
import javax.security.auth.x500.X500Principal;

/* JADX INFO: loaded from: classes4.dex */
public final class Serpens extends Solar {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final String f3891a;
    public final int b;
    public String[] c;
    public String[] d;

    public Serpens(String str, int i) {
        if (str == null) {
            throw new NullPointerException("keystoreAlias == null");
        }
        if (str.isEmpty()) {
            throw new IllegalArgumentException("keystoreAlias must not be empty");
        }
        this.f3891a = str;
        this.b = i;
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Solar
    public final AlgorithmParameterSpec a() throws ClassNotFoundException {
        Class<?> cls = Class.forName("android.security.keystore.KeyGenParameterSpec");
        Class<?> cls2 = Integer.TYPE;
        Class<?> cls3 = Boolean.TYPE;
        return (AlgorithmParameterSpec) cls.getConstructor(String.class, cls2, AlgorithmParameterSpec.class, X500Principal.class, BigInteger.class, java.util.Date.class, java.util.Date.class, java.util.Date.class, java.util.Date.class, java.util.Date.class, cls2, String[].class, String[].class, String[].class, String[].class, cls3, cls3, cls2).newInstance(this.f3891a, -1, null, null, null, null, null, null, null, null, Integer.valueOf(this.b), this.c, null, this.d, null, Boolean.TRUE, Boolean.FALSE, -1);
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Solar
    public final Solar b(String... strArr) {
        if (strArr.length > 0) {
            strArr = (String[]) strArr.clone();
        }
        this.d = strArr;
        return this;
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Solar
    public final Solar a(String... strArr) {
        if (strArr.length > 0) {
            strArr = (String[]) strArr.clone();
        }
        this.c = strArr;
        return this;
    }
}

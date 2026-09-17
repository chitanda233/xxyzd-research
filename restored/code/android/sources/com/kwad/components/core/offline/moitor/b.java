package com.kwad.components.core.offline.moitor;

/* JADX INFO: loaded from: classes3.dex */
public class b extends com.kwad.sdk.commercial.c.a {
    public String acZ;
    public long ada;
    public long adb;
    public long adc;
    public String add;

    public final b aQ(String str) {
        this.acZ = str;
        return this;
    }

    public final b H(long j) {
        this.ada = j;
        return this;
    }

    public final b I(long j) {
        this.adb = j;
        return this;
    }

    public final b bi(int i) {
        this.adc = i;
        return this;
    }

    @Override // com.kwad.sdk.commercial.c.a
    /* JADX INFO: renamed from: bj, reason: merged with bridge method [inline-methods] */
    public final b setErrorCode(int i) {
        this.errorCode = i;
        return this;
    }

    public final b aR(String str) {
        this.errorMsg = str;
        return this;
    }

    public final b aS(String str) {
        this.add = str;
        return this;
    }
}

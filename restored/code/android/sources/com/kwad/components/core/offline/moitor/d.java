package com.kwad.components.core.offline.moitor;

/* JADX INFO: loaded from: classes3.dex */
public class d extends com.kwad.sdk.commercial.c.a {
    public String acZ;
    public long ada;
    public long adb;
    public String add;
    public long ade;

    public final d aT(String str) {
        this.acZ = str;
        return this;
    }

    public final d J(long j) {
        this.ada = j;
        return this;
    }

    public final d K(long j) {
        this.adb = j;
        return this;
    }

    public final d L(long j) {
        this.ade = j;
        return this;
    }

    @Override // com.kwad.sdk.commercial.c.a
    /* JADX INFO: renamed from: bk, reason: merged with bridge method [inline-methods] */
    public final d setErrorCode(int i) {
        this.errorCode = i;
        return this;
    }

    public final d aU(String str) {
        this.errorMsg = str;
        return this;
    }

    public final d aV(String str) {
        this.add = str;
        return this;
    }
}

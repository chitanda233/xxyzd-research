package com.baidu.mobads.sdk.internal;

/* JADX INFO: loaded from: classes.dex */
class ch implements an.b {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ double f464a;
    final /* synthetic */ cb b;

    ch(cb cbVar, double d) {
        this.b = cbVar;
        this.f464a = d;
    }

    @Override // com.baidu.mobads.sdk.internal.an.b
    public void a(String str, String str2) {
        this.b.w = new bz(str);
        double dB = co.b();
        float f = this.b.m().getFloat(cb.c, 0.0f);
        Boolean boolValueOf = Boolean.valueOf(((float) this.b.w.b()) == f);
        Boolean boolValueOf2 = Boolean.valueOf(dB <= this.b.w.b() && Math.floor(dB) == Math.floor(this.b.w.b()));
        this.b.z.a(cb.f459a, "try to download apk badVer=" + f + ", isBad=" + boolValueOf + ", compatible=" + boolValueOf2);
        if (this.f464a >= this.b.w.b() || this.b.w == null || !this.b.w.a().booleanValue() || !boolValueOf2.booleanValue() || boolValueOf.booleanValue()) {
            if (this.b.A) {
                this.b.A = false;
                this.b.a(false, "Refused to download remote for version...");
                return;
            }
            return;
        }
        cb cbVar = this.b;
        cbVar.a(cbVar.w);
    }

    @Override // com.baidu.mobads.sdk.internal.an.b
    public void a(String str, int i) {
        if (this.b.A) {
            this.b.A = false;
            this.b.a(false, "remote update Network access failed");
        }
    }
}

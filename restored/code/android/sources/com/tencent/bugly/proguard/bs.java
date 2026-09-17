package com.tencent.bugly.proguard;

/* JADX INFO: compiled from: BUGLY */
/* JADX INFO: loaded from: classes4.dex */
public final class bs extends m implements Cloneable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public String f3787a = "";
    public String b = "";

    @Override // com.tencent.bugly.proguard.m
    public final void a(StringBuilder sb, int i) {
    }

    @Override // com.tencent.bugly.proguard.m
    public final void a(l lVar) {
        lVar.a(this.f3787a, 0);
        lVar.a(this.b, 1);
    }

    @Override // com.tencent.bugly.proguard.m
    public final void a(k kVar) {
        this.f3787a = kVar.b(0, true);
        this.b = kVar.b(1, true);
    }
}

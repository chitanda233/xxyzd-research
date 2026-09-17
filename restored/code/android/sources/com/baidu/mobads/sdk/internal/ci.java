package com.baidu.mobads.sdk.internal;

/* JADX INFO: loaded from: classes.dex */
class ci implements ao.a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ cb f465a;

    ci(cb cbVar) {
        this.f465a = cbVar;
    }

    @Override // com.baidu.mobads.sdk.internal.ao.a
    public void a() {
        if (this.f465a.A) {
            this.f465a.A = false;
            this.f465a.a(false, "remote update Network access failed");
        }
    }
}

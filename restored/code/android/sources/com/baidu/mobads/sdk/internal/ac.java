package com.baidu.mobads.sdk.internal;

/* JADX INFO: loaded from: classes.dex */
class ac implements cb.c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ aa f406a;

    ac(aa aaVar) {
        this.f406a = aaVar;
    }

    @Override // com.baidu.mobads.sdk.internal.cb.c
    public void a(boolean z) {
        if (z) {
            try {
                if (h.f507a != null) {
                    this.f406a.b = h.f507a.i();
                    if (this.f406a.b != null) {
                        this.f406a.k();
                        return;
                    }
                }
            } catch (Exception unused) {
                this.f406a.a("加载dex异常");
                return;
            }
        }
        h.f507a = null;
        this.f406a.a("加载dex失败");
    }
}

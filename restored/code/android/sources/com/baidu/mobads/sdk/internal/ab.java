package com.baidu.mobads.sdk.internal;

/* JADX INFO: loaded from: classes.dex */
class ab implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ aa f405a;

    ab(aa aaVar) {
        this.f405a = aaVar;
    }

    @Override // java.lang.Runnable
    public void run() {
        this.f405a.a("加载dex超过5秒");
    }
}

package com.baidu.mobads.sdk.internal;

/* JADX INFO: loaded from: classes.dex */
class bl implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ Runnable f442a;

    bl(Runnable runnable) {
        this.f442a = runnable;
    }

    @Override // java.lang.Runnable
    public void run() {
        this.f442a.run();
    }
}

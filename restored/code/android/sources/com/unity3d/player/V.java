package com.unity3d.player;

/* JADX INFO: loaded from: classes4.dex */
final class V implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ X f4018a;

    V(X x) {
        this.f4018a = x;
    }

    @Override // java.lang.Runnable
    public final void run() {
        this.f4018a.c.requestFocus();
        this.f4018a.f();
    }
}

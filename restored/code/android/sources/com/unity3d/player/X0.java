package com.unity3d.player;

/* JADX INFO: loaded from: classes4.dex */
final class X0 implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ a1 f4022a;

    X0(a1 a1Var) {
        this.f4022a = a1Var;
    }

    @Override // java.lang.Runnable
    public final void run() {
        this.f4022a.destroyPlayer();
        this.f4022a.a(3);
    }
}

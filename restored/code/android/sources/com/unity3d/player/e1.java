package com.unity3d.player;

/* JADX INFO: loaded from: classes4.dex */
final class e1 implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ i1 f4037a;

    e1(i1 i1Var) {
        this.f4037a = i1Var;
    }

    @Override // java.lang.Runnable
    public final void run() {
        this.f4037a.f4048a.onPause();
    }
}

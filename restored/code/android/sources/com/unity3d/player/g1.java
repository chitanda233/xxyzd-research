package com.unity3d.player;

/* JADX INFO: loaded from: classes4.dex */
final class g1 implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ i1 f4043a;

    g1(i1 i1Var) {
        this.f4043a = i1Var;
    }

    @Override // java.lang.Runnable
    public final void run() {
        i1 i1Var = this.f4043a;
        a1 a1Var = i1Var.f;
        if (a1Var != null) {
            i1Var.f4048a.removeViewFromPlayer(a1Var);
            i1Var.i = false;
            i1Var.f.destroyPlayer();
            i1Var.f = null;
            h1 h1Var = i1Var.c;
            if (h1Var != null) {
                ((A0) h1Var).a();
            }
        }
        this.f4043a.f4048a.onResume();
    }
}

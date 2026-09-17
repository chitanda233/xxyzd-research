package com.unity3d.player;

/* JADX INFO: loaded from: classes4.dex */
final class c1 implements Y0 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ d1 f4033a;

    c1(d1 d1Var) {
        this.f4033a = d1Var;
    }

    public final void a(int i) {
        this.f4033a.h.e.lock();
        i1 i1Var = this.f4033a.h;
        i1Var.g = i;
        if (i == 3 && i1Var.i) {
            i1Var.runOnUiThread(new b1(this));
        }
        if (i != 0) {
            this.f4033a.h.d.release();
        }
        this.f4033a.h.e.unlock();
    }
}

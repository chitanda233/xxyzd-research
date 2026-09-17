package com.unity3d.player;

/* JADX INFO: renamed from: com.unity3d.player.p0, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes4.dex */
final class C0732p0 implements G {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ RunnableC0734q0 f4061a;

    C0732p0(RunnableC0734q0 runnableC0734q0) {
        this.f4061a = runnableC0734q0;
    }

    public final void a() {
        RunnableC0734q0 runnableC0734q0 = this.f4061a;
        runnableC0734q0.f4063a = true;
        if (runnableC0734q0.b) {
            runnableC0734q0.c.release();
        }
    }
}

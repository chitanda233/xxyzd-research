package com.unity3d.player;

/* JADX INFO: renamed from: com.unity3d.player.t0, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes4.dex */
final class RunnableC0740t0 implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ boolean f4069a;
    final /* synthetic */ UnityPlayer b;

    RunnableC0740t0(UnityPlayer unityPlayer, boolean z) {
        this.b = unityPlayer;
        this.f4069a = z;
    }

    @Override // java.lang.Runnable
    public final void run() {
        S s = this.b.mSoftInput;
        if (s != null) {
            s.a(this.f4069a);
        }
    }
}

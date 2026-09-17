package com.unity3d.player;

/* JADX INFO: renamed from: com.unity3d.player.n0, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes4.dex */
final class RunnableC0728n0 implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ UnityPlayer f4058a;

    RunnableC0728n0(UnityPlayer unityPlayer) {
        this.f4058a = unityPlayer;
    }

    @Override // java.lang.Runnable
    public final void run() {
        C0718i0 c0718i0 = this.f4058a.mGlView;
        if (c0718i0 != null) {
            c0718i0.b();
        }
    }
}

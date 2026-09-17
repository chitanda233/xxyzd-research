package com.unity3d.player;

/* JADX INFO: renamed from: com.unity3d.player.j0, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes4.dex */
final class RunnableC0720j0 implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ UnityPlayer f4050a;

    RunnableC0720j0(UnityPlayer unityPlayer) {
        this.f4050a = unityPlayer;
    }

    @Override // java.lang.Runnable
    public final void run() {
        this.f4050a.nativeLowMemory();
    }
}

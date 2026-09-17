package com.unity3d.player;

/* JADX INFO: renamed from: com.unity3d.player.k0, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes4.dex */
final class RunnableC0722k0 implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ UnityPlayer f4052a;

    RunnableC0722k0(UnityPlayer unityPlayer) {
        this.f4052a = unityPlayer;
    }

    @Override // java.lang.Runnable
    public final void run() {
        this.f4052a.nativeResume();
    }
}

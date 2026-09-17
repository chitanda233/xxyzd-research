package com.unity3d.player;

/* JADX INFO: loaded from: classes4.dex */
final class C0 implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ UnityPlayer f3980a;

    C0(UnityPlayer unityPlayer) {
        this.f3980a = unityPlayer;
    }

    @Override // java.lang.Runnable
    public final void run() {
        this.f3980a.setupUnityToBePaused();
        this.f3980a.windowFocusChanged(false);
        this.f3980a.m_UnityPlayerLifecycleEvents.onUnityPlayerUnloaded();
    }
}

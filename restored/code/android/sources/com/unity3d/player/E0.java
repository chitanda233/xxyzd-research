package com.unity3d.player;

/* JADX INFO: loaded from: classes4.dex */
final class E0 implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ float f3983a;
    final /* synthetic */ UnityPlayer b;

    E0(UnityPlayer unityPlayer, float f) {
        this.b = unityPlayer;
        this.f3983a = f;
    }

    @Override // java.lang.Runnable
    public final void run() {
        this.b.mGlView.a(this.f3983a);
    }
}

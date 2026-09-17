package com.unity3d.player;

/* JADX INFO: loaded from: classes4.dex */
final class T implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ U f4014a;

    T(U u) {
        this.f4014a = u;
    }

    @Override // java.lang.Runnable
    public final void run() {
        S s = this.f4014a.d;
        s.a(s.b(), true);
    }
}

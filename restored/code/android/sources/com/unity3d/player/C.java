package com.unity3d.player;

/* JADX INFO: loaded from: classes4.dex */
class C {
    protected Runnable b;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    protected com.unity3d.player.a.c f3979a = null;
    protected boolean c = true;

    protected C(Runnable runnable) {
        this.b = runnable;
    }

    protected void registerOnBackPressedCallback() {
        if (this.f3979a != null) {
            return;
        }
        this.f3979a = new B(this.b);
    }

    protected void unregisterOnBackPressedCallback() {
        this.f3979a = null;
    }
}

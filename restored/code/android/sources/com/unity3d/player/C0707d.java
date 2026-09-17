package com.unity3d.player;

import android.window.OnBackInvokedCallback;

/* JADX INFO: renamed from: com.unity3d.player.d, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes4.dex */
final class C0707d implements OnBackInvokedCallback {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ com.unity3d.player.a.c f4034a;

    C0707d(com.unity3d.player.a.c cVar) {
        this.f4034a = cVar;
    }

    @Override // android.window.OnBackInvokedCallback
    public final void onBackInvoked() {
        Runnable runnable = ((B) this.f4034a).f3977a;
        if (runnable != null) {
            runnable.run();
        }
    }
}

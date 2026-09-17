package com.unity3d.player;

import android.graphics.Rect;
import java.util.concurrent.Semaphore;

/* JADX INFO: renamed from: com.unity3d.player.q0, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes4.dex */
final class RunnableC0734q0 implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    boolean f4063a = false;
    boolean b = false;
    final /* synthetic */ Semaphore c;
    final /* synthetic */ UnityPlayer d;
    final /* synthetic */ UnityPlayer e;

    RunnableC0734q0(UnityPlayer unityPlayer, Semaphore semaphore, UnityPlayer unityPlayer2) {
        this.e = unityPlayer;
        this.c = semaphore;
        this.d = unityPlayer2;
    }

    @Override // java.lang.Runnable
    public final void run() {
        this.e.reportSoftInputArea(new Rect());
        this.e.reportSoftInputIsVisible(false);
        if (this.e.mSoftInput != null) {
            this.d.setOnHandleFocusListener(new C0730o0(this));
            UnityPlayer unityPlayer = this.e;
            unityPlayer.mSoftInput.g = new C0732p0(this);
            unityPlayer.dismissSoftInput();
        }
    }
}

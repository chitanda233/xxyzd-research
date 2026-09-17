package com.unity3d.player;

import android.view.SurfaceHolder;

/* JADX INFO: renamed from: com.unity3d.player.h0, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes4.dex */
final class SurfaceHolderCallbackC0716h0 implements SurfaceHolder.Callback {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ C0718i0 f4045a;

    SurfaceHolderCallbackC0716h0(C0718i0 c0718i0) {
        this.f4045a = c0718i0;
    }

    @Override // android.view.SurfaceHolder.Callback
    public final void surfaceChanged(SurfaceHolder surfaceHolder, int i, int i2, int i3) {
        this.f4045a.b.updateGLDisplay(0, surfaceHolder.getSurface());
        this.f4045a.b.sendSurfaceChangedEvent();
    }

    @Override // android.view.SurfaceHolder.Callback
    public final void surfaceCreated(SurfaceHolder surfaceHolder) {
        this.f4045a.b.updateGLDisplay(0, surfaceHolder.getSurface());
        C0718i0 c0718i0 = this.f4045a;
        K k = c0718i0.c;
        UnityPlayer unityPlayer = c0718i0.b;
        J j = k.b;
        if (j == null || j.getParent() != null) {
            return;
        }
        unityPlayer.addView(k.b);
        unityPlayer.bringChildToFront(k.b);
    }

    @Override // android.view.SurfaceHolder.Callback
    public final void surfaceDestroyed(SurfaceHolder surfaceHolder) {
        C0718i0 c0718i0 = this.f4045a;
        K k = c0718i0.c;
        C0711f c0711f = c0718i0.f4047a;
        k.getClass();
        if (PlatformSupport.NOUGAT_SUPPORT && k.f3993a != null) {
            if (k.b == null) {
                k.b = new J(k.f3993a);
            }
            k.b.a(c0711f);
        }
        this.f4045a.b.updateGLDisplay(0, null);
    }
}

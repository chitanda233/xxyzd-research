package com.unity3d.player;

import android.hardware.camera2.CameraDevice;

/* JADX INFO: renamed from: com.unity3d.player.t, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes4.dex */
final class C0739t extends CameraDevice.StateCallback {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ C0745w f4068a;

    C0739t(C0745w c0745w) {
        this.f4068a = c0745w;
    }

    @Override // android.hardware.camera2.CameraDevice.StateCallback
    public final void onClosed(CameraDevice cameraDevice) {
        C0745w.D.release();
    }

    @Override // android.hardware.camera2.CameraDevice.StateCallback
    public final void onDisconnected(CameraDevice cameraDevice) {
        AbstractC0751z.Log(5, "Camera2: CameraDevice disconnected.");
        this.f4068a.a(cameraDevice);
        C0745w.D.release();
    }

    @Override // android.hardware.camera2.CameraDevice.StateCallback
    public final void onError(CameraDevice cameraDevice, int i) {
        AbstractC0751z.Log(6, "Camera2: Error opeining CameraDevice " + i);
        this.f4068a.a(cameraDevice);
        C0745w.D.release();
    }

    @Override // android.hardware.camera2.CameraDevice.StateCallback
    public final void onOpened(CameraDevice cameraDevice) {
        this.f4068a.b = cameraDevice;
        C0745w.D.release();
    }
}

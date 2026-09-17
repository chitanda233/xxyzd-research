package com.unity3d.player;

import android.hardware.camera2.CameraAccessException;
import android.hardware.camera2.CameraCaptureSession;
import android.hardware.camera2.CaptureRequest;

/* JADX INFO: renamed from: com.unity3d.player.s, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes4.dex */
final class C0737s extends CameraCaptureSession.StateCallback {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ C0745w f4066a;

    C0737s(C0745w c0745w) {
        this.f4066a = c0745w;
    }

    @Override // android.hardware.camera2.CameraCaptureSession.StateCallback
    public final void onConfigureFailed(CameraCaptureSession cameraCaptureSession) {
        AbstractC0751z.Log(6, "Camera2: CaptureSession configuration failed.");
    }

    @Override // android.hardware.camera2.CameraCaptureSession.StateCallback
    public void onConfigured(CameraCaptureSession cameraCaptureSession) {
        StringBuilder sbAppend;
        C0745w c0745w = this.f4066a;
        if (c0745w.b == null) {
            return;
        }
        synchronized (c0745w.s) {
            C0745w c0745w2 = this.f4066a;
            c0745w2.r = cameraCaptureSession;
            try {
                try {
                    c0745w2.q = c0745w2.b.createCaptureRequest(1);
                    C0745w c0745w3 = this.f4066a;
                    c0745w3.q.addTarget(c0745w3.v);
                    C0745w c0745w4 = this.f4066a;
                    c0745w4.q.set(CaptureRequest.CONTROL_AE_TARGET_FPS_RANGE, c0745w4.n);
                    this.f4066a.g();
                } catch (IllegalStateException e) {
                    sbAppend = new StringBuilder("Camera2: IllegalStateException ").append(e);
                    AbstractC0751z.Log(6, sbAppend.toString());
                }
            } catch (CameraAccessException e2) {
                sbAppend = new StringBuilder("Camera2: CameraAccessException ").append(e2);
                AbstractC0751z.Log(6, sbAppend.toString());
            }
        }
    }
}

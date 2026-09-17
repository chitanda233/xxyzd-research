package com.unity3d.player;

import android.os.Build;

/* JADX INFO: loaded from: classes4.dex */
final class I implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private IPermissionRequestCallbacks f3990a;
    private String b;
    private int c;
    private boolean d;

    I(IPermissionRequestCallbacks iPermissionRequestCallbacks, String str, int i, boolean z) {
        this.f3990a = iPermissionRequestCallbacks;
        this.b = str;
        this.c = i;
        this.d = z;
    }

    @Override // java.lang.Runnable
    public final void run() {
        int i = this.c;
        if (i != -1) {
            if (i == 0) {
                this.f3990a.onPermissionGranted(this.b);
            }
        } else if (Build.VERSION.SDK_INT >= 30 || this.d) {
            this.f3990a.onPermissionDenied(this.b);
        } else {
            this.f3990a.onPermissionDeniedAndDontAskAgain(this.b);
        }
    }
}

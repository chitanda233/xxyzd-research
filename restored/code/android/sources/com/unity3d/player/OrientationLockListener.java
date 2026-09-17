package com.unity3d.player;

import android.content.Context;
import android.provider.Settings;

/* JADX INFO: loaded from: classes4.dex */
public class OrientationLockListener implements InterfaceC0708d0 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private C0712f0 f4004a;
    private Context b;

    OrientationLockListener(Context context) {
        this.b = context;
        this.f4004a = new C0712f0(context);
        nativeUpdateOrientationLockState(Settings.System.getInt(context.getContentResolver(), "accelerometer_rotation", 0));
        this.f4004a.a(this);
    }

    public final void a() {
        this.f4004a.a();
        this.f4004a = null;
    }

    public final void b() {
        nativeUpdateOrientationLockState(Settings.System.getInt(this.b.getContentResolver(), "accelerometer_rotation", 0));
    }

    public final native void nativeUpdateOrientationLockState(int i);
}

package com.unity3d.player;

import android.content.Context;
import android.os.Handler;
import android.os.Looper;
import android.provider.Settings;

/* JADX INFO: renamed from: com.unity3d.player.f0, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes4.dex */
final class C0712f0 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Context f4039a;
    private C0710e0 b;

    public C0712f0(Context context) {
        this.f4039a = context;
    }

    public final void a() {
        if (this.b != null) {
            this.f4039a.getContentResolver().unregisterContentObserver(this.b);
            this.b = null;
        }
    }

    public final void a(InterfaceC0708d0 interfaceC0708d0) {
        this.b = new C0710e0(new Handler(Looper.getMainLooper()), interfaceC0708d0);
        this.f4039a.getContentResolver().registerContentObserver(Settings.System.getUriFor("accelerometer_rotation"), true, this.b);
    }
}

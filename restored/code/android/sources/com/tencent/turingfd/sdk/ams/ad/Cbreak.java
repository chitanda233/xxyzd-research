package com.tencent.turingfd.sdk.ams.ad;

import android.app.Activity;
import android.app.Application;
import android.os.Build;
import android.os.Process;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: renamed from: com.tencent.turingfd.sdk.ams.ad.break, reason: invalid class name */
/* JADX INFO: loaded from: classes4.dex */
public final class Cbreak extends Cfor {
    public static final Cthis c = new Cthis();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final AtomicBoolean f3914a = new AtomicBoolean(false);
    public volatile boolean b = false;

    public final void a() {
        synchronized (this.f3914a) {
            if (this.f3914a.get()) {
                return;
            }
            Application applicationB = Ccatch.b();
            if (applicationB == null) {
                return;
            }
            applicationB.registerActivityLifecycleCallbacks(this);
            boolean z = true;
            this.f3914a.set(true);
            if (Build.VERSION.SDK_INT >= 34) {
                if (applicationB.checkPermission("android.permission.DETECT_SCREEN_CAPTURE", Process.myPid(), Process.myUid()) != 0) {
                    z = false;
                }
                this.b = z;
            }
        }
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public final void onActivityPaused(Activity activity) {
        if (!this.b || Build.VERSION.SDK_INT < 34) {
            return;
        }
        try {
            activity.unregisterScreenCaptureCallback((Peanut) Peanut.d.b());
        } catch (Throwable unused) {
        }
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public final void onActivityResumed(Activity activity) {
        if (!this.b || Build.VERSION.SDK_INT < 34) {
            return;
        }
        Peanut peanut = (Peanut) Peanut.d.b();
        peanut.b = activity.getClass().getName();
        try {
            activity.registerScreenCaptureCallback(Ara.b, peanut);
        } catch (Throwable unused) {
        }
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Cfor, android.app.Application.ActivityLifecycleCallbacks
    public final void onActivityStarted(Activity activity) {
    }
}

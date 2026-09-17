package com.tencent.turingfd.sdk.ams.ad;

import android.app.Activity;
import android.view.ViewTreeObserver;
import android.view.Window;
import java.lang.ref.WeakReference;
import java.util.WeakHashMap;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: renamed from: com.tencent.turingfd.sdk.ams.ad.default, reason: invalid class name */
/* JADX INFO: loaded from: classes4.dex */
public final class Cdefault extends Cfor {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final AtomicBoolean f3922a = new AtomicBoolean(false);
    public final Cstatic b;

    public Cdefault(Cstatic cstatic) {
        this.b = cstatic;
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public final void onActivityPaused(Activity activity) {
        this.f3922a.set(true);
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public final void onActivityResumed(Activity activity) {
        Window window;
        Window window2;
        if (activity != null && (window2 = activity.getWindow()) != null) {
            String name = activity.getClass().getName();
            try {
                WeakHashMap weakHashMap = Cextends.f3926a;
                if (!weakHashMap.containsKey(activity)) {
                    weakHashMap.put(activity, null);
                    Window.Callback callback = window2.getCallback();
                    if (callback != null && !(callback instanceof o0)) {
                        window2.setCallback(new o0(callback, name, this));
                    }
                    ViewTreeObserver viewTreeObserver = window2.getDecorView().getViewTreeObserver();
                    if (viewTreeObserver != null) {
                        viewTreeObserver.addOnPreDrawListener(new Cthrows(window2, this, name));
                    }
                }
            } catch (Throwable unused) {
            }
        }
        WeakHashMap weakHashMap2 = Pear.f3874a;
        if (activity != null && (window = activity.getWindow()) != null) {
            Pear.c = new WeakReference(window);
            if (Pear.b.get()) {
                Pear.b(window);
            }
        }
        this.f3922a.set(false);
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Cfor, android.app.Application.ActivityLifecycleCallbacks
    public final void onActivityStopped(Activity activity) {
        Window window;
        WeakHashMap weakHashMap = Pear.f3874a;
        if (activity == null || (window = activity.getWindow()) == null) {
            return;
        }
        Pear.a(window);
    }
}

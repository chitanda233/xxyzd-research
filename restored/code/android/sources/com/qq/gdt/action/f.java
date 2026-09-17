package com.qq.gdt.action;

import android.app.Activity;
import android.app.Application;
import android.os.Bundle;
import android.util.SparseArray;
import com.qq.gdt.action.i.o;

/* JADX INFO: loaded from: classes3.dex */
public class f implements Application.ActivityLifecycleCallbacks {
    private final d c;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private int f3066a = 0;
    private int b = 0;
    private SparseArray d = new SparseArray();

    public f(d dVar) {
        this.c = dVar;
    }

    private void a() {
        o.a("App Enter Background", new Object[0]);
        this.c.k();
    }

    private void a(Activity activity) {
        o.a("App Enter Foreground", new Object[0]);
        this.c.a(activity);
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityCreated(Activity activity, Bundle bundle) {
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityDestroyed(Activity activity) {
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityPaused(Activity activity) {
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityResumed(Activity activity) {
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivitySaveInstanceState(Activity activity, Bundle bundle) {
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityStarted(Activity activity) {
        if (this.f3066a <= 0) {
            a(activity);
        }
        int i = this.b;
        if (i < 0) {
            this.b = i + 1;
        } else {
            this.f3066a++;
        }
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityStopped(Activity activity) {
        if (activity.isChangingConfigurations()) {
            this.b--;
            return;
        }
        int i = this.f3066a - 1;
        this.f3066a = i;
        if (i <= 0) {
            a();
        }
    }
}

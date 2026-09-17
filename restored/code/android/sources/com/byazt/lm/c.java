package com.byazt.lm;

import android.app.Activity;
import android.app.Application;
import android.os.Bundle;
import java.lang.ref.WeakReference;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 1949, 20})
public class c implements Application.ActivityLifecycleCallbacks {
    public static volatile boolean c = false;
    public int tt = 0;
    public InterfaceC0179c uj;
    public volatile WeakReference<Activity> ve;

    /* JADX INFO: renamed from: com.byazt.lm.c$c, reason: collision with other inner class name */
    public interface InterfaceC0179c {
        void c();

        void tt();
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
    public void onActivitySaveInstanceState(Activity activity, Bundle bundle) {
    }

    public Boolean c() {
        return Boolean.valueOf(c);
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityStarted(Activity activity) {
        this.tt++;
        c = false;
        InterfaceC0179c interfaceC0179c = this.uj;
        if (interfaceC0179c != null) {
            interfaceC0179c.tt();
        }
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityResumed(Activity activity) {
        this.ve = new WeakReference<>(activity);
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityStopped(Activity activity) {
        int i = this.tt - 1;
        this.tt = i;
        if (i == 0) {
            c = true;
            InterfaceC0179c interfaceC0179c = this.uj;
            if (interfaceC0179c != null) {
                interfaceC0179c.c();
            }
        }
    }

    public void c(InterfaceC0179c interfaceC0179c) {
        this.uj = interfaceC0179c;
    }

    public Activity tt() {
        if (this.ve == null) {
            return null;
        }
        return this.ve.get();
    }
}

package com.byazt.g;

import android.app.Activity;
import android.app.Application;
import android.content.Context;
import android.os.Bundle;
import android.text.TextUtils;
import com.byazt.hv.TTDownloadField;
import com.byazt.nr.m;
import com.byazt.w.a;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.lang.ref.WeakReference;
import java.util.ArrayList;
import java.util.List;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 954, 20})
public class c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public volatile int f927a;
    public Application c;
    public WeakReference<Activity> n;
    public volatile boolean sp;
    public ve tt;
    public int uj;
    public final List<InterfaceC0125c> ve;
    public final Application.ActivityLifecycleCallbacks x;

    /* JADX INFO: renamed from: com.byazt.g.c$c, reason: collision with other inner class name */
    public interface InterfaceC0125c {
        void tt();

        void ve();
    }

    public interface ve {
    }

    public static c c() {
        return tt.c;
    }

    @com.byazt.zqa.c(c = {0, 1, 954, MediaPlayer.MEDIA_PLAYER_OPTION_ABR_AVERAGE_PLAY_SPEED})
    private static class tt {
        public static final c c = new c();
    }

    private c() {
        this.ve = new ArrayList();
        this.f927a = -1;
        this.sp = false;
        this.x = new Application.ActivityLifecycleCallbacks() { // from class: com.byazt.g.c.1
            @Override // android.app.Application.ActivityLifecycleCallbacks
            public void onActivityCreated(Activity activity, Bundle bundle) {
            }

            @Override // android.app.Application.ActivityLifecycleCallbacks
            public void onActivityDestroyed(Activity activity) {
            }

            @Override // android.app.Application.ActivityLifecycleCallbacks
            public void onActivitySaveInstanceState(Activity activity, Bundle bundle) {
            }

            @Override // android.app.Application.ActivityLifecycleCallbacks
            public void onActivityStarted(Activity activity) {
                c.this.n = new WeakReference(activity);
                int i = c.this.uj;
                c.this.uj = activity != null ? activity.hashCode() : i;
                c.this.sp = false;
                if (i == 0) {
                    c.this.n();
                }
            }

            @Override // android.app.Application.ActivityLifecycleCallbacks
            public void onActivityResumed(Activity activity) {
                int i = c.this.uj;
                c.this.sp = false;
                c.this.uj = activity != null ? activity.hashCode() : i;
                if (i == 0) {
                    c.this.n();
                }
            }

            @Override // android.app.Application.ActivityLifecycleCallbacks
            public void onActivityPaused(Activity activity) {
                c.this.sp = true;
                if (c.this.uj != 0 || activity == null) {
                    return;
                }
                c.this.uj = activity.hashCode();
            }

            @Override // android.app.Application.ActivityLifecycleCallbacks
            public void onActivityStopped(Activity activity) {
                if (activity != null && activity.hashCode() == c.this.uj) {
                    c.this.uj = 0;
                    c.this.a();
                }
                c.this.sp = false;
            }
        };
    }

    public void c(Context context) {
        if (this.c == null && (context instanceof Application)) {
            synchronized (this) {
                if (this.c == null) {
                    Application application = (Application) context;
                    this.c = application;
                    application.registerActivityLifecycleCallbacks(this.x);
                }
            }
        }
    }

    public void c(ve veVar) {
        this.tt = veVar;
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r0v1 */
    /* JADX WARN: Type inference failed for: r0v3, types: [boolean, int] */
    /* JADX WARN: Type inference failed for: r0v4 */
    /* JADX WARN: Type inference failed for: r0v5 */
    public boolean tt() {
        int i = this.f927a;
        ?? r0 = i;
        if (i == -1) {
            ?? Sp = sp();
            this.f927a = Sp;
            r0 = Sp;
        }
        return r0 == 1;
    }

    public boolean ve() {
        return tt() && !this.sp;
    }

    public void c(InterfaceC0125c interfaceC0125c) {
        if (interfaceC0125c == null) {
            return;
        }
        synchronized (this.ve) {
            if (!this.ve.contains(interfaceC0125c)) {
                this.ve.add(interfaceC0125c);
            }
        }
    }

    public void tt(InterfaceC0125c interfaceC0125c) {
        synchronized (this.ve) {
            this.ve.remove(interfaceC0125c);
        }
    }

    private Object[] uj() {
        Object[] array;
        synchronized (this.ve) {
            array = this.ve.size() > 0 ? this.ve.toArray() : null;
        }
        return array;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void n() {
        this.f927a = 1;
        Object[] objArrUj = uj();
        if (objArrUj != null) {
            for (Object obj : objArrUj) {
                ((InterfaceC0125c) obj).tt();
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a() {
        this.f927a = 0;
        Object[] objArrUj = uj();
        if (objArrUj != null) {
            for (Object obj : objArrUj) {
                ((InterfaceC0125c) obj).ve();
            }
        }
    }

    private boolean sp() {
        try {
            Application application = this.c;
            if (application == null) {
                return false;
            }
            application.getSystemService(TTDownloadField.TT_ACTIVITY);
            return TextUtils.equals(application.getPackageName(), a.uj(application));
        } catch (Throwable th) {
            m.c(th);
            return false;
        }
    }
}

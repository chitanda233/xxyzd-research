package com.chuanglan.shanyan_sdk;

import android.app.Activity;
import android.app.Application;
import android.os.Bundle;
import android.os.Handler;
import android.os.Looper;
import java.lang.ref.WeakReference;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.Iterator;
import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.x, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes2.dex */
public final class C0618x implements Application.ActivityLifecycleCallbacks {
    private static volatile C0618x h;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Handler f2033a = new Handler(Looper.getMainLooper());
    private final CopyOnWriteArrayList b = new CopyOnWriteArrayList();
    private boolean c = false;
    private final HashSet d = new HashSet();
    private final HashSet e = new HashSet();
    private final Object f = new Object();
    private Runnable g;

    /* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.x$a */
    class a implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ int f2034a;
        final /* synthetic */ String b;

        a(int i, String str) {
            this.f2034a = i;
            this.b = str;
        }

        @Override // java.lang.Runnable
        public void run() {
            C0618x.this.g = null;
            synchronized (C0618x.this.f) {
                C0618x.this.a();
                boolean z = C0618x.this.d.isEmpty() && C0618x.this.e.isEmpty();
                boolean z2 = C0618x.this.d.contains(Integer.valueOf(this.f2034a)) || C0618x.this.e.contains(Integer.valueOf(this.f2034a));
                if (!z || z2 || C0618x.this.d() <= 0) {
                    Q.a("ActivityLifecycleShanYanLogger", "onApplicationEnterBackground", "isEmpty=", Boolean.valueOf(z), "isSameActivityRestarted=", Boolean.valueOf(z2), "started=", Integer.valueOf(C0618x.this.d.size()), "resumed=", Integer.valueOf(C0618x.this.e.size()));
                } else {
                    Q.a("ActivityLifecycleShanYanLogger", "onApplicationEnterBackground", this.b);
                    C0618x.this.f();
                }
            }
        }
    }

    /* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.x$b */
    class b implements Runnable {
        b() {
        }

        @Override // java.lang.Runnable
        public void run() {
            C0618x.this.f();
        }
    }

    /* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.x$c */
    public interface c {
        void a();
    }

    private C0618x() {
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityCreated(Activity activity, Bundle bundle) {
        Q.a("ActivityLifecycleShanYanLogger", "onActivityCreated", activity.getClass().getSimpleName());
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityDestroyed(Activity activity) {
        synchronized (this.f) {
            int iIdentityHashCode = System.identityHashCode(activity);
            this.d.remove(Integer.valueOf(iIdentityHashCode));
            this.e.remove(Integer.valueOf(iIdentityHashCode));
            Runnable runnable = this.g;
            if (runnable != null) {
                this.f2033a.removeCallbacks(runnable);
                this.g = null;
            }
        }
        Q.a("ActivityLifecycleShanYanLogger", "onActivityDestroyed", activity.getClass().getSimpleName());
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityPaused(Activity activity) {
        synchronized (this.f) {
            this.e.remove(Integer.valueOf(System.identityHashCode(activity)));
            Q.a("ActivityLifecycleShanYanLogger", "onActivityPaused", activity.getClass().getSimpleName() + ", resumed=" + this.e.size());
        }
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityResumed(Activity activity) {
        boolean z;
        try {
            synchronized (this.f) {
                this.e.add(Integer.valueOf(System.identityHashCode(activity)));
                boolean zIsEmpty = this.e.isEmpty();
                Q.a("ActivityLifecycleShanYanLogger", "onActivityResumed", activity.getClass().getSimpleName() + ", resumed=" + this.e.size());
                z = zIsEmpty && !this.e.isEmpty() && d() > 0;
            }
            if (z) {
                Q.a("ActivityLifecycleShanYanLogger", "onApplicationEnterForeground", "App entered foreground");
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivitySaveInstanceState(Activity activity, Bundle bundle) {
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityStarted(Activity activity) {
        synchronized (this.f) {
            this.d.add(Integer.valueOf(System.identityHashCode(activity)));
            Q.a("ActivityLifecycleShanYanLogger", "onActivityStarted", activity.getClass().getSimpleName() + ", started=" + this.d.size());
        }
    }

    @Override // android.app.Application.ActivityLifecycleCallbacks
    public void onActivityStopped(Activity activity) {
        try {
            int iIdentityHashCode = System.identityHashCode(activity);
            String simpleName = activity.getClass().getSimpleName();
            synchronized (this.f) {
                try {
                    this.d.remove(Integer.valueOf(iIdentityHashCode));
                    Q.a("ActivityLifecycleShanYanLogger", "onActivityStopped", simpleName + ", started=" + this.d.size() + ", resumed=" + this.e.size());
                    if (this.d.isEmpty() && this.e.isEmpty() && d() > 0) {
                        Runnable runnable = this.g;
                        if (runnable != null) {
                            this.f2033a.removeCallbacks(runnable);
                            this.g = null;
                        }
                        a aVar = new a(iIdentityHashCode, simpleName);
                        this.g = aVar;
                        this.f2033a.postDelayed(aVar, 50L);
                        Q.a("ActivityLifecycleShanYanLogger", "onActivityStopped", simpleName);
                    }
                } catch (Throwable th) {
                    throw th;
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public static void c() {
        synchronized (C0618x.class) {
            if (h != null) {
                h.b();
                h = null;
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public int d() {
        Iterator it = this.b.iterator();
        int i = 0;
        while (it.hasNext()) {
            if (((WeakReference) it.next()).get() != null) {
                i++;
            }
        }
        return i;
    }

    public static C0618x e() {
        if (h == null) {
            synchronized (C0618x.class) {
                if (h == null) {
                    h = new C0618x();
                }
            }
        }
        return h;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void f() {
        a();
        if (Looper.myLooper() != Looper.getMainLooper()) {
            this.f2033a.post(new b());
            return;
        }
        ArrayList arrayList = new ArrayList();
        Iterator it = this.b.iterator();
        while (it.hasNext()) {
            c cVar = (c) ((WeakReference) it.next()).get();
            if (cVar != null) {
                arrayList.add(cVar);
            }
        }
        Iterator it2 = arrayList.iterator();
        while (it2.hasNext()) {
            ((c) it2.next()).a();
        }
    }

    public void b(Application application, c cVar) {
        if (cVar == null) {
            return;
        }
        try {
            a();
            ArrayList arrayList = new ArrayList();
            for (WeakReference weakReference : this.b) {
                c cVar2 = (c) weakReference.get();
                if (cVar2 == null || cVar2 == cVar) {
                    arrayList.add(weakReference);
                }
            }
            this.b.removeAll(arrayList);
            if (d() == 0 && this.c) {
                this.c = false;
                application.unregisterActivityLifecycleCallbacks(this);
                synchronized (this.f) {
                    this.d.clear();
                    this.e.clear();
                }
                this.f2033a.removeCallbacksAndMessages(null);
                this.g = null;
                Q.a("ActivityLifecycleShanYanLogger", "unregisterListener");
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public void a(Application application, c cVar) {
        if (cVar == null) {
            return;
        }
        try {
            a();
            Iterator it = this.b.iterator();
            while (it.hasNext()) {
                if (((c) ((WeakReference) it.next()).get()) == cVar) {
                    return;
                }
            }
            this.b.add(new WeakReference(cVar));
            if (this.c) {
                return;
            }
            this.c = true;
            application.registerActivityLifecycleCallbacks(this);
            synchronized (this.f) {
                this.d.clear();
                this.e.clear();
            }
            Q.a("ActivityLifecycleShanYanLogger", "registerListener", Integer.valueOf(this.b.size()));
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a() {
        ArrayList arrayList = new ArrayList();
        for (WeakReference weakReference : this.b) {
            if (weakReference.get() == null) {
                arrayList.add(weakReference);
            }
        }
        this.b.removeAll(arrayList);
    }

    private void b() {
        this.f2033a.removeCallbacksAndMessages(null);
        synchronized (this.f) {
            this.b.clear();
            this.d.clear();
            this.e.clear();
            this.c = false;
            this.g = null;
        }
        Q.a("ActivityLifecycleShanYanLogger", "Foreback instance destroyed");
    }
}

package com.kwad.sdk.core.c;

import android.app.Activity;
import android.app.Application;
import android.content.Context;
import android.os.Bundle;
import com.kwad.sdk.api.core.KSLifecycleListener;
import com.kwad.sdk.api.core.KSLifecycleObserver;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.service.a.f;
import com.kwad.sdk.utils.bz;
import com.kwad.sdk.wrapper.m;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
public class b implements c<Activity> {
    private static volatile b aSJ;
    private static final List<c> mListeners = new CopyOnWriteArrayList();
    private Application mApplication;
    private final AtomicBoolean mHasInit = new AtomicBoolean(false);

    private b() {
    }

    public static b Mh() {
        if (aSJ == null) {
            synchronized (b.class) {
                if (aSJ == null) {
                    aSJ = new b();
                }
            }
        }
        return aSJ;
    }

    public final void init(Context context) {
        if (this.mHasInit.get() || context == null) {
            return;
        }
        this.mHasInit.set(true);
        try {
            if (bz.aD(((f) ServiceProvider.get(f.class)).getApiVersion(), "3.3.26")) {
                this.mApplication = KSLifecycleObserver.getInstance().getApplication();
                KSLifecycleObserver.getInstance().registerLifecycleListener(new KSLifecycleListener() { // from class: com.kwad.sdk.core.c.b.1
                    @Override // com.kwad.sdk.api.core.KSLifecycleListener
                    public final void onActivityCreated(final Activity activity, final Bundle bundle) {
                        b bVar = b.this;
                        b.d(new com.kwad.sdk.g.a<c>() { // from class: com.kwad.sdk.core.c.b.1.1
                            /* JADX INFO: Access modifiers changed from: private */
                            @Override // com.kwad.sdk.g.a
                            /* JADX INFO: renamed from: c, reason: merged with bridge method [inline-methods] */
                            public void accept(c cVar) {
                                cVar.a(activity, bundle);
                            }
                        });
                    }

                    @Override // com.kwad.sdk.api.core.KSLifecycleListener
                    public final void onActivityResumed(final Activity activity) {
                        b bVar = b.this;
                        b.d(new com.kwad.sdk.g.a<c>() { // from class: com.kwad.sdk.core.c.b.1.2
                            /* JADX INFO: Access modifiers changed from: private */
                            @Override // com.kwad.sdk.g.a
                            /* JADX INFO: renamed from: c, reason: merged with bridge method [inline-methods] */
                            public void accept(c cVar) {
                                cVar.d(activity);
                            }
                        });
                    }

                    @Override // com.kwad.sdk.api.core.KSLifecycleListener
                    public final void onActivityPaused(final Activity activity) {
                        b bVar = b.this;
                        b.d(new com.kwad.sdk.g.a<c>() { // from class: com.kwad.sdk.core.c.b.1.3
                            /* JADX INFO: Access modifiers changed from: private */
                            @Override // com.kwad.sdk.g.a
                            /* JADX INFO: renamed from: c, reason: merged with bridge method [inline-methods] */
                            public void accept(c cVar) {
                                cVar.c(activity);
                            }
                        });
                    }

                    @Override // com.kwad.sdk.api.core.KSLifecycleListener
                    public final void onActivityStopped(final Activity activity) {
                        b bVar = b.this;
                        b.d(new com.kwad.sdk.g.a<c>() { // from class: com.kwad.sdk.core.c.b.1.4
                            /* JADX INFO: Access modifiers changed from: private */
                            @Override // com.kwad.sdk.g.a
                            /* JADX INFO: renamed from: c, reason: merged with bridge method [inline-methods] */
                            public void accept(c cVar) {
                                cVar.f(activity);
                            }
                        });
                    }

                    @Override // com.kwad.sdk.api.core.KSLifecycleListener
                    public final void onActivityDestroyed(final Activity activity) {
                        b bVar = b.this;
                        b.d(new com.kwad.sdk.g.a<c>() { // from class: com.kwad.sdk.core.c.b.1.5
                            /* JADX INFO: Access modifiers changed from: private */
                            @Override // com.kwad.sdk.g.a
                            /* JADX INFO: renamed from: c, reason: merged with bridge method [inline-methods] */
                            public void accept(c cVar) {
                                cVar.b(activity);
                            }
                        });
                    }

                    @Override // com.kwad.sdk.api.core.KSLifecycleListener
                    public final void onBackToForeground() {
                        com.kwad.sdk.core.d.c.V("LifecycleHolder", "onBackToForeground");
                        b bVar = b.this;
                        b.d(new com.kwad.sdk.g.a<c>() { // from class: com.kwad.sdk.core.c.b.1.6
                            @Override // com.kwad.sdk.g.a
                            public final /* synthetic */ void accept(c cVar) {
                                c(cVar);
                            }

                            private static void c(c cVar) {
                                cVar.onBackToForeground();
                            }
                        });
                    }

                    @Override // com.kwad.sdk.api.core.KSLifecycleListener
                    public final void onBackToBackground() {
                        com.kwad.sdk.core.d.c.V("LifecycleHolder", "onBackToBackground");
                        b bVar = b.this;
                        b.d(new com.kwad.sdk.g.a<c>() { // from class: com.kwad.sdk.core.c.b.1.7
                            @Override // com.kwad.sdk.g.a
                            public final /* synthetic */ void accept(c cVar) {
                                c(cVar);
                            }

                            private static void c(c cVar) {
                                cVar.onBackToBackground();
                            }
                        });
                    }
                });
            } else {
                com.kwad.sdk.core.d.c.V("LifecycleHolder", "init KSLifecycleObserver not support");
            }
        } catch (Throwable unused) {
        }
        Application applicationYh = m.Yh();
        if (applicationYh != null) {
            this.mApplication = applicationYh;
            a.Mf().init(this.mApplication);
            a.Mf().a(this);
        }
    }

    public final Application getApplication() {
        return this.mApplication;
    }

    public static boolean isEnable() {
        return Mi() || a.Mf().isEnable();
    }

    public static boolean isAppOnForeground() {
        if (Mi()) {
            return KSLifecycleObserver.getInstance().isAppOnForeground();
        }
        if (a.Mf().isEnable()) {
            return a.Mf().isAppOnForeground();
        }
        return false;
    }

    public static boolean Mi() {
        try {
            if (bz.aD(((f) ServiceProvider.get(f.class)).getApiVersion(), "3.3.26")) {
                return KSLifecycleObserver.getInstance().isEnable();
            }
            return false;
        } catch (Throwable unused) {
            return false;
        }
    }

    public static Activity getCurrentActivity() {
        if (Mi()) {
            return KSLifecycleObserver.getInstance().getCurrentActivity();
        }
        if (a.Mf().isEnable()) {
            return a.Mf().getCurrentActivity();
        }
        return null;
    }

    public static void a(c cVar) {
        mListeners.add(cVar);
    }

    public static void b(c cVar) {
        mListeners.remove(cVar);
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.sdk.core.c.c
    /* JADX INFO: renamed from: onActivityCreated, reason: merged with bridge method [inline-methods] */
    public void a(final Activity activity, final Bundle bundle) {
        d(new com.kwad.sdk.g.a<c>() { // from class: com.kwad.sdk.core.c.b.2
            /* JADX INFO: Access modifiers changed from: private */
            @Override // com.kwad.sdk.g.a
            /* JADX INFO: renamed from: c, reason: merged with bridge method [inline-methods] */
            public void accept(c cVar) {
                cVar.a(activity, bundle);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.sdk.core.c.c
    /* JADX INFO: renamed from: onActivityResumed, reason: merged with bridge method [inline-methods] */
    public void d(final Activity activity) {
        d(new com.kwad.sdk.g.a<c>() { // from class: com.kwad.sdk.core.c.b.3
            /* JADX INFO: Access modifiers changed from: private */
            @Override // com.kwad.sdk.g.a
            /* JADX INFO: renamed from: c, reason: merged with bridge method [inline-methods] */
            public void accept(c cVar) {
                cVar.d(activity);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.sdk.core.c.c
    /* JADX INFO: renamed from: onActivityPaused, reason: merged with bridge method [inline-methods] */
    public void c(final Activity activity) {
        d(new com.kwad.sdk.g.a<c>() { // from class: com.kwad.sdk.core.c.b.4
            /* JADX INFO: Access modifiers changed from: private */
            @Override // com.kwad.sdk.g.a
            /* JADX INFO: renamed from: c, reason: merged with bridge method [inline-methods] */
            public void accept(c cVar) {
                cVar.c(activity);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.sdk.core.c.c
    /* JADX INFO: renamed from: onActivityStopped, reason: merged with bridge method [inline-methods] */
    public void f(final Activity activity) {
        d(new com.kwad.sdk.g.a<c>() { // from class: com.kwad.sdk.core.c.b.5
            /* JADX INFO: Access modifiers changed from: private */
            @Override // com.kwad.sdk.g.a
            /* JADX INFO: renamed from: c, reason: merged with bridge method [inline-methods] */
            public void accept(c cVar) {
                cVar.f(activity);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.sdk.core.c.c
    /* JADX INFO: renamed from: onActivityDestroyed, reason: merged with bridge method [inline-methods] */
    public void b(final Activity activity) {
        d(new com.kwad.sdk.g.a<c>() { // from class: com.kwad.sdk.core.c.b.6
            /* JADX INFO: Access modifiers changed from: private */
            @Override // com.kwad.sdk.g.a
            /* JADX INFO: renamed from: c, reason: merged with bridge method [inline-methods] */
            public void accept(c cVar) {
                cVar.b(activity);
            }
        });
    }

    @Override // com.kwad.sdk.core.c.c
    public final void onBackToForeground() {
        com.kwad.sdk.core.d.c.V("LifecycleHolder", "onBackToForeground old");
        d(new com.kwad.sdk.g.a<c>() { // from class: com.kwad.sdk.core.c.b.7
            @Override // com.kwad.sdk.g.a
            public final /* synthetic */ void accept(c cVar) {
                c(cVar);
            }

            private static void c(c cVar) {
                cVar.onBackToForeground();
            }
        });
    }

    @Override // com.kwad.sdk.core.c.c
    public final void onBackToBackground() {
        com.kwad.sdk.core.d.c.V("LifecycleHolder", "onBackToBackground old");
        d(new com.kwad.sdk.g.a<c>() { // from class: com.kwad.sdk.core.c.b.8
            @Override // com.kwad.sdk.g.a
            public final /* synthetic */ void accept(c cVar) {
                c(cVar);
            }

            private static void c(c cVar) {
                cVar.onBackToBackground();
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static <T> void d(com.kwad.sdk.g.a<c> aVar) {
        for (c cVar : mListeners) {
            if (cVar != null) {
                aVar.accept(cVar);
            }
        }
    }
}

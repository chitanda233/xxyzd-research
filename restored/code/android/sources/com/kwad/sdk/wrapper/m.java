package com.kwad.sdk.wrapper;

import android.app.Activity;
import android.app.Application;
import android.content.Context;
import android.content.ContextWrapper;
import android.view.ContextThemeWrapper;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ab;

/* JADX INFO: loaded from: classes3.dex */
public final class m {
    private static Application btY;

    public static void E(Context context, boolean z) {
        try {
            context.getSharedPreferences("kssdk_api_pref", 0).edit().putBoolean("useContextClassLoader", z).apply();
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTrace(th);
        }
    }

    public static int getThemeResId(Context context) {
        if (context instanceof ContextThemeWrapper) {
            Object objA = ab.a((Object) context, "android.view.ContextThemeWrapper", "getThemeResId");
            if (objA != null) {
                return ((Integer) objA).intValue();
            }
            return 0;
        }
        if (context instanceof androidx.appcompat.view.ContextThemeWrapper) {
            return ((androidx.appcompat.view.ContextThemeWrapper) context).getThemeResId();
        }
        return 0;
    }

    private static boolean Yg() {
        if (f.XZ().Ww()) {
            return true;
        }
        ServiceProvider.reportSdkCaughtException(new RuntimeException("please init KSPlugin"));
        return false;
    }

    public static View a(Context context, int i, ViewGroup viewGroup, boolean z) {
        LayoutInflater layoutInflaterEQ;
        try {
            layoutInflaterEQ = eQ(context);
            try {
                return layoutInflaterEQ.inflate(i, viewGroup, z);
            } catch (RuntimeException e) {
                e = e;
                throw WrapperException.createFromInflater(layoutInflaterEQ, e);
            }
        } catch (RuntimeException e2) {
            e = e2;
            layoutInflaterEQ = null;
        }
    }

    public static View inflate(Context context, int i, ViewGroup viewGroup) {
        LayoutInflater layoutInflaterEQ;
        try {
            layoutInflaterEQ = eQ(context);
            try {
                return eQ(context).inflate(i, viewGroup);
            } catch (RuntimeException e) {
                e = e;
                throw WrapperException.createFromInflater(layoutInflaterEQ, e);
            }
        } catch (RuntimeException e2) {
            e = e2;
            layoutInflaterEQ = null;
        }
    }

    public static void d(Application application) {
        if (btY == null) {
            btY = application;
        }
    }

    public static Application Yh() {
        Yg();
        Application applicationYi = Yi();
        if (j.Ye()) {
            btY = (Application) j.wrapContextIfNeed(applicationYi);
        }
        return btY;
    }

    private static Application Yi() {
        Context applicationContext;
        Application application = btY;
        if (application != null) {
            return application;
        }
        Context contextUm = ServiceProvider.Um();
        if (contextUm instanceof Application) {
            Application application2 = (Application) contextUm;
            btY = application2;
            return application2;
        }
        Context applicationContext2 = contextUm.getApplicationContext();
        if (applicationContext2 instanceof Application) {
            Application application3 = (Application) applicationContext2;
            btY = application3;
            return application3;
        }
        if (bd(applicationContext2)) {
            applicationContext = j.eI(applicationContext2);
        } else if (k.bd(applicationContext2)) {
            applicationContext = k.eI(applicationContext2);
        } else {
            applicationContext = contextUm.getApplicationContext();
        }
        if (applicationContext instanceof Application) {
            btY = (Application) applicationContext;
        } else {
            Application application4 = com.kwad.sdk.core.c.b.Mh().getApplication();
            if (application4 != null) {
                btY = application4;
            } else if (applicationContext instanceof ContextWrapper) {
                Context baseContext = ((ContextWrapper) applicationContext).getBaseContext();
                if (baseContext != null) {
                    baseContext = baseContext.getApplicationContext();
                }
                if (baseContext instanceof Application) {
                    btY = (Application) baseContext;
                }
            }
        }
        if (btY == null) {
            btY = Yj();
        }
        Application applicationEN = eN(btY);
        btY = applicationEN;
        return applicationEN;
    }

    private static Application Yj() {
        Application application = (Application) ab.a("android.app.ActivityThread", "currentApplication", new Object[0]);
        return application != null ? application : (Application) ab.a("android.app.AppGlobals", "getInitialApplication", new Object[0]);
    }

    public static Activity getActivityFromContext(Context context) {
        if (context instanceof Activity) {
            return (Activity) context;
        }
        Context contextEL = eL(context);
        if (contextEL instanceof Activity) {
            return (Activity) contextEL;
        }
        com.kwad.sdk.core.c.b.Mh();
        return com.kwad.sdk.core.c.b.getCurrentActivity();
    }

    public static Context wrapContextIfNeed(Context context) {
        Context contextWrapContextIfNeed;
        if (!Yg() || !Yk()) {
            return context;
        }
        if (j.Ye()) {
            contextWrapContextIfNeed = j.wrapContextIfNeed(context);
        } else {
            contextWrapContextIfNeed = k.wrapContextIfNeed(context);
        }
        return eK(contextWrapContextIfNeed);
    }

    public static boolean Yk() {
        return ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).FG() || f.XZ().Ya();
    }

    private static Context eK(Context context) {
        if (j.Ye() && !bd(context)) {
            ServiceProvider.reportSdkCaughtException(new RuntimeException("expect KSContext in external --context:" + context.getClass().getName() + "--initFinish:" + ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).FJ()));
        } else if (!j.Ye() && !k.bd(context)) {
            ServiceProvider.reportSdkCaughtException(new RuntimeException("expect ResContext in external --context:" + context.getClass().getName() + "--initFinish:" + ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).FJ()));
        }
        return context;
    }

    public static Context eL(Context context) {
        Context contextUnwrapContextIfNeed;
        if (!Yg() || !Yk() || eO(context)) {
            return context;
        }
        if (bd(context)) {
            contextUnwrapContextIfNeed = j.eH(context);
        } else {
            contextUnwrapContextIfNeed = k.unwrapContextIfNeed(context);
        }
        return eM(contextUnwrapContextIfNeed);
    }

    private static Context eM(Context context) {
        if (k.bd(context) || (context instanceof b)) {
            ServiceProvider.reportSdkCaughtException(new RuntimeException("expect normalContext --context:" + context.getClass().getName() + "--initFinish:" + ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).FJ()));
        }
        return context;
    }

    private static Application eN(Context context) {
        if (context instanceof Application) {
            return (Application) context;
        }
        ServiceProvider.reportSdkCaughtException(new RuntimeException("expect normalContext --context:" + context.getClass().getName() + "--initFinish:" + ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).FJ() + "--isExternal:" + ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).FG() + "--isInnerDex:" + f.XZ().Ya()));
        return null;
    }

    public static boolean eO(Context context) {
        return (bd(context) || k.bd(context)) ? false : true;
    }

    private static boolean bd(Context context) {
        return context instanceof b;
    }

    public static Context eP(Context context) {
        try {
            if (k.bd(context)) {
                context = k.bc(context);
            }
            if (context instanceof b) {
                context = ((b) context).getDelegatedContext();
            }
            if (eO(context)) {
                return context;
            }
            for (int i = 0; i < 5; i++) {
                if (k.bd(context)) {
                    context = k.bc(context);
                }
                if (context instanceof b) {
                    context = ((b) context).getDelegatedContext();
                }
                if (eO(context)) {
                    return context;
                }
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
        return context;
    }

    public static LayoutInflater eQ(Context context) {
        Context contextWrapContextIfNeed = wrapContextIfNeed(context);
        if (k.bd(contextWrapContextIfNeed)) {
            LayoutInflater layoutInflaterFrom = LayoutInflater.from(contextWrapContextIfNeed);
            a(layoutInflaterFrom);
            return layoutInflaterFrom;
        }
        return LayoutInflater.from(contextWrapContextIfNeed);
    }

    public static LayoutInflater a(Context context, Context context2) {
        LayoutInflater layoutInflaterCloneInContext = LayoutInflater.from(bb(context)).cloneInContext(context2);
        a(layoutInflaterCloneInContext);
        return layoutInflaterCloneInContext;
    }

    private static Context bb(Context context) {
        return context instanceof ContextWrapper ? ((ContextWrapper) context).getBaseContext() : context;
    }

    private static void a(LayoutInflater layoutInflater) {
        ab.a(layoutInflater, "mFactory", (Object) null);
        ab.a(layoutInflater, "mFactory2", (Object) null);
    }

    public static void u(Activity activity) {
        k.onDestroy(activity);
    }
}

package com.kwad.sdk.wrapper;

import android.app.Application;
import android.content.Context;
import com.kwad.sdk.api.core.ResContext;
import com.kwad.sdk.api.loader.Wrapper;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
final class k {
    static Context wrapContextIfNeed(Context context) {
        return Wrapper.wrapContextIfNeed(context);
    }

    static Context unwrapContextIfNeed(Context context) {
        if (bd(context)) {
            context = bc(context);
        }
        if (!bd(context)) {
            return context;
        }
        RuntimeException runtimeException = null;
        for (int i = 0; i < 10; i++) {
            if (runtimeException == null) {
                RuntimeException runtimeException2 = new RuntimeException("expect normalContext --context:" + context.getClass().getName() + "--initFinish:" + ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).FJ());
                ((com.kwad.sdk.service.a.e) ServiceProvider.get(com.kwad.sdk.service.a.e.class)).gatherException(runtimeException2);
                runtimeException = runtimeException2;
            }
            context = bc(context);
            if (!bd(context)) {
                return context;
            }
        }
        return context;
    }

    static Context eI(Context context) {
        Context applicationContext = unwrapContextIfNeed(context).getApplicationContext();
        if (applicationContext instanceof Application) {
            return applicationContext;
        }
        for (int i = 0; i < 10; i++) {
            applicationContext = applicationContext.getApplicationContext();
            if (applicationContext instanceof Application) {
                return applicationContext;
            }
            if (bd(applicationContext)) {
                applicationContext = bc(applicationContext);
            }
        }
        return applicationContext;
    }

    static boolean bd(Context context) {
        return context instanceof ResContext;
    }

    /* JADX WARN: Multi-variable type inference failed */
    static Context bc(Context context) {
        return ((ResContext) context).getDelegatedContext();
    }

    public static void onDestroy(Context context) {
        Wrapper.onDestroy(context);
    }
}

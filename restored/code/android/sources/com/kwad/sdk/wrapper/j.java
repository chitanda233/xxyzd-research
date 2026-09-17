package com.kwad.sdk.wrapper;

import android.app.Activity;
import android.app.Application;
import android.content.Context;
import android.content.ContextWrapper;
import android.content.res.Resources;
import android.text.TextUtils;
import android.util.Log;
import android.view.ContextThemeWrapper;
import com.kwad.sdk.service.ServiceProvider;
import java.lang.ref.WeakReference;
import java.util.Arrays;
import java.util.List;
import java.util.Map;
import java.util.WeakHashMap;
import java.util.concurrent.CopyOnWriteArrayList;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
public class j {
    private static final String CLAZZ_NAME = "com.kwad.sdk.wrapper.j";
    private static final ThreadLocal<a> sAutoUnWrapModelTL = new ThreadLocal<>();
    private static final List<String> sAutoUnWrapStackList = new CopyOnWriteArrayList();
    private static final Map<Context, Context> sResContextCache = new WeakHashMap();
    private static final AtomicBoolean btR = new AtomicBoolean(false);

    static class a {
        private WeakReference<Context> aDY;
        private int aDZ;
        private StackTraceElement[] aEa;
        private int aEb;
        private long aEc;

        private a() {
            this.aDY = new WeakReference<>(null);
            this.aDZ = 0;
            this.aEa = null;
            this.aEb = 0;
        }

        /* synthetic */ a(byte b) {
            this();
        }

        static /* synthetic */ int c(a aVar) {
            int i = aVar.aDZ;
            aVar.aDZ = i + 1;
            return i;
        }

        static /* synthetic */ int g(a aVar) {
            int i = aVar.aEb;
            aVar.aEb = i + 1;
            return i;
        }

        /* JADX INFO: Access modifiers changed from: private */
        public void clear() {
            this.aDY = new WeakReference<>(null);
            this.aDZ = 0;
            this.aEa = null;
            this.aEb = 0;
            this.aEc = 0L;
        }
    }

    public static boolean Ye() {
        return btR.get();
    }

    public static void cL(boolean z) {
        btR.set(z);
    }

    static Context wrapContextIfNeed(Context context) {
        Context gVar;
        if (context == null) {
            ((com.kwad.sdk.service.a.e) ServiceProvider.get(com.kwad.sdk.service.a.e.class)).gatherException(new RuntimeException("KSWrapper wrapContextIfNeed context is null"));
            return null;
        }
        com.kwad.sdk.core.d.c.w("Wrapper", "wrapContextIfNeed run context is: " + context);
        if (!m.Yk() || (context instanceof b)) {
            return context;
        }
        if (k.bd(context)) {
            context = k.unwrapContextIfNeed(context);
            if (k.bd(context)) {
                ((com.kwad.sdk.service.a.e) ServiceProvider.get(com.kwad.sdk.service.a.e.class)).gatherException(new RuntimeException("KSWrapper unwrapContextIfNeed fail"));
                return context;
            }
        }
        Context context2 = sResContextCache.get(context);
        if (context2 instanceof b) {
            return context2;
        }
        if (l.eJ(context)) {
            return context;
        }
        if (returnUnWrappedContext(context)) {
            ((com.kwad.sdk.service.a.e) ServiceProvider.get(com.kwad.sdk.service.a.e.class)).gatherException(new RuntimeException("KSWrapper returnUnWrappedContext context: " + context.getClass().getName()));
            return context;
        }
        if (context instanceof Application) {
            try {
                gVar = new g((Application) context, new h(context, f.XZ()));
                m.d((Application) gVar);
            } catch (Throwable th) {
                com.kwad.sdk.core.d.c.w("Wrapper", "wrapContextIfNeed Application error: " + th.getMessage());
                th.printStackTrace();
                ((com.kwad.sdk.service.a.e) ServiceProvider.get(com.kwad.sdk.service.a.e.class)).gatherException(new RuntimeException("wrapper Application fail --context:" + context.getClass().getName() + "--initFinish:" + ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).FJ()));
                return context;
            }
        } else if (context instanceof ContextThemeWrapper) {
            gVar = new c((ContextThemeWrapper) context);
        } else if (context instanceof androidx.appcompat.view.ContextThemeWrapper) {
            gVar = new d((androidx.appcompat.view.ContextThemeWrapper) context);
        } else if (context instanceof ContextWrapper) {
            gVar = new e(context);
        } else {
            gVar = new e(context);
        }
        b(context, gVar);
        return gVar;
    }

    private static void b(final Context context, Context context2) {
        sResContextCache.put(context, context2);
        if (context instanceof Activity) {
            com.kwad.sdk.core.c.b.Mh();
            com.kwad.sdk.core.c.b.a(new com.kwad.sdk.core.c.d() { // from class: com.kwad.sdk.wrapper.j.1
                @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
                /* JADX INFO: renamed from: onActivityDestroyed */
                public final void b(Activity activity) {
                    if (activity == context) {
                        com.kwad.sdk.core.c.b.Mh();
                        com.kwad.sdk.core.c.b.b((com.kwad.sdk.core.c.c) this);
                        j.onDestroy(context);
                    }
                }
            });
        }
    }

    public static void onDestroy(Context context) {
        sResContextCache.remove(context);
    }

    static ClassLoader replaceExternalClassLoader(ClassLoader classLoader) {
        ClassLoader classLoader2 = f.XZ().getClassLoader();
        return classLoader2 != null ? classLoader2 : classLoader;
    }

    static Resources.Theme replaceTheme(Resources.Theme theme, Resources.Theme theme2, int i) {
        Resources resources = f.XZ().getResources();
        if (resources == null) {
            return theme;
        }
        if (theme2 != null) {
            return theme2;
        }
        Resources.Theme themeNewTheme = resources.newTheme();
        themeNewTheme.applyStyle(i, true);
        return themeNewTheme;
    }

    private static boolean returnUnWrappedContext(Context context) {
        ThreadLocal<a> threadLocal = sAutoUnWrapModelTL;
        a aVar = threadLocal.get();
        byte b = 0;
        if (aVar != null) {
            if (aVar.aDY.get() != context || Math.abs(System.currentTimeMillis() - aVar.aEc) >= 150) {
                aVar.clear();
                aVar.aDY = new WeakReference(context);
                aVar.aEc = System.currentTimeMillis();
            } else {
                a.c(aVar);
                if (aVar.aDZ >= (context instanceof Application ? 15 : 5) && a(context, aVar)) {
                    aVar.clear();
                    return true;
                }
            }
        } else {
            threadLocal.set(new a(b));
        }
        return false;
    }

    private static boolean a(Context context, a aVar) {
        Context context2 = sResContextCache.get(context);
        String name = context2 != null ? context2.getClass().getName() : "";
        StackTraceElement[] stackTrace = Thread.currentThread().getStackTrace();
        if (!Arrays.equals(stackTrace, aVar.aEa)) {
            if (aVar.aEa != null) {
                aVar.clear();
                return false;
            }
            aVar.aEa = stackTrace;
            int i = 0;
            int i2 = 0;
            while (i < stackTrace.length) {
                StackTraceElement stackTraceElement = stackTrace[i];
                String className = stackTraceElement.getClassName();
                for (String str : getAutoUnWrapStackList()) {
                    if (!TextUtils.isEmpty(str) && className.contains(str)) {
                        Log.d("Wrapper", "needAutoUnWrap true 命中白名单");
                        return true;
                    }
                }
                String methodName = stackTraceElement.getMethodName();
                i++;
                if (i < stackTrace.length && CLAZZ_NAME.equals(className) && "wrapContextIfNeed".equals(methodName)) {
                    StackTraceElement stackTraceElement2 = stackTrace[i];
                    if (TextUtils.equals(name, stackTraceElement2.getClassName()) && "getBaseContext".equals(stackTraceElement2.getMethodName()) && (i2 = i2 + 1) >= 5) {
                        return true;
                    }
                }
            }
            return false;
        }
        a.g(aVar);
        aVar.aEa = stackTrace;
        if (aVar.aEb < 5) {
            return false;
        }
        Log.d("Wrapper", "needAutoUnWrap true 连续相同堆栈");
        return true;
    }

    private static List<String> getAutoUnWrapStackList() {
        List<String> list = sAutoUnWrapStackList;
        if (list.isEmpty()) {
            list.add("com.sensorsdata.analytics.android.sdk");
        }
        return list;
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r5v0, types: [android.content.Context] */
    /* JADX WARN: Type inference failed for: r5v1, types: [android.content.Context] */
    /* JADX WARN: Type inference failed for: r5v10 */
    /* JADX WARN: Type inference failed for: r5v11 */
    /* JADX WARN: Type inference failed for: r5v12 */
    /* JADX WARN: Type inference failed for: r5v13 */
    /* JADX WARN: Type inference failed for: r5v14 */
    /* JADX WARN: Type inference failed for: r5v15 */
    /* JADX WARN: Type inference failed for: r5v16 */
    /* JADX WARN: Type inference failed for: r5v17 */
    /* JADX WARN: Type inference failed for: r5v2, types: [android.content.Context, java.lang.Object] */
    /* JADX WARN: Type inference failed for: r5v3 */
    /* JADX WARN: Type inference failed for: r5v4, types: [android.content.Context] */
    static Context eH(Context context) {
        boolean z = context instanceof b;
        ?? delegatedContext = context;
        if (z) {
            delegatedContext = ((b) context).getDelegatedContext();
        }
        if (m.eO(delegatedContext)) {
            return delegatedContext;
        }
        RuntimeException runtimeException = null;
        int i = 0;
        ?? r5 = delegatedContext;
        while (i < 10) {
            if (runtimeException == null) {
                RuntimeException runtimeException2 = new RuntimeException("expect normalContext --context:" + r5.getClass().getName() + "--initFinish:" + ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).FJ());
                ((com.kwad.sdk.service.a.e) ServiceProvider.get(com.kwad.sdk.service.a.e.class)).gatherException(runtimeException2);
                runtimeException = runtimeException2;
            }
            boolean zBd = k.bd(r5);
            ?? Bc = r5;
            if (zBd) {
                Bc = k.bc(r5);
            }
            boolean z2 = Bc instanceof b;
            ?? delegatedContext2 = Bc;
            if (z2) {
                delegatedContext2 = ((b) Bc).getDelegatedContext();
            }
            if (m.eO(delegatedContext2)) {
                return delegatedContext2;
            }
            i++;
            r5 = delegatedContext2;
        }
        return r5;
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r2v3, types: [android.content.Context] */
    /* JADX WARN: Type inference failed for: r2v4, types: [android.content.Context] */
    /* JADX WARN: Type inference failed for: r2v5 */
    /* JADX WARN: Type inference failed for: r2v7, types: [android.content.Context] */
    /* JADX WARN: Type inference failed for: r2v8 */
    /* JADX WARN: Type inference failed for: r2v9 */
    static Context eI(Context context) {
        if (context instanceof Application) {
            return context;
        }
        Context applicationContext = eH(context).getApplicationContext();
        if (applicationContext instanceof Application) {
            return applicationContext;
        }
        int i = 0;
        ?? r2 = applicationContext;
        while (i < 10) {
            ?? applicationContext2 = r2.getApplicationContext();
            if (applicationContext2 instanceof Application) {
                return applicationContext2;
            }
            if (applicationContext2 instanceof b) {
                applicationContext2 = ((b) applicationContext2).getDelegatedContext();
            }
            i++;
            r2 = applicationContext2;
        }
        return r2;
    }
}

package com.kwad.library.solder.lib;

import android.content.Context;
import android.util.Log;
import com.kwad.library.solder.lib.ext.PluginError;
import com.kwad.sdk.utils.by;
import java.io.File;
import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.LinkedBlockingQueue;
import java.util.concurrent.ThreadFactory;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;
import java.util.concurrent.atomic.AtomicInteger;

/* JADX INFO: loaded from: classes3.dex */
public final class i {
    private static Map<String, Integer> aEB = new ConcurrentHashMap(8);
    private static a aEC;
    private static volatile i aEz;
    private e aEA;
    private volatile boolean mHasInit = false;

    public interface a {
        boolean Ef();

        void b(String str, File file);

        void f(String str, Throwable th);

        int getCorePoolSize();

        int getMaxRetryCount();
    }

    private i() {
    }

    public static i Ec() {
        if (aEz == null) {
            synchronized (i.class) {
                if (aEz == null) {
                    aEz = new i();
                }
            }
        }
        return aEz;
    }

    private static ExecutorService cV(int i) {
        return new ThreadPoolExecutor(i, 3, 60L, TimeUnit.SECONDS, new LinkedBlockingQueue(), new ThreadFactory() { // from class: com.kwad.library.solder.lib.i.1
            private final AtomicInteger poolNumber = new AtomicInteger(1);

            @Override // java.util.concurrent.ThreadFactory
            public final Thread newThread(Runnable runnable) {
                Thread thread = new Thread(runnable);
                try {
                    String name = thread.getName();
                    thread.setName(name + "-");
                    i.aEB.put(name, 1);
                } catch (Throwable th) {
                    com.kwad.library.solder.lib.a.e("Sodler", Log.getStackTraceString(th));
                }
                return thread;
            }
        });
    }

    public static boolean cy(String str) {
        try {
            Map<String, Integer> map = aEB;
            if (map != null) {
                return map.containsKey(str);
            }
            return false;
        } catch (Throwable unused) {
            return false;
        }
    }

    public static void a(a aVar) {
        aEC = aVar;
    }

    private synchronized void init(Context context) {
        if (this.mHasInit) {
            return;
        }
        com.kwad.library.solder.lib.ext.c.a aVarCG = new com.kwad.library.solder.lib.ext.c.a().cG("sodler");
        a aVar = aEC;
        com.kwad.library.solder.lib.ext.c.a aVarBz = aVarCG.cY(aVar != null ? aVar.getMaxRetryCount() : 1).bz(false);
        a aVar2 = aEC;
        com.kwad.library.solder.lib.ext.c.a aVarBA = aVarBz.bA(aVar2 != null && aVar2.Ef());
        a aVar3 = aEC;
        com.kwad.library.solder.lib.ext.c.a aVarA = aVarBA.a(cV(aVar3 != null ? aVar3.getCorePoolSize() : 0));
        a aVar4 = aEC;
        com.kwad.library.solder.lib.ext.c cVarEI = aVarA.cZ(aVar4 != null ? aVar4.getCorePoolSize() : 0).EI();
        d dVar = new d(context);
        c cVar = new c(context, cVarEI);
        f fVar = new f(context);
        fVar.a(new com.kwad.library.solder.lib.a.f.a() { // from class: com.kwad.library.solder.lib.i.2
            @Override // com.kwad.library.solder.lib.a.f.a
            public final void a(com.kwad.library.solder.lib.a.e eVar, File file) throws PluginError.UpdateError {
                if (i.aEC != null) {
                    try {
                        eVar.getDownloadUrl();
                        file.getAbsolutePath();
                        i.aEC.b(eVar.getDownloadUrl(), file);
                    } catch (Throwable th) {
                        th.printStackTrace();
                        i.aEC.f(eVar.getDownloadUrl(), th);
                        throw new PluginError.UpdateError(th.getMessage(), PluginError.ERROR_UPD_PLUGIN_CONNECTION);
                    }
                }
            }
        });
        this.aEA = new e(dVar, fVar, cVar, cVarEI, new com.kwad.library.solder.lib.ext.a());
        this.mHasInit = true;
    }

    public final <P extends com.kwad.library.solder.lib.a.a, R extends com.kwad.library.solder.lib.a.e<P>> void a(Context context, R r, com.kwad.library.solder.lib.ext.b<P, R> bVar) {
        init(context);
        r.cX(this.aEA.DW().getRetryCount());
        r.a(new b<P, R>(bVar, new com.kwad.library.solder.lib.ext.b.C0493b()) { // from class: com.kwad.library.solder.lib.i.3
            /* JADX WARN: Incorrect types in method signature: (TR;Lcom/kwad/library/solder/lib/ext/PluginError;)V */
            @Override // com.kwad.library.solder.lib.b, com.kwad.library.solder.lib.ext.b
            public final void a(final com.kwad.library.solder.lib.a.e eVar, PluginError pluginError) {
                super.a(eVar, pluginError);
                com.kwad.library.solder.lib.a.e("Sodler", "load failed:" + pluginError.getCode() + ":" + pluginError.getMessage());
                i.this.aEA.i(eVar);
                by.runOnUiThreadDelay(new Runnable() { // from class: com.kwad.library.solder.lib.i.3.1
                    @Override // java.lang.Runnable
                    public final void run() {
                        if (eVar.Em()) {
                            i.this.aEA.a(eVar, 16);
                        }
                    }
                }, eVar.El() instanceof PluginError.UpdateError ? 1000L : 0L);
            }
        });
        this.aEA.a(r, 16);
    }

    public final com.kwad.library.solder.lib.a.a p(Context context, String str) {
        if (!this.mHasInit && context != null) {
            init(context);
        }
        e eVar = this.aEA;
        if (eVar != null) {
            return eVar.DX().cw(str);
        }
        return null;
    }

    public final com.kwad.library.solder.lib.ext.c DW() {
        if (!this.mHasInit) {
            throw new RuntimeException("Sodler has not yet been init.");
        }
        return this.aEA.DW();
    }

    public final void o(Context context, final String str) {
        if (!this.mHasInit && context != null) {
            init(context);
        }
        if (DW() == null || DW().EG() == null) {
            return;
        }
        DW().EG().execute(new Runnable() { // from class: com.kwad.library.solder.lib.i.4
            @Override // java.lang.Runnable
            public final void run() {
                try {
                    i.this.aEA.DZ().cu(str);
                } catch (Throwable th) {
                    Log.getStackTraceString(th);
                }
            }
        });
    }
}

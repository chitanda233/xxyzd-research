package com.kwad.sdk.utils.a;

import java.util.concurrent.Executor;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.LinkedBlockingQueue;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;

/* JADX INFO: loaded from: classes3.dex */
public final class d {
    static c.d bsw;
    static volatile Executor bsx;
    static ExecutorService bsy = Executors.newSingleThreadExecutor();

    private d() {
    }

    public static void a(c.d dVar) {
        bsw = dVar;
    }

    public static void setExecutor(Executor executor) {
        if (executor != null) {
            bsx = executor;
        }
    }

    static Executor getExecutor() {
        if (bsx == null) {
            synchronized (d.class) {
                if (bsx == null) {
                    ThreadPoolExecutor threadPoolExecutor = new ThreadPoolExecutor(4, 4, 10L, TimeUnit.SECONDS, new LinkedBlockingQueue());
                    threadPoolExecutor.allowCoreThreadTimeOut(true);
                    bsx = threadPoolExecutor;
                }
            }
        }
        return bsx;
    }
}

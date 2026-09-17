package com.kwad.sdk.utils;

import com.kwad.sdk.core.threads.GlobalThreadPools;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.ScheduledExecutorService;
import java.util.concurrent.TimeUnit;

/* JADX INFO: loaded from: classes3.dex */
public class i {
    private static volatile ExecutorService bos;
    private static volatile ScheduledExecutorService bot;

    public static void execute(Runnable runnable) {
        if (bos == null) {
            synchronized (i.class) {
                if (bos == null) {
                    bos = GlobalThreadPools.Or();
                }
            }
        }
        if (bos == null || bos.isShutdown() || bos.isTerminated()) {
            return;
        }
        bos.execute(runnable);
    }

    public static void schedule(Runnable runnable, long j, TimeUnit timeUnit) {
        if (bot == null) {
            synchronized (i.class) {
                if (bot == null) {
                    bot = GlobalThreadPools.Os();
                }
            }
        }
        bot.schedule(runnable, j, timeUnit);
    }
}

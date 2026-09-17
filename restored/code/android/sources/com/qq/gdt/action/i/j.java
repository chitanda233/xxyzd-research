package com.qq.gdt.action.i;

import java.util.concurrent.Executor;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.LinkedBlockingQueue;
import java.util.concurrent.ThreadFactory;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;
import java.util.concurrent.atomic.AtomicInteger;

/* JADX INFO: loaded from: classes3.dex */
public class j {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static volatile j f3081a;
    private static final TimeUnit c = TimeUnit.SECONDS;
    private volatile ExecutorService b;

    public static j a() {
        if (f3081a == null) {
            synchronized (j.class) {
                if (f3081a == null) {
                    f3081a = new j();
                }
            }
        }
        return f3081a;
    }

    public synchronized Executor b() {
        if (this.b == null || this.b.isShutdown()) {
            try {
                this.b = new ThreadPoolExecutor(2, 4, 30L, c, new LinkedBlockingQueue(1000), new ThreadFactory() { // from class: com.qq.gdt.action.i.j.1
                    private final AtomicInteger b = new AtomicInteger(1);

                    @Override // java.util.concurrent.ThreadFactory
                    public Thread newThread(Runnable runnable) {
                        Thread thread = new Thread(runnable, "GDTAction-" + this.b.getAndIncrement());
                        thread.setDaemon(true);
                        return thread;
                    }
                });
            } catch (Exception e) {
                o.a("Failed to create custom thread pool, using default CachedThreadPool", e);
                this.b = Executors.newCachedThreadPool();
            }
        }
        return this.b;
    }
}

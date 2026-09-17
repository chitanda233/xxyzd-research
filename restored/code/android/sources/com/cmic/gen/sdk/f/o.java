package com.cmic.gen.sdk.f;

import android.content.Context;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.SynchronousQueue;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;

/* JADX INFO: compiled from: ThreadUtils.java */
/* JADX INFO: loaded from: classes2.dex */
public class o {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final ExecutorService f2129a = new ThreadPoolExecutor(0, 30, 60, TimeUnit.SECONDS, new SynchronousQueue());

    public static void a(a aVar) {
        try {
            f2129a.execute(aVar);
        } catch (Exception e) {
            aVar.f2130a.uncaughtException(Thread.currentThread(), e);
        }
    }

    /* JADX INFO: compiled from: ThreadUtils.java */
    public static abstract class a implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private final Thread.UncaughtExceptionHandler f2130a;

        protected abstract void a();

        protected a() {
            this.f2130a = new Thread.UncaughtExceptionHandler() { // from class: com.cmic.gen.sdk.f.o.a.1
                @Override // java.lang.Thread.UncaughtExceptionHandler
                public void uncaughtException(Thread thread, Throwable th) {
                    th.printStackTrace();
                }
            };
        }

        protected a(final Context context, final com.cmic.gen.sdk.a aVar) {
            this.f2130a = new Thread.UncaughtExceptionHandler() { // from class: com.cmic.gen.sdk.f.o.a.2
                @Override // java.lang.Thread.UncaughtExceptionHandler
                public void uncaughtException(Thread thread, Throwable th) {
                    aVar.a().f2094a.add(th);
                    com.cmic.gen.sdk.auth.c.getInstance(context).callBackResult("200025", "发生未知错误", aVar, null);
                }
            };
        }

        @Override // java.lang.Runnable
        public void run() {
            Thread.currentThread().setUncaughtExceptionHandler(this.f2130a);
            a();
            Thread.currentThread().setUncaughtExceptionHandler(null);
        }
    }
}

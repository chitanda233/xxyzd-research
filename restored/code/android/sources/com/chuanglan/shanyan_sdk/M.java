package com.chuanglan.shanyan_sdk;

import com.chuanglan.shanyan_sdk.listener.InitCallbacks;
import java.util.concurrent.ScheduledExecutorService;
import java.util.concurrent.ScheduledThreadPoolExecutor;
import java.util.concurrent.TimeUnit;

/* JADX INFO: loaded from: classes2.dex */
public abstract class M {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static ScheduledExecutorService f1946a = new ScheduledThreadPoolExecutor(1);

    class a implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ InitCallbacks f1947a;
        final /* synthetic */ long b;
        final /* synthetic */ int c;
        final /* synthetic */ long d;
        final /* synthetic */ long e;
        final /* synthetic */ long f;

        a(InitCallbacks initCallbacks, long j, int i, long j2, long j3, long j4) {
            this.f1947a = initCallbacks;
            this.b = j;
            this.c = i;
            this.d = j2;
            this.e = j3;
            this.f = j4;
        }

        @Override // java.lang.Runnable
        public void run() {
            InitCallbacks initCallbacks = this.f1947a;
            EnumC0611q enumC0611q = EnumC0611q.TIME_OUT_CODE;
            initCallbacks.initFailed(enumC0611q.d(), enumC0611q.b(), enumC0611q.e(), enumC0611q.c() + this.b, this.c, this.d, this.e, this.f);
        }
    }

    public static void a(long j, InitCallbacks initCallbacks, int i, long j2, long j3, long j4) {
        ScheduledExecutorService scheduledExecutorService = f1946a;
        if (scheduledExecutorService == null || scheduledExecutorService.isShutdown()) {
            f1946a = new ScheduledThreadPoolExecutor(1);
        }
        f1946a.schedule(new a(initCallbacks, j, i, j2, j3, j4), j, TimeUnit.MILLISECONDS);
    }

    public static synchronized void a() {
        ScheduledExecutorService scheduledExecutorService = f1946a;
        if (scheduledExecutorService != null) {
            scheduledExecutorService.shutdownNow();
        }
    }
}

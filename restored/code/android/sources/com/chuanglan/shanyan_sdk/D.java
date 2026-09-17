package com.chuanglan.shanyan_sdk;

import com.chuanglan.shanyan_sdk.listener.LoginAuthCallbacks;
import java.util.concurrent.ScheduledExecutorService;
import java.util.concurrent.ScheduledThreadPoolExecutor;
import java.util.concurrent.TimeUnit;

/* JADX INFO: loaded from: classes2.dex */
public abstract class D {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static ScheduledExecutorService f1933a = new ScheduledThreadPoolExecutor(1);

    class a implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ LoginAuthCallbacks f1934a;
        final /* synthetic */ long b;
        final /* synthetic */ String c;
        final /* synthetic */ long d;
        final /* synthetic */ long e;
        final /* synthetic */ long f;

        a(LoginAuthCallbacks loginAuthCallbacks, long j, String str, long j2, long j3, long j4) {
            this.f1934a = loginAuthCallbacks;
            this.b = j;
            this.c = str;
            this.d = j2;
            this.e = j3;
            this.f = j4;
        }

        @Override // java.lang.Runnable
        public void run() {
            LoginAuthCallbacks loginAuthCallbacks = this.f1934a;
            EnumC0611q enumC0611q = EnumC0611q.TIME_OUT_CODE;
            loginAuthCallbacks.getTokenFailed(enumC0611q.d(), enumC0611q.b(), enumC0611q.e(), enumC0611q.c() + this.b, this.c, this.d, this.e, this.f);
        }
    }

    public static void a(String str, long j, LoginAuthCallbacks loginAuthCallbacks, long j2, long j3, long j4) {
        ScheduledExecutorService scheduledExecutorService = f1933a;
        if (scheduledExecutorService == null || scheduledExecutorService.isShutdown()) {
            f1933a = new ScheduledThreadPoolExecutor(1);
        }
        f1933a.schedule(new a(loginAuthCallbacks, j, str, j2, j3, j4), j, TimeUnit.MILLISECONDS);
    }

    public static synchronized void a() {
        ScheduledExecutorService scheduledExecutorService = f1933a;
        if (scheduledExecutorService != null) {
            scheduledExecutorService.shutdownNow();
        }
    }
}

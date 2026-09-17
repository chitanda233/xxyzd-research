package com.chuanglan.shanyan_sdk;

import android.content.Context;
import com.chuanglan.shanyan_sdk.listener.GetPhoneInfoCallbacks;
import java.util.concurrent.ScheduledExecutorService;
import java.util.concurrent.ScheduledThreadPoolExecutor;
import java.util.concurrent.TimeUnit;

/* JADX INFO: loaded from: classes2.dex */
public abstract class j0 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static ScheduledExecutorService f1980a = new ScheduledThreadPoolExecutor(1);

    class a implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ GetPhoneInfoCallbacks f1981a;
        final /* synthetic */ long b;
        final /* synthetic */ int c;
        final /* synthetic */ Context d;
        final /* synthetic */ long e;
        final /* synthetic */ long f;
        final /* synthetic */ long g;

        a(GetPhoneInfoCallbacks getPhoneInfoCallbacks, long j, int i, Context context, long j2, long j3, long j4) {
            this.f1981a = getPhoneInfoCallbacks;
            this.b = j;
            this.c = i;
            this.d = context;
            this.e = j2;
            this.f = j3;
            this.g = j4;
        }

        @Override // java.lang.Runnable
        public void run() {
            GetPhoneInfoCallbacks getPhoneInfoCallbacks = this.f1981a;
            EnumC0611q enumC0611q = EnumC0611q.TIME_OUT_CODE;
            getPhoneInfoCallbacks.getPhoneInfoFailed(enumC0611q.d(), enumC0611q.b(), enumC0611q.e(), enumC0611q.c() + this.b, this.c, C0616v.g().b(this.d), this.e, this.f, this.g);
        }
    }

    public static void a(Context context, long j, int i, GetPhoneInfoCallbacks getPhoneInfoCallbacks, long j2, long j3, long j4) {
        ScheduledExecutorService scheduledExecutorService = f1980a;
        if (scheduledExecutorService == null || scheduledExecutorService.isShutdown()) {
            f1980a = new ScheduledThreadPoolExecutor(1);
        }
        f1980a.schedule(new a(getPhoneInfoCallbacks, j, i, context, j2, j3, j4), j, TimeUnit.MILLISECONDS);
    }

    public static synchronized void a() {
        ScheduledExecutorService scheduledExecutorService = f1980a;
        if (scheduledExecutorService != null) {
            scheduledExecutorService.shutdownNow();
        }
    }
}

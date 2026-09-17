package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.os.SystemClock;
import com.chuanglan.shanyan_sdk.listener.OpenLoginAuthCallbaks;
import java.util.concurrent.ExecutorService;

/* JADX INFO: loaded from: classes2.dex */
public class T {
    private static volatile T d;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Context f1956a;
    private ExecutorService b;
    private OpenLoginAuthCallbaks c;

    class a implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ int f1957a;
        final /* synthetic */ long b;
        final /* synthetic */ long c;

        a(int i, long j, long j2) {
            this.f1957a = i;
            this.b = j;
            this.c = j2;
        }

        @Override // java.lang.Runnable
        public void run() {
            k0.b().a(this.f1957a, null, this.b, this.c);
            Q.a("ProcessShanYanLogger", "open preInfo start ");
        }
    }

    private T() {
    }

    public static T a() {
        if (d == null) {
            synchronized (T.class) {
                if (d == null) {
                    d = new T();
                }
            }
        }
        return d;
    }

    public void a(Context context, ExecutorService executorService) {
        this.f1956a = context;
        this.b = executorService;
    }

    public void a(int i, long j, long j2) {
        Q.a("ProcessShanYanLogger", "openLoginAuthMethod start ");
        this.c = new e0(this.f1956a);
        long jUptimeMillis = SystemClock.uptimeMillis();
        if (this.f1956a != null && this.b != null) {
            a aVar = new a(i, j, j2);
            if (AbstractC0606l.U.getAndSet(false)) {
                this.b.execute(aVar);
                return;
            }
            Q.d("ExceptionShanYanLogger", "openLoginAuthMethod is in progress");
            OpenLoginAuthCallbaks openLoginAuthCallbaks = this.c;
            EnumC0611q enumC0611q = EnumC0611q.AUTHPAGE_LOADING_CODE;
            openLoginAuthCallbaks.openPageFailed(enumC0611q.d(), enumC0611q.b(), enumC0611q.e(), enumC0611q.c() + "openLoginAuthMethod()", "Unknown_Operator", j, j2, jUptimeMillis);
            return;
        }
        Q.a("ProcessShanYanLogger", "not initialized ");
        OpenLoginAuthCallbaks openLoginAuthCallbaks2 = this.c;
        EnumC0611q enumC0611q2 = EnumC0611q.NOT_INITIALIZED_CODE;
        openLoginAuthCallbaks2.openPageFailed(enumC0611q2.d(), enumC0611q2.b(), enumC0611q2.e(), enumC0611q2.c() + "openLoginAuthMethod()", "Unknown_Operator", j, j2, jUptimeMillis);
    }

    public void a(long j, long j2, long j3) {
        try {
            Q.a("ProcessShanYanLogger", "start LoginActivity");
            t0.h().m();
            AbstractC0595a.a(this.f1956a, j, j2, j3);
        } catch (Exception e) {
            e.printStackTrace();
            AbstractC0606l.U.set(true);
            OpenLoginAuthCallbaks openLoginAuthCallbaks = this.c;
            EnumC0611q enumC0611q = EnumC0611q.SDK_EXCEPTION_CODE;
            openLoginAuthCallbaks.openPageFailed(enumC0611q.d(), enumC0611q.b(), enumC0611q.e(), enumC0611q.c() + e, "Unknown_Operator", j, j2, j3);
        }
    }
}

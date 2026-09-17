package com.qq.gdt.action.e.b;

import android.os.Handler;
import android.os.Looper;
import java.util.concurrent.Executor;
import java.util.concurrent.LinkedBlockingQueue;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;

/* JADX INFO: loaded from: classes3.dex */
public class d {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public int f3052a = (int) TimeUnit.SECONDS.toMillis(30);
    public int b = (int) TimeUnit.SECONDS.toMillis(30);
    public Executor c = new ThreadPoolExecutor(3, 10, 60, TimeUnit.SECONDS, new LinkedBlockingQueue());
    public Executor d = new Executor() { // from class: com.qq.gdt.action.e.b.d.1

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        Handler f3053a = new Handler(Looper.getMainLooper());

        @Override // java.util.concurrent.Executor
        public void execute(Runnable runnable) {
            this.f3053a.post(runnable);
        }
    };
}

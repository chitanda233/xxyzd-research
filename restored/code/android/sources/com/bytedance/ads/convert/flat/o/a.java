package com.bytedance.ads.convert.flat.o;

import com.bytedance.ads.convert.flat.n.c;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.SynchronousQueue;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes2.dex */
public class a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final int f1747a = Runtime.getRuntime().availableProcessors();
    public static final c<ExecutorService> b;

    /* JADX INFO: renamed from: com.bytedance.ads.convert.flat.o.a$a, reason: collision with other inner class name */
    public static class C0336a extends c<ExecutorService> {
        @Override // com.bytedance.ads.convert.flat.n.c
        public ExecutorService a(Object[] objArr) {
            return new ThreadPoolExecutor((int) (((double) a.f1747a) * 0.5d), Integer.MAX_VALUE, 30L, TimeUnit.SECONDS, new SynchronousQueue());
        }
    }

    static {
        new AtomicBoolean(false);
        b = new C0336a();
    }
}

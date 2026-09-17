package cn.thinkingdata.analytics.g;

import java.util.concurrent.ExecutorService;
import java.util.concurrent.LinkedBlockingQueue;
import java.util.concurrent.ThreadFactory;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;

/* JADX INFO: loaded from: classes.dex */
public class a {
    private static volatile a b;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final ExecutorService f111a = new ThreadPoolExecutor(1, 1, 0, TimeUnit.MILLISECONDS, new LinkedBlockingQueue(), new ThreadFactoryC0023a(this));

    /* JADX INFO: renamed from: cn.thinkingdata.analytics.g.a$a, reason: collision with other inner class name */
    class ThreadFactoryC0023a implements ThreadFactory {
        ThreadFactoryC0023a(a aVar) {
        }

        @Override // java.util.concurrent.ThreadFactory
        public Thread newThread(Runnable runnable) {
            return new Thread(runnable, "TD.TaskExecuteThread");
        }
    }

    private a() {
    }

    public static a a() {
        if (b == null) {
            synchronized (a.class) {
                if (b == null) {
                    b = new a();
                }
            }
        }
        return b;
    }

    public void a(Runnable runnable) {
        try {
            this.f111a.execute(runnable);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}

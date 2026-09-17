package cn.thinkingdata.core.network;

import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.ThreadFactory;

/* JADX INFO: loaded from: classes.dex */
public class TEHttpTaskManager {
    private static final String THREAD_TE_NET = "TE.NetWorkTask";
    private static volatile ExecutorService executor;

    static class ThreadFactoryWithName implements ThreadFactory {
        private final String name;

        ThreadFactoryWithName(String str) {
            this.name = str;
        }

        @Override // java.util.concurrent.ThreadFactory
        public Thread newThread(Runnable runnable) {
            return new Thread(runnable, this.name);
        }
    }

    private TEHttpTaskManager() {
    }

    public static ExecutorService getExecutor() {
        if (executor == null) {
            synchronized (TEHttpTaskManager.class) {
                if (executor == null) {
                    executor = Executors.newCachedThreadPool(new ThreadFactoryWithName(THREAD_TE_NET));
                }
            }
        }
        return executor;
    }
}

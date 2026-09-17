package cn.thinkingdata.thirdparty;

import java.util.concurrent.ExecutorService;
import java.util.concurrent.LinkedBlockingQueue;
import java.util.concurrent.ThreadFactory;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;

/* JADX INFO: loaded from: classes.dex */
public class ThirdPartyTaskManager {
    private static final int POOL_SIZE = 2;
    private static final String THREAD_TD_THIRD = "TD.ThirdPartyTask";
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

    private ThirdPartyTaskManager() {
    }

    public static ExecutorService getExecutor() {
        if (executor == null) {
            synchronized (ThirdPartyTaskManager.class) {
                if (executor == null) {
                    executor = new ThreadPoolExecutor(2, 2, 0L, TimeUnit.MILLISECONDS, new LinkedBlockingQueue(), new ThreadFactoryWithName(THREAD_TD_THIRD));
                }
            }
        }
        return executor;
    }
}

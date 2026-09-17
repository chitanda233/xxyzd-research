package cn.com.chinatelecom.account.api.manager;

import java.util.concurrent.BlockingQueue;
import java.util.concurrent.LinkedBlockingQueue;
import java.util.concurrent.ThreadFactory;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;
import java.util.concurrent.atomic.AtomicInteger;

/* JADX INFO: loaded from: classes.dex */
public class ThreadPoolManager extends ThreadPoolExecutor {
    private static final int CORE_POOL_SIZE = 5;
    private static final int KEEP_ALIVE = 1;
    private static final int MAXIMUM_QUEUE_SIZE = 256;
    private static final BlockingQueue<Runnable> taskQueue = new LinkedBlockingQueue(256);
    private static final ThreadFactory sThreadFactory = new ThreadFactory() { // from class: cn.com.chinatelecom.account.api.manager.ThreadPoolManager.1
        private final AtomicInteger mCount = new AtomicInteger(1);

        @Override // java.util.concurrent.ThreadFactory
        public Thread newThread(Runnable runnable) {
            return new Thread(runnable);
        }
    };

    public ThreadPoolManager() {
        this(5);
    }

    public ThreadPoolManager(int i) {
        this(i, i * 2, 1L, TimeUnit.SECONDS, taskQueue, sThreadFactory);
    }

    public ThreadPoolManager(int i, int i2, long j, TimeUnit timeUnit, BlockingQueue<Runnable> blockingQueue, ThreadFactory threadFactory) {
        super(i, i2, j, timeUnit, blockingQueue, threadFactory);
    }

    public void executeTask(WorkTask workTask) {
        execute(workTask);
    }

    public static abstract class AbsRunnable implements Runnable {
        private boolean isCancel = false;

        public void setCancel(boolean z) {
            this.isCancel = z;
        }

        public boolean isCancel() {
            return this.isCancel;
        }
    }
}

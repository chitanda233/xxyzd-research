package com.bun.miitmdid.utils;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.netease.nis.sdkwrapper.Utils;
import java.util.concurrent.ArrayBlockingQueue;
import java.util.concurrent.BlockingQueue;
import java.util.concurrent.ThreadFactory;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;
import java.util.concurrent.atomic.AtomicInteger;

/* JADX INFO: loaded from: classes.dex */
public class ThreadPoolUtil {
    public static BlockingQueue blockingQueue = new ArrayBlockingQueue(3);
    public static ThreadFactory threadFactory = new ThreadFactory() { // from class: com.bun.miitmdid.utils.ThreadPoolUtil.1
        public final AtomicInteger integer = new AtomicInteger();

        @Override // java.util.concurrent.ThreadFactory
        public Thread newThread(Runnable runnable) {
            return new Thread(runnable, "myThreadPool thread:" + this.integer.getAndIncrement());
        }
    };
    public static int CORE_POOL_SIZE = 2;
    public static int MAX_POOL_SIZE = 5;
    public static int KEEP_ALIVE_TIME = 5000;
    public static ThreadPoolExecutor threadPool = new ThreadPoolExecutor(CORE_POOL_SIZE, MAX_POOL_SIZE, KEEP_ALIVE_TIME, TimeUnit.SECONDS, (BlockingQueue<Runnable>) blockingQueue, threadFactory);

    public static void execute(Runnable runnable) {
        Object[] objArr = new Object[4];
        objArr[1] = runnable;
        objArr[2] = Integer.valueOf(MediaPlayer.MEDIA_PLAYER_OPTION_LOOP_START_TIME);
        objArr[3] = 1594371206413L;
        Utils.rL(objArr);
    }
}

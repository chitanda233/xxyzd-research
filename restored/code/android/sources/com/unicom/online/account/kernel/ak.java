package com.unicom.online.account.kernel;

import java.util.concurrent.ThreadFactory;
import java.util.concurrent.atomic.AtomicInteger;

/* JADX INFO: loaded from: classes4.dex */
public final class ak implements ThreadFactory {
    public final AtomicInteger b = new AtomicInteger(1);

    @Override // java.util.concurrent.ThreadFactory
    public final Thread newThread(Runnable runnable) {
        Thread thread = new Thread(runnable, "LogUploader-" + this.b.getAndIncrement());
        thread.setDaemon(true);
        return thread;
    }
}

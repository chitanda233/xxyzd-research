package com.gorilla.sdk;

import android.util.Log;
import java.util.concurrent.ConcurrentHashMap;
import java.util.concurrent.Executors;
import java.util.concurrent.ScheduledExecutorService;
import java.util.concurrent.ScheduledFuture;
import java.util.concurrent.ThreadFactory;
import java.util.concurrent.TimeUnit;
import java.util.concurrent.atomic.AtomicLong;

/* JADX INFO: loaded from: classes3.dex */
public final class NativeTimer {
    private static final AtomicLong NEXT_ID = new AtomicLong(1);
    private static final ConcurrentHashMap<Long, TimerEntry> TIMERS = new ConcurrentHashMap<>();
    private static final ScheduledExecutorService EXECUTOR = Executors.newSingleThreadScheduledExecutor(new ThreadFactory() { // from class: com.gorilla.sdk.NativeTimer.1
        @Override // java.util.concurrent.ThreadFactory
        public Thread newThread(Runnable runnable) {
            Thread thread = new Thread(runnable, "GorillaBase-NativeTimer");
            thread.setDaemon(true);
            return thread;
        }
    });

    public interface Callback {
        void onTick();
    }

    private NativeTimer() {
    }

    public static long create(long j, Callback callback) {
        if (j <= 0) {
            throw new IllegalArgumentException("Timer interval must be greater than zero.");
        }
        if (callback == null) {
            throw new IllegalArgumentException("Timer callback cannot be null.");
        }
        long andIncrement = NEXT_ID.getAndIncrement();
        TIMERS.put(Long.valueOf(andIncrement), new TimerEntry(j, callback));
        return andIncrement;
    }

    public static void start(long j) {
        final TimerEntry timerEntry = TIMERS.get(Long.valueOf(j));
        if (timerEntry == null) {
            return;
        }
        synchronized (timerEntry) {
            if (timerEntry.future == null && !timerEntry.cancelled) {
                timerEntry.future = EXECUTOR.scheduleAtFixedRate(new Runnable() { // from class: com.gorilla.sdk.NativeTimer$$ExternalSyntheticLambda0
                    @Override // java.lang.Runnable
                    public final void run() {
                        NativeTimer.invoke(timerEntry);
                    }
                }, timerEntry.intervalMilliseconds, timerEntry.intervalMilliseconds, TimeUnit.MILLISECONDS);
            }
        }
    }

    public static void cancel(long j) {
        TimerEntry timerEntryRemove = TIMERS.remove(Long.valueOf(j));
        if (timerEntryRemove == null) {
            return;
        }
        synchronized (timerEntryRemove) {
            timerEntryRemove.cancelled = true;
            if (timerEntryRemove.future != null) {
                timerEntryRemove.future.cancel(false);
                timerEntryRemove.future = null;
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void invoke(TimerEntry timerEntry) {
        if (timerEntry.cancelled) {
            return;
        }
        try {
            timerEntry.callback.onTick();
        } catch (Throwable th) {
            Log.e("GorillaBase-NativeTimer", "Timer callback failed.", th);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    static final class TimerEntry {
        private final Callback callback;
        private volatile boolean cancelled;
        private ScheduledFuture<?> future;
        private final long intervalMilliseconds;

        private TimerEntry(long j, Callback callback) {
            this.intervalMilliseconds = j;
            this.callback = callback;
        }
    }
}

package com.czhj.sdk.common.ThreadPool;

import android.os.Handler;
import com.czhj.sdk.common.utils.Preconditions;

/* JADX INFO: loaded from: classes2.dex */
public abstract class RepeatingHandlerRunnable implements Runnable {
    private final Handler mHandler;
    private volatile boolean mIsRunning;
    protected volatile long mUpdateIntervalMillis;

    protected RepeatingHandlerRunnable(Handler handler) {
        Preconditions.NoThrow.checkNotNull(handler);
        this.mHandler = handler;
    }

    protected abstract void doWork();

    @Override // java.lang.Runnable
    public void run() {
        if (this.mIsRunning) {
            doWork();
            this.mHandler.postDelayed(this, this.mUpdateIntervalMillis);
        }
    }

    public void startRepeating(long j) {
        Preconditions.NoThrow.checkArgument(j > 0, "intervalMillis must be greater than 0. Saw: " + j);
        this.mUpdateIntervalMillis = j;
        if (this.mIsRunning) {
            return;
        }
        this.mIsRunning = true;
        this.mHandler.post(this);
    }

    public void stop() {
        this.mIsRunning = false;
        this.mHandler.removeCallbacksAndMessages(null);
    }
}

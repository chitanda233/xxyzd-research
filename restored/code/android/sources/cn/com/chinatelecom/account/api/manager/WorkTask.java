package cn.com.chinatelecom.account.api.manager;

import android.os.Handler;
import android.os.Looper;

/* JADX INFO: loaded from: classes.dex */
public abstract class WorkTask implements Runnable {
    private static Handler handler = new Handler(Looper.getMainLooper());
    private boolean isCompleted = false;
    private TimeOutTask timeOutTask;
    private long timeout;

    public abstract void runTask();

    public void timeout() {
    }

    public WorkTask() {
    }

    public WorkTask(long j) {
        this.timeout = j;
    }

    public void setCompleted(boolean z) {
        this.isCompleted = z;
    }

    public boolean isCompleted() {
        return this.isCompleted;
    }

    @Override // java.lang.Runnable
    public void run() {
        if (this.timeout > 0) {
            checkTimeOut();
        }
        runTask();
    }

    public void removeTimeoutTask() {
        try {
            TimeOutTask timeOutTask = this.timeOutTask;
            if (timeOutTask != null) {
                handler.removeCallbacks(timeOutTask);
            }
        } catch (Throwable th) {
            th.printStackTrace();
        }
    }

    private void checkTimeOut() {
        TimeOutTask timeOutTask = new TimeOutTask(this);
        this.timeOutTask = timeOutTask;
        handler.postDelayed(timeOutTask, this.timeout);
    }

    private static class TimeOutTask implements Runnable {
        private WorkTask workTask;

        public TimeOutTask(WorkTask workTask) {
            this.workTask = workTask;
        }

        @Override // java.lang.Runnable
        public void run() {
            WorkTask workTask = this.workTask;
            if (workTask != null) {
                workTask.timeout();
            }
        }
    }
}

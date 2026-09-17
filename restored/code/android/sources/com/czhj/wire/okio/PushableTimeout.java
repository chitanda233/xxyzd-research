package com.czhj.wire.okio;

import java.util.concurrent.TimeUnit;

/* JADX INFO: loaded from: classes2.dex */
final class PushableTimeout extends Timeout {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Timeout f2394a;
    private boolean b;
    private long c;
    private long d;

    PushableTimeout() {
    }

    void a() {
        this.f2394a.timeout(this.d, TimeUnit.NANOSECONDS);
        if (this.b) {
            this.f2394a.deadlineNanoTime(this.c);
        } else {
            this.f2394a.clearDeadline();
        }
    }

    void a(Timeout timeout) {
        long jDeadlineNanoTime;
        this.f2394a = timeout;
        boolean zHasDeadline = timeout.hasDeadline();
        this.b = zHasDeadline;
        this.c = zHasDeadline ? timeout.deadlineNanoTime() : -1L;
        long jTimeoutNanos = timeout.timeoutNanos();
        this.d = jTimeoutNanos;
        timeout.timeout(a(jTimeoutNanos, timeoutNanos()), TimeUnit.NANOSECONDS);
        if (this.b && hasDeadline()) {
            jDeadlineNanoTime = Math.min(deadlineNanoTime(), this.c);
        } else if (!hasDeadline()) {
            return;
        } else {
            jDeadlineNanoTime = deadlineNanoTime();
        }
        timeout.deadlineNanoTime(jDeadlineNanoTime);
    }
}

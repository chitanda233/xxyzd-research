package com.czhj.wire.okio;

import java.io.IOException;
import java.util.concurrent.TimeUnit;

/* JADX INFO: loaded from: classes2.dex */
public class ForwardingTimeout extends Timeout {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Timeout f2380a;

    public ForwardingTimeout(Timeout timeout) {
        if (timeout == null) {
            throw new IllegalArgumentException("delegate == null");
        }
        this.f2380a = timeout;
    }

    @Override // com.czhj.wire.okio.Timeout
    public Timeout clearDeadline() {
        return this.f2380a.clearDeadline();
    }

    @Override // com.czhj.wire.okio.Timeout
    public Timeout clearTimeout() {
        return this.f2380a.clearTimeout();
    }

    @Override // com.czhj.wire.okio.Timeout
    public long deadlineNanoTime() {
        return this.f2380a.deadlineNanoTime();
    }

    @Override // com.czhj.wire.okio.Timeout
    public Timeout deadlineNanoTime(long j) {
        return this.f2380a.deadlineNanoTime(j);
    }

    public final Timeout delegate() {
        return this.f2380a;
    }

    @Override // com.czhj.wire.okio.Timeout
    public boolean hasDeadline() {
        return this.f2380a.hasDeadline();
    }

    public final ForwardingTimeout setDelegate(Timeout timeout) {
        if (timeout == null) {
            throw new IllegalArgumentException("delegate == null");
        }
        this.f2380a = timeout;
        return this;
    }

    @Override // com.czhj.wire.okio.Timeout
    public void throwIfReached() throws IOException {
        this.f2380a.throwIfReached();
    }

    @Override // com.czhj.wire.okio.Timeout
    public Timeout timeout(long j, TimeUnit timeUnit) {
        return this.f2380a.timeout(j, timeUnit);
    }

    @Override // com.czhj.wire.okio.Timeout
    public long timeoutNanos() {
        return this.f2380a.timeoutNanos();
    }
}

package com.kwad.framework.filedownloader;

import android.os.SystemClock;

/* JADX INFO: loaded from: classes3.dex */
public final class b implements s.a, s.b {
    private long ayT;
    private long ayU;
    private long ayV;
    private int ayW;
    private int ayX = 1000;
    private long mStartTime;

    @Override // com.kwad.framework.filedownloader.s.b
    public final void start(long j) {
        this.mStartTime = SystemClock.uptimeMillis();
        this.ayV = j;
    }

    @Override // com.kwad.framework.filedownloader.s.b
    public final void end(long j) {
        if (this.mStartTime <= 0) {
            return;
        }
        long j2 = j - this.ayV;
        this.ayT = 0L;
        long jUptimeMillis = SystemClock.uptimeMillis() - this.mStartTime;
        if (jUptimeMillis <= 0) {
            this.ayW = (int) j2;
        } else {
            this.ayW = (int) (j2 / jUptimeMillis);
        }
    }

    @Override // com.kwad.framework.filedownloader.s.b
    public final void X(long j) {
        if (this.ayX <= 0) {
            return;
        }
        boolean z = true;
        if (this.ayT != 0) {
            long jUptimeMillis = SystemClock.uptimeMillis() - this.ayT;
            if (jUptimeMillis >= this.ayX || (this.ayW == 0 && jUptimeMillis > 0)) {
                int i = (int) ((j - this.ayU) / jUptimeMillis);
                this.ayW = i;
                this.ayW = Math.max(0, i);
            } else {
                z = false;
            }
        }
        if (z) {
            this.ayU = j;
            this.ayT = SystemClock.uptimeMillis();
        }
    }

    @Override // com.kwad.framework.filedownloader.s.b
    public final void reset() {
        this.ayW = 0;
        this.ayT = 0L;
    }

    @Override // com.kwad.framework.filedownloader.s.a
    public final int getSpeed() {
        return this.ayW;
    }
}

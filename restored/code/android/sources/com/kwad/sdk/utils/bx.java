package com.kwad.sdk.utils;

import android.os.SystemClock;

/* JADX INFO: loaded from: classes3.dex */
public final class bx {
    private long brr;
    private long brs;
    private boolean brt;

    public bx() {
        reset();
    }

    public final void startTiming() {
        reset();
        this.brt = true;
        this.brs = SystemClock.elapsedRealtime();
    }

    private void reset() {
        this.brr = 0L;
        this.brs = -1L;
    }

    public final void Xn() {
        if (this.brt && this.brs < 0) {
            this.brs = SystemClock.elapsedRealtime();
        }
    }

    public final void Xo() {
        if (this.brt && this.brs > 0) {
            this.brr += SystemClock.elapsedRealtime() - this.brs;
            this.brs = -1L;
        }
    }

    public final long Xp() {
        if (!this.brt) {
            return 0L;
        }
        this.brt = false;
        if (this.brs > 0) {
            this.brr += SystemClock.elapsedRealtime() - this.brs;
            this.brs = -1L;
        }
        return this.brr;
    }

    public final long getTime() {
        if (this.brs > 0) {
            return (this.brr + SystemClock.elapsedRealtime()) - this.brs;
        }
        return this.brr;
    }
}

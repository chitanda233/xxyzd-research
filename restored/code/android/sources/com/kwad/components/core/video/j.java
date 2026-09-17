package com.kwad.components.core.video;

import android.os.SystemClock;

/* JADX INFO: loaded from: classes3.dex */
public final class j {
    private volatile boolean anS;
    private long anT;
    private a anU = new a();

    public static class a {
        private long anV = 0;
        private int anW = 0;

        public final void accumulate(long j) {
            this.anV += j;
            this.anW++;
        }

        public final int yh() {
            return this.anW;
        }

        public final long yi() {
            return this.anV;
        }

        public final void reset() {
            this.anV = 0L;
            this.anW = 0;
        }
    }

    public final void yc() {
        if (this.anS) {
            return;
        }
        this.anS = true;
        this.anT = SystemClock.elapsedRealtime();
        com.kwad.sdk.core.video.a.a.a.fq("videoStartBlock");
    }

    public final void yd() {
        if (this.anS) {
            long jElapsedRealtime = SystemClock.elapsedRealtime() - this.anT;
            this.anU.accumulate(jElapsedRealtime);
            this.anS = false;
            com.kwad.sdk.core.video.a.a.a.fq("videoEndBlock");
            com.kwad.sdk.core.video.a.a.a.fq("videoBlockTime_" + jElapsedRealtime);
        }
    }

    public final boolean ye() {
        return this.anS;
    }

    public final a yf() {
        if (this.anS) {
            this.anU.accumulate(SystemClock.elapsedRealtime() - this.anT);
            this.anS = false;
        }
        return this.anU;
    }

    public final long yg() {
        return this.anT;
    }

    public final void reset() {
        this.anS = false;
        this.anT = 0L;
        this.anU.reset();
    }
}

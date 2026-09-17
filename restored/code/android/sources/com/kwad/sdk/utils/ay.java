package com.kwad.sdk.utils;

import android.content.Context;
import android.os.PowerManager;
import android.os.SystemClock;

/* JADX INFO: loaded from: classes3.dex */
public final class ay {
    private static volatile ay bpS = new ay();
    private volatile boolean bpT;
    private volatile long bpU = 0;
    private volatile PowerManager bpV;

    public static ay Wg() {
        return bpS;
    }

    public final boolean dK(Context context) {
        if (this.bpU > 0 && SystemClock.elapsedRealtime() - this.bpU < 600) {
            return this.bpT;
        }
        if (this.bpV == null && context != null) {
            synchronized (this) {
                if (this.bpV == null) {
                    this.bpV = (PowerManager) context.getApplicationContext().getSystemService("power");
                }
            }
        }
        this.bpT = this.bpV != null ? this.bpV.isInteractive() : false;
        this.bpU = SystemClock.elapsedRealtime();
        return this.bpT;
    }
}

package com.kwad.components.core.t;

import android.os.SystemClock;
import android.view.View;

/* JADX INFO: loaded from: classes3.dex */
public final class j {
    private static long alC;
    private long alB;
    private boolean alD;
    private long alE;

    public j() {
        this(false);
    }

    public j(boolean z) {
        this(z, 1000L);
    }

    private j(boolean z, long j) {
        this.alD = z;
        this.alE = 1000L;
    }

    public final void a(View view, View.OnClickListener onClickListener) {
        com.kwad.sdk.core.d.c.d("click", "cur:" + SystemClock.elapsedRealtime() + " pre:" + this.alB + " global:" + this.alD + " gt:" + alC);
        if (SystemClock.elapsedRealtime() - (this.alD ? alC : this.alB) > this.alE) {
            long jElapsedRealtime = SystemClock.elapsedRealtime();
            this.alB = jElapsedRealtime;
            alC = jElapsedRealtime;
            onClickListener.onClick(view);
        }
    }
}

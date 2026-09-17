package com.kwad.components.core.a;

import android.os.SystemClock;
import android.text.TextUtils;
import com.kwad.sdk.core.c.b;
import com.kwad.sdk.core.c.d;
import com.kwad.sdk.core.config.e;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.core.report.g;
import com.kwad.sdk.core.report.n;
import java.util.Timer;
import java.util.TimerTask;
import java.util.UUID;
import java.util.concurrent.TimeUnit;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private String OH;
    private String OI;
    private long OJ;
    private long OL;
    private Timer OM;
    private boolean ON = false;
    private final long period;

    /* JADX INFO: renamed from: com.kwad.components.core.a.a$a, reason: collision with other inner class name */
    static final class C0416a {
        private static final a OP = new a();
    }

    public static a oB() {
        return C0416a.OP;
    }

    public a() {
        this.OJ = -1L;
        try {
            this.OJ = SystemClock.elapsedRealtime();
        } catch (Throwable th) {
            this.OJ = System.currentTimeMillis();
            c.printStackTraceOnly(th);
        }
        this.period = TimeUnit.MINUTES.toMillis(e.JH());
        d dVar = new d() { // from class: com.kwad.components.core.a.a.1
            @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
            public final void onBackToForeground() {
                super.onBackToForeground();
                a.this.aw();
            }

            @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
            public final void onBackToBackground() {
                super.onBackToBackground();
                a.this.ax();
            }
        };
        b.Mh();
        b.a(dVar);
    }

    public final void aw() {
        if (this.ON) {
            return;
        }
        this.ON = true;
        if (this.period <= 0) {
            return;
        }
        this.OM = new Timer();
        ax(1);
        TimerTask timerTask = new TimerTask() { // from class: com.kwad.components.core.a.a.2
            @Override // java.util.TimerTask, java.lang.Runnable
            public final void run() {
                a.this.ax(2);
            }
        };
        try {
            Timer timer = this.OM;
            long j = this.period;
            timer.schedule(timerTask, j, j);
        } catch (Throwable unused) {
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void ax() {
        this.ON = false;
        if (this.period <= 0) {
            return;
        }
        Timer timer = this.OM;
        if (timer != null) {
            timer.cancel();
        }
        ax(3);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void ax(int i) {
        long jElapsedRealtime = SystemClock.elapsedRealtime();
        long j = jElapsedRealtime - this.OJ;
        this.OJ = jElapsedRealtime;
        if (i == 1) {
            this.OL = 0L;
            this.OI = UUID.randomUUID().toString();
            if (TextUtils.isEmpty(this.OH)) {
                this.OH = this.OI;
            }
        }
        this.OL++;
        n nVar = new n(10220L);
        nVar.aRP = this.OL;
        if (j > 0) {
            nVar.aWy = j;
        }
        nVar.aWz = i;
        nVar.OH = this.OH;
        nVar.OI = this.OI;
        g.a(nVar);
    }
}

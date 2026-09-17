package com.sigmob.sdk.base.utils;

import android.os.CountDownTimer;
import com.czhj.sdk.logger.SigmobLogger;

/* JADX INFO: loaded from: classes3.dex */
public class o {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final String f3261a = "o";
    private CountDownTimer b;
    private long c;
    private final long d;
    private final long e;
    private boolean f = false;
    private a g;

    public interface a {
        void onTimerFinished();
    }

    public o(long totalTime, long interval) {
        this.d = totalTime;
        this.e = interval;
        this.c = totalTime;
    }

    /* JADX WARN: Type inference failed for: r0v2, types: [com.sigmob.sdk.base.utils.o$1] */
    public void a() {
        SigmobLogger.d(f3261a, "start", new Object[0]);
        CountDownTimer countDownTimer = this.b;
        if (countDownTimer != null) {
            countDownTimer.cancel();
        }
        this.b = new CountDownTimer(this.c, this.e) { // from class: com.sigmob.sdk.base.utils.o.1
            @Override // android.os.CountDownTimer
            public void onFinish() {
                SigmobLogger.d(o.f3261a, "start#onFinish", new Object[0]);
                o.this.c = 0L;
                if (o.this.g == null) {
                    return;
                }
                o.this.g.onTimerFinished();
            }

            @Override // android.os.CountDownTimer
            public void onTick(long millisUntilFinished) {
                SigmobLogger.d(o.f3261a, "start#onTick: remainingTime = " + Math.round(millisUntilFinished / 1000.0f), new Object[0]);
                o.this.c = millisUntilFinished;
            }
        }.start();
        this.f = false;
    }

    public void a(a listener) {
        this.g = listener;
    }

    public void b() {
        SigmobLogger.d(f3261a, "stop", new Object[0]);
        CountDownTimer countDownTimer = this.b;
        if (countDownTimer != null) {
            countDownTimer.cancel();
        }
        this.c = this.d;
        this.f = false;
    }

    public void c() {
        SigmobLogger.d(f3261a, com.sigmob.sdk.base.common.a.j, new Object[0]);
        CountDownTimer countDownTimer = this.b;
        if (countDownTimer == null || this.f) {
            return;
        }
        countDownTimer.cancel();
        this.f = true;
    }

    public void d() {
        SigmobLogger.d(f3261a, "resume", new Object[0]);
        if (this.f) {
            a();
        }
    }

    public void e() {
        SigmobLogger.d(f3261a, com.sigmob.sdk.mraid.g.b, new Object[0]);
        CountDownTimer countDownTimer = this.b;
        if (countDownTimer != null) {
            countDownTimer.cancel();
            this.b = null;
        }
        this.g = null;
    }

    public long f() {
        return this.c;
    }
}

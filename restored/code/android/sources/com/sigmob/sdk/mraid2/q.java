package com.sigmob.sdk.mraid2;

import java.util.Timer;
import java.util.TimerTask;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class q {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final String f3545a;
    private final int b;
    private final boolean c;
    private final d d;
    private Timer e = null;
    private TimerTask f = null;

    /* JADX INFO: renamed from: com.sigmob.sdk.mraid2.q$1, reason: invalid class name */
    class AnonymousClass1 extends TimerTask {
        AnonymousClass1() {
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void a() {
            q.this.d.e(q.this.f3545a);
        }

        @Override // java.util.TimerTask, java.lang.Runnable
        public void run() {
            if (q.this.d == null) {
                return;
            }
            q.this.d.a().post(new Runnable() { // from class: com.sigmob.sdk.mraid2.q$1$$ExternalSyntheticLambda0
                @Override // java.lang.Runnable
                public final void run() {
                    this.f$0.a();
                }
            });
        }
    }

    public q(d bridge, JSONObject args) {
        this.d = bridge;
        this.b = args.optInt("interval");
        this.c = args.optBoolean("repeats");
        this.f3545a = args.optString("uniqueId");
    }

    private void d() {
        this.e = new Timer();
        this.f = new AnonymousClass1();
    }

    public void a() {
        c();
    }

    public void b() {
        try {
            c();
            d();
            int i = this.b;
            if (i > 0) {
                if (this.c) {
                    this.e.schedule(this.f, i, i);
                } else {
                    this.e.schedule(this.f, i);
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public void c() {
        TimerTask timerTask = this.f;
        if (timerTask != null) {
            timerTask.cancel();
            this.f = null;
        }
        Timer timer = this.e;
        if (timer != null) {
            timer.cancel();
            this.e.purge();
            this.e = null;
        }
    }
}

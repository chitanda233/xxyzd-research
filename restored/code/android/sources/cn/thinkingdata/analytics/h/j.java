package cn.thinkingdata.analytics.h;

import android.os.SystemClock;
import cn.thinkingdata.core.receiver.TDAnalyticsObservable;
import cn.thinkingdata.core.utils.TDLog;
import java.util.Date;

/* JADX INFO: loaded from: classes.dex */
public class j implements d {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private long f119a;
    private long b;
    private final String[] c;
    private final Thread d;

    class a implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final m f120a = new m();

        a() {
        }

        @Override // java.lang.Runnable
        public void run() {
            for (String str : j.this.c) {
                if (this.f120a.a(str, 3000)) {
                    TDLog.i("ThinkingAnalytics.NTP", "[ThinkingData] Info: Time Calibration with NTP(" + str + "), diff = " + this.f120a.a());
                    j.this.f119a = System.currentTimeMillis() + this.f120a.a();
                    j.this.b = SystemClock.elapsedRealtime();
                    TDAnalyticsObservable.getInstance().onTimeCalibrated();
                    return;
                }
            }
        }
    }

    public j(String... strArr) {
        Thread thread = new Thread(new a());
        this.d = thread;
        this.c = strArr;
        thread.start();
    }

    @Override // cn.thinkingdata.analytics.h.d
    public Date a(long j) {
        try {
            this.d.join(com.alipay.sdk.m.y.c.f378a);
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        return this.b == 0 ? new Date((System.currentTimeMillis() - SystemClock.elapsedRealtime()) + j) : new Date((j - this.b) + this.f119a);
    }
}

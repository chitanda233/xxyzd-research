package com.sigmob.sdk.manager;

import android.app.ActivityManager;
import android.content.Context;
import com.byazt.hv.TTDownloadField;
import com.czhj.sdk.logger.SigmobLogger;
import com.sigmob.sdk.base.mta.PointCategory;
import com.sigmob.sdk.base.mta.PointEntityActive;
import com.sigmob.sdk.base.utils.k;
import java.util.List;
import java.util.Timer;
import java.util.TimerTask;
import java.util.UUID;

/* JADX INFO: loaded from: classes3.dex */
public class a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3467a = "AppStatusManager";
    private static volatile a b;
    private volatile boolean c;
    private volatile long d;
    private Timer e;
    private String f;
    private long g;
    private boolean h;

    private a() {
        a(3L);
    }

    public static a a() {
        if (b == null) {
            synchronized (a.class) {
                if (b == null) {
                    b = new a();
                }
            }
        }
        return b;
    }

    public static boolean b() {
        Context contextE = com.sigmob.sdk.b.e();
        if (contextE == null) {
            return false;
        }
        ActivityManager activityManager = (ActivityManager) contextE.getSystemService(TTDownloadField.TT_ACTIVITY);
        String packageName = contextE.getPackageName();
        List<ActivityManager.RunningAppProcessInfo> runningAppProcesses = activityManager.getRunningAppProcesses();
        if (runningAppProcesses == null) {
            return false;
        }
        for (ActivityManager.RunningAppProcessInfo runningAppProcessInfo : runningAppProcesses) {
            if (runningAppProcessInfo.importance == 100 && runningAppProcessInfo.processName.equals(packageName)) {
                return true;
            }
        }
        return false;
    }

    public static boolean c() {
        ActivityManager.RunningAppProcessInfo runningAppProcessInfo = new ActivityManager.RunningAppProcessInfo();
        try {
            ActivityManager.getMyMemoryState(runningAppProcessInfo);
        } catch (Exception e) {
            k.f(f3467a, "isForeground: error = " + e.getMessage(), new Object[0]);
        }
        return runningAppProcessInfo.importance == 100;
    }

    private synchronized void e() {
        SigmobLogger.d(f3467a, "cancelTimer", new Object[0]);
        Timer timer = this.e;
        if (timer == null) {
            return;
        }
        timer.cancel();
        this.e = null;
    }

    public synchronized void a(long interval) {
        try {
            if (interval <= 0) {
                SigmobLogger.e(f3467a, "startAppStatusCheck: interval is unavailable.", new Object[0]);
                return;
            }
            boolean z = interval == this.d;
            SigmobLogger.d(f3467a, "startAppStatusCheck: status = " + this.c + ", interval = " + interval + ", result = " + z, new Object[0]);
            if (this.c && z) {
                return;
            }
            e();
            long j = interval * 1000;
            Timer timer = new Timer();
            this.e = timer;
            timer.schedule(new TimerTask() { // from class: com.sigmob.sdk.manager.a.1
                @Override // java.util.TimerTask, java.lang.Runnable
                public void run() {
                    boolean zC = a.c();
                    if (a.this.h == zC) {
                        return;
                    }
                    if (zC) {
                        a.this.g = System.currentTimeMillis();
                        a.this.f = UUID.randomUUID().toString();
                        PointEntityActive.ActiveTracking(PointCategory.SESSION_START, a.this.f, "0", String.valueOf(a.this.g));
                    } else {
                        long jCurrentTimeMillis = System.currentTimeMillis();
                        PointEntityActive.ActiveTracking(PointCategory.SESSION_END, a.this.f, String.valueOf((jCurrentTimeMillis - a.this.g) / 1000), String.valueOf(jCurrentTimeMillis));
                    }
                    a.this.h = zC;
                }
            }, j, j);
            this.c = true;
            this.d = interval;
            SigmobLogger.d(f3467a, "startAppStatusCheck: status = " + this.c, new Object[0]);
        } catch (Throwable th) {
            throw th;
        }
    }

    public synchronized void d() {
        SigmobLogger.d(f3467a, "stopAppStatusCheck: running = " + this.c, new Object[0]);
        if (this.c) {
            e();
            this.c = false;
        }
    }
}

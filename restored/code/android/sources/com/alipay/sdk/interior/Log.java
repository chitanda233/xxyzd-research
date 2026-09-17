package com.alipay.sdk.interior;

import android.content.Context;
import android.os.SystemClock;
import com.alipay.sdk.m.m.a;
import com.alipay.sdk.m.w.b;
import com.alipay.sdk.m.y.g;

/* JADX INFO: loaded from: classes.dex */
public class Log {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static long f231a;

    public interface ISdkLogCallback {
        void onLogLine(String str);
    }

    public static boolean forcedLogReport(Context context) {
        try {
            b.c().a(context);
            long jElapsedRealtime = SystemClock.elapsedRealtime() / 1000;
            if (jElapsedRealtime - f231a < 600) {
                return false;
            }
            f231a = jElapsedRealtime;
            a.a(context);
            return true;
        } catch (Exception e) {
            g.a(e);
            return false;
        }
    }

    public static void setupLogCallback(ISdkLogCallback iSdkLogCallback) {
        g.a(iSdkLogCallback);
    }
}

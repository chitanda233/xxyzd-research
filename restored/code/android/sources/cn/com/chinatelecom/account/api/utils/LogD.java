package cn.com.chinatelecom.account.api.utils;

import android.util.Log;

/* JADX INFO: loaded from: classes.dex */
public final class LogD {
    public static final int ASSERT = 7;
    public static final int DEBUG = 3;
    public static final int ERROR = 6;
    public static final int INFO = 4;
    private static final boolean LOGD_ENABLE = true;
    private static final boolean LOGE_ENABLE = true;
    private static final boolean LOGI_ENABLE = true;
    private static final boolean LOGV_ENABLE = true;
    private static final boolean LOGW_ENABLE = true;
    private static final boolean LOG_SWITCH = true;
    private static final long M2 = 2097152;
    private static final String TAG = "LOG";
    public static final int VERBOSE = 2;
    public static final int WARN = 5;

    private LogD() {
    }

    public static boolean isLoggable(String str, int i) {
        return Log.isLoggable(str, i);
    }

    public static int v(String str, String str2) {
        return Log.v(str, str2);
    }

    public static int v(String str) {
        return Log.v(TAG, str);
    }

    public static int v(String str, String str2, Throwable th) {
        return Log.v(str, str2, th);
    }

    public static int d(String str, String str2) {
        return Log.d(str, str2);
    }

    public static int d(String str) {
        return Log.d(TAG, str);
    }

    public static int d(String str, String str2, Throwable th) {
        return Log.d(str, str2, th);
    }

    public static int i(String str, String str2) {
        return Log.i(str, str2);
    }

    public static int i(String str) {
        return Log.i(TAG, str);
    }

    public static int i(String str, String str2, Throwable th) {
        return Log.i(str, str2, th);
    }

    public static int w(String str, String str2) {
        return Log.w(str, str2);
    }

    public static int w(String str) {
        return Log.w(TAG, str);
    }

    public static int w(String str, String str2, Throwable th) {
        return Log.w(str, str2, th);
    }

    public static int w(String str, Throwable th) {
        return Log.w(str, th);
    }

    public static int e(String str, String str2) {
        return Log.e(str, str2);
    }

    public static int e(String str) {
        return Log.e(TAG, str);
    }

    public static int e(String str, String str2, Throwable th) {
        return Log.e(str, str2, th);
    }

    public static String getStackTraceString(Throwable th) {
        return Log.getStackTraceString(th);
    }

    public static int println(int i, String str, String str2) {
        return Log.println(i, str, str2);
    }
}

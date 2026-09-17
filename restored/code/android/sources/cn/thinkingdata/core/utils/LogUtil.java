package cn.thinkingdata.core.utils;

import android.util.Log;

/* JADX INFO: loaded from: classes.dex */
public class LogUtil {
    private static OnLogPrintListener mListener;

    public interface OnLogPrintListener {
        void onLogPrint(String str, String str2);
    }

    public static void d(String str, String str2) {
        Log.d(str, str2);
        handleLogListener(str, str2);
    }

    public static void e(String str, String str2) {
        Log.e(str, str2);
        handleLogListener(str, str2);
    }

    public static void e(String str, String str2, Throwable th) {
        Log.e(str, str2, th);
        handleLogListener(str, str2);
    }

    private static void handleLogListener(String str, String str2) {
        OnLogPrintListener onLogPrintListener = mListener;
        if (onLogPrintListener != null) {
            onLogPrintListener.onLogPrint(str, str2);
        }
    }

    public static void i(String str, String str2) {
        if (str2.length() > 4000) {
            largeLog(str, str2);
        } else {
            Log.i(str, str2);
        }
        handleLogListener(str, str2);
    }

    public static void i(String str, String str2, Throwable th) {
        Log.i(str, str2, th);
        handleLogListener(str, str2);
    }

    public static void i(String str, Throwable th) {
        try {
            Log.i(str, "", th);
            if (th != null) {
                handleLogListener(str, th.getMessage());
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    private static void largeLog(String str, String str2) {
        while (str2.length() > 4000) {
            Log.i(str, str2.substring(0, 4000) + "");
            str2 = str2.substring(4000) + "";
        }
        Log.i(str, str2);
    }

    public static void setLogPrintListener(OnLogPrintListener onLogPrintListener) {
        mListener = onLogPrintListener;
    }

    public static void v(String str, String str2) {
        Log.v(str, str2);
        handleLogListener(str, str2);
    }

    public static void v(String str, String str2, Throwable th) {
        Log.v(str, str2, th);
        handleLogListener(str, str2);
    }

    public static void w(String str, String str2) {
        Log.w(str, str2);
        handleLogListener(str, str2);
    }

    public static void w(String str, String str2, Throwable th) {
        Log.w(str, str2, th);
        handleLogListener(str, str2);
    }
}

package cn.thinkingdata.core.utils;

/* JADX INFO: loaded from: classes.dex */
public class TDLog {
    public static volatile boolean mEnableLog = false;
    static volatile boolean mEnableLogInner = false;

    public static void d(String str, String str2) {
        if (mEnableLog) {
            LogUtil.d(str, str2);
        }
    }

    public static void e(String str, String str2) {
        if (mEnableLog) {
            LogUtil.e(str, str2);
        }
    }

    public static void e(String str, String str2, Throwable th) {
        if (mEnableLog) {
            LogUtil.e(str, str2, th);
        }
    }

    public static boolean getEnableLog() {
        return mEnableLog;
    }

    public static void i(String str, String str2) {
        if (mEnableLog) {
            LogUtil.i(str, str2);
        }
    }

    public static void i(String str, String str2, Throwable th) {
        if (mEnableLog) {
            LogUtil.i(str, str2, th);
        }
    }

    public static void i(String str, Throwable th) {
        if (mEnableLog) {
            LogUtil.i(str, "", th);
        }
    }

    public static void setEnableLog(boolean z) {
        if (mEnableLogInner) {
            z = true;
        }
        mEnableLog = z;
    }

    public static void setEnableLogInner(boolean z) {
        mEnableLogInner = z;
    }

    public static void v(String str, String str2) {
        if (mEnableLog) {
            LogUtil.v(str, str2);
        }
    }

    public static void v(String str, String str2, Throwable th) {
        if (mEnableLog) {
            LogUtil.v(str, str2, th);
        }
    }

    public static void w(String str, String str2) {
        if (mEnableLog) {
            LogUtil.w(str, str2);
        }
    }

    public static void w(String str, String str2, Throwable th) {
        if (mEnableLog) {
            LogUtil.w(str, str2, th);
        }
    }
}

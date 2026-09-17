package com.kwad.sdk.utils;

import android.app.ActivityManager;
import android.app.Application;
import android.content.Context;
import android.os.Build;
import android.os.Process;
import android.text.TextUtils;
import com.byazt.hv.TTDownloadField;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class ba {
    private static String bpW = "";
    private static volatile Boolean bpX;

    public static String getProcessName(Context context) {
        if (!TextUtils.isEmpty(bpW)) {
            return bpW;
        }
        String strWh = Wh();
        bpW = strWh;
        if (!TextUtils.isEmpty(strWh)) {
            return bpW;
        }
        String strWi = Wi();
        bpW = strWi;
        if (!TextUtils.isEmpty(strWi)) {
            return bpW;
        }
        String strDL = dL(context);
        bpW = strDL;
        return strDL;
    }

    private static String Wh() {
        return Build.VERSION.SDK_INT >= 28 ? Application.getProcessName() : "";
    }

    private static String Wi() {
        try {
            Object objCallStaticMethod = ab.callStaticMethod(Class.forName("android.app.ActivityThread", false, Application.class.getClassLoader()), "currentProcessName", new Object[0]);
            return objCallStaticMethod instanceof String ? (String) objCallStaticMethod : "";
        } catch (Throwable th) {
            th.printStackTrace();
            return "";
        }
    }

    private static String dL(Context context) {
        List<ActivityManager.RunningAppProcessInfo> runningAppProcesses;
        if (context == null) {
            return "";
        }
        int iMyPid = Process.myPid();
        ActivityManager activityManager = (ActivityManager) context.getSystemService(TTDownloadField.TT_ACTIVITY);
        if (activityManager != null && (runningAppProcesses = activityManager.getRunningAppProcesses()) != null) {
            for (ActivityManager.RunningAppProcessInfo runningAppProcessInfo : runningAppProcesses) {
                if (runningAppProcessInfo.pid == iMyPid) {
                    return runningAppProcessInfo.processName;
                }
            }
        }
        return "";
    }

    public static boolean isInMainProcess(Context context) {
        if (bpX == null) {
            String processName = getProcessName(context);
            bpX = Boolean.valueOf(!TextUtils.isEmpty(processName) && processName.equals(context.getPackageName()));
        }
        return bpX.booleanValue();
    }
}

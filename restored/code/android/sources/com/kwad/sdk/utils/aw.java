package com.kwad.sdk.utils;

import android.app.AppOpsManager;
import android.content.Context;
import android.os.Binder;
import android.os.Process;
import android.provider.Settings;
import cn.thinkingdata.core.router.TRouterMap;
import java.lang.reflect.Method;
import java.util.HashMap;
import java.util.HashSet;
import java.util.Map;
import java.util.Set;

/* JADX INFO: loaded from: classes3.dex */
public final class aw {
    private static Map<String, Integer> bpP;
    private static Set<String> bpQ;
    private static Method bpR;

    static {
        HashSet hashSet = new HashSet();
        bpQ = hashSet;
        hashSet.add("android.permission.REQUEST_INSTALL_PACKAGES");
        bpQ.add("android.permission.WRITE_SETTINGS");
        bpQ.add("android.permission.SYSTEM_ALERT_WINDOW");
    }

    public static int aA(Context context, String str) {
        int iAB;
        if (bpP == null) {
            h(aa.dh(context));
        }
        if (bpQ.contains(str) && (iAB = aB(context, str)) != -2) {
            return iAB;
        }
        int iAC = aC(context, str);
        if (iAC != -2) {
            return iAC;
        }
        try {
            return context.checkPermission(str, Process.myPid(), Process.myUid());
        } catch (Throwable unused) {
            return iAC;
        }
    }

    /* JADX WARN: Can't fix incorrect switch cases order, some code will duplicate */
    private static int aB(Context context, String str) {
        str.hashCode();
        switch (str) {
            case "android.permission.WRITE_SETTINGS":
                try {
                    if (Settings.System.canWrite(context)) {
                        return 0;
                    }
                    return -1;
                } catch (Throwable unused) {
                    break;
                }
                break;
            case "android.permission.SYSTEM_ALERT_WINDOW":
                try {
                    if (Settings.canDrawOverlays(context)) {
                        return 0;
                    }
                    return -1;
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                    break;
                }
                break;
            case "android.permission.REQUEST_INSTALL_PACKAGES":
                if (aa.dg(context)) {
                    return 0;
                }
                return -1;
            default:
                return -2;
        }
    }

    private static int aC(Context context, String str) {
        if (bpP == null || str == null || !bpP.containsKey(str)) {
            return -2;
        }
        try {
            Integer num = bpP.get(str);
            if (num == null) {
                return -2;
            }
            if (bpR == null) {
                Method declaredMethod = AppOpsManager.class.getDeclaredMethod("checkOp", Integer.TYPE, Integer.TYPE, String.class);
                bpR = declaredMethod;
                declaredMethod.setAccessible(true);
            }
            return ((Integer) bpR.invoke((AppOpsManager) context.getSystemService("appops"), num, Integer.valueOf(Binder.getCallingUid()), context.getPackageName())).intValue() == 0 ? 0 : -1;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
            return 0;
        }
    }

    private static void h(String[] strArr) {
        if (strArr == null) {
            return;
        }
        bpP = new HashMap();
        for (String str : strArr) {
            try {
                int iIntValue = ((Integer) ab.c(AppOpsManager.class, "OP_" + hW(str))).intValue();
                if (iIntValue >= 0) {
                    bpP.put(str, Integer.valueOf(iIntValue));
                }
            } catch (Throwable unused) {
            }
        }
    }

    private static String hW(String str) {
        if (str == null) {
            return null;
        }
        int iLastIndexOf = str.lastIndexOf(TRouterMap.DOT);
        if (iLastIndexOf < 0) {
            return str;
        }
        try {
            return str.substring(iLastIndexOf + 1);
        } catch (Exception unused) {
            return str;
        }
    }

    public static boolean dJ(Context context) {
        int i;
        try {
            i = Settings.Secure.getInt(context.getContentResolver(), "accessibility_enabled");
        } catch (Throwable unused) {
            i = 0;
        }
        return i == 1;
    }
}

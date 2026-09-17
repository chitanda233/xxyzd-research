package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;
import android.net.wifi.WifiManager;
import android.os.SystemClock;
import android.provider.Settings;
import android.telephony.SubscriptionInfo;
import android.telephony.SubscriptionManager;
import android.telephony.TelephonyManager;
import cn.com.chinatelecom.account.api.CtAuth;
import java.lang.reflect.Method;
import java.util.Arrays;

/* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.p, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes2.dex */
public abstract class AbstractC0610p {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static volatile boolean f1993a = true;
    private static volatile int b = -2;
    private static volatile long c = 0;
    private static volatile String d = "default_changeKey";
    private static long e = 0;
    private static int f = -1;
    static int g = -1;

    private static int a(int i) {
        switch (i) {
            case 1:
            case 2:
            case 4:
            case 7:
            case 11:
                return 2;
            case 3:
            case 5:
            case 6:
            case 8:
            case 9:
            case 10:
            case 12:
            case 14:
            case 15:
                return 3;
            case 13:
                return 4;
            default:
                return 0;
        }
    }

    public static boolean a(Context context) {
        boolean z;
        try {
            if (context == null) {
                Q.a("CheckAuthEnableShanYanLogger", "checkAuthEnable context is null");
                return false;
            }
            Context applicationContext = context.getApplicationContext();
            boolean zM = m(applicationContext);
            boolean zL = l(applicationContext);
            boolean zG = g(applicationContext);
            int iJ = j(applicationContext);
            if (zM && !zL && zG) {
                String strB = C0616v.g().b(applicationContext);
                if (strB != null && !strB.equals("Unknown_Operator") && iJ != 0) {
                    Q.a("CheckAuthEnableShanYanLogger", "checkAuthEnable network Type", Integer.valueOf(iJ), "netOperatorName", strB);
                    if ((!"CUCC".equals(strB) || iJ < 3) && ((!"CTCC".equals(strB) || iJ < 4) && iJ < 2)) {
                    }
                    Q.a("CheckAuthEnableShanYanLogger", "checkAuthEnable isAuthEnable", Boolean.valueOf(z));
                    return z;
                }
                z = true;
                Q.a("CheckAuthEnableShanYanLogger", "checkAuthEnable isAuthEnable", Boolean.valueOf(z));
                return z;
            }
            Q.a("CheckAuthEnableShanYanLogger", "checkAuthEnable simStateReady", Boolean.valueOf(zM), "airplaneMode", Boolean.valueOf(zL), "mobileDataEnabled", Boolean.valueOf(zG), "networkType", Integer.valueOf(iJ));
            z = false;
            Q.a("CheckAuthEnableShanYanLogger", "checkAuthEnable isAuthEnable", Boolean.valueOf(z));
            return z;
        } catch (Throwable th) {
            Q.d("ExceptionShanYanLogger", "checkAuthEnable Exception", th);
            return true;
        }
    }

    public static boolean b(Context context) {
        if (AbstractC0606l.E) {
            return AbstractC0601g.a(context, com.kuaishou.weapon.p0.g.c);
        }
        return false;
    }

    /* JADX WARN: Code duplicated, block: B:12:0x0028  */
    public static boolean c(Context context) {
        boolean zIsWifiEnabled;
        if (!AbstractC0606l.H) {
            return true;
        }
        if (context != null) {
            try {
                WifiManager wifiManager = (WifiManager) context.getSystemService("wifi");
                if (wifiManager != null) {
                    zIsWifiEnabled = wifiManager.isWifiEnabled();
                } else {
                    zIsWifiEnabled = false;
                }
            } catch (Exception unused) {
                Q.d("CheckAuthEnableShanYanLogger", "is wifi enable Exception", Boolean.FALSE);
            }
        } else {
            zIsWifiEnabled = false;
        }
        Q.a("CheckAuthEnableShanYanLogger", "is wifi enable", Boolean.valueOf(zIsWifiEnabled));
        return zIsWifiEnabled;
    }

    public static boolean d(Context context, String str) {
        b = d(context);
        if (b == -1) {
            f1993a = true;
            return true;
        }
        int iA = p0.a(context, str, -2);
        if (iA == -2 || b != iA) {
            f1993a = true;
            p0.b(context, str, b);
        } else {
            f1993a = false;
        }
        Q.a("CheckAuthEnableShanYanLogger", "Sub ID changed", "key", str, "oldSubId", Integer.valueOf(iA), "newSubId", Integer.valueOf(b), "isChanged", Boolean.valueOf(f1993a));
        return false;
    }

    private static int e(Context context) {
        Integer numA = a(context, 0);
        int iIntValue = numA.intValue();
        try {
            if (!b(context)) {
                return iIntValue;
            }
            Method declaredMethod = Class.forName("android.telephony.SubscriptionManager").getDeclaredMethod("getSubId", Integer.TYPE);
            declaredMethod.setAccessible(true);
            int[] iArr = (int[]) declaredMethod.invoke(null, numA);
            return (iArr == null || iArr.length <= 0) ? iIntValue : iArr[0];
        } catch (Exception e2) {
            Q.d("CheckAuthEnableShanYanLogger", "data sub by subid Exception_e", e2);
            return iIntValue;
        }
    }

    private static String f(Context context) {
        TelephonyManager telephonyManager;
        String networkOperator = null;
        try {
            telephonyManager = (TelephonyManager) context.getSystemService("phone");
            if (telephonyManager != null) {
                try {
                    networkOperator = telephonyManager.getSimOperator();
                } catch (Throwable th) {
                    th = th;
                    Q.d("ExceptionShanYanLogger", "sim operator Exception_e", th);
                }
            }
        } catch (Throwable th2) {
            th = th2;
            telephonyManager = null;
        }
        if (AbstractC0600f.a(networkOperator)) {
            try {
                Integer numA = a(context, 1);
                if (telephonyManager != null && numA.intValue() != -1) {
                    Method declaredMethod = Class.forName("android.telephony.TelephonyManager").getDeclaredMethod("getNetworkOperatorForPhone", Integer.TYPE);
                    declaredMethod.setAccessible(true);
                    networkOperator = (String) declaredMethod.invoke(telephonyManager, numA);
                }
            } catch (Throwable th3) {
                Q.d("ExceptionShanYanLogger", "network operator for phone  Exception_e", th3);
            }
        }
        if (AbstractC0600f.a(networkOperator) && telephonyManager != null) {
            try {
                networkOperator = telephonyManager.getNetworkOperator();
            } catch (Throwable th4) {
                Q.d("ExceptionShanYanLogger", "network operator Exception_e", th4);
            }
        }
        Q.a("CheckAuthEnableShanYanLogger", "default sim card  operator", networkOperator);
        return networkOperator;
    }

    public static boolean g(Context context) {
        boolean zIsMobileDataEnabled;
        if (!AbstractC0606l.H) {
            return true;
        }
        if (context != null) {
            try {
                zIsMobileDataEnabled = CtAuth.getInstance().isMobileDataEnabled();
            } catch (Throwable th) {
                Q.d("ExceptionShanYanLogger", "getMobileDataEnabled Exception_e", th);
                zIsMobileDataEnabled = true;
            }
        } else {
            zIsMobileDataEnabled = true;
        }
        Q.a("CheckAuthEnableShanYanLogger", "mobile data enable  ", Boolean.valueOf(zIsMobileDataEnabled));
        return zIsMobileDataEnabled;
    }

    private static int h(Context context) {
        int iIntValue;
        if (context != null) {
            try {
                TelephonyManager telephonyManager = (TelephonyManager) context.getSystemService("phone");
                Method declaredMethod = Class.forName("android.telephony.TelephonyManager").getDeclaredMethod("getNetworkType", null);
                declaredMethod.setAccessible(true);
                iIntValue = ((Integer) declaredMethod.invoke(telephonyManager, null)).intValue();
            } catch (Throwable th) {
                Q.d("ExceptionShanYanLogger", "get Network2 Exception_e", th);
                iIntValue = -1;
            }
        } else {
            iIntValue = -1;
        }
        Q.a("CheckAuthEnableShanYanLogger", "net type ", Integer.valueOf(iIntValue));
        return iIntValue;
    }

    public static String i(Context context) {
        try {
            String strB = b(f(context));
            Q.a("CheckAuthEnableShanYanLogger", "network Operator Type", strB);
            return strB;
        } catch (Throwable th) {
            Q.d("ExceptionShanYanLogger", "network Operator Exception_e", th);
            return "Unknown_Operator";
        }
    }

    public static int j(Context context) {
        NetworkInfo activeNetworkInfo;
        int iIntValue;
        if (!AbstractC0606l.H) {
            return 0;
        }
        try {
            int iB = b(context) ? b(c(context, d(context))) : 0;
            if (iB == 0 && (iIntValue = a(context, 1).intValue()) >= 0) {
                iB = b(context, iIntValue);
            }
            if (iB == 0) {
                int iH = h(context);
                int iB2 = b(iH);
                Q.a("CheckAuthEnableShanYanLogger", "get NetworkType", Integer.valueOf(iH), "network", Integer.valueOf(iB2));
                iB = iB2;
            }
            if (context != null && iB == 0 && (activeNetworkInfo = ((ConnectivityManager) context.getApplicationContext().getSystemService("connectivity")).getActiveNetworkInfo()) != null && activeNetworkInfo.isConnected() && activeNetworkInfo.getType() == 0) {
                iB = a(activeNetworkInfo.getSubtype());
                Q.a("CheckAuthEnableShanYanLogger", "get Network Subtype", "network", Integer.valueOf(iB));
            }
            Q.a("CheckAuthEnableShanYanLogger", "get Network network", Integer.valueOf(iB));
            return iB;
        } catch (Throwable th) {
            Q.d("CheckAuthEnableShanYanLogger", "get Network Exception_e", th);
            return 0;
        }
    }

    public static int k(Context context) {
        int i;
        try {
            String strA = a(context, "gsm.sim.state");
            String strA2 = a(context, "gsm.sim.state.2");
            if (!AbstractC0600f.a(strA2)) {
                strA = strA + "," + strA2;
            }
            String[] strArrSplit = AbstractC0600f.a(strA) ? null : strA.split(",");
            Q.a("CheckAuthEnableShanYanLogger", "sim state", Arrays.toString(strArrSplit));
            if (strArrSplit != null) {
                i = 0;
                for (String str : strArrSplit) {
                    try {
                        if (!"ABSENT".equalsIgnoreCase(str) && !"NOT_READY".equalsIgnoreCase(str)) {
                            i++;
                        }
                    } catch (Exception e2) {
                        e = e2;
                        Q.a("CheckAuthEnableShanYanLogger", "simCardCount Exception", e);
                        Q.a("CheckAuthEnableShanYanLogger", "current sim card count", Integer.valueOf(i));
                        return i;
                    }
                }
            } else {
                int iD = d(context, 0);
                int iD2 = d(context, 1);
                Q.a("CheckAuthEnableShanYanLogger", "simState1", Integer.valueOf(iD), "statesLength", Integer.valueOf(iD2));
                i = iD == 5 ? 1 : 0;
                if (iD2 == 5) {
                    i++;
                }
            }
        } catch (Exception e3) {
            e = e3;
            i = 0;
        }
        Q.a("CheckAuthEnableShanYanLogger", "current sim card count", Integer.valueOf(i));
        return i;
    }

    private static boolean l(Context context) {
        boolean z;
        try {
            z = Settings.System.getInt(context.getContentResolver(), "airplane_mode_on", 0) == 1;
        } catch (Throwable th) {
            Q.d("CheckAuthEnableShanYanLogger", "isAirplaneMode Exception_e", th);
        }
        Q.a("CheckAuthEnableShanYanLogger", "airplane mode  ", Boolean.valueOf(z));
        return z;
    }

    private static boolean m(Context context) {
        if (!AbstractC0606l.I) {
            return true;
        }
        try {
            C0616v.g().e(context);
        } catch (Throwable th) {
            Q.d("CheckAuthEnableShanYanLogger", "isSimStateReady Exception_e", th);
        }
        Q.a("CheckAuthEnableShanYanLogger", "sim card  ready", true);
        return true;
    }

    public static boolean b(Context context, String str) {
        long jCurrentTimeMillis = System.currentTimeMillis();
        long j = jCurrentTimeMillis - c;
        Q.a("CheckAuthEnableShanYanLogger", "intervalTime", Long.valueOf(j), Long.valueOf(c), d, str);
        if (j < 500 && d.equals(str)) {
            f1993a = false;
            return f1993a;
        }
        c = jCurrentTimeMillis;
        d = str;
        try {
            if (!c(context, str) && !d(context, str)) {
                return f1993a;
            }
            return f1993a;
        } catch (Exception e2) {
            Q.d("CheckAuthEnableShanYanLogger", "data sim card changed Exception", e2, Boolean.valueOf(f1993a));
            return f1993a;
        }
    }

    public static boolean c(Context context, String str) {
        int iA = p0.a(context, "cl_jm_f9", -1);
        int iE = C0616v.g().e(context);
        if (iE <= 0) {
            f1993a = true;
            return true;
        }
        if (iA == iE) {
            return false;
        }
        f1993a = true;
        p0.b(context, "cl_jm_f9", iE);
        Q.a("CheckAuthEnableShanYanLogger", "SIM count changed", "key", str, "lastCount", Integer.valueOf(iA), "currentCount", Integer.valueOf(iE), "isChanged", Boolean.valueOf(f1993a));
        return true;
    }

    public static int d(Context context) {
        try {
            if (!AbstractC0606l.I) {
                return f;
            }
            long jElapsedRealtime = SystemClock.elapsedRealtime();
            long j = e;
            long j2 = jElapsedRealtime - j;
            boolean z = j2 > com.alipay.sdk.m.y.c.f378a;
            boolean z2 = jElapsedRealtime < j;
            if (z || z2) {
                e = SystemClock.elapsedRealtime();
                int iA = a();
                f = iA;
                if (-1 == iA && C0616v.g().e(context) > 0) {
                    f = e(context);
                }
            }
            Q.a("CheckAuthEnableShanYanLogger", "current data sub ", Integer.valueOf(f), Long.valueOf(j2), Boolean.valueOf(z), Boolean.valueOf(z2));
            return f;
        } catch (Exception e2) {
            Q.d("CheckAuthEnableShanYanLogger", "data sub  Exception_e", e2);
        }
    }

    private static String b(String str) {
        str.hashCode();
        str.hashCode();
        switch (str) {
            case "46000":
            case "46002":
            case "46004":
            case "46007":
            case "46008":
            case "46013":
                return "CMCC";
            case "46001":
            case "46006":
            case "46009":
            case "46010":
                return "CUCC";
            case "46003":
            case "46005":
            case "46011":
            case "46012":
                return "CTCC";
            default:
                return "Unknown_Operator";
        }
    }

    private static int c(Context context, int i) {
        if (context == null || i == -1) {
            return -1;
        }
        try {
            TelephonyManager telephonyManager = (TelephonyManager) context.getSystemService("phone");
            Method declaredMethod = Class.forName("android.telephony.TelephonyManager").getDeclaredMethod("getNetworkType", Integer.TYPE);
            declaredMethod.setAccessible(true);
            return ((Integer) declaredMethod.invoke(telephonyManager, Integer.valueOf(i))).intValue();
        } catch (Throwable th) {
            Q.d("CheckAuthEnableShanYanLogger", "get NetType BySubId Exception_e", th);
            return -1;
        }
    }

    /* JADX WARN: Code duplicated, block: B:16:0x0073 A[Catch: all -> 0x0092, TryCatch #0 {all -> 0x0092, blocks: (B:3:0x0005, B:7:0x0036, B:16:0x0073, B:19:0x0079, B:21:0x0085, B:15:0x0068, B:10:0x0045, B:12:0x0060), top: B:27:0x0005, inners: #1 }] */
    /* JADX WARN: Code duplicated, block: B:18:0x0077 A[ADDED_TO_REGION] */
    public static Integer a(Context context, int i) {
        Method method;
        try {
            int iE = C0616v.g().e(context);
            boolean zB = b(context, "defaultdata_sub");
            Q.a("CheckAuthEnableShanYanLogger", "slot index", Integer.valueOf(i), Integer.valueOf(iE), Boolean.valueOf(zB));
            if (iE > 0 && (i == 0 || zB)) {
                SubscriptionManager subscriptionManager = (SubscriptionManager) context.getSystemService("telephony_subscription_service");
                boolean zB2 = b(context);
                if (zB2) {
                    try {
                        Q.a("CheckAuthEnableShanYanLogger", "get default data SubscriptionInfo by system");
                        SubscriptionInfo subscriptionInfo = (SubscriptionInfo) subscriptionManager.getClass().getMethod("getDefaultDataSubscriptionInfo", null).invoke(subscriptionManager, null);
                        if (subscriptionInfo != null) {
                            g = subscriptionInfo.getSimSlotIndex();
                            if (g < 0 && zB2 && (method = subscriptionManager.getClass().getMethod("getDefaultDataPhoneId", null)) != null) {
                                g = ((Integer) method.invoke(subscriptionManager, null)).intValue();
                            }
                        } else if (g < 0) {
                            g = ((Integer) method.invoke(subscriptionManager, null)).intValue();
                        }
                    } catch (Throwable th) {
                        Q.d("CheckAuthEnableShanYanLogger", ">= 22 slot index  Exception_e", th);
                    }
                } else if (g < 0) {
                    g = ((Integer) method.invoke(subscriptionManager, null)).intValue();
                }
            }
        } catch (Throwable th2) {
            Q.d("CheckAuthEnableShanYanLogger", "slot index Exception_e", th2);
        }
        Q.a("CheckAuthEnableShanYanLogger", "default data slot index", Integer.valueOf(g));
        return Integer.valueOf(g);
    }

    private static int d(Context context, int i) {
        int iIntValue;
        if (context != null) {
            try {
                TelephonyManager telephonyManager = (TelephonyManager) context.getSystemService("phone");
                Method declaredMethod = TelephonyManager.class.getDeclaredMethod("getSimState", Integer.TYPE);
                declaredMethod.setAccessible(true);
                Integer num = (Integer) declaredMethod.invoke(telephonyManager, Integer.valueOf(i));
                iIntValue = num.intValue();
                Q.a("CheckAuthEnableShanYanLogger", "data sim card simState invoke", num);
            } catch (Throwable th) {
                Q.d("CheckAuthEnableShanYanLogger", "get sim card  Exception_e", th);
                return 1;
            }
        } else {
            iIntValue = 1;
        }
        Q.a("CheckAuthEnableShanYanLogger", "sim card id", Integer.valueOf(i), "simState", Integer.valueOf(iIntValue));
        return iIntValue;
    }

    private static int b(int i) {
        Q.a("CheckAuthEnableShanYanLogger", "getNetwork1 networkType", Integer.valueOf(i));
        switch (i) {
            case 1:
            case 2:
            case 4:
            case 7:
            case 11:
            case 16:
                return 2;
            case 3:
            case 5:
            case 6:
            case 8:
            case 9:
            case 10:
            case 12:
            case 14:
            case 15:
            case 17:
                return 3;
            case 13:
            case 18:
            case 19:
                return 4;
            case 20:
                return 5;
            default:
                return 0;
        }
    }

    private static int b(Context context, int i) {
        if (i < 0) {
            return 0;
        }
        try {
            String strA = a(context, "gsm.network.type");
            String strA2 = a(context, "gsm.network.type.2");
            if (!AbstractC0600f.a(strA2)) {
                strA = strA + "," + strA2;
            }
            String str = null;
            String[] strArrSplit = AbstractC0600f.a(strA) ? null : strA.split(",");
            if (strArrSplit != null && strArrSplit.length > i) {
                str = strArrSplit[i];
            }
            Q.a("CheckAuthEnableShanYanLogger", "getNetworkType GSMNetwork", "network", str);
            return a(str);
        } catch (Throwable th) {
            Q.d("CheckAuthEnableShanYanLogger", "getGSMNetwork Exception_e", th);
            return 0;
        }
    }

    private static int a() {
        int iIntValue = -1;
        try {
            Method declaredMethod = Class.forName("android.telephony.SubscriptionManager").getDeclaredMethod("getDefaultDataSubscriptionId", null);
            declaredMethod.setAccessible(true);
            iIntValue = ((Integer) declaredMethod.invoke(null, null)).intValue();
            Q.a("CheckAuthEnableShanYanLogger", "default data sub scriptionId", Integer.valueOf(iIntValue));
            return iIntValue;
        } catch (Throwable th) {
            Q.d("CheckAuthEnableShanYanLogger", "default data sub scriptionId Exception_e", th);
            return iIntValue;
        }
    }

    private static int a(String str) {
        if (AbstractC0600f.a(str)) {
            return 0;
        }
        String lowerCase = str.toLowerCase();
        if (lowerCase.contains("lte") || lowerCase.contains("iwlan")) {
            return 4;
        }
        if (lowerCase.contains("nr")) {
            return 5;
        }
        if (lowerCase.contains("unknown")) {
            return 0;
        }
        if (lowerCase.contains("gprs") || lowerCase.contains("edge") || lowerCase.contains("cdma") || lowerCase.contains("1xrtt") || lowerCase.contains("iden")) {
            return 2;
        }
        return (lowerCase.contains("umts") || lowerCase.contains("evdo") || lowerCase.contains("hsdpa") || lowerCase.contains("hsupa") || lowerCase.contains("hspa") || lowerCase.contains("ehrpd") || lowerCase.contains("scdma")) ? 3 : 0;
    }

    private static String a(Context context, String str) {
        String str2;
        if (context != null) {
            try {
                Class<?> clsLoadClass = context.getClassLoader().loadClass("android.os.SystemProperties");
                str2 = (String) clsLoadClass.getMethod("get", String.class).invoke(clsLoadClass, new String(str));
            } catch (Throwable th) {
                Q.d("CheckAuthEnableShanYanLogger", "get GMS Type Exception_e", th);
                str2 = "";
            }
        } else {
            str2 = "";
        }
        Q.a("CheckAuthEnableShanYanLogger", "get gms  type", str, "gmsType", str2);
        return str2;
    }
}

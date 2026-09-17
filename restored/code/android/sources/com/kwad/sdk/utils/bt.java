package com.kwad.sdk.utils;

import android.app.ActivityManager;
import android.content.Context;
import android.graphics.Insets;
import android.graphics.Rect;
import android.media.AudioManager;
import android.net.wifi.WifiInfo;
import android.net.wifi.WifiManager;
import android.os.BatteryManager;
import android.os.Build;
import android.os.Environment;
import android.os.LocaleList;
import android.os.Process;
import android.os.SystemClock;
import android.provider.Settings;
import android.system.Os;
import android.system.StructStat;
import android.telephony.SubscriptionManager;
import android.telephony.TelephonyManager;
import android.text.TextUtils;
import android.util.DisplayMetrics;
import android.util.Pair;
import android.view.WindowInsets;
import android.view.WindowManager;
import android.view.WindowMetrics;
import android.view.accessibility.AccessibilityManager;
import cn.thinkingdata.core.router.TRouterMap;
import com.byazt.hv.TTDownloadField;
import com.bykv.vk.component.ttvideo.player.MediaFormat;
import com.kwad.sdk.service.ServiceProvider;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.net.Inet4Address;
import java.net.InetAddress;
import java.net.NetworkInterface;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Enumeration;
import java.util.List;
import java.util.Locale;
import java.util.Random;

/* JADX INFO: loaded from: classes3.dex */
public final class bt {
    private static String bqP = null;
    private static String bqQ = "";
    private static boolean bqR = false;
    private static String bqS = "";
    private static String bqT = "";
    private static int bqU = 0;
    private static boolean bqV = false;
    private static int bqW = 0;
    private static boolean bqX = false;
    private static String brc;
    private static String brd;
    private static int brl;
    private static long brm;
    private static final String[] bqY = {"", ""};
    private static String bqZ = "";
    private static String bra = "";
    private static String brb = "";
    private static int bre = -1;
    private static boolean brf = false;
    private static boolean brg = false;
    private static boolean brh = false;
    private static boolean bri = false;
    private static boolean brj = false;
    private static boolean brk = false;
    private static String brn = "";
    private static String bro = "";
    public static String brp = "";
    private static final List<String> brq = Arrays.asList("a5f5faddde9e9f02", "8e17f7422b35fbea", "b88c3c236923d9d9", "cb36bf76cca443d0", "5d4e49ed381836c5", "cffa38e9136f93e9", "62bd2daa59ea0173", "b7aad49a2d5bc5d9", "f2138912c5e5dd5c", "330a1e81a2bf9f31", "59c0f432ccbef844", "521376155e535f39", "aa5ec6ce14abd680", "5522a09bb500d82f", "6dfe4a96800edfb4", "ecc9a2dded8cdf72", "399f868043955b11", "34dc327c00dbff94", "d1b4e3862c309f8b", "68bdbf71f863ccac", "01558dd995085a35", "351174200a06da52", "fa0988506c76ff4b", "8eb8ef823312c61a", "a72e81be65c4638b", "416d15a015c8f324", "474086ea2d737519", "befdddf908c8d749", "780ee58a6f57aab6", "cfe86fa07cae3601", "704ff4d1534f0ff4", "9298b9e9bbd7cdea", "7b634c42f236c6e8", "11eacf22b9ceab7d", "2941a4f39eec5864", "87d134dc5ba45550", "fdd2313bb1750eb9", "6560ef232d8424bb", "5d876286e1064482", "f66fefb916f4962d", "7baf82d0ac49f596", "57748921d8d88ed4", "120cd57f1a50b8f5", "e164f9610ddd9fc8", "6256f0e8da6389de", "bcb22df712476416", "714fa9aff63f7adb", "cb8252e4da7cf610", "e18f649aa80e140c", "966790a9db5ea8d8", "e1769e681af901dd", "d23f2574a60964a4", "d717e6298d3c9cb2", "f5ea5e8ba730864e", "a8a0a223d1a42232", "6675a4f231f5c8db", "3edb7c2103e5c75a", "8ce6a9a216b326c4", "af606153eb3be0a7", "7ae255c3d760c920", "e50e94c40048c5fd", "55009bca30f9dc4c", "c37566487909214a", "891b74f7e534d14a", "726e190aae663525", "df473127d30fb669", "bfbcc646d92dfd48", "a4a1954c44751936", "da4a44a3d7c4d8be", "5ff5bca4a775dd30", "14917461e1917c53", "14ce20d0a80955fa", "a56a63de4d3f3d39", "f780246adc7bd556", "3495a541aea0da72", "f7f205ce47fed2a5", "f52db3f434279c3a", "dca17088c97dee5e", "dd53a8b3a2a4ccc0", "52e07629290d45e4", "cda522b0f8f50d9a", "b85a1c8bcd51d82c", "e344a00cd3f5e93a", "fa59d8a66d7bdd88", "68fb1f1393a216e8", "4c30ab1fb10af181", "b1376e0578099143", "88752f72d8d305fd", "fddf20078d27bf3c", "dab2120bffa2be8c", "c7c8dde481793471", "e4b1bdbcabfc284d");

    public static int er(Context context) {
        if (((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).al(512L)) {
            return 0;
        }
        try {
            return ((BatteryManager) context.getApplicationContext().getSystemService("batterymanager")).getIntProperty(4);
        } catch (Exception unused) {
            return 0;
        }
    }

    public static long WP() {
        return com.kwad.sdk.crash.utils.h.L(Environment.getDataDirectory());
    }

    public static long WQ() {
        if (((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).al(1024L)) {
            return 0L;
        }
        return com.kwad.sdk.crash.utils.h.K(Environment.getDataDirectory());
    }

    private static long WN() throws Throwable {
        BufferedReader bufferedReader;
        Throwable th;
        String line;
        BufferedReader bufferedReader2 = null;
        try {
            bufferedReader = new BufferedReader(new FileReader("/proc/meminfo"), 8192);
            do {
                try {
                    line = bufferedReader.readLine();
                    if (line == null) {
                        com.kwad.sdk.crash.utils.b.closeQuietly(bufferedReader);
                        return 0L;
                    }
                } catch (Exception unused) {
                    bufferedReader2 = bufferedReader;
                    com.kwad.sdk.crash.utils.b.closeQuietly(bufferedReader2);
                    return 0L;
                } catch (Throwable th2) {
                    th = th2;
                    com.kwad.sdk.crash.utils.b.closeQuietly(bufferedReader);
                    throw th;
                }
            } while (!line.contains("MemTotal"));
            long jLongValue = Long.valueOf(line.split("\\s+")[1]).longValue() << 10;
            com.kwad.sdk.crash.utils.b.closeQuietly(bufferedReader);
            return jLongValue;
        } catch (Exception unused2) {
        } catch (Throwable th3) {
            bufferedReader = null;
            th = th3;
        }
    }

    public static long es(Context context) throws Throwable {
        long j = brm;
        if (j > 0) {
            return j;
        }
        if (context == null) {
            return 0L;
        }
        try {
            ActivityManager activityManager = (ActivityManager) context.getApplicationContext().getSystemService(TTDownloadField.TT_ACTIVITY);
            ActivityManager.MemoryInfo memoryInfo = new ActivityManager.MemoryInfo();
            activityManager.getMemoryInfo(memoryInfo);
            long jWN = memoryInfo.totalMem;
            if (jWN <= 0) {
                jWN = WN();
            }
            brm = jWN;
            return jWN;
        } catch (Exception unused) {
            return 0L;
        }
    }

    public static long eo(Context context) {
        if (context == null || ((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).al(1024L)) {
            return 0L;
        }
        try {
            ActivityManager activityManager = (ActivityManager) context.getSystemService(TTDownloadField.TT_ACTIVITY);
            ActivityManager.MemoryInfo memoryInfo = new ActivityManager.MemoryInfo();
            activityManager.getMemoryInfo(memoryInfo);
            return memoryInfo.availMem;
        } catch (Exception unused) {
            return 0L;
        }
    }

    public static long WR() {
        try {
            long jFreeMemory = Runtime.getRuntime().freeMemory();
            if (jFreeMemory > 0) {
                return jFreeMemory;
            }
            return 0L;
        } catch (Throwable unused) {
        }
    }

    public static int WS() {
        int i = brl;
        if (i > 0) {
            return i;
        }
        int iAvailableProcessors = Runtime.getRuntime().availableProcessors();
        brl = iAvailableProcessors;
        return iAvailableProcessors;
    }

    public static String B(Context context, boolean z) {
        if (be.usePhoneStateDisable() && !TextUtils.isEmpty(be.getDevImei())) {
            return be.getDevImei();
        }
        String strEt = et(context);
        return (TextUtils.isEmpty(strEt) && !z && TextUtils.isEmpty(com.kwad.sdk.core.e.a.getAppOAID(context))) ? ((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).FV() : strEt;
    }

    private static synchronized String et(Context context) {
        boolean zEn;
        if (be.usePhoneStateDisable() && !TextUtils.isEmpty(be.getDevImei())) {
            return be.getDevImei();
        }
        if (brf) {
            return bqS;
        }
        if (TextUtils.isEmpty(bqS) && context != null) {
            if (Build.VERSION.SDK_INT >= 29) {
                return bqS;
            }
            if (be.usePhoneStateDisable()) {
                return bqS;
            }
            if (!t.UV()) {
                return bqS;
            }
            try {
                zEn = SystemUtil.en(context);
                if (zEn) {
                    try {
                        String deviceId = ((TelephonyManager) context.getSystemService("phone")).getDeviceId();
                        bqS = deviceId;
                        if (TextUtils.isEmpty(deviceId)) {
                            brf = true;
                        }
                    } catch (Exception e) {
                        e = e;
                        com.kwad.sdk.core.d.c.printStackTrace(e);
                        if (zEn) {
                            brf = true;
                        }
                    }
                }
            } catch (Exception e2) {
                e = e2;
                zEn = false;
            }
            return bqS;
        }
        return bqS;
    }

    public static synchronized String eu(Context context) {
        boolean zEn;
        if (brk) {
            return bqT;
        }
        if (TextUtils.isEmpty(bqT) && context != null) {
            if (be.usePhoneStateDisable()) {
                return bqT;
            }
            if (!t.UU()) {
                return brb;
            }
            try {
                zEn = SystemUtil.en(context);
                if (zEn) {
                    try {
                        TelephonyManager telephonyManager = (TelephonyManager) context.getSystemService("phone");
                        if (telephonyManager != null) {
                            String meid = telephonyManager.getMeid();
                            bqT = meid;
                            if (TextUtils.isEmpty(meid)) {
                                brk = true;
                            }
                        }
                    } catch (Exception e) {
                        e = e;
                        com.kwad.sdk.core.d.c.printStackTrace(e);
                        if (zEn) {
                            brk = true;
                        }
                    }
                }
            } catch (Exception e2) {
                e = e2;
                zEn = false;
            }
            return bqT;
        }
        return bqT;
    }

    public static synchronized String[] ev(Context context) {
        if (be.usePhoneStateDisable() && be.getDevImeis() != null) {
            return be.getDevImeis();
        }
        if (brj) {
            return bqY;
        }
        if (Build.VERSION.SDK_INT >= 29) {
            return bqY;
        }
        String[] strArr = bqY;
        boolean z = false;
        if (TextUtils.isEmpty(strArr[0]) && TextUtils.isEmpty(strArr[1]) && context != null) {
            if (be.usePhoneStateDisable()) {
                return strArr;
            }
            if (!t.UV()) {
                return strArr;
            }
            try {
                boolean zEn = SystemUtil.en(context);
                if (zEn) {
                    try {
                        TelephonyManager telephonyManager = (TelephonyManager) context.getSystemService("phone");
                        if (telephonyManager != null) {
                            int iMin = Math.min(ew(context), 2);
                            for (int i = 0; i < iMin; i++) {
                                bqY[i] = telephonyManager.getImei(i);
                            }
                            String[] strArr2 = bqY;
                            if (TextUtils.isEmpty(strArr2[0]) && TextUtils.isEmpty(strArr2[1])) {
                                brj = true;
                            }
                        }
                    } catch (Exception e) {
                        e = e;
                        z = zEn;
                        com.kwad.sdk.core.d.c.printStackTraceOnly(e);
                        if (z) {
                            brj = true;
                        }
                    }
                }
            } catch (Exception e2) {
                e = e2;
            }
            return bqY;
        }
        return strArr;
    }

    public static synchronized int ew(Context context) {
        if (bqV || bqU > 0 || context == null || be.usePhoneStateDisable()) {
            return bqU;
        }
        try {
            bqU = ((TelephonyManager) context.getSystemService("phone")).getPhoneCount();
        } catch (Exception unused) {
        }
        int i = bqU;
        bqV = i == 0;
        return i;
    }

    public static int ex(Context context) {
        if (context == null || bqW > 0 || bqX || !SystemUtil.en(context) || be.usePhoneStateDisable()) {
            return bqW;
        }
        try {
            bqW = ((SubscriptionManager) context.getSystemService("telephony_subscription_service")).getActiveSubscriptionInfoCount();
        } catch (Throwable unused) {
        }
        int i = bqW;
        bqX = i != 0;
        return i;
    }

    public static synchronized String dS(Context context) {
        if (context != null) {
            if (!brg && TextUtils.isEmpty(bqZ) && SystemUtil.en(context) && !be.usePhoneStateDisable() && t.UW()) {
                try {
                    bqZ = ((TelephonyManager) context.getApplicationContext().getSystemService("phone")).getSubscriberId();
                } catch (Exception unused) {
                }
                brg = TextUtils.isEmpty(bqZ);
                return bqZ;
            }
        }
        return bqZ;
    }

    public static int checkSelfPermission(Context context, String str) {
        return context.checkPermission(str, Process.myPid(), Process.myUid());
    }

    public static String ey(Context context) {
        if (!TextUtils.isEmpty(bra) || context == null) {
            return bra;
        }
        if (brh) {
            return bra;
        }
        if (be.usePhoneStateDisable()) {
            return bra;
        }
        if (!t.UX()) {
            return bra;
        }
        try {
            if (SystemUtil.en(context)) {
                bra = ((TelephonyManager) context.getApplicationContext().getSystemService("phone")).getSimSerialNumber();
            }
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
            bra = null;
        }
        if (TextUtils.isEmpty(bra)) {
            brh = true;
        }
        String str = TextUtils.isEmpty(bra) ? "" : bra;
        bra = str;
        return str;
    }

    public static String getLocale() {
        Locale locale = LocaleList.getDefault().get(0);
        if (locale == null) {
            locale = Locale.CHINESE;
        }
        return String.valueOf(locale);
    }

    public static String WT() {
        return Build.MODEL;
    }

    public static synchronized long WU() {
        long j;
        j = (!be.usePhoneStateDisable() || (TextUtils.isEmpty(be.getDevImei()) && be.getDevImeis() == null)) ? 0L : 1L;
        if (be.readLocationDisable() && be.Wo() != null) {
            j |= 64;
        }
        if (be.usePhoneStateDisable() && !TextUtils.isEmpty(be.getDevAndroidId())) {
            j |= 2;
        }
        if (be.useMacAddressDisable() && !TextUtils.isEmpty(be.getDevMacAddress())) {
            j |= 4;
        }
        if (be.useOaidDisable() && !TextUtils.isEmpty(be.getDevOaid())) {
            j |= 2048;
        }
        if (be.readInstalledPackagesDisable() && be.getDevInstalledPackages() != null) {
            j |= 16;
        }
        return j;
    }

    public static String WV() {
        return Build.BRAND;
    }

    public static String WW() {
        return Build.CPU_ABI;
    }

    public static synchronized int ez(Context context) {
        try {
        } catch (Exception unused) {
            return -1;
        }
        return ((AudioManager) context.getSystemService(MediaFormat.KEY_AUDIO)).getRingerMode();
    }

    public static synchronized long WX() {
        return SystemClock.elapsedRealtime() / 1000;
    }

    public static synchronized long WY() {
        return Build.TIME;
    }

    public static synchronized String WZ() {
        return Build.FINGERPRINT;
    }

    public static synchronized String Xa() {
        if (!TextUtils.isEmpty(bqP)) {
            return bqP;
        }
        String radioVersion = Build.getRadioVersion();
        bqP = radioVersion;
        return radioVersion;
    }

    public static synchronized String Xb() {
        return bd.getName();
    }

    public static synchronized String Xc() {
        return bd.getVersion();
    }

    public static String Xd() {
        return Build.MANUFACTURER;
    }

    public static int Xe() {
        if (bre == -1) {
            bre = eA(((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).getContext()) ? 4 : 3;
        }
        return bre;
    }

    public static String Xf() {
        if (TextUtils.isEmpty(brd)) {
            try {
                brd = System.getProperty("os.arch");
            } catch (Exception e) {
                com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            }
        }
        return brd;
    }

    private static boolean eA(Context context) {
        return (context == null || context.getResources() == null || context.getResources().getConfiguration() == null || (context.getResources().getConfiguration().screenLayout & 15) < 3) ? false : true;
    }

    public static String getOsVersion() {
        return Build.VERSION.RELEASE;
    }

    public static int Xg() {
        return Build.VERSION.SDK_INT;
    }

    public static String getLanguage() {
        return Locale.getDefault().getLanguage();
    }

    public static int getScreenWidth(Context context) {
        try {
            DisplayMetrics displayMetrics = new DisplayMetrics();
            WindowManager windowManager = (WindowManager) context.getSystemService("window");
            if (Build.VERSION.SDK_INT >= 35) {
                WindowMetrics currentWindowMetrics = windowManager.getCurrentWindowMetrics();
                Rect bounds = currentWindowMetrics.getBounds();
                Insets insets = currentWindowMetrics.getWindowInsets().getInsets(WindowInsets.Type.systemBars());
                return (bounds.width() - insets.left) - insets.right;
            }
            windowManager.getDefaultDisplay().getMetrics(displayMetrics);
            return displayMetrics.widthPixels;
        } catch (Exception unused) {
            return 0;
        }
    }

    public static int getScreenHeight(Context context) {
        try {
            DisplayMetrics displayMetrics = new DisplayMetrics();
            WindowManager windowManager = (WindowManager) context.getSystemService("window");
            if (Build.VERSION.SDK_INT >= 35) {
                WindowMetrics currentWindowMetrics = windowManager.getCurrentWindowMetrics();
                Rect bounds = currentWindowMetrics.getBounds();
                Insets insets = currentWindowMetrics.getWindowInsets().getInsets(WindowInsets.Type.systemBars());
                return (bounds.height() - insets.top) - insets.bottom;
            }
            windowManager.getDefaultDisplay().getMetrics(displayMetrics);
            return displayMetrics.heightPixels;
        } catch (Exception unused) {
            return 0;
        }
    }

    public static String Xh() {
        if (be.useNetworkStateDisable() || ((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).al(8L)) {
            return "";
        }
        if (TextUtils.isEmpty(brp)) {
            return brp;
        }
        try {
            Enumeration<NetworkInterface> networkInterfaces = NetworkInterface.getNetworkInterfaces();
            while (networkInterfaces.hasMoreElements()) {
                Enumeration<InetAddress> inetAddresses = networkInterfaces.nextElement().getInetAddresses();
                while (inetAddresses.hasMoreElements()) {
                    InetAddress inetAddressNextElement = inetAddresses.nextElement();
                    if ((inetAddressNextElement instanceof Inet4Address) && !inetAddressNextElement.isLoopbackAddress()) {
                        String hostAddress = inetAddressNextElement.getHostAddress();
                        brp = hostAddress;
                        return hostAddress;
                    }
                }
            }
        } catch (Throwable unused) {
        }
        return "";
    }

    public static String dO(Context context) {
        if (!TextUtils.isEmpty(brb) || context == null || bri) {
            return brb;
        }
        if (be.usePhoneStateDisable()) {
            return be.getDevAndroidId();
        }
        if (!t.UP()) {
            return brb;
        }
        try {
            String string = Settings.Secure.getString(context.getContentResolver(), "android_id");
            brb = string;
            if (!in(string)) {
                brb = "";
            }
        } catch (Exception unused) {
        }
        if (TextUtils.isEmpty(brb)) {
            bri = true;
        }
        return brb;
    }

    public static synchronized String eB(Context context) {
        if (TextUtils.isEmpty(bqQ) && context != null && !bqR) {
            if (be.useMacAddressDisable()) {
                String devMacAddress = be.getDevMacAddress();
                bqQ = devMacAddress;
                return devMacAddress;
            }
            if (!t.UQ()) {
                return bqQ;
            }
            try {
                WifiInfo connectionInfo = ((WifiManager) context.getApplicationContext().getSystemService("wifi")).getConnectionInfo();
                if (connectionInfo != null) {
                    bqQ = connectionInfo.getMacAddress();
                }
                if (il(bqQ)) {
                    for (NetworkInterface networkInterface : Collections.list(NetworkInterface.getNetworkInterfaces())) {
                        if (networkInterface != null && "wlan0".equals(networkInterface.getName())) {
                            byte[] hardwareAddress = networkInterface.getHardwareAddress();
                            if (hardwareAddress != null && hardwareAddress.length != 0) {
                                StringBuilder sb = new StringBuilder();
                                for (byte b : hardwareAddress) {
                                    sb.append(String.format("%02X:", Byte.valueOf(b)));
                                }
                                if (sb.length() > 0) {
                                    sb.deleteCharAt(sb.length() - 1);
                                }
                                bqQ = sb.toString();
                                break;
                            }
                            break;
                            break;
                        }
                    }
                }
                if (il(bqQ)) {
                    bqQ = com.kwad.sdk.crash.utils.h.c(Runtime.getRuntime().exec("cat /sys/class/net/wlan0/address ").getInputStream());
                }
                if (!il(bqQ)) {
                    bqQ = bqQ.toUpperCase(Locale.US);
                }
            } catch (Exception unused) {
                bqR = true;
            }
            bqR = il(bqQ);
            return bqQ;
        }
        return bqQ;
    }

    private static boolean il(String str) {
        return TextUtils.isEmpty(str) || str.equals("02:00:00:00:00:00");
    }

    public static String getDeviceId() {
        try {
            if (!TextUtils.isEmpty(brc)) {
                return brc;
            }
            String strXk = Xk();
            if (!TextUtils.isEmpty(strXk)) {
                String str = "ANDROID_" + strXk;
                brc = str;
                return str;
            }
            String strDO = dO(((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).getContext());
            if (!TextUtils.isEmpty(strDO) && !im(strDO) && in(strDO)) {
                String str2 = "ANDROID_" + strDO;
                brc = str2;
                return str2;
            }
            String strXi = Xi();
            if (!TextUtils.isEmpty(strXi)) {
                String str3 = "ANDROID_" + strXi;
                brc = str3;
                return str3;
            }
            return "ANDROID_";
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
        }
    }

    private static String Xi() {
        String strI = ai.i("ksadsdk_pref", "random_android_id", "");
        if (!TextUtils.isEmpty(strI)) {
            return strI;
        }
        String strXj = Xj();
        if (TextUtils.isEmpty(strXj)) {
            return "";
        }
        io(strXj);
        ai.a("ksadsdk_pref", "random_android_id", strXj, true);
        return strXj;
    }

    private static String Xj() {
        try {
            return a(Long.toHexString(new Random(System.currentTimeMillis()).nextLong()), 16, '0');
        } catch (Throwable unused) {
            return null;
        }
    }

    private static String a(String str, int i, char c) {
        StringBuilder sb = new StringBuilder();
        while (sb.length() + str.length() < 16) {
            sb.append('0');
        }
        sb.append(str);
        return sb.toString();
    }

    private static boolean im(String str) {
        return brq.contains(str.toLowerCase(Locale.US));
    }

    private static boolean in(String str) {
        for (int i = 0; i < str.length(); i++) {
            try {
                if (str.charAt(i) != '0') {
                    return true;
                }
            } catch (Throwable unused) {
            }
        }
        return false;
    }

    private static void io(String str) {
        if (((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).getContext() == null) {
            return;
        }
        ai.a("ksadsdk_pref", "android_id", str, true);
    }

    private static String Xk() {
        if (((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).getContext() == null) {
            return null;
        }
        String strI = ai.i("ksadsdk_pref", "android_id", null);
        ai.j(strI, "ksadsdk_pref", "android_id");
        return strI;
    }

    public static String cF(boolean z) {
        com.kwad.sdk.service.a.f fVar = (com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class);
        if (fVar == null) {
            return "";
        }
        Context context = fVar.getContext();
        String appOAID = com.kwad.sdk.core.e.a.getAppOAID(context);
        return (TextUtils.isEmpty(appOAID) && !z && TextUtils.isEmpty(et(context))) ? ((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).FW() : appOAID;
    }

    public static List<String> eC(Context context) {
        String[] list;
        if (d.cL(context)) {
            return new ArrayList();
        }
        if (!eD(context)) {
            return new ArrayList();
        }
        File file = new File(Environment.getExternalStorageDirectory().getAbsolutePath() + "/Android/data");
        if (!file.exists() || !file.isDirectory() || (list = file.list()) == null) {
            return null;
        }
        ArrayList arrayList = new ArrayList();
        for (String str : list) {
            if (!TextUtils.isEmpty(str) && !str.startsWith(TRouterMap.DOT)) {
                arrayList.add(str);
            }
        }
        return arrayList;
    }

    public static boolean eD(Context context) {
        try {
            return (context.getApplicationInfo().targetSdkVersion < 30 || Build.VERSION.SDK_INT < 30) && context.checkCallingOrSelfPermission(com.kuaishou.weapon.p0.g.j) == 0;
        } catch (Throwable unused) {
        }
    }

    public static String ip(String str) {
        String strValueOf;
        if (!TextUtils.isEmpty(bro) || TextUtils.isEmpty(str)) {
            return bro;
        }
        try {
            StructStat structStatStat = Os.stat(str);
            if (structStatStat == null) {
                return bro;
            }
            String strValueOf2 = "";
            if (Build.VERSION.SDK_INT >= 27) {
                if (structStatStat.st_atim == null) {
                    strValueOf = "";
                } else {
                    strValueOf2 = String.valueOf(structStatStat.st_atim.tv_sec);
                    strValueOf = String.valueOf(structStatStat.st_atim.tv_nsec);
                }
                bro = strValueOf2 + TRouterMap.DOT + strValueOf;
            } else {
                if (structStatStat.st_atime != 0) {
                    strValueOf2 = String.valueOf(structStatStat.st_atime);
                }
                bro = strValueOf2;
            }
            return bro;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
        }
    }

    public static Pair<Boolean, Boolean> eE(Context context) {
        boolean z;
        boolean z2 = false;
        try {
            AccessibilityManager accessibilityManager = (AccessibilityManager) context.getSystemService("accessibility");
            accessibilityManager.getEnabledAccessibilityServiceList(16);
            boolean zIsEnabled = accessibilityManager.isEnabled();
            try {
                z2 = accessibilityManager.getEnabledAccessibilityServiceList(16).isEmpty() ? false : true;
                return new Pair<>(Boolean.valueOf(zIsEnabled), Boolean.valueOf(z2));
            } catch (Throwable th) {
                th = th;
                z = z2;
                z2 = zIsEnabled;
                com.kwad.sdk.core.d.c.printStackTrace(th);
                return new Pair<>(Boolean.valueOf(z2), Boolean.valueOf(z));
            }
        } catch (Throwable th2) {
            th = th2;
            z = false;
        }
    }
}

package com.czhj.devicehelper;

import android.content.Context;
import android.os.Handler;
import android.os.Looper;
import android.telephony.TelephonyManager;
import android.text.TextUtils;
import android.util.Log;
import com.bykv.vk.component.ttvideo.ILivePlayer;
import com.czhj.sdk.logger.SigmobLog;
import java.net.Inet6Address;
import java.net.InetAddress;
import java.net.NetworkInterface;
import java.net.SocketException;
import java.util.ArrayList;
import java.util.Enumeration;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes2.dex */
public final class DeviceHelper {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f2170a = "getSimState";
    private static final String b = "getImei";
    private static final String c = "getLine1Number";
    private static String d = null;
    private static String e = null;
    private static String f = null;
    private static String g = "";
    private static long h = 0;
    private static long i = 0;
    private static Handler j = null;
    private static Handler k = null;
    private static int l = 0;
    private static boolean m = false;
    private static String n;
    private static String o;
    private static String p;
    private static Thread q;
    private static Thread r;
    private static boolean s;
    private static int t;

    public static Map<String, List<String>> getAllIPv6() {
        boolean zIsUp;
        Enumeration<InetAddress> inetAddresses;
        int iIndexOf;
        HashMap map = new HashMap();
        try {
            Enumeration<NetworkInterface> networkInterfaces = NetworkInterface.getNetworkInterfaces();
            if (networkInterfaces == null) {
                return map;
            }
            while (networkInterfaces.hasMoreElements()) {
                NetworkInterface networkInterfaceNextElement = networkInterfaces.nextElement();
                try {
                    zIsUp = networkInterfaceNextElement.isUp();
                } catch (SocketException e2) {
                    e2.printStackTrace();
                    zIsUp = false;
                }
                if (zIsUp && !networkInterfaceNextElement.isVirtual() && (inetAddresses = networkInterfaceNextElement.getInetAddresses()) != null) {
                    ArrayList arrayList = new ArrayList();
                    while (inetAddresses.hasMoreElements()) {
                        InetAddress inetAddressNextElement = inetAddresses.nextElement();
                        if ((inetAddressNextElement instanceof Inet6Address) && !inetAddressNextElement.isAnyLocalAddress() && !inetAddressNextElement.isLinkLocalAddress() && !inetAddressNextElement.isLoopbackAddress()) {
                            String hostAddress = inetAddressNextElement.getHostAddress();
                            if (!TextUtils.isEmpty(hostAddress) && (iIndexOf = hostAddress.indexOf(37)) > 0) {
                                arrayList.add(hostAddress.substring(0, iIndexOf));
                            }
                        }
                    }
                    String name = networkInterfaceNextElement.getName();
                    if (!TextUtils.isEmpty(name) && !arrayList.isEmpty()) {
                        map.put(name, arrayList);
                    }
                }
            }
            return map;
        } catch (SocketException unused) {
        }
    }

    public static String getIMEI(Context context) {
        try {
            SigmobLog.d("private :getIMEI");
            TelephonyManager telephonyManager = (TelephonyManager) context.getSystemService("phone");
            if (telephonyManager == null) {
                return null;
            }
            String imei = telephonyManager.getImei();
            if (TextUtils.isEmpty(imei)) {
                try {
                    return telephonyManager.getDeviceId();
                } catch (Throwable unused) {
                    return telephonyManager.getMeid();
                }
            }
            if (imei != null) {
                return imei;
            }
            return null;
        } catch (Exception unused2) {
        }
    }

    public static String getIMEI(Context context, int i2) {
        try {
            SigmobLog.d("private :getIMEI " + i2);
            TelephonyManager telephonyManager = (TelephonyManager) context.getSystemService("phone");
            if (telephonyManager == null) {
                return null;
            }
            String imei = telephonyManager.getImei(i2);
            if (TextUtils.isEmpty(imei)) {
                try {
                    return telephonyManager.getDeviceId(i2);
                } catch (Throwable unused) {
                    return telephonyManager.getMeid(i2);
                }
            }
            if (imei != null) {
                return imei;
            }
        } catch (Exception unused2) {
        }
        return null;
    }

    public static String getIMSI(Context context) {
        return null;
    }

    public static String getMacAddress() {
        return "";
    }

    public static void getOAID(final Context context, final com.czhj.devicehelper.msaoaId.a.InterfaceC0354a interfaceC0354a) {
        if (!TextUtils.isEmpty(d)) {
            if (interfaceC0354a != null) {
                interfaceC0354a.a(e);
                return;
            }
            return;
        }
        if (t > 10) {
            if (interfaceC0354a != null) {
                interfaceC0354a.a("");
                return;
            }
            return;
        }
        h = System.currentTimeMillis();
        if (r == null) {
            Log.d("", "Thread create ,current thread num :" + Thread.activeCount());
            Thread thread = new Thread(new Runnable() { // from class: com.czhj.devicehelper.DeviceHelper.1
                @Override // java.lang.Runnable
                public void run() {
                    SigmobLog.d("private  getOAID");
                    com.czhj.devicehelper.msaoaId.a.a(context, new com.czhj.devicehelper.msaoaId.a.InterfaceC0354a() { // from class: com.czhj.devicehelper.DeviceHelper.1.1
                        @Override // com.czhj.devicehelper.msaoaId.a.InterfaceC0354a
                        public void a(String str) {
                            String unused = DeviceHelper.d = str;
                            if (interfaceC0354a != null) {
                                interfaceC0354a.a(str);
                            }
                            boolean unused2 = DeviceHelper.s = false;
                            if (DeviceHelper.j != null) {
                                DeviceHelper.j.removeCallbacksAndMessages(null);
                                Handler unused3 = DeviceHelper.j = null;
                            }
                        }
                    });
                }
            });
            r = thread;
            thread.start();
            t++;
            s = true;
            Handler handler = new Handler(Looper.getMainLooper());
            j = handler;
            handler.postDelayed(new Runnable() { // from class: com.czhj.devicehelper.DeviceHelper.2
                @Override // java.lang.Runnable
                public void run() {
                    if (DeviceHelper.r != null) {
                        boolean unused = DeviceHelper.s = false;
                        int unused2 = DeviceHelper.t = 11;
                        com.czhj.devicehelper.msaoaId.a.InterfaceC0354a interfaceC0354a2 = interfaceC0354a;
                        if (interfaceC0354a2 != null) {
                            interfaceC0354a2.a("");
                        }
                        if (DeviceHelper.j != null) {
                            DeviceHelper.j.removeCallbacksAndMessages(null);
                            Handler unused3 = DeviceHelper.j = null;
                        }
                    }
                }
            }, ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT);
        }
    }

    public static String getVAID() {
        return f;
    }

    public static String getWifiName(Context context) {
        return n;
    }

    public static String getWifimac(Context context) {
        return "";
    }
}

package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.net.Proxy;
import android.net.wifi.WifiConfiguration;
import android.net.wifi.WifiInfo;
import android.net.wifi.WifiManager;
import android.text.TextUtils;
import java.lang.reflect.Method;
import java.util.List;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Fig {
    public static boolean a(Context context) {
        List<WifiConfiguration> configuredNetworks;
        String str;
        Object objA;
        Object objA2;
        int iA = Orange.a();
        if (iA < 14) {
            return (TextUtils.isEmpty(Proxy.getHost(context)) || Proxy.getPort(context) == -1) ? false : true;
        }
        if (!TextUtils.isEmpty(System.getProperty("http.proxyHost")) && !TextUtils.equals(System.getProperty("http.proxyPort"), "-1")) {
            return true;
        }
        WifiManager wifiManager = (WifiManager) context.getApplicationContext().getSystemService("wifi");
        if (Cranberry.a(context, com.kuaishou.weapon.p0.g.d) != 0) {
            return false;
        }
        try {
            WifiInfo connectionInfo = wifiManager.getConnectionInfo();
            if (connectionInfo != null && connectionInfo.getNetworkId() != -1) {
                Object objInvoke = null;
                try {
                    configuredNetworks = wifiManager.getConfiguredNetworks();
                } catch (Throwable unused) {
                    configuredNetworks = null;
                }
                if (configuredNetworks == null) {
                    return false;
                }
                int networkId = connectionInfo.getNetworkId();
                for (WifiConfiguration wifiConfiguration : configuredNetworks) {
                    if (wifiConfiguration.networkId == networkId) {
                        if (iA < 21) {
                            objA = Filbert.a(WifiConfiguration.class, "proxySettings", wifiConfiguration);
                            str = "android.net.wifi.WifiConfiguration$ProxySettings";
                        } else {
                            try {
                                Method methodA = Filbert.a(WifiConfiguration.class, "getProxySettings", new Class[0]);
                                if (methodA != null) {
                                    objInvoke = methodA.invoke(wifiConfiguration, null);
                                }
                            } catch (Throwable unused2) {
                            }
                            str = "android.net.IpConfiguration$ProxySettings";
                            objA = objInvoke;
                        }
                        Object objA3 = Filbert.a(str, "STATIC");
                        if (objA3 != null && objA3 == objA) {
                            return true;
                        }
                        if (iA < 19 || (objA2 = Filbert.a(str, "PAC")) == null || objA2 != objA) {
                            break;
                        }
                        return true;
                    }
                }
            }
        } catch (Throwable unused3) {
        }
        return false;
    }
}

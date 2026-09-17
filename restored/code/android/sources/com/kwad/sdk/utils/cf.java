package com.kwad.sdk.utils;

import android.content.Context;
import android.net.wifi.ScanResult;
import android.net.wifi.WifiInfo;
import android.net.wifi.WifiManager;
import android.os.Build;
import android.text.TextUtils;
import androidx.core.content.ContextCompat;
import com.kwad.sdk.service.ServiceProvider;
import com.qq.gdt.action.ActionUtils;
import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class cf {
    private static boolean brD = false;
    private static final List<a> brE = new CopyOnWriteArrayList();

    public static List<a> o(Context context, int i) {
        WifiManager wifiManager;
        if (be.useNetworkStateDisable()) {
            return new ArrayList();
        }
        if (!brD && ServiceProvider.getSDKConfig().canReadNearbyWifiList()) {
            List<a> list = brE;
            if (list.isEmpty() && context != null) {
                if (((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).al(32L)) {
                    return list;
                }
                try {
                    if (eF(context) || (wifiManager = (WifiManager) context.getApplicationContext().getSystemService("wifi")) == null) {
                        return list;
                    }
                    WifiInfo connectionInfo = wifiManager.getConnectionInfo();
                    List<ScanResult> scanResults = wifiManager.getScanResults();
                    if (scanResults != null) {
                        for (ScanResult scanResult : scanResults) {
                            a aVar = new a();
                            aVar.brF = scanResult.SSID;
                            aVar.brG = scanResult.BSSID;
                            aVar.level = scanResult.level;
                            if (connectionInfo.getBSSID() != null && scanResult.BSSID != null && TextUtils.equals(connectionInfo.getBSSID().replace("\"", ""), scanResult.BSSID.replace("\"", "")) && connectionInfo.getSSID() != null && scanResult.SSID != null && TextUtils.equals(connectionInfo.getSSID().replace("\"", ""), scanResult.SSID.replace("\"", ""))) {
                                brE.add(0, aVar);
                            } else {
                                brE.add(aVar);
                            }
                            List<a> list2 = brE;
                            if (list2.size() >= i) {
                                return list2;
                            }
                        }
                    }
                } catch (Exception e) {
                    brD = true;
                    com.kwad.sdk.core.d.c.printStackTraceOnly(e);
                }
                return brE;
            }
        }
        return brE;
    }

    public static boolean eF(Context context) {
        if (context.getApplicationInfo().targetSdkVersion < 29 || Build.VERSION.SDK_INT < 29) {
            return ContextCompat.checkSelfPermission(context, com.kuaishou.weapon.p0.g.g) == -1 && ContextCompat.checkSelfPermission(context, com.kuaishou.weapon.p0.g.h) == -1;
        }
        return ContextCompat.checkSelfPermission(context, com.kuaishou.weapon.p0.g.g) == -1;
    }

    public static class a implements com.kwad.sdk.core.b {
        public String brF;
        public String brG;
        public int level;

        @Override // com.kwad.sdk.core.b
        public final void parseJson(JSONObject jSONObject) {
        }

        @Override // com.kwad.sdk.core.b
        public final JSONObject toJson() {
            JSONObject jSONObject = new JSONObject();
            ac.putValue(jSONObject, ActionUtils.LEVEL, this.level);
            ac.putValue(jSONObject, "ssid", this.brF);
            ac.putValue(jSONObject, "bssid", this.brG);
            return jSONObject;
        }
    }
}

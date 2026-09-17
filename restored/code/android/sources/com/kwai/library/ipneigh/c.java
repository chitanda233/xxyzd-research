package com.kwai.library.ipneigh;

import android.content.Context;
import android.net.wifi.WifiManager;
import android.text.TextUtils;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    public static d eR(Context context) {
        return F(context, false);
    }

    private static d F(Context context, boolean z) {
        return b(context, false, false);
    }

    private static d b(Context context, boolean z, boolean z2) {
        try {
            if (!b.isWifiConnected(context)) {
                return new d("", false, "");
            }
            String strGi = b.gi(((WifiManager) context.getApplicationContext().getSystemService("wifi")).getDhcpInfo().gateway);
            String strIH = !z ? a.iH("timeout 5 ip neigh show " + strGi) : "";
            if (z || TextUtils.isEmpty(strIH)) {
                strIH = KwaiIpNeigh.j(strGi, false);
            }
            String strIJ = b.iJ(strIH);
            return new d(strIJ, !TextUtils.isEmpty(strIJ), strIH);
        } catch (Throwable th) {
            return new d("", false, th.getMessage());
        }
    }
}

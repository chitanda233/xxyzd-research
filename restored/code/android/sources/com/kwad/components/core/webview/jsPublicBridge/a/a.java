package com.kwad.components.core.webview.jsPublicBridge.a;

import android.content.Context;
import android.net.ConnectivityManager;
import android.telephony.TelephonyManager;
import com.kuaishou.weapon.p0.g;
import com.kwad.sdk.core.config.e;
import com.kwad.sdk.core.webview.c.c;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.service.a.f;
import com.kwad.sdk.utils.SystemUtil;
import com.kwad.sdk.utils.aq;
import com.kwad.sdk.utils.n;

/* JADX INFO: loaded from: classes3.dex */
public final class a implements com.kwad.sdk.core.webview.c.a {
    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "ksadUnionGetPlatformInfo";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, c cVar) {
        cVar.b(C0463a.yC());
    }

    /* JADX INFO: renamed from: com.kwad.components.core.webview.jsPublicBridge.a.a$a, reason: collision with other inner class name */
    public static final class C0463a extends com.kwad.sdk.core.response.a.a {
        public int apd;
        public int ape;
        public int apf;
        public String apg;
        public String aph;
        public String api;
        public String appVersion;
        public int netType;

        public static C0463a yC() {
            C0463a c0463a = new C0463a();
            c0463a.apd = 6;
            c0463a.ape = 2;
            c0463a.apf = 2;
            c0463a.appVersion = n.cY(((f) ServiceProvider.get(f.class)).getContext());
            c0463a.netType = yy();
            c0463a.apg = e.Lk();
            c0463a.aph = "KSAdChinaMobile.ksadGetPhoneNumber";
            c0463a.api = "KSAdChinaMobile.ksadGetOperJudge";
            return c0463a;
        }

        private static int yy() {
            if (!SystemUtil.b(ServiceProvider.getContext(), g.b)) {
                return -1;
            }
            try {
                Context context = ServiceProvider.getContext();
                ConnectivityManager connectivityManager = (ConnectivityManager) context.getSystemService("connectivity");
                TelephonyManager telephonyManager = (TelephonyManager) context.getSystemService("phone");
                if (connectivityManager == null) {
                    return -1;
                }
                boolean zIsDataEnabled = telephonyManager.isDataEnabled();
                boolean zIsWifiConnected = aq.isWifiConnected(context);
                if (zIsDataEnabled && zIsWifiConnected) {
                    return 3;
                }
                if (zIsDataEnabled) {
                    return 1;
                }
                return zIsWifiConnected ? 2 : -1;
            } catch (Exception e) {
                com.kwad.sdk.core.d.c.printStackTraceOnly(e);
                return -1;
            }
        }
    }
}

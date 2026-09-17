package com.kwad.sdk.core.webview.d;

import android.content.Context;
import com.kwad.components.offline.api.BuildConfig;
import com.kwad.sdk.components.d;
import com.kwad.sdk.components.h;
import com.kwad.sdk.core.webview.c.c;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.service.a.f;
import com.kwad.sdk.utils.ai;
import com.kwad.sdk.utils.aq;
import com.kwad.sdk.utils.bf;
import com.kwad.sdk.utils.bt;
import com.kwad.sdk.utils.n;

/* JADX INFO: loaded from: classes3.dex */
public final class a implements com.kwad.sdk.core.webview.c.a {
    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "getDeviceInfo";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, c cVar) {
        cVar.b(C0521a.PU());
    }

    /* JADX INFO: renamed from: com.kwad.sdk.core.webview.d.a$a, reason: collision with other inner class name */
    public static final class C0521a extends com.kwad.sdk.core.response.a.a {
        public String Ni;
        public String SDKVersion;
        public int SDKVersionCode;
        public int Sh;
        public int Si;
        public String Uv;
        public String aQZ;
        public String aRa;
        public String aWY;
        public String aWn;
        public String aXa;
        public String aXb;
        public String aXo;
        public String appId;
        public String appName;
        public String appVersion;
        public int aqA;
        public String aqB;
        public int aqC;
        public int aqD;
        public String aqw;
        public String aqx;
        public int aqy;
        public String aqz;
        public String bda;
        public String bdb;
        public boolean bdc;
        public String bdd;
        public String model;
        public String sdkApiVersion;
        public int sdkApiVersionCode;
        public int sdkType;

        public static C0521a PU() {
            C0521a c0521a = new C0521a();
            c0521a.SDKVersion = BuildConfig.VERSION_NAME;
            c0521a.SDKVersionCode = BuildConfig.VERSION_CODE;
            c0521a.aWn = "6.2.2";
            c0521a.bdd = "1.3";
            c0521a.sdkApiVersion = ((f) ServiceProvider.get(f.class)).getApiVersion();
            c0521a.sdkApiVersionCode = ((f) ServiceProvider.get(f.class)).getApiVersionCode();
            c0521a.sdkType = 1;
            Context context = ((f) ServiceProvider.get(f.class)).getContext();
            c0521a.appVersion = n.cY(context);
            c0521a.appName = ((f) ServiceProvider.get(f.class)).getAppName();
            c0521a.appId = ((f) ServiceProvider.get(f.class)).getAppId();
            c0521a.bda = "";
            c0521a.aXb = ai.getEGid();
            h hVar = (h) d.f(h.class);
            if (hVar != null) {
                c0521a.aXa = hVar.qP();
            }
            c0521a.aqw = String.valueOf(aq.dA(context));
            c0521a.aqx = bt.Xd();
            c0521a.model = bt.WT();
            c0521a.Ni = bt.WV();
            c0521a.aqy = 1;
            c0521a.aqz = bt.getOsVersion();
            c0521a.aqA = bt.Xg();
            c0521a.aqB = bt.getLanguage();
            c0521a.Uv = bt.getLocale();
            c0521a.bdc = ((f) ServiceProvider.get(f.class)).FG();
            c0521a.bdb = bf.getDeviceId();
            c0521a.Si = bt.getScreenWidth(context);
            c0521a.Sh = bt.getScreenHeight(context);
            c0521a.aQZ = bf.dN(context);
            c0521a.aRa = bf.getOaid();
            c0521a.aWY = bf.dO(context);
            c0521a.aXo = bf.dP(context);
            c0521a.aqC = com.kwad.sdk.c.a.a.getStatusBarHeight(context);
            c0521a.aqD = com.kwad.sdk.c.a.a.a(context, 50.0f);
            return c0521a;
        }
    }
}

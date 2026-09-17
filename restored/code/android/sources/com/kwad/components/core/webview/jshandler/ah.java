package com.kwad.components.core.webview.jshandler;

import android.content.Context;
import com.kwad.components.offline.api.BuildConfig;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bt;

/* JADX INFO: loaded from: classes3.dex */
public final class ah implements com.kwad.sdk.core.webview.c.a {
    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "getKsPlayableDeviceInfo";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        cVar.b(a.yG());
    }

    public static final class a extends com.kwad.sdk.core.response.a.a {
        public String Ni;
        public String SDKVersion;
        public int SDKVersionCode;
        public int Sh;
        public int Si;
        public String Uv;
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
        public String model;
        public String sdkApiVersion;
        public int sdkApiVersionCode;
        public int sdkType;

        public static a yG() {
            a aVar = new a();
            aVar.SDKVersion = BuildConfig.VERSION_NAME;
            aVar.SDKVersionCode = BuildConfig.VERSION_CODE;
            aVar.sdkApiVersion = ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).getApiVersion();
            aVar.sdkApiVersionCode = ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).getApiVersionCode();
            aVar.sdkType = 1;
            Context context = ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).getContext();
            aVar.appVersion = com.kwad.sdk.utils.n.cY(context);
            aVar.appName = ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).getAppName();
            aVar.appId = ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).getAppId();
            aVar.aqw = String.valueOf(com.kwad.sdk.utils.aq.dA(context));
            aVar.aqx = bt.Xd();
            aVar.model = bt.WT();
            aVar.Ni = bt.WV();
            aVar.aqy = 1;
            aVar.aqz = bt.getOsVersion();
            aVar.aqA = bt.Xg();
            aVar.aqB = bt.getLanguage();
            aVar.Uv = bt.getLocale();
            aVar.Si = bt.getScreenWidth(context);
            aVar.Sh = bt.getScreenHeight(context);
            aVar.aqC = com.kwad.sdk.c.a.a.getStatusBarHeight(context);
            aVar.aqD = com.kwad.sdk.c.a.a.a(context, 50.0f);
            return aVar;
        }
    }
}

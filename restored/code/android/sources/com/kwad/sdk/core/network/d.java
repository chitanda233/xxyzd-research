package com.kwad.sdk.core.network;

import com.kwad.components.offline.api.BuildConfig;
import com.kwad.sdk.components.DevelopMangerComponents;
import com.kwad.sdk.core.request.model.StatusInfo;
import com.kwad.sdk.internal.api.SceneImpl;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.be;

/* JADX INFO: loaded from: classes3.dex */
public abstract class d extends b {
    public static final String TRACK_ID_KEY = "kuaishou-tracing-token";
    public static boolean hadCreateInstance = false;

    protected boolean enablePrivateInfoObtain() {
        return true;
    }

    protected boolean needAppList() {
        return false;
    }

    protected boolean needAppendKuaHeader() {
        return true;
    }

    protected boolean needDeviceInfoBody() {
        return true;
    }

    public d() {
        this(0, null);
    }

    public d(int i, SceneImpl sceneImpl) {
        hadCreateInstance = true;
        if (needAppendKuaHeader()) {
            appendKUAHeader();
        }
        if (needDeviceInfoBody()) {
            putBody("deviceInfo", com.kwad.sdk.core.request.model.b.h(needAppList(), i));
        }
        if (sceneImpl != null) {
            putBody("statusInfo", StatusInfo.d(sceneImpl));
        }
    }

    private void appendKUAHeader() {
        com.kwad.sdk.service.a.f fVar;
        com.kwad.sdk.core.i.c cVarK = com.kwad.sdk.core.i.a.k(true, false);
        if (cVarK == null || (fVar = (com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)) == null) {
            return;
        }
        addHeader("KUA", cVarK.cc(fVar.getContext()));
    }

    @Override // com.kwad.sdk.core.network.b
    protected void buildBaseBody() {
        try {
            putBody("protocolVersion", "2.0");
            putBody("SDKVersion", BuildConfig.VERSION_NAME);
            putBody("SDKVersionCode", BuildConfig.VERSION_CODE);
            putBody("sdkApiVersion", ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).getApiVersion());
            putBody("sdkApiVersionCode", ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).getApiVersionCode());
            int i = 1;
            putBody("sdkType", 1);
            putBody("appInfo", com.kwad.sdk.core.request.model.a.Nz());
            putBody("tkVersion", "6.2.2");
            putBody("adSdkVersion", BuildConfig.VERSION_NAME);
            putBody("networkInfo", com.kwad.sdk.core.request.model.d.ND());
            putBody("liveSupportMode", ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).tG() ? 1 : 0);
            putBody("waynePlayerSupportMode", ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).tF() ? 1 : 0);
            if (!((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).tD()) {
                i = 0;
            }
            putBody("closureSupportMode", i);
            putBody("userInfo", com.kwad.sdk.core.request.model.g.NG());
            putBody("requestSessionData", q.Mu().eJ(getUrl()));
            putBody(com.alipay.sdk.m.x.a.k, System.currentTimeMillis());
            if (enablePrivateInfoObtain()) {
                buildBaseBodyWithPrivateInfo();
            }
        } catch (Throwable th) {
            reportSdkCaughtException(th);
        }
        putBody("mediumDisableSensor", be.useSensorManagerDisable());
        putBody("kwaiMerchantSdkVersion", "1.1.0");
    }

    protected void buildBaseBodyWithPrivateInfo() {
        try {
            putBody("geoInfo", com.kwad.sdk.core.request.model.c.NC());
            putBody("kGeoInfo", ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).FL());
            putBody(com.sigmob.sdk.base.n.m, com.kwad.sdk.core.request.model.e.NF());
        } catch (Throwable th) {
            reportSdkCaughtException(th);
        }
    }

    @Override // com.kwad.sdk.core.network.b
    protected void buildBaseHeader() {
        if (com.kwad.framework.b.a.oV.booleanValue()) {
            com.kwad.sdk.components.d.f(DevelopMangerComponents.class);
            addHeader("trace-context", "{\"laneId\":\"STAGING.online.u\"}");
            com.kwad.sdk.components.d.f(DevelopMangerComponents.class);
        }
    }
}

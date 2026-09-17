package com.kwad.components.core.request;

import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ac;
import com.kwad.sdk.utils.ai;
import org.json.JSONArray;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class g extends com.kwad.sdk.core.network.d {
    public g() {
        try {
            JSONArray jSONArray = new JSONArray();
            ac.a(jSONArray, new JSONObject());
            putBody("impInfo", jSONArray);
            putBody("appTag", ai.Vx());
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    @Override // com.kwad.sdk.core.network.b, com.kwad.sdk.core.network.f
    public final String getUrl() {
        return com.kwad.sdk.i.Fd();
    }

    @Override // com.kwad.sdk.core.network.d
    public final void buildBaseBodyWithPrivateInfo() {
        try {
            putBody("geoInfo", com.kwad.sdk.core.request.model.c.NC());
            putBody("kGeoInfo", ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).FL());
        } catch (Throwable th) {
            reportSdkCaughtException(th);
        }
    }
}

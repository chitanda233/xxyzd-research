package com.kwad.sdk.core.request.model;

import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ac;
import com.kwad.sdk.utils.bf;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class c implements com.kwad.sdk.core.b {
    private static c aXn;
    private double latitude;
    private double longitude;
    private int type;

    @Override // com.kwad.sdk.core.b
    public final void parseJson(JSONObject jSONObject) {
    }

    @Override // com.kwad.sdk.core.b
    public final JSONObject toJson() {
        JSONObject jSONObject = new JSONObject();
        ac.putValue(jSONObject, "latitude", this.latitude);
        ac.putValue(jSONObject, "longitude", this.longitude);
        ac.putValue(jSONObject, "type", this.type);
        return jSONObject;
    }

    public static c NC() {
        c cVar = aXn;
        if (cVar != null) {
            return cVar;
        }
        try {
            aXn = new c();
            com.kwad.sdk.utils.c.a aVarDf = bf.df(((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).getContext());
            if (aVarDf != null && aVarDf.bsJ != null) {
                aXn.latitude = aVarDf.bsJ.getLatitude();
                aXn.longitude = aVarDf.bsJ.getLongitude();
                aXn.type = aVarDf.type;
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
        return aXn;
    }
}

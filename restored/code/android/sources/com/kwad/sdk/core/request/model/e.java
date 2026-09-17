package com.kwad.sdk.core.request.model;

import com.kwad.sdk.core.network.k;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ac;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class e implements com.kwad.sdk.core.b {
    private com.kwad.sdk.core.b aXr;

    @Override // com.kwad.sdk.core.b
    public final void parseJson(JSONObject jSONObject) {
    }

    public static e NF() {
        e eVar = new e();
        try {
            eVar.aXr = ((k) ServiceProvider.get(k.class)).FB();
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
        return eVar;
    }

    @Override // com.kwad.sdk.core.b
    public final JSONObject toJson() {
        JSONObject jSONObject = new JSONObject();
        ac.a(jSONObject, "modeInfo", this.aXr);
        return jSONObject;
    }
}

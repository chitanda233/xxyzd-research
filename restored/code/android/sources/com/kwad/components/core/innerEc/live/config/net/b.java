package com.kwad.components.core.innerEc.live.config.net;

import com.kwad.sdk.utils.ac;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class b extends com.kwad.sdk.core.response.a.a {
    public i Uo;
    public d Up;
    public e Uq;

    @Override // com.kwad.sdk.core.response.a.a, com.kwad.sdk.core.b
    public void parseJson(JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        i iVar = new i();
        this.Uo = iVar;
        ac.a(iVar, jSONObject.optString("webSocketLiveServer"));
        d dVar = new d();
        this.Up = dVar;
        ac.a(dVar, jSONObject.optString("commonData"));
        e eVar = new e();
        this.Uq = eVar;
        ac.a(eVar, jSONObject.optString("livePlayData"));
    }

    @Override // com.kwad.sdk.core.response.a.a, com.kwad.sdk.core.b
    public JSONObject toJson() {
        JSONObject jSONObject = new JSONObject();
        ac.a(jSONObject, "webSocketLiveServer", this.Uo);
        ac.a(jSONObject, "commonData", this.Up);
        ac.a(jSONObject, "livePlayData", this.Uq);
        return jSONObject;
    }
}

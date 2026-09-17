package com.kwad.components.core.innerEc.live.video.reconnect;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a implements com.kwad.sdk.core.b {
    public String UC;
    public JSONObject UD;
    public String XZ;

    public final void a(String str, JSONObject jSONObject) {
        this.UC = str;
        this.UD = jSONObject;
    }

    @Override // com.kwad.sdk.core.b
    public final void parseJson(JSONObject jSONObject) {
        if (jSONObject != null) {
            this.XZ = jSONObject.optString("livePlayData");
        }
    }

    @Override // com.kwad.sdk.core.b
    public final JSONObject toJson() {
        return this.UD;
    }
}

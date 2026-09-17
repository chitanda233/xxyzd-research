package com.kwad.components.core.innerEc.live.reconnect;

import com.kwad.sdk.core.b;
import com.kwad.sdk.core.d.c;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a implements b {
    public int UB;
    public String UC;
    public JSONObject UD;
    public String XP = "";

    public final void a(String str, JSONObject jSONObject) {
        this.UC = str;
        this.UD = jSONObject;
    }

    @Override // com.kwad.sdk.core.b
    public final void parseJson(JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        try {
            this.UB = jSONObject.optInt("liveErrorCode");
            JSONObject jSONObjectOptJSONObject = jSONObject.optJSONObject("liveData");
            if (jSONObjectOptJSONObject != null) {
                this.XP = jSONObjectOptJSONObject.toString();
            }
        } catch (Throwable th) {
            c.printStackTraceOnly(th);
        }
    }

    @Override // com.kwad.sdk.core.b
    public final JSONObject toJson() {
        return this.UD;
    }
}

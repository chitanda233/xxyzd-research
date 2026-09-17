package com.kwad.sdk.core.webview.c;

import com.alipay.sdk.m.y.o;
import com.kwad.sdk.utils.ac;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class f implements com.kwad.sdk.core.b {
    public final com.kwad.sdk.core.b bcZ;
    public final int result = 1;

    @Override // com.kwad.sdk.core.b
    public final void parseJson(JSONObject jSONObject) {
    }

    public f(com.kwad.sdk.core.b bVar) {
        this.bcZ = bVar;
    }

    @Override // com.kwad.sdk.core.b
    public final JSONObject toJson() {
        JSONObject jSONObject = new JSONObject();
        ac.putValue(jSONObject, o.c, this.result);
        ac.a(jSONObject, "data", this.bcZ);
        return jSONObject;
    }
}

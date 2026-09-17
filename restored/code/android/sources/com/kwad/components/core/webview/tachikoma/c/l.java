package com.kwad.components.core.webview.tachikoma.c;

import com.kwad.sdk.utils.ac;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class l extends com.kwad.sdk.core.response.a.a {
    public int aur;
    public int aus = -1;
    public int aut;

    @Override // com.kwad.sdk.core.response.a.a, com.kwad.sdk.core.b
    public final JSONObject toJson() {
        JSONObject jSONObject = new JSONObject();
        ac.putValue(jSONObject, "insertScreenAdShowStrategy", this.aur);
        ac.putValue(jSONObject, "isAutoShow", this.aut);
        int i = this.aus;
        if (i != -1) {
            ac.putValue(jSONObject, "triggerType", i);
        }
        return jSONObject;
    }
}

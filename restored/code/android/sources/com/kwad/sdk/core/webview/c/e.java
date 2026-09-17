package com.kwad.sdk.core.webview.c;

import com.alipay.sdk.m.y.o;
import com.kwad.sdk.utils.ac;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class e implements com.kwad.sdk.core.b {
    private final String aIv;
    private final int result;

    @Override // com.kwad.sdk.core.b
    public final void parseJson(JSONObject jSONObject) {
    }

    public e(int i, String str) {
        this.result = i;
        this.aIv = str;
    }

    @Override // com.kwad.sdk.core.b
    public final JSONObject toJson() {
        JSONObject jSONObject = new JSONObject();
        ac.putValue(jSONObject, o.c, this.result);
        ac.putValue(jSONObject, "error_msg", this.aIv);
        return jSONObject;
    }
}

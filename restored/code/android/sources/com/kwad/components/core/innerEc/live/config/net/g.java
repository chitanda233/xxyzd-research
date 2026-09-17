package com.kwad.components.core.innerEc.live.config.net;

import android.text.TextUtils;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class g extends com.kwad.sdk.core.response.a.a {
    public int UB;
    public String UC;
    public JSONObject UD;
    public b Uz = new b();
    public a UA = new a();

    public final void a(String str, JSONObject jSONObject) {
        this.UC = str;
        this.UD = jSONObject;
    }

    @Override // com.kwad.sdk.core.response.a.a, com.kwad.sdk.core.b
    public JSONObject toJson() {
        return this.UD;
    }

    public final boolean isValid() {
        return this.UB == 1 && !TextUtils.isEmpty(this.Uz.Up.liveStreamId);
    }

    public final boolean rS() {
        return this.UB != 1;
    }

    public final boolean rT() {
        return this.UB == 601;
    }
}

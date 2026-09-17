package com.kwad.components.core.innerEc.live.a;

import com.kwad.components.core.webview.tachikoma.b.w;
import com.kwad.sdk.utils.ac;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class p extends w {
    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "registerHorizontalSwipeListener";
    }

    public final void rK() {
        aE("left");
    }

    public final void rL() {
        aE("right");
    }

    private void aE(String str) {
        a aVar = new a();
        aVar.TW = str;
        a(aVar);
    }

    public static final class a implements com.kwad.sdk.core.b {
        private String TW;

        @Override // com.kwad.sdk.core.b
        public final void parseJson(JSONObject jSONObject) {
            if (jSONObject == null) {
                return;
            }
            this.TW = jSONObject.optString("swipeStatus");
        }

        @Override // com.kwad.sdk.core.b
        public final JSONObject toJson() {
            JSONObject jSONObject = new JSONObject();
            ac.putValue(jSONObject, "swipeStatus", this.TW);
            return jSONObject;
        }
    }
}

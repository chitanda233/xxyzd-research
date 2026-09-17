package com.kwad.components.core.webview.jshandler;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class ai implements com.kwad.sdk.core.webview.c.a {
    private final com.kwad.sdk.core.webview.b apL;

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "getScreenOrientation";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
    }

    public ai(com.kwad.sdk.core.webview.b bVar) {
        this.apL = bVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        if (this.apL.PE()) {
            cVar.onError(-1, "native adTemplate is null");
            return;
        }
        a aVar = new a();
        aVar.screenOrientation = !com.kwad.sdk.utils.as.isOrientationPortrait() ? 1 : 0;
        cVar.b(aVar);
    }

    public static final class a implements com.kwad.sdk.core.b {
        public int screenOrientation;

        @Override // com.kwad.sdk.core.b
        public final void parseJson(JSONObject jSONObject) {
        }

        @Override // com.kwad.sdk.core.b
        public final JSONObject toJson() {
            JSONObject jSONObject = new JSONObject();
            com.kwad.sdk.utils.ac.putValue(jSONObject, "screenOrientation", this.screenOrientation);
            return jSONObject;
        }
    }
}

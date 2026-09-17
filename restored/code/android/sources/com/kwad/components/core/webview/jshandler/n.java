package com.kwad.components.core.webview.jshandler;

import com.kwad.sdk.core.response.model.AdTemplate;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class n implements com.kwad.sdk.core.webview.c.a {
    com.kwad.sdk.core.webview.b apL;

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "cancelAppDownloadForAd";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
    }

    public n(com.kwad.sdk.core.webview.b bVar) {
        this.apL = bVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        try {
            a aVar = new a();
            aVar.parseJson(new JSONObject(str));
            com.kwad.sdk.core.download.a.eu(com.kwad.sdk.core.response.helper.e.eM(a(aVar)).adConversionInfo.appDownloadUrl);
            cVar.b(null);
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            cVar.onError(-1, th.getMessage());
        }
    }

    private AdTemplate a(a aVar) {
        if (aVar.adTemplate != null) {
            return aVar.adTemplate;
        }
        return this.apL.dS(aVar.Pu);
    }

    public static class a implements com.kwad.sdk.core.b {
        public String Pu;
        public AdTemplate adTemplate;

        @Override // com.kwad.sdk.core.b
        public final void parseJson(JSONObject jSONObject) {
            if (jSONObject == null) {
                return;
            }
            this.Pu = jSONObject.optString("creativeId");
            try {
                if (jSONObject.has("adTemplate")) {
                    String string = jSONObject.getString("adTemplate");
                    if (this.adTemplate == null) {
                        this.adTemplate = new AdTemplate();
                    }
                    this.adTemplate.parseJson(new JSONObject(string));
                }
            } catch (Exception e) {
                com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            }
        }

        @Override // com.kwad.sdk.core.b
        public final JSONObject toJson() {
            JSONObject jSONObject = new JSONObject();
            com.kwad.sdk.utils.ac.a(jSONObject, "adTemplate", this.adTemplate);
            com.kwad.sdk.utils.ac.putValue(jSONObject, "creativeId", this.Pu);
            return jSONObject;
        }
    }
}

package com.kwad.components.core.webview.jshandler;

import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class c implements com.kwad.sdk.core.webview.c.a {
    private com.kwad.components.core.proxy.launchdialog.b apA = yE();
    private com.kwad.sdk.core.webview.c.c apz;
    private final com.kwad.sdk.core.webview.b fc;

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "dpInterceptPopupListener";
    }

    public c(com.kwad.sdk.core.webview.b bVar) {
        this.fc = bVar;
        com.kwad.components.core.proxy.launchdialog.e.vV().a(this.apA);
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        this.apz = cVar;
    }

    private com.kwad.components.core.proxy.launchdialog.b yE() {
        return new com.kwad.components.core.proxy.launchdialog.b() { // from class: com.kwad.components.core.webview.jshandler.c.1
            @Override // com.kwad.components.core.proxy.launchdialog.b
            public final void b(long j, int i) {
                try {
                    String strValueOf = String.valueOf(j);
                    AdTemplate adTemplateDS = c.this.fc.dS(strValueOf);
                    if (c.this.apz == null || adTemplateDS == null) {
                        return;
                    }
                    a aVar = new a();
                    aVar.status = i;
                    aVar.Pu = strValueOf;
                    c.this.apz.b(aVar);
                } catch (Throwable th) {
                    ServiceProvider.reportSdkCaughtException(th);
                }
            }
        };
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
        this.apz = null;
        com.kwad.components.core.proxy.launchdialog.e.vV().b(this.apA);
        this.apA = null;
    }

    public static final class a implements com.kwad.sdk.core.b {
        String Pu;
        int status;

        @Override // com.kwad.sdk.core.b
        public final void parseJson(JSONObject jSONObject) {
        }

        @Override // com.kwad.sdk.core.b
        public final JSONObject toJson() {
            JSONObject jSONObject = new JSONObject();
            com.kwad.sdk.utils.ac.putValue(jSONObject, "status", this.status);
            com.kwad.sdk.utils.ac.putValue(jSONObject, "creativeId", this.Pu);
            return jSONObject;
        }
    }
}

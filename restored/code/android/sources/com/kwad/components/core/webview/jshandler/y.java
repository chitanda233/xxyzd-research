package com.kwad.components.core.webview.jshandler;

import com.kwad.sdk.core.response.model.AdTemplate;
import java.util.List;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class y implements com.kwad.sdk.core.webview.c.a {
    private List<AdTemplate> apV;
    private com.kwad.sdk.core.webview.b fc;
    private b sl;

    public static class a extends com.kwad.sdk.core.response.a.a {
        public long creativeId = -1;
        public int adStyle = -1;
    }

    public interface b {
        void W(AdTemplate adTemplate);
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "adImpression";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
    }

    public y(List<AdTemplate> list) {
        this.apV = list;
    }

    public y(com.kwad.sdk.core.webview.b bVar) {
        this.fc = bVar;
    }

    public final void a(b bVar) {
        this.sl = bVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        try {
            a aVar = new a();
            aVar.parseJson(new JSONObject(str));
            AdTemplate adTemplateA = com.kwad.sdk.core.response.helper.e.a(yF(), aVar.creativeId, aVar.adStyle);
            b bVar = this.sl;
            if (bVar != null) {
                bVar.W(adTemplateA);
            }
        } catch (JSONException unused) {
        }
    }

    private List<AdTemplate> yF() {
        List<AdTemplate> list = this.apV;
        if (list != null) {
            return list;
        }
        com.kwad.sdk.core.webview.b bVar = this.fc;
        if (bVar != null) {
            return bVar.PD();
        }
        return null;
    }
}

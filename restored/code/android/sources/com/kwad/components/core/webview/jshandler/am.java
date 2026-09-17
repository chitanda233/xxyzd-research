package com.kwad.components.core.webview.jshandler;

import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.br;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class am implements com.kwad.sdk.core.webview.c.a {
    private final com.kwad.sdk.core.webview.b apL;
    private int aqR = 0;
    private a aqS;

    public interface a {
        void onAdShow();
    }

    protected void a(com.kwad.sdk.core.adlog.c.b bVar) {
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final String getKey() {
        return "log";
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void onDestroy() {
    }

    public am(com.kwad.sdk.core.webview.b bVar) {
        this.apL = bVar;
    }

    public final void a(a aVar) {
        this.aqS = aVar;
    }

    @Override // com.kwad.sdk.core.webview.c.a
    public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
        try {
            b bVar = new b();
            bVar.parseJson(new JSONObject(str));
            if (c(bVar) == null) {
                cVar.onError(-1, "native adTemplate is null");
            }
            a(bVar);
            cVar.b(null);
        } catch (JSONException e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
            cVar.onError(-1, e.getMessage());
        }
    }

    protected void b(boolean z, AdTemplate adTemplate, JSONObject jSONObject, com.kwad.sdk.core.adlog.c.b bVar) {
        com.kwad.components.core.t.b.wR().a(adTemplate, null, bVar);
    }

    protected void a(b bVar) {
        com.kwad.sdk.core.d.c.d("WebCardLogHandler", "handleH5Log actionType actionType" + bVar.actionType);
        if (bVar.actionType == 1) {
            com.kwad.sdk.core.adlog.c.b bVarEa = new com.kwad.sdk.core.adlog.c.b().ea(bVar.QQ);
            a aVar = this.aqS;
            if (aVar != null) {
                aVar.onAdShow();
            }
            if (bVar.adTemplate != null) {
                bVarEa.dW(this.aqR);
                b(true, bVar.adTemplate, null, bVarEa);
                return;
            }
            if (br.isNullString(bVar.pb())) {
                b(true, this.apL.getAdTemplate(), null, bVarEa);
                return;
            }
            if (this.apL.PD() != null) {
                for (AdTemplate adTemplate : this.apL.PD()) {
                    if (br.isEquals(bVar.pb(), String.valueOf(com.kwad.sdk.core.response.helper.e.eW(adTemplate)))) {
                        b(false, adTemplate, null, bVarEa);
                        return;
                    }
                }
                return;
            }
            return;
        }
        if (bVar.actionType == 2) {
            com.kwad.sdk.widget.g gVar = this.apL.bbV;
            com.kwad.sdk.core.adlog.c.b bVarEa2 = new com.kwad.sdk.core.adlog.c.b().dW(this.aqR).ea(bVar.QQ);
            if (gVar != null) {
                bVarEa2.f(gVar.getTouchCoords());
            }
            a(bVarEa2);
            com.kwad.sdk.core.adlog.c.a(c(bVar), bVarEa2, this.apL.mReportExtData);
            return;
        }
        if (bVar.actionType == 12006) {
            com.kwad.components.core.p.a.vX().f(c(bVar), bVar.aqT, this.aqR);
            return;
        }
        if (bVar.actionType == 140) {
            com.kwad.sdk.core.adlog.c.d(c(bVar), this.apL.mReportExtData, new com.kwad.sdk.core.adlog.c.b().ea(bVar.QQ));
        } else if (bVar.actionType == 141) {
            com.kwad.sdk.core.adlog.c.e(c(bVar), this.apL.mReportExtData, new com.kwad.sdk.core.adlog.c.b().ea(bVar.QQ));
        } else {
            com.kwad.sdk.core.adlog.c.a(c(bVar), bVar.actionType, this.apL.mReportExtData, bVar.QQ);
            com.kwad.components.core.webview.tachikoma.e.a.zM().bP(bVar.QQ);
        }
    }

    private AdTemplate c(b bVar) {
        return bVar.adTemplate != null ? bVar.adTemplate : this.apL.dS(bVar.Pu);
    }

    public static final class b extends com.kwad.sdk.core.report.a implements com.kwad.sdk.core.b {
        private String Pu;
        private String QQ;
        private int actionType;
        private AdTemplate adTemplate;
        private int aqT;

        @Override // com.kwad.sdk.core.response.a.a, com.kwad.sdk.core.b
        public final void parseJson(JSONObject jSONObject) {
            if (jSONObject == null) {
                return;
            }
            this.actionType = jSONObject.optInt("actionType");
            this.aqT = jSONObject.optInt("refreshType");
            this.QQ = jSONObject.optString("payload");
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
            if (this.adTemplate == null && jSONObject.has("adCacheId")) {
                this.adTemplate = com.kwad.sdk.core.response.helper.c.a(com.kwad.components.core.offline.a.f.a.a.bf(jSONObject.optInt("adCacheId")), this.Pu);
            }
        }

        @Override // com.kwad.sdk.core.response.a.a, com.kwad.sdk.core.b
        public final JSONObject toJson() {
            JSONObject jSONObject = new JSONObject();
            com.kwad.sdk.utils.ac.putValue(jSONObject, "actionType", this.actionType);
            com.kwad.sdk.utils.ac.putValue(jSONObject, "payload", this.QQ);
            com.kwad.sdk.utils.ac.putValue(jSONObject, "refreshType", this.aqT);
            com.kwad.sdk.utils.ac.a(jSONObject, "adTemplate", this.adTemplate);
            com.kwad.sdk.utils.ac.putValue(jSONObject, "creativeId", this.Pu);
            return jSONObject;
        }

        public final int getActionType() {
            return this.actionType;
        }

        public final String yH() {
            return this.QQ;
        }

        public final String pb() {
            return this.Pu;
        }
    }
}

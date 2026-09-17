package com.kwad.sdk.core.webview.d.b;

import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.br;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends com.kwad.sdk.core.response.a.a {

    @Deprecated
    public boolean QC;
    public String Rc;
    public AdTemplate adTemplate;

    @Deprecated
    public boolean ara;
    public int arc;
    public d ard;
    public int bdg;
    public int bdh;
    public int ne;
    public boolean needReport = true;
    public long creativeId = -1;
    public int adStyle = -1;
    public boolean bdi = false;
    public boolean bdj = false;

    @Override // com.kwad.sdk.core.response.a.a, com.kwad.sdk.core.b
    public final void parseJson(JSONObject jSONObject) {
        super.parseJson(jSONObject);
        try {
            if (this.ne == 0 && this.bdh == 0) {
                if (jSONObject != null && jSONObject.has("logParam")) {
                    JSONObject jSONObjectOptJSONObject = jSONObject.optJSONObject("logParam");
                    this.ne = jSONObjectOptJSONObject.getInt("itemClickType");
                    this.bdh = jSONObjectOptJSONObject.getInt("sceneType");
                    this.bdi = jSONObjectOptJSONObject.optBoolean("isCallbackOnly");
                }
                String strOptString = jSONObject.optString("adTemplate");
                if (br.isNullString(strOptString)) {
                    return;
                }
                try {
                    JSONObject jSONObject2 = new JSONObject(strOptString);
                    AdTemplate adTemplate = new AdTemplate();
                    this.adTemplate = adTemplate;
                    adTemplate.parseJson(jSONObject2);
                } catch (JSONException e) {
                    ServiceProvider.reportSdkCaughtException(e);
                }
            }
        } catch (Throwable unused) {
        }
    }

    public final boolean PV() {
        return 1 == this.arc;
    }
}

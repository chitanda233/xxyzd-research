package com.kwad.sdk.commercial;

import com.kwad.sdk.utils.ac;
import java.util.ArrayList;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends com.kwad.sdk.core.response.a.a {
    public double aJu;
    public List<f> aJv;
    public String minVersion;

    @Override // com.kwad.sdk.core.response.a.a
    public final String toString() {
        return "RefineConfRatio{defaultRatio=" + this.aJu + ", minVersion='" + this.minVersion + "', ruleSet=" + this.aJv + '}';
    }

    @Override // com.kwad.sdk.core.response.a.a, com.kwad.sdk.core.b
    public final JSONObject toJson() {
        JSONObject jSONObject = new JSONObject();
        ac.putValue(jSONObject, "default_ratio", this.aJu);
        ac.putValue(jSONObject, "min_version", this.minVersion);
        ac.putValue(jSONObject, "rule_set", this.aJv);
        afterToJson(jSONObject);
        return jSONObject;
    }

    @Override // com.kwad.sdk.core.response.a.a, com.kwad.sdk.core.b
    public final void parseJson(JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        this.aJu = jSONObject.optDouble("default_ratio", 0.0d);
        this.minVersion = jSONObject.optString("min_version", "");
        List<JSONObject> listH = ac.h(jSONObject.optJSONArray("rule_set"));
        if (listH != null) {
            this.aJv = new ArrayList();
            for (JSONObject jSONObject2 : listH) {
                f fVar = new f();
                fVar.parseJson(jSONObject2);
                this.aJv.add(fVar);
            }
        }
    }
}

package com.kwad.sdk.core.b.a;

import java.util.ArrayList;
import org.json.JSONArray;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class dy implements com.kwad.sdk.core.d<com.kwad.components.core.pfmonitor.model.b> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.pfmonitor.model.b) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.pfmonitor.model.b) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.pfmonitor.model.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        bVar.air = jSONObject.optInt("fileThreshold");
        bVar.ais = new ArrayList();
        JSONArray jSONArrayOptJSONArray = jSONObject.optJSONArray("targetDiskPathList");
        if (jSONArrayOptJSONArray != null) {
            for (int i = 0; i < jSONArrayOptJSONArray.length(); i++) {
                com.kwad.components.core.pfmonitor.model.a aVar = new com.kwad.components.core.pfmonitor.model.a();
                aVar.parseJson(jSONArrayOptJSONArray.optJSONObject(i));
                bVar.ais.add(aVar);
            }
        }
    }

    private static JSONObject b(com.kwad.components.core.pfmonitor.model.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (bVar.air != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "fileThreshold", bVar.air);
        }
        com.kwad.sdk.utils.ac.putValue(jSONObject, "targetDiskPathList", bVar.ais);
        return jSONObject;
    }
}

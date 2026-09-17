package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class e implements com.kwad.sdk.core.d<com.kwad.sdk.core.webview.d.b.a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.sdk.core.webview.d.b.a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.sdk.core.webview.d.b.a) bVar, jSONObject);
    }

    private static void a(com.kwad.sdk.core.webview.d.b.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        aVar.ara = jSONObject.optBoolean("clickActionButton");
        aVar.arc = jSONObject.optInt("area");
        aVar.ne = jSONObject.optInt("itemClickType");
        aVar.bdg = jSONObject.optInt("convertPageType", new Integer("-1").intValue());
        aVar.ard = new com.kwad.sdk.core.webview.d.b.d();
        aVar.ard.parseJson(jSONObject.optJSONObject("logParam"));
        aVar.needReport = jSONObject.optBoolean("needReport", new Boolean("true").booleanValue());
        aVar.creativeId = jSONObject.optLong("creativeId", new Long("-1").longValue());
        aVar.Rc = jSONObject.optString("liveItemId");
        if (JSONObject.NULL.toString().equals(aVar.Rc)) {
            aVar.Rc = "";
        }
        aVar.bdh = jSONObject.optInt("sceneType");
        aVar.adStyle = jSONObject.optInt("adStyle", new Integer("-1").intValue());
        aVar.bdi = jSONObject.optBoolean("isCallbackOnly");
        aVar.bdj = jSONObject.optBoolean("disableCallback");
    }

    private static JSONObject b(com.kwad.sdk.core.webview.d.b.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (aVar.ara) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "clickActionButton", aVar.ara);
        }
        if (aVar.arc != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "area", aVar.arc);
        }
        if (aVar.ne != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "itemClickType", aVar.ne);
        }
        com.kwad.sdk.utils.ac.putValue(jSONObject, "convertPageType", aVar.bdg);
        com.kwad.sdk.utils.ac.a(jSONObject, "logParam", aVar.ard);
        com.kwad.sdk.utils.ac.putValue(jSONObject, "needReport", aVar.needReport);
        com.kwad.sdk.utils.ac.putValue(jSONObject, "creativeId", aVar.creativeId);
        if (aVar.Rc != null && !aVar.Rc.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "liveItemId", aVar.Rc);
        }
        if (aVar.bdh != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "sceneType", aVar.bdh);
        }
        com.kwad.sdk.utils.ac.putValue(jSONObject, "adStyle", aVar.adStyle);
        if (aVar.bdi) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "isCallbackOnly", aVar.bdi);
        }
        if (aVar.bdj) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "disableCallback", aVar.bdj);
        }
        return jSONObject;
    }
}

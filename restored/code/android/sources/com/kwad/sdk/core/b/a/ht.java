package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class ht implements com.kwad.sdk.core.d<com.kwad.components.core.innerEc.live.config.net.d> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.innerEc.live.config.net.d) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.innerEc.live.config.net.d) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.innerEc.live.config.net.d dVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        dVar.Us = jSONObject.optString("serverExpTag");
        if (JSONObject.NULL.toString().equals(dVar.Us)) {
            dVar.Us = "";
        }
        dVar.streamType = jSONObject.optInt("streamType");
        dVar.liveStreamId = jSONObject.optString("liveStreamId");
        if (JSONObject.NULL.toString().equals(dVar.liveStreamId)) {
            dVar.liveStreamId = "";
        }
        dVar.Ut = jSONObject.optBoolean("multiTabLive");
        dVar.Uu = jSONObject.optString("attach");
        if (JSONObject.NULL.toString().equals(dVar.Uu)) {
            dVar.Uu = "";
        }
        dVar.Uv = jSONObject.optString("locale");
        if (JSONObject.NULL.toString().equals(dVar.Uv)) {
            dVar.Uv = "";
        }
        dVar.Uw = jSONObject.optBoolean("isAnonymousLive");
    }

    private static JSONObject b(com.kwad.components.core.innerEc.live.config.net.d dVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (dVar.Us != null && !dVar.Us.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "serverExpTag", dVar.Us);
        }
        if (dVar.streamType != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "streamType", dVar.streamType);
        }
        if (dVar.liveStreamId != null && !dVar.liveStreamId.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "liveStreamId", dVar.liveStreamId);
        }
        if (dVar.Ut) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "multiTabLive", dVar.Ut);
        }
        if (dVar.Uu != null && !dVar.Uu.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "attach", dVar.Uu);
        }
        if (dVar.Uv != null && !dVar.Uv.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "locale", dVar.Uv);
        }
        if (dVar.Uw) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "isAnonymousLive", dVar.Uw);
        }
        return jSONObject;
    }
}

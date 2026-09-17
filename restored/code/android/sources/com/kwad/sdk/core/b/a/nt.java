package com.kwad.sdk.core.b.a;

import com.byazt.nys.PluginConstants;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class nt implements com.kwad.sdk.core.d<com.kwad.components.core.video.a.d.a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.video.a.d.a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.video.a.d.a) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.video.a.d.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        aVar.code = jSONObject.optInt(PluginConstants.KEY_ERROR_CODE);
        aVar.msg = jSONObject.optString("msg");
        if (JSONObject.NULL.toString().equals(aVar.msg)) {
            aVar.msg = "";
        }
        aVar.videoUrl = jSONObject.optString("video_url");
        if (JSONObject.NULL.toString().equals(aVar.videoUrl)) {
            aVar.videoUrl = "";
        }
        aVar.llsid = jSONObject.optLong("llsid");
        aVar.creativeId = jSONObject.optLong("creative_id");
        aVar.authorId = jSONObject.optLong("ad_info_uid");
        aVar.aop = jSONObject.optString("ad_info_user_name");
        if (JSONObject.NULL.toString().equals(aVar.aop)) {
            aVar.aop = "";
        }
        aVar.aoq = jSONObject.optInt("ad_media_player_type");
    }

    private static JSONObject b(com.kwad.components.core.video.a.d.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (aVar.code != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, PluginConstants.KEY_ERROR_CODE, aVar.code);
        }
        if (aVar.msg != null && !aVar.msg.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "msg", aVar.msg);
        }
        if (aVar.videoUrl != null && !aVar.videoUrl.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "video_url", aVar.videoUrl);
        }
        if (aVar.llsid != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "llsid", aVar.llsid);
        }
        if (aVar.creativeId != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "creative_id", aVar.creativeId);
        }
        if (aVar.authorId != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "ad_info_uid", aVar.authorId);
        }
        if (aVar.aop != null && !aVar.aop.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "ad_info_user_name", aVar.aop);
        }
        if (aVar.aoq != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "ad_media_player_type", aVar.aoq);
        }
        return jSONObject;
    }
}

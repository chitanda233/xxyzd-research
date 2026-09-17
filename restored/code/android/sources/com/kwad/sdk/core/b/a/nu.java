package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class nu implements com.kwad.sdk.core.d<com.kwad.components.core.video.a.d.b> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.video.a.d.b) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.video.a.d.b) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.video.a.d.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        bVar.aor = jSONObject.optLong("start_play_duration_ms");
        bVar.aos = jSONObject.optLong("first_frame_duration_ms");
        bVar.aot = jSONObject.optLong("block_total_duration_ms");
        bVar.videoDuration = jSONObject.optLong("video_duration_ms");
        bVar.anW = jSONObject.optInt("block_times");
        bVar.videoUrl = jSONObject.optString("video_url");
        if (JSONObject.NULL.toString().equals(bVar.videoUrl)) {
            bVar.videoUrl = "";
        }
        bVar.llsid = jSONObject.optLong("llsid");
        bVar.creativeId = jSONObject.optLong("creative_id");
        bVar.authorId = jSONObject.optLong("ad_info_uid");
        bVar.aop = jSONObject.optString("ad_info_user_name");
        if (JSONObject.NULL.toString().equals(bVar.aop)) {
            bVar.aop = "";
        }
        bVar.adStyle = jSONObject.optInt("ad_style");
        bVar.aoq = jSONObject.optInt("ad_media_player_type");
    }

    private static JSONObject b(com.kwad.components.core.video.a.d.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (bVar.aor != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "start_play_duration_ms", bVar.aor);
        }
        if (bVar.aos != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "first_frame_duration_ms", bVar.aos);
        }
        if (bVar.aot != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "block_total_duration_ms", bVar.aot);
        }
        if (bVar.videoDuration != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "video_duration_ms", bVar.videoDuration);
        }
        if (bVar.anW != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "block_times", bVar.anW);
        }
        if (bVar.videoUrl != null && !bVar.videoUrl.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "video_url", bVar.videoUrl);
        }
        if (bVar.llsid != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "llsid", bVar.llsid);
        }
        if (bVar.creativeId != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "creative_id", bVar.creativeId);
        }
        if (bVar.authorId != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "ad_info_uid", bVar.authorId);
        }
        if (bVar.aop != null && !bVar.aop.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "ad_info_user_name", bVar.aop);
        }
        if (bVar.adStyle != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "ad_style", bVar.adStyle);
        }
        if (bVar.aoq != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "ad_media_player_type", bVar.aoq);
        }
        return jSONObject;
    }
}

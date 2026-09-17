package com.kwad.sdk.core.b.a;

import com.baidu.mobads.sdk.api.IAdInterListener;
import com.kwad.sdk.core.scene.URLPackage;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class hx implements com.kwad.sdk.core.d<com.kwad.components.core.innerEc.live.base.b> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.innerEc.live.base.b) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.innerEc.live.base.b) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.innerEc.live.base.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        bVar.authorId = jSONObject.optString(URLPackage.KEY_AUTHOR_ID);
        if (JSONObject.NULL.toString().equals(bVar.authorId)) {
            bVar.authorId = "";
        }
        bVar.liveStreamId = jSONObject.optString("liveStreamId");
        if (JSONObject.NULL.toString().equals(bVar.liveStreamId)) {
            bVar.liveStreamId = "";
        }
        bVar.kwaiUserId = jSONObject.optString("kwaiUserId");
        if (JSONObject.NULL.toString().equals(bVar.kwaiUserId)) {
            bVar.kwaiUserId = "";
        }
        bVar.content = jSONObject.optString(IAdInterListener.AdProdType.PRODUCT_CONTENT);
        if (JSONObject.NULL.toString().equals(bVar.content)) {
            bVar.content = "";
        }
        bVar.TB = jSONObject.optInt("likeCount");
        bVar.TC = jSONObject.optLong("likeIntervalMs");
    }

    private static JSONObject b(com.kwad.components.core.innerEc.live.base.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (bVar.authorId != null && !bVar.authorId.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, URLPackage.KEY_AUTHOR_ID, bVar.authorId);
        }
        if (bVar.liveStreamId != null && !bVar.liveStreamId.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "liveStreamId", bVar.liveStreamId);
        }
        if (bVar.kwaiUserId != null && !bVar.kwaiUserId.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "kwaiUserId", bVar.kwaiUserId);
        }
        if (bVar.content != null && !bVar.content.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, IAdInterListener.AdProdType.PRODUCT_CONTENT, bVar.content);
        }
        if (bVar.TB != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "likeCount", bVar.TB);
        }
        if (bVar.TC != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "likeIntervalMs", bVar.TC);
        }
        return jSONObject;
    }
}

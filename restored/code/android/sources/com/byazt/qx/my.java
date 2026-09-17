package com.byazt.qx;

import com.baidu.mobads.sdk.internal.cb;
import com.byazt.nys.PluginConstants;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import org.json.JSONArray;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_GET_AUDIO_DEVICE_OPENED_TIME, MediaPlayer.MEDIA_PLAYER_OPTION_SINGLE_PLAY_DOWNLOAD_BYTES})
public class my extends com.byazt.pct.n<JSONObject, JSONObject> {
    public com.byazt.ete.ic c;

    public my(com.byazt.ete.ic icVar) {
        this.c = icVar;
    }

    public static void c(com.byazt.pct.nu nuVar, com.byazt.ete.ic icVar) {
        nuVar.c("getRestMetas", (com.byazt.pct.n<?, ?>) new my(icVar));
    }

    @Override // com.byazt.pct.n
    public JSONObject c(JSONObject jSONObject, com.byazt.pct.a aVar) throws Exception {
        JSONObject jSONObject2 = new JSONObject();
        try {
            JSONArray jSONArray = new JSONArray();
            if (this.c != null) {
                jSONArray = new JSONArray(this.c.hl());
            }
            JSONObject jSONObject3 = new JSONObject();
            jSONObject3.put("creatives", jSONArray);
            jSONObject2.put("data", jSONObject3);
            jSONObject2.put(PluginConstants.KEY_ERROR_CODE, 0);
            jSONObject2.put("msg", cb.o);
        } catch (Exception e) {
            com.byazt.nr.m.uj("GetRestMetasMethod", "getRestMetas error: " + e.getMessage());
            jSONObject2.put(PluginConstants.KEY_ERROR_CODE, -1);
            jSONObject2.put("msg", e.getMessage());
        }
        return jSONObject2;
    }
}

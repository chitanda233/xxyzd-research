package com.byazt.qx;

import com.byazt.nys.PluginConstants;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_GET_AUDIO_DEVICE_OPENED_TIME, 129})
public class bm extends com.byazt.pct.n<JSONObject, JSONObject> {
    public com.byazt.omf.d c;

    public static void c(com.byazt.pct.nu nuVar, com.byazt.omf.d dVar) {
        nuVar.c("ShowUgenDownloadDialog", (com.byazt.pct.n<?, ?>) new bm(dVar));
    }

    @Override // com.byazt.pct.n
    public JSONObject c(JSONObject jSONObject, com.byazt.pct.a aVar) throws Exception {
        return ve();
    }

    public bm(com.byazt.omf.d dVar) {
        this.c = dVar;
    }

    public JSONObject ve() {
        JSONObject jSONObject = new JSONObject();
        com.byazt.omf.d dVar = this.c;
        if (dVar == null) {
            try {
                jSONObject.put(PluginConstants.KEY_ERROR_CODE, -1);
                jSONObject.put("codeMsg", "JsObject is null");
                return jSONObject;
            } catch (JSONException e) {
                throw new RuntimeException(e);
            }
        }
        return dVar.t();
    }
}

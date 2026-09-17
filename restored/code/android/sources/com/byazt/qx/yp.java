package com.byazt.qx;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_GET_AUDIO_DEVICE_OPENED_TIME, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_QCOM_LOW_LATENCY})
public class yp extends com.byazt.pct.n<JSONObject, JSONObject> {
    public JSONObject c;

    public yp(JSONObject jSONObject) {
        this.c = jSONObject;
    }

    public static void c(com.byazt.pct.nu nuVar, JSONObject jSONObject) {
        nuVar.c("getData", (com.byazt.pct.n<?, ?>) new yp(jSONObject));
    }

    @Override // com.byazt.pct.n
    public JSONObject c(JSONObject jSONObject, com.byazt.pct.a aVar) throws Exception {
        return com.byazt.jlk.tt.c(this.c, jSONObject);
    }
}

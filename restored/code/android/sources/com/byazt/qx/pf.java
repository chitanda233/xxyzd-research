package com.byazt.qx;

import com.byazt.nys.PluginConstants;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_GET_AUDIO_DEVICE_OPENED_TIME, 577})
public class pf extends com.byazt.pct.n<JSONObject, JSONObject> {
    public final String c;

    public pf(String str) {
        this.c = str;
    }

    public static void c(com.byazt.pct.nu nuVar, com.byazt.ete.ic icVar) {
        nuVar.c("sendElement", (com.byazt.pct.n<?, ?>) new pf(icVar.zm()));
    }

    @Override // com.byazt.pct.n
    public JSONObject c(JSONObject jSONObject, com.byazt.pct.a aVar) throws Exception {
        JSONObject jSONObject2 = new JSONObject();
        com.byazt.rgb.tt.c(this.c, 0, jSONObject);
        jSONObject2.put(PluginConstants.KEY_ERROR_CODE, 0);
        return jSONObject2;
    }
}

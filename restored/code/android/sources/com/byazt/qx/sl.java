package com.byazt.qx;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_GET_AUDIO_DEVICE_OPENED_TIME, 158})
public class sl extends com.byazt.pct.n<JSONObject, JSONObject> {
    public com.byazt.ete.ic c;
    public com.byazt.omf.d tt;

    public static void c(com.byazt.pct.nu nuVar, com.byazt.ete.ic icVar, com.byazt.omf.d dVar) {
        nuVar.c("adViewInfo", (com.byazt.pct.n<?, ?>) new sl(icVar, dVar));
    }

    public sl(com.byazt.ete.ic icVar, com.byazt.omf.d dVar) {
        this.c = icVar;
        this.tt = dVar;
    }

    @Override // com.byazt.pct.n
    public JSONObject c(JSONObject jSONObject, com.byazt.pct.a aVar) throws Exception {
        JSONObject jSONObject2 = new JSONObject();
        jSONObject2.put("container", this.tt.c());
        jSONObject2.put("creative", this.tt.tt());
        return jSONObject2;
    }
}

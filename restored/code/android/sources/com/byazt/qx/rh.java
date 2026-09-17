package com.byazt.qx;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.lang.ref.WeakReference;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_GET_AUDIO_DEVICE_OPENED_TIME, 115})
public class rh extends com.byazt.pct.n<JSONObject, JSONObject> {
    public WeakReference<com.byazt.omf.d> c;

    public static void c(com.byazt.pct.nu nuVar, com.byazt.omf.d dVar) {
        nuVar.c("getPlayTimeCurrent", (com.byazt.pct.n<?, ?>) new rh(dVar));
    }

    @Override // com.byazt.pct.n
    public JSONObject c(JSONObject jSONObject, com.byazt.pct.a aVar) throws Exception {
        JSONObject jSONObject2 = new JSONObject();
        WeakReference<com.byazt.omf.d> weakReference = this.c;
        if (weakReference != null && weakReference.get() != null) {
            com.byazt.omf.d dVar = this.c.get();
            jSONObject2.put("currentTime", dVar != null ? dVar.or() : 0);
        }
        return jSONObject2;
    }

    public rh(com.byazt.omf.d dVar) {
        this.c = new WeakReference<>(dVar);
    }
}

package com.byazt.qx;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.lang.ref.WeakReference;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_GET_AUDIO_DEVICE_OPENED_TIME, 42})
public class i extends com.byazt.pct.uj<JSONObject, JSONObject> {
    public WeakReference<com.byazt.omf.d> c;

    @Override // com.byazt.pct.uj
    public void uj() {
    }

    public static void c(com.byazt.pct.nu nuVar, final com.byazt.omf.d dVar) {
        nuVar.c("newClickEvent", new com.byazt.pct.uj.tt() { // from class: com.byazt.qx.i.1
            @Override // com.byazt.pct.uj.tt
            public com.byazt.pct.uj c() {
                return new i(dVar);
            }
        });
    }

    public i(com.byazt.omf.d dVar) {
        this.c = new WeakReference<>(dVar);
    }

    @Override // com.byazt.pct.uj
    public void c(JSONObject jSONObject, com.byazt.pct.a aVar) throws Exception {
        com.byazt.omf.d dVar = this.c.get();
        if (dVar == null) {
            ve();
        } else {
            dVar.x(jSONObject);
        }
    }
}

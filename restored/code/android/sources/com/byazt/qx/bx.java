package com.byazt.qx;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.util.HashMap;
import java.util.Iterator;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_GET_AUDIO_DEVICE_OPENED_TIME, 126})
public class bx extends com.byazt.pct.n<JSONObject, JSONObject> {
    public com.byazt.ete.ic c;

    public static void c(com.byazt.pct.nu nuVar, com.byazt.ete.ic icVar) {
        nuVar.c("sendEventCode", (com.byazt.pct.n<?, ?>) new bx(icVar));
    }

    public bx(com.byazt.ete.ic icVar) {
        this.c = icVar;
    }

    @Override // com.byazt.pct.n
    public JSONObject c(JSONObject jSONObject, com.byazt.pct.a aVar) throws Exception {
        com.byazt.ocd.tt ttVar;
        JSONObject jSONObject2 = new JSONObject();
        com.byazt.ete.ic icVar = this.c;
        if (icVar != null && (ttVar = (com.byazt.ocd.tt) com.byazt.omf.rl.c(icVar.rl(), com.byazt.ocd.tt.class)) != null) {
            HashMap map = new HashMap();
            int iOptInt = jSONObject.optInt("event_code", -1);
            if (iOptInt >= 200) {
                JSONObject jSONObjectOptJSONObject = jSONObject.optJSONObject("info");
                if (jSONObjectOptJSONObject != null) {
                    Iterator<String> itKeys = jSONObjectOptJSONObject.keys();
                    while (itKeys.hasNext()) {
                        String next = itKeys.next();
                        map.put(next, jSONObjectOptJSONObject.opt(next));
                    }
                }
                ttVar.c(iOptInt, map);
            }
        }
        return jSONObject2;
    }
}

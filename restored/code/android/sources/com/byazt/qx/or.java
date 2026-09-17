package com.byazt.qx;

import com.byazt.nys.PluginConstants;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_GET_AUDIO_DEVICE_OPENED_TIME, 579})
public class or extends com.byazt.pct.n<JSONObject, JSONObject> {
    public com.byazt.xs.tt c;

    public static void c(com.byazt.pct.nu nuVar, com.byazt.xs.tt ttVar) {
        nuVar.c("RendUgenDownloadDialogState", (com.byazt.pct.n<?, ?>) new or(ttVar));
    }

    @Override // com.byazt.pct.n
    public JSONObject c(JSONObject jSONObject, com.byazt.pct.a aVar) throws Exception {
        c(jSONObject);
        return ve();
    }

    private void c(JSONObject jSONObject) {
        if (jSONObject == null || this.c == null) {
            return;
        }
        int iOptInt = jSONObject.optInt(PluginConstants.KEY_ERROR_CODE);
        if (iOptInt == 200) {
            this.c.c();
        } else {
            this.c.c(iOptInt, jSONObject.optString(MediationConstant.KEY_ERROR_MSG));
        }
    }

    public or(com.byazt.xs.tt ttVar) {
        this.c = ttVar;
    }

    public JSONObject ve() {
        return new JSONObject();
    }
}

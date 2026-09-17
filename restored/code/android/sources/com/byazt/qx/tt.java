package com.byazt.qx;

import com.baidu.mobads.sdk.internal.cb;
import com.byazt.el.SSWebView;
import com.byazt.nys.PluginConstants;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_GET_AUDIO_DEVICE_OPENED_TIME, 13})
public class tt extends com.byazt.pct.n<JSONObject, JSONObject> {
    public SSWebView c;
    public String tt;

    public static void c(com.byazt.pct.nu nuVar, SSWebView sSWebView, String str) {
        nuVar.c("start_twist_observer", (com.byazt.pct.n<?, ?>) new tt(sSWebView, str));
    }

    @Override // com.byazt.pct.n
    public JSONObject c(JSONObject jSONObject, com.byazt.pct.a aVar) throws Exception {
        return ve();
    }

    public tt(SSWebView sSWebView, String str) {
        this.c = sSWebView;
        this.tt = str;
    }

    public JSONObject ve() {
        JSONObject jSONObject = new JSONObject();
        try {
            if (com.byazt.omf.x.m().tt(com.byazt.omf.gt.getContext()) && this.c != null) {
                jSONObject.put(PluginConstants.KEY_ERROR_CODE, 0);
                jSONObject.put("codeMsg", cb.o);
                this.c.c(2, com.byazt.omf.x.m().uj());
                return jSONObject;
            }
            jSONObject.put(PluginConstants.KEY_ERROR_CODE, -1);
            jSONObject.put("codeMsg", "unavailable");
        } catch (Throwable unused) {
        }
        return jSONObject;
    }
}

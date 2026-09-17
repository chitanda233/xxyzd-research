package com.byazt.sz;

import android.content.Context;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_SUB, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_QCOM_LOW_LATENCY})
public class yp {
    public Context c;
    public JSONObject tt;
    public Map<String, Object> uj;
    public JSONObject ve;

    public Context getContext() {
        return this.c;
    }

    public void c(Context context) {
        this.c = context;
    }

    public void c(JSONObject jSONObject) {
        this.tt = jSONObject;
    }

    public JSONObject c() {
        return this.ve;
    }

    public void tt(JSONObject jSONObject) {
        this.ve = jSONObject;
    }

    public Map<String, Object> tt() {
        return this.uj;
    }

    public void c(Map<String, Object> map) {
        this.uj = map;
    }
}

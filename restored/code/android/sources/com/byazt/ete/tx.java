package com.byazt.ete;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 8, MediaPlayer.MEDIA_PLAYER_OPTION_MAX_AV_POS_GAP})
public class tx {
    public boolean c;
    public int tt;

    public tx(JSONObject jSONObject) {
        this.c = jSONObject.optBoolean("enable_reward_callback");
        this.tt = jSONObject.optInt("browse_duration_limit", 10);
    }

    public boolean c() {
        return this.c;
    }

    public int tt() {
        return this.tt;
    }

    public void c(JSONObject jSONObject) {
        JSONObject jSONObject2 = new JSONObject();
        try {
            jSONObject2.put("enable_reward_callback", c());
            jSONObject2.put("browse_duration_limit", tt());
            jSONObject.put("self_reward_callback", jSONObject2);
        } catch (JSONException unused) {
        }
    }
}

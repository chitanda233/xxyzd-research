package com.byazt.ds;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 1480, MediaPlayer.MEDIA_PLAYER_OPTION_LOOP_START_TIME})
public class nu extends ve {
    public nu() {
        super(true, false);
    }

    @Override // com.byazt.ds.ve
    public boolean c(JSONObject jSONObject) throws JSONException {
        jSONObject.put("rom", com.byazt.yv.c.uj());
        return true;
    }
}

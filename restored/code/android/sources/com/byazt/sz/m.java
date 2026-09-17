package com.byazt.sz;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_SUB, MediaPlayer.MEDIA_PLAYER_OPTION_DEFAULT_VIDEO_BITRATE})
public class m {
    public com.byazt.xj.ve c;
    public m n;
    public int tt;
    public m uj;
    public JSONObject ve;

    public com.byazt.xj.ve c() {
        return this.c;
    }

    public void c(com.byazt.xj.ve veVar) {
        this.c = veVar;
    }

    public int tt() {
        return this.tt;
    }

    public void c(int i) {
        this.tt = i;
    }

    public JSONObject ve() {
        return this.ve;
    }

    public void c(JSONObject jSONObject) {
        this.ve = jSONObject;
    }

    public m uj() {
        return this.uj;
    }

    public void c(m mVar) {
        this.uj = mVar;
    }

    public void tt(m mVar) {
        this.n = mVar;
    }

    public String toString() {
        return "UGenEvent{mWidget=" + this.c + ", mEventType=" + this.tt + ", mEvent=" + this.ve + '}';
    }
}

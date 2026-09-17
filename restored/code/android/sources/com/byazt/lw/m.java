package com.byazt.lw;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 2104, MediaPlayer.MEDIA_PLAYER_OPTION_DEFAULT_VIDEO_BITRATE})
public class m implements com.byazt.dr.c {
    public final com.byazt.zg.ve c;

    public m(com.byazt.zg.ve veVar) {
        this.c = veVar;
    }

    @Override // com.byazt.dr.c
    public Object c(Map<String, JSONObject> map) {
        throw new UnsupportedOperationException();
    }

    @Override // com.byazt.dr.c
    public com.byazt.zg.n c() {
        return this.c;
    }

    @Override // com.byazt.dr.c
    public String tt() {
        return this.c.c();
    }

    public String toString() {
        return tt();
    }
}

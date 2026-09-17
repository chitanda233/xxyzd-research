package com.byazt.gqp;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.util.ArrayList;
import java.util.List;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_RENDER_STALL, 46})
public final class n extends z {
    public List<String> c;
    public List<String> tt;

    public n(List<String> list, List<String> list2) {
        this.c = list;
        this.tt = list2;
    }

    @com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_RENDER_STALL, MediaPlayer.MEDIA_PLAYER_OPTION_GET_CONTAINER_FPS})
    public static final class c {
        public final List<String> c = new ArrayList();
        public final List<String> tt = new ArrayList();

        public c c(String str, String str2) {
            this.c.add(str);
            this.tt.add(str2);
            return this;
        }

        public n c() {
            return new n(this.c, this.tt);
        }
    }
}

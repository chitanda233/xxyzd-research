package com.byazt.gj;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes.dex */
public interface n {
    void c(c cVar);

    @com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_GET_VIDEO_OUTPUT_FPS, MediaPlayer.MEDIA_PLAYER_OPTION_GET_CONTAINER_FPS})
    public static final class c {
        public final String c;
        public final boolean tt;
        public final long ve;

        public c(String str, boolean z, long j) {
            this.c = str;
            this.tt = z;
            this.ve = j;
        }
    }
}

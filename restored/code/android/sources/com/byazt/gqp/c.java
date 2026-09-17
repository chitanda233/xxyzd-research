package com.byazt.gqp;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_RENDER_STALL, 20})
public final class c {
    public final boolean c;

    public c(C0132c c0132c) {
        this.c = c0132c.c;
    }

    /* JADX INFO: renamed from: com.byazt.gqp.c$c, reason: collision with other inner class name */
    @com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_RENDER_STALL, 44})
    public static final class C0132c {
        public boolean c;

        public C0132c c() {
            this.c = true;
            return this;
        }

        public c tt() {
            return new c(this);
        }
    }
}

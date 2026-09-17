package com.byazt.di;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_DROP_AUDIO_PTS, 91})
public class sp {
    public static volatile sp c;
    public com.byazt.ou.a tt = null;

    private sp() {
    }

    public static sp c() {
        if (c == null) {
            synchronized (sp.class) {
                if (c == null) {
                    c = new sp();
                }
            }
        }
        return c;
    }

    public com.byazt.ou.a tt() {
        return this.tt;
    }
}

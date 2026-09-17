package com.byazt.pvs;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_DOLBY_PRESENTATION_ID, 20})
public class c {
    public static volatile tt c;

    public static tt c(com.byazt.vb.n nVar) {
        if (c == null) {
            synchronized (tt.class) {
                if (c == null) {
                    c = new ve(new a(nVar), nVar);
                }
            }
        }
        return c;
    }
}

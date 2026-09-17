package com.byazt.jj;

import com.byazt.omf.x;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_GET_CACHE_TIMESTAMP, 13})
public class tt {
    public static boolean c;

    public static void c(boolean z) {
        c = z;
    }

    public static boolean c() {
        if (x.m().lr()) {
            return c;
        }
        return false;
    }
}

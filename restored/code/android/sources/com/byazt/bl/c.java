package com.byazt.bl;

import com.byazt.yj.eo;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_ABR_LOW_THRESHOLD, 20})
public class c {
    public static eo c(int i) {
        return new uj(new tt(i, Integer.MAX_VALUE));
    }

    public static eo c(eo eoVar) {
        return new uj(eoVar);
    }
}

package com.byazt.jb;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.io.IOException;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 63, MediaPlayer.MEDIA_PLAYER_OPTION_DISABLE_ACCURATE_START})
public final class z extends IOException {
    public final tt c;

    public z(tt ttVar) {
        super("stream was reset: ".concat(String.valueOf(ttVar)));
        this.c = ttVar;
    }
}

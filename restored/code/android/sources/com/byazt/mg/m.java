package com.byazt.mg;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 170, MediaPlayer.MEDIA_PLAYER_OPTION_DEFAULT_VIDEO_BITRATE})
public final class m {
    public static Thread c(Runnable runnable, String str) {
        com.byazt.jtc.ve veVar;
        if (runnable == null) {
            return null;
        }
        if (str == null) {
            veVar = new com.byazt.jtc.ve(runnable, "hreadExecutor");
        } else {
            veVar = new com.byazt.jtc.ve(runnable, str);
        }
        veVar.start();
        return veVar;
    }

    public static Thread c(Runnable runnable) {
        return c(runnable, null);
    }
}

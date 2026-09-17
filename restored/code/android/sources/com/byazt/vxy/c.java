package com.byazt.vxy;

import com.byazt.omf.x;
import com.byazt.ut.uj;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_LAZY_SEEK, 20})
public class c {
    public static c c;

    public static c c() {
        if (c == null) {
            synchronized (c.class) {
                if (c == null) {
                    c = new c();
                }
            }
        }
        return c;
    }

    public com.byazt.dna.c c(String str) {
        return uj.getAppContext(str);
    }

    public static String tt() {
        return x.m().rl();
    }

    public static String ve() {
        return x.m().rl();
    }

    public static String uj() {
        return x.m().rl();
    }

    public static com.byazt.dna.c n() {
        return uj.getAppContext(uj());
    }
}

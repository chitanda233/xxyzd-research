package com.byazt.ktv;

import com.byazt.omf.gt;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.util.Random;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_REUSE_SOCKET, 13})
public class tt {
    public static volatile Random c = null;
    public static volatile boolean tt = false;

    public static boolean c() {
        return tt;
    }

    public static void tt() {
        c(gt.tt().kk(), true);
    }

    public static boolean c(float f, boolean z) {
        if (f <= 0.0f) {
            if (z) {
                tt = false;
            }
            return false;
        }
        int iNextInt = ve().nextInt(10000);
        int i = (int) (f * 10000.0f);
        if (z) {
            tt = iNextInt < i;
        }
        return iNextInt < i;
    }

    private static Random ve() {
        if (c != null) {
            return c;
        }
        Random randomVe = com.byazt.nr.c.ve();
        c = randomVe;
        return randomVe;
    }
}

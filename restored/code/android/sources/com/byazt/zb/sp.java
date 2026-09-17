package com.byazt.zb;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_HW_CONTROL_BY_OPPO, 91})
public class sp {
    public static c c;

    public interface c {
        void c(String str, String str2, Throwable th);
    }

    public static void c(c cVar) {
        c = cVar;
    }

    public static boolean c() {
        return c != null;
    }

    public static void c(String str, String str2, Throwable th) {
        if (c == null) {
            return;
        }
        if (th == null) {
            th = new Throwable();
        }
        c.c(str, str2, th);
    }
}

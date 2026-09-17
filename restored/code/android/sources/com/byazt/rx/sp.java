package com.byazt.rx;

import android.os.Handler;
import android.os.HandlerThread;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_GET_CLOCK_DIFF, 91})
public class sp {
    public static volatile HandlerThread c;
    public static volatile Handler tt;
    public static volatile Handler ve;

    public static HandlerThread c() {
        if (c == null) {
            synchronized (sp.class) {
                if (c == null) {
                    HandlerThread handlerThread = new HandlerThread("default_npth_thread");
                    c = handlerThread;
                    handlerThread.start();
                    tt = new Handler(c.getLooper());
                }
            }
        }
        return c;
    }

    public static Handler tt() {
        if (tt == null) {
            c();
        }
        return tt;
    }
}

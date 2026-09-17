package com.byazt.nr;

import android.text.TextUtils;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_AUDIO_REND_FIRST_FRAME_TIME, MediaPlayer.MEDIA_PLAYER_OPTION_SINGLE_PLAY_DOWNLOAD_BYTES})
public class my {
    public static void c(Object obj, String str) {
        if (obj == null) {
            tt(str);
        }
    }

    public static void c(String str, String str2) {
        if (TextUtils.isEmpty(str)) {
            tt(str2);
        }
    }

    public static void c(boolean z, String str) {
        if (z) {
            return;
        }
        tt(str);
    }

    public static void c(String str) {
        tt(str);
    }

    private static void tt(String str) {
        throw new IllegalArgumentException(str);
    }
}

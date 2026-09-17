package com.byazt.vx;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 962, MediaPlayer.MEDIA_PLAYER_OPTION_DEFAULT_VIDEO_BITRATE})
public class m {
    public static String c(int[] iArr) {
        if (iArr == null || iArr.length == 0) {
            return null;
        }
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < iArr.length; i++) {
            sb.append(iArr[i]);
            if (i != iArr.length - 1) {
                sb.append(",");
            }
        }
        return sb.toString();
    }
}

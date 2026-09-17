package com.byazt.m;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_DEFAULT_VIDEO_BITRATE, 91})
public class sp extends BaseException {
    public sp(int i, String str) {
        super(i, str);
    }

    public sp c(String str) {
        setExtraInfo(str);
        return this;
    }

    public String c() {
        return getExtraInfo();
    }
}

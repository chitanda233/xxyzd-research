package com.byazt.m;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_DEFAULT_VIDEO_BITRATE, 15})
public class uj extends BaseException {
    public final long c;
    public final long tt;

    public uj(long j, long j2) {
        super(1006, String.format("space is not enough required space is : %s but available space is :%s", String.valueOf(j2), String.valueOf(j)));
        this.c = j;
        this.tt = j2;
    }

    public long c() {
        return this.c;
    }

    public long tt() {
        return this.tt;
    }
}

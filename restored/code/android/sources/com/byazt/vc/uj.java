package com.byazt.vc;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_AVFORMAT_OPEN_TIME, 15})
public class uj {
    public float c;
    public float tt;

    public uj(float f, float f2) {
        this.c = f;
        this.tt = f2;
    }

    public uj() {
        this(1.0f, 1.0f);
    }

    public float c() {
        return this.c;
    }

    public float tt() {
        return this.tt;
    }

    public void c(float f, float f2) {
        this.c = f;
        this.tt = f2;
    }

    public boolean tt(float f, float f2) {
        return this.c == f && this.tt == f2;
    }

    public String toString() {
        return c() + "x" + tt();
    }
}

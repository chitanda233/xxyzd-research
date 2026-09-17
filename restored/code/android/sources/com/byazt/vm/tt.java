package com.byazt.vm;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_SUPER_RES_OPTION, 13})
public abstract class tt<T> {
    public volatile T c;

    public abstract T c(Object... objArr);

    public final T tt(Object... objArr) {
        if (this.c == null) {
            synchronized (this) {
                if (this.c == null) {
                    this.c = c(objArr);
                }
            }
        }
        return this.c;
    }
}

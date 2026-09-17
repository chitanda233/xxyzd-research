package com.byazt.gqp;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.io.Closeable;
import java.io.IOException;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_RENDER_STALL, MediaPlayer.MEDIA_PLAYER_OPTION_DEFAULT_VIDEO_BITRATE})
public abstract class m implements Closeable {
    public abstract nu a();

    public abstract long c();

    public abstract String c(String str);

    public abstract String c(String str, String str2);

    @Override // java.io.Closeable, java.lang.AutoCloseable
    public abstract void close();

    public abstract String n() throws IOException;

    public abstract a sp();

    public abstract long tt();

    public abstract boolean uj();

    public abstract int ve();

    public abstract sl x();
}

package com.byazt.mk;

import android.support.v4.media.session.PlaybackStateCompat;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_POSITION_UPDATE_INTERVAL, MediaPlayer.MEDIA_PLAYER_OPTION_DEFAULT_VIDEO_BITRATE})
public final class m {
    public static z c;
    public static long tt;

    private m() {
    }

    public static z c() {
        synchronized (m.class) {
            z zVar = c;
            if (zVar != null) {
                c = zVar.f1173a;
                zVar.f1173a = null;
                tt -= PlaybackStateCompat.ACTION_PLAY_FROM_URI;
                return zVar;
            }
            return new z();
        }
    }

    public static void c(z zVar) {
        if (zVar.f1173a != null || zVar.sp != null) {
            throw new IllegalArgumentException();
        }
        if (zVar.uj) {
            return;
        }
        synchronized (m.class) {
            long j = tt;
            if (j + PlaybackStateCompat.ACTION_PLAY_FROM_URI > PlaybackStateCompat.ACTION_PREPARE_FROM_SEARCH) {
                return;
            }
            tt = j + PlaybackStateCompat.ACTION_PLAY_FROM_URI;
            zVar.f1173a = c;
            zVar.ve = 0;
            zVar.tt = 0;
            c = zVar;
        }
    }
}
